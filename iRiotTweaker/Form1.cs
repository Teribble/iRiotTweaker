using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iRiotTweaker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void OnLable1Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://tlgg.ru/@iRiotweak");
        }

        private void OnButton1Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                Registry.LocalMachine.CreateSubKey(@"SOFTWARE\Policies\Microsoft\Windows Defender").SetValue("DisableAntiSpyware", 1, RegistryValueKind.DWord);
                Registry.LocalMachine.CreateSubKey(@"SOFTWARE\Policies\Microsoft\Windows Defender\Real-Time Protection").SetValue("DisableBehaviorMonitoring", 1, RegistryValueKind.DWord);
                Registry.LocalMachine.CreateSubKey(@"SOFTWARE\Policies\Microsoft\Windows Defender\Real-Time Protection").SetValue("DisableOnAccessProtection", 1, RegistryValueKind.DWord);
                Registry.LocalMachine.CreateSubKey(@"SOFTWARE\Policies\Microsoft\Windows Defender\Real-Time Protection").SetValue("DisableScanOnRealtimeEnable", 1, RegistryValueKind.DWord);
                Registry.LocalMachine.CreateSubKey(@"SOFTWARE\Policies\Microsoft\Windows Defender\Real-Time Protection").SetValue("DisableIOAVProtection", 1, RegistryValueKind.DWord);
            }

            if (checkBox2.Checked == true)
            {
                string path = "%appdata%\\123123";
                if (Directory.Exists(path))
                {
                    Directory.Delete(path);
                }
            }
        }
    }
}
