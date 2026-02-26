using System;
using Gameplay.Isles.Clan.Controller;
using Gameplay.Isles.Clan.Events;
using Gameplay.Isles.Clan.Model;
using Gameplay.World.Model;
using Il2CppDummyDll;
using MVC;

namespace UI.Windows.Buildings
{
	// Token: 0x020002B3 RID: 691
	[Token(Token = "0x20002B3")]
	public class ClanBuildingInfoViewMediator : AbstractViewMediator<ClanIsleModel, ClanIsleEvents, ClanIsleController, ClanBuildingInfoView>
	{
		// Token: 0x1700025A RID: 602
		// (get) Token: 0x0600103D RID: 4157 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700025A")]
		private BaseBuildingData _buildingData
		{
			[Token(Token = "0x600103D")]
			[Address(RVA = "0x6247", Offset = "0x6247", VA = "0x6247")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600103E RID: 4158 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600103E")]
		[Address(RVA = "0x6248", Offset = "0x6248", VA = "0x6248")]
		public ClanBuildingInfoViewMediator(uint buildingTypeId, ClanIsleModel model, ClanIsleEvents events, ClanIsleController controller)
		{
		/* --- GHIDRA: <ShowConfirmCancelBuildWindow>b__14_0 ---
		undefined4
		UI_Windows_Buildings_ClanBuildingInfoViewMediator___ShowConfirmCancelBuildWindow_b__14_0
		          (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a58ab3 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_12679);
		    DAT_ram_00a58ab3 = '\x01';
		  }
		  return StringLiteral_12679;
		}
		*/

		/* --- GHIDRA: <ViewOnRequestAccelerateBuildEvent>b__10_0 ---
		void UI_Windows_Buildings_ClanBuildingInfoViewMediator___ViewOnRequestAccelerateBuildEvent_b__10_0
		               (int *param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 param1_00;
		  undefined4 param2_00;
		  
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		  param2_00 = UnityEngine_AndroidJavaObject___GetRawObject(param3,0);
		  Gameplay_Isles_Clan_Controller_ClanIsleController__AccelerateBuild(param1_00,param2_00,0);
		  return;
		}
		*/

		/* --- GHIDRA: .ctor ---
		void UI_Windows_Buildings_ClanBuildingInfoViewMediator___ctor
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a58aad == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanIsleModel__ClanIsleEvents__ClanIsleController__ClanBuildingInfoView__set_View__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_Buildings_BaseBuildingInfoView_ClanIsle__add_RequestAccelerateBuildEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_Buildings_BaseBuildingInfoView_ClanIsle__add_RequestCancelBuildEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_Buildings_BaseBuildingInfoView_ClanIsle__add_RequestStartBuildEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_Buildings_BaseBuildingInfoView_ClanIsle__remove_RequestAccelerateBuildEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_Buildings_BaseBuildingInfoView_ClanIsle__remove_RequestCancelBuildEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_Buildings_BaseBuildingInfoView_ClanIsle__remove_RequestStartBuildEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_Buildings_ClanBuildingInfoViewMediator_ViewOnRequestAccelerateBuildEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_Buildings_ClanBuildingInfoViewMediator_ViewOnRequestCancelBuildEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_Buildings_ClanBuildingInfoViewMediator_ViewOnRequestStartBuildEvent__
		              );
		    DAT_ram_00a58aad = '\x01';
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
		               Method_UI_Windows_Buildings_ClanBuildingInfoViewMediator_ViewOnRequestStartBuildEvent__
		               ,0);
		    UI_Windows_Buildings_BaseBuildingInfoView_object___remove_RequestCancelBuildEvent
		              (uVar1,uVar3,
		               Method_UI_Windows_Buildings_BaseBuildingInfoView_ClanIsle__remove_RequestStartBuildEvent__
		              );
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_UI_Windows_Buildings_ClanBuildingInfoViewMediator_ViewOnRequestAccelerateBuildEvent__
		               ,0);
		    UI_Windows_Buildings_BaseBuildingInfoView_object___get_TitleLabel
		              (uVar1,uVar3,
		               Method_UI_Windows_Buildings_BaseBuildingInfoView_ClanIsle__remove_RequestAccelerateBuildEvent__
		              );
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_UI_Windows_Buildings_ClanBuildingInfoViewMediator_ViewOnRequestCancelBuildEvent__
		               ,0);
		    UI_Windows_Buildings_BaseBuildingInfoView_object___remove_RequestAccelerateBuildEvent
		              (uVar1,uVar3,
		               Method_UI_Windows_Buildings_BaseBuildingInfoView_ClanIsle__remove_RequestCancelBuildEvent__
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
		               Method_UI_Windows_Buildings_ClanBuildingInfoViewMediator_ViewOnRequestStartBuildEvent__
		               ,0);
		    UI_Windows_Buildings_BaseBuildingInfoView_object___add_RequestCancelBuildEvent
		              (uVar1,uVar3,
		               Method_UI_Windows_Buildings_BaseBuildingInfoView_ClanIsle__add_RequestStartBuildEvent__
		              );
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_UI_Windows_Buildings_ClanBuildingInfoViewMediator_ViewOnRequestAccelerateBuildEvent__
		               ,0);
		    UI_Windows_Buildings_BaseBuildingInfoView_object___ShowMaxLevelState
		              (uVar1,uVar3,
		               Method_UI_Windows_Buildings_BaseBuildingInfoView_ClanIsle__add_RequestAccelerateBuildEvent__
		              );
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_UI_Windows_Buildings_ClanBuildingInfoViewMediator_ViewOnRequestCancelBuildEvent__
		               ,0);
		    UI_Windows_Buildings_BaseBuildingInfoView_object___add_RequestAccelerateBuildEvent
		              (uVar1,uVar3,
		               Method_UI_Windows_Buildings_BaseBuildingInfoView_ClanIsle__add_RequestCancelBuildEvent__
		              );
		    UI_Windows_Buildings_ClanBuildingInfoViewMediator__ViewOnRequestStartBuildEvent
		              (param1,param1[6],param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x1700025B RID: 603
		// (set) Token: 0x0600103F RID: 4159 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700025B")]
		public override ClanBuildingInfoView View
		{
			[Token(Token = "0x600103F")]
			[Address(RVA = "0x6249", Offset = "0x6249", VA = "0x6249", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x1700025C RID: 604
		// (set) Token: 0x06001040 RID: 4160 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700025C")]
		public override ClanIsleEvents Events
		{
			[Token(Token = "0x6001040")]
			[Address(RVA = "0x624A", Offset = "0x624A", VA = "0x624A", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x06001041 RID: 4161 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001041")]
		[Address(RVA = "0x624B", Offset = "0x624B", VA = "0x624B")]
		private void BuildingStateChangedEventHandler(uint buildingTypeId)
		{
		/* --- GHIDRA: BuildingStateChangedEventHandler ---
		void UI_Windows_Buildings_ClanBuildingInfoViewMediator__BuildingStateChangedEventHandler
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a58aab == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanIsleModel__ClanIsleEvents__ClanIsleController__ClanBuildingInfoView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__BaseBuildingData__get_Item__);
		    DAT_ram_00a58aab = '\x01';
		  }
		  param2_00 = System_Collections_Generic_List_object___get_Item
		                        (*(undefined4 *)(*(int *)(param1 + 8) + 0x24),*(undefined4 *)(param1 + 0x18)
		                         ,
		                         Method_System_Collections_Generic_Dictionary_uint__BaseBuildingData__get_Item__
		                        );
		  UI_Windows_Buildings_ClanBuildingInfoViewMediator__UpdateView(param1,param2_00,param1);
		  return;
		}
		*/

		}

		// Token: 0x06001042 RID: 4162 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001042")]
		[Address(RVA = "0x624C", Offset = "0x624C", VA = "0x624C")]
		private void ViewOnRequestCancelBuildEvent()
		{
		/* --- GHIDRA: ViewOnRequestCancelBuildEvent ---
		void UI_Windows_Buildings_ClanBuildingInfoViewMediator__ViewOnRequestCancelBuildEvent
		               (int param1,undefined4 param2)
		
		{
		  undefined4 in_register_20000014;
		  undefined8 uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  float fVar5;
		  uint *puVar6;
		  undefined4 uVar7;
		  double param3;
		  int *piVar8;
		  undefined4 param1_00;
		  uint uVar9;
		  
		  if (DAT_ram_00a58aaf == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_Buildings_ClanBuildingInfoViewMediator__ViewOnRequestAccelerateBuildEvent_b__10_0__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_21206);
		    DAT_ram_00a58aaf = '\x01';
		  }
		  if (DAT_ram_00a58aab == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanIsleModel__ClanIsleEvents__ClanIsleController__ClanBuildingInfoView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__BaseBuildingData__get_Item__);
		    DAT_ram_00a58aab = '\x01';
		  }
		  uVar2 = System_Collections_Generic_List_object___get_Item
		                    (*(undefined4 *)(*(int *)(param1 + 8) + 0x24),*(undefined4 *)(param1 + 0x18),
		                     Method_System_Collections_Generic_Dictionary_uint__BaseBuildingData__get_Item__
		                    );
		  iVar3 = Newtonsoft_Json_Converters_XDeclarationWrapper__get_Encoding(uVar2,0);
		  if (DAT_ram_00a58aab == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanIsleModel__ClanIsleEvents__ClanIsleController__ClanBuildingInfoView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__BaseBuildingData__get_Item__);
		    DAT_ram_00a58aab = '\x01';
		  }
		  iVar4 = System_Collections_Generic_List_object___get_Item
		                    (*(undefined4 *)(*(int *)(param1 + 8) + 0x24),*(undefined4 *)(param1 + 0x18),
		                     Method_System_Collections_Generic_Dictionary_uint__BaseBuildingData__get_Item__
		                    );
		  fVar5 = func_ii_7103(*(undefined4 *)(iVar4 + 0x14),0);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar9 = 0;
		  piVar8 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar4 = *piVar8;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar9 * 8)) {
		        puVar6 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar9 * 8 + 4) * 8 + iVar4 + 0x178);
		        goto code_r0x80f6fd7f;
		      }
		      uVar9 = uVar9 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar9);
		  }
		  puVar6 = (uint *)func_ii_1080(piVar8,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80f6fd7f:
		  uVar1 = CONCAT44(in_register_20000014,puVar6[1]);
		  uVar7 = (**(code **)((ulonglong)*puVar6 * 4))(piVar8,uVar1);
		  uVar2 = (undefined4)((ulonglong)uVar1 >> 0x20);
		  uVar7 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar7,0);
		  param3 = Core_Extensions_Dict_DictExt__GetIntParameter(uVar7,StringLiteral_21206,0);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar8 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar4 = *piVar8;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar9 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar9 * 8)) {
		        puVar6 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar9 * 8 + 4) * 8 + iVar4 + 0x230);
		        goto code_r0x80f6fe3f;
		      }
		      uVar9 = uVar9 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar9);
		  }
		  puVar6 = (uint *)func_ii_1080(piVar8,Core_Gameplay_IGame_TypeInfo,0x2e);
		code_r0x80f6fe3f:
		  iVar4 = (**(code **)((ulonglong)*puVar6 * 4))(piVar8,CONCAT44(uVar2,puVar6[1]));
		  uVar7 = *(undefined4 *)(*(int *)(*(int *)(iVar4 + 0x10) + 0x18) + 8);
		  uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,param1,
		             Method_UI_Windows_Buildings_ClanBuildingInfoViewMediator__ViewOnRequestAccelerateBuildEvent_b__10_0__
		             ,0);
		  param1_00 = 3;
		  if (iVar3 == 0) {
		    param1_00 = 2;
		  }
		  UI_Windows_ConfirmAccelerateWindow__Show(param1_00,(double)fVar5,param3,uVar7,uVar2,0);
		  return;
		}
		*/

		}

		// Token: 0x06001043 RID: 4163 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001043")]
		[Address(RVA = "0x624D", Offset = "0x624D", VA = "0x624D")]
		private void ViewOnRequestAccelerateBuildEvent()
		{
		/* --- GHIDRA: ViewOnRequestAccelerateBuildEvent ---
		void UI_Windows_Buildings_ClanBuildingInfoViewMediator__ViewOnRequestAccelerateBuildEvent
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param2_00;
		  undefined4 uVar1;
		  
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		  if (DAT_ram_00a58aab == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanIsleModel__ClanIsleEvents__ClanIsleController__ClanBuildingInfoView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__BaseBuildingData__get_Item__);
		    DAT_ram_00a58aab = '\x01';
		  }
		  param2_00 = System_Collections_Generic_List_object___get_Item
		                        (*(undefined4 *)(param1[2] + 0x24),param1[6],
		                         Method_System_Collections_Generic_Dictionary_uint__BaseBuildingData__get_Item__
		                        );
		  if (DAT_ram_00a58aab == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanIsleModel__ClanIsleEvents__ClanIsleController__ClanBuildingInfoView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__BaseBuildingData__get_Item__);
		    DAT_ram_00a58aab = '\x01';
		  }
		  uVar1 = System_Collections_Generic_List_object___get_Item
		                    (*(undefined4 *)(param1[2] + 0x24),param1[6],
		                     Method_System_Collections_Generic_Dictionary_uint__BaseBuildingData__get_Item__
		                    );
		  uVar1 = UnityEngine_AndroidJavaObject___GetRawObject(uVar1,0);
		  Gameplay_Isles_Clan_Controller_ClanIsleController__SetIsleInformation(param1_00,param2_00,uVar1,0)
		  ;
		  return;
		}
		*/

		}

		// Token: 0x06001044 RID: 4164 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001044")]
		[Address(RVA = "0x624E", Offset = "0x624E", VA = "0x624E")]
		private void ViewOnRequestStartBuildEvent()
		{
		/* --- GHIDRA: ViewOnRequestStartBuildEvent ---
		void UI_Windows_Buildings_ClanBuildingInfoViewMediator__ViewOnRequestStartBuildEvent
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int *piVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  uint *puVar5;
		  longlong lVar6;
		  longlong lVar7;
		  uint uVar8;
		  
		  if (DAT_ram_00a58ab0 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanIsleModel__ClanIsleEvents__ClanIsleController__ClanBuildingInfoView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_Buildings_BaseBuildingInfoView_ClanIsle__ShowBuildingState__);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_Buildings_BaseBuildingInfoView_ClanIsle__ShowDefaultState__);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_Buildings_BaseBuildingInfoView_ClanIsle__ShowMaxLevelState__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Discounts_Model_IDiscountHandler_TypeInfo);
		    DAT_ram_00a58ab0 = '\x01';
		  }
		  if (param1[6] == param2) {
		    UI_Windows_Buildings_ClanBuildingInfoViewMediator__BuildingStateChanged(param1,param1);
		    if (DAT_ram_00a58aab == 0) {
		      Mono_Security_ASN1__get_Item
		                (&
		                 Method_MVC_AbstractViewMediator_ClanIsleModel__ClanIsleEvents__ClanIsleController__ClanBuildingInfoView__get_Model__
		                );
		      Mono_Security_ASN1__get_Item
		                (&Method_System_Collections_Generic_Dictionary_uint__BaseBuildingData__get_Item__);
		      DAT_ram_00a58aab = 1;
		    }
		    piVar1 = (int *)System_Collections_Generic_List_object___get_Item
		                              (*(undefined4 *)(param1[2] + 0x24),param1[6],
		                               Method_System_Collections_Generic_Dictionary_uint__BaseBuildingData__get_Item__
		                              );
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x120) * 4))
		                      (piVar1,*(undefined4 *)(*piVar1 + 0x124));
		    if (iVar2 != 0) {
		      uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      UI_Windows_Buildings_BaseBuildingInfoView_object___ShowDefaultState
		                (uVar3,
		                 Method_UI_Windows_Buildings_BaseBuildingInfoView_ClanIsle__ShowMaxLevelState__);
		      return;
		    }
		    if (DAT_ram_00a58aab == 0) {
		      Mono_Security_ASN1__get_Item
		                (&
		                 Method_MVC_AbstractViewMediator_ClanIsleModel__ClanIsleEvents__ClanIsleController__ClanBuildingInfoView__get_Model__
		                );
		      Mono_Security_ASN1__get_Item
		                (&Method_System_Collections_Generic_Dictionary_uint__BaseBuildingData__get_Item__);
		      DAT_ram_00a58aab = 1;
		    }
		    uVar3 = System_Collections_Generic_List_object___get_Item
		                      (*(undefined4 *)(param1[2] + 0x24),param1[6],
		                       Method_System_Collections_Generic_Dictionary_uint__BaseBuildingData__get_Item__
		                      );
		    iVar2 = func_ii_8742(uVar3,0);
		    uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    if (iVar2 != 0) {
		      if ((DAT_ram_00a58aab & 1) == 0) {
		        Mono_Security_ASN1__get_Item
		                  (&
		                   Method_MVC_AbstractViewMediator_ClanIsleModel__ClanIsleEvents__ClanIsleController__ClanBuildingInfoView__get_Model__
		                  );
		        Mono_Security_ASN1__get_Item
		                  (&Method_System_Collections_Generic_Dictionary_uint__BaseBuildingData__get_Item__)
		        ;
		        DAT_ram_00a58aab = 1;
		      }
		      uVar4 = System_Collections_Generic_List_object___get_Item
		                        (*(undefined4 *)(param1[2] + 0x24),param1[6],
		                         Method_System_Collections_Generic_Dictionary_uint__BaseBuildingData__get_Item__
		                        );
		      iVar2 = UI_Windows_Buildings_BaseBuildingInfoView_object___Init
		                        (uVar3,uVar4,*(undefined4 *)(param1[2] + 8),
		                         Method_UI_Windows_Buildings_BaseBuildingInfoView_ClanIsle__ShowBuildingState__
		                        );
		      uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(iVar2 + 0x18),0);
		      lVar6 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                        (*(undefined4 *)(*(int *)(param1[2] + 0x30) + 0x14),0);
		      lVar7 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                        (*(undefined4 *)(param1[2] + 8),0);
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (uVar3,(uint)(lVar6 == lVar7),0);
		      uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(iVar2 + 0x1c),0);
		      lVar6 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                        (*(undefined4 *)(*(int *)(param1[2] + 0x30) + 0x14),0);
		      lVar7 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                        (*(undefined4 *)(param1[2] + 8),0);
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (uVar3,(uint)(lVar6 == lVar7),0);
		      return;
		    }
		    if ((DAT_ram_00a58aab & 1) == 0) {
		      Mono_Security_ASN1__get_Item
		                (&
		                 Method_MVC_AbstractViewMediator_ClanIsleModel__ClanIsleEvents__ClanIsleController__ClanBuildingInfoView__get_Model__
		                );
		      Mono_Security_ASN1__get_Item
		                (&Method_System_Collections_Generic_Dictionary_uint__BaseBuildingData__get_Item__);
		      DAT_ram_00a58aab = 1;
		    }
		    uVar4 = System_Collections_Generic_List_object___get_Item
		                      (*(undefined4 *)(param1[2] + 0x24),param1[6],
		                       Method_System_Collections_Generic_Dictionary_uint__BaseBuildingData__get_Item__
		                      );
		    uVar3 = UI_Windows_Buildings_BaseBuildingInfoView_object___ShowBuildingState
		                      (uVar3,uVar4,*(undefined4 *)(param1[2] + 8),
		                       Method_UI_Windows_Buildings_BaseBuildingInfoView_ClanIsle__ShowDefaultState__
		                      );
		    piVar1 = *(int **)(param1[2] + 0x20);
		    if (piVar1 != (int *)0x0) {
		      iVar2 = *piVar1;
		      if (*(ushort *)(iVar2 + 0xb6) != 0) {
		        uVar8 = 0;
		        do {
		          if (Gameplay_Discounts_Model_IDiscountHandler_TypeInfo ==
		              *(int *)(*(int *)(iVar2 + 0x58) + uVar8 * 8)) {
		            puVar5 = (uint *)(iVar2 + *(int *)(*(int *)(iVar2 + 0x58) + uVar8 * 8 + 4) * 8 + 0xc0);
		            goto code_r0x80f6f3b5;
		          }
		          uVar8 = uVar8 + 1;
		        } while (*(ushort *)(iVar2 + 0xb6) != uVar8);
		      }
		      puVar5 = (uint *)func_ii_1080(piVar1,Gameplay_Discounts_Model_IDiscountHandler_TypeInfo,0);
		code_r0x80f6f3b5:
		      (**(code **)((ulonglong)*puVar5 * 4))(piVar1,uVar3,puVar5[1]);
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001045 RID: 4165 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001045")]
		[Address(RVA = "0x624F", Offset = "0x624F", VA = "0x624F")]
		private void BuildingStateChanged(uint buildingTypeId)
		{
		/* --- GHIDRA: BuildingStateChanged ---
		void UI_Windows_Buildings_ClanBuildingInfoViewMediator__BuildingStateChanged
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  int *piVar3;
		  undefined4 uVar4;
		  uint *puVar5;
		  undefined4 uVar6;
		  int *piVar7;
		  
		  if (DAT_ram_00a58ab1 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_Buildings_BaseBuildingInfoView_ClanIsle__get_DescLabel__);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_Buildings_BaseBuildingInfoView_ClanIsle__get_LevelCounter__);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_Buildings_BaseBuildingInfoView_ClanIsle__get_TitleLabel__);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a58ab1 = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  piVar7 = *(int **)(iVar2 + 0x10);
		  if (DAT_ram_00a58aab == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanIsleModel__ClanIsleEvents__ClanIsleController__ClanBuildingInfoView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__BaseBuildingData__get_Item__);
		    DAT_ram_00a58aab = '\x01';
		  }
		  piVar3 = (int *)System_Collections_Generic_List_object___get_Item
		                            (*(undefined4 *)(param1[2] + 0x24),param1[6],
		                             Method_System_Collections_Generic_Dictionary_uint__BaseBuildingData__get_Item__
		                            );
		  uVar4 = (**(code **)((ulonglong)*(uint *)(*piVar3 + 0xe8) * 4))
		                    (piVar3,*(undefined4 *)(*piVar3 + 0xec));
		  iVar2 = *piVar7;
		  (**(code **)((ulonglong)*(uint *)(iVar2 + 0x2d0) * 4))
		            (piVar7,uVar4,*(undefined4 *)(iVar2 + 0x2d4));
		  if (DAT_ram_00a58aab == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanIsleModel__ClanIsleEvents__ClanIsleController__ClanBuildingInfoView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__BaseBuildingData__get_Item__);
		    DAT_ram_00a58aab = '\x01';
		  }
		  piVar7 = (int *)System_Collections_Generic_List_object___get_Item
		                            (*(undefined4 *)(param1[2] + 0x24),param1[6],
		                             Method_System_Collections_Generic_Dictionary_uint__BaseBuildingData__get_Item__
		                            );
		  if (DAT_ram_00a58aab == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanIsleModel__ClanIsleEvents__ClanIsleController__ClanBuildingInfoView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__BaseBuildingData__get_Item__);
		    DAT_ram_00a58aab = '\x01';
		  }
		  uVar4 = System_Collections_Generic_List_object___get_Item
		                    (*(undefined4 *)(param1[2] + 0x24),param1[6],
		                     Method_System_Collections_Generic_Dictionary_uint__BaseBuildingData__get_Item__
		                    );
		  uVar4 = Newtonsoft_Json_Converters_XDeclarationWrapper__get_Encoding(uVar4,0);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar3 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar2 = *piVar3;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar5 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x178);
		        goto code_r0x80f6f5a3;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar5 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80f6f5a3:
		  uVar6 = (**(code **)((ulonglong)*puVar5 * 4))(piVar3,puVar5[1]);
		  uVar6 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar6,0);
		  uVar4 = (**(code **)((ulonglong)*(uint *)(*piVar7 + 0x130) * 4))
		                    (piVar7,uVar4,uVar6,*(undefined4 *)(*piVar7 + 0x134));
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  piVar7 = *(int **)(iVar2 + 0x14);
		  if (DAT_ram_00a58aab == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanIsleModel__ClanIsleEvents__ClanIsleController__ClanBuildingInfoView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__BaseBuildingData__get_Item__);
		    DAT_ram_00a58aab = '\x01';
		  }
		  piVar3 = (int *)System_Collections_Generic_List_object___get_Item
		                            (*(undefined4 *)(param1[2] + 0x24),param1[6],
		                             Method_System_Collections_Generic_Dictionary_uint__BaseBuildingData__get_Item__
		                            );
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*piVar3 + 0xf0) * 4))
		                    (piVar3,*(undefined4 *)(*piVar3 + 0xf4));
		  if (iVar2 == 0) {
		    uVar4 = 0;
		  }
		  else {
		    uVar4 = Core_GameLocalization__GetTranslation(iVar2,uVar4,0);
		  }
		  iVar2 = *piVar7;
		  (**(code **)((ulonglong)*(uint *)(iVar2 + 0x2d0) * 4))
		            (piVar7,uVar4,*(undefined4 *)(iVar2 + 0x2d4));
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar4 = *(undefined4 *)(iVar2 + 0x18);
		  if (DAT_ram_00a58aab == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanIsleModel__ClanIsleEvents__ClanIsleController__ClanBuildingInfoView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__BaseBuildingData__get_Item__);
		    DAT_ram_00a58aab = '\x01';
		  }
		  uVar6 = System_Collections_Generic_List_object___get_Item
		                    (*(undefined4 *)(param1[2] + 0x24),param1[6],
		                     Method_System_Collections_Generic_Dictionary_uint__BaseBuildingData__get_Item__
		                    );
		  uVar6 = Newtonsoft_Json_Converters_XDeclarationWrapper__get_Encoding(uVar6,0);
		  UI_Elements_Counters_CounterAutoHide___ctor(uVar4,uVar6,0);
		  return;
		}
		*/

		}

		// Token: 0x06001046 RID: 4166 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001046")]
		[Address(RVA = "0x6250", Offset = "0x6250", VA = "0x6250")]
		private void UpdateView()
		{
		/* --- GHIDRA: UpdateView ---
		undefined4
		UI_Windows_Buildings_ClanBuildingInfoViewMediator__UpdateView
		          (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 param1_00;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  undefined4 *puVar6;
		  int param1_01;
		  uint uVar7;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a58ab2 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanIsleModel__ClanIsleEvents__ClanIsleController__ClanBuildingInfoView__get_Model__
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
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_Buildings_ClanBuildingInfoViewMediator__ShowConfirmCancelBuildWindow_b__14_0__
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
		    DAT_ram_00a58ab2 = '\x01';
		  }
		  uVar5 = *(undefined4 *)(param1 + 8);
		  uVar1 = UnityEngine_AndroidJavaObject___GetRawObject(param2,0);
		  uVar1 = Gameplay_Isles_Clan_Model_ClanIsleModel__SetGolemRecoveryBacktime(uVar5,uVar1,0);
		  iVar2 = Newtonsoft_Json_Converters_XDeclarationWrapper__get_Encoding(param2,0);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  puVar6 = &StringLiteral_3698;
		  if (iVar2 == 0) {
		    puVar6 = &StringLiteral_3697;
		  }
		  uVar5 = func_ii_7508(*puVar6,1,0,1,0,0,0,0);
		  puVar6 = &StringLiteral_4111;
		  if (iVar2 == 0) {
		    puVar6 = &StringLiteral_3696;
		  }
		  param1_00 = func_ii_7508(*puVar6,1,0,1,0,0,0,0);
		  iVar2 = unnamed_function_1417(UI_Windows_DialogWindow_DialogWindowArgs_TypeInfo);
		  if (DAT_ram_00a58a57 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindow_DialogWindowArgs___ctor__
		              );
		    DAT_ram_00a58a57 = '\x01';
		  }
		  UnityEngine_UIElements_BaseCompositeField___Il2CppFullySharedGenericType__object____Il2CppFullySharedGenericType___UpdateMixedValueContent
		            (iVar2,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindow_DialogWindowArgs___ctor__
		            );
		  *(undefined4 *)(iVar2 + 0x18) = uVar5;
		  iVar3 = Mono_Security_ASN1Convert__ToOid
		                    (System_Collections_Generic_KeyValuePair_string__string____TypeInfo,1);
		  uVar1 = Core_Extensions_Dict_ResourceSetExt__ToLocaleString(uVar1,NAN,0,StringLiteral_2556,0,0,0);
		  local_8 = 0;
		  System_Text_Formatting_StringView__get_IsEmpty
		            (&local_8,StringLiteral_26445,uVar1,
		             Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		  *(undefined8 *)(iVar3 + 0x10) = local_8;
		  uVar1 = Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsRewardsTab_ClanWarsRewardsView__GetPlacesText
		                    (param1_00,iVar3,0);
		  *(undefined4 *)(iVar2 + 0x1c) = uVar1;
		  param1_01 = *(int *)(iVar2 + 0x24);
		  iVar3 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs__TypeInfo
		                    );
		  UI_Windows_DialogWindow_DialogWindowArgs___ctor
		            (iVar3,
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
		  *(undefined4 *)(iVar3 + 8) = uVar1;
		  iVar4 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_DialogWindow_DialogWindowArgs__BaseBuildingData__TypeInfo
		                    );
		  *(undefined4 *)(iVar4 + 0xc) = param2;
		  uVar1 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_DialogWindow_DialogWindowArgs__BaseBuildingData__TypeInfo
		                    );
		  UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_object__Int32Enum___Invoke
		            (uVar1,param1,
		             Method_UI_Windows_Buildings_ClanBuildingInfoViewMediator__ShowConfirmCancelBuildWindow_b__14_0__
		             ,0);
		  *(undefined4 *)(iVar4 + 0x10) = uVar1;
		  *(int *)(iVar3 + 0x14) = iVar4;
		  iVar4 = 
		  Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___Add__
		  ;
		  *(int *)(param1_01 + 0x10) = *(int *)(param1_01 + 0x10) + 1;
		  uVar7 = *(uint *)(param1_01 + 0xc);
		  if (uVar7 < *(uint *)(*(int *)(param1_01 + 8) + 0xc)) {
		    *(uint *)(param1_01 + 0xc) = uVar7 + 1;
		    *(int *)(*(int *)(param1_01 + 8) + uVar7 * 4 + 0x10) = iVar3;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (param1_01,iVar3,*(undefined4 *)(*(int *)(*(int *)(iVar4 + 0x10) + 0x60) + 0x38));
		  }
		  if (DAT_ram_00a58a52 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_PopupController_Show_DialogWindow___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12610);
		    DAT_ram_00a58a52 = '\x01';
		  }
		  uVar1 = System_Uri___ctor(0);
		  uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar1,0);
		  uVar1 = Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		                    (uVar1,StringLiteral_12610,iVar2,
		                     Method_UI_Windows_PopupController_Show_DialogWindow___);
		  return uVar1;
		}
		*/

		}

		// Token: 0x06001047 RID: 4167 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001047")]
		[Address(RVA = "0x6251", Offset = "0x6251", VA = "0x6251")]
		private DialogWindow ShowConfirmCancelBuildWindow(BaseBuildingData buildingData)
		{
		/* --- GHIDRA: ShowConfirmCancelBuildWindow ---
		void UI_Windows_Buildings_ClanBuildingInfoViewMediator__ShowConfirmCancelBuildWindow
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param2_00;
		  
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		  if (DAT_ram_00a58aab == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanIsleModel__ClanIsleEvents__ClanIsleController__ClanBuildingInfoView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__BaseBuildingData__get_Item__);
		    DAT_ram_00a58aab = '\x01';
		  }
		  param2_00 = System_Collections_Generic_List_object___get_Item
		                        (*(undefined4 *)(param1[2] + 0x24),param1[6],
		                         Method_System_Collections_Generic_Dictionary_uint__BaseBuildingData__get_Item__
		                        );
		  Gameplay_Isles_Clan_Controller_ClanIsleController__StartBuild(param1_00,param2_00,0);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x04000854 RID: 2132
		[Token(Token = "0x4000854")]
		[FieldOffset(Offset = "0x18")]
		private uint _buildingTypeId;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get__buildingData ---
		void UI_Windows_Buildings_ClanBuildingInfoViewMediator__get__buildingData
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5,
		               undefined4 param6)
		
		{
		  if (DAT_ram_00a58aac == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanIsleModel__ClanIsleEvents__ClanIsleController__ClanBuildingInfoView___ctor__
		              );
		    DAT_ram_00a58aac = '\x01';
		  }
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (param1,param3,param4,param5,
		             Method_MVC_AbstractViewMediator_ClanIsleModel__ClanIsleEvents__ClanIsleController__ClanBuildingInfoView___ctor__
		            );
		  *(undefined4 *)(param1 + 0x18) = param2;
		  return;
		}
		*/


		/* --- GHIDRA: set_View ---
		void UI_Windows_Buildings_ClanBuildingInfoViewMediator__set_View
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a58aae == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanIsleModel__ClanIsleEvents__ClanIsleController__ClanBuildingInfoView__set_Events__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_uint__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_Buildings_ClanBuildingInfoViewMediator_BuildingStateChangedEventHandler__
		              );
		    DAT_ram_00a58aae = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar1 + 0x14);
		    uVar2 = unnamed_function_1417(System_Action_uint__TypeInfo);
		    func_ii_12322(uVar2,param1,
		                  Method_UI_Windows_Buildings_ClanBuildingInfoViewMediator_BuildingStateChangedEventHandler__
		                  ,0);
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
		                  Method_UI_Windows_Buildings_ClanBuildingInfoViewMediator_BuildingStateChangedEventHandler__
		                  ,0);
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


		/* --- GHIDRA: set_Events ---
		void UI_Windows_Buildings_ClanBuildingInfoViewMediator__set_Events
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  UI_Windows_Buildings_ClanBuildingInfoViewMediator__ViewOnRequestStartBuildEvent
		            (param1,param2,param2);
		  return;
		}
		*/

}
