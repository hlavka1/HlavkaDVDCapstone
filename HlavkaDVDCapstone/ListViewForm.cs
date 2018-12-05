using HlavkaDVDCapstone.Model;
using System;
using System.Data;
using System.Windows.Forms;

namespace HlavkaDVDCapstone
{
    public partial class ListViewForm : Form
    {
        public ListViewForm()
        {
            InitializeComponent();
        }

        private void ListViewForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dvdDataSet.Sheet1' table. You can move, or remove it, as needed.
            this.sheet1TableAdapter1.Fill(this.dvdDataSet.Sheet1);
            // TODO: This line of code loads data into the 'database4DataSet.Sheet1' table. You can move, or remove it, as needed.
            this.sheet1TableAdapter.Fill(this.database4DataSet.Sheet1);

        }

        private void btn_DetailForm_Click(object sender, EventArgs e)
        {
            DVD dvd = new DVD();

            var dataRow = dataGridListView.CurrentRow;
            DataRowView dataItem = dataRow.DataBoundItem as DataRowView;
            var items = dataItem.Row.ItemArray;

            dvd.ID = int.Parse(items[0].ToString());
            dvd.Sequel = bool.Parse(items[2].ToString());
            dvd.Title = items[3].ToString();
            dvd.Length = items[4].ToString();
            dvd.Year = double.Parse(items[5].ToString());
            dvd.Actor = items[1].ToString();

            DetailForm df = new DetailForm(dvd);
            df.Show();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
