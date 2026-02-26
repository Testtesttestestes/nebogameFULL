using System;
using Gameplay.Inventory.View;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Gameplay.Inventory.ContextMenu
{
	// Token: 0x020006D4 RID: 1748
	[Token(Token = "0x20006D4")]
	internal class EquipToGolemContextMenuElement : AbstractArtifactContextMenuElement
	{
		// Token: 0x170007F8 RID: 2040
		// (get) Token: 0x06002A28 RID: 10792 RVA: 0x00008100 File Offset: 0x00006300
		[Token(Token = "0x170007F8")]
		public override ArtikulMenuActionDic.Types.Actions ActionId
		{
			[Token(Token = "0x6002A28")]
			[Address(RVA = "0x7ACB", Offset = "0x7ACB", VA = "0x7ACB", Slot = "4")]
			get
			{
				return ArtikulMenuActionDic.Types.Actions.UnknownAction;
			}
		}

		// Token: 0x06002A29 RID: 10793 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A29")]
		[Address(RVA = "0x7ACC", Offset = "0x7ACC", VA = "0x7ACC", Slot = "7")]
		public override void Handle(IArtifactView artifactView)
		{
		/* --- GHIDRA: Handle ---
		uint Gameplay_Inventory_ContextMenu_EquipToGolemContextMenuElement__Handle
		               (undefined4 param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *param1_00;
		  int iVar4;
		  
		  if (DAT_ram_00a5a1aa == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Inventory_View_IArtifactView_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5a1aa = '\x01';
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
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x230);
		        goto code_r0x811ddccb;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x2e);
		code_r0x811ddccb:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  iVar4 = Gameplay_Clans_Model_ClansModel__set_GolemUserData(*(undefined4 *)(iVar4 + 0x10),0);
		  if (iVar4 == 0) {
		    uVar1 = 0;
		  }
		  else {
		    uVar1 = 0;
		    iVar4 = *param2;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      do {
		        if (Gameplay_Inventory_View_IArtifactView_TypeInfo ==
		            *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xd0);
		          goto code_r0x811ddd5e;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param2,Gameplay_Inventory_View_IArtifactView_TypeInfo,2);
		code_r0x811ddd5e:
		    uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		    iVar4 = Core_Data_ArtikulData__get_IsDollItem(uVar3,0);
		    if (iVar4 == 0) {
		      uVar1 = 0;
		    }
		    else {
		      uVar1 = 0;
		      iVar4 = *param2;
		      if (*(ushort *)(iVar4 + 0xb6) != 0) {
		        do {
		          if (Gameplay_Inventory_View_IArtifactView_TypeInfo ==
		              *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		            puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xd0);
		            goto code_r0x811ddde6;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		      }
		      puVar2 = (uint *)func_ii_1080(param2,Gameplay_Inventory_View_IArtifactView_TypeInfo,2);
		code_r0x811ddde6:
		      uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		      iVar4 = func_ii_7597(uVar3,0);
		      if (iVar4 == 0) {
		        uVar1 = 0;
		      }
		      else {
		        uVar1 = 0;
		        iVar4 = *param2;
		        if (*(ushort *)(iVar4 + 0xb6) != 0) {
		          do {
		            if (Gameplay_Inventory_View_IArtifactView_TypeInfo ==
		                *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		              puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xd0)
		              ;
		              goto code_r0x811dde6e;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		        }
		        puVar2 = (uint *)func_ii_1080(param2,Gameplay_Inventory_View_IArtifactView_TypeInfo,2);
		code_r0x811dde6e:
		        iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		        if (*(int *)(iVar4 + 0x80) == 1) {
		          iVar4 = *(int *)(iVar4 + 0x7c);
		          if (DAT_ram_00a5a162 == '\0') {
		            Mono_Security_ASN1__get_Item(&Gameplay_Inventory_Model_InventoryConstants_TypeInfo);
		            DAT_ram_00a5a162 = '\x01';
		          }
		          if (*(int *)(Gameplay_Inventory_Model_InventoryConstants_TypeInfo + 0x74) == 0) {
		            func_ii_306000(Gameplay_Inventory_Model_InventoryConstants_TypeInfo);
		          }
		          uVar1 = (uint)(*(int *)(*(int *)(Gameplay_Inventory_Model_InventoryConstants_TypeInfo +
		                                          0x5c) + 4) <= iVar4);
		        }
		        else {
		          uVar1 = 0;
		        }
		      }
		    }
		  }
		  return uVar1;
		}
		*/

		}

		// Token: 0x06002A2A RID: 10794 RVA: 0x00008118 File Offset: 0x00006318
		[Token(Token = "0x6002A2A")]
		[Address(RVA = "0x7ACD", Offset = "0x7ACD", VA = "0x7ACD", Slot = "5")]
		public override bool Validate(IArtifactView artifactView)
		{
			return default(bool);
		}

		// Token: 0x06002A2B RID: 10795 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A2B")]
		[Address(RVA = "0x7ACE", Offset = "0x7ACE", VA = "0x7ACE")]
		public EquipToGolemContextMenuElement()
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_ActionId ---
		void Gameplay_Inventory_ContextMenu_EquipToGolemContextMenuElement__get_ActionId
		               (undefined4 param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param2_00;
		  int *param1_00;
		  int iVar3;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a5a1a9 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Inventory_View_IArtifactView_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Inventory_Controller_InventoryBaseController_GolemInventoryModel__GolemInventoryEvents__Equip__
		              );
		    DAT_ram_00a5a1a9 = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar3 = *param1_00;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x238);
		        goto code_r0x811ddb66;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x2f);
		code_r0x811ddb66:
		  iVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  param1_01 = *(undefined4 *)(iVar3 + 0x14);
		  uVar1 = 0;
		  iVar3 = *param2;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Gameplay_Inventory_View_IArtifactView_TypeInfo ==
		          *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0xd0);
		        goto code_r0x811ddbed;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,Gameplay_Inventory_View_IArtifactView_TypeInfo,2);
		code_r0x811ddbed:
		  param2_00 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  Gameplay_Inventory_Controller_InventoryBaseController_object__object___Dispose
		            (param1_01,param2_00,
		             Method_Gameplay_Inventory_Controller_InventoryBaseController_GolemInventoryModel__GolemInventoryEvents__Equip__
		            );
		  return;
		}
		*/

}
