using System;
using Core.Gameplay.Managers.Ad.Model;
using Core.Gameplay.Managers.Ad.Providers;
using Il2CppDummyDll;
using MVC;

namespace Core.Gameplay.Managers.Ad.Events
{
	// Token: 0x02001226 RID: 4646
	[Token(Token = "0x2001226")]
	public class AdEvents : AbstractMVCEvents
	{
		// Token: 0x06006DFF RID: 28159 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006DFF")]
		[Address(RVA = "0xB8B5", Offset = "0xB8B5", VA = "0xB8B5")]
		public AdEvents()
		{
		}

		// Token: 0x04003988 RID: 14728
		[Token(Token = "0x4003988")]
		[FieldOffset(Offset = "0x14")]
		public Action<AdTransaction> AdRewardedEvent;

		// Token: 0x04003989 RID: 14729
		[Token(Token = "0x4003989")]
		[FieldOffset(Offset = "0x18")]
		public Action<uint> AdPlacementDataChangedEvent;

		// Token: 0x0400398A RID: 14730
		[Token(Token = "0x400398A")]
		[FieldOffset(Offset = "0x1C")]
		public Action<AdTransaction> TransactionCreatedEvent;

		// Token: 0x0400398B RID: 14731
		[Token(Token = "0x400398B")]
		[FieldOffset(Offset = "0x20")]
		public Action<string> TransactionClosedEvent;

		// Token: 0x0400398C RID: 14732
		[Token(Token = "0x400398C")]
		[FieldOffset(Offset = "0x24")]
		public Action<IAdProvider.AdAvailabilityEventData> AdAvailabilityChangedEvent;
	}
}
