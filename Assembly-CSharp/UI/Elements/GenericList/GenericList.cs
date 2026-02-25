using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using Utils;

namespace UI.Elements.GenericList
{
	// Token: 0x02000223 RID: 547
	[Token(Token = "0x2000223")]
	public abstract class GenericList<TArgs, TElement, TElementArgs> : MonoBehaviour where TArgs : GenericListArgs<TElementArgs> where TElement : GenericListElement<TElementArgs>, new() where TElementArgs : GenericListElementArgs
	{
		// Token: 0x06000D98 RID: 3480 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D98")]
		public virtual void Init(TArgs args)
		{
		}

		// Token: 0x06000D99 RID: 3481 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000D99")]
		protected virtual TElement Instantiate(int i, TElementArgs elementArgs)
		{
			return null;
		}

		// Token: 0x06000D9A RID: 3482 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000D9A")]
		protected virtual TElement InstantiateElement(TElement elementPrefab, RectTransform container)
		{
			return null;
		}

		// Token: 0x06000D9B RID: 3483 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D9B")]
		protected virtual void OnInstantiateElement(TElement element, TElementArgs elementArgs)
		{
		}

		// Token: 0x06000D9C RID: 3484 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D9C")]
		public virtual void Remove(int indexElement)
		{
		}

		// Token: 0x06000D9D RID: 3485 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D9D")]
		public virtual void Remove(TElement element)
		{
		}

		// Token: 0x06000D9E RID: 3486 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D9E")]
		public virtual void Clear()
		{
		}

		// Token: 0x06000D9F RID: 3487 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D9F")]
		protected virtual void OnClickElement(TElementArgs elementArgs)
		{
		}

		// Token: 0x06000DA0 RID: 3488 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DA0")]
		public void UpdateElement(int index, TElementArgs elementArgs)
		{
		}

		// Token: 0x06000DA1 RID: 3489 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DA1")]
		public virtual void UpdateElement(TElement element, TElementArgs elementArgs)
		{
		}

		// Token: 0x06000DA2 RID: 3490 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DA2")]
		protected GenericList()
		{
		}

		// Token: 0x040006BF RID: 1727
		[Token(Token = "0x40006BF")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		protected RectTransform _container;

		// Token: 0x040006C0 RID: 1728
		[Token(Token = "0x40006C0")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		protected TElement _elementPrefab;

		// Token: 0x040006C1 RID: 1729
		[Token(Token = "0x40006C1")]
		[FieldOffset(Offset = "0x0")]
		public TypedUnityEvent<TElementArgs> onClick;

		// Token: 0x040006C2 RID: 1730
		[Token(Token = "0x40006C2")]
		[FieldOffset(Offset = "0x0")]
		protected List<TElement> _elements;
	}
}
