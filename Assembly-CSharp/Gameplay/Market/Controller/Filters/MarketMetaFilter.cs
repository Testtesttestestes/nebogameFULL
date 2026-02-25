using System;
using System.Runtime.CompilerServices;
using Gameplay.Market.Model.Data;
using Il2CppDummyDll;
using Protocol.Dic;
using UI.Filters;

namespace Gameplay.Market.Controller.Filters
{
	// Token: 0x02000638 RID: 1592
	[Token(Token = "0x2000638")]
	public class MarketMetaFilter : IMarketFilter
	{
		// Token: 0x1700073E RID: 1854
		// (get) Token: 0x060026B1 RID: 9905 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060026B2 RID: 9906 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700073E")]
		public FilterInfo FilterInfo
		{
			[Token(Token = "0x60026B1")]
			[Address(RVA = "0x77E6", Offset = "0x77E6", VA = "0x77E6", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60026B2")]
			[Address(RVA = "0x77E7", Offset = "0x77E7", VA = "0x77E7", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060026B3 RID: 9907 RVA: 0x000076B0 File Offset: 0x000058B0
		[Token(Token = "0x60026B3")]
		[Address(RVA = "0x77E8", Offset = "0x77E8", VA = "0x77E8", Slot = "6")]
		public bool Filter(MarketLotData marketLotData)
		{
			return default(bool);
		}

		// Token: 0x060026B4 RID: 9908 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026B4")]
		[Address(RVA = "0x77E9", Offset = "0x77E9", VA = "0x77E9", Slot = "7")]
		public void Prepare()
		{
		}

		// Token: 0x060026B5 RID: 9909 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026B5")]
		[Address(RVA = "0x77EA", Offset = "0x77EA", VA = "0x77EA")]
		public MarketMetaFilter()
		{
		}

		// Token: 0x0400151F RID: 5407
		[Token(Token = "0x400151F")]
		[FieldOffset(Offset = "0x8")]
		private ArtikulTypeFilters[] _filters;
	}
}
