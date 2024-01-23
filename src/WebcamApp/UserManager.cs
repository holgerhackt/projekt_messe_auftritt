using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Models;
using WebcamApp.OfflineDB;
using System.Threading;

namespace WebcamApp
{
    public partial class UserManager : Form
    {
        private readonly OfflineContext _context = new OfflineContext();
        public UserManager()
        {
            InitializeComponent();
            FillDataSource();
        }
        private void FillDataSource()
        {
            UserTabelle.AllowUserToAddRows = false; //Data can only be added via the main app
            _context.Users.Load(); //Necessary to load the data from the database
            UserTabelle.DataSource = _context.Users.Local.ToBindingList();
            SetupCompanyComboBox();
            var sensitiveColumns = new HashSet<string> { "Id", "AddressId", "Image", "CompanyId" };
            SetupReadonlyColumns(sensitiveColumns);
            HideColumns(sensitiveColumns);
        }
        private void SetupCompanyComboBox()
        {
            DataGridViewComboBoxColumn comboColumn = new DataGridViewComboBoxColumn();
            comboColumn.HeaderText = "Company";
            comboColumn.DataPropertyName = "CompanyId"; 

            var companies = _context.Company.ToList();
            comboColumn.DataSource = companies;
            comboColumn.DisplayMember = "Name";
            comboColumn.ValueMember = "Id";
            
            int columnIndex = UserTabelle.Columns["Company"].Index; 
            UserTabelle.Columns[columnIndex].Visible = false;
            UserTabelle.Columns.Insert(columnIndex, comboColumn);

        }

        private void SetupReadonlyColumns(HashSet<string> readonlyColumns)
        {
            foreach (DataGridViewColumn column in UserTabelle.Columns)
            {
                if (readonlyColumns.Contains(column.Name))
                {
                    column.ReadOnly = true;
                }
            }
        }
        private void HideColumns(HashSet<string> hiddenColumns)
        {
            foreach (DataGridViewColumn column in UserTabelle.Columns)
            {
                if (hiddenColumns.Contains(column.Name))
                {
                    column.Visible = false;
                }
            }
        }

        private void UserTabelle_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            _context.SaveChanges();
        }

        private void UserTabelle_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
                var entityToDelete = (User)e.Row.DataBoundItem;
                _context.Users.Remove(entityToDelete);
                _context.SaveChanges(); // Because of the binding list, the changes are automatically reflected in the UI
        }
    }
}
