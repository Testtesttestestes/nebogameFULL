using System;
using CloudsFly.Movement;
using Gameplay.World.Events;
using Gameplay.World.Model;
using Gameplay.World.View;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.World.Controller
{
	// Token: 0x02000377 RID: 887
	[Token(Token = "0x2000377")]
	public abstract class AbstractWorldViewMediator : AbstractViewMediator<WorldModel, WorldControllerEvents, WorldController, WorldView>
	{
		// Token: 0x06001497 RID: 5271 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001497")]
		[Address(RVA = "0x6661", Offset = "0x6661", VA = "0x6661")]
		public AbstractWorldViewMediator(WorldModel model, WorldControllerEvents events, WorldController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_World_Controller_AbstractWorldViewMediator___ctor
		               (int *param1,int param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  int iVar6;
		  int iVar7;
		  
		  if (DAT_ram_00a58ca4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_WorldModel__WorldControllerEvents__WorldController__WorldView__set_View__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_World_Controller_AbstractWorldViewMediator_ViewOnMovCompleteEvent__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_World_Controller_AbstractWorldViewMediator_ViewOnMovStartEvent__);
		    Mono_Security_ASN1__get_Item(&System_Action_WorldMovementTypes__TypeInfo);
		    DAT_ram_00a58ca4 = '\x01';
		  }
		  uVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar6 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar5,0);
		  if (iVar6 != 0) {
		    iVar6 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar5 = unnamed_function_1417(System_Action_WorldMovementTypes__TypeInfo);
		    System_Action_int___Invoke
		              (uVar5,param1,
		               Method_Gameplay_World_Controller_AbstractWorldViewMediator_ViewOnMovStartEvent__,0);
		    if (DAT_ram_00a58c5a == '\0') {
		      Mono_Security_ASN1__get_Item(&System_Action_WorldMovementTypes__TypeInfo);
		      DAT_ram_00a58c5a = '\x01';
		    }
		    iVar3 = *(int *)(iVar6 + 0x28);
		    do {
		      iVar4 = 0;
		      iVar7 = func_ii_7048(iVar3,uVar5,0);
		      uVar2 = System_Action_WorldMovementTypes__TypeInfo;
		      if ((iVar7 != 0) &&
		         (iVar4 = func_ii_1082(iVar7,System_Action_WorldMovementTypes__TypeInfo), iVar4 == 0)) {
		        System_Activator__CreateInstance(iVar7,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      iVar4 = func_ii_4329(iVar6 + 0x28,iVar4,iVar3);
		      bVar1 = iVar4 != iVar3;
		      iVar3 = iVar4;
		    } while (bVar1);
		    iVar6 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar5 = unnamed_function_1417(System_Action_WorldMovementTypes__TypeInfo);
		    System_Action_int___Invoke
		              (uVar5,param1,
		               Method_Gameplay_World_Controller_AbstractWorldViewMediator_ViewOnMovCompleteEvent__,0
		              );
		    if (DAT_ram_00a58c5c == '\0') {
		      Mono_Security_ASN1__get_Item(&System_Action_WorldMovementTypes__TypeInfo);
		      DAT_ram_00a58c5c = '\x01';
		    }
		    iVar3 = *(int *)(iVar6 + 0x2c);
		    do {
		      iVar4 = 0;
		      iVar7 = func_ii_7048(iVar3,uVar5,0);
		      uVar2 = System_Action_WorldMovementTypes__TypeInfo;
		      if ((iVar7 != 0) &&
		         (iVar4 = func_ii_1082(iVar7,System_Action_WorldMovementTypes__TypeInfo), iVar4 == 0)) {
		        System_Activator__CreateInstance(iVar7,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      iVar4 = func_ii_4329(iVar6 + 0x2c,iVar4,iVar3);
		      bVar1 = iVar4 != iVar3;
		      iVar3 = iVar4;
		    } while (bVar1);
		  }
		  param1[5] = param2;
		  uVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar6 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar5,0);
		  if (iVar6 != 0) {
		    iVar6 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar5 = unnamed_function_1417(System_Action_WorldMovementTypes__TypeInfo);
		    System_Action_int___Invoke
		              (uVar5,param1,
		               Method_Gameplay_World_Controller_AbstractWorldViewMediator_ViewOnMovStartEvent__,0);
		    if (DAT_ram_00a58c59 == '\0') {
		      Mono_Security_ASN1__get_Item(&System_Action_WorldMovementTypes__TypeInfo);
		      DAT_ram_00a58c59 = '\x01';
		    }
		    iVar3 = *(int *)(iVar6 + 0x28);
		    do {
		      iVar4 = 0;
		      iVar7 = UnityEngine_UI_Image__set_sprite(iVar3,uVar5,0);
		      uVar2 = System_Action_WorldMovementTypes__TypeInfo;
		      if ((iVar7 != 0) &&
		         (iVar4 = func_ii_1082(iVar7,System_Action_WorldMovementTypes__TypeInfo), iVar4 == 0)) {
		        System_Activator__CreateInstance(iVar7,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      iVar4 = func_ii_4329(iVar6 + 0x28,iVar4,iVar3);
		      bVar1 = iVar4 != iVar3;
		      iVar3 = iVar4;
		    } while (bVar1);
		    iVar6 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar5 = unnamed_function_1417(System_Action_WorldMovementTypes__TypeInfo);
		    System_Action_int___Invoke
		              (uVar5,param1,
		               Method_Gameplay_World_Controller_AbstractWorldViewMediator_ViewOnMovCompleteEvent__,0
		              );
		    if (DAT_ram_00a58c5b == '\0') {
		      Mono_Security_ASN1__get_Item(&System_Action_WorldMovementTypes__TypeInfo);
		      DAT_ram_00a58c5b = '\x01';
		    }
		    iVar3 = *(int *)(iVar6 + 0x2c);
		    do {
		      iVar4 = 0;
		      iVar7 = UnityEngine_UI_Image__set_sprite(iVar3,uVar5,0);
		      uVar2 = System_Action_WorldMovementTypes__TypeInfo;
		      if ((iVar7 != 0) &&
		         (iVar4 = func_ii_1082(iVar7,System_Action_WorldMovementTypes__TypeInfo), iVar4 == 0)) {
		        System_Activator__CreateInstance(iVar7,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      iVar4 = func_ii_4329(iVar6 + 0x2c,iVar4,iVar3);
		      bVar1 = iVar4 != iVar3;
		      iVar3 = iVar4;
		    } while (bVar1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x17000362 RID: 866
		// (set) Token: 0x06001498 RID: 5272 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000362")]
		public override WorldView View
		{
			[Token(Token = "0x6001498")]
			[Address(RVA = "0x6662", Offset = "0x6662", VA = "0x6662", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06001499 RID: 5273 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001499")]
		[Address(RVA = "0x6663", Offset = "0x6663", VA = "0x6663")]
		private void ViewOnMovCompleteEvent(WorldMovementTypes type)
		{
		/* --- GHIDRA: ViewOnMovCompleteEvent ---
		void Gameplay_World_Controller_AbstractWorldViewMediator__ViewOnMovCompleteEvent
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *piVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a58ca6 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_WorldModel__WorldControllerEvents__WorldController__WorldView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a58ca6 = '\x01';
		  }
		  piVar3 = *(int **)(param1[2] + 0xc);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x220);
		        goto code_r0x80f95a55;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,0x2c);
		code_r0x80f95a55:
		  uVar1 = 0;
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  Gameplay_Inventory_View_EquipmentSlotView__set_ArtifactData(*(undefined4 *)(iVar4 + 0x18),4,0);
		  piVar3 = *(int **)(param1[2] + 0xc);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x110);
		        goto code_r0x80f95ae6;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,10);
		code_r0x80f95ae6:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  *(undefined1 *)(*(int *)(iVar4 + 0x14) + 0x40) = 1;
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0x170) * 4))(param1,*(undefined4 *)(*param1 + 0x174));
		  uVar1 = 0;
		  piVar3 = *(int **)(param1[2] + 0xc);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x110);
		        goto code_r0x80f95b8a;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,10);
		code_r0x80f95b8a:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  iVar4 = *(int *)(*(int *)(iVar4 + 8) + 8);
		  if (iVar4 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar4 + 0xc) * 4))
		              (*(undefined4 *)(iVar4 + 0x20),param2,*(undefined4 *)(iVar4 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600149A RID: 5274 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600149A")]
		[Address(RVA = "0x6664", Offset = "0x6664", VA = "0x6664")]
		private void ViewOnMovStartEvent(WorldMovementTypes type)
		{
		}

		// Token: 0x0600149B RID: 5275
		[Token(Token = "0x600149B")]
		public abstract void Clear();

		// Token: 0x0600149C RID: 5276
		[Token(Token = "0x600149C")]
		protected abstract void StartMovement();

		// Token: 0x0600149D RID: 5277
		[Token(Token = "0x600149D")]
		protected abstract void CompleteMovement();
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_View ---
		void Gameplay_World_Controller_AbstractWorldViewMediator__set_View
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *piVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a58ca5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_WorldModel__WorldControllerEvents__WorldController__WorldView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a58ca5 = '\x01';
		  }
		  piVar3 = *(int **)(param1[2] + 0xc);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x220);
		        goto code_r0x80f9584f;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,0x2c);
		code_r0x80f9584f:
		  uVar1 = 0;
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  Gameplay_Inventory_View_EquipmentSlotView__set_ArtifactData(*(undefined4 *)(iVar4 + 0x18),5,0);
		  piVar3 = *(int **)(param1[2] + 0xc);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x110);
		        goto code_r0x80f958e0;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,10);
		code_r0x80f958e0:
		  uVar1 = 0;
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  *(undefined1 *)(*(int *)(iVar4 + 0x14) + 0x40) = 0;
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0x178) * 4))(param1,*(undefined4 *)(*param1 + 0x17c));
		  piVar3 = *(int **)(param1[2] + 0xc);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x110);
		        goto code_r0x80f95984;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,10);
		code_r0x80f95984:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  iVar4 = *(int *)(*(int *)(iVar4 + 8) + 0xc);
		  if (iVar4 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar4 + 0xc) * 4))
		              (*(undefined4 *)(iVar4 + 0x20),param2,*(undefined4 *)(iVar4 + 0x14));
		  }
		  return;
		}
		*/

}
