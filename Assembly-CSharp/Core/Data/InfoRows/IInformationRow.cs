using System;
using Il2CppDummyDll;

namespace Core.Data.InfoRows
{
	// Token: 0x020010DE RID: 4318
	[Token(Token = "0x20010DE")]
	public interface IInformationRow
	{
		// Token: 0x17001477 RID: 5239
		// (get) Token: 0x06006518 RID: 25880
		[Token(Token = "0x17001477")]
		InformationRowTypes Type { [Token(Token = "0x6006518")] get; }

		// Token: 0x17001478 RID: 5240
		// (get) Token: 0x06006519 RID: 25881
		// (set) Token: 0x0600651A RID: 25882
		[Token(Token = "0x17001478")]
		string Title { [Token(Token = "0x6006519")] get; [Token(Token = "0x600651A")] set; }
	}
}
