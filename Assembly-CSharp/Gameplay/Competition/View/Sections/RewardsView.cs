using System;
using Core.MVC.Interfaces;
using Gameplay.Competition.Control.Sections;
using Gameplay.Competition.Events;
using Gameplay.Competition.Model;
using Gameplay.VortexRating.View.GreatPrizesTab;
using Il2CppDummyDll;
using MVC;
using UnityEngine;

namespace Gameplay.Competition.View.Sections
{
	// Token: 0x020008E0 RID: 2272
	[Token(Token = "0x20008E0")]
	[AddComponentMenu("Competition/View/Sections/RewardsView")]
	public class RewardsView : BaseSectionView<RewardsController>
	{
		// Token: 0x17000A90 RID: 2704
		// (get) Token: 0x06003575 RID: 13685 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000A90")]
		public GreatPrizesView GreatPrizesTab
		{
			[Token(Token = "0x6003575")]
			[Address(RVA = "0x8583", Offset = "0x8583", VA = "0x8583")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003576 RID: 13686 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003576")]
		[Address(RVA = "0x8584", Offset = "0x8584", VA = "0x8584", Slot = "6")]
		protected override void CreateController(CompetitionModel model, CompetitionEvents events, out RewardsController controller)
		{
		}

		// Token: 0x06003577 RID: 13687 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003577")]
		[Address(RVA = "0x8585", Offset = "0x8585", VA = "0x8585", Slot = "7")]
		protected override void CreateMediator(RewardsController controller, out IViewMediator mediator)
		{
		}

		// Token: 0x06003578 RID: 13688 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003578")]
		[Address(RVA = "0x8586", Offset = "0x8586", VA = "0x8586", Slot = "8")]
		protected override void RunController(RewardsController controller, out AbstractMVCEvents events)
		{
		}

		// Token: 0x06003579 RID: 13689 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003579")]
		[Address(RVA = "0x8587", Offset = "0x8587", VA = "0x8587")]
		public RewardsView()
		{
		}

		// Token: 0x04001D40 RID: 7488
		[Token(Token = "0x4001D40")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private GreatPrizesView _greatPrizesTab;
	}
}
