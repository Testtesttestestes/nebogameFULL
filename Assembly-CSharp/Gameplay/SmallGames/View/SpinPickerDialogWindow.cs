using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Money;
using Il2CppDummyDll;
using UI.Elements.Buttons;
using UI.Windows;
using UnityEngine;

namespace Gameplay.SmallGames.View
{
	// Token: 0x02000525 RID: 1317
	[Token(Token = "0x2000525")]
	public class SpinPickerDialogWindow : BaseDialogWindow<SpinPickerDialogWindow.SpinPickerDialogWindowArgs>
	{
		// Token: 0x170005BB RID: 1467
		// (get) Token: 0x06001F60 RID: 8032 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170005BB")]
		public override string WindowId
		{
			[Token(Token = "0x6001F60")]
			[Address(RVA = "0x70C6", Offset = "0x70C6", VA = "0x70C6", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005BC RID: 1468
		// (get) Token: 0x06001F61 RID: 8033 RVA: 0x00006648 File Offset: 0x00004848
		// (set) Token: 0x06001F62 RID: 8034 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005BC")]
		public uint SelectedAttemptsNum
		{
			[Token(Token = "0x6001F61")]
			[Address(RVA = "0x70C7", Offset = "0x70C7", VA = "0x70C7")]
			[CompilerGenerated]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001F62")]
			[Address(RVA = "0x70C8", Offset = "0x70C8", VA = "0x70C8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1400013A RID: 314
		// (add) Token: 0x06001F63 RID: 8035 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06001F64 RID: 8036 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400013A")]
		public event Action<uint> SelectedEvent
		{
			[Token(Token = "0x6001F63")]
			[Address(RVA = "0x70C9", Offset = "0x70C9", VA = "0x70C9")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6001F64")]
			[Address(RVA = "0x70CA", Offset = "0x70CA", VA = "0x70CA")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06001F65 RID: 8037 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F65")]
		[Address(RVA = "0x70CB", Offset = "0x70CB", VA = "0x70CB", Slot = "18")]
		protected override void OnShow(BaseWindowArgs args)
		{
		/* --- GHIDRA: OnShow ---
		void Gameplay_SmallGames_View_SpinPickerDialogWindow__OnShow(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a58285 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_uint__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_SpinPickerDialogWindow_SpinPickerDialogWindowArgs__OnClose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_SmallGames_View_SpinPickerDialogWindow_ConfirmButtonClickHandler__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_SmallGames_View_SpinPickerDialogWindow_SpinValuePickerOnSelectionChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_ValuePicker_ValuePicker_uint__remove_SelectionChangedEvent__);
		    DAT_ram_00a58285 = '\x01';
		  }
		  UI_Windows_BaseDialogWindow_object___HandleTitle
		            (param1,
		             Method_UI_Windows_BaseDialogWindow_SpinPickerDialogWindow_SpinPickerDialogWindowArgs__OnClose__
		            );
		  uVar2 = *(undefined4 *)(param1 + 0x50);
		  uVar1 = unnamed_function_1417(System_Action_uint__TypeInfo);
		  func_ii_12322(uVar1,param1,
		                Method_Gameplay_SmallGames_View_SpinPickerDialogWindow_SpinValuePickerOnSelectionChangedEvent__
		                ,0);
		  UI_ValuePicker_ValuePicker___Il2CppFullySharedGenericType___add_SelectionChangedEvent
		            (uVar2,uVar1,Method_UI_ValuePicker_ValuePicker_uint__remove_SelectionChangedEvent__);
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 0x54) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,
		             Method_Gameplay_SmallGames_View_SpinPickerDialogWindow_ConfirmButtonClickHandler__,0);
		  UnityEngine_Events_UnityAction___ctor(uVar2,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x06001F66 RID: 8038 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F66")]
		[Address(RVA = "0x70CC", Offset = "0x70CC", VA = "0x70CC", Slot = "19")]
		protected override void OnClose()
		{
		/* --- GHIDRA: OnClose ---
		void Gameplay_SmallGames_View_SpinPickerDialogWindow__OnClose(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param1 + 0x5c);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(param1 + 0x58),
		               *(undefined4 *)(iVar1 + 0x14));
		  }
		  System_ComponentModel_BindingList___Il2CppFullySharedGenericType___OnAddingNew(param1,2,0);
		  return;
		}
		*/

		}

		// Token: 0x06001F67 RID: 8039 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F67")]
		[Address(RVA = "0x70CD", Offset = "0x70CD", VA = "0x70CD")]
		private void ConfirmButtonClickHandler()
		{
		/* --- GHIDRA: ConfirmButtonClickHandler ---
		void Gameplay_SmallGames_View_SpinPickerDialogWindow__ConfirmButtonClickHandler
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  uint uVar3;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a58286 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseWindow_SpinPickerDialogWindow_SpinPickerDialogWindowArgs__get_WindowArgs__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		    DAT_ram_00a58286 = '\x01';
		  }
		  *(undefined4 *)(param1 + 0x58) = param2;
		  iVar1 = func_ii_8093(param1,
		                       Method_UI_Windows_BaseWindow_SpinPickerDialogWindow_SpinPickerDialogWindowArgs__get_WindowArgs__
		                      );
		  uVar2 = *(undefined4 *)(iVar1 + 0x2c);
		  uVar3 = *(uint *)(param1 + 0x58);
		  if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_Money_TypeInfo);
		  }
		  uVar2 = Core_Money_Money__op_Subtraction(uVar2,(double)uVar3,0);
		  param1_00 = *(undefined4 *)(*(int *)(param1 + 0x54) + 0xb8);
		  iVar1 = func_ii_8093(param1,
		                       Method_UI_Windows_BaseWindow_SpinPickerDialogWindow_SpinPickerDialogWindowArgs__get_WindowArgs__
		                      );
		  UI_Price_Price__SetColor(param1_00,*(undefined4 *)(iVar1 + 0x30),uVar2,0);
		  return;
		}
		*/

		}

		// Token: 0x06001F68 RID: 8040 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F68")]
		[Address(RVA = "0x70CE", Offset = "0x70CE", VA = "0x70CE")]
		private void SpinValuePickerOnSelectionChangedEvent(uint attemptsNum)
		{
		/* --- GHIDRA: SpinValuePickerOnSelectionChangedEvent ---
		void Gameplay_SmallGames_View_SpinPickerDialogWindow__SpinValuePickerOnSelectionChangedEvent
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param2_00;
		  undefined4 *puVar3;
		  undefined4 param2_01;
		  
		  if (DAT_ram_00a58287 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_SpinPickerDialogWindow_SpinPickerDialogWindowArgs__HandleContent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseWindow_SpinPickerDialogWindow_SpinPickerDialogWindowArgs__get_WindowArgs__
		              );
		    Mono_Security_ASN1__get_Item(&System_Func_uint__string__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_SmallGames_View_SpinPickerDialogWindow___c__HandleContent_b__16_0__)
		    ;
		    Mono_Security_ASN1__get_Item(&Gameplay_SmallGames_View_SpinPickerDialogWindow___c_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UI_ValuePicker_ValuePicker_uint__Init__);
		    Mono_Security_ASN1__get_Item(&Method_UI_ValuePicker_ValuePicker_uint__ScrollTo__);
		    DAT_ram_00a58287 = '\x01';
		  }
		  UI_Windows_BaseDialogWindow_object___HandleButtons
		            (param1,
		             Method_UI_Windows_BaseDialogWindow_SpinPickerDialogWindow_SpinPickerDialogWindowArgs__HandleContent__
		            );
		  uVar2 = *(undefined4 *)(param1 + 0x50);
		  iVar1 = func_ii_8093(param1,
		                       Method_UI_Windows_BaseWindow_SpinPickerDialogWindow_SpinPickerDialogWindowArgs__get_WindowArgs__
		                      );
		  param2_00 = *(undefined4 *)(iVar1 + 0x38);
		  if (*(int *)(Gameplay_SmallGames_View_SpinPickerDialogWindow___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_SmallGames_View_SpinPickerDialogWindow___c_TypeInfo);
		  }
		  puVar3 = *(undefined4 **)(Gameplay_SmallGames_View_SpinPickerDialogWindow___c_TypeInfo + 0x5c);
		  iVar1 = puVar3[1];
		  if (iVar1 == 0) {
		    if (*(int *)(Gameplay_SmallGames_View_SpinPickerDialogWindow___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_SmallGames_View_SpinPickerDialogWindow___c_TypeInfo);
		      puVar3 = *(undefined4 **)(Gameplay_SmallGames_View_SpinPickerDialogWindow___c_TypeInfo + 0x5c)
		      ;
		    }
		    param2_01 = *puVar3;
		    iVar1 = unnamed_function_1417(System_Func_uint__string__TypeInfo);
		    System_Linq_Enumerable__Distinct_uint_
		              (iVar1,param2_01,
		               Method_Gameplay_SmallGames_View_SpinPickerDialogWindow___c__HandleContent_b__16_0__,0
		              );
		    *(int *)(*(int *)(Gameplay_SmallGames_View_SpinPickerDialogWindow___c_TypeInfo + 0x5c) + 4) =
		         iVar1;
		  }
		  UI_ValuePicker_ValuePicker_uint___Awake
		            (uVar2,param2_00,iVar1,Method_UI_ValuePicker_ValuePicker_uint__Init__);
		  uVar2 = *(undefined4 *)(param1 + 0x50);
		  iVar1 = func_ii_8093(param1,
		                       Method_UI_Windows_BaseWindow_SpinPickerDialogWindow_SpinPickerDialogWindowArgs__get_WindowArgs__
		                      );
		  UI_ValuePicker_ValuePicker_uint___OnDestroy
		            (uVar2,*(undefined4 *)(iVar1 + 0x34),Method_UI_ValuePicker_ValuePicker_uint__ScrollTo__)
		  ;
		  return;
		}
		*/

		}

		// Token: 0x06001F69 RID: 8041 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F69")]
		[Address(RVA = "0x70CF", Offset = "0x70CF", VA = "0x70CF", Slot = "28")]
		protected override void HandleContent()
		{
		/* --- GHIDRA: HandleContent ---
		undefined4
		Gameplay_SmallGames_View_SpinPickerDialogWindow__HandleContent(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a58288 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_PopupController_Show_SpinPickerDialogWindow___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12668);
		    DAT_ram_00a58288 = '\x01';
		  }
		  uVar1 = System_Uri___ctor(0);
		  uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar1,0);
		  uVar1 = Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		                    (uVar1,StringLiteral_12668,param1,
		                     Method_UI_Windows_PopupController_Show_SpinPickerDialogWindow___);
		  return uVar1;
		}
		*/

		}

		// Token: 0x06001F6A RID: 8042 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001F6A")]
		[Address(RVA = "0x70D0", Offset = "0x70D0", VA = "0x70D0")]
		public static SpinPickerDialogWindow Show(SpinPickerDialogWindow.SpinPickerDialogWindowArgs args)
		{
		/* --- GHIDRA: Show ---
		void Gameplay_SmallGames_View_SpinPickerDialogWindow__Show(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a58289 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_SpinPickerDialogWindow_SpinPickerDialogWindowArgs___ctor__
		              );
		    DAT_ram_00a58289 = '\x01';
		  }
		  UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_object____ctor
		            (param1,
		             Method_UI_Windows_BaseDialogWindow_SpinPickerDialogWindow_SpinPickerDialogWindowArgs___ctor__
		            );
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06001F6B RID: 8043 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F6B")]
		[Address(RVA = "0x70D1", Offset = "0x70D1", VA = "0x70D1")]
		public SpinPickerDialogWindow()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_SmallGames_View_SpinPickerDialogWindow___ctor
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5,
		               undefined4 param6)
		
		{
		  if (DAT_ram_00a5828a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_SpinPickerDialogWindow_SpinPickerDialogWindowArgs___ctor__
		              );
		    DAT_ram_00a5828a = '\x01';
		  }
		  UnityEngine_UIElements_BaseCompositeField___Il2CppFullySharedGenericType__object____Il2CppFullySharedGenericType___UpdateMixedValueContent
		            (param1,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_SpinPickerDialogWindow_SpinPickerDialogWindowArgs___ctor__
		            );
		  *(undefined4 *)(param1 + 0x38) = param3;
		  *(undefined4 *)(param1 + 0x34) = param2;
		  *(undefined4 *)(param1 + 0x30) = param5;
		  *(undefined4 *)(param1 + 0x2c) = param4;
		  return;
		}
		*/

		}

		// Token: 0x04001115 RID: 4373
		[Token(Token = "0x4001115")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/SmallGames/SpinPickerDialogWindow";

		// Token: 0x04001116 RID: 4374
		[Token(Token = "0x4001116")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private SpinValuePicker _spinValuePicker;

		// Token: 0x04001117 RID: 4375
		[Token(Token = "0x4001117")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private ButtonWithCost _buttonWithCost;

		// Token: 0x02000526 RID: 1318
		[Token(Token = "0x2000526")]
		public class SpinPickerDialogWindowArgs : BaseDialogWindow<SpinPickerDialogWindow.SpinPickerDialogWindowArgs>.BaseDialogWindowArgs
		{
			// Token: 0x06001F6C RID: 8044 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001F6C")]
			[Address(RVA = "0x70D2", Offset = "0x70D2", VA = "0x70D2")]
			public SpinPickerDialogWindowArgs(uint startValue, uint[] values, Money price, UserData user)
			{
			}

			// Token: 0x0400111A RID: 4378
			[Token(Token = "0x400111A")]
			[FieldOffset(Offset = "0x2C")]
			public readonly Money Price;

			// Token: 0x0400111B RID: 4379
			[Token(Token = "0x400111B")]
			[FieldOffset(Offset = "0x30")]
			public readonly UserData User;

			// Token: 0x0400111C RID: 4380
			[Token(Token = "0x400111C")]
			[FieldOffset(Offset = "0x34")]
			public readonly uint StartValue;

			// Token: 0x0400111D RID: 4381
			[Token(Token = "0x400111D")]
			[FieldOffset(Offset = "0x38")]
			public readonly uint[] Values;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_SelectedAttemptsNum ---
		void Gameplay_SmallGames_View_SpinPickerDialogWindow__set_SelectedAttemptsNum
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a58282 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_uint__TypeInfo);
		    DAT_ram_00a58282 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x5c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_uint__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_uint__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x5c,iVar2,param1_00);
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
		void Gameplay_SmallGames_View_SpinPickerDialogWindow__add_SelectedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a58283 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_uint__TypeInfo);
		    DAT_ram_00a58283 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x5c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_uint__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_uint__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x5c,iVar2,param1_00);
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
		void Gameplay_SmallGames_View_SpinPickerDialogWindow__remove_SelectedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a58284 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_uint__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseWindow_SpinPickerDialogWindow_SpinPickerDialogWindowArgs__OnShow__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_SmallGames_View_SpinPickerDialogWindow_ConfirmButtonClickHandler__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_SmallGames_View_SpinPickerDialogWindow_SpinValuePickerOnSelectionChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_ValuePicker_ValuePicker_uint__add_SelectionChangedEvent__);
		    DAT_ram_00a58284 = '\x01';
		  }
		  UI_Windows_BaseWindow_object____ctor
		            (param1,param2,
		             Method_UI_Windows_BaseWindow_SpinPickerDialogWindow_SpinPickerDialogWindowArgs__OnShow__
		            );
		  uVar2 = *(undefined4 *)(param1 + 0x50);
		  uVar1 = unnamed_function_1417(System_Action_uint__TypeInfo);
		  func_ii_12322(uVar1,param1,
		                Method_Gameplay_SmallGames_View_SpinPickerDialogWindow_SpinValuePickerOnSelectionChangedEvent__
		                ,0);
		  UI_ValuePicker_ValuePicker___Il2CppFullySharedGenericType___SpinnerOnCurrentSelectedIndexChangedEvent
		            (uVar2,uVar1,Method_UI_ValuePicker_ValuePicker_uint__add_SelectionChangedEvent__);
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 0x54) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,
		             Method_Gameplay_SmallGames_View_SpinPickerDialogWindow_ConfirmButtonClickHandler__,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar2,uVar1,0);
		  return;
		}
		*/

}
