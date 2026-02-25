using System;
using Core.Gameplay.Managers;
using Core.MVC.Interfaces;
using Gameplay.Clans.ClanWars.Controller;
using Gameplay.Clans.ClanWars.Events;
using Gameplay.Clans.ClanWars.Model;
using Gameplay.Clans.Office.View.ClanWarsTab.ClanPoliticsTab;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Clans.Office.Controller.ClanWars
{
	// Token: 0x02000A89 RID: 2697
	[Token(Token = "0x2000A89")]
	public abstract class WarStatusViewMediatorBase : AbstractViewMediator<ClanWarsModel, ClanWarsEvents, ClanWarsController, ClanWarStatusView>, IViewMediator<ClanWarStatusView>, IViewMediator
	{
		// Token: 0x06004086 RID: 16518 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004086")]
		[Address(RVA = "0x8F40", Offset = "0x8F40", VA = "0x8F40")]
		public WarStatusViewMediatorBase(ClanWarsModel model, ClanWarsEvents events, ClanWarsController controller, string enemyClanName)
		{
		}

		// Token: 0x17000CBA RID: 3258
		// (set) Token: 0x06004087 RID: 16519 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CBA")]
		public override ClanWarStatusView View
		{
			[Token(Token = "0x6004087")]
			[Address(RVA = "0x8F41", Offset = "0x8F41", VA = "0x8F41", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06004088 RID: 16520 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004088")]
		[Address(RVA = "0x8F42", Offset = "0x8F42", VA = "0x8F42")]
		private void Init()
		{
		}

		// Token: 0x06004089 RID: 16521
		[Token(Token = "0x6004089")]
		protected abstract void HandlePrepareState();

		// Token: 0x0600408A RID: 16522
		[Token(Token = "0x600408A")]
		protected abstract void HandleAcceleratedState();

		// Token: 0x0600408B RID: 16523
		[Token(Token = "0x600408B")]
		protected abstract void HandleSoonStartState();

		// Token: 0x0600408C RID: 16524 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600408C")]
		[Address(RVA = "0x8F43", Offset = "0x8F43", VA = "0x8F43")]
		private void HandleActiveState()
		{
		}

		// Token: 0x0600408D RID: 16525 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600408D")]
		[Address(RVA = "0x8F44", Offset = "0x8F44", VA = "0x8F44")]
		private void AttackButtonClickedEventHandler()
		{
		}

		// Token: 0x0600408E RID: 16526 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600408E")]
		[Address(RVA = "0x8F45", Offset = "0x8F45", VA = "0x8F45")]
		private void SetStatusLocalizationKey(string key)
		{
		}

		// Token: 0x040023E2 RID: 9186
		[Token(Token = "0x40023E2")]
		[FieldOffset(Offset = "0x18")]
		protected ClansManager _clansManager;

		// Token: 0x040023E3 RID: 9187
		[Token(Token = "0x40023E3")]
		[FieldOffset(Offset = "0x1C")]
		private string _enemyClanName;
	}
}
