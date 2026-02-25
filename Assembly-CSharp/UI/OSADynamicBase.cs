using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UI.Elements.GenericList;

namespace UI
{
	// Token: 0x02000109 RID: 265
	[Token(Token = "0x2000109")]
	public abstract class OSADynamicBase<T, Y> : OSAGenericBase<T, Y> where T : AbstractItemViewsHolder where Y : GenericListElementArgs
	{
		// Token: 0x17000113 RID: 275
		// (get) Token: 0x06000883 RID: 2179 RVA: 0x00003540 File Offset: 0x00001740
		[Token(Token = "0x17000113")]
		protected virtual int MinElementsToUpdate
		{
			[Token(Token = "0x6000883")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000884 RID: 2180 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000884")]
		public void ActivateRequestBounds(bool activateUpperBound, bool activateLowerBound)
		{
		}

		// Token: 0x06000885 RID: 2181 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000885")]
		protected override void LateUpdate()
		{
		}

		// Token: 0x06000886 RID: 2182 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000886")]
		private void SendAddBeforeRequest()
		{
		}

		// Token: 0x06000887 RID: 2183 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000887")]
		private void SendAddAfterRequest()
		{
		}

		// Token: 0x06000888 RID: 2184 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000888")]
		public override void AddItems(IList<Y> items, bool atEnd)
		{
		}

		// Token: 0x06000889 RID: 2185 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000889")]
		public override void SetItems(IList<Y> items)
		{
		}

		// Token: 0x0600088A RID: 2186 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600088A")]
		protected OSADynamicBase()
		{
		}

		// Token: 0x0400030A RID: 778
		[Token(Token = "0x400030A")]
		protected const int MIN_ELEMENTS_LEFT_TO_UPDATE = 50;

		// Token: 0x0400030B RID: 779
		[Token(Token = "0x400030B")]
		[FieldOffset(Offset = "0x0")]
		protected bool _upperBoundActive;

		// Token: 0x0400030C RID: 780
		[Token(Token = "0x400030C")]
		[FieldOffset(Offset = "0x0")]
		protected bool _lowerBoundActive;

		// Token: 0x0400030D RID: 781
		[Token(Token = "0x400030D")]
		[FieldOffset(Offset = "0x0")]
		protected bool _addAfterRequestSent;

		// Token: 0x0400030E RID: 782
		[Token(Token = "0x400030E")]
		[FieldOffset(Offset = "0x0")]
		protected bool _addBeforeRequestSent;

		// Token: 0x0400030F RID: 783
		[Token(Token = "0x400030F")]
		[FieldOffset(Offset = "0x0")]
		public Action MoreItemsAfterNeededEvent;

		// Token: 0x04000310 RID: 784
		[Token(Token = "0x4000310")]
		[FieldOffset(Offset = "0x0")]
		public Action MoreItemsBeforeNeededEvent;
	}
}
