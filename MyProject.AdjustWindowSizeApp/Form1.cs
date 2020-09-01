using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace MyProject.AdjustWindowSizeApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void datagrid_Select(object sender, EventArgs e)
        {
            var datagrid = sender as DataGridView;

            MainWindowHandleTextBox.Text = datagrid.CurrentRow.Cells[2].Value.ToString();

        }

        [DllImport("user32.dll")]
        private static extern bool GetWindowRect(IntPtr hwnd, out RECT lpRect);

        [StructLayout(LayoutKind.Sequential)]
        private struct RECT
        {
            public int left;
            public int top;
            public int right;
            public int bottom;
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

        private void button2_Click(object sender, EventArgs e)
        {
            int hundleIntl;
            int.TryParse(MainWindowHandleTextBox.Text, out hundleIntl);

            var handle = (IntPtr)hundleIntl;

            RECT rect;
            GetWindowRect(handle, out rect);

            WindowBottom_TextBox.Text = rect.bottom.ToString();
            WindowTop_TextBox.Text = rect.top.ToString();
            WindowRight_TextBox.Text = rect.right.ToString();
            WindowLeft_TextBox.Text = rect.left.ToString();


        }
    }
}
