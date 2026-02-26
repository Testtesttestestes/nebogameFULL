using System;
using Gameplay.UserInfo.Model;
using Gameplay.UserInfo.View;
using Il2CppDummyDll;
using MVC;
using Protocol.Dic;
using UI;
using UnityEngine.EventSystems;

namespace Gameplay.UserInfo.Control
{
	// Token: 0x0200041D RID: 1053
	[Token(Token = "0x200041D")]
	public class UserInfoViewMediator : AbstractCozyViewMediator<UserInfoModel, UserInfoEvents, UserInfoController, UserInfoView>
	{
		// Token: 0x060018C9 RID: 6345 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018C9")]
		[Address(RVA = "0x6A68", Offset = "0x6A68", VA = "0x6A68")]
		public UserInfoViewMediator(UserInfoView view, UserInfoModel model, UserInfoEvents events, UserInfoController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_UserInfo_Control_UserInfoViewMediator___ctor
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int *piVar3;
		  undefined4 uVar4;
		  
		  if (DAT_ram_00a59938 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_UserInfo_Control_UserInfoViewMediator_HandleInitEvent__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_UserInfo_Control_UserInfoViewMediator_HandleUserCultGenderChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_UserInfo_Control_UserInfoViewMediator_HandleUserNickChangedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_UserInfo_Control_UserInfoViewMediator_HandleUserSkillsChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_UserInfo_Control_UserInfoViewMediator_UserAprChangedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_UserInfo_Control_UserInfoViewMediator_UserBasicRequestedEventHandler__
		              );
		    DAT_ram_00a59938 = '\x01';
		  }
		  uVar4 = *(undefined4 *)(param2 + 8);
		  uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,param1,Method_Gameplay_UserInfo_Control_UserInfoViewMediator_HandleInitEvent__,0)
		  ;
		  piVar3 = (int *)func_ii_7048(uVar4,uVar2,0);
		  iVar1 = System_Action_TypeInfo;
		  if (piVar3 == (int *)0x0) {
		    *(undefined4 *)(param2 + 8) = 0;
		  }
		  else if ((*piVar3 != System_Action_TypeInfo) || (*(int **)(param2 + 8) = piVar3, *piVar3 != iVar1)
		          ) {
		    System_Activator__CreateInstance(piVar3,iVar1);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  uVar4 = *(undefined4 *)(param2 + 0x18);
		  uVar2 = unnamed_function_1417(iVar1);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,param1,
		             Method_Gameplay_UserInfo_Control_UserInfoViewMediator_HandleUserSkillsChangedEvent__,0)
		  ;
		  piVar3 = (int *)func_ii_7048(uVar4,uVar2,0);
		  iVar1 = System_Action_TypeInfo;
		  if (piVar3 == (int *)0x0) {
		    *(undefined4 *)(param2 + 0x18) = 0;
		  }
		  else if ((*piVar3 != System_Action_TypeInfo) ||
		          (*(int **)(param2 + 0x18) = piVar3, *piVar3 != iVar1)) {
		    System_Activator__CreateInstance(piVar3,iVar1);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  uVar4 = *(undefined4 *)(param2 + 0x20);
		  uVar2 = unnamed_function_1417(iVar1);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,param1,
		             Method_Gameplay_UserInfo_Control_UserInfoViewMediator_HandleUserNickChangedEvent__,0);
		  piVar3 = (int *)func_ii_7048(uVar4,uVar2,0);
		  iVar1 = System_Action_TypeInfo;
		  if (piVar3 == (int *)0x0) {
		    *(undefined4 *)(param2 + 0x20) = 0;
		  }
		  else if ((*piVar3 != System_Action_TypeInfo) ||
		          (*(int **)(param2 + 0x20) = piVar3, *piVar3 != iVar1)) {
		    System_Activator__CreateInstance(piVar3,iVar1);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  uVar4 = *(undefined4 *)(param2 + 0x24);
		  uVar2 = unnamed_function_1417(iVar1);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,param1,
		             Method_Gameplay_UserInfo_Control_UserInfoViewMediator_UserAprChangedEvent__,0);
		  piVar3 = (int *)func_ii_7048(uVar4,uVar2,0);
		  iVar1 = System_Action_TypeInfo;
		  if (piVar3 == (int *)0x0) {
		    *(undefined4 *)(param2 + 0x24) = 0;
		  }
		  else if ((*piVar3 != System_Action_TypeInfo) ||
		          (*(int **)(param2 + 0x24) = piVar3, *piVar3 != iVar1)) {
		    System_Activator__CreateInstance(piVar3,iVar1);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  uVar4 = *(undefined4 *)(param2 + 0x28);
		  uVar2 = unnamed_function_1417(iVar1);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,param1,
		             Method_Gameplay_UserInfo_Control_UserInfoViewMediator_HandleUserCultGenderChangedEvent__
		             ,0);
		  piVar3 = (int *)func_ii_7048(uVar4,uVar2,0);
		  iVar1 = System_Action_TypeInfo;
		  if (piVar3 == (int *)0x0) {
		    *(undefined4 *)(param2 + 0x28) = 0;
		  }
		  else if ((*piVar3 != System_Action_TypeInfo) ||
		          (*(int **)(param2 + 0x28) = piVar3, *piVar3 != iVar1)) {
		    System_Activator__CreateInstance(piVar3,iVar1);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  uVar4 = *(undefined4 *)(param2 + 0x14);
		  uVar2 = unnamed_function_1417(iVar1);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,param1,
		             Method_Gameplay_UserInfo_Control_UserInfoViewMediator_UserBasicRequestedEventHandler__,
		             0);
		  piVar3 = (int *)func_ii_7048(uVar4,uVar2,0);
		  iVar1 = System_Action_TypeInfo;
		  if (piVar3 == (int *)0x0) {
		    *(undefined4 *)(param2 + 0x14) = 0;
		    return;
		  }
		  if ((System_Action_TypeInfo == *piVar3) && (*(int **)(param2 + 0x14) = piVar3, *piVar3 == iVar1))
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

