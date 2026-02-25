using System;
using System.Runtime.CompilerServices;
using Gameplay.Market.Model.Data;
using Il2CppDummyDll;
using UI.Filters;

namespace Gameplay.Market.Controller.Filters
{
	// Token: 0x0200063D RID: 1597
	[Token(Token = "0x200063D")]
	public class MarketTitleFilter : IMarketFilter
	{
		// Token: 0x17000740 RID: 1856
		// (get) Token: 0x060026C4 RID: 9924 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060026C5 RID: 9925 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000740")]
		public FilterInfo FilterInfo
		{
			[Token(Token = "0x60026C4")]
			[Address(RVA = "0x77F9", Offset = "0x77F9", VA = "0x77F9", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60026C5")]
			[Address(RVA = "0x77FA", Offset = "0x77FA", VA = "0x77FA", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060026C6 RID: 9926 RVA: 0x00007710 File Offset: 0x00005910
		[Token(Token = "0x60026C6")]
		[Address(RVA = "0x77FB", Offset = "0x77FB", VA = "0x77FB", Slot = "6")]
		public bool Filter(MarketLotData marketLotData)
		{
			return default(bool);
		}

		// Token: 0x060026C7 RID: 9927 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026C7")]
		[Address(RVA = "0x77FC", Offset = "0x77FC", VA = "0x77FC", Slot = "7")]
		public void Prepare()
		{
		}

		// Token: 0x060026C8 RID: 9928 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026C8")]
		[Address(RVA = "0x77FD", Offset = "0x77FD", VA = "0x77FD")]
		public MarketTitleFilter()
		{
		}

		// Token: 0x04001529 RID: 5417
		[Token(Token = "0x4001529")]
		[FieldOffset(Offset = "0x8")]
		private string _value;
	}
}
