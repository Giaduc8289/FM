///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 2.6
// Code is generated on: 19 May 2022 14:46:06
// Code is generated using templates: SD.TemplateBindings.Linq
// Templates vendor: Solutions Design.
//////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using SD.LLBLGen.Pro.LinqSupportClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

using GD.FM.DAL;
using GD.FM.DAL.EntityClasses;
using GD.FM.DAL.FactoryClasses;
using GD.FM.DAL.HelperClasses;
using GD.FM.DAL.RelationClasses;

namespace GD.FM.DAL.Linq
{
	/// <summary>Meta-data class for the construction of Linq queries which are to be executed using LLBLGen Pro code.</summary>
	public class LinqMetaData: ILinqMetaData
	{
		#region Class Member Declarations
		private IDataAccessAdapter _adapterToUse;
		private FunctionMappingStore _customFunctionMappings;
		private Context _contextToUse;
		#endregion
		
		/// <summary>CTor. Using this ctor will leave the IDataAccessAdapter object to use empty. To be able to execute the query, an IDataAccessAdapter instance
		/// is required, and has to be set on the LLBLGenProProvider2 object in the query to execute. </summary>
		public LinqMetaData() : this(null, null)
		{
		}
		
		/// <summary>CTor which accepts an IDataAccessAdapter implementing object, which will be used to execute queries created with this metadata class.</summary>
		/// <param name="adapterToUse">the IDataAccessAdapter to use in queries created with this meta data</param>
		/// <remarks> Be aware that the IDataAccessAdapter object set via this property is kept alive by the LLBLGenProQuery objects created with this meta data
		/// till they go out of scope.</remarks>
		public LinqMetaData(IDataAccessAdapter adapterToUse) : this (adapterToUse, null)
		{
		}

		/// <summary>CTor which accepts an IDataAccessAdapter implementing object, which will be used to execute queries created with this metadata class.</summary>
		/// <param name="adapterToUse">the IDataAccessAdapter to use in queries created with this meta data</param>
		/// <param name="customFunctionMappings">The custom function mappings to use. These take higher precedence than the ones in the DQE to use.</param>
		/// <remarks> Be aware that the IDataAccessAdapter object set via this property is kept alive by the LLBLGenProQuery objects created with this meta data
		/// till they go out of scope.</remarks>
		public LinqMetaData(IDataAccessAdapter adapterToUse, FunctionMappingStore customFunctionMappings)
		{
			_adapterToUse = adapterToUse;
			_customFunctionMappings = customFunctionMappings;
		}
	
		/// <summary>returns the datasource to use in a Linq query for the entity type specified</summary>
		/// <param name="typeOfEntity">the type of the entity to get the datasource for</param>
		/// <returns>the requested datasource</returns>
		public IDataSource GetQueryableForEntity(int typeOfEntity)
		{
			IDataSource toReturn = null;
			switch((GD.FM.DAL.EntityType)typeOfEntity)
			{
				case GD.FM.DAL.EntityType.DanhmuccangEntity:
					toReturn = this.Danhmuccang;
					break;
				case GD.FM.DAL.EntityType.DanhmuchanghoaEntity:
					toReturn = this.Danhmuchanghoa;
					break;
				case GD.FM.DAL.EntityType.DanhmuckhachEntity:
					toReturn = this.Danhmuckhach;
					break;
				case GD.FM.DAL.EntityType.DanhmucnganhangEntity:
					toReturn = this.Danhmucnganhang;
					break;
				case GD.FM.DAL.EntityType.DanhmucquocgiaEntity:
					toReturn = this.Danhmucquocgia;
					break;
				case GD.FM.DAL.EntityType.DanhmucungdungEntity:
					toReturn = this.Danhmucungdung;
					break;
				case GD.FM.DAL.EntityType.DmcapmaEntity:
					toReturn = this.Dmcapma;
					break;
				case GD.FM.DAL.EntityType.DonvitinhEntity:
					toReturn = this.Donvitinh;
					break;
				case GD.FM.DAL.EntityType.FormcoEntity:
					toReturn = this.Formco;
					break;
				case GD.FM.DAL.EntityType.HopdongbanhangEntity:
					toReturn = this.Hopdongbanhang;
					break;
				case GD.FM.DAL.EntityType.LogbackupEntity:
					toReturn = this.Logbackup;
					break;
				case GD.FM.DAL.EntityType.MenuEntity:
					toReturn = this.Menu;
					break;
				case GD.FM.DAL.EntityType.MenuroleEntity:
					toReturn = this.Menurole;
					break;
				case GD.FM.DAL.EntityType.NhanvienEntity:
					toReturn = this.Nhanvien;
					break;
				case GD.FM.DAL.EntityType.PhuongthucthanhtoanEntity:
					toReturn = this.Phuongthucthanhtoan;
					break;
				case GD.FM.DAL.EntityType.PhuongthucvanchuyenEntity:
					toReturn = this.Phuongthucvanchuyen;
					break;
				case GD.FM.DAL.EntityType.RolesEntity:
					toReturn = this.Roles;
					break;
				case GD.FM.DAL.EntityType.ThamsoEntity:
					toReturn = this.Thamso;
					break;
				case GD.FM.DAL.EntityType.ThuchienhopdongbanhangEntity:
					toReturn = this.Thuchienhopdongbanhang;
					break;
				case GD.FM.DAL.EntityType.TygiaEntity:
					toReturn = this.Tygia;
					break;
				case GD.FM.DAL.EntityType.UsersEntity:
					toReturn = this.Users;
					break;
				default:
					toReturn = null;
					break;
			}
			return toReturn;
		}

