using System;
using System.Collections.Generic;
using Gameplay.ThemeDuel.Events;
using Gameplay.ThemeDuel.Model;
using Gameplay.ThemeDuel.View;
using Il2CppDummyDll;
using MVC;
using MVC.Interfaces;
using Protocol.Dic;

namespace Gameplay.ThemeDuel.Controller
{
	// Token: 0x020004F6 RID: 1270
	[Token(Token = "0x20004F6")]
	public class ThemeDuelViewMediator : AbstractViewMediator<ThemeDuelModel, ThemeDuelEvents, ThemeDuelController, ThemeDuelWindow>
	{
		// Token: 0x06001E4E RID: 7758 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E4E")]
		[Address(RVA = "0x6FCC", Offset = "0x6FCC", VA = "0x6FCC")]
		public ThemeDuelViewMediator(ThemeDuelModel model, ThemeDuelEvents events, ThemeDuelController controller)
		{
		}

		// Token: 0x1700057F RID: 1407
		// (set) Token: 0x06001E4F RID: 7759 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700057F")]
		public override ThemeDuelWindow View
		{
			[Token(Token = "0x6001E4F")]
			[Address(RVA = "0x6FCD", Offset = "0x6FCD", VA = "0x6FCD", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06001E50 RID: 7760 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E50")]
		[Address(RVA = "0x6FCE", Offset = "0x6FCE", VA = "0x6FCE")]
		private void ListenEventDuelState()
		{
		}

		// Token: 0x06001E51 RID: 7761 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E51")]
		[Address(RVA = "0x6FCF", Offset = "0x6FCF", VA = "0x6FCF")]
		private void UnlistenEventDuelState()
		{
		}

		// Token: 0x06001E52 RID: 7762 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E52")]
		[Address(RVA = "0x6FD0", Offset = "0x6FD0", VA = "0x6FD0")]
		private void OnCurrentThemeDuelChanged(ThemeDuelDic td)
		{
		}

		// Token: 0x06001E53 RID: 7763 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E53")]
		[Address(RVA = "0x6FD1", Offset = "0x6FD1", VA = "0x6FD1")]
		private void ShowEventFinishedAlert()
		{
		}

		// Token: 0x06001E54 RID: 7764 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E54")]
		[Address(RVA = "0x6FD2", Offset = "0x6FD2", VA = "0x6FD2")]
		private void ResetView()
		{
		}

		// Token: 0x06001E55 RID: 7765 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E55")]
		[Address(RVA = "0x6FD3", Offset = "0x6FD3", VA = "0x6FD3")]
		private void SetupView()
		{
		}

		// Token: 0x06001E56 RID: 7766 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E56")]
		[Address(RVA = "0x6FD4", Offset = "0x6FD4", VA = "0x6FD4")]
		private void TabChangedEventHandler()
		{
		}

		// Token: 0x06001E57 RID: 7767 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001E57")]
		[Address(RVA = "0x6FD5", Offset = "0x6FD5", VA = "0x6FD5")]
		private IHideableMediator ShowRulesTab()
		{
			return null;
		}

		// Token: 0x06001E58 RID: 7768 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001E58")]
		[Address(RVA = "0x6FD6", Offset = "0x6FD6", VA = "0x6FD6")]
		private IHideableMediator ShowRatingTab()
		{
			return null;
		}

		// Token: 0x06001E59 RID: 7769 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001E59")]
		[Address(RVA = "0x6FD7", Offset = "0x6FD7", VA = "0x6FD7")]
		private IHideableMediator ShowShopTab()
		{
			return null;
		}

		// Token: 0x06001E5A RID: 7770 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E5A")]
		[Address(RVA = "0x6FD8", Offset = "0x6FD8", VA = "0x6FD8", Slot = "14")]
		public override void Dispose()
		{
		}

		// Token: 0x04001078 RID: 4216
		[Token(Token = "0x4001078")]
		[FieldOffset(Offset = "0x18")]
		private RulesViewMediator _rulesViewMediator;

		// Token: 0x04001079 RID: 4217
		[Token(Token = "0x4001079")]
		[FieldOffset(Offset = "0x1C")]
		private ThemeDuelRatingViewMediator _tdRatingViewMediator;

		// Token: 0x0400107A RID: 4218
		[Token(Token = "0x400107A")]
		[FieldOffset(Offset = "0x20")]
		private ThemeDuelShopViewMediator _tdShopViewMediator;

		// Token: 0x0400107B RID: 4219
		[Token(Token = "0x400107B")]
		[FieldOffset(Offset = "0x24")]
		private readonly Dictionary<ThemeDuelTargets, Func<IHideableMediator>> _tabsOpenersById;

		// Token: 0x0400107C RID: 4220
		[Token(Token = "0x400107C")]
		[FieldOffset(Offset = "0x28")]
		private IHideableMediator _currentMediator;
	}
}
