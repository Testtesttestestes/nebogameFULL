using System;
using Gameplay.Inventory.View;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Gameplay.Inventory.ContextMenu
{
	// Token: 0x020006CC RID: 1740
	[Token(Token = "0x20006CC")]
	public class DismantleAllUserArtifactsContextMenuElement : AbstractArtifactContextMenuElement
	{
		// Token: 0x170007F1 RID: 2033
		// (get) Token: 0x06002A09 RID: 10761 RVA: 0x00007FB0 File Offset: 0x000061B0
		[Token(Token = "0x170007F1")]
		public override ArtikulMenuActionDic.Types.Actions ActionId
		{
			[Token(Token = "0x6002A09")]
			[Address(RVA = "0x7AAC", Offset = "0x7AAC", VA = "0x7AAC", Slot = "4")]
			get
			{
				return ArtikulMenuActionDic.Types.Actions.UnknownAction;
			}
		}

		// Token: 0x06002A0A RID: 10762 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A0A")]
		[Address(RVA = "0x7AAD", Offset = "0x7AAD", VA = "0x7AAD", Slot = "7")]
		public override void Handle(IArtifactView artifactView)
		{
		/* --- GHIDRA: Handle ---
		uint Gameplay_Inventory_ContextMenu_DismantleAllUserArtifactsContextMenuElement__Handle
		               (undefined4 param1,int *param2,undefined4 param3)
		
		{
		  uint *puVar1;
		  undefined4 uVar2;
		  longlong lVar3;
		  longlong lVar4;
		  int iVar5;
		  int *param1_00;
		  uint uVar6;
		  
		  if (DAT_ram_00a5a19a == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Inventory_View_IArtifactView_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5a19a = '\x01';
		  }
		  iVar5 = *param2;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar6 = 0;
		    do {
		      if (Gameplay_Inventory_View_IArtifactView_TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar6 * 8)) {
		        puVar1 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar6 * 8 + 4) * 8 + iVar5 + 0xd0);
		        goto code_r0x811dba03;
		      }
		      uVar6 = uVar6 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar6);
		  }
		  puVar1 = (uint *)func_ii_1080(param2,Gameplay_Inventory_View_IArtifactView_TypeInfo,2);
		code_r0x811dba03:
		  uVar2 = (**(code **)((ulonglong)*puVar1 * 4))(param2,puVar1[1]);
		  iVar5 = Core_Data_ArtikulData__get_IsRepairable(uVar2,0);
		  if (iVar5 == 0) {
		    uVar6 = 0;
		  }
		  else {
		    uVar6 = 0;
		    iVar5 = *param2;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      do {
		        if (Gameplay_Inventory_View_IArtifactView_TypeInfo ==
		            *(int *)(*(int *)(iVar5 + 0x58) + uVar6 * 8)) {
		          puVar1 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar6 * 8 + 4) * 8 + iVar5 + 0xd0);
		          goto code_r0x811dba91;
		        }
		        uVar6 = uVar6 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar6);
		    }
		    puVar1 = (uint *)func_ii_1080(param2,Gameplay_Inventory_View_IArtifactView_TypeInfo,2);
		code_r0x811dba91:
		    iVar5 = (**(code **)((ulonglong)*puVar1 * 4))(param2,puVar1[1]);
		    lVar3 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                      (*(undefined4 *)(iVar5 + 0x70),0);
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar5 = *param1_00;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      uVar6 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar6 * 8)) {
		          puVar1 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar6 * 8 + 4) * 8 + iVar5 + 0x140);
		          goto code_r0x811dbb42;
		        }
		        uVar6 = uVar6 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar6);
		    }
		    puVar1 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x811dbb42:
		    uVar2 = (**(code **)((ulonglong)*puVar1 * 4))(param1_00,puVar1[1]);
		    uVar2 = func_ii_7112(uVar2,0);
		    lVar4 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext(uVar2,0);
		    if (lVar4 == lVar3) {
		      uVar6 = 0;
		      iVar5 = *param2;
		      if (*(ushort *)(iVar5 + 0xb6) != 0) {
		        do {
		          if (Gameplay_Inventory_View_IArtifactView_TypeInfo ==
		              *(int *)(*(int *)(iVar5 + 0x58) + uVar6 * 8)) {
		            puVar1 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar6 * 8 + 4) * 8 + iVar5 + 0xd0);
		            goto code_r0x811dbbd6;
		          }
		          uVar6 = uVar6 + 1;
		        } while (*(ushort *)(iVar5 + 0xb6) != uVar6);
		      }
		      puVar1 = (uint *)func_ii_1080(param2,Gameplay_Inventory_View_IArtifactView_TypeInfo,2);
		code_r0x811dbbd6:
		      iVar5 = (**(code **)((ulonglong)*puVar1 * 4))(param2,puVar1[1]);
		      uVar6 = (*(byte *)(*(int *)(iVar5 + 0xc) + 0x11) & 0x20) >> 5;
		    }
		    else {
		      uVar6 = 0;
		    }
		  }
		  return uVar6;
		}
		*/

		}

		// Token: 0x06002A0B RID: 10763 RVA: 0x00007FC8 File Offset: 0x000061C8
		[Token(Token = "0x6002A0B")]
		[Address(RVA = "0x7AAE", Offset = "0x7AAE", VA = "0x7AAE", Slot = "5")]
		public override bool Validate(IArtifactView artifactView)
		{
			return default(bool);
		}

		// Token: 0x06002A0C RID: 10764 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A0C")]
		[Address(RVA = "0x7AAF", Offset = "0x7AAF", VA = "0x7AAF")]
		public DismantleAllUserArtifactsContextMenuElement()
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_ActionId ---
		void Gameplay_Inventory_ContextMenu_DismantleAllUserArtifactsContextMenuElement__get_ActionId
		               (undefined4 param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  int *piVar5;
		  int iVar6;
		  
		  if (DAT_ram_00a5a199 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Inventory_View_IArtifactView_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5a199 = '\x01';
		  }
		  iVar6 = *param2;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Gameplay_Inventory_View_IArtifactView_TypeInfo ==
		          *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0xd0);
		        goto code_r0x811db6db;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,Gameplay_Inventory_View_IArtifactView_TypeInfo,2);
		code_r0x811db6db:
		  iVar6 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  if (*(int *)(iVar6 + 0x80) == 2) {
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    uVar1 = 0;
		    piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar6 = *piVar5;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x150);
		          goto code_r0x811db796;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x12);
		code_r0x811db796:
		    iVar6 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		    uVar3 = *(undefined4 *)(iVar6 + 0x10);
		    uVar1 = 0;
		    iVar6 = *param2;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      do {
		        if (Gameplay_Inventory_View_IArtifactView_TypeInfo ==
		            *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0xd0);
		          goto code_r0x811db81d;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param2,Gameplay_Inventory_View_IArtifactView_TypeInfo,2);
		code_r0x811db81d:
		    uVar4 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		    Gameplay_ArtifactDrop_Control_ArtifactDropController__EquipArtifact(uVar3,uVar4,0,1,0);
		    return;
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x120);
		        goto code_r0x811db8cd;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0xc);
		code_r0x811db8cd:
		  uVar1 = 0;
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		  iVar6 = *param2;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Gameplay_Inventory_View_IArtifactView_TypeInfo ==
		          *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0xd0);
		        goto code_r0x811db951;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,Gameplay_Inventory_View_IArtifactView_TypeInfo,2);
		code_r0x811db951:
		  uVar4 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  Core_Gameplay_Managers_Inventory_InventoryManager__Equip(uVar3,uVar4,0,1,0);
		  return;
		}
		*/

}
