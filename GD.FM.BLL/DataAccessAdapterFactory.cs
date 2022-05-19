using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace GD.FM.BLL
{
	public class DataAccessAdapterFactory
	{
		public static DataAccessAdapterBase CreateAdapter(string DatabaseType)
		{
			DataAccessAdapterBase toReturn = null;
            toReturn = new GD.FM.DAL.DatabaseSpecific.DataAccessAdapter();   
			return toReturn;
		}

		public DataAccessAdapterBase CreateAdapter()
		{
			return CreateAdapter(ConfigurationSettings.AppSettings["DefaultDatabaseType"]);
		}
	}
}

