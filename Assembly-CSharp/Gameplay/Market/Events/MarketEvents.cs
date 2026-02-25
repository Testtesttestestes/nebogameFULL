using System;
using System.Collections.Generic;
using Gameplay.Market.View;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Market.Events
{
	// Token: 0x02000632 RID: 1586
	[Token(Token = "0x2000632")]
	public class MarketEvents : AbstractMVCEvents
	{
		// Token: 0x0600266D RID: 9837 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600266D")]
		[Address(RVA = "0x77A6", Offset = "0x77A6", VA = "0x77A6")]
		public MarketEvents()
		{
		}

		// Token: 0x0400150B RID: 5387
		[Token(Token = "0x400150B")]
		[FieldOffset(Offset = "0x14")]
		public Action MarketArtifactsRequestedEvent;

		// Token: 0x0400150C RID: 5388
		[Token(Token = "0x400150C")]
		[FieldOffset(Offset = "0x18")]
		public Action ExtraArtifactsRequestedEvent;

		// Token: 0x0400150D RID: 5389
		[Token(Token = "0x400150D")]
		[FieldOffset(Offset = "0x1C")]
		public Action MarketLotsChangedEvent;

		// Token: 0x0400150E RID: 5390
		[Token(Token = "0x400150E")]
		[FieldOffset(Offset = "0x20")]
		public Action<IEnumerable<MarketLotListElement.MarketLotListElementArgs>, IEnumerable<MarketLotListElement.MarketLotListElementArgs>> ArtifactsListChangedEvent;
	}
}
