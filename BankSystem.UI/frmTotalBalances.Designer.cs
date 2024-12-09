namespace BankSystem
{
    partial class frmTotalBalances
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTotalBalances));
            this.dgvTotalBalances = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalBalances = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotalBalances)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTotalBalances
            // 
            this.dgvTotalBalances.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvTotalBalances.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTotalBalances.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTotalBalances.GridColor = System.Drawing.Color.Fuchsia;
            this.dgvTotalBalances.Location = new System.Drawing.Point(0, 0);
            this.dgvTotalBalances.Name = "dgvTotalBalances";
            this.dgvTotalBalances.RowHeadersWidth = 51;
            this.dgvTotalBalances.RowTemplate.Height = 26;
            this.dgvTotalBalances.Size = new System.Drawing.Size(1379, 830);
            this.dgvTotalBalances.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(813, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(566, 830);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(835, 770);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 36);
            this.label1.TabIndex = 25;
            this.label1.Text = "Total Balances: ";
            // 
            // lblTotalBalances
            // 
            this.lblTotalBalances.AutoSize = true;
            this.lblTotalBalances.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalBalances.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalBalances.ForeColor = System.Drawing.Color.Fuchsia;
            this.lblTotalBalances.Location = new System.Drawing.Point(1077, 760);
            this.lblTotalBalances.Name = "lblTotalBalances";
            this.lblTotalBalances.Size = new System.Drawing.Size(189, 50);
            this.lblTotalBalances.TabIndex = 26;
            this.lblTotalBalances.Text = "190000 $";
            // 
            // frmTotalBalances
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1379, 830);
            this.Controls.Add(this.lblTotalBalances);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvTotalBalances);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTotalBalances";
            this.Text = "frmTotalBalances";
            this.Load += new System.EventHandler(this.frmTotalBalances_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotalBalances)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTotalBalances;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalBalances;
    }
}