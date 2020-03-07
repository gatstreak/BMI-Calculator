namespace BMI_Calculator
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
            this.tbxHeight = new System.Windows.Forms.TextBox();
            this.tbxWeight = new System.Windows.Forms.TextBox();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbxHeight
            // 
            this.tbxHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.tbxHeight.Location = new System.Drawing.Point(155, 128);
            this.tbxHeight.Name = "tbxHeight";
            this.tbxHeight.Size = new System.Drawing.Size(154, 45);
            this.tbxHeight.TabIndex = 0;
            this.tbxHeight.TextChanged += new System.EventHandler(this.tbxHeight_TextChanged);
            // 
            // tbxWeight
            // 
            this.tbxWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.tbxWeight.Location = new System.Drawing.Point(155, 64);
            this.tbxWeight.Name = "tbxWeight";
            this.tbxWeight.Size = new System.Drawing.Size(154, 45);
            this.tbxWeight.TabIndex = 1;
            this.tbxWeight.TextChanged += new System.EventHandler(this.tbxWeight_TextChanged);
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lblAnswer.Location = new System.Drawing.Point(446, 64);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(192, 58);
            this.lblAnswer.TabIndex = 2;
            this.lblAnswer.Text = "Answer";
            this.lblAnswer.Click += new System.EventHandler(this.lblAnswer_Click);
            // 
            // btnCalc
            // 
            this.btnCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnCalc.Location = new System.Drawing.Point(155, 211);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(173, 48);
            this.btnCalc.TabIndex = 3;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(71, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "KG";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(59, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Meters";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(449, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Your BMI Score";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.tbxWeight);
            this.Controls.Add(this.tbxHeight);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxHeight;
        private System.Windows.Forms.TextBox tbxWeight;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

