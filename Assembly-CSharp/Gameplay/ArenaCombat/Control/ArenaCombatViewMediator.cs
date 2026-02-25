using System;
using Core.Data;
using Gameplay.ArenaCombat.Model;
using Gameplay.Combat.Control;
using Gameplay.Combat.View;
using Il2CppDummyDll;
using Utils;

namespace Gameplay.ArenaCombat.Control
{
	// Token: 0x02000D4B RID: 3403
	[Token(Token = "0x2000D4B")]
	public class ArenaCombatViewMediator : OneOnOneCombatViewMediator<ArenaCombatModel, ArenaCombatEvents, ArenaCombatController>
	{
		// Token: 0x06005358 RID: 21336 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005358")]
		[Address(RVA = "0xA117", Offset = "0xA117", VA = "0xA117")]
		public ArenaCombatViewMediator(ArenaCombatModel model, ArenaCombatEvents events, ArenaCombatController controller)
		{
		}

		// Token: 0x06005359 RID: 21337 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005359")]
		[Address(RVA = "0xA118", Offset = "0xA118", VA = "0xA118", Slot = "33")]
		protected override CombatWaitingWindowMono ShowAwaitCombatWindow(BackTime backTime)
		{
			return null;
		}

		// Token: 0x0600535A RID: 21338 RVA: 0x0000F138 File Offset: 0x0000D338
		[Token(Token = "0x600535A")]
		[Address(RVA = "0xA119", Offset = "0xA119", VA = "0xA119", Slot = "22")]
		protected override bool HandleGameOverWindowCloseRequestEvent(CombatGameOverView view)
		{
			return default(bool);
		}

		// Token: 0x0600535B RID: 21339 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600535B")]
		[Address(RVA = "0xA11A", Offset = "0xA11A", VA = "0xA11A")]
		private void ResolveMonsterOrigin(UserData user, ArenaCombatModel.AttackRequestedMonster requestedMonster)
		{
		}

		// Token: 0x0600535C RID: 21340 RVA: 0x0000F150 File Offset: 0x0000D350
		[Token(Token = "0x600535C")]
		[Address(RVA = "0xA11B", Offset = "0xA11B", VA = "0xA11B", Slot = "21")]
		protected override bool HandleGameOverWindowNextCombatRequestEvent(CombatGameOverView gameOverView)
		{
			return default(bool);
		}
	}
}
