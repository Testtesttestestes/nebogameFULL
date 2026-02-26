using System;
using Gameplay.Inventory.View;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Gameplay.Inventory.ContextMenu
{
	// Token: 0x020006E5 RID: 1765
	[Token(Token = "0x20006E5")]
	public class TakeFromDropItemContextMenuElement : AbstractArtifactContextMenuElement
	{
		// Token: 0x17000809 RID: 2057
		// (get) Token: 0x06002A69 RID: 10857 RVA: 0x00008400 File Offset: 0x00006600
		[Token(Token = "0x17000809")]
		public override ArtikulMenuActionDic.Types.Actions ActionId
		{
			[Token(Token = "0x6002A69")]
			[Address(RVA = "0x7B0C", Offset = "0x7B0C", VA = "0x7B0C", Slot = "4")]
			get
			{
				return ArtikulMenuActionDic.Types.Actions.UnknownAction;
			}
		}

		// Token: 0x06002A6A RID: 10858 RVA: 0x00008418 File Offset: 0x00006618
		[Token(Token = "0x6002A6A")]
		[Address(RVA = "0x7B0D", Offset = "0x7B0D", VA = "0x7B0D", Slot = "5")]
		public override bool Validate(IArtifactView artifactView)
		{
		/* --- GHIDRA: Validate ---
		void Gameplay_Inventory_ContextMenu_TakeFromDropItemContextMenuElement__Validate
		               (undefined4 param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int iVar3;
		  int *piVar4;
		  int iVar5;
		  undefined4 uVar6;
		  
		  if (DAT_ram_00a5a1c8 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Data_ArtifactData___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Inventory_View_IArtifactView_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5a1c8 = '\x01';
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
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x150);
		        goto code_r0x811e1700;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x12);
		code_r0x811e1700:
		  iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		  uVar6 = *(undefined4 *)(iVar5 + 0x10);
		  uVar1 = 0;
		  piVar4 = (int *)Mono_Security_ASN1Convert__ToOid(Core_Data_ArtifactData___TypeInfo,1);
		  iVar5 = *param2;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Gameplay_Inventory_View_IArtifactView_TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd0);
		        goto code_r0x811e1796;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,Gameplay_Inventory_View_IArtifactView_TypeInfo,2);
		code_r0x811e1796:
		  iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  if ((iVar5 != 0) && (iVar3 = func_ii_1082(iVar5,*(undefined4 *)(*piVar4 + 0x20)), iVar3 == 0)) {
		    uVar6 = func_ii_1083();
		    func_ii_1050(uVar6,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar4[4] = iVar5;
		  Gameplay_ArtifactDrop_Control_ArtifactDropController__SellArtifacts(uVar6,piVar4,0);
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x06002A6B RID: 10859 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A6B")]
		[Address(RVA = "0x7B0E", Offset = "0x7B0E", VA = "0x7B0E", Slot = "7")]
		public override void Handle(IArtifactView artifactView)
		{
		}

		// Token: 0x06002A6C RID: 10860 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A6C")]
		[Address(RVA = "0x7B0F", Offset = "0x7B0F", VA = "0x7B0F")]
		public TakeFromDropItemContextMenuElement()
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_ActionId ---
		uint Gameplay_Inventory_ContextMenu_TakeFromDropItemContextMenuElement__get_ActionId
		               (undefined4 param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a5a1c7 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Inventory_View_IArtifactView_TypeInfo);
		    DAT_ram_00a5a1c7 = '\x01';
		  }
		  iVar3 = *param2;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Gameplay_Inventory_View_IArtifactView_TypeInfo ==
		          *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0xd0);
		        goto code_r0x811e161f;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,Gameplay_Inventory_View_IArtifactView_TypeInfo,2);
		code_r0x811e161f:
		  iVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  return (uint)(*(int *)(iVar3 + 0x80) == 2);
		}
		*/

}
