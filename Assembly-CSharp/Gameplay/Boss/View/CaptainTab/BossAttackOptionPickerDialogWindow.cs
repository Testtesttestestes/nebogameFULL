using System;
using System.Runtime.CompilerServices;
using Gameplay.Boss.Model;
using Il2CppDummyDll;
using UI.Elements.Buttons;
using UI.Windows;
using UnityEngine;

namespace Gameplay.Boss.View.CaptainTab
{
	// Token: 0x02000B73 RID: 2931
	[Token(Token = "0x2000B73")]
	public class BossAttackOptionPickerDialogWindow : BaseDialogWindow<BossAttackOptionPickerDialogWindow.BossAttackOptionPickerDialogWindowArgs>
	{
		// Token: 0x17000E35 RID: 3637
		// (get) Token: 0x06004734 RID: 18228 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000E35")]
		public override string WindowId
		{
			[Token(Token = "0x6004734")]
			[Address(RVA = "0x95CA", Offset = "0x95CA", VA = "0x95CA", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x140001C0 RID: 448
		// (add) Token: 0x06004735 RID: 18229 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06004736 RID: 18230 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001C0")]
		public event Action<BossInfo.BossAttackOption.BossAttackOptionVariant> SelectedEvent
		{
			[Token(Token = "0x6004735")]
			[Address(RVA = "0x95CB", Offset = "0x95CB", VA = "0x95CB")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6004736")]
			[Address(RVA = "0x95CC", Offset = "0x95CC", VA = "0x95CC")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000E36 RID: 3638
		// (get) Token: 0x06004737 RID: 18231 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004738 RID: 18232 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E36")]
		public BossInfo.BossAttackOption.BossAttackOptionVariant SelectedVariant
		{
			[Token(Token = "0x6004737")]
			[Address(RVA = "0x95CD", Offset = "0x95CD", VA = "0x95CD")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004738")]
			[Address(RVA = "0x95CE", Offset = "0x95CE", VA = "0x95CE")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06004739 RID: 18233 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004739")]
		[Address(RVA = "0x95CF", Offset = "0x95CF", VA = "0x95CF", Slot = "18")]
		protected override void OnShow(BaseWindowArgs args)
		{
		/* --- GHIDRA: OnShow ---
		void Gameplay_Boss_View_CaptainTab_BossAttackOptionPickerDialogWindow__OnShow
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a57a2b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&System_Action_BossInfo_BossAttackOption_BossAttackOptionVariant__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BossAttackOptionPickerDialogWindow_BossAttackOptionPickerDialogWindowArgs__OnClose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Boss_View_CaptainTab_BossAttackOptionPickerDialogWindow_ConfirmButtonClickHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Boss_View_CaptainTab_BossAttackOptionPickerDialogWindow_ValuePickerOnSelectionChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_ValuePicker_ValuePicker_BossInfo_BossAttackOption_BossAttackOptionVariant__remove_SelectionChangedEvent__
		              );
		    DAT_ram_00a57a2b = '\x01';
		  }
		  UI_Windows_BaseDialogWindow_object___HandleTitle
		            (param1,
		             Method_UI_Windows_BaseDialogWindow_BossAttackOptionPickerDialogWindow_BossAttackOptionPickerDialogWindowArgs__OnClose__
		            );
		  uVar2 = *(undefined4 *)(param1 + 0x50);
		  uVar1 = unnamed_function_1417
		                    (System_Action_BossInfo_BossAttackOption_BossAttackOptionVariant__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_Boss_View_CaptainTab_BossAttackOptionPickerDialogWindow_ValuePickerOnSelectionChangedEvent__
		             ,0);
		  UI_ValuePicker_ValuePicker___Il2CppFullySharedGenericType___add_SelectionChangedEvent
		            (uVar2,uVar1,
		             Method_UI_ValuePicker_ValuePicker_BossInfo_BossAttackOption_BossAttackOptionVariant__remove_SelectionChangedEvent__
		            );
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 0x54) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,
		             Method_Gameplay_Boss_View_CaptainTab_BossAttackOptionPickerDialogWindow_ConfirmButtonClickHandler__
		             ,0);
		  UnityEngine_Events_UnityAction___ctor(uVar2,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x0600473A RID: 18234 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600473A")]
		[Address(RVA = "0x95D0", Offset = "0x95D0", VA = "0x95D0", Slot = "19")]
		protected override void OnClose()
		{
		/* --- GHIDRA: OnClose ---
		void Gameplay_Boss_View_CaptainTab_BossAttackOptionPickerDialogWindow__OnClose
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param1 + 0x5c);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(param1 + 0x60),
		               *(undefined4 *)(iVar1 + 0x14));
		  }
		  System_ComponentModel_BindingList___Il2CppFullySharedGenericType___OnAddingNew(param1,2,0);
		  return;
		}
		*/

		}

		// Token: 0x0600473B RID: 18235 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600473B")]
		[Address(RVA = "0x95D1", Offset = "0x95D1", VA = "0x95D1")]
		private void ConfirmButtonClickHandler()
		{
		/* --- GHIDRA: ConfirmButtonClickHandler ---
		void Gameplay_Boss_View_CaptainTab_BossAttackOptionPickerDialogWindow__ConfirmButtonClickHandler
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar5;
		  
		  if (DAT_ram_00a57a2c == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		    DAT_ram_00a57a2c = '\x01';
		  }
		  *(undefined4 *)(param1 + 0x60) = param2;
		  param1_00 = *(undefined4 *)(*(int *)(param1 + 0x54) + 0xb8);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_01 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar5 = *param1_01;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x140);
		        goto code_r0x80e15750;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x80e15750:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_01,puVar2[1]);
		  uVar3 = func_ii_7112(uVar3,0);
		  uVar4 = com_unity3d_mediation_LevelPlayBannerAd___ctor(*(undefined4 *)(param1 + 0x60),0);
		  if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_Money_TypeInfo);
		  }
		  uVar4 = Core_Money_Money__op_Explicit(uVar4,0);
		  UI_Price_Price__SetColor(param1_00,uVar3,uVar4,0);
		  Gameplay_Boss_View_CaptainTab_BossAttackSkillBonusView__get_Skills
		            (*(undefined4 *)(param1 + 0x58),*(undefined4 *)(*(int *)(param1 + 0x60) + 0xc),uVar3);
		  return;
		}
		*/

		}

		// Token: 0x0600473C RID: 18236 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600473C")]
		[Address(RVA = "0x95D2", Offset = "0x95D2", VA = "0x95D2")]
		private void ValuePickerOnSelectionChangedEvent(BossInfo.BossAttackOption.BossAttackOptionVariant variant)
		{
		/* --- GHIDRA: ValuePickerOnSelectionChangedEvent ---
		void Gameplay_Boss_View_CaptainTab_BossAttackOptionPickerDialogWindow__ValuePickerOnSelectionChangedEvent
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param2_00;
		  undefined4 *puVar3;
		  undefined4 param2_01;
		  
		  if (DAT_ram_00a57a2d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BossAttackOptionPickerDialogWindow_BossAttackOptionPickerDialogWindowArgs__HandleContent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseWindow_BossAttackOptionPickerDialogWindow_BossAttackOptionPickerDialogWindowArgs__get_WindowArgs__
		              );
		    Mono_Security_ASN1__get_Item
		              (&System_Func_BossInfo_BossAttackOption_BossAttackOptionVariant__string__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Boss_View_CaptainTab_BossAttackOptionPickerDialogWindow___c__HandleContent_b__17_0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Boss_View_CaptainTab_BossAttackOptionPickerDialogWindow___c_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_ValuePicker_ValuePicker_BossInfo_BossAttackOption_BossAttackOptionVariant__Init__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_ValuePicker_ValuePicker_BossInfo_BossAttackOption_BossAttackOptionVariant__ScrollTo__
		              );
		    DAT_ram_00a57a2d = '\x01';
		  }
		  UI_Windows_BaseDialogWindow_object___HandleButtons
		            (param1,
		             Method_UI_Windows_BaseDialogWindow_BossAttackOptionPickerDialogWindow_BossAttackOptionPickerDialogWindowArgs__HandleContent__
		            );
		  uVar2 = *(undefined4 *)(param1 + 0x50);
		  iVar1 = func_ii_8093(param1,
		                       Method_UI_Windows_BaseWindow_BossAttackOptionPickerDialogWindow_BossAttackOptionPickerDialogWindowArgs__get_WindowArgs__
		                      );
		  param2_00 = *(undefined4 *)(*(int *)(iVar1 + 0x2c) + 0xc);
		  if (*(int *)(Gameplay_Boss_View_CaptainTab_BossAttackOptionPickerDialogWindow___c_TypeInfo + 0x74)
		      == 0) {
		    func_ii_306000(Gameplay_Boss_View_CaptainTab_BossAttackOptionPickerDialogWindow___c_TypeInfo);
		  }
		  puVar3 = *(undefined4 **)
		            (Gameplay_Boss_View_CaptainTab_BossAttackOptionPickerDialogWindow___c_TypeInfo + 0x5c);
		  iVar1 = puVar3[1];
		  if (iVar1 == 0) {
		    if (*(int *)(Gameplay_Boss_View_CaptainTab_BossAttackOptionPickerDialogWindow___c_TypeInfo +
		                0x74) == 0) {
		      func_ii_306000(Gameplay_Boss_View_CaptainTab_BossAttackOptionPickerDialogWindow___c_TypeInfo);
		      puVar3 = *(undefined4 **)
		                (Gameplay_Boss_View_CaptainTab_BossAttackOptionPickerDialogWindow___c_TypeInfo +
		                0x5c);
		    }
		    param2_01 = *puVar3;
		    iVar1 = unnamed_function_1417
		                      (
		                      System_Func_BossInfo_BossAttackOption_BossAttackOptionVariant__string__TypeInfo
		                      );
		    System_Linq_Enumerable__Where_object_
		              (iVar1,param2_01,
		               Method_Gameplay_Boss_View_CaptainTab_BossAttackOptionPickerDialogWindow___c__HandleContent_b__17_0__
		               ,0);
		    *(int *)(*(int *)(Gameplay_Boss_View_CaptainTab_BossAttackOptionPickerDialogWindow___c_TypeInfo
		                     + 0x5c) + 4) = iVar1;
		  }
		  UI_ValuePicker_ValuePicker_object___Awake
		            (uVar2,param2_00,iVar1,
		             Method_UI_ValuePicker_ValuePicker_BossInfo_BossAttackOption_BossAttackOptionVariant__Init__
		            );
		  uVar2 = *(undefined4 *)(param1 + 0x50);
		  iVar1 = func_ii_8093(param1,
		                       Method_UI_Windows_BaseWindow_BossAttackOptionPickerDialogWindow_BossAttackOptionPickerDialogWindowArgs__get_WindowArgs__
		                      );
		  UI_ValuePicker_ValuePicker_object___OnDestroy
		            (uVar2,*(undefined4 *)(iVar1 + 0x30),
		             Method_UI_ValuePicker_ValuePicker_BossInfo_BossAttackOption_BossAttackOptionVariant__ScrollTo__
		            );
		  return;
		}
		*/

		}

		// Token: 0x0600473D RID: 18237 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600473D")]
		[Address(RVA = "0x95D3", Offset = "0x95D3", VA = "0x95D3", Slot = "28")]
		protected override void HandleContent()
		{
		/* --- GHIDRA: HandleContent ---
		undefined4
		Gameplay_Boss_View_CaptainTab_BossAttackOptionPickerDialogWindow__HandleContent
		          (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int param1_00;
		  
		  if (DAT_ram_00a57a2e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Boss_View_CaptainTab_BossAttackOptionPickerDialogWindow_BossAttackOptionPickerDialogWindowArgs_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_PopupController_Show_BossAttackOptionPickerDialogWindow___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12577);
		    DAT_ram_00a57a2e = '\x01';
		  }
		  uVar1 = System_Uri___ctor(0);
		  uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar1,0);
		  param1_00 = unnamed_function_1417
		                        (
		                        Gameplay_Boss_View_CaptainTab_BossAttackOptionPickerDialogWindow_BossAttackOptionPickerDialogWindowArgs_TypeInfo
		                        );
		  Gameplay_Boss_View_CaptainTab_BossAttackOptionPickerDialogWindow___ctor(param1_00,param1_00);
		  *(undefined4 *)(param1_00 + 0x30) = param2;
		  *(undefined4 *)(param1_00 + 0x2c) = param1;
		  uVar1 = Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		                    (uVar1,StringLiteral_12577,param1_00,
		                     Method_UI_Windows_PopupController_Show_BossAttackOptionPickerDialogWindow___);
		  return uVar1;
		}
		*/

		}

		// Token: 0x0600473E RID: 18238 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600473E")]
		[Address(RVA = "0x95D4", Offset = "0x95D4", VA = "0x95D4")]
		public static BossAttackOptionPickerDialogWindow Show(BossInfo.BossAttackOption bossAttackOption, BossInfo.BossAttackOption.BossAttackOptionVariant initialVariant)
		{
		/* --- GHIDRA: Show ---
		void Gameplay_Boss_View_CaptainTab_BossAttackOptionPickerDialogWindow__Show
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57a2f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BossAttackOptionPickerDialogWindow_BossAttackOptionPickerDialogWindowArgs___ctor__
		              );
		    DAT_ram_00a57a2f = '\x01';
		  }
		  UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_object____ctor
		            (param1,
		             Method_UI_Windows_BaseDialogWindow_BossAttackOptionPickerDialogWindow_BossAttackOptionPickerDialogWindowArgs___ctor__
		            );
		  return;
		}
		*/

			return null;
		}

		// Token: 0x0600473F RID: 18239 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600473F")]
		[Address(RVA = "0x95D5", Offset = "0x95D5", VA = "0x95D5")]
		public BossAttackOptionPickerDialogWindow()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Boss_View_CaptainTab_BossAttackOptionPickerDialogWindow___ctor
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int param1_00;
		  int param1_01;
		  uint uVar3;
		  
		  if (DAT_ram_00a57a30 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_BossAttackOptionPickerDialogWindow_BossAttackOptionPickerDialogWindowArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_BossAttackOptionPickerDialogWindow_BossAttackOptionPickerDialogWindowArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_BossAttackOptionPickerDialogWindow_BossAttackOptionPickerDialogWindowArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_BossAttackOptionPickerDialogWindow_BossAttackOptionPickerDialogWindowArgs___Add__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_BossAttackOptionPickerDialogWindow_BossAttackOptionPickerDialogWindowArgs____ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_BossAttackOptionPickerDialogWindow_BossAttackOptionPickerDialogWindowArgs___TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&StringLiteral_3632);
		    DAT_ram_00a57a30 = '\x01';
		  }
		  UnityEngine_UIElements_BaseCompositeField___Il2CppFullySharedGenericType__object____Il2CppFullySharedGenericType___UpdateMixedValueContent
		            (param1,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_BossAttackOptionPickerDialogWindow_BossAttackOptionPickerDialogWindowArgs___ctor__
		            );
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar2 = func_ii_7508(StringLiteral_3632,1,0,1,0,0,0,0);
		  *(undefined4 *)(param1 + 0x1c) = 0;
		  *(undefined4 *)(param1 + 0x18) = uVar2;
		  param1_00 = unnamed_function_1417
		                        (
		                        System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_BossAttackOptionPickerDialogWindow_BossAttackOptionPickerDialogWindowArgs___TypeInfo
		                        );
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,
		             Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_BossAttackOptionPickerDialogWindow_BossAttackOptionPickerDialogWindowArgs____ctor__
		            );
		  param1_01 = unnamed_function_1417
		                        (
		                        UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_BossAttackOptionPickerDialogWindow_BossAttackOptionPickerDialogWindowArgs__TypeInfo
		                        );
		  UI_Windows_DialogWindow_DialogWindowArgs___ctor
		            (param1_01,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_BossAttackOptionPickerDialogWindow_BossAttackOptionPickerDialogWindowArgs___ctor__
		            );
		  uVar2 = UI_Windows_DialogWindow__get_OK_LABEL(0);
		  *(undefined4 *)(param1_01 + 8) = uVar2;
		  iVar1 = 
		  Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_BossAttackOptionPickerDialogWindow_BossAttackOptionPickerDialogWindowArgs___Add__
		  ;
		  *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		  uVar3 = *(uint *)(param1_00 + 0xc);
		  if (uVar3 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		    *(uint *)(param1_00 + 0xc) = uVar3 + 1;
		    *(int *)(*(int *)(param1_00 + 8) + uVar3 * 4 + 0x10) = param1_01;
		    *(int *)(param1 + 0x24) = param1_00;
		    return;
		  }
		  System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		            (param1_00,param1_01,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  *(int *)(param1 + 0x24) = param1_00;
		  return;
		}
		*/

		}

		// Token: 0x0400270D RID: 9997
		[Token(Token = "0x400270D")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Boss/BossAttackOptionPickerDialogWindow";

		// Token: 0x0400270E RID: 9998
		[Token(Token = "0x400270E")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private BossAttackOptionValuePicker _valuePicker;

		// Token: 0x0400270F RID: 9999
		[Token(Token = "0x400270F")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private ButtonWithCost _buttonWithCost;

		// Token: 0x04002710 RID: 10000
		[Token(Token = "0x4002710")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private BossAttackSkillBonusView _skillBonusView;

		// Token: 0x02000B74 RID: 2932
		[Token(Token = "0x2000B74")]
		public class BossAttackOptionPickerDialogWindowArgs : BaseDialogWindow<BossAttackOptionPickerDialogWindow.BossAttackOptionPickerDialogWindowArgs>.BaseDialogWindowArgs
		{
			// Token: 0x06004740 RID: 18240 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004740")]
			[Address(RVA = "0x95D6", Offset = "0x95D6", VA = "0x95D6")]
			public BossAttackOptionPickerDialogWindowArgs()
			{
			}

			// Token: 0x04002713 RID: 10003
			[Token(Token = "0x4002713")]
			[FieldOffset(Offset = "0x2C")]
			public BossInfo.BossAttackOption BossAttackOption;

			// Token: 0x04002714 RID: 10004
			[Token(Token = "0x4002714")]
			[FieldOffset(Offset = "0x30")]
			public BossInfo.BossAttackOption.BossAttackOptionVariant InitialVariant;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_WindowId ---
		void Gameplay_Boss_View_CaptainTab_BossAttackOptionPickerDialogWindow__get_WindowId
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a57a28 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&System_Action_BossInfo_BossAttackOption_BossAttackOptionVariant__TypeInfo);
		    DAT_ram_00a57a28 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x5c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_BossInfo_BossAttackOption_BossAttackOptionVariant__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,
		                             System_Action_BossInfo_BossAttackOption_BossAttackOptionVariant__TypeInfo
		                            ), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x5c,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: add_SelectedEvent ---
		void Gameplay_Boss_View_CaptainTab_BossAttackOptionPickerDialogWindow__add_SelectedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a57a29 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&System_Action_BossInfo_BossAttackOption_BossAttackOptionVariant__TypeInfo);
		    DAT_ram_00a57a29 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x5c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_BossInfo_BossAttackOption_BossAttackOptionVariant__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,
		                             System_Action_BossInfo_BossAttackOption_BossAttackOptionVariant__TypeInfo
		                            ), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x5c,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: set_SelectedVariant ---
		void Gameplay_Boss_View_CaptainTab_BossAttackOptionPickerDialogWindow__set_SelectedVariant
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a57a2a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&System_Action_BossInfo_BossAttackOption_BossAttackOptionVariant__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseWindow_BossAttackOptionPickerDialogWindow_BossAttackOptionPickerDialogWindowArgs__OnShow__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Boss_View_CaptainTab_BossAttackOptionPickerDialogWindow_ConfirmButtonClickHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Boss_View_CaptainTab_BossAttackOptionPickerDialogWindow_ValuePickerOnSelectionChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_ValuePicker_ValuePicker_BossInfo_BossAttackOption_BossAttackOptionVariant__add_SelectionChangedEvent__
		              );
		    DAT_ram_00a57a2a = '\x01';
		  }
		  UI_Windows_BaseWindow_object____ctor
		            (param1,param2,
		             Method_UI_Windows_BaseWindow_BossAttackOptionPickerDialogWindow_BossAttackOptionPickerDialogWindowArgs__OnShow__
		            );
		  uVar2 = *(undefined4 *)(param1 + 0x50);
		  uVar1 = unnamed_function_1417
		                    (System_Action_BossInfo_BossAttackOption_BossAttackOptionVariant__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_Boss_View_CaptainTab_BossAttackOptionPickerDialogWindow_ValuePickerOnSelectionChangedEvent__
		             ,0);
		  UI_ValuePicker_ValuePicker___Il2CppFullySharedGenericType___SpinnerOnCurrentSelectedIndexChangedEvent
		            (uVar2,uVar1,
		             Method_UI_ValuePicker_ValuePicker_BossInfo_BossAttackOption_BossAttackOptionVariant__add_SelectionChangedEvent__
		            );
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 0x54) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,
		             Method_Gameplay_Boss_View_CaptainTab_BossAttackOptionPickerDialogWindow_ConfirmButtonClickHandler__
		             ,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar2,uVar1,0);
		  return;
		}
		*/

}
