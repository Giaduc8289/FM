using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Data;

namespace GD.FM.CONTROL
{
    public partial class setup : Form
    {
        private DataGridView dataGridView1 = new DataGridView();
        public DataTable dtsource,dttemp; 
        private string xmlfile = string.Empty;      
        public setup(string xmlfile)
        {            
            InitializeComponent();
            this.xmlfile = xmlfile;
            this.dtsource = IO.ReadXMLTOW(this.xmlfile);
            Application.EnableVisualStyles();
            this.AutoScroll = true;
        }   
        private void setupviewgrid_Load(object sender, EventArgs e)
        {
            DataGridViewCheckBoxColumn column0 = new DataGridViewCheckBoxColumn();
            DataGridViewDisableButtonColumn column1 =  new DataGridViewDisableButtonColumn();
            DataGridViewTextBoxColumn column2 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn column3 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn column4 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn column5 = new DataGridViewTextBoxColumn();
            //DatagridviewText
            column0.Name = "Check";
            column1.Name = "Name";
            column2.Name = "HeaderText";
            column3.Name = "BackColor";
            column4.Name = "SelectionBackColor";
            column5.Name = "Width";
            dataGridView1.Columns.Add(column0);
            dataGridView1.Columns.Add(column1);
            dataGridView1.Columns.Add(column2);
            dataGridView1.Columns.Add(column3);
            dataGridView1.Columns.Add(column4);
            dataGridView1.Columns.Add(column5);
            dataGridView1.RowCount = dtsource.Rows.Count+1;
            dataGridView1.AutoSize = true;
            dataGridView1.Dock = DockStyle.Fill;
            
            this.dataGridView1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.myKeyUp);
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment =DataGridViewContentAlignment.MiddleCenter;
            // Set the text for each button.
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Cells["Name"].Value = dtsource.Rows[i]["name"];
                dataGridView1.Rows[i].Cells["HeaderText"].Value = dtsource.Rows[i]["headerText"];
                dataGridView1.Rows[i].Cells["BackColor"].Value = dtsource.Rows[i]["BackColor"];
                dataGridView1.Rows[i].Cells["SelectionBackColor"].Value = dtsource.Rows[i]["SelectionBackColor"];
                dataGridView1.Rows[i].Cells["Width"].Value = dtsource.Rows[i]["Width"];

                //if (this.dtsource.Rows[i]["value"].ToString() == "2")
                //{
                //    dataGridView1.Rows[i].Visible = false;
                //}
               //else
                if (this.dtsource.Rows[i]["value"].ToString() == "0" || this.dtsource.Rows[i]["value"].ToString() == "2")
                {
                    DataGridViewCheckBoxCell checkCell = (DataGridViewCheckBoxCell)dataGridView1.Rows[i].Cells["Check"];
                    checkCell.Value = true;
                    DataGridViewDisableButtonCell buttonCell = (DataGridViewDisableButtonCell)dataGridView1.Rows[i].Cells["Name"];
                    buttonCell.Enabled = false;
                }
            }

