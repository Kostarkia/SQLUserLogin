
namespace UserLOGİN
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.k = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.k1 = new System.Windows.Forms.TextBox();
            this.k2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // k
            // 
            this.k.AutoSize = true;
            this.k.Location = new System.Drawing.Point(10, 28);
            this.k.Name = "k";
            this.k.Size = new System.Drawing.Size(29, 13);
            this.k.TabIndex = 0;
            this.k.Text = "User";
            this.k.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // k1
            // 
            this.k1.Location = new System.Drawing.Point(98, 25);
            this.k1.Name = "k1";
            this.k1.Size = new System.Drawing.Size(100, 20);
            this.k1.TabIndex = 2;
            this.k1.TextChanged += new System.EventHandler(this.k1_TextChanged);
            // 
            // k2
            // 
            this.k2.Location = new System.Drawing.Point(98, 79);
            this.k2.Name = "k2";
            this.k2.Size = new System.Drawing.Size(100, 20);
            this.k2.TabIndex = 3;
            this.k2.TextChanged += new System.EventHandler(this.k2_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(98, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 192);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.k2);
            this.Controls.Add(this.k1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.k);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label k;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox k1;
        private System.Windows.Forms.TextBox k2;
        private System.Windows.Forms.Button button1;
    }
}

