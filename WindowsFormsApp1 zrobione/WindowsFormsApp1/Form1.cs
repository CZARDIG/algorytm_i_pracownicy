using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private string generatedPassword;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int passwordLength;
            int.TryParse(textBox3.Text, out passwordLength);
            bool includeUppercase = false;
            bool includeDigits = false;
            bool includeSpecialChars = false;

            if(checkBox1.Checked)
            {
                includeUppercase = true;
            }
            if (checkBox2.Checked)
            {
                includeDigits = true;
            }
            if (checkBox3.Checked)
            {
                includeSpecialChars = true;
            }
            generatedPassword = GeneratePassword(passwordLength, includeUppercase, includeDigits, includeSpecialChars);
            MessageBox.Show(generatedPassword);
        }

        static string GeneratePassword(int passwordLength, bool includeUppercase, bool includeDigits, bool includeSpecialChars)
        {
            const string lowercaseLetters = "abcdefghijklmnopqrstuvwxyz";
            const string uppercaseLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string digits = "0123456789";
            const string specialChars = "!@#$%^&*()_-+=";

            StringBuilder characterSet = new StringBuilder(lowercaseLetters);
            if (includeUppercase)
            {
                characterSet.Append(uppercaseLetters);
            }
            if (includeDigits)
            {
                characterSet.Append(digits);
            }
            if (includeSpecialChars)
            {
                characterSet.Append(specialChars);
            }

            Random random = new Random();
            StringBuilder password = new StringBuilder();

            if (includeUppercase)
            {
                password.Append(uppercaseLetters[random.Next(uppercaseLetters.Length)]);
            }
            if (includeDigits)
            {
                password.Append(digits[random.Next(digits.Length)]);
            }
            if (includeSpecialChars)
            {
                password.Append(specialChars[random.Next(specialChars.Length)]);
            }

            for (int i = password.Length; i <= passwordLength; i++)
            {
                password.Append(characterSet[random.Next(lowercaseLetters.Length)]);
            }

            return password.ToString();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dane Pracownika: " + textBox1.Text + " " + textBox2.Text + " " + comboBox1.Text + " Hasło: " + generatedPassword);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
