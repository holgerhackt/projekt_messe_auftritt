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
using AutoMapper;
using Microsoft.Data.Sqlite;


namespace WebcamApp
{
    public partial class UserManager : Form
    {
        private readonly OfflineContext _context = new OfflineContext();
        private readonly IMapper _mapper;
        public UserManager()
        {
            InitializeComponent();
            _mapper = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AutoMapperProfile>();
            }).CreateMapper();
            FillDataSource();
        }
        private void FillDataSource()
        {
            UserTabelle.AutoGenerateColumns = false;
            BindingSource bs = new BindingSource();
            UserTabelle.DataSource = bs;

            List<DataGridUser> dataGridUsers = _mapper.Map<List<DataGridUser>>(_context.Users
                .Include(u => u.Address)
                .Include(u => u.Company)
                .ThenInclude(ca => ca!.Address)
                .ToList());
            bs.DataSource = dataGridUsers;
        }


        private void UserTabelle_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < UserTabelle.Rows.Count)
            {
                var dataBoundItem = UserTabelle.Rows[e.RowIndex].DataBoundItem;

                if (dataBoundItem is DataGridUser dataGridUser)
                {
                    var userInDb = _context.Users.FirstOrDefault(u => u.Id == dataGridUser.Id);
                    var updatedUser = _mapper.Map<User>(dataGridUser);
                    _context.Users.Remove(userInDb);
                    _context.SaveChanges();
                    
                    if(dataGridUser.AddressId != null)
                    {
                        Address addressInDb = _context.Addresses.FirstOrDefault(a => a.Id == dataGridUser.AddressId);
                        _context.Addresses.Remove(addressInDb);
                        _context.SaveChanges();
                        updatedUser.Address.Id = 0;
                        updatedUser.AddressId = 0;
                    }
                    if(dataGridUser.CompanyId != null)
                    {
                        Company companyInDb = _context.Company.FirstOrDefault(c => c.Id == dataGridUser.CompanyId);
                        _context.Company.Remove(companyInDb);
                        _context.Addresses.Remove(companyInDb.Address);
                        _context.SaveChanges();
                        updatedUser.Company.Id = 0;
                        updatedUser.CompanyId = 0;
                    }
                    _context.Users.Add(updatedUser);
                    _context.SaveChanges();
                }
            }

        }

        private void UserTabelle_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            var dataGridUser = (DataGridUser)e.Row.DataBoundItem;
            var entityToDelete = _context.Users.Find(dataGridUser.Id);
            if (entityToDelete != null)
            {
                _context.Users.Remove(entityToDelete);
                _context.SaveChanges();
            }
        }
        public bool IsAddressChanged(DataGridUser dataGridUser, User user)
        {
            if (user.Address == null || dataGridUser.AddressId == 0)
            {
                return false;
            }

            return user.Address.Country != dataGridUser.Country ||
                   user.Address.City != dataGridUser.City ||
                   user.Address.PostalCode != dataGridUser.PostalCode ||
                   user.Address.Street != dataGridUser.Street ||
                   user.Address.HouseNumber != dataGridUser.HouseNumber;
        }

    }
}
