using System;
using Core.Data;
using Gameplay.Discounts.View;
using Il2CppDummyDll;
using UI.Windows;
using UnityEngine;

namespace Gameplay.Medals.View
{
	// Token: 0x020005F2 RID: 1522
	[Token(Token = "0x20005F2")]
	public class ConfirmBuyMedalWindow : BaseDialogWindow<ConfirmBuyMedalWindow.ConfirmBuyMedalWindowArgs>
	{
		// Token: 0x170006E0 RID: 1760
		// (get) Token: 0x060024E7 RID: 9447 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170006E0")]
		public override string WindowId
		{
			[Token(Token = "0x60024E7")]
			[Address(RVA = "0x7632", Offset = "0x7632", VA = "0x7632", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x060024E8 RID: 9448 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024E8")]
		[Address(RVA = "0x7633", Offset = "0x7633", VA = "0x7633", Slot = "28")]
		protected override void HandleContent()
		{
		/* --- GHIDRA: HandleContent ---
		undefined4
		Gameplay_Medals_View_ConfirmBuyMedalWindow__HandleContent
		          (int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  int param1_00;
		  undefined4 uVar3;
		  int iVar4;
		  int iVar5;
		  undefined4 uVar6;
		  undefined4 param3_00;
		  int iVar7;
		  uint *puVar8;
		  int *param1_01;
		  int iVar9;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a57d78 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_MedalDic__uint__get_Data__);
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_ConfirmBuyMedalWindow_ConfirmBuyMedalWindowArgs__MedalData__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ConfirmBuyMedalWindow_ConfirmBuyMedalWindowArgs__MedalData___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ConfirmBuyMedalWindow_ConfirmBuyMedalWindowArgs__MedalData__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Medals_View_ConfirmBuyMedalWindow_ConfirmBuyMedalWindowArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ConfirmBuyMedalWindow_ConfirmBuyMedalWindowArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ConfirmBuyMedalWindow_ConfirmBuyMedalWindowArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_KeyValuePair_string__string____TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ConfirmBuyMedalWindow_ConfirmBuyMedalWindowArgs___Add__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_PopupController_Show_ConfirmBuyMedalWindow___);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_PriceHolder_ConfirmBuyMedalWindow_ConfirmBuyMedalWindowArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_PriceHolder_ConfirmBuyMedalWindow_ConfirmBuyMedalWindowArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Medals_View_ConfirmBuyMedalWindow___c__DisplayClass7_0__Show_b__0__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Medals_View_ConfirmBuyMedalWindow___c__DisplayClass7_0_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12650);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2556);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26295);
		    Mono_Security_ASN1__get_Item(&StringLiteral_10728);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3708);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27734);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19733);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    DAT_ram_00a57d78 = '\x01';
		  }
		  iVar2 = unnamed_function_1417
		                    (Gameplay_Medals_View_ConfirmBuyMedalWindow___c__DisplayClass7_0_TypeInfo);
		  *(undefined4 *)(iVar2 + 8) = param2;
		  param1_00 = unnamed_function_1417
		                        (
		                        Gameplay_Medals_View_ConfirmBuyMedalWindow_ConfirmBuyMedalWindowArgs_TypeInfo
		                        );
		  Gameplay_Medals_View_ConfirmBuyMedalWindow___ctor(param1_00,param2);
		  *(int *)(param1_00 + 0x2c) = param1;
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar3 = func_ii_7508(StringLiteral_10728,1,0,1,0,0,0,0);
		  iVar4 = Mono_Security_ASN1Convert__ToOid
		                    (System_Collections_Generic_KeyValuePair_string__string____TypeInfo,3);
		  iVar5 = Core_Data_MedalData__get_CurrentMedal(param1,0);
		  uVar6 = func_ii_14054(*(undefined4 *)(iVar5 + 0x10),0);
		  local_10 = 0;
		  System_Text_Formatting_StringView__get_IsEmpty
		            (&local_10,StringLiteral_27734,uVar6,
		             Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		  *(undefined8 *)(iVar4 + 0x10) = local_10;
		  local_4 = *(undefined4 *)(param1 + 0x14);
		  iVar5 = Protocol_Combat_ProtoPlayerActionEvt___ctor(&local_4,0);
		  local_10 = 0;
		  if (iVar5 == 0) {
		    iVar5 = StringLiteral_5;
		  }
		  System_Text_Formatting_StringView__get_IsEmpty
		            (&local_10,StringLiteral_26295,iVar5,
		             Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		  *(undefined8 *)(iVar4 + 0x18) = local_10;
		  iVar5 = Core_Data_MedalData__get_CurrentMedal(param1,0);
		  uVar6 = 0x7ff80000;
		  param3_00 = Core_Extensions_Dict_ResourceSetExt__ToLocaleString
		                        (*(undefined4 *)(*(int *)(iVar5 + 0x10) + 0x24),NAN,0,StringLiteral_2556,0,0
		                         ,0);
		  local_18 = 0;
		  System_Text_Formatting_StringView__get_IsEmpty
		            (&local_18,StringLiteral_19733,param3_00,
		             Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		  *(undefined8 *)(iVar4 + 0x20) = local_18;
		  uVar3 = Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsRewardsTab_ClanWarsRewardsView__GetPlacesText
		                    (uVar3,iVar4,0);
		  *(undefined4 *)(param1_00 + 0x1c) = uVar3;
		  iVar4 = *(int *)(param1_00 + 0x24);
		  iVar5 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ConfirmBuyMedalWindow_ConfirmBuyMedalWindowArgs__TypeInfo
		                    );
		  UI_Windows_DialogWindow_DialogWindowArgs___ctor
		            (iVar5,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ConfirmBuyMedalWindow_ConfirmBuyMedalWindowArgs___ctor__
		            );
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar3 = func_ii_7508(StringLiteral_3708,1,0,1,0,0,0,0);
		  *(undefined4 *)(iVar5 + 8) = uVar3;
		  iVar7 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_PriceHolder_ConfirmBuyMedalWindow_ConfirmBuyMedalWindowArgs__TypeInfo
		                    );
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_01 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar9 = *param1_01;
		  if (*(ushort *)(iVar9 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8)) {
		        puVar8 = (uint *)(*(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8 + 4) * 8 + iVar9 + 0x140);
		        goto code_r0x80e575f7;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar9 + 0xb6) != uVar1);
		  }
		  puVar8 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x80e575f7:
		  uVar3 = (**(code **)((ulonglong)*puVar8 * 4))(param1_01,CONCAT44(uVar6,puVar8[1]));
		  uVar3 = func_ii_7112(uVar3,0);
		  *(undefined4 *)(iVar7 + 0xc) = uVar3;
		  iVar9 = Core_Data_MedalData__get_CurrentMedal(param1,0);
		  uVar3 = *(undefined4 *)(*(int *)(iVar9 + 0x10) + 0x24);
		  if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_Money_TypeInfo);
		  }
		  uVar3 = Core_Money_Money__op_Explicit(uVar3,0);
		  *(undefined4 *)(iVar7 + 8) = uVar3;
		  *(int *)(iVar5 + 0x10) = iVar7;
		  iVar7 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ConfirmBuyMedalWindow_ConfirmBuyMedalWindowArgs__MedalData__TypeInfo
		                    );
		  *(int *)(iVar7 + 0xc) = param1;
		  uVar3 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_ConfirmBuyMedalWindow_ConfirmBuyMedalWindowArgs__MedalData__TypeInfo
		                    );
		  UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_object__Int32Enum___Invoke
		            (uVar3,iVar2,
		             Method_Gameplay_Medals_View_ConfirmBuyMedalWindow___c__DisplayClass7_0__Show_b__0__,0);
		  *(undefined4 *)(iVar7 + 0x10) = uVar3;
		  *(int *)(iVar5 + 0x14) = iVar7;
		  iVar2 = 
		  Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ConfirmBuyMedalWindow_ConfirmBuyMedalWindowArgs___Add__
		  ;
		  *(int *)(iVar4 + 0x10) = *(int *)(iVar4 + 0x10) + 1;
		  uVar1 = *(uint *)(iVar4 + 0xc);
		  if (uVar1 < *(uint *)(*(int *)(iVar4 + 8) + 0xc)) {
		    *(uint *)(iVar4 + 0xc) = uVar1 + 1;
		    *(int *)(*(int *)(iVar4 + 8) + uVar1 * 4 + 0x10) = iVar5;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar4,iVar5,*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		  }
		  uVar3 = System_Uri___ctor(0);
		  uVar3 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar3,0);
		  uVar3 = Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		                    (uVar3,StringLiteral_12650,param1_00,
		                     Method_UI_Windows_PopupController_Show_ConfirmBuyMedalWindow___);
		  return uVar3;
		}
		*/

		}

		// Token: 0x060024E9 RID: 9449 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60024E9")]
		[Address(RVA = "0x7634", Offset = "0x7634", VA = "0x7634")]
		public static ConfirmBuyMedalWindow Show(MedalData medal, Action<MedalData> resultCallback)
		{
		/* --- GHIDRA: Show ---
		void Gameplay_Medals_View_ConfirmBuyMedalWindow__Show(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57d79 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_ConfirmBuyMedalWindow_ConfirmBuyMedalWindowArgs___ctor__
		              );
		    DAT_ram_00a57d79 = '\x01';
		  }
		  UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_object____ctor
		            (param1,
		             Method_UI_Windows_BaseDialogWindow_ConfirmBuyMedalWindow_ConfirmBuyMedalWindowArgs___ctor__
		            );
		  return;
		}
		*/

			return null;
		}

		// Token: 0x060024EA RID: 9450 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024EA")]
		[Address(RVA = "0x7635", Offset = "0x7635", VA = "0x7635")]
		public ConfirmBuyMedalWindow()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Medals_View_ConfirmBuyMedalWindow___ctor(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a57d7a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_ConfirmBuyMedalWindow_ConfirmBuyMedalWindowArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_10729);
		    DAT_ram_00a57d7a = '\x01';
		  }
		  UnityEngine_UIElements_BaseCompositeField___Il2CppFullySharedGenericType__object____Il2CppFullySharedGenericType___UpdateMixedValueContent
		            (param1,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_ConfirmBuyMedalWindow_ConfirmBuyMedalWindowArgs___ctor__
		            );
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar1 = func_ii_7508(StringLiteral_10729,1,0,1,0,0,0,0);
		  *(undefined4 *)(param1 + 0x18) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x04001424 RID: 5156
		[Token(Token = "0x4001424")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private MedalView _medalView;

		// Token: 0x04001425 RID: 5157
		[Token(Token = "0x4001425")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private DiscountGroup _discountGroup;

		// Token: 0x04001426 RID: 5158
		[Token(Token = "0x4001426")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Medals/ConfirmBuyMedalWindow";

		// Token: 0x020005F3 RID: 1523
		[Token(Token = "0x20005F3")]
		public class ConfirmBuyMedalWindowArgs : BaseDialogWindow<ConfirmBuyMedalWindow.ConfirmBuyMedalWindowArgs>.BaseDialogWindowArgs
		{
			// Token: 0x060024EB RID: 9451 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60024EB")]
			[Address(RVA = "0x7636", Offset = "0x7636", VA = "0x7636")]
			public ConfirmBuyMedalWindowArgs()
			{
			}

			// Token: 0x04001427 RID: 5159
			[Token(Token = "0x4001427")]
			[FieldOffset(Offset = "0x2C")]
			public MedalData MedalData;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_WindowId ---
		void Gameplay_Medals_View_ConfirmBuyMedalWindow__get_WindowId(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 in_register_20000014;
		  undefined8 uVar2;
		  int iVar3;
		  undefined4 uVar4;
		  uint *puVar5;
		  int *piVar6;
		  float8 local_8;
		  
		  if (DAT_ram_00a57d77 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_ConfirmBuyMedalWindow_ConfirmBuyMedalWindowArgs__HandleContent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseWindow_ConfirmBuyMedalWindow_ConfirmBuyMedalWindowArgs__get_WindowArgs__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Discounts_Model_IDiscountsProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a57d77 = '\x01';
		  }
		  local_8 = 0.0;
		  UI_Windows_BaseDialogWindow_object___HandleButtons
		            (param1,
		             Method_UI_Windows_BaseDialogWindow_ConfirmBuyMedalWindow_ConfirmBuyMedalWindowArgs__HandleContent__
		            );
		  piVar6 = *(int **)(param1 + 0x50);
		  iVar3 = func_ii_8093(param1,
		                       Method_UI_Windows_BaseWindow_ConfirmBuyMedalWindow_ConfirmBuyMedalWindowArgs__get_WindowArgs__
		                      );
		  uVar4 = Core_Data_MedalData__get_CurrentMedal(*(undefined4 *)(iVar3 + 0x2c),0);
		  iVar3 = *piVar6;
		  uVar2 = CONCAT44(in_register_20000014,uVar4);
		  (**(code **)((ulonglong)*(uint *)(iVar3 + 0x138) * 4))
		            (piVar6,uVar2,*(undefined4 *)(iVar3 + 0x13c));
		  uVar4 = (undefined4)((ulonglong)uVar2 >> 0x20);
		  *(undefined4 *)(*(int *)(param1 + 0x50) + 0x40) = 2;
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  piVar6 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar3 = *piVar6;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar5 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x248);
		        goto code_r0x80e571a4;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar5 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x31);
		code_r0x80e571a4:
		  uVar2 = CONCAT44(uVar4,puVar5[1]);
		  iVar3 = (**(code **)((ulonglong)*puVar5 * 4))(piVar6,uVar2);
		  uVar4 = (undefined4)((ulonglong)uVar2 >> 0x20);
		  uVar1 = 0;
		  piVar6 = *(int **)(iVar3 + 0x20);
		  iVar3 = *piVar6;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Gameplay_Discounts_Model_IDiscountsProvider_TypeInfo ==
		          *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar5 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 200);
		        goto code_r0x80e57229;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar5 = (uint *)func_ii_1080(piVar6,Gameplay_Discounts_Model_IDiscountsProvider_TypeInfo,1);
		code_r0x80e57229:
		  iVar3 = (**(code **)((ulonglong)*puVar5 * 4))(piVar6,CONCAT44(uVar4,1),&local_8,puVar5[1]);
		  if (iVar3 == 0) {
		    uVar4 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(param1 + 0x54),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar4,0,0);
		  }
		  else {
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (*(undefined4 *)(*(int *)(param1 + 0x50) + 0x3c),1,0);
		    Gameplay_DailyQuests_Controller_QuestsTriggerObserver_Quests___ctor
		              (*(undefined4 *)(param1 + 0x54),(double)local_8,1,0);
		  }
		  return;
		}
		*/

}
