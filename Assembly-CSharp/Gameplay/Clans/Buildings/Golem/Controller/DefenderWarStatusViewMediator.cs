using System;
using Core.Gameplay.Managers;
using Core.MVC.Interfaces;
using Gameplay.Clans.Buildings.Golem.Model;
using Gameplay.Clans.Buildings.Golem.View;
using Gameplay.Clans.ClanWars.Controller;
using Gameplay.Clans.ClanWars.Events;
using Il2CppDummyDll;
using MVC;
using Protocol.ClanWar;

namespace Gameplay.Clans.Buildings.Golem.Controller
{
	// Token: 0x02000AD9 RID: 2777
	[Token(Token = "0x2000AD9")]
	public class DefenderWarStatusViewMediator : AbstractViewMediator<GolemModel, ClanWarsEvents, ClanWarsController, WarStatusWindow>, IViewMediator<WarStatusWindow>, IViewMediator
	{
		// Token: 0x17000D35 RID: 3381
		// (get) Token: 0x060042D8 RID: 17112 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000D35")]
		private ClanWarInfo WarInfo
		{
			[Token(Token = "0x60042D8")]
			[Address(RVA = "0x918C", Offset = "0x918C", VA = "0x918C")]
			get
			{
				return null;
			}
		}

		// Token: 0x060042D9 RID: 17113 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042D9")]
		[Address(RVA = "0x918D", Offset = "0x918D", VA = "0x918D")]
		public DefenderWarStatusViewMediator(GolemModel model, ClanWarsEvents events, ClanWarsController controller)
		{
		}

		// Token: 0x17000D36 RID: 3382
		// (set) Token: 0x060042DA RID: 17114 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D36")]
		public override WarStatusWindow View
		{
			[Token(Token = "0x60042DA")]
			[Address(RVA = "0x918E", Offset = "0x918E", VA = "0x918E", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x060042DB RID: 17115 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042DB")]
		[Address(RVA = "0x918F", Offset = "0x918F", VA = "0x918F")]
		private void Init()
		{
		}

		// Token: 0x060042DC RID: 17116 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042DC")]
		[Address(RVA = "0x9190", Offset = "0x9190", VA = "0x9190")]
		private void UpdateView()
		{
		}

		// Token: 0x060042DD RID: 17117 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042DD")]
		[Address(RVA = "0x9191", Offset = "0x9191", VA = "0x9191")]
		private void HandlePrepareState()
		{
		}

		// Token: 0x060042DE RID: 17118 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042DE")]
		[Address(RVA = "0x9192", Offset = "0x9192", VA = "0x9192")]
		private void HandleAcceleratedState()
		{
		}

		// Token: 0x060042DF RID: 17119 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042DF")]
		[Address(RVA = "0x9193", Offset = "0x9193", VA = "0x9193")]
		private void HandleActiveState()
		{
		}

		// Token: 0x060042E0 RID: 17120 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042E0")]
		[Address(RVA = "0x9194", Offset = "0x9194", VA = "0x9194")]
		private void CancelAccelerationButtonClickedEventHandler()
		{
		}

		// Token: 0x060042E1 RID: 17121 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042E1")]
		[Address(RVA = "0x9195", Offset = "0x9195", VA = "0x9195")]
		private void PayOffButtonClickedEventHandler()
		{
		}

		// Token: 0x040024F1 RID: 9457
		[Token(Token = "0x40024F1")]
		[FieldOffset(Offset = "0x18")]
		private ClansManager _clansManager;

		// Token: 0x040024F2 RID: 9458
		[Token(Token = "0x40024F2")]
		[FieldOffset(Offset = "0x1C")]
		private ClanWarsManager _clanWarsManager;
	}
}
