using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SortAlgorithms
{
    public partial class Form1 : Form
    {
        List<SortedItem> items = new List<SortedItem>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(AddTextBox.Text, out int value))
            {
                var item = new SortedItem(value);
                items.Add(item);
                panel3.Controls.Add(item.ProgressBar);
                panel3.Controls.Add(item.Label);
            }

            AddTextBox.Text = "";
        }

        private void FillButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(FillTextBox.Text, out int value))
            {
                var rnd = new Random();

                for (int i = 0; i < value; i++)
                {
                    var item = new SortedItem(rnd.Next());
                    items.Add(item);
                    panel3.Controls.Add(item.ProgressBar);
                    panel3.Controls.Add(item.Label);
                }
            }

            FillTextBox.Text = "";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
