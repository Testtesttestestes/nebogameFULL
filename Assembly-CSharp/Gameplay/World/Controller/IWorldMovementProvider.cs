using System;
using Il2CppDummyDll;

namespace Gameplay.World.Controller
{
	// Token: 0x0200037A RID: 890
	[Token(Token = "0x200037A")]
	public interface IWorldMovementProvider
	{
		// Token: 0x17000363 RID: 867
		// (get) Token: 0x060014A1 RID: 5281
		[Token(Token = "0x17000363")]
		IUserIslesWorldMovement UserIslesWorldMovement { [Token(Token = "0x60014A1")] get; }

		// Token: 0x17000364 RID: 868
		// (get) Token: 0x060014A2 RID: 5282
		[Token(Token = "0x17000364")]
		IClanIslesWorldMovement ClanIslesWorldMovement { [Token(Token = "0x60014A2")] get; }
	}
}
