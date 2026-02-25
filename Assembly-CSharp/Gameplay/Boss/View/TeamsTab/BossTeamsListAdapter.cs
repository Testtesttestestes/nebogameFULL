using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Com.TheFallenGames.OSA.Core;
using Com.TheFallenGames.OSA.CustomParams;
using Com.TheFallenGames.OSA.DataHelpers;
using Gameplay.Boss.Model;
using Il2CppDummyDll;

namespace Gameplay.Boss.View.TeamsTab
{
	// Token: 0x02000B55 RID: 2901
	[Token(Token = "0x2000B55")]
	public class BossTeamsListAdapter : OSA<BaseParamsWithPrefab, BossTeamsListItemViewHolder>
	{
		// Token: 0x17000DD6 RID: 3542
		// (get) Token: 0x06004632 RID: 17970 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004633 RID: 17971 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DD6")]
		public SimpleDataHelper<TeamRewardData> Data
		{
			[Token(Token = "0x6004632")]
			[Address(RVA = "0x94CB", Offset = "0x94CB", VA = "0x94CB")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004633")]
			[Address(RVA = "0x94CC", Offset = "0x94CC", VA = "0x94CC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x140001B1 RID: 433
		// (add) Token: 0x06004634 RID: 17972 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06004635 RID: 17973 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001B1")]
		public event Action<TeamRewardData> ClickEvent
		{
			[Token(Token = "0x6004634")]
			[Address(RVA = "0x94CD", Offset = "0x94CD", VA = "0x94CD")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6004635")]
			[Address(RVA = "0x94CE", Offset = "0x94CE", VA = "0x94CE")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06004636 RID: 17974 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004636")]
		[Address(RVA = "0x94CF", Offset = "0x94CF", VA = "0x94CF", Slot = "69")]
		protected override void Start()
		{
		}

		// Token: 0x06004637 RID: 17975 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004637")]
		[Address(RVA = "0x94D0", Offset = "0x94D0", VA = "0x94D0", Slot = "99")]
		protected override BossTeamsListItemViewHolder CreateViewsHolder(int itemIndex)
		{
			return null;
		}

		// Token: 0x06004638 RID: 17976 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004638")]
		[Address(RVA = "0x94D1", Offset = "0x94D1", VA = "0x94D1")]
		private void RendererOnButtonClickedEvent(TeamRewardData obj)
		{
		}

		// Token: 0x06004639 RID: 17977 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004639")]
		[Address(RVA = "0x94D2", Offset = "0x94D2", VA = "0x94D2", Slot = "105")]
		protected override void OnBeforeDestroyViewsHolder(BossTeamsListItemViewHolder vh, bool isActive)
		{
		}

		// Token: 0x0600463A RID: 17978 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600463A")]
		[Address(RVA = "0x94D3", Offset = "0x94D3", VA = "0x94D3", Slot = "100")]
		protected override void UpdateViewsHolder(BossTeamsListItemViewHolder newOrRecycled)
		{
		}

		// Token: 0x0600463B RID: 17979 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600463B")]
		[Address(RVA = "0x94D4", Offset = "0x94D4", VA = "0x94D4")]
		public void SetItems(List<TeamRewardData> items)
		{
		}

		// Token: 0x0600463C RID: 17980 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600463C")]
		[Address(RVA = "0x94D5", Offset = "0x94D5", VA = "0x94D5")]
		public BossTeamsListAdapter()
		{
		}
	}
}
