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
      this.label1 = new Label();
      this.label15 = new Label();
      this.button3 = new Button();
      this.button1 = new Button();
      this.textBox8 = new TextBox();
      this.textBox5 = new TextBox();
      this.button4 = new Button();
      this.button5 = new Button();
      this.SuspendLayout();
      Point point1 = new Point();
      point1 = new Point(64, 73);
      this.label1.Location = point1;
      this.label1.Name = "label1";
      Size size1 = new Size();
      size1 = new Size(88, 16);
      this.label1.Size = size1;
      this.label1.TabIndex = 48;
      this.label1.Text = "C-R.bin";
      this.label1.Click += new EventHandler(this.label1_Click);
      Point point2 = new Point();
      point2 = new Point(64, 25);
      this.label15.Location = point2;
      this.label15.Name = "label15";
      Size size2 = new Size();
      size2 = new Size(88, 16);
      this.label15.Size = size2;
      this.label15.TabIndex = 47;
      this.label15.Text = "Key.bin";
      this.button3.DialogResult = DialogResult.Cancel;
      this.button3.FlatStyle = FlatStyle.System;
      Point point3 = new Point();
      point3 = new Point(136, 128);
      this.button3.Location = point3;
      this.button3.Name = "button3";
      Size size3 = new Size();
      size3 = new Size(80, 24);
      this.button3.Size = size3;
      this.button3.TabIndex = 46;
      this.button3.Text = "Cancel";
      this.button1.DialogResult = DialogResult.OK;
      this.button1.Enabled = false;
      this.button1.FlatStyle = FlatStyle.System;
      Point point4 = new Point();
      point4 = new Point(288, 128);
      this.button1.Location = point4;
      this.button1.Name = "button1";
      Size size4 = new Size();
      size4 = new Size(80, 24);
      this.button1.Size = size4;
      this.button1.TabIndex = 45;
      this.button1.Text = "OK";
      this.textBox8.AllowDrop = true;
      Point point5 = new Point();
      point5 = new Point(64, 41);
      this.textBox8.Location = point5;
      this.textBox8.Name = "textBox8";
      this.textBox8.ReadOnly = true;
      Size size5 = new Size();
      size5 = new Size(424, 20);
      this.textBox8.Size = size5;
      this.textBox8.TabIndex = 42;
      this.textBox8.Text = "";
      this.textBox8.DragDrop += new DragEventHandler(this.textBox8_DragDrop);
      this.textBox8.TextChanged += new EventHandler(this.textBox8_TextChanged);
      this.textBox8.DragEnter += new DragEventHandler(this.textBox8_DragEnter);
      this.textBox5.AllowDrop = true;
      Point point6 = new Point();
      point6 = new Point(64, 89);
      this.textBox5.Location = point6;
      this.textBox5.Name = "textBox5";
      this.textBox5.ReadOnly = true;
      Size size6 = new Size();
      size6 = new Size(424, 20);
      this.textBox5.Size = size6;
      this.textBox5.TabIndex = 39;
      this.textBox5.Text = "";
      this.textBox5.DragDrop += new DragEventHandler(this.textBox5_DragDrop);
      this.textBox5.TextChanged += new EventHandler(this.textBox5_TextChanged);
      this.textBox5.DragEnter += new DragEventHandler(this.textBox5_DragEnter);
      this.button4.FlatStyle = FlatStyle.System;
      Point point7 = new Point();
      point7 = new Point(16, 41);
      this.button4.Location = point7;
      this.button4.Name = "button4";
      Size size7 = new Size();
      size7 = new Size(36, 20);
      this.button4.Size = size7;
      this.button4.TabIndex = 41;
      this.button4.Text = "...";
      this.button4.Click += new EventHandler(this.button4_Click);
      this.button5.FlatStyle = FlatStyle.System;
      Point point8 = new Point();
      point8 = new Point(16, 89);
      this.button5.Location = point8;
      this.button5.Name = "button5";
      Size size8 = new Size();
      size8 = new Size(36, 20);
      this.button5.Size = size8;
      this.button5.TabIndex = 40;
      this.button5.Text = "...";
      this.button5.Click += new EventHandler(this.button5_Click);
      Size size9 = new Size();
      size9 = new Size(5, 13);
      this.AutoScaleBaseSize = size9;
      Size size10 = new Size();
      size10 = new Size(504, 166);
      this.ClientSize = size10;
      this.ControlBox = false;
      this.Controls.Add((Control) this.label1);
      this.Controls.Add((Control) this.label15);
      this.Controls.Add((Control) this.button3);
      this.Controls.Add((Control) this.button1);
      this.Controls.Add((Control) this.textBox8);
      this.Controls.Add((Control) this.textBox5);
      this.Controls.Add((Control) this.button4);
      this.Controls.Add((Control) this.button5);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "KeyCR";
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "Load RGH Exports";
      this.Load += new EventHandler(this.KeyCR_Load);
      this.ResumeLayout(false);
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
      GStruct5* pGstruct5_0 = \u003CModule\u003E.fopen((sbyte*) (void*) Marshal.StringToHGlobalAnsi(Path.GetFullPath(openFileDialog.FileName)), (sbyte*) &\u003CModule\u003E.struct18_4);
      if ((IntPtr) pGstruct5_0 == IntPtr.Zero)
      {
        // ISSUE: cast to a function pointer type
        \u003CModule\u003E.pGstruct14_11 = \u003CModule\u003E.SetWindowsHookExA(5, (__FnPtr<int (int, uint, int)>) (IntPtr) \u003CModule\u003E.ppInt_11, (GStruct81*) 0, \u003CModule\u003E.GetCurrentThreadId());
        int num = (int) MessageBox.Show(openFileDialog.FileName.ToString(), "Can't open file", MessageBoxButtons.OK);
        \u003CModule\u003E.UnhookWindowsHookEx(\u003CModule\u003E.pGstruct14_11);
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
          \u003CModule\u003E.pGstruct14_11 = \u003CModule\u003E.SetWindowsHookExA(5, (__FnPtr<int (int, uint, int)>) (IntPtr) \u003CModule\u003E.ppInt_11, (GStruct81*) 0, \u003CModule\u003E.GetCurrentThreadId());
          int num2 = (int) MessageBox.Show("Key file should be 16 bytes", "Loading File", MessageBoxButtons.OK);
          \u003CModule\u003E.UnhookWindowsHookEx(\u003CModule\u003E.pGstruct14_11);
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
            \u003CModule\u003E.pGstruct14_11 = \u003CModule\u003E.SetWindowsHookExA(5, (__FnPtr<int (int, uint, int)>) (IntPtr) \u003CModule\u003E.ppInt_11, (GStruct81*) 0, \u003CModule\u003E.GetCurrentThreadId());
            int num2 = (int) MessageBox.Show("Key file should be 16 bytes", "Loading File", MessageBoxButtons.OK);
            \u003CModule\u003E.UnhookWindowsHookEx(\u003CModule\u003E.pGstruct14_11);
            \u003CModule\u003E.fclose(pGstruct5_0);
            this.textBox8.Text = new string((sbyte*) &\u003CModule\u003E.struct19_0);
            this.bool_0 = false;
          }
          else
          {
            this.bool_0 = true;
            this.textBox8.Text = openFileDialog.FileName;
            \u003CModule\u003E.memcpy((void*) (this.pByte_0 + 126960), (void*) &struct28, 16U);
            \u003CModule\u003E.fclose(pGstruct5_0);
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
      GStruct5* pGstruct5_0 = \u003CModule\u003E.fopen((sbyte*) (void*) Marshal.StringToHGlobalAnsi(Path.GetFullPath(openFileDialog.FileName)), (sbyte*) &\u003CModule\u003E.struct18_4);
      if ((IntPtr) pGstruct5_0 == IntPtr.Zero)
      {
        // ISSUE: cast to a function pointer type
        \u003CModule\u003E.pGstruct14_11 = \u003CModule\u003E.SetWindowsHookExA(5, (__FnPtr<int (int, uint, int)>) (IntPtr) \u003CModule\u003E.ppInt_11, (GStruct81*) 0, \u003CModule\u003E.GetCurrentThreadId());
        int num = (int) MessageBox.Show(openFileDialog.FileName.ToString(), "Can't open file", MessageBoxButtons.OK);
        \u003CModule\u003E.UnhookWindowsHookEx(\u003CModule\u003E.pGstruct14_11);
        this.textBox5.Text = new string((sbyte*) &\u003CModule\u003E.struct19_0);
        this.bool_1 = false;
      }
      else
      {
        \u003CModule\u003E.fseek(pGstruct5_0, 0, 2);
        int num1 = \u003CModule\u003E.ftell(pGstruct5_0);
        \u003CModule\u003E.rewind(pGstruct5_0);
        if (num1 != 9538)
        {
          // ISSUE: cast to a function pointer type
          \u003CModule\u003E.pGstruct14_11 = \u003CModule\u003E.SetWindowsHookExA(5, (__FnPtr<int (int, uint, int)>) (IntPtr) \u003CModule\u003E.ppInt_11, (GStruct81*) 0, \u003CModule\u003E.GetCurrentThreadId());
          int num2 = (int) MessageBox.Show("CR file should be 9538 bytes", "Loading File", MessageBoxButtons.OK);
          \u003CModule\u003E.UnhookWindowsHookEx(\u003CModule\u003E.pGstruct14_11);
          \u003CModule\u003E.fclose(pGstruct5_0);
          this.textBox5.Text = new string((sbyte*) &\u003CModule\u003E.struct19_0);
          this.bool_1 = false;
        }
        else
        {
          Struct64 struct64;
          if ((int) \u003CModule\u003E.fread((void*) &struct64, 9538U, 1U, pGstruct5_0) != 1)
          {
            // ISSUE: cast to a function pointer type
            \u003CModule\u003E.pGstruct14_11 = \u003CModule\u003E.SetWindowsHookExA(5, (__FnPtr<int (int, uint, int)>) (IntPtr) \u003CModule\u003E.ppInt_11, (GStruct81*) 0, \u003CModule\u003E.GetCurrentThreadId());
            int num2 = (int) MessageBox.Show("CR file should be 9538 bytes", "Loading File", MessageBoxButtons.OK);
            \u003CModule\u003E.UnhookWindowsHookEx(\u003CModule\u003E.pGstruct14_11);
            \u003CModule\u003E.fclose(pGstruct5_0);
            this.textBox5.Text = new string((sbyte*) &\u003CModule\u003E.struct19_0);
            this.bool_1 = false;
          }
          else
          {
            this.bool_1 = true;
            this.textBox5.Text = openFileDialog.FileName;
            \u003CModule\u003E.memcpy((void*) (this.pByte_0 + 186624), (void*) &struct64, 9538U);
            \u003CModule\u003E.fclose(pGstruct5_0);
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
        \u003CModule\u003E.free((void*) this.pByte_0);
      this.pByte_0 = (byte*) \u003CModule\u003E.malloc(262144U);
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
      GStruct5* pGstruct5_0 = \u003CModule\u003E.fopen((sbyte*) (void*) Marshal.StringToHGlobalAnsi(Path.GetFullPath(strArray[0])), (sbyte*) &\u003CModule\u003E.struct18_4);
      if ((IntPtr) pGstruct5_0 == IntPtr.Zero)
      {
        // ISSUE: cast to a function pointer type
        \u003CModule\u003E.pGstruct14_11 = \u003CModule\u003E.SetWindowsHookExA(5, (__FnPtr<int (int, uint, int)>) (IntPtr) \u003CModule\u003E.ppInt_11, (GStruct81*) 0, \u003CModule\u003E.GetCurrentThreadId());
        int num = (int) MessageBox.Show(strArray[0], "Can't open file", MessageBoxButtons.OK);
        \u003CModule\u003E.UnhookWindowsHookEx(\u003CModule\u003E.pGstruct14_11);
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
          \u003CModule\u003E.pGstruct14_11 = \u003CModule\u003E.SetWindowsHookExA(5, (__FnPtr<int (int, uint, int)>) (IntPtr) \u003CModule\u003E.ppInt_11, (GStruct81*) 0, \u003CModule\u003E.GetCurrentThreadId());
          int num2 = (int) MessageBox.Show("Key file should be 16 bytes", "Loading File", MessageBoxButtons.OK);
          \u003CModule\u003E.UnhookWindowsHookEx(\u003CModule\u003E.pGstruct14_11);
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
            \u003CModule\u003E.pGstruct14_11 = \u003CModule\u003E.SetWindowsHookExA(5, (__FnPtr<int (int, uint, int)>) (IntPtr) \u003CModule\u003E.ppInt_11, (GStruct81*) 0, \u003CModule\u003E.GetCurrentThreadId());
            int num2 = (int) MessageBox.Show("Key file should be 16 bytes", "Loading File", MessageBoxButtons.OK);
            \u003CModule\u003E.UnhookWindowsHookEx(\u003CModule\u003E.pGstruct14_11);
            \u003CModule\u003E.fclose(pGstruct5_0);
            this.textBox8.Text = new string((sbyte*) &\u003CModule\u003E.struct19_0);
            this.bool_0 = false;
          }
          else
          {
            this.bool_0 = true;
            this.textBox8.Text = strArray[0];
            \u003CModule\u003E.memcpy((void*) (this.pByte_0 + 126960), (void*) &struct28, 16U);
            \u003CModule\u003E.fclose(pGstruct5_0);
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
      GStruct5* pGstruct5_0 = \u003CModule\u003E.fopen((sbyte*) (void*) Marshal.StringToHGlobalAnsi(Path.GetFullPath(strArray[0])), (sbyte*) &\u003CModule\u003E.struct18_4);
      if ((IntPtr) pGstruct5_0 == IntPtr.Zero)
      {
        // ISSUE: cast to a function pointer type
        \u003CModule\u003E.pGstruct14_11 = \u003CModule\u003E.SetWindowsHookExA(5, (__FnPtr<int (int, uint, int)>) (IntPtr) \u003CModule\u003E.ppInt_11, (GStruct81*) 0, \u003CModule\u003E.GetCurrentThreadId());
        int num = (int) MessageBox.Show(strArray[0], "Can't open file", MessageBoxButtons.OK);
        \u003CModule\u003E.UnhookWindowsHookEx(\u003CModule\u003E.pGstruct14_11);
        this.textBox5.Text = new string((sbyte*) &\u003CModule\u003E.struct19_0);
        this.bool_1 = false;
      }
      else
      {
        \u003CModule\u003E.fseek(pGstruct5_0, 0, 2);
        int num1 = \u003CModule\u003E.ftell(pGstruct5_0);
        \u003CModule\u003E.rewind(pGstruct5_0);
        if (num1 != 9538)
        {
          // ISSUE: cast to a function pointer type
          \u003CModule\u003E.pGstruct14_11 = \u003CModule\u003E.SetWindowsHookExA(5, (__FnPtr<int (int, uint, int)>) (IntPtr) \u003CModule\u003E.ppInt_11, (GStruct81*) 0, \u003CModule\u003E.GetCurrentThreadId());
          int num2 = (int) MessageBox.Show("CR file should be 9538 bytes", "Loading File", MessageBoxButtons.OK);
          \u003CModule\u003E.UnhookWindowsHookEx(\u003CModule\u003E.pGstruct14_11);
          \u003CModule\u003E.fclose(pGstruct5_0);
          this.textBox5.Text = new string((sbyte*) &\u003CModule\u003E.struct19_0);
          this.bool_1 = false;
        }
        else
        {
          Struct64 struct64;
          if ((int) \u003CModule\u003E.fread((void*) &struct64, 9538U, 1U, pGstruct5_0) != 1)
          {
            // ISSUE: cast to a function pointer type
            \u003CModule\u003E.pGstruct14_11 = \u003CModule\u003E.SetWindowsHookExA(5, (__FnPtr<int (int, uint, int)>) (IntPtr) \u003CModule\u003E.ppInt_11, (GStruct81*) 0, \u003CModule\u003E.GetCurrentThreadId());
            int num2 = (int) MessageBox.Show("CR file should be 9538 bytes", "Loading File", MessageBoxButtons.OK);
            \u003CModule\u003E.UnhookWindowsHookEx(\u003CModule\u003E.pGstruct14_11);
            \u003CModule\u003E.fclose(pGstruct5_0);
            this.textBox5.Text = new string((sbyte*) &\u003CModule\u003E.struct19_0);
            this.bool_1 = false;
          }
          else
          {
            this.bool_1 = true;
            this.textBox5.Text = strArray[0];
            \u003CModule\u003E.memcpy((void*) (this.pByte_0 + 186624), (void*) &struct64, 9538U);
            \u003CModule\u003E.fclose(pGstruct5_0);
          }
        }
      }
    }
  }
}
