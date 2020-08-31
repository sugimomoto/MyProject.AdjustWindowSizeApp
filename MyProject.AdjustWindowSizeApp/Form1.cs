using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProject.AdjustWindowSizeApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var process = Process.GetProcesses()
            .Where(x => x.MainWindowHandle != IntPtr.Zero)
            .Select(x => new
            {
                x.ProcessName,
                x.MainWindowTitle,
                MainWindowHandle = x.MainWindowHandle.ToInt64()
            })
            .OrderBy(x => x.ProcessName);

            foreach (var item in process)
            {
                // 参考
                // https://www.sejuku.net/blog/58436
                dataGridView1.ColumnCount = 3;
                dataGridView1.Columns[0].HeaderText = "ProcessName";
                dataGridView1.Columns[1].HeaderText = "MainWindowTitle";
                dataGridView1.Columns[2].HeaderText = "MainWindowHandle";


                dataGridView1.Rows.Add(item.ProcessName,item.MainWindowTitle,item.MainWindowHandle);
            }


        }

        

    }
}
