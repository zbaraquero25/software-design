namespace lab2
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
            lblResult = new Label();
            txtInput = new TextBox();
            txtArrayInput = new TextBox();
            lblSumResult = new Label();
            btnCalculateFactorial = new Button();
            btnCalculateSum = new Button();
            lblRecursiveFactorial = new Label();
            lblSumOfArrayElements = new Label();
            lblRecursiveFibonacciSequence = new Label();
            lblFibonacciResult = new Label();
            txtFibonacci = new TextBox();
            btnCalculateFibonacci = new Button();
            lblPowerResult = new Label();
            label1 = new Label();
            txtBase = new TextBox();
            txtExponent = new TextBox();
            txtPowerResult = new TextBox();
            lblBase = new Label();
            lblExponent = new Label();
            btnCalculatePower = new Button();
            SuspendLayout();
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(108, 33);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(55, 15);
            lblResult.TabIndex = 1;
            lblResult.Text = "Factorial:";
            // 
            // txtInput
            // 
            txtInput.Location = new Point(46, 51);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(170, 23);
            txtInput.TabIndex = 2;
            // 
            // txtArrayInput
            // 
            txtArrayInput.Location = new Point(292, 51);
            txtArrayInput.Name = "txtArrayInput";
            txtArrayInput.Size = new Size(170, 23);
            txtArrayInput.TabIndex = 4;
            // 
            // lblSumResult
            // 
            lblSumResult.AutoSize = true;
            lblSumResult.Location = new Point(360, 33);
            lblSumResult.Name = "lblSumResult";
            lblSumResult.Size = new Size(34, 15);
            lblSumResult.TabIndex = 5;
            lblSumResult.Text = "Sum:";
            // 
            // btnCalculateFactorial
            // 
            btnCalculateFactorial.Location = new Point(46, 80);
            btnCalculateFactorial.Name = "btnCalculateFactorial";
            btnCalculateFactorial.Size = new Size(170, 21);
            btnCalculateFactorial.TabIndex = 6;
            btnCalculateFactorial.Text = "Calculate Factorial";
            btnCalculateFactorial.UseVisualStyleBackColor = true;
            btnCalculateFactorial.Click += btn_CalculateFactorial_Click;
            // 
            // btnCalculateSum
            // 
            btnCalculateSum.Location = new Point(292, 80);
            btnCalculateSum.Name = "btnCalculateSum";
            btnCalculateSum.Size = new Size(170, 21);
            btnCalculateSum.TabIndex = 7;
            btnCalculateSum.Text = "Calculate Sum";
            btnCalculateSum.UseVisualStyleBackColor = true;
            btnCalculateSum.Click += btnCalculateSum_Click;
            // 
            // lblRecursiveFactorial
            // 
            lblRecursiveFactorial.AutoSize = true;
            lblRecursiveFactorial.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRecursiveFactorial.Location = new Point(55, 8);
            lblRecursiveFactorial.Name = "lblRecursiveFactorial";
            lblRecursiveFactorial.Size = new Size(153, 21);
            lblRecursiveFactorial.TabIndex = 8;
            lblRecursiveFactorial.Text = "Recursive Factorial";
            // 
            // lblSumOfArrayElements
            // 
            lblSumOfArrayElements.AutoSize = true;
            lblSumOfArrayElements.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSumOfArrayElements.Location = new Point(286, 8);
            lblSumOfArrayElements.Name = "lblSumOfArrayElements";
            lblSumOfArrayElements.Size = new Size(183, 21);
            lblSumOfArrayElements.TabIndex = 9;
            lblSumOfArrayElements.Text = "Sum of Array Elements";
            // 
            // lblRecursiveFibonacciSequence
            // 
            lblRecursiveFibonacciSequence.AutoSize = true;
            lblRecursiveFibonacciSequence.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRecursiveFibonacciSequence.Location = new Point(12, 136);
            lblRecursiveFibonacciSequence.Name = "lblRecursiveFibonacciSequence";
            lblRecursiveFibonacciSequence.Size = new Size(238, 21);
            lblRecursiveFibonacciSequence.TabIndex = 10;
            lblRecursiveFibonacciSequence.Text = "Recursive Fibonacci Sequence";
            // 
            // lblFibonacciResult
            // 
            lblFibonacciResult.AutoSize = true;
            lblFibonacciResult.Location = new Point(101, 161);
            lblFibonacciResult.Name = "lblFibonacciResult";
            lblFibonacciResult.Size = new Size(61, 15);
            lblFibonacciResult.TabIndex = 11;
            lblFibonacciResult.Text = "Fibonacci:";
            // 
            // txtFibonacci
            // 
            txtFibonacci.Location = new Point(46, 179);
            txtFibonacci.Name = "txtFibonacci";
            txtFibonacci.Size = new Size(170, 23);
            txtFibonacci.TabIndex = 12;
            // 
            // btnCalculateFibonacci
            // 
            btnCalculateFibonacci.Location = new Point(46, 208);
            btnCalculateFibonacci.Name = "btnCalculateFibonacci";
            btnCalculateFibonacci.Size = new Size(170, 23);
            btnCalculateFibonacci.TabIndex = 13;
            btnCalculateFibonacci.Text = "Calculate Fibonacci";
            btnCalculateFibonacci.UseVisualStyleBackColor = true;
            btnCalculateFibonacci.Click += btnCalculateFibonacci_Click;
            // 
            // lblPowerResult
            // 
            lblPowerResult.AutoSize = true;
            lblPowerResult.Location = new Point(356, 161);
            lblPowerResult.Name = "lblPowerResult";
            lblPowerResult.Size = new Size(43, 15);
            lblPowerResult.TabIndex = 14;
            lblPowerResult.Text = "Power:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(310, 140);
            label1.Name = "label1";
            label1.Size = new Size(135, 21);
            label1.TabIndex = 15;
            label1.Text = "Recursive Power";
            // 
            // txtBase
            // 
            txtBase.Location = new Point(357, 208);
            txtBase.Name = "txtBase";
            txtBase.Size = new Size(105, 23);
            txtBase.TabIndex = 16;
            // 
            // txtExponent
            // 
            txtExponent.Location = new Point(357, 234);
            txtExponent.Name = "txtExponent";
            txtExponent.Size = new Size(105, 23);
            txtExponent.TabIndex = 17;
            // 
            // txtPowerResult
            // 
            txtPowerResult.Enabled = false;
            txtPowerResult.Location = new Point(292, 179);
            txtPowerResult.Name = "txtPowerResult";
            txtPowerResult.Size = new Size(170, 23);
            txtPowerResult.TabIndex = 18;
            // 
            // lblBase
            // 
            lblBase.AutoSize = true;
            lblBase.Location = new Point(292, 211);
            lblBase.Name = "lblBase";
            lblBase.Size = new Size(34, 15);
            lblBase.TabIndex = 19;
            lblBase.Text = "Base:";
            // 
            // lblExponent
            // 
            lblExponent.AutoSize = true;
            lblExponent.Location = new Point(292, 237);
            lblExponent.Name = "lblExponent";
            lblExponent.Size = new Size(59, 15);
            lblExponent.TabIndex = 20;
            lblExponent.Text = "Exponent:";
            // 
            // btnCalculatePower
            // 
            btnCalculatePower.Location = new Point(292, 263);
            btnCalculatePower.Name = "btnCalculatePower";
            btnCalculatePower.Size = new Size(170, 23);
            btnCalculatePower.TabIndex = 21;
            btnCalculatePower.Text = "Calculate Power";
            btnCalculatePower.UseVisualStyleBackColor = true;
            btnCalculatePower.Click += btnCalculatePower_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(508, 310);
            Controls.Add(btnCalculatePower);
            Controls.Add(lblExponent);
            Controls.Add(lblBase);
            Controls.Add(txtPowerResult);
            Controls.Add(txtExponent);
            Controls.Add(txtBase);
            Controls.Add(label1);
            Controls.Add(lblPowerResult);
            Controls.Add(btnCalculateFibonacci);
            Controls.Add(txtFibonacci);
            Controls.Add(lblFibonacciResult);
            Controls.Add(lblRecursiveFibonacciSequence);
            Controls.Add(lblSumOfArrayElements);
            Controls.Add(lblRecursiveFactorial);
            Controls.Add(btnCalculateSum);
            Controls.Add(btnCalculateFactorial);
            Controls.Add(lblSumResult);
            Controls.Add(txtArrayInput);
            Controls.Add(txtInput);
            Controls.Add(lblResult);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblResult;
        private TextBox txtInput;
        private TextBox txtArrayInput;
        private Label lblSumResult;
        private Button btnCalculateFactorial;
        private Button btnCalculateSum;
        private Label lblRecursiveFactorial;
        private Label lblSumOfArrayElements;
        private Label lblRecursiveFibonacciSequence;
        private Label lblFibonacciResult;
        private TextBox txtFibonacci;
        private Button btnCalculateFibonacci;
        private Label lblPowerResult;
        private Label label1;
        private TextBox txtBase;
        private TextBox txtExponent;
        private TextBox txtPowerResult;
        private Label lblBase;
        private Label lblExponent;
        private Button btnCalculatePower;
    }
}
