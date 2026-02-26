using System;
using Core.Dict.DictWrappers.Wrappers;
using Gameplay.UserInfo.Model;
using Gameplay.UserInfo.View;
using Google.Protobuf.Collections;
using Il2CppDummyDll;
using MVC;
using UI.Windows;

namespace Gameplay.UserInfo.Control
{
	// Token: 0x0200041C RID: 1052
	[Token(Token = "0x200041C")]
	public class UserInfoEditViewMediator : AbstractViewMediator<UserInfoModel, UserInfoEvents, UserInfoController, CultGenderNickSettingsView>
	{
		// Token: 0x060018B3 RID: 6323 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018B3")]
		[Address(RVA = "0x6A52", Offset = "0x6A52", VA = "0x6A52")]
		public UserInfoEditViewMediator(UserInfoModel model, UserInfoEvents events, UserInfoController controller)
		{
		/* --- GHIDRA: <ShowConfirmChangeCult>b__22_0 ---
		void Gameplay_UserInfo_Control_UserInfoEditViewMediator___ShowConfirmChangeCult_b__22_0
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5,undefined4 param6)
		
		{
		  if (DAT_ram_00a59937 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractCozyViewMediator_UserInfoModel__UserInfoEvents__UserInfoController__UserInfoView___ctor__
		              );
		    DAT_ram_00a59937 = '\x01';
		  }
		  MVC_AbstractCozyViewMediator_object__object__object__object____ctor
		            (param1,param2,param3,param4,param5,
		             Method_MVC_AbstractCozyViewMediator_UserInfoModel__UserInfoEvents__UserInfoController__UserInfoView___ctor__
		            );
		  return;
		}
		*/

		/* --- GHIDRA: .ctor ---
		void Gameplay_UserInfo_Control_UserInfoEditViewMediator___ctor(int *param1,undefined4 param2)
		
		{
		  int *piVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a59929 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_UserInfoModel__UserInfoEvents__UserInfoController__CultGenderNickSettingsView__Dispose__
		              );
		    DAT_ram_00a59929 = '\x01';
		  }
		  piVar1 = (int *)(**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                            (param1,*(undefined4 *)(*param1 + 0x14c));
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x100) * 4))
		                    (piVar1,*(undefined4 *)(*piVar1 + 0x104));
		  *(undefined4 *)(iVar2 + 0x34) = 0;
		  MVC_AbstractViewMediator_object__object__object__object___Core_MVC_Interfaces_IViewMediator_set_View
		            (param1,
		             Method_MVC_AbstractViewMediator_UserInfoModel__UserInfoEvents__UserInfoController__CultGenderNickSettingsView__Dispose__
		            );
		  return;
		}
		*/

		}

