using System;
using Core.Data;
using Gameplay.Inventory.View;
using Il2CppDummyDll;
using UI.Windows;
using UnityEngine;

namespace Gameplay.Horde.View
{
	// Token: 0x020006F4 RID: 1780
	[Token(Token = "0x20006F4")]
	public class ConfirmChangeUserEquipmentWindow : BaseDialogWindow<ConfirmChangeUserEquipmentWindow.ConfirmChangeUserEquipmentWindowArgs>
	{
		// Token: 0x17000818 RID: 2072
		// (get) Token: 0x06002AAB RID: 10923 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000818")]
		public override string WindowId
		{
			[Token(Token = "0x6002AAB")]
			[Address(RVA = "0x7B46", Offset = "0x7B46", VA = "0x7B46", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002AAC RID: 10924 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002AAC")]
		[Address(RVA = "0x7B47", Offset = "0x7B47", VA = "0x7B47")]
		public static ConfirmChangeUserEquipmentWindow Show(params ArtifactData[] artifacts)
		{
		/* --- GHIDRA: Show ---
		void Gameplay_Horde_View_ConfirmChangeUserEquipmentWindow__Show(int param1,undefined4 param2)
		
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
		  if (DAT_ram_00a5a1e8 == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Dic_ArtikulMenuActionDic_Types_Actions___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_ConfirmChangeUserEquipmentWindow_ConfirmChangeUserEquipmentWindowArgs__HandleContent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_ConfirmChangeUserEquipmentWindow_ConfirmChangeUserEquipmentWindowArgs__get_Content__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseWindow_ConfirmChangeUserEquipmentWindow_ConfirmChangeUserEquipmentWindowArgs__get_WindowArgs__
		              );
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_ArtifactView___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a5a1e8 = '\x01';
		  }
		  UI_Windows_BaseDialogWindow_object___HandleButtons
		            (param1,
		             Method_UI_Windows_BaseDialogWindow_ConfirmChangeUserEquipmentWindow_ConfirmChangeUserEquipmentWindowArgs__HandleContent__
		            );
		  iVar1 = func_ii_8093(param1,
		                       Method_UI_Windows_BaseWindow_ConfirmChangeUserEquipmentWindow_ConfirmChangeUserEquipmentWindowArgs__get_WindowArgs__
		                      );
		  iVar1 = *(int *)(*(int *)(iVar1 + 0x2c) + 0xc);
		  if (0 < iVar1) {
		    do {
		      iVar2 = func_ii_8093(param1,
		                           Method_UI_Windows_BaseWindow_ConfirmChangeUserEquipmentWindow_ConfirmChangeUserEquipmentWindowArgs__get_WindowArgs__
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

		// Token: 0x06002AAD RID: 10925 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AAD")]
		[Address(RVA = "0x7B48", Offset = "0x7B48", VA = "0x7B48", Slot = "28")]
		protected override void HandleContent()
		{
		/* --- GHIDRA: HandleContent ---
		void Gameplay_Horde_View_ConfirmChangeUserEquipmentWindow__HandleContent
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5a1e9 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_ConfirmChangeUserEquipmentWindow_ConfirmChangeUserEquipmentWindowArgs___ctor__
		              );
		    DAT_ram_00a5a1e9 = '\x01';
		  }
		  UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_object____ctor
		            (param1,
		             Method_UI_Windows_BaseDialogWindow_ConfirmChangeUserEquipmentWindow_ConfirmChangeUserEquipmentWindowArgs___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06002AAE RID: 10926 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AAE")]
		[Address(RVA = "0x7B49", Offset = "0x7B49", VA = "0x7B49")]
		public ConfirmChangeUserEquipmentWindow()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Horde_View_ConfirmChangeUserEquipmentWindow___ctor
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a5a1ea == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_ConfirmChangeUserEquipmentWindow_ConfirmChangeUserEquipmentWindowArgs___ctor__
		              );
		    DAT_ram_00a5a1ea = '\x01';
		  }
		  UnityEngine_UIElements_BaseCompositeField___Il2CppFullySharedGenericType__object____Il2CppFullySharedGenericType___UpdateMixedValueContent
		            (param1,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_ConfirmChangeUserEquipmentWindow_ConfirmChangeUserEquipmentWindowArgs___ctor__
		            );
		  *(undefined4 *)(param1 + 0x2c) = param2;
		  return;
		}
		*/

		}

		// Token: 0x0400174A RID: 5962
		[Token(Token = "0x400174A")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Horde/ConfirmChangeUserEquipmentWindow";

		// Token: 0x0400174B RID: 5963
		[Token(Token = "0x400174B")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private ArtifactView _artifactViewPrefab;

		// Token: 0x020006F5 RID: 1781
		[Token(Token = "0x20006F5")]
		public class ConfirmChangeUserEquipmentWindowArgs : BaseDialogWindow<ConfirmChangeUserEquipmentWindow.ConfirmChangeUserEquipmentWindowArgs>.BaseDialogWindowArgs
		{
			// Token: 0x06002AAF RID: 10927 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002AAF")]
			[Address(RVA = "0x7B4A", Offset = "0x7B4A", VA = "0x7B4A")]
			public ConfirmChangeUserEquipmentWindowArgs(ArtifactData[] artifacts)
			{
			}

			// Token: 0x0400174C RID: 5964
			[Token(Token = "0x400174C")]
			[FieldOffset(Offset = "0x2C")]
			public ArtifactData[] Artifacts;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_WindowId ---
		undefined4
		Gameplay_Horde_View_ConfirmChangeUserEquipmentWindow__get_WindowId
		          (undefined4 param1,undefined4 param2)
		
		{
		  int param1_00;
		  undefined4 uVar1;
		  int param1_01;
		  int iVar2;
		  int param1_02;
		  undefined4 *puVar3;
		  int param1_03;
		  uint uVar4;
		  
		  if (DAT_ram_00a5a1e7 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_ConfirmChangeUserEquipmentWindow_ConfirmChangeUserEquipmentWindowArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ConfirmChangeUserEquipmentWindow_ConfirmChangeUserEquipmentWindowArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ConfirmChangeUserEquipmentWindow_ConfirmChangeUserEquipmentWindowArgs__set_Callback__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ConfirmChangeUserEquipmentWindow_ConfirmChangeUserEquipmentWindowArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Horde_View_ConfirmChangeUserEquipmentWindow_ConfirmChangeUserEquipmentWindowArgs_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ConfirmChangeUserEquipmentWindow_ConfirmChangeUserEquipmentWindowArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ConfirmChangeUserEquipmentWindow_ConfirmChangeUserEquipmentWindowArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ConfirmChangeUserEquipmentWindow_ConfirmChangeUserEquipmentWindowArgs___Add__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_PopupController_Show_ConfirmChangeUserEquipmentWindow___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Horde_View_ConfirmChangeUserEquipmentWindow___c__Show_b__4_0__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Horde_View_ConfirmChangeUserEquipmentWindow___c_TypeInfo)
		    ;
		    Mono_Security_ASN1__get_Item(&StringLiteral_10754);
		    Mono_Security_ASN1__get_Item(&StringLiteral_8717);
		    Mono_Security_ASN1__get_Item(&StringLiteral_8718);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12629);
		    DAT_ram_00a5a1e7 = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (
		                        Gameplay_Horde_View_ConfirmChangeUserEquipmentWindow_ConfirmChangeUserEquipmentWindowArgs_TypeInfo
		                        );
		  if (DAT_ram_00a5a1ea == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_ConfirmChangeUserEquipmentWindow_ConfirmChangeUserEquipmentWindowArgs___ctor__
		              );
		    DAT_ram_00a5a1ea = '\x01';
		  }
		  UnityEngine_UIElements_BaseCompositeField___Il2CppFullySharedGenericType__object____Il2CppFullySharedGenericType___UpdateMixedValueContent
		            (param1_00,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_ConfirmChangeUserEquipmentWindow_ConfirmChangeUserEquipmentWindowArgs___ctor__
		            );
		  *(undefined4 *)(param1_00 + 0x2c) = param1;
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar1 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_10754,1,0,1,0,0,0,0);
		  *(undefined4 *)(param1_00 + 0x18) = uVar1;
		  uVar1 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_8718,1,0,1,0,0,0,0);
		  *(undefined4 *)(param1_00 + 0x1c) = uVar1;
		  param1_02 = *(int *)(param1_00 + 0x24);
		  param1_01 = unnamed_function_1417
		                        (
		                        UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ConfirmChangeUserEquipmentWindow_ConfirmChangeUserEquipmentWindowArgs__TypeInfo
		                        );
		  UI_Windows_DialogWindow_DialogWindowArgs___ctor
		            (param1_01,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ConfirmChangeUserEquipmentWindow_ConfirmChangeUserEquipmentWindowArgs___ctor__
		            );
		  uVar1 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_8717,1,0,1,0,0,0,0);
		  *(undefined4 *)(param1_01 + 8) = uVar1;
		  iVar2 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ConfirmChangeUserEquipmentWindow_ConfirmChangeUserEquipmentWindowArgs__TypeInfo
		                    );
		  if (*(int *)(Gameplay_Horde_View_ConfirmChangeUserEquipmentWindow___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Horde_View_ConfirmChangeUserEquipmentWindow___c_TypeInfo);
		  }
		  puVar3 = *(undefined4 **)
		            (Gameplay_Horde_View_ConfirmChangeUserEquipmentWindow___c_TypeInfo + 0x5c);
		  param1_03 = puVar3[1];
		  if (param1_03 == 0) {
		    if (*(int *)(Gameplay_Horde_View_ConfirmChangeUserEquipmentWindow___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_Horde_View_ConfirmChangeUserEquipmentWindow___c_TypeInfo);
		      puVar3 = *(undefined4 **)
		                (Gameplay_Horde_View_ConfirmChangeUserEquipmentWindow___c_TypeInfo + 0x5c);
		    }
		    uVar1 = *puVar3;
		    param1_03 = unnamed_function_1417
		                          (
		                          UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_ConfirmChangeUserEquipmentWindow_ConfirmChangeUserEquipmentWindowArgs__TypeInfo
		                          );
		    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_object____ctor
		              (param1_03,uVar1,
		               Method_Gameplay_Horde_View_ConfirmChangeUserEquipmentWindow___c__Show_b__4_0__,0);
		    *(int *)(*(int *)(Gameplay_Horde_View_ConfirmChangeUserEquipmentWindow___c_TypeInfo + 0x5c) + 4)
		         = param1_03;
		  }
		  *(int *)(iVar2 + 8) = param1_03;
		  *(int *)(param1_01 + 0x14) = iVar2;
		  iVar2 = 
		  Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ConfirmChangeUserEquipmentWindow_ConfirmChangeUserEquipmentWindowArgs___Add__
		  ;
		  *(int *)(param1_02 + 0x10) = *(int *)(param1_02 + 0x10) + 1;
		  uVar4 = *(uint *)(param1_02 + 0xc);
		  if (uVar4 < *(uint *)(*(int *)(param1_02 + 8) + 0xc)) {
		    *(uint *)(param1_02 + 0xc) = uVar4 + 1;
		    *(int *)(*(int *)(param1_02 + 8) + uVar4 * 4 + 0x10) = param1_01;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (param1_02,param1_01,*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		  }
		  uVar1 = System_Uri___ctor(0);
		  uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar1,0);
		  uVar1 = Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		                    (uVar1,StringLiteral_12629,param1_00,
		                     Method_UI_Windows_PopupController_Show_ConfirmChangeUserEquipmentWindow___);
		  return uVar1;
		}
		*/

}
