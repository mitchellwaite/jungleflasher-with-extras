// Type: ns0.Welcome
// Assembly: JungleFlasher, Version=1.0.5004.40451, Culture=neutral, PublicKeyToken=7240d12d147b2b97
// MVID: 86B778B8-1293-454B-A759-8F0EBE32074A
// Assembly location: C:\Documents and Settings\User\Desktop\JungleFlasher-cleaned.exe

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Resources;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ns0
{
  public class Welcome : Form
  {
    private static Timer timer_0 = new Timer();
    private Label label1;
    private LinkLabel linkLabel2;
    private GroupBox groupBox1;
    private PictureBox pictureBox1;
    private Container container_0;

    static Welcome()
    {
    }

    public Welcome()
    {
      this.InitializeComponent();
    }

    protected override void Dispose([MarshalAs(UnmanagedType.U1)] bool disposing)
    {
      if (disposing && this.container_0 != null)
        this.container_0.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ResourceManager resourceManager = new ResourceManager(typeof (Welcome));
      this.label1 = new Label();
      this.linkLabel2 = new LinkLabel();
      this.groupBox1 = new GroupBox();
      this.pictureBox1 = new PictureBox();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      this.label1.BackColor = SystemColors.Control;
      this.label1.Font = new Font("Microsoft Sans Serif", 15.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label1.ForeColor = SystemColors.ControlText;
      Point point1 = new Point();
      point1 = new Point(69, 24);
      this.label1.Location = point1;
      this.label1.Name = "label1";
      Size size1 = new Size();
      size1 = new Size(242, 40);
      this.label1.Size = size1;
      this.label1.TabIndex = 1;
      this.label1.Text = "JungleFlasher 0.1.96 b";
      this.label1.TextAlign = ContentAlignment.MiddleCenter;
      this.linkLabel2.BackColor = Color.Transparent;
      this.linkLabel2.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Point point2 = new Point();
      point2 = new Point(18, 80);
      this.linkLabel2.Location = point2;
      this.linkLabel2.Name = "linkLabel2";
      Size size2 = new Size();
      size2 = new Size(344, 16);
      this.linkLabel2.Size = size2;
      this.linkLabel2.TabIndex = 5;
      this.linkLabel2.TabStop = true;
      this.linkLabel2.Text = "For Support join #JungleFlasher on EFnet";
      this.linkLabel2.TextAlign = ContentAlignment.MiddleCenter;
      this.linkLabel2.LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
      this.groupBox1.Controls.Add((Control) this.pictureBox1);
      Point point3 = new Point();
      point3 = new Point(3, -2);
      this.groupBox1.Location = point3;
      this.groupBox1.Name = "groupBox1";
      Size size3 = new Size();
      size3 = new Size(375, 128);
      this.groupBox1.Size = size3;
      this.groupBox1.TabIndex = 6;
      this.groupBox1.TabStop = false;
      this.pictureBox1.Image = (Image) resourceManager.GetObject("pictureBox1.Image");
      Point point4 = new Point();
      point4 = new Point(320, 32);
      this.pictureBox1.Location = point4;
      this.pictureBox1.Name = "pictureBox1";
      Size size4 = new Size();
      size4 = new Size(32, 32);
      this.pictureBox1.Size = size4;
      this.pictureBox1.TabIndex = 0;
      this.pictureBox1.TabStop = false;
      Size size5 = new Size();
      size5 = new Size(5, 13);
      this.AutoScaleBaseSize = size5;
      this.BackColor = SystemColors.Control;
      Size size6 = new Size();
      size6 = new Size(380, 128);
      this.ClientSize = size6;
      this.ControlBox = false;
      this.Controls.Add((Control) this.linkLabel2);
      this.Controls.Add((Control) this.label1);
      this.Controls.Add((Control) this.groupBox1);
      this.FormBorderStyle = FormBorderStyle.None;
      this.Icon = (Icon) resourceManager.GetObject("$this.Icon");
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "Welcome";
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "Welcome";
      this.Load += new EventHandler(this.Welcome_Load);
      this.groupBox1.ResumeLayout(false);
      this.ResumeLayout(false);
    }

    private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      this.method_0();
    }

    private void method_0()
    {
      this.linkLabel2.LinkVisited = true;
      Process.Start("irc://irc.efnet.org/JungleFlasher");
    }

    private void Welcome_Load(object sender, EventArgs e)
    {
      Welcome.timer_0.Tick += new EventHandler(this.method_1);
      Welcome.timer_0.Interval = 4000;
      Welcome.timer_0.Start();
    }

    private void method_1(object sender, EventArgs e)
    {
      Welcome.timer_0.Stop();
      this.Close();
    }
  }
}
