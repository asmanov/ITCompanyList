using System;

namespace ITCompanyList
{
    partial class AdminForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameCompanyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfEmployeesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iTCompanyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ukrITCompanyDBDataSet = new ITCompanyList.UkrITCompanyDBDataSet();
            this.iTCompanyTableAdapter = new ITCompanyList.UkrITCompanyDBDataSetTableAdapters.ITCompanyTableAdapter();
            this.ukrITCompanyDBDataSet1 = new ITCompanyList.UkrITCompanyDBDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTCompanyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ukrITCompanyDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ukrITCompanyDBDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameCompanyDataGridViewTextBoxColumn,
            this.numberOfEmployeesDataGridViewTextBoxColumn,
            this.locationDataGridViewTextBoxColumn,
            this.leadDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.iTCompanyBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-132, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(933, 627);
            this.dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameCompanyDataGridViewTextBoxColumn
            // 
            this.nameCompanyDataGridViewTextBoxColumn.DataPropertyName = "name company";
            this.nameCompanyDataGridViewTextBoxColumn.HeaderText = "name company";
            this.nameCompanyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameCompanyDataGridViewTextBoxColumn.Name = "nameCompanyDataGridViewTextBoxColumn";
            this.nameCompanyDataGridViewTextBoxColumn.Width = 125;
            // 
            // numberOfEmployeesDataGridViewTextBoxColumn
            // 
            this.numberOfEmployeesDataGridViewTextBoxColumn.DataPropertyName = "number of employees";
            this.numberOfEmployeesDataGridViewTextBoxColumn.HeaderText = "number of employees";
            this.numberOfEmployeesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numberOfEmployeesDataGridViewTextBoxColumn.Name = "numberOfEmployeesDataGridViewTextBoxColumn";
            this.numberOfEmployeesDataGridViewTextBoxColumn.Width = 125;
            // 
            // locationDataGridViewTextBoxColumn
            // 
            this.locationDataGridViewTextBoxColumn.DataPropertyName = "location";
            this.locationDataGridViewTextBoxColumn.HeaderText = "location";
            this.locationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            this.locationDataGridViewTextBoxColumn.Width = 125;
            // 
            // leadDataGridViewTextBoxColumn
            // 
            this.leadDataGridViewTextBoxColumn.DataPropertyName = "lead";
            this.leadDataGridViewTextBoxColumn.HeaderText = "lead";
            this.leadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.leadDataGridViewTextBoxColumn.Name = "leadDataGridViewTextBoxColumn";
            this.leadDataGridViewTextBoxColumn.Width = 125;
            // 
            // iTCompanyBindingSource
            // 
            this.iTCompanyBindingSource.DataMember = "ITCompany";
            this.iTCompanyBindingSource.DataSource = this.ukrITCompanyDBDataSet;
            // 
            // ukrITCompanyDBDataSet
            // 
            this.ukrITCompanyDBDataSet.DataSetName = "UkrITCompanyDBDataSet";
            this.ukrITCompanyDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iTCompanyTableAdapter
            // 
            this.iTCompanyTableAdapter.ClearBeforeFill = true;
            // 
            // ukrITCompanyDBDataSet1
            // 
            this.ukrITCompanyDBDataSet1.DataSetName = "UkrITCompanyDBDataSet";
            this.ukrITCompanyDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 651);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTCompanyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ukrITCompanyDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ukrITCompanyDBDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        



        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private UkrITCompanyDBDataSet ukrITCompanyDBDataSet;
        private System.Windows.Forms.BindingSource iTCompanyBindingSource;
        private UkrITCompanyDBDataSetTableAdapters.ITCompanyTableAdapter iTCompanyTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameCompanyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfEmployeesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn leadDataGridViewTextBoxColumn;
        private UkrITCompanyDBDataSet ukrITCompanyDBDataSet1;
    }
}