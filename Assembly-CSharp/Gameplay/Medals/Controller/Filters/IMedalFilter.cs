using System;
using Core.Data;
using Il2CppDummyDll;
using UI.Filters;

namespace Gameplay.Medals.Controller.Filters
{
	// Token: 0x0200060F RID: 1551
	[Token(Token = "0x200060F")]
	public interface IMedalFilter
	{
		// Token: 0x17000714 RID: 1812
		// (get) Token: 0x060025B6 RID: 9654
		// (set) Token: 0x060025B7 RID: 9655
		[Token(Token = "0x17000714")]
		FilterInfo FilterInfo { [Token(Token = "0x60025B6")] get; [Token(Token = "0x60025B7")] set; }

		// Token: 0x060025B8 RID: 9656
		[Token(Token = "0x60025B8")]
		bool Filter(MedalData medalData);
	}
}
