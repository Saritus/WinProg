using System;
using System.Drawing;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Collections;


class Aufg9_Server : Form
{
    Socket s, sc;
    ArrayList al;
    bool end = false;
    int i;
    const int BufferSize = 256;
    private TextBox textBox1;
    private TextBox textBox2;
    private Button button1;            // Size of buffer.
    byte[] buffer = new byte[BufferSize];  // buffer.

    public Aufg9_Server()
    {
        Text = "Sockets - der Server";
        i = 0;
        al = new ArrayList();
        //Connect-Menu
        MenuItem miConnect = new MenuItem("&Start Server ...",
            new EventHandler(MenuStartServer), Shortcut.Ctrl1);
        MenuItem miDisconnect = new MenuItem("&Disconnect",
            new EventHandler(MenuDisconnect), Shortcut.Ctrl2);
        MenuItem miDash = new MenuItem("-");
        MenuItem miExit = new MenuItem("E&xit",
            new EventHandler(MenuExit));
        MenuItem miServer = new MenuItem("&Server",
            new MenuItem[] { miConnect, miDisconnect, miDash, miExit });

        // Send-Menu
        MenuItem miSend = new MenuItem("&Send String ...",
            new EventHandler(MenuSend), Shortcut.Ctrl3);
        MenuItem miData = new MenuItem("&Data",
            new MenuItem[] { miSend });

        // Main-Menu
        Menu = new MainMenu(new MenuItem[] { miServer, miData });

        InitializeComponent();
    }
    void MenuStartServer(object obj, EventArgs ea)
    {
        //Creates the Socket for sending data over TCP.
        s = new Socket(AddressFamily.InterNetwork, SocketType.Stream,
                       ProtocolType.Tcp);
        IPAddress hostadd = Dns.Resolve("localhost").AddressList[0];
        IPEndPoint EPhost = new IPEndPoint(hostadd, 20000);
        try
        {
            s.Bind(EPhost);
            s.Listen(10); // Allows a queue of 10 connections.
            s.BeginAccept(new AsyncCallback(acceptCallback), s);
        }
        catch (Exception e)
        {
            Text = (e.ToString());
            return;
        }
        Text = "waiting for connection";
    }
    public void acceptCallback(IAsyncResult ar)
    {
        if (!end)
        {
            Socket listener = (Socket)ar.AsyncState;
            Socket sc = listener.EndAccept(ar);  // Create the state object.
            al.Add(sc);
            listener.BeginAccept(new AsyncCallback(acceptCallback), listener);
            sc.BeginReceive(buffer, 0, buffer.Length, 0,
                                  new AsyncCallback(ReadCallback), sc);

            this.Invoke((MethodInvoker)delegate
            {
                this.Text = String.Format("Client {0} connected", al.Count);
            });
        }
    }
    public void ReadCallback(IAsyncResult ar)
    {
        sc = (Socket)ar.AsyncState;
        try
        {
            // Read data from the client socket.
            int bytesRead = sc.EndReceive(ar);
            if (bytesRead > 0)// There  might be more data, so store  the data received so far.
                this.Invoke((MethodInvoker)delegate
                {
                    textBox1.Text += Encoding.ASCII.GetString(buffer, 0, bytesRead);
                    if (!textBox1.Text.EndsWith("\r\n"))
                    {
                        textBox1.Text += "\r\n";
                    }
                });
            sc.BeginReceive(buffer, 0, BufferSize, 0,
                                  new AsyncCallback(ReadCallback), sc);
        }
        catch (Exception e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                Text = "Client disconnected";
            });
            al.Remove(sc); sc.Close();
        }
    }
    void MenuDisconnect(object obj, EventArgs ea)
    {
        end = true;
        for (int l = 0; l < al.Count; l++)
            ((Socket)al[l]).Close();
        s.Close();
        if (!s.Connected)
            Text = "disconnected";
    }
    void MenuSend(object obj, EventArgs ea)
    {
        String str = String.Format("Server: " + this.textBox2.Text, ++i);
        byte[] byteData = Encoding.ASCII.GetBytes(str);
        for (int l = 0; l < al.Count; l++)
            ((Socket)al[l]).BeginSend(byteData, 0, byteData.Length, SocketFlags.None,
              new AsyncCallback(SendCallback), al[l]);
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
            Socket client = (Socket)ar.AsyncState;
            int bytesSent = client.EndSend(ar); // Complete sending 
            // Signal that all bytes have been sent.
            this.Invoke((MethodInvoker)delegate
            {
                Text = String.Format("Sent {0} bytes to client.", bytesSent);
            });
        }
        catch (Exception e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                Text = e.ToString();
            });
        }
    }
    void MenuExit(object obj, EventArgs ea)
    {
        Close();
    }

    private void InitializeComponent()
    {
        this.textBox1 = new System.Windows.Forms.TextBox();
        this.textBox2 = new System.Windows.Forms.TextBox();
        this.button1 = new System.Windows.Forms.Button();
        this.SuspendLayout();
        // 
        // textBox1
        // 
        this.textBox1.Enabled = false;
        this.textBox1.Location = new System.Drawing.Point(12, 12);
        this.textBox1.Multiline = true;
        this.textBox1.Name = "textBox1";
        this.textBox1.Size = new System.Drawing.Size(560, 300);
        this.textBox1.TabIndex = 0;
        // 
        // textBox2
        // 
        this.textBox2.Location = new System.Drawing.Point(12, 318);
        this.textBox2.Multiline = true;
        this.textBox2.Name = "textBox2";
        this.textBox2.Size = new System.Drawing.Size(479, 20);
        this.textBox2.TabIndex = 1;
        this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
        // 
        // button1
        // 
        this.button1.Location = new System.Drawing.Point(497, 318);
        this.button1.Name = "button1";
        this.button1.Size = new System.Drawing.Size(75, 20);
        this.button1.TabIndex = 2;
        this.button1.Text = "Senden";
        this.button1.UseVisualStyleBackColor = true;
        this.button1.Click += new System.EventHandler(this.button1_Click);
        // 
        // Aufg9_Server
        // 
        this.ClientSize = new System.Drawing.Size(584, 351);
        this.Controls.Add(this.button1);
        this.Controls.Add(this.textBox2);
        this.Controls.Add(this.textBox1);
        this.Name = "Aufg9_Server";
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
            this.textBox2.Text = "";
        }
        textBox2.Focus();
    }

    private void textBox2_TextChanged(object sender, EventArgs e)
    {
        if (((TextBox)sender).Text.EndsWith("\r\n"))
        {
            button1_Click(sender, e);
        }
    }
}