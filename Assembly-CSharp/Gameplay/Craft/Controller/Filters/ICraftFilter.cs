using System;
using Core.Data;
using Il2CppDummyDll;
using UI.Filters;

namespace Gameplay.Craft.Controller.Filters
{
	// Token: 0x020008D6 RID: 2262
	[Token(Token = "0x20008D6")]
	public interface ICraftFilter
	{
		// Token: 0x17000A81 RID: 2689
		// (get) Token: 0x06003548 RID: 13640
		// (set) Token: 0x06003549 RID: 13641
		[Token(Token = "0x17000A81")]
		FilterInfo FilterInfo { [Token(Token = "0x6003548")] get; [Token(Token = "0x6003549")] set; }

		// Token: 0x0600354A RID: 13642
		[Token(Token = "0x600354A")]
		bool Filter(CraftSchemeData craftSchemeData);
	}
}
