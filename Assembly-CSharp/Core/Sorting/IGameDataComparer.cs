using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Core.Sorting
{
	// Token: 0x02000E73 RID: 3699
	[Token(Token = "0x2000E73")]
	public interface IGameDataComparer<in T> : IComparer<T>
	{
		// Token: 0x1700125B RID: 4699
		// (get) Token: 0x06005A24 RID: 23076
		[Token(Token = "0x1700125B")]
		string Title { [Token(Token = "0x6005A24")] get; }

		// Token: 0x1700125C RID: 4700
		// (get) Token: 0x06005A25 RID: 23077
		// (set) Token: 0x06005A26 RID: 23078
		[Token(Token = "0x1700125C")]
		bool IsDescending { [Token(Token = "0x6005A25")] get; [Token(Token = "0x6005A26")] set; }
	}
}
