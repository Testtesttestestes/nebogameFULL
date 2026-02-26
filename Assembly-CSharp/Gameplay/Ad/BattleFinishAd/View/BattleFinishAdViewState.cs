using System;
using Il2CppDummyDll;
using UI;

namespace Gameplay.Ad.BattleFinishAd.View
{
	// Token: 0x02000DB6 RID: 3510
	[Token(Token = "0x2000DB6")]
	public class BattleFinishAdViewState : MonoBehaviourWithStates<BattleFinishAdViewState.State>
	{
		// Token: 0x060055B8 RID: 21944 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055B8")]
		[Address(RVA = "0xA358", Offset = "0xA358", VA = "0xA358")]
		public BattleFinishAdViewState()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Ad_BattleFinishAd_View_BattleFinishAdViewState___ctor
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5,undefined4 param6)
		
		{
		  if (DAT_ram_00a58857 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractCozyViewMediator_BattleFinishAdPlacementModel__BattleFinishAdPlacementEvents__BattleFinishAdPlacementController__BattleFinishAdView___ctor__
		              );
		    DAT_ram_00a58857 = '\x01';
		  }
		  MVC_AbstractCozyViewMediator_object__object__object__object____ctor
		            (param1,param2,param3,param4,param5,
		             Method_MVC_AbstractCozyViewMediator_BattleFinishAdPlacementModel__BattleFinishAdPlacementEvents__BattleFinishAdPlacementController__BattleFinishAdView___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x02000DB7 RID: 3511
		[Token(Token = "0x2000DB7")]
		public enum State
		{
			// Token: 0x04002E72 RID: 11890
			[Token(Token = "0x4002E72")]
			Default,
			// Token: 0x04002E73 RID: 11891
			[Token(Token = "0x4002E73")]
			AdWatched
		}
	}
}
