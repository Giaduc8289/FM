using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace GD.FM.APP.LIB
{
    #region Enums

    /// <summary>
    /// The functions which can be used for aggreation
    /// </summary>
    public enum AggregateFunction
    {
        Sum,
        Avg,
        Count,
        Max,
        Min
    }

    #endregion

    #region Entity

    /// <summary>
    /// The class which will have properties of function to be performed and on which field
    /// </summary>
    public class DataTableAggregateFunction
    {
        /// <summary>
        /// The function to be performed
        /// </summary>
        public AggregateFunction enmFunction { get; set; }

        /// <summary>
        /// Performed for which column
        /// </summary>
        public string ColumnName { get; set; }

        /// <summary>
        /// What should be the name after output
        /// </summary>
        public string OutPutColumnName { get; set; }
    }

    #endregion


    public class GroupByDataTable
    {
        /// <summary>
        /// Demo for Group By
        /// </summary>
        public void DemoGroupBy()
        {
            //Gets the mock data table
            DataTable _dt = GetDataTable();

            //Add columns which you want to group by
            IList<string> _groupByColumnNames = new List<string>();
            _groupByColumnNames.Add("State");
            _groupByColumnNames.Add("City");

            //Functions you want to perform on which fields
            IList<DataTableAggregateFunction> _fieldsForCalculation = new List<DataTableAggregateFunction>();
            _fieldsForCalculation.Add(new DataTableAggregateFunction() { enmFunction = AggregateFunction.Avg, ColumnName = "Population", OutPutColumnName = "PopulationAvg" });
            _fieldsForCalculation.Add(new DataTableAggregateFunction() { enmFunction = AggregateFunction.Sum, ColumnName = "Population", OutPutColumnName = "PopulationSum" });
            _fieldsForCalculation.Add(new DataTableAggregateFunction() { enmFunction = AggregateFunction.Count, ColumnName = "Population", OutPutColumnName = "PopulationCount" });
            _fieldsForCalculation.Add(new DataTableAggregateFunction() { enmFunction = AggregateFunction.Max, ColumnName = "Year", OutPutColumnName = "YearMax" });
            _fieldsForCalculation.Add(new DataTableAggregateFunction() { enmFunction = AggregateFunction.Min, ColumnName = "Year", OutPutColumnName = "YearMin" });

            //Gets the result after grouping by
            DataTable dtGroupedBy = GetGroupedBy(_dt, _groupByColumnNames, _fieldsForCalculation);
        }


        /// <summary>
        /// Returns a mock data table
        /// </summary>
        /// <returns></returns>
        private DataTable GetDataTable()
        {
            //Declarations
            DataTable _dt = new DataTable();
            DataRow _dr;

            //Create columns
            _dt.Columns.Add(new DataColumn() { ColumnName = "State" });
            _dt.Columns.Add(new DataColumn() { ColumnName = "City" });
            _dt.Columns.Add(new DataColumn() { ColumnName = "Year", DataType = typeof(System.Int32) });
            _dt.Columns.Add(new DataColumn() { ColumnName = "Population", DataType = typeof(System.Int32) });

            //Add mock data
            _dr = _dt.NewRow(); _dr["State"] = "Gujarat"; _dr["City"] = "Ahmedabad"; _dr["Year"] = 2009; _dr["Population"] = 6000000; _dt.Rows.Add(_dr);
            _dr = _dt.NewRow(); _dr["State"] = "Gujarat"; _dr["City"] = "Surat"; _dr["Year"] = 2009; _dr["Population"] = 2000000; _dt.Rows.Add(_dr);
            _dr = _dt.NewRow(); _dr["State"] = "Gujarat"; _dr["City"] = "Rajkot"; _dr["Year"] = 2009; _dr["Population"] = 1000000; _dt.Rows.Add(_dr);
            _dr = _dt.NewRow(); _dr["State"] = "Maharastra"; _dr["City"] = "Mumbai"; _dr["Year"] = 2009; _dr["Population"] = 3000000; _dt.Rows.Add(_dr);
            _dr = _dt.NewRow(); _dr["State"] = "Maharastra"; _dr["City"] = "Pune"; _dr["Year"] = 2009; _dr["Population"] = 3000000; _dt.Rows.Add(_dr);

            _dr = _dt.NewRow(); _dr["State"] = "Gujarat"; _dr["City"] = "Ahmedabad"; _dr["Year"] = 2010; _dr["Population"] = 8000000; _dt.Rows.Add(_dr);
            _dr = _dt.NewRow(); _dr["State"] = "Maharastra"; _dr["City"] = "Mumbai"; _dr["Year"] = 2010; _dr["Population"] = 8000000; _dt.Rows.Add(_dr);

            _dr = _dt.NewRow(); _dr["State"] = "Gujarat"; _dr["City"] = "Ahmedabad"; _dr["Year"] = 2011; _dr["Population"] = 6000000; _dt.Rows.Add(_dr);
            _dr = _dt.NewRow(); _dr["State"] = "Gujarat"; _dr["City"] = "Surat"; _dr["Year"] = 2011; _dr["Population"] = 2000000; _dt.Rows.Add(_dr);
            _dr = _dt.NewRow(); _dr["State"] = "Gujarat"; _dr["City"] = "Rajkot"; _dr["Year"] = 2011; _dr["Population"] = 1000000; _dt.Rows.Add(_dr);
            _dr = _dt.NewRow(); _dr["State"] = "Maharastra"; _dr["City"] = "Mumbai"; _dr["Year"] = 2011; _dr["Population"] = 3000000; _dt.Rows.Add(_dr);
            _dr = _dt.NewRow(); _dr["State"] = "Maharastra"; _dr["City"] = "Pune"; _dr["Year"] = 2011; _dr["Population"] = 3000000; _dt.Rows.Add(_dr);

            //Return table
            return _dt;
        }

        /// <summary>
        /// Group by DataTable
        /// </summary>
        /// <param name="_dtSource"></param>
        /// <param name="_groupByColumnNames"></param>
        /// <param name="_fieldsForCalculation"></param>
        /// <returns></returns>
        public DataTable GetGroupedBy(DataTable _dtSource, IList<string> _groupByColumnNames, IList<DataTableAggregateFunction> _fieldsForCalculation)
        {

            //Once the columns are added find the distinct rows and group it bu the numbet
            DataTable _dtReturn = _dtSource.DefaultView.ToTable(true, _groupByColumnNames.ToArray());

            //The column names in data table
            foreach (DataTableAggregateFunction _calculatedField in _fieldsForCalculation)
            {
                _dtReturn.Columns.Add(_calculatedField.OutPutColumnName,typeof(double));
            }

            //Gets the collection and send it back
            for (int i = 0; i < _dtReturn.Rows.Count; i = i + 1)
            {
                #region Gets the filter string
                string _filterString = string.Empty;
                for (int j = 0; j < _groupByColumnNames.Count; j = j + 1)
                {
                    if (j > 0)
                    {
                        _filterString += " AND ";
                    }
                    if (_dtReturn.Columns[_groupByColumnNames[j]].DataType == typeof(System.Int32))
                    {
                        if (string.IsNullOrEmpty(_dtReturn.Rows[i][_groupByColumnNames[j]].ToString()))
                            _filterString += " ( " + _groupByColumnNames[j] + " = " + _dtReturn.Rows[i][_groupByColumnNames[j]].ToString() + " OR "
                                + _groupByColumnNames[j] + " Is Null ) ";
                        else
                            _filterString += _groupByColumnNames[j] + " = " + _dtReturn.Rows[i][_groupByColumnNames[j]].ToString() + "";
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(_dtReturn.Rows[i][_groupByColumnNames[j]].ToString()))
                            _filterString += " ( " + _groupByColumnNames[j] + " = '" + _dtReturn.Rows[i][_groupByColumnNames[j]].ToString() + "' OR "
                                + _groupByColumnNames[j] + " Is Null ) ";
                        else
                            _filterString += _groupByColumnNames[j] + " = '" + _dtReturn.Rows[i][_groupByColumnNames[j]].ToString() + "'";
                    }
                }
                #endregion

                #region Compute the aggregate command

                foreach (DataTableAggregateFunction _calculatedField in _fieldsForCalculation)
                {
                    _dtReturn.Rows[i][_calculatedField.OutPutColumnName] = _dtSource.Compute(_calculatedField.enmFunction.ToString() + "(" + _calculatedField.ColumnName + ")", _filterString);
                }

                #endregion
            }

            return _dtReturn;
        }
    }

}
