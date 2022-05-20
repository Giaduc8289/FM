///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 2.6
// Code is generated on: 20 May 2022 16:33:50
// Code is generated using templates: SD.TemplateBindings.SharedTemplates.NET20
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using GD.FM.DAL.EntityClasses;
using GD.FM.DAL.HelperClasses;
using GD.FM.DAL.RelationClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace GD.FM.DAL.FactoryClasses
{
	
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END
	
	/// <summary>general base class for the generated factories</summary>
	[Serializable]
	public partial class EntityFactoryBase2 : EntityFactoryCore2
	{
		private string _entityName;
		private GD.FM.DAL.EntityType _typeOfEntity;
		
		/// <summary>CTor</summary>
		/// <param name="entityName">Name of the entity.</param>
		/// <param name="typeOfEntity">The type of entity.</param>
		public EntityFactoryBase2(string entityName, GD.FM.DAL.EntityType typeOfEntity)
		{
			_entityName = entityName;
			_typeOfEntity = typeOfEntity;
		}
		
		/// <summary>Creates, using the generated EntityFieldsFactory, the IEntityFields2 object for the entity to create.</summary>
		/// <returns>Empty IEntityFields2 object.</returns>
		public override IEntityFields2 CreateFields()
		{
			return EntityFieldsFactory.CreateEntityFieldsObject(_typeOfEntity);
		}
		
		/// <summary>Creates a new entity instance using the GeneralEntityFactory in the generated code, using the passed in entitytype value</summary>
		/// <param name="entityTypeValue">The entity type value of the entity to create an instance for.</param>
		/// <returns>new IEntity instance</returns>
		public override IEntity2 CreateEntityFromEntityTypeValue(int entityTypeValue)
		{
			return GeneralEntityFactory.Create((GD.FM.DAL.EntityType)entityTypeValue);
		}

		/// <summary>Creates the relations collection to the entity to join all targets so this entity can be fetched. </summary>
		/// <param name="objectAlias">The object alias to use for the elements in the relations.</param>
		/// <returns>null if the entity isn't in a hierarchy of type TargetPerEntity, otherwise the relations collection needed to join all targets together to fetch all subtypes of this entity and this entity itself</returns>
		public override IRelationCollection CreateHierarchyRelations(string objectAlias) 
		{
			return InheritanceInfoProviderSingleton.GetInstance().GetHierarchyRelations(_entityName, objectAlias);
		}

		/// <summary>This method retrieves, using the InheritanceInfoprovider, the factory for the entity represented by the values passed in.</summary>
		/// <param name="fieldValues">Field values read from the db, to determine which factory to return, based on the field values passed in.</param>
		/// <param name="entityFieldStartIndexesPerEntity">indexes into values where per entity type their own fields start.</param>
		/// <returns>the factory for the entity which is represented by the values passed in.</returns>
		public override IEntityFactory2 GetEntityFactory(object[] fieldValues, Dictionary<string, int> entityFieldStartIndexesPerEntity) 
		{
			IEntityFactory2 toReturn = (IEntityFactory2)InheritanceInfoProviderSingleton.GetInstance().GetEntityFactory(_entityName, fieldValues, entityFieldStartIndexesPerEntity);
			if(toReturn == null)
			{
				toReturn = this;
			}
			return toReturn;
		}
		
		/// <summary>Gets a predicateexpression which filters on the entity with type belonging to this factory.</summary>
		/// <param name="negate">Flag to produce a NOT filter, (true), or a normal filter (false). </param>
		/// <param name="objectAlias">The object alias to use for the predicate(s).</param>
		/// <returns>ready to use predicateexpression, or an empty predicate expression if the belonging entity isn't a hierarchical type.</returns>
		public override IPredicateExpression GetEntityTypeFilter(bool negate, string objectAlias) 
		{
			return InheritanceInfoProviderSingleton.GetInstance().GetEntityTypeFilter(this.ForEntityName, objectAlias, negate);
		}
				
		/// <summary>returns the name of the entity this factory is for, e.g. "EmployeeEntity"</summary>
		public override string ForEntityName 
		{ 
			get { return _entityName; }
		}
	}
	
	/// <summary>Factory to create new, empty DanhmuccangEntity objects.</summary>
	[Serializable]
	public partial class DanhmuccangEntityFactory : EntityFactoryBase2 {
		/// <summary>CTor</summary>
		public DanhmuccangEntityFactory() : base("DanhmuccangEntity", GD.FM.DAL.EntityType.DanhmuccangEntity) { }

		/// <summary>Creates a new, empty DanhmuccangEntity object.</summary>
		/// <returns>A new, empty DanhmuccangEntity object.</returns>
		public override IEntity2 Create() {
			IEntity2 toReturn = new DanhmuccangEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewDanhmuccang
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new DanhmuccangEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new DanhmuccangEntity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewDanhmuccangUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new generic EntityCollection(Of T) for the entity to which this factory belongs.</summary>
		/// <returns>ready to use generic EntityCollection(Of T) with this factory set as the factory</returns>
		public override IEntityCollection2 CreateEntityCollection()
		{
			return new EntityCollection<DanhmuccangEntity>(this);
		}
		

		#region Included Code

		#endregion
	}	
	/// <summary>Factory to create new, empty DanhmucchucvuEntity objects.</summary>
	[Serializable]
	public partial class DanhmucchucvuEntityFactory : EntityFactoryBase2 {
		/// <summary>CTor</summary>
		public DanhmucchucvuEntityFactory() : base("DanhmucchucvuEntity", GD.FM.DAL.EntityType.DanhmucchucvuEntity) { }

		/// <summary>Creates a new, empty DanhmucchucvuEntity object.</summary>
		/// <returns>A new, empty DanhmucchucvuEntity object.</returns>
		public override IEntity2 Create() {
			IEntity2 toReturn = new DanhmucchucvuEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewDanhmucchucvu
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new DanhmucchucvuEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new DanhmucchucvuEntity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewDanhmucchucvuUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new generic EntityCollection(Of T) for the entity to which this factory belongs.</summary>
		/// <returns>ready to use generic EntityCollection(Of T) with this factory set as the factory</returns>
		public override IEntityCollection2 CreateEntityCollection()
		{
			return new EntityCollection<DanhmucchucvuEntity>(this);
		}
		

		#region Included Code

		#endregion
	}	
	/// <summary>Factory to create new, empty DanhmuchanghoaEntity objects.</summary>
	[Serializable]
	public partial class DanhmuchanghoaEntityFactory : EntityFactoryBase2 {
		/// <summary>CTor</summary>
		public DanhmuchanghoaEntityFactory() : base("DanhmuchanghoaEntity", GD.FM.DAL.EntityType.DanhmuchanghoaEntity) { }

		/// <summary>Creates a new, empty DanhmuchanghoaEntity object.</summary>
		/// <returns>A new, empty DanhmuchanghoaEntity object.</returns>
		public override IEntity2 Create() {
			IEntity2 toReturn = new DanhmuchanghoaEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewDanhmuchanghoa
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new DanhmuchanghoaEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new DanhmuchanghoaEntity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewDanhmuchanghoaUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new generic EntityCollection(Of T) for the entity to which this factory belongs.</summary>
		/// <returns>ready to use generic EntityCollection(Of T) with this factory set as the factory</returns>
		public override IEntityCollection2 CreateEntityCollection()
		{
			return new EntityCollection<DanhmuchanghoaEntity>(this);
		}
		

		#region Included Code

		#endregion
	}	
	/// <summary>Factory to create new, empty DanhmuckhachEntity objects.</summary>
	[Serializable]
	public partial class DanhmuckhachEntityFactory : EntityFactoryBase2 {
		/// <summary>CTor</summary>
		public DanhmuckhachEntityFactory() : base("DanhmuckhachEntity", GD.FM.DAL.EntityType.DanhmuckhachEntity) { }

		/// <summary>Creates a new, empty DanhmuckhachEntity object.</summary>
		/// <returns>A new, empty DanhmuckhachEntity object.</returns>
		public override IEntity2 Create() {
			IEntity2 toReturn = new DanhmuckhachEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewDanhmuckhach
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new DanhmuckhachEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new DanhmuckhachEntity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewDanhmuckhachUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new generic EntityCollection(Of T) for the entity to which this factory belongs.</summary>
		/// <returns>ready to use generic EntityCollection(Of T) with this factory set as the factory</returns>
		public override IEntityCollection2 CreateEntityCollection()
		{
			return new EntityCollection<DanhmuckhachEntity>(this);
		}
		

		#region Included Code

		#endregion
	}	
	/// <summary>Factory to create new, empty DanhmucnganhangEntity objects.</summary>
	[Serializable]
	public partial class DanhmucnganhangEntityFactory : EntityFactoryBase2 {
		/// <summary>CTor</summary>
		public DanhmucnganhangEntityFactory() : base("DanhmucnganhangEntity", GD.FM.DAL.EntityType.DanhmucnganhangEntity) { }

		/// <summary>Creates a new, empty DanhmucnganhangEntity object.</summary>
		/// <returns>A new, empty DanhmucnganhangEntity object.</returns>
		public override IEntity2 Create() {
			IEntity2 toReturn = new DanhmucnganhangEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewDanhmucnganhang
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new DanhmucnganhangEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new DanhmucnganhangEntity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewDanhmucnganhangUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new generic EntityCollection(Of T) for the entity to which this factory belongs.</summary>
		/// <returns>ready to use generic EntityCollection(Of T) with this factory set as the factory</returns>
		public override IEntityCollection2 CreateEntityCollection()
		{
			return new EntityCollection<DanhmucnganhangEntity>(this);
		}
		

		#region Included Code

		#endregion
	}	
	/// <summary>Factory to create new, empty DanhmucquocgiaEntity objects.</summary>
	[Serializable]
	public partial class DanhmucquocgiaEntityFactory : EntityFactoryBase2 {
		/// <summary>CTor</summary>
		public DanhmucquocgiaEntityFactory() : base("DanhmucquocgiaEntity", GD.FM.DAL.EntityType.DanhmucquocgiaEntity) { }

		/// <summary>Creates a new, empty DanhmucquocgiaEntity object.</summary>
		/// <returns>A new, empty DanhmucquocgiaEntity object.</returns>
		public override IEntity2 Create() {
			IEntity2 toReturn = new DanhmucquocgiaEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewDanhmucquocgia
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new DanhmucquocgiaEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new DanhmucquocgiaEntity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewDanhmucquocgiaUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new generic EntityCollection(Of T) for the entity to which this factory belongs.</summary>
		/// <returns>ready to use generic EntityCollection(Of T) with this factory set as the factory</returns>
		public override IEntityCollection2 CreateEntityCollection()
		{
			return new EntityCollection<DanhmucquocgiaEntity>(this);
		}
		

		#region Included Code

		#endregion
	}	
	/// <summary>Factory to create new, empty DanhmucungdungEntity objects.</summary>
	[Serializable]
	public partial class DanhmucungdungEntityFactory : EntityFactoryBase2 {
		/// <summary>CTor</summary>
		public DanhmucungdungEntityFactory() : base("DanhmucungdungEntity", GD.FM.DAL.EntityType.DanhmucungdungEntity) { }

		/// <summary>Creates a new, empty DanhmucungdungEntity object.</summary>
		/// <returns>A new, empty DanhmucungdungEntity object.</returns>
		public override IEntity2 Create() {
			IEntity2 toReturn = new DanhmucungdungEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewDanhmucungdung
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new DanhmucungdungEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new DanhmucungdungEntity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewDanhmucungdungUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new generic EntityCollection(Of T) for the entity to which this factory belongs.</summary>
		/// <returns>ready to use generic EntityCollection(Of T) with this factory set as the factory</returns>
		public override IEntityCollection2 CreateEntityCollection()
		{
			return new EntityCollection<DanhmucungdungEntity>(this);
		}
		

		#region Included Code

		#endregion
	}	
	/// <summary>Factory to create new, empty DmcapmaEntity objects.</summary>
	[Serializable]
	public partial class DmcapmaEntityFactory : EntityFactoryBase2 {
		/// <summary>CTor</summary>
		public DmcapmaEntityFactory() : base("DmcapmaEntity", GD.FM.DAL.EntityType.DmcapmaEntity) { }

		/// <summary>Creates a new, empty DmcapmaEntity object.</summary>
		/// <returns>A new, empty DmcapmaEntity object.</returns>
		public override IEntity2 Create() {
			IEntity2 toReturn = new DmcapmaEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewDmcapma
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new DmcapmaEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new DmcapmaEntity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewDmcapmaUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new generic EntityCollection(Of T) for the entity to which this factory belongs.</summary>
		/// <returns>ready to use generic EntityCollection(Of T) with this factory set as the factory</returns>
		public override IEntityCollection2 CreateEntityCollection()
		{
			return new EntityCollection<DmcapmaEntity>(this);
		}
		

		#region Included Code

		#endregion
	}	
	/// <summary>Factory to create new, empty DonvitinhEntity objects.</summary>
	[Serializable]
	public partial class DonvitinhEntityFactory : EntityFactoryBase2 {
		/// <summary>CTor</summary>
		public DonvitinhEntityFactory() : base("DonvitinhEntity", GD.FM.DAL.EntityType.DonvitinhEntity) { }

		/// <summary>Creates a new, empty DonvitinhEntity object.</summary>
		/// <returns>A new, empty DonvitinhEntity object.</returns>
		public override IEntity2 Create() {
			IEntity2 toReturn = new DonvitinhEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewDonvitinh
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new DonvitinhEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new DonvitinhEntity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewDonvitinhUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new generic EntityCollection(Of T) for the entity to which this factory belongs.</summary>
		/// <returns>ready to use generic EntityCollection(Of T) with this factory set as the factory</returns>
		public override IEntityCollection2 CreateEntityCollection()
		{
			return new EntityCollection<DonvitinhEntity>(this);
		}
		

		#region Included Code

		#endregion
	}	
	/// <summary>Factory to create new, empty FormcoEntity objects.</summary>
	[Serializable]
	public partial class FormcoEntityFactory : EntityFactoryBase2 {
		/// <summary>CTor</summary>
		public FormcoEntityFactory() : base("FormcoEntity", GD.FM.DAL.EntityType.FormcoEntity) { }

		/// <summary>Creates a new, empty FormcoEntity object.</summary>
		/// <returns>A new, empty FormcoEntity object.</returns>
		public override IEntity2 Create() {
			IEntity2 toReturn = new FormcoEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewFormco
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new FormcoEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new FormcoEntity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewFormcoUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new generic EntityCollection(Of T) for the entity to which this factory belongs.</summary>
		/// <returns>ready to use generic EntityCollection(Of T) with this factory set as the factory</returns>
		public override IEntityCollection2 CreateEntityCollection()
		{
			return new EntityCollection<FormcoEntity>(this);
		}
		

		#region Included Code

		#endregion
	}	
	/// <summary>Factory to create new, empty HopdongbanhangEntity objects.</summary>
	[Serializable]
	public partial class HopdongbanhangEntityFactory : EntityFactoryBase2 {
		/// <summary>CTor</summary>
		public HopdongbanhangEntityFactory() : base("HopdongbanhangEntity", GD.FM.DAL.EntityType.HopdongbanhangEntity) { }

		/// <summary>Creates a new, empty HopdongbanhangEntity object.</summary>
		/// <returns>A new, empty HopdongbanhangEntity object.</returns>
		public override IEntity2 Create() {
			IEntity2 toReturn = new HopdongbanhangEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewHopdongbanhang
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new HopdongbanhangEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new HopdongbanhangEntity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewHopdongbanhangUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new generic EntityCollection(Of T) for the entity to which this factory belongs.</summary>
		/// <returns>ready to use generic EntityCollection(Of T) with this factory set as the factory</returns>
		public override IEntityCollection2 CreateEntityCollection()
		{
			return new EntityCollection<HopdongbanhangEntity>(this);
		}
		

		#region Included Code

		#endregion
	}	
	/// <summary>Factory to create new, empty HopdongbanhangchitietEntity objects.</summary>
	[Serializable]
	public partial class HopdongbanhangchitietEntityFactory : EntityFactoryBase2 {
		/// <summary>CTor</summary>
		public HopdongbanhangchitietEntityFactory() : base("HopdongbanhangchitietEntity", GD.FM.DAL.EntityType.HopdongbanhangchitietEntity) { }

		/// <summary>Creates a new, empty HopdongbanhangchitietEntity object.</summary>
		/// <returns>A new, empty HopdongbanhangchitietEntity object.</returns>
		public override IEntity2 Create() {
			IEntity2 toReturn = new HopdongbanhangchitietEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewHopdongbanhangchitiet
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new HopdongbanhangchitietEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new HopdongbanhangchitietEntity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewHopdongbanhangchitietUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new generic EntityCollection(Of T) for the entity to which this factory belongs.</summary>
		/// <returns>ready to use generic EntityCollection(Of T) with this factory set as the factory</returns>
		public override IEntityCollection2 CreateEntityCollection()
		{
			return new EntityCollection<HopdongbanhangchitietEntity>(this);
		}
		

		#region Included Code

		#endregion
	}	
	/// <summary>Factory to create new, empty LogbackupEntity objects.</summary>
	[Serializable]
	public partial class LogbackupEntityFactory : EntityFactoryBase2 {
		/// <summary>CTor</summary>
		public LogbackupEntityFactory() : base("LogbackupEntity", GD.FM.DAL.EntityType.LogbackupEntity) { }

		/// <summary>Creates a new, empty LogbackupEntity object.</summary>
		/// <returns>A new, empty LogbackupEntity object.</returns>
		public override IEntity2 Create() {
			IEntity2 toReturn = new LogbackupEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewLogbackup
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new LogbackupEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new LogbackupEntity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewLogbackupUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new generic EntityCollection(Of T) for the entity to which this factory belongs.</summary>
		/// <returns>ready to use generic EntityCollection(Of T) with this factory set as the factory</returns>
		public override IEntityCollection2 CreateEntityCollection()
		{
			return new EntityCollection<LogbackupEntity>(this);
		}
		

		#region Included Code

		#endregion
	}	
	/// <summary>Factory to create new, empty MenuEntity objects.</summary>
	[Serializable]
	public partial class MenuEntityFactory : EntityFactoryBase2 {
		/// <summary>CTor</summary>
		public MenuEntityFactory() : base("MenuEntity", GD.FM.DAL.EntityType.MenuEntity) { }

		/// <summary>Creates a new, empty MenuEntity object.</summary>
		/// <returns>A new, empty MenuEntity object.</returns>
		public override IEntity2 Create() {
			IEntity2 toReturn = new MenuEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewMenu
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new MenuEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new MenuEntity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewMenuUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new generic EntityCollection(Of T) for the entity to which this factory belongs.</summary>
		/// <returns>ready to use generic EntityCollection(Of T) with this factory set as the factory</returns>
		public override IEntityCollection2 CreateEntityCollection()
		{
			return new EntityCollection<MenuEntity>(this);
		}
		

		#region Included Code

		#endregion
	}	
	/// <summary>Factory to create new, empty MenuroleEntity objects.</summary>
	[Serializable]
	public partial class MenuroleEntityFactory : EntityFactoryBase2 {
		/// <summary>CTor</summary>
		public MenuroleEntityFactory() : base("MenuroleEntity", GD.FM.DAL.EntityType.MenuroleEntity) { }

		/// <summary>Creates a new, empty MenuroleEntity object.</summary>
		/// <returns>A new, empty MenuroleEntity object.</returns>
		public override IEntity2 Create() {
			IEntity2 toReturn = new MenuroleEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewMenurole
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new MenuroleEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new MenuroleEntity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewMenuroleUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new generic EntityCollection(Of T) for the entity to which this factory belongs.</summary>
		/// <returns>ready to use generic EntityCollection(Of T) with this factory set as the factory</returns>
		public override IEntityCollection2 CreateEntityCollection()
		{
			return new EntityCollection<MenuroleEntity>(this);
		}
		

		#region Included Code

		#endregion
	}	
	/// <summary>Factory to create new, empty NhanvienEntity objects.</summary>
	[Serializable]
	public partial class NhanvienEntityFactory : EntityFactoryBase2 {
		/// <summary>CTor</summary>
		public NhanvienEntityFactory() : base("NhanvienEntity", GD.FM.DAL.EntityType.NhanvienEntity) { }

		/// <summary>Creates a new, empty NhanvienEntity object.</summary>
		/// <returns>A new, empty NhanvienEntity object.</returns>
		public override IEntity2 Create() {
			IEntity2 toReturn = new NhanvienEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewNhanvien
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new NhanvienEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new NhanvienEntity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewNhanvienUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new generic EntityCollection(Of T) for the entity to which this factory belongs.</summary>
		/// <returns>ready to use generic EntityCollection(Of T) with this factory set as the factory</returns>
		public override IEntityCollection2 CreateEntityCollection()
		{
			return new EntityCollection<NhanvienEntity>(this);
		}
		

		#region Included Code

		#endregion
	}	
	/// <summary>Factory to create new, empty PhongbanEntity objects.</summary>
	[Serializable]
	public partial class PhongbanEntityFactory : EntityFactoryBase2 {
		/// <summary>CTor</summary>
		public PhongbanEntityFactory() : base("PhongbanEntity", GD.FM.DAL.EntityType.PhongbanEntity) { }

		/// <summary>Creates a new, empty PhongbanEntity object.</summary>
		/// <returns>A new, empty PhongbanEntity object.</returns>
		public override IEntity2 Create() {
			IEntity2 toReturn = new PhongbanEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewPhongban
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new PhongbanEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new PhongbanEntity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewPhongbanUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new generic EntityCollection(Of T) for the entity to which this factory belongs.</summary>
		/// <returns>ready to use generic EntityCollection(Of T) with this factory set as the factory</returns>
		public override IEntityCollection2 CreateEntityCollection()
		{
			return new EntityCollection<PhongbanEntity>(this);
		}
		

		#region Included Code

		#endregion
	}	
	/// <summary>Factory to create new, empty PhuongthucthanhtoanEntity objects.</summary>
	[Serializable]
	public partial class PhuongthucthanhtoanEntityFactory : EntityFactoryBase2 {
		/// <summary>CTor</summary>
		public PhuongthucthanhtoanEntityFactory() : base("PhuongthucthanhtoanEntity", GD.FM.DAL.EntityType.PhuongthucthanhtoanEntity) { }

		/// <summary>Creates a new, empty PhuongthucthanhtoanEntity object.</summary>
		/// <returns>A new, empty PhuongthucthanhtoanEntity object.</returns>
		public override IEntity2 Create() {
			IEntity2 toReturn = new PhuongthucthanhtoanEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewPhuongthucthanhtoan
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new PhuongthucthanhtoanEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new PhuongthucthanhtoanEntity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewPhuongthucthanhtoanUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new generic EntityCollection(Of T) for the entity to which this factory belongs.</summary>
		/// <returns>ready to use generic EntityCollection(Of T) with this factory set as the factory</returns>
		public override IEntityCollection2 CreateEntityCollection()
		{
			return new EntityCollection<PhuongthucthanhtoanEntity>(this);
		}
		

		#region Included Code

		#endregion
	}	
	/// <summary>Factory to create new, empty PhuongthucvanchuyenEntity objects.</summary>
	[Serializable]
	public partial class PhuongthucvanchuyenEntityFactory : EntityFactoryBase2 {
		/// <summary>CTor</summary>
		public PhuongthucvanchuyenEntityFactory() : base("PhuongthucvanchuyenEntity", GD.FM.DAL.EntityType.PhuongthucvanchuyenEntity) { }

		/// <summary>Creates a new, empty PhuongthucvanchuyenEntity object.</summary>
		/// <returns>A new, empty PhuongthucvanchuyenEntity object.</returns>
		public override IEntity2 Create() {
			IEntity2 toReturn = new PhuongthucvanchuyenEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewPhuongthucvanchuyen
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new PhuongthucvanchuyenEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new PhuongthucvanchuyenEntity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewPhuongthucvanchuyenUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new generic EntityCollection(Of T) for the entity to which this factory belongs.</summary>
		/// <returns>ready to use generic EntityCollection(Of T) with this factory set as the factory</returns>
		public override IEntityCollection2 CreateEntityCollection()
		{
			return new EntityCollection<PhuongthucvanchuyenEntity>(this);
		}
		

		#region Included Code

		#endregion
	}	
	/// <summary>Factory to create new, empty RolesEntity objects.</summary>
	[Serializable]
	public partial class RolesEntityFactory : EntityFactoryBase2 {
		/// <summary>CTor</summary>
		public RolesEntityFactory() : base("RolesEntity", GD.FM.DAL.EntityType.RolesEntity) { }

		/// <summary>Creates a new, empty RolesEntity object.</summary>
		/// <returns>A new, empty RolesEntity object.</returns>
		public override IEntity2 Create() {
			IEntity2 toReturn = new RolesEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewRoles
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new RolesEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new RolesEntity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewRolesUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new generic EntityCollection(Of T) for the entity to which this factory belongs.</summary>
		/// <returns>ready to use generic EntityCollection(Of T) with this factory set as the factory</returns>
		public override IEntityCollection2 CreateEntityCollection()
		{
			return new EntityCollection<RolesEntity>(this);
		}
		

		#region Included Code

		#endregion
	}	
	/// <summary>Factory to create new, empty ThamsoEntity objects.</summary>
	[Serializable]
	public partial class ThamsoEntityFactory : EntityFactoryBase2 {
		/// <summary>CTor</summary>
		public ThamsoEntityFactory() : base("ThamsoEntity", GD.FM.DAL.EntityType.ThamsoEntity) { }

		/// <summary>Creates a new, empty ThamsoEntity object.</summary>
		/// <returns>A new, empty ThamsoEntity object.</returns>
		public override IEntity2 Create() {
			IEntity2 toReturn = new ThamsoEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewThamso
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new ThamsoEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new ThamsoEntity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewThamsoUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new generic EntityCollection(Of T) for the entity to which this factory belongs.</summary>
		/// <returns>ready to use generic EntityCollection(Of T) with this factory set as the factory</returns>
		public override IEntityCollection2 CreateEntityCollection()
		{
			return new EntityCollection<ThamsoEntity>(this);
		}
		

		#region Included Code

		#endregion
	}	
	/// <summary>Factory to create new, empty ThuchienhopdongbanhangEntity objects.</summary>
	[Serializable]
	public partial class ThuchienhopdongbanhangEntityFactory : EntityFactoryBase2 {
		/// <summary>CTor</summary>
		public ThuchienhopdongbanhangEntityFactory() : base("ThuchienhopdongbanhangEntity", GD.FM.DAL.EntityType.ThuchienhopdongbanhangEntity) { }

		/// <summary>Creates a new, empty ThuchienhopdongbanhangEntity object.</summary>
		/// <returns>A new, empty ThuchienhopdongbanhangEntity object.</returns>
		public override IEntity2 Create() {
			IEntity2 toReturn = new ThuchienhopdongbanhangEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewThuchienhopdongbanhang
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new ThuchienhopdongbanhangEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new ThuchienhopdongbanhangEntity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewThuchienhopdongbanhangUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new generic EntityCollection(Of T) for the entity to which this factory belongs.</summary>
		/// <returns>ready to use generic EntityCollection(Of T) with this factory set as the factory</returns>
		public override IEntityCollection2 CreateEntityCollection()
		{
			return new EntityCollection<ThuchienhopdongbanhangEntity>(this);
		}
		

		#region Included Code

		#endregion
	}	
	/// <summary>Factory to create new, empty TygiaEntity objects.</summary>
	[Serializable]
	public partial class TygiaEntityFactory : EntityFactoryBase2 {
		/// <summary>CTor</summary>
		public TygiaEntityFactory() : base("TygiaEntity", GD.FM.DAL.EntityType.TygiaEntity) { }

		/// <summary>Creates a new, empty TygiaEntity object.</summary>
		/// <returns>A new, empty TygiaEntity object.</returns>
		public override IEntity2 Create() {
			IEntity2 toReturn = new TygiaEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewTygia
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new TygiaEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new TygiaEntity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewTygiaUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new generic EntityCollection(Of T) for the entity to which this factory belongs.</summary>
		/// <returns>ready to use generic EntityCollection(Of T) with this factory set as the factory</returns>
		public override IEntityCollection2 CreateEntityCollection()
		{
			return new EntityCollection<TygiaEntity>(this);
		}
		

		#region Included Code

		#endregion
	}	
	/// <summary>Factory to create new, empty UsersEntity objects.</summary>
	[Serializable]
	public partial class UsersEntityFactory : EntityFactoryBase2 {
		/// <summary>CTor</summary>
		public UsersEntityFactory() : base("UsersEntity", GD.FM.DAL.EntityType.UsersEntity) { }

		/// <summary>Creates a new, empty UsersEntity object.</summary>
		/// <returns>A new, empty UsersEntity object.</returns>
		public override IEntity2 Create() {
			IEntity2 toReturn = new UsersEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewUsers
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new UsersEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new UsersEntity(fields);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewUsersUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new generic EntityCollection(Of T) for the entity to which this factory belongs.</summary>
		/// <returns>ready to use generic EntityCollection(Of T) with this factory set as the factory</returns>
		public override IEntityCollection2 CreateEntityCollection()
		{
			return new EntityCollection<UsersEntity>(this);
		}
		

		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty Entity objects based on the entity type specified. Uses  entity specific factory objects</summary>
	[Serializable]
	public partial class GeneralEntityFactory
	{
		/// <summary>Creates a new, empty Entity object of the type specified</summary>
		/// <param name="entityTypeToCreate">The entity type to create.</param>
		/// <returns>A new, empty Entity object.</returns>
		public static IEntity2 Create(GD.FM.DAL.EntityType entityTypeToCreate)
		{
			IEntityFactory2 factoryToUse = null;
			switch(entityTypeToCreate)
			{
				case GD.FM.DAL.EntityType.DanhmuccangEntity:
					factoryToUse = new DanhmuccangEntityFactory();
					break;
				case GD.FM.DAL.EntityType.DanhmucchucvuEntity:
					factoryToUse = new DanhmucchucvuEntityFactory();
					break;
				case GD.FM.DAL.EntityType.DanhmuchanghoaEntity:
					factoryToUse = new DanhmuchanghoaEntityFactory();
					break;
				case GD.FM.DAL.EntityType.DanhmuckhachEntity:
					factoryToUse = new DanhmuckhachEntityFactory();
					break;
				case GD.FM.DAL.EntityType.DanhmucnganhangEntity:
					factoryToUse = new DanhmucnganhangEntityFactory();
					break;
				case GD.FM.DAL.EntityType.DanhmucquocgiaEntity:
					factoryToUse = new DanhmucquocgiaEntityFactory();
					break;
				case GD.FM.DAL.EntityType.DanhmucungdungEntity:
					factoryToUse = new DanhmucungdungEntityFactory();
					break;
				case GD.FM.DAL.EntityType.DmcapmaEntity:
					factoryToUse = new DmcapmaEntityFactory();
					break;
				case GD.FM.DAL.EntityType.DonvitinhEntity:
					factoryToUse = new DonvitinhEntityFactory();
					break;
				case GD.FM.DAL.EntityType.FormcoEntity:
					factoryToUse = new FormcoEntityFactory();
					break;
				case GD.FM.DAL.EntityType.HopdongbanhangEntity:
					factoryToUse = new HopdongbanhangEntityFactory();
					break;
				case GD.FM.DAL.EntityType.HopdongbanhangchitietEntity:
					factoryToUse = new HopdongbanhangchitietEntityFactory();
					break;
				case GD.FM.DAL.EntityType.LogbackupEntity:
					factoryToUse = new LogbackupEntityFactory();
					break;
				case GD.FM.DAL.EntityType.MenuEntity:
					factoryToUse = new MenuEntityFactory();
					break;
				case GD.FM.DAL.EntityType.MenuroleEntity:
					factoryToUse = new MenuroleEntityFactory();
					break;
				case GD.FM.DAL.EntityType.NhanvienEntity:
					factoryToUse = new NhanvienEntityFactory();
					break;
				case GD.FM.DAL.EntityType.PhongbanEntity:
					factoryToUse = new PhongbanEntityFactory();
					break;
				case GD.FM.DAL.EntityType.PhuongthucthanhtoanEntity:
					factoryToUse = new PhuongthucthanhtoanEntityFactory();
					break;
				case GD.FM.DAL.EntityType.PhuongthucvanchuyenEntity:
					factoryToUse = new PhuongthucvanchuyenEntityFactory();
					break;
				case GD.FM.DAL.EntityType.RolesEntity:
					factoryToUse = new RolesEntityFactory();
					break;
				case GD.FM.DAL.EntityType.ThamsoEntity:
					factoryToUse = new ThamsoEntityFactory();
					break;
				case GD.FM.DAL.EntityType.ThuchienhopdongbanhangEntity:
					factoryToUse = new ThuchienhopdongbanhangEntityFactory();
					break;
				case GD.FM.DAL.EntityType.TygiaEntity:
					factoryToUse = new TygiaEntityFactory();
					break;
				case GD.FM.DAL.EntityType.UsersEntity:
					factoryToUse = new UsersEntityFactory();
					break;
			}
			IEntity2 toReturn = null;
			if(factoryToUse != null)
			{
				toReturn = factoryToUse.Create();
			}
			return toReturn;
		}		
	}
		
	/// <summary>Class which is used to obtain the entity factory based on the .NET type of the entity. </summary>
	[Serializable]
	public static class EntityFactoryFactory
	{
#if CF
		/// <summary>Gets the factory of the entity with the GD.FM.DAL.EntityType specified</summary>
		/// <param name="typeOfEntity">The type of entity.</param>
		/// <returns>factory to use or null if not found</returns>
		public static IEntityFactory2 GetFactory(GD.FM.DAL.EntityType typeOfEntity)
		{
			return GeneralEntityFactory.Create(typeOfEntity).GetEntityFactory();
		}
#else
		private static Dictionary<Type, IEntityFactory2> _factoryPerType = new Dictionary<Type, IEntityFactory2>();

		/// <summary>Initializes the <see cref="EntityFactoryFactory"/> class.</summary>
		static EntityFactoryFactory()
		{
			Array entityTypeValues = Enum.GetValues(typeof(GD.FM.DAL.EntityType));
			foreach(int entityTypeValue in entityTypeValues)
			{
				IEntity2 dummy = GeneralEntityFactory.Create((GD.FM.DAL.EntityType)entityTypeValue);
				_factoryPerType.Add(dummy.GetType(), dummy.GetEntityFactory());
			}
		}

		/// <summary>Gets the factory of the entity with the .NET type specified</summary>
		/// <param name="typeOfEntity">The type of entity.</param>
		/// <returns>factory to use or null if not found</returns>
		public static IEntityFactory2 GetFactory(Type typeOfEntity)
		{
			IEntityFactory2 toReturn = null;
			_factoryPerType.TryGetValue(typeOfEntity, out toReturn);
			return toReturn;
		}

		/// <summary>Gets the factory of the entity with the GD.FM.DAL.EntityType specified</summary>
		/// <param name="typeOfEntity">The type of entity.</param>
		/// <returns>factory to use or null if not found</returns>
		public static IEntityFactory2 GetFactory(GD.FM.DAL.EntityType typeOfEntity)
		{
			return GetFactory(GeneralEntityFactory.Create(typeOfEntity).GetType());
		}
#endif		
	}
		
	/// <summary>Element creator for creating project elements from somewhere else, like inside Linq providers.</summary>
	public class ElementCreator : ElementCreatorBase, IElementCreator2
	{
		/// <summary>Gets the factory of the Entity type with the GD.FM.DAL.EntityType value passed in</summary>
		/// <param name="entityTypeValue">The entity type value.</param>
		/// <returns>the entity factory of the entity type or null if not found</returns>
		public IEntityFactory2 GetFactory(int entityTypeValue)
		{
			return (IEntityFactory2)this.GetFactoryImpl(entityTypeValue);
		}
		
		/// <summary>Gets the factory of the Entity type with the .NET type passed in</summary>
		/// <param name="typeOfEntity">The type of entity.</param>
		/// <returns>the entity factory of the entity type or null if not found</returns>
		public IEntityFactory2 GetFactory(Type typeOfEntity)
		{
			return (IEntityFactory2)this.GetFactoryImpl(typeOfEntity);
		}

		/// <summary>Creates a new resultset fields object with the number of field slots reserved as specified</summary>
		/// <param name="numberOfFields">The number of fields.</param>
		/// <returns>ready to use resultsetfields object</returns>
		public IEntityFields2 CreateResultsetFields(int numberOfFields)
		{
			return new ResultsetFields(numberOfFields);
		}

		/// <summary>Creates a new dynamic relation instance</summary>
		/// <param name="leftOperand">The left operand.</param>
		/// <returns>ready to use dynamic relation</returns>
		public override IDynamicRelation CreateDynamicRelation(DerivedTableDefinition leftOperand)
		{
			return new DynamicRelation(leftOperand);
		}

		/// <summary>Creates a new dynamic relation instance</summary>
		/// <param name="leftOperand">The left operand.</param>
		/// <param name="joinType">Type of the join. If None is specified, Inner is assumed.</param>
		/// <param name="rightOperand">The right operand.</param>
		/// <param name="onClause">The on clause for the join.</param>
		/// <returns>ready to use dynamic relation</returns>
		public override IDynamicRelation CreateDynamicRelation(DerivedTableDefinition leftOperand, JoinHint joinType, DerivedTableDefinition rightOperand, IPredicate onClause)
		{
			return new DynamicRelation(leftOperand, joinType, rightOperand, onClause);
		}

		/// <summary>Creates a new dynamic relation instance</summary>
		/// <param name="leftOperand">The left operand.</param>
		/// <param name="joinType">Type of the join. If None is specified, Inner is assumed.</param>
		/// <param name="rightOperandEntityName">Name of the entity, which is used as the right operand.</param>
		/// <param name="aliasRightOperand">The alias of the right operand. If you don't want to / need to alias the right operand (only alias if you have to), specify string.Empty.</param>
		/// <param name="onClause">The on clause for the join.</param>
		/// <returns>ready to use dynamic relation</returns>
		public override IDynamicRelation CreateDynamicRelation(DerivedTableDefinition leftOperand, JoinHint joinType, string rightOperandEntityName, string aliasRightOperand, IPredicate onClause)
		{
			return new DynamicRelation(leftOperand, joinType, (GD.FM.DAL.EntityType)Enum.Parse(typeof(GD.FM.DAL.EntityType), rightOperandEntityName, false), aliasRightOperand, onClause);
		}

		/// <summary>Creates a new dynamic relation instance</summary>
		/// <param name="leftOperandEntityName">Name of the entity which is used as the left operand.</param>
		/// <param name="joinType">Type of the join. If None is specified, Inner is assumed.</param>
		/// <param name="rightOperandEntityName">Name of the entity, which is used as the right operand.</param>
		/// <param name="aliasLeftOperand">The alias of the left operand. If you don't want to / need to alias the right operand (only alias if you have to), specify string.Empty.</param>
		/// <param name="aliasRightOperand">The alias of the right operand. If you don't want to / need to alias the right operand (only alias if you have to), specify string.Empty.</param>
		/// <param name="onClause">The on clause for the join.</param>
		/// <returns>ready to use dynamic relation</returns>
		public override IDynamicRelation CreateDynamicRelation(string leftOperandEntityName, JoinHint joinType, string rightOperandEntityName, string aliasLeftOperand, string aliasRightOperand, IPredicate onClause)
		{
			return new DynamicRelation((GD.FM.DAL.EntityType)Enum.Parse(typeof(GD.FM.DAL.EntityType), leftOperandEntityName, false), joinType, (GD.FM.DAL.EntityType)Enum.Parse(typeof(GD.FM.DAL.EntityType), rightOperandEntityName, false), aliasLeftOperand, aliasRightOperand, onClause);
		}
		
		/// <summary>Obtains the inheritance info provider instance from the singleton </summary>
		/// <returns>The singleton instance of the inheritance info provider</returns>
		public override IInheritanceInfoProvider ObtainInheritanceInfoProviderInstance()
		{
			return InheritanceInfoProviderSingleton.GetInstance();
		}
		
		/// <summary>Implementation of the routine which gets the factory of the Entity type with the GD.FM.DAL.EntityType value passed in</summary>
		/// <param name="entityTypeValue">The entity type value.</param>
		/// <returns>the entity factory of the entity type or null if not found</returns>
		protected override IEntityFactoryCore GetFactoryImpl(int entityTypeValue)
		{
			return EntityFactoryFactory.GetFactory((GD.FM.DAL.EntityType)entityTypeValue);
		}
#if !CF		
		/// <summary>Implementation of the routine which gets the factory of the Entity type with the .NET type passed in</summary>
		/// <param name="typeOfEntity">The type of entity.</param>
		/// <returns>the entity factory of the entity type or null if not found</returns>
		protected override IEntityFactoryCore GetFactoryImpl(Type typeOfEntity)
		{
			return EntityFactoryFactory.GetFactory(typeOfEntity);
		}
#endif
	}
}
