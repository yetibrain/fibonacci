// --------------------------------------------------------------------------------------------------------------------
// <copyright company="brightman software studios" file="FormMain.cs">
//   Copyright © brightman software studios 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Windows.Forms;

namespace Fibonacci
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1Load(object sender, EventArgs e)
        {
            ulong prev = 0;
            ulong act = 1;

            ListViewItem li0 = new ListViewItem("0");
            ListViewItem.ListViewSubItem si0 = new ListViewItem.ListViewSubItem { Text = "0" };
            li0.SubItems.Add(si0);
            listViewFibonacci.Items.Add(li0);

            ListViewItem li1 = new ListViewItem("1");
            ListViewItem.ListViewSubItem si1 = new ListViewItem.ListViewSubItem { Text = "1" };
            li1.SubItems.Add(si1);
            listViewFibonacci.Items.Add(li1);

            for (ulong pos = 2; pos < 77; pos++)
            {
                ListViewItem lvi = new ListViewItem($"{pos}");
                ListViewItem.ListViewSubItem sia = new ListViewItem.ListViewSubItem();
                ListViewItem.ListViewSubItem sib = new ListViewItem.ListViewSubItem();

                var temp = act + prev;

                if (pos >= 4)
                {
                    double gc = (double)temp / act;
                    sib.Text = $"{gc}";
                }

                sia.Text = $"{temp}";
                
                prev = act;
                act = temp;
                
                lvi.SubItems.Add(sia);
                lvi.SubItems.Add(sib);
                listViewFibonacci.Items.Add(lvi);

            }
        }
    }
}
