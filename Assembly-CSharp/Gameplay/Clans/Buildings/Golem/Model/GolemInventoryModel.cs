using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Cache;
using Core.Data;
using Core.Dict;
using Core.Gameplay;
using Core.Gameplay.Managers.Requirements;
using Gameplay.Inventory.Model;
using Il2CppDummyDll;
using Protocol.Common;
using UI.Toast;

namespace Gameplay.Clans.Buildings.Golem.Model
{
	// Token: 0x02000AD2 RID: 2770
	[Token(Token = "0x2000AD2")]
	public class GolemInventoryModel : InventoryBaseModel
	{
		// Token: 0x17000D2D RID: 3373
		// (get) Token: 0x060042B3 RID: 17075 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060042B4 RID: 17076 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D2D")]
		public UserData GolemUserData
		{
			[Token(Token = "0x60042B3")]
			[Address(RVA = "0x9167", Offset = "0x9167", VA = "0x9167")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60042B4")]
			[Address(RVA = "0x9168", Offset = "0x9168", VA = "0x9168")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000D2E RID: 3374
		// (get) Token: 0x060042B5 RID: 17077 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000D2E")]
		public override UserData OwnerUser
		{
			[Token(Token = "0x60042B5")]
			[Address(RVA = "0x9169", Offset = "0x9169", VA = "0x9169", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x060042B6 RID: 17078 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042B6")]
		[Address(RVA = "0x916A", Offset = "0x916A", VA = "0x916A")]
		public GolemInventoryModel(IGame game, ToastController toasts, ArtifactCache artifactCache, IRequirementValidator requirementValidator, IDictProvider dictProvider, UserData user, UserData golemUserData)
		{
		}

		// Token: 0x060042B7 RID: 17079 RVA: 0x0000CAF8 File Offset: 0x0000ACF8
		[Token(Token = "0x60042B7")]
		[Address(RVA = "0x916B", Offset = "0x916B", VA = "0x916B", Slot = "9")]
		protected override long GetExtraSlotsCount()
		{
		/* --- GHIDRA: GetExtraSlotsCount ---
		undefined4
		Gameplay_Clans_Buildings_Golem_Model_GolemInventoryModel__GetExtraSlotsCount
		          (int param1,uint param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 in_register_20000014;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *param1_00;
		  int iVar4;
		  
		  if (DAT_ram_00a57856 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    DAT_ram_00a57856 = '\x01';
		  }
		  param1_00 = *(int **)(param1 + 0x4c);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xd0);
		        goto code_r0x80de8133;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x80de8133:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,CONCAT44(in_register_20000014,puVar2[1]));
		  iVar4 = Core_Extensions_Dict_DictExt__GetGenderDic(uVar3,7,0);
		  uVar3 = Protocol_Common_ResourceSet___ctor(*(undefined4 *)(*(int *)(iVar4 + 0xc) + 0x18),0);
		  uVar3 = Core_Extensions_Dict_ResourceSetExt__Round(uVar3,(double)param2,0);
		  return uVar3;
		}
		*/

			return 0L;
		}

		// Token: 0x060042B8 RID: 17080 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60042B8")]
		[Address(RVA = "0x916C", Offset = "0x916C", VA = "0x916C", Slot = "11")]
		public override ResourceSet GetSlotPrice(uint slotCount)
		{
		/* --- GHIDRA: GetSlotPrice ---
		undefined4
		Gameplay_Clans_Buildings_Golem_Model_GolemInventoryModel__GetSlotPrice
		          (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = Gameplay_Inventory_Model_InventoryBaseModel__GetAllArtikulTypeFilters
		                    (param1,param2,*(undefined4 *)(param1 + 0x58),0);
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x060042B9 RID: 17081 RVA: 0x0000CB10 File Offset: 0x0000AD10
		[Token(Token = "0x60042B9")]
		[Address(RVA = "0x916D", Offset = "0x916D", VA = "0x916D", Slot = "13")]
		public override bool IsArtifactCanBeEquipped(ArtifactData artifact)
		{
			return default(bool);
		}

		// Token: 0x060042BA RID: 17082 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042BA")]
		[Address(RVA = "0x916E", Offset = "0x916E", VA = "0x916E", Slot = "6")]
		protected override void HandleBagSlot(int slotId, ArtifactData artifactData)
		{
		/* --- GHIDRA: HandleBagSlot ---
		undefined4
		Gameplay_Clans_Buildings_Golem_Model_GolemInventoryModel__HandleBagSlot
		          (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = Gameplay_Inventory_Model_InventoryUtils__IsEquipmentSlot(param2,0);
		  return uVar1;
		}
		*/

		}

		// Token: 0x060042BB RID: 17083 RVA: 0x0000CB28 File Offset: 0x0000AD28
		[Token(Token = "0x60042BB")]
		[Address(RVA = "0x916F", Offset = "0x916F", VA = "0x916F", Slot = "10")]
		protected override bool IsEquipmentSlot(int slotId)
		{
		/* --- GHIDRA: IsEquipmentSlot ---
		undefined4
		Gameplay_Clans_Buildings_Golem_Model_GolemInventoryModel__IsEquipmentSlot
		          (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 *puVar2;
		  int param1_00;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a57857 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_ulong__ArtifactData__get_Values__);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToArray_ArtifactData___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Where_ArtifactData___);
		    Mono_Security_ASN1__get_Item(&System_Func_ArtifactData__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Buildings_Golem_Model_GolemInventoryModel___c__GetComparableItems_b__12_0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Clans_Buildings_Golem_Model_GolemInventoryModel___c_TypeInfo);
		    DAT_ram_00a57857 = '\x01';
		  }
		  uVar1 = System_Collections_Generic_Dictionary_int__object___TryAdd
		                    (*(undefined4 *)(param1 + 0x28),
		                     Method_System_Collections_Generic_Dictionary_ulong__ArtifactData__get_Values__)
		  ;
		  if (*(int *)(Gameplay_Clans_Buildings_Golem_Model_GolemInventoryModel___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Clans_Buildings_Golem_Model_GolemInventoryModel___c_TypeInfo);
		  }
		  puVar2 = *(undefined4 **)
		            (Gameplay_Clans_Buildings_Golem_Model_GolemInventoryModel___c_TypeInfo + 0x5c);
		  param1_00 = puVar2[1];
		  if (param1_00 == 0) {
		    if (*(int *)(Gameplay_Clans_Buildings_Golem_Model_GolemInventoryModel___c_TypeInfo + 0x74) == 0)
		    {
		      func_ii_306000(Gameplay_Clans_Buildings_Golem_Model_GolemInventoryModel___c_TypeInfo);
		      puVar2 = *(undefined4 **)
		                (Gameplay_Clans_Buildings_Golem_Model_GolemInventoryModel___c_TypeInfo + 0x5c);
		    }
		    param2_00 = *puVar2;
		    param1_00 = unnamed_function_1417(System_Func_ArtifactData__bool__TypeInfo);
		    System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		              (param1_00,param2_00,
		               Method_Gameplay_Clans_Buildings_Golem_Model_GolemInventoryModel___c__GetComparableItems_b__12_0__
		               ,0);
		    *(int *)(*(int *)(Gameplay_Clans_Buildings_Golem_Model_GolemInventoryModel___c_TypeInfo + 0x5c)
		            + 4) = param1_00;
		  }
		  uVar1 = System_Linq_Enumerable__Where_PlayerLoopSystem_
		                    (uVar1,param1_00,Method_System_Linq_Enumerable_Where_ArtifactData___);
		  uVar1 = func_ii_6295(uVar1,Method_System_Linq_Enumerable_ToArray_ArtifactData___);
		  return uVar1;
		}
		*/

			return default(bool);
		}

		// Token: 0x060042BC RID: 17084 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60042BC")]
		[Address(RVA = "0x9170", Offset = "0x9170", VA = "0x9170", Slot = "12")]
		public override IList<ArtifactData> GetComparableItems()
		{
		/* --- GHIDRA: GetComparableItems ---
		uint Gameplay_Clans_Buildings_Golem_Model_GolemInventoryModel__GetComparableItems
		               (int param1,int *param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a57858 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_int__ArtifactData__get_Item__);
		    DAT_ram_00a57858 = '\x01';
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

			return null;
		}

		// Token: 0x060042BD RID: 17085 RVA: 0x0000CB40 File Offset: 0x0000AD40
		[Token(Token = "0x60042BD")]
		[Address(RVA = "0x9171", Offset = "0x9171", VA = "0x9171", Slot = "8")]
		public override bool CanFitTwoHandedWeapon(out int occupiedSlots)
		{
		/* --- GHIDRA: CanFitTwoHandedWeapon ---
		void Gameplay_Clans_Buildings_Golem_Model_GolemInventoryModel__CanFitTwoHandedWeapon
		               (undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a57859 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Clans_Buildings_Golem_Model_GolemInventoryModel___c_TypeInfo);
		    DAT_ram_00a57859 = '\x01';
		  }
		  uVar1 = unnamed_function_1417
		                    (Gameplay_Clans_Buildings_Golem_Model_GolemInventoryModel___c_TypeInfo);
		  **(undefined4 **)(Gameplay_Clans_Buildings_Golem_Model_GolemInventoryModel___c_TypeInfo + 0x5c) =
		       uVar1;
		  return;
		}
		*/

			return default(bool);
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_OwnerUser ---
		void Gameplay_Clans_Buildings_Golem_Model_GolemInventoryModel__get_OwnerUser
		               (int param1,int *param2,undefined4 param3,undefined4 param4,undefined4 param5,
		               undefined4 param6,undefined4 param7,undefined4 param8,undefined4 param9)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a57855 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a57855 = '\x01';
		  }
		  Gameplay_Inventory_Model_InventoryBaseModel__get_TotalSlotsAvailable
		            (param1,param3,param4,param5,param6,param7,0);
		  *(undefined4 *)(param1 + 0x58) = param8;
		  iVar3 = *param2;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x120);
		        goto code_r0x80de8082;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,Core_Gameplay_IGame_TypeInfo,0xc);
		code_r0x80de8082:
		  iVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  *(undefined4 *)(param1 + 0x10) = *(undefined4 *)(*(int *)(iVar3 + 0x10) + 0x10);
		  return;
		}
		*/

}
