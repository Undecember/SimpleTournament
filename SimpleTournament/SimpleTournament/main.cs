using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.MemoryMappedFiles;
using System.Diagnostics;
using System.IO;

namespace SimpleTournament
{
    public partial class main : Form
    {
        MemoryMappedFile mmf;
        List<string> items = new List<string>();
        public main(List<string> _items)
        {
            InitializeComponent();
            this.items = _items;
        }

        private void main_Load(object sender, EventArgs e)
        {
            Process.Start(Application.StartupPath + "\\Sorter.exe");
            while (true)
            {
                try
                {
                    mmf = MemoryMappedFile.OpenExisting("SorterSmem");
                } 
                catch (Exception ex)
                {
                    if (ex.GetType(). == FileNotFoundException) continue;
                }
            }
            
            byte[] blen = new byte[4];
            mmfvs.Read(blen, 0, 4);
            int len = blen[0] + blen[1] * 256 + blen[2] * 65536 + blen[2] * 16777216;
            byte[] strbuf = new byte[len];
            mmfvs.Read(strbuf, 0, len);
            string s = System.Text.Encoding.Default.GetString(strbuf);
            Console.WriteLine(s);
        }
    }
}
