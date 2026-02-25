using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gameplay.Market.Model.Data;
using Il2CppDummyDll;
using Protocol.Dic;
using UI.Filters;

namespace Gameplay.Market.Controller.Filters
{
	// Token: 0x0200063B RID: 1595
	[Token(Token = "0x200063B")]
	internal class MarketSubFilter : IMarketFilter
	{
		// Token: 0x1700073F RID: 1855
		// (get) Token: 0x060026BC RID: 9916 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060026BD RID: 9917 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700073F")]
		public FilterInfo FilterInfo
		{
			[Token(Token = "0x60026BC")]
			[Address(RVA = "0x77F1", Offset = "0x77F1", VA = "0x77F1", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60026BD")]
			[Address(RVA = "0x77F2", Offset = "0x77F2", VA = "0x77F2", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060026BE RID: 9918 RVA: 0x000076E0 File Offset: 0x000058E0
		[Token(Token = "0x60026BE")]
		[Address(RVA = "0x77F3", Offset = "0x77F3", VA = "0x77F3", Slot = "6")]
		public bool Filter(MarketLotData marketLotData)
		{
			return default(bool);
		}

		// Token: 0x060026BF RID: 9919 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026BF")]
		[Address(RVA = "0x77F4", Offset = "0x77F4", VA = "0x77F4", Slot = "7")]
		public void Prepare()
		{
		}

		// Token: 0x060026C0 RID: 9920 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026C0")]
		[Address(RVA = "0x77F5", Offset = "0x77F5", VA = "0x77F5")]
		public MarketSubFilter()
		{
		}

		// Token: 0x04001525 RID: 5413
		[Token(Token = "0x4001525")]
		[FieldOffset(Offset = "0x8")]
		private IList<ArtikulTypeFilters> _filters;
	}
}
