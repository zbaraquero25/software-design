namespace Task5_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnSort_Click(object sender, EventArgs e)
        {
            int[] numbers = { 3, 1, 5, 2, 4 };
            int[] sortedNumbers = DescendingSorter.Sort(numbers);
            listBoxResults.DataSource = sortedNumbers;
        }
    }
}
