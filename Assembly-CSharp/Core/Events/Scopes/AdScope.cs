using System;
using Core.Application;
using Core.Gameplay;
using Core.Gameplay.Managers.Ad.Model;
using Core.Gameplay.Managers.Ad.Providers;
using Core.Gameplay.Managers.Ad.Statistics;
using Il2CppDummyDll;
using Protocol.Services;

namespace Core.Events.Scopes
{
	// Token: 0x02000FBA RID: 4026
	[Token(Token = "0x2000FBA")]
	public class AdScope : AbstractEventBusScope
	{
		// Token: 0x0600607C RID: 24700 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600607C")]
		[Address(RVA = "0xACA8", Offset = "0xACA8", VA = "0xACA8", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x0600607D RID: 24701 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600607D")]
		[Address(RVA = "0xACA9", Offset = "0xACA9", VA = "0xACA9")]
		public AdScope()
		{
		}

		// Token: 0x04003364 RID: 13156
		[Token(Token = "0x4003364")]
		[FieldOffset(Offset = "0x8")]
		public Action<AdScope.AdPlacementEventArgs> AdPlacementShownEvent;

		// Token: 0x04003365 RID: 13157
		[Token(Token = "0x4003365")]
		[FieldOffset(Offset = "0xC")]
		public Action<AdScope.AdEventArgs> AdAppRequestEvent;

		// Token: 0x04003366 RID: 13158
		[Token(Token = "0x4003366")]
		[FieldOffset(Offset = "0x10")]
		public Action<AdScope.AdEventArgs> AdProviderRequestEvent;

		// Token: 0x04003367 RID: 13159
		[Token(Token = "0x4003367")]
		[FieldOffset(Offset = "0x14")]
		public Action<AdScope.AdEventArgs> AdWatchedEvent;

		// Token: 0x04003368 RID: 13160
		[Token(Token = "0x4003368")]
		[FieldOffset(Offset = "0x18")]
		public Action<AdScope.AdErrorEventArgs> AdErrorEvent;

		// Token: 0x04003369 RID: 13161
		[Token(Token = "0x4003369")]
		[FieldOffset(Offset = "0x1C")]
		public Action<AdScope.AdTransactionInfoEventArgs> AdTransactionClosedEvent;

		// Token: 0x02000FBB RID: 4027
		[Token(Token = "0x2000FBB")]
		public class AdPlacementEventArgs : BaseEventBusEventArgs
		{
			// Token: 0x0600607E RID: 24702 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600607E")]
			[Address(RVA = "0xACAA", Offset = "0xACAA", VA = "0xACAA")]
			public AdPlacementEventArgs(IApp app, IGame game, AdPlacement adPlacement, uint optionId = 0U)
			{
			}

			// Token: 0x0400336A RID: 13162
			[Token(Token = "0x400336A")]
			[FieldOffset(Offset = "0x10")]
			public readonly AdPlacement AdPlacement;

			// Token: 0x0400336B RID: 13163
			[Token(Token = "0x400336B")]
			[FieldOffset(Offset = "0x14")]
			public readonly uint OptionId;
		}

		// Token: 0x02000FBC RID: 4028
		[Token(Token = "0x2000FBC")]
		public class AdEventArgs : BaseEventBusEventArgs
		{
			// Token: 0x0600607F RID: 24703 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600607F")]
			[Address(RVA = "0xACAB", Offset = "0xACAB", VA = "0xACAB")]
			public AdEventArgs(IApp app, IGame game, AdTransaction adTransaction)
			{
			}

			// Token: 0x0400336C RID: 13164
			[Token(Token = "0x400336C")]
			[FieldOffset(Offset = "0x10")]
			public readonly AdTransaction AdTransaction;
		}

		// Token: 0x02000FBD RID: 4029
		[Token(Token = "0x2000FBD")]
		public class AdErrorEventArgs : AdScope.AdEventArgs
		{
			// Token: 0x06006080 RID: 24704 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006080")]
			[Address(RVA = "0xACAC", Offset = "0xACAC", VA = "0xACAC")]
			public AdErrorEventArgs(IApp app, IGame game, AdTransaction adTransaction, IAdProvider.AdErrorEventData errorData)
			{
			}

			// Token: 0x0400336D RID: 13165
			[Token(Token = "0x400336D")]
			[FieldOffset(Offset = "0x14")]
			public readonly IAdProvider.AdErrorEventData ErrorData;
		}

		// Token: 0x02000FBE RID: 4030
		[Token(Token = "0x2000FBE")]
		public class AdTransactionInfoEventArgs : BaseEventBusEventArgs
		{
			// Token: 0x06006081 RID: 24705 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006081")]
			[Address(RVA = "0xACAD", Offset = "0xACAD", VA = "0xACAD")]
			public AdTransactionInfoEventArgs(IApp app, IGame game, AdTransactionStatisticsInfo info)
			{
			}

			// Token: 0x0400336E RID: 13166
			[Token(Token = "0x400336E")]
			[FieldOffset(Offset = "0x10")]
			public readonly AdTransactionStatisticsInfo Info;
		}
	}
}
