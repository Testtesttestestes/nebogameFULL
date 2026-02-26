using System;
using Gameplay.Isles.User.Controller;
using Gameplay.Isles.User.Events;
using Gameplay.Isles.User.Model;
using Gameplay.World.Model;
using Il2CppDummyDll;
using MVC;

namespace UI.Windows.Buildings
{
	// Token: 0x020002AD RID: 685
	[Token(Token = "0x20002AD")]
	public class BuildingInfoViewMediator : AbstractViewMediator<UserIsleModel, UserIsleEvents, UserIsleController, BuildingInfoView>
	{
		// Token: 0x06001010 RID: 4112 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001010")]
		[Address(RVA = "0x621A", Offset = "0x621A", VA = "0x621A")]
		public BuildingInfoViewMediator(uint buildingTypeId, UserIsleModel model, UserIsleEvents events, UserIsleController controller)
		{
		/* --- GHIDRA: <ViewOnRequestAccelerateBuildEvent>b__10_0 ---
		void UI_Windows_Buildings_BuildingInfoViewMediator___ViewOnRequestAccelerateBuildEvent_b__10_0
		               (int *param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 param1_00;
		  undefined4 param2_00;
		  
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		  param2_00 = UnityEngine_AndroidJavaObject___GetRawObject(param3,0);
		  Gameplay_Isles_User_Controller_UserIsleController__AccelerateBuildingServiceHandler
		            (param1_00,param2_00,0);
		  return;
		}
		*/

		/* --- GHIDRA: .ctor ---
		void UI_Windows_Buildings_BuildingInfoViewMediator___ctor(int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a58a97 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_UserIsleModel__UserIsleEvents__UserIsleController__BuildingInfoView__set_Events__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_uint__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_Buildings_BuildingInfoViewMediator_BuildingStateChanged__);
		    DAT_ram_00a58a97 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar1 + 0x14);
		    uVar2 = unnamed_function_1417(System_Action_uint__TypeInfo);
		    func_ii_12322(uVar2,param1,
		                  Method_UI_Windows_Buildings_BuildingInfoViewMediator_BuildingStateChanged__,0);
		    iVar3 = func_ii_7048(uVar5,uVar2,0);
		    uVar2 = System_Action_uint__TypeInfo;
		    if (iVar3 == 0) {
		      *(undefined4 *)(iVar1 + 0x14) = 0;
		    }
		    else {
		      iVar4 = func_ii_1082(iVar3,System_Action_uint__TypeInfo);
		      if (iVar4 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x14) = iVar4;
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
		    uVar5 = *(undefined4 *)(iVar1 + 0x14);
		    uVar2 = unnamed_function_1417(System_Action_uint__TypeInfo);
		    func_ii_12322(uVar2,param1,
		                  Method_UI_Windows_Buildings_BuildingInfoViewMediator_BuildingStateChanged__,0);
		    iVar3 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		    uVar2 = System_Action_uint__TypeInfo;
		    if (iVar3 == 0) {
		      *(undefined4 *)(iVar1 + 0x14) = 0;
		      return;
		    }
		    iVar4 = func_ii_1082(iVar3,System_Action_uint__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar3,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar1 + 0x14) = iVar4;
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

		// Token: 0x17000249 RID: 585
		// (set) Token: 0x06001011 RID: 4113 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000249")]
		public override UserIsleEvents Events
		{
			[Token(Token = "0x6001011")]
			[Address(RVA = "0x621B", Offset = "0x621B", VA = "0x621B", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x06001012 RID: 4114 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001012")]
		[Address(RVA = "0x621C", Offset = "0x621C", VA = "0x621C")]
		private void BuildingStateChanged(uint buildingTypeId)
		{
		/* --- GHIDRA: BuildingStateChanged ---
		void UI_Windows_Buildings_BuildingInfoViewMediator__BuildingStateChanged
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a58a99 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_UserIsleModel__UserIsleEvents__UserIsleController__BuildingInfoView__set_View__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_Buildings_BaseBuildingInfoView_UserIsle__add_RequestAccelerateBuildEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_Buildings_BaseBuildingInfoView_UserIsle__add_RequestCancelBuildEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_Buildings_BaseBuildingInfoView_UserIsle__add_RequestStartBuildEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_Buildings_BaseBuildingInfoView_UserIsle__remove_RequestAccelerateBuildEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_Buildings_BaseBuildingInfoView_UserIsle__remove_RequestCancelBuildEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_Buildings_BaseBuildingInfoView_UserIsle__remove_RequestStartBuildEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_Buildings_BuildingInfoViewMediator_ViewOnRequestAccelerateBuildEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_Buildings_BuildingInfoViewMediator_ViewOnRequestCancelBuildEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_Buildings_BuildingInfoViewMediator_ViewOnRequestStartBuildEvent__)
		    ;
		    DAT_ram_00a58a99 = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_UI_Windows_Buildings_BuildingInfoViewMediator_ViewOnRequestStartBuildEvent__,0
		              );
		    UI_Windows_Buildings_BaseBuildingInfoView_object___remove_RequestCancelBuildEvent
		              (uVar1,uVar3,
		               Method_UI_Windows_Buildings_BaseBuildingInfoView_UserIsle__remove_RequestStartBuildEvent__
		              );
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_UI_Windows_Buildings_BuildingInfoViewMediator_ViewOnRequestAccelerateBuildEvent__
		               ,0);
		    UI_Windows_Buildings_BaseBuildingInfoView_object___get_TitleLabel
		              (uVar1,uVar3,
		               Method_UI_Windows_Buildings_BaseBuildingInfoView_UserIsle__remove_RequestAccelerateBuildEvent__
		              );
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_UI_Windows_Buildings_BuildingInfoViewMediator_ViewOnRequestCancelBuildEvent__,
		               0);
		    UI_Windows_Buildings_BaseBuildingInfoView_object___remove_RequestAccelerateBuildEvent
		              (uVar1,uVar3,
		               Method_UI_Windows_Buildings_BaseBuildingInfoView_UserIsle__remove_RequestCancelBuildEvent__
		              );
		  }
		  param1[5] = param2;
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_UI_Windows_Buildings_BuildingInfoViewMediator_ViewOnRequestStartBuildEvent__,0
		              );
		    UI_Windows_Buildings_BaseBuildingInfoView_object___add_RequestCancelBuildEvent
		              (uVar1,uVar3,
		               Method_UI_Windows_Buildings_BaseBuildingInfoView_UserIsle__add_RequestStartBuildEvent__
		              );
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_UI_Windows_Buildings_BuildingInfoViewMediator_ViewOnRequestAccelerateBuildEvent__
		               ,0);
		    UI_Windows_Buildings_BaseBuildingInfoView_object___ShowMaxLevelState
		              (uVar1,uVar3,
		               Method_UI_Windows_Buildings_BaseBuildingInfoView_UserIsle__add_RequestAccelerateBuildEvent__
		              );
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_UI_Windows_Buildings_BuildingInfoViewMediator_ViewOnRequestCancelBuildEvent__,
		               0);
		    UI_Windows_Buildings_BaseBuildingInfoView_object___add_RequestAccelerateBuildEvent
		              (uVar1,uVar3,
		               Method_UI_Windows_Buildings_BaseBuildingInfoView_UserIsle__add_RequestCancelBuildEvent__
		              );
		    UI_Windows_Buildings_BuildingInfoViewMediator__set_Events(param1,param1[6],param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x1700024A RID: 586
		// (set) Token: 0x06001013 RID: 4115 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700024A")]
		public override BuildingInfoView View
		{
			[Token(Token = "0x6001013")]
			[Address(RVA = "0x621D", Offset = "0x621D", VA = "0x621D", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06001014 RID: 4116 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001014")]
		[Address(RVA = "0x621E", Offset = "0x621E", VA = "0x621E")]
		private void UpdateView()
		{
		/* --- GHIDRA: UpdateView ---
		void UI_Windows_Buildings_BuildingInfoViewMediator__UpdateView(int param1,undefined4 param2)
		
		{
		  UI_Windows_Buildings_BuildingInfoViewMediator__ViewOnRequestStartBuildEvent
		            (param1,*(undefined4 *)(param1 + 0x1c),param1);
		  return;
		}
		*/

		}

