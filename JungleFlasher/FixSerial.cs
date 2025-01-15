// Type: ns0.FixSerial
// Assembly: JungleFlasher, Version=1.0.5004.40451, Culture=neutral, PublicKeyToken=7240d12d147b2b97
// MVID: 86B778B8-1293-454B-A759-8F0EBE32074A
// Assembly location: C:\Documents and Settings\User\Desktop\JungleFlasher-cleaned.exe

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Resources;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ns0
{
  public class FixSerial : Form
  {
    private PictureBox pictureBox1;
    private TextBox textBox1;
    private GroupBox groupBox1;
    private PictureBox pictureBox2;
    private GroupBox groupBox2;
    private TextBox textBox2;
    private GroupBox groupBox3;
    private PictureBox pictureBox3;
    private TextBox textBox3;
    private TextBox textBox4;
    private GroupBox groupBox4;
    private TextBox textBox5;
    private Button button1;
    private Button button2;
    private ToolTip toolTip_0;
    private IContainer icontainer_0;
    public unsafe byte* pByte_0;
    public unsafe byte* pByte_1;
    public uint uint_0;
    public uint uint_1;
    public uint uint_2;
    public bool bool_0;
    public bool bool_1;
    public bool bool_2;
    public bool bool_3;
    public bool bool_4;
    public string string_0;

    public FixSerial()
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
      ResourceManager resourceManager = new ResourceManager(typeof (FixSerial));
      this.pictureBox1 = new PictureBox();
      this.textBox1 = new TextBox();
      this.groupBox1 = new GroupBox();
      this.pictureBox2 = new PictureBox();
      this.groupBox2 = new GroupBox();
      this.textBox4 = new TextBox();
      this.textBox2 = new TextBox();
      this.groupBox3 = new GroupBox();
      this.textBox3 = new TextBox();
      this.pictureBox3 = new PictureBox();
      this.groupBox4 = new GroupBox();
      this.textBox5 = new TextBox();
      this.button1 = new Button();
      this.button2 = new Button();
      this.toolTip_0 = new ToolTip(this.icontainer_0);
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.groupBox3.SuspendLayout();
      this.groupBox4.SuspendLayout();
      this.SuspendLayout();
      this.pictureBox1.Image = (Image) resourceManager.GetObject("pictureBox1.Image");
      Point point1 = new Point();
      point1 = new Point(24, 24);
      this.pictureBox1.Location = point1;
      this.pictureBox1.Name = "pictureBox1";
      Size size1 = new Size();
      size1 = new Size(32, 32);
      this.pictureBox1.Size = size1;
      this.pictureBox1.TabIndex = 0;
      this.pictureBox1.TabStop = false;
      this.toolTip_0.SetToolTip((Control) this.pictureBox1, "Click to see an Example");
      this.pictureBox1.Click += new EventHandler(this.pictureBox1_Click);
      this.pictureBox1.MouseEnter += new EventHandler(this.pictureBox1_MouseEnter);
      this.pictureBox1.MouseLeave += new EventHandler(this.pictureBox1_MouseLeave);
      this.textBox1.Font = new Font("Courier New", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Point point2 = new Point();
      point2 = new Point(16, 72);
      this.textBox1.Location = point2;
      this.textBox1.MaxLength = 16;
      this.textBox1.Multiline = true;
      this.textBox1.Name = "textBox1";
      Size size2 = new Size();
      size2 = new Size(48, 80);
      this.textBox1.Size = size2;
      this.textBox1.TabIndex = 4;
      this.textBox1.Text = "8G241076170514XX";
      this.toolTip_0.SetToolTip((Control) this.textBox1, "Enter 16 digit barcode from drive laser, 4 x 4 ends in XX");
      this.textBox1.TextChanged += new EventHandler(this.textBox1_TextChanged);
      this.textBox1.Leave += new EventHandler(this.textBox1_Leave);
      this.groupBox1.Controls.Add((Control) this.pictureBox1);
      this.groupBox1.Controls.Add((Control) this.textBox1);
      this.groupBox1.FlatStyle = FlatStyle.System;
      Point point3 = new Point();
      point3 = new Point(320, 16);
      this.groupBox1.Location = point3;
      this.groupBox1.Name = "groupBox1";
      Size size3 = new Size();
      size3 = new Size(80, 168);
      this.groupBox1.Size = size3;
      this.groupBox1.TabIndex = 2;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Laser";
      this.pictureBox2.Image = (Image) resourceManager.GetObject("pictureBox2.Image");
      Point point4 = new Point();
      point4 = new Point(136, 32);
      this.pictureBox2.Location = point4;
      this.pictureBox2.Name = "pictureBox2";
      Size size4 = new Size();
      size4 = new Size(48, 48);
      this.pictureBox2.Size = size4;
      this.pictureBox2.TabIndex = 3;
      this.pictureBox2.TabStop = false;
      this.toolTip_0.SetToolTip((Control) this.pictureBox2, "Click to see an Example");
      this.pictureBox2.Click += new EventHandler(this.pictureBox2_Click);
      this.pictureBox2.MouseEnter += new EventHandler(this.pictureBox2_MouseEnter);
      this.pictureBox2.MouseLeave += new EventHandler(this.pictureBox2_MouseLeave);
      this.groupBox2.Controls.Add((Control) this.textBox4);
      this.groupBox2.Controls.Add((Control) this.textBox2);
      this.groupBox2.Controls.Add((Control) this.pictureBox2);
      this.groupBox2.FlatStyle = FlatStyle.System;
      Point point5 = new Point();
      point5 = new Point(16, 128);
      this.groupBox2.Location = point5;
      this.groupBox2.Name = "groupBox2";
      Size size5 = new Size();
      size5 = new Size(192, 96);
      this.groupBox2.Size = size5;
      this.groupBox2.TabIndex = 4;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "PCB";
      this.textBox4.Font = new Font("Courier New", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Point point6 = new Point();
      point6 = new Point(16, 56);
      this.textBox4.Location = point6;
      this.textBox4.MaxLength = 8;
      this.textBox4.Name = "textBox4";
      Size size6 = new Size();
      size6 = new Size(88, 26);
      this.textBox4.Size = size6;
      this.textBox4.TabIndex = 6;
      this.textBox4.Text = "00240924";
      this.toolTip_0.SetToolTip((Control) this.textBox4, "Enter 8 digit third row of PCB label");
      this.textBox4.TextChanged += new EventHandler(this.textBox4_TextChanged);
      this.textBox4.Leave += new EventHandler(this.textBox4_Leave);
      this.textBox2.Font = new Font("Courier New", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Point point7 = new Point();
      point7 = new Point(16, 24);
      this.textBox2.Location = point7;
      this.textBox2.MaxLength = 10;
      this.textBox2.Name = "textBox2";
      Size size7 = new Size();
      size7 = new Size(112, 26);
      this.textBox2.Size = size7;
      this.textBox2.TabIndex = 5;
      this.textBox2.Text = "S4P8731000";
      this.toolTip_0.SetToolTip((Control) this.textBox2, "Enter 10 digit second row of PCB label");
      this.textBox2.TextChanged += new EventHandler(this.textBox2_TextChanged);
      this.textBox2.Leave += new EventHandler(this.textBox2_Leave);
      this.groupBox3.Controls.Add((Control) this.textBox3);
      this.groupBox3.Controls.Add((Control) this.pictureBox3);
      this.groupBox3.FlatStyle = FlatStyle.System;
      Point point8 = new Point();
      point8 = new Point(16, 16);
      this.groupBox3.Location = point8;
      this.groupBox3.Name = "groupBox3";
      Size size8 = new Size();
      size8 = new Size(288, 104);
      this.groupBox3.Size = size8;
      this.groupBox3.TabIndex = 5;
      this.groupBox3.TabStop = false;
      this.groupBox3.Text = "Cover";
      this.textBox3.Font = new Font("Courier New", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Point point9 = new Point();
      point9 = new Point(41, 24);
      this.textBox3.Location = point9;
      this.textBox3.MaxLength = 20;
      this.textBox3.Name = "textBox3";
      Size size9 = new Size();
      size9 = new Size(206, 26);
      this.textBox3.Size = size9;
      this.textBox3.TabIndex = 3;
      this.textBox3.Text = "D608CG83290200BCZ   ";
      this.toolTip_0.SetToolTip((Control) this.textBox3, "Enter 17 digit barcode from drive lid");
      this.textBox3.TextChanged += new EventHandler(this.textBox3_TextChanged);
      this.pictureBox3.Image = (Image) resourceManager.GetObject("pictureBox3.Image");
      Point point10 = new Point();
      point10 = new Point(14, 56);
      this.pictureBox3.Location = point10;
      this.pictureBox3.Name = "pictureBox3";
      Size size10 = new Size();
      size10 = new Size(260, 40);
      this.pictureBox3.Size = size10;
      this.pictureBox3.TabIndex = 0;
      this.pictureBox3.TabStop = false;
      this.groupBox4.Controls.Add((Control) this.textBox5);
      this.groupBox4.FlatStyle = FlatStyle.System;
      Point point11 = new Point();
      point11 = new Point(224, 128);
      this.groupBox4.Location = point11;
      this.groupBox4.Name = "groupBox4";
      Size size11 = new Size();
      size11 = new Size(80, 56);
      this.groupBox4.Size = size11;
      this.groupBox4.TabIndex = 6;
      this.groupBox4.TabStop = false;
      this.groupBox4.Text = "HW Ver";
      this.textBox5.Font = new Font("Courier New", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Point point12 = new Point();
      point12 = new Point(16, 16);
      this.textBox5.Location = point12;
      this.textBox5.MaxLength = 4;
      this.textBox5.Name = "textBox5";
      Size size12 = new Size();
      size12 = new Size(48, 26);
      this.textBox5.Size = size12;
      this.textBox5.TabIndex = 7;
      this.textBox5.Text = "A0A1";
      this.toolTip_0.SetToolTip((Control) this.textBox5, "Enter H/W rev from Lid label");
      this.textBox5.TextChanged += new EventHandler(this.textBox5_TextChanged);
      this.textBox5.Leave += new EventHandler(this.textBox5_Leave);
      this.button1.DialogResult = DialogResult.OK;
      this.button1.FlatStyle = FlatStyle.System;
      Point point13 = new Point();
      point13 = new Point(224, 192);
      this.button1.Location = point13;
      this.button1.Name = "button1";
      Size size13 = new Size();
      size13 = new Size(80, 32);
      this.button1.Size = size13;
      this.button1.TabIndex = 1;
      this.button1.Text = "OK";
      this.button1.Click += new EventHandler(this.button1_Click);
      this.button2.DialogResult = DialogResult.Cancel;
      this.button2.FlatStyle = FlatStyle.System;
      Point point14 = new Point();
      point14 = new Point(320, 192);
      this.button2.Location = point14;
      this.button2.Name = "button2";
      Size size14 = new Size();
      size14 = new Size(80, 32);
      this.button2.Size = size14;
      this.button2.TabIndex = 2;
      this.button2.Text = "Cancel";
      this.AcceptButton = (IButtonControl) this.button1;
      Size size15 = new Size();
      size15 = new Size(5, 13);
      this.AutoScaleBaseSize = size15;
      this.CancelButton = (IButtonControl) this.button2;
      Size size16 = new Size();
      size16 = new Size(418, 240);
      this.ClientSize = size16;
      this.ControlBox = false;
      this.Controls.Add((Control) this.button2);
      this.Controls.Add((Control) this.button1);
      this.Controls.Add((Control) this.groupBox4);
      this.Controls.Add((Control) this.groupBox3);
      this.Controls.Add((Control) this.groupBox2);
      this.Controls.Add((Control) this.groupBox1);
      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      this.Icon = (Icon) resourceManager.GetObject("$this.Icon");
      this.Name = "FixSerial";
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "Update Serial Info";
      this.Load += new EventHandler(this.FixSerial_Load);
      this.groupBox1.ResumeLayout(false);
      this.groupBox2.ResumeLayout(false);
      this.groupBox3.ResumeLayout(false);
      this.groupBox4.ResumeLayout(false);
      this.ResumeLayout(false);
    }

    public unsafe string method_0(byte* pByte_2, uint uint_3)
    {
      string str1 = (string) null;
      for (uint index = 0U; index < uint_3; ++index)
      {
        if ((int) pByte_2[(int) index] >= 32 && (int) pByte_2[(int) index] <= 126)
        {
          if ((int) pByte_2[(int) index] >= 97 && (int) pByte_2[(int) index] <= 122)
            pByte_2[(int) index] = (byte) ((int) pByte_2[(int) index] - 32);
          Struct20 struct20;
          \u003CModule\u003E.sprintf((sbyte*) &struct20, (sbyte*) &\u003CModule\u003E.struct18_0, __arglist ((int) pByte_2[(int) index]));
          string str2 = new string((sbyte*) &\u003CModule\u003E.struct19_0) + new string((sbyte*) &struct20);
          str1 = str1 + str2;
        }
        else
          str1 = str1 + "?";
      }
      return str1;
    }

    public unsafe int method_1(byte* pByte_2, uint uint_3)
    {
      for (uint index = 0U; index < uint_3; ++index)
      {
        if ((int) pByte_2[(int) index] != 32 && ((int) pByte_2[(int) index] < 48 || (int) pByte_2[(int) index] > 57) && (((int) pByte_2[(int) index] < 97 || (int) pByte_2[(int) index] > 122) && ((int) pByte_2[(int) index] < 65 || (int) pByte_2[(int) index] > 90)))
          return 1;
      }
      return 0;
    }

    private unsafe void FixSerial_Load(object sender, EventArgs e)
    {
      Struct41 struct41;
      // ISSUE: explicit reference operation
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      ^(sbyte&) @struct41 = (sbyte) -1;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      ^(sbyte&) ((IntPtr) &struct41 + 1) = (sbyte) -1;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      ^(sbyte&) ((IntPtr) &struct41 + 2) = (sbyte) -1;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      ^(sbyte&) ((IntPtr) &struct41 + 3) = (sbyte) -1;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      ^(sbyte&) ((IntPtr) &struct41 + 4) = (sbyte) -1;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      ^(sbyte&) ((IntPtr) &struct41 + 5) = (sbyte) -1;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      ^(sbyte&) ((IntPtr) &struct41 + 6) = (sbyte) -1;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      ^(sbyte&) ((IntPtr) &struct41 + 7) = (sbyte) -1;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      ^(sbyte&) ((IntPtr) &struct41 + 8) = (sbyte) -1;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      ^(sbyte&) ((IntPtr) &struct41 + 9) = (sbyte) -1;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      ^(sbyte&) ((IntPtr) &struct41 + 10) = (sbyte) -1;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      ^(sbyte&) ((IntPtr) &struct41 + 11) = (sbyte) -1;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      ^(sbyte&) ((IntPtr) &struct41 + 12) = (sbyte) -1;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      ^(sbyte&) ((IntPtr) &struct41 + 13) = (sbyte) -1;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      ^(sbyte&) ((IntPtr) &struct41 + 14) = (sbyte) -1;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      ^(sbyte&) ((IntPtr) &struct41 + 15) = (sbyte) -1;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      ^(sbyte&) ((IntPtr) &struct41 + 16) = (sbyte) -1;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      ^(sbyte&) ((IntPtr) &struct41 + 17) = (sbyte) -1;
      if ((int) this.uint_1 == 5 && (int) this.uint_2 == 1)
      {
        \u003CModule\u003E.memset((void*) (this.pByte_0 + 17), 32, 3U);
        \u003CModule\u003E.memset((void*) (this.pByte_1 + 130833), 32, 3U);
      }
      this.textBox3.Text = this.method_0(this.pByte_0, 20U);
      this.bool_0 = true;
      this.textBox1.Text = this.method_0(this.pByte_0 + 24, 16U);
      this.bool_1 = \u003CModule\u003E.memcmp((void*) (this.pByte_0 + 24), (void*) &struct41, 18U) != 0;
      this.textBox2.Text = this.method_0(this.pByte_0 + 44, 10U);
      this.bool_2 = \u003CModule\u003E.memcmp((void*) (this.pByte_0 + 24), (void*) &struct41, 10U) != 0;
      this.textBox4.Text = this.method_0(this.pByte_0 + 54, 8U);
      this.bool_3 = \u003CModule\u003E.memcmp((void*) (this.pByte_0 + 54), (void*) &struct41, 8U) != 0;
      this.textBox5.Text = this.method_0(this.pByte_0 + 40, 2U) + this.method_0(this.pByte_0 + 76, 2U);
      this.bool_4 = true;
      this.method_7();
    }

    private unsafe void method_2()
    {
      this.bool_0 = false;
      string s = Convert.ToString(this.textBox3.Text);
      if (this.textBox3.TextLength != 20)
      {
        // ISSUE: cast to a function pointer type
        \u003CModule\u003E.pGstruct14_7 = \u003CModule\u003E.SetWindowsHookExA(5, (__FnPtr<int (int, uint, int)>) (IntPtr) \u003CModule\u003E.ppInt_6, (GStruct81*) 0, \u003CModule\u003E.GetCurrentThreadId());
        int num = (int) MessageBox.Show("Cover Barcode must be 20 chars ( 17 alpha-numeric and 3 spaces)" + "\n" + "e.g. [D608CG833907010F0___]", "Case Barcode", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        \u003CModule\u003E.UnhookWindowsHookEx(\u003CModule\u003E.pGstruct14_7);
      }
      else
      {
        byte* pByte_2 = (byte*) (void*) Marshal.StringToHGlobalAnsi(s);
        Struct42 struct42;
        \u003CModule\u003E.memset((void*) &struct42, 0, 20U);
        if (this.method_1(pByte_2, 20U) != 0)
        {
          // ISSUE: cast to a function pointer type
          \u003CModule\u003E.pGstruct14_7 = \u003CModule\u003E.SetWindowsHookExA(5, (__FnPtr<int (int, uint, int)>) (IntPtr) \u003CModule\u003E.ppInt_6, (GStruct81*) 0, \u003CModule\u003E.GetCurrentThreadId());
          int num = (int) MessageBox.Show("Cover Barcode must be 20 chars.. ( 17 alpha-numeric and 3 spaces)" + "\n" + "e.g. [D608CG833907010F0___]", "Case Barcode", MessageBoxButtons.OK, MessageBoxIcon.Hand);
          \u003CModule\u003E.UnhookWindowsHookEx(\u003CModule\u003E.pGstruct14_7);
        }
        else
        {
          \u003CModule\u003E.memcpy((void*) this.pByte_0, (void*) pByte_2, 20U);
          \u003CModule\u003E.memcpy((void*) (this.pByte_1 + 130816), (void*) pByte_2, 20U);
          if ((int) this.uint_0 == 41008)
          {
            \u003CModule\u003E.memcpy((void*) (this.pByte_1 + 11818), (void*) pByte_2, 20U);
            \u003CModule\u003E.memcpy((void*) (this.pByte_1 + 11284), (void*) pByte_2, 20U);
          }
          this.button1.Enabled = false;
          this.textBox3.Clear();
          this.textBox3.Text = this.method_0(this.pByte_0, 20U);
          this.bool_0 = true;
          this.method_7();
        }
      }
    }

    private unsafe void method_3()
    {
      this.bool_4 = false;
      string s = Convert.ToString(this.textBox5.Text);
      if (this.textBox5.TextLength != 4)
      {
        // ISSUE: cast to a function pointer type
        \u003CModule\u003E.pGstruct14_7 = \u003CModule\u003E.SetWindowsHookExA(5, (__FnPtr<int (int, uint, int)>) (IntPtr) \u003CModule\u003E.ppInt_6, (GStruct81*) 0, \u003CModule\u003E.GetCurrentThreadId());
        int num = (int) MessageBox.Show("Rev must be 4 chars" + "\n" + "e.g. [A0A1]", "H/W Rev", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        \u003CModule\u003E.UnhookWindowsHookEx(\u003CModule\u003E.pGstruct14_7);
      }
      else
      {
        byte* pByte_2 = (byte*) (void*) Marshal.StringToHGlobalAnsi(s);
        if (this.method_1(pByte_2, 4U) != 0)
        {
          // ISSUE: cast to a function pointer type
          \u003CModule\u003E.pGstruct14_7 = \u003CModule\u003E.SetWindowsHookExA(5, (__FnPtr<int (int, uint, int)>) (IntPtr) \u003CModule\u003E.ppInt_6, (GStruct81*) 0, \u003CModule\u003E.GetCurrentThreadId());
          int num = (int) MessageBox.Show("Rev must be 4 chars" + "\n" + "e.g. [A0A1]", "H/W Rev", MessageBoxButtons.OK, MessageBoxIcon.Hand);
          \u003CModule\u003E.UnhookWindowsHookEx(\u003CModule\u003E.pGstruct14_7);
        }
        else
        {
          \u003CModule\u003E.memcpy((void*) (this.pByte_0 + 40), (void*) pByte_2, 2U);
          \u003CModule\u003E.memcpy((void*) (this.pByte_0 + 76), (void*) (pByte_2 + 2), 2U);
          \u003CModule\u003E.memcpy((void*) (this.pByte_1 + 130856), (void*) pByte_2, 2U);
          \u003CModule\u003E.memcpy((void*) (this.pByte_1 + 130892), (void*) (pByte_2 + 2), 2U);
          if ((int) this.uint_0 == 41008)
          {
            \u003CModule\u003E.memcpy((void*) (this.pByte_1 + 11814), (void*) pByte_2, 2U);
            \u003CModule\u003E.memcpy((void*) (this.pByte_1 + 11816), (void*) (pByte_2 + 2), 2U);
          }
          this.button1.Enabled = false;
          this.textBox5.Clear();
          this.textBox5.Text = this.method_0(this.pByte_0 + 40, 2U) + this.method_0(this.pByte_0 + 76, 2U);
          this.bool_4 = true;
          this.method_7();
        }
      }
    }

    private unsafe void method_4()
    {
      this.bool_1 = false;
      string s = Convert.ToString(this.textBox1.Text);
      if (this.textBox1.TextLength != 16)
      {
        // ISSUE: cast to a function pointer type
        \u003CModule\u003E.pGstruct14_7 = \u003CModule\u003E.SetWindowsHookExA(5, (__FnPtr<int (int, uint, int)>) (IntPtr) \u003CModule\u003E.ppInt_6, (GStruct81*) 0, \u003CModule\u003E.GetCurrentThreadId());
        int num = (int) MessageBox.Show("Laser Barcode must be 16 chars 4 lines of" + "\n" + "e.g. [8G241076170514XX]", "Laser Barcode", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        \u003CModule\u003E.UnhookWindowsHookEx(\u003CModule\u003E.pGstruct14_7);
      }
      else
      {
        byte* pByte_2 = (byte*) (void*) Marshal.StringToHGlobalAnsi(s);
        if (this.method_1(pByte_2, 16U) != 0)
        {
          // ISSUE: cast to a function pointer type
          \u003CModule\u003E.pGstruct14_7 = \u003CModule\u003E.SetWindowsHookExA(5, (__FnPtr<int (int, uint, int)>) (IntPtr) \u003CModule\u003E.ppInt_6, (GStruct81*) 0, \u003CModule\u003E.GetCurrentThreadId());
          int num = (int) MessageBox.Show("Laser Barcode must be 16 chars 4 lines of" + "\n" + "e.g. [8G241076170514XX]", "Laser Barcode", MessageBoxButtons.OK, MessageBoxIcon.Hand);
          \u003CModule\u003E.UnhookWindowsHookEx(\u003CModule\u003E.pGstruct14_7);
        }
        else
        {
          \u003CModule\u003E.memcpy((void*) (this.pByte_0 + 24), (void*) pByte_2, 16U);
          \u003CModule\u003E.memcpy((void*) (this.pByte_1 + 130840), (void*) pByte_2, 16U);
          this.button1.Enabled = false;
          this.textBox1.Clear();
          this.textBox1.Text = this.method_0(this.pByte_0 + 24, 16U);
          this.bool_1 = true;
          this.method_7();
        }
      }
    }

    private unsafe void method_5()
    {
      this.bool_2 = false;
      string s = Convert.ToString(this.textBox2.Text);
      if (this.textBox2.TextLength != 10)
      {
        // ISSUE: cast to a function pointer type
        \u003CModule\u003E.pGstruct14_7 = \u003CModule\u003E.SetWindowsHookExA(5, (__FnPtr<int (int, uint, int)>) (IntPtr) \u003CModule\u003E.ppInt_6, (GStruct81*) 0, \u003CModule\u003E.GetCurrentThreadId());
        int num = (int) MessageBox.Show("PCB barcode first line must be 10 chars" + "\n" + "e.g. [S4P8731000]", "PCB barcode", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        \u003CModule\u003E.UnhookWindowsHookEx(\u003CModule\u003E.pGstruct14_7);
      }
      else
      {
        byte* pByte_2 = (byte*) (void*) Marshal.StringToHGlobalAnsi(s);
        if (this.method_1(pByte_2, 10U) != 0)
        {
          // ISSUE: cast to a function pointer type
          \u003CModule\u003E.pGstruct14_7 = \u003CModule\u003E.SetWindowsHookExA(5, (__FnPtr<int (int, uint, int)>) (IntPtr) \u003CModule\u003E.ppInt_6, (GStruct81*) 0, \u003CModule\u003E.GetCurrentThreadId());
          int num = (int) MessageBox.Show("PCB barcode first line must be 10 chars" + "\n" + "e.g. [S4P8731000]", "PCB barcode", MessageBoxButtons.OK, MessageBoxIcon.Hand);
          \u003CModule\u003E.UnhookWindowsHookEx(\u003CModule\u003E.pGstruct14_7);
        }
        else
        {
          \u003CModule\u003E.memcpy((void*) (this.pByte_0 + 44), (void*) pByte_2, 10U);
          \u003CModule\u003E.memcpy((void*) (this.pByte_1 + 130860), (void*) pByte_2, 10U);
          this.button1.Enabled = false;
          this.textBox2.Clear();
          this.textBox2.Text = this.method_0(this.pByte_0 + 44, 10U);
          this.bool_2 = true;
          this.method_7();
        }
      }
    }

    private unsafe void method_6()
    {
      this.bool_3 = false;
      string s = Convert.ToString(this.textBox4.Text);
      if (this.textBox4.TextLength != 8)
      {
        // ISSUE: cast to a function pointer type
        \u003CModule\u003E.pGstruct14_7 = \u003CModule\u003E.SetWindowsHookExA(5, (__FnPtr<int (int, uint, int)>) (IntPtr) \u003CModule\u003E.ppInt_6, (GStruct81*) 0, \u003CModule\u003E.GetCurrentThreadId());
        int num = (int) MessageBox.Show("PCB barcode second line must be 8 chars" + "\n" + "e.g. [00240924]", "PCB barcode", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        \u003CModule\u003E.UnhookWindowsHookEx(\u003CModule\u003E.pGstruct14_7);
      }
      else
      {
        byte* pByte_2 = (byte*) (void*) Marshal.StringToHGlobalAnsi(s);
        if (this.method_1(pByte_2, 8U) != 0)
        {
          // ISSUE: cast to a function pointer type
          \u003CModule\u003E.pGstruct14_7 = \u003CModule\u003E.SetWindowsHookExA(5, (__FnPtr<int (int, uint, int)>) (IntPtr) \u003CModule\u003E.ppInt_6, (GStruct81*) 0, \u003CModule\u003E.GetCurrentThreadId());
          int num = (int) MessageBox.Show("PCB barcode second line must be 8 chars" + "\n" + "e.g. [00240924]", "PCB barcode", MessageBoxButtons.OK, MessageBoxIcon.Hand);
          \u003CModule\u003E.UnhookWindowsHookEx(\u003CModule\u003E.pGstruct14_7);
        }
        else
        {
          \u003CModule\u003E.memcpy((void*) (this.pByte_0 + 54), (void*) pByte_2, 8U);
          this.pByte_0[62] = (byte) 0;
          this.pByte_0[63] = (byte) 0;
          \u003CModule\u003E.memcpy((void*) (this.pByte_1 + 130870), (void*) pByte_2, 8U);
          this.pByte_1[130878] = (byte) 0;
          this.pByte_1[130879] = (byte) 0;
          this.button1.Enabled = false;
          this.textBox4.Clear();
          this.textBox4.Text = this.method_0(this.pByte_0 + 54, 8U);
          this.bool_3 = true;
          this.method_7();
        }
      }
    }

    private void method_7()
    {
      if (this.bool_0 & this.bool_1 & this.bool_2 & this.bool_3 & this.bool_4)
        this.button1.Enabled = true;
      else
        this.button1.Enabled = false;
    }

    private void method_8(object sender, EventArgs e)
    {
      this.method_2();
    }

    private void textBox1_Leave(object sender, EventArgs e)
    {
      this.method_4();
    }

    private void textBox2_Leave(object sender, EventArgs e)
    {
      this.method_5();
    }

    private void textBox4_Leave(object sender, EventArgs e)
    {
      this.method_6();
    }

    private void textBox5_Leave(object sender, EventArgs e)
    {
      this.method_3();
    }

    private unsafe void button1_Click(object sender, EventArgs e)
    {
      this.method_2();
      this.method_3();
      this.method_4();
      this.method_5();
      this.method_6();
      if ((int) this.uint_1 == 5 && (int) this.uint_2 == 1)
      {
        \u003CModule\u003E.memset((void*) (this.pByte_0 + 17), 0, 3U);
        \u003CModule\u003E.memset((void*) (this.pByte_1 + 130833), 0, 3U);
      }
      SaveFileDialog saveFileDialog = new SaveFileDialog();
      saveFileDialog.Filter = "Firmware Images (*.bin)|*.bin|All Files (*.*)|*.*";
      saveFileDialog.DefaultExt = ".bin";
      saveFileDialog.FileName = "dummy_fixed.bin";
      saveFileDialog.RestoreDirectory = false;
      if (saveFileDialog.ShowDialog() == DialogResult.OK)
      {
        sbyte* pSbyte_0 = (sbyte*) (void*) Marshal.StringToHGlobalAnsi(Path.GetFullPath(saveFileDialog.FileName));
        this.string_0 = saveFileDialog.FileName;
        GStruct5* pGstruct5_0 = \u003CModule\u003E.fopen(pSbyte_0, (sbyte*) &\u003CModule\u003E.struct18_5);
        if ((IntPtr) pGstruct5_0 == IntPtr.Zero)
        {
          // ISSUE: cast to a function pointer type
          \u003CModule\u003E.pGstruct14_7 = \u003CModule\u003E.SetWindowsHookExA(5, (__FnPtr<int (int, uint, int)>) (IntPtr) \u003CModule\u003E.ppInt_6, (GStruct81*) 0, \u003CModule\u003E.GetCurrentThreadId());
          int num = (int) MessageBox.Show(saveFileDialog.FileName.ToString(), "Can't open file", MessageBoxButtons.OK);
          \u003CModule\u003E.UnhookWindowsHookEx(\u003CModule\u003E.pGstruct14_7);
        }
        else
        {
          int num = (int) \u003CModule\u003E.fwrite((void*) this.pByte_1, 262144U, 1U, pGstruct5_0);
          \u003CModule\u003E.fclose(pGstruct5_0);
        }
      }
      else
        this.DialogResult = DialogResult.Cancel;
    }

    private void textBox3_TextChanged(object sender, EventArgs e)
    {
      this.button1.Enabled = false;
    }

    private void textBox2_TextChanged(object sender, EventArgs e)
    {
      this.button1.Enabled = false;
    }

    private void textBox4_TextChanged(object sender, EventArgs e)
    {
      this.button1.Enabled = false;
    }

    private void textBox5_TextChanged(object sender, EventArgs e)
    {
      this.button1.Enabled = false;
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {
      this.button1.Enabled = false;
    }

    private unsafe void pictureBox2_Click(object sender, EventArgs e)
    {
      try
      {
        Process.Start("http://www.jungleflasher.net/files/IMAGE_095.jpg");
      }
      catch (Exception ex)
      {
        // ISSUE: cast to a function pointer type
        \u003CModule\u003E.pGstruct14_7 = \u003CModule\u003E.SetWindowsHookExA(5, (__FnPtr<int (int, uint, int)>) (IntPtr) \u003CModule\u003E.ppInt_6, (GStruct81*) 0, \u003CModule\u003E.GetCurrentThreadId());
        int num = (int) MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
        \u003CModule\u003E.UnhookWindowsHookEx(\u003CModule\u003E.pGstruct14_7);
      }
    }

    private unsafe void pictureBox1_Click(object sender, EventArgs e)
    {
      try
      {
        Process.Start("http://www.jungleflasher.net/files/IMAGE_094.jpg");
      }
      catch (Exception ex)
      {
        // ISSUE: cast to a function pointer type
        \u003CModule\u003E.pGstruct14_7 = \u003CModule\u003E.SetWindowsHookExA(5, (__FnPtr<int (int, uint, int)>) (IntPtr) \u003CModule\u003E.ppInt_6, (GStruct81*) 0, \u003CModule\u003E.GetCurrentThreadId());
        int num = (int) MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
        \u003CModule\u003E.UnhookWindowsHookEx(\u003CModule\u003E.pGstruct14_7);
      }
    }

    private void pictureBox2_MouseEnter(object sender, EventArgs e)
    {
      this.Cursor = Cursors.Hand;
    }

    private void pictureBox2_MouseLeave(object sender, EventArgs e)
    {
      this.Cursor = Cursors.Arrow;
    }

    private void pictureBox1_MouseEnter(object sender, EventArgs e)
    {
      this.Cursor = Cursors.Hand;
    }

    private void pictureBox1_MouseLeave(object sender, EventArgs e)
    {
      this.Cursor = Cursors.Arrow;
    }
  }
}
