using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

        private Student stu;

        private string formName;

        public event EventHandler tellMe;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.eventLog1.Source = "My Server Explorer App";
            try {
                this.eventLog1.WriteEntry("Something happend", System.Diagnostics.EventLogEntryType.Information);
            }
            catch (Exception exception)
            {
                exception.GetBaseException();
            }
        }
    }
}
