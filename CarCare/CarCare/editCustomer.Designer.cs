namespace CarCare
{
    partial class EditCustomer
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
            this.label2 = new System.Windows.Forms.Label();
            this.carList = new System.Windows.Forms.ListBox();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.nameChangeTxt = new System.Windows.Forms.TextBox();
            this.addressChangeTxt = new System.Windows.Forms.TextBox();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.addCarBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(437, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Change cutsomer name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(476, 44);
            this.label2.TabIndex = 1;
            this.label2.Text = "Change customer address:";
            // 
            // carList
            // 
            this.carList.FormattingEnabled = true;
            this.carList.ItemHeight = 25;
            this.carList.Location = new System.Drawing.Point(20, 167);
            this.carList.Margin = new System.Windows.Forms.Padding(4);
            this.carList.Name = "carList";
            this.carList.Size = new System.Drawing.Size(1052, 429);
            this.carList.TabIndex = 2;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.Location = new System.Drawing.Point(20, 740);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(4);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(1052, 123);
            this.deleteBtn.TabIndex = 3;
            this.deleteBtn.Text = "Delete this car";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // nameChangeTxt
            // 
            this.nameChangeTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameChangeTxt.Location = new System.Drawing.Point(456, 6);
            this.nameChangeTxt.Margin = new System.Windows.Forms.Padding(4);
            this.nameChangeTxt.Name = "nameChangeTxt";
            this.nameChangeTxt.Size = new System.Drawing.Size(616, 50);
            this.nameChangeTxt.TabIndex = 5;
            // 
            // addressChangeTxt
            // 
            this.addressChangeTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressChangeTxt.Location = new System.Drawing.Point(494, 62);
            this.addressChangeTxt.Margin = new System.Windows.Forms.Padding(4);
            this.addressChangeTxt.Name = "addressChangeTxt";
            this.addressChangeTxt.Size = new System.Drawing.Size(578, 50);
            this.addressChangeTxt.TabIndex = 6;
            // 
            // confirmBtn
            // 
            this.confirmBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmBtn.Location = new System.Drawing.Point(20, 869);
            this.confirmBtn.Margin = new System.Windows.Forms.Padding(4);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(1052, 123);
            this.confirmBtn.TabIndex = 7;
            this.confirmBtn.Text = "Confirm changes";
            this.confirmBtn.UseVisualStyleBackColor = true;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // addCarBtn
            // 
            this.addCarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCarBtn.Location = new System.Drawing.Point(20, 612);
            this.addCarBtn.Margin = new System.Windows.Forms.Padding(4);
            this.addCarBtn.Name = "addCarBtn";
            this.addCarBtn.Size = new System.Drawing.Size(1052, 123);
            this.addCarBtn.TabIndex = 8;
            this.addCarBtn.Text = "Add new car";
            this.addCarBtn.UseVisualStyleBackColor = true;
            this.addCarBtn.Click += new System.EventHandler(this.AddCarBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 44);
            this.label3.TabIndex = 9;
            this.label3.Text = "Cars:";
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.Location = new System.Drawing.Point(960, 121);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(112, 42);
            this.RefreshBtn.TabIndex = 10;
            this.RefreshBtn.Text = "Refresh";
            this.RefreshBtn.UseVisualStyleBackColor = true;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // EditCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1084, 996);
            this.Controls.Add(this.RefreshBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.addCarBtn);
            this.Controls.Add(this.confirmBtn);
            this.Controls.Add(this.addressChangeTxt);
            this.Controls.Add(this.nameChangeTxt);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.carList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EditCustomer";
            this.Text = "editCustomer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox carList;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.TextBox nameChangeTxt;
        private System.Windows.Forms.TextBox addressChangeTxt;
        private System.Windows.Forms.Button confirmBtn;
        private System.Windows.Forms.Button addCarBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button RefreshBtn;
    }
}