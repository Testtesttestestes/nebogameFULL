using System;
using Gameplay.Combat.Control;
using Gameplay.Combat.Events;
using Gameplay.Combat.Model;
using Gameplay.Combat.View;
using Il2CppDummyDll;
using Utils;

namespace Gameplay.Duel.Controller
{
	// Token: 0x02000865 RID: 2149
	[Token(Token = "0x2000865")]
	public class DuelCombatViewMediator : OneOnOneCombatViewMediator<CombatModel, CombatEvents, DuelCombatController>
	{
		// Token: 0x0600326E RID: 12910 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600326E")]
		[Address(RVA = "0x82C3", Offset = "0x82C3", VA = "0x82C3")]
		public DuelCombatViewMediator(CombatModel model, CombatEvents events, DuelCombatController controller)
		{
		}

		// Token: 0x0600326F RID: 12911 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600326F")]
		[Address(RVA = "0x82C4", Offset = "0x82C4", VA = "0x82C4", Slot = "37")]
		protected override void HandleGameOver()
		{
		}

		// Token: 0x06003270 RID: 12912 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003270")]
		[Address(RVA = "0x82C5", Offset = "0x82C5", VA = "0x82C5", Slot = "33")]
		protected override CombatWaitingWindowMono ShowAwaitCombatWindow(BackTime backTime)
		{
			return null;
		}

		// Token: 0x06003271 RID: 12913 RVA: 0x0000A440 File Offset: 0x00008640
		[Token(Token = "0x6003271")]
		[Address(RVA = "0x82C6", Offset = "0x82C6", VA = "0x82C6", Slot = "22")]
		protected override bool HandleGameOverWindowCloseRequestEvent(CombatGameOverView wnd)
		{
			return default(bool);
		}

		// Token: 0x06003272 RID: 12914 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003272")]
		[Address(RVA = "0x82C7", Offset = "0x82C7", VA = "0x82C7")]
		private void CloseGameOverWindow()
		{
		}
	}
}
