///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 2.6
// Code is generated on: 20 May 2022 09:12:00
// Code is generated using templates: SD.TemplateBindings.SharedTemplates.NET20
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace GD.FM.DAL.HelperClasses
{
	
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END
	
	/// <summary>
	/// Singleton implementation of the FieldInfoProvider. This class is the singleton wrapper through which the actual instance is retrieved.
	/// </summary>
	/// <remarks>It uses a single instance of an internal class. The access isn't marked with locks as the FieldInfoProviderBase class is threadsafe.</remarks>
	internal sealed class FieldInfoProviderSingleton
	{
		#region Class Member Declarations
		private static readonly IFieldInfoProvider _providerInstance = new FieldInfoProviderCore();
		#endregion
		
		/// <summary>private ctor to prevent instances of this class.</summary>
		private FieldInfoProviderSingleton()
		{
		}

		/// <summary>Dummy static constructor to make sure threadsafe initialization is performed.</summary>
		static FieldInfoProviderSingleton()
		{
		}

		/// <summary>Gets the singleton instance of the FieldInfoProviderCore</summary>
		/// <returns>Instance of the FieldInfoProvider.</returns>
		public static IFieldInfoProvider GetInstance()
		{
			return _providerInstance;
		}
	}

	/// <summary>Actual implementation of the FieldInfoProvider. Used by singleton wrapper.</summary>
	internal class FieldInfoProviderCore : FieldInfoProviderBase
	{
		/// <summary>Initializes a new instance of the <see cref="FieldInfoProviderCore"/> class.</summary>
		internal FieldInfoProviderCore()
		{
			Init();
		}

		/// <summary>Method which initializes the internal datastores.</summary>
		private void Init()
		{
			base.InitClass( (24 + 0));
			InitDanhmuccangEntityInfos();
			InitDanhmucchucvuEntityInfos();
			InitDanhmuchanghoaEntityInfos();
			InitDanhmuckhachEntityInfos();
			InitDanhmucnganhangEntityInfos();
			InitDanhmucquocgiaEntityInfos();
			InitDanhmucungdungEntityInfos();
			InitDmcapmaEntityInfos();
			InitDonvitinhEntityInfos();
			InitFormcoEntityInfos();
			InitHopdongbanhangEntityInfos();
			InitHopdongbanhangchitietEntityInfos();
			InitLogbackupEntityInfos();
			InitMenuEntityInfos();
			InitMenuroleEntityInfos();
			InitNhanvienEntityInfos();
			InitPhongbanEntityInfos();
			InitPhuongthucthanhtoanEntityInfos();
			InitPhuongthucvanchuyenEntityInfos();
			InitRolesEntityInfos();
			InitThamsoEntityInfos();
			InitThuchienhopdongbanhangEntityInfos();
			InitTygiaEntityInfos();
			InitUsersEntityInfos();

			base.ConstructElementFieldStructures(InheritanceInfoProviderSingleton.GetInstance());
		}

		/// <summary>Inits DanhmuccangEntity's FieldInfo objects</summary>
		private void InitDanhmuccangEntityInfos()
		{
			base.AddElementFieldInfo("DanhmuccangEntity", "Mahieu", typeof(System.String), true, false, false, false,  (int)DanhmuccangFieldIndex.Mahieu, 50, 0, 0);
			base.AddElementFieldInfo("DanhmuccangEntity", "Tenhieu", typeof(System.String), false, false, false, true,  (int)DanhmuccangFieldIndex.Tenhieu, 250, 0, 0);
			base.AddElementFieldInfo("DanhmuccangEntity", "Tenrutgon", typeof(System.String), false, false, false, true,  (int)DanhmuccangFieldIndex.Tenrutgon, 50, 0, 0);
			base.AddElementFieldInfo("DanhmuccangEntity", "Maquocgia", typeof(System.String), false, false, false, true,  (int)DanhmuccangFieldIndex.Maquocgia, 50, 0, 0);
			base.AddElementFieldInfo("DanhmuccangEntity", "Tenquocgia", typeof(System.String), false, false, false, true,  (int)DanhmuccangFieldIndex.Tenquocgia, 250, 0, 0);
			base.AddElementFieldInfo("DanhmuccangEntity", "Ngaytao", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)DanhmuccangFieldIndex.Ngaytao, 0, 0, 0);
			base.AddElementFieldInfo("DanhmuccangEntity", "Nguoitao", typeof(System.String), false, false, false, true,  (int)DanhmuccangFieldIndex.Nguoitao, 50, 0, 0);
			base.AddElementFieldInfo("DanhmuccangEntity", "Ngaysua", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)DanhmuccangFieldIndex.Ngaysua, 0, 0, 0);
			base.AddElementFieldInfo("DanhmuccangEntity", "Nguoisua", typeof(System.String), false, false, false, true,  (int)DanhmuccangFieldIndex.Nguoisua, 50, 0, 0);
		}
		/// <summary>Inits DanhmucchucvuEntity's FieldInfo objects</summary>
		private void InitDanhmucchucvuEntityInfos()
		{
			base.AddElementFieldInfo("DanhmucchucvuEntity", "Mahieu", typeof(System.String), true, false, false, false,  (int)DanhmucchucvuFieldIndex.Mahieu, 50, 0, 0);
			base.AddElementFieldInfo("DanhmucchucvuEntity", "Tenhieu", typeof(System.String), false, false, false, true,  (int)DanhmucchucvuFieldIndex.Tenhieu, 250, 0, 0);
			base.AddElementFieldInfo("DanhmucchucvuEntity", "Tenrutgon", typeof(System.String), false, false, false, true,  (int)DanhmucchucvuFieldIndex.Tenrutgon, 50, 0, 0);
			base.AddElementFieldInfo("DanhmucchucvuEntity", "Ngaytao", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)DanhmucchucvuFieldIndex.Ngaytao, 0, 0, 0);
			base.AddElementFieldInfo("DanhmucchucvuEntity", "Nguoitao", typeof(System.String), false, false, false, true,  (int)DanhmucchucvuFieldIndex.Nguoitao, 50, 0, 0);
			base.AddElementFieldInfo("DanhmucchucvuEntity", "Ngaysua", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)DanhmucchucvuFieldIndex.Ngaysua, 0, 0, 0);
			base.AddElementFieldInfo("DanhmucchucvuEntity", "Nguoisua", typeof(System.String), false, false, false, true,  (int)DanhmucchucvuFieldIndex.Nguoisua, 50, 0, 0);
		}
		/// <summary>Inits DanhmuchanghoaEntity's FieldInfo objects</summary>
		private void InitDanhmuchanghoaEntityInfos()
		{
			base.AddElementFieldInfo("DanhmuchanghoaEntity", "Mahieu", typeof(System.String), true, false, false, false,  (int)DanhmuchanghoaFieldIndex.Mahieu, 50, 0, 0);
			base.AddElementFieldInfo("DanhmuchanghoaEntity", "Makhach", typeof(System.String), false, false, false, true,  (int)DanhmuchanghoaFieldIndex.Makhach, 50, 0, 0);
			base.AddElementFieldInfo("DanhmuchanghoaEntity", "Tenkhach", typeof(System.String), false, false, false, true,  (int)DanhmuchanghoaFieldIndex.Tenkhach, 250, 0, 0);
			base.AddElementFieldInfo("DanhmuchanghoaEntity", "Mahangphiakhach", typeof(System.String), false, false, false, true,  (int)DanhmuchanghoaFieldIndex.Mahangphiakhach, 50, 0, 0);
			base.AddElementFieldInfo("DanhmuchanghoaEntity", "Maungdung", typeof(System.String), false, false, false, true,  (int)DanhmuchanghoaFieldIndex.Maungdung, 50, 0, 0);
			base.AddElementFieldInfo("DanhmuchanghoaEntity", "Tocdomay", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)DanhmuchanghoaFieldIndex.Tocdomay, 0, 2, 20);
			base.AddElementFieldInfo("DanhmuchanghoaEntity", "Caco3kh", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)DanhmuchanghoaFieldIndex.Caco3kh, 0, 2, 20);
			base.AddElementFieldInfo("DanhmuchanghoaEntity", "Tio2kh", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)DanhmuchanghoaFieldIndex.Tio2kh, 0, 2, 20);
			base.AddElementFieldInfo("DanhmuchanghoaEntity", "Mikh", typeof(System.String), false, false, false, true,  (int)DanhmuchanghoaFieldIndex.Mikh, 50, 0, 0);
			base.AddElementFieldInfo("DanhmuchanghoaEntity", "Khackh", typeof(System.String), false, false, false, true,  (int)DanhmuchanghoaFieldIndex.Khackh, 250, 0, 0);
			base.AddElementFieldInfo("DanhmuchanghoaEntity", "Caco3fm", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)DanhmuchanghoaFieldIndex.Caco3fm, 0, 2, 20);
			base.AddElementFieldInfo("DanhmuchanghoaEntity", "Tio2fm", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)DanhmuchanghoaFieldIndex.Tio2fm, 0, 2, 20);
			base.AddElementFieldInfo("DanhmuchanghoaEntity", "Mifm", typeof(System.String), false, false, false, true,  (int)DanhmuchanghoaFieldIndex.Mifm, 50, 0, 0);
			base.AddElementFieldInfo("DanhmuchanghoaEntity", "Khacfm", typeof(System.String), false, false, false, true,  (int)DanhmuchanghoaFieldIndex.Khacfm, 250, 0, 0);
			base.AddElementFieldInfo("DanhmuchanghoaEntity", "Ngaytao", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)DanhmuchanghoaFieldIndex.Ngaytao, 0, 0, 0);
			base.AddElementFieldInfo("DanhmuchanghoaEntity", "Nguoitao", typeof(System.String), false, false, false, true,  (int)DanhmuchanghoaFieldIndex.Nguoitao, 50, 0, 0);
			base.AddElementFieldInfo("DanhmuchanghoaEntity", "Ngaysua", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)DanhmuchanghoaFieldIndex.Ngaysua, 0, 0, 0);
			base.AddElementFieldInfo("DanhmuchanghoaEntity", "Nguoisua", typeof(System.String), false, false, false, true,  (int)DanhmuchanghoaFieldIndex.Nguoisua, 50, 0, 0);
		}
		/// <summary>Inits DanhmuckhachEntity's FieldInfo objects</summary>
		private void InitDanhmuckhachEntityInfos()
		{
			base.AddElementFieldInfo("DanhmuckhachEntity", "Mahieu", typeof(System.String), true, false, false, false,  (int)DanhmuckhachFieldIndex.Mahieu, 50, 0, 0);
			base.AddElementFieldInfo("DanhmuckhachEntity", "Tenhieu", typeof(System.String), false, false, false, false,  (int)DanhmuckhachFieldIndex.Tenhieu, 250, 0, 0);
			base.AddElementFieldInfo("DanhmuckhachEntity", "Tenrutgon", typeof(System.String), false, false, false, true,  (int)DanhmuckhachFieldIndex.Tenrutgon, 50, 0, 0);
			base.AddElementFieldInfo("DanhmuckhachEntity", "Diachi", typeof(System.String), false, false, false, true,  (int)DanhmuckhachFieldIndex.Diachi, 250, 0, 0);
			base.AddElementFieldInfo("DanhmuckhachEntity", "Sodienthoai", typeof(System.String), false, false, false, true,  (int)DanhmuckhachFieldIndex.Sodienthoai, 100, 0, 0);
			base.AddElementFieldInfo("DanhmuckhachEntity", "Sofax", typeof(System.String), false, false, false, true,  (int)DanhmuckhachFieldIndex.Sofax, 100, 0, 0);
			base.AddElementFieldInfo("DanhmuckhachEntity", "Masothue", typeof(System.String), false, false, false, true,  (int)DanhmuckhachFieldIndex.Masothue, 100, 0, 0);
			base.AddElementFieldInfo("DanhmuckhachEntity", "Taikhoannganhang", typeof(System.String), false, false, false, true,  (int)DanhmuckhachFieldIndex.Taikhoannganhang, 100, 0, 0);
			base.AddElementFieldInfo("DanhmuckhachEntity", "Tennganhang", typeof(System.String), false, false, false, true,  (int)DanhmuckhachFieldIndex.Tennganhang, 250, 0, 0);
			base.AddElementFieldInfo("DanhmuckhachEntity", "Email", typeof(System.String), false, false, false, true,  (int)DanhmuckhachFieldIndex.Email, 100, 0, 0);
			base.AddElementFieldInfo("DanhmuckhachEntity", "Noidia", typeof(Nullable<System.Boolean>), false, false, false, true,  (int)DanhmuckhachFieldIndex.Noidia, 0, 0, 0);
			base.AddElementFieldInfo("DanhmuckhachEntity", "Truyenthong", typeof(Nullable<System.Boolean>), false, false, false, true,  (int)DanhmuckhachFieldIndex.Truyenthong, 0, 0, 0);
			base.AddElementFieldInfo("DanhmuckhachEntity", "Nguoilienhehoten", typeof(System.String), false, false, false, true,  (int)DanhmuckhachFieldIndex.Nguoilienhehoten, 100, 0, 0);
			base.AddElementFieldInfo("DanhmuckhachEntity", "Nguoilienhechucvu", typeof(System.String), false, false, false, true,  (int)DanhmuckhachFieldIndex.Nguoilienhechucvu, 100, 0, 0);
			base.AddElementFieldInfo("DanhmuckhachEntity", "Nguoilienhesodienthoai", typeof(System.String), false, false, false, true,  (int)DanhmuckhachFieldIndex.Nguoilienhesodienthoai, 100, 0, 0);
			base.AddElementFieldInfo("DanhmuckhachEntity", "Nguoilienhethongtinbosung", typeof(System.String), false, false, false, true,  (int)DanhmuckhachFieldIndex.Nguoilienhethongtinbosung, 250, 0, 0);
			base.AddElementFieldInfo("DanhmuckhachEntity", "Ngaytao", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)DanhmuckhachFieldIndex.Ngaytao, 0, 0, 0);
			base.AddElementFieldInfo("DanhmuckhachEntity", "Nguoitao", typeof(System.String), false, false, false, true,  (int)DanhmuckhachFieldIndex.Nguoitao, 50, 0, 0);
			base.AddElementFieldInfo("DanhmuckhachEntity", "Ngaysua", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)DanhmuckhachFieldIndex.Ngaysua, 0, 0, 0);
			base.AddElementFieldInfo("DanhmuckhachEntity", "Nguoisua", typeof(System.String), false, false, false, true,  (int)DanhmuckhachFieldIndex.Nguoisua, 50, 0, 0);
			base.AddElementFieldInfo("DanhmuckhachEntity", "Manhanvien", typeof(System.String), false, false, false, true,  (int)DanhmuckhachFieldIndex.Manhanvien, 50, 0, 0);
			base.AddElementFieldInfo("DanhmuckhachEntity", "Tennhanvien", typeof(System.String), false, false, false, true,  (int)DanhmuckhachFieldIndex.Tennhanvien, 250, 0, 0);
			base.AddElementFieldInfo("DanhmuckhachEntity", "Macode", typeof(System.String), false, false, false, true,  (int)DanhmuckhachFieldIndex.Macode, 2147483647, 0, 0);
			base.AddElementFieldInfo("DanhmuckhachEntity", "Mafiller", typeof(System.String), false, false, false, true,  (int)DanhmuckhachFieldIndex.Mafiller, 2147483647, 0, 0);
		}
		/// <summary>Inits DanhmucnganhangEntity's FieldInfo objects</summary>
		private void InitDanhmucnganhangEntityInfos()
		{
			base.AddElementFieldInfo("DanhmucnganhangEntity", "Mahieu", typeof(System.String), true, false, false, false,  (int)DanhmucnganhangFieldIndex.Mahieu, 50, 0, 0);
			base.AddElementFieldInfo("DanhmucnganhangEntity", "AccountHolder", typeof(System.String), false, false, false, true,  (int)DanhmucnganhangFieldIndex.AccountHolder, 250, 0, 0);
			base.AddElementFieldInfo("DanhmucnganhangEntity", "Bank", typeof(System.String), false, false, false, true,  (int)DanhmucnganhangFieldIndex.Bank, 250, 0, 0);
			base.AddElementFieldInfo("DanhmucnganhangEntity", "Address", typeof(System.String), false, false, false, true,  (int)DanhmucnganhangFieldIndex.Address, 250, 0, 0);
			base.AddElementFieldInfo("DanhmucnganhangEntity", "Accountnumber", typeof(System.String), false, false, false, true,  (int)DanhmucnganhangFieldIndex.Accountnumber, 50, 0, 0);
			base.AddElementFieldInfo("DanhmucnganhangEntity", "Swift", typeof(System.String), false, false, false, true,  (int)DanhmucnganhangFieldIndex.Swift, 50, 0, 0);
			base.AddElementFieldInfo("DanhmucnganhangEntity", "Ngaytao", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)DanhmucnganhangFieldIndex.Ngaytao, 0, 0, 0);
			base.AddElementFieldInfo("DanhmucnganhangEntity", "Nguoitao", typeof(System.String), false, false, false, true,  (int)DanhmucnganhangFieldIndex.Nguoitao, 50, 0, 0);
			base.AddElementFieldInfo("DanhmucnganhangEntity", "Ngaysua", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)DanhmucnganhangFieldIndex.Ngaysua, 0, 0, 0);
			base.AddElementFieldInfo("DanhmucnganhangEntity", "Nguoisua", typeof(System.String), false, false, false, true,  (int)DanhmucnganhangFieldIndex.Nguoisua, 50, 0, 0);
		}
		/// <summary>Inits DanhmucquocgiaEntity's FieldInfo objects</summary>
		private void InitDanhmucquocgiaEntityInfos()
		{
			base.AddElementFieldInfo("DanhmucquocgiaEntity", "Mahieu", typeof(System.String), true, false, false, false,  (int)DanhmucquocgiaFieldIndex.Mahieu, 50, 0, 0);
			base.AddElementFieldInfo("DanhmucquocgiaEntity", "Tenhieu", typeof(System.String), false, false, false, true,  (int)DanhmucquocgiaFieldIndex.Tenhieu, 250, 0, 0);
			base.AddElementFieldInfo("DanhmucquocgiaEntity", "Tenrutgon", typeof(System.String), false, false, false, true,  (int)DanhmucquocgiaFieldIndex.Tenrutgon, 50, 0, 0);
			base.AddElementFieldInfo("DanhmucquocgiaEntity", "Ngaytao", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)DanhmucquocgiaFieldIndex.Ngaytao, 0, 0, 0);
			base.AddElementFieldInfo("DanhmucquocgiaEntity", "Nguoitao", typeof(System.String), false, false, false, true,  (int)DanhmucquocgiaFieldIndex.Nguoitao, 50, 0, 0);
			base.AddElementFieldInfo("DanhmucquocgiaEntity", "Ngaysua", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)DanhmucquocgiaFieldIndex.Ngaysua, 0, 0, 0);
			base.AddElementFieldInfo("DanhmucquocgiaEntity", "Nguoisua", typeof(System.String), false, false, false, true,  (int)DanhmucquocgiaFieldIndex.Nguoisua, 50, 0, 0);
		}
		/// <summary>Inits DanhmucungdungEntity's FieldInfo objects</summary>
		private void InitDanhmucungdungEntityInfos()
		{
			base.AddElementFieldInfo("DanhmucungdungEntity", "Mahieu", typeof(System.String), true, false, false, false,  (int)DanhmucungdungFieldIndex.Mahieu, 50, 0, 0);
			base.AddElementFieldInfo("DanhmucungdungEntity", "Tenhieu", typeof(System.String), false, false, false, true,  (int)DanhmucungdungFieldIndex.Tenhieu, 250, 0, 0);
			base.AddElementFieldInfo("DanhmucungdungEntity", "Tenrutgon", typeof(System.String), false, false, false, true,  (int)DanhmucungdungFieldIndex.Tenrutgon, 50, 0, 0);
			base.AddElementFieldInfo("DanhmucungdungEntity", "Ngaytao", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)DanhmucungdungFieldIndex.Ngaytao, 0, 0, 0);
			base.AddElementFieldInfo("DanhmucungdungEntity", "Nguoitao", typeof(System.String), false, false, false, true,  (int)DanhmucungdungFieldIndex.Nguoitao, 50, 0, 0);
			base.AddElementFieldInfo("DanhmucungdungEntity", "Ngaysua", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)DanhmucungdungFieldIndex.Ngaysua, 0, 0, 0);
			base.AddElementFieldInfo("DanhmucungdungEntity", "Nguoisua", typeof(System.String), false, false, false, true,  (int)DanhmucungdungFieldIndex.Nguoisua, 50, 0, 0);
		}
		/// <summary>Inits DmcapmaEntity's FieldInfo objects</summary>
		private void InitDmcapmaEntityInfos()
		{
			base.AddElementFieldInfo("DmcapmaEntity", "Macappk", typeof(System.String), false, false, false, false,  (int)DmcapmaFieldIndex.Macappk, 50, 0, 0);
			base.AddElementFieldInfo("DmcapmaEntity", "Loaima", typeof(System.String), true, false, false, false,  (int)DmcapmaFieldIndex.Loaima, 50, 0, 0);
			base.AddElementFieldInfo("DmcapmaEntity", "Mastart", typeof(System.String), false, false, false, true,  (int)DmcapmaFieldIndex.Mastart, 50, 0, 0);
		}
		/// <summary>Inits DonvitinhEntity's FieldInfo objects</summary>
		private void InitDonvitinhEntityInfos()
		{
			base.AddElementFieldInfo("DonvitinhEntity", "Mahieu", typeof(System.String), true, false, false, false,  (int)DonvitinhFieldIndex.Mahieu, 50, 0, 0);
			base.AddElementFieldInfo("DonvitinhEntity", "Tenhieu", typeof(System.String), false, false, false, true,  (int)DonvitinhFieldIndex.Tenhieu, 50, 0, 0);
			base.AddElementFieldInfo("DonvitinhEntity", "Tentienganh", typeof(System.String), false, false, false, true,  (int)DonvitinhFieldIndex.Tentienganh, 50, 0, 0);
			base.AddElementFieldInfo("DonvitinhEntity", "Ngaytao", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)DonvitinhFieldIndex.Ngaytao, 0, 0, 0);
			base.AddElementFieldInfo("DonvitinhEntity", "Nguoitao", typeof(System.String), false, false, false, true,  (int)DonvitinhFieldIndex.Nguoitao, 50, 0, 0);
			base.AddElementFieldInfo("DonvitinhEntity", "Ngaysua", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)DonvitinhFieldIndex.Ngaysua, 0, 0, 0);
			base.AddElementFieldInfo("DonvitinhEntity", "Nguoisua", typeof(System.String), false, false, false, true,  (int)DonvitinhFieldIndex.Nguoisua, 50, 0, 0);
		}
		/// <summary>Inits FormcoEntity's FieldInfo objects</summary>
		private void InitFormcoEntityInfos()
		{
			base.AddElementFieldInfo("FormcoEntity", "Mahieu", typeof(System.String), true, false, false, false,  (int)FormcoFieldIndex.Mahieu, 50, 0, 0);
			base.AddElementFieldInfo("FormcoEntity", "Tenhieu", typeof(System.String), false, false, false, true,  (int)FormcoFieldIndex.Tenhieu, 250, 0, 0);
			base.AddElementFieldInfo("FormcoEntity", "Tenrutgon", typeof(System.String), false, false, false, true,  (int)FormcoFieldIndex.Tenrutgon, 50, 0, 0);
			base.AddElementFieldInfo("FormcoEntity", "Ngaytao", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)FormcoFieldIndex.Ngaytao, 0, 0, 0);
			base.AddElementFieldInfo("FormcoEntity", "Nguoitao", typeof(System.String), false, false, false, true,  (int)FormcoFieldIndex.Nguoitao, 50, 0, 0);
			base.AddElementFieldInfo("FormcoEntity", "Ngaysua", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)FormcoFieldIndex.Ngaysua, 0, 0, 0);
			base.AddElementFieldInfo("FormcoEntity", "Nguoisua", typeof(System.String), false, false, false, true,  (int)FormcoFieldIndex.Nguoisua, 50, 0, 0);
		}
		/// <summary>Inits HopdongbanhangEntity's FieldInfo objects</summary>
		private void InitHopdongbanhangEntityInfos()
		{
			base.AddElementFieldInfo("HopdongbanhangEntity", "Sohopdong", typeof(System.String), true, false, false, false,  (int)HopdongbanhangFieldIndex.Sohopdong, 50, 0, 0);
			base.AddElementFieldInfo("HopdongbanhangEntity", "Ngayhopdong", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)HopdongbanhangFieldIndex.Ngayhopdong, 0, 0, 0);
			base.AddElementFieldInfo("HopdongbanhangEntity", "Makhach", typeof(System.String), false, false, false, true,  (int)HopdongbanhangFieldIndex.Makhach, 50, 0, 0);
			base.AddElementFieldInfo("HopdongbanhangEntity", "Tenkhach", typeof(System.String), false, false, false, true,  (int)HopdongbanhangFieldIndex.Tenkhach, 250, 0, 0);
			base.AddElementFieldInfo("HopdongbanhangEntity", "Macangden", typeof(System.String), false, false, false, true,  (int)HopdongbanhangFieldIndex.Macangden, 50, 0, 0);
			base.AddElementFieldInfo("HopdongbanhangEntity", "Tencangden", typeof(System.String), false, false, false, true,  (int)HopdongbanhangFieldIndex.Tencangden, 250, 0, 0);
			base.AddElementFieldInfo("HopdongbanhangEntity", "Thanhtienvnd", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)HopdongbanhangFieldIndex.Thanhtienvnd, 0, 2, 20);
			base.AddElementFieldInfo("HopdongbanhangEntity", "Thanhtienusd", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)HopdongbanhangFieldIndex.Thanhtienusd, 0, 2, 20);
			base.AddElementFieldInfo("HopdongbanhangEntity", "Ngaytao", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)HopdongbanhangFieldIndex.Ngaytao, 0, 0, 0);
			base.AddElementFieldInfo("HopdongbanhangEntity", "Nguoitao", typeof(System.String), false, false, false, true,  (int)HopdongbanhangFieldIndex.Nguoitao, 50, 0, 0);
			base.AddElementFieldInfo("HopdongbanhangEntity", "Ngaysua", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)HopdongbanhangFieldIndex.Ngaysua, 0, 0, 0);
			base.AddElementFieldInfo("HopdongbanhangEntity", "Nguoisua", typeof(System.String), false, false, false, true,  (int)HopdongbanhangFieldIndex.Nguoisua, 50, 0, 0);
		}
		/// <summary>Inits HopdongbanhangchitietEntity's FieldInfo objects</summary>
		private void InitHopdongbanhangchitietEntityInfos()
		{
			base.AddElementFieldInfo("HopdongbanhangchitietEntity", "Id", typeof(System.Int64), true, false, true, false,  (int)HopdongbanhangchitietFieldIndex.Id, 0, 0, 19);
			base.AddElementFieldInfo("HopdongbanhangchitietEntity", "Sohopdong", typeof(System.String), false, false, false, true,  (int)HopdongbanhangchitietFieldIndex.Sohopdong, 50, 0, 0);
			base.AddElementFieldInfo("HopdongbanhangchitietEntity", "Ngayhopdong", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)HopdongbanhangchitietFieldIndex.Ngayhopdong, 0, 0, 0);
			base.AddElementFieldInfo("HopdongbanhangchitietEntity", "Makhach", typeof(System.String), false, false, false, true,  (int)HopdongbanhangchitietFieldIndex.Makhach, 50, 0, 0);
			base.AddElementFieldInfo("HopdongbanhangchitietEntity", "Tenkhach", typeof(System.String), false, false, false, true,  (int)HopdongbanhangchitietFieldIndex.Tenkhach, 250, 0, 0);
			base.AddElementFieldInfo("HopdongbanhangchitietEntity", "Macangden", typeof(System.String), false, false, false, true,  (int)HopdongbanhangchitietFieldIndex.Macangden, 50, 0, 0);
			base.AddElementFieldInfo("HopdongbanhangchitietEntity", "Tencangden", typeof(System.String), false, false, false, true,  (int)HopdongbanhangchitietFieldIndex.Tencangden, 250, 0, 0);
			base.AddElementFieldInfo("HopdongbanhangchitietEntity", "Mahangphiakhach", typeof(System.String), false, false, false, true,  (int)HopdongbanhangchitietFieldIndex.Mahangphiakhach, 50, 0, 0);
			base.AddElementFieldInfo("HopdongbanhangchitietEntity", "Codefiller", typeof(System.String), false, false, false, true,  (int)HopdongbanhangchitietFieldIndex.Codefiller, 50, 0, 0);
			base.AddElementFieldInfo("HopdongbanhangchitietEntity", "Soluong", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)HopdongbanhangchitietFieldIndex.Soluong, 0, 2, 20);
			base.AddElementFieldInfo("HopdongbanhangchitietEntity", "Dongiavnd", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)HopdongbanhangchitietFieldIndex.Dongiavnd, 0, 2, 20);
			base.AddElementFieldInfo("HopdongbanhangchitietEntity", "Tygia", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)HopdongbanhangchitietFieldIndex.Tygia, 0, 2, 20);
			base.AddElementFieldInfo("HopdongbanhangchitietEntity", "Dongiausd", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)HopdongbanhangchitietFieldIndex.Dongiausd, 0, 4, 20);
			base.AddElementFieldInfo("HopdongbanhangchitietEntity", "Thanhtienvnd", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)HopdongbanhangchitietFieldIndex.Thanhtienvnd, 0, 2, 20);
			base.AddElementFieldInfo("HopdongbanhangchitietEntity", "Thanhtienusd", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)HopdongbanhangchitietFieldIndex.Thanhtienusd, 0, 2, 20);
			base.AddElementFieldInfo("HopdongbanhangchitietEntity", "Ngaytao", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)HopdongbanhangchitietFieldIndex.Ngaytao, 0, 0, 0);
			base.AddElementFieldInfo("HopdongbanhangchitietEntity", "Nguoitao", typeof(System.String), false, false, false, true,  (int)HopdongbanhangchitietFieldIndex.Nguoitao, 50, 0, 0);
			base.AddElementFieldInfo("HopdongbanhangchitietEntity", "Ngaysua", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)HopdongbanhangchitietFieldIndex.Ngaysua, 0, 0, 0);
			base.AddElementFieldInfo("HopdongbanhangchitietEntity", "Nguoisua", typeof(System.String), false, false, false, true,  (int)HopdongbanhangchitietFieldIndex.Nguoisua, 50, 0, 0);
		}
		/// <summary>Inits LogbackupEntity's FieldInfo objects</summary>
		private void InitLogbackupEntityInfos()
		{
			base.AddElementFieldInfo("LogbackupEntity", "Mahieu", typeof(System.Int64), true, false, true, false,  (int)LogbackupFieldIndex.Mahieu, 0, 0, 19);
			base.AddElementFieldInfo("LogbackupEntity", "Nam", typeof(Nullable<System.Int32>), false, false, false, true,  (int)LogbackupFieldIndex.Nam, 0, 0, 10);
			base.AddElementFieldInfo("LogbackupEntity", "Duongdan", typeof(System.String), false, false, false, true,  (int)LogbackupFieldIndex.Duongdan, 250, 0, 0);
			base.AddElementFieldInfo("LogbackupEntity", "Ngay", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)LogbackupFieldIndex.Ngay, 0, 0, 0);
		}
		/// <summary>Inits MenuEntity's FieldInfo objects</summary>
		private void InitMenuEntityInfos()
		{
			base.AddElementFieldInfo("MenuEntity", "MenuId", typeof(System.String), true, false, false, false,  (int)MenuFieldIndex.MenuId, 20, 0, 0);
			base.AddElementFieldInfo("MenuEntity", "MenuName", typeof(System.String), false, false, false, true,  (int)MenuFieldIndex.MenuName, 500, 0, 0);
			base.AddElementFieldInfo("MenuEntity", "Icon", typeof(System.String), false, false, false, true,  (int)MenuFieldIndex.Icon, 500, 0, 0);
			base.AddElementFieldInfo("MenuEntity", "Issudung", typeof(Nullable<System.Int32>), false, false, false, true,  (int)MenuFieldIndex.Issudung, 0, 0, 10);
			base.AddElementFieldInfo("MenuEntity", "Istrangthai", typeof(Nullable<System.Int32>), false, false, false, true,  (int)MenuFieldIndex.Istrangthai, 0, 0, 10);
			base.AddElementFieldInfo("MenuEntity", "Menuparent", typeof(System.String), false, false, false, true,  (int)MenuFieldIndex.Menuparent, 50, 0, 0);
			base.AddElementFieldInfo("MenuEntity", "Thutu", typeof(Nullable<System.Int32>), false, false, false, true,  (int)MenuFieldIndex.Thutu, 0, 0, 10);
			base.AddElementFieldInfo("MenuEntity", "FormName", typeof(System.String), false, false, false, true,  (int)MenuFieldIndex.FormName, 1000, 0, 0);
			base.AddElementFieldInfo("MenuEntity", "LoaiMenu", typeof(Nullable<System.Int32>), false, false, false, true,  (int)MenuFieldIndex.LoaiMenu, 0, 0, 10);
			base.AddElementFieldInfo("MenuEntity", "Param", typeof(System.String), false, false, false, true,  (int)MenuFieldIndex.Param, 500, 0, 0);
			base.AddElementFieldInfo("MenuEntity", "Maphanhe", typeof(System.String), false, false, false, true,  (int)MenuFieldIndex.Maphanhe, 50, 0, 0);
		}
		/// <summary>Inits MenuroleEntity's FieldInfo objects</summary>
		private void InitMenuroleEntityInfos()
		{
			base.AddElementFieldInfo("MenuroleEntity", "Menuid", typeof(System.String), true, true, false, false,  (int)MenuroleFieldIndex.Menuid, 20, 0, 0);
			base.AddElementFieldInfo("MenuroleEntity", "Rolesid", typeof(System.String), true, true, false, false,  (int)MenuroleFieldIndex.Rolesid, 50, 0, 0);
		}
		/// <summary>Inits NhanvienEntity's FieldInfo objects</summary>
		private void InitNhanvienEntityInfos()
		{
			base.AddElementFieldInfo("NhanvienEntity", "Manhanvien", typeof(System.String), true, false, false, false,  (int)NhanvienFieldIndex.Manhanvien, 50, 0, 0);
			base.AddElementFieldInfo("NhanvienEntity", "Hoten", typeof(System.String), false, false, false, true,  (int)NhanvienFieldIndex.Hoten, 50, 0, 0);
			base.AddElementFieldInfo("NhanvienEntity", "Maphongban", typeof(System.String), false, false, false, true,  (int)NhanvienFieldIndex.Maphongban, 50, 0, 0);
			base.AddElementFieldInfo("NhanvienEntity", "Tenphongban", typeof(System.String), false, false, false, true,  (int)NhanvienFieldIndex.Tenphongban, 250, 0, 0);
			base.AddElementFieldInfo("NhanvienEntity", "Machucvu", typeof(System.String), false, false, false, true,  (int)NhanvienFieldIndex.Machucvu, 50, 0, 0);
			base.AddElementFieldInfo("NhanvienEntity", "Tenchucvu", typeof(System.String), false, false, false, true,  (int)NhanvienFieldIndex.Tenchucvu, 250, 0, 0);
			base.AddElementFieldInfo("NhanvienEntity", "Gioitinh", typeof(Nullable<System.Boolean>), false, false, false, true,  (int)NhanvienFieldIndex.Gioitinh, 0, 0, 0);
			base.AddElementFieldInfo("NhanvienEntity", "Ngaysinh", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)NhanvienFieldIndex.Ngaysinh, 0, 0, 0);
			base.AddElementFieldInfo("NhanvienEntity", "Diachi", typeof(System.String), false, false, false, true,  (int)NhanvienFieldIndex.Diachi, 250, 0, 0);
			base.AddElementFieldInfo("NhanvienEntity", "Sodienthoai", typeof(System.String), false, false, false, true,  (int)NhanvienFieldIndex.Sodienthoai, 50, 0, 0);
			base.AddElementFieldInfo("NhanvienEntity", "Email", typeof(System.String), false, false, false, true,  (int)NhanvienFieldIndex.Email, 50, 0, 0);
		}
		/// <summary>Inits PhongbanEntity's FieldInfo objects</summary>
		private void InitPhongbanEntityInfos()
		{
			base.AddElementFieldInfo("PhongbanEntity", "Mahieu", typeof(System.String), true, false, false, false,  (int)PhongbanFieldIndex.Mahieu, 50, 0, 0);
			base.AddElementFieldInfo("PhongbanEntity", "Tenhieu", typeof(System.String), false, false, false, true,  (int)PhongbanFieldIndex.Tenhieu, 250, 0, 0);
			base.AddElementFieldInfo("PhongbanEntity", "Tenrutgon", typeof(System.String), false, false, false, true,  (int)PhongbanFieldIndex.Tenrutgon, 50, 0, 0);
			base.AddElementFieldInfo("PhongbanEntity", "Ngaytao", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)PhongbanFieldIndex.Ngaytao, 0, 0, 0);
			base.AddElementFieldInfo("PhongbanEntity", "Nguoitao", typeof(System.String), false, false, false, true,  (int)PhongbanFieldIndex.Nguoitao, 50, 0, 0);
			base.AddElementFieldInfo("PhongbanEntity", "Ngaysua", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)PhongbanFieldIndex.Ngaysua, 0, 0, 0);
			base.AddElementFieldInfo("PhongbanEntity", "Nguoisua", typeof(System.String), false, false, false, true,  (int)PhongbanFieldIndex.Nguoisua, 50, 0, 0);
		}
		/// <summary>Inits PhuongthucthanhtoanEntity's FieldInfo objects</summary>
		private void InitPhuongthucthanhtoanEntityInfos()
		{
			base.AddElementFieldInfo("PhuongthucthanhtoanEntity", "Mahieu", typeof(System.String), true, false, false, false,  (int)PhuongthucthanhtoanFieldIndex.Mahieu, 50, 0, 0);
			base.AddElementFieldInfo("PhuongthucthanhtoanEntity", "Tenhieu", typeof(System.String), false, false, false, true,  (int)PhuongthucthanhtoanFieldIndex.Tenhieu, 250, 0, 0);
			base.AddElementFieldInfo("PhuongthucthanhtoanEntity", "Tenrutgon", typeof(System.String), false, false, false, true,  (int)PhuongthucthanhtoanFieldIndex.Tenrutgon, 50, 0, 0);
			base.AddElementFieldInfo("PhuongthucthanhtoanEntity", "Deposit", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)PhuongthucthanhtoanFieldIndex.Deposit, 0, 2, 20);
			base.AddElementFieldInfo("PhuongthucthanhtoanEntity", "Pay", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)PhuongthucthanhtoanFieldIndex.Pay, 0, 2, 20);
			base.AddElementFieldInfo("PhuongthucthanhtoanEntity", "Ngaytao", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)PhuongthucthanhtoanFieldIndex.Ngaytao, 0, 0, 0);
			base.AddElementFieldInfo("PhuongthucthanhtoanEntity", "Nguoitao", typeof(System.String), false, false, false, true,  (int)PhuongthucthanhtoanFieldIndex.Nguoitao, 50, 0, 0);
			base.AddElementFieldInfo("PhuongthucthanhtoanEntity", "Ngaysua", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)PhuongthucthanhtoanFieldIndex.Ngaysua, 0, 0, 0);
			base.AddElementFieldInfo("PhuongthucthanhtoanEntity", "Nguoisua", typeof(System.String), false, false, false, true,  (int)PhuongthucthanhtoanFieldIndex.Nguoisua, 50, 0, 0);
		}
		/// <summary>Inits PhuongthucvanchuyenEntity's FieldInfo objects</summary>
		private void InitPhuongthucvanchuyenEntityInfos()
		{
			base.AddElementFieldInfo("PhuongthucvanchuyenEntity", "Mahieu", typeof(System.String), true, false, false, false,  (int)PhuongthucvanchuyenFieldIndex.Mahieu, 50, 0, 0);
			base.AddElementFieldInfo("PhuongthucvanchuyenEntity", "Tenhieu", typeof(System.String), false, false, false, true,  (int)PhuongthucvanchuyenFieldIndex.Tenhieu, 250, 0, 0);
			base.AddElementFieldInfo("PhuongthucvanchuyenEntity", "Tenrutgon", typeof(System.String), false, false, false, true,  (int)PhuongthucvanchuyenFieldIndex.Tenrutgon, 50, 0, 0);
			base.AddElementFieldInfo("PhuongthucvanchuyenEntity", "Ngaytao", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)PhuongthucvanchuyenFieldIndex.Ngaytao, 0, 0, 0);
			base.AddElementFieldInfo("PhuongthucvanchuyenEntity", "Nguoitao", typeof(System.String), false, false, false, true,  (int)PhuongthucvanchuyenFieldIndex.Nguoitao, 50, 0, 0);
			base.AddElementFieldInfo("PhuongthucvanchuyenEntity", "Ngaysua", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)PhuongthucvanchuyenFieldIndex.Ngaysua, 0, 0, 0);
			base.AddElementFieldInfo("PhuongthucvanchuyenEntity", "Nguoisua", typeof(System.String), false, false, false, true,  (int)PhuongthucvanchuyenFieldIndex.Nguoisua, 50, 0, 0);
		}
		/// <summary>Inits RolesEntity's FieldInfo objects</summary>
		private void InitRolesEntityInfos()
		{
			base.AddElementFieldInfo("RolesEntity", "Rolesid", typeof(System.String), true, false, false, false,  (int)RolesFieldIndex.Rolesid, 50, 0, 0);
			base.AddElementFieldInfo("RolesEntity", "Rolesname", typeof(System.String), false, false, false, true,  (int)RolesFieldIndex.Rolesname, 50, 0, 0);
			base.AddElementFieldInfo("RolesEntity", "Description", typeof(System.String), false, false, false, true,  (int)RolesFieldIndex.Description, 200, 0, 0);
		}
		/// <summary>Inits ThamsoEntity's FieldInfo objects</summary>
		private void InitThamsoEntityInfos()
		{
			base.AddElementFieldInfo("ThamsoEntity", "Mahieu", typeof(System.String), true, false, false, false,  (int)ThamsoFieldIndex.Mahieu, 20, 0, 0);
			base.AddElementFieldInfo("ThamsoEntity", "Stt", typeof(System.Int32), false, false, false, false,  (int)ThamsoFieldIndex.Stt, 0, 0, 10);
			base.AddElementFieldInfo("ThamsoEntity", "Tenthamso", typeof(System.String), false, false, false, false,  (int)ThamsoFieldIndex.Tenthamso, 200, 0, 0);
			base.AddElementFieldInfo("ThamsoEntity", "Giatri", typeof(System.String), false, false, false, true,  (int)ThamsoFieldIndex.Giatri, 200, 0, 0);
			base.AddElementFieldInfo("ThamsoEntity", "Thaydoi", typeof(System.Boolean), false, false, false, false,  (int)ThamsoFieldIndex.Thaydoi, 0, 0, 0);
			base.AddElementFieldInfo("ThamsoEntity", "Kieudulieu", typeof(System.Int32), false, false, false, false,  (int)ThamsoFieldIndex.Kieudulieu, 0, 0, 10);
			base.AddElementFieldInfo("ThamsoEntity", "Ghichu", typeof(System.String), false, false, false, true,  (int)ThamsoFieldIndex.Ghichu, 200, 0, 0);
			base.AddElementFieldInfo("ThamsoEntity", "Loaithamso", typeof(Nullable<System.Int32>), false, false, false, true,  (int)ThamsoFieldIndex.Loaithamso, 0, 0, 10);
			base.AddElementFieldInfo("ThamsoEntity", "An", typeof(Nullable<System.Boolean>), false, false, false, true,  (int)ThamsoFieldIndex.An, 0, 0, 0);
		}
		/// <summary>Inits ThuchienhopdongbanhangEntity's FieldInfo objects</summary>
		private void InitThuchienhopdongbanhangEntityInfos()
		{
			base.AddElementFieldInfo("ThuchienhopdongbanhangEntity", "Id", typeof(System.Int64), true, false, true, false,  (int)ThuchienhopdongbanhangFieldIndex.Id, 0, 0, 19);
			base.AddElementFieldInfo("ThuchienhopdongbanhangEntity", "Sohopdong", typeof(System.String), false, false, false, true,  (int)ThuchienhopdongbanhangFieldIndex.Sohopdong, 50, 0, 0);
			base.AddElementFieldInfo("ThuchienhopdongbanhangEntity", "Ngayhopdong", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)ThuchienhopdongbanhangFieldIndex.Ngayhopdong, 0, 0, 0);
			base.AddElementFieldInfo("ThuchienhopdongbanhangEntity", "Makhach", typeof(System.String), false, false, false, true,  (int)ThuchienhopdongbanhangFieldIndex.Makhach, 50, 0, 0);
			base.AddElementFieldInfo("ThuchienhopdongbanhangEntity", "Tenkhach", typeof(System.String), false, false, false, true,  (int)ThuchienhopdongbanhangFieldIndex.Tenkhach, 250, 0, 0);
			base.AddElementFieldInfo("ThuchienhopdongbanhangEntity", "Mahangphiakhach", typeof(System.String), false, false, false, true,  (int)ThuchienhopdongbanhangFieldIndex.Mahangphiakhach, 50, 0, 0);
			base.AddElementFieldInfo("ThuchienhopdongbanhangEntity", "Codefiller", typeof(System.String), false, false, false, true,  (int)ThuchienhopdongbanhangFieldIndex.Codefiller, 50, 0, 0);
			base.AddElementFieldInfo("ThuchienhopdongbanhangEntity", "Soluonggiao", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)ThuchienhopdongbanhangFieldIndex.Soluonggiao, 0, 2, 20);
			base.AddElementFieldInfo("ThuchienhopdongbanhangEntity", "Ngaygiao", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)ThuchienhopdongbanhangFieldIndex.Ngaygiao, 0, 0, 0);
			base.AddElementFieldInfo("ThuchienhopdongbanhangEntity", "Dongiavnd", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)ThuchienhopdongbanhangFieldIndex.Dongiavnd, 0, 2, 20);
			base.AddElementFieldInfo("ThuchienhopdongbanhangEntity", "Tygia", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)ThuchienhopdongbanhangFieldIndex.Tygia, 0, 2, 20);
			base.AddElementFieldInfo("ThuchienhopdongbanhangEntity", "Dongiausd", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)ThuchienhopdongbanhangFieldIndex.Dongiausd, 0, 4, 20);
			base.AddElementFieldInfo("ThuchienhopdongbanhangEntity", "Thanhtienvnd", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)ThuchienhopdongbanhangFieldIndex.Thanhtienvnd, 0, 2, 20);
			base.AddElementFieldInfo("ThuchienhopdongbanhangEntity", "Thanhtienusd", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)ThuchienhopdongbanhangFieldIndex.Thanhtienusd, 0, 2, 20);
			base.AddElementFieldInfo("ThuchienhopdongbanhangEntity", "Ngaytao", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)ThuchienhopdongbanhangFieldIndex.Ngaytao, 0, 0, 0);
			base.AddElementFieldInfo("ThuchienhopdongbanhangEntity", "Nguoitao", typeof(System.String), false, false, false, true,  (int)ThuchienhopdongbanhangFieldIndex.Nguoitao, 50, 0, 0);
			base.AddElementFieldInfo("ThuchienhopdongbanhangEntity", "Ngaysua", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)ThuchienhopdongbanhangFieldIndex.Ngaysua, 0, 0, 0);
			base.AddElementFieldInfo("ThuchienhopdongbanhangEntity", "Nguoisua", typeof(System.String), false, false, false, true,  (int)ThuchienhopdongbanhangFieldIndex.Nguoisua, 50, 0, 0);
		}
		/// <summary>Inits TygiaEntity's FieldInfo objects</summary>
		private void InitTygiaEntityInfos()
		{
			base.AddElementFieldInfo("TygiaEntity", "Thang", typeof(System.String), true, false, false, false,  (int)TygiaFieldIndex.Thang, 20, 0, 0);
			base.AddElementFieldInfo("TygiaEntity", "Tygia", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)TygiaFieldIndex.Tygia, 0, 2, 20);
			base.AddElementFieldInfo("TygiaEntity", "Ngaytao", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)TygiaFieldIndex.Ngaytao, 0, 0, 0);
			base.AddElementFieldInfo("TygiaEntity", "Nguoitao", typeof(System.String), false, false, false, true,  (int)TygiaFieldIndex.Nguoitao, 50, 0, 0);
			base.AddElementFieldInfo("TygiaEntity", "Ngaysua", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)TygiaFieldIndex.Ngaysua, 0, 0, 0);
			base.AddElementFieldInfo("TygiaEntity", "Nguoisua", typeof(System.String), false, false, false, true,  (int)TygiaFieldIndex.Nguoisua, 50, 0, 0);
		}
		/// <summary>Inits UsersEntity's FieldInfo objects</summary>
		private void InitUsersEntityInfos()
		{
			base.AddElementFieldInfo("UsersEntity", "Userid", typeof(System.String), true, false, false, false,  (int)UsersFieldIndex.Userid, 50, 0, 0);
			base.AddElementFieldInfo("UsersEntity", "Rolesid", typeof(System.String), false, true, false, false,  (int)UsersFieldIndex.Rolesid, 50, 0, 0);
			base.AddElementFieldInfo("UsersEntity", "Username", typeof(System.String), false, false, false, false,  (int)UsersFieldIndex.Username, 150, 0, 0);
			base.AddElementFieldInfo("UsersEntity", "Fullname", typeof(System.String), false, false, false, true,  (int)UsersFieldIndex.Fullname, 500, 0, 0);
			base.AddElementFieldInfo("UsersEntity", "Phone", typeof(System.String), false, false, false, true,  (int)UsersFieldIndex.Phone, 50, 0, 0);
			base.AddElementFieldInfo("UsersEntity", "Address", typeof(System.String), false, false, false, true,  (int)UsersFieldIndex.Address, 500, 0, 0);
			base.AddElementFieldInfo("UsersEntity", "Password", typeof(System.String), false, false, false, false,  (int)UsersFieldIndex.Password, 50, 0, 0);
			base.AddElementFieldInfo("UsersEntity", "Active", typeof(Nullable<System.Boolean>), false, false, false, true,  (int)UsersFieldIndex.Active, 0, 0, 0);
		}
		
	}
}




