using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Utils;

namespace Core.Cache
{
	// Token: 0x020010F6 RID: 4342
	[Token(Token = "0x20010F6")]
	public abstract class AbstractCache<TKey, TData> : AbstractCache, ICache<TKey, TData>, IDisposable
	{
		// Token: 0x17001494 RID: 5268
		// (get) Token: 0x0600656B RID: 25963 RVA: 0x00013500 File Offset: 0x00011700
		[Token(Token = "0x17001494")]
		public int Count
		{
			[Token(Token = "0x600656B")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17001495 RID: 5269
		// (get) Token: 0x0600656C RID: 25964 RVA: 0x00013518 File Offset: 0x00011718
		[Token(Token = "0x17001495")]
		public float Ttl
		{
			[Token(Token = "0x600656C")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17001496 RID: 5270
		// (get) Token: 0x0600656D RID: 25965 RVA: 0x00013530 File Offset: 0x00011730
		// (set) Token: 0x0600656E RID: 25966 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001496")]
		public bool IsDisposed
		{
			[Token(Token = "0x600656D")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600656E")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001497 RID: 5271
		// (get) Token: 0x0600656F RID: 25967 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006570 RID: 25968 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001497")]
		public OpTokenRepository TokenRepository
		{
			[Token(Token = "0x600656F")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006570")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06006571 RID: 25969 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006571")]
		public virtual void Dispose()
		{
		}

		// Token: 0x06006572 RID: 25970 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006572")]
		public AbstractCache(float ttl)
		{
		}

		// Token: 0x06006573 RID: 25971 RVA: 0x00013548 File Offset: 0x00011748
		[Token(Token = "0x6006573")]
		public long GetData(CacheResultCallback<TData> resultCallback, params TKey[] keys)
		{
			return 0L;
		}

		// Token: 0x06006574 RID: 25972 RVA: 0x00013560 File Offset: 0x00011760
		[Token(Token = "0x6006574")]
		public virtual int Reset(params TKey[] keys)
		{
			return 0;
		}

		// Token: 0x06006575 RID: 25973 RVA: 0x00013578 File Offset: 0x00011778
		[Token(Token = "0x6006575")]
		public bool Cancel(long index)
		{
			return default(bool);
		}

		// Token: 0x06006576 RID: 25974 RVA: 0x00013590 File Offset: 0x00011790
		[Token(Token = "0x6006576")]
		private long GetDataNext(CacheResultCallback<TData> resultCallback)
		{
			return 0L;
		}

		// Token: 0x06006577 RID: 25975 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006577")]
		protected void SetData(AbstractCache<TKey, TData>.CacheItem cacheItem, TData data)
		{
		}

		// Token: 0x06006578 RID: 25976 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006578")]
		protected AbstractCache<TKey, TData>.CacheItem[] GetCacheItem(params TKey[] keys)
		{
			return null;
		}

		// Token: 0x06006579 RID: 25977 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006579")]
		protected AbstractCache<TKey, TData>.CacheItem GetCacheItem(TKey key)
		{
			return null;
		}

		// Token: 0x0600657A RID: 25978 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600657A")]
		protected void AddCallback(AbstractCache<TKey, TData>.CacheItem[] items, long requestIndex, CacheResultCallback<TData> resultCallback)
		{
		}

		// Token: 0x0600657B RID: 25979 RVA: 0x000135A8 File Offset: 0x000117A8
		[Token(Token = "0x600657B")]
		protected bool TryRemoveCallback(AbstractCache<TKey, TData>.CacheItem[] items, out List<AbstractCache<TKey, TData>.RequestInvoker> list)
		{
			return default(bool);
		}

		// Token: 0x0600657C RID: 25980 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600657C")]
		protected void Complete(AbstractCache<TKey, TData>.CacheItem[] cacheItems, TData[] data)
		{
		}

		// Token: 0x0600657D RID: 25981
		[Token(Token = "0x600657D")]
		protected abstract void Update(long requestIndex, CacheResultCallback<TData> completeCallback, params AbstractCache<TKey, TData>.CacheItem[] cacheItems);

		// Token: 0x04003632 RID: 13874
		[Token(Token = "0x4003632")]
		[FieldOffset(Offset = "0x0")]
		private readonly Dictionary<TKey, AbstractCache<TKey, TData>.CacheItem> _cache;

		// Token: 0x04003633 RID: 13875
		[Token(Token = "0x4003633")]
		[FieldOffset(Offset = "0x0")]
		private readonly Dictionary<AbstractCache<TKey, TData>.CacheItem[], List<AbstractCache<TKey, TData>.RequestInvoker>> _callbacks;

		// Token: 0x04003634 RID: 13876
		[Token(Token = "0x4003634")]
		[FieldOffset(Offset = "0x0")]
		private float _ttl;

		// Token: 0x04003637 RID: 13879
		[Token(Token = "0x4003637")]
		[FieldOffset(Offset = "0x0")]
		private Queue<TKey[]> _keysQueue;

		// Token: 0x020010F7 RID: 4343
		[Token(Token = "0x20010F7")]
		protected class CacheItem
		{
			// Token: 0x17001498 RID: 5272
			// (get) Token: 0x0600657E RID: 25982 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17001498")]
			public TKey Key
			{
				[Token(Token = "0x600657E")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x17001499 RID: 5273
			// (get) Token: 0x0600657F RID: 25983 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x06006580 RID: 25984 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17001499")]
			public TData Data
			{
				[Token(Token = "0x600657F")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6006580")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x1700149A RID: 5274
			// (get) Token: 0x06006581 RID: 25985 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x1700149A")]
			public BackTime Expire
			{
				[Token(Token = "0x6006581")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x1700149B RID: 5275
			// (get) Token: 0x06006582 RID: 25986 RVA: 0x000135C0 File Offset: 0x000117C0
			[Token(Token = "0x1700149B")]
			public bool IsExpired
			{
				[Token(Token = "0x6006582")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06006583 RID: 25987 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006583")]
			public CacheItem(TKey key)
			{
			}
		}

		// Token: 0x020010F8 RID: 4344
		[Token(Token = "0x20010F8")]
		protected class RequestInvoker
		{
			// Token: 0x06006584 RID: 25988 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006584")]
			public RequestInvoker(long index, CacheResultCallback<TData> callback)
			{
			}

			// Token: 0x0400363B RID: 13883
			[Token(Token = "0x400363B")]
			[FieldOffset(Offset = "0x0")]
			public readonly long Index;

			// Token: 0x0400363C RID: 13884
			[Token(Token = "0x400363C")]
			[FieldOffset(Offset = "0x0")]
			public readonly CacheResultCallback<TData> Callback;
		}
	}
}
