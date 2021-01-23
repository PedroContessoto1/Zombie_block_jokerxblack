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
using Memory;

namespace Zombie_block_jokerxblack
{
    public partial class Form1 : Form
    {
        Mem meme = new Mem();
        public static string Pistol_ammo = "mono.dll+0x001F3648,550,5b8,10";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int PID = meme.GetProcIdFromName("Zumbi blocks ultimate");
            if(PID > 0)
            {
                label1.Visible = false;
                meme.OpenProcess(PID);
                Thread WA = new Thread(writeAmmo) { IsBackground = true};
                WA.Start();
            }
        }

        private void writeAmmo()
        {
            while (true)
            {
                if (checkBox1.Checked)
                {
                    meme.WriteMemory(Pistol_ammo,"int","18");
                    Thread.Sleep(2);
                }
                Thread.Sleep(2);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
