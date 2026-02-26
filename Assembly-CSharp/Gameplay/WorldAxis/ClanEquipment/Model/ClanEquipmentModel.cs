using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Core.Cache;
using Core.Data;
using Core.Gameplay.Managers;
using Gameplay.WorldAxis.Model;
using Il2CppDummyDll;
using MVC;
using Protocol.Colossus;
using Protocol.Common;
using Protocol.Dic;
using UI.Elements.Filters.GenericFilter;

namespace Gameplay.WorldAxis.ClanEquipment.Model
{
	// Token: 0x0200034A RID: 842
	[Token(Token = "0x200034A")]
	public class ClanEquipmentModel : AbstractModel
	{
		// Token: 0x17000307 RID: 775
		// (get) Token: 0x0600134B RID: 4939 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000307")]
		public Dictionaries Dict
		{
			[Token(Token = "0x600134B")]
			[Address(RVA = "0x653C", Offset = "0x653C", VA = "0x653C")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000308 RID: 776
		// (get) Token: 0x0600134C RID: 4940 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600134D RID: 4941 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000308")]
		public ClanEquipmentModel.DollsOwner[] DollOwners
		{
			[Token(Token = "0x600134C")]
			[Address(RVA = "0x653D", Offset = "0x653D", VA = "0x653D")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600134D")]
			[Address(RVA = "0x653E", Offset = "0x653E", VA = "0x653E")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600134E RID: 4942 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600134E")]
		[Address(RVA = "0x653F", Offset = "0x653F", VA = "0x653F")]
		public ClanEquipmentModel(UserData user, UserData golemUserData, [Optional] ulong? selectedUser)
		{
		/* --- GHIDRA: <CreateFilters>g__ConstructData|17_0 ---
		undefined4
		Gameplay_WorldAxis_ClanEquipment_Model_ClanEquipmentModel___CreateFilters_g__ConstructData_17_0
		          (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 *puVar2;
		  int param1_00;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a58c3e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ulong__ClanEquipmentModel_DollArtifacts__get_Values__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_SelectMany_ClanEquipmentModel_DollArtifacts__ArtifactData___
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToArray_ArtifactData___);
		    Mono_Security_ASN1__get_Item
		              (&System_Func_ClanEquipmentModel_DollArtifacts__IEnumerable_ArtifactData___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_ClanEquipment_Model_ClanEquipmentModel_DollsOwner___c__get_AllArtifacts_b__3_0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_WorldAxis_ClanEquipment_Model_ClanEquipmentModel_DollsOwner___c_TypeInfo);
		    DAT_ram_00a58c3e = '\x01';
		  }
		  uVar1 = System_Collections_Generic_Dictionary_int__object___TryAdd
		                    (*(undefined4 *)(param1 + 0xc),
		                     Method_System_Collections_Generic_Dictionary_ulong__ClanEquipmentModel_DollArtifacts__get_Values__
		                    );
		  if (*(int *)(Gameplay_WorldAxis_ClanEquipment_Model_ClanEquipmentModel_DollsOwner___c_TypeInfo +
		              0x74) == 0) {
		    func_ii_306000(Gameplay_WorldAxis_ClanEquipment_Model_ClanEquipmentModel_DollsOwner___c_TypeInfo
		                  );
		  }
		  puVar2 = *(undefined4 **)
		            (Gameplay_WorldAxis_ClanEquipment_Model_ClanEquipmentModel_DollsOwner___c_TypeInfo +
		            0x5c);
		  param1_00 = puVar2[1];
		  if (param1_00 == 0) {
		    if (*(int *)(Gameplay_WorldAxis_ClanEquipment_Model_ClanEquipmentModel_DollsOwner___c_TypeInfo +
		                0x74) == 0) {
		      func_ii_306000(
		                    Gameplay_WorldAxis_ClanEquipment_Model_ClanEquipmentModel_DollsOwner___c_TypeInfo
		                    );
		      puVar2 = *(undefined4 **)
		                (Gameplay_WorldAxis_ClanEquipment_Model_ClanEquipmentModel_DollsOwner___c_TypeInfo +
		                0x5c);
		    }
		    param2_00 = *puVar2;
		    param1_00 = unnamed_function_1417
		                          (
		                          System_Func_ClanEquipmentModel_DollArtifacts__IEnumerable_ArtifactData___TypeInfo
		                          );
		    System_Linq_Enumerable__Where_object_
		              (param1_00,param2_00,
		               Method_Gameplay_WorldAxis_ClanEquipment_Model_ClanEquipmentModel_DollsOwner___c__get_AllArtifacts_b__3_0__
		               ,0);
		    *(int *)(*(int *)(
		                     Gameplay_WorldAxis_ClanEquipment_Model_ClanEquipmentModel_DollsOwner___c_TypeInfo
		                     + 0x5c) + 4) = param1_00;
		  }
		  uVar1 = System_Linq_Enumerable__SelectMany_ValueTuple_object__object___object_
		                    (uVar1,param1_00,
		                     Method_System_Linq_Enumerable_SelectMany_ClanEquipmentModel_DollArtifacts__ArtifactData___
		                    );
		  uVar1 = func_ii_6295(uVar1,Method_System_Linq_Enumerable_ToArray_ArtifactData___);
		  return uVar1;
		}
		*/

		/* --- GHIDRA: .ctor ---
		int Gameplay_WorldAxis_ClanEquipment_Model_ClanEquipmentModel___ctor(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param1 + 0x30);
		  if (iVar1 == 0) {
		    iVar1 = Gameplay_WorldAxis_ClanEquipment_Model_ClanEquipmentModel__PopulateUsers(param1,param1);
		    *(int *)(param1 + 0x30) = iVar1;
		  }
		  return iVar1;
		}
		*/

		}

		// Token: 0x17000309 RID: 777
		// (get) Token: 0x0600134F RID: 4943 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000309")]
		public FilterWithIconListElement.FilterWithIconData[] FiltersData
		{
			[Token(Token = "0x600134F")]
			[Address(RVA = "0x6540", Offset = "0x6540", VA = "0x6540")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001350 RID: 4944 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001350")]
		[Address(RVA = "0x6541", Offset = "0x6541", VA = "0x6541")]
		public void PopulateUsers(IList<ProtoGetDollArtsAns.Types.DollsOwner> dollsOwners, UserData[] data)
		{
		/* --- GHIDRA: PopulateUsers ---
		undefined4
		Gameplay_WorldAxis_ClanEquipment_Model_ClanEquipmentModel__PopulateUsers
		          (undefined4 param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *param1_00;
		  int iVar4;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a58c3c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_ClanEquipment_Model_ClanEquipmentModel__CreateFilters_g__ConstructData_17_0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_Select_DollsInfoDic__FilterWithIconListElement_FilterWithIconData___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_ToArray_FilterWithIconListElement_FilterWithIconData___
		              );
		    Mono_Security_ASN1__get_Item
		              (&System_Func_DollsInfoDic__FilterWithIconListElement_FilterWithIconData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a58c3c = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 600);
		        goto code_r0x80f8e253;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x33);
		code_r0x80f8e253:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  param1_01 = *(undefined4 *)(*(int *)(iVar4 + 0x14) + 0x28);
		  uVar3 = unnamed_function_1417
		                    (
		                    System_Func_DollsInfoDic__FilterWithIconListElement_FilterWithIconData__TypeInfo
		                    );
		  System_Linq_Enumerable__Where_object_
		            (uVar3,0,
		             Method_Gameplay_WorldAxis_ClanEquipment_Model_ClanEquipmentModel__CreateFilters_g__ConstructData_17_0__
		             ,0);
		  uVar3 = System_Linq_Enumerable__ReverseIterator___Il2CppFullySharedGenericType_
		                    (param1_01,uVar3,
		                     Method_System_Linq_Enumerable_Select_DollsInfoDic__FilterWithIconListElement_FilterWithIconData___
		                    );
		  uVar3 = func_ii_6295(uVar3,
		                       Method_System_Linq_Enumerable_ToArray_FilterWithIconListElement_FilterWithIconData___
		                      );
		  return uVar3;
		}
		*/

		}

		// Token: 0x06001351 RID: 4945 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001351")]
		[Address(RVA = "0x6542", Offset = "0x6542", VA = "0x6542")]
		private FilterWithIconListElement.FilterWithIconData[] CreateFilters()
		{
		/* --- GHIDRA: CreateFilters ---
		int Gameplay_WorldAxis_ClanEquipment_Model_ClanEquipmentModel__CreateFilters
		              (undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a58c3d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Elements_Filters_GenericFilter_FilterWithIconListElement_FilterWithIconData_TypeInfo
		              );
		    DAT_ram_00a58c3d = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (
		                    UI_Elements_Filters_GenericFilter_FilterWithIconListElement_FilterWithIconData_TypeInfo
		                    );
		  *(undefined4 *)(iVar1 + 0xc) = param1;
		  uVar2 = Core_Extensions_Dict_DiscountsDicExt__GetDiscountDescription(param1,0);
		  *(undefined4 *)(iVar1 + 8) = uVar2;
		  uVar2 = Core_Extensions_Dict_DollInfoDicExt__GetTraitsColumn(param1,0);
		  *(undefined4 *)(iVar1 + 0x10) = uVar2;
		  return iVar1;
		}
		*/

			return null;
		}

		// Token: 0x06001352 RID: 4946 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001352")]
		[Address(RVA = "0x6543", Offset = "0x6543", VA = "0x6543")]
		[CompilerGenerated]
		internal static FilterWithIconListElement.FilterWithIconData <CreateFilters>g__ConstructData|17_0(DollsInfoDic dic)
		{
			return null;
		}

		// Token: 0x04000A57 RID: 2647
		[Token(Token = "0x4000A57")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private DictManager _dictManager;

		// Token: 0x04000A58 RID: 2648
		[Token(Token = "0x4000A58")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly WorldAxisModel WorldAxisModel;

		// Token: 0x04000A59 RID: 2649
		[Token(Token = "0x4000A59")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public readonly Dictionary<ulong, DollsInfoDic> DollsInfoDicsById;

		// Token: 0x04000A5A RID: 2650
		[Token(Token = "0x4000A5A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly ArtifactCache ArtifactCache;

		// Token: 0x04000A5B RID: 2651
		[Token(Token = "0x4000A5B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public readonly UserData GolemUserData;

		// Token: 0x04000A5C RID: 2652
		[Token(Token = "0x4000A5C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public readonly ulong? SelectedUser;

		// Token: 0x04000A5D RID: 2653
		[Token(Token = "0x4000A5D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private FilterWithIconListElement.FilterWithIconData[] _filtersData;

		// Token: 0x0200034B RID: 843
		[Token(Token = "0x200034B")]
		public class DollsOwner
		{
			// Token: 0x1700030A RID: 778
			// (get) Token: 0x06001353 RID: 4947 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x1700030A")]
			public ArtifactData[] AllArtifacts
			{
				[Token(Token = "0x6001353")]
				[Address(RVA = "0x6544", Offset = "0x6544", VA = "0x6544")]
				get
				{
					return null;
				}
			}

			// Token: 0x06001354 RID: 4948 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001354")]
			[Address(RVA = "0x6545", Offset = "0x6545", VA = "0x6545")]
			public DollsOwner(UserData userData)
			{
			}

			// Token: 0x04000A5F RID: 2655
			[Token(Token = "0x4000A5F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public readonly UserData UserData;

			// Token: 0x04000A60 RID: 2656
			[Token(Token = "0x4000A60")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Dictionary<ulong, ClanEquipmentModel.DollArtifacts> DollArtifactsByDollId;
		}

		// Token: 0x0200034D RID: 845
		[Token(Token = "0x200034D")]
		public class DollArtifacts
		{
			// Token: 0x06001358 RID: 4952 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001358")]
			[Address(RVA = "0x1DE8", Offset = "0x1DE8", VA = "0x1DE8")]
			public DollArtifacts(ulong dollId, IList<ArtifactInfo> artifacts, Dictionary<ulong, DollsInfoDic> dollsInfoDicsById, ArtifactCache artifactCache, UserData owner)
			{
			}

			// Token: 0x04000A63 RID: 2659
			[Token(Token = "0x4000A63")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public readonly DollsInfoDic Dic;

			// Token: 0x04000A64 RID: 2660
			[Token(Token = "0x4000A64")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public ArtifactData[] Artifacts;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_DollOwners ---
		void Gameplay_WorldAxis_ClanEquipment_Model_ClanEquipmentModel__set_DollOwners
		               (int param1,undefined4 param2,undefined4 param3,undefined8 *param4,undefined4 param5)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  int iVar5;
		  undefined4 *puVar6;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a58c3a == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToDictionary_DollsInfoDic__ulong___)
		    ;
		    Mono_Security_ASN1__get_Item(&System_Func_DollsInfoDic__ulong__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_ClanEquipment_Model_ClanEquipmentModel___c___ctor_b__13_0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_WorldAxis_ClanEquipment_Model_ClanEquipmentModel___c_TypeInfo);
		    DAT_ram_00a58c3a = '\x01';
		  }
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(param1,param2,0);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  piVar4 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x178);
		        goto code_r0x80f8cd62;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80f8cd62:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		  *(undefined4 *)(param1 + 0xc) = uVar3;
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar4 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 600);
		        goto code_r0x80f8ce11;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x33);
		code_r0x80f8ce11:
		  iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		  *(undefined4 *)(param1 + 0x10) = *(undefined4 *)(iVar5 + 0x14);
		  iVar5 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System
		                    (*(undefined4 *)(param1 + 0xc),0);
		  uVar3 = *(undefined4 *)(iVar5 + 0x1f0);
		  if (*(int *)(Gameplay_WorldAxis_ClanEquipment_Model_ClanEquipmentModel___c_TypeInfo + 0x74) == 0)
		  {
		    func_ii_306000(Gameplay_WorldAxis_ClanEquipment_Model_ClanEquipmentModel___c_TypeInfo);
		  }
		  puVar6 = *(undefined4 **)
		            (Gameplay_WorldAxis_ClanEquipment_Model_ClanEquipmentModel___c_TypeInfo + 0x5c);
		  iVar5 = puVar6[1];
		  if (iVar5 == 0) {
		    if (*(int *)(Gameplay_WorldAxis_ClanEquipment_Model_ClanEquipmentModel___c_TypeInfo + 0x74) == 0
		       ) {
		      func_ii_306000(Gameplay_WorldAxis_ClanEquipment_Model_ClanEquipmentModel___c_TypeInfo);
		      puVar6 = *(undefined4 **)
		                (Gameplay_WorldAxis_ClanEquipment_Model_ClanEquipmentModel___c_TypeInfo + 0x5c);
		    }
		    param2_00 = *puVar6;
		    iVar5 = unnamed_function_1417(System_Func_DollsInfoDic__ulong__TypeInfo);
		    func_ii_7542(iVar5,param2_00,
		                 Method_Gameplay_WorldAxis_ClanEquipment_Model_ClanEquipmentModel___c___ctor_b__13_0__
		                 ,0);
		    *(int *)(*(int *)(Gameplay_WorldAxis_ClanEquipment_Model_ClanEquipmentModel___c_TypeInfo + 0x5c)
		            + 4) = iVar5;
		  }
		  uVar3 = System_Linq_Enumerable__ToDictionary_object__uint_
		                    (uVar3,iVar5,Method_System_Linq_Enumerable_ToDictionary_DollsInfoDic__ulong___);
		  *(undefined4 *)(param1 + 0x14) = uVar3;
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar4 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x158);
		        goto code_r0x80f8cf67;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x13);
		code_r0x80f8cf67:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		  uVar3 = Core_Gameplay_Managers_CacheManager__GetEndOfFrameCacheRequestAccumulator(uVar3,0);
		  *(undefined4 *)(param1 + 0x1c) = param3;
		  *(undefined4 *)(param1 + 0x18) = uVar3;
		  *(undefined8 *)(param1 + 0x20) = *param4;
		  *(undefined8 *)(param1 + 0x28) = param4[1];
		  return;
		}
		*/


		/* --- GHIDRA: get_FiltersData ---
		void Gameplay_WorldAxis_ClanEquipment_Model_ClanEquipmentModel__get_FiltersData
		               (int param1,int *param2,int param3,undefined4 param4)
		
		{
		  uint uVar1;
		  undefined4 in_register_20000024;
		  ulonglong uVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  undefined4 uVar5;
		  int iVar6;
		  undefined4 *puVar7;
		  undefined4 uVar8;
		  int *piVar9;
		  undefined4 param7;
		  undefined4 param6;
		  undefined4 param5;
		  int iVar10;
		  ulonglong param3_00;
		  int iVar11;
		  int iVar12;
		  int *piVar13;
		  int local_c;
		  int **local_8;
		  int *local_4;
		  
		  uVar2 = CONCAT44(in_register_20000024,param3);
		  iVar10 = 0;
		  if (DAT_ram_00a58c3b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ulong__ClanEquipmentModel_DollArtifacts__set_Item__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_WorldAxis_ClanEquipment_Model_ClanEquipmentModel_DollArtifacts_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_WorldAxis_ClanEquipment_Model_ClanEquipmentModel_DollsOwner___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_WorldAxis_ClanEquipment_Model_ClanEquipmentModel_DollsOwner_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_ICollection_ProtoGetDollArtsAns_Types_DollsOwner__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_IEnumerator_ProtoGetDollArtsAns_Types_DollsOwner_Types_DollArtifacts__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_IList_ProtoGetDollArtsAns_Types_DollsOwner__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Google_Protobuf_Collections_RepeatedField_ProtoGetDollArtsAns_Types_DollsOwner_Types_DollArtifacts__GetEnumerator__
		              );
		    DAT_ram_00a58c3b = '\x01';
		  }
		  local_4 = (int *)0x0;
		  uVar3 = Mono_Security_ASN1Convert__ToOid
		                    (Gameplay_WorldAxis_ClanEquipment_Model_ClanEquipmentModel_DollsOwner___TypeInfo
		                     ,*(undefined4 *)(param3 + 0xc));
		  *(undefined4 *)(param1 + 0x34) = uVar3;
		  do {
		    uVar3 = (undefined4)(uVar2 >> 0x20);
		    iVar11 = *param2;
		    if (*(ushort *)(iVar11 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar9 = (int *)(*(int *)(iVar11 + 0x58) + uVar1 * 8);
		        if (System_Collections_Generic_ICollection_ProtoGetDollArtsAns_Types_DollsOwner__TypeInfo ==
		            *piVar9) {
		          puVar4 = (uint *)(iVar11 + piVar9[1] * 8 + 0xc0);
		          goto code_r0x80f8e3b0;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar11 + 0xb6) != uVar1);
		    }
		    puVar4 = (uint *)func_ii_1080(param2,
		                                  System_Collections_Generic_ICollection_ProtoGetDollArtsAns_Types_DollsOwner__TypeInfo
		                                  ,0);
		code_r0x80f8e3b0:
		    iVar11 = (**(code **)((ulonglong)*puVar4 * 4))(param2,puVar4[1]);
		    if (iVar11 <= iVar10) {
		      return;
		    }
		    uVar8 = *(undefined4 *)(param3 + iVar10 * 4 + 0x10);
		    piVar9 = *(int **)(param1 + 0x34);
		    iVar11 = unnamed_function_1417
		                       (
		                       Gameplay_WorldAxis_ClanEquipment_Model_ClanEquipmentModel_DollsOwner_TypeInfo
		                       );
		    if (DAT_ram_00a58c3f == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&
		                 Method_System_Collections_Generic_Dictionary_ulong__ClanEquipmentModel_DollArtifacts___ctor__
		                );
		      Mono_Security_ASN1__get_Item
		                (&
		                 System_Collections_Generic_Dictionary_ulong__ClanEquipmentModel_DollArtifacts__TypeInfo
		                );
		      DAT_ram_00a58c3f = '\x01';
		    }
		    uVar5 = unnamed_function_1417
		                      (
		                      System_Collections_Generic_Dictionary_ulong__ClanEquipmentModel_DollArtifacts__TypeInfo
		                      );
		    System_Collections_Generic_Dictionary_ulong__ulong___set_Item
		              (uVar5,
		               Method_System_Collections_Generic_Dictionary_ulong__ClanEquipmentModel_DollArtifacts___ctor__
		              );
		    *(undefined4 *)(iVar11 + 0xc) = uVar5;
		    *(undefined4 *)(iVar11 + 8) = uVar8;
		    iVar6 = func_ii_1082(iVar11,*(undefined4 *)(*piVar9 + 0x20));
		    if (iVar6 == 0) {
		      uVar3 = func_ii_1083();
		      func_ii_1050(uVar3,0);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    piVar9[iVar10 + 4] = iVar11;
		    iVar11 = *param2;
		    if (*(ushort *)(iVar11 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar9 = (int *)(*(int *)(iVar11 + 0x58) + uVar1 * 8);
		        if (System_Collections_Generic_IList_ProtoGetDollArtsAns_Types_DollsOwner__TypeInfo ==
		            *piVar9) {
		          puVar4 = (uint *)(iVar11 + piVar9[1] * 8 + 0xc0);
		          goto code_r0x80f8e4bb;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar11 + 0xb6) != uVar1);
		    }
		    puVar4 = (uint *)func_ii_1080(param2,
		                                  System_Collections_Generic_IList_ProtoGetDollArtsAns_Types_DollsOwner__TypeInfo
		                                  ,0);
		code_r0x80f8e4bb:
		    param3_00 = CONCAT44(uVar3,puVar4[1]);
		    iVar11 = (**(code **)((ulonglong)*puVar4 * 4))(param2,iVar10,param3_00);
		    local_4 = (int *)Google_Protobuf_Collections_RepeatedField_float___Equals
		                               (*(undefined4 *)(iVar11 + 0x18),
		                                Method_Google_Protobuf_Collections_RepeatedField_ProtoGetDollArtsAns_Types_DollsOwner_Types_DollArtifacts__GetEnumerator__
		                               );
		    local_c = 0;
		    local_8 = &local_4;
		    do {
		      piVar9 = local_4;
		      uVar3 = (undefined4)(param3_00 >> 0x20);
		      iVar11 = *local_4;
		      if (*(ushort *)(iVar11 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          piVar13 = (int *)(*(int *)(iVar11 + 0x58) + uVar1 * 8);
		          if (System_Collections_IEnumerator_TypeInfo == *piVar13) {
		            puVar7 = (undefined4 *)(iVar11 + piVar13[1] * 8 + 0xc0);
		            goto code_r0x80f8e58a;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar11 + 0xb6) != uVar1);
		      }
		      DAT_ram_009d3e38 = 0;
		      uVar2 = CONCAT44(uVar3,System_Collections_IEnumerator_TypeInfo);
		      puVar7 = (undefined4 *)
		               import::env::invoke_iiii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                          System_Collections_IEnumerator_TypeInfo,0);
		      uVar3 = (undefined4)(uVar2 >> 0x20);
		      if (DAT_ram_009d3e38 == 1) break;
		code_r0x80f8e58a:
		      DAT_ram_009d3e38 = 0;
		      uVar2 = CONCAT44(uVar3,puVar7[1]);
		      iVar11 = import::env::invoke_iii(*puVar7,piVar9,puVar7[1]);
		      piVar9 = local_4;
		      uVar3 = (undefined4)(uVar2 >> 0x20);
		      if (DAT_ram_009d3e38 == 1) break;
		      if (iVar11 == 0) {
		        iVar6 = 6;
		        iVar11 = 0;
		        goto code_r0x80f8e7e5;
		      }
		      iVar11 = *local_4;
		      if (*(ushort *)(iVar11 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          piVar13 = (int *)(*(int *)(iVar11 + 0x58) + uVar1 * 8);
		          if (System_Collections_Generic_IEnumerator_ProtoGetDollArtsAns_Types_DollsOwner_Types_DollArtifacts__TypeInfo
		              == *piVar13) {
		            puVar7 = (undefined4 *)(iVar11 + piVar13[1] * 8 + 0xc0);
		            goto code_r0x80f8e664;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar11 + 0xb6) != uVar1);
		      }
		      DAT_ram_009d3e38 = 0;
		      uVar2 = CONCAT44(uVar3,
		                       System_Collections_Generic_IEnumerator_ProtoGetDollArtsAns_Types_DollsOwner_Types_DollArtifacts__TypeInfo
		                      );
		      puVar7 = (undefined4 *)
		               import::env::invoke_iiii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                          System_Collections_Generic_IEnumerator_ProtoGetDollArtsAns_Types_DollsOwner_Types_DollArtifacts__TypeInfo
		                          ,0);
		      uVar3 = (undefined4)(uVar2 >> 0x20);
		      if (DAT_ram_009d3e38 == 1) break;
		code_r0x80f8e664:
		      DAT_ram_009d3e38 = 0;
		      uVar2 = CONCAT44(uVar3,puVar7[1]);
		      iVar11 = import::env::invoke_iii(*puVar7,piVar9,puVar7[1]);
		      if (DAT_ram_009d3e38 == 1) break;
		      uVar8 = *(undefined4 *)(*(int *)(*(int *)(param1 + 0x34) + iVar10 * 4 + 0x10) + 0xc);
		      uVar5 = *(undefined4 *)(param1 + 0x1c);
		      param7 = *(undefined4 *)(param1 + 0x18);
		      param6 = *(undefined4 *)(param1 + 0x14);
		      param5 = *(undefined4 *)(iVar11 + 0x18);
		      param3_00 = *(ulonglong *)(iVar11 + 0x10);
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::invoke_ii
		                        (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                         Gameplay_WorldAxis_ClanEquipment_Model_ClanEquipmentModel_DollArtifacts_TypeInfo
		                        );
		      if (DAT_ram_009d3e38 == 1) break;
		      DAT_ram_009d3e38 = 0;
		      uVar2 = CONCAT44((int)(uVar2 >> 0x20),(int)param3_00);
		      import::env::invoke_vijiiiii
		                (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x261,uVar3,(int)param3_00,
		                 (int)(param3_00 >> 0x20),param5,param6,param7,uVar5,uVar3);
		      if (DAT_ram_009d3e38 == 1) break;
		      DAT_ram_009d3e38 = 0;
		      unnamed_function_184063
		                (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x262,uVar8,param3_00,uVar3,
		                 Method_System_Collections_Generic_Dictionary_ulong__ClanEquipmentModel_DollArtifacts__set_Item__
		                );
		      uVar2 = param3_00;
		    } while (DAT_ram_009d3e38 != 1);
		    DAT_ram_009d3e38 = 0;
		    uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    iVar11 = global_1;
		    iVar6 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		    if (iVar11 != iVar6) {
		code_r0x80f8e893:
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x263,&local_c);
		      iVar10 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar10 != 1) {
		        import::env::__resumeException(uVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      import::env::__cxa_find_matching_catch_3(0);
		      unnamed_function_937();
		      do {
		        halt_trap();
		      } while( true );
		    }
		    piVar9 = (int *)import::env::__cxa_begin_catch(uVar3);
		    iVar11 = *piVar9;
		    iVar6 = 0;
		    DAT_ram_009d3e38 = 0;
		    local_c = iVar11;
		    import::env::invoke_v(0x123);
		    iVar12 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar12 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_2();
		      goto code_r0x80f8e893;
		    }
		code_r0x80f8e7e5:
		    piVar9 = local_4;
		    DAT_ram_009d3e38 = 0;
		    if (local_4 != (int *)0x0) {
		      iVar12 = *local_4;
		      if (*(ushort *)(iVar12 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          piVar13 = (int *)(*(int *)(iVar12 + 0x58) + uVar1 * 8);
		          if (System_IDisposable_TypeInfo == *piVar13) {
		            puVar4 = (uint *)(iVar12 + piVar13[1] * 8 + 0xc0);
		            goto code_r0x80f8e859;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar12 + 0xb6) != uVar1);
		      }
		      uVar2 = uVar2 & 0xffffffff00000000;
		      puVar4 = (uint *)func_ii_1080(local_4,System_IDisposable_TypeInfo,0);
		code_r0x80f8e859:
		      (**(code **)((ulonglong)*puVar4 * 4))(piVar9,puVar4[1]);
		    }
		    if (iVar11 != 0) {
		      System_Data_DataSet__ValidateLocaleConstraint(iVar11);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    if (iVar6 != 0) {
		      if (iVar6 == 1) {
		        return;
		      }
		      if (iVar6 == 2) {
		        return;
		      }
		      if (iVar6 == 3) {
		        return;
		      }
		      if (iVar6 == 4) {
		        return;
		      }
		      if (iVar6 == 5) {
		        return;
		      }
		      if (iVar6 != 6) {
		        return;
		      }
		    }
		    iVar10 = iVar10 + 1;
		  } while( true );
		}
		*/

}
