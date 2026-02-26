using System;
using Core.Data;
using Gameplay.Inventory.View;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace UI.Windows
{
	// Token: 0x0200028B RID: 651
	[Token(Token = "0x200028B")]
	public class ConfirmDeleteCraftSchemeWindow : BaseDialogWindow<ConfirmDeleteCraftSchemeWindow.ConfirmDeleteCraftSchemeWindowArgs>
	{
		// Token: 0x17000220 RID: 544
		// (get) Token: 0x06000F5A RID: 3930 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000220")]
		public override string WindowId
		{
			[Token(Token = "0x6000F5A")]
			[Address(RVA = "0x6185", Offset = "0x6185", VA = "0x6185", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000F5B RID: 3931 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F5B")]
		[Address(RVA = "0x6186", Offset = "0x6186", VA = "0x6186", Slot = "28")]
		protected override void HandleContent()
		{
		/* --- GHIDRA: HandleContent ---
		undefined4
		UI_Windows_ConfirmDeleteCraftSchemeWindow__HandleContent
		          (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  int param1_00;
		  int iVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int iVar5;
		  uint uVar6;
		  
		  if (DAT_ram_00a63a01 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_ConfirmDeleteCraftSchemeWindow_ConfirmDeleteCraftSchemeWindowArgs__CraftSchemeData__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ConfirmDeleteCraftSchemeWindow_ConfirmDeleteCraftSchemeWindowArgs__CraftSchemeData___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ConfirmDeleteCraftSchemeWindow_ConfirmDeleteCraftSchemeWindowArgs__CraftSchemeData__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_ConfirmDeleteCraftSchemeWindow_ConfirmDeleteCraftSchemeWindowArgs_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ConfirmDeleteCraftSchemeWindow_ConfirmDeleteCraftSchemeWindowArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ConfirmDeleteCraftSchemeWindow_ConfirmDeleteCraftSchemeWindowArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ConfirmDeleteCraftSchemeWindow_ConfirmDeleteCraftSchemeWindowArgs___Add__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_PopupController_Show_ConfirmDeleteCraftSchemeWindow___);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_ConfirmDeleteCraftSchemeWindow___c__DisplayClass7_0__Show_b__0__);
		    Mono_Security_ASN1__get_Item
		              (&UI_Windows_ConfirmDeleteCraftSchemeWindow___c__DisplayClass7_0_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12604);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4107);
		    Mono_Security_ASN1__get_Item(&StringLiteral_6122);
		    DAT_ram_00a63a01 = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (UI_Windows_ConfirmDeleteCraftSchemeWindow___c__DisplayClass7_0_TypeInfo);
		  *(undefined4 *)(iVar1 + 8) = param2;
		  param1_00 = unnamed_function_1417
		                        (
		                        UI_Windows_ConfirmDeleteCraftSchemeWindow_ConfirmDeleteCraftSchemeWindowArgs_TypeInfo
		                        );
		  if (DAT_ram_00a63a03 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_ConfirmDeleteCraftSchemeWindow_ConfirmDeleteCraftSchemeWindowArgs___ctor__
		              );
		    DAT_ram_00a63a03 = '\x01';
		  }
		  UnityEngine_UIElements_BaseCompositeField___Il2CppFullySharedGenericType__object____Il2CppFullySharedGenericType___UpdateMixedValueContent
		            (param1_00,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_ConfirmDeleteCraftSchemeWindow_ConfirmDeleteCraftSchemeWindowArgs___ctor__
		            );
		  *(undefined4 *)(param1_00 + 0x2c) = param1;
		  UI_Windows_ConfirmDeleteCraftSchemeWindow_ConfirmDeleteCraftSchemeWindowArgs___ctor
		            (param1_00,param1_00);
		  iVar5 = *(int *)(param1_00 + 0x24);
		  iVar2 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ConfirmDeleteCraftSchemeWindow_ConfirmDeleteCraftSchemeWindowArgs__TypeInfo
		                    );
		  UI_Windows_DialogWindow_DialogWindowArgs___ctor
		            (iVar2,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ConfirmDeleteCraftSchemeWindow_ConfirmDeleteCraftSchemeWindowArgs___ctor__
		            );
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar3 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_6122,1,0,1,0,0,0,0);
		  *(undefined4 *)(iVar2 + 8) = uVar3;
		  iVar4 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ConfirmDeleteCraftSchemeWindow_ConfirmDeleteCraftSchemeWindowArgs__CraftSchemeData__TypeInfo
		                    );
		  *(undefined4 *)(iVar4 + 0xc) = param1;
		  uVar3 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_ConfirmDeleteCraftSchemeWindow_ConfirmDeleteCraftSchemeWindowArgs__CraftSchemeData__TypeInfo
		                    );
		  UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_object__Int32Enum___Invoke
		            (uVar3,iVar1,
		             Method_UI_Windows_ConfirmDeleteCraftSchemeWindow___c__DisplayClass7_0__Show_b__0__,0);
		  *(undefined4 *)(iVar4 + 0x10) = uVar3;
		  *(int *)(iVar2 + 0x14) = iVar4;
		  iVar1 = 
		  Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ConfirmDeleteCraftSchemeWindow_ConfirmDeleteCraftSchemeWindowArgs___Add__
		  ;
		  *(int *)(iVar5 + 0x10) = *(int *)(iVar5 + 0x10) + 1;
		  uVar6 = *(uint *)(iVar5 + 0xc);
		  if (uVar6 < *(uint *)(*(int *)(iVar5 + 8) + 0xc)) {
		    *(uint *)(iVar5 + 0xc) = uVar6 + 1;
		    *(int *)(*(int *)(iVar5 + 8) + uVar6 * 4 + 0x10) = iVar2;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar5,iVar2,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  iVar5 = *(int *)(param1_00 + 0x24);
		  iVar2 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ConfirmDeleteCraftSchemeWindow_ConfirmDeleteCraftSchemeWindowArgs__TypeInfo
		                    );
		  UI_Windows_DialogWindow_DialogWindowArgs___ctor
		            (iVar2,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ConfirmDeleteCraftSchemeWindow_ConfirmDeleteCraftSchemeWindowArgs___ctor__
		            );
		  uVar3 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4107,1,0,1,0,0,0,0);
		  *(undefined4 *)(iVar2 + 8) = uVar3;
		  iVar1 = 
		  Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ConfirmDeleteCraftSchemeWindow_ConfirmDeleteCraftSchemeWindowArgs___Add__
		  ;
		  *(int *)(iVar5 + 0x10) = *(int *)(iVar5 + 0x10) + 1;
		  uVar6 = *(uint *)(iVar5 + 0xc);
		  if (uVar6 < *(uint *)(*(int *)(iVar5 + 8) + 0xc)) {
		    *(uint *)(iVar5 + 0xc) = uVar6 + 1;
		    *(int *)(*(int *)(iVar5 + 8) + uVar6 * 4 + 0x10) = iVar2;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar5,iVar2,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  uVar3 = System_Uri___ctor(0);
		  uVar3 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar3,0);
		  uVar3 = Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		                    (uVar3,StringLiteral_12604,param1_00,
		                     Method_UI_Windows_PopupController_Show_ConfirmDeleteCraftSchemeWindow___);
		  return uVar3;
		}
		*/

		}

		// Token: 0x06000F5C RID: 3932 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000F5C")]
		[Address(RVA = "0x6187", Offset = "0x6187", VA = "0x6187")]
		public static ConfirmDeleteCraftSchemeWindow Show(CraftSchemeData craftScheme, Action<CraftSchemeData> resultCallback)
		{
		/* --- GHIDRA: Show ---
		void UI_Windows_ConfirmDeleteCraftSchemeWindow__Show(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a63a02 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_ConfirmDeleteCraftSchemeWindow_ConfirmDeleteCraftSchemeWindowArgs___ctor__
		              );
		    DAT_ram_00a63a02 = '\x01';
		  }
		  UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_object____ctor
		            (param1,
		             Method_UI_Windows_BaseDialogWindow_ConfirmDeleteCraftSchemeWindow_ConfirmDeleteCraftSchemeWindowArgs___ctor__
		            );
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06000F5D RID: 3933 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F5D")]
		[Address(RVA = "0x6188", Offset = "0x6188", VA = "0x6188")]
		public ConfirmDeleteCraftSchemeWindow()
		{
		/* --- GHIDRA: .ctor ---
		void UI_Windows_ConfirmDeleteCraftSchemeWindow___ctor
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a63a03 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_ConfirmDeleteCraftSchemeWindow_ConfirmDeleteCraftSchemeWindowArgs___ctor__
		              );
		    DAT_ram_00a63a03 = '\x01';
		  }
		  UnityEngine_UIElements_BaseCompositeField___Il2CppFullySharedGenericType__object____Il2CppFullySharedGenericType___UpdateMixedValueContent
		            (param1,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_ConfirmDeleteCraftSchemeWindow_ConfirmDeleteCraftSchemeWindowArgs___ctor__
		            );
		  *(undefined4 *)(param1 + 0x2c) = param2;
		  UI_Windows_ConfirmDeleteCraftSchemeWindow_ConfirmDeleteCraftSchemeWindowArgs___ctor(param1,param1)
		  ;
		  return;
		}
		*/

		}

		// Token: 0x040007CE RID: 1998
		[Token(Token = "0x40007CE")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Craft/ConfirmDeleteCraftSchemeWindow";

		// Token: 0x040007CF RID: 1999
		[Token(Token = "0x40007CF")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private ArtikulView _artifactViewPrefab;

		// Token: 0x040007D0 RID: 2000
		[Token(Token = "0x40007D0")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private TextMeshProUGUI _quantity;

		// Token: 0x0200028C RID: 652
		[Token(Token = "0x200028C")]
		public class ConfirmDeleteCraftSchemeWindowArgs : BaseDialogWindow<ConfirmDeleteCraftSchemeWindow.ConfirmDeleteCraftSchemeWindowArgs>.BaseDialogWindowArgs
		{
			// Token: 0x06000F5E RID: 3934 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000F5E")]
			[Address(RVA = "0x6189", Offset = "0x6189", VA = "0x6189")]
			public ConfirmDeleteCraftSchemeWindowArgs(CraftSchemeData craftScheme)
			{
			}

			// Token: 0x06000F5F RID: 3935 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000F5F")]
			[Address(RVA = "0x618A", Offset = "0x618A", VA = "0x618A")]
			private void InitInstance()
			{
			}

			// Token: 0x040007D1 RID: 2001
			[Token(Token = "0x40007D1")]
			[FieldOffset(Offset = "0x2C")]
			public readonly CraftSchemeData CraftScheme;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_WindowId ---
		void UI_Windows_ConfirmDeleteCraftSchemeWindow__get_WindowId(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int *piVar3;
		  undefined4 param1_00;
		  int iVar4;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a63a00 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_ConfirmDeleteCraftSchemeWindow_ConfirmDeleteCraftSchemeWindowArgs__HandleContent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseWindow_ConfirmDeleteCraftSchemeWindow_ConfirmDeleteCraftSchemeWindowArgs__get_WindowArgs__
		              );
		    DAT_ram_00a63a00 = '\x01';
		  }
		  UI_Windows_BaseDialogWindow_object___HandleButtons
		            (param1,
		             Method_UI_Windows_BaseDialogWindow_ConfirmDeleteCraftSchemeWindow_ConfirmDeleteCraftSchemeWindowArgs__HandleContent__
		            );
		  piVar3 = *(int **)(param1 + 0x50);
		  iVar1 = func_ii_8093(param1,
		                       Method_UI_Windows_BaseWindow_ConfirmDeleteCraftSchemeWindow_ConfirmDeleteCraftSchemeWindowArgs__get_WindowArgs__
		                      );
		  iVar4 = *piVar3;
		  (**(code **)((ulonglong)*(uint *)(iVar4 + 0x138) * 4))
		            (piVar3,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x2c) + 0xc) + 0x10),
		             *(undefined4 *)(iVar4 + 0x13c));
		  param1_00 = *(undefined4 *)(param1 + 0x54);
		  iVar1 = func_ii_8093(param1,
		                       Method_UI_Windows_BaseWindow_ConfirmDeleteCraftSchemeWindow_ConfirmDeleteCraftSchemeWindowArgs__get_WindowArgs__
		                      );
		  local_4 = *(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x2c) + 8) + 0x10);
		  uVar2 = Protocol_Combat_ProtoPlayerActionEvt___ctor(&local_4,0);
		  UnityEngine_Component__GetComponentInChildren_object_(param1_00,uVar2,0);
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x54),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar2,1,0);
		  return;
		}
		*/

}
