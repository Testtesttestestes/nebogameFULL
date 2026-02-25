using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Utils.Cache
{
	// Token: 0x02000073 RID: 115
	[Token(Token = "0x2000073")]
	public class GameObjectPoolRestricted<T> : GameObjectPool<T> where T : Component, IPoolElement<T>, new()
	{
		// Token: 0x0600035B RID: 859 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600035B")]
		public GameObjectPoolRestricted(T target, Transform parent, [Optional] ObjectPool<T>.ResetPoolObjectDelegate resetPoolObjectDelegate)
		{
		}

		// Token: 0x0600035C RID: 860 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600035C")]
		public GameObjectPoolRestricted(int count, T target, Transform parent, [Optional] ObjectPool<T>.ResetPoolObjectDelegate resetPoolObjectDelegate)
		{
		}

		// Token: 0x0600035D RID: 861 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600035D")]
		protected override T CreateInstance()
		{
			return null;
		}
	}
}
