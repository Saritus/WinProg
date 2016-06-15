//namespace winprog

using System.Windows.Forms;
using System.Drawing;

public class Aufg2 : Form
{
    Point oldpoint;
    private bool line;


    public Aufg2()
    {
        Text = "Aufgabe 2";
        Size = new Size(500 , 500);
        CenterToScreen();
        //MessageBox.Show("Testausgabe MessageBox");
    }
    protected override void OnPaint(PaintEventArgs pea)
    { // paint-Event
        Graphics grfx = pea.Graphics;
        grfx.DrawString("my first App!!", Font, Brushes.Black, 100, 100);
    }

    protected override void OnMouseDown(MouseEventArgs mea)
    {
        oldpoint = new Point(mea.X, mea.Y);
        line = false;
    }

    protected override void OnMouseUp(MouseEventArgs mea)
    {
        if (!line)
        {
            Graphics grfx = CreateGraphics();
            grfx.DrawString("die Maus war hier", Font, Brushes.Black, mea.X, mea.Y);
            grfx.Dispose();
        }
}

    protected override void OnMouseMove(MouseEventArgs mea)
    {
        Graphics grfx = CreateGraphics();
        if (mea.Button == MouseButtons.Left)
        {
            grfx.DrawLine(Pens.Black, oldpoint, new Point(mea.X, mea.Y));
            oldpoint = new Point(mea.X, mea.Y);
            line = true;
        }
        grfx.Dispose();
        System.Windows.Forms.Cursor.Position = new Point(SystemInformation.VirtualScreen.Width / 2, SystemInformation.VirtualScreen.Height/ 2);
    }

    protected override void OnMove(System.EventArgs e)
    {
        CenterToScreen();
    }

    protected override void OnResize(System.EventArgs e)
    {
        CenterToScreen();
    }

    protected override void OnFormClosing(FormClosingEventArgs e)
    {
        Graphics grfx = CreateGraphics();
        grfx.DrawString("Schließen geht nicht", Font, Brushes.Black, 10, 10);
        e.Cancel = true;
    }
}