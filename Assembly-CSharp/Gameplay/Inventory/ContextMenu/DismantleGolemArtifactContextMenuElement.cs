using System;
using Gameplay.Inventory.View;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Gameplay.Inventory.ContextMenu
{
	// Token: 0x020006D0 RID: 1744
	[Token(Token = "0x20006D0")]
	public class DismantleGolemArtifactContextMenuElement : AbstractArtifactContextMenuElement
	{
		// Token: 0x170007F4 RID: 2036
		// (get) Token: 0x06002A18 RID: 10776 RVA: 0x00008040 File Offset: 0x00006240
		[Token(Token = "0x170007F4")]
		public override ArtikulMenuActionDic.Types.Actions ActionId
		{
			[Token(Token = "0x6002A18")]
			[Address(RVA = "0x7ABB", Offset = "0x7ABB", VA = "0x7ABB", Slot = "4")]
			get
			{
				return ArtikulMenuActionDic.Types.Actions.UnknownAction;
			}
		}

		// Token: 0x06002A19 RID: 10777 RVA: 0x00008058 File Offset: 0x00006258
		[Token(Token = "0x6002A19")]
		[Address(RVA = "0x7ABC", Offset = "0x7ABC", VA = "0x7ABC", Slot = "5")]
		public override bool Validate(IArtifactView artifactView)
		{
		/* --- GHIDRA: Validate ---
		void Gameplay_Inventory_ContextMenu_DismantleGolemArtifactContextMenuElement__Validate
		               (undefined4 param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  int iVar5;
		  
		  if (DAT_ram_00a5a1a2 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Inventory_View_IArtifactView_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5a1a2 = '\x01';
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
		        goto code_r0x811dcf2c;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x2f);
		code_r0x811dcf2c:
		  iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		  piVar4 = *(int **)(iVar5 + 0x14);
		  uVar1 = 0;
		  iVar5 = *param2;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Gameplay_Inventory_View_IArtifactView_TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd0);
		        goto code_r0x811dcfb3;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,Gameplay_Inventory_View_IArtifactView_TypeInfo,2);
		code_r0x811dcfb3:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  iVar5 = *piVar4;
		  (**(code **)((ulonglong)*(uint *)(iVar5 + 0x128) * 4))
		            (piVar4,uVar3,0,0,*(undefined4 *)(iVar5 + 300));
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x06002A1A RID: 10778 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A1A")]
		[Address(RVA = "0x7ABD", Offset = "0x7ABD", VA = "0x7ABD", Slot = "7")]
		public override void Handle(IArtifactView artifactView)
		{
		}

		// Token: 0x06002A1B RID: 10779 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A1B")]
		[Address(RVA = "0x7ABE", Offset = "0x7ABE", VA = "0x7ABE")]
		public DismantleGolemArtifactContextMenuElement()
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_ActionId ---
		undefined4
		Gameplay_Inventory_ContextMenu_DismantleGolemArtifactContextMenuElement__get_ActionId
		          (undefined4 param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  undefined4 param1_00;
		  int iVar4;
		  int *param1_01;
		  int iVar5;
		  
		  if (DAT_ram_00a5a1a1 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Inventory_View_IArtifactView_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5a1a1 = '\x01';
		  }
		  iVar4 = *param2;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Gameplay_Inventory_View_IArtifactView_TypeInfo ==
		          *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xd0);
		        goto code_r0x811dcc90;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param2,Gameplay_Inventory_View_IArtifactView_TypeInfo,2);
		code_r0x811dcc90:
		  uVar2 = 0;
		  param1_00 = (**(code **)((ulonglong)*puVar3 * 4))(param2,puVar3[1]);
		  iVar4 = Core_Data_ArtifactData__get_IsTemporaryWithCriticalLifetime(param1_00,0);
		  if (((iVar4 == 0) && (iVar4 = Core_Data_ArtikulData__get_IsDollItem(param1_00,0), iVar4 != 0)) &&
		     (iVar4 = Core_Data_ArtifactData__get_Rank(param1_00,0), iVar4 == 0)) {
		    uVar1 = 0;
		    iVar4 = *param2;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      do {
		        if (Gameplay_Inventory_View_IArtifactView_TypeInfo ==
		            *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xd0);
		          goto code_r0x811dcd35;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(param2,Gameplay_Inventory_View_IArtifactView_TypeInfo,2);
		code_r0x811dcd35:
		    iVar4 = (**(code **)((ulonglong)*puVar3 * 4))(param2,puVar3[1]);
		    iVar4 = *(int *)(iVar4 + 0x70);
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    param1_01 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar5 = *param1_01;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x230);
		          goto code_r0x811dcde0;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0x2e);
		code_r0x811dcde0:
		    uVar2 = 0;
		    iVar5 = (**(code **)((ulonglong)*puVar3 * 4))(param1_01,puVar3[1]);
		    if (iVar4 == *(int *)(*(int *)(iVar5 + 0x10) + 0x20)) {
		      iVar4 = Core_Data_ArtikulData__get_IsDismantable(param1_00,0);
		      if (iVar4 != 0) {
		        uVar2 = Core_Data_ArtikulData__get_IsRepairable(param1_00,0);
		        return uVar2;
		      }
		      iVar4 = Core_Data_ArtikulData__get_IsDismantableInGolemSlot(param1_00,0);
		      if (iVar4 != 0) {
		        if (DAT_ram_00a6456f == '\0') {
		          Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		          DAT_ram_00a6456f = '\x01';
		        }
		        iVar4 = Unity_Properties_PropertyMember___ctor
		                          (0x2e,Core_Gameplay_IGame_TypeInfo,
		                           **(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c));
		        uVar2 = Gameplay_Clans_Model_ClansModel__set_GolemUserData(*(undefined4 *)(iVar4 + 0x10),0);
		      }
		    }
		  }
		  return uVar2;
		}
		*/

}
