using System;
using Core.Rounting;
using Il2CppDummyDll;
using Utils;

namespace Core.Gameplay.Managers.GameActivityRouting.Locators.Game.Path
{
	// Token: 0x020011D4 RID: 4564
	[Token(Token = "0x20011D4")]
	public class CommonRatings : AbstractPathNode
	{
		// Token: 0x06006CA8 RID: 27816 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CA8")]
		[Address(RVA = "0xB794", Offset = "0xB794", VA = "0xB794", Slot = "5")]
		protected override void ExecuteTransition(IGame game, OpToken<LocatorPayload, AbstractPathNode> token, LocatorPayload payload)
		{
		}

		// Token: 0x06006CA9 RID: 27817 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CA9")]
		[Address(RVA = "0xB795", Offset = "0xB795", VA = "0xB795", Slot = "6")]
		protected override void TransitionCanceled()
		{
		}

		// Token: 0x06006CAA RID: 27818 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CAA")]
		[Address(RVA = "0xB796", Offset = "0xB796", VA = "0xB796")]
		public CommonRatings()
		{
		/* --- GHIDRA: .ctor ---
		void Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_CommonRatings___ctor
		               (undefined4 param1,int *param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *param1_00;
		  undefined4 param1_01;
		  undefined4 param1_02;
		  int iVar3;
		  
		  if (DAT_ram_00a5a715 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Craft_View_CraftWindow_CraftWindowArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_LocatorPayload__AbstractPathNode__Complete__)
		    ;
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_PopupController_Show_CraftWindow___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12605);
		    DAT_ram_00a5a715 = '\x01';
		  }
		  iVar3 = *param2;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0xe0);
		        goto code_r0x81260670;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x81260670:
		  param1_00 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  uVar1 = 0;
		  iVar3 = *param1_00;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0xe8);
		        goto code_r0x812606ee;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Application_IApp_TypeInfo,5);
		code_r0x812606ee:
		  param1_01 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  param1_02 = unnamed_function_1417(Gameplay_Craft_View_CraftWindow_CraftWindowArgs_TypeInfo);
		  Gameplay_AccountLinker_View_SelectUserWindow___ctor(param1_02,0);
		  Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		            (param1_01,StringLiteral_12605,param1_02,
		             Method_UI_Windows_PopupController_Show_CraftWindow___);
		  Core_ExternAppMethods__OpenPaymentWindow
		            (param3,param4,Method_Utils_OpToken_LocatorPayload__AbstractPathNode__Complete__);
		  return;
		}
		*/

		}
	}
}
