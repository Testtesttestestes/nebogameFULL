using System;
using AssetContent;
using Core.MVC.Interfaces;
using Gameplay.GdEvents.Control;
using Il2CppDummyDll;
using TMPro;
using UI.Rewards;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.GdEvents.View.EventView
{
	// Token: 0x02000745 RID: 1861
	[Token(Token = "0x2000745")]
	public class DescriptionEventSectionView : AbstractEventSectionView
	{
		// Token: 0x1700086C RID: 2156
		// (get) Token: 0x06002C4E RID: 11342 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700086C")]
		public GameAssetViewRawImage ArtRender
		{
			[Token(Token = "0x6002C4E")]
			[Address(RVA = "0x7CDD", Offset = "0x7CDD", VA = "0x7CDD")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700086D RID: 2157
		// (get) Token: 0x06002C4F RID: 11343 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700086D")]
		public TextMeshProUGUI Description
		{
			[Token(Token = "0x6002C4F")]
			[Address(RVA = "0x7CDE", Offset = "0x7CDE", VA = "0x7CDE")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700086E RID: 2158
		// (get) Token: 0x06002C50 RID: 11344 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700086E")]
		public Transform RewardsOwner
		{
			[Token(Token = "0x6002C50")]
			[Address(RVA = "0x7CDF", Offset = "0x7CDF", VA = "0x7CDF")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700086F RID: 2159
		// (get) Token: 0x06002C51 RID: 11345 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700086F")]
		public RewardsRender Rewards
		{
			[Token(Token = "0x6002C51")]
			[Address(RVA = "0x7CE0", Offset = "0x7CE0", VA = "0x7CE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000870 RID: 2160
		// (get) Token: 0x06002C52 RID: 11346 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000870")]
		public BackTimeView Timer
		{
			[Token(Token = "0x6002C52")]
			[Address(RVA = "0x7CE1", Offset = "0x7CE1", VA = "0x7CE1")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000871 RID: 2161
		// (get) Token: 0x06002C53 RID: 11347 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000871")]
		public Button AprsButton
		{
			[Token(Token = "0x6002C53")]
			[Address(RVA = "0x7CE2", Offset = "0x7CE2", VA = "0x7CE2")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000872 RID: 2162
		// (get) Token: 0x06002C54 RID: 11348 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000872")]
		public Button MedalsButton
		{
			[Token(Token = "0x6002C54")]
			[Address(RVA = "0x7CE3", Offset = "0x7CE3", VA = "0x7CE3")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000873 RID: 2163
		// (get) Token: 0x06002C55 RID: 11349 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000873")]
		public Button CollectionsButton
		{
			[Token(Token = "0x6002C55")]
			[Address(RVA = "0x7CE4", Offset = "0x7CE4", VA = "0x7CE4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000874 RID: 2164
		// (get) Token: 0x06002C56 RID: 11350 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000874")]
		public Button ItemsButton
		{
			[Token(Token = "0x6002C56")]
			[Address(RVA = "0x7CE5", Offset = "0x7CE5", VA = "0x7CE5")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000875 RID: 2165
		// (get) Token: 0x06002C57 RID: 11351 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000875")]
		public BattlePassGroupView BattlePassGroupView
		{
			[Token(Token = "0x6002C57")]
			[Address(RVA = "0x7CE6", Offset = "0x7CE6", VA = "0x7CE6")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002C58 RID: 11352 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C58")]
		[Address(RVA = "0x7CE7", Offset = "0x7CE7", VA = "0x7CE7", Slot = "5")]
		protected override void CreateMediator(ref IViewMediator mediator, GdEventsController controller)
		{
		}

		// Token: 0x06002C59 RID: 11353 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C59")]
		[Address(RVA = "0x7CE8", Offset = "0x7CE8", VA = "0x7CE8")]
		public DescriptionEventSectionView()
		{
		}

		// Token: 0x0400184A RID: 6218
		[Token(Token = "0x400184A")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private TextMeshProUGUI _description;

		// Token: 0x0400184B RID: 6219
		[Token(Token = "0x400184B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _rewardsOwner;

		// Token: 0x0400184C RID: 6220
		[Token(Token = "0x400184C")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private RewardsRender _rewards;

		// Token: 0x0400184D RID: 6221
		[Token(Token = "0x400184D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameAssetViewRawImage _artRender;

		// Token: 0x0400184E RID: 6222
		[Token(Token = "0x400184E")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private BackTimeView _timer;

		// Token: 0x0400184F RID: 6223
		[Token(Token = "0x400184F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Button _aprsButton;

		// Token: 0x04001850 RID: 6224
		[Token(Token = "0x4001850")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private Button _medalsButton;

		// Token: 0x04001851 RID: 6225
		[Token(Token = "0x4001851")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Button _collectionsButton;

		// Token: 0x04001852 RID: 6226
		[Token(Token = "0x4001852")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private Button _itemsButton;

		// Token: 0x04001853 RID: 6227
		[Token(Token = "0x4001853")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private BattlePassGroupView _battlePassGroupView;
	}
}
