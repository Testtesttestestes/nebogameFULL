using System;
using Gameplay.Inventory.ContextMenu;
using Gameplay.Inventory.View;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Gameplay.ThemeDuel.View.ContextMenu
{
	// Token: 0x020004E3 RID: 1251
	[Token(Token = "0x20004E3")]
	public class BuyThemeDuelContextMenuElement : AbstractArtifactContextMenuElement
	{
		// Token: 0x1700056E RID: 1390
		// (get) Token: 0x06001DE7 RID: 7655 RVA: 0x000063C0 File Offset: 0x000045C0
		[Token(Token = "0x1700056E")]
		public override ArtikulMenuActionDic.Types.Actions ActionId
		{
			[Token(Token = "0x6001DE7")]
			[Address(RVA = "0x6F65", Offset = "0x6F65", VA = "0x6F65", Slot = "4")]
			get
			{
				return ArtikulMenuActionDic.Types.Actions.UnknownAction;
			}
		}

		// Token: 0x06001DE8 RID: 7656 RVA: 0x000063D8 File Offset: 0x000045D8
		[Token(Token = "0x6001DE8")]
		[Address(RVA = "0x6F66", Offset = "0x6F66", VA = "0x6F66", Slot = "5")]
		public override bool Validate(IArtifactView artifactView)
		{
		/* --- GHIDRA: Validate ---
		void Gameplay_ThemeDuel_View_ContextMenu_BuyThemeDuelContextMenuElement__Validate
		               (undefined4 param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a585cf == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Inventory_Controller_ArtifactViewEvents_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Inventory_View_IArtifactView_TypeInfo);
		    DAT_ram_00a585cf = '\x01';
		  }
		  iVar3 = *param2;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Gameplay_Inventory_View_IArtifactView_TypeInfo ==
		          *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0xd0);
		        goto code_r0x80f0fad9;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,Gameplay_Inventory_View_IArtifactView_TypeInfo,2);
		code_r0x80f0fad9:
		  iVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  if ((*(int *)(iVar3 + 0x80) == 6) &&
		     (iVar3 = **(int **)(Gameplay_Inventory_Controller_ArtifactViewEvents_TypeInfo + 0x5c),
		     iVar3 != 0)) {
		    (**(code **)((ulonglong)*(uint *)(iVar3 + 0xc) * 4))
		              (*(undefined4 *)(iVar3 + 0x20),param2,*(undefined4 *)(iVar3 + 0x14));
		  }
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x06001DE9 RID: 7657 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DE9")]
		[Address(RVA = "0x6F67", Offset = "0x6F67", VA = "0x6F67", Slot = "7")]
		public override void Handle(IArtifactView artifactView)
		{
		}

		// Token: 0x06001DEA RID: 7658 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DEA")]
		[Address(RVA = "0x6F68", Offset = "0x6F68", VA = "0x6F68")]
		public BuyThemeDuelContextMenuElement()
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_ActionId ---
		uint Gameplay_ThemeDuel_View_ContextMenu_BuyThemeDuelContextMenuElement__get_ActionId
		               (undefined4 param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a585ce == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Inventory_View_IArtifactView_TypeInfo);
		    DAT_ram_00a585ce = '\x01';
		  }
		  iVar3 = *param2;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Gameplay_Inventory_View_IArtifactView_TypeInfo ==
		          *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0xd0);
		        goto code_r0x80f0fa28;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,Gameplay_Inventory_View_IArtifactView_TypeInfo,2);
		code_r0x80f0fa28:
		  iVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  return (uint)(*(int *)(iVar3 + 0x80) == 6);
		}
		*/

}