		// Token: 0x06001015 RID: 4117 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001015")]
		[Address(RVA = "0x621F", Offset = "0x621F", VA = "0x621F")]
		private void ViewOnRequestCancelBuildEvent()
		{
		/* --- GHIDRA: ViewOnRequestCancelBuildEvent ---
		void UI_Windows_Buildings_BuildingInfoViewMediator__ViewOnRequestCancelBuildEvent
		               (int param1,undefined4 param2)
		
		{
		  undefined4 in_register_20000014;
		  undefined8 uVar1;
		  int iVar2;
		  float fVar3;
		  uint *puVar4;
		  undefined4 uVar5;
		  undefined4 uVar6;
		  double param3;
		  int *piVar7;
		  int iVar8;
		  double param4;
		  uint uVar9;
		  
		  if (DAT_ram_00a58a9b == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_Buildings_BuildingInfoViewMediator__ViewOnRequestAccelerateBuildEvent_b__10_0__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25458);
		    DAT_ram_00a58a9b = '\x01';
		  }
		  iVar2 = Newtonsoft_Json_Converters_XDeclarationWrapper__get_Encoding
		                    (*(undefined4 *)(param1 + 0x1c),0);
		  fVar3 = func_ii_7103(*(undefined4 *)(*(int *)(param1 + 0x1c) + 0x14),0);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar9 = 0;
		  piVar7 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar8 = *piVar7;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar9 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar9 * 8 + 4) * 8 + iVar8 + 0x178);
		        goto code_r0x80f6d984;
		      }
		      uVar9 = uVar9 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar9);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80f6d984:
		  uVar1 = CONCAT44(in_register_20000014,puVar4[1]);
		  uVar5 = (**(code **)((ulonglong)*puVar4 * 4))(piVar7,uVar1);
		  uVar6 = (undefined4)((ulonglong)uVar1 >> 0x20);
		  uVar5 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar5,0);
		  param3 = Core_Extensions_Dict_DictExt__GetIntParameter(uVar5,StringLiteral_25458,0);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar7 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar8 = *piVar7;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    uVar9 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar9 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar9 * 8 + 4) * 8 + iVar8 + 0x140);
		        goto code_r0x80f6da44;
		      }
		      uVar9 = uVar9 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar9);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x80f6da44:
		  uVar6 = (**(code **)((ulonglong)*puVar4 * 4))(piVar7,CONCAT44(uVar6,puVar4[1]));
		  iVar8 = func_ii_7112(uVar6,0);
		  param4 = *(double *)(*(int *)(iVar8 + 0x78) + 0x18);
		  uVar6 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar6,param1,
		             Method_UI_Windows_Buildings_BuildingInfoViewMediator__ViewOnRequestAccelerateBuildEvent_b__10_0__
		             ,0);
		  uVar5 = 3;
		  if (iVar2 == 0) {
		    uVar5 = 2;
		  }
		  UI_Windows_Alert_AlertArgs___ctor(uVar5,(double)fVar3,param3,param4,uVar6,0);
		  return;
		}
		*/

		}

