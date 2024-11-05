namespace A2_Graphs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnAdd = new Button();
            txtName = new TextBox();
            txtValue = new TextBox();
            label1 = new Label();
            label2 = new Label();
            panelChart = new Panel();
            btnClear = new Button();
            label3 = new Label();
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(31, 209);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(89, 34);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(31, 71);
            txtName.Name = "txtName";
            txtName.Size = new Size(238, 31);
            txtName.TabIndex = 1;
            // 
            // txtValue
            // 
            txtValue.Location = new Point(31, 149);
            txtValue.Name = "txtValue";
            txtValue.Size = new Size(238, 31);
            txtValue.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 43);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 3;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 121);
            label2.Name = "label2";
            label2.Size = new Size(54, 25);
            label2.TabIndex = 4;
            label2.Text = "Value";
            // 
            // panelChart
            // 
            panelChart.AutoScroll = true;
            panelChart.BackColor = SystemColors.ControlLightLight;
            panelChart.Location = new Point(338, 99);
            panelChart.Name = "panelChart";
            panelChart.Size = new Size(764, 324);
            panelChart.TabIndex = 5;
            panelChart.Paint += panelChart_Paint;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(126, 209);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(143, 34);
            btnClear.TabIndex = 6;
            btnClear.Text = "Clear All Data";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // label3
            // 
            label3.BackColor = SystemColors.ControlLight;
            label3.Dock = DockStyle.Top;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(1127, 65);
            label3.TabIndex = 7;
            label3.Text = "             Bar Chart - Input your data";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtValue);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(btnClear);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(22, 86);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(300, 337);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add data";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ControlLight;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(22, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1127, 451);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(panelChart);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "BarChart - 457647 Yosita Jasamut";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnAdd;
        private TextBox txtName;
        private TextBox txtValue;
        private Label label1;
        private Label label2;
        private Panel panelChart;
        private Button btnClear;
        private Label label3;
        private GroupBox groupBox1;
        private PictureBox pictureBox1;
    }
}