		// Token: 0x060018CA RID: 6346 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018CA")]
		[Address(RVA = "0x6A69", Offset = "0x6A69", VA = "0x6A69", Slot = "21")]
		protected override void ResetEvents(UserInfoEvents events)
		{
		/* --- GHIDRA: ResetEvents ---
		void Gameplay_UserInfo_Control_UserInfoViewMediator__ResetEvents
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int *piVar3;
		  undefined4 uVar4;
		  
		  if (DAT_ram_00a59939 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_UserInfo_Control_UserInfoViewMediator_HandleInitEvent__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_UserInfo_Control_UserInfoViewMediator_HandleUserCultGenderChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_UserInfo_Control_UserInfoViewMediator_HandleUserNickChangedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_UserInfo_Control_UserInfoViewMediator_HandleUserSkillsChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_UserInfo_Control_UserInfoViewMediator_UserAprChangedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_UserInfo_Control_UserInfoViewMediator_UserBasicRequestedEventHandler__
		              );
		    DAT_ram_00a59939 = '\x01';
		  }
		  uVar4 = *(undefined4 *)(param2 + 8);
		  uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,param1,Method_Gameplay_UserInfo_Control_UserInfoViewMediator_HandleInitEvent__,0)
		  ;
		  piVar3 = (int *)UnityEngine_UI_Image__set_sprite(uVar4,uVar2,0);
		  iVar1 = System_Action_TypeInfo;
		  if (piVar3 == (int *)0x0) {
		    *(undefined4 *)(param2 + 8) = 0;
		  }
		  else if ((*piVar3 != System_Action_TypeInfo) || (*(int **)(param2 + 8) = piVar3, *piVar3 != iVar1)
		          ) {
		    System_Activator__CreateInstance(piVar3,iVar1);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  uVar4 = *(undefined4 *)(param2 + 0x18);
		  uVar2 = unnamed_function_1417(iVar1);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,param1,
		             Method_Gameplay_UserInfo_Control_UserInfoViewMediator_HandleUserSkillsChangedEvent__,0)
		  ;
		  piVar3 = (int *)UnityEngine_UI_Image__set_sprite(uVar4,uVar2,0);
		  iVar1 = System_Action_TypeInfo;
		  if (piVar3 == (int *)0x0) {
		    *(undefined4 *)(param2 + 0x18) = 0;
		  }
		  else if ((*piVar3 != System_Action_TypeInfo) ||
		          (*(int **)(param2 + 0x18) = piVar3, *piVar3 != iVar1)) {
		    System_Activator__CreateInstance(piVar3,iVar1);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  uVar4 = *(undefined4 *)(param2 + 0x20);
		  uVar2 = unnamed_function_1417(iVar1);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,param1,
		             Method_Gameplay_UserInfo_Control_UserInfoViewMediator_HandleUserNickChangedEvent__,0);
		  piVar3 = (int *)UnityEngine_UI_Image__set_sprite(uVar4,uVar2,0);
		  iVar1 = System_Action_TypeInfo;
		  if (piVar3 == (int *)0x0) {
		    *(undefined4 *)(param2 + 0x20) = 0;
		  }
		  else if ((*piVar3 != System_Action_TypeInfo) ||
		          (*(int **)(param2 + 0x20) = piVar3, *piVar3 != iVar1)) {
		    System_Activator__CreateInstance(piVar3,iVar1);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  uVar4 = *(undefined4 *)(param2 + 0x24);
		  uVar2 = unnamed_function_1417(iVar1);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,param1,
		             Method_Gameplay_UserInfo_Control_UserInfoViewMediator_UserAprChangedEvent__,0);
		  piVar3 = (int *)UnityEngine_UI_Image__set_sprite(uVar4,uVar2,0);
		  iVar1 = System_Action_TypeInfo;
		  if (piVar3 == (int *)0x0) {
		    *(undefined4 *)(param2 + 0x24) = 0;
		  }
		  else if ((*piVar3 != System_Action_TypeInfo) ||
		          (*(int **)(param2 + 0x24) = piVar3, *piVar3 != iVar1)) {
		    System_Activator__CreateInstance(piVar3,iVar1);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  uVar4 = *(undefined4 *)(param2 + 0x28);
		  uVar2 = unnamed_function_1417(iVar1);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,param1,
		             Method_Gameplay_UserInfo_Control_UserInfoViewMediator_HandleUserCultGenderChangedEvent__
		             ,0);
		  piVar3 = (int *)UnityEngine_UI_Image__set_sprite(uVar4,uVar2,0);
		  iVar1 = System_Action_TypeInfo;
		  if (piVar3 == (int *)0x0) {
		    *(undefined4 *)(param2 + 0x28) = 0;
		  }
		  else if ((*piVar3 != System_Action_TypeInfo) ||
		          (*(int **)(param2 + 0x28) = piVar3, *piVar3 != iVar1)) {
		    System_Activator__CreateInstance(piVar3,iVar1);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  uVar4 = *(undefined4 *)(param2 + 0x14);
		  uVar2 = unnamed_function_1417(iVar1);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,param1,
		             Method_Gameplay_UserInfo_Control_UserInfoViewMediator_UserBasicRequestedEventHandler__,
		             0);
		  piVar3 = (int *)UnityEngine_UI_Image__set_sprite(uVar4,uVar2,0);
		  iVar1 = System_Action_TypeInfo;
		  if (piVar3 == (int *)0x0) {
		    *(undefined4 *)(param2 + 0x14) = 0;
		    return;
		  }
		  if ((System_Action_TypeInfo == *piVar3) && (*(int **)(param2 + 0x14) = piVar3, *piVar3 == iVar1))
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

		// Token: 0x060018CB RID: 6347 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018CB")]
		[Address(RVA = "0x6A6A", Offset = "0x6A6A", VA = "0x6A6A", Slot = "22")]
		protected override void SetupEvents(UserInfoEvents events)
		{
		/* --- GHIDRA: SetupEvents ---
		void Gameplay_UserInfo_Control_UserInfoViewMediator__SetupEvents
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a5993a == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IndexButtonBasic__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_EventHandler_PointerEventData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_UserInfo_Control_UserInfoViewMediator_HandleAddToFriendsButtonClickEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_UserInfo_Control_UserInfoViewMediator_HandleAntiqClickEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_UserInfo_Control_UserInfoViewMediator_HandleAprsButtonClickEvent__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_UserInfo_Control_UserInfoViewMediator_HandleChatBanButtonClickEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_UserInfo_Control_UserInfoViewMediator_HandleCollectionsButtonClickEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_UserInfo_Control_UserInfoViewMediator_HandleDuelButtonClickEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_UserInfo_Control_UserInfoViewMediator_HandleEditeButtonClickEvent__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_UserInfo_Control_UserInfoViewMediator_HandleInfoButtonClickEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_UserInfo_Control_UserInfoViewMediator_HandleMedalButtonClickEvent__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_UserInfo_Control_UserInfoViewMediator_HandleRatingButtonClickEvent__
		              );
		    DAT_ram_00a5993a = '\x01';
		  }
		  uVar2 = *(undefined4 *)(param2 + 0x28);
		  uVar1 = unnamed_function_1417(System_Action_IndexButtonBasic__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_UserInfo_Control_UserInfoViewMediator_HandleMedalButtonClickEvent__,0);
		  UI_IndexButtonBasic__add_ClickEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param2 + 0x24);
		  uVar1 = unnamed_function_1417(System_Action_IndexButtonBasic__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_UserInfo_Control_UserInfoViewMediator_HandleAprsButtonClickEvent__,0);
		  UI_IndexButtonBasic__add_ClickEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param2 + 0x2c);
		  uVar1 = unnamed_function_1417(System_Action_IndexButtonBasic__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_UserInfo_Control_UserInfoViewMediator_HandleCollectionsButtonClickEvent__
		             ,0);
		  UI_IndexButtonBasic__add_ClickEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(*(int *)(param2 + 0x34) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,
		             Method_Gameplay_UserInfo_Control_UserInfoViewMediator_HandleInfoButtonClickEvent__,0);
		  UnityEngine_Events_UnityAction___ctor(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(*(int *)(param2 + 0x3c) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,
		             Method_Gameplay_UserInfo_Control_UserInfoViewMediator_HandleRatingButtonClickEvent__,0)
		  ;
		  UnityEngine_Events_UnityAction___ctor(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(*(int *)(param2 + 0x38) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,
		             Method_Gameplay_UserInfo_Control_UserInfoViewMediator_HandleEditeButtonClickEvent__,0);
		  UnityEngine_Events_UnityAction___ctor(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param2 + 0x44);
		  uVar1 = unnamed_function_1417(System_EventHandler_PointerEventData__TypeInfo);
		  UnityEngine_Object__Instantiate_object_
		            (uVar1,param1,
		             Method_Gameplay_UserInfo_Control_UserInfoViewMediator_HandleAddToFriendsButtonClickEvent__
		             ,0);
		  UI_SelectedButton__add_ClickEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(*(int *)(param2 + 0x60) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,
		             Method_Gameplay_UserInfo_Control_UserInfoViewMediator_HandleChatBanButtonClickEvent__,0
		            );
		  UnityEngine_Events_UnityAction___ctor(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(*(int *)(param2 + 0x40) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,
		             Method_Gameplay_UserInfo_Control_UserInfoViewMediator_HandleDuelButtonClickEvent__,0);
		  UnityEngine_Events_UnityAction___ctor(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param2 + 0x30);
		  uVar1 = unnamed_function_1417(System_Action_IndexButtonBasic__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_UserInfo_Control_UserInfoViewMediator_HandleAntiqClickEvent__,0);
		  UI_IndexButtonBasic__add_ClickEvent(uVar2,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x060018CC RID: 6348 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018CC")]
		[Address(RVA = "0x6A6B", Offset = "0x6A6B", VA = "0x6A6B", Slot = "23")]
		protected override void ResetView(UserInfoView view)
		{
		/* --- GHIDRA: ResetView ---
		void Gameplay_UserInfo_Control_UserInfoViewMediator__ResetView
		               (int param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 in_register_20000014;
		  undefined4 uVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  undefined8 uVar5;
		  undefined4 uVar6;
		  int *piVar7;
		  int iVar8;
		  int iVar9;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5993b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_UserInfoModel__UserInfoEvents__UserInfoController__UserInfoView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_IndexButtonBasic__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_EventHandler_PointerEventData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Discounts_Model_IDiscountHandler_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_UserInfoView_State__set_CurrentState__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_UserInfo_Control_UserInfoViewMediator_HandleAddToFriendsButtonClickEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_UserInfo_Control_UserInfoViewMediator_HandleAntiqClickEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_UserInfo_Control_UserInfoViewMediator_HandleAprsButtonClickEvent__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_UserInfo_Control_UserInfoViewMediator_HandleChatBanButtonClickEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_UserInfo_Control_UserInfoViewMediator_HandleCollectionsButtonClickEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_UserInfo_Control_UserInfoViewMediator_HandleDuelButtonClickEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_UserInfo_Control_UserInfoViewMediator_HandleEditeButtonClickEvent__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_UserInfo_Control_UserInfoViewMediator_HandleInfoButtonClickEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_UserInfo_Control_UserInfoViewMediator_HandleMedalButtonClickEvent__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_UserInfo_Control_UserInfoViewMediator_HandleRatingButtonClickEvent__
		              );
		    DAT_ram_00a5993b = '\x01';
		  }
		  local_4 = 0;
		  uVar6 = *(undefined4 *)(param2 + 0x28);
		  uVar2 = unnamed_function_1417(System_Action_IndexButtonBasic__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_UserInfo_Control_UserInfoViewMediator_HandleMedalButtonClickEvent__,0);
		  UI_IndexButtonBasic__get_CanvasGroup(uVar6,uVar2,0);
		  uVar6 = *(undefined4 *)(param2 + 0x24);
		  uVar2 = unnamed_function_1417(System_Action_IndexButtonBasic__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_UserInfo_Control_UserInfoViewMediator_HandleAprsButtonClickEvent__,0);
		  UI_IndexButtonBasic__get_CanvasGroup(uVar6,uVar2,0);
		  uVar6 = *(undefined4 *)(param2 + 0x2c);
		  uVar2 = unnamed_function_1417(System_Action_IndexButtonBasic__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_UserInfo_Control_UserInfoViewMediator_HandleCollectionsButtonClickEvent__
		             ,0);
		  UI_IndexButtonBasic__get_CanvasGroup(uVar6,uVar2,0);
		  uVar6 = *(undefined4 *)(*(int *)(param2 + 0x34) + 0xb4);
		  uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar2,param1,
		             Method_Gameplay_UserInfo_Control_UserInfoViewMediator_HandleInfoButtonClickEvent__,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar6,uVar2,0);
		  uVar6 = *(undefined4 *)(*(int *)(param2 + 0x3c) + 0xb4);
		  uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar2,param1,
		             Method_Gameplay_UserInfo_Control_UserInfoViewMediator_HandleRatingButtonClickEvent__,0)
		  ;
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar6,uVar2,0);
		  uVar6 = *(undefined4 *)(*(int *)(param2 + 0x38) + 0xb4);
		  uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar2,param1,
		             Method_Gameplay_UserInfo_Control_UserInfoViewMediator_HandleEditeButtonClickEvent__,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar6,uVar2,0);
		  uVar6 = *(undefined4 *)(param2 + 0x44);
		  uVar2 = unnamed_function_1417(System_EventHandler_PointerEventData__TypeInfo);
		  UnityEngine_Object__Instantiate_object_
		            (uVar2,param1,
		             Method_Gameplay_UserInfo_Control_UserInfoViewMediator_HandleAddToFriendsButtonClickEvent__
		             ,0);
		  UI_RawImageWithGrayscale___ctor(uVar6,uVar2,0);
		  uVar6 = *(undefined4 *)(*(int *)(param2 + 0x60) + 0xb4);
		  uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar2,param1,
		             Method_Gameplay_UserInfo_Control_UserInfoViewMediator_HandleChatBanButtonClickEvent__,0
		            );
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar6,uVar2,0);
		  uVar6 = *(undefined4 *)(*(int *)(param2 + 0x40) + 0xb4);
		  uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar2,param1,
		             Method_Gameplay_UserInfo_Control_UserInfoViewMediator_HandleDuelButtonClickEvent__,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar6,uVar2,0);
		  uVar6 = *(undefined4 *)(param2 + 0x30);
		  uVar2 = unnamed_function_1417(System_Action_IndexButtonBasic__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_UserInfo_Control_UserInfoViewMediator_HandleAntiqClickEvent__,0);
		  UI_IndexButtonBasic__get_CanvasGroup(uVar6,uVar2,0);
		  uVar2 = 1;
		  if (*(int *)(*(int *)(param1 + 8) + 8) != *(int *)(*(int *)(*(int *)(param1 + 8) + 0xc) + 8)) {
		    uVar2 = 2;
		  }
		  Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		            (param2,uVar2,Method_UI_MonoBehaviourWithStates_UserInfoView_State__set_CurrentState__);
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param2 + 0x60),0);
		  piVar7 = *(int **)(*(int *)(param1 + 8) + 0x28);
		  iVar8 = *piVar7;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + iVar8 + 0x1d8);
		        goto code_r0x81093adc;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,0x23);
		code_r0x81093adc:
		  uVar5 = CONCAT44(in_register_20000014,puVar3[1]);
		  iVar8 = (**(code **)((ulonglong)*puVar3 * 4))(piVar7,uVar5);
		  iVar9 = **(int **)(iVar8 + 0x10);
		  uVar5 = CONCAT44((int)((ulonglong)uVar5 >> 0x20),*(undefined4 *)(iVar9 + 0x104));
		  iVar8 = (**(code **)((ulonglong)*(uint *)(iVar9 + 0x100) * 4))(*(int **)(iVar8 + 0x10),uVar5);
		  uVar6 = (undefined4)((ulonglong)uVar5 >> 0x20);
		  iVar8 = *(int *)(iVar8 + 0x2c);
		  if (iVar8 == 0) {
		    uVar4 = 0;
		  }
		  else {
		    uVar1 = 0;
		    piVar7 = *(int **)(*(int *)(param1 + 8) + 0x28);
		    iVar9 = *piVar7;
		    if (*(ushort *)(iVar9 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8 + 4) * 8 + iVar9 + 0x1d8);
		          goto code_r0x81093b88;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar9 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,0x23);
		code_r0x81093b88:
		    if (iVar8 == 0) {
		      uVar2 = 0;
		    }
		    uVar5 = CONCAT44(uVar6,puVar3[1]);
		    iVar8 = (**(code **)((ulonglong)*puVar3 * 4))(piVar7,uVar5);
		    iVar9 = **(int **)(iVar8 + 0x10);
		    uVar5 = CONCAT44((int)((ulonglong)uVar5 >> 0x20),*(undefined4 *)(iVar9 + 0x104));
		    iVar8 = (**(code **)((ulonglong)*(uint *)(iVar9 + 0x100) * 4))(*(int **)(iVar8 + 0x10),uVar5);
		    uVar6 = (undefined4)((ulonglong)uVar5 >> 0x20);
		    if (*(int *)(iVar8 + 8) == *(int *)(*(int *)(param1 + 8) + 8)) {
		      uVar4 = 0;
		    }
		    else {
		      uVar1 = 0;
		      piVar7 = *(int **)(*(int *)(param1 + 8) + 0x28);
		      iVar8 = *piVar7;
		      if (*(ushort *)(iVar8 + 0xb6) != 0) {
		        do {
		          if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		            puVar3 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + iVar8 + 0x1d8);
		            goto code_r0x81093c42;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		      }
		      puVar3 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,0x23);
		code_r0x81093c42:
		      uVar5 = CONCAT44(uVar6,puVar3[1]);
		      iVar8 = (**(code **)((ulonglong)*puVar3 * 4))(piVar7,uVar5);
		      iVar9 = **(int **)(iVar8 + 0x10);
		      uVar5 = CONCAT44((int)((ulonglong)uVar5 >> 0x20),*(undefined4 *)(iVar9 + 0x104));
		      iVar8 = (**(code **)((ulonglong)*(uint *)(iVar9 + 0x100) * 4))(*(int **)(iVar8 + 0x10),uVar5);
		      uVar6 = (undefined4)((ulonglong)uVar5 >> 0x20);
		      uVar4 = Gameplay_Chat_Model_Data_ChatVisitorData__set_BanData(*(undefined4 *)(iVar8 + 0x2c),0)
		      ;
		    }
		  }
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar2,uVar4,0);
		  uVar2 = *(undefined4 *)(param2 + 0x44);
		  piVar7 = *(int **)(*(int *)(param1 + 8) + 0x28);
		  iVar8 = *piVar7;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + iVar8 + 0x1d8);
		        goto code_r0x81093d07;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,0x23);
		code_r0x81093d07:
		  iVar8 = (**(code **)((ulonglong)*puVar3 * 4))(piVar7,CONCAT44(uVar6,puVar3[1]));
		  iVar9 = **(int **)(iVar8 + 0x10);
		  uVar6 = (**(code **)((ulonglong)*(uint *)(iVar9 + 0x100) * 4))
		                    (*(int **)(iVar8 + 0x10),*(undefined4 *)(iVar9 + 0x104));
		  uVar5 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                    (*(undefined4 *)(*(int *)(param1 + 8) + 8),0);
		  uVar4 = Gameplay_Chat_Model_ChatModel__RemoveFavorite(uVar6,uVar5,&local_4,0);
		  uVar6 = (undefined4)((ulonglong)uVar5 >> 0x20);
		  UI_SelectedButton__get_Selected(uVar2,uVar4,0);
		  iVar8 = *(int *)(param1 + 8);
		  if (*(int *)(iVar8 + 8) == *(int *)(*(int *)(iVar8 + 0xc) + 8)) {
		    piVar7 = *(int **)(iVar8 + 0x28);
		    iVar8 = *piVar7;
		    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + iVar8 + 0x138);
		          goto code_r0x81093dd9;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,0xf);
		code_r0x81093dd9:
		    uVar5 = CONCAT44(uVar6,puVar3[1]);
		    iVar8 = (**(code **)((ulonglong)*puVar3 * 4))(piVar7,uVar5);
		    uVar2 = (undefined4)((ulonglong)uVar5 >> 0x20);
		    piVar7 = *(int **)(*(int *)(iVar8 + 0x14) + 0x2c);
		    if (piVar7 != (int *)0x0) {
		      uVar1 = 0;
		      uVar6 = *(undefined4 *)(param2 + 0x24);
		      iVar8 = *piVar7;
		      if (*(ushort *)(iVar8 + 0xb6) != 0) {
		        do {
		          if (Gameplay_Discounts_Model_IDiscountHandler_TypeInfo ==
		              *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		            puVar3 = (uint *)(iVar8 + *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		            goto code_r0x81093e68;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		      }
		      puVar3 = (uint *)func_ii_1080(piVar7,Gameplay_Discounts_Model_IDiscountHandler_TypeInfo,0);
		code_r0x81093e68:
		      uVar5 = CONCAT44(uVar2,uVar6);
		      (**(code **)((ulonglong)*puVar3 * 4))(piVar7,uVar5,puVar3[1]);
		      uVar2 = (undefined4)((ulonglong)uVar5 >> 0x20);
		    }
		    uVar1 = 0;
		    piVar7 = *(int **)(*(int *)(param1 + 8) + 0x28);
		    iVar8 = *piVar7;
		    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + iVar8 + 0x248);
		          goto code_r0x81093eeb;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,0x31);
		code_r0x81093eeb:
		    uVar2 = (**(code **)((ulonglong)*puVar3 * 4))(piVar7,CONCAT44(uVar2,puVar3[1]));
		    Core_Gameplay_Managers_DiscountsManager__Deinit(uVar2,*(undefined4 *)(param2 + 0x28),0);
		  }
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (param2,0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar2,0,0);
		  return;
		}
		*/

		}

