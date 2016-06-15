using System.Windows.Forms;
using System.Drawing;

public class Aufg12 : Form
{
    private WebBrowser webBrowser1;

    public Aufg12()
    {
        Text = "Aufgabe 12";
        Size = new Size(500, 500);
        CenterToScreen();
        InitializeComponent();
    }

    private void InitializeComponent()
    {
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(693, 573);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.DocumentText = "<!DOCTYPE html><html><body><h1>My First Heading</h1><p>My first paragraph.</p></body></html>";
            // 
            // Aufg12
            // 
            this.ClientSize = new System.Drawing.Size(693, 573);
            this.Controls.Add(this.webBrowser1);
            this.Name = "Aufg12";
            this.ResumeLayout(false);

    }
}