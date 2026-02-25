using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Google.Protobuf;
using Il2CppDummyDll;
using ServicesNamespace;
using Utils;

namespace Core.Cache.User
{
	// Token: 0x02001102 RID: 4354
	[Token(Token = "0x2001102")]
	public class UserCache : AbstractCache<ulong, UserData>
	{
		// Token: 0x060065A8 RID: 26024 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065A8")]
		[Address(RVA = "0xB131", Offset = "0xB131", VA = "0xB131", Slot = "9")]
		public override void Dispose()
		{
		}

		// Token: 0x060065A9 RID: 26025 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065A9")]
		[Address(RVA = "0xB132", Offset = "0xB132", VA = "0xB132")]
		public UserCache(IUserCache userCache, float ttl)
		{
		}

		// Token: 0x060065AA RID: 26026 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065AA")]
		[Address(RVA = "0xB133", Offset = "0xB133", VA = "0xB133", Slot = "11")]
		protected override void Update(long requestIndex, CacheResultCallback<UserData> completeCallback, params AbstractCache<ulong, UserData>.CacheItem[] cacheItems)
		{
		}

		// Token: 0x060065AB RID: 26027 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60065AB")]
		[Address(RVA = "0xB134", Offset = "0xB134", VA = "0xB134")]
		private UserCache.CollectInfoInvokerVo CollectInfo(int index, AbstractCache<ulong, UserData>.CacheItem cacheItem, Action<UserCache.CollectInfoInvokerVo> callback)
		{
			return null;
		}

		// Token: 0x060065AC RID: 26028 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065AC")]
		[Address(RVA = "0xB135", Offset = "0xB135", VA = "0xB135")]
		private void RequestClanIsleInfo(UserCache.CollectInfoInvokerVo invoker)
		{
		}

		// Token: 0x060065AD RID: 26029 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065AD")]
		[Address(RVA = "0xB136", Offset = "0xB136", VA = "0xB136")]
		private void RequestUserSkills(UserCache.CollectInfoInvokerVo invoker)
		{
		}

		// Token: 0x060065AE RID: 26030 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065AE")]
		[Address(RVA = "0xB137", Offset = "0xB137", VA = "0xB137")]
		private void RequestUserStats(UserCache.CollectInfoInvokerVo invoker)
		{
		}

		// Token: 0x060065AF RID: 26031 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065AF")]
		[Address(RVA = "0xB138", Offset = "0xB138", VA = "0xB138")]
		private void RequestUserMedals(UserCache.CollectInfoInvokerVo invoker)
		{
		}

		// Token: 0x060065B0 RID: 26032 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065B0")]
		[Address(RVA = "0xB139", Offset = "0xB139", VA = "0xB139")]
		private void HandleGetClanIsleInfo(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x060065B1 RID: 26033 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065B1")]
		[Address(RVA = "0xB13A", Offset = "0xB13A", VA = "0xB13A")]
		private void HandleGetUserSkillsService(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x060065B2 RID: 26034 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065B2")]
		[Address(RVA = "0xB13B", Offset = "0xB13B", VA = "0xB13B")]
		private void HandleGetUserStatsService(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x060065B3 RID: 26035 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065B3")]
		[Address(RVA = "0xB13C", Offset = "0xB13C", VA = "0xB13C")]
		private void HandleGetUserMedalsService(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x0400364D RID: 13901
		[Token(Token = "0x400364D")]
		[FieldOffset(Offset = "0x20")]
		private readonly LinkedList<IDisposable> _collectors;

		// Token: 0x0400364E RID: 13902
		[Token(Token = "0x400364E")]
		[FieldOffset(Offset = "0x24")]
		private IUserCache _userCache;

		// Token: 0x0400364F RID: 13903
		[Token(Token = "0x400364F")]
		[FieldOffset(Offset = "0x28")]
		private MainService _service;

		// Token: 0x02001103 RID: 4355
		[Token(Token = "0x2001103")]
		private class CollectInfoInvokerVo : IDisposable
		{
			// Token: 0x170014A1 RID: 5281
			// (get) Token: 0x060065B4 RID: 26036 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x060065B5 RID: 26037 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170014A1")]
			public AbstractCache<ulong, UserData>.CacheItem Item
			{
				[Token(Token = "0x60065B4")]
				[Address(RVA = "0xB13D", Offset = "0xB13D", VA = "0xB13D")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60065B5")]
				[Address(RVA = "0xB13E", Offset = "0xB13E", VA = "0xB13E")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x060065B6 RID: 26038 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60065B6")]
			[Address(RVA = "0xB13F", Offset = "0xB13F", VA = "0xB13F")]
			public CollectInfoInvokerVo(int index, AbstractCache<ulong, UserData>.CacheItem item, Action<UserCache.CollectInfoInvokerVo> collectCallback)
			{
			}

			// Token: 0x060065B7 RID: 26039 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60065B7")]
			[Address(RVA = "0xB140", Offset = "0xB140", VA = "0xB140")]
			public void Complete()
			{
			}

			// Token: 0x060065B8 RID: 26040 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60065B8")]
			[Address(RVA = "0xB141", Offset = "0xB141", VA = "0xB141", Slot = "4")]
			public void Dispose()
			{
			}

			// Token: 0x04003650 RID: 13904
			[Token(Token = "0x4003650")]
			[FieldOffset(Offset = "0x8")]
			public readonly int Index;

			// Token: 0x04003652 RID: 13906
			[Token(Token = "0x4003652")]
			[FieldOffset(Offset = "0x10")]
			private Action<UserCache.CollectInfoInvokerVo> _collectCallback;
		}
	}
}
