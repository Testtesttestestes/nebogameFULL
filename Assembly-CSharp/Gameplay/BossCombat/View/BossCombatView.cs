using System;
using Gameplay.Combat.Model;
using Gameplay.Combat.View;
using Il2CppDummyDll;

namespace Gameplay.BossCombat.View
{
	// Token: 0x02000B3B RID: 2875
	[Token(Token = "0x2000B3B")]
	public class BossCombatView : OneOnOneCombatView
	{
		// Token: 0x060045C9 RID: 17865 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045C9")]
		[Address(RVA = "0x946B", Offset = "0x946B", VA = "0x946B", Slot = "6")]
		protected override void Start()
		{
		}

		// Token: 0x060045CA RID: 17866 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60045CA")]
		[Address(RVA = "0x946C", Offset = "0x946C", VA = "0x946C", Slot = "8")]
		protected override CombatGameOverView ShowGameOverView(GameOverData gameOver, CombatModel model)
		{
			return null;
		}

		// Token: 0x060045CB RID: 17867 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045CB")]
		[Address(RVA = "0x946D", Offset = "0x946D", VA = "0x946D")]
		public BossCombatView()
		{
		}
	}
}
