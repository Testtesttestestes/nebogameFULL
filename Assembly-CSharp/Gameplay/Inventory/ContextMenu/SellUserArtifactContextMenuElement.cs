using System;
using Gameplay.Inventory.View;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Gameplay.Inventory.ContextMenu
{
	// Token: 0x020006E3 RID: 1763
	[Token(Token = "0x20006E3")]
	public class SellUserArtifactContextMenuElement : AbstractArtifactContextMenuElement
	{
		// Token: 0x17000807 RID: 2055
		// (get) Token: 0x06002A60 RID: 10848 RVA: 0x000083A0 File Offset: 0x000065A0
		[Token(Token = "0x17000807")]
		public override ArtikulMenuActionDic.Types.Actions ActionId
		{
			[Token(Token = "0x6002A60")]
			[Address(RVA = "0x7B03", Offset = "0x7B03", VA = "0x7B03", Slot = "4")]
			get
			{
				return ArtikulMenuActionDic.Types.Actions.UnknownAction;
			}
		}

		// Token: 0x06002A61 RID: 10849 RVA: 0x000083B8 File Offset: 0x000065B8
		[Token(Token = "0x6002A61")]
		[Address(RVA = "0x7B04", Offset = "0x7B04", VA = "0x7B04", Slot = "5")]
		public override bool Validate(IArtifactView artifactView)
		{
		/* --- GHIDRA: Validate ---
		void Gameplay_Inventory_ContextMenu_SellUserArtifactContextMenuElement__Validate
		               (undefined4 param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  int iVar5;
		  int iVar6;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5a1c3 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_ArtikulDic__uint__get_Data__)
		    ;
		    Mono_Security_ASN1__get_Item(&Core_Data_ArtifactData___TypeInfo);
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Inventory_View_IArtifactView_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_280);
		    Mono_Security_ASN1__get_Item(&StringLiteral_16468);
		    DAT_ram_00a5a1c3 = '\x01';
		  }
		  iVar6 = *param2;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Gameplay_Inventory_View_IArtifactView_TypeInfo ==
		          *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0xd0);
		        goto code_r0x811e0fdd;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,Gameplay_Inventory_View_IArtifactView_TypeInfo,2);
		code_r0x811e0fdd:
		  iVar6 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  local_8 = func_ii_7957(iVar6,0);
		  uVar3 = func_ii_8783(&local_8,0);
		  uVar3 = System_Int32__ToString
		                    (StringLiteral_16468,uVar3,StringLiteral_280,
		                     *(undefined4 *)(*(int *)(*(int *)(iVar6 + 8) + 0x10) + 0x18),0);
		  if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		    func_ii_306000(OKG_Logs_Debug_TypeInfo);
		  }
		  System_Collections_Generic_Dictionary_uint__object___get_Count(uVar3,0);
		  if (*(int *)(iVar6 + 0x80) == 2) {
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
		          goto code_r0x811e11a9;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x12);
		code_r0x811e11a9:
		    iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		    uVar3 = *(undefined4 *)(iVar5 + 0x10);
		    piVar4 = (int *)Mono_Security_ASN1Convert__ToOid(Core_Data_ArtifactData___TypeInfo,1);
		    if ((iVar6 != 0) && (iVar5 = func_ii_1082(iVar6,*(undefined4 *)(*piVar4 + 0x20)), iVar5 == 0)) {
		      uVar3 = func_ii_1083();
		      func_ii_1050(uVar3,0);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    piVar4[4] = iVar6;
		    Gameplay_ArtifactDrop_Control_ArtifactDropController__SellAllDrop(uVar3,piVar4,0);
		  }
		  else {
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
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x120);
		          goto code_r0x811e10f6;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0xc);
		code_r0x811e10f6:
		    uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		    Core_Gameplay_Managers_Inventory_InventoryManager__BuySlots(uVar3,iVar6,0);
		  }
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x06002A62 RID: 10850 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A62")]
		[Address(RVA = "0x7B05", Offset = "0x7B05", VA = "0x7B05", Slot = "7")]
		public override void Handle(IArtifactView artifactView)
		{
		}

		// Token: 0x06002A63 RID: 10851 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A63")]
		[Address(RVA = "0x7B06", Offset = "0x7B06", VA = "0x7B06")]
		public SellUserArtifactContextMenuElement()
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_ActionId ---
		undefined4
		Gameplay_Inventory_ContextMenu_SellUserArtifactContextMenuElement__get_ActionId
		          (undefined4 param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int iVar3;
		  int *param1_00;
		  int iVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a5a1c2 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Inventory_View_IArtifactView_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5a1c2 = '\x01';
		  }
		  iVar3 = *param2;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Gameplay_Inventory_View_IArtifactView_TypeInfo ==
		          *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0xd0);
		        goto code_r0x811e0d2a;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,Gameplay_Inventory_View_IArtifactView_TypeInfo,2);
		code_r0x811e0d2a:
		  iVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  if (*(int *)(iVar3 + 0x80) == 2) {
		    uVar5 = 1;
		  }
		  else {
		    uVar1 = 0;
		    iVar3 = *param2;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      do {
		        if (Gameplay_Inventory_View_IArtifactView_TypeInfo ==
		            *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0xd0);
		          goto code_r0x811e0db9;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param2,Gameplay_Inventory_View_IArtifactView_TypeInfo,2);
		code_r0x811e0db9:
		    iVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		    if (*(int *)(iVar3 + 0x80) == 1) {
		      uVar1 = 0;
		      iVar3 = *param2;
		      if (*(ushort *)(iVar3 + 0xb6) != 0) {
		        do {
		          if (Gameplay_Inventory_View_IArtifactView_TypeInfo ==
		              *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		            puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0xd0);
		            goto code_r0x811e0e3e;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		      }
		      puVar2 = (uint *)func_ii_1080(param2,Gameplay_Inventory_View_IArtifactView_TypeInfo,2);
		code_r0x811e0e3e:
		      iVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		      iVar3 = *(int *)(iVar3 + 0x70);
		      if (DAT_ram_00a6456f == '\0') {
		        Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		        DAT_ram_00a6456f = '\x01';
		      }
		      param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		      iVar4 = *param1_00;
		      if (*(ushort *)(iVar4 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		            puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x140);
		            goto code_r0x811e0ee9;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		      }
		      puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x811e0ee9:
		      uVar5 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		      iVar4 = func_ii_7112(uVar5,0);
		      if (iVar4 == iVar3) {
		        return 1;
		      }
		    }
		    uVar5 = 0;
		  }
		  return uVar5;
		}
		*/

}
