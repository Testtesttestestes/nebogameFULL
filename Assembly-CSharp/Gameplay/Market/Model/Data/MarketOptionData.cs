using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Gameplay.Bank.Model;
using Il2CppDummyDll;
using Protocol.Common;

namespace Gameplay.Market.Model.Data
{
	// Token: 0x02000630 RID: 1584
	[Token(Token = "0x2000630")]
	public class MarketOptionData : MarketLotData
	{
		// Token: 0x17000735 RID: 1845
		// (get) Token: 0x06002660 RID: 9824 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002661 RID: 9825 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000735")]
		public override ResourceSet Price
		{
			[Token(Token = "0x6002660")]
			[Address(RVA = "0x7799", Offset = "0x7799", VA = "0x7799", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002661")]
			[Address(RVA = "0x779A", Offset = "0x779A", VA = "0x779A", Slot = "5")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000736 RID: 1846
		// (get) Token: 0x06002662 RID: 9826 RVA: 0x000075D8 File Offset: 0x000057D8
		[Token(Token = "0x17000736")]
		public override MarketLotData.DataType Type
		{
			[Token(Token = "0x6002662")]
			[Address(RVA = "0x779B", Offset = "0x779B", VA = "0x779B", Slot = "6")]
			get
			{
				return MarketLotData.DataType.USER;
			}
		}

		// Token: 0x06002663 RID: 9827 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002663")]
		[Address(RVA = "0x779C", Offset = "0x779C", VA = "0x779C")]
		public MarketOptionData(BankOptionData data, ArtifactData artifact)
		{
		}

		// Token: 0x06002664 RID: 9828 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002664")]
		[Address(RVA = "0x779D", Offset = "0x779D", VA = "0x779D")]
		public void SetPrice(ResourceSet value)
		{
		}

		// Token: 0x06002665 RID: 9829 RVA: 0x000075F0 File Offset: 0x000057F0
		[Token(Token = "0x6002665")]
		[Address(RVA = "0x779E", Offset = "0x779E", VA = "0x779E", Slot = "7")]
		public override bool TryGetExtPrice(out BankOptionData.ExtPriceData extPrice)
		{
			return default(bool);
		}

		// Token: 0x06002666 RID: 9830 RVA: 0x00007608 File Offset: 0x00005808
		[Token(Token = "0x6002666")]
		[Address(RVA = "0x779F", Offset = "0x779F", VA = "0x779F", Slot = "8")]
		public override bool TryGetVipPoints(out int vipPoints)
		{
			return default(bool);
		}

		// Token: 0x04001508 RID: 5384
		[Token(Token = "0x4001508")]
		[FieldOffset(Offset = "0x14")]
		public readonly BankOptionData BankOptionData;
	}
}
