using System;
using Gameplay.Inventory.View;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Gameplay.Inventory.ContextMenu
{
	// Token: 0x020006D1 RID: 1745
	[Token(Token = "0x20006D1")]
	public class EquipArtifactFromDropContextMenuElement : AbstractArtifactContextMenuElement
	{
		// Token: 0x170007F5 RID: 2037
		// (get) Token: 0x06002A1C RID: 10780 RVA: 0x00008070 File Offset: 0x00006270
		[Token(Token = "0x170007F5")]
		public override ArtikulMenuActionDic.Types.Actions ActionId
		{
			[Token(Token = "0x6002A1C")]
			[Address(RVA = "0x7ABF", Offset = "0x7ABF", VA = "0x7ABF", Slot = "4")]
			get
			{
				return ArtikulMenuActionDic.Types.Actions.UnknownAction;
			}
		}

		// Token: 0x06002A1D RID: 10781 RVA: 0x00008088 File Offset: 0x00006288
		[Token(Token = "0x6002A1D")]
		[Address(RVA = "0x7AC0", Offset = "0x7AC0", VA = "0x7AC0", Slot = "5")]
		public override bool Validate(IArtifactView artifactView)
		{
		/* --- GHIDRA: Validate ---
		void Gameplay_Inventory_ContextMenu_EquipArtifactFromDropContextMenuElement__Validate
		               (undefined4 param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param2_00;
		  int *param1_00;
		  int iVar3;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a5a1a4 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Inventory_View_IArtifactView_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5a1a4 = '\x01';
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
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x150);
		        goto code_r0x811dd2e4;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x12);
		code_r0x811dd2e4:
		  iVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  param1_01 = *(undefined4 *)(iVar3 + 0x10);
		  uVar1 = 0;
		  iVar3 = *param2;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Gameplay_Inventory_View_IArtifactView_TypeInfo ==
		          *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0xd0);
		        goto code_r0x811dd36b;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,Gameplay_Inventory_View_IArtifactView_TypeInfo,2);
		code_r0x811dd36b:
		  param2_00 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  Gameplay_ArtifactDrop_Control_ArtifactDropController__TakeArtifacts(param1_01,param2_00,0);
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x06002A1E RID: 10782 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A1E")]
		[Address(RVA = "0x7AC1", Offset = "0x7AC1", VA = "0x7AC1", Slot = "7")]
		public override void Handle(IArtifactView artifactView)
		{
		}

		// Token: 0x06002A1F RID: 10783 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A1F")]
		[Address(RVA = "0x7AC2", Offset = "0x7AC2", VA = "0x7AC2")]
		public EquipArtifactFromDropContextMenuElement()
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_ActionId ---
		uint Gameplay_Inventory_ContextMenu_EquipArtifactFromDropContextMenuElement__get_ActionId
		               (undefined4 param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a5a1a3 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Inventory_View_IArtifactView_TypeInfo);
		    DAT_ram_00a5a1a3 = '\x01';
		  }
		  iVar4 = *param2;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Gameplay_Inventory_View_IArtifactView_TypeInfo ==
		          *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xd0);
		        goto code_r0x811dd069;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,Gameplay_Inventory_View_IArtifactView_TypeInfo,2);
		code_r0x811dd069:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  iVar4 = Core_Data_ArtifactData__get_Rank(uVar3,0);
		  if (iVar4 == 0) {
		    uVar1 = 0;
		    iVar4 = *param2;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      do {
		        if (Gameplay_Inventory_View_IArtifactView_TypeInfo ==
		            *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xd0);
		          goto code_r0x811dd0f4;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param2,Gameplay_Inventory_View_IArtifactView_TypeInfo,2);
		code_r0x811dd0f4:
		    uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		    iVar4 = Core_Data_ArtikulData__get_IsEquipment(uVar3,0);
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
		            goto code_r0x811dd17e;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		      }
		      puVar2 = (uint *)func_ii_1080(param2,Gameplay_Inventory_View_IArtifactView_TypeInfo,2);
		code_r0x811dd17e:
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
		              goto code_r0x811dd20a;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		        }
		        puVar2 = (uint *)func_ii_1080(param2,Gameplay_Inventory_View_IArtifactView_TypeInfo,2);
		code_r0x811dd20a:
		        iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		        uVar1 = (uint)(*(int *)(iVar4 + 0x80) == 2);
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
