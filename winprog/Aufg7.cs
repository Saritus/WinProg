using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.Drawing;
using System;

public class Aufg7: Form
{
    private Label label1;
    private ComboBox comboBox1;
    private Label label2;
    private NumericUpDown numericUpDown1;
    private GroupBox groupBox1;
    private TextBox textBox1;
    private RadioButton radioButton5;
    private RadioButton radioButton4;
    private RadioButton radioButton3;
    private RadioButton radioButton2;
    private RadioButton radioButton1;
    private Button button1;
    private Button button2;
    private Label label3;
    private Label label4;
    private Panel panel1;
    private int selected;
    private Point start;
    private Graphics g;
    private Button btnopen;
    private Button btnsave;
    private Brush brush;
    private Bitmap buffer;

    public Aufg7()
    {
        Text = "Aufgabe 7";
        Size = new Size(500, 500);
        CenterToScreen();
        InitializeComponent();
        g = panel1.CreateGraphics();
        selected = 1;
    }

    private void InitializeComponent()
    {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnopen = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(517, 513);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mousedown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Mousemove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Mouseup);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(535, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Stift:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "HatchBrush",
            "LinearGradientBrush",
            "PathGradientBrush",
            "SolidBrush",
            "TextureBrush"});
            this.comboBox1.Location = new System.Drawing.Point(538, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(150, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(535, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lienenstärke:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(639, 67);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(49, 20);
            this.numericUpDown1.TabIndex = 4;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.radioButton5);
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(538, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(150, 211);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Auswahl";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(6, 176);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(138, 20);
            this.textBox1.TabIndex = 5;
            // 
            // radioButton5
            // 
            this.radioButton5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.radioButton5.Location = new System.Drawing.Point(6, 145);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(138, 25);
            this.radioButton5.TabIndex = 4;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Text";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.radioButton4.Location = new System.Drawing.Point(6, 114);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(138, 25);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Rechteck";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.radioButton3.Location = new System.Drawing.Point(6, 83);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(138, 25);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Ellipse";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.radioButton2.Location = new System.Drawing.Point(6, 52);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(138, 25);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Linie";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 21);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(138, 25);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Freihand";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(538, 355);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 24);
            this.button1.TabIndex = 6;
            this.button1.Text = "Font auswählen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(538, 398);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 24);
            this.button2.TabIndex = 7;
            this.button2.Text = "Farbe auswählen";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(541, 382);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "ELLIS";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(541, 425);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 20);
            this.label4.TabIndex = 9;
            // 
            // btnopen
            // 
            this.btnopen.Location = new System.Drawing.Point(535, 502);
            this.btnopen.Name = "btnopen";
            this.btnopen.Size = new System.Drawing.Size(153, 23);
            this.btnopen.TabIndex = 10;
            this.btnopen.Text = "Laden";
            this.btnopen.UseVisualStyleBackColor = true;
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(535, 473);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(153, 23);
            this.btnsave.TabIndex = 11;
            this.btnsave.Text = "Speichern";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // Aufg7
            // 
            this.ClientSize = new System.Drawing.Size(700, 539);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnopen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Aufg7";
            this.Move += new System.EventHandler(this.WindowMove);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    private void button1_Click(object sender, System.EventArgs e)
    {
        FontDialog fd = new FontDialog();
        fd.Font = label3.Font;
        if (fd.ShowDialog() == DialogResult.OK)
        {
            label3.Font = fd.Font;
        };
    }

    private void button2_Click(object sender, System.EventArgs e)
    {
        ColorDialog cd = new ColorDialog();
        cd.Color = label4.BackColor;
        if (cd.ShowDialog() == DialogResult.OK)
        {
            label4.BackColor = cd.Color;
        }
    }

    private void radioButton_CheckedChanged(object sender, System.EventArgs e)
    {
        if (radioButton1.Checked)
            selected = 1;
        if (radioButton2.Checked)
            selected = 2;
        if (radioButton3.Checked)
            selected = 3;
        if (radioButton4.Checked)
            selected = 4;
        if (radioButton5.Checked)
        {
            textBox1.Enabled = true;
            selected = 5;
        }
        else
        {
            textBox1.Enabled = false;
        }
    }

    private void Mousemove(object sender, MouseEventArgs e)
    {
        if ((e.Button == MouseButtons.Left)&&(selected==1))
        {
            Pen pen = new Pen(label4.BackColor, (float)numericUpDown1.Value);
            g.DrawLine(pen, start.X, start.Y, e.X, e.Y);
            start = e.Location;
        }
    }

    private void Mousedown(object sender, MouseEventArgs e)
    {
        start = e.Location;
    }

    private void Mouseup(object sender, MouseEventArgs e)
    {
        Pen pen = new Pen(label4.BackColor, (float)numericUpDown1.Value);
        switch (selected)
        {
            case 1:
                // Do nothing
                break;
            case 2:
                g.DrawLine(pen, start, e.Location);
                break;
            case 3:
                if (start.X > e.X)
                {
                    if (start.Y > e.Y)
                        g.DrawEllipse(pen, e.X, e.Y, Math.Abs(e.X - start.X), Math.Abs(start.Y - e.Y));
                    else
                        g.DrawEllipse(pen, e.X, start.Y, Math.Abs(start.X - e.X), Math.Abs(start.Y - e.Y));
                }
                else
                {
                    if (start.Y > e.Y)
                        g.DrawEllipse(pen, start.X, e.Y, Math.Abs(e.X - start.X), Math.Abs(start.Y - e.Y));
                    else
                        g.DrawEllipse(pen, start.X, start.Y, Math.Abs(e.X - start.X), Math.Abs(e.Y - start.Y));
                }
                break;
            case 4:
                if (start.X > e.X) {
                    if(start.Y>e.Y)
                        g.DrawRectangle(pen, e.X, e.Y, Math.Abs(e.X - start.X), Math.Abs(start.Y - e.Y));
                    else
                        g.DrawRectangle(pen, e.X, start.Y, Math.Abs(start.X - e.X), Math.Abs(start.Y - e.Y));
                }
                else { 
                    if (start.Y > e.Y)
                        g.DrawRectangle(pen, start.X, e.Y, Math.Abs(e.X - start.X), Math.Abs(start.Y - e.Y));
                    else
                        g.DrawRectangle(pen, start.X, start.Y, Math.Abs(e.X - start.X), Math.Abs(e.Y - start.Y));
                }
                break;
            case 5:
                g.DrawString(textBox1.Text, label3.Font, brush, e.Location);
                break;
        }
    }

    private void WindowMove(object sender, EventArgs e)
    {
        //panel1.Refresh();
    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        switch (comboBox1.SelectedIndex)
        {
            case 0:
                brush = new HatchBrush(HatchStyle.Horizontal, Color.Red, label4.BackColor);
                break;
            case 1:
                brush = new LinearGradientBrush(start, new Point(start.X + 10, start.Y + 10), label4.BackColor,
                    Color.Blue);
                break;
            case 2:
                //brush = new PathGradientBrush(new GraphicsPath(st));
                break;
            case 3:
                brush = new SolidBrush(label4.BackColor);
                break;
            case 4:
                //brush = new TextureBrush();
                break;
        }

    }

    private void OnDragEnter(object sender, DragEventArgs e)
    {
        if (e.Data.GetDataPresent(DataFormats.FileDrop))
            e.Effect = DragDropEffects.Move;
    }
    private void OnDragDrop(object sender, DragEventArgs dea)
    {
        if (dea.Data.GetDataPresent(DataFormats.FileDrop))
        {
            string[] astr = (string[])dea.Data.GetData(DataFormats.FileDrop);

        }
    }

    private void btnsave_Click(object sender, EventArgs e)
    {
        SaveFileDialog ofd = new SaveFileDialog();
        ofd.ShowDialog();
        Bitmap bitmap = new Bitmap(panel1.Width, panel1.Height);
        g.Save();
        bitmap.Save(ofd.FileName, ImageFormat.Bmp);
    }
}