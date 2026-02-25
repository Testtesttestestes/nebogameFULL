using System;
using Core.Gameplay.Managers;
using Core.MVC.Interfaces;
using Gameplay.Clans.Buildings.Golem.Model;
using Gameplay.Clans.Buildings.Golem.View;
using Gameplay.Clans.ClanWars.Controller;
using Gameplay.Clans.ClanWars.Events;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Clans.Buildings.Golem.Controller
{
	// Token: 0x02000ADA RID: 2778
	[Token(Token = "0x2000ADA")]
	public class EnemyTruceStatusViewMediator : AbstractViewMediator<GolemModel, ClanWarsEvents, ClanWarsController, WarStatusWindow>, IViewMediator<WarStatusWindow>, IViewMediator
	{
		// Token: 0x060042E2 RID: 17122 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042E2")]
		[Address(RVA = "0x9196", Offset = "0x9196", VA = "0x9196")]
		public EnemyTruceStatusViewMediator(GolemModel model, ClanWarsEvents events, ClanWarsController controller)
		{
		}

		// Token: 0x17000D37 RID: 3383
		// (set) Token: 0x060042E3 RID: 17123 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D37")]
		public override WarStatusWindow View
		{
			[Token(Token = "0x60042E3")]
			[Address(RVA = "0x9197", Offset = "0x9197", VA = "0x9197", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x060042E4 RID: 17124 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042E4")]
		[Address(RVA = "0x9198", Offset = "0x9198", VA = "0x9198")]
		private void WarButtonClickedEventHandler()
		{
		}

		// Token: 0x060042E5 RID: 17125 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042E5")]
		[Address(RVA = "0x9199", Offset = "0x9199", VA = "0x9199")]
		private void Init()
		{
		}

		// Token: 0x060042E6 RID: 17126 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042E6")]
		[Address(RVA = "0x919A", Offset = "0x919A", VA = "0x919A")]
		private void UpdateView()
		{
		}

		// Token: 0x060042E7 RID: 17127 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042E7")]
		[Address(RVA = "0x919B", Offset = "0x919B", VA = "0x919B")]
		private void HandleCanStartWar()
		{
		}

		// Token: 0x060042E8 RID: 17128 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042E8")]
		[Address(RVA = "0x919C", Offset = "0x919C", VA = "0x919C")]
		private void HandleWarsDisabled()
		{
		}

		// Token: 0x060042E9 RID: 17129 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042E9")]
		[Address(RVA = "0x919D", Offset = "0x919D", VA = "0x919D")]
		private void HandleSeasonEndSoon()
		{
		}

		// Token: 0x060042EA RID: 17130 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042EA")]
		[Address(RVA = "0x919E", Offset = "0x919E", VA = "0x919E")]
		private void HandleSeasonEnd()
		{
		}

		// Token: 0x060042EB RID: 17131 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042EB")]
		[Address(RVA = "0x919F", Offset = "0x919F", VA = "0x919F")]
		private void HandleGolemHasShield()
		{
		}

		// Token: 0x060042EC RID: 17132 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042EC")]
		[Address(RVA = "0x91A0", Offset = "0x91A0", VA = "0x91A0")]
		private void HandleHasCreditDebt()
		{
		}

		// Token: 0x060042ED RID: 17133 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042ED")]
		[Address(RVA = "0x91A1", Offset = "0x91A1", VA = "0x91A1")]
		private void HandleDifferentLeagues()
		{
		}

		// Token: 0x040024F3 RID: 9459
		[Token(Token = "0x40024F3")]
		[FieldOffset(Offset = "0x18")]
		private ClansManager _clansManager;

		// Token: 0x040024F4 RID: 9460
		[Token(Token = "0x40024F4")]
		[FieldOffset(Offset = "0x1C")]
		private ClanWarsManager _clanWarsManager;
	}
}
