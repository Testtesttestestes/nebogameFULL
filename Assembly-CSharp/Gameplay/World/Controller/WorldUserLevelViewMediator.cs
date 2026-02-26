using System;
using Gameplay.Sound.Model;
using Gameplay.World.Events;
using Gameplay.World.Model;
using Gameplay.World.View;
using Il2CppDummyDll;

namespace Gameplay.World.Controller
{
	// Token: 0x0200037F RID: 895
	[Token(Token = "0x200037F")]
	public class WorldUserLevelViewMediator : AbstractWorldViewMediator
	{
		// Token: 0x060014DA RID: 5338 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014DA")]
		[Address(RVA = "0x669C", Offset = "0x669C", VA = "0x669C")]
		public WorldUserLevelViewMediator(WorldModel model, WorldControllerEvents events, WorldController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_World_Controller_WorldUserLevelViewMediator___ctor
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a58197 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_WorldModel__WorldControllerEvents__WorldController__WorldView__set_Events__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_ulong__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_World_Controller_WorldUserLevelViewMediator_CurrentIsleChangedEventHandler__
		              );
		    DAT_ram_00a58197 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar1 + 0x1c);
		    uVar2 = unnamed_function_1417(System_Action_ulong__TypeInfo);
		    func_ii_6877(uVar2,param1,
		                 Method_Gameplay_World_Controller_WorldUserLevelViewMediator_CurrentIsleChangedEventHandler__
		                 ,0);
		    iVar3 = func_ii_7048(uVar5,uVar2,0);
		    uVar2 = System_Action_ulong__TypeInfo;
		    if (iVar3 == 0) {
		      *(undefined4 *)(iVar1 + 0x1c) = 0;
		    }
		    else {
		      iVar4 = func_ii_1082(iVar3,System_Action_ulong__TypeInfo);
		      if (iVar4 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x1c) = iVar4;
		      uVar2 = System_Action_ulong__TypeInfo;
		      iVar1 = func_ii_1082(iVar3,System_Action_ulong__TypeInfo);
		      if (iVar1 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		  }
		  param1[3] = param2;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar1 + 0x1c);
		    uVar2 = unnamed_function_1417(System_Action_ulong__TypeInfo);
		    func_ii_6877(uVar2,param1,
		                 Method_Gameplay_World_Controller_WorldUserLevelViewMediator_CurrentIsleChangedEventHandler__
		                 ,0);
		    iVar3 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		    uVar2 = System_Action_ulong__TypeInfo;
		    if (iVar3 == 0) {
		      *(undefined4 *)(iVar1 + 0x1c) = 0;
		      return;
		    }
		    iVar4 = func_ii_1082(iVar3,System_Action_ulong__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar3,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar1 + 0x1c) = iVar4;
		    uVar2 = System_Action_ulong__TypeInfo;
		    iVar1 = func_ii_1082(iVar3,System_Action_ulong__TypeInfo);
		    if (iVar1 == 0) {
		      System_Activator__CreateInstance(iVar3,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x17000368 RID: 872
		// (set) Token: 0x060014DB RID: 5339 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000368")]
		public override WorldControllerEvents Events
		{
			[Token(Token = "0x60014DB")]
			[Address(RVA = "0x669D", Offset = "0x669D", VA = "0x669D", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x060014DC RID: 5340 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014DC")]
		[Address(RVA = "0x669E", Offset = "0x669E", VA = "0x669E")]
		private void CurrentIsleChangedEventHandler(ulong prevOwnerId)
		{
		/* --- GHIDRA: CurrentIsleChangedEventHandler ---
		void Gameplay_World_Controller_WorldUserLevelViewMediator__CurrentIsleChangedEventHandler
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000014;
		  undefined8 uVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  int iVar4;
		  
		  uVar1 = CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))(param1,uVar1);
		  uVar2 = (undefined4)((ulonglong)uVar1 >> 0x20);
		  Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar3,0);
		  Gameplay_World_Controller_AbstractWorldViewMediator___ctor(param1,param2,0);
		  uVar1 = CONCAT44(uVar2,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))(param1,uVar1);
		  uVar2 = (undefined4)((ulonglong)uVar1 >> 0x20);
		  iVar4 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar3,0);
		  if (iVar4 != 0) {
		    (**(code **)((ulonglong)*(uint *)(*param1 + 0x180) * 4))
		              (param1,CONCAT44(uVar2,1),*(undefined4 *)(*param1 + 0x184));
		    Gameplay_World_Controller_WorldUserLevelViewMediator__set_Events(param1,0,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x17000369 RID: 873
		// (set) Token: 0x060014DD RID: 5341 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000369")]
		public override WorldView View
		{
			[Token(Token = "0x60014DD")]
			[Address(RVA = "0x669F", Offset = "0x669F", VA = "0x669F", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x060014DE RID: 5342 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014DE")]
		[Address(RVA = "0x66A0", Offset = "0x66A0", VA = "0x66A0", Slot = "21")]
		public override void Clear()
		{
		}

		// Token: 0x060014DF RID: 5343 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014DF")]
		[Address(RVA = "0x66A1", Offset = "0x66A1", VA = "0x66A1", Slot = "22")]
		protected override void StartMovement()
		{
		}

		// Token: 0x060014E0 RID: 5344 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014E0")]
		[Address(RVA = "0x66A2", Offset = "0x66A2", VA = "0x66A2", Slot = "23")]
		protected override void CompleteMovement()
		{
		/* --- GHIDRA: CompleteMovement ---
		void Gameplay_World_Controller_WorldUserLevelViewMediator__CompleteMovement
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *param1_00;
		  int iVar3;
		  
		  if (DAT_ram_00a58199 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_WorldModel__WorldControllerEvents__WorldController__WorldView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a58199 = '\x01';
		  }
		  param1_00 = *(int **)(*(int *)(param1 + 8) + 0xc);
		  iVar3 = *param1_00;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x220);
		        goto code_r0x80eb10d7;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x2c);
		code_r0x80eb10d7:
		  iVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  Gameplay_Sound_Control_AudioController__PlaySound(*(undefined4 *)(iVar3 + 0x18),param2,0);
		  return;
		}
		*/

		}

		// Token: 0x060014E1 RID: 5345 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014E1")]
		[Address(RVA = "0x66A3", Offset = "0x66A3", VA = "0x66A3", Slot = "24")]
		protected virtual void StartMusic(PlayLists playLists)
		{
		/* --- GHIDRA: StartMusic ---
		void Gameplay_World_Controller_WorldUserLevelViewMediator__StartMusic
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5819a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_WorldModel__WorldControllerEvents__WorldController__WorldView__Dispose__
		              );
		    DAT_ram_00a5819a = '\x01';
		  }
		  MVC_AbstractViewMediator_object__object__object__object___Core_MVC_Interfaces_IViewMediator_set_View
		            (param1,
		             Method_MVC_AbstractViewMediator_WorldModel__WorldControllerEvents__WorldController__WorldView__Dispose__
		            );
		  return;
		}
		*/

		}

		// Token: 0x060014E2 RID: 5346 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014E2")]
		[Address(RVA = "0x66A4", Offset = "0x66A4", VA = "0x66A4", Slot = "14")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_World_Controller_WorldUserLevelViewMediator__Dispose(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5819b == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_World_Controller_WorldUserLevelViewMediator___c_TypeInfo)
		    ;
		    DAT_ram_00a5819b = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Gameplay_World_Controller_WorldUserLevelViewMediator___c_TypeInfo);
		  **(undefined4 **)(Gameplay_World_Controller_WorldUserLevelViewMediator___c_TypeInfo + 0x5c) =
		       uVar1;
		  return;
		}
		*/

		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Events ---
		void Gameplay_World_Controller_WorldUserLevelViewMediator__set_Events
		               (int *param1,undefined8 param2,undefined4 param3)
		
		{
		  int param2_00;
		  int iVar1;
		  int param5;
		  undefined4 uVar2;
		  longlong lVar3;
		  undefined4 uVar4;
		  undefined4 *puVar5;
		  int param1_00;
		  int param2_01;
		  longlong lVar6;
		  
		  if (DAT_ram_00a58198 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_UserIsleEvents__UserIsleModel__UserIsleController__UserBuildingTypes__get_Id__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_UserIsleEvents__UserIsleModel__UserIsleController__UserBuildingTypes__set_WasViewed__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_WorldModel__WorldControllerEvents__WorldController__WorldView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Select_UserIsle__IIsle___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToList_IIsle___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Where_IIsle___);
		    Mono_Security_ASN1__get_Item(&System_Func_UserIsle__IIsle__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_IIsle__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_World_Model_IsleHeap_UserIsle__GetNextIsle__);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_World_Model_IsleHeap_UserIsle__get_List__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_World_Controller_WorldUserLevelViewMediator___c__CurrentIsleChangedEventHandler_b__3_0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_World_Controller_WorldUserLevelViewMediator___c__DisplayClass3_0__CurrentIsleChangedEventHandler_b__1__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_World_Controller_WorldUserLevelViewMediator___c__DisplayClass3_0_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_World_Controller_WorldUserLevelViewMediator___c_TypeInfo)
		    ;
		    DAT_ram_00a58198 = '\x01';
		  }
		  param2_00 = unnamed_function_1417
		                        (
		                        Gameplay_World_Controller_WorldUserLevelViewMediator___c__DisplayClass3_0_TypeInfo
		                        );
		  *(undefined8 *)(param2_00 + 8) = param2;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  if ((iVar1 != 0) && (iVar1 = param1[2], *(int *)(iVar1 + 0x1c) == 1)) {
		    param2_01 = *(int *)(iVar1 + 0x24);
		    iVar1 = func_ii_8571(*(undefined4 *)(iVar1 + 0x30),param2_01,1,
		                         Method_Gameplay_World_Model_IsleHeap_UserIsle__GetNextIsle__);
		    param5 = func_ii_8571(*(undefined4 *)(param1[2] + 0x30),*(undefined4 *)(param1[2] + 0x24),2,
		                          Method_Gameplay_World_Model_IsleHeap_UserIsle__GetNextIsle__);
		    *(undefined1 *)(param2_01 + 0x20) = 1;
		    if (iVar1 != 0) {
		      *(undefined1 *)(iVar1 + 0x20) = 1;
		    }
		    if (param5 != 0) {
		      *(undefined1 *)(param5 + 0x20) = 1;
		    }
		    uVar4 = *(undefined4 *)(*(int *)(param1[2] + 0x30) + 0x10);
		    if (*(int *)(Gameplay_World_Controller_WorldUserLevelViewMediator___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_World_Controller_WorldUserLevelViewMediator___c_TypeInfo);
		    }
		    puVar5 = *(undefined4 **)
		              (Gameplay_World_Controller_WorldUserLevelViewMediator___c_TypeInfo + 0x5c);
		    param1_00 = puVar5[1];
		    if (param1_00 == 0) {
		      if (*(int *)(Gameplay_World_Controller_WorldUserLevelViewMediator___c_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Gameplay_World_Controller_WorldUserLevelViewMediator___c_TypeInfo);
		        puVar5 = *(undefined4 **)
		                  (Gameplay_World_Controller_WorldUserLevelViewMediator___c_TypeInfo + 0x5c);
		      }
		      uVar2 = *puVar5;
		      param1_00 = unnamed_function_1417(System_Func_UserIsle__IIsle__TypeInfo);
		      System_Linq_Enumerable__Where_object_
		                (param1_00,uVar2,
		                 Method_Gameplay_World_Controller_WorldUserLevelViewMediator___c__CurrentIsleChangedEventHandler_b__3_0__
		                 ,0);
		      *(int *)(*(int *)(Gameplay_World_Controller_WorldUserLevelViewMediator___c_TypeInfo + 0x5c) +
		              4) = param1_00;
		    }
		    uVar4 = System_Linq_Enumerable__ReverseIterator___Il2CppFullySharedGenericType_
		                      (uVar4,param1_00,Method_System_Linq_Enumerable_Select_UserIsle__IIsle___);
		    if (*(longlong *)(param2_00 + 8) != *(longlong *)(param2_01 + 0x18)) {
		      uVar2 = unnamed_function_1417(System_Func_IIsle__bool__TypeInfo);
		      System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		                (uVar2,param2_00,
		                 Method_Gameplay_World_Controller_WorldUserLevelViewMediator___c__DisplayClass3_0__CurrentIsleChangedEventHandler_b__1__
		                 ,0);
		      uVar4 = System_Linq_Enumerable__Where_PlayerLoopSystem_
		                        (uVar4,uVar2,Method_System_Linq_Enumerable_Where_IIsle___);
		    }
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    lVar6 = *(longlong *)(param2_01 + 0x18);
		    lVar3 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                      (*(undefined4 *)(param1[2] + 8),0);
		    uVar4 = System_Linq_Enumerable__Select_object__object_
		                      (uVar4,Method_System_Linq_Enumerable_ToList_IIsle___);
		    Gameplay_World_View_WorldView__GetIsleEngineByLevel
		              (uVar2,1,param2_01,iVar1,param5,(uint)(lVar6 == lVar3),uVar4,0);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_View ---
		void Gameplay_World_Controller_WorldUserLevelViewMediator__set_View(int *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_World_View_WorldView__MoveToIsle(param1_00,1,0);
		  return;
		}
		*/

}
