using System;
using System.Threading;
using Gameplay.Portals.Events;
using Gameplay.Portals.Model;
using Gameplay.Portals.View.RatingTab;
using Il2CppDummyDll;
using MVC;
using MVC.Interfaces;

namespace Gameplay.Portals.Controller
{
	// Token: 0x020005DE RID: 1502
	[Token(Token = "0x20005DE")]
	public class PortalsRatingViewMediator : AbstractViewMediator<PortalsRatingModel, PortalsEvents, PortalsRatingController, PortalsRatingView>, IHideableMediator
	{
		// Token: 0x06002443 RID: 9283 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002443")]
		[Address(RVA = "0x7592", Offset = "0x7592", VA = "0x7592", Slot = "14")]
		public override void Dispose()
		{
		}

		// Token: 0x06002444 RID: 9284 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002444")]
		[Address(RVA = "0x7593", Offset = "0x7593", VA = "0x7593", Slot = "21")]
		public void Hide()
		{
		}

		// Token: 0x06002445 RID: 9285 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002445")]
		[Address(RVA = "0x7594", Offset = "0x7594", VA = "0x7594")]
		public PortalsRatingViewMediator(PortalsRatingModel model, PortalsEvents events, PortalsRatingController controller)
		{
		}

		// Token: 0x170006D3 RID: 1747
		// (set) Token: 0x06002446 RID: 9286 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006D3")]
		public override PortalsEvents Events
		{
			[Token(Token = "0x6002446")]
			[Address(RVA = "0x7595", Offset = "0x7595", VA = "0x7595", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x170006D4 RID: 1748
		// (set) Token: 0x06002447 RID: 9287 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006D4")]
		public override PortalsRatingView View
		{
			[Token(Token = "0x6002447")]
			[Address(RVA = "0x7596", Offset = "0x7596", VA = "0x7596", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06002448 RID: 9288 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002448")]
		[Address(RVA = "0x7597", Offset = "0x7597", VA = "0x7597")]
		private void HandleStopRequestEvent()
		{
		}

		// Token: 0x06002449 RID: 9289 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002449")]
		[Address(RVA = "0x7598", Offset = "0x7598", VA = "0x7598")]
		private void HandleStartRequestEvent()
		{
		}

		// Token: 0x0600244A RID: 9290 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600244A")]
		[Address(RVA = "0x7599", Offset = "0x7599", VA = "0x7599")]
		private void HandlePortalRatingReceivedEvent()
		{
		}

		// Token: 0x0600244B RID: 9291 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600244B")]
		[Address(RVA = "0x759A", Offset = "0x759A", VA = "0x759A")]
		private void SetupView()
		{
		}

		// Token: 0x0600244C RID: 9292 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600244C")]
		[Address(RVA = "0x759B", Offset = "0x759B", VA = "0x759B")]
		private void ShowRating()
		{
		}

		// Token: 0x0600244D RID: 9293 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600244D")]
		[Address(RVA = "0x759C", Offset = "0x759C", VA = "0x759C")]
		private void UpdateOSAView()
		{
		}

		// Token: 0x0600244E RID: 9294 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600244E")]
		[Address(RVA = "0x759D", Offset = "0x759D", VA = "0x759D")]
		private void UpdateMyRatingView()
		{
		}

		// Token: 0x0600244F RID: 9295 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600244F")]
		[Address(RVA = "0x759E", Offset = "0x759E", VA = "0x759E")]
		private static void CancelAwaitReceivingData(ref CancellationTokenSource cts)
		{
		}

		// Token: 0x06002450 RID: 9296 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002450")]
		[Address(RVA = "0x759F", Offset = "0x759F", VA = "0x759F")]
		private void ShowAwaitReceivingData(int delay, CancellationTokenSource cts)
		{
		}

		// Token: 0x040013F5 RID: 5109
		[Token(Token = "0x40013F5")]
		[FieldOffset(Offset = "0x18")]
		private CancellationTokenSource _cancelReceivingDataTs;
	}
}
