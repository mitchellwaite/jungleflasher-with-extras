// Type: ns0.ProjectName
// Assembly: JungleFlasher, Version=1.0.5004.40451, Culture=neutral, PublicKeyToken=7240d12d147b2b97
// MVID: 86B778B8-1293-454B-A759-8F0EBE32074A
// Assembly location: C:\Documents and Settings\User\Desktop\JungleFlasher-cleaned.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Resources;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ns0
{
  public class ProjectName : Form
  {
    private Button button3;
    private Button button1;
    public TextBox textBox1;
    private Container container_0;

    public ProjectName()
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
      ResourceManager resourceManager = new ResourceManager(typeof (ProjectName));
      this.button3 = new Button();
      this.button1 = new Button();
      this.textBox1 = new TextBox();
      this.SuspendLayout();
      this.button3.DialogResult = DialogResult.Cancel;
      this.button3.FlatStyle = FlatStyle.System;
      Point point1 = new Point();
      point1 = new Point(32, 48);
      this.button3.Location = point1;
      this.button3.Name = "button3";
      Size size1 = new Size();
      size1 = new Size(80, 24);
      this.button3.Size = size1;
      this.button3.TabIndex = 3;
      this.button3.Text = "Cancel";
      this.button1.DialogResult = DialogResult.OK;
      this.button1.FlatStyle = FlatStyle.System;
      Point point2 = new Point();
      point2 = new Point(128, 48);
      this.button1.Location = point2;
      this.button1.Name = "button1";
      Size size2 = new Size();
      size2 = new Size(80, 24);
      this.button1.Size = size2;
      this.button1.TabIndex = 2;
      this.button1.Text = "OK";
      Point point3 = new Point();
      point3 = new Point(24, 16);
      this.textBox1.Location = point3;
      this.textBox1.Name = "textBox1";
      Size size3 = new Size();
      size3 = new Size(192, 20);
      this.textBox1.Size = size3;
      this.textBox1.TabIndex = 1;
      this.textBox1.Text = "";
      this.AcceptButton = (IButtonControl) this.button1;
      Size size4 = new Size();
      size4 = new Size(5, 13);
      this.AutoScaleBaseSize = size4;
      this.CancelButton = (IButtonControl) this.button3;
      Size size5 = new Size();
      size5 = new Size(242, 88);
      this.ClientSize = size5;
      this.ControlBox = false;
      this.Controls.Add((Control) this.textBox1);
      this.Controls.Add((Control) this.button3);
      this.Controls.Add((Control) this.button1);
      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      this.Icon = (Icon) resourceManager.GetObject("$this.Icon");
      this.Name = "ProjectName";
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "Enter Job Name";
      this.Load += new EventHandler(this.ProjectName_Load);
      this.ResumeLayout(false);
    }

    private void ProjectName_Load(object sender, EventArgs e)
    {
    }
  }
}
