using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Text;
using System;
using System.Text.RegularExpressions;
//using MarkupConverter;

public class Aufg6 : Form
{
    private Button button1;
    private Button button2;
    private Button button3;
    private RichTextBox richTextBox1;
    private Button button4;

    public Aufg6()
    {
        Text = "Aufgabe 6";
        CenterToScreen();
        InitializeComponent();
        Size = new Size(800, 500);
        this.MinimumSize = new Size(470, 150);
    }

    private void InitializeComponent()
    {
        this.button1 = new System.Windows.Forms.Button();
        this.button2 = new System.Windows.Forms.Button();
        this.button3 = new System.Windows.Forms.Button();
        this.button4 = new System.Windows.Forms.Button();
        this.richTextBox1 = new System.Windows.Forms.RichTextBox();
        this.SuspendLayout();
        // 
        // button1
        // 
        this.button1.Location = new System.Drawing.Point(12, 12);
        this.button1.Name = "button1";
        this.button1.Size = new System.Drawing.Size(100, 25);
        this.button1.TabIndex = 0;
        this.button1.Text = "Load";
        this.button1.UseVisualStyleBackColor = true;
        this.button1.Click += new System.EventHandler(this.button1_Click);
        // 
        // button2
        // 
        this.button2.Location = new System.Drawing.Point(118, 12);
        this.button2.Name = "button2";
        this.button2.Size = new System.Drawing.Size(100, 25);
        this.button2.TabIndex = 1;
        this.button2.Text = "Save";
        this.button2.UseVisualStyleBackColor = true;
        this.button2.Click += new System.EventHandler(this.button2_Click);
        // 
        // button3
        // 
        this.button3.Location = new System.Drawing.Point(266, 12);
        this.button3.Name = "button3";
        this.button3.Size = new System.Drawing.Size(100, 25);
        this.button3.TabIndex = 2;
        this.button3.Text = "Textfarbe";
        this.button3.UseVisualStyleBackColor = true;
        this.button3.Click += new System.EventHandler(this.button3_Click);
        // 
        // button4
        // 
        this.button4.Location = new System.Drawing.Point(372, 12);
        this.button4.Name = "button4";
        this.button4.Size = new System.Drawing.Size(100, 25);
        this.button4.TabIndex = 3;
        this.button4.Text = "Schriftart";
        this.button4.UseVisualStyleBackColor = true;
        this.button4.Click += new System.EventHandler(this.button4_Click);
        // 
        // richTextBox1
        // 
        this.richTextBox1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold);
        this.richTextBox1.Location = new System.Drawing.Point(12, 43);
        this.richTextBox1.Name = "richTextBox1";
        this.richTextBox1.Size = new System.Drawing.Size(460, 206);
        this.richTextBox1.TabIndex = 4;
        this.richTextBox1.Text = "";
        this.richTextBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.OnDragEnter);
        this.richTextBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.OnDragDrop);
        this.richTextBox1.AllowDrop = true;
        // 
        // Aufg6
        // 
        this.ClientSize = new System.Drawing.Size(484, 261);
        this.Controls.Add(this.richTextBox1);
        this.Controls.Add(this.button4);
        this.Controls.Add(this.button3);
        this.Controls.Add(this.button2);
        this.Controls.Add(this.button1);
        this.Name = "Aufg6";
        this.ResumeLayout(false);

    }

    private void button3_Click(object sender, System.EventArgs e)
    {
        ColorDialog cd = new ColorDialog();
        cd.Color = richTextBox1.SelectionColor;
        cd.ShowDialog();
        richTextBox1.SelectionColor = cd.Color;
    }

    private void button4_Click(object sender, System.EventArgs e)
    {
        FontDialog fd = new FontDialog();
        //fd.ShowColor = true;
        fd.Font = richTextBox1.SelectionFont;
        //fd.Font = richTextBox1.Font;
        fd.ShowDialog();
        richTextBox1.SelectionFont = fd.Font;
    }

    private void button1_Click(object sender, System.EventArgs e)
    {
        OpenFileDialog ofd = new OpenFileDialog();
        ofd.InitialDirectory = "G:\\winprog\\winprog\\bin";
        ofd.Filter = "Textdateien|*.txt|Rich Text Format|*.rtf|Alle Dateien|*.*";
        ofd.FilterIndex = 3;
        if (ofd.ShowDialog() == DialogResult.OK)
        {
            LoadFile(ofd.FileName);
            //richTextBox1.LoadFile(ofd.FileName);
            //richTextBox1.Text = ofd.FileName;

        }
    }

    private void button2_Click(object sender, System.EventArgs e)
    {
        SaveFileDialog sfd = new SaveFileDialog();
        sfd.InitialDirectory = "G:\\winprog\\winprog\\bin";
        sfd.Filter = "Textdateien|*.txt|Rich Text Format|*.rtf|Alle Dateien|*.*";
        if (sfd.ShowDialog() == DialogResult.OK)
        {
            switch (Path.GetExtension(sfd.FileName))
            {
                case ".txt":
                    richTextBox1.SaveFile(sfd.FileName, RichTextBoxStreamType.PlainText);
                    break;
                case ".rtf":
                    richTextBox1.SaveFile(sfd.FileName);
                    break;
                case ".html":
                    TextWriter tw = new StreamWriter(sfd.FileName);
                    richTextBox1.SelectAll();
                    richTextBox1.Copy();
                    IDataObject iData = Clipboard.GetDataObject();
                    string[] f = iData.GetFormats();
                    string rtf = (string)iData.GetData(DataFormats.Rtf);
                    break;
                default:
                    //richTextBox1.Text = "Unknown file extension " + Path.GetExtension(ofd.FileName);
                    richTextBox1.SaveFile(sfd.FileName, RichTextBoxStreamType.PlainText);
                    break;
            }
            //richTextBox1.LoadFile(ofd.FileName);
            //richTextBox1.Text = ofd.FileName;

        }
    }

    protected override void OnResize(System.EventArgs e)
    {
        richTextBox1.Height = this.Height - 95;
        richTextBox1.Width = this.Width - 40;
        button3.Location = new Point(this.Width - 235, button4.Location.Y);
        button4.Location = new Point(this.Width - 130, button4.Location.Y);
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
            LoadFile(astr[0]);
        }
    }

    private void LoadFile(string path)
    {
        switch (Path.GetExtension(path))
        {
            case ".txt":
                richTextBox1.LoadFile(path, RichTextBoxStreamType.PlainText);
                break;
            case ".rtf":
                richTextBox1.LoadFile(path, RichTextBoxStreamType.RichText);
                break;
            case ".html":
                WebBrowser wb = new WebBrowser();
                wb.Navigate("about:blank");
                richTextBox1.LoadFile(path, RichTextBoxStreamType.PlainText);
                wb.Document.Write(richTextBox1.Text);
                wb.Document.ExecCommand("SelectAll", false, null);
                wb.Document.ExecCommand("Copy", false, null);
                richTextBox1.SelectAll();
                richTextBox1.Paste();
                break;
            case ".gif":
            case ".jpg":
            case ".png":
                Image myImage = Image.FromFile(path);
                Clipboard.SetImage(myImage);
                //richTextBox1.Clear();
                richTextBox1.Paste();
                break;
            default:
                //richTextBox1.Text = "Unknown file extension " + Path.GetExtension(ofd.FileName);
                richTextBox1.LoadFile(path, RichTextBoxStreamType.PlainText);
                break;
        }
    }
}