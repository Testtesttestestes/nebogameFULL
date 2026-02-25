using System;
using Core.Gameplay;
using Core.Gameplay.Managers;
using Core.Gameplay.Managers.Location;
using Il2CppDummyDll;

namespace Core.Application.Managers.Connection
{
	// Token: 0x0200126A RID: 4714
	[Token(Token = "0x200126A")]
	public interface IRecoveryConnection : IDisposable
	{
		// Token: 0x170016D2 RID: 5842
		// (get) Token: 0x06006FD2 RID: 28626
		// (set) Token: 0x06006FD3 RID: 28627
		[Token(Token = "0x170016D2")]
		ILoginProvider AuthLogin { [Token(Token = "0x6006FD2")] get; [Token(Token = "0x6006FD3")] set; }

		// Token: 0x170016D3 RID: 5843
		// (get) Token: 0x06006FD4 RID: 28628
		// (set) Token: 0x06006FD5 RID: 28629
		[Token(Token = "0x170016D3")]
		ILocation Location { [Token(Token = "0x6006FD4")] get; [Token(Token = "0x6006FD5")] set; }

		// Token: 0x170016D4 RID: 5844
		// (get) Token: 0x06006FD6 RID: 28630
		// (set) Token: 0x06006FD7 RID: 28631
		[Token(Token = "0x170016D4")]
		IClientState ClientState { [Token(Token = "0x6006FD6")] get; [Token(Token = "0x6006FD7")] set; }

		// Token: 0x170016D5 RID: 5845
		// (get) Token: 0x06006FD8 RID: 28632
		// (set) Token: 0x06006FD9 RID: 28633
		[Token(Token = "0x170016D5")]
		IGame Game { [Token(Token = "0x6006FD8")] get; [Token(Token = "0x6006FD9")] set; }

		// Token: 0x06006FDA RID: 28634
		[Token(Token = "0x6006FDA")]
		void Resolve();
	}
}
