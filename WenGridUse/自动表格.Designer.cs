namespace WenGridUse
{
    partial class 自动表格
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
            this.dgvAXis = new WenGrid.ucDgvExcel();
            this.SuspendLayout();
            // 
            // dgvAXis
            // 
            this.dgvAXis.BackColor = System.Drawing.Color.White;
            this.dgvAXis.Location = new System.Drawing.Point(27, 12);
            this.dgvAXis.Name = "dgvAXis";
            this.dgvAXis.Size = new System.Drawing.Size(740, 426);
            this.dgvAXis.TabIndex = 15;
            // 
            // 自动表格
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvAXis);
            this.Name = "自动表格";
            this.Text = "自动表格";
            this.Load += new System.EventHandler(this.自动表格_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private WenGrid.ucDgvExcel dgvAXis;
    }
}