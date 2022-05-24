///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 2.6
// Code is generated on: 24 Tháng Năm 2022 9:06:26 SA
// Code is generated using templates: SD.TemplateBindings.SharedTemplates.NET20
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using System.ComponentModel;
using System.Collections.Generic;
#if !CF
using System.Runtime.Serialization;
#endif
using System.Xml.Serialization;
using GD.FM.DAL;
using GD.FM.DAL.HelperClasses;
using GD.FM.DAL.FactoryClasses;
using GD.FM.DAL.RelationClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace GD.FM.DAL.EntityClasses
{
	
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END
	

	/// <summary>
	/// Entity class which represents the entity 'Dulieuxnk'.<br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public partial class DulieuxnkEntity : CommonEntityBase, ISerializable
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END
			
	{
		#region Class Member Declarations




		
		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static class MemberNames
		{




		}
		#endregion
		
		/// <summary> Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static DulieuxnkEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary> CTor</summary>
		public DulieuxnkEntity():base("DulieuxnkEntity")
		{
			InitClassEmpty(null, CreateFields());
		}

		/// <summary> CTor</summary>
		/// <remarks>For framework usage.</remarks>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public DulieuxnkEntity(IEntityFields2 fields):base("DulieuxnkEntity")
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this DulieuxnkEntity</param>
		public DulieuxnkEntity(IValidator validator):base("DulieuxnkEntity")
		{
			InitClassEmpty(validator, CreateFields());
		}
				

		/// <summary> CTor</summary>
		/// <param name="id">PK value for Dulieuxnk which data should be fetched into this Dulieuxnk object</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public DulieuxnkEntity(System.Int64 id):base("DulieuxnkEntity")
		{
			InitClassEmpty(null, CreateFields());
			this.Id = id;
		}

		/// <summary> CTor</summary>
		/// <param name="id">PK value for Dulieuxnk which data should be fetched into this Dulieuxnk object</param>
		/// <param name="validator">The custom validator object for this DulieuxnkEntity</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public DulieuxnkEntity(System.Int64 id, IValidator validator):base("DulieuxnkEntity")
		{
			InitClassEmpty(validator, CreateFields());
			this.Id = id;
		}

		/// <summary> Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected DulieuxnkEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			if(SerializationHelper.Optimization != SerializationOptimization.Fast) 
			{




				base.FixupDeserialization(FieldInfoProviderSingleton.GetInstance());
			}
			
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
			
		}

		
		/// <summary>Performs the desync setup when an FK field has been changed. The entity referenced based on the FK field will be dereferenced and sync info will be removed.</summary>
		/// <param name="fieldIndex">The fieldindex.</param>
		protected override void PerformDesyncSetupFKFieldChange(int fieldIndex)
		{
			switch((DulieuxnkFieldIndex)fieldIndex)
			{
				default:
					base.PerformDesyncSetupFKFieldChange(fieldIndex);
					break;
			}
		}
				
		/// <summary>Gets the inheritance info provider instance of the project this entity instance is located in. </summary>
		/// <returns>ready to use inheritance info provider instance.</returns>
		protected override IInheritanceInfoProvider GetInheritanceInfoProvider()
		{
			return InheritanceInfoProviderSingleton.GetInstance();
		}
		
		/// <summary> Sets the related entity property to the entity specified. If the property is a collection, it will add the entity specified to that collection.</summary>
		/// <param name="propertyName">Name of the property.</param>
		/// <param name="entity">Entity to set as an related entity</param>
		/// <remarks>Used by prefetch path logic.</remarks>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override void SetRelatedEntityProperty(string propertyName, IEntity2 entity)
		{
			switch(propertyName)
			{




				default:
					break;
			}
		}
		
		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public override RelationCollection GetRelationsForFieldOfType(string fieldName)
		{
			return DulieuxnkEntity.GetRelationsForField(fieldName);
		}

		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public static RelationCollection GetRelationsForField(string fieldName)
		{
			RelationCollection toReturn = new RelationCollection();
			switch(fieldName)
			{




				default:

					break;				
			}
			return toReturn;
		}
#if !CF
		/// <summary>Checks if the relation mapped by the property with the name specified is a one way / single sided relation. If the passed in name is null, it
		/// will return true if the entity has any single-sided relation</summary>
		/// <param name="propertyName">Name of the property which is mapped onto the relation to check, or null to check if the entity has any relation/ which is single sided</param>
		/// <returns>true if the relation is single sided / one way (so the opposite relation isn't present), false otherwise</returns>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override bool CheckOneWayRelations(string propertyName)
		{
			// use template trick to calculate the # of single-sided / oneway relations
			int numberOfOneWayRelations = 0;
			switch(propertyName)
			{
				case null:
					return ((numberOfOneWayRelations > 0) || base.CheckOneWayRelations(null));


				default:
					return base.CheckOneWayRelations(propertyName);
			}
		}
#endif
		/// <summary> Sets the internal parameter related to the fieldname passed to the instance relatedEntity. </summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		/// <param name="fieldName">Name of field mapped onto the relation which resolves in the instance relatedEntity</param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override void SetRelatedEntity(IEntity2 relatedEntity, string fieldName)
		{
			switch(fieldName)
			{



				default:
					break;
			}
		}

		/// <summary> Unsets the internal parameter related to the fieldname passed to the instance relatedEntity. Reverses the actions taken by SetRelatedEntity() </summary>
		/// <param name="relatedEntity">Instance to unset as the related entity of type entityType</param>
		/// <param name="fieldName">Name of field mapped onto the relation which resolves in the instance relatedEntity</param>
		/// <param name="signalRelatedEntityManyToOne">if set to true it will notify the manytoone side, if applicable.</param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override void UnsetRelatedEntity(IEntity2 relatedEntity, string fieldName, bool signalRelatedEntityManyToOne)
		{
			switch(fieldName)
			{



				default:
					break;
			}
		}

		/// <summary> Gets a collection of related entities referenced by this entity which depend on this entity (this entity is the PK side of their FK fields). These entities will have to be persisted after this entity during a recursive save.</summary>
		/// <returns>Collection with 0 or more IEntity2 objects, referenced by this entity</returns>
		public override List<IEntity2> GetDependingRelatedEntities()
		{
			List<IEntity2> toReturn = new List<IEntity2>();

			return toReturn;
		}
		
		/// <summary> Gets a collection of related entities referenced by this entity which this entity depends on (this entity is the FK side of their PK fields). These
		/// entities will have to be persisted before this entity during a recursive save.</summary>
		/// <returns>Collection with 0 or more IEntity2 objects, referenced by this entity</returns>
		public override List<IEntity2> GetDependentRelatedEntities()
		{
			List<IEntity2> toReturn = new List<IEntity2>();


			return toReturn;
		}
		
		/// <summary>Gets a list of all entity collections stored as member variables in this entity. The contents of the ArrayList is used by the DataAccessAdapter to perform recursive saves. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection2 objects, referenced by this entity</returns>
		public override List<IEntityCollection2> GetMemberEntityCollections()
		{
			List<IEntityCollection2> toReturn = new List<IEntityCollection2>();


			return toReturn;
		}
		


		/// <summary>ISerializable member. Does custom serialization so event handlers do not get serialized. Serializes members of this entity class and uses the base class' implementation to serialize the rest.</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			if (SerializationHelper.Optimization != SerializationOptimization.Fast) 
			{




			}
			
			// __LLBLGENPRO_USER_CODE_REGION_START GetObjectInfo
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			base.GetObjectData(info, context);
		}

		/// <summary>Returns true if the original value for the field with the fieldIndex passed in, read from the persistent storage was NULL, false otherwise.
		/// Should not be used for testing if the current value is NULL, use <see cref="TestCurrentFieldValueForNull"/> for that.</summary>
		/// <param name="fieldIndex">Index of the field to test if that field was NULL in the persistent storage</param>
		/// <returns>true if the field with the passed in index was NULL in the persistent storage, false otherwise</returns>
		public bool TestOriginalFieldValueForNull(DulieuxnkFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}
		
		/// <summary>Returns true if the current value for the field with the fieldIndex passed in represents null/not defined, false otherwise.
		/// Should not be used for testing if the original value (read from the db) is NULL</summary>
		/// <param name="fieldIndex">Index of the field to test if its currentvalue is null/undefined</param>
		/// <returns>true if the field's value isn't defined yet, false otherwise</returns>
		public bool TestCurrentFieldValueForNull(DulieuxnkFieldIndex fieldIndex)
		{
			return base.CheckIfCurrentFieldValueIsNull((int)fieldIndex);
		}

				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		public override List<IEntityRelation> GetAllRelations()
		{
			return new DulieuxnkRelations().GetAllRelations();
		}
		




	
		
		/// <summary>Creates entity fields object for this entity. Used in constructor to setup this entity in a polymorphic scenario.</summary>
		protected virtual IEntityFields2 CreateFields()
		{
			return EntityFieldsFactory.CreateEntityFieldsObject(GD.FM.DAL.EntityType.DulieuxnkEntity);
		}

		/// <summary>
		/// Creates the ITypeDefaultValue instance used to provide default values for value types which aren't of type nullable(of T)
		/// </summary>
		/// <returns></returns>
		protected override ITypeDefaultValue CreateTypeDefaultValueProvider()
		{
			return new TypeDefaultValue();
		}

		/// <summary>Creates a new instance of the factory related to this entity</summary>
		protected override IEntityFactory2 CreateEntityFactory()
		{
			return EntityFactoryCache2.GetEntityFactory(typeof(DulieuxnkEntityFactory));
		}
