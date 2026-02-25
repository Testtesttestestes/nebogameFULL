using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Core.Data.InfoRows
{
	// Token: 0x020010DD RID: 4317
	[Token(Token = "0x20010DD")]
	public interface IInformationProvider : IDisposable
	{
		// Token: 0x17001476 RID: 5238
		// (get) Token: 0x06006516 RID: 25878
		[Token(Token = "0x17001476")]
		UserData LoggedUser { [Token(Token = "0x6006516")] get; }

		// Token: 0x06006517 RID: 25879
		[Token(Token = "0x6006517")]
		List<IInformationRow> GetRows();
	}
}