		// Token: 0x06001016 RID: 4118 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001016")]
		[Address(RVA = "0x6220", Offset = "0x6220", VA = "0x6220")]
		private void ViewOnRequestAccelerateBuildEvent()
		{
		/* --- GHIDRA: ViewOnRequestAccelerateBuildEvent ---
		void UI_Windows_Buildings_BuildingInfoViewMediator__ViewOnRequestAccelerateBuildEvent
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		  Gameplay_Isles_User_Controller_UserIsleController__OnDiamondIsleFound(param1_00,param1[6],0);
		  return;
		}
		*/

		}

		// Token: 0x06001017 RID: 4119 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001017")]
		[Address(RVA = "0x6221", Offset = "0x6221", VA = "0x6221")]
		private void ViewOnRequestStartBuildEvent()
		{
		/* --- GHIDRA: ViewOnRequestStartBuildEvent ---
		undefined4
		UI_Windows_Buildings_BuildingInfoViewMediator__ViewOnRequestStartBuildEvent
		          (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000014;
		  undefined4 uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  undefined4 param1_00;
		  int iVar4;
		  int iVar5;
		  undefined4 *puVar6;
		  int param1_01;
		  uint uVar7;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a58a9c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_Buildings_BuildingInfoViewMediator__ShowConfirmCancelBuildWindow_b__12_0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_DialogWindow_DialogWindowArgs__BaseBuildingData__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_DialogWindow_DialogWindowArgs__BaseBuildingData___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_DialogWindow_DialogWindowArgs__BaseBuildingData__TypeInfo
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
		              (&System_Collections_Generic_KeyValuePair_string__string____TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___Add__
		              );
		    Mono_Security_ASN1__get_Item(&StringLiteral_26445);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2556);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4111);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3698);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3697);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3696);
		    DAT_ram_00a58a9c = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                    (param1,CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x14c)));
		  uVar2 = UnityEngine_AndroidJavaObject___GetRawObject(param2,0);
		  uVar1 = Gameplay_Isles_User_Controller_UserIsleController__CancelBuild(uVar1,uVar2,0);
		  iVar3 = Newtonsoft_Json_Converters_XDeclarationWrapper__get_Encoding(param2,0);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  puVar6 = &StringLiteral_3698;
		  if (iVar3 == 0) {
		    puVar6 = &StringLiteral_3697;
		  }
		  uVar2 = func_ii_7508(*puVar6,1,0,1,0,0,0,0);
		  puVar6 = &StringLiteral_4111;
		  if (iVar3 == 0) {
		    puVar6 = &StringLiteral_3696;
		  }
		  param1_00 = func_ii_7508(*puVar6,1,0,1,0,0,0,0);
		  iVar3 = unnamed_function_1417(UI_Windows_DialogWindow_DialogWindowArgs_TypeInfo);
		  if (DAT_ram_00a58a57 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindow_DialogWindowArgs___ctor__
		              );
		    DAT_ram_00a58a57 = '\x01';
		  }
		  UnityEngine_UIElements_BaseCompositeField___Il2CppFullySharedGenericType__object____Il2CppFullySharedGenericType___UpdateMixedValueContent
		            (iVar3,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindow_DialogWindowArgs___ctor__
		            );
		  *(undefined4 *)(iVar3 + 0x18) = uVar2;
		  iVar4 = Mono_Security_ASN1Convert__ToOid
		                    (System_Collections_Generic_KeyValuePair_string__string____TypeInfo,1);
		  uVar1 = Core_Extensions_Dict_ResourceSetExt__ToLocaleString(uVar1,NAN,0,StringLiteral_2556,0,0,0);
		  local_8 = 0;
		  System_Text_Formatting_StringView__get_IsEmpty
		            (&local_8,StringLiteral_26445,uVar1,
		             Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		  *(undefined8 *)(iVar4 + 0x10) = local_8;
		  uVar1 = Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsRewardsTab_ClanWarsRewardsView__GetPlacesText
		                    (param1_00,iVar4,0);
		  *(undefined4 *)(iVar3 + 0x1c) = uVar1;
		  param1_01 = *(int *)(iVar3 + 0x24);
		  iVar4 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs__TypeInfo
		                    );
		  UI_Windows_DialogWindow_DialogWindowArgs___ctor
		            (iVar4,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___ctor__
		            );
		  if (DAT_ram_00a58a4e == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_18331);
		    DAT_ram_00a58a4e = '\x01';
		  }
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar1 = func_ii_7508(StringLiteral_18331,1,0,1,0,0,0,0);
		  *(undefined4 *)(iVar4 + 8) = uVar1;
		  iVar5 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_DialogWindow_DialogWindowArgs__BaseBuildingData__TypeInfo
		                    );
		  *(undefined4 *)(iVar5 + 0xc) = param2;
		  uVar1 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_DialogWindow_DialogWindowArgs__BaseBuildingData__TypeInfo
		                    );
		  UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_object__Int32Enum___Invoke
		            (uVar1,param1,
		             Method_UI_Windows_Buildings_BuildingInfoViewMediator__ShowConfirmCancelBuildWindow_b__12_0__
		             ,0);
		  *(undefined4 *)(iVar5 + 0x10) = uVar1;
		  *(int *)(iVar4 + 0x14) = iVar5;
		  iVar5 = 
		  Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___Add__
		  ;
		  *(int *)(param1_01 + 0x10) = *(int *)(param1_01 + 0x10) + 1;
		  uVar7 = *(uint *)(param1_01 + 0xc);
		  if (uVar7 < *(uint *)(*(int *)(param1_01 + 8) + 0xc)) {
		    *(uint *)(param1_01 + 0xc) = uVar7 + 1;
		    *(int *)(*(int *)(param1_01 + 8) + uVar7 * 4 + 0x10) = iVar4;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (param1_01,iVar4,*(undefined4 *)(*(int *)(*(int *)(iVar5 + 0x10) + 0x60) + 0x38));
		  }
		  if (DAT_ram_00a58a52 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_PopupController_Show_DialogWindow___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12610);
		    DAT_ram_00a58a52 = '\x01';
		  }
		  uVar1 = System_Uri___ctor(0);
		  uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar1,0);
		  uVar1 = Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		                    (uVar1,StringLiteral_12610,iVar3,
		                     Method_UI_Windows_PopupController_Show_DialogWindow___);
		  return uVar1;
		}
		*/

		}

