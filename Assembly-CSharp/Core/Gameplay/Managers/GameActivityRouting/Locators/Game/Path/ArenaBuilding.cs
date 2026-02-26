using System;
using Core.Rounting;
using Il2CppDummyDll;
using Utils;

namespace Core.Gameplay.Managers.GameActivityRouting.Locators.Game.Path
{
	// Token: 0x020011CA RID: 4554
	[Token(Token = "0x20011CA")]
	public class ArenaBuilding : AbstractPathNode
	{
		// Token: 0x06006C86 RID: 27782 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C86")]
		[Address(RVA = "0xB772", Offset = "0xB772", VA = "0xB772", Slot = "5")]
		protected override void ExecuteTransition(IGame game, OpToken<LocatorPayload, AbstractPathNode> token, LocatorPayload payload)
		{
		/* --- GHIDRA: ExecuteTransition ---
		undefined4
		Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_ArenaBuilding__ExecuteTransition
		          (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *param1_00;
		  int iVar4;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5a706 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_UserIsleEvents__UserIsleModel__UserIsleController__UserBuildingTypes__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5a706 = '\x01';
		  }
		  local_4 = 0;
		  param1_00 = *(int **)(param1 + 0x10);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x110);
		        goto code_r0x8125f22b;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,10);
		code_r0x8125f22b:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  uVar3 = Gameplay_Isles_Base_Model_BaseIsleModel__GetBuildingLevel
		                    (*(undefined4 *)(*(int *)(*(int *)(iVar4 + 0x14) + 0x20) + 0x10),2,&local_4,0);
		  return uVar3;
		}
		*/

		}

		// Token: 0x06006C87 RID: 27783 RVA: 0x00014058 File Offset: 0x00012258
		[Token(Token = "0x6006C87")]
		[Address(RVA = "0xB773", Offset = "0xB773", VA = "0xB773", Slot = "4")]
		public override bool Check()
		{
			return default(bool);
		}

		// Token: 0x06006C88 RID: 27784 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C88")]
		[Address(RVA = "0xB774", Offset = "0xB774", VA = "0xB774", Slot = "6")]
		protected override void TransitionCanceled()
		{
		}

		// Token: 0x06006C89 RID: 27785 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C89")]
		[Address(RVA = "0xB775", Offset = "0xB775", VA = "0xB775")]
		public ArenaBuilding()
		{
		/* --- GHIDRA: .ctor ---
		void Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_ArenaBuilding___ctor
		               (undefined4 param1,int *param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *param1_00;
		  undefined4 param1_01;
		  undefined4 param1_02;
		  int iVar3;
		  
		  if (DAT_ram_00a5a707 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Auchan_View_AuchanWindow_AuchanWindowArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_LocatorPayload__AbstractPathNode__Complete__)
		    ;
		    Mono_Security_ASN1__get_Item(&StringLiteral_12566);
		    DAT_ram_00a5a707 = '\x01';
		  }
		  iVar3 = *param2;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0xe0);
		        goto code_r0x8125f31b;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x8125f31b:
		  param1_00 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  uVar1 = 0;
		  iVar3 = *param1_00;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0xe8);
		        goto code_r0x8125f399;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Application_IApp_TypeInfo,5);
		code_r0x8125f399:
		  param1_01 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  param1_02 = unnamed_function_1417(Gameplay_Auchan_View_AuchanWindow_AuchanWindowArgs_TypeInfo);
		  Gameplay_AccountLinker_View_SelectUserWindow___ctor(param1_02,0);
		  UI_Windows_PopupController__set_TopWindow(param1_01,StringLiteral_12566,param1_02,0,0);
		  Core_ExternAppMethods__OpenPaymentWindow
		            (param3,param4,Method_Utils_OpToken_LocatorPayload__AbstractPathNode__Complete__);
		  return;
		}
		*/

		}
	}
}
