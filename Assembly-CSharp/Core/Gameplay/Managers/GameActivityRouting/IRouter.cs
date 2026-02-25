using System;
using Core.Rounting;
using Il2CppDummyDll;

namespace Core.Gameplay.Managers.GameActivityRouting
{
	// Token: 0x020011C6 RID: 4550
	[Token(Token = "0x20011C6")]
	public interface IRouter
	{
		// Token: 0x17001626 RID: 5670
		// (get) Token: 0x06006C69 RID: 27753
		[Token(Token = "0x17001626")]
		ILocatorRepository LocatorRepository { [Token(Token = "0x6006C69")] get; }
	}
}
