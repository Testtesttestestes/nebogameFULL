using System;
using System.Collections.Generic;
using Gameplay.Combat.Control;
using Gameplay.Combat.Model;
using Gameplay.Combat.View;
using Gameplay.VortexCombat.Model;
using Gameplay.VortexCombat.View;
using Il2CppDummyDll;
using Protocol.Combat;
using UnityEngine.EventSystems;
using Utils;

namespace Gameplay.VortexCombat.Control
{
	// Token: 0x020003B9 RID: 953
	[Token(Token = "0x20003B9")]
	public class VortexCombatViewMediator : AbstractCombatViewMediator<VortexCombatModel, VortexCombatEvents, VortexCombatController, VortexCombatView>
	{
		// Token: 0x06001651 RID: 5713 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001651")]
		[Address(RVA = "0x6812", Offset = "0x6812", VA = "0x6812")]
		public VortexCombatViewMediator(VortexCombatModel model, VortexCombatEvents events, VortexCombatController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_VortexCombat_Control_VortexCombatViewMediator___ctor
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a58246 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_AbstractCombatViewMediator_VortexCombatModel__VortexCombatEvents__VortexCombatController__VortexCombatView__set_Events__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TurnStates__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_VortexCombat_Control_VortexCombatViewMediator_HandleSwitchTurnEvent__
		              );
		    DAT_ram_00a58246 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar1 + 0x40);
		    uVar2 = unnamed_function_1417(System_Action_TurnStates__TypeInfo);
		    System_Action_int___Invoke
		              (uVar2,param1,
		               Method_Gameplay_VortexCombat_Control_VortexCombatViewMediator_HandleSwitchTurnEvent__
		               ,0);
		    iVar3 = func_ii_7048(uVar5,uVar2,0);
		    uVar2 = System_Action_TurnStates__TypeInfo;
		    if (iVar3 == 0) {
		      *(undefined4 *)(iVar1 + 0x40) = 0;
		    }
		    else {
		      iVar4 = func_ii_1082(iVar3,System_Action_TurnStates__TypeInfo);
		      if (iVar4 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x40) = iVar4;
		      uVar2 = System_Action_TurnStates__TypeInfo;
		      iVar1 = func_ii_1082(iVar3,System_Action_TurnStates__TypeInfo);
		      if (iVar1 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		  }
		  Gameplay_Combat_Control_AbstractCombatViewMediator_object__object__object__object___ValidateUserBalance
		            (param1,param2,
		             Method_Gameplay_Combat_Control_AbstractCombatViewMediator_VortexCombatModel__VortexCombatEvents__VortexCombatController__VortexCombatView__set_Events__
		            );
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar1 + 0x40);
		    uVar2 = unnamed_function_1417(System_Action_TurnStates__TypeInfo);
		    System_Action_int___Invoke
		              (uVar2,param1,
		               Method_Gameplay_VortexCombat_Control_VortexCombatViewMediator_HandleSwitchTurnEvent__
		               ,0);
		    iVar3 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		    uVar2 = System_Action_TurnStates__TypeInfo;
		    if (iVar3 == 0) {
		      *(undefined4 *)(iVar1 + 0x40) = 0;
		      return;
		    }
		    iVar4 = func_ii_1082(iVar3,System_Action_TurnStates__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar3,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar1 + 0x40) = iVar4;
		    uVar2 = System_Action_TurnStates__TypeInfo;
		    iVar1 = func_ii_1082(iVar3,System_Action_TurnStates__TypeInfo);
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

