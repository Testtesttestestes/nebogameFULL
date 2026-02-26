using System;
using Gameplay.Inventory.View;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Gameplay.Inventory.ContextMenu
{
	// Token: 0x020006EF RID: 1775
	[Token(Token = "0x20006EF")]
	public class UnequipFromGolemContextMenuElement : AbstractArtifactContextMenuElement
	{
		// Token: 0x17000813 RID: 2067
		// (get) Token: 0x06002A91 RID: 10897 RVA: 0x000085E0 File Offset: 0x000067E0
		[Token(Token = "0x17000813")]
		public override ArtikulMenuActionDic.Types.Actions ActionId
		{
			[Token(Token = "0x6002A91")]
			[Address(RVA = "0x7B34", Offset = "0x7B34", VA = "0x7B34", Slot = "4")]
			get
			{
				return ArtikulMenuActionDic.Types.Actions.UnknownAction;
			}
		}

		// Token: 0x06002A92 RID: 10898 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A92")]
		[Address(RVA = "0x7B35", Offset = "0x7B35", VA = "0x7B35", Slot = "7")]
		public override void Handle(IArtifactView artifactView)
		{
		/* --- GHIDRA: Handle ---
		undefined4
		Gameplay_Inventory_ContextMenu_UnequipFromGolemContextMenuElement__Handle
		          (undefined4 param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  int iVar5;
		  int iVar6;
		  
		  if (DAT_ram_00a5a1dc == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Inventory_View_IArtifactView_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5a1dc = '\x01';
		  }
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
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x230);
		        goto code_r0x811e3ef2;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x2e);
		code_r0x811e3ef2:
		  iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		  iVar5 = Gameplay_Clans_Model_ClansModel__set_GolemUserData(*(undefined4 *)(iVar5 + 0x10),0);
		  if (iVar5 == 0) {
		    uVar3 = 0;
		  }
		  else {
		    uVar1 = 0;
		    iVar5 = *param2;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      do {
		        if (Gameplay_Inventory_View_IArtifactView_TypeInfo ==
		            *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd0);
		          goto code_r0x811e3f83;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param2,Gameplay_Inventory_View_IArtifactView_TypeInfo,2);
		code_r0x811e3f83:
		    iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		    iVar5 = *(int *)(iVar5 + 0x70);
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    piVar4 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar6 = *piVar4;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x230);
		          goto code_r0x811e402e;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x2e);
		code_r0x811e402e:
		    iVar6 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		    if (iVar5 == *(int *)(*(int *)(iVar6 + 0x10) + 0x20)) {
		      uVar1 = 0;
		      iVar5 = *param2;
		      if (*(ushort *)(iVar5 + 0xb6) != 0) {
		        do {
		          if (Gameplay_Inventory_View_IArtifactView_TypeInfo ==
		              *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		            puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd0);
		            goto code_r0x811e40ba;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		      }
		      puVar2 = (uint *)func_ii_1080(param2,Gameplay_Inventory_View_IArtifactView_TypeInfo,2);
		code_r0x811e40ba:
		      iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		      if (*(int *)(iVar5 + 0x80) == 1) {
		        uVar3 = Gameplay_Inventory_Model_InventoryUtils__IsEquipmentSlot
		                          (*(undefined4 *)(iVar5 + 0x7c),iVar5);
		      }
		      else {
		        uVar3 = 0;
		      }
		    }
		    else {
		      uVar3 = 0;
		    }
		  }
		  return uVar3;
		}
		*/

		}

		// Token: 0x06002A93 RID: 10899 RVA: 0x000085F8 File Offset: 0x000067F8
		[Token(Token = "0x6002A93")]
		[Address(RVA = "0x7B36", Offset = "0x7B36", VA = "0x7B36", Slot = "5")]
		public override bool Validate(IArtifactView artifactView)
		{
			return default(bool);
		}

		// Token: 0x06002A94 RID: 10900 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A94")]
		[Address(RVA = "0x7B37", Offset = "0x7B37", VA = "0x7B37")]
		public UnequipFromGolemContextMenuElement()
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Gameplay_Inventory_ContextMenu_UnequipFromGolemContextMenuElement___ctor
		          (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5a202 == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_InputSystem_Pointer_TypeInfo);
		    DAT_ram_00a5a202 = '\x01';
		  }
		  return **(undefined4 **)(UnityEngine_InputSystem_Pointer_TypeInfo + 0x5c);
		}
		*/

		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_ActionId ---
		void Gameplay_Inventory_ContextMenu_UnequipFromGolemContextMenuElement__get_ActionId
		               (undefined4 param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param2_00;
		  int *param1_00;
		  int iVar3;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a5a1db == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Inventory_View_IArtifactView_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Inventory_Controller_InventoryBaseController_GolemInventoryModel__GolemInventoryEvents__Unequip__
		              );
		    DAT_ram_00a5a1db = '\x01';
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
		        goto code_r0x811e3d8d;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x2f);
		code_r0x811e3d8d:
		  iVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  param1_01 = *(undefined4 *)(iVar3 + 0x14);
		  uVar1 = 0;
		  iVar3 = *param2;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Gameplay_Inventory_View_IArtifactView_TypeInfo ==
		          *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0xd0);
		        goto code_r0x811e3e14;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,Gameplay_Inventory_View_IArtifactView_TypeInfo,2);
		code_r0x811e3e14:
		  param2_00 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  Gameplay_Inventory_Controller_InventoryBaseController_object__object___ShowNotAvailableSlotsWindow
		            (param1_01,param2_00,
		             Method_Gameplay_Inventory_Controller_InventoryBaseController_GolemInventoryModel__GolemInventoryEvents__Unequip__
		            );
		  return;
		}
		*/

}
