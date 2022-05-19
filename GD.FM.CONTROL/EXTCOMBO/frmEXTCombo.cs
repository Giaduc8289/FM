using System;
using System.Data;
using System.Windows.Forms;

namespace ExtensiveCombo
{
    public partial class frmEXTCombo : Form
    {
        public frmEXTCombo()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            //dummy data for TreeView
            treeView4Combo1.Nodes.Add("Asian");
            treeView4Combo1.Nodes[0].Nodes.Add("Rahil");
            treeView4Combo1.Nodes[0].Nodes.Add("Majid");
                treeView4Combo1.Nodes[0].Nodes.Add("Fahad");
                treeView4Combo1.Nodes.Add("African");
                treeView4Combo1.Nodes[1].Nodes.Add("Sajid");
                treeView4Combo1.Nodes[1].Nodes.Add("Faisal");
            treeView4Combo1.Nodes.Add("Alien");
                treeView4Combo1.Nodes[2].Nodes.Add("Nadeem");

            //dummy data for Grid
            DataTable oTable = new DataTable();
            oTable.Columns.Add("Employee Id");
            oTable.Columns.Add("Name");
            oTable.Columns.Add("Designation");
            oTable.Rows.Add("1", "Rahil", "CTO");
            oTable.Rows.Add("2", "Majid", "Software Architect");
            oTable.Rows.Add("3", "Nadeem", "Developer");
            oTable.Rows.Add("4", "Sajid", "Developer");
            oTable.Rows.Add("5", "Faisal", "Developer");
            oTable.Rows.Add("6", "Fahad", "Developer");
            gridView4Combo1.DataSource = oTable;

            multiSelect4Combo1.Items.Add("VB.net");
            multiSelect4Combo1.Items.Add("C#");
            multiSelect4Combo1.Items.Add("SQL-Server");
            multiSelect4Combo1.Items.Add("Oracle");
            multiSelect4Combo1.Items.Add("ASP.net");
            multiSelect4Combo1.Items.Add("Perl");

            //Assigning child controls to its respective combobox
            this.extCombo1.AddControl(gridView4Combo1);
            this.extCombo2.AddControl(treeView4Combo1);
            this.extCombo3.AddControl(weekDays4Combo1);
            this.extCombo4.AddControl(multiSelect4Combo1);
            this.extCombo1.LoadChildControl();
            this.extCombo2.LoadChildControl();
            this.extCombo3.LoadChildControl();
            this.extCombo4.LoadChildControl();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(extCombo2.Text.ToString());
        }
    }
}
