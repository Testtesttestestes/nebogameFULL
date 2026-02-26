using System;
using Gameplay.Inventory.View;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Gameplay.Inventory.ContextMenu
{
	// Token: 0x020006EB RID: 1771
	[Token(Token = "0x20006EB")]
	public class ToFavoritesItemContextMenuElement : AbstractArtifactContextMenuElement
	{
		// Token: 0x1700080F RID: 2063
		// (get) Token: 0x06002A81 RID: 10881 RVA: 0x00008520 File Offset: 0x00006720
		[Token(Token = "0x1700080F")]
		public override ArtikulMenuActionDic.Types.Actions ActionId
		{
			[Token(Token = "0x6002A81")]
			[Address(RVA = "0x7B24", Offset = "0x7B24", VA = "0x7B24", Slot = "4")]
			get
			{
				return ArtikulMenuActionDic.Types.Actions.UnknownAction;
			}
		}

		// Token: 0x06002A82 RID: 10882 RVA: 0x00008538 File Offset: 0x00006738
		[Token(Token = "0x6002A82")]
		[Address(RVA = "0x7B25", Offset = "0x7B25", VA = "0x7B25", Slot = "5")]
		public override bool Validate(IArtifactView artifactView)
		{
		/* --- GHIDRA: Validate ---
		void Gameplay_Inventory_ContextMenu_ToFavoritesItemContextMenuElement__Validate
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
		  
		  if (DAT_ram_00a5a1d4 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Inventory_View_IArtifactView_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5a1d4 = '\x01';
		  }
		  iVar6 = *param2;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Gameplay_Inventory_View_IArtifactView_TypeInfo ==
		          *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0xd0);
		        goto code_r0x811e305a;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,Gameplay_Inventory_View_IArtifactView_TypeInfo,2);
		code_r0x811e305a:
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
		        goto code_r0x811e3102;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0xc);
		code_r0x811e3102:
		  iVar6 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,CONCAT44(uVar3,puVar2[1]));
		  piVar5 = *(int **)(iVar6 + 0x14);
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*piVar5 + 0x100) * 4))
		                    (piVar5,*(undefined4 *)(*piVar5 + 0x104));
		  System_Collections_Generic_CollectionExtensions__GetValueOrDefault_ulong__object_
		            (uVar3,param2_00,1,piVar5);
		  iVar6 = piVar5[9];
		  uVar4 = func_ii_7957(param2_00,0);
		  ServicesNamespace_MainService__SetUserId(iVar6,uVar4,1,0);
		  Utils_Accumulators_CallAccumulator___ctor(piVar5[7],0);
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x06002A83 RID: 10883 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A83")]
		[Address(RVA = "0x7B26", Offset = "0x7B26", VA = "0x7B26", Slot = "7")]
		public override void Handle(IArtifactView artifactView)
		{
		}

		// Token: 0x06002A84 RID: 10884 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A84")]
		[Address(RVA = "0x7B27", Offset = "0x7B27", VA = "0x7B27")]
		public ToFavoritesItemContextMenuElement()
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_ActionId ---
		uint Gameplay_Inventory_ContextMenu_ToFavoritesItemContextMenuElement__get_ActionId
		               (undefined4 param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 in_register_20000014;
		  uint *puVar2;
		  undefined4 param1_00;
		  undefined8 uVar3;
		  int iVar4;
		  int *piVar5;
		  int iVar6;
		  undefined4 uVar7;
		  int iVar8;
		  
		  if (DAT_ram_00a5a1d3 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_ulong__ArtifactData__ContainsKey__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Inventory_View_IArtifactView_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5a1d3 = '\x01';
		  }
		  iVar8 = *param2;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Gameplay_Inventory_View_IArtifactView_TypeInfo ==
		          *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + iVar8 + 0xd0);
		        goto code_r0x811e2e19;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,Gameplay_Inventory_View_IArtifactView_TypeInfo,2);
		code_r0x811e2e19:
		  uVar3 = CONCAT44(in_register_20000014,puVar2[1]);
		  iVar8 = (**(code **)((ulonglong)*puVar2 * 4))(param2,uVar3);
		  uVar7 = (undefined4)((ulonglong)uVar3 >> 0x20);
		  iVar4 = *(int *)(iVar8 + 0x70);
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
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x140);
		        goto code_r0x811e2ec6;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x811e2ec6:
		  uVar1 = 0;
		  uVar3 = CONCAT44(uVar7,puVar2[1]);
		  param1_00 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,uVar3);
		  uVar7 = (undefined4)((ulonglong)uVar3 >> 0x20);
		  iVar6 = func_ii_7112(param1_00,0);
		  if ((iVar6 == iVar4) && (*(int *)(iVar8 + 0x80) == 1)) {
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar4 = *piVar5;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x120);
		          goto code_r0x811e2f8c;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0xc);
		code_r0x811e2f8c:
		    iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,CONCAT44(uVar7,puVar2[1]));
		    uVar7 = *(undefined4 *)(*(int *)(iVar4 + 0x10) + 0x1c);
		    uVar3 = func_ii_7957(iVar8,0);
		    uVar1 = Google_Protobuf_Collections_RepeatedField_ulong___GetEnumerator
		                      (uVar7,uVar3,
		                       Method_System_Collections_Generic_Dictionary_ulong__ArtifactData__ContainsKey__
		                      );
		    uVar1 = uVar1 ^ 1;
		  }
		  return uVar1;
		}
		*/

}
