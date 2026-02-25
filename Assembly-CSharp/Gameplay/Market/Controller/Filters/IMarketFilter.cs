using System;
using Gameplay.Market.Model.Data;
using Il2CppDummyDll;
using UI.Filters;

namespace Gameplay.Market.Controller.Filters
{
	// Token: 0x02000636 RID: 1590
	[Token(Token = "0x2000636")]
	public interface IMarketFilter
	{
		// Token: 0x1700073C RID: 1852
		// (get) Token: 0x060026A8 RID: 9896
		// (set) Token: 0x060026A9 RID: 9897
		[Token(Token = "0x1700073C")]
		FilterInfo FilterInfo { [Token(Token = "0x60026A8")] get; [Token(Token = "0x60026A9")] set; }

		// Token: 0x060026AA RID: 9898
		[Token(Token = "0x60026AA")]
		bool Filter(MarketLotData marketLotData);

		// Token: 0x060026AB RID: 9899
		[Token(Token = "0x60026AB")]
		void Prepare();
	}
}
