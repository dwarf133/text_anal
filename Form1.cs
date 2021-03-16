using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace text_anal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void butOpenCode_Click(object sender, EventArgs e)
        {
            string fileName = "";
            openFileDialogCode.ShowDialog();
            if (openFileDialogCode.CheckFileExists) fileName = openFileDialogCode.FileName;
            openFileDialogCode.OpenFile()
        }
    }
}
