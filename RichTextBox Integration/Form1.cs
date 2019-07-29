using Syncfusion.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.autoComplete1.SetAutoComplete(this.richTextBox1, Syncfusion.Windows.Forms.Tools.AutoCompleteModes.AutoSuggest);
            this.Load += Form1_Load;


        }
        private void Form1_Load(object sender, EventArgs e)
        {

            //Create dataTable
            DataTable dt = new DataTable("Table1");
            dt.Columns.Add("Country");
            dt.Columns.Add("Capital");

            // Create a Data Set
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            dt.Rows.Add(new string[] { "United Kingdom ", "London" });
            dt.Rows.Add(new string[] { "USA", "Washington, D.C." });
            dt.Rows.Add(new string[] { "Brazil", "Brasilia" });
            dt.Rows.Add(new string[] { "France", "Paris" });
            dt.Rows.Add(new string[] { "Russia", "Moscow" });
            dt.Rows.Add(new string[] { "India", "Delhi" });
            DataView view = new DataView(dt);

            // DATASOURCE is DATAVIEW
            this.autoComplete1.DataSource = view;
            this.autoComplete1.ShowColumnHeader = true;
        }
    }

    public class MyRichTextBox : System.Windows.Forms.RichTextBox, IEditControlsEmbed

    {

        // Returns the active RichTextBox control.

        public Control GetActiveEditControl(IEditControlsEmbedListener listener)

        {

            return (Control)this;

        }



    }
}
