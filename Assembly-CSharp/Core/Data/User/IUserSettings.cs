using System;
using Il2CppDummyDll;

namespace Core.Data.User
{
	// Token: 0x020010C6 RID: 4294
	[Token(Token = "0x20010C6")]
	public interface IUserSettings
	{
		// Token: 0x17001453 RID: 5203
		// (get) Token: 0x0600649A RID: 25754
		[Token(Token = "0x17001453")]
		UserSettings Settings { [Token(Token = "0x600649A")] get; }

		// Token: 0x0600649B RID: 25755
		[Token(Token = "0x600649B")]
		void CommitSettings();
	}
}