#if !CF
		/// <summary>Adds the member collections to the collections queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void AddToMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue) 
		{
			base.AddToMemberEntityCollectionsQueue(collectionsQueue);


		}
		
		/// <summary>Gets the member collections queue from the queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void GetFromMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue)
		{
			base.GetFromMemberEntityCollectionsQueue(collectionsQueue);


		}
		
		/// <summary>Determines whether the entity has populated member collections</summary>
		/// <returns>true if the entity has populated member collections.</returns>
		protected override bool HasPopulatedMemberEntityCollections()
		{


			return base.HasPopulatedMemberEntityCollections();
		}
		
		/// <summary>Creates the member entity collections queue.</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		/// <param name="requiredQueue">The required queue.</param>
		protected override void CreateMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue, Queue<bool> requiredQueue) 
		{
			base.CreateMemberEntityCollectionsQueue(collectionsQueue, requiredQueue);


		}
#endif
		/// <summary>
		/// Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element. 
		/// </summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		public override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();




			return toReturn;
		}
		
		/// <summary> Adds the internals to the active context. </summary>
		protected override void AddInternalsToContext()
		{




		}

		/// <summary> Initializes the class members</summary>
		protected virtual void InitClassMembers()
		{





			PerformDependencyInjection();
			
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			OnInitClassMembersComplete();
		}

		#region Custom Property Hashtable Setup
		/// <summary> Initializes the hashtables for the entity type and entity field custom properties. </summary>
		private static void SetupCustomPropertyHashtables()
		{
			_customProperties = new Dictionary<string, string>();
			_fieldsCustomProperties = new Dictionary<string, Dictionary<string, string>>();

			Dictionary<string, string> fieldHashtable = null;
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Id", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Nam", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Thang", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Ngaythongquan", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Masothuexuat", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Tencongtyxuat", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Diachicongtyxuat", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Dienthoaicongtyxuat", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Tencongtynhap", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Diachicongtynhap", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Hscode", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Motahanghoa", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Thuexuat", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Xuatxu", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Madonvi", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Sotan", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Giausd", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Soluong", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Dongianguyente", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Dongiausd", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Trigiausd", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Tygiavnd", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Madongtien", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Dieukiengia", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Phuongthucthanhtoan", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Chicuchaiquan", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Loaihinhxuatkhau", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Tennuocxuatkhau", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Tennuocnhapkhau", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Diadiemxephang", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Diadiemnhanhangcuoicung", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Sotokhai", fieldHashtable);
		}
		#endregion



		/// <summary> Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validator">The validator object for this DulieuxnkEntity</param>
		/// <param name="fields">Fields of this entity</param>
		protected virtual void InitClassEmpty(IValidator validator, IEntityFields2 fields)
		{
			OnInitializing();
			base.Fields = fields;
			base.IsNew=true;
			base.Validator = validator;
			InitClassMembers();

			
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassEmpty
			// __LLBLGENPRO_USER_CODE_REGION_END
			

			OnInitialized();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static DulieuxnkRelations Relations
		{
			get	{ return new DulieuxnkRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}





		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		public override Dictionary<string, string> CustomPropertiesOfType
		{
			get { return DulieuxnkEntity.CustomProperties;}
		}

		/// <summary> The custom properties for the fields of this entity type. The returned Hashtable contains per fieldname a hashtable of name-value
		/// pairs. </summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, Dictionary<string, string>> FieldsCustomProperties
		{
			get { return _fieldsCustomProperties;}
		}

		/// <summary> The custom properties for the fields of the type of this entity instance. The returned Hashtable contains per fieldname a hashtable of name-value pairs. </summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		public override Dictionary<string, Dictionary<string, string>> FieldsCustomPropertiesOfType
		{
			get { return DulieuxnkEntity.FieldsCustomProperties;}
		}

		/// <summary> The Id property of the Entity Dulieuxnk<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Dulieuxnk"."Id"<br/>
		/// Table field type characteristics (type, precision, scale, length): BigInt, 19, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int64 Id
		{
			get { return (System.Int64)GetValue((int)DulieuxnkFieldIndex.Id, true); }
			set	{ SetValue((int)DulieuxnkFieldIndex.Id, value); }
		}

		/// <summary> The Nam property of the Entity Dulieuxnk<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Dulieuxnk"."Nam"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> Nam
		{
			get { return (Nullable<System.Int32>)GetValue((int)DulieuxnkFieldIndex.Nam, false); }
			set	{ SetValue((int)DulieuxnkFieldIndex.Nam, value); }
		}

		/// <summary> The Thang property of the Entity Dulieuxnk<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Dulieuxnk"."Thang"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> Thang
		{
			get { return (Nullable<System.Int32>)GetValue((int)DulieuxnkFieldIndex.Thang, false); }
			set	{ SetValue((int)DulieuxnkFieldIndex.Thang, value); }
		}

		/// <summary> The Ngaythongquan property of the Entity Dulieuxnk<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Dulieuxnk"."Ngaythongquan"<br/>
		/// Table field type characteristics (type, precision, scale, length): Date, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> Ngaythongquan
		{
			get { return (Nullable<System.DateTime>)GetValue((int)DulieuxnkFieldIndex.Ngaythongquan, false); }
			set	{ SetValue((int)DulieuxnkFieldIndex.Ngaythongquan, value); }
		}

		/// <summary> The Masothuexuat property of the Entity Dulieuxnk<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Dulieuxnk"."Masothuexuat"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Masothuexuat
		{
			get { return (System.String)GetValue((int)DulieuxnkFieldIndex.Masothuexuat, true); }
			set	{ SetValue((int)DulieuxnkFieldIndex.Masothuexuat, value); }
		}

		/// <summary> The Tencongtyxuat property of the Entity Dulieuxnk<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Dulieuxnk"."Tencongtyxuat"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 250<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Tencongtyxuat
		{
			get { return (System.String)GetValue((int)DulieuxnkFieldIndex.Tencongtyxuat, true); }
			set	{ SetValue((int)DulieuxnkFieldIndex.Tencongtyxuat, value); }
		}

		/// <summary> The Diachicongtyxuat property of the Entity Dulieuxnk<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Dulieuxnk"."Diachicongtyxuat"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 250<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Diachicongtyxuat
		{
			get { return (System.String)GetValue((int)DulieuxnkFieldIndex.Diachicongtyxuat, true); }
			set	{ SetValue((int)DulieuxnkFieldIndex.Diachicongtyxuat, value); }
		}

		/// <summary> The Dienthoaicongtyxuat property of the Entity Dulieuxnk<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Dulieuxnk"."Dienthoaicongtyxuat"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Dienthoaicongtyxuat
		{
			get { return (System.String)GetValue((int)DulieuxnkFieldIndex.Dienthoaicongtyxuat, true); }
			set	{ SetValue((int)DulieuxnkFieldIndex.Dienthoaicongtyxuat, value); }
		}

		/// <summary> The Tencongtynhap property of the Entity Dulieuxnk<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Dulieuxnk"."Tencongtynhap"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 250<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Tencongtynhap
		{
			get { return (System.String)GetValue((int)DulieuxnkFieldIndex.Tencongtynhap, true); }
			set	{ SetValue((int)DulieuxnkFieldIndex.Tencongtynhap, value); }
		}

		/// <summary> The Diachicongtynhap property of the Entity Dulieuxnk<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Dulieuxnk"."Diachicongtynhap"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 250<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Diachicongtynhap
		{
			get { return (System.String)GetValue((int)DulieuxnkFieldIndex.Diachicongtynhap, true); }
			set	{ SetValue((int)DulieuxnkFieldIndex.Diachicongtynhap, value); }
		}

		/// <summary> The Hscode property of the Entity Dulieuxnk<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Dulieuxnk"."Hscode"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Hscode
		{
			get { return (System.String)GetValue((int)DulieuxnkFieldIndex.Hscode, true); }
			set	{ SetValue((int)DulieuxnkFieldIndex.Hscode, value); }
		}

		/// <summary> The Motahanghoa property of the Entity Dulieuxnk<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Dulieuxnk"."Motahanghoa"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 2147483647<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Motahanghoa
		{
			get { return (System.String)GetValue((int)DulieuxnkFieldIndex.Motahanghoa, true); }
			set	{ SetValue((int)DulieuxnkFieldIndex.Motahanghoa, value); }
		}

		/// <summary> The Thuexuat property of the Entity Dulieuxnk<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Dulieuxnk"."Thuexuat"<br/>
		/// Table field type characteristics (type, precision, scale, length): Decimal, 20, 2, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Decimal> Thuexuat
		{
			get { return (Nullable<System.Decimal>)GetValue((int)DulieuxnkFieldIndex.Thuexuat, false); }
			set	{ SetValue((int)DulieuxnkFieldIndex.Thuexuat, value); }
		}

		/// <summary> The Xuatxu property of the Entity Dulieuxnk<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Dulieuxnk"."Xuatxu"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Xuatxu
		{
			get { return (System.String)GetValue((int)DulieuxnkFieldIndex.Xuatxu, true); }
			set	{ SetValue((int)DulieuxnkFieldIndex.Xuatxu, value); }
		}

		/// <summary> The Madonvi property of the Entity Dulieuxnk<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Dulieuxnk"."Madonvi"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Madonvi
		{
			get { return (System.String)GetValue((int)DulieuxnkFieldIndex.Madonvi, true); }
			set	{ SetValue((int)DulieuxnkFieldIndex.Madonvi, value); }
		}

		/// <summary> The Sotan property of the Entity Dulieuxnk<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Dulieuxnk"."Sotan"<br/>
		/// Table field type characteristics (type, precision, scale, length): Decimal, 20, 2, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Decimal> Sotan
		{
			get { return (Nullable<System.Decimal>)GetValue((int)DulieuxnkFieldIndex.Sotan, false); }
			set	{ SetValue((int)DulieuxnkFieldIndex.Sotan, value); }
		}

		/// <summary> The Giausd property of the Entity Dulieuxnk<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Dulieuxnk"."Giausd"<br/>
		/// Table field type characteristics (type, precision, scale, length): Decimal, 20, 2, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Decimal> Giausd
		{
			get { return (Nullable<System.Decimal>)GetValue((int)DulieuxnkFieldIndex.Giausd, false); }
			set	{ SetValue((int)DulieuxnkFieldIndex.Giausd, value); }
		}

		/// <summary> The Soluong property of the Entity Dulieuxnk<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Dulieuxnk"."Soluong"<br/>
		/// Table field type characteristics (type, precision, scale, length): Decimal, 20, 2, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Decimal> Soluong
		{
			get { return (Nullable<System.Decimal>)GetValue((int)DulieuxnkFieldIndex.Soluong, false); }
			set	{ SetValue((int)DulieuxnkFieldIndex.Soluong, value); }
		}

		/// <summary> The Dongianguyente property of the Entity Dulieuxnk<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Dulieuxnk"."Dongianguyente"<br/>
		/// Table field type characteristics (type, precision, scale, length): Decimal, 20, 2, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Decimal> Dongianguyente
		{
			get { return (Nullable<System.Decimal>)GetValue((int)DulieuxnkFieldIndex.Dongianguyente, false); }
			set	{ SetValue((int)DulieuxnkFieldIndex.Dongianguyente, value); }
		}

		/// <summary> The Dongiausd property of the Entity Dulieuxnk<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Dulieuxnk"."Dongiausd"<br/>
		/// Table field type characteristics (type, precision, scale, length): Decimal, 20, 2, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Decimal> Dongiausd
		{
			get { return (Nullable<System.Decimal>)GetValue((int)DulieuxnkFieldIndex.Dongiausd, false); }
			set	{ SetValue((int)DulieuxnkFieldIndex.Dongiausd, value); }
		}

		/// <summary> The Trigiausd property of the Entity Dulieuxnk<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Dulieuxnk"."Trigiausd"<br/>
		/// Table field type characteristics (type, precision, scale, length): Decimal, 20, 2, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Decimal> Trigiausd
		{
			get { return (Nullable<System.Decimal>)GetValue((int)DulieuxnkFieldIndex.Trigiausd, false); }
			set	{ SetValue((int)DulieuxnkFieldIndex.Trigiausd, value); }
		}

		/// <summary> The Tygiavnd property of the Entity Dulieuxnk<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Dulieuxnk"."Tygiavnd"<br/>
		/// Table field type characteristics (type, precision, scale, length): Decimal, 20, 2, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Decimal> Tygiavnd
		{
			get { return (Nullable<System.Decimal>)GetValue((int)DulieuxnkFieldIndex.Tygiavnd, false); }
			set	{ SetValue((int)DulieuxnkFieldIndex.Tygiavnd, value); }
		}

		/// <summary> The Madongtien property of the Entity Dulieuxnk<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Dulieuxnk"."Madongtien"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Madongtien
		{
			get { return (System.String)GetValue((int)DulieuxnkFieldIndex.Madongtien, true); }
			set	{ SetValue((int)DulieuxnkFieldIndex.Madongtien, value); }
		}

		/// <summary> The Dieukiengia property of the Entity Dulieuxnk<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Dulieuxnk"."Dieukiengia"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Dieukiengia
		{
			get { return (System.String)GetValue((int)DulieuxnkFieldIndex.Dieukiengia, true); }
			set	{ SetValue((int)DulieuxnkFieldIndex.Dieukiengia, value); }
		}

		/// <summary> The Phuongthucthanhtoan property of the Entity Dulieuxnk<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Dulieuxnk"."Phuongthucthanhtoan"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Phuongthucthanhtoan
		{
			get { return (System.String)GetValue((int)DulieuxnkFieldIndex.Phuongthucthanhtoan, true); }
			set	{ SetValue((int)DulieuxnkFieldIndex.Phuongthucthanhtoan, value); }
		}

		/// <summary> The Chicuchaiquan property of the Entity Dulieuxnk<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Dulieuxnk"."Chicuchaiquan"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 250<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Chicuchaiquan
		{
			get { return (System.String)GetValue((int)DulieuxnkFieldIndex.Chicuchaiquan, true); }
			set	{ SetValue((int)DulieuxnkFieldIndex.Chicuchaiquan, value); }
		}

		/// <summary> The Loaihinhxuatkhau property of the Entity Dulieuxnk<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Dulieuxnk"."Loaihinhxuatkhau"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 250<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Loaihinhxuatkhau
		{
			get { return (System.String)GetValue((int)DulieuxnkFieldIndex.Loaihinhxuatkhau, true); }
			set	{ SetValue((int)DulieuxnkFieldIndex.Loaihinhxuatkhau, value); }
		}

		/// <summary> The Tennuocxuatkhau property of the Entity Dulieuxnk<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Dulieuxnk"."Tennuocxuatkhau"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Tennuocxuatkhau
		{
			get { return (System.String)GetValue((int)DulieuxnkFieldIndex.Tennuocxuatkhau, true); }
			set	{ SetValue((int)DulieuxnkFieldIndex.Tennuocxuatkhau, value); }
		}

		/// <summary> The Tennuocnhapkhau property of the Entity Dulieuxnk<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Dulieuxnk"."Tennuocnhapkhau"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Tennuocnhapkhau
		{
			get { return (System.String)GetValue((int)DulieuxnkFieldIndex.Tennuocnhapkhau, true); }
			set	{ SetValue((int)DulieuxnkFieldIndex.Tennuocnhapkhau, value); }
		}

		/// <summary> The Diadiemxephang property of the Entity Dulieuxnk<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Dulieuxnk"."Diadiemxephang"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 250<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Diadiemxephang
		{
			get { return (System.String)GetValue((int)DulieuxnkFieldIndex.Diadiemxephang, true); }
			set	{ SetValue((int)DulieuxnkFieldIndex.Diadiemxephang, value); }
		}

		/// <summary> The Diadiemnhanhangcuoicung property of the Entity Dulieuxnk<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Dulieuxnk"."Diadiemnhanhangcuoicung"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 250<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Diadiemnhanhangcuoicung
		{
			get { return (System.String)GetValue((int)DulieuxnkFieldIndex.Diadiemnhanhangcuoicung, true); }
			set	{ SetValue((int)DulieuxnkFieldIndex.Diadiemnhanhangcuoicung, value); }
		}

		/// <summary> The Sotokhai property of the Entity Dulieuxnk<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Dulieuxnk"."Sotokhai"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Sotokhai
		{
			get { return (System.String)GetValue((int)DulieuxnkFieldIndex.Sotokhai, true); }
			set	{ SetValue((int)DulieuxnkFieldIndex.Sotokhai, value); }
		}




	
		
		/// <summary> Gets the type of the hierarchy this entity is in. </summary>
		protected override InheritanceHierarchyType LLBLGenProIsInHierarchyOfType
		{
			get { return InheritanceHierarchyType.None;}
		}
		
		/// <summary> Gets or sets a value indicating whether this entity is a subtype</summary>
		protected override bool LLBLGenProIsSubType
		{
			get { return false;}
		}
		
		/// <summary>Returns the GD.FM.DAL.EntityType enum value for this entity.</summary>
		[Browsable(false), XmlIgnore]
		public override int LLBLGenProEntityTypeValue 
		{ 
			get { return (int)GD.FM.DAL.EntityType.DulieuxnkEntity; }
		}
		#endregion


		#region Custom Entity code
		
		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END
		
		#endregion

		#region Included code

		#endregion
	}
}
