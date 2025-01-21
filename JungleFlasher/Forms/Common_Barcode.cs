// Type: ns0.Common_Barcode
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
  public class Common_Barcode : Form
  {
    private GroupBox groupBox3;
    private PictureBox pictureBox3;
    public TextBox textBox3;
    private Button button1;
    private Button button2;
    private ToolTip toolTip_0;
    private IContainer icontainer_0;
    public unsafe byte* pByte_0;
        private IContainer components;
        public bool bool_0;

    public Common_Barcode()
    {
      this.InitializeComponent();
    }

    protected override void Dispose([MarshalAs(UnmanagedType.U1)] bool disposing)
    {
      if (disposing && this.icontainer_0 != null)
        this.icontainer_0.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Common_Barcode));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.toolTip_0 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox3);
            this.groupBox3.Controls.Add(this.pictureBox3);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox3.Location = new System.Drawing.Point(16, 16);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(288, 104);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cover";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(53, 24);
            this.textBox3.MaxLength = 17;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(183, 26);
            this.textBox3.TabIndex = 1;
            this.textBox3.Text = "D608CG73880800348   ";
            this.toolTip_0.SetToolTip(this.textBox3, "Enter 17 digit barcode from drive lid");
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(14, 56);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(260, 40);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(56, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 32);
            this.button1.TabIndex = 2;
            this.button1.Text = "OK";
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Location = new System.Drawing.Point(184, 136);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 32);
            this.button2.TabIndex = 3;
            this.button2.Text = "Cancel";
            // 
            // Common_Barcode
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(322, 184);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Common_Barcode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Barcode Search";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

    }

    public unsafe void method_0()
    {
      this.bool_0 = false;
      string s = Convert.ToString(this.textBox3.Text);
      if (this.textBox3.TextLength != 17)
      {
        // ISSUE: cast to a function pointer type
        _Module.pGstruct14_5 = _Module.SetWindowsHookExA(5, (__FnPtr<int (int, uint, int)>) (IntPtr) _Module.ppInt_1, (GStruct81*) 0, _Module.GetCurrentThreadId());
        int num = (int) MessageBox.Show("Cover Barcode must be 17 chars" + "\n" + "e.g. [D608CG833907010F0]", "Case Barcode", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        _Module.UnhookWindowsHookEx(_Module.pGstruct14_5);
      }
      else
      {
        byte* pByte_1 = (byte*) (void*) Marshal.StringToHGlobalAnsi(s);
        Struct17 struct17;
        _Module.memset((void*) &struct17, 0, 17U);
        if (this.method_3(pByte_1, 17U) != 0)
        {
          // ISSUE: cast to a function pointer type
          _Module.pGstruct14_5 = _Module.SetWindowsHookExA(5, (__FnPtr<int (int, uint, int)>) (IntPtr) _Module.ppInt_1, (GStruct81*) 0, _Module.GetCurrentThreadId());
          int num = (int) MessageBox.Show("Cover Barcode must be 17 chars" + "\n" + "e.g. [D608CG833907010F0]", "Case Barcode", MessageBoxButtons.OK, MessageBoxIcon.Hand);
          _Module.UnhookWindowsHookEx(_Module.pGstruct14_5);
        }
        else
        {
          _Module.memcpy((void*) this.pByte_0, (void*) pByte_1, 17U);
          this.button1.Enabled = false;
          this.textBox3.Clear();
          this.textBox3.Text = this.method_2(this.pByte_0, 20U);
          this.bool_0 = true;
          this.method_1();
        }
      }
    }

    public void method_1()
    {
      if (this.bool_0)
        this.button1.Enabled = true;
      else
        this.button1.Enabled = false;
    }

    public unsafe string method_2(byte* pByte_1, uint uint_0)
    {
      string str1 = (string) null;
      for (uint index = 0U; index < uint_0; ++index)
      {
        if ((int) pByte_1[(int) index] >= 32 && (int) pByte_1[(int) index] <= 126)
        {
          if ((int) pByte_1[(int) index] >= 97 && (int) pByte_1[(int) index] <= 122)
            pByte_1[(int) index] = (byte) ((int) pByte_1[(int) index] - 32);
          Struct20 struct20;
          _Module.sprintf((sbyte*) &struct20, (sbyte*) &_Module.struct18_0, __arglist ((int) pByte_1[(int) index]));
          string str2 = new string((sbyte*) &_Module.struct19_0) + new string((sbyte*) &struct20);
          str1 = str1 + str2;
        }
        else
          str1 = str1 + "?";
      }
      return str1;
    }

    public unsafe int method_3(byte* pByte_1, uint uint_0)
    {
      for (uint index = 0U; index < uint_0; ++index)
      {
        if ((int) pByte_1[(int) index] != 32 && ((int) pByte_1[(int) index] < 48 || (int) pByte_1[(int) index] > 57) && (((int) pByte_1[(int) index] < 97 || (int) pByte_1[(int) index] > 122) && ((int) pByte_1[(int) index] < 65 || (int) pByte_1[(int) index] > 90)))
          return 1;
      }
      return 0;
    }
  }
}
