namespace CarCare
{
    partial class Home
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
            this.refreshBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Name:";
            // 
            // custSearch
            // 
            this.custSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custSearch.Location = new System.Drawing.Point(348, 17);
            this.custSearch.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.custSearch.Name = "custSearch";
            this.custSearch.Size = new System.Drawing.Size(416, 56);
            this.custSearch.TabIndex = 1;
            // 
            // custList
            // 
            this.custList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custList.FormattingEnabled = true;
            this.custList.ItemHeight = 31;
            this.custList.Location = new System.Drawing.Point(14, 123);
            this.custList.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.custList.Name = "custList";
            this.custList.Size = new System.Drawing.Size(1182, 438);
            this.custList.TabIndex = 2;
            this.custList.Click += new System.EventHandler(this.custList_Click);
            // 
            // carList
            // 
            this.carList.FormattingEnabled = true;
            this.carList.ItemHeight = 25;
            this.carList.Location = new System.Drawing.Point(14, 654);
            this.carList.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.carList.Name = "carList";
            this.carList.Size = new System.Drawing.Size(494, 254);
            this.carList.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 598);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 51);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cars:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 73);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 51);
            this.label3.TabIndex = 5;
            this.label3.Text = "Customers:";
            // 
            // carInfoLbl
            // 
            this.carInfoLbl.AutoSize = true;
            this.carInfoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carInfoLbl.Location = new System.Drawing.Point(1210, 23);
            this.carInfoLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.carInfoLbl.Name = "carInfoLbl";
            this.carInfoLbl.Size = new System.Drawing.Size(186, 51);
            this.carInfoLbl.TabIndex = 6;
            this.carInfoLbl.Text = "Car Info:";
            // 
            // repairHist
            // 
            this.repairHist.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repairHist.FormattingEnabled = true;
            this.repairHist.ItemHeight = 31;
            this.repairHist.Location = new System.Drawing.Point(1222, 123);
            this.repairHist.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.repairHist.Name = "repairHist";
            this.repairHist.Size = new System.Drawing.Size(1208, 438);
            this.repairHist.TabIndex = 7;
            // 
            // repairDetLbl
            // 
            this.repairDetLbl.AutoSize = true;
            this.repairDetLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repairDetLbl.Location = new System.Drawing.Point(1212, 598);
            this.repairDetLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.repairDetLbl.Name = "repairDetLbl";
            this.repairDetLbl.Size = new System.Drawing.Size(305, 51);
            this.repairDetLbl.TabIndex = 8;
            this.repairDetLbl.Text = "Repair Details:";
            // 
            // addRep
            // 
            this.addRep.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addRep.Location = new System.Drawing.Point(1222, 756);
            this.addRep.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.addRep.Name = "addRep";
            this.addRep.Size = new System.Drawing.Size(600, 158);
            this.addRep.TabIndex = 9;
            this.addRep.Text = "Add new repair";
            this.addRep.UseVisualStyleBackColor = true;
            // 
            // deleteRep
            // 
            this.deleteRep.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteRep.Location = new System.Drawing.Point(1834, 756);
            this.deleteRep.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.deleteRep.Name = "deleteRep";
            this.deleteRep.Size = new System.Drawing.Size(600, 158);
            this.deleteRep.TabIndex = 10;
            this.deleteRep.Text = "Delete this repair";
            this.deleteRep.UseVisualStyleBackColor = true;
            // 
            // addCust
            // 
            this.addCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCust.Location = new System.Drawing.Point(520, 604);
            this.addCust.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.addCust.Name = "addCust";
            this.addCust.Size = new System.Drawing.Size(678, 96);
            this.addCust.TabIndex = 11;
            this.addCust.Text = "Add new customer";
            this.addCust.UseVisualStyleBackColor = true;
            this.addCust.Click += new System.EventHandler(this.addCust_Click);
            // 
            // editCust
            // 
            this.editCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editCust.Location = new System.Drawing.Point(520, 708);
            this.editCust.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.editCust.Name = "editCust";
            this.editCust.Size = new System.Drawing.Size(678, 96);
            this.editCust.TabIndex = 12;
            this.editCust.Text = "Edit Customer";
            this.editCust.UseVisualStyleBackColor = true;
            this.editCust.Click += new System.EventHandler(this.editCust_Click);
            // 
            // deleteCust
            // 
            this.deleteCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteCust.Location = new System.Drawing.Point(520, 815);
            this.deleteCust.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.deleteCust.Name = "deleteCust";
            this.deleteCust.Size = new System.Drawing.Size(678, 96);
            this.deleteCust.TabIndex = 13;
            this.deleteCust.Text = "Delete customer";
            this.deleteCust.UseVisualStyleBackColor = true;
            this.deleteCust.Click += new System.EventHandler(this.deleteCust_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.Location = new System.Drawing.Point(782, 17);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(416, 62);
            this.searchBtn.TabIndex = 14;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(1048, 79);
            this.refreshBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(150, 44);
            this.refreshBtn.TabIndex = 15;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(2446, 933);
            this.Controls.Add(this.refreshBtn);
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
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Home";
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
        private System.Windows.Forms.Button refreshBtn;
    }
}

