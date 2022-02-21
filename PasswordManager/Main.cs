namespace PasswordManager
{
    using CsvHelper;
    using Dtos;
    using Models.IdentityData;
    using Services.Users;
    using Persistance;
    using Services.IdentityDatas;

    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        public async void Main_Load(object sender, EventArgs e)
        {

            var dbContext = new PasswordManagerDbContext();
            var userService = new UserSqlService(dbContext);

            var password = await userService.Get(1);

            var isPasswordExist = false;

            if(password != null)
            {
                isPasswordExist = true;
            }

            if (!isPasswordExist)
            {
                var savePassword = new SavePassword();
                savePassword.ShowDialog(this);
            }

            await this.LoadInitialData();

        }
        public async Task LoadInitialData()
        {
            var dbContext = new PasswordManagerDbContext();
            var identityDataService = new IdentityDataSqlService(dbContext);

            var data = await identityDataService.GetAll();
            var identityDatas = data.ToList();

            listView1.Items.Clear();

            for (int i = 0; i < identityDatas.Count(); i++)
            {
                var identityData = identityDatas[i];

                var row = new string[] { identityData.WebSite, identityData.UserName, identityData.Id.ToString() };

                var listViewItem = new ListViewItem(row);

                listView1.Items.Add(listViewItem);
            }

            TotalResultsLabel.Text = identityDatas.Count.ToString();
            SearchTextBox.Text = "";
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void ExportFromCsvButton_Click(object sender, EventArgs e)
        {
            var size = -1;
            var openFileDialog1 = new OpenFileDialog();
            var result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string file = openFileDialog1.FileName;
                try
                {
                    var text = File.ReadAllText(file);
                    size = text.Length;
                }
                catch (IOException)
                {
                }
            }

            var fileName = openFileDialog1.FileName;

            var data = new List<IdentityDataCsvDto>();

            using (var reader = new StreamReader(fileName))
            using (var csv = new CsvReader(reader, System.Globalization.CultureInfo.CurrentCulture))
            {
                data = csv.GetRecords<IdentityDataCsvDto>().ToList();
            }

            var dbContext = new PasswordManagerDbContext();
            var identityDataService = new IdentityDataSqlService(dbContext);

            MessageBox.Show("This operation might take a few minutes please stand by!");

            foreach (var item in data)
            {
                var identityData = new IdentityData(item.WebSite, item.Username, item.Password);

                await identityDataService.Create(identityData);
            }
        }

        private async void SearchButton_Click(object sender, EventArgs e)
        {
            var searchString = SearchTextBox.Text;

            if (string.IsNullOrEmpty(searchString))
            {
                MessageBox.Show("Search input is invalid try again!");
                return;
            }

            var dbContext = new PasswordManagerDbContext();
            var identityDataService = new IdentityDataSqlService(dbContext);

            var data = await identityDataService.GetAll();
            var identityDatas = data
                .Where(d => d.WebSite.Contains(searchString) ||
                d.UserName.Contains(searchString))
                .ToList();

            listView1.Items.Clear();

            for (int i = 0; i < identityDatas.Count(); i++)
            {
                var identityData = identityDatas[i];

                var row = new string[] { identityData.WebSite, identityData.UserName, identityData.Id.ToString() };

                var listViewItem = new ListViewItem(row);

                listView1.Items.Add(listViewItem);
            }

            this.TotalResultsLabel.Text = identityDatas.Count.ToString();
        }

        private async void ClearSearchButton_Click(object sender, EventArgs e)
        {
            await this.LoadInitialData();
        }

        private async void listView1_DoubleClick(object sender, EventArgs e)
        {
            var firstSelectedItem = listView1.SelectedItems[0];
            var secondSelectedItem = firstSelectedItem.SubItems[2];
            var id = Convert.ToInt32(secondSelectedItem.Text);

            var dbContext = new PasswordManagerDbContext();
            var identityDataService = new IdentityDataSqlService(dbContext);

            var identityData = await identityDataService.Get(id);

            var details = new Details(identityData);
            details.Show(this);
        }

        private void SetMasterPasswordButton_Click(object sender, EventArgs e)
        {

        }
    }
}
