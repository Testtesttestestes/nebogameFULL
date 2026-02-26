using System;
using Core.Rounting;
using Il2CppDummyDll;
using Utils;

namespace Core.Gameplay.Managers.GameActivityRouting.Locators.Game.Path
{
	// Token: 0x020011E4 RID: 4580
	[Token(Token = "0x20011E4")]
	public class Sync : AbstractPathNode
	{
		// Token: 0x06006CDD RID: 27869 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CDD")]
		[Address(RVA = "0xB7C9", Offset = "0xB7C9", VA = "0xB7C9", Slot = "5")]
		protected override void ExecuteTransition(IGame game, OpToken<LocatorPayload, AbstractPathNode> token, LocatorPayload payload)
		{
		}

		// Token: 0x06006CDE RID: 27870 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CDE")]
		[Address(RVA = "0xB7CA", Offset = "0xB7CA", VA = "0xB7CA", Slot = "6")]
		protected override void TransitionCanceled()
		{
		}

		// Token: 0x06006CDF RID: 27871 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CDF")]
		[Address(RVA = "0xB7CB", Offset = "0xB7CB", VA = "0xB7CB")]
		public Sync()
		{
		/* --- GHIDRA: .ctor ---
		void Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Sync___ctor
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar3;
		  
		  if (DAT_ram_00a5a72b == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_LocatorPayload__AbstractPathNode__Complete__)
		    ;
		    DAT_ram_00a5a72b = '\x01';
		  }
		  param1_01 = *(int **)(param1 + 0x10);
		  iVar3 = *param1_01;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x1c8);
		        goto code_r0x81263610;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0x21);
		code_r0x81263610:
		  param1_00 = (**(code **)((ulonglong)*puVar2 * 4))(param1_01,puVar2[1]);
		  Core_Gameplay_Managers_TournamentsManager__Init(param1_00,0);
		  Core_ExternAppMethods__OpenPaymentWindow
		            (param3,param4,Method_Utils_OpToken_LocatorPayload__AbstractPathNode__Complete__);
		  return;
		}
		*/

		}
	}
}
