using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string strsubstring = txtsubstring.Text;
            string strreplacestring = txtreplace.Text;
            string strstring = txtstring.Text;
            int nsslenth = strsubstring.Length;
            int nsrlength = strreplacestring.Length;
            int nsindex = strstring.IndexOf(strsubstring);
            if (nsslenth == 0)
            {
                MessageBox.Show("يرجا ادخال نص", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (nsindex == -1)
            {
                MessageBox.Show("يرجا ادخال كلمة او محرف موجودة في النص", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (nsrlength == 0)
            {
                MessageBox.Show("يرجا ادخال كلمة او محرف المراد التبديل بها", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                txtstring.Text = strstring.Replace(strsubstring, strreplacestring);
                txtsubstring.Clear();
                txtreplace.Clear();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string strsubstring = txtsubstring.Text;
            string strstring = txtstring.Text;
            int nsslenth = strsubstring.Length;
            int nsindex = strstring.IndexOf(strsubstring);

            if(nsslenth==0)
            {
                MessageBox.Show("يرجا ادخال نص", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (nsindex==-1)
            {
                MessageBox.Show("يرجا ادخال كلمة او محرف موجودة في النص", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                txtstring.Text = strstring.Remove(nsindex, nsslenth);
                txtsubstring.Clear();
            }
        }
    }
}
