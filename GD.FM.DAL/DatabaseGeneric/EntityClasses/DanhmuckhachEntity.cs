///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 2.6
// Code is generated on: 20 May 2022 09:12:01
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
	/// Entity class which represents the entity 'Danhmuckhach'.<br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public partial class DanhmuckhachEntity : CommonEntityBase, ISerializable
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
		static DanhmuckhachEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary> CTor</summary>
		public DanhmuckhachEntity():base("DanhmuckhachEntity")
		{
			InitClassEmpty(null, CreateFields());
		}

		/// <summary> CTor</summary>
		/// <remarks>For framework usage.</remarks>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public DanhmuckhachEntity(IEntityFields2 fields):base("DanhmuckhachEntity")
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this DanhmuckhachEntity</param>
		public DanhmuckhachEntity(IValidator validator):base("DanhmuckhachEntity")
		{
			InitClassEmpty(validator, CreateFields());
		}
				

		/// <summary> CTor</summary>
		/// <param name="mahieu">PK value for Danhmuckhach which data should be fetched into this Danhmuckhach object</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public DanhmuckhachEntity(System.String mahieu):base("DanhmuckhachEntity")
		{
			InitClassEmpty(null, CreateFields());
			this.Mahieu = mahieu;
		}

		/// <summary> CTor</summary>
		/// <param name="mahieu">PK value for Danhmuckhach which data should be fetched into this Danhmuckhach object</param>
		/// <param name="validator">The custom validator object for this DanhmuckhachEntity</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public DanhmuckhachEntity(System.String mahieu, IValidator validator):base("DanhmuckhachEntity")
		{
			InitClassEmpty(validator, CreateFields());
			this.Mahieu = mahieu;
		}

		/// <summary> Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected DanhmuckhachEntity(SerializationInfo info, StreamingContext context) : base(info, context)
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
			switch((DanhmuckhachFieldIndex)fieldIndex)
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
			return DanhmuckhachEntity.GetRelationsForField(fieldName);
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
		public bool TestOriginalFieldValueForNull(DanhmuckhachFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}
		
		/// <summary>Returns true if the current value for the field with the fieldIndex passed in represents null/not defined, false otherwise.
		/// Should not be used for testing if the original value (read from the db) is NULL</summary>
		/// <param name="fieldIndex">Index of the field to test if its currentvalue is null/undefined</param>
		/// <returns>true if the field's value isn't defined yet, false otherwise</returns>
		public bool TestCurrentFieldValueForNull(DanhmuckhachFieldIndex fieldIndex)
		{
			return base.CheckIfCurrentFieldValueIsNull((int)fieldIndex);
		}

				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		public override List<IEntityRelation> GetAllRelations()
		{
			return new DanhmuckhachRelations().GetAllRelations();
		}
		




	
		
		/// <summary>Creates entity fields object for this entity. Used in constructor to setup this entity in a polymorphic scenario.</summary>
		protected virtual IEntityFields2 CreateFields()
		{
			return EntityFieldsFactory.CreateEntityFieldsObject(GD.FM.DAL.EntityType.DanhmuckhachEntity);
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
			return EntityFactoryCache2.GetEntityFactory(typeof(DanhmuckhachEntityFactory));
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

			_fieldsCustomProperties.Add("Mahieu", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Tenhieu", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Tenrutgon", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Diachi", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Sodienthoai", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Sofax", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Masothue", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Taikhoannganhang", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Tennganhang", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Email", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Noidia", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Truyenthong", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Nguoilienhehoten", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Nguoilienhechucvu", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Nguoilienhesodienthoai", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Nguoilienhethongtinbosung", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Ngaytao", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Nguoitao", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Ngaysua", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Nguoisua", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Manhanvien", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Tennhanvien", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Macode", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Mafiller", fieldHashtable);
		}
		#endregion



		/// <summary> Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validator">The validator object for this DanhmuckhachEntity</param>
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
		public  static DanhmuckhachRelations Relations
		{
			get	{ return new DanhmuckhachRelations(); }
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
			get { return DanhmuckhachEntity.CustomProperties;}
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
			get { return DanhmuckhachEntity.FieldsCustomProperties;}
		}

		/// <summary> The Mahieu property of the Entity Danhmuckhach<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Danhmuckhach"."Mahieu"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.String Mahieu
		{
			get { return (System.String)GetValue((int)DanhmuckhachFieldIndex.Mahieu, true); }
			set	{ SetValue((int)DanhmuckhachFieldIndex.Mahieu, value); }
		}

		/// <summary> The Tenhieu property of the Entity Danhmuckhach<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Danhmuckhach"."Tenhieu"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 250<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Tenhieu
		{
			get { return (System.String)GetValue((int)DanhmuckhachFieldIndex.Tenhieu, true); }
			set	{ SetValue((int)DanhmuckhachFieldIndex.Tenhieu, value); }
		}

		/// <summary> The Tenrutgon property of the Entity Danhmuckhach<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Danhmuckhach"."Tenrutgon"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Tenrutgon
		{
			get { return (System.String)GetValue((int)DanhmuckhachFieldIndex.Tenrutgon, true); }
			set	{ SetValue((int)DanhmuckhachFieldIndex.Tenrutgon, value); }
		}

		/// <summary> The Diachi property of the Entity Danhmuckhach<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Danhmuckhach"."Diachi"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 250<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Diachi
		{
			get { return (System.String)GetValue((int)DanhmuckhachFieldIndex.Diachi, true); }
			set	{ SetValue((int)DanhmuckhachFieldIndex.Diachi, value); }
		}

		/// <summary> The Sodienthoai property of the Entity Danhmuckhach<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Danhmuckhach"."Sodienthoai"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 100<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Sodienthoai
		{
			get { return (System.String)GetValue((int)DanhmuckhachFieldIndex.Sodienthoai, true); }
			set	{ SetValue((int)DanhmuckhachFieldIndex.Sodienthoai, value); }
		}

		/// <summary> The Sofax property of the Entity Danhmuckhach<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Danhmuckhach"."Sofax"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 100<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Sofax
		{
			get { return (System.String)GetValue((int)DanhmuckhachFieldIndex.Sofax, true); }
			set	{ SetValue((int)DanhmuckhachFieldIndex.Sofax, value); }
		}

		/// <summary> The Masothue property of the Entity Danhmuckhach<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Danhmuckhach"."Masothue"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 100<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Masothue
		{
			get { return (System.String)GetValue((int)DanhmuckhachFieldIndex.Masothue, true); }
			set	{ SetValue((int)DanhmuckhachFieldIndex.Masothue, value); }
		}

		/// <summary> The Taikhoannganhang property of the Entity Danhmuckhach<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Danhmuckhach"."Taikhoannganhang"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 100<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Taikhoannganhang
		{
			get { return (System.String)GetValue((int)DanhmuckhachFieldIndex.Taikhoannganhang, true); }
			set	{ SetValue((int)DanhmuckhachFieldIndex.Taikhoannganhang, value); }
		}

		/// <summary> The Tennganhang property of the Entity Danhmuckhach<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Danhmuckhach"."Tennganhang"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 250<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Tennganhang
		{
			get { return (System.String)GetValue((int)DanhmuckhachFieldIndex.Tennganhang, true); }
			set	{ SetValue((int)DanhmuckhachFieldIndex.Tennganhang, value); }
		}

		/// <summary> The Email property of the Entity Danhmuckhach<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Danhmuckhach"."Email"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 100<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Email
		{
			get { return (System.String)GetValue((int)DanhmuckhachFieldIndex.Email, true); }
			set	{ SetValue((int)DanhmuckhachFieldIndex.Email, value); }
		}

		/// <summary> The Noidia property of the Entity Danhmuckhach<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Danhmuckhach"."Noidia"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Boolean> Noidia
		{
			get { return (Nullable<System.Boolean>)GetValue((int)DanhmuckhachFieldIndex.Noidia, false); }
			set	{ SetValue((int)DanhmuckhachFieldIndex.Noidia, value); }
		}

		/// <summary> The Truyenthong property of the Entity Danhmuckhach<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Danhmuckhach"."Truyenthong"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Boolean> Truyenthong
		{
			get { return (Nullable<System.Boolean>)GetValue((int)DanhmuckhachFieldIndex.Truyenthong, false); }
			set	{ SetValue((int)DanhmuckhachFieldIndex.Truyenthong, value); }
		}

		/// <summary> The Nguoilienhehoten property of the Entity Danhmuckhach<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Danhmuckhach"."Nguoilienhehoten"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 100<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Nguoilienhehoten
		{
			get { return (System.String)GetValue((int)DanhmuckhachFieldIndex.Nguoilienhehoten, true); }
			set	{ SetValue((int)DanhmuckhachFieldIndex.Nguoilienhehoten, value); }
		}

		/// <summary> The Nguoilienhechucvu property of the Entity Danhmuckhach<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Danhmuckhach"."Nguoilienhechucvu"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 100<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Nguoilienhechucvu
		{
			get { return (System.String)GetValue((int)DanhmuckhachFieldIndex.Nguoilienhechucvu, true); }
			set	{ SetValue((int)DanhmuckhachFieldIndex.Nguoilienhechucvu, value); }
		}

		/// <summary> The Nguoilienhesodienthoai property of the Entity Danhmuckhach<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Danhmuckhach"."Nguoilienhesodienthoai"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 100<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Nguoilienhesodienthoai
		{
			get { return (System.String)GetValue((int)DanhmuckhachFieldIndex.Nguoilienhesodienthoai, true); }
			set	{ SetValue((int)DanhmuckhachFieldIndex.Nguoilienhesodienthoai, value); }
		}

		/// <summary> The Nguoilienhethongtinbosung property of the Entity Danhmuckhach<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Danhmuckhach"."Nguoilienhethongtinbosung"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 250<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Nguoilienhethongtinbosung
		{
			get { return (System.String)GetValue((int)DanhmuckhachFieldIndex.Nguoilienhethongtinbosung, true); }
			set	{ SetValue((int)DanhmuckhachFieldIndex.Nguoilienhethongtinbosung, value); }
		}

		/// <summary> The Ngaytao property of the Entity Danhmuckhach<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Danhmuckhach"."Ngaytao"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> Ngaytao
		{
			get { return (Nullable<System.DateTime>)GetValue((int)DanhmuckhachFieldIndex.Ngaytao, false); }
			set	{ SetValue((int)DanhmuckhachFieldIndex.Ngaytao, value); }
		}

		/// <summary> The Nguoitao property of the Entity Danhmuckhach<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Danhmuckhach"."Nguoitao"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Nguoitao
		{
			get { return (System.String)GetValue((int)DanhmuckhachFieldIndex.Nguoitao, true); }
			set	{ SetValue((int)DanhmuckhachFieldIndex.Nguoitao, value); }
		}

		/// <summary> The Ngaysua property of the Entity Danhmuckhach<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Danhmuckhach"."Ngaysua"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> Ngaysua
		{
			get { return (Nullable<System.DateTime>)GetValue((int)DanhmuckhachFieldIndex.Ngaysua, false); }
			set	{ SetValue((int)DanhmuckhachFieldIndex.Ngaysua, value); }
		}

		/// <summary> The Nguoisua property of the Entity Danhmuckhach<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Danhmuckhach"."Nguoisua"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Nguoisua
		{
			get { return (System.String)GetValue((int)DanhmuckhachFieldIndex.Nguoisua, true); }
			set	{ SetValue((int)DanhmuckhachFieldIndex.Nguoisua, value); }
		}

		/// <summary> The Manhanvien property of the Entity Danhmuckhach<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Danhmuckhach"."Manhanvien"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Manhanvien
		{
			get { return (System.String)GetValue((int)DanhmuckhachFieldIndex.Manhanvien, true); }
			set	{ SetValue((int)DanhmuckhachFieldIndex.Manhanvien, value); }
		}

		/// <summary> The Tennhanvien property of the Entity Danhmuckhach<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Danhmuckhach"."Tennhanvien"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 250<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Tennhanvien
		{
			get { return (System.String)GetValue((int)DanhmuckhachFieldIndex.Tennhanvien, true); }
			set	{ SetValue((int)DanhmuckhachFieldIndex.Tennhanvien, value); }
		}

		/// <summary> The Macode property of the Entity Danhmuckhach<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Danhmuckhach"."Macode"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 2147483647<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Macode
		{
			get { return (System.String)GetValue((int)DanhmuckhachFieldIndex.Macode, true); }
			set	{ SetValue((int)DanhmuckhachFieldIndex.Macode, value); }
		}

		/// <summary> The Mafiller property of the Entity Danhmuckhach<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Danhmuckhach"."Mafiller"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 2147483647<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Mafiller
		{
			get { return (System.String)GetValue((int)DanhmuckhachFieldIndex.Mafiller, true); }
			set	{ SetValue((int)DanhmuckhachFieldIndex.Mafiller, value); }
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
			get { return (int)GD.FM.DAL.EntityType.DanhmuckhachEntity; }
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
