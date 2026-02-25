using System;
using System.Collections.Generic;
using Core.MVC.Interfaces;
using Gameplay.GdEvents.Control;
using Gameplay.GdEvents.Model.Milestone;
using Gameplay.GdEvents.View.Milestone;
using Gameplay.GdEvents.View.Milestone.Activity;
using Gameplay.GdEvents.View.Milestone.StageContent;
using Gameplay.GdEvents.View.Milestone.StageContent.Avatars;
using Gameplay.GdEvents.View.Milestone.StageContent.Collections;
using Gameplay.GdEvents.View.Milestone.StageContent.Gifts;
using Gameplay.GdEvents.View.Milestone.StageContent.Medals;
using Gameplay.GdEvents.View.Milestone.StageContent.Monsters;
using Il2CppDummyDll;
using TMPro;
using UI.Requirements;
using UI.Rewards;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gameplay.GdEvents.View.EventView
{
	// Token: 0x02000748 RID: 1864
	[Token(Token = "0x2000748")]
	public class MilestonesEventSectionView : AbstractEventSectionView
	{
		// Token: 0x1700087A RID: 2170
		// (get) Token: 0x06002C62 RID: 11362 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700087A")]
		public TextMeshProUGUI Title
		{
			[Token(Token = "0x6002C62")]
			[Address(RVA = "0x7CF1", Offset = "0x7CF1", VA = "0x7CF1")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700087B RID: 2171
		// (get) Token: 0x06002C63 RID: 11363 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700087B")]
		public TextMeshProUGUI Description
		{
			[Token(Token = "0x6002C63")]
			[Address(RVA = "0x7CF2", Offset = "0x7CF2", VA = "0x7CF2")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700087C RID: 2172
		// (get) Token: 0x06002C64 RID: 11364 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700087C")]
		public MilestonesListOsaView List
		{
			[Token(Token = "0x6002C64")]
			[Address(RVA = "0x7CF3", Offset = "0x7CF3", VA = "0x7CF3")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700087D RID: 2173
		// (get) Token: 0x06002C65 RID: 11365 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700087D")]
		public ScrollRect ContentScroll
		{
			[Token(Token = "0x6002C65")]
			[Address(RVA = "0x7CF4", Offset = "0x7CF4", VA = "0x7CF4")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700087E RID: 2174
		// (get) Token: 0x06002C66 RID: 11366 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700087E")]
		public RequirementsView Requirements
		{
			[Token(Token = "0x6002C66")]
			[Address(RVA = "0x7CF5", Offset = "0x7CF5", VA = "0x7CF5")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700087F RID: 2175
		// (get) Token: 0x06002C67 RID: 11367 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700087F")]
		public Transform RewardsOwner
		{
			[Token(Token = "0x6002C67")]
			[Address(RVA = "0x7CF6", Offset = "0x7CF6", VA = "0x7CF6")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000880 RID: 2176
		// (get) Token: 0x06002C68 RID: 11368 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000880")]
		public RewardsRender Rewards
		{
			[Token(Token = "0x6002C68")]
			[Address(RVA = "0x7CF7", Offset = "0x7CF7", VA = "0x7CF7")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000881 RID: 2177
		// (get) Token: 0x06002C69 RID: 11369 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000881")]
		public Transform Stages
		{
			[Token(Token = "0x6002C69")]
			[Address(RVA = "0x7CF8", Offset = "0x7CF8", VA = "0x7CF8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000882 RID: 2178
		// (get) Token: 0x06002C6A RID: 11370 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000882")]
		public Transform Activity
		{
			[Token(Token = "0x6002C6A")]
			[Address(RVA = "0x7CF9", Offset = "0x7CF9", VA = "0x7CF9")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000883 RID: 2179
		// (get) Token: 0x06002C6B RID: 11371 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000883")]
		public ArtkulsStageContentGroupView ArtikulsContent
		{
			[Token(Token = "0x6002C6B")]
			[Address(RVA = "0x7CFA", Offset = "0x7CFA", VA = "0x7CFA")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000884 RID: 2180
		// (get) Token: 0x06002C6C RID: 11372 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000884")]
		public MedalsStageContentGroupView MedalsContent
		{
			[Token(Token = "0x6002C6C")]
			[Address(RVA = "0x7CFB", Offset = "0x7CFB", VA = "0x7CFB")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000885 RID: 2181
		// (get) Token: 0x06002C6D RID: 11373 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000885")]
		public AvatarsStageContentGroupView AvatarsContent
		{
			[Token(Token = "0x6002C6D")]
			[Address(RVA = "0x7CFC", Offset = "0x7CFC", VA = "0x7CFC")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000886 RID: 2182
		// (get) Token: 0x06002C6E RID: 11374 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000886")]
		public CollectionsStageContentGroupView CollectionsContent
		{
			[Token(Token = "0x6002C6E")]
			[Address(RVA = "0x7CFD", Offset = "0x7CFD", VA = "0x7CFD")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000887 RID: 2183
		// (get) Token: 0x06002C6F RID: 11375 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000887")]
		public MonstersStageContentGroupView MonstersContent
		{
			[Token(Token = "0x6002C6F")]
			[Address(RVA = "0x7CFE", Offset = "0x7CFE", VA = "0x7CFE")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000888 RID: 2184
		// (get) Token: 0x06002C70 RID: 11376 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000888")]
		public GiftsStageContentGroupView GiftsContent
		{
			[Token(Token = "0x6002C70")]
			[Address(RVA = "0x7CFF", Offset = "0x7CFF", VA = "0x7CFF")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002C71 RID: 11377 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C71")]
		[Address(RVA = "0x7D00", Offset = "0x7D00", VA = "0x7D00", Slot = "4")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x06002C72 RID: 11378 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C72")]
		[Address(RVA = "0x7D01", Offset = "0x7D01", VA = "0x7D01", Slot = "5")]
		protected override void CreateMediator(ref IViewMediator mediator, GdEventsController controller)
		{
		}

		// Token: 0x06002C73 RID: 11379 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C73")]
		[Address(RVA = "0x7D02", Offset = "0x7D02", VA = "0x7D02")]
		private void HandleActivityClickEvent(GameActivityData activity)
		{
		}

		// Token: 0x06002C74 RID: 11380 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C74")]
		[Address(RVA = "0x7D03", Offset = "0x7D03", VA = "0x7D03")]
		public void SetActivities(IEnumerable<ActivityGroupData> activities)
		{
		}

		// Token: 0x06002C75 RID: 11381 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C75")]
		[Address(RVA = "0x7D04", Offset = "0x7D04", VA = "0x7D04")]
		public MilestonesEventSectionView()
		{
		}

		// Token: 0x0400185A RID: 6234
		[Token(Token = "0x400185A")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x0400185B RID: 6235
		[Token(Token = "0x400185B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TextMeshProUGUI _description;

		// Token: 0x0400185C RID: 6236
		[Token(Token = "0x400185C")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private ScrollRect _contentScroll;

		// Token: 0x0400185D RID: 6237
		[Token(Token = "0x400185D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private MilestonesListOsaView _list;

		// Token: 0x0400185E RID: 6238
		[Token(Token = "0x400185E")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private RequirementsView _requirements;

		// Token: 0x0400185F RID: 6239
		[Token(Token = "0x400185F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform _rewardsOwner;

		// Token: 0x04001860 RID: 6240
		[Token(Token = "0x4001860")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private RewardsRender _rewards;

		// Token: 0x04001861 RID: 6241
		[Token(Token = "0x4001861")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Transform _stages;

		// Token: 0x04001862 RID: 6242
		[Token(Token = "0x4001862")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private Transform _activity;

		// Token: 0x04001863 RID: 6243
		[Token(Token = "0x4001863")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Transform _activityContent;

		// Token: 0x04001864 RID: 6244
		[Token(Token = "0x4001864")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private GameActivityContentGroupView _activityGroupPrefab;

		// Token: 0x04001865 RID: 6245
		[Token(Token = "0x4001865")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private ArtkulsStageContentGroupView _artikulsContent;

		// Token: 0x04001866 RID: 6246
		[Token(Token = "0x4001866")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private MedalsStageContentGroupView _medalsContent;

		// Token: 0x04001867 RID: 6247
		[Token(Token = "0x4001867")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private AvatarsStageContentGroupView _avatarsContent;

		// Token: 0x04001868 RID: 6248
		[Token(Token = "0x4001868")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private CollectionsStageContentGroupView _collectionsContent;

		// Token: 0x04001869 RID: 6249
		[Token(Token = "0x4001869")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private MonstersStageContentGroupView _monstersContent;

		// Token: 0x0400186A RID: 6250
		[Token(Token = "0x400186A")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private GiftsStageContentGroupView _giftsContent;

		// Token: 0x0400186B RID: 6251
		[Token(Token = "0x400186B")]
		[FieldOffset(Offset = "0x60")]
		[NonSerialized]
		public UnityEvent<GameActivityData> ActivityItemClickEvent;
	}
}
