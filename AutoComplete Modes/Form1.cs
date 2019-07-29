using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.autoComplete1.SetAutoComplete(this.textBox1, Syncfusion.Windows.Forms.Tools.AutoCompleteModes.MultiSuggestExtended);
            this.Load += Form1_Load;
            this.BackColor = Color.White;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable("Table1");
            dt.Columns.Add("Famous place");
            dt.Columns.Add("Country");
            dt.Columns.Add("Capital");

            // Create a Data Set
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            dt.Rows.Add(new string[] { "Big Ben", "United Kingdom ", "London" });
            dt.Rows.Add(new string[] { "white House","USA", "Washington, D.C." });
            dt.Rows.Add(new string[] { "Rio de Janeiro", "Brazil", "Brasilia" });
            dt.Rows.Add(new string[] { "Eiffel Tower","France", "Paris" });
            dt.Rows.Add(new string[] { "Moscow Kremlin","Russia", "Moscow" });
            dt.Rows.Add(new string[] { "Taj Mahal","India", "Delhi" });
            DataView view = new DataView(dt);

            // DATASOURCE is DATAVIEW
            this.autoComplete1.DataSource = view;
            this.autoComplete1.ShowColumnHeader = true;
            autoComplete1.CaseSensitive = true;
            autoComplete1.IgnoreCase = false;

        }
    }
}
