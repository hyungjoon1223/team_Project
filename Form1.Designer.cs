﻿namespace team_Project {
    partial class Form1 {
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
            this.LeftBox = new System.Windows.Forms.PictureBox();
            this.RightBox = new System.Windows.Forms.PictureBox();
            this.btn_openMap = new System.Windows.Forms.Button();
            this.btn_exp = new System.Windows.Forms.Button();
            this.btn_ero = new System.Windows.Forms.Button();
            this.btn_hist = new System.Windows.Forms.Button();
            this.btn_otsu = new System.Windows.Forms.Button();
            this.btn_gau = new System.Windows.Forms.Button();
            this.btn_lap = new System.Windows.Forms.Button();
            this.scope_box = new System.Windows.Forms.PictureBox();
            this.lbl_gray = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btn_match = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.LeftBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scope_box)).BeginInit();
            this.SuspendLayout();
            // 
            // LeftBox
            // 
            this.LeftBox.Location = new System.Drawing.Point(24, 72);
            this.LeftBox.Name = "LeftBox";
            this.LeftBox.Size = new System.Drawing.Size(370, 370);
            this.LeftBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LeftBox.TabIndex = 0;
            this.LeftBox.TabStop = false;
            // 
            // RightBox
            // 
            this.RightBox.Location = new System.Drawing.Point(419, 72);
            this.RightBox.Name = "RightBox";
            this.RightBox.Size = new System.Drawing.Size(370, 370);
            this.RightBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RightBox.TabIndex = 0;
            this.RightBox.TabStop = false;
            // 
            // btn_openMap
            // 
            this.btn_openMap.Location = new System.Drawing.Point(24, 24);
            this.btn_openMap.Name = "btn_openMap";
            this.btn_openMap.Size = new System.Drawing.Size(109, 33);
            this.btn_openMap.TabIndex = 1;
            this.btn_openMap.Text = "미니맵";
            this.btn_openMap.UseVisualStyleBackColor = true;
            // 
            // btn_exp
            // 
            this.btn_exp.Location = new System.Drawing.Point(810, 24);
            this.btn_exp.Name = "btn_exp";
            this.btn_exp.Size = new System.Drawing.Size(109, 33);
            this.btn_exp.TabIndex = 1;
            this.btn_exp.Text = "팽창연산";
            this.btn_exp.UseVisualStyleBackColor = true;
            // 
            // btn_ero
            // 
            this.btn_ero.Location = new System.Drawing.Point(810, 72);
            this.btn_ero.Name = "btn_ero";
            this.btn_ero.Size = new System.Drawing.Size(109, 33);
            this.btn_ero.TabIndex = 1;
            this.btn_ero.Text = "침식연산";
            this.btn_ero.UseVisualStyleBackColor = true;
            // 
            // btn_hist
            // 
            this.btn_hist.Location = new System.Drawing.Point(810, 122);
            this.btn_hist.Name = "btn_hist";
            this.btn_hist.Size = new System.Drawing.Size(109, 33);
            this.btn_hist.TabIndex = 1;
            this.btn_hist.Text = "히스토그램";
            this.btn_hist.UseVisualStyleBackColor = true;
            // 
            // btn_otsu
            // 
            this.btn_otsu.Location = new System.Drawing.Point(810, 170);
            this.btn_otsu.Name = "btn_otsu";
            this.btn_otsu.Size = new System.Drawing.Size(109, 33);
            this.btn_otsu.TabIndex = 1;
            this.btn_otsu.Text = "오츠이진화";
            this.btn_otsu.UseVisualStyleBackColor = true;
            // 
            // btn_gau
            // 
            this.btn_gau.Location = new System.Drawing.Point(810, 219);
            this.btn_gau.Name = "btn_gau";
            this.btn_gau.Size = new System.Drawing.Size(109, 33);
            this.btn_gau.TabIndex = 1;
            this.btn_gau.Text = "가우시안";
            this.btn_gau.UseVisualStyleBackColor = true;
            // 
            // btn_lap
            // 
            this.btn_lap.Location = new System.Drawing.Point(810, 267);
            this.btn_lap.Name = "btn_lap";
            this.btn_lap.Size = new System.Drawing.Size(109, 33);
            this.btn_lap.TabIndex = 1;
            this.btn_lap.Text = "라플라시안";
            this.btn_lap.UseVisualStyleBackColor = true;
            // 
            // scope_box
            // 
            this.scope_box.Location = new System.Drawing.Point(816, 449);
            this.scope_box.Name = "scope_box";
            this.scope_box.Size = new System.Drawing.Size(100, 100);
            this.scope_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.scope_box.TabIndex = 2;
            this.scope_box.TabStop = false;
            // 
            // lbl_gray
            // 
            this.lbl_gray.AutoSize = true;
            this.lbl_gray.Location = new System.Drawing.Point(813, 415);
            this.lbl_gray.Name = "lbl_gray";
            this.lbl_gray.Size = new System.Drawing.Size(50, 15);
            this.lbl_gray.TabIndex = 3;
            this.lbl_gray.Text = "gray : ";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(83, 464);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(109, 33);
            this.button7.TabIndex = 1;
            this.button7.Text = "불러오기";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(217, 464);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(109, 33);
            this.button8.TabIndex = 1;
            this.button8.Text = "저장";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(479, 464);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(109, 33);
            this.button9.TabIndex = 1;
            this.button9.Text = "불러오기";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(613, 464);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(109, 33);
            this.button10.TabIndex = 1;
            this.button10.Text = "저장";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(24, 525);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(765, 23);
            this.progressBar1.TabIndex = 4;
            // 
            // btn_match
            // 
            this.btn_match.Location = new System.Drawing.Point(810, 349);
            this.btn_match.Name = "btn_match";
            this.btn_match.Size = new System.Drawing.Size(109, 33);
            this.btn_match.TabIndex = 1;
            this.btn_match.Text = "탬플릿매칭";
            this.btn_match.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 570);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lbl_gray);
            this.Controls.Add(this.scope_box);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.btn_match);
            this.Controls.Add(this.btn_lap);
            this.Controls.Add(this.btn_gau);
            this.Controls.Add(this.btn_otsu);
            this.Controls.Add(this.btn_hist);
            this.Controls.Add(this.btn_ero);
            this.Controls.Add(this.btn_exp);
            this.Controls.Add(this.btn_openMap);
            this.Controls.Add(this.RightBox);
            this.Controls.Add(this.LeftBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.LeftBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scope_box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox LeftBox;
        private System.Windows.Forms.PictureBox RightBox;
        private System.Windows.Forms.Button btn_openMap;
        private System.Windows.Forms.Button btn_exp;
        private System.Windows.Forms.Button btn_ero;
        private System.Windows.Forms.Button btn_hist;
        private System.Windows.Forms.Button btn_otsu;
        private System.Windows.Forms.Button btn_gau;
        private System.Windows.Forms.Button btn_lap;
        private System.Windows.Forms.PictureBox scope_box;
        private System.Windows.Forms.Label lbl_gray;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btn_match;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

