using System;
using Il2CppDummyDll;
using Protocol.Dic;
using UnityEngine;

namespace Core.Cache.Audio
{
	// Token: 0x0200110B RID: 4363
	[Token(Token = "0x200110B")]
	public class AudioClipCache : AbstractCache<AssetDic, AudioClip>
	{
		// Token: 0x060065D2 RID: 26066 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065D2")]
		[Address(RVA = "0xB15B", Offset = "0xB15B", VA = "0xB15B")]
		public AudioClipCache(float ttl)
		{
		}

		// Token: 0x060065D3 RID: 26067 RVA: 0x000136C8 File Offset: 0x000118C8
		[Token(Token = "0x60065D3")]
		[Address(RVA = "0xB15C", Offset = "0xB15C", VA = "0xB15C", Slot = "10")]
		public override int Reset(params AssetDic[] keys)
		{
			return 0;
		}

		// Token: 0x060065D4 RID: 26068 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065D4")]
		[Address(RVA = "0xB15D", Offset = "0xB15D", VA = "0xB15D", Slot = "11")]
		protected override void Update(long requestIndex, CacheResultCallback<AudioClip> completeCallback, params AbstractCache<AssetDic, AudioClip>.CacheItem[] cacheItems)
		{
		}
	}
}
