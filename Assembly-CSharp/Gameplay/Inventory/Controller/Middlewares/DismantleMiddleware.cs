using System;
using Core.Data;
using Core.Dict;
using Core.Dict.DictWrappers.Wrappers;
using Core.Gameplay.Managers.GameActivityRouting;
using Il2CppDummyDll;
using Protocol.Consts;
using UI.ConfirmationMessage;
using UI.Toast;
using UI.Windows;

namespace Gameplay.Inventory.Controller.Middlewares
{
	// Token: 0x020006BE RID: 1726
	[Token(Token = "0x20006BE")]
	public sealed class DismantleMiddleware
	{
		// Token: 0x060029CC RID: 10700 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029CC")]
		[Address(RVA = "0x7A82", Offset = "0x7A82", VA = "0x7A82")]
		public DismantleMiddleware(IDictProvider dictProvider, GameFeatureRouterManager featureRouter, ConfirmationMessageController confirmationMessage, ToastController toastController, ArtikulTypes recipeArtikulType)
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Gameplay_Inventory_Controller_Middlewares_DismantleMiddleware___ctor
		          (undefined4 param1,undefined4 param2,int param3,int *param4,undefined4 param5)
		
		{
		  int iVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 param1_00;
		  undefined4 param3_00;
		  int iVar4;
		  int iVar5;
		  int iVar6;
		  uint uVar7;
		  int iVar8;
		  
		  if (DAT_ram_00a5a18b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_ArtikulDic__uint__get_Data__)
		    ;
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
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_string__string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___Add__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_RewardInfo__get_Item__);
		    Mono_Security_ASN1__get_Item(&Method_Google_Protobuf_Collections_RepeatedField_uint__get_Item__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Inventory_Controller_Middlewares_DismantleMiddleware___c__DisplayClass6_0__ShowRecipeLearnedWindow_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Inventory_Controller_Middlewares_DismantleMiddleware___c__DisplayClass6_0_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&StringLiteral_3613);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4476);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26332);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4489);
		    DAT_ram_00a5a18b = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (
		                    Gameplay_Inventory_Controller_Middlewares_DismantleMiddleware___c__DisplayClass6_0_TypeInfo
		                    );
		  *(undefined4 *)(iVar1 + 0xc) = 0;
		  *(undefined4 *)(iVar1 + 8) = param1;
		  iVar8 = *param4;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    uVar7 = 0;
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar7 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar7 * 8 + 4) * 8 + iVar8 + 0xd0);
		        goto code_r0x811d83ac;
		      }
		      uVar7 = uVar7 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar7);
		  }
		  puVar2 = (uint *)func_ii_1080(param4,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x811d83ac:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param4,puVar2[1]);
		  iVar8 = Core_Extensions_Dict_DictExt__GetDiscountsDic
		                    (uVar3,*(undefined4 *)(*(int *)(param3 + 0x10) + 0xc),0);
		  if (iVar8 != 0) {
		    iVar8 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                      (*(undefined4 *)(iVar8 + 0x18),0,
		                       Method_Google_Protobuf_Collections_RepeatedField_RewardInfo__get_Item__);
		    uVar3 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                      (*(undefined4 *)(iVar8 + 0x10),0,
		                       Method_Google_Protobuf_Collections_RepeatedField_uint__get_Item__);
		    *(undefined4 *)(iVar1 + 0xc) = uVar3;
		  }
		  iVar8 = unnamed_function_1417(UI_Windows_DialogWindow_DialogWindowArgs_TypeInfo);
		  func_ii_8625(iVar8,0);
		  *(undefined4 *)(iVar8 + 0x18) = param2;
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar3 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4476,1,0,1,0,0,0,0);
		  param1_00 = unnamed_function_1417(System_Collections_Generic_Dictionary_string__string__TypeInfo);
		  System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		            (param1_00,Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		  param3_00 = Core_Extensions_Dict_DictExt__GetArtikul(*(undefined4 *)(param3 + 0x10),0);
		  System_Reflection_FieldInfo__get_IsStatic
		            (param1_00,StringLiteral_26332,param3_00,
		             Method_System_Collections_Generic_Dictionary_string__string__Add__);
		  uVar3 = Core_GameLocalization__GetTranslation(uVar3,param1_00,0);
		  *(undefined4 *)(iVar8 + 0x1c) = uVar3;
		  iVar6 = *(int *)(iVar8 + 0x24);
		  iVar4 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs__TypeInfo
		                    );
		  UI_Windows_DialogWindow_DialogWindowArgs___ctor
		            (iVar4,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___ctor__
		            );
		  uVar3 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_3613,1,0,1,0,0,0,0);
		  *(undefined4 *)(iVar4 + 8) = uVar3;
		  iVar5 = 
		  Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___Add__
		  ;
		  *(int *)(iVar6 + 0x10) = *(int *)(iVar6 + 0x10) + 1;
		  uVar7 = *(uint *)(iVar6 + 0xc);
		  if (uVar7 < *(uint *)(*(int *)(iVar6 + 8) + 0xc)) {
		    *(uint *)(iVar6 + 0xc) = uVar7 + 1;
		    *(int *)(*(int *)(iVar6 + 8) + uVar7 * 4 + 0x10) = iVar4;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar6,iVar4,*(undefined4 *)(*(int *)(*(int *)(iVar5 + 0x10) + 0x60) + 0x38));
		  }
		  iVar6 = *(int *)(iVar8 + 0x24);
		  iVar5 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs__TypeInfo
		                    );
		  UI_Windows_DialogWindow_DialogWindowArgs___ctor
		            (iVar5,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___ctor__
		            );
		  uVar3 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4489,1,0,1,0,0,0,0);
		  *(undefined4 *)(iVar5 + 8) = uVar3;
		  iVar4 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_DialogWindow_DialogWindowArgs__TypeInfo
		                    );
		  uVar3 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_DialogWindow_DialogWindowArgs__TypeInfo
		                    );
		  UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_object____ctor
		            (uVar3,iVar1,
		             Method_Gameplay_Inventory_Controller_Middlewares_DismantleMiddleware___c__DisplayClass6_0__ShowRecipeLearnedWindow_b__0__
		             ,0);
		  *(undefined4 *)(iVar4 + 8) = uVar3;
		  *(int *)(iVar5 + 0x14) = iVar4;
		  iVar1 = 
		  Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___Add__
		  ;
		  *(int *)(iVar6 + 0x10) = *(int *)(iVar6 + 0x10) + 1;
		  uVar7 = *(uint *)(iVar6 + 0xc);
		  if (uVar7 < *(uint *)(*(int *)(iVar6 + 8) + 0xc)) {
		    *(uint *)(iVar6 + 0xc) = uVar7 + 1;
		    *(int *)(*(int *)(iVar6 + 8) + uVar7 * 4 + 0x10) = iVar5;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar6,iVar5,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  uVar3 = UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_object____ctor
		                    (iVar8,0);
		  return uVar3;
		}
		*/

		}

		// Token: 0x060029CD RID: 10701 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60029CD")]
		[Address(RVA = "0x7A83", Offset = "0x7A83", VA = "0x7A83")]
		private DialogWindow ShowRecipeLearnedWindow(string title, ArtikulDicWrapper artikul, IDictProvider dictProvider)
		{
		/* --- GHIDRA: ShowRecipeLearnedWindow ---
		int Gameplay_Inventory_Controller_Middlewares_DismantleMiddleware__ShowRecipeLearnedWindow
		              (int param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 param1_00;
		  int *piVar4;
		  int iVar5;
		  
		  if (DAT_ram_00a5a18c == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    DAT_ram_00a5a18c = '\x01';
		  }
		  piVar4 = *(int **)(param1 + 8);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd0);
		        goto code_r0x811d818a;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x811d818a:
		  uVar1 = 0;
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		  uVar3 = Core_Extensions_Dict_DictExt__GetUserMenuActionDic(uVar3,1,0);
		  piVar4 = *(int **)(param1 + 8);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd0);
		        goto code_r0x811d8217;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x811d8217:
		  param1_00 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		  iVar5 = Core_Extensions_Dict_DictExt__GetArtikulMenuActionDic
		                    (param1_00,1,*(undefined4 *)(*(int *)(param2 + 0xc) + 0xc),0);
		  if ((iVar5 == 0) ||
		     (iVar5 = Core_Extensions_Dict_ArtikulTypeMenuActionDicExt__GetTitle(iVar5,0), iVar5 == 0)) {
		    iVar5 = Core_Extensions_Dict_ArtikulMenuActionDicExt__GetTitle(uVar3,0);
		  }
		  return iVar5;
		}
		*/

			return null;
		}

		// Token: 0x060029CE RID: 10702 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60029CE")]
		[Address(RVA = "0x7A84", Offset = "0x7A84", VA = "0x7A84")]
		private string GetText(ArtifactData artifact)
		{
		/* --- GHIDRA: GetText ---
		void Gameplay_Inventory_Controller_Middlewares_DismantleMiddleware__GetText
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 param2_00;
		  
		  param2_00 = Gameplay_Inventory_Controller_Middlewares_DismantleMiddleware__ShowRecipeLearnedWindow
		                        (param1,param2,param1);
		  if ((ulonglong)*(uint *)(*(int *)(param2 + 0xc) + 0xc) == (longlong)*(int *)(param1 + 0x18)) {
		    Gameplay_Inventory_Controller_Middlewares_DismantleMiddleware___ctor
		              (param1,param2_00,*(undefined4 *)(param2 + 8),*(undefined4 *)(param1 + 8),param1);
		    return;
		  }
		  if (*(int *)(param1 + 0x10) != 0) {
		    UI_ConfirmationMessage_ConfirmationMessageController__set_DefaultDuration
		              (*(int *)(param1 + 0x10),param2_00,0);
		  }
		  return;
		}
		*/

			return null;
		}

		// Token: 0x060029CF RID: 10703 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029CF")]
		[Address(RVA = "0x7A85", Offset = "0x7A85", VA = "0x7A85")]
		public void Notify(ArtifactData artifact)
		{
		/* --- GHIDRA: Notify ---
		void Gameplay_Inventory_Controller_Middlewares_DismantleMiddleware__Notify
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  int param1_00;
		  
		  param1_00 = *(int *)(param1 + 0x14);
		  if (param1_00 != 0) {
		    uVar1 = Gameplay_Inventory_Controller_Middlewares_DismantleMiddleware__ShowRecipeLearnedWindow
		                      (param1,param2,param1);
		    uVar1 = UI_Toast_ToastController_ToastData__GetUiResourceIdByTheme(param3,uVar1,param2,0);
		    UI_Toast_ToastController__OnReleaseToast(param1_00,uVar1,0);
		  }
		  return;
		}
		*/

		/* --- GHIDRA: Notify ---
		void Gameplay_Inventory_Controller_Middlewares_DismantleMiddleware__Notify
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  int param1_00;
		  
		  param1_00 = *(int *)(param1 + 0x14);
		  if (param1_00 != 0) {
		    uVar1 = Gameplay_Inventory_Controller_Middlewares_DismantleMiddleware__ShowRecipeLearnedWindow
		                      (param1,param2,param1);
		    uVar1 = UI_Toast_ToastController_ToastData__GetUiResourceIdByTheme(param3,uVar1,param2,0);
		    UI_Toast_ToastController__OnReleaseToast(param1_00,uVar1,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060029D0 RID: 10704 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029D0")]
		[Address(RVA = "0x7A86", Offset = "0x7A86", VA = "0x7A86")]
		public void Notify(ArtifactData artifact, ToastTheme theme)
		{
		}

		// Token: 0x0400172B RID: 5931
		[Token(Token = "0x400172B")]
		[FieldOffset(Offset = "0x8")]
		private readonly IDictProvider _dictProvider;

		// Token: 0x0400172C RID: 5932
		[Token(Token = "0x400172C")]
		[FieldOffset(Offset = "0xC")]
		private readonly GameFeatureRouterManager _featureRouter;

		// Token: 0x0400172D RID: 5933
		[Token(Token = "0x400172D")]
		[FieldOffset(Offset = "0x10")]
		private readonly ConfirmationMessageController _confirmationMessage;

		// Token: 0x0400172E RID: 5934
		[Token(Token = "0x400172E")]
		[FieldOffset(Offset = "0x14")]
		private readonly ToastController _toastController;

		// Token: 0x0400172F RID: 5935
		[Token(Token = "0x400172F")]
		[FieldOffset(Offset = "0x18")]
		private readonly ArtikulTypes _recipeArtikulType;
	}
}
