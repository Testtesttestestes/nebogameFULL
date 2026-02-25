using System;
using Il2CppDummyDll;
using UnityEngine;
using Utils.Cache;

namespace UI.Elements.GenericList
{
	// Token: 0x02000227 RID: 551
	[Token(Token = "0x2000227")]
	public class PooledGenericList<TArgs, TElement, TElementArgs> : GenericList<TArgs, TElement, TElementArgs> where TArgs : GenericListArgs<TElementArgs> where TElement : GenericListElement<TElementArgs>, new() where TElementArgs : GenericListElementArgs
	{
		// Token: 0x06000DB2 RID: 3506 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DB2")]
		public override void Init(TArgs args)
		{
		}

		// Token: 0x06000DB3 RID: 3507 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000DB3")]
		protected override TElement InstantiateElement(TElement elementPrefab, RectTransform container)
		{
			return null;
		}

		// Token: 0x06000DB4 RID: 3508 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DB4")]
		public override void Remove(TElement element)
		{
		}

		// Token: 0x06000DB5 RID: 3509 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DB5")]
		public override void Clear()
		{
		}

		// Token: 0x06000DB6 RID: 3510 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DB6")]
		public PooledGenericList()
		{
		}

		// Token: 0x040006C9 RID: 1737
		[Token(Token = "0x40006C9")]
		[FieldOffset(Offset = "0x0")]
		protected GameObjectPool<TElement> pool;

		// Token: 0x040006CA RID: 1738
		[Token(Token = "0x40006CA")]
		[FieldOffset(Offset = "0x0")]
		public bool hideFreeElements;
	}
}
