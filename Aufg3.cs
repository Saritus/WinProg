using System;
using System.Windows.Forms;
using System.Drawing;

public class Aufg3 : Form
{
    private GroupBox group_input;
    private GroupBox group_ausgabe;
    private Label label1;
    private TextBox textBox2;
    private Label label2;
    private TextBox textBox1;
    private ComboBox comboBox1;
    private Label label3;
    private GroupBox groupBox1;
    private RadioButton radioButton5;
    private RadioButton radioButton4;
    private RadioButton radioButton3;
    private RadioButton radioButton2;
    private RadioButton radioButton1;
    private GroupBox groupBox2;
    private RadioButton radioButton6;
    private RadioButton radioButton7;
    private RadioButton radioButton8;
    private RadioButton radioButton9;
    private RadioButton radioButton10;
    private Label label5;
    private Label label4;
    private Label label6;
    private HScrollBar hScrollBar1;
    private Label label7;
    private Label label8;
    private Label label9;
    private Label label12;
    private Label label11;
    private Label label10;
    private System.ComponentModel.IContainer components;

    public Aufg3()
    {
        Text = "Aufgabe 3";
        Size = new Size(500, 500);
        CenterToScreen();
        InitializeComponent();
        this.hScrollBar1.Maximum = 100 + hScrollBar1.LargeChange - 1;
    }

