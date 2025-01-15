// Type: ns0.DataBaseView
// Assembly: JungleFlasher, Version=1.0.5004.40451, Culture=neutral, PublicKeyToken=7240d12d147b2b97
// MVID: 86B778B8-1293-454B-A759-8F0EBE32074A
// Assembly location: C:\Documents and Settings\User\Desktop\JungleFlasher-cleaned.exe

using Microsoft.Win32;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Resources;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ns0
{
  public class DataBaseView : Form
  {
    private DataGrid dataGrid1;
    private DataSet dataSet_0;
    private DataTable dataTable_0;
    public DataColumn dataColumn_0;
    private DataColumn dataColumn_1;
    private DataColumn dataColumn_2;
    private DataColumn dataColumn_3;
    private DataColumn dataColumn_4;
    private DataColumn dataColumn_5;
    private DataColumn dataColumn_6;
    private DataColumn dataColumn_7;
    private DataColumn dataColumn_8;
    private DataColumn dataColumn_9;
    private DataColumn dataColumn_10;
    private DataColumn dataColumn_11;
    private DataColumn dataColumn_12;
    private Label label40;
    private Label label44;
    private Label label43;
    private Label label41;
    private Label label37;
    public TextBox textBox15;
    private Label label19;
    private TextBox textBox9;
    private Label label15;
    private Label label7;
    private Label label6;
    private Label label5;
    private Label label4;
    private Label label3;
    private Label label16;
    private Label label8;
    private Label label1;
    private Label label2;
    private Label label9;
    private Label label10;
    private Button button1;
    private GroupBox groupBox1;
    private Label label11;
    private ContextMenu contextMenu_0;
    private MenuItem menuItem_0;
    private TextBox textBox1;
    private DataTable dataTable_1;
    private DataColumn dataColumn_13;
    private ToolTip toolTip_0;
    private Button button2;
    public TextBox textBox2;
    private Button button3;
    private Button button4;
    private IContainer icontainer_0;
    public int int_0;

    public DataBaseView()
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
      ResourceManager resourceManager = new ResourceManager(typeof (DataBaseView));
      this.dataGrid1 = new DataGrid();
      this.contextMenu_0 = new ContextMenu();
      this.menuItem_0 = new MenuItem();
      this.dataTable_0 = new DataTable();
      this.dataColumn_0 = new DataColumn();
      this.dataColumn_1 = new DataColumn();
      this.dataColumn_2 = new DataColumn();
      this.dataColumn_3 = new DataColumn();
      this.dataColumn_4 = new DataColumn();
      this.dataColumn_5 = new DataColumn();
      this.dataColumn_6 = new DataColumn();
      this.dataColumn_7 = new DataColumn();
      this.dataColumn_8 = new DataColumn();
      this.dataColumn_9 = new DataColumn();
      this.dataColumn_10 = new DataColumn();
      this.dataColumn_11 = new DataColumn();
      this.dataColumn_12 = new DataColumn();
      this.dataSet_0 = new DataSet();
      this.dataTable_1 = new DataTable();
      this.dataColumn_13 = new DataColumn();
      this.label40 = new Label();
      this.label44 = new Label();
      this.label43 = new Label();
      this.label41 = new Label();
      this.label37 = new Label();
      this.textBox15 = new TextBox();
      this.label19 = new Label();
      this.textBox9 = new TextBox();
      this.label15 = new Label();
      this.label7 = new Label();
      this.label6 = new Label();
      this.label5 = new Label();
      this.label4 = new Label();
      this.label3 = new Label();
      this.label16 = new Label();
      this.label8 = new Label();
      this.label1 = new Label();
      this.label2 = new Label();
      this.label9 = new Label();
      this.label10 = new Label();
      this.button1 = new Button();
      this.groupBox1 = new GroupBox();
      this.button4 = new Button();
      this.button3 = new Button();
      this.button2 = new Button();
      this.label11 = new Label();
      this.textBox2 = new TextBox();
      this.textBox1 = new TextBox();
      this.toolTip_0 = new ToolTip(this.icontainer_0);
      this.dataGrid1.BeginInit();
      this.dataTable_0.BeginInit();
      this.dataSet_0.BeginInit();
      this.dataTable_1.BeginInit();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      this.dataGrid1.CaptionVisible = false;
      this.dataGrid1.ContextMenu = this.contextMenu_0;
      this.dataGrid1.DataMember = "";
      this.dataGrid1.HeaderForeColor = SystemColors.ControlText;
      Point point1 = new Point();
      point1 = new Point(16, 48);
      this.dataGrid1.Location = point1;
      this.dataGrid1.Name = "dataGrid1";
      this.dataGrid1.ParentRowsVisible = false;
      this.dataGrid1.ReadOnly = true;
      Size size1 = new Size();
      size1 = new Size(520, 278);
      this.dataGrid1.Size = size1;
      this.dataGrid1.TabIndex = 0;
      this.dataGrid1.MouseDown += new MouseEventHandler(this.dataGrid1_MouseDown);
      this.dataGrid1.DoubleClick += new EventHandler(this.dataGrid1_DoubleClick);
      this.dataGrid1.MouseUp += new MouseEventHandler(this.dataGrid1_MouseUp);
      this.dataGrid1.CurrentCellChanged += new EventHandler(this.dataGrid1_CurrentCellChanged);
      this.contextMenu_0.MenuItems.AddRange(new MenuItem[1]
      {
        this.menuItem_0
      });
      this.menuItem_0.Index = 0;
      this.menuItem_0.Text = "Delete";
      this.menuItem_0.Click += new EventHandler(this.menuItem_0_Click);
      this.dataTable_0.Columns.AddRange(new DataColumn[13]
      {
        this.dataColumn_0,
        this.dataColumn_1,
        this.dataColumn_2,
        this.dataColumn_3,
        this.dataColumn_4,
        this.dataColumn_5,
        this.dataColumn_6,
        this.dataColumn_7,
        this.dataColumn_8,
        this.dataColumn_9,
        this.dataColumn_10,
        this.dataColumn_11,
        this.dataColumn_12
      });
      this.dataTable_0.TableName = "Table1";
      this.dataColumn_0.ColumnName = "ID";
      this.dataColumn_0.DataType = typeof (int);
      this.dataColumn_1.ColumnName = "Job_Name";
      this.dataColumn_2.ColumnName = "Key";
      this.dataColumn_3.ColumnName = "Vendor";
      this.dataColumn_4.ColumnName = "Model";
      this.dataColumn_5.ColumnName = "Rev";
      this.dataColumn_6.ColumnName = "FileLoc";
      this.dataColumn_7.ColumnName = "KeyLoc";
      this.dataColumn_8.ColumnName = "Type";
      this.dataColumn_9.ColumnName = "Spoof";
      this.dataColumn_10.ColumnName = "Osig";
      this.dataColumn_11.ColumnName = "Created";
      this.dataColumn_12.ColumnName = "Updated";
      this.dataSet_0.DataSetName = "NewDataSet";
      this.dataSet_0.Locale = new CultureInfo("en-IE");
      this.dataSet_0.Tables.AddRange(new DataTable[2]
      {
        this.dataTable_0,
        this.dataTable_1
      });
      this.dataTable_1.Columns.AddRange(new DataColumn[1]
      {
        this.dataColumn_13
      });
      this.dataTable_1.TableName = "Table2";
      this.dataColumn_13.ColumnName = "Vendor";
      this.label40.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      Point point2 = new Point();
      point2 = new Point(312, 64);
      this.label40.Location = point2;
      this.label40.Name = "label40";
      Size size2 = new Size();
      size2 = new Size(208, 16);
      this.label40.Size = size2;
      this.label40.TabIndex = 49;
      this.label44.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Point point3 = new Point();
      point3 = new Point(40, 64);
      this.label44.Location = point3;
      this.label44.Name = "label44";
      Size size3 = new Size();
      size3 = new Size(208, 16);
      this.label44.Size = size3;
      this.label44.TabIndex = 52;
      Point point4 = new Point();
      point4 = new Point(8, 64);
      this.label43.Location = point4;
      this.label43.Name = "label43";
      Size size4 = new Size();
      size4 = new Size(40, 16);
      this.label43.Size = size4;
      this.label43.TabIndex = 51;
      this.label43.Text = "OSIG:";
      Point point5 = new Point();
      point5 = new Point(248, 64);
      this.label41.Location = point5;
      this.label41.Name = "label41";
      Size size5 = new Size();
      size5 = new Size(88, 16);
      this.label41.Size = size5;
      this.label41.TabIndex = 50;
      this.label41.Text = "Spoofed As:";
      Point point6 = new Point();
      point6 = new Point(384, 16);
      this.label37.Location = point6;
      this.label37.Name = "label37";
      Size size6 = new Size();
      size6 = new Size(60, 16);
      this.label37.Size = size6;
      this.label37.TabIndex = 48;
      this.textBox15.BackColor = SystemColors.Window;
      Point point7 = new Point();
      point7 = new Point(8, 120);
      this.textBox15.Location = point7;
      this.textBox15.Name = "textBox15";
      this.textBox15.ReadOnly = true;
      Size size7 = new Size();
      size7 = new Size(488, 20);
      this.textBox15.Size = size7;
      this.textBox15.TabIndex = 47;
      this.textBox15.Text = "";
      Point point8 = new Point();
      point8 = new Point(312, 16);
      this.label19.Location = point8;
      this.label19.Name = "label19";
      Size size8 = new Size();
      size8 = new Size(72, 16);
      this.label19.Size = size8;
      this.label19.TabIndex = 46;
      this.label19.Text = "DVD Key @";
      this.textBox9.BackColor = SystemColors.Window;
      Point point9 = new Point();
      point9 = new Point(304, 40);
      this.textBox9.Location = point9;
      this.textBox9.Name = "textBox9";
      this.textBox9.ReadOnly = true;
      Size size9 = new Size();
      size9 = new Size(224, 20);
      this.textBox9.Size = size9;
      this.textBox9.TabIndex = 45;
      this.textBox9.Text = "";
      Point point10 = new Point();
      point10 = new Point(160, 16);
      this.label15.Location = point10;
      this.label15.Name = "label15";
      Size size10 = new Size();
      size10 = new Size(120, 16);
      this.label15.Size = size10;
      this.label15.TabIndex = 43;
      this.label15.Text = "Firmware Type";
      Point point11 = new Point();
      point11 = new Point(56, 40);
      this.label7.Location = point11;
      this.label7.Name = "label7";
      Size size11 = new Size();
      size11 = new Size(64, 16);
      this.label7.Size = size11;
      this.label7.TabIndex = 41;
      Point point12 = new Point();
      point12 = new Point(8, 40);
      this.label6.Location = point12;
      this.label6.Name = "label6";
      Size size12 = new Size();
      size12 = new Size(72, 16);
      this.label6.Size = size12;
      this.label6.TabIndex = 40;
      Point point13 = new Point();
      point13 = new Point(120, 16);
      this.label5.Location = point13;
      this.label5.Name = "label5";
      Size size13 = new Size();
      size13 = new Size(32, 16);
      this.label5.Size = size13;
      this.label5.TabIndex = 39;
      this.label5.Text = "Rev";
      Point point14 = new Point();
      point14 = new Point(56, 16);
      this.label4.Location = point14;
      this.label4.Name = "label4";
      Size size14 = new Size();
      size14 = new Size(56, 16);
      this.label4.Size = size14;
      this.label4.TabIndex = 38;
      this.label4.Text = "Model ";
      Point point15 = new Point();
      point15 = new Point(8, 16);
      this.label3.Location = point15;
      this.label3.Name = "label3";
      Size size15 = new Size();
      size15 = new Size(48, 16);
      this.label3.Size = size15;
      this.label3.TabIndex = 37;
      this.label3.Text = "Vendor";
      Point point16 = new Point();
      point16 = new Point(160, 40);
      this.label16.Location = point16;
      this.label16.Name = "label16";
      Size size16 = new Size();
      size16 = new Size(152, 24);
      this.label16.Size = size16;
      this.label16.TabIndex = 44;
      Point point17 = new Point();
      point17 = new Point(120, 40);
      this.label8.Location = point17;
      this.label8.Name = "label8";
      Size size17 = new Size();
      size17 = new Size(72, 16);
      this.label8.Size = size17;
      this.label8.TabIndex = 42;
      Point point18 = new Point();
      point18 = new Point(8, 88);
      this.label1.Location = point18;
      this.label1.Name = "label1";
      Size size18 = new Size();
      size18 = new Size(48, 16);
      this.label1.Size = size18;
      this.label1.TabIndex = 54;
      this.label1.Text = "Created:";
      Point point19 = new Point();
      point19 = new Point(248, 88);
      this.label2.Location = point19;
      this.label2.Name = "label2";
      Size size19 = new Size();
      size19 = new Size(88, 16);
      this.label2.Size = size19;
      this.label2.TabIndex = 55;
      this.label2.Text = "Last Updated:";
      this.label9.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Point point20 = new Point();
      point20 = new Point(56, 88);
      this.label9.Location = point20;
      this.label9.Name = "label9";
      Size size20 = new Size();
      size20 = new Size(200, 16);
      this.label9.Size = size20;
      this.label9.TabIndex = 56;
      this.label10.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Point point21 = new Point();
      point21 = new Point(336, 88);
      this.label10.Location = point21;
      this.label10.Name = "label10";
      Size size21 = new Size();
      size21 = new Size(168, 16);
      this.label10.Size = size21;
      this.label10.TabIndex = 57;
      this.button1.FlatStyle = FlatStyle.System;
      Point point22 = new Point();
      point22 = new Point(504, 88);
      this.button1.Location = point22;
      this.button1.Name = "button1";
      Size size22 = new Size();
      size22 = new Size(24, 16);
      this.button1.Size = size22;
      this.button1.TabIndex = 58;
      this.button1.Text = "...";
      this.toolTip_0.SetToolTip((Control) this.button1, "Click to view all date info");
      this.button1.Click += new EventHandler(this.button1_Click);
      this.groupBox1.Controls.Add((Control) this.button4);
      this.groupBox1.Controls.Add((Control) this.button3);
      this.groupBox1.Controls.Add((Control) this.button2);
      this.groupBox1.Controls.Add((Control) this.label40);
      this.groupBox1.Controls.Add((Control) this.label41);
      this.groupBox1.Controls.Add((Control) this.label44);
      this.groupBox1.Controls.Add((Control) this.label11);
      this.groupBox1.Controls.Add((Control) this.textBox9);
      this.groupBox1.Controls.Add((Control) this.label16);
      this.groupBox1.Controls.Add((Control) this.label8);
      this.groupBox1.Controls.Add((Control) this.label7);
      this.groupBox1.Controls.Add((Control) this.label1);
      this.groupBox1.Controls.Add((Control) this.label2);
      this.groupBox1.Controls.Add((Control) this.label9);
      this.groupBox1.Controls.Add((Control) this.label10);
      this.groupBox1.Controls.Add((Control) this.label3);
      this.groupBox1.Controls.Add((Control) this.label4);
      this.groupBox1.Controls.Add((Control) this.label5);
      this.groupBox1.Controls.Add((Control) this.label6);
      this.groupBox1.Controls.Add((Control) this.label15);
      this.groupBox1.Controls.Add((Control) this.button1);
      this.groupBox1.Controls.Add((Control) this.label19);
      this.groupBox1.Controls.Add((Control) this.textBox15);
      this.groupBox1.Controls.Add((Control) this.label37);
      this.groupBox1.Controls.Add((Control) this.label43);
      this.groupBox1.FlatStyle = FlatStyle.System;
      Point point23 = new Point();
      point23 = new Point(8, 328);
      this.groupBox1.Location = point23;
      this.groupBox1.Name = "groupBox1";
      Size size23 = new Size();
      size23 = new Size(536, 184);
      this.groupBox1.Size = size23;
      this.groupBox1.TabIndex = 59;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Properties";
      this.button4.FlatStyle = FlatStyle.System;
      Point point24 = new Point();
      point24 = new Point(312, 152);
      this.button4.Location = point24;
      this.button4.Name = "button4";
      Size size24 = new Size();
      size24 = new Size(80, 24);
      this.button4.Size = size24;
      this.button4.TabIndex = 62;
      this.button4.Text = "Import";
      this.toolTip_0.SetToolTip((Control) this.button4, "Import KeyDB from CSV File");
      this.button4.Click += new EventHandler(this.button4_Click);
      this.button3.FlatStyle = FlatStyle.System;
      Point point25 = new Point();
      point25 = new Point(160, 152);
      this.button3.Location = point25;
      this.button3.Name = "button3";
      Size size25 = new Size();
      size25 = new Size(80, 24);
      this.button3.Size = size25;
      this.button3.TabIndex = 61;
      this.button3.Text = "Export";
      this.toolTip_0.SetToolTip((Control) this.button3, "Export KeyDB to CSV file");
      this.button3.Click += new EventHandler(this.button3_Click);
      this.button2.FlatStyle = FlatStyle.System;
      Point point26 = new Point();
      point26 = new Point(504, 120);
      this.button2.Location = point26;
      this.button2.Name = "button2";
      Size size26 = new Size();
      size26 = new Size(24, 20);
      this.button2.Size = size26;
      this.button2.TabIndex = 60;
      this.button2.Text = "...";
      this.toolTip_0.SetToolTip((Control) this.button2, "Open Job File");
      this.button2.Click += new EventHandler(this.button2_Click);
      Point point27 = new Point();
      point27 = new Point(464, 16);
      this.label11.Location = point27;
      this.label11.Name = "label11";
      Size size27 = new Size();
      size27 = new Size(64, 16);
      this.label11.Size = size27;
      this.label11.TabIndex = 59;
      this.label11.TextAlign = ContentAlignment.TopRight;
      this.textBox2.BackColor = SystemColors.Window;
      Point point28 = new Point();
      point28 = new Point(272, 272);
      this.textBox2.Location = point28;
      this.textBox2.Name = "textBox2";
      this.textBox2.ReadOnly = true;
      Size size28 = new Size();
      size28 = new Size(88, 20);
      this.textBox2.Size = size28;
      this.textBox2.TabIndex = 62;
      this.textBox2.Text = "Jobname";
      this.textBox1.BackColor = SystemColors.Window;
      Point point29 = new Point();
      point29 = new Point(48, 16);
      this.textBox1.Location = point29;
      this.textBox1.Name = "textBox1";
      Size size29 = new Size();
      size29 = new Size(72, 20);
      this.textBox1.Size = size29;
      this.textBox1.TabIndex = 61;
      this.textBox1.Text = "";
      this.toolTip_0.SetToolTip((Control) this.textBox1, "Type Job Name search string and press enter");
      this.textBox1.KeyDown += new KeyEventHandler(this.textBox1_KeyDown);
      this.textBox1.TextChanged += new EventHandler(this.textBox1_TextChanged);
      Size size30 = new Size();
      size30 = new Size(5, 13);
      this.AutoScaleBaseSize = size30;
      Size size31 = new Size();
      size31 = new Size(554, 520);
      this.ClientSize = size31;
      this.Controls.Add((Control) this.textBox1);
      this.Controls.Add((Control) this.groupBox1);
      this.Controls.Add((Control) this.dataGrid1);
      this.Controls.Add((Control) this.textBox2);
      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      this.Icon = (Icon) resourceManager.GetObject("$this.Icon");
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "DataBaseView";
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "Key DataBase Viewer";
      this.Load += new EventHandler(this.DataBaseView_Load);
      this.dataGrid1.EndInit();
      this.dataTable_0.EndInit();
      this.dataSet_0.EndInit();
      this.dataTable_1.EndInit();
      this.groupBox1.ResumeLayout(false);
      this.ResumeLayout(false);
    }

    private unsafe void method_0()
    {
      RegistryKey subKey1 = Registry.CurrentUser.CreateSubKey("JF_KeyDB");
      int num;
      if (subKey1.GetValue("Index") != null)
        num = Convert.ToInt32(subKey1.GetValue("Index").ToString()) + 1;
      subKey1.Close();
      for (int index = 1; index < num; ++index)
      {
        RegistryKey subKey2 = Registry.CurrentUser.CreateSubKey("JF_KeyDB\\" + Convert.ToString(index));
        if (subKey2.GetValue("Key") != null && subKey2.GetValue("Deleted") == null)
        {
          string str1 = subKey2.GetValue("Key").ToString();
          string str2 = subKey2.GetValue("KeyLoc").ToString();
          string str3 = subKey2.GetValue("Vendor").ToString();
          string str4 = subKey2.GetValue(new string((sbyte*) &\u003CModule\u003E.struct23_0)).ToString();
          string str5 = subKey2.GetValue("Rev").ToString();
          string str6 = subKey2.GetValue("Type").ToString();
          string str7 = subKey2.GetValue("JobName").ToString();
          string str8 = subKey2.GetValue(new string((sbyte*) &\u003CModule\u003E.struct22_0)).ToString();
          string str9 = subKey2.GetValue("Spoof") == null ? "" : subKey2.GetValue("Spoof").ToString();
          string str10 = subKey2.GetValue("Updated") == null ? "" : subKey2.GetValue("Updated").ToString();
          string str11 = subKey2.GetValue("Osig").ToString();
          string str12 = subKey2.GetValue("LastFile") == null ? subKey2.GetValue("WorkingDir").ToString() + "\\" : subKey2.GetValue("LastFile").ToString();
          subKey2.Close();
          DataRow row = this.dataTable_0.NewRow();
          row["ID"] = (object) Convert.ToString(index);
          row["Job_Name"] = (object) str7;
          row["Key"] = (object) str1;
          row["Model"] = (object) str4;
          row["Rev"] = (object) str5;
          row["Vendor"] = (object) str3;
          row["FileLoc"] = (object) str12;
          row["KeyLoc"] = (object) str2;
          row["Type"] = (object) str6;
          row["Spoof"] = (object) str9;
          row["Osig"] = (object) str11;
          row["Created"] = (object) str8;
          row["Updated"] = (object) str10;
          this.dataTable_0.Rows.Add(row);
        }
      }
    }

    private unsafe void DataBaseView_Load(object sender, EventArgs e)
    {
      this.method_0();
      this.dataGrid1.DataSource = (object) this.dataSet_0.Tables["Table1"];
      DataGridTableStyle table = new DataGridTableStyle();
      table.MappingName = "Table1";
      DataGridColumnStyle column1 = (DataGridColumnStyle) new DataGridTextBoxColumn();
      DataGridColumnStyle column2 = (DataGridColumnStyle) new DataGridTextBoxColumn();
      DataGridColumnStyle column3 = (DataGridColumnStyle) new DataGridTextBoxColumn();
      DataGridColumnStyle column4 = (DataGridColumnStyle) new DataGridTextBoxColumn();
      DataGridColumnStyle column5 = (DataGridColumnStyle) new DataGridTextBoxColumn();
      DataGridColumnStyle column6 = (DataGridColumnStyle) new DataGridTextBoxColumn();
      column1.MappingName = new string((sbyte*) &\u003CModule\u003E.struct18_1);
      column1.HeaderText = new string((sbyte*) &\u003CModule\u003E.struct18_1);
      column1.Width = 30;
      table.GridColumnStyles.Add(column1);
      column2.MappingName = new string((sbyte*) &\u003CModule\u003E.struct24_0);
      column2.HeaderText = "Job Name";
      column2.Width = 65;
      table.GridColumnStyles.Add(column2);
      column3.MappingName = new string((sbyte*) &\u003CModule\u003E.struct25_0);
      column3.HeaderText = new string((sbyte*) &\u003CModule\u003E.struct25_0);
      column3.Width = 235;
      table.GridColumnStyles.Add(column3);
      column4.MappingName = new string((sbyte*) &\u003CModule\u003E.struct10_1);
      column4.HeaderText = new string((sbyte*) &\u003CModule\u003E.struct10_1);
      column4.Width = 65;
      table.GridColumnStyles.Add(column4);
      column5.MappingName = new string((sbyte*) &\u003CModule\u003E.struct23_0);
      column5.HeaderText = new string((sbyte*) &\u003CModule\u003E.struct23_0);
      column5.Width = 60;
      table.GridColumnStyles.Add(column5);
      column6.MappingName = new string((sbyte*) &\u003CModule\u003E.struct25_1);
      column6.HeaderText = new string((sbyte*) &\u003CModule\u003E.struct25_1);
      column6.Width = 44;
      table.RowHeadersVisible = false;
      table.GridColumnStyles.Add(column6);
      this.dataGrid1.TableStyles.Add(table);
      this.label6.DataBindings.Add("Text", (object) this.dataTable_0, "Vendor");
      this.label7.DataBindings.Add("Text", (object) this.dataTable_0, "Model");
      this.label8.DataBindings.Add("Text", (object) this.dataTable_0, "Rev");
      this.label9.DataBindings.Add("Text", (object) this.dataTable_0, "Created");
      this.label10.DataBindings.Add("Text", (object) this.dataTable_0, "Updated");
      this.label11.DataBindings.Add("Text", (object) this.dataTable_0, "ID");
      this.label16.DataBindings.Add("Text", (object) this.dataTable_0, "Type");
      this.label37.DataBindings.Add("Text", (object) this.dataTable_0, "KeyLoc");
      this.label40.DataBindings.Add("Text", (object) this.dataTable_0, "Spoof");
      this.label44.DataBindings.Add("Text", (object) this.dataTable_0, "Osig");
      this.textBox2.DataBindings.Add("Text", (object) this.dataTable_0, "Job_Name");
      this.textBox9.DataBindings.Add("Text", (object) this.dataTable_0, "Key");
      this.textBox15.DataBindings.Add("Text", (object) this.dataTable_0, "FileLoc");
      if (this.int_0 <= 0)
        return;
      this.method_3(this.int_0);
      this.dataGrid1.CurrentRowIndex = 0;
      this.dataGrid1.Select(this.dataGrid1.CurrentRowIndex);
    }

    private void button1_Click(object sender, EventArgs e)
    {
      int num = (int) new Job_history()
      {
        int_0 = Convert.ToInt32(this.label11.Text)
      }.ShowDialog((IWin32Window) this);
    }

    private void menuItem_0_Click(object sender, EventArgs e)
    {
      RegistryKey subKey = Registry.CurrentUser.CreateSubKey("JF_KeyDB\\" + this.label11.Text);
      subKey.SetValue("Deleted", (object) "1");
      subKey.Close();
      this.dataTable_0.Clear();
      this.method_0();
    }

    private void dataGrid1_MouseUp(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Left)
        return;
      this.dataGrid1.Select(this.dataGrid1.CurrentRowIndex);
    }

    private void dataGrid1_CurrentCellChanged(object sender, EventArgs e)
    {
      this.dataGrid1.Select(this.dataGrid1.CurrentRowIndex);
    }

    private void dataGrid1_MouseDown(object sender, MouseEventArgs e)
    {
      DataGridCell dataGridCell = new DataGridCell();
      if (e.Button != MouseButtons.Right)
        return;
      this.dataGrid1.UnSelect(this.dataGrid1.CurrentRowIndex);
      DataGrid.HitTestInfo hitTestInfo = this.dataGrid1.HitTest(e.X, e.Y);
      dataGridCell.RowNumber = hitTestInfo.Row;
      dataGridCell.ColumnNumber = hitTestInfo.Column;
      this.dataGrid1.CurrentCell = dataGridCell;
      this.dataGrid1.CurrentRowIndex = hitTestInfo.Row;
      this.dataGrid1.Select(this.dataGrid1.CurrentRowIndex);
    }

    private void method_1(object sender, EventArgs e)
    {
      this.method_2();
    }

    private void method_2()
    {
      this.dataSet_0.Tables["Table1"].DefaultView.RowFilter = string.Format("Job_Name like '{0}%'", (object) this.textBox1.Text);
      if (this.dataSet_0.Tables["Table1"].DefaultView.Count != 0)
        return;
      int num = (int) MessageBox.Show("No matching Jobs Found", "Filter", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      this.dataSet_0.Tables["Table1"].DefaultView.RowFilter = "";
    }

    private void method_3(int int_1)
    {
      this.dataSet_0.Tables["Table1"].DefaultView.RowFilter = string.Format("ID = {0}", (object) Convert.ToString(int_1));
      if (this.dataSet_0.Tables["Table1"].DefaultView.Count != 0)
        return;
      int num = (int) MessageBox.Show("No matching Jobs Found", "Filter", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      this.dataSet_0.Tables["Table1"].DefaultView.RowFilter = "";
    }

    private void textBox1_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode != Keys.Return)
        return;
      this.method_2();
    }

    private void dataGrid1_DoubleClick(object sender, EventArgs e)
    {
      int num = (int) new Job_history()
      {
        int_0 = Convert.ToInt32(this.label11.Text)
      }.ShowDialog((IWin32Window) this);
    }

    private unsafe void button2_Click(object sender, EventArgs e)
    {
      GStruct11* windowA = \u003CModule\u003E.FindWindowA((sbyte*) 0, (sbyte*) &\u003CModule\u003E.struct12_5);
      if ((IntPtr) windowA == IntPtr.Zero)
      {
        windowA = \u003CModule\u003E.FindWindowA((sbyte*) &\u003CModule\u003E.struct9_1, (sbyte*) 0);
        if ((IntPtr) windowA == IntPtr.Zero)
          windowA = \u003CModule\u003E.FindWindowA((sbyte*) &\u003CModule\u003E.struct26_0, (sbyte*) 0);
      }
      GStruct11* windowExA = \u003CModule\u003E.FindWindowExA(windowA, (GStruct11*) 0, (sbyte*) 0, (sbyte*) &\u003CModule\u003E.struct16_1);
      if (File.Exists(this.textBox15.Text))
      {
        IntPtr num = Marshal.StringToHGlobalAnsi(this.textBox15.Text);
        \u003CModule\u003E.SendMessageA(windowExA, 12U, 0U, (int) (void*) num);
        this.DialogResult = DialogResult.OK;
        this.Close();
      }
      else
      {
        if (!Directory.Exists(Path.GetDirectoryName(this.textBox15.Text)))
          return;
        OpenFileDialog openFileDialog = new OpenFileDialog();
        openFileDialog.Filter = "Firmware file (*.bin)|*.bin|All Files (*.*)|*.*";
        openFileDialog.FileName = "Orig.bin";
        openFileDialog.DefaultExt = ".bin";
        openFileDialog.CheckFileExists = true;
        openFileDialog.CheckPathExists = true;
        openFileDialog.RestoreDirectory = false;
        openFileDialog.InitialDirectory = this.textBox15.Text;
        if (openFileDialog.ShowDialog() != DialogResult.OK)
          return;
        IntPtr num = Marshal.StringToHGlobalAnsi(openFileDialog.FileName);
        \u003CModule\u003E.SendMessageA(windowExA, 12U, 0U, (int) (void*) num);
        this.DialogResult = DialogResult.OK;
        this.Close();
      }
    }

    private unsafe void method_4()
    {
      string str1 = (string) null;
      RegistryKey subKey1 = Registry.CurrentUser.CreateSubKey("JF_KeyDB");
      int num1;
      if (subKey1.GetValue("Index") != null)
      {
        str1 = subKey1.GetValue("Index").ToString();
        num1 = Convert.ToInt32(str1) + 1;
      }
      subKey1.Close();
      RegistryKey subKey2 = Registry.CurrentUser.CreateSubKey("JF_KeyDB\\SerList");
      string str2 = subKey2.ValueCount.ToString();
      string[] valueNames = subKey2.GetValueNames();
      string str3 = ",,JungleFlasher Key Database,";
      int num2;
      \u003CModule\u003E.time(&num2);
      GStruct85* pGstruct85_0 = \u003CModule\u003E.localtime(&num2);
      string s = str3 + Convert.ToString(new string(\u003CModule\u003E.asctime(pGstruct85_0))).Substring(0, 24) + (object) "," + str1 + " keys present!" + (string) __arglist ("\n");
      for (int index1 = 1; index1 < num1; ++index1)
      {
        RegistryKey subKey3 = Registry.CurrentUser.CreateSubKey("JF_KeyDB\\" + Convert.ToString(index1));
        if (subKey3.GetValue("Key") != null)
        {
          string str4 = subKey3.GetValue("Key").ToString();
          string str5 = subKey3.GetValue("KeyLoc").ToString();
          string str6 = subKey3.GetValue("Vendor").ToString();
          string str7 = subKey3.GetValue(new string((sbyte*) &\u003CModule\u003E.struct23_0)).ToString();
          string str8 = subKey3.GetValue("Rev").ToString();
          string str9 = subKey3.GetValue("Type").ToString();
          string str10 = subKey3.GetValue("JobName").ToString();
          string str11 = subKey3.GetValue(new string((sbyte*) &\u003CModule\u003E.struct22_0)).ToString();
          string strA1 = subKey3.GetValue("Spoof") == null ? "" : subKey3.GetValue("Spoof").ToString();
          string strA2 = subKey3.GetValue("Updated") == null ? "" : subKey3.GetValue("Updated").ToString();
          string str12 = subKey3.GetValue("Osig").ToString();
          string str13 = subKey3.GetValue("WorkingDir").ToString();
          string strA3 = subKey3.GetValue("LastFile") == null ? "" : subKey3.GetValue("LastFile").ToString();
          subKey3.Close();
          string strA4 = "";
          for (int index2 = 0; index2 < Convert.ToInt32(str2); ++index2)
          {
            if (string.Compare(subKey2.GetValue(valueNames[index2]).ToString(), Convert.ToString(index1)) == 0)
            {
              strA4 = valueNames[index2];
              break;
            }
          }
          string str14 = s + Convert.ToString(index1) + "," + str10 + "," + str11 + "," + str13 + "," + str12 + ",";
          string str15 = (string.Compare(strA1, "") == 0 ? str14 + "," : str14 + strA1 + ",") + str6 + "," + str7 + "," + str8 + "," + str9 + "," + str4 + "," + str5 + ",";
          string str16 = string.Compare(strA2, "") == 0 ? str15 + "n/a," : str15 + strA2 + ",";
          string str17 = string.Compare(strA3, "") == 0 ? str16 + "n/a," : str16 + strA3 + ",";
          s = string.Compare(strA4, "") == 0 ? str17 + "n/a\n" : str17 + strA4 + "\n";
        }
      }
      subKey2.Close();
      SaveFileDialog saveFileDialog = new SaveFileDialog();
      saveFileDialog.Filter = "KeyDb Backup file (*.csv)|*.csv|All Files (*.*)|*.*";
      saveFileDialog.DefaultExt = ".csv";
      saveFileDialog.FileName = "KeyDB.csv";
      saveFileDialog.OverwritePrompt = false;
      if (saveFileDialog.ShowDialog() != DialogResult.OK)
        return;
      GStruct5* pGstruct5_0 = \u003CModule\u003E.fopen((sbyte*) (void*) Marshal.StringToHGlobalAnsi(Path.GetFullPath(saveFileDialog.FileName)), (sbyte*) &\u003CModule\u003E.struct18_2);
      if ((IntPtr) pGstruct5_0 == IntPtr.Zero)
      {
        int num3 = (int) MessageBox.Show(saveFileDialog.FileName.ToString(), "Can't open file", MessageBoxButtons.OK);
      }
      else
      {
        \u003CModule\u003E.fputs((sbyte*) (void*) Marshal.StringToHGlobalAnsi(s), pGstruct5_0);
        \u003CModule\u003E.fclose(pGstruct5_0);
      }
    }

    private unsafe void method_5()
    {
      OpenFileDialog openFileDialog = new OpenFileDialog();
      openFileDialog.Filter = "KeyDB Backup file (*.csv)|*.csv|All Files (*.*)|*.*";
      openFileDialog.FileName = "KeyDB.csv";
      openFileDialog.DefaultExt = ".csv";
      openFileDialog.CheckFileExists = true;
      openFileDialog.CheckPathExists = true;
      openFileDialog.RestoreDirectory = false;
      if (openFileDialog.ShowDialog() != DialogResult.OK)
        return;
      this.Cursor = Cursors.AppStarting;
      GStruct5* pGstruct5_0 = \u003CModule\u003E.fopen((sbyte*) (void*) Marshal.StringToHGlobalAnsi(Path.GetFullPath(openFileDialog.FileName)), (sbyte*) &\u003CModule\u003E.struct6_3);
      if ((IntPtr) pGstruct5_0 == IntPtr.Zero)
      {
        int num = (int) MessageBox.Show(openFileDialog.FileName.ToString(), "Can't open file", MessageBoxButtons.OK);
      }
      else
      {
        Struct27 struct27;
        \u003CModule\u003E.fgets((sbyte*) &struct27, 1024, pGstruct5_0);
        sbyte* numPtr = \u003CModule\u003E.strtok((sbyte*) &struct27, (sbyte*) &\u003CModule\u003E.struct6_4);
        numPtr = \u003CModule\u003E.strtok((sbyte*) 0, (sbyte*) &\u003CModule\u003E.struct6_4);
        string str1 = "" + new string(\u003CModule\u003E.strtok(\u003CModule\u003E.strtok((sbyte*) 0, (sbyte*) &\u003CModule\u003E.struct6_4), (sbyte*) &\u003CModule\u003E.struct6_5));
        string[,] strArray = new string[Convert.ToInt32(str1), 15];
        for (int index1 = 0; index1 < Convert.ToInt32(str1); ++index1)
        {
          \u003CModule\u003E.fgets((sbyte*) &struct27, 1024, pGstruct5_0);
          string str2 = "" + new string(\u003CModule\u003E.strtok((sbyte*) &struct27, (sbyte*) &\u003CModule\u003E.struct6_4));
          strArray[index1, 0] = str2;
          for (int index2 = 1; index2 < 15; ++index2)
          {
            string str3 = "" + new string(\u003CModule\u003E.strtok((sbyte*) 0, (sbyte*) &\u003CModule\u003E.struct18_3));
            strArray[index1, index2] = str3;
          }
        }
        RegistryKey subKey1 = Registry.CurrentUser.CreateSubKey("JF_KeyDB");
        string str4 = subKey1.GetValue("Index") == null ? new string((sbyte*) &\u003CModule\u003E.struct6_6) : subKey1.GetValue("Index").ToString();
        string str5 = Convert.ToString(Convert.ToInt32(str1) + Convert.ToInt32(str4));
        subKey1.SetValue("Index", (object) Convert.ToString(str5));
        subKey1.Close();
        for (int index = 0; index < Convert.ToInt32(str1); ++index)
        {
          RegistryKey subKey2 = Registry.CurrentUser.CreateSubKey(new string((sbyte*) &\u003CModule\u003E.struct7_1) + Convert.ToString(index + 1 + Convert.ToInt32(str4)));
          subKey2.SetValue("Index", (object) Convert.ToString(index + 1 + Convert.ToInt32(str4)));
          subKey2.SetValue("JobName", (object) strArray[index, 1]);
          subKey2.SetValue("Created", (object) strArray[index, 2]);
          subKey2.SetValue("WorkingDir", (object) strArray[index, 3]);
          subKey2.SetValue("Osig", (object) strArray[index, 4]);
          subKey2.SetValue("Spoof", (object) strArray[index, 5]);
          subKey2.SetValue("Vendor", (object) strArray[index, 6]);
          subKey2.SetValue("Model", (object) strArray[index, 7]);
          subKey2.SetValue("Rev", (object) strArray[index, 8]);
          subKey2.SetValue("Type", (object) strArray[index, 9]);
          subKey2.SetValue("Key", (object) strArray[index, 10]);
          subKey2.SetValue("KeyLoc", (object) strArray[index, 11]);
          subKey2.SetValue("Updated", (object) strArray[index, 12]);
          subKey2.SetValue("Lastfile", (object) strArray[index, 13]);
          subKey2.Close();
        }
        for (int index = 0; index < Convert.ToInt32(str1); ++index)
        {
          RegistryKey subKey2 = Registry.CurrentUser.CreateSubKey(new string((sbyte*) &\u003CModule\u003E.struct16_2));
          subKey2.SetValue(strArray[index, 10], (object) Convert.ToString(index + 1 + Convert.ToInt32(str4)));
          subKey2.Close();
        }
        for (int index = 0; index < Convert.ToInt32(str1); ++index)
        {
          if (string.Compare(strArray[index, 14], "n/a") != 0)
          {
            RegistryKey subKey2 = Registry.CurrentUser.CreateSubKey(new string((sbyte*) &\u003CModule\u003E.struct16_3));
            subKey2.SetValue(strArray[index, 14], (object) Convert.ToString(index + 1 + Convert.ToInt32(str4)));
            subKey2.Close();
          }
        }
        this.Cursor = Cursors.Arrow;
      }
    }

    private void button4_Click(object sender, EventArgs e)
    {
      this.method_5();
      this.dataTable_0.Clear();
      this.method_0();
    }

    private void button3_Click(object sender, EventArgs e)
    {
      this.method_4();
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {
    }
  }
}
