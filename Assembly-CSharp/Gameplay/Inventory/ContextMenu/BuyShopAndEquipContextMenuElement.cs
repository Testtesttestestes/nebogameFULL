using System;
using Gameplay.Inventory.View;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Gameplay.Inventory.ContextMenu
{
	// Token: 0x020006C8 RID: 1736
	[Token(Token = "0x20006C8")]
	public class BuyShopAndEquipContextMenuElement : AbstractArtifactContextMenuElement
	{
		// Token: 0x170007ED RID: 2029
		// (get) Token: 0x060029F9 RID: 10745 RVA: 0x00007EF0 File Offset: 0x000060F0
		[Token(Token = "0x170007ED")]
		public override ArtikulMenuActionDic.Types.Actions ActionId
		{
			[Token(Token = "0x60029F9")]
			[Address(RVA = "0x7A9C", Offset = "0x7A9C", VA = "0x7A9C", Slot = "4")]
			get
			{
				return ArtikulMenuActionDic.Types.Actions.UnknownAction;
			}
		}

		// Token: 0x060029FA RID: 10746 RVA: 0x00007F08 File Offset: 0x00006108
		[Token(Token = "0x60029FA")]
		[Address(RVA = "0x7A9D", Offset = "0x7A9D", VA = "0x7A9D", Slot = "5")]
		public override bool Validate(IArtifactView artifactView)
		{
		/* --- GHIDRA: Validate ---
		void Gameplay_Inventory_ContextMenu_BuyShopAndEquipContextMenuElement__Validate
		               (undefined4 param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param2_00;
		  int *param1_00;
		  undefined4 param1_01;
		  int iVar3;
		  
		  if (DAT_ram_00a5a192 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Inventory_View_IArtifactView_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5a192 = '\x01';
		  }
		  iVar3 = *param2;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Gameplay_Inventory_View_IArtifactView_TypeInfo ==
		          *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0xd0);
		        goto code_r0x811daabe;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,Gameplay_Inventory_View_IArtifactView_TypeInfo,2);
		code_r0x811daabe:
		  iVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  if (*(int *)(iVar3 + 0x80) == 4) {
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar3 = *param1_00;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x108);
		          goto code_r0x811dab6d;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,9);
		code_r0x811dab6d:
		    iVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		    param1_01 = *(undefined4 *)(iVar3 + 0x18);
		    uVar1 = 0;
		    iVar3 = *param2;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      do {
		        if (Gameplay_Inventory_View_IArtifactView_TypeInfo ==
		            *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0xd0);
		          goto code_r0x811dabf4;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param2,Gameplay_Inventory_View_IArtifactView_TypeInfo,2);
		code_r0x811dabf4:
		    param2_00 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		    Gameplay_Shop_ShopController__TakeoffArtifactFromShop(param1_01,param2_00,1,0);
		  }
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x060029FB RID: 10747 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029FB")]
		[Address(RVA = "0x7A9E", Offset = "0x7A9E", VA = "0x7A9E", Slot = "7")]
		public override void Handle(IArtifactView artifactView)
		{
		}

		// Token: 0x060029FC RID: 10748 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029FC")]
		[Address(RVA = "0x7A9F", Offset = "0x7A9F", VA = "0x7A9F")]
		public BuyShopAndEquipContextMenuElement()
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_ActionId ---
		uint Gameplay_Inventory_ContextMenu_BuyShopAndEquipContextMenuElement__get_ActionId
		               (undefined4 param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint uVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  undefined4 param2_00;
		  int iVar5;
		  int *piVar6;
		  int iVar7;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5a191 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Inventory_View_IArtifactView_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5a191 = '\x01';
		  }
		  local_4 = 0;
		  iVar5 = *param2;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Gameplay_Inventory_View_IArtifactView_TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd0);
		        goto code_r0x811da5e8;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param2,Gameplay_Inventory_View_IArtifactView_TypeInfo,2);
		code_r0x811da5e8:
		  uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(param2,puVar3[1]);
		  iVar5 = Core_Data_ArtifactData__get_Rank(uVar4,0);
		  if (iVar5 == 0) {
		    uVar1 = 0;
		    iVar5 = *param2;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      do {
		        if (Gameplay_Inventory_View_IArtifactView_TypeInfo ==
		            *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd0);
		          goto code_r0x811da673;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(param2,Gameplay_Inventory_View_IArtifactView_TypeInfo,2);
		code_r0x811da673:
		    uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(param2,puVar3[1]);
		    iVar5 = Core_Data_ArtikulData__get_IsEquipment(uVar4,0);
		    if (iVar5 == 0) {
		      uVar1 = 0;
		    }
		    else {
		      uVar1 = 0;
		      iVar5 = *param2;
		      if (*(ushort *)(iVar5 + 0xb6) != 0) {
		        do {
		          if (Gameplay_Inventory_View_IArtifactView_TypeInfo ==
		              *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		            puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd0);
		            goto code_r0x811da6fd;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		      }
		      puVar3 = (uint *)func_ii_1080(param2,Gameplay_Inventory_View_IArtifactView_TypeInfo,2);
		code_r0x811da6fd:
		      uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(param2,puVar3[1]);
		      iVar5 = func_ii_7597(uVar4,0);
		      if (iVar5 == 0) {
		        uVar1 = 0;
		      }
		      else {
		        if (DAT_ram_00a6456f == '\0') {
		          Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		          DAT_ram_00a6456f = '\x01';
		        }
		        piVar6 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		        iVar5 = *piVar6;
		        if (*(ushort *)(iVar5 + 0xb6) != 0) {
		          uVar1 = 0;
		          do {
		            if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		              puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x120
		                               );
		              goto code_r0x811da7b3;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		        }
		        puVar3 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0xc);
		code_r0x811da7b3:
		        iVar5 = (**(code **)((ulonglong)*puVar3 * 4))(piVar6,puVar3[1]);
		        uVar4 = *(undefined4 *)(iVar5 + 0x10);
		        uVar1 = 0;
		        iVar5 = *param2;
		        if (*(ushort *)(iVar5 + 0xb6) != 0) {
		          do {
		            if (Gameplay_Inventory_View_IArtifactView_TypeInfo ==
		                *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		              puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd0)
		              ;
		              goto code_r0x811da83a;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		        }
		        puVar3 = (uint *)func_ii_1080(param2,Gameplay_Inventory_View_IArtifactView_TypeInfo,2);
		code_r0x811da83a:
		        param2_00 = (**(code **)((ulonglong)*puVar3 * 4))(param2,puVar3[1]);
		        uVar1 = Gameplay_Inventory_Model_InventoryBaseModel__ParseSlotChanges
		                          (uVar4,param2_00,&local_4,puVar3);
		      }
		    }
		  }
		  else {
		    uVar1 = 0;
		  }
		  iVar5 = *param2;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar2 = 0;
		    do {
		      if (Gameplay_Inventory_View_IArtifactView_TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar2 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar2 * 8 + 4) * 8 + iVar5 + 0xd0);
		        goto code_r0x811da8c2;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar2);
		  }
		  puVar3 = (uint *)func_ii_1080(param2,Gameplay_Inventory_View_IArtifactView_TypeInfo,2);
		code_r0x811da8c2:
		  uVar2 = 0;
		  iVar5 = (**(code **)((ulonglong)*puVar3 * 4))(param2,puVar3[1]);
		  if (*(int *)(iVar5 + 0x80) == 4) {
		    uVar2 = 0;
		    iVar5 = *param2;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      do {
		        if (Gameplay_Inventory_View_IArtifactView_TypeInfo ==
		            *(int *)(*(int *)(iVar5 + 0x58) + uVar2 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar2 * 8 + 4) * 8 + iVar5 + 0xd0);
		          goto code_r0x811da94f;
		        }
		        uVar2 = uVar2 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar2);
		    }
		    puVar3 = (uint *)func_ii_1080(param2,Gameplay_Inventory_View_IArtifactView_TypeInfo,2);
		code_r0x811da94f:
		    iVar5 = (**(code **)((ulonglong)*puVar3 * 4))(param2,puVar3[1]);
		    iVar5 = *(int *)(iVar5 + 0x70);
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    piVar6 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar7 = *piVar6;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      uVar2 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar2 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar2 * 8 + 4) * 8 + iVar7 + 0x140);
		          goto code_r0x811da9fa;
		        }
		        uVar2 = uVar2 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar2);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x811da9fa:
		    uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(piVar6,puVar3[1]);
		    iVar7 = func_ii_7112(uVar4,0);
		    uVar2 = (uint)(iVar7 != iVar5);
		  }
		  return uVar2 & uVar1;
		}
		*/

}
