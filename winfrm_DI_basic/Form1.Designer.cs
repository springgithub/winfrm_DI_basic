namespace winfrm_DI_basic
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
            this.tbxMsg = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDepInj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxMsg
            // 
            this.tbxMsg.Location = new System.Drawing.Point(72, 113);
            this.tbxMsg.Multiline = true;
            this.tbxMsg.Name = "tbxMsg";
            this.tbxMsg.Size = new System.Drawing.Size(685, 710);
            this.tbxMsg.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(869, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(277, 186);
            this.button1.TabIndex = 1;
            this.button1.Text = "No Dep Injection";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(869, 647);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(290, 176);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDepInj
            // 
            this.btnDepInj.Location = new System.Drawing.Point(880, 373);
            this.btnDepInj.Name = "btnDepInj";
            this.btnDepInj.Size = new System.Drawing.Size(266, 180);
            this.btnDepInj.TabIndex = 3;
            this.btnDepInj.Text = "Dep Injection";
            this.btnDepInj.UseVisualStyleBackColor = true;
            this.btnDepInj.Click += new System.EventHandler(this.btnDepInj_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1315, 1016);
            this.Controls.Add(this.btnDepInj);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbxMsg);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxMsg;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDepInj;
    }
}

