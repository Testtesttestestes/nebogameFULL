using System;
using Gameplay.Inventory.View;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Gameplay.Inventory.ContextMenu
{
	// Token: 0x020006DE RID: 1758
	[Token(Token = "0x20006DE")]
	public class ReforgeUserArtifactContextMenuElement : AbstractArtifactContextMenuElement
	{
		// Token: 0x17000802 RID: 2050
		// (get) Token: 0x06002A4C RID: 10828 RVA: 0x000082B0 File Offset: 0x000064B0
		[Token(Token = "0x17000802")]
		public override ArtikulMenuActionDic.Types.Actions ActionId
		{
			[Token(Token = "0x6002A4C")]
			[Address(RVA = "0x7AEF", Offset = "0x7AEF", VA = "0x7AEF", Slot = "4")]
			get
			{
				return ArtikulMenuActionDic.Types.Actions.UnknownAction;
			}
		}

		// Token: 0x06002A4D RID: 10829 RVA: 0x000082C8 File Offset: 0x000064C8
		[Token(Token = "0x6002A4D")]
		[Address(RVA = "0x7AF0", Offset = "0x7AF0", VA = "0x7AF0", Slot = "5")]
		public override bool Validate(IArtifactView artifactView)
		{
		/* --- GHIDRA: Validate ---
		void Gameplay_Inventory_ContextMenu_ReforgeUserArtifactContextMenuElement__Validate
		               (int param1,int *param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a5a1b9 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Inventory_View_ArtifactView_TypeInfo);
		    DAT_ram_00a5a1b9 = '\x01';
		  }
		  if (param2 != (int *)0x0) {
		    if (((uint)*(byte *)(*param2 + 0xb8) <
		         (uint)*(byte *)(Gameplay_Inventory_View_ArtifactView_TypeInfo + 0xb8)) ||
		       (*(int *)(*(int *)(*param2 + 100) +
		                 (uint)*(byte *)(Gameplay_Inventory_View_ArtifactView_TypeInfo + 0xb8) * 4 + -4) !=
		        Gameplay_Inventory_View_ArtifactView_TypeInfo)) {
		      System_Activator__CreateInstance(param2,Gameplay_Inventory_View_ArtifactView_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  Gameplay_Inventory_View_ArtifactActionPopupWindow__EnableSale
		            (1,param2,*(undefined4 *)(param1 + 8),0);
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x06002A4E RID: 10830 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A4E")]
		[Address(RVA = "0x7AF1", Offset = "0x7AF1", VA = "0x7AF1", Slot = "7")]
		public override void Handle(IArtifactView artifactView)
		{
		}

		// Token: 0x06002A4F RID: 10831 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A4F")]
		[Address(RVA = "0x7AF2", Offset = "0x7AF2", VA = "0x7AF2")]
		public ReforgeUserArtifactContextMenuElement()
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_ActionId ---
		uint Gameplay_Inventory_ContextMenu_ReforgeUserArtifactContextMenuElement__get_ActionId
		               (undefined4 param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int *param1_00;
		  int iVar5;
		  
		  if (DAT_ram_00a5a1b8 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Inventory_View_IArtifactView_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5a1b8 = '\x01';
		  }
		  iVar4 = *param2;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Gameplay_Inventory_View_IArtifactView_TypeInfo ==
		          *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xd0);
		        goto code_r0x811dfa94;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,Gameplay_Inventory_View_IArtifactView_TypeInfo,2);
		code_r0x811dfa94:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  iVar4 = Core_Data_ArtifactData__get_IsRestorable(uVar3,0);
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
		          goto code_r0x811dfb22;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param2,Gameplay_Inventory_View_IArtifactView_TypeInfo,2);
		code_r0x811dfb22:
		    iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		    if ((*(int *)(iVar4 + 0x80) == 1) &&
		       (iVar4 = Gameplay_Inventory_Model_InventoryUtils__IsBagSlot
		                          (*(undefined4 *)(iVar4 + 0x7c),iVar4), iVar4 != 0)) {
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
		            goto code_r0x811dfbb8;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		      }
		      puVar2 = (uint *)func_ii_1080(param2,Gameplay_Inventory_View_IArtifactView_TypeInfo,2);
		code_r0x811dfbb8:
		      iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		      if (*(int *)(iVar4 + 0x80) == 1) {
		        uVar1 = 0;
		        iVar4 = *param2;
		        if (*(ushort *)(iVar4 + 0xb6) != 0) {
		          do {
		            if (Gameplay_Inventory_View_IArtifactView_TypeInfo ==
		                *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		              puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xd0)
		              ;
		              goto code_r0x811dfc44;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		        }
		        puVar2 = (uint *)func_ii_1080(param2,Gameplay_Inventory_View_IArtifactView_TypeInfo,2);
		code_r0x811dfc44:
		        iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		        iVar4 = *(int *)(iVar4 + 0x70);
		        if (DAT_ram_00a6456f == '\0') {
		          Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		          DAT_ram_00a6456f = '\x01';
		        }
		        param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		        iVar5 = *param1_00;
		        if (*(ushort *)(iVar5 + 0xb6) != 0) {
		          uVar1 = 0;
		          do {
		            if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		              puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x140
		                               );
		              goto code_r0x811dfcef;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		        }
		        puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x811dfcef:
		        uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		        iVar5 = func_ii_7112(uVar3,0);
		        uVar1 = (uint)(iVar5 == iVar4);
		      }
		      else {
		        uVar1 = 0;
		      }
		    }
		  }
		  return uVar1;
		}
		*/

}
