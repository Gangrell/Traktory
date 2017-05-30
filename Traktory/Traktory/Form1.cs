using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Facebook;
using System.Dynamic;

namespace Traktory
{
    public partial class Form1 : Form
    {

        private const string AppId = "1346621245427692";
        private Uri _loginUrl;
        private const string _ExtendedPermissions = "user_about_me, publish_stream, offline_access";
        FacebookClient fbClient = new FacebookClient();

        MySQL DB = new MySQL();
        List<Label> list = new List<Label>();
        public Form1()
        {
            InitializeComponent();
            
            List<string>[] ListaModeli = DB.Select2();
            List<string>[] ListaMarek = DB.Select();
            MarkaCB.DataSource = ListaMarek[1];

            cos(ListaModeli, ListaMarek);
            
        }

        private void cos(List<string>[] ListaModeli, List<string>[] ListaMarek)
        {
            for (int j = 0; j < ListaModeli[0].Count; j++)
                for (int i = 0; i < ListaModeli.Count(); i++)
                {
                    Label tb = new Label();
                    if ((i + 3) % 4 == 0)
                        tb.Text = ListaMarek[1][ListaMarek[0].IndexOf(ListaModeli[i][j])];
                    else
                        tb.Text = ListaModeli[i][j];
                    list.Add(tb);
                }
            int x = 200;
            int y = 50;

            Label la = new Label();
            la.Text = "Model";
            la.Location = new Point(x, y-20);
            la.Height = 19;
            la.Width = 79;
            this.Controls.Add(la);

            la = new Label();
            la.Text = "Marka";
            la.Location = new Point(x + 80, y-20);
            la.Height = 19;
            la.Width = 79;
            this.Controls.Add(la);

            la = new Label();
            la.Text = "Moc";
            la.Location = new Point(x + 160, y-20);
            la.Height = 19;
            la.Width = 79;
            this.Controls.Add(la);

            la = new Label();
            la.Text = "Masa[kg]";
            la.Location = new Point(x + 240, y-20);
            la.Height = 19;
            la.Width = 79;
            this.Controls.Add(la);

            int k = 0;
            foreach (Label L in list)
            {
                L.Location = new Point(x, y);
                L.Height = 19;
                L.Width = 79;
                this.Controls.Add(L);
                x += 80;
                k++;
                if (k == 4)
                {
                    k = 0;
                    y += 20;
                    x = 200;
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            DB.Insert(MarkaCB.Text,int.Parse(MocTB.Text),int.Parse(MasaTB.Text),ModelTB.Text);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            GeneratorPDF GPDF = new GeneratorPDF(DB.Select(),DB.Select2());
        }

        public void Login()
        {

            dynamic parameters = new ExpandoObject();
            parameters.client_id = AppId;
            //parameters.redirect_uri = "https://www.facebook.com/connect/login_success.html";
            parameters.redirect_uri = "https://www.facebook.com";

            parameters.response_type = "token";

            //parameters.display = "popup";

            /*if (!string.IsNullOrWhiteSpace(_ExtendedPermissions))
                parameters.scope = _ExtendedPermissions;*/

            var fb = new FacebookClient();
            _loginUrl = fb.GetLoginUrl(parameters);

            webBrowserLogin.Navigate(_loginUrl.AbsoluteUri);

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            Login();
        }
    }
}
