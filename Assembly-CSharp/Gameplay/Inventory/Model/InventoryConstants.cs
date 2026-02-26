using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Gameplay.Inventory.Model
{
	// Token: 0x020006A0 RID: 1696
	[Token(Token = "0x20006A0")]
	public static class InventoryConstants
	{
		// Token: 0x170007D1 RID: 2001
		// (get) Token: 0x06002929 RID: 10537 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170007D1")]
		public static int[] EquipmentSlotIds
		{
			[Token(Token = "0x6002929")]
			[Address(RVA = "0x7A35", Offset = "0x7A35", VA = "0x7A35")]
			get
			{
				return null;
			}
		}

		// Token: 0x170007D2 RID: 2002
		// (get) Token: 0x0600292A RID: 10538 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600292B RID: 10539 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007D2")]
		public static int[] GolemEquipmentSlotIds
		{
			[Token(Token = "0x600292A")]
			[Address(RVA = "0x7A36", Offset = "0x7A36", VA = "0x7A36")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600292B")]
			[Address(RVA = "0x7A37", Offset = "0x7A37", VA = "0x7A37")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x040016C5 RID: 5829
		[Token(Token = "0x40016C5")]
		[FieldOffset(Offset = "0x0")]
		public static readonly int SlotIdBagFrom;

		// Token: 0x040016C6 RID: 5830
		[Token(Token = "0x40016C6")]
		[FieldOffset(Offset = "0x4")]
		public static readonly int SlotIdStoreFrom;

		// Token: 0x040016C7 RID: 5831
		[Token(Token = "0x40016C7")]
		[FieldOffset(Offset = "0x8")]
		public static readonly int BagLength;

		// Token: 0x040016C8 RID: 5832
		[Token(Token = "0x40016C8")]
		[FieldOffset(Offset = "0xC")]
		private static readonly int[] _equipmentSlotIds;

		// Token: 0x040016C9 RID: 5833
		[Token(Token = "0x40016C9")]
		public const uint BATTLE_PASS_TYPE_ID = 120U;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: .cctor ---
		undefined4 Gameplay_Inventory_Model_InventoryConstants___cctor(undefined4 param1)
		
		{
		  if (DAT_ram_00a5a154 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Inventory_Model_InventoryConstants_TypeInfo);
		    DAT_ram_00a5a154 = '\x01';
		  }
		  if (*(int *)(Gameplay_Inventory_Model_InventoryConstants_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Inventory_Model_InventoryConstants_TypeInfo);
		  }
		  return *(undefined4 *)
		          (*(int *)(Gameplay_Inventory_Model_InventoryConstants_TypeInfo + 0x5c) + 0xc);
		}
		*/


		/* --- GHIDRA: get_EquipmentSlotIds ---
		undefined4 Gameplay_Inventory_Model_InventoryConstants__get_EquipmentSlotIds(undefined4 param1)
		
		{
		  if (DAT_ram_00a5a155 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Inventory_Model_InventoryConstants_TypeInfo);
		    DAT_ram_00a5a155 = '\x01';
		  }
		  if (*(int *)(Gameplay_Inventory_Model_InventoryConstants_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Inventory_Model_InventoryConstants_TypeInfo);
		  }
		  return *(undefined4 *)
		          (*(int *)(Gameplay_Inventory_Model_InventoryConstants_TypeInfo + 0x5c) + 0x10);
		}
		*/


		/* --- GHIDRA: get_GolemEquipmentSlotIds ---
		void Gameplay_Inventory_Model_InventoryConstants__get_GolemEquipmentSlotIds
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5a156 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Inventory_Model_InventoryConstants_TypeInfo);
		    DAT_ram_00a5a156 = '\x01';
		  }
		  if (*(int *)(Gameplay_Inventory_Model_InventoryConstants_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Inventory_Model_InventoryConstants_TypeInfo);
		  }
		  *(undefined4 *)(*(int *)(Gameplay_Inventory_Model_InventoryConstants_TypeInfo + 0x5c) + 0x10) =
		       param1;
		  return;
		}
		*/

}
