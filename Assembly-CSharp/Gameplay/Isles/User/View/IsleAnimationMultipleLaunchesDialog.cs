using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Money;
using Il2CppDummyDll;
using Protocol.Dic;
using TMPro;
using UI.Elements.Buttons;
using UI.Elements.Sliders;
using UI.Windows;
using UnityEngine;
using Utils;

namespace Gameplay.Isles.User.View
{
	// Token: 0x02000D13 RID: 3347
	[Token(Token = "0x2000D13")]
	public sealed class IsleAnimationMultipleLaunchesDialog : BaseDialogWindow<IsleAnimationMultipleLaunchesDialog.Args>
	{
		// Token: 0x17001087 RID: 4231
		// (get) Token: 0x060051B1 RID: 20913 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001087")]
		public override string WindowId
		{
			[Token(Token = "0x60051B1")]
			[Address(RVA = "0x9F8B", Offset = "0x9F8B", VA = "0x9F8B", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001088 RID: 4232
		// (get) Token: 0x060051B2 RID: 20914 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001088")]
		public SliderWithButtons Slider
		{
			[Token(Token = "0x60051B2")]
			[Address(RVA = "0x9F8C", Offset = "0x9F8C", VA = "0x9F8C")]
			get
			{
				return null;
			}
		}

		// Token: 0x140001F1 RID: 497
		// (add) Token: 0x060051B3 RID: 20915 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060051B4 RID: 20916 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001F1")]
		public event Action<IsleAnimationMultipleLaunchesDialog> SelectedEvent
		{
			[Token(Token = "0x60051B3")]
			[Address(RVA = "0x9F8D", Offset = "0x9F8D", VA = "0x9F8D")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60051B4")]
			[Address(RVA = "0x9F8E", Offset = "0x9F8E", VA = "0x9F8E")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140001F2 RID: 498
		// (add) Token: 0x060051B5 RID: 20917 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060051B6 RID: 20918 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001F2")]
		public event Action<IsleAnimationMultipleLaunchesDialog> RequestQuickSelectionValueEvent
		{
			[Token(Token = "0x60051B5")]
			[Address(RVA = "0x9F8F", Offset = "0x9F8F", VA = "0x9F8F")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60051B6")]
			[Address(RVA = "0x9F90", Offset = "0x9F90", VA = "0x9F90")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x060051B7 RID: 20919 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051B7")]
		[Address(RVA = "0x9F91", Offset = "0x9F91", VA = "0x9F91", Slot = "19")]
		protected override void OnClose()
		{
		/* --- GHIDRA: OnClose ---
		void Gameplay_Isles_User_View_IsleAnimationMultipleLaunchesDialog__OnClose
		               (int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a58d35 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_int__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_IsleAnimationMultipleLaunchesDialog_Args__OnShow__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_User_View_IsleAnimationMultipleLaunchesDialog_HandleClickPriceButtonEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_User_View_IsleAnimationMultipleLaunchesDialog_SliderButtonOnLongTapEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_User_View_IsleAnimationMultipleLaunchesDialog_SliderOnOnValueChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item(&Utils_LongTap_LongTapHandler_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a58d35 = '\x01';
		  }
		  UI_Windows_BaseDialogWindow_object___OnDestroy
		            (param1,param2,
		             Method_UI_Windows_BaseDialogWindow_IsleAnimationMultipleLaunchesDialog_Args__OnShow__);
		  UI_Elements_Sliders_SliderWithButtons__SetLimitValues
		            (*(undefined4 *)(param1 + 0x54),*(undefined4 *)(param2 + 0x30),*(int *)(param2 + 0x34),
		             *(int *)(param2 + 0x34) / 2,0);
		  UI_Elements_Sliders_SliderWithButtons__get_Value
		            (*(undefined4 *)(param1 + 0x54),*(undefined4 *)(param2 + 0x2c),0);
		  Gameplay_Isles_User_View_IsleAnimationMultipleLaunchesDialog__SliderOnOnValueChangedEvent
		            (param1,*(undefined4 *)(param2 + 0x2c),param2);
		  Gameplay_Isles_User_View_IsleAnimationMultipleLaunchesDialog__DisplayPrice
		            (param1,*(undefined4 *)(param2 + 0x2c),*(undefined4 *)(param2 + 0x34),param2);
		  uVar3 = *(undefined4 *)(param1 + 0x54);
		  uVar2 = unnamed_function_1417(System_Action_int__TypeInfo);
		  System_Action_short___Invoke
		            (uVar2,param1,
		             Method_Gameplay_Isles_User_View_IsleAnimationMultipleLaunchesDialog_SliderOnOnValueChangedEvent__
		             ,0);
		  UI_Elements_ShopItem___ctor(uVar3,uVar2,0);
		  uVar3 = *(undefined4 *)(*(int *)(param1 + 0x58) + 0xb4);
		  uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar2,param1,
		             Method_Gameplay_Isles_User_View_IsleAnimationMultipleLaunchesDialog_HandleClickPriceButtonEvent__
		             ,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar3,uVar2,0);
		  if ((*(int *)(param1 + 0x60) < *(int *)(param2 + 0x34)) &&
		     (iVar4 = *(int *)(param1 + 0x5c), 0 < *(int *)(iVar4 + 0xc))) {
		    iVar1 = 0;
		    do {
		      uVar3 = *(undefined4 *)(iVar4 + iVar1 * 4 + 0x10);
		      uVar2 = unnamed_function_1417(Utils_LongTap_LongTapHandler_TypeInfo);
		      Utils_LongTap___cctor
		                (uVar2,param1,
		                 Method_Gameplay_Isles_User_View_IsleAnimationMultipleLaunchesDialog_SliderButtonOnLongTapEvent__
		                 ,0);
		      Utils_LongTap__remove_CancelLongTapEvent(uVar3,uVar2,0);
		      iVar1 = iVar1 + 1;
		    } while (iVar1 < *(int *)(iVar4 + 0xc));
		  }
		  return;
		}
		*/

		}

		// Token: 0x060051B8 RID: 20920 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051B8")]
		[Address(RVA = "0x9F92", Offset = "0x9F92", VA = "0x9F92", Slot = "22")]
		protected override void OnShow(IsleAnimationMultipleLaunchesDialog.Args args)
		{
		/* --- GHIDRA: OnShow ---
		void Gameplay_Isles_User_View_IsleAnimationMultipleLaunchesDialog__OnShow
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param1 + 0x68);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param1,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x060051B9 RID: 20921 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051B9")]
		[Address(RVA = "0x9F93", Offset = "0x9F93", VA = "0x9F93")]
		private void SliderButtonOnLongTapEvent(LongTap sender)
		{
		/* --- GHIDRA: SliderButtonOnLongTapEvent ---
		void Gameplay_Isles_User_View_IsleAnimationMultipleLaunchesDialog__SliderButtonOnLongTapEvent
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param1 + 100);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param1,*(undefined4 *)(iVar1 + 0x14));
		  }
		  System_ComponentModel_BindingList___Il2CppFullySharedGenericType___OnAddingNew(param1,2,0);
		  return;
		}
		*/

		}

		// Token: 0x060051BA RID: 20922 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051BA")]
		[Address(RVA = "0x9F94", Offset = "0x9F94", VA = "0x9F94")]
		private void HandleClickPriceButtonEvent()
		{
		/* --- GHIDRA: HandleClickPriceButtonEvent ---
		void Gameplay_Isles_User_View_IsleAnimationMultipleLaunchesDialog__HandleClickPriceButtonEvent
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a58d36 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseWindow_IsleAnimationMultipleLaunchesDialog_Args__get_WindowArgs__
		              );
		    DAT_ram_00a58d36 = '\x01';
		  }
		  Gameplay_Isles_User_View_IsleAnimationMultipleLaunchesDialog__SliderOnOnValueChangedEvent
		            (param1,param2,param1);
		  iVar1 = func_ii_8093(param1,
		                       Method_UI_Windows_BaseWindow_IsleAnimationMultipleLaunchesDialog_Args__get_WindowArgs__
		                      );
		  Gameplay_Isles_User_View_IsleAnimationMultipleLaunchesDialog__DisplayPrice
		            (param1,param2,*(undefined4 *)(iVar1 + 0x34),param1);
		  return;
		}
		*/

		}

		// Token: 0x060051BB RID: 20923 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051BB")]
		[Address(RVA = "0x9F95", Offset = "0x9F95", VA = "0x9F95")]
		private void SliderOnOnValueChangedEvent(int value)
		{
		/* --- GHIDRA: SliderOnOnValueChangedEvent ---
		void Gameplay_Isles_User_View_IsleAnimationMultipleLaunchesDialog__SliderOnOnValueChangedEvent
		               (int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  undefined4 param2_00;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a58d37 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseWindow_IsleAnimationMultipleLaunchesDialog_Args__get_WindowArgs__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		    DAT_ram_00a58d37 = '\x01';
		  }
		  param1_00 = *(undefined4 *)(*(int *)(param1 + 0x58) + 0xb8);
		  iVar1 = func_ii_8093(param1,
		                       Method_UI_Windows_BaseWindow_IsleAnimationMultipleLaunchesDialog_Args__get_WindowArgs__
		                      );
		  param2_00 = *(undefined4 *)(iVar1 + 0x3c);
		  iVar1 = func_ii_8093(param1,
		                       Method_UI_Windows_BaseWindow_IsleAnimationMultipleLaunchesDialog_Args__get_WindowArgs__
		                      );
		  uVar2 = *(undefined4 *)(iVar1 + 0x38);
		  if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_Money_TypeInfo);
		  }
		  uVar2 = Core_Money_Money__op_Subtraction(uVar2,(double)param2,0);
		  UI_Price_Price__SetColor(param1_00,param2_00,uVar2,0);
		  return;
		}
		*/

		}

		// Token: 0x060051BC RID: 20924 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051BC")]
		[Address(RVA = "0x9F96", Offset = "0x9F96", VA = "0x9F96")]
		private void DisplayPrice(int multiplier)
		{
		/* --- GHIDRA: DisplayPrice ---
		void Gameplay_Isles_User_View_IsleAnimationMultipleLaunchesDialog__DisplayPrice
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined4 local_8;
		  undefined4 local_4;
		  
		  local_8 = param3;
		  local_4 = param2;
		  if (DAT_ram_00a58d38 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_KeyValuePair_string__string____TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22118);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27779);
		    Mono_Security_ASN1__get_Item(&StringLiteral_9151);
		    DAT_ram_00a58d38 = '\x01';
		  }
		  piVar4 = *(int **)(param1 + 0x50);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar1 = func_ii_7508(StringLiteral_9151,1,0,1,0,0,0,0);
		  iVar2 = Mono_Security_ASN1Convert__ToOid
		                    (System_Collections_Generic_KeyValuePair_string__string____TypeInfo,2);
		  uVar3 = func_ii_4443(&local_4,0);
		  local_10 = 0;
		  System_Text_Formatting_StringView__get_IsEmpty
		            (&local_10,StringLiteral_22118,uVar3,
		             Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		  *(undefined8 *)(iVar2 + 0x10) = local_10;
		  uVar3 = func_ii_4443(&local_8,0);
		  local_18 = 0;
		  System_Text_Formatting_StringView__get_IsEmpty
		            (&local_18,StringLiteral_27779,uVar3,
		             Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		  *(undefined8 *)(iVar2 + 0x18) = local_18;
		  uVar1 = Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsRewardsTab_ClanWarsRewardsView__GetPlacesText
		                    (uVar1,iVar2,0);
		  iVar2 = *piVar4;
		  (**(code **)((ulonglong)*(uint *)(iVar2 + 0x2d0) * 4))
		            (piVar4,uVar1,*(undefined4 *)(iVar2 + 0x2d4));
		  return;
		}
		*/

		}

		// Token: 0x060051BD RID: 20925 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051BD")]
		[Address(RVA = "0x9F97", Offset = "0x9F97", VA = "0x9F97")]
		private void DisplaySelectedValues(int current, int total)
		{
		/* --- GHIDRA: DisplaySelectedValues ---
		void Gameplay_Isles_User_View_IsleAnimationMultipleLaunchesDialog__DisplaySelectedValues
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a58d39 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_BaseDialogWindow_IsleAnimationMultipleLaunchesDialog_Args___ctor__
		              );
		    DAT_ram_00a58d39 = '\x01';
		  }
		  UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_object____ctor
		            (param1,
		             Method_UI_Windows_BaseDialogWindow_IsleAnimationMultipleLaunchesDialog_Args___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x060051BE RID: 20926 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051BE")]
		[Address(RVA = "0x9F98", Offset = "0x9F98", VA = "0x9F98")]
		public IsleAnimationMultipleLaunchesDialog()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Isles_User_View_IsleAnimationMultipleLaunchesDialog___ctor
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5,
		               undefined4 param6,undefined8 param7,undefined4 param8,undefined4 param9)
		
		{
		  if (DAT_ram_00a58d3a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_IsleAnimationMultipleLaunchesDialog_Args___ctor__
		              );
		    DAT_ram_00a58d3a = '\x01';
		  }
		  UnityEngine_UIElements_BaseCompositeField___Il2CppFullySharedGenericType__object____Il2CppFullySharedGenericType___UpdateMixedValueContent
		            (param1,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_IsleAnimationMultipleLaunchesDialog_Args___ctor__
		            );
		  *(undefined8 *)(param1 + 0x48) = param7;
		  *(undefined4 *)(param1 + 0x40) = param6;
		  *(undefined4 *)(param1 + 0x38) = param5;
		  *(undefined4 *)(param1 + 0x34) = param4;
		  *(undefined4 *)(param1 + 0x30) = param3;
		  *(undefined4 *)(param1 + 0x2c) = param2;
		  *(undefined4 *)(param1 + 0x3c) = param8;
		  return;
		}
		*/

		}

		// Token: 0x04002C66 RID: 11366
		[Token(Token = "0x4002C66")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/IsleAnimation/IsleAnimationMultipleLaunchesDialog";

		// Token: 0x04002C67 RID: 11367
		[Token(Token = "0x4002C67")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private TextMeshProUGUI _selectedValueField;

		// Token: 0x04002C68 RID: 11368
		[Token(Token = "0x4002C68")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private SliderWithButtons _slider;

		// Token: 0x04002C69 RID: 11369
		[Token(Token = "0x4002C69")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private ButtonWithCost _buttonWithCost;

		// Token: 0x04002C6A RID: 11370
		[Token(Token = "0x4002C6A")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private LongTap[] _sliderButtons;

		// Token: 0x04002C6B RID: 11371
		[Token(Token = "0x4002C6B")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private int _availQuickSelectionMinCount;

		// Token: 0x02000D14 RID: 3348
		[Token(Token = "0x2000D14")]
		public sealed class Args : BaseDialogWindow<IsleAnimationMultipleLaunchesDialog.Args>.BaseDialogWindowArgs
		{
			// Token: 0x060051BF RID: 20927 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60051BF")]
			[Address(RVA = "0x9F99", Offset = "0x9F99", VA = "0x9F99")]
			public Args(int current, int min, int max, Money price, IsleAnimationsDic isleAnimationsDict, ulong userIsleId, UserData user)
			{
			}

			// Token: 0x04002C6E RID: 11374
			[Token(Token = "0x4002C6E")]
			[FieldOffset(Offset = "0x2C")]
			public readonly int Current;

			// Token: 0x04002C6F RID: 11375
			[Token(Token = "0x4002C6F")]
			[FieldOffset(Offset = "0x30")]
			public readonly int Min;

			// Token: 0x04002C70 RID: 11376
			[Token(Token = "0x4002C70")]
			[FieldOffset(Offset = "0x34")]
			public readonly int Max;

			// Token: 0x04002C71 RID: 11377
			[Token(Token = "0x4002C71")]
			[FieldOffset(Offset = "0x38")]
			public readonly Money Price;

			// Token: 0x04002C72 RID: 11378
			[Token(Token = "0x4002C72")]
			[FieldOffset(Offset = "0x3C")]
			public readonly UserData User;

			// Token: 0x04002C73 RID: 11379
			[Token(Token = "0x4002C73")]
			[FieldOffset(Offset = "0x40")]
			public readonly IsleAnimationsDic IsleAnimationsDict;

			// Token: 0x04002C74 RID: 11380
			[Token(Token = "0x4002C74")]
			[FieldOffset(Offset = "0x48")]
			public readonly ulong UserIsleId;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Slider ---
		void Gameplay_Isles_User_View_IsleAnimationMultipleLaunchesDialog__get_Slider
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a58d30 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IsleAnimationMultipleLaunchesDialog__TypeInfo);
		    DAT_ram_00a58d30 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 100);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_IsleAnimationMultipleLaunchesDialog__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IsleAnimationMultipleLaunchesDialog__TypeInfo),
		       iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 100,iVar2,param1_00);
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
		void Gameplay_Isles_User_View_IsleAnimationMultipleLaunchesDialog__add_SelectedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a58d31 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IsleAnimationMultipleLaunchesDialog__TypeInfo);
		    DAT_ram_00a58d31 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 100);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_IsleAnimationMultipleLaunchesDialog__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IsleAnimationMultipleLaunchesDialog__TypeInfo),
		       iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 100,iVar2,param1_00);
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
		void Gameplay_Isles_User_View_IsleAnimationMultipleLaunchesDialog__remove_SelectedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a58d32 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IsleAnimationMultipleLaunchesDialog__TypeInfo);
		    DAT_ram_00a58d32 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x68);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_IsleAnimationMultipleLaunchesDialog__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IsleAnimationMultipleLaunchesDialog__TypeInfo),
		       iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x68,iVar2,param1_00);
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


		/* --- GHIDRA: add_RequestQuickSelectionValueEvent ---
		void Gameplay_Isles_User_View_IsleAnimationMultipleLaunchesDialog__add_RequestQuickSelectionValueEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a58d33 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IsleAnimationMultipleLaunchesDialog__TypeInfo);
		    DAT_ram_00a58d33 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x68);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_IsleAnimationMultipleLaunchesDialog__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IsleAnimationMultipleLaunchesDialog__TypeInfo),
		       iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x68,iVar2,param1_00);
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


		/* --- GHIDRA: remove_RequestQuickSelectionValueEvent ---
		void Gameplay_Isles_User_View_IsleAnimationMultipleLaunchesDialog__remove_RequestQuickSelectionValueEvent
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  
		  iVar4 = 0;
		  if (DAT_ram_00a58d34 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_int__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_IsleAnimationMultipleLaunchesDialog_Args__OnClose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_User_View_IsleAnimationMultipleLaunchesDialog_HandleClickPriceButtonEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_User_View_IsleAnimationMultipleLaunchesDialog_SliderButtonOnLongTapEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_User_View_IsleAnimationMultipleLaunchesDialog_SliderOnOnValueChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item(&Utils_LongTap_LongTapHandler_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a58d34 = '\x01';
		  }
		  UI_Windows_BaseDialogWindow_object___HandleTitle
		            (param1,
		             Method_UI_Windows_BaseDialogWindow_IsleAnimationMultipleLaunchesDialog_Args__OnClose__)
		  ;
		  *(undefined8 *)(param1 + 100) = 0;
		  uVar2 = *(undefined4 *)(param1 + 0x54);
		  uVar1 = unnamed_function_1417(System_Action_int__TypeInfo);
		  System_Action_short___Invoke
		            (uVar1,param1,
		             Method_Gameplay_Isles_User_View_IsleAnimationMultipleLaunchesDialog_SliderOnOnValueChangedEvent__
		             ,0);
		  UI_Elements_Sliders_SliderWithButtons__add_OnValueChangedEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 0x58) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,
		             Method_Gameplay_Isles_User_View_IsleAnimationMultipleLaunchesDialog_HandleClickPriceButtonEvent__
		             ,0);
		  UnityEngine_Events_UnityAction___ctor(uVar2,uVar1,0);
		  iVar3 = *(int *)(param1 + 0x5c);
		  if (0 < *(int *)(iVar3 + 0xc)) {
		    do {
		      uVar2 = *(undefined4 *)(iVar3 + iVar4 * 4 + 0x10);
		      uVar1 = unnamed_function_1417(Utils_LongTap_LongTapHandler_TypeInfo);
		      Utils_LongTap___cctor
		                (uVar1,param1,
		                 Method_Gameplay_Isles_User_View_IsleAnimationMultipleLaunchesDialog_SliderButtonOnLongTapEvent__
		                 ,0);
		      Utils_LongTap__add_LongTapEvent(uVar2,uVar1,0);
		      iVar4 = iVar4 + 1;
		    } while (iVar4 < *(int *)(iVar3 + 0xc));
		  }
		  return;
		}
		*/

}
