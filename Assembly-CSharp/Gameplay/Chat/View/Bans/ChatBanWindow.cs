using System;
using System.Collections.Generic;
using Gameplay.Chat.Control;
using Gameplay.Chat.Model.Data;
using Il2CppDummyDll;
using TMPro;
using UI.Windows;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Chat.View.Bans
{
	// Token: 0x02000B03 RID: 2819
	[Token(Token = "0x2000B03")]
	public class ChatBanWindow : ClosableBaseWindow<ChatBanWindow.ChatBanWindowArgs>
	{
		// Token: 0x17000D66 RID: 3430
		// (get) Token: 0x06004412 RID: 17426 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000D66")]
		public override string WindowId
		{
			[Token(Token = "0x6004412")]
			[Address(RVA = "0x92C5", Offset = "0x92C5", VA = "0x92C5", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x06004413 RID: 17427 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004413")]
		[Address(RVA = "0x92C6", Offset = "0x92C6", VA = "0x92C6", Slot = "19")]
		protected override void OnClose()
		{
		/* --- GHIDRA: OnClose ---
		void Gameplay_Chat_View_Bans_ChatBanWindow__OnClose(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int iVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int param1_01;
		  undefined4 uVar5;
		  int *piVar6;
		  
		  if (DAT_ram_00a57b34 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_BaseWindow_ChatBanWindow_ChatBanWindowArgs__OnShow__);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_BaseWindow_ChatBanWindow_ChatBanWindowArgs__get_WindowArgs__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Chat_View_Bans_ChatBanWindow_HandleConfirmButtonClickEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Chat_View_Bans_ChatBanWindow_HandleSelectedEvent__);
		    Mono_Security_ASN1__get_Item(&System_EventHandler_ChatBanArticleData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a57b34 = '\x01';
		  }
		  UI_Windows_BaseWindow_object____ctor
		            (param1,param2,Method_UI_Windows_BaseWindow_ChatBanWindow_ChatBanWindowArgs__OnShow__);
		  uVar5 = *(undefined4 *)(*(int *)(param1 + 0x44) + 0xb4);
		  uVar3 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar3,param1,
		             Method_Gameplay_Chat_View_Bans_ChatBanWindow_HandleConfirmButtonClickEvent__,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar5,uVar3,0);
		  piVar6 = *(int **)(param1 + 0x48);
		  iVar4 = func_ii_8093(param1,
		                       Method_UI_Windows_BaseWindow_ChatBanWindow_ChatBanWindowArgs__get_WindowArgs__
		                      );
		  uVar3 = *(undefined4 *)(iVar4 + 0x1c);
		  if (DAT_ram_00a57b2f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_ChatBanArticleData__ResetItems__
		              );
		    DAT_ram_00a57b2f = '\x01';
		  }
		  (**(code **)((ulonglong)*(uint *)(*piVar6 + 0x2e8) * 4))(piVar6,*(undefined4 *)(*piVar6 + 0x2ec));
		  Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_object___RemoveOneFromStart
		            (piVar6[0x29],uVar3,0,
		             Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_ChatBanArticleData__ResetItems__
		            );
		  iVar4 = *(int *)(param1 + 0x48);
		  uVar3 = unnamed_function_1417(System_EventHandler_ChatBanArticleData__TypeInfo);
		  UnityEngine_Object__Instantiate_object_
		            (uVar3,param1,Method_Gameplay_Chat_View_Bans_ChatBanWindow_HandleSelectedEvent__,0);
		  if (DAT_ram_00a57b28 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_EventHandler_ChatBanArticleData__TypeInfo);
		    DAT_ram_00a57b28 = '\x01';
		  }
		  param1_00 = *(int *)(iVar4 + 0xa0);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,uVar3,0);
		    uVar5 = System_EventHandler_ChatBanArticleData__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_EventHandler_ChatBanArticleData__TypeInfo), iVar2 == 0
		       )) break;
		    iVar2 = func_ii_4329(iVar4 + 0xa0,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      Gameplay_Chat_View_Bans_ChatBanWindow__HandleConfirmButtonClickEvent(param1,iVar2,0,iVar2);
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,uVar5);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06004414 RID: 17428 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004414")]
		[Address(RVA = "0x92C7", Offset = "0x92C7", VA = "0x92C7", Slot = "18")]
		protected override void OnShow(BaseWindowArgs args)
		{
		/* --- GHIDRA: OnShow ---
		void Gameplay_Chat_View_Bans_ChatBanWindow__OnShow(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a57b35 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_BaseWindow_ChatBanWindow_ChatBanWindowArgs__get_WindowArgs__);
		    DAT_ram_00a57b35 = '\x01';
		  }
		  iVar1 = func_ii_8093(param1,
		                       Method_UI_Windows_BaseWindow_ChatBanWindow_ChatBanWindowArgs__get_WindowArgs__
		                      );
		  param1_00 = *(undefined4 *)(iVar1 + 0x20);
		  iVar1 = func_ii_8093(param1,
		                       Method_UI_Windows_BaseWindow_ChatBanWindow_ChatBanWindowArgs__get_WindowArgs__
		                      );
		  Gameplay_Chat_Control_ChatController__RequestProcessComplaint
		            (param1_00,
		             *(undefined8 *)(*(int *)(*(int *)(*(int *)(iVar1 + 0x18) + 0x14) + 0xc) + 0x10),
		             *(undefined4 *)(*(int *)(*(int *)(*(int *)(param1 + 0x48) + 0xa8) + 8) + 0xc),param1);
		  System_ComponentModel_BindingList___Il2CppFullySharedGenericType___OnAddingNew(param1,2,0);
		  return;
		}
		*/

		}

		// Token: 0x06004415 RID: 17429 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004415")]
		[Address(RVA = "0x92C8", Offset = "0x92C8", VA = "0x92C8")]
		private void HandleConfirmButtonClickEvent()
		{
		/* --- GHIDRA: HandleConfirmButtonClickEvent ---
		void Gameplay_Chat_View_Bans_ChatBanWindow__HandleConfirmButtonClickEvent
		               (int param1,undefined4 param2,int param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int iVar3;
		  undefined4 uVar4;
		  float fVar5;
		  undefined4 param3_00;
		  int *piVar6;
		  undefined8 param1_00;
		  double param1_01;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a57b36 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_BaseWindow_ChatBanWindow_ChatBanWindowArgs__get_WindowArgs__);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_KeyValuePair_string__string____TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22759);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25589);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4170);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19940);
		    DAT_ram_00a57b36 = '\x01';
		  }
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x40),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,(uint)(param3 != 0),0);
		  if (param3 != 0) {
		    piVar6 = *(int **)(param1 + 0x3c);
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar1 = func_ii_7508(StringLiteral_4170,1,0,1,0,0,0,0);
		    iVar2 = Mono_Security_ASN1Convert__ToOid
		                      (System_Collections_Generic_KeyValuePair_string__string____TypeInfo,3);
		    iVar3 = func_ii_8093(param1,
		                         Method_UI_Windows_BaseWindow_ChatBanWindow_ChatBanWindowArgs__get_WindowArgs__
		                        );
		    local_8 = 0;
		    System_Text_Formatting_StringView__get_IsEmpty
		              (&local_8,StringLiteral_25589,
		               *(undefined4 *)(*(int *)(*(int *)(*(int *)(iVar3 + 0x18) + 0x14) + 0xc) + 0x18),
		               Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		    *(undefined8 *)(iVar2 + 0x10) = local_8;
		    uVar4 = Core_Extensions_Dict_BossCategoryDicExt__GetTitle(*(undefined4 *)(param3 + 8),0);
		    local_10 = 0;
		    System_Text_Formatting_StringView__get_IsEmpty
		              (&local_10,StringLiteral_19940,uVar4,
		               Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		    *(undefined8 *)(iVar2 + 0x18) = local_10;
		    param1_00 = *(undefined8 *)(*(int *)(param3 + 8) + 0x10);
		    if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Utils_TimeUtils_TypeInfo);
		    }
		    fVar5 = Utils_StringUtils___cctor(param1_00,0);
		    param1_01 = (double)fVar5;
		    param3_00 = Utils_TimeUtils__DateFormat(param1_01,0);
		    local_18 = 0;
		    uVar4 = (undefined4)((ulonglong)param1_01 >> 0x20);
		    System_Text_Formatting_StringView__get_IsEmpty
		              (&local_18,StringLiteral_22759,param3_00,
		               Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		    *(undefined8 *)(iVar2 + 0x20) = local_18;
		    uVar1 = Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsRewardsTab_ClanWarsRewardsView__GetPlacesText
		                      (uVar1,iVar2,0);
		    iVar2 = *piVar6;
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0x2d0) * 4))
		              (CONCAT44(uVar4,piVar6),uVar1,*(undefined4 *)(iVar2 + 0x2d4));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004416 RID: 17430 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004416")]
		[Address(RVA = "0x92C9", Offset = "0x92C9", VA = "0x92C9")]
		private void HandleSelectedEvent(object sender, ChatBanArticleData e)
		{
		/* --- GHIDRA: HandleSelectedEvent ---
		void Gameplay_Chat_View_Bans_ChatBanWindow__HandleSelectedEvent(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57b37 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_ClosableBaseWindow_ChatBanWindow_ChatBanWindowArgs___ctor__);
		    DAT_ram_00a57b37 = '\x01';
		  }
		  UI_MonoBehaviourWithStates_ClientStateChangedDelegate___Il2CppFullySharedGenericStructType___Invoke
		            (param1,Method_UI_Windows_ClosableBaseWindow_ChatBanWindow_ChatBanWindowArgs___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x06004417 RID: 17431 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004417")]
		[Address(RVA = "0x92CA", Offset = "0x92CA", VA = "0x92CA")]
		public ChatBanWindow()
		{
		}

		// Token: 0x0400257D RID: 9597
		[Token(Token = "0x400257D")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Chat/ChatBanWindow";

		// Token: 0x0400257E RID: 9598
		[Token(Token = "0x400257E")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private TextMeshProUGUI _description;

		// Token: 0x0400257F RID: 9599
		[Token(Token = "0x400257F")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Transform _descriptionContainer;

		// Token: 0x04002580 RID: 9600
		[Token(Token = "0x4002580")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private Button _confirmButton;

		// Token: 0x04002581 RID: 9601
		[Token(Token = "0x4002581")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private ChatBanListAdapter _list;

		// Token: 0x02000B04 RID: 2820
		[Token(Token = "0x2000B04")]
		public class ChatBanWindowArgs : BaseWindowArgs
		{
			// Token: 0x06004418 RID: 17432 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004418")]
			[Address(RVA = "0x92CB", Offset = "0x92CB", VA = "0x92CB")]
			public ChatBanWindowArgs()
			{
			}

			// Token: 0x04002582 RID: 9602
			[Token(Token = "0x4002582")]
			[FieldOffset(Offset = "0x18")]
			public ChatVisitorData Visitor;

			// Token: 0x04002583 RID: 9603
			[Token(Token = "0x4002583")]
			[FieldOffset(Offset = "0x1C")]
			public IList<ChatBanArticleData> BanArtles;

			// Token: 0x04002584 RID: 9604
			[Token(Token = "0x4002584")]
			[FieldOffset(Offset = "0x20")]
			public ChatController ChatController;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_WindowId ---
		void Gameplay_Chat_View_Bans_ChatBanWindow__get_WindowId(int param1,undefined4 param2)
		
		{
		  bool bVar1;
		  int param1_00;
		  int iVar2;
		  undefined4 uVar3;
		  int param1_01;
		  int iVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a57b33 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Chat_View_Bans_ChatBanWindow_HandleConfirmButtonClickEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Chat_View_Bans_ChatBanWindow_HandleSelectedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_ClosableBaseWindow_ChatBanWindow_ChatBanWindowArgs__OnClose__);
		    Mono_Security_ASN1__get_Item(&System_EventHandler_ChatBanArticleData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a57b33 = '\x01';
		  }
		  UI_Windows_ClosableBaseWindow_object___OnClickBack
		            (param1,Method_UI_Windows_ClosableBaseWindow_ChatBanWindow_ChatBanWindowArgs__OnClose__)
		  ;
		  iVar4 = *(int *)(param1 + 0x48);
		  uVar3 = unnamed_function_1417(System_EventHandler_ChatBanArticleData__TypeInfo);
		  UnityEngine_Object__Instantiate_object_
		            (uVar3,param1,Method_Gameplay_Chat_View_Bans_ChatBanWindow_HandleSelectedEvent__,0);
		  if (DAT_ram_00a57b29 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_EventHandler_ChatBanArticleData__TypeInfo);
		    DAT_ram_00a57b29 = '\x01';
		  }
		  param1_00 = *(int *)(iVar4 + 0xa0);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,uVar3,0);
		    uVar5 = System_EventHandler_ChatBanArticleData__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_EventHandler_ChatBanArticleData__TypeInfo), iVar2 == 0
		       )) break;
		    iVar2 = func_ii_4329(iVar4 + 0xa0,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      uVar5 = *(undefined4 *)(*(int *)(param1 + 0x44) + 0xb4);
		      uVar3 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		      Utils_ObjectUtils__IsNotNull
		                (uVar3,param1,
		                 Method_Gameplay_Chat_View_Bans_ChatBanWindow_HandleConfirmButtonClickEvent__,0);
		      UnityEngine_Events_UnityAction___ctor(uVar5,uVar3,0);
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,uVar5);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

}
