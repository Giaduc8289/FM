///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 2.6
// Code is generated on: 19 May 2022 14:46:06
// Code is generated using templates: SD.TemplateBindings.SharedTemplates.NET20
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using System.Collections;
using System.Collections.Generic;
using GD.FM.DAL;
using GD.FM.DAL.FactoryClasses;
using GD.FM.DAL.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace GD.FM.DAL.RelationClasses
{
	/// <summary>Implements the static Relations variant for the entity: Roles. </summary>
	public partial class RolesRelations
	{
		/// <summary>CTor</summary>
		public RolesRelations()
		{
		}

		/// <summary>Gets all relations of the RolesEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.MenuroleEntityUsingRolesid);
			toReturn.Add(this.UsersEntityUsingRolesid);


			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between RolesEntity and MenuroleEntity over the 1:n relation they have, using the relation between the fields:
		/// Roles.Rolesid - Menurole.Rolesid
		/// </summary>
		public virtual IEntityRelation MenuroleEntityUsingRolesid
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "Menurole" , true);
				relation.AddEntityFieldPair(RolesFields.Rolesid, MenuroleFields.Rolesid);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("RolesEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MenuroleEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between RolesEntity and UsersEntity over the 1:n relation they have, using the relation between the fields:
		/// Roles.Rolesid - Users.Rolesid
		/// </summary>
		public virtual IEntityRelation UsersEntityUsingRolesid
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "Users" , true);
				relation.AddEntityFieldPair(RolesFields.Rolesid, UsersFields.Rolesid);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("RolesEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("UsersEntity", false);
				return relation;
			}
		}



		/// <summary>stub, not used in this entity, only for TargetPerEntity entities.</summary>
		public virtual IEntityRelation GetSubTypeRelation(string subTypeEntityName) { return null; }
		/// <summary>stub, not used in this entity, only for TargetPerEntity entities.</summary>
		public virtual IEntityRelation GetSuperTypeRelation() { return null;}

		#endregion

		#region Included Code

		#endregion
	}
}
