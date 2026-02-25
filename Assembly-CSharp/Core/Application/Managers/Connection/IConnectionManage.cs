using System;
using Il2CppDummyDll;

namespace Core.Application.Managers.Connection
{
	// Token: 0x02001268 RID: 4712
	[Token(Token = "0x2001268")]
	public interface IConnectionManage
	{
		// Token: 0x06006FCE RID: 28622
		[Token(Token = "0x6006FCE")]
		void RunConnect();

		// Token: 0x06006FCF RID: 28623
		[Token(Token = "0x6006FCF")]
		void ReConnect(Action callback);

		// Token: 0x06006FD0 RID: 28624
		[Token(Token = "0x6006FD0")]
		void ReConnect(Uri uri, Action callback);
	}
}
