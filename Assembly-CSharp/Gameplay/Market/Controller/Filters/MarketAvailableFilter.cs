using System;
using System.Runtime.CompilerServices;
using Gameplay.Market.Model.Data;
using Il2CppDummyDll;
using UI.Filters;

namespace Gameplay.Market.Controller.Filters
{
	// Token: 0x02000637 RID: 1591
	[Token(Token = "0x2000637")]
	public class MarketAvailableFilter : IMarketFilter
	{
		// Token: 0x1700073D RID: 1853
		// (get) Token: 0x060026AC RID: 9900 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060026AD RID: 9901 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700073D")]
		public FilterInfo FilterInfo
		{
			[Token(Token = "0x60026AC")]
			[Address(RVA = "0x77E1", Offset = "0x77E1", VA = "0x77E1", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60026AD")]
			[Address(RVA = "0x77E2", Offset = "0x77E2", VA = "0x77E2", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060026AE RID: 9902 RVA: 0x00007698 File Offset: 0x00005898
		[Token(Token = "0x60026AE")]
		[Address(RVA = "0x77E3", Offset = "0x77E3", VA = "0x77E3", Slot = "6")]
		public bool Filter(MarketLotData marketLotData)
		{
			return default(bool);
		}

		// Token: 0x060026AF RID: 9903 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026AF")]
		[Address(RVA = "0x77E4", Offset = "0x77E4", VA = "0x77E4", Slot = "7")]
		public void Prepare()
		{
		}

		// Token: 0x060026B0 RID: 9904 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026B0")]
		[Address(RVA = "0x77E5", Offset = "0x77E5", VA = "0x77E5")]
		public MarketAvailableFilter()
		{
		}

		// Token: 0x0400151D RID: 5405
		[Token(Token = "0x400151D")]
		[FieldOffset(Offset = "0x8")]
		private uint _userLevel;
	}
}
