using System;
using Il2CppDummyDll;

namespace Core.Application.Managers.Configuration.Curator
{
	// Token: 0x02001275 RID: 4725
	[Token(Token = "0x2001275")]
	public interface ICuratorDataProvider
	{
		// Token: 0x140002F8 RID: 760
		// (add) Token: 0x0600701A RID: 28698
		// (remove) Token: 0x0600701B RID: 28699
		[Token(Token = "0x140002F8")]
		event Action<ICuratorDataProvider> CompleteEvent;

		// Token: 0x170016E0 RID: 5856
		// (get) Token: 0x0600701C RID: 28700
		// (set) Token: 0x0600701D RID: 28701
		[Token(Token = "0x170016E0")]
		CuratorData Data { [Token(Token = "0x600701C")] get; [Token(Token = "0x600701D")] set; }

		// Token: 0x0600701E RID: 28702
		[Token(Token = "0x600701E")]
		void Commit();

		// Token: 0x0600701F RID: 28703
		[Token(Token = "0x600701F")]
		string GetUserId(ulong userId);
	}
}
