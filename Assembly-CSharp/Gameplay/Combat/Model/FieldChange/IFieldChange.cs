using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Protocol.Combat;

namespace Gameplay.Combat.Model.FieldChange
{
	// Token: 0x020009A9 RID: 2473
	[Token(Token = "0x20009A9")]
	public interface IFieldChange
	{
		// Token: 0x17000BBD RID: 3005
		// (get) Token: 0x06003B0E RID: 15118
		[Token(Token = "0x17000BBD")]
		FieldChangedTypes ChangeType { [Token(Token = "0x6003B0E")] get; }

		// Token: 0x17000BBE RID: 3006
		// (get) Token: 0x06003B0F RID: 15119
		[Token(Token = "0x17000BBE")]
		IList<CellInfo> Points { [Token(Token = "0x6003B0F")] get; }

		// Token: 0x06003B10 RID: 15120
		[Token(Token = "0x6003B10")]
		bool TryGetUserId(out ulong userId);
	}
}
