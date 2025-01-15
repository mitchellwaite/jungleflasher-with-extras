// Type: ns0.WorkingFolder
// Assembly: JungleFlasher, Version=1.0.5004.40451, Culture=neutral, PublicKeyToken=7240d12d147b2b97
// MVID: 86B778B8-1293-454B-A759-8F0EBE32074A
// Assembly location: C:\Documents and Settings\User\Desktop\JungleFlasher-cleaned.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Resources;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ns0
{
  public class WorkingFolder : Form
  {
    private Button button3;
    private Button button1;
    public TextBox textBox8;
    private Button button4;
    private Container container_0;

    public WorkingFolder()
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
      ResourceManager resourceManager = new ResourceManager(typeof (WorkingFolder));
      this.button3 = new Button();
      this.button1 = new Button();
      this.textBox8 = new TextBox();
      this.button4 = new Button();
      this.SuspendLayout();
      this.button3.DialogResult = DialogResult.Cancel;
      this.button3.FlatStyle = FlatStyle.System;
      Point point1 = new Point();
      point1 = new Point(101, 56);
      this.button3.Location = point1;
      this.button3.Name = "button3";
      Size size1 = new Size();
      size1 = new Size(80, 24);
      this.button3.Size = size1;
      this.button3.TabIndex = 6;
      this.button3.Text = "Cancel";
      this.button1.DialogResult = DialogResult.OK;
      this.button1.FlatStyle = FlatStyle.System;
      Point point2 = new Point();
      point2 = new Point(205, 56);
      this.button1.Location = point2;
      this.button1.Name = "button1";
      Size size2 = new Size();
      size2 = new Size(80, 24);
      this.button1.Size = size2;
      this.button1.TabIndex = 5;
      this.button1.Text = "OK";
      Point point3 = new Point();
      point3 = new Point(64, 16);
      this.textBox8.Location = point3;
      this.textBox8.Name = "textBox8";
      Size size3 = new Size();
      size3 = new Size(304, 20);
      this.textBox8.Size = size3;
      this.textBox8.TabIndex = 28;
      this.textBox8.Text = "";
      this.button4.FlatStyle = FlatStyle.System;
      Point point4 = new Point();
      point4 = new Point(16, 16);
      this.button4.Location = point4;
      this.button4.Name = "button4";
      Size size4 = new Size();
      size4 = new Size(36, 20);
      this.button4.Size = size4;
      this.button4.TabIndex = 27;
      this.button4.Text = "...";
      this.button4.Click += new EventHandler(this.button4_Click);
      Size size5 = new Size();
      size5 = new Size(5, 13);
      this.AutoScaleBaseSize = size5;
      Size size6 = new Size();
      size6 = new Size(386, 94);
      this.ClientSize = size6;
      this.ControlBox = false;
      this.Controls.Add((Control) this.textBox8);
      this.Controls.Add((Control) this.button4);
      this.Controls.Add((Control) this.button3);
      this.Controls.Add((Control) this.button1);
      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      this.Icon = (Icon) resourceManager.GetObject("$this.Icon");
      this.Name = "WorkingFolder";
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "Set Working Folder";
      this.Load += new EventHandler(this.WorkingFolder_Load);
      this.ResumeLayout(false);
    }

    private void button4_Click(object sender, EventArgs e)
    {
      FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
      folderBrowserDialog.SelectedPath = this.textBox8.Text;
      if (folderBrowserDialog.ShowDialog() != DialogResult.OK)
        return;
      this.textBox8.Text = Path.GetFullPath(folderBrowserDialog.SelectedPath) + "\\";
    }

    private void WorkingFolder_Load(object sender, EventArgs e)
    {
    }
  }
}
