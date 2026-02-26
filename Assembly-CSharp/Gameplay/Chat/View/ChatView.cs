using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Sorting;
using Gameplay.Chat.Control;
using Gameplay.Chat.Model;
using Gameplay.Chat.Model.Data;
using Gameplay.Chat.View.Messages;
using Gameplay.Chat.View.Smiles;
using Gameplay.Chat.View.Sorting;
using Gameplay.UserInfo.View;
using Il2CppDummyDll;
using Protocol.Dic;
using TMPro;
using UI;
using UI.Tabs;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Gameplay.Chat.View
{
	// Token: 0x02000AEB RID: 2795
	[Token(Token = "0x2000AEB")]
	public class ChatView : MonoBehaviourWithStates<ChatViewStates>, IChatView
	{
		// Token: 0x17000D46 RID: 3398
		// (get) Token: 0x0600435E RID: 17246 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000D46")]
		public TabBar RoomsTabBar
		{
			[Token(Token = "0x600435E")]
			[Address(RVA = "0x9212", Offset = "0x9212", VA = "0x9212")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000D47 RID: 3399
		// (get) Token: 0x0600435F RID: 17247 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000D47")]
		public SelectedButton PrivateMessagesButton
		{
			[Token(Token = "0x600435F")]
			[Address(RVA = "0x9213", Offset = "0x9213", VA = "0x9213")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000D48 RID: 3400
		// (get) Token: 0x06004360 RID: 17248 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000D48")]
		public SelectedButton MiniChatViewSwitchButton
		{
			[Token(Token = "0x6004360")]
			[Address(RVA = "0x9214", Offset = "0x9214", VA = "0x9214")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000D49 RID: 3401
		// (get) Token: 0x06004361 RID: 17249 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000D49")]
		public SelectedButton RoomVisitorsOrContactsButton
		{
			[Token(Token = "0x6004361")]
			[Address(RVA = "0x9215", Offset = "0x9215", VA = "0x9215")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000D4A RID: 3402
		// (get) Token: 0x06004362 RID: 17250 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000D4A")]
		public PatternTextInput MessageTextInput
		{
			[Token(Token = "0x6004362")]
			[Address(RVA = "0x9216", Offset = "0x9216", VA = "0x9216")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000D4B RID: 3403
		// (get) Token: 0x06004363 RID: 17251 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000D4B")]
		public ChatRoomVisitorsListAdapter VisitorsList
		{
			[Token(Token = "0x6004363")]
			[Address(RVA = "0x9217", Offset = "0x9217", VA = "0x9217")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000D4C RID: 3404
		// (get) Token: 0x06004364 RID: 17252 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000D4C")]
		public MessagesListAdapter MessagesList
		{
			[Token(Token = "0x6004364")]
			[Address(RVA = "0x9218", Offset = "0x9218", VA = "0x9218")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000D4D RID: 3405
		// (get) Token: 0x06004365 RID: 17253 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000D4D")]
		public SmilesView SmilesView
		{
			[Token(Token = "0x6004365")]
			[Address(RVA = "0x9219", Offset = "0x9219", VA = "0x9219")]
			get
			{
				return null;
			}
		}

		// Token: 0x140001A4 RID: 420
		// (add) Token: 0x06004366 RID: 17254 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06004367 RID: 17255 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001A4")]
		public event Action SendMessageEvent
		{
			[Token(Token = "0x6004366")]
			[Address(RVA = "0x921A", Offset = "0x921A", VA = "0x921A")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6004367")]
			[Address(RVA = "0x921B", Offset = "0x921B", VA = "0x921B")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06004368 RID: 17256 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004368")]
		[Address(RVA = "0x921C", Offset = "0x921C", VA = "0x921C")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_Chat_View_ChatView__OnDestroy(int param1,undefined4 param2)
		
		{
		  bool bVar1;
		  int iVar2;
		  uint uVar3;
		  uint *puVar4;
		  undefined4 uVar5;
		  undefined4 uVar6;
		  int param1_00;
		  int *piVar7;
		  int iVar8;
		  undefined4 param4;
		  int iVar9;
		  
		  if (DAT_ram_00a57adf == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Sorting_AbstractSortControlView_ChatVisitorData__add_ComparerChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ChatSmileDic__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_IGameDataComparer_ChatVisitorData___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Chat_Control_ChatViewMediator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_Chat_View_ChatView_HandleMessageInputSubmit__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Chat_View_ChatView_HandleMessageTextInputStatusChangedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Chat_View_ChatView_HandleSendMessageButtonClickEvent__);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_Chat_View_ChatView_HandleSmilesButtonClickEvent__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Chat_View_ChatView_HandleSmilesViewItemSelectedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Chat_View_ChatView_HandleVisitorsSearchFieldOnValueChanged__);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_Chat_View_ChatView_HandleVisitorsSortTriggered__);
		    Mono_Security_ASN1__get_Item(&System_EventHandler_PointerEventData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Events_UnityEvent_string__AddListener__);
		    DAT_ram_00a57adf = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar3 = 0;
		  piVar7 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar8 = *piVar7;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar3 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar3 * 8 + 4) * 8 + iVar8 + 0x1d8);
		        goto code_r0x80e1ff7f;
		      }
		      uVar3 = uVar3 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar3);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,0x23);
		code_r0x80e1ff7f:
		  iVar8 = (**(code **)((ulonglong)*puVar4 * 4))(piVar7,puVar4[1]);
		  iVar9 = **(int **)(iVar8 + 0x10);
		  uVar5 = (**(code **)((ulonglong)*(uint *)(iVar9 + 0x100) * 4))
		                    (*(int **)(iVar8 + 0x10),*(undefined4 *)(iVar9 + 0x104));
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar7 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar8 = *piVar7;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    uVar3 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar3 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar3 * 8 + 4) * 8 + iVar8 + 0x1d8);
		        goto code_r0x80e20044;
		      }
		      uVar3 = uVar3 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar3);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,0x23);
		code_r0x80e20044:
		  iVar8 = (**(code **)((ulonglong)*puVar4 * 4))(piVar7,puVar4[1]);
		  iVar9 = **(int **)(iVar8 + 0x10);
		  uVar6 = (**(code **)((ulonglong)*(uint *)(iVar9 + 0x110) * 4))
		                    (*(int **)(iVar8 + 0x10),*(undefined4 *)(iVar9 + 0x114));
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar7 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar8 = *piVar7;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    uVar3 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar3 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar3 * 8 + 4) * 8 + iVar8 + 0x1d8);
		        goto code_r0x80e20109;
		      }
		      uVar3 = uVar3 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar3);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,0x23);
		code_r0x80e20109:
		  iVar8 = (**(code **)((ulonglong)*puVar4 * 4))(piVar7,puVar4[1]);
		  param4 = *(undefined4 *)(iVar8 + 0x10);
		  piVar7 = (int *)unnamed_function_1417(Gameplay_Chat_Control_ChatViewMediator_TypeInfo);
		  Gameplay_Chat_Control_ChatMiniViewMediator__TryCloseChat(piVar7,uVar5,uVar6,param4,0);
		  *(int **)(param1 + 0x80) = piVar7;
		  (**(code **)((ulonglong)*(uint *)(*piVar7 + 0x160) * 4))
		            (piVar7,param1,*(undefined4 *)(*piVar7 + 0x164));
		  uVar6 = *(undefined4 *)(*(int *)(param1 + 0x20) + 0xb4);
		  uVar5 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar5,param1,Method_Gameplay_Chat_View_ChatView_HandleSendMessageButtonClickEvent__,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar6,uVar5,0);
		  uVar6 = *(undefined4 *)(*(int *)(*(int *)(param1 + 0x34) + 0x10) + 0x11c);
		  uVar5 = unnamed_function_1417(UnityEngine_Events_UnityAction_string__TypeInfo);
		  func_ii_7054(uVar5,param1,Method_Gameplay_Chat_View_ChatView_HandleMessageInputSubmit__,0);
		  UnityEngine_Events_UnityEvent_InputAction_CallbackContext____ctor
		            (uVar6,uVar5,Method_UnityEngine_Events_UnityEvent_string__AddListener__);
		  uVar6 = *(undefined4 *)(param1 + 0x34);
		  uVar5 = unnamed_function_1417(System_Action_bool__TypeInfo);
		  System_Action_AsyncGPUReadbackRequest___Invoke
		            (uVar5,param1,
		             Method_Gameplay_Chat_View_ChatView_HandleMessageTextInputStatusChangedEvent__,0);
		  Gameplay_UserInfo_View_NickVariantItemRow___ctor(uVar6,uVar5,0);
		  Gameplay_UserInfo_View_PatternTextInput__get_Status(*(undefined4 *)(param1 + 0x34),1,0);
		  piVar7 = *(int **)(*(int *)(param1 + 0x34) + 0x10);
		  iVar8 = *piVar7;
		  (**(code **)((ulonglong)*(uint *)(iVar8 + 0x1f0) * 4))(piVar7,*(undefined4 *)(iVar8 + 500));
		  TMPro_TMP_InputField__Validate(*(undefined4 *)(*(int *)(param1 + 0x34) + 0x10),0);
		  uVar6 = *(undefined4 *)(param1 + 0x40);
		  uVar5 = unnamed_function_1417(System_Action_IGameDataComparer_ChatVisitorData___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar5,param1,Method_Gameplay_Chat_View_ChatView_HandleVisitorsSortTriggered__,0);
		  UI_Sorting_AbstractSortControlView___Il2CppFullySharedGenericType___SwitcherValueChangedHandler
		            (uVar6,uVar5,
		             Method_UI_Sorting_AbstractSortControlView_ChatVisitorData__add_ComparerChangedEvent__);
		  uVar6 = *(undefined4 *)(*(int *)(param1 + 0x38) + 0x130);
		  uVar5 = unnamed_function_1417(UnityEngine_Events_UnityAction_string__TypeInfo);
		  func_ii_7054(uVar5,param1,
		               Method_Gameplay_Chat_View_ChatView_HandleVisitorsSearchFieldOnValueChanged__,0);
		  UnityEngine_Events_UnityEvent_InputAction_CallbackContext____ctor
		            (uVar6,uVar5,Method_UnityEngine_Events_UnityEvent_string__AddListener__);
		  uVar6 = *(undefined4 *)(param1 + 0x28);
		  uVar5 = unnamed_function_1417(System_EventHandler_PointerEventData__TypeInfo);
		  UnityEngine_Object__Instantiate_object_
		            (uVar5,param1,Method_Gameplay_Chat_View_ChatView_HandleSmilesButtonClickEvent__,0);
		  UI_RawImageWithGrayscale___ctor(uVar6,uVar5,0);
		  iVar8 = *(int *)(param1 + 0x48);
		  uVar5 = unnamed_function_1417(System_Action_ChatSmileDic__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar5,param1,Method_Gameplay_Chat_View_ChatView_HandleSmilesViewItemSelectedEvent__,0);
		  if (DAT_ram_00a57afe == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ChatSmileDic__TypeInfo);
		    DAT_ram_00a57afe = '\x01';
		  }
		  iVar9 = *(int *)(iVar8 + 0x34);
		  while( true ) {
		    iVar2 = 0;
		    param1_00 = UnityEngine_UI_Image__set_sprite(iVar9,uVar5,0);
		    uVar6 = System_Action_ChatSmileDic__TypeInfo;
		    if ((param1_00 != 0) &&
		       (iVar2 = func_ii_1082(param1_00,System_Action_ChatSmileDic__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(iVar8 + 0x34,iVar2,iVar9);
		    bVar1 = iVar2 == iVar9;
		    iVar9 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_00,uVar6);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06004369 RID: 17257 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004369")]
		[Address(RVA = "0x921D", Offset = "0x921D", VA = "0x921D")]
		private void Start()
		{
		/* --- GHIDRA: Start ---
		void Gameplay_Chat_View_ChatView__Start(int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param1 + 0x84);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600436A RID: 17258 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600436A")]
		[Address(RVA = "0x921E", Offset = "0x921E", VA = "0x921E")]
		private void HandleMessageInputSubmit(string text)
		{
		/* --- GHIDRA: HandleMessageInputSubmit ---
		void Gameplay_Chat_View_ChatView__HandleMessageInputSubmit
		               (int param1,int *param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a57ae0 == '\0') {
		    Mono_Security_ASN1__get_Item(&UI_SelectedButton_TypeInfo);
		    DAT_ram_00a57ae0 = '\x01';
		  }
		  if (param2 != (int *)0x0) {
		    if (((uint)*(byte *)(UI_SelectedButton_TypeInfo + 0xb8) <= (uint)*(byte *)(*param2 + 0xb8)) &&
		       (*(int *)(*(int *)(*param2 + 100) + (uint)*(byte *)(UI_SelectedButton_TypeInfo + 0xb8) * 4 +
		                -4) == UI_SelectedButton_TypeInfo)) {
		      if ((char)param2[8] != '\0') {
		        if (DAT_ram_00a57ae7 == '\0') {
		          Mono_Security_ASN1__get_Item
		                    (&Method_UI_MonoBehaviourWithStates_SmilesViewStates__set_CurrentState__);
		          DAT_ram_00a57ae7 = '\x01';
		        }
		        UI_SelectedButton__get_Selected(*(undefined4 *)(param1 + 0x28),1,0);
		        uVar1 = *(undefined4 *)(param1 + 0x48);
		        UI_MonoBehaviourWithStates_ByteEnum___remove_CurrentStateChangedEvent
		                  (uVar1,0xff,Method_UI_MonoBehaviourWithStates_SmilesViewStates__set_CurrentState__
		                  );
		        UI_MonoBehaviourWithStates_ByteEnum___remove_CurrentStateChangedEvent
		                  (uVar1,0xff,Method_UI_MonoBehaviourWithStates_SmilesViewStates__set_CurrentState__
		                  );
		        return;
		      }
		      if (DAT_ram_00a57ae8 == '\0') {
		        Mono_Security_ASN1__get_Item
		                  (&Method_UI_MonoBehaviourWithStates_SmilesViewStates__set_CurrentState__);
		        DAT_ram_00a57ae8 = '\x01';
		      }
		      UI_SelectedButton__get_Selected(*(undefined4 *)(param1 + 0x28),0,0);
		      uVar1 = *(undefined4 *)(param1 + 0x48);
		      UI_MonoBehaviourWithStates_ByteEnum___remove_CurrentStateChangedEvent
		                (uVar1,0,Method_UI_MonoBehaviourWithStates_SmilesViewStates__set_CurrentState__);
		      UI_MonoBehaviourWithStates_ByteEnum___remove_CurrentStateChangedEvent
		                (uVar1,0,Method_UI_MonoBehaviourWithStates_SmilesViewStates__set_CurrentState__);
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600436B RID: 17259 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600436B")]
		[Address(RVA = "0x921F", Offset = "0x921F", VA = "0x921F")]
		private void HandleSmilesButtonClickEvent(object sender, PointerEventData e)
		{
		/* --- GHIDRA: HandleSmilesButtonClickEvent ---
		void Gameplay_Chat_View_ChatView__HandleSmilesButtonClickEvent
		               (int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int param3_00;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  
		  if (DAT_ram_00a57ae1 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Chat_Model_Data_Message_Format_ChatMsgPresenter_TypeInfo)
		    ;
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_First_string___);
		    Mono_Security_ASN1__get_Item(&System_Math_TypeInfo);
		    DAT_ram_00a57ae1 = '\x01';
		  }
		  uVar2 = *(undefined4 *)(param2 + 0x10);
		  if (*(int *)(Gameplay_Chat_Model_Data_Message_Format_ChatMsgPresenter_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Chat_Model_Data_Message_Format_ChatMsgPresenter_TypeInfo);
		  }
		  uVar2 = System_UriBuilder___ctor
		                    (uVar2,**(undefined4 **)
		                             (Gameplay_Chat_Model_Data_Message_Format_ChatMsgPresenter_TypeInfo +
		                             0x5c),0,0);
		  iVar1 = System_Linq_Enumerable__Count_object_(uVar2,Method_System_Linq_Enumerable_First_string___)
		  ;
		  uVar2 = TMPro_TMP_InputField__set_selectionAnchorPosition
		                    (*(undefined4 *)(*(int *)(param1 + 0x34) + 0x10),0);
		  if (*(int *)(System_Math_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_Math_TypeInfo);
		  }
		  param3_00 = UnityEngine_Mathf__Max(uVar2,0,0);
		  uVar3 = *(undefined4 *)(*(int *)(*(int *)(param1 + 0x34) + 0x10) + 0x160);
		  uVar2 = System_Data_DataSet__ReadXmlSchema(uVar3,0,param3_00,0);
		  uVar3 = System_String__get_Chars(uVar3,param3_00,0);
		  uVar2 = UnityEngine_AndroidJavaObject__FromJavaArray_Nullable_int__(uVar2,iVar1,uVar3,0);
		  TMPro_TMP_InputField__get_text(*(undefined4 *)(*(int *)(param1 + 0x34) + 0x10),uVar2,0);
		  TMPro_TMP_InputField__get_caretPosition
		            (*(undefined4 *)(*(int *)(param1 + 0x34) + 0x10),param3_00 + *(int *)(iVar1 + 8),0);
		  piVar4 = *(int **)(*(int *)(param1 + 0x34) + 0x10);
		  iVar1 = *piVar4;
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x1f0) * 4))(piVar4,*(undefined4 *)(iVar1 + 500));
		  TMPro_TMP_InputField__Validate(*(undefined4 *)(*(int *)(param1 + 0x34) + 0x10),0);
		  return;
		}
		*/

		}

		// Token: 0x0600436C RID: 17260 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600436C")]
		[Address(RVA = "0x9220", Offset = "0x9220", VA = "0x9220")]
		private void HandleSmilesViewItemSelectedEvent(ChatSmileDic smileDic)
		{
		}

		// Token: 0x0600436D RID: 17261 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600436D")]
		[Address(RVA = "0x9221", Offset = "0x9221", VA = "0x9221")]
		private void HandleVisitorsSearchFieldOnValueChanged(string value)
		{
		/* --- GHIDRA: HandleVisitorsSearchFieldOnValueChanged ---
		void Gameplay_Chat_View_ChatView__HandleVisitorsSearchFieldOnValueChanged
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param2_00;
		  int *piVar1;
		  
		  piVar1 = *(int **)(param1 + 0x3c);
		  param2_00 = Gameplay_Chat_View_ChatView__HandleCurrentVisitorsSortComparerChanged
		                        (param1,*(undefined4 *)(param1 + 0x88),param1);
		  if (DAT_ram_00a57ad9 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_ChatVisitorData__ResetItems__
		              );
		    DAT_ram_00a57ad9 = '\x01';
		  }
		  (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x2e8) * 4))(piVar1,*(undefined4 *)(*piVar1 + 0x2ec));
		  Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_object___RemoveOneFromStart
		            (piVar1[0x28],param2_00,0,
		             Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_ChatVisitorData__ResetItems__
		            );
		  return;
		}
		*/

		}

		// Token: 0x0600436E RID: 17262 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600436E")]
		[Address(RVA = "0x9222", Offset = "0x9222", VA = "0x9222")]
		private void HandleCurrentVisitorsSortComparerChanged()
		{
		/* --- GHIDRA: HandleCurrentVisitorsSortComparerChanged ---
		undefined4
		Gameplay_Chat_View_ChatView__HandleCurrentVisitorsSortComparerChanged
		          (int param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int iVar4;
		  uint *puVar5;
		  undefined4 *puVar6;
		  int iVar7;
		  int *piVar8;
		  undefined4 uVar9;
		  int *piVar10;
		  int iVar11;
		  int local_c;
		  int **local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a57ae2 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Sorting_AbstractSortControlView_ChatVisitorData__get_SelectedFilter__);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Count_ChatVisitorData___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToList_ChatVisitorData___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Where_ChatVisitorData___);
		    Mono_Security_ASN1__get_Item(&System_Func_ChatVisitorData__ChatVisitorData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_ChatVisitorData__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Extensions_IEnumerableExt_SortGameData_ChatVisitorData__ChatVisitorData___
		              );
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerable_ChatVisitorData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_ChatVisitorData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ChatVisitorData__AddRange__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ChatVisitorData__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ChatVisitorData__ToArray__)
		    ;
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ChatVisitorData___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_ChatVisitorData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Chat_View_ChatView___c__PrepareVisitorForDisplay_b__45_1__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Chat_View_ChatView___c__PrepareVisitorForDisplay_b__45_2__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Chat_View_ChatView___c__DisplayClass45_0__PrepareVisitorForDisplay_b__0__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Chat_View_ChatView___c__DisplayClass45_0_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Chat_View_ChatView___c_TypeInfo);
		    DAT_ram_00a57ae2 = '\x01';
		  }
		  local_4 = (int *)0x0;
		  iVar2 = unnamed_function_1417(Gameplay_Chat_View_ChatView___c__DisplayClass45_0_TypeInfo);
		  uVar3 = System_Convert__FromBase64String(*(undefined4 *)(*(int *)(param1 + 0x38) + 0x160),0);
		  iVar4 = func_ii_7775(uVar3,0);
		  *(int *)(iVar2 + 8) = iVar4;
		  if (1 < *(int *)(iVar4 + 8)) {
		    uVar3 = unnamed_function_1417(System_Func_ChatVisitorData__bool__TypeInfo);
		    System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		              (uVar3,iVar2,
		               Method_Gameplay_Chat_View_ChatView___c__DisplayClass45_0__PrepareVisitorForDisplay_b__0__
		               ,0);
		    param2 = (int *)System_Linq_Enumerable__Where_PlayerLoopSystem_
		                              (param2,uVar3,Method_System_Linq_Enumerable_Where_ChatVisitorData___);
		  }
		  uVar1 = 0;
		  uVar3 = func_ii_6330(param2,Method_System_Linq_Enumerable_Count_ChatVisitorData___);
		  iVar2 = unnamed_function_1417(System_Collections_Generic_List_ChatVisitorData__TypeInfo);
		  Unity_Services_Core_Internal_UnityServicesInternal___c__DisplayClass33_0___InitializeServicesAsync_g__FailServicesInitialization_2
		            (iVar2,uVar3,Method_System_Collections_Generic_List_ChatVisitorData___ctor__);
		  uVar3 = func_ii_6330(param2,Method_System_Linq_Enumerable_Count_ChatVisitorData___);
		  iVar4 = unnamed_function_1417(System_Collections_Generic_List_ChatVisitorData__TypeInfo);
		  Unity_Services_Core_Internal_UnityServicesInternal___c__DisplayClass33_0___InitializeServicesAsync_g__FailServicesInitialization_2
		            (iVar4,uVar3,Method_System_Collections_Generic_List_ChatVisitorData___ctor__);
		  iVar11 = *param2;
		  if (*(ushort *)(iVar11 + 0xb6) != 0) {
		    do {
		      if (System_Collections_Generic_IEnumerable_ChatVisitorData__TypeInfo ==
		          *(int *)(*(int *)(iVar11 + 0x58) + uVar1 * 8)) {
		        puVar5 = (uint *)(iVar11 + *(int *)(*(int *)(iVar11 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80e20969;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar11 + 0xb6) != uVar1);
		  }
		  puVar5 = (uint *)func_ii_1080(param2,
		                                System_Collections_Generic_IEnumerable_ChatVisitorData__TypeInfo,0);
		code_r0x80e20969:
		  local_4 = (int *)(**(code **)((ulonglong)*puVar5 * 4))(param2,puVar5[1]);
		  local_c = 0;
		  local_8 = &local_4;
		code_r0x80e2098e:
		  do {
		    piVar8 = local_4;
		    iVar11 = *local_4;
		    if (*(ushort *)(iVar11 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar10 = (int *)(*(int *)(iVar11 + 0x58) + uVar1 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar10) {
		          puVar6 = (undefined4 *)(iVar11 + piVar10[1] * 8 + 0xc0);
		          goto code_r0x80e20a36;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar11 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar6 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80e20a7e:
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e20c83;
		    }
		code_r0x80e20a36:
		    DAT_ram_009d3e38 = 0;
		    iVar11 = import::env::invoke_iii(*puVar6,piVar8,puVar6[1]);
		    piVar8 = local_4;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80e20a7e;
		    if (iVar11 == 0) {
		      iVar11 = 6;
		      goto code_r0x80e20cd0;
		    }
		    iVar11 = *local_4;
		    if (*(ushort *)(iVar11 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar10 = (int *)(*(int *)(iVar11 + 0x58) + uVar1 * 8);
		        if (System_Collections_Generic_IEnumerator_ChatVisitorData__TypeInfo == *piVar10) {
		          puVar6 = (undefined4 *)(iVar11 + piVar10[1] * 8 + 0xc0);
		          goto code_r0x80e20b23;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar11 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar6 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_Generic_IEnumerator_ChatVisitorData__TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80e20c7b:
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e20c83;
		    }
		code_r0x80e20b23:
		    DAT_ram_009d3e38 = 0;
		    iVar7 = import::env::invoke_iii(*puVar6,piVar8,puVar6[1]);
		    iVar11 = Method_System_Collections_Generic_List_ChatVisitorData__Add__;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80e20c7b;
		    if ((*(byte *)(*(int *)(iVar7 + 0x14) + 0x14) & 2) == 0) {
		      *(int *)(iVar4 + 0x10) = *(int *)(iVar4 + 0x10) + 1;
		      uVar1 = *(uint *)(iVar4 + 0xc);
		      if (uVar1 < *(uint *)(*(int *)(iVar4 + 8) + 0xc)) {
		        *(uint *)(iVar4 + 0xc) = uVar1 + 1;
		        iVar11 = *(int *)(iVar4 + 8) + uVar1 * 4;
		code_r0x80e20f22:
		        *(int *)(iVar11 + 0x10) = iVar7;
		      }
		      else {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar4,iVar7,
		                   *(undefined4 *)(*(int *)(*(int *)(iVar11 + 0x10) + 0x60) + 0x38));
		        iVar11 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar11 == 1) {
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80e20c83;
		        }
		      }
		      goto code_r0x80e2098e;
		    }
		    *(int *)(iVar2 + 0x10) = *(int *)(iVar2 + 0x10) + 1;
		    uVar1 = *(uint *)(iVar2 + 0xc);
		    if (uVar1 < *(uint *)(*(int *)(iVar2 + 8) + 0xc)) {
		      *(uint *)(iVar2 + 0xc) = uVar1 + 1;
		      iVar11 = *(int *)(iVar2 + 8) + uVar1 * 4;
		      goto code_r0x80e20f22;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar2,iVar7,
		               *(undefined4 *)(*(int *)(*(int *)(iVar11 + 0x10) + 0x60) + 0x38));
		    iVar11 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar11 != 1);
		  uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80e20c83:
		  iVar11 = global_1;
		  iVar7 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar11 == iVar7) {
		    piVar8 = (int *)import::env::__cxa_begin_catch(uVar3);
		    local_c = *piVar8;
		    iVar11 = 0;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar7 != 1) {
		code_r0x80e20cd0:
		      DAT_ram_009d3e38 = 0;
		      piVar8 = *local_8;
		      if (piVar8 != (int *)0x0) {
		        uVar1 = 0;
		        iVar7 = *piVar8;
		        if (*(ushort *)(iVar7 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		              puVar5 = (uint *)(iVar7 + *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x80e20d4b;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		        }
		        puVar5 = (uint *)func_ii_1080(piVar8,System_IDisposable_TypeInfo,0);
		code_r0x80e20d4b:
		        (**(code **)((ulonglong)*puVar5 * 4))(piVar8,puVar5[1]);
		      }
		      if (local_c == 0) {
		        if ((iVar11 == 0) ||
		           ((((uVar3 = 0, iVar11 != 1 && (iVar11 != 2)) && (iVar11 != 3)) &&
		            (((iVar11 != 4 && (iVar11 != 5)) && (iVar11 == 6)))))) {
		          if (*(int *)(Gameplay_Chat_View_ChatView___c_TypeInfo + 0x74) == 0) {
		            func_ii_306000(Gameplay_Chat_View_ChatView___c_TypeInfo);
		          }
		          puVar6 = *(undefined4 **)(Gameplay_Chat_View_ChatView___c_TypeInfo + 0x5c);
		          iVar11 = puVar6[1];
		          if (iVar11 == 0) {
		            if (*(int *)(Gameplay_Chat_View_ChatView___c_TypeInfo + 0x74) == 0) {
		              func_ii_306000(Gameplay_Chat_View_ChatView___c_TypeInfo);
		              puVar6 = *(undefined4 **)(Gameplay_Chat_View_ChatView___c_TypeInfo + 0x5c);
		            }
		            uVar3 = *puVar6;
		            iVar11 = unnamed_function_1417(System_Func_ChatVisitorData__ChatVisitorData__TypeInfo);
		            System_Linq_Enumerable__Where_object_
		                      (iVar11,uVar3,
		                       Method_Gameplay_Chat_View_ChatView___c__PrepareVisitorForDisplay_b__45_1__,0)
		            ;
		            *(int *)(*(int *)(Gameplay_Chat_View_ChatView___c_TypeInfo + 0x5c) + 4) = iVar11;
		          }
		          uVar3 = func_ii_7521(iVar2,iVar11,*(undefined4 *)(*(int *)(param1 + 0x40) + 0x28),
		                               Method_Core_Extensions_IEnumerableExt_SortGameData_ChatVisitorData__ChatVisitorData___
		                              );
		          uVar3 = System_Linq_Enumerable__Select_object__object_
		                            (uVar3,Method_System_Linq_Enumerable_ToList_ChatVisitorData___);
		          if (*(int *)(Gameplay_Chat_View_ChatView___c_TypeInfo + 0x74) == 0) {
		            func_ii_306000(Gameplay_Chat_View_ChatView___c_TypeInfo);
		          }
		          puVar6 = *(undefined4 **)(Gameplay_Chat_View_ChatView___c_TypeInfo + 0x5c);
		          iVar2 = puVar6[2];
		          if (iVar2 == 0) {
		            if (*(int *)(Gameplay_Chat_View_ChatView___c_TypeInfo + 0x74) == 0) {
		              func_ii_306000(Gameplay_Chat_View_ChatView___c_TypeInfo);
		              puVar6 = *(undefined4 **)(Gameplay_Chat_View_ChatView___c_TypeInfo + 0x5c);
		            }
		            uVar9 = *puVar6;
		            iVar2 = unnamed_function_1417(System_Func_ChatVisitorData__ChatVisitorData__TypeInfo);
		            System_Linq_Enumerable__Where_object_
		                      (iVar2,uVar9,
		                       Method_Gameplay_Chat_View_ChatView___c__PrepareVisitorForDisplay_b__45_2__,0)
		            ;
		            *(int *)(*(int *)(Gameplay_Chat_View_ChatView___c_TypeInfo + 0x5c) + 8) = iVar2;
		          }
		          uVar9 = func_ii_7521(iVar4,iVar2,*(undefined4 *)(*(int *)(param1 + 0x40) + 0x28),
		                               Method_Core_Extensions_IEnumerableExt_SortGameData_ChatVisitorData__ChatVisitorData___
		                              );
		          func_ii_6335(uVar3,uVar9,
		                       Method_System_Collections_Generic_List_ChatVisitorData__AddRange__);
		          uVar3 = UnityEngine_TextCore_Text_FontAsset__UpdateFontFeaturesForNewlyAddedGlyphs
		                            (uVar3,Method_System_Collections_Generic_List_ChatVisitorData__ToArray__
		                            );
		        }
		        return uVar3;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(local_c);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar3 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x1f,&local_c);
		  iVar2 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar2 == 1) {
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__resumeException(uVar3);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x0600436F RID: 17263 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600436F")]
		[Address(RVA = "0x9223", Offset = "0x9223", VA = "0x9223")]
		public ChatVisitorData[] PrepareVisitorForDisplay(IEnumerable<ChatVisitorData> visitors)
		{
			return null;
		}

		// Token: 0x06004370 RID: 17264 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004370")]
		[Address(RVA = "0x9224", Offset = "0x9224", VA = "0x9224")]
		private void HandleVisitorsSortTriggered(IGameDataComparer<ChatVisitorData> comparer)
		{
		/* --- GHIDRA: HandleVisitorsSortTriggered ---
		void Gameplay_Chat_View_ChatView__HandleVisitorsSortTriggered(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param1 + 0x84);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004371 RID: 17265 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004371")]
		[Address(RVA = "0x9225", Offset = "0x9225", VA = "0x9225")]
		private void HandleSendMessageButtonClickEvent()
		{
		/* --- GHIDRA: HandleSendMessageButtonClickEvent ---
		void Gameplay_Chat_View_ChatView__HandleSendMessageButtonClickEvent
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined8 local_40;
		  undefined8 local_38;
		  undefined8 local_30;
		  undefined8 local_28;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a57ae3 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_Image___);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_SetDelay_TweenerCore_Color__Color__ColorOptions____
		              );
		    DAT_ram_00a57ae3 = '\x01';
		  }
		  if (param2 == 0) {
		    uVar1 = func_ii_5677(*(undefined4 *)(*(int *)(param1 + 0x34) + 0x10),
		                         Method_UnityEngine_Component_GetComponent_Image___);
		    local_8 = 0x3f80000000000000;
		    local_28 = 0x3f80000000000000;
		    local_10 = 0x3f800000;
		    local_30 = 0x3f800000;
		    DG_Tweening_DOTweenModuleSprite___c__DisplayClass3_0___DOBlendableColor_b__1
		              (uVar1,&local_30,0.0,0);
		    uVar1 = func_ii_5677(*(undefined4 *)(*(int *)(param1 + 0x34) + 0x10),
		                         Method_UnityEngine_Component_GetComponent_Image___);
		    local_18 = 0x3f8000003f800000;
		    local_38 = 0x3f8000003f800000;
		    local_20 = 0x3f8000003f800000;
		    local_40 = 0x3f8000003f800000;
		    uVar1 = DG_Tweening_DOTweenModuleSprite___c__DisplayClass3_0___DOBlendableColor_b__1
		                      (uVar1,&local_40,0.5,0);
		    DG_Tweening_DOTweenModuleUI__DOFade
		              (uVar1,0.5,
		               Method_DG_Tweening_TweenSettingsExtensions_SetDelay_TweenerCore_Color__Color__ColorOptions____
		              );
		    Gameplay_UserInfo_View_PatternTextInput__get_Status(*(undefined4 *)(param1 + 0x34),1,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004372 RID: 17266 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004372")]
		[Address(RVA = "0x9226", Offset = "0x9226", VA = "0x9226")]
		private void HandleMessageTextInputStatusChangedEvent(bool status)
		{
		/* --- GHIDRA: HandleMessageTextInputStatusChangedEvent ---
		int Gameplay_Chat_View_ChatView__HandleMessageTextInputStatusChangedEvent
		              (undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a57ae4 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Chat_View_ChatView__ScrollTpSpike_d__49_TypeInfo);
		    DAT_ram_00a57ae4 = '\x01';
		  }
		  iVar1 = unnamed_function_1417(Gameplay_Chat_View_ChatView__ScrollTpSpike_d__49_TypeInfo);
		  *(undefined4 *)(iVar1 + 0x10) = param1;
		  *(undefined4 *)(iVar1 + 8) = 0;
		  return iVar1;
		}
		*/

		}

		// Token: 0x06004373 RID: 17267 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004373")]
		[Address(RVA = "0x9227", Offset = "0x9227", VA = "0x9227")]
		private IEnumerator ScrollTpSpike()
		{
		/* --- GHIDRA: ScrollTpSpike ---
		void Gameplay_Chat_View_ChatView__ScrollTpSpike
		               (int param1,undefined4 param2,int param3,undefined4 param4)
		
		{
		  undefined4 param1_00;
		  undefined8 *puVar1;
		  undefined8 local_38;
		  undefined8 local_30;
		  undefined8 local_28;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a57ae5 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_RectTransform___);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_ChatViewStates__HandleCurrentStateChanged__);
		    DAT_ram_00a57ae5 = '\x01';
		  }
		  UI_MonoBehaviourWithStates_ByteEnum____ctor
		            (param1,param2,param3,
		             Method_UI_MonoBehaviourWithStates_ChatViewStates__HandleCurrentStateChanged__);
		  param1_00 = func_ii_5677(*(undefined4 *)(param1 + 0x44),
		                           Method_UnityEngine_Component_GetComponent_RectTransform___);
		  if (param3 == 2) {
		    local_30 = *(undefined8 *)(param1 + 0x70);
		    local_8 = local_30;
		    UnityEngine_RectTransform__get_sizeDelta(param1_00,&local_30,0);
		    local_10 = *(undefined8 *)(param1 + 100);
		    puVar1 = &local_10;
		  }
		  else {
		    local_28 = *(undefined8 *)(param1 + 0x58);
		    local_18 = local_28;
		    UnityEngine_RectTransform__get_sizeDelta(param1_00,&local_28,0);
		    local_20 = *(undefined8 *)(param1 + 0x4c);
		    puVar1 = &local_20;
		  }
		  local_38 = *puVar1;
		  UnityEngine_RectTransform__get_anchoredPosition(param1_00,&local_38,0);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06004374 RID: 17268 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004374")]
		[Address(RVA = "0x9228", Offset = "0x9228", VA = "0x9228", Slot = "4")]
		protected override void HandleCurrentStateChanged(ChatViewStates fromState, ChatViewStates toState)
		{
		/* --- GHIDRA: HandleCurrentStateChanged ---
		void Gameplay_Chat_View_ChatView__HandleCurrentStateChanged
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param2_00;
		  int *piVar1;
		  
		  *(undefined4 *)(param1 + 0x88) = param2;
		  piVar1 = *(int **)(param1 + 0x3c);
		  param2_00 = Gameplay_Chat_View_ChatView__HandleCurrentVisitorsSortComparerChanged
		                        (param1,param2,param1);
		  if (DAT_ram_00a57ad9 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_ChatVisitorData__ResetItems__
		              );
		    DAT_ram_00a57ad9 = '\x01';
		  }
		  (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x2e8) * 4))(piVar1,*(undefined4 *)(*piVar1 + 0x2ec));
		  Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_object___RemoveOneFromStart
		            (piVar1[0x28],param2_00,0,
		             Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_ChatVisitorData__ResetItems__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06004375 RID: 17269 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004375")]
		[Address(RVA = "0x9229", Offset = "0x9229", VA = "0x9229")]
		public void SetVisitors(List<ChatVisitorData> visitors)
		{
		/* --- GHIDRA: SetVisitors ---
		void Gameplay_Chat_View_ChatView__SetVisitors(int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param2_00;
		  int *piVar1;
		  
		  piVar1 = *(int **)(param1 + 0x3c);
		  param2_00 = Gameplay_Chat_View_ChatView__HandleCurrentVisitorsSortComparerChanged
		                        (param1,*(undefined4 *)(param1 + 0x88),param1);
		  if (DAT_ram_00a57ad9 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_ChatVisitorData__ResetItems__
		              );
		    DAT_ram_00a57ad9 = '\x01';
		  }
		  (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x2e8) * 4))(piVar1,*(undefined4 *)(*piVar1 + 0x2ec));
		  Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_object___RemoveOneFromStart
		            (piVar1[0x28],param2_00,0,
		             Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_ChatVisitorData__ResetItems__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06004376 RID: 17270 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004376")]
		[Address(RVA = "0x922A", Offset = "0x922A", VA = "0x922A")]
		public void AddVisitor(ChatVisitorData visitor)
		{
		/* --- GHIDRA: AddVisitor ---
		void Gameplay_Chat_View_ChatView__AddVisitor(int param1,int param2,undefined4 param3)
		
		{
		  int param2_00;
		  int iVar1;
		  int iVar2;
		  
		  param2_00 = 0;
		  if (DAT_ram_00a57ae6 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_ChatVisitorData__RemoveItems__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_ChatVisitorData__get_Count__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_ChatVisitorData__get_Item__
		              );
		    DAT_ram_00a57ae6 = '\x01';
		  }
		  iVar1 = UnityEngine_AndroidJavaObject___GetRawObject
		                    (*(undefined4 *)(*(int *)(param1 + 0x3c) + 0xa0),
		                     Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_ChatVisitorData__get_Count__
		                    );
		  if (0 < iVar1) {
		    do {
		      iVar2 = Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_object___System_Collections_IEnumerable_GetEnumerator
		                        (*(undefined4 *)(*(int *)(param1 + 0x3c) + 0xa0),param2_00,
		                         Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_ChatVisitorData__get_Item__
		                        );
		      if (iVar2 == param2) {
		        Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_object___NotifyListChangedExternally
		                  (*(undefined4 *)(*(int *)(param1 + 0x3c) + 0xa0),param2_00,1,0,
		                   Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_ChatVisitorData__RemoveItems__
		                  );
		        return;
		      }
		      param2_00 = param2_00 + 1;
		    } while (param2_00 != iVar1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004377 RID: 17271 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004377")]
		[Address(RVA = "0x922B", Offset = "0x922B", VA = "0x922B")]
		public void RemoveVisitor(ChatVisitorData visitor)
		{
		/* --- GHIDRA: RemoveVisitor ---
		void Gameplay_Chat_View_ChatView__RemoveVisitor(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = func_ii_12174(*(undefined4 *)(param1 + 0x44),0);
		  if (iVar1 != 0) {
		    if (DAT_ram_00a57ae4 == '\0') {
		      Mono_Security_ASN1__get_Item(&Gameplay_Chat_View_ChatView__ScrollTpSpike_d__49_TypeInfo);
		      DAT_ram_00a57ae4 = '\x01';
		    }
		    iVar1 = unnamed_function_1417(Gameplay_Chat_View_ChatView__ScrollTpSpike_d__49_TypeInfo);
		    *(int *)(iVar1 + 0x10) = param1;
		    *(undefined4 *)(iVar1 + 8) = 0;
		    Utils_CoroutineSource__GetMono(iVar1,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004378 RID: 17272 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004378")]
		[Address(RVA = "0x922C", Offset = "0x922C", VA = "0x922C")]
		public void ScrollMessagesDown()
		{
		/* --- GHIDRA: ScrollMessagesDown ---
		void Gameplay_Chat_View_ChatView__ScrollMessagesDown(int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x34),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,(uint)(param2 == 0),0);
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x7c),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,(uint)(param2 != 0),0);
		  iVar2 = *(int *)(param1 + 0x7c);
		  if ((*(int *)(iVar2 + 0x18) != param2) && (*(int *)(iVar2 + 0x18) = param2, param2 != 0)) {
		    UI_Elements_RightPanel_TitleWithLevel__set_Level
		              (*(undefined4 *)(iVar2 + 0x10),*(undefined4 *)(param2 + 0x10),0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004379 RID: 17273 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004379")]
		[Address(RVA = "0x922D", Offset = "0x922D", VA = "0x922D")]
		public void SetBan(ChatBanData banData)
		{
		/* --- GHIDRA: SetBan ---
		void Gameplay_Chat_View_ChatView__SetBan(int param1,undefined4 param2)
		
		{
		  int *piVar1;
		  int iVar2;
		  
		  piVar1 = *(int **)(*(int *)(param1 + 0x34) + 0x10);
		  iVar2 = *piVar1;
		  (**(code **)((ulonglong)*(uint *)(iVar2 + 0x1f0) * 4))(piVar1,*(undefined4 *)(iVar2 + 500));
		  TMPro_TMP_InputField__Validate(*(undefined4 *)(*(int *)(param1 + 0x34) + 0x10),0);
		  return;
		}
		*/

		}

		// Token: 0x0600437A RID: 17274 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600437A")]
		[Address(RVA = "0x922E", Offset = "0x922E", VA = "0x922E")]
		public void SetFocusOnTextInputField()
		{
		/* --- GHIDRA: SetFocusOnTextInputField ---
		void Gameplay_Chat_View_ChatView__SetFocusOnTextInputField(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a57ae7 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_SmilesViewStates__set_CurrentState__);
		    DAT_ram_00a57ae7 = '\x01';
		  }
		  UI_SelectedButton__get_Selected(*(undefined4 *)(param1 + 0x28),1,0);
		  param1_00 = *(undefined4 *)(param1 + 0x48);
		  UI_MonoBehaviourWithStates_ByteEnum___remove_CurrentStateChangedEvent
		            (param1_00,0xff,Method_UI_MonoBehaviourWithStates_SmilesViewStates__set_CurrentState__);
		  UI_MonoBehaviourWithStates_ByteEnum___remove_CurrentStateChangedEvent
		            (param1_00,0xff,Method_UI_MonoBehaviourWithStates_SmilesViewStates__set_CurrentState__);
		  return;
		}
		*/

		}

		// Token: 0x0600437B RID: 17275 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600437B")]
		[Address(RVA = "0x922F", Offset = "0x922F", VA = "0x922F")]
		public void ShowSmilePanel()
		{
		/* --- GHIDRA: ShowSmilePanel ---
		void Gameplay_Chat_View_ChatView__ShowSmilePanel(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a57ae8 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_SmilesViewStates__set_CurrentState__);
		    DAT_ram_00a57ae8 = '\x01';
		  }
		  UI_SelectedButton__get_Selected(*(undefined4 *)(param1 + 0x28),0,0);
		  param1_00 = *(undefined4 *)(param1 + 0x48);
		  UI_MonoBehaviourWithStates_ByteEnum___remove_CurrentStateChangedEvent
		            (param1_00,0,Method_UI_MonoBehaviourWithStates_SmilesViewStates__set_CurrentState__);
		  UI_MonoBehaviourWithStates_ByteEnum___remove_CurrentStateChangedEvent
		            (param1_00,0,Method_UI_MonoBehaviourWithStates_SmilesViewStates__set_CurrentState__);
		  return;
		}
		*/

		}

		// Token: 0x0600437C RID: 17276 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600437C")]
		[Address(RVA = "0x9230", Offset = "0x9230", VA = "0x9230")]
		public void CloseSmilePanel()
		{
		/* --- GHIDRA: CloseSmilePanel ---
		void Gameplay_Chat_View_ChatView__CloseSmilePanel(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57ae9 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_MonoBehaviourWithStates_ChatViewStates___ctor__);
		    DAT_ram_00a57ae9 = '\x01';
		  }
		  ScreenAdaptation_Common_AppSize__Update
		            (param1,Method_UI_MonoBehaviourWithStates_ChatViewStates___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x0600437D RID: 17277 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600437D")]
		[Address(RVA = "0x9231", Offset = "0x9231", VA = "0x9231")]
		public ChatView()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Chat_View_ChatView___ctor(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a57aea == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Chat_View_ChatView___c_TypeInfo);
		    DAT_ram_00a57aea = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Gameplay_Chat_View_ChatView___c_TypeInfo);
		  **(undefined4 **)(Gameplay_Chat_View_ChatView___c_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x0400251D RID: 9501
		[Token(Token = "0x400251D")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private TabBar _roomsTabBar;

		// Token: 0x0400251E RID: 9502
		[Token(Token = "0x400251E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Button _sendMessageButton;

		// Token: 0x0400251F RID: 9503
		[Token(Token = "0x400251F")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private SelectedButton _privateMessagesButton;

		// Token: 0x04002520 RID: 9504
		[Token(Token = "0x4002520")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SelectedButton _smilesButton;

		// Token: 0x04002521 RID: 9505
		[Token(Token = "0x4002521")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private SelectedButton _roomVisitorsOrContactsButton;

		// Token: 0x04002522 RID: 9506
		[Token(Token = "0x4002522")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private SelectedButton _miniChatViewSwitchButton;

		// Token: 0x04002523 RID: 9507
		[Token(Token = "0x4002523")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private PatternTextInput _messageTextInput;

		// Token: 0x04002524 RID: 9508
		[Token(Token = "0x4002524")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private TMP_InputField _roomVisitorsSearchInputField;

		// Token: 0x04002525 RID: 9509
		[Token(Token = "0x4002525")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private ChatRoomVisitorsListAdapter _visitorsList;

		// Token: 0x04002526 RID: 9510
		[Token(Token = "0x4002526")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private ChatVisitorsSort _visitorsSortControl;

		// Token: 0x04002527 RID: 9511
		[Token(Token = "0x4002527")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private MessagesListAdapter _messagesList;

		// Token: 0x04002528 RID: 9512
		[Token(Token = "0x4002528")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private SmilesView _smilesView;

		// Token: 0x04002529 RID: 9513
		[Token(Token = "0x4002529")]
		[FieldOffset(Offset = "0x4C")]
		[Space(50f)]
		[SerializeField]
		private Vector3 _defaultMessagesLisPosition;

		// Token: 0x0400252A RID: 9514
		[Token(Token = "0x400252A")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Vector3 _defaultMessagesLisSize;

		// Token: 0x0400252B RID: 9515
		[Token(Token = "0x400252B")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		private Vector3 _complaintsStateMessagesListPosition;

		// Token: 0x0400252C RID: 9516
		[Token(Token = "0x400252C")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Vector3 _complaintsStateMessagesListSize;

		// Token: 0x0400252D RID: 9517
		[Token(Token = "0x400252D")]
		[FieldOffset(Offset = "0x7C")]
		[SerializeField]
		private BanStub _banStub;

		// Token: 0x0400252E RID: 9518
		[Token(Token = "0x400252E")]
		[FieldOffset(Offset = "0x80")]
		private ChatViewMediator _mediator;

		// Token: 0x04002530 RID: 9520
		[Token(Token = "0x4002530")]
		private const int MIN_CHAR_COUNT_FOR_VISITOR_SEARCH = 1;

		// Token: 0x04002531 RID: 9521
		[Token(Token = "0x4002531")]
		[FieldOffset(Offset = "0x88")]
		private IList<ChatVisitorData> _visitors;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_SmilesView ---
		void Gameplay_Chat_View_ChatView__get_SmilesView(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a57adc == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a57adc = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x84);
		  while ((param1_01 = (int *)UnityEngine_UI_Image__set_sprite(param1_00,param2,0),
		         param1_01 == (int *)0x0 || (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x84,param1_01,param1_00);
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


		/* --- GHIDRA: add_SendMessageEvent ---
		void Gameplay_Chat_View_ChatView__add_SendMessageEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a57add == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a57add = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x84);
		  while ((param1_01 = (int *)func_ii_7048(param1_00,param2,0), param1_01 == (int *)0x0 ||
		         (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x84,param1_01,param1_00);
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


		/* --- GHIDRA: remove_SendMessageEvent ---
		void Gameplay_Chat_View_ChatView__remove_SendMessageEvent(int param1,undefined4 param2)
		
		{
		  bool bVar1;
		  int param1_00;
		  int iVar2;
		  undefined4 uVar3;
		  int param1_01;
		  undefined4 uVar4;
		  int iVar5;
		  
		  if (DAT_ram_00a57ade == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Sorting_AbstractSortControlView_ChatVisitorData__remove_ComparerChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ChatSmileDic__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_IGameDataComparer_ChatVisitorData___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_Chat_View_ChatView_HandleMessageInputSubmit__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Chat_View_ChatView_HandleMessageTextInputStatusChangedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Chat_View_ChatView_HandleSendMessageButtonClickEvent__);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_Chat_View_ChatView_HandleSmilesButtonClickEvent__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Chat_View_ChatView_HandleSmilesViewItemSelectedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Chat_View_ChatView_HandleVisitorsSearchFieldOnValueChanged__);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_Chat_View_ChatView_HandleVisitorsSortTriggered__);
		    Mono_Security_ASN1__get_Item(&System_EventHandler_PointerEventData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Events_UnityEvent_string__RemoveListener__);
		    DAT_ram_00a57ade = '\x01';
		  }
		  uVar4 = *(undefined4 *)(*(int *)(*(int *)(param1 + 0x34) + 0x10) + 0x11c);
		  uVar3 = unnamed_function_1417(UnityEngine_Events_UnityAction_string__TypeInfo);
		  func_ii_7054(uVar3,param1,Method_Gameplay_Chat_View_ChatView_HandleMessageInputSubmit__,0);
		  UnityEngine_Events_UnityEvent_InputAction_CallbackContext___Invoke
		            (uVar4,uVar3,Method_UnityEngine_Events_UnityEvent_string__RemoveListener__);
		  uVar4 = *(undefined4 *)(*(int *)(param1 + 0x38) + 0x130);
		  uVar3 = unnamed_function_1417(UnityEngine_Events_UnityAction_string__TypeInfo);
		  func_ii_7054(uVar3,param1,
		               Method_Gameplay_Chat_View_ChatView_HandleVisitorsSearchFieldOnValueChanged__,0);
		  UnityEngine_Events_UnityEvent_InputAction_CallbackContext___Invoke
		            (uVar4,uVar3,Method_UnityEngine_Events_UnityEvent_string__RemoveListener__);
		  uVar4 = *(undefined4 *)(*(int *)(param1 + 0x20) + 0xb4);
		  uVar3 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar3,param1,Method_Gameplay_Chat_View_ChatView_HandleSendMessageButtonClickEvent__,0);
		  UnityEngine_Events_UnityAction___ctor(uVar4,uVar3,0);
		  uVar4 = *(undefined4 *)(param1 + 0x34);
		  uVar3 = unnamed_function_1417(System_Action_bool__TypeInfo);
		  System_Action_AsyncGPUReadbackRequest___Invoke
		            (uVar3,param1,
		             Method_Gameplay_Chat_View_ChatView_HandleMessageTextInputStatusChangedEvent__,0);
		  Gameplay_UserInfo_View_PatternTextInput__add_OnStatusChanged(uVar4,uVar3,0);
		  uVar4 = *(undefined4 *)(param1 + 0x40);
		  uVar3 = unnamed_function_1417(System_Action_IGameDataComparer_ChatVisitorData___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar3,param1,Method_Gameplay_Chat_View_ChatView_HandleVisitorsSortTriggered__,0);
		  UI_Sorting_AbstractSortControlView___Il2CppFullySharedGenericType___get_SelectedFilter
		            (uVar4,uVar3,
		             Method_UI_Sorting_AbstractSortControlView_ChatVisitorData__remove_ComparerChangedEvent__
		            );
		  uVar4 = *(undefined4 *)(param1 + 0x28);
		  uVar3 = unnamed_function_1417(System_EventHandler_PointerEventData__TypeInfo);
		  UnityEngine_Object__Instantiate_object_
		            (uVar3,param1,Method_Gameplay_Chat_View_ChatView_HandleSmilesButtonClickEvent__,0);
		  UI_SelectedButton__add_ClickEvent(uVar4,uVar3,0);
		  iVar5 = *(int *)(param1 + 0x48);
		  uVar3 = unnamed_function_1417(System_Action_ChatSmileDic__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar3,param1,Method_Gameplay_Chat_View_ChatView_HandleSmilesViewItemSelectedEvent__,0);
		  if (DAT_ram_00a57aff == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ChatSmileDic__TypeInfo);
		    DAT_ram_00a57aff = '\x01';
		  }
		  param1_00 = *(int *)(iVar5 + 0x34);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,uVar3,0);
		    uVar4 = System_Action_ChatSmileDic__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ChatSmileDic__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(iVar5 + 0x34,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      iVar5 = **(int **)(param1 + 0x80);
		      (**(code **)((ulonglong)*(uint *)(iVar5 + 0x130) * 4))
		                (*(int **)(param1 + 0x80),*(undefined4 *)(iVar5 + 0x134));
		      *(undefined4 *)(param1 + 0x88) = 0;
		      *(undefined4 *)(param1 + 0x80) = 0;
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,uVar4);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

}
