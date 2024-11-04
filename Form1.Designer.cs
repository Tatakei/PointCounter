namespace PointCounter
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            GivePoints = new Button();
            DeductPoints = new Button();
            lblPoints = new Label();
            SuspendLayout();
            // 
            // GivePoints
            // 
            GivePoints.Location = new Point(141, 259);
            GivePoints.Name = "GivePoints";
            GivePoints.Size = new Size(86, 23);
            GivePoints.TabIndex = 0;
            GivePoints.Text = "GivePoints";
            GivePoints.UseVisualStyleBackColor = true;
            GivePoints.Click += GivePoints_Click;
            // 
            // DeductPoints
            // 
            DeductPoints.Location = new Point(532, 259);
            DeductPoints.Name = "DeductPoints";
            DeductPoints.Size = new Size(98, 23);
            DeductPoints.TabIndex = 1;
            DeductPoints.Text = "DeductPoints";
            DeductPoints.UseVisualStyleBackColor = true;
            DeductPoints.Click += DeductPoints_Click;
            // 
            // lblPoints
            // 
            lblPoints.AutoSize = true;
            lblPoints.Location = new Point(324, 263);
            lblPoints.Name = "lblPoints";
            lblPoints.Size = new Size(0, 15);
            lblPoints.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblPoints);
            Controls.Add(DeductPoints);
            Controls.Add(GivePoints);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button GivePoints;
        private Button DeductPoints;
        private Label lblPoints;
    }
}
