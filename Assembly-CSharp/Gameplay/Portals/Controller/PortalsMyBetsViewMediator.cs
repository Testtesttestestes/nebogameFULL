using System;
using Gameplay.Portals.Events;
using Gameplay.Portals.Model;
using Gameplay.Portals.View.MyBetsTab;
using Il2CppDummyDll;
using MVC;
using MVC.Interfaces;

namespace Gameplay.Portals.Controller
{
	// Token: 0x020005DC RID: 1500
	[Token(Token = "0x20005DC")]
	public class PortalsMyBetsViewMediator : AbstractViewMediator<PortalsMyBetsModel, PortalsEvents, PortalsMyBetsController, PortalsMyBetsView>, IHideableMediator
	{
		// Token: 0x06002431 RID: 9265 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002431")]
		[Address(RVA = "0x7580", Offset = "0x7580", VA = "0x7580")]
		public PortalsMyBetsViewMediator(PortalsMyBetsModel model, PortalsEvents events, PortalsMyBetsController controller)
		{
		}

		// Token: 0x170006D1 RID: 1745
		// (set) Token: 0x06002432 RID: 9266 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006D1")]
		public override PortalsEvents Events
		{
			[Token(Token = "0x6002432")]
			[Address(RVA = "0x7581", Offset = "0x7581", VA = "0x7581", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x170006D2 RID: 1746
		// (set) Token: 0x06002433 RID: 9267 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006D2")]
		public override PortalsMyBetsView View
		{
			[Token(Token = "0x6002433")]
			[Address(RVA = "0x7582", Offset = "0x7582", VA = "0x7582", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06002434 RID: 9268 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002434")]
		[Address(RVA = "0x7583", Offset = "0x7583", VA = "0x7583", Slot = "21")]
		public void Hide()
		{
		}

		// Token: 0x06002435 RID: 9269 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002435")]
		[Address(RVA = "0x7584", Offset = "0x7584", VA = "0x7584", Slot = "14")]
		public override void Dispose()
		{
		}

		// Token: 0x06002436 RID: 9270 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002436")]
		[Address(RVA = "0x7585", Offset = "0x7585", VA = "0x7585")]
		private void Unsubscribe()
		{
		}

		// Token: 0x06002437 RID: 9271 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002437")]
		[Address(RVA = "0x7586", Offset = "0x7586", VA = "0x7586")]
		private void Init()
		{
		}

		// Token: 0x06002438 RID: 9272 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002438")]
		[Address(RVA = "0x7587", Offset = "0x7587", VA = "0x7587")]
		private void RequestHistory()
		{
		}

		// Token: 0x06002439 RID: 9273 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002439")]
		[Address(RVA = "0x7588", Offset = "0x7588", VA = "0x7588")]
		private void ShowHistory()
		{
		}

		// Token: 0x0600243A RID: 9274 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600243A")]
		[Address(RVA = "0x7589", Offset = "0x7589", VA = "0x7589")]
		private void UpdateHistoryList()
		{
		}

		// Token: 0x0600243B RID: 9275 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600243B")]
		[Address(RVA = "0x758A", Offset = "0x758A", VA = "0x758A")]
		private void HandleClick(ulong betId)
		{
		}

		// Token: 0x0600243C RID: 9276 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600243C")]
		[Address(RVA = "0x758B", Offset = "0x758B", VA = "0x758B")]
		private void ShowBets()
		{
		}

		// Token: 0x0600243D RID: 9277 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600243D")]
		[Address(RVA = "0x758C", Offset = "0x758C", VA = "0x758C")]
		private void UpdateOSAView()
		{
		}

		// Token: 0x0600243E RID: 9278 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600243E")]
		[Address(RVA = "0x758D", Offset = "0x758D", VA = "0x758D")]
		private void AllBetsButtonClickHandler()
		{
		}
	}
}
