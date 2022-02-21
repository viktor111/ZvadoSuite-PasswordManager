namespace PasswordManager
{
    using Models.IdentityData;
    using Services.IdentityDatas;
    using Persistance;
    using Services.Users;

    public partial class Details : Form
    {
        private readonly IdentityData identityData;

        public Details(IdentityData identityData)
        {
            this.identityData = identityData;
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private async void EditButton_Click(object sender, EventArgs e)
        {
            var dbContext = new PasswordManagerDbContext();
            var userService = new UserSqlService(dbContext);
            var identityService = new IdentityDataSqlService(dbContext);

            var masterPassword = await userService.Get(1);
            var inputPassword = MasterPasswordTextBox.Text;

            if (masterPassword.Password != inputPassword)
            {
                MessageBox.Show("Master password incorrect!");
                return;
            }

            if (string.IsNullOrEmpty(WebPasswordTextBox.Text))
            {
                MessageBox.Show("Edit password is invalid!");
            }

            var newData = this.identityData.UpdatePassword(WebPasswordTextBox.Text);

            await identityService.Update(newData);


            var main = Owner as Main;

            main.Main_Load(sender, e);
            this.Close();
        }

        private async void RevealPasswordButton_Click(object sender, EventArgs e)
        {
            var dbContext = new PasswordManagerDbContext();
            var userService = new UserSqlService(dbContext);

            var masterPassword = await userService.Get(1);          

            var inputPassword = MasterPasswordTextBox.Text;

            if(masterPassword.Password != inputPassword)
            {
                MessageBox.Show("Master password incorrect!");
                return;
            }

            WebPasswordTextBox.Text = identityData.Password;
        }

        private async void DeleteButton_Click(object sender, EventArgs e)
        {
            var dbContext = new PasswordManagerDbContext();
            var identityDataService = new IdentityDataSqlService(dbContext);

            await identityDataService.Delete(this.identityData.Id);

            var main = Owner as Main;

            main.Main_Load(sender, e);
            this.Close();
        }

        private void Details_Load(object sender, EventArgs e)
        {

        }
    }
}
