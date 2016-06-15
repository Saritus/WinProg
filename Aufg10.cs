using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System;
using System.Threading;
using System.Runtime.InteropServices;

public class Aufg10 : Form
{
    private RichTextBox listBox1;
    private Button button2;
    private Button button3;
    private Button button1;

    ThreadStart del;
    Thread thread;
    private delegate void DelegateTextOut(long i);
    private DelegateTextOut to;
    private Label label1;
    private ProgressBar progressBar1;
    private List<long> primearray = new List<long>();
    private bool run = false;

    private int maxPrime = 50000000; // 822066

    public Aufg10()
    {
        Text = "Aufgabe 10";
        Size = new Size(500, 500);
        CenterToScreen();
        InitProgressBar();
        InitializeComponent();
        to = new DelegateTextOut(TextOut);
    }

    private void InitProgressBar()
    {
        progressBar1 = new ProgressBar();
        this.progressBar1.Location = new System.Drawing.Point(12, 451);
        this.progressBar1.Name = "progressBar1";
        this.progressBar1.Size = new System.Drawing.Size(231, 23);
        this.progressBar1.TabIndex = 6;
        this.progressBar1.Style = ProgressBarStyle.Continuous;
        this.progressBar1.ForeColor = Color.GreenYellow;
        //ModifyProgressBarColor.SetState(progressBar1, 1);
        this.Controls.Add(this.progressBar1);
    }
    private void InitializeComponent()
    {
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(138, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Multiline = true;
            this.listBox1.Name = "listBox1";
            //this.listBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.listBox1.Size = new System.Drawing.Size(120, 433);
            this.listBox1.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(138, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Pause";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(138, 70);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Stop";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(138, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 89);
            this.label1.TabIndex = 5;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Aufg10
            // 
            this.ClientSize = new System.Drawing.Size(255, 486);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Name = "Aufg10";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.MyClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    private void button1_Click(object sender, EventArgs e)
    {
        if (thread == null)
        {
            del = new ThreadStart(TestMethod);
            thread = new Thread(del);
            thread.Start();
        }
        else
        {
            if (thread.ThreadState == ThreadState.Suspended)
                thread.Resume();
        }
        //for (; ; ) { }
    }

    public void TestMethod()
    {
        run = true;
        bool prime = true;
        DateTime start = DateTime.Now;
        for (long i = 2; i <= maxPrime; i++)
        {
            long k = 1 + (int)Math.Sqrt(i);
            for (long j = 2; j < k; j++)
            {
                if (i % j == 0)
                {
                    prime = false;
                    break;
                }
            }
            if (prime)
            {
                primearray.Add(i);
                Invoke(to, i);
            }
            else
            {
                prime = true;
            }
        }
        
        this.Invoke((MethodInvoker)delegate
        {
            StringBuilder sb = new StringBuilder("");
            for (int i = 0; i < primearray.Count; i++)
            {
                sb.Append(primearray[i] + "\r\n");
            }
            listBox1.Text = sb.ToString();
            progressBar1.Value = 100;
            DateTime ende = DateTime.Now;
            label1.Text = "Dauer: " + (ende - start).TotalSeconds + "ms\n" + "Items: " + primearray.Count; // runs on UI thread
        });
        run = false;
    }

    private void button2_Click(object sender, EventArgs e)
    {
        if (thread!=null)
        {
            thread.Suspend();
        }
    }

    private void button3_Click(object sender, EventArgs e)
    {
        if ((thread != null) && (true)) 
            thread.Abort();
        run = false;
    }

    private void TextOut(long i)
    {
        //listBox1.Items.Add(i);
        progressBar1.Value = (int)(100 * i / maxPrime);
        //listBox1.SelectedIndex = listBox1.Items.Count - 1;
    }

    protected void MyClosing(Object s, CancelEventArgs cea)
    {
        // Thread beenden
        if (run)
        {
            if (thread.ThreadState == ThreadState.Running)
                thread.Abort();
        }

        // ListBox abspeichern
        listBox1.SaveFile("prime.txt", RichTextBoxStreamType.PlainText);

        // Fenster schließen
        cea.Cancel = false;
    }
}

public class MyProgressBar : ProgressBar
{
    public MyProgressBar()
    {
        this.SetStyle(ControlStyles.UserPaint, true);
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        Rectangle rec = e.ClipRectangle;

        rec.Width = (int)(rec.Width * ((double)Value / Maximum)) - 2;
        if (ProgressBarRenderer.IsSupported)
            ProgressBarRenderer.DrawHorizontalBar(e.Graphics, e.ClipRectangle);
        rec.Height = rec.Height - 2;
        e.Graphics.FillRectangle(Brushes.Red, 1, 1, rec.Width, rec.Height);
        e.Graphics.DrawString(Value + "", new Font(FontFamily.GenericSerif, 12.0F, FontStyle.Regular), Brushes.White, new Point(1,1));
    }
}

public static class ModifyProgressBarColor
{
    [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
    static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr w, IntPtr l);
    public static void SetState(ProgressBar pBar, int state)
    {
        SendMessage(pBar.Handle, 1040, (IntPtr)state, IntPtr.Zero);
    }
}