using System;
using Gameplay.Bank.Model;
using Il2CppDummyDll;
using UI.Windows;
using UnityEngine;

namespace Gameplay.Bank.View
{
	// Token: 0x02000C33 RID: 3123
	[Token(Token = "0x2000C33")]
	public class BankConfirmBuyOptionWindow : BaseDialogWindow<BankConfirmBuyOptionWindow.BankConfirmBuyOptionWindowArgs>
	{
		// Token: 0x17000F59 RID: 3929
		// (get) Token: 0x06004C28 RID: 19496 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000F59")]
		public override string WindowId
		{
			[Token(Token = "0x6004C28")]
			[Address(RVA = "0x9A6C", Offset = "0x9A6C", VA = "0x9A6C", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x06004C29 RID: 19497 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004C29")]
		[Address(RVA = "0x9A6D", Offset = "0x9A6D", VA = "0x9A6D")]
		public static BankConfirmBuyOptionWindow Show(BankOptionData bankOptionData, Action<BankOptionData> resultCallback)
		{
		/* --- GHIDRA: Show ---
		void Gameplay_Bank_View_BankConfirmBuyOptionWindow__Show(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int *piVar2;
		  int iVar3;
		  uint *puVar4;
		  undefined4 uVar5;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5975a == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBankOptionView__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Bank_View_BankConfirmBuyOptionWindow_BankOptionViewOnBuyButtonClickEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BankConfirmBuyOptionWindow_BankConfirmBuyOptionWindowArgs__HandleContent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BankConfirmBuyOptionWindow_BankConfirmBuyOptionWindowArgs__get_Content__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseWindow_BankConfirmBuyOptionWindow_BankConfirmBuyOptionWindowArgs__get_WindowArgs__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Bank_View_IBankOptionView_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_BankOptionView___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a5975a = '\x01';
		  }
		  UI_Windows_BaseDialogWindow_object___HandleButtons
		            (param1,
		             Method_UI_Windows_BaseDialogWindow_BankConfirmBuyOptionWindow_BankConfirmBuyOptionWindowArgs__HandleContent__
		            );
		  uVar5 = *(undefined4 *)(param1 + 0x40);
		  param1_00 = *(undefined4 *)(param1 + 0x50);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  uVar1 = 0;
		  piVar2 = (int *)func_ii_6805(param1_00,uVar5,
		                               Method_UnityEngine_Object_Instantiate_BankOptionView___);
		  *(int **)(param1 + 0x54) = piVar2;
		  iVar3 = func_ii_8093(param1,
		                       Method_UI_Windows_BaseWindow_BankConfirmBuyOptionWindow_BankConfirmBuyOptionWindowArgs__get_WindowArgs__
		                      );
		  uVar5 = *(undefined4 *)(iVar3 + 0x2c);
		  iVar3 = *piVar2;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Gameplay_Bank_View_IBankOptionView_TypeInfo ==
		          *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 200);
		        goto code_r0x81062c06;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar2,Gameplay_Bank_View_IBankOptionView_TypeInfo,1);
		code_r0x81062c06:
		  (**(code **)((ulonglong)*puVar4 * 4))(piVar2,uVar5,puVar4[1]);
		  piVar2 = *(int **)(param1 + 0x54);
		  uVar1 = 0;
		  uVar5 = unnamed_function_1417(System_Action_IBankOptionView__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar5,param1,
		             Method_Gameplay_Bank_View_BankConfirmBuyOptionWindow_BankOptionViewOnBuyButtonClickEvent__
		             ,0);
		  iVar3 = *piVar2;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Gameplay_Bank_View_IBankOptionView_TypeInfo ==
		          *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0xd0);
		        goto code_r0x81062ca8;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar2,Gameplay_Bank_View_IBankOptionView_TypeInfo,2);
		code_r0x81062ca8:
		  (**(code **)((ulonglong)*puVar4 * 4))(piVar2,uVar5,puVar4[1]);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06004C2A RID: 19498 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C2A")]
		[Address(RVA = "0x9A6E", Offset = "0x9A6E", VA = "0x9A6E", Slot = "28")]
		protected override void HandleContent()
		{
		/* --- GHIDRA: HandleContent ---
		void Gameplay_Bank_View_BankConfirmBuyOptionWindow__HandleContent
		               (undefined4 param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  int iVar5;
		  
		  if (DAT_ram_00a5975b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseWindow_BankConfirmBuyOptionWindow_BankConfirmBuyOptionWindowArgs__get_WindowArgs__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Bank_View_IBankOptionView_TypeInfo);
		    DAT_ram_00a5975b = '\x01';
		  }
		  iVar2 = func_ii_8093(param1,
		                       Method_UI_Windows_BaseWindow_BankConfirmBuyOptionWindow_BankConfirmBuyOptionWindowArgs__get_WindowArgs__
		                      );
		  iVar2 = *(int *)(iVar2 + 0x30);
		  if (iVar2 != 0) {
		    uVar1 = 0;
		    iVar5 = *param2;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      do {
		        if (Gameplay_Bank_View_IBankOptionView_TypeInfo ==
		            *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(iVar5 + *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x81062d65;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(param2,Gameplay_Bank_View_IBankOptionView_TypeInfo,0);
		code_r0x81062d65:
		    uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(param2,puVar3[1]);
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		              (*(undefined4 *)(iVar2 + 0x20),uVar4,*(undefined4 *)(iVar2 + 0x14));
		  }
		  System_ComponentModel_BindingList___Il2CppFullySharedGenericType___OnAddingNew(param1,2,0);
		  return;
		}
		*/

		}

		// Token: 0x06004C2B RID: 19499 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C2B")]
		[Address(RVA = "0x9A6F", Offset = "0x9A6F", VA = "0x9A6F")]
		private void BankOptionViewOnBuyButtonClickEvent(IBankOptionView bankOptionView)
		{
		/* --- GHIDRA: BankOptionViewOnBuyButtonClickEvent ---
		void Gameplay_Bank_View_BankConfirmBuyOptionWindow__BankOptionViewOnBuyButtonClickEvent
		               (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 param1_00;
		  uint *puVar2;
		  int *param1_01;
		  int iVar3;
		  
		  if (DAT_ram_00a5975c == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBankOptionView__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Bank_View_BankConfirmBuyOptionWindow_BankOptionViewOnBuyButtonClickEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BankConfirmBuyOptionWindow_BankConfirmBuyOptionWindowArgs__OnClose__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Bank_View_IBankOptionView_TypeInfo);
		    DAT_ram_00a5975c = '\x01';
		  }
		  UI_Windows_BaseDialogWindow_object___HandleTitle
		            (param1,
		             Method_UI_Windows_BaseDialogWindow_BankConfirmBuyOptionWindow_BankConfirmBuyOptionWindowArgs__OnClose__
		            );
		  param1_01 = *(int **)(param1 + 0x54);
		  if (param1_01 != (int *)0x0) {
		    uVar1 = 0;
		    param1_00 = unnamed_function_1417(System_Action_IBankOptionView__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (param1_00,param1,
		               Method_Gameplay_Bank_View_BankConfirmBuyOptionWindow_BankOptionViewOnBuyButtonClickEvent__
		               ,0);
		    iVar3 = *param1_01;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      do {
		        if (Gameplay_Bank_View_IBankOptionView_TypeInfo ==
		            *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0xd8);
		          goto code_r0x81062e73;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param1_01,Gameplay_Bank_View_IBankOptionView_TypeInfo,3);
		code_r0x81062e73:
		    (**(code **)((ulonglong)*puVar2 * 4))(param1_01,param1_00,puVar2[1]);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004C2C RID: 19500 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C2C")]
		[Address(RVA = "0x9A70", Offset = "0x9A70", VA = "0x9A70", Slot = "19")]
		protected override void OnClose()
		{
		/* --- GHIDRA: OnClose ---
		void Gameplay_Bank_View_BankConfirmBuyOptionWindow__OnClose(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5975d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BankConfirmBuyOptionWindow_BankConfirmBuyOptionWindowArgs___ctor__
		              );
		    DAT_ram_00a5975d = '\x01';
		  }
		  UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_object____ctor
		            (param1,
		             Method_UI_Windows_BaseDialogWindow_BankConfirmBuyOptionWindow_BankConfirmBuyOptionWindowArgs___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06004C2D RID: 19501 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C2D")]
		[Address(RVA = "0x9A71", Offset = "0x9A71", VA = "0x9A71")]
		public BankConfirmBuyOptionWindow()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Bank_View_BankConfirmBuyOptionWindow___ctor(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5975e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_BankConfirmBuyOptionWindow_BankConfirmBuyOptionWindowArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3534);
		    DAT_ram_00a5975e = '\x01';
		  }
		  UnityEngine_UIElements_BaseCompositeField___Il2CppFullySharedGenericType__object____Il2CppFullySharedGenericType___UpdateMixedValueContent
		            (param1,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_BankConfirmBuyOptionWindow_BankConfirmBuyOptionWindowArgs___ctor__
		            );
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar1 = func_ii_7508(StringLiteral_3534,1,0,1,0,0,0,0);
		  *(undefined4 *)(param1 + 0x1c) = 0;
		  *(undefined4 *)(param1 + 0x18) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x04002977 RID: 10615
		[Token(Token = "0x4002977")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Bank/BankConfirmBuyOptionWindow";

		// Token: 0x04002978 RID: 10616
		[Token(Token = "0x4002978")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private BankOptionView _bankOptionViewPrefab;

		// Token: 0x04002979 RID: 10617
		[Token(Token = "0x4002979")]
		[FieldOffset(Offset = "0x54")]
		private IBankOptionView _bankOptionView;

		// Token: 0x02000C34 RID: 3124
		[Token(Token = "0x2000C34")]
		public class BankConfirmBuyOptionWindowArgs : BaseDialogWindow<BankConfirmBuyOptionWindow.BankConfirmBuyOptionWindowArgs>.BaseDialogWindowArgs
		{
			// Token: 0x06004C2E RID: 19502 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004C2E")]
			[Address(RVA = "0x9A72", Offset = "0x9A72", VA = "0x9A72")]
			public BankConfirmBuyOptionWindowArgs()
			{
			}

			// Token: 0x0400297A RID: 10618
			[Token(Token = "0x400297A")]
			[FieldOffset(Offset = "0x2C")]
			public BankOptionData BankOptionData;

			// Token: 0x0400297B RID: 10619
			[Token(Token = "0x400297B")]
			[FieldOffset(Offset = "0x30")]
			public Action<BankOptionData> ResultCallback;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_WindowId ---
		undefined4
		Gameplay_Bank_View_BankConfirmBuyOptionWindow__get_WindowId
		          (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int param1_00;
		  
		  if (DAT_ram_00a59759 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Bank_View_BankConfirmBuyOptionWindow_BankConfirmBuyOptionWindowArgs_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_PopupController_Show_BankConfirmBuyOptionWindow___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12568);
		    DAT_ram_00a59759 = '\x01';
		  }
		  uVar1 = System_Uri___ctor(0);
		  uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar1,0);
		  param1_00 = unnamed_function_1417
		                        (
		                        Gameplay_Bank_View_BankConfirmBuyOptionWindow_BankConfirmBuyOptionWindowArgs_TypeInfo
		                        );
		  Gameplay_Bank_View_BankConfirmBuyOptionWindow___ctor(param1_00,param1_00);
		  *(undefined4 *)(param1_00 + 0x30) = param2;
		  *(undefined4 *)(param1_00 + 0x2c) = param1;
		  *(undefined1 *)(param1_00 + 0xc) = 0;
		  uVar1 = Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		                    (uVar1,StringLiteral_12568,param1_00,
		                     Method_UI_Windows_PopupController_Show_BankConfirmBuyOptionWindow___);
		  return uVar1;
		}
		*/

}
