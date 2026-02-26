using System;
using System.Runtime.CompilerServices;
using Gameplay.AccountLinker;
using Gameplay.AccountLinker.ProgressSaver.Controller;
using Gameplay.AccountLinker.ProgressSaver.Model;
using Gameplay.UserInterface.View;
using Il2CppDummyDll;
using UI.Windows;

namespace Core.Gameplay.Managers
{
	// Token: 0x02001173 RID: 4467
	[Token(Token = "0x2001173")]
	public class ProgressSaverManager : IGameManager, IBaseManager
	{
		// Token: 0x14000292 RID: 658
		// (add) Token: 0x0600698B RID: 27019 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600698C RID: 27020 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000292")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x600698B")]
			[Address(RVA = "0xB4AB", Offset = "0xB4AB", VA = "0xB4AB", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600698C")]
			[Address(RVA = "0xB4AC", Offset = "0xB4AC", VA = "0xB4AC", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000293 RID: 659
		// (add) Token: 0x0600698D RID: 27021 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600698E RID: 27022 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000293")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x600698D")]
			[Address(RVA = "0xB4AD", Offset = "0xB4AD", VA = "0xB4AD", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600698E")]
			[Address(RVA = "0xB4AE", Offset = "0xB4AE", VA = "0xB4AE", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x0600698F RID: 27023 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600698F")]
		[Address(RVA = "0xB4AF", Offset = "0xB4AF", VA = "0xB4AF")]
		public ProgressSaverManager(IGame game)
		{
		/* --- GHIDRA: <ShowAccountLinkDialogWindow>b__19_0 ---
		undefined4
		Core_Gameplay_Managers_ProgressSaverManager___ShowAccountLinkDialogWindow_b__19_0
		          (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a63818 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_12865);
		    DAT_ram_00a63818 = '\x01';
		  }
		  return StringLiteral_12865;
		}
		*/

		/* --- GHIDRA: .cctor ---
		void Core_Gameplay_Managers_ProgressSaverManager___cctor
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  Core_Gameplay_Managers_ProgressSaverManager__get_Name(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x17001598 RID: 5528
		// (get) Token: 0x06006990 RID: 27024 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001598")]
		public ProgressSaverController Controller
		{
			[Token(Token = "0x6006990")]
			[Address(RVA = "0xB4B0", Offset = "0xB4B0", VA = "0xB4B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006991 RID: 27025 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006991")]
		[Address(RVA = "0xB4B1", Offset = "0xB4B1", VA = "0xB4B1", Slot = "8")]
		public void Init()
		{
		/* --- GHIDRA: Init ---
		void Core_Gameplay_Managers_ProgressSaverManager__Init(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  MVC_AbstractController__Run(*(undefined4 *)(param1 + 0x14),0);
		  MVC_AbstractController__Run(*(undefined4 *)(param1 + 0x18),0);
		  iVar1 = **(int **)(param1 + 0x18);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xe8) * 4))
		            (*(int **)(param1 + 0x18),*(undefined4 *)(iVar1 + 0xec));
		  iVar1 = **(int **)(param1 + 0x10);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xe8) * 4))
		            (*(int **)(param1 + 0x10),*(undefined4 *)(iVar1 + 0xec));
		  iVar1 = **(int **)(param1 + 0x14);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xe8) * 4))
		            (*(int **)(param1 + 0x14),*(undefined4 *)(iVar1 + 0xec));
		  *(undefined4 *)(param1 + 0x18) = 0;
		  *(undefined8 *)(param1 + 0x10) = 0;
		  iVar1 = *(int *)(param1 + 0xc);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		            (*(undefined4 *)(iVar1 + 0x20),param1,*(undefined4 *)(iVar1 + 0x14));
		  return;
		}
		*/

		}

		// Token: 0x06006992 RID: 27026 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006992")]
		[Address(RVA = "0xB4B2", Offset = "0xB4B2", VA = "0xB4B2", Slot = "9")]
		public void Deinit()
		{
		/* --- GHIDRA: Deinit ---
		undefined4 Core_Gameplay_Managers_ProgressSaverManager__Deinit(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a63813 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_12786);
		    DAT_ram_00a63813 = '\x01';
		  }
		  return StringLiteral_12786;
		}
		*/

		}

		// Token: 0x17001599 RID: 5529
		// (get) Token: 0x06006993 RID: 27027 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001599")]
		public string Name
		{
			[Token(Token = "0x6006993")]
			[Address(RVA = "0xB4B3", Offset = "0xB4B3", VA = "0xB4B3", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006994 RID: 27028 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006994")]
		[Address(RVA = "0xB4B4", Offset = "0xB4B4", VA = "0xB4B4")]
		private void ShowProgressSaverWindow()
		{
		/* --- GHIDRA: ShowProgressSaverWindow ---
		undefined4
		Core_Gameplay_Managers_ProgressSaverManager__ShowProgressSaverWindow
		          (undefined4 param1,undefined4 param2)
		
		{
		  int param1_00;
		  undefined4 uVar1;
		  int param1_01;
		  int iVar2;
		  int iVar3;
		  uint uVar4;
		  
		  if (DAT_ram_00a63815 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_DialogWindow_DialogWindowArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_DialogWindow_DialogWindowArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_DialogWindow_DialogWindowArgs__set_Callback__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_DialogWindow_DialogWindowArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&UI_Windows_DialogWindow_DialogWindowArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___Add__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs____ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_ProgressSaverManager__ShowAccountLinkDialogWindow_b__19_0__
		              );
		    Mono_Security_ASN1__get_Item(&StringLiteral_3532);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4107);
		    Mono_Security_ASN1__get_Item(&StringLiteral_9094);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28790);
		    DAT_ram_00a63815 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(UI_Windows_DialogWindow_DialogWindowArgs_TypeInfo);
		  func_ii_8625(param1_00,0);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar1 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_9094,1,0,1,0,0,0,0);
		  *(undefined4 *)(param1_00 + 0x18) = uVar1;
		  uVar1 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_3532,1,0,1,0,0,0,0);
		  *(undefined4 *)(param1_00 + 0x1c) = uVar1;
		  param1_01 = unnamed_function_1417
		                        (
		                        System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___TypeInfo
		                        );
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_01,
		             Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs____ctor__
		            );
		  iVar2 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs__TypeInfo
		                    );
		  UI_Windows_DialogWindow_DialogWindowArgs___ctor
		            (iVar2,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___ctor__
		            );
		  uVar1 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_28790,1,0,1,0,0,0,0);
		  *(undefined4 *)(iVar2 + 8) = uVar1;
		  iVar3 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_DialogWindow_DialogWindowArgs__TypeInfo
		                    );
		  uVar1 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_DialogWindow_DialogWindowArgs__TypeInfo
		                    );
		  UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_object____ctor
		            (uVar1,param1,
		             Method_Core_Gameplay_Managers_ProgressSaverManager__ShowAccountLinkDialogWindow_b__19_0__
		             ,0);
		  *(undefined4 *)(iVar3 + 8) = uVar1;
		  *(int *)(iVar2 + 0x14) = iVar3;
		  iVar3 = 
		  Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___Add__
		  ;
		  *(int *)(param1_01 + 0x10) = *(int *)(param1_01 + 0x10) + 1;
		  uVar4 = *(uint *)(param1_01 + 0xc);
		  if (uVar4 < *(uint *)(*(int *)(param1_01 + 8) + 0xc)) {
		    *(uint *)(param1_01 + 0xc) = uVar4 + 1;
		    *(int *)(*(int *)(param1_01 + 8) + uVar4 * 4 + 0x10) = iVar2;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (param1_01,iVar2,*(undefined4 *)(*(int *)(*(int *)(iVar3 + 0x10) + 0x60) + 0x38));
		  }
		  iVar2 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs__TypeInfo
		                    );
		  UI_Windows_DialogWindow_DialogWindowArgs___ctor
		            (iVar2,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___ctor__
		            );
		  uVar1 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4107,1,0,1,0,0,0,0);
		  *(undefined4 *)(iVar2 + 8) = uVar1;
		  iVar3 = 
		  Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___Add__
		  ;
		  *(int *)(param1_01 + 0x10) = *(int *)(param1_01 + 0x10) + 1;
		  uVar4 = *(uint *)(param1_01 + 0xc);
		  if (uVar4 < *(uint *)(*(int *)(param1_01 + 8) + 0xc)) {
		    *(uint *)(param1_01 + 0xc) = uVar4 + 1;
		    *(int *)(*(int *)(param1_01 + 8) + uVar4 * 4 + 0x10) = iVar2;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (param1_01,iVar2,*(undefined4 *)(*(int *)(*(int *)(iVar3 + 0x10) + 0x60) + 0x38));
		  }
		  *(int *)(param1_00 + 0x24) = param1_01;
		  uVar1 = UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_object____ctor
		                    (param1_00,0);
		  return uVar1;
		}
		*/

		}

		// Token: 0x06006995 RID: 27029 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006995")]
		[Address(RVA = "0xB4B5", Offset = "0xB4B5", VA = "0xB4B5")]
		public DialogWindow ShowAccountLinkDialogWindow()
		{
		/* --- GHIDRA: ShowAccountLinkDialogWindow ---
		void Core_Gameplay_Managers_ProgressSaverManager__ShowAccountLinkDialogWindow
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a63816 == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a63816 = '\x01';
		  }
		  local_4 = 0;
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar1 = UnityEngine_TextCore_Text_TextElement__get_textAsset(param2,0,0);
		  if ((iVar1 != 0) &&
		     (iVar1 = Gameplay_UserInterface_View_UserInterfaceButtonsView__get_BankButton
		                        (*(undefined4 *)(param2 + 0x14),&local_4,0), iVar1 != 0)) {
		    param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                          (local_4,0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (param1_00,0,0);
		  }
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06006996 RID: 27030 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006996")]
		[Address(RVA = "0xB4B6", Offset = "0xB4B6", VA = "0xB4B6")]
		public void SetView(UserInterfaceView view)
		{
		/* --- GHIDRA: SetView ---
		void Core_Gameplay_Managers_ProgressSaverManager__SetView(undefined4 param1)
		
		{
		  if (DAT_ram_00a63817 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_ProgressSaverManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12520);
		    DAT_ram_00a63817 = '\x01';
		  }
		  **(undefined4 **)(Core_Gameplay_Managers_ProgressSaverManager_TypeInfo + 0x5c) =
		       StringLiteral_12520;
		  return;
		}
		*/

		}

		// Token: 0x040037FF RID: 14335
		[Token(Token = "0x40037FF")]
		[FieldOffset(Offset = "0x0")]
		public static readonly string AssetResourcePath;

		// Token: 0x04003802 RID: 14338
		[Token(Token = "0x4003802")]
		[FieldOffset(Offset = "0x10")]
		private ProgressSaverModel _model;

		// Token: 0x04003803 RID: 14339
		[Token(Token = "0x4003803")]
		[FieldOffset(Offset = "0x14")]
		private AccountLinker _accountLinker;

		// Token: 0x04003804 RID: 14340
		[Token(Token = "0x4003804")]
		[FieldOffset(Offset = "0x18")]
		private ProgressSaverController _controller;

		// Token: 0x04003805 RID: 14341
		[Token(Token = "0x4003805")]
		[FieldOffset(Offset = "0x1C")]
		public readonly IGame Game;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_InitCompleteEvent ---
		void Core_Gameplay_Managers_ProgressSaverManager__add_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a6380f == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a6380f = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 8);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_IBaseManager__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IBaseManager__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 8,iVar2,param1_00);
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


		/* --- GHIDRA: remove_InitCompleteEvent ---
		void Core_Gameplay_Managers_ProgressSaverManager__remove_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a63810 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a63810 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0xc);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_IBaseManager__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IBaseManager__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0xc,iVar2,param1_00);
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


		/* --- GHIDRA: add_DeinitCompleteEvent ---
		void Core_Gameplay_Managers_ProgressSaverManager__add_DeinitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a63811 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a63811 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0xc);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_IBaseManager__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IBaseManager__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0xc,iVar2,param1_00);
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


		/* --- GHIDRA: get_Controller ---
		void Core_Gameplay_Managers_ProgressSaverManager__get_Controller(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  undefined4 param7;
		  undefined4 param4;
		  uint *puVar3;
		  int *piVar4;
		  undefined4 uVar5;
		  undefined4 param6;
		  undefined4 param1_00;
		  int *piVar6;
		  int iVar7;
		  undefined4 uVar8;
		  undefined4 param5;
		  
		  if (DAT_ram_00a63812 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_AccountLinker_AccountLinkerEvents_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_AccountLinker_Model_AccountLinkerModel_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_AccountLinker_AccountLinker_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverController_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_AccountLinker_ProgressSaver_ProgressSaverEvents_TypeInfo)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_AccountLinker_ProgressSaver_Model_ProgressSaverModel_TypeInfo);
		    DAT_ram_00a63812 = '\x01';
		  }
		  param4 = unnamed_function_1417(Gameplay_AccountLinker_ProgressSaver_ProgressSaverEvents_TypeInfo);
		  piVar6 = *(int **)(param1 + 0x1c);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0xe0);
		        goto code_r0x82305179;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x82305179:
		  piVar4 = (int *)(**(code **)((ulonglong)*puVar3 * 4))(piVar6,puVar3[1]);
		  uVar1 = 0;
		  iVar7 = *piVar4;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x160);
		        goto code_r0x823051fb;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar4,Core_Application_IApp_TypeInfo,0x14);
		code_r0x823051fb:
		  iVar7 = (**(code **)((ulonglong)*puVar3 * 4))(piVar4,puVar3[1]);
		  uVar8 = *(undefined4 *)(iVar7 + 0x14);
		  uVar1 = 0;
		  piVar4 = *(int **)(param1 + 0x1c);
		  iVar7 = *piVar4;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x140);
		        goto code_r0x8230527f;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x8230527f:
		  uVar2 = 0;
		  iVar7 = (**(code **)((ulonglong)*puVar3 * 4))(piVar4,puVar3[1]);
		  if (*(int *)(iVar7 + 0x14) != 0) {
		    uVar2 = *(undefined4 *)(*(int *)(iVar7 + 0x14) + 8);
		  }
		  uVar5 = unnamed_function_1417
		                    (Gameplay_AccountLinker_ProgressSaver_Model_ProgressSaverModel_TypeInfo);
		  Gameplay_AccountLinker_ProgressSaver_Model_ProgressSaverModel__Dispose(uVar5,piVar6,uVar8,uVar2,0)
		  ;
		  *(undefined4 *)(param1 + 0x10) = uVar5;
		  piVar6 = *(int **)(param1 + 0x1c);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0xe0);
		        goto code_r0x82305335;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x82305335:
		  piVar6 = (int *)(**(code **)((ulonglong)*puVar3 * 4))(piVar6,puVar3[1]);
		  uVar1 = 0;
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x128);
		        goto code_r0x823053b5;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar6,Core_Application_IApp_TypeInfo,0xd);
		code_r0x823053b5:
		  uVar1 = 0;
		  uVar8 = (**(code **)((ulonglong)*puVar3 * 4))(piVar6,puVar3[1]);
		  piVar6 = *(int **)(param1 + 0x1c);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0xe0);
		        goto code_r0x8230543a;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x8230543a:
		  piVar6 = (int *)(**(code **)((ulonglong)*puVar3 * 4))(piVar6,puVar3[1]);
		  uVar1 = 0;
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x160);
		        goto code_r0x823054bc;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar6,Core_Application_IApp_TypeInfo,0x14);
		code_r0x823054bc:
		  iVar7 = (**(code **)((ulonglong)*puVar3 * 4))(piVar6,puVar3[1]);
		  uVar2 = *(undefined4 *)(iVar7 + 0x14);
		  uVar1 = 0;
		  piVar6 = *(int **)(param1 + 0x1c);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0xe0);
		        goto code_r0x82305540;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x82305540:
		  piVar6 = (int *)(**(code **)((ulonglong)*puVar3 * 4))(piVar6,puVar3[1]);
		  uVar1 = 0;
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x160);
		        goto code_r0x823055c2;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar6,Core_Application_IApp_TypeInfo,0x14);
		code_r0x823055c2:
		  iVar7 = (**(code **)((ulonglong)*puVar3 * 4))(piVar6,puVar3[1]);
		  uVar5 = *(undefined4 *)(iVar7 + 0x14);
		  uVar1 = 0;
		  piVar6 = *(int **)(param1 + 0x1c);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0xe0);
		        goto code_r0x82305646;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x82305646:
		  piVar6 = (int *)(**(code **)((ulonglong)*puVar3 * 4))(piVar6,puVar3[1]);
		  uVar1 = 0;
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x160);
		        goto code_r0x823056c8;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar6,Core_Application_IApp_TypeInfo,0x14);
		code_r0x823056c8:
		  iVar7 = (**(code **)((ulonglong)*puVar3 * 4))(piVar6,puVar3[1]);
		  param5 = *(undefined4 *)(iVar7 + 0x14);
		  uVar1 = 0;
		  piVar6 = *(int **)(param1 + 0x1c);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0xe0);
		        goto code_r0x8230574c;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x8230574c:
		  piVar6 = (int *)(**(code **)((ulonglong)*puVar3 * 4))(piVar6,puVar3[1]);
		  uVar1 = 0;
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x168);
		        goto code_r0x823057cc;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar6,Core_Application_IApp_TypeInfo,0x15);
		code_r0x823057cc:
		  uVar1 = 0;
		  param6 = (**(code **)((ulonglong)*puVar3 * 4))(piVar6,puVar3[1]);
		  piVar6 = *(int **)(param1 + 0x1c);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x140);
		        goto code_r0x82305851;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x82305851:
		  param7 = 0;
		  iVar7 = (**(code **)((ulonglong)*puVar3 * 4))(piVar6,puVar3[1]);
		  if (*(int *)(iVar7 + 0x14) != 0) {
		    param7 = *(undefined4 *)(*(int *)(iVar7 + 0x14) + 8);
		  }
		  param1_00 = unnamed_function_1417(Gameplay_AccountLinker_Model_AccountLinkerModel_TypeInfo);
		  Gameplay_AccountLinker_Model_AccountLinkerModel__Dispose
		            (param1_00,uVar8,uVar2,uVar5,param5,param6,param7,0);
		  uVar8 = unnamed_function_1417(Gameplay_AccountLinker_AccountLinkerEvents_TypeInfo);
		  uVar2 = unnamed_function_1417(Gameplay_AccountLinker_AccountLinker_TypeInfo);
		  Gameplay_AccountLinker_AccountLinker__Dispose(uVar2,param1_00,uVar8,0);
		  *(undefined4 *)(param1 + 0x14) = uVar2;
		  uVar5 = *(undefined4 *)(param1 + 0x10);
		  uVar8 = unnamed_function_1417
		                    (
		                    Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverController_TypeInfo
		                    );
		  Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverController__Dispose
		            (uVar8,uVar2,uVar5,param4,0);
		  *(undefined4 *)(param1 + 0x18) = uVar8;
		  MVC_AbstractController__Dispose(*(undefined4 *)(param1 + 0x14),0);
		  MVC_AbstractController__Dispose(*(undefined4 *)(param1 + 0x18),0);
		  iVar7 = *(int *)(param1 + 8);
		  (**(code **)((ulonglong)*(uint *)(iVar7 + 0xc) * 4))
		            (*(undefined4 *)(iVar7 + 0x20),param1,*(undefined4 *)(iVar7 + 0x14));
		  return;
		}
		*/


		/* --- GHIDRA: get_Name ---
		void Core_Gameplay_Managers_ProgressSaverManager__get_Name(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 param2_00;
		  undefined4 uVar2;
		  uint *puVar3;
		  undefined4 param1_00;
		  int *piVar4;
		  int iVar5;
		  undefined4 param3;
		  
		  if (DAT_ram_00a63814 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_UserInterface_View_Menu_MenuWindow_MenuWindowArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12653);
		    DAT_ram_00a63814 = '\x01';
		  }
		  uVar2 = System_Uri___ctor(0);
		  uVar2 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar2,0);
		  piVar4 = *(int **)(param1 + 0x1c);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x140);
		        goto code_r0x82305a8c;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x82305a8c:
		  param2_00 = 0;
		  iVar5 = (**(code **)((ulonglong)*puVar3 * 4))(piVar4,puVar3[1]);
		  if (*(int *)(iVar5 + 0x14) != 0) {
		    param2_00 = *(undefined4 *)(*(int *)(iVar5 + 0x14) + 8);
		  }
		  piVar4 = *(int **)(param1 + 0x1c);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xe0);
		        goto code_r0x82305b22;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x82305b22:
		  piVar4 = (int *)(**(code **)((ulonglong)*puVar3 * 4))(piVar4,puVar3[1]);
		  uVar1 = 0;
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x128);
		        goto code_r0x82305ba4;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar4,Core_Application_IApp_TypeInfo,0xd);
		code_r0x82305ba4:
		  iVar5 = (**(code **)((ulonglong)*puVar3 * 4))(piVar4,puVar3[1]);
		  param3 = *(undefined4 *)(iVar5 + 0xc);
		  param1_00 = unnamed_function_1417
		                        (Gameplay_UserInterface_View_Menu_MenuWindow_MenuWindowArgs_TypeInfo);
		  Gameplay_UserInterface_View_Menu_MenuWindow_MenuWindowArgs__get_Payload
		            (param1_00,param2_00,param3,1,0,0);
		  UI_Windows_PopupController__set_TopWindow(uVar2,StringLiteral_12653,param1_00,0,0);
		  return;
		}
		*/

}
