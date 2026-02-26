using System;
using Gameplay.Inventory.View;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Gameplay.Inventory.ContextMenu
{
	// Token: 0x020006E8 RID: 1768
	[Token(Token = "0x20006E8")]
	public class TakeoffFromShopContextMenuElement : AbstractArtifactContextMenuElement
	{
		// Token: 0x1700080C RID: 2060
		// (get) Token: 0x06002A75 RID: 10869 RVA: 0x00008490 File Offset: 0x00006690
		[Token(Token = "0x1700080C")]
		public override ArtikulMenuActionDic.Types.Actions ActionId
		{
			[Token(Token = "0x6002A75")]
			[Address(RVA = "0x7B18", Offset = "0x7B18", VA = "0x7B18", Slot = "4")]
			get
			{
				return ArtikulMenuActionDic.Types.Actions.UnknownAction;
			}
		}

		// Token: 0x06002A76 RID: 10870 RVA: 0x000084A8 File Offset: 0x000066A8
		[Token(Token = "0x6002A76")]
		[Address(RVA = "0x7B19", Offset = "0x7B19", VA = "0x7B19", Slot = "5")]
		public override bool Validate(IArtifactView artifactView)
		{
		/* --- GHIDRA: Validate ---
		void Gameplay_Inventory_ContextMenu_TakeoffFromShopContextMenuElement__Validate
		               (undefined4 param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param2_00;
		  int *param1_00;
		  undefined4 param1_01;
		  int iVar3;
		  
		  if (DAT_ram_00a5a1ce == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Inventory_View_IArtifactView_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5a1ce = '\x01';
		  }
		  iVar3 = *param2;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Gameplay_Inventory_View_IArtifactView_TypeInfo ==
		          *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0xd0);
		        goto code_r0x811e25b8;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,Gameplay_Inventory_View_IArtifactView_TypeInfo,2);
		code_r0x811e25b8:
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
		          goto code_r0x811e2667;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,9);
		code_r0x811e2667:
		    iVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		    param1_01 = *(undefined4 *)(iVar3 + 0x18);
		    uVar1 = 0;
		    iVar3 = *param2;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      do {
		        if (Gameplay_Inventory_View_IArtifactView_TypeInfo ==
		            *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0xd0);
		          goto code_r0x811e26ee;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param2,Gameplay_Inventory_View_IArtifactView_TypeInfo,2);
		code_r0x811e26ee:
		    param2_00 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		    Gameplay_Shop_ShopController__OnItemsMovedToShop(param1_01,param2_00,0,0);
		  }
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x06002A77 RID: 10871 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A77")]
		[Address(RVA = "0x7B1A", Offset = "0x7B1A", VA = "0x7B1A", Slot = "7")]
		public override void Handle(IArtifactView artifactView)
		{
		}

		// Token: 0x06002A78 RID: 10872 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A78")]
		[Address(RVA = "0x7B1B", Offset = "0x7B1B", VA = "0x7B1B")]
		public TakeoffFromShopContextMenuElement()
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_ActionId ---
		uint Gameplay_Inventory_ContextMenu_TakeoffFromShopContextMenuElement__get_ActionId
		               (undefined4 param1,int *param2,undefined4 param3)
		
		{
		  uint *puVar1;
		  undefined4 param1_00;
		  int iVar2;
		  int *param1_01;
		  int iVar3;
		  uint uVar4;
		  
		  if (DAT_ram_00a5a1cd == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Inventory_View_IArtifactView_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5a1cd = '\x01';
		  }
		  iVar2 = *param2;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    uVar4 = 0;
		    do {
		      if (Gameplay_Inventory_View_IArtifactView_TypeInfo ==
		          *(int *)(*(int *)(iVar2 + 0x58) + uVar4 * 8)) {
		        puVar1 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar4 * 8 + 4) * 8 + iVar2 + 0xd0);
		        goto code_r0x811e23c7;
		      }
		      uVar4 = uVar4 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar4);
		  }
		  puVar1 = (uint *)func_ii_1080(param2,Gameplay_Inventory_View_IArtifactView_TypeInfo,2);
		code_r0x811e23c7:
		  iVar2 = (**(code **)((ulonglong)*puVar1 * 4))(param2,puVar1[1]);
		  if (*(int *)(iVar2 + 0x80) == 4) {
		    uVar4 = 0;
		    iVar2 = *param2;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      do {
		        if (Gameplay_Inventory_View_IArtifactView_TypeInfo ==
		            *(int *)(*(int *)(iVar2 + 0x58) + uVar4 * 8)) {
		          puVar1 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar4 * 8 + 4) * 8 + iVar2 + 0xd0);
		          goto code_r0x811e2454;
		        }
		        uVar4 = uVar4 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar4);
		    }
		    puVar1 = (uint *)func_ii_1080(param2,Gameplay_Inventory_View_IArtifactView_TypeInfo,2);
		code_r0x811e2454:
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
		          goto code_r0x811e24ff;
		        }
		        uVar4 = uVar4 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar4);
		    }
		    puVar1 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x811e24ff:
		    param1_00 = (**(code **)((ulonglong)*puVar1 * 4))(param1_01,puVar1[1]);
		    iVar3 = func_ii_7112(param1_00,0);
		    uVar4 = (uint)(iVar3 == iVar2);
		  }
		  else {
		    uVar4 = 0;
		  }
		  return uVar4;
		}
		*/

}
