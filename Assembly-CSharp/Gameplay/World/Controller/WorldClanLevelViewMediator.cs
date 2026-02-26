using System;
using Gameplay.World.Events;
using Gameplay.World.Model;
using Gameplay.World.View;
using Il2CppDummyDll;

namespace Gameplay.World.Controller
{
	// Token: 0x0200037C RID: 892
	[Token(Token = "0x200037C")]
	public class WorldClanLevelViewMediator : AbstractWorldViewMediator
	{
		// Token: 0x060014A8 RID: 5288 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014A8")]
		[Address(RVA = "0x666A", Offset = "0x666A", VA = "0x666A")]
		public WorldClanLevelViewMediator(WorldModel model, WorldControllerEvents events, WorldController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_World_Controller_WorldClanLevelViewMediator___ctor
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a58176 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_WorldModel__WorldControllerEvents__WorldController__WorldView__set_Events__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_ulong__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_World_Controller_WorldClanLevelViewMediator_CurrentIsleChangedEvent__
		              );
		    DAT_ram_00a58176 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar1 + 0x1c);
		    uVar2 = unnamed_function_1417(System_Action_ulong__TypeInfo);
		    func_ii_6877(uVar2,param1,
		                 Method_Gameplay_World_Controller_WorldClanLevelViewMediator_CurrentIsleChangedEvent__
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
		                 Method_Gameplay_World_Controller_WorldClanLevelViewMediator_CurrentIsleChangedEvent__
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

		// Token: 0x17000366 RID: 870
		// (set) Token: 0x060014A9 RID: 5289 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000366")]
		public override WorldControllerEvents Events
		{
			[Token(Token = "0x60014A9")]
			[Address(RVA = "0x666B", Offset = "0x666B", VA = "0x666B", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x17000367 RID: 871
		// (set) Token: 0x060014AA RID: 5290 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000367")]
		public override WorldView View
		{
			[Token(Token = "0x60014AA")]
			[Address(RVA = "0x666C", Offset = "0x666C", VA = "0x666C", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x060014AB RID: 5291 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014AB")]
		[Address(RVA = "0x666D", Offset = "0x666D", VA = "0x666D", Slot = "21")]
		public override void Clear()
		{
		}

		// Token: 0x060014AC RID: 5292 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014AC")]
		[Address(RVA = "0x666E", Offset = "0x666E", VA = "0x666E", Slot = "22")]
		protected override void StartMovement()
		{
		}

		// Token: 0x060014AD RID: 5293 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014AD")]
		[Address(RVA = "0x666F", Offset = "0x666F", VA = "0x666F", Slot = "23")]
		protected override void CompleteMovement()
		{
		/* --- GHIDRA: CompleteMovement ---
		void Gameplay_World_Controller_WorldClanLevelViewMediator__CompleteMovement
		               (int *param1,undefined8 param2,undefined4 param3)
		
		{
		  uint param6;
		  int iVar1;
		  undefined4 uVar2;
		  int param1_00;
		  int param2_00;
		  int iVar3;
		  uint uVar4;
		  undefined8 local_8;
		  
		  param6 = 0;
		  if (DAT_ram_00a58177 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_ClanIsleEvents__ClanIsleModel__ClanIsleController__ClanBuildingTypes__get_Id__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_ClanIsleEvents__ClanIsleModel__ClanIsleController__ClanBuildingTypes__set_WasViewed__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_WorldModel__WorldControllerEvents__WorldController__WorldView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_World_Model_IsleHeap_ClanIsle__GetNextIsle__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IIsle__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IIsle___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_IIsle__TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_17944);
		    DAT_ram_00a58177 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  if ((iVar1 != 0) && (*(int *)(param1[2] + 0x1c) == 2)) {
		    local_8 = param2;
		    uVar2 = func_ii_1081(DAT_ram_00a66968,&local_8);
		    uVar2 = func_ii_4419(StringLiteral_17944,uVar2,0);
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(uVar2,0);
		    iVar1 = param1[2];
		    param2_00 = *(int *)(iVar1 + 0x28);
		    iVar3 = *(int *)(*(int *)(iVar1 + 8) + 0x68);
		    if (iVar3 != 0) {
		      param6 = (uint)(*(longlong *)(*(int *)(iVar3 + 0x1c) + 0x10) ==
		                     *(longlong *)(param2_00 + 0x18));
		    }
		    iVar1 = func_ii_8571(*(undefined4 *)(iVar1 + 0x34),param2_00,1,
		                         Method_Gameplay_World_Model_IsleHeap_ClanIsle__GetNextIsle__);
		    *(undefined1 *)(param2_00 + 0x20) = 1;
		    if (iVar1 != 0) {
		      *(undefined1 *)(iVar1 + 0x20) = 1;
		    }
		    param1_00 = unnamed_function_1417(System_Collections_Generic_List_IIsle__TypeInfo);
		    GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		              (param1_00,Method_System_Collections_Generic_List_IIsle___ctor__);
		    iVar3 = Method_System_Collections_Generic_List_IIsle__Add__;
		    uVar2 = *(undefined4 *)(param1[2] + 0x28);
		    *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		    uVar4 = *(uint *)(param1_00 + 0xc);
		    if (uVar4 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		      *(uint *)(param1_00 + 0xc) = uVar4 + 1;
		      *(undefined4 *)(*(int *)(param1_00 + 8) + uVar4 * 4 + 0x10) = uVar2;
		    }
		    else {
		      System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                (param1_00,uVar2,*(undefined4 *)(*(int *)(*(int *)(iVar3 + 0x10) + 0x60) + 0x38));
		    }
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    Gameplay_World_View_WorldView__GetIsleEngineByLevel
		              (uVar2,2,param2_00,iVar1,0,param6,param1_00,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060014AE RID: 5294 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014AE")]
		[Address(RVA = "0x6670", Offset = "0x6670", VA = "0x6670")]
		private void CurrentIsleChangedEvent(ulong prevOwnerId)
		{
		/* --- GHIDRA: CurrentIsleChangedEvent ---
		void Gameplay_World_Controller_WorldClanLevelViewMediator__CurrentIsleChangedEvent
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a58178 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_WorldModel__WorldControllerEvents__WorldController__WorldView__Dispose__
		              );
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_17945);
		    DAT_ram_00a58178 = '\x01';
		  }
		  if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		    func_ii_306000(OKG_Logs_Debug_TypeInfo);
		  }
		  System_Collections_Generic_Dictionary_uint__object___get_Count(StringLiteral_17945,0);
		  MVC_AbstractViewMediator_object__object__object__object___Core_MVC_Interfaces_IViewMediator_set_View
		            (param1,
		             Method_MVC_AbstractViewMediator_WorldModel__WorldControllerEvents__WorldController__WorldView__Dispose__
		            );
		  return;
		}
		*/

		}

		// Token: 0x060014AF RID: 5295 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014AF")]
		[Address(RVA = "0x6671", Offset = "0x6671", VA = "0x6671", Slot = "14")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_World_Controller_WorldClanLevelViewMediator__Dispose(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a58179 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_MVC_AbstractController_WorldModel__WorldControllerEvents__Dispose__);
		    DAT_ram_00a58179 = '\x01';
		  }
		  Gameplay_World_Controller_WorldController__GoHome(param1,param1);
		  Gameplay_World_Controller_WorldController__ClearUserIsleHeap(param1,param1);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  iVar2 = **(int **)(iVar1 + 0x20);
		  (**(code **)((ulonglong)*(uint *)(iVar2 + 0x120) * 4))
		            (*(int **)(iVar1 + 0x20),*(undefined4 *)(iVar2 + 0x124));
		  param1[0xb] = 0;
		  param1[9] = 0;
		  param1[7] = 0;
		  param1[8] = 0;
		  MVC_AbstractController_object__object____ctor
		            (param1,Method_MVC_AbstractController_WorldModel__WorldControllerEvents__Dispose__);
		  return;
		}
		*/

		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Events ---
		void Gameplay_World_Controller_WorldClanLevelViewMediator__set_Events
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000014;
		  undefined8 uVar1;
		  undefined4 param1_00;
		  undefined4 uVar2;
		  int iVar3;
		  
		  uVar1 = CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x15c));
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))(param1,uVar1);
		  uVar2 = (undefined4)((ulonglong)uVar1 >> 0x20);
		  Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(param1_00,0);
		  Gameplay_World_Controller_AbstractWorldViewMediator___ctor(param1,param2,0);
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,CONCAT44(uVar2,*(undefined4 *)(*param1 + 0x15c)));
		  iVar3 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar2,0);
		  if (iVar3 != 0) {
		    Gameplay_World_Controller_WorldClanLevelViewMediator__CompleteMovement(param1,0,param1);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_View ---
		void Gameplay_World_Controller_WorldClanLevelViewMediator__set_View(int *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_World_View_WorldView__MoveToIsle(param1_00,2,0);
		  return;
		}
		*/

}
