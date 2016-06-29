using System;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.Drawing;
using System.Windows.Input;
using System.Windows;

public class Aufg8 : Form
{
    private Bitmap background;
    private Bitmap ultralisk;
    private Bitmap ultraliskFlip;
    private Bitmap ultraliskWalk;
    private Bitmap mutalisk;
    private Bitmap myBuffer;
    private int myStepNr;

    private Point pos;
    private Point click;
    private char direction = 'r';
    private double winkel;
    private int d;
    private double t = 10;

    public Aufg8()
    {
        Text = "Aufgabe 8";
        Size = new Size(1024, 768);
        CenterToScreen();
        InitializeComponent();
        Init();
        Timer t = new Timer();
    }

    private void InitializeComponent()
    {
        this.SuspendLayout();
        // 
        // Aufg8
        // 
        this.ClientSize = new System.Drawing.Size(1008, 729);
        this.Name = "Aufg8";
        this.ResumeLayout(false);
    }

    private void Init()
    {
        myBuffer = new Bitmap(this.Width, this.Height, PixelFormat.Format24bppRgb);
        background = new Bitmap("Creep.bmp");
        ultralisk = new Bitmap("Ultralisk.bmp");
        ultralisk.MakeTransparent(ultralisk.GetPixel(0, 0));
        ultraliskFlip = new Bitmap(ultralisk);
        ultraliskFlip.RotateFlip(RotateFlipType.RotateNoneFlipX);
        ultraliskWalk = new Bitmap(ultralisk);
        mutalisk = new Bitmap("Mutalisk.bmp");
        mutalisk.MakeTransparent(mutalisk.GetPixel(0, 0));
        myStepNr = 0;
        Timer timer = new Timer();
        timer.Tick += new EventHandler(DrawIt);
        timer.Interval = 50; timer.Start(); // 20 fps
    }

    private void DrawIt(Object obj, EventArgs ea)
    {
        Graphics b = Graphics.FromImage(myBuffer);
        b.DrawImage(background, 0, 0, background.Width, background.Height);

        // Ultralisk läuft
        b.DrawImage(ultralisk, (myStepNr * 4) % (this.Width + 200) - 100, 160,
            new Rectangle(404, (myStepNr % 10) * 108, 101, 108), GraphicsUnit.Pixel);

        // Mutalisk fliegt
        b.DrawImage(mutalisk, (myStepNr * 9) % (this.Width + 200) - 100, 350,
            new Rectangle(4 * 67, (myStepNr % 5) * 75, 67, 75), GraphicsUnit.Pixel);

        // Ultralisken kämpfen
        b.DrawImage(ultralisk, 100, 550,
            new Rectangle(505, (9 + myStepNr % 6) * 108, 101, 108), GraphicsUnit.Pixel);
        b.DrawImage(ultraliskFlip, 190, 550,
            new Rectangle(404, (9 + (myStepNr + 3) % 6) * 108, 101, 108), GraphicsUnit.Pixel);

        b.DrawImage(ultralisk, 500, 500,
            new Rectangle(909, (9 + myStepNr % 6) * 108, 101, 108), GraphicsUnit.Pixel);
        b.DrawImage(ultralisk, 500, 570,
            new Rectangle(0, (9 + (myStepNr + 3) % 6) * 108, 101, 108), GraphicsUnit.Pixel);

        // Ultralisk läuft zur Mauspos
        if (differenz(click, pos) > (t / 2) + 1)
        {
            double xschritt;
            double yschritt;
            double xDiff = click.X - pos.X;
            double yDiff = click.Y - pos.Y;
            /*else if ((xDiff == 0) && (yDiff < 0))
            {
                xschritt = 0;
                yschritt = t;
            }*/
            if ((int)xDiff < 0)
            {
                xschritt = -t / Math.Sqrt((yDiff * yDiff) / (xDiff * xDiff) + 1);
                yschritt = ((yDiff / xDiff) * xschritt);
            }
            else if ((int)xDiff > 0)
            {
                xschritt = t / Math.Sqrt((yDiff * yDiff) / (xDiff * xDiff) + 1);
                yschritt = (yDiff / xDiff) * xschritt;
            }
            else if (((int)xDiff == 0) && ((int)yDiff > 0))
            {
                xschritt = 0;
                yschritt = t;
            }
            else
            {
                xschritt = 0;
                yschritt = -t;
            }
            pos.X = (int)xschritt + pos.X;
            pos.Y = (int)yschritt + pos.Y;
            winkel = -Math.Atan2(yDiff, xDiff) * 180.0 / Math.PI;
            if (winkel < -90)
                winkel = -90 + (-90 - winkel);
            d = Math.Abs((int)((90 - winkel) / 20) * 101);
            if (direction == 'l')
                d = 909 - d;
            b.DrawImage(ultraliskWalk, pos.X - 40, pos.Y - 44,
                new Rectangle(d, (myStepNr % 10) * 108, 101, 108), GraphicsUnit.Pixel);
        }
        else
        {
            b.DrawImage(ultraliskWalk, pos.X - 40, pos.Y - 44,
                new Rectangle(d, 0, 101, 108), GraphicsUnit.Pixel);
        }

        myStepNr++;
        /*b.DrawString("Winkel: " + winkel + ", d: " + d, new Font(FontFamily.GenericSerif, 12.0F, FontStyle.Regular), Brushes.White, new Point(1, 1));
        b.DrawString("X: "+ pos.X + " , Y: " + pos.Y, new Font(FontFamily.GenericSerif, 12.0F, FontStyle.Regular), Brushes.White, new Point(1, 19));
        b.DrawString("Abstand: " + differenz(click,pos), new Font(FontFamily.GenericSerif, 12.0F, FontStyle.Regular), Brushes.White, new Point(1, 37));*/

        Graphics e = CreateGraphics();
        e.DrawImage(myBuffer, 0, 0, myBuffer.Width, myBuffer.Height);
        e.Dispose(); b.Dispose();
    }

    protected override void OnMouseDown(MouseEventArgs e)
    {
        click = e.Location;
        if ((click.X < pos.X) && (direction == 'r'))
        {
            ultraliskWalk.RotateFlip(RotateFlipType.RotateNoneFlipX);
            direction = 'l';
        }
        if ((click.X > pos.X) && (direction == 'l'))
        {
            ultraliskWalk.RotateFlip(RotateFlipType.RotateNoneFlipX);
            direction = 'r';
        }
    }

    protected override void OnMouseMove(MouseEventArgs e)
    {
        if ((Control.MouseButtons & MouseButtons.Left) != 0)
        {
            click = e.Location;
            if ((click.X < pos.X) && (direction == 'r'))
            {
                ultraliskWalk.RotateFlip(RotateFlipType.RotateNoneFlipX);
                direction = 'l';
            }
            if ((click.X > pos.X) && (direction == 'l'))
            {
                ultraliskWalk.RotateFlip(RotateFlipType.RotateNoneFlipX);
                direction = 'r';
            }
        }
    }

    private double differenz(Point a, Point b)
    {
        return Math.Sqrt((a.X - b.X) * (a.X - b.X) + (a.Y - b.Y) * (a.Y - b.Y));
    }
}