using System;
using System.Collections.Generic;
using Gameplay.Portals.Events;
using Gameplay.Portals.Model;
using Google.Protobuf;
using Il2CppDummyDll;
using MVC;
using Protocol.Portal;
using ServicesNamespace;
using Utils;

namespace Gameplay.Portals.Controller
{
	// Token: 0x020005E3 RID: 1507
	[Token(Token = "0x20005E3")]
	public class PortalsTotalizatorController : AbstractController<PortalsTotalizatorModel, PortalsEvents>
	{
		// Token: 0x06002465 RID: 9317 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002465")]
		[Address(RVA = "0x75B3", Offset = "0x75B3", VA = "0x75B3")]
		public PortalsTotalizatorController(PortalsTotalizatorModel model, PortalsEvents events, PortalsService portalsService)
		{
		}

		// Token: 0x06002466 RID: 9318 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002466")]
		[Address(RVA = "0x75B4", Offset = "0x75B4", VA = "0x75B4")]
		public void BetRestrictedHandler()
		{
		}

		// Token: 0x06002467 RID: 9319 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002467")]
		[Address(RVA = "0x75B5", Offset = "0x75B5", VA = "0x75B5")]
		public void ParticipantsForBetNotAvailHandler()
		{
		}

		// Token: 0x06002468 RID: 9320 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002468")]
		[Address(RVA = "0x75B6", Offset = "0x75B6", VA = "0x75B6")]
		public void GetBetList()
		{
		}

		// Token: 0x06002469 RID: 9321 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002469")]
		[Address(RVA = "0x75B7", Offset = "0x75B7", VA = "0x75B7")]
		private void OnGetBetList(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x0600246A RID: 9322 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600246A")]
		[Address(RVA = "0x75B8", Offset = "0x75B8", VA = "0x75B8")]
		public void UpdateBetList()
		{
		}

		// Token: 0x0600246B RID: 9323 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600246B")]
		[Address(RVA = "0x75B9", Offset = "0x75B9", VA = "0x75B9")]
		private void OnUpdateBetList(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x0600246C RID: 9324 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600246C")]
		[Address(RVA = "0x75BA", Offset = "0x75BA", VA = "0x75BA")]
		private void UpdateModel(BetList list)
		{
		}

		// Token: 0x0600246D RID: 9325 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600246D")]
		[Address(RVA = "0x75BB", Offset = "0x75BB", VA = "0x75BB")]
		public void DoBet(IEnumerable<ProtoDoBetCmd.Types.BetChoice> bet)
		{
		}

		// Token: 0x0600246E RID: 9326 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600246E")]
		[Address(RVA = "0x75BC", Offset = "0x75BC", VA = "0x75BC")]
		private void DoBetHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x04001401 RID: 5121
		[Token(Token = "0x4001401")]
		[FieldOffset(Offset = "0x18")]
		private PortalsService _portalsService;
	}
}
