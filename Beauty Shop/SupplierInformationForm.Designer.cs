
namespace Beauty_Shop
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblsupplierName = new System.Windows.Forms.Label();
            this.lblsupplierContactName = new System.Windows.Forms.Label();
            this.lblsupplierEmail = new System.Windows.Forms.Label();
            this.lblVillage = new System.Windows.Forms.Label();
            this.txtsupplierName = new System.Windows.Forms.TextBox();
            this.txtsupplierContactName = new System.Windows.Forms.TextBox();
            this.txtsupplierEmail = new System.Windows.Forms.TextBox();
            this.txtsupplierVillage = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblPostOffice = new System.Windows.Forms.Label();
            this.lblDistrict = new System.Windows.Forms.Label();
            this.lblPincode = new System.Windows.Forms.Label();
            this.txtVillage = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtPostOffice = new System.Windows.Forms.TextBox();
            this.txtDistrict = new System.Windows.Forms.TextBox();
            this.txtPincode = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(387, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Supplier Information";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Location = new System.Drawing.Point(485, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(303, 326);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblsupplierName
            // 
            this.lblsupplierName.AutoSize = true;
            this.lblsupplierName.BackColor = System.Drawing.Color.MediumPurple;
            this.lblsupplierName.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsupplierName.ForeColor = System.Drawing.Color.Black;
            this.lblsupplierName.Location = new System.Drawing.Point(34, 93);
            this.lblsupplierName.Name = "lblsupplierName";
            this.lblsupplierName.Size = new System.Drawing.Size(107, 19);
            this.lblsupplierName.TabIndex = 2;
            this.lblsupplierName.Text = "supplier Name";
            // 
            // lblsupplierContactName
            // 
            this.lblsupplierContactName.AutoSize = true;
            this.lblsupplierContactName.BackColor = System.Drawing.Color.MediumPurple;
            this.lblsupplierContactName.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsupplierContactName.ForeColor = System.Drawing.Color.Black;
            this.lblsupplierContactName.Location = new System.Drawing.Point(34, 131);
            this.lblsupplierContactName.Name = "lblsupplierContactName";
            this.lblsupplierContactName.Size = new System.Drawing.Size(158, 19);
            this.lblsupplierContactName.TabIndex = 2;
            this.lblsupplierContactName.Text = "supplierContact Name";
            // 
            // lblsupplierEmail
            // 
            this.lblsupplierEmail.AutoSize = true;
            this.lblsupplierEmail.BackColor = System.Drawing.Color.MediumPurple;
            this.lblsupplierEmail.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsupplierEmail.ForeColor = System.Drawing.Color.Black;
            this.lblsupplierEmail.Location = new System.Drawing.Point(34, 170);
            this.lblsupplierEmail.Name = "lblsupplierEmail";
            this.lblsupplierEmail.Size = new System.Drawing.Size(103, 19);
            this.lblsupplierEmail.TabIndex = 2;
            this.lblsupplierEmail.Text = "supplier Email";
            // 
            // lblVillage
            // 
            this.lblVillage.AutoSize = true;
            this.lblVillage.BackColor = System.Drawing.Color.MediumPurple;
            this.lblVillage.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVillage.ForeColor = System.Drawing.Color.Black;
            this.lblVillage.Location = new System.Drawing.Point(34, 209);
            this.lblVillage.Name = "lblVillage";
            this.lblVillage.Size = new System.Drawing.Size(55, 19);
            this.lblVillage.TabIndex = 2;
            this.lblVillage.Text = "Village";
            this.lblVillage.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtsupplierName
            // 
            this.txtsupplierName.Location = new System.Drawing.Point(232, 94);
            this.txtsupplierName.Name = "txtsupplierName";
            this.txtsupplierName.Size = new System.Drawing.Size(185, 20);
            this.txtsupplierName.TabIndex = 3;
            // 
            // txtsupplierContactName
            // 
            this.txtsupplierContactName.Location = new System.Drawing.Point(232, 130);
            this.txtsupplierContactName.Name = "txtsupplierContactName";
            this.txtsupplierContactName.Size = new System.Drawing.Size(185, 20);
            this.txtsupplierContactName.TabIndex = 3;
            // 
            // txtsupplierEmail
            // 
            this.txtsupplierEmail.Location = new System.Drawing.Point(232, 169);
            this.txtsupplierEmail.Name = "txtsupplierEmail";
            this.txtsupplierEmail.Size = new System.Drawing.Size(185, 20);
            this.txtsupplierEmail.TabIndex = 3;
            // 
            // txtsupplierVillage
            // 
            this.txtsupplierVillage.Location = new System.Drawing.Point(232, 209);
            this.txtsupplierVillage.Name = "txtsupplierVillage";
            this.txtsupplierVillage.Size = new System.Drawing.Size(185, 20);
            this.txtsupplierVillage.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Aqua;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Navy;
            this.btnSave.Location = new System.Drawing.Point(155, 405);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(96, 33);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblPostOffice
            // 
            this.lblPostOffice.AutoSize = true;
            this.lblPostOffice.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostOffice.Location = new System.Drawing.Point(34, 244);
            this.lblPostOffice.Name = "lblPostOffice";
            this.lblPostOffice.Size = new System.Drawing.Size(78, 19);
            this.lblPostOffice.TabIndex = 5;
            this.lblPostOffice.Text = "PostOffice";
            // 
            // lblDistrict
            // 
            this.lblDistrict.AutoSize = true;
            this.lblDistrict.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistrict.Location = new System.Drawing.Point(34, 277);
            this.lblDistrict.Name = "lblDistrict";
            this.lblDistrict.Size = new System.Drawing.Size(56, 19);
            this.lblDistrict.TabIndex = 5;
            this.lblDistrict.Text = "District";
            this.lblDistrict.Click += new System.EventHandler(this.lblsupplierEmailId_Click);
            // 
            // lblPincode
            // 
            this.lblPincode.AutoSize = true;
            this.lblPincode.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPincode.Location = new System.Drawing.Point(34, 310);
            this.lblPincode.Name = "lblPincode";
            this.lblPincode.Size = new System.Drawing.Size(63, 19);
            this.lblPincode.TabIndex = 5;
            this.lblPincode.Text = "Pincode";
            // 
            // txtVillage
            // 
            this.txtVillage.Location = new System.Drawing.Point(232, 209);
            this.txtVillage.Name = "txtVillage";
            this.txtVillage.Size = new System.Drawing.Size(185, 20);
            this.txtVillage.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Aqua;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Navy;
            this.button1.Location = new System.Drawing.Point(155, 405);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 33);
            this.button1.TabIndex = 4;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtPostOffice
            // 
            this.txtPostOffice.Location = new System.Drawing.Point(232, 245);
            this.txtPostOffice.Name = "txtPostOffice";
            this.txtPostOffice.Size = new System.Drawing.Size(185, 20);
            this.txtPostOffice.TabIndex = 6;
            // 
            // txtDistrict
            // 
            this.txtDistrict.Location = new System.Drawing.Point(232, 278);
            this.txtDistrict.Name = "txtDistrict";
            this.txtDistrict.Size = new System.Drawing.Size(185, 20);
            this.txtDistrict.TabIndex = 7;
            // 
            // txtPincode
            // 
            this.txtPincode.Location = new System.Drawing.Point(232, 310);
            this.txtPincode.Name = "txtPincode";
            this.txtPincode.Size = new System.Drawing.Size(185, 20);
            this.txtPincode.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtPincode);
            this.Controls.Add(this.txtDistrict);
            this.Controls.Add(this.txtPostOffice);
            this.Controls.Add(this.lblPincode);
            this.Controls.Add(this.lblDistrict);
            this.Controls.Add(this.lblPostOffice);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtVillage);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtsupplierVillage);
            this.Controls.Add(this.txtsupplierEmail);
            this.Controls.Add(this.txtsupplierContactName);
            this.Controls.Add(this.txtsupplierName);
            this.Controls.Add(this.lblVillage);
            this.Controls.Add(this.lblsupplierEmail);
            this.Controls.Add(this.lblsupplierContactName);
            this.Controls.Add(this.lblsupplierName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblsupplierName;
        private System.Windows.Forms.Label lblsupplierContactName;
        private System.Windows.Forms.Label lblsupplierEmail;
        private System.Windows.Forms.Label lblVillage;
        private System.Windows.Forms.TextBox txtsupplierName;
        private System.Windows.Forms.TextBox txtsupplierContactName;
        private System.Windows.Forms.TextBox txtsupplierEmail;
        private System.Windows.Forms.TextBox txtsupplierVillage;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblPostOffice;
        private System.Windows.Forms.Label lblDistrict;
        private System.Windows.Forms.Label lblPincode;
        private System.Windows.Forms.TextBox txtVillage;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtPostOffice;
        private System.Windows.Forms.TextBox txtDistrict;
        private System.Windows.Forms.TextBox txtPincode;
    }
}

