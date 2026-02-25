using System;
using Core.Dict.DictWrappers.Wrappers;
using Il2CppDummyDll;

namespace Gameplay.Aprs.View
{
	// Token: 0x02000D5B RID: 3419
	[Token(Token = "0x2000D5B")]
	public interface IAprView
	{
		// Token: 0x17001106 RID: 4358
		// (get) Token: 0x060053CC RID: 21452
		// (set) Token: 0x060053CD RID: 21453
		[Token(Token = "0x17001106")]
		AprDicWrapper Data { [Token(Token = "0x60053CC")] get; [Token(Token = "0x60053CD")] set; }
	}
}
