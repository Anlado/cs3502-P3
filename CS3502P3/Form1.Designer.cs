namespace CS3502P3
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            panel1 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            textBox4 = new TextBox();
            button12 = new Button();
            textBox2 = new TextBox();
            button11 = new Button();
            panel2 = new Panel();
            button9 = new Button();
            label1 = new Label();
            button8 = new Button();
            textBox3 = new TextBox();
            textBox1 = new TextBox();
            listView1 = new ListView();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            button7 = new Button();
            imageList1 = new ImageList(components);
            button10 = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F);
            button1.Location = new Point(100, 573);
            button1.Name = "button1";
            button1.Size = new Size(162, 52);
            button1.TabIndex = 0;
            button1.Text = "CREATE";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F);
            button2.Location = new Point(280, 573);
            button2.Name = "button2";
            button2.Size = new Size(162, 52);
            button2.TabIndex = 1;
            button2.Text = "RENAME";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 12F);
            button3.Location = new Point(460, 573);
            button3.Name = "button3";
            button3.Size = new Size(162, 52);
            button3.TabIndex = 2;
            button3.Text = "DELETE";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 12F);
            button4.Location = new Point(640, 573);
            button4.Name = "button4";
            button4.Size = new Size(162, 52);
            button4.TabIndex = 3;
            button4.Text = "READ";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 12F);
            button5.Location = new Point(820, 573);
            button5.Name = "button5";
            button5.Size = new Size(162, 52);
            button5.TabIndex = 4;
            button5.Text = "UPDATE";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 12F);
            button6.Location = new Point(1166, 12);
            button6.Name = "button6";
            button6.Size = new Size(84, 37);
            button6.TabIndex = 5;
            button6.Text = "QUIT";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(listView1);
            panel1.ForeColor = SystemColors.ButtonHighlight;
            panel1.Location = new Point(110, 30);
            panel1.Name = "panel1";
            panel1.Size = new Size(1042, 492);
            panel1.TabIndex = 6;
            panel1.Paint += panel1_Paint_1;
            // 
            // panel3
            // 
            panel3.Controls.Add(textBox2);
            panel3.Controls.Add(button11);
            panel3.Location = new Point(1, 1);
            panel3.Name = "panel3";
            panel3.Size = new Size(1041, 491);
            panel3.TabIndex = 3;
            panel3.Visible = false;
            // 
            // panel4
            // 
            panel4.Controls.Add(textBox4);
            panel4.Controls.Add(button12);
            panel4.Location = new Point(0, 1);
            panel4.Name = "panel4";
            panel4.Size = new Size(1041, 491);
            panel4.TabIndex = 10;
            panel4.Visible = false;
            // 
            // textBox4
            // 
            textBox4.BackColor = SystemColors.Menu;
            textBox4.Location = new Point(30, 90);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.ScrollBars = ScrollBars.Vertical;
            textBox4.Size = new Size(981, 380);
            textBox4.TabIndex = 9;
            // 
            // button12
            // 
            button12.Font = new Font("Segoe UI", 10F);
            button12.ForeColor = SystemColors.Desktop;
            button12.Location = new Point(30, 20);
            button12.Name = "button12";
            button12.Size = new Size(98, 56);
            button12.TabIndex = 8;
            button12.Text = "Save and Exit";
            button12.UseVisualStyleBackColor = true;
            button12.Click += button12_Click;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.Menu;
            textBox2.Location = new Point(30, 90);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.ScrollBars = ScrollBars.Vertical;
            textBox2.Size = new Size(981, 380);
            textBox2.TabIndex = 9;
            // 
            // button11
            // 
            button11.Font = new Font("Segoe UI", 15F);
            button11.ForeColor = SystemColors.Desktop;
            button11.Location = new Point(30, 20);
            button11.Name = "button11";
            button11.Size = new Size(98, 56);
            button11.TabIndex = 8;
            button11.Text = "Exit";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(button9);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(button8);
            panel2.Controls.Add(textBox3);
            panel2.Location = new Point(219, 174);
            panel2.Name = "panel2";
            panel2.Size = new Size(604, 188);
            panel2.TabIndex = 2;
            panel2.Visible = false;
            // 
            // button9
            // 
            button9.ForeColor = SystemColors.Desktop;
            button9.Location = new Point(12, 10);
            button9.Name = "button9";
            button9.Size = new Size(94, 29);
            button9.TabIndex = 4;
            button9.Text = "Cancel";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.ForeColor = SystemColors.Desktop;
            label1.Location = new Point(171, 10);
            label1.Name = "label1";
            label1.Size = new Size(263, 35);
            label1.TabIndex = 3;
            label1.Text = "Please input file name:";
            // 
            // button8
            // 
            button8.ForeColor = SystemColors.Desktop;
            button8.Location = new Point(233, 134);
            button8.Name = "button8";
            button8.Size = new Size(139, 29);
            button8.TabIndex = 2;
            button8.Text = "Confirm";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.MenuBar;
            textBox3.Font = new Font("Segoe UI", 15F);
            textBox3.Location = new Point(147, 67);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(311, 41);
            textBox3.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.Location = new Point(38, 34);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(966, 34);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged_1;
            textBox1.KeyDown += textBox1_KeyDown;
            textBox1.Leave += textBox1_Leave_1;
            // 
            // listView1
            // 
            listView1.BackColor = SystemColors.MenuBar;
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            listView1.Location = new Point(23, 74);
            listView1.Name = "listView1";
            listView1.Size = new Size(997, 397);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "File Name";
            columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "File Type";
            columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Date Modified";
            columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Size";
            columnHeader5.Width = 120;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 15F);
            button7.ForeColor = SystemColors.Desktop;
            button7.Location = new Point(6, 51);
            button7.Name = "button7";
            button7.Size = new Size(98, 56);
            button7.TabIndex = 3;
            button7.Text = "Back";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click_1;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "free-folder-icon-1484-thumb.png");
            imageList1.Images.SetKeyName(1, "file-60 (1).png");
            // 
            // button10
            // 
            button10.Font = new Font("Segoe UI", 12F);
            button10.Location = new Point(1000, 573);
            button10.Name = "button10";
            button10.Size = new Size(162, 52);
            button10.TabIndex = 7;
            button10.Text = "DOWNLOAD";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1262, 673);
            Controls.Add(button10);
            Controls.Add(button7);
            Controls.Add(panel1);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Panel panel1;
        private ListView listView1;
        private TextBox textBox1;
        private Panel panel2;
        private TextBox textBox3;
        private Button button8;
        private Label label1;
        private Button button9;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private Button button7;
        private ImageList imageList1;
        private Button button10;
        private Panel panel3;
        private Button button11;
        private TextBox textBox2;
        private ContextMenuStrip contextMenuStrip1;
        private Panel panel4;
        private TextBox textBox4;
        private Button button12;
    }
}
