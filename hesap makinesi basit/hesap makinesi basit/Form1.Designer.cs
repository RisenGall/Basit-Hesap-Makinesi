namespace hesap_makinesi_basit
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            btneksi = new Button();
            btnarti = new Button();
            btnbolu = new Button();
            btncarpi = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(29, 30);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(29, 79);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(253, 60);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 2;
            // 
            // btneksi
            // 
            btneksi.Location = new Point(67, 123);
            btneksi.Name = "btneksi";
            btneksi.Size = new Size(32, 33);
            btneksi.TabIndex = 3;
            btneksi.Text = "-";
            btneksi.UseVisualStyleBackColor = true;
            btneksi.Click += btneksi_Click;
            // 
            // btnarti
            // 
            btnarti.Location = new Point(29, 123);
            btnarti.Name = "btnarti";
            btnarti.Size = new Size(32, 33);
            btnarti.TabIndex = 4;
            btnarti.Text = "+";
            btnarti.UseVisualStyleBackColor = true;
            btnarti.Click += btnarti_Click;
            // 
            // btnbolu
            // 
            btnbolu.Location = new Point(105, 123);
            btnbolu.Name = "btnbolu";
            btnbolu.Size = new Size(32, 33);
            btnbolu.TabIndex = 5;
            btnbolu.Text = "/";
            btnbolu.UseVisualStyleBackColor = true;
            btnbolu.Click += btnbolu_Click;
            // 
            // btncarpi
            // 
            btncarpi.Location = new Point(143, 123);
            btncarpi.Name = "btncarpi";
            btncarpi.Size = new Size(32, 33);
            btncarpi.TabIndex = 6;
            btncarpi.Text = "x";
            btncarpi.UseVisualStyleBackColor = true;
            btncarpi.Click += btncarpi_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(180, 60);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 7;
            label2.Text = "Sonuç :";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(341, 215);
            Controls.Add(label2);
            Controls.Add(btncarpi);
            Controls.Add(btnbolu);
            Controls.Add(btnarti);
            Controls.Add(btneksi);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Button btneksi;
        private Button btnarti;
        private Button btnbolu;
        private Button btncarpi;
        private Label label2;
    }
}