using System.Windows.Forms;
using System.Drawing;

public class Aufg5 : Form
{
    private TabControl tabControl1;
    private TabPage tabPage1;
    private TabPage tabPage2;
    private Label label2;
    private Button button1;
    private Button button2;
    private Label label3;
    public ComboBox comboBox1;
    public CheckBox checkBox1;
    private Label label1;

    public Aufg5()
    {
        Text = "Aufgabe 5";
        Size = new Size(500, 500);
        CenterToScreen();
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        this.tabControl1 = new System.Windows.Forms.TabControl();
        this.tabPage1 = new System.Windows.Forms.TabPage();
        this.label2 = new System.Windows.Forms.Label();
        this.tabPage2 = new System.Windows.Forms.TabPage();
        this.label3 = new System.Windows.Forms.Label();
        this.comboBox1 = new System.Windows.Forms.ComboBox();
        this.checkBox1 = new System.Windows.Forms.CheckBox();
        this.label1 = new System.Windows.Forms.Label();
        this.button1 = new System.Windows.Forms.Button();
        this.button2 = new System.Windows.Forms.Button();
        this.tabControl1.SuspendLayout();
        this.tabPage1.SuspendLayout();
        this.tabPage2.SuspendLayout();
        this.SuspendLayout();
        // 
        // tabControl1
        // 
        this.tabControl1.Controls.Add(this.tabPage1);
        this.tabControl1.Controls.Add(this.tabPage2);
        this.tabControl1.Location = new System.Drawing.Point(15, 37);
        this.tabControl1.Name = "tabControl1";
        this.tabControl1.SelectedIndex = 0;
        this.tabControl1.Size = new System.Drawing.Size(257, 212);
        this.tabControl1.TabIndex = 0;
        // 
        // tabPage1
        // 
        this.tabPage1.Controls.Add(this.label2);
        this.tabPage1.Location = new System.Drawing.Point(4, 22);
        this.tabPage1.Name = "tabPage1";
        this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
        this.tabPage1.Size = new System.Drawing.Size(249, 186);
        this.tabPage1.TabIndex = 0;
        this.tabPage1.Text = "Hilfe";
        this.tabPage1.UseVisualStyleBackColor = true;
        // 
        // label2
        // 
        this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.label2.Location = new System.Drawing.Point(6, 3);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(237, 180);
        this.label2.TabIndex = 0;
        this.label2.Text = "Hilfe zum Programm\n\nDie aktuelle Hilfe zu diesem Programm finden Sie unter http:/" +
"/programmhilfe.de";
        // 
        // tabPage2
        // 
        this.tabPage2.Controls.Add(this.label3);
        this.tabPage2.Controls.Add(this.comboBox1);
        this.tabPage2.Controls.Add(this.checkBox1);
        this.tabPage2.Location = new System.Drawing.Point(4, 22);
        this.tabPage2.Name = "tabPage2";
        this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
        this.tabPage2.Size = new System.Drawing.Size(249, 186);
        this.tabPage2.TabIndex = 1;
        this.tabPage2.Text = "Tooltipps";
        this.tabPage2.UseVisualStyleBackColor = true;
        // 
        // label3
        // 
        this.label3.Location = new System.Drawing.Point(61, 101);
        this.label3.Name = "label3";
        this.label3.Size = new System.Drawing.Size(121, 20);
        this.label3.TabIndex = 2;
        this.label3.Text = "Sprache der Tooltipps:";
        // 
        // comboBox1
        // 
        this.comboBox1.FormattingEnabled = true;
        this.comboBox1.Items.AddRange(new object[] {
            "Deutsch",
            "English",
            "Français",
            "Espagnol"});
        this.comboBox1.Location = new System.Drawing.Point(64, 124);
        this.comboBox1.Name = "comboBox1";
        this.comboBox1.Size = new System.Drawing.Size(118, 21);
        this.comboBox1.TabIndex = 1;
        this.comboBox1.SelectedItem = "Deutsch";
        this.comboBox1.Enabled = false;
        // 
        // checkBox1
        // 
        this.checkBox1.AutoSize = true;
        this.checkBox1.Location = new System.Drawing.Point(64, 44);
        this.checkBox1.Name = "checkBox1";
        this.checkBox1.Size = new System.Drawing.Size(118, 17);
        this.checkBox1.TabIndex = 0;
        this.checkBox1.Text = "Tooltipps aktivieren";
        this.checkBox1.UseVisualStyleBackColor = true;
        this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
        // 
        // label1
        // 
        this.label1.Location = new System.Drawing.Point(12, 9);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(260, 25);
        this.label1.TabIndex = 1;
        this.label1.Text = "Optionen";
        // 
        // button1
        // 
        this.button1.Location = new System.Drawing.Point(19, 255);
        this.button1.Name = "button1";
        this.button1.Size = new System.Drawing.Size(100, 25);
        this.button1.TabIndex = 2;
        this.button1.Text = "Speichern";
        this.button1.UseVisualStyleBackColor = true;
        this.button1.Click += new System.EventHandler(this.button1_Click);
        // 
        // button2
        // 
        this.button2.Location = new System.Drawing.Point(168, 255);
        this.button2.Name = "button2";
        this.button2.Size = new System.Drawing.Size(100, 25);
        this.button2.TabIndex = 3;
        this.button2.Text = "Abbrechen";
        this.button2.UseVisualStyleBackColor = true;
        this.button2.Click += new System.EventHandler(this.button2_Click);
        // 
        // Aufg5
        // 
        this.ClientSize = new System.Drawing.Size(284, 292);
        this.Controls.Add(this.button2);
        this.Controls.Add(this.button1);
        this.Controls.Add(this.label1);
        this.Controls.Add(this.tabControl1);
        this.Name = "Aufg5";
        this.tabControl1.ResumeLayout(false);
        this.tabPage1.ResumeLayout(false);
        this.tabPage2.ResumeLayout(false);
        this.tabPage2.PerformLayout();
        this.ResumeLayout(false);

    }

    private void button2_Click(object sender, System.EventArgs e)
    {
        this.DialogResult = DialogResult.Cancel;
        this.Close();
    }

    private void button1_Click(object sender, System.EventArgs e)
    {
        this.DialogResult = DialogResult.OK;
        this.Close();
    }

    private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
    {
        if (checkBox1.Checked)
        {
            comboBox1.Enabled = true;
        }
        else
        {
            comboBox1.Enabled = false;
        }
    }
}