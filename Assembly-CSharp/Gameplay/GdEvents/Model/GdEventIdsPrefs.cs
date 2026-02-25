using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Gameplay.GdEvents.Model
{
	// Token: 0x0200074E RID: 1870
	[Token(Token = "0x200074E")]
	public class GdEventIdsPrefs
	{
		// Token: 0x06002C95 RID: 11413 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C95")]
		[Address(RVA = "0x7D22", Offset = "0x7D22", VA = "0x7D22")]
		public GdEventIdsPrefs(string name)
		{
		}

		// Token: 0x06002C96 RID: 11414 RVA: 0x00008838 File Offset: 0x00006A38
		[Token(Token = "0x6002C96")]
		[Address(RVA = "0x7D23", Offset = "0x7D23", VA = "0x7D23")]
		public bool TryAdd(uint v)
		{
			return default(bool);
		}

		// Token: 0x06002C97 RID: 11415 RVA: 0x00008850 File Offset: 0x00006A50
		[Token(Token = "0x6002C97")]
		[Address(RVA = "0x7D24", Offset = "0x7D24", VA = "0x7D24")]
		public bool TryRemove(uint v)
		{
			return default(bool);
		}

		// Token: 0x06002C98 RID: 11416 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C98")]
		[Address(RVA = "0x7D25", Offset = "0x7D25", VA = "0x7D25")]
		public void Clear()
		{
		}

		// Token: 0x06002C99 RID: 11417 RVA: 0x00008868 File Offset: 0x00006A68
		[Token(Token = "0x6002C99")]
		[Address(RVA = "0x7D26", Offset = "0x7D26", VA = "0x7D26")]
		public bool Contains(uint v)
		{
			return default(bool);
		}

		// Token: 0x06002C9A RID: 11418 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C9A")]
		[Address(RVA = "0x7D27", Offset = "0x7D27", VA = "0x7D27")]
		public void Commit()
		{
		}

		// Token: 0x04001882 RID: 6274
		[Token(Token = "0x4001882")]
		[FieldOffset(Offset = "0x8")]
		public readonly string Name;

		// Token: 0x04001883 RID: 6275
		[Token(Token = "0x4001883")]
		[FieldOffset(Offset = "0xC")]
		private GdEventIdsPrefs.ValuesWrapper _data;

		// Token: 0x0200074F RID: 1871
		[Token(Token = "0x200074F")]
		private class ValuesWrapper
		{
			// Token: 0x06002C9B RID: 11419 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002C9B")]
			[Address(RVA = "0x7D28", Offset = "0x7D28", VA = "0x7D28")]
			public ValuesWrapper()
			{
			}

			// Token: 0x04001884 RID: 6276
			[Token(Token = "0x4001884")]
			[FieldOffset(Offset = "0x8")]
			public readonly List<uint> Values;
		}
	}
}
