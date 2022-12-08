
namespace Memory_Card_Game_NGM
{
    partial class homePage
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
            this.hardBtn = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.harderBtn = new System.Windows.Forms.Button();
            this.hardestBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hardBtn
            // 
            this.hardBtn.Font = new System.Drawing.Font("MV Boli", 16.27826F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hardBtn.Location = new System.Drawing.Point(279, 278);
            this.hardBtn.Name = "hardBtn";
            this.hardBtn.Size = new System.Drawing.Size(165, 69);
            this.hardBtn.TabIndex = 0;
            this.hardBtn.Text = "Hard";
            this.hardBtn.UseVisualStyleBackColor = true;
            this.hardBtn.Click += new System.EventHandler(this.hardBtn_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("MV Boli", 36.31305F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(150, 120);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(429, 77);
            this.title.TabIndex = 3;
            this.title.Text = "Memory Cards";
            // 
            // harderBtn
            // 
            this.harderBtn.Font = new System.Drawing.Font("MV Boli", 16.27826F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.harderBtn.Location = new System.Drawing.Point(279, 375);
            this.harderBtn.Name = "harderBtn";
            this.harderBtn.Size = new System.Drawing.Size(165, 69);
            this.harderBtn.TabIndex = 4;
            this.harderBtn.Text = "Harder";
            this.harderBtn.UseVisualStyleBackColor = true;
            this.harderBtn.Click += new System.EventHandler(this.harderBtn_Click);
            // 
            // hardestBtn
            // 
            this.hardestBtn.Font = new System.Drawing.Font("MV Boli", 16.27826F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hardestBtn.Location = new System.Drawing.Point(279, 489);
            this.hardestBtn.Name = "hardestBtn";
            this.hardestBtn.Size = new System.Drawing.Size(165, 69);
            this.hardestBtn.TabIndex = 5;
            this.hardestBtn.Text = "Hardest";
            this.hardestBtn.UseVisualStyleBackColor = true;
            this.hardestBtn.Click += new System.EventHandler(this.hardestBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(274, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "(Advanced Edition)";
            // 
            // homePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 705);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hardestBtn);
            this.Controls.Add(this.harderBtn);
            this.Controls.Add(this.title);
            this.Controls.Add(this.hardBtn);
            this.Name = "homePage";
            this.Text = "homePage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button hardBtn;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button harderBtn;
        private System.Windows.Forms.Button hardestBtn;
        private System.Windows.Forms.Label label1;
    }
}