using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using Gameplay.DailyQuests.Model;
using Il2CppDummyDll;
using JetBrains.Annotations;
using MVC;
using Protocol.Competition;
using UI.Tabs;
using Utils;

namespace Gameplay.Competition.Model
{
	// Token: 0x020008F1 RID: 2289
	[Token(Token = "0x20008F1")]
	public class CompetitionModel : AbstractModel
	{
		// Token: 0x17000AB5 RID: 2741
		// (get) Token: 0x060035F1 RID: 13809 RVA: 0x0000AE48 File Offset: 0x00009048
		// (set) Token: 0x060035F2 RID: 13810 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AB5")]
		public Sections CurrentSection
		{
			[Token(Token = "0x60035F1")]
			[Address(RVA = "0x85FE", Offset = "0x85FE", VA = "0x85FE")]
			[CompilerGenerated]
			get
			{
				return Sections.Unknown;
			}
			[Token(Token = "0x60035F2")]
			[Address(RVA = "0x85FF", Offset = "0x85FF", VA = "0x85FF")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000AB6 RID: 2742
		// (get) Token: 0x060035F3 RID: 13811 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060035F4 RID: 13812 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AB6")]
		public List<IDailyQuest> Quests
		{
			[Token(Token = "0x60035F3")]
			[Address(RVA = "0x8600", Offset = "0x8600", VA = "0x8600")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60035F4")]
			[Address(RVA = "0x8601", Offset = "0x8601", VA = "0x8601")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000AB7 RID: 2743
		// (get) Token: 0x060035F5 RID: 13813 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060035F6 RID: 13814 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AB7")]
		[CanBeNull]
		public CompetitionData Competition
		{
			[Token(Token = "0x60035F5")]
			[Address(RVA = "0x8602", Offset = "0x8602", VA = "0x8602")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60035F6")]
			[Address(RVA = "0x8603", Offset = "0x8603", VA = "0x8603")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000AB8 RID: 2744
		// (get) Token: 0x060035F7 RID: 13815 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000AB8")]
		[NotNull]
		public OwnerRating OwnerRating
		{
			[Token(Token = "0x60035F7")]
			[Address(RVA = "0x8604", Offset = "0x8604", VA = "0x8604")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000AB9 RID: 2745
		// (get) Token: 0x060035F8 RID: 13816 RVA: 0x0000AE60 File Offset: 0x00009060
		[Token(Token = "0x17000AB9")]
		public float FireAnimationTimeUntilEnd
		{
			[Token(Token = "0x60035F8")]
			[Address(RVA = "0x8605", Offset = "0x8605", VA = "0x8605")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
		}

		// Token: 0x060035F9 RID: 13817 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60035F9")]
		[Address(RVA = "0x8606", Offset = "0x8606", VA = "0x8606")]
		public CompetitionModel(OwnerRating ownerRating, IReadOnlyCollection<TabBarItemData<Sections>> sections, IReadOnlyDictionary<EventState, Sections[]> availSectionsByState, TabBarItemData<Sections> defaultSection, Dependencies dependencies)
		{
		}

		// Token: 0x060035FA RID: 13818 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60035FA")]
		[Address(RVA = "0x8607", Offset = "0x8607", VA = "0x8607")]
		public ReadOnlyCollection<TabBarItemData<Sections>> GetAvailSections(EventState state)
		{
			return null;
		}

		// Token: 0x060035FB RID: 13819 RVA: 0x0000AE78 File Offset: 0x00009078
		[Token(Token = "0x60035FB")]
		[Address(RVA = "0x8608", Offset = "0x8608", VA = "0x8608")]
		public int GetCompletedQuestsWithPendingRewardCount()
		{
			return 0;
		}

		// Token: 0x04001D93 RID: 7571
		[Token(Token = "0x4001D93")]
		[FieldOffset(Offset = "0xC")]
		public readonly Dependencies Dependencies;

		// Token: 0x04001D94 RID: 7572
		[Token(Token = "0x4001D94")]
		[FieldOffset(Offset = "0x10")]
		public readonly TabBarItemData DefaultSection;

		// Token: 0x04001D95 RID: 7573
		[Token(Token = "0x4001D95")]
		[FieldOffset(Offset = "0x14")]
		private readonly IReadOnlyDictionary<EventState, Sections[]> _availSectionsByState;

		// Token: 0x04001D96 RID: 7574
		[Token(Token = "0x4001D96")]
		[FieldOffset(Offset = "0x18")]
		private readonly List<TabBarItemData<Sections>> _sections;

		// Token: 0x04001D97 RID: 7575
		[Token(Token = "0x4001D97")]
		[FieldOffset(Offset = "0x1C")]
		private readonly List<TabBarItemData<Sections>> _availSections;

		// Token: 0x04001D98 RID: 7576
		[Token(Token = "0x4001D98")]
		[FieldOffset(Offset = "0x20")]
		public BackTime BackTime;
	}
}
