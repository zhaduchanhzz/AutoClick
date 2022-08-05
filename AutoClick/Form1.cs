using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using KAutoHelper;
using System.Text.RegularExpressions;

namespace AutoClick
{
    public partial class Form1 : Form
    {

        #region
       
        private int _countClick;
        public int CountClick
        {
            get { return _countClick; }
            set { _countClick = value; }
        }

        private int _nrecord;

        public int nRecord
        {
            get { return _nrecord; }
            set { _nrecord = value; }
        }
        EMouseKey mousekey = EMouseKey.LEFT;
        private int _positionX;

        public int PositionX
        {
            get { return _positionX; }
            set { _positionX = value; }
        }
        private int _positionY;

        public int PositionY
        {
            get { return _positionY; }
            set { _positionY = value; }
        }



        #endregion

         static String filepath = Environment.CurrentDirectory + @"\Autoclick.ini";
        IniFile iniFile = new IniFile(filepath);
        public Form1()
        {
            InitializeComponent();

        }

        private void timer2_Tick(object sender, EventArgs e, int x, int y)
        {
            throw new NotImplementedException();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            timer1.Start();
            timer1.Interval = 1;
            List<string> listMouse = new List<string>();
            listMouse.Add("Left");
            listMouse.Add("Right");
            listMouse.Add("Middle");
            List<string> listClickType = new List<string>();
            listClickType.Add("Single");
            listClickType.Add("Double");
            


            if (File.Exists(filepath))
            {
                cbxMouse.Text = iniFile.Read("ClickMouse", "MouseClick");
                cbxTypeClick.Text = iniFile.Read("Clicktype", "MouseClick");
                chkRecord.Checked = bool.Parse(iniFile.Read("RecordStatus", "ClickByRecord"));
                chkCount.Checked = bool.Parse(iniFile.Read("Counting", "Counting"));
                nCount.Value = Convert.ToInt32(iniFile.Read("CountClick", "Counting"));
                n1000.Value = Convert.ToInt32(iniFile.Read("1/1000", "ClickInterval"));
                n100.Value = Convert.ToInt32(iniFile.Read("1/100", "ClickInterval"));
                n10.Value = Convert.ToInt32(iniFile.Read("1/10", "ClickInterval"));



            }
            else
            {
                iniFile.Write("Clicktype", cbxTypeClick.Text, "MouseClick");
                iniFile.Write("ClickMouse", cbxMouse.Text, "MouseClick");
                iniFile.Write("RecordStatus", chkRecord.Checked.ToString(), "ClickByRecord");
                iniFile.Write("Counting", chkCount.Checked.ToString(), "Counting");
                iniFile.Write("CountClick", nCount.Value.ToString(), "Counting");
                iniFile.Write("1/1000", n1000.Value.ToString(), "ClickInterval");
                iniFile.Write("1/100", n100.Value.ToString(), "ClickInterval");
                iniFile.Write("1/10", n10.Value.ToString(), "ClickInterval");
            }
            cbxMouse.DataSource = listMouse;
            cbxTypeClick.DataSource = listClickType;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = "X =" + Cursor.Position.X.ToString() + " Y =" + Cursor.Position.Y.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void chkRecord_CheckedChanged(object sender, EventArgs e)
        {
            iniFile.Write("RecordStatus", chkRecord.Checked.ToString(), "ClickByRecord");

        }
        private void chkCount_CheckedChanged(object sender, EventArgs e)
        {
            iniFile.Write("Counting", chkCount.Checked.ToString(), "Counting");

        }

        private void cbxMouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            iniFile.Write("ClickMouse", cbxMouse.Text, "MouseClick");

        }

        private void cbxTypeClick_SelectedIndexChanged(object sender, EventArgs e)
        {
            iniFile.Write("Clicktype", cbxTypeClick.Text, "MouseClick");
        }

        private void n1000_ValueChanged(object sender, EventArgs e)
        {
            iniFile.Write("1/1000", n1000.Value.ToString(), "ClickInterval");

        }

