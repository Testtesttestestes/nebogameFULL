using System;
using System.Runtime.CompilerServices;
using Core.Dict.DictWrappers.Storages;
using Il2CppDummyDll;

namespace Core.Dict.DictWrappers.Base
{
	// Token: 0x020010A2 RID: 4258
	[Token(Token = "0x20010A2")]
	public class DictWrappersStorage : IDisposable
	{
		// Token: 0x170013B6 RID: 5046
		// (get) Token: 0x060062F1 RID: 25329 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060062F2 RID: 25330 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170013B6")]
		public ArtikulDicWrapperStorage ArtikulDicStorage
		{
			[Token(Token = "0x60062F1")]
			[Address(RVA = "0xAF01", Offset = "0xAF01", VA = "0xAF01")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60062F2")]
			[Address(RVA = "0xAF02", Offset = "0xAF02", VA = "0xAF02")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170013B7 RID: 5047
		// (get) Token: 0x060062F3 RID: 25331 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060062F4 RID: 25332 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170013B7")]
		public MedalsDicWrapperStorage MedalsDicStorage
		{
			[Token(Token = "0x60062F3")]
			[Address(RVA = "0xAF03", Offset = "0xAF03", VA = "0xAF03")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60062F4")]
			[Address(RVA = "0xAF04", Offset = "0xAF04", VA = "0xAF04")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170013B8 RID: 5048
		// (get) Token: 0x060062F5 RID: 25333 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060062F6 RID: 25334 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170013B8")]
		public UserBuildingLevelDicWrapperStorage UserBuildingLevelsDicStorage
		{
			[Token(Token = "0x60062F5")]
			[Address(RVA = "0xAF05", Offset = "0xAF05", VA = "0xAF05")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60062F6")]
			[Address(RVA = "0xAF06", Offset = "0xAF06", VA = "0xAF06")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170013B9 RID: 5049
		// (get) Token: 0x060062F7 RID: 25335 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060062F8 RID: 25336 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170013B9")]
		public AprDicWrapperStorage AprDicStorage
		{
			[Token(Token = "0x60062F7")]
			[Address(RVA = "0xAF07", Offset = "0xAF07", VA = "0xAF07")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60062F8")]
			[Address(RVA = "0xAF08", Offset = "0xAF08", VA = "0xAF08")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060062F9 RID: 25337 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60062F9")]
		[Address(RVA = "0xAF09", Offset = "0xAF09", VA = "0xAF09")]
		public DictWrappersStorage(IDictProvider provider)
		{
		/* --- GHIDRA: .ctor ---
		void Core_Dict_DictWrappers_Base_DictWrappersStorage___ctor(int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a60750 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Dict_DictWrappers_Base_AbstractDictWrapperStorage_MedalDicWrapper__uint__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Dict_DictWrappers_Base_AbstractDictWrapperStorage_UserBuildingLevelDicWrapper__UserBuildingLevelDicWrapper_UserBuildingLevelDicWrapperId__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Dict_DictWrappers_Base_AbstractDictWrapperStorage_ArtikulDicWrapper__uint__Dispose__
		              );
		    DAT_ram_00a60750 = '\x01';
		  }
		  if (*(int *)(param1 + 8) != 0) {
		    Core_Dict_DictWrappers_Base_AbstractDictWrapperStorage_object__uint___DictProviderOnChangedEvent
		              (*(int *)(param1 + 8),
		               Method_Core_Dict_DictWrappers_Base_AbstractDictWrapperStorage_ArtikulDicWrapper__uint__Dispose__
		              );
		  }
		  if (*(int *)(param1 + 0xc) != 0) {
		    Core_Dict_DictWrappers_Base_AbstractDictWrapperStorage_object__uint___DictProviderOnChangedEvent
		              (*(int *)(param1 + 0xc),
		               Method_Core_Dict_DictWrappers_Base_AbstractDictWrapperStorage_MedalDicWrapper__uint__Dispose__
		              );
		  }
		  if (*(int *)(param1 + 0x10) != 0) {
		    Core_Dict_DictWrappers_Base_AbstractDictWrapperStorage_object__object___DictProviderOnChangedEvent
		              (*(int *)(param1 + 0x10),
		               Method_Core_Dict_DictWrappers_Base_AbstractDictWrapperStorage_UserBuildingLevelDicWrapper__UserBuildingLevelDicWrapper_UserBuildingLevelDicWrapperId__Dispose__
		              );
		  }
		  *(undefined4 *)(param1 + 0x10) = 0;
		  *(undefined8 *)(param1 + 8) = 0;
		  return;
		}
		*/

		}

		// Token: 0x060062FA RID: 25338 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60062FA")]
		[Address(RVA = "0xAF0A", Offset = "0xAF0A", VA = "0xAF0A", Slot = "4")]
		public void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Core_Dict_DictWrappers_Base_DictWrappersStorage__Dispose(int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a60751 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_MVC_AbstractController_DictModel__DictEvents__Dispose__);
		    DAT_ram_00a60751 = '\x01';
		  }
		  MVC_AbstractController_object__object____ctor
		            (param1,Method_MVC_AbstractController_DictModel__DictEvents__Dispose__);
		  *(undefined1 *)(param1 + 0x18) = 1;
		  return;
		}
		*/

		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_AprDicStorage ---
		void Core_Dict_DictWrappers_Base_DictWrappersStorage__set_AprDicStorage
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a6074f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Dict_DictWrappers_Storages_AprDicWrapperStorage_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Dict_DictWrappers_Storages_ArtikulDicWrapperStorage_TypeInfo)
		    ;
		    Mono_Security_ASN1__get_Item(&Core_Dict_DictWrappers_Storages_MedalsDicWrapperStorage_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Core_Dict_DictWrappers_Storages_UserBuildingLevelDicWrapperStorage_TypeInfo);
		    DAT_ram_00a6074f = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Core_Dict_DictWrappers_Storages_ArtikulDicWrapperStorage_TypeInfo);
		  if (DAT_ram_00a6074c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Dict_DictWrappers_Base_AbstractDictWrapperStorage_ArtikulDicWrapper__uint___ctor__
		              );
		    DAT_ram_00a6074c = '\x01';
		  }
		  Core_Dict_DictWrappers_Base_AbstractDictWrapperStorage_object__object___UpdateWrappers
		            (uVar1,param2,
		             Method_Core_Dict_DictWrappers_Base_AbstractDictWrapperStorage_ArtikulDicWrapper__uint___ctor__
		            );
		  *(undefined4 *)(param1 + 8) = uVar1;
		  uVar1 = unnamed_function_1417(Core_Dict_DictWrappers_Storages_MedalsDicWrapperStorage_TypeInfo);
		  if (DAT_ram_00a6074d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Dict_DictWrappers_Base_AbstractDictWrapperStorage_MedalDicWrapper__uint___ctor__
		              );
		    DAT_ram_00a6074d = '\x01';
		  }
		  Core_Dict_DictWrappers_Base_AbstractDictWrapperStorage_object__object___UpdateWrappers
		            (uVar1,param2,
		             Method_Core_Dict_DictWrappers_Base_AbstractDictWrapperStorage_MedalDicWrapper__uint___ctor__
		            );
		  *(undefined4 *)(param1 + 0xc) = uVar1;
		  uVar1 = unnamed_function_1417
		                    (Core_Dict_DictWrappers_Storages_UserBuildingLevelDicWrapperStorage_TypeInfo);
		  if (DAT_ram_00a6074e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Dict_DictWrappers_Base_AbstractDictWrapperStorage_UserBuildingLevelDicWrapper__UserBuildingLevelDicWrapper_UserBuildingLevelDicWrapperId___ctor__
		              );
		    DAT_ram_00a6074e = '\x01';
		  }
		  UI_AbstractDataRenderer___Il2CppFullySharedGenericType___set_Data
		            (uVar1,param2,
		             Method_Core_Dict_DictWrappers_Base_AbstractDictWrapperStorage_UserBuildingLevelDicWrapper__UserBuildingLevelDicWrapper_UserBuildingLevelDicWrapperId___ctor__
		            );
		  *(undefined4 *)(param1 + 0x10) = uVar1;
		  uVar1 = unnamed_function_1417(Core_Dict_DictWrappers_Storages_AprDicWrapperStorage_TypeInfo);
		  if (DAT_ram_00a6074b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Dict_DictWrappers_Base_AbstractDictWrapperStorage_AprDicWrapper__uint___ctor__
		              );
		    DAT_ram_00a6074b = '\x01';
		  }
		  Core_Dict_DictWrappers_Base_AbstractDictWrapperStorage_object__object___UpdateWrappers
		            (uVar1,param2,
		             Method_Core_Dict_DictWrappers_Base_AbstractDictWrapperStorage_AprDicWrapper__uint___ctor__
		            );
		  *(undefined4 *)(param1 + 0x14) = uVar1;
		  return;
		}
		*/

}
