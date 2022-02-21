namespace PasswordManager.Models.Users
{
    using Models.Exceptions;

    public class User
    {
        internal User(int id, string password)
        {
            this.Validate(password);

            this .Id = id;
            this.Password = password;
        }
        private User()
        {
            this.Password = default!;
        }

        public int Id { get; set; }

        public string Password { get; private set; }

        public User UpdatePassword(string password)
        {
            this.ValidatePassword(password);
            this.Password = password;
            return this;
        }

        private void Validate(string password)
        {
            this.ValidatePassword(password);
        }

        private void ValidatePassword(string password)
        {
            var validLenght = 3;

            if (string.IsNullOrEmpty(password))
            {
                throw new InvalidUserException(nameof(this.Password) + " is null or empty");
            }
            if (password.Length <= validLenght)
            {
                throw new InvalidUserException(nameof(this.Password) + $" length of {password.Length} is not valid. Valid length is {validLenght}");
            }
        }
    }
}
