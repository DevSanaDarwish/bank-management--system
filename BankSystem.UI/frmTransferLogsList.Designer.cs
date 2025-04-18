namespace BankSystem
{
    partial class frmTransferLogsList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvTransferLogs = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransferLogs)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTransferLogs
            // 
            this.dgvTransferLogs.AllowUserToAddRows = false;
            this.dgvTransferLogs.AllowUserToDeleteRows = false;
            this.dgvTransferLogs.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTransferLogs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTransferLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransferLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTransferLogs.GridColor = System.Drawing.Color.BurlyWood;
            this.dgvTransferLogs.Location = new System.Drawing.Point(0, 0);
            this.dgvTransferLogs.Name = "dgvTransferLogs";
            this.dgvTransferLogs.ReadOnly = true;
            this.dgvTransferLogs.RowHeadersWidth = 51;
            this.dgvTransferLogs.RowTemplate.Height = 26;
            this.dgvTransferLogs.Size = new System.Drawing.Size(1379, 830);
            this.dgvTransferLogs.TabIndex = 0;
            // 
            // frmTransferLogsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1379, 830);
            this.Controls.Add(this.dgvTransferLogs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTransferLogsList";
            this.Text = "frmTransferLogsList";
            this.Load += new System.EventHandler(this.frmTransferLogsList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransferLogs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTransferLogs;
    }
}