namespace lab3
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
            btnShowInfo = new Button();
            txtInfo = new ListBox();
            SuspendLayout();
            // 
            // btnShowInfo
            // 
            btnShowInfo.Location = new Point(12, 12);
            btnShowInfo.Name = "btnShowInfo";
            btnShowInfo.Size = new Size(145, 43);
            btnShowInfo.TabIndex = 0;
            btnShowInfo.Text = "Show Information";
            btnShowInfo.UseVisualStyleBackColor = true;
            btnShowInfo.Click += btnShowInfo_Click;
            // 
            // txtInfo
            // 
            txtInfo.FormattingEnabled = true;
            txtInfo.ItemHeight = 15;
            txtInfo.Location = new Point(163, 12);
            txtInfo.Name = "txtInfo";
            txtInfo.Size = new Size(459, 259);
            txtInfo.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(634, 287);
            Controls.Add(txtInfo);
            Controls.Add(btnShowInfo);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnShowInfo;
        private ListBox txtInfo;
    }
}
