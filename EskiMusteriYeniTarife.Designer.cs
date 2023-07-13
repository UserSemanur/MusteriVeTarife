namespace MusteriVeTarife
{
    partial class EskiMusteriYeniTarife
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EskiMusteriYeniTarife));
            this.textBoxTC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonYeniTarifeyiAta = new System.Windows.Forms.Button();
            this.TarifeIDAtanacaktextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxTC
            // 
            this.textBoxTC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTC.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxTC.Location = new System.Drawing.Point(185, 18);
            this.textBoxTC.Multiline = true;
            this.textBoxTC.Name = "textBoxTC";
            this.textBoxTC.Size = new System.Drawing.Size(273, 43);
            this.textBoxTC.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(121, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "TC";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.RosyBrown;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 131);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(643, 544);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // buttonYeniTarifeyiAta
            // 
            this.buttonYeniTarifeyiAta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonYeniTarifeyiAta.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonYeniTarifeyiAta.Location = new System.Drawing.Point(145, 742);
            this.buttonYeniTarifeyiAta.Name = "buttonYeniTarifeyiAta";
            this.buttonYeniTarifeyiAta.Size = new System.Drawing.Size(245, 43);
            this.buttonYeniTarifeyiAta.TabIndex = 3;
            this.buttonYeniTarifeyiAta.Text = "Yeni Tarifeyi Kaydet";
            this.buttonYeniTarifeyiAta.UseVisualStyleBackColor = true;
            this.buttonYeniTarifeyiAta.Click += new System.EventHandler(this.buttonYeniTarifeyiAta_Click);
            // 
            // TarifeIDAtanacaktextBox
            // 
            this.TarifeIDAtanacaktextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TarifeIDAtanacaktextBox.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TarifeIDAtanacaktextBox.Location = new System.Drawing.Point(333, 684);
            this.TarifeIDAtanacaktextBox.Name = "TarifeIDAtanacaktextBox";
            this.TarifeIDAtanacaktextBox.Size = new System.Drawing.Size(100, 52);
            this.TarifeIDAtanacaktextBox.TabIndex = 4;
            this.TarifeIDAtanacaktextBox.TextChanged += new System.EventHandler(this.TarifeIDAtanacaktextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(96, 684);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 46);
            this.label2.TabIndex = 8;
            this.label2.Text = "Yeni Tarife ID";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(920, 759);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "label5";
            this.label5.Visible = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.RosyBrown;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(671, 131);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(666, 544);
            this.dataGridView2.TabIndex = 12;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(848, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 37);
            this.label3.TabIndex = 13;
            this.label3.Text = "TARİFELER:";
            // 
            // EskiMusteriYeniTarife
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MusteriVeTarife.Properties.Resources.desktop_wallpaper_pinterest_nature;
            this.ClientSize = new System.Drawing.Size(1339, 786);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TarifeIDAtanacaktextBox);
            this.Controls.Add(this.buttonYeniTarifeyiAta);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxTC);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EskiMusteriYeniTarife";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EskiMusteriYeniTarife";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.EskiMusteriYeniTarife_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxTC;
        private Label label1;
        private DataGridView dataGridView1;
        private Button buttonYeniTarifeyiAta;
        private TextBox TarifeIDAtanacaktextBox;
        private Label label2;
        private Label label5;
        private DataGridView dataGridView2;
        private Label label3;
    }
}