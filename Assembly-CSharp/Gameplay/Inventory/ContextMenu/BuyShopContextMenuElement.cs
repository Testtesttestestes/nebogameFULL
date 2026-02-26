using System;
using Gameplay.Inventory.View;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Gameplay.Inventory.ContextMenu
{
	// Token: 0x020006C9 RID: 1737
	[Token(Token = "0x20006C9")]
	public class BuyShopContextMenuElement : AbstractArtifactContextMenuElement
	{
		// Token: 0x170007EE RID: 2030
		// (get) Token: 0x060029FD RID: 10749 RVA: 0x00007F20 File Offset: 0x00006120
		[Token(Token = "0x170007EE")]
		public override ArtikulMenuActionDic.Types.Actions ActionId
		{
			[Token(Token = "0x60029FD")]
			[Address(RVA = "0x7AA0", Offset = "0x7AA0", VA = "0x7AA0", Slot = "4")]
			get
			{
				return ArtikulMenuActionDic.Types.Actions.UnknownAction;
			}
		}

		// Token: 0x060029FE RID: 10750 RVA: 0x00007F38 File Offset: 0x00006138
		[Token(Token = "0x60029FE")]
		[Address(RVA = "0x7AA1", Offset = "0x7AA1", VA = "0x7AA1", Slot = "5")]
		public override bool Validate(IArtifactView artifactView)
		{
		/* --- GHIDRA: Validate ---
		void Gameplay_Inventory_ContextMenu_BuyShopContextMenuElement__Validate
		               (undefined4 param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param2_00;
		  int *param1_00;
		  undefined4 param1_01;
		  int iVar3;
		  
		  if (DAT_ram_00a5a194 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Inventory_View_IArtifactView_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5a194 = '\x01';
		  }
		  iVar3 = *param2;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Gameplay_Inventory_View_IArtifactView_TypeInfo ==
		          *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0xd0);
		        goto code_r0x811dae94;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,Gameplay_Inventory_View_IArtifactView_TypeInfo,2);
		code_r0x811dae94:
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
		          goto code_r0x811daf43;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,9);
		code_r0x811daf43:
		    iVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		    param1_01 = *(undefined4 *)(iVar3 + 0x18);
		    uVar1 = 0;
		    iVar3 = *param2;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      do {
		        if (Gameplay_Inventory_View_IArtifactView_TypeInfo ==
		            *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0xd0);
		          goto code_r0x811dafca;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param2,Gameplay_Inventory_View_IArtifactView_TypeInfo,2);
		code_r0x811dafca:
		    param2_00 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		    Gameplay_Shop_ShopController__TakeoffArtifactFromShop(param1_01,param2_00,0,0);
		  }
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x060029FF RID: 10751 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029FF")]
		[Address(RVA = "0x7AA2", Offset = "0x7AA2", VA = "0x7AA2", Slot = "7")]
		public override void Handle(IArtifactView artifactView)
		{
		}

		// Token: 0x06002A00 RID: 10752 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A00")]
		[Address(RVA = "0x7AA3", Offset = "0x7AA3", VA = "0x7AA3")]
		public BuyShopContextMenuElement()
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_ActionId ---
		uint Gameplay_Inventory_ContextMenu_BuyShopContextMenuElement__get_ActionId
		               (undefined4 param1,int *param2,undefined4 param3)
		
		{
		  uint *puVar1;
		  undefined4 param1_00;
		  int iVar2;
		  int *param1_01;
		  int iVar3;
		  uint uVar4;
		  
		  if (DAT_ram_00a5a193 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Inventory_View_IArtifactView_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5a193 = '\x01';
		  }
		  iVar2 = *param2;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    uVar4 = 0;
		    do {
		      if (Gameplay_Inventory_View_IArtifactView_TypeInfo ==
		          *(int *)(*(int *)(iVar2 + 0x58) + uVar4 * 8)) {
		        puVar1 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar4 * 8 + 4) * 8 + iVar2 + 0xd0);
		        goto code_r0x811daca3;
		      }
		      uVar4 = uVar4 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar4);
		  }
		  puVar1 = (uint *)func_ii_1080(param2,Gameplay_Inventory_View_IArtifactView_TypeInfo,2);
		code_r0x811daca3:
		  iVar2 = (**(code **)((ulonglong)*puVar1 * 4))(param2,puVar1[1]);
		  if (*(int *)(iVar2 + 0x80) == 4) {
		    uVar4 = 0;
		    iVar2 = *param2;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      do {
		        if (Gameplay_Inventory_View_IArtifactView_TypeInfo ==
		            *(int *)(*(int *)(iVar2 + 0x58) + uVar4 * 8)) {
		          puVar1 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar4 * 8 + 4) * 8 + iVar2 + 0xd0);
		          goto code_r0x811dad30;
		        }
		        uVar4 = uVar4 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar4);
		    }
		    puVar1 = (uint *)func_ii_1080(param2,Gameplay_Inventory_View_IArtifactView_TypeInfo,2);
		code_r0x811dad30:
		    iVar2 = (**(code **)((ulonglong)*puVar1 * 4))(param2,puVar1[1]);
		    iVar2 = *(int *)(iVar2 + 0x70);
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    param1_01 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar3 = *param1_01;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      uVar4 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar4 * 8)) {
		          puVar1 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar4 * 8 + 4) * 8 + iVar3 + 0x140);
		          goto code_r0x811daddb;
		        }
		        uVar4 = uVar4 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar4);
		    }
		    puVar1 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x811daddb:
		    param1_00 = (**(code **)((ulonglong)*puVar1 * 4))(param1_01,puVar1[1]);
		    iVar3 = func_ii_7112(param1_00,0);
		    uVar4 = (uint)(iVar3 != iVar2);
		  }
		  else {
		    uVar4 = 0;
		  }
		  return uVar4;
		}
		*/

}
