namespace CarCare
{
    partial class AddCustomer
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
            this.label1 = new System.Windows.Forms.Label();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addressTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.makeTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.modelTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.yearInt = new System.Windows.Forms.NumericUpDown();
            this.addCustBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.licenseTxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.yearInt)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Name:";
            // 
            // nameTxt
            // 
            this.nameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTxt.Location = new System.Drawing.Point(219, 13);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(322, 32);
            this.nameTxt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Customer Address:";
            // 
            // addressTxt
            // 
            this.addressTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressTxt.Location = new System.Drawing.Point(219, 52);
            this.addressTxt.Name = "addressTxt";
            this.addressTxt.Size = new System.Drawing.Size(322, 32);
            this.addressTxt.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Car Make:";
            // 
            // makeTxt
            // 
            this.makeTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makeTxt.Location = new System.Drawing.Point(136, 91);
            this.makeTxt.Name = "makeTxt";
            this.makeTxt.Size = new System.Drawing.Size(405, 32);
            this.makeTxt.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = "Car Model:";
            // 
            // modelTxt
            // 
            this.modelTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelTxt.Location = new System.Drawing.Point(136, 129);
            this.modelTxt.Name = "modelTxt";
            this.modelTxt.Size = new System.Drawing.Size(405, 32);
            this.modelTxt.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 26);
            this.label5.TabIndex = 8;
            this.label5.Text = "Car Year:";
            // 
            // yearInt
            // 
            this.yearInt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearInt.Location = new System.Drawing.Point(136, 167);
            this.yearInt.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.yearInt.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.yearInt.Name = "yearInt";
            this.yearInt.Size = new System.Drawing.Size(120, 32);
            this.yearInt.TabIndex = 9;
            this.yearInt.Value = new decimal(new int[] {
            2017,
            0,
            0,
            0});
            // 
            // addCustBtn
            // 
            this.addCustBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCustBtn.Location = new System.Drawing.Point(12, 205);
            this.addCustBtn.Name = "addCustBtn";
            this.addCustBtn.Size = new System.Drawing.Size(528, 38);
            this.addCustBtn.TabIndex = 15;
            this.addCustBtn.Text = "Add New Customer";
            this.addCustBtn.UseVisualStyleBackColor = true;
            this.addCustBtn.Click += new System.EventHandler(this.addCustBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(262, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 26);
            this.label6.TabIndex = 16;
            this.label6.Text = "License:";
            // 
            // licenseTxt
            // 
            this.licenseTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.licenseTxt.Location = new System.Drawing.Point(361, 167);
            this.licenseTxt.Name = "licenseTxt";
            this.licenseTxt.Size = new System.Drawing.Size(179, 32);
            this.licenseTxt.TabIndex = 17;
            // 
            // AddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 255);
            this.Controls.Add(this.licenseTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.addCustBtn);
            this.Controls.Add(this.yearInt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.modelTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.makeTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.addressTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.label1);
            this.Name = "AddCustomer";
            this.Text = "Add Customer Form";
            ((System.ComponentModel.ISupportInitialize)(this.yearInt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox addressTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox makeTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox modelTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown yearInt;
        private System.Windows.Forms.Button addCustBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox licenseTxt;
    }
}