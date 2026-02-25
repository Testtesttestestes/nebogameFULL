using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Utils.Cache
{
	// Token: 0x02000076 RID: 118
	[Token(Token = "0x2000076")]
	public class ObjectPool<T> : IPool<T>, IDisposable where T : class, new()
	{
		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06000363 RID: 867 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000364 RID: 868 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000081")]
		public ObjectPool<T>.ResetPoolObjectDelegate ResetDelegate
		{
			[Token(Token = "0x6000363")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000364")]
			set
			{
			}
		}

		// Token: 0x06000365 RID: 869 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000365")]
		public ObjectPool(ObjectPool<T>.ResetPoolObjectDelegate resetPoolObjectDelegate)
		{
		}

		// Token: 0x06000366 RID: 870 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000366")]
		public ObjectPool(int count, ObjectPool<T>.ResetPoolObjectDelegate resetPoolObjectDelegate)
		{
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x06000367 RID: 871 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000082")]
		public Queue<T> Objects
		{
			[Token(Token = "0x6000367")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000368 RID: 872 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000368")]
		public virtual void Warm(int count)
		{
		}

		// Token: 0x06000369 RID: 873 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000369")]
		protected virtual T CreateInstance()
		{
			return null;
		}

		// Token: 0x0600036A RID: 874 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600036A")]
		public T Get()
		{
			return null;
		}

		// Token: 0x0600036B RID: 875 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600036B")]
		public void Release(T value)
		{
		}

		// Token: 0x0600036C RID: 876 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600036C")]
		public void Clear()
		{
		}

		// Token: 0x0600036D RID: 877 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600036D")]
		public virtual void Dispose()
		{
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x0600036E RID: 878 RVA: 0x00002D48 File Offset: 0x00000F48
		[Token(Token = "0x17000083")]
		public int Count
		{
			[Token(Token = "0x600036E")]
			get
			{
				return 0;
			}
		}

		// Token: 0x04000182 RID: 386
		[Token(Token = "0x4000182")]
		[FieldOffset(Offset = "0x0")]
		private Queue<T> _objects;

		// Token: 0x04000183 RID: 387
		[Token(Token = "0x4000183")]
		[FieldOffset(Offset = "0x0")]
		private ObjectPool<T>.ResetPoolObjectDelegate _resetPoolObjectDelegate;

		// Token: 0x02000077 RID: 119
		// (Invoke) Token: 0x06000370 RID: 880
		[Token(Token = "0x2000077")]
		public delegate void ResetPoolObjectDelegate(T pooledObject);
	}
}
