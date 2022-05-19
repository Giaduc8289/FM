


/*
'===============================================================================
'  GD.FM.BL.MenuManagerBase
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
	public class MenuManagerBase
	{
	    
		#region ColumnNames
		
		
		public const String Field_MenuId="MenuId";				
		
		public const String Field_MenuName="MenuName";				
		
		public const String Field_Icon="Icon";				
		
		public const String Field_Issudung="Issudung";				
		
		public const String Field_Istrangthai="Istrangthai";				
		
		public const String Field_Menuparent="Menuparent";				
		
		public const String Field_Thutu="Thutu";				
		
		public const String Field_FormName="FormName";				
		
		public const String Field_LoaiMenu="LoaiMenu";				
		
		public const String Field_Param="Param";				
		
		public const String Field_Maphanhe="Maphanhe";				
		
				
		#endregion	

		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public MenuManagerBase()
		{
			// Nothing for now.
		}
		public DataTable Clone()
		{
			DataTable dt = new DataTable();
			
			
			dt.Columns.Add(Field_MenuId,typeof(System.String));
			
			dt.Columns.Add(Field_MenuName,typeof(System.String));
			
			dt.Columns.Add(Field_Icon,typeof(System.String));
			
			dt.Columns.Add(Field_Issudung,typeof(System.Int32));
			
			dt.Columns.Add(Field_Istrangthai,typeof(System.Int32));
			
			dt.Columns.Add(Field_Menuparent,typeof(System.String));
			
			dt.Columns.Add(Field_Thutu,typeof(System.Int32));
			
			dt.Columns.Add(Field_FormName,typeof(System.String));
			
			dt.Columns.Add(Field_LoaiMenu,typeof(System.Int32));
			
			dt.Columns.Add(Field_Param,typeof(System.String));
			
			dt.Columns.Add(Field_Maphanhe,typeof(System.String));
									
		            
			return dt;			
		}
		public DataRow Convert(MenuEntity _MenuEntity)
		{			
			DataTable dt = new DataTable();
			dt=Clone();
			DataRow r=dt.NewRow();
			
			
			try
			{
				r[Field_MenuId]=_MenuEntity.MenuId;
			}
			catch { }
			
			try
			{
				r[Field_MenuName]=_MenuEntity.MenuName;
			}
			catch { }
			
			try
			{
				r[Field_Icon]=_MenuEntity.Icon;
			}
			catch { }
			
			try
			{
				r[Field_Issudung]=_MenuEntity.Issudung;
			}
			catch { }
			
			try
			{
				r[Field_Istrangthai]=_MenuEntity.Istrangthai;
			}
			catch { }
			
			try
			{
				r[Field_Menuparent]=_MenuEntity.Menuparent;
			}
			catch { }
			
			try
			{
				r[Field_Thutu]=_MenuEntity.Thutu;
			}
			catch { }
			
			try
			{
				r[Field_FormName]=_MenuEntity.FormName;
			}
			catch { }
			
			try
			{
				r[Field_LoaiMenu]=_MenuEntity.LoaiMenu;
			}
			catch { }
			
			try
			{
				r[Field_Param]=_MenuEntity.Param;
			}
			catch { }
			
			try
			{
				r[Field_Maphanhe]=_MenuEntity.Maphanhe;
			}
			catch { }
									
						
			dt.Rows.Add(r);
			return r;
		}		
		
		public MenuEntity Convert(DataRow r)
		{	
			
			MenuEntity _MenuEntity=new MenuEntity(r[Field_MenuId].ToString());					
						
			
			
			try
			{
				_MenuEntity.MenuName= r[Field_MenuName].ToString();						
			}
			catch { }
			
			try
			{
				_MenuEntity.Icon= r[Field_Icon].ToString();						
			}
			catch { }
			
			try
			{
				_MenuEntity.Issudung= System.Int32.Parse(r[Field_Issudung].ToString());						
			}
			catch { }
			
			try
			{
				_MenuEntity.Istrangthai= System.Int32.Parse(r[Field_Istrangthai].ToString());						
			}
			catch { }
			
			try
			{
				_MenuEntity.Menuparent= r[Field_Menuparent].ToString();						
			}
			catch { }
			
			try
			{
				_MenuEntity.Thutu= System.Int32.Parse(r[Field_Thutu].ToString());						
			}
			catch { }
			
			try
			{
				_MenuEntity.FormName= r[Field_FormName].ToString();						
			}
			catch { }
			
			try
			{
				_MenuEntity.LoaiMenu= System.Int32.Parse(r[Field_LoaiMenu].ToString());						
			}
			catch { }
			
			try
			{
				_MenuEntity.Param= r[Field_Param].ToString();						
			}
			catch { }
			
			try
			{
				_MenuEntity.Maphanhe= r[Field_Maphanhe].ToString();						
			}
			catch { }
									
									
			return _MenuEntity;
		}			
		
		public MenuEntity Convert_Entity(MenuEntity _MenuEntity,MenuEntity _MenuEntity_XML)
		{	
			
			
			_MenuEntity.MenuId= _MenuEntity_XML.MenuId;
			
			_MenuEntity.MenuName= _MenuEntity_XML.MenuName;
			
			_MenuEntity.Icon= _MenuEntity_XML.Icon;
			
			_MenuEntity.Issudung= _MenuEntity_XML.Issudung;
			
			_MenuEntity.Istrangthai= _MenuEntity_XML.Istrangthai;
			
			_MenuEntity.Menuparent= _MenuEntity_XML.Menuparent;
			
			_MenuEntity.Thutu= _MenuEntity_XML.Thutu;
			
			_MenuEntity.FormName= _MenuEntity_XML.FormName;
			
			_MenuEntity.LoaiMenu= _MenuEntity_XML.LoaiMenu;
			
			_MenuEntity.Param= _MenuEntity_XML.Param;
			
			_MenuEntity.Maphanhe= _MenuEntity_XML.Maphanhe;
									
				
			return _MenuEntity;
		}	
		
		public String InsertV2(MenuEntity _MenuEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			String id =(new MenuManagerBase()).Insert(_MenuEntity).MenuId.ToString();
			
			
			try
			{
				r.SetField(Field_MenuId,_MenuEntity.MenuId);
			}
			catch { }
			
			
			
			
			try
			{
				r.SetField(Field_MenuName,_MenuEntity.MenuName);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Icon,_MenuEntity.Icon);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Issudung,_MenuEntity.Issudung);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Istrangthai,_MenuEntity.Istrangthai);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Menuparent,_MenuEntity.Menuparent);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Thutu,_MenuEntity.Thutu);
			}
			catch { }
			
			try
			{
				r.SetField(Field_FormName,_MenuEntity.FormName);
			}
			catch { }
			
			try
			{
				r.SetField(Field_LoaiMenu,_MenuEntity.LoaiMenu);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Param,_MenuEntity.Param);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Maphanhe,_MenuEntity.Maphanhe);
			}
			catch { }
									
			
			_BindingSource.ResetCurrentItem();
			return id;
		}
		
		public void UpdateV2(MenuEntity _MenuEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			(new MenuManagerBase()).Update(_MenuEntity);
			r.SetField(Field_MenuId,_MenuEntity.MenuId);
									
			
			
			
			try
			{
				r.SetField(Field_MenuName,_MenuEntity.MenuName);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Icon,_MenuEntity.Icon);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Issudung,_MenuEntity.Issudung);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Istrangthai,_MenuEntity.Istrangthai);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Menuparent,_MenuEntity.Menuparent);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Thutu,_MenuEntity.Thutu);
			}
			catch { }
			
			try
			{
				r.SetField(Field_FormName,_MenuEntity.FormName);
			}
			catch { }
			
			try
			{
				r.SetField(Field_LoaiMenu,_MenuEntity.LoaiMenu);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Param,_MenuEntity.Param);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Maphanhe,_MenuEntity.Maphanhe);
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

		public MenuEntity Insert(MenuEntity MenuEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(MenuEntity, true);
			}
			return MenuEntity;
		}

		public MenuEntity Insert(System.String  MenuId, System.String  MenuName, System.String  Icon, System.Int32  Issudung, System.Int32  Istrangthai, System.String  Menuparent, System.Int32  Thutu, System.String  FormName, System.Int32  LoaiMenu, System.String  Param, System.String  Maphanhe)
		{
			MenuEntity _MenuEntity = new MenuEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_MenuEntity.MenuId = MenuId;
				
				_MenuEntity.MenuName = MenuName;
				
				_MenuEntity.Icon = Icon;
				
				_MenuEntity.Issudung = Issudung;
				
				_MenuEntity.Istrangthai = Istrangthai;
				
				_MenuEntity.Menuparent = Menuparent;
				
				_MenuEntity.Thutu = Thutu;
				
				_MenuEntity.FormName = FormName;
				
				_MenuEntity.LoaiMenu = LoaiMenu;
				
				_MenuEntity.Param = Param;
				
				_MenuEntity.Maphanhe = Maphanhe;
					
					
				adapter.SaveEntity(_MenuEntity, true);
			}
			return _MenuEntity;
		}

		public MenuEntity Insert(System.String MenuName, System.String Icon, System.Int32 Issudung, System.Int32 Istrangthai, System.String Menuparent, System.Int32 Thutu, System.String FormName, System.Int32 LoaiMenu, System.String Param, System.String Maphanhe)//ko co mahieu
		{
			MenuEntity _MenuEntity = new MenuEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				
				_MenuEntity.MenuName = MenuName;
				
				_MenuEntity.Icon = Icon;
				
				_MenuEntity.Issudung = Issudung;
				
				_MenuEntity.Istrangthai = Istrangthai;
				
				_MenuEntity.Menuparent = Menuparent;
				
				_MenuEntity.Thutu = Thutu;
				
				_MenuEntity.FormName = FormName;
				
				_MenuEntity.LoaiMenu = LoaiMenu;
				
				_MenuEntity.Param = Param;
				
				_MenuEntity.Maphanhe = Maphanhe;
					

				adapter.SaveEntity(_MenuEntity, true);
			}
			return _MenuEntity;
		}

		public bool Update(MenuEntity _MenuEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				
				_PredicateExpression.Add(MenuFields.MenuId == _MenuEntity.MenuId);
				
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_MenuEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(MenuEntity _MenuEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_MenuEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(System.String MenuId, System.String MenuName, System.String Icon, System.Int32 Issudung, System.Int32 Istrangthai, System.String Menuparent, System.Int32 Thutu, System.String FormName, System.Int32 LoaiMenu, System.String Param, System.String Maphanhe)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				MenuEntity _MenuEntity = new MenuEntity(MenuId);
				if (adapter.FetchEntity(_MenuEntity))
				{
				
					
					
					_MenuEntity.MenuName = MenuName;
					
					_MenuEntity.Icon = Icon;
					
					_MenuEntity.Issudung = Issudung;
					
					_MenuEntity.Istrangthai = Istrangthai;
					
					_MenuEntity.Menuparent = Menuparent;
					
					_MenuEntity.Thutu = Thutu;
					
					_MenuEntity.FormName = FormName;
					
					_MenuEntity.LoaiMenu = LoaiMenu;
					
					_MenuEntity.Param = Param;
					
					_MenuEntity.Maphanhe = Maphanhe;
						

					adapter.SaveEntity(_MenuEntity, true);
					toReturn = true;
				}
			}
			return toReturn;
		}

		public bool Delete(System.String MenuId)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				MenuEntity _MenuEntity = new MenuEntity(MenuId);
				if (adapter.FetchEntity(_MenuEntity))
				{
					adapter.DeleteEntity(_MenuEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("MenuEntity", null);
			}
		}
		
		
		
		public int DeleteByMenuId(System.String MenuId)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MenuFields.MenuId == MenuId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("MenuEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMenuName(System.String MenuName)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MenuFields.MenuName == MenuName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("MenuEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByIcon(System.String Icon)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MenuFields.Icon == Icon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("MenuEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByIssudung(System.Int32 Issudung)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MenuFields.Issudung == Issudung);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("MenuEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByIstrangthai(System.Int32 Istrangthai)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MenuFields.Istrangthai == Istrangthai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("MenuEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMenuparent(System.String Menuparent)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MenuFields.Menuparent == Menuparent);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("MenuEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByThutu(System.Int32 Thutu)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MenuFields.Thutu == Thutu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("MenuEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByFormName(System.String FormName)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MenuFields.FormName == FormName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("MenuEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByLoaiMenu(System.Int32 LoaiMenu)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MenuFields.LoaiMenu == LoaiMenu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("MenuEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByParam(System.String Param)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MenuFields.Param == Param);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("MenuEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMaphanhe(System.String Maphanhe)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MenuFields.Maphanhe == Maphanhe);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("MenuEntity", filter);
			}
			return toReturn;
		}		
			
		
		public MenuEntity SelectOne(System.String MenuId)
		{
			MenuEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				MenuEntity _MenuEntity = new MenuEntity(MenuId);
				if (adapter.FetchEntity(_MenuEntity))
				{
					toReturn = _MenuEntity;
				}
			}
			return toReturn;
		}

		// Return EntityCollection
		public EntityCollection SelectAll()
		{
			EntityCollection _MenuCollection = new EntityCollection( new MenuEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_MenuCollection, null, 0, null);
			}
			return _MenuCollection;
		}
		
		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _MenuCollection = new EntityCollection(new MenuEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_MenuCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}

		
		
		// Return EntityCollection
		public EntityCollection SelectByMenuId(System.String MenuId)
		{
			EntityCollection _MenuCollection = new EntityCollection(new MenuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MenuFields.MenuId == MenuId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_MenuCollection, filter, 0, null);
			}
			return _MenuCollection;
		}
		// Return DataTable
		public DataTable SelectByMenuIdRDT(System.String MenuId)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _MenuCollection = new EntityCollection(new MenuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MenuFields.MenuId == MenuId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_MenuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMenuName(System.String MenuName)
		{
			EntityCollection _MenuCollection = new EntityCollection(new MenuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MenuFields.MenuName == MenuName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_MenuCollection, filter, 0, null);
			}
			return _MenuCollection;
		}
		// Return DataTable
		public DataTable SelectByMenuNameRDT(System.String MenuName)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _MenuCollection = new EntityCollection(new MenuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MenuFields.MenuName == MenuName);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_MenuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByIcon(System.String Icon)
		{
			EntityCollection _MenuCollection = new EntityCollection(new MenuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MenuFields.Icon == Icon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_MenuCollection, filter, 0, null);
			}
			return _MenuCollection;
		}
		// Return DataTable
		public DataTable SelectByIconRDT(System.String Icon)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _MenuCollection = new EntityCollection(new MenuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MenuFields.Icon == Icon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_MenuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByIssudung(System.Int32 Issudung)
		{
			EntityCollection _MenuCollection = new EntityCollection(new MenuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MenuFields.Issudung == Issudung);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_MenuCollection, filter, 0, null);
			}
			return _MenuCollection;
		}
		// Return DataTable
		public DataTable SelectByIssudungRDT(System.Int32 Issudung)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _MenuCollection = new EntityCollection(new MenuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MenuFields.Issudung == Issudung);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_MenuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByIstrangthai(System.Int32 Istrangthai)
		{
			EntityCollection _MenuCollection = new EntityCollection(new MenuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MenuFields.Istrangthai == Istrangthai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_MenuCollection, filter, 0, null);
			}
			return _MenuCollection;
		}
		// Return DataTable
		public DataTable SelectByIstrangthaiRDT(System.Int32 Istrangthai)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _MenuCollection = new EntityCollection(new MenuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MenuFields.Istrangthai == Istrangthai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_MenuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMenuparent(System.String Menuparent)
		{
			EntityCollection _MenuCollection = new EntityCollection(new MenuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MenuFields.Menuparent == Menuparent);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_MenuCollection, filter, 0, null);
			}
			return _MenuCollection;
		}
		// Return DataTable
		public DataTable SelectByMenuparentRDT(System.String Menuparent)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _MenuCollection = new EntityCollection(new MenuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MenuFields.Menuparent == Menuparent);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_MenuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByThutu(System.Int32 Thutu)
		{
			EntityCollection _MenuCollection = new EntityCollection(new MenuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MenuFields.Thutu == Thutu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_MenuCollection, filter, 0, null);
			}
			return _MenuCollection;
		}
		// Return DataTable
		public DataTable SelectByThutuRDT(System.Int32 Thutu)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _MenuCollection = new EntityCollection(new MenuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MenuFields.Thutu == Thutu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_MenuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByFormName(System.String FormName)
		{
			EntityCollection _MenuCollection = new EntityCollection(new MenuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MenuFields.FormName == FormName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_MenuCollection, filter, 0, null);
			}
			return _MenuCollection;
		}
		// Return DataTable
		public DataTable SelectByFormNameRDT(System.String FormName)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _MenuCollection = new EntityCollection(new MenuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MenuFields.FormName == FormName);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_MenuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByLoaiMenu(System.Int32 LoaiMenu)
		{
			EntityCollection _MenuCollection = new EntityCollection(new MenuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MenuFields.LoaiMenu == LoaiMenu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_MenuCollection, filter, 0, null);
			}
			return _MenuCollection;
		}
		// Return DataTable
		public DataTable SelectByLoaiMenuRDT(System.Int32 LoaiMenu)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _MenuCollection = new EntityCollection(new MenuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MenuFields.LoaiMenu == LoaiMenu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_MenuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByParam(System.String Param)
		{
			EntityCollection _MenuCollection = new EntityCollection(new MenuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MenuFields.Param == Param);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_MenuCollection, filter, 0, null);
			}
			return _MenuCollection;
		}
		// Return DataTable
		public DataTable SelectByParamRDT(System.String Param)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _MenuCollection = new EntityCollection(new MenuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MenuFields.Param == Param);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_MenuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMaphanhe(System.String Maphanhe)
		{
			EntityCollection _MenuCollection = new EntityCollection(new MenuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MenuFields.Maphanhe == Maphanhe);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_MenuCollection, filter, 0, null);
			}
			return _MenuCollection;
		}
		// Return DataTable
		public DataTable SelectByMaphanheRDT(System.String Maphanhe)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _MenuCollection = new EntityCollection(new MenuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MenuFields.Maphanhe == Maphanhe);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_MenuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
			

	}
}
