using System;
using Gameplay.AccountLinker.ProgressSaver.Model;
using Gameplay.AccountLinker.ProgressSaver.View;
using Il2CppDummyDll;
using MVC;
using Protocol.Auth2;

namespace Gameplay.AccountLinker.ProgressSaver.Controller
{
	// Token: 0x02000E13 RID: 3603
	[Token(Token = "0x2000E13")]
	public class ProgressSaverViewMediator : AbstractViewMediator<ProgressSaverModel, ProgressSaverEvents, ProgressSaverController, ProgressSaverView>
	{
		// Token: 0x060057D7 RID: 22487 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057D7")]
		[Address(RVA = "0xA54A", Offset = "0xA54A", VA = "0xA54A")]
		public ProgressSaverViewMediator(ProgressSaverModel model, ProgressSaverEvents events, ProgressSaverController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverViewMediator___ctor
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a63b5b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ProgressSaverModel__ProgressSaverEvents__ProgressSaverController__ProgressSaverView__set_View__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_Provider__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverViewMediator_HandleGpgsSigninButtonClickEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverViewMediator_HandleOnOAuthEvent__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a63b5b = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(iVar2 + 0x14);
		    uVar1 = unnamed_function_1417(System_Action_Provider__TypeInfo);
		    System_Action_int___Invoke
		              (uVar1,param1,
		               Method_Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverViewMediator_HandleOnOAuthEvent__
		               ,0);
		    Gameplay_AccountLinker_View_SignInVariants__add_OnOAuthEvent(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x14) + 0x1c) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverViewMediator_HandleGpgsSigninButtonClickEvent__
		               ,0);
		    UnityEngine_Events_UnityAction___ctor(uVar3,uVar1,0);
		  }
		  param1[5] = param2;
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(iVar2 + 0x14);
		    uVar1 = unnamed_function_1417(System_Action_Provider__TypeInfo);
		    System_Action_int___Invoke
		              (uVar1,param1,
		               Method_Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverViewMediator_HandleOnOAuthEvent__
		               ,0);
		    Gameplay_AccountLinker_View_SignInVariants__get_EmailOauthSignin(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x14) + 0x1c) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverViewMediator_HandleGpgsSigninButtonClickEvent__
		               ,0);
		    Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar3,uVar1,0);
		    Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverViewMediator__set_Events
		              (param1,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x170011EC RID: 4588
		// (set) Token: 0x060057D8 RID: 22488 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170011EC")]
		public override ProgressSaverView View
		{
			[Token(Token = "0x60057D8")]
			[Address(RVA = "0xA54B", Offset = "0xA54B", VA = "0xA54B", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x170011ED RID: 4589
		// (set) Token: 0x060057D9 RID: 22489 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170011ED")]
		public override ProgressSaverEvents Events
		{
			[Token(Token = "0x60057D9")]
			[Address(RVA = "0xA54C", Offset = "0xA54C", VA = "0xA54C", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x060057DA RID: 22490 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057DA")]
		[Address(RVA = "0xA54D", Offset = "0xA54D", VA = "0xA54D")]
		private void HandleSetupView()
		{
		/* --- GHIDRA: HandleSetupView ---
		void Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverViewMediator__HandleSetupView
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  uint uVar4;
		  int iVar5;
		  undefined4 uVar6;
		  int *piVar7;
		  undefined4 *puVar8;
		  int param1_00;
		  int iVar9;
		  int iVar10;
		  
		  if (DAT_ram_00a63b5e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ProgressSaverModel__ProgressSaverEvents__ProgressSaverController__ProgressSaverView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponentInParent_Button___);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_Button___);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_CanvasGroup___);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_Select_OAuthProviderInvoker__Provider___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToArray_Provider___);
		    Mono_Security_ASN1__get_Item(&System_Func_OAuthProviderInvoker__Provider__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_GameObject_AddComponent_CanvasGroup___);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_SignInVariants_States__set_CurrentState__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverViewMediator___c__UpdateSignState_b__6_0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverViewMediator___c_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&StringLiteral_13989);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12188);
		    Mono_Security_ASN1__get_Item(&StringLiteral_13721);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1217);
		    DAT_ram_00a63b5e = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (*(undefined4 *)(*(int *)(iVar2 + 0x14) + 0x38),1,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (*(undefined4 *)(*(int *)(iVar2 + 0x14) + 0x3c),0,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar6 = *(undefined4 *)(iVar2 + 0x14);
		  uVar3 = Gameplay_AccountLinker_ProgressSaver_Model_ProgressSaverModel__get_PlatformNick
		                    (param1[2],0);
		  Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		            (uVar6,uVar3,Method_UI_MonoBehaviourWithStates_SignInVariants_States__set_CurrentState__
		            );
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(iVar2 + 0x1c);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar2 = UnityEngine_Component__GetComponent_object_(uVar3,0);
		  if (iVar2 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    piVar7 = *(int **)(iVar2 + 0x1c);
		    uVar3 = Gameplay_AccountLinker_ProgressSaver_Model_ProgressSaverModel___ctor(param1[2],0);
		    iVar2 = *piVar7;
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0x2d0) * 4))
		              (piVar7,uVar3,*(undefined4 *)(iVar2 + 0x2d4));
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(iVar2 + 0x18);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar2 = UnityEngine_Component__GetComponent_object_(uVar3,0);
		  if (iVar2 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    piVar7 = *(int **)(iVar2 + 0x18);
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar3 = func_ii_7508(StringLiteral_13721,1,0,1,0,0,0,0);
		    iVar2 = *piVar7;
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0x2d0) * 4))
		              (piVar7,uVar3,*(undefined4 *)(iVar2 + 0x2d4));
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar6 = *(undefined4 *)(*(int *)(iVar2 + 0x14) + 0x24);
		  uVar3 = Gameplay_AccountLinker_ProgressSaver_Model_ProgressSaverModel__GetCurrentSigninState
		                    (param1[2],0);
		  TMPro_TMP_InputField__get_text(uVar6,uVar3,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar6 = *(undefined4 *)(*(int *)(iVar2 + 0x14) + 0x24);
		  uVar3 = Gameplay_AccountLinker_ProgressSaver_Model_ProgressSaverModel__GetCurrentSigninState
		                    (param1[2],0);
		  uVar3 = Newtonsoft_Json_Serialization_JsonSerializerInternalReader__ShouldDeserialize(uVar3,0);
		  System_Linq_Enumerable__First_object_(uVar6,uVar3,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar6 = *(undefined4 *)(*(int *)(iVar2 + 0x14) + 0x28);
		  uVar3 = Gameplay_AccountLinker_ProgressSaver_Model_ProgressSaverModel__GetCurrentSigninState
		                    (param1[2],0);
		  uVar3 = Newtonsoft_Json_Serialization_JsonSerializerInternalReader__ShouldDeserialize(uVar3,0);
		  System_Linq_Enumerable__First_object_(uVar6,uVar3,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(*(int *)(iVar2 + 0x14) + 0x20),0);
		  uVar4 = Gameplay_AccountLinker_ProgressSaver_Model_ProgressSaverModel__set_Email(param1[2],0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar3,uVar4 ^ 1,0);
		  uVar3 = Gameplay_AccountLinker_ProgressSaver_Model_ProgressSaverModel__GetCurrentSigninState
		                    (param1[2],0);
		  iVar2 = Newtonsoft_Json_Serialization_JsonSerializerInternalReader__ShouldDeserialize(uVar3,0);
		  if (iVar2 == 0) {
		    uVar4 = Gameplay_AccountLinker_ProgressSaver_Model_ProgressSaverModel__set_Email(param1[2],0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(iVar2 + 0x20),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar3,uVar4 ^ 1,0);
		    if (uVar4 == 0) {
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      uVar3 = *(undefined4 *)(iVar2 + 0x18);
		      if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		        func_ii_306000(UnityEngine_Object_TypeInfo);
		      }
		      iVar2 = UnityEngine_TextCore_Text_TextElement__get_textAsset(uVar3,0,0);
		      if (iVar2 != 0) {
		        iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0x15c));
		        uVar3 = UnityEngine_Component__GetComponentInChildren___Il2CppFullySharedGenericType_
		                          (*(undefined4 *)(iVar2 + 0x18),
		                           Method_UnityEngine_Component_GetComponentInParent_Button___);
		        if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		          func_ii_306000(UnityEngine_Object_TypeInfo);
		        }
		        iVar2 = UnityEngine_TextCore_Text_TextElement__get_textAsset(uVar3,0,0);
		        if (iVar2 != 0) {
		          uVar6 = func_ii_5677(uVar3,Method_UnityEngine_Component_GetComponent_CanvasGroup___);
		          if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		            func_ii_306000(UnityEngine_Object_TypeInfo);
		          }
		          iVar2 = func_ii_3812(uVar6,0,0);
		          if (iVar2 != 0) {
		            uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                              (uVar3,0);
		            uVar6 = UnityEngine_GameObject__GetComponent_object_
		                              (uVar3,Method_UnityEngine_GameObject_AddComponent_CanvasGroup___);
		          }
		          UnityEngine_CanvasGroup__get_interactable(uVar6,0,0);
		        }
		      }
		    }
		  }
		  else {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(iVar2 + 0x20),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar3,0,0);
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  piVar7 = *(int **)(iVar2 + 0x20);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar3 = func_ii_7508(StringLiteral_12188,1,0,1,0,0,0,0);
		  iVar2 = *piVar7;
		  (**(code **)((ulonglong)*(uint *)(iVar2 + 0x2d0) * 4))
		            (piVar7,uVar3,*(undefined4 *)(iVar2 + 0x2d4));
		  uVar3 = Gameplay_AccountLinker_ProgressSaver_Model_ProgressSaverModel__GetCurrentSigninState
		                    (param1[2],0);
		  iVar2 = Newtonsoft_Json_Serialization_JsonSerializerInternalReader__ShouldDeserialize(uVar3,0);
		  if (iVar2 == 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(iVar2 + 0x18);
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UnityEngine_Object_TypeInfo);
		    }
		    iVar2 = UnityEngine_Component__GetComponent_object_(uVar3,0);
		    if (iVar2 != 0) {
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      piVar7 = *(int **)(iVar2 + 0x18);
		      if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_GameLocalization_TypeInfo);
		      }
		      uVar3 = func_ii_7508(StringLiteral_13989,1,0,1,0,0,0,0);
		      iVar2 = *piVar7;
		      (**(code **)((ulonglong)*(uint *)(iVar2 + 0x2d0) * 4))
		                (piVar7,uVar3,*(undefined4 *)(iVar2 + 0x2d4));
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    TMPro_TMP_InputField__get_text
		              (*(undefined4 *)(*(int *)(iVar2 + 0x14) + 0x28),StringLiteral_1217,0);
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x14) + 0x34);
		  if (*(int *)(
		              Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverViewMediator___c_TypeInfo
		              + 0x74) == 0) {
		    func_ii_306000(
		                  Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverViewMediator___c_TypeInfo
		                  );
		  }
		  puVar8 = *(undefined4 **)
		            (Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverViewMediator___c_TypeInfo
		            + 0x5c);
		  iVar2 = puVar8[1];
		  if (iVar2 == 0) {
		    if (*(int *)(
		                Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverViewMediator___c_TypeInfo
		                + 0x74) == 0) {
		      func_ii_306000(
		                    Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverViewMediator___c_TypeInfo
		                    );
		      puVar8 = *(undefined4 **)
		                (
		                Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverViewMediator___c_TypeInfo
		                + 0x5c);
		    }
		    uVar6 = *puVar8;
		    iVar2 = unnamed_function_1417(System_Func_OAuthProviderInvoker__Provider__TypeInfo);
		    System_Action_object____ctor
		              (iVar2,uVar6,
		               Method_Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverViewMediator___c__UpdateSignState_b__6_0__
		               ,0);
		    *(int *)(*(int *)(
		                     Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverViewMediator___c_TypeInfo
		                     + 0x5c) + 4) = iVar2;
		  }
		  uVar3 = System_Linq_Enumerable__ReverseIterator___Il2CppFullySharedGenericType_
		                    (uVar3,iVar2,
		                     Method_System_Linq_Enumerable_Select_OAuthProviderInvoker__Provider___);
		  uVar3 = System_Linq_Enumerable__Select_object__Int32Enum_
		                    (uVar3,Method_System_Linq_Enumerable_ToArray_Provider___);
		  uVar6 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x14c));
		  iVar2 = Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverController__InvokeOAuth
		                    (uVar6,uVar3,0);
		  if (iVar2 != 0) {
		    iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    iVar5 = *(int *)(*(int *)(iVar5 + 0x14) + 0x34);
		    if (0 < *(int *)(iVar5 + 0xc)) {
		      iVar1 = 0;
		      do {
		        param1_00 = *(int *)(iVar5 + iVar1 * 4 + 0x10);
		        iVar9 = *(int *)(param1_00 + 0x10);
		        iVar10 = *(int *)(iVar2 + 0xc);
		        uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                          (param1_00,0);
		        Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                  (uVar3,(uint)(iVar9 == iVar10),0);
		        uVar3 = func_ii_5677(param1_00,Method_UnityEngine_Component_GetComponent_Button___);
		        System_Linq_Enumerable__First_object_(uVar3,(uint)(iVar9 != iVar10),0);
		        iVar1 = iVar1 + 1;
		      } while (iVar1 < *(int *)(iVar5 + 0xc));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x060057DB RID: 22491 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057DB")]
		[Address(RVA = "0xA54E", Offset = "0xA54E", VA = "0xA54E")]
		private void UpdateSignState()
		{
		/* --- GHIDRA: UpdateSignState ---
		void Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverViewMediator__UpdateSignState
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		  Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverController__SetEmailAndPassword
		            (param1_00,param2,0);
		  return;
		}
		*/

		}

		// Token: 0x060057DC RID: 22492 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057DC")]
		[Address(RVA = "0xA54F", Offset = "0xA54F", VA = "0xA54F")]
		private void HandleOnOAuthEvent(Provider provider)
		{
		}

		// Token: 0x060057DD RID: 22493 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057DD")]
		[Address(RVA = "0xA550", Offset = "0xA550", VA = "0xA550")]
		private void HandleGpgsSigninButtonClickEvent()
		{
		/* --- GHIDRA: HandleGpgsSigninButtonClickEvent ---
		void Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverViewMediator__HandleGpgsSigninButtonClickEvent
		               (undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param3;
		  
		  if (DAT_ram_00a63b5f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12189);
		    DAT_ram_00a63b5f = '\x01';
		  }
		  uVar1 = System_Uri___ctor(0);
		  uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar1,0);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  param3 = func_ii_7508(StringLiteral_12189,1,0,1,0,0,0,0);
		  Core_Application_App__get_ToastController(uVar1,1,param3,0);
		  return;
		}
		*/

		}

		// Token: 0x060057DE RID: 22494 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057DE")]
		[Address(RVA = "0xA551", Offset = "0xA551", VA = "0xA551")]
		private void HandleSetEmailPasswordSuccessEvent()
		{
		/* --- GHIDRA: HandleSetEmailPasswordSuccessEvent ---
		void Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverViewMediator__HandleSetEmailPasswordSuccessEvent
		               (undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverViewMediator__HandleSetupView
		            (param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x060057DF RID: 22495 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057DF")]
		[Address(RVA = "0xA552", Offset = "0xA552", VA = "0xA552")]
		private void HandleProgressSavedSuccessEvent()
		{
		/* --- GHIDRA: HandleProgressSavedSuccessEvent ---
		void Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverViewMediator__HandleProgressSavedSuccessEvent
		               (undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a63b60 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverViewMediator___c_TypeInfo
		              );
		    DAT_ram_00a63b60 = '\x01';
		  }
		  uVar1 = unnamed_function_1417
		                    (
		                    Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverViewMediator___c_TypeInfo
		                    );
		  **(undefined4 **)
		    (Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverViewMediator___c_TypeInfo + 0x5c)
		       = uVar1;
		  return;
		}
		*/

		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_View ---
		void Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverViewMediator__set_View
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a63b5c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ProgressSaverModel__ProgressSaverEvents__ProgressSaverController__ProgressSaverView__set_Events__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverViewMediator_HandleProgressSavedSuccessEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverViewMediator_HandleSetEmailPasswordSuccessEvent__
		              );
		    DAT_ram_00a63b5c = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x14);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverViewMediator_HandleSetEmailPasswordSuccessEvent__
		               ,0);
		    piVar4 = (int *)func_ii_7048(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x14) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x14) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x18);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverViewMediator_HandleProgressSavedSuccessEvent__
		               ,0);
		    piVar4 = (int *)func_ii_7048(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x18) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x18) = piVar4, *piVar4 != iVar1)) {
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
		    uVar5 = *(undefined4 *)(iVar2 + 0x14);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverViewMediator_HandleSetEmailPasswordSuccessEvent__
		               ,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x14) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x14) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x18);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverViewMediator_HandleProgressSavedSuccessEvent__
		               ,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x18) = 0;
		      return;
		    }
		    if ((System_Action_TypeInfo != *piVar4) || (*(int **)(iVar2 + 0x18) = piVar4, *piVar4 != iVar1))
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


		/* --- GHIDRA: set_Events ---
		void Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverViewMediator__set_Events
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  int *param2_00;
		  undefined4 uVar2;
		  int iVar3;
		  undefined4 uVar4;
		  
		  if (DAT_ram_00a63b5d == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UI_Tabs_TabBarItemData___TypeInfo);
		    Mono_Security_ASN1__get_Item(&UI_Tabs_TabBarItemData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12190);
		    DAT_ram_00a63b5d = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar4 = *(undefined4 *)(iVar1 + 0x10);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar1 = UnityEngine_Component__GetComponent_object_(uVar4,0);
		  if (iVar1 != 0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar4 = *(undefined4 *)(iVar1 + 0x10);
		    param2_00 = (int *)Mono_Security_ASN1Convert__ToOid(UI_Tabs_TabBarItemData___TypeInfo,1);
		    iVar1 = unnamed_function_1417(UI_Tabs_TabBarItemData_TypeInfo);
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar2 = func_ii_7508(StringLiteral_12190,1,0,1,0,0,0,0);
		    *(undefined4 *)(iVar1 + 0x10) = uVar2;
		    iVar3 = func_ii_1082(iVar1,*(undefined4 *)(*param2_00 + 0x20));
		    if (iVar3 == 0) {
		      uVar4 = func_ii_1083();
		      func_ii_1050(uVar4,0);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    param2_00[4] = iVar1;
		    UI_Tabs_TabBar__HandleSelected(uVar4,param2_00,0);
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    Gameplay_GameEvents_Model_GameEventData__get_ContainsArtifactRewards
		              (*(undefined4 *)(iVar1 + 0x10),0,0,0);
		  }
		  Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverViewMediator__HandleSetupView
		            (param1,param1);
		  return;
		}
		*/

}
