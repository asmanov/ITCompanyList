namespace ITCompanyList
{
    partial class UserForm
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ukrITCompanyDBDataSet1 = new ITCompanyList.UkrITCompanyDBDataSet();
            this.iTCompanyTableAdapter = new ITCompanyList.UkrITCompanyDBDataSetTableAdapters.ITCompanyTableAdapter();
            this.tableAdapterManager1 = new ITCompanyList.UkrITCompanyDBDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.ukrITCompanyDBDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(939, 478);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // ukrITCompanyDBDataSet1
            // 
            this.ukrITCompanyDBDataSet1.DataSetName = "UkrITCompanyDBDataSet";
            this.ukrITCompanyDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iTCompanyTableAdapter
            // 
            this.iTCompanyTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.ITCompanyTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = ITCompanyList.UkrITCompanyDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 518);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.Load += new System.EventHandler(this.UserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ukrITCompanyDBDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private UkrITCompanyDBDataSet ukrITCompanyDBDataSet1;
        private UkrITCompanyDBDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private UkrITCompanyDBDataSetTableAdapters.ITCompanyTableAdapter iTCompanyTableAdapter;
    }
}