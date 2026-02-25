using System;
using Il2CppDummyDll;

namespace Core.Files
{
	// Token: 0x02000EF5 RID: 3829
	[Token(Token = "0x2000EF5")]
	public interface IFileContent
	{
		// Token: 0x170012C1 RID: 4801
		// (get) Token: 0x06005CE2 RID: 23778
		[Token(Token = "0x170012C1")]
		IFileInfo FileInfo { [Token(Token = "0x6005CE2")] get; }

		// Token: 0x06005CE3 RID: 23779
		[Token(Token = "0x6005CE3")]
		bool TryGetContent(out byte[] bytes);
	}
}
