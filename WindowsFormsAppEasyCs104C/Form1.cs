using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppEasyCs104C
{
    public partial class Form1 : Form
    {
        private DataSet ds;
        private DataGridView dg;
        private string path = "C:\\Users\\Enin\\RiderProjects\\WindowsFormsAppEasyCs104C\\WindowsFormsAppEasyCs104C\\";
        
        public Form1()
        {
            InitializeComponent();
            this.Text = "XML Viewer";
            ds = new DataSet();
            ds.ReadXml(path + "Sample.xml");
            
            dg = new DataGridView();
            dg.DataSource = ds.Tables[0];
            dg.Parent = this;
        }
    }
}