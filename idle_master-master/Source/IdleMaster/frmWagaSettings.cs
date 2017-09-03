using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IdleMaster
{
    public partial class frmWagaSettings : Form
    {
        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);
        public frmWagaSettings()
        {
            InitializeComponent();
        }

        private void changeautonextime_Click(object sender, EventArgs e)
        {
            try
            {
                if (timebox.Text == "")
                {
                    MessageBox.Show("请输入正确时间！");
                }
                else if (Convert.ToInt32(timebox.Text) > 5000)
                {
                    MessageBox.Show("设置间隔最大为5000ms！");
                    timebox.Text = "5000";
                }
                else if (Convert.ToInt32(timebox.Text) < 500)
                {
                    MessageBox.Show("设置间隔最小为500ms！");
                    timebox.Text = "500";
                }
                else
                {
                    try
                    {
                        WritePrivateProfileString("AutoNext", "Time", timebox.Text, ".\\Settings.ini");
                        MessageBox.Show("设置保存成功！");
                    }
                    catch
                    {
                        MessageBox.Show("修改失败！");
                    }
                }
            }
            catch
            {
                MessageBox.Show("请输入正确格式！");
                timebox.Text = "";
            }
        }

        private void frmWagaSettings_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("本页设置需要在文件->重新加载或重启程序后生效！","提示");
        }
    }
}
