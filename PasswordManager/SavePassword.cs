using PasswordManager.Models.Users;
using PasswordManager.Persistance;
using PasswordManager.Services.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordManager
{
    public partial class SavePassword : Form
    {
        public SavePassword()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private async void SaveMasterPasswordButton_Click(object sender, EventArgs e)
        {
            var passwordInput = MasterPasswordTextBox.Text;

            if (string.IsNullOrEmpty(passwordInput))
            {
                MessageBox.Show("Password is invalid!");
                return;
            }
            
            var dbContext = new PasswordManagerDbContext();
            var userService = new UserSqlService(dbContext);

            var password = await userService.Get(1);

            if(password != null)
            {
                await userService.Delete(1);
            }

            await userService.Create(new User(1, passwordInput));

            var filePath = "../../../s.txt";
            var file = File.CreateText(filePath);
            file.Write("true");
            file.Close();

            var main = Owner as Main;
            main.Show();
            this.Close();
        }
    }
}
