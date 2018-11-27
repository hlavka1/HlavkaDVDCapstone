using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;
using System.Drawing;
using System.Text;

namespace HlavkaDVDCapstone
{
   public partial class Form1
    {
        OleDbConnection con = new OleDbConnection(HlavkaDVDCapstone.Properties.Settings.Default.Database4ConnectionString);
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.database4DataSet = new HlavkaDVDCapstone.Database4DataSet();
            this.database4DataSet11 = new HlavkaDVDCapstone.Database4DataSet1();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sheet1TableAdapter1 = new HlavkaDVDCapstone.Database4DataSet1TableAdapters.Sheet1TableAdapter();
            this.sheet1TableAdapter2 = new HlavkaDVDCapstone.Database4DataSetTableAdapters.Sheet1TableAdapter();
            this.btn_DisplayDetails = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.lbl_DVDDatabase = new System.Windows.Forms.Label();
            this.TestForGit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database4DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database4DataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dataGridView2.DataSource = this.bindingSource2;
            this.dataGridView2.Location = new System.Drawing.Point(72, 170);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(801, 436);
            this.dataGridView2.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "DVD Title";
            this.dataGridViewTextBoxColumn1.HeaderText = "DVD Title";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Year";
            this.dataGridViewTextBoxColumn2.HeaderText = "Year";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // bindingSource2
            // 
            this.bindingSource2.DataMember = "Sheet1";
            this.bindingSource2.DataSource = this.database4DataSet;
            // 
            // database4DataSet
            // 
            this.database4DataSet.DataSetName = "Database4DataSet";
            this.database4DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // database4DataSet11
            // 
            this.database4DataSet11.DataSetName = "Database4DataSet1";
            this.database4DataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "Sheet1";
            this.bindingSource1.DataSource = this.database4DataSet11;
            // 
            // sheet1TableAdapter1
            // 
            this.sheet1TableAdapter1.ClearBeforeFill = true;
            // 
            // sheet1TableAdapter2
            // 
            this.sheet1TableAdapter2.ClearBeforeFill = true;
            // 
            // btn_DisplayDetails
            // 
            this.btn_DisplayDetails.Location = new System.Drawing.Point(72, 688);
            this.btn_DisplayDetails.Name = "btn_DisplayDetails";
            this.btn_DisplayDetails.Size = new System.Drawing.Size(250, 103);
            this.btn_DisplayDetails.TabIndex = 1;
            this.btn_DisplayDetails.Text = "Display Details";
            this.btn_DisplayDetails.UseVisualStyleBackColor = true;
            this.btn_DisplayDetails.Click += new System.EventHandler(this.btn_DisplayDetails_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(577, 688);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(296, 103);
            this.btn_Exit.TabIndex = 2;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // lbl_DVDDatabase
            // 
            this.lbl_DVDDatabase.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.lbl_DVDDatabase.AutoSize = true;
            this.lbl_DVDDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DVDDatabase.Location = new System.Drawing.Point(86, 55);
            this.lbl_DVDDatabase.Name = "lbl_DVDDatabase";
            this.lbl_DVDDatabase.Size = new System.Drawing.Size(773, 82);
            this.lbl_DVDDatabase.TabIndex = 3;
            this.lbl_DVDDatabase.Text = "Hlavka DVD Database";
            // 
            // TestForGit
            // 
            this.TestForGit.Location = new System.Drawing.Point(373, 682);
            this.TestForGit.Name = "TestForGit";
            this.TestForGit.Size = new System.Drawing.Size(156, 108);
            this.TestForGit.TabIndex = 4;
            this.TestForGit.Text = "TestForGit";
            this.TestForGit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(971, 835);
            this.Controls.Add(this.TestForGit);
            this.Controls.Add(this.lbl_DVDDatabase);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_DisplayDetails);
            this.Controls.Add(this.dataGridView2);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database4DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database4DataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private Button button2;
        private Database4DataSet1 database4DataSet1;
        private BindingSource sheet1BindingSource;
        private Database4DataSet1TableAdapters.Sheet1TableAdapter sheet1TableAdapter;
        private DataGridViewCheckBoxColumn sequelDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn dVDTitleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private BindingSource database4DataSet1BindingSource;
      //  private Database4DataSet2 database4DataSet2;
        private BindingSource sheet1BindingSource1;
        private DataGridView dataGridView2;
        private Database4DataSet1 database4DataSet11;
        private BindingSource bindingSource1;
        private Database4DataSet1TableAdapters.Sheet1TableAdapter sheet1TableAdapter1;
        private Database4DataSet database4DataSet;
        private BindingSource bindingSource2;
        private Database4DataSetTableAdapters.Sheet1TableAdapter sheet1TableAdapter2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private Button btn_DisplayDetails;
        private Button btn_Exit;
        private Label lbl_DVDDatabase;
        private Button TestForGit;
        // private Database4DataSet2TableAdapters.Sheet1TableAdapter sheet1TableAdapter1;
    }
}

