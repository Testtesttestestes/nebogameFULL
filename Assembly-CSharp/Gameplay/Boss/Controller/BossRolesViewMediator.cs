using System;
using Gameplay.Boss.Events;
using Gameplay.Boss.Model;
using Gameplay.Boss.View.RolesTab;
using Il2CppDummyDll;

namespace Gameplay.Boss.Controller
{
	// Token: 0x02000BB3 RID: 2995
	[Token(Token = "0x2000BB3")]
	public class BossRolesViewMediator : AbstractBossWindowViewMediator<BossRolesView>
	{
		// Token: 0x06004977 RID: 18807 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004977")]
		[Address(RVA = "0x97E9", Offset = "0x97E9", VA = "0x97E9")]
		public BossRolesViewMediator(BossInstanceModel model, BossInstanceEvents events, BossInstanceController controller)
		{
		}

		// Token: 0x06004978 RID: 18808 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004978")]
		[Address(RVA = "0x97EA", Offset = "0x97EA", VA = "0x97EA", Slot = "21")]
		protected override void ResetEvents(BossInstanceEvents events)
		{
		}

		// Token: 0x06004979 RID: 18809 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004979")]
		[Address(RVA = "0x97EB", Offset = "0x97EB", VA = "0x97EB", Slot = "22")]
		protected override void SetupEvents(BossInstanceEvents events)
		{
		/* --- GHIDRA: SetupEvents ---
		void Gameplay_Boss_Controller_BossRolesViewMediator__SetupEvents
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a57929 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_BossInfo_BossCultSpellData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Boss_Controller_BossRolesViewMediator_ViewOnSelectedEvent__);
		    DAT_ram_00a57929 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Action_BossInfo_BossCultSpellData__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_Boss_Controller_BossRolesViewMediator_ViewOnSelectedEvent__,0);
		  Gameplay_Boss_View_RolesTab_BossRolesView__add_SelectedEvent(param2,param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x0600497A RID: 18810 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600497A")]
		[Address(RVA = "0x97EC", Offset = "0x97EC", VA = "0x97EC", Slot = "23")]
		protected override void ResetView(BossRolesView view)
		{
		/* --- GHIDRA: ResetView ---
		void Gameplay_Boss_Controller_BossRolesViewMediator__ResetView
		               (int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  int *piVar5;
		  undefined1 auStack_20 [8];
		  int local_18;
		  undefined8 *local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5792a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_BossInstanceModel__BossInstanceEvents__BossInstanceController__BossRolesView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_BossInfo_BossCultSpellData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Boss_Controller_BossRolesViewMediator_ViewOnSelectedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_BossInfo_BossCultSpellData__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_BossInfo_BossCultSpellData__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_BossInfo_BossCultSpellData__get_Current__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_BossInfo_BossCultSpellData__GetEnumerator__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_BossInfo_BossCultSpellData__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_TeamData_TeamAssistantData__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_BossInfo_BossCultSpellData__get_Item__);
		    Mono_Security_ASN1__get_Item(&System_Math_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_MonoBehaviourWithStates_BossPossibleEmptyWindowStateController_WindowStates__set_CurrentState__
		              );
		    DAT_ram_00a5792a = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  uVar2 = unnamed_function_1417(System_Action_BossInfo_BossCultSpellData__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_Boss_Controller_BossRolesViewMediator_ViewOnSelectedEvent__,0);
		  Gameplay_Boss_View_RolesTab_BossRolesView__get_SelectedItem(param2,uVar2,0);
		  if (*(int *)(*(int *)(*(int *)(*(int *)(param1 + 8) + 0x30) + 0x48) + 0xc) < 1) {
		    Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		              (*(undefined4 *)(param2 + 0x38),1,
		               Method_UI_MonoBehaviourWithStates_BossPossibleEmptyWindowStateController_WindowStates__set_CurrentState__
		              );
		    return;
		  }
		  Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		            (*(undefined4 *)(param2 + 0x38),2,
		             Method_UI_MonoBehaviourWithStates_BossPossibleEmptyWindowStateController_WindowStates__set_CurrentState__
		            );
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_10,*(undefined4 *)(*(int *)(*(int *)(param1 + 8) + 0x30) + 0x48),
		             Method_System_Collections_Generic_List_BossInfo_BossCultSpellData__GetEnumerator__);
		  local_18 = 0;
		  local_14 = &local_10;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar3 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_10,
		                       Method_System_Collections_Generic_List_Enumerator_BossInfo_BossCultSpellData__MoveNext__
		                      );
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80e01269:
		      iVar1 = global_1;
		      iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar1 == iVar3) {
		        piVar5 = (int *)import::env::__cxa_begin_catch(uVar2);
		        iVar3 = *piVar5;
		        DAT_ram_009d3e38 = 0;
		        local_18 = iVar3;
		        import::env::invoke_v(0x123);
		        iVar1 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar1 != 1) {
		          if (iVar3 != 0) {
		            System_Data_DataSet__ValidateLocaleConstraint(iVar3);
		            do {
		              halt_trap();
		            } while( true );
		          }
		code_r0x80e012bf:
		          DAT_ram_009d3e38 = 0;
		          Gameplay_Boss_View_RolesTab_BossRolesView__get_Spells
		                    (param2,*(undefined4 *)(*(int *)(*(int *)(param1 + 8) + 0x30) + 0x48),0);
		          uVar2 = System_Linq_Enumerable__ToList_object_
		                            (*(undefined4 *)(param2 + 0x4c),0,
		                             Method_System_Collections_Generic_List_BossInfo_BossCultSpellData__get_Item__
		                            );
		          Gameplay_Boss_Model_BossInfo_BossCultSpellData__get_SpellId(param2,uVar2,0);
		          return;
		        }
		        uVar2 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_000017c8 + 0x3ba,&local_18);
		      iVar1 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar1 == 1) {
		        import::env::__cxa_find_matching_catch_3(0);
		        unnamed_function_937();
		        do {
		          halt_trap();
		        } while( true );
		      }
		      import::env::__resumeException(uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    if (iVar3 == 0) goto code_r0x80e012bf;
		    iVar3 = local_8._4_4_;
		    DAT_ram_009d3e38 = 0;
		    iVar4 = import::env::invoke_iiii
		                      (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x3b9,
		                       *(undefined4 *)(param1 + 8),
		                       *(undefined4 *)(*(int *)(local_8._4_4_ + 8) + 0xc),auStack_20);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e01269;
		    }
		    uVar2 = *(undefined4 *)(iVar4 + 0xc);
		    if (*(int *)(System_Math_TypeInfo + 0x74) == 0) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi
		                (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,System_Math_TypeInfo);
		      iVar1 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar1 == 1) {
		        uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80e01269;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar2 = UnityEngine_Mathf__Max(uVar2,1,0);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e01269;
		    }
		    *(undefined4 *)(iVar3 + 0x10) = uVar2;
		  } while( true );
		}
		*/

		}

