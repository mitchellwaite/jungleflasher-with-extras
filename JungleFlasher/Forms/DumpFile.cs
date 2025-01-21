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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DumpFile));
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(64, 72);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(424, 20);
            this.textBox5.TabIndex = 23;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button5.Location = new System.Drawing.Point(16, 72);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(36, 20);
            this.button5.TabIndex = 24;
            this.button5.Text = "...";
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button4.Location = new System.Drawing.Point(16, 24);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(36, 20);
            this.button4.TabIndex = 25;
            this.button4.Text = "...";
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(64, 24);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(424, 20);
            this.textBox8.TabIndex = 26;
            this.textBox8.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // button7
            // 
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button7.Location = new System.Drawing.Point(16, 120);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(36, 20);
            this.button7.TabIndex = 27;
            this.button7.Text = "...";
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(64, 120);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(424, 20);
            this.textBox1.TabIndex = 28;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Enabled = false;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(288, 200);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 24);
            this.button1.TabIndex = 30;
            this.button1.Text = "OK";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button3.Location = new System.Drawing.Point(136, 200);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 24);
            this.button3.TabIndex = 32;
            this.button3.Text = "Cancel";
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(64, 8);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(88, 16);
            this.label15.TabIndex = 33;
            this.label15.Text = "Key.bin";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(64, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 34;
            this.label1.Text = "Inquiry.bin";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(64, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 35;
            this.label2.Text = "Identify.bin";
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Location = new System.Drawing.Point(16, 168);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(36, 20);
            this.button2.TabIndex = 36;
            this.button2.Text = "...";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(64, 168);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(424, 20);
            this.textBox2.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(64, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 38;
            this.label3.Text = "Serial.bin";
            // 
            // DumpFile
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(506, 240);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(150, 150);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DumpFile";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Load DVDKey Extracts";
            this.Closed += new System.EventHandler(this.DumpFile_Closed);
            this.Load += new System.EventHandler(this.DumpFile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    private unsafe void DumpFile_Load(object sender, EventArgs e)
    {
      string text = "You are about to generate a Dummy.bin from previously     " + "\n" + "dumped files. This is intended for Legacy support only " + "\n" + "and creating a Dummy.bin in this way will mean " + "\n" + "certain drive specific info will be missing!" + "\n" + "Only use this method if the drive is no longer available." + "\n\n" + "If possible you should re-extract your drive info with the" + "\n" + "latest tools.." + new string((sbyte*) &_Module.struct6_7) + "        1. JungleFlasher, this tool - DVDKey32 Tab" + "\n" + "        2. Dosflash 1.7+" + "\n" + "        3. DVDKey32 0.7+" + "\n" + "Do you wish to proceed anyway ?" + "\n";
      // ISSUE: cast to a function pointer type
      _Module.pGstruct14_6 = _Module.SetWindowsHookExA(5, (__FnPtr<int (int, uint, int)>) (IntPtr) _Module.ppInt_4, (GStruct81*) 0, _Module.GetCurrentThreadId());
      int num = (int) MessageBox.Show(text, "Load from dump files", MessageBoxButtons.YesNo, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button2);
      _Module.UnhookWindowsHookEx(_Module.pGstruct14_6);
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
      GStruct5* pGstruct5_0 = _Module.fopen((sbyte*) (void*) Marshal.StringToHGlobalAnsi(Path.GetFullPath(openFileDialog.FileName)), (sbyte*) &_Module.struct18_4);
      if ((IntPtr) pGstruct5_0 == IntPtr.Zero)
      {
        // ISSUE: cast to a function pointer type
        _Module.pGstruct14_6 = _Module.SetWindowsHookExA(5, (__FnPtr<int (int, uint, int)>) (IntPtr) _Module.ppInt_4, (GStruct81*) 0, _Module.GetCurrentThreadId());
        int num = (int) MessageBox.Show(openFileDialog.FileName.ToString(), "Can't open file", MessageBoxButtons.OK);
        _Module.UnhookWindowsHookEx(_Module.pGstruct14_6);
        this.textBox8.Text = new string((sbyte*) &_Module.struct19_0);
        this.bool_0 = false;
      }
      else
      {
        _Module.fseek(pGstruct5_0, 0, 2);
        int num1 = _Module.ftell(pGstruct5_0);
        _Module.rewind(pGstruct5_0);
        if (num1 != 16)
        {
          // ISSUE: cast to a function pointer type
          _Module.pGstruct14_6 = _Module.SetWindowsHookExA(5, (__FnPtr<int (int, uint, int)>) (IntPtr) _Module.ppInt_4, (GStruct81*) 0, _Module.GetCurrentThreadId());
          int num2 = (int) MessageBox.Show("Key file should be 16 bytes", "Loading File", MessageBoxButtons.OK);
          _Module.UnhookWindowsHookEx(_Module.pGstruct14_6);
          _Module.fclose(pGstruct5_0);
          this.textBox8.Text = new string((sbyte*) &_Module.struct19_0);
          this.bool_0 = false;
        }
        else
        {
          Struct28 struct28;
          if ((int) _Module.fread((void*) &struct28, 16U, 1U, pGstruct5_0) != 1)
          {
            // ISSUE: cast to a function pointer type
            _Module.pGstruct14_6 = _Module.SetWindowsHookExA(5, (__FnPtr<int (int, uint, int)>) (IntPtr) _Module.ppInt_4, (GStruct81*) 0, _Module.GetCurrentThreadId());
            int num2 = (int) MessageBox.Show("Key file should be 16 bytes", "Loading File", MessageBoxButtons.OK);
            _Module.UnhookWindowsHookEx(_Module.pGstruct14_6);
            _Module.fclose(pGstruct5_0);
            this.textBox8.Text = new string((sbyte*) &_Module.struct19_0);
            this.bool_0 = false;
          }
          else
          {
            this.bool_0 = true;
            this.textBox8.Text = openFileDialog.FileName;
            if ((IntPtr) this.pByte_2 == IntPtr.Zero)
              this.pByte_2 = (byte*) _Module.malloc(16U);
            _Module.memcpy((void*) this.pByte_2, (void*) &struct28, 16U);
            _Module.fclose(pGstruct5_0);
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
      GStruct5* pGstruct5_0 = _Module.fopen((sbyte*) (void*) Marshal.StringToHGlobalAnsi(Path.GetFullPath(openFileDialog.FileName)), (sbyte*) &_Module.struct18_4);
      if ((IntPtr) pGstruct5_0 == IntPtr.Zero)
      {
        // ISSUE: cast to a function pointer type
        _Module.pGstruct14_6 = _Module.SetWindowsHookExA(5, (__FnPtr<int (int, uint, int)>) (IntPtr) _Module.ppInt_4, (GStruct81*) 0, _Module.GetCurrentThreadId());
        int num = (int) MessageBox.Show(openFileDialog.FileName.ToString(), "Can't open file", MessageBoxButtons.OK);
        _Module.UnhookWindowsHookEx(_Module.pGstruct14_6);
        this.textBox5.Text = new string((sbyte*) &_Module.struct19_0);
        this.bool_1 = false;
      }
      else
      {
        _Module.fseek(pGstruct5_0, 0, 2);
        int num1 = _Module.ftell(pGstruct5_0);
        _Module.rewind(pGstruct5_0);
        if (num1 != 96)
        {
          // ISSUE: cast to a function pointer type
          _Module.pGstruct14_6 = _Module.SetWindowsHookExA(5, (__FnPtr<int (int, uint, int)>) (IntPtr) _Module.ppInt_4, (GStruct81*) 0, _Module.GetCurrentThreadId());
          int num2 = (int) MessageBox.Show((IWin32Window) this, "Inquiry file should be 96 bytes", "Loading File", MessageBoxButtons.OK);
          _Module.UnhookWindowsHookEx(_Module.pGstruct14_6);
          _Module.fclose(pGstruct5_0);
          this.textBox5.Text = new string((sbyte*) &_Module.struct19_0);
          this.bool_1 = false;
        }
        else
        {
          Struct29 struct29;
          if ((int) _Module.fread((void*) &struct29, 96U, 1U, pGstruct5_0) != 1)
          {
            // ISSUE: cast to a function pointer type
            _Module.pGstruct14_6 = _Module.SetWindowsHookExA(5, (__FnPtr<int (int, uint, int)>) (IntPtr) _Module.ppInt_4, (GStruct81*) 0, _Module.GetCurrentThreadId());
            int num2 = (int) MessageBox.Show("Inquiry file should be 96 bytes", "Loading File", MessageBoxButtons.OK);
            _Module.UnhookWindowsHookEx(_Module.pGstruct14_6);
            _Module.fclose(pGstruct5_0);
            this.textBox5.Text = new string((sbyte*) &_Module.struct19_0);
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
                this.pByte_1 = (byte*) _Module.malloc(96U);
              _Module.memcpy((void*) this.pByte_1, (void*) &struct29, 96U);
              _Module.fclose(pGstruct5_0);
            }
            else
            {
              // ISSUE: cast to a function pointer type
              _Module.pGstruct14_6 = _Module.SetWindowsHookExA(5, (__FnPtr<int (int, uint, int)>) (IntPtr) _Module.ppInt_4, (GStruct81*) 0, _Module.GetCurrentThreadId());
              int num2 = (int) MessageBox.Show("Inquiry file is invalid!", "Loading File", MessageBoxButtons.OK);
              _Module.UnhookWindowsHookEx(_Module.pGstruct14_6);
              _Module.fclose(pGstruct5_0);
              this.textBox5.Text = new string((sbyte*) &_Module.struct19_0);
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
      GStruct5* pGstruct5_0 = _Module.fopen((sbyte*) (void*) Marshal.StringToHGlobalAnsi(Path.GetFullPath(openFileDialog.FileName)), (sbyte*) &_Module.struct18_4);
      if ((IntPtr) pGstruct5_0 == IntPtr.Zero)
      {
        // ISSUE: cast to a function pointer type
        _Module.pGstruct14_6 = _Module.SetWindowsHookExA(5, (__FnPtr<int (int, uint, int)>) (IntPtr) _Module.ppInt_4, (GStruct81*) 0, _Module.GetCurrentThreadId());
        int num = (int) MessageBox.Show(openFileDialog.FileName.ToString(), "Can't open file", MessageBoxButtons.OK);
        _Module.UnhookWindowsHookEx(_Module.pGstruct14_6);
        this.textBox1.Text = new string((sbyte*) &_Module.struct19_0);
        this.bool_2 = false;
      }
      else
      {
        _Module.fseek(pGstruct5_0, 0, 2);
        int num1 = _Module.ftell(pGstruct5_0);
        _Module.rewind(pGstruct5_0);
        if (num1 != 512)
        {
          // ISSUE: cast to a function pointer type
          _Module.pGstruct14_6 = _Module.SetWindowsHookExA(5, (__FnPtr<int (int, uint, int)>) (IntPtr) _Module.ppInt_4, (GStruct81*) 0, _Module.GetCurrentThreadId());
          int num2 = (int) MessageBox.Show("Identify file should be 512 bytes", "Loading File", MessageBoxButtons.OK);
          _Module.UnhookWindowsHookEx(_Module.pGstruct14_6);
          _Module.fclose(pGstruct5_0);
          this.textBox1.Text = new string((sbyte*) &_Module.struct19_0);
          this.bool_2 = false;
        }
        else
        {
          Struct30 struct30;
          if ((int) _Module.fread((void*) &struct30, 512U, 1U, pGstruct5_0) != 1)
          {
            // ISSUE: cast to a function pointer type
            _Module.pGstruct14_6 = _Module.SetWindowsHookExA(5, (__FnPtr<int (int, uint, int)>) (IntPtr) _Module.ppInt_4, (GStruct81*) 0, _Module.GetCurrentThreadId());
            int num2 = (int) MessageBox.Show("Identify file should be 512 bytes", "Loading File", MessageBoxButtons.OK);
            _Module.UnhookWindowsHookEx(_Module.pGstruct14_6);
            _Module.fclose(pGstruct5_0);
            this.textBox1.Text = new string((sbyte*) &_Module.struct19_0);
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
                this.pByte_0 = (byte*) _Module.malloc(512U);
              _Module.memcpy((void*) this.pByte_0, (void*) &struct30, 512U);
            }
            else
            {
              // ISSUE: cast to a function pointer type
              _Module.pGstruct14_6 = _Module.SetWindowsHookExA(5, (__FnPtr<int (int, uint, int)>) (IntPtr) _Module.ppInt_4, (GStruct81*) 0, _Module.GetCurrentThreadId());
              int num2 = (int) MessageBox.Show("Identify file is invalid!", "Loading File", MessageBoxButtons.OK);
              _Module.UnhookWindowsHookEx(_Module.pGstruct14_6);
              _Module.fclose(pGstruct5_0);
              this.textBox1.Text = new string((sbyte*) &_Module.struct19_0);
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
      GStruct5* pGstruct5_0 = _Module.fopen((sbyte*) (void*) Marshal.StringToHGlobalAnsi(Path.GetFullPath(openFileDialog.FileName)), (sbyte*) &_Module.struct18_4);
      if ((IntPtr) pGstruct5_0 == IntPtr.Zero)
      {
        // ISSUE: cast to a function pointer type
        _Module.pGstruct14_6 = _Module.SetWindowsHookExA(5, (__FnPtr<int (int, uint, int)>) (IntPtr) _Module.ppInt_4, (GStruct81*) 0, _Module.GetCurrentThreadId());
        int num = (int) MessageBox.Show(openFileDialog.FileName.ToString(), "Can't open file", MessageBoxButtons.OK);
        _Module.UnhookWindowsHookEx(_Module.pGstruct14_6);
        this.textBox2.Text = new string((sbyte*) &_Module.struct19_0);
        this.bool_3 = false;
      }
      else
      {
        _Module.fseek(pGstruct5_0, 0, 2);
        int num1 = _Module.ftell(pGstruct5_0);
        _Module.rewind(pGstruct5_0);
        if (num1 != 80)
        {
          // ISSUE: cast to a function pointer type
          _Module.pGstruct14_6 = _Module.SetWindowsHookExA(5, (__FnPtr<int (int, uint, int)>) (IntPtr) _Module.ppInt_4, (GStruct81*) 0, _Module.GetCurrentThreadId());
          int num2 = (int) MessageBox.Show((IWin32Window) this, "Serial file should be 80 bytes", "Loading File", MessageBoxButtons.OK);
          _Module.UnhookWindowsHookEx(_Module.pGstruct14_6);
          _Module.fclose(pGstruct5_0);
          this.textBox2.Text = new string((sbyte*) &_Module.struct19_0);
          this.bool_3 = false;
        }
        else
        {
          Struct31 struct31;
          if ((int) _Module.fread((void*) &struct31, 80U, 1U, pGstruct5_0) != 1)
          {
            // ISSUE: cast to a function pointer type
            _Module.pGstruct14_6 = _Module.SetWindowsHookExA(5, (__FnPtr<int (int, uint, int)>) (IntPtr) _Module.ppInt_4, (GStruct81*) 0, _Module.GetCurrentThreadId());
            int num2 = (int) MessageBox.Show("Serial file should be 80 bytes", "Loading File", MessageBoxButtons.OK);
            _Module.UnhookWindowsHookEx(_Module.pGstruct14_6);
            _Module.fclose(pGstruct5_0);
            this.textBox2.Text = new string((sbyte*) &_Module.struct19_0);
            this.bool_3 = false;
          }
          else
          {
            this.bool_3 = true;
            this.textBox2.Text = openFileDialog.FileName;
            if ((IntPtr) this.pByte_3 == IntPtr.Zero)
              this.pByte_3 = (byte*) _Module.malloc(80U);
            _Module.memcpy((void*) this.pByte_3, (void*) &struct31, 80U);
            _Module.fclose(pGstruct5_0);
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
      _Module.memcpy((void*) &struct30, (void*) this.pByte_0, 512U);
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
      _Module.memset((void*) &struct32, 0, 262144U);
      Struct33 struct33;
      _Module.memset((void*) &struct33, (int) byte.MaxValue, 4096U);
      _Module.memcpy((void*) ((IntPtr) &struct32 + 11264), (void*) &struct30, 512U);
      _Module.memcpy((void*) ((IntPtr) &struct32 + 11776), (void*) this.pByte_1, 96U);
      _Module.memcpy((void*) ((IntPtr) &struct32 + 24512), (void*) &struct28, 16U);
      _Module.memcpy((void*) ((IntPtr) &struct32 + 40960), (void*) &struct33, 4096U);
      _Module.memcpy((void*) ((IntPtr) &struct32 + 40960), (void*) &struct34, 48U);
      _Module.memcpy((void*) ((IntPtr) &struct32 + 41008), (void*) this.pByte_2, 16U);
      _Module.memset((void*) ((IntPtr) &struct32 + 130816), (int) byte.MaxValue, 80U);
      _Module.memcpy((void*) ((IntPtr) &struct32 + 130816), (void*) (this.pByte_1 + 42), 20U);
      _Module.memcpy((void*) ((IntPtr) &struct32 + 130856), (void*) (this.pByte_1 + 38), 2U);
      _Module.memcpy((void*) ((IntPtr) &struct32 + 130892), (void*) (this.pByte_1 + 40), 2U);
      if (this.bool_3)
      {
        byte* numPtr1 = (byte*) ((IntPtr) &struct32 + 130816);
        byte* numPtr2 = this.pByte_3;
        _Module.memcpy((void*) numPtr1, (void*) numPtr2, 80U);
        _Module.memcpy((void*) ((IntPtr) &struct32 + 11284), (void*) numPtr2, 20U);
        _Module.memcpy((void*) ((IntPtr) &struct32 + 11818), (void*) numPtr2, 20U);
        _Module.memcpy((void*) ((IntPtr) &struct32 + 11814), (void*) (this.pByte_3 + 40), 2U);
        _Module.memcpy((void*) ((IntPtr) &struct32 + 11816), (void*) (this.pByte_3 + 76), 2U);
      }
      if ((IntPtr) this.pByte_4 != IntPtr.Zero)
        _Module.free((void*) this.pByte_4);
      this.pByte_4 = (byte*) _Module.malloc(262144U);
      _Module.memcpy((void*) this.pByte_4, (void*) &struct32, 262144U);
    }

    private unsafe void DumpFile_Closed(object sender, EventArgs e)
    {
      if ((IntPtr) this.pByte_0 != IntPtr.Zero)
        _Module.free((void*) this.pByte_0);
      if ((IntPtr) this.pByte_1 != IntPtr.Zero)
        _Module.free((void*) this.pByte_1);
      if ((IntPtr) this.pByte_1 == IntPtr.Zero)
        return;
      _Module.free((void*) this.pByte_2);
    }
  }
}
