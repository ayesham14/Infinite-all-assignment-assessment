namespace RailwayReservationSystem
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
            this.dataGridViewTrains = new System.Windows.Forms.DataGridView();
            this.txtTno = new System.Windows.Forms.TextBox();
            this.txtTname = new System.Windows.Forms.TextBox();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.txtDest = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtSeats = new System.Windows.Forms.TextBox();
            this.btnAddTrain = new System.Windows.Forms.Button();
            this.btnUpdateTrain = new System.Windows.Forms.Button();
            this.btnDeleteTrain = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrains)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewTrains
            // 
            this.dataGridViewTrains.AccessibleName = "";
            this.dataGridViewTrains.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTrains.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewTrains.Location = new System.Drawing.Point(12, 3);
            this.dataGridViewTrains.Name = "dataGridViewTrains";
            this.dataGridViewTrains.Size = new System.Drawing.Size(776, 448);
            this.dataGridViewTrains.TabIndex = 0;
            this.dataGridViewTrains.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTrains_CellContentClick);
            // 
            // txtTno
            // 
            this.txtTno.Location = new System.Drawing.Point(115, 110);
            this.txtTno.Name = "txtTno";
            this.txtTno.Size = new System.Drawing.Size(100, 20);
            this.txtTno.TabIndex = 1;
            this.txtTno.TextChanged += new System.EventHandler(this.txtTno_TextChanged);
            // 
            // txtTname
            // 
            this.txtTname.Location = new System.Drawing.Point(290, 110);
            this.txtTname.Name = "txtTname";
            this.txtTname.Size = new System.Drawing.Size(100, 20);
            this.txtTname.TabIndex = 2;
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(455, 110);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(100, 20);
            this.txtFrom.TabIndex = 3;
            // 
            // txtDest
            // 
            this.txtDest.BackColor = System.Drawing.SystemColors.Window;
            this.txtDest.Location = new System.Drawing.Point(599, 110);
            this.txtDest.Name = "txtDest";
            this.txtDest.Size = new System.Drawing.Size(100, 20);
            this.txtDest.TabIndex = 4;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(115, 212);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 5;
            // 
            // txtClass
            // 
            this.txtClass.Location = new System.Drawing.Point(290, 212);
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(100, 20);
            this.txtClass.TabIndex = 6;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(455, 212);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(100, 20);
            this.txtStatus.TabIndex = 7;
            // 
            // txtSeats
            // 
            this.txtSeats.Location = new System.Drawing.Point(599, 212);
            this.txtSeats.Name = "txtSeats";
            this.txtSeats.Size = new System.Drawing.Size(100, 20);
            this.txtSeats.TabIndex = 8;
            // 
            // btnAddTrain
            // 
            this.btnAddTrain.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnAddTrain.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTrain.Location = new System.Drawing.Point(108, 345);
            this.btnAddTrain.Name = "btnAddTrain";
            this.btnAddTrain.Size = new System.Drawing.Size(126, 23);
            this.btnAddTrain.TabIndex = 9;
            this.btnAddTrain.Text = "Add Train";
            this.btnAddTrain.UseVisualStyleBackColor = false;
            // 
            // btnUpdateTrain
            // 
            this.btnUpdateTrain.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnUpdateTrain.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateTrain.Location = new System.Drawing.Point(331, 345);
            this.btnUpdateTrain.Name = "btnUpdateTrain";
            this.btnUpdateTrain.Size = new System.Drawing.Size(118, 23);
            this.btnUpdateTrain.TabIndex = 10;
            this.btnUpdateTrain.Text = "Update Train";
            this.btnUpdateTrain.UseVisualStyleBackColor = false;
            // 
            // btnDeleteTrain
            // 
            this.btnDeleteTrain.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnDeleteTrain.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteTrain.Location = new System.Drawing.Point(528, 345);
            this.btnDeleteTrain.Name = "btnDeleteTrain";
            this.btnDeleteTrain.Size = new System.Drawing.Size(128, 23);
            this.btnDeleteTrain.TabIndex = 11;
            this.btnDeleteTrain.Text = "Delete Train";
            this.btnDeleteTrain.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(132, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Train Number";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(298, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Train Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(492, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "From";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(613, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Destination";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(147, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(328, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Class";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(485, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Status";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Highlight;
            this.label8.Location = new System.Drawing.Point(612, 183);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Total Seats";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(12, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 63);
            this.panel1.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(300, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 25);
            this.label9.TabIndex = 0;
            this.label9.Text = "Admin Page";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeleteTrain);
            this.Controls.Add(this.btnUpdateTrain);
            this.Controls.Add(this.btnAddTrain);
            this.Controls.Add(this.txtSeats);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtClass);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtDest);
            this.Controls.Add(this.txtFrom);
            this.Controls.Add(this.txtTname);
            this.Controls.Add(this.txtTno);
            this.Controls.Add(this.dataGridViewTrains);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrains)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTrains;
        private System.Windows.Forms.TextBox txtTno;
        private System.Windows.Forms.TextBox txtTname;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.TextBox txtDest;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtSeats;
        private System.Windows.Forms.Button btnAddTrain;
        private System.Windows.Forms.Button btnUpdateTrain;
        private System.Windows.Forms.Button btnDeleteTrain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
    }
}