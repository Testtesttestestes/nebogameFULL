using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Protocol.Dic;
using UI.Filters;
using UnityEngine;

namespace Gameplay.Craft.View
{
	// Token: 0x020008A8 RID: 2216
	[Token(Token = "0x20008A8")]
	public class CraftFiltersView : MonoBehaviour
	{
		// Token: 0x1400016D RID: 365
		// (add) Token: 0x06003408 RID: 13320 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06003409 RID: 13321 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400016D")]
		public event Action ChangedEvent
		{
			[Token(Token = "0x6003408")]
			[Address(RVA = "0x8435", Offset = "0x8435", VA = "0x8435")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6003409")]
			[Address(RVA = "0x8436", Offset = "0x8436", VA = "0x8436")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x0600340A RID: 13322 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600340A")]
		[Address(RVA = "0x8437", Offset = "0x8437", VA = "0x8437")]
		public void Init()
		{
		}

		// Token: 0x0600340B RID: 13323 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600340B")]
		[Address(RVA = "0x8438", Offset = "0x8438", VA = "0x8438")]
		private void FilterToggleClickedEventHandler(AbstractFilterToggleView<ArtikulTypeFilters> view)
		{
		}

		// Token: 0x0600340C RID: 13324 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600340C")]
		[Address(RVA = "0x8439", Offset = "0x8439", VA = "0x8439")]
		public CraftFiltersView()
		{
		}

		// Token: 0x04001C4D RID: 7245
		[Token(Token = "0x4001C4D")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private FilterToggleView _filterPrefab;

		// Token: 0x04001C4E RID: 7246
		[Token(Token = "0x4001C4E")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private RectTransform _contentParent;

		// Token: 0x04001C4F RID: 7247
		[Token(Token = "0x4001C4F")]
		[FieldOffset(Offset = "0x18")]
		public List<ArtikulTypeFilters> ActiveFilters;
	}
}
