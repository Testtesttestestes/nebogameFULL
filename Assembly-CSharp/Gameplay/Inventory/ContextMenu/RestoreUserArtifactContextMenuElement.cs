using System;
using Gameplay.Inventory.View;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Gameplay.Inventory.ContextMenu
{
	// Token: 0x020006E1 RID: 1761
	[Token(Token = "0x20006E1")]
	public class RestoreUserArtifactContextMenuElement : AbstractArtifactContextMenuElement
	{
		// Token: 0x17000805 RID: 2053
		// (get) Token: 0x06002A58 RID: 10840 RVA: 0x00008340 File Offset: 0x00006540
		[Token(Token = "0x17000805")]
		public override ArtikulMenuActionDic.Types.Actions ActionId
		{
			[Token(Token = "0x6002A58")]
			[Address(RVA = "0x7AFB", Offset = "0x7AFB", VA = "0x7AFB", Slot = "4")]
			get
			{
				return ArtikulMenuActionDic.Types.Actions.UnknownAction;
			}
		}

		// Token: 0x06002A59 RID: 10841 RVA: 0x00008358 File Offset: 0x00006558
		[Token(Token = "0x6002A59")]
		[Address(RVA = "0x7AFC", Offset = "0x7AFC", VA = "0x7AFC", Slot = "5")]
		public override bool Validate(IArtifactView artifactView)
		{
		/* --- GHIDRA: Validate ---
		void Gameplay_Inventory_ContextMenu_RestoreUserArtifactContextMenuElement__Validate
		               (undefined4 param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  int iVar3;
		  
		  if (DAT_ram_00a5a1bf == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Inventory_View_IArtifactView_TypeInfo);
		    DAT_ram_00a5a1bf = '\x01';
		  }
		  iVar3 = *param2;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Gameplay_Inventory_View_IArtifactView_TypeInfo ==
		          *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0xd0);
		        goto code_r0x811e0904;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,Gameplay_Inventory_View_IArtifactView_TypeInfo,2);
		code_r0x811e0904:
		  param1_00 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  UI_Windows_RestoreArtifactWindow__HandleContent(param1_00,0);
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x06002A5A RID: 10842 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A5A")]
		[Address(RVA = "0x7AFD", Offset = "0x7AFD", VA = "0x7AFD", Slot = "7")]
		public override void Handle(IArtifactView artifactView)
		{
		}

		// Token: 0x06002A5B RID: 10843 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A5B")]
		[Address(RVA = "0x7AFE", Offset = "0x7AFE", VA = "0x7AFE")]
		public RestoreUserArtifactContextMenuElement()
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_ActionId ---
		undefined4
		Gameplay_Inventory_ContextMenu_RestoreUserArtifactContextMenuElement__get_ActionId
		          (undefined4 param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a5a1be == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Inventory_View_IArtifactView_TypeInfo);
		    DAT_ram_00a5a1be = '\x01';
		  }
		  iVar4 = *param2;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Gameplay_Inventory_View_IArtifactView_TypeInfo ==
		          *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xd0);
		        goto code_r0x811e085e;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,Gameplay_Inventory_View_IArtifactView_TypeInfo,2);
		code_r0x811e085e:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  uVar3 = Core_Data_ArtifactData__get_Rank(uVar3,0);
		  return uVar3;
		}
		*/

}
