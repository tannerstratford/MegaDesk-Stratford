
namespace MegaDesk_Stratford
{
    partial class MainMenu
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
            this.btn_add_new_quote = new System.Windows.Forms.Button();
            this.btn_view_quotes = new System.Windows.Forms.Button();
            this.btn_search_quotes = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_add_new_quote
            // 
            this.btn_add_new_quote.AutoSize = true;
            this.btn_add_new_quote.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_new_quote.Location = new System.Drawing.Point(63, 45);
            this.btn_add_new_quote.Name = "btn_add_new_quote";
            this.btn_add_new_quote.Size = new System.Drawing.Size(176, 36);
            this.btn_add_new_quote.TabIndex = 0;
            this.btn_add_new_quote.Text = "Add New Quote";
            this.btn_add_new_quote.UseVisualStyleBackColor = true;
            this.btn_add_new_quote.Click += new System.EventHandler(this.btn_add_new_quote_Click);
            // 
            // btn_view_quotes
            // 
            this.btn_view_quotes.AutoSize = true;
            this.btn_view_quotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_view_quotes.Location = new System.Drawing.Point(63, 113);
            this.btn_view_quotes.Name = "btn_view_quotes";
            this.btn_view_quotes.Size = new System.Drawing.Size(176, 36);
            this.btn_view_quotes.TabIndex = 1;
            this.btn_view_quotes.Text = "View quotes";
            this.btn_view_quotes.UseVisualStyleBackColor = true;
            this.btn_view_quotes.Click += new System.EventHandler(this.btn_view_quotes_Click);
            // 
            // btn_search_quotes
            // 
            this.btn_search_quotes.AutoSize = true;
            this.btn_search_quotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search_quotes.Location = new System.Drawing.Point(63, 186);
            this.btn_search_quotes.Name = "btn_search_quotes";
            this.btn_search_quotes.Size = new System.Drawing.Size(176, 36);
            this.btn_search_quotes.TabIndex = 2;
            this.btn_search_quotes.Text = "Search quotes";
            this.btn_search_quotes.UseVisualStyleBackColor = true;
            this.btn_search_quotes.Click += new System.EventHandler(this.btn_search_quotes_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.AutoSize = true;
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Location = new System.Drawing.Point(63, 248);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(176, 36);
            this.btn_exit.TabIndex = 3;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MegaDesk_Stratford.Properties.Resources.desk;
            this.pictureBox1.Location = new System.Drawing.Point(324, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(408, 239);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_search_quotes);
            this.Controls.Add(this.btn_view_quotes);
            this.Controls.Add(this.btn_add_new_quote);
            this.Name = "MainMenu";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_add_new_quote;
        private System.Windows.Forms.Button btn_view_quotes;
        private System.Windows.Forms.Button btn_search_quotes;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

