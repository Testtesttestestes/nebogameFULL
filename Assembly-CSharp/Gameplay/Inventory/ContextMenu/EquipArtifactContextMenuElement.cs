using System;
using Gameplay.Inventory.View;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Gameplay.Inventory.ContextMenu
{
	// Token: 0x020006D3 RID: 1747
	[Token(Token = "0x20006D3")]
	public class EquipArtifactContextMenuElement : AbstractArtifactContextMenuElement
	{
		// Token: 0x170007F7 RID: 2039
		// (get) Token: 0x06002A24 RID: 10788 RVA: 0x000080D0 File Offset: 0x000062D0
		[Token(Token = "0x170007F7")]
		public override ArtikulMenuActionDic.Types.Actions ActionId
		{
			[Token(Token = "0x6002A24")]
			[Address(RVA = "0x7AC7", Offset = "0x7AC7", VA = "0x7AC7", Slot = "4")]
			get
			{
				return ArtikulMenuActionDic.Types.Actions.UnknownAction;
			}
		}

		// Token: 0x06002A25 RID: 10789 RVA: 0x000080E8 File Offset: 0x000062E8
		[Token(Token = "0x6002A25")]
		[Address(RVA = "0x7AC8", Offset = "0x7AC8", VA = "0x7AC8", Slot = "5")]
		public override bool Validate(IArtifactView artifactView)
		{
		/* --- GHIDRA: Validate ---
		void Gameplay_Inventory_ContextMenu_EquipArtifactContextMenuElement__Validate
		               (undefined4 param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  undefined4 param2_00;
		  int *param1_01;
		  int iVar3;
		  
		  if (DAT_ram_00a5a1a8 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Inventory_View_IArtifactView_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5a1a8 = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_01 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar3 = *param1_01;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x120);
		        goto code_r0x811dda02;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0xc);
		code_r0x811dda02:
		  uVar1 = 0;
		  param1_00 = (**(code **)((ulonglong)*puVar2 * 4))(param1_01,puVar2[1]);
		  iVar3 = *param2;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Gameplay_Inventory_View_IArtifactView_TypeInfo ==
		          *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0xd0);
		        goto code_r0x811dda86;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,Gameplay_Inventory_View_IArtifactView_TypeInfo,2);
		code_r0x811dda86:
		  param2_00 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  Core_Gameplay_Managers_Inventory_InventoryManager__UnEquip(param1_00,param2_00,0);
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x06002A26 RID: 10790 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A26")]
		[Address(RVA = "0x7AC9", Offset = "0x7AC9", VA = "0x7AC9", Slot = "7")]
		public override void Handle(IArtifactView artifactView)
		{
		}

		// Token: 0x06002A27 RID: 10791 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A27")]
		[Address(RVA = "0x7ACA", Offset = "0x7ACA", VA = "0x7ACA")]
		public EquipArtifactContextMenuElement()
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_ActionId ---
		uint Gameplay_Inventory_ContextMenu_EquipArtifactContextMenuElement__get_ActionId
		               (undefined4 param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  int iVar5;
		  
		  if (DAT_ram_00a5a1a7 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Inventory_View_IArtifactView_TypeInfo);
		    DAT_ram_00a5a1a7 = '\x01';
		  }
		  iVar5 = *param2;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Gameplay_Inventory_View_IArtifactView_TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd0);
		        goto code_r0x811dd637;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,Gameplay_Inventory_View_IArtifactView_TypeInfo,2);
		code_r0x811dd637:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  iVar5 = Core_Data_ArtifactData__get_Rank(uVar3,0);
		  if (iVar5 == 0) {
		    uVar1 = 0;
		    iVar5 = *param2;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      do {
		        if (Gameplay_Inventory_View_IArtifactView_TypeInfo ==
		            *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd0);
		          goto code_r0x811dd6be;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param2,Gameplay_Inventory_View_IArtifactView_TypeInfo,2);
		code_r0x811dd6be:
		    uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		    iVar5 = Core_Data_ArtikulData__get_IsEquipment(uVar3,0);
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
		            puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd0);
		            goto code_r0x811dd746;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		      }
		      puVar2 = (uint *)func_ii_1080(param2,Gameplay_Inventory_View_IArtifactView_TypeInfo,2);
		code_r0x811dd746:
		      uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		      iVar5 = func_ii_7597(uVar3,0);
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
		              puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd0)
		              ;
		              goto code_r0x811dd7ce;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		        }
		        puVar2 = (uint *)func_ii_1080(param2,Gameplay_Inventory_View_IArtifactView_TypeInfo,2);
		code_r0x811dd7ce:
		        iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		        if (*(int *)(iVar5 + 0x80) == 1) {
		          iVar5 = *(int *)(iVar5 + 0x7c);
		          if (DAT_ram_00a5a163 == '\0') {
		            Mono_Security_ASN1__get_Item(&Gameplay_Inventory_Model_InventoryConstants_TypeInfo);
		            DAT_ram_00a5a163 = '\x01';
		          }
		          if (*(int *)(Gameplay_Inventory_Model_InventoryConstants_TypeInfo + 0x74) == 0) {
		            func_ii_306000(Gameplay_Inventory_Model_InventoryConstants_TypeInfo);
		          }
		          piVar4 = *(int **)(Gameplay_Inventory_Model_InventoryConstants_TypeInfo + 0x5c);
		          if (*piVar4 <= iVar5) {
		            if (*(int *)(Gameplay_Inventory_Model_InventoryConstants_TypeInfo + 0x74) == 0) {
		              func_ii_306000(Gameplay_Inventory_Model_InventoryConstants_TypeInfo);
		              piVar4 = *(int **)(Gameplay_Inventory_Model_InventoryConstants_TypeInfo + 0x5c);
		            }
		            if (iVar5 < piVar4[1]) {
		              return 1;
		            }
		          }
		        }
		        uVar1 = 0;
		        iVar5 = *param2;
		        if (*(ushort *)(iVar5 + 0xb6) != 0) {
		          do {
		            if (Gameplay_Inventory_View_IArtifactView_TypeInfo ==
		                *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		              puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd0)
		              ;
		              goto code_r0x811dd8d4;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		        }
		        puVar2 = (uint *)func_ii_1080(param2,Gameplay_Inventory_View_IArtifactView_TypeInfo,2);
		code_r0x811dd8d4:
		        iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		        if (*(int *)(iVar5 + 0x80) == 1) {
		          iVar5 = *(int *)(iVar5 + 0x7c);
		          if (DAT_ram_00a5a162 == '\0') {
		            Mono_Security_ASN1__get_Item(&Gameplay_Inventory_Model_InventoryConstants_TypeInfo);
		            DAT_ram_00a5a162 = '\x01';
		          }
		          if (*(int *)(Gameplay_Inventory_Model_InventoryConstants_TypeInfo + 0x74) == 0) {
		            func_ii_306000(Gameplay_Inventory_Model_InventoryConstants_TypeInfo);
		          }
		          uVar1 = (uint)(*(int *)(*(int *)(Gameplay_Inventory_Model_InventoryConstants_TypeInfo +
		                                          0x5c) + 4) <= iVar5);
		        }
		        else {
		          uVar1 = 0;
		        }
		      }
		    }
		  }
		  else {
		    uVar1 = 0;
		  }
		  return uVar1;
		}
		*/

}
