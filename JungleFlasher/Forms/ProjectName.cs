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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectName));
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button3.Location = new System.Drawing.Point(32, 48);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 24);
            this.button3.TabIndex = 3;
            this.button3.Text = "Cancel";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(128, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 24);
            this.button1.TabIndex = 2;
            this.button1.Text = "OK";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(24, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(192, 20);
            this.textBox1.TabIndex = 1;
            // 
            // ProjectName
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.CancelButton = this.button3;
            this.ClientSize = new System.Drawing.Size(242, 88);
            this.ControlBox = false;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProjectName";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Enter Job Name";
            this.Load += new System.EventHandler(this.ProjectName_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    private void ProjectName_Load(object sender, EventArgs e)
    {
    }
  }
}
