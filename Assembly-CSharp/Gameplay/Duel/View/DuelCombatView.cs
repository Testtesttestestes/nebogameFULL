using System;
using Gameplay.Combat.View;
using Il2CppDummyDll;

namespace Gameplay.Duel.View
{
	// Token: 0x02000857 RID: 2135
	[Token(Token = "0x2000857")]
	public class DuelCombatView : OneOnOneCombatView
	{
		// Token: 0x06003237 RID: 12855 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003237")]
		[Address(RVA = "0x828D", Offset = "0x828D", VA = "0x828D", Slot = "6")]
		protected override void Start()
		{
		}

		// Token: 0x06003238 RID: 12856 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003238")]
		[Address(RVA = "0x828E", Offset = "0x828E", VA = "0x828E")]
		public DuelCombatView()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Duel_View_DuelCombatView___ctor(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57bcb == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_MonoBehaviourWithStates_DuelStates_State___ctor__);
		    DAT_ram_00a57bcb = '\x01';
		  }
		  ScreenAdaptation_Common_AppSize__Update
		            (param1,Method_UI_MonoBehaviourWithStates_DuelStates_State___ctor__);
		  return;
		}
		*/

		}
	}
}
