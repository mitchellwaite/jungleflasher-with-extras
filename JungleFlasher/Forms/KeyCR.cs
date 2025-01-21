// Type: ns0.KeyCR
// Assembly: JungleFlasher, Version=1.0.5004.40451, Culture=neutral, PublicKeyToken=7240d12d147b2b97
// MVID: 86B778B8-1293-454B-A759-8F0EBE32074A
// Assembly location: C:\Documents and Settings\User\Desktop\JungleFlasher-cleaned.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ns0
{
  public class KeyCR : Form
  {
    private Label label1;
    private Label label15;
    private Button button3;
    private Button button1;
    private TextBox textBox8;
    private TextBox textBox5;
    private Button button4;
    private Button button5;
    private Container container_0;
    public unsafe byte* pByte_0;
    public unsafe byte* pByte_1;
    public bool bool_0;
    public bool bool_1;
    public bool bool_2;
    public bool bool_3;
    public bool bool_4;
    public string string_0;

    public KeyCR()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KeyCR));
            this.label1 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(64, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 48;
            this.label1.Text = "C-R.bin";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(64, 25);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(88, 16);
            this.label15.TabIndex = 47;
            this.label15.Text = "Key.bin";
            // 
            // button3
            // 
            this.button3.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button3.Location = new System.Drawing.Point(136, 128);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 24);
            this.button3.TabIndex = 46;
            this.button3.Text = "Cancel";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Enabled = false;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(288, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 24);
            this.button1.TabIndex = 45;
            this.button1.Text = "OK";
            // 
            // textBox8
            // 
            this.textBox8.AllowDrop = true;
            this.textBox8.Location = new System.Drawing.Point(64, 41);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(424, 20);
            this.textBox8.TabIndex = 42;
            this.textBox8.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            this.textBox8.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBox8_DragDrop);
            this.textBox8.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBox8_DragEnter);
            // 
            // textBox5
            // 
            this.textBox5.AllowDrop = true;
            this.textBox5.Location = new System.Drawing.Point(64, 89);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(424, 20);
            this.textBox5.TabIndex = 39;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            this.textBox5.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBox5_DragDrop);
            this.textBox5.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBox5_DragEnter);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button4.Location = new System.Drawing.Point(16, 41);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(36, 20);
            this.button4.TabIndex = 41;
            this.button4.Text = "...";
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button5.Location = new System.Drawing.Point(16, 89);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(36, 20);
            this.button5.TabIndex = 40;
            this.button5.Text = "...";
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // KeyCR
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(504, 166);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KeyCR";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Load RGH Exports";
            this.Load += new System.EventHandler(this.KeyCR_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    private void label1_Click(object sender, EventArgs e)
    {
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
        openFileDialog.InitialDirectory = this.string_0;
      if (openFileDialog.ShowDialog() != DialogResult.OK)
        return;
      GStruct5* pGstruct5_0 = _Module.fopen((sbyte*) (void*) Marshal.StringToHGlobalAnsi(Path.GetFullPath(openFileDialog.FileName)), (sbyte*) &_Module.struct18_4);
      if ((IntPtr) pGstruct5_0 == IntPtr.Zero)
      {
        // ISSUE: cast to a function pointer type
        _Module.pGstruct14_11 = _Module.SetWindowsHookExA(5, (__FnPtr<int (int, uint, int)>) (IntPtr) _Module.ppInt_11, (GStruct81*) 0, _Module.GetCurrentThreadId());
        int num = (int) MessageBox.Show(openFileDialog.FileName.ToString(), "Can't open file", MessageBoxButtons.OK);
        _Module.UnhookWindowsHookEx(_Module.pGstruct14_11);
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
          _Module.pGstruct14_11 = _Module.SetWindowsHookExA(5, (__FnPtr<int (int, uint, int)>) (IntPtr) _Module.ppInt_11, (GStruct81*) 0, _Module.GetCurrentThreadId());
          int num2 = (int) MessageBox.Show("Key file should be 16 bytes", "Loading File", MessageBoxButtons.OK);
          _Module.UnhookWindowsHookEx(_Module.pGstruct14_11);
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
            _Module.pGstruct14_11 = _Module.SetWindowsHookExA(5, (__FnPtr<int (int, uint, int)>) (IntPtr) _Module.ppInt_11, (GStruct81*) 0, _Module.GetCurrentThreadId());
            int num2 = (int) MessageBox.Show("Key file should be 16 bytes", "Loading File", MessageBoxButtons.OK);
            _Module.UnhookWindowsHookEx(_Module.pGstruct14_11);
            _Module.fclose(pGstruct5_0);
            this.textBox8.Text = new string((sbyte*) &_Module.struct19_0);
            this.bool_0 = false;
          }
          else
          {
            this.bool_0 = true;
            this.textBox8.Text = openFileDialog.FileName;
            _Module.memcpy((void*) (this.pByte_0 + 126960), (void*) &struct28, 16U);
            _Module.fclose(pGstruct5_0);
          }
        }
      }
    }

    private unsafe void button5_Click(object sender, EventArgs e)
    {
      this.bool_1 = false;
      OpenFileDialog openFileDialog = new OpenFileDialog();
      openFileDialog.Filter = "CR File (*.bin)|*.bin|All Files (*.*)|*.*";
      openFileDialog.FileName = "C-R.bin";
      openFileDialog.DefaultExt = ".bin";
      openFileDialog.CheckFileExists = true;
      openFileDialog.CheckPathExists = true;
      openFileDialog.RestoreDirectory = false;
      if (this.bool_4)
        openFileDialog.InitialDirectory = this.string_0;
      if (openFileDialog.ShowDialog() != DialogResult.OK)
        return;
      GStruct5* pGstruct5_0 = _Module.fopen((sbyte*) (void*) Marshal.StringToHGlobalAnsi(Path.GetFullPath(openFileDialog.FileName)), (sbyte*) &_Module.struct18_4);
      if ((IntPtr) pGstruct5_0 == IntPtr.Zero)
      {
        // ISSUE: cast to a function pointer type
        _Module.pGstruct14_11 = _Module.SetWindowsHookExA(5, (__FnPtr<int (int, uint, int)>) (IntPtr) _Module.ppInt_11, (GStruct81*) 0, _Module.GetCurrentThreadId());
        int num = (int) MessageBox.Show(openFileDialog.FileName.ToString(), "Can't open file", MessageBoxButtons.OK);
        _Module.UnhookWindowsHookEx(_Module.pGstruct14_11);
        this.textBox5.Text = new string((sbyte*) &_Module.struct19_0);
        this.bool_1 = false;
      }
      else
      {
        _Module.fseek(pGstruct5_0, 0, 2);
        int num1 = _Module.ftell(pGstruct5_0);
        _Module.rewind(pGstruct5_0);
        if (num1 != 9538)
        {
          // ISSUE: cast to a function pointer type
          _Module.pGstruct14_11 = _Module.SetWindowsHookExA(5, (__FnPtr<int (int, uint, int)>) (IntPtr) _Module.ppInt_11, (GStruct81*) 0, _Module.GetCurrentThreadId());
          int num2 = (int) MessageBox.Show("CR file should be 9538 bytes", "Loading File", MessageBoxButtons.OK);
          _Module.UnhookWindowsHookEx(_Module.pGstruct14_11);
          _Module.fclose(pGstruct5_0);
          this.textBox5.Text = new string((sbyte*) &_Module.struct19_0);
          this.bool_1 = false;
        }
        else
        {
          Struct64 struct64;
          if ((int) _Module.fread((void*) &struct64, 9538U, 1U, pGstruct5_0) != 1)
          {
            // ISSUE: cast to a function pointer type
            _Module.pGstruct14_11 = _Module.SetWindowsHookExA(5, (__FnPtr<int (int, uint, int)>) (IntPtr) _Module.ppInt_11, (GStruct81*) 0, _Module.GetCurrentThreadId());
            int num2 = (int) MessageBox.Show("CR file should be 9538 bytes", "Loading File", MessageBoxButtons.OK);
            _Module.UnhookWindowsHookEx(_Module.pGstruct14_11);
            _Module.fclose(pGstruct5_0);
            this.textBox5.Text = new string((sbyte*) &_Module.struct19_0);
            this.bool_1 = false;
          }
          else
          {
            this.bool_1 = true;
            this.textBox5.Text = openFileDialog.FileName;
            _Module.memcpy((void*) (this.pByte_0 + 186624), (void*) &struct64, 9538U);
            _Module.fclose(pGstruct5_0);
          }
        }
      }
    }

    private void textBox8_TextChanged(object sender, EventArgs e)
    {
      if (this.bool_0 && this.bool_1)
        this.button1.Enabled = true;
      else
        this.button1.Enabled = false;
    }

    private void textBox5_TextChanged(object sender, EventArgs e)
    {
      if (this.bool_0 && this.bool_1)
        this.button1.Enabled = true;
      else
        this.button1.Enabled = false;
    }

    private unsafe void KeyCR_Load(object sender, EventArgs e)
    {
      if ((IntPtr) this.pByte_0 != IntPtr.Zero)
        _Module.free((void*) this.pByte_0);
      this.pByte_0 = (byte*) _Module.malloc(262144U);
    }

    private void textBox8_DragEnter(object sender, DragEventArgs e)
    {
      e.Effect = !e.Data.GetDataPresent(DataFormats.FileDrop) ? DragDropEffects.None : DragDropEffects.All;
      if (((string[]) e.Data.GetData(DataFormats.FileDrop)).Length <= 1)
        return;
      e.Effect = DragDropEffects.None;
    }

    private void textBox5_DragEnter(object sender, DragEventArgs e)
    {
      e.Effect = !e.Data.GetDataPresent(DataFormats.FileDrop) ? DragDropEffects.None : DragDropEffects.All;
      if (((string[]) e.Data.GetData(DataFormats.FileDrop)).Length <= 1)
        return;
      e.Effect = DragDropEffects.None;
    }

    private unsafe void textBox8_DragDrop(object sender, DragEventArgs e)
    {
      string str = (string) null;
      this.bool_0 = false;
      this.textBox8.Clear();
      string[] strArray = (string[]) e.Data.GetData(DataFormats.FileDrop);
      str = strArray[0];
      GStruct5* pGstruct5_0 = _Module.fopen((sbyte*) (void*) Marshal.StringToHGlobalAnsi(Path.GetFullPath(strArray[0])), (sbyte*) &_Module.struct18_4);
      if ((IntPtr) pGstruct5_0 == IntPtr.Zero)
      {
        // ISSUE: cast to a function pointer type
        _Module.pGstruct14_11 = _Module.SetWindowsHookExA(5, (__FnPtr<int (int, uint, int)>) (IntPtr) _Module.ppInt_11, (GStruct81*) 0, _Module.GetCurrentThreadId());
        int num = (int) MessageBox.Show(strArray[0], "Can't open file", MessageBoxButtons.OK);
        _Module.UnhookWindowsHookEx(_Module.pGstruct14_11);
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
          _Module.pGstruct14_11 = _Module.SetWindowsHookExA(5, (__FnPtr<int (int, uint, int)>) (IntPtr) _Module.ppInt_11, (GStruct81*) 0, _Module.GetCurrentThreadId());
          int num2 = (int) MessageBox.Show("Key file should be 16 bytes", "Loading File", MessageBoxButtons.OK);
          _Module.UnhookWindowsHookEx(_Module.pGstruct14_11);
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
            _Module.pGstruct14_11 = _Module.SetWindowsHookExA(5, (__FnPtr<int (int, uint, int)>) (IntPtr) _Module.ppInt_11, (GStruct81*) 0, _Module.GetCurrentThreadId());
            int num2 = (int) MessageBox.Show("Key file should be 16 bytes", "Loading File", MessageBoxButtons.OK);
            _Module.UnhookWindowsHookEx(_Module.pGstruct14_11);
            _Module.fclose(pGstruct5_0);
            this.textBox8.Text = new string((sbyte*) &_Module.struct19_0);
            this.bool_0 = false;
          }
          else
          {
            this.bool_0 = true;
            this.textBox8.Text = strArray[0];
            _Module.memcpy((void*) (this.pByte_0 + 126960), (void*) &struct28, 16U);
            _Module.fclose(pGstruct5_0);
          }
        }
      }
    }

    private unsafe void textBox5_DragDrop(object sender, DragEventArgs e)
    {
      string str = (string) null;
      this.bool_1 = false;
      this.textBox5.Clear();
      string[] strArray = (string[]) e.Data.GetData(DataFormats.FileDrop);
      str = strArray[0];
      GStruct5* pGstruct5_0 = _Module.fopen((sbyte*) (void*) Marshal.StringToHGlobalAnsi(Path.GetFullPath(strArray[0])), (sbyte*) &_Module.struct18_4);
      if ((IntPtr) pGstruct5_0 == IntPtr.Zero)
      {
        // ISSUE: cast to a function pointer type
        _Module.pGstruct14_11 = _Module.SetWindowsHookExA(5, (__FnPtr<int (int, uint, int)>) (IntPtr) _Module.ppInt_11, (GStruct81*) 0, _Module.GetCurrentThreadId());
        int num = (int) MessageBox.Show(strArray[0], "Can't open file", MessageBoxButtons.OK);
        _Module.UnhookWindowsHookEx(_Module.pGstruct14_11);
        this.textBox5.Text = new string((sbyte*) &_Module.struct19_0);
        this.bool_1 = false;
      }
      else
      {
        _Module.fseek(pGstruct5_0, 0, 2);
        int num1 = _Module.ftell(pGstruct5_0);
        _Module.rewind(pGstruct5_0);
        if (num1 != 9538)
        {
          // ISSUE: cast to a function pointer type
          _Module.pGstruct14_11 = _Module.SetWindowsHookExA(5, (__FnPtr<int (int, uint, int)>) (IntPtr) _Module.ppInt_11, (GStruct81*) 0, _Module.GetCurrentThreadId());
          int num2 = (int) MessageBox.Show("CR file should be 9538 bytes", "Loading File", MessageBoxButtons.OK);
          _Module.UnhookWindowsHookEx(_Module.pGstruct14_11);
          _Module.fclose(pGstruct5_0);
          this.textBox5.Text = new string((sbyte*) &_Module.struct19_0);
          this.bool_1 = false;
        }
        else
        {
          Struct64 struct64;
          if ((int) _Module.fread((void*) &struct64, 9538U, 1U, pGstruct5_0) != 1)
          {
            // ISSUE: cast to a function pointer type
            _Module.pGstruct14_11 = _Module.SetWindowsHookExA(5, (__FnPtr<int (int, uint, int)>) (IntPtr) _Module.ppInt_11, (GStruct81*) 0, _Module.GetCurrentThreadId());
            int num2 = (int) MessageBox.Show("CR file should be 9538 bytes", "Loading File", MessageBoxButtons.OK);
            _Module.UnhookWindowsHookEx(_Module.pGstruct14_11);
            _Module.fclose(pGstruct5_0);
            this.textBox5.Text = new string((sbyte*) &_Module.struct19_0);
            this.bool_1 = false;
          }
          else
          {
            this.bool_1 = true;
            this.textBox5.Text = strArray[0];
            _Module.memcpy((void*) (this.pByte_0 + 186624), (void*) &struct64, 9538U);
            _Module.fclose(pGstruct5_0);
          }
        }
      }
    }
  }
}
