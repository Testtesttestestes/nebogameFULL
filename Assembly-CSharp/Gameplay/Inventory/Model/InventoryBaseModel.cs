using System;
using System.Collections.Generic;
using Core.Cache;
using Core.Data;
using Core.Dict;
using Core.Gameplay.Managers.Requirements;
using Il2CppDummyDll;
using MVC;
using Protocol.Common;
using Protocol.Main;
using UI.Toast;

namespace Gameplay.Inventory.Model
{
	// Token: 0x0200069E RID: 1694
	[Token(Token = "0x200069E")]
	public abstract class InventoryBaseModel : AbstractModel
	{
		// Token: 0x170007C2 RID: 1986
		// (get) Token: 0x060028FE RID: 10494 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170007C2")]
		public Dictionary<ulong, ArtifactData> ArtifactsByArtifactId
		{
			[Token(Token = "0x60028FE")]
			[Address(RVA = "0x7A16", Offset = "0x7A16", VA = "0x7A16")]
			get
			{
				return null;
			}
		}

		// Token: 0x170007C3 RID: 1987
		// (get) Token: 0x060028FF RID: 10495 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170007C3")]
		public Dictionary<ulong, ArtifactData> Favorites
		{
			[Token(Token = "0x60028FF")]
			[Address(RVA = "0x7A17", Offset = "0x7A17", VA = "0x7A17")]
			get
			{
				return null;
			}
		}

		// Token: 0x170007C4 RID: 1988
		// (get) Token: 0x06002900 RID: 10496 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170007C4")]
		public Dictionary<ulong, ArtifactData> Fresh
		{
			[Token(Token = "0x6002900")]
			[Address(RVA = "0x7A18", Offset = "0x7A18", VA = "0x7A18")]
			get
			{
				return null;
			}
		}

		// Token: 0x170007C5 RID: 1989
		// (get) Token: 0x06002901 RID: 10497 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170007C5")]
		public Dictionary<uint, List<ArtifactData>> ChestArtifactsByArtikulType
		{
			[Token(Token = "0x6002901")]
			[Address(RVA = "0x7A19", Offset = "0x7A19", VA = "0x7A19")]
			get
			{
				return null;
			}
		}

		// Token: 0x170007C6 RID: 1990
		// (get) Token: 0x06002902 RID: 10498 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170007C6")]
		public SortedList<int, ArtifactData> ChestArtifacts
		{
			[Token(Token = "0x6002902")]
			[Address(RVA = "0x7A1A", Offset = "0x7A1A", VA = "0x7A1A")]
			get
			{
				return null;
			}
		}

		// Token: 0x170007C7 RID: 1991
		// (get) Token: 0x06002903 RID: 10499 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170007C7")]
		public SortedList<int, ArtifactData> BagArtifacts
		{
			[Token(Token = "0x6002903")]
			[Address(RVA = "0x7A1B", Offset = "0x7A1B", VA = "0x7A1B")]
			get
			{
				return null;
			}
		}

		// Token: 0x170007C8 RID: 1992
		// (get) Token: 0x06002904 RID: 10500 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170007C8")]
		public Dictionary<int, ArtifactData> Equipment
		{
			[Token(Token = "0x6002904")]
			[Address(RVA = "0x7A1C", Offset = "0x7A1C", VA = "0x7A1C")]
			get
			{
				return null;
			}
		}

