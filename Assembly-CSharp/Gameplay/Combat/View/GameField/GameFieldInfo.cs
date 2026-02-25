using System;
using Il2CppDummyDll;

namespace Gameplay.Combat.View.GameField
{
	// Token: 0x0200095E RID: 2398
	[Token(Token = "0x200095E")]
	public abstract class GameFieldInfo
	{
		// Token: 0x060038DA RID: 14554 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038DA")]
		[Address(RVA = "0x8878", Offset = "0x8878", VA = "0x8878")]
		protected GameFieldInfo()
		{
		}

		// Token: 0x04001F67 RID: 8039
		[Token(Token = "0x4001F67")]
		public const int CellSize = 88;

		// Token: 0x04001F68 RID: 8040
		[Token(Token = "0x4001F68")]
		public const int HalfCellSize = 44;
	}
}
