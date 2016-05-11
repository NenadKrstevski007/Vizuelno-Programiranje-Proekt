namespace Game2048
{
    partial class About
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblHowToPlay = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblExplanation = new System.Windows.Forms.Label();
            this.lblMadeBy = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Aardvark", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lblTitle.Location = new System.Drawing.Point(13, 28);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.lblTitle.Size = new System.Drawing.Size(148, 38);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "label1";
            // 
            // lblHowToPlay
            // 
            this.lblHowToPlay.AutoSize = true;
            this.lblHowToPlay.Font = new System.Drawing.Font("Aardvark", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHowToPlay.ForeColor = System.Drawing.Color.Gray;
            this.lblHowToPlay.Location = new System.Drawing.Point(16, 100);
            this.lblHowToPlay.Name = "lblHowToPlay";
            this.lblHowToPlay.Size = new System.Drawing.Size(74, 27);
            this.lblHowToPlay.TabIndex = 1;
            this.lblHowToPlay.Text = "label2";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.lblName.ForeColor = System.Drawing.Color.DimGray;
            this.lblName.Location = new System.Drawing.Point(18, 228);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(46, 20);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "label3";
            // 
            // lblExplanation
            // 
            this.lblExplanation.AutoSize = true;
            this.lblExplanation.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.lblExplanation.ForeColor = System.Drawing.Color.DimGray;
            this.lblExplanation.Location = new System.Drawing.Point(17, 127);
            this.lblExplanation.Name = "lblExplanation";
            this.lblExplanation.Size = new System.Drawing.Size(46, 20);
            this.lblExplanation.TabIndex = 3;
            this.lblExplanation.Text = "label1";
            // 
            // lblMadeBy
            // 
            this.lblMadeBy.AutoSize = true;
            this.lblMadeBy.Font = new System.Drawing.Font("Aardvark", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMadeBy.ForeColor = System.Drawing.Color.Gray;
            this.lblMadeBy.Location = new System.Drawing.Point(16, 201);
            this.lblMadeBy.Name = "lblMadeBy";
            this.lblMadeBy.Size = new System.Drawing.Size(69, 27);
            this.lblMadeBy.TabIndex = 4;
            this.lblMadeBy.Text = "label1";
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(299, 294);
            this.Controls.Add(this.lblMadeBy);
            this.Controls.Add(this.lblExplanation);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblHowToPlay);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "About";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblHowToPlay;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblExplanation;
        private System.Windows.Forms.Label lblMadeBy;
    }
}