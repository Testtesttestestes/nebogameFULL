using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Gameplay.Medals.View;
using Il2CppDummyDll;
using UI.Tabs;
using UnityEngine;

namespace Gameplay.Inventory.View.Chest
{
	// Token: 0x02000697 RID: 1687
	[Token(Token = "0x2000697")]
	public class MedalsGridView : MonoBehaviour
	{
		// Token: 0x170007B5 RID: 1973
		// (get) Token: 0x060028BB RID: 10427 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060028BC RID: 10428 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007B5")]
		public UserData User
		{
			[Token(Token = "0x60028BB")]
			[Address(RVA = "0x79D9", Offset = "0x79D9", VA = "0x79D9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60028BC")]
			[Address(RVA = "0x79DA", Offset = "0x79DA", VA = "0x79DA")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170007B6 RID: 1974
		// (get) Token: 0x060028BD RID: 10429 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060028BE RID: 10430 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007B6")]
		public UserData LoggedUser
		{
			[Token(Token = "0x60028BD")]
			[Address(RVA = "0x79DB", Offset = "0x79DB", VA = "0x79DB")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60028BE")]
			[Address(RVA = "0x79DC", Offset = "0x79DC", VA = "0x79DC")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060028BF RID: 10431 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028BF")]
		[Address(RVA = "0x79DD", Offset = "0x79DD", VA = "0x79DD")]
		private void OnDestroy()
		{
		}

		// Token: 0x060028C0 RID: 10432 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028C0")]
		[Address(RVA = "0x79DE", Offset = "0x79DE", VA = "0x79DE")]
		private void Start()
		{
		}

		// Token: 0x060028C1 RID: 10433 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028C1")]
		[Address(RVA = "0x79DF", Offset = "0x79DF", VA = "0x79DF")]
		private void TabBarOnChangeEvent()
		{
		}

		// Token: 0x060028C2 RID: 10434 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028C2")]
		[Address(RVA = "0x79E0", Offset = "0x79E0", VA = "0x79E0")]
		public void SetData(List<MedalsCategoryData> data, Action<MedalView> medalViewClickCallback, bool saleEnabled)
		{
		}

		// Token: 0x060028C3 RID: 10435 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028C3")]
		[Address(RVA = "0x79E1", Offset = "0x79E1", VA = "0x79E1")]
		private void RenderCategories()
		{
		}

		// Token: 0x060028C4 RID: 10436 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028C4")]
		[Address(RVA = "0x79E2", Offset = "0x79E2", VA = "0x79E2")]
		private void ScrollToCategory(MedalsCategoryData cat)
		{
		}

		// Token: 0x060028C5 RID: 10437 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028C5")]
		[Address(RVA = "0x79E3", Offset = "0x79E3", VA = "0x79E3")]
		public void SelectDefaultTab()
		{
		}

		// Token: 0x060028C6 RID: 10438 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028C6")]
		[Address(RVA = "0x79E4", Offset = "0x79E4", VA = "0x79E4")]
		public MedalsGridView()
		{
		}

		// Token: 0x0400167F RID: 5759
		[Token(Token = "0x400167F")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TabBar _tabBar;

		// Token: 0x04001680 RID: 5760
		[Token(Token = "0x4001680")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private MedalsGridOsaView _medalsGridOsaView;

		// Token: 0x04001681 RID: 5761
		[Token(Token = "0x4001681")]
		[FieldOffset(Offset = "0x18")]
		private List<MedalsCategoryData> _categories;

		// Token: 0x04001682 RID: 5762
		[Token(Token = "0x4001682")]
		[FieldOffset(Offset = "0x1C")]
		private TabBarItemData _currentTab;
	}
}
