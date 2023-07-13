namespace MusteriVeTarife
{
    partial class MusteriGuncelleSil
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusteriGuncelleSil));
            this.labelTC = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxAdAtanacak = new System.Windows.Forms.TextBox();
            this.textBoxSoyAdAtanacak = new System.Windows.Forms.TextBox();
            this.textBoxGSM_Atanacak = new System.Windows.Forms.TextBox();
            this.textBoxEmailAtanacak = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTC
            // 
            this.labelTC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTC.AutoSize = true;
            this.labelTC.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTC.Location = new System.Drawing.Point(453, 20);
            this.labelTC.Name = "labelTC";
            this.labelTC.Size = new System.Drawing.Size(57, 46);
            this.labelTC.TabIndex = 0;
            this.labelTC.Text = "TC";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(550, 27);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 28);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(977, 677);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(1231, 534);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(354, 73);
            this.button1.TabIndex = 6;
            this.button1.Text = "Müşteride Yapılan Değişiklikleri Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(1259, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 41);
            this.label1.TabIndex = 7;
            this.label1.Text = "İsim";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(1202, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 41);
            this.label2.TabIndex = 8;
            this.label2.Text = "Soy İsim";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(1249, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 41);
            this.label3.TabIndex = 9;
            this.label3.Text = "GSM";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(1231, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 41);
            this.label4.TabIndex = 10;
            this.label4.Text = "E-mail";
            // 
            // textBoxAdAtanacak
            // 
            this.textBoxAdAtanacak.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxAdAtanacak.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxAdAtanacak.Location = new System.Drawing.Point(1372, 106);
            this.textBoxAdAtanacak.Name = "textBoxAdAtanacak";
            this.textBoxAdAtanacak.Size = new System.Drawing.Size(100, 32);
            this.textBoxAdAtanacak.TabIndex = 11;
            // 
            // textBoxSoyAdAtanacak
            // 
            this.textBoxSoyAdAtanacak.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxSoyAdAtanacak.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxSoyAdAtanacak.Location = new System.Drawing.Point(1372, 163);
            this.textBoxSoyAdAtanacak.Name = "textBoxSoyAdAtanacak";
            this.textBoxSoyAdAtanacak.Size = new System.Drawing.Size(100, 32);
            this.textBoxSoyAdAtanacak.TabIndex = 12;
            // 
            // textBoxGSM_Atanacak
            // 
            this.textBoxGSM_Atanacak.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxGSM_Atanacak.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxGSM_Atanacak.Location = new System.Drawing.Point(1372, 221);
            this.textBoxGSM_Atanacak.Name = "textBoxGSM_Atanacak";
            this.textBoxGSM_Atanacak.Size = new System.Drawing.Size(100, 32);
            this.textBoxGSM_Atanacak.TabIndex = 13;
            // 
            // textBoxEmailAtanacak
            // 
            this.textBoxEmailAtanacak.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxEmailAtanacak.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxEmailAtanacak.Location = new System.Drawing.Point(1361, 282);
            this.textBoxEmailAtanacak.Name = "textBoxEmailAtanacak";
            this.textBoxEmailAtanacak.Size = new System.Drawing.Size(100, 32);
            this.textBoxEmailAtanacak.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(1088, 739);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "label5";
            this.label5.Visible = false;
            // 
            // MusteriGuncelleSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1464, 790);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxEmailAtanacak);
            this.Controls.Add(this.textBoxGSM_Atanacak);
            this.Controls.Add(this.textBoxSoyAdAtanacak);
            this.Controls.Add(this.textBoxAdAtanacak);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelTC);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MusteriGuncelleSil";
            this.Text = "MusteriGuncelleSil";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MusteriGuncelleSil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelTC;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private Button button1;
        private ErrorProvider errorProvider1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBoxEmailAtanacak;
        private TextBox textBoxGSM_Atanacak;
        private TextBox textBoxSoyAdAtanacak;
        private TextBox textBoxAdAtanacak;
        private Label label5;
    }
}