using System;
using Core.Data;
using Il2CppDummyDll;

namespace Gameplay.Chat.Model
{
	// Token: 0x02000B0E RID: 2830
	[Token(Token = "0x2000B0E")]
	public interface IFavoriteUsersProvider
	{
		// Token: 0x0600444A RID: 17482
		[Token(Token = "0x600444A")]
		UserData[] GetFavoriteUsers();
	}
}
