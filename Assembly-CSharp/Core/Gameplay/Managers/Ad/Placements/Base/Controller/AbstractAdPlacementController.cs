using System;
using Core.Gameplay.Managers.Ad.Controller;
using Core.Gameplay.Managers.Ad.Events;
using Core.Gameplay.Managers.Ad.Model;
using Core.Gameplay.Managers.Ad.Placements.Base.Events;
using Core.Gameplay.Managers.Ad.Placements.Base.Model;
using Core.Gameplay.Managers.Ad.Providers;
using Il2CppDummyDll;
using MVC;

namespace Core.Gameplay.Managers.Ad.Placements.Base.Controller
{
	// Token: 0x0200121D RID: 4637
	[Token(Token = "0x200121D")]
	public abstract class AbstractAdPlacementController<M, E> : AbstractController<M, E> where M : AbstractAdPlacementModel where E : AdPlacementEvents
	{
		// Token: 0x06006DD3 RID: 28115 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006DD3")]
		protected AbstractAdPlacementController(M model, E events, IAdController adController, AdEvents adEvents)
		{
		}

		// Token: 0x06006DD4 RID: 28116 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006DD4")]
		protected override void HandleRun()
		{
		}

		// Token: 0x06006DD5 RID: 28117 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006DD5")]
		private void AdAvailabilityChangedEventHandler(IAdProvider.AdAvailabilityEventData e)
		{
		}

		// Token: 0x06006DD6 RID: 28118 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006DD6")]
		private void AdRewardedEvent(AdTransaction adTransaction)
		{
		}

		// Token: 0x06006DD7 RID: 28119 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006DD7")]
		private void AdPlacementDataChangedEvent(uint placementId)
		{
		}

		// Token: 0x06006DD8 RID: 28120 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006DD8")]
		protected override void HandleStop()
		{
		}

		// Token: 0x0400397A RID: 14714
		[Token(Token = "0x400397A")]
		[FieldOffset(Offset = "0x0")]
		public readonly IAdController AdsController;

		// Token: 0x0400397B RID: 14715
		[Token(Token = "0x400397B")]
		[FieldOffset(Offset = "0x0")]
		private readonly AdEvents _adEvents;
	}
}
