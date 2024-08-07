namespace RailwayReservationSystem
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
            this.dataGridViewAvailableTrains = new System.Windows.Forms.DataGridView();
            this.txtTno = new System.Windows.Forms.TextBox();
            this.txtSeatsToBook = new System.Windows.Forms.TextBox();
            this.btnBookTicket = new System.Windows.Forms.Button();
            this.btnCancelTicket = new System.Windows.Forms.Button();
            this.txtBookingId = new System.Windows.Forms.Button();
            this.txtSeatsToCancel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAvailableTrains)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewAvailableTrains
            // 
            this.dataGridViewAvailableTrains.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAvailableTrains.Location = new System.Drawing.Point(127, 55);
            this.dataGridViewAvailableTrains.Name = "dataGridViewAvailableTrains";
            this.dataGridViewAvailableTrains.Size = new System.Drawing.Size(562, 394);
            this.dataGridViewAvailableTrains.TabIndex = 0;
            // 
            // txtTno
            // 
            this.txtTno.Location = new System.Drawing.Point(246, 181);
            this.txtTno.Name = "txtTno";
            this.txtTno.Size = new System.Drawing.Size(100, 20);
            this.txtTno.TabIndex = 1;
            this.txtTno.TextChanged += new System.EventHandler(this.txtTno_TextChanged);
            // 
            // txtSeatsToBook
            // 
            this.txtSeatsToBook.Location = new System.Drawing.Point(246, 254);
            this.txtSeatsToBook.Name = "txtSeatsToBook";
            this.txtSeatsToBook.Size = new System.Drawing.Size(100, 20);
            this.txtSeatsToBook.TabIndex = 2;
            this.txtSeatsToBook.TextChanged += new System.EventHandler(this.txtSeatsToBook_TextChanged);
            // 
            // btnBookTicket
            // 
            this.btnBookTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookTicket.Location = new System.Drawing.Point(211, 340);
            this.btnBookTicket.Name = "btnBookTicket";
            this.btnBookTicket.Size = new System.Drawing.Size(114, 23);
            this.btnBookTicket.TabIndex = 3;
            this.btnBookTicket.Text = "Book Ticket";
            this.btnBookTicket.UseVisualStyleBackColor = true;
            this.btnBookTicket.Click += new System.EventHandler(this.btnBookTicket_Click_1);
            // 
            // btnCancelTicket
            // 
            this.btnCancelTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelTicket.Location = new System.Drawing.Point(430, 340);
            this.btnCancelTicket.Name = "btnCancelTicket";
            this.btnCancelTicket.Size = new System.Drawing.Size(138, 23);
            this.btnCancelTicket.TabIndex = 4;
            this.btnCancelTicket.Text = "Cancel Ticket";
            this.btnCancelTicket.UseVisualStyleBackColor = true;
            // 
            // txtBookingId
            // 
            this.txtBookingId.Location = new System.Drawing.Point(508, 180);
            this.txtBookingId.Name = "txtBookingId";
            this.txtBookingId.Size = new System.Drawing.Size(102, 17);
            this.txtBookingId.TabIndex = 5;
            this.txtBookingId.UseVisualStyleBackColor = true;
            this.txtBookingId.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSeatsToCancel
            // 
            this.txtSeatsToCancel.Location = new System.Drawing.Point(510, 247);
            this.txtSeatsToCancel.Name = "txtSeatsToCancel";
            this.txtSeatsToCancel.Size = new System.Drawing.Size(100, 20);
            this.txtSeatsToCancel.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(160, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Train Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(160, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Seats To Book";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(427, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Booking ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(409, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Seats To Book";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(127, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(565, 97);
            this.panel1.TabIndex = 12;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(218, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "USER PAGE";
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSeatsToCancel);
            this.Controls.Add(this.txtBookingId);
            this.Controls.Add(this.btnCancelTicket);
            this.Controls.Add(this.btnBookTicket);
            this.Controls.Add(this.txtSeatsToBook);
            this.Controls.Add(this.txtTno);
            this.Controls.Add(this.dataGridViewAvailableTrains);
            this.Name = "UserForm";
            this.Text = "UserForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAvailableTrains)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAvailableTrains;
        private System.Windows.Forms.TextBox txtTno;
        private System.Windows.Forms.TextBox txtSeatsToBook;
        private System.Windows.Forms.Button btnBookTicket;
        private System.Windows.Forms.Button btnCancelTicket;
        private System.Windows.Forms.Button txtBookingId;
        private System.Windows.Forms.TextBox txtSeatsToCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
    }
}