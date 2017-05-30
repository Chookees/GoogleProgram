using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Google_Programm
{
    public partial class Form1 : Form
    {
        Int32[] iZahlen = new Int32[4];
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            #region Useless + ausgabe
            iZahlen[0] = Convert.ToInt32(textBox1.Text);
            iZahlen[1] = Convert.ToInt32(textBox2.Text);
            iZahlen[2] = Convert.ToInt32(textBox3.Text);
            iZahlen[3] = Convert.ToInt32(textBox4.Text);
            Array.Sort(iZahlen);
            label2.Text = "[" + iZahlen[0] + "] [" + iZahlen[1] + "] [" + iZahlen[2] + "] [" + iZahlen[3] + "]";
            #endregion
            #region Bubblesort
            int temp = 0;
            for (int i = 0; i < iZahlen.Length; i++)
            {
                for (int sort = 0; sort < iZahlen.Length - 1; sort++)
                {
                    if (iZahlen[i] < iZahlen[sort])
                    {
                        temp = iZahlen[i];
                        iZahlen[i] = iZahlen[sort];
                        iZahlen[sort] = temp;
                    }
                }
            }
            #endregion
            #region Program
            Int32 iTemp1, itemp2, iIndikator, iindikator2;
            bool check = true;
            iIndikator = 0;
            iindikator2 = 3;

            while (check == true)
            {
                itemp2 = iZahlen[iIndikator];
                iTemp1 = iZahlen[iindikator2];
                if (iTemp1 + itemp2 < 8)
                {
                    iIndikator++;
                }

                if (iTemp1 + itemp2 > 8)
                {
                    iindikator2--;
                }

                if (iTemp1 + itemp2 == 8)
                {
                    check = false;
                    MessageBox.Show("Match with " + itemp2 + " and " + iTemp1);
                }

            }
            #endregion
        }
        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=XKu_SEDAykw");
        }
    }
}