		// Token: 0x060018CD RID: 6349 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018CD")]
		[Address(RVA = "0x6A6C", Offset = "0x6A6C", VA = "0x6A6C", Slot = "24")]
		protected override void SetupView(UserInfoView view)
		{
		/* --- GHIDRA: SetupView ---
		void Gameplay_UserInfo_Control_UserInfoViewMediator__SetupView(int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *param4;
		  undefined4 uVar3;
		  undefined4 param1_00;
		  undefined4 param2_00;
		  int *param1_01;
		  
		  if (DAT_ram_00a5993c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_UserInfoModel__UserInfoEvents__UserInfoController__UserInfoView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5993c = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_00 = *(undefined4 *)(iVar2 + 0x58);
		  param2_00 = *(undefined4 *)(*(int *)(*(int *)(param1[2] + 8) + 0x34) + 0x38);
		  param1_01 = *(int **)(param1[2] + 0x28);
		  iVar2 = *param1_01;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        param4 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x178);
		        goto code_r0x81093fea;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  param4 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x81093fea:
		  uVar3 = (**(code **)((ulonglong)*param4 * 4))(param1_01,param4[1]);
		  uVar3 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar3,0);
		  Gameplay_UserInfo_View_MarkerListElement___ctor(param1_00,param2_00,uVar3,param4);
		  return;
		}
		*/

		}

