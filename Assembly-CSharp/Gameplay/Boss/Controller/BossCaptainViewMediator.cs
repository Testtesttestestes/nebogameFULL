using System;
using System.Threading;
using Gameplay.Boss.Events;
using Gameplay.Boss.Model;
using Gameplay.Boss.View.CaptainTab;
using Il2CppDummyDll;

namespace Gameplay.Boss.Controller
{
	// Token: 0x02000BA2 RID: 2978
	[Token(Token = "0x2000BA2")]
	public class BossCaptainViewMediator : AbstractBossWindowViewMediator<BossCaptainView>
	{
		// Token: 0x060048C2 RID: 18626 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048C2")]
		[Address(RVA = "0x973A", Offset = "0x973A", VA = "0x973A", Slot = "14")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_Boss_Controller_BossCaptainViewMediator__Dispose
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a578a0 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Boss_Controller_AbstractBossWindowViewMediator_BossCaptainView___ctor__
		              );
		    Mono_Security_ASN1__get_Item(&System_Threading_CancellationTokenSource_TypeInfo);
		    DAT_ram_00a578a0 = '\x01';
		  }
		  Core_Gameplay_Managers_Ad_Placements_AbstractAdPlacementManager_object__object__object___set_Model
		            (param1,param2,param3,param4,
		             Method_Gameplay_Boss_Controller_AbstractBossWindowViewMediator_BossCaptainView___ctor__
		            );
		  param1_00 = unnamed_function_1417(System_Threading_CancellationTokenSource_TypeInfo);
		  Gameplay_Combat_Control_Conveyor__Next(param1_00,0);
		  *(undefined4 *)(param1 + 0x18) = param1_00;
		  return;
		}
		*/

		}

		// Token: 0x060048C3 RID: 18627 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048C3")]
		[Address(RVA = "0x973B", Offset = "0x973B", VA = "0x973B")]
		public BossCaptainViewMediator(BossInstanceModel model, BossInstanceEvents events, BossInstanceController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Boss_Controller_BossCaptainViewMediator___ctor(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a578a2 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_BossInstanceModel__BossInstanceEvents__BossInstanceController__BossCaptainView__get_Model__
		              );
		    DAT_ram_00a578a2 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Boss_View_CaptainTab_BossTeamView__add_AssistantClickedEvent
		            (*(undefined4 *)(iVar1 + 0x24),*(undefined4 *)(param1[2] + 0x3c),0);
		  return;
		}
		*/

		}

		// Token: 0x060048C4 RID: 18628 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048C4")]
		[Address(RVA = "0x1B5F", Offset = "0x1B5F", VA = "0x1B5F")]
		private void HealthChangedEvent()
		{
		/* --- GHIDRA: HealthChangedEvent ---
		void Gameplay_Boss_Controller_BossCaptainViewMediator__HealthChangedEvent
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 param1_00;
		  int *piVar3;
		  longlong lVar4;
		  longlong local_28;
		  undefined4 local_20;
		  int local_18;
		  undefined8 *local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a578a7 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_BossInstanceModel__BossInstanceEvents__BossInstanceController__BossCaptainView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_BossAttackOptionView__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_BossAttackOptionView__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_BossAttackOptionView__get_Current__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_BossAttackOptionView__GetEnumerator__);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_ValueTuple_long__int___get_HasValue__);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_ValueTuple_long__int___get_Value__);
		    DAT_ram_00a578a7 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  if (*(char *)(param1[2] + 0x10) == '\0') {
		    return;
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_10,*(undefined4 *)(*(int *)(iVar1 + 0x30) + 0x3c),
		             Method_System_Collections_Generic_List_BossAttackOptionView__GetEnumerator__);
		  local_18 = 0;
		  local_14 = &local_10;
		  while( true ) {
		    do {
		      DAT_ram_009d3e38 = 0;
		      iVar2 = import::env::invoke_iii
		                        (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_10,
		                         Method_System_Collections_Generic_List_Enumerator_BossAttackOptionView__MoveNext__
		                        );
		      iVar1 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar1 == 1) {
		        param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80df14b2;
		      }
		      if (iVar2 == 0) {
		        DAT_ram_009d3e38 = 0;
		        return;
		      }
		      iVar2 = local_8._4_4_;
		      lVar4 = *(longlong *)(*(int *)(*(int *)(local_8._4_4_ + 0x34) + 8) + 0x10);
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_viii
		                (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x377,&local_28,param1[2] + 0x10,
		                 Method_System_Nullable_ValueTuple_long__int___get_Value__);
		      iVar1 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar1 == 1) {
		        param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80df14b2;
		      }
		    } while (lVar4 != local_28);
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x377,&local_28,param1[2] + 0x10,
		               Method_System_Nullable_ValueTuple_long__int___get_Value__);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) break;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x378,iVar2,local_20,0);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) {
		      param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80df14b2:
		      iVar1 = global_1;
		      iVar2 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar1 == iVar2) {
		        piVar3 = (int *)import::env::__cxa_begin_catch(param1_00);
		        iVar2 = *piVar3;
		        DAT_ram_009d3e38 = 0;
		        local_18 = iVar2;
		        import::env::invoke_v(0x123);
		        iVar1 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar1 != 1) {
		          if (iVar2 == 0) {
		            DAT_ram_009d3e38 = 0;
		            return;
		          }
		          System_Data_DataSet__ValidateLocaleConstraint(iVar2);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        param1_00 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_000017c8 + 0x379,&local_18);
		      iVar1 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar1 != 1) {
		        import::env::__resumeException(param1_00);
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
		  param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  goto code_r0x80df14b2;
		}
		*/

		}

		// Token: 0x060048C5 RID: 18629 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048C5")]
		[Address(RVA = "0x973C", Offset = "0x973C", VA = "0x973C")]
		private void TeamInfoChangedEvent()
		{
		/* --- GHIDRA: TeamInfoChangedEvent ---
		void Gameplay_Boss_Controller_BossCaptainViewMediator__TeamInfoChangedEvent
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int *piVar3;
		  undefined4 uVar4;
		  
		  if (DAT_ram_00a578a3 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Boss_Controller_BossCaptainViewMediator_HealthChangedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Boss_Controller_BossCaptainViewMediator_TeamInfoChangedEvent__);
		    DAT_ram_00a578a3 = '\x01';
		  }
		  uVar4 = *(undefined4 *)(param2 + 0x1c);
		  uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,param1,
		             Method_Gameplay_Boss_Controller_BossCaptainViewMediator_TeamInfoChangedEvent__,0);
		  piVar3 = (int *)func_ii_7048(uVar4,uVar2,0);
		  iVar1 = System_Action_TypeInfo;
		  if (piVar3 == (int *)0x0) {
		    *(undefined4 *)(param2 + 0x1c) = 0;
		  }
		  else if ((*piVar3 != System_Action_TypeInfo) ||
		          (*(int **)(param2 + 0x1c) = piVar3, *piVar3 != iVar1)) {
		    System_Activator__CreateInstance(piVar3,iVar1);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  uVar4 = *(undefined4 *)(param2 + 0x18);
		  uVar2 = unnamed_function_1417(iVar1);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,param1,
		             Method_Gameplay_Boss_Controller_BossCaptainViewMediator_HealthChangedEvent__,0);
		  piVar3 = (int *)func_ii_7048(uVar4,uVar2,0);
		  iVar1 = System_Action_TypeInfo;
		  if (piVar3 == (int *)0x0) {
		    *(undefined4 *)(param2 + 0x18) = 0;
		    return;
		  }
		  if ((System_Action_TypeInfo == *piVar3) && (*(int **)(param2 + 0x18) = piVar3, *piVar3 == iVar1))
		  {
		    return;
		  }
		  System_Activator__CreateInstance(piVar3,iVar1);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x060048C6 RID: 18630 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048C6")]
		[Address(RVA = "0x973D", Offset = "0x973D", VA = "0x973D", Slot = "21")]
		protected override void ResetEvents(BossInstanceEvents events)
		{
		/* --- GHIDRA: ResetEvents ---
		void Gameplay_Boss_Controller_BossCaptainViewMediator__ResetEvents
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int *piVar3;
		  undefined4 uVar4;
		  
		  if (DAT_ram_00a578a4 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Boss_Controller_BossCaptainViewMediator_HealthChangedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Boss_Controller_BossCaptainViewMediator_TeamInfoChangedEvent__);
		    DAT_ram_00a578a4 = '\x01';
		  }
		  uVar4 = *(undefined4 *)(param2 + 0x1c);
		  uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,param1,
		             Method_Gameplay_Boss_Controller_BossCaptainViewMediator_TeamInfoChangedEvent__,0);
		  piVar3 = (int *)UnityEngine_UI_Image__set_sprite(uVar4,uVar2,0);
		  iVar1 = System_Action_TypeInfo;
		  if (piVar3 == (int *)0x0) {
		    *(undefined4 *)(param2 + 0x1c) = 0;
		  }
		  else if ((*piVar3 != System_Action_TypeInfo) ||
		          (*(int **)(param2 + 0x1c) = piVar3, *piVar3 != iVar1)) {
		    System_Activator__CreateInstance(piVar3,iVar1);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  uVar4 = *(undefined4 *)(param2 + 0x18);
		  uVar2 = unnamed_function_1417(iVar1);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,param1,
		             Method_Gameplay_Boss_Controller_BossCaptainViewMediator_HealthChangedEvent__,0);
		  piVar3 = (int *)UnityEngine_UI_Image__set_sprite(uVar4,uVar2,0);
		  iVar1 = System_Action_TypeInfo;
		  if (piVar3 == (int *)0x0) {
		    *(undefined4 *)(param2 + 0x18) = 0;
		    return;
		  }
		  if ((System_Action_TypeInfo == *piVar3) && (*(int **)(param2 + 0x18) = piVar3, *piVar3 == iVar1))
		  {
		    return;
		  }
		  System_Activator__CreateInstance(piVar3,iVar1);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x060048C7 RID: 18631 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048C7")]
		[Address(RVA = "0x973E", Offset = "0x973E", VA = "0x973E", Slot = "22")]
		protected override void SetupEvents(BossInstanceEvents events)
		{
		/* --- GHIDRA: SetupEvents ---
		void Gameplay_Boss_Controller_BossCaptainViewMediator__SetupEvents
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a578a5 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TeamData_TeamAssistantData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Action_BossInfo_BossAttackOption__BossInfo_BossAttackOption_BossAttackOptionVariant__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Boss_Controller_BossCaptainViewMediator_BossInfoViewOnAttackButtonClickEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Boss_Controller_BossCaptainViewMediator_SkillInfoButtonClickHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Boss_Controller_BossCaptainViewMediator_TeamEditViewOnExitEditModeEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Boss_Controller_BossCaptainViewMediator_TeamViewOnAssistantClickedEvent__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a578a5 = '\x01';
		  }
		  uVar2 = *(undefined4 *)(param2 + 0x30);
		  uVar1 = unnamed_function_1417
		                    (
		                    System_Action_BossInfo_BossAttackOption__BossInfo_BossAttackOption_BossAttackOptionVariant__TypeInfo
		                    );
		  System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		            (uVar1,param1,
		             Method_Gameplay_Boss_Controller_BossCaptainViewMediator_BossInfoViewOnAttackButtonClickEvent__
		             ,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__get_AttackOptionViews(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(*(int *)(*(int *)(param2 + 0x30) + 0x1c) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,
		             Method_Gameplay_Boss_Controller_BossCaptainViewMediator_SkillInfoButtonClickHandler__,0
		            );
		  UnityEngine_Events_UnityAction___ctor(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param2 + 0x24);
		  uVar1 = unnamed_function_1417(System_Action_TeamData_TeamAssistantData__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_Boss_Controller_BossCaptainViewMediator_TeamViewOnAssistantClickedEvent__
		             ,0);
		  Gameplay_Boss_View_CaptainTab_BossTeamEditView___ctor(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param2 + 0x2c);
		  uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar1,param1,
		             Method_Gameplay_Boss_Controller_BossCaptainViewMediator_TeamEditViewOnExitEditModeEvent__
		             ,0);
		  Gameplay_Boss_View_CaptainTab_BossTeamEditView__get_TeamView(uVar2,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x060048C8 RID: 18632 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048C8")]
		[Address(RVA = "0x973F", Offset = "0x973F", VA = "0x973F", Slot = "23")]
		protected override void ResetView(BossCaptainView view)
		{
		/* --- GHIDRA: ResetView ---
		void Gameplay_Boss_Controller_BossCaptainViewMediator__ResetView
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined8 local_34;
		  undefined8 local_2c;
		  undefined4 local_24;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined4 local_10;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a578a6 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_BossCaptainViewMediator__SetupView_d__8___
		              );
		    DAT_ram_00a578a6 = '\x01';
		  }
		  local_8 = 0;
		  System_Linq_Enumerable__ToDictionary_KeyValuePair_object__object___object__object_(&local_34,0);
		  local_18 = local_2c;
		  local_24 = 0xffffffff;
		  local_20 = local_34;
		  local_10 = param1;
		  local_c = param2;
		  System_Runtime_CompilerServices_AsyncVoidMethodBuilder__Start_BaseDictController__HandleRun_d__3_
		            (&local_20,&local_24,
		             Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_BossCaptainViewMediator__SetupView_d__8___
		            );
		  return;
		}
		*/

		}

		// Token: 0x060048C9 RID: 18633 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048C9")]
		[Address(RVA = "0x9740", Offset = "0x9740", VA = "0x9740", Slot = "24")]
		protected override void SetupView(BossCaptainView view)
		{
		/* --- GHIDRA: SetupView ---
		void Gameplay_Boss_Controller_BossCaptainViewMediator__SetupView
		               (int param1,int param2,int param3,undefined4 param4)
		
		{
		  undefined4 in_register_20000014;
		  uint *param4_00;
		  int *param1_00;
		  int iVar1;
		  undefined8 param2_00;
		  uint uVar2;
		  undefined8 local_38;
		  undefined8 local_30;
		  undefined8 local_28;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a578a8 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_BossInstanceModel__BossInstanceEvents__BossInstanceController__BossCaptainView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_BossInfo_BossAttackOption_BossAttackOptionVariant__get_Count__
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_ValueTuple_long__int____ctor__);
		    Mono_Security_ASN1__get_Item(&Method_System_ValueTuple_long__int___ctor__);
		    DAT_ram_00a578a8 = '\x01';
		  }
		  if (1 < *(int *)(*(int *)(param2 + 0xc) + 0xc)) {
		    iVar1 = *(int *)(param1 + 8);
		    param2_00 = *(undefined8 *)(*(int *)(param2 + 8) + 0x10);
		    local_8 = 0;
		    local_10 = 0;
		    System_ValueTuple_uint__uint___ToString
		              (&local_10,param2_00,*(undefined4 *)(*(int *)(param3 + 8) + 0xc),
		               Method_System_ValueTuple_long__int___ctor__);
		    local_18 = 0;
		    local_20 = 0;
		    local_30 = local_8;
		    local_28 = 0;
		    local_38 = local_10;
		    in_register_20000014 = (undefined4)((ulonglong)param2_00 >> 0x20);
		    UnityEngine_InputSystem_Utilities_PrimitiveValue__FromObject
		              (&local_28,&local_38,Method_System_Nullable_ValueTuple_long__int____ctor__);
		    *(undefined8 *)(iVar1 + 0x20) = local_18;
		    *(undefined8 *)(iVar1 + 0x18) = local_20;
		    *(undefined8 *)(iVar1 + 0x10) = local_28;
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar1 = *param1_00;
		  if (*(ushort *)(iVar1 + 0xb6) != 0) {
		    uVar2 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar1 + 0x58) + uVar2 * 8)) {
		        param4_00 = (uint *)(*(int *)(*(int *)(iVar1 + 0x58) + uVar2 * 8 + 4) * 8 + iVar1 + 0x1e0);
		        goto code_r0x80df1721;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar1 + 0xb6) != uVar2);
		  }
		  param4_00 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x24);
		code_r0x80df1721:
		  iVar1 = (**(code **)((ulonglong)*param4_00 * 4))
		                    (param1_00,CONCAT44(in_register_20000014,param4_00[1]));
		  Gameplay_Boss_Controller_BossController__GetInstanceList
		            (*(undefined4 *)(iVar1 + 0x10),*(undefined8 *)(*(int *)(param2 + 8) + 0x10),
		             *(undefined4 *)(*(int *)(param3 + 8) + 0xc),param4_00);
		  return;
		}
		*/

		}

		// Token: 0x060048CA RID: 18634 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048CA")]
		[Address(RVA = "0x1B60", Offset = "0x1B60", VA = "0x1B60")]
		private void TrySelectLastSavedOptionAndVariant()
		{
		/* --- GHIDRA: TrySelectLastSavedOptionAndVariant ---
		void Gameplay_Boss_Controller_BossCaptainViewMediator__TrySelectLastSavedOptionAndVariant
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  int *piVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a57a68 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_AssetContent_Loaders_AbstractGameGraphicLoader_Image__Sprite__set_AssetId__);
		    DAT_ram_00a57a68 = '\x01';
		  }
		  *(int *)(param1 + 0x40) = param2;
		  if (*(int *)(param2 + 0x18) != 0) {
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (*(undefined4 *)(param1 + 0x34),1,0);
		    param1_00 = *(undefined4 *)(param1 + 0x30);
		    uVar1 = Gameplay_Boss_View_CaptainTab_BossSkillInfoView__set_DominateCultDescription
		                      (*(undefined4 *)(*(int *)(param1 + 0x40) + 0x18),0);
		    Core_Extensions_Dict_CultDicExt__GetIcon64AssetId
		              (param1_00,uVar1,
		               Method_AssetContent_Loaders_AbstractGameGraphicLoader_Image__Sprite__set_AssetId__);
		    piVar2 = *(int **)(param1 + 0x2c);
		    uVar1 = System_Collections_Generic_Dictionary_object__object____ctor
		                      (*(undefined4 *)(*(int *)(param1 + 0x40) + 0x18),0);
		    iVar3 = *piVar2;
		    (**(code **)((ulonglong)*(uint *)(iVar3 + 0x2d0) * 4))
		              (piVar2,uVar1,*(undefined4 *)(iVar3 + 0x2d4));
		    return;
		  }
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (*(undefined4 *)(param1 + 0x34),0,0);
		  return;
		}
		*/

		}

		// Token: 0x060048CB RID: 18635 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048CB")]
		[Address(RVA = "0x9741", Offset = "0x9741", VA = "0x9741")]
		private void BossInfoViewOnAttackButtonClickEvent(BossInfo.BossAttackOption attackOption, BossInfo.BossAttackOption.BossAttackOptionVariant variant)
		{
		/* --- GHIDRA: BossInfoViewOnAttackButtonClickEvent ---
		void Gameplay_Boss_Controller_BossCaptainViewMediator__BossInfoViewOnAttackButtonClickEvent
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_UserInfo_View_BaseInfoBox__HandleVisibleChanged
		            (*(undefined4 *)(*(int *)(iVar1 + 0x30) + 0x2c),0);
		  return;
		}
		*/

		}

		// Token: 0x060048CC RID: 18636 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048CC")]
		[Address(RVA = "0x9742", Offset = "0x9742", VA = "0x9742")]
		private void SkillInfoButtonClickHandler()
		{
		/* --- GHIDRA: SkillInfoButtonClickHandler ---
		void Gameplay_Boss_Controller_BossCaptainViewMediator__SkillInfoButtonClickHandler
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a578a9 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_MonoBehaviourWithStates_BossCaptainViewStateController_BossCaptainViewState__set_CurrentState__
		              );
		    DAT_ram_00a578a9 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		            (*(undefined4 *)(iVar1 + 0x28),1,
		             Method_UI_MonoBehaviourWithStates_BossCaptainViewStateController_BossCaptainViewState__set_CurrentState__
		            );
		  return;
		}
		*/

		}

		// Token: 0x060048CD RID: 18637 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048CD")]
		[Address(RVA = "0x9743", Offset = "0x9743", VA = "0x9743")]
		private void TeamEditViewOnExitEditModeEvent()
		{
		/* --- GHIDRA: TeamEditViewOnExitEditModeEvent ---
		void Gameplay_Boss_Controller_BossCaptainViewMediator__TeamEditViewOnExitEditModeEvent
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a578aa == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_MonoBehaviourWithStates_BossCaptainViewStateController_BossCaptainViewState__set_CurrentState__
		              );
		    DAT_ram_00a578aa = '\x01';
		  }
		  if (param2 == 0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		              (*(undefined4 *)(iVar1 + 0x28),2,
		               Method_UI_MonoBehaviourWithStates_BossCaptainViewStateController_BossCaptainViewState__set_CurrentState__
		              );
		  }
		  return;
		}
		*/

		}

		// Token: 0x060048CE RID: 18638 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048CE")]
		[Address(RVA = "0x9744", Offset = "0x9744", VA = "0x9744")]
		private void TeamViewOnAssistantClickedEvent(TeamData.TeamAssistantData assistantData)
		{
		}

		// Token: 0x040027E5 RID: 10213
		[Token(Token = "0x40027E5")]
		[FieldOffset(Offset = "0x18")]
		private readonly CancellationTokenSource _cancellationTokenSource;
	}
}
