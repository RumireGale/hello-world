namespace Assignment
{
    partial class Form2
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtDisplayOut = new System.Windows.Forms.RichTextBox();
            this.labelOut = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 36);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Path";
            // 
            // txtDisplayOut
            // 
            this.txtDisplayOut.Location = new System.Drawing.Point(13, 57);
            this.txtDisplayOut.Margin = new System.Windows.Forms.Padding(4);
            this.txtDisplayOut.Name = "txtDisplayOut";
            this.txtDisplayOut.Size = new System.Drawing.Size(364, 484);
            this.txtDisplayOut.TabIndex = 7;
            this.txtDisplayOut.Text = "";
            // 
            // labelOut
            // 
            this.labelOut.AutoSize = true;
            this.labelOut.Location = new System.Drawing.Point(309, 57);
            this.labelOut.Name = "labelOut";
            this.labelOut.Size = new System.Drawing.Size(0, 17);
            this.labelOut.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(414, 434);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(264, 78);
            this.button1.TabIndex = 10;
            this.button1.Text = "Back to Input";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(414, 323);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(264, 78);
            this.button2.TabIndex = 11;
            this.button2.Text = "To Map";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 554);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelOut);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDisplayOut);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.Text = "MRT Guide -by Yue Jun & Joseph";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txtDisplayOut;
        private System.Windows.Forms.Label labelOut;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}