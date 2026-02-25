using System;
using Core.Gameplay.Managers;
using Core.MVC.Interfaces;
using Gameplay.Clans.Buildings.Golem.Model;
using Gameplay.Clans.Buildings.Golem.View;
using Gameplay.Clans.ClanWars.Controller;
using Gameplay.Clans.ClanWars.Events;
using Il2CppDummyDll;
using MVC;
using Protocol.Common;

namespace Gameplay.Clans.Buildings.Golem.Controller
{
	// Token: 0x02000AE2 RID: 2786
	[Token(Token = "0x2000AE2")]
	public class TruceStatusViewMediator : AbstractViewMediator<GolemModel, ClanWarsEvents, ClanWarsController, WarStatusWindow>, IViewMediator<WarStatusWindow>, IViewMediator
	{
		// Token: 0x06004325 RID: 17189 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004325")]
		[Address(RVA = "0x91D9", Offset = "0x91D9", VA = "0x91D9")]
		public TruceStatusViewMediator(GolemModel model, ClanWarsEvents events, ClanWarsController controller)
		{
		}

		// Token: 0x17000D3C RID: 3388
		// (set) Token: 0x06004326 RID: 17190 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D3C")]
		public override WarStatusWindow View
		{
			[Token(Token = "0x6004326")]
			[Address(RVA = "0x91DA", Offset = "0x91DA", VA = "0x91DA", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06004327 RID: 17191 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004327")]
		[Address(RVA = "0x91DB", Offset = "0x91DB", VA = "0x91DB")]
		private void ShieldButtonClickedEventHandler()
		{
		}

		// Token: 0x06004328 RID: 17192 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004328")]
		[Address(RVA = "0x91DC", Offset = "0x91DC", VA = "0x91DC")]
		private void Init()
		{
		}

		// Token: 0x06004329 RID: 17193 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004329")]
		[Address(RVA = "0x91DD", Offset = "0x91DD", VA = "0x91DD")]
		private void UpdateView()
		{
		}

		// Token: 0x0600432A RID: 17194 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600432A")]
		[Address(RVA = "0x91DE", Offset = "0x91DE", VA = "0x91DE")]
		private void HandleHasCreditDebt()
		{
		}

		// Token: 0x0600432B RID: 17195 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600432B")]
		[Address(RVA = "0x91DF", Offset = "0x91DF", VA = "0x91DF")]
		private void HandleGolemHasShield()
		{
		}

		// Token: 0x0600432C RID: 17196 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600432C")]
		[Address(RVA = "0x91E0", Offset = "0x91E0", VA = "0x91E0")]
		private void HandleCanStartWar()
		{
		}

		// Token: 0x0600432D RID: 17197 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600432D")]
		[Address(RVA = "0x91E1", Offset = "0x91E1", VA = "0x91E1")]
		private void HandleWarsDisabled()
		{
		}

		// Token: 0x0600432E RID: 17198 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600432E")]
		[Address(RVA = "0x91E2", Offset = "0x91E2", VA = "0x91E2")]
		private void HandleSeasonEndSoon()
		{
		}

		// Token: 0x0600432F RID: 17199 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600432F")]
		[Address(RVA = "0x91E3", Offset = "0x91E3", VA = "0x91E3")]
		private void HandleSeasonEnd()
		{
		}

		// Token: 0x06004330 RID: 17200 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004330")]
		[Address(RVA = "0x91E4", Offset = "0x91E4", VA = "0x91E4")]
		private void UpdateGolemSleepAnnotation()
		{
		}

		// Token: 0x06004331 RID: 17201 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004331")]
		[Address(RVA = "0x91E5", Offset = "0x91E5", VA = "0x91E5")]
		private void UpdateShieldButtonAndCost()
		{
		}

		// Token: 0x06004332 RID: 17202 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004332")]
		[Address(RVA = "0x91E6", Offset = "0x91E6", VA = "0x91E6")]
		private void ValidateShieldButton()
		{
		}

		// Token: 0x040024FB RID: 9467
		[Token(Token = "0x40024FB")]
		[FieldOffset(Offset = "0x18")]
		private ClansManager _clansManager;

		// Token: 0x040024FC RID: 9468
		[Token(Token = "0x40024FC")]
		[FieldOffset(Offset = "0x1C")]
		private ClanWarsManager _clanWarsManager;

		// Token: 0x040024FD RID: 9469
		[Token(Token = "0x40024FD")]
		[FieldOffset(Offset = "0x20")]
		private ResourceSet _shieldActionCost;
	}
}
