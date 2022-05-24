///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 2.6
// Code is generated on: 24 Tháng Năm 2022 9:06:27 SA
// Code is generated using templates: SD.TemplateBindings.SqlServerSpecific.NET20
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using System.Collections;
using System.Data;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace GD.FM.DAL.DatabaseSpecific
{
	/// <summary>
	/// Singleton implementation of the PersistenceInfoProvider. This class is the singleton wrapper through which the actual instance is retrieved.
	/// </summary>
	/// <remarks>It uses a single instance of an internal class. The access isn't marked with locks as the PersistenceInfoProviderBase class is threadsafe.</remarks>
	internal sealed class PersistenceInfoProviderSingleton
	{
		#region Class Member Declarations
		private static readonly IPersistenceInfoProvider _providerInstance = new PersistenceInfoProviderCore();
		#endregion
		
		/// <summary>private ctor to prevent instances of this class.</summary>
		private PersistenceInfoProviderSingleton()
		{
		}

		/// <summary>Dummy static constructor to make sure threadsafe initialization is performed.</summary>
		static PersistenceInfoProviderSingleton()
		{
		}

		/// <summary>Gets the singleton instance of the PersistenceInfoProviderCore</summary>
		/// <returns>Instance of the PersistenceInfoProvider.</returns>
		public static IPersistenceInfoProvider GetInstance()
		{
			return _providerInstance;
		}
	}

	/// <summary>Actual implementation of the PersistenceInfoProvider. Used by singleton wrapper.</summary>
	internal class PersistenceInfoProviderCore : PersistenceInfoProviderBase
	{
		/// <summary>Initializes a new instance of the <see cref="PersistenceInfoProviderCore"/> class.</summary>
		internal PersistenceInfoProviderCore()
		{
			Init();
		}

		/// <summary>Method which initializes the internal datastores with the structure of hierarchical types.</summary>
		private void Init()
		{
			base.InitClass((27 + 0));
			InitCacbuoclogisticEntityMappings();
			InitDanhmuccangEntityMappings();
			InitDanhmucchucvuEntityMappings();
			InitDanhmuckhachEntityMappings();
			InitDanhmucnganhangEntityMappings();
			InitDanhmucquocgiaEntityMappings();
			InitDanhmucungdungEntityMappings();
			InitDanhmuchanghoaEntityMappings();
			InitDmcapmaEntityMappings();
			InitDonvitinhEntityMappings();
			InitDulieuxnkEntityMappings();
			InitFormcoEntityMappings();
			InitHopdongbanhangEntityMappings();
			InitHopdongbanhangchitietEntityMappings();
			InitLogbackupEntityMappings();
			InitMenuEntityMappings();
			InitMenuroleEntityMappings();
			InitNhanvienEntityMappings();
			InitPhongbanEntityMappings();
			InitPhuongthucthanhtoanEntityMappings();
			InitPhuongthucvanchuyenEntityMappings();
			InitRolesEntityMappings();
			InitTygiaEntityMappings();
			InitThamsoEntityMappings();
			InitThuchienlogisticEntityMappings();
			InitThuchienhopdongbanhangEntityMappings();
			InitUsersEntityMappings();

		}


		/// <summary>Inits CacbuoclogisticEntity's mappings</summary>
		private void InitCacbuoclogisticEntityMappings()
		{
			base.AddElementMapping( "CacbuoclogisticEntity", "FM", @"dbo", "Cacbuoclogistic", 7 );
			base.AddElementFieldMapping( "CacbuoclogisticEntity", "Mahieu", "Mahieu", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 0 );
			base.AddElementFieldMapping( "CacbuoclogisticEntity", "Tenhieu", "Tenhieu", true, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 1 );
			base.AddElementFieldMapping( "CacbuoclogisticEntity", "Tenrutgon", "Tenrutgon", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 2 );
			base.AddElementFieldMapping( "CacbuoclogisticEntity", "Ngaytao", "Ngaytao", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 3 );
			base.AddElementFieldMapping( "CacbuoclogisticEntity", "Nguoitao", "Nguoitao", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 4 );
			base.AddElementFieldMapping( "CacbuoclogisticEntity", "Ngaysua", "Ngaysua", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 5 );
			base.AddElementFieldMapping( "CacbuoclogisticEntity", "Nguoisua", "Nguoisua", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 6 );
		}
		/// <summary>Inits DanhmuccangEntity's mappings</summary>
		private void InitDanhmuccangEntityMappings()
		{
			base.AddElementMapping( "DanhmuccangEntity", "FM", @"dbo", "Danhmuccang", 9 );
			base.AddElementFieldMapping( "DanhmuccangEntity", "Mahieu", "Mahieu", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 0 );
			base.AddElementFieldMapping( "DanhmuccangEntity", "Tenhieu", "Tenhieu", true, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 1 );
			base.AddElementFieldMapping( "DanhmuccangEntity", "Tenrutgon", "Tenrutgon", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 2 );
			base.AddElementFieldMapping( "DanhmuccangEntity", "Maquocgia", "Maquocgia", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 3 );
			base.AddElementFieldMapping( "DanhmuccangEntity", "Tenquocgia", "Tenquocgia", true, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 4 );
			base.AddElementFieldMapping( "DanhmuccangEntity", "Ngaytao", "Ngaytao", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 5 );
			base.AddElementFieldMapping( "DanhmuccangEntity", "Nguoitao", "Nguoitao", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 6 );
			base.AddElementFieldMapping( "DanhmuccangEntity", "Ngaysua", "Ngaysua", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 7 );
			base.AddElementFieldMapping( "DanhmuccangEntity", "Nguoisua", "Nguoisua", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 8 );
		}
		/// <summary>Inits DanhmucchucvuEntity's mappings</summary>
		private void InitDanhmucchucvuEntityMappings()
		{
			base.AddElementMapping( "DanhmucchucvuEntity", "FM", @"dbo", "Danhmucchucvu", 7 );
			base.AddElementFieldMapping( "DanhmucchucvuEntity", "Mahieu", "Mahieu", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 0 );
			base.AddElementFieldMapping( "DanhmucchucvuEntity", "Tenhieu", "Tenhieu", true, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 1 );
			base.AddElementFieldMapping( "DanhmucchucvuEntity", "Tenrutgon", "Tenrutgon", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 2 );
			base.AddElementFieldMapping( "DanhmucchucvuEntity", "Ngaytao", "Ngaytao", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 3 );
			base.AddElementFieldMapping( "DanhmucchucvuEntity", "Nguoitao", "Nguoitao", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 4 );
			base.AddElementFieldMapping( "DanhmucchucvuEntity", "Ngaysua", "Ngaysua", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 5 );
			base.AddElementFieldMapping( "DanhmucchucvuEntity", "Nguoisua", "Nguoisua", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 6 );
		}
		/// <summary>Inits DanhmuckhachEntity's mappings</summary>
		private void InitDanhmuckhachEntityMappings()
		{
			base.AddElementMapping( "DanhmuckhachEntity", "FM", @"dbo", "Danhmuckhach", 24 );
			base.AddElementFieldMapping( "DanhmuckhachEntity", "Mahieu", "Mahieu", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 0 );
			base.AddElementFieldMapping( "DanhmuckhachEntity", "Tenhieu", "Tenhieu", false, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 1 );
			base.AddElementFieldMapping( "DanhmuckhachEntity", "Tenrutgon", "Tenrutgon", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 2 );
			base.AddElementFieldMapping( "DanhmuckhachEntity", "Diachi", "Diachi", true, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 3 );
			base.AddElementFieldMapping( "DanhmuckhachEntity", "Sodienthoai", "Sodienthoai", true, (int)SqlDbType.NVarChar, 100, 0, 0, false, "", null, typeof(System.String), 4 );
			base.AddElementFieldMapping( "DanhmuckhachEntity", "Sofax", "Sofax", true, (int)SqlDbType.NVarChar, 100, 0, 0, false, "", null, typeof(System.String), 5 );
			base.AddElementFieldMapping( "DanhmuckhachEntity", "Masothue", "Masothue", true, (int)SqlDbType.NVarChar, 100, 0, 0, false, "", null, typeof(System.String), 6 );
			base.AddElementFieldMapping( "DanhmuckhachEntity", "Taikhoannganhang", "Taikhoannganhang", true, (int)SqlDbType.NVarChar, 100, 0, 0, false, "", null, typeof(System.String), 7 );
			base.AddElementFieldMapping( "DanhmuckhachEntity", "Tennganhang", "Tennganhang", true, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 8 );
			base.AddElementFieldMapping( "DanhmuckhachEntity", "Email", "Email", true, (int)SqlDbType.NVarChar, 100, 0, 0, false, "", null, typeof(System.String), 9 );
			base.AddElementFieldMapping( "DanhmuckhachEntity", "Noidia", "Noidia", true, (int)SqlDbType.Bit, 0, 0, 0, false, "", null, typeof(System.Boolean), 10 );
			base.AddElementFieldMapping( "DanhmuckhachEntity", "Truyenthong", "Truyenthong", true, (int)SqlDbType.Bit, 0, 0, 0, false, "", null, typeof(System.Boolean), 11 );
			base.AddElementFieldMapping( "DanhmuckhachEntity", "Nguoilienhehoten", "Nguoilienhehoten", true, (int)SqlDbType.NVarChar, 100, 0, 0, false, "", null, typeof(System.String), 12 );
			base.AddElementFieldMapping( "DanhmuckhachEntity", "Nguoilienhechucvu", "Nguoilienhechucvu", true, (int)SqlDbType.NVarChar, 100, 0, 0, false, "", null, typeof(System.String), 13 );
			base.AddElementFieldMapping( "DanhmuckhachEntity", "Nguoilienhesodienthoai", "Nguoilienhesodienthoai", true, (int)SqlDbType.NVarChar, 100, 0, 0, false, "", null, typeof(System.String), 14 );
			base.AddElementFieldMapping( "DanhmuckhachEntity", "Nguoilienhethongtinbosung", "Nguoilienhethongtinbosung", true, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 15 );
			base.AddElementFieldMapping( "DanhmuckhachEntity", "Ngaytao", "Ngaytao", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 16 );
			base.AddElementFieldMapping( "DanhmuckhachEntity", "Nguoitao", "Nguoitao", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 17 );
			base.AddElementFieldMapping( "DanhmuckhachEntity", "Ngaysua", "Ngaysua", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 18 );
			base.AddElementFieldMapping( "DanhmuckhachEntity", "Nguoisua", "Nguoisua", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 19 );
			base.AddElementFieldMapping( "DanhmuckhachEntity", "Manhanvien", "Manhanvien", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 20 );
			base.AddElementFieldMapping( "DanhmuckhachEntity", "Tennhanvien", "Tennhanvien", true, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 21 );
			base.AddElementFieldMapping( "DanhmuckhachEntity", "Macode", "Macode", true, (int)SqlDbType.NVarChar, 2147483647, 0, 0, false, "", null, typeof(System.String), 22 );
			base.AddElementFieldMapping( "DanhmuckhachEntity", "Mafiller", "Mafiller", true, (int)SqlDbType.NVarChar, 2147483647, 0, 0, false, "", null, typeof(System.String), 23 );
		}
		/// <summary>Inits DanhmucnganhangEntity's mappings</summary>
		private void InitDanhmucnganhangEntityMappings()
		{
			base.AddElementMapping( "DanhmucnganhangEntity", "FM", @"dbo", "Danhmucnganhang", 10 );
			base.AddElementFieldMapping( "DanhmucnganhangEntity", "Mahieu", "Mahieu", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 0 );
			base.AddElementFieldMapping( "DanhmucnganhangEntity", "AccountHolder", "AccountHolder", true, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 1 );
			base.AddElementFieldMapping( "DanhmucnganhangEntity", "Bank", "Bank", true, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 2 );
			base.AddElementFieldMapping( "DanhmucnganhangEntity", "Address", "Address", true, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 3 );
			base.AddElementFieldMapping( "DanhmucnganhangEntity", "Accountnumber", "Accountnumber", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 4 );
			base.AddElementFieldMapping( "DanhmucnganhangEntity", "Swift", "Swift", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 5 );
			base.AddElementFieldMapping( "DanhmucnganhangEntity", "Ngaytao", "Ngaytao", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 6 );
			base.AddElementFieldMapping( "DanhmucnganhangEntity", "Nguoitao", "Nguoitao", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 7 );
			base.AddElementFieldMapping( "DanhmucnganhangEntity", "Ngaysua", "Ngaysua", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 8 );
			base.AddElementFieldMapping( "DanhmucnganhangEntity", "Nguoisua", "Nguoisua", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 9 );
		}
		/// <summary>Inits DanhmucquocgiaEntity's mappings</summary>
		private void InitDanhmucquocgiaEntityMappings()
		{
			base.AddElementMapping( "DanhmucquocgiaEntity", "FM", @"dbo", "Danhmucquocgia", 7 );
			base.AddElementFieldMapping( "DanhmucquocgiaEntity", "Mahieu", "Mahieu", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 0 );
			base.AddElementFieldMapping( "DanhmucquocgiaEntity", "Tenhieu", "Tenhieu", true, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 1 );
			base.AddElementFieldMapping( "DanhmucquocgiaEntity", "Tenrutgon", "Tenrutgon", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 2 );
			base.AddElementFieldMapping( "DanhmucquocgiaEntity", "Ngaytao", "Ngaytao", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 3 );
			base.AddElementFieldMapping( "DanhmucquocgiaEntity", "Nguoitao", "Nguoitao", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 4 );
			base.AddElementFieldMapping( "DanhmucquocgiaEntity", "Ngaysua", "Ngaysua", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 5 );
			base.AddElementFieldMapping( "DanhmucquocgiaEntity", "Nguoisua", "Nguoisua", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 6 );
		}
		/// <summary>Inits DanhmucungdungEntity's mappings</summary>
		private void InitDanhmucungdungEntityMappings()
		{
			base.AddElementMapping( "DanhmucungdungEntity", "FM", @"dbo", "Danhmucungdung", 7 );
			base.AddElementFieldMapping( "DanhmucungdungEntity", "Mahieu", "Mahieu", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 0 );
			base.AddElementFieldMapping( "DanhmucungdungEntity", "Tenhieu", "Tenhieu", true, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 1 );
			base.AddElementFieldMapping( "DanhmucungdungEntity", "Tenrutgon", "Tenrutgon", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 2 );
			base.AddElementFieldMapping( "DanhmucungdungEntity", "Ngaytao", "Ngaytao", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 3 );
			base.AddElementFieldMapping( "DanhmucungdungEntity", "Nguoitao", "Nguoitao", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 4 );
			base.AddElementFieldMapping( "DanhmucungdungEntity", "Ngaysua", "Ngaysua", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 5 );
			base.AddElementFieldMapping( "DanhmucungdungEntity", "Nguoisua", "Nguoisua", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 6 );
		}
		/// <summary>Inits DanhmuchanghoaEntity's mappings</summary>
		private void InitDanhmuchanghoaEntityMappings()
		{
			base.AddElementMapping( "DanhmuchanghoaEntity", "FM", @"dbo", "Danhmuchanghoa", 18 );
			base.AddElementFieldMapping( "DanhmuchanghoaEntity", "Mahieu", "Mahieu", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 0 );
			base.AddElementFieldMapping( "DanhmuchanghoaEntity", "Makhach", "Makhach", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 1 );
			base.AddElementFieldMapping( "DanhmuchanghoaEntity", "Tenkhach", "Tenkhach", true, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 2 );
			base.AddElementFieldMapping( "DanhmuchanghoaEntity", "Mahangphiakhach", "Mahangphiakhach", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 3 );
			base.AddElementFieldMapping( "DanhmuchanghoaEntity", "Maungdung", "Maungdung", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 4 );
			base.AddElementFieldMapping( "DanhmuchanghoaEntity", "Tocdomay", "Tocdomay", true, (int)SqlDbType.Decimal, 0, 2, 20, false, "", null, typeof(System.Decimal), 5 );
			base.AddElementFieldMapping( "DanhmuchanghoaEntity", "Caco3kh", "Caco3kh", true, (int)SqlDbType.Decimal, 0, 2, 20, false, "", null, typeof(System.Decimal), 6 );
			base.AddElementFieldMapping( "DanhmuchanghoaEntity", "Tio2kh", "Tio2kh", true, (int)SqlDbType.Decimal, 0, 2, 20, false, "", null, typeof(System.Decimal), 7 );
			base.AddElementFieldMapping( "DanhmuchanghoaEntity", "Mikh", "Mikh", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 8 );
			base.AddElementFieldMapping( "DanhmuchanghoaEntity", "Khackh", "Khackh", true, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 9 );
			base.AddElementFieldMapping( "DanhmuchanghoaEntity", "Caco3fm", "Caco3fm", true, (int)SqlDbType.Decimal, 0, 2, 20, false, "", null, typeof(System.Decimal), 10 );
			base.AddElementFieldMapping( "DanhmuchanghoaEntity", "Tio2fm", "Tio2fm", true, (int)SqlDbType.Decimal, 0, 2, 20, false, "", null, typeof(System.Decimal), 11 );
			base.AddElementFieldMapping( "DanhmuchanghoaEntity", "Mifm", "Mifm", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 12 );
			base.AddElementFieldMapping( "DanhmuchanghoaEntity", "Khacfm", "Khacfm", true, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 13 );
			base.AddElementFieldMapping( "DanhmuchanghoaEntity", "Ngaytao", "Ngaytao", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 14 );
			base.AddElementFieldMapping( "DanhmuchanghoaEntity", "Nguoitao", "Nguoitao", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 15 );
			base.AddElementFieldMapping( "DanhmuchanghoaEntity", "Ngaysua", "Ngaysua", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 16 );
			base.AddElementFieldMapping( "DanhmuchanghoaEntity", "Nguoisua", "Nguoisua", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 17 );
		}
		/// <summary>Inits DmcapmaEntity's mappings</summary>
		private void InitDmcapmaEntityMappings()
		{
			base.AddElementMapping( "DmcapmaEntity", "FM", @"dbo", "Dmcapma", 3 );
			base.AddElementFieldMapping( "DmcapmaEntity", "Macappk", "Macappk", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 0 );
			base.AddElementFieldMapping( "DmcapmaEntity", "Loaima", "Loaima", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 1 );
			base.AddElementFieldMapping( "DmcapmaEntity", "Mastart", "Mastart", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 2 );
		}
		/// <summary>Inits DonvitinhEntity's mappings</summary>
		private void InitDonvitinhEntityMappings()
		{
			base.AddElementMapping( "DonvitinhEntity", "FM", @"dbo", "Donvitinh", 7 );
			base.AddElementFieldMapping( "DonvitinhEntity", "Mahieu", "Mahieu", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 0 );
			base.AddElementFieldMapping( "DonvitinhEntity", "Tenhieu", "Tenhieu", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 1 );
			base.AddElementFieldMapping( "DonvitinhEntity", "Tentienganh", "Tentienganh", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 2 );
			base.AddElementFieldMapping( "DonvitinhEntity", "Ngaytao", "Ngaytao", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 3 );
			base.AddElementFieldMapping( "DonvitinhEntity", "Nguoitao", "Nguoitao", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 4 );
			base.AddElementFieldMapping( "DonvitinhEntity", "Ngaysua", "Ngaysua", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 5 );
			base.AddElementFieldMapping( "DonvitinhEntity", "Nguoisua", "Nguoisua", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 6 );
		}
		/// <summary>Inits DulieuxnkEntity's mappings</summary>
		private void InitDulieuxnkEntityMappings()
		{
			base.AddElementMapping( "DulieuxnkEntity", "FM", @"dbo", "Dulieuxnk", 32 );
			base.AddElementFieldMapping( "DulieuxnkEntity", "Id", "Id", false, (int)SqlDbType.BigInt, 0, 0, 19, true, "SCOPE_IDENTITY()", null, typeof(System.Int64), 0 );
			base.AddElementFieldMapping( "DulieuxnkEntity", "Nam", "Nam", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 1 );
			base.AddElementFieldMapping( "DulieuxnkEntity", "Thang", "Thang", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 2 );
			base.AddElementFieldMapping( "DulieuxnkEntity", "Ngaythongquan", "Ngaythongquan", true, (int)SqlDbType.Date, 0, 0, 0, false, "", null, typeof(System.DateTime), 3 );
			base.AddElementFieldMapping( "DulieuxnkEntity", "Masothuexuat", "Masothuexuat", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 4 );
			base.AddElementFieldMapping( "DulieuxnkEntity", "Tencongtyxuat", "Tencongtyxuat", true, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 5 );
			base.AddElementFieldMapping( "DulieuxnkEntity", "Diachicongtyxuat", "Diachicongtyxuat", true, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 6 );
			base.AddElementFieldMapping( "DulieuxnkEntity", "Dienthoaicongtyxuat", "Dienthoaicongtyxuat", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 7 );
			base.AddElementFieldMapping( "DulieuxnkEntity", "Tencongtynhap", "Tencongtynhap", true, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 8 );
			base.AddElementFieldMapping( "DulieuxnkEntity", "Diachicongtynhap", "Diachicongtynhap", true, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 9 );
			base.AddElementFieldMapping( "DulieuxnkEntity", "Hscode", "Hscode", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 10 );
			base.AddElementFieldMapping( "DulieuxnkEntity", "Motahanghoa", "Motahanghoa", true, (int)SqlDbType.NVarChar, 2147483647, 0, 0, false, "", null, typeof(System.String), 11 );
			base.AddElementFieldMapping( "DulieuxnkEntity", "Thuexuat", "Thuexuat", true, (int)SqlDbType.Decimal, 0, 2, 20, false, "", null, typeof(System.Decimal), 12 );
			base.AddElementFieldMapping( "DulieuxnkEntity", "Xuatxu", "Xuatxu", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 13 );
			base.AddElementFieldMapping( "DulieuxnkEntity", "Madonvi", "Madonvi", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 14 );
			base.AddElementFieldMapping( "DulieuxnkEntity", "Sotan", "Sotan", true, (int)SqlDbType.Decimal, 0, 2, 20, false, "", null, typeof(System.Decimal), 15 );
			base.AddElementFieldMapping( "DulieuxnkEntity", "Giausd", "Giausd", true, (int)SqlDbType.Decimal, 0, 2, 20, false, "", null, typeof(System.Decimal), 16 );
			base.AddElementFieldMapping( "DulieuxnkEntity", "Soluong", "Soluong", true, (int)SqlDbType.Decimal, 0, 2, 20, false, "", null, typeof(System.Decimal), 17 );
			base.AddElementFieldMapping( "DulieuxnkEntity", "Dongianguyente", "Dongianguyente", true, (int)SqlDbType.Decimal, 0, 2, 20, false, "", null, typeof(System.Decimal), 18 );
			base.AddElementFieldMapping( "DulieuxnkEntity", "Dongiausd", "Dongiausd", true, (int)SqlDbType.Decimal, 0, 2, 20, false, "", null, typeof(System.Decimal), 19 );
			base.AddElementFieldMapping( "DulieuxnkEntity", "Trigiausd", "Trigiausd", true, (int)SqlDbType.Decimal, 0, 2, 20, false, "", null, typeof(System.Decimal), 20 );
			base.AddElementFieldMapping( "DulieuxnkEntity", "Tygiavnd", "Tygiavnd", true, (int)SqlDbType.Decimal, 0, 2, 20, false, "", null, typeof(System.Decimal), 21 );
			base.AddElementFieldMapping( "DulieuxnkEntity", "Madongtien", "Madongtien", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 22 );
			base.AddElementFieldMapping( "DulieuxnkEntity", "Dieukiengia", "Dieukiengia", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 23 );
			base.AddElementFieldMapping( "DulieuxnkEntity", "Phuongthucthanhtoan", "Phuongthucthanhtoan", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 24 );
			base.AddElementFieldMapping( "DulieuxnkEntity", "Chicuchaiquan", "Chicuchaiquan", true, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 25 );
			base.AddElementFieldMapping( "DulieuxnkEntity", "Loaihinhxuatkhau", "Loaihinhxuatkhau", true, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 26 );
			base.AddElementFieldMapping( "DulieuxnkEntity", "Tennuocxuatkhau", "Tennuocxuatkhau", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 27 );
			base.AddElementFieldMapping( "DulieuxnkEntity", "Tennuocnhapkhau", "Tennuocnhapkhau", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 28 );
			base.AddElementFieldMapping( "DulieuxnkEntity", "Diadiemxephang", "Diadiemxephang", true, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 29 );
			base.AddElementFieldMapping( "DulieuxnkEntity", "Diadiemnhanhangcuoicung", "Diadiemnhanhangcuoicung", true, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 30 );
			base.AddElementFieldMapping( "DulieuxnkEntity", "Sotokhai", "Sotokhai", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 31 );
		}
		/// <summary>Inits FormcoEntity's mappings</summary>
		private void InitFormcoEntityMappings()
		{
			base.AddElementMapping( "FormcoEntity", "FM", @"dbo", "Formco", 7 );
			base.AddElementFieldMapping( "FormcoEntity", "Mahieu", "Mahieu", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 0 );
			base.AddElementFieldMapping( "FormcoEntity", "Tenhieu", "Tenhieu", true, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 1 );
			base.AddElementFieldMapping( "FormcoEntity", "Tenrutgon", "Tenrutgon", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 2 );
			base.AddElementFieldMapping( "FormcoEntity", "Ngaytao", "Ngaytao", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 3 );
			base.AddElementFieldMapping( "FormcoEntity", "Nguoitao", "Nguoitao", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 4 );
			base.AddElementFieldMapping( "FormcoEntity", "Ngaysua", "Ngaysua", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 5 );
			base.AddElementFieldMapping( "FormcoEntity", "Nguoisua", "Nguoisua", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 6 );
		}
		/// <summary>Inits HopdongbanhangEntity's mappings</summary>
		private void InitHopdongbanhangEntityMappings()
		{
			base.AddElementMapping( "HopdongbanhangEntity", "FM", @"dbo", "Hopdongbanhang", 12 );
			base.AddElementFieldMapping( "HopdongbanhangEntity", "Sohopdong", "Sohopdong", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 0 );
			base.AddElementFieldMapping( "HopdongbanhangEntity", "Ngayhopdong", "Ngayhopdong", true, (int)SqlDbType.Date, 0, 0, 0, false, "", null, typeof(System.DateTime), 1 );
			base.AddElementFieldMapping( "HopdongbanhangEntity", "Makhach", "Makhach", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 2 );
			base.AddElementFieldMapping( "HopdongbanhangEntity", "Tenkhach", "Tenkhach", true, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 3 );
			base.AddElementFieldMapping( "HopdongbanhangEntity", "Macangden", "Macangden", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 4 );
			base.AddElementFieldMapping( "HopdongbanhangEntity", "Tencangden", "Tencangden", true, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 5 );
			base.AddElementFieldMapping( "HopdongbanhangEntity", "Thanhtienvnd", "Thanhtienvnd", true, (int)SqlDbType.Decimal, 0, 2, 20, false, "", null, typeof(System.Decimal), 6 );
			base.AddElementFieldMapping( "HopdongbanhangEntity", "Thanhtienusd", "Thanhtienusd", true, (int)SqlDbType.Decimal, 0, 2, 20, false, "", null, typeof(System.Decimal), 7 );
			base.AddElementFieldMapping( "HopdongbanhangEntity", "Ngaytao", "Ngaytao", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 8 );
			base.AddElementFieldMapping( "HopdongbanhangEntity", "Nguoitao", "Nguoitao", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 9 );
			base.AddElementFieldMapping( "HopdongbanhangEntity", "Ngaysua", "Ngaysua", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 10 );
			base.AddElementFieldMapping( "HopdongbanhangEntity", "Nguoisua", "Nguoisua", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 11 );
		}
		/// <summary>Inits HopdongbanhangchitietEntity's mappings</summary>
		private void InitHopdongbanhangchitietEntityMappings()
		{
			base.AddElementMapping( "HopdongbanhangchitietEntity", "FM", @"dbo", "Hopdongbanhangchitiet", 20 );
			base.AddElementFieldMapping( "HopdongbanhangchitietEntity", "Id", "Id", false, (int)SqlDbType.BigInt, 0, 0, 19, true, "SCOPE_IDENTITY()", null, typeof(System.Int64), 0 );
			base.AddElementFieldMapping( "HopdongbanhangchitietEntity", "Sohopdong", "Sohopdong", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 1 );
			base.AddElementFieldMapping( "HopdongbanhangchitietEntity", "Ngayhopdong", "Ngayhopdong", true, (int)SqlDbType.Date, 0, 0, 0, false, "", null, typeof(System.DateTime), 2 );
			base.AddElementFieldMapping( "HopdongbanhangchitietEntity", "Makhach", "Makhach", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 3 );
			base.AddElementFieldMapping( "HopdongbanhangchitietEntity", "Tenkhach", "Tenkhach", true, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 4 );
			base.AddElementFieldMapping( "HopdongbanhangchitietEntity", "Macangden", "Macangden", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 5 );
			base.AddElementFieldMapping( "HopdongbanhangchitietEntity", "Tencangden", "Tencangden", true, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 6 );
			base.AddElementFieldMapping( "HopdongbanhangchitietEntity", "Mahangphiakhach", "Mahangphiakhach", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 7 );
			base.AddElementFieldMapping( "HopdongbanhangchitietEntity", "Codefiller", "Codefiller", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 8 );
			base.AddElementFieldMapping( "HopdongbanhangchitietEntity", "Soluong", "Soluong", true, (int)SqlDbType.Decimal, 0, 2, 20, false, "", null, typeof(System.Decimal), 9 );
			base.AddElementFieldMapping( "HopdongbanhangchitietEntity", "Dongiavnd", "Dongiavnd", true, (int)SqlDbType.Decimal, 0, 2, 20, false, "", null, typeof(System.Decimal), 10 );
			base.AddElementFieldMapping( "HopdongbanhangchitietEntity", "Tygia", "Tygia", true, (int)SqlDbType.Decimal, 0, 2, 20, false, "", null, typeof(System.Decimal), 11 );
			base.AddElementFieldMapping( "HopdongbanhangchitietEntity", "Dongiausd", "Dongiausd", true, (int)SqlDbType.Decimal, 0, 4, 20, false, "", null, typeof(System.Decimal), 12 );
			base.AddElementFieldMapping( "HopdongbanhangchitietEntity", "Thanhtienvnd", "Thanhtienvnd", true, (int)SqlDbType.Decimal, 0, 2, 20, false, "", null, typeof(System.Decimal), 13 );
			base.AddElementFieldMapping( "HopdongbanhangchitietEntity", "Thanhtienusd", "Thanhtienusd", true, (int)SqlDbType.Decimal, 0, 2, 20, false, "", null, typeof(System.Decimal), 14 );
			base.AddElementFieldMapping( "HopdongbanhangchitietEntity", "Ngaytao", "Ngaytao", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 15 );
			base.AddElementFieldMapping( "HopdongbanhangchitietEntity", "Nguoitao", "Nguoitao", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 16 );
			base.AddElementFieldMapping( "HopdongbanhangchitietEntity", "Ngaysua", "Ngaysua", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 17 );
			base.AddElementFieldMapping( "HopdongbanhangchitietEntity", "Nguoisua", "Nguoisua", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 18 );
			base.AddElementFieldMapping( "HopdongbanhangchitietEntity", "Ngaygiao", "Ngaygiao", true, (int)SqlDbType.Date, 0, 0, 0, false, "", null, typeof(System.DateTime), 19 );
		}
		/// <summary>Inits LogbackupEntity's mappings</summary>
		private void InitLogbackupEntityMappings()
		{
			base.AddElementMapping( "LogbackupEntity", "FM", @"dbo", "Logbackup", 4 );
			base.AddElementFieldMapping( "LogbackupEntity", "Mahieu", "Mahieu", false, (int)SqlDbType.BigInt, 0, 0, 19, true, "SCOPE_IDENTITY()", null, typeof(System.Int64), 0 );
			base.AddElementFieldMapping( "LogbackupEntity", "Nam", "Nam", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 1 );
			base.AddElementFieldMapping( "LogbackupEntity", "Duongdan", "Duongdan", true, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 2 );
			base.AddElementFieldMapping( "LogbackupEntity", "Ngay", "Ngay", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 3 );
		}
		/// <summary>Inits MenuEntity's mappings</summary>
		private void InitMenuEntityMappings()
		{
			base.AddElementMapping( "MenuEntity", "FM", @"dbo", "Menu", 11 );
			base.AddElementFieldMapping( "MenuEntity", "MenuId", "MenuId", false, (int)SqlDbType.NVarChar, 20, 0, 0, false, "", null, typeof(System.String), 0 );
			base.AddElementFieldMapping( "MenuEntity", "MenuName", "MenuName", true, (int)SqlDbType.NVarChar, 500, 0, 0, false, "", null, typeof(System.String), 1 );
			base.AddElementFieldMapping( "MenuEntity", "Icon", "Icon", true, (int)SqlDbType.NVarChar, 500, 0, 0, false, "", null, typeof(System.String), 2 );
			base.AddElementFieldMapping( "MenuEntity", "Issudung", "Issudung", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 3 );
			base.AddElementFieldMapping( "MenuEntity", "Istrangthai", "Istrangthai", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 4 );
			base.AddElementFieldMapping( "MenuEntity", "Menuparent", "Menuparent", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 5 );
			base.AddElementFieldMapping( "MenuEntity", "Thutu", "Thutu", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 6 );
			base.AddElementFieldMapping( "MenuEntity", "FormName", "FormName", true, (int)SqlDbType.NVarChar, 1000, 0, 0, false, "", null, typeof(System.String), 7 );
			base.AddElementFieldMapping( "MenuEntity", "LoaiMenu", "LoaiMenu", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 8 );
			base.AddElementFieldMapping( "MenuEntity", "Param", "Param", true, (int)SqlDbType.NVarChar, 500, 0, 0, false, "", null, typeof(System.String), 9 );
			base.AddElementFieldMapping( "MenuEntity", "Maphanhe", "Maphanhe", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 10 );
		}
		/// <summary>Inits MenuroleEntity's mappings</summary>
		private void InitMenuroleEntityMappings()
		{
			base.AddElementMapping( "MenuroleEntity", "FM", @"dbo", "Menurole", 2 );
			base.AddElementFieldMapping( "MenuroleEntity", "Menuid", "Menuid", false, (int)SqlDbType.NVarChar, 20, 0, 0, false, "", null, typeof(System.String), 0 );
			base.AddElementFieldMapping( "MenuroleEntity", "Rolesid", "Rolesid", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 1 );
		}
		/// <summary>Inits NhanvienEntity's mappings</summary>
		private void InitNhanvienEntityMappings()
		{
			base.AddElementMapping( "NhanvienEntity", "FM", @"dbo", "Nhanvien", 11 );
			base.AddElementFieldMapping( "NhanvienEntity", "Manhanvien", "Manhanvien", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 0 );
			base.AddElementFieldMapping( "NhanvienEntity", "Hoten", "Hoten", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 1 );
			base.AddElementFieldMapping( "NhanvienEntity", "Maphongban", "Maphongban", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 2 );
			base.AddElementFieldMapping( "NhanvienEntity", "Tenphongban", "Tenphongban", true, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 3 );
			base.AddElementFieldMapping( "NhanvienEntity", "Machucvu", "Machucvu", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 4 );
			base.AddElementFieldMapping( "NhanvienEntity", "Tenchucvu", "Tenchucvu", true, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 5 );
			base.AddElementFieldMapping( "NhanvienEntity", "Gioitinh", "Gioitinh", true, (int)SqlDbType.Bit, 0, 0, 0, false, "", null, typeof(System.Boolean), 6 );
			base.AddElementFieldMapping( "NhanvienEntity", "Ngaysinh", "Ngaysinh", true, (int)SqlDbType.Date, 0, 0, 0, false, "", null, typeof(System.DateTime), 7 );
			base.AddElementFieldMapping( "NhanvienEntity", "Diachi", "Diachi", true, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 8 );
			base.AddElementFieldMapping( "NhanvienEntity", "Sodienthoai", "Sodienthoai", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 9 );
			base.AddElementFieldMapping( "NhanvienEntity", "Email", "Email", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 10 );
		}
		/// <summary>Inits PhongbanEntity's mappings</summary>
		private void InitPhongbanEntityMappings()
		{
			base.AddElementMapping( "PhongbanEntity", "FM", @"dbo", "Phongban", 7 );
			base.AddElementFieldMapping( "PhongbanEntity", "Mahieu", "Mahieu", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 0 );
			base.AddElementFieldMapping( "PhongbanEntity", "Tenhieu", "Tenhieu", true, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 1 );
			base.AddElementFieldMapping( "PhongbanEntity", "Tenrutgon", "Tenrutgon", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 2 );
			base.AddElementFieldMapping( "PhongbanEntity", "Ngaytao", "Ngaytao", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 3 );
			base.AddElementFieldMapping( "PhongbanEntity", "Nguoitao", "Nguoitao", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 4 );
			base.AddElementFieldMapping( "PhongbanEntity", "Ngaysua", "Ngaysua", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 5 );
			base.AddElementFieldMapping( "PhongbanEntity", "Nguoisua", "Nguoisua", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 6 );
		}
		/// <summary>Inits PhuongthucthanhtoanEntity's mappings</summary>
		private void InitPhuongthucthanhtoanEntityMappings()
		{
			base.AddElementMapping( "PhuongthucthanhtoanEntity", "FM", @"dbo", "Phuongthucthanhtoan", 9 );
			base.AddElementFieldMapping( "PhuongthucthanhtoanEntity", "Mahieu", "Mahieu", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 0 );
			base.AddElementFieldMapping( "PhuongthucthanhtoanEntity", "Tenhieu", "Tenhieu", true, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 1 );
			base.AddElementFieldMapping( "PhuongthucthanhtoanEntity", "Tenrutgon", "Tenrutgon", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 2 );
			base.AddElementFieldMapping( "PhuongthucthanhtoanEntity", "Deposit", "Deposit", true, (int)SqlDbType.Decimal, 0, 2, 20, false, "", null, typeof(System.Decimal), 3 );
			base.AddElementFieldMapping( "PhuongthucthanhtoanEntity", "Pay", "Pay", true, (int)SqlDbType.Decimal, 0, 2, 20, false, "", null, typeof(System.Decimal), 4 );
			base.AddElementFieldMapping( "PhuongthucthanhtoanEntity", "Ngaytao", "Ngaytao", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 5 );
			base.AddElementFieldMapping( "PhuongthucthanhtoanEntity", "Nguoitao", "Nguoitao", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 6 );
			base.AddElementFieldMapping( "PhuongthucthanhtoanEntity", "Ngaysua", "Ngaysua", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 7 );
			base.AddElementFieldMapping( "PhuongthucthanhtoanEntity", "Nguoisua", "Nguoisua", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 8 );
		}
		/// <summary>Inits PhuongthucvanchuyenEntity's mappings</summary>
		private void InitPhuongthucvanchuyenEntityMappings()
		{
			base.AddElementMapping( "PhuongthucvanchuyenEntity", "FM", @"dbo", "Phuongthucvanchuyen", 7 );
			base.AddElementFieldMapping( "PhuongthucvanchuyenEntity", "Mahieu", "Mahieu", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 0 );
			base.AddElementFieldMapping( "PhuongthucvanchuyenEntity", "Tenhieu", "Tenhieu", true, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 1 );
			base.AddElementFieldMapping( "PhuongthucvanchuyenEntity", "Tenrutgon", "Tenrutgon", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 2 );
			base.AddElementFieldMapping( "PhuongthucvanchuyenEntity", "Ngaytao", "Ngaytao", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 3 );
			base.AddElementFieldMapping( "PhuongthucvanchuyenEntity", "Nguoitao", "Nguoitao", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 4 );
			base.AddElementFieldMapping( "PhuongthucvanchuyenEntity", "Ngaysua", "Ngaysua", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 5 );
			base.AddElementFieldMapping( "PhuongthucvanchuyenEntity", "Nguoisua", "Nguoisua", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 6 );
		}
		/// <summary>Inits RolesEntity's mappings</summary>
		private void InitRolesEntityMappings()
		{
			base.AddElementMapping( "RolesEntity", "FM", @"dbo", "Roles", 3 );
			base.AddElementFieldMapping( "RolesEntity", "Rolesid", "Rolesid", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 0 );
			base.AddElementFieldMapping( "RolesEntity", "Rolesname", "Rolesname", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 1 );
			base.AddElementFieldMapping( "RolesEntity", "Description", "Description", true, (int)SqlDbType.NVarChar, 200, 0, 0, false, "", null, typeof(System.String), 2 );
		}
		/// <summary>Inits TygiaEntity's mappings</summary>
		private void InitTygiaEntityMappings()
		{
			base.AddElementMapping( "TygiaEntity", "FM", @"dbo", "Tygia", 6 );
			base.AddElementFieldMapping( "TygiaEntity", "Thang", "Thang", false, (int)SqlDbType.NVarChar, 20, 0, 0, false, "", null, typeof(System.String), 0 );
			base.AddElementFieldMapping( "TygiaEntity", "Tygia", "Tygia", true, (int)SqlDbType.Decimal, 0, 2, 20, false, "", null, typeof(System.Decimal), 1 );
			base.AddElementFieldMapping( "TygiaEntity", "Ngaytao", "Ngaytao", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 2 );
			base.AddElementFieldMapping( "TygiaEntity", "Nguoitao", "Nguoitao", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 3 );
			base.AddElementFieldMapping( "TygiaEntity", "Ngaysua", "Ngaysua", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 4 );
			base.AddElementFieldMapping( "TygiaEntity", "Nguoisua", "Nguoisua", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 5 );
		}
		/// <summary>Inits ThamsoEntity's mappings</summary>
		private void InitThamsoEntityMappings()
		{
			base.AddElementMapping( "ThamsoEntity", "FM", @"dbo", "Thamso", 9 );
			base.AddElementFieldMapping( "ThamsoEntity", "Mahieu", "Mahieu", false, (int)SqlDbType.NVarChar, 20, 0, 0, false, "", null, typeof(System.String), 0 );
			base.AddElementFieldMapping( "ThamsoEntity", "Stt", "Stt", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 1 );
			base.AddElementFieldMapping( "ThamsoEntity", "Tenthamso", "Tenthamso", false, (int)SqlDbType.NVarChar, 200, 0, 0, false, "", null, typeof(System.String), 2 );
			base.AddElementFieldMapping( "ThamsoEntity", "Giatri", "Giatri", true, (int)SqlDbType.NVarChar, 200, 0, 0, false, "", null, typeof(System.String), 3 );
			base.AddElementFieldMapping( "ThamsoEntity", "Thaydoi", "Thaydoi", false, (int)SqlDbType.Bit, 0, 0, 0, false, "", null, typeof(System.Boolean), 4 );
			base.AddElementFieldMapping( "ThamsoEntity", "Kieudulieu", "Kieudulieu", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 5 );
			base.AddElementFieldMapping( "ThamsoEntity", "Ghichu", "Ghichu", true, (int)SqlDbType.NVarChar, 200, 0, 0, false, "", null, typeof(System.String), 6 );
			base.AddElementFieldMapping( "ThamsoEntity", "Loaithamso", "Loaithamso", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 7 );
			base.AddElementFieldMapping( "ThamsoEntity", "An", "An", true, (int)SqlDbType.Bit, 0, 0, 0, false, "", null, typeof(System.Boolean), 8 );
		}
		/// <summary>Inits ThuchienlogisticEntity's mappings</summary>
		private void InitThuchienlogisticEntityMappings()
		{
			base.AddElementMapping( "ThuchienlogisticEntity", "FM", @"dbo", "Thuchienlogistic", 16 );
			base.AddElementFieldMapping( "ThuchienlogisticEntity", "Id", "Id", false, (int)SqlDbType.BigInt, 0, 0, 19, true, "SCOPE_IDENTITY()", null, typeof(System.Int64), 0 );
			base.AddElementFieldMapping( "ThuchienlogisticEntity", "Sohopdong", "Sohopdong", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 1 );
			base.AddElementFieldMapping( "ThuchienlogisticEntity", "Ngayhopdong", "Ngayhopdong", true, (int)SqlDbType.Date, 0, 0, 0, false, "", null, typeof(System.DateTime), 2 );
			base.AddElementFieldMapping( "ThuchienlogisticEntity", "Makhach", "Makhach", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 3 );
			base.AddElementFieldMapping( "ThuchienlogisticEntity", "Tenkhach", "Tenkhach", true, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 4 );
			base.AddElementFieldMapping( "ThuchienlogisticEntity", "Mahangphiakhach", "Mahangphiakhach", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 5 );
			base.AddElementFieldMapping( "ThuchienlogisticEntity", "Codefiller", "Codefiller", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 6 );
			base.AddElementFieldMapping( "ThuchienlogisticEntity", "Soluonggiao", "Soluonggiao", true, (int)SqlDbType.Decimal, 0, 2, 20, false, "", null, typeof(System.Decimal), 7 );
			base.AddElementFieldMapping( "ThuchienlogisticEntity", "Ngaygiao", "Ngaygiao", true, (int)SqlDbType.Date, 0, 0, 0, false, "", null, typeof(System.DateTime), 8 );
			base.AddElementFieldMapping( "ThuchienlogisticEntity", "Buoclogistic", "Buoclogistic", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 9 );
			base.AddElementFieldMapping( "ThuchienlogisticEntity", "Tenbuoclogistic", "Tenbuoclogistic", true, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 10 );
			base.AddElementFieldMapping( "ThuchienlogisticEntity", "Ngaythuchien", "Ngaythuchien", true, (int)SqlDbType.Date, 0, 0, 0, false, "", null, typeof(System.DateTime), 11 );
			base.AddElementFieldMapping( "ThuchienlogisticEntity", "Ngaytao", "Ngaytao", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 12 );
			base.AddElementFieldMapping( "ThuchienlogisticEntity", "Nguoitao", "Nguoitao", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 13 );
			base.AddElementFieldMapping( "ThuchienlogisticEntity", "Ngaysua", "Ngaysua", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 14 );
			base.AddElementFieldMapping( "ThuchienlogisticEntity", "Nguoisua", "Nguoisua", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 15 );
		}
		/// <summary>Inits ThuchienhopdongbanhangEntity's mappings</summary>
		private void InitThuchienhopdongbanhangEntityMappings()
		{
			base.AddElementMapping( "ThuchienhopdongbanhangEntity", "FM", @"dbo", "Thuchienhopdongbanhang", 20 );
			base.AddElementFieldMapping( "ThuchienhopdongbanhangEntity", "Id", "Id", false, (int)SqlDbType.BigInt, 0, 0, 19, true, "SCOPE_IDENTITY()", null, typeof(System.Int64), 0 );
			base.AddElementFieldMapping( "ThuchienhopdongbanhangEntity", "Sohopdong", "Sohopdong", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 1 );
			base.AddElementFieldMapping( "ThuchienhopdongbanhangEntity", "Ngayhopdong", "Ngayhopdong", true, (int)SqlDbType.Date, 0, 0, 0, false, "", null, typeof(System.DateTime), 2 );
			base.AddElementFieldMapping( "ThuchienhopdongbanhangEntity", "Makhach", "Makhach", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 3 );
			base.AddElementFieldMapping( "ThuchienhopdongbanhangEntity", "Tenkhach", "Tenkhach", true, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 4 );
			base.AddElementFieldMapping( "ThuchienhopdongbanhangEntity", "Mahangphiakhach", "Mahangphiakhach", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 5 );
			base.AddElementFieldMapping( "ThuchienhopdongbanhangEntity", "Codefiller", "Codefiller", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 6 );
			base.AddElementFieldMapping( "ThuchienhopdongbanhangEntity", "Soluonggiao", "Soluonggiao", true, (int)SqlDbType.Decimal, 0, 2, 20, false, "", null, typeof(System.Decimal), 7 );
			base.AddElementFieldMapping( "ThuchienhopdongbanhangEntity", "Ngaygiao", "Ngaygiao", true, (int)SqlDbType.Date, 0, 0, 0, false, "", null, typeof(System.DateTime), 8 );
			base.AddElementFieldMapping( "ThuchienhopdongbanhangEntity", "Dongiavnd", "Dongiavnd", true, (int)SqlDbType.Decimal, 0, 2, 20, false, "", null, typeof(System.Decimal), 9 );
			base.AddElementFieldMapping( "ThuchienhopdongbanhangEntity", "Tygia", "Tygia", true, (int)SqlDbType.Decimal, 0, 2, 20, false, "", null, typeof(System.Decimal), 10 );
			base.AddElementFieldMapping( "ThuchienhopdongbanhangEntity", "Dongiausd", "Dongiausd", true, (int)SqlDbType.Decimal, 0, 4, 20, false, "", null, typeof(System.Decimal), 11 );
			base.AddElementFieldMapping( "ThuchienhopdongbanhangEntity", "Thanhtienvnd", "Thanhtienvnd", true, (int)SqlDbType.Decimal, 0, 2, 20, false, "", null, typeof(System.Decimal), 12 );
			base.AddElementFieldMapping( "ThuchienhopdongbanhangEntity", "Thanhtienusd", "Thanhtienusd", true, (int)SqlDbType.Decimal, 0, 2, 20, false, "", null, typeof(System.Decimal), 13 );
			base.AddElementFieldMapping( "ThuchienhopdongbanhangEntity", "Ngaytao", "Ngaytao", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 14 );
			base.AddElementFieldMapping( "ThuchienhopdongbanhangEntity", "Nguoitao", "Nguoitao", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 15 );
			base.AddElementFieldMapping( "ThuchienhopdongbanhangEntity", "Ngaysua", "Ngaysua", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 16 );
			base.AddElementFieldMapping( "ThuchienhopdongbanhangEntity", "Nguoisua", "Nguoisua", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 17 );
			base.AddElementFieldMapping( "ThuchienhopdongbanhangEntity", "Thanhtoanvnd", "Thanhtoanvnd", true, (int)SqlDbType.Decimal, 0, 2, 20, false, "", null, typeof(System.Decimal), 18 );
			base.AddElementFieldMapping( "ThuchienhopdongbanhangEntity", "Thanhtoanusd", "Thanhtoanusd", true, (int)SqlDbType.Decimal, 0, 2, 20, false, "", null, typeof(System.Decimal), 19 );
		}
		/// <summary>Inits UsersEntity's mappings</summary>
		private void InitUsersEntityMappings()
		{
			base.AddElementMapping( "UsersEntity", "FM", @"dbo", "Users", 8 );
			base.AddElementFieldMapping( "UsersEntity", "Userid", "Userid", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 0 );
			base.AddElementFieldMapping( "UsersEntity", "Rolesid", "Rolesid", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 1 );
			base.AddElementFieldMapping( "UsersEntity", "Username", "Username", false, (int)SqlDbType.NVarChar, 150, 0, 0, false, "", null, typeof(System.String), 2 );
			base.AddElementFieldMapping( "UsersEntity", "Fullname", "Fullname", true, (int)SqlDbType.NVarChar, 500, 0, 0, false, "", null, typeof(System.String), 3 );
			base.AddElementFieldMapping( "UsersEntity", "Phone", "Phone", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 4 );
			base.AddElementFieldMapping( "UsersEntity", "Address", "Address", true, (int)SqlDbType.NVarChar, 500, 0, 0, false, "", null, typeof(System.String), 5 );
			base.AddElementFieldMapping( "UsersEntity", "Password", "Password", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 6 );
			base.AddElementFieldMapping( "UsersEntity", "Active", "Active", true, (int)SqlDbType.Bit, 0, 0, 0, false, "", null, typeof(System.Boolean), 7 );
		}

	}
}













