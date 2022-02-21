namespace PasswordManager.Models.IdentityData
{
    using Models.Exceptions;

    public class IdentityData
    {
        internal IdentityData(string website, string userName, string password)
        {
            this.Validate(website, userName, password);

            this.WebSite = website;
            this.UserName = userName;
            this.Password = password;
            this.CreatedDate = DateTime.Now;
        }

        private IdentityData()
        {
            this.WebSite = default!;
            this.UserName = default!;
            this.Password = default!;
            this.CreatedDate = DateTime.Now;
        }

        public int Id { get; set; }

        public string WebSite{ get; set; }

        public string UserName { get; private set; }

        public string Password { get; private set; }

        public DateTime CreatedDate { get; set; }

        public IdentityData UpdateUserName(string userName)
        {
            this.ValidateUserName(userName);
            this.UserName = userName;
            return this;
        }

        public IdentityData UpdatePassword(string password)
        {
            this.ValidatePassword(password);
            this.Password= password;
            return this;
        }

        private void Validate(string website, string userName, string password)
        {
            this.ValidateWebSite(website);
            this.ValidateUserName(userName);
            this.ValidatePassword(password);
        }

        private void ValidateWebSite(string website)
        {
            if (website == null)
            {
                throw new InvalidIdentityDataException(nameof(this.WebSite) + " is null or empty");
            }
        }

        private void ValidateUserName(string userName)
        {
            if (userName == null)
            {
                throw new InvalidIdentityDataException(nameof(this.UserName) + " is null or empty");
            }
        }

        private void ValidatePassword(string password)
        {
            if (password == null)
            {
                throw new InvalidIdentityDataException(nameof(this.Password) + " is null or empty");
            }
        }
    }
}

