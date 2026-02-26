using System;
using Core.Rounting;
using Il2CppDummyDll;
using Utils;

namespace Core.Gameplay.Managers.GameActivityRouting.Locators.Game.Path
{
	// Token: 0x020011D2 RID: 4562
	[Token(Token = "0x20011D2")]
	public class ClanManagement : AbstractPathNode
	{
		// Token: 0x06006CA2 RID: 27810 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CA2")]
		[Address(RVA = "0xB78E", Offset = "0xB78E", VA = "0xB78E", Slot = "5")]
		protected override void ExecuteTransition(IGame game, OpToken<LocatorPayload, AbstractPathNode> token, LocatorPayload payload)
		{
		}

		// Token: 0x06006CA3 RID: 27811 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CA3")]
		[Address(RVA = "0xB78F", Offset = "0xB78F", VA = "0xB78F", Slot = "6")]
		protected override void TransitionCanceled()
		{
		}

		// Token: 0x06006CA4 RID: 27812 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CA4")]
		[Address(RVA = "0xB790", Offset = "0xB790", VA = "0xB790")]
		public ClanManagement()
		{
		/* --- GHIDRA: .ctor ---
		void Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_ClanManagement___ctor
		               (undefined4 param1,int *param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *param1_00;
		  undefined4 param1_01;
		  undefined4 param1_02;
		  int iVar4;
		  
		  if (DAT_ram_00a5a713 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Collections_View_CollectionsWindow_CollectionsWindowArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_LocatorPayload__AbstractPathNode__Complete__)
		    ;
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_PopupController_Show_CollectionsWindow___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12600);
		    DAT_ram_00a5a713 = '\x01';
		  }
		  iVar4 = *param2;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x140);
		        goto code_r0x812602da;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x812602da:
		  uVar1 = 0;
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  uVar3 = func_ii_7112(uVar3,0);
		  iVar4 = *param2;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xe0);
		        goto code_r0x81260362;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x81260362:
		  param1_00 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  uVar1 = 0;
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xe8);
		        goto code_r0x812603e0;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Application_IApp_TypeInfo,5);
		code_r0x812603e0:
		  param1_01 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  param1_02 = unnamed_function_1417
		                        (Gameplay_Collections_View_CollectionsWindow_CollectionsWindowArgs_TypeInfo)
		  ;
		  Gameplay_Collections_View_CollectionsWindow___ctor(param1_02,uVar3,uVar3,param2,0);
		  Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		            (param1_01,StringLiteral_12600,param1_02,
		             Method_UI_Windows_PopupController_Show_CollectionsWindow___);
		  Core_ExternAppMethods__OpenPaymentWindow
		            (param3,param4,Method_Utils_OpToken_LocatorPayload__AbstractPathNode__Complete__);
		  return;
		}
		*/

		}
	}
}