        private void n100_ValueChanged(object sender, EventArgs e)
        {
            iniFile.Write("1/100", n100.Value.ToString(), "ClickInterval");

        }

        private void n10_ValueChanged(object sender, EventArgs e)
        {
            iniFile.Write("1/10", n10.Value.ToString(), "ClickInterval");

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Regex re = new Regex(@"\d+");
            Match m = re.Match(label1.Text);

            PositionX = Convert.ToInt32(m.Value);
            PositionY = Convert.ToInt32(m.NextMatch().Value);

            if (chkCount.Checked)
            {
                if (CountClick >= 0)
                {
                    CountClick--;
                }
                else
                {
                    panel4.Enabled = true;
                    timer2.Stop();
                }
            }
            if (chkRecord.Checked)
            {
                int total = Convert.ToInt32(iniFile.Read("Total", "Record position"));
                if (total > 0)
                {
                    string key = "Record " + nRecord;
                    string po = iniFile.Read(key, "Record position");
                    m = re.Match(po);
                    PositionX = Convert.ToInt32(m.Value);
                    PositionY = Convert.ToInt32(m.NextMatch().Value);
                    if (nRecord<total)
                    {
                        nRecord++;

                    }
                    else
                    {
                        nRecord = 0;
                    }
                }

            }
            AutoControl.MouseClick(PositionX, PositionY, mousekey);
            this.TopMost = true;
            this.Activate();
            this.Focus();
        }

        private void nCount_ValueChanged(object sender, EventArgs e)
        {
            CountClick = Convert.ToInt32(nCount.Value);
            iniFile.Write("CountClick", nCount.Value.ToString(), "Counting");


        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F3")
            {
                if (timer2.Enabled)
                {
                    panel4.Enabled = true;
                    timer2.Stop();
                    timer1.Start();
                }
                else
                {
                    panel4.Enabled = false;
                    int interval = Convert.ToInt32(n10.Value + (n100.Value * 10) + (n1000.Value * 100));
                    timer2.Interval = interval;
                    if (cbxMouse.SelectedItem.Equals("Left"))
                    {
                        if (cbxTypeClick.SelectedItem.Equals("Double"))
                        {
                            mousekey = EMouseKey.DOUBLE_LEFT;
                        }
                    }
                    if (cbxMouse.SelectedItem.Equals("Right"))
                    {
                        if (cbxTypeClick.SelectedItem.Equals("Double"))
                        {
                            mousekey = EMouseKey.DOUBLE_RIGHT;
                        }
                        else
                        {
                            mousekey = EMouseKey.RIGHT;
                        }
                    }
                    if (chkCount.Checked)
                    {
                        CountClick = Convert.ToInt32(nCount.Value);

                    }
                    if (chkRecord.Checked)
                    {
                        nRecord = 0;
                    }
                    timer2.Start();
                    timer1.Stop();
                }
            }


        }


        //private void Form1_KeyDown(object sender, KeyEventArgs e)
        //{
        //    panel4.Enabled = false;
        //    CountClick = Convert.ToInt32(nCount.Value);
        //    int interval = Convert.ToInt32(n10.Value + (n100.Value * 10) + (n1000.Value * 100));
        //    EMouseKey mousekey = EMouseKey.LEFT;
        //    if (cbxMouse.SelectedItem.Equals("Left"))
        //    {
        //        if (cbxTypeClick.SelectedItem.Equals("Double"))
        //        {
        //            mousekey = EMouseKey.DOUBLE_LEFT;
        //        }
        //    }
        //    if (cbxMouse.SelectedItem.Equals("Right"))
        //    {
        //        if (cbxTypeClick.SelectedItem.Equals("Double"))
        //        {
        //            mousekey = EMouseKey.DOUBLE_RIGHT;
        //        }
        //        else
        //        {
        //            mousekey = EMouseKey.RIGHT;
        //        }
        //    }
        //    if (chkCount.Checked)
        //    {

        //    }
        //    if (chkRecord.Checked)
        //    {

        //    }


        //}


    }
}
