using System.Windows.Forms;

namespace SortAlgorithms
{
    public class SortedItem
    {
        public ProgressBar ProgressBar {  get; private set; }
        public Label Label { get; private set; }
        public int Value { get; set; }

        public SortedItem(int value)
        {
            Value = value;
            ProgressBar = new ProgressBar();
            Label = new Label();

            // 
            // label3
            // 
            Label.AutoSize = true;
            Label.Location = new System.Drawing.Point(5, 4);
            Label.Name = "label3";
            Label.Size = new System.Drawing.Size(21, 16);
            Label.TabIndex = 0;
            Label.Text = Value.ToString();
            // 
            // progressBar1
            // 
            ProgressBar.Location = new System.Drawing.Point(32, 4);
            ProgressBar.Maximum = 100;
            ProgressBar.Minimum = 0;
            ProgressBar.Name = "progressBar1";
            ProgressBar.Size = new System.Drawing.Size(309, 23);
            ProgressBar.Step = 1;
            ProgressBar.TabIndex = 1;
            ProgressBar.Value = Value;
        }
    }
}
