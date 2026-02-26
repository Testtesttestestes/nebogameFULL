using System;
using Gameplay.Ad.EnergyRegenAd.View;
using Il2CppDummyDll;
using Protocol.Consts;
using UI.Windows;
using UnityEngine;

namespace UI
{
	// Token: 0x02000104 RID: 260
	[Token(Token = "0x2000104")]
	public class NotEnoughResourcesWindow : BaseDialogWindow<NotEnoughResourcesWindow.NotEnoughResourcesWindowArgs>
	{
		// Token: 0x1700010E RID: 270
		// (get) Token: 0x06000871 RID: 2161 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700010E")]
		public override string WindowId
		{
			[Token(Token = "0x6000871")]
			[Address(RVA = "0x5C1B", Offset = "0x5C1B", VA = "0x5C1B", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000872 RID: 2162 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000872")]
		[Address(RVA = "0x5C1C", Offset = "0x5C1C", VA = "0x5C1C", Slot = "22")]
		protected override void OnShow(NotEnoughResourcesWindow.NotEnoughResourcesWindowArgs args)
		{
		/* --- GHIDRA: OnShow ---
		void UI_NotEnoughResourcesWindow__OnShow(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5b888 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_NotEnoughResourcesWindow_NotEnoughResourcesWindowArgs___ctor__
		              );
		    DAT_ram_00a5b888 = '\x01';
		  }
		  UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_object____ctor
		            (param1,
		             Method_UI_Windows_BaseDialogWindow_NotEnoughResourcesWindow_NotEnoughResourcesWindowArgs___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06000873 RID: 2163 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000873")]
		[Address(RVA = "0x5C1D", Offset = "0x5C1D", VA = "0x5C1D")]
		public NotEnoughResourcesWindow()
		{
		/* --- GHIDRA: .ctor ---
		void UI_NotEnoughResourcesWindow___ctor(int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  undefined4 param3_00;
		  int param1_01;
		  int param1_02;
		  int iVar3;
		  uint uVar4;
		  undefined4 local_8;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5b889 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_NotEnoughResourcesWindow_NotEnoughResourcesWindowArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_NotEnoughResourcesWindow_NotEnoughResourcesWindowArgs__Resources__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_NotEnoughResourcesWindow_NotEnoughResourcesWindowArgs__Resources___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_NotEnoughResourcesWindow_NotEnoughResourcesWindowArgs__Resources__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_NotEnoughResourcesWindow_NotEnoughResourcesWindowArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_NotEnoughResourcesWindow_NotEnoughResourcesWindowArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_string__string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_NotEnoughResourcesWindow_NotEnoughResourcesWindowArgs___Add__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_NotEnoughResourcesWindow_NotEnoughResourcesWindowArgs____ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_NotEnoughResourcesWindow_NotEnoughResourcesWindowArgs___TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_NotEnoughResourcesWindow_NotEnoughResourcesWindowArgs___c__DisplayClass1_0___ctor_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_NotEnoughResourcesWindow_NotEnoughResourcesWindowArgs___c__DisplayClass1_0_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&StringLiteral_26428);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3708);
		    Mono_Security_ASN1__get_Item(&StringLiteral_6871);
		    Mono_Security_ASN1__get_Item(&StringLiteral_6870);
		    DAT_ram_00a5b889 = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (
		                    UI_NotEnoughResourcesWindow_NotEnoughResourcesWindowArgs___c__DisplayClass1_0_TypeInfo
		                    );
		  *(undefined4 *)(iVar1 + 8) = param2;
		  UnityEngine_UIElements_BaseCompositeField___Il2CppFullySharedGenericType__object____Il2CppFullySharedGenericType___UpdateMixedValueContent
		            (param1,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_NotEnoughResourcesWindow_NotEnoughResourcesWindowArgs___ctor__
		            );
		  local_4 = *(undefined4 *)(iVar1 + 8);
		  *(undefined4 *)(param1 + 0x2c) = local_4;
		  uVar2 = func_ii_1081(DAT_ram_00a66958,&local_4);
		  uVar2 = func_ii_4419(StringLiteral_6871,uVar2,0);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(uVar2,1,0,1,0,0,0,0);
		  *(undefined4 *)(param1 + 0x18) = uVar2;
		  local_8 = *(undefined4 *)(iVar1 + 8);
		  uVar2 = func_ii_1081(DAT_ram_00a66958,&local_8);
		  uVar2 = func_ii_4419(StringLiteral_6870,uVar2,0);
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(uVar2,1,0,1,0,0,0,0);
		  param1_00 = unnamed_function_1417(System_Collections_Generic_Dictionary_string__string__TypeInfo);
		  System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		            (param1_00,Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		  param3_00 = Core_Extensions_Dict_ResourcesDicExt__GetUnlimitToolTipText
		                        (*(undefined4 *)(iVar1 + 8),0);
		  System_Reflection_FieldInfo__get_IsStatic
		            (param1_00,StringLiteral_26428,param3_00,
		             Method_System_Collections_Generic_Dictionary_string__string__Add__);
		  uVar2 = Core_GameLocalization__GetTranslation(uVar2,param1_00,0);
		  *(undefined4 *)(param1 + 0x1c) = uVar2;
		  param1_01 = unnamed_function_1417
		                        (
		                        System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_NotEnoughResourcesWindow_NotEnoughResourcesWindowArgs___TypeInfo
		                        );
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_01,
		             Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_NotEnoughResourcesWindow_NotEnoughResourcesWindowArgs____ctor__
		            );
		  param1_02 = unnamed_function_1417
		                        (
		                        UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_NotEnoughResourcesWindow_NotEnoughResourcesWindowArgs__TypeInfo
		                        );
		  UI_Windows_DialogWindow_DialogWindowArgs___ctor
		            (param1_02,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_NotEnoughResourcesWindow_NotEnoughResourcesWindowArgs___ctor__
		            );
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_3708,1,0,1,0,0,0,0);
		  *(undefined4 *)(param1_02 + 8) = uVar2;
		  iVar3 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_NotEnoughResourcesWindow_NotEnoughResourcesWindowArgs__Resources__TypeInfo
		                    );
		  *(undefined4 *)(iVar3 + 0xc) = *(undefined4 *)(iVar1 + 8);
		  uVar2 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_NotEnoughResourcesWindow_NotEnoughResourcesWindowArgs__Resources__TypeInfo
		                    );
		  UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_object__int___Invoke
		            (uVar2,iVar1,
		             Method_UI_NotEnoughResourcesWindow_NotEnoughResourcesWindowArgs___c__DisplayClass1_0___ctor_b__0__
		             ,0);
		  *(undefined4 *)(iVar3 + 0x10) = uVar2;
		  *(int *)(param1_02 + 0x14) = iVar3;
		  iVar1 = 
		  Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_NotEnoughResourcesWindow_NotEnoughResourcesWindowArgs___Add__
		  ;
		  *(int *)(param1_01 + 0x10) = *(int *)(param1_01 + 0x10) + 1;
		  uVar4 = *(uint *)(param1_01 + 0xc);
		  if (uVar4 < *(uint *)(*(int *)(param1_01 + 8) + 0xc)) {
		    *(uint *)(param1_01 + 0xc) = uVar4 + 1;
		    *(int *)(*(int *)(param1_01 + 8) + uVar4 * 4 + 0x10) = param1_02;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (param1_01,param1_02,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  *(int *)(param1 + 0x24) = param1_01;
		  return;
		}
		*/

		}

		// Token: 0x04000301 RID: 769
		[Token(Token = "0x4000301")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/NotEnoughResourcesWindow";

		// Token: 0x04000302 RID: 770
		[Token(Token = "0x4000302")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private EnergyRegenAdEntryView _energyRegenAdEntryView;

		// Token: 0x02000105 RID: 261
		[Token(Token = "0x2000105")]
		public class NotEnoughResourcesWindowArgs : BaseDialogWindow<NotEnoughResourcesWindow.NotEnoughResourcesWindowArgs>.BaseDialogWindowArgs
		{
			// Token: 0x06000874 RID: 2164 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000874")]
			[Address(RVA = "0x5C1E", Offset = "0x5C1E", VA = "0x5C1E")]
			public NotEnoughResourcesWindowArgs(Protocol.Consts.Resources resourceId)
			{
			}

			// Token: 0x04000303 RID: 771
			[Token(Token = "0x4000303")]
			[FieldOffset(Offset = "0x2C")]
			public Protocol.Consts.Resources ResourceId;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_WindowId ---
		void UI_NotEnoughResourcesWindow__get_WindowId(int param1,int param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a5b887 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_NotEnoughResourcesWindow_NotEnoughResourcesWindowArgs__OnShow__
		              );
		    DAT_ram_00a5b887 = '\x01';
		  }
		  UI_Windows_BaseDialogWindow_object___OnDestroy
		            (param1,param2,
		             Method_UI_Windows_BaseDialogWindow_NotEnoughResourcesWindow_NotEnoughResourcesWindowArgs__OnShow__
		            );
		  Gameplay_Announcements_Control_AnnouncementsViewMediator__HandleAnnouncementActivity
		            (*(undefined4 *)(param1 + 0x50),*(undefined4 *)(param2 + 0x2c),0);
		  return;
		}
		*/

}