		// Token: 0x0600497B RID: 18811 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600497B")]
		[Address(RVA = "0x97ED", Offset = "0x97ED", VA = "0x97ED", Slot = "24")]
		protected override void SetupView(BossRolesView view)
		{
		/* --- GHIDRA: SetupView ---
		void Gameplay_Boss_Controller_BossRolesViewMediator__SetupView
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  
		  if (DAT_ram_00a5792b == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Core_Data_Spells_SpellData_Create_SpellData___);
		    DAT_ram_00a5792b = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(iVar1 + 0x2c);
		  uVar2 = Gameplay_Boss_View_CaptainTab_BossSkillInfoView__set_DominateCultDescription
		                    (*(undefined4 *)(param2 + 8),0);
		  Core_Extensions_Dict_PortalDicExt__GetCurrencyIcon60x66(uVar3,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  piVar4 = *(int **)(iVar1 + 0x28);
		  uVar2 = System_Collections_Generic_Dictionary_object__object____ctor
		                    (*(undefined4 *)(param2 + 8),0);
		  iVar1 = *piVar4;
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x2d0) * 4))
		            (piVar4,uVar2,*(undefined4 *)(iVar1 + 0x2d4));
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(iVar1 + 0x30);
		  uVar2 = Core_Extensions_Dict_SpellDicExt__GetAnimationOnAvatarCanvasAssetId
		                    (*(undefined4 *)(param2 + 0xc),0);
		  Gameplay_Antiq_View_Grid_GridList__SetData(uVar3,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_School_View_SpellTitle__set_Title
		            (*(undefined4 *)(iVar1 + 0x30),*(undefined4 *)(param2 + 0x10),0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(iVar1 + 0x30);
		  uVar2 = Core_Extensions_Dict_SpellDicExt__GetAssetId(*(undefined4 *)(param2 + 0xc),0);
		  Gameplay_School_View_SpellCurrentDescriptionTitledListElementArgs___ctor(uVar3,uVar2,0);
		  uVar2 = Core_Data_Spells_SpellData__Create_object_
		                    (*(undefined4 *)(*(int *)(param2 + 0xc) + 0xc),*(undefined4 *)(param2 + 0x10),
		                     Method_Core_Data_Spells_SpellData_Create_SpellData___);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Boss_View_RolesTab_BossRoleSpellDescription__get_Spell
		            (*(undefined4 *)(iVar1 + 0x34),uVar2,0);
		  return;
		}
		*/

		}

