using System;
using Gameplay.Inventory.View;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Gameplay.Inventory.ContextMenu
{
	// Token: 0x020006D2 RID: 1746
	[Token(Token = "0x20006D2")]
	public class EquipDollArtifactContextMenuElement : AbstractArtifactContextMenuElement
	{
		// Token: 0x170007F6 RID: 2038
		// (get) Token: 0x06002A20 RID: 10784 RVA: 0x000080A0 File Offset: 0x000062A0
		[Token(Token = "0x170007F6")]
		public override ArtikulMenuActionDic.Types.Actions ActionId
		{
			[Token(Token = "0x6002A20")]
			[Address(RVA = "0x7AC3", Offset = "0x7AC3", VA = "0x7AC3", Slot = "4")]
			get
			{
				return ArtikulMenuActionDic.Types.Actions.UnknownAction;
			}
		}

		// Token: 0x06002A21 RID: 10785 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A21")]
		[Address(RVA = "0x7AC4", Offset = "0x7AC4", VA = "0x7AC4", Slot = "7")]
		public override void Handle(IArtifactView artifactView)
		{
		/* --- GHIDRA: Handle ---
		undefined4
		Gameplay_Inventory_ContextMenu_EquipDollArtifactContextMenuElement__Handle
		          (undefined4 param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a5a1a6 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Inventory_View_IArtifactView_TypeInfo);
		    DAT_ram_00a5a1a6 = '\x01';
		  }
		  iVar4 = *param2;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Gameplay_Inventory_View_IArtifactView_TypeInfo ==
		          *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xd0);
		        goto code_r0x811dd58d;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,Gameplay_Inventory_View_IArtifactView_TypeInfo,2);
		code_r0x811dd58d:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  uVar3 = Core_Data_ArtikulData__set_TargetRequirements(uVar3,0);
		  return uVar3;
		}
		*/

		}

		// Token: 0x06002A22 RID: 10786 RVA: 0x000080B8 File Offset: 0x000062B8
		[Token(Token = "0x6002A22")]
		[Address(RVA = "0x7AC5", Offset = "0x7AC5", VA = "0x7AC5", Slot = "5")]
		public override bool Validate(IArtifactView artifactView)
		{
			return default(bool);
		}

		// Token: 0x06002A23 RID: 10787 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A23")]
		[Address(RVA = "0x7AC6", Offset = "0x7AC6", VA = "0x7AC6")]
		public EquipDollArtifactContextMenuElement()
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_ActionId ---
		void Gameplay_Inventory_ContextMenu_EquipDollArtifactContextMenuElement__get_ActionId
		               (undefined4 param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 in_register_20000014;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined8 uVar4;
		  int *param1_00;
		  int iVar5;
		  undefined4 param1_01;
		  int iVar6;
		  
		  if (DAT_ram_00a5a1a5 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Inventory_View_IArtifactView_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5a1a5 = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar5 = *param1_00;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 600);
		        goto code_r0x811dd443;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x33);
		code_r0x811dd443:
		  uVar4 = CONCAT44(in_register_20000014,puVar2[1]);
		  iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,uVar4);
		  uVar3 = (undefined4)((ulonglong)uVar4 >> 0x20);
		  param1_01 = *(undefined4 *)(iVar5 + 0x1c);
		  uVar1 = 0;
		  iVar6 = *param2;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Gameplay_Inventory_View_IArtifactView_TypeInfo ==
		          *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0xd0);
		        goto code_r0x811dd4cc;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,Gameplay_Inventory_View_IArtifactView_TypeInfo,2);
		code_r0x811dd4cc:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param2,CONCAT44(uVar3,puVar2[1]));
		  uVar4 = func_ii_7957(uVar3,0);
		  Gameplay_WorldAxis_Controller_WorldAxisController__GetPartyInfoResultHandler
		            (param1_01,uVar4,
		             *(undefined8 *)(*(int *)(*(int *)(*(int *)(iVar5 + 0x14) + 0x24) + 0xc) + 0x10),
		             *(undefined4 *)(*(int *)(iVar5 + 0x14) + 0x2c),0);
		  return;
		}
		*/

}
