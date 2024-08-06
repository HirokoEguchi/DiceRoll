namespace DiceRoll
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
            this.btnRoll = new System.Windows.Forms.Button();
            this.picDice = new System.Windows.Forms.PictureBox();
            this.picDice2 = new System.Windows.Forms.PictureBox();
            this.picDice3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picDice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDice2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDice3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRoll
            // 
            this.btnRoll.Location = new System.Drawing.Point(355, 287);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(80, 30);
            this.btnRoll.TabIndex = 0;
            this.btnRoll.Text = "振る！";
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // picDice
            // 
            this.picDice.Location = new System.Drawing.Point(193, 97);
            this.picDice.Name = "picDice";
            this.picDice.Size = new System.Drawing.Size(100, 100);
            this.picDice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDice.TabIndex = 1;
            this.picDice.TabStop = false;
            // 
            // picDice2
            // 
            this.picDice2.Location = new System.Drawing.Point(346, 97);
            this.picDice2.Name = "picDice2";
            this.picDice2.Size = new System.Drawing.Size(100, 100);
            this.picDice2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDice2.TabIndex = 2;
            this.picDice2.TabStop = false;
            // 
            // picDice3
            // 
            this.picDice3.Location = new System.Drawing.Point(498, 97);
            this.picDice3.Name = "picDice3";
            this.picDice3.Size = new System.Drawing.Size(100, 100);
            this.picDice3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDice3.TabIndex = 3;
            this.picDice3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picDice3);
            this.Controls.Add(this.picDice2);
            this.Controls.Add(this.picDice);
            this.Controls.Add(this.btnRoll);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picDice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDice2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDice3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.PictureBox picDice;
        private System.Windows.Forms.PictureBox picDice2;
        private System.Windows.Forms.PictureBox picDice3;
    }
}

