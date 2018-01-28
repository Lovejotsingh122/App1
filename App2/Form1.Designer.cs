namespace App2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Hi = new System.Windows.Forms.Button();
            this.bye = new System.Windows.Forms.Button();
            this.farleft = new System.Windows.Forms.Button();
            this.farright = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bye);
            this.groupBox1.Controls.Add(this.Hi);
            this.groupBox1.Location = new System.Drawing.Point(135, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Main Box";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.farright);
            this.groupBox2.Controls.Add(this.farleft);
            this.groupBox2.Location = new System.Drawing.Point(39, 131);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(394, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // Hi
            // 
            this.Hi.Location = new System.Drawing.Point(49, 19);
            this.Hi.Name = "Hi";
            this.Hi.Size = new System.Drawing.Size(75, 23);
            this.Hi.TabIndex = 0;
            this.Hi.Text = "Hi";
            this.Hi.UseVisualStyleBackColor = true;
            this.Hi.Click += new System.EventHandler(this.Hi_Click);
            // 
            // bye
            // 
            this.bye.Location = new System.Drawing.Point(49, 48);
            this.bye.Name = "bye";
            this.bye.Size = new System.Drawing.Size(75, 23);
            this.bye.TabIndex = 1;
            this.bye.Text = "Bye";
            this.bye.UseVisualStyleBackColor = true;
            this.bye.Click += new System.EventHandler(this.bye_Click);
            // 
            // farleft
            // 
            this.farleft.Location = new System.Drawing.Point(0, 11);
            this.farleft.Name = "farleft";
            this.farleft.Size = new System.Drawing.Size(75, 23);
            this.farleft.TabIndex = 0;
            this.farleft.Text = "far Left";
            this.farleft.UseVisualStyleBackColor = true;
            this.farleft.Click += new System.EventHandler(this.farleft_Click);
            // 
            // farright
            // 
            this.farright.Location = new System.Drawing.Point(319, 11);
            this.farright.Name = "farright";
            this.farright.Size = new System.Drawing.Size(75, 23);
            this.farright.TabIndex = 1;
            this.farright.Text = "far Right";
            this.farright.UseVisualStyleBackColor = true;
            this.farright.Click += new System.EventHandler(this.farright_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(145, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 299);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "HI THERE! WELCOME TO PROGRAMMING 3";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(106, 330);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(55, 17);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "BOLD";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(254, 330);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(59, 17);
            this.checkBox2.TabIndex = 4;
            this.checkBox2.Text = "ITALIC";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 501);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bye;
        private System.Windows.Forms.Button Hi;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button farright;
        private System.Windows.Forms.Button farleft;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
    }
}

