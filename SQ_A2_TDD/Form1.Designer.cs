namespace SQ_A2_TDD
{
    partial class Form1
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
            this.txtSideA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSideB = new System.Windows.Forms.TextBox();
            this.btnArea = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbSideC = new System.Windows.Forms.Label();
            this.btnHypo = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAngleA = new System.Windows.Forms.TextBox();
            this.txtAngleB = new System.Windows.Forms.TextBox();
            this.btnAngle = new System.Windows.Forms.Button();
            this.lbAngleC = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbArea = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSideA
            // 
            this.txtSideA.Location = new System.Drawing.Point(88, 50);
            this.txtSideA.Name = "txtSideA";
            this.txtSideA.Size = new System.Drawing.Size(100, 20);
            this.txtSideA.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Side A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Side B";
            // 
            // txtSideB
            // 
            this.txtSideB.Location = new System.Drawing.Point(88, 114);
            this.txtSideB.Name = "txtSideB";
            this.txtSideB.Size = new System.Drawing.Size(100, 20);
            this.txtSideB.TabIndex = 3;
            // 
            // btnArea
            // 
            this.btnArea.Location = new System.Drawing.Point(47, 307);
            this.btnArea.Name = "btnArea";
            this.btnArea.Size = new System.Drawing.Size(75, 23);
            this.btnArea.TabIndex = 4;
            this.btnArea.Text = "Find Area";
            this.btnArea.UseVisualStyleBackColor = true;
            this.btnArea.Click += new System.EventHandler(this.btnArea_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Side C";
            // 
            // lbSideC
            // 
            this.lbSideC.AutoSize = true;
            this.lbSideC.ForeColor = System.Drawing.Color.Black;
            this.lbSideC.Location = new System.Drawing.Point(121, 185);
            this.lbSideC.Name = "lbSideC";
            this.lbSideC.Size = new System.Drawing.Size(0, 13);
            this.lbSideC.TabIndex = 6;
            // 
            // btnHypo
            // 
            this.btnHypo.Location = new System.Drawing.Point(69, 237);
            this.btnHypo.Name = "btnHypo";
            this.btnHypo.Size = new System.Drawing.Size(144, 23);
            this.btnHypo.TabIndex = 7;
            this.btnHypo.Text = "Calaculate Hypotenuse";
            this.btnHypo.UseVisualStyleBackColor = true;
            this.btnHypo.Click += new System.EventHandler(this.btnHypo_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(322, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Angle A";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(322, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Angle B";
            // 
            // txtAngleA
            // 
            this.txtAngleA.Location = new System.Drawing.Point(216, 51);
            this.txtAngleA.Name = "txtAngleA";
            this.txtAngleA.Size = new System.Drawing.Size(100, 20);
            this.txtAngleA.TabIndex = 10;
            // 
            // txtAngleB
            // 
            this.txtAngleB.Location = new System.Drawing.Point(216, 114);
            this.txtAngleB.Name = "txtAngleB";
            this.txtAngleB.Size = new System.Drawing.Size(100, 20);
            this.txtAngleB.TabIndex = 11;
            // 
            // btnAngle
            // 
            this.btnAngle.Location = new System.Drawing.Point(241, 237);
            this.btnAngle.Name = "btnAngle";
            this.btnAngle.Size = new System.Drawing.Size(75, 23);
            this.btnAngle.TabIndex = 12;
            this.btnAngle.Text = "Find Angle";
            this.btnAngle.UseVisualStyleBackColor = true;
            this.btnAngle.Click += new System.EventHandler(this.btnAngle_Click);
            // 
            // lbAngleC
            // 
            this.lbAngleC.AutoSize = true;
            this.lbAngleC.Location = new System.Drawing.Point(249, 177);
            this.lbAngleC.Name = "lbAngleC";
            this.lbAngleC.Size = new System.Drawing.Size(0, 13);
            this.lbAngleC.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(322, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Angle C";
            // 
            // lbArea
            // 
            this.lbArea.AutoSize = true;
            this.lbArea.ForeColor = System.Drawing.Color.Black;
            this.lbArea.Location = new System.Drawing.Point(178, 312);
            this.lbArea.Name = "lbArea";
            this.lbArea.Size = new System.Drawing.Size(0, 13);
            this.lbArea.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(140, 312);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Area";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 359);
            this.Controls.Add(this.lbArea);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbAngleC);
            this.Controls.Add(this.btnAngle);
            this.Controls.Add(this.txtAngleB);
            this.Controls.Add(this.txtAngleA);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnHypo);
            this.Controls.Add(this.lbSideC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnArea);
            this.Controls.Add(this.txtSideB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSideA);
            this.Name = "Form1";
            this.Text = "SQ Assingment 2 TDD";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSideA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSideB;
        private System.Windows.Forms.Button btnArea;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbSideC;
        private System.Windows.Forms.Button btnHypo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAngleA;
        private System.Windows.Forms.TextBox txtAngleB;
        private System.Windows.Forms.Button btnAngle;
        private System.Windows.Forms.Label lbAngleC;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbArea;
        private System.Windows.Forms.Label label8;
    }
}

