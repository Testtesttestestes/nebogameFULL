using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Data.InfoRows;
using Core.Gameplay.Managers.Requirements;
using Gameplay.Collections.Model.Factories;
using Gameplay.GdEvents.Model.Categories;
using Gameplay.GdEvents.Model.Milestone;
using Il2CppDummyDll;
using JetBrains.Annotations;
using Protocol.Dic;
using Utils;

namespace Gameplay.GdEvents.Model
{
	// Token: 0x0200074D RID: 1869
	[Token(Token = "0x200074D")]
	public class GdEventData : IDisposable
	{
		// Token: 0x1700088C RID: 2188
		// (get) Token: 0x06002C7E RID: 11390 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002C7F RID: 11391 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700088C")]
		[NotNull]
		public GameEventDic GameEventDic
		{
			[Token(Token = "0x6002C7E")]
			[Address(RVA = "0x7D0D", Offset = "0x7D0D", VA = "0x7D0D")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002C7F")]
			[Address(RVA = "0x7D0E", Offset = "0x7D0E", VA = "0x7D0E")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700088D RID: 2189
		// (get) Token: 0x06002C80 RID: 11392 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002C81 RID: 11393 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700088D")]
		[CanBeNull]
		public AbstractGdEventCatData Category
		{
			[Token(Token = "0x6002C80")]
			[Address(RVA = "0x7D0F", Offset = "0x7D0F", VA = "0x7D0F")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002C81")]
			[Address(RVA = "0x7D10", Offset = "0x7D10", VA = "0x7D10")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700088E RID: 2190
		// (get) Token: 0x06002C82 RID: 11394 RVA: 0x000087D8 File Offset: 0x000069D8
		// (set) Token: 0x06002C83 RID: 11395 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700088E")]
		public bool IsNewestInMainCategory
		{
			[Token(Token = "0x6002C82")]
			[Address(RVA = "0x7D11", Offset = "0x7D11", VA = "0x7D11")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002C83")]
			[Address(RVA = "0x7D12", Offset = "0x7D12", VA = "0x7D12")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700088F RID: 2191
		// (get) Token: 0x06002C84 RID: 11396 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002C85 RID: 11397 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700088F")]
		public UserData User
		{
			[Token(Token = "0x6002C84")]
			[Address(RVA = "0x7D13", Offset = "0x7D13", VA = "0x7D13")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002C85")]
			[Address(RVA = "0x7D14", Offset = "0x7D14", VA = "0x7D14")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000890 RID: 2192
		// (get) Token: 0x06002C86 RID: 11398 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002C87 RID: 11399 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000890")]
		public IRequirementValidator RequirementValidator
		{
			[Token(Token = "0x6002C86")]
			[Address(RVA = "0x7D15", Offset = "0x7D15", VA = "0x7D15")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002C87")]
			[Address(RVA = "0x7D16", Offset = "0x7D16", VA = "0x7D16")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000891 RID: 2193
		// (get) Token: 0x06002C88 RID: 11400 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002C89 RID: 11401 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000891")]
		public IRewardProvider RewardProvider
		{
			[Token(Token = "0x6002C88")]
			[Address(RVA = "0x7D17", Offset = "0x7D17", VA = "0x7D17")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002C89")]
			[Address(RVA = "0x7D18", Offset = "0x7D18", VA = "0x7D18")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000892 RID: 2194
		// (get) Token: 0x06002C8A RID: 11402 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002C8B RID: 11403 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000892")]
		public MilestoneData SelectedMilestone
		{
			[Token(Token = "0x6002C8A")]
			[Address(RVA = "0x7D19", Offset = "0x7D19", VA = "0x7D19")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002C8B")]
			[Address(RVA = "0x7D1A", Offset = "0x7D1A", VA = "0x7D1A")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06002C8C RID: 11404 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C8C")]
		[Address(RVA = "0x218D", Offset = "0x218D", VA = "0x218D", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x06002C8D RID: 11405 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C8D")]
		[Address(RVA = "0x7D1B", Offset = "0x7D1B", VA = "0x7D1B")]
		public GdEventData(GameEventDic gameEventDic, IRequirementValidator requirementValidator, IRewardProvider rewardProvider, UserData user, EventTabs tabs, ValueRow progressValueRow)
		{
		}

		// Token: 0x06002C8E RID: 11406 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C8E")]
		[Address(RVA = "0x7D1C", Offset = "0x7D1C", VA = "0x7D1C")]
		public void ResetMilestones()
		{
		}

		// Token: 0x06002C8F RID: 11407 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002C8F")]
		[Address(RVA = "0x7D1D", Offset = "0x7D1D", VA = "0x7D1D")]
		public List<MilestoneData> GetMilestones(ICollectionDataFactory collectionDataFactory)
		{
			return null;
		}

		// Token: 0x06002C90 RID: 11408 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002C90")]
		[Address(RVA = "0x7D1E", Offset = "0x7D1E", VA = "0x7D1E")]
		public ValueRow GetProgress()
		{
			return null;
		}

		// Token: 0x06002C91 RID: 11409 RVA: 0x000087F0 File Offset: 0x000069F0
		[Token(Token = "0x6002C91")]
		[Address(RVA = "0x2187", Offset = "0x2187", VA = "0x2187")]
		public float GetProgress(GameEventDic.Types.Milestone milestoneDic)
		{
			return 0f;
		}

		// Token: 0x06002C92 RID: 11410 RVA: 0x00008808 File Offset: 0x00006A08
		[Token(Token = "0x6002C92")]
		[Address(RVA = "0x7D1F", Offset = "0x7D1F", VA = "0x7D1F")]
		public float GetRoundedPercentage(GameEventDic.Types.Milestone milestoneDic)
		{
			return 0f;
		}

		// Token: 0x06002C93 RID: 11411 RVA: 0x00008820 File Offset: 0x00006A20
		[Token(Token = "0x6002C93")]
		[Address(RVA = "0x7D20", Offset = "0x7D20", VA = "0x7D20")]
		public MilestoneProgressState GetProgressState(MilestoneData milestone)
		{
			return MilestoneProgressState.Unknown;
		}

		// Token: 0x06002C94 RID: 11412 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C94")]
		[Address(RVA = "0x7D21", Offset = "0x7D21", VA = "0x7D21")]
		public void SetSelectedMileStone(MilestoneData value)
		{
		}

		// Token: 0x04001876 RID: 6262
		[Token(Token = "0x4001876")]
		[FieldOffset(Offset = "0x8")]
		[NotNull]
		public readonly EventTabs Tabs;

		// Token: 0x04001877 RID: 6263
		[Token(Token = "0x4001877")]
		[FieldOffset(Offset = "0xC")]
		[NotNull]
		public readonly BackTime BackTime;

		// Token: 0x0400187E RID: 6270
		[Token(Token = "0x400187E")]
		[FieldOffset(Offset = "0x28")]
		private List<MilestoneData> _milestones;

		// Token: 0x0400187F RID: 6271
		[Token(Token = "0x400187F")]
		[FieldOffset(Offset = "0x2C")]
		private readonly string _progressValueTextTemplate;

		// Token: 0x04001880 RID: 6272
		[Token(Token = "0x4001880")]
		[FieldOffset(Offset = "0x30")]
		private ValueRow _progressValueRow;
	}
}
