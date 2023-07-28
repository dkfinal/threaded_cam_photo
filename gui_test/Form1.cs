using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gui_test
{
    public partial class Form1 : Form
    {
        string strCfgFilename = "\\\\cfg.txt";

        [DllImport("dll_test.dll")]
        public static extern void createWnd();

        [DllImport("dll_test.dll")]
        public static extern int dAmount();

        [DllImport("dll_test.dll")]
        public static extern IntPtr dName(int dNum);

        [DllImport("dll_test.dll")]
        public static extern void freeP(IntPtr hWnd);

        [DllImport("dll_test.dll")]
        public static extern void initCam(int dNum, int camW, int camH);

        [DllImport("dll_test.dll")]
        public static extern void setDir(string path);

        [DllImport("dll_test.dll")]
        public static extern void saveCam();

        [DllImport("dll_test.dll")]
        public static extern int fps();

        [DllImport("dll_test.dll")]
        public static extern void closeOnLeaving();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            string execPath = Assembly.GetExecutingAssembly().Location;
            if (File.Exists(Path.GetDirectoryName(execPath) + strCfgFilename))
            {
                StreamReader cfgR = new StreamReader(Path.GetDirectoryName(execPath) + strCfgFilename);
                string cfgLine = cfgR.ReadLine();
                if (cfgLine != null)
                {
                    tbPath.Text = cfgLine;
                }
                cfgR.Close();
                cfgR.Dispose();
                cfgR = null;
            }
            else
            {
                var fl = File.Create(Path.GetDirectoryName(execPath) + strCfgFilename);
                fl.Close();
                fl.Dispose();
            }

            
            createWnd();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            closeOnLeaving();
        }

        private void ticker_Tick(object sender, EventArgs e)
        {
            lFPS.Text = "FPS: " + fps().ToString();
        }

        private void bBrowse_Click(object sender, EventArgs e)
        {
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                tbPath.Text = fbd.SelectedPath;
                setDir(tbPath.Text);

                string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)
                    + strCfgFilename;

                StreamWriter cfgW = new StreamWriter(path);
                cfgW.WriteLine(tbPath.Text);

                cfgW.Close();
                cfgW.Dispose();
                cfgW = null;
            }
        }

        private void bScan_Click(object sender, EventArgs e)
        {
            lbDevices.Items.Clear();
            for (int i = 0; i < dAmount(); i++)
            {
                IntPtr ptr = dName(i);
                lbDevices.Items.Add(Marshal.PtrToStringAnsi(ptr));
                freeP(ptr);
            }

            if (tbPath.Text.Length != 0)
            {
                setDir(tbPath.Text);
            }
        }

        private void bShoot_Click(object sender, EventArgs e)
        {
            saveCam();
        }

        private void lbDevices_Click(object sender, EventArgs e)
        {
            if (tbCamWidth.Text.Length != 0 && tbCamHeight.Text.Length != 0)
            {
                initCam(lbDevices.SelectedIndex, int.Parse(tbCamWidth.Text), int.Parse(tbCamHeight.Text));
            }
        }
    }
}
