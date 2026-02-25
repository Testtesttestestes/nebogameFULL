using System;
using Gameplay.Clans.ClanWars.Controller;
using Gameplay.Clans.ClanWars.Events;
using Gameplay.Clans.ClanWars.Model;
using Il2CppDummyDll;

namespace Gameplay.Clans.Office.Controller.ClanWars
{
	// Token: 0x02000A7F RID: 2687
	[Token(Token = "0x2000A7F")]
	public class AttackerWarStatusViewMediator : WarStatusViewMediatorBase
	{
		// Token: 0x0600401A RID: 16410 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600401A")]
		[Address(RVA = "0x8ED4", Offset = "0x8ED4", VA = "0x8ED4")]
		public AttackerWarStatusViewMediator(ClanWarsModel model, ClanWarsEvents events, ClanWarsController controller, string enemyClanName)
		{
		}

		// Token: 0x0600401B RID: 16411 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600401B")]
		[Address(RVA = "0x8ED5", Offset = "0x8ED5", VA = "0x8ED5", Slot = "23")]
		protected override void HandlePrepareState()
		{
		}

		// Token: 0x0600401C RID: 16412 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600401C")]
		[Address(RVA = "0x8ED6", Offset = "0x8ED6", VA = "0x8ED6")]
		private void AccelerateButtonClickedEventHandler()
		{
		}

		// Token: 0x0600401D RID: 16413 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600401D")]
		[Address(RVA = "0x8ED7", Offset = "0x8ED7", VA = "0x8ED7", Slot = "25")]
		protected override void HandleSoonStartState()
		{
		}

		// Token: 0x0600401E RID: 16414 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600401E")]
		[Address(RVA = "0x8ED8", Offset = "0x8ED8", VA = "0x8ED8", Slot = "24")]
		protected override void HandleAcceleratedState()
		{
		}
	}
}
