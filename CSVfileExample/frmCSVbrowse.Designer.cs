namespace CSVfileExample
{
    partial class frmCSVbrowse
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
            this.btnLoad = new System.Windows.Forms.Button();
            this.txtBrowae = new System.Windows.Forms.TextBox();
            this.dgvCSVData = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCSVData)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(499, 49);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // txtBrowae
            // 
            this.txtBrowae.Location = new System.Drawing.Point(87, 51);
            this.txtBrowae.Name = "txtBrowae";
            this.txtBrowae.Size = new System.Drawing.Size(406, 20);
            this.txtBrowae.TabIndex = 1;
            this.txtBrowae.Click += new System.EventHandler(this.txtBrowae_Click);
            // 
            // dgvCSVData
            // 
            this.dgvCSVData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCSVData.Location = new System.Drawing.Point(87, 77);
            this.dgvCSVData.Name = "dgvCSVData";
            this.dgvCSVData.Size = new System.Drawing.Size(406, 211);
            this.dgvCSVData.TabIndex = 2;
            // 
            // frmCSVbrowse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvCSVData);
            this.Controls.Add(this.txtBrowae);
            this.Controls.Add(this.btnLoad);
            this.Name = "frmCSVbrowse";
            this.Text = "frmCSVbrowse";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCSVData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.TextBox txtBrowae;
        private System.Windows.Forms.DataGridView dgvCSVData;
    }
}