using System;
using Core.Data;
using Gameplay.Craft.View;
using Il2CppDummyDll;
using Protocol.Craft;
using UI.Price;
using UnityEngine;

namespace UI.Windows
{
	// Token: 0x02000288 RID: 648
	[Token(Token = "0x2000288")]
	public class ConfirmCancelCraftWindow : BaseDialogWindow<ConfirmCancelCraftWindow.ConfirmCancelCraftWindowArgs>
	{
		// Token: 0x1700021F RID: 543
		// (get) Token: 0x06000F52 RID: 3922 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700021F")]
		public override string WindowId
		{
			[Token(Token = "0x6000F52")]
			[Address(RVA = "0x617D", Offset = "0x617D", VA = "0x617D", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000F53 RID: 3923 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F53")]
		[Address(RVA = "0x617E", Offset = "0x617E", VA = "0x617E", Slot = "28")]
		protected override void HandleContent()
		{
		/* --- GHIDRA: HandleContent ---
		undefined4
		UI_Windows_ConfirmCancelCraftWindow__HandleContent
		          (undefined4 param1,int param2,undefined4 param3,undefined4 param4)
		
		{
		  int iVar1;
		  int param1_00;
		  int iVar2;
		  int iVar3;
		  undefined4 uVar4;
		  undefined4 uVar5;
		  int iVar6;
		  uint uVar7;
		  
		  if (DAT_ram_00a639fb == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_ConfirmCancelCraftWindow_ConfirmCancelCraftWindowArgs__uint__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ConfirmCancelCraftWindow_ConfirmCancelCraftWindowArgs__uint___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ConfirmCancelCraftWindow_ConfirmCancelCraftWindowArgs__uint__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&UI_Windows_ConfirmCancelCraftWindow_ConfirmCancelCraftWindowArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ConfirmCancelCraftWindow_ConfirmCancelCraftWindowArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ConfirmCancelCraftWindow_ConfirmCancelCraftWindowArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ConfirmCancelCraftWindow_ConfirmCancelCraftWindowArgs___Add__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_PopupController_Show_ConfirmCancelCraftWindow___);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_ConfirmCancelCraftWindow___c__DisplayClass7_0__Show_b__0__);
		    Mono_Security_ASN1__get_Item(&UI_Windows_ConfirmCancelCraftWindow___c__DisplayClass7_0_TypeInfo)
		    ;
		    Mono_Security_ASN1__get_Item(&StringLiteral_11304);
		    Mono_Security_ASN1__get_Item(&StringLiteral_18331);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12603);
		    DAT_ram_00a639fb = '\x01';
		  }
		  iVar1 = unnamed_function_1417(UI_Windows_ConfirmCancelCraftWindow___c__DisplayClass7_0_TypeInfo);
		  *(undefined4 *)(iVar1 + 8) = param3;
		  uVar4 = *(undefined4 *)(param2 + 0x4c);
		  uVar5 = *(undefined4 *)(param2 + 0x44);
		  param1_00 = unnamed_function_1417
		                        (UI_Windows_ConfirmCancelCraftWindow_ConfirmCancelCraftWindowArgs_TypeInfo);
		  if (DAT_ram_00a639fd == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_ConfirmCancelCraftWindow_ConfirmCancelCraftWindowArgs___ctor__
		              );
		    DAT_ram_00a639fd = '\x01';
		  }
		  UnityEngine_UIElements_BaseCompositeField___Il2CppFullySharedGenericType__object____Il2CppFullySharedGenericType___UpdateMixedValueContent
		            (param1_00,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_ConfirmCancelCraftWindow_ConfirmCancelCraftWindowArgs___ctor__
		            );
		  *(undefined4 *)(param1_00 + 0x34) = uVar4;
		  *(undefined4 *)(param1_00 + 0x2c) = uVar5;
		  *(undefined4 *)(param1_00 + 0x30) = param1;
		  UI_Windows_ConfirmCancelCraftWindow_ConfirmCancelCraftWindowArgs___ctor(param1_00,param1_00);
		  iVar6 = *(int *)(param1_00 + 0x24);
		  iVar2 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ConfirmCancelCraftWindow_ConfirmCancelCraftWindowArgs__TypeInfo
		                    );
		  UI_Windows_DialogWindow_DialogWindowArgs___ctor
		            (iVar2,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ConfirmCancelCraftWindow_ConfirmCancelCraftWindowArgs___ctor__
		            );
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar4 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_18331,1,0,1,0,0,0,0);
		  *(undefined4 *)(iVar2 + 8) = uVar4;
		  iVar3 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ConfirmCancelCraftWindow_ConfirmCancelCraftWindowArgs__uint__TypeInfo
		                    );
		  *(undefined4 *)(iVar3 + 0xc) = *(undefined4 *)(*(int *)(param1_00 + 0x2c) + 0xc);
		  uVar4 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_ConfirmCancelCraftWindow_ConfirmCancelCraftWindowArgs__uint__TypeInfo
		                    );
		  UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_object__object___Invoke
		            (uVar4,iVar1,
		             Method_UI_Windows_ConfirmCancelCraftWindow___c__DisplayClass7_0__Show_b__0__,0);
		  *(undefined4 *)(iVar3 + 0x10) = uVar4;
		  *(int *)(iVar2 + 0x14) = iVar3;
		  iVar1 = 
		  Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ConfirmCancelCraftWindow_ConfirmCancelCraftWindowArgs___Add__
		  ;
		  *(int *)(iVar6 + 0x10) = *(int *)(iVar6 + 0x10) + 1;
		  uVar7 = *(uint *)(iVar6 + 0xc);
		  if (uVar7 < *(uint *)(*(int *)(iVar6 + 8) + 0xc)) {
		    *(uint *)(iVar6 + 0xc) = uVar7 + 1;
		    *(int *)(*(int *)(iVar6 + 8) + uVar7 * 4 + 0x10) = iVar2;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar6,iVar2,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  iVar6 = *(int *)(param1_00 + 0x24);
		  iVar2 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ConfirmCancelCraftWindow_ConfirmCancelCraftWindowArgs__TypeInfo
		                    );
		  UI_Windows_DialogWindow_DialogWindowArgs___ctor
		            (iVar2,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ConfirmCancelCraftWindow_ConfirmCancelCraftWindowArgs___ctor__
		            );
		  uVar4 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_11304,1,0,1,0,0,0,0);
		  *(undefined4 *)(iVar2 + 8) = uVar4;
		  iVar1 = 
		  Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ConfirmCancelCraftWindow_ConfirmCancelCraftWindowArgs___Add__
		  ;
		  *(int *)(iVar6 + 0x10) = *(int *)(iVar6 + 0x10) + 1;
		  uVar7 = *(uint *)(iVar6 + 0xc);
		  if (uVar7 < *(uint *)(*(int *)(iVar6 + 8) + 0xc)) {
		    *(uint *)(iVar6 + 0xc) = uVar7 + 1;
		    *(int *)(*(int *)(iVar6 + 8) + uVar7 * 4 + 0x10) = iVar2;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar6,iVar2,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  uVar4 = System_Uri___ctor(0);
		  uVar4 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar4,0);
		  uVar4 = Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		                    (uVar4,StringLiteral_12603,param1_00,
		                     Method_UI_Windows_PopupController_Show_ConfirmCancelCraftWindow___);
		  return uVar4;
		}
		*/

		}

		// Token: 0x06000F54 RID: 3924 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000F54")]
		[Address(RVA = "0x617F", Offset = "0x617F", VA = "0x617F")]
		public static ConfirmCancelCraftWindow Show(UserData user, CraftSlotListElement element, Action<uint> resultCallback)
		{
		/* --- GHIDRA: Show ---
		void UI_Windows_ConfirmCancelCraftWindow__Show(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a639fc == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_ConfirmCancelCraftWindow_ConfirmCancelCraftWindowArgs___ctor__
		              );
		    DAT_ram_00a639fc = '\x01';
		  }
		  UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_object____ctor
		            (param1,
		             Method_UI_Windows_BaseDialogWindow_ConfirmCancelCraftWindow_ConfirmCancelCraftWindowArgs___ctor__
		            );
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06000F55 RID: 3925 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F55")]
		[Address(RVA = "0x6180", Offset = "0x6180", VA = "0x6180")]
		public ConfirmCancelCraftWindow()
		{
		/* --- GHIDRA: .ctor ---
		void UI_Windows_ConfirmCancelCraftWindow___ctor
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  if (DAT_ram_00a639fd == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_ConfirmCancelCraftWindow_ConfirmCancelCraftWindowArgs___ctor__
		              );
		    DAT_ram_00a639fd = '\x01';
		  }
		  UnityEngine_UIElements_BaseCompositeField___Il2CppFullySharedGenericType__object____Il2CppFullySharedGenericType___UpdateMixedValueContent
		            (param1,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_ConfirmCancelCraftWindow_ConfirmCancelCraftWindowArgs___ctor__
		            );
		  *(undefined4 *)(param1 + 0x34) = param4;
		  *(undefined4 *)(param1 + 0x2c) = param3;
		  *(undefined4 *)(param1 + 0x30) = param2;
		  UI_Windows_ConfirmCancelCraftWindow_ConfirmCancelCraftWindowArgs___ctor(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x040007C7 RID: 1991
		[Token(Token = "0x40007C7")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Craft/ConfirmCancelCraftWindow";

		// Token: 0x040007C8 RID: 1992
		[Token(Token = "0x40007C8")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Price _pricePrefab;

		// Token: 0x040007C9 RID: 1993
		[Token(Token = "0x40007C9")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private GameObject _spacerPrefab;

		// Token: 0x02000289 RID: 649
		[Token(Token = "0x2000289")]
		public class ConfirmCancelCraftWindowArgs : BaseDialogWindow<ConfirmCancelCraftWindow.ConfirmCancelCraftWindowArgs>.BaseDialogWindowArgs
		{
			// Token: 0x06000F56 RID: 3926 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000F56")]
			[Address(RVA = "0x6181", Offset = "0x6181", VA = "0x6181")]
			public ConfirmCancelCraftWindowArgs(UserData user, UserCraftSlotInfo slotInfo, CraftSchemeData.CraftSchemeInfo schemeInfo)
			{
			}

			// Token: 0x06000F57 RID: 3927 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000F57")]
			[Address(RVA = "0x6182", Offset = "0x6182", VA = "0x6182")]
			private void InitInstance()
			{
			}

			// Token: 0x040007CA RID: 1994
			[Token(Token = "0x40007CA")]
			[FieldOffset(Offset = "0x2C")]
			public readonly UserCraftSlotInfo SlotInfo;

			// Token: 0x040007CB RID: 1995
			[Token(Token = "0x40007CB")]
			[FieldOffset(Offset = "0x30")]
			public readonly UserData User;

			// Token: 0x040007CC RID: 1996
			[Token(Token = "0x40007CC")]
			[FieldOffset(Offset = "0x34")]
			public readonly CraftSchemeData.CraftSchemeInfo SchemeInfo;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_WindowId ---
		void UI_Windows_ConfirmCancelCraftWindow__get_WindowId(int param1,undefined4 param2)
		
		{
		  undefined4 in_register_20000014;
		  uint *puVar1;
		  undefined4 uVar2;
		  double param2_00;
		  int *param1_00;
		  int iVar3;
		  undefined4 uVar4;
		  undefined4 param1_01;
		  uint uVar5;
		  
		  if (DAT_ram_00a639fa == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_ConfirmCancelCraftWindow_ConfirmCancelCraftWindowArgs__HandleContent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_ConfirmCancelCraftWindow_ConfirmCancelCraftWindowArgs__get_Content__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_ConfirmCancelCraftWindow_ConfirmCancelCraftWindowArgs__get_DescriptionField__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseWindow_ConfirmCancelCraftWindow_ConfirmCancelCraftWindowArgs__get_WindowArgs__
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_GameObject___);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_Price___);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_TextMeshProUGUI___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27946);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4396);
		    DAT_ram_00a639fa = '\x01';
		  }
		  UI_Windows_BaseDialogWindow_object___HandleButtons
		            (param1,
		             Method_UI_Windows_BaseDialogWindow_ConfirmCancelCraftWindow_ConfirmCancelCraftWindowArgs__HandleContent__
		            );
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar5 = 0;
		  param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar3 = *param1_00;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar5 * 8)) {
		        puVar1 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar5 * 8 + 4) * 8 + iVar3 + 0x178);
		        goto code_r0x82329ddb;
		      }
		      uVar5 = uVar5 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar5);
		  }
		  puVar1 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x82329ddb:
		  uVar2 = (**(code **)((ulonglong)*puVar1 * 4))(param1_00,CONCAT44(in_register_20000014,puVar1[1]));
		  uVar2 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar2,0);
		  iVar3 = func_ii_8093(param1,
		                       Method_UI_Windows_BaseWindow_ConfirmCancelCraftWindow_ConfirmCancelCraftWindowArgs__get_WindowArgs__
		                      );
		  iVar3 = Core_Extensions_Dict_DictExt__GetStringParameter
		                    (uVar2,*(undefined4 *)(*(int *)(*(int *)(iVar3 + 0x34) + 8) + 0x14),0);
		  param2_00 = Core_Extensions_Dict_DictExt__GetIntParameter(uVar2,StringLiteral_27946,0);
		  uVar2 = *(undefined4 *)(iVar3 + 0x10);
		  if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_Money_TypeInfo);
		  }
		  uVar2 = Core_Money_Money__op_Explicit(uVar2,0);
		  uVar2 = Core_Money_Money__op_Subtraction(uVar2,param2_00,0);
		  uVar4 = *(undefined4 *)(param1 + 0x40);
		  param1_01 = *(undefined4 *)(param1 + 0x54);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  func_ii_6805(param1_01,uVar4,Method_UnityEngine_Object_Instantiate_GameObject___);
		  uVar4 = func_ii_6805(*(undefined4 *)(param1 + 0x50),*(undefined4 *)(param1 + 0x40),
		                       Method_UnityEngine_Object_Instantiate_Price___);
		  iVar3 = func_ii_8093(param1,
		                       Method_UI_Windows_BaseWindow_ConfirmCancelCraftWindow_ConfirmCancelCraftWindowArgs__get_WindowArgs__
		                      );
		  UI_Price_Price__SetColor(uVar4,*(undefined4 *)(iVar3 + 0x30),uVar2,0);
		  func_ii_6805(*(undefined4 *)(param1 + 0x54),*(undefined4 *)(param1 + 0x40),
		               Method_UnityEngine_Object_Instantiate_GameObject___);
		  uVar2 = func_ii_6805(*(undefined4 *)(param1 + 0x3c),*(undefined4 *)(param1 + 0x40),
		                       Method_UnityEngine_Object_Instantiate_TextMeshProUGUI___);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar4 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4396,1,0,1,0,0,0,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar2,uVar4,0);
		  return;
		}
		*/

}
