using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Memory;
namespace SoTFOV
{
    
    public partial class Form1 : Form
    {
        Mem m = new Mem();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int PID = m.GetProcIdFromName("SoTGame");
            if (PID > 0)
            {
                m.OpenProcess(PID);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            m.WriteMemory("SoTGame.exe+0x07EADAE8,0x2C0,0x4B0,0x100,0x10,0x54", "float", "140");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            m.WriteMemory("SoTGame.exe+0x07EADAE8,0x2C0,0x4B0,0x100,0x10,0x54", "float", "90");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            m.WriteMemory("SoTGame.exe+0x07EADAE8,0x2C0,0x4B0,0x100,0x10,0x54", "float", "100");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            m.WriteMemory("SoTGame.exe+0x07EADAE8,0x2C0,0x4B0,0x100,0x10,0x54", "float", "110");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            m.WriteMemory("SoTGame.exe+0x07EADAE8,0x2C0,0x4B0,0x100,0x10,0x54", "float", "120");
        }
    }
}
