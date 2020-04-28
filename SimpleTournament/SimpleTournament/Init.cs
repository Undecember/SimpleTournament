using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleTournament
{
    public partial class Init : Form
    {
        public Init()
        {
            InitializeComponent();
        }

        private void Lstbx_Items_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Lstbx_Items.SelectedItems.Count > 0)
            {
                btn_delsel.Enabled = true;
                btn_deselall.Enabled = true;
                btn_revorder.Enabled = true;
            }
        }

        private void btn_selall_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Lstbx_Items.Items.Count; i++) Lstbx_Items.SetSelected(i, true);
        }

        private void btn_deselall_Click(object sender, EventArgs e)
        {
            Lstbx_Items.ClearSelected();
        }

        private void btn_delsel_Click(object sender, EventArgs e)
        {
            while (Lstbx_Items.SelectedItems.Count > 0) Lstbx_Items.Items.RemoveAt(Lstbx_Items.SelectedIndices[0]);
            if (Lstbx_Items.Items.Count <= 1)
            {
                if (Lstbx_Items.Items.Count == 0)
                {
                    btn_delsel.Enabled = false;
                    btn_deselall.Enabled = false;
                    btn_revorder.Enabled = false;
                    btn_selall.Enabled = false;
                }
                btn_start.Enabled = false;
            }
        }

        private void btn_revorder_Click(object sender, EventArgs e)
        {
            List<int> indlst = new List<int>();
            for (int i = 0; i < Lstbx_Items.SelectedIndices.Count; i++) indlst.Add(Lstbx_Items.SelectedIndices[i]);
            Lstbx_Items.ClearSelected();
            for (int i = 0; i < indlst.Count / 2; i++)
            {
                string tmp = Lstbx_Items.Items[indlst[i]].ToString();
                Lstbx_Items.Items[indlst[i]] = Lstbx_Items.Items[indlst[indlst.Count - i - 1]].ToString();
                Lstbx_Items.Items[indlst[indlst.Count - i - 1]] = tmp;
            }
            for (int i = 0; i < indlst.Count; i++) Lstbx_Items.SetSelected(indlst[i], true);
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Lstbx_Items.Items.Add(tbx_newitem.Text);
            tbx_newitem.Text = "";
            if (Lstbx_Items.Items.Count > 0)
            {
                if (Lstbx_Items.Items.Count > 1) btn_start.Enabled = true;
                btn_delsel.Enabled = true;
                btn_deselall.Enabled = true;
                btn_revorder.Enabled = true;
                btn_selall.Enabled = true;
            }
        }

        private void tbx_newitem_TextChanged(object sender, EventArgs e)
        {
            if (tbx_newitem.Text == "") btn_add.Enabled = false;
            else btn_add.Enabled = true;
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            List<string> items = new List<string>();
            for (int i = 0; i < Lstbx_Items.Items.Count; i++) items.Add(Lstbx_Items.Items[i].ToString());
            main _main = new main(items);
            _main.Show();
            this.Close();
        }
    }
}
