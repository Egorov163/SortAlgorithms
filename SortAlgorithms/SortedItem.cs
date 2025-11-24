using System;
using System.Drawing;
using System.Windows.Forms;

namespace SortAlgorithms
{
    public class SortedItem : IComparable
    {
        public ProgressBar ProgressBar { get; private set; }
        public Label Label { get; private set; }
        public int Value { get; private set; }

        public SortedItem(int value, int number)
        {
            Value = value;
            ProgressBar = new ProgressBar();
            Label = new Label();

            var y = number * 30;

            // 
            // label3
            // 
            Label.AutoSize = true;
            Label.Location = new System.Drawing.Point(5, y);
            Label.Name = "label" + number;
            Label.Size = new System.Drawing.Size(21, 16);
            Label.TabIndex = number;
            Label.Text = Value.ToString();
            // 
            // progressBar1
            // 
            ProgressBar.Location = new System.Drawing.Point(32, y);
            ProgressBar.Maximum = 100;
            ProgressBar.Minimum = 0;
            ProgressBar.Name = "progressBar" + number;
            ProgressBar.Size = new System.Drawing.Size(309, 23);
            ProgressBar.Step = 1;
            ProgressBar.TabIndex = number;
            ProgressBar.Value = Value;
        }

        public void SetValue(int value)
        {
            Value = value;
            ProgressBar.Value = Value;
            Label.Text = Value.ToString();
        }

        public void SetColor(Color color)
        {
            ProgressBar.ForeColor = color;
        }

        public int CompareTo(object obj)
        {
            if (obj is SortedItem item)
            {
                return Value.CompareTo(item.Value);
            }
            else
            {
                throw new ArgumentException($"obj is not {nameof(SortedItem)}", nameof(obj));
            }
        }
    }
}
