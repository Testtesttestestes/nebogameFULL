using System;
using System.Runtime.CompilerServices;
using Gameplay.Inventory.View.Info.InfoBox;
using Gameplay.SmallGames.View;
using Il2CppDummyDll;
using UI.Elements.Buttons;
using UI.Windows;
using UnityEngine;

namespace Gameplay.Craft.View
{
	// Token: 0x020008B5 RID: 2229
	[Token(Token = "0x20008B5")]
	public class CraftSpinPickerDialogWindow : BaseDialogWindow<CraftSpinPickerDialogWindow.CraftSpinPickerDialogWindowArgs>
	{
		// Token: 0x17000A62 RID: 2658
		// (get) Token: 0x0600345D RID: 13405 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000A62")]
		public override string WindowId
		{
			[Token(Token = "0x600345D")]
			[Address(RVA = "0x8487", Offset = "0x8487", VA = "0x8487", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A63 RID: 2659
		// (get) Token: 0x0600345E RID: 13406 RVA: 0x0000AA58 File Offset: 0x00008C58
		// (set) Token: 0x0600345F RID: 13407 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A63")]
		public uint SelectedAttemptsNum
		{
			[Token(Token = "0x600345E")]
			[Address(RVA = "0x8488", Offset = "0x8488", VA = "0x8488")]
			[CompilerGenerated]
			get
			{
				return 0U;
			}
			[Token(Token = "0x600345F")]
			[Address(RVA = "0x8489", Offset = "0x8489", VA = "0x8489")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x14000170 RID: 368
		// (add) Token: 0x06003460 RID: 13408 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06003461 RID: 13409 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000170")]
		public event Action<uint> SelectedEvent
		{
			[Token(Token = "0x6003460")]
			[Address(RVA = "0x848A", Offset = "0x848A", VA = "0x848A")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6003461")]
			[Address(RVA = "0x848B", Offset = "0x848B", VA = "0x848B")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06003462 RID: 13410 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003462")]
		[Address(RVA = "0x848C", Offset = "0x848C", VA = "0x848C", Slot = "18")]
		protected override void OnShow(BaseWindowArgs args)
		{
		/* --- GHIDRA: OnShow ---
		void Gameplay_Craft_View_CraftSpinPickerDialogWindow__OnShow(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a57cfd == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_uint__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_CraftSpinPickerDialogWindow_CraftSpinPickerDialogWindowArgs__OnClose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Craft_View_CraftSpinPickerDialogWindow_ConfirmButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Craft_View_CraftSpinPickerDialogWindow_SpinValuePickerOnSelectionChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_ValuePicker_ValuePicker_uint__remove_SelectionChangedEvent__);
		    DAT_ram_00a57cfd = '\x01';
		  }
		  UI_Windows_BaseDialogWindow_object___HandleTitle
		            (param1,
		             Method_UI_Windows_BaseDialogWindow_CraftSpinPickerDialogWindow_CraftSpinPickerDialogWindowArgs__OnClose__
		            );
		  uVar2 = *(undefined4 *)(param1 + 0x50);
		  uVar1 = unnamed_function_1417(System_Action_uint__TypeInfo);
		  func_ii_12322(uVar1,param1,
		                Method_Gameplay_Craft_View_CraftSpinPickerDialogWindow_SpinValuePickerOnSelectionChangedEvent__
		                ,0);
		  UI_ValuePicker_ValuePicker___Il2CppFullySharedGenericType___add_SelectionChangedEvent
		            (uVar2,uVar1,Method_UI_ValuePicker_ValuePicker_uint__remove_SelectionChangedEvent__);
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 0x54) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,
		             Method_Gameplay_Craft_View_CraftSpinPickerDialogWindow_ConfirmButtonClickedEventHandler__
		             ,0);
		  UnityEngine_Events_UnityAction___ctor(uVar2,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x06003463 RID: 13411 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003463")]
		[Address(RVA = "0x848D", Offset = "0x848D", VA = "0x848D", Slot = "19")]
		protected override void OnClose()
		{
		/* --- GHIDRA: OnClose ---
		void Gameplay_Craft_View_CraftSpinPickerDialogWindow__OnClose(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param1 + 0x60);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(param1 + 0x5c),
		               *(undefined4 *)(iVar1 + 0x14));
		  }
		  System_ComponentModel_BindingList___Il2CppFullySharedGenericType___OnAddingNew(param1,2,0);
		  return;
		}
		*/

		}

		// Token: 0x06003464 RID: 13412 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003464")]
		[Address(RVA = "0x848E", Offset = "0x848E", VA = "0x848E")]
		private void ConfirmButtonClickedEventHandler()
		{
		/* --- GHIDRA: ConfirmButtonClickedEventHandler ---
		void Gameplay_Craft_View_CraftSpinPickerDialogWindow__ConfirmButtonClickedEventHandler
		               (int param1,uint param2,undefined4 param3)
		
		{
		  int iVar1;
		  int param1_00;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  undefined4 param3_00;
		  undefined4 param1_01;
		  uint param2_00;
		  ushort local_6;
		  uint local_4;
		  
		  local_4 = param2;
		  if (DAT_ram_00a57cfe == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseWindow_CraftSpinPickerDialogWindow_CraftSpinPickerDialogWindowArgs__get_WindowArgs__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_string__string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_bool___ctor__);
		    Mono_Security_ASN1__get_Item(&Core_Data_InfoRows_ValueRow_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4458);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4471);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26268);
		    DAT_ram_00a57cfe = '\x01';
		  }
		  *(uint *)(param1 + 0x5c) = param2;
		  iVar1 = func_ii_8093(param1,
		                       Method_UI_Windows_BaseWindow_CraftSpinPickerDialogWindow_CraftSpinPickerDialogWindowArgs__get_WindowArgs__
		                      );
		  uVar3 = StringLiteral_4471;
		  uVar2 = StringLiteral_4458;
		  iVar1 = *(int *)(iVar1 + 0x30);
		  param1_01 = *(undefined4 *)(param1 + 0x58);
		  param1_00 = unnamed_function_1417(Core_Data_InfoRows_ValueRow_TypeInfo);
		  System_Collections_Generic_List_object____ctor(param1_00,0);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  param2_00 = (uint)((longlong)(ulonglong)param2 <= (longlong)iVar1);
		  if (param2_00 == 0) {
		    uVar2 = uVar3;
		  }
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(uVar2,1,0,1,0,0,0,0);
		  uVar3 = unnamed_function_1417(System_Collections_Generic_Dictionary_string__string__TypeInfo);
		  System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		            (uVar3,Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		  param3_00 = Protocol_Combat_ProtoPlayerActionEvt___ctor(&local_4,0);
		  System_Reflection_FieldInfo__get_IsStatic
		            (uVar3,StringLiteral_26268,param3_00,
		             Method_System_Collections_Generic_Dictionary_string__string__Add__);
		  uVar2 = Core_GameLocalization__GetTranslation(uVar2,uVar3,0);
		  *(undefined4 *)(param1_00 + 0x18) = uVar2;
		  local_6 = 0;
		  System_Data_SqlTypes_SqlByte__ToSqlInt64(&local_6,param2_00,Method_System_Nullable_bool___ctor__);
		  *(ushort *)(param1_00 + 0x10) = local_6;
		  UI_Requirements_RequirementsView__GetRowPrefab(param1_01,param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06003465 RID: 13413 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003465")]
		[Address(RVA = "0x848F", Offset = "0x848F", VA = "0x848F")]
		private void SpinValuePickerOnSelectionChangedEvent(uint attemptsNum)
		{
		/* --- GHIDRA: SpinValuePickerOnSelectionChangedEvent ---
		void Gameplay_Craft_View_CraftSpinPickerDialogWindow__SpinValuePickerOnSelectionChangedEvent
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 *puVar3;
		  undefined4 uVar4;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a57cff == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_CraftSpinPickerDialogWindow_CraftSpinPickerDialogWindowArgs__HandleContent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseWindow_CraftSpinPickerDialogWindow_CraftSpinPickerDialogWindowArgs__get_WindowArgs__
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Select_int__uint___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToArray_uint___);
		    Mono_Security_ASN1__get_Item(&System_Func_uint__string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_int__uint__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Craft_View_CraftSpinPickerDialogWindow___c__HandleContent_b__17_0__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Craft_View_CraftSpinPickerDialogWindow___c__HandleContent_b__17_1__)
		    ;
		    Mono_Security_ASN1__get_Item(&Gameplay_Craft_View_CraftSpinPickerDialogWindow___c_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UI_ValuePicker_ValuePicker_uint__Init__);
		    Mono_Security_ASN1__get_Item(&Method_UI_ValuePicker_ValuePicker_uint__ScrollTo__);
		    DAT_ram_00a57cff = '\x01';
		  }
		  UI_Windows_BaseDialogWindow_object___HandleButtons
		            (param1,
		             Method_UI_Windows_BaseDialogWindow_CraftSpinPickerDialogWindow_CraftSpinPickerDialogWindowArgs__HandleContent__
		            );
		  iVar1 = func_ii_8093(param1,
		                       Method_UI_Windows_BaseWindow_CraftSpinPickerDialogWindow_CraftSpinPickerDialogWindowArgs__get_WindowArgs__
		                      );
		  uVar2 = System_Linq_Error__NotSupported(1,*(undefined4 *)(iVar1 + 0x2c),0);
		  if (*(int *)(Gameplay_Craft_View_CraftSpinPickerDialogWindow___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Craft_View_CraftSpinPickerDialogWindow___c_TypeInfo);
		  }
		  puVar3 = *(undefined4 **)(Gameplay_Craft_View_CraftSpinPickerDialogWindow___c_TypeInfo + 0x5c);
		  iVar1 = puVar3[1];
		  if (iVar1 == 0) {
		    if (*(int *)(Gameplay_Craft_View_CraftSpinPickerDialogWindow___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_Craft_View_CraftSpinPickerDialogWindow___c_TypeInfo);
		      puVar3 = *(undefined4 **)(Gameplay_Craft_View_CraftSpinPickerDialogWindow___c_TypeInfo + 0x5c)
		      ;
		    }
		    uVar4 = *puVar3;
		    iVar1 = unnamed_function_1417(System_Func_int__uint__TypeInfo);
		    System_Func_int__float___Invoke
		              (iVar1,uVar4,
		               Method_Gameplay_Craft_View_CraftSpinPickerDialogWindow___c__HandleContent_b__17_0__,0
		              );
		    *(int *)(*(int *)(Gameplay_Craft_View_CraftSpinPickerDialogWindow___c_TypeInfo + 0x5c) + 4) =
		         iVar1;
		  }
		  uVar2 = System_Linq_Enumerable__ReverseIterator___Il2CppFullySharedGenericType_
		                    (uVar2,iVar1,Method_System_Linq_Enumerable_Select_int__uint___);
		  uVar2 = System_Linq_Enumerable__OrderBy_uint__uint_
		                    (uVar2,Method_System_Linq_Enumerable_ToArray_uint___);
		  uVar4 = *(undefined4 *)(param1 + 0x50);
		  if (*(int *)(Gameplay_Craft_View_CraftSpinPickerDialogWindow___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Craft_View_CraftSpinPickerDialogWindow___c_TypeInfo);
		  }
		  puVar3 = *(undefined4 **)(Gameplay_Craft_View_CraftSpinPickerDialogWindow___c_TypeInfo + 0x5c);
		  iVar1 = puVar3[2];
		  if (iVar1 == 0) {
		    if (*(int *)(Gameplay_Craft_View_CraftSpinPickerDialogWindow___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_Craft_View_CraftSpinPickerDialogWindow___c_TypeInfo);
		      puVar3 = *(undefined4 **)(Gameplay_Craft_View_CraftSpinPickerDialogWindow___c_TypeInfo + 0x5c)
		      ;
		    }
		    param2_00 = *puVar3;
		    iVar1 = unnamed_function_1417(System_Func_uint__string__TypeInfo);
		    System_Linq_Enumerable__Distinct_uint_
		              (iVar1,param2_00,
		               Method_Gameplay_Craft_View_CraftSpinPickerDialogWindow___c__HandleContent_b__17_1__,0
		              );
		    *(int *)(*(int *)(Gameplay_Craft_View_CraftSpinPickerDialogWindow___c_TypeInfo + 0x5c) + 8) =
		         iVar1;
		  }
		  UI_ValuePicker_ValuePicker_uint___Awake
		            (uVar4,uVar2,iVar1,Method_UI_ValuePicker_ValuePicker_uint__Init__);
		  UI_ValuePicker_ValuePicker_uint___OnDestroy
		            (*(undefined4 *)(param1 + 0x50),1,Method_UI_ValuePicker_ValuePicker_uint__ScrollTo__);
		  return;
		}
		*/

		}

		// Token: 0x06003466 RID: 13414 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003466")]
		[Address(RVA = "0x8490", Offset = "0x8490", VA = "0x8490", Slot = "28")]
		protected override void HandleContent()
		{
		/* --- GHIDRA: HandleContent ---
		undefined4
		Gameplay_Craft_View_CraftSpinPickerDialogWindow__HandleContent
		          (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int param1_00;
		  
		  if (DAT_ram_00a57d00 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Craft_View_CraftSpinPickerDialogWindow_CraftSpinPickerDialogWindowArgs_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_PopupController_Show_CraftSpinPickerDialogWindow___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12606);
		    DAT_ram_00a57d00 = '\x01';
		  }
		  uVar1 = System_Uri___ctor(0);
		  uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar1,0);
		  param1_00 = unnamed_function_1417
		                        (
		                        Gameplay_Craft_View_CraftSpinPickerDialogWindow_CraftSpinPickerDialogWindowArgs_TypeInfo
		                        );
		  Gameplay_Craft_View_CraftSpinPickerDialogWindow___ctor(param1_00,param1_00);
		  *(undefined4 *)(param1_00 + 0x30) = param2;
		  *(undefined4 *)(param1_00 + 0x2c) = param1;
		  uVar1 = Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		                    (uVar1,StringLiteral_12606,param1_00,
		                     Method_UI_Windows_PopupController_Show_CraftSpinPickerDialogWindow___);
		  return uVar1;
		}
		*/

		}

		// Token: 0x06003467 RID: 13415 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003467")]
		[Address(RVA = "0x8491", Offset = "0x8491", VA = "0x8491")]
		public static CraftSpinPickerDialogWindow Show(int maxQuantity, int maxEnoughQuantity)
		{
		/* --- GHIDRA: Show ---
		void Gameplay_Craft_View_CraftSpinPickerDialogWindow__Show(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57d01 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_CraftSpinPickerDialogWindow_CraftSpinPickerDialogWindowArgs___ctor__
		              );
		    DAT_ram_00a57d01 = '\x01';
		  }
		  UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_object____ctor
		            (param1,
		             Method_UI_Windows_BaseDialogWindow_CraftSpinPickerDialogWindow_CraftSpinPickerDialogWindowArgs___ctor__
		            );
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06003468 RID: 13416 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003468")]
		[Address(RVA = "0x8492", Offset = "0x8492", VA = "0x8492")]
		public CraftSpinPickerDialogWindow()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Craft_View_CraftSpinPickerDialogWindow___ctor(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int param1_00;
		  int param1_01;
		  uint uVar3;
		  
		  if (DAT_ram_00a57d02 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_CraftSpinPickerDialogWindow_CraftSpinPickerDialogWindowArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_CraftSpinPickerDialogWindow_CraftSpinPickerDialogWindowArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_CraftSpinPickerDialogWindow_CraftSpinPickerDialogWindowArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_CraftSpinPickerDialogWindow_CraftSpinPickerDialogWindowArgs___Add__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_CraftSpinPickerDialogWindow_CraftSpinPickerDialogWindowArgs____ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_CraftSpinPickerDialogWindow_CraftSpinPickerDialogWindowArgs___TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&StringLiteral_4470);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4474);
		    DAT_ram_00a57d02 = '\x01';
		  }
		  UnityEngine_UIElements_BaseCompositeField___Il2CppFullySharedGenericType__object____Il2CppFullySharedGenericType___UpdateMixedValueContent
		            (param1,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_CraftSpinPickerDialogWindow_CraftSpinPickerDialogWindowArgs___ctor__
		            );
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar2 = func_ii_7508(StringLiteral_4474,1,0,1,0,0,0,0);
		  *(undefined4 *)(param1 + 0x18) = uVar2;
		  uVar2 = func_ii_7508(StringLiteral_4470,1,0,1,0,0,0,0);
		  *(undefined4 *)(param1 + 0x1c) = uVar2;
		  param1_00 = unnamed_function_1417
		                        (
		                        System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_CraftSpinPickerDialogWindow_CraftSpinPickerDialogWindowArgs___TypeInfo
		                        );
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,
		             Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_CraftSpinPickerDialogWindow_CraftSpinPickerDialogWindowArgs____ctor__
		            );
		  param1_01 = unnamed_function_1417
		                        (
		                        UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_CraftSpinPickerDialogWindow_CraftSpinPickerDialogWindowArgs__TypeInfo
		                        );
		  UI_Windows_DialogWindow_DialogWindowArgs___ctor
		            (param1_01,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_CraftSpinPickerDialogWindow_CraftSpinPickerDialogWindowArgs___ctor__
		            );
		  uVar2 = UI_Windows_DialogWindow__get_OK_LABEL(0);
		  *(undefined4 *)(param1_01 + 8) = uVar2;
		  iVar1 = 
		  Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_CraftSpinPickerDialogWindow_CraftSpinPickerDialogWindowArgs___Add__
		  ;
		  *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		  uVar3 = *(uint *)(param1_00 + 0xc);
		  if (uVar3 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		    *(uint *)(param1_00 + 0xc) = uVar3 + 1;
		    *(int *)(*(int *)(param1_00 + 8) + uVar3 * 4 + 0x10) = param1_01;
		    *(int *)(param1 + 0x24) = param1_00;
		    return;
		  }
		  System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		            (param1_00,param1_01,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  *(int *)(param1 + 0x24) = param1_00;
		  return;
		}
		*/

		}

		// Token: 0x04001C99 RID: 7321
		[Token(Token = "0x4001C99")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Craft/SpinPickerDialogWindow";

		// Token: 0x04001C9A RID: 7322
		[Token(Token = "0x4001C9A")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private SpinValuePicker _spinValuePicker;

		// Token: 0x04001C9B RID: 7323
		[Token(Token = "0x4001C9B")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private ButtonWithCost _confirmButton;

		// Token: 0x04001C9C RID: 7324
		[Token(Token = "0x4001C9C")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private LoaderValueRowView _valueRow;

		// Token: 0x020008B6 RID: 2230
		[Token(Token = "0x20008B6")]
		public class CraftSpinPickerDialogWindowArgs : BaseDialogWindow<CraftSpinPickerDialogWindow.CraftSpinPickerDialogWindowArgs>.BaseDialogWindowArgs
		{
			// Token: 0x06003469 RID: 13417 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003469")]
			[Address(RVA = "0x8493", Offset = "0x8493", VA = "0x8493")]
			public CraftSpinPickerDialogWindowArgs()
			{
			}

			// Token: 0x04001C9F RID: 7327
			[Token(Token = "0x4001C9F")]
			[FieldOffset(Offset = "0x2C")]
			public int MaxQuantity;

			// Token: 0x04001CA0 RID: 7328
			[Token(Token = "0x4001CA0")]
			[FieldOffset(Offset = "0x30")]
			public int MaxEnoughQuantity;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_SelectedAttemptsNum ---
		void Gameplay_Craft_View_CraftSpinPickerDialogWindow__set_SelectedAttemptsNum
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a57cfa == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_uint__TypeInfo);
		    DAT_ram_00a57cfa = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x60);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_uint__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_uint__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x60,iVar2,param1_00);
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


		/* --- GHIDRA: add_SelectedEvent ---
		void Gameplay_Craft_View_CraftSpinPickerDialogWindow__add_SelectedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a57cfb == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_uint__TypeInfo);
		    DAT_ram_00a57cfb = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x60);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_uint__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_uint__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x60,iVar2,param1_00);
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


		/* --- GHIDRA: remove_SelectedEvent ---
		void Gameplay_Craft_View_CraftSpinPickerDialogWindow__remove_SelectedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a57cfc == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_uint__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseWindow_CraftSpinPickerDialogWindow_CraftSpinPickerDialogWindowArgs__OnShow__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Craft_View_CraftSpinPickerDialogWindow_ConfirmButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Craft_View_CraftSpinPickerDialogWindow_SpinValuePickerOnSelectionChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_ValuePicker_ValuePicker_uint__add_SelectionChangedEvent__);
		    DAT_ram_00a57cfc = '\x01';
		  }
		  UI_Windows_BaseWindow_object____ctor
		            (param1,param2,
		             Method_UI_Windows_BaseWindow_CraftSpinPickerDialogWindow_CraftSpinPickerDialogWindowArgs__OnShow__
		            );
		  uVar2 = *(undefined4 *)(param1 + 0x50);
		  uVar1 = unnamed_function_1417(System_Action_uint__TypeInfo);
		  func_ii_12322(uVar1,param1,
		                Method_Gameplay_Craft_View_CraftSpinPickerDialogWindow_SpinValuePickerOnSelectionChangedEvent__
		                ,0);
		  UI_ValuePicker_ValuePicker___Il2CppFullySharedGenericType___SpinnerOnCurrentSelectedIndexChangedEvent
		            (uVar2,uVar1,Method_UI_ValuePicker_ValuePicker_uint__add_SelectionChangedEvent__);
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 0x54) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,
		             Method_Gameplay_Craft_View_CraftSpinPickerDialogWindow_ConfirmButtonClickedEventHandler__
		             ,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar2,uVar1,0);
		  return;
		}
		*/

}
