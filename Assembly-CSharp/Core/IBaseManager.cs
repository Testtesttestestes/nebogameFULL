using System;
using Il2CppDummyDll;

namespace Core
{
	// Token: 0x02000E5B RID: 3675
	[Token(Token = "0x2000E5B")]
	public interface IBaseManager
	{
		// Token: 0x1400021F RID: 543
		// (add) Token: 0x060059EE RID: 23022
		// (remove) Token: 0x060059EF RID: 23023
		[Token(Token = "0x1400021F")]
		event Action<IBaseManager> InitCompleteEvent;

		// Token: 0x14000220 RID: 544
		// (add) Token: 0x060059F0 RID: 23024
		// (remove) Token: 0x060059F1 RID: 23025
		[Token(Token = "0x14000220")]
		event Action<IBaseManager> DeinitCompleteEvent;

		// Token: 0x060059F2 RID: 23026
		[Token(Token = "0x60059F2")]
		void Init();

		// Token: 0x060059F3 RID: 23027
		[Token(Token = "0x60059F3")]
		void Deinit();

		// Token: 0x1700124E RID: 4686
		// (get) Token: 0x060059F4 RID: 23028
		[Token(Token = "0x1700124E")]
		string Name { [Token(Token = "0x60059F4")] get; }
	}
}