            dataGridView1.CellValueChanged += new DataGridViewCellEventHandler(dataGridView1_CellValueChanged);
            dataGridView1.CurrentCellDirtyStateChanged += new EventHandler(dataGridView1_CurrentCellDirtyStateChanged);
            this.Controls.Add(dataGridView1);
        }
        // This event handler manually raises the CellValueChanged event
        // by calling the CommitEdit method.
        void dataGridView1_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridView1.IsCurrentCellDirty)
            {
                dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        // If a check box cell is clicked, this event handler disables  
        // or enables the button in the same row as the clicked cell.
        public void dataGridView1_CellValueChanged(object sender,DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Check")
            {
                DataGridViewDisableButtonCell buttonCell =
                    (DataGridViewDisableButtonCell)dataGridView1.
                    Rows[e.RowIndex].Cells["Name"];
                
                DataGridViewTextBoxCell TextboxCol = (DataGridViewTextBoxCell)dataGridView1.
                    Rows[e.RowIndex].Cells["HeaderText"];

                DataGridViewTextBoxCell NumberTextboxCol = (DataGridViewTextBoxCell)dataGridView1.
                    Rows[e.RowIndex].Cells["Width"];

                DataGridViewCheckBoxCell checkCell =
                    (DataGridViewCheckBoxCell)dataGridView1.
                    Rows[e.RowIndex].Cells["Check"];
                Boolean bootem = !(Boolean)checkCell.Value;
                buttonCell.Enabled = bootem;
                dtsource.Rows[e.RowIndex].SetField("value", "2");
                if (bootem)
                {
                    dtsource.Rows[e.RowIndex].SetField("value", "1");
                }
               

                TextboxCol.ReadOnly = bootem;


                dataGridView1.Invalidate();
            }
            

        }

        // If the user clicks on an enabled button cell, this event handler  
        // reports that the button is enabled.
        void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Name")
            {
                DataGridViewDisableButtonCell buttonCell =
                    (DataGridViewDisableButtonCell)dataGridView1.
                    Rows[e.RowIndex].Cells["Name"];

                DataGridViewTextBoxCell TextboxCol = (DataGridViewTextBoxCell)dataGridView1.
                   Rows[e.RowIndex].Cells["HeaderText"];

                if (buttonCell.Enabled)
                {
                    MessageBox.Show(dataGridView1.Rows[e.RowIndex].
                        Cells[e.ColumnIndex].Value.ToString() +
                        " is enabled" + "value Text==" + TextboxCol.Value);
                    dtsource.Rows[e.RowIndex].SetField("HeaderText", TextboxCol.Value);
                }
                
            }
        }

        private void setupviewgrid_FormClosed(object sender, FormClosedEventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                DataGridViewTextBoxCell TextboxCol = (DataGridViewTextBoxCell)dataGridView1.
                  Rows[i].Cells["HeaderText"];
                dtsource.Rows[i].SetField("headerText", TextboxCol.Value);

                DataGridViewTextBoxCell TextboxColBackColor = (DataGridViewTextBoxCell)dataGridView1.
                 Rows[i].Cells["BackColor"];
                dtsource.Rows[i].SetField("BackColor", TextboxColBackColor.Value);

                DataGridViewTextBoxCell TextboxSelectionBackColor = (DataGridViewTextBoxCell)dataGridView1.
                 Rows[i].Cells["SelectionBackColor"];
                dtsource.Rows[i].SetField("SelectionBackColor", TextboxSelectionBackColor.Value);

                DataGridViewTextBoxCell TextboxColWidth = (DataGridViewTextBoxCell)dataGridView1.
                 Rows[i].Cells["Width"];
                dtsource.Rows[i].SetField("Width", TextboxColWidth.Value);
            }
            DataSet ds = new DataSet(); ds.Tables.Add(dtsource.Copy());
            IO.GenXML(this.xmlfile, ds);
        }

        private void myKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == Keys.Escape.ToString())
            {
                this.Close();
            }
        }
     
    }


    public class DataGridViewDisableButtonColumn : DataGridViewButtonColumn
    {
        public DataGridViewDisableButtonColumn()
        {
            this.CellTemplate = new DataGridViewDisableButtonCell();
        }
    }

    public class DataGridViewDisableButtonCell : DataGridViewButtonCell
    {
        private bool enabledValue;
        public bool Enabled
        {
            get
            {
                return enabledValue;
            }
            set
            {
                enabledValue = value;
            }
        }

        // Override the Clone method so that the Enabled property is copied.
        public override object Clone()
        {
            DataGridViewDisableButtonCell cell =
                (DataGridViewDisableButtonCell)base.Clone();
            cell.Enabled = this.Enabled;
            return cell;
        }

        // By default, enable the button cell.
        public DataGridViewDisableButtonCell()
        {
            this.enabledValue = true;
        }

        protected override void Paint(Graphics graphics,
            Rectangle clipBounds, Rectangle cellBounds, int rowIndex,
            DataGridViewElementStates elementState, object value,
            object formattedValue, string errorText,
            DataGridViewCellStyle cellStyle,
            DataGridViewAdvancedBorderStyle advancedBorderStyle,
            DataGridViewPaintParts paintParts)
        {
            // The button cell is disabled, so paint the border,  
            // background, and disabled button for the cell.
            if (!this.enabledValue)
            {
                // Draw the cell background, if specified.
                if ((paintParts & DataGridViewPaintParts.Background) ==
                    DataGridViewPaintParts.Background)
                {
                    SolidBrush cellBackground =
                        new SolidBrush(cellStyle.BackColor);
                    graphics.FillRectangle(cellBackground, cellBounds);
                    cellBackground.Dispose();
                }

                // Draw the cell borders, if specified.
                if ((paintParts & DataGridViewPaintParts.Border) ==
                    DataGridViewPaintParts.Border)
                {
                    PaintBorder(graphics, clipBounds, cellBounds, cellStyle,
                        advancedBorderStyle);
                }

                // Calculate the area in which to draw the button.
                Rectangle buttonArea = cellBounds;
                Rectangle buttonAdjustment =
                    this.BorderWidths(advancedBorderStyle);
                buttonArea.X += buttonAdjustment.X;
                buttonArea.Y += buttonAdjustment.Y;
                buttonArea.Height -= buttonAdjustment.Height;
                buttonArea.Width -= buttonAdjustment.Width;

                // Draw the disabled button.                
                ButtonRenderer.DrawButton(graphics, buttonArea,
                    PushButtonState.Disabled);

                // Draw the disabled button text. 
                if (this.FormattedValue is String)
                {
                    TextRenderer.DrawText(graphics,
                        (string)this.FormattedValue,
                        this.DataGridView.Font,
                        buttonArea, SystemColors.GrayText);
                }
            }
            else
            {
                // The button cell is enabled, so let the base class 
                // handle the painting.
                base.Paint(graphics, clipBounds, cellBounds, rowIndex,
                    elementState, value, formattedValue, errorText,
                    cellStyle, advancedBorderStyle, paintParts);
            }
        }
    }
}
