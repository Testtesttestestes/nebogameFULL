using System;
using Core.Data;
using Core.Gameplay.Managers;
using Gameplay.Inventory.View;
using Il2CppDummyDll;
using UI.Windows;
using UnityEngine;

namespace Gameplay.Auchan.View
{
	// Token: 0x02000C8E RID: 3214
	[Token(Token = "0x2000C8E")]
	public class NoTradeAccountDialogWindow : BaseDialogWindow<NoTradeAccountDialogWindow.NoTradeAccountDialogWindowArgs>
	{
		// Token: 0x17000FDC RID: 4060
		// (get) Token: 0x06004E54 RID: 20052 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000FDC")]
		public override string WindowId
		{
			[Token(Token = "0x6004E54")]
			[Address(RVA = "0x9C86", Offset = "0x9C86", VA = "0x9C86", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x06004E55 RID: 20053 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004E55")]
		[Address(RVA = "0x9C87", Offset = "0x9C87", VA = "0x9C87")]
		public static NoTradeAccountDialogWindow Show(UserData user, AccountsManager accountsManager, params ArtifactData[] artifacts)
		{
		/* --- GHIDRA: Show ---
		void Gameplay_Auchan_View_NoTradeAccountDialogWindow__Show(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  int *param1_00;
		  undefined4 uVar3;
		  undefined4 param2_00;
		  undefined4 param1_01;
		  int iVar4;
		  undefined8 local_18;
		  undefined4 local_10;
		  int local_c;
		  int local_8;
		  undefined4 local_4;
		  
		  iVar4 = 0;
		  if (DAT_ram_00a59862 == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Dic_ArtikulMenuActionDic_Types_Actions___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_NoTradeAccountDialogWindow_NoTradeAccountDialogWindowArgs__HandleContent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_NoTradeAccountDialogWindow_NoTradeAccountDialogWindowArgs__get_Content__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseWindow_NoTradeAccountDialogWindow_NoTradeAccountDialogWindowArgs__get_WindowArgs__
		              );
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_ArtifactView___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a59862 = '\x01';
		  }
		  UI_Windows_BaseDialogWindow_object___HandleButtons
		            (param1,
		             Method_UI_Windows_BaseDialogWindow_NoTradeAccountDialogWindow_NoTradeAccountDialogWindowArgs__HandleContent__
		            );
		  iVar1 = func_ii_8093(param1,
		                       Method_UI_Windows_BaseWindow_NoTradeAccountDialogWindow_NoTradeAccountDialogWindowArgs__get_WindowArgs__
		                      );
		  iVar1 = *(int *)(*(int *)(iVar1 + 0x2c) + 0xc);
		  if (0 < iVar1) {
		    do {
		      iVar2 = func_ii_8093(param1,
		                           Method_UI_Windows_BaseWindow_NoTradeAccountDialogWindow_NoTradeAccountDialogWindowArgs__get_WindowArgs__
		                          );
		      uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x2c) + iVar4 * 4 + 0x10);
		      param2_00 = *(undefined4 *)(param1 + 0x40);
		      param1_01 = *(undefined4 *)(param1 + 0x50);
		      if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		        func_ii_306000(UnityEngine_Object_TypeInfo);
		      }
		      param1_00 = (int *)func_ii_6805(param1_01,param2_00,
		                                      Method_UnityEngine_Object_Instantiate_ArtifactView___);
		      (**(code **)((ulonglong)*(uint *)(*param1_00 + 0x138) * 4))
		                (param1_00,uVar3,*(undefined4 *)(*param1_00 + 0x13c));
		      iVar2 = param1_00[0x14];
		      local_8 = Mono_Security_ASN1Convert__ToOid
		                          (Protocol_Dic_ArtikulMenuActionDic_Types_Actions___TypeInfo,1);
		      *(undefined4 *)(local_8 + 0x10) = 5;
		      local_4 = 0;
		      local_10 = 0;
		      local_18 = CONCAT44(local_8,iVar2);
		      local_c = iVar2;
		      func_ii_7564(param1_00,&local_18,0);
		      iVar4 = iVar4 + 1;
		    } while (iVar4 != iVar1);
		  }
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06004E56 RID: 20054 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E56")]
		[Address(RVA = "0x9C88", Offset = "0x9C88", VA = "0x9C88", Slot = "28")]
		protected override void HandleContent()
		{
		/* --- GHIDRA: HandleContent ---
		void Gameplay_Auchan_View_NoTradeAccountDialogWindow__HandleContent
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a59863 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_NoTradeAccountDialogWindow_NoTradeAccountDialogWindowArgs___ctor__
		              );
		    DAT_ram_00a59863 = '\x01';
		  }
		  UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_object____ctor
		            (param1,
		             Method_UI_Windows_BaseDialogWindow_NoTradeAccountDialogWindow_NoTradeAccountDialogWindowArgs___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06004E57 RID: 20055 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E57")]
		[Address(RVA = "0x9C89", Offset = "0x9C89", VA = "0x9C89")]
		public NoTradeAccountDialogWindow()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Auchan_View_NoTradeAccountDialogWindow___ctor
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  if (DAT_ram_00a59864 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_NoTradeAccountDialogWindow_NoTradeAccountDialogWindowArgs___ctor__
		              );
		    DAT_ram_00a59864 = '\x01';
		  }
		  UnityEngine_UIElements_BaseCompositeField___Il2CppFullySharedGenericType__object____Il2CppFullySharedGenericType___UpdateMixedValueContent
		            (param1,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_NoTradeAccountDialogWindow_NoTradeAccountDialogWindowArgs___ctor__
		            );
		  *(undefined4 *)(param1 + 0x30) = param3;
		  *(undefined4 *)(param1 + 0x2c) = param2;
		  return;
		}
		*/

		}

		// Token: 0x04002ACF RID: 10959
		[Token(Token = "0x4002ACF")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Auchan/NoTradeAccountDialogWindow";

		// Token: 0x04002AD0 RID: 10960
		[Token(Token = "0x4002AD0")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private ArtifactView _artifactViewPrefab;

		// Token: 0x02000C8F RID: 3215
		[Token(Token = "0x2000C8F")]
		public class NoTradeAccountDialogWindowArgs : BaseDialogWindow<NoTradeAccountDialogWindow.NoTradeAccountDialogWindowArgs>.BaseDialogWindowArgs
		{
			// Token: 0x06004E58 RID: 20056 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004E58")]
			[Address(RVA = "0x9C8A", Offset = "0x9C8A", VA = "0x9C8A")]
			public NoTradeAccountDialogWindowArgs(ArtifactData[] artifacts, UserData user)
			{
			}

			// Token: 0x04002AD1 RID: 10961
			[Token(Token = "0x4002AD1")]
			[FieldOffset(Offset = "0x2C")]
			public ArtifactData[] Artifacts;

			// Token: 0x04002AD2 RID: 10962
			[Token(Token = "0x4002AD2")]
			[FieldOffset(Offset = "0x30")]
			public UserData User;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_WindowId ---
		undefined4
		Gameplay_Auchan_View_NoTradeAccountDialogWindow__get_WindowId
		          (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int iVar1;
		  int param1_00;
		  undefined4 uVar2;
		  int param1_01;
		  int iVar3;
		  int param1_02;
		  uint uVar4;
		  
		  if (DAT_ram_00a59861 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_NoTradeAccountDialogWindow_NoTradeAccountDialogWindowArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_NoTradeAccountDialogWindow_NoTradeAccountDialogWindowArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_NoTradeAccountDialogWindow_NoTradeAccountDialogWindowArgs__set_Callback__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_NoTradeAccountDialogWindow_NoTradeAccountDialogWindowArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_NoTradeAccountDialogWindow_NoTradeAccountDialogWindowArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_NoTradeAccountDialogWindow_NoTradeAccountDialogWindowArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_NoTradeAccountDialogWindow_NoTradeAccountDialogWindowArgs___Add__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Auchan_View_NoTradeAccountDialogWindow_NoTradeAccountDialogWindowArgs_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_PopupController_Show_NoTradeAccountDialogWindow___);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Auchan_View_NoTradeAccountDialogWindow___c__DisplayClass4_0__Show_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Auchan_View_NoTradeAccountDialogWindow___c__DisplayClass4_0_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2491);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12567);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2490);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3708);
		    DAT_ram_00a59861 = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (Gameplay_Auchan_View_NoTradeAccountDialogWindow___c__DisplayClass4_0_TypeInfo);
		  *(undefined4 *)(iVar1 + 8) = param2;
		  param1_00 = unnamed_function_1417
		                        (
		                        Gameplay_Auchan_View_NoTradeAccountDialogWindow_NoTradeAccountDialogWindowArgs_TypeInfo
		                        );
		  if (DAT_ram_00a59864 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_NoTradeAccountDialogWindow_NoTradeAccountDialogWindowArgs___ctor__
		              );
		    DAT_ram_00a59864 = '\x01';
		  }
		  UnityEngine_UIElements_BaseCompositeField___Il2CppFullySharedGenericType__object____Il2CppFullySharedGenericType___UpdateMixedValueContent
		            (param1_00,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_NoTradeAccountDialogWindow_NoTradeAccountDialogWindowArgs___ctor__
		            );
		  *(undefined4 *)(param1_00 + 0x30) = param1;
		  *(undefined4 *)(param1_00 + 0x2c) = param3;
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_2491,1,0,1,0,0,0,0);
		  *(undefined4 *)(param1_00 + 0x18) = uVar2;
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_2490,1,0,1,0,0,0,0);
		  *(undefined4 *)(param1_00 + 0x1c) = uVar2;
		  param1_02 = *(int *)(param1_00 + 0x24);
		  param1_01 = unnamed_function_1417
		                        (
		                        UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_NoTradeAccountDialogWindow_NoTradeAccountDialogWindowArgs__TypeInfo
		                        );
		  UI_Windows_DialogWindow_DialogWindowArgs___ctor
		            (param1_01,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_NoTradeAccountDialogWindow_NoTradeAccountDialogWindowArgs___ctor__
		            );
		  uVar2 = func_ii_7508(StringLiteral_3708,1,0,1,0,0,0,0);
		  *(undefined4 *)(param1_01 + 8) = uVar2;
		  iVar3 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_NoTradeAccountDialogWindow_NoTradeAccountDialogWindowArgs__TypeInfo
		                    );
		  uVar2 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_NoTradeAccountDialogWindow_NoTradeAccountDialogWindowArgs__TypeInfo
		                    );
		  UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_object____ctor
		            (uVar2,iVar1,
		             Method_Gameplay_Auchan_View_NoTradeAccountDialogWindow___c__DisplayClass4_0__Show_b__0__
		             ,0);
		  *(undefined4 *)(iVar3 + 8) = uVar2;
		  *(int *)(param1_01 + 0x14) = iVar3;
		  iVar1 = 
		  Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_NoTradeAccountDialogWindow_NoTradeAccountDialogWindowArgs___Add__
		  ;
		  *(int *)(param1_02 + 0x10) = *(int *)(param1_02 + 0x10) + 1;
		  uVar4 = *(uint *)(param1_02 + 0xc);
		  if (uVar4 < *(uint *)(*(int *)(param1_02 + 8) + 0xc)) {
		    *(uint *)(param1_02 + 0xc) = uVar4 + 1;
		    *(int *)(*(int *)(param1_02 + 8) + uVar4 * 4 + 0x10) = param1_01;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (param1_02,param1_01,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  uVar2 = System_Uri___ctor(0);
		  uVar2 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar2,0);
		  uVar2 = Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		                    (uVar2,StringLiteral_12567,param1_00,
		                     Method_UI_Windows_PopupController_Show_NoTradeAccountDialogWindow___);
		  return uVar2;
		}
		*/

}
