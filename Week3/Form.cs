namespace Week3
{
    public partial class Form : System.Windows.Forms.Form
    {
        ArrayOfNumbers array;

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
            array = new ArrayOfNumbers(int.Parse(txt_length.Text) - 1);
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

        // Clear and update the combobox
        private void updateLabels()
        {
            cb_index.Items.Clear();

            for (int i = 0; i <= array.Numbers.Length; i++)
            {
                cb_index.Items.Add(i.ToString());
            }
        }

        private void btn_newValue_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
