using System;
using Core.Rounting;
using Il2CppDummyDll;
using Utils;

namespace Core.Gameplay.Managers.GameActivityRouting.Locators.Game.Path
{
	// Token: 0x020011D6 RID: 4566
	[Token(Token = "0x20011D6")]
	public class DailyQuests : AbstractPathNode
	{
		// Token: 0x06006CAE RID: 27822 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CAE")]
		[Address(RVA = "0xB79A", Offset = "0xB79A", VA = "0xB79A", Slot = "5")]
		protected override void ExecuteTransition(IGame game, OpToken<LocatorPayload, AbstractPathNode> token, LocatorPayload payload)
		{
		}

		// Token: 0x06006CAF RID: 27823 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CAF")]
		[Address(RVA = "0xB79B", Offset = "0xB79B", VA = "0xB79B", Slot = "6")]
		protected override void TransitionCanceled()
		{
		}

		// Token: 0x06006CB0 RID: 27824 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CB0")]
		[Address(RVA = "0xB79C", Offset = "0xB79C", VA = "0xB79C")]
		public DailyQuests()
		{
		/* --- GHIDRA: .ctor ---
		void Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_DailyQuests___ctor
		               (undefined4 param1,int *param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  int iVar3;
		  
		  if (DAT_ram_00a5a717 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_LocatorPayload__AbstractPathNode__Complete__)
		    ;
		    DAT_ram_00a5a717 = '\x01';
		  }
		  iVar3 = *param2;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x1b8);
		        goto code_r0x812608ee;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,Core_Gameplay_IGame_TypeInfo,0x1f);
		code_r0x812608ee:
		  param1_00 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  Core_Gameplay_Managers_SmallGamesManager__ShowSmallGamesWindow(param1_00,0);
		  Core_ExternAppMethods__OpenPaymentWindow
		            (param3,param4,Method_Utils_OpToken_LocatorPayload__AbstractPathNode__Complete__);
		  return;
		}
		*/

		}
	}
}
