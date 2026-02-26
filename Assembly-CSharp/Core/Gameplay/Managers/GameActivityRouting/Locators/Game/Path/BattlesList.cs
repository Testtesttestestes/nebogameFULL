using System;
using Core.Rounting;
using Il2CppDummyDll;
using Utils;

namespace Core.Gameplay.Managers.GameActivityRouting.Locators.Game.Path
{
	// Token: 0x020011CD RID: 4557
	[Token(Token = "0x20011CD")]
	public class BattlesList : AbstractPathNode
	{
		// Token: 0x06006C90 RID: 27792 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C90")]
		[Address(RVA = "0xB77C", Offset = "0xB77C", VA = "0xB77C", Slot = "5")]
		protected override void ExecuteTransition(IGame game, OpToken<LocatorPayload, AbstractPathNode> token, LocatorPayload payload)
		{
		}

		// Token: 0x06006C91 RID: 27793 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C91")]
		[Address(RVA = "0xB77D", Offset = "0xB77D", VA = "0xB77D", Slot = "6")]
		protected override void TransitionCanceled()
		{
		}

		// Token: 0x06006C92 RID: 27794 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C92")]
		[Address(RVA = "0xB77E", Offset = "0xB77E", VA = "0xB77E")]
		public BattlesList()
		{
		/* --- GHIDRA: .ctor ---
		void Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_BattlesList___ctor
		               (undefined4 param1,int *param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  int iVar3;
		  
		  if (DAT_ram_00a5a70a == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_LocatorPayload__AbstractPathNode__Complete__)
		    ;
		    DAT_ram_00a5a70a = '\x01';
		  }
		  iVar3 = *param2;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x1c0);
		        goto code_r0x8125f739;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,Core_Gameplay_IGame_TypeInfo,0x20);
		code_r0x8125f739:
		  param1_00 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  Core_Gameplay_Managers_BlitzTournamentManager__Init(param1_00,0,0);
		  Core_ExternAppMethods__OpenPaymentWindow
		            (param3,param4,Method_Utils_OpToken_LocatorPayload__AbstractPathNode__Complete__);
		  return;
		}
		*/

		}
	}
}
