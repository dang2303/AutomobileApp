namespace AutoMobileWinApp
{
    partial class frmCarManagement
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
            txtReleaseYear = new MaskedTextBox();
            txtPrice = new MaskedTextBox();
            txtCarName = new TextBox();
            txtCarID = new TextBox();
            lblReleaseYear = new Label();
            lblPrice = new Label();
            lblManufacturer = new Label();
            lblCarName = new Label();
            lblCarID = new Label();
            btnLoad = new Button();
            btnNew = new Button();
            btnDelete = new Button();
            dgvCarList = new DataGridView();
            btnClose = new Button();
            txtManufacturer = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvCarList).BeginInit();
            SuspendLayout();
            // 
            // txtReleaseYear
            // 
            txtReleaseYear.Location = new Point(381, 41);
            txtReleaseYear.Name = "txtReleaseYear";
            txtReleaseYear.Size = new Size(171, 23);
            txtReleaseYear.TabIndex = 30;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(381, 8);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(171, 23);
            txtPrice.TabIndex = 29;
            // 
            // txtCarName
            // 
            txtCarName.Location = new Point(93, 41);
            txtCarName.Name = "txtCarName";
            txtCarName.Size = new Size(171, 23);
            txtCarName.TabIndex = 28;
            // 
            // txtCarID
            // 
            txtCarID.Location = new Point(93, 8);
            txtCarID.Name = "txtCarID";
            txtCarID.Size = new Size(171, 23);
            txtCarID.TabIndex = 27;
            // 
            // lblReleaseYear
            // 
            lblReleaseYear.AutoSize = true;
            lblReleaseYear.Location = new Point(292, 49);
            lblReleaseYear.Name = "lblReleaseYear";
            lblReleaseYear.Size = new Size(78, 15);
            lblReleaseYear.TabIndex = 26;
            lblReleaseYear.Text = "Released Year";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(292, 16);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(33, 15);
            lblPrice.TabIndex = 25;
            lblPrice.Text = "Price";
            // 
            // lblManufacturer
            // 
            lblManufacturer.AutoSize = true;
            lblManufacturer.Location = new Point(12, 82);
            lblManufacturer.Name = "lblManufacturer";
            lblManufacturer.Size = new Size(79, 15);
            lblManufacturer.TabIndex = 24;
            lblManufacturer.Text = "Manufacturer";
            // 
            // lblCarName
            // 
            lblCarName.AutoSize = true;
            lblCarName.Location = new Point(12, 49);
            lblCarName.Name = "lblCarName";
            lblCarName.Size = new Size(60, 15);
            lblCarName.TabIndex = 23;
            lblCarName.Text = "Car Name";
            // 
            // lblCarID
            // 
            lblCarID.AutoSize = true;
            lblCarID.Location = new Point(12, 16);
            lblCarID.Name = "lblCarID";
            lblCarID.Size = new Size(39, 15);
            lblCarID.TabIndex = 22;
            lblCarID.Text = "Car ID";
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(93, 115);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(104, 36);
            btnLoad.TabIndex = 32;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(261, 115);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(104, 36);
            btnNew.TabIndex = 33;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(448, 115);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(104, 36);
            btnDelete.TabIndex = 34;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDeleteClick;
            // 
            // dgvCarList
            // 
            dgvCarList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarList.Location = new Point(12, 174);
            dgvCarList.Name = "dgvCarList";
            dgvCarList.ReadOnly = true;
            dgvCarList.RowTemplate.Height = 25;
            dgvCarList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCarList.Size = new Size(540, 150);
            dgvCarList.TabIndex = 35;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(221, 327);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(104, 36);
            btnClose.TabIndex = 36;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // txtManufacturer
            // 
            txtManufacturer.Location = new Point(93, 74);
            txtManufacturer.Name = "txtManufacturer";
            txtManufacturer.Size = new Size(171, 23);
            txtManufacturer.TabIndex = 37;
            // 
            // frmCarManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(564, 375);
            Controls.Add(txtManufacturer);
            Controls.Add(btnClose);
            Controls.Add(dgvCarList);
            Controls.Add(btnDelete);
            Controls.Add(btnNew);
            Controls.Add(btnLoad);
            Controls.Add(txtReleaseYear);
            Controls.Add(txtPrice);
            Controls.Add(txtCarName);
            Controls.Add(txtCarID);
            Controls.Add(lblReleaseYear);
            Controls.Add(lblPrice);
            Controls.Add(lblManufacturer);
            Controls.Add(lblCarName);
            Controls.Add(lblCarID);
            Name = "frmCarManagement";
            Text = "Car Management";
            Load += frmCarManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCarList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MaskedTextBox txtReleaseYear;
        private MaskedTextBox txtPrice;
        private TextBox txtCarName;
        private TextBox txtCarID;
        private Label lblReleaseYear;
        private Label lblPrice;
        private Label lblManufacturer;
        private Label lblCarName;
        private Label lblCarID;
        private Button btnLoad;
        private Button btnNew;
        private Button btnDelete;
        private DataGridView dgvCarList;
        private Button btnClose;
        private TextBox txtManufacturer;
    }
}