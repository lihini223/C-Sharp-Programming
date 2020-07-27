namespace SignUpForm
{
    partial class SignUp
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUname = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtCpassword = new System.Windows.Forms.TextBox();
            this.btnok = new System.Windows.Forms.Button();
            this.deletewindow = new System.Windows.Forms.Button();
            this.updatewindow = new System.Windows.Forms.Button();
            this.home = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(176, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sign Up ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "User Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(66, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(66, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Confirm Password";
            // 
            // txtUname
            // 
            this.txtUname.Location = new System.Drawing.Point(298, 120);
            this.txtUname.Name = "txtUname";
            this.txtUname.Size = new System.Drawing.Size(100, 20);
            this.txtUname.TabIndex = 4;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(298, 169);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 5;
            // 
            // txtCpassword
            // 
            this.txtCpassword.Location = new System.Drawing.Point(298, 209);
            this.txtCpassword.Name = "txtCpassword";
            this.txtCpassword.Size = new System.Drawing.Size(100, 20);
            this.txtCpassword.TabIndex = 6;
            // 
            // btnok
            // 
            this.btnok.Location = new System.Drawing.Point(71, 251);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(114, 52);
            this.btnok.TabIndex = 7;
            this.btnok.Text = "OK";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // deletewindow
            // 
            this.deletewindow.Location = new System.Drawing.Point(281, 323);
            this.deletewindow.Name = "deletewindow";
            this.deletewindow.Size = new System.Drawing.Size(117, 49);
            this.deletewindow.TabIndex = 8;
            this.deletewindow.Text = "Delete Window";
            this.deletewindow.UseVisualStyleBackColor = true;
            this.deletewindow.Click += new System.EventHandler(this.deletewindow_Click);
            // 
            // updatewindow
            // 
            this.updatewindow.Location = new System.Drawing.Point(68, 323);
            this.updatewindow.Name = "updatewindow";
            this.updatewindow.Size = new System.Drawing.Size(117, 49);
            this.updatewindow.TabIndex = 9;
            this.updatewindow.Text = "Update Window";
            this.updatewindow.UseVisualStyleBackColor = true;
            this.updatewindow.Click += new System.EventHandler(this.updatewindow_Click);
            // 
            // home
            // 
            this.home.Location = new System.Drawing.Point(281, 251);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(114, 52);
            this.home.TabIndex = 10;
            this.home.Text = "Home";
            this.home.UseVisualStyleBackColor = true;
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(499, 403);
            this.Controls.Add(this.home);
            this.Controls.Add(this.updatewindow);
            this.Controls.Add(this.deletewindow);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.txtCpassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SignUp";
            this.Text = "SignUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUname;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtCpassword;
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.Button deletewindow;
        private System.Windows.Forms.Button updatewindow;
        private System.Windows.Forms.Button home;
    }
}

