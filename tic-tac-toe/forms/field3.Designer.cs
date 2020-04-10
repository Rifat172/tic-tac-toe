namespace tic_tac_toe.forms
{
    partial class Field3
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
            this.restart = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // restart
            // 
            this.restart.Font = new System.Drawing.Font("Arial", 15F);
            this.restart.Location = new System.Drawing.Point(15, 410);
            this.restart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.restart.Name = "restart";
            this.restart.Size = new System.Drawing.Size(199, 64);
            this.restart.TabIndex = 9;
            this.restart.Text = "ЗАНОВО";
            this.restart.UseVisualStyleBackColor = true;
            this.restart.Click += new System.EventHandler(this.restart_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 15F);
            this.button1.Location = new System.Drawing.Point(219, 410);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 64);
            this.button1.TabIndex = 10;
            this.button1.Text = "В МЕНЮ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.backToMenu_Click);
            // 
            // Field3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 487);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.restart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Field3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "3X3";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Field3_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button restart;
        private System.Windows.Forms.Button button1;
    }
}