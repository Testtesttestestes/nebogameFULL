using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UI;
using UI.Tabs;
using UI.Toggle;
using UnityEngine;

namespace Gameplay.Auchan.View
{
	// Token: 0x02000C8B RID: 3211
	[Token(Token = "0x2000C8B")]
	public class AuchanView : MonoBehaviour
	{
		// Token: 0x17000FD8 RID: 4056
		// (get) Token: 0x06004E42 RID: 20034 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000FD8")]
		public SearchInput SearchInput
		{
			[Token(Token = "0x6004E42")]
			[Address(RVA = "0x9C74", Offset = "0x9C74", VA = "0x9C74")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000FD9 RID: 4057
		// (get) Token: 0x06004E43 RID: 20035 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000FD9")]
		public GreenToggle Toggle
		{
			[Token(Token = "0x6004E43")]
			[Address(RVA = "0x9C75", Offset = "0x9C75", VA = "0x9C75")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000FDA RID: 4058
		// (get) Token: 0x06004E44 RID: 20036 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000FDA")]
		public AuchanSortingFilter SortingFilter
		{
			[Token(Token = "0x6004E44")]
			[Address(RVA = "0x9C76", Offset = "0x9C76", VA = "0x9C76")]
			get
			{
				return null;
			}
		}

		// Token: 0x06004E45 RID: 20037 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E45")]
		[Address(RVA = "0x9C77", Offset = "0x9C77", VA = "0x9C77")]
		private void Start()
		{
		}

		// Token: 0x06004E46 RID: 20038 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E46")]
		[Address(RVA = "0x9C78", Offset = "0x9C78", VA = "0x9C78")]
		private void OnDestroy()
		{
		}

		// Token: 0x06004E47 RID: 20039 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E47")]
		[Address(RVA = "0x9C79", Offset = "0x9C79", VA = "0x9C79")]
		private void TabBarOnChangeEvent()
		{
		}

		// Token: 0x06004E48 RID: 20040 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E48")]
		[Address(RVA = "0x9C7A", Offset = "0x9C7A", VA = "0x9C7A")]
		public void SetData(List<AuchanArtifactCategoryData> data)
		{
		}

		// Token: 0x06004E49 RID: 20041 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E49")]
		[Address(RVA = "0x9C7B", Offset = "0x9C7B", VA = "0x9C7B")]
		private void RenderCategories()
		{
		}

		// Token: 0x06004E4A RID: 20042 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E4A")]
		[Address(RVA = "0x9C7C", Offset = "0x9C7C", VA = "0x9C7C")]
		private void ScrollToCategory(AuchanArtifactCategoryData cat)
		{
		}

		// Token: 0x06004E4B RID: 20043 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E4B")]
		[Address(RVA = "0x9C7D", Offset = "0x9C7D", VA = "0x9C7D")]
		public AuchanView()
		{
		}

		// Token: 0x04002AC0 RID: 10944
		[Token(Token = "0x4002AC0")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TabBar _tabBar;

		// Token: 0x04002AC1 RID: 10945
		[Token(Token = "0x4002AC1")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private AuchanGridOsaView _gridView;

		// Token: 0x04002AC2 RID: 10946
		[Token(Token = "0x4002AC2")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SearchInput _searchInput;

		// Token: 0x04002AC3 RID: 10947
		[Token(Token = "0x4002AC3")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private GreenToggle _toggle;

		// Token: 0x04002AC4 RID: 10948
		[Token(Token = "0x4002AC4")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AuchanSortingFilter _sortingFilter;

		// Token: 0x04002AC5 RID: 10949
		[Token(Token = "0x4002AC5")]
		[FieldOffset(Offset = "0x24")]
		private List<AuchanArtifactCategoryData> _categories;
	}
}
