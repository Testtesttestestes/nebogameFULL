using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace UI.Elements.Filters.GenericFilter
{
	// Token: 0x02000237 RID: 567
	[Token(Token = "0x2000237")]
	public class GenericFilterView : MonoBehaviour
	{
		// Token: 0x140000F1 RID: 241
		// (add) Token: 0x06000E02 RID: 3586 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000E03 RID: 3587 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000F1")]
		public event Action<object> SelectedEvent
		{
			[Token(Token = "0x6000E02")]
			[Address(RVA = "0x6095", Offset = "0x6095", VA = "0x6095")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000E03")]
			[Address(RVA = "0x6096", Offset = "0x6096", VA = "0x6096")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06000E04 RID: 3588 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E04")]
		[Address(RVA = "0x6097", Offset = "0x6097", VA = "0x6097", Slot = "4")]
		public virtual void Init(IEnumerable<FilterListElement.FilterData> data)
		{
		}

		// Token: 0x06000E05 RID: 3589 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E05")]
		[Address(RVA = "0x6098", Offset = "0x6098", VA = "0x6098", Slot = "5")]
		protected virtual void ListElementClickedEventHandler(FilterListElement element)
		{
		}

		// Token: 0x06000E06 RID: 3590 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E06")]
		[Address(RVA = "0x6099", Offset = "0x6099", VA = "0x6099")]
		protected void SelectElement(FilterListElement element, bool notify)
		{
		}

		// Token: 0x06000E07 RID: 3591 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E07")]
		[Address(RVA = "0x609A", Offset = "0x609A", VA = "0x609A")]
		public void SelectByIndex(int index)
		{
		}

		// Token: 0x06000E08 RID: 3592 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E08")]
		[Address(RVA = "0x609B", Offset = "0x609B", VA = "0x609B")]
		public void SelectByIndexSilent(int index)
		{
		}

		// Token: 0x06000E09 RID: 3593 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000E09")]
		[Address(RVA = "0x609C", Offset = "0x609C", VA = "0x609C")]
		public FilterListElement GetElementByIndex(int index)
		{
			return null;
		}

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x06000E0A RID: 3594 RVA: 0x000041B8 File Offset: 0x000023B8
		[Token(Token = "0x170001DA")]
		public int CurrentIndex
		{
			[Token(Token = "0x6000E0A")]
			[Address(RVA = "0x609D", Offset = "0x609D", VA = "0x609D")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000E0B RID: 3595 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E0B")]
		[Address(RVA = "0x609E", Offset = "0x609E", VA = "0x609E")]
		protected void PopulateList(IEnumerable<FilterListElement.FilterData> data)
		{
		}

		// Token: 0x06000E0C RID: 3596 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E0C")]
		[Address(RVA = "0x609F", Offset = "0x609F", VA = "0x609F")]
		public GenericFilterView()
		{
		}

		// Token: 0x040006EB RID: 1771
		[Token(Token = "0x40006EB")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private FilterListElement _listElementPrefab;

		// Token: 0x040006EC RID: 1772
		[Token(Token = "0x40006EC")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private RectTransform _content;

		// Token: 0x040006EE RID: 1774
		[Token(Token = "0x40006EE")]
		[FieldOffset(Offset = "0x1C")]
		private readonly List<FilterListElement> _listElements;

		// Token: 0x040006EF RID: 1775
		[Token(Token = "0x40006EF")]
		[FieldOffset(Offset = "0x20")]
		protected FilterListElement _selectedElement;
	}
}