    private void InitializeComponent()
    {
            this.group_input = new System.Windows.Forms.GroupBox();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.group_ausgabe = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.group_input.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.group_ausgabe.SuspendLayout();
            this.SuspendLayout();
            // 
            // group_input
            // 
            this.group_input.Controls.Add(this.hScrollBar1);
            this.group_input.Controls.Add(this.label6);
            this.group_input.Controls.Add(this.label5);
            this.group_input.Controls.Add(this.label4);
            this.group_input.Controls.Add(this.groupBox2);
            this.group_input.Controls.Add(this.groupBox1);
            this.group_input.Controls.Add(this.comboBox1);
            this.group_input.Controls.Add(this.label3);
            this.group_input.Controls.Add(this.textBox2);
            this.group_input.Controls.Add(this.label2);
            this.group_input.Controls.Add(this.textBox1);
            this.group_input.Controls.Add(this.label1);
            this.group_input.Location = new System.Drawing.Point(12, 12);
            this.group_input.Name = "group_input";
            this.group_input.Size = new System.Drawing.Size(350, 300);
            this.group_input.TabIndex = 2;
            this.group_input.TabStop = false;
            this.group_input.Text = "Eingabe";
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(144, 248);
            
            //this.hScrollBar1.Maximum = 109;
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(200, 20);
            this.hScrollBar1.TabIndex = 17;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(6, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 30);
            this.label6.TabIndex = 15;
            this.label6.Text = "Engagement:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(6, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 30);
            this.label5.TabIndex = 14;
            this.label5.Text = "Belegnote:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 30);
            this.label4.TabIndex = 13;
            this.label4.Text = "Note:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox2.Controls.Add(this.radioButton6);
            this.groupBox2.Controls.Add(this.radioButton7);
            this.groupBox2.Controls.Add(this.radioButton8);
            this.groupBox2.Controls.Add(this.radioButton9);
            this.groupBox2.Controls.Add(this.radioButton10);
            this.groupBox2.Location = new System.Drawing.Point(159, 200);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(185, 30);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(151, 9);
            this.radioButton6.Margin = new System.Windows.Forms.Padding(0);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(31, 17);
            this.radioButton6.TabIndex = 10;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "5";
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.CheckedChanged += new System.EventHandler(this.belegnote_changed);
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(114, 9);
            this.radioButton7.Margin = new System.Windows.Forms.Padding(0);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(31, 17);
            this.radioButton7.TabIndex = 9;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "4";
            this.radioButton7.UseVisualStyleBackColor = true;
            this.radioButton7.CheckedChanged += new System.EventHandler(this.belegnote_changed);
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(77, 9);
            this.radioButton8.Margin = new System.Windows.Forms.Padding(0);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(31, 17);
            this.radioButton8.TabIndex = 8;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "3";
            this.radioButton8.UseVisualStyleBackColor = true;
            this.radioButton8.CheckedChanged += new System.EventHandler(this.belegnote_changed);
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Location = new System.Drawing.Point(40, 9);
            this.radioButton9.Margin = new System.Windows.Forms.Padding(0);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(31, 17);
            this.radioButton9.TabIndex = 7;
            this.radioButton9.TabStop = true;
            this.radioButton9.Text = "2";
            this.radioButton9.UseVisualStyleBackColor = true;
            this.radioButton9.CheckedChanged += new System.EventHandler(this.belegnote_changed);
            // 
            // radioButton10
            // 
            this.radioButton10.AutoSize = true;
            this.radioButton10.Location = new System.Drawing.Point(3, 9);
            this.radioButton10.Margin = new System.Windows.Forms.Padding(0);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(31, 17);
            this.radioButton10.TabIndex = 6;
            this.radioButton10.TabStop = true;
            this.radioButton10.Text = "1";
            this.radioButton10.UseVisualStyleBackColor = true;
            this.radioButton10.CheckedChanged += new System.EventHandler(this.belegnote_changed);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.radioButton5);
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(159, 160);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(185, 30);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(151, 9);
            this.radioButton5.Margin = new System.Windows.Forms.Padding(0);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(31, 17);
            this.radioButton5.TabIndex = 10;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "5";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.note_changed);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(114, 9);
            this.radioButton4.Margin = new System.Windows.Forms.Padding(0);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(31, 17);
            this.radioButton4.TabIndex = 9;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "4";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.note_changed);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(77, 9);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(0);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(31, 17);
            this.radioButton3.TabIndex = 8;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "3";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.note_changed);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(40, 9);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(0);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(31, 17);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "2";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.note_changed);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(3, 9);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(0);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(31, 17);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "1";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.note_changed);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(144, 126);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 21);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.Items.Add("Windowsprogrammierung");
            this.comboBox1.Items.Add("Entwicklungswerkzeuge für Multimediasysteme");
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fach:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(144, 86);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Matrikelnummer:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(144, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // group_ausgabe
            // 
            this.group_ausgabe.Controls.Add(this.label12);
            this.group_ausgabe.Controls.Add(this.label11);
            this.group_ausgabe.Controls.Add(this.label10);
            this.group_ausgabe.Controls.Add(this.label9);
            this.group_ausgabe.Controls.Add(this.label8);
            this.group_ausgabe.Controls.Add(this.label7);
            this.group_ausgabe.Location = new System.Drawing.Point(368, 12);
            this.group_ausgabe.Name = "group_ausgabe";
            this.group_ausgabe.Size = new System.Drawing.Size(350, 300);
            this.group_ausgabe.TabIndex = 3;
            this.group_ausgabe.TabStop = false;
            this.group_ausgabe.Text = "Ausgabe";
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(6, 240);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(338, 30);
            this.label12.TabIndex = 5;
            this.label12.Text = "Engagement:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(6, 202);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(338, 30);
            this.label11.TabIndex = 4;
            this.label11.Text = "Belegnote:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(6, 162);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(338, 30);
            this.label10.TabIndex = 3;
            this.label10.Text = "Note:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(6, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(338, 30);
            this.label9.TabIndex = 2;
            this.label9.Text = "Fach:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(6, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(338, 30);
            this.label8.TabIndex = 1;
            this.label8.Text = "Matrikelnummer:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(6, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(338, 30);
            this.label7.TabIndex = 0;
            this.label7.Text = "Name:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Aufg3
            // 
            this.ClientSize = new System.Drawing.Size(736, 326);
            this.Controls.Add(this.group_ausgabe);
            this.Controls.Add(this.group_input);
            this.Name = "Aufg3";
            this.group_input.ResumeLayout(false);
            this.group_input.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.group_ausgabe.ResumeLayout(false);
            this.ResumeLayout(false);

    }

    private void textBox1_TextChanged(object sender, System.EventArgs e)
    {
        label7.Text = "Name: " + textBox1.Text;
    }

    private void textBox2_TextChanged(object sender, System.EventArgs e)
    {
        label8.Text = "Matrikelnummer: " + textBox2.Text;
    }

    private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
    {
        label9.Text = "Fach: " + comboBox1.Text;
    }

    private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
    {
        label12.Text = "Engagement: " + hScrollBar1.Value;
        if (hScrollBar1.Value > 90)
            radioButton5.Enabled = false;
        else
            radioButton5.Enabled = true;

    }

    private void note_changed(object sender, System.EventArgs e)
    {
        label10.Text = "Note: " + ((RadioButton) sender).Text;
    }

    private void belegnote_changed(object sender, System.EventArgs e)
    {
        label11.Text = "Belegnote: " + ((RadioButton)sender).Text;
    }

}