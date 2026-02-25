using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Com.TheFallenGames.OSA.Core;
using Com.TheFallenGames.OSA.CustomParams;
using Com.TheFallenGames.OSA.DataHelpers;
using Gameplay.Boss.Model;
using Il2CppDummyDll;

namespace Gameplay.Boss.View.RatingTab
{
	// Token: 0x02000B63 RID: 2915
	[Token(Token = "0x2000B63")]
	public class BossRatingListAdapter : OSA<BaseParamsWithPrefab, BossRatingListItemViewHolder>
	{
		// Token: 0x17000E03 RID: 3587
		// (get) Token: 0x060046A8 RID: 18088 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060046A9 RID: 18089 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E03")]
		public SimpleDataHelper<BossCaptainRatingData> Data
		{
			[Token(Token = "0x60046A8")]
			[Address(RVA = "0x953E", Offset = "0x953E", VA = "0x953E")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60046A9")]
			[Address(RVA = "0x953F", Offset = "0x953F", VA = "0x953F")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x140001B8 RID: 440
		// (add) Token: 0x060046AA RID: 18090 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060046AB RID: 18091 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001B8")]
		public event Action<BossCaptainRatingData> ClickEvent
		{
			[Token(Token = "0x60046AA")]
			[Address(RVA = "0x9540", Offset = "0x9540", VA = "0x9540")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60046AB")]
			[Address(RVA = "0x9541", Offset = "0x9541", VA = "0x9541")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x060046AC RID: 18092 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60046AC")]
		[Address(RVA = "0x9542", Offset = "0x9542", VA = "0x9542", Slot = "69")]
		protected override void Start()
		{
		}

		// Token: 0x060046AD RID: 18093 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60046AD")]
		[Address(RVA = "0x9543", Offset = "0x9543", VA = "0x9543", Slot = "99")]
		protected override BossRatingListItemViewHolder CreateViewsHolder(int itemIndex)
		{
			return null;
		}

		// Token: 0x060046AE RID: 18094 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60046AE")]
		[Address(RVA = "0x9544", Offset = "0x9544", VA = "0x9544")]
		private void RendererOnClickEvent(BossCaptainRatingData data)
		{
		}

		// Token: 0x060046AF RID: 18095 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60046AF")]
		[Address(RVA = "0x9545", Offset = "0x9545", VA = "0x9545", Slot = "100")]
		protected override void UpdateViewsHolder(BossRatingListItemViewHolder newOrRecycled)
		{
		}

		// Token: 0x060046B0 RID: 18096 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60046B0")]
		[Address(RVA = "0x9546", Offset = "0x9546", VA = "0x9546", Slot = "105")]
		protected override void OnBeforeDestroyViewsHolder(BossRatingListItemViewHolder vh, bool isActive)
		{
		}

		// Token: 0x060046B1 RID: 18097 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60046B1")]
		[Address(RVA = "0x9547", Offset = "0x9547", VA = "0x9547")]
		public void AddItemsAt(int index, IList<BossCaptainRatingData> items)
		{
		}

		// Token: 0x060046B2 RID: 18098 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60046B2")]
		[Address(RVA = "0x9548", Offset = "0x9548", VA = "0x9548")]
		public void RemoveItemsFrom(int index, int count)
		{
		}

		// Token: 0x060046B3 RID: 18099 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60046B3")]
		[Address(RVA = "0x9549", Offset = "0x9549", VA = "0x9549")]
		public void SetItems(IList<BossCaptainRatingData> items)
		{
		}

		// Token: 0x060046B4 RID: 18100 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60046B4")]
		[Address(RVA = "0x954A", Offset = "0x954A", VA = "0x954A")]
		public BossRatingListAdapter()
		{
		}
	}
}
