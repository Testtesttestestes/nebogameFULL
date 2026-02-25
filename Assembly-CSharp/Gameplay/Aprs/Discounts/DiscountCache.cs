using System;
using Core.Cache;
using Core.Dict.DictWrappers.Wrappers;
using Gameplay.Aprs.Model;
using Gameplay.Discounts.Model;
using Il2CppDummyDll;

namespace Gameplay.Aprs.Discounts
{
	// Token: 0x02000D6C RID: 3436
	[Token(Token = "0x2000D6C")]
	public class DiscountCache : AbstractCache<MedalDicWrapper, IDiscountArgs>
	{
		// Token: 0x06005433 RID: 21555 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005433")]
		[Address(RVA = "0xA1EA", Offset = "0xA1EA", VA = "0xA1EA", Slot = "9")]
		public override void Dispose()
		{
		}

		// Token: 0x06005434 RID: 21556 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005434")]
		[Address(RVA = "0xA1EB", Offset = "0xA1EB", VA = "0xA1EB")]
		public DiscountCache(AprsModel aprsModel, float ttl)
		{
		}

		// Token: 0x06005435 RID: 21557 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005435")]
		[Address(RVA = "0xA1EC", Offset = "0xA1EC", VA = "0xA1EC", Slot = "11")]
		protected override void Update(long requestIndex, CacheResultCallback<IDiscountArgs> completeCallback, params AbstractCache<MedalDicWrapper, IDiscountArgs>.CacheItem[] cacheItems)
		{
		}

		// Token: 0x04002D9C RID: 11676
		[Token(Token = "0x4002D9C")]
		[FieldOffset(Offset = "0x20")]
		private AprsModel _aprs;
	}
}
