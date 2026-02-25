using System;
using Gameplay.Combat.Model;
using Gameplay.Combat.View;
using Il2CppDummyDll;

namespace Gameplay.BossCombat.View
{
	// Token: 0x02000B3C RID: 2876
	[Token(Token = "0x2000B3C")]
	public class BossMinionCombatView : OneOnOneCombatView
	{
		// Token: 0x060045CC RID: 17868 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045CC")]
		[Address(RVA = "0x946E", Offset = "0x946E", VA = "0x946E", Slot = "6")]
		protected override void Start()
		{
		}

		// Token: 0x060045CD RID: 17869 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60045CD")]
		[Address(RVA = "0x946F", Offset = "0x946F", VA = "0x946F", Slot = "8")]
		protected override CombatGameOverView ShowGameOverView(GameOverData gameOver, CombatModel model)
		{
			return null;
		}

		// Token: 0x060045CE RID: 17870 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045CE")]
		[Address(RVA = "0x9470", Offset = "0x9470", VA = "0x9470")]
		public BossMinionCombatView()
		{
		}
	}
}
