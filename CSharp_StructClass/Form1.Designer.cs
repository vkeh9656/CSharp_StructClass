namespace CSharp_StructClass
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pboxSun = new System.Windows.Forms.PictureBox();
            this.pBoxMoon = new System.Windows.Forms.PictureBox();
            this.pBoxStar = new System.Windows.Forms.PictureBox();
            this.pBoxNone = new System.Windows.Forms.PictureBox();
            this.radioPlayer1 = new System.Windows.Forms.RadioButton();
            this.radioPlayer2 = new System.Windows.Forms.RadioButton();
            this.lboxResult1 = new System.Windows.Forms.ListBox();
            this.lboxResult2 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pboxSun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxMoon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxStar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxNone)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "- 플레이어는 한번씩 돌아가면서 그림을 선택합니다.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(381, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "- 각 5회 진행 후, 해/달/별 숫자의 합이 가장 높은 사람이 승리합니다.";
            // 
            // pboxSun
            // 
            this.pboxSun.BackColor = System.Drawing.SystemColors.Control;
            this.pboxSun.Image = global::CSharp_StructClass.Properties.Resources._1;
            this.pboxSun.Location = new System.Drawing.Point(14, 69);
            this.pboxSun.Name = "pboxSun";
            this.pboxSun.Size = new System.Drawing.Size(100, 119);
            this.pboxSun.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxSun.TabIndex = 2;
            this.pboxSun.TabStop = false;
            this.pboxSun.Click += new System.EventHandler(this.pboxSun_Click);
            // 
            // pBoxMoon
            // 
            this.pBoxMoon.Image = global::CSharp_StructClass.Properties.Resources._2;
            this.pBoxMoon.Location = new System.Drawing.Point(133, 69);
            this.pBoxMoon.Name = "pBoxMoon";
            this.pBoxMoon.Size = new System.Drawing.Size(100, 119);
            this.pBoxMoon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxMoon.TabIndex = 3;
            this.pBoxMoon.TabStop = false;
            this.pBoxMoon.Click += new System.EventHandler(this.pBoxMoon_Click);
            // 
            // pBoxStar
            // 
            this.pBoxStar.Image = global::CSharp_StructClass.Properties.Resources._3;
            this.pBoxStar.Location = new System.Drawing.Point(253, 69);
            this.pBoxStar.Name = "pBoxStar";
            this.pBoxStar.Size = new System.Drawing.Size(100, 119);
            this.pBoxStar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxStar.TabIndex = 4;
            this.pBoxStar.TabStop = false;
            this.pBoxStar.Click += new System.EventHandler(this.pBoxStar_Click);
            // 
            // pBoxNone
            // 
            this.pBoxNone.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pBoxNone.Location = new System.Drawing.Point(369, 69);
            this.pBoxNone.Name = "pBoxNone";
            this.pBoxNone.Size = new System.Drawing.Size(100, 119);
            this.pBoxNone.TabIndex = 5;
            this.pBoxNone.TabStop = false;
            this.pBoxNone.Click += new System.EventHandler(this.pBoxNone_Click);
            // 
            // radioPlayer1
            // 
            this.radioPlayer1.AutoSize = true;
            this.radioPlayer1.Location = new System.Drawing.Point(14, 206);
            this.radioPlayer1.Name = "radioPlayer1";
            this.radioPlayer1.Size = new System.Drawing.Size(69, 16);
            this.radioPlayer1.TabIndex = 6;
            this.radioPlayer1.TabStop = true;
            this.radioPlayer1.Text = "Player 1";
            this.radioPlayer1.UseVisualStyleBackColor = true;
            // 
            // radioPlayer2
            // 
            this.radioPlayer2.AutoSize = true;
            this.radioPlayer2.Location = new System.Drawing.Point(278, 206);
            this.radioPlayer2.Name = "radioPlayer2";
            this.radioPlayer2.Size = new System.Drawing.Size(69, 16);
            this.radioPlayer2.TabIndex = 7;
            this.radioPlayer2.TabStop = true;
            this.radioPlayer2.Text = "Player 2";
            this.radioPlayer2.UseVisualStyleBackColor = true;
            // 
            // lboxResult1
            // 
            this.lboxResult1.FormattingEnabled = true;
            this.lboxResult1.ItemHeight = 12;
            this.lboxResult1.Location = new System.Drawing.Point(14, 228);
            this.lboxResult1.Name = "lboxResult1";
            this.lboxResult1.Size = new System.Drawing.Size(249, 100);
            this.lboxResult1.TabIndex = 8;
            // 
            // lboxResult2
            // 
            this.lboxResult2.FormattingEnabled = true;
            this.lboxResult2.ItemHeight = 12;
            this.lboxResult2.Location = new System.Drawing.Point(278, 228);
            this.lboxResult2.Name = "lboxResult2";
            this.lboxResult2.Size = new System.Drawing.Size(239, 100);
            this.lboxResult2.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 458);
            this.Controls.Add(this.lboxResult2);
            this.Controls.Add(this.lboxResult1);
            this.Controls.Add(this.radioPlayer2);
            this.Controls.Add(this.radioPlayer1);
            this.Controls.Add(this.pBoxNone);
            this.Controls.Add(this.pBoxStar);
            this.Controls.Add(this.pBoxMoon);
            this.Controls.Add(this.pboxSun);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pboxSun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxMoon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxStar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxNone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pboxSun;
        private System.Windows.Forms.PictureBox pBoxMoon;
        private System.Windows.Forms.PictureBox pBoxStar;
        private System.Windows.Forms.PictureBox pBoxNone;
        private System.Windows.Forms.RadioButton radioPlayer1;
        private System.Windows.Forms.RadioButton radioPlayer2;
        private System.Windows.Forms.ListBox lboxResult1;
        private System.Windows.Forms.ListBox lboxResult2;
    }
}

