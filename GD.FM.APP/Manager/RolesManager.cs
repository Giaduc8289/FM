
/*
'===============================================================================
'  GD.FM.BL.DanhmucManager
'===============================================================================
*/

using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using GD.FM.BLL;
using GD.FM.DAL;
using GD.FM.DAL.EntityClasses;
using GD.FM.DAL.FactoryClasses;
using GD.FM.DAL.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace GD.FM.BLL
{
	public class RolesManager : RolesManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
        public static string ROLE_ADMINISTRATOR = "ADMINISTRATOR";
        public RolesManager()
		{
			// Nothing for now.
		}
	}
}
