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
	// Token: 0x02000AD7 RID: 2775
	[Token(Token = "0x2000AD7")]
	public class AttackerWarStatusViewMediator : AbstractViewMediator<GolemModel, ClanWarsEvents, ClanWarsController, WarStatusWindow>, IViewMediator<WarStatusWindow>, IViewMediator
	{
		// Token: 0x17000D32 RID: 3378
		// (get) Token: 0x060042CA RID: 17098 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000D32")]
		private ClanWarInfo WarInfo
		{
			[Token(Token = "0x60042CA")]
			[Address(RVA = "0x917E", Offset = "0x917E", VA = "0x917E")]
			get
			{
				return null;
			}
		}

		// Token: 0x060042CB RID: 17099 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042CB")]
		[Address(RVA = "0x917F", Offset = "0x917F", VA = "0x917F")]
		public AttackerWarStatusViewMediator(GolemModel model, ClanWarsEvents events, ClanWarsController controller)
		{
		}

		// Token: 0x17000D33 RID: 3379
		// (set) Token: 0x060042CC RID: 17100 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D33")]
		public override WarStatusWindow View
		{
			[Token(Token = "0x60042CC")]
			[Address(RVA = "0x9180", Offset = "0x9180", VA = "0x9180", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x060042CD RID: 17101 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042CD")]
		[Address(RVA = "0x9181", Offset = "0x9181", VA = "0x9181")]
		private void Init()
		{
		}

		// Token: 0x060042CE RID: 17102 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042CE")]
		[Address(RVA = "0x9182", Offset = "0x9182", VA = "0x9182")]
		private void UpdateView()
		{
		}

		// Token: 0x060042CF RID: 17103 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042CF")]
		[Address(RVA = "0x9183", Offset = "0x9183", VA = "0x9183")]
		private void HandlePrepareState()
		{
		}

		// Token: 0x060042D0 RID: 17104 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042D0")]
		[Address(RVA = "0x9184", Offset = "0x9184", VA = "0x9184")]
		private void HandleAcceleratedState()
		{
		}

		// Token: 0x060042D1 RID: 17105 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042D1")]
		[Address(RVA = "0x9185", Offset = "0x9185", VA = "0x9185")]
		private void HandleActiveState()
		{
		}

		// Token: 0x060042D2 RID: 17106 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042D2")]
		[Address(RVA = "0x9186", Offset = "0x9186", VA = "0x9186")]
		private void HandleSoonStartState()
		{
		}

		// Token: 0x060042D3 RID: 17107 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042D3")]
		[Address(RVA = "0x9187", Offset = "0x9187", VA = "0x9187")]
		private void FillBottomAnnotation()
		{
		}

		// Token: 0x060042D4 RID: 17108 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042D4")]
		[Address(RVA = "0x9188", Offset = "0x9188", VA = "0x9188")]
		private void AccelerateButtonClickedEventHandler()
		{
		}

		// Token: 0x040024EF RID: 9455
		[Token(Token = "0x40024EF")]
		[FieldOffset(Offset = "0x18")]
		private ClansManager _clansManager;

		// Token: 0x040024F0 RID: 9456
		[Token(Token = "0x40024F0")]
		[FieldOffset(Offset = "0x1C")]
		private ClanWarsManager _clanWarsManager;
	}
}
