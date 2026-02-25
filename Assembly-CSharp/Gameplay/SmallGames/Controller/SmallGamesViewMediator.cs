using System;
using System.Collections;
using Gameplay.SmallGames.Events;
using Gameplay.SmallGames.Model;
using Gameplay.SmallGames.View;
using Il2CppDummyDll;
using MVC;
using Protocol.SmallGames;
using UnityEngine;

namespace Gameplay.SmallGames.Controller
{
	// Token: 0x02000540 RID: 1344
	[Token(Token = "0x2000540")]
	public class SmallGamesViewMediator : AbstractViewMediator<SmallGamesModel, Gameplay.SmallGames.Events.SmallGamesEvents, SmallGamesController, SmallGamesWindow>
	{
		// Token: 0x0600202B RID: 8235 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600202B")]
		[Address(RVA = "0x7190", Offset = "0x7190", VA = "0x7190")]
		public SmallGamesViewMediator(SmallGamesModel model, Gameplay.SmallGames.Events.SmallGamesEvents events, SmallGamesController controller)
		{
		}

		// Token: 0x170005E2 RID: 1506
		// (set) Token: 0x0600202C RID: 8236 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005E2")]
		public override SmallGamesWindow View
		{
			[Token(Token = "0x600202C")]
			[Address(RVA = "0x7191", Offset = "0x7191", VA = "0x7191", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x170005E3 RID: 1507
		// (set) Token: 0x0600202D RID: 8237 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005E3")]
		public override Gameplay.SmallGames.Events.SmallGamesEvents Events
		{
			[Token(Token = "0x600202D")]
			[Address(RVA = "0x7192", Offset = "0x7192", VA = "0x7192", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x0600202E RID: 8238 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600202E")]
		[Address(RVA = "0x7193", Offset = "0x7193", VA = "0x7193")]
		private void TakeButtonClickEventHandler()
		{
		}

		// Token: 0x0600202F RID: 8239 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600202F")]
		[Address(RVA = "0x7194", Offset = "0x7194", VA = "0x7194")]
		private void HandleNotificationsCountChanged(int count)
		{
		}

		// Token: 0x06002030 RID: 8240 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002030")]
		[Address(RVA = "0x7195", Offset = "0x7195", VA = "0x7195")]
		private void WinningCombinationsButtonClickEventHandler()
		{
		}

		// Token: 0x06002031 RID: 8241 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002031")]
		[Address(RVA = "0x7196", Offset = "0x7196", VA = "0x7196")]
		private void LastDropRequestedEventHandler()
		{
		}

		// Token: 0x06002032 RID: 8242 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002032")]
		[Address(RVA = "0x7197", Offset = "0x7197", VA = "0x7197")]
		private void ChangedTabEventHandler()
		{
		}

		// Token: 0x06002033 RID: 8243 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002033")]
		[Address(RVA = "0x7198", Offset = "0x7198", VA = "0x7198")]
		private void SelectCurrentSlotWheels(SlotMachineType type)
		{
		}

		// Token: 0x06002034 RID: 8244 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002034")]
		[Address(RVA = "0x7199", Offset = "0x7199", VA = "0x7199")]
		private void AttemptsCountChangedEventHandler(uint attemptsCount)
		{
		}

		// Token: 0x06002035 RID: 8245 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002035")]
		[Address(RVA = "0x719A", Offset = "0x719A", VA = "0x719A")]
		private void FreeAttemptsRequestedEventHandler()
		{
		}

		// Token: 0x06002036 RID: 8246 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002036")]
		[Address(RVA = "0x719B", Offset = "0x719B", VA = "0x719B")]
		private void SpinButtonClickEventHandler()
		{
		}

		// Token: 0x06002037 RID: 8247 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002037")]
		[Address(RVA = "0x719C", Offset = "0x719C", VA = "0x719C")]
		private void WheelResultReceivedEventHandler(bool success)
		{
		}

		// Token: 0x06002038 RID: 8248 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002038")]
		[Address(RVA = "0x719D", Offset = "0x719D", VA = "0x719D")]
		private void WheelsStoppedEventHandler()
		{
		}

		// Token: 0x06002039 RID: 8249 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002039")]
		[Address(RVA = "0x719E", Offset = "0x719E", VA = "0x719E")]
		private void LastJackpotRequestedEventHandler(SlotMachineType type)
		{
		}

		// Token: 0x0600203A RID: 8250 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600203A")]
		[Address(RVA = "0x719F", Offset = "0x719F", VA = "0x719F")]
		private void JackpotRequestedEventHandler()
		{
		}

		// Token: 0x0600203B RID: 8251 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600203B")]
		[Address(RVA = "0x71A0", Offset = "0x71A0", VA = "0x71A0")]
		private void VisitRegisteredEventHandler()
		{
		}

		// Token: 0x0600203C RID: 8252 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600203C")]
		[Address(RVA = "0x71A1", Offset = "0x71A1", VA = "0x71A1")]
		private void SetupView()
		{
		}

		// Token: 0x0600203D RID: 8253 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600203D")]
		[Address(RVA = "0x71A2", Offset = "0x71A2", VA = "0x71A2")]
		private void UpdateCasino()
		{
		}

		// Token: 0x0600203E RID: 8254 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600203E")]
		[Address(RVA = "0x71A3", Offset = "0x71A3", VA = "0x71A3")]
		private void UpdateSpinButtonView()
		{
		}

		// Token: 0x0600203F RID: 8255 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600203F")]
		[Address(RVA = "0x71A4", Offset = "0x71A4", VA = "0x71A4")]
		private void UpdateTimer()
		{
		}

		// Token: 0x06002040 RID: 8256 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002040")]
		[Address(RVA = "0x71A5", Offset = "0x71A5", VA = "0x71A5")]
		private IEnumerator NextFreeSpinRoutine(float backtime)
		{
			return null;
		}

		// Token: 0x06002041 RID: 8257 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002041")]
		[Address(RVA = "0x71A6", Offset = "0x71A6", VA = "0x71A6", Slot = "14")]
		public override void Dispose()
		{
		}

		// Token: 0x0400119B RID: 4507
		[Token(Token = "0x400119B")]
		private const string LOCALIZATION_SPIN = "SMALL_GAMES/SPIN";

		// Token: 0x0400119C RID: 4508
		[Token(Token = "0x400119C")]
		private const string LOCALIZATION_STOP = "SMALL_GAMES/STOP";

		// Token: 0x0400119D RID: 4509
		[Token(Token = "0x400119D")]
		private const string LOCALIZATION_DIAMONDS = "SMALL_GAMES/DIAMONDS";

		// Token: 0x0400119E RID: 4510
		[Token(Token = "0x400119E")]
		private const string LOCALIZATION_ONYXES = "SMALL_GAMES/ONYXES";

		// Token: 0x0400119F RID: 4511
		[Token(Token = "0x400119F")]
		private const string LOCALIZATION_NO_ITEMS = "SMALL_GAMES/NO_ITEMS";

		// Token: 0x040011A0 RID: 4512
		[Token(Token = "0x40011A0")]
		[FieldOffset(Offset = "0x18")]
		private bool _takeButtonClicked;

		// Token: 0x040011A1 RID: 4513
		[Token(Token = "0x40011A1")]
		[FieldOffset(Offset = "0x1C")]
		private Coroutine _nextFreeSpinRoutine;
	}
}
