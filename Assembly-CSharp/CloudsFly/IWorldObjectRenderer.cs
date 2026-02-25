using System;
using Il2CppDummyDll;

namespace CloudsFly
{
	// Token: 0x02001303 RID: 4867
	[Token(Token = "0x2001303")]
	public interface IWorldObjectRenderer
	{
		// Token: 0x1700175D RID: 5981
		// (get) Token: 0x060073CF RID: 29647
		// (set) Token: 0x060073D0 RID: 29648
		[Token(Token = "0x1700175D")]
		int SortingOrder { [Token(Token = "0x60073CF")] get; [Token(Token = "0x60073D0")] set; }

		// Token: 0x1700175E RID: 5982
		// (get) Token: 0x060073D1 RID: 29649
		// (set) Token: 0x060073D2 RID: 29650
		[Token(Token = "0x1700175E")]
		int SortingLayerId { [Token(Token = "0x60073D1")] get; [Token(Token = "0x60073D2")] set; }
	}
}
