using System;
using Gameplay.Inventory.View;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Gameplay.Inventory.ContextMenu
{
	// Token: 0x020006E9 RID: 1769
	[Token(Token = "0x20006E9")]
	public class ToBagArtifactContextMenuElement : AbstractArtifactContextMenuElement
	{
		// Token: 0x1700080D RID: 2061
		// (get) Token: 0x06002A79 RID: 10873 RVA: 0x000084C0 File Offset: 0x000066C0
		[Token(Token = "0x1700080D")]
		public override ArtikulMenuActionDic.Types.Actions ActionId
		{
			[Token(Token = "0x6002A79")]
			[Address(RVA = "0x7B1C", Offset = "0x7B1C", VA = "0x7B1C", Slot = "4")]
			get
			{
				return ArtikulMenuActionDic.Types.Actions.UnknownAction;
			}
		}

		// Token: 0x06002A7A RID: 10874 RVA: 0x000084D8 File Offset: 0x000066D8
		[Token(Token = "0x6002A7A")]
		[Address(RVA = "0x7B1D", Offset = "0x7B1D", VA = "0x7B1D", Slot = "5")]
		public override bool Validate(IArtifactView artifactView)
		{
		/* --- GHIDRA: Validate ---
		void Gameplay_Inventory_ContextMenu_ToBagArtifactContextMenuElement__Validate
		               (undefined4 param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  undefined4 param2_00;
		  int *param1_01;
		  int iVar3;
		  
		  if (DAT_ram_00a5a1d0 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Inventory_View_IArtifactView_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5a1d0 = '\x01';
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
		        goto code_r0x811e2992;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0xc);
		code_r0x811e2992:
		  uVar1 = 0;
		  param1_00 = (**(code **)((ulonglong)*puVar2 * 4))(param1_01,puVar2[1]);
		  iVar3 = *param2;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Gameplay_Inventory_View_IArtifactView_TypeInfo ==
		          *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0xd0);
		        goto code_r0x811e2a16;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,Gameplay_Inventory_View_IArtifactView_TypeInfo,2);
		code_r0x811e2a16:
		  param2_00 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  Core_Gameplay_Managers_Inventory_InventoryManager__SellItem(param1_00,param2_00,0);
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x06002A7B RID: 10875 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A7B")]
		[Address(RVA = "0x7B1E", Offset = "0x7B1E", VA = "0x7B1E", Slot = "7")]
		public override void Handle(IArtifactView artifactView)
		{
		}

		// Token: 0x06002A7C RID: 10876 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A7C")]
		[Address(RVA = "0x7B1F", Offset = "0x7B1F", VA = "0x7B1F")]
		public ToBagArtifactContextMenuElement()
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_ActionId ---
		uint Gameplay_Inventory_ContextMenu_ToBagArtifactContextMenuElement__get_ActionId
		               (undefined4 param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  int iVar3;
		  int *param1_01;
		  int iVar4;
		  int iVar5;
		  
		  if (DAT_ram_00a5a1cf == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Inventory_View_IArtifactView_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5a1cf = '\x01';
		  }
		  iVar5 = *param2;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Gameplay_Inventory_View_IArtifactView_TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd0);
		        goto code_r0x811e279f;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,Gameplay_Inventory_View_IArtifactView_TypeInfo,2);
		code_r0x811e279f:
		  iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  iVar3 = *(int *)(iVar5 + 0x70);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  param1_01 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar4 = *param1_01;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x140);
		        goto code_r0x811e284c;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x811e284c:
		  uVar1 = 0;
		  param1_00 = (**(code **)((ulonglong)*puVar2 * 4))(param1_01,puVar2[1]);
		  iVar4 = func_ii_7112(param1_00,0);
		  if ((iVar4 == iVar3) && (*(int *)(iVar5 + 0x80) == 1)) {
		    iVar5 = *(int *)(iVar5 + 0x7c);
		    if (DAT_ram_00a5a162 == '\0') {
		      Mono_Security_ASN1__get_Item(&Gameplay_Inventory_Model_InventoryConstants_TypeInfo);
		      DAT_ram_00a5a162 = '\x01';
		    }
		    if (*(int *)(Gameplay_Inventory_Model_InventoryConstants_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_Inventory_Model_InventoryConstants_TypeInfo);
		    }
		    uVar1 = (uint)(*(int *)(*(int *)(Gameplay_Inventory_Model_InventoryConstants_TypeInfo + 0x5c) +
		                           4) <= iVar5);
		  }
		  return uVar1;
		}
		*/

}
