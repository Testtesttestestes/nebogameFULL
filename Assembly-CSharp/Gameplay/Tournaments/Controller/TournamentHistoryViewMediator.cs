using System;
using Gameplay.Tournaments.Events;
using Gameplay.Tournaments.Model;
using Gameplay.Tournaments.View;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Tournaments.Controller
{
	// Token: 0x020004BE RID: 1214
	[Token(Token = "0x20004BE")]
	public class TournamentHistoryViewMediator : AbstractViewMediator<TournamentsModel, TournamentsEvents, TournamentsController, TournamentHistoryWindow>
	{
		// Token: 0x06001CB8 RID: 7352 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CB8")]
		[Address(RVA = "0x6E37", Offset = "0x6E37", VA = "0x6E37")]
		public TournamentHistoryViewMediator(TournamentsModel model, TournamentsEvents events, TournamentsController controller)
		{
		}

		// Token: 0x1700052F RID: 1327
		// (set) Token: 0x06001CB9 RID: 7353 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700052F")]
		public override TournamentHistoryWindow View
		{
			[Token(Token = "0x6001CB9")]
			[Address(RVA = "0x6E38", Offset = "0x6E38", VA = "0x6E38", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06001CBA RID: 7354 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CBA")]
		[Address(RVA = "0x6E39", Offset = "0x6E39", VA = "0x6E39")]
		private void PrevButtonClickedEventHandler()
		{
		}

		// Token: 0x06001CBB RID: 7355 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CBB")]
		[Address(RVA = "0x6E3A", Offset = "0x6E3A", VA = "0x6E3A")]
		private void NextButtonClickedEventHandler()
		{
		}

		// Token: 0x06001CBC RID: 7356 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CBC")]
		[Address(RVA = "0x6E3B", Offset = "0x6E3B", VA = "0x6E3B")]
		private void RulesButtonClickedEventHandler()
		{
		}

		// Token: 0x06001CBD RID: 7357 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CBD")]
		[Address(RVA = "0x6E3C", Offset = "0x6E3C", VA = "0x6E3C")]
		private void Init()
		{
		}

		// Token: 0x06001CBE RID: 7358 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CBE")]
		[Address(RVA = "0x6E3D", Offset = "0x6E3D", VA = "0x6E3D")]
		private void ValidateNextPrevButtons()
		{
		}

		// Token: 0x06001CBF RID: 7359 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CBF")]
		[Address(RVA = "0x6E3E", Offset = "0x6E3E", VA = "0x6E3E")]
		private void UpdateView()
		{
		}

		// Token: 0x04000FAE RID: 4014
		[Token(Token = "0x4000FAE")]
		[FieldOffset(Offset = "0x18")]
		private int _index;

		// Token: 0x04000FAF RID: 4015
		[Token(Token = "0x4000FAF")]
		[FieldOffset(Offset = "0x1C")]
		private bool _isPlayerParticipant;
	}
}
