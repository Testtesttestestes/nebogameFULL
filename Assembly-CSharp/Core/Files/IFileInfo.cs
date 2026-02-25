using System;
using Il2CppDummyDll;

namespace Core.Files
{
	// Token: 0x02000EF6 RID: 3830
	[Token(Token = "0x2000EF6")]
	public interface IFileInfo
	{
		// Token: 0x170012C2 RID: 4802
		// (get) Token: 0x06005CE4 RID: 23780
		[Token(Token = "0x170012C2")]
		string Path { [Token(Token = "0x6005CE4")] get; }

		// Token: 0x170012C3 RID: 4803
		// (get) Token: 0x06005CE5 RID: 23781
		[Token(Token = "0x170012C3")]
		bool CacheOnDevice { [Token(Token = "0x6005CE5")] get; }

		// Token: 0x06005CE6 RID: 23782
		[Token(Token = "0x6005CE6")]
		bool TryGetResponseHeader(string key, out string value);
	}
}
