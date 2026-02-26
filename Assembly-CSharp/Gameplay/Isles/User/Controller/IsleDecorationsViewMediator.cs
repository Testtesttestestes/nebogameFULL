using System;
using Gameplay.Isles.User.Events;
using Gameplay.Isles.User.Model;
using Gameplay.Isles.User.View;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Isles.User.Controller
{
	// Token: 0x02000D37 RID: 3383
	[Token(Token = "0x2000D37")]
	public class IsleDecorationsViewMediator : AbstractViewMediator<UserIsleModel, UserIsleEvents, UserIsleController, IsleDecorationsView>
	{
		// Token: 0x060052BD RID: 21181 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052BD")]
		[Address(RVA = "0xA093", Offset = "0xA093", VA = "0xA093")]
		public IsleDecorationsViewMediator(UserIsleModel model, UserIsleEvents events, UserIsleController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Isles_User_Controller_IsleDecorationsViewMediator___ctor
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a58db3 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_UserIsleModel__UserIsleEvents__UserIsleController__IsleDecorationsView__set_Events__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_uint__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_User_Controller_IsleDecorationsViewMediator_DecorationAddedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_User_Controller_IsleDecorationsViewMediator_DecorationRemovedEvent__
		              );
		    DAT_ram_00a58db3 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar1 + 0x2c);
		    uVar2 = unnamed_function_1417(System_Action_uint__TypeInfo);
		    func_ii_12322(uVar2,param1,
		                  Method_Gameplay_Isles_User_Controller_IsleDecorationsViewMediator_DecorationAddedEvent__
		                  ,0);
		    iVar3 = func_ii_7048(uVar5,uVar2,0);
		    uVar2 = System_Action_uint__TypeInfo;
		    if (iVar3 == 0) {
		      *(undefined4 *)(iVar1 + 0x2c) = 0;
		    }
		    else {
		      iVar4 = func_ii_1082(iVar3,System_Action_uint__TypeInfo);
		      if (iVar4 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x2c) = iVar4;
		      uVar2 = System_Action_uint__TypeInfo;
		      iVar1 = func_ii_1082(iVar3,System_Action_uint__TypeInfo);
		      if (iVar1 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar1 + 0x30);
		    uVar2 = unnamed_function_1417(System_Action_uint__TypeInfo);
		    func_ii_12322(uVar2,param1,
		                  Method_Gameplay_Isles_User_Controller_IsleDecorationsViewMediator_DecorationRemovedEvent__
		                  ,0);
		    iVar3 = func_ii_7048(uVar5,uVar2,0);
		    uVar2 = System_Action_uint__TypeInfo;
		    if (iVar3 == 0) {
		      *(undefined4 *)(iVar1 + 0x30) = 0;
		    }
		    else {
		      iVar4 = func_ii_1082(iVar3,System_Action_uint__TypeInfo);
		      if (iVar4 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x30) = iVar4;
		      uVar2 = System_Action_uint__TypeInfo;
		      iVar1 = func_ii_1082(iVar3,System_Action_uint__TypeInfo);
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
		    uVar5 = *(undefined4 *)(iVar1 + 0x2c);
		    uVar2 = unnamed_function_1417(System_Action_uint__TypeInfo);
		    func_ii_12322(uVar2,param1,
		                  Method_Gameplay_Isles_User_Controller_IsleDecorationsViewMediator_DecorationAddedEvent__
		                  ,0);
		    iVar3 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		    uVar2 = System_Action_uint__TypeInfo;
		    if (iVar3 == 0) {
		      *(undefined4 *)(iVar1 + 0x2c) = 0;
		    }
		    else {
		      iVar4 = func_ii_1082(iVar3,System_Action_uint__TypeInfo);
		      if (iVar4 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x2c) = iVar4;
		      uVar2 = System_Action_uint__TypeInfo;
		      iVar1 = func_ii_1082(iVar3,System_Action_uint__TypeInfo);
		      if (iVar1 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar1 + 0x30);
		    uVar2 = unnamed_function_1417(System_Action_uint__TypeInfo);
		    func_ii_12322(uVar2,param1,
		                  Method_Gameplay_Isles_User_Controller_IsleDecorationsViewMediator_DecorationRemovedEvent__
		                  ,0);
		    iVar3 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		    uVar2 = System_Action_uint__TypeInfo;
		    if (iVar3 == 0) {
		      *(undefined4 *)(iVar1 + 0x30) = 0;
		      return;
		    }
		    iVar4 = func_ii_1082(iVar3,System_Action_uint__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar3,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar1 + 0x30) = iVar4;
		    uVar2 = System_Action_uint__TypeInfo;
		    iVar1 = func_ii_1082(iVar3,System_Action_uint__TypeInfo);
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

		// Token: 0x170010DD RID: 4317
		// (set) Token: 0x060052BE RID: 21182 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170010DD")]
		public override UserIsleEvents Events
		{
			[Token(Token = "0x60052BE")]
			[Address(RVA = "0xA094", Offset = "0xA094", VA = "0xA094", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x060052BF RID: 21183 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052BF")]
		[Address(RVA = "0xA095", Offset = "0xA095", VA = "0xA095")]
		private void DecorationRemovedEvent(uint decorationId)
		{
		/* --- GHIDRA: DecorationRemovedEvent ---
		void Gameplay_Isles_User_Controller_IsleDecorationsViewMediator__DecorationRemovedEvent
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  uint *param3_00;
		  undefined4 uVar4;
		  int *param1_00;
		  
		  if (DAT_ram_00a58db4 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a58db4 = '\x01';
		  }
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar3 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar2,0);
		  if (iVar3 != 0) {
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar3 = *param1_00;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		          param3_00 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x178)
		          ;
		          goto code_r0x80fab22b;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		    }
		    param3_00 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80fab22b:
		    uVar4 = (**(code **)((ulonglong)*param3_00 * 4))(param1_00,param3_00[1]);
		    uVar4 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar4,0);
		    uVar4 = func_ii_7699(uVar4,param2,0);
		    Core_Extensions_Dict_DictExt__GetIsleDecorationsDic(uVar2,uVar4,param3_00);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060052C0 RID: 21184 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052C0")]
		[Address(RVA = "0xA096", Offset = "0xA096", VA = "0xA096")]
		private void DecorationAddedEvent(uint decorationId)
		{
		/* --- GHIDRA: DecorationAddedEvent ---
		void Gameplay_Isles_User_Controller_IsleDecorationsViewMediator__DecorationAddedEvent
		               (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  undefined4 *puVar4;
		  undefined4 param2_00;
		  undefined4 uVar5;
		  int iVar6;
		  int *piVar7;
		  uint *puVar8;
		  int *piVar9;
		  int local_c;
		  int **local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a58db5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_UserIsleModel__UserIsleEvents__UserIsleController__IsleDecorationsView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_UserIsleModel__UserIsleEvents__UserIsleController__IsleDecorationsView__set_View__
		              );
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_uint__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_uint__GetEnumerator__);
		    DAT_ram_00a58db5 = '\x01';
		  }
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar3 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar2,0);
		  if (iVar3 != 0) {
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    Gameplay_Isles_User_View_IsleBonusesView___c__DisplayClass23_0___ShowBonusCollected_b__0
		              (uVar2,param2);
		  }
		  param1[5] = param2;
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar3 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar2,0);
		  if (iVar3 != 0) {
		    iVar3 = *param1;
		    uVar2 = (**(code **)((ulonglong)*(uint *)(iVar3 + 0x158) * 4))
		                      (param1,*(undefined4 *)(iVar3 + 0x15c));
		    Gameplay_Isles_User_View_IsleBonusesView___c__DisplayClass23_0___ShowBonusCollected_b__0
		              (uVar2,iVar3);
		    if (*(int *)(param1[2] + 0x34) != 0) {
		      local_4 = (int *)Google_Protobuf_Collections_RepeatedField_float___Equals
		                                 (*(undefined4 *)(*(int *)(param1[2] + 0x34) + 0x40),
		                                  Method_Google_Protobuf_Collections_RepeatedField_uint__GetEnumerator__
		                                 );
		      local_c = 0;
		      local_8 = &local_4;
		      do {
		        piVar7 = local_4;
		        iVar3 = *local_4;
		        if (*(ushort *)(iVar3 + 0xb6) != 0) {
		          uVar1 = 0;
		          do {
		            piVar9 = (int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8);
		            if (System_Collections_IEnumerator_TypeInfo == *piVar9) {
		              puVar4 = (undefined4 *)(iVar3 + piVar9[1] * 8 + 0xc0);
		              goto code_r0x80fab418;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar4 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                            System_Collections_IEnumerator_TypeInfo,0);
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x80fab76f:
		          DAT_ram_009d3e38 = 0;
		          uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80fab777;
		        }
		code_r0x80fab418:
		        DAT_ram_009d3e38 = 0;
		        iVar3 = import::env::invoke_iii(*puVar4,piVar7,puVar4[1]);
		        piVar7 = local_4;
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80fab76f;
		        if (iVar3 == 0) {
		          iVar3 = 0;
		          goto code_r0x80fab7c0;
		        }
		        iVar3 = *local_4;
		        if (*(ushort *)(iVar3 + 0xb6) != 0) {
		          uVar1 = 0;
		          do {
		            piVar9 = (int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8);
		            if (System_Collections_Generic_IEnumerator_uint__TypeInfo == *piVar9) {
		              puVar4 = (undefined4 *)(iVar3 + piVar9[1] * 8 + 0xc0);
		              goto code_r0x80fab4f2;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar4 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                            System_Collections_Generic_IEnumerator_uint__TypeInfo,0);
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x80fab733:
		          DAT_ram_009d3e38 = 0;
		          uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80fab777;
		        }
		code_r0x80fab4f2:
		        DAT_ram_009d3e38 = 0;
		        uVar2 = import::env::invoke_iii(*puVar4,piVar7,puVar4[1]);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80fab733;
		        DAT_ram_009d3e38 = 0;
		        param2_00 = import::env::invoke_iii
		                              (*(undefined4 *)(*param1 + 0x158),param1,
		                               *(undefined4 *)(*param1 + 0x15c));
		        iVar3 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar3 == 1) {
		          uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80fab777;
		        }
		        if (DAT_ram_00a6456f == '\0') {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vi(0x7ff,&Core_Gameplay_Game_TypeInfo);
		          iVar3 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar3 == 1) {
		            uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x80fab777;
		          }
		          DAT_ram_00a6456f = '\x01';
		        }
		        piVar7 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		        iVar3 = *piVar7;
		        if (*(ushort *)(iVar3 + 0xb6) != 0) {
		          uVar1 = 0;
		          do {
		            piVar9 = (int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8);
		            if (Core_Gameplay_IGame_TypeInfo == *piVar9) {
		              puVar4 = (undefined4 *)(piVar9[1] * 8 + iVar3 + 0x178);
		              goto code_r0x80fab65a;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar4 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar7,
		                            Core_Gameplay_IGame_TypeInfo,0x17);
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x80fab751:
		          DAT_ram_009d3e38 = 0;
		          uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80fab777;
		        }
		code_r0x80fab65a:
		        DAT_ram_009d3e38 = 0;
		        uVar5 = import::env::invoke_iii(*puVar4,piVar7,puVar4[1]);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80fab751;
		        DAT_ram_009d3e38 = 0;
		        uVar5 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar5,0);
		        iVar3 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar3 == 1) {
		          uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80fab777;
		        }
		        DAT_ram_009d3e38 = 0;
		        uVar2 = import::env::invoke_iiii
		                          (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x28d,uVar5,uVar2,0);
		        iVar3 = DAT_ram_009d3e38;
		        if (DAT_ram_009d3e38 == 1) break;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x28e,param2_00,uVar2,iVar3);
		      } while (DAT_ram_009d3e38 != 1);
		      DAT_ram_009d3e38 = 0;
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80fab777:
		      iVar3 = global_1;
		      iVar6 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar3 == iVar6) {
		        piVar7 = (int *)import::env::__cxa_begin_catch(uVar2);
		        iVar3 = *piVar7;
		        DAT_ram_009d3e38 = 0;
		        local_c = iVar3;
		        import::env::invoke_v(0x123);
		        iVar6 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar6 != 1) {
		code_r0x80fab7c0:
		          piVar7 = local_4;
		          DAT_ram_009d3e38 = 0;
		          if (local_4 != (int *)0x0) {
		            uVar1 = 0;
		            iVar6 = *local_4;
		            if (*(ushort *)(iVar6 + 0xb6) != 0) {
		              do {
		                if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		                  puVar8 = (uint *)(iVar6 + *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 +
		                                   0xc0);
		                  goto code_r0x80fab838;
		                }
		                uVar1 = uVar1 + 1;
		              } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		            }
		            puVar8 = (uint *)func_ii_1080(local_4,System_IDisposable_TypeInfo,0);
		code_r0x80fab838:
		            (**(code **)((ulonglong)*puVar8 * 4))(piVar7,puVar8[1]);
		          }
		          if (iVar3 == 0) {
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
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x28f,&local_c);
		      iVar3 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar3 != 1) {
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
		  }
		  return;
		}
		*/

		}

		// Token: 0x170010DE RID: 4318
		// (set) Token: 0x060052C1 RID: 21185 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170010DE")]
		public override IsleDecorationsView View
		{
			[Token(Token = "0x60052C1")]
			[Address(RVA = "0xA097", Offset = "0xA097", VA = "0xA097", Slot = "20")]
			set
			{
			}
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Events ---
		void Gameplay_Isles_User_Controller_IsleDecorationsViewMediator__set_Events
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    func_ii_7679(uVar1,param2,param1);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_View ---
		void Gameplay_Isles_User_Controller_IsleDecorationsViewMediator__set_View
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5)
		
		{
		  if (DAT_ram_00a58db6 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_UserIsleModel__UserIsleEvents__UserIsleController__IsleMonsterInfoWindow___ctor__
		              );
		    DAT_ram_00a58db6 = '\x01';
		  }
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (param1,param2,param3,param4,
		             Method_MVC_AbstractViewMediator_UserIsleModel__UserIsleEvents__UserIsleController__IsleMonsterInfoWindow___ctor__
		            );
		  return;
		}
		*/

}
