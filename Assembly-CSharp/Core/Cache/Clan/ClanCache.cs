using System;
using Google.Protobuf;
using Il2CppDummyDll;
using Protocol.Common;
using ServicesNamespace;
using Utils;

namespace Core.Cache.Clan
{
	// Token: 0x02001109 RID: 4361
	[Token(Token = "0x2001109")]
	public class ClanCache : AbstractCache<ulong, ClanShortInfo>
	{
		// Token: 0x060065CB RID: 26059 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065CB")]
		[Address(RVA = "0xB154", Offset = "0xB154", VA = "0xB154", Slot = "9")]
		public override void Dispose()
		{
		}

		// Token: 0x060065CC RID: 26060 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065CC")]
		[Address(RVA = "0xB155", Offset = "0xB155", VA = "0xB155")]
		public ClanCache(float ttl)
		{
		}

		// Token: 0x060065CD RID: 26061 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065CD")]
		[Address(RVA = "0xB156", Offset = "0xB156", VA = "0xB156", Slot = "11")]
		protected override void Update(long requestIndex, CacheResultCallback<ClanShortInfo> completeCallback, params AbstractCache<ulong, ClanShortInfo>.CacheItem[] cacheItems)
		{
		}

		// Token: 0x060065CE RID: 26062 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065CE")]
		[Address(RVA = "0xB157", Offset = "0xB157", VA = "0xB157")]
		private void HandleGetShortClansInfoService(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x0400365E RID: 13918
		[Token(Token = "0x400365E")]
		[FieldOffset(Offset = "0x20")]
		private ClansService _clansService;
	}
}
