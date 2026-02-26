using System;
using Gameplay.Inventory.ContextMenu;
using Gameplay.Inventory.View;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Gameplay.Portals.View.ContextMenu
{
	// Token: 0x020005CC RID: 1484
	[Token(Token = "0x20005CC")]
	public class BuyPortalsContextMenuElement : AbstractArtifactContextMenuElement
	{
		// Token: 0x1700069F RID: 1695
		// (get) Token: 0x06002386 RID: 9094 RVA: 0x00006E28 File Offset: 0x00005028
		[Token(Token = "0x1700069F")]
		public override ArtikulMenuActionDic.Types.Actions ActionId
		{
			[Token(Token = "0x6002386")]
			[Address(RVA = "0x74D8", Offset = "0x74D8", VA = "0x74D8", Slot = "4")]
			get
			{
				return ArtikulMenuActionDic.Types.Actions.UnknownAction;
			}
		}

		// Token: 0x06002387 RID: 9095 RVA: 0x00006E40 File Offset: 0x00005040
		[Token(Token = "0x6002387")]
		[Address(RVA = "0x74D9", Offset = "0x74D9", VA = "0x74D9", Slot = "5")]
		public override bool Validate(IArtifactView artifactView)
		{
		/* --- GHIDRA: Validate ---
		void Gameplay_Portals_View_ContextMenu_BuyPortalsContextMenuElement__Validate
		               (undefined4 param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a58116 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Inventory_Controller_ArtifactViewEvents_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Inventory_View_IArtifactView_TypeInfo);
		    DAT_ram_00a58116 = '\x01';
		  }
		  iVar3 = *param2;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Gameplay_Inventory_View_IArtifactView_TypeInfo ==
		          *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0xd0);
		        goto code_r0x80ea44c8;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,Gameplay_Inventory_View_IArtifactView_TypeInfo,2);
		code_r0x80ea44c8:
		  iVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  if ((*(int *)(iVar3 + 0x80) == 7) &&
		     (iVar3 = *(int *)(*(int *)(Gameplay_Inventory_Controller_ArtifactViewEvents_TypeInfo + 0x5c) +
		                      4), iVar3 != 0)) {
		    (**(code **)((ulonglong)*(uint *)(iVar3 + 0xc) * 4))
		              (*(undefined4 *)(iVar3 + 0x20),param2,*(undefined4 *)(iVar3 + 0x14));
		  }
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x06002388 RID: 9096 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002388")]
		[Address(RVA = "0x74DA", Offset = "0x74DA", VA = "0x74DA", Slot = "7")]
		public override void Handle(IArtifactView artifactView)
		{
		}

		// Token: 0x06002389 RID: 9097 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002389")]
		[Address(RVA = "0x74DB", Offset = "0x74DB", VA = "0x74DB")]
		public BuyPortalsContextMenuElement()
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Gameplay_Portals_View_ContextMenu_BuyPortalsContextMenuElement___ctor(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a58117 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_GameObject_GetComponent_CanvasGroup___);
		    DAT_ram_00a58117 = '\x01';
		  }
		  if (*(int *)(param1 + 0x20) != 0) {
		    return *(undefined4 *)(param1 + 0x20);
		  }
		  uVar1 = func_ii_6601(*(undefined4 *)(param1 + 0x14),
		                       Method_UnityEngine_GameObject_GetComponent_CanvasGroup___);
		  *(undefined4 *)(param1 + 0x20) = uVar1;
		  return uVar1;
		}
		*/

		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_ActionId ---
		uint Gameplay_Portals_View_ContextMenu_BuyPortalsContextMenuElement__get_ActionId
		               (undefined4 param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a58115 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Inventory_View_IArtifactView_TypeInfo);
		    DAT_ram_00a58115 = '\x01';
		  }
		  iVar3 = *param2;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Gameplay_Inventory_View_IArtifactView_TypeInfo ==
		          *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0xd0);
		        goto code_r0x80ea4417;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,Gameplay_Inventory_View_IArtifactView_TypeInfo,2);
		code_r0x80ea4417:
		  iVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  return (uint)(*(int *)(iVar3 + 0x80) == 7);
		}
		*/

}
