using System;
using Core.Rounting;
using Il2CppDummyDll;
using Utils;

namespace Core.Gameplay.Managers.GameActivityRouting.Locators.Game.Path
{
	// Token: 0x020011CC RID: 4556
	[Token(Token = "0x20011CC")]
	public class Bank : AbstractPathNode
	{
		// Token: 0x06006C8D RID: 27789 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C8D")]
		[Address(RVA = "0xB779", Offset = "0xB779", VA = "0xB779", Slot = "5")]
		protected override void ExecuteTransition(IGame game, OpToken<LocatorPayload, AbstractPathNode> token, LocatorPayload payload)
		{
		}

		// Token: 0x06006C8E RID: 27790 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C8E")]
		[Address(RVA = "0xB77A", Offset = "0xB77A", VA = "0xB77A", Slot = "6")]
		protected override void TransitionCanceled()
		{
		}

		// Token: 0x06006C8F RID: 27791 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C8F")]
		[Address(RVA = "0xB77B", Offset = "0xB77B", VA = "0xB77B")]
		public Bank()
		{
		/* --- GHIDRA: .ctor ---
		void Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Bank___ctor
		               (undefined4 param1,int *param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *param1_00;
		  undefined4 param1_01;
		  undefined4 param1_02;
		  int iVar3;
		  
		  if (DAT_ram_00a5a709 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Battles_View_BattlesWindow_BattlesWindowArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_LocatorPayload__AbstractPathNode__Complete__)
		    ;
		    Mono_Security_ASN1__get_Item(&StringLiteral_12574);
		    DAT_ram_00a5a709 = '\x01';
		  }
		  iVar3 = *param2;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0xe0);
		        goto code_r0x8125f5d9;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x8125f5d9:
		  param1_00 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  uVar1 = 0;
		  iVar3 = *param1_00;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0xe8);
		        goto code_r0x8125f657;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Application_IApp_TypeInfo,5);
		code_r0x8125f657:
		  param1_01 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  param1_02 = unnamed_function_1417(Gameplay_Battles_View_BattlesWindow_BattlesWindowArgs_TypeInfo);
		  Gameplay_AccountLinker_View_SelectUserWindow___ctor(param1_02,0);
		  UI_Windows_PopupController__set_TopWindow(param1_01,StringLiteral_12574,param1_02,0,0);
		  Core_ExternAppMethods__OpenPaymentWindow
		            (param3,param4,Method_Utils_OpToken_LocatorPayload__AbstractPathNode__Complete__);
		  return;
		}
		*/

		}
	}
}
