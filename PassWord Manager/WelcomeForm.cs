using System;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Linq;

namespace PassWord_Manager
{
    public partial class WelcomeForm : Form
    {
        XmlSerializer xmlSerializer;
        List<Records> recList;
        Label accsiteLBL = new Label();
        TextBox accsiteTB = new TextBox();
        Button saveBTN = new Button();
        Label mailLBL = new Label();
        TextBox mailTB = new TextBox();
        string mail= "";
        string address = "";
        string pass = "";
        public WelcomeForm()
        {
            InitializeComponent();
            recList = new List<Records>();
            xmlSerializer = new XmlSerializer(typeof(List<Records>));
        }

        private void generatePasswordBTN_Click(object sender, EventArgs e)
        {
            generatePasswordBTN.Visible = encryptPasswordBTN.Visible = decryptPasswordBTN.Visible = false;
            ExitBTN.Location = new Point (ExitBTN.Location.X + 150, ExitBTN.Location.Y + 250);
            requirementGB.Visible = true;
            requirementGB.Location = new Point(requirementGB.Location.X, requirementGB.Location.Y - 150);
        }

        private void encryptPasswordBTN_Click(object sender, EventArgs e)
        {
            generatePasswordBTN.Visible = encryptPasswordBTN.Visible = decryptPasswordBTN.Visible = false;
            ExitBTN.Location = new Point(ExitBTN.Location.X + 150, ExitBTN.Location.Y + 250);
            passwordTB.Visible = PassisLBL.Visible = EncBTN.Visible = KeyLBL.Visible = KeyTb.Visible = true;
        }

        private void decryptPasswordBTN_Click(object sender, EventArgs e)
        {
            requirementGB.Visible = PassisLBL.Visible = passwordTB.Visible = EncLBL.Visible = EncTB.Visible = EncBTN.Visible = DecLBL.Visible = DecTB.Visible = DecBTN.Visible = KeyLBL.Visible = KeyTb.Visible = false;
            DecBTN.Visible = KeyLBL.Visible = KeyTb.Visible = EncTB.Visible = EncLBL.Visible = true;
            EncTB.Location = passwordTB.Location;
            EncLBL.Location = PassisLBL.Location;
            DecLBL.Location = new Point(DecLBL.Location.X, DecLBL.Location.Y - 30);
            DecTB.Location = new Point(DecTB.Location.X, DecTB.Location.Y - 30);
            DecBTN.Location = EncBTN.Location;
        }

        private void ExitBTN_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void WelcomeForm_Load(object sender, EventArgs e)
        {
            this.Controls.Clear();
            InitializeComponent();
            requirementGB.Visible = PassisLBL.Visible = passwordTB.Visible = EncLBL.Visible = EncTB.Visible = EncBTN.Visible = DecLBL.Visible = DecTB.Visible = DecBTN.Visible = KeyLBL.Visible = KeyTb.Visible = false;
            generatePasswordBTN.Visible = encryptPasswordBTN.Visible = decryptPasswordBTN.Visible = ExitBTN.Visible = true;
        }

