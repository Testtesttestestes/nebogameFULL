using System;
using Gameplay.Clans.ClanWars.Controller;
using Gameplay.Clans.ClanWars.Events;
using Gameplay.Clans.ClanWars.Model;
using Il2CppDummyDll;

namespace Gameplay.Clans.Office.Controller.ClanWars
{
	// Token: 0x02000A87 RID: 2695
	[Token(Token = "0x2000A87")]
	public class DefenderWarStatusViewMediator : WarStatusViewMediatorBase
	{
		// Token: 0x0600407B RID: 16507 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600407B")]
		[Address(RVA = "0x8F35", Offset = "0x8F35", VA = "0x8F35")]
		public DefenderWarStatusViewMediator(ClanWarsModel model, ClanWarsEvents events, ClanWarsController controller, string enemyClanName)
		{
		}

		// Token: 0x0600407C RID: 16508 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600407C")]
		[Address(RVA = "0x8F36", Offset = "0x8F36", VA = "0x8F36", Slot = "23")]
		protected override void HandlePrepareState()
		{
		}

		// Token: 0x0600407D RID: 16509 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600407D")]
		[Address(RVA = "0x8F37", Offset = "0x8F37", VA = "0x8F37", Slot = "25")]
		protected override void HandleSoonStartState()
		{
		}

		// Token: 0x0600407E RID: 16510 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600407E")]
		[Address(RVA = "0x8F38", Offset = "0x8F38", VA = "0x8F38", Slot = "24")]
		protected override void HandleAcceleratedState()
		{
		}

		// Token: 0x0600407F RID: 16511 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600407F")]
		[Address(RVA = "0x8F39", Offset = "0x8F39", VA = "0x8F39")]
		private void CancelAccelerationButtonClickedEventHandler()
		{
		}

		// Token: 0x06004080 RID: 16512 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004080")]
		[Address(RVA = "0x8F3A", Offset = "0x8F3A", VA = "0x8F3A")]
		private void PayOffButtonClickedEventHandler()
		{
		}
	}
}
