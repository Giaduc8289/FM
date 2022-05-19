// Decompiled with JetBrains decompiler
// Type: TBNet.MultiColumnComboBox
// Assembly: TBNet.Forms.Control, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DE87E719-51C4-42D8-A566-BE783BA316FC
// Assembly location: D:\temp\KTX\GD.FM\DLL\TBNet.Forms.Control.dll

using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace GD.FM.LIB
{
  [DesignerCategory("Code")]
  public class MultiColumnComboBox : ComboBox
  {
    private Color _BackColorEven = Color.White;
    private Color _BackColorOdd = Color.White;
    private string _ColumnNameString = "";
    private int _ColumnWidthDefault = 150;
    private string _ColumnWidthString = "";
    private int _TotalWidth = 0;
    private int _ValueMemberColumnIndex = 0;
    private Collection<string> _ColumnNames = new Collection<string>();
    private Collection<int> _ColumnWidths = new Collection<int>();
    private bool _AutoComplete;
    private bool _AutoDropdown;
    private int _LinkedColumnIndex;
    private TextBox _LinkedTextBox;

    public bool AutoComplete
    {
      get
      {
        return this._AutoComplete;
      }
      set
      {
        this._AutoComplete = value;
      }
    }

    public bool AutoDropdown
    {
      get
      {
        return this._AutoDropdown;
      }
      set
      {
        this._AutoDropdown = value;
      }
    }

    public Color BackColorEven
    {
      get
      {
        return this._BackColorEven;
      }
      set
      {
        this._BackColorEven = value;
      }
    }

    public Color BackColorOdd
    {
      get
      {
        return this._BackColorOdd;
      }
      set
      {
        this._BackColorOdd = value;
      }
    }

    public Collection<string> ColumnNameCollection
    {
      get
      {
        return this._ColumnNames;
      }
    }

    public string ColumnNames
    {
      get
      {
        return this._ColumnNameString;
      }
      set
      {
        if (!Convert.ToBoolean(value.Trim().Length))
        {
          this._ColumnNameString = "";
        }
        else
        {
          if (value == null)
            return;
          char[] chArray = new char[3]
          {
            ',',
            ';',
            ':'
          };
          string[] strArray = value.Split(chArray);
          if (!this.DesignMode)
            this._ColumnNames.Clear();
          foreach (string str in strArray)
          {
            if (!Convert.ToBoolean(str.Trim().Length))
              throw new NotSupportedException("Column names can not be blank.");
            if (!this.DesignMode)
              this._ColumnNames.Add(str.Trim());
          }
          this._ColumnNameString = value;
        }
      }
    }

    public Collection<int> ColumnWidthCollection
    {
      get
      {
        return this._ColumnWidths;
      }
    }

    public int ColumnWidthDefault
    {
      get
      {
        return this._ColumnWidthDefault;
      }
      set
      {
        this._ColumnWidthDefault = value;
      }
    }

    public string ColumnWidths
    {
      get
      {
        return this._ColumnWidthString;
      }
      set
      {
        if (!Convert.ToBoolean(value.Trim().Length))
        {
          this._ColumnWidthString = "";
        }
        else
        {
          if (value == null)
            return;
          char[] chArray = new char[3]
          {
            ',',
            ';',
            ':'
          };
          string[] strArray = value.Split(chArray);
          string str1 = "";
          int num1 = -1;
          int num2 = 1;
          foreach (string s in strArray)
          {
            if (Convert.ToBoolean(s.Trim().Length))
            {
              int result;
              if (!int.TryParse(s, out result))
              {
                num1 = num2;
                str1 = s;
              }
              else
                ++num2;
            }
            else
              ++num2;
          }
          if (num1 > -1)
            throw new ArgumentOutOfRangeException("Invalid column width '" + str1 + "' located at column " + num1.ToString());
          this._ColumnWidthString = value;
          if (!this.DesignMode)
          {
            this._ColumnWidths.Clear();
            foreach (string str2 in strArray)
            {
              if (Convert.ToBoolean(str2.Trim().Length))
                this._ColumnWidths.Add(Convert.ToInt32(str2));
              else
                this._ColumnWidths.Add(this._ColumnWidthDefault);
            }
            if (this.DataManager != null)
              this.InitializeColumns();
          }
        }
      }
    }

    public new DrawMode DrawMode
    {
      get
      {
        return base.DrawMode;
      }
      set
      {
        if (value != DrawMode.OwnerDrawVariable)
          throw new NotSupportedException("Needs to be DrawMode.OwnerDrawVariable");
        base.DrawMode = value;
      }
    }

    public new ComboBoxStyle DropDownStyle
    {
      get
      {
        return base.DropDownStyle;
      }
      set
      {
        if (value != ComboBoxStyle.DropDown)
          throw new NotSupportedException("ComboBoxStyle.DropDown is the only supported style");
        base.DropDownStyle = value;
      }
    }

    public int LinkedColumnIndex
    {
      get
      {
        return this._LinkedColumnIndex;
      }
      set
      {
        if (value < 0)
          throw new ArgumentOutOfRangeException("A column index can not be negative");
        this._LinkedColumnIndex = value;
      }
    }

    public TextBox LinkedTextBox
    {
      get
      {
        return this._LinkedTextBox;
      }
      set
      {
        this._LinkedTextBox = value;
        if (this._LinkedTextBox == null)
          return;
        this._LinkedTextBox.ReadOnly = true;
        this._LinkedTextBox.TabStop = false;
      }
    }

    public int TotalWidth
    {
      get
      {
        return this._TotalWidth;
      }
    }

    public event EventHandler OpenSearchForm;

    public MultiColumnComboBox()
    {
      this.DrawMode = DrawMode.OwnerDrawVariable;
      this.ContextMenu = new ContextMenu();
    }

    protected override void OnDataSourceChanged(EventArgs e)
    {
      base.OnDataSourceChanged(e);
      this.InitializeColumns();
    }

    protected override void OnDrawItem(DrawItemEventArgs e)
    {
      base.OnDrawItem(e);
      if (this.DesignMode)
        return;
      e.DrawBackground();
      Rectangle bounds = e.Bounds;
      int num = 0;
      Color color;
      if ((e.State & DrawItemState.Selected) == DrawItemState.None)
      {
        using (SolidBrush solidBrush = new SolidBrush(Convert.ToBoolean(e.Index % 2) ? this._BackColorOdd : this._BackColorEven))
          e.Graphics.FillRectangle((Brush) solidBrush, e.Bounds);
        color = Color.Black;
      }
      else
        color = Color.White;
      using (Pen pen = new Pen(SystemColors.GrayText))
      {
        using (SolidBrush solidBrush = new SolidBrush(color))
        {
          if (!Convert.ToBoolean(this._ColumnNames.Count))
          {
            e.Graphics.DrawString(Convert.ToString(this.Items[e.Index]), this.Font, (Brush) solidBrush, (RectangleF) bounds);
          }
          else
          {
            for (int index = 0; index < this._ColumnNames.Count; ++index)
            {
              if (Convert.ToBoolean(this._ColumnWidths[index]))
              {
                string s = Convert.ToString(this.FilterItemOnProperty(this.Items[e.Index], this._ColumnNames[index]));
                bounds.X = num;
                bounds.Width = this._ColumnWidths[index];
                num = bounds.Right;
                e.Graphics.DrawString(s, this.Font, (Brush) solidBrush, (RectangleF) bounds);
                if (index < this._ColumnNames.Count - 1)
                  e.Graphics.DrawLine(pen, bounds.Right, bounds.Top, bounds.Right, bounds.Bottom);
              }
            }
          }
        }
      }
      e.DrawFocusRectangle();
    }

    protected override void OnDropDown(EventArgs e)
    {
      base.OnDropDown(e);
      if (this._TotalWidth <= 0)
        return;
      this.DropDownWidth = this._TotalWidth;
    }

    protected override void OnKeyDown(KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.Escape)
      {
        this.SelectedIndex = -1;
        this.Text = "";
        if (this._LinkedTextBox == null)
          return;
        this._LinkedTextBox.Text = "";
      }
      else
      {
        if (e.KeyCode != Keys.F5 || this.OpenSearchForm == null)
          return;
        this.OpenSearchForm((object) this, EventArgs.Empty);
      }
    }

    protected override void OnKeyPress(KeyPressEventArgs e)
    {
      this.DroppedDown = this._AutoDropdown;
      if (!char.IsControl(e.KeyChar))
      {
        if (this._AutoComplete)
        {
          string s = this.Text.Substring(0, this.SelectionStart) + (object) e.KeyChar;
          int num = this.FindStringExact(s);
          if (num == -1)
            num = this.FindString(s);
          else
            this.DroppedDown = false;
          if (num != -1)
          {
            this.SelectedIndex = num;
            this.SelectionStart = s.Length;
            this.SelectionLength = this.Text.Length - this.SelectionStart;
          }
          else
            e.KeyChar = char.MinValue;
        }
        else
        {
          int @string = this.FindString(e.KeyChar.ToString(), this.SelectedIndex);
          if (@string != -1)
            this.SelectedIndex = @string;
        }
      }
      if ((int) e.KeyChar == 8 && this._AutoComplete && Convert.ToBoolean(this.SelectionStart))
      {
        string s = this.Text.Substring(0, this.SelectionStart - 1);
        int @string = this.FindString(s);
        if (@string != -1)
        {
          this.SelectedIndex = @string;
          this.SelectionStart = s.Length;
          this.SelectionLength = this.Text.Length - this.SelectionStart;
        }
      }
      e.Handled = true;
    }

    protected override void OnSelectedValueChanged(EventArgs e)
    {
      if (this._LinkedTextBox == null || this._LinkedColumnIndex >= this._ColumnNames.Count)
        return;
      this._LinkedTextBox.Text = Convert.ToString(this.FilterItemOnProperty(this.SelectedItem, this._ColumnNames[this._LinkedColumnIndex]));
    }

    protected override bool ProcessCmdKey(ref Message m, Keys k)
    {
      if (m.Msg != 256 || k != Keys.Return)
        return base.ProcessCmdKey(ref m, k);
      SendKeys.Send("\t");
      return true;
    }

    protected override void OnValueMemberChanged(EventArgs e)
    {
      base.OnValueMemberChanged(e);
      this.InitializeValueMemberColumn();
    }

    private void InitializeColumns()
    {
      if (!Convert.ToBoolean(this._ColumnNameString.Length))
      {
        PropertyDescriptorCollection itemProperties = this.DataManager.GetItemProperties();
        this._TotalWidth = 0;
        this._ColumnNames.Clear();
        for (int index = 0; index < itemProperties.Count; ++index)
        {
          this._ColumnNames.Add(itemProperties[index].Name);
          if (index >= this._ColumnWidths.Count)
            this._ColumnWidths.Add(this._ColumnWidthDefault);
          this._TotalWidth += this._ColumnWidths[index];
        }
      }
      else
      {
        this._TotalWidth = 0;
        for (int index = 0; index < this._ColumnNames.Count; ++index)
        {
          if (index >= this._ColumnWidths.Count)
            this._ColumnWidths.Add(this._ColumnWidthDefault);
          this._TotalWidth += this._ColumnWidths[index];
        }
      }
      if (this._LinkedColumnIndex < this._ColumnNames.Count)
        return;
      this._LinkedColumnIndex = 0;
    }

    private void InitializeValueMemberColumn()
    {
      int num = 0;
      foreach (string strA in this._ColumnNames)
      {
        if (string.Compare(strA, this.ValueMember, true, CultureInfo.CurrentUICulture) == 0)
        {
          this._ValueMemberColumnIndex = num;
          break;
        }
        else
          ++num;
      }
    }
  }
}
