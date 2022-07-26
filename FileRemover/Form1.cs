using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FileRemover
{
    public partial class Form1 : Form
    {
        Queue<Item> queue = new Queue<Item>();

        public Form1()
        {
            InitializeComponent();
            lviewFiles.View = View.Details;
            lviewFiles.Columns.Add("Name");
            lviewFiles.Columns.Add("Size");
            lviewFiles.Columns.Add("Date");
            this.lviewFiles.ColumnWidthChanging += new ColumnWidthChangingEventHandler(lviewFiles_ColumnWidthChanging);
    }

        public void btnSearch_Click(object sender, EventArgs e)
        {
            if(queue.Count() != 0)
            {
                queue.Clear();
            }

            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowDialog();
            txtPath.Text = fbd.SelectedPath;
            lviewFiles.Items.Clear();
            FindFiles(fbd.SelectedPath);
        }

        public void FindFiles(string path)
        {
            if(Directory.EnumerateFiles(path, "*", SearchOption.TopDirectoryOnly).Count() > 0)
            {
                foreach (string file in Directory.EnumerateFiles(path, "*", SearchOption.TopDirectoryOnly))
                {
                    FileInfo info = new FileInfo(file);

                    if (info.Length > 1024 && info.Length < 1048576)
                    {
                        ListViewItem item = new ListViewItem(path + @"\" + info.Name);
                        item.SubItems.Add((info.Length / 1024m).ToString("#.##") + "KB");
                        item.SubItems.Add(info.CreationTime.ToString());
                        lviewFiles.Items.Add(item);
                    }
                    else
                    {
                        ListViewItem item = new ListViewItem(path + @"\" + info.Name);
                        item.SubItems.Add((info.Length).ToString("#.##") + "Bytes");
                        item.SubItems.Add(info.CreationTime.ToString());
                        lviewFiles.Items.Add(item);
                    }
                }
                lviewFiles.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            }
            else
            {
                return;
            }
        }

        public void lviewFiles_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = lviewFiles.Columns[e.ColumnIndex].Width;
        }

        public void lviewFiles_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            ListViewItem item = e.Item as ListViewItem;
            Item currentItem = new Item(item.Text);
            if (item.Checked)
            {
                queue.Enqueue(currentItem);
            }
            else
            {
                Queue<Item> holdQueue = new Queue<Item>();
                while(queue.Count() > 0)
                {
                    if(queue.Peek().Path != currentItem.Path)
                    {
                        holdQueue.Enqueue(queue.Peek());
                        queue.Dequeue();
                    }
                    else
                    {
                        queue.Dequeue();
                    }
                }
                
                while(holdQueue.Count() > 0)
                {
                    queue.Enqueue(holdQueue.Peek());
                    holdQueue.Dequeue();
                }
            }
        }

        public void btnDelete_Click(object sender, EventArgs e)
        {
            while(queue.Count() > 0)
            {
                queue.Peek().Delete();
                queue.Dequeue();
            }
        }
    }
}