        private void GenerateBTN_Click(object sender, EventArgs e)
        {
            //https://codeshare.co.uk/blog/how-to-create-a-random-password-generator-in-c/
            string password = "";

            passwordTB.Text = "";

            try
            {
                password = GeneratePassword(SLCB.Checked, CLCB.Checked, NCB.Checked, SCCB.Checked, (int)PasswordLengthUD.Value);
                while (!PasswordIsValid(SLCB.Checked, CLCB.Checked, NCB.Checked, SCCB.Checked, password))
                {
                    password = GeneratePassword(SLCB.Checked, CLCB.Checked, NCB.Checked, SCCB.Checked, (int)PasswordLengthUD.Value);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            PassisLBL.Visible = passwordTB.Visible = EncBTN.Visible = DecBTN.Visible = KeyLBL.Visible = KeyTb.Visible = true;
            DecBTN.Visible = false;
            passwordTB.Text = password.ToString();
        }

        public static string GeneratePassword(bool includeLowercase, bool includeUppercase, bool includeNumeric, bool includeSpecial, int lengthOfPassword)
        {
            const int MAXIMUM_IDENTICAL_CONSECUTIVE_CHARS = 1;
            const string LOWERCASE_CHARACTERS = "abcdefghijklmnopqrstuvwxyz";
            const string UPPERCASE_CHARACTERS = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string NUMERIC_CHARACTERS = "0123456789";
            const string SPECIAL_CHARACTERS = @"!#$%&*@\";
            const int PASSWORD_LENGTH_MIN = 4;
            const int PASSWORD_LENGTH_MAX = 128;

            if (lengthOfPassword < PASSWORD_LENGTH_MIN || lengthOfPassword > PASSWORD_LENGTH_MAX)
            {
                return "Password length must be between 4 and 128.";
            }

            string characterSet = "";

            if (includeLowercase)
            {
                characterSet += LOWERCASE_CHARACTERS;
            }

            if (includeUppercase)
            {
                characterSet += UPPERCASE_CHARACTERS;
            }

            if (includeNumeric)
            {
                characterSet += NUMERIC_CHARACTERS;
            }

            if (includeSpecial)
            {
                characterSet += SPECIAL_CHARACTERS;
            }

            char[] password = new char[lengthOfPassword];
            int characterSetLength = characterSet.Length;

            System.Random random = new System.Random();
            for (int characterPosition = 0; characterPosition < lengthOfPassword; characterPosition++)
            {
                password[characterPosition] = characterSet[random.Next(characterSetLength - 1)];

                bool moreThanTwoIdenticalInARow = characterPosition > MAXIMUM_IDENTICAL_CONSECUTIVE_CHARS && password[characterPosition] == password[characterPosition - 1];

                if (moreThanTwoIdenticalInARow)
                {
                    characterPosition--;
                }
            }
            return string.Join(null, password);
        }

        public static bool PasswordIsValid(bool includeLowercase, bool includeUppercase, bool includeNumeric, bool includeSpecial, string password)
        {
            const string REGEX_LOWERCASE = @"[a-z]";
            const string REGEX_UPPERCASE = @"[A-Z]";
            const string REGEX_NUMERIC = @"[\d]";
            const string REGEX_SPECIAL = @"([!#$%&*@\\])+";

            bool lowerCaseIsValid = !includeLowercase || (includeLowercase && Regex.IsMatch(password, REGEX_LOWERCASE));
            bool upperCaseIsValid = !includeUppercase || (includeUppercase && Regex.IsMatch(password, REGEX_UPPERCASE));
            bool numericIsValid = !includeNumeric || (includeNumeric && Regex.IsMatch(password, REGEX_NUMERIC));
            bool symbolsAreValid = !includeSpecial || (includeSpecial && Regex.IsMatch(password, REGEX_SPECIAL));

            return lowerCaseIsValid && upperCaseIsValid && numericIsValid && symbolsAreValid;
        }

        private void EncBTN_Click(object sender, EventArgs e)
        {
            //https://www.c-sharpcorner.com/blogs/encrypt-and-decrypt-a-string-in-asp-net1
            EncTB.Visible = EncLBL.Visible = DecBTN.Visible = KeyTb.Enabled = KeyLBL.Enabled = true;
            EncTB.Text = encrypt(passwordTB.Text, KeyTb.Text);
            //byte[] b = System.Text.ASCIIEncoding.ASCII.GetBytes(strEncrypted);
            //string encrypted = Convert.ToBase64String(b);
            //return encrypted;
        }

        private void DecBTN_Click(object sender, EventArgs e)
        {
            DecLBL.Visible = DecTB.Visible = true;
            DecTB.Text = Decrypt(EncTB.Text, KeyTb.Text);
            //byte[] b;
            //string decrypted;
            //try
            //{
            //    b = Convert.FromBase64String(encrString);
            //    decrypted = System.Text.ASCIIEncoding.ASCII.GetString(b);
            //}
            //catch (FormatException fe)
            //{
            //    decrypted = "";
            //}
            //return decrypted;
        }

        public string encrypt(string encryptString, string EncryptionKey)
        {
            byte[] clearBytes = Encoding.Unicode.GetBytes(encryptString);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    encryptString = Convert.ToBase64String(ms.ToArray());
                }
            }
            return encryptString;
        }

