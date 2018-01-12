using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace BIN2TXT
{
    public partial class BIN2TXT : Form
    {
        string File_read_path = "";
        string File_write_path = "";
        public BIN2TXT()
        {
            InitializeComponent();
        }

        private string getFontName(string path)
        {
            string a = "";
            string[] strArray = path.Split('\\');
            a = strArray[strArray.Length - 1];
            return a;
        }

        private void readBINData() {
            try
            {
                string str = "";
                UInt32 readLen = 0;
                int i;
                FileInfo ENFileInfo = new FileInfo(File_read_path);
                readLen = (UInt32)ENFileInfo.Length;
                if (readLen > 2048)
                {
                    readLen = 2048;
                }
                FileStream f_read = new FileStream(File_read_path, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(f_read);
                br.BaseStream.Seek(0, SeekOrigin.Begin);
                for (i = 0; i < readLen; i++)
                {
                    str += br.ReadByte().ToString("X2").ToUpper()+" ";
                }
                richTextBoxData.Text = str;
            }
            catch (Exception m)
            {
                MessageBox.Show(this, m.Message, "小凡", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonRead_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog rFile = new OpenFileDialog();
                rFile.Filter = "二进制文件|*.bin|LCD文件|*.LCD";//!<过滤文件类型
                rFile.RestoreDirectory = true; //!<记忆上次浏览路径
                if (rFile.ShowDialog() == DialogResult.OK)
                {
                    File_read_path = rFile.FileName;
                    readBINData();
                    textBoxRead.Text = getFontName(rFile.FileName);
                }
                rFile.Dispose();
            }
            catch (Exception m)
            {
                MessageBox.Show(this, m.Message, "小凡", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonWrite_Click(object sender, EventArgs e)
        {
            int i;
            UInt32 readLen = 0;
            string str = "";
            try
            {
                //设置保存文件的格式
                SaveFileDialog mySave = new SaveFileDialog();
                mySave.Filter = "文本文件(*.txt)|*.txt";
                if (mySave.ShowDialog() == DialogResult.OK)
                {
                    //使用“另存为”对话框中输入的文件名实例化StreamWriter对象
                    StreamWriter sw = new StreamWriter(mySave.FileName, false);
                    FileInfo FileInfo = new FileInfo(File_read_path);
                    readLen = (UInt32)FileInfo.Length;
                    FileStream f_read = new FileStream(File_read_path, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(f_read);
                    br.BaseStream.Seek(0, SeekOrigin.Begin);
                    for (i = 0; i < readLen; i++)
                    {
                        str = br.ReadByte().ToString("X2").ToUpper() + " ";
                        sw.Write(str);
                    }
                    sw.Close();
                }
                textBoxWrite.Text = getFontName(mySave.FileName);
                MessageBox.Show(this, "保存为" + getFontName(mySave.FileName) + "成功！", "小凡提示：", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            catch (Exception m)
            {
                MessageBox.Show(this, m.Message, "小凡", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
