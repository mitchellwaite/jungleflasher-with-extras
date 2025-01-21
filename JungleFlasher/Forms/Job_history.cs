// Type: ns0.Job_history
// Assembly: JungleFlasher, Version=1.0.5004.40451, Culture=neutral, PublicKeyToken=7240d12d147b2b97
// MVID: 86B778B8-1293-454B-A759-8F0EBE32074A
// Assembly location: C:\Documents and Settings\User\Desktop\JungleFlasher-cleaned.exe

using Microsoft.Win32;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Resources;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ns0
{
  public class Job_history : Form
  {
    private ListBox listBox1;
    private Container container_0;
    public int int_0;

    public Job_history()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Job_history));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Location = new System.Drawing.Point(16, 16);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(264, 173);
            this.listBox1.TabIndex = 0;
            // 
            // Job_history
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(298, 216);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Job_history";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Job History";
            this.Load += new System.EventHandler(this.Job_history_Load);
            this.ResumeLayout(false);

    }

    private unsafe void Job_history_Load(object sender, EventArgs e)
    {
      int num = 1;
      string str = Convert.ToString(this.int_0);
      RegistryKey subKey = Registry.CurrentUser.CreateSubKey("JF_KeyDB\\" + str);
      if (subKey.GetValue(new string((sbyte*) &_Module.struct22_0)) != null)
        this.listBox1.Items.Add((object) ("Created" + "\t\t" + subKey.GetValue(new string((sbyte*) &_Module.struct22_0)).ToString()));
      for (; subKey.GetValue("Date" + Convert.ToString(num)) != null; ++num)
        this.listBox1.Items.Add((object) (Convert.ToString(num) + "\t\t" + subKey.GetValue("Date" + Convert.ToString(num)).ToString()));
      if (string.Compare(subKey.GetValue("Date" + Convert.ToString(num - 1)) == null ? "" : subKey.GetValue("Date" + Convert.ToString(num - 1)).ToString(), subKey.GetValue("Updated") == null ? "x" : subKey.GetValue("Updated").ToString()) == 0)
        this.listBox1.Items.RemoveAt(num - 1);
      if (subKey.GetValue("Updated") == null)
        return;
      this.listBox1.Items.Add((object) ("Last Update" + "\t" + subKey.GetValue("Updated").ToString()));
    }
  }
}
