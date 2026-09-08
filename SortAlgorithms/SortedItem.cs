using System;
using System.Drawing;
using System.Windows.Forms;

namespace SortAlgorithms
{
    public class SortedItem 
    {
        public VerticalProgressBar.VerticalProgressBar ProgressBar { get; private set; }
        public Label Label { get; private set; }
        public int Value { get; private set; }

        public SortedItem(int value, int number)
        {
            Value = value;
            ProgressBar = new VerticalProgressBar.VerticalProgressBar();
            Label = new Label();

            // 
            // verticalProgressBar1
            // 
            ProgressBar.BorderStyle = VerticalProgressBar.BorderStyles.Classic;
            ProgressBar.Color = System.Drawing.Color.Blue;
            ProgressBar.Location = new System.Drawing.Point(8, 11);
            ProgressBar.Maximum = 100;
            ProgressBar.Minimum = 0;
            ProgressBar.Name = "verticalProgressBar1";
            ProgressBar.Size = new System.Drawing.Size(17, 113);
            ProgressBar.Step = 1;
            ProgressBar.Style = VerticalProgressBar.Styles.Classic;
            ProgressBar.TabIndex = 0;
            ProgressBar.Value = Value;
            // 
            // label3
            // 
            Label.AutoSize = true;
            Label.Location = new System.Drawing.Point(4, 127);
            Label.Name = "label3";
            Label.Size = new System.Drawing.Size(21, 16);
            Label.TabIndex = 1;
            Label.Text = Value.ToString();

        }
    }
}
