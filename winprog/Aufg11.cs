using System.Windows.Forms;
using System.Drawing;
using System.Runtime.InteropServices;
using System;

public class Aufg11 : Form
{
    private Button button2;
    private Button button3;
    private NumericUpDown numericUpDown1;
    private Button button4;
    private TextBox textBox1;
    private Button button1;

    [DllImport("DLL Praktikum.dll")]
    public static extern void teste0();
    [DllImport("DLL Praktikum.dll")]
    public static extern void teste1(int i);

    
    [DllImport("DLL Praktikum.dll")]
    public static extern IntPtr teste2();

    [DllImport("MFCLibrary1.dll")]
    public static extern int tolleZahl();
    

    public Aufg11()
    {
        Text = "Aufgabe 11";
        Size = new Size(500, 500);
        CenterToScreen();
        InitializeComponent();
    }

    private void InitializeComponent()
    {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(95, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 20);
            this.button1.TabIndex = 0;
            this.button1.Text = "test0";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(96, 38);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 20);
            this.button2.TabIndex = 0;
            this.button2.Text = "test1";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(96, 64);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 20);
            this.button3.TabIndex = 0;
            this.button3.Text = "test2";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(13, 38);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(77, 20);
            this.numericUpDown1.TabIndex = 2;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(13, 90);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(150, 20);
            this.button4.TabIndex = 3;
            this.button4.Text = "Meine DLL";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(169, 91);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(76, 20);
            this.textBox1.TabIndex = 4;
            // 
            // Aufg11
            // 
            this.ClientSize = new System.Drawing.Size(258, 125);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Aufg11";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    private void button1_Click(object sender, EventArgs e)
    {
        teste0();
    }

    private void button2_Click(object sender, EventArgs e)
    {
        try
        {
            teste1(Decimal.ToInt32(this.numericUpDown1.Value));
        }
        catch (Exception exception)
        {
            teste1(0);
        }
    }

    private void button3_Click(object sender, EventArgs e)
    {
        IntPtr ipr = teste2();
        string value = System.Runtime.InteropServices.Marshal.PtrToStringAnsi(ipr);
        MessageBox.Show(value);
    }

    private void button4_Click(object sender, EventArgs e)
    {
        textBox1.Text = tolleZahl().ToString();
    }
}