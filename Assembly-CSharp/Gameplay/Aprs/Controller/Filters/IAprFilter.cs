using System;
using Gameplay.Aprs.Model;
using Il2CppDummyDll;
using UI.Filters;

namespace Gameplay.Aprs.Controller.Filters
{
	// Token: 0x02000D7A RID: 3450
	[Token(Token = "0x2000D7A")]
	public interface IAprFilter
	{
		// Token: 0x1700112F RID: 4399
		// (get) Token: 0x0600548A RID: 21642
		// (set) Token: 0x0600548B RID: 21643
		[Token(Token = "0x1700112F")]
		FilterInfo FilterInfo { [Token(Token = "0x600548A")] get; [Token(Token = "0x600548B")] set; }

		// Token: 0x0600548C RID: 21644
		[Token(Token = "0x600548C")]
		bool Filter(AprData aprData);
	}
}
