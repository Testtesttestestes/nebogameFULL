using System;
using Gameplay.Inventory.View.Info.InfoBox;
using Il2CppDummyDll;
using Protocol.Dic;
using UI.Windows;
using UnityEngine;

namespace Gameplay.Duel.View
{
	// Token: 0x02000854 RID: 2132
	[Token(Token = "0x2000854")]
	public class AttackDeclinedDialogWindow : BaseDialogWindow<AttackDeclinedDialogWindow.AttackDeclinedDialogWindowArgs>
	{
		// Token: 0x170009E4 RID: 2532
		// (get) Token: 0x0600322B RID: 12843 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170009E4")]
		public override string WindowId
		{
			[Token(Token = "0x600322B")]
			[Address(RVA = "0x8281", Offset = "0x8281", VA = "0x8281", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600322C RID: 12844 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600322C")]
		[Address(RVA = "0x8282", Offset = "0x8282", VA = "0x8282", Slot = "28")]
		protected override void HandleContent()
		{
		/* --- GHIDRA: HandleContent ---
		undefined4
		Gameplay_Duel_View_AttackDeclinedDialogWindow__HandleContent(undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  int param1_00;
		  int param1_01;
		  undefined4 uVar2;
		  int param1_02;
		  uint uVar3;
		  
		  if (DAT_ram_00a57bc4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Duel_View_AttackDeclinedDialogWindow_AttackDeclinedDialogWindowArgs_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_AttackDeclinedDialogWindow_AttackDeclinedDialogWindowArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_AttackDeclinedDialogWindow_AttackDeclinedDialogWindowArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_AttackDeclinedDialogWindow_AttackDeclinedDialogWindowArgs___Add__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_PopupController_Show_AttackDeclinedDialogWindow___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_16790);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12612);
		    DAT_ram_00a57bc4 = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (
		                        Gameplay_Duel_View_AttackDeclinedDialogWindow_AttackDeclinedDialogWindowArgs_TypeInfo
		                        );
		  Gameplay_Duel_View_AttackDeclinedDialogWindow___ctor(param1_00,param1,param1);
		  param1_02 = *(int *)(param1_00 + 0x24);
		  param1_01 = unnamed_function_1417
		                        (
		                        UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_AttackDeclinedDialogWindow_AttackDeclinedDialogWindowArgs__TypeInfo
		                        );
		  UI_Windows_DialogWindow_DialogWindowArgs___ctor
		            (param1_01,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_AttackDeclinedDialogWindow_AttackDeclinedDialogWindowArgs___ctor__
		            );
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_16790,1,0,1,0,0,0,0);
		  *(undefined4 *)(param1_01 + 8) = uVar2;
		  iVar1 = 
		  Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_AttackDeclinedDialogWindow_AttackDeclinedDialogWindowArgs___Add__
		  ;
		  *(int *)(param1_02 + 0x10) = *(int *)(param1_02 + 0x10) + 1;
		  uVar3 = *(uint *)(param1_02 + 0xc);
		  if (uVar3 < *(uint *)(*(int *)(param1_02 + 8) + 0xc)) {
		    *(uint *)(param1_02 + 0xc) = uVar3 + 1;
		    *(int *)(*(int *)(param1_02 + 8) + uVar3 * 4 + 0x10) = param1_01;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (param1_02,param1_01,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  uVar2 = System_Uri___ctor(0);
		  uVar2 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar2,0);
		  uVar2 = Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		                    (uVar2,StringLiteral_12612,param1_00,
		                     Method_UI_Windows_PopupController_Show_AttackDeclinedDialogWindow___);
		  return uVar2;
		}
		*/

		}

		// Token: 0x0600322D RID: 12845 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600322D")]
		[Address(RVA = "0x8283", Offset = "0x8283", VA = "0x8283")]
		public static AttackDeclinedDialogWindow Show(DuelUserStateFlags[] stateFlags)
		{
		/* --- GHIDRA: Show ---
		void Gameplay_Duel_View_AttackDeclinedDialogWindow__Show(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57bc5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_AttackDeclinedDialogWindow_AttackDeclinedDialogWindowArgs___ctor__
		              );
		    DAT_ram_00a57bc5 = '\x01';
		  }
		  UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_object____ctor
		            (param1,
		             Method_UI_Windows_BaseDialogWindow_AttackDeclinedDialogWindow_AttackDeclinedDialogWindowArgs___ctor__
		            );
		  return;
		}
		*/

			return null;
		}

		// Token: 0x0600322E RID: 12846 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600322E")]
		[Address(RVA = "0x8284", Offset = "0x8284", VA = "0x8284")]
		public AttackDeclinedDialogWindow()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Duel_View_AttackDeclinedDialogWindow___ctor
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a57bc6 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_AttackDeclinedDialogWindow_AttackDeclinedDialogWindowArgs___ctor__
		              );
		    DAT_ram_00a57bc6 = '\x01';
		  }
		  UnityEngine_UIElements_BaseCompositeField___Il2CppFullySharedGenericType__object____Il2CppFullySharedGenericType___UpdateMixedValueContent
		            (param1,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_AttackDeclinedDialogWindow_AttackDeclinedDialogWindowArgs___ctor__
		            );
		  *(undefined4 *)(param1 + 0x2c) = param2;
		  if (DAT_ram_00a57bc7 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_6228);
		    DAT_ram_00a57bc7 = '\x01';
		  }
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar1 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_6228,1,0,1,0,0,0,0);
		  *(undefined4 *)(param1 + 0x18) = uVar1;
		  *(undefined4 *)(param1 + 0x1c) = **(undefined4 **)(DAT_ram_00a66978 + 0x5c);
		  return;
		}
		*/

		}

		// Token: 0x04001B69 RID: 7017
		[Token(Token = "0x4001B69")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Duel/AttackDeclinedDialogWindow";

		// Token: 0x04001B6A RID: 7018
		[Token(Token = "0x4001B6A")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private LoaderValueRowView _rowPrefab;

		// Token: 0x02000855 RID: 2133
		[Token(Token = "0x2000855")]
		public class AttackDeclinedDialogWindowArgs : BaseDialogWindow<AttackDeclinedDialogWindow.AttackDeclinedDialogWindowArgs>.BaseDialogWindowArgs
		{
			// Token: 0x0600322F RID: 12847 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600322F")]
			[Address(RVA = "0x8285", Offset = "0x8285", VA = "0x8285")]
			public AttackDeclinedDialogWindowArgs(DuelUserStateFlags[] stateFlags)
			{
			}

			// Token: 0x06003230 RID: 12848 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003230")]
			[Address(RVA = "0x8286", Offset = "0x8286", VA = "0x8286")]
			private void InitInstance()
			{
			}

			// Token: 0x04001B6B RID: 7019
			[Token(Token = "0x4001B6B")]
			[FieldOffset(Offset = "0x2C")]
			public readonly DuelUserStateFlags[] StateFlags;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_WindowId ---
		void Gameplay_Duel_View_AttackDeclinedDialogWindow__get_WindowId(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int param1_00;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  undefined4 param1_01;
		  int iVar4;
		  ushort local_2;
		  
		  iVar4 = 0;
		  if (DAT_ram_00a57bc3 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_AttackDeclinedDialogWindow_AttackDeclinedDialogWindowArgs__HandleContent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_AttackDeclinedDialogWindow_AttackDeclinedDialogWindowArgs__get_Content__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseWindow_AttackDeclinedDialogWindow_AttackDeclinedDialogWindowArgs__get_WindowArgs__
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_bool___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_LoaderValueRowView___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Data_InfoRows_ValueRow_TypeInfo);
		    DAT_ram_00a57bc3 = '\x01';
		  }
		  UI_Windows_BaseDialogWindow_object___HandleButtons
		            (param1,
		             Method_UI_Windows_BaseDialogWindow_AttackDeclinedDialogWindow_AttackDeclinedDialogWindowArgs__HandleContent__
		            );
		  iVar1 = func_ii_8093(param1,
		                       Method_UI_Windows_BaseWindow_AttackDeclinedDialogWindow_AttackDeclinedDialogWindowArgs__get_WindowArgs__
		                      );
		  iVar1 = *(int *)(iVar1 + 0x2c);
		  if (0 < *(int *)(iVar1 + 0xc)) {
		    do {
		      uVar2 = *(undefined4 *)(iVar1 + iVar4 * 4 + 0x10);
		      uVar3 = *(undefined4 *)(param1 + 0x40);
		      param1_01 = *(undefined4 *)(param1 + 0x50);
		      if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		        func_ii_306000(UnityEngine_Object_TypeInfo);
		      }
		      uVar3 = func_ii_6805(param1_01,uVar3,
		                           Method_UnityEngine_Object_Instantiate_LoaderValueRowView___);
		      param1_00 = unnamed_function_1417(Core_Data_InfoRows_ValueRow_TypeInfo);
		      System_Collections_Generic_List_object____ctor(param1_00,0);
		      uVar2 = Core_Extensions_Dict_DollInfoDicExt__GetFilterIcon(uVar2,0);
		      *(undefined4 *)(param1_00 + 0xc) = uVar2;
		      local_2 = 0;
		      System_Data_SqlTypes_SqlByte__ToSqlInt64(&local_2,0,Method_System_Nullable_bool___ctor__);
		      *(ushort *)(param1_00 + 0x10) = local_2;
		      UI_Requirements_RequirementsView__GetRowPrefab(uVar3,param1_00,0);
		      iVar4 = iVar4 + 1;
		    } while (iVar4 < *(int *)(iVar1 + 0xc));
		  }
		  return;
		}
		*/

}
