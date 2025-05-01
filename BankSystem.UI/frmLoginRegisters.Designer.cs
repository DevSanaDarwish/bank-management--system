namespace BankSystem
{
    partial class frmLoginRegisters
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
            this.dgvLoginRegisters = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoginRegisters)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLoginRegisters
            // 
            this.dgvLoginRegisters.AllowUserToAddRows = false;
            this.dgvLoginRegisters.AllowUserToDeleteRows = false;
            this.dgvLoginRegisters.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLoginRegisters.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLoginRegisters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoginRegisters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLoginRegisters.GridColor = System.Drawing.Color.DarkMagenta;
            this.dgvLoginRegisters.Location = new System.Drawing.Point(0, 0);
            this.dgvLoginRegisters.Name = "dgvLoginRegisters";
            this.dgvLoginRegisters.ReadOnly = true;
            this.dgvLoginRegisters.RowHeadersWidth = 51;
            this.dgvLoginRegisters.RowTemplate.Height = 26;
            this.dgvLoginRegisters.Size = new System.Drawing.Size(1379, 830);
            this.dgvLoginRegisters.TabIndex = 1;
            // 
            // frmLoginRegisters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1379, 830);
            this.Controls.Add(this.dgvLoginRegisters);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLoginRegisters";
            this.Text = "frmLoginRegisters";
            this.Load += new System.EventHandler(this.frmLoginRegisters_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoginRegisters)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLoginRegisters;
    }
}