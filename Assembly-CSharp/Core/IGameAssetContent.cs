using System;
using Il2CppDummyDll;

namespace Core
{
	// Token: 0x02000E5C RID: 3676
	[Token(Token = "0x2000E5C")]
	public interface IGameAssetContent
	{
		// Token: 0x1700124F RID: 4687
		// (get) Token: 0x060059F5 RID: 23029
		// (set) Token: 0x060059F6 RID: 23030
		[Token(Token = "0x1700124F")]
		string AssetId { [Token(Token = "0x60059F5")] get; [Token(Token = "0x60059F6")] set; }

		// Token: 0x17001250 RID: 4688
		// (get) Token: 0x060059F7 RID: 23031
		[Token(Token = "0x17001250")]
		string AssetPath { [Token(Token = "0x60059F7")] get; }
	}
}
