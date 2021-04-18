namespace Barber_Shop
{
    partial class Barber_part
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
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage = new System.Windows.Forms.TabControl();
            this.barber_browse = new System.Windows.Forms.TabPage();
            this.transaction_history = new System.Windows.Forms.TabPage();
            this._history = new System.Windows.Forms.DataGridView();
            this.customer_browse = new System.Windows.Forms.TabPage();
            this._customer = new System.Windows.Forms.DataGridView();
            this._barber = new System.Windows.Forms.DataGridView();
            this.tabPage.SuspendLayout();
            this.barber_browse.SuspendLayout();
            this.transaction_history.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._history)).BeginInit();
            this.customer_browse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._customer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._barber)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(713, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage
            // 
            this.tabPage.Controls.Add(this.barber_browse);
            this.tabPage.Controls.Add(this.transaction_history);
            this.tabPage.Controls.Add(this.customer_browse);
            this.tabPage.Location = new System.Drawing.Point(12, 51);
            this.tabPage.Name = "tabPage";
            this.tabPage.SelectedIndex = 0;
            this.tabPage.Size = new System.Drawing.Size(776, 387);
            this.tabPage.TabIndex = 1;
            // 
            // barber_browse
            // 
            this.barber_browse.Controls.Add(this._barber);
            this.barber_browse.Location = new System.Drawing.Point(4, 22);
            this.barber_browse.Name = "barber_browse";
            this.barber_browse.Padding = new System.Windows.Forms.Padding(3);
            this.barber_browse.Size = new System.Drawing.Size(768, 361);
            this.barber_browse.TabIndex = 0;
            this.barber_browse.Text = "barber";
            this.barber_browse.UseVisualStyleBackColor = true;
            // 
            // transaction_history
            // 
            this.transaction_history.Controls.Add(this._history);
            this.transaction_history.Location = new System.Drawing.Point(4, 22);
            this.transaction_history.Name = "transaction_history";
            this.transaction_history.Padding = new System.Windows.Forms.Padding(3);
            this.transaction_history.Size = new System.Drawing.Size(768, 361);
            this.transaction_history.TabIndex = 1;
            this.transaction_history.Text = "history";
            this.transaction_history.UseVisualStyleBackColor = true;
            // 
            // _history
            // 
            this._history.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._history.Location = new System.Drawing.Point(0, 0);
            this._history.Name = "_history";
            this._history.RowTemplate.Height = 24;
            this._history.Size = new System.Drawing.Size(765, 358);
            this._history.TabIndex = 0;
            // 
            // customer_browse
            // 
            this.customer_browse.Controls.Add(this._customer);
            this.customer_browse.Location = new System.Drawing.Point(4, 22);
            this.customer_browse.Name = "customer_browse";
            this.customer_browse.Size = new System.Drawing.Size(768, 361);
            this.customer_browse.TabIndex = 2;
            this.customer_browse.Text = "customer";
            this.customer_browse.UseVisualStyleBackColor = true;
            // 
            // _customer
            // 
            this._customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._customer.Location = new System.Drawing.Point(3, 3);
            this._customer.Name = "_customer";
            this._customer.RowTemplate.Height = 24;
            this._customer.Size = new System.Drawing.Size(762, 355);
            this._customer.TabIndex = 0;
            // 
            // _barber
            // 
            this._barber.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._barber.Location = new System.Drawing.Point(6, 6);
            this._barber.Name = "_barber";
            this._barber.RowTemplate.Height = 24;
            this._barber.Size = new System.Drawing.Size(756, 349);
            this._barber.TabIndex = 0;
            // 
            // Barber_part
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabPage);
            this.Controls.Add(this.button1);
            this.Name = "Barber_part";
            this.Text = "Barber_part";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Barber_FormClosing);
            this.tabPage.ResumeLayout(false);
            this.barber_browse.ResumeLayout(false);
            this.transaction_history.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._history)).EndInit();
            this.customer_browse.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._customer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._barber)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabPage;
        private System.Windows.Forms.TabPage barber_browse;
        private System.Windows.Forms.TabPage transaction_history;
        private System.Windows.Forms.DataGridView _history;
        private System.Windows.Forms.TabPage customer_browse;
        private System.Windows.Forms.DataGridView _customer;
        private System.Windows.Forms.DataGridView _barber;
    }
}