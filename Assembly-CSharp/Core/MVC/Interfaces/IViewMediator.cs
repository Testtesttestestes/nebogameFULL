using System;
using Il2CppDummyDll;

namespace Core.MVC.Interfaces
{
	// Token: 0x02000EC5 RID: 3781
	[Token(Token = "0x2000EC5")]
	public interface IViewMediator<TView> : IViewMediator
	{
		// Token: 0x170012B0 RID: 4784
		// (get) Token: 0x06005C16 RID: 23574
		// (set) Token: 0x06005C17 RID: 23575
		[Token(Token = "0x170012B0")]
		TView View { [Token(Token = "0x6005C16")] get; [Token(Token = "0x6005C17")] set; }
	}
}
