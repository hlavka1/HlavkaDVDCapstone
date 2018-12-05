namespace HlavkaDVDCapstone
{
    partial class ListViewForm
    {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.database4DataSet = new HlavkaDVDCapstone.Database4DataSet();
            this.sheet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sheet1TableAdapter = new HlavkaDVDCapstone.Database4DataSetTableAdapters.Sheet1TableAdapter();
            this.dataGridListView = new System.Windows.Forms.DataGridView();
            this.sheet1BindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dvdDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dvdDataSet = new HlavkaDVDCapstone.DvdDataSet();
            this.sheet1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btn_DetailForm = new System.Windows.Forms.Button();
            this.sheet1TableAdapter1 = new HlavkaDVDCapstone.DvdDataSetTableAdapters.Sheet1TableAdapter();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sequelDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lengthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.database4DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sheet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridListView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sheet1BindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvdDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvdDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sheet1BindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // database4DataSet
            // 
            this.database4DataSet.DataSetName = "Database4DataSet";
            this.database4DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sheet1BindingSource
            // 
            this.sheet1BindingSource.DataMember = "Sheet1";
            this.sheet1BindingSource.DataSource = this.database4DataSet;
            // 
            // sheet1TableAdapter
            // 
            this.sheet1TableAdapter.ClearBeforeFill = true;
            // 
            // dataGridListView
            // 
            this.dataGridListView.AutoGenerateColumns = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Baskerville Old Face", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridListView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridListView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridListView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.actorDataGridViewTextBoxColumn,
            this.sequelDataGridViewCheckBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.lengthDataGridViewTextBoxColumn,
            this.yearDataGridViewTextBoxColumn});
            this.dataGridListView.DataSource = this.sheet1BindingSource2;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridListView.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridListView.Location = new System.Drawing.Point(31, 39);
            this.dataGridListView.Name = "dataGridListView";
            this.dataGridListView.RowTemplate.Height = 28;
            this.dataGridListView.Size = new System.Drawing.Size(1071, 695);
            this.dataGridListView.TabIndex = 0;
            // 
            // sheet1BindingSource2
            // 
            this.sheet1BindingSource2.DataMember = "Sheet1";
            this.sheet1BindingSource2.DataSource = this.dvdDataSetBindingSource;
            // 
            // dvdDataSetBindingSource
            // 
            this.dvdDataSetBindingSource.DataSource = this.dvdDataSet;
            this.dvdDataSetBindingSource.Position = 0;
            // 
            // dvdDataSet
            // 
            this.dvdDataSet.DataSetName = "DvdDataSet";
            this.dvdDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sheet1BindingSource1
            // 
            this.sheet1BindingSource1.DataMember = "Sheet1";
            this.sheet1BindingSource1.DataSource = this.database4DataSet;
            // 
            // btn_DetailForm
            // 
            this.btn_DetailForm.Font = new System.Drawing.Font("Baskerville Old Face", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DetailForm.Location = new System.Drawing.Point(67, 776);
            this.btn_DetailForm.Name = "btn_DetailForm";
            this.btn_DetailForm.Size = new System.Drawing.Size(268, 66);
            this.btn_DetailForm.TabIndex = 1;
            this.btn_DetailForm.Text = "View Details";
            this.btn_DetailForm.UseVisualStyleBackColor = true;
            this.btn_DetailForm.Click += new System.EventHandler(this.btn_DetailForm_Click);
            // 
            // sheet1TableAdapter1
            // 
            this.sheet1TableAdapter1.ClearBeforeFill = true;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Font = new System.Drawing.Font("Baskerville Old Face", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.Location = new System.Drawing.Point(820, 776);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(224, 66);
            this.btn_Exit.TabIndex = 2;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // actorDataGridViewTextBoxColumn
            // 
            this.actorDataGridViewTextBoxColumn.DataPropertyName = "Actor";
            this.actorDataGridViewTextBoxColumn.HeaderText = "Actor";
            this.actorDataGridViewTextBoxColumn.Name = "actorDataGridViewTextBoxColumn";
            this.actorDataGridViewTextBoxColumn.Visible = false;
            // 
            // sequelDataGridViewCheckBoxColumn
            // 
            this.sequelDataGridViewCheckBoxColumn.DataPropertyName = "Sequel";
            this.sequelDataGridViewCheckBoxColumn.HeaderText = "Sequel";
            this.sequelDataGridViewCheckBoxColumn.Name = "sequelDataGridViewCheckBoxColumn";
            this.sequelDataGridViewCheckBoxColumn.Visible = false;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.Width = 109;
            // 
            // lengthDataGridViewTextBoxColumn
            // 
            this.lengthDataGridViewTextBoxColumn.DataPropertyName = "Length";
            this.lengthDataGridViewTextBoxColumn.HeaderText = "Length";
            this.lengthDataGridViewTextBoxColumn.Name = "lengthDataGridViewTextBoxColumn";
            this.lengthDataGridViewTextBoxColumn.Visible = false;
            // 
            // yearDataGridViewTextBoxColumn
            // 
            this.yearDataGridViewTextBoxColumn.DataPropertyName = "Year";
            this.yearDataGridViewTextBoxColumn.HeaderText = "Year";
            this.yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            // 
            // ListViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1145, 883);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_DetailForm);
            this.Controls.Add(this.dataGridListView);
            this.Name = "ListViewForm";
            this.Text = "ListViewForm";
            this.Load += new System.EventHandler(this.ListViewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database4DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sheet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridListView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sheet1BindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvdDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvdDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sheet1BindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Database4DataSet database4DataSet;
        private System.Windows.Forms.BindingSource sheet1BindingSource;
        private Database4DataSetTableAdapters.Sheet1TableAdapter sheet1TableAdapter;
        private System.Windows.Forms.DataGridView dataGridListView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dVDTitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_DetailForm;
        private System.Windows.Forms.BindingSource sheet1BindingSource1;
        private System.Windows.Forms.BindingSource dvdDataSetBindingSource;
        private DvdDataSet dvdDataSet;
        private System.Windows.Forms.BindingSource sheet1BindingSource2;
        private DvdDataSetTableAdapters.Sheet1TableAdapter sheet1TableAdapter1;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn sequelDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lengthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
    }
}