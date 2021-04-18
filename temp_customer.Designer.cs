namespace Barber_Shop
{
    partial class temp_customer
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
            this.m_account = new System.Windows.Forms.TextBox();
            this.m_password = new System.Windows.Forms.TextBox();
            this.password_check = new System.Windows.Forms.TextBox();
            this.m_submit = new System.Windows.Forms.Button();
            this.log_in = new System.Windows.Forms.RadioButton();
            this.sign_up = new System.Windows.Forms.RadioButton();
            this.account_lb = new System.Windows.Forms.Label();
            this.password_lb = new System.Windows.Forms.Label();
            this.pw_check_lb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // m_account
            // 
            this.m_account.Location = new System.Drawing.Point(118, 48);
            this.m_account.Name = "m_account";
            this.m_account.Size = new System.Drawing.Size(100, 22);
            this.m_account.TabIndex = 0;
            // 
            // m_password
            // 
            this.m_password.Location = new System.Drawing.Point(118, 76);
            this.m_password.Name = "m_password";
            this.m_password.Size = new System.Drawing.Size(100, 22);
            this.m_password.TabIndex = 1;
            // 
            // password_check
            // 
            this.password_check.Location = new System.Drawing.Point(118, 104);
            this.password_check.Name = "password_check";
            this.password_check.Size = new System.Drawing.Size(100, 22);
            this.password_check.TabIndex = 2;
            this.password_check.Visible = false;
            // 
            // m_submit
            // 
            this.m_submit.Location = new System.Drawing.Point(118, 150);
            this.m_submit.Name = "m_submit";
            this.m_submit.Size = new System.Drawing.Size(75, 23);
            this.m_submit.TabIndex = 3;
            this.m_submit.Text = "submit";
            this.m_submit.UseMnemonic = false;
            this.m_submit.UseVisualStyleBackColor = true;
            // 
            // log_in
            // 
            this.log_in.AutoSize = true;
            this.log_in.Location = new System.Drawing.Point(245, 56);
            this.log_in.Name = "log_in";
            this.log_in.Size = new System.Drawing.Size(54, 16);
            this.log_in.TabIndex = 4;
            this.log_in.TabStop = true;
            this.log_in.Text = "Log in";
            this.log_in.UseVisualStyleBackColor = true;
            // 
            // sign_up
            // 
            this.sign_up.AutoSize = true;
            this.sign_up.Location = new System.Drawing.Point(245, 84);
            this.sign_up.Name = "sign_up";
            this.sign_up.Size = new System.Drawing.Size(59, 16);
            this.sign_up.TabIndex = 5;
            this.sign_up.TabStop = true;
            this.sign_up.Text = "Sign up";
            this.sign_up.UseVisualStyleBackColor = true;
            // 
            // account_lb
            // 
            this.account_lb.AutoSize = true;
            this.account_lb.Location = new System.Drawing.Point(29, 58);
            this.account_lb.Name = "account_lb";
            this.account_lb.Size = new System.Drawing.Size(41, 12);
            this.account_lb.TabIndex = 6;
            this.account_lb.Text = "account";
            // 
            // password_lb
            // 
            this.password_lb.AutoSize = true;
            this.password_lb.Location = new System.Drawing.Point(29, 86);
            this.password_lb.Name = "password_lb";
            this.password_lb.Size = new System.Drawing.Size(48, 12);
            this.password_lb.TabIndex = 7;
            this.password_lb.Text = "password";
            // 
            // pw_check_lb
            // 
            this.pw_check_lb.AutoSize = true;
            this.pw_check_lb.Location = new System.Drawing.Point(29, 114);
            this.pw_check_lb.Name = "pw_check_lb";
            this.pw_check_lb.Size = new System.Drawing.Size(79, 12);
            this.pw_check_lb.TabIndex = 8;
            this.pw_check_lb.Text = "repeat password";
            this.pw_check_lb.Visible = false;
            // 
            // temp_customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 290);
            this.Controls.Add(this.pw_check_lb);
            this.Controls.Add(this.password_lb);
            this.Controls.Add(this.account_lb);
            this.Controls.Add(this.sign_up);
            this.Controls.Add(this.log_in);
            this.Controls.Add(this.m_submit);
            this.Controls.Add(this.password_check);
            this.Controls.Add(this.m_password);
            this.Controls.Add(this.m_account);
            this.Name = "temp_customer";
            this.Text = "account";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.TextBox m_account;
        private System.Windows.Forms.TextBox m_password;
        private System.Windows.Forms.TextBox password_check;
        private System.Windows.Forms.Button m_submit;
        private System.Windows.Forms.RadioButton log_in;
        private System.Windows.Forms.RadioButton sign_up;
        private System.Windows.Forms.Label account_lb;
        private System.Windows.Forms.Label password_lb;
        private System.Windows.Forms.Label pw_check_lb;
        #endregion
    }
}