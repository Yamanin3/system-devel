namespace 注文登録
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 510);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(677, 61);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("HGｺﾞｼｯｸM", 18F);
            this.textBox1.Location = new System.Drawing.Point(31, 10);
            this.textBox1.MinimumSize = new System.Drawing.Size(165, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(165, 40);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "社員番号";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("HGｺﾞｼｯｸM", 18F);
            this.textBox2.Location = new System.Drawing.Point(31, 60);
            this.textBox2.MinimumSize = new System.Drawing.Size(165, 40);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(165, 40);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "営業所番号";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("HGｺﾞｼｯｸM", 18F);
            this.textBox3.Location = new System.Drawing.Point(31, 110);
            this.textBox3.MinimumSize = new System.Drawing.Size(165, 40);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(165, 40);
            this.textBox3.TabIndex = 4;
            this.textBox3.Text = "注文番号";
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("HGｺﾞｼｯｸM", 18F);
            this.textBox4.Location = new System.Drawing.Point(31, 160);
            this.textBox4.MinimumSize = new System.Drawing.Size(165, 40);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(165, 40);
            this.textBox4.TabIndex = 5;
            this.textBox4.Text = "顧客番号";
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("HGｺﾞｼｯｸM", 18F);
            this.textBox5.Location = new System.Drawing.Point(31, 210);
            this.textBox5.MinimumSize = new System.Drawing.Size(165, 40);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(165, 40);
            this.textBox5.TabIndex = 6;
            this.textBox5.Text = "顧客名";
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("HGｺﾞｼｯｸM", 18F);
            this.textBox6.Location = new System.Drawing.Point(31, 360);
            this.textBox6.MinimumSize = new System.Drawing.Size(165, 40);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(165, 40);
            this.textBox6.TabIndex = 7;
            this.textBox6.Text = "商品番号";
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("HGｺﾞｼｯｸM", 18F);
            this.textBox7.Location = new System.Drawing.Point(31, 410);
            this.textBox7.MinimumSize = new System.Drawing.Size(165, 40);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(165, 40);
            this.textBox7.TabIndex = 8;
            this.textBox7.Text = "数量";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("HGｺﾞｼｯｸM", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dateTimePicker1.Location = new System.Drawing.Point(31, 460);
            this.dateTimePicker1.MinimumSize = new System.Drawing.Size(0, 40);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(165, 40);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // textBox8
            // 
            this.textBox8.Font = new System.Drawing.Font("HGｺﾞｼｯｸM", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox8.Location = new System.Drawing.Point(31, 590);
            this.textBox8.MinimumSize = new System.Drawing.Size(165, 40);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(165, 40);
            this.textBox8.TabIndex = 10;
            this.textBox8.Text = "価格";
            // 
            // textBox9
            // 
            this.textBox9.Font = new System.Drawing.Font("HGｺﾞｼｯｸM", 18F);
            this.textBox9.Location = new System.Drawing.Point(31, 640);
            this.textBox9.MinimumSize = new System.Drawing.Size(165, 40);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(165, 40);
            this.textBox9.TabIndex = 11;
            this.textBox9.Text = "小計";
            // 
            // textBox10
            // 
            this.textBox10.Font = new System.Drawing.Font("HGｺﾞｼｯｸM", 18F);
            this.textBox10.Location = new System.Drawing.Point(31, 690);
            this.textBox10.MinimumSize = new System.Drawing.Size(165, 40);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(165, 40);
            this.textBox10.TabIndex = 12;
            this.textBox10.Text = "消費銭";
            // 
            // textBox11
            // 
            this.textBox11.Font = new System.Drawing.Font("HGｺﾞｼｯｸM", 18F);
            this.textBox11.Location = new System.Drawing.Point(31, 740);
            this.textBox11.MinimumSize = new System.Drawing.Size(165, 40);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(165, 40);
            this.textBox11.TabIndex = 13;
            this.textBox11.Text = "合計";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(589, 749);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 60);
            this.button2.TabIndex = 14;
            this.button2.Text = "キャンセル";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("HGｺﾞｼｯｸM", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(31, 260);
            this.comboBox1.MinimumSize = new System.Drawing.Size(165, 0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(165, 38);
            this.comboBox1.TabIndex = 15;
            this.comboBox1.Text = "商品分類";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("HGｺﾞｼｯｸM", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(31, 310);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(165, 38);
            this.comboBox2.TabIndex = 16;
            this.comboBox2.Text = "商品";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(464, 749);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 60);
            this.button3.TabIndex = 17;
            this.button3.Text = "登録";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 818);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button3;
    }
}

