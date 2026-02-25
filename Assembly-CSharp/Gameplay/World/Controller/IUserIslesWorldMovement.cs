using System;
using Il2CppDummyDll;

namespace Gameplay.World.Controller
{
	// Token: 0x02000379 RID: 889
	[Token(Token = "0x2000379")]
	public interface IUserIslesWorldMovement
	{
		// Token: 0x0600149F RID: 5279
		[Token(Token = "0x600149F")]
		void GoHome();

		// Token: 0x060014A0 RID: 5280
		[Token(Token = "0x60014A0")]
		void GoToUserIsle(ulong userId, bool force);
	}
}
