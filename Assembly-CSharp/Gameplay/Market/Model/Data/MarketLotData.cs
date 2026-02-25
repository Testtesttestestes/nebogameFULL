using System;
using Core.Data;
using Gameplay.Bank.Model;
using Il2CppDummyDll;
using Protocol.Common;
using Utils;

namespace Gameplay.Market.Model.Data
{
	// Token: 0x0200062E RID: 1582
	[Token(Token = "0x200062E")]
	public abstract class MarketLotData
	{
		// Token: 0x0600265A RID: 9818 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600265A")]
		[Address(RVA = "0x7798", Offset = "0x7798", VA = "0x7798")]
		protected MarketLotData(ArtifactData artifact)
		{
		}

		// Token: 0x17000733 RID: 1843
		// (get) Token: 0x0600265B RID: 9819
		// (set) Token: 0x0600265C RID: 9820
		[Token(Token = "0x17000733")]
		public abstract ResourceSet Price { [Token(Token = "0x600265B")] get; [Token(Token = "0x600265C")] protected set; }

		// Token: 0x17000734 RID: 1844
		// (get) Token: 0x0600265D RID: 9821
		[Token(Token = "0x17000734")]
		public abstract MarketLotData.DataType Type { [Token(Token = "0x600265D")] get; }

		// Token: 0x0600265E RID: 9822
		[Token(Token = "0x600265E")]
		public abstract bool TryGetExtPrice(out BankOptionData.ExtPriceData extPrice);

		// Token: 0x0600265F RID: 9823
		[Token(Token = "0x600265F")]
		public abstract bool TryGetVipPoints(out int vipPoints);

		// Token: 0x04001501 RID: 5377
		[Token(Token = "0x4001501")]
		[FieldOffset(Offset = "0x8")]
		public readonly ArtifactData Artifact;

		// Token: 0x04001502 RID: 5378
		[Token(Token = "0x4001502")]
		[FieldOffset(Offset = "0xC")]
		public BackTime BackTime;

		// Token: 0x04001503 RID: 5379
		[Token(Token = "0x4001503")]
		[FieldOffset(Offset = "0x10")]
		public string StickerAssetId;

		// Token: 0x0200062F RID: 1583
		[Token(Token = "0x200062F")]
		public enum DataType
		{
			// Token: 0x04001505 RID: 5381
			[Token(Token = "0x4001505")]
			UNKNOWN = -1,
			// Token: 0x04001506 RID: 5382
			[Token(Token = "0x4001506")]
			USER,
			// Token: 0x04001507 RID: 5383
			[Token(Token = "0x4001507")]
			OPTION
		}
	}
}
