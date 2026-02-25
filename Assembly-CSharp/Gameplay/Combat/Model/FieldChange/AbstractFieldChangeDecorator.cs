using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Protocol.Combat;

namespace Gameplay.Combat.Model.FieldChange
{
	// Token: 0x020009A7 RID: 2471
	[Token(Token = "0x20009A7")]
	public abstract class AbstractFieldChangeDecorator<T> : IDisposable, IFieldChange where T : class
	{
		// Token: 0x06003B05 RID: 15109 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B05")]
		public void Dispose()
		{
		}

		// Token: 0x06003B06 RID: 15110 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B06")]
		public AbstractFieldChangeDecorator(T change)
		{
		}

		// Token: 0x17000BB9 RID: 3001
		// (get) Token: 0x06003B07 RID: 15111
		[Token(Token = "0x17000BB9")]
		public abstract FieldChangedTypes ChangeType { [Token(Token = "0x6003B07")] get; }

		// Token: 0x17000BBA RID: 3002
		// (get) Token: 0x06003B08 RID: 15112
		[Token(Token = "0x17000BBA")]
		public abstract IList<CellInfo> Points { [Token(Token = "0x6003B08")] get; }

		// Token: 0x06003B09 RID: 15113
		[Token(Token = "0x6003B09")]
		public abstract bool TryGetUserId(out ulong userId);

		// Token: 0x04002095 RID: 8341
		[Token(Token = "0x4002095")]
		[FieldOffset(Offset = "0x0")]
		protected T _change;
	}
}