		// Token: 0x060018CE RID: 6350 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018CE")]
		[Address(RVA = "0x6A6D", Offset = "0x6A6D", VA = "0x6A6D")]
		private void UserBasicRequestedEventHandler()
		{
		/* --- GHIDRA: UserBasicRequestedEventHandler ---
		void Gameplay_UserInfo_Control_UserInfoViewMediator__UserBasicRequestedEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 param2_00;
		  int iVar1;
		  
		  if (DAT_ram_00a5993d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_AprDic__uint__get_Data__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_UserInfoModel__UserInfoEvents__UserInfoController__UserInfoView__get_Model__
		              );
		    DAT_ram_00a5993d = '\x01';
		  }
		  param2_00 = UI_Wiki_WikiUriRouter__SetData
		                        (*(undefined4 *)(*(int *)(*(int *)(param1[2] + 8) + 0x38) + 0x10),0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Core_Extensions_Dict_AprDicExt__Get1024AssetId(*(undefined4 *)(iVar1 + 0x1c),param2_00,0);
		  return;
		}
		*/

		}

		// Token: 0x060018CF RID: 6351 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018CF")]
		[Address(RVA = "0x6A6E", Offset = "0x6A6E", VA = "0x6A6E")]
		private void UserAprChangedEvent()
		{
		/* --- GHIDRA: UserAprChangedEvent ---
		void Gameplay_UserInfo_Control_UserInfoViewMediator__UserAprChangedEvent
		               (undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_UserInfo_Control_UserInfoViewMediator__HandleHideElements(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x060018D0 RID: 6352 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018D0")]
		[Address(RVA = "0x6A6F", Offset = "0x6A6F", VA = "0x6A6F")]
		private void HandleEditeButtonClickEvent()
		{
		/* --- GHIDRA: HandleEditeButtonClickEvent ---
		void Gameplay_UserInfo_Control_UserInfoViewMediator__HandleEditeButtonClickEvent
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_UserInfo_Control_UserInfoViewMediator__HandleInfoButtonClickEvent
		            (param1,*(undefined4 *)(iVar1 + 0x54),param1);
		  return;
		}
		*/

		}

		// Token: 0x060018D1 RID: 6353 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018D1")]
		[Address(RVA = "0x6A70", Offset = "0x6A70", VA = "0x6A70")]
		private void HandleRatingButtonClickEvent()
		{
		/* --- GHIDRA: HandleRatingButtonClickEvent ---
		void Gameplay_UserInfo_Control_UserInfoViewMediator__HandleRatingButtonClickEvent
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 in_register_20000004;
		  undefined8 uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  int iVar5;
		  int *piVar6;
		  ulonglong uVar7;
		  double dVar8;
		  
		  dVar8 = 0.0;
		  if (DAT_ram_00a5993e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_UserInfoModel__UserInfoEvents__UserInfoController__UserInfoView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_StringUtils_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_16825);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28780);
		    Mono_Security_ASN1__get_Item(&StringLiteral_16824);
		    DAT_ram_00a5993e = '\x01';
		  }
		  iVar5 = param1[2];
		  if (*(int *)(iVar5 + 8) == *(int *)(*(int *)(iVar5 + 0xc) + 8)) {
		    iVar2 = Gameplay_User_Model_UserModel__get_ExperienceProgress(*(int *)(iVar5 + 0xc),param1);
		    if (iVar2 == 0) {
		      uVar1 = CONCAT44(in_register_20000004,param1);
		      iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (uVar1,*(undefined4 *)(*param1 + 0x15c));
		      uVar4 = (undefined4)((ulonglong)uVar1 >> 0x20);
		      piVar6 = *(int **)(*(int *)(iVar5 + 0x50) + 0x1c);
		      if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_GameLocalization_TypeInfo);
		      }
		      uVar3 = func_ii_7508(StringLiteral_16824,1,0,1,0,0,0,0);
		      iVar5 = *piVar6;
		      (**(code **)((ulonglong)*(uint *)(iVar5 + 0x2d0) * 4))
		                (CONCAT44(uVar4,piVar6),uVar3,*(undefined4 *)(iVar5 + 0x2d4));
		      iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      piVar6 = *(int **)(*(int *)(iVar5 + 0x50) + 0x20);
		      uVar7 = *(ulonglong *)(*(int *)(param1[2] + 8) + 0x58);
		      if (*(int *)(Utils_StringUtils_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Utils_StringUtils_TypeInfo);
		      }
		      dVar8 = (double)uVar7;
		      uVar4 = UI_SimpleIconValue__set_IconAssetId(dVar8,StringLiteral_28780,0);
		      iVar5 = *piVar6;
		      uVar1 = CONCAT44((int)((ulonglong)dVar8 >> 0x20),piVar6);
		      (**(code **)((ulonglong)*(uint *)(iVar5 + 0x2d0) * 4))
		                (uVar1,uVar4,*(undefined4 *)(iVar5 + 0x2d4));
		      uVar4 = (undefined4)((ulonglong)uVar1 >> 0x20);
		      goto code_r0x81094546;
		    }
		    iVar2 = Gameplay_User_Model_UserModel__get_ExperienceProgress
		                      (*(undefined4 *)(iVar5 + 0xc),param1);
		    dVar8 = (double)(ulonglong)
		                    (*(longlong *)(iVar2 + 0x10) - *(longlong *)(*(int *)(iVar5 + 8) + 0x58));
		  }
		  uVar1 = CONCAT44(in_register_20000004,param1);
		  iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (uVar1,*(undefined4 *)(*param1 + 0x15c));
		  uVar4 = (undefined4)((ulonglong)uVar1 >> 0x20);
		  piVar6 = *(int **)(*(int *)(iVar5 + 0x50) + 0x1c);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar3 = func_ii_7508(StringLiteral_16825,1,0,1,0,0,0,0);
		  iVar5 = *piVar6;
		  (**(code **)((ulonglong)*(uint *)(iVar5 + 0x2d0) * 4))
		            (CONCAT44(uVar4,piVar6),uVar3,*(undefined4 *)(iVar5 + 0x2d4));
		  iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  piVar6 = *(int **)(*(int *)(iVar5 + 0x50) + 0x20);
		  if (*(int *)(Utils_StringUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Utils_StringUtils_TypeInfo);
		  }
		  uVar4 = UI_SimpleIconValue__set_IconAssetId(dVar8,StringLiteral_28780,0);
		  iVar5 = *piVar6;
		  uVar1 = CONCAT44((int)((ulonglong)dVar8 >> 0x20),piVar6);
		  (**(code **)((ulonglong)*(uint *)(iVar5 + 0x2d0) * 4))(uVar1,uVar4,*(undefined4 *)(iVar5 + 0x2d4))
		  ;
		  uVar4 = (undefined4)((ulonglong)uVar1 >> 0x20);
		code_r0x81094546:
		  iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (CONCAT44(uVar4,param1),*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_UserInfo_Control_UserInfoViewMediator__HandleInfoButtonClickEvent
		            (param1,*(undefined4 *)(iVar5 + 0x50),param1);
		  return;
		}
		*/

		}

