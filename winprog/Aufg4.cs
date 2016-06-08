using System.Windows.Forms;
using System.Drawing;

public class Aufg4 : Form
{
    private TrackBar trackBar1;
    private ProgressBar progressBar1;
    private TreeView treeView1;
    private Button button1;
    private TextBox textBox1;
    private Label label1;
    private ListView listBox1;
    private Label label2;
    private Label label3;
    private Label label4;
    private Button button2;
    private ToolTip tp;
    private System.ComponentModel.IContainer components;
    private Aufg5 m_aufg5;

    public Aufg4()
    {
        m_aufg5 = new Aufg5();
        Text = "Aufgabe 4";
        Size = new Size(500, 500);
        CenterToScreen();
        InitializeComponent();

    }

    private void InitializeComponent()
    {
            this.components = new System.ComponentModel.Container();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.tp = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 20;
            this.trackBar1.Location = new System.Drawing.Point(12, 12);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(200, 45);
            this.trackBar1.SmallChange = 10;
            this.trackBar1.TabIndex = 0;
            this.trackBar1.TickFrequency = 10;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(272, 12);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(200, 25);
            this.progressBar1.TabIndex = 1;
            // 
            // treeView1
            // 
            this.treeView1.HideSelection = false;
            this.treeView1.Location = new System.Drawing.Point(272, 62);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(200, 200);
            this.treeView1.TabIndex = 2;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.treeview_click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(272, 424);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 25);
            this.button1.TabIndex = 3;
            this.button1.Text = "Eintrag hinzufügen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(272, 398);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(272, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 100);
            this.label1.TabIndex = 5;
            this.label1.Text = "aktuelle Auswahl:";
            // 
            // listBox1
            // 
            //this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 63);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(200, 199);
            this.listBox1.TabIndex = 6;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 100);
            this.label2.TabIndex = 7;
            this.label2.Text = "aktuelle Auswahl:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(272, 365);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 30);
            this.label3.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(218, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "0%";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 424);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 25);
            this.button2.TabIndex = 10;
            this.button2.Text = "Optionen";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Aufg4
            // 
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.trackBar1);
            this.Name = "Aufg4";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    private void button1_Click(object sender, System.EventArgs e)
    {
        if (textBox1.Text != "")
        {
            listBox1.Items.Add(textBox1.Text);
            if(treeView1.SelectedNode == null)
                treeView1.Nodes.Add(textBox1.Text);
            else
                treeView1.SelectedNode.Nodes.Add(textBox1.Text);
                treeView1.ExpandAll();
            label3.Text = "";
        }
        else
        {
            label3.Text = "Eintrag darf nicht leer sein";
        }
    }

    private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
    {
        label1.Text = "aktuelle Auswahl:\n\n" + treeView1.SelectedNode.Text;
    }

    private void trackBar1_Scroll(object sender, System.EventArgs e)
    {
        progressBar1.Value = trackBar1.Value;
        label4.Text = trackBar1.Value + "%";
    }

    private void listBox1_SelectedIndexChanged(object sender, System.EventArgs e)
    {
        label2.Text = "aktuelle Auswahl:\n\n" + listBox1.SelectedItems.ToString();
    }

    private void treeview_click(object sender, MouseEventArgs e)
    {
        treeView1.SelectedNode = null;
    }

    private void button2_Click_1(object sender, System.EventArgs e)
    {

        if (m_aufg5.ShowDialog() == DialogResult.OK)
        {
            if (m_aufg5.checkBox1.Checked)
            {
                switch ((string) m_aufg5.comboBox1.SelectedItem)
                {
                    case "Deutsch":
                        tp.SetToolTip(button1, "Eintrag hinzufügen");
                        break;
                    case "English":
                        tp.SetToolTip(button1, "Insert item");
                        break;
                    case "Français":
                        tp.SetToolTip(button1, "Français");
                        break;
                    case "Espagnol":
                        tp.SetToolTip(button1, "Espagnol");
                        break;
                }
            }
            else
            {
                tp.RemoveAll();
            }
        }
       
    }
}