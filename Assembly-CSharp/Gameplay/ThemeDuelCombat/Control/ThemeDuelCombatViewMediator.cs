using System;
using Gameplay.Combat.Control;
using Gameplay.Combat.View;
using Gameplay.ThemeDuelCombat.Model;
using Gameplay.ThemeDuelCombat.View;
using Il2CppDummyDll;
using Protocol.Combat;
using Utils;

namespace Gameplay.ThemeDuelCombat.Control
{
	// Token: 0x020004DA RID: 1242
	[Token(Token = "0x20004DA")]
	public class ThemeDuelCombatViewMediator : AbstractOneOnOneCombatViewMediator<ThemeDuelCombatModel, ThemeDuelCombatEvents, ThemeDuelCombatController, ThemeDuelCombatView>
	{
		// Token: 0x06001D95 RID: 7573 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D95")]
		[Address(RVA = "0x6F14", Offset = "0x6F14", VA = "0x6F14")]
		public ThemeDuelCombatViewMediator(ThemeDuelCombatModel model, ThemeDuelCombatEvents events, ThemeDuelCombatController controller)
		{
		/* --- GHIDRA: <HandleGameOver>b__1_0 ---
		undefined4
		Gameplay_ThemeDuelCombat_Control_ThemeDuelCombatViewMediator___HandleGameOver_b__1_0
		          (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a585bc == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_12672);
		    DAT_ram_00a585bc = '\x01';
		  }
		  return StringLiteral_12672;
		}
		*/

		/* --- GHIDRA: .ctor ---
		void Gameplay_ThemeDuelCombat_Control_ThemeDuelCombatViewMediator___ctor
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  int *piVar2;
		  undefined4 uVar3;
		  int iVar4;
		  float fVar5;
		  undefined4 uVar6;
		  
		  iVar4 = 0;
		  if (DAT_ram_00a585b0 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ThemeDuelCombatModel__ThemeDuelCombatEvents__ThemeDuelCombatController__ThemeDuelCombatView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_CombatGameOverView__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_ThemeDuelCombat_Control_ThemeDuelCombatViewMediator__HandleGameOver_b__1_0__
		              );
		    DAT_ram_00a585b0 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Combat_View_PlayerChatBubble__AddText(*(undefined4 *)(iVar1 + 100),0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Combat_View_PlayerChatBubble__AddText(*(undefined4 *)(iVar1 + 0x68),0);
		  piVar2 = (int *)(**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                            (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar1 = param1[2];
		  uVar6 = *(undefined4 *)(iVar1 + 0x10);
		  uVar3 = unnamed_function_1417(System_Action_CombatGameOverView__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar3,param1,
		             Method_Gameplay_ThemeDuelCombat_Control_ThemeDuelCombatViewMediator__HandleGameOver_b__1_0__
		             ,0);
		  (**(code **)((ulonglong)*(uint *)(*piVar2 + 0x118) * 4))
		            (piVar2,iVar1,uVar6,uVar3,*(undefined4 *)(*piVar2 + 0x11c));
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar1 = *(int *)(iVar1 + 0x78);
		  if (0 < *(int *)(iVar1 + 0xc)) {
		    do {
		      uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(iVar1 + iVar4 * 4 + 0x10),0);
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (uVar3,0,0);
		      iVar4 = iVar4 + 1;
		    } while (iVar4 < *(int *)(iVar1 + 0xc));
		  }
		  iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(*(int *)(iVar4 + 0x28) + 0x20),0);
		  fVar5 = func_ii_7103(*(undefined4 *)(*(int *)(param1[2] + 0x6c) + 0x30),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar3,(uint)(0.0 < fVar5),0);
		  return;
		}
		*/

		}

