using System;
using Core.Rounting;
using Il2CppDummyDll;
using Utils;

namespace Core.Gameplay.Managers.GameActivityRouting.Locators.Game.Path
{
	// Token: 0x020011D3 RID: 4563
	[Token(Token = "0x20011D3")]
	public class Collections : AbstractPathNode
	{
		// Token: 0x06006CA5 RID: 27813 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CA5")]
		[Address(RVA = "0xB791", Offset = "0xB791", VA = "0xB791", Slot = "5")]
		protected override void ExecuteTransition(IGame game, OpToken<LocatorPayload, AbstractPathNode> token, LocatorPayload payload)
		{
		}

		// Token: 0x06006CA6 RID: 27814 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CA6")]
		[Address(RVA = "0xB792", Offset = "0xB792", VA = "0xB792", Slot = "6")]
		protected override void TransitionCanceled()
		{
		}

		// Token: 0x06006CA7 RID: 27815 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CA7")]
		[Address(RVA = "0xB793", Offset = "0xB793", VA = "0xB793")]
		public Collections()
		{
		/* --- GHIDRA: .ctor ---
		void Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Collections___ctor
		               (undefined4 param1,int *param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *param1_00;
		  undefined4 param1_01;
		  undefined4 param1_02;
		  int iVar3;
		  
		  if (DAT_ram_00a5a714 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_LocatorPayload__AbstractPathNode__Complete__)
		    ;
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_PopupController_Show_RatingWindow___);
		    Mono_Security_ASN1__get_Item(&Gameplay_Rating_View_RatingWindow_RatingWindowArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12661);
		    DAT_ram_00a5a714 = '\x01';
		  }
		  iVar3 = *param2;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0xe0);
		        goto code_r0x812604ec;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x812604ec:
		  param1_00 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  uVar1 = 0;
		  iVar3 = *param1_00;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0xe8);
		        goto code_r0x8126056a;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Application_IApp_TypeInfo,5);
		code_r0x8126056a:
		  param1_01 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  param1_02 = unnamed_function_1417(Gameplay_Rating_View_RatingWindow_RatingWindowArgs_TypeInfo);
		  Gameplay_Rating_View_RatingWindow___ctor(param1_02,0);
		  Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		            (param1_01,StringLiteral_12661,param1_02,
		             Method_UI_Windows_PopupController_Show_RatingWindow___);
		  Core_ExternAppMethods__OpenPaymentWindow
		            (param3,param4,Method_Utils_OpToken_LocatorPayload__AbstractPathNode__Complete__);
		  return;
		}
		*/

		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: Join<__Il2CppFullySharedGenericType> ---
		void LunarConsolePluginInternal_Collections__Join___Il2CppFullySharedGenericType_
		               (undefined4 param1,undefined4 param2,int param3)
		
		{
		  undefined4 *puVar1;
		  int param3_00;
		  undefined4 uVar2;
		  int param3_01;
		  int param1_00;
		  
		  puVar1 = *(undefined4 **)(param3 + 0x1c);
		  if (puVar1 == (undefined4 *)0x0) {
		    System_ReadOnlySpan_char___GetPinnableReference(param3);
		    puVar1 = *(undefined4 **)(param3 + 0x1c);
		  }
		  param3_01 = *(int *)(puVar1[1] + 0x84);
		  param3_00 = (int)&stack0x00000000 - (param3_01 + 0xfU & 0xfffffff0);
		  uVar2 = *puVar1;
		  if (*(int *)(DAT_ram_00a669a0 + 0x74) == 0) {
		    func_ii_306000(DAT_ram_00a669a0);
		  }
		  uVar2 = func_ii_2734(uVar2,0);
		  uVar2 = UnityEngine_AssemblyFullName__ToString(param1,uVar2,0);
		  param1_00 = *(int *)(*(int *)(param3 + 0x1c) + 4);
		  if ((*(byte *)(param1_00 + 0xbd) & 1) == 0) {
		    param1_00 = func_ii_1079(param1_00);
		  }
		  uVar2 = func_ii_2732(uVar2,param1_00,param3_00);
		  uVar2 = unnamed_function_773(param3_00,uVar2,param3_01);
		  unnamed_function_713(param2,uVar2,param3_01);
		  return;
		}
		*/

}
