using System;
using System.Collections;
using Core.Gameplay.Managers.Ad.Placements.DailyQuests.Controller;
using Core.Gameplay.Managers.Ad.Placements.DailyQuests.Events;
using Core.Gameplay.Managers.Ad.Placements.DailyQuests.Model;
using Gameplay.Ad.DailyQuestsAd.View;
using Gameplay.DailyQuests.Model;
using Il2CppDummyDll;
using MVC;
using UnityEngine;

namespace Gameplay.Ad.DailyQuestsAd.Controller
{
	// Token: 0x02000DB0 RID: 3504
	[Token(Token = "0x2000DB0")]
	public class DailyQuestsAdViewMediator : AbstractViewMediator<DailyQuestsAdPlacementModel, DailyQuestsAdPlacementEvents, DailyQuestsAdPlacementController, DailyQuestsAdView>
	{
		// Token: 0x06005598 RID: 21912 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005598")]
		[Address(RVA = "0xA338", Offset = "0xA338", VA = "0xA338")]
		public DailyQuestsAdViewMediator(DailyQuestsAdPlacementModel model, DailyQuestsAdPlacementEvents events, DailyQuestsAdPlacementController controller, IDailyQuest dailyQuest)
		{
		}

		// Token: 0x17001164 RID: 4452
		// (set) Token: 0x06005599 RID: 21913 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001164")]
		public override DailyQuestsAdView View
		{
			[Token(Token = "0x6005599")]
			[Address(RVA = "0xA339", Offset = "0xA339", VA = "0xA339", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x17001165 RID: 4453
		// (set) Token: 0x0600559A RID: 21914 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001165")]
		public override DailyQuestsAdPlacementEvents Events
		{
			[Token(Token = "0x600559A")]
			[Address(RVA = "0xA33A", Offset = "0xA33A", VA = "0xA33A", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x0600559B RID: 21915 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600559B")]
		[Address(RVA = "0xA33B", Offset = "0xA33B", VA = "0xA33B")]
		private void ValidateState()
		{
		}

		// Token: 0x0600559C RID: 21916 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600559C")]
		[Address(RVA = "0xA33C", Offset = "0xA33C", VA = "0xA33C")]
		private void DailyQuestChangedEventHandler()
		{
		}

		// Token: 0x0600559D RID: 21917 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600559D")]
		[Address(RVA = "0xA33D", Offset = "0xA33D", VA = "0xA33D")]
		private void WatchButtonClickedEventHandler()
		{
		}

		// Token: 0x0600559E RID: 21918 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600559E")]
		[Address(RVA = "0xA33E", Offset = "0xA33E", VA = "0xA33E")]
		private IEnumerator ValidateRoutine()
		{
			return null;
		}

		// Token: 0x04002E57 RID: 11863
		[Token(Token = "0x4002E57")]
		[FieldOffset(Offset = "0x18")]
		private Coroutine _validateRoutine;

		// Token: 0x04002E58 RID: 11864
		[Token(Token = "0x4002E58")]
		[FieldOffset(Offset = "0x1C")]
		private bool _adAvailable;

		// Token: 0x04002E59 RID: 11865
		[Token(Token = "0x4002E59")]
		[FieldOffset(Offset = "0x20")]
		private readonly IDailyQuest _dailyQuest;
	}
}
