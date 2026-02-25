using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.VortexRating.View.GreatPrizesTab
{
	// Token: 0x0200038D RID: 909
	[Token(Token = "0x200038D")]
	public class GenericListFilter : MonoBehaviour
	{
		// Token: 0x1400010C RID: 268
		// (add) Token: 0x06001527 RID: 5415 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06001528 RID: 5416 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400010C")]
		public event Action<object> SelectedEvent
		{
			[Token(Token = "0x6001527")]
			[Address(RVA = "0x66E9", Offset = "0x66E9", VA = "0x66E9")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6001528")]
			[Address(RVA = "0x66EA", Offset = "0x66EA", VA = "0x66EA")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06001529 RID: 5417 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001529")]
		[Address(RVA = "0x66EB", Offset = "0x66EB", VA = "0x66EB")]
		public void Init(IList<GenericListFilter.ListFilterData> data)
		{
		}

		// Token: 0x0600152A RID: 5418 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600152A")]
		[Address(RVA = "0x66EC", Offset = "0x66EC", VA = "0x66EC")]
		private void ListElementClickedEventHandler(FilterListElement element)
		{
		}

		// Token: 0x0600152B RID: 5419 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600152B")]
		[Address(RVA = "0x66ED", Offset = "0x66ED", VA = "0x66ED")]
		private void SelectElement(FilterListElement element)
		{
		}

		// Token: 0x0600152C RID: 5420 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600152C")]
		[Address(RVA = "0x66EE", Offset = "0x66EE", VA = "0x66EE")]
		public GenericListFilter()
		{
		}

		// Token: 0x04000B39 RID: 2873
		[Token(Token = "0x4000B39")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private FilterListElement _listElementPrefab;

		// Token: 0x04000B3A RID: 2874
		[Token(Token = "0x4000B3A")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private RectTransform _content;

		// Token: 0x04000B3C RID: 2876
		[Token(Token = "0x4000B3C")]
		[FieldOffset(Offset = "0x1C")]
		public readonly List<FilterListElement> ListElements;

		// Token: 0x04000B3D RID: 2877
		[Token(Token = "0x4000B3D")]
		[FieldOffset(Offset = "0x20")]
		private FilterListElement _selectedElement;

		// Token: 0x0200038E RID: 910
		[Token(Token = "0x200038E")]
		public class ListFilterData
		{
			// Token: 0x0600152D RID: 5421 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600152D")]
			[Address(RVA = "0x66EF", Offset = "0x66EF", VA = "0x66EF")]
			public ListFilterData()
			{
			}

			// Token: 0x04000B3E RID: 2878
			[Token(Token = "0x4000B3E")]
			[FieldOffset(Offset = "0x8")]
			public string Title;

			// Token: 0x04000B3F RID: 2879
			[Token(Token = "0x4000B3F")]
			[FieldOffset(Offset = "0xC")]
			public object Data;
		}
	}
}