		// Token: 0x170007C9 RID: 1993
		// (get) Token: 0x06002905 RID: 10501 RVA: 0x00007BC0 File Offset: 0x00005DC0
		[Token(Token = "0x170007C9")]
		public int BagEmptySlotsNum
		{
			[Token(Token = "0x6002905")]
			[Address(RVA = "0x7A1D", Offset = "0x7A1D", VA = "0x7A1D")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170007CA RID: 1994
		// (get) Token: 0x06002906 RID: 10502 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170007CA")]
		public int[] EquipSlotsIds
		{
			[Token(Token = "0x6002906")]
			[Address(RVA = "0x7A1E", Offset = "0x7A1E", VA = "0x7A1E")]
			get
			{
				return null;
			}
		}

		// Token: 0x170007CB RID: 1995
		// (get) Token: 0x06002907 RID: 10503 RVA: 0x00007BD8 File Offset: 0x00005DD8
		[Token(Token = "0x170007CB")]
		public long AvailableSlots
		{
			[Token(Token = "0x6002907")]
			[Address(RVA = "0x7A1F", Offset = "0x7A1F", VA = "0x7A1F")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x170007CC RID: 1996
		// (get) Token: 0x06002908 RID: 10504 RVA: 0x00007BF0 File Offset: 0x00005DF0
		[Token(Token = "0x170007CC")]
		public long ChestEmptySlotsNum
		{
			[Token(Token = "0x6002908")]
			[Address(RVA = "0x7A20", Offset = "0x7A20", VA = "0x7A20")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x170007CD RID: 1997
		// (get) Token: 0x06002909 RID: 10505 RVA: 0x00007C08 File Offset: 0x00005E08
		[Token(Token = "0x170007CD")]
		public long ChestTotalSlotsNum
		{
			[Token(Token = "0x6002909")]
			[Address(RVA = "0x7A21", Offset = "0x7A21", VA = "0x7A21")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x170007CE RID: 1998
		// (get) Token: 0x0600290A RID: 10506 RVA: 0x00007C20 File Offset: 0x00005E20
		[Token(Token = "0x170007CE")]
		public long TotalEmptySlotsNum
		{
			[Token(Token = "0x600290A")]
			[Address(RVA = "0x7A22", Offset = "0x7A22", VA = "0x7A22")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x170007CF RID: 1999
		// (get) Token: 0x0600290B RID: 10507 RVA: 0x00007C38 File Offset: 0x00005E38
		[Token(Token = "0x170007CF")]
		public long TotalSlotsAvailable
		{
			[Token(Token = "0x600290B")]
			[Address(RVA = "0x7A23", Offset = "0x7A23", VA = "0x7A23")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x0600290C RID: 10508 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600290C")]
		[Address(RVA = "0x7A24", Offset = "0x7A24", VA = "0x7A24")]
		protected InventoryBaseModel(ToastController toasts, ArtifactCache artifactCache, IRequirementValidator requirementValidator, IDictProvider dictProvider, UserData user)
		{
		/* --- GHIDRA: <GetAllArtikulTypeFilters>b__48_0 ---
		void Gameplay_Inventory_Model_InventoryBaseModel___GetAllArtikulTypeFilters_b__48_0
		               (undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5a152 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Inventory_Model_InventoryBaseModel___c_TypeInfo);
		    DAT_ram_00a5a152 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Gameplay_Inventory_Model_InventoryBaseModel___c_TypeInfo);
		  **(undefined4 **)(Gameplay_Inventory_Model_InventoryBaseModel___c_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

		/* --- GHIDRA: .ctor ---
		int Gameplay_Inventory_Model_InventoryBaseModel___ctor(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  int iVar5;
		  int *param1_00;
		  undefined4 *puVar6;
		  
		  if (DAT_ram_00a5a143 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_OrderBy_InventoryMetaFilterData__uint___);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_Select_ArtikulTypeMetaFilterDic__InventoryMetaFilterData___
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToList_InventoryMetaFilterData___);
		    Mono_Security_ASN1__get_Item
		              (&System_Func_ArtikulTypeMetaFilterDic__InventoryMetaFilterData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_InventoryMetaFilterData__uint__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Inventory_Model_InventoryBaseModel__GetAllArtikulTypeFilters_b__48_0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_InventoryMetaFilterData___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_InventoryMetaFilterData__TypeInfo)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Inventory_Model_InventoryBaseModel___c__GetAllArtikulTypeFilters_b__48_1__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Inventory_Model_InventoryBaseModel___c_TypeInfo);
		    DAT_ram_00a5a143 = '\x01';
		  }
		  iVar5 = *(int *)(param1 + 0x38);
		  if (iVar5 == 0) {
		    uVar1 = 0;
		    param1_00 = *(int **)(param1 + 0x4c);
		    iVar5 = *param1_00;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      do {
		        if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd0);
		          goto code_r0x811d2c79;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param1_00,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x811d2c79:
		    uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		    uVar3 = Core_Extensions_Dict_DictExt__GetString(uVar3,0x20,0);
		    uVar4 = unnamed_function_1417(System_Collections_Generic_List_InventoryMetaFilterData__TypeInfo)
		    ;
		    GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		              (uVar4,Method_System_Collections_Generic_List_InventoryMetaFilterData___ctor__);
		    *(undefined4 *)(param1 + 0x38) = uVar4;
		    uVar4 = unnamed_function_1417
		                      (System_Func_ArtikulTypeMetaFilterDic__InventoryMetaFilterData__TypeInfo);
		    System_Linq_Enumerable__Where_object_
		              (uVar4,param1,
		               Method_Gameplay_Inventory_Model_InventoryBaseModel__GetAllArtikulTypeFilters_b__48_0__
		               ,0);
		    uVar3 = System_Linq_Enumerable__ReverseIterator___Il2CppFullySharedGenericType_
		                      (uVar3,uVar4,
		                       Method_System_Linq_Enumerable_Select_ArtikulTypeMetaFilterDic__InventoryMetaFilterData___
		                      );
		    uVar3 = System_Linq_Enumerable__Select_object__object_
		                      (uVar3,Method_System_Linq_Enumerable_ToList_InventoryMetaFilterData___);
		    if (*(int *)(Gameplay_Inventory_Model_InventoryBaseModel___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_Inventory_Model_InventoryBaseModel___c_TypeInfo);
		    }
		    puVar6 = *(undefined4 **)(Gameplay_Inventory_Model_InventoryBaseModel___c_TypeInfo + 0x5c);
		    iVar5 = puVar6[1];
		    if (iVar5 == 0) {
		      if (*(int *)(Gameplay_Inventory_Model_InventoryBaseModel___c_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Gameplay_Inventory_Model_InventoryBaseModel___c_TypeInfo);
		        puVar6 = *(undefined4 **)(Gameplay_Inventory_Model_InventoryBaseModel___c_TypeInfo + 0x5c);
		      }
		      uVar4 = *puVar6;
		      iVar5 = unnamed_function_1417(System_Func_InventoryMetaFilterData__uint__TypeInfo);
		      System_Collections_Generic_Dictionary_KeyCollection_uint__object___GetEnumerator
		                (iVar5,uVar4,
		                 Method_Gameplay_Inventory_Model_InventoryBaseModel___c__GetAllArtikulTypeFilters_b__48_1__
		                 ,0);
		      *(int *)(*(int *)(Gameplay_Inventory_Model_InventoryBaseModel___c_TypeInfo + 0x5c) + 4) =
		           iVar5;
		    }
		    uVar3 = System_Linq_Enumerable__Min___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType_
		                      (uVar3,iVar5,
		                       Method_System_Linq_Enumerable_OrderBy_InventoryMetaFilterData__uint___);
		    iVar5 = System_Linq_Enumerable__Select_object__object_
		                      (uVar3,Method_System_Linq_Enumerable_ToList_InventoryMetaFilterData___);
		    *(int *)(param1 + 0x38) = iVar5;
		  }
		  return iVar5;
		}
		*/

		}

		// Token: 0x0600290D RID: 10509 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600290D")]
		[Address(RVA = "0x7A25", Offset = "0x7A25", VA = "0x7A25")]
		public List<InventoryMetaFilterData> GetAllArtikulTypeFilters()
		{
		/* --- GHIDRA: GetAllArtikulTypeFilters ---
		uint Gameplay_Inventory_Model_InventoryBaseModel__GetAllArtikulTypeFilters
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int iVar1;
		  uint uVar2;
		  int iVar3;
		  uint uVar4;
		  uint uVar5;
		  
		  uVar5 = 1;
		  iVar1 = Core_Data_ArtifactData__get_StackLimit(param2,0);
		  uVar2 = Core_Data_UserData__set_LevelDic(param3,0);
		  uVar4 = 1;
		  iVar3 = Core_Data_ArtifactData__get_MinLevel(param2,0);
		  if (iVar3 != 0) {
		    iVar3 = Core_Data_ArtifactData__get_MinLevel(param2,0);
		    uVar4 = func_ii_6965(param3,0);
		    uVar4 = (uint)((longlong)iVar3 == (ulonglong)uVar4);
		  }
		  iVar3 = Core_Data_ArtifactData__get_Cult(param2,0);
		  if (iVar3 != 0) {
		    iVar3 = Core_Data_ArtifactData__get_Cult(param2,0);
		    uVar5 = Core_Data_UserData__set_Level(param3,0);
		    uVar5 = (uint)((longlong)iVar3 == (ulonglong)uVar5);
		  }
		  return uVar5 & uVar4 & (longlong)iVar1 <= (longlong)(ulonglong)uVar2;
		}
		*/

			return null;
		}

		// Token: 0x0600290E RID: 10510 RVA: 0x00007C50 File Offset: 0x00005E50
		[Token(Token = "0x600290E")]
		[Address(RVA = "0x7A26", Offset = "0x7A26", VA = "0x7A26")]
		protected bool IsArtifactCanBeEquipped(ArtifactData artifact, UserData user)
		{
		/* --- GHIDRA: IsArtifactCanBeEquipped ---
		undefined4
		Gameplay_Inventory_Model_InventoryBaseModel__IsArtifactCanBeEquipped
		          (int param1,uint param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a5a144 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_int__get_Count__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_int__get_Item__);
		    DAT_ram_00a5a144 = '\x01';
		  }
		  iVar2 = -1;
		  iVar1 = -1;
		  if (0 < *(int *)(*(int *)(param1 + 0x30) + 0xc)) {
		    iVar1 = System_Linq_Enumerable__ToList_object_
		                      (*(int *)(param1 + 0x30),0,
		                       Method_System_Collections_Generic_List_int__get_Item__);
		  }
		  if (0 < *(int *)(*(int *)(param1 + 0x34) + 0xc)) {
		    iVar2 = System_Linq_Enumerable__ToList_object_
		                      (*(int *)(param1 + 0x34),0,
		                       Method_System_Collections_Generic_List_int__get_Item__);
		  }
		  if ((param2 & 3) == 3) {
		    if (iVar1 != -1) {
		      return iVar1;
		    }
		    if (iVar2 != -1) {
		      return iVar2;
		    }
		  }
		  else {
		    if ((param2 & 1) != 0) {
		      return iVar1;
		    }
		    if ((param2 & 2) != 0) {
		      return iVar2;
		    }
		  }
		  return 0xffffffff;
		}
		*/

			return default(bool);
		}

		// Token: 0x0600290F RID: 10511 RVA: 0x00007C68 File Offset: 0x00005E68
		[Token(Token = "0x600290F")]
		[Address(RVA = "0x7A27", Offset = "0x7A27", VA = "0x7A27")]
		public int GetFirstEmptySlot(InvetoryScope scope = InvetoryScope.ALL)
		{
		/* --- GHIDRA: GetFirstEmptySlot ---
		void Gameplay_Inventory_Model_InventoryBaseModel__GetFirstEmptySlot(int param1,undefined4 param2)
		
		{
		  int *piVar1;
		  uint *puVar2;
		  undefined4 *puVar3;
		  undefined4 uVar4;
		  int iVar5;
		  undefined8 param3;
		  int *piVar6;
		  int iVar7;
		  uint uVar8;
		  int local_c;
		  int **local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a5a145 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_ulong__ArtifactData__Clear__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_ulong__ArtifactData__set_Item__);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerable_int__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_int__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_SortedList_int__ArtifactData__get_Item__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_SortedList_int__ArtifactData__get_Keys__);
		    DAT_ram_00a5a145 = '\x01';
		  }
		  System_Xml_XmlWellFormedWriter__PushNamespaceImplicit
		            (*(undefined4 *)(param1 + 0x20),
		             Method_System_Collections_Generic_Dictionary_ulong__ArtifactData__Clear__);
		  piVar1 = (int *)System_Collections_Generic_SortedList_uint__object___System_Collections_IDictionary_get_Item
		                            (*(undefined4 *)(param1 + 0xc),
		                             Method_System_Collections_Generic_SortedList_int__ArtifactData__get_Keys__
		                            );
		  iVar7 = *piVar1;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    uVar8 = 0;
		    do {
		      if (System_Collections_Generic_IEnumerable_int__TypeInfo ==
		          *(int *)(*(int *)(iVar7 + 0x58) + uVar8 * 8)) {
		        puVar2 = (uint *)(iVar7 + *(int *)(*(int *)(iVar7 + 0x58) + uVar8 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x811d2ef9;
		      }
		      uVar8 = uVar8 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar8);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar1,System_Collections_Generic_IEnumerable_int__TypeInfo,0);
		code_r0x811d2ef9:
		  local_4 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(piVar1,puVar2[1]);
		  local_c = 0;
		  local_8 = &local_4;
		  do {
		    do {
		      piVar1 = local_4;
		      iVar7 = *local_4;
		      if (*(ushort *)(iVar7 + 0xb6) != 0) {
		        uVar8 = 0;
		        do {
		          piVar6 = (int *)(*(int *)(iVar7 + 0x58) + uVar8 * 8);
		          if (System_Collections_IEnumerator_TypeInfo == *piVar6) {
		            puVar3 = (undefined4 *)(iVar7 + piVar6[1] * 8 + 0xc0);
		            goto code_r0x811d2fc4;
		          }
		          uVar8 = uVar8 + 1;
		        } while (*(ushort *)(iVar7 + 0xb6) != uVar8);
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar3 = (undefined4 *)
		               import::env::invoke_iiii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                          System_Collections_IEnumerator_TypeInfo,0);
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x811d300c:
		        DAT_ram_009d3e38 = 0;
		        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x811d31da;
		      }
		code_r0x811d2fc4:
		      DAT_ram_009d3e38 = 0;
		      iVar7 = import::env::invoke_iii(*puVar3,piVar1,puVar3[1]);
		      piVar1 = local_4;
		      if (DAT_ram_009d3e38 == 1) goto code_r0x811d300c;
		      if (iVar7 == 0) {
		        iVar7 = 0;
		        goto code_r0x811d3223;
		      }
		      iVar7 = *local_4;
		      if (*(ushort *)(iVar7 + 0xb6) != 0) {
		        uVar8 = 0;
		        do {
		          piVar6 = (int *)(*(int *)(iVar7 + 0x58) + uVar8 * 8);
		          if (System_Collections_Generic_IEnumerator_int__TypeInfo == *piVar6) {
		            puVar3 = (undefined4 *)(iVar7 + piVar6[1] * 8 + 0xc0);
		            goto code_r0x811d30b5;
		          }
		          uVar8 = uVar8 + 1;
		        } while (*(ushort *)(iVar7 + 0xb6) != uVar8);
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar3 = (undefined4 *)
		               import::env::invoke_iiii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                          System_Collections_Generic_IEnumerator_int__TypeInfo,0);
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x811d3139:
		        DAT_ram_009d3e38 = 0;
		        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x811d31da;
		      }
		code_r0x811d30b5:
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::invoke_iii(*puVar3,piVar1,puVar3[1]);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x811d3139;
		      DAT_ram_009d3e38 = 0;
		      iVar5 = import::env::invoke_iiii
		                        (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x260,
		                         *(undefined4 *)(param1 + 0xc),uVar4,
		                         Method_System_Collections_Generic_SortedList_int__ArtifactData__get_Item__)
		      ;
		      iVar7 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar7 == 1) {
		        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x811d31da;
		      }
		    } while ((iVar5 == 0) || (*(char *)(iVar5 + 0x79) == '\0'));
		    uVar4 = *(undefined4 *)(param1 + 0x20);
		    DAT_ram_009d3e38 = 0;
		    param3 = unnamed_function_184054(s_struct_Uniforms___color__array<v_ram_00001f04 + 0x12,iVar5,0)
		    ;
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar7 == 1) {
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x811d31da;
		    }
		    DAT_ram_009d3e38 = 0;
		    unnamed_function_184063
		              (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x262,uVar4,param3,iVar5,
		               Method_System_Collections_Generic_Dictionary_ulong__ArtifactData__set_Item__);
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar7 != 1);
		  uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x811d31da:
		  iVar7 = global_1;
		  iVar5 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar7 == iVar5) {
		    piVar1 = (int *)import::env::__cxa_begin_catch(uVar4);
		    iVar7 = *piVar1;
		    DAT_ram_009d3e38 = 0;
		    local_c = iVar7;
		    import::env::invoke_v(0x123);
		    iVar5 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar5 != 1) {
		code_r0x811d3223:
		      piVar1 = local_4;
		      DAT_ram_009d3e38 = 0;
		      if (local_4 != (int *)0x0) {
		        uVar8 = 0;
		        iVar5 = *local_4;
		        if (*(ushort *)(iVar5 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar8 * 8)) {
		              puVar2 = (uint *)(iVar5 + *(int *)(*(int *)(iVar5 + 0x58) + uVar8 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x811d329b;
		            }
		            uVar8 = uVar8 + 1;
		          } while (*(ushort *)(iVar5 + 0xb6) != uVar8);
		        }
		        puVar2 = (uint *)func_ii_1080(local_4,System_IDisposable_TypeInfo,0);
		code_r0x811d329b:
		        (**(code **)((ulonglong)*puVar2 * 4))(piVar1,puVar2[1]);
		      }
		      if (iVar7 == 0) {
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar7);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar4 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001f04 + 0x261,&local_c);
		  iVar7 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar7 == 1) {
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__resumeException(uVar4);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

			return 0;
		}

		// Token: 0x06002910 RID: 10512 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002910")]
		[Address(RVA = "0x7A28", Offset = "0x7A28", VA = "0x7A28")]
		private void UpdateFreshCache()
		{
		/* --- GHIDRA: UpdateFreshCache ---
		void Gameplay_Inventory_Model_InventoryBaseModel__UpdateFreshCache(int *param1,undefined4 param2)
		
		{
		  int *piVar1;
		  uint *puVar2;
		  undefined4 *puVar3;
		  undefined4 uVar4;
		  int iVar5;
		  int iVar6;
		  int iVar7;
		  int iVar8;
		  undefined8 uVar9;
		  int iVar10;
		  undefined4 param3;
		  int *piVar11;
		  uint uVar12;
		  int local_10;
		  int **local_c;
		  int *local_8;
		  int local_4;
		  
		  if (DAT_ram_00a5a146 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_ArtikulDic__uint__get_Data__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_int__ArtifactData__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_ulong__ArtifactData__Clear__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_int__ArtifactData__Clear__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__List_ArtifactData___Clear__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_Dictionary_uint__uint__Clear__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__List_ArtifactData___ContainsKey__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__List_ArtifactData___get_Item__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_ulong__ArtifactData__set_Item__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__uint__set_Item__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__List_ArtifactData___set_Item__);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerable_int__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_int__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_int__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ArtifactData__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_int__Clear__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ArtifactData___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_ArtifactData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_SortedList_int__ArtifactData__Clear__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_SortedList_int__ArtifactData__get_Item__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_SortedList_int__ArtifactData__get_Keys__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_SortedList_int__ArtifactData__set_Item__);
		    DAT_ram_00a5a146 = '\x01';
		  }
		  local_8 = (int *)0x0;
		  System_Xml_XmlWellFormedWriter__PushNamespaceImplicit
		            (param1[5],Method_System_Collections_Generic_Dictionary_uint__uint__Clear__);
		  System_Xml_XmlWellFormedWriter__PushNamespaceImplicit
		            (param1[10],Method_System_Collections_Generic_Dictionary_ulong__ArtifactData__Clear__);
		  System_Collections_Generic_SortedList_int__object___Add
		            (param1[6],Method_System_Collections_Generic_SortedList_int__ArtifactData__Clear__);
		  System_Xml_XmlWellFormedWriter__PushNamespaceImplicit
		            (param1[9],
		             Method_System_Collections_Generic_Dictionary_uint__List_ArtifactData___Clear__);
		  iVar10 = param1[0xd];
		  *(undefined4 *)(iVar10 + 0xc) = 0;
		  *(int *)(iVar10 + 0x10) = *(int *)(iVar10 + 0x10) + 1;
		  iVar10 = param1[0xc];
		  *(undefined4 *)(iVar10 + 0xc) = 0;
		  *(int *)(iVar10 + 0x10) = *(int *)(iVar10 + 0x10) + 1;
		  System_Xml_XmlWellFormedWriter__PushNamespaceImplicit
		            (param1[0xb],Method_System_Collections_Generic_Dictionary_int__ArtifactData__Clear__);
		  System_Xml_XmlWellFormedWriter__PushNamespaceImplicit
		            (param1[7],Method_System_Collections_Generic_Dictionary_ulong__ArtifactData__Clear__);
		  param1[0x11] = 0;
		  param1[0xf] = 0;
		  param1[0x10] = 0;
		  piVar1 = (int *)System_Collections_Generic_SortedList_uint__object___System_Collections_IDictionary_get_Item
		                            (param1[3],
		                             Method_System_Collections_Generic_SortedList_int__ArtifactData__get_Keys__
		                            );
		  iVar10 = *piVar1;
		  if (*(ushort *)(iVar10 + 0xb6) != 0) {
		    uVar12 = 0;
		    do {
		      if (System_Collections_Generic_IEnumerable_int__TypeInfo ==
		          *(int *)(*(int *)(iVar10 + 0x58) + uVar12 * 8)) {
		        puVar2 = (uint *)(iVar10 + *(int *)(*(int *)(iVar10 + 0x58) + uVar12 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x811d3521;
		      }
		      uVar12 = uVar12 + 1;
		    } while (*(ushort *)(iVar10 + 0xb6) != uVar12);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar1,System_Collections_Generic_IEnumerable_int__TypeInfo,0);
		code_r0x811d3521:
		  local_8 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(piVar1,puVar2[1]);
		  local_10 = 0;
		  local_c = &local_8;
		code_r0x811d3546:
		  do {
		    do {
		      piVar1 = local_8;
		      iVar10 = *local_8;
		      if (*(ushort *)(iVar10 + 0xb6) != 0) {
		        uVar12 = 0;
		        do {
		          piVar11 = (int *)(*(int *)(iVar10 + 0x58) + uVar12 * 8);
		          if (System_Collections_IEnumerator_TypeInfo == *piVar11) {
		            puVar3 = (undefined4 *)(iVar10 + piVar11[1] * 8 + 0xc0);
		            goto code_r0x811d35ec;
		          }
		          uVar12 = uVar12 + 1;
		        } while (*(ushort *)(iVar10 + 0xb6) != uVar12);
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar3 = (undefined4 *)
		               import::env::invoke_iiii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_8,
		                          System_Collections_IEnumerator_TypeInfo,0);
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x811d3630:
		        DAT_ram_009d3e38 = 0;
		        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x811d3fca;
		      }
		code_r0x811d35ec:
		      DAT_ram_009d3e38 = 0;
		      iVar10 = import::env::invoke_iii(*puVar3,piVar1,puVar3[1]);
		      piVar1 = local_8;
		      if (DAT_ram_009d3e38 == 1) goto code_r0x811d3630;
		      if (iVar10 == 0) goto code_r0x811d4013;
		      iVar10 = *local_8;
		      if (*(ushort *)(iVar10 + 0xb6) != 0) {
		        uVar12 = 0;
		        do {
		          piVar11 = (int *)(*(int *)(iVar10 + 0x58) + uVar12 * 8);
		          if (System_Collections_Generic_IEnumerator_int__TypeInfo == *piVar11) {
		            puVar3 = (undefined4 *)(iVar10 + piVar11[1] * 8 + 0xc0);
		            goto code_r0x811d36ed;
		          }
		          uVar12 = uVar12 + 1;
		        } while (*(ushort *)(iVar10 + 0xb6) != uVar12);
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar3 = (undefined4 *)
		               import::env::invoke_iiii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_8,
		                          System_Collections_Generic_IEnumerator_int__TypeInfo,0);
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x811d37ec:
		        DAT_ram_009d3e38 = 0;
		        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x811d3fca;
		      }
		code_r0x811d36ed:
		      DAT_ram_009d3e38 = 0;
		      iVar10 = import::env::invoke_iii(*puVar3,piVar1,puVar3[1]);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x811d37ec;
		      DAT_ram_009d3e38 = 0;
		      piVar1 = (int *)import::env::invoke_iiii
		                                (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x260,param1[3],
		                                 iVar10,
		                                 Method_System_Collections_Generic_SortedList_int__ArtifactData__get_Item__
		                                );
		      iVar8 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar8 == 1) {
		        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x811d3fca;
		      }
		      if (piVar1 != (int *)0x0) {
		        iVar5 = param1[10];
		        DAT_ram_009d3e38 = 0;
		        uVar9 = unnamed_function_184054
		                          (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x12,piVar1,0);
		        iVar8 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar8 == 1) {
		          uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x811d3fca;
		        }
		        DAT_ram_009d3e38 = 0;
		        unnamed_function_184063
		                  (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x262,iVar5,uVar9,piVar1,
		                   Method_System_Collections_Generic_Dictionary_ulong__ArtifactData__set_Item__);
		        iVar8 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar8 == 1) {
		          uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x811d3fca;
		        }
		        if ((char)piVar1[0x1e] != '\0') {
		          iVar5 = param1[7];
		          DAT_ram_009d3e38 = 0;
		          uVar9 = unnamed_function_184054
		                            (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x12,piVar1,0);
		          iVar8 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar8 == 1) {
		            uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x811d3fca;
		          }
		          DAT_ram_009d3e38 = 0;
		          unnamed_function_184063
		                    (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x262,iVar5,uVar9,piVar1,
		                     Method_System_Collections_Generic_Dictionary_ulong__ArtifactData__set_Item__);
		          iVar8 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar8 == 1) {
		            uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x811d3fca;
		          }
		        }
		      }
		      DAT_ram_009d3e38 = 0;
		      iVar5 = import::env::invoke_iiii
		                        (*(undefined4 *)(*param1 + 0x110),param1,iVar10,
		                         *(undefined4 *)(*param1 + 0x114));
		      iVar8 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar8 == 1) {
		        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x811d3fca;
		      }
		      if (iVar5 != 0) {
		        param1[0x11] = param1[0x11] + 1;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viiii
		                  (s_struct_Uniforms___color__array<v_ram_00000aff + 0x259,param1[0xb],iVar10,piVar1
		                   ,Method_System_Collections_Generic_Dictionary_int__ArtifactData__Add__);
		        iVar8 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar8 == 1) {
		          uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x811d3fca;
		        }
		      }
		      if (piVar1 != (int *)0x0) {
		        uVar4 = *(undefined4 *)(*(int *)(piVar1[2] + 0x10) + 0xc);
		        if (DAT_ram_00a5a14d == '\0') {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vi
		                    (0x7ff,&Method_System_Collections_Generic_Dictionary_uint__uint__TryGetValue__);
		          if (DAT_ram_009d3e38 != 1) {
		            DAT_ram_00a5a14d = '\x01';
		            goto code_r0x811d396c;
		          }
		        }
		        else {
		code_r0x811d396c:
		          local_4 = 0;
		          DAT_ram_009d3e38 = 0;
		          iVar5 = import::env::invoke_iiiii
		                            (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x262,param1[5],uVar4
		                             ,&local_4,
		                             Method_System_Collections_Generic_Dictionary_uint__uint__TryGetValue__)
		          ;
		          iVar8 = local_4;
		          if (DAT_ram_009d3e38 != 1) {
		            DAT_ram_009d3e38 = 0;
		            iVar6 = import::env::invoke_iii
		                              (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x8c,piVar1,0);
		            iVar7 = DAT_ram_009d3e38;
		            DAT_ram_009d3e38 = 0;
		            if (iVar7 != 1) {
		              if (iVar5 == 0) {
		                iVar8 = 0;
		              }
		              if (iVar6 == 0) {
		                DAT_ram_009d3e38 = 0;
		                iVar7 = import::env::invoke_iii
		                                  (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x263,piVar1,0)
		                ;
		                iVar5 = DAT_ram_009d3e38;
		                DAT_ram_009d3e38 = 0;
		                if (iVar5 == 1) {
		                  uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                  goto code_r0x811d3fca;
		                }
		                if (iVar7 == 0) {
		                  DAT_ram_009d3e38 = 0;
		                  iVar7 = import::env::invoke_iii
		                                    (*(undefined4 *)(*piVar1 + 0xf8),piVar1,
		                                     *(undefined4 *)(*piVar1 + 0xfc));
		                  iVar5 = DAT_ram_009d3e38;
		                  DAT_ram_009d3e38 = 0;
		                  if (iVar5 == 1) {
		                    uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                    goto code_r0x811d3fca;
		                  }
		                  DAT_ram_009d3e38 = 0;
		                  iVar6 = import::env::invoke_iii
		                                    (*(undefined4 *)(*piVar1 + 0xe8),piVar1,
		                                     *(undefined4 *)(*piVar1 + 0xec));
		                  iVar5 = DAT_ram_009d3e38;
		                  DAT_ram_009d3e38 = 0;
		                  if (iVar5 == 1) {
		                    uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                    goto code_r0x811d3fca;
		                  }
		                  if (iVar7 < iVar6) goto code_r0x811d3b5b;
		                }
		                iVar8 = iVar8 + 1;
		              }
		              else {
		                DAT_ram_009d3e38 = 0;
		                iVar7 = import::env::invoke_iii
		                                  (*(undefined4 *)(*piVar1 + 0xf8),piVar1,
		                                   *(undefined4 *)(*piVar1 + 0xfc));
		                iVar5 = DAT_ram_009d3e38;
		                DAT_ram_009d3e38 = 0;
		                if (iVar5 == 1) {
		                  uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                  goto code_r0x811d3fca;
		                }
		                iVar8 = iVar8 + iVar7;
		              }
		code_r0x811d3b5b:
		              DAT_ram_009d3e38 = 0;
		              import::env::invoke_viiii
		                        (s_struct_Uniforms___color__array<v_ram_00001b87 + 0xd0,param1[5],
		                         *(undefined4 *)(*(int *)(piVar1[2] + 0x10) + 0xc),iVar8,
		                         Method_System_Collections_Generic_Dictionary_uint__uint__set_Item__);
		              iVar8 = DAT_ram_009d3e38;
		              DAT_ram_009d3e38 = 0;
		              if (iVar8 != 1) goto code_r0x811d3bc5;
		              uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		              goto code_r0x811d3fca;
		            }
		            uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x811d3fca;
		          }
		        }
		        DAT_ram_009d3e38 = 0;
		        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x811d3fca;
		      }
		code_r0x811d3bc5:
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_viiii
		                (*(undefined4 *)(*param1 + 0xf0),param1,iVar10,piVar1,
		                 *(undefined4 *)(*param1 + 0xf4));
		      iVar8 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar8 == 1) {
		        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x811d3fca;
		      }
		      if (DAT_ram_00a5a162 == '\0') {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vi(0x7ff,&Gameplay_Inventory_Model_InventoryConstants_TypeInfo);
		        if (DAT_ram_009d3e38 != 1) {
		          DAT_ram_00a5a162 = '\x01';
		          goto code_r0x811d3c54;
		        }
		code_r0x811d3cb3:
		        DAT_ram_009d3e38 = 0;
		        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x811d3fca;
		      }
		code_r0x811d3c54:
		      if (*(int *)(Gameplay_Inventory_Model_InventoryConstants_TypeInfo + 0x74) == 0) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vi
		                  (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                   Gameplay_Inventory_Model_InventoryConstants_TypeInfo);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x811d3cb3;
		      }
		    } while (iVar10 < *(int *)(*(int *)(Gameplay_Inventory_Model_InventoryConstants_TypeInfo + 0x5c)
		                              + 4));
		    param1[0xf] = param1[0xf] + 1;
		    iVar8 = Method_System_Collections_Generic_List_int__Add__;
		    if (piVar1 != (int *)0x0) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_viiii
		                (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x264,param1[6],iVar10,piVar1,
		                 Method_System_Collections_Generic_SortedList_int__ArtifactData__set_Item__);
		      iVar10 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar10 == 1) {
		        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x811d3fca;
		      }
		      iVar5 = piVar1[3];
		      DAT_ram_009d3e38 = 0;
		      iVar8 = import::env::invoke_iiii
		                        (s_struct_Uniforms___color__array<v_ram_00000aff + 0x3c1,param1[9],
		                         *(undefined4 *)(iVar5 + 0xc),
		                         Method_System_Collections_Generic_Dictionary_uint__List_ArtifactData___ContainsKey__
		                        );
		      iVar10 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar10 == 1) {
		        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x811d3fca;
		      }
		      if (iVar8 == 0) {
		        param3 = *(undefined4 *)(iVar5 + 0xc);
		        iVar10 = param1[9];
		        DAT_ram_009d3e38 = 0;
		        uVar4 = import::env::invoke_ii
		                          (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                           System_Collections_Generic_List_ArtifactData__TypeInfo);
		        if (DAT_ram_009d3e38 != 1) {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vii
		                    (s_struct_Uniforms___color__array<v_ram_00000aff + 0x252,uVar4,
		                     Method_System_Collections_Generic_List_ArtifactData___ctor__);
		          if (DAT_ram_009d3e38 != 1) {
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_viiii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x22c,iVar10,param3,uVar4,
		                       Method_System_Collections_Generic_Dictionary_uint__List_ArtifactData___set_Item__
		                      );
		            if (DAT_ram_009d3e38 != 1) goto code_r0x811d3ec9;
		          }
		        }
		        DAT_ram_009d3e38 = 0;
		        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x811d3fca;
		      }
		code_r0x811d3ec9:
		      DAT_ram_009d3e38 = 0;
		      iVar5 = import::env::invoke_iiii
		                        (s_struct_Uniforms___color__array<v_ram_00000aff + 0x22b,param1[9],
		                         *(undefined4 *)(iVar5 + 0xc),
		                         Method_System_Collections_Generic_Dictionary_uint__List_ArtifactData___get_Item__
		                        );
		      iVar8 = DAT_ram_009d3e38;
		      iVar10 = Method_System_Collections_Generic_List_ArtifactData__Add__;
		      DAT_ram_009d3e38 = 0;
		      if (iVar8 == 1) {
		        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x811d3fca;
		      }
		      *(int *)(iVar5 + 0x10) = *(int *)(iVar5 + 0x10) + 1;
		      uVar12 = *(uint *)(iVar5 + 0xc);
		      if (uVar12 < *(uint *)(*(int *)(iVar5 + 8) + 0xc)) {
		        *(uint *)(iVar5 + 0xc) = uVar12 + 1;
		        *(int **)(*(int *)(iVar5 + 8) + uVar12 * 4 + 0x10) = piVar1;
		      }
		      else {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar5,piVar1,
		                   *(undefined4 *)(*(int *)(*(int *)(iVar10 + 0x10) + 0x60) + 0x38));
		        iVar10 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar10 == 1) {
		          uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x811d3fca;
		        }
		      }
		      goto code_r0x811d3546;
		    }
		    iVar5 = param1[0xd];
		    *(int *)(iVar5 + 0x10) = *(int *)(iVar5 + 0x10) + 1;
		    uVar12 = *(uint *)(iVar5 + 0xc);
		    if (uVar12 < *(uint *)(*(int *)(iVar5 + 8) + 0xc)) {
		      *(uint *)(iVar5 + 0xc) = uVar12 + 1;
		      *(int *)(*(int *)(iVar5 + 8) + uVar12 * 4 + 0x10) = iVar10;
		      goto code_r0x811d3546;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00000aff + 0x9a,iVar5,iVar10,
		               *(undefined4 *)(*(int *)(*(int *)(iVar8 + 0x10) + 0x60) + 0x38));
		    iVar10 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar10 != 1);
		  uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x811d3fca:
		  iVar10 = global_1;
		  iVar8 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar10 == iVar8) {
		    piVar1 = (int *)import::env::__cxa_begin_catch(uVar4);
		    local_10 = *piVar1;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar10 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar10 != 1) {
		code_r0x811d4013:
		      DAT_ram_009d3e38 = 0;
		      piVar1 = *local_c;
		      if (piVar1 != (int *)0x0) {
		        uVar12 = 0;
		        iVar10 = *piVar1;
		        if (*(ushort *)(iVar10 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar10 + 0x58) + uVar12 * 8)) {
		              puVar2 = (uint *)(iVar10 + *(int *)(*(int *)(iVar10 + 0x58) + uVar12 * 8 + 4) * 8 +
		                               0xc0);
		              goto code_r0x811d408e;
		            }
		            uVar12 = uVar12 + 1;
		          } while (*(ushort *)(iVar10 + 0xb6) != uVar12);
		        }
		        puVar2 = (uint *)func_ii_1080(piVar1,System_IDisposable_TypeInfo,0);
		code_r0x811d408e:
		        (**(code **)((ulonglong)*puVar2 * 4))(piVar1,puVar2[1]);
		      }
		      if (local_10 == 0) {
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(local_10);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar4 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001f04 + 0x265,&local_10);
		  iVar10 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar10 == 1) {
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__resumeException(uVar4);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06002911 RID: 10513 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002911")]
		[Address(RVA = "0x7A29", Offset = "0x7A29", VA = "0x7A29")]
		private void UpdateCache()
		{
		/* --- GHIDRA: UpdateCache ---
		void Gameplay_Inventory_Model_InventoryBaseModel__UpdateCache
		               (int param1,int param2,int param3,undefined4 param4)
		
		{
		  int iVar1;
		  int *piVar2;
		  int param1_00;
		  uint uVar3;
		  
		  if (DAT_ram_00a5a147 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_int__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_SortedList_int__ArtifactData__set_Item__);
		    DAT_ram_00a5a147 = '\x01';
		  }
		  if (DAT_ram_00a5a163 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Inventory_Model_InventoryConstants_TypeInfo);
		    DAT_ram_00a5a163 = '\x01';
		  }
		  if (*(int *)(Gameplay_Inventory_Model_InventoryConstants_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Inventory_Model_InventoryConstants_TypeInfo);
		  }
		  piVar2 = *(int **)(Gameplay_Inventory_Model_InventoryConstants_TypeInfo + 0x5c);
		  if (*piVar2 <= param2) {
		    if (*(int *)(Gameplay_Inventory_Model_InventoryConstants_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_Inventory_Model_InventoryConstants_TypeInfo);
		      piVar2 = *(int **)(Gameplay_Inventory_Model_InventoryConstants_TypeInfo + 0x5c);
		    }
		    if (param2 < piVar2[1]) {
		      *(int *)(param1 + 0x40) = *(int *)(param1 + 0x40) + 1;
		      Core_Data_ArtikulData__get_IsEternal
		                (*(undefined4 *)(param1 + 0x10),param2,param3,
		                 Method_System_Collections_Generic_SortedList_int__ArtifactData__set_Item__);
		      iVar1 = Method_System_Collections_Generic_List_int__Add__;
		      if (param3 == 0) {
		        param1_00 = *(int *)(param1 + 0x30);
		        *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		        uVar3 = *(uint *)(param1_00 + 0xc);
		        if (uVar3 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		          *(uint *)(param1_00 + 0xc) = uVar3 + 1;
		          *(int *)(*(int *)(param1_00 + 8) + uVar3 * 4 + 0x10) = param2;
		          return;
		        }
		        System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                  (param1_00,param2,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38))
		        ;
		      }
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002912 RID: 10514 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002912")]
		[Address(RVA = "0x7A2A", Offset = "0x7A2A", VA = "0x7A2A", Slot = "6")]
		protected virtual void HandleBagSlot(int slotId, ArtifactData artifactData)
		{
		/* --- GHIDRA: HandleBagSlot ---
		void Gameplay_Inventory_Model_InventoryBaseModel__HandleBagSlot
		               (int *param1,undefined4 param2,int param3,undefined4 param4)
		
		{
		  int iVar1;
		  undefined4 param3_00;
		  
		  iVar1 = 0;
		  if (DAT_ram_00a5a148 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_SortedList_int__ArtifactData__set_Item__);
		    DAT_ram_00a5a148 = '\x01';
		  }
		  if (param3 != 0) {
		    iVar1 = param1[0x12];
		    param3_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf8) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0xfc));
		    iVar1 = func_ii_8553(iVar1,param3,param3_00,0);
		    Core_Cache_ArtifactCache__GetArtifact(iVar1,param2,0);
		    *(undefined4 *)(iVar1 + 0x80) = 1;
		  }
		  Core_Data_ArtikulData__get_IsEternal
		            (param1[3],param2,iVar1,
		             Method_System_Collections_Generic_SortedList_int__ArtifactData__set_Item__);
		  return;
		}
		*/

		}

		// Token: 0x06002913 RID: 10515 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002913")]
		[Address(RVA = "0x7A2B", Offset = "0x7A2B", VA = "0x7A2B")]
		private void SetArtifact(int slotId, ArtifactInfo artifactInfo)
		{
		/* --- GHIDRA: SetArtifact ---
		void Gameplay_Inventory_Model_InventoryBaseModel__SetArtifact
		               (int *param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 *puVar3;
		  undefined4 param4;
		  undefined4 uVar4;
		  int iVar5;
		  int *piVar6;
		  int *piVar7;
		  int iVar8;
		  int local_c;
		  int **local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a5a149 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_IEnumerable_ProtoGetUserArtifactsAns_Types_UserArtifact__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_IEnumerator_ProtoGetUserArtifactsAns_Types_UserArtifact__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    DAT_ram_00a5a149 = '\x01';
		  }
		  iVar8 = *param2;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (System_Collections_Generic_IEnumerable_ProtoGetUserArtifactsAns_Types_UserArtifact__TypeInfo
		          == *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar8 + *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x811d43ae;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,
		                                System_Collections_Generic_IEnumerable_ProtoGetUserArtifactsAns_Types_UserArtifact__TypeInfo
		                                ,0);
		code_r0x811d43ae:
		  local_4 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  local_c = 0;
		  local_8 = &local_4;
		  do {
		    piVar6 = local_4;
		    iVar8 = *local_4;
		    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar7 = (int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar7) {
		          puVar3 = (undefined4 *)(iVar8 + piVar7[1] * 8 + 0xc0);
		          goto code_r0x811d447c;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = (uint *)0x0;
		    puVar3 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,0);
		    if (DAT_ram_009d3e38 == (uint *)0x1) {
		code_r0x811d470d:
		      DAT_ram_009d3e38 = (uint *)0x0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x811d4715;
		    }
		code_r0x811d447c:
		    DAT_ram_009d3e38 = (uint *)0x0;
		    iVar8 = import::env::invoke_iii(*puVar3,piVar6,puVar3[1]);
		    piVar6 = local_4;
		    if (DAT_ram_009d3e38 == (uint *)0x1) goto code_r0x811d470d;
		    if (iVar8 == 0) {
		      iVar8 = 0;
		      puVar2 = DAT_ram_009d3e38;
		      goto code_r0x811d475e;
		    }
		    iVar8 = *local_4;
		    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar7 = (int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8);
		        if (System_Collections_Generic_IEnumerator_ProtoGetUserArtifactsAns_Types_UserArtifact__TypeInfo
		            == *piVar7) {
		          puVar3 = (undefined4 *)(iVar8 + piVar7[1] * 8 + 0xc0);
		          goto code_r0x811d4556;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = (uint *)0x0;
		    puVar3 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_Generic_IEnumerator_ProtoGetUserArtifactsAns_Types_UserArtifact__TypeInfo
		                        ,0);
		    if (DAT_ram_009d3e38 == (uint *)0x1) {
		code_r0x811d46f9:
		      DAT_ram_009d3e38 = (uint *)0x0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x811d4715;
		    }
		code_r0x811d4556:
		    DAT_ram_009d3e38 = (uint *)0x0;
		    iVar8 = import::env::invoke_iii(*puVar3,piVar6,puVar3[1]);
		    if (DAT_ram_009d3e38 == (uint *)0x1) goto code_r0x811d46f9;
		    iVar5 = *(int *)(iVar8 + 0x10);
		    uVar4 = *(undefined4 *)(iVar8 + 0xc);
		    if (DAT_ram_00a5a148 == '\0') {
		      DAT_ram_009d3e38 = (uint *)0x0;
		      import::env::invoke_vi
		                (0x7ff,&Method_System_Collections_Generic_SortedList_int__ArtifactData__set_Item__);
		      if (DAT_ram_009d3e38 == (uint *)0x1) break;
		      DAT_ram_00a5a148 = '\x01';
		    }
		    if (iVar5 == 0) {
		      iVar8 = 0;
		    }
		    else {
		      iVar8 = param1[0x12];
		      DAT_ram_009d3e38 = (uint *)0x0;
		      param4 = import::env::invoke_iii
		                         (*(undefined4 *)(*param1 + 0xf8),param1,*(undefined4 *)(*param1 + 0xfc));
		      if (DAT_ram_009d3e38 == (uint *)0x1) break;
		      DAT_ram_009d3e38 = (uint *)0x0;
		      iVar8 = import::env::invoke_iiiii
		                        (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x266,iVar8,iVar5,param4,
		                         0);
		      if (DAT_ram_009d3e38 == (uint *)0x1) break;
		      DAT_ram_009d3e38 = (uint *)0x0;
		      import::env::invoke_viii
		                (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x267,iVar8,uVar4,0);
		      if (DAT_ram_009d3e38 == (uint *)0x1) break;
		      *(undefined4 *)(iVar8 + 0x80) = 1;
		    }
		    DAT_ram_009d3e38 = (uint *)0x0;
		    import::env::invoke_viiii
		              (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x264,param1[3],uVar4,iVar8,
		               Method_System_Collections_Generic_SortedList_int__ArtifactData__set_Item__);
		  } while (DAT_ram_009d3e38 != (uint *)0x1);
		  DAT_ram_009d3e38 = (uint *)0x0;
		  uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x811d4715:
		  iVar8 = global_1;
		  iVar5 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar8 == iVar5) {
		    piVar6 = (int *)import::env::__cxa_begin_catch(uVar4);
		    iVar8 = *piVar6;
		    DAT_ram_009d3e38 = (uint *)0x0;
		    local_c = iVar8;
		    import::env::invoke_v(0x123);
		    puVar2 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = (uint *)0x0;
		    if (puVar2 != (uint *)0x1) {
		code_r0x811d475e:
		      piVar6 = local_4;
		      DAT_ram_009d3e38 = (uint *)0x0;
		      if (local_4 != (int *)0x0) {
		        uVar1 = 0;
		        iVar5 = *local_4;
		        if (*(ushort *)(iVar5 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		              puVar2 = (uint *)(iVar5 + *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x811d47d6;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		        }
		        puVar2 = (uint *)func_ii_1080(local_4,System_IDisposable_TypeInfo,0);
		code_r0x811d47d6:
		        (**(code **)((ulonglong)*puVar2 * 4))(piVar6,puVar2[1]);
		      }
		      if (iVar8 == 0) {
		        Gameplay_Inventory_Model_InventoryBaseModel__UpdateFreshCache(param1,puVar2);
		        Gameplay_Inventory_Model_InventoryBaseModel__GetFirstEmptySlot(param1,puVar2);
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar8);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar4 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = (uint *)0x0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001f04 + 0x268,&local_c);
		  iVar8 = (int)DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = (uint *)0x0;
		  if (iVar8 == 1) {
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__resumeException(uVar4);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06002914 RID: 10516 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002914")]
		[Address(RVA = "0x7A2C", Offset = "0x7A2C", VA = "0x7A2C")]
		public void ParseSlotChanges(IList<ProtoGetUserArtifactsAns.Types.UserArtifact> changes)
		{
		/* --- GHIDRA: ParseSlotChanges ---
		uint Gameplay_Inventory_Model_InventoryBaseModel__ParseSlotChanges
		               (int param1,int param2,undefined4 *param3,undefined4 param4)
		
		{
		  int iVar1;
		  uint uVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  undefined4 uVar5;
		  int iVar6;
		  int *param1_00;
		  int *piVar7;
		  int iVar8;
		  int param2_00;
		  int *piVar9;
		  int iVar10;
		  uint uVar11;
		  
		  iVar1 = 0;
		  param2_00 = 0;
		  uVar2 = 0;
		  if (DAT_ram_00a5a14e == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Core_Gameplay_Managers_Requirements_IRequirementValidator_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_uint__get_Count__);
		    Mono_Security_ASN1__get_Item(&Method_Google_Protobuf_Collections_RepeatedField_uint__get_Item__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_SortedList_int__ArtifactData__get_Item__);
		    DAT_ram_00a5a14e = '\x01';
		  }
		  *param3 = 0;
		  iVar6 = *(int *)(*(int *)(*(int *)(param2 + 0xc) + 0x14) + 0xc);
		  if (0 < iVar6) {
		    uVar2 = 1;
		    do {
		      uVar3 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                        (*(undefined4 *)(*(int *)(param2 + 0xc) + 0x14),param2_00,
		                         Method_Google_Protobuf_Collections_RepeatedField_uint__get_Item__);
		      *param3 = uVar3;
		      param1_00 = *(int **)(param1 + 0x50);
		      piVar7 = *(int **)(param1 + 0x4c);
		      iVar8 = *piVar7;
		      if (*(ushort *)(iVar8 + 0xb6) != 0) {
		        uVar11 = 0;
		        do {
		          piVar9 = (int *)(*(int *)(iVar8 + 0x58) + uVar11 * 8);
		          if (Core_Dict_IDictProvider_TypeInfo == *piVar9) {
		            puVar4 = (uint *)(piVar9[1] * 8 + iVar8 + 0xd0);
		            goto code_r0x811d4f01;
		          }
		          uVar11 = uVar11 + 1;
		        } while (*(ushort *)(iVar8 + 0xb6) != uVar11);
		      }
		      puVar4 = (uint *)func_ii_1080(piVar7,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x811d4f01:
		      uVar5 = (**(code **)((ulonglong)*puVar4 * 4))(piVar7,puVar4[1]);
		      iVar8 = Core_Extensions_Dict_DictExt__GetAccountOptionsDicByOptionId(uVar5,uVar3,0);
		      uVar3 = *(undefined4 *)(iVar8 + 0x18);
		      uVar5 = *(undefined4 *)(param1 + 8);
		      iVar8 = *param1_00;
		      if (*(ushort *)(iVar8 + 0xb6) != 0) {
		        uVar11 = 0;
		        do {
		          piVar7 = (int *)(*(int *)(iVar8 + 0x58) + uVar11 * 8);
		          if (Core_Gameplay_Managers_Requirements_IRequirementValidator_TypeInfo == *piVar7) {
		            puVar4 = (uint *)(piVar7[1] * 8 + iVar8 + 0xd0);
		            goto code_r0x811d4f91;
		          }
		          uVar11 = uVar11 + 1;
		        } while (*(ushort *)(iVar8 + 0xb6) != uVar11);
		      }
		      puVar4 = (uint *)func_ii_1080(param1_00,
		                                    Core_Gameplay_Managers_Requirements_IRequirementValidator_TypeInfo
		                                    ,2);
		code_r0x811d4f91:
		      iVar8 = (**(code **)((ulonglong)*puVar4 * 4))(param1_00,uVar3,uVar5,puVar4[1]);
		      if (iVar8 != 0) {
		        iVar8 = func_ii_8547(*(undefined4 *)(param1 + 0xc),*param3,
		                             Method_System_Collections_Generic_SortedList_int__ArtifactData__get_Item__
		                            );
		        if (iVar8 == 0) {
		          return uVar2;
		        }
		        iVar10 = iVar1;
		        if (iVar1 == 0) {
		          iVar10 = iVar8;
		        }
		        iVar1 = iVar8;
		        if (*(longlong *)(iVar10 + 0x60) <= *(longlong *)(iVar8 + 0x60)) {
		          iVar1 = iVar10;
		        }
		      }
		      param2_00 = param2_00 + 1;
		      uVar2 = (uint)(param2_00 < iVar6);
		    } while (param2_00 != iVar6);
		    if (iVar1 != 0) {
		      *param3 = *(undefined4 *)(iVar1 + 0x7c);
		    }
		  }
		  return uVar2;
		}
		*/

		/* --- GHIDRA: ParseSlotChanges ---
		uint Gameplay_Inventory_Model_InventoryBaseModel__ParseSlotChanges
		               (int param1,int param2,undefined4 *param3,undefined4 param4)
		
		{
		  int iVar1;
		  uint uVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  undefined4 uVar5;
		  int iVar6;
		  int *param1_00;
		  int *piVar7;
		  int iVar8;
		  int param2_00;
		  int *piVar9;
		  int iVar10;
		  uint uVar11;
		  
		  iVar1 = 0;
		  param2_00 = 0;
		  uVar2 = 0;
		  if (DAT_ram_00a5a14e == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Core_Gameplay_Managers_Requirements_IRequirementValidator_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_uint__get_Count__);
		    Mono_Security_ASN1__get_Item(&Method_Google_Protobuf_Collections_RepeatedField_uint__get_Item__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_SortedList_int__ArtifactData__get_Item__);
		    DAT_ram_00a5a14e = '\x01';
		  }
		  *param3 = 0;
		  iVar6 = *(int *)(*(int *)(*(int *)(param2 + 0xc) + 0x14) + 0xc);
		  if (0 < iVar6) {
		    uVar2 = 1;
		    do {
		      uVar3 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                        (*(undefined4 *)(*(int *)(param2 + 0xc) + 0x14),param2_00,
		                         Method_Google_Protobuf_Collections_RepeatedField_uint__get_Item__);
		      *param3 = uVar3;
		      param1_00 = *(int **)(param1 + 0x50);
		      piVar7 = *(int **)(param1 + 0x4c);
		      iVar8 = *piVar7;
		      if (*(ushort *)(iVar8 + 0xb6) != 0) {
		        uVar11 = 0;
		        do {
		          piVar9 = (int *)(*(int *)(iVar8 + 0x58) + uVar11 * 8);
		          if (Core_Dict_IDictProvider_TypeInfo == *piVar9) {
		            puVar4 = (uint *)(piVar9[1] * 8 + iVar8 + 0xd0);
		            goto code_r0x811d4f01;
		          }
		          uVar11 = uVar11 + 1;
		        } while (*(ushort *)(iVar8 + 0xb6) != uVar11);
		      }
		      puVar4 = (uint *)func_ii_1080(piVar7,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x811d4f01:
		      uVar5 = (**(code **)((ulonglong)*puVar4 * 4))(piVar7,puVar4[1]);
		      iVar8 = Core_Extensions_Dict_DictExt__GetAccountOptionsDicByOptionId(uVar5,uVar3,0);
		      uVar3 = *(undefined4 *)(iVar8 + 0x18);
		      uVar5 = *(undefined4 *)(param1 + 8);
		      iVar8 = *param1_00;
		      if (*(ushort *)(iVar8 + 0xb6) != 0) {
		        uVar11 = 0;
		        do {
		          piVar7 = (int *)(*(int *)(iVar8 + 0x58) + uVar11 * 8);
		          if (Core_Gameplay_Managers_Requirements_IRequirementValidator_TypeInfo == *piVar7) {
		            puVar4 = (uint *)(piVar7[1] * 8 + iVar8 + 0xd0);
		            goto code_r0x811d4f91;
		          }
		          uVar11 = uVar11 + 1;
		        } while (*(ushort *)(iVar8 + 0xb6) != uVar11);
		      }
		      puVar4 = (uint *)func_ii_1080(param1_00,
		                                    Core_Gameplay_Managers_Requirements_IRequirementValidator_TypeInfo
		                                    ,2);
		code_r0x811d4f91:
		      iVar8 = (**(code **)((ulonglong)*puVar4 * 4))(param1_00,uVar3,uVar5,puVar4[1]);
		      if (iVar8 != 0) {
		        iVar8 = func_ii_8547(*(undefined4 *)(param1 + 0xc),*param3,
		                             Method_System_Collections_Generic_SortedList_int__ArtifactData__get_Item__
		                            );
		        if (iVar8 == 0) {
		          return uVar2;
		        }
		        iVar10 = iVar1;
		        if (iVar1 == 0) {
		          iVar10 = iVar8;
		        }
		        iVar1 = iVar8;
		        if (*(longlong *)(iVar10 + 0x60) <= *(longlong *)(iVar8 + 0x60)) {
		          iVar1 = iVar10;
		        }
		      }
		      param2_00 = param2_00 + 1;
		      uVar2 = (uint)(param2_00 < iVar6);
		    } while (param2_00 != iVar6);
		    if (iVar1 != 0) {
		      *param3 = *(undefined4 *)(iVar1 + 0x7c);
		    }
		  }
		  return uVar2;
		}
		*/

		}

		// Token: 0x06002915 RID: 10517 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002915")]
		[Address(RVA = "0x7A2D", Offset = "0x7A2D", VA = "0x7A2D")]
		public void ParseSlotChanges(IList<UserArtifact> changes)
		{
		}

		// Token: 0x06002916 RID: 10518 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002916")]
		[Address(RVA = "0x1F8F", Offset = "0x1F8F", VA = "0x1F8F")]
		public ArtifactData GetArtifactById(ulong artifactId)
		{
		/* --- GHIDRA: GetArtifactById ---
		uint Gameplay_Inventory_Model_InventoryBaseModel__GetArtifactById(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  return (uint)(0 < iVar1);
		}
		*/

			return null;
		}

		// Token: 0x06002917 RID: 10519 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002917")]
		[Address(RVA = "0x1DAC", Offset = "0x1DAC", VA = "0x1DAC")]
		public ArtifactData GetArtifactBySlotId(int slotId)
		{
			return null;
		}

		// Token: 0x06002918 RID: 10520 RVA: 0x00007C80 File Offset: 0x00005E80
		[Token(Token = "0x6002918")]
		[Address(RVA = "0x445A", Offset = "0x445A", VA = "0x445A")]
		public uint GetCount(uint artikulId)
		{
		/* --- GHIDRA: GetCount ---
		int Gameplay_Inventory_Model_InventoryBaseModel__GetCount(int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param3_00;
		  undefined4 uVar2;
		  undefined4 *puVar3;
		  undefined1 auStack_10 [8];
		  int local_8;
		  undefined4 local_4;
		  
		  iVar1 = 0;
		  if (DAT_ram_00a5ace8 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Extensions_Dict_DictExt_BinarySearch_ArtikulDic__uint___);
		    Mono_Security_ASN1__get_Item(&System_Func_ArtikulDic__uint__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Extensions_Dict_NotFoundInDictsUtil_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ArtikulDic__Add__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Extensions_Dict_DictExt___c__GetArtikul_b__3_0__);
		    Mono_Security_ASN1__get_Item(&Core_Extensions_Dict_DictExt___c_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_11315);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3313);
		    DAT_ram_00a5ace8 = '\x01';
		  }
		  if (param2 != 0) {
		    local_4 = *(undefined4 *)(param1 + 0x40);
		    if (*(int *)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Extensions_Dict_DictExt___c_TypeInfo);
		    }
		    puVar3 = *(undefined4 **)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x5c);
		    iVar1 = puVar3[2];
		    if (iVar1 == 0) {
		      if (*(int *)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_Extensions_Dict_DictExt___c_TypeInfo);
		        puVar3 = *(undefined4 **)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x5c);
		      }
		      uVar2 = *puVar3;
		      iVar1 = unnamed_function_1417(System_Func_ArtikulDic__uint__TypeInfo);
		      System_Collections_Generic_Dictionary_KeyCollection_uint__object___GetEnumerator
		                (iVar1,uVar2,Method_Core_Extensions_Dict_DictExt___c__GetArtikul_b__3_0__,0);
		      *(int *)(*(int *)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x5c) + 8) = iVar1;
		    }
		    iVar1 = func_ii_8597(&local_4,iVar1,param2,
		                         Method_Core_Extensions_Dict_DictExt_BinarySearch_ArtikulDic__uint___);
		    if (iVar1 == 0) {
		      local_8 = param2;
		      param3_00 = func_ii_1081(DAT_ram_00a66958,&local_8);
		      uVar2 = StringLiteral_3313;
		      if (DAT_ram_00a5ace5 == '\0') {
		        Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		        Mono_Security_ASN1__get_Item(&StringLiteral_18888);
		        DAT_ram_00a5ace5 = '\x01';
		      }
		      uVar2 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                        (StringLiteral_18888,uVar2,param3_00,0);
		      if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		        func_ii_306000(OKG_Logs_Debug_TypeInfo);
		      }
		      func_ii_7830(uVar2,0);
		      if (*(int *)(Core_Extensions_Dict_NotFoundInDictsUtil_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_Extensions_Dict_NotFoundInDictsUtil_TypeInfo);
		      }
		      iVar1 = Core_Extensions_Dict_NewResourceOptionsDicExt__GetEventPromoDescription
		                        (param2,StringLiteral_11315,auStack_10);
		      func_ii_6441(*(undefined4 *)(param1 + 0x40),iVar1,
		                   Method_Google_Protobuf_Collections_RepeatedField_ArtikulDic__Add__);
		    }
		  }
		  return iVar1;
		}
		*/

			return 0U;
		}

		// Token: 0x06002919 RID: 10521 RVA: 0x00007C98 File Offset: 0x00005E98
		[Token(Token = "0x6002919")]
		[Address(RVA = "0x7A2E", Offset = "0x7A2E", VA = "0x7A2E")]
		public bool TryGetFitSlotId(ArtifactData artifact, out int slotId)
		{
		/* --- GHIDRA: TryGetFitSlotId ---
		longlong Gameplay_Inventory_Model_InventoryBaseModel__TryGetFitSlotId(int *param1,undefined4 param2)
		
		{
		  uint *puVar1;
		  undefined4 uVar2;
		  longlong lVar3;
		  longlong lVar4;
		  longlong lVar5;
		  int *piVar6;
		  int iVar7;
		  uint uVar8;
		  
		  if (DAT_ram_00a5a150 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27288);
		    Mono_Security_ASN1__get_Item(&StringLiteral_21133);
		    DAT_ram_00a5a150 = '\x01';
		  }
		  piVar6 = (int *)param1[0x13];
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    uVar8 = 0;
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar8 * 8)) {
		        puVar1 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar8 * 8 + 4) * 8 + iVar7 + 0xd0);
		        goto code_r0x811d28bf;
		      }
		      uVar8 = uVar8 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar8);
		  }
		  puVar1 = (uint *)func_ii_1080(piVar6,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x811d28bf:
		  uVar8 = 0;
		  uVar2 = (**(code **)((ulonglong)*puVar1 * 4))(piVar6,puVar1[1]);
		  lVar3 = Core_Extensions_Dict_DictExt__GetDoubleParameter(uVar2,StringLiteral_21133,0);
		  piVar6 = (int *)param1[0x13];
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar8 * 8)) {
		        puVar1 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar8 * 8 + 4) * 8 + iVar7 + 0xd0);
		        goto code_r0x811d2952;
		      }
		      uVar8 = uVar8 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar8);
		  }
		  puVar1 = (uint *)func_ii_1080(piVar6,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x811d2952:
		  uVar2 = (**(code **)((ulonglong)*puVar1 * 4))(piVar6,puVar1[1]);
		  lVar4 = Core_Extensions_Dict_DictExt__GetDoubleParameter(uVar2,StringLiteral_27288,0);
		  lVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x108) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x10c));
		  return lVar5 + lVar3 * lVar4;
		}
		*/

			return default(bool);
		}

		// Token: 0x0600291A RID: 10522 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600291A")]
		[Address(RVA = "0x2173", Offset = "0x2173", VA = "0x2173")]
		public void SetArtifactFavorite(ArtifactData artifactData, bool favorite)
		{
		}

		// Token: 0x0600291B RID: 10523 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600291B")]
		[Address(RVA = "0x1F93", Offset = "0x1F93", VA = "0x1F93")]
		public void SetArtifactFresh(ArtifactData artifactData, bool fresh)
		{
		}

		// Token: 0x0600291C RID: 10524 RVA: 0x00007CB0 File Offset: 0x00005EB0
		[Token(Token = "0x600291C")]
		[Address(RVA = "0x7A2F", Offset = "0x7A2F", VA = "0x7A2F")]
		public long GetMaxChestSlots()
		{
		/* --- GHIDRA: GetMaxChestSlots ---
		undefined4
		Gameplay_Inventory_Model_InventoryBaseModel__GetMaxChestSlots
		          (int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *param3_00;
		  undefined4 uVar2;
		  int *param1_00;
		  int iVar3;
		  
		  if (DAT_ram_00a5a151 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    DAT_ram_00a5a151 = '\x01';
		  }
		  param1_00 = *(int **)(param1 + 0x4c);
		  iVar3 = *param1_00;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        param3_00 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0xd0);
		        goto code_r0x811d514b;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  param3_00 = (uint *)func_ii_1080(param1_00,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x811d514b:
		  uVar2 = (**(code **)((ulonglong)*param3_00 * 4))(param1_00,param3_00[1]);
		  uVar2 = func_ii_7960(param2,uVar2,param3_00);
		  return uVar2;
		}
		*/

			return 0L;
		}

		// Token: 0x170007D0 RID: 2000
		// (get) Token: 0x0600291D RID: 10525
		[Token(Token = "0x170007D0")]
		public abstract UserData OwnerUser { [Token(Token = "0x600291D")] get; }

		// Token: 0x0600291E RID: 10526
		[Token(Token = "0x600291E")]
		public abstract bool CanFitTwoHandedWeapon(out int occupiedSlots);

		// Token: 0x0600291F RID: 10527
		[Token(Token = "0x600291F")]
		protected abstract long GetExtraSlotsCount();

		// Token: 0x06002920 RID: 10528
		[Token(Token = "0x6002920")]
		protected abstract bool IsEquipmentSlot(int slotId);

		// Token: 0x06002921 RID: 10529
		[Token(Token = "0x6002921")]
		public abstract ResourceSet GetSlotPrice(uint slotCount);

		// Token: 0x06002922 RID: 10530
		[Token(Token = "0x6002922")]
		public abstract IList<ArtifactData> GetComparableItems();

		// Token: 0x06002923 RID: 10531
		[Token(Token = "0x6002923")]
		public abstract bool IsArtifactCanBeEquipped(ArtifactData artifact);

		// Token: 0x040016B0 RID: 5808
		[Token(Token = "0x40016B0")]
		[FieldOffset(Offset = "0xC")]
		protected readonly SortedList<int, ArtifactData> _artifactsBySlotId;

		// Token: 0x040016B1 RID: 5809
		[Token(Token = "0x40016B1")]
		[FieldOffset(Offset = "0x10")]
		protected SortedList<int, ArtifactData> _bagArtifacts;

		// Token: 0x040016B2 RID: 5810
		[Token(Token = "0x40016B2")]
		[FieldOffset(Offset = "0x14")]
		private readonly Dictionary<uint, uint> _artikulCount;

		// Token: 0x040016B3 RID: 5811
		[Token(Token = "0x40016B3")]
		[FieldOffset(Offset = "0x18")]
		private readonly SortedList<int, ArtifactData> _chestArtifacts;

		// Token: 0x040016B4 RID: 5812
		[Token(Token = "0x40016B4")]
		[FieldOffset(Offset = "0x1C")]
		private readonly Dictionary<ulong, ArtifactData> _favorites;

		// Token: 0x040016B5 RID: 5813
		[Token(Token = "0x40016B5")]
		[FieldOffset(Offset = "0x20")]
		private readonly Dictionary<ulong, ArtifactData> _fresh;

		// Token: 0x040016B6 RID: 5814
		[Token(Token = "0x40016B6")]
		[FieldOffset(Offset = "0x24")]
		private readonly Dictionary<uint, List<ArtifactData>> _chestArtifactsByArtikulType;

		// Token: 0x040016B7 RID: 5815
		[Token(Token = "0x40016B7")]
		[FieldOffset(Offset = "0x28")]
		private readonly Dictionary<ulong, ArtifactData> _artifactsByArtifactId;

		// Token: 0x040016B8 RID: 5816
		[Token(Token = "0x40016B8")]
		[FieldOffset(Offset = "0x2C")]
		private readonly Dictionary<int, ArtifactData> _equipmentCache;

		// Token: 0x040016B9 RID: 5817
		[Token(Token = "0x40016B9")]
		[FieldOffset(Offset = "0x30")]
		private readonly List<int> _bagEmptySlots;

		// Token: 0x040016BA RID: 5818
		[Token(Token = "0x40016BA")]
		[FieldOffset(Offset = "0x34")]
		private readonly List<int> _chestEmptySlots;

		// Token: 0x040016BB RID: 5819
		[Token(Token = "0x40016BB")]
		[FieldOffset(Offset = "0x38")]
		private List<InventoryMetaFilterData> _artikulTypeFiltersCache;

		// Token: 0x040016BC RID: 5820
		[Token(Token = "0x40016BC")]
		[FieldOffset(Offset = "0x3C")]
		private int _chestTotalSlotsNum;

		// Token: 0x040016BD RID: 5821
		[Token(Token = "0x40016BD")]
		[FieldOffset(Offset = "0x40")]
		private int _bagTotalSlotsNum;

		// Token: 0x040016BE RID: 5822
		[Token(Token = "0x40016BE")]
		[FieldOffset(Offset = "0x44")]
		private int _equipTotalSlotsNum;

		// Token: 0x040016BF RID: 5823
		[Token(Token = "0x40016BF")]
		[FieldOffset(Offset = "0x48")]
		public readonly ArtifactCache ArtifactCache;

		// Token: 0x040016C0 RID: 5824
		[Token(Token = "0x40016C0")]
		[FieldOffset(Offset = "0x4C")]
		public readonly IDictProvider DictProvider;

		// Token: 0x040016C1 RID: 5825
		[Token(Token = "0x40016C1")]
		[FieldOffset(Offset = "0x50")]
		public readonly IRequirementValidator RequirementValidator;

		// Token: 0x040016C2 RID: 5826
		[Token(Token = "0x40016C2")]
		[FieldOffset(Offset = "0x54")]
		public readonly ToastController Toasts;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Equipment ---
		undefined4 Gameplay_Inventory_Model_InventoryBaseModel__get_Equipment(int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5a13e == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_int__get_Count__);
		    DAT_ram_00a5a13e = '\x01';
		  }
		  return *(undefined4 *)(*(int *)(param1 + 0x30) + 0xc);
		}
		*/


		/* --- GHIDRA: get_BagEmptySlotsNum ---
		undefined4
		Gameplay_Inventory_Model_InventoryBaseModel__get_BagEmptySlotsNum
		          (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5a13f == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Inventory_Model_InventoryConstants_TypeInfo);
		    DAT_ram_00a5a13f = '\x01';
		  }
		  if (*(int *)(Gameplay_Inventory_Model_InventoryConstants_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Inventory_Model_InventoryConstants_TypeInfo);
		  }
		  if (DAT_ram_00a5a1ff == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Inventory_Model_InventoryConstants_TypeInfo);
		    DAT_ram_00a5a1ff = '\x01';
		  }
		  if (*(int *)(Gameplay_Inventory_Model_InventoryConstants_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Inventory_Model_InventoryConstants_TypeInfo);
		  }
		  return *(undefined4 *)
		          (*(int *)(Gameplay_Inventory_Model_InventoryConstants_TypeInfo + 0x5c) + 0xc);
		}
		*/


		/* --- GHIDRA: get_EquipSlotsIds ---
		longlong Gameplay_Inventory_Model_InventoryBaseModel__get_EquipSlotsIds
		                   (int param1,undefined4 param2)
		
		{
		  return (longlong)*(int *)(param1 + 0x3c) +
		         (longlong)(*(int *)(param1 + 0x40) + *(int *)(param1 + 0x44));
		}
		*/


		/* --- GHIDRA: get_AvailableSlots ---
		longlong Gameplay_Inventory_Model_InventoryBaseModel__get_AvailableSlots
		                   (int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5a140 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_int__get_Count__);
		    DAT_ram_00a5a140 = '\x01';
		  }
		  return (longlong)*(int *)(*(int *)(param1 + 0x34) + 0xc);
		}
		*/


		/* --- GHIDRA: get_ChestEmptySlotsNum ---
		longlong Gameplay_Inventory_Model_InventoryBaseModel__get_ChestEmptySlotsNum
		                   (int param1,undefined4 param2)
		
		{
		  return (longlong)*(int *)(param1 + 0x3c);
		}
		*/


		/* --- GHIDRA: get_ChestTotalSlotsNum ---
		longlong Gameplay_Inventory_Model_InventoryBaseModel__get_ChestTotalSlotsNum
		                   (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a5a13e == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_int__get_Count__);
		    DAT_ram_00a5a13e = '\x01';
		  }
		  iVar1 = *(int *)(*(int *)(param1 + 0x30) + 0xc);
		  if (DAT_ram_00a5a140 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_int__get_Count__);
		    DAT_ram_00a5a140 = '\x01';
		  }
		  return (longlong)*(int *)(*(int *)(param1 + 0x34) + 0xc) + (longlong)iVar1;
		}
		*/


		/* --- GHIDRA: get_TotalEmptySlotsNum ---
		longlong Gameplay_Inventory_Model_InventoryBaseModel__get_TotalEmptySlotsNum
		                   (undefined4 param1,undefined4 param2)
		
		{
		  longlong lVar1;
		  int param2_00;
		  
		  if (DAT_ram_00a5a141 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Inventory_Model_InventoryConstants_TypeInfo);
		    DAT_ram_00a5a141 = '\x01';
		  }
		  if (*(int *)(Gameplay_Inventory_Model_InventoryConstants_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Inventory_Model_InventoryConstants_TypeInfo);
		  }
		  param2_00 = *(int *)(*(int *)(Gameplay_Inventory_Model_InventoryConstants_TypeInfo + 0x5c) + 4);
		  lVar1 = Gameplay_Inventory_Model_InventoryBaseModel__TryGetFitSlotId(param1,param2_00);
		  return lVar1 + (param2_00 + -1);
		}
		*/


		/* --- GHIDRA: get_TotalSlotsAvailable ---
		void Gameplay_Inventory_Model_InventoryBaseModel__get_TotalSlotsAvailable
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5,
		               undefined4 param6,undefined4 param7)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5a142 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_ulong__ArtifactData___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_int__ArtifactData___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__List_ArtifactData____ctor__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_Dictionary_uint__uint___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_uint__uint__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_int__ArtifactData__TypeInfo)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_Dictionary_ulong__ArtifactData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_Dictionary_uint__List_ArtifactData___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_int___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_int__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_SortedList_int__ArtifactData___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_SortedList_int__ArtifactData__TypeInfo)
		    ;
		    DAT_ram_00a5a142 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(System_Collections_Generic_SortedList_int__ArtifactData__TypeInfo);
		  System_Collections_Generic_SortedList_SortedListValueEnumerator___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType___get_Current
		            (uVar1,Method_System_Collections_Generic_SortedList_int__ArtifactData___ctor__);
		  *(undefined4 *)(param1 + 0xc) = uVar1;
		  uVar1 = unnamed_function_1417(System_Collections_Generic_SortedList_int__ArtifactData__TypeInfo);
		  System_Collections_Generic_SortedList_SortedListValueEnumerator___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType___get_Current
		            (uVar1,Method_System_Collections_Generic_SortedList_int__ArtifactData___ctor__);
		  *(undefined4 *)(param1 + 0x10) = uVar1;
		  uVar1 = unnamed_function_1417(System_Collections_Generic_Dictionary_uint__uint__TypeInfo);
		  System_Collections_Generic_List_GAFAnimationAssetInternal_KeyFrame____ctor
		            (uVar1,Method_System_Collections_Generic_Dictionary_uint__uint___ctor__);
		  *(undefined4 *)(param1 + 0x14) = uVar1;
		  uVar1 = unnamed_function_1417(System_Collections_Generic_SortedList_int__ArtifactData__TypeInfo);
		  System_Collections_Generic_SortedList_SortedListValueEnumerator___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType___get_Current
		            (uVar1,Method_System_Collections_Generic_SortedList_int__ArtifactData___ctor__);
		  *(undefined4 *)(param1 + 0x18) = uVar1;
		  uVar1 = unnamed_function_1417(System_Collections_Generic_Dictionary_ulong__ArtifactData__TypeInfo)
		  ;
		  System_Collections_Generic_Dictionary_ulong__ulong___set_Item
		            (uVar1,Method_System_Collections_Generic_Dictionary_ulong__ArtifactData___ctor__);
		  *(undefined4 *)(param1 + 0x1c) = uVar1;
		  uVar1 = unnamed_function_1417(System_Collections_Generic_Dictionary_ulong__ArtifactData__TypeInfo)
		  ;
		  System_Collections_Generic_Dictionary_ulong__ulong___set_Item
		            (uVar1,Method_System_Collections_Generic_Dictionary_ulong__ArtifactData___ctor__);
		  *(undefined4 *)(param1 + 0x20) = uVar1;
		  uVar1 = unnamed_function_1417
		                    (System_Collections_Generic_Dictionary_uint__List_ArtifactData___TypeInfo);
		  System_Collections_Generic_List_GAFAnimationAssetInternal_KeyFrame____ctor
		            (uVar1,Method_System_Collections_Generic_Dictionary_uint__List_ArtifactData____ctor__);
		  *(undefined4 *)(param1 + 0x24) = uVar1;
		  uVar1 = unnamed_function_1417(System_Collections_Generic_Dictionary_ulong__ArtifactData__TypeInfo)
		  ;
		  System_Collections_Generic_Dictionary_ulong__ulong___set_Item
		            (uVar1,Method_System_Collections_Generic_Dictionary_ulong__ArtifactData___ctor__);
		  *(undefined4 *)(param1 + 0x28) = uVar1;
		  uVar1 = unnamed_function_1417(System_Collections_Generic_Dictionary_int__ArtifactData__TypeInfo);
		  System_Collections_Generic_Dictionary_int__TMP_ResourceManager_FontAssetRef___set_Item
		            (uVar1,Method_System_Collections_Generic_Dictionary_int__ArtifactData___ctor__);
		  *(undefined4 *)(param1 + 0x2c) = uVar1;
		  uVar1 = unnamed_function_1417(System_Collections_Generic_List_int__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (uVar1,Method_System_Collections_Generic_List_int___ctor__);
		  *(undefined4 *)(param1 + 0x30) = uVar1;
		  uVar1 = unnamed_function_1417(System_Collections_Generic_List_int__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (uVar1,Method_System_Collections_Generic_List_int___ctor__);
		  *(undefined4 *)(param1 + 0x34) = uVar1;
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(param1,param6,0);
		  *(undefined4 *)(param1 + 0x50) = param4;
		  *(undefined4 *)(param1 + 0x48) = param3;
		  *(undefined4 *)(param1 + 0x54) = param2;
		  *(undefined4 *)(param1 + 0x4c) = param5;
		  return;
		}
		*/

}
