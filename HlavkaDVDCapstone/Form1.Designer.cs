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


            this.database4DataSet2 = new HlavkaDVDCapstone.Database4DataSet2();
            this.database4DataSet = new HlavkaDVDCapstone.Database4DataSet();
            this.database4DataSet11 = new HlavkaDVDCapstone.Database4DataSet1();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.sheet1TableAdapter1 = new HlavkaDVDCapstone.Database4DataSet1TableAdapters.Sheet1TableAdapter();
            this.sheet1TableAdapter2 = new HlavkaDVDCapstone.Database4DataSetTableAdapters.Sheet1TableAdapter();
            this.sheet1TableAdapter3 = new HlavkaDVDCapstone.Database4DataSet2TableAdapters.Sheet1TableAdapter();

            this.btn_DisplayDetails = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.lbl_DVDDatabase = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Length = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.database4DataSet11BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database4DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database4DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database4DataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database4DataSet11BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingSource3
            // 
            this.bindingSource3.DataMember = "Sheet1";
            this.bindingSource3.DataSource = this.database4DataSet2;
            // 
            // database4DataSet2
            // 
            this.database4DataSet2.DataSetName = "Database4DataSet2";
            this.database4DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // bindingSource2
            // 
            this.bindingSource2.DataMember = "Sheet1";
            this.bindingSource2.DataSource = this.database4DataSet;
            // 
            // sheet1TableAdapter1
            // 
            this.sheet1TableAdapter1.ClearBeforeFill = true;
            // 
            // sheet1TableAdapter2
            // 
            this.sheet1TableAdapter2.ClearBeforeFill = true;
            // 
            // sheet1TableAdapter3
            // 
            this.sheet1TableAdapter3.ClearBeforeFill = true;
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
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "DVD Title";
            this.dataGridViewTextBoxColumn1.HeaderText = "DVD Title";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // Length
            // 
            this.Length.DataPropertyName = "Length";
            this.Length.HeaderText = "Length";
            this.Length.Name = "Length";
            this.Length.Visible = false;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn2.HeaderText = "ID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // database4DataSet11BindingSource
            // 
            this.database4DataSet11BindingSource.DataSource = this.database4DataSet11;
            this.database4DataSet11BindingSource.Position = 0;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(971, 835);
            this.Controls.Add(this.lbl_DVDDatabase);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_DisplayDetails);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database4DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database4DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database4DataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database4DataSet11BindingSource)).EndInit();
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
        private Database4DataSet1 database4DataSet11;
        private BindingSource bindingSource1;
        private Database4DataSet1TableAdapters.Sheet1TableAdapter sheet1TableAdapter1;
        private Database4DataSet database4DataSet;
        private BindingSource bindingSource2;
        private Database4DataSetTableAdapters.Sheet1TableAdapter sheet1TableAdapter2;
        private Button btn_DisplayDetails;
        private Button btn_Exit;
        private Label lbl_DVDDatabase;
        private Database4DataSet2 database4DataSet2;
        private BindingSource bindingSource3;
        private Database4DataSet2TableAdapters.Sheet1TableAdapter sheet1TableAdapter3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn Length;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private BindingSource database4DataSet11BindingSource;
        // private Database4DataSet2TableAdapters.Sheet1TableAdapter sheet1TableAdapter1;
    }
}

