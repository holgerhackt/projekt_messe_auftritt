using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WebcamApp;

public class InputFieldValidator
{
    private readonly Regex _cityRegex = new(@"^[A-Za-zÀ-ÖØ-öø-ÿ\s-]+$");
    private readonly Regex _countryRegex = new("^[a-zA-Z]+$"); // Only lower and upper case letters are allowed
    private readonly Regex _emailRegex = new(@"^[^@\s]+@[^@\s]+\.[A-Za-z]+$");
    private readonly Regex _houseNumberRegex = new(@"^\d+[a-zA-Z]?$");
    private readonly Regex _userNameRegex = new(@"^[A-Za-z]+([- ]?[A-Za-z]+)?$");

    public bool ValidateUsername(string forename, string lastname) // Return true if username is valid
    {
        return _userNameRegex.IsMatch(forename) && _userNameRegex.IsMatch(lastname);
    }


    public bool
        IsAnyAddressPropertyFilled(Panel panel,
            HashSet<string> excludedTextBoxNames) // Return true if any address property is filled
    {
        foreach (var textBox in panel.Controls.OfType<TextBox>())
            if (!excludedTextBoxNames.Contains(textBox.Name) && !string.IsNullOrWhiteSpace(textBox.Text))
                return true;
        return false;
    }

    public string? ValidateTextBoxContent(Panel panel, string countryTextBox, string houseNumberTextBox,
        string? emailTextBox, string cityTextBox) // Return a list of missing or invalid fields
    {
        var invalidStringFields = new List<string>();
        string? invalidHouseNumber = null;
        string? invalidEmail = null;
        string? errorMessage = null;

        foreach (var textBox in panel.Controls.OfType<TextBox>())
            if (textBox.Name == countryTextBox && !string.IsNullOrWhiteSpace(textBox.Text) &&
                !_countryRegex.IsMatch(textBox.Text))
                invalidStringFields.Add(textBox.Tag.ToString()!);
            else if (textBox.Name == houseNumberTextBox && !string.IsNullOrWhiteSpace(textBox.Text) &&
                     !_houseNumberRegex.IsMatch(textBox.Text))
                invalidHouseNumber = "Please enter a valid house number!";
            else if (emailTextBox != null && textBox.Name == emailTextBox && !string.IsNullOrWhiteSpace(textBox.Text) &&
                     !_emailRegex.IsMatch(textBox.Text))
                invalidEmail = "Please enter a valid email address!";
            else if (textBox.Name == cityTextBox && !string.IsNullOrWhiteSpace(textBox.Text) &&
                     !_cityRegex.IsMatch(textBox.Text)) invalidStringFields.Add(textBox.Tag.ToString()!);

        List<string> errorMessages = new();
        if (invalidStringFields.Any())
            errorMessages.Add(
                $"Please enter valid string literals (only alphabets) for the following fields: {string.Join(", ", invalidStringFields)}");
        if (invalidEmail != null)
            errorMessages.Add(invalidEmail);
        if (invalidHouseNumber != null)
            errorMessages.Add(invalidHouseNumber);
        if (errorMessages.Any())
            errorMessage = string.Join("\n", errorMessages);
        return errorMessage;
    }
}