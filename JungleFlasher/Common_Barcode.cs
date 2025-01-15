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
      this.icontainer_0 = (IContainer) new Container();
      ResourceManager resourceManager = new ResourceManager(typeof (Common_Barcode));
      this.groupBox3 = new GroupBox();
      this.textBox3 = new TextBox();
      this.pictureBox3 = new PictureBox();
      this.button1 = new Button();
      this.button2 = new Button();
      this.toolTip_0 = new ToolTip(this.icontainer_0);
      this.groupBox3.SuspendLayout();
      this.SuspendLayout();
      this.groupBox3.Controls.Add((Control) this.textBox3);
      this.groupBox3.Controls.Add((Control) this.pictureBox3);
      this.groupBox3.FlatStyle = FlatStyle.System;
      Point point1 = new Point();
      point1 = new Point(16, 16);
      this.groupBox3.Location = point1;
      this.groupBox3.Name = "groupBox3";
      Size size1 = new Size();
      size1 = new Size(288, 104);
      this.groupBox3.Size = size1;
      this.groupBox3.TabIndex = 5;
      this.groupBox3.TabStop = false;
      this.groupBox3.Text = "Cover";
      this.textBox3.Font = new Font("Courier New", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Point point2 = new Point();
      point2 = new Point(53, 24);
      this.textBox3.Location = point2;
      this.textBox3.MaxLength = 17;
      this.textBox3.Name = "textBox3";
      Size size2 = new Size();
      size2 = new Size(183, 26);
      this.textBox3.Size = size2;
      this.textBox3.TabIndex = 1;
      this.textBox3.Text = "D608CG73880800348   ";
      this.toolTip_0.SetToolTip((Control) this.textBox3, "Enter 17 digit barcode from drive lid");
      this.pictureBox3.Image = (Image) resourceManager.GetObject("pictureBox3.Image");
      Point point3 = new Point();
      point3 = new Point(14, 56);
      this.pictureBox3.Location = point3;
      this.pictureBox3.Name = "pictureBox3";
      Size size3 = new Size();
      size3 = new Size(260, 40);
      this.pictureBox3.Size = size3;
      this.pictureBox3.TabIndex = 0;
      this.pictureBox3.TabStop = false;
      this.button1.DialogResult = DialogResult.OK;
      this.button1.FlatStyle = FlatStyle.System;
      Point point4 = new Point();
      point4 = new Point(56, 136);
      this.button1.Location = point4;
      this.button1.Name = "button1";
      Size size4 = new Size();
      size4 = new Size(80, 32);
      this.button1.Size = size4;
      this.button1.TabIndex = 2;
      this.button1.Text = "OK";
      this.button2.DialogResult = DialogResult.Cancel;
      this.button2.FlatStyle = FlatStyle.System;
      Point point5 = new Point();
      point5 = new Point(184, 136);
      this.button2.Location = point5;
      this.button2.Name = "button2";
      Size size5 = new Size();
      size5 = new Size(80, 32);
      this.button2.Size = size5;
      this.button2.TabIndex = 3;
      this.button2.Text = "Cancel";
      this.AcceptButton = (IButtonControl) this.button1;
      Size size6 = new Size();
      size6 = new Size(5, 13);
      this.AutoScaleBaseSize = size6;
      this.CancelButton = (IButtonControl) this.button2;
      Size size7 = new Size();
      size7 = new Size(322, 184);
      this.ClientSize = size7;
      this.ControlBox = false;
      this.Controls.Add((Control) this.button2);
      this.Controls.Add((Control) this.button1);
      this.Controls.Add((Control) this.groupBox3);
      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      this.Name = "Common_Barcode";
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "Barcode Search";
      this.groupBox3.ResumeLayout(false);
      this.ResumeLayout(false);
    }

    public unsafe void method_0()
    {
      this.bool_0 = false;
      string s = Convert.ToString(this.textBox3.Text);
      if (this.textBox3.TextLength != 17)
      {
        // ISSUE: cast to a function pointer type
        \u003CModule\u003E.pGstruct14_5 = \u003CModule\u003E.SetWindowsHookExA(5, (__FnPtr<int (int, uint, int)>) (IntPtr) \u003CModule\u003E.ppInt_1, (GStruct81*) 0, \u003CModule\u003E.GetCurrentThreadId());
        int num = (int) MessageBox.Show("Cover Barcode must be 17 chars" + "\n" + "e.g. [D608CG833907010F0]", "Case Barcode", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        \u003CModule\u003E.UnhookWindowsHookEx(\u003CModule\u003E.pGstruct14_5);
      }
      else
      {
        byte* pByte_1 = (byte*) (void*) Marshal.StringToHGlobalAnsi(s);
        Struct17 struct17;
        \u003CModule\u003E.memset((void*) &struct17, 0, 17U);
        if (this.method_3(pByte_1, 17U) != 0)
        {
          // ISSUE: cast to a function pointer type
          \u003CModule\u003E.pGstruct14_5 = \u003CModule\u003E.SetWindowsHookExA(5, (__FnPtr<int (int, uint, int)>) (IntPtr) \u003CModule\u003E.ppInt_1, (GStruct81*) 0, \u003CModule\u003E.GetCurrentThreadId());
          int num = (int) MessageBox.Show("Cover Barcode must be 17 chars" + "\n" + "e.g. [D608CG833907010F0]", "Case Barcode", MessageBoxButtons.OK, MessageBoxIcon.Hand);
          \u003CModule\u003E.UnhookWindowsHookEx(\u003CModule\u003E.pGstruct14_5);
        }
        else
        {
          \u003CModule\u003E.memcpy((void*) this.pByte_0, (void*) pByte_1, 17U);
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
          \u003CModule\u003E.sprintf((sbyte*) &struct20, (sbyte*) &\u003CModule\u003E.struct18_0, __arglist ((int) pByte_1[(int) index]));
          string str2 = new string((sbyte*) &\u003CModule\u003E.struct19_0) + new string((sbyte*) &struct20);
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
