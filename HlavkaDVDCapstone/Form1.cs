using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using HlavkaDVDCapstone.Model;

namespace HlavkaDVDCapstone
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database4DataSet2.Sheet1' table. You can move, or remove it, as needed.
            //this.sheet1TableAdapter1.Fill(this.database4DataSet2.Sheet1);
            // TODO: This line of code loads data into the 'database4DataSet1.Sheet1' table. You can move, or remove it, as needed.
            this.sheet1TableAdapter.Fill(this.database4DataSet1.Sheet1);

        }


        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_DisplayDetails_Click(object sender, EventArgs e)
        {
            var dvdData = dataGridView2.CurrentRow.DataBoundItem;
            DVD dvd = new DVD();
            var tom = database4DataSet.Tables;
            //DetailForm form = new DetailForm();
            //form.Show();
        }
    }
}
