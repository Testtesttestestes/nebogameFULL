using System;
using Core.Data;
using Gameplay.Discounts.View;
using Gameplay.Inventory.Model;
using Il2CppDummyDll;
using UI.Windows;
using UnityEngine;
using Utils;

namespace Gameplay.Inventory.View.Chest
{
	// Token: 0x02000687 RID: 1671
	[Token(Token = "0x2000687")]
	public class InventoryConfirmBuySlotWindow : BaseDialogWindow<InventoryConfirmBuySlotWindow.InventoryConfirmBuySlotWindowArgs>
	{
		// Token: 0x170007AB RID: 1963
		// (get) Token: 0x0600286B RID: 10347 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170007AB")]
		public override string WindowId
		{
			[Token(Token = "0x600286B")]
			[Address(RVA = "0x798B", Offset = "0x798B", VA = "0x798B", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600286C RID: 10348 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600286C")]
		[Address(RVA = "0x798C", Offset = "0x798C", VA = "0x798C", Slot = "25")]
		protected override void HandleCloseButton()
		{
		/* --- GHIDRA: HandleCloseButton ---
		void Gameplay_Inventory_View_Chest_InventoryConfirmBuySlotWindow__HandleCloseButton
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a5a0f2 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_InventoryConfirmBuySlotWindow_InventoryConfirmBuySlotWindowArgs__HandleContent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseWindow_InventoryConfirmBuySlotWindow_InventoryConfirmBuySlotWindowArgs__get_WindowArgs__
		              );
		    DAT_ram_00a5a0f2 = '\x01';
		  }
		  UI_Windows_BaseDialogWindow_object___HandleButtons
		            (param1,
		             Method_UI_Windows_BaseDialogWindow_InventoryConfirmBuySlotWindow_InventoryConfirmBuySlotWindowArgs__HandleContent__
		            );
		  iVar1 = func_ii_8093(param1,
		                       Method_UI_Windows_BaseWindow_InventoryConfirmBuySlotWindow_InventoryConfirmBuySlotWindowArgs__get_WindowArgs__
		                      );
		  if (*(int *)(iVar1 + 0x30) != 0) {
		    uVar2 = *(undefined4 *)(param1 + 0x50);
		    iVar1 = func_ii_8093(param1,
		                         Method_UI_Windows_BaseWindow_InventoryConfirmBuySlotWindow_InventoryConfirmBuySlotWindowArgs__get_WindowArgs__
		                        );
		    Gameplay_Discounts_View_DiscountGroup__Init(uVar2,*(undefined4 *)(iVar1 + 0x30),0);
		    uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(param1 + 0x50),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar2,1,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600286D RID: 10349 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600286D")]
		[Address(RVA = "0x798D", Offset = "0x798D", VA = "0x798D", Slot = "28")]
		protected override void HandleContent()
		{
		/* --- GHIDRA: HandleContent ---
		undefined4
		Gameplay_Inventory_View_Chest_InventoryConfirmBuySlotWindow__HandleContent
		          (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 in_register_20000014;
		  undefined8 uVar2;
		  undefined4 uVar3;
		  int param2_00;
		  int *piVar4;
		  uint *puVar5;
		  undefined4 uVar6;
		  undefined4 uVar7;
		  undefined4 uVar8;
		  undefined4 uVar9;
		  int iVar10;
		  undefined4 param3_00;
		  int iVar11;
		  int iVar12;
		  int iVar13;
		  int iVar14;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5a0f3 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_InventoryConfirmBuySlotWindow_InventoryConfirmBuySlotWindowArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_InventoryConfirmBuySlotWindow_InventoryConfirmBuySlotWindowArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_InventoryConfirmBuySlotWindow_InventoryConfirmBuySlotWindowArgs__set_Callback__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_InventoryConfirmBuySlotWindow_InventoryConfirmBuySlotWindowArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_InventoryConfirmBuySlotWindow_InventoryConfirmBuySlotWindowArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_InventoryConfirmBuySlotWindow_InventoryConfirmBuySlotWindowArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Discounts_Model_IDiscountsProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Inventory_View_Chest_InventoryConfirmBuySlotWindow_InventoryConfirmBuySlotWindowArgs_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_KeyValuePair_string__string____TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_InventoryConfirmBuySlotWindow_InventoryConfirmBuySlotWindowArgs___Add__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_InventoryConfirmBuySlotWindow_InventoryConfirmBuySlotWindowArgs____ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_InventoryConfirmBuySlotWindow_InventoryConfirmBuySlotWindowArgs___TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_int__int___ctor__);
		    Mono_Security_ASN1__get_Item(&Utils_OpToken_int__int__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_PopupController_Show_InventoryConfirmBuySlotWindow___);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_PriceHolder_InventoryConfirmBuySlotWindow_InventoryConfirmBuySlotWindowArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_PriceHolder_InventoryConfirmBuySlotWindow_InventoryConfirmBuySlotWindowArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Inventory_View_Chest_InventoryConfirmBuySlotWindow___c__DisplayClass7_0__Show_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Inventory_View_Chest_InventoryConfirmBuySlotWindow___c__DisplayClass7_0_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&StringLiteral_26152);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2556);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27285);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12640);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3708);
		    Mono_Security_ASN1__get_Item(&StringLiteral_9114);
		    Mono_Security_ASN1__get_Item(&StringLiteral_9113);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    DAT_ram_00a5a0f3 = '\x01';
		  }
		  local_4 = 0;
		  param2_00 = unnamed_function_1417
		                        (
		                        Gameplay_Inventory_View_Chest_InventoryConfirmBuySlotWindow___c__DisplayClass7_0_TypeInfo
		                        );
		  *(undefined4 *)(param2_00 + 0x10) = param2;
		  *(undefined4 *)(param2_00 + 8) = param1;
		  piVar4 = (int *)unnamed_function_1417(Utils_OpToken_int__int__TypeInfo);
		  Gameplay_FeedbackForm_Model_FeedbackFormModel__GetUid
		            (piVar4,Method_Utils_OpToken_int__int___ctor__);
		  *(int **)(param2_00 + 0xc) = piVar4;
		  uVar2 = CONCAT44(in_register_20000014,*(undefined4 *)(*piVar4 + 0x114));
		  (**(code **)((ulonglong)*(uint *)(*piVar4 + 0x110) * 4))(piVar4,uVar2);
		  uVar7 = (undefined4)((ulonglong)uVar2 >> 0x20);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  piVar4 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar12 = *piVar4;
		  if (*(ushort *)(iVar12 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar12 + 0x58) + uVar1 * 8)) {
		        puVar5 = (uint *)(*(int *)(*(int *)(iVar12 + 0x58) + uVar1 * 8 + 4) * 8 + iVar12 + 0x120);
		        goto code_r0x811cbac4;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar12 + 0xb6) != uVar1);
		  }
		  puVar5 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0xc);
		code_r0x811cbac4:
		  uVar2 = CONCAT44(uVar7,puVar5[1]);
		  iVar12 = (**(code **)((ulonglong)*puVar5 * 4))(piVar4,uVar2);
		  iVar14 = **(int **)(iVar12 + 0x10);
		  uVar2 = CONCAT44((int)((ulonglong)uVar2 >> 0x20),*(undefined4 *)(param2_00 + 8));
		  uVar6 = (**(code **)((ulonglong)*(uint *)(iVar14 + 0x118) * 4))
		                    (*(int **)(iVar12 + 0x10),uVar2,*(undefined4 *)(iVar14 + 0x11c));
		  uVar7 = (undefined4)((ulonglong)uVar2 >> 0x20);
		  if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_Money_TypeInfo);
		  }
		  uVar6 = Core_Money_Money__op_Explicit(uVar6,0);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  piVar4 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar12 = *piVar4;
		  if (*(ushort *)(iVar12 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar12 + 0x58) + uVar1 * 8)) {
		        puVar5 = (uint *)(*(int *)(*(int *)(iVar12 + 0x58) + uVar1 * 8 + 4) * 8 + iVar12 + 0x248);
		        goto code_r0x811cbbaf;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar12 + 0xb6) != uVar1);
		  }
		  puVar5 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x31);
		code_r0x811cbbaf:
		  uVar2 = CONCAT44(uVar7,puVar5[1]);
		  iVar12 = (**(code **)((ulonglong)*puVar5 * 4))(piVar4,uVar2);
		  uVar7 = (undefined4)((ulonglong)uVar2 >> 0x20);
		  uVar1 = 0;
		  piVar4 = *(int **)(iVar12 + 0x20);
		  iVar12 = *piVar4;
		  if (*(ushort *)(iVar12 + 0xb6) != 0) {
		    do {
		      if (Gameplay_Discounts_Model_IDiscountsProvider_TypeInfo ==
		          *(int *)(*(int *)(iVar12 + 0x58) + uVar1 * 8)) {
		        puVar5 = (uint *)(iVar12 + *(int *)(*(int *)(iVar12 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x811cbc34;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar12 + 0xb6) != uVar1);
		  }
		  puVar5 = (uint *)func_ii_1080(piVar4,Gameplay_Discounts_Model_IDiscountsProvider_TypeInfo,0);
		code_r0x811cbc34:
		  (**(code **)((ulonglong)*puVar5 * 4))(piVar4,CONCAT44(uVar7,10),&local_4,puVar5[1]);
		  uVar7 = System_Uri___ctor(0);
		  uVar7 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar7,0);
		  iVar12 = unnamed_function_1417
		                     (
		                     Gameplay_Inventory_View_Chest_InventoryConfirmBuySlotWindow_InventoryConfirmBuySlotWindowArgs_TypeInfo
		                     );
		  if (DAT_ram_00a5a0f6 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_InventoryConfirmBuySlotWindow_InventoryConfirmBuySlotWindowArgs___ctor__
		              );
		    DAT_ram_00a5a0f6 = '\x01';
		  }
		  UnityEngine_UIElements_BaseCompositeField___Il2CppFullySharedGenericType__object____Il2CppFullySharedGenericType___UpdateMixedValueContent
		            (iVar12,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_InventoryConfirmBuySlotWindow_InventoryConfirmBuySlotWindowArgs___ctor__
		            );
		  *(undefined4 *)(iVar12 + 0x2c) = *(undefined4 *)(param2_00 + 0xc);
		  *(undefined4 *)(iVar12 + 0x30) = local_4;
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar8 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_9114,1,0,1,0,0,0,0);
		  *(undefined4 *)(iVar12 + 0x18) = uVar8;
		  uVar9 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_9113,1,0,1,0,0,0,0);
		  iVar10 = Mono_Security_ASN1Convert__ToOid
		                     (System_Collections_Generic_KeyValuePair_string__string____TypeInfo,2);
		  iVar14 = Protocol_Combat_ProtoPlayerActionEvt___ctor((undefined4 *)(param2_00 + 8),0);
		  uVar8 = StringLiteral_12640;
		  local_10 = 0;
		  if (iVar14 == 0) {
		    iVar14 = StringLiteral_5;
		  }
		  System_Text_Formatting_StringView__get_IsEmpty
		            (&local_10,StringLiteral_27285,iVar14,
		             Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		  *(undefined8 *)(iVar10 + 0x10) = local_10;
		  uVar3 = 0x7ff80000;
		  param3_00 = Core_Extensions_Dict_ResourceSetExt__ToNullableResourceSet
		                        (uVar6,NAN,0,StringLiteral_2556,0,0,0);
		  local_18 = 0;
		  System_Text_Formatting_StringView__get_IsEmpty
		            (&local_18,StringLiteral_26152,param3_00,
		             Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		  *(undefined8 *)(iVar10 + 0x18) = local_18;
		  uVar9 = Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsRewardsTab_ClanWarsRewardsView__GetPlacesText
		                    (uVar9,iVar10,0);
		  *(undefined4 *)(iVar12 + 0x1c) = uVar9;
		  iVar14 = unnamed_function_1417
		                     (
		                     System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_InventoryConfirmBuySlotWindow_InventoryConfirmBuySlotWindowArgs___TypeInfo
		                     );
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (iVar14,
		             Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_InventoryConfirmBuySlotWindow_InventoryConfirmBuySlotWindowArgs____ctor__
		            );
		  iVar10 = unnamed_function_1417
		                     (
		                     UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_InventoryConfirmBuySlotWindow_InventoryConfirmBuySlotWindowArgs__TypeInfo
		                     );
		  UI_Windows_DialogWindow_DialogWindowArgs___ctor
		            (iVar10,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_InventoryConfirmBuySlotWindow_InventoryConfirmBuySlotWindowArgs___ctor__
		            );
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar9 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_3708,1,0,1,0,0,0,0);
		  *(undefined4 *)(iVar10 + 8) = uVar9;
		  iVar11 = unnamed_function_1417
		                     (
		                     UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_PriceHolder_InventoryConfirmBuySlotWindow_InventoryConfirmBuySlotWindowArgs__TypeInfo
		                     );
		  *(undefined4 *)(iVar11 + 8) = uVar6;
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  piVar4 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar13 = *piVar4;
		  if (*(ushort *)(iVar13 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar13 + 0x58) + uVar1 * 8)) {
		        puVar5 = (uint *)(*(int *)(*(int *)(iVar13 + 0x58) + uVar1 * 8 + 4) * 8 + iVar13 + 0x140);
		        goto code_r0x811cbed3;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar13 + 0xb6) != uVar1);
		  }
		  puVar5 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x811cbed3:
		  uVar6 = (**(code **)((ulonglong)*puVar5 * 4))(piVar4,CONCAT44(uVar3,puVar5[1]));
		  uVar6 = func_ii_7112(uVar6,0);
		  *(undefined4 *)(iVar11 + 0xc) = uVar6;
		  *(int *)(iVar10 + 0x10) = iVar11;
		  iVar11 = unnamed_function_1417
		                     (
		                     UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_InventoryConfirmBuySlotWindow_InventoryConfirmBuySlotWindowArgs__TypeInfo
		                     );
		  uVar6 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_InventoryConfirmBuySlotWindow_InventoryConfirmBuySlotWindowArgs__TypeInfo
		                    );
		  UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_object____ctor
		            (uVar6,param2_00,
		             Method_Gameplay_Inventory_View_Chest_InventoryConfirmBuySlotWindow___c__DisplayClass7_0__Show_b__0__
		             ,0);
		  *(undefined4 *)(iVar11 + 8) = uVar6;
		  *(int *)(iVar10 + 0x14) = iVar11;
		  iVar11 = 
		  Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_InventoryConfirmBuySlotWindow_InventoryConfirmBuySlotWindowArgs___Add__
		  ;
		  *(int *)(iVar14 + 0x10) = *(int *)(iVar14 + 0x10) + 1;
		  uVar1 = *(uint *)(iVar14 + 0xc);
		  if (uVar1 < *(uint *)(*(int *)(iVar14 + 8) + 0xc)) {
		    *(uint *)(iVar14 + 0xc) = uVar1 + 1;
		    *(int *)(*(int *)(iVar14 + 8) + uVar1 * 4 + 0x10) = iVar10;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar14,iVar10,*(undefined4 *)(*(int *)(*(int *)(iVar11 + 0x10) + 0x60) + 0x38));
		  }
		  *(int *)(iVar12 + 0x24) = iVar14;
		  Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		            (uVar7,uVar8,iVar12,
		             Method_UI_Windows_PopupController_Show_InventoryConfirmBuySlotWindow___);
		  return *(undefined4 *)(param2_00 + 0xc);
		}
		*/

		}

		// Token: 0x0600286E RID: 10350 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600286E")]
		[Address(RVA = "0x798E", Offset = "0x798E", VA = "0x798E")]
		public static OpToken<int, int> Show(uint quantity, InvetoryScope scope)
		{
		/* --- GHIDRA: Show ---
		undefined4
		Gameplay_Inventory_View_Chest_InventoryConfirmBuySlotWindow__Show
		          (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 in_register_20000014;
		  undefined8 uVar2;
		  undefined4 uVar3;
		  int param2_00;
		  int *piVar4;
		  uint *puVar5;
		  undefined4 uVar6;
		  undefined4 uVar7;
		  undefined4 uVar8;
		  undefined4 uVar9;
		  int iVar10;
		  undefined4 param3_00;
		  int iVar11;
		  int iVar12;
		  int iVar13;
		  int iVar14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5a0f4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_InventoryConfirmBuySlotWindow_InventoryConfirmBuySlotWindowArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_InventoryConfirmBuySlotWindow_InventoryConfirmBuySlotWindowArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_InventoryConfirmBuySlotWindow_InventoryConfirmBuySlotWindowArgs__set_Callback__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_InventoryConfirmBuySlotWindow_InventoryConfirmBuySlotWindowArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_InventoryConfirmBuySlotWindow_InventoryConfirmBuySlotWindowArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_InventoryConfirmBuySlotWindow_InventoryConfirmBuySlotWindowArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Inventory_View_Chest_InventoryConfirmBuySlotWindow_InventoryConfirmBuySlotWindowArgs_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_KeyValuePair_string__string____TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_InventoryConfirmBuySlotWindow_InventoryConfirmBuySlotWindowArgs___Add__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_InventoryConfirmBuySlotWindow_InventoryConfirmBuySlotWindowArgs____ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_InventoryConfirmBuySlotWindow_InventoryConfirmBuySlotWindowArgs___TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_int__int___ctor__);
		    Mono_Security_ASN1__get_Item(&Utils_OpToken_int__int__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_PopupController_Show_InventoryConfirmBuySlotWindow___);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_PriceHolder_InventoryConfirmBuySlotWindow_InventoryConfirmBuySlotWindowArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_PriceHolder_InventoryConfirmBuySlotWindow_InventoryConfirmBuySlotWindowArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Inventory_View_Chest_InventoryConfirmBuySlotWindow___c__DisplayClass8_0__ShowForGolem_b__1__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Inventory_View_Chest_InventoryConfirmBuySlotWindow___c__DisplayClass8_0_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&StringLiteral_26152);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2556);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27285);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12640);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3708);
		    Mono_Security_ASN1__get_Item(&StringLiteral_9114);
		    Mono_Security_ASN1__get_Item(&StringLiteral_9113);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    DAT_ram_00a5a0f4 = '\x01';
		  }
		  param2_00 = unnamed_function_1417
		                        (
		                        Gameplay_Inventory_View_Chest_InventoryConfirmBuySlotWindow___c__DisplayClass8_0_TypeInfo
		                        );
		  *(undefined4 *)(param2_00 + 8) = param1;
		  piVar4 = (int *)unnamed_function_1417(Utils_OpToken_int__int__TypeInfo);
		  Gameplay_FeedbackForm_Model_FeedbackFormModel__GetUid
		            (piVar4,Method_Utils_OpToken_int__int___ctor__);
		  *(int **)(param2_00 + 0xc) = piVar4;
		  uVar2 = CONCAT44(in_register_20000014,*(undefined4 *)(*piVar4 + 0x114));
		  (**(code **)((ulonglong)*(uint *)(*piVar4 + 0x110) * 4))(piVar4,uVar2);
		  uVar6 = (undefined4)((ulonglong)uVar2 >> 0x20);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  piVar4 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar12 = *piVar4;
		  if (*(ushort *)(iVar12 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar12 + 0x58) + uVar1 * 8)) {
		        puVar5 = (uint *)(*(int *)(*(int *)(iVar12 + 0x58) + uVar1 * 8 + 4) * 8 + iVar12 + 0x238);
		        goto code_r0x811cc1e7;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar12 + 0xb6) != uVar1);
		  }
		  puVar5 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x2f);
		code_r0x811cc1e7:
		  iVar12 = (**(code **)((ulonglong)*puVar5 * 4))(piVar4,CONCAT44(uVar6,puVar5[1]));
		  iVar14 = **(int **)(iVar12 + 0x10);
		  uVar6 = (**(code **)((ulonglong)*(uint *)(iVar14 + 0x118) * 4))
		                    (*(int **)(iVar12 + 0x10),*(undefined4 *)(param2_00 + 8),
		                     *(undefined4 *)(iVar14 + 0x11c));
		  if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_Money_TypeInfo);
		  }
		  uVar6 = Core_Money_Money__op_Explicit(uVar6,0);
		  uVar7 = System_Uri___ctor(0);
		  uVar7 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar7,0);
		  iVar12 = unnamed_function_1417
		                     (
		                     Gameplay_Inventory_View_Chest_InventoryConfirmBuySlotWindow_InventoryConfirmBuySlotWindowArgs_TypeInfo
		                     );
		  if (DAT_ram_00a5a0f6 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_InventoryConfirmBuySlotWindow_InventoryConfirmBuySlotWindowArgs___ctor__
		              );
		    DAT_ram_00a5a0f6 = '\x01';
		  }
		  UnityEngine_UIElements_BaseCompositeField___Il2CppFullySharedGenericType__object____Il2CppFullySharedGenericType___UpdateMixedValueContent
		            (iVar12,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_InventoryConfirmBuySlotWindow_InventoryConfirmBuySlotWindowArgs___ctor__
		            );
		  *(undefined4 *)(iVar12 + 0x2c) = *(undefined4 *)(param2_00 + 0xc);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar8 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_9114,1,0,1,0,0,0,0);
		  *(undefined4 *)(iVar12 + 0x18) = uVar8;
		  uVar9 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_9113,1,0,1,0,0,0,0);
		  iVar10 = Mono_Security_ASN1Convert__ToOid
		                     (System_Collections_Generic_KeyValuePair_string__string____TypeInfo,2);
		  iVar14 = Protocol_Combat_ProtoPlayerActionEvt___ctor((undefined4 *)(param2_00 + 8),0);
		  uVar8 = StringLiteral_12640;
		  local_8 = 0;
		  if (iVar14 == 0) {
		    iVar14 = StringLiteral_5;
		  }
		  System_Text_Formatting_StringView__get_IsEmpty
		            (&local_8,StringLiteral_27285,iVar14,
		             Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		  *(undefined8 *)(iVar10 + 0x10) = local_8;
		  uVar3 = 0x7ff80000;
		  param3_00 = Core_Extensions_Dict_ResourceSetExt__ToNullableResourceSet
		                        (uVar6,NAN,0,StringLiteral_2556,0,0,0);
		  local_10 = 0;
		  System_Text_Formatting_StringView__get_IsEmpty
		            (&local_10,StringLiteral_26152,param3_00,
		             Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		  *(undefined8 *)(iVar10 + 0x18) = local_10;
		  uVar9 = Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsRewardsTab_ClanWarsRewardsView__GetPlacesText
		                    (uVar9,iVar10,0);
		  *(undefined4 *)(iVar12 + 0x1c) = uVar9;
		  iVar14 = unnamed_function_1417
		                     (
		                     System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_InventoryConfirmBuySlotWindow_InventoryConfirmBuySlotWindowArgs___TypeInfo
		                     );
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (iVar14,
		             Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_InventoryConfirmBuySlotWindow_InventoryConfirmBuySlotWindowArgs____ctor__
		            );
		  iVar10 = unnamed_function_1417
		                     (
		                     UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_InventoryConfirmBuySlotWindow_InventoryConfirmBuySlotWindowArgs__TypeInfo
		                     );
		  UI_Windows_DialogWindow_DialogWindowArgs___ctor
		            (iVar10,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_InventoryConfirmBuySlotWindow_InventoryConfirmBuySlotWindowArgs___ctor__
		            );
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar9 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_3708,1,0,1,0,0,0,0);
		  *(undefined4 *)(iVar10 + 8) = uVar9;
		  iVar11 = unnamed_function_1417
		                     (
		                     UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_PriceHolder_InventoryConfirmBuySlotWindow_InventoryConfirmBuySlotWindowArgs__TypeInfo
		                     );
		  *(undefined4 *)(iVar11 + 8) = uVar6;
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar4 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar13 = *piVar4;
		  if (*(ushort *)(iVar13 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar13 + 0x58) + uVar1 * 8)) {
		        puVar5 = (uint *)(*(int *)(*(int *)(iVar13 + 0x58) + uVar1 * 8 + 4) * 8 + iVar13 + 0x230);
		        goto code_r0x811cc4b2;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar13 + 0xb6) != uVar1);
		  }
		  puVar5 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x2e);
		code_r0x811cc4b2:
		  iVar13 = (**(code **)((ulonglong)*puVar5 * 4))(piVar4,CONCAT44(uVar3,puVar5[1]));
		  *(undefined4 *)(iVar11 + 0xc) = *(undefined4 *)(*(int *)(iVar13 + 0x10) + 0x18);
		  *(int *)(iVar10 + 0x10) = iVar11;
		  iVar11 = unnamed_function_1417
		                     (
		                     UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_InventoryConfirmBuySlotWindow_InventoryConfirmBuySlotWindowArgs__TypeInfo
		                     );
		  uVar6 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_InventoryConfirmBuySlotWindow_InventoryConfirmBuySlotWindowArgs__TypeInfo
		                    );
		  UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_object____ctor
		            (uVar6,param2_00,
		             Method_Gameplay_Inventory_View_Chest_InventoryConfirmBuySlotWindow___c__DisplayClass8_0__ShowForGolem_b__1__
		             ,0);
		  *(undefined4 *)(iVar11 + 8) = uVar6;
		  *(int *)(iVar10 + 0x14) = iVar11;
		  iVar11 = 
		  Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_InventoryConfirmBuySlotWindow_InventoryConfirmBuySlotWindowArgs___Add__
		  ;
		  *(int *)(iVar14 + 0x10) = *(int *)(iVar14 + 0x10) + 1;
		  uVar1 = *(uint *)(iVar14 + 0xc);
		  if (uVar1 < *(uint *)(*(int *)(iVar14 + 8) + 0xc)) {
		    *(uint *)(iVar14 + 0xc) = uVar1 + 1;
		    *(int *)(*(int *)(iVar14 + 8) + uVar1 * 4 + 0x10) = iVar10;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar14,iVar10,*(undefined4 *)(*(int *)(*(int *)(iVar11 + 0x10) + 0x60) + 0x38));
		  }
		  *(int *)(iVar12 + 0x24) = iVar14;
		  Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		            (uVar7,uVar8,iVar12,
		             Method_UI_Windows_PopupController_Show_InventoryConfirmBuySlotWindow___);
		  return *(undefined4 *)(param2_00 + 0xc);
		}
		*/

			return null;
		}

		// Token: 0x0600286F RID: 10351 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600286F")]
		[Address(RVA = "0x798F", Offset = "0x798F", VA = "0x798F")]
		public static OpToken<int, int> ShowForGolem(uint quantity, InvetoryScope scope)
		{
		/* --- GHIDRA: ShowForGolem ---
		void Gameplay_Inventory_View_Chest_InventoryConfirmBuySlotWindow__ShowForGolem
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5a0f5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_InventoryConfirmBuySlotWindow_InventoryConfirmBuySlotWindowArgs___ctor__
		              );
		    DAT_ram_00a5a0f5 = '\x01';
		  }
		  UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_object____ctor
		            (param1,
		             Method_UI_Windows_BaseDialogWindow_InventoryConfirmBuySlotWindow_InventoryConfirmBuySlotWindowArgs___ctor__
		            );
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06002870 RID: 10352 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002870")]
		[Address(RVA = "0x7990", Offset = "0x7990", VA = "0x7990")]
		public InventoryConfirmBuySlotWindow()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Inventory_View_Chest_InventoryConfirmBuySlotWindow___ctor
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5a0f6 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_InventoryConfirmBuySlotWindow_InventoryConfirmBuySlotWindowArgs___ctor__
		              );
		    DAT_ram_00a5a0f6 = '\x01';
		  }
		  UnityEngine_UIElements_BaseCompositeField___Il2CppFullySharedGenericType__object____Il2CppFullySharedGenericType___UpdateMixedValueContent
		            (param1,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_InventoryConfirmBuySlotWindow_InventoryConfirmBuySlotWindowArgs___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x0400164B RID: 5707
		[Token(Token = "0x400164B")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Inventory/InventoryConfirmBuySlotWindow";

		// Token: 0x0400164C RID: 5708
		[Token(Token = "0x400164C")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private DiscountGroup _discountGroup;

		// Token: 0x02000688 RID: 1672
		[Token(Token = "0x2000688")]
		public class InventoryConfirmBuySlotWindowArgs : BaseDialogWindow<InventoryConfirmBuySlotWindow.InventoryConfirmBuySlotWindowArgs>.BaseDialogWindowArgs
		{
			// Token: 0x06002871 RID: 10353 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002871")]
			[Address(RVA = "0x7991", Offset = "0x7991", VA = "0x7991")]
			public InventoryConfirmBuySlotWindowArgs()
			{
			}

			// Token: 0x0400164D RID: 5709
			[Token(Token = "0x400164D")]
			[FieldOffset(Offset = "0x2C")]
			public OpToken<int, int> OpToken;

			// Token: 0x0400164E RID: 5710
			[Token(Token = "0x400164E")]
			[FieldOffset(Offset = "0x30")]
			public DiscountData DiscountData;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_WindowId ---
		void Gameplay_Inventory_View_Chest_InventoryConfirmBuySlotWindow__get_WindowId
		               (undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a5a0f1 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseWindow_InventoryConfirmBuySlotWindow_InventoryConfirmBuySlotWindowArgs__get_WindowArgs__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_int__int__Fail__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_WindowWhitCloseButton_InventoryConfirmBuySlotWindow_InventoryConfirmBuySlotWindowArgs__HandleCloseButton__
		              );
		    DAT_ram_00a5a0f1 = '\x01';
		  }
		  iVar1 = func_ii_8093(param1,
		                       Method_UI_Windows_BaseWindow_InventoryConfirmBuySlotWindow_InventoryConfirmBuySlotWindowArgs__get_WindowArgs__
		                      );
		  Utils_OpToken_object__object___DisposeHandlers
		            (*(undefined4 *)(iVar1 + 0x2c),0,Method_Utils_OpToken_int__int__Fail__);
		  UI_Windows_WindowWhitCloseButton_object___Awake
		            (param1,
		             Method_UI_Windows_WindowWhitCloseButton_InventoryConfirmBuySlotWindow_InventoryConfirmBuySlotWindowArgs__HandleCloseButton__
		            );
		  return;
		}
		*/

}
