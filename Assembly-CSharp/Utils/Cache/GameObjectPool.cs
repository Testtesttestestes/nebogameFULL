using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Utils.Cache
{
	// Token: 0x02000072 RID: 114
	[Token(Token = "0x2000072")]
	public class GameObjectPool<T> : ObjectPool<T> where T : Component, new()
	{
		// Token: 0x06000356 RID: 854 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000356")]
		public GameObjectPool(T target, Transform parent, [Optional] ObjectPool<T>.ResetPoolObjectDelegate resetPoolObjectDelegate)
		{
		}

		// Token: 0x06000357 RID: 855 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000357")]
		public GameObjectPool(int count, T target, Transform parent, [Optional] ObjectPool<T>.ResetPoolObjectDelegate resetPoolObjectDelegate)
		{
		}

		// Token: 0x06000358 RID: 856 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000358")]
		protected override T CreateInstance()
		{
			return null;
		}

		// Token: 0x06000359 RID: 857 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000359")]
		public override void Warm(int count)
		{
		}

		// Token: 0x0600035A RID: 858 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600035A")]
		public override void Dispose()
		{
		}

		// Token: 0x04000180 RID: 384
		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private T _target;

		// Token: 0x04000181 RID: 385
		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Transform _parent;
	}
}
