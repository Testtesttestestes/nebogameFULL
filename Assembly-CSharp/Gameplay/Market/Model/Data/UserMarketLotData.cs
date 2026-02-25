using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Gameplay.Bank.Model;
using Il2CppDummyDll;
using Protocol.Common;

namespace Gameplay.Market.Model.Data
{
	// Token: 0x02000631 RID: 1585
	[Token(Token = "0x2000631")]
	public class UserMarketLotData : MarketLotData
	{
		// Token: 0x06002667 RID: 9831 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002667")]
		[Address(RVA = "0x77A0", Offset = "0x77A0", VA = "0x77A0")]
		public UserMarketLotData(ArtifactData artifact, ResourceSet price)
		{
		}

		// Token: 0x17000737 RID: 1847
		// (get) Token: 0x06002668 RID: 9832 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002669 RID: 9833 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000737")]
		public override ResourceSet Price
		{
			[Token(Token = "0x6002668")]
			[Address(RVA = "0x77A1", Offset = "0x77A1", VA = "0x77A1", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002669")]
			[Address(RVA = "0x77A2", Offset = "0x77A2", VA = "0x77A2", Slot = "5")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000738 RID: 1848
		// (get) Token: 0x0600266A RID: 9834 RVA: 0x00007620 File Offset: 0x00005820
		[Token(Token = "0x17000738")]
		public override MarketLotData.DataType Type
		{
			[Token(Token = "0x600266A")]
			[Address(RVA = "0x77A3", Offset = "0x77A3", VA = "0x77A3", Slot = "6")]
			get
			{
				return MarketLotData.DataType.USER;
			}
		}

		// Token: 0x0600266B RID: 9835 RVA: 0x00007638 File Offset: 0x00005838
		[Token(Token = "0x600266B")]
		[Address(RVA = "0x77A4", Offset = "0x77A4", VA = "0x77A4", Slot = "7")]
		public override bool TryGetExtPrice(out BankOptionData.ExtPriceData extPrice)
		{
			return default(bool);
		}

		// Token: 0x0600266C RID: 9836 RVA: 0x00007650 File Offset: 0x00005850
		[Token(Token = "0x600266C")]
		[Address(RVA = "0x77A5", Offset = "0x77A5", VA = "0x77A5", Slot = "8")]
		public override bool TryGetVipPoints(out int vipPoints)
		{
			return default(bool);
		}
	}
}