		// Token: 0x170003BA RID: 954
		// (set) Token: 0x06001652 RID: 5714 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003BA")]
		public override VortexCombatEvents Events
		{
			[Token(Token = "0x6001652")]
			[Address(RVA = "0x6813", Offset = "0x6813", VA = "0x6813", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x06001653 RID: 5715 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001653")]
		[Address(RVA = "0x6814", Offset = "0x6814", VA = "0x6814")]
		private void HandleSwitchTurnEvent(TurnStates obj)
		{
		/* --- GHIDRA: HandleSwitchTurnEvent ---
		void Gameplay_VortexCombat_Control_VortexCombatViewMediator__HandleSwitchTurnEvent
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int *piVar4;
		  undefined4 *puVar5;
		  undefined4 uVar6;
		  int *piVar7;
		  int *piVar8;
		  int iVar9;
		  int param3;
		  int *piVar10;
		  int local_20;
		  undefined1 *puStack_1c;
		  undefined8 local_18;
		  undefined1 local_10 [8];
		  undefined8 local_8;
		  
		  if (DAT_ram_00a58248 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_AbstractCombatViewMediator_VortexCombatModel__VortexCombatEvents__VortexCombatController__VortexCombatView__HandleInitEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_VortexCombatModel__VortexCombatEvents__VortexCombatController__VortexCombatView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_View_Animations_CombatAnimation_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_ulong__CombatPlayer__get_Values__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_ulong__CombatPlayer__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_ulong__CombatPlayer__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_ulong__CombatPlayer__get_Current__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_View_Players_ICombatPLayerView_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_ulong__CombatPlayer__GetEnumerator__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_VortexCombat_View_Player_VortexCombatPlayerView_TypeInfo)
		    ;
		    Mono_Security_ASN1__get_Item(&Gameplay_VortexCombat_Model_VortexCombatPlayer_TypeInfo);
		    DAT_ram_00a58248 = '\x01';
		  }
		  Gameplay_Combat_Control_AbstractCombatViewMediator_object__object__object__object___HandleGameOverWindowNextCombatRequestEvent
		            (param1,
		             Method_Gameplay_Combat_Control_AbstractCombatViewMediator_VortexCombatModel__VortexCombatEvents__VortexCombatController__VortexCombatView__HandleInitEvent__
		            );
		  uVar2 = System_Collections_Generic_Dictionary_int__object___TryAdd
		                    (*(undefined4 *)(param1[2] + 0x1c),
		                     Method_System_Collections_Generic_Dictionary_ulong__CombatPlayer__get_Values__)
		  ;
		  System_Collections_Generic_Dictionary_Int32Enum__object___get_Values
		            (&local_20,uVar2,
		             Method_System_Collections_Generic_Dictionary_ValueCollection_ulong__CombatPlayer__GetEnumerator__
		            );
		  local_8 = local_18;
		  local_20 = 0;
		  puStack_1c = local_10;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar3 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x2e2,local_10,
		                       Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_ulong__CombatPlayer__MoveNext__
		                      );
		    iVar9 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar9 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80ebeb36:
		      iVar9 = global_1;
		      iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar9 == iVar3) {
		        piVar7 = (int *)import::env::__cxa_begin_catch(uVar2);
		        iVar3 = *piVar7;
		        DAT_ram_009d3e38 = 0;
		        local_20 = iVar3;
		        import::env::invoke_v(0x123);
		        iVar9 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar9 != 1) {
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
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 299,&local_20);
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
		    if (iVar3 == 0) {
		      DAT_ram_009d3e38 = 0;
		      return;
		    }
		    piVar7 = local_8._4_4_;
		    if (local_8._4_4_ != (int *)0x0) {
		      if (((uint)*(byte *)(*local_8._4_4_ + 0xb8) <
		           (uint)*(byte *)(Gameplay_VortexCombat_Model_VortexCombatPlayer_TypeInfo + 0xb8)) ||
		         (*(int *)(*(int *)(*local_8._4_4_ + 100) +
		                   (uint)*(byte *)(Gameplay_VortexCombat_Model_VortexCombatPlayer_TypeInfo + 0xb8) *
		                   4 + -4) != Gameplay_VortexCombat_Model_VortexCombatPlayer_TypeInfo)) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vii
		                  (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x183,local_8._4_4_,
		                   Gameplay_VortexCombat_Model_VortexCombatPlayer_TypeInfo);
		        iVar9 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar9 != 1) {
		          do {
		            halt_trap();
		          } while( true );
		        }
		        uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80ebeb36;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    piVar4 = (int *)import::env::invoke_iii
		                              (*(undefined4 *)(*param1 + 0x158),param1,
		                               *(undefined4 *)(*param1 + 0x15c));
		    iVar9 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar9 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80ebeb36;
		    }
		    DAT_ram_009d3e38 = 0;
		    piVar4 = (int *)import::env::invoke_iiii
		                              (*(undefined4 *)(*piVar4 + 0x120),piVar4,piVar7,
		                               *(undefined4 *)(*piVar4 + 0x124));
		    iVar9 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar9 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80ebeb36;
		    }
		    uVar2 = *(undefined4 *)(*(int *)(param1[2] + 0x3c) + 0x1c);
		    if (DAT_ram_00a6456f == '\0') {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi(0x7ff,&Core_Gameplay_Game_TypeInfo);
		      iVar9 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar9 == 1) {
		        uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80ebeb36;
		      }
		      DAT_ram_00a6456f = '\x01';
		    }
		    piVar8 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar9 = *piVar8;
		    if (*(ushort *)(iVar9 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar10 = (int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8);
		        if (Core_Gameplay_IGame_TypeInfo == *piVar10) {
		          puVar5 = (undefined4 *)(piVar10[1] * 8 + iVar9 + 0x178);
		          goto code_r0x80ebe8c8;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar9 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar5 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar8,
		                        Core_Gameplay_IGame_TypeInfo,0x17);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80ebeb06:
		      DAT_ram_009d3e38 = 0;
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80ebeb36;
		    }
		code_r0x80ebe8c8:
		    DAT_ram_009d3e38 = 0;
		    uVar6 = import::env::invoke_iii(*puVar5,piVar8,puVar5[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80ebeb06;
		    DAT_ram_009d3e38 = 0;
		    uVar6 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar6,0);
		    iVar9 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar9 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80ebeb36;
		    }
		    iVar9 = *piVar4;
		    if (*(ushort *)(iVar9 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar8 = (int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8);
		        if (Gameplay_Combat_View_Players_ICombatPLayerView_TypeInfo == *piVar8) {
		          puVar5 = (undefined4 *)(iVar9 + piVar8[1] * 8 + 0xc0);
		          goto code_r0x80ebe9c8;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar9 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar5 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar4,
		                        Gameplay_Combat_View_Players_ICombatPLayerView_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80ebeb1a:
		      DAT_ram_009d3e38 = 0;
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80ebeb36;
		    }
		code_r0x80ebe9c8:
		    DAT_ram_009d3e38 = 0;
		    piVar7 = (int *)import::env::invoke_iiiiii(*puVar5,piVar4,piVar7,uVar2,uVar6,puVar5[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80ebeb1a;
		    piVar4 = (int *)0x0;
		    if (piVar7 != (int *)0x0) {
		      if (((uint)*(byte *)(Gameplay_VortexCombat_View_Player_VortexCombatPlayerView_TypeInfo + 0xb8)
		           <= (uint)*(byte *)(*piVar7 + 0xb8)) &&
		         (piVar4 = piVar7,
		         *(int *)(*(int *)(*piVar7 + 100) +
		                  (uint)*(byte *)(Gameplay_VortexCombat_View_Player_VortexCombatPlayerView_TypeInfo
		                                 + 0xb8) * 4 + -4) !=
		         Gameplay_VortexCombat_View_Player_VortexCombatPlayerView_TypeInfo)) {
		        piVar4 = (int *)0x0;
		      }
		    }
		    iVar3 = piVar4[0xe];
		    param3 = param1[10];
		    DAT_ram_009d3e38 = 0;
		    iVar9 = import::env::invoke_ii
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                       Gameplay_Combat_View_Animations_CombatAnimation_TypeInfo);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80ebeb24:
		      DAT_ram_009d3e38 = 0;
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80ebeb36;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viiiii
		              (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x12a,iVar9,param3,iVar3,100,0);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80ebeb24;
		    piVar4[0x12] = iVar9;
		  } while( true );
		}
		*/

		}

		// Token: 0x06001654 RID: 5716 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001654")]
		[Address(RVA = "0x6815", Offset = "0x6815", VA = "0x6815", Slot = "23")]
		protected override void HandleInitEvent()
		{
		/* --- GHIDRA: HandleInitEvent ---
		void Gameplay_VortexCombat_Control_VortexCombatViewMediator__HandleInitEvent
		               (int *param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *piVar3;
		  int *piVar4;
		  int iVar5;
		  longlong lVar6;
		  int iVar7;
		  int *piVar8;
		  int iVar9;
		  
		  iVar5 = 0;
		  if (DAT_ram_00a58249 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_AbstractCombatViewMediator_VortexCombatModel__VortexCombatEvents__VortexCombatController__VortexCombatView__HandleUserSkillsChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_VortexCombatModel__VortexCombatEvents__VortexCombatController__VortexCombatView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_ICollection_CombatPlayer__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_View_Players_ICombatPLayerView_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Sound_Control_IGameAudio_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IList_CombatPlayer__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_VortexCombat_Model_VortexCombatPlayer_TypeInfo);
		    DAT_ram_00a58249 = '\x01';
		  }
		  Gameplay_Combat_Control_AbstractCombatViewMediator_object__object__object__object___HandleUserBalanceChangedEvent
		            (param1,param2,
		             Method_Gameplay_Combat_Control_AbstractCombatViewMediator_VortexCombatModel__VortexCombatEvents__VortexCombatController__VortexCombatView__HandleUserSkillsChangedEvent__
		            );
		  iVar7 = *param2;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (System_Collections_Generic_ICollection_CombatPlayer__TypeInfo ==
		          *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar7 + *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80ebecb4;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,System_Collections_Generic_ICollection_CombatPlayer__TypeInfo
		                                ,0);
		code_r0x80ebecb4:
		  iVar7 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  if (0 < iVar7) {
		    do {
		      iVar9 = *param2;
		      if (*(ushort *)(iVar9 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          piVar3 = (int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8);
		          if (System_Collections_Generic_IList_CombatPlayer__TypeInfo == *piVar3) {
		            puVar2 = (uint *)(iVar9 + piVar3[1] * 8 + 0xc0);
		            goto code_r0x80ebed37;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar9 + 0xb6) != uVar1);
		      }
		      puVar2 = (uint *)func_ii_1080(param2,System_Collections_Generic_IList_CombatPlayer__TypeInfo,0
		                                   );
		code_r0x80ebed37:
		      piVar3 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(param2,iVar5,puVar2[1]);
		      if (piVar3 != (int *)0x0) {
		        if (((uint)*(byte *)(*piVar3 + 0xb8) <
		             (uint)*(byte *)(Gameplay_VortexCombat_Model_VortexCombatPlayer_TypeInfo + 0xb8)) ||
		           (*(int *)(*(int *)(*piVar3 + 100) +
		                     (uint)*(byte *)(Gameplay_VortexCombat_Model_VortexCombatPlayer_TypeInfo + 0xb8)
		                     * 4 + -4) != Gameplay_VortexCombat_Model_VortexCombatPlayer_TypeInfo)) {
		          System_Activator__CreateInstance
		                    (piVar3,Gameplay_VortexCombat_Model_VortexCombatPlayer_TypeInfo);
		          do {
		            halt_trap();
		          } while( true );
		        }
		      }
		      lVar6 = *(longlong *)(piVar3 + 0x1a);
		      piVar4 = (int *)(**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                                (param1,*(undefined4 *)(*param1 + 0x15c));
		      piVar4 = (int *)(**(code **)((ulonglong)*(uint *)(*piVar4 + 0x108) * 4))
		                                (piVar4,piVar3,*(undefined4 *)(*piVar4 + 0x10c));
		      if (lVar6 != 0) {
		        if (0 < *(longlong *)(piVar3 + 0x1a)) {
		          piVar3 = *(int **)(*(int *)(param1[2] + 0x3c) + 0x1c);
		          iVar9 = *piVar3;
		          if (*(ushort *)(iVar9 + 0xb6) != 0) {
		            uVar1 = 0;
		            do {
		              piVar8 = (int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8);
		              if (Gameplay_Sound_Control_IGameAudio_TypeInfo == *piVar8) {
		                puVar2 = (uint *)(piVar8[1] * 8 + iVar9 + 200);
		                goto code_r0x80ebee39;
		              }
		              uVar1 = uVar1 + 1;
		            } while (*(ushort *)(iVar9 + 0xb6) != uVar1);
		          }
		          puVar2 = (uint *)func_ii_1080(piVar3,Gameplay_Sound_Control_IGameAudio_TypeInfo,1);
		code_r0x80ebee39:
		          (**(code **)((ulonglong)*puVar2 * 4))(piVar3,0x15,puVar2[1]);
		        }
		        iVar9 = *piVar4;
		        if (*(ushort *)(iVar9 + 0xb6) != 0) {
		          uVar1 = 0;
		          do {
		            piVar3 = (int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8);
		            if (Gameplay_Combat_View_Players_ICombatPLayerView_TypeInfo == *piVar3) {
		              puVar2 = (uint *)(piVar3[1] * 8 + iVar9 + 200);
		              goto code_r0x80ebeeba;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar9 + 0xb6) != uVar1);
		        }
		        puVar2 = (uint *)func_ii_1080(piVar4,Gameplay_Combat_View_Players_ICombatPLayerView_TypeInfo
		                                      ,1);
		code_r0x80ebeeba:
		        (**(code **)((ulonglong)*puVar2 * 4))(piVar4,0x10,puVar2[1]);
		      }
		      iVar5 = iVar5 + 1;
		    } while (iVar5 != iVar7);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001655 RID: 5717 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001655")]
		[Address(RVA = "0x6816", Offset = "0x6816", VA = "0x6816", Slot = "27")]
		protected override void HandleUserSkillsChangedEvent(IList<CombatPlayer> players)
		{
		/* --- GHIDRA: HandleUserSkillsChangedEvent ---
		void Gameplay_VortexCombat_Control_VortexCombatViewMediator__HandleUserSkillsChangedEvent
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a5824a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_AbstractCombatViewMediator_VortexCombatModel__VortexCombatEvents__VortexCombatController__VortexCombatView__HandleResetView__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Events_UnityEvent_bool__RemoveListener__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_VortexCombat_Control_VortexCombatViewMediator_HandleClickShowHideSkillsNumbersButtonEvent__
		              );
		    DAT_ram_00a5824a = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_01 = *(undefined4 *)(*(int *)(iVar1 + 0x58) + 0xc0);
		  param1_00 = unnamed_function_1417(UnityEngine_Events_UnityAction_bool__TypeInfo);
		  UnityEngine_UI_Toggle__set_group
		            (param1_00,param1,
		             Method_Gameplay_VortexCombat_Control_VortexCombatViewMediator_HandleClickShowHideSkillsNumbersButtonEvent__
		             ,0);
		  UnityEngine_Events_UnityEvent_InputAction_CallbackContext___Invoke
		            (param1_01,param1_00,Method_UnityEngine_Events_UnityEvent_bool__RemoveListener__);
		  Gameplay_Combat_Control_AbstractCombatViewMediator_object__object__object__object___HandleRequestViewEvent
		            (param1,
		             Method_Gameplay_Combat_Control_AbstractCombatViewMediator_VortexCombatModel__VortexCombatEvents__VortexCombatController__VortexCombatView__HandleResetView__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06001656 RID: 5718 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001656")]
		[Address(RVA = "0x6817", Offset = "0x6817", VA = "0x6817", Slot = "32")]
		protected override void HandleResetView()
		{
		/* --- GHIDRA: HandleResetView ---
		void Gameplay_VortexCombat_Control_VortexCombatViewMediator__HandleResetView
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a5824b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_AbstractCombatViewMediator_VortexCombatModel__VortexCombatEvents__VortexCombatController__VortexCombatView__HandleSetupView__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_VortexCombatModel__VortexCombatEvents__VortexCombatController__VortexCombatView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Events_UnityEvent_bool__AddListener__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_VortexCombat_Control_VortexCombatViewMediator_HandleClickShowHideSkillsNumbersButtonEvent__
		              );
		    DAT_ram_00a5824b = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  func_ii_7603(*(undefined4 *)(iVar1 + 0x58),(uint)*(byte *)(param1[2] + 0x5c),0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_01 = *(undefined4 *)(*(int *)(iVar1 + 0x58) + 0xc0);
		  param1_00 = unnamed_function_1417(UnityEngine_Events_UnityAction_bool__TypeInfo);
		  UnityEngine_UI_Toggle__set_group
		            (param1_00,param1,
		             Method_Gameplay_VortexCombat_Control_VortexCombatViewMediator_HandleClickShowHideSkillsNumbersButtonEvent__
		             ,0);
		  UnityEngine_Events_UnityEvent_InputAction_CallbackContext____ctor
		            (param1_01,param1_00,Method_UnityEngine_Events_UnityEvent_bool__AddListener__);
		  Gameplay_Combat_Control_AbstractCombatViewMediator_object__object__object__object___HandleSelectedSpellChangedEvent
		            (param1,
		             Method_Gameplay_Combat_Control_AbstractCombatViewMediator_VortexCombatModel__VortexCombatEvents__VortexCombatController__VortexCombatView__HandleSetupView__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06001657 RID: 5719 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001657")]
		[Address(RVA = "0x6818", Offset = "0x6818", VA = "0x6818", Slot = "31")]
		protected override void HandleSetupView()
		{
		/* --- GHIDRA: HandleSetupView ---
		void Gameplay_VortexCombat_Control_VortexCombatViewMediator__HandleSetupView
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 param2_00;
		  undefined4 param2_01;
		  int iVar1;
		  int *piVar2;
		  
		  if (DAT_ram_00a5824c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_AbstractCombatViewMediator_VortexCombatModel__VortexCombatEvents__VortexCombatController__VortexCombatView__HandleSelectedSpell__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_VortexCombatModel__VortexCombatEvents__VortexCombatController__VortexCombatView__get_Model__
		              );
		    DAT_ram_00a5824c = '\x01';
		  }
		  piVar2 = *(int **)(param1 + 8);
		  param2_00 = (**(code **)((ulonglong)*(uint *)(*piVar2 + 0x148) * 4))
		                        (piVar2,*(undefined4 *)(piVar2[3] + 0x2c),*(undefined4 *)(*piVar2 + 0x14c));
		  piVar2 = *(int **)(param1 + 8);
		  param2_01 = (**(code **)((ulonglong)*(uint *)(*piVar2 + 0x150) * 4))
		                        (piVar2,*(undefined4 *)(piVar2[3] + 0x2c),*(undefined4 *)(*piVar2 + 0x154));
		  Gameplay_VortexCombat_Control_VortexCombatViewMediator__HandleSelectedSpell
		            (param1,param2_00,param1);
		  Gameplay_VortexCombat_Control_VortexCombatViewMediator__HandleSelectedSpell
		            (param1,param2_01,param1);
		  if ((param2 != 0) &&
		     (iVar1 = Gameplay_Combat_Model_CombatSpellData__get_IsFriendlyTarget(param2,0), iVar1 != 0)) {
		    iVar1 = Gameplay_Combat_Model_CombatSpellData__get_IsForceEffect(param2,0);
		    if (iVar1 == 0) {
		      param2_00 = param2_01;
		    }
		    Gameplay_VortexCombat_Control_VortexCombatViewMediator__StopListenPLayersClick
		              (param1,param2_00,param1);
		  }
		  Gameplay_Combat_Control_AbstractCombatViewMediator_object__object__object__object___HandleResetView
		            (param1,param2,
		             Method_Gameplay_Combat_Control_AbstractCombatViewMediator_VortexCombatModel__VortexCombatEvents__VortexCombatController__VortexCombatView__HandleSelectedSpell__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06001658 RID: 5720 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001658")]
		[Address(RVA = "0x6819", Offset = "0x6819", VA = "0x6819", Slot = "36")]
		protected override void HandleSelectedSpell(CombatSpellData spell)
		{
		/* --- GHIDRA: HandleSelectedSpell ---
		void Gameplay_VortexCombat_Control_VortexCombatViewMediator__HandleSelectedSpell
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  undefined4 *puVar3;
		  undefined4 param2_00;
		  undefined4 uVar4;
		  int *piVar5;
		  int iVar6;
		  int *piVar7;
		  int local_20;
		  undefined1 *puStack_1c;
		  undefined8 local_18;
		  undefined1 local_10 [8];
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5824d == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_PointerEventData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_CombatPlayer__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_CombatPlayer__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_CombatPlayer__get_Current__);
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_GameObject_GetComponent_MonoPointerClickHandler___);
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_View_Players_ICombatPLayerView_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_CombatPlayer__GetEnumerator__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_VortexCombat_Control_VortexCombatViewMediator_HandleClickOnPLayer__)
		    ;
		    DAT_ram_00a5824d = '\x01';
		  }
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_20,param2,Method_System_Collections_Generic_List_CombatPlayer__GetEnumerator__);
		  local_8 = local_18;
		  local_20 = 0;
		  puStack_1c = local_10;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar2 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,local_10,
		                       Method_System_Collections_Generic_List_Enumerator_CombatPlayer__MoveNext__);
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 == 1) {
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80ebf548;
		    }
		    if (iVar2 == 0) {
		      DAT_ram_009d3e38 = 0;
		      return;
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar4 = local_8._4_4_;
		    piVar5 = (int *)import::env::invoke_iii
		                              (*(undefined4 *)(*param1 + 0x158),param1,
		                               *(undefined4 *)(*param1 + 0x15c));
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 == 1) {
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80ebf548;
		    }
		    DAT_ram_009d3e38 = 0;
		    piVar5 = (int *)import::env::invoke_iiii
		                              (*(undefined4 *)(*piVar5 + 0x108),piVar5,uVar4,
		                               *(undefined4 *)(*piVar5 + 0x10c));
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 == 1) {
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80ebf548;
		    }
		    iVar6 = *piVar5;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar7 = (int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8);
		        if (Gameplay_Combat_View_Players_ICombatPLayerView_TypeInfo == *piVar7) {
		          puVar3 = (undefined4 *)(piVar7[1] * 8 + iVar6 + 0x120);
		          goto code_r0x80ebf314;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar3 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar5,
		                        Gameplay_Combat_View_Players_ICombatPLayerView_TypeInfo,0xc);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80ebf518:
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80ebf548;
		    }
		code_r0x80ebf314:
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii(*puVar3,piVar5,0,puVar3[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80ebf518;
		    iVar6 = *piVar5;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar7 = (int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8);
		        if (Gameplay_Combat_View_Players_ICombatPLayerView_TypeInfo == *piVar7) {
		          puVar3 = (undefined4 *)(piVar7[1] * 8 + iVar6 + 0x110);
		          goto code_r0x80ebf3e5;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar3 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar5,
		                        Gameplay_Combat_View_Players_ICombatPLayerView_TypeInfo,10);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80ebf522:
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80ebf548;
		    }
		code_r0x80ebf3e5:
		    DAT_ram_009d3e38 = 0;
		    uVar4 = import::env::invoke_iii(*puVar3,piVar5,puVar3[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80ebf522;
		    DAT_ram_009d3e38 = 0;
		    uVar4 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x202,uVar4,
		                       Method_UnityEngine_GameObject_GetComponent_MonoPointerClickHandler___);
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 == 1) {
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80ebf548;
		    }
		    DAT_ram_009d3e38 = 0;
		    param2_00 = import::env::invoke_ii
		                          (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                           System_Action_PointerEventData__TypeInfo);
		    if (DAT_ram_009d3e38 == 1) break;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viiii
		              (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x241,param2_00,param1,
		               Method_Gameplay_VortexCombat_Control_VortexCombatViewMediator_HandleClickOnPLayer__,0
		              );
		    if (DAT_ram_009d3e38 == 1) break;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x21,uVar4,param2_00,0);
		  } while (DAT_ram_009d3e38 != 1);
		  DAT_ram_009d3e38 = 0;
		  uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80ebf548:
		  iVar6 = global_1;
		  iVar2 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar6 == iVar2) {
		    piVar5 = (int *)import::env::__cxa_begin_catch(uVar4);
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
		    uVar4 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 300,&local_20);
		  iVar6 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar6 != 1) {
		    import::env::__resumeException(uVar4);
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

		// Token: 0x06001659 RID: 5721 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001659")]
		[Address(RVA = "0x681A", Offset = "0x681A", VA = "0x681A")]
		private void StopListenPLayersClick(List<CombatPlayer> players)
		{
		/* --- GHIDRA: StopListenPLayersClick ---
		void Gameplay_VortexCombat_Control_VortexCombatViewMediator__StopListenPLayersClick
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  undefined4 *puVar3;
		  undefined4 param2_00;
		  undefined4 uVar4;
		  int *piVar5;
		  int iVar6;
		  int *piVar7;
		  int local_20;
		  undefined1 *puStack_1c;
		  undefined8 local_18;
		  undefined1 local_10 [8];
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5824e == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_PointerEventData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_CombatPlayer__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_CombatPlayer__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_CombatPlayer__get_Current__);
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_GameObject_GetComponent_MonoPointerClickHandler___);
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_View_Players_ICombatPLayerView_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_CombatPlayer__GetEnumerator__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_VortexCombat_Control_VortexCombatViewMediator_HandleClickOnPLayer__)
		    ;
		    DAT_ram_00a5824e = '\x01';
		  }
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_20,param2,Method_System_Collections_Generic_List_CombatPlayer__GetEnumerator__);
		  local_8 = local_18;
		  local_20 = 0;
		  puStack_1c = local_10;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar2 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,local_10,
		                       Method_System_Collections_Generic_List_Enumerator_CombatPlayer__MoveNext__);
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 == 1) {
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80ebfa3a;
		    }
		    if (iVar2 == 0) {
		      DAT_ram_009d3e38 = 0;
		      return;
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar4 = local_8._4_4_;
		    piVar5 = (int *)import::env::invoke_iii
		                              (*(undefined4 *)(*param1 + 0x158),param1,
		                               *(undefined4 *)(*param1 + 0x15c));
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 == 1) {
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80ebfa3a;
		    }
		    DAT_ram_009d3e38 = 0;
		    piVar5 = (int *)import::env::invoke_iiii
		                              (*(undefined4 *)(*piVar5 + 0x108),piVar5,uVar4,
		                               *(undefined4 *)(*piVar5 + 0x10c));
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 == 1) {
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80ebfa3a;
		    }
		    iVar6 = *piVar5;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar7 = (int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8);
		        if (Gameplay_Combat_View_Players_ICombatPLayerView_TypeInfo == *piVar7) {
		          puVar3 = (undefined4 *)(piVar7[1] * 8 + iVar6 + 0x120);
		          goto code_r0x80ebf806;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar3 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar5,
		                        Gameplay_Combat_View_Players_ICombatPLayerView_TypeInfo,0xc);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80ebfa0a:
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80ebfa3a;
		    }
		code_r0x80ebf806:
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii(*puVar3,piVar5,1,puVar3[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80ebfa0a;
		    iVar6 = *piVar5;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar7 = (int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8);
		        if (Gameplay_Combat_View_Players_ICombatPLayerView_TypeInfo == *piVar7) {
		          puVar3 = (undefined4 *)(piVar7[1] * 8 + iVar6 + 0x110);
		          goto code_r0x80ebf8d7;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar3 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar5,
		                        Gameplay_Combat_View_Players_ICombatPLayerView_TypeInfo,10);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80ebfa14:
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80ebfa3a;
		    }
		code_r0x80ebf8d7:
		    DAT_ram_009d3e38 = 0;
		    uVar4 = import::env::invoke_iii(*puVar3,piVar5,puVar3[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80ebfa14;
		    DAT_ram_009d3e38 = 0;
		    uVar4 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x202,uVar4,
		                       Method_UnityEngine_GameObject_GetComponent_MonoPointerClickHandler___);
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 == 1) {
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80ebfa3a;
		    }
		    DAT_ram_009d3e38 = 0;
		    param2_00 = import::env::invoke_ii
		                          (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                           System_Action_PointerEventData__TypeInfo);
		    if (DAT_ram_009d3e38 == 1) break;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viiii
		              (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x241,param2_00,param1,
		               Method_Gameplay_VortexCombat_Control_VortexCombatViewMediator_HandleClickOnPLayer__,0
		              );
		    if (DAT_ram_009d3e38 == 1) break;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x26,uVar4,param2_00,0);
		  } while (DAT_ram_009d3e38 != 1);
		  DAT_ram_009d3e38 = 0;
		  uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80ebfa3a:
		  iVar6 = global_1;
		  iVar2 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar6 == iVar2) {
		    piVar5 = (int *)import::env::__cxa_begin_catch(uVar4);
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
		    uVar4 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x12d,&local_20);
		  iVar6 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar6 != 1) {
		    import::env::__resumeException(uVar4);
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

		// Token: 0x0600165A RID: 5722 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600165A")]
		[Address(RVA = "0x681B", Offset = "0x681B", VA = "0x681B")]
		private void StartListenPlayersClick(List<CombatPlayer> players)
		{
		/* --- GHIDRA: StartListenPlayersClick ---
		void Gameplay_VortexCombat_Control_VortexCombatViewMediator__StartListenPlayersClick
		               (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int *piVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  int param1_00;
		  int iVar5;
		  undefined4 param2_00;
		  int iVar6;
		  
		  if (DAT_ram_00a5824f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_VortexCombatModel__VortexCombatEvents__VortexCombatController__VortexCombatView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_CombatController_VortexCombatModel__VortexCombatEvents__SpellCalled__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_Model_CombatPlayer___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_GameObject_GetComponent_ICombatPLayerView___);
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_View_Players_ICombatPLayerView_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_Model_SpellTarget_TypeInfo);
		    DAT_ram_00a5824f = '\x01';
		  }
		  piVar2 = (int *)func_ii_6601(*(undefined4 *)(param2 + 0x24),
		                               Method_UnityEngine_GameObject_GetComponent_ICombatPLayerView___);
		  iVar6 = *piVar2;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Gameplay_Combat_View_Players_ICombatPLayerView_TypeInfo ==
		          *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x100);
		        goto code_r0x80ebfbaf;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar2,Gameplay_Combat_View_Players_ICombatPLayerView_TypeInfo,8);
		code_r0x80ebfbaf:
		  iVar6 = (**(code **)((ulonglong)*puVar3 * 4))(piVar2,puVar3[1]);
		  uVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x14c));
		  param2_00 = *(undefined4 *)(param1[2] + 0x28);
		  param1_00 = unnamed_function_1417(Gameplay_Combat_Model_SpellTarget_TypeInfo);
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(param1_00,param2_00,0);
		  piVar2 = (int *)Mono_Security_ASN1Convert__ToOid(Gameplay_Combat_Model_CombatPlayer___TypeInfo,1);
		  if ((iVar6 != 0) && (iVar5 = func_ii_1082(iVar6,*(undefined4 *)(*piVar2 + 0x20)), iVar5 == 0)) {
		    uVar4 = func_ii_1083();
		    func_ii_1050(uVar4,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar2[4] = iVar6;
		  *(int **)(param1_00 + 0xc) = piVar2;
		  Gameplay_Combat_Control_CombatController_object__object___SetSkillsChanges
		            (uVar4,param1_00,
		             Method_Gameplay_Combat_Control_CombatController_VortexCombatModel__VortexCombatEvents__SpellCalled__
		            );
		  return;
		}
		*/

		}

		// Token: 0x0600165B RID: 5723 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600165B")]
		[Address(RVA = "0x681C", Offset = "0x681C", VA = "0x681C")]
		private void HandleClickOnPLayer(PointerEventData data)
		{
		/* --- GHIDRA: HandleClickOnPLayer ---
		void Gameplay_VortexCombat_Control_VortexCombatViewMediator__HandleClickOnPLayer
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  undefined4 *puVar4;
		  int *piVar5;
		  int iVar6;
		  int *piVar7;
		  int local_20;
		  undefined1 *puStack_1c;
		  undefined8 local_18;
		  undefined1 local_10 [8];
		  undefined8 local_8;
		  
		  if (DAT_ram_00a58250 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_VortexCombatModel__VortexCombatEvents__VortexCombatController__VortexCombatView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_ulong__CombatPlayer__get_Values__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_ulong__CombatPlayer__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_ulong__CombatPlayer__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_ulong__CombatPlayer__get_Current__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_View_Players_ICombatPLayerView_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_ulong__CombatPlayer__GetEnumerator__
		              );
		    DAT_ram_00a58250 = '\x01';
		  }
		  uVar2 = System_Collections_Generic_Dictionary_int__object___TryAdd
		                    (*(undefined4 *)(param1[2] + 0x1c),
		                     Method_System_Collections_Generic_Dictionary_ulong__CombatPlayer__get_Values__)
		  ;
		  System_Collections_Generic_Dictionary_Int32Enum__object___get_Values
		            (&local_20,uVar2,
		             Method_System_Collections_Generic_Dictionary_ValueCollection_ulong__CombatPlayer__GetEnumerator__
		            );
		  local_8 = local_18;
		  local_20 = 0;
		  puStack_1c = local_10;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar3 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x2e2,local_10,
		                       Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_ulong__CombatPlayer__MoveNext__
		                      );
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80ec0082;
		    }
		    if (iVar3 == 0) {
		      DAT_ram_009d3e38 = 0;
		      return;
		    }
		    iVar3 = local_8._4_4_;
		    *(undefined1 *)(local_8._4_4_ + 0x50) = (undefined1)param2;
		    DAT_ram_009d3e38 = 0;
		    piVar5 = (int *)import::env::invoke_iii
		                              (*(undefined4 *)(*param1 + 0x158),param1,
		                               *(undefined4 *)(*param1 + 0x15c));
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80ec0082;
		    }
		    DAT_ram_009d3e38 = 0;
		    piVar5 = (int *)import::env::invoke_iiii
		                              (*(undefined4 *)(*piVar5 + 0x108),piVar5,iVar3,
		                               *(undefined4 *)(*piVar5 + 0x10c));
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80ec0082;
		    }
		    iVar6 = *piVar5;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar7 = (int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8);
		        if (Gameplay_Combat_View_Players_ICombatPLayerView_TypeInfo == *piVar7) {
		          puVar4 = (undefined4 *)(piVar7[1] * 8 + iVar6 + 200);
		          goto code_r0x80ebfe63;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar4 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar5,
		                        Gameplay_Combat_View_Players_ICombatPLayerView_TypeInfo,1);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80ec0066:
		      DAT_ram_009d3e38 = 0;
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80ec0082;
		    }
		code_r0x80ebfe63:
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii(*puVar4,piVar5,3,puVar4[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80ec0066;
		    iVar6 = *piVar5;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar7 = (int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8);
		        if (Gameplay_Combat_View_Players_ICombatPLayerView_TypeInfo == *piVar7) {
		          puVar4 = (undefined4 *)(piVar7[1] * 8 + iVar6 + 200);
		          goto code_r0x80ebff34;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar4 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar5,
		                        Gameplay_Combat_View_Players_ICombatPLayerView_TypeInfo,1);
		    if (DAT_ram_009d3e38 == 1) break;
		code_r0x80ebff34:
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii(*puVar4,piVar5,4,puVar4[1]);
		    if (DAT_ram_009d3e38 == 1) break;
		    iVar6 = *piVar5;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar7 = (int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8);
		        if (Gameplay_Combat_View_Players_ICombatPLayerView_TypeInfo == *piVar7) {
		          puVar4 = (undefined4 *)(piVar7[1] * 8 + iVar6 + 200);
		          goto code_r0x80ec0005;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar4 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar5,
		                        Gameplay_Combat_View_Players_ICombatPLayerView_TypeInfo,1);
		    if (DAT_ram_009d3e38 == 1) break;
		code_r0x80ec0005:
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii(*puVar4,piVar5,0x10,puVar4[1]);
		  } while (DAT_ram_009d3e38 != 1);
		  DAT_ram_009d3e38 = 0;
		  uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80ec0082:
		  iVar6 = global_1;
		  iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar6 == iVar3) {
		    piVar5 = (int *)import::env::__cxa_begin_catch(uVar2);
		    iVar3 = *piVar5;
		    DAT_ram_009d3e38 = 0;
		    local_20 = iVar3;
		    import::env::invoke_v(0x123);
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 != 1) {
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
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x12e,&local_20);
		  iVar6 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar6 != 1) {
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

		// Token: 0x0600165C RID: 5724 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600165C")]
		[Address(RVA = "0x681D", Offset = "0x681D", VA = "0x681D")]
		private void HandleClickShowHideSkillsNumbersButtonEvent(bool value)
		{
		/* --- GHIDRA: HandleClickShowHideSkillsNumbersButtonEvent ---
		undefined4
		Gameplay_VortexCombat_Control_VortexCombatViewMediator__HandleClickShowHideSkillsNumbersButtonEvent
		          (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  undefined4 local_8;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a58251 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_AbstractCombatViewMediator_VortexCombatModel__VortexCombatEvents__VortexCombatController__VortexCombatView__ShowAwaitCombatWindow__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_VortexCombatModel__VortexCombatEvents__VortexCombatController__VortexCombatView__get_Model__
		              );
		    DAT_ram_00a58251 = '\x01';
		  }
		  local_4 = 0;
		  local_8 = 0;
		  param1_00 = Gameplay_Combat_Control_AbstractCombatViewMediator_object__object__object__object___RunShowCombatViewProcess
		                        (param1,param2,
		                         Method_Gameplay_Combat_Control_AbstractCombatViewMediator_VortexCombatModel__VortexCombatEvents__VortexCombatController__VortexCombatView__ShowAwaitCombatWindow__
		                        );
		  iVar1 = **(int **)(param1 + 8);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x168) * 4))
		            (*(int **)(param1 + 8),&local_4,&local_8,*(undefined4 *)(iVar1 + 0x16c));
		  Gameplay_Combat_View_CombatWaitingWindowMono__HideWaitingWindow(param1_00,local_4,0);
		  Core_Extensions_StringExt__Replacer(param1_00,local_8,0);
		  return param1_00;
		}
		*/

		}

		// Token: 0x0600165D RID: 5725 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600165D")]
		[Address(RVA = "0x681E", Offset = "0x681E", VA = "0x681E", Slot = "33")]
		protected override CombatWaitingWindowMono ShowAwaitCombatWindow(BackTime backTime)
		{
		/* --- GHIDRA: ShowAwaitCombatWindow ---
		void Gameplay_VortexCombat_Control_VortexCombatViewMediator__ShowAwaitCombatWindow
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 param1_00;
		  
		  iVar1 = 0;
		  if (DAT_ram_00a58252 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_AbstractCombatViewMediator_VortexCombatModel__VortexCombatEvents__VortexCombatController__VortexCombatView__HandleGameOver__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_VortexCombatPlayer__get_DestroyInstantElements__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_VortexCombatPlayer__get_HideInstantElements__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a58252 = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = *(int *)(iVar2 + 0x3c);
		  if (0 < *(int *)(iVar2 + 0xc)) {
		    do {
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (*(undefined4 *)(iVar2 + iVar1 * 4 + 0x10),0,0);
		      iVar1 = iVar1 + 1;
		    } while (iVar1 < *(int *)(iVar2 + 0xc));
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar1 = *(int *)(iVar1 + 0x40);
		  if (0 < *(int *)(iVar1 + 0xc)) {
		    iVar2 = 0;
		    do {
		      param1_00 = *(undefined4 *)(iVar1 + iVar2 * 4 + 0x10);
		      if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		        func_ii_306000(UnityEngine_Object_TypeInfo);
		      }
		      UnityEngine_Application__get_isPlaying(param1_00,0);
		      iVar2 = iVar2 + 1;
		    } while (iVar2 < *(int *)(iVar1 + 0xc));
		  }
		  Gameplay_Combat_Control_AbstractCombatViewMediator_object__object__object__object___HandleFinishAwaitCombatEvent
		            (param1,
		             Method_Gameplay_Combat_Control_AbstractCombatViewMediator_VortexCombatModel__VortexCombatEvents__VortexCombatController__VortexCombatView__HandleGameOver__
		            );
		  return;
		}
		*/

			return null;
		}

		// Token: 0x0600165E RID: 5726 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600165E")]
		[Address(RVA = "0x681F", Offset = "0x681F", VA = "0x681F", Slot = "37")]
		protected override void HandleGameOver()
		{
		/* --- GHIDRA: HandleGameOver ---
		int Gameplay_VortexCombat_Control_VortexCombatViewMediator__HandleGameOver
		              (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  int iVar5;
		  int param3_00;
		  
		  if (DAT_ram_00a58253 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_AbstractCombatViewMediator_VortexCombatModel__VortexCombatEvents__VortexCombatController__VortexCombatView__HandleGameOverWindowCloseRequestEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_VortexCombatModel__VortexCombatEvents__VortexCombatController__VortexCombatViewMediator__VortexCombatView__Stop__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_VortexCombatModel__VortexCombatEvents__VortexCombatController__VortexCombatViewMediator__VortexCombatView__TryRun__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_VortexCombatModel__VortexCombatEvents__VortexCombatController__VortexCombatView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_VortexCombat_VortexCombat_TypeInfo);
		    DAT_ram_00a58253 = '\x01';
		  }
		  piVar4 = *(int **)(param1 + 8);
		  iVar5 = piVar4[0x14];
		  param3_00 = piVar4[2];
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*piVar4 + 0x120) * 4))
		                    (piVar4,*(undefined4 *)(*piVar4 + 0x124));
		  iVar2 = Gameplay_Combat_Control_AbstractCombatViewMediator_object__object__object__object___HandleGameOver
		                    (param1,param2,
		                     Method_Gameplay_Combat_Control_AbstractCombatViewMediator_VortexCombatModel__VortexCombatEvents__VortexCombatController__VortexCombatView__HandleGameOverWindowCloseRequestEvent__
		                    );
		  if (iVar2 == 0) {
		    uVar3 = UI_Windows_PopupController__get_OpenedWindowsCount(0);
		    DefaultNamespace_SceneAppManager__RemoveScene(uVar3,iVar5,0);
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    uVar3 = **(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    piVar4 = (int *)unnamed_function_1417(Gameplay_VortexCombat_VortexCombat_TypeInfo);
		    Gameplay_VortexCombat_VortexCombat__CheckRunRestrictions(piVar4,uVar3,param3_00,param3_00,0,0);
		    iVar5 = Gameplay_Combat_AbstractCombat_object__object__object__object__object___TryRun
		                      (piVar4,uVar1,
		                       Method_Gameplay_Combat_AbstractCombat_VortexCombatModel__VortexCombatEvents__VortexCombatController__VortexCombatViewMediator__VortexCombatView__TryRun__
		                      );
		    if (iVar5 != 0) {
		      uVar1 = System_Uri___ctor(0);
		      uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar1,0);
		      UI_Windows_PopupController__Close(uVar1,0,0);
		      return 0;
		    }
		    Gameplay_Combat_AbstractCombat_object__object__object__object__object___SetView
		              (piVar4,
		               Method_Gameplay_Combat_AbstractCombat_VortexCombatModel__VortexCombatEvents__VortexCombatController__VortexCombatViewMediator__VortexCombatView__Stop__
		              );
		    (**(code **)((ulonglong)*(uint *)(*piVar4 + 0x118) * 4))
		              (piVar4,*(undefined4 *)(*piVar4 + 0x11c));
		  }
		  return iVar2;
		}
		*/

		}

		// Token: 0x0600165F RID: 5727 RVA: 0x00005460 File Offset: 0x00003660
		[Token(Token = "0x600165F")]
		[Address(RVA = "0x6820", Offset = "0x6820", VA = "0x6820", Slot = "21")]
		protected override bool HandleGameOverWindowNextCombatRequestEvent(CombatGameOverView gameOverView)
		{
		/* --- GHIDRA: HandleGameOverWindowNextCombatRequestEvent ---
		int Gameplay_VortexCombat_Control_VortexCombatViewMediator__HandleGameOverWindowNextCombatRequestEvent
		              (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a58254 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_AbstractCombatViewMediator_VortexCombatModel__VortexCombatEvents__VortexCombatController__VortexCombatView__HandleGameOverWindowCloseRequestEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_VortexCombatModel__VortexCombatEvents__VortexCombatController__VortexCombatView__get_Model__
		              );
		    DAT_ram_00a58254 = '\x01';
		  }
		  param2_00 = *(undefined4 *)(*(int *)(param1 + 8) + 0x50);
		  iVar1 = Gameplay_Combat_Control_AbstractCombatViewMediator_object__object__object__object___HandleGameOver
		                    (param1,param2,
		                     Method_Gameplay_Combat_Control_AbstractCombatViewMediator_VortexCombatModel__VortexCombatEvents__VortexCombatController__VortexCombatView__HandleGameOverWindowCloseRequestEvent__
		                    );
		  if (iVar1 == 0) {
		    param1_00 = UI_Windows_PopupController__get_OpenedWindowsCount(0);
		    DefaultNamespace_SceneAppManager__RemoveScene(param1_00,param2_00,0);
		  }
		  return iVar1;
		}
		*/

			return default(bool);
		}

		// Token: 0x06001660 RID: 5728 RVA: 0x00005478 File Offset: 0x00003678
		[Token(Token = "0x6001660")]
		[Address(RVA = "0x6821", Offset = "0x6821", VA = "0x6821", Slot = "22")]
		protected override bool HandleGameOverWindowCloseRequestEvent(CombatGameOverView view)
		{
		/* --- GHIDRA: HandleGameOverWindowCloseRequestEvent ---
		void Gameplay_VortexCombat_Control_VortexCombatViewMediator__HandleGameOverWindowCloseRequestEvent
		               (int *param1,undefined4 param2,int param3,int param4,undefined4 param5)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 param1_00;
		  int param2_00;
		  int *param2_01;
		  int iVar4;
		  int iVar5;
		  int *piVar6;
		  uint uVar7;
		  ulonglong local_8;
		  
		  if (DAT_ram_00a58255 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_AbstractCombatViewMediator_VortexCombatModel__VortexCombatEvents__VortexCombatController__VortexCombatView__HandleSpellAppliedEvent__
		              );
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_CombatPlayer__get_Count__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_CombatPlayer__get_Item__);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_int__GetValueOrDefault__);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_int___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_int__get_HasValue__);
		    Mono_Security_ASN1__get_Item(&System_Nullable_int__TypeInfo);
		    Mono_Security_ASN1__get_Item(&object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_VortexCombat_View_Player_VortexCombatPlayerView_TypeInfo)
		    ;
		    Mono_Security_ASN1__get_Item(&StringLiteral_3116);
		    DAT_ram_00a58255 = '\x01';
		  }
		  Gameplay_Combat_Control_AbstractCombatViewMediator_object__object__object__object___HandleSetupView
		            (param1,param2,param3,param4,
		             Method_Gameplay_Combat_Control_AbstractCombatViewMediator_VortexCombatModel__VortexCombatEvents__VortexCombatController__VortexCombatView__HandleSpellAppliedEvent__
		            );
		  uVar1 = Core_Extensions_Dict_SpellDicExt__GetAnimationCanvasAssetId
		                    (*(undefined4 *)(param3 + 0xc),0);
		  iVar2 = Newtonsoft_Json_Serialization_JsonSerializerInternalReader__ShouldDeserialize(uVar1,0);
		  if (iVar2 == 0) {
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    piVar6 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar2 = *piVar6;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      uVar7 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar7 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar7 * 8 + 4) * 8 + iVar2 + 0x178);
		          goto code_r0x80ec0599;
		        }
		        uVar7 = uVar7 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar7);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80ec0599:
		    iVar2 = 0;
		    param1_00 = (**(code **)((ulonglong)*puVar3 * 4))(piVar6,puVar3[1]);
		    param2_00 = Core_Extensions_Dict_GameFieldGemSetsDicExt__GetGemsSpriteAtlasAssetId
		                          (param1_00,uVar1,0);
		    if (param4 != 0) {
		      local_8 = 0;
		      System_Data_SqlTypes_SqlInt32___ctor
		                (&local_8,*(undefined4 *)(param4 + 0xc),Method_System_Nullable_int___ctor__);
		      if (((local_8 & 0xff) != 0) && (0 < (int)(local_8 >> 0x20))) {
		        do {
		          piVar6 = (int *)(**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                                    (param1,*(undefined4 *)(*param1 + 0x15c));
		          uVar1 = System_Linq_Enumerable__ToList_object_
		                            (param4,iVar2,
		                             Method_System_Collections_Generic_List_CombatPlayer__get_Item__);
		          piVar6 = (int *)(**(code **)((ulonglong)*(uint *)(*piVar6 + 0x108) * 4))
		                                    (piVar6,uVar1,*(undefined4 *)(*piVar6 + 0x10c));
		          if (*(int *)(*(int *)(*piVar6 + 100) +
		                       (uint)*(byte *)(
		                                      Gameplay_VortexCombat_View_Player_VortexCombatPlayerView_TypeInfo
		                                      + 0xb8) * 4 + -4) !=
		              Gameplay_VortexCombat_View_Player_VortexCombatPlayerView_TypeInfo) {
		            piVar6 = (int *)0x0;
		          }
		          Gameplay_Combat_View_Animations_CombatAnimation__Load(piVar6[0x12],param2_00,0,0);
		          param2_01 = (int *)Mono_Security_ASN1Convert__ToOid(object___TypeInfo,4);
		          local_8 = CONCAT44(local_8._4_4_,*(undefined4 *)(*(int *)(param3 + 0xc) + 0xc));
		          iVar4 = func_ii_1081(DAT_ram_00a66958,&local_8);
		          if ((iVar4 != 0) &&
		             (iVar5 = func_ii_1082(iVar4,*(undefined4 *)(*param2_01 + 0x20)), iVar5 == 0)) {
		            uVar1 = func_ii_1083();
		            func_ii_1050(uVar1,0);
		            do {
		              halt_trap();
		            } while( true );
		          }
		          param2_01[4] = iVar4;
		          if ((param2_00 != 0) &&
		             (iVar4 = func_ii_1082(param2_00,*(undefined4 *)(*param2_01 + 0x20)), iVar4 == 0)) {
		            uVar1 = func_ii_1083();
		            func_ii_1050(uVar1,0);
		            do {
		              halt_trap();
		            } while( true );
		          }
		          param2_01[5] = param2_00;
		          uVar1 = StringLiteral_3116;
		          local_8 = 0;
		          System_Data_SqlTypes_SqlInt32___ctor
		                    (&local_8,*(undefined4 *)(param4 + 0xc),Method_System_Nullable_int___ctor__);
		          iVar4 = func_ii_1081(System_Nullable_int__TypeInfo,&local_8);
		          if ((iVar4 != 0) &&
		             (iVar5 = func_ii_1082(iVar4,*(undefined4 *)(*param2_01 + 0x20)), iVar5 == 0)) {
		            uVar1 = func_ii_1083();
		            func_ii_1050(uVar1,0);
		            do {
		              halt_trap();
		            } while( true );
		          }
		          param2_01[6] = iVar4;
		          iVar4 = GAFInternal_Assets_GAFAnimationAssetInternal__collectExternalData(piVar6,0);
		          if ((iVar4 != 0) &&
		             (iVar5 = func_ii_1082(iVar4,*(undefined4 *)(*param2_01 + 0x20)), iVar5 == 0)) {
		            uVar1 = func_ii_1083();
		            func_ii_1050(uVar1,0);
		            do {
		              halt_trap();
		            } while( true );
		          }
		          param2_01[7] = iVar4;
		          uVar1 = UnityEngine_InputSystem_Utilities_TypeHelpers__GetNiceTypeName(uVar1,param2_01,0);
		          if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		            func_ii_306000(OKG_Logs_Debug_TypeInfo);
		          }
		          System_Collections_Generic_Dictionary_uint__object___get_Count(uVar1,0);
		          local_8 = 0;
		          System_Data_SqlTypes_SqlInt32___ctor
		                    (&local_8,*(undefined4 *)(param4 + 0xc),Method_System_Nullable_int___ctor__);
		        } while (((local_8 & 0xff) != 0) && (iVar2 = iVar2 + 1, iVar2 < (int)(local_8 >> 0x20)));
		      }
		    }
		  }
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x06001661 RID: 5729 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001661")]
		[Address(RVA = "0x6822", Offset = "0x6822", VA = "0x6822", Slot = "25")]
		protected override void HandleSpellAppliedEvent(CombatPlayer owner, CombatSpellData spell, List<CombatPlayer> targetPlayers)
		{
		/* --- GHIDRA: HandleSpellAppliedEvent ---
		void Gameplay_VortexCombat_Control_VortexCombatViewMediator__HandleSpellAppliedEvent
		               (int param1,int param2,undefined4 param3)
		
		{
		  int param1_00;
		  undefined4 uVar1;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a58256 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_AbstractCombatViewMediator_VortexCombatModel__VortexCombatEvents__VortexCombatController__VortexCombatView__HandleTerminate__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_VortexCombatModel__VortexCombatEvents__VortexCombatController__VortexCombatView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&UI_Windows_Alert_AlertArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_17532);
		    DAT_ram_00a58256 = '\x01';
		  }
		  if (param2 == 2) {
		    param1_00 = unnamed_function_1417(UI_Windows_Alert_AlertArgs_TypeInfo);
		    UI_Windows_Alert__Show(param1_00,0);
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar1 = func_ii_7508(StringLiteral_17532,1,0,1,0,0,0,0);
		    *(undefined4 *)(param1_00 + 0x1c) = uVar1;
		    UI_Windows_UnityInstantiator___ctor(param1_00,0);
		  }
		  else {
		    Gameplay_Combat_Control_AbstractCombatViewMediator_object__object__object__object___HandleSwitchTurnEvent
		              (param1,param2,
		               Method_Gameplay_Combat_Control_AbstractCombatViewMediator_VortexCombatModel__VortexCombatEvents__VortexCombatController__VortexCombatView__HandleTerminate__
		              );
		  }
		  param2_00 = *(undefined4 *)(*(int *)(param1 + 8) + 0x50);
		  uVar1 = UI_Windows_PopupController__get_OpenedWindowsCount(0);
		  DefaultNamespace_SceneAppManager__RemoveScene(uVar1,param2_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06001662 RID: 5730 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001662")]
		[Address(RVA = "0x6823", Offset = "0x6823", VA = "0x6823", Slot = "28")]
		protected override void HandleTerminate(TerminateReason reason)
		{
		/* --- GHIDRA: HandleTerminate ---
		int Gameplay_VortexCombat_Control_VortexCombatViewMediator__HandleTerminate
		              (int *param1,undefined4 param2)
		
		{
		  int param1_00;
		  int iVar1;
		  
		  if (DAT_ram_00a58257 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_ClanIsleEvents__ClanIsleModel__ClanIsleController__ClanBuildingTypes__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Method_UI_ToolTip_ToolTipData_ClanData___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_UI_ToolTip_ToolTipData_ClanData__set_Data__);
		    Mono_Security_ASN1__get_Item(&UI_ToolTip_ToolTipData_ClanData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12530);
		    DAT_ram_00a58257 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(UI_ToolTip_ToolTipData_ClanData__TypeInfo);
		  System_Buffers_TlsOverPerCoreLockedStacksArrayPool___Il2CppFullySharedGenericType___get_Id
		            (param1_00,StringLiteral_12530,Method_UI_ToolTip_ToolTipData_ClanData___ctor__);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x134));
		  *(undefined4 *)(param1_00 + 0x1c) = *(undefined4 *)(*(int *)(iVar1 + 0x10) + 0x30);
		  return param1_00;
		}
		*/

		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Events ---
		void Gameplay_VortexCombat_Control_VortexCombatViewMediator__set_Events
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  int *param2_00;
		  undefined4 uVar2;
		  int iVar3;
		  int *piVar4;
		  undefined1 auStack_20 [8];
		  int local_18;
		  undefined8 *local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a58247 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_VortexCombatModel__VortexCombatEvents__VortexCombatController__VortexCombatView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_ulong__CombatPlayer__get_Values__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_ulong__CombatPlayer__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_ulong__CombatPlayer__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_ulong__CombatPlayer__get_Current__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_ulong__CombatPlayer__GetEnumerator__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_VortexCombat_View_Player_VortexCombatPlayerView_TypeInfo)
		    ;
		    DAT_ram_00a58247 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  uVar2 = System_Collections_Generic_Dictionary_int__object___TryAdd
		                    (*(undefined4 *)(param1[2] + 0x1c),
		                     Method_System_Collections_Generic_Dictionary_ulong__CombatPlayer__get_Values__)
		  ;
		  System_Collections_Generic_Dictionary_Int32Enum__object___get_Values
		            (&local_10,uVar2,
		             Method_System_Collections_Generic_Dictionary_ValueCollection_ulong__CombatPlayer__GetEnumerator__
		            );
		  local_18 = 0;
		  local_14 = &local_10;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar3 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x2e2,&local_10,
		                       Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_ulong__CombatPlayer__MoveNext__
		                      );
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80ebe4f9;
		    }
		    if (iVar3 == 0) {
		      DAT_ram_009d3e38 = 0;
		      return;
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar2 = local_8._4_4_;
		    piVar4 = (int *)import::env::invoke_iii
		                              (*(undefined4 *)(*param1 + 0x158),param1,
		                               *(undefined4 *)(*param1 + 0x15c));
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80ebe4f9;
		    }
		    DAT_ram_009d3e38 = 0;
		    piVar4 = (int *)import::env::invoke_iiii
		                              (*(undefined4 *)(*piVar4 + 0x108),piVar4,uVar2,
		                               *(undefined4 *)(*piVar4 + 0x10c));
		    if (DAT_ram_009d3e38 == 1) break;
		    param2_00 = (int *)0x0;
		    if (piVar4 != (int *)0x0) {
		      if (((uint)*(byte *)(Gameplay_VortexCombat_View_Player_VortexCombatPlayerView_TypeInfo + 0xb8)
		           <= (uint)*(byte *)(*piVar4 + 0xb8)) &&
		         (param2_00 = piVar4,
		         *(int *)(*(int *)(*piVar4 + 100) +
		                  (uint)*(byte *)(Gameplay_VortexCombat_View_Player_VortexCombatPlayerView_TypeInfo
		                                 + 0xb8) * 4 + -4) !=
		         Gameplay_VortexCombat_View_Player_VortexCombatPlayerView_TypeInfo)) {
		        param2_00 = (int *)0x0;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_vii
		              (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x128,param2_00,auStack_20);
		  } while (DAT_ram_009d3e38 != 1);
		  DAT_ram_009d3e38 = 0;
		  uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80ebe4f9:
		  iVar1 = global_1;
		  iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar1 == iVar3) {
		    piVar4 = (int *)import::env::__cxa_begin_catch(uVar2);
		    iVar3 = *piVar4;
		    DAT_ram_009d3e38 = 0;
		    local_18 = iVar3;
		    import::env::invoke_v(0x123);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 != 1) {
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
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x129,&local_18);
		  iVar1 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar1 != 1) {
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