		/// <summary>returns the datasource to use in a Linq query when targeting DanhmuccangEntity instances in the database.</summary>
		public DataSource2<DanhmuccangEntity> Danhmuccang
		{
			get { return new DataSource2<DanhmuccangEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting DanhmuchanghoaEntity instances in the database.</summary>
		public DataSource2<DanhmuchanghoaEntity> Danhmuchanghoa
		{
			get { return new DataSource2<DanhmuchanghoaEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting DanhmuckhachEntity instances in the database.</summary>
		public DataSource2<DanhmuckhachEntity> Danhmuckhach
		{
			get { return new DataSource2<DanhmuckhachEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting DanhmucnganhangEntity instances in the database.</summary>
		public DataSource2<DanhmucnganhangEntity> Danhmucnganhang
		{
			get { return new DataSource2<DanhmucnganhangEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting DanhmucquocgiaEntity instances in the database.</summary>
		public DataSource2<DanhmucquocgiaEntity> Danhmucquocgia
		{
			get { return new DataSource2<DanhmucquocgiaEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting DanhmucungdungEntity instances in the database.</summary>
		public DataSource2<DanhmucungdungEntity> Danhmucungdung
		{
			get { return new DataSource2<DanhmucungdungEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting DmcapmaEntity instances in the database.</summary>
		public DataSource2<DmcapmaEntity> Dmcapma
		{
			get { return new DataSource2<DmcapmaEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting DonvitinhEntity instances in the database.</summary>
		public DataSource2<DonvitinhEntity> Donvitinh
		{
			get { return new DataSource2<DonvitinhEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting FormcoEntity instances in the database.</summary>
		public DataSource2<FormcoEntity> Formco
		{
			get { return new DataSource2<FormcoEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting HopdongbanhangEntity instances in the database.</summary>
		public DataSource2<HopdongbanhangEntity> Hopdongbanhang
		{
			get { return new DataSource2<HopdongbanhangEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting LogbackupEntity instances in the database.</summary>
		public DataSource2<LogbackupEntity> Logbackup
		{
			get { return new DataSource2<LogbackupEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting MenuEntity instances in the database.</summary>
		public DataSource2<MenuEntity> Menu
		{
			get { return new DataSource2<MenuEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting MenuroleEntity instances in the database.</summary>
		public DataSource2<MenuroleEntity> Menurole
		{
			get { return new DataSource2<MenuroleEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting NhanvienEntity instances in the database.</summary>
		public DataSource2<NhanvienEntity> Nhanvien
		{
			get { return new DataSource2<NhanvienEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting PhuongthucthanhtoanEntity instances in the database.</summary>
		public DataSource2<PhuongthucthanhtoanEntity> Phuongthucthanhtoan
		{
			get { return new DataSource2<PhuongthucthanhtoanEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting PhuongthucvanchuyenEntity instances in the database.</summary>
		public DataSource2<PhuongthucvanchuyenEntity> Phuongthucvanchuyen
		{
			get { return new DataSource2<PhuongthucvanchuyenEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting RolesEntity instances in the database.</summary>
		public DataSource2<RolesEntity> Roles
		{
			get { return new DataSource2<RolesEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting ThamsoEntity instances in the database.</summary>
		public DataSource2<ThamsoEntity> Thamso
		{
			get { return new DataSource2<ThamsoEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting ThuchienhopdongbanhangEntity instances in the database.</summary>
		public DataSource2<ThuchienhopdongbanhangEntity> Thuchienhopdongbanhang
		{
			get { return new DataSource2<ThuchienhopdongbanhangEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting TygiaEntity instances in the database.</summary>
		public DataSource2<TygiaEntity> Tygia
		{
			get { return new DataSource2<TygiaEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting UsersEntity instances in the database.</summary>
		public DataSource2<UsersEntity> Users
		{
			get { return new DataSource2<UsersEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		
		#region Class Property Declarations
		/// <summary> Gets / sets the IDataAccessAdapter to use for the queries created with this meta data object.</summary>
		/// <remarks> Be aware that the IDataAccessAdapter object set via this property is kept alive by the LLBLGenProQuery objects created with this meta data
		/// till they go out of scope.</remarks>
		public IDataAccessAdapter AdapterToUse
		{
			get { return _adapterToUse;}
			set { _adapterToUse = value;}
		}

		/// <summary>Gets or sets the custom function mappings to use. These take higher precedence than the ones in the DQE to use</summary>
		public FunctionMappingStore CustomFunctionMappings
		{
			get { return _customFunctionMappings; }
			set { _customFunctionMappings = value; }
		}
		
		/// <summary>Gets or sets the Context instance to use for entity fetches.</summary>
		public Context ContextToUse
		{
			get { return _contextToUse;}
			set { _contextToUse = value;}
		}
		#endregion
	}
}