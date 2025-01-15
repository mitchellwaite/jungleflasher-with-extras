// Type: ns0.DumpFile
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
  public class DumpFile : Form
  {
    private TextBox textBox5;
    private Button button5;
    private Button button4;
    private TextBox textBox8;
    private Button button7;
    private TextBox textBox1;
    private Button button1;
    private Button button3;
    private Label label15;
    private Label label1;
    private Label label2;
    private Button button2;
    private TextBox textBox2;
    private Label label3;
    private Container container_0;
    private unsafe byte* pByte_0;
    private unsafe byte* pByte_1;
    private unsafe byte* pByte_2;
    private unsafe byte* pByte_3;
    public unsafe byte* pByte_4;
    public bool bool_0;
    public bool bool_1;
    public bool bool_2;
    public bool bool_3;
    public string string_0;
    public bool bool_4;
    public string string_1;

    public DumpFile()
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
      ResourceManager resourceManager = new ResourceManager(typeof (DumpFile));
      this.textBox5 = new TextBox();
      this.button5 = new Button();
      this.button4 = new Button();
      this.textBox8 = new TextBox();
      this.button7 = new Button();
      this.textBox1 = new TextBox();
      this.button1 = new Button();
      this.button3 = new Button();
      this.label15 = new Label();
      this.label1 = new Label();
      this.label2 = new Label();
      this.button2 = new Button();
      this.textBox2 = new TextBox();
      this.label3 = new Label();
      this.SuspendLayout();
      Point point1 = new Point();
      point1 = new Point(64, 72);
      this.textBox5.Location = point1;
      this.textBox5.Name = "textBox5";
      this.textBox5.ReadOnly = true;
      Size size1 = new Size();
      size1 = new Size(424, 20);
      this.textBox5.Size = size1;
      this.textBox5.TabIndex = 23;
      this.textBox5.Text = "";
      this.textBox5.TextChanged += new EventHandler(this.textBox5_TextChanged);
      this.button5.FlatStyle = FlatStyle.System;
      Point point2 = new Point();
      point2 = new Point(16, 72);
      this.button5.Location = point2;
      this.button5.Name = "button5";
      Size size2 = new Size();
      size2 = new Size(36, 20);
      this.button5.Size = size2;
      this.button5.TabIndex = 24;
      this.button5.Text = "...";
      this.button5.Click += new EventHandler(this.button5_Click);
      this.button4.FlatStyle = FlatStyle.System;
      Point point3 = new Point();
      point3 = new Point(16, 24);
      this.button4.Location = point3;
      this.button4.Name = "button4";
      Size size3 = new Size();
      size3 = new Size(36, 20);
      this.button4.Size = size3;
      this.button4.TabIndex = 25;
      this.button4.Text = "...";
      this.button4.Click += new EventHandler(this.button4_Click);
      Point point4 = new Point();
      point4 = new Point(64, 24);
      this.textBox8.Location = point4;
      this.textBox8.Name = "textBox8";
      this.textBox8.ReadOnly = true;
      Size size4 = new Size();
      size4 = new Size(424, 20);
      this.textBox8.Size = size4;
      this.textBox8.TabIndex = 26;
      this.textBox8.Text = "";
      this.textBox8.TextChanged += new EventHandler(this.textBox8_TextChanged);
      this.button7.FlatStyle = FlatStyle.System;
      Point point5 = new Point();
      point5 = new Point(16, 120);
      this.button7.Location = point5;
      this.button7.Name = "button7";
      Size size5 = new Size();
      size5 = new Size(36, 20);
      this.button7.Size = size5;
      this.button7.TabIndex = 27;
      this.button7.Text = "...";
      this.button7.Click += new EventHandler(this.button7_Click);
      Point point6 = new Point();
      point6 = new Point(64, 120);
      this.textBox1.Location = point6;
      this.textBox1.Name = "textBox1";
      this.textBox1.ReadOnly = true;
      Size size6 = new Size();
      size6 = new Size(424, 20);
      this.textBox1.Size = size6;
      this.textBox1.TabIndex = 28;
      this.textBox1.Text = "";
      this.textBox1.TextChanged += new EventHandler(this.textBox1_TextChanged);
      this.button1.DialogResult = DialogResult.OK;
      this.button1.Enabled = false;
      this.button1.FlatStyle = FlatStyle.System;
      Point point7 = new Point();
      point7 = new Point(288, 200);
      this.button1.Location = point7;
      this.button1.Name = "button1";
      Size size7 = new Size();
      size7 = new Size(80, 24);
      this.button1.Size = size7;
      this.button1.TabIndex = 30;
      this.button1.Text = "OK";
      this.button1.Click += new EventHandler(this.button1_Click);
      this.button3.DialogResult = DialogResult.Cancel;
      this.button3.FlatStyle = FlatStyle.System;
      Point point8 = new Point();
      point8 = new Point(136, 200);
      this.button3.Location = point8;
      this.button3.Name = "button3";
      Size size8 = new Size();
      size8 = new Size(80, 24);
      this.button3.Size = size8;
      this.button3.TabIndex = 32;
      this.button3.Text = "Cancel";
      Point point9 = new Point();
      point9 = new Point(64, 8);
      this.label15.Location = point9;
      this.label15.Name = "label15";
      Size size9 = new Size();
      size9 = new Size(88, 16);
      this.label15.Size = size9;
      this.label15.TabIndex = 33;
      this.label15.Text = "Key.bin";
      Point point10 = new Point();
      point10 = new Point(64, 56);
      this.label1.Location = point10;
      this.label1.Name = "label1";
      Size size10 = new Size();
      size10 = new Size(88, 16);
      this.label1.Size = size10;
      this.label1.TabIndex = 34;
      this.label1.Text = "Inquiry.bin";
      Point point11 = new Point();
      point11 = new Point(64, 104);
      this.label2.Location = point11;
      this.label2.Name = "label2";
      Size size11 = new Size();
      size11 = new Size(88, 16);
      this.label2.Size = size11;
      this.label2.TabIndex = 35;
      this.label2.Text = "Identify.bin";
      this.button2.FlatStyle = FlatStyle.System;
      Point point12 = new Point();
      point12 = new Point(16, 168);
      this.button2.Location = point12;
      this.button2.Name = "button2";
      Size size12 = new Size();
      size12 = new Size(36, 20);
      this.button2.Size = size12;
      this.button2.TabIndex = 36;
      this.button2.Text = "...";
      this.button2.Click += new EventHandler(this.button2_Click);
      Point point13 = new Point();
      point13 = new Point(64, 168);
      this.textBox2.Location = point13;
      this.textBox2.Name = "textBox2";
      this.textBox2.ReadOnly = true;
      Size size13 = new Size();
      size13 = new Size(424, 20);
      this.textBox2.Size = size13;
      this.textBox2.TabIndex = 37;
      this.textBox2.Text = "";
      Point point14 = new Point();
      point14 = new Point(64, 152);
      this.label3.Location = point14;
      this.label3.Name = "label3";
      Size size14 = new Size();
      size14 = new Size(88, 16);
      this.label3.Size = size14;
      this.label3.TabIndex = 38;
      this.label3.Text = "Serial.bin";
      Size size15 = new Size();
      size15 = new Size(5, 13);
      this.AutoScaleBaseSize = size15;
      Size size16 = new Size();
      size16 = new Size(506, 240);
      this.ClientSize = size16;
      this.ControlBox = false;
      this.Controls.Add((Control) this.label3);
      this.Controls.Add((Control) this.textBox2);
      this.Controls.Add((Control) this.button2);
      this.Controls.Add((Control) this.label2);
      this.Controls.Add((Control) this.label1);
      this.Controls.Add((Control) this.label15);
      this.Controls.Add((Control) this.button3);
      this.Controls.Add((Control) this.button1);
      this.Controls.Add((Control) this.textBox1);
      this.Controls.Add((Control) this.textBox8);
      this.Controls.Add((Control) this.textBox5);
      this.Controls.Add((Control) this.button7);
      this.Controls.Add((Control) this.button4);
      this.Controls.Add((Control) this.button5);
      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      this.Icon = (Icon) resourceManager.GetObject("$this.Icon");
      Point point15 = new Point();
      point15 = new Point(150, 150);
      this.Location = point15;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "DumpFile";
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "Load DVDKey Extracts";
      this.Load += new EventHandler(this.DumpFile_Load);
      this.Closed += new EventHandler(this.DumpFile_Closed);
      this.ResumeLayout(false);
    }

    private unsafe void DumpFile_Load(object sender, EventArgs e)
    {
      string text = "You are about to generate a Dummy.bin from previously     " + "\n" + "dumped files. This is intended for Legacy support only " + "\n" + "and creating a Dummy.bin in this way will mean " + "\n" + "certain drive specific info will be missing!" + "\n" + "Only use this method if the drive is no longer available." + "\n\n" + "If possible you should re-extract your drive info with the" + "\n" + "latest tools.." + new string((sbyte*) &\u003CModule\u003E.struct6_7) + "        1. JungleFlasher, this tool - DVDKey32 Tab" + "\n" + "        2. Dosflash 1.7+" + "\n" + "        3. DVDKey32 0.7+" + "\n" + "Do you wish to proceed anyway ?" + "\n";
      // ISSUE: cast to a function pointer type
      \u003CModule\u003E.pGstruct14_6 = \u003CModule\u003E.SetWindowsHookExA(5, (__FnPtr<int (int, uint, int)>) (IntPtr) \u003CModule\u003E.ppInt_4, (GStruct81*) 0, \u003CModule\u003E.GetCurrentThreadId());
      int num = (int) MessageBox.Show(text, "Load from dump files", MessageBoxButtons.YesNo, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button2);
      \u003CModule\u003E.UnhookWindowsHookEx(\u003CModule\u003E.pGstruct14_6);
      if (num == 7)
        this.Close();
      this.bool_0 = false;
      this.bool_1 = false;
      this.bool_2 = false;
      this.bool_3 = false;
    }

    private unsafe void button4_Click(object sender, EventArgs e)
    {
      this.bool_0 = false;
      OpenFileDialog openFileDialog = new OpenFileDialog();
      openFileDialog.Filter = "Key file (*.bin)|*.bin|All Files (*.*)|*.*";
      openFileDialog.FileName = "Key.bin";
      openFileDialog.DefaultExt = ".bin";
      openFileDialog.CheckFileExists = true;
      openFileDialog.CheckPathExists = true;
      openFileDialog.RestoreDirectory = false;
      if (this.bool_4)
        openFileDialog.InitialDirectory = this.string_1;
      if (openFileDialog.ShowDialog() != DialogResult.OK)
        return;
      GStruct5* pGstruct5_0 = \u003CModule\u003E.fopen((sbyte*) (void*) Marshal.StringToHGlobalAnsi(Path.GetFullPath(openFileDialog.FileName)), (sbyte*) &\u003CModule\u003E.struct18_4);
      if ((IntPtr) pGstruct5_0 == IntPtr.Zero)
      {
        // ISSUE: cast to a function pointer type
        \u003CModule\u003E.pGstruct14_6 = \u003CModule\u003E.SetWindowsHookExA(5, (__FnPtr<int (int, uint, int)>) (IntPtr) \u003CModule\u003E.ppInt_4, (GStruct81*) 0, \u003CModule\u003E.GetCurrentThreadId());
        int num = (int) MessageBox.Show(openFileDialog.FileName.ToString(), "Can't open file", MessageBoxButtons.OK);
        \u003CModule\u003E.UnhookWindowsHookEx(\u003CModule\u003E.pGstruct14_6);
        this.textBox8.Text = new string((sbyte*) &\u003CModule\u003E.struct19_0);
        this.bool_0 = false;
      }
      else
      {
        \u003CModule\u003E.fseek(pGstruct5_0, 0, 2);
        int num1 = \u003CModule\u003E.ftell(pGstruct5_0);
        \u003CModule\u003E.rewind(pGstruct5_0);
        if (num1 != 16)
        {
          // ISSUE: cast to a function pointer type
          \u003CModule\u003E.pGstruct14_6 = \u003CModule\u003E.SetWindowsHookExA(5, (__FnPtr<int (int, uint, int)>) (IntPtr) \u003CModule\u003E.ppInt_4, (GStruct81*) 0, \u003CModule\u003E.GetCurrentThreadId());
          int num2 = (int) MessageBox.Show("Key file should be 16 bytes", "Loading File", MessageBoxButtons.OK);
          \u003CModule\u003E.UnhookWindowsHookEx(\u003CModule\u003E.pGstruct14_6);
          \u003CModule\u003E.fclose(pGstruct5_0);
          this.textBox8.Text = new string((sbyte*) &\u003CModule\u003E.struct19_0);
          this.bool_0 = false;
        }
        else
        {
          Struct28 struct28;
          if ((int) \u003CModule\u003E.fread((void*) &struct28, 16U, 1U, pGstruct5_0) != 1)
          {
            // ISSUE: cast to a function pointer type
            \u003CModule\u003E.pGstruct14_6 = \u003CModule\u003E.SetWindowsHookExA(5, (__FnPtr<int (int, uint, int)>) (IntPtr) \u003CModule\u003E.ppInt_4, (GStruct81*) 0, \u003CModule\u003E.GetCurrentThreadId());
            int num2 = (int) MessageBox.Show("Key file should be 16 bytes", "Loading File", MessageBoxButtons.OK);
            \u003CModule\u003E.UnhookWindowsHookEx(\u003CModule\u003E.pGstruct14_6);
            \u003CModule\u003E.fclose(pGstruct5_0);
            this.textBox8.Text = new string((sbyte*) &\u003CModule\u003E.struct19_0);
            this.bool_0 = false;
          }
          else
          {
            this.bool_0 = true;
            this.textBox8.Text = openFileDialog.FileName;
            if ((IntPtr) this.pByte_2 == IntPtr.Zero)
              this.pByte_2 = (byte*) \u003CModule\u003E.malloc(16U);
            \u003CModule\u003E.memcpy((void*) this.pByte_2, (void*) &struct28, 16U);
            \u003CModule\u003E.fclose(pGstruct5_0);
          }
        }
      }
    }

    private unsafe void button5_Click(object sender, EventArgs e)
    {
      this.bool_1 = false;
      OpenFileDialog openFileDialog = new OpenFileDialog();
      openFileDialog.Filter = "Inquiry file (*.bin)|*.bin|All Files (*.*)|*.*";
      openFileDialog.FileName = "Inquiry.bin";
      openFileDialog.DefaultExt = ".bin";
      openFileDialog.CheckFileExists = true;
      openFileDialog.CheckPathExists = true;
      openFileDialog.RestoreDirectory = false;
      if (this.bool_4)
        openFileDialog.InitialDirectory = this.string_1;
      if (openFileDialog.ShowDialog() != DialogResult.OK)
        return;
      GStruct5* pGstruct5_0 = \u003CModule\u003E.fopen((sbyte*) (void*) Marshal.StringToHGlobalAnsi(Path.GetFullPath(openFileDialog.FileName)), (sbyte*) &\u003CModule\u003E.struct18_4);
      if ((IntPtr) pGstruct5_0 == IntPtr.Zero)
      {
        // ISSUE: cast to a function pointer type
        \u003CModule\u003E.pGstruct14_6 = \u003CModule\u003E.SetWindowsHookExA(5, (__FnPtr<int (int, uint, int)>) (IntPtr) \u003CModule\u003E.ppInt_4, (GStruct81*) 0, \u003CModule\u003E.GetCurrentThreadId());
        int num = (int) MessageBox.Show(openFileDialog.FileName.ToString(), "Can't open file", MessageBoxButtons.OK);
        \u003CModule\u003E.UnhookWindowsHookEx(\u003CModule\u003E.pGstruct14_6);
        this.textBox5.Text = new string((sbyte*) &\u003CModule\u003E.struct19_0);
        this.bool_1 = false;
      }
      else
      {
        \u003CModule\u003E.fseek(pGstruct5_0, 0, 2);
        int num1 = \u003CModule\u003E.ftell(pGstruct5_0);
        \u003CModule\u003E.rewind(pGstruct5_0);
        if (num1 != 96)
        {
          // ISSUE: cast to a function pointer type
          \u003CModule\u003E.pGstruct14_6 = \u003CModule\u003E.SetWindowsHookExA(5, (__FnPtr<int (int, uint, int)>) (IntPtr) \u003CModule\u003E.ppInt_4, (GStruct81*) 0, \u003CModule\u003E.GetCurrentThreadId());
          int num2 = (int) MessageBox.Show((IWin32Window) this, "Inquiry file should be 96 bytes", "Loading File", MessageBoxButtons.OK);
          \u003CModule\u003E.UnhookWindowsHookEx(\u003CModule\u003E.pGstruct14_6);
          \u003CModule\u003E.fclose(pGstruct5_0);
          this.textBox5.Text = new string((sbyte*) &\u003CModule\u003E.struct19_0);
          this.bool_1 = false;
        }
        else
        {
          Struct29 struct29;
          if ((int) \u003CModule\u003E.fread((void*) &struct29, 96U, 1U, pGstruct5_0) != 1)
          {
            // ISSUE: cast to a function pointer type
            \u003CModule\u003E.pGstruct14_6 = \u003CModule\u003E.SetWindowsHookExA(5, (__FnPtr<int (int, uint, int)>) (IntPtr) \u003CModule\u003E.ppInt_4, (GStruct81*) 0, \u003CModule\u003E.GetCurrentThreadId());
            int num2 = (int) MessageBox.Show("Inquiry file should be 96 bytes", "Loading File", MessageBoxButtons.OK);
            \u003CModule\u003E.UnhookWindowsHookEx(\u003CModule\u003E.pGstruct14_6);
            \u003CModule\u003E.fclose(pGstruct5_0);
            this.textBox5.Text = new string((sbyte*) &\u003CModule\u003E.struct19_0);
            this.bool_1 = false;
          }
          else
          {
            // ISSUE: explicit reference operation
            // ISSUE: cast to a reference type
            // ISSUE: explicit reference operation
            // ISSUE: cast to a reference type
            // ISSUE: explicit reference operation
            // ISSUE: cast to a reference type
            // ISSUE: explicit reference operation
            // ISSUE: cast to a reference type
            // ISSUE: explicit reference operation
            // ISSUE: cast to a reference type
            // ISSUE: explicit reference operation
            // ISSUE: cast to a reference type
            // ISSUE: explicit reference operation
            if ((int) ^(byte&) @struct29 == 5 && (int) ^(byte&) ((IntPtr) &struct29 + 1) == 128 && ((int) ^(byte&) ((IntPtr) &struct29 + 2) == 0 && (int) ^(byte&) ((IntPtr) &struct29 + 3) == 50) && ((int) ^(byte&) ((IntPtr) &struct29 + 5) == 0 && (int) ^(byte&) ((IntPtr) &struct29 + 6) == 0))
            {
              this.bool_1 = true;
              this.textBox5.Text = openFileDialog.FileName;
              if ((IntPtr) this.pByte_1 == IntPtr.Zero)
                this.pByte_1 = (byte*) \u003CModule\u003E.malloc(96U);
              \u003CModule\u003E.memcpy((void*) this.pByte_1, (void*) &struct29, 96U);
              \u003CModule\u003E.fclose(pGstruct5_0);
            }
            else
            {
              // ISSUE: cast to a function pointer type
              \u003CModule\u003E.pGstruct14_6 = \u003CModule\u003E.SetWindowsHookExA(5, (__FnPtr<int (int, uint, int)>) (IntPtr) \u003CModule\u003E.ppInt_4, (GStruct81*) 0, \u003CModule\u003E.GetCurrentThreadId());
              int num2 = (int) MessageBox.Show("Inquiry file is invalid!", "Loading File", MessageBoxButtons.OK);
              \u003CModule\u003E.UnhookWindowsHookEx(\u003CModule\u003E.pGstruct14_6);
              \u003CModule\u003E.fclose(pGstruct5_0);
              this.textBox5.Text = new string((sbyte*) &\u003CModule\u003E.struct19_0);
              this.bool_1 = false;
            }
          }
        }
      }
    }

    private unsafe void button7_Click(object sender, EventArgs e)
    {
      this.bool_2 = false;
      OpenFileDialog openFileDialog = new OpenFileDialog();
      openFileDialog.Filter = "Identify file (*.bin)|*.bin|All Files (*.*)|*.*";
      openFileDialog.FileName = "Identify.bin";
      openFileDialog.DefaultExt = ".bin";
      openFileDialog.CheckFileExists = true;
      openFileDialog.CheckPathExists = true;
      openFileDialog.RestoreDirectory = false;
      if (this.bool_4)
        openFileDialog.InitialDirectory = this.string_1;
      if (openFileDialog.ShowDialog() != DialogResult.OK)
        return;
      GStruct5* pGstruct5_0 = \u003CModule\u003E.fopen((sbyte*) (void*) Marshal.StringToHGlobalAnsi(Path.GetFullPath(openFileDialog.FileName)), (sbyte*) &\u003CModule\u003E.struct18_4);
      if ((IntPtr) pGstruct5_0 == IntPtr.Zero)
      {
        // ISSUE: cast to a function pointer type
        \u003CModule\u003E.pGstruct14_6 = \u003CModule\u003E.SetWindowsHookExA(5, (__FnPtr<int (int, uint, int)>) (IntPtr) \u003CModule\u003E.ppInt_4, (GStruct81*) 0, \u003CModule\u003E.GetCurrentThreadId());
        int num = (int) MessageBox.Show(openFileDialog.FileName.ToString(), "Can't open file", MessageBoxButtons.OK);
        \u003CModule\u003E.UnhookWindowsHookEx(\u003CModule\u003E.pGstruct14_6);
        this.textBox1.Text = new string((sbyte*) &\u003CModule\u003E.struct19_0);
        this.bool_2 = false;
      }
      else
      {
        \u003CModule\u003E.fseek(pGstruct5_0, 0, 2);
        int num1 = \u003CModule\u003E.ftell(pGstruct5_0);
        \u003CModule\u003E.rewind(pGstruct5_0);
        if (num1 != 512)
        {
          // ISSUE: cast to a function pointer type
          \u003CModule\u003E.pGstruct14_6 = \u003CModule\u003E.SetWindowsHookExA(5, (__FnPtr<int (int, uint, int)>) (IntPtr) \u003CModule\u003E.ppInt_4, (GStruct81*) 0, \u003CModule\u003E.GetCurrentThreadId());
          int num2 = (int) MessageBox.Show("Identify file should be 512 bytes", "Loading File", MessageBoxButtons.OK);
          \u003CModule\u003E.UnhookWindowsHookEx(\u003CModule\u003E.pGstruct14_6);
          \u003CModule\u003E.fclose(pGstruct5_0);
          this.textBox1.Text = new string((sbyte*) &\u003CModule\u003E.struct19_0);
          this.bool_2 = false;
        }
        else
        {
          Struct30 struct30;
          if ((int) \u003CModule\u003E.fread((void*) &struct30, 512U, 1U, pGstruct5_0) != 1)
          {
            // ISSUE: cast to a function pointer type
            \u003CModule\u003E.pGstruct14_6 = \u003CModule\u003E.SetWindowsHookExA(5, (__FnPtr<int (int, uint, int)>) (IntPtr) \u003CModule\u003E.ppInt_4, (GStruct81*) 0, \u003CModule\u003E.GetCurrentThreadId());
            int num2 = (int) MessageBox.Show("Identify file should be 512 bytes", "Loading File", MessageBoxButtons.OK);
            \u003CModule\u003E.UnhookWindowsHookEx(\u003CModule\u003E.pGstruct14_6);
            \u003CModule\u003E.fclose(pGstruct5_0);
            this.textBox1.Text = new string((sbyte*) &\u003CModule\u003E.struct19_0);
            this.bool_2 = false;
          }
          else
          {
            // ISSUE: explicit reference operation
            // ISSUE: cast to a reference type
            // ISSUE: explicit reference operation
            // ISSUE: cast to a reference type
            // ISSUE: explicit reference operation
            // ISSUE: cast to a reference type
            // ISSUE: explicit reference operation
            // ISSUE: cast to a reference type
            // ISSUE: explicit reference operation
            // ISSUE: cast to a reference type
            // ISSUE: explicit reference operation
            // ISSUE: cast to a reference type
            // ISSUE: explicit reference operation
            if ((int) ^(byte&) @struct30 == 192 && (int) ^(byte&) ((IntPtr) &struct30 + 1) == 133 && ((int) ^(byte&) ((IntPtr) &struct30 + 2) == 0 && (int) ^(byte&) ((IntPtr) &struct30 + 3) == 0) && ((int) ^(byte&) ((IntPtr) &struct30 + 4) == 0 && (int) ^(byte&) ((IntPtr) &struct30 + 5) == 0))
            {
              this.bool_2 = true;
              this.textBox1.Text = openFileDialog.FileName;
              if ((IntPtr) this.pByte_0 == IntPtr.Zero)
                this.pByte_0 = (byte*) \u003CModule\u003E.malloc(512U);
              \u003CModule\u003E.memcpy((void*) this.pByte_0, (void*) &struct30, 512U);
            }
            else
            {
              // ISSUE: cast to a function pointer type
              \u003CModule\u003E.pGstruct14_6 = \u003CModule\u003E.SetWindowsHookExA(5, (__FnPtr<int (int, uint, int)>) (IntPtr) \u003CModule\u003E.ppInt_4, (GStruct81*) 0, \u003CModule\u003E.GetCurrentThreadId());
              int num2 = (int) MessageBox.Show("Identify file is invalid!", "Loading File", MessageBoxButtons.OK);
              \u003CModule\u003E.UnhookWindowsHookEx(\u003CModule\u003E.pGstruct14_6);
              \u003CModule\u003E.fclose(pGstruct5_0);
              this.textBox1.Text = new string((sbyte*) &\u003CModule\u003E.struct19_0);
              this.bool_2 = false;
            }
          }
        }
      }
    }

    private unsafe void button2_Click(object sender, EventArgs e)
    {
      this.bool_3 = false;
      OpenFileDialog openFileDialog = new OpenFileDialog();
      openFileDialog.Filter = "Serial file (*.bin)|*.bin|All Files (*.*)|*.*";
      openFileDialog.FileName = "Serial.bin";
      openFileDialog.DefaultExt = ".bin";
      openFileDialog.CheckFileExists = true;
      openFileDialog.CheckPathExists = true;
      openFileDialog.RestoreDirectory = false;
      if (this.bool_4)
        openFileDialog.InitialDirectory = this.string_1;
      if (openFileDialog.ShowDialog() != DialogResult.OK)
        return;
      GStruct5* pGstruct5_0 = \u003CModule\u003E.fopen((sbyte*) (void*) Marshal.StringToHGlobalAnsi(Path.GetFullPath(openFileDialog.FileName)), (sbyte*) &\u003CModule\u003E.struct18_4);
      if ((IntPtr) pGstruct5_0 == IntPtr.Zero)
      {
        // ISSUE: cast to a function pointer type
        \u003CModule\u003E.pGstruct14_6 = \u003CModule\u003E.SetWindowsHookExA(5, (__FnPtr<int (int, uint, int)>) (IntPtr) \u003CModule\u003E.ppInt_4, (GStruct81*) 0, \u003CModule\u003E.GetCurrentThreadId());
        int num = (int) MessageBox.Show(openFileDialog.FileName.ToString(), "Can't open file", MessageBoxButtons.OK);
        \u003CModule\u003E.UnhookWindowsHookEx(\u003CModule\u003E.pGstruct14_6);
        this.textBox2.Text = new string((sbyte*) &\u003CModule\u003E.struct19_0);
        this.bool_3 = false;
      }
      else
      {
        \u003CModule\u003E.fseek(pGstruct5_0, 0, 2);
        int num1 = \u003CModule\u003E.ftell(pGstruct5_0);
        \u003CModule\u003E.rewind(pGstruct5_0);
        if (num1 != 80)
        {
          // ISSUE: cast to a function pointer type
          \u003CModule\u003E.pGstruct14_6 = \u003CModule\u003E.SetWindowsHookExA(5, (__FnPtr<int (int, uint, int)>) (IntPtr) \u003CModule\u003E.ppInt_4, (GStruct81*) 0, \u003CModule\u003E.GetCurrentThreadId());
          int num2 = (int) MessageBox.Show((IWin32Window) this, "Serial file should be 80 bytes", "Loading File", MessageBoxButtons.OK);
          \u003CModule\u003E.UnhookWindowsHookEx(\u003CModule\u003E.pGstruct14_6);
          \u003CModule\u003E.fclose(pGstruct5_0);
          this.textBox2.Text = new string((sbyte*) &\u003CModule\u003E.struct19_0);
          this.bool_3 = false;
        }
        else
        {
          Struct31 struct31;
          if ((int) \u003CModule\u003E.fread((void*) &struct31, 80U, 1U, pGstruct5_0) != 1)
          {
            // ISSUE: cast to a function pointer type
            \u003CModule\u003E.pGstruct14_6 = \u003CModule\u003E.SetWindowsHookExA(5, (__FnPtr<int (int, uint, int)>) (IntPtr) \u003CModule\u003E.ppInt_4, (GStruct81*) 0, \u003CModule\u003E.GetCurrentThreadId());
            int num2 = (int) MessageBox.Show("Serial file should be 80 bytes", "Loading File", MessageBoxButtons.OK);
            \u003CModule\u003E.UnhookWindowsHookEx(\u003CModule\u003E.pGstruct14_6);
            \u003CModule\u003E.fclose(pGstruct5_0);
            this.textBox2.Text = new string((sbyte*) &\u003CModule\u003E.struct19_0);
            this.bool_3 = false;
          }
          else
          {
            this.bool_3 = true;
            this.textBox2.Text = openFileDialog.FileName;
            if ((IntPtr) this.pByte_3 == IntPtr.Zero)
              this.pByte_3 = (byte*) \u003CModule\u003E.malloc(80U);
            \u003CModule\u003E.memcpy((void*) this.pByte_3, (void*) &struct31, 80U);
            \u003CModule\u003E.fclose(pGstruct5_0);
          }
        }
      }
    }

    private void textBox8_TextChanged(object sender, EventArgs e)
    {
      if (this.bool_0 && this.bool_1 && this.bool_2)
        this.button1.Enabled = true;
      else
        this.button1.Enabled = false;
    }

    private void textBox5_TextChanged(object sender, EventArgs e)
    {
      if (this.bool_0 && this.bool_1 && this.bool_2)
        this.button1.Enabled = true;
      else
        this.button1.Enabled = false;
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {
      if (this.bool_0 && this.bool_1 && this.bool_2)
        this.button1.Enabled = true;
      else
        this.button1.Enabled = false;
    }

    private unsafe void button1_Click(object sender, EventArgs e)
    {
      if (!this.bool_0 || !this.bool_1 || !this.bool_2)
        return;
      Struct34 struct34;
      // ISSUE: explicit reference operation
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      ^(sbyte&) @struct34 = sbyte.MaxValue;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      ^(sbyte&) ((IntPtr) &struct34 + 1) = (sbyte) -1;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      ^(sbyte&) ((IntPtr) &struct34 + 2) = (sbyte) -1;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      ^(sbyte&) ((IntPtr) &struct34 + 3) = (sbyte) -1;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      ^(sbyte&) ((IntPtr) &struct34 + 4) = (sbyte) -1;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      ^(sbyte&) ((IntPtr) &struct34 + 5) = (sbyte) -1;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      ^(sbyte&) ((IntPtr) &struct34 + 6) = (sbyte) -1;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      ^(sbyte&) ((IntPtr) &struct34 + 7) = (sbyte) -1;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      ^(sbyte&) ((IntPtr) &struct34 + 8) = (sbyte) -1;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      ^(sbyte&) ((IntPtr) &struct34 + 9) = (sbyte) -1;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      ^(sbyte&) ((IntPtr) &struct34 + 10) = (sbyte) -1;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      ^(sbyte&) ((IntPtr) &struct34 + 11) = (sbyte) -1;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      ^(sbyte&) ((IntPtr) &struct34 + 12) = (sbyte) -1;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      ^(sbyte&) ((IntPtr) &struct34 + 13) = (sbyte) -1;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      ^(sbyte&) ((IntPtr) &struct34 + 14) = (sbyte) -1;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      ^(sbyte&) ((IntPtr) &struct34 + 15) = (sbyte) -1;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      ^(sbyte&) ((IntPtr) &struct34 + 16) = (sbyte) -1;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      ^(sbyte&) ((IntPtr) &struct34 + 17) = (sbyte) -1;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      ^(sbyte&) ((IntPtr) &struct34 + 18) = (sbyte) -1;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      ^(sbyte&) ((IntPtr) &struct34 + 19) = (sbyte) -1;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      ^(sbyte&) ((IntPtr) &struct34 + 20) = (sbyte) -1;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      ^(sbyte&) ((IntPtr) &struct34 + 21) = (sbyte) -1;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      ^(sbyte&) ((IntPtr) &struct34 + 22) = (sbyte) -1;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      ^(sbyte&) ((IntPtr) &struct34 + 23) = (sbyte) -1;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      ^(sbyte&) ((IntPtr) &struct34 + 24) = (sbyte) -1;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      ^(sbyte&) ((IntPtr) &struct34 + 25) = (sbyte) -1;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      ^(sbyte&) ((IntPtr) &struct34 + 26) = (sbyte) -1;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      ^(sbyte&) ((IntPtr) &struct34 + 27) = (sbyte) -1;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      ^(sbyte&) ((IntPtr) &struct34 + 28) = (sbyte) -1;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      ^(sbyte&) ((IntPtr) &struct34 + 29) = (sbyte) -1;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      ^(sbyte&) ((IntPtr) &struct34 + 30) = (sbyte) -1;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      ^(sbyte&) ((IntPtr) &struct34 + 31) = (sbyte) -1;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      ^(sbyte&) ((IntPtr) &struct34 + 32) = (sbyte) 0;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      ^(sbyte&) ((IntPtr) &struct34 + 33) = (sbyte) 17;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      ^(sbyte&) ((IntPtr) &struct34 + 34) = (sbyte) 34;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      ^(sbyte&) ((IntPtr) &struct34 + 35) = (sbyte) 51;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      ^(sbyte&) ((IntPtr) &struct34 + 36) = (sbyte) 68;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      ^(sbyte&) ((IntPtr) &struct34 + 37) = (sbyte) 85;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      ^(sbyte&) ((IntPtr) &struct34 + 38) = (sbyte) 102;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      ^(sbyte&) ((IntPtr) &struct34 + 39) = (sbyte) 119;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      ^(sbyte&) ((IntPtr) &struct34 + 40) = (sbyte) -120;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      ^(sbyte&) ((IntPtr) &struct34 + 41) = (sbyte) -103;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      ^(sbyte&) ((IntPtr) &struct34 + 42) = (sbyte) -86;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      ^(sbyte&) ((IntPtr) &struct34 + 43) = (sbyte) -69;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      ^(sbyte&) ((IntPtr) &struct34 + 44) = (sbyte) -52;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      ^(sbyte&) ((IntPtr) &struct34 + 45) = (sbyte) -35;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      ^(sbyte&) ((IntPtr) &struct34 + 46) = (sbyte) -18;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      ^(sbyte&) ((IntPtr) &struct34 + 47) = (sbyte) -6;
      Struct28 struct28;
      // ISSUE: explicit reference operation
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      ^(sbyte&) @struct28 = (sbyte) 68;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      ^(sbyte&) ((IntPtr) &struct28 + 1) = (sbyte) 86;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      ^(sbyte&) ((IntPtr) &struct28 + 2) = (sbyte) 68;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      ^(sbyte&) ((IntPtr) &struct28 + 3) = (sbyte) 75;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      ^(sbyte&) ((IntPtr) &struct28 + 4) = (sbyte) 101;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      ^(sbyte&) ((IntPtr) &struct28 + 5) = (sbyte) 121;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      ^(sbyte&) ((IntPtr) &struct28 + 6) = (sbyte) 51;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      ^(sbyte&) ((IntPtr) &struct28 + 7) = (sbyte) 50;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      ^(sbyte&) ((IntPtr) &struct28 + 8) = (sbyte) 32;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      ^(sbyte&) ((IntPtr) &struct28 + 9) = (sbyte) 101;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      ^(sbyte&) ((IntPtr) &struct28 + 10) = (sbyte) 120;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      ^(sbyte&) ((IntPtr) &struct28 + 11) = (sbyte) 116;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      ^(sbyte&) ((IntPtr) &struct28 + 12) = (sbyte) 114;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      ^(sbyte&) ((IntPtr) &struct28 + 13) = (sbyte) 97;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      ^(sbyte&) ((IntPtr) &struct28 + 14) = (sbyte) 99;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      ^(sbyte&) ((IntPtr) &struct28 + 15) = (sbyte) 116;
      Struct30 struct30;
      \u003CModule\u003E.memcpy((void*) &struct30, (void*) this.pByte_0, 512U);
      int index = 46;
      while (index < 93)
      {
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        ^(sbyte&) ((IntPtr) &struct30 + index) = (sbyte) this.pByte_0[index + 1];
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        ^(sbyte&) ((IntPtr) &struct30 + (index + 1)) = (sbyte) this.pByte_0[index];
        index += 2;
      }
      Struct32 struct32;
      \u003CModule\u003E.memset((void*) &struct32, 0, 262144U);
      Struct33 struct33;
      \u003CModule\u003E.memset((void*) &struct33, (int) byte.MaxValue, 4096U);
      \u003CModule\u003E.memcpy((void*) ((IntPtr) &struct32 + 11264), (void*) &struct30, 512U);
      \u003CModule\u003E.memcpy((void*) ((IntPtr) &struct32 + 11776), (void*) this.pByte_1, 96U);
      \u003CModule\u003E.memcpy((void*) ((IntPtr) &struct32 + 24512), (void*) &struct28, 16U);
      \u003CModule\u003E.memcpy((void*) ((IntPtr) &struct32 + 40960), (void*) &struct33, 4096U);
      \u003CModule\u003E.memcpy((void*) ((IntPtr) &struct32 + 40960), (void*) &struct34, 48U);
      \u003CModule\u003E.memcpy((void*) ((IntPtr) &struct32 + 41008), (void*) this.pByte_2, 16U);
      \u003CModule\u003E.memset((void*) ((IntPtr) &struct32 + 130816), (int) byte.MaxValue, 80U);
      \u003CModule\u003E.memcpy((void*) ((IntPtr) &struct32 + 130816), (void*) (this.pByte_1 + 42), 20U);
      \u003CModule\u003E.memcpy((void*) ((IntPtr) &struct32 + 130856), (void*) (this.pByte_1 + 38), 2U);
      \u003CModule\u003E.memcpy((void*) ((IntPtr) &struct32 + 130892), (void*) (this.pByte_1 + 40), 2U);
      if (this.bool_3)
      {
        byte* numPtr1 = (byte*) ((IntPtr) &struct32 + 130816);
        byte* numPtr2 = this.pByte_3;
        \u003CModule\u003E.memcpy((void*) numPtr1, (void*) numPtr2, 80U);
        \u003CModule\u003E.memcpy((void*) ((IntPtr) &struct32 + 11284), (void*) numPtr2, 20U);
        \u003CModule\u003E.memcpy((void*) ((IntPtr) &struct32 + 11818), (void*) numPtr2, 20U);
        \u003CModule\u003E.memcpy((void*) ((IntPtr) &struct32 + 11814), (void*) (this.pByte_3 + 40), 2U);
        \u003CModule\u003E.memcpy((void*) ((IntPtr) &struct32 + 11816), (void*) (this.pByte_3 + 76), 2U);
      }
      if ((IntPtr) this.pByte_4 != IntPtr.Zero)
        \u003CModule\u003E.free((void*) this.pByte_4);
      this.pByte_4 = (byte*) \u003CModule\u003E.malloc(262144U);
      \u003CModule\u003E.memcpy((void*) this.pByte_4, (void*) &struct32, 262144U);
    }

    private unsafe void DumpFile_Closed(object sender, EventArgs e)
    {
      if ((IntPtr) this.pByte_0 != IntPtr.Zero)
        \u003CModule\u003E.free((void*) this.pByte_0);
      if ((IntPtr) this.pByte_1 != IntPtr.Zero)
        \u003CModule\u003E.free((void*) this.pByte_1);
      if ((IntPtr) this.pByte_1 == IntPtr.Zero)
        return;
      \u003CModule\u003E.free((void*) this.pByte_2);
    }
  }
}
