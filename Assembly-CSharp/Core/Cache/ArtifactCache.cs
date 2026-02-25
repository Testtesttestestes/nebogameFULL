using System;
using System.Collections.Generic;
using Core.Data;
using Core.Dict;
using Il2CppDummyDll;
using Protocol.Common;

namespace Core.Cache
{
	// Token: 0x020010FB RID: 4347
	[Token(Token = "0x20010FB")]
	public class ArtifactCache : IDisposable
	{
		// Token: 0x0600658A RID: 25994 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600658A")]
		[Address(RVA = "0xB12F", Offset = "0xB12F", VA = "0xB12F")]
		public ArtifactCache(UserData loggedUser, IDictProvider provider)
		{
		}

		// Token: 0x0600658B RID: 25995 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600658B")]
		[Address(RVA = "0x216A", Offset = "0x216A", VA = "0x216A")]
		public ArtifactData GetArtifact(ArtifactInfo artifactInfo, UserData ownerUser)
		{
			return null;
		}

		// Token: 0x0600658C RID: 25996 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600658C")]
		[Address(RVA = "0xB130", Offset = "0xB130", VA = "0xB130", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x04003642 RID: 13890
		[Token(Token = "0x4003642")]
		[FieldOffset(Offset = "0x8")]
		private readonly UserData _loggedUser;

		// Token: 0x04003643 RID: 13891
		[Token(Token = "0x4003643")]
		[FieldOffset(Offset = "0xC")]
		private readonly IDictProvider _dictProvider;

		// Token: 0x04003644 RID: 13892
		[Token(Token = "0x4003644")]
		[FieldOffset(Offset = "0x10")]
		private readonly Dictionary<ulong, ArtifactData> _allArtifacts;
	}
}
