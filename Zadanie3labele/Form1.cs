using System;
using System.IO;
using System.Windows.Forms;
using System.Web;


namespace Zadanie3labele
{
    public partial class Form1 : Form
    {
        WebBrowser webBrowser = new WebBrowser();
        public Form1()
        {
            InitializeComponent();
            webBrowser.Navigate("https://www.google.com/maps/");
        }

        private void z1btn_Click(object sender, EventArgs e)
        {
            string note = textBox1.Text;


            Random rnd = new Random();
            double lat = rnd.NextDouble() * 180 - 90;
            double lon = rnd.NextDouble() * 360 - 180;


            string time = DateTime.Now.ToString();


            using (StreamWriter sw = new StreamWriter("notatka" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".txt"))
            {
                sw.WriteLine(note);
                sw.WriteLine(lat);
                sw.WriteLine(lon);
                sw.WriteLine(time);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void z2btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text pliki (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileContent = File.ReadAllText(openFileDialog.FileName);
                label1.Text = fileContent;
            }
        }

        private void z3btn_Click(object sender, EventArgs e)
        {
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();

                openFileDialog1.InitialDirectory = "c:\\";
                openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog1.FilterIndex = 2;
                openFileDialog1.RestoreDirectory = true;

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string filePath = openFileDialog1.FileName;
                        string[] lines = File.ReadAllLines(filePath);
                        double lat = double.Parse(lines[0]);
                        double lng = double.Parse(lines[1]);
                        string url = String.Format("https://www.google.com/maps/search/{0},{1}/", lat, lng);
                        webBrowser.Navigate(url);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                    }
                }
            }
        }
    }
}

