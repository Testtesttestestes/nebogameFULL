using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UI.ValuePicker;
using UnityEngine;

namespace UI.Windows
{
	// Token: 0x02000298 RID: 664
	[Token(Token = "0x2000298")]
	public class IntegerValuePickerWindow : BaseDialogWindow<IntegerValuePickerWindow.IntegerValuePickerWindowArgs>
	{
		// Token: 0x1700022E RID: 558
		// (get) Token: 0x06000F93 RID: 3987 RVA: 0x000044E8 File Offset: 0x000026E8
		// (set) Token: 0x06000F94 RID: 3988 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700022E")]
		public int SelectedValue
		{
			[Token(Token = "0x6000F93")]
			[Address(RVA = "0x61BC", Offset = "0x61BC", VA = "0x61BC")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000F94")]
			[Address(RVA = "0x61BD", Offset = "0x61BD", VA = "0x61BD")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700022F RID: 559
		// (get) Token: 0x06000F95 RID: 3989 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700022F")]
		public override string WindowId
		{
			[Token(Token = "0x6000F95")]
			[Address(RVA = "0x61BE", Offset = "0x61BE", VA = "0x61BE", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000F96 RID: 3990 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F96")]
		[Address(RVA = "0x61BF", Offset = "0x61BF", VA = "0x61BF", Slot = "22")]
		protected override void OnShow(IntegerValuePickerWindow.IntegerValuePickerWindowArgs args)
		{
		/* --- GHIDRA: OnShow ---
		void UI_Windows_IntegerValuePickerWindow__OnShow(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a58a64 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_int__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_IntegerValuePickerWindow_IntegerValuePickerWindowArgs__OnClose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_IntegerValuePickerWindow_HandlePickerSelectionChangedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_ValuePicker_ValuePicker_int__remove_SelectionChangedEvent__);
		    DAT_ram_00a58a64 = '\x01';
		  }
		  UI_Windows_BaseDialogWindow_object___HandleTitle
		            (param1,
		             Method_UI_Windows_BaseDialogWindow_IntegerValuePickerWindow_IntegerValuePickerWindowArgs__OnClose__
		            );
		  param1_01 = *(undefined4 *)(param1 + 0x50);
		  param1_00 = unnamed_function_1417(System_Action_int__TypeInfo);
		  System_Action_short___Invoke
		            (param1_00,param1,
		             Method_UI_Windows_IntegerValuePickerWindow_HandlePickerSelectionChangedEvent__,0);
		  UI_ValuePicker_ValuePicker___Il2CppFullySharedGenericType___add_SelectionChangedEvent
		            (param1_01,param1_00,
		             Method_UI_ValuePicker_ValuePicker_int__remove_SelectionChangedEvent__);
		  return;
		}
		*/

		}

		// Token: 0x06000F97 RID: 3991 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F97")]
		[Address(RVA = "0x61C0", Offset = "0x61C0", VA = "0x61C0", Slot = "19")]
		protected override void OnClose()
		{
		/* --- GHIDRA: OnClose ---
		void UI_Windows_IntegerValuePickerWindow__OnClose(int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a58a65 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseWindow_IntegerValuePickerWindow_IntegerValuePickerWindowArgs__get_WindowArgs__
		              );
		    DAT_ram_00a58a65 = '\x01';
		  }
		  *(undefined4 *)(param1 + 0x54) = param2;
		  iVar1 = func_ii_8093(param1,
		                       Method_UI_Windows_BaseWindow_IntegerValuePickerWindow_IntegerValuePickerWindowArgs__get_WindowArgs__
		                      );
		  *(undefined4 *)(iVar1 + 0x30) = param2;
		  return;
		}
		*/

		}

		// Token: 0x06000F98 RID: 3992 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F98")]
		[Address(RVA = "0x61C1", Offset = "0x61C1", VA = "0x61C1")]
		private void HandlePickerSelectionChangedEvent(int value)
		{
		/* --- GHIDRA: HandlePickerSelectionChangedEvent ---
		void UI_Windows_IntegerValuePickerWindow__HandlePickerSelectionChangedEvent
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param2_00;
		  undefined4 *puVar3;
		  undefined4 param2_01;
		  
		  if (DAT_ram_00a58a66 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_IntegerValuePickerWindow_IntegerValuePickerWindowArgs__HandleContent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseWindow_IntegerValuePickerWindow_IntegerValuePickerWindowArgs__get_WindowArgs__
		              );
		    Mono_Security_ASN1__get_Item(&System_Func_int__string__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_IntegerValuePickerWindow___c__HandleContent_b__12_0__);
		    Mono_Security_ASN1__get_Item(&UI_Windows_IntegerValuePickerWindow___c_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UI_ValuePicker_ValuePicker_int__Init__);
		    Mono_Security_ASN1__get_Item(&Method_UI_ValuePicker_ValuePicker_int__ScrollTo__);
		    DAT_ram_00a58a66 = '\x01';
		  }
		  UI_Windows_BaseDialogWindow_object___HandleButtons
		            (param1,
		             Method_UI_Windows_BaseDialogWindow_IntegerValuePickerWindow_IntegerValuePickerWindowArgs__HandleContent__
		            );
		  uVar2 = *(undefined4 *)(param1 + 0x50);
		  iVar1 = func_ii_8093(param1,
		                       Method_UI_Windows_BaseWindow_IntegerValuePickerWindow_IntegerValuePickerWindowArgs__get_WindowArgs__
		                      );
		  param2_00 = *(undefined4 *)(iVar1 + 0x2c);
		  if (*(int *)(UI_Windows_IntegerValuePickerWindow___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UI_Windows_IntegerValuePickerWindow___c_TypeInfo);
		  }
		  puVar3 = *(undefined4 **)(UI_Windows_IntegerValuePickerWindow___c_TypeInfo + 0x5c);
		  iVar1 = puVar3[1];
		  if (iVar1 == 0) {
		    if (*(int *)(UI_Windows_IntegerValuePickerWindow___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UI_Windows_IntegerValuePickerWindow___c_TypeInfo);
		      puVar3 = *(undefined4 **)(UI_Windows_IntegerValuePickerWindow___c_TypeInfo + 0x5c);
		    }
		    param2_01 = *puVar3;
		    iVar1 = unnamed_function_1417(System_Func_int__string__TypeInfo);
		    System_Func_int__InternedString___Invoke
		              (iVar1,param2_01,
		               Method_UI_Windows_IntegerValuePickerWindow___c__HandleContent_b__12_0__,0);
		    *(int *)(*(int *)(UI_Windows_IntegerValuePickerWindow___c_TypeInfo + 0x5c) + 4) = iVar1;
		  }
		  UI_ValuePicker_ValuePicker_int___Awake
		            (uVar2,param2_00,iVar1,Method_UI_ValuePicker_ValuePicker_int__Init__);
		  uVar2 = *(undefined4 *)(param1 + 0x50);
		  iVar1 = func_ii_8093(param1,
		                       Method_UI_Windows_BaseWindow_IntegerValuePickerWindow_IntegerValuePickerWindowArgs__get_WindowArgs__
		                      );
		  UI_ValuePicker_ValuePicker_int___OnDestroy
		            (uVar2,*(undefined4 *)(iVar1 + 0x30),Method_UI_ValuePicker_ValuePicker_int__ScrollTo__);
		  return;
		}
		*/

		}

		// Token: 0x06000F99 RID: 3993 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F99")]
		[Address(RVA = "0x61C2", Offset = "0x61C2", VA = "0x61C2", Slot = "28")]
		protected override void HandleContent()
		{
		/* --- GHIDRA: HandleContent ---
		undefined4 UI_Windows_IntegerValuePickerWindow__HandleContent(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a58a67 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_PopupController_Show_IntegerValuePickerWindow___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12631);
		    DAT_ram_00a58a67 = '\x01';
		  }
		  uVar1 = System_Uri___ctor(0);
		  uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar1,0);
		  uVar1 = Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		                    (uVar1,StringLiteral_12631,param1,
		                     Method_UI_Windows_PopupController_Show_IntegerValuePickerWindow___);
		  return uVar1;
		}
		*/

		}

		// Token: 0x06000F9A RID: 3994 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000F9A")]
		[Address(RVA = "0x61C3", Offset = "0x61C3", VA = "0x61C3")]
		public static IntegerValuePickerWindow Show(IntegerValuePickerWindow.IntegerValuePickerWindowArgs args)
		{
		/* --- GHIDRA: Show ---
		void UI_Windows_IntegerValuePickerWindow__Show(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a58a68 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_IntegerValuePickerWindow_IntegerValuePickerWindowArgs___ctor__
		              );
		    DAT_ram_00a58a68 = '\x01';
		  }
		  UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_object____ctor
		            (param1,
		             Method_UI_Windows_BaseDialogWindow_IntegerValuePickerWindow_IntegerValuePickerWindowArgs___ctor__
		            );
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06000F9B RID: 3995 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F9B")]
		[Address(RVA = "0x61C4", Offset = "0x61C4", VA = "0x61C4")]
		public IntegerValuePickerWindow()
		{
		}

		// Token: 0x040007E9 RID: 2025
		[Token(Token = "0x40007E9")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private IntegerValuePicker _picker;

		// Token: 0x040007EB RID: 2027
		[Token(Token = "0x40007EB")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/IntegerValuePickerWindow";

		// Token: 0x02000299 RID: 665
		[Token(Token = "0x2000299")]
		public class IntegerValuePickerWindowArgs : BaseDialogWindow<IntegerValuePickerWindow.IntegerValuePickerWindowArgs>.BaseDialogWindowArgs
		{
			// Token: 0x17000230 RID: 560
			// (get) Token: 0x06000F9C RID: 3996 RVA: 0x00004500 File Offset: 0x00002700
			// (set) Token: 0x06000F9D RID: 3997 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000230")]
			public int SelectedValue
			{
				[Token(Token = "0x6000F9C")]
				[Address(RVA = "0x61C5", Offset = "0x61C5", VA = "0x61C5")]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[Token(Token = "0x6000F9D")]
				[Address(RVA = "0x61C6", Offset = "0x61C6", VA = "0x61C6")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x06000F9E RID: 3998 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000F9E")]
			[Address(RVA = "0x61C7", Offset = "0x61C7", VA = "0x61C7")]
			public IntegerValuePickerWindowArgs(string selectButtonLabel)
			{
			}

			// Token: 0x040007EC RID: 2028
			[Token(Token = "0x40007EC")]
			[FieldOffset(Offset = "0x2C")]
			public IList<int> Values;

			// Token: 0x040007EE RID: 2030
			[Token(Token = "0x40007EE")]
			[FieldOffset(Offset = "0x34")]
			public BaseDialogWindow<IntegerValuePickerWindow.IntegerValuePickerWindowArgs>.BaseDialogWindowArgs.DialogWindowButton.ButtonInvoker<int>.ButtonCallbackDelegate SelectCallback;

			// Token: 0x040007EF RID: 2031
			[Token(Token = "0x40007EF")]
			[FieldOffset(Offset = "0x38")]
			public readonly string SelectButtonLabel;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_SelectedValue ---
		undefined4
		UI_Windows_IntegerValuePickerWindow__set_SelectedValue(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a58a62 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_12631);
		    DAT_ram_00a58a62 = '\x01';
		  }
		  return StringLiteral_12631;
		}
		*/


		/* --- GHIDRA: get_WindowId ---
		void UI_Windows_IntegerValuePickerWindow__get_WindowId
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a58a63 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_int__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_IntegerValuePickerWindow_IntegerValuePickerWindowArgs__OnShow__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_IntegerValuePickerWindow_HandlePickerSelectionChangedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_ValuePicker_ValuePicker_int__add_SelectionChangedEvent__);
		    DAT_ram_00a58a63 = '\x01';
		  }
		  UI_Windows_BaseDialogWindow_object___OnDestroy
		            (param1,param2,
		             Method_UI_Windows_BaseDialogWindow_IntegerValuePickerWindow_IntegerValuePickerWindowArgs__OnShow__
		            );
		  param1_01 = *(undefined4 *)(param1 + 0x50);
		  param1_00 = unnamed_function_1417(System_Action_int__TypeInfo);
		  System_Action_short___Invoke
		            (param1_00,param1,
		             Method_UI_Windows_IntegerValuePickerWindow_HandlePickerSelectionChangedEvent__,0);
		  UI_ValuePicker_ValuePicker___Il2CppFullySharedGenericType___SpinnerOnCurrentSelectedIndexChangedEvent
		            (param1_01,param1_00,Method_UI_ValuePicker_ValuePicker_int__add_SelectionChangedEvent__)
		  ;
		  return;
		}
		*/

}
