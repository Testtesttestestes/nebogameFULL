using System;
using Gameplay.Inventory.View;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Gameplay.Inventory.ContextMenu
{
	// Token: 0x020006E4 RID: 1764
	[Token(Token = "0x20006E4")]
	public class SplitArtifactContextMenuElement : AbstractArtifactContextMenuElement
	{
		// Token: 0x17000808 RID: 2056
		// (get) Token: 0x06002A64 RID: 10852 RVA: 0x000083D0 File Offset: 0x000065D0
		[Token(Token = "0x17000808")]
		public override ArtikulMenuActionDic.Types.Actions ActionId
		{
			[Token(Token = "0x6002A64")]
			[Address(RVA = "0x7B07", Offset = "0x7B07", VA = "0x7B07", Slot = "4")]
			get
			{
				return ArtikulMenuActionDic.Types.Actions.UnknownAction;
			}
		}

		// Token: 0x06002A65 RID: 10853 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A65")]
		[Address(RVA = "0x7B08", Offset = "0x7B08", VA = "0x7B08", Slot = "7")]
		public override void Handle(IArtifactView artifactView)
		{
		/* --- GHIDRA: Handle ---
		uint Gameplay_Inventory_ContextMenu_SplitArtifactContextMenuElement__Handle
		               (undefined4 param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  int *piVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a5a1c5 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Inventory_View_IArtifactView_TypeInfo);
		    DAT_ram_00a5a1c5 = '\x01';
		  }
		  iVar4 = *param2;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Gameplay_Inventory_View_IArtifactView_TypeInfo ==
		          *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xd0);
		        goto code_r0x811e1372;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,Gameplay_Inventory_View_IArtifactView_TypeInfo,2);
		code_r0x811e1372:
		  param1_00 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  iVar4 = Gameplay_Inventory_Model_InventoryBaseModel__GetArtifactById(param1_00,0);
		  if (iVar4 == 0) {
		    uVar1 = 0;
		  }
		  else {
		    uVar1 = 0;
		    iVar4 = *param2;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      do {
		        if (Gameplay_Inventory_View_IArtifactView_TypeInfo ==
		            *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xd0);
		          goto code_r0x811e13fe;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param2,Gameplay_Inventory_View_IArtifactView_TypeInfo,2);
		code_r0x811e13fe:
		    iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		    if (*(int *)(iVar4 + 0x80) == 1) {
		      uVar1 = 0;
		      iVar4 = *param2;
		      if (*(ushort *)(iVar4 + 0xb6) != 0) {
		        do {
		          if (Gameplay_Inventory_View_IArtifactView_TypeInfo ==
		              *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		            puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xd0);
		            goto code_r0x811e148a;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		      }
		      puVar2 = (uint *)func_ii_1080(param2,Gameplay_Inventory_View_IArtifactView_TypeInfo,2);
		code_r0x811e148a:
		      piVar3 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		      iVar4 = (**(code **)((ulonglong)*(uint *)(*piVar3 + 0xf8) * 4))
		                        (piVar3,*(undefined4 *)(*piVar3 + 0xfc));
		      uVar1 = (uint)(1 < iVar4);
		    }
		    else {
		      uVar1 = 0;
		    }
		  }
		  return uVar1;
		}
		*/

		}

		// Token: 0x06002A66 RID: 10854 RVA: 0x000083E8 File Offset: 0x000065E8
		[Token(Token = "0x6002A66")]
		[Address(RVA = "0x7B09", Offset = "0x7B09", VA = "0x7B09", Slot = "5")]
		public override bool Validate(IArtifactView artifactView)
		{
		/* --- GHIDRA: Validate ---
		void Gameplay_Inventory_ContextMenu_SplitArtifactContextMenuElement__Validate
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  uint uVar1;
		  uint *param4_00;
		  int *param1_00;
		  int iVar2;
		  
		  if (DAT_ram_00a5a1c6 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5a1c6 = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar2 = *param1_00;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        param4_00 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x120);
		        goto code_r0x811e156e;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  param4_00 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0xc);
		code_r0x811e156e:
		  iVar2 = (**(code **)((ulonglong)*param4_00 * 4))(param1_00,param4_00[1]);
		  Gameplay_Inventory_Controller_InventoryController__MergeArtifactResultHandler
		            (*(undefined4 *)(iVar2 + 0x14),param2,param3,param4_00);
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x06002A67 RID: 10855 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A67")]
		[Address(RVA = "0x7B0A", Offset = "0x7B0A", VA = "0x7B0A")]
		private void ConfirmArtifactSplitEventHandler(uint slotId, uint quantity)
		{
		}

		// Token: 0x06002A68 RID: 10856 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A68")]
		[Address(RVA = "0x7B0B", Offset = "0x7B0B", VA = "0x7B0B")]
		public SplitArtifactContextMenuElement()
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_ActionId ---
		void Gameplay_Inventory_ContextMenu_SplitArtifactContextMenuElement__get_ActionId
		               (undefined4 param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  undefined4 param1_01;
		  int iVar3;
		  
		  if (DAT_ram_00a5a1c4 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_uint__uint__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Inventory_View_IArtifactView_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Inventory_ContextMenu_SplitArtifactContextMenuElement_ConfirmArtifactSplitEventHandler__
		              );
		    DAT_ram_00a5a1c4 = '\x01';
		  }
		  iVar3 = *param2;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Gameplay_Inventory_View_IArtifactView_TypeInfo ==
		          *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0xd0);
		        goto code_r0x811e12aa;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,Gameplay_Inventory_View_IArtifactView_TypeInfo,2);
		code_r0x811e12aa:
		  param1_00 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  param1_01 = unnamed_function_1417(System_Action_uint__uint__TypeInfo);
		  System_Action_PhysicsScene__NativeArray_ModifiableContactPair____Invoke
		            (param1_01,param1,
		             Method_Gameplay_Inventory_ContextMenu_SplitArtifactContextMenuElement_ConfirmArtifactSplitEventHandler__
		             ,0);
		  Gameplay_Inventory_View_ConfirmSplitArtifactWindow__Start(param1_00,param1_01,0);
		  return;
		}
		*/

}
