using System;
using System.Collections;
using Core.Gameplay.Managers.Ad.Placements.BattleBonuses.Controller;
using Core.Gameplay.Managers.Ad.Placements.BattleBonuses.Events;
using Core.Gameplay.Managers.Ad.Placements.BattleBonuses.Model;
using Gameplay.Ad.BattleBonusesAd.View;
using Il2CppDummyDll;
using MVC;
using UnityEngine;

namespace Gameplay.Ad.BattleBonusesAd.Controller
{
	// Token: 0x02000DC2 RID: 3522
	[Token(Token = "0x2000DC2")]
	public class BattleBonusesAdWindowMediator : AbstractCozyViewMediator<BattleBonusesAdModel, BattleBonusesAdEvents, BattleBonusesAdController, BattleBonusesAdWindow>
	{
		// Token: 0x060055F2 RID: 22002 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055F2")]
		[Address(RVA = "0xA392", Offset = "0xA392", VA = "0xA392")]
		public BattleBonusesAdWindowMediator(BattleBonusesAdWindow view, BattleBonusesAdModel model, BattleBonusesAdEvents events, BattleBonusesAdController controller)
		{
		}

		// Token: 0x060055F3 RID: 22003 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055F3")]
		[Address(RVA = "0xA393", Offset = "0xA393", VA = "0xA393", Slot = "21")]
		protected override void ResetEvents(BattleBonusesAdEvents events)
		{
		}

		// Token: 0x060055F4 RID: 22004 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055F4")]
		[Address(RVA = "0xA394", Offset = "0xA394", VA = "0xA394", Slot = "22")]
		protected override void SetupEvents(BattleBonusesAdEvents events)
		{
		}

		// Token: 0x060055F5 RID: 22005 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055F5")]
		[Address(RVA = "0xA395", Offset = "0xA395", VA = "0xA395", Slot = "23")]
		protected override void ResetView(BattleBonusesAdWindow view)
		{
		}

		// Token: 0x060055F6 RID: 22006 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055F6")]
		[Address(RVA = "0xA396", Offset = "0xA396", VA = "0xA396", Slot = "24")]
		protected override void SetupView(BattleBonusesAdWindow view)
		{
		}

		// Token: 0x060055F7 RID: 22007 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055F7")]
		[Address(RVA = "0xA397", Offset = "0xA397", VA = "0xA397")]
		private void ValidateState()
		{
		}

		// Token: 0x060055F8 RID: 22008 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055F8")]
		[Address(RVA = "0xA398", Offset = "0xA398", VA = "0xA398")]
		private void AdAvailabilityPossiblyChangedEvent()
		{
		}

		// Token: 0x060055F9 RID: 22009 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60055F9")]
		[Address(RVA = "0xA399", Offset = "0xA399", VA = "0xA399")]
		private IEnumerator HandleAdAvailability()
		{
			return null;
		}

		// Token: 0x060055FA RID: 22010 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055FA")]
		[Address(RVA = "0xA39A", Offset = "0xA39A", VA = "0xA39A")]
		private void WatchButtonClickHandler()
		{
		}

		// Token: 0x04002E92 RID: 11922
		[Token(Token = "0x4002E92")]
		[FieldOffset(Offset = "0x18")]
		private Coroutine _handleAdAvailabilityRoutine;
	}
}
