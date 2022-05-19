


/*
'===============================================================================
'  GD.FM.BL.UsersManagerBase
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
using System.Windows.Forms;
namespace GD.FM.BLL
{
	public class UsersManagerBase
	{
	    
		#region ColumnNames
		
		
		public const String Field_Userid="Userid";				
		
		public const String Field_Rolesid="Rolesid";				
		
		public const String Field_Username="Username";				
		
		public const String Field_Fullname="Fullname";				
		
		public const String Field_Phone="Phone";				
		
		public const String Field_Address="Address";				
		
		public const String Field_Password="Password";				
		
		public const String Field_Active="Active";				
		
				
		#endregion	

		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public UsersManagerBase()
		{
			// Nothing for now.
		}
		public DataTable Clone()
		{
			DataTable dt = new DataTable();
			
			
			dt.Columns.Add(Field_Userid,typeof(System.String));
			
			dt.Columns.Add(Field_Rolesid,typeof(System.String));
			
			dt.Columns.Add(Field_Username,typeof(System.String));
			
			dt.Columns.Add(Field_Fullname,typeof(System.String));
			
			dt.Columns.Add(Field_Phone,typeof(System.String));
			
			dt.Columns.Add(Field_Address,typeof(System.String));
			
			dt.Columns.Add(Field_Password,typeof(System.String));
			
			dt.Columns.Add(Field_Active,typeof(System.Boolean));
									
		            
			return dt;			
		}
		public DataRow Convert(UsersEntity _UsersEntity)
		{			
			DataTable dt = new DataTable();
			dt=Clone();
			DataRow r=dt.NewRow();
			
			
			try
			{
				r[Field_Userid]=_UsersEntity.Userid;
			}
			catch { }
			
			try
			{
				r[Field_Rolesid]=_UsersEntity.Rolesid;
			}
			catch { }
			
			try
			{
				r[Field_Username]=_UsersEntity.Username;
			}
			catch { }
			
			try
			{
				r[Field_Fullname]=_UsersEntity.Fullname;
			}
			catch { }
			
			try
			{
				r[Field_Phone]=_UsersEntity.Phone;
			}
			catch { }
			
			try
			{
				r[Field_Address]=_UsersEntity.Address;
			}
			catch { }
			
			try
			{
				r[Field_Password]=_UsersEntity.Password;
			}
			catch { }
			
			try
			{
				r[Field_Active]=_UsersEntity.Active;
			}
			catch { }
									
						
			dt.Rows.Add(r);
			return r;
		}		
		
		public UsersEntity Convert(DataRow r)
		{	
			
			UsersEntity _UsersEntity=new UsersEntity(r[Field_Userid].ToString());					
						
			
			
			try
			{
				_UsersEntity.Rolesid= r[Field_Rolesid].ToString();						
			}
			catch { }
			
			try
			{
				_UsersEntity.Username= r[Field_Username].ToString();						
			}
			catch { }
			
			try
			{
				_UsersEntity.Fullname= r[Field_Fullname].ToString();						
			}
			catch { }
			
			try
			{
				_UsersEntity.Phone= r[Field_Phone].ToString();						
			}
			catch { }
			
			try
			{
				_UsersEntity.Address= r[Field_Address].ToString();						
			}
			catch { }
			
			try
			{
				_UsersEntity.Password= r[Field_Password].ToString();						
			}
			catch { }
			
			try
			{
				_UsersEntity.Active= System.Boolean.Parse(r[Field_Active].ToString());						
			}
			catch { }
									
									
			return _UsersEntity;
		}			
		
		public UsersEntity Convert_Entity(UsersEntity _UsersEntity,UsersEntity _UsersEntity_XML)
		{	
			
			
			_UsersEntity.Userid= _UsersEntity_XML.Userid;
			
			_UsersEntity.Rolesid= _UsersEntity_XML.Rolesid;
			
			_UsersEntity.Username= _UsersEntity_XML.Username;
			
			_UsersEntity.Fullname= _UsersEntity_XML.Fullname;
			
			_UsersEntity.Phone= _UsersEntity_XML.Phone;
			
			_UsersEntity.Address= _UsersEntity_XML.Address;
			
			_UsersEntity.Password= _UsersEntity_XML.Password;
			
			_UsersEntity.Active= _UsersEntity_XML.Active;
									
				
			return _UsersEntity;
		}	
		
		public String InsertV2(UsersEntity _UsersEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			String id =(new UsersManagerBase()).Insert(_UsersEntity).Userid.ToString();
			
			
			try
			{
				r.SetField(Field_Userid,_UsersEntity.Userid);
			}
			catch { }
			
			
			
			
			try
			{
				r.SetField(Field_Rolesid,_UsersEntity.Rolesid);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Username,_UsersEntity.Username);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Fullname,_UsersEntity.Fullname);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Phone,_UsersEntity.Phone);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Address,_UsersEntity.Address);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Password,_UsersEntity.Password);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Active,_UsersEntity.Active);
			}
			catch { }
									
			
			_BindingSource.ResetCurrentItem();
			return id;
		}
		
		public void UpdateV2(UsersEntity _UsersEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			(new UsersManagerBase()).Update(_UsersEntity);
			r.SetField(Field_Userid,_UsersEntity.Userid);
									
			
			
			
			try
			{
				r.SetField(Field_Rolesid,_UsersEntity.Rolesid);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Username,_UsersEntity.Username);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Fullname,_UsersEntity.Fullname);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Phone,_UsersEntity.Phone);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Address,_UsersEntity.Address);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Password,_UsersEntity.Password);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Active,_UsersEntity.Active);
			}
			catch { }
									
			
			_BindingSource.ResetCurrentItem();
		}

		public void InsertCollection(EntityCollection _Collection)
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntityCollection(_Collection);
			}
		}

		public UsersEntity Insert(UsersEntity UsersEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(UsersEntity, true);
			}
			return UsersEntity;
		}

		public UsersEntity Insert(System.String  Userid, System.String  Rolesid, System.String  Username, System.String  Fullname, System.String  Phone, System.String  Address, System.String  Password, System.Boolean  Active)
		{
			UsersEntity _UsersEntity = new UsersEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_UsersEntity.Userid = Userid;
				
				_UsersEntity.Rolesid = Rolesid;
				
				_UsersEntity.Username = Username;
				
				_UsersEntity.Fullname = Fullname;
				
				_UsersEntity.Phone = Phone;
				
				_UsersEntity.Address = Address;
				
				_UsersEntity.Password = Password;
				
				_UsersEntity.Active = Active;
					
					
				adapter.SaveEntity(_UsersEntity, true);
			}
			return _UsersEntity;
		}

		public UsersEntity Insert(System.String Rolesid, System.String Username, System.String Fullname, System.String Phone, System.String Address, System.String Password, System.Boolean Active)//ko co mahieu
		{
			UsersEntity _UsersEntity = new UsersEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				
				_UsersEntity.Rolesid = Rolesid;
				
				_UsersEntity.Username = Username;
				
				_UsersEntity.Fullname = Fullname;
				
				_UsersEntity.Phone = Phone;
				
				_UsersEntity.Address = Address;
				
				_UsersEntity.Password = Password;
				
				_UsersEntity.Active = Active;
					

				adapter.SaveEntity(_UsersEntity, true);
			}
			return _UsersEntity;
		}

		public bool Update(UsersEntity _UsersEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				
				_PredicateExpression.Add(UsersFields.Userid == _UsersEntity.Userid);
				
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_UsersEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(UsersEntity _UsersEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_UsersEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(System.String Userid, System.String Rolesid, System.String Username, System.String Fullname, System.String Phone, System.String Address, System.String Password, System.Boolean Active)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				UsersEntity _UsersEntity = new UsersEntity(Userid);
				if (adapter.FetchEntity(_UsersEntity))
				{
				
					
					
					_UsersEntity.Rolesid = Rolesid;
					
					_UsersEntity.Username = Username;
					
					_UsersEntity.Fullname = Fullname;
					
					_UsersEntity.Phone = Phone;
					
					_UsersEntity.Address = Address;
					
					_UsersEntity.Password = Password;
					
					_UsersEntity.Active = Active;
						

					adapter.SaveEntity(_UsersEntity, true);
					toReturn = true;
				}
			}
			return toReturn;
		}

		public bool Delete(System.String Userid)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				UsersEntity _UsersEntity = new UsersEntity(Userid);
				if (adapter.FetchEntity(_UsersEntity))
				{
					adapter.DeleteEntity(_UsersEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("UsersEntity", null);
			}
		}
		
		
		
		public int DeleteByUserid(System.String Userid)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(UsersFields.Userid == Userid);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("UsersEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByRolesid(System.String Rolesid)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(UsersFields.Rolesid == Rolesid);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("UsersEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByUsername(System.String Username)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(UsersFields.Username == Username);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("UsersEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByFullname(System.String Fullname)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(UsersFields.Fullname == Fullname);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("UsersEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByPhone(System.String Phone)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(UsersFields.Phone == Phone);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("UsersEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByAddress(System.String Address)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(UsersFields.Address == Address);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("UsersEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByPassword(System.String Password)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(UsersFields.Password == Password);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("UsersEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByActive(System.Boolean Active)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(UsersFields.Active == Active);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("UsersEntity", filter);
			}
			return toReturn;
		}		
			
		
		public UsersEntity SelectOne(System.String Userid)
		{
			UsersEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				UsersEntity _UsersEntity = new UsersEntity(Userid);
				if (adapter.FetchEntity(_UsersEntity))
				{
					toReturn = _UsersEntity;
				}
			}
			return toReturn;
		}

		// Return EntityCollection
		public EntityCollection SelectAll()
		{
			EntityCollection _UsersCollection = new EntityCollection( new UsersEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_UsersCollection, null, 0, null);
			}
			return _UsersCollection;
		}
		
		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _UsersCollection = new EntityCollection(new UsersEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_UsersCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}

		
		
		// Return EntityCollection
		public EntityCollection SelectByUserid(System.String Userid)
		{
			EntityCollection _UsersCollection = new EntityCollection(new UsersEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(UsersFields.Userid == Userid);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_UsersCollection, filter, 0, null);
			}
			return _UsersCollection;
		}
		// Return DataTable
		public DataTable SelectByUseridRDT(System.String Userid)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _UsersCollection = new EntityCollection(new UsersEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(UsersFields.Userid == Userid);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_UsersCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByRolesid(System.String Rolesid)
		{
			EntityCollection _UsersCollection = new EntityCollection(new UsersEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(UsersFields.Rolesid == Rolesid);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_UsersCollection, filter, 0, null);
			}
			return _UsersCollection;
		}
		// Return DataTable
		public DataTable SelectByRolesidRDT(System.String Rolesid)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _UsersCollection = new EntityCollection(new UsersEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(UsersFields.Rolesid == Rolesid);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_UsersCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByUsername(System.String Username)
		{
			EntityCollection _UsersCollection = new EntityCollection(new UsersEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(UsersFields.Username == Username);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_UsersCollection, filter, 0, null);
			}
			return _UsersCollection;
		}
		// Return DataTable
		public DataTable SelectByUsernameRDT(System.String Username)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _UsersCollection = new EntityCollection(new UsersEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(UsersFields.Username == Username);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_UsersCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByFullname(System.String Fullname)
		{
			EntityCollection _UsersCollection = new EntityCollection(new UsersEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(UsersFields.Fullname == Fullname);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_UsersCollection, filter, 0, null);
			}
			return _UsersCollection;
		}
		// Return DataTable
		public DataTable SelectByFullnameRDT(System.String Fullname)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _UsersCollection = new EntityCollection(new UsersEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(UsersFields.Fullname == Fullname);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_UsersCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByPhone(System.String Phone)
		{
			EntityCollection _UsersCollection = new EntityCollection(new UsersEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(UsersFields.Phone == Phone);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_UsersCollection, filter, 0, null);
			}
			return _UsersCollection;
		}
		// Return DataTable
		public DataTable SelectByPhoneRDT(System.String Phone)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _UsersCollection = new EntityCollection(new UsersEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(UsersFields.Phone == Phone);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_UsersCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByAddress(System.String Address)
		{
			EntityCollection _UsersCollection = new EntityCollection(new UsersEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(UsersFields.Address == Address);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_UsersCollection, filter, 0, null);
			}
			return _UsersCollection;
		}
		// Return DataTable
		public DataTable SelectByAddressRDT(System.String Address)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _UsersCollection = new EntityCollection(new UsersEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(UsersFields.Address == Address);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_UsersCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByPassword(System.String Password)
		{
			EntityCollection _UsersCollection = new EntityCollection(new UsersEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(UsersFields.Password == Password);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_UsersCollection, filter, 0, null);
			}
			return _UsersCollection;
		}
		// Return DataTable
		public DataTable SelectByPasswordRDT(System.String Password)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _UsersCollection = new EntityCollection(new UsersEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(UsersFields.Password == Password);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_UsersCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByActive(System.Boolean Active)
		{
			EntityCollection _UsersCollection = new EntityCollection(new UsersEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(UsersFields.Active == Active);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_UsersCollection, filter, 0, null);
			}
			return _UsersCollection;
		}
		// Return DataTable
		public DataTable SelectByActiveRDT(System.Boolean Active)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _UsersCollection = new EntityCollection(new UsersEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(UsersFields.Active == Active);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_UsersCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
			

	}
}
