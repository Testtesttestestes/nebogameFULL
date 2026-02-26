using System;
using Core.Rounting;
using Il2CppDummyDll;
using Utils;

namespace Core.Gameplay.Managers.GameActivityRouting.Locators.Game.Path
{
	// Token: 0x020011E6 RID: 4582
	[Token(Token = "0x20011E6")]
	public class TreeBuilding : AbstractPathNode
	{
		// Token: 0x06006CE3 RID: 27875 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CE3")]
		[Address(RVA = "0xB7CF", Offset = "0xB7CF", VA = "0xB7CF", Slot = "5")]
		protected override void ExecuteTransition(IGame game, OpToken<LocatorPayload, AbstractPathNode> token, LocatorPayload payload)
		{
		/* --- GHIDRA: ExecuteTransition ---
		undefined4
		Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_TreeBuilding__ExecuteTransition
		          (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *param1_00;
		  int iVar4;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5a72d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_UserIsleEvents__UserIsleModel__UserIsleController__UserBuildingTypes__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5a72d = '\x01';
		  }
		  local_4 = 0;
		  param1_00 = *(int **)(param1 + 0x10);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x110);
		        goto code_r0x812637d6;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,10);
		code_r0x812637d6:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  uVar3 = Gameplay_Isles_Base_Model_BaseIsleModel__GetBuildingLevel
		                    (*(undefined4 *)(*(int *)(*(int *)(iVar4 + 0x14) + 0x20) + 0x10),1,&local_4,0);
		  return uVar3;
		}
		*/

		}

		// Token: 0x06006CE4 RID: 27876 RVA: 0x000140D0 File Offset: 0x000122D0
		[Token(Token = "0x6006CE4")]
		[Address(RVA = "0xB7D0", Offset = "0xB7D0", VA = "0xB7D0", Slot = "4")]
		public override bool Check()
		{
			return default(bool);
		}

		// Token: 0x06006CE5 RID: 27877 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CE5")]
		[Address(RVA = "0xB7D1", Offset = "0xB7D1", VA = "0xB7D1", Slot = "6")]
		protected override void TransitionCanceled()
		{
		}

		// Token: 0x06006CE6 RID: 27878 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CE6")]
		[Address(RVA = "0xB7D2", Offset = "0xB7D2", VA = "0xB7D2")]
		public TreeBuilding()
		{
		/* --- GHIDRA: .ctor ---
		void Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_TreeBuilding___ctor
		               (undefined4 param1,int *param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *param1_00;
		  undefined4 param1_01;
		  undefined4 uVar3;
		  undefined4 param1_02;
		  int iVar4;
		  
		  if (DAT_ram_00a5a72e == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_LocatorPayload__AbstractPathNode__Complete__)
		    ;
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_PopupController_Show_UserInfoWindow___);
		    Mono_Security_ASN1__get_Item(&Gameplay_UserInfo_View_UserInfoWindow_UserInfoWindowArgs_TypeInfo)
		    ;
		    Mono_Security_ASN1__get_Item(&StringLiteral_12683);
		    DAT_ram_00a5a72e = '\x01';
		  }
		  iVar4 = *param2;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xe0);
		        goto code_r0x812638c3;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x812638c3:
		  param1_00 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  uVar1 = 0;
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xe8);
		        goto code_r0x8126393f;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Application_IApp_TypeInfo,5);
		code_r0x8126393f:
		  uVar1 = 0;
		  param1_01 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  iVar4 = *param2;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x140);
		        goto code_r0x812639c1;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x812639c1:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  uVar3 = func_ii_7112(uVar3,0);
		  param1_02 = unnamed_function_1417
		                        (Gameplay_UserInfo_View_UserInfoWindow_UserInfoWindowArgs_TypeInfo);
		  Core_Browser_BrowserWindow___ctor(param1_02,uVar3,0);
		  Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		            (param1_01,StringLiteral_12683,param1_02,
		             Method_UI_Windows_PopupController_Show_UserInfoWindow___);
		  Core_ExternAppMethods__OpenPaymentWindow
		            (param3,param4,Method_Utils_OpToken_LocatorPayload__AbstractPathNode__Complete__);
		  return;
		}
		*/

		}
	}
}
