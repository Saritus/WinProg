using System;
using System.Drawing;
using System.Security.AccessControl;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Text;


class Aufg9_Client : Form
{
    Socket s; int i;
    const int BufferSize = 256;
    private Button button1;
    private TextBox textBox2;
    private TextBox textBox1;            // Size of buffer.
    byte[] buffer = new byte[BufferSize];  // read buffer.

    public Aufg9_Client()
    {
        Text = "Sockets - der Client"; i = 0;

        // File-Menu
        MenuItem miConnect = new MenuItem("&Connect...",
            new EventHandler(MenuConnect), Shortcut.Ctrl1);
        MenuItem miDisconnect = new MenuItem("&Disconnect",
            new EventHandler(MenuDisconnect), Shortcut.Ctrl2);
        MenuItem miDash = new MenuItem("-");
        MenuItem miExit = new MenuItem("E&xit",
            new EventHandler(MenuExit));
        MenuItem miClient = new MenuItem("&Client",
            new MenuItem[] { miConnect, miDisconnect, miDash, miExit });

        // Send-Menu
        MenuItem miSend = new MenuItem("&Send String ...",
            new EventHandler(MenuSend), Shortcut.Ctrl3);
        MenuItem miData = new MenuItem("&Data",
            new MenuItem[] { miSend });

        // Main-Menu
        Menu = new MainMenu(new MenuItem[] { miClient, miData });

        InitializeComponent();
    }
    void MenuConnect(object obj, EventArgs ea)
    {
        //Creates the Socket for sending data over TCP.
        s = new Socket(AddressFamily.InterNetwork, SocketType.Stream,
                       ProtocolType.Tcp);
        // create a new IPEndPoint (sockets destination)
        IPAddress hostadd = Dns.Resolve("localhost").AddressList[0];
        IPEndPoint EPhost = new IPEndPoint(hostadd, 20000);
        // Connects to the host using IPEndPoint.
        s.BeginConnect(EPhost, new AsyncCallback(ConnectCallback), s);
    }
    private void ConnectCallback(IAsyncResult ar)
    {
        try
        {
            // Complete connecting to the remote device.
            s.EndConnect(ar);
            // Begin to receive data.
            
            this.Invoke((MethodInvoker)delegate
            {
                Text = String.Format("Connected to {0}", s.RemoteEndPoint.ToString());
            });  
            s.BeginReceive(buffer, 0, buffer.Length, 0,
                                 new AsyncCallback(ReadCallback), ar.AsyncState);
        }
        catch (Exception e)
        {
            MessageBox.Show(e.ToString());
        }
    }
    void MenuDisconnect(object obj, EventArgs ea)
    {
        //s.Shutdown(SocketShutdown.Both); // deaktiviert Senden und Empfangen
        s.Close();
        if (!s.Connected) Text = "disconnected";
    }
    void MenuSend(object obj, EventArgs ea)
    {
        String str = String.Format("Client: " + this.textBox2.Text, ++i);
        byte[] byteData = Encoding.ASCII.GetBytes(str);
        s.BeginSend(byteData, 0, byteData.Length, SocketFlags.None,
            new AsyncCallback(SendCallback), s);
        this.Invoke((MethodInvoker)delegate
        {
            if ((!textBox1.Text.EndsWith("\r\n")) && (textBox1.Text != "")) 
            {
                textBox1.Text += "\r\n";
            }
            this.textBox1.Text += "Ich: " + this.textBox2.Text;
            this.textBox2.Text = "";
        });
    }
    private void SendCallback(IAsyncResult ar)
    {
        try
        {
            // Complete sending the data to the remote device.
            int bytesSent = s.EndSend(ar);
            // Signal that all bytes have been sent.
            this.Invoke((MethodInvoker)delegate
            {
                Text = String.Format("Sent {0} bytes to server.", bytesSent);
            });  
            
        }
        catch (Exception e)
        {
            MessageBox.Show(e.ToString());
        }
    }
    public void ReadCallback(IAsyncResult ar)
    {
        try
        {
            int bytesRead = s.EndReceive(ar);
            if (bytesRead > 0)
            {
                // There  might be more data, so store  the data received so far.
                this.Invoke((MethodInvoker)delegate
                {
                    textBox1.Text += Encoding.ASCII.GetString(buffer, 0, bytesRead);
                    if (!textBox1.Text.EndsWith("\r\n"))
                    {
                        textBox1.Text += "\r\n";
                    }
                }); 
                s.BeginReceive(buffer, 0, buffer.Length, 0,
                                   new AsyncCallback(ReadCallback), s);
            }
        }
        catch (Exception e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                Text = "Client disconnected";
            });  
            
            s.Close();
        }
    }
    void MenuExit(object obj, EventArgs ea)
    {
        Close();
    }

    private void InitializeComponent()
    {
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(497, 318);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 20);
            this.button1.TabIndex = 5;
            this.button1.Text = "Senden";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 318);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(479, 20);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(560, 300);
            this.textBox1.TabIndex = 3;
            // 
            // Aufg9_Client
            // 
            this.ClientSize = new System.Drawing.Size(584, 351);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Aufg9_Client";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    private void button1_Click(object sender, EventArgs e)
    {
        if ((this.textBox2.Text != "") && (textBox2.Text != "\r\n"))
        {
            MenuSend(sender, e);
        }
        else
        {
            this.textBox2.Text="";
        }
        textBox2.Focus();
    }

    private void textBox2_TextChanged(object sender, EventArgs e)
    {
        if (((TextBox) sender).Text.EndsWith("\r\n"))
        {
            button1_Click(sender, e);
        }
    }
}