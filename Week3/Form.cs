namespace Week3
{
    public partial class Form : System.Windows.Forms.Form
    {
        private ArrayOfNumbers array;

        public Form()
        {
            InitializeComponent();
        }

        private void cb_index_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = cb_index.SelectedIndex;
            txt_selectedValue.Text = array.Numbers[i].ToString();
        }

        // Create array of length
        private void btn_arrayLength_Click(object sender, EventArgs e)
        {
            array = new ArrayOfNumbers(int.Parse(txt_length.Text));
            updateLabels();
        }

        // Create array with values
        private void btn_arrayValues_Click(object sender, EventArgs e)
        {
            string[] input = txt_values.Text.Split(",");
            int[] arrayValues = new int[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                arrayValues[i] = int.Parse(input[i]);
            }

            array = new ArrayOfNumbers(arrayValues);
            updateLabels();
        }

        // Reset the UI when creating new object, update combobox elements
        private void updateLabels()
        {
            txt_length.Text = string.Empty;
            txt_values.Text = string.Empty;
            cb_index.Items.Clear();
            cb_1stIndex.Items.Clear();
            cb_2ndIndex.Items.Clear();

            for (int i = 0; i <= array.Numbers.Length; i++)
            {
                cb_index.Items.Add(i.ToString());
            }

            foreach (int number in array.Numbers)
            {
                cb_1stIndex.Items.Add(number);
                cb_2ndIndex.Items.Add(number);
            }
        }

        private void btn_newValue_Click(object sender, EventArgs e)
        {
            array.SetValue(cb_index.SelectedIndex, int.Parse(txt_newValue.Text));
            updateLabels();
        }

        private void btn_gcd_Click(object sender, EventArgs e)
        {
            int x = cb_1stIndex.SelectedIndex;
            int y = cb_2ndIndex.SelectedIndex;
            lbl_output.Text = array.GCD(x, y).ToString();
        }

        private void btn_equal_Click(object sender, EventArgs e)
        {
            int x = cb_1stIndex.SelectedIndex;
            int y = cb_2ndIndex.SelectedIndex;

            if (array.IsEqual(x, y))
            {
                lbl_output.Text = "Numbers are equal";
            }
            else
            {
                lbl_output.Text = "Numbers are not equal";
            }
        }

        private void btn_max_Click(object sender, EventArgs e)
        {
            lbl_output.Text = $"Max array value: {array.GetMax()}";
        }

        private void btn_count_Click(object sender, EventArgs e)
        {
            lbl_output.Text = $"Number of array elements: {array.GetCount()}";
        }

        private void btn_sum_Click(object sender, EventArgs e)
        {
            lbl_output.Text = $"Sum of array elements values: {array.GetSum()}";
        }

        private void btn_average_Click(object sender, EventArgs e)
        {
            lbl_output.Text = $"Average of array elements values {array.GetAverage()}";
        }

        private void btn_toString_Click(object sender, EventArgs e)
        {
            lbl_output.Text = $"""
                Array values:
                {array.ToString()}
                """;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            lbl_output.Text = "Old values:";
            lbl_output.Text += "\r\n" + array.ToString() + "\r\n";

            array.Add(int.Parse(txt_mutator.Text));

            lbl_output.Text += "\r\nNew multiplied values:";
            lbl_output.Text += "\r\n" + array.ToString();
        }

        private void btn_multiply_Click(object sender, EventArgs e)
        {
            lbl_output.Text = "Old values:";
            lbl_output.Text += "\r\n" + array.ToString() + "\r\n";

            array.Multiply(int.Parse(txt_mutator.Text));

            lbl_output.Text += "\r\nNew multiplied values:";
            lbl_output.Text += "\r\n" + array.ToString();
        }
    }
}
