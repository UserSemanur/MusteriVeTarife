namespace MusteriVeTarife
{
    partial class Tahsilat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tahsilat));
            this.LabelTC = new System.Windows.Forms.Label();
            this.textBoxTc = new System.Windows.Forms.TextBox();
            this.dataGridViewTahsilat = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTahsilat)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelTC
            // 
            this.LabelTC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelTC.AutoSize = true;
            this.LabelTC.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelTC.Location = new System.Drawing.Point(487, 64);
            this.LabelTC.Name = "LabelTC";
            this.LabelTC.Size = new System.Drawing.Size(64, 51);
            this.LabelTC.TabIndex = 0;
            this.LabelTC.Text = "TC";
            // 
            // textBoxTc
            // 
            this.textBoxTc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTc.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxTc.Location = new System.Drawing.Point(583, 72);
            this.textBoxTc.Name = "textBoxTc";
            this.textBoxTc.Size = new System.Drawing.Size(238, 43);
            this.textBoxTc.TabIndex = 1;
            this.textBoxTc.TextChanged += new System.EventHandler(this.textBoxTc_TextChanged);
            // 
            // dataGridViewTahsilat
            // 
            this.dataGridViewTahsilat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewTahsilat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTahsilat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTahsilat.Location = new System.Drawing.Point(64, 169);
            this.dataGridViewTahsilat.Name = "dataGridViewTahsilat";
            this.dataGridViewTahsilat.RowTemplate.Height = 25;
            this.dataGridViewTahsilat.Size = new System.Drawing.Size(1195, 571);
            this.dataGridViewTahsilat.TabIndex = 2;
            // 
            // Tahsilat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1271, 864);
            this.Controls.Add(this.dataGridViewTahsilat);
            this.Controls.Add(this.textBoxTc);
            this.Controls.Add(this.LabelTC);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Tahsilat";
            this.Text = "Tahsilat";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Tahsilat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTahsilat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LabelTC;
        private TextBox textBoxTc;
        private DataGridView dataGridViewTahsilat;
    }
}