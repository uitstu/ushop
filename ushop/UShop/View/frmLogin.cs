using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Presenter.Interface;
using Presenter.InterfaceImplement;
using Model;
using Presenter.Interfaces;
using System.Security.Cryptography;
using System.IO;

namespace View
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm, IAccountLoginView
    {
        private AccountPresenter preAccount;

        public frmLogin()
        {
            preAccount = new AccountPresenter(this);
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            preAccount.verifyAccount(edtID.Text, edtPassword.Text);
        }

        public void loadAccounts(List<Model.ACCOUNT> listObj)
        {
            throw new NotImplementedException();
        }

        public void veryfyAccount(string message)
        {

            if (message == null)
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!");
            }
            else
            {
                saveFormPass();
                //MessageBox.Show(message);
                frmUShop frm = new frmUShop();
                frm.Show();
                Hide();
            }
        }

        public void showAccountList(DataTable table)
        {
            throw new NotImplementedException();
        }

        public DataTable getAccountTable()
        {
            throw new NotImplementedException();
        }

        public void showMessageBox(string mB_FAILURE, MessageBoxIcon information)
        {
            throw new NotImplementedException();
        }

        public void setFormPass()
        {
            try
            {
                if (!File.Exists("Pass.txt"))
                {
                    FileStream fs;
                    fs = new FileStream("Pass.txt", FileMode.Create);
                    StreamWriter sWriter = new StreamWriter(fs, Encoding.UTF8);

                    sWriter.WriteLine("Hello World!");
                    sWriter.Flush();
                    fs.Close();
                }



                string[] lines = File.ReadAllLines("Pass.txt");
                if (lines[lines.Length - 1] == "1")
                {
                    edtPassword.Text = Decrypt(lines[lines.Length - 3]);
                    edtID.Text = lines[lines.Length - 2];
                    cboxRemember.Checked = true;
                }
            }
            catch (Exception)
            {
                //MessageBox.Show("Thông tài khoản, mật khẩu ghi lại có thể đã bị phá!");
            }
        }

        public void saveFormPass()
        {
            FileStream fs = new FileStream("Pass.txt", FileMode.Append);

            StreamWriter writeFile = new StreamWriter(fs, Encoding.UTF8);
            if (cboxRemember.Checked == true)
            {
                writeFile.WriteLine(Encrypt(edtPassword.Text));
                writeFile.WriteLine(edtID.Text);             
                writeFile.WriteLine("1");
                writeFile.Flush();
            }
            else writeFile.WriteLine("0");
            writeFile.Close();
        }

        public string key = "ushopkey";

        public string Encrypt(string toEncrypt) // mã hóa
        {
            bool useHashing = true;
            byte[] keyArray;
            byte[] toEncryptArray = UTF8Encoding.UTF8.GetBytes(toEncrypt);

            if (useHashing)
            {
                MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
                keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
            }
            else
                keyArray = UTF8Encoding.UTF8.GetBytes(key);

            TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
            tdes.Key = keyArray;
            tdes.Mode = CipherMode.ECB;
            tdes.Padding = PaddingMode.PKCS7;

            ICryptoTransform cTransform = tdes.CreateEncryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);

            return Convert.ToBase64String(resultArray, 0, resultArray.Length);
        }

        public string Decrypt(string toDecrypt) // giải mã
        {
            bool useHashing = true;
            byte[] keyArray;
            byte[] toEncryptArray = Convert.FromBase64String(toDecrypt);

            if (useHashing)
            {
                MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
                keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
            }
            else
                keyArray = UTF8Encoding.UTF8.GetBytes(key);

            TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
            tdes.Key = keyArray;
            tdes.Mode = CipherMode.ECB;
            tdes.Padding = PaddingMode.PKCS7;

            ICryptoTransform cTransform = tdes.CreateDecryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);

            return UTF8Encoding.UTF8.GetString(resultArray);
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            setFormPass();
        }
    }
}