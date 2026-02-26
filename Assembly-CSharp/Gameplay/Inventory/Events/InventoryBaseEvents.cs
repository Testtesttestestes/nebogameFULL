using System;
using Core.Data;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Inventory.Events
{
	// Token: 0x020006AE RID: 1710
	[Token(Token = "0x20006AE")]
	public class InventoryBaseEvents : AbstractMVCEvents
	{
		// Token: 0x06002952 RID: 10578 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002952")]
		[Address(RVA = "0x7A59", Offset = "0x7A59", VA = "0x7A59")]
		public InventoryBaseEvents()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Inventory_Events_InventoryBaseEvents___ctor
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5)
		
		{
		  if (DAT_ram_00a5a168 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Inventory_Controller_InventoryBaseViewMediator_InventoryModel__InventoryEvents__InventoryController__UserInventoryChestWindow___ctor__
		              );
		    DAT_ram_00a5a168 = '\x01';
		  }
		  Gameplay_Inventory_Controller_InventoryBaseController_object__object___Unequip
		            (param1,param2,param3,param4,
		             Method_Gameplay_Inventory_Controller_InventoryBaseViewMediator_InventoryModel__InventoryEvents__InventoryController__UserInventoryChestWindow___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x04001706 RID: 5894
		[Token(Token = "0x4001706")]
		[FieldOffset(Offset = "0x14")]
		public Action InventoryChangedEvent;

		// Token: 0x04001707 RID: 5895
		[Token(Token = "0x4001707")]
		[FieldOffset(Offset = "0x18")]
		public Action EquipmentChangedEvent;

		// Token: 0x04001708 RID: 5896
		[Token(Token = "0x4001708")]
		[FieldOffset(Offset = "0x1C")]
		public Action PurchasedSlotsCountChangedEvent;

		// Token: 0x04001709 RID: 5897
		[Token(Token = "0x4001709")]
		[FieldOffset(Offset = "0x20")]
		public Action<ArtifactData> ArtifactReforgedEvent;

		// Token: 0x0400170A RID: 5898
		[Token(Token = "0x400170A")]
		[FieldOffset(Offset = "0x24")]
		public Action NewEquipEvent;
	}
}
