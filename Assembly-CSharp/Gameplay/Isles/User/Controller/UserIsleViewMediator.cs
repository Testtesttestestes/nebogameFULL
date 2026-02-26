using System;
using CloudsFly.Movement;
using Gameplay.Isles.Base.Controller;
using Gameplay.Isles.Base.Events;
using Gameplay.Isles.User.Events;
using Gameplay.Isles.User.Model;
using Gameplay.Isles.User.View;
using Il2CppDummyDll;

namespace Gameplay.Isles.User.Controller
{
	// Token: 0x02000D3F RID: 3391
	[Token(Token = "0x2000D3F")]
	public class UserIsleViewMediator : BaseIsleViewMediator<UserIsleController, UserIsleView, UserIsleModel, UserIsleEvents>
	{
		// Token: 0x0600530C RID: 21260 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600530C")]
		[Address(RVA = "0xA0E1", Offset = "0xA0E1", VA = "0xA0E1")]
		public UserIsleViewMediator(UserIsleModel model, UserIsleEvents events, UserIsleController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Isles_User_Controller_UserIsleViewMediator___ctor
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  int *piVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a593b3 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_Controller_BaseIsleViewMediator_UserIsleController__UserIsleView__UserIsleModel__UserIsleEvents__set_View__
		              );
		    DAT_ram_00a593b3 = '\x01';
		  }
		  Gameplay_Isles_Base_Controller_BaseIsleViewMediator_object__object__object__object___set_Events
		            (param1,param2,
		             Method_Gameplay_Isles_Base_Controller_BaseIsleViewMediator_UserIsleController__UserIsleView__UserIsleModel__UserIsleEvents__set_View__
		            );
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar1 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(param1_00,0);
		  if (iVar1 != 0) {
		    piVar2 = (int *)param1[6];
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    iVar3 = *piVar2;
		    (**(code **)((ulonglong)*(uint *)(iVar3 + 0x160) * 4))
		              (piVar2,*(undefined4 *)(iVar1 + 0x38),*(undefined4 *)(iVar3 + 0x164));
		    piVar2 = (int *)param1[7];
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    iVar3 = *piVar2;
		    (**(code **)((ulonglong)*(uint *)(iVar3 + 0x160) * 4))
		              (piVar2,*(undefined4 *)(iVar1 + 0x3c),*(undefined4 *)(iVar3 + 0x164));
		    piVar2 = (int *)param1[8];
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    iVar3 = *piVar2;
		    (**(code **)((ulonglong)*(uint *)(iVar3 + 0x160) * 4))
		              (piVar2,*(undefined4 *)(iVar1 + 0x40),*(undefined4 *)(iVar3 + 0x164));
		    piVar2 = (int *)param1[9];
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    iVar3 = *piVar2;
		    (**(code **)((ulonglong)*(uint *)(iVar3 + 0x160) * 4))
		              (piVar2,*(undefined4 *)(iVar1 + 0x44),*(undefined4 *)(iVar3 + 0x164));
		  }
		  return;
		}
		*/

		}

		// Token: 0x170010E7 RID: 4327
		// (set) Token: 0x0600530D RID: 21261 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170010E7")]
		public override UserIsleView View
		{
			[Token(Token = "0x600530D")]
			[Address(RVA = "0xA0E2", Offset = "0xA0E2", VA = "0xA0E2", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x170010E8 RID: 4328
		// (set) Token: 0x0600530E RID: 21262 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170010E8")]
		public override BaseIsleEvents Events
		{
			[Token(Token = "0x600530E")]
			[Address(RVA = "0xA0E3", Offset = "0xA0E3", VA = "0xA0E3", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x0600530F RID: 21263 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600530F")]
		[Address(RVA = "0xA0E4", Offset = "0xA0E4", VA = "0xA0E4")]
		private void IsleViewChangedEventHandler(uint type)
		{
		/* --- GHIDRA: IsleViewChangedEventHandler ---
		void Gameplay_Isles_User_Controller_UserIsleViewMediator__IsleViewChangedEventHandler
		               (int param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 in_register_20000014;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 param1_00;
		  int *piVar4;
		  int iVar5;
		  undefined8 uVar6;
		  
		  if (DAT_ram_00a593b6 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_UserIsleModel__BaseIsleEvents__UserIsleController__UserIsleView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Battles_View_BattlesWindow_BattlesWindowArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_PopupController_Show_BattlesWindow___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12574);
		    DAT_ram_00a593b6 = '\x01';
		  }
		  piVar4 = *(int **)(*(int *)(param1 + 8) + 0x28);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x110);
		        goto code_r0x80ff6ff2;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,10);
		code_r0x80ff6ff2:
		  iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,CONCAT44(in_register_20000014,puVar2[1]));
		  uVar6 = *(undefined8 *)(*(int *)(param1 + 8) + 0x10);
		  piVar4 = (int *)Gameplay_World_Model_WorldModel__set_IsMovingOnWorldLevel
		                            (*(undefined4 *)(iVar5 + 0x14),uVar6,0);
		  uVar6 = CONCAT44((int)((ulonglong)uVar6 >> 0x20),param2);
		  iVar5 = (**(code **)((ulonglong)*(uint *)(*piVar4 + 0x118) * 4))
		                    (piVar4,uVar6,*(undefined4 *)(*piVar4 + 0x11c));
		  uVar3 = (undefined4)((ulonglong)uVar6 >> 0x20);
		  if ((param2 == 2) && (iVar5 == 0)) {
		    uVar1 = 0;
		    piVar4 = *(int **)(*(int *)(param1 + 8) + 0x28);
		    iVar5 = *piVar4;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xe0);
		          goto code_r0x80ff70b0;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x80ff70b0:
		    uVar6 = CONCAT44(uVar3,puVar2[1]);
		    piVar4 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(piVar4,uVar6);
		    uVar3 = (undefined4)((ulonglong)uVar6 >> 0x20);
		    uVar1 = 0;
		    iVar5 = *piVar4;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      do {
		        if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xe8);
		          goto code_r0x80ff7132;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar4,Core_Application_IApp_TypeInfo,5);
		code_r0x80ff7132:
		    uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,CONCAT44(uVar3,puVar2[1]));
		    param1_00 = unnamed_function_1417
		                          (Gameplay_Battles_View_BattlesWindow_BattlesWindowArgs_TypeInfo);
		    Gameplay_AccountLinker_View_SelectUserWindow___ctor(param1_00,0);
		    Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		              (uVar3,StringLiteral_12574,param1_00,
		               Method_UI_Windows_PopupController_Show_BattlesWindow___);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06005310 RID: 21264 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005310")]
		[Address(RVA = "0xA0E5", Offset = "0xA0E5", VA = "0xA0E5", Slot = "22")]
		protected override void HandleBuildingClick(uint type)
		{
		/* --- GHIDRA: HandleBuildingClick ---
		void Gameplay_Isles_User_Controller_UserIsleViewMediator__HandleBuildingClick
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 *puVar3;
		  undefined4 param1_00;
		  int iVar4;
		  int *piVar5;
		  int iVar6;
		  uint uVar7;
		  int *piVar8;
		  int local_20;
		  undefined1 *puStack_1c;
		  undefined8 local_18;
		  undefined1 local_10 [8];
		  undefined8 local_8;
		  
		  if (DAT_ram_00a593b7 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_UserIsleModel__BaseIsleEvents__UserIsleController__UserIsleView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__BaseIsleBuildingView__get_Values__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__BaseIsleBuildingView__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__BaseIsleBuildingView__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__BaseIsleBuildingView__get_Current__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Tutorial_Guide_Model_Data_IGuideTarget_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_uint__BaseIsleBuildingView__GetEnumerator__
		              );
		    DAT_ram_00a593b7 = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar1 = func_ii_12328(uVar1,0);
		  uVar1 = System_Collections_Generic_Dictionary_int__object___TryAdd
		                    (uVar1,
		                     Method_System_Collections_Generic_Dictionary_uint__BaseIsleBuildingView__get_Values__
		                    );
		  System_Collections_Generic_Dictionary_Int32Enum__object___get_Values
		            (&local_20,uVar1,
		             Method_System_Collections_Generic_Dictionary_ValueCollection_uint__BaseIsleBuildingView__GetEnumerator__
		            );
		  local_8 = local_18;
		  local_20 = 0;
		  puStack_1c = local_10;
		  do {
		    do {
		      DAT_ram_009d3e38 = 0;
		      iVar2 = import::env::invoke_iii
		                        (s_struct_Uniforms___color__array<v_ram_00000aff + 0x25b,local_10,
		                         Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__BaseIsleBuildingView__MoveNext__
		                        );
		      iVar6 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar6 == 1) {
		        uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80ff75d7;
		      }
		      if (iVar2 == 0) {
		        DAT_ram_009d3e38 = 0;
		        return;
		      }
		      DAT_ram_009d3e38 = 0;
		      uVar1 = local_8._4_4_;
		      iVar2 = import::env::invoke_iii
		                        (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x298,local_8._4_4_,0);
		      iVar6 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar6 == 1) {
		        uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80ff75d7;
		      }
		    } while (iVar2 == 0);
		    DAT_ram_009d3e38 = 0;
		    piVar5 = (int *)import::env::invoke_iii
		                              (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x298,uVar1,0);
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 == 1) {
		      uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80ff75d7;
		    }
		    iVar6 = *piVar5;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      uVar7 = 0;
		      do {
		        piVar8 = (int *)(*(int *)(iVar6 + 0x58) + uVar7 * 8);
		        if (Gameplay_Tutorial_Guide_Model_Data_IGuideTarget_TypeInfo == *piVar8) {
		          puVar3 = (undefined4 *)(piVar8[1] * 8 + iVar6 + 0xe0);
		          goto code_r0x80ff738d;
		        }
		        uVar7 = uVar7 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar7);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar3 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar5,
		                        Gameplay_Tutorial_Guide_Model_Data_IGuideTarget_TypeInfo,4);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80ff73f0:
		      DAT_ram_009d3e38 = 0;
		      uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80ff75d7;
		    }
		code_r0x80ff738d:
		    DAT_ram_009d3e38 = 0;
		    uVar1 = import::env::invoke_iii(*puVar3,piVar5,puVar3[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80ff73f0;
		    if (*(char *)(param1[2] + 0x2c) != '\0') {
		      iVar6 = *(int *)(param1[2] + 8);
		      if (DAT_ram_00a6456f == '\0') {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vi(0x7ff,&Core_Gameplay_Game_TypeInfo);
		        iVar2 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar2 == 1) {
		          uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80ff75d7;
		        }
		        DAT_ram_00a6456f = '\x01';
		      }
		      piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		      iVar2 = *piVar5;
		      if (*(ushort *)(iVar2 + 0xb6) != 0) {
		        uVar7 = 0;
		        do {
		          piVar8 = (int *)(*(int *)(iVar2 + 0x58) + uVar7 * 8);
		          if (Core_Gameplay_IGame_TypeInfo == *piVar8) {
		            puVar3 = (undefined4 *)(piVar8[1] * 8 + iVar2 + 0x140);
		            goto code_r0x80ff74e8;
		          }
		          uVar7 = uVar7 + 1;
		        } while (*(ushort *)(iVar2 + 0xb6) != uVar7);
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar3 = (undefined4 *)
		               import::env::invoke_iiii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar5,
		                          Core_Gameplay_IGame_TypeInfo,0x10);
		      if (DAT_ram_009d3e38 != 1) {
		code_r0x80ff74e8:
		        DAT_ram_009d3e38 = 0;
		        param1_00 = import::env::invoke_iii(*puVar3,piVar5,puVar3[1]);
		        if (DAT_ram_009d3e38 != 1) {
		          DAT_ram_009d3e38 = 0;
		          iVar4 = func_ii_7112(param1_00,0);
		          iVar2 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar2 != 1) {
		            uVar7 = (uint)(iVar4 == iVar6);
		            goto code_r0x80ff755e;
		          }
		          uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80ff75d7;
		        }
		      }
		      DAT_ram_009d3e38 = 0;
		      uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80ff75d7;
		    }
		    uVar7 = 0;
		code_r0x80ff755e:
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii(s_struct_Uniforms___color__array<v_ram_000013c7 + 0x269,uVar1,uVar7,0);
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 == 1) {
		      uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80ff75d7:
		      iVar6 = global_1;
		      iVar2 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar6 == iVar2) {
		        piVar5 = (int *)import::env::__cxa_begin_catch(uVar1);
		        iVar2 = *piVar5;
		        DAT_ram_009d3e38 = 0;
		        local_20 = iVar2;
		        import::env::invoke_v(0x123);
		        iVar6 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar6 != 1) {
		          if (iVar2 == 0) {
		            DAT_ram_009d3e38 = 0;
		            return;
		          }
		          System_Data_DataSet__ValidateLocaleConstraint(iVar2);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        uVar1 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x299,&local_20);
		      iVar6 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar6 == 1) {
		        import::env::__cxa_find_matching_catch_3(0);
		        unnamed_function_937();
		        do {
		          halt_trap();
		        } while( true );
		      }
		      import::env::__resumeException(uVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  } while( true );
		}
		*/

		}

		// Token: 0x06005311 RID: 21265 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005311")]
		[Address(RVA = "0xA0E6", Offset = "0xA0E6", VA = "0xA0E6")]
		private void HandleMovCompleteEvent(WorldMovementTypes worldMovementTypes)
		{
		/* --- GHIDRA: HandleMovCompleteEvent ---
		void Gameplay_Isles_User_Controller_UserIsleViewMediator__HandleMovCompleteEvent
		               (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 in_register_20000014;
		  uint *puVar2;
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar3;
		  
		  if (DAT_ram_00a593b8 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_UserIsleModel__BaseIsleEvents__UserIsleController__UserIsleView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a593b8 = '\x01';
		  }
		  if (*(char *)(*(int *)(param1 + 8) + 0x2c) == '\0') {
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    param1_01 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar3 = *param1_01;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x110);
		          goto code_r0x80ff7774;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,10);
		code_r0x80ff7774:
		    param1_00 = (**(code **)((ulonglong)*puVar2 * 4))
		                          (param1_01,CONCAT44(in_register_20000014,puVar2[1]));
		    Core_Gameplay_Managers_WorldManager__GoHome
		              (param1_00,*(undefined8 *)(*(int *)(param1 + 8) + 0x10),0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06005312 RID: 21266 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005312")]
		[Address(RVA = "0xA0E7", Offset = "0xA0E7", VA = "0xA0E7", Slot = "21")]
		protected override void HandleClickBg()
		{
		/* --- GHIDRA: HandleClickBg ---
		void Gameplay_Isles_User_Controller_UserIsleViewMediator__HandleClickBg
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  undefined4 *puVar4;
		  int iVar5;
		  int *piVar6;
		  uint *puVar7;
		  undefined4 param1_00;
		  int *param2_00;
		  int *piVar8;
		  int iVar9;
		  int local_20;
		  undefined8 *puStack_1c;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a593b9 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_UserIsleModel__BaseIsleEvents__UserIsleController__UserIsleView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__BaseIsleBuildingView__get_Values__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__BaseIsleBuildingView__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__BaseIsleBuildingView__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__BaseIsleBuildingView__get_Current__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Tutorial_Guide_Model_Data_IGuideTarget_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_uint__BaseIsleBuildingView__GetEnumerator__
		              );
		    DAT_ram_00a593b9 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = func_ii_12328(uVar2,0);
		  uVar2 = System_Collections_Generic_Dictionary_int__object___TryAdd
		                    (uVar2,
		                     Method_System_Collections_Generic_Dictionary_uint__BaseIsleBuildingView__get_Values__
		                    );
		  System_Collections_Generic_Dictionary_Int32Enum__object___get_Values
		            (&local_20,uVar2,
		             Method_System_Collections_Generic_Dictionary_ValueCollection_uint__BaseIsleBuildingView__GetEnumerator__
		            );
		  local_8 = local_18;
		  local_20 = 0;
		  puStack_1c = &local_10;
		code_r0x80ff7878:
		  DAT_ram_009d3e38 = 0;
		  iVar3 = import::env::invoke_iii
		                    (s_struct_Uniforms___color__array<v_ram_00000aff + 0x25b,&local_10,
		                     Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__BaseIsleBuildingView__MoveNext__
		                    );
		  iVar9 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar9 == 1) {
		    uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    goto code_r0x80ff7be9;
		  }
		  if (iVar3 == 0) goto code_r0x80ff7c3f;
		  piVar6 = local_8._4_4_;
		  if (*(char *)(param1[2] + 0x2c) != '\0') {
		    iVar9 = *(int *)(param1[2] + 8);
		    if (DAT_ram_00a6456f == '\0') {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi(0x7ff,&Core_Gameplay_Game_TypeInfo);
		      iVar3 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar3 == 1) {
		        uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80ff7be9;
		      }
		      DAT_ram_00a6456f = '\x01';
		    }
		    param2_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar3 = *param2_00;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar8 = (int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8);
		        if (Core_Gameplay_IGame_TypeInfo == *piVar8) {
		          puVar4 = (undefined4 *)(piVar8[1] * 8 + iVar3 + 0x140);
		          goto code_r0x80ff79d3;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar4 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,param2_00,
		                        Core_Gameplay_IGame_TypeInfo,0x10);
		    if (DAT_ram_009d3e38 != 1) {
		code_r0x80ff79d3:
		      DAT_ram_009d3e38 = 0;
		      uVar2 = import::env::invoke_iii(*puVar4,param2_00,puVar4[1]);
		      if (DAT_ram_009d3e38 != 1) {
		        DAT_ram_009d3e38 = 0;
		        iVar5 = func_ii_7112(uVar2,0);
		        iVar3 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar3 == 1) {
		          uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80ff7be9;
		        }
		        if (iVar5 == iVar9) {
		          uVar1 = 1;
		        }
		        else {
		          DAT_ram_009d3e38 = 0;
		          iVar3 = import::env::invoke_iii
		                            (*(undefined4 *)(*piVar6 + 0x110),piVar6,
		                             *(undefined4 *)(*piVar6 + 0x114));
		          iVar9 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar9 == 1) {
		            uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x80ff7be9;
		          }
		          uVar1 = 1;
		          if (iVar3 == 1) goto code_r0x80ff7bb0;
		          DAT_ram_009d3e38 = 0;
		          iVar3 = import::env::invoke_iii
		                            (*(undefined4 *)(*piVar6 + 0x110),piVar6,
		                             *(undefined4 *)(*piVar6 + 0x114));
		          iVar9 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar9 == 1) {
		            uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x80ff7be9;
		          }
		          if (iVar3 != 4) {
		            DAT_ram_009d3e38 = 0;
		            iVar3 = import::env::invoke_iii
		                              (*(undefined4 *)(*piVar6 + 0x110),piVar6,
		                               *(undefined4 *)(*piVar6 + 0x114));
		            iVar9 = DAT_ram_009d3e38;
		            DAT_ram_009d3e38 = 0;
		            if (iVar9 == 1) {
		              uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		              goto code_r0x80ff7be9;
		            }
		            uVar1 = (uint)(iVar3 == 3);
		          }
		        }
		        goto code_r0x80ff7bb0;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    goto code_r0x80ff7be9;
		  }
		  uVar1 = 0;
		code_r0x80ff7bb0:
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_viii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x29a,piVar6,uVar1,0);
		  iVar9 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar9 == 1) goto code_r0x80ff7be1;
		  goto code_r0x80ff7878;
		code_r0x80ff7be1:
		  uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80ff7be9:
		  iVar9 = global_1;
		  iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar9 == iVar3) {
		    piVar6 = (int *)import::env::__cxa_begin_catch(uVar2);
		    iVar3 = *piVar6;
		    DAT_ram_009d3e38 = 0;
		    local_20 = iVar3;
		    import::env::invoke_v(0x123);
		    iVar9 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar9 != 1) {
		      if (iVar3 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		code_r0x80ff7c3f:
		      DAT_ram_009d3e38 = 0;
		      uVar1 = 0;
		      uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      piVar6 = (int *)Gameplay_Isles_User_View_UserIsleBuildingView___ctor(uVar2,0);
		      iVar9 = *piVar6;
		      if (*(ushort *)(iVar9 + 0xb6) != 0) {
		        do {
		          if (Gameplay_Tutorial_Guide_Model_Data_IGuideTarget_TypeInfo ==
		              *(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8)) {
		            puVar7 = (uint *)(*(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8 + 4) * 8 + iVar9 + 0xe0);
		            goto code_r0x80ff7ccc;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar9 + 0xb6) != uVar1);
		      }
		      puVar7 = (uint *)func_ii_1080(piVar6,Gameplay_Tutorial_Guide_Model_Data_IGuideTarget_TypeInfo,
		                                    4);
		code_r0x80ff7ccc:
		      uVar2 = (**(code **)((ulonglong)*puVar7 * 4))(piVar6,puVar7[1]);
		      if (*(char *)(param1[2] + 0x2c) == '\0') {
		        iVar9 = *(int *)(param1[2] + 8);
		        if (DAT_ram_00a6456f == '\0') {
		          Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		          DAT_ram_00a6456f = '\x01';
		        }
		        piVar6 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		        iVar3 = *piVar6;
		        if (*(ushort *)(iVar3 + 0xb6) != 0) {
		          uVar1 = 0;
		          do {
		            if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		              puVar7 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x140
		                               );
		              goto code_r0x80ff7dc7;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		        }
		        puVar7 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x80ff7dc7:
		        param1_00 = (**(code **)((ulonglong)*puVar7 * 4))(piVar6,puVar7[1]);
		        iVar3 = func_ii_7112(param1_00,0);
		        uVar1 = (uint)(iVar3 != iVar9);
		      }
		      else {
		        uVar1 = 0;
		      }
		      UnityEngine_Object__op_Implicit(uVar2,uVar1,0);
		      return;
		    }
		    uVar2 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x29b,&local_20);
		  iVar9 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar9 != 1) {
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

		// Token: 0x06005313 RID: 21267 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005313")]
		[Address(RVA = "0xA0E8", Offset = "0xA0E8", VA = "0xA0E8", Slot = "25")]
		protected override void ValidateBuildingAvailability()
		{
		/* --- GHIDRA: ValidateBuildingAvailability ---
		undefined4
		Gameplay_Isles_User_Controller_UserIsleViewMediator__ValidateBuildingAvailability
		          (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int *param1_00;
		  
		  if (DAT_ram_00a593ba == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_UserIsleModel__BaseIsleEvents__UserIsleController__UserIsleView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a593ba = '\x01';
		  }
		  iVar4 = *(int *)(*(int *)(param1 + 8) + 0x38);
		  if (iVar4 != 0) {
		    uVar3 = Core_Extensions_Dict_IsleDecorationsDicExt__GetAnimationAssetId(iVar4,0);
		    return uVar3;
		  }
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
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x178);
		        goto code_r0x80ff7eeb;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80ff7eeb:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  uVar3 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar3,0);
		  uVar3 = Core_Extensions_Dict_DictExt__GetClanCult
		                    (uVar3,*(undefined4 *)
		                            (*(int *)(*(int *)(*(int *)(param1 + 8) + 8) + 0x34) + 0x30),0);
		  uVar3 = Core_Extensions_Dict_IsleDecorationsDicExt__GetAnimationAssetId(uVar3,0);
		  return uVar3;
		}
		*/

		}

		// Token: 0x06005314 RID: 21268 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005314")]
		[Address(RVA = "0xA0E9", Offset = "0xA0E9", VA = "0xA0E9", Slot = "27")]
		protected override string GetBgAssetId()
		{
		/* --- GHIDRA: GetBgAssetId ---
		void Gameplay_Isles_User_Controller_UserIsleViewMediator__GetBgAssetId(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int *piVar5;
		  int iVar6;
		  int iVar7;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a593bb == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_UserIsleModel__BaseIsleEvents__UserIsleController__UserIsleView__Dispose__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_WorldMovementTypes__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Isles_User_Controller_UserIsleViewMediator_HandleMovCompleteEvent__)
		    ;
		    DAT_ram_00a593bb = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x110);
		        goto code_r0x80ff7ff1;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,10);
		code_r0x80ff7ff1:
		  iVar6 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		  iVar7 = *(int *)(iVar6 + 8);
		  param1_00 = *(undefined4 *)(iVar7 + 0xc);
		  uVar3 = unnamed_function_1417(System_Action_WorldMovementTypes__TypeInfo);
		  System_Action_int___Invoke
		            (uVar3,param1,
		             Method_Gameplay_Isles_User_Controller_UserIsleViewMediator_HandleMovCompleteEvent__,0);
		  iVar6 = func_ii_7048(param1_00,uVar3,0);
		  uVar3 = System_Action_WorldMovementTypes__TypeInfo;
		  if (iVar6 == 0) {
		    *(undefined4 *)(iVar7 + 0xc) = 0;
		  }
		  else {
		    iVar4 = func_ii_1082(iVar6,System_Action_WorldMovementTypes__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar6,uVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar7 + 0xc) = iVar4;
		    uVar3 = System_Action_WorldMovementTypes__TypeInfo;
		    iVar7 = func_ii_1082(iVar6,System_Action_WorldMovementTypes__TypeInfo);
		    if (iVar7 == 0) {
		      System_Activator__CreateInstance(iVar6,uVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  piVar5 = *(int **)(param1 + 0x18);
		  if (piVar5 != (int *)0x0) {
		    (**(code **)((ulonglong)*(uint *)(*piVar5 + 0x130) * 4))
		              (piVar5,*(undefined4 *)(*piVar5 + 0x134));
		  }
		  piVar5 = *(int **)(param1 + 0x1c);
		  if (piVar5 != (int *)0x0) {
		    (**(code **)((ulonglong)*(uint *)(*piVar5 + 0x130) * 4))
		              (piVar5,*(undefined4 *)(*piVar5 + 0x134));
		  }
		  piVar5 = *(int **)(param1 + 0x20);
		  if (piVar5 != (int *)0x0) {
		    (**(code **)((ulonglong)*(uint *)(*piVar5 + 0x130) * 4))
		              (piVar5,*(undefined4 *)(*piVar5 + 0x134));
		  }
		  iVar6 = **(int **)(param1 + 0x24);
		  (**(code **)((ulonglong)*(uint *)(iVar6 + 0x130) * 4))
		            (*(int **)(param1 + 0x24),*(undefined4 *)(iVar6 + 0x134));
		  *(undefined8 *)(param1 + 0x20) = 0;
		  *(undefined8 *)(param1 + 0x18) = 0;
		  MVC_AbstractViewMediator_object__object__object__object___Core_MVC_Interfaces_IViewMediator_set_View
		            (param1,
		             Method_MVC_AbstractViewMediator_UserIsleModel__BaseIsleEvents__UserIsleController__UserIsleView__Dispose__
		            );
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06005315 RID: 21269 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005315")]
		[Address(RVA = "0xA0EA", Offset = "0xA0EA", VA = "0xA0EA", Slot = "14")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_Isles_User_Controller_UserIsleViewMediator__Dispose
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5,undefined4 param6)
		
		{
		  if (DAT_ram_00a593bc == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_ArenaCombatModel__ArenaCombatEvents__ArenaCombatController__ArenaCombatViewMediator__OneOnOneCombatView___ctor__
		              );
		    DAT_ram_00a593bc = '\x01';
		  }
		  Gameplay_Combat_Control_AbstractCombatViewMediator_object__object__object__object___set_View
		            (param1,param2,param3,param4,param5,
		             Method_Gameplay_Combat_AbstractCombat_ArenaCombatModel__ArenaCombatEvents__ArenaCombatController__ArenaCombatViewMediator__OneOnOneCombatView___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x04002D08 RID: 11528
		[Token(Token = "0x4002D08")]
		[FieldOffset(Offset = "0x18")]
		private IsleBonusesViewMediator _isleBonusesViewMediator;

		// Token: 0x04002D09 RID: 11529
		[Token(Token = "0x4002D09")]
		[FieldOffset(Offset = "0x1C")]
		private IsleDecorationsViewMediator _isleDecorationsViewMediator;

		// Token: 0x04002D0A RID: 11530
		[Token(Token = "0x4002D0A")]
		[FieldOffset(Offset = "0x20")]
		private IsleAnimationViewMediator _isleAnimationViewMediator;

		// Token: 0x04002D0B RID: 11531
		[Token(Token = "0x4002D0B")]
		[FieldOffset(Offset = "0x24")]
		private IsleAccountMarkersViewMediator _isleAccountMarkersViewMediator;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_View ---
		void Gameplay_Isles_User_Controller_UserIsleViewMediator__set_View
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  int *piVar2;
		  undefined4 uVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a593b4 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_uint__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_Controller_BaseIsleViewMediator_UserIsleController__UserIsleView__UserIsleModel__UserIsleEvents__set_Events__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Isles_User_Events_UserIsleEvents_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_User_Controller_UserIsleViewMediator_IsleViewChangedEventHandler__
		              );
		    DAT_ram_00a593b4 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    piVar2 = (int *)(**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                              (param1,*(undefined4 *)(*param1 + 0x13c));
		    if (piVar2 != (int *)0x0) {
		      if (((uint)*(byte *)(*piVar2 + 0xb8) <
		           (uint)*(byte *)(Gameplay_Isles_User_Events_UserIsleEvents_TypeInfo + 0xb8)) ||
		         (*(int *)(*(int *)(*piVar2 + 100) +
		                   (uint)*(byte *)(Gameplay_Isles_User_Events_UserIsleEvents_TypeInfo + 0xb8) * 4 +
		                  -4) != Gameplay_Isles_User_Events_UserIsleEvents_TypeInfo)) {
		        System_Activator__CreateInstance(piVar2,Gameplay_Isles_User_Events_UserIsleEvents_TypeInfo);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    iVar1 = piVar2[0xf];
		    uVar3 = unnamed_function_1417(System_Action_uint__TypeInfo);
		    func_ii_12322(uVar3,param1,
		                  Method_Gameplay_Isles_User_Controller_UserIsleViewMediator_IsleViewChangedEventHandler__
		                  ,0);
		    iVar1 = func_ii_7048(iVar1,uVar3,0);
		    uVar3 = System_Action_uint__TypeInfo;
		    if (iVar1 == 0) {
		      piVar2[0xf] = 0;
		    }
		    else {
		      iVar4 = func_ii_1082(iVar1,System_Action_uint__TypeInfo);
		      if (iVar4 == 0) {
		        System_Activator__CreateInstance(iVar1,uVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      piVar2[0xf] = iVar4;
		      uVar3 = System_Action_uint__TypeInfo;
		      iVar4 = func_ii_1082(iVar1,System_Action_uint__TypeInfo);
		      if (iVar4 == 0) {
		        System_Activator__CreateInstance(iVar1,uVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		  }
		  Gameplay_Isles_Base_Controller_BaseIsleViewMediator_object__object__object__object___RenderIsle
		            (param1,param2,
		             Method_Gameplay_Isles_Base_Controller_BaseIsleViewMediator_UserIsleController__UserIsleView__UserIsleModel__UserIsleEvents__set_Events__
		            );
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    piVar2 = (int *)(**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                              (param1,*(undefined4 *)(*param1 + 0x13c));
		    if (piVar2 != (int *)0x0) {
		      if (((uint)*(byte *)(*piVar2 + 0xb8) <
		           (uint)*(byte *)(Gameplay_Isles_User_Events_UserIsleEvents_TypeInfo + 0xb8)) ||
		         (*(int *)(*(int *)(*piVar2 + 100) +
		                   (uint)*(byte *)(Gameplay_Isles_User_Events_UserIsleEvents_TypeInfo + 0xb8) * 4 +
		                  -4) != Gameplay_Isles_User_Events_UserIsleEvents_TypeInfo)) {
		        System_Activator__CreateInstance(piVar2,Gameplay_Isles_User_Events_UserIsleEvents_TypeInfo);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    iVar1 = piVar2[0xf];
		    uVar3 = unnamed_function_1417(System_Action_uint__TypeInfo);
		    func_ii_12322(uVar3,param1,
		                  Method_Gameplay_Isles_User_Controller_UserIsleViewMediator_IsleViewChangedEventHandler__
		                  ,0);
		    iVar1 = UnityEngine_UI_Image__set_sprite(iVar1,uVar3,0);
		    uVar3 = System_Action_uint__TypeInfo;
		    if (iVar1 == 0) {
		      piVar2[0xf] = 0;
		      return;
		    }
		    iVar4 = func_ii_1082(iVar1,System_Action_uint__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    piVar2[0xf] = iVar4;
		    uVar3 = System_Action_uint__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_uint__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_Events ---
		void Gameplay_Isles_User_Controller_UserIsleViewMediator__set_Events
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a593b5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_UserIsleModel__BaseIsleEvents__UserIsleController__UserIsleView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__BaseBuildingData__get_Item__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__BaseIsleBuildingView__get_Item__)
		    ;
		    DAT_ram_00a593b5 = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar1 = func_ii_12328(uVar1,0);
		  uVar1 = System_Collections_Generic_List_object___get_Item
		                    (uVar1,param2,
		                     Method_System_Collections_Generic_Dictionary_uint__BaseIsleBuildingView__get_Item__
		                    );
		  param2_00 = System_Collections_Generic_List_object___get_Item
		                        (*(undefined4 *)(param1[2] + 0x24),param2,
		                         Method_System_Collections_Generic_Dictionary_uint__BaseBuildingData__get_Item__
		                        );
		  Gameplay_Isles_Base_View_BaseIsleBuildingView__remove_ClickedEvent(uVar1,param2_00,0);
		  return;
		}
		*/

}