		// Token: 0x06001D96 RID: 7574 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D96")]
		[Address(RVA = "0x6F15", Offset = "0x6F15", VA = "0x6F15", Slot = "37")]
		protected override void HandleGameOver()
		{
		/* --- GHIDRA: HandleGameOver ---
		void Gameplay_ThemeDuelCombat_Control_ThemeDuelCombatViewMediator__HandleGameOver
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a585b1 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_AbstractOneOnOneCombatViewMediator_ThemeDuelCombatModel__ThemeDuelCombatEvents__ThemeDuelCombatController__ThemeDuelCombatView__AddGameProcessEventsHandlers__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoThemeScoreChangedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_ThemeDuelCombat_Control_ThemeDuelCombatViewMediator_HandleRunNextCombatAvailEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_ThemeDuelCombat_Control_ThemeDuelCombatViewMediator_HandleThemeScoreChangedEvent__
		              );
		    DAT_ram_00a585b1 = '\x01';
		  }
		  Gameplay_Combat_Control_AbstractOneOnOneCombatViewMediator_object__object__object__object____ctor
		            (param1,
		             Method_Gameplay_Combat_Control_AbstractOneOnOneCombatViewMediator_ThemeDuelCombatModel__ThemeDuelCombatEvents__ThemeDuelCombatController__ThemeDuelCombatView__AddGameProcessEventsHandlers__
		            );
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  uVar5 = *(undefined4 *)(iVar1 + 0x70);
		  uVar2 = unnamed_function_1417(System_Action_ProtoThemeScoreChangedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_ThemeDuelCombat_Control_ThemeDuelCombatViewMediator_HandleThemeScoreChangedEvent__
		             ,0);
		  iVar3 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_ProtoThemeScoreChangedEvt__TypeInfo;
		  if (iVar3 == 0) {
		    *(undefined4 *)(iVar1 + 0x70) = 0;
		  }
		  else {
		    iVar4 = func_ii_1082(iVar3,System_Action_ProtoThemeScoreChangedEvt__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar3,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar1 + 0x70) = iVar4;
		    uVar2 = System_Action_ProtoThemeScoreChangedEvt__TypeInfo;
		    iVar1 = func_ii_1082(iVar3,System_Action_ProtoThemeScoreChangedEvt__TypeInfo);
		    if (iVar1 == 0) {
		      System_Activator__CreateInstance(iVar3,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  uVar5 = *(undefined4 *)(iVar1 + 0x74);
		  uVar2 = unnamed_function_1417(System_Action_bool__TypeInfo);
		  System_Action_AsyncGPUReadbackRequest___Invoke
		            (uVar2,param1,
		             Method_Gameplay_ThemeDuelCombat_Control_ThemeDuelCombatViewMediator_HandleRunNextCombatAvailEvent__
		             ,0);
		  iVar3 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_bool__TypeInfo;
		  if (iVar3 == 0) {
		    *(undefined4 *)(iVar1 + 0x74) = 0;
		    return;
		  }
		  iVar4 = func_ii_1082(iVar3,System_Action_bool__TypeInfo);
		  if (iVar4 != 0) {
		    *(int *)(iVar1 + 0x74) = iVar4;
		    uVar2 = System_Action_bool__TypeInfo;
		    iVar1 = func_ii_1082(iVar3,System_Action_bool__TypeInfo);
		    if (iVar1 != 0) {
		      return;
		    }
		    System_Activator__CreateInstance(iVar3,uVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  System_Activator__CreateInstance(iVar3,uVar2);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06001D97 RID: 7575 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D97")]
		[Address(RVA = "0x6F16", Offset = "0x6F16", VA = "0x6F16", Slot = "29")]
		protected override void AddGameProcessEventsHandlers()
		{
		/* --- GHIDRA: AddGameProcessEventsHandlers ---
		void Gameplay_ThemeDuelCombat_Control_ThemeDuelCombatViewMediator__AddGameProcessEventsHandlers
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a585b2 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_AbstractOneOnOneCombatViewMediator_ThemeDuelCombatModel__ThemeDuelCombatEvents__ThemeDuelCombatController__ThemeDuelCombatView__RemoveGameProcessEventsHandlers__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoThemeScoreChangedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_ThemeDuelCombat_Control_ThemeDuelCombatViewMediator_HandleRunNextCombatAvailEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_ThemeDuelCombat_Control_ThemeDuelCombatViewMediator_HandleThemeScoreChangedEvent__
		              );
		    DAT_ram_00a585b2 = '\x01';
		  }
		  Gameplay_Combat_Control_AbstractOneOnOneCombatViewMediator_object__object__object__object___HandleSkillInfoVisibleLeft
		            (param1,
		             Method_Gameplay_Combat_Control_AbstractOneOnOneCombatViewMediator_ThemeDuelCombatModel__ThemeDuelCombatEvents__ThemeDuelCombatController__ThemeDuelCombatView__RemoveGameProcessEventsHandlers__
		            );
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  uVar5 = *(undefined4 *)(iVar1 + 0x70);
		  uVar2 = unnamed_function_1417(System_Action_ProtoThemeScoreChangedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_ThemeDuelCombat_Control_ThemeDuelCombatViewMediator_HandleThemeScoreChangedEvent__
		             ,0);
		  iVar3 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_ProtoThemeScoreChangedEvt__TypeInfo;
		  if (iVar3 == 0) {
		    *(undefined4 *)(iVar1 + 0x70) = 0;
		  }
		  else {
		    iVar4 = func_ii_1082(iVar3,System_Action_ProtoThemeScoreChangedEvt__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar3,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar1 + 0x70) = iVar4;
		    uVar2 = System_Action_ProtoThemeScoreChangedEvt__TypeInfo;
		    iVar1 = func_ii_1082(iVar3,System_Action_ProtoThemeScoreChangedEvt__TypeInfo);
		    if (iVar1 == 0) {
		      System_Activator__CreateInstance(iVar3,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  uVar5 = *(undefined4 *)(iVar1 + 0x74);
		  uVar2 = unnamed_function_1417(System_Action_bool__TypeInfo);
		  System_Action_AsyncGPUReadbackRequest___Invoke
		            (uVar2,param1,
		             Method_Gameplay_ThemeDuelCombat_Control_ThemeDuelCombatViewMediator_HandleRunNextCombatAvailEvent__
		             ,0);
		  iVar3 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_bool__TypeInfo;
		  if (iVar3 == 0) {
		    *(undefined4 *)(iVar1 + 0x74) = 0;
		    return;
		  }
		  iVar4 = func_ii_1082(iVar3,System_Action_bool__TypeInfo);
		  if (iVar4 != 0) {
		    *(int *)(iVar1 + 0x74) = iVar4;
		    uVar2 = System_Action_bool__TypeInfo;
		    iVar1 = func_ii_1082(iVar3,System_Action_bool__TypeInfo);
		    if (iVar1 != 0) {
		      return;
		    }
		    System_Activator__CreateInstance(iVar3,uVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  System_Activator__CreateInstance(iVar3,uVar2);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06001D98 RID: 7576 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D98")]
		[Address(RVA = "0x6F17", Offset = "0x6F17", VA = "0x6F17", Slot = "30")]
		protected override void RemoveGameProcessEventsHandlers()
		{
		/* --- GHIDRA: RemoveGameProcessEventsHandlers ---
		void Gameplay_ThemeDuelCombat_Control_ThemeDuelCombatViewMediator__RemoveGameProcessEventsHandlers
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar1 = func_ii_12174(*(undefined4 *)(iVar1 + 0x28),0);
		  if (iVar1 != 0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                          (*(undefined4 *)(*(int *)(iVar1 + 0x28) + 0x20),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (param1_00,param2,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001D99 RID: 7577 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D99")]
		[Address(RVA = "0x1D0B", Offset = "0x1D0B", VA = "0x1D0B")]
		private void HandleThemeScoreChangedEvent(ProtoThemeScoreChangedEvt msg)
		{
		/* --- GHIDRA: HandleThemeScoreChangedEvent ---
		int * Gameplay_ThemeDuelCombat_Control_ThemeDuelCombatViewMediator__HandleThemeScoreChangedEvent
		                (int *param1)
		
		{
		  if (*param1 == 0) {
		    return param1;
		  }
		  System_Data_DataSet__ValidateLocaleConstraint(*param1);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06001D9A RID: 7578 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D9A")]
		[Address(RVA = "0x6F18", Offset = "0x6F18", VA = "0x6F18")]
		private void HandleRunNextCombatAvailEvent(bool value)
		{
		/* --- GHIDRA: HandleRunNextCombatAvailEvent ---
		/* WARNING: Removing unreachable block (ram,0x80f0cbf8) */
		
		void Gameplay_ThemeDuelCombat_Control_ThemeDuelCombatViewMediator__HandleRunNextCombatAvailEvent
		               (int param1,undefined4 param2)
		
		{
		  undefined8 uVar1;
		  undefined8 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 param1_00;
		  int *piVar5;
		  int local_30;
		  undefined8 *local_2c;
		  undefined8 local_28;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a585b4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_AbstractOneOnOneCombatViewMediator_ThemeDuelCombatModel__ThemeDuelCombatEvents__ThemeDuelCombatController__ThemeDuelCombatView__HandleInitEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ThemeDuelCombatModel__ThemeDuelCombatEvents__ThemeDuelCombatController__ThemeDuelCombatView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_ulong__ulong__GetEnumerator__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_Enumerator_ulong__ulong__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_Enumerator_ulong__ulong__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_Enumerator_ulong__ulong__get_Current__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_ulong__ulong__get_Key__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_ulong__ulong__get_Value__);
		    Mono_Security_ASN1__get_Item(&Protocol_Combat_ProtoThemeScoreChangedEvt_TypeInfo);
		    DAT_ram_00a585b4 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  local_18 = 0;
		  local_20 = 0;
		  local_28 = 0;
		  Gameplay_Combat_Control_AbstractOneOnOneCombatViewMediator_object__object__object__object___HandleChatEvent
		            (param1,
		             Method_Gameplay_Combat_Control_AbstractOneOnOneCombatViewMediator_ThemeDuelCombatModel__ThemeDuelCombatEvents__ThemeDuelCombatController__ThemeDuelCombatView__HandleInitEvent__
		            );
		  System_Collections_Generic_Dictionary_ulong__ulong___FindEntry
		            (&local_28,*(undefined4 *)(*(int *)(param1 + 8) + 0x60),
		             Method_System_Collections_Generic_Dictionary_ulong__ulong__GetEnumerator__);
		  local_30 = 0;
		  local_2c = &local_28;
		  while( true ) {
		    DAT_ram_009d3e38 = 0;
		    iVar3 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x182,&local_28,
		                       Method_System_Collections_Generic_Dictionary_Enumerator_ulong__ulong__MoveNext__
		                      );
		    uVar2 = local_10;
		    uVar1 = local_18;
		    iVar4 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar4 == 1) {
		      param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f0cc64;
		    }
		    if (iVar3 == 0) {
		      DAT_ram_009d3e38 = 0;
		      return;
		    }
		    DAT_ram_009d3e38 = 0;
		    iVar4 = import::env::invoke_ii
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                       Protocol_Combat_ProtoThemeScoreChangedEvt_TypeInfo);
		    if (DAT_ram_009d3e38 == 1) break;
		    *(undefined8 *)(iVar4 + 0x18) = uVar2;
		    *(undefined8 *)(iVar4 + 0x10) = uVar1;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x184,param1,iVar4,&local_30);
		    iVar4 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar4 == 1) {
		      param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80f0cc64:
		      iVar4 = global_1;
		      iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar4 == iVar3) {
		        piVar5 = (int *)import::env::__cxa_begin_catch(param1_00);
		        iVar3 = *piVar5;
		        DAT_ram_009d3e38 = 0;
		        local_30 = iVar3;
		        import::env::invoke_v(0x123);
		        iVar4 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar4 != 1) {
		          if (iVar3 == 0) {
		            DAT_ram_009d3e38 = 0;
		            return;
		          }
		          System_Data_DataSet__ValidateLocaleConstraint(iVar3);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        param1_00 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x185,&local_30);
		      iVar4 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar4 == 1) {
		        import::env::__cxa_find_matching_catch_3(0);
		        unnamed_function_937();
		        do {
		          halt_trap();
		        } while( true );
		      }
		      import::env::__resumeException(param1_00);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  DAT_ram_009d3e38 = 0;
		  param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  goto code_r0x80f0cc64;
		}
		*/

		}

		// Token: 0x06001D9B RID: 7579 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D9B")]
		[Address(RVA = "0x6F19", Offset = "0x6F19", VA = "0x6F19", Slot = "23")]
		protected override void HandleInitEvent()
		{
		/* --- GHIDRA: HandleInitEvent ---
		void Gameplay_ThemeDuelCombat_Control_ThemeDuelCombatViewMediator__HandleInitEvent
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a585b5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_AbstractOneOnOneCombatViewMediator_ThemeDuelCombatModel__ThemeDuelCombatEvents__ThemeDuelCombatController__ThemeDuelCombatView__HandleResetView__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_ThemeDuelCombat_Control_ThemeDuelCombatViewMediator_HandleTdShopButtonClickEvent__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a585b5 = '\x01';
		  }
		  Gameplay_Combat_Control_AbstractOneOnOneCombatViewMediator_object__object__object__object___HandleOtherPlayerTriggersChangedEvent
		            (param1,
		             Method_Gameplay_Combat_Control_AbstractOneOnOneCombatViewMediator_ThemeDuelCombatModel__ThemeDuelCombatEvents__ThemeDuelCombatController__ThemeDuelCombatView__HandleResetView__
		            );
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_01 = *(undefined4 *)(*(int *)(iVar1 + 0x7c) + 0xb4);
		  param1_00 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (param1_00,param1,
		             Method_Gameplay_ThemeDuelCombat_Control_ThemeDuelCombatViewMediator_HandleTdShopButtonClickEvent__
		             ,0);
		  UnityEngine_Events_UnityAction___ctor(param1_01,param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06001D9C RID: 7580 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D9C")]
		[Address(RVA = "0x6F1A", Offset = "0x6F1A", VA = "0x6F1A", Slot = "32")]
		protected override void HandleResetView()
		{
		/* --- GHIDRA: HandleResetView ---
		void Gameplay_ThemeDuelCombat_Control_ThemeDuelCombatViewMediator__HandleResetView
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int param1_00;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  undefined8 local_18;
		  undefined8 local_10;
		  int local_4;
		  
		  if (DAT_ram_00a585b6 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_AbstractOneOnOneCombatViewMediator_ThemeDuelCombatModel__ThemeDuelCombatEvents__ThemeDuelCombatController__ThemeDuelCombatView__HandleSetupView__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ThemeDuelCombatModel__ThemeDuelCombatEvents__ThemeDuelCombatController__ThemeDuelCombatView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_Component_TryGetComponent_RewardToBalanceTweener___);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_ThemeDuelCombat_Control_ThemeDuelCombatViewMediator_HandleTdShopButtonClickEvent__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1746);
		    Mono_Security_ASN1__get_Item(&StringLiteral_17000);
		    DAT_ram_00a585b6 = '\x01';
		  }
		  local_4 = 0;
		  Gameplay_Portals_Combat_Control_PortalCombatViewMediator__StageChangedHandler
		            (param1,
		             Method_Gameplay_Combat_Control_AbstractOneOnOneCombatViewMediator_ThemeDuelCombatModel__ThemeDuelCombatEvents__ThemeDuelCombatController__ThemeDuelCombatView__HandleSetupView__
		            );
		  param1_00 = *(int *)(param1[2] + 100);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(iVar1 + 0x70);
		  if (param1_00 == 0) {
		    UI_Elements_CommonElements___ctor(uVar3,0,StringLiteral_17000,0);
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    UI_Elements_CommonElements___ctor(*(undefined4 *)(iVar1 + 0x74),0,StringLiteral_17000,0);
		  }
		  else {
		    uVar4 = Core_Extensions_Dict_ThemeDuelDicExt__GetIcon32AssetId(param1_00,0);
		    local_10 = *(undefined8 *)(param1_00 + 0x30);
		    uVar2 = func_ii_1081(DAT_ram_00a66968,&local_10);
		    uVar2 = func_ii_4419(StringLiteral_1746,uVar2,0);
		    UI_Elements_CommonElements___ctor(uVar3,uVar4,uVar2,0);
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar2 = *(undefined4 *)(iVar1 + 0x74);
		    uVar3 = Core_Extensions_Dict_ThemeDuelDicExt__GetIcon32AssetId(param1_00,0);
		    local_18 = *(undefined8 *)(param1_00 + 0x30);
		    uVar4 = func_ii_1081(DAT_ram_00a66968,&local_18);
		    uVar4 = func_ii_4419(StringLiteral_1746,uVar4,0);
		    UI_Elements_CommonElements___ctor(uVar2,uVar3,uVar4,0);
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    iVar1 = UnityEngine_UIElements_GroupBoxUtility__UnregisterGroupBoxOption_object_
		                      (*(undefined4 *)(iVar1 + 0x28),&local_4,
		                       Method_UnityEngine_Component_TryGetComponent_RewardToBalanceTweener___);
		    if (iVar1 != 0) {
		      uVar4 = *(undefined4 *)(*(int *)(local_4 + 0x14) + 0xc);
		      uVar3 = Core_Extensions_Dict_ThemeDuelDicExt__GetBtnImgBattleListAssetId(param1_00,0);
		      Core_Extensions_Dict_PortalDicExt__GetCurrencyIcon60x66(uVar4,uVar3,0);
		      iVar1 = *(int *)(param1[2] + 0x6c);
		      uVar3 = *(undefined4 *)(local_4 + 0x14);
		      if (DAT_ram_00a58587 == '\0') {
		        Mono_Security_ASN1__get_Item(&Method_System_Nullable_long__GetValueOrDefault__);
		        DAT_ram_00a58587 = '\x01';
		      }
		      AssetContent_GameRawImage__set_AssetId(uVar3,(float)*(longlong *)(iVar1 + 0x20),0);
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar4 = *(undefined4 *)(*(int *)(iVar1 + 0x7c) + 0xb4);
		  uVar3 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar3,param1,
		             Method_Gameplay_ThemeDuelCombat_Control_ThemeDuelCombatViewMediator_HandleTdShopButtonClickEvent__
		             ,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar4,uVar3,0);
		  return;
		}
		*/

		}

		// Token: 0x06001D9D RID: 7581 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D9D")]
		[Address(RVA = "0x6F1B", Offset = "0x6F1B", VA = "0x6F1B", Slot = "31")]
		protected override void HandleSetupView()
		{
		/* --- GHIDRA: HandleSetupView ---
		void Gameplay_ThemeDuelCombat_Control_ThemeDuelCombatViewMediator__HandleSetupView
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a585b7 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_PopupController_Show_ThemeDuelWindow___);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_ThemeDuel_View_ThemeDuelWindow_ThemeDuelWindowArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12672);
		    DAT_ram_00a585b7 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0x170) * 4))
		            (param1,*(undefined4 *)(iVar1 + 0x28),*(undefined4 *)(*param1 + 0x174));
		  uVar2 = System_Uri___ctor(0);
		  uVar2 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar2,0);
		  iVar1 = unnamed_function_1417
		                    (Gameplay_ThemeDuel_View_ThemeDuelWindow_ThemeDuelWindowArgs_TypeInfo);
		  UI_Windows_BaseWindowArgs__Dispose(iVar1,0);
		  *(undefined4 *)(iVar1 + 0x10) = 0xc;
		  *(undefined4 *)(iVar1 + 0x18) = 3;
		  Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		            (uVar2,StringLiteral_12672,iVar1,
		             Method_UI_Windows_PopupController_Show_ThemeDuelWindow___);
		  return;
		}
		*/

		}

		// Token: 0x06001D9E RID: 7582 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D9E")]
		[Address(RVA = "0x6F1C", Offset = "0x6F1C", VA = "0x6F1C")]
		private void HandleTdShopButtonClickEvent()
		{
		/* --- GHIDRA: HandleTdShopButtonClickEvent ---
		undefined4
		Gameplay_ThemeDuelCombat_Control_ThemeDuelCombatViewMediator__HandleTdShopButtonClickEvent
		          (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  undefined4 uVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a585b8 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_AbstractCombatViewMediator_ThemeDuelCombatModel__ThemeDuelCombatEvents__ThemeDuelCombatController__ThemeDuelCombatView__ShowAwaitCombatWindow__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ThemeDuelCombatModel__ThemeDuelCombatEvents__ThemeDuelCombatController__ThemeDuelCombatView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2797);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2798);
		    Mono_Security_ASN1__get_Item(&StringLiteral_6233);
		    DAT_ram_00a585b8 = '\x01';
		  }
		  param1_00 = Gameplay_Combat_Control_AbstractCombatViewMediator_object__object__object__object___RunShowCombatViewProcess
		                        (param1,param2,
		                         Method_Gameplay_Combat_Control_AbstractCombatViewMediator_ThemeDuelCombatModel__ThemeDuelCombatEvents__ThemeDuelCombatController__ThemeDuelCombatView__ShowAwaitCombatWindow__
		                        );
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar1 = func_ii_7508(StringLiteral_6233,1,0,1,0,0,0,0);
		  Gameplay_Combat_View_CombatWaitingWindowMono__HideWaitingWindow(param1_00,uVar1,0);
		  iVar2 = *(int *)(*(int *)(param1 + 8) + 0x5c);
		  if (iVar2 == 1) {
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar1 = func_ii_7508(StringLiteral_2797,1,0,1,0,0,0,0);
		  }
		  else if (iVar2 == 2) {
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar1 = func_ii_7508(StringLiteral_2798,1,0,1,0,0,0,0);
		  }
		  else {
		    uVar1 = **(undefined4 **)(DAT_ram_00a66978 + 0x5c);
		  }
		  Core_Extensions_StringExt__Replacer(param1_00,uVar1,0);
		  return param1_00;
		}
		*/

		}

		// Token: 0x06001D9F RID: 7583 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001D9F")]
		[Address(RVA = "0x6F1D", Offset = "0x6F1D", VA = "0x6F1D", Slot = "33")]
		protected override CombatWaitingWindowMono ShowAwaitCombatWindow(BackTime backTime)
		{
		/* --- GHIDRA: ShowAwaitCombatWindow ---
		int Gameplay_ThemeDuelCombat_Control_ThemeDuelCombatViewMediator__ShowAwaitCombatWindow
		              (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a585b9 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_AbstractCombatViewMediator_ThemeDuelCombatModel__ThemeDuelCombatEvents__ThemeDuelCombatController__ThemeDuelCombatView__HandleGameOverWindowCloseRequestEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ThemeDuelCombatModel__ThemeDuelCombatEvents__ThemeDuelCombatController__ThemeDuelCombatView__get_Model__
		              );
		    DAT_ram_00a585b9 = '\x01';
		  }
		  param2_00 = *(undefined4 *)(*(int *)(param1 + 8) + 0x50);
		  iVar1 = Gameplay_Combat_Control_AbstractCombatViewMediator_object__object__object__object___HandleGameOver
		                    (param1,param2,
		                     Method_Gameplay_Combat_Control_AbstractCombatViewMediator_ThemeDuelCombatModel__ThemeDuelCombatEvents__ThemeDuelCombatController__ThemeDuelCombatView__HandleGameOverWindowCloseRequestEvent__
		                    );
		  if (iVar1 == 0) {
		    param1_00 = UI_Windows_PopupController__get_OpenedWindowsCount(0);
		    DefaultNamespace_SceneAppManager__RemoveScene(param1_00,param2_00,0);
		  }
		  return iVar1;
		}
		*/

			return null;
		}

		// Token: 0x06001DA0 RID: 7584 RVA: 0x00006348 File Offset: 0x00004548
		[Token(Token = "0x6001DA0")]
		[Address(RVA = "0x6F1E", Offset = "0x6F1E", VA = "0x6F1E", Slot = "22")]
		protected override bool HandleGameOverWindowCloseRequestEvent(CombatGameOverView view)
		{
		/* --- GHIDRA: HandleGameOverWindowCloseRequestEvent ---
		undefined4
		Gameplay_ThemeDuelCombat_Control_ThemeDuelCombatViewMediator__HandleGameOverWindowCloseRequestEvent
		          (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a585ba == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_AbstractCombatViewMediator_ThemeDuelCombatModel__ThemeDuelCombatEvents__ThemeDuelCombatController__ThemeDuelCombatView__HandleGameOverWindowNextCombatRequestEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ThemeDuelCombatModel__ThemeDuelCombatEvents__ThemeDuelCombatController__ThemeDuelCombatView__get_Model__
		              );
		    DAT_ram_00a585ba = '\x01';
		  }
		  if (*(int *)(param1[2] + 100) == 0) {
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x170) * 4))
		                      (param1,param2,*(undefined4 *)(*param1 + 0x174));
		    return uVar2;
		  }
		  uVar2 = *(undefined4 *)(param1[2] + 0x5c);
		  iVar1 = Gameplay_Combat_Control_AbstractCombatViewMediator_object__object__object__object___HandleGameOverWindowCloseRequestEvent
		                    (param1,param2,
		                     Method_Gameplay_Combat_Control_AbstractCombatViewMediator_ThemeDuelCombatModel__ThemeDuelCombatEvents__ThemeDuelCombatController__ThemeDuelCombatView__HandleGameOverWindowNextCombatRequestEvent__
		                    );
		  if (iVar1 == 0) {
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    Gameplay_ThemeDuelCombat_ThemeDuelCombat__Dispose
		              (**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c),uVar2,0,param1);
		    uVar2 = 0;
		  }
		  else {
		    uVar2 = 1;
		  }
		  return uVar2;
		}
		*/

			return default(bool);
		}

		// Token: 0x06001DA1 RID: 7585 RVA: 0x00006360 File Offset: 0x00004560
		[Token(Token = "0x6001DA1")]
		[Address(RVA = "0x6F1F", Offset = "0x6F1F", VA = "0x6F1F", Slot = "21")]
		protected override bool HandleGameOverWindowNextCombatRequestEvent(CombatGameOverView gameOverView)
		{
		/* --- GHIDRA: HandleGameOverWindowNextCombatRequestEvent ---
		void Gameplay_ThemeDuelCombat_Control_ThemeDuelCombatViewMediator__HandleGameOverWindowNextCombatRequestEvent
		               (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  int iVar4;
		  undefined4 param1_00;
		  int *piVar5;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a585bb == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ThemeDuelCombatModel__ThemeDuelCombatEvents__ThemeDuelCombatController__ThemeDuelCombatView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_IndexButtonBasic__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_Component_TryGetComponent_RewardToBalanceTweener___);
		    Mono_Security_ASN1__get_Item(&System_Func_CombatGameOverView__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Sound_Control_IGameAudio_TypeInfo);
		    DAT_ram_00a585bb = '\x01';
		  }
		  local_4 = 0;
		  param1[7] = param2;
		  uVar2 = unnamed_function_1417(System_Func_CombatGameOverView__bool__TypeInfo);
		  System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		            (uVar2,param1,*(undefined4 *)(*param1 + 0x174),0);
		  Gameplay_Combat_View_CombatEventsToast___ctor(param2,uVar2,0);
		  iVar4 = param1[7];
		  uVar2 = unnamed_function_1417(System_Func_CombatGameOverView__bool__TypeInfo);
		  System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		            (uVar2,param1,*(undefined4 *)(*param1 + 0x16c),0);
		  Gameplay_Combat_View_CombatGameOverView__remove_CloseRequestEvent(iVar4,uVar2,0);
		  param1_00 = *(undefined4 *)(param1[7] + 0x38);
		  uVar2 = unnamed_function_1417(System_Action_IndexButtonBasic__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout(uVar2,param1,*(undefined4 *)(*param1 + 500),0);
		  UI_IndexButtonBasic__get_CanvasGroup(param1_00,uVar2,0);
		  piVar5 = *(int **)(*(int *)(param1[2] + 0x3c) + 0x1c);
		  iVar4 = *piVar5;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Gameplay_Sound_Control_IGameAudio_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)
		         ) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xd8);
		        goto code_r0x80f0d43c;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar5,Gameplay_Sound_Control_IGameAudio_TypeInfo,3);
		code_r0x80f0d43c:
		  (**(code **)((ulonglong)*puVar3 * 4))(piVar5,puVar3[1]);
		  uVar2 = 0x18;
		  if (*(char *)(*(int *)(param1[2] + 0x10) + 8) == '\0') {
		    uVar2 = 0x19;
		  }
		  uVar1 = 0;
		  piVar5 = *(int **)(*(int *)(param1[2] + 0x3c) + 0x1c);
		  iVar4 = *piVar5;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Gameplay_Sound_Control_IGameAudio_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)
		         ) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 200);
		        goto code_r0x80f0d4d6;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar5,Gameplay_Sound_Control_IGameAudio_TypeInfo,1);
		code_r0x80f0d4d6:
		  (**(code **)((ulonglong)*puVar3 * 4))(piVar5,uVar2,puVar3[1]);
		  iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar4 = UnityEngine_UIElements_GroupBoxUtility__UnregisterGroupBoxOption_object_
		                    (*(undefined4 *)(iVar4 + 0x28),&local_4,
		                     Method_UnityEngine_Component_TryGetComponent_RewardToBalanceTweener___);
		  if (iVar4 != 0) {
		    Gameplay_Combat_View_RewardToBalanceTweener__get_Ballance
		              (local_4,*(undefined4 *)(*(int *)(param1[2] + 0x10) + 0x20),0.8,0);
		  }
		  return;
		}
		*/

			return default(bool);
		}
	}
}