		// Token: 0x060018D2 RID: 6354 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018D2")]
		[Address(RVA = "0x6A71", Offset = "0x6A71", VA = "0x6A71")]
		private void HandleInfoButtonClickEvent()
		{
		/* --- GHIDRA: HandleInfoButtonClickEvent ---
		void Gameplay_UserInfo_Control_UserInfoViewMediator__HandleInfoButtonClickEvent
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  uint uVar2;
		  int *param1_00;
		  int iVar3;
		  
		  iVar3 = 0;
		  if (DAT_ram_00a5993f == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a5993f = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar1 = *(int *)(iVar1 + 0x5c);
		  if (0 < *(int *)(iVar1 + 0xc)) {
		    do {
		      param1_00 = *(int **)(iVar1 + iVar3 * 4 + 0x10);
		      if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		        func_ii_306000(UnityEngine_Object_TypeInfo);
		      }
		      uVar2 = func_ii_3812(param1_00,param2,0);
		      uVar2 = uVar2 & *(byte *)(param1_00 + 5) == 0;
		      if (*(byte *)(param1_00 + 5) != uVar2) {
		        *(char *)(param1_00 + 5) = (char)uVar2;
		        (**(code **)((ulonglong)*(uint *)(*param1_00 + 0xe0) * 4))
		                  (param1_00,*(undefined4 *)(*param1_00 + 0xe4));
		      }
		      iVar3 = iVar3 + 1;
		    } while (iVar3 < *(int *)(iVar1 + 0xc));
		  }
		  return;
		}
		*/

		}

		// Token: 0x060018D3 RID: 6355 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018D3")]
		[Address(RVA = "0x6A72", Offset = "0x6A72", VA = "0x6A72")]
		private void ShowInfoBox(BaseInfoBox box)
		{
		/* --- GHIDRA: ShowInfoBox ---
		void Gameplay_UserInfo_Control_UserInfoViewMediator__ShowInfoBox
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 param3_00;
		  uint *puVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int *piVar5;
		  int iVar6;
		  
		  if (DAT_ram_00a59940 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_UserInfoModel__UserInfoEvents__UserInfoController__UserInfoView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Medals_View_MedalsWindowArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_PopupController_Show_MedalsWindow___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_10731);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12652);
		    DAT_ram_00a59940 = '\x01';
		  }
		  iVar4 = *(int *)(param1 + 8);
		  if ((*(int *)(iVar4 + 8) != *(int *)(*(int *)(iVar4 + 0xc) + 8)) &&
		     (*(char *)(*(int *)(iVar4 + 8) + 0x48) != '\0')) {
		    uVar1 = 0;
		    piVar5 = *(int **)(iVar4 + 0x28);
		    iVar4 = *piVar5;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xe0);
		          goto code_r0x81094656;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x81094656:
		    piVar5 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		    uVar1 = 0;
		    iVar4 = *piVar5;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      do {
		        if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xf0);
		          goto code_r0x810946d8;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar5,Core_Application_IApp_TypeInfo,6);
		code_r0x810946d8:
		    uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    param3_00 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_10731,1,0,1,0,0,0,0);
		    Core_Application_App__get_ToastController(uVar3,1,param3_00,0);
		    return;
		  }
		  uVar1 = 0;
		  piVar5 = *(int **)(iVar4 + 0x28);
		  iVar4 = *piVar5;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xe0);
		        goto code_r0x81094796;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x81094796:
		  piVar5 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		  uVar1 = 0;
		  iVar4 = *piVar5;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xe8);
		        goto code_r0x81094818;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,Core_Application_IApp_TypeInfo,5);
		code_r0x81094818:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		  iVar4 = unnamed_function_1417(Gameplay_Medals_View_MedalsWindowArgs_TypeInfo);
		  Gameplay_AccountLinker_View_SelectUserWindow___ctor(iVar4,0);
		  iVar6 = *(int *)(param1 + 8);
		  *(undefined4 *)(iVar4 + 0x18) = *(undefined4 *)(iVar6 + 8);
		  *(undefined4 *)(iVar4 + 0x1c) = *(undefined4 *)(*(int *)(iVar6 + 0xc) + 8);
		  Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		            (uVar3,StringLiteral_12652,iVar4,Method_UI_Windows_PopupController_Show_MedalsWindow___)
		  ;
		  return;
		}
		*/

		}

		// Token: 0x060018D4 RID: 6356 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018D4")]
		[Address(RVA = "0x6A73", Offset = "0x6A73", VA = "0x6A73")]
		private void HandleMedalButtonClickEvent(IndexButtonBasic button)
		{
		/* --- GHIDRA: HandleMedalButtonClickEvent ---
		void Gameplay_UserInfo_Control_UserInfoViewMediator__HandleMedalButtonClickEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar3;
		  
		  if (DAT_ram_00a59941 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_UserInfoModel__UserInfoEvents__UserInfoController__UserInfoView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a59941 = '\x01';
		  }
		  param1_01 = *(int **)(*(int *)(param1 + 8) + 0x28);
		  iVar3 = *param1_01;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x280);
		        goto code_r0x81094910;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0x38);
		code_r0x81094910:
		  param1_00 = (**(code **)((ulonglong)*puVar2 * 4))(param1_01,puVar2[1]);
		  Core_Gameplay_Managers_CollectionsManager__ShowOwnCollectionsWindow
		            (param1_00,*(undefined4 *)(*(int *)(param1 + 8) + 8),0);
		  return;
		}
		*/

		}

		// Token: 0x060018D5 RID: 6357 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018D5")]
		[Address(RVA = "0x6A74", Offset = "0x6A74", VA = "0x6A74")]
		private void HandleCollectionsButtonClickEvent(IndexButtonBasic button)
		{
		/* --- GHIDRA: HandleCollectionsButtonClickEvent ---
		void Gameplay_UserInfo_Control_UserInfoViewMediator__HandleCollectionsButtonClickEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  undefined4 param3_00;
		  undefined4 param4;
		  undefined4 param1_01;
		  int *piVar3;
		  int iVar4;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a59942 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_UserInfoModel__UserInfoEvents__UserInfoController__UserInfoView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_PopupController_Show_GroupListWindow___);
		    Mono_Security_ASN1__get_Item(&Gameplay_Antiq_View_GroupListWindow_WindowArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12559);
		    DAT_ram_00a59942 = '\x01';
		  }
		  piVar3 = *(int **)(*(int *)(param1 + 8) + 0x28);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xe0);
		        goto code_r0x810949f0;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x810949f0:
		  piVar3 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  uVar1 = 0;
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xe8);
		        goto code_r0x81094a70;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Application_IApp_TypeInfo,5);
		code_r0x81094a70:
		  uVar1 = 0;
		  param1_00 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  param2_00 = *(undefined4 *)(*(int *)(param1 + 8) + 8);
		  piVar3 = *(int **)(*(int *)(param1 + 8) + 0x28);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x178);
		        goto code_r0x81094b01;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x81094b01:
		  uVar1 = 0;
		  param3_00 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  piVar3 = *(int **)(*(int *)(param1 + 8) + 0x28);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xe0);
		        goto code_r0x81094b89;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x81094b89:
		  piVar3 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  uVar1 = 0;
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xe8);
		        goto code_r0x81094c0b;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Application_IApp_TypeInfo,5);
		code_r0x81094c0b:
		  param4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  param1_01 = unnamed_function_1417(Gameplay_Antiq_View_GroupListWindow_WindowArgs_TypeInfo);
		  Gameplay_Antiq_View_GroupListWindow____n__0(param1_01,param2_00,param3_00,param4,0);
		  Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		            (param1_00,StringLiteral_12559,param1_01,
		             Method_UI_Windows_PopupController_Show_GroupListWindow___);
		  return;
		}
		*/

		}

