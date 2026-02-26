using System;
using Core.Data;
using Gameplay.Antiq;
using Gameplay.UserInfo.Model;
using Gameplay.UserInfo.View.Equipment;
using Il2CppDummyDll;
using MVC;
using UnityEngine.EventSystems;

namespace Gameplay.UserInfo.Control
{
	// Token: 0x02000415 RID: 1045
	[Token(Token = "0x2000415")]
	public class UserEquipmentViewMediator : AbstractCozyViewMediator<UserInfoModel, UserInfoEvents, UserInfoController, UserEquipmentView>
	{
		// Token: 0x0600187D RID: 6269 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600187D")]
		[Address(RVA = "0x6A1D", Offset = "0x6A1D", VA = "0x6A1D", Slot = "14")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_UserInfo_Control_UserEquipmentViewMediator__Dispose
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5,undefined4 param6)
		
		{
		  if (DAT_ram_00a59907 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractCozyViewMediator_UserInfoModel__UserInfoEvents__UserInfoController__UserEquipmentView___ctor__
		              );
		    DAT_ram_00a59907 = '\x01';
		  }
		  MVC_AbstractCozyViewMediator_object__object__object__object____ctor
		            (param1,param2,param3,param4,param5,
		             Method_MVC_AbstractCozyViewMediator_UserInfoModel__UserInfoEvents__UserInfoController__UserEquipmentView___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x0600187E RID: 6270 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600187E")]
		[Address(RVA = "0x6A1E", Offset = "0x6A1E", VA = "0x6A1E")]
		public UserEquipmentViewMediator(UserEquipmentView view, UserInfoModel model, UserInfoEvents events, UserInfoController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_UserInfo_Control_UserEquipmentViewMediator___ctor
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int *piVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a59908 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_UserData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_UserInfo_Control_UserEquipmentViewMediator_HandleInitEvent__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_UserInfo_Control_UserEquipmentViewMediator_HandleUserEquipmentChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_UserInfo_Control_UserEquipmentViewMediator_HandleUserTriggersChangedEvent__
		              );
		    DAT_ram_00a59908 = '\x01';
		  }
		  uVar5 = *(undefined4 *)(param2 + 0x1c);
		  uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar1,param1,
		             Method_Gameplay_UserInfo_Control_UserEquipmentViewMediator_HandleUserEquipmentChangedEvent__
		             ,0);
		  piVar2 = (int *)func_ii_7048(uVar5,uVar1,0);
		  iVar3 = System_Action_TypeInfo;
		  if (piVar2 == (int *)0x0) {
		    *(undefined4 *)(param2 + 0x1c) = 0;
		  }
		  else if ((System_Action_TypeInfo != *piVar2) ||
		          (*(int **)(param2 + 0x1c) = piVar2, *piVar2 != iVar3)) {
		    System_Activator__CreateInstance(piVar2,iVar3);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  uVar5 = *(undefined4 *)(param2 + 0x3c);
		  uVar1 = unnamed_function_1417(System_Action_UserData__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_UserInfo_Control_UserEquipmentViewMediator_HandleUserTriggersChangedEvent__
		             ,0);
		  iVar3 = func_ii_7048(uVar5,uVar1,0);
		  uVar1 = System_Action_UserData__TypeInfo;
		  if (iVar3 == 0) {
		    *(undefined4 *)(param2 + 0x3c) = 0;
		  }
		  else {
		    iVar4 = func_ii_1082(iVar3,System_Action_UserData__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar3,uVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(param2 + 0x3c) = iVar4;
		    uVar1 = System_Action_UserData__TypeInfo;
		    iVar4 = func_ii_1082(iVar3,System_Action_UserData__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar3,uVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  uVar5 = *(undefined4 *)(param2 + 8);
		  uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar1,param1,
		             Method_Gameplay_UserInfo_Control_UserEquipmentViewMediator_HandleInitEvent__,0);
		  piVar2 = (int *)func_ii_7048(uVar5,uVar1,0);
		  iVar3 = System_Action_TypeInfo;
		  if (piVar2 == (int *)0x0) {
		    *(undefined4 *)(param2 + 8) = 0;
		    return;
		  }
		  if ((System_Action_TypeInfo == *piVar2) && (*(int **)(param2 + 8) = piVar2, *piVar2 == iVar3)) {
		    return;
		  }
		  System_Activator__CreateInstance(piVar2,iVar3);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x0600187F RID: 6271 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600187F")]
		[Address(RVA = "0x6A1F", Offset = "0x6A1F", VA = "0x6A1F", Slot = "21")]
		protected override void ResetEvents(UserInfoEvents events)
		{
		/* --- GHIDRA: ResetEvents ---
		void Gameplay_UserInfo_Control_UserEquipmentViewMediator__ResetEvents
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int *piVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a59909 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_UserData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_UserInfo_Control_UserEquipmentViewMediator_HandleInitEvent__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_UserInfo_Control_UserEquipmentViewMediator_HandleUserEquipmentChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_UserInfo_Control_UserEquipmentViewMediator_HandleUserTriggersChangedEvent__
		              );
		    DAT_ram_00a59909 = '\x01';
		  }
		  uVar5 = *(undefined4 *)(param2 + 0x1c);
		  uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar1,param1,
		             Method_Gameplay_UserInfo_Control_UserEquipmentViewMediator_HandleUserEquipmentChangedEvent__
		             ,0);
		  piVar2 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar1,0);
		  iVar3 = System_Action_TypeInfo;
		  if (piVar2 == (int *)0x0) {
		    *(undefined4 *)(param2 + 0x1c) = 0;
		  }
		  else if ((System_Action_TypeInfo != *piVar2) ||
		          (*(int **)(param2 + 0x1c) = piVar2, *piVar2 != iVar3)) {
		    System_Activator__CreateInstance(piVar2,iVar3);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  uVar5 = *(undefined4 *)(param2 + 0x3c);
		  uVar1 = unnamed_function_1417(System_Action_UserData__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_UserInfo_Control_UserEquipmentViewMediator_HandleUserTriggersChangedEvent__
		             ,0);
		  iVar3 = UnityEngine_UI_Image__set_sprite(uVar5,uVar1,0);
		  uVar1 = System_Action_UserData__TypeInfo;
		  if (iVar3 == 0) {
		    *(undefined4 *)(param2 + 0x3c) = 0;
		  }
		  else {
		    iVar4 = func_ii_1082(iVar3,System_Action_UserData__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar3,uVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(param2 + 0x3c) = iVar4;
		    uVar1 = System_Action_UserData__TypeInfo;
		    iVar4 = func_ii_1082(iVar3,System_Action_UserData__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar3,uVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  uVar5 = *(undefined4 *)(param2 + 8);
		  uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar1,param1,
		             Method_Gameplay_UserInfo_Control_UserEquipmentViewMediator_HandleInitEvent__,0);
		  piVar2 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar1,0);
		  iVar3 = System_Action_TypeInfo;
		  if (piVar2 == (int *)0x0) {
		    *(undefined4 *)(param2 + 8) = 0;
		    return;
		  }
		  if ((System_Action_TypeInfo == *piVar2) && (*(int **)(param2 + 8) = piVar2, *piVar2 == iVar3)) {
		    return;
		  }
		  System_Activator__CreateInstance(piVar2,iVar3);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06001880 RID: 6272 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001880")]
		[Address(RVA = "0x6A20", Offset = "0x6A20", VA = "0x6A20", Slot = "22")]
		protected override void SetupEvents(UserInfoEvents events)
		{
		/* --- GHIDRA: SetupEvents ---
		void Gameplay_UserInfo_Control_UserEquipmentViewMediator__SetupEvents
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5990a == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_PointerEventData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_UserEquipmentSlotConfig__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_UserInfo_View_Equipment_BaseEquipmentView_UserEquipmentSlotConfig__remove_SlotClickedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_Component_GetComponent_MonoPointerClickHandler___);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_UserInfo_Control_UserEquipmentViewMediator_EquipmentViewOnSlotClickedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_UserInfo_Control_UserEquipmentViewMediator_HandleExtraSlotsStubClickEvent__
		              );
		    DAT_ram_00a5990a = '\x01';
		  }
		  uVar1 = unnamed_function_1417(System_Action_UserEquipmentSlotConfig__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_UserInfo_Control_UserEquipmentViewMediator_EquipmentViewOnSlotClickedEvent__
		             ,0);
		  Gameplay_UserInfo_View_Equipment_BaseEquipmentView___Il2CppFullySharedGenericType___get_Artifacts
		            (param2,uVar1,
		             Method_Gameplay_UserInfo_View_Equipment_BaseEquipmentView_UserEquipmentSlotConfig__remove_SlotClickedEvent__
		            );
		  uVar1 = func_ii_5677(*(undefined4 *)(*(int *)(param2 + 0x24) + 0x10),
		                       Method_UnityEngine_Component_GetComponent_MonoPointerClickHandler___);
		  param1_00 = unnamed_function_1417(System_Action_PointerEventData__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_UserInfo_Control_UserEquipmentViewMediator_HandleExtraSlotsStubClickEvent__
		             ,0);
		  Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_object___get_Count(uVar1,param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06001881 RID: 6273 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001881")]
		[Address(RVA = "0x6A21", Offset = "0x6A21", VA = "0x6A21", Slot = "23")]
		protected override void ResetView(UserEquipmentView view)
		{
		/* --- GHIDRA: ResetView ---
		void Gameplay_UserInfo_Control_UserEquipmentViewMediator__ResetView
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5990b == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_PointerEventData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_UserEquipmentSlotConfig__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_UserInfo_View_Equipment_BaseEquipmentView_UserEquipmentSlotConfig__add_SlotClickedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_Component_GetComponent_MonoPointerClickHandler___);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_UserInfo_Control_UserEquipmentViewMediator_EquipmentViewOnSlotClickedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_UserInfo_Control_UserEquipmentViewMediator_HandleExtraSlotsStubClickEvent__
		              );
		    DAT_ram_00a5990b = '\x01';
		  }
		  uVar1 = unnamed_function_1417(System_Action_UserEquipmentSlotConfig__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_UserInfo_Control_UserEquipmentViewMediator_EquipmentViewOnSlotClickedEvent__
		             ,0);
		  Gameplay_UserInfo_View_Equipment_BaseEquipmentView_object___SlotOnClickEvent
		            (param2,uVar1,
		             Method_Gameplay_UserInfo_View_Equipment_BaseEquipmentView_UserEquipmentSlotConfig__add_SlotClickedEvent__
		            );
		  uVar1 = func_ii_5677(*(undefined4 *)(*(int *)(param2 + 0x24) + 0x10),
		                       Method_UnityEngine_Component_GetComponent_MonoPointerClickHandler___);
		  param1_00 = unnamed_function_1417(System_Action_PointerEventData__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_UserInfo_Control_UserEquipmentViewMediator_HandleExtraSlotsStubClickEvent__
		             ,0);
		  Gameplay_Chat_View_Smiles_SmileItemView__HandleSmileDicChanged(uVar1,param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06001882 RID: 6274 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001882")]
		[Address(RVA = "0x6A22", Offset = "0x6A22", VA = "0x6A22", Slot = "24")]
		protected override void SetupView(UserEquipmentView view)
		{
		/* --- GHIDRA: SetupView ---
		void Gameplay_UserInfo_Control_UserEquipmentViewMediator__SetupView
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  Gameplay_UserInfo_Control_UserEquipmentViewMediator__HandleInitEvent(param1,param2,param2);
		  return;
		}
		*/

		}

		// Token: 0x06001883 RID: 6275 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001883")]
		[Address(RVA = "0x6A23", Offset = "0x6A23", VA = "0x6A23")]
		private void HandleUserTriggersChangedEvent(UserData user)
		{
		/* --- GHIDRA: HandleUserTriggersChangedEvent ---
		void Gameplay_UserInfo_Control_UserEquipmentViewMediator__HandleUserTriggersChangedEvent
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint uVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int iVar5;
		  uint *puVar6;
		  int iVar7;
		  int *param1_00;
		  int iVar8;
		  int iVar9;
		  int *piVar10;
		  
		  iVar9 = 0;
		  if (DAT_ram_00a5990c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_UserInfoModel__UserInfoEvents__UserInfoController__UserEquipmentView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_UserInfo_View_Equipment_BaseEquipmentSlotConfig_EquipmentSlotIds__get_EquipmentSlotId__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_UserInfo_View_Equipment_BaseEquipmentSlotConfig_EquipmentSlotIds__get_Slot__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_UserInfo_View_Equipment_BaseEquipmentView_UserEquipmentSlotConfig__GetSlots__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5990c = '\x01';
		  }
		  uVar2 = 1;
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar4 = Gameplay_UserInfo_View_Equipment_BaseEquipmentView_object___Awake
		                    (uVar3,
		                     Method_Gameplay_UserInfo_View_Equipment_BaseEquipmentView_UserEquipmentSlotConfig__GetSlots__
		                    );
		  if (0 < *(int *)(iVar4 + 0xc)) {
		    do {
		      iVar7 = *(int *)(iVar4 + iVar9 * 4 + 0x10);
		      UnityEngine_Object__op_Implicit
		                (*(undefined4 *)(iVar7 + 0xc),
		                 (uint)(*(int *)(param1[2] + 8) == *(int *)(*(int *)(param1[2] + 0xc) + 8)),0);
		      iVar5 = Gameplay_Inventory_View_EquipmentSlotView__set_ArtifactViewArgs
		                        (*(undefined4 *)(iVar7 + 0xc),0);
		      param1_00 = *(int **)(param1[2] + 0x28);
		      iVar8 = *param1_00;
		      if (*(ushort *)(iVar8 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          piVar10 = (int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8);
		          if (Core_Gameplay_IGame_TypeInfo == *piVar10) {
		            puVar6 = (uint *)(piVar10[1] * 8 + iVar8 + 0x178);
		            goto code_r0x8108d85a;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		      }
		      puVar6 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x8108d85a:
		      uVar3 = (**(code **)((ulonglong)*puVar6 * 4))(param1_00,puVar6[1]);
		      uVar3 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar3,0);
		      uVar3 = Core_Extensions_Dict_DictExt__GetAccountOptionsDicByOptionId
		                        (uVar3,*(undefined4 *)(iVar7 + 8),0);
		      uVar3 = Core_Extensions_Dict_UserSkillDicExt__GetToolTipFormattedTitleWhitValue(uVar3,0);
		      *(undefined4 *)(iVar5 + 0x28) = uVar3;
		      iVar9 = iVar9 + 1;
		    } while (iVar9 < *(int *)(iVar4 + 0xc));
		  }
		  iVar9 = *(int *)(param1[2] + 8);
		  if (iVar9 != *(int *)(*(int *)(param1[2] + 0xc) + 8)) {
		    uVar2 = Core_Extensions_UriExt___c___QueryStringToDictionary_b__0_1(iVar9,0);
		    uVar2 = uVar2 ^ 1;
		  }
		  iVar9 = *param1;
		  uVar3 = (**(code **)((ulonglong)*(uint *)(iVar9 + 0x158) * 4))
		                    (param1,*(undefined4 *)(iVar9 + 0x15c));
		  uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (uVar3,0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar3,uVar2,0);
		  Gameplay_UserInfo_Control_UserEquipmentViewMediator__HandleInitEvent
		            (param1,*(undefined4 *)(param1[2] + 8),iVar9);
		  return;
		}
		*/

		}

		// Token: 0x06001884 RID: 6276 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001884")]
		[Address(RVA = "0x6A24", Offset = "0x6A24", VA = "0x6A24")]
		private void HandleInitEvent()
		{
		/* --- GHIDRA: HandleInitEvent ---
		void Gameplay_UserInfo_Control_UserEquipmentViewMediator__HandleInitEvent
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  uint *puVar2;
		  undefined4 param2_00;
		  int iVar3;
		  undefined4 uVar4;
		  int *piVar5;
		  int iVar6;
		  int iVar7;
		  int iVar8;
		  int iVar9;
		  int *piVar10;
		  uint uVar11;
		  
		  iVar8 = 0;
		  iVar3 = 0;
		  if (DAT_ram_00a5990d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_UserInfoModel__UserInfoEvents__UserInfoController__UserEquipmentView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5990d = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar1 = *(int *)(*(int *)(iVar1 + 0x24) + 0x18);
		  if (0 < *(int *)(iVar1 + 0xc)) {
		    do {
		      iVar9 = *(int *)(iVar1 + iVar3 * 4 + 0x10);
		      piVar5 = *(int **)(param1[2] + 0x2c);
		      iVar6 = *piVar5;
		      if (*(ushort *)(iVar6 + 0xb6) != 0) {
		        uVar11 = 0;
		        do {
		          piVar10 = (int *)(*(int *)(iVar6 + 0x58) + uVar11 * 8);
		          if (Core_Dict_IDictProvider_TypeInfo == *piVar10) {
		            puVar2 = (uint *)(piVar10[1] * 8 + iVar6 + 0xd0);
		            goto code_r0x8108d539;
		          }
		          uVar11 = uVar11 + 1;
		        } while (*(ushort *)(iVar6 + 0xb6) != uVar11);
		      }
		      puVar2 = (uint *)func_ii_1080(piVar5,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x8108d539:
		      uVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		      param2_00 = Gameplay_Inventory_View_EquipmentSlotView__get_ToolTip(iVar9,0);
		      iVar6 = Core_Extensions_Dict_DictExt__GetAccountOptionsDicByOptionId(uVar4,param2_00,0);
		      piVar5 = *(int **)(param1[2] + 0x28);
		      iVar7 = *piVar5;
		      if (*(ushort *)(iVar7 + 0xb6) != 0) {
		        uVar11 = 0;
		        do {
		          piVar10 = (int *)(*(int *)(iVar7 + 0x58) + uVar11 * 8);
		          if (Core_Gameplay_IGame_TypeInfo == *piVar10) {
		            puVar2 = (uint *)(piVar10[1] * 8 + iVar7 + 0x160);
		            goto code_r0x8108d5cb;
		          }
		          uVar11 = uVar11 + 1;
		        } while (*(ushort *)(iVar7 + 0xb6) != uVar11);
		      }
		      puVar2 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x14);
		code_r0x8108d5cb:
		      uVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		      iVar6 = Core_Gameplay_Managers_Requirements_RequirementsManager__CheckRestriction
		                        (uVar4,*(undefined4 *)(iVar6 + 0x18),param2,0);
		      if (iVar6 == 0) {
		        uVar11 = (uint)(*(int *)(param1[2] + 8) != *(int *)(*(int *)(param1[2] + 0xc) + 8));
		      }
		      else {
		        iVar8 = iVar8 + 1;
		        uVar11 = 1;
		      }
		      iVar6 = 0;
		      iVar7 = *(int *)(iVar9 + 0x1c);
		      if (0 < *(int *)(iVar7 + 0xc)) {
		        do {
		          uVar4 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                            (*(undefined4 *)(iVar7 + iVar6 * 4 + 0x10),0);
		          Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                    (uVar4,uVar11,0);
		          iVar6 = iVar6 + 1;
		        } while (iVar6 < *(int *)(iVar7 + 0xc));
		      }
		      iVar9 = *(int *)(iVar9 + 0x20);
		      if (0 < *(int *)(iVar9 + 0xc)) {
		        iVar6 = 0;
		        do {
		          uVar4 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                            (*(undefined4 *)(iVar9 + iVar6 * 4 + 0x10),0);
		          Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                    (uVar4,uVar11 ^ 1,0);
		          iVar6 = iVar6 + 1;
		        } while (iVar6 < *(int *)(iVar9 + 0xc));
		      }
		      iVar3 = iVar3 + 1;
		    } while (iVar3 < *(int *)(iVar1 + 0xc));
		  }
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar4 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(*(int *)(iVar3 + 0x24) + 0x10),0);
		  if (iVar8 == 0) {
		    uVar11 = (uint)(*(int *)(param1[2] + 8) == *(int *)(*(int *)(param1[2] + 0xc) + 8));
		  }
		  else {
		    uVar11 = 0;
		  }
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar4,uVar11,0);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar1 = *(int *)(param1[2] + 8);
		  iVar9 = *(int *)(*(int *)(param1[2] + 0xc) + 8);
		  uVar4 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(*(int *)(iVar3 + 0x24) + 0x14),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar4,(uint)(iVar9 != iVar1 || 0 < iVar8),0);
		  return;
		}
		*/

		}

		// Token: 0x06001885 RID: 6277 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001885")]
		[Address(RVA = "0x6A25", Offset = "0x6A25", VA = "0x6A25")]
		private void ValidateExtraSlots(UserData user)
		{
		/* --- GHIDRA: ValidateExtraSlots ---
		void Gameplay_UserInfo_Control_UserEquipmentViewMediator__ValidateExtraSlots
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5990e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_UserInfoModel__UserInfoEvents__UserInfoController__UserEquipmentView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_UserInfo_View_Equipment_BaseEquipmentView_UserEquipmentSlotConfig__set_Artifacts__
		              );
		    DAT_ram_00a5990e = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_UserInfo_View_Equipment_BaseEquipmentView_object___remove_SlotClickedEvent
		            (uVar1,0,
		             Method_Gameplay_UserInfo_View_Equipment_BaseEquipmentView_UserEquipmentSlotConfig__set_Artifacts__
		            );
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_UserInfo_View_Equipment_BaseEquipmentView_object___remove_SlotClickedEvent
		            (uVar1,*(undefined4 *)(*(int *)(param1[2] + 0x14) + 0x2c),
		             Method_Gameplay_UserInfo_View_Equipment_BaseEquipmentView_UserEquipmentSlotConfig__set_Artifacts__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06001886 RID: 6278 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001886")]
		[Address(RVA = "0x6A26", Offset = "0x6A26", VA = "0x6A26")]
		private void HandleUserEquipmentChangedEvent()
		{
		/* --- GHIDRA: HandleUserEquipmentChangedEvent ---
		void Gameplay_UserInfo_Control_UserEquipmentViewMediator__HandleUserEquipmentChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint uVar2;
		  int iVar3;
		  uint *puVar4;
		  undefined4 uVar5;
		  undefined4 uVar6;
		  undefined4 param1_00;
		  int *piVar7;
		  int iVar8;
		  int iVar9;
		  
		  if (DAT_ram_00a5990f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_UserInfoModel__UserInfoEvents__UserInfoController__UserEquipmentView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Protocol_Dic_ArtikulMenuActionDic_Types_Actions___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Inventory_View_Chest_InventoryChestWindowOptions_ArtifactFilterDelegate_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_UserInfo_View_Equipment_BaseEquipmentSlotConfig_EquipmentSlotIds__get_EquipmentSlotId__
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Field__PrivateImplementationDetails__CA2BF3224A57AC61B5EFA1C869845F61B3BFA9B6F30DE826A6C157B911EC1A8C
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_UserInfo_Control_UserEquipmentViewMediator___c__DisplayClass11_0__EquipmentViewOnSlotClickedEvent_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_UserInfo_Control_UserEquipmentViewMediator___c__DisplayClass11_0_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_16826);
		    DAT_ram_00a5990f = '\x01';
		  }
		  iVar3 = unnamed_function_1417
		                    (
		                    Gameplay_UserInfo_Control_UserEquipmentViewMediator___c__DisplayClass11_0_TypeInfo
		                    );
		  *(undefined4 *)(iVar3 + 8) = param2;
		  piVar7 = *(int **)(*(int *)(param1 + 8) + 0x2c);
		  iVar8 = *piVar7;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + iVar8 + 0xd0);
		        goto code_r0x8108da6e;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar7,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x8108da6e:
		  uVar1 = 0;
		  uVar5 = (**(code **)((ulonglong)*puVar4 * 4))(piVar7,puVar4[1]);
		  iVar8 = Core_Extensions_Dict_DictExt__GetAccountOptionsDicByOptionId
		                    (uVar5,*(undefined4 *)(*(int *)(iVar3 + 8) + 8),0);
		  piVar7 = *(int **)(*(int *)(param1 + 8) + 0x28);
		  iVar9 = *piVar7;
		  if (*(ushort *)(iVar9 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8 + 4) * 8 + iVar9 + 0x160);
		        goto code_r0x8108db04;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar9 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,0x14);
		code_r0x8108db04:
		  uVar5 = (**(code **)((ulonglong)*puVar4 * 4))(piVar7,puVar4[1]);
		  iVar8 = Core_Gameplay_Managers_Requirements_RequirementsManager__CheckRestriction
		                    (uVar5,*(undefined4 *)(iVar8 + 0x18),*(undefined4 *)(*(int *)(param1 + 8) + 8),0
		                    );
		  piVar7 = *(int **)(*(int *)(param1 + 8) + 0x28);
		  iVar9 = *piVar7;
		  uVar1 = (uint)*(ushort *)(iVar9 + 0xb6);
		  if (iVar8 == 0) {
		    if (uVar1 != 0) {
		      uVar2 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar9 + 0x58) + uVar2 * 8)) {
		          puVar4 = (uint *)(*(int *)(*(int *)(iVar9 + 0x58) + uVar2 * 8 + 4) * 8 + iVar9 + 0xe0);
		          goto code_r0x8108dba8;
		        }
		        uVar2 = uVar2 + 1;
		      } while (uVar1 != uVar2);
		    }
		    puVar4 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x8108dba8:
		    piVar7 = (int *)(**(code **)((ulonglong)*puVar4 * 4))(piVar7,puVar4[1]);
		    uVar1 = 0;
		    iVar3 = *piVar7;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      do {
		        if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		          puVar4 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0xf0);
		          goto code_r0x8108dc26;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		    }
		    puVar4 = (uint *)func_ii_1080(piVar7,Core_Application_IApp_TypeInfo,6);
		code_r0x8108dc26:
		    uVar5 = (**(code **)((ulonglong)*puVar4 * 4))(piVar7,puVar4[1]);
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar6 = func_ii_7508(StringLiteral_16826,1,0,1,0,0,0,0);
		    Core_Application_App__get_ToastController(uVar5,1,uVar6,0);
		    return;
		  }
		  if (uVar1 != 0) {
		    uVar2 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar9 + 0x58) + uVar2 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar9 + 0x58) + uVar2 * 8 + 4) * 8 + iVar9 + 0x120);
		        goto code_r0x8108dccc;
		      }
		      uVar2 = uVar2 + 1;
		    } while (uVar1 != uVar2);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,0xc);
		code_r0x8108dccc:
		  uVar5 = (**(code **)((ulonglong)*puVar4 * 4))(piVar7,puVar4[1]);
		  uVar6 = Mono_Security_ASN1Convert__ToOid
		                    (Protocol_Dic_ArtikulMenuActionDic_Types_Actions___TypeInfo,3);
		  System_Runtime_CompilerServices_RuntimeHelpers__InitializeArray
		            (uVar6,
		             Field__PrivateImplementationDetails__CA2BF3224A57AC61B5EFA1C869845F61B3BFA9B6F30DE826A6C157B911EC1A8C
		             ,0);
		  iVar8 = Mono_Security_ASN1Convert__ToOid
		                    (Protocol_Dic_ArtikulMenuActionDic_Types_Actions___TypeInfo,1);
		  *(undefined4 *)(iVar8 + 0x10) = 6;
		  param1_00 = unnamed_function_1417
		                        (
		                        Gameplay_Inventory_View_Chest_InventoryChestWindowOptions_ArtifactFilterDelegate_TypeInfo
		                        );
		  Gameplay_Inventory_View_Chest_InventoryChestWindowOptions___ctor
		            (param1_00,iVar3,
		             Method_Gameplay_UserInfo_Control_UserEquipmentViewMediator___c__DisplayClass11_0__EquipmentViewOnSlotClickedEvent_b__0__
		             ,0);
		  Core_Gameplay_Managers_Inventory_InventoryManager__DismantleArtifact
		            (uVar5,uVar6,iVar8,param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06001887 RID: 6279 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001887")]
		[Address(RVA = "0x6A27", Offset = "0x6A27", VA = "0x6A27")]
		private void EquipmentViewOnSlotClickedEvent(UserEquipmentSlotConfig slotConfig)
		{
		/* --- GHIDRA: EquipmentViewOnSlotClickedEvent ---
		void Gameplay_UserInfo_Control_UserEquipmentViewMediator__EquipmentViewOnSlotClickedEvent
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  int *param1_00;
		  int iVar5;
		  undefined8 local_38;
		  undefined8 local_30;
		  undefined4 local_28;
		  undefined8 local_24;
		  undefined8 local_1c;
		  int *local_14;
		  undefined4 local_10;
		  undefined8 local_c;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a59910 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_UserInfoModel__UserInfoEvents__UserInfoController__UserEquipmentView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_First_EquipmentExtraSlotView___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_First_RestrictionInfo___);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a59910 = '\x01';
		  }
		  param1_00 = *(int **)(param1[2] + 0x28);
		  iVar5 = *param1_00;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x178);
		        goto code_r0x8108ddf1;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x8108ddf1:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  uVar3 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar3,0);
		  iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar4 = System_Linq_Enumerable__Count_object_
		                    (*(undefined4 *)(*(int *)(iVar5 + 0x24) + 0x18),
		                     Method_System_Linq_Enumerable_First_EquipmentExtraSlotView___);
		  uVar4 = Gameplay_Inventory_View_EquipmentSlotView__get_ToolTip(uVar4,0);
		  iVar5 = Core_Extensions_Dict_DictExt__GetAccountOptionsDicByOptionId(uVar3,uVar4,0);
		  iVar5 = System_Linq_Enumerable__Count_object_
		                    (*(undefined4 *)(iVar5 + 0x18),
		                     Method_System_Linq_Enumerable_First_RestrictionInfo___);
		  uVar3 = *(undefined4 *)(iVar5 + 0xc);
		  if (DAT_ram_00a59911 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_UserEquipmentViewMediator__ShowAntiqGroupReview_d__13___
		              );
		    DAT_ram_00a59911 = '\x01';
		  }
		  local_4 = 0;
		  local_c = 0;
		  System_Linq_Enumerable__ToDictionary_KeyValuePair_object__object___object__object_(&local_38,0);
		  local_1c = local_30;
		  local_28 = 0xffffffff;
		  local_24 = local_38;
		  local_14 = param1;
		  local_10 = uVar3;
		  System_Runtime_CompilerServices_AsyncVoidMethodBuilder__Start_UnityServicesManager__Init_d__8_
		            (&local_24,&local_28,
		             Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_UserEquipmentViewMediator__ShowAntiqGroupReview_d__13___
		            );
		  return;
		}
		*/

		}

		// Token: 0x06001888 RID: 6280 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001888")]
		[Address(RVA = "0x6A28", Offset = "0x6A28", VA = "0x6A28")]
		private void HandleExtraSlotsStubClickEvent(PointerEventData data)
		{
		/* --- GHIDRA: HandleExtraSlotsStubClickEvent ---
		void Gameplay_UserInfo_Control_UserEquipmentViewMediator__HandleExtraSlotsStubClickEvent
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined8 local_38;
		  undefined8 local_30;
		  undefined4 local_28;
		  undefined8 local_24;
		  undefined8 local_1c;
		  undefined4 local_14;
		  undefined4 local_10;
		  undefined8 local_c;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a59911 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_UserEquipmentViewMediator__ShowAntiqGroupReview_d__13___
		              );
		    DAT_ram_00a59911 = '\x01';
		  }
		  local_4 = 0;
		  local_c = 0;
		  System_Linq_Enumerable__ToDictionary_KeyValuePair_object__object___object__object_(&local_38,0);
		  local_1c = local_30;
		  local_28 = 0xffffffff;
		  local_24 = local_38;
		  local_14 = param1;
		  local_10 = param2;
		  System_Runtime_CompilerServices_AsyncVoidMethodBuilder__Start_UnityServicesManager__Init_d__8_
		            (&local_24,&local_28,
		             Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_UserEquipmentViewMediator__ShowAntiqGroupReview_d__13___
		            );
		  return;
		}
		*/

		}

		// Token: 0x06001889 RID: 6281 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001889")]
		[Address(RVA = "0x6A29", Offset = "0x6A29", VA = "0x6A29")]
		private void ShowAntiqGroupReview(int triggerId)
		{
		}

		// Token: 0x04000D1B RID: 3355
		[Token(Token = "0x4000D1B")]
		[FieldOffset(Offset = "0x18")]
		private Launch _antiqLaunch;
	}
}
