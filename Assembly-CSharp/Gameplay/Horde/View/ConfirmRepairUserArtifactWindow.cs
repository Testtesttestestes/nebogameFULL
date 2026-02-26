using System;
using Core.Data;
using Gameplay.Inventory.View;
using Il2CppDummyDll;
using UI.Windows;
using UnityEngine;

namespace Gameplay.Horde.View
{
	// Token: 0x020006F7 RID: 1783
	[Token(Token = "0x20006F7")]
	public class ConfirmRepairUserArtifactWindow : BaseDialogWindow<ConfirmRepairUserArtifactWindow.RepairUserArtifactWindowArgs>
	{
		// Token: 0x17000819 RID: 2073
		// (get) Token: 0x06002AB3 RID: 10931 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000819")]
		public override string WindowId
		{
			[Token(Token = "0x6002AB3")]
			[Address(RVA = "0x7B4E", Offset = "0x7B4E", VA = "0x7B4E", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002AB4 RID: 10932 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002AB4")]
		[Address(RVA = "0x7B4F", Offset = "0x7B4F", VA = "0x7B4F")]
		public static ConfirmRepairUserArtifactWindow Show(UserData user, Action<ArtifactData[]> resultCallback, params ArtifactData[] artifacts)
		{
		/* --- GHIDRA: Show ---
		void Gameplay_Horde_View_ConfirmRepairUserArtifactWindow__Show(int param1,undefined4 param2)
		
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
		  if (DAT_ram_00a5a1ef == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Dic_ArtikulMenuActionDic_Types_Actions___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_ConfirmRepairUserArtifactWindow_RepairUserArtifactWindowArgs__HandleContent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_ConfirmRepairUserArtifactWindow_RepairUserArtifactWindowArgs__get_Content__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseWindow_ConfirmRepairUserArtifactWindow_RepairUserArtifactWindowArgs__get_WindowArgs__
		              );
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_ArtifactView___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a5a1ef = '\x01';
		  }
		  UI_Windows_BaseDialogWindow_object___HandleButtons
		            (param1,
		             Method_UI_Windows_BaseDialogWindow_ConfirmRepairUserArtifactWindow_RepairUserArtifactWindowArgs__HandleContent__
		            );
		  iVar1 = func_ii_8093(param1,
		                       Method_UI_Windows_BaseWindow_ConfirmRepairUserArtifactWindow_RepairUserArtifactWindowArgs__get_WindowArgs__
		                      );
		  iVar1 = *(int *)(*(int *)(iVar1 + 0x2c) + 0xc);
		  if (0 < iVar1) {
		    do {
		      iVar2 = func_ii_8093(param1,
		                           Method_UI_Windows_BaseWindow_ConfirmRepairUserArtifactWindow_RepairUserArtifactWindowArgs__get_WindowArgs__
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

		// Token: 0x06002AB5 RID: 10933 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AB5")]
		[Address(RVA = "0x7B50", Offset = "0x7B50", VA = "0x7B50", Slot = "28")]
		protected override void HandleContent()
		{
		/* --- GHIDRA: HandleContent ---
		void Gameplay_Horde_View_ConfirmRepairUserArtifactWindow__HandleContent
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5a1f0 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_ConfirmRepairUserArtifactWindow_RepairUserArtifactWindowArgs___ctor__
		              );
		    DAT_ram_00a5a1f0 = '\x01';
		  }
		  UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_object____ctor
		            (param1,
		             Method_UI_Windows_BaseDialogWindow_ConfirmRepairUserArtifactWindow_RepairUserArtifactWindowArgs___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06002AB6 RID: 10934 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AB6")]
		[Address(RVA = "0x7B51", Offset = "0x7B51", VA = "0x7B51")]
		public ConfirmRepairUserArtifactWindow()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Horde_View_ConfirmRepairUserArtifactWindow___ctor
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  if (DAT_ram_00a5a1f1 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_ConfirmRepairUserArtifactWindow_RepairUserArtifactWindowArgs___ctor__
		              );
		    DAT_ram_00a5a1f1 = '\x01';
		  }
		  UnityEngine_UIElements_BaseCompositeField___Il2CppFullySharedGenericType__object____Il2CppFullySharedGenericType___UpdateMixedValueContent
		            (param1,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_ConfirmRepairUserArtifactWindow_RepairUserArtifactWindowArgs___ctor__
		            );
		  *(undefined4 *)(param1 + 0x30) = param3;
		  *(undefined4 *)(param1 + 0x2c) = param2;
		  return;
		}
		*/

		}

		// Token: 0x0400174F RID: 5967
		[Token(Token = "0x400174F")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Horde/ConfirmRepairUserArtifactWindow";

		// Token: 0x04001750 RID: 5968
		[Token(Token = "0x4001750")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private ArtifactView _artifactViewPrefab;

		// Token: 0x020006F8 RID: 1784
		[Token(Token = "0x20006F8")]
		public class RepairUserArtifactWindowArgs : BaseDialogWindow<ConfirmRepairUserArtifactWindow.RepairUserArtifactWindowArgs>.BaseDialogWindowArgs
		{
			// Token: 0x06002AB7 RID: 10935 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002AB7")]
			[Address(RVA = "0x7B52", Offset = "0x7B52", VA = "0x7B52")]
			public RepairUserArtifactWindowArgs(ArtifactData[] artifacts, UserData user)
			{
			}

			// Token: 0x04001751 RID: 5969
			[Token(Token = "0x4001751")]
			[FieldOffset(Offset = "0x2C")]
			public ArtifactData[] Artifacts;

			// Token: 0x04001752 RID: 5970
			[Token(Token = "0x4001752")]
			[FieldOffset(Offset = "0x30")]
			public UserData User;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_WindowId ---
		undefined4
		Gameplay_Horde_View_ConfirmRepairUserArtifactWindow__get_WindowId
		          (undefined4 param1,undefined4 param2,int param3,undefined4 param4)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  int iVar5;
		  int iVar6;
		  uint *puVar7;
		  int iVar8;
		  int *param1_00;
		  int iVar9;
		  uint uVar10;
		  undefined4 *puVar11;
		  
		  if (DAT_ram_00a5a1ee == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_ArtikulDic__uint__get_Data__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_ConfirmRepairUserArtifactWindow_RepairUserArtifactWindowArgs__ArtifactData____TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_ConfirmRepairUserArtifactWindow_RepairUserArtifactWindowArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ConfirmRepairUserArtifactWindow_RepairUserArtifactWindowArgs__ArtifactData_____ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ConfirmRepairUserArtifactWindow_RepairUserArtifactWindowArgs__ArtifactData____TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ConfirmRepairUserArtifactWindow_RepairUserArtifactWindowArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ConfirmRepairUserArtifactWindow_RepairUserArtifactWindowArgs__set_Callback__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ConfirmRepairUserArtifactWindow_RepairUserArtifactWindowArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ConfirmRepairUserArtifactWindow_RepairUserArtifactWindowArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ConfirmRepairUserArtifactWindow_RepairUserArtifactWindowArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ConfirmRepairUserArtifactWindow_RepairUserArtifactWindowArgs___Add__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_PopupController_Show_ConfirmRepairUserArtifactWindow___);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_PriceHolder_ConfirmRepairUserArtifactWindow_RepairUserArtifactWindowArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_PriceHolder_ConfirmRepairUserArtifactWindow_RepairUserArtifactWindowArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Horde_View_ConfirmRepairUserArtifactWindow_RepairUserArtifactWindowArgs_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Horde_View_ConfirmRepairUserArtifactWindow___c__Show_b__4_1__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Horde_View_ConfirmRepairUserArtifactWindow___c__DisplayClass4_0__Show_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Horde_View_ConfirmRepairUserArtifactWindow___c__DisplayClass4_0_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Horde_View_ConfirmRepairUserArtifactWindow___c_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12630);
		    Mono_Security_ASN1__get_Item(&StringLiteral_8720);
		    Mono_Security_ASN1__get_Item(&StringLiteral_10754);
		    Mono_Security_ASN1__get_Item(&StringLiteral_8717);
		    Mono_Security_ASN1__get_Item(&StringLiteral_9119);
		    DAT_ram_00a5a1ee = '\x01';
		  }
		  iVar2 = unnamed_function_1417
		                    (
		                    Gameplay_Horde_View_ConfirmRepairUserArtifactWindow___c__DisplayClass4_0_TypeInfo
		                    );
		  *(undefined4 *)(iVar2 + 8) = param2;
		  if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_Money_TypeInfo);
		  }
		  iVar1 = 0;
		  uVar3 = Core_Money_Money__FromMoney(0);
		  if (0 < *(int *)(param3 + 0xc)) {
		    do {
		      uVar4 = *(undefined4 *)
		               (*(int *)(*(int *)(*(int *)(param3 + iVar1 * 4 + 0x10) + 8) + 0x10) + 0x60);
		      if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_Money_Money_TypeInfo);
		      }
		      uVar4 = Core_Money_Money__op_Explicit(uVar4,0);
		      uVar3 = Core_Money_Money__CreateEmpty(uVar3,uVar4,0);
		      iVar1 = iVar1 + 1;
		    } while (iVar1 < *(int *)(param3 + 0xc));
		  }
		  iVar1 = unnamed_function_1417
		                    (
		                    Gameplay_Horde_View_ConfirmRepairUserArtifactWindow_RepairUserArtifactWindowArgs_TypeInfo
		                    );
		  if (DAT_ram_00a5a1f1 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_ConfirmRepairUserArtifactWindow_RepairUserArtifactWindowArgs___ctor__
		              );
		    DAT_ram_00a5a1f1 = '\x01';
		  }
		  UnityEngine_UIElements_BaseCompositeField___Il2CppFullySharedGenericType__object____Il2CppFullySharedGenericType___UpdateMixedValueContent
		            (iVar1,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_ConfirmRepairUserArtifactWindow_RepairUserArtifactWindowArgs___ctor__
		            );
		  *(undefined4 *)(iVar1 + 0x30) = param1;
		  *(int *)(iVar1 + 0x2c) = param3;
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar4 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_10754,1,0,1,0,0,0,0);
		  *(undefined4 *)(iVar1 + 0x18) = uVar4;
		  uVar4 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_8720,1,0,1,0,0,0,0);
		  *(undefined4 *)(iVar1 + 0x1c) = uVar4;
		  iVar8 = *(int *)(iVar1 + 0x24);
		  iVar5 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ConfirmRepairUserArtifactWindow_RepairUserArtifactWindowArgs__TypeInfo
		                    );
		  UI_Windows_DialogWindow_DialogWindowArgs___ctor
		            (iVar5,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ConfirmRepairUserArtifactWindow_RepairUserArtifactWindowArgs___ctor__
		            );
		  uVar4 = func_ii_7508(StringLiteral_9119,1,0,1,0,0,0,0);
		  *(undefined4 *)(iVar5 + 8) = uVar4;
		  iVar6 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_PriceHolder_ConfirmRepairUserArtifactWindow_RepairUserArtifactWindowArgs__TypeInfo
		                    );
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar9 = *param1_00;
		  if (*(ushort *)(iVar9 + 0xb6) != 0) {
		    uVar10 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar9 + 0x58) + uVar10 * 8)) {
		        puVar7 = (uint *)(*(int *)(*(int *)(iVar9 + 0x58) + uVar10 * 8 + 4) * 8 + iVar9 + 0x140);
		        goto code_r0x811e546c;
		      }
		      uVar10 = uVar10 + 1;
		    } while (*(ushort *)(iVar9 + 0xb6) != uVar10);
		  }
		  puVar7 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x811e546c:
		  uVar4 = (**(code **)((ulonglong)*puVar7 * 4))(param1_00,puVar7[1]);
		  uVar4 = func_ii_7112(uVar4,0);
		  *(undefined4 *)(iVar6 + 8) = uVar3;
		  *(undefined4 *)(iVar6 + 0xc) = uVar4;
		  *(int *)(iVar5 + 0x10) = iVar6;
		  iVar6 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ConfirmRepairUserArtifactWindow_RepairUserArtifactWindowArgs__ArtifactData____TypeInfo
		                    );
		  *(int *)(iVar6 + 0xc) = param3;
		  uVar3 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_ConfirmRepairUserArtifactWindow_RepairUserArtifactWindowArgs__ArtifactData____TypeInfo
		                    );
		  UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_object__Int32Enum___Invoke
		            (uVar3,iVar2,
		             Method_Gameplay_Horde_View_ConfirmRepairUserArtifactWindow___c__DisplayClass4_0__Show_b__0__
		             ,0);
		  *(undefined4 *)(iVar6 + 0x10) = uVar3;
		  *(int *)(iVar5 + 0x14) = iVar6;
		  iVar2 = 
		  Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ConfirmRepairUserArtifactWindow_RepairUserArtifactWindowArgs___Add__
		  ;
		  *(int *)(iVar8 + 0x10) = *(int *)(iVar8 + 0x10) + 1;
		  uVar10 = *(uint *)(iVar8 + 0xc);
		  if (uVar10 < *(uint *)(*(int *)(iVar8 + 8) + 0xc)) {
		    *(uint *)(iVar8 + 0xc) = uVar10 + 1;
		    *(int *)(*(int *)(iVar8 + 8) + uVar10 * 4 + 0x10) = iVar5;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar8,iVar5,*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		  }
		  iVar6 = *(int *)(iVar1 + 0x24);
		  iVar2 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ConfirmRepairUserArtifactWindow_RepairUserArtifactWindowArgs__TypeInfo
		                    );
		  UI_Windows_DialogWindow_DialogWindowArgs___ctor
		            (iVar2,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ConfirmRepairUserArtifactWindow_RepairUserArtifactWindowArgs___ctor__
		            );
		  uVar3 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_8717,1,0,1,0,0,0,0);
		  *(undefined4 *)(iVar2 + 8) = uVar3;
		  iVar5 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ConfirmRepairUserArtifactWindow_RepairUserArtifactWindowArgs__TypeInfo
		                    );
		  if (*(int *)(Gameplay_Horde_View_ConfirmRepairUserArtifactWindow___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Horde_View_ConfirmRepairUserArtifactWindow___c_TypeInfo);
		  }
		  puVar11 = *(undefined4 **)
		             (Gameplay_Horde_View_ConfirmRepairUserArtifactWindow___c_TypeInfo + 0x5c);
		  iVar8 = puVar11[1];
		  if (iVar8 == 0) {
		    if (*(int *)(Gameplay_Horde_View_ConfirmRepairUserArtifactWindow___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_Horde_View_ConfirmRepairUserArtifactWindow___c_TypeInfo);
		      puVar11 = *(undefined4 **)
		                 (Gameplay_Horde_View_ConfirmRepairUserArtifactWindow___c_TypeInfo + 0x5c);
		    }
		    uVar3 = *puVar11;
		    iVar8 = unnamed_function_1417
		                      (
		                      UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_ConfirmRepairUserArtifactWindow_RepairUserArtifactWindowArgs__TypeInfo
		                      );
		    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_object____ctor
		              (iVar8,uVar3,
		               Method_Gameplay_Horde_View_ConfirmRepairUserArtifactWindow___c__Show_b__4_1__,0);
		    *(int *)(*(int *)(Gameplay_Horde_View_ConfirmRepairUserArtifactWindow___c_TypeInfo + 0x5c) + 4)
		         = iVar8;
		  }
		  *(int *)(iVar5 + 8) = iVar8;
		  *(int *)(iVar2 + 0x14) = iVar5;
		  iVar5 = 
		  Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ConfirmRepairUserArtifactWindow_RepairUserArtifactWindowArgs___Add__
		  ;
		  *(int *)(iVar6 + 0x10) = *(int *)(iVar6 + 0x10) + 1;
		  uVar10 = *(uint *)(iVar6 + 0xc);
		  if (uVar10 < *(uint *)(*(int *)(iVar6 + 8) + 0xc)) {
		    *(uint *)(iVar6 + 0xc) = uVar10 + 1;
		    *(int *)(*(int *)(iVar6 + 8) + uVar10 * 4 + 0x10) = iVar2;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar6,iVar2,*(undefined4 *)(*(int *)(*(int *)(iVar5 + 0x10) + 0x60) + 0x38));
		  }
		  uVar3 = System_Uri___ctor(0);
		  uVar3 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar3,0);
		  uVar3 = Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		                    (uVar3,StringLiteral_12630,iVar1,
		                     Method_UI_Windows_PopupController_Show_ConfirmRepairUserArtifactWindow___);
		  return uVar3;
		}
		*/

}