		// Token: 0x060018D6 RID: 6358 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018D6")]
		[Address(RVA = "0x6A75", Offset = "0x6A75", VA = "0x6A75")]
		private void HandleAntiqClickEvent(IndexButtonBasic obj)
		{
		/* --- GHIDRA: HandleAntiqClickEvent ---
		void Gameplay_UserInfo_Control_UserInfoViewMediator__HandleAntiqClickEvent
		               (int *param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 in_register_20000014;
		  uint *puVar1;
		  undefined4 uVar2;
		  uint uVar3;
		  undefined8 uVar4;
		  int *piVar5;
		  int iVar6;
		  uint uVar7;
		  int iVar8;
		  uint uVar9;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a59943 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_UserInfoModel__UserInfoEvents__UserInfoController__UserInfoView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a59943 = '\x01';
		  }
		  local_4 = 0;
		  piVar5 = *(int **)(param1[2] + 0x28);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar3 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar3 * 8)) {
		        puVar1 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar3 * 8 + 4) * 8 + iVar6 + 0x1d8);
		        goto code_r0x81094cfd;
		      }
		      uVar3 = uVar3 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar3);
		  }
		  puVar1 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x23);
		code_r0x81094cfd:
		  iVar6 = (**(code **)((ulonglong)*puVar1 * 4))(piVar5,CONCAT44(in_register_20000014,puVar1[1]));
		  iVar8 = **(int **)(iVar6 + 0x10);
		  uVar2 = (**(code **)((ulonglong)*(uint *)(iVar8 + 0x100) * 4))
		                    (*(int **)(iVar6 + 0x10),*(undefined4 *)(iVar8 + 0x104));
		  uVar4 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                    (*(undefined4 *)(param1[2] + 8),0);
		  uVar3 = Gameplay_Chat_Model_ChatModel__RemoveFavorite(uVar2,uVar4,&local_4,0);
		  piVar5 = *(int **)(param1[2] + 0x28);
		  iVar6 = *piVar5;
		  uVar7 = (uint)*(ushort *)(iVar6 + 0xb6);
		  uVar2 = (undefined4)((ulonglong)uVar4 >> 0x20);
		  if (uVar3 == 0) {
		    if (uVar7 != 0) {
		      uVar9 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar9 * 8)) {
		          puVar1 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar9 * 8 + 4) * 8 + iVar6 + 0x1d8);
		          goto code_r0x81094e39;
		        }
		        uVar9 = uVar9 + 1;
		      } while (uVar7 != uVar9);
		    }
		    puVar1 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x23);
		code_r0x81094e39:
		    iVar6 = (**(code **)((ulonglong)*puVar1 * 4))(piVar5,CONCAT44(uVar2,puVar1[1]));
		    uVar2 = *(undefined4 *)(iVar6 + 0x10);
		    uVar4 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                      (*(undefined4 *)(param1[2] + 8),0);
		    Gameplay_Chat_Control_ChatController__SetRoom(uVar2,uVar4,0);
		    uVar2 = (undefined4)((ulonglong)uVar4 >> 0x20);
		  }
		  else {
		    if (uVar7 != 0) {
		      uVar9 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar9 * 8)) {
		          puVar1 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar9 * 8 + 4) * 8 + iVar6 + 0x1d8);
		          goto code_r0x81094dc1;
		        }
		        uVar9 = uVar9 + 1;
		      } while (uVar7 != uVar9);
		    }
		    puVar1 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x23);
		code_r0x81094dc1:
		    uVar4 = CONCAT44(uVar2,puVar1[1]);
		    iVar6 = (**(code **)((ulonglong)*puVar1 * 4))(piVar5,uVar4);
		    uVar2 = (undefined4)((ulonglong)uVar4 >> 0x20);
		    Gameplay_Chat_Control_ChatController__RemoveFromFavorites
		              (*(undefined4 *)(iVar6 + 0x10),local_4,0);
		  }
		  iVar6 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,CONCAT44(uVar2,*(undefined4 *)(*param1 + 0x15c)));
		  UI_SelectedButton__get_Selected(*(undefined4 *)(iVar6 + 0x44),uVar3 ^ 1,0);
		  return;
		}
		*/

		}

		// Token: 0x060018D7 RID: 6359 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018D7")]
		[Address(RVA = "0x6A76", Offset = "0x6A76", VA = "0x6A76")]
		private void HandleAddToFriendsButtonClickEvent(object sender, PointerEventData eventData)
		{
		/* --- GHIDRA: HandleAddToFriendsButtonClickEvent ---
		void Gameplay_UserInfo_Control_UserInfoViewMediator__HandleAddToFriendsButtonClickEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 param3_00;
		  uint *puVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int *piVar5;
		  int iVar6;
		  
		  if (DAT_ram_00a59944 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_UserInfoModel__UserInfoEvents__UserInfoController__UserInfoView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Aprs_View_AprsWindowArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_PopupController_Show_AprsWindow___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2582);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12562);
		    DAT_ram_00a59944 = '\x01';
		  }
		  iVar4 = *(int *)(param1 + 8);
		  if ((*(int *)(iVar4 + 8) != *(int *)(*(int *)(iVar4 + 0xc) + 8)) &&
		     (*(char *)(*(int *)(iVar4 + 8) + 0x49) != '\0')) {
		    uVar1 = 0;
		    piVar5 = *(int **)(iVar4 + 0x28);
		    iVar4 = *piVar5;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xe0);
		          goto code_r0x81094f78;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x81094f78:
		    piVar5 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		    uVar1 = 0;
		    iVar4 = *piVar5;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      do {
		        if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xf0);
		          goto code_r0x81094ffa;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar5,Core_Application_IApp_TypeInfo,6);
		code_r0x81094ffa:
		    uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    param3_00 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_2582,1,0,1,0,0,0,0);
		    Core_Application_App__get_ToastController(uVar3,1,param3_00,0);
		    return;
		  }
		  uVar1 = 0;
		  piVar5 = *(int **)(iVar4 + 0x28);
		  iVar4 = *piVar5;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xe0);
		        goto code_r0x810950b8;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x810950b8:
		  piVar5 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		  uVar1 = 0;
		  iVar4 = *piVar5;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xe8);
		        goto code_r0x8109513a;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,Core_Application_IApp_TypeInfo,5);
		code_r0x8109513a:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		  iVar4 = unnamed_function_1417(Gameplay_Aprs_View_AprsWindowArgs_TypeInfo);
		  Gameplay_AccountLinker_View_SelectUserWindow___ctor(iVar4,0);
		  iVar6 = *(int *)(param1 + 8);
		  *(undefined4 *)(iVar4 + 0x18) = *(undefined4 *)(iVar6 + 8);
		  *(undefined4 *)(iVar4 + 0x1c) = *(undefined4 *)(*(int *)(iVar6 + 0xc) + 8);
		  Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		            (uVar3,StringLiteral_12562,iVar4,Method_UI_Windows_PopupController_Show_AprsWindow___);
		  return;
		}
		*/

		}

