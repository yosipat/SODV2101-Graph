using System.Diagnostics.Metrics;

namespace A2_Graphs
{
    public partial class Form1 : Form
    {
        public class Data()
        {
            public string Name { get; set; }
            public int Value { get; set; }
        }

        List<Data> data = new List<Data>();
        List<int> values = new List<int>();
        public Form1()
        {
            InitializeComponent();

            // Initial data
            data.Add(new Data
            {
                Name = "A",
                Value = 1
            });
            data.Add(new Data
            {
                Name = "B",
                Value = 2
            });
            data.Add(new Data
            {
                Name = "C",
                Value = 3
            });
            data.Add(new Data
            {
                Name = "D",
                Value = -4
            });
            data.Add(new Data
            {
                Name = "E",
                Value = -5
            });
            data.Add(new Data
            {
                Name = "F",
                Value = -6
            });
            data.Add(new Data
            {
                Name = "G",
                Value = 7
            });
            data.Add(new Data
            {
                Name = "H",
                Value = 8
            });
            data.Add(new Data
            {
                Name = "I",
                Value = 9
            });
            data.Add(new Data
            {
                Name = "J",
                Value = -10
            });
        }

        private void panelChart_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen blackPen = new Pen(Color.Black, 1);

            int barWidth = 40;
            int spacing = 10; // space between bar
            int originX = 20; // Starting x position
            int originY = panelChart.Height / 2; // Starting y position

            // draw x-axis
            g.DrawLine(blackPen, originX, originY, panelChart.Width - originX, originY);
            g.DrawString("x", this.Font, Brushes.Black, panelChart.Width - originX , originY - 15);
            // draw y-axis
            g.DrawLine(blackPen, originX, originY - panelChart.Height / 2 + 30, originX, originY + panelChart.Height / 2 - 30);
            g.DrawString("y", this.Font, Brushes.Black, originX - 5, originY - panelChart.Height / 2);
            g.DrawString("-y", this.Font, Brushes.Black, originX - 5, originY + panelChart.Height / 2 - 30);


            if (data == null || data.Count == 0) // check Is data null?
                return;

            values.Clear();
            foreach (Data data in data)
            {
                values.Add(data.Value);
            }

            int max = values.Max();
            int min = values.Min();

            int index = 0;
            foreach (Data data in data)
            {
                string name = data.Name;
                int value = data.Value;

                // Calculate the height and position
                int height = (int)((value * 100) / (Math.Abs(max) > Math.Abs(min) ? Math.Abs(max) : Math.Abs(min)));
                int x = originX + index * (barWidth + spacing);
                int y = height > 0 ? originY - height : originY;

                // Draw the bar
                Color color = Color.FromArgb((index * 0) % 255, (index * 50) % 255, (index * 100) % 255);
                g.FillRectangle(new SolidBrush(color), x, y, barWidth, Math.Abs(height));

                SizeF sizeValue = g.MeasureString(value.ToString(), this.Font);
                SizeF sizeName = g.MeasureString(name, this.Font);
                
                // label the bar
                g.DrawString(name, this.Font, Brushes.Blue, x + (barWidth - sizeName.Width) / 2, height > 0 ? y + height : y - 30);
                g.DrawString(value.ToString(), this.Font, Brushes.Red, x + (barWidth - sizeValue.Width) / 2, height > 0 ? y - 30 : y + Math.Abs(height));

                index++;

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (data.Count < 14)
                {
                    // add new data from input box
                    data.Add(new Data
                    {
                        Name = txtName.Text,
                        Value = Int32.Parse(txtValue.Text)
                    });
                }
                else
                {
                    MessageBox.Show("Display is maximum 14 bars. Please clear data.");
                }

                panelChart.Invalidate(); // Trigger the paint event
            }
            catch
            {
                MessageBox.Show("Please enter valid numbers.");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            data.Clear();
            panelChart.Invalidate(); // Trigger the paint event
        }
    }
}
