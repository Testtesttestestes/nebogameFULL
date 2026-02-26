using System;
using System.Collections.Generic;
using Core.Cache;
using Core.Data;
using Core.Dict;
using Core.Gameplay.Managers.Requirements;
using Il2CppDummyDll;
using Protocol.Common;
using Protocol.Dic;
using UI.Toast;

namespace Gameplay.Inventory.Model
{
	// Token: 0x020006A5 RID: 1701
	[Token(Token = "0x20006A5")]
	public class InventoryModel : InventoryBaseModel
	{
		// Token: 0x06002935 RID: 10549 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002935")]
		[Address(RVA = "0x7A3D", Offset = "0x7A3D", VA = "0x7A3D")]
		public InventoryModel(Antiq.Types.EffectsDic.Types.EffectID effectId, ToastController toasts, ArtifactCache artifactCache, IRequirementValidator requirementValidator, IDictProvider dictProvider, UserData user)
		{
		}

		// Token: 0x170007D8 RID: 2008
		// (get) Token: 0x06002936 RID: 10550 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170007D8")]
		public override UserData OwnerUser
		{
			[Token(Token = "0x6002936")]
			[Address(RVA = "0x7A3E", Offset = "0x7A3E", VA = "0x7A3E", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002937 RID: 10551 RVA: 0x00007D10 File Offset: 0x00005F10
		[Token(Token = "0x6002937")]
		[Address(RVA = "0x7A3F", Offset = "0x7A3F", VA = "0x7A3F", Slot = "8")]
		public override bool CanFitTwoHandedWeapon(out int occupiedSlots)
		{
		/* --- GHIDRA: CanFitTwoHandedWeapon ---
		undefined8
		Gameplay_Inventory_Model_InventoryModel__CanFitTwoHandedWeapon(int param1,undefined4 param2)
		
		{
		  undefined4 in_register_20000014;
		  uint *puVar1;
		  undefined4 uVar2;
		  int *piVar3;
		  int iVar4;
		  undefined8 uVar5;
		  uint uVar6;
		  ulonglong param2_00;
		  int local_8;
		  int local_4;
		  
		  uVar5 = 0;
		  if (DAT_ram_00a5a159 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    DAT_ram_00a5a159 = '\x01';
		  }
		  local_4 = 0;
		  local_8 = 0;
		  piVar3 = *(int **)(param1 + 0x4c);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar6 = 0;
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar6 * 8)) {
		        puVar1 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar6 * 8 + 4) * 8 + iVar4 + 0xd0);
		        goto code_r0x811d5ef1;
		      }
		      uVar6 = uVar6 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar6);
		  }
		  puVar1 = (uint *)func_ii_1080(piVar3,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x811d5ef1:
		  uVar2 = (**(code **)((ulonglong)*puVar1 * 4))(piVar3,CONCAT44(in_register_20000014,puVar1[1]));
		  param2_00 = (ulonglong)*(uint *)(param1 + 0x58);
		  iVar4 = func_ii_10817(uVar2,param2_00,&local_4,0);
		  if (iVar4 != 0) {
		    uVar2 = (undefined4)(param2_00 >> 0x20);
		    piVar3 = (int *)Core_Gameplay_Managers_UserManager__get_User(*(undefined4 *)(param1 + 8),0);
		    iVar4 = (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x100) * 4))
		                      (piVar3,CONCAT44(uVar2,*(undefined4 *)(local_4 + 0x18)),&local_8,
		                       *(undefined4 *)(*piVar3 + 0x104));
		    if (iVar4 != 0) {
		      uVar5 = *(undefined8 *)(local_8 + 0x10);
		    }
		  }
		  return uVar5;
		}
		*/

			return default(bool);
		}

		// Token: 0x06002938 RID: 10552 RVA: 0x00007D28 File Offset: 0x00005F28
		[Token(Token = "0x6002938")]
		[Address(RVA = "0x7A40", Offset = "0x7A40", VA = "0x7A40", Slot = "9")]
		protected override long GetExtraSlotsCount()
		{
		/* --- GHIDRA: GetExtraSlotsCount ---
		undefined4
		Gameplay_Inventory_Model_InventoryModel__GetExtraSlotsCount
		          (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int param2_00;
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5a15a == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Distinct_ArtifactData___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToArray_ArtifactData___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Where_ArtifactData___);
		    Mono_Security_ASN1__get_Item(&System_Func_ArtifactData__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_SortedList_int__ArtifactData__get_Values__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Inventory_Model_InventoryModel___c__DisplayClass6_0__GetArtifactsToRepairForHorde_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Inventory_Model_InventoryModel___c__DisplayClass6_0_TypeInfo);
		    DAT_ram_00a5a15a = '\x01';
		  }
		  param2_00 = unnamed_function_1417
		                        (Gameplay_Inventory_Model_InventoryModel___c__DisplayClass6_0_TypeInfo);
		  *(undefined4 *)(param2_00 + 8) = param2;
		  uVar1 = System_Collections_Generic_SortedList_uint__object___System_Collections_Generic_IReadOnlyDictionary_TKey_TValue__get_Keys
		                    (*(undefined4 *)(param1 + 0xc),
		                     Method_System_Collections_Generic_SortedList_int__ArtifactData__get_Values__);
		  param1_00 = unnamed_function_1417(System_Func_ArtifactData__bool__TypeInfo);
		  System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		            (param1_00,param2_00,
		             Method_Gameplay_Inventory_Model_InventoryModel___c__DisplayClass6_0__GetArtifactsToRepairForHorde_b__0__
		             ,0);
		  uVar1 = System_Linq_Enumerable__Where_PlayerLoopSystem_
		                    (uVar1,param1_00,Method_System_Linq_Enumerable_Where_ArtifactData___);
		  uVar1 = System_Linq_Enumerable__DefaultIfEmptyIterator___Il2CppFullySharedGenericType_
		                    (uVar1,Method_System_Linq_Enumerable_Distinct_ArtifactData___);
		  uVar1 = func_ii_6295(uVar1,Method_System_Linq_Enumerable_ToArray_ArtifactData___);
		  return uVar1;
		}
		*/

			return 0L;
		}

		// Token: 0x06002939 RID: 10553 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002939")]
		[Address(RVA = "0x7A41", Offset = "0x7A41", VA = "0x7A41")]
		public ArtifactData[] GetArtifactsToRepairForHorde(int hordeLength)
		{
		/* --- GHIDRA: GetArtifactsToRepairForHorde ---
		undefined4
		Gameplay_Inventory_Model_InventoryModel__GetArtifactsToRepairForHorde
		          (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int param2_00;
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5a15b == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Distinct_ArtifactData___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToArray_ArtifactData___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Where_ArtifactData___);
		    Mono_Security_ASN1__get_Item(&System_Func_ArtifactData__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_SortedList_int__ArtifactData__get_Values__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Inventory_Model_InventoryModel___c__DisplayClass7_0__GetArtifactsToTakeoffForHorde_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Inventory_Model_InventoryModel___c__DisplayClass7_0_TypeInfo);
		    DAT_ram_00a5a15b = '\x01';
		  }
		  param2_00 = unnamed_function_1417
		                        (Gameplay_Inventory_Model_InventoryModel___c__DisplayClass7_0_TypeInfo);
		  *(undefined4 *)(param2_00 + 8) = param2;
		  uVar1 = System_Collections_Generic_SortedList_uint__object___System_Collections_Generic_IReadOnlyDictionary_TKey_TValue__get_Keys
		                    (*(undefined4 *)(param1 + 0xc),
		                     Method_System_Collections_Generic_SortedList_int__ArtifactData__get_Values__);
		  param1_00 = unnamed_function_1417(System_Func_ArtifactData__bool__TypeInfo);
		  System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		            (param1_00,param2_00,
		             Method_Gameplay_Inventory_Model_InventoryModel___c__DisplayClass7_0__GetArtifactsToTakeoffForHorde_b__0__
		             ,0);
		  uVar1 = System_Linq_Enumerable__Where_PlayerLoopSystem_
		                    (uVar1,param1_00,Method_System_Linq_Enumerable_Where_ArtifactData___);
		  uVar1 = System_Linq_Enumerable__DefaultIfEmptyIterator___Il2CppFullySharedGenericType_
		                    (uVar1,Method_System_Linq_Enumerable_Distinct_ArtifactData___);
		  uVar1 = func_ii_6295(uVar1,Method_System_Linq_Enumerable_ToArray_ArtifactData___);
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x0600293A RID: 10554 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600293A")]
		[Address(RVA = "0x7A42", Offset = "0x7A42", VA = "0x7A42")]
		public ArtifactData[] GetArtifactsToTakeoffForHorde(int hordeLen)
		{
		/* --- GHIDRA: GetArtifactsToTakeoffForHorde ---
		undefined4
		Gameplay_Inventory_Model_InventoryModel__GetArtifactsToTakeoffForHorde(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 *puVar2;
		  int param1_00;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a5a15c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_ulong__ArtifactData__get_Values__);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToArray_ArtifactData___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Where_ArtifactData___);
		    Mono_Security_ASN1__get_Item(&System_Func_ArtifactData__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Inventory_Model_InventoryModel___c__GetComparableItems_b__8_0__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Inventory_Model_InventoryModel___c_TypeInfo);
		    DAT_ram_00a5a15c = '\x01';
		  }
		  uVar1 = System_Collections_Generic_Dictionary_int__object___TryAdd
		                    (*(undefined4 *)(param1 + 0x28),
		                     Method_System_Collections_Generic_Dictionary_ulong__ArtifactData__get_Values__)
		  ;
		  if (*(int *)(Gameplay_Inventory_Model_InventoryModel___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Inventory_Model_InventoryModel___c_TypeInfo);
		  }
		  puVar2 = *(undefined4 **)(Gameplay_Inventory_Model_InventoryModel___c_TypeInfo + 0x5c);
		  param1_00 = puVar2[1];
		  if (param1_00 == 0) {
		    if (*(int *)(Gameplay_Inventory_Model_InventoryModel___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_Inventory_Model_InventoryModel___c_TypeInfo);
		      puVar2 = *(undefined4 **)(Gameplay_Inventory_Model_InventoryModel___c_TypeInfo + 0x5c);
		    }
		    param2_00 = *puVar2;
		    param1_00 = unnamed_function_1417(System_Func_ArtifactData__bool__TypeInfo);
		    System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		              (param1_00,param2_00,
		               Method_Gameplay_Inventory_Model_InventoryModel___c__GetComparableItems_b__8_0__,0);
		    *(int *)(*(int *)(Gameplay_Inventory_Model_InventoryModel___c_TypeInfo + 0x5c) + 4) = param1_00;
		  }
		  uVar1 = System_Linq_Enumerable__Where_PlayerLoopSystem_
		                    (uVar1,param1_00,Method_System_Linq_Enumerable_Where_ArtifactData___);
		  uVar1 = func_ii_6295(uVar1,Method_System_Linq_Enumerable_ToArray_ArtifactData___);
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x0600293B RID: 10555 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600293B")]
		[Address(RVA = "0x7A43", Offset = "0x7A43", VA = "0x7A43", Slot = "12")]
		public override IList<ArtifactData> GetComparableItems()
		{
		/* --- GHIDRA: GetComparableItems ---
		undefined4
		Gameplay_Inventory_Model_InventoryModel__GetComparableItems(int param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 in_register_20000014;
		  undefined8 uVar2;
		  undefined4 param1_00;
		  uint *puVar3;
		  undefined4 uVar4;
		  undefined4 uVar5;
		  undefined4 uVar6;
		  float fVar7;
		  undefined4 uVar8;
		  int *piVar9;
		  int iVar10;
		  int iVar11;
		  float param1_01;
		  int local_8 [2];
		  
		  if (DAT_ram_00a5a15d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_LastOrDefault_KeyValuePair_int__ArtifactData____);
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_int__ArtifactData__get_Key__);
		    Mono_Security_ASN1__get_Item(&Protocol_Common_ResourceSet_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27280);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27281);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27278);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27279);
		    DAT_ram_00a5a15d = '\x01';
		  }
		  System_Linq_Enumerable__Last___Il2CppFullySharedGenericType_
		            (local_8,*(undefined4 *)(param1 + 0xc),
		             Method_System_Linq_Enumerable_LastOrDefault_KeyValuePair_int__ArtifactData____);
		  param1_00 = unnamed_function_1417(Protocol_Common_ResourceSet_TypeInfo);
		  piVar9 = *(int **)(param1 + 0x4c);
		  iVar10 = *piVar9;
		  if (*(ushort *)(iVar10 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8 + 4) * 8 + iVar10 + 0xd0);
		        goto code_r0x811d62cd;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar10 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar9,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x811d62cd:
		  uVar1 = 0;
		  uVar2 = CONCAT44(in_register_20000014,puVar3[1]);
		  uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(piVar9,uVar2);
		  uVar6 = (undefined4)((ulonglong)uVar2 >> 0x20);
		  iVar10 = Core_Extensions_Dict_DictExt__GetUserBuildingLevelDic(uVar4,StringLiteral_27281,0);
		  piVar9 = *(int **)(param1 + 0x4c);
		  iVar11 = *piVar9;
		  if (*(ushort *)(iVar11 + 0xb6) != 0) {
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar11 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar11 + 0x58) + uVar1 * 8 + 4) * 8 + iVar11 + 0xd0);
		        goto code_r0x811d6360;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar11 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar9,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x811d6360:
		  uVar1 = 0;
		  uVar2 = CONCAT44(uVar6,puVar3[1]);
		  uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(piVar9,uVar2);
		  uVar6 = (undefined4)((ulonglong)uVar2 >> 0x20);
		  uVar4 = Core_Extensions_Dict_DictExt__GetUserBuildingLevelDic(uVar4,StringLiteral_27280,0);
		  piVar9 = *(int **)(param1 + 0x4c);
		  iVar11 = *piVar9;
		  if (*(ushort *)(iVar11 + 0xb6) != 0) {
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar11 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar11 + 0x58) + uVar1 * 8 + 4) * 8 + iVar11 + 0xd0);
		        goto code_r0x811d63f3;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar11 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar9,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x811d63f3:
		  uVar1 = 0;
		  uVar2 = CONCAT44(uVar6,puVar3[1]);
		  uVar5 = (**(code **)((ulonglong)*puVar3 * 4))(piVar9,uVar2);
		  uVar6 = (undefined4)((ulonglong)uVar2 >> 0x20);
		  uVar5 = Core_Extensions_Dict_DictExt__GetBoolParameter(uVar5,StringLiteral_27279,0);
		  piVar9 = *(int **)(param1 + 0x4c);
		  iVar11 = *piVar9;
		  if (*(ushort *)(iVar11 + 0xb6) != 0) {
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar11 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar11 + 0x58) + uVar1 * 8 + 4) * 8 + iVar11 + 0xd0);
		        goto code_r0x811d6486;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar11 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar9,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x811d6486:
		  uVar6 = (**(code **)((ulonglong)*puVar3 * 4))(piVar9,CONCAT44(uVar6,puVar3[1]));
		  uVar6 = Core_Extensions_Dict_DictExt__GetBoolParameter(uVar6,StringLiteral_27278,0);
		  if (param2 != 0) {
		    param1_01 = (float)(local_8[0] + 2) - (float)iVar10;
		    if (param1_01 <= 0.0) {
		      param1_01 = 0.0;
		    }
		    do {
		      fVar7 = Utils_MathUtils_MathUtils__SaferDivide(param1_01,uVar4,0);
		      uVar8 = Protocol_Common_ResourceSet___ctor(uVar6,0);
		      uVar8 = Core_Extensions_Dict_ResourceSetExt__Round(uVar8,(double)CEIL(fVar7),0);
		      Core_Extensions_Dict_RegularOptionDicExt__GetBankBgAssetId(uVar8,uVar5,0);
		      Core_Extensions_Dict_RegularOptionDicExt__GetBankBgAssetId(param1_00,uVar8,0);
		      param2 = param2 + -1;
		    } while (param2 != 0);
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x0600293C RID: 10556 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600293C")]
		[Address(RVA = "0x7A44", Offset = "0x7A44", VA = "0x7A44", Slot = "11")]
		public override ResourceSet GetSlotPrice(uint slotCount)
		{
		/* --- GHIDRA: GetSlotPrice ---
		undefined4
		Gameplay_Inventory_Model_InventoryModel__GetSlotPrice
		          (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = Gameplay_Inventory_Model_InventoryBaseModel__GetAllArtikulTypeFilters
		                    (param1,param2,*(undefined4 *)(param1 + 8),param1);
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x0600293D RID: 10557 RVA: 0x00007D40 File Offset: 0x00005F40
		[Token(Token = "0x600293D")]
		[Address(RVA = "0x7A45", Offset = "0x7A45", VA = "0x7A45", Slot = "13")]
		public override bool IsArtifactCanBeEquipped(ArtifactData artifact)
		{
		/* --- GHIDRA: IsArtifactCanBeEquipped ---
		undefined4
		Gameplay_Inventory_Model_InventoryModel__IsArtifactCanBeEquipped
		          (undefined4 param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5a15e == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Inventory_Model_InventoryConstants_TypeInfo);
		    DAT_ram_00a5a15e = '\x01';
		  }
		  if (*(int *)(Gameplay_Inventory_Model_InventoryConstants_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Inventory_Model_InventoryConstants_TypeInfo);
		  }
		  if (param2 < **(int **)(Gameplay_Inventory_Model_InventoryConstants_TypeInfo + 0x5c)) {
		    uVar1 = Gameplay_Inventory_Model_InventoryUtils__IsBagSlot
		                      (param2,Gameplay_Inventory_Model_InventoryConstants_TypeInfo);
		  }
		  else {
		    uVar1 = 0;
		  }
		  return uVar1;
		}
		*/

			return default(bool);
		}

		// Token: 0x0600293E RID: 10558 RVA: 0x00007D58 File Offset: 0x00005F58
		[Token(Token = "0x600293E")]
		[Address(RVA = "0x7A46", Offset = "0x7A46", VA = "0x7A46", Slot = "10")]
		protected override bool IsEquipmentSlot(int slotId)
		{
		/* --- GHIDRA: IsEquipmentSlot ---
		void Gameplay_Inventory_Model_InventoryModel__IsEquipmentSlot(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5a15f == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Inventory_Model_InventoryModel___c_TypeInfo);
		    DAT_ram_00a5a15f = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Gameplay_Inventory_Model_InventoryModel___c_TypeInfo);
		  **(undefined4 **)(Gameplay_Inventory_Model_InventoryModel___c_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x040016F1 RID: 5873
		[Token(Token = "0x40016F1")]
		[FieldOffset(Offset = "0x58")]
		private readonly Antiq.Types.EffectsDic.Types.EffectID _effectId;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_OwnerUser ---
		uint Gameplay_Inventory_Model_InventoryModel__get_OwnerUser
		               (int param1,int *param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a5a158 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_int__ArtifactData__get_Item__);
		    DAT_ram_00a5a158 = '\x01';
		  }
		  *param2 = 0;
		  iVar1 = System_Collections_Generic_Dictionary_int__Int32Enum___get_Count
		                    (*(undefined4 *)(param1 + 0x2c),1,
		                     Method_System_Collections_Generic_Dictionary_int__ArtifactData__get_Item__);
		  if (iVar1 != 0) {
		    *param2 = *param2 + 1;
		  }
		  iVar2 = System_Collections_Generic_Dictionary_int__Int32Enum___get_Count
		                    (*(undefined4 *)(param1 + 0x2c),2,
		                     Method_System_Collections_Generic_Dictionary_int__ArtifactData__get_Item__);
		  iVar1 = *param2;
		  if (iVar2 != 0) {
		    iVar1 = iVar1 + 1;
		    *param2 = iVar1;
		  }
		  return (uint)(iVar1 == 0);
		}
		*/

}
