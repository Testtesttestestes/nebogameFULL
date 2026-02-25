using System;
using Core.Data;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Il2CppDummyDll;
using Protocol.Common;
using Utils;

namespace Core.Cache.User
{
	// Token: 0x02001107 RID: 4359
	[Token(Token = "0x2001107")]
	public class UserCacheBasicInfo : AbstractCache<ulong, UserData>, IUserCache, ICache<ulong, UserData>, IDisposable, IUserInfoWrapper
	{
		// Token: 0x060065C0 RID: 26048 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065C0")]
		[Address(RVA = "0xB149", Offset = "0xB149", VA = "0xB149")]
		public UserCacheBasicInfo(float ttl)
		{
		}

		// Token: 0x060065C1 RID: 26049 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60065C1")]
		[Address(RVA = "0xB14A", Offset = "0xB14A", VA = "0xB14A", Slot = "14")]
		public UserData[] GetData(params UserInfo[] userInfos)
		{
			return null;
		}

		// Token: 0x060065C2 RID: 26050 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60065C2")]
		[Address(RVA = "0xB14B", Offset = "0xB14B", VA = "0xB14B", Slot = "13")]
		public UserData GetData(UserInfo userInfo)
		{
			return null;
		}

		// Token: 0x060065C3 RID: 26051 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60065C3")]
		[Address(RVA = "0xB14C", Offset = "0xB14C", VA = "0xB14C", Slot = "12")]
		public UserData GetDataKeepRatings(UserInfo userInfo)
		{
			return null;
		}

		// Token: 0x060065C4 RID: 26052 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60065C4")]
		[Address(RVA = "0xB14D", Offset = "0xB14D", VA = "0xB14D")]
		private UserData[] GetData(RepeatedField<ExtUserInfo> extUserInfos)
		{
			return null;
		}

		// Token: 0x060065C5 RID: 26053 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065C5")]
		[Address(RVA = "0xB14E", Offset = "0xB14E", VA = "0xB14E", Slot = "11")]
		protected override void Update(long requestIndex, CacheResultCallback<UserData> completeCallback, params AbstractCache<ulong, UserData>.CacheItem[] cacheItems)
		{
		}

		// Token: 0x060065C6 RID: 26054 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065C6")]
		[Address(RVA = "0xB14F", Offset = "0xB14F", VA = "0xB14F")]
		private void RequestExtUserInfo(AbstractCache<ulong, UserData>.CacheItem[] cacheItems)
		{
		}

		// Token: 0x060065C7 RID: 26055 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065C7")]
		[Address(RVA = "0xB150", Offset = "0xB150", VA = "0xB150")]
		private void HandlerGetShortUserInfoService(OpToken<IMessage, object> op)
		{
		}
	}
}
