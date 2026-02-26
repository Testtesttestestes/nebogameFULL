using System;
using Gameplay.Inventory.View;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Gameplay.Inventory.ContextMenu
{
	// Token: 0x020006D5 RID: 1749
	[Token(Token = "0x20006D5")]
	public class FromFavoritesArtifactContextMenuElement : AbstractArtifactContextMenuElement
	{
		// Token: 0x170007F9 RID: 2041
		// (get) Token: 0x06002A2C RID: 10796 RVA: 0x00008130 File Offset: 0x00006330
		[Token(Token = "0x170007F9")]
		public override ArtikulMenuActionDic.Types.Actions ActionId
		{
			[Token(Token = "0x6002A2C")]
			[Address(RVA = "0x7ACF", Offset = "0x7ACF", VA = "0x7ACF", Slot = "4")]
			get
			{
				return ArtikulMenuActionDic.Types.Actions.UnknownAction;
			}
		}

		// Token: 0x06002A2D RID: 10797 RVA: 0x00008148 File Offset: 0x00006348
		[Token(Token = "0x6002A2D")]
		[Address(RVA = "0x7AD0", Offset = "0x7AD0", VA = "0x7AD0", Slot = "5")]
		public override bool Validate(IArtifactView artifactView)
		{
		/* --- GHIDRA: Validate ---
		void Gameplay_Inventory_ContextMenu_FromFavoritesArtifactContextMenuElement__Validate
		               (undefined4 param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 in_register_20000014;
		  uint *puVar2;
		  undefined4 param2_00;
		  undefined4 uVar3;
		  undefined8 uVar4;
		  int *piVar5;
		  int iVar6;
		  
		  if (DAT_ram_00a5a1ac == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Inventory_View_IArtifactView_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5a1ac = '\x01';
		  }
		  iVar6 = *param2;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Gameplay_Inventory_View_IArtifactView_TypeInfo ==
		          *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0xd0);
		        goto code_r0x811de1b8;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,Gameplay_Inventory_View_IArtifactView_TypeInfo,2);
		code_r0x811de1b8:
		  uVar4 = CONCAT44(in_register_20000014,puVar2[1]);
		  param2_00 = (**(code **)((ulonglong)*puVar2 * 4))(param2,uVar4);
		  uVar3 = (undefined4)((ulonglong)uVar4 >> 0x20);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x120);
		        goto code_r0x811de260;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0xc);
		code_r0x811de260:
		  iVar6 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,CONCAT44(uVar3,puVar2[1]));
		  piVar5 = *(int **)(iVar6 + 0x14);
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*piVar5 + 0x100) * 4))
		                    (piVar5,*(undefined4 *)(*piVar5 + 0x104));
		  System_Collections_Generic_CollectionExtensions__GetValueOrDefault_ulong__object_
		            (uVar3,param2_00,0,piVar5);
		  iVar6 = piVar5[9];
		  uVar4 = func_ii_7957(param2_00,0);
		  ServicesNamespace_MainService__SetUserId(iVar6,uVar4,0,0);
		  Utils_Accumulators_CallAccumulator___ctor(piVar5[7],0);
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x06002A2E RID: 10798 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A2E")]
		[Address(RVA = "0x7AD1", Offset = "0x7AD1", VA = "0x7AD1", Slot = "7")]
		public override void Handle(IArtifactView artifactView)
		{
		}

		// Token: 0x06002A2F RID: 10799 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A2F")]
		[Address(RVA = "0x7AD2", Offset = "0x7AD2", VA = "0x7AD2")]
		public FromFavoritesArtifactContextMenuElement()
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_ActionId ---
		undefined4
		Gameplay_Inventory_ContextMenu_FromFavoritesArtifactContextMenuElement__get_ActionId
		          (undefined4 param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  undefined4 in_register_20000014;
		  uint *puVar3;
		  undefined4 param1_00;
		  undefined8 uVar4;
		  int iVar5;
		  int *piVar6;
		  int iVar7;
		  undefined4 uVar8;
		  int iVar9;
		  
		  if (DAT_ram_00a5a1ab == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_ulong__ArtifactData__ContainsKey__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Inventory_View_IArtifactView_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5a1ab = '\x01';
		  }
		  iVar9 = *param2;
		  if (*(ushort *)(iVar9 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Gameplay_Inventory_View_IArtifactView_TypeInfo ==
		          *(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8 + 4) * 8 + iVar9 + 0xd0);
		        goto code_r0x811ddf7a;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar9 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param2,Gameplay_Inventory_View_IArtifactView_TypeInfo,2);
		code_r0x811ddf7a:
		  uVar4 = CONCAT44(in_register_20000014,puVar3[1]);
		  iVar9 = (**(code **)((ulonglong)*puVar3 * 4))(param2,uVar4);
		  uVar8 = (undefined4)((ulonglong)uVar4 >> 0x20);
		  iVar5 = *(int *)(iVar9 + 0x70);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar6 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x140);
		        goto code_r0x811de027;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x811de027:
		  uVar2 = 0;
		  uVar4 = CONCAT44(uVar8,puVar3[1]);
		  param1_00 = (**(code **)((ulonglong)*puVar3 * 4))(piVar6,uVar4);
		  uVar8 = (undefined4)((ulonglong)uVar4 >> 0x20);
		  iVar7 = func_ii_7112(param1_00,0);
		  if ((iVar7 == iVar5) && (*(int *)(iVar9 + 0x80) == 1)) {
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    piVar6 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar5 = *piVar6;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x120);
		          goto code_r0x811de0ed;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0xc);
		code_r0x811de0ed:
		    iVar5 = (**(code **)((ulonglong)*puVar3 * 4))(piVar6,CONCAT44(uVar8,puVar3[1]));
		    uVar8 = *(undefined4 *)(*(int *)(iVar5 + 0x10) + 0x1c);
		    uVar4 = func_ii_7957(iVar9,0);
		    uVar2 = Google_Protobuf_Collections_RepeatedField_ulong___GetEnumerator
		                      (uVar8,uVar4,
		                       Method_System_Collections_Generic_Dictionary_ulong__ArtifactData__ContainsKey__
		                      );
		  }
		  return uVar2;
		}
		*/

}
