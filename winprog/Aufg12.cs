using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;

public class Aufg12 : Form
{
    private Panel panel;
    private Graphics pg;
    private Bitmap buffer;
    private Graphics bg;
    private Point start;

    public Aufg12()
    {
        Text = "Aufgabe 12";
        Size = new Size(500, 500);
        CenterToScreen();
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        this.panel = new System.Windows.Forms.Panel();
        this.SuspendLayout();
        // 
        // panel
        // 
        this.panel.Location = new System.Drawing.Point(12, 12);
        this.panel.Name = "panel1";
        this.panel.Size = new System.Drawing.Size(500, 500);
        this.panel.TabIndex = 0;
        this.panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
        this.panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnMouseMove);
        this.panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUp);
        //
        // graphics
        //
        buffer = new Bitmap(panel.Width, panel.Height, PixelFormat.Format24bppRgb);
        pg = panel.CreateGraphics();
        bg = Graphics.FromImage(buffer);
        bg.FillRectangle(new SolidBrush(Color.White), 0, 0, buffer.Width, buffer.Height);
        // 
        // Aufg12
        // 
        this.ClientSize = new System.Drawing.Size(693, 573);
        this.Controls.Add(this.panel);
        this.Name = "Aufg12";
        this.ResumeLayout(false);

    }

    private void OnMouseDown(object sender, MouseEventArgs e)
    {
        start = e.Location;
    }

    private void OnMouseMove(object sender, MouseEventArgs e)
    {
        if ((Control.MouseButtons & MouseButtons.Left) != 0)
        {
            pg.DrawImage(buffer, 0, 0, buffer.Width, buffer.Height);
            pg.DrawLine(new Pen(Color.Black), start, e.Location);
        }
    }

    private void OnMouseUp(object sender, MouseEventArgs e)
    {
        bg.DrawLine(new Pen(Color.Black), start, e.Location);
    }
}

class WriteTextFile
{
    static void write()
    {
        // WriteAllLines
        string[] lines = { "First line", "Second line", "Third line" };
        System.IO.File.WriteAllLines(@"C:\Users\Public\TestFolder\WriteLines.txt", lines);

        // WriteAllText
        string text = "A class is the most powerful data type in C#. Like a structure, " +
                       "a class defines the data and behavior of the data type. ";
        System.IO.File.WriteAllText(@"C:\Users\Public\TestFolder\WriteText.txt", text);

        // WriteLine
        using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(@"C:\Users\Public\TestFolder\WriteLines2.txt"))
        {
            foreach (string line in lines)
            {
                if (!line.Contains("Second"))
                {
                    file.WriteLine(line);
                }
            }
        }

        // WriteLine append
        using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(@"C:\Users\Public\TestFolder\WriteLines2.txt", true))
        {
            file.WriteLine("Fourth line");
        }
    }
}