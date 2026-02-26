using System;
using Gameplay.Boss.Events;
using Gameplay.Boss.Model;
using Gameplay.Boss.View.GuestTab;
using Il2CppDummyDll;

namespace Gameplay.Boss.Controller
{
	// Token: 0x02000BA5 RID: 2981
	[Token(Token = "0x2000BA5")]
	public class BossGuestViewMediator : AbstractBossWindowViewMediator<BossGuestView>
	{
		// Token: 0x060048E9 RID: 18665 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048E9")]
		[Address(RVA = "0x975C", Offset = "0x975C", VA = "0x975C")]
		public BossGuestViewMediator(BossInstanceModel model, BossInstanceEvents events, BossInstanceController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Boss_Controller_BossGuestViewMediator___ctor
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  int param2_00;
		  undefined4 param1_00;
		  int *param1_01;
		  undefined4 param1_02;
		  
		  if (DAT_ram_00a578c0 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Boss_Controller_BossGuestViewMediator_HealthChangedEvent__);
		    DAT_ram_00a578c0 = '\x01';
		  }
		  param1_02 = *(undefined4 *)(param2 + 0x18);
		  param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_00,param1,
		             Method_Gameplay_Boss_Controller_BossGuestViewMediator_HealthChangedEvent__,0);
		  param1_01 = (int *)func_ii_7048(param1_02,param1_00,0);
		  param2_00 = System_Action_TypeInfo;
		  if (param1_01 == (int *)0x0) {
		    *(undefined4 *)(param2 + 0x18) = 0;
		    return;
		  }
		  if ((System_Action_TypeInfo == *param1_01) &&
		     (*(int **)(param2 + 0x18) = param1_01, *param1_01 == param2_00)) {
		    return;
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x060048EA RID: 18666 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048EA")]
		[Address(RVA = "0x975D", Offset = "0x975D", VA = "0x975D", Slot = "21")]
		protected override void ResetEvents(BossInstanceEvents events)
		{
		/* --- GHIDRA: ResetEvents ---
		void Gameplay_Boss_Controller_BossGuestViewMediator__ResetEvents
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  int param2_00;
		  undefined4 param1_00;
		  int *param1_01;
		  undefined4 param1_02;
		  
		  if (DAT_ram_00a578c1 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Boss_Controller_BossGuestViewMediator_HealthChangedEvent__);
		    DAT_ram_00a578c1 = '\x01';
		  }
		  param1_02 = *(undefined4 *)(param2 + 0x18);
		  param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_00,param1,
		             Method_Gameplay_Boss_Controller_BossGuestViewMediator_HealthChangedEvent__,0);
		  param1_01 = (int *)UnityEngine_UI_Image__set_sprite(param1_02,param1_00,0);
		  param2_00 = System_Action_TypeInfo;
		  if (param1_01 == (int *)0x0) {
		    *(undefined4 *)(param2 + 0x18) = 0;
		    return;
		  }
		  if ((System_Action_TypeInfo == *param1_01) &&
		     (*(int **)(param2 + 0x18) = param1_01, *param1_01 == param2_00)) {
		    return;
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x060048EB RID: 18667 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048EB")]
		[Address(RVA = "0x975E", Offset = "0x975E", VA = "0x975E", Slot = "22")]
		protected override void SetupEvents(BossInstanceEvents events)
		{
		/* --- GHIDRA: SetupEvents ---
		void Gameplay_Boss_Controller_BossGuestViewMediator__SetupEvents
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a578c2 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Boss_Controller_BossGuestViewMediator_SkillInfoButtonClickHandler__)
		    ;
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a578c2 = '\x01';
		  }
		  param1_01 = *(undefined4 *)(*(int *)(*(int *)(param2 + 0x24) + 0x1c) + 0xb4);
		  param1_00 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (param1_00,param1,
		             Method_Gameplay_Boss_Controller_BossGuestViewMediator_SkillInfoButtonClickHandler__,0);
		  UnityEngine_Events_UnityAction___ctor(param1_01,param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x060048EC RID: 18668 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048EC")]
		[Address(RVA = "0x975F", Offset = "0x975F", VA = "0x975F", Slot = "23")]
		protected override void ResetView(BossGuestView view)
		{
		/* --- GHIDRA: ResetView ---
		void Gameplay_Boss_Controller_BossGuestViewMediator__ResetView
		               (int param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  undefined4 param1_00;
		  undefined4 uVar5;
		  int *piVar6;
		  int iVar7;
		  undefined4 param4;
		  int iVar8;
		  undefined4 local_8;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a578c3 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_AssetContent_Loaders_AbstractGameGraphicLoader_Image__Sprite__set_AssetId__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_BossInstanceModel__BossInstanceEvents__BossInstanceController__BossGuestView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Boss_Controller_BossGuestViewMediator_SkillInfoButtonClickHandler__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_string__string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Core_Gameplay_Managers_Requirements_RequirementsInfoProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3637);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22108);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3651);
		    DAT_ram_00a578c3 = '\x01';
		  }
		  uVar5 = *(undefined4 *)(param2 + 0x2c);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  piVar6 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x178);
		        goto code_r0x80df5d4f;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80df5d4f:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar6,puVar2[1]);
		  piVar6 = (int *)Mono_Security_ASN1Convert__ToOid(object___TypeInfo,2);
		  local_4 = *(undefined4 *)(*(int *)(*(int *)(*(int *)(param1 + 8) + 0x30) + 0x14) + 0xc);
		  iVar7 = func_ii_1081(DAT_ram_00a66958,&local_4);
		  if ((iVar7 != 0) && (iVar8 = func_ii_1082(iVar7,*(undefined4 *)(*piVar6 + 0x20)), iVar8 == 0)) {
		    uVar5 = func_ii_1083();
		    func_ii_1050(uVar5,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar6[4] = iVar7;
		  local_8 = *(undefined4 *)(*(int *)(*(int *)(param1 + 8) + 0x28) + 0x18);
		  iVar7 = func_ii_1081(DAT_ram_00a66954,&local_8);
		  if ((iVar7 != 0) && (iVar8 = func_ii_1082(iVar7,*(undefined4 *)(*piVar6 + 0x20)), iVar8 == 0)) {
		    uVar5 = func_ii_1083();
		    func_ii_1050(uVar5,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar6[5] = iVar7;
		  UI_MonoBehaviourWithStates_Int32Enum___set_CurrentState(uVar5,uVar3,piVar6,0);
		  uVar3 = *(undefined4 *)(*(int *)(*(int *)(param2 + 0x24) + 0x1c) + 0xb4);
		  uVar5 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar5,param1,
		             Method_Gameplay_Boss_Controller_BossGuestViewMediator_SkillInfoButtonClickHandler__,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar3,uVar5,0);
		  uVar3 = *(undefined4 *)(*(int *)(param2 + 0x24) + 0x18);
		  uVar5 = UI_Wiki_WikiUriRouter__SetData
		                    (*(undefined4 *)(*(int *)(*(int *)(param1 + 8) + 0x30) + 8),0);
		  Core_Extensions_Dict_AprDicExt__Get1024AssetId(uVar3,uVar5,0);
		  uVar3 = *(undefined4 *)(*(int *)(param2 + 0x24) + 0x10);
		  uVar5 = AssetContent_GameAssetViewRawImage__set_AssetId
		                    (*(undefined4 *)(*(int *)(*(int *)(param1 + 8) + 0x30) + 0x14),0);
		  Core_Extensions_Dict_MonsterDictExt__GetTitle(uVar3,uVar5,0);
		  UI_Elements_RightPanel_TitleWithLevel__set_Title
		            (*(undefined4 *)(*(int *)(param2 + 0x24) + 0x10),
		             *(undefined4 *)(*(int *)(*(int *)(*(int *)(param1 + 8) + 0x30) + 0x14) + 0x14),0);
		  UI_Elements_RightPanel_TitleWithLevel__set_Level
		            (*(undefined4 *)(*(int *)(param2 + 0x24) + 0x24),
		             *(undefined4 *)(*(int *)(param1 + 8) + 0x34),0);
		  iVar7 = *(int *)(*(int *)(param2 + 0x24) + 0x2c);
		  iVar8 = *(int *)(*(int *)(param1 + 8) + 0x30);
		  *(undefined4 *)(iVar7 + 0x30) = *(undefined4 *)(iVar8 + 0x40);
		  uVar5 = Gameplay_Boss_View_CaptainTab_BossInfoView__set_AttackOptions
		                    (*(undefined4 *)(iVar8 + 0x14),0);
		  Core_Extensions_Dict_MonsterDictExt__GetDescription(iVar7,uVar5,0);
		  iVar7 = *(int *)(*(int *)(*(int *)(param1 + 8) + 0x30) + 0x18);
		  if (iVar7 == 0) {
		    uVar5 = *(undefined4 *)(*(int *)(param2 + 0x24) + 0x2c);
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar3 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_3651,1,0,1,0,0,0,0);
		    Core_Extensions_StringExt__Replacer(uVar5,uVar3,0);
		  }
		  else {
		    uVar5 = unnamed_function_1417(System_Collections_Generic_Dictionary_string__string__TypeInfo);
		    System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		              (uVar5,Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		    uVar3 = System_Collections_Generic_Dictionary_object__object____ctor
		                      (*(undefined4 *)(*(int *)(*(int *)(param1 + 8) + 0x30) + 0x18),0);
		    System_Reflection_FieldInfo__get_IsStatic
		              (uVar5,StringLiteral_22108,uVar3,
		               Method_System_Collections_Generic_Dictionary_string__string__Add__);
		    uVar3 = *(undefined4 *)(*(int *)(param2 + 0x24) + 0x2c);
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar4 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_3637,1,0,1,0,0,0,0);
		    uVar5 = Core_GameLocalization__GetTranslation(uVar4,uVar5,0);
		    Core_Extensions_StringExt__Replacer(uVar3,uVar5,0);
		    uVar3 = *(undefined4 *)(*(int *)(param2 + 0x24) + 0x30);
		    uVar5 = Gameplay_Boss_View_CaptainTab_BossSkillInfoView__set_DominateCultDescription
		                      (*(undefined4 *)(*(int *)(*(int *)(param1 + 8) + 0x30) + 0x18),0);
		    Core_Extensions_Dict_CultDicExt__GetIcon64AssetId
		              (uVar3,uVar5,
		               Method_AssetContent_Loaders_AbstractGameGraphicLoader_Image__Sprite__set_AssetId__);
		  }
		  uVar5 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(*(int *)(param2 + 0x24) + 0x30),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar5,(uint)(iVar7 != 0),0);
		  uVar5 = *(undefined4 *)(param2 + 0x28);
		  uVar3 = *(undefined4 *)(*(int *)(param1 + 8) + 8);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar6 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x140);
		        goto code_r0x80df609c;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x80df609c:
		  uVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar6,puVar2[1]);
		  uVar4 = func_ii_7112(uVar4,0);
		  param4 = *(undefined4 *)(*(int *)(*(int *)(*(int *)(param1 + 8) + 0x30) + 0x10) + 0x14);
		  param1_00 = unnamed_function_1417
		                        (Core_Gameplay_Managers_Requirements_RequirementsInfoProvider_TypeInfo);
		  Core_Gameplay_Managers_Requirements_RequirementsInfoProvider___ctor
		            (param1_00,uVar3,uVar4,param4,0);
		  UI_Requirements_RequirementsView__get_Data(uVar5,param1_00,0);
		  Gameplay_Boss_Controller_BossGuestViewMediator__SkillInfoButtonClickHandler(param1,uVar4);
		  return;
		}
		*/

		}

		// Token: 0x060048ED RID: 18669 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048ED")]
		[Address(RVA = "0x9760", Offset = "0x9760", VA = "0x9760", Slot = "24")]
		protected override void SetupView(BossGuestView view)
		{
		/* --- GHIDRA: SetupView ---
		void Gameplay_Boss_Controller_BossGuestViewMediator__SetupView(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_UserInfo_View_BaseInfoBox__HandleVisibleChanged
		            (*(undefined4 *)(*(int *)(iVar1 + 0x24) + 0x2c),0);
		  return;
		}
		*/

		}

		// Token: 0x060048EE RID: 18670 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048EE")]
		[Address(RVA = "0x9761", Offset = "0x9761", VA = "0x9761")]
		private void SkillInfoButtonClickHandler()
		{
		/* --- GHIDRA: SkillInfoButtonClickHandler ---
		void Gameplay_Boss_Controller_BossGuestViewMediator__SkillInfoButtonClickHandler
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 in_register_20000004;
		  undefined8 uVar1;
		  undefined4 in_register_20000014;
		  undefined8 uVar2;
		  undefined4 uVar3;
		  undefined4 param1_00;
		  int iVar4;
		  float fVar5;
		  undefined4 uVar6;
		  ulonglong uVar7;
		  int *piVar8;
		  ulonglong uVar9;
		  
		  if (DAT_ram_00a578c4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_BossInstanceModel__BossInstanceEvents__BossInstanceController__BossGuestView__get_Model__
		              );
		    DAT_ram_00a578c4 = '\x01';
		  }
		  uVar1 = CONCAT44(in_register_20000004,param1);
		  uVar2 = CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x15c));
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))(uVar1,uVar2);
		  uVar6 = (undefined4)((ulonglong)uVar1 >> 0x20);
		  uVar3 = (undefined4)((ulonglong)uVar2 >> 0x20);
		  iVar4 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(param1_00,0);
		  if (iVar4 != 0) {
		    uVar1 = CONCAT44(uVar6,param1);
		    uVar2 = CONCAT44(uVar3,*(undefined4 *)(*param1 + 0x15c));
		    iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))(uVar1,uVar2);
		    piVar8 = *(int **)(*(int *)(iVar4 + 0x24) + 0x14);
		    uVar9 = *(ulonglong *)(*(int *)(param1[2] + 0x28) + 0x28);
		    uVar6 = (undefined4)((ulonglong)uVar1 >> 0x20);
		    uVar3 = (undefined4)((ulonglong)uVar2 >> 0x20);
		    uVar7 = Gameplay_Boss_Model_BossInfo__get_HasLossReward
		                      (*(undefined4 *)(param1[2] + 0x30),param1);
		    fVar5 = UnityEngine_Camera__set_orthographicSize((float)uVar9,(float)uVar7,0);
		    iVar4 = *piVar8;
		    (**(code **)((ulonglong)*(uint *)(iVar4 + 0x108) * 4))
		              (CONCAT44(uVar6,piVar8),CONCAT44(uVar3,fVar5),*(undefined4 *)(iVar4 + 0x10c));
		    iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    piVar8 = *(int **)(*(int *)(iVar4 + 0x24) + 0x34);
		    iVar4 = param1[2];
		    if (DAT_ram_00a57880 == '\0') {
		      Mono_Security_ASN1__get_Item(&Utils_StringUtils_TypeInfo);
		      DAT_ram_00a57880 = '\x01';
		    }
		    uVar9 = *(ulonglong *)(*(int *)(iVar4 + 0x28) + 0x28);
		    uVar7 = Gameplay_Boss_Model_BossInfo__get_HasLossReward(*(undefined4 *)(iVar4 + 0x30),iVar4);
		    if (*(int *)(Utils_StringUtils_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Utils_StringUtils_TypeInfo);
		    }
		    uVar6 = Utils_StringUtils__GetRomanNumber((double)uVar9,(double)uVar7,0);
		    iVar4 = *piVar8;
		    (**(code **)((ulonglong)*(uint *)(iVar4 + 0x2d0) * 4))
		              (piVar8,uVar6,*(undefined4 *)(iVar4 + 0x2d4));
		  }
		  return;
		}
		*/

		}

		// Token: 0x060048EF RID: 18671 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048EF")]
		[Address(RVA = "0x9762", Offset = "0x9762", VA = "0x9762")]
		private void HealthChangedEvent()
		{
		/* --- GHIDRA: HealthChangedEvent ---
		void Gameplay_Boss_Controller_BossGuestViewMediator__HealthChangedEvent
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a578c5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_MVC_AbstractController_BossInstanceModel__BossInstanceEvents___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_BossService___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    DAT_ram_00a578c5 = '\x01';
		  }
		  Gameplay_Combat_AbstractCombat_object__object__object__object__object___set_User
		            (param1,param2,param3,
		             Method_MVC_AbstractController_BossInstanceModel__BossInstanceEvents___ctor__);
		  if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		  }
		  uVar1 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_BossService___);
		  *(undefined4 *)(param1 + 0x18) = uVar1;
		  return;
		}
		*/

		}
	}
}
