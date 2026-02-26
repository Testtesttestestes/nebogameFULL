using System;
using Gameplay.Isles.User.Events;
using Gameplay.Isles.User.Model;
using Gameplay.Isles.User.View;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Isles.User.Controller
{
	// Token: 0x02000D30 RID: 3376
	[Token(Token = "0x2000D30")]
	public class IsleAccountMarkersViewMediator : AbstractViewMediator<UserIsleModel, UserIsleEvents, UserIsleController, IsleAccountMarkersLayerView>
	{
		// Token: 0x06005295 RID: 21141 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005295")]
		[Address(RVA = "0xA06B", Offset = "0xA06B", VA = "0xA06B")]
		public IsleAccountMarkersViewMediator(UserIsleModel model, UserIsleEvents events, UserIsleController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Isles_User_Controller_IsleAccountMarkersViewMediator___ctor
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a58d93 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_UserIsleModel__UserIsleEvents__UserIsleController__IsleAccountMarkersLayerView__set_Events__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_User_Controller_IsleAccountMarkersViewMediator_HandleAccountMarkersChangedEvent__
		              );
		    DAT_ram_00a58d93 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x38);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Isles_User_Controller_IsleAccountMarkersViewMediator_HandleAccountMarkersChangedEvent__
		               ,0);
		    piVar4 = (int *)func_ii_7048(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x38) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x38) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  param1[3] = param2;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x38);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Isles_User_Controller_IsleAccountMarkersViewMediator_HandleAccountMarkersChangedEvent__
		               ,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x38) = 0;
		      return;
		    }
		    if ((System_Action_TypeInfo != *piVar4) || (*(int **)(iVar2 + 0x38) = piVar4, *piVar4 != iVar1))
		    {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x170010D8 RID: 4312
		// (set) Token: 0x06005296 RID: 21142 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170010D8")]
		public override UserIsleEvents Events
		{
			[Token(Token = "0x6005296")]
			[Address(RVA = "0xA06C", Offset = "0xA06C", VA = "0xA06C", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x170010D9 RID: 4313
		// (set) Token: 0x06005297 RID: 21143 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170010D9")]
		public override IsleAccountMarkersLayerView View
		{
			[Token(Token = "0x6005297")]
			[Address(RVA = "0xA06D", Offset = "0xA06D", VA = "0xA06D", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06005298 RID: 21144 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005298")]
		[Address(RVA = "0xA06E", Offset = "0xA06E", VA = "0xA06E")]
		private void HandleAccountMarkersChangedEvent()
		{
		/* --- GHIDRA: HandleAccountMarkersChangedEvent ---
		void Gameplay_Isles_User_Controller_IsleAccountMarkersViewMediator__HandleAccountMarkersChangedEvent
		               (undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_Isles_User_Controller_IsleAccountMarkersViewMediator__set_View(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06005299 RID: 21145 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005299")]
		[Address(RVA = "0xA06F", Offset = "0xA06F", VA = "0xA06F")]
		private void SetupView()
		{
		/* --- GHIDRA: SetupView ---
		void Gameplay_Isles_User_Controller_IsleAccountMarkersViewMediator__SetupView
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5,undefined4 param6)
		
		{
		  if (DAT_ram_00a58d96 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractCozyViewMediator_WorldModel__WorldControllerEvents__WorldController__IsleAnimationButtonsView___ctor__
		              );
		    DAT_ram_00a58d96 = '\x01';
		  }
		  MVC_AbstractCozyViewMediator_object__object__object__object____ctor
		            (param1,param2,param3,param4,param5,
		             Method_MVC_AbstractCozyViewMediator_WorldModel__WorldControllerEvents__WorldController__IsleAnimationButtonsView___ctor__
		            );
		  return;
		}
		*/

		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Events ---
		void Gameplay_Isles_User_Controller_IsleAccountMarkersViewMediator__set_Events
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  
		  if (DAT_ram_00a58d94 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_UserIsleModel__UserIsleEvents__UserIsleController__IsleAccountMarkersLayerView__set_View__
		              );
		    DAT_ram_00a58d94 = '\x01';
		  }
		  param1[5] = param2;
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar1 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(param1_00,0);
		  if (iVar1 != 0) {
		    Gameplay_Isles_User_Controller_IsleAccountMarkersViewMediator__set_View(param1,param1);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_View ---
		void Gameplay_Isles_User_Controller_IsleAccountMarkersViewMediator__set_View
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  undefined4 *puVar4;
		  undefined4 uVar5;
		  int *piVar6;
		  int iVar7;
		  int *piVar8;
		  undefined8 local_38;
		  undefined4 local_30;
		  float4 local_2c;
		  float4 local_28;
		  undefined4 local_24;
		  int local_20;
		  undefined1 *puStack_1c;
		  undefined8 local_18;
		  undefined1 local_10 [8];
		  undefined8 local_8;
		  
		  if (DAT_ram_00a58d95 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_UserIsleModel__UserIsleEvents__UserIsleController__IsleAccountMarkersLayerView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_UserIsleAccountMarkerData__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_UserIsleAccountMarkerData__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_UserIsleAccountMarkerData__get_Current__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Accounts_Model_Data_IAccountDataDecorator_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_UserIsleAccountMarkerData__GetEnumerator__);
		    DAT_ram_00a58d95 = '\x01';
		  }
		  iVar7 = *param1;
		  uVar2 = (**(code **)((ulonglong)*(uint *)(iVar7 + 0x158) * 4))
		                    (param1,*(undefined4 *)(iVar7 + 0x15c));
		  Gameplay_Isles_User_View_IsleAccountMarkersLayerView__Hide(uVar2,iVar7);
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_20,*(undefined4 *)(param1[2] + 0x50),
		             Method_System_Collections_Generic_List_UserIsleAccountMarkerData__GetEnumerator__);
		  local_8 = local_18;
		  local_20 = 0;
		  puStack_1c = local_10;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar3 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,local_10,
		                       Method_System_Collections_Generic_List_Enumerator_UserIsleAccountMarkerData__MoveNext__
		                      );
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar7 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80fa736d;
		    }
		    if (iVar3 == 0) {
		      DAT_ram_009d3e38 = 0;
		      return;
		    }
		    iVar7 = local_8._4_4_;
		    piVar6 = *(int **)(local_8._4_4_ + 8);
		    iVar3 = *piVar6;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar8 = (int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8);
		        if (Gameplay_Accounts_Model_Data_IAccountDataDecorator_TypeInfo == *piVar8) {
		          puVar4 = (undefined4 *)(piVar8[1] * 8 + iVar3 + 200);
		          goto code_r0x80fa70ae;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar4 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar6,
		                        Gameplay_Accounts_Model_Data_IAccountDataDecorator_TypeInfo,1);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80fa7315:
		      DAT_ram_009d3e38 = 0;
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80fa736d;
		    }
		code_r0x80fa70ae:
		    DAT_ram_009d3e38 = 0;
		    uVar2 = import::env::invoke_iii(*puVar4,piVar6,puVar4[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80fa7315;
		    DAT_ram_009d3e38 = 0;
		    uVar2 = import::env::invoke_iii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x27f,uVar2,0)
		    ;
		    iVar3 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar3 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80fa736d;
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar5 = import::env::invoke_iii
		                      (*(undefined4 *)(*param1 + 0x158),param1,*(undefined4 *)(*param1 + 0x15c));
		    iVar3 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar3 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80fa736d;
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar5 = import::env::invoke_iiii
		                      (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x280,uVar5,uVar2,uVar2);
		    iVar3 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar3 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80fa736d;
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar5 = import::env::invoke_iii(s_struct_Uniforms___color__array<v_ram_000017c8 + 0x30e,uVar5,0)
		    ;
		    iVar3 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar3 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80fa736d;
		    }
		    local_24 = 0;
		    local_30 = 0;
		    local_28 = (float4)(float)*(int *)(*(int *)(iVar7 + 0xc) + 0x10);
		    local_2c = (float4)(float)*(int *)(*(int *)(iVar7 + 0xc) + 0xc);
		    DAT_ram_009d3e38 = 0;
		    local_38 = CONCAT44(local_28,local_2c);
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x281,uVar5,&local_38,0);
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar7 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80fa736d;
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar5 = import::env::invoke_iii
		                      (*(undefined4 *)(*param1 + 0x158),param1,*(undefined4 *)(*param1 + 0x15c));
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar7 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80fa736d;
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar2 = import::env::invoke_iiii
		                      (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x280,uVar5,uVar2,uVar2);
		    if (DAT_ram_009d3e38 == 1) break;
		    DAT_ram_009d3e38 = 0;
		    uVar2 = import::env::invoke_iii(s_struct_Uniforms___color__array<v_ram_00000aff + 0x25c,uVar2,0)
		    ;
		    if (DAT_ram_009d3e38 == 1) break;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii(s_struct_Uniforms___color__array<v_ram_000013c7 + 0x26d,uVar2,1,0);
		  } while (DAT_ram_009d3e38 != 1);
		  DAT_ram_009d3e38 = 0;
		  uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80fa736d:
		  iVar7 = global_1;
		  iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar7 == iVar3) {
		    piVar6 = (int *)import::env::__cxa_begin_catch(uVar2);
		    iVar3 = *piVar6;
		    DAT_ram_009d3e38 = 0;
		    local_20 = iVar3;
		    import::env::invoke_v(0x123);
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar7 != 1) {
		      if (iVar3 == 0) {
		        DAT_ram_009d3e38 = 0;
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar2 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x282,&local_20);
		  iVar7 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar7 != 1) {
		    import::env::__resumeException(uVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__cxa_find_matching_catch_3(0);
		  unnamed_function_937();
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

}
