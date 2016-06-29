using System.Runtime.Remoting.Channels;
using System.Windows.Forms;
using System.Drawing;
using System;

public class Dialog : Form
{
    private Button btn_aufg3;
    private Button btn_aufg4;
    private Button btn_aufg5;
    private Button btn_aufg6;
    private Button btn_aufg7;
    private Button btn_aufg8;
    private Button btn_aufg9;
    private Button btn_aufg10;
    private Button btn_aufg11;
    private Button btn_aufg12;
    private Button btn_quit;
    private Button btn_aufg2;

    private Aufg9_Server server = new Aufg9_Server();

    public Dialog()
    {
        Text = "Erste Dialoganwendung";
        Size = new Size(1000, 600);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        CenterToScreen();
        InitializeComponent();
    }

    [STAThread]
    static public void Main()
    {
        Application.EnableVisualStyles();
        Application.Run(new Dialog());

    }

    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dialog));
        this.btn_aufg2 = new System.Windows.Forms.Button();
        this.btn_aufg3 = new System.Windows.Forms.Button();
        this.btn_aufg4 = new System.Windows.Forms.Button();
        this.btn_aufg5 = new System.Windows.Forms.Button();
        this.btn_aufg6 = new System.Windows.Forms.Button();
        this.btn_aufg7 = new System.Windows.Forms.Button();
        this.btn_aufg8 = new System.Windows.Forms.Button();
        this.btn_aufg9 = new System.Windows.Forms.Button();
        this.btn_aufg10 = new System.Windows.Forms.Button();
        this.btn_aufg11 = new System.Windows.Forms.Button();
        this.btn_aufg12 = new System.Windows.Forms.Button();
        this.btn_quit = new System.Windows.Forms.Button();
        this.SuspendLayout();
        // 
        // btn_aufg2
        // 
        this.btn_aufg2.Location = new System.Drawing.Point(12, 12);
        this.btn_aufg2.Name = "btn_aufg2";
        this.btn_aufg2.Size = new System.Drawing.Size(250, 50);
        this.btn_aufg2.TabIndex = 0;
        this.btn_aufg2.Text = "Aufgabe 2\n Reaktion auf Ereignisse";
        this.btn_aufg2.UseVisualStyleBackColor = true;
        this.btn_aufg2.Click += new System.EventHandler(this.btn_aufg2_Click);
        // 
        // btn_aufg3
        // 
        this.btn_aufg3.Location = new System.Drawing.Point(12, 68);
        this.btn_aufg3.Name = "btn_aufg3";
        this.btn_aufg3.Size = new System.Drawing.Size(250, 50);
        this.btn_aufg3.TabIndex = 1;
        this.btn_aufg3.Text = "Aufgabe 3\nklassische Standardsteuerelemente";
        this.btn_aufg3.UseVisualStyleBackColor = true;
        this.btn_aufg3.Click += new System.EventHandler(this.btn_aufg3_Click);
        // 
        // btn_aufg4
        // 
        this.btn_aufg4.Location = new System.Drawing.Point(12, 124);
        this.btn_aufg4.Name = "btn_aufg4";
        this.btn_aufg4.Size = new System.Drawing.Size(250, 50);
        this.btn_aufg4.TabIndex = 2;
        this.btn_aufg4.Text = "Aufgabe 4\nweitere Steuerelemente";
        this.btn_aufg4.UseVisualStyleBackColor = true;
        this.btn_aufg4.Click += new System.EventHandler(this.btn_aufg4_Click);
        // 
        // btn_aufg5
        // 
        this.btn_aufg5.Location = new System.Drawing.Point(12, 180);
        this.btn_aufg5.Name = "btn_aufg5";
        this.btn_aufg5.Size = new System.Drawing.Size(250, 50);
        this.btn_aufg5.TabIndex = 3;
        this.btn_aufg5.Text = "Aufgabe 5\nTooltips und mehrseitige Dialoge";
        this.btn_aufg5.UseVisualStyleBackColor = true;
        this.btn_aufg5.Click += new System.EventHandler(this.btn_aufg5_Click);
        // 
        // btn_aufg6
        // 
        this.btn_aufg6.Location = new System.Drawing.Point(268, 12);
        this.btn_aufg6.Name = "btn_aufg6";
        this.btn_aufg6.Size = new System.Drawing.Size(250, 50);
        this.btn_aufg6.TabIndex = 4;
        this.btn_aufg6.Text = "Aufgabe 6\nein einfacher Texteditor";
        this.btn_aufg6.UseVisualStyleBackColor = true;
        this.btn_aufg6.Click += new System.EventHandler(this.btn_aufg6_Click);
        // 
        // btn_aufg7
        // 
        this.btn_aufg7.Location = new System.Drawing.Point(268, 68);
        this.btn_aufg7.Name = "btn_aufg7";
        this.btn_aufg7.Size = new System.Drawing.Size(250, 50);
        this.btn_aufg7.TabIndex = 5;
        this.btn_aufg7.Text = "Aufgabe 7\nein erstes Zeichenprogramm";
        this.btn_aufg7.UseVisualStyleBackColor = true;
        this.btn_aufg7.Click += new System.EventHandler(this.btn_aufg7_Click);
        // 
        // btn_aufg8
        // 
        this.btn_aufg8.Location = new System.Drawing.Point(268, 124);
        this.btn_aufg8.Name = "btn_aufg8";
        this.btn_aufg8.Size = new System.Drawing.Size(250, 50);
        this.btn_aufg8.TabIndex = 6;
        this.btn_aufg8.Text = "Aufgabe 8\ngraphische Benutzeroberflächen mit Bitmaps";
        this.btn_aufg8.UseVisualStyleBackColor = true;
        this.btn_aufg8.Click += new System.EventHandler(this.btn_aufg8_Click);
        // 
        // btn_aufg9
        // 
        this.btn_aufg9.Location = new System.Drawing.Point(268, 180);
        this.btn_aufg9.Name = "btn_aufg9";
        this.btn_aufg9.Size = new System.Drawing.Size(250, 50);
        this.btn_aufg9.TabIndex = 7;
        this.btn_aufg9.Text = "Aufgabe 9\nDatenaustausch über Sockets";
        this.btn_aufg9.UseVisualStyleBackColor = true;
        this.btn_aufg9.Click += new System.EventHandler(this.btn_aufg9_Click);
        // 
        // btn_aufg10
        // 
        this.btn_aufg10.Location = new System.Drawing.Point(524, 12);
        this.btn_aufg10.Name = "btn_aufg10";
        this.btn_aufg10.Size = new System.Drawing.Size(250, 50);
        this.btn_aufg10.TabIndex = 8;
        this.btn_aufg10.Text = "Aufgabe 10\ndie Arbeit mit Threads";
        this.btn_aufg10.UseVisualStyleBackColor = true;
        this.btn_aufg10.Click += new System.EventHandler(this.btn_aufg10_Click);
        // 
        // btn_aufg11
        // 
        this.btn_aufg11.Location = new System.Drawing.Point(524, 68);
        this.btn_aufg11.Name = "btn_aufg11";
        this.btn_aufg11.Size = new System.Drawing.Size(250, 50);
        this.btn_aufg11.TabIndex = 9;
        this.btn_aufg11.Text = "Aufgabe 11\nNutzen einer DLL-Bibliothek, Interoperabilität";
        this.btn_aufg11.UseVisualStyleBackColor = true;
        this.btn_aufg11.Click += new System.EventHandler(this.btn_aufg11_Click);
        // 
        // btn_aufg12
        // 
        this.btn_aufg12.Location = new System.Drawing.Point(524, 124);
        this.btn_aufg12.Name = "btn_aufg12";
        this.btn_aufg12.Size = new System.Drawing.Size(250, 50);
        this.btn_aufg12.TabIndex = 10;
        this.btn_aufg12.Text = "Aufgabe 12\nWindows Presentation Foundation";
        this.btn_aufg12.UseVisualStyleBackColor = true;
        this.btn_aufg12.Click += new System.EventHandler(this.btn_aufg12_Click);
        // 
        // btn_quit
        // 
        this.btn_quit.Location = new System.Drawing.Point(574, 190);
        this.btn_quit.Name = "btn_quit";
        this.btn_quit.Size = new System.Drawing.Size(200, 40);
        this.btn_quit.TabIndex = 11;
        this.btn_quit.Text = "Programm verlassen";
        this.btn_quit.UseVisualStyleBackColor = true;
        this.btn_quit.Click += new System.EventHandler(this.btn_quit_Click);
        // 
        // Dialog
        // 
        this.AutoSize = true;
        this.ClientSize = new System.Drawing.Size(786, 245);
        this.Controls.Add(this.btn_quit);
        this.Controls.Add(this.btn_aufg12);
        this.Controls.Add(this.btn_aufg11);
        this.Controls.Add(this.btn_aufg10);
        this.Controls.Add(this.btn_aufg9);
        this.Controls.Add(this.btn_aufg8);
        this.Controls.Add(this.btn_aufg7);
        this.Controls.Add(this.btn_aufg6);
        this.Controls.Add(this.btn_aufg5);
        this.Controls.Add(this.btn_aufg4);
        this.Controls.Add(this.btn_aufg3);
        this.Controls.Add(this.btn_aufg2);
        this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
        this.Name = "Dialog";
        this.ResumeLayout(false);

    }

    private void btn_aufg2_Click(object sender, System.EventArgs e)
    {
        Aufg2 m_aufg2 = new Aufg2(); m_aufg2.Show();
    }

    private void btn_aufg3_Click(object sender, System.EventArgs e)
    {
        Aufg3 m_aufg3 = new Aufg3(); m_aufg3.ShowDialog();
    }

    private void btn_aufg4_Click(object sender, System.EventArgs e)
    {
        Aufg4 m_aufg4 = new Aufg4(); m_aufg4.ShowDialog();
    }

    private void btn_aufg5_Click(object sender, System.EventArgs e)
    {
        Aufg5 m_aufg5 = new Aufg5(); m_aufg5.ShowDialog();
    }

    private void btn_aufg6_Click(object sender, System.EventArgs e)
    {
        Aufg6 m_aufg6 = new Aufg6(); m_aufg6.ShowDialog();
    }

    private void btn_aufg7_Click(object sender, System.EventArgs e)
    {
        Aufg7 m_aufg7 = new Aufg7(); m_aufg7.ShowDialog();
    }

    private void btn_aufg8_Click(object sender, System.EventArgs e)
    {
        Aufg8 m_aufg8 = new Aufg8(); m_aufg8.ShowDialog();
    }

    private void btn_aufg9_Click(object sender, System.EventArgs e)
    {
        server.Show();
        Aufg9_Client client = new Aufg9_Client();
        client.Show();
    }

    private void btn_aufg10_Click(object sender, System.EventArgs e)
    {
        Aufg10 m_aufg10 = new Aufg10(); m_aufg10.ShowDialog();
    }

    private void btn_aufg11_Click(object sender, System.EventArgs e)
    {
        Aufg11 m_aufg11 = new Aufg11(); m_aufg11.ShowDialog();
    }

    private void btn_aufg12_Click(object sender, System.EventArgs e)
    {
        Aufg12 m_aufg12 = new Aufg12(); m_aufg12.ShowDialog();
    }

    private void btn_quit_Click(object sender, System.EventArgs e)
    {
        this.Close();
    }
}