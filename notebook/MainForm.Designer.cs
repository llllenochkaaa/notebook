namespace notebook
{
    partial class MainForm
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
            this.MyFriendsButton = new System.Windows.Forms.Button();
            this.FindFriendButton = new System.Windows.Forms.Button();
            this.AddFriendButton = new System.Windows.Forms.Button();
            this.CurrentData = new System.Windows.Forms.TextBox();
            this.BackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MyFriendsButton
            // 
            this.MyFriendsButton.BackColor = System.Drawing.Color.Violet;
            this.MyFriendsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MyFriendsButton.ForeColor = System.Drawing.Color.Maroon;
            this.MyFriendsButton.Location = new System.Drawing.Point(273, 49);
            this.MyFriendsButton.Name = "MyFriendsButton";
            this.MyFriendsButton.Size = new System.Drawing.Size(254, 84);
            this.MyFriendsButton.TabIndex = 0;
            this.MyFriendsButton.Text = "Мої друзі";
            this.MyFriendsButton.UseVisualStyleBackColor = false;
            // 
            // FindFriendButton
            // 
            this.FindFriendButton.BackColor = System.Drawing.Color.Violet;
            this.FindFriendButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FindFriendButton.ForeColor = System.Drawing.Color.Maroon;
            this.FindFriendButton.Location = new System.Drawing.Point(273, 184);
            this.FindFriendButton.Name = "FindFriendButton";
            this.FindFriendButton.Size = new System.Drawing.Size(254, 84);
            this.FindFriendButton.TabIndex = 1;
            this.FindFriendButton.Text = "Знайти друга";
            this.FindFriendButton.UseVisualStyleBackColor = false;
            // 
            // AddFriendButton
            // 
            this.AddFriendButton.BackColor = System.Drawing.Color.Violet;
            this.AddFriendButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddFriendButton.ForeColor = System.Drawing.Color.Maroon;
            this.AddFriendButton.Location = new System.Drawing.Point(273, 316);
            this.AddFriendButton.Name = "AddFriendButton";
            this.AddFriendButton.Size = new System.Drawing.Size(254, 84);
            this.AddFriendButton.TabIndex = 2;
            this.AddFriendButton.Text = "Додати друга";
            this.AddFriendButton.UseVisualStyleBackColor = false;
            // 
            // CurrentData
            // 
            this.CurrentData.BackColor = System.Drawing.Color.LightPink;
            this.CurrentData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CurrentData.ForeColor = System.Drawing.Color.Black;
            this.CurrentData.Location = new System.Drawing.Point(681, 411);
            this.CurrentData.Name = "CurrentData";
            this.CurrentData.Size = new System.Drawing.Size(107, 27);
            this.CurrentData.TabIndex = 3;
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.LightPink;
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackButton.ForeColor = System.Drawing.Color.Purple;
            this.BackButton.Location = new System.Drawing.Point(12, 12);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(159, 37);
            this.BackButton.TabIndex = 4;
            this.BackButton.Text = "Повернутися";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.HotPink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.CurrentData);
            this.Controls.Add(this.AddFriendButton);
            this.Controls.Add(this.FindFriendButton);
            this.Controls.Add(this.MyFriendsButton);
            this.Name = "MainForm";
            this.Text = "Notebook";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MyFriendsButton;
        private System.Windows.Forms.Button FindFriendButton;
        private System.Windows.Forms.Button AddFriendButton;
        private System.Windows.Forms.TextBox CurrentData;
        private System.Windows.Forms.Button BackButton;
    }
}