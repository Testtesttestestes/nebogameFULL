using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Com.TheFallenGames.OSA.Core;
using Com.TheFallenGames.OSA.CustomParams;
using Com.TheFallenGames.OSA.DataHelpers;
using Gameplay.Boss.Model;
using Il2CppDummyDll;

namespace Gameplay.Boss.View.InvitesTab
{
	// Token: 0x02000B6E RID: 2926
	[Token(Token = "0x2000B6E")]
	public class BossInvitesListAdapter : OSA<BaseParamsWithPrefab, BossInviteItemViewHolder>
	{
		// Token: 0x140001BF RID: 447
		// (add) Token: 0x06004710 RID: 18192 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06004711 RID: 18193 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001BF")]
		public event Action<BossInviteData> SelectedEvent
		{
			[Token(Token = "0x6004710")]
			[Address(RVA = "0x95A6", Offset = "0x95A6", VA = "0x95A6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6004711")]
			[Address(RVA = "0x95A7", Offset = "0x95A7", VA = "0x95A7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000E25 RID: 3621
		// (get) Token: 0x06004712 RID: 18194 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004713 RID: 18195 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E25")]
		public SimpleDataHelper<BossInviteData> Data
		{
			[Token(Token = "0x6004712")]
			[Address(RVA = "0x95A8", Offset = "0x95A8", VA = "0x95A8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004713")]
			[Address(RVA = "0x95A9", Offset = "0x95A9", VA = "0x95A9")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000E26 RID: 3622
		// (get) Token: 0x06004714 RID: 18196 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000E26")]
		public BossInviteData SelectedItem
		{
			[Token(Token = "0x6004714")]
			[Address(RVA = "0x95AA", Offset = "0x95AA", VA = "0x95AA")]
			get
			{
				return null;
			}
		}

		// Token: 0x06004715 RID: 18197 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004715")]
		[Address(RVA = "0x95AB", Offset = "0x95AB", VA = "0x95AB", Slot = "67")]
		protected override void Awake()
		{
		}

		// Token: 0x06004716 RID: 18198 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004716")]
		[Address(RVA = "0x95AC", Offset = "0x95AC", VA = "0x95AC", Slot = "99")]
		protected override BossInviteItemViewHolder CreateViewsHolder(int itemIndex)
		{
			return null;
		}

		// Token: 0x06004717 RID: 18199 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004717")]
		[Address(RVA = "0x95AD", Offset = "0x95AD", VA = "0x95AD")]
		private void BossInviteItemViewOnClickEvent(BossInviteData data)
		{
		}

		// Token: 0x06004718 RID: 18200 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004718")]
		[Address(RVA = "0x95AE", Offset = "0x95AE", VA = "0x95AE")]
		public void Select(BossInviteData instanceInfo)
		{
		}

		// Token: 0x06004719 RID: 18201 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004719")]
		[Address(RVA = "0x95AF", Offset = "0x95AF", VA = "0x95AF", Slot = "105")]
		protected override void OnBeforeDestroyViewsHolder(BossInviteItemViewHolder vh, bool isActive)
		{
		}

		// Token: 0x0600471A RID: 18202 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600471A")]
		[Address(RVA = "0x95B0", Offset = "0x95B0", VA = "0x95B0", Slot = "100")]
		protected override void UpdateViewsHolder(BossInviteItemViewHolder newOrRecycled)
		{
		}

		// Token: 0x0600471B RID: 18203 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600471B")]
		[Address(RVA = "0x95B1", Offset = "0x95B1", VA = "0x95B1")]
		public void SetItems(List<BossInviteData> items)
		{
		}

		// Token: 0x0600471C RID: 18204 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600471C")]
		[Address(RVA = "0x95B2", Offset = "0x95B2", VA = "0x95B2")]
		public BossInvitesListAdapter()
		{
		}

		// Token: 0x040026FE RID: 9982
		[Token(Token = "0x40026FE")]
		[FieldOffset(Offset = "0xA8")]
		private BossInviteData _selectedItem;
	}
}
