namespace Barber_Shop
{
    partial class Main_form
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.customer = new System.Windows.Forms.Button();
            this.shop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // customer
            // 
            this.customer.Location = new System.Drawing.Point(331, 128);
            this.customer.Name = "customer";
            this.customer.Size = new System.Drawing.Size(136, 54);
            this.customer.TabIndex = 0;
            this.customer.Text = "customer";
            this.customer.UseVisualStyleBackColor = true;
            this.customer.Click += new System.EventHandler(this.customer_Click);
            // 
            // shop
            // 
            this.shop.Location = new System.Drawing.Point(331, 220);
            this.shop.Name = "shop";
            this.shop.Size = new System.Drawing.Size(136, 59);
            this.shop.TabIndex = 1;
            this.shop.Text = "shop";
            this.shop.UseVisualStyleBackColor = true;
            this.shop.Click += new System.EventHandler(this.shop_Click);
            // 
            // Main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.shop);
            this.Controls.Add(this.customer);
            this.Name = "Main_form";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button customer;
        private System.Windows.Forms.Button shop;
    }
}

