using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace CloudsFly
{
	// Token: 0x020012F3 RID: 4851
	[Token(Token = "0x20012F3")]
	public class BaseWorldObjectRenderer : MonoBehaviour, IWorldObjectRenderer
	{
		// Token: 0x17001751 RID: 5969
		// (get) Token: 0x06007376 RID: 29558 RVA: 0x00014BE0 File Offset: 0x00012DE0
		[Token(Token = "0x17001751")]
		public int SortingOrderDelta
		{
			[Token(Token = "0x6007376")]
			[Address(RVA = "0xBD63", Offset = "0xBD63", VA = "0xBD63")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17001752 RID: 5970
		// (get) Token: 0x06007377 RID: 29559 RVA: 0x00014BF8 File Offset: 0x00012DF8
		// (set) Token: 0x06007378 RID: 29560 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001752")]
		public int SortingOrder
		{
			[Token(Token = "0x6007377")]
			[Address(RVA = "0xBD64", Offset = "0xBD64", VA = "0xBD64", Slot = "4")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6007378")]
			[Address(RVA = "0xBD65", Offset = "0xBD65", VA = "0xBD65", Slot = "5")]
			set
			{
			}
		}

		// Token: 0x17001753 RID: 5971
		// (get) Token: 0x06007379 RID: 29561 RVA: 0x00014C10 File Offset: 0x00012E10
		[Token(Token = "0x17001753")]
		public int SortingOrderWithDelta
		{
			[Token(Token = "0x6007379")]
			[Address(RVA = "0x1DEF", Offset = "0x1DEF", VA = "0x1DEF")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17001754 RID: 5972
		// (get) Token: 0x0600737A RID: 29562 RVA: 0x00014C28 File Offset: 0x00012E28
		// (set) Token: 0x0600737B RID: 29563 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001754")]
		public int SortingLayerId
		{
			[Token(Token = "0x600737A")]
			[Address(RVA = "0xBD66", Offset = "0xBD66", VA = "0xBD66", Slot = "6")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600737B")]
			[Address(RVA = "0xBD67", Offset = "0xBD67", VA = "0xBD67", Slot = "7")]
			set
			{
			}
		}

		// Token: 0x0600737C RID: 29564 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600737C")]
		[Address(RVA = "0xBD68", Offset = "0xBD68", VA = "0xBD68")]
		private List<IWorldObjectRenderer> GetChildren()
		{
			return null;
		}

		// Token: 0x0600737D RID: 29565 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600737D")]
		[Address(RVA = "0xBD69", Offset = "0xBD69", VA = "0xBD69")]
		private void ValidateSortingOrder()
		{
		}

		// Token: 0x0600737E RID: 29566 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600737E")]
		[Address(RVA = "0xBD6A", Offset = "0xBD6A", VA = "0xBD6A")]
		private void ValidateSortingLayerId()
		{
		}

		// Token: 0x0600737F RID: 29567 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600737F")]
		[Address(RVA = "0xBD6B", Offset = "0xBD6B", VA = "0xBD6B", Slot = "8")]
		protected virtual void ApplySortingOrder()
		{
		}

		// Token: 0x06007380 RID: 29568 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007380")]
		[Address(RVA = "0xBD6C", Offset = "0xBD6C", VA = "0xBD6C", Slot = "9")]
		protected virtual void ApplySortingLayerId()
		{
		}

		// Token: 0x06007381 RID: 29569 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007381")]
		[Address(RVA = "0xBD6D", Offset = "0xBD6D", VA = "0xBD6D")]
		public BaseWorldObjectRenderer()
		{
		}

		// Token: 0x04003C6D RID: 15469
		[Token(Token = "0x4003C6D")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private int _sortingOrderDelta;

		// Token: 0x04003C6E RID: 15470
		[Token(Token = "0x4003C6E")]
		[FieldOffset(Offset = "0x14")]
		private int _sortingOrder;

		// Token: 0x04003C6F RID: 15471
		[Token(Token = "0x4003C6F")]
		[FieldOffset(Offset = "0x18")]
		private int _sortingLayerId;

		// Token: 0x04003C70 RID: 15472
		[Token(Token = "0x4003C70")]
		[FieldOffset(Offset = "0x1C")]
		private List<IWorldObjectRenderer> _children;

		// Token: 0x04003C71 RID: 15473
		[Token(Token = "0x4003C71")]
		[FieldOffset(Offset = "0x20")]
		private bool _childrenChanged;
	}
}
