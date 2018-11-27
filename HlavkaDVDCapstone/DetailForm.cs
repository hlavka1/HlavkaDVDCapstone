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



namespace HlavkaDVDCapstone
{
    public partial class DetailForm : Form
    {


        public DetailForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DetailForm_Load(object sender, EventArgs e)
        {

        }

        private void DetailForm_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database4DataSet1.Sheet1' table. You can move, or remove it, as needed.
            this.sheet1TableAdapter.Fill(this.database4DataSet1.Sheet1);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
