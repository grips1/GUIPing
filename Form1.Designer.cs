namespace GUIPing
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPing = new System.Windows.Forms.Button();
            this.hostbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ttlbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPing
            // 
            this.btnPing.AutoSize = true;
            this.btnPing.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnPing.Location = new System.Drawing.Point(306, 236);
            this.btnPing.Name = "btnPing";
            this.btnPing.Size = new System.Drawing.Size(125, 30);
            this.btnPing.TabIndex = 0;
            this.btnPing.Text = "CLICK ME!";
            this.btnPing.UseVisualStyleBackColor = false;
            this.btnPing.Click += new System.EventHandler(this.btnPing_Click);
            // 
            // hostbox
            // 
            this.hostbox.Location = new System.Drawing.Point(306, 114);
            this.hostbox.Name = "hostbox";
            this.hostbox.Size = new System.Drawing.Size(125, 27);
            this.hostbox.TabIndex = 2;
            this.hostbox.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Please enter host:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Click to ping given host:";
            // 
            // ttlbox
            // 
            this.ttlbox.Location = new System.Drawing.Point(306, 169);
            this.ttlbox.Name = "ttlbox";
            this.ttlbox.Size = new System.Drawing.Size(125, 27);
            this.ttlbox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Please enter TTL:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(306, 313);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(145, 20);
            this.lbl4.TabIndex = 7;
            this.lbl4.Text = "Awaiting Button Call";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ttlbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hostbox);
            this.Controls.Add(this.btnPing);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnPing;
        private TextBox hostbox;
        private Label label1;
        private Label label2;
        private TextBox ttlbox;
        private Label label3;
        private Label lbl4;
    }
}