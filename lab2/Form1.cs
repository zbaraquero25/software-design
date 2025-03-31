namespace lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Recursive factorial
        public int RecursiveFactorial(int n)
        {
            if (n == 0) return 1;
            return n * RecursiveFactorial(n - 1);
        }
        private void btn_CalculateFactorial_Click(object sender, EventArgs e)
        {
            int number = int.Parse(txtInput.Text);
            int result = RecursiveFactorial(number);
            lblResult.Text = $"Factorial: {result}";
        }
        // Recursive sum
        public int RecursiveSum(int[] numbers, int n)
        {
            if (n == 0) return numbers[0];
            return numbers[n] + RecursiveSum(numbers, n - 1);
        }

        private void btnCalculateSum_Click(object sender, EventArgs e)
        {
            int[] numbers = txtArrayInput.Text.Split(',').Select(int.Parse).ToArray();
            int result = RecursiveSum(numbers, numbers.Length - 1);
            lblSumResult.Text = $"Sum: {result}";
        }
        // Recursive fibonacci sequence
        public int RecursiveFibonacci(int n)
        {
            //if (n == 0) return 1;
            return 0;
        }
        private void btnCalculateFibonacci_Click(object sender, EventArgs e)
        {
            int number = int.Parse(txtFibonacci.Text);
            int result = RecursiveFibonacci(number);
            lblFibonacciResult.Text = $"Fibonacci: {result}";
        }
        // Recursive power
        public int RecursivePower(int baseNum, int exponent)
        {
            //if (n == 0) return 1;
            return baseNum * RecursivePower(baseNum, exponent);
        }
        private void btnCalculatePower_Click(object sender, EventArgs e)
        {
            int baseNum = int.Parse(txtBase.Text);
            int exponent = int.Parse(txtExponent.Text);
            int result = RecursivePower(baseNum, exponent);
            lblPowerResult.Text = $"Power: {result}";
        }
    }
}