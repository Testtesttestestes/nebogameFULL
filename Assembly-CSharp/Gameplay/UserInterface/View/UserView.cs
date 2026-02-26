using System;
using AssetContent;
using AssetContent.Loaders;
using Core.Data;
using Core.Dict.DictWrappers.Wrappers;
using Gameplay.Tutorial.Guide.Model.Data;
using Gameplay.UserInfo.View;
using Il2CppDummyDll;
using UI.ToolTip;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Gameplay.UserInterface.View
{
	// Token: 0x020003C6 RID: 966
	[Token(Token = "0x20003C6")]
	public class UserView : MonoBehaviour, IToolTipDataProvider, IPointerClickHandler, IEventSystemHandler
	{
		// Token: 0x0600169D RID: 5789 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600169D")]
		[Address(RVA = "0x685E", Offset = "0x685E", VA = "0x685E")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_UserInterface_View_UserView__OnDestroy(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  int iVar4;
		  undefined4 uVar5;
		  int *param1_00;
		  int iVar6;
		  
		  if (DAT_ram_00a58263 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a58263 = '\x01';
		  }
		  if (*(int *)(param1 + 0x1c) != 0) {
		    iVar4 = *(int *)(*(int *)(param1 + 0x1c) + 0x38);
		    if (DAT_ram_00a58268 == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_AprDic__uint__get_Data__);
		      DAT_ram_00a58268 = '\x01';
		    }
		    uVar5 = *(undefined4 *)(param1 + 0x10);
		    uVar2 = Core_Extensions_Dict_AprDicExt__GetAttackAssetId(*(undefined4 *)(iVar4 + 0x10),0);
		    Core_Extensions_Dict_AprDicExt__Get1024AssetId(uVar5,uVar2,0);
		    Gameplay_UserInterface_View_UserView__SetApr(param1,iVar4,iVar4);
		    iVar4 = *(int *)(param1 + 0x18);
		    if (iVar4 != 0) {
		      uVar2 = *(undefined4 *)(param1 + 0x1c);
		      if (DAT_ram_00a6456f == '\0') {
		        Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		        DAT_ram_00a6456f = '\x01';
		      }
		      param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		      iVar6 = *param1_00;
		      if (*(ushort *)(iVar6 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		            puVar3 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x140);
		            goto code_r0x80ec2299;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		      }
		      puVar3 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x80ec2299:
		      uVar5 = (**(code **)((ulonglong)*puVar3 * 4))(param1_00,puVar3[1]);
		      Gameplay_UserInfo_View_UserNickCultLevelExpView__SetCult(iVar4,uVar2,uVar5,0);
		    }
		    uVar2 = *(undefined4 *)(param1 + 0x1c);
		    if (DAT_ram_00a58264 == '\0') {
		      Mono_Security_ASN1__get_Item(&System_Action_AprDicWrapper__TypeInfo);
		      Mono_Security_ASN1__get_Item
		                (&Method_Gameplay_UserInterface_View_UserView_HandleOnUserAprChangedEvent__);
		      DAT_ram_00a58264 = '\x01';
		    }
		    uVar5 = unnamed_function_1417(System_Action_AprDicWrapper__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar5,param1,
		               Method_Gameplay_UserInterface_View_UserView_HandleOnUserAprChangedEvent__,0);
		    Core_Data_UserData__remove_OnUserLevelChangedEvent(uVar2,uVar5,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600169E RID: 5790 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600169E")]
		[Address(RVA = "0x685F", Offset = "0x685F", VA = "0x685F")]
		private void OnEnable()
		{
		/* --- GHIDRA: OnEnable ---
		void Gameplay_UserInterface_View_UserView__OnEnable(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int param1_01;
		  
		  param1_01 = *(int *)(param1 + 0x1c);
		  if (param1_01 != 0) {
		    if (DAT_ram_00a58265 == '\0') {
		      Mono_Security_ASN1__get_Item(&System_Action_AprDicWrapper__TypeInfo);
		      Mono_Security_ASN1__get_Item
		                (&Method_Gameplay_UserInterface_View_UserView_HandleOnUserAprChangedEvent__);
		      DAT_ram_00a58265 = '\x01';
		    }
		    param1_00 = unnamed_function_1417(System_Action_AprDicWrapper__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (param1_00,param1,
		               Method_Gameplay_UserInterface_View_UserView_HandleOnUserAprChangedEvent__,0);
		    Core_Data_UserData__add_OnUserAprChangedEvent(param1_01,param1_00,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600169F RID: 5791 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600169F")]
		[Address(RVA = "0x6860", Offset = "0x6860", VA = "0x6860")]
		private void OnDisable()
		{
		/* --- GHIDRA: OnDisable ---
		void Gameplay_UserInterface_View_UserView__OnDisable
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a58264 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_AprDicWrapper__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_UserInterface_View_UserView_HandleOnUserAprChangedEvent__);
		    DAT_ram_00a58264 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Action_AprDicWrapper__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_UserInterface_View_UserView_HandleOnUserAprChangedEvent__,0);
		  Core_Data_UserData__remove_OnUserLevelChangedEvent(param2,param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x060016A0 RID: 5792 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016A0")]
		[Address(RVA = "0x6861", Offset = "0x6861", VA = "0x6861")]
		private void StartListenEvents(UserData user)
		{
		/* --- GHIDRA: StartListenEvents ---
		void Gameplay_UserInterface_View_UserView__StartListenEvents
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a58265 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_AprDicWrapper__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_UserInterface_View_UserView_HandleOnUserAprChangedEvent__);
		    DAT_ram_00a58265 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Action_AprDicWrapper__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_UserInterface_View_UserView_HandleOnUserAprChangedEvent__,0);
		  Core_Data_UserData__add_OnUserAprChangedEvent(param2,param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x060016A1 RID: 5793 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016A1")]
		[Address(RVA = "0x6862", Offset = "0x6862", VA = "0x6862")]
		private void StopListenEvents(UserData user)
		{
		/* --- GHIDRA: StopListenEvents ---
		int Gameplay_UserInterface_View_UserView__StopListenEvents(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a58266 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_IGuideTarget___);
		    DAT_ram_00a58266 = '\x01';
		  }
		  iVar1 = *(int *)(param1 + 0x20);
		  if (iVar1 == 0) {
		    iVar1 = func_ii_5677(param1,Method_UnityEngine_Component_GetComponent_IGuideTarget___);
		  }
		  *(int *)(param1 + 0x20) = iVar1;
		  return iVar1;
		}
		*/

		}

		// Token: 0x170003D4 RID: 980
		// (get) Token: 0x060016A2 RID: 5794 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170003D4")]
		public IGuideTarget GuideTarget
		{
			[Token(Token = "0x60016A2")]
			[Address(RVA = "0x6863", Offset = "0x6863", VA = "0x6863")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003D5 RID: 981
		// (get) Token: 0x060016A3 RID: 5795 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060016A4 RID: 5796 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003D5")]
		public UserData UserData
		{
			[Token(Token = "0x60016A3")]
			[Address(RVA = "0x6864", Offset = "0x6864", VA = "0x6864")]
			get
			{
				return null;
			}
			[Token(Token = "0x60016A4")]
			[Address(RVA = "0x6865", Offset = "0x6865", VA = "0x6865")]
			set
			{
			}
		}

		// Token: 0x060016A5 RID: 5797 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016A5")]
		[Address(RVA = "0x6866", Offset = "0x6866", VA = "0x6866")]
		private void HandleUserChanged(UserData fromUser, UserData toUser)
		{
		}

		// Token: 0x060016A6 RID: 5798 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016A6")]
		[Address(RVA = "0x6867", Offset = "0x6867", VA = "0x6867")]
		private void HandleOnUserAprChangedEvent(AprDicWrapper apr)
		{
		/* --- GHIDRA: HandleOnUserAprChangedEvent ---
		void Gameplay_Rating_View_UserView__HandleOnUserAprChangedEvent
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a5803c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_AprDic__uint__get_Data__);
		    DAT_ram_00a5803c = '\x01';
		  }
		  param1_00 = *(undefined4 *)(param1 + 0x10);
		  if (param2 == 0) {
		    param2_00 = 0;
		  }
		  else {
		    param2_00 = Core_Extensions_Dict_AprDicExt__GetAttackAssetId(*(undefined4 *)(param2 + 0x10),0);
		  }
		  Core_Extensions_Dict_AprDicExt__Get1024AssetId(param1_00,param2_00,0);
		  return;
		}
		*/

		/* --- GHIDRA: HandleOnUserAprChangedEvent ---
		void Gameplay_UserInterface_View_UserView__HandleOnUserAprChangedEvent
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 param2_00;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a58268 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_AprDic__uint__get_Data__);
		    DAT_ram_00a58268 = '\x01';
		  }
		  param1_00 = *(undefined4 *)(param1 + 0x10);
		  param2_00 = Core_Extensions_Dict_AprDicExt__GetAttackAssetId(*(undefined4 *)(param2 + 0x10),0);
		  Core_Extensions_Dict_AprDicExt__Get1024AssetId(param1_00,param2_00,0);
		  Gameplay_UserInterface_View_UserView__SetApr(param1,param2,param2);
		  return;
		}
		*/

		}

		// Token: 0x060016A7 RID: 5799 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016A7")]
		[Address(RVA = "0x6868", Offset = "0x6868", VA = "0x6868")]
		public void SetApr(AprDicWrapper apr)
		{
		/* --- GHIDRA: SetApr ---
		void Gameplay_Rating_View_UserView__SetApr(int param1,undefined4 param2,undefined4 param3)
		
		{
		  if (*(int *)(param1 + 0x14) != 0) {
		    Gameplay_Rating_View_UserView__OnPointerClick(param1,param1);
		  }
		  return;
		}
		*/

		/* --- GHIDRA: SetApr ---
		void Gameplay_UserInterface_View_UserView__SetApr(int param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  int iVar5;
		  int *param1_00;
		  
		  if (DAT_ram_00a58269 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_AprDic__uint__get_Data__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_AssetContent_Loaders_AbstractGameGraphicLoader_RawImage__Texture2D__set_AssetId__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a58269 = '\x01';
		  }
		  iVar5 = *(int *)(*(int *)(param2 + 0x10) + 0x24);
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x14),0);
		  if (iVar5 == 0) {
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar2,0,0);
		    return;
		  }
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar2,1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x14);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar5 = *param1_00;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x178);
		        goto code_r0x80ec2403;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80ec2403:
		  uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(param1_00,puVar3[1]);
		  uVar4 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar4,0);
		  uVar4 = Core_Extensions_Dict_DictExt__GetEventTagDic
		                    (uVar4,*(undefined4 *)(*(int *)(param2 + 0x10) + 0x28),0);
		  uVar4 = Core_Extensions_Dict_CollectionRankInfoDicExt__GetAprRibbonAssetId(uVar4,0);
		  Core_Extensions_Dict_CultDicExt__GetIcon64AssetId
		            (uVar2,uVar4,
		             Method_AssetContent_Loaders_AbstractGameGraphicLoader_RawImage__Texture2D__set_AssetId__
		            );
		  return;
		}
		*/

		}

		// Token: 0x060016A8 RID: 5800 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016A8")]
		[Address(RVA = "0x6869", Offset = "0x6869", VA = "0x6869")]
		private void DrawRibbon(AprDicWrapper apr)
		{
		/* --- GHIDRA: DrawRibbon ---
		void Gameplay_UserInterface_View_UserView__DrawRibbon
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  undefined4 param1_01;
		  int *param1_02;
		  int iVar3;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a5826a == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_UserInfo_View_UserInfoWindow_UserInfoWindowArgs_TypeInfo)
		    ;
		    DAT_ram_00a5826a = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_02 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar3 = *param1_02;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x1b0);
		        goto code_r0x80ec268f;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_02,Core_Gameplay_IGame_TypeInfo,0x1e);
		code_r0x80ec268f:
		  param1_00 = (**(code **)((ulonglong)*puVar2 * 4))(param1_02,puVar2[1]);
		  param2_00 = *(undefined4 *)(param1 + 0x1c);
		  param1_01 = unnamed_function_1417
		                        (Gameplay_UserInfo_View_UserInfoWindow_UserInfoWindowArgs_TypeInfo);
		  Core_Browser_BrowserWindow___ctor(param1_01,param2_00,0);
		  Core_Gameplay_Managers_GameActivityRouting_GameFeatureRouterManager__ShowCraft
		            (param1_00,param1_01,0);
		  return;
		}
		*/

		}

		// Token: 0x060016A9 RID: 5801 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016A9")]
		[Address(RVA = "0x686A", Offset = "0x686A", VA = "0x686A", Slot = "5")]
		public void OnPointerClick(PointerEventData eventData)
		{
		/* --- GHIDRA: OnPointerClick ---
		void Gameplay_Rating_View_UserView__OnPointerClick(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int param3;
		  undefined4 param2_00;
		  undefined8 local_18;
		  undefined8 local_10 [2];
		  
		  if (DAT_ram_00a5803d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_ContextMenu_ContextMenuController_Show_UserContextMenu_MenuContext__UserContextMenu___
		              );
		    Mono_Security_ASN1__get_Item(&UI_UserContextMenu_UserContextMenu_MenuContext_TypeInfo);
		    DAT_ram_00a5803d = '\x01';
		  }
		  uVar1 = System_Uri___ctor(0);
		  uVar1 = Google_Protobuf_Reflection_EnumValueDescriptor__get_Name(uVar1,0);
		  param3 = unnamed_function_1417(UI_UserContextMenu_UserContextMenu_MenuContext_TypeInfo);
		  *(undefined4 *)(param3 + 8) = *(undefined4 *)(param1 + 0x14);
		  param2_00 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                        (param1,0);
		  func_ii_7888(local_10,param2_00,0);
		  local_18 = local_10[0];
		  UI_ContextMenu_ContextMenuController___Show_b__13_0___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType_
		            (uVar1,1,param3,&local_18,
		             Method_UI_ContextMenu_ContextMenuController_Show_UserContextMenu_MenuContext__UserContextMenu___
		            );
		  return;
		}
		*/

		/* --- GHIDRA: OnPointerClick ---
		int Gameplay_UserInterface_View_UserView__OnPointerClick(int param1,undefined4 param2)
		
		{
		  int param1_00;
		  
		  if (DAT_ram_00a5826b == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_ToolTip_ToolTipData_UserData___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_UI_ToolTip_ToolTipData_UserData__set_Data__);
		    Mono_Security_ASN1__get_Item(&UI_ToolTip_ToolTipData_UserData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12544);
		    DAT_ram_00a5826b = '\x01';
		  }
		  param1_00 = unnamed_function_1417(UI_ToolTip_ToolTipData_UserData__TypeInfo);
		  System_Buffers_TlsOverPerCoreLockedStacksArrayPool___Il2CppFullySharedGenericType___get_Id
		            (param1_00,StringLiteral_12544,Method_UI_ToolTip_ToolTipData_UserData___ctor__);
		  *(undefined4 *)(param1_00 + 0x1c) = *(undefined4 *)(param1 + 0x1c);
		  return param1_00;
		}
		*/

		}

		// Token: 0x060016AA RID: 5802 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60016AA")]
		[Address(RVA = "0x686B", Offset = "0x686B", VA = "0x686B", Slot = "4")]
		public BaseToolTipData GetData()
		{
			return null;
		}

		// Token: 0x060016AB RID: 5803 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016AB")]
		[Address(RVA = "0x686C", Offset = "0x686C", VA = "0x686C")]
		public UserView()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Rating_View_UserView___ctor(int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  int *param1_00;
		  int iVar5;
		  undefined4 *puVar6;
		  int param1_01;
		  int param1_02;
		  
		  if (DAT_ram_00a5803f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_ToDictionary_UserRatingKindDic__uint__SubRatingInfo___
		              );
		    Mono_Security_ASN1__get_Item(&System_Func_UserRatingKindDic__SubRatingInfo__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_UserRatingKindDic__uint__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_Rating_Model_RatingInfo___c___ctor_b__3_0__);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_Rating_Model_RatingInfo___c___ctor_b__3_1__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Rating_Model_RatingInfo___c_TypeInfo);
		    DAT_ram_00a5803f = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar5 = *param1_00;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x178);
		        goto code_r0x80e976a7;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80e976a7:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  uVar3 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar3,0);
		  uVar3 = Core_Extensions_Dict_DictExt__GetCultRatingKindDic(uVar3,1,0);
		  uVar3 = Core_Extensions_DateTimeExt__ToGregorianCalenderTimeString(uVar3,0);
		  if (*(int *)(Gameplay_Rating_Model_RatingInfo___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Rating_Model_RatingInfo___c_TypeInfo);
		  }
		  puVar6 = *(undefined4 **)(Gameplay_Rating_Model_RatingInfo___c_TypeInfo + 0x5c);
		  param1_01 = puVar6[1];
		  iVar5 = Gameplay_Rating_Model_RatingInfo___c_TypeInfo;
		  if (param1_01 == 0) {
		    if (*(int *)(Gameplay_Rating_Model_RatingInfo___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_Rating_Model_RatingInfo___c_TypeInfo);
		      puVar6 = *(undefined4 **)(Gameplay_Rating_Model_RatingInfo___c_TypeInfo + 0x5c);
		    }
		    uVar4 = *puVar6;
		    param1_01 = unnamed_function_1417(System_Func_UserRatingKindDic__uint__TypeInfo);
		    System_Collections_Generic_Dictionary_KeyCollection_uint__object___GetEnumerator
		              (param1_01,uVar4,Method_Gameplay_Rating_Model_RatingInfo___c___ctor_b__3_0__,0);
		    iVar5 = Gameplay_Rating_Model_RatingInfo___c_TypeInfo;
		    *(int *)(*(int *)(Gameplay_Rating_Model_RatingInfo___c_TypeInfo + 0x5c) + 4) = param1_01;
		  }
		  if (*(int *)(iVar5 + 0x74) == 0) {
		    func_ii_306000(iVar5);
		    iVar5 = Gameplay_Rating_Model_RatingInfo___c_TypeInfo;
		  }
		  puVar6 = *(undefined4 **)(iVar5 + 0x5c);
		  param1_02 = puVar6[2];
		  if (param1_02 == 0) {
		    if (*(int *)(iVar5 + 0x74) == 0) {
		      func_ii_306000(iVar5);
		      puVar6 = *(undefined4 **)(Gameplay_Rating_Model_RatingInfo___c_TypeInfo + 0x5c);
		    }
		    uVar4 = *puVar6;
		    param1_02 = unnamed_function_1417(System_Func_UserRatingKindDic__SubRatingInfo__TypeInfo);
		    System_Linq_Enumerable__Where_object_
		              (param1_02,uVar4,Method_Gameplay_Rating_Model_RatingInfo___c___ctor_b__3_1__,0);
		    *(int *)(*(int *)(Gameplay_Rating_Model_RatingInfo___c_TypeInfo + 0x5c) + 8) = param1_02;
		  }
		  uVar4 = System_Linq_Enumerable__ToDictionary_object__object__object_
		                    (param2,param1_01,param1_02,
		                     Method_System_Linq_Enumerable_ToDictionary_UserRatingKindDic__uint__SubRatingInfo___
		                    );
		  *(undefined4 *)(param1 + 0x10) = uVar4;
		  *(undefined4 *)(param1 + 0xc) = uVar3;
		  *(undefined4 *)(param1 + 8) = 1;
		  return;
		}
		*/

		/* --- GHIDRA: .ctor ---
		void Gameplay_UserInterface_View_UserView___ctor(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a5826c == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a5826c = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x18);
		  while ((param1_01 = (int *)UnityEngine_UI_Image__set_sprite(param1_00,param2,0),
		         param1_01 == (int *)0x0 || (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x18,param1_01,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
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

		// Token: 0x04000BF1 RID: 3057
		[Token(Token = "0x4000BF1")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private GameAssetViewRawImage _avatar;

		// Token: 0x04000BF2 RID: 3058
		[Token(Token = "0x4000BF2")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private GameRawImageLoader _ribbon;

		// Token: 0x04000BF3 RID: 3059
		[Token(Token = "0x4000BF3")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UserNickCultLevelExpView _userInfoBar;

		// Token: 0x04000BF4 RID: 3060
		[Token(Token = "0x4000BF4")]
		[FieldOffset(Offset = "0x1C")]
		private UserData _userData;

		// Token: 0x04000BF5 RID: 3061
		[Token(Token = "0x4000BF5")]
		[FieldOffset(Offset = "0x20")]
		private IGuideTarget _guideTarget;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_UserData ---
		void Gameplay_UserInterface_View_UserView__get_UserData(int param1,int param2,undefined4 param3)
		
		{
		  int param2_00;
		  
		  param2_00 = *(int *)(param1 + 0x1c);
		  if (param2 != param2_00) {
		    *(int *)(param1 + 0x1c) = param2;
		    Gameplay_UserInterface_View_UserView__set_UserData(param1,param2_00,param2,param1);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_UserData ---
		void Gameplay_UserInterface_View_UserView__set_UserData
		               (int param1,int param2,int param3,undefined4 param4)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar5;
		  
		  if (DAT_ram_00a58267 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a58267 = '\x01';
		  }
		  if (*(int *)(param1 + 0x18) != 0) {
		    uVar4 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(int *)(param1 + 0x18),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar4,(uint)(param3 != 0),0);
		  }
		  iVar2 = func_ii_12174(param1,0);
		  if (iVar2 != 0) {
		    if (param3 != 0) {
		      iVar2 = *(int *)(param3 + 0x38);
		      if (DAT_ram_00a58268 == '\0') {
		        Mono_Security_ASN1__get_Item
		                  (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_AprDic__uint__get_Data__)
		        ;
		        DAT_ram_00a58268 = '\x01';
		      }
		      param1_00 = *(undefined4 *)(param1 + 0x10);
		      uVar4 = Core_Extensions_Dict_AprDicExt__GetAttackAssetId(*(undefined4 *)(iVar2 + 0x10),0);
		      Core_Extensions_Dict_AprDicExt__Get1024AssetId(param1_00,uVar4,0);
		      Gameplay_UserInterface_View_UserView__SetApr(param1,iVar2,iVar2);
		      iVar2 = *(int *)(param1 + 0x18);
		      if (iVar2 != 0) {
		        if (DAT_ram_00a6456f == '\0') {
		          Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		          DAT_ram_00a6456f = '\x01';
		        }
		        param1_01 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		        iVar5 = *param1_01;
		        if (*(ushort *)(iVar5 + 0xb6) != 0) {
		          uVar1 = 0;
		          do {
		            if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		              puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x140
		                               );
		              goto code_r0x80ec209e;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		        }
		        puVar3 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x80ec209e:
		        uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(param1_01,puVar3[1]);
		        Gameplay_UserInfo_View_UserNickCultLevelExpView__SetCult(iVar2,param3,uVar4,0);
		      }
		      if (DAT_ram_00a58264 == '\0') {
		        Mono_Security_ASN1__get_Item(&System_Action_AprDicWrapper__TypeInfo);
		        Mono_Security_ASN1__get_Item
		                  (&Method_Gameplay_UserInterface_View_UserView_HandleOnUserAprChangedEvent__);
		        DAT_ram_00a58264 = '\x01';
		      }
		      uVar4 = unnamed_function_1417(System_Action_AprDicWrapper__TypeInfo);
		      UnityEngine_UIElements_VisualElement__get_layout
		                (uVar4,param1,
		                 Method_Gameplay_UserInterface_View_UserView_HandleOnUserAprChangedEvent__,0);
		      Core_Data_UserData__remove_OnUserLevelChangedEvent(param3,uVar4,0);
		    }
		    if (param2 != 0) {
		      if (DAT_ram_00a58265 == '\0') {
		        Mono_Security_ASN1__get_Item(&System_Action_AprDicWrapper__TypeInfo);
		        Mono_Security_ASN1__get_Item
		                  (&Method_Gameplay_UserInterface_View_UserView_HandleOnUserAprChangedEvent__);
		        DAT_ram_00a58265 = '\x01';
		      }
		      uVar4 = unnamed_function_1417(System_Action_AprDicWrapper__TypeInfo);
		      UnityEngine_UIElements_VisualElement__get_layout
		                (uVar4,param1,
		                 Method_Gameplay_UserInterface_View_UserView_HandleOnUserAprChangedEvent__,0);
		      Core_Data_UserData__add_OnUserAprChangedEvent(param2,uVar4,0);
		    }
		  }
		  return;
		}
		*/


		/* --- GHIDRA: get_UserData ---
		void Gameplay_Rating_View_UserView__get_UserData(int param1,int param2,undefined4 param3)
		
		{
		  int param2_00;
		  
		  param2_00 = *(int *)(param1 + 0x14);
		  if (param2 != param2_00) {
		    *(int *)(param1 + 0x14) = param2;
		    Gameplay_Rating_View_UserView__set_UserData(param1,param2_00,param2,param1);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_UserData ---
		void Gameplay_Rating_View_UserView__set_UserData(int param1,int param2,int param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a5803b == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_AprDicWrapper__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Rating_View_UserView_HandleOnUserAprChangedEvent__);
		    DAT_ram_00a5803b = '\x01';
		  }
		  if (param3 == 0) {
		    if (DAT_ram_00a5803c == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_AprDic__uint__get_Data__);
		      DAT_ram_00a5803c = '\x01';
		    }
		    Core_Extensions_Dict_AprDicExt__Get1024AssetId(*(undefined4 *)(param1 + 0x10),0,0);
		  }
		  else {
		    iVar2 = *(int *)(param3 + 0x38);
		    if (DAT_ram_00a5803c == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_AprDic__uint__get_Data__);
		      DAT_ram_00a5803c = '\x01';
		    }
		    uVar1 = *(undefined4 *)(param1 + 0x10);
		    if (iVar2 == 0) {
		      param2_00 = 0;
		    }
		    else {
		      param2_00 = Core_Extensions_Dict_AprDicExt__GetAttackAssetId(*(undefined4 *)(iVar2 + 0x10),0);
		    }
		    Core_Extensions_Dict_AprDicExt__Get1024AssetId(uVar1,param2_00,0);
		    uVar1 = unnamed_function_1417(System_Action_AprDicWrapper__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar1,param1,Method_Gameplay_Rating_View_UserView_HandleOnUserAprChangedEvent__,0);
		    Core_Data_UserData__remove_OnUserLevelChangedEvent(param3,uVar1,0);
		  }
		  if (param2 != 0) {
		    uVar1 = unnamed_function_1417(System_Action_AprDicWrapper__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar1,param1,Method_Gameplay_Rating_View_UserView_HandleOnUserAprChangedEvent__,0);
		    Core_Data_UserData__add_OnUserAprChangedEvent(param2,uVar1,0);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: ShowContextMenu ---
		int Gameplay_Rating_View_UserView__ShowContextMenu(int param1,undefined4 param2)
		
		{
		  int param1_00;
		  
		  if (DAT_ram_00a5803e == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_ToolTip_ToolTipData_UserData___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_UI_ToolTip_ToolTipData_UserData__set_Data__);
		    Mono_Security_ASN1__get_Item(&UI_ToolTip_ToolTipData_UserData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12544);
		    DAT_ram_00a5803e = '\x01';
		  }
		  param1_00 = unnamed_function_1417(UI_ToolTip_ToolTipData_UserData__TypeInfo);
		  System_Buffers_TlsOverPerCoreLockedStacksArrayPool___Il2CppFullySharedGenericType___get_Id
		            (param1_00,StringLiteral_12544,Method_UI_ToolTip_ToolTipData_UserData___ctor__);
		  *(undefined4 *)(param1_00 + 0x1c) = *(undefined4 *)(param1 + 0x14);
		  return param1_00;
		}
		*/

}
