using System;
using Core.Data;
using Il2CppDummyDll;

namespace Gameplay.Inventory.Model
{
	// Token: 0x0200069B RID: 1691
	[Token(Token = "0x200069B")]
	public static class ArtifactDataUtils
	{
		// Token: 0x060028DD RID: 10461 RVA: 0x00007B30 File Offset: 0x00005D30
		[Token(Token = "0x60028DD")]
		[Address(RVA = "0x79F7", Offset = "0x79F7", VA = "0x79F7")]
		public static bool IsInChest(this ArtifactData artifactData)
		{
		/* --- GHIDRA: IsInChest ---
		uint Gameplay_Inventory_Model_ArtifactDataUtils__IsInChest(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  uint uVar2;
		  int *piVar3;
		  
		  if (*(int *)(param1 + 0x80) == 1) {
		    iVar1 = *(int *)(param1 + 0x7c);
		    if (DAT_ram_00a5a163 == '\0') {
		      Mono_Security_ASN1__get_Item(&Gameplay_Inventory_Model_InventoryConstants_TypeInfo);
		      DAT_ram_00a5a163 = '\x01';
		    }
		    if (*(int *)(Gameplay_Inventory_Model_InventoryConstants_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_Inventory_Model_InventoryConstants_TypeInfo);
		    }
		    piVar3 = *(int **)(Gameplay_Inventory_Model_InventoryConstants_TypeInfo + 0x5c);
		    if (iVar1 < *piVar3) {
		      uVar2 = 0;
		    }
		    else {
		      if (*(int *)(Gameplay_Inventory_Model_InventoryConstants_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Gameplay_Inventory_Model_InventoryConstants_TypeInfo);
		        piVar3 = *(int **)(Gameplay_Inventory_Model_InventoryConstants_TypeInfo + 0x5c);
		      }
		      uVar2 = (uint)(iVar1 < piVar3[1]);
		    }
		  }
		  else {
		    uVar2 = 0;
		  }
		  return uVar2;
		}
		*/

			return default(bool);
		}

		// Token: 0x060028DE RID: 10462 RVA: 0x00007B48 File Offset: 0x00005D48
		[Token(Token = "0x60028DE")]
		[Address(RVA = "0x79F8", Offset = "0x79F8", VA = "0x79F8")]
		public static bool IsInBag(this ArtifactData artifactData)
		{
		/* --- GHIDRA: IsInBag ---
		undefined4 Gameplay_Inventory_Model_ArtifactDataUtils__IsInBag(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (*(int *)(param1 + 0x80) == 1) {
		    uVar1 = Gameplay_Inventory_Model_InventoryUtils__IsBagSlot
		                      (*(undefined4 *)(param1 + 0x7c),param1);
		  }
		  else {
		    uVar1 = 0;
		  }
		  return uVar1;
		}
		*/

			return default(bool);
		}

		// Token: 0x060028DF RID: 10463 RVA: 0x00007B60 File Offset: 0x00005D60
		[Token(Token = "0x60028DF")]
		[Address(RVA = "0x79F9", Offset = "0x79F9", VA = "0x79F9")]
		public static bool IsInEquip(this ArtifactData artifactData)
		{
		/* --- GHIDRA: IsInEquip ---
		undefined4 Gameplay_Inventory_Model_ArtifactDataUtils__IsInEquip(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (*(int *)(param1 + 0x80) == 1) {
		    uVar1 = Gameplay_Inventory_Model_InventoryUtils__IsEquipmentSlot
		                      (*(undefined4 *)(param1 + 0x7c),param1);
		  }
		  else {
		    uVar1 = 0;
		  }
		  return uVar1;
		}
		*/

			return default(bool);
		}

		// Token: 0x060028E0 RID: 10464 RVA: 0x00007B78 File Offset: 0x00005D78
		[Token(Token = "0x60028E0")]
		[Address(RVA = "0x79FA", Offset = "0x79FA", VA = "0x79FA")]
		public static bool IsInGolemEquip(this ArtifactData artifactData)
		{
			return default(bool);
		}

		// Token: 0x060028E1 RID: 10465 RVA: 0x00007B90 File Offset: 0x00005D90
		[Token(Token = "0x60028E1")]
		[Address(RVA = "0x1DB0", Offset = "0x1DB0", VA = "0x1DB0")]
		public static bool IsComparableWith(this ArtifactData artifactData, ArtifactData otherArtifactData)
		{
		/* --- GHIDRA: IsComparableWith ---
		int * Gameplay_Inventory_Model_ArtifactDataUtils__IsComparableWith(int *param1)
		
		{
		  if (*param1 == 0) {
		    return param1;
		  }
		  System_Data_DataSet__ValidateLocaleConstraint(*param1);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

			return default(bool);
		}
	}
}
