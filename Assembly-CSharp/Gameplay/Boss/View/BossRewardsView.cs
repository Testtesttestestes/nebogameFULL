using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gameplay.Boss.Controller;
using Gameplay.Boss.Model;
using Il2CppDummyDll;
using UI.Rewards;
using UnityEngine;

namespace Gameplay.Boss.View
{
	// Token: 0x02000B51 RID: 2897
	[Token(Token = "0x2000B51")]
	public class BossRewardsView : AbstractBossWindowView<BossRewardsView, BossRewardsViewMediator>
	{
		// Token: 0x17000DCB RID: 3531
		// (get) Token: 0x06004611 RID: 17937 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000DCB")]
		public RectTransform RewardsContainer
		{
			[Token(Token = "0x6004611")]
			[Address(RVA = "0x94AA", Offset = "0x94AA", VA = "0x94AA")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000DCC RID: 3532
		// (get) Token: 0x06004612 RID: 17938 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000DCC")]
		public RewardsRender CaptainRewardsRender
		{
			[Token(Token = "0x6004612")]
			[Address(RVA = "0x94AB", Offset = "0x94AB", VA = "0x94AB")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000DCD RID: 3533
		// (get) Token: 0x06004613 RID: 17939 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000DCD")]
		public RewardsRender AssistantRewardsRender
		{
			[Token(Token = "0x6004613")]
			[Address(RVA = "0x94AC", Offset = "0x94AC", VA = "0x94AC")]
			get
			{
				return null;
			}
		}

		// Token: 0x140001B0 RID: 432
		// (add) Token: 0x06004614 RID: 17940 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06004615 RID: 17941 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001B0")]
		public event Action<BossInfo.BossRewardRangeData> SelectedEvent
		{
			[Token(Token = "0x6004614")]
			[Address(RVA = "0x94AD", Offset = "0x94AD", VA = "0x94AD")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6004615")]
			[Address(RVA = "0x94AE", Offset = "0x94AE", VA = "0x94AE")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000DCE RID: 3534
		// (get) Token: 0x06004616 RID: 17942 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000DCE")]
		public BossInfo.BossRewardRangeData SelectedItem
		{
			[Token(Token = "0x6004616")]
			[Address(RVA = "0x94AF", Offset = "0x94AF", VA = "0x94AF")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000DCF RID: 3535
		// (get) Token: 0x06004617 RID: 17943 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004618 RID: 17944 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DCF")]
		public List<BossInfo.BossRewardRangeData> Data
		{
			[Token(Token = "0x6004617")]
			[Address(RVA = "0x94B0", Offset = "0x94B0", VA = "0x94B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004618")]
			[Address(RVA = "0x94B1", Offset = "0x94B1", VA = "0x94B1")]
			set
			{
			}
		}

		// Token: 0x06004619 RID: 17945 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004619")]
		[Address(RVA = "0x94B2", Offset = "0x94B2", VA = "0x94B2")]
		private void ItemOnClickEvent(BossRewardListItemView itemView)
		{
		}

		// Token: 0x0600461A RID: 17946 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600461A")]
		[Address(RVA = "0x94B3", Offset = "0x94B3", VA = "0x94B3")]
		public void Select(BossInfo.BossRewardRangeData data)
		{
		}

		// Token: 0x0600461B RID: 17947 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600461B")]
		[Address(RVA = "0x94B4", Offset = "0x94B4", VA = "0x94B4", Slot = "5")]
		protected override BossRewardsViewMediator CreateMediator()
		{
			return null;
		}

		// Token: 0x0600461C RID: 17948 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600461C")]
		[Address(RVA = "0x94B5", Offset = "0x94B5", VA = "0x94B5", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x0600461D RID: 17949 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600461D")]
		[Address(RVA = "0x94B6", Offset = "0x94B6", VA = "0x94B6")]
		public BossRewardsView()
		{
		}

		// Token: 0x04002654 RID: 9812
		[Token(Token = "0x4002654")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private Transform _container;

		// Token: 0x04002655 RID: 9813
		[Token(Token = "0x4002655")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RewardsRender _captainRewardsRender;

		// Token: 0x04002656 RID: 9814
		[Token(Token = "0x4002656")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private RectTransform _rewardsContainer;

		// Token: 0x04002657 RID: 9815
		[Token(Token = "0x4002657")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RewardsRender _assistantRewardsRender;

		// Token: 0x04002658 RID: 9816
		[Token(Token = "0x4002658")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private BossRewardListItemView _listItemPrefab;

		// Token: 0x04002659 RID: 9817
		[Token(Token = "0x4002659")]
		[FieldOffset(Offset = "0x38")]
		private List<BossRewardListItemView> _items;

		// Token: 0x0400265B RID: 9819
		[Token(Token = "0x400265B")]
		[FieldOffset(Offset = "0x40")]
		private BossInfo.BossRewardRangeData _selectedItem;

		// Token: 0x0400265C RID: 9820
		[Token(Token = "0x400265C")]
		[FieldOffset(Offset = "0x44")]
		private List<BossInfo.BossRewardRangeData> _data;
	}
}
