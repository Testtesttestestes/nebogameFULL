using System;
using Il2CppDummyDll;
using Protocol.System;

namespace Core.Application.Managers.Connection
{
	// Token: 0x0200126B RID: 4715
	[Token(Token = "0x200126B")]
	public interface ISystemDisconnectResolver
	{
		// Token: 0x170016D6 RID: 5846
		// (get) Token: 0x06006FDB RID: 28635
		// (set) Token: 0x06006FDC RID: 28636
		[Token(Token = "0x170016D6")]
		DisconnectCode? Code { [Token(Token = "0x6006FDB")] get; [Token(Token = "0x6006FDC")] set; }

		// Token: 0x06006FDD RID: 28637
		[Token(Token = "0x6006FDD")]
		void Resolve(IConnectionManage connection);

		// Token: 0x06006FDE RID: 28638
		[Token(Token = "0x6006FDE")]
		bool TryNotify();
	}
}
