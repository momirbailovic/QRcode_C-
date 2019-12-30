namespace QR
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEncode = new System.Windows.Forms.TextBox();
            this.butEncode = new System.Windows.Forms.Button();
            this.butDecode = new System.Windows.Forms.Button();
            this.txtDecode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.Location = new System.Drawing.Point(12, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(375, 357);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 397);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Encode";
            // 
            // txtEncode
            // 
            this.txtEncode.Location = new System.Drawing.Point(87, 397);
            this.txtEncode.Name = "txtEncode";
            this.txtEncode.Size = new System.Drawing.Size(167, 20);
            this.txtEncode.TabIndex = 2;
            // 
            // butEncode
            // 
            this.butEncode.Location = new System.Drawing.Point(260, 394);
            this.butEncode.Name = "butEncode";
            this.butEncode.Size = new System.Drawing.Size(75, 23);
            this.butEncode.TabIndex = 3;
            this.butEncode.Text = "Encode";
            this.butEncode.UseVisualStyleBackColor = true;
            this.butEncode.Click += new System.EventHandler(this.butEncode_Click);
            // 
            // butDecode
            // 
            this.butDecode.Location = new System.Drawing.Point(260, 437);
            this.butDecode.Name = "butDecode";
            this.butDecode.Size = new System.Drawing.Size(75, 23);
            this.butDecode.TabIndex = 6;
            this.butDecode.Text = "Decode";
            this.butDecode.UseVisualStyleBackColor = true;
            this.butDecode.Click += new System.EventHandler(this.butDecode_Click);
            // 
            // txtDecode
            // 
            this.txtDecode.Location = new System.Drawing.Point(87, 440);
            this.txtDecode.Name = "txtDecode";
            this.txtDecode.Size = new System.Drawing.Size(167, 20);
            this.txtDecode.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 440);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Decode";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 485);
            this.Controls.Add(this.butDecode);
            this.Controls.Add(this.txtDecode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.butEncode);
            this.Controls.Add(this.txtEncode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEncode;
        private System.Windows.Forms.Button butEncode;
        private System.Windows.Forms.Button butDecode;
        private System.Windows.Forms.TextBox txtDecode;
        private System.Windows.Forms.Label label2;
    }
}

