using System;
using Gameplay.Inventory.View;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Gameplay.Inventory.ContextMenu
{
	// Token: 0x020006DD RID: 1757
	[Token(Token = "0x20006DD")]
	public class ReforgeGolemArtifactContextMenuElement : AbstractArtifactContextMenuElement
	{
		// Token: 0x17000801 RID: 2049
		// (get) Token: 0x06002A48 RID: 10824 RVA: 0x00008280 File Offset: 0x00006480
		[Token(Token = "0x17000801")]
		public override ArtikulMenuActionDic.Types.Actions ActionId
		{
			[Token(Token = "0x6002A48")]
			[Address(RVA = "0x7AEB", Offset = "0x7AEB", VA = "0x7AEB", Slot = "4")]
			get
			{
				return ArtikulMenuActionDic.Types.Actions.UnknownAction;
			}
		}

		// Token: 0x06002A49 RID: 10825 RVA: 0x00008298 File Offset: 0x00006498
		[Token(Token = "0x6002A49")]
		[Address(RVA = "0x7AEC", Offset = "0x7AEC", VA = "0x7AEC", Slot = "5")]
		public override bool Validate(IArtifactView artifactView)
		{
		/* --- GHIDRA: Validate ---
		void Gameplay_Inventory_ContextMenu_ReforgeGolemArtifactContextMenuElement__Validate
		               (int param1,int *param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a5a1b7 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Inventory_View_ArtifactView_TypeInfo);
		    DAT_ram_00a5a1b7 = '\x01';
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
		  Gameplay_Inventory_View_ArtifactActionPopupWindow__Show(1,param2,*(undefined4 *)(param1 + 8),0);
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x06002A4A RID: 10826 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A4A")]
		[Address(RVA = "0x7AED", Offset = "0x7AED", VA = "0x7AED", Slot = "7")]
		public override void Handle(IArtifactView artifactView)
		{
		}

		// Token: 0x06002A4B RID: 10827 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A4B")]
		[Address(RVA = "0x7AEE", Offset = "0x7AEE", VA = "0x7AEE")]
		public ReforgeGolemArtifactContextMenuElement()
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_ActionId ---
		uint Gameplay_Inventory_ContextMenu_ReforgeGolemArtifactContextMenuElement__get_ActionId
		               (undefined4 param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  int *piVar3;
		  int iVar4;
		  int iVar5;
		  
		  if (DAT_ram_00a5a1b6 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Inventory_View_IArtifactView_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5a1b6 = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  piVar3 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x230);
		        goto code_r0x811df6ff;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,0x2e);
		code_r0x811df6ff:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
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
		          goto code_r0x811df790;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param2,Gameplay_Inventory_View_IArtifactView_TypeInfo,2);
		code_r0x811df790:
		    iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		    iVar4 = *(int *)(iVar4 + 0x70);
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    piVar3 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar5 = *piVar3;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x230);
		          goto code_r0x811df83b;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,0x2e);
		code_r0x811df83b:
		    iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		    if (iVar4 == *(int *)(*(int *)(iVar5 + 0x10) + 0x20)) {
		      uVar1 = 0;
		      iVar4 = *param2;
		      if (*(ushort *)(iVar4 + 0xb6) != 0) {
		        do {
		          if (Gameplay_Inventory_View_IArtifactView_TypeInfo ==
		              *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		            puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xd0);
		            goto code_r0x811df8c7;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		      }
		      puVar2 = (uint *)func_ii_1080(param2,Gameplay_Inventory_View_IArtifactView_TypeInfo,2);
		code_r0x811df8c7:
		      param1_00 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		      iVar4 = Core_Data_ArtifactData__get_IsRestorable(param1_00,0);
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
		              goto code_r0x811df951;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		        }
		        puVar2 = (uint *)func_ii_1080(param2,Gameplay_Inventory_View_IArtifactView_TypeInfo,2);
		code_r0x811df951:
		        iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		        if (*(int *)(iVar4 + 0x80) == 1) {
		          uVar1 = Gameplay_Inventory_Model_InventoryUtils__IsBagSlot
		                            (*(undefined4 *)(iVar4 + 0x7c),iVar4);
		          uVar1 = uVar1 ^ 1;
		        }
		        else {
		          uVar1 = 1;
		        }
		      }
		    }
		    else {
		      uVar1 = 0;
		    }
		  }
		  return uVar1;
		}
		*/

}