		// Token: 0x060018B4 RID: 6324 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018B4")]
		[Address(RVA = "0x6A53", Offset = "0x6A53", VA = "0x6A53", Slot = "14")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_UserInfo_Control_UserInfoEditViewMediator__Dispose
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  int *piVar5;
		  undefined4 uVar6;
		  
		  if (DAT_ram_00a5992a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_UserInfoModel__UserInfoEvents__UserInfoController__CultGenderNickSettingsView__set_Events__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_string__RepeatedField_string___TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_UserInfo_Control_UserInfoEditViewMediator_HandleUserNickGenerateCompleteEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_UserInfo_Control_UserInfoEditViewMediator_HandleUserNickPriceChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_UserInfo_Control_UserInfoEditViewMediator_HandleUserNickVariantsCompleteEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_UserInfo_Control_UserInfoEditViewMediator_UserAprSelectedEvent__);
		    DAT_ram_00a5992a = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar1 + 0x34);
		    uVar2 = unnamed_function_1417(System_Action_string__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar2,param1,
		               Method_Gameplay_UserInfo_Control_UserInfoEditViewMediator_HandleUserNickGenerateCompleteEvent__
		               ,0);
		    iVar3 = func_ii_7048(uVar6,uVar2,0);
		    uVar2 = System_Action_string__TypeInfo;
		    if (iVar3 == 0) {
		      *(undefined4 *)(iVar1 + 0x34) = 0;
		    }
		    else {
		      iVar4 = func_ii_1082(iVar3,System_Action_string__TypeInfo);
		      if (iVar4 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x34) = iVar4;
		      uVar2 = System_Action_string__TypeInfo;
		      iVar1 = func_ii_1082(iVar3,System_Action_string__TypeInfo);
		      if (iVar1 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar1 + 0x38);
		    uVar2 = unnamed_function_1417(System_Action_string__RepeatedField_string___TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,
		               Method_Gameplay_UserInfo_Control_UserInfoEditViewMediator_HandleUserNickVariantsCompleteEvent__
		               ,0);
		    iVar3 = func_ii_7048(uVar6,uVar2,0);
		    uVar2 = System_Action_string__RepeatedField_string___TypeInfo;
		    if (iVar3 == 0) {
		      *(undefined4 *)(iVar1 + 0x38) = 0;
		    }
		    else {
		      iVar4 = func_ii_1082(iVar3,System_Action_string__RepeatedField_string___TypeInfo);
		      if (iVar4 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x38) = iVar4;
		      uVar2 = System_Action_string__RepeatedField_string___TypeInfo;
		      iVar1 = func_ii_1082(iVar3,System_Action_string__RepeatedField_string___TypeInfo);
		      if (iVar1 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar3 + 0x2c);
		    uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar2,param1,
		               Method_Gameplay_UserInfo_Control_UserInfoEditViewMediator_HandleUserNickPriceChangedEvent__
		               ,0);
		    piVar5 = (int *)func_ii_7048(uVar6,uVar2,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar5 == (int *)0x0) {
		      *(undefined4 *)(iVar3 + 0x2c) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar5) ||
		            (*(int **)(iVar3 + 0x2c) = piVar5, *piVar5 != iVar1)) {
		      System_Activator__CreateInstance(piVar5,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar3 + 0x30);
		    uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar2,param1,
		               Method_Gameplay_UserInfo_Control_UserInfoEditViewMediator_UserAprSelectedEvent__,0);
		    piVar5 = (int *)func_ii_7048(uVar6,uVar2,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar5 == (int *)0x0) {
		      *(undefined4 *)(iVar3 + 0x30) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar5) ||
		            (*(int **)(iVar3 + 0x30) = piVar5, *piVar5 != iVar1)) {
		      System_Activator__CreateInstance(piVar5,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  param1[3] = param2;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar1 + 0x34);
		    uVar2 = unnamed_function_1417(System_Action_string__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar2,param1,
		               Method_Gameplay_UserInfo_Control_UserInfoEditViewMediator_HandleUserNickGenerateCompleteEvent__
		               ,0);
		    iVar3 = UnityEngine_UI_Image__set_sprite(uVar6,uVar2,0);
		    uVar2 = System_Action_string__TypeInfo;
		    if (iVar3 == 0) {
		      *(undefined4 *)(iVar1 + 0x34) = 0;
		    }
		    else {
		      iVar4 = func_ii_1082(iVar3,System_Action_string__TypeInfo);
		      if (iVar4 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x34) = iVar4;
		      uVar2 = System_Action_string__TypeInfo;
		      iVar1 = func_ii_1082(iVar3,System_Action_string__TypeInfo);
		      if (iVar1 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar1 + 0x38);
		    uVar2 = unnamed_function_1417(System_Action_string__RepeatedField_string___TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,
		               Method_Gameplay_UserInfo_Control_UserInfoEditViewMediator_HandleUserNickVariantsCompleteEvent__
		               ,0);
		    iVar3 = UnityEngine_UI_Image__set_sprite(uVar6,uVar2,0);
		    uVar2 = System_Action_string__RepeatedField_string___TypeInfo;
		    if (iVar3 == 0) {
		      *(undefined4 *)(iVar1 + 0x38) = 0;
		    }
		    else {
		      iVar4 = func_ii_1082(iVar3,System_Action_string__RepeatedField_string___TypeInfo);
		      if (iVar4 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x38) = iVar4;
		      uVar2 = System_Action_string__RepeatedField_string___TypeInfo;
		      iVar1 = func_ii_1082(iVar3,System_Action_string__RepeatedField_string___TypeInfo);
		      if (iVar1 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar3 + 0x2c);
		    uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar2,param1,
		               Method_Gameplay_UserInfo_Control_UserInfoEditViewMediator_HandleUserNickPriceChangedEvent__
		               ,0);
		    piVar5 = (int *)UnityEngine_UI_Image__set_sprite(uVar6,uVar2,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar5 == (int *)0x0) {
		      *(undefined4 *)(iVar3 + 0x2c) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar5) ||
		            (*(int **)(iVar3 + 0x2c) = piVar5, *piVar5 != iVar1)) {
		      System_Activator__CreateInstance(piVar5,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar3 + 0x30);
		    uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar2,param1,
		               Method_Gameplay_UserInfo_Control_UserInfoEditViewMediator_UserAprSelectedEvent__,0);
		    piVar5 = (int *)UnityEngine_UI_Image__set_sprite(uVar6,uVar2,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar5 == (int *)0x0) {
		      *(undefined4 *)(iVar3 + 0x30) = 0;
		      return;
		    }
		    if ((System_Action_TypeInfo != *piVar5) || (*(int **)(iVar3 + 0x30) = piVar5, *piVar5 != iVar1))
		    {
		      System_Activator__CreateInstance(piVar5,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x17000459 RID: 1113
		// (set) Token: 0x060018B5 RID: 6325 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000459")]
		public override UserInfoEvents Events
		{
			[Token(Token = "0x60018B5")]
			[Address(RVA = "0x6A54", Offset = "0x6A54", VA = "0x6A54", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x060018B6 RID: 6326 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018B6")]
		[Address(RVA = "0x6A55", Offset = "0x6A55", VA = "0x6A55")]
		private void HandleUserNickPriceChangedEvent()
		{
		/* --- GHIDRA: HandleUserNickPriceChangedEvent ---
		void Gameplay_UserInfo_Control_UserInfoEditViewMediator__HandleUserNickPriceChangedEvent
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 param2_00;
		  int iVar1;
		  
		  if (DAT_ram_00a5992c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_AprDic__uint__get_Data__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_UserInfoModel__UserInfoEvents__UserInfoController__CultGenderNickSettingsView__get_Model__
		              );
		    DAT_ram_00a5992c = '\x01';
		  }
		  param2_00 = UI_Wiki_WikiUriRouter__SetData(*(undefined4 *)(*(int *)(param1[2] + 0x34) + 0x10),0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Core_Extensions_Dict_AprDicExt__Get1024AssetId(*(undefined4 *)(iVar1 + 0x10),param2_00,0);
		  return;
		}
		*/

		}

		// Token: 0x060018B7 RID: 6327 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018B7")]
		[Address(RVA = "0x6A56", Offset = "0x6A56", VA = "0x6A56")]
		private void UserAprSelectedEvent()
		{
		/* --- GHIDRA: UserAprSelectedEvent ---
		void Gameplay_UserInfo_Control_UserInfoEditViewMediator__UserAprSelectedEvent
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a5992d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_UserInfoModel__UserInfoEvents__UserInfoController__CultGenderNickSettingsView__set_View__
		              );
		    DAT_ram_00a5992d = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    Gameplay_UserInfo_Control_UserInfoEditViewMediator__set_View(param1,param1);
		  }
		  param1[5] = param2;
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    Gameplay_UserInfo_Control_UserInfoEditViewMediator__ResetView(param1,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x1700045A RID: 1114
		// (set) Token: 0x060018B8 RID: 6328 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700045A")]
		public override CultGenderNickSettingsView View
		{
			[Token(Token = "0x60018B8")]
			[Address(RVA = "0x6A57", Offset = "0x6A57", VA = "0x6A57", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x060018B9 RID: 6329 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018B9")]
		[Address(RVA = "0x6A58", Offset = "0x6A58", VA = "0x6A58")]
		private void ResetView()
		{
		/* --- GHIDRA: ResetView ---
		void Gameplay_UserInfo_Control_UserInfoEditViewMediator__ResetView(int *param1,undefined4 param2)
		
		{
		  bool bVar1;
		  int param1_00;
		  int iVar2;
		  undefined4 uVar3;
		  int *param1_01;
		  int iVar4;
		  undefined4 uVar5;
		  undefined4 uVar6;
		  undefined4 local_8;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5992f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_UserInfoModel__UserInfoEvents__UserInfoController__CultGenderNickSettingsView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Events_UnityEvent_bool__AddListener__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_UserInfo_Control_UserInfoEditViewMediator_HandleChangeCultGenderButtonClickEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_UserInfo_Control_UserInfoEditViewMediator_HandleChangeNickButtonClickEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_UserInfo_Control_UserInfoEditViewMediator_HandleGenerateNickButtonClickEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_UserInfo_Control_UserInfoEditViewMediator_HandleHideAprsCheckBoxValueChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_UserInfo_Control_UserInfoEditViewMediator_HandleHideMedalsCheckBoxValueChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_UserInfo_Control_UserInfoEditViewMediator_HandleOnGenderOrCultSelected__
		              );
		    DAT_ram_00a5992f = '\x01';
		  }
		  local_4 = 0;
		  local_8 = 0;
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar5 = *(undefined4 *)(*(int *)(iVar2 + 0x24) + 0xb4);
		  uVar3 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar3,param1,
		             Method_Gameplay_UserInfo_Control_UserInfoEditViewMediator_HandleChangeNickButtonClickEvent__
		             ,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar5,uVar3,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar5 = *(undefined4 *)(*(int *)(iVar2 + 0x20) + 0xb4);
		  uVar3 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar3,param1,
		             Method_Gameplay_UserInfo_Control_UserInfoEditViewMediator_HandleChangeCultGenderButtonClickEvent__
		             ,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar5,uVar3,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar5 = *(undefined4 *)(*(int *)(iVar2 + 0x28) + 0xb4);
		  uVar3 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar3,param1,
		             Method_Gameplay_UserInfo_Control_UserInfoEditViewMediator_HandleGenerateNickButtonClickEvent__
		             ,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar5,uVar3,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar3,param1,
		             Method_Gameplay_UserInfo_Control_UserInfoEditViewMediator_HandleOnGenderOrCultSelected__
		             ,0);
		  if (DAT_ram_00a598c8 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a598c8 = '\x01';
		  }
		  param1_00 = *(int *)(iVar2 + 0x58);
		  while ((param1_01 = (int *)UnityEngine_UI_Image__set_sprite(param1_00,uVar3,0),
		         param1_01 == (int *)0x0 || (System_Action_TypeInfo == *param1_01))) {
		    iVar4 = func_ii_4329(iVar2 + 0x58,param1_01,param1_00);
		    bVar1 = iVar4 == param1_00;
		    param1_00 = iVar4;
		    if (bVar1) {
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      uVar5 = *(undefined4 *)(*(int *)(iVar2 + 0x4c) + 0xc0);
		      uVar3 = unnamed_function_1417(UnityEngine_Events_UnityAction_bool__TypeInfo);
		      UnityEngine_UI_Toggle__set_group
		                (uVar3,param1,
		                 Method_Gameplay_UserInfo_Control_UserInfoEditViewMediator_HandleHideMedalsCheckBoxValueChangedEvent__
		                 ,0);
		      UnityEngine_Events_UnityEvent_InputAction_CallbackContext____ctor
		                (uVar5,uVar3,Method_UnityEngine_Events_UnityEvent_bool__AddListener__);
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      uVar5 = *(undefined4 *)(*(int *)(iVar2 + 0x50) + 0xc0);
		      uVar3 = unnamed_function_1417(UnityEngine_Events_UnityAction_bool__TypeInfo);
		      UnityEngine_UI_Toggle__set_group
		                (uVar3,param1,
		                 Method_Gameplay_UserInfo_Control_UserInfoEditViewMediator_HandleHideAprsCheckBoxValueChangedEvent__
		                 ,0);
		      UnityEngine_Events_UnityEvent_InputAction_CallbackContext____ctor
		                (uVar5,uVar3,Method_UnityEngine_Events_UnityEvent_bool__AddListener__);
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      *(undefined4 *)(iVar2 + 0x5c) = *(undefined4 *)(param1[2] + 8);
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      *(undefined4 *)(iVar2 + 100) = *(undefined4 *)(param1[2] + 0x18);
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      *(undefined4 *)(iVar2 + 0x60) = *(undefined4 *)(param1[2] + 0x20);
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      uVar3 = *(undefined4 *)(iVar2 + 0x3c);
		      uVar5 = *(undefined4 *)(param1[2] + 8);
		      iVar2 = Gameplay_UserInfo_Model_UserInfoModel__set_Game(param1[2],uVar3);
		      uVar6 = *(undefined4 *)(*(int *)(iVar2 + 0xc) + 0x18);
		      if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_Money_Money_TypeInfo);
		      }
		      uVar6 = Core_Money_Money__op_Explicit(uVar6,0);
		      UI_Price_Price__SetColor(uVar3,uVar5,uVar6,0);
		      if (DAT_ram_00a5992b == '\0') {
		        Mono_Security_ASN1__get_Item
		                  (&
		                   Method_MVC_AbstractViewMediator_UserInfoModel__UserInfoEvents__UserInfoController__CultGenderNickSettingsView__get_Model__
		                  );
		        Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		        DAT_ram_00a5992b = '\x01';
		      }
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      uVar3 = *(undefined4 *)(iVar2 + 0x40);
		      uVar5 = *(undefined4 *)(param1[2] + 0x30);
		      uVar6 = *(undefined4 *)(param1[2] + 8);
		      if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_Money_Money_TypeInfo);
		      }
		      uVar5 = Core_Money_Money__op_Explicit(uVar5,0);
		      UI_Price_Price__SetColor(uVar3,uVar6,uVar5,0);
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      func_ii_7603(*(undefined4 *)(iVar2 + 0x4c),(uint)*(byte *)(*(int *)(param1[2] + 8) + 0x48),0);
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      func_ii_7603(*(undefined4 *)(iVar2 + 0x50),(uint)*(byte *)(*(int *)(param1[2] + 8) + 0x49),0);
		      uVar3 = 1;
		      iVar2 = Core_Extensions_UserDataExt__IsLegendaryUser
		                        (*(undefined4 *)(param1[2] + 8),&local_4,0);
		      if (iVar2 == 0) {
		        uVar3 = Core_Extensions_UserDataExt__TryGetIndividualApr
		                          (*(undefined4 *)(param1[2] + 8),&local_8,0);
		      }
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      System_Linq_Enumerable__First_object_(*(undefined4 *)(iVar2 + 0x50),uVar3,0);
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      System_Linq_Enumerable__First_object_(*(undefined4 *)(iVar2 + 0x4c),uVar3,0);
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (*(undefined4 *)(iVar2 + 0x54),uVar3,0);
		      if (DAT_ram_00a59930 == '\0') {
		        Mono_Security_ASN1__get_Item
		                  (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_AprDic__uint__get_Data__)
		        ;
		        Mono_Security_ASN1__get_Item
		                  (&
		                   Method_MVC_AbstractViewMediator_UserInfoModel__UserInfoEvents__UserInfoController__CultGenderNickSettingsView__get_Model__
		                  );
		        DAT_ram_00a59930 = '\x01';
		      }
		      uVar3 = UI_Wiki_WikiUriRouter__SetData
		                        (*(undefined4 *)(*(int *)(*(int *)(param1[2] + 8) + 0x38) + 0x10),0);
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      Core_Extensions_Dict_AprDicExt__Get1024AssetId(*(undefined4 *)(iVar2 + 0x10),uVar3,0);
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,System_Action_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x060018BA RID: 6330 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018BA")]
		[Address(RVA = "0x6A59", Offset = "0x6A59", VA = "0x6A59")]
		private void SetupView()
		{
		/* --- GHIDRA: SetupView ---
		void Gameplay_UserInfo_Control_UserInfoEditViewMediator__SetupView(int *param1,undefined4 param2)
		
		{
		  undefined4 param2_00;
		  int iVar1;
		  
		  if (DAT_ram_00a59930 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_AprDic__uint__get_Data__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_UserInfoModel__UserInfoEvents__UserInfoController__CultGenderNickSettingsView__get_Model__
		              );
		    DAT_ram_00a59930 = '\x01';
		  }
		  param2_00 = UI_Wiki_WikiUriRouter__SetData
		                        (*(undefined4 *)(*(int *)(*(int *)(param1[2] + 8) + 0x38) + 0x10),0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Core_Extensions_Dict_AprDicExt__Get1024AssetId(*(undefined4 *)(iVar1 + 0x10),param2_00,0);
		  return;
		}
		*/

		}

		// Token: 0x060018BB RID: 6331 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018BB")]
		[Address(RVA = "0x6A5A", Offset = "0x6A5A", VA = "0x6A5A")]
		private void SetCurrentAvatar()
		{
		/* --- GHIDRA: SetCurrentAvatar ---
		void Gameplay_UserInfo_Control_UserInfoEditViewMediator__SetCurrentAvatar
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  byte bVar1;
		  int *piVar2;
		  int iVar3;
		  int param1_00;
		  
		  piVar2 = (int *)(**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                            (param1,*(undefined4 *)(*param1 + 0x14c));
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*piVar2 + 0x100) * 4))
		                    (piVar2,*(undefined4 *)(*piVar2 + 0x104));
		  *(undefined1 *)(*(int *)(iVar3 + 8) + 0x49) = (undefined1)param2;
		  param1_00 = piVar2[6];
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*piVar2 + 0x100) * 4))
		                    (piVar2,*(undefined4 *)(*piVar2 + 0x104));
		  bVar1 = *(byte *)(*(int *)(iVar3 + 8) + 0x48);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*piVar2 + 0x100) * 4))
		                    (piVar2,*(undefined4 *)(*piVar2 + 0x104));
		  ServicesNamespace_MainService__ChangeFavoriteArtifact
		            (param1_00,(uint)bVar1,(uint)*(byte *)(*(int *)(iVar3 + 8) + 0x49),0);
		  return;
		}
		*/

		}

		// Token: 0x060018BC RID: 6332 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018BC")]
		[Address(RVA = "0x6A5B", Offset = "0x6A5B", VA = "0x6A5B")]
		private void HandleHideAprsCheckBoxValueChangedEvent(bool value)
		{
		/* --- GHIDRA: HandleHideAprsCheckBoxValueChangedEvent ---
		void Gameplay_UserInfo_Control_UserInfoEditViewMediator__HandleHideAprsCheckBoxValueChangedEvent
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  byte bVar1;
		  int *piVar2;
		  int iVar3;
		  int param1_00;
		  
		  piVar2 = (int *)(**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                            (param1,*(undefined4 *)(*param1 + 0x14c));
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*piVar2 + 0x100) * 4))
		                    (piVar2,*(undefined4 *)(*piVar2 + 0x104));
		  *(undefined1 *)(*(int *)(iVar3 + 8) + 0x48) = (undefined1)param2;
		  param1_00 = piVar2[6];
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*piVar2 + 0x100) * 4))
		                    (piVar2,*(undefined4 *)(*piVar2 + 0x104));
		  bVar1 = *(byte *)(*(int *)(iVar3 + 8) + 0x48);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*piVar2 + 0x100) * 4))
		                    (piVar2,*(undefined4 *)(*piVar2 + 0x104));
		  ServicesNamespace_MainService__ChangeFavoriteArtifact
		            (param1_00,(uint)bVar1,(uint)*(byte *)(*(int *)(iVar3 + 8) + 0x49),0);
		  return;
		}
		*/

		}

		// Token: 0x060018BD RID: 6333 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018BD")]
		[Address(RVA = "0x6A5C", Offset = "0x6A5C", VA = "0x6A5C")]
		private void HandleHideMedalsCheckBoxValueChangedEvent(bool value)
		{
		/* --- GHIDRA: HandleHideMedalsCheckBoxValueChangedEvent ---
		void Gameplay_UserInfo_Control_UserInfoEditViewMediator__HandleHideMedalsCheckBoxValueChangedEvent
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  undefined4 param2_00;
		  undefined4 param3;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param2_00 = *(undefined4 *)(iVar1 + 0x68);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param3 = *(undefined4 *)(iVar1 + 0x6c);
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		  Gameplay_UserInfo_Control_UserInfoController__GenerateNick(param1_00,param2_00,param3,param1);
		  return;
		}
		*/

		}

		// Token: 0x060018BE RID: 6334 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018BE")]
		[Address(RVA = "0x6A5D", Offset = "0x6A5D", VA = "0x6A5D")]
		private void HandleOnGenderOrCultSelected()
		{
		/* --- GHIDRA: HandleOnGenderOrCultSelected ---
		void Gameplay_UserInfo_Control_UserInfoEditViewMediator__HandleOnGenderOrCultSelected
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a59931 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_UserInfoModel__UserInfoEvents__UserInfoController__CultGenderNickSettingsView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__AprDicWrapper__get_Item__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_Genders__Dictionary_uint__AprDicWrapper___get_Item__
		              );
		    DAT_ram_00a59931 = '\x01';
		  }
		  uVar2 = *(undefined4 *)(*(int *)(param1[2] + 8) + 0x78);
		  iVar1 = Gameplay_UserInfo_Model_UserInfoModel__set_Game(param1[2],param1);
		  iVar1 = Core_Errors_Expected_ExpectedBillingErrors__GetErrorCode
		                    (uVar2,*(undefined4 *)(*(int *)(iVar1 + 0xc) + 0x18),0);
		  if (iVar1 != 0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    iVar3 = *(int *)(iVar1 + 0x68);
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    iVar1 = *(int *)(iVar1 + 0x6c);
		    uVar2 = GAFInternal_Reader_GAFReader__OpenTag
		                      (*(undefined4 *)(param1[2] + 0x24),*(undefined4 *)(iVar3 + 0xc),
		                       Method_System_Collections_Generic_Dictionary_Genders__Dictionary_uint__AprDicWrapper___get_Item__
		                      );
		    uVar2 = System_Collections_Generic_List_object___get_Item
		                      (uVar2,*(undefined4 *)(iVar1 + 0xc),
		                       Method_System_Collections_Generic_Dictionary_uint__AprDicWrapper__get_Item__)
		    ;
		    Gameplay_UserInfo_Control_UserInfoEditViewMediator__SetAvatar(param1,uVar2,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060018BF RID: 6335 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018BF")]
		[Address(RVA = "0x6A5E", Offset = "0x6A5E", VA = "0x6A5E")]
		private void HandleChangeCultGenderButtonClickEvent()
		{
		/* --- GHIDRA: HandleChangeCultGenderButtonClickEvent ---
		void Gameplay_UserInfo_Control_UserInfoEditViewMediator__HandleChangeCultGenderButtonClickEvent
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  int *param1_00;
		  undefined4 param2_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a59932 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_UserInfoModel__UserInfoEvents__UserInfoController__CultGenderNickSettingsView__get_Model__
		              );
		    DAT_ram_00a59932 = '\x01';
		  }
		  iVar1 = Core_Errors_Expected_ExpectedBillingErrors__GetErrorCode
		                    (*(undefined4 *)(*(int *)(param1[2] + 8) + 0x78),
		                     *(undefined4 *)(param1[2] + 0x30),0);
		  if (iVar1 != 0) {
		    param1_00 = (int *)(**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                                 (param1,*(undefined4 *)(*param1 + 0x14c));
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    param1_01 = *(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x44) + 0x10) + 0x160);
		    iVar1 = Newtonsoft_Json_Serialization_JsonSerializerInternalReader__ShouldDeserialize
		                      (param1_01,0);
		    if (iVar1 == 0) {
		      iVar1 = (**(code **)((ulonglong)*(uint *)(*param1_00 + 0x100) * 4))
		                        (param1_00,*(undefined4 *)(*param1_00 + 0x104));
		      param2_00 = Google_Protobuf_Collections_RepeatedField_object___GetEnumerator
		                            (*(undefined4 *)(iVar1 + 8),0);
		      iVar1 = Mono_Security_X509_X509CertificateCollection_X509CertificateEnumerator__get_Current
		                        (param1_01,param2_00,0);
		      if (iVar1 != 0) {
		        Gameplay_UserInfo_Control_UserInfoController__RequestNickChangePrice
		                  (param1_00,param1_01,0,param1_01);
		      }
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x060018C0 RID: 6336 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018C0")]
		[Address(RVA = "0x6A5F", Offset = "0x6A5F", VA = "0x6A5F")]
		private void HandleChangeNickButtonClickEvent()
		{
		/* --- GHIDRA: HandleChangeNickButtonClickEvent ---
		void Gameplay_UserInfo_Control_UserInfoEditViewMediator__HandleChangeNickButtonClickEvent
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  System_Linq_Enumerable__First_object_(*(undefined4 *)(iVar1 + 0x28),0,0);
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		  if (DAT_ram_00a59926 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    DAT_ram_00a59926 = '\x01';
		  }
		  Gameplay_UserInfo_Control_UserInfoController__HandleStop(param1_00,StringLiteral_5,param1_00);
		  return;
		}
		*/

		}

		// Token: 0x060018C1 RID: 6337 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018C1")]
		[Address(RVA = "0x6A60", Offset = "0x6A60", VA = "0x6A60")]
		private void HandleGenerateNickButtonClickEvent()
		{
		/* --- GHIDRA: HandleGenerateNickButtonClickEvent ---
		void Gameplay_UserInfo_Control_UserInfoEditViewMediator__HandleGenerateNickButtonClickEvent
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  uint uVar2;
		  undefined4 param1_00;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  TMPro_TMP_InputField__get_text(*(undefined4 *)(*(int *)(iVar1 + 0x44) + 0x10),param2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_00 = *(undefined4 *)(iVar1 + 0x28);
		  uVar2 = Newtonsoft_Json_Serialization_JsonSerializerInternalReader__ShouldDeserialize(param2,0);
		  System_Linq_Enumerable__First_object_(param1_00,uVar2 ^ 1,0);
		  return;
		}
		*/

		}

		// Token: 0x060018C2 RID: 6338 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018C2")]
		[Address(RVA = "0x6A61", Offset = "0x6A61", VA = "0x6A61")]
		private void HandleUserNickGenerateCompleteEvent(string nick)
		{
		/* --- GHIDRA: HandleUserNickGenerateCompleteEvent ---
		void Gameplay_UserInfo_Control_UserInfoEditViewMediator__HandleUserNickGenerateCompleteEvent
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a59933 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_UserInfo_Control_UserInfoEditViewMediator_HandleNickVariantsOnCloseEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_UserInfo_Control_UserInfoEditViewMediator_NickSelectedFromVariantsCallback__
		              );
		    DAT_ram_00a59933 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(System_Action_string__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_UserInfo_Control_UserInfoEditViewMediator_NickSelectedFromVariantsCallback__
		             ,0);
		  uVar1 = Gameplay_UserInfo_View_ExistNickResolverWindow__HandleConfirmButtonOnClickEvent
		                    (param2,param3,uVar1,param1);
		  param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_00,param1,
		             Method_Gameplay_UserInfo_Control_UserInfoEditViewMediator_HandleNickVariantsOnCloseEvent__
		             ,0);
		  UI_Windows_BaseWindow__get_IsActiveResourceBar(uVar1,param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x060018C3 RID: 6339 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018C3")]
		[Address(RVA = "0x6A62", Offset = "0x6A62", VA = "0x6A62")]
		private void HandleUserNickVariantsCompleteEvent(string sourceNick, RepeatedField<string> nickVariants)
		{
		/* --- GHIDRA: HandleUserNickVariantsCompleteEvent ---
		void Gameplay_UserInfo_Control_UserInfoEditViewMediator__HandleUserNickVariantsCompleteEvent
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  int *piVar2;
		  
		  if (DAT_ram_00a59934 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    DAT_ram_00a59934 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  TMPro_TMP_InputField__set_text(*(undefined4 *)(*(int *)(iVar1 + 0x44) + 0x10),StringLiteral_5,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  piVar2 = *(int **)(*(int *)(iVar1 + 0x44) + 0x10);
		  iVar1 = *piVar2;
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x1f0) * 4))(piVar2,*(undefined4 *)(iVar1 + 500));
		  return;
		}
		*/

		}

		// Token: 0x060018C4 RID: 6340 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018C4")]
		[Address(RVA = "0x6A63", Offset = "0x6A63", VA = "0x6A63")]
		private void HandleNickVariantsOnCloseEvent()
		{
		/* --- GHIDRA: HandleNickVariantsOnCloseEvent ---
		void Gameplay_UserInfo_Control_UserInfoEditViewMediator__HandleNickVariantsOnCloseEvent
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  int iVar2;
		  
		  if (DAT_ram_00a59935 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_PopupController_GetLastWindow_ExistNickResolverWindow___);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_UserInfo_Control_UserInfoEditViewMediator_HandleNickVariantsOnCloseEvent__
		              );
		    DAT_ram_00a59935 = '\x01';
		  }
		  uVar1 = System_Uri___ctor(0);
		  uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar1,0);
		  uVar1 = UI_Windows_PopupController__Close___Il2CppFullySharedGenericType_
		                    (uVar1,
		                     Method_UI_Windows_PopupController_GetLastWindow_ExistNickResolverWindow___);
		  param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_00,param1,
		             Method_Gameplay_UserInfo_Control_UserInfoEditViewMediator_HandleNickVariantsOnCloseEvent__
		             ,0);
		  UI_Windows_BaseWindow__add_onClose(uVar1,param1_00,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  TMPro_TMP_InputField__get_text(*(undefined4 *)(*(int *)(iVar2 + 0x44) + 0x10),param2,0);
		  return;
		}
		*/

		}

		// Token: 0x060018C5 RID: 6341 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018C5")]
		[Address(RVA = "0x6A64", Offset = "0x6A64", VA = "0x6A64")]
		private void NickSelectedFromVariantsCallback(string nick)
		{
		/* --- GHIDRA: NickSelectedFromVariantsCallback ---
		void Gameplay_UserInfo_Control_UserInfoEditViewMediator__NickSelectedFromVariantsCallback
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Core_Extensions_Dict_AprDicExt__Get1024AssetId(*(undefined4 *)(iVar1 + 0x10),param2,0);
		  return;
		}
		*/

		}

		// Token: 0x060018C6 RID: 6342 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018C6")]
		[Address(RVA = "0x6A65", Offset = "0x6A65", VA = "0x6A65")]
		private void SetAvatar(string assetId)
		{
		/* --- GHIDRA: SetAvatar ---
		undefined4
		Gameplay_UserInfo_Control_UserInfoEditViewMediator__SetAvatar
		          (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  int param1_00;
		  undefined4 uVar1;
		  int iVar2;
		  int iVar3;
		  int iVar4;
		  uint uVar5;
		  
		  if (DAT_ram_00a59936 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_DialogWindow_DialogWindowArgs__AprDicWrapper__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_DialogWindow_DialogWindowArgs__AprDicWrapper___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_DialogWindow_DialogWindowArgs__AprDicWrapper__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&UI_Windows_DialogWindow_DialogWindowArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___Add__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_UserInfo_Control_UserInfoEditViewMediator__ShowConfirmChangeCult_b__22_0__
		              );
		    Mono_Security_ASN1__get_Item(&StringLiteral_4161);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2765);
		    DAT_ram_00a59936 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(UI_Windows_DialogWindow_DialogWindowArgs_TypeInfo);
		  func_ii_8625(param1_00,0);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar1 = func_ii_7508(StringLiteral_2765,1,0,1,0,0,0,0);
		  *(undefined4 *)(param1_00 + 0x18) = uVar1;
		  uVar1 = func_ii_7508(StringLiteral_4161,1,0,1,0,0,0,0);
		  *(undefined4 *)(param1_00 + 0x1c) = uVar1;
		  iVar4 = *(int *)(param1_00 + 0x24);
		  iVar2 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs__TypeInfo
		                    );
		  UI_Windows_DialogWindow_DialogWindowArgs___ctor
		            (iVar2,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___ctor__
		            );
		  uVar1 = UI_Windows_DialogWindow__get_WindowId(0);
		  *(undefined4 *)(iVar2 + 8) = uVar1;
		  iVar3 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_DialogWindow_DialogWindowArgs__AprDicWrapper__TypeInfo
		                    );
		  *(undefined4 *)(iVar3 + 0xc) = param2;
		  uVar1 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_DialogWindow_DialogWindowArgs__AprDicWrapper__TypeInfo
		                    );
		  UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_object__Int32Enum___Invoke
		            (uVar1,param1,
		             Method_Gameplay_UserInfo_Control_UserInfoEditViewMediator__ShowConfirmChangeCult_b__22_0__
		             ,0);
		  *(undefined4 *)(iVar3 + 0x10) = uVar1;
		  *(int *)(iVar2 + 0x14) = iVar3;
		  iVar3 = 
		  Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___Add__
		  ;
		  *(int *)(iVar4 + 0x10) = *(int *)(iVar4 + 0x10) + 1;
		  uVar5 = *(uint *)(iVar4 + 0xc);
		  if (uVar5 < *(uint *)(*(int *)(iVar4 + 8) + 0xc)) {
		    *(uint *)(iVar4 + 0xc) = uVar5 + 1;
		    *(int *)(*(int *)(iVar4 + 8) + uVar5 * 4 + 0x10) = iVar2;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar4,iVar2,*(undefined4 *)(*(int *)(*(int *)(iVar3 + 0x10) + 0x60) + 0x38));
		  }
		  iVar4 = *(int *)(param1_00 + 0x24);
		  iVar2 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs__TypeInfo
		                    );
		  UI_Windows_DialogWindow_DialogWindowArgs___ctor
		            (iVar2,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___ctor__
		            );
		  uVar1 = UI_Windows_DialogWindow__get_YES_LABEL(0);
		  *(undefined4 *)(iVar2 + 8) = uVar1;
		  iVar3 = 
		  Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___Add__
		  ;
		  *(int *)(iVar4 + 0x10) = *(int *)(iVar4 + 0x10) + 1;
		  uVar5 = *(uint *)(iVar4 + 0xc);
		  if (uVar5 < *(uint *)(*(int *)(iVar4 + 8) + 0xc)) {
		    *(uint *)(iVar4 + 0xc) = uVar5 + 1;
		    *(int *)(*(int *)(iVar4 + 8) + uVar5 * 4 + 0x10) = iVar2;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar4,iVar2,*(undefined4 *)(*(int *)(*(int *)(iVar3 + 0x10) + 0x60) + 0x38));
		  }
		  uVar1 = UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_object____ctor
		                    (param1_00,0);
		  return uVar1;
		}
		*/

		}

		// Token: 0x060018C7 RID: 6343 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60018C7")]
		[Address(RVA = "0x6A66", Offset = "0x6A66", VA = "0x6A66")]
		private DialogWindow ShowConfirmChangeCult(AprDicWrapper apr)
		{
		/* --- GHIDRA: ShowConfirmChangeCult ---
		void Gameplay_UserInfo_Control_UserInfoEditViewMediator__ShowConfirmChangeCult
		               (int *param1,undefined4 param2,int param3,undefined4 param4)
		
		{
		  int *param1_00;
		  int iVar1;
		  
		  param1_00 = (int *)(**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                               (param1,*(undefined4 *)(*param1 + 0x14c));
		  if (DAT_ram_00a59925 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_AprDic__uint__get_Data__);
		    DAT_ram_00a59925 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1_00 + 0x100) * 4))
		                    (param1_00,*(undefined4 *)(*param1_00 + 0x104));
		  if (param3 != *(int *)(*(int *)(iVar1 + 8) + 0x38)) {
		    Gameplay_UserInfo_Control_UserInfoController__RequestChangesNick
		              (param1_00,*(undefined4 *)(*(int *)(param3 + 0x10) + 0xc),0,param1_00);
		  }
		  return;
		}
		*/

			return null;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Events ---
		void Gameplay_UserInfo_Control_UserInfoEditViewMediator__set_Events(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  undefined4 uVar2;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a5992b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_UserInfoModel__UserInfoEvents__UserInfoController__CultGenderNickSettingsView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		    DAT_ram_00a5992b = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_00 = *(undefined4 *)(iVar1 + 0x40);
		  uVar2 = *(undefined4 *)(param1[2] + 0x30);
		  param2_00 = *(undefined4 *)(param1[2] + 8);
		  if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_Money_TypeInfo);
		  }
		  uVar2 = Core_Money_Money__op_Explicit(uVar2,0);
		  UI_Price_Price__SetColor(param1_00,param2_00,uVar2,0);
		  return;
		}
		*/


		/* --- GHIDRA: set_View ---
		void Gameplay_UserInfo_Control_UserInfoEditViewMediator__set_View(int *param1,undefined4 param2)
		
		{
		  bool bVar1;
		  int param1_00;
		  int iVar2;
		  undefined4 uVar3;
		  int *param1_01;
		  int iVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a5992e == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Events_UnityEvent_bool__RemoveListener__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_UserInfo_Control_UserInfoEditViewMediator_HandleChangeCultGenderButtonClickEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_UserInfo_Control_UserInfoEditViewMediator_HandleChangeNickButtonClickEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_UserInfo_Control_UserInfoEditViewMediator_HandleGenerateNickButtonClickEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_UserInfo_Control_UserInfoEditViewMediator_HandleHideAprsCheckBoxValueChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_UserInfo_Control_UserInfoEditViewMediator_HandleHideMedalsCheckBoxValueChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_UserInfo_Control_UserInfoEditViewMediator_HandleOnGenderOrCultSelected__
		              );
		    DAT_ram_00a5992e = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar5 = *(undefined4 *)(*(int *)(iVar2 + 0x24) + 0xb4);
		  uVar3 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar3,param1,
		             Method_Gameplay_UserInfo_Control_UserInfoEditViewMediator_HandleChangeNickButtonClickEvent__
		             ,0);
		  UnityEngine_Events_UnityAction___ctor(uVar5,uVar3,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar5 = *(undefined4 *)(*(int *)(iVar2 + 0x20) + 0xb4);
		  uVar3 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar3,param1,
		             Method_Gameplay_UserInfo_Control_UserInfoEditViewMediator_HandleChangeCultGenderButtonClickEvent__
		             ,0);
		  UnityEngine_Events_UnityAction___ctor(uVar5,uVar3,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar5 = *(undefined4 *)(*(int *)(iVar2 + 0x28) + 0xb4);
		  uVar3 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar3,param1,
		             Method_Gameplay_UserInfo_Control_UserInfoEditViewMediator_HandleGenerateNickButtonClickEvent__
		             ,0);
		  UnityEngine_Events_UnityAction___ctor(uVar5,uVar3,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar3,param1,
		             Method_Gameplay_UserInfo_Control_UserInfoEditViewMediator_HandleOnGenderOrCultSelected__
		             ,0);
		  if (DAT_ram_00a598c9 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a598c9 = '\x01';
		  }
		  param1_00 = *(int *)(iVar2 + 0x58);
		  while ((param1_01 = (int *)func_ii_7048(param1_00,uVar3,0), param1_01 == (int *)0x0 ||
		         (System_Action_TypeInfo == *param1_01))) {
		    iVar4 = func_ii_4329(iVar2 + 0x58,param1_01,param1_00);
		    bVar1 = iVar4 == param1_00;
		    param1_00 = iVar4;
		    if (bVar1) {
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      uVar5 = *(undefined4 *)(*(int *)(iVar2 + 0x4c) + 0xc0);
		      uVar3 = unnamed_function_1417(UnityEngine_Events_UnityAction_bool__TypeInfo);
		      UnityEngine_UI_Toggle__set_group
		                (uVar3,param1,
		                 Method_Gameplay_UserInfo_Control_UserInfoEditViewMediator_HandleHideMedalsCheckBoxValueChangedEvent__
		                 ,0);
		      UnityEngine_Events_UnityEvent_InputAction_CallbackContext___Invoke
		                (uVar5,uVar3,Method_UnityEngine_Events_UnityEvent_bool__RemoveListener__);
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      uVar5 = *(undefined4 *)(*(int *)(iVar2 + 0x50) + 0xc0);
		      uVar3 = unnamed_function_1417(UnityEngine_Events_UnityAction_bool__TypeInfo);
		      UnityEngine_UI_Toggle__set_group
		                (uVar3,param1,
		                 Method_Gameplay_UserInfo_Control_UserInfoEditViewMediator_HandleHideAprsCheckBoxValueChangedEvent__
		                 ,0);
		      UnityEngine_Events_UnityEvent_InputAction_CallbackContext___Invoke
		                (uVar5,uVar3,Method_UnityEngine_Events_UnityEvent_bool__RemoveListener__);
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,System_Action_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

}
