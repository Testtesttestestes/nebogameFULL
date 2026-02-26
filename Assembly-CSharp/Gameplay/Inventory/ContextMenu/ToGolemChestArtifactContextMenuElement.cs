using System;
using Gameplay.Inventory.View;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Gameplay.Inventory.ContextMenu
{
	// Token: 0x020006EC RID: 1772
	[Token(Token = "0x20006EC")]
	public class ToGolemChestArtifactContextMenuElement : AbstractArtifactContextMenuElement
	{
		// Token: 0x17000810 RID: 2064
		// (get) Token: 0x06002A85 RID: 10885 RVA: 0x00008550 File Offset: 0x00006750
		[Token(Token = "0x17000810")]
		public override ArtikulMenuActionDic.Types.Actions ActionId
		{
			[Token(Token = "0x6002A85")]
			[Address(RVA = "0x7B28", Offset = "0x7B28", VA = "0x7B28", Slot = "4")]
			get
			{
				return ArtikulMenuActionDic.Types.Actions.UnknownAction;
			}
		}

		// Token: 0x06002A86 RID: 10886 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A86")]
		[Address(RVA = "0x7B29", Offset = "0x7B29", VA = "0x7B29", Slot = "7")]
		public override void Handle(IArtifactView artifactView)
		{
		/* --- GHIDRA: Handle ---
		uint Gameplay_Inventory_ContextMenu_ToGolemChestArtifactContextMenuElement__Handle
		               (undefined4 param1,int *param2,undefined4 param3)
		
		{
		  uint *puVar1;
		  undefined4 uVar2;
		  longlong lVar3;
		  longlong lVar4;
		  int *piVar5;
		  int iVar6;
		  uint uVar7;
		  
		  if (DAT_ram_00a5a1d6 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Inventory_View_IArtifactView_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5a1d6 = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar7 = 0;
		  piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar7 * 8)) {
		        puVar1 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar7 * 8 + 4) * 8 + iVar6 + 0x230);
		        goto code_r0x811e338b;
		      }
		      uVar7 = uVar7 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar7);
		  }
		  puVar1 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x2e);
		code_r0x811e338b:
		  iVar6 = (**(code **)((ulonglong)*puVar1 * 4))(piVar5,puVar1[1]);
		  if (*(longlong *)(*(int *)(iVar6 + 0x10) + 0x10) == 0) {
		    return 0;
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar7 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar7 * 8)) {
		        puVar1 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar7 * 8 + 4) * 8 + iVar6 + 0x230);
		        goto code_r0x811e3442;
		      }
		      uVar7 = uVar7 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar7);
		  }
		  puVar1 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x2e);
		code_r0x811e3442:
		  iVar6 = (**(code **)((ulonglong)*puVar1 * 4))(piVar5,puVar1[1]);
		  if (*(int *)(*(int *)(iVar6 + 0x10) + 0x20) == 0) {
		    return 0;
		  }
		  uVar7 = 0;
		  iVar6 = *param2;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Gameplay_Inventory_View_IArtifactView_TypeInfo ==
		          *(int *)(*(int *)(iVar6 + 0x58) + uVar7 * 8)) {
		        puVar1 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar7 * 8 + 4) * 8 + iVar6 + 0xd0);
		        goto code_r0x811e34cd;
		      }
		      uVar7 = uVar7 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar7);
		  }
		  puVar1 = (uint *)func_ii_1080(param2,Gameplay_Inventory_View_IArtifactView_TypeInfo,2);
		code_r0x811e34cd:
		  uVar2 = (**(code **)((ulonglong)*puVar1 * 4))(param2,puVar1[1]);
		  iVar6 = Core_Data_ArtikulData__get_IsDollItem(uVar2,0);
		  if (iVar6 == 0) {
		    uVar7 = 0;
		  }
		  else {
		    uVar7 = 0;
		    iVar6 = *param2;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      do {
		        if (Gameplay_Inventory_View_IArtifactView_TypeInfo ==
		            *(int *)(*(int *)(iVar6 + 0x58) + uVar7 * 8)) {
		          puVar1 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar7 * 8 + 4) * 8 + iVar6 + 0xd0);
		          goto code_r0x811e3559;
		        }
		        uVar7 = uVar7 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar7);
		    }
		    puVar1 = (uint *)func_ii_1080(param2,Gameplay_Inventory_View_IArtifactView_TypeInfo,2);
		code_r0x811e3559:
		    iVar6 = (**(code **)((ulonglong)*puVar1 * 4))(param2,puVar1[1]);
		    lVar3 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                      (*(undefined4 *)(iVar6 + 0x70),0);
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar6 = *piVar5;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      uVar7 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar7 * 8)) {
		          puVar1 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar7 * 8 + 4) * 8 + iVar6 + 0x140);
		          goto code_r0x811e360a;
		        }
		        uVar7 = uVar7 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar7);
		    }
		    puVar1 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x811e360a:
		    uVar2 = (**(code **)((ulonglong)*puVar1 * 4))(piVar5,puVar1[1]);
		    uVar2 = func_ii_7112(uVar2,0);
		    lVar4 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext(uVar2,0);
		    uVar7 = (uint)(lVar4 == lVar3);
		  }
		  return uVar7;
		}
		*/

		}

		// Token: 0x06002A87 RID: 10887 RVA: 0x00008568 File Offset: 0x00006768
		[Token(Token = "0x6002A87")]
		[Address(RVA = "0x7B2A", Offset = "0x7B2A", VA = "0x7B2A", Slot = "5")]
		public override bool Validate(IArtifactView artifactView)
		{
			return default(bool);
		}

		// Token: 0x06002A88 RID: 10888 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A88")]
		[Address(RVA = "0x7B2B", Offset = "0x7B2B", VA = "0x7B2B")]
		public ToGolemChestArtifactContextMenuElement()
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_ActionId ---
		void Gameplay_Inventory_ContextMenu_ToGolemChestArtifactContextMenuElement__get_ActionId
		               (undefined4 param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  int iVar5;
		  
		  if (DAT_ram_00a5a1d5 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Inventory_View_IArtifactView_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5a1d5 = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  piVar4 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x238);
		        goto code_r0x811e321c;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x2f);
		code_r0x811e321c:
		  iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		  piVar4 = *(int **)(iVar5 + 0x14);
		  uVar1 = 0;
		  iVar5 = *param2;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Gameplay_Inventory_View_IArtifactView_TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd0);
		        goto code_r0x811e32a3;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,Gameplay_Inventory_View_IArtifactView_TypeInfo,2);
		code_r0x811e32a3:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  iVar5 = *piVar4;
		  (**(code **)((ulonglong)*(uint *)(iVar5 + 0x138) * 4))
		            (piVar4,uVar3,*(undefined4 *)(iVar5 + 0x13c));
		  return;
		}
		*/

}
