namespace zaikoitirann
{
    partial class gridview_s
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.GridView1 = new System.Windows.Forms.DataGridView();
            this.lbl_h = new System.Windows.Forms.Label();
            this.bt_r = new System.Windows.Forms.Button();
            this.bt_e = new System.Windows.Forms.Button();
            this.lbl_S = new System.Windows.Forms.Label();
            this.txt_d = new System.Windows.Forms.TextBox();
            this.lbl_o = new System.Windows.Forms.Label();
            this.comboBox_e = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.GridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // GridView1
            // 
            this.GridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView1.Location = new System.Drawing.Point(82, 202);
            this.GridView1.Name = "GridView1";
            this.GridView1.RowTemplate.Height = 24;
            this.GridView1.Size = new System.Drawing.Size(488, 247);
            this.GridView1.TabIndex = 0;
            // 
            // lbl_h
            // 
            this.lbl_h.AutoSize = true;
            this.lbl_h.Location = new System.Drawing.Point(60, 32);
            this.lbl_h.Name = "lbl_h";
            this.lbl_h.Size = new System.Drawing.Size(67, 15);
            this.lbl_h.TabIndex = 1;
            this.lbl_h.Text = "在庫一覧";
            // 
            // bt_r
            // 
            this.bt_r.Location = new System.Drawing.Point(511, 136);
            this.bt_r.Name = "bt_r";
            this.bt_r.Size = new System.Drawing.Size(75, 23);
            this.bt_r.TabIndex = 2;
            this.bt_r.Text = "戻る";
            this.bt_r.UseVisualStyleBackColor = true;
            // 
            // bt_e
            // 
            this.bt_e.Location = new System.Drawing.Point(369, 136);
            this.bt_e.Name = "bt_e";
            this.bt_e.Size = new System.Drawing.Size(75, 23);
            this.bt_e.TabIndex = 3;
            this.bt_e.Text = "検索";
            this.bt_e.UseVisualStyleBackColor = true;
            // 
            // lbl_S
            // 
            this.lbl_S.AutoSize = true;
            this.lbl_S.Location = new System.Drawing.Point(105, 125);
            this.lbl_S.Name = "lbl_S";
            this.lbl_S.Size = new System.Drawing.Size(52, 15);
            this.lbl_S.TabIndex = 4;
            this.lbl_S.Text = "商品名";
            // 
            // txt_d
            // 
            this.txt_d.Location = new System.Drawing.Point(194, 125);
            this.txt_d.Name = "txt_d";
            this.txt_d.Size = new System.Drawing.Size(100, 22);
            this.txt_d.TabIndex = 5;
            // 
            // lbl_o
            // 
            this.lbl_o.AutoSize = true;
            this.lbl_o.Location = new System.Drawing.Point(105, 82);
            this.lbl_o.Name = "lbl_o";
            this.lbl_o.Size = new System.Drawing.Size(50, 15);
            this.lbl_o.TabIndex = 6;
            this.lbl_o.Text = "カテゴリ";
            this.lbl_o.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBox_e
            // 
            this.comboBox_e.FormattingEnabled = true;
            this.comboBox_e.Location = new System.Drawing.Point(194, 82);
            this.comboBox_e.Name = "comboBox_e";
            this.comboBox_e.Size = new System.Drawing.Size(100, 23);
            this.comboBox_e.TabIndex = 7;
            // 
            // gridview_s
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox_e);
            this.Controls.Add(this.lbl_o);
            this.Controls.Add(this.txt_d);
            this.Controls.Add(this.lbl_S);
            this.Controls.Add(this.bt_e);
            this.Controls.Add(this.bt_r);
            this.Controls.Add(this.lbl_h);
            this.Controls.Add(this.GridView1);
            this.Name = "gridview_s";
            this.Text = "在庫一覧";
            ((System.ComponentModel.ISupportInitialize)(this.GridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridView1;
        private System.Windows.Forms.Label lbl_h;
        private System.Windows.Forms.Button bt_r;
        private System.Windows.Forms.Button bt_e;
        private System.Windows.Forms.Label lbl_S;
        private System.Windows.Forms.TextBox txt_d;
        private System.Windows.Forms.Label lbl_o;
        private System.Windows.Forms.ComboBox comboBox_e;
    }
}

