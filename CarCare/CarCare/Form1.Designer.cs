namespace CarCare
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
            this.label1 = new System.Windows.Forms.Label();
            this.custSearch = new System.Windows.Forms.TextBox();
            this.custList = new System.Windows.Forms.ListBox();
            this.carList = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.carInfoLbl = new System.Windows.Forms.Label();
            this.repairHist = new System.Windows.Forms.ListBox();
            this.repairDetLbl = new System.Windows.Forms.Label();
            this.addRep = new System.Windows.Forms.Button();
            this.deleteRep = new System.Windows.Forms.Button();
            this.addCust = new System.Windows.Forms.Button();
            this.editCust = new System.Windows.Forms.Button();
            this.deleteCust = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Name:";
            // 
            // custSearch
            // 
            this.custSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custSearch.Location = new System.Drawing.Point(174, 9);
            this.custSearch.Name = "custSearch";
            this.custSearch.Size = new System.Drawing.Size(210, 32);
            this.custSearch.TabIndex = 1;
            // 
            // custList
            // 
            this.custList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custList.FormattingEnabled = true;
            this.custList.ItemHeight = 16;
            this.custList.Location = new System.Drawing.Point(7, 64);
            this.custList.Name = "custList";
            this.custList.Size = new System.Drawing.Size(593, 244);
            this.custList.TabIndex = 2;
            // 
            // carList
            // 
            this.carList.FormattingEnabled = true;
            this.carList.Location = new System.Drawing.Point(7, 340);
            this.carList.Name = "carList";
            this.carList.Size = new System.Drawing.Size(249, 134);
            this.carList.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 311);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cars:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(2, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "Customers:";
            // 
            // carInfoLbl
            // 
            this.carInfoLbl.AutoSize = true;
            this.carInfoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carInfoLbl.Location = new System.Drawing.Point(605, 12);
            this.carInfoLbl.Name = "carInfoLbl";
            this.carInfoLbl.Size = new System.Drawing.Size(95, 26);
            this.carInfoLbl.TabIndex = 6;
            this.carInfoLbl.Text = "Car Info:";
            // 
            // repairHist
            // 
            this.repairHist.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repairHist.FormattingEnabled = true;
            this.repairHist.ItemHeight = 16;
            this.repairHist.Location = new System.Drawing.Point(611, 64);
            this.repairHist.Name = "repairHist";
            this.repairHist.Size = new System.Drawing.Size(606, 244);
            this.repairHist.TabIndex = 7;
            // 
            // repairDetLbl
            // 
            this.repairDetLbl.AutoSize = true;
            this.repairDetLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repairDetLbl.Location = new System.Drawing.Point(606, 311);
            this.repairDetLbl.Name = "repairDetLbl";
            this.repairDetLbl.Size = new System.Drawing.Size(155, 26);
            this.repairDetLbl.TabIndex = 8;
            this.repairDetLbl.Text = "Repair Details:";
            // 
            // addRep
            // 
            this.addRep.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addRep.Location = new System.Drawing.Point(611, 393);
            this.addRep.Name = "addRep";
            this.addRep.Size = new System.Drawing.Size(300, 82);
            this.addRep.TabIndex = 9;
            this.addRep.Text = "Add new repair";
            this.addRep.UseVisualStyleBackColor = true;
            // 
            // deleteRep
            // 
            this.deleteRep.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteRep.Location = new System.Drawing.Point(917, 393);
            this.deleteRep.Name = "deleteRep";
            this.deleteRep.Size = new System.Drawing.Size(300, 82);
            this.deleteRep.TabIndex = 10;
            this.deleteRep.Text = "Delete this repair";
            this.deleteRep.UseVisualStyleBackColor = true;
            // 
            // addCust
            // 
            this.addCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCust.Location = new System.Drawing.Point(260, 314);
            this.addCust.Name = "addCust";
            this.addCust.Size = new System.Drawing.Size(339, 50);
            this.addCust.TabIndex = 11;
            this.addCust.Text = "Add new customer";
            this.addCust.UseVisualStyleBackColor = true;
            this.addCust.Click += new System.EventHandler(this.addCust_Click);
            // 
            // editCust
            // 
            this.editCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editCust.Location = new System.Drawing.Point(260, 368);
            this.editCust.Name = "editCust";
            this.editCust.Size = new System.Drawing.Size(339, 50);
            this.editCust.TabIndex = 12;
            this.editCust.Text = "Edit Customer";
            this.editCust.UseVisualStyleBackColor = true;
            // 
            // deleteCust
            // 
            this.deleteCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteCust.Location = new System.Drawing.Point(260, 424);
            this.deleteCust.Name = "deleteCust";
            this.deleteCust.Size = new System.Drawing.Size(339, 50);
            this.deleteCust.TabIndex = 13;
            this.deleteCust.Text = "Delete customer";
            this.deleteCust.UseVisualStyleBackColor = true;
            // 
            // searchBtn
            // 
            this.searchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.Location = new System.Drawing.Point(391, 9);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(208, 32);
            this.searchBtn.TabIndex = 14;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 485);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.deleteCust);
            this.Controls.Add(this.editCust);
            this.Controls.Add(this.addCust);
            this.Controls.Add(this.deleteRep);
            this.Controls.Add(this.addRep);
            this.Controls.Add(this.repairDetLbl);
            this.Controls.Add(this.repairHist);
            this.Controls.Add(this.carInfoLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.carList);
            this.Controls.Add(this.custList);
            this.Controls.Add(this.custSearch);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Car Care";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox custSearch;
        private System.Windows.Forms.ListBox custList;
        private System.Windows.Forms.ListBox carList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label carInfoLbl;
        private System.Windows.Forms.ListBox repairHist;
        private System.Windows.Forms.Label repairDetLbl;
        private System.Windows.Forms.Button addRep;
        private System.Windows.Forms.Button deleteRep;
        private System.Windows.Forms.Button addCust;
        private System.Windows.Forms.Button editCust;
        private System.Windows.Forms.Button deleteCust;
        private System.Windows.Forms.Button searchBtn;

    }
}

