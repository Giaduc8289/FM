using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KTXPT.BLL;
using KTXPT.DAL;
using KTXPT.DAL.EntityClasses;
using KTXPT.DAL.FactoryClasses;
using KTXPT.DAL.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;
namespace KTXPT.DATA
{
    public class USERS
    {
        public static UsersEntity _Current;
        public static RolesEntity _RolesEntity;
    }
}
