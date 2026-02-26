using System;
using Il2CppDummyDll;
using Utils;

namespace UI.Windows.Licenses
{
	// Token: 0x0200029F RID: 671
	[Token(Token = "0x200029F")]
	public static class BuyLicenseDialogWindow
	{
		// Token: 0x06000FB7 RID: 4023 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000FB7")]
		[Address(RVA = "0x61E0", Offset = "0x61E0", VA = "0x61E0")]
		public static DialogWindow Show()
		{
		/* --- GHIDRA: Show ---
		void UI_Windows_Licenses_BuyLicenseDialogWindow__Show(undefined4 param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  undefined4 param1_01;
		  int *param1_02;
		  int iVar3;
		  
		  if (DAT_ram_00a58a79 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_bool__int___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_Licenses_BuyLicenseDialogWindow_HandleBuyProcessComplete__);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_bool__int__AddResultHandler__);
		    DAT_ram_00a58a79 = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_02 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar3 = *param1_02;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x140);
		        goto code_r0x80f6aef4;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_02,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x80f6aef4:
		  iVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_02,puVar2[1]);
		  param1_00 = Gameplay_User_Controller_UserController__PayoffBanResultHandler
		                        (*(undefined4 *)(iVar3 + 0x18),0);
		  param1_01 = unnamed_function_1417(System_Action_OpToken_bool__int___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_01,0,
		             Method_UI_Windows_Licenses_BuyLicenseDialogWindow_HandleBuyProcessComplete__,0);
		  ServicesNamespace_MainService__GetUserStats
		            (param1_00,param1_01,0,Method_Utils_OpToken_bool__int__AddResultHandler__);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06000FB8 RID: 4024 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FB8")]
		[Address(RVA = "0x61E1", Offset = "0x61E1", VA = "0x61E1")]
		private static void BuyLicenseCallback(BaseDialogWindow<DialogWindow.DialogWindowArgs> window)
		{
		/* --- GHIDRA: BuyLicenseCallback ---
		void UI_Windows_Licenses_BuyLicenseDialogWindow__BuyLicenseCallback(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param3;
		  
		  if (DAT_ram_00a58a7a == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_bool__int__get_Result__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_10313);
		    DAT_ram_00a58a7a = '\x01';
		  }
		  if (*(char *)(param1 + 0x20) != '\0') {
		    uVar1 = System_Uri___ctor(0);
		    uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar1,0);
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    param3 = func_ii_7508(StringLiteral_10313,1,0,1,0,0,0,0);
		    Core_Application_App__get_ToastController(uVar1,1,param3,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06000FB9 RID: 4025 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FB9")]
		[Address(RVA = "0x61E2", Offset = "0x61E2", VA = "0x61E2")]
		private static void HandleBuyProcessComplete(OpToken<bool, int> op)
		{
		}
	}
}
