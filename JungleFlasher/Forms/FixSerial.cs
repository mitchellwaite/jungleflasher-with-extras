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
        private IContainer components;
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FixSerial));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.toolTip_0 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.toolTip_0.SetToolTip(this.pictureBox1, "Click to see an Example");
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(16, 72);
            this.textBox1.MaxLength = 16;
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(48, 80);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "8G241076170514XX";
            this.toolTip_0.SetToolTip(this.textBox1, "Enter 16 digit barcode from drive laser, 4 x 4 ends in XX");
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Location = new System.Drawing.Point(320, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(80, 168);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Laser";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(136, 32);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 48);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.toolTip_0.SetToolTip(this.pictureBox2, "Click to see an Example");
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pictureBox2.MouseEnter += new System.EventHandler(this.pictureBox2_MouseEnter);
            this.pictureBox2.MouseLeave += new System.EventHandler(this.pictureBox2_MouseLeave);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox2.Location = new System.Drawing.Point(16, 128);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(192, 96);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PCB";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(16, 56);
            this.textBox4.MaxLength = 8;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(88, 26);
            this.textBox4.TabIndex = 6;
            this.textBox4.Text = "00240924";
            this.toolTip_0.SetToolTip(this.textBox4, "Enter 8 digit third row of PCB label");
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            this.textBox4.Leave += new System.EventHandler(this.textBox4_Leave);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(16, 24);
            this.textBox2.MaxLength = 10;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(112, 26);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "S4P8731000";
            this.toolTip_0.SetToolTip(this.textBox2, "Enter 10 digit second row of PCB label");
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.textBox2.Leave += new System.EventHandler(this.textBox2_Leave);
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
            this.textBox3.Location = new System.Drawing.Point(41, 24);
            this.textBox3.MaxLength = 20;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(206, 26);
            this.textBox3.TabIndex = 3;
            this.textBox3.Text = "D608CG83290200BCZ   ";
            this.toolTip_0.SetToolTip(this.textBox3, "Enter 17 digit barcode from drive lid");
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
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
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox5);
            this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox4.Location = new System.Drawing.Point(224, 128);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(80, 56);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "HW Ver";
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(16, 16);
            this.textBox5.MaxLength = 4;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(48, 26);
            this.textBox5.TabIndex = 7;
            this.textBox5.Text = "A0A1";
            this.toolTip_0.SetToolTip(this.textBox5, "Enter H/W rev from Lid label");
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            this.textBox5.Leave += new System.EventHandler(this.textBox5_Leave);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(224, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "OK";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Location = new System.Drawing.Point(320, 192);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 32);
            this.button2.TabIndex = 2;
            this.button2.Text = "Cancel";
            // 
            // FixSerial
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(418, 240);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FixSerial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Update Serial Info";
            this.Load += new System.EventHandler(this.FixSerial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
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
          _Module.sprintf((sbyte*) &struct20, (sbyte*) &_Module.struct18_0, __arglist ((int) pByte_2[(int) index]));
          string str2 = new string((sbyte*) &_Module.struct19_0) + new string((sbyte*) &struct20);
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
        _Module.memset((void*) (this.pByte_0 + 17), 32, 3U);
        _Module.memset((void*) (this.pByte_1 + 130833), 32, 3U);
      }
      this.textBox3.Text = this.method_0(this.pByte_0, 20U);
      this.bool_0 = true;
      this.textBox1.Text = this.method_0(this.pByte_0 + 24, 16U);
      this.bool_1 = _Module.memcmp((void*) (this.pByte_0 + 24), (void*) &struct41, 18U) != 0;
      this.textBox2.Text = this.method_0(this.pByte_0 + 44, 10U);
      this.bool_2 = _Module.memcmp((void*) (this.pByte_0 + 24), (void*) &struct41, 10U) != 0;
      this.textBox4.Text = this.method_0(this.pByte_0 + 54, 8U);
      this.bool_3 = _Module.memcmp((void*) (this.pByte_0 + 54), (void*) &struct41, 8U) != 0;
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
        _Module.pGstruct14_7 = _Module.SetWindowsHookExA(5, (__FnPtr<int (int, uint, int)>) (IntPtr) _Module.ppInt_6, (GStruct81*) 0, _Module.GetCurrentThreadId());
        int num = (int) MessageBox.Show("Cover Barcode must be 20 chars ( 17 alpha-numeric and 3 spaces)" + "\n" + "e.g. [D608CG833907010F0___]", "Case Barcode", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        _Module.UnhookWindowsHookEx(_Module.pGstruct14_7);
      }
      else
      {
        byte* pByte_2 = (byte*) (void*) Marshal.StringToHGlobalAnsi(s);
        Struct42 struct42;
        _Module.memset((void*) &struct42, 0, 20U);
        if (this.method_1(pByte_2, 20U) != 0)
        {
          // ISSUE: cast to a function pointer type
          _Module.pGstruct14_7 = _Module.SetWindowsHookExA(5, (__FnPtr<int (int, uint, int)>) (IntPtr) _Module.ppInt_6, (GStruct81*) 0, _Module.GetCurrentThreadId());
          int num = (int) MessageBox.Show("Cover Barcode must be 20 chars.. ( 17 alpha-numeric and 3 spaces)" + "\n" + "e.g. [D608CG833907010F0___]", "Case Barcode", MessageBoxButtons.OK, MessageBoxIcon.Hand);
          _Module.UnhookWindowsHookEx(_Module.pGstruct14_7);
        }
        else
        {
          _Module.memcpy((void*) this.pByte_0, (void*) pByte_2, 20U);
          _Module.memcpy((void*) (this.pByte_1 + 130816), (void*) pByte_2, 20U);
          if ((int) this.uint_0 == 41008)
          {
            _Module.memcpy((void*) (this.pByte_1 + 11818), (void*) pByte_2, 20U);
            _Module.memcpy((void*) (this.pByte_1 + 11284), (void*) pByte_2, 20U);
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
        _Module.pGstruct14_7 = _Module.SetWindowsHookExA(5, (__FnPtr<int (int, uint, int)>) (IntPtr) _Module.ppInt_6, (GStruct81*) 0, _Module.GetCurrentThreadId());
        int num = (int) MessageBox.Show("Rev must be 4 chars" + "\n" + "e.g. [A0A1]", "H/W Rev", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        _Module.UnhookWindowsHookEx(_Module.pGstruct14_7);
      }
      else
      {
        byte* pByte_2 = (byte*) (void*) Marshal.StringToHGlobalAnsi(s);
        if (this.method_1(pByte_2, 4U) != 0)
        {
          // ISSUE: cast to a function pointer type
          _Module.pGstruct14_7 = _Module.SetWindowsHookExA(5, (__FnPtr<int (int, uint, int)>) (IntPtr) _Module.ppInt_6, (GStruct81*) 0, _Module.GetCurrentThreadId());
          int num = (int) MessageBox.Show("Rev must be 4 chars" + "\n" + "e.g. [A0A1]", "H/W Rev", MessageBoxButtons.OK, MessageBoxIcon.Hand);
          _Module.UnhookWindowsHookEx(_Module.pGstruct14_7);
        }
        else
        {
          _Module.memcpy((void*) (this.pByte_0 + 40), (void*) pByte_2, 2U);
          _Module.memcpy((void*) (this.pByte_0 + 76), (void*) (pByte_2 + 2), 2U);
          _Module.memcpy((void*) (this.pByte_1 + 130856), (void*) pByte_2, 2U);
          _Module.memcpy((void*) (this.pByte_1 + 130892), (void*) (pByte_2 + 2), 2U);
          if ((int) this.uint_0 == 41008)
          {
            _Module.memcpy((void*) (this.pByte_1 + 11814), (void*) pByte_2, 2U);
            _Module.memcpy((void*) (this.pByte_1 + 11816), (void*) (pByte_2 + 2), 2U);
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
        _Module.pGstruct14_7 = _Module.SetWindowsHookExA(5, (__FnPtr<int (int, uint, int)>) (IntPtr) _Module.ppInt_6, (GStruct81*) 0, _Module.GetCurrentThreadId());
        int num = (int) MessageBox.Show("Laser Barcode must be 16 chars 4 lines of" + "\n" + "e.g. [8G241076170514XX]", "Laser Barcode", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        _Module.UnhookWindowsHookEx(_Module.pGstruct14_7);
      }
      else
      {
        byte* pByte_2 = (byte*) (void*) Marshal.StringToHGlobalAnsi(s);
        if (this.method_1(pByte_2, 16U) != 0)
        {
          // ISSUE: cast to a function pointer type
          _Module.pGstruct14_7 = _Module.SetWindowsHookExA(5, (__FnPtr<int (int, uint, int)>) (IntPtr) _Module.ppInt_6, (GStruct81*) 0, _Module.GetCurrentThreadId());
          int num = (int) MessageBox.Show("Laser Barcode must be 16 chars 4 lines of" + "\n" + "e.g. [8G241076170514XX]", "Laser Barcode", MessageBoxButtons.OK, MessageBoxIcon.Hand);
          _Module.UnhookWindowsHookEx(_Module.pGstruct14_7);
        }
        else
        {
          _Module.memcpy((void*) (this.pByte_0 + 24), (void*) pByte_2, 16U);
          _Module.memcpy((void*) (this.pByte_1 + 130840), (void*) pByte_2, 16U);
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
        _Module.pGstruct14_7 = _Module.SetWindowsHookExA(5, (__FnPtr<int (int, uint, int)>) (IntPtr) _Module.ppInt_6, (GStruct81*) 0, _Module.GetCurrentThreadId());
        int num = (int) MessageBox.Show("PCB barcode first line must be 10 chars" + "\n" + "e.g. [S4P8731000]", "PCB barcode", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        _Module.UnhookWindowsHookEx(_Module.pGstruct14_7);
      }
      else
      {
        byte* pByte_2 = (byte*) (void*) Marshal.StringToHGlobalAnsi(s);
        if (this.method_1(pByte_2, 10U) != 0)
        {
          // ISSUE: cast to a function pointer type
          _Module.pGstruct14_7 = _Module.SetWindowsHookExA(5, (__FnPtr<int (int, uint, int)>) (IntPtr) _Module.ppInt_6, (GStruct81*) 0, _Module.GetCurrentThreadId());
          int num = (int) MessageBox.Show("PCB barcode first line must be 10 chars" + "\n" + "e.g. [S4P8731000]", "PCB barcode", MessageBoxButtons.OK, MessageBoxIcon.Hand);
          _Module.UnhookWindowsHookEx(_Module.pGstruct14_7);
        }
        else
        {
          _Module.memcpy((void*) (this.pByte_0 + 44), (void*) pByte_2, 10U);
          _Module.memcpy((void*) (this.pByte_1 + 130860), (void*) pByte_2, 10U);
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
        _Module.pGstruct14_7 = _Module.SetWindowsHookExA(5, (__FnPtr<int (int, uint, int)>) (IntPtr) _Module.ppInt_6, (GStruct81*) 0, _Module.GetCurrentThreadId());
        int num = (int) MessageBox.Show("PCB barcode second line must be 8 chars" + "\n" + "e.g. [00240924]", "PCB barcode", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        _Module.UnhookWindowsHookEx(_Module.pGstruct14_7);
      }
      else
      {
        byte* pByte_2 = (byte*) (void*) Marshal.StringToHGlobalAnsi(s);
        if (this.method_1(pByte_2, 8U) != 0)
        {
          // ISSUE: cast to a function pointer type
          _Module.pGstruct14_7 = _Module.SetWindowsHookExA(5, (__FnPtr<int (int, uint, int)>) (IntPtr) _Module.ppInt_6, (GStruct81*) 0, _Module.GetCurrentThreadId());
          int num = (int) MessageBox.Show("PCB barcode second line must be 8 chars" + "\n" + "e.g. [00240924]", "PCB barcode", MessageBoxButtons.OK, MessageBoxIcon.Hand);
          _Module.UnhookWindowsHookEx(_Module.pGstruct14_7);
        }
        else
        {
          _Module.memcpy((void*) (this.pByte_0 + 54), (void*) pByte_2, 8U);
          this.pByte_0[62] = (byte) 0;
          this.pByte_0[63] = (byte) 0;
          _Module.memcpy((void*) (this.pByte_1 + 130870), (void*) pByte_2, 8U);
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
        _Module.memset((void*) (this.pByte_0 + 17), 0, 3U);
        _Module.memset((void*) (this.pByte_1 + 130833), 0, 3U);
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
        GStruct5* pGstruct5_0 = _Module.fopen(pSbyte_0, (sbyte*) &_Module.struct18_5);
        if ((IntPtr) pGstruct5_0 == IntPtr.Zero)
        {
          // ISSUE: cast to a function pointer type
          _Module.pGstruct14_7 = _Module.SetWindowsHookExA(5, (__FnPtr<int (int, uint, int)>) (IntPtr) _Module.ppInt_6, (GStruct81*) 0, _Module.GetCurrentThreadId());
          int num = (int) MessageBox.Show(saveFileDialog.FileName.ToString(), "Can't open file", MessageBoxButtons.OK);
          _Module.UnhookWindowsHookEx(_Module.pGstruct14_7);
        }
        else
        {
          int num = (int) _Module.fwrite((void*) this.pByte_1, 262144U, 1U, pGstruct5_0);
          _Module.fclose(pGstruct5_0);
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
        _Module.pGstruct14_7 = _Module.SetWindowsHookExA(5, (__FnPtr<int (int, uint, int)>) (IntPtr) _Module.ppInt_6, (GStruct81*) 0, _Module.GetCurrentThreadId());
        int num = (int) MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
        _Module.UnhookWindowsHookEx(_Module.pGstruct14_7);
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
        _Module.pGstruct14_7 = _Module.SetWindowsHookExA(5, (__FnPtr<int (int, uint, int)>) (IntPtr) _Module.ppInt_6, (GStruct81*) 0, _Module.GetCurrentThreadId());
        int num = (int) MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
        _Module.UnhookWindowsHookEx(_Module.pGstruct14_7);
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
