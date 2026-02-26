using System;
using System.Collections.Generic;
using Gameplay.Aprs.Model;
using Gameplay.Discounts.Model;
using Gameplay.Discounts.View;
using Il2CppDummyDll;
using Protocol.Consts;
using UI.Windows;
using UnityEngine;

namespace Gameplay.Aprs.View
{
	// Token: 0x02000D57 RID: 3415
	[Token(Token = "0x2000D57")]
	public class ConfirmBuyAprWindow : BaseDialogWindow<ConfirmBuyAprWindow.ConfirmBuyAprWindowArgs>, IDiscountTarget
	{
		// Token: 0x17001104 RID: 4356
		// (get) Token: 0x060053C1 RID: 21441 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001104")]
		public DiscountTargets[] DiscountTargets
		{
			[Token(Token = "0x60053C1")]
			[Address(RVA = "0xA180", Offset = "0xA180", VA = "0xA180", Slot = "30")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001105 RID: 4357
		// (get) Token: 0x060053C2 RID: 21442 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001105")]
		public override string WindowId
		{
			[Token(Token = "0x60053C2")]
			[Address(RVA = "0xA181", Offset = "0xA181", VA = "0xA181", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x060053C3 RID: 21443 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60053C3")]
		[Address(RVA = "0xA182", Offset = "0xA182", VA = "0xA182")]
		public static ConfirmBuyAprWindow Show(AprData apr, Action<AprData> resultCallback)
		{
		/* --- GHIDRA: Show ---
		void Gameplay_Aprs_View_ConfirmBuyAprWindow__Show(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int *piVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a59421 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_ConfirmBuyAprWindow_ConfirmBuyAprWindowArgs__HandleContent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseWindow_ConfirmBuyAprWindow_ConfirmBuyAprWindowArgs__get_WindowArgs__
		              );
		    DAT_ram_00a59421 = '\x01';
		  }
		  UI_Windows_BaseDialogWindow_object___HandleButtons
		            (param1,
		             Method_UI_Windows_BaseDialogWindow_ConfirmBuyAprWindow_ConfirmBuyAprWindowArgs__HandleContent__
		            );
		  piVar2 = *(int **)(param1 + 0x50);
		  iVar1 = func_ii_8093(param1,
		                       Method_UI_Windows_BaseWindow_ConfirmBuyAprWindow_ConfirmBuyAprWindowArgs__get_WindowArgs__
		                      );
		  iVar3 = *piVar2;
		  (**(code **)((ulonglong)*(uint *)(iVar3 + 0x138) * 4))
		            (piVar2,*(undefined4 *)(*(int *)(iVar1 + 0x2c) + 0x1c),*(undefined4 *)(iVar3 + 0x13c));
		  return;
		}
		*/

			return null;
		}

		// Token: 0x060053C4 RID: 21444 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053C4")]
		[Address(RVA = "0xA183", Offset = "0xA183", VA = "0xA183", Slot = "28")]
		protected override void HandleContent()
		{
		/* --- GHIDRA: HandleContent ---
		void Gameplay_Aprs_View_ConfirmBuyAprWindow__HandleContent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int iVar5;
		  
		  iVar5 = 0;
		  if (DAT_ram_00a59422 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Any_IDiscountArgs___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_First_IDiscountArgs___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Where_IDiscountArgs___);
		    Mono_Security_ASN1__get_Item(&System_Func_IDiscountArgs__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Aprs_View_ConfirmBuyAprWindow___c__DisplayClass11_0__Setup_b__0__);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Aprs_View_ConfirmBuyAprWindow___c__DisplayClass11_0_TypeInfo);
		    DAT_ram_00a59422 = '\x01';
		  }
		  iVar4 = *(int *)(param1 + 0x58);
		  if (0 < *(int *)(iVar4 + 0xc)) {
		    do {
		      iVar1 = unnamed_function_1417
		                        (Gameplay_Aprs_View_ConfirmBuyAprWindow___c__DisplayClass11_0_TypeInfo);
		      *(int *)(iVar1 + 0xc) = param1;
		      *(undefined4 *)(iVar1 + 8) = *(undefined4 *)(iVar4 + iVar5 * 4 + 0x10);
		      uVar2 = unnamed_function_1417(System_Func_IDiscountArgs__bool__TypeInfo);
		      System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		                (uVar2,iVar1,
		                 Method_Gameplay_Aprs_View_ConfirmBuyAprWindow___c__DisplayClass11_0__Setup_b__0__,0
		                );
		      uVar2 = System_Linq_Enumerable__Where_PlayerLoopSystem_
		                        (param2,uVar2,Method_System_Linq_Enumerable_Where_IDiscountArgs___);
		      iVar1 = System_Linq_Enumerable__OrderBy_object__ulong_
		                        (uVar2,Method_System_Linq_Enumerable_Any_IDiscountArgs___);
		      uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(param1 + 0x54),0);
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (uVar3,iVar1,0);
		      if (iVar1 != 0) {
		        uVar3 = *(undefined4 *)(param1 + 0x54);
		        uVar2 = System_Linq_Enumerable__Count_object_
		                          (uVar2,Method_System_Linq_Enumerable_First_IDiscountArgs___);
		        func_ii_7719(uVar3,uVar2,0);
		      }
		      iVar5 = iVar5 + 1;
		    } while (iVar5 < *(int *)(iVar4 + 0xc));
		  }
		  return;
		}
		*/

		}

		// Token: 0x060053C5 RID: 21445 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053C5")]
		[Address(RVA = "0xA184", Offset = "0xA184", VA = "0xA184", Slot = "31")]
		public void Setup(IEnumerable<IDiscountArgs> value)
		{
		/* --- GHIDRA: Setup ---
		void Gameplay_Aprs_View_ConfirmBuyAprWindow__Setup(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a59423 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_ConfirmBuyAprWindow_ConfirmBuyAprWindowArgs___ctor__
		              );
		    DAT_ram_00a59423 = '\x01';
		  }
		  UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_object____ctor
		            (param1,
		             Method_UI_Windows_BaseDialogWindow_ConfirmBuyAprWindow_ConfirmBuyAprWindowArgs___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x060053C6 RID: 21446 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053C6")]
		[Address(RVA = "0xA185", Offset = "0xA185", VA = "0xA185")]
		public ConfirmBuyAprWindow()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Aprs_View_ConfirmBuyAprWindow___ctor(int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a59424 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_ConfirmBuyAprWindow_ConfirmBuyAprWindowArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2579);
		    DAT_ram_00a59424 = '\x01';
		  }
		  UnityEngine_UIElements_BaseCompositeField___Il2CppFullySharedGenericType__object____Il2CppFullySharedGenericType___UpdateMixedValueContent
		            (param1,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_ConfirmBuyAprWindow_ConfirmBuyAprWindowArgs___ctor__
		            );
		  *(undefined4 *)(param1 + 0x2c) = param2;
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar1 = func_ii_7508(StringLiteral_2579,1,0,1,0,0,0,0);
		  *(undefined4 *)(param1 + 0x18) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x04002D67 RID: 11623
		[Token(Token = "0x4002D67")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private AprView _aprView;

		// Token: 0x04002D68 RID: 11624
		[Token(Token = "0x4002D68")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private DiscountGroup _discountGroup;

		// Token: 0x04002D69 RID: 11625
		[Token(Token = "0x4002D69")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private DiscountTargets[] _discountTargets;

		// Token: 0x04002D6A RID: 11626
		[Token(Token = "0x4002D6A")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Aprs/ConfirmBuyAprWindow";

		// Token: 0x02000D58 RID: 3416
		[Token(Token = "0x2000D58")]
		public class ConfirmBuyAprWindowArgs : BaseDialogWindow<ConfirmBuyAprWindow.ConfirmBuyAprWindowArgs>.BaseDialogWindowArgs
		{
			// Token: 0x060053C7 RID: 21447 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60053C7")]
			[Address(RVA = "0xA186", Offset = "0xA186", VA = "0xA186")]
			public ConfirmBuyAprWindowArgs(AprData apr)
			{
			}

			// Token: 0x04002D6B RID: 11627
			[Token(Token = "0x4002D6B")]
			[FieldOffset(Offset = "0x2C")]
			public AprData AprData;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_DiscountTargets ---
		undefined4
		Gameplay_Aprs_View_ConfirmBuyAprWindow__get_DiscountTargets(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5941f == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_12563);
		    DAT_ram_00a5941f = '\x01';
		  }
		  return StringLiteral_12563;
		}
		*/


		/* --- GHIDRA: get_WindowId ---
		undefined4
		Gameplay_Aprs_View_ConfirmBuyAprWindow__get_WindowId(int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000004;
		  int iVar1;
		  int param1_00;
		  undefined4 uVar2;
		  float fVar3;
		  undefined4 uVar4;
		  int iVar5;
		  undefined4 uVar6;
		  int iVar7;
		  uint *puVar8;
		  int param1_01;
		  int *param1_02;
		  uint uVar9;
		  undefined8 param1_03;
		  double param1_04;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a59420 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_MedalDic__uint__get_Data__);
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_ConfirmBuyAprWindow_ConfirmBuyAprWindowArgs__AprData__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ConfirmBuyAprWindow_ConfirmBuyAprWindowArgs__AprData___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ConfirmBuyAprWindow_ConfirmBuyAprWindowArgs__AprData__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Aprs_View_ConfirmBuyAprWindow_ConfirmBuyAprWindowArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ConfirmBuyAprWindow_ConfirmBuyAprWindowArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ConfirmBuyAprWindow_ConfirmBuyAprWindowArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_KeyValuePair_string__string____TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ConfirmBuyAprWindow_ConfirmBuyAprWindowArgs___Add__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_PopupController_Show_ConfirmBuyAprWindow___);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_PriceHolder_ConfirmBuyAprWindow_ConfirmBuyAprWindowArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_PriceHolder_ConfirmBuyAprWindow_ConfirmBuyAprWindowArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Aprs_View_ConfirmBuyAprWindow___c__DisplayClass9_0__Show_b__0__);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Aprs_View_ConfirmBuyAprWindow___c__DisplayClass9_0_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2583);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2556);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22759);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3708);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27734);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19733);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2578);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12563);
		    DAT_ram_00a59420 = '\x01';
		  }
		  local_8 = 0;
		  iVar1 = unnamed_function_1417
		                    (Gameplay_Aprs_View_ConfirmBuyAprWindow___c__DisplayClass9_0_TypeInfo);
		  *(undefined4 *)(iVar1 + 8) = param2;
		  param1_00 = unnamed_function_1417
		                        (Gameplay_Aprs_View_ConfirmBuyAprWindow_ConfirmBuyAprWindowArgs_TypeInfo);
		  Gameplay_Aprs_View_ConfirmBuyAprWindow___ctor(param1_00,param1,param2);
		  uVar2 = func_ii_14054(*(undefined4 *)(*(int *)(param1 + 0x14) + 0x10),0);
		  System_Text_Formatting_StringView__get_IsEmpty
		            (&local_8,StringLiteral_27734,uVar2,
		             Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		  if (*(longlong *)(*(int *)(*(int *)(param1 + 0x14) + 0x10) + 0x40) == 0) {
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar4 = func_ii_7508(StringLiteral_2578,1,0,1,0,0,0,0);
		    iVar5 = Mono_Security_ASN1Convert__ToOid
		                      (System_Collections_Generic_KeyValuePair_string__string____TypeInfo,2);
		    uVar2 = 0x7ff80000;
		    uVar6 = Core_Extensions_Dict_ResourceSetExt__ToLocaleString
		                      (*(undefined4 *)(*(int *)(*(int *)(param1 + 0x14) + 0x10) + 0x24),NAN,0,
		                       StringLiteral_2556,0,0,0);
		    local_10 = 0;
		    System_Text_Formatting_StringView__get_IsEmpty
		              (&local_10,StringLiteral_19733,uVar6,
		               Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		    *(undefined8 *)(iVar5 + 0x10) = local_10;
		    *(undefined8 *)(iVar5 + 0x18) = local_8;
		    uVar4 = Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsRewardsTab_ClanWarsRewardsView__GetPlacesText
		                      (uVar4,iVar5,0);
		    *(undefined4 *)(param1_00 + 0x1c) = uVar4;
		  }
		  else {
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar4 = func_ii_7508(StringLiteral_2583,1,0,1,0,0,0,0);
		    iVar5 = Mono_Security_ASN1Convert__ToOid
		                      (System_Collections_Generic_KeyValuePair_string__string____TypeInfo,3);
		    uVar2 = 0x7ff80000;
		    uVar6 = Core_Extensions_Dict_ResourceSetExt__ToLocaleString
		                      (*(undefined4 *)(*(int *)(*(int *)(param1 + 0x14) + 0x10) + 0x24),NAN,0,
		                       StringLiteral_2556,0,0,0);
		    local_10 = 0;
		    System_Text_Formatting_StringView__get_IsEmpty
		              (&local_10,StringLiteral_19733,uVar6,
		               Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		    *(undefined8 *)(iVar5 + 0x10) = local_10;
		    param1_03 = *(undefined8 *)(*(int *)(*(int *)(param1 + 0x14) + 0x10) + 0x40);
		    if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Utils_TimeUtils_TypeInfo);
		    }
		    fVar3 = Utils_StringUtils___cctor(param1_03,0);
		    param1_04 = (double)fVar3;
		    uVar6 = Utils_TimeUtils__DateFormat(param1_04,0);
		    local_18 = 0;
		    in_register_20000004 = (undefined4)((ulonglong)param1_04 >> 0x20);
		    System_Text_Formatting_StringView__get_IsEmpty
		              (&local_18,StringLiteral_22759,uVar6,
		               Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		    *(undefined8 *)(iVar5 + 0x18) = local_18;
		    *(undefined8 *)(iVar5 + 0x20) = local_8;
		    uVar4 = Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsRewardsTab_ClanWarsRewardsView__GetPlacesText
		                      (uVar4,iVar5,0);
		    *(undefined4 *)(param1_00 + 0x1c) = uVar4;
		  }
		  iVar5 = Core_Extensions_Dict_ResourceSetExt__GetDelta
		                    (*(undefined4 *)(*(int *)(*(int *)(param1 + 0x14) + 0x10) + 0x24),0);
		  if (iVar5 == 0) {
		    param1_01 = *(int *)(param1_00 + 0x24);
		    iVar5 = unnamed_function_1417
		                      (
		                      UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ConfirmBuyAprWindow_ConfirmBuyAprWindowArgs__TypeInfo
		                      );
		    UI_Windows_DialogWindow_DialogWindowArgs___ctor
		              (iVar5,
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ConfirmBuyAprWindow_ConfirmBuyAprWindowArgs___ctor__
		              );
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar4 = func_ii_7508(StringLiteral_3708,1,0,1,0,0,0,0);
		    *(undefined4 *)(iVar5 + 8) = uVar4;
		    iVar7 = unnamed_function_1417
		                      (
		                      UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ConfirmBuyAprWindow_ConfirmBuyAprWindowArgs__AprData__TypeInfo
		                      );
		    *(int *)(iVar7 + 0xc) = param1;
		    uVar4 = unnamed_function_1417
		                      (
		                      UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_ConfirmBuyAprWindow_ConfirmBuyAprWindowArgs__AprData__TypeInfo
		                      );
		    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_object__Int32Enum___Invoke
		              (uVar4,iVar1,
		               Method_Gameplay_Aprs_View_ConfirmBuyAprWindow___c__DisplayClass9_0__Show_b__0__,0);
		    *(undefined4 *)(iVar7 + 0x10) = uVar4;
		    *(int *)(iVar5 + 0x14) = iVar7;
		    iVar1 = unnamed_function_1417
		                      (
		                      UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_PriceHolder_ConfirmBuyAprWindow_ConfirmBuyAprWindowArgs__TypeInfo
		                      );
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    param1_02 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar7 = *param1_02;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      uVar9 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar9 * 8)) {
		          puVar8 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar9 * 8 + 4) * 8 + iVar7 + 0x140);
		          goto code_r0x81000364;
		        }
		        uVar9 = uVar9 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar9);
		    }
		    puVar8 = (uint *)func_ii_1080(param1_02,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x81000364:
		    uVar2 = (**(code **)((ulonglong)*puVar8 * 4))
		                      (CONCAT44(in_register_20000004,param1_02),CONCAT44(uVar2,puVar8[1]));
		    uVar2 = func_ii_7112(uVar2,0);
		    *(undefined4 *)(iVar1 + 0xc) = uVar2;
		    uVar2 = *(undefined4 *)(*(int *)(*(int *)(param1 + 0x14) + 0x10) + 0x24);
		    if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Money_Money_TypeInfo);
		    }
		    uVar2 = Core_Money_Money__op_Explicit(uVar2,0);
		    *(undefined4 *)(iVar1 + 8) = uVar2;
		    *(int *)(iVar5 + 0x10) = iVar1;
		    iVar1 = 
		    Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ConfirmBuyAprWindow_ConfirmBuyAprWindowArgs___Add__
		    ;
		    *(int *)(param1_01 + 0x10) = *(int *)(param1_01 + 0x10) + 1;
		    uVar9 = *(uint *)(param1_01 + 0xc);
		    if (uVar9 < *(uint *)(*(int *)(param1_01 + 8) + 0xc)) {
		      *(uint *)(param1_01 + 0xc) = uVar9 + 1;
		      *(int *)(*(int *)(param1_01 + 8) + uVar9 * 4 + 0x10) = iVar5;
		    }
		    else {
		      System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                (param1_01,iVar5,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		    }
		  }
		  uVar2 = System_Uri___ctor(0);
		  uVar2 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar2,0);
		  uVar2 = Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		                    (uVar2,StringLiteral_12563,param1_00,
		                     Method_UI_Windows_PopupController_Show_ConfirmBuyAprWindow___);
		  return uVar2;
		}
		*/

}
