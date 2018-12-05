using HlavkaDVDCapstone.Model;
using System;
using System.Windows.Forms;



namespace HlavkaDVDCapstone
{
    public partial class DetailForm : Form
    {
        DVD _dvd;

        public DetailForm(DVD dvd)
        {
            InitializeComponent();
            _dvd = dvd;
        }


        private void DetailForm_Load(object sender, EventArgs e)
        {
            txtbx_LeadActor.Text = _dvd.Actor;
            txtbx_DVDTitle.Text = _dvd.Title;
            txtbx_Length.Text = _dvd.Length;
            txtbx_Sequel.Text = _dvd.Sequel.ToString();
            txtbx_Year.Text = _dvd.Year.ToString();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
