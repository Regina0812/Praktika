namespace Repair_shop
{
    partial class ClientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idServiceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servicePriceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repairBaseDataSet = new Repair_shop.RepairBaseDataSet();
            this.clientTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.serviceTableTableAdapter = new Repair_shop.RepairBaseDataSetTableAdapters.ServiceTableTableAdapter();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.repairMainTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repairMainTableTableAdapter = new Repair_shop.RepairBaseDataSetTableAdapters.RepairMainTableTableAdapter();
            this.repairMainTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.clientTableTableAdapter = new Repair_shop.RepairBaseDataSetTableAdapters.ClientTableTableAdapter();
            this.servicePriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idServiceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairBaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairMainTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairMainTableBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Enabled = false;
            this.tabControl1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.ItemSize = new System.Drawing.Size(114, 40);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1000, 658);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.TabStop = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage1.Location = new System.Drawing.Point(4, 44);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(992, 610);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Виды услуг";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idServiceDataGridViewTextBoxColumn1,
            this.serviceDataGridViewTextBoxColumn1,
            this.servicePriceDataGridViewTextBoxColumn1});
            this.dataGridView1.DataSource = this.serviceTableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(975, 575);
            this.dataGridView1.TabIndex = 1;
            // 
            // idServiceDataGridViewTextBoxColumn1
            // 
            this.idServiceDataGridViewTextBoxColumn1.DataPropertyName = "Id_Service";
            this.idServiceDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idServiceDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.idServiceDataGridViewTextBoxColumn1.Name = "idServiceDataGridViewTextBoxColumn1";
            this.idServiceDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // serviceDataGridViewTextBoxColumn1
            // 
            this.serviceDataGridViewTextBoxColumn1.DataPropertyName = "Service";
            this.serviceDataGridViewTextBoxColumn1.HeaderText = "Услуги";
            this.serviceDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.serviceDataGridViewTextBoxColumn1.Name = "serviceDataGridViewTextBoxColumn1";
            this.serviceDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // servicePriceDataGridViewTextBoxColumn1
            // 
            this.servicePriceDataGridViewTextBoxColumn1.DataPropertyName = "ServicePrice";
            this.servicePriceDataGridViewTextBoxColumn1.HeaderText = "Цена";
            this.servicePriceDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.servicePriceDataGridViewTextBoxColumn1.Name = "servicePriceDataGridViewTextBoxColumn1";
            this.servicePriceDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // serviceTableBindingSource
            // 
            this.serviceTableBindingSource.DataMember = "ServiceTable";
            this.serviceTableBindingSource.DataSource = this.repairBaseDataSet;
            // 
            // repairBaseDataSet
            // 
            this.repairBaseDataSet.DataSetName = "RepairBaseDataSet";
            this.repairBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientTableBindingSource
            // 
            this.clientTableBindingSource.DataMember = "ClientTable";
            this.clientTableBindingSource.DataSource = this.repairBaseDataSet;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(900, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // serviceTableTableAdapter
            // 
            this.serviceTableTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(856, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pictureBox2.MouseLeave += new System.EventHandler(this.pictureBox2_MouseLeave);
            this.pictureBox2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseMove);
            // 
            // repairMainTableBindingSource
            // 
            this.repairMainTableBindingSource.DataMember = "RepairMainTable";
            this.repairMainTableBindingSource.DataSource = this.repairBaseDataSet;
            // 
            // repairMainTableTableAdapter
            // 
            this.repairMainTableTableAdapter.ClearBeforeFill = true;
            // 
            // repairMainTableBindingSource1
            // 
            this.repairMainTableBindingSource1.DataMember = "RepairMainTable";
            this.repairMainTableBindingSource1.DataSource = this.repairBaseDataSet;
            // 
            // clientTableTableAdapter
            // 
            this.clientTableTableAdapter.ClearBeforeFill = true;
            // 
            // servicePriceDataGridViewTextBoxColumn
            // 
            this.servicePriceDataGridViewTextBoxColumn.DataPropertyName = "ServicePrice";
            this.servicePriceDataGridViewTextBoxColumn.HeaderText = "ServicePrice";
            this.servicePriceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.servicePriceDataGridViewTextBoxColumn.Name = "servicePriceDataGridViewTextBoxColumn";
            this.servicePriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.servicePriceDataGridViewTextBoxColumn.Width = 150;
            // 
            // serviceDataGridViewTextBoxColumn
            // 
            this.serviceDataGridViewTextBoxColumn.DataPropertyName = "Service";
            this.serviceDataGridViewTextBoxColumn.HeaderText = "Service";
            this.serviceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.serviceDataGridViewTextBoxColumn.Name = "serviceDataGridViewTextBoxColumn";
            this.serviceDataGridViewTextBoxColumn.ReadOnly = true;
            this.serviceDataGridViewTextBoxColumn.Width = 150;
            // 
            // idServiceDataGridViewTextBoxColumn
            // 
            this.idServiceDataGridViewTextBoxColumn.DataPropertyName = "Id_Service";
            this.idServiceDataGridViewTextBoxColumn.HeaderText = "Id_Service";
            this.idServiceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idServiceDataGridViewTextBoxColumn.Name = "idServiceDataGridViewTextBoxColumn";
            this.idServiceDataGridViewTextBoxColumn.ReadOnly = true;
            this.idServiceDataGridViewTextBoxColumn.Width = 150;
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(978, 595);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1000, 651);
            this.MinimumSize = new System.Drawing.Size(1000, 651);
            this.Name = "ClientForm";
            this.Text = "Прайс";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.global_FormClosed);
            this.Load += new System.EventHandler(this.ClientForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairBaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairMainTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairMainTableBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private RepairBaseDataSet repairBaseDataSet;
        private System.Windows.Forms.BindingSource serviceTableBindingSource;
        private RepairBaseDataSetTableAdapters.ServiceTableTableAdapter serviceTableTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.BindingSource repairMainTableBindingSource;
        private RepairBaseDataSetTableAdapters.RepairMainTableTableAdapter repairMainTableTableAdapter;
        private System.Windows.Forms.BindingSource repairMainTableBindingSource1;
        private System.Windows.Forms.BindingSource clientTableBindingSource;
        private RepairBaseDataSetTableAdapters.ClientTableTableAdapter clientTableTableAdapter;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idServiceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn servicePriceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn servicePriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idServiceDataGridViewTextBoxColumn;
    }
}