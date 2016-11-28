namespace SOAP_Dictionary_Service
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
            this.btnGetDefinition = new System.Windows.Forms.Button();
            this.txtWord = new System.Windows.Forms.TextBox();
            this.txtDefintion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.labelPageNum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGetDefinition
            // 
            this.btnGetDefinition.Location = new System.Drawing.Point(76, 51);
            this.btnGetDefinition.Name = "btnGetDefinition";
            this.btnGetDefinition.Size = new System.Drawing.Size(117, 23);
            this.btnGetDefinition.TabIndex = 0;
            this.btnGetDefinition.Text = "Get Definition";
            this.btnGetDefinition.UseVisualStyleBackColor = true;
            this.btnGetDefinition.Click += new System.EventHandler(this.btnGetDefinition_Click);
            // 
            // txtWord
            // 
            this.txtWord.Location = new System.Drawing.Point(35, 25);
            this.txtWord.Name = "txtWord";
            this.txtWord.Size = new System.Drawing.Size(200, 20);
            this.txtWord.TabIndex = 1;
            // 
            // txtDefintion
            // 
            this.txtDefintion.Location = new System.Drawing.Point(12, 120);
            this.txtDefintion.Multiline = true;
            this.txtDefintion.Name = "txtDefintion";
            this.txtDefintion.Size = new System.Drawing.Size(260, 244);
            this.txtDefintion.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Insert Word To Define";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Definitions";
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(12, 370);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.TabIndex = 5;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(197, 370);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // labelPageNum
            // 
            this.labelPageNum.AutoSize = true;
            this.labelPageNum.Location = new System.Drawing.Point(122, 375);
            this.labelPageNum.Name = "labelPageNum";
            this.labelPageNum.Size = new System.Drawing.Size(36, 13);
            this.labelPageNum.TabIndex = 7;
            this.labelPageNum.Text = "( 0/0 )";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 405);
            this.Controls.Add(this.labelPageNum);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDefintion);
            this.Controls.Add(this.txtWord);
            this.Controls.Add(this.btnGetDefinition);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetDefinition;
        private System.Windows.Forms.TextBox txtWord;
        private System.Windows.Forms.TextBox txtDefintion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label labelPageNum;
    }
}

