
namespace AltinFiyatlari
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.lbl_info_altin = new System.Windows.Forms.Label();
            this.lbl_info_alis = new System.Windows.Forms.Label();
            this.lbl_info_satis = new System.Windows.Forms.Label();
            this.lbl_info_gram = new System.Windows.Forms.Label();
            this.lbl_value_gram_alis = new System.Windows.Forms.Label();
            this.lbl_value_gram_satis = new System.Windows.Forms.Label();
            this.lbl_value_ceyrek_satis = new System.Windows.Forms.Label();
            this.lbl_value_ceyrek_alis = new System.Windows.Forms.Label();
            this.lbl_info_ceyrek = new System.Windows.Forms.Label();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_info_altin
            // 
            this.lbl_info_altin.AutoSize = true;
            this.lbl_info_altin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_info_altin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_info_altin.Location = new System.Drawing.Point(15, 15);
            this.lbl_info_altin.Name = "lbl_info_altin";
            this.lbl_info_altin.Size = new System.Drawing.Size(38, 16);
            this.lbl_info_altin.TabIndex = 0;
            this.lbl_info_altin.Text = "Altın";
            // 
            // lbl_info_alis
            // 
            this.lbl_info_alis.AutoSize = true;
            this.lbl_info_alis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_info_alis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_info_alis.Location = new System.Drawing.Point(100, 15);
            this.lbl_info_alis.Name = "lbl_info_alis";
            this.lbl_info_alis.Size = new System.Drawing.Size(34, 16);
            this.lbl_info_alis.TabIndex = 1;
            this.lbl_info_alis.Text = "Alış";
            // 
            // lbl_info_satis
            // 
            this.lbl_info_satis.AutoSize = true;
            this.lbl_info_satis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_info_satis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_info_satis.Location = new System.Drawing.Point(185, 15);
            this.lbl_info_satis.Name = "lbl_info_satis";
            this.lbl_info_satis.Size = new System.Drawing.Size(43, 16);
            this.lbl_info_satis.TabIndex = 2;
            this.lbl_info_satis.Text = "Satış";
            // 
            // lbl_info_gram
            // 
            this.lbl_info_gram.AutoSize = true;
            this.lbl_info_gram.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_info_gram.Location = new System.Drawing.Point(15, 60);
            this.lbl_info_gram.Name = "lbl_info_gram";
            this.lbl_info_gram.Size = new System.Drawing.Size(42, 15);
            this.lbl_info_gram.TabIndex = 3;
            this.lbl_info_gram.Text = "Gram";
            // 
            // lbl_value_gram_alis
            // 
            this.lbl_value_gram_alis.AutoSize = true;
            this.lbl_value_gram_alis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_value_gram_alis.ForeColor = System.Drawing.Color.Red;
            this.lbl_value_gram_alis.Location = new System.Drawing.Point(100, 60);
            this.lbl_value_gram_alis.Name = "lbl_value_gram_alis";
            this.lbl_value_gram_alis.Size = new System.Drawing.Size(11, 15);
            this.lbl_value_gram_alis.TabIndex = 4;
            this.lbl_value_gram_alis.Text = "-";
            // 
            // lbl_value_gram_satis
            // 
            this.lbl_value_gram_satis.AutoSize = true;
            this.lbl_value_gram_satis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_value_gram_satis.ForeColor = System.Drawing.Color.Red;
            this.lbl_value_gram_satis.Location = new System.Drawing.Point(185, 60);
            this.lbl_value_gram_satis.Name = "lbl_value_gram_satis";
            this.lbl_value_gram_satis.Size = new System.Drawing.Size(11, 15);
            this.lbl_value_gram_satis.TabIndex = 5;
            this.lbl_value_gram_satis.Text = "-";
            // 
            // lbl_value_ceyrek_satis
            // 
            this.lbl_value_ceyrek_satis.AutoSize = true;
            this.lbl_value_ceyrek_satis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_value_ceyrek_satis.ForeColor = System.Drawing.Color.Red;
            this.lbl_value_ceyrek_satis.Location = new System.Drawing.Point(185, 105);
            this.lbl_value_ceyrek_satis.Name = "lbl_value_ceyrek_satis";
            this.lbl_value_ceyrek_satis.Size = new System.Drawing.Size(11, 15);
            this.lbl_value_ceyrek_satis.TabIndex = 8;
            this.lbl_value_ceyrek_satis.Text = "-";
            // 
            // lbl_value_ceyrek_alis
            // 
            this.lbl_value_ceyrek_alis.AutoSize = true;
            this.lbl_value_ceyrek_alis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_value_ceyrek_alis.ForeColor = System.Drawing.Color.Red;
            this.lbl_value_ceyrek_alis.Location = new System.Drawing.Point(100, 105);
            this.lbl_value_ceyrek_alis.Name = "lbl_value_ceyrek_alis";
            this.lbl_value_ceyrek_alis.Size = new System.Drawing.Size(11, 15);
            this.lbl_value_ceyrek_alis.TabIndex = 7;
            this.lbl_value_ceyrek_alis.Text = "-";
            // 
            // lbl_info_ceyrek
            // 
            this.lbl_info_ceyrek.AutoSize = true;
            this.lbl_info_ceyrek.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_info_ceyrek.Location = new System.Drawing.Point(15, 105);
            this.lbl_info_ceyrek.Name = "lbl_info_ceyrek";
            this.lbl_info_ceyrek.Size = new System.Drawing.Size(50, 15);
            this.lbl_info_ceyrek.TabIndex = 6;
            this.lbl_info_ceyrek.Text = "Çeyrek";
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(181, 160);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(75, 23);
            this.btn_refresh.TabIndex = 9;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 195);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.lbl_value_ceyrek_satis);
            this.Controls.Add(this.lbl_value_ceyrek_alis);
            this.Controls.Add(this.lbl_info_ceyrek);
            this.Controls.Add(this.lbl_value_gram_satis);
            this.Controls.Add(this.lbl_value_gram_alis);
            this.Controls.Add(this.lbl_info_gram);
            this.Controls.Add(this.lbl_info_satis);
            this.Controls.Add(this.lbl_info_alis);
            this.Controls.Add(this.lbl_info_altin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.Text = "AltinFiyatlari";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_info_altin;
        private System.Windows.Forms.Label lbl_info_alis;
        private System.Windows.Forms.Label lbl_info_satis;
        private System.Windows.Forms.Label lbl_info_gram;
        private System.Windows.Forms.Label lbl_value_gram_alis;
        private System.Windows.Forms.Label lbl_value_gram_satis;
        private System.Windows.Forms.Label lbl_value_ceyrek_satis;
        private System.Windows.Forms.Label lbl_value_ceyrek_alis;
        private System.Windows.Forms.Label lbl_info_ceyrek;
        private System.Windows.Forms.Button btn_refresh;
    }
}

