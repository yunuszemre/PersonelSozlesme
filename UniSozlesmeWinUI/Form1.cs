using System.Net;

namespace UniSozlesmeWinUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string uri = "https://localhost:7113";
        private void Form1_Load(object sender, EventArgs e)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            request.Method = "GET";


        }
    }
}