		// Token: 0x06001018 RID: 4120 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001018")]
		[Address(RVA = "0x6222", Offset = "0x6222", VA = "0x6222")]
		private DialogWindow ShowConfirmCancelBuildWindow(BaseBuildingData buildingData)
		{
		/* --- GHIDRA: ShowConfirmCancelBuildWindow ---
		void UI_Windows_Buildings_BuildingInfoViewMediator__ShowConfirmCancelBuildWindow
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		  Gameplay_Isles_User_Controller_UserIsleController__StartBuildingServiceHandler
		            (param1_00,param1[6],0);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x04000839 RID: 2105
		[Token(Token = "0x4000839")]
		[FieldOffset(Offset = "0x18")]
		private uint _buildingTypeId;

		// Token: 0x0400083A RID: 2106
		[Token(Token = "0x400083A")]
		[FieldOffset(Offset = "0x1C")]
		private BaseBuildingData _buildingData;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Events ---
		void UI_Windows_Buildings_BuildingInfoViewMediator__set_Events
		               (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  int *param1_00;
		  int iVar4;
		  
		  if (DAT_ram_00a58a98 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_UserIsleModel__UserIsleEvents__UserIsleController__BuildingInfoView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_Buildings_BaseBuildingInfoView_UserIsle__ShowBuildingState__);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_Buildings_BaseBuildingInfoView_UserIsle__ShowDefaultState__);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_Buildings_BaseBuildingInfoView_UserIsle__ShowMaxLevelState__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Discounts_Model_IDiscountHandler_TypeInfo);
		    DAT_ram_00a58a98 = '\x01';
		  }
		  if (param1[6] == param2) {
		    UI_Windows_Buildings_BuildingInfoViewMediator__set_View(param1,param1);
		    iVar4 = *(int *)param1[7];
		    iVar4 = (**(code **)((ulonglong)*(uint *)(iVar4 + 0x120) * 4))
		                      ((int *)param1[7],*(undefined4 *)(iVar4 + 0x124));
		    if (iVar4 != 0) {
		      uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      UI_Windows_Buildings_BaseBuildingInfoView_object___ShowDefaultState
		                (uVar2,
		                 Method_UI_Windows_Buildings_BaseBuildingInfoView_UserIsle__ShowMaxLevelState__);
		      return;
		    }
		    iVar4 = func_ii_8742(param1[7],0);
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    if (iVar4 != 0) {
		      iVar4 = UI_Windows_Buildings_BaseBuildingInfoView_object___Init
		                        (uVar2,param1[7],*(undefined4 *)(param1[2] + 0x48),
		                         Method_UI_Windows_Buildings_BaseBuildingInfoView_UserIsle__ShowBuildingState__
		                        );
		      uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(iVar4 + 0x1c),0);
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (uVar2,(uint)(*(int *)(param1[2] + 8) == *(int *)(param1[2] + 0x48)),0);
		      return;
		    }
		    uVar2 = UI_Windows_Buildings_BaseBuildingInfoView_object___ShowBuildingState
		                      (uVar2,param1[7],*(undefined4 *)(param1[2] + 0x48),
		                       Method_UI_Windows_Buildings_BaseBuildingInfoView_UserIsle__ShowDefaultState__
		                      );
		    param1_00 = *(int **)(param1[2] + 0x20);
		    if (param1_00 != (int *)0x0) {
		      uVar1 = 0;
		      iVar4 = *param1_00;
		      if (*(ushort *)(iVar4 + 0xb6) != 0) {
		        do {
		          if (Gameplay_Discounts_Model_IDiscountHandler_TypeInfo ==
		              *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		            puVar3 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		            goto code_r0x80f6d0cb;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		      }
		      puVar3 = (uint *)func_ii_1080(param1_00,Gameplay_Discounts_Model_IDiscountHandler_TypeInfo,0);
		code_r0x80f6d0cb:
		      (**(code **)((ulonglong)*puVar3 * 4))(param1_00,uVar2,puVar3[1]);
		    }
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_View ---
		void UI_Windows_Buildings_BuildingInfoViewMediator__set_View(int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  undefined4 uVar5;
		  int *piVar6;
		  int *param1_00;
		  
		  if (DAT_ram_00a58a9a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_Buildings_BaseBuildingInfoView_UserIsle__get_DescLabel__);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_Buildings_BaseBuildingInfoView_UserIsle__get_LevelCounter__);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_Buildings_BaseBuildingInfoView_UserIsle__get_TitleLabel__);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a58a9a = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  piVar6 = *(int **)(iVar2 + 0x10);
		  iVar2 = *(int *)param1[7];
		  uVar3 = (**(code **)((ulonglong)*(uint *)(iVar2 + 0xe8) * 4))
		                    ((int *)param1[7],*(undefined4 *)(iVar2 + 0xec));
		  iVar2 = *piVar6;
		  (**(code **)((ulonglong)*(uint *)(iVar2 + 0x2d0) * 4))
		            (piVar6,uVar3,*(undefined4 *)(iVar2 + 0x2d4));
		  piVar6 = (int *)param1[7];
		  uVar3 = Newtonsoft_Json_Converters_XDeclarationWrapper__get_Encoding(piVar6,0);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar2 = *param1_00;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x178);
		        goto code_r0x80f6d207;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80f6d207:
		  uVar5 = (**(code **)((ulonglong)*puVar4 * 4))(param1_00,puVar4[1]);
		  uVar5 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar5,0);
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*piVar6 + 0x130) * 4))
		                    (piVar6,uVar3,uVar5,*(undefined4 *)(*piVar6 + 0x134));
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  piVar6 = *(int **)(iVar2 + 0x14);
		  iVar2 = *(int *)param1[7];
		  iVar2 = (**(code **)((ulonglong)*(uint *)(iVar2 + 0xf0) * 4))
		                    ((int *)param1[7],*(undefined4 *)(iVar2 + 0xf4));
		  if (iVar2 == 0) {
		    uVar3 = 0;
		  }
		  else {
		    uVar3 = Core_GameLocalization__GetTranslation(iVar2,uVar3,0);
		  }
		  iVar2 = *piVar6;
		  (**(code **)((ulonglong)*(uint *)(iVar2 + 0x2d0) * 4))
		            (piVar6,uVar3,*(undefined4 *)(iVar2 + 0x2d4));
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar5 = *(undefined4 *)(iVar2 + 0x18);
		  uVar3 = Newtonsoft_Json_Converters_XDeclarationWrapper__get_Encoding(param1[7],0);
		  UI_Elements_Counters_CounterAutoHide___ctor(uVar5,uVar3,0);
		  return;
		}
		*/

}
