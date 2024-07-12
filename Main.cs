using System.Security.Cryptography;
using System.Text;

namespace PasswordHashGenerator
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        public (byte[], byte[]) CreatePassword(string password)
        {
            byte[] passwordHash, passwordKey;

            using (var hmac = new HMACSHA512())
            {
                passwordKey = hmac.Key;
                passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));

            }
            return (passwordHash, passwordKey);
        }

        public bool MatchPasswordHash(string passwordText, byte[] password, byte[] passwordKey)
        {
            using (var hmac = new HMACSHA512(passwordKey))
            {
                var passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(passwordText));

                for (int i = 0; i < passwordHash.Length; i++)
                {
                    if (passwordHash[i] != password[i])
                        return false;
                }

                return true;
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            string inputPassword = password.Text.ToString();
            if (inputPassword.Length >= 8)
            {
                var (generatedHash, generatedkey) = CreatePassword(inputPassword);
                passwordHash.Text = Convert.ToBase64String(generatedHash);
                passwordKey.Text = Convert.ToBase64String(generatedkey);
                MessageBox.Show("Password hash and key generated!", "Success");
            }
            else
            {
                MessageBox.Show("Your password must be greater than 8 characters!", "Error!");
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = true;
            button3.Visible = true;
            updateBtn.Enabled = false;
            passwordHash.ReadOnly = false;
            passwordKey.ReadOnly = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string inputPassword = password.Text.ToString();
            string hashToMacth = passwordHash.Text.ToString();
            string keyToMatch = passwordKey.Text.ToString();
            if (inputPassword != "" && hashToMacth != "" & keyToMatch != "")
            {
                bool matchedPassword = MatchPasswordHash(
                inputPassword,
                Convert.FromBase64String(hashToMacth),
                Convert.FromBase64String(keyToMatch));
                if (!matchedPassword)
                {
                    MessageBox.Show("Password hash and key do not correspond to password!", "Error!");
                    return;
                }
                else
                {
                    MessageBox.Show("Password hash and key corresponds to password!", "Success!");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please provide valid input", "Error!");
                return;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            passwordHash.ReadOnly = true;
            passwordKey.ReadOnly = true;
            button1.Visible = true;
            button2.Visible = false;
            button3.Visible = false;
            updateBtn.Enabled = true;
        }
    }
}