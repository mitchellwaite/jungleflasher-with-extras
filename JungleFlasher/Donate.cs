// Type: ns0.Donate
// Assembly: JungleFlasher, Version=1.0.5004.40451, Culture=neutral, PublicKeyToken=7240d12d147b2b97
// MVID: 86B778B8-1293-454B-A759-8F0EBE32074A
// Assembly location: C:\Documents and Settings\User\Desktop\JungleFlasher-cleaned.exe

using System.ComponentModel;
using System.Drawing;
using System.Resources;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ns0
{
  public class Donate : Form
  {
    private PictureBox pictureBox1;
    private Button button1;
    private Button button2;
    private Label label10;
    private Label label11;
    private Label label1;
    private Label label2;
    private Label label3;
    private Container container_0;

    public Donate()
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
      ResourceManager resourceManager = new ResourceManager(typeof (Donate));
      this.pictureBox1 = new PictureBox();
      this.button1 = new Button();
      this.button2 = new Button();
      this.label10 = new Label();
      this.label11 = new Label();
      this.label1 = new Label();
      this.label2 = new Label();
      this.label3 = new Label();
      this.SuspendLayout();
      this.pictureBox1.Image = (Image) resourceManager.GetObject("pictureBox1.Image");
      Point point1 = new Point();
      point1 = new Point(16, 16);
      this.pictureBox1.Location = point1;
      this.pictureBox1.Name = "pictureBox1";
      Size size1 = new Size();
      size1 = new Size(60, 38);
      this.pictureBox1.Size = size1;
      this.pictureBox1.TabIndex = 0;
      this.pictureBox1.TabStop = false;
      this.button1.DialogResult = DialogResult.OK;
      this.button1.FlatStyle = FlatStyle.System;
      Point point2 = new Point();
      point2 = new Point(136, 104);
      this.button1.Location = point2;
      this.button1.Name = "button1";
      Size size2 = new Size();
      size2 = new Size(72, 24);
      this.button1.Size = size2;
      this.button1.TabIndex = 1;
      this.button1.Text = "Yes";
      this.button2.DialogResult = DialogResult.Cancel;
      this.button2.FlatStyle = FlatStyle.System;
      Point point3 = new Point();
      point3 = new Point(224, 104);
      this.button2.Location = point3;
      this.button2.Name = "button2";
      Size size3 = new Size();
      size3 = new Size(72, 24);
      this.button2.Size = size3;
      this.button2.TabIndex = 2;
      this.button2.Text = "No";
      Point point4 = new Point();
      point4 = new Point(104, 16);
      this.label10.Location = point4;
      this.label10.Name = "label10";
      Size size4 = new Size();
      size4 = new Size(320, 16);
      this.label10.Size = size4;
      this.label10.TabIndex = 5;
      this.label10.Text = "As a heavy user of JungleFlasher, Maybe you would";
      Point point5 = new Point();
      point5 = new Point(104, 32);
      this.label11.Location = point5;
      this.label11.Name = "label11";
      Size size5 = new Size();
      size5 = new Size(320, 16);
      this.label11.Size = size5;
      this.label11.TabIndex = 6;
      this.label11.Text = "consider a donation to the dev Team, as a sign of";
      Point point6 = new Point();
      point6 = new Point(104, 48);
      this.label1.Location = point6;
      this.label1.Name = "label1";
      Size size6 = new Size();
      size6 = new Size(320, 16);
      this.label1.Size = size6;
      this.label1.TabIndex = 7;
      this.label1.Text = "appreciation and recognition of all the hard work and";
      Point point7 = new Point();
      point7 = new Point(104, 64);
      this.label2.Location = point7;
      this.label2.Name = "label2";
      Size size7 = new Size();
      size7 = new Size(320, 16);
      this.label2.Size = size7;
      this.label2.TabIndex = 8;
      this.label2.Text = "dedication that goes into developing such a full";
      Point point8 = new Point();
      point8 = new Point(104, 80);
      this.label3.Location = point8;
      this.label3.Name = "label3";
      Size size8 = new Size();
      size8 = new Size(320, 16);
      this.label3.Size = size8;
      this.label3.TabIndex = 9;
      this.label3.Text = "featured application.";
      this.AcceptButton = (IButtonControl) this.button1;
      Size size9 = new Size();
      size9 = new Size(5, 13);
      this.AutoScaleBaseSize = size9;
      this.CancelButton = (IButtonControl) this.button2;
      Size size10 = new Size();
      size10 = new Size(434, 144);
      this.ClientSize = size10;
      this.ControlBox = false;
      this.Controls.Add((Control) this.label3);
      this.Controls.Add((Control) this.label2);
      this.Controls.Add((Control) this.label1);
      this.Controls.Add((Control) this.button2);
      this.Controls.Add((Control) this.button1);
      this.Controls.Add((Control) this.pictureBox1);
      this.Controls.Add((Control) this.label10);
      this.Controls.Add((Control) this.label11);
      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      this.Icon = (Icon) resourceManager.GetObject("$this.Icon");
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "Donate";
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "Donate";
      this.ResumeLayout(false);
    }
  }
}
