namespace AutoMobileWinApp
{
    partial class frmCarDetails
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
            btnCancel = new Button();
            btnSave = new Button();
            cboManufacturer = new ComboBox();
            txtReleaseYear = new MaskedTextBox();
            txtPrice = new MaskedTextBox();
            txtCarName = new TextBox();
            txtCarID = new TextBox();
            lblReleaseYear = new Label();
            lblPrice = new Label();
            lblManufacturer = new Label();
            lblCarName = new Label();
            lblCarID = new Label();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(233, 195);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 36);
            btnCancel.TabIndex = 23;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(132, 195);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 36);
            btnSave.TabIndex = 22;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // cboManufacturer
            // 
            cboManufacturer.FormattingEnabled = true;
            cboManufacturer.Location = new Point(132, 87);
            cboManufacturer.Name = "cboManufacturer";
            cboManufacturer.Size = new Size(176, 23);
            cboManufacturer.TabIndex = 21;
            // 
            // txtReleaseYear
            // 
            txtReleaseYear.Location = new Point(132, 153);
            txtReleaseYear.Name = "txtReleaseYear";
            txtReleaseYear.Size = new Size(176, 23);
            txtReleaseYear.TabIndex = 20;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(132, 120);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(176, 23);
            txtPrice.TabIndex = 19;
            // 
            // txtCarName
            // 
            txtCarName.Location = new Point(132, 54);
            txtCarName.Name = "txtCarName";
            txtCarName.Size = new Size(176, 23);
            txtCarName.TabIndex = 18;
            // 
            // txtCarID
            // 
            txtCarID.Location = new Point(132, 21);
            txtCarID.Name = "txtCarID";
            txtCarID.Size = new Size(176, 23);
            txtCarID.TabIndex = 17;
            // 
            // lblReleaseYear
            // 
            lblReleaseYear.AutoSize = true;
            lblReleaseYear.Location = new Point(27, 161);
            lblReleaseYear.Name = "lblReleaseYear";
            lblReleaseYear.Size = new Size(78, 15);
            lblReleaseYear.TabIndex = 16;
            lblReleaseYear.Text = "Released Year";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(27, 128);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(33, 15);
            lblPrice.TabIndex = 15;
            lblPrice.Text = "Price";
            // 
            // lblManufacturer
            // 
            lblManufacturer.AutoSize = true;
            lblManufacturer.Location = new Point(27, 95);
            lblManufacturer.Name = "lblManufacturer";
            lblManufacturer.Size = new Size(79, 15);
            lblManufacturer.TabIndex = 14;
            lblManufacturer.Text = "Manufacturer";
            // 
            // lblCarName
            // 
            lblCarName.AutoSize = true;
            lblCarName.Location = new Point(27, 62);
            lblCarName.Name = "lblCarName";
            lblCarName.Size = new Size(60, 15);
            lblCarName.TabIndex = 13;
            lblCarName.Text = "Car Name";
            // 
            // lblCarID
            // 
            lblCarID.AutoSize = true;
            lblCarID.Location = new Point(27, 29);
            lblCarID.Name = "lblCarID";
            lblCarID.Size = new Size(39, 15);
            lblCarID.TabIndex = 12;
            lblCarID.Text = "Car ID";
            // 
            // frmCarDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(347, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(cboManufacturer);
            Controls.Add(txtReleaseYear);
            Controls.Add(txtPrice);
            Controls.Add(txtCarName);
            Controls.Add(txtCarID);
            Controls.Add(lblReleaseYear);
            Controls.Add(lblPrice);
            Controls.Add(lblManufacturer);
            Controls.Add(lblCarName);
            Controls.Add(lblCarID);
            Name = "frmCarDetails";
            Text = "frmCarDetails";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnSave;
        private ComboBox cboManufacturer;
        private MaskedTextBox txtReleaseYear;
        private MaskedTextBox txtPrice;
        private TextBox txtCarName;
        private TextBox txtCarID;
        private Label lblReleaseYear;
        private Label lblPrice;
        private Label lblManufacturer;
        private Label lblCarName;
        private Label lblCarID;
    }
}