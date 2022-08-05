using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoClick
{



    public partial class Form2 : Form
    {
        #region
        private int _count;

        public int Count
        {
            get { return _count; }
            set { _count = value; }
        }
        private List<string> _list;

        public List<string> ListPosition
        {
            get { return _list; }
            set { _list = value; }
        }


        #endregion
        static String filepath = Environment.CurrentDirectory + @"\Autoclick.ini";
        IniFile iniFile = new IniFile(filepath);
        int count = 0;
        public Form2()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void button1_DragDrop(object sender, DragEventArgs e)
        {
            listView1.Items.Add("X =" + Cursor.Position.X.ToString() + " Y =" + Cursor.Position.Y.ToString());
            count++;
            label2.Text = "Total " + count;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = "X =" + Cursor.Position.X.ToString() + " Y =" + Cursor.Position.Y.ToString();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            //Cursor.Current = new Cursor(@"C:\Users\zhadu\source\repos\AutoClick\AutoClick\Cursor1.cur");
            Cursor cur = Cursors.Cross;
            Cursor.Current = cur;
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            iniFile.Write("Record " + count, Cursor.Position.X.ToString() + "-" + Cursor.Position.Y.ToString(), "Record position");
            iniFile.Write("Total  ", count.ToString(), "Record position");
            Cursor.Current = null;
            string position = "X =" + Cursor.Position.X.ToString() + " Y =" + Cursor.Position.Y.ToString();
            listView1.Items.Add(position);
            count++;
            label2.Text = "Total " + count;

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Are you sure you want to Clear all record", "Are you sure?", MessageBoxButtons.YesNo);

            if (DialogResult == DialogResult.Yes)
            {
                iniFile.DeleteSection("Record position");
                count = 0;
                label2.Text = "Total = 0";
                listView1.Clear();
            }

            else if (DialogResult == DialogResult.No)
            {

            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Count = count;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            if (File.Exists(filepath))
            {
                try
                {
                    Count = Convert.ToInt32(iniFile.Read("Total", "Record position"));
                    if (iniFile.Read("Total", "Record position") != null)
                    {
                        for (int i = 0; i <= Count; i++)
                        {
                            string key = "Record " + i;
                            listView1.Items.Add(iniFile.Read(key, "Record position"));
                        }
                        label2.Text = "Total " + Count;
                    }
                   
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }

            }
        }
    }
}