		// Token: 0x0600497C RID: 18812 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600497C")]
		[Address(RVA = "0x97EE", Offset = "0x97EE", VA = "0x97EE")]
		private void ViewOnSelectedEvent(BossInfo.BossCultSpellData cultSpell)
		{
		/* --- GHIDRA: ViewOnSelectedEvent ---
		void Gameplay_Boss_Controller_BossRolesViewMediator__ViewOnSelectedEvent
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  undefined4 uVar1;
		  int param2_00;
		  float fVar2;
		  int iVar3;
		  int param1_00;
		  undefined4 param4_00;
		  undefined4 param3_00;
		  longlong lVar4;
		  
		  if (DAT_ram_00a5792c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Boss_Controller_AbstractBossWindowViewMediator_BossTeamEditView___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_BossInstanceModel__BossInstanceEvents__BossInstanceController__BossTeamEditView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_UserData___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_UserData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Boss_Model_TeamData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    DAT_ram_00a5792c = '\x01';
		  }
		  uVar1 = unnamed_function_1417(System_Collections_Generic_List_UserData__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (uVar1,Method_System_Collections_Generic_List_UserData___ctor__);
		  *(undefined4 *)(param1 + 0x1c) = uVar1;
		  Core_Gameplay_Managers_Ad_Placements_AbstractAdPlacementManager_object__object__object___set_Model
		            (param1,param2,param3,param4,
		             Method_Gameplay_Boss_Controller_AbstractBossWindowViewMediator_BossTeamEditView___ctor__
		            );
		  param2_00 = Protocol_Boss_TeamInfo___ctor
		                        (*(undefined4 *)(*(int *)(*(int *)(param1 + 8) + 0x3c) + 0x34),0);
		  iVar3 = *(int *)(param1 + 8);
		  param1_00 = *(int *)(*(int *)(iVar3 + 0x3c) + 0xc);
		  if (param1_00 != 0) {
		    fVar2 = func_ii_7103(param1_00,0);
		    if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Utils_TimeUtils_TypeInfo);
		    }
		    if (ABS(fVar2) < 9.223372e+18) {
		      lVar4 = (longlong)fVar2;
		    }
		    else {
		      lVar4 = -0x8000000000000000;
		    }
		    fVar2 = Utils_TimeUtils__SecToMs(lVar4,0);
		    if (ABS(fVar2) < 9.223372e+18) {
		      lVar4 = (longlong)fVar2;
		    }
		    else {
		      lVar4 = -0x8000000000000000;
		    }
		    *(longlong *)(param2_00 + 0x30) = lVar4;
		    iVar3 = *(int *)(param1 + 8);
		  }
		  param4_00 = *(undefined4 *)(iVar3 + 8);
		  param3_00 = *(undefined4 *)(iVar3 + 0x30);
		  uVar1 = unnamed_function_1417(Gameplay_Boss_Model_TeamData_TypeInfo);
		  Gameplay_Boss_Model_TeamData__get_MyRatingPlace(uVar1,param2_00,param3_00,param4_00,param1);
		  *(undefined4 *)(param1 + 0x18) = uVar1;
		  return;
		}
		*/

		}
	}
}
