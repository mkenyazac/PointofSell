namespace PointOfSellSystem.forms
{
    partial class welcome
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
            this.termsbt = new System.Windows.Forms.Button();
            this.exitbt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.adminbt = new System.Windows.Forms.Button();
            this.userbt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // termsbt
            // 
            this.termsbt.Location = new System.Drawing.Point(623, 362);
            this.termsbt.Name = "termsbt";
            this.termsbt.Size = new System.Drawing.Size(110, 23);
            this.termsbt.TabIndex = 11;
            this.termsbt.Text = "Terms & Conditions";
            this.termsbt.UseVisualStyleBackColor = true;
            this.termsbt.Click += new System.EventHandler(this.termsbt_Click);
            // 
            // exitbt
            // 
            this.exitbt.Location = new System.Drawing.Point(739, 362);
            this.exitbt.Name = "exitbt";
            this.exitbt.Size = new System.Drawing.Size(75, 23);
            this.exitbt.TabIndex = 10;
            this.exitbt.Text = "Exit";
            this.exitbt.UseVisualStyleBackColor = true;
            this.exitbt.Click += new System.EventHandler(this.exitbt_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 387);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "I.S.T software House";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 362);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(411, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Copy right all rights reserved 2023 Isaac Stephen and Martin Karanja";
            // 
            // adminbt
            // 
            this.adminbt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminbt.Location = new System.Drawing.Point(416, 186);
            this.adminbt.Name = "adminbt";
            this.adminbt.Size = new System.Drawing.Size(193, 40);
            this.adminbt.TabIndex = 7;
            this.adminbt.Text = "Login as Admin";
            this.adminbt.UseVisualStyleBackColor = true;
            this.adminbt.Click += new System.EventHandler(this.adminbt_Click);
            // 
            // userbt
            // 
            this.userbt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userbt.Location = new System.Drawing.Point(416, 129);
            this.userbt.Name = "userbt";
            this.userbt.Size = new System.Drawing.Size(193, 40);
            this.userbt.TabIndex = 6;
            this.userbt.Text = "Login as User";
            this.userbt.UseVisualStyleBackColor = true;
            this.userbt.Click += new System.EventHandler(this.userbt_Click);
            // 
            // welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(828, 401);
            this.Controls.Add(this.termsbt);
            this.Controls.Add(this.exitbt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.adminbt);
            this.Controls.Add(this.userbt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "welcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "welcome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button termsbt;
        private System.Windows.Forms.Button exitbt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button adminbt;
        private System.Windows.Forms.Button userbt;
    }
}