		// Token: 0x060018D8 RID: 6360 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018D8")]
		[Address(RVA = "0x6A77", Offset = "0x6A77", VA = "0x6A77")]
		private void HandleAprsButtonClickEvent(IndexButtonBasic button)
		{
		/* --- GHIDRA: HandleAprsButtonClickEvent ---
		void Gameplay_UserInfo_Control_UserInfoViewMediator__HandleAprsButtonClickEvent
		               (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 in_register_20000014;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined8 param2_00;
		  int *piVar4;
		  int iVar5;
		  int iVar6;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a59945 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_UserInfoModel__UserInfoEvents__UserInfoController__UserInfoView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a59945 = '\x01';
		  }
		  local_4 = 0;
		  piVar4 = *(int **)(*(int *)(param1 + 8) + 0x28);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x1d8);
		        goto code_r0x81095242;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x23);
		code_r0x81095242:
		  iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,CONCAT44(in_register_20000014,puVar2[1]));
		  iVar6 = **(int **)(iVar5 + 0x10);
		  uVar3 = (**(code **)((ulonglong)*(uint *)(iVar6 + 0x100) * 4))
		                    (*(int **)(iVar5 + 0x10),*(undefined4 *)(iVar6 + 0x104));
		  param2_00 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                        (*(undefined4 *)(*(int *)(param1 + 8) + 8),0);
		  iVar5 = Gameplay_Chat_Model_ChatModel__TryGetFavorite(uVar3,param2_00,&local_4,0);
		  uVar3 = (undefined4)((ulonglong)param2_00 >> 0x20);
		  if (iVar5 != 0) {
		    piVar4 = *(int **)(*(int *)(param1 + 8) + 0x28);
		    iVar5 = *piVar4;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x1d8);
		          goto code_r0x810952fc;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x23);
		code_r0x810952fc:
		    uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,CONCAT44(uVar3,puVar2[1]));
		    Core_Gameplay_Managers_ChatManager__get_Name(uVar3,local_4,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060018D9 RID: 6361 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018D9")]
		[Address(RVA = "0x6A78", Offset = "0x6A78", VA = "0x6A78")]
		private void HandleChatBanButtonClickEvent()
		{
		/* --- GHIDRA: HandleChatBanButtonClickEvent ---
		void Gameplay_UserInfo_Control_UserInfoViewMediator__HandleChatBanButtonClickEvent
		               (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar3;
		  
		  if (DAT_ram_00a59946 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_UserInfoModel__UserInfoEvents__UserInfoController__UserInfoView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a59946 = '\x01';
		  }
		  param1_01 = *(int **)(*(int *)(param1 + 8) + 0x28);
		  iVar3 = *param1_01;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x228);
		        goto code_r0x810953c1;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0x2d);
		code_r0x810953c1:
		  param1_00 = (**(code **)((ulonglong)*puVar2 * 4))(param1_01,puVar2[1]);
		  Core_Gameplay_Managers_DuelManager__Init(param1_00,*(undefined4 *)(*(int *)(param1 + 8) + 8),0);
		  return;
		}
		*/

		}

		// Token: 0x060018DA RID: 6362 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018DA")]
		[Address(RVA = "0x6A79", Offset = "0x6A79", VA = "0x6A79")]
		private void HandleDuelButtonClickEvent()
		{
		/* --- GHIDRA: HandleDuelButtonClickEvent ---
		void Gameplay_UserInfo_Control_UserInfoViewMediator__HandleDuelButtonClickEvent
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a59947 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_UserInfoModel__UserInfoEvents__UserInfoController__UserInfoView__get_Model__
		              );
		    DAT_ram_00a59947 = '\x01';
		  }
		  param2_00 = *(undefined4 *)(*(int *)(param1[2] + 8) + 0x4c);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_UserInfo_View_UserNickCultLevelExpView__SetNick
		            (*(undefined4 *)(iVar1 + 100),param2_00,param1);
		  return;
		}
		*/

		}

		// Token: 0x060018DB RID: 6363 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018DB")]
		[Address(RVA = "0x6A7A", Offset = "0x6A7A", VA = "0x6A7A")]
		private void HandleUserCultGenderChangedEvent()
		{
		/* --- GHIDRA: HandleUserCultGenderChangedEvent ---
		void Gameplay_UserInfo_Control_UserInfoViewMediator__HandleUserCultGenderChangedEvent
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = **(int **)(iVar1 + 0x50);
		  (**(code **)((ulonglong)*(uint *)(iVar2 + 0xe8) * 4))
		            (*(int **)(iVar1 + 0x50),*(undefined4 *)(iVar2 + 0xec));
		  return;
		}
		*/

		}

		// Token: 0x060018DC RID: 6364 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018DC")]
		[Address(RVA = "0x6A7B", Offset = "0x6A7B", VA = "0x6A7B")]
		private void HandleUserSkillsChangedEvent()
		{
		/* --- GHIDRA: HandleUserSkillsChangedEvent ---
		void Gameplay_UserInfo_Control_UserInfoViewMediator__HandleUserSkillsChangedEvent
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  undefined4 uVar5;
		  int param3;
		  int *piVar6;
		  int iVar7;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a59948 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_UserInfoModel__UserInfoEvents__UserInfoController__UserInfoView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a59948 = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  *(undefined4 *)(*(int *)(iVar2 + 0x54) + 0x1c) = *(undefined4 *)(param1[2] + 8);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  *(undefined4 *)(*(int *)(iVar2 + 0x50) + 0x2c) = *(undefined4 *)(param1[2] + 8);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  *(undefined4 *)(*(int *)(iVar2 + 0x50) + 0x30) = *(undefined4 *)(param1[2] + 0x1c);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = *(int *)(iVar2 + 100);
		  param3 = *(int *)(param1[2] + 8);
		  piVar6 = *(int **)(param1[2] + 0x28);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x140);
		        goto code_r0x810955b8;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x810955b8:
		  uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(piVar6,puVar3[1]);
		  *(undefined4 *)(iVar2 + 0x28) = uVar4;
		  iVar7 = *(int *)(iVar2 + 0x2c);
		  if (param3 != iVar7) {
		    *(int *)(iVar2 + 0x2c) = param3;
		    Gameplay_UserInfo_View_UserNickCultLevelExpView__set_User(iVar2,iVar7,param3,iVar7);
		  }
		  if (DAT_ram_00a5994a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_AprDic__uint__get_Data__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_UserInfoModel__UserInfoEvents__UserInfoController__UserInfoView__get_Model__
		              );
		    DAT_ram_00a5994a = '\x01';
		  }
		  uVar4 = UI_Wiki_WikiUriRouter__SetData
		                    (*(undefined4 *)(*(int *)(*(int *)(param1[2] + 8) + 0x38) + 0x10),0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Core_Extensions_Dict_AprDicExt__Get1024AssetId(*(undefined4 *)(iVar2 + 0x1c),uVar4,0);
		  uVar4 = Google_Protobuf_Collections_RepeatedField_object___GetEnumerator
		                    (*(undefined4 *)(param1[2] + 8),0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  piVar6 = *(int **)(*(int *)(iVar2 + 100) + 0x10);
		  iVar2 = *piVar6;
		  (**(code **)((ulonglong)*(uint *)(iVar2 + 0x2d0) * 4))
		            (piVar6,uVar4,*(undefined4 *)(iVar2 + 0x2d4));
		  uVar4 = *(undefined4 *)(*(int *)(param1[2] + 8) + 0x4c);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_UserInfo_View_UserNickCultLevelExpView__SetNick(*(undefined4 *)(iVar2 + 100),uVar4,uVar4)
		  ;
		  puVar3 = (uint *)param1[2];
		  if (puVar3[2] == *(uint *)(puVar3[3] + 8)) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar4 = *(undefined4 *)(*(int *)(iVar2 + 0x50) + 0x24);
		    uVar1 = 0;
		    piVar6 = *(int **)(param1[2] + 0x28);
		    iVar2 = *piVar6;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x178);
		          goto code_r0x81095765;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x81095765:
		    uVar5 = (**(code **)((ulonglong)*puVar3 * 4))(piVar6,puVar3[1]);
		    uVar5 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar5,0);
		    param2_00 = 2;
		    if (*(char *)(*(int *)(param1[2] + 8) + 0x74) == '\0') {
		      param2_00 = 1;
		    }
		    uVar5 = Core_Extensions_Dict_DictExt__GetArtikulTypeMenuActionDic(uVar5,param2_00,0);
		    uVar5 = Core_Extensions_Dict_EventTypeDicExt__GetDescription(uVar5,0);
		    Core_Extensions_Dict_PortalDicExt__GetCurrencyIcon60x66(uVar4,uVar5,0);
		  }
		  Gameplay_UserInfo_Control_UserInfoViewMediator__SetCult(param1,puVar3);
		  uVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar4 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (uVar4,0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar4,1,0);
		  return;
		}
		*/

		}

		// Token: 0x060018DD RID: 6365 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018DD")]
		[Address(RVA = "0x6A7C", Offset = "0x6A7C", VA = "0x6A7C")]
		private void HandleInitEvent()
		{
		/* --- GHIDRA: HandleInitEvent ---
		void Gameplay_UserInfo_Control_UserInfoViewMediator__HandleInitEvent(int *param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int *piVar3;
		  
		  if (DAT_ram_00a59949 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_UserInfoModel__UserInfoEvents__UserInfoController__UserInfoView__get_Model__
		              );
		    DAT_ram_00a59949 = '\x01';
		  }
		  uVar1 = Google_Protobuf_Collections_RepeatedField_object___GetEnumerator
		                    (*(undefined4 *)(param1[2] + 8),0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  piVar3 = *(int **)(*(int *)(iVar2 + 100) + 0x10);
		  iVar2 = *piVar3;
		  (**(code **)((ulonglong)*(uint *)(iVar2 + 0x2d0) * 4))
		            (piVar3,uVar1,*(undefined4 *)(iVar2 + 0x2d4));
		  return;
		}
		*/

		}

		// Token: 0x060018DE RID: 6366 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018DE")]
		[Address(RVA = "0x6A7D", Offset = "0x6A7D", VA = "0x6A7D")]
		private void HandleUserNickChangedEvent()
		{
		/* --- GHIDRA: HandleUserNickChangedEvent ---
		void Gameplay_UserInfo_Control_UserInfoViewMediator__HandleUserNickChangedEvent
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 param2_00;
		  int iVar1;
		  
		  if (DAT_ram_00a5994a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_AprDic__uint__get_Data__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_UserInfoModel__UserInfoEvents__UserInfoController__UserInfoView__get_Model__
		              );
		    DAT_ram_00a5994a = '\x01';
		  }
		  param2_00 = UI_Wiki_WikiUriRouter__SetData
		                        (*(undefined4 *)(*(int *)(*(int *)(param1[2] + 8) + 0x38) + 0x10),0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Core_Extensions_Dict_AprDicExt__Get1024AssetId(*(undefined4 *)(iVar1 + 0x1c),param2_00,0);
		  return;
		}
		*/

		}

		// Token: 0x060018DF RID: 6367 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018DF")]
		[Address(RVA = "0x6A7E", Offset = "0x6A7E", VA = "0x6A7E")]
		private void SetCurrentAvatar()
		{
		/* --- GHIDRA: SetCurrentAvatar ---
		void Gameplay_UserInfo_Control_UserInfoViewMediator__SetCurrentAvatar
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Core_Extensions_Dict_AprDicExt__Get1024AssetId(*(undefined4 *)(iVar1 + 0x1c),param2,0);
		  return;
		}
		*/

		}

		// Token: 0x060018E0 RID: 6368 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018E0")]
		[Address(RVA = "0x6A7F", Offset = "0x6A7F", VA = "0x6A7F")]
		private void SetAvatar(string assetId)
		{
		/* --- GHIDRA: SetAvatar ---
		void Gameplay_UserInfo_Control_UserInfoViewMediator__SetAvatar
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  int *piVar2;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  piVar2 = *(int **)(*(int *)(iVar1 + 100) + 0x10);
		  iVar1 = *piVar2;
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x2d0) * 4))
		            (piVar2,param2,*(undefined4 *)(iVar1 + 0x2d4));
		  return;
		}
		*/

		}

		// Token: 0x060018E1 RID: 6369 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018E1")]
		[Address(RVA = "0x6A80", Offset = "0x6A80", VA = "0x6A80")]
		private void SetNick(string nick)
		{
		/* --- GHIDRA: SetNick ---
		void Gameplay_UserInfo_Control_UserInfoViewMediator__SetNick
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_UserInfo_View_UserNickCultLevelExpView__SetNick
		            (*(undefined4 *)(iVar1 + 100),param2,param1);
		  return;
		}
		*/

		}

		// Token: 0x060018E2 RID: 6370 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018E2")]
		[Address(RVA = "0x6A81", Offset = "0x6A81", VA = "0x6A81")]
		private void SetCult(CultDic cultDic)
		{
		/* --- GHIDRA: SetCult ---
		void Gameplay_UserInfo_Control_UserInfoViewMediator__SetCult(int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  int iVar5;
		  char cVar6;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5994b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_UserInfoModel__UserInfoEvents__UserInfoController__UserInfoView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_UserInfo_View_Equipment_BaseEquipmentView_UserEquipmentSlotConfig__set_Artifacts__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Discounts_Model_IDiscountsProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5994b = '\x01';
		  }
		  local_8 = 0;
		  local_c = 0;
		  piVar4 = *(int **)(param1[2] + 0x28);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x248);
		        goto code_r0x81095895;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x31);
		code_r0x81095895:
		  iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		  uVar1 = 0;
		  piVar4 = *(int **)(iVar5 + 0x20);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Gameplay_Discounts_Model_IDiscountsProvider_TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 200);
		        goto code_r0x8109591a;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Gameplay_Discounts_Model_IDiscountsProvider_TypeInfo,1);
		code_r0x8109591a:
		  (**(code **)((ulonglong)*puVar2 * 4))(piVar4,1,&local_8,puVar2[1]);
		  uVar1 = 0;
		  piVar4 = *(int **)(param1[2] + 0x28);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x248);
		        goto code_r0x810959a8;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x31);
		code_r0x810959a8:
		  iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		  uVar1 = 0;
		  piVar4 = *(int **)(iVar5 + 0x20);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Gameplay_Discounts_Model_IDiscountsProvider_TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar5 + *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x81095a2d;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Gameplay_Discounts_Model_IDiscountsProvider_TypeInfo,0);
		code_r0x81095a2d:
		  (**(code **)((ulonglong)*puVar2 * 4))(piVar4,10,&local_c,puVar2[1]);
		  uVar1 = 0;
		  iVar5 = *(int *)(param1[2] + 8);
		  if (iVar5 != *(int *)(*(int *)(param1[2] + 0xc) + 8)) {
		    uVar1 = Core_Extensions_UriExt___c___QueryStringToDictionary_b__0_1(iVar5,0);
		  }
		  iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(iVar5 + 0x48),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar3,uVar1,0);
		  iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(iVar5 + 0x34),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar3,uVar1 ^ 1,0);
		  iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(iVar5 + 0x38),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar3,(uint)(*(int *)(param1[2] + 8) == *(int *)(*(int *)(param1[2] + 0xc) + 8)),0);
		  iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(iVar5 + 0x4c),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar3,(uint)(*(int *)(param1[2] + 8) != *(int *)(*(int *)(param1[2] + 0xc) + 8)),0);
		  iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (*(undefined4 *)(*(int *)(iVar5 + 0x50) + 0x28),
		             (uint)(*(int *)(param1[2] + 8) == *(int *)(*(int *)(param1[2] + 0xc) + 8)),0);
		  iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(iVar5 + 0x58),0);
		  iVar5 = *(int *)(param1[2] + 8);
		  if (iVar5 == *(int *)(*(int *)(param1[2] + 0xc) + 8)) {
		    cVar6 = '\0';
		  }
		  else {
		    cVar6 = *(char *)(iVar5 + 0x48);
		  }
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar3,(uint)(cVar6 == '\0'),0);
		  iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(iVar5 + 0x30),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar3,(uint)(*(int *)(param1[2] + 8) == *(int *)(*(int *)(param1[2] + 0xc) + 8)),0);
		  if (uVar1 == 0) {
		    iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    Gameplay_UserInfo_View_Equipment_BaseEquipmentView_object___remove_SlotClickedEvent
		              (*(undefined4 *)(iVar5 + 0x20),*(undefined4 *)(*(int *)(param1[2] + 0x14) + 0x2c),
		               Method_Gameplay_UserInfo_View_Equipment_BaseEquipmentView_UserEquipmentSlotConfig__set_Artifacts__
		              );
		  }
		  return;
		}
		*/

		}

		// Token: 0x060018E3 RID: 6371 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018E3")]
		[Address(RVA = "0x6A82", Offset = "0x6A82", VA = "0x6A82")]
		private void HandleHideElements()
		{
		/* --- GHIDRA: HandleHideElements ---
		void Gameplay_UserInfo_Control_UserInfoViewMediator__HandleHideElements
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  undefined4 uVar3;
		  int *piVar4;
		  int iVar5;
		  int iVar6;
		  
		  if (DAT_ram_00a5994c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_UserInfoModel__UserInfoEvents__UserInfoController__UserInfoView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_PopupController_Show_UserInfoEditWindow___);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_UserInfo_View_UserInfoEditWindow_UserInfoEditWindowArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12682);
		    DAT_ram_00a5994c = '\x01';
		  }
		  piVar4 = *(int **)(param1[2] + 0x28);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xe0);
		        goto code_r0x8109415b;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x8109415b:
		  piVar4 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		  uVar1 = 0;
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xe8);
		        goto code_r0x810941dd;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_Application_IApp_TypeInfo,5);
		code_r0x810941dd:
		  param1_00 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		  iVar6 = param1[2];
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x14c));
		  iVar5 = unnamed_function_1417
		                    (Gameplay_UserInfo_View_UserInfoEditWindow_UserInfoEditWindowArgs_TypeInfo);
		  UI_Windows_BaseWindowArgs__Dispose(iVar5,0);
		  *(undefined4 *)(iVar5 + 0x1c) = uVar3;
		  *(int *)(iVar5 + 0x18) = iVar6;
		  Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		            (param1_00,StringLiteral_12682,iVar5,
		             Method_UI_Windows_PopupController_Show_UserInfoEditWindow___);
		  return;
		}
		*/

		}

		// Token: 0x060018E4 RID: 6372 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018E4")]
		[Address(RVA = "0x6A83", Offset = "0x6A83", VA = "0x6A83")]
		private void ShowEditeWindow()
		{
		}
	}
}
