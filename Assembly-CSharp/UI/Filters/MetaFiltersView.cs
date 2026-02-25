using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Protocol.Dic;
using UnityEngine;

namespace UI.Filters
{
	// Token: 0x020001E6 RID: 486
	[Token(Token = "0x20001E6")]
	public class MetaFiltersView : MonoBehaviour
	{
		// Token: 0x140000E6 RID: 230
		// (add) Token: 0x06000C8F RID: 3215 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000C90 RID: 3216 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000E6")]
		public event Action ChangedEvent
		{
			[Token(Token = "0x6000C8F")]
			[Address(RVA = "0x5F92", Offset = "0x5F92", VA = "0x5F92")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000C90")]
			[Address(RVA = "0x5F93", Offset = "0x5F93", VA = "0x5F93")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x06000C91 RID: 3217 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000C92 RID: 3218 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001A3")]
		public FilterInfo FilterInfo
		{
			[Token(Token = "0x6000C91")]
			[Address(RVA = "0x5F94", Offset = "0x5F94", VA = "0x5F94")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000C92")]
			[Address(RVA = "0x5F95", Offset = "0x5F95", VA = "0x5F95")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x06000C93 RID: 3219 RVA: 0x00003EA0 File Offset: 0x000020A0
		// (set) Token: 0x06000C94 RID: 3220 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001A4")]
		public ArtikulTypeFilters.Types.FilterType FilterType
		{
			[Token(Token = "0x6000C93")]
			[Address(RVA = "0x5F96", Offset = "0x5F96", VA = "0x5F96")]
			[CompilerGenerated]
			get
			{
				return ArtikulTypeFilters.Types.FilterType.UnknownFilterType;
			}
			[Token(Token = "0x6000C94")]
			[Address(RVA = "0x5F97", Offset = "0x5F97", VA = "0x5F97")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000C95 RID: 3221 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C95")]
		[Address(RVA = "0x5F98", Offset = "0x5F98", VA = "0x5F98")]
		public void Init(ArtikulTypeFilters.Types.FilterType type, Dictionary<uint, ArtikulTypeFilters> allFilters)
		{
		}

		// Token: 0x06000C96 RID: 3222 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C96")]
		[Address(RVA = "0x5F99", Offset = "0x5F99", VA = "0x5F99")]
		private void FilterToggleClickedEventHandler(AbstractFilterToggleView<MetaFilterData<ArtikulTypeMetaFilterDic, ArtikulTypeFilters>> view)
		{
		}

		// Token: 0x06000C97 RID: 3223 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C97")]
		[Address(RVA = "0x5F9A", Offset = "0x5F9A", VA = "0x5F9A")]
		public MetaFiltersView()
		{
		}

		// Token: 0x04000618 RID: 1560
		[Token(Token = "0x4000618")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private MetaFilterToggleView _filterPrefab;

		// Token: 0x04000619 RID: 1561
		[Token(Token = "0x4000619")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private RectTransform _contentParent;

		// Token: 0x0400061A RID: 1562
		[Token(Token = "0x400061A")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<uint, ArtikulTypeMetaFilterDic> _selectedMetaFilters;

		// Token: 0x0400061B RID: 1563
		[Token(Token = "0x400061B")]
		[FieldOffset(Offset = "0x1C")]
		public readonly List<ArtikulTypeMetaFilterDic> ActiveMetaFilters;
	}
}
