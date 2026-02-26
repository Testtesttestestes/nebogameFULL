using System;
using Gameplay.Inventory.Events;
using Il2CppDummyDll;

namespace Gameplay.Inventory.Controller
{
	// Token: 0x020006BC RID: 1724
	[Token(Token = "0x20006BC")]
	public class InventoryEvents : InventoryBaseEvents
	{
		// Token: 0x060029C7 RID: 10695 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029C7")]
		[Address(RVA = "0x7A7D", Offset = "0x7A7D", VA = "0x7A7D")]
		public InventoryEvents()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Inventory_Controller_InventoryEvents___ctor
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *param1_00;
		  int iVar4;
		  int iVar5;
		  
		  if (DAT_ram_00a5a187 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Accounts_Model_AccountsModel_GetAccount_BattleAccount___);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Inventory_Controller_ArtifactActionBaseViewMediator_InventoryModel__InventoryEvents__InventoryController___ctor__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5a187 = '\x01';
		  }
		  MVC_AbstractController_object__object___set_Model
		            (param1,param2,param3,param4,
		             Method_Gameplay_Inventory_Controller_ArtifactActionBaseViewMediator_InventoryModel__InventoryEvents__InventoryController___ctor__
		            );
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
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x1f8);
		        goto code_r0x811d9bd6;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x27);
		code_r0x811d9bd6:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  iVar5 = **(int **)(iVar4 + 0x14);
		  uVar3 = (**(code **)((ulonglong)*(uint *)(iVar5 + 0x100) * 4))
		                    (*(int **)(iVar4 + 0x14),*(undefined4 *)(iVar5 + 0x104));
		  uVar3 = Core_Net_AbstractService__LogEvent___Il2CppFullySharedGenericStructType_
		                    (uVar3,1,
		                     Method_Gameplay_Accounts_Model_AccountsModel_GetAccount_BattleAccount___);
		  *(undefined4 *)(param1 + 0x20) = uVar3;
		  return;
		}
		*/

		}
	}
}
