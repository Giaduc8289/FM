


/*
'===============================================================================
'  GD.FM.BL.ThuchienlogisticManagerBase
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
	public class ThuchienlogisticManagerBase
	{
	    
		#region ColumnNames
		
		
		public const String Field_Id="Id";				
		
		public const String Field_Sohopdong="Sohopdong";				
		
		public const String Field_Ngayhopdong="Ngayhopdong";				
		
		public const String Field_Makhach="Makhach";				
		
		public const String Field_Tenkhach="Tenkhach";				
		
		public const String Field_Mahangphiakhach="Mahangphiakhach";				
		
		public const String Field_Codefiller="Codefiller";				
		
		public const String Field_Soluonggiao="Soluonggiao";				
		
		public const String Field_Ngaygiao="Ngaygiao";				
		
		public const String Field_Buoclogistic="Buoclogistic";				
		
		public const String Field_Tenbuoclogistic="Tenbuoclogistic";				
		
		public const String Field_Ngaythuchien="Ngaythuchien";				
		
		public const String Field_Ngaytao="Ngaytao";				
		
		public const String Field_Nguoitao="Nguoitao";				
		
		public const String Field_Ngaysua="Ngaysua";				
		
		public const String Field_Nguoisua="Nguoisua";				
		
				
		#endregion	

		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public ThuchienlogisticManagerBase()
		{
			// Nothing for now.
		}
		public DataTable Clone()
		{
			DataTable dt = new DataTable();
			
			
			dt.Columns.Add(Field_Id,typeof(System.Int64));
			
			dt.Columns.Add(Field_Sohopdong,typeof(System.String));
			
			dt.Columns.Add(Field_Ngayhopdong,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Makhach,typeof(System.String));
			
			dt.Columns.Add(Field_Tenkhach,typeof(System.String));
			
			dt.Columns.Add(Field_Mahangphiakhach,typeof(System.String));
			
			dt.Columns.Add(Field_Codefiller,typeof(System.String));
			
			dt.Columns.Add(Field_Soluonggiao,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Ngaygiao,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Buoclogistic,typeof(System.String));
			
			dt.Columns.Add(Field_Tenbuoclogistic,typeof(System.String));
			
			dt.Columns.Add(Field_Ngaythuchien,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Ngaytao,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Nguoitao,typeof(System.String));
			
			dt.Columns.Add(Field_Ngaysua,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Nguoisua,typeof(System.String));
									
		            
			return dt;			
		}
		public DataRow Convert(ThuchienlogisticEntity _ThuchienlogisticEntity)
		{			
			DataTable dt = new DataTable();
			dt=Clone();
			DataRow r=dt.NewRow();
			
			
			try
			{
				r[Field_Id]=_ThuchienlogisticEntity.Id;
			}
			catch { }
			
			try
			{
				r[Field_Sohopdong]=_ThuchienlogisticEntity.Sohopdong;
			}
			catch { }
			
			try
			{
				r[Field_Ngayhopdong]=_ThuchienlogisticEntity.Ngayhopdong;
			}
			catch { }
			
			try
			{
				r[Field_Makhach]=_ThuchienlogisticEntity.Makhach;
			}
			catch { }
			
			try
			{
				r[Field_Tenkhach]=_ThuchienlogisticEntity.Tenkhach;
			}
			catch { }
			
			try
			{
				r[Field_Mahangphiakhach]=_ThuchienlogisticEntity.Mahangphiakhach;
			}
			catch { }
			
			try
			{
				r[Field_Codefiller]=_ThuchienlogisticEntity.Codefiller;
			}
			catch { }
			
			try
			{
				r[Field_Soluonggiao]=_ThuchienlogisticEntity.Soluonggiao;
			}
			catch { }
			
			try
			{
				r[Field_Ngaygiao]=_ThuchienlogisticEntity.Ngaygiao;
			}
			catch { }
			
			try
			{
				r[Field_Buoclogistic]=_ThuchienlogisticEntity.Buoclogistic;
			}
			catch { }
			
			try
			{
				r[Field_Tenbuoclogistic]=_ThuchienlogisticEntity.Tenbuoclogistic;
			}
			catch { }
			
			try
			{
				r[Field_Ngaythuchien]=_ThuchienlogisticEntity.Ngaythuchien;
			}
			catch { }
			
			try
			{
				r[Field_Ngaytao]=_ThuchienlogisticEntity.Ngaytao;
			}
			catch { }
			
			try
			{
				r[Field_Nguoitao]=_ThuchienlogisticEntity.Nguoitao;
			}
			catch { }
			
			try
			{
				r[Field_Ngaysua]=_ThuchienlogisticEntity.Ngaysua;
			}
			catch { }
			
			try
			{
				r[Field_Nguoisua]=_ThuchienlogisticEntity.Nguoisua;
			}
			catch { }
									
						
			dt.Rows.Add(r);
			return r;
		}		
		
		public ThuchienlogisticEntity Convert(DataRow r)
		{	
			
			ThuchienlogisticEntity _ThuchienlogisticEntity=new ThuchienlogisticEntity(System.Int64.Parse(r[Field_Id].ToString()));					
						
			
			
			try
			{
				_ThuchienlogisticEntity.Sohopdong= r[Field_Sohopdong].ToString();						
			}
			catch { }
			
			try
			{
				_ThuchienlogisticEntity.Ngayhopdong= System.DateTime.Parse(r[Field_Ngayhopdong].ToString());						
			}
			catch { }
			
			try
			{
				_ThuchienlogisticEntity.Makhach= r[Field_Makhach].ToString();						
			}
			catch { }
			
			try
			{
				_ThuchienlogisticEntity.Tenkhach= r[Field_Tenkhach].ToString();						
			}
			catch { }
			
			try
			{
				_ThuchienlogisticEntity.Mahangphiakhach= r[Field_Mahangphiakhach].ToString();						
			}
			catch { }
			
			try
			{
				_ThuchienlogisticEntity.Codefiller= r[Field_Codefiller].ToString();						
			}
			catch { }
			
			try
			{
				_ThuchienlogisticEntity.Soluonggiao= System.Decimal.Parse(r[Field_Soluonggiao].ToString());						
			}
			catch { }
			
			try
			{
				_ThuchienlogisticEntity.Ngaygiao= System.DateTime.Parse(r[Field_Ngaygiao].ToString());						
			}
			catch { }
			
			try
			{
				_ThuchienlogisticEntity.Buoclogistic= r[Field_Buoclogistic].ToString();						
			}
			catch { }
			
			try
			{
				_ThuchienlogisticEntity.Tenbuoclogistic= r[Field_Tenbuoclogistic].ToString();						
			}
			catch { }
			
			try
			{
				_ThuchienlogisticEntity.Ngaythuchien= System.DateTime.Parse(r[Field_Ngaythuchien].ToString());						
			}
			catch { }
			
			try
			{
				_ThuchienlogisticEntity.Ngaytao= System.DateTime.Parse(r[Field_Ngaytao].ToString());						
			}
			catch { }
			
			try
			{
				_ThuchienlogisticEntity.Nguoitao= r[Field_Nguoitao].ToString();						
			}
			catch { }
			
			try
			{
				_ThuchienlogisticEntity.Ngaysua= System.DateTime.Parse(r[Field_Ngaysua].ToString());						
			}
			catch { }
			
			try
			{
				_ThuchienlogisticEntity.Nguoisua= r[Field_Nguoisua].ToString();						
			}
			catch { }
									
									
			return _ThuchienlogisticEntity;
		}			
		
		public ThuchienlogisticEntity Convert_Entity(ThuchienlogisticEntity _ThuchienlogisticEntity,ThuchienlogisticEntity _ThuchienlogisticEntity_XML)
		{	
			
			
			_ThuchienlogisticEntity.Id= _ThuchienlogisticEntity_XML.Id;
			
			_ThuchienlogisticEntity.Sohopdong= _ThuchienlogisticEntity_XML.Sohopdong;
			
			_ThuchienlogisticEntity.Ngayhopdong= _ThuchienlogisticEntity_XML.Ngayhopdong;
			
			_ThuchienlogisticEntity.Makhach= _ThuchienlogisticEntity_XML.Makhach;
			
			_ThuchienlogisticEntity.Tenkhach= _ThuchienlogisticEntity_XML.Tenkhach;
			
			_ThuchienlogisticEntity.Mahangphiakhach= _ThuchienlogisticEntity_XML.Mahangphiakhach;
			
			_ThuchienlogisticEntity.Codefiller= _ThuchienlogisticEntity_XML.Codefiller;
			
			_ThuchienlogisticEntity.Soluonggiao= _ThuchienlogisticEntity_XML.Soluonggiao;
			
			_ThuchienlogisticEntity.Ngaygiao= _ThuchienlogisticEntity_XML.Ngaygiao;
			
			_ThuchienlogisticEntity.Buoclogistic= _ThuchienlogisticEntity_XML.Buoclogistic;
			
			_ThuchienlogisticEntity.Tenbuoclogistic= _ThuchienlogisticEntity_XML.Tenbuoclogistic;
			
			_ThuchienlogisticEntity.Ngaythuchien= _ThuchienlogisticEntity_XML.Ngaythuchien;
			
			_ThuchienlogisticEntity.Ngaytao= _ThuchienlogisticEntity_XML.Ngaytao;
			
			_ThuchienlogisticEntity.Nguoitao= _ThuchienlogisticEntity_XML.Nguoitao;
			
			_ThuchienlogisticEntity.Ngaysua= _ThuchienlogisticEntity_XML.Ngaysua;
			
			_ThuchienlogisticEntity.Nguoisua= _ThuchienlogisticEntity_XML.Nguoisua;
									
				
			return _ThuchienlogisticEntity;
		}	
		
		public String InsertV2(ThuchienlogisticEntity _ThuchienlogisticEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			String id =(new ThuchienlogisticManagerBase()).Insert(_ThuchienlogisticEntity).Id.ToString();
			
			
			try
			{
				r.SetField(Field_Id,_ThuchienlogisticEntity.Id);
			}
			catch { }
			
			
			
			
			try
			{
				r.SetField(Field_Sohopdong,_ThuchienlogisticEntity.Sohopdong);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngayhopdong,_ThuchienlogisticEntity.Ngayhopdong);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Makhach,_ThuchienlogisticEntity.Makhach);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenkhach,_ThuchienlogisticEntity.Tenkhach);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Mahangphiakhach,_ThuchienlogisticEntity.Mahangphiakhach);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Codefiller,_ThuchienlogisticEntity.Codefiller);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Soluonggiao,_ThuchienlogisticEntity.Soluonggiao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaygiao,_ThuchienlogisticEntity.Ngaygiao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Buoclogistic,_ThuchienlogisticEntity.Buoclogistic);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenbuoclogistic,_ThuchienlogisticEntity.Tenbuoclogistic);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaythuchien,_ThuchienlogisticEntity.Ngaythuchien);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_ThuchienlogisticEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_ThuchienlogisticEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_ThuchienlogisticEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_ThuchienlogisticEntity.Nguoisua);
			}
			catch { }
									
			
			_BindingSource.ResetCurrentItem();
			return id;
		}
		
		public void UpdateV2(ThuchienlogisticEntity _ThuchienlogisticEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			(new ThuchienlogisticManagerBase()).Update(_ThuchienlogisticEntity);
			r.SetField(Field_Id,_ThuchienlogisticEntity.Id);
									
			
			
			
			try
			{
				r.SetField(Field_Sohopdong,_ThuchienlogisticEntity.Sohopdong);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngayhopdong,_ThuchienlogisticEntity.Ngayhopdong);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Makhach,_ThuchienlogisticEntity.Makhach);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenkhach,_ThuchienlogisticEntity.Tenkhach);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Mahangphiakhach,_ThuchienlogisticEntity.Mahangphiakhach);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Codefiller,_ThuchienlogisticEntity.Codefiller);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Soluonggiao,_ThuchienlogisticEntity.Soluonggiao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaygiao,_ThuchienlogisticEntity.Ngaygiao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Buoclogistic,_ThuchienlogisticEntity.Buoclogistic);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenbuoclogistic,_ThuchienlogisticEntity.Tenbuoclogistic);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaythuchien,_ThuchienlogisticEntity.Ngaythuchien);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_ThuchienlogisticEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_ThuchienlogisticEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_ThuchienlogisticEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_ThuchienlogisticEntity.Nguoisua);
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

		public ThuchienlogisticEntity Insert(ThuchienlogisticEntity ThuchienlogisticEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(ThuchienlogisticEntity, true);
			}
			return ThuchienlogisticEntity;
		}

		public ThuchienlogisticEntity Insert(System.Int64  Id, System.String  Sohopdong, System.DateTime  Ngayhopdong, System.String  Makhach, System.String  Tenkhach, System.String  Mahangphiakhach, System.String  Codefiller, System.Decimal  Soluonggiao, System.DateTime  Ngaygiao, System.String  Buoclogistic, System.String  Tenbuoclogistic, System.DateTime  Ngaythuchien, System.DateTime  Ngaytao, System.String  Nguoitao, System.DateTime  Ngaysua, System.String  Nguoisua)
		{
			ThuchienlogisticEntity _ThuchienlogisticEntity = new ThuchienlogisticEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_ThuchienlogisticEntity.Id = Id;
				
				_ThuchienlogisticEntity.Sohopdong = Sohopdong;
				
				_ThuchienlogisticEntity.Ngayhopdong = Ngayhopdong;
				
				_ThuchienlogisticEntity.Makhach = Makhach;
				
				_ThuchienlogisticEntity.Tenkhach = Tenkhach;
				
				_ThuchienlogisticEntity.Mahangphiakhach = Mahangphiakhach;
				
				_ThuchienlogisticEntity.Codefiller = Codefiller;
				
				_ThuchienlogisticEntity.Soluonggiao = Soluonggiao;
				
				_ThuchienlogisticEntity.Ngaygiao = Ngaygiao;
				
				_ThuchienlogisticEntity.Buoclogistic = Buoclogistic;
				
				_ThuchienlogisticEntity.Tenbuoclogistic = Tenbuoclogistic;
				
				_ThuchienlogisticEntity.Ngaythuchien = Ngaythuchien;
				
				_ThuchienlogisticEntity.Ngaytao = Ngaytao;
				
				_ThuchienlogisticEntity.Nguoitao = Nguoitao;
				
				_ThuchienlogisticEntity.Ngaysua = Ngaysua;
				
				_ThuchienlogisticEntity.Nguoisua = Nguoisua;
					
					
				adapter.SaveEntity(_ThuchienlogisticEntity, true);
			}
			return _ThuchienlogisticEntity;
		}

		public ThuchienlogisticEntity Insert(System.String Sohopdong, System.DateTime Ngayhopdong, System.String Makhach, System.String Tenkhach, System.String Mahangphiakhach, System.String Codefiller, System.Decimal Soluonggiao, System.DateTime Ngaygiao, System.String Buoclogistic, System.String Tenbuoclogistic, System.DateTime Ngaythuchien, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua)//ko co mahieu
		{
			ThuchienlogisticEntity _ThuchienlogisticEntity = new ThuchienlogisticEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				
				_ThuchienlogisticEntity.Sohopdong = Sohopdong;
				
				_ThuchienlogisticEntity.Ngayhopdong = Ngayhopdong;
				
				_ThuchienlogisticEntity.Makhach = Makhach;
				
				_ThuchienlogisticEntity.Tenkhach = Tenkhach;
				
				_ThuchienlogisticEntity.Mahangphiakhach = Mahangphiakhach;
				
				_ThuchienlogisticEntity.Codefiller = Codefiller;
				
				_ThuchienlogisticEntity.Soluonggiao = Soluonggiao;
				
				_ThuchienlogisticEntity.Ngaygiao = Ngaygiao;
				
				_ThuchienlogisticEntity.Buoclogistic = Buoclogistic;
				
				_ThuchienlogisticEntity.Tenbuoclogistic = Tenbuoclogistic;
				
				_ThuchienlogisticEntity.Ngaythuchien = Ngaythuchien;
				
				_ThuchienlogisticEntity.Ngaytao = Ngaytao;
				
				_ThuchienlogisticEntity.Nguoitao = Nguoitao;
				
				_ThuchienlogisticEntity.Ngaysua = Ngaysua;
				
				_ThuchienlogisticEntity.Nguoisua = Nguoisua;
					

				adapter.SaveEntity(_ThuchienlogisticEntity, true);
			}
			return _ThuchienlogisticEntity;
		}

		public bool Update(ThuchienlogisticEntity _ThuchienlogisticEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				
				_PredicateExpression.Add(ThuchienlogisticFields.Id == _ThuchienlogisticEntity.Id);
				
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_ThuchienlogisticEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(ThuchienlogisticEntity _ThuchienlogisticEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_ThuchienlogisticEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(System.Int64 Id, System.String Sohopdong, System.DateTime Ngayhopdong, System.String Makhach, System.String Tenkhach, System.String Mahangphiakhach, System.String Codefiller, System.Decimal Soluonggiao, System.DateTime Ngaygiao, System.String Buoclogistic, System.String Tenbuoclogistic, System.DateTime Ngaythuchien, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				ThuchienlogisticEntity _ThuchienlogisticEntity = new ThuchienlogisticEntity(Id);
				if (adapter.FetchEntity(_ThuchienlogisticEntity))
				{
				
					
					
					_ThuchienlogisticEntity.Sohopdong = Sohopdong;
					
					_ThuchienlogisticEntity.Ngayhopdong = Ngayhopdong;
					
					_ThuchienlogisticEntity.Makhach = Makhach;
					
					_ThuchienlogisticEntity.Tenkhach = Tenkhach;
					
					_ThuchienlogisticEntity.Mahangphiakhach = Mahangphiakhach;
					
					_ThuchienlogisticEntity.Codefiller = Codefiller;
					
					_ThuchienlogisticEntity.Soluonggiao = Soluonggiao;
					
					_ThuchienlogisticEntity.Ngaygiao = Ngaygiao;
					
					_ThuchienlogisticEntity.Buoclogistic = Buoclogistic;
					
					_ThuchienlogisticEntity.Tenbuoclogistic = Tenbuoclogistic;
					
					_ThuchienlogisticEntity.Ngaythuchien = Ngaythuchien;
					
					_ThuchienlogisticEntity.Ngaytao = Ngaytao;
					
					_ThuchienlogisticEntity.Nguoitao = Nguoitao;
					
					_ThuchienlogisticEntity.Ngaysua = Ngaysua;
					
					_ThuchienlogisticEntity.Nguoisua = Nguoisua;
						

					adapter.SaveEntity(_ThuchienlogisticEntity, true);
					toReturn = true;
				}
			}
			return toReturn;
		}

		public bool Delete(System.Int64 Id)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				ThuchienlogisticEntity _ThuchienlogisticEntity = new ThuchienlogisticEntity(Id);
				if (adapter.FetchEntity(_ThuchienlogisticEntity))
				{
					adapter.DeleteEntity(_ThuchienlogisticEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("ThuchienlogisticEntity", null);
			}
		}
		
		
		
		public int DeleteById(System.Int64 Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThuchienlogisticFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ThuchienlogisticEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteBySohopdong(System.String Sohopdong)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThuchienlogisticFields.Sohopdong == Sohopdong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ThuchienlogisticEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgayhopdong(System.DateTime Ngayhopdong)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThuchienlogisticFields.Ngayhopdong == Ngayhopdong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ThuchienlogisticEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMakhach(System.String Makhach)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThuchienlogisticFields.Makhach == Makhach);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ThuchienlogisticEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTenkhach(System.String Tenkhach)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThuchienlogisticFields.Tenkhach == Tenkhach);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ThuchienlogisticEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMahangphiakhach(System.String Mahangphiakhach)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThuchienlogisticFields.Mahangphiakhach == Mahangphiakhach);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ThuchienlogisticEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByCodefiller(System.String Codefiller)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThuchienlogisticFields.Codefiller == Codefiller);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ThuchienlogisticEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteBySoluonggiao(System.Decimal Soluonggiao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThuchienlogisticFields.Soluonggiao == Soluonggiao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ThuchienlogisticEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaygiao(System.DateTime Ngaygiao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThuchienlogisticFields.Ngaygiao == Ngaygiao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ThuchienlogisticEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByBuoclogistic(System.String Buoclogistic)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThuchienlogisticFields.Buoclogistic == Buoclogistic);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ThuchienlogisticEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTenbuoclogistic(System.String Tenbuoclogistic)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThuchienlogisticFields.Tenbuoclogistic == Tenbuoclogistic);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ThuchienlogisticEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaythuchien(System.DateTime Ngaythuchien)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThuchienlogisticFields.Ngaythuchien == Ngaythuchien);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ThuchienlogisticEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaytao(System.DateTime Ngaytao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThuchienlogisticFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ThuchienlogisticEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoitao(System.String Nguoitao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThuchienlogisticFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ThuchienlogisticEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaysua(System.DateTime Ngaysua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThuchienlogisticFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ThuchienlogisticEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoisua(System.String Nguoisua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThuchienlogisticFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ThuchienlogisticEntity", filter);
			}
			return toReturn;
		}		
			
		
		public ThuchienlogisticEntity SelectOne(System.Int64 Id)
		{
			ThuchienlogisticEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				ThuchienlogisticEntity _ThuchienlogisticEntity = new ThuchienlogisticEntity(Id);
				if (adapter.FetchEntity(_ThuchienlogisticEntity))
				{
					toReturn = _ThuchienlogisticEntity;
				}
			}
			return toReturn;
		}

		// Return EntityCollection
		public EntityCollection SelectAll()
		{
			EntityCollection _ThuchienlogisticCollection = new EntityCollection( new ThuchienlogisticEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ThuchienlogisticCollection, null, 0, null);
			}
			return _ThuchienlogisticCollection;
		}
		
		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ThuchienlogisticCollection = new EntityCollection(new ThuchienlogisticEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ThuchienlogisticCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}

		
		
		// Return EntityCollection
		public EntityCollection SelectById(System.Int64 Id)
		{
			EntityCollection _ThuchienlogisticCollection = new EntityCollection(new ThuchienlogisticEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThuchienlogisticFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ThuchienlogisticCollection, filter, 0, null);
			}
			return _ThuchienlogisticCollection;
		}
		// Return DataTable
		public DataTable SelectByIdRDT(System.Int64 Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ThuchienlogisticCollection = new EntityCollection(new ThuchienlogisticEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThuchienlogisticFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ThuchienlogisticCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectBySohopdong(System.String Sohopdong)
		{
			EntityCollection _ThuchienlogisticCollection = new EntityCollection(new ThuchienlogisticEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThuchienlogisticFields.Sohopdong == Sohopdong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ThuchienlogisticCollection, filter, 0, null);
			}
			return _ThuchienlogisticCollection;
		}
		// Return DataTable
		public DataTable SelectBySohopdongRDT(System.String Sohopdong)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ThuchienlogisticCollection = new EntityCollection(new ThuchienlogisticEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThuchienlogisticFields.Sohopdong == Sohopdong);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ThuchienlogisticCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgayhopdong(System.DateTime Ngayhopdong)
		{
			EntityCollection _ThuchienlogisticCollection = new EntityCollection(new ThuchienlogisticEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThuchienlogisticFields.Ngayhopdong == Ngayhopdong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ThuchienlogisticCollection, filter, 0, null);
			}
			return _ThuchienlogisticCollection;
		}
		// Return DataTable
		public DataTable SelectByNgayhopdongRDT(System.DateTime Ngayhopdong)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ThuchienlogisticCollection = new EntityCollection(new ThuchienlogisticEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThuchienlogisticFields.Ngayhopdong == Ngayhopdong);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ThuchienlogisticCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMakhach(System.String Makhach)
		{
			EntityCollection _ThuchienlogisticCollection = new EntityCollection(new ThuchienlogisticEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThuchienlogisticFields.Makhach == Makhach);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ThuchienlogisticCollection, filter, 0, null);
			}
			return _ThuchienlogisticCollection;
		}
		// Return DataTable
		public DataTable SelectByMakhachRDT(System.String Makhach)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ThuchienlogisticCollection = new EntityCollection(new ThuchienlogisticEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThuchienlogisticFields.Makhach == Makhach);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ThuchienlogisticCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTenkhach(System.String Tenkhach)
		{
			EntityCollection _ThuchienlogisticCollection = new EntityCollection(new ThuchienlogisticEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThuchienlogisticFields.Tenkhach == Tenkhach);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ThuchienlogisticCollection, filter, 0, null);
			}
			return _ThuchienlogisticCollection;
		}
		// Return DataTable
		public DataTable SelectByTenkhachRDT(System.String Tenkhach)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ThuchienlogisticCollection = new EntityCollection(new ThuchienlogisticEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThuchienlogisticFields.Tenkhach == Tenkhach);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ThuchienlogisticCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMahangphiakhach(System.String Mahangphiakhach)
		{
			EntityCollection _ThuchienlogisticCollection = new EntityCollection(new ThuchienlogisticEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThuchienlogisticFields.Mahangphiakhach == Mahangphiakhach);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ThuchienlogisticCollection, filter, 0, null);
			}
			return _ThuchienlogisticCollection;
		}
		// Return DataTable
		public DataTable SelectByMahangphiakhachRDT(System.String Mahangphiakhach)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ThuchienlogisticCollection = new EntityCollection(new ThuchienlogisticEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThuchienlogisticFields.Mahangphiakhach == Mahangphiakhach);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ThuchienlogisticCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByCodefiller(System.String Codefiller)
		{
			EntityCollection _ThuchienlogisticCollection = new EntityCollection(new ThuchienlogisticEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThuchienlogisticFields.Codefiller == Codefiller);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ThuchienlogisticCollection, filter, 0, null);
			}
			return _ThuchienlogisticCollection;
		}
		// Return DataTable
		public DataTable SelectByCodefillerRDT(System.String Codefiller)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ThuchienlogisticCollection = new EntityCollection(new ThuchienlogisticEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThuchienlogisticFields.Codefiller == Codefiller);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ThuchienlogisticCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectBySoluonggiao(System.Decimal Soluonggiao)
		{
			EntityCollection _ThuchienlogisticCollection = new EntityCollection(new ThuchienlogisticEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThuchienlogisticFields.Soluonggiao == Soluonggiao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ThuchienlogisticCollection, filter, 0, null);
			}
			return _ThuchienlogisticCollection;
		}
		// Return DataTable
		public DataTable SelectBySoluonggiaoRDT(System.Decimal Soluonggiao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ThuchienlogisticCollection = new EntityCollection(new ThuchienlogisticEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThuchienlogisticFields.Soluonggiao == Soluonggiao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ThuchienlogisticCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaygiao(System.DateTime Ngaygiao)
		{
			EntityCollection _ThuchienlogisticCollection = new EntityCollection(new ThuchienlogisticEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThuchienlogisticFields.Ngaygiao == Ngaygiao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ThuchienlogisticCollection, filter, 0, null);
			}
			return _ThuchienlogisticCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaygiaoRDT(System.DateTime Ngaygiao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ThuchienlogisticCollection = new EntityCollection(new ThuchienlogisticEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThuchienlogisticFields.Ngaygiao == Ngaygiao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ThuchienlogisticCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByBuoclogistic(System.String Buoclogistic)
		{
			EntityCollection _ThuchienlogisticCollection = new EntityCollection(new ThuchienlogisticEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThuchienlogisticFields.Buoclogistic == Buoclogistic);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ThuchienlogisticCollection, filter, 0, null);
			}
			return _ThuchienlogisticCollection;
		}
		// Return DataTable
		public DataTable SelectByBuoclogisticRDT(System.String Buoclogistic)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ThuchienlogisticCollection = new EntityCollection(new ThuchienlogisticEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThuchienlogisticFields.Buoclogistic == Buoclogistic);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ThuchienlogisticCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTenbuoclogistic(System.String Tenbuoclogistic)
		{
			EntityCollection _ThuchienlogisticCollection = new EntityCollection(new ThuchienlogisticEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThuchienlogisticFields.Tenbuoclogistic == Tenbuoclogistic);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ThuchienlogisticCollection, filter, 0, null);
			}
			return _ThuchienlogisticCollection;
		}
		// Return DataTable
		public DataTable SelectByTenbuoclogisticRDT(System.String Tenbuoclogistic)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ThuchienlogisticCollection = new EntityCollection(new ThuchienlogisticEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThuchienlogisticFields.Tenbuoclogistic == Tenbuoclogistic);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ThuchienlogisticCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaythuchien(System.DateTime Ngaythuchien)
		{
			EntityCollection _ThuchienlogisticCollection = new EntityCollection(new ThuchienlogisticEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThuchienlogisticFields.Ngaythuchien == Ngaythuchien);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ThuchienlogisticCollection, filter, 0, null);
			}
			return _ThuchienlogisticCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaythuchienRDT(System.DateTime Ngaythuchien)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ThuchienlogisticCollection = new EntityCollection(new ThuchienlogisticEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThuchienlogisticFields.Ngaythuchien == Ngaythuchien);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ThuchienlogisticCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaytao(System.DateTime Ngaytao)
		{
			EntityCollection _ThuchienlogisticCollection = new EntityCollection(new ThuchienlogisticEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThuchienlogisticFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ThuchienlogisticCollection, filter, 0, null);
			}
			return _ThuchienlogisticCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaytaoRDT(System.DateTime Ngaytao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ThuchienlogisticCollection = new EntityCollection(new ThuchienlogisticEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThuchienlogisticFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ThuchienlogisticCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoitao(System.String Nguoitao)
		{
			EntityCollection _ThuchienlogisticCollection = new EntityCollection(new ThuchienlogisticEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThuchienlogisticFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ThuchienlogisticCollection, filter, 0, null);
			}
			return _ThuchienlogisticCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoitaoRDT(System.String Nguoitao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ThuchienlogisticCollection = new EntityCollection(new ThuchienlogisticEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThuchienlogisticFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ThuchienlogisticCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaysua(System.DateTime Ngaysua)
		{
			EntityCollection _ThuchienlogisticCollection = new EntityCollection(new ThuchienlogisticEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThuchienlogisticFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ThuchienlogisticCollection, filter, 0, null);
			}
			return _ThuchienlogisticCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaysuaRDT(System.DateTime Ngaysua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ThuchienlogisticCollection = new EntityCollection(new ThuchienlogisticEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThuchienlogisticFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ThuchienlogisticCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoisua(System.String Nguoisua)
		{
			EntityCollection _ThuchienlogisticCollection = new EntityCollection(new ThuchienlogisticEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThuchienlogisticFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ThuchienlogisticCollection, filter, 0, null);
			}
			return _ThuchienlogisticCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoisuaRDT(System.String Nguoisua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ThuchienlogisticCollection = new EntityCollection(new ThuchienlogisticEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThuchienlogisticFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ThuchienlogisticCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
			

	}
}
