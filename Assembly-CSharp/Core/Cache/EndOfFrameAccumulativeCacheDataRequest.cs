using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Core.Cache
{
	// Token: 0x020010FD RID: 4349
	[Token(Token = "0x20010FD")]
	public class EndOfFrameAccumulativeCacheDataRequest<TKey, TData> : ICache<TKey, TData>, IDisposable
	{
		// Token: 0x06006591 RID: 26001 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006591")]
		public void Dispose()
		{
		}

		// Token: 0x1700149C RID: 5276
		// (get) Token: 0x06006592 RID: 26002 RVA: 0x000135F0 File Offset: 0x000117F0
		[Token(Token = "0x1700149C")]
		public float Ttl
		{
			[Token(Token = "0x6006592")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06006593 RID: 26003 RVA: 0x00013608 File Offset: 0x00011808
		[Token(Token = "0x6006593")]
		public long GetData(CacheResultCallback<TData> resultCallback, params TKey[] keys)
		{
			return 0L;
		}

		// Token: 0x06006594 RID: 26004 RVA: 0x00013620 File Offset: 0x00011820
		[Token(Token = "0x6006594")]
		public int Reset(params TKey[] keys)
		{
			return 0;
		}

		// Token: 0x06006595 RID: 26005 RVA: 0x00013638 File Offset: 0x00011838
		[Token(Token = "0x6006595")]
		public bool Cancel(long index)
		{
			return default(bool);
		}

		// Token: 0x06006596 RID: 26006 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006596")]
		public IEnumerator WaitEndOfFrameCoroutine()
		{
			return null;
		}

		// Token: 0x06006597 RID: 26007 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006597")]
		public EndOfFrameAccumulativeCacheDataRequest(ICache<TKey, TData> cache)
		{
		}

		// Token: 0x1700149D RID: 5277
		// (get) Token: 0x06006598 RID: 26008 RVA: 0x00013650 File Offset: 0x00011850
		// (set) Token: 0x06006599 RID: 26009 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700149D")]
		public int FrameIndex
		{
			[Token(Token = "0x6006598")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6006599")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600659A RID: 26010 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600659A")]
		protected virtual void Execute()
		{
		}

		// Token: 0x04003645 RID: 13893
		[Token(Token = "0x4003645")]
		public const int DEFAULT_CAPACITY = 10;

		// Token: 0x04003646 RID: 13894
		[Token(Token = "0x4003646")]
		[FieldOffset(Offset = "0x0")]
		private Dictionary<CacheResultCallback<TData>, List<TKey>> _keysByCallback;

		// Token: 0x04003647 RID: 13895
		[Token(Token = "0x4003647")]
		[FieldOffset(Offset = "0x0")]
		private Coroutine _coroutine;

		// Token: 0x04003648 RID: 13896
		[Token(Token = "0x4003648")]
		[FieldOffset(Offset = "0x0")]
		private ICache<TKey, TData> _cache;
	}
}