        public string Decrypt(string cipherText, string EncryptionKey)
        {
            cipherText = cipherText.Replace(" ", "+");
            byte[] cipherBytes = Convert.FromBase64String(cipherText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(cipherBytes, 0, cipherBytes.Length);
                        cs.Close();
                    }
                    cipherText = Encoding.Unicode.GetString(ms.ToArray());
                }
            }
            return cipherText;
        }

        private void storeBTN_Click(object sender, EventArgs e)
        {
            mailLBL.Text = "Account Email";
            mailTB.Name = "mailTB";
            mailLBL.Location = new Point(130, 500);
            mailTB.Location = new Point(250, 500);
            mailTB.Size = new Size(60, 10);
            this.Controls.Add(mailTB);
            this.Controls.Add(mailLBL);

            
            accsiteTB.Name = "accsiteTB";
            accsiteLBL.Text = "Account Location(Site)";
            accsiteLBL.Location = new Point(350, 500);
            accsiteTB.Location = new Point(500, 500);
            accsiteTB.Size = new Size(60, 10);
            accsiteLBL.Size = new Size(170, 15);
            this.Controls.Add(accsiteTB);
            this.Controls.Add(accsiteLBL);

            
            saveBTN.Text = "Save";
            saveBTN.Location = new Point(570, 500);
            this.Controls.Add(saveBTN);
            //address = accsiteTB.Text;
            //pass = EncTB.Text;
            //mail = mailTB.Text;
            saveBTN.Click += new System.EventHandler(this.saveBTN_Click);
        }

        private void saveBTN_Click(object sender, EventArgs e)
        {
            int index = -1;
            FileStream fileStreams = new FileStream("Record.Xml", FileMode.Create, FileAccess.Write);
            fileStreams.Close();
            FileStream fs = new FileStream("Record.Xml", FileMode.Open, FileAccess.Read);
            if (fs.Length == 0)
            {
            }
            else
            {
                recList = (List<Records>)xmlSerializer.Deserialize(fs);
                Records[] array = recList.ToArray();
                for (int i=0; i< array.Length; i++)
                {
                    Records records1 = new Records(accsiteTB.Text, mailTB.Text);
                    if (array[i].Mail == mailTB.Text && array[i].Address == accsiteTB.Text)
                    {
                        index = i;
                        DialogResult dr = MessageBox.Show("Record already exist do you want to update?", "Record existance warning", MessageBoxButtons.YesNo);
                        switch (dr)
                        {
                            case DialogResult.Yes:
                                Records record = new Records(accsiteTB.Text, mailTB.Text, passwordTB.Text);
                                recList.RemoveAt(index);
                                recList.Insert(index, record);
                                break;
                            case DialogResult.No:
                                break;
                            default:
                                break;
                        }
                    }
                    else
                    {
                        Records records = new Records(accsiteTB.Text, mailTB.Text, passwordTB.Text);
                        recList.Add(records);
                    }
                }
            }
            fs.Close();
            FileStream fileStream = new FileStream("Record.Xml", FileMode.Create, FileAccess.Write);
            if (index == -1)
            {
                recList.Add(new Records(accsiteTB.Text, mailTB.Text, EncTB.Text));
            }
            xmlSerializer.Serialize(fileStream, recList);
            fileStream.Close();
        }
    }
}