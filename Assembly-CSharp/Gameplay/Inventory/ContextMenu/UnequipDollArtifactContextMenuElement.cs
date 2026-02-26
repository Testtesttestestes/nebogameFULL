using System;
using Gameplay.Inventory.View;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Gameplay.Inventory.ContextMenu
{
	// Token: 0x020006EE RID: 1774
	[Token(Token = "0x20006EE")]
	public class UnequipDollArtifactContextMenuElement : AbstractArtifactContextMenuElement
	{
		// Token: 0x17000812 RID: 2066
		// (get) Token: 0x06002A8D RID: 10893 RVA: 0x000085B0 File Offset: 0x000067B0
		[Token(Token = "0x17000812")]
		public override ArtikulMenuActionDic.Types.Actions ActionId
		{
			[Token(Token = "0x6002A8D")]
			[Address(RVA = "0x7B30", Offset = "0x7B30", VA = "0x7B30", Slot = "4")]
			get
			{
				return ArtikulMenuActionDic.Types.Actions.UnknownAction;
			}
		}

		// Token: 0x06002A8E RID: 10894 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A8E")]
		[Address(RVA = "0x7B31", Offset = "0x7B31", VA = "0x7B31", Slot = "7")]
		public override void Handle(IArtifactView artifactView)
		{
		/* --- GHIDRA: Handle ---
		undefined4
		Gameplay_Inventory_ContextMenu_UnequipDollArtifactContextMenuElement__Handle
		          (undefined4 param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a5a1da == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Inventory_View_IArtifactView_TypeInfo);
		    DAT_ram_00a5a1da = '\x01';
		  }
		  iVar4 = *param2;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Gameplay_Inventory_View_IArtifactView_TypeInfo ==
		          *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xd0);
		        goto code_r0x811e3c09;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,Gameplay_Inventory_View_IArtifactView_TypeInfo,2);
		code_r0x811e3c09:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  iVar4 = Core_Data_ArtikulData__set_TargetRequirements(uVar3,0);
		  if (iVar4 == 0) {
		    uVar3 = 0;
		  }
		  else {
		    uVar1 = 0;
		    iVar4 = *param2;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      do {
		        if (Gameplay_Inventory_View_IArtifactView_TypeInfo ==
		            *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xd0);
		          goto code_r0x811e3c95;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param2,Gameplay_Inventory_View_IArtifactView_TypeInfo,2);
		code_r0x811e3c95:
		    iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		    if (*(int *)(iVar4 + 0x80) == 1) {
		      uVar3 = Gameplay_Inventory_Model_InventoryUtils__IsBagSlot
		                        (*(undefined4 *)(iVar4 + 0x7c),iVar4);
		    }
		    else {
		      uVar3 = 0;
		    }
		  }
		  return uVar3;
		}
		*/

		}

		// Token: 0x06002A8F RID: 10895 RVA: 0x000085C8 File Offset: 0x000067C8
		[Token(Token = "0x6002A8F")]
		[Address(RVA = "0x7B32", Offset = "0x7B32", VA = "0x7B32", Slot = "5")]
		public override bool Validate(IArtifactView artifactView)
		{
			return default(bool);
		}

		// Token: 0x06002A90 RID: 10896 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A90")]
		[Address(RVA = "0x7B33", Offset = "0x7B33", VA = "0x7B33")]
		public UnequipDollArtifactContextMenuElement()
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_ActionId ---
		void Gameplay_Inventory_ContextMenu_UnequipDollArtifactContextMenuElement__get_ActionId
		               (undefined4 param1,int *param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000014;
		  undefined4 uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  undefined8 uVar3;
		  int *param1_01;
		  int iVar4;
		  undefined4 param1_02;
		  uint uVar5;
		  
		  if (DAT_ram_00a5a1d9 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Inventory_View_IArtifactView_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5a1d9 = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar5 = 0;
		  param1_01 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar4 = *param1_01;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar5 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar5 * 8 + 4) * 8 + iVar4 + 600);
		        goto code_r0x811e3a53;
		      }
		      uVar5 = uVar5 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar5);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0x33);
		code_r0x811e3a53:
		  uVar3 = CONCAT44(in_register_20000014,puVar2[1]);
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(param1_01,uVar3);
		  uVar1 = (undefined4)((ulonglong)uVar3 >> 0x20);
		  param1_02 = *(undefined4 *)(iVar4 + 0x1c);
		  uVar5 = 0;
		  iVar4 = *param2;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Gameplay_Inventory_View_IArtifactView_TypeInfo ==
		          *(int *)(*(int *)(iVar4 + 0x58) + uVar5 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar5 * 8 + 4) * 8 + iVar4 + 0xd0);
		        goto code_r0x811e3ad6;
		      }
		      uVar5 = uVar5 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar5);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,Gameplay_Inventory_View_IArtifactView_TypeInfo,2);
		code_r0x811e3ad6:
		  uVar5 = 0;
		  uVar3 = CONCAT44(uVar1,puVar2[1]);
		  param1_00 = (**(code **)((ulonglong)*puVar2 * 4))(param2,uVar3);
		  uVar1 = (undefined4)((ulonglong)uVar3 >> 0x20);
		  uVar3 = func_ii_7957(param1_00,0);
		  iVar4 = *param2;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Gameplay_Inventory_View_IArtifactView_TypeInfo ==
		          *(int *)(*(int *)(iVar4 + 0x58) + uVar5 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar5 * 8 + 4) * 8 + iVar4 + 0xd0);
		        goto code_r0x811e3b62;
		      }
		      uVar5 = uVar5 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar5);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,Gameplay_Inventory_View_IArtifactView_TypeInfo,2);
		code_r0x811e3b62:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(param2,CONCAT44(uVar1,puVar2[1]));
		  Gameplay_WorldAxis_Controller_WorldAxisController__FromGolemToDollResultHandler
		            (param1_02,uVar3,*(undefined4 *)(iVar4 + 0x7c),0);
		  return;
		}
		*/

}
