using System;
using Core.Data;
using Il2CppDummyDll;
using UI.Elements.Sliders;
using UI.Windows;
using UnityEngine;

namespace Gameplay.Inventory.View
{
	// Token: 0x0200065B RID: 1627
	[Token(Token = "0x200065B")]
	public class ConfirmSplitArtifactWindow : BaseDialogWindow<ConfirmSplitArtifactWindow.ConfirmSplitAtrifactWindowArgs>
	{
		// Token: 0x17000775 RID: 1909
		// (get) Token: 0x06002784 RID: 10116 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000775")]
		public override string WindowId
		{
			[Token(Token = "0x6002784")]
			[Address(RVA = "0x78B5", Offset = "0x78B5", VA = "0x78B5", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000776 RID: 1910
		// (get) Token: 0x06002785 RID: 10117 RVA: 0x00007908 File Offset: 0x00005B08
		[Token(Token = "0x17000776")]
		public uint Value
		{
			[Token(Token = "0x6002785")]
			[Address(RVA = "0x78B6", Offset = "0x78B6", VA = "0x78B6")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x06002786 RID: 10118 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002786")]
		[Address(RVA = "0x78B7", Offset = "0x78B7", VA = "0x78B7")]
		private void Start()
		{
		/* --- GHIDRA: Start ---
		undefined4
		Gameplay_Inventory_View_ConfirmSplitArtifactWindow__Start
		          (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  int param1_00;
		  int param1_01;
		  undefined4 uVar2;
		  int iVar3;
		  int param1_02;
		  uint uVar4;
		  
		  if (DAT_ram_00a5a09b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_ConfirmSplitArtifactWindow_ConfirmSplitAtrifactWindowArgs__ArtifactData__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ConfirmSplitArtifactWindow_ConfirmSplitAtrifactWindowArgs__ArtifactData___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ConfirmSplitArtifactWindow_ConfirmSplitAtrifactWindowArgs__ArtifactData__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Inventory_View_ConfirmSplitArtifactWindow_ConfirmSplitAtrifactWindowArgs_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ConfirmSplitArtifactWindow_ConfirmSplitAtrifactWindowArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ConfirmSplitArtifactWindow_ConfirmSplitAtrifactWindowArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ConfirmSplitArtifactWindow_ConfirmSplitAtrifactWindowArgs___Add__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_PopupController_Show_ConfirmSplitArtifactWindow___);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Inventory_View_ConfirmSplitArtifactWindow___c__DisplayClass10_0__Show_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Inventory_View_ConfirmSplitArtifactWindow___c__DisplayClass10_0_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_9122);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12637);
		    DAT_ram_00a5a09b = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (
		                    Gameplay_Inventory_View_ConfirmSplitArtifactWindow___c__DisplayClass10_0_TypeInfo
		                    );
		  *(undefined4 *)(iVar1 + 8) = param2;
		  param1_00 = unnamed_function_1417
		                        (
		                        Gameplay_Inventory_View_ConfirmSplitArtifactWindow_ConfirmSplitAtrifactWindowArgs_TypeInfo
		                        );
		  Gameplay_Inventory_View_ConfirmSplitArtifactWindow___ctor(param1_00,param2);
		  *(undefined4 *)(param1_00 + 0x2c) = param1;
		  *(undefined4 *)(param1_00 + 0x1c) = **(undefined4 **)(DAT_ram_00a66978 + 0x5c);
		  param1_02 = *(int *)(param1_00 + 0x24);
		  param1_01 = unnamed_function_1417
		                        (
		                        UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ConfirmSplitArtifactWindow_ConfirmSplitAtrifactWindowArgs__TypeInfo
		                        );
		  UI_Windows_DialogWindow_DialogWindowArgs___ctor
		            (param1_01,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ConfirmSplitArtifactWindow_ConfirmSplitAtrifactWindowArgs___ctor__
		            );
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar2 = func_ii_7508(StringLiteral_9122,1,0,1,0,0,0,0);
		  *(undefined4 *)(param1_01 + 8) = uVar2;
		  iVar3 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ConfirmSplitArtifactWindow_ConfirmSplitAtrifactWindowArgs__ArtifactData__TypeInfo
		                    );
		  *(undefined4 *)(iVar3 + 0xc) = param1;
		  uVar2 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_ConfirmSplitArtifactWindow_ConfirmSplitAtrifactWindowArgs__ArtifactData__TypeInfo
		                    );
		  UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_object__Int32Enum___Invoke
		            (uVar2,iVar1,
		             Method_Gameplay_Inventory_View_ConfirmSplitArtifactWindow___c__DisplayClass10_0__Show_b__0__
		             ,0);
		  *(undefined4 *)(iVar3 + 0x10) = uVar2;
		  *(int *)(param1_01 + 0x14) = iVar3;
		  iVar1 = 
		  Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ConfirmSplitArtifactWindow_ConfirmSplitAtrifactWindowArgs___Add__
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
		                    (uVar2,StringLiteral_12637,param1_00,
		                     Method_UI_Windows_PopupController_Show_ConfirmSplitArtifactWindow___);
		  return uVar2;
		}
		*/

		}

		// Token: 0x06002787 RID: 10119 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002787")]
		[Address(RVA = "0x78B8", Offset = "0x78B8", VA = "0x78B8")]
		public static ConfirmSplitArtifactWindow Show(ArtifactData artifact, Action<uint, uint> resultCallback)
		{
		/* --- GHIDRA: Show ---
		void Gameplay_Inventory_View_ConfirmSplitArtifactWindow__Show(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int *piVar4;
		  undefined4 uVar5;
		  int iVar6;
		  
		  if (DAT_ram_00a5a09c == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SplitArtifactView_ArtifactSelection__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_int__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_SplitArtifactView_ArtifactSelection__int__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_ConfirmSplitArtifactWindow_ConfirmSplitAtrifactWindowArgs__HandleContent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseWindow_ConfirmSplitArtifactWindow_ConfirmSplitAtrifactWindowArgs__get_WindowArgs__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Inventory_View_ConfirmSplitArtifactWindow_OnArtifactSelectHandler__)
		    ;
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_Inventory_View_ConfirmSplitArtifactWindow_OnOk__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Inventory_View_ConfirmSplitArtifactWindow_OnSliderValueChangedEventHandler__
		              );
		    DAT_ram_00a5a09c = '\x01';
		  }
		  UI_Windows_BaseDialogWindow_object___HandleButtons
		            (param1,
		             Method_UI_Windows_BaseDialogWindow_ConfirmSplitArtifactWindow_ConfirmSplitAtrifactWindowArgs__HandleContent__
		            );
		  piVar4 = *(int **)(param1 + 0x54);
		  iVar1 = func_ii_8093(param1,
		                       Method_UI_Windows_BaseWindow_ConfirmSplitArtifactWindow_ConfirmSplitAtrifactWindowArgs__get_WindowArgs__
		                      );
		  iVar6 = *piVar4;
		  (**(code **)((ulonglong)*(uint *)(iVar6 + 0x138) * 4))
		            (piVar4,*(undefined4 *)(iVar1 + 0x2c),*(undefined4 *)(iVar6 + 0x13c));
		  iVar6 = *(int *)(param1 + 0x54);
		  uVar5 = *(undefined4 *)(iVar6 + 0x34);
		  uVar2 = unnamed_function_1417(System_Action_SplitArtifactView_ArtifactSelection__TypeInfo);
		  System_Action_int___Invoke
		            (uVar2,param1,
		             Method_Gameplay_Inventory_View_ConfirmSplitArtifactWindow_OnArtifactSelectHandler__,0);
		  iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_SplitArtifactView_ArtifactSelection__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar6 + 0x34) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_SplitArtifactView_ArtifactSelection__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar6 + 0x34) = iVar3;
		    uVar2 = System_Action_SplitArtifactView_ArtifactSelection__TypeInfo;
		    iVar6 = func_ii_1082(iVar1,System_Action_SplitArtifactView_ArtifactSelection__TypeInfo);
		    if (iVar6 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar6 = *(int *)(param1 + 0x58);
		  uVar5 = *(undefined4 *)(iVar6 + 0x20);
		  uVar2 = unnamed_function_1417(System_Action_SplitArtifactView_ArtifactSelection__int__TypeInfo);
		  System_Action_int__float___Invoke
		            (uVar2,param1,Method_Gameplay_Inventory_View_ConfirmSplitArtifactWindow_OnOk__,0);
		  iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_SplitArtifactView_ArtifactSelection__int__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar6 + 0x20) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_SplitArtifactView_ArtifactSelection__int__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar6 + 0x20) = iVar3;
		    uVar2 = System_Action_SplitArtifactView_ArtifactSelection__int__TypeInfo;
		    iVar6 = func_ii_1082(iVar1,System_Action_SplitArtifactView_ArtifactSelection__int__TypeInfo);
		    if (iVar6 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = func_ii_8093(param1,
		                       Method_UI_Windows_BaseWindow_ConfirmSplitArtifactWindow_ConfirmSplitAtrifactWindowArgs__get_WindowArgs__
		                      );
		  iVar6 = **(int **)(iVar1 + 0x2c);
		  uVar2 = (**(code **)((ulonglong)*(uint *)(iVar6 + 0xf8) * 4))
		                    (*(int **)(iVar1 + 0x2c),*(undefined4 *)(iVar6 + 0xfc));
		  UI_Elements_Sliders_SplitSlider__DisplayValue(*(undefined4 *)(param1 + 0x50),1,uVar2,0);
		  uVar5 = *(undefined4 *)(param1 + 0x50);
		  uVar2 = unnamed_function_1417(System_Action_int__TypeInfo);
		  System_Action_short___Invoke
		            (uVar2,param1,
		             Method_Gameplay_Inventory_View_ConfirmSplitArtifactWindow_OnSliderValueChangedEventHandler__
		             ,0);
		  UI_Elements_Sliders_SliderWithButtons___ctor(uVar5,uVar2,0);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06002788 RID: 10120 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002788")]
		[Address(RVA = "0x78B9", Offset = "0x78B9", VA = "0x78B9", Slot = "28")]
		protected override void HandleContent()
		{
		/* --- GHIDRA: HandleContent ---
		void Gameplay_Inventory_View_ConfirmSplitArtifactWindow__HandleContent(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a5a09d == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SplitArtifactView_ArtifactSelection__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_int__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_SplitArtifactView_ArtifactSelection__int__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_ConfirmSplitArtifactWindow_ConfirmSplitAtrifactWindowArgs__OnDestroy__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Inventory_View_ConfirmSplitArtifactWindow_OnArtifactSelectHandler__)
		    ;
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_Inventory_View_ConfirmSplitArtifactWindow_OnOk__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Inventory_View_ConfirmSplitArtifactWindow_OnSliderValueChangedEventHandler__
		              );
		    DAT_ram_00a5a09d = '\x01';
		  }
		  iVar4 = *(int *)(param1 + 0x54);
		  uVar5 = *(undefined4 *)(iVar4 + 0x34);
		  uVar1 = unnamed_function_1417(System_Action_SplitArtifactView_ArtifactSelection__TypeInfo);
		  System_Action_int___Invoke
		            (uVar1,param1,
		             Method_Gameplay_Inventory_View_ConfirmSplitArtifactWindow_OnArtifactSelectHandler__,0);
		  iVar2 = func_ii_7048(uVar5,uVar1,0);
		  uVar1 = System_Action_SplitArtifactView_ArtifactSelection__TypeInfo;
		  if (iVar2 == 0) {
		    *(undefined4 *)(iVar4 + 0x34) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar2,System_Action_SplitArtifactView_ArtifactSelection__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x34) = iVar3;
		    uVar1 = System_Action_SplitArtifactView_ArtifactSelection__TypeInfo;
		    iVar4 = func_ii_1082(iVar2,System_Action_SplitArtifactView_ArtifactSelection__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  uVar5 = *(undefined4 *)(param1 + 0x50);
		  uVar1 = unnamed_function_1417(System_Action_int__TypeInfo);
		  System_Action_short___Invoke
		            (uVar1,param1,
		             Method_Gameplay_Inventory_View_ConfirmSplitArtifactWindow_OnSliderValueChangedEventHandler__
		             ,0);
		  UI_Elements_Sliders_SplitSlider__add_OnValueChangedEvent(uVar5,uVar1,0);
		  iVar4 = *(int *)(param1 + 0x58);
		  uVar5 = *(undefined4 *)(iVar4 + 0x20);
		  uVar1 = unnamed_function_1417(System_Action_SplitArtifactView_ArtifactSelection__int__TypeInfo);
		  System_Action_int__float___Invoke
		            (uVar1,param1,Method_Gameplay_Inventory_View_ConfirmSplitArtifactWindow_OnOk__,0);
		  iVar2 = func_ii_7048(uVar5,uVar1,0);
		  uVar1 = System_Action_SplitArtifactView_ArtifactSelection__int__TypeInfo;
		  if (iVar2 == 0) {
		    *(undefined4 *)(iVar4 + 0x20) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar2,System_Action_SplitArtifactView_ArtifactSelection__int__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x20) = iVar3;
		    uVar1 = System_Action_SplitArtifactView_ArtifactSelection__int__TypeInfo;
		    iVar4 = func_ii_1082(iVar2,System_Action_SplitArtifactView_ArtifactSelection__int__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  UI_Windows_BaseDialogWindow_object___OnClose
		            (param1,
		             Method_UI_Windows_BaseDialogWindow_ConfirmSplitArtifactWindow_ConfirmSplitAtrifactWindowArgs__OnDestroy__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06002789 RID: 10121 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002789")]
		[Address(RVA = "0x78BA", Offset = "0x78BA", VA = "0x78BA", Slot = "29")]
		protected override void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_Inventory_View_ConfirmSplitArtifactWindow__OnDestroy
		               (int param1,int param2,int param3,undefined4 param4)
		
		{
		  uint uVar1;
		  int param2_00;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 param6;
		  undefined4 uVar4;
		  undefined4 uVar5;
		  int iVar6;
		  int *piVar7;
		  undefined4 param3_00;
		  int iVar8;
		  
		  if (DAT_ram_00a5a09e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseWindow_ConfirmSplitArtifactWindow_ConfirmSplitAtrifactWindowArgs__get_WindowArgs__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_InventoryScope_UsingNumpadEventArgs_TypeInfo);
		    DAT_ram_00a5a09e = '\x01';
		  }
		  if (param2 == 0) {
		    UI_Elements_Sliders_SplitSlider__GetValue(*(undefined4 *)(param1 + 0x50),param3,0);
		  }
		  else {
		    if (param2 != 1) {
		      uVar5 = unnamed_function_2232(&System_NotSupportedException_TypeInfo);
		      uVar5 = unnamed_function_1417(uVar5);
		      func_ii_20706(uVar5,0);
		      uVar3 = unnamed_function_2232
		                        (&Method_Gameplay_Inventory_View_ConfirmSplitArtifactWindow_OnOk__);
		      func_ii_1050(uVar5,uVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    UI_Elements_Sliders_SplitSlider__GetValue
		              (*(int *)(param1 + 0x50),*(int *)(*(int *)(param1 + 0x50) + 0x24) - param3,0);
		  }
		  param2_00 = System_Uri___ctor(0);
		  iVar2 = func_ii_8093(param1,
		                       Method_UI_Windows_BaseWindow_ConfirmSplitArtifactWindow_ConfirmSplitAtrifactWindowArgs__get_WindowArgs__
		                      );
		  iVar6 = *(int *)(*(int *)(*(int *)(*(int *)(param2_00 + 0x38) + 0x10) + 0x40) + 0xc);
		  if (iVar6 != 0) {
		    piVar7 = *(int **)(iVar2 + 0x2c);
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    param3_00 = **(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    uVar3 = Core_Data_ArtikulData__get_IsSellable(piVar7,0);
		    uVar1 = *(uint *)(piVar7[0x1d] + 0x18);
		    param6 = (**(code **)((ulonglong)*(uint *)(*piVar7 + 0xf8) * 4))
		                       (piVar7,*(undefined4 *)(*piVar7 + 0xfc));
		    uVar5 = 0;
		    iVar8 = *(int *)(param1 + 0x58);
		    piVar7 = *(int **)(iVar8 + 0x18);
		    iVar2 = *piVar7;
		    uVar4 = (**(code **)((ulonglong)*(uint *)(iVar2 + 0x2c8) * 4))
		                      (piVar7,*(undefined4 *)(iVar2 + 0x2cc));
		    iVar2 = func_ii_4769(uVar4,0);
		    if (iVar2 == 0) {
		      piVar7 = *(int **)(iVar8 + 0x18);
		      iVar2 = *piVar7;
		      uVar5 = (**(code **)((ulonglong)*(uint *)(iVar2 + 0x2c8) * 4))
		                        (piVar7,*(undefined4 *)(iVar2 + 0x2cc));
		      uVar5 = func_ii_8697(uVar5,0);
		    }
		    uVar4 = unnamed_function_1417(Core_Events_Scopes_InventoryScope_UsingNumpadEventArgs_TypeInfo);
		    Core_Events_Scopes_InventoryScope_BuySlotEventArgs___ctor
		              (uVar4,param2_00,param3_00,uVar3,(ulonglong)uVar1,param6,uVar5,0);
		    (**(code **)((ulonglong)*(uint *)(iVar6 + 0xc) * 4))
		              (*(undefined4 *)(iVar6 + 0x20),uVar4,*(undefined4 *)(iVar6 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600278A RID: 10122 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600278A")]
		[Address(RVA = "0x78BB", Offset = "0x78BB", VA = "0x78BB")]
		private void OnOk(SplitArtifactView.ArtifactSelection selection, int value)
		{
		/* --- GHIDRA: OnOk ---
		void Gameplay_Inventory_View_ConfirmSplitArtifactWindow__OnOk
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param1 + 100);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param2,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600278B RID: 10123 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600278B")]
		[Address(RVA = "0x78BC", Offset = "0x78BC", VA = "0x78BC")]
		private void OnArtifactSelectHandler(SplitArtifactView.ArtifactSelection selection)
		{
		/* --- GHIDRA: OnArtifactSelectHandler ---
		void Gameplay_Inventory_View_ConfirmSplitArtifactWindow__OnArtifactSelectHandler
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param1 + 0x60);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param2,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600278C RID: 10124 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600278C")]
		[Address(RVA = "0x78BD", Offset = "0x78BD", VA = "0x78BD")]
		private void OnSliderValueChangedEventHandler(int value)
		{
		/* --- GHIDRA: OnSliderValueChangedEventHandler ---
		undefined4
		Gameplay_Inventory_View_ConfirmSplitArtifactWindow__OnSliderValueChangedEventHandler
		          (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = UI_Elements_Sliders_SplitSlider__SetValues(*(undefined4 *)(param1 + 0x50),0);
		  return uVar1;
		}
		*/

		}

		// Token: 0x17000777 RID: 1911
		// (get) Token: 0x0600278D RID: 10125 RVA: 0x00007920 File Offset: 0x00005B20
		// (set) Token: 0x0600278E RID: 10126 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000777")]
		public int LeftArtifactValue
		{
			[Token(Token = "0x600278D")]
			[Address(RVA = "0x78BE", Offset = "0x78BE", VA = "0x78BE")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600278E")]
			[Address(RVA = "0x78BF", Offset = "0x78BF", VA = "0x78BF")]
			set
			{
			}
		}

		// Token: 0x17000778 RID: 1912
		// (get) Token: 0x0600278F RID: 10127 RVA: 0x00007938 File Offset: 0x00005B38
		// (set) Token: 0x06002790 RID: 10128 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000778")]
		public int RightArtifactValue
		{
			[Token(Token = "0x600278F")]
			[Address(RVA = "0x78C0", Offset = "0x78C0", VA = "0x78C0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002790")]
			[Address(RVA = "0x78C1", Offset = "0x78C1", VA = "0x78C1")]
			set
			{
			}
		}

		// Token: 0x17000779 RID: 1913
		// (get) Token: 0x06002791 RID: 10129 RVA: 0x00007950 File Offset: 0x00005B50
		[Token(Token = "0x17000779")]
		public int ArtifactMaxValue
		{
			[Token(Token = "0x6002791")]
			[Address(RVA = "0x78C2", Offset = "0x78C2", VA = "0x78C2")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700077A RID: 1914
		// (get) Token: 0x06002792 RID: 10130 RVA: 0x00007968 File Offset: 0x00005B68
		[Token(Token = "0x1700077A")]
		public SplitArtifactView.ArtifactSelection CurrentArtifactSelection
		{
			[Token(Token = "0x6002792")]
			[Address(RVA = "0x78C3", Offset = "0x78C3", VA = "0x78C3")]
			get
			{
				return SplitArtifactView.ArtifactSelection.Left;
			}
		}

		// Token: 0x06002793 RID: 10131 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002793")]
		[Address(RVA = "0x78C4", Offset = "0x78C4", VA = "0x78C4")]
		public ConfirmSplitArtifactWindow()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Inventory_View_ConfirmSplitArtifactWindow___ctor(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5a0a0 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_ConfirmSplitArtifactWindow_ConfirmSplitAtrifactWindowArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_9123);
		    DAT_ram_00a5a0a0 = '\x01';
		  }
		  UnityEngine_UIElements_BaseCompositeField___Il2CppFullySharedGenericType__object____Il2CppFullySharedGenericType___UpdateMixedValueContent
		            (param1,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_ConfirmSplitArtifactWindow_ConfirmSplitAtrifactWindowArgs___ctor__
		            );
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar1 = func_ii_7508(StringLiteral_9123,1,0,1,0,0,0,0);
		  *(undefined4 *)(param1 + 0x18) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x040015AC RID: 5548
		[Token(Token = "0x40015AC")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Inventory/ConfirmSplitArtifactWindow";

		// Token: 0x040015AD RID: 5549
		[Token(Token = "0x40015AD")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private SplitSlider _slider;

		// Token: 0x040015AE RID: 5550
		[Token(Token = "0x40015AE")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private SplitArtifactView _artifactView;

		// Token: 0x040015AF RID: 5551
		[Token(Token = "0x40015AF")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private NumpadView _numpad;

		// Token: 0x040015B0 RID: 5552
		[Token(Token = "0x40015B0")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private GameObject _separator;

		// Token: 0x040015B1 RID: 5553
		[Token(Token = "0x40015B1")]
		[FieldOffset(Offset = "0x60")]
		public Action<int> OnSliderChanged;

		// Token: 0x040015B2 RID: 5554
		[Token(Token = "0x40015B2")]
		[FieldOffset(Offset = "0x64")]
		public Action<SplitArtifactView.ArtifactSelection> OnArtifactSelect;

		// Token: 0x0200065C RID: 1628
		[Token(Token = "0x200065C")]
		public class ConfirmSplitAtrifactWindowArgs : BaseDialogWindow<ConfirmSplitArtifactWindow.ConfirmSplitAtrifactWindowArgs>.BaseDialogWindowArgs
		{
			// Token: 0x06002794 RID: 10132 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002794")]
			[Address(RVA = "0x78C5", Offset = "0x78C5", VA = "0x78C5")]
			public ConfirmSplitAtrifactWindowArgs()
			{
			}

			// Token: 0x040015B3 RID: 5555
			[Token(Token = "0x40015B3")]
			[FieldOffset(Offset = "0x2C")]
			public ArtifactData ArtifactData;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Value ---
		void Gameplay_Inventory_View_ConfirmSplitArtifactWindow__get_Value(int param1,undefined4 param2)
		
		{
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (*(undefined4 *)(param1 + 0x5c),0,0);
		  return;
		}
		*/


		/* --- GHIDRA: get_LeftArtifactValue ---
		void Gameplay_Inventory_View_ConfirmSplitArtifactWindow__get_LeftArtifactValue
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  UI_Elements_Sliders_SplitSlider__GetValue(*(undefined4 *)(param1 + 0x50),param2,0);
		  return;
		}
		*/


		/* --- GHIDRA: set_LeftArtifactValue ---
		int Gameplay_Inventory_View_ConfirmSplitArtifactWindow__set_LeftArtifactValue
		              (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  
		  iVar2 = *(int *)(*(int *)(param1 + 0x50) + 0x24);
		  iVar1 = UI_Elements_Sliders_SplitSlider__SetValues(*(int *)(param1 + 0x50),0);
		  return iVar2 - iVar1;
		}
		*/


		/* --- GHIDRA: get_RightArtifactValue ---
		void Gameplay_Inventory_View_ConfirmSplitArtifactWindow__get_RightArtifactValue
		               (int param1,int param2,undefined4 param3)
		
		{
		  UI_Elements_Sliders_SplitSlider__GetValue
		            (*(int *)(param1 + 0x50),*(int *)(*(int *)(param1 + 0x50) + 0x24) - param2,0);
		  return;
		}
		*/


		/* --- GHIDRA: set_RightArtifactValue ---
		undefined4
		Gameplay_Inventory_View_ConfirmSplitArtifactWindow__set_RightArtifactValue
		          (int param1,undefined4 param2)
		
		{
		  return *(undefined4 *)(*(int *)(param1 + 0x50) + 0x24);
		}
		*/


		/* --- GHIDRA: get_ArtifactMaxValue ---
		undefined4
		Gameplay_Inventory_View_ConfirmSplitArtifactWindow__get_ArtifactMaxValue
		          (int param1,undefined4 param2)
		
		{
		  return *(undefined4 *)(*(int *)(param1 + 0x54) + 0x38);
		}
		*/


		/* --- GHIDRA: get_CurrentArtifactSelection ---
		void Gameplay_Inventory_View_ConfirmSplitArtifactWindow__get_CurrentArtifactSelection
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5a09f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_ConfirmSplitArtifactWindow_ConfirmSplitAtrifactWindowArgs___ctor__
		              );
		    DAT_ram_00a5a09f = '\x01';
		  }
		  UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_object____ctor
		            (param1,
		             Method_UI_Windows_BaseDialogWindow_ConfirmSplitArtifactWindow_ConfirmSplitAtrifactWindowArgs___ctor__
		            );
		  return;
		}
		*/

}
