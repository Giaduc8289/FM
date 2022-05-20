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
using System.Collections;
using System.Collections.Generic;
using GD.FM.DAL;
using GD.FM.DAL.FactoryClasses;
using GD.FM.DAL.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace GD.FM.DAL.RelationClasses
{
	/// <summary>Implements the static Relations variant for the entity: Menurole. </summary>
	public partial class MenuroleRelations
	{
		/// <summary>CTor</summary>
		public MenuroleRelations()
		{
		}

		/// <summary>Gets all relations of the MenuroleEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();


			toReturn.Add(this.MenuEntityUsingMenuid);
			toReturn.Add(this.RolesEntityUsingRolesid);
			return toReturn;
		}

		#region Class Property Declarations



		/// <summary>Returns a new IEntityRelation object, between MenuroleEntity and MenuEntity over the m:1 relation they have, using the relation between the fields:
		/// Menurole.Menuid - Menu.MenuId
		/// </summary>
		public virtual IEntityRelation MenuEntityUsingMenuid
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Menu", false);
				relation.AddEntityFieldPair(MenuFields.MenuId, MenuroleFields.Menuid);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MenuEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MenuroleEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between MenuroleEntity and RolesEntity over the m:1 relation they have, using the relation between the fields:
		/// Menurole.Rolesid - Roles.Rolesid
		/// </summary>
		public virtual IEntityRelation RolesEntityUsingRolesid
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Roles", false);
				relation.AddEntityFieldPair(RolesFields.Rolesid, MenuroleFields.Rolesid);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("RolesEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MenuroleEntity", true);
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
