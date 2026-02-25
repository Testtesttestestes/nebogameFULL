using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Com.TheFallenGames.OSA.Core;
using Com.TheFallenGames.OSA.CustomParams;
using Com.TheFallenGames.OSA.DataHelpers;
using Gameplay.Boss.Model;
using Il2CppDummyDll;

namespace Gameplay.Boss.View.ListView
{
	// Token: 0x02000B68 RID: 2920
	[Token(Token = "0x2000B68")]
	public class BossListAdapter : OSA<BaseParamsWithPrefab, BossListItemViewHolder>
	{
		// Token: 0x17000E11 RID: 3601
		// (get) Token: 0x060046D3 RID: 18131 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060046D4 RID: 18132 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E11")]
		public SimpleDataHelper<BossInstance> Data
		{
			[Token(Token = "0x60046D3")]
			[Address(RVA = "0x9569", Offset = "0x9569", VA = "0x9569")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60046D4")]
			[Address(RVA = "0x956A", Offset = "0x956A", VA = "0x956A")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x140001BA RID: 442
		// (add) Token: 0x060046D5 RID: 18133 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060046D6 RID: 18134 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001BA")]
		public event Action<BossInstance> SelectedEvent
		{
			[Token(Token = "0x60046D5")]
			[Address(RVA = "0x956B", Offset = "0x956B", VA = "0x956B")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60046D6")]
			[Address(RVA = "0x956C", Offset = "0x956C", VA = "0x956C")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140001BB RID: 443
		// (add) Token: 0x060046D7 RID: 18135 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060046D8 RID: 18136 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001BB")]
		public event Action<BossInstance> QuestionButtonClickedEvent
		{
			[Token(Token = "0x60046D7")]
			[Address(RVA = "0x956D", Offset = "0x956D", VA = "0x956D")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60046D8")]
			[Address(RVA = "0x956E", Offset = "0x956E", VA = "0x956E")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000E12 RID: 3602
		// (get) Token: 0x060046D9 RID: 18137 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000E12")]
		public BossInstance SelectedItem
		{
			[Token(Token = "0x60046D9")]
			[Address(RVA = "0x956F", Offset = "0x956F", VA = "0x956F")]
			get
			{
				return null;
			}
		}

		// Token: 0x060046DA RID: 18138 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60046DA")]
		[Address(RVA = "0x9570", Offset = "0x9570", VA = "0x9570", Slot = "67")]
		protected override void Awake()
		{
		}

		// Token: 0x060046DB RID: 18139 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60046DB")]
		[Address(RVA = "0x9571", Offset = "0x9571", VA = "0x9571", Slot = "99")]
		protected override BossListItemViewHolder CreateViewsHolder(int itemIndex)
		{
			return null;
		}

		// Token: 0x060046DC RID: 18140 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60046DC")]
		[Address(RVA = "0x9572", Offset = "0x9572", VA = "0x9572")]
		private void BossListItemViewOnQuestionClickedEvent(BossInstance data)
		{
		}

		// Token: 0x060046DD RID: 18141 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60046DD")]
		[Address(RVA = "0x9573", Offset = "0x9573", VA = "0x9573")]
		private void BossListItemViewOnSelectedEvent(BossInstance bossInstance)
		{
		}

		// Token: 0x060046DE RID: 18142 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60046DE")]
		[Address(RVA = "0x9574", Offset = "0x9574", VA = "0x9574")]
		public void Select(BossInstance instanceInfo)
		{
		}

		// Token: 0x060046DF RID: 18143 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60046DF")]
		[Address(RVA = "0x9575", Offset = "0x9575", VA = "0x9575", Slot = "100")]
		protected override void UpdateViewsHolder(BossListItemViewHolder newOrRecycled)
		{
		}

		// Token: 0x060046E0 RID: 18144 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60046E0")]
		[Address(RVA = "0x9576", Offset = "0x9576", VA = "0x9576", Slot = "105")]
		protected override void OnBeforeDestroyViewsHolder(BossListItemViewHolder vh, bool isActive)
		{
		}

		// Token: 0x060046E1 RID: 18145 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60046E1")]
		[Address(RVA = "0x9577", Offset = "0x9577", VA = "0x9577")]
		public void AddItemsAt(int index, IList<BossInstance> items)
		{
		}

		// Token: 0x060046E2 RID: 18146 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60046E2")]
		[Address(RVA = "0x9578", Offset = "0x9578", VA = "0x9578")]
		public void RemoveItemsFrom(int index, int count)
		{
		}

		// Token: 0x060046E3 RID: 18147 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60046E3")]
		[Address(RVA = "0x9579", Offset = "0x9579", VA = "0x9579")]
		public void SetItems(IList<BossInstance> items)
		{
		}

		// Token: 0x060046E4 RID: 18148 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60046E4")]
		[Address(RVA = "0x957A", Offset = "0x957A", VA = "0x957A")]
		public BossListAdapter()
		{
		}

		// Token: 0x040026D0 RID: 9936
		[Token(Token = "0x40026D0")]
		[FieldOffset(Offset = "0xAC")]
		private BossInstance _selectedItem;
	}
}
