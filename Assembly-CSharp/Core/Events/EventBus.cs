using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Events.Scopes;
using Il2CppDummyDll;

namespace Core.Events
{
	// Token: 0x02000FB8 RID: 4024
	[Token(Token = "0x2000FB8")]
	public class EventBus : IDisposable
	{
		// Token: 0x170012D4 RID: 4820
		// (get) Token: 0x0600602B RID: 24619 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600602C RID: 24620 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170012D4")]
		public AuthScope AuthScope
		{
			[Token(Token = "0x600602B")]
			[Address(RVA = "0xAC58", Offset = "0xAC58", VA = "0xAC58")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600602C")]
			[Address(RVA = "0xAC59", Offset = "0xAC59", VA = "0xAC59")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170012D5 RID: 4821
		// (get) Token: 0x0600602D RID: 24621 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600602E RID: 24622 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170012D5")]
		public UserScope UserScope
		{
			[Token(Token = "0x600602D")]
			[Address(RVA = "0xAC5A", Offset = "0xAC5A", VA = "0xAC5A")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600602E")]
			[Address(RVA = "0xAC5B", Offset = "0xAC5B", VA = "0xAC5B")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170012D6 RID: 4822
		// (get) Token: 0x0600602F RID: 24623 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006030 RID: 24624 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170012D6")]
		public Tutorial2Scope Tutorial2Scope
		{
			[Token(Token = "0x600602F")]
			[Address(RVA = "0xAC5C", Offset = "0xAC5C", VA = "0xAC5C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006030")]
			[Address(RVA = "0xAC5D", Offset = "0xAC5D", VA = "0xAC5D")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170012D7 RID: 4823
		// (get) Token: 0x06006031 RID: 24625 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006032 RID: 24626 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170012D7")]
		public AnalyticsEventMediatorScope AnalyticsEventMediatorScope
		{
			[Token(Token = "0x6006031")]
			[Address(RVA = "0xAC5E", Offset = "0xAC5E", VA = "0xAC5E")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006032")]
			[Address(RVA = "0xAC5F", Offset = "0xAC5F", VA = "0xAC5F")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170012D8 RID: 4824
		// (get) Token: 0x06006033 RID: 24627 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006034 RID: 24628 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170012D8")]
		public PlatformSpecificScope PlatformSpecificScope
		{
			[Token(Token = "0x6006033")]
			[Address(RVA = "0xAC60", Offset = "0xAC60", VA = "0xAC60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006034")]
			[Address(RVA = "0xAC61", Offset = "0xAC61", VA = "0xAC61")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170012D9 RID: 4825
		// (get) Token: 0x06006035 RID: 24629 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006036 RID: 24630 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170012D9")]
		public AppScope AppScope
		{
			[Token(Token = "0x6006035")]
			[Address(RVA = "0xAC62", Offset = "0xAC62", VA = "0xAC62")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006036")]
			[Address(RVA = "0xAC63", Offset = "0xAC63", VA = "0xAC63")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170012DA RID: 4826
		// (get) Token: 0x06006037 RID: 24631 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006038 RID: 24632 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170012DA")]
		public BillingScope BillingScope
		{
			[Token(Token = "0x6006037")]
			[Address(RVA = "0xAC64", Offset = "0xAC64", VA = "0xAC64")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006038")]
			[Address(RVA = "0xAC65", Offset = "0xAC65", VA = "0xAC65")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170012DB RID: 4827
		// (get) Token: 0x06006039 RID: 24633 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600603A RID: 24634 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170012DB")]
		public SettingsScope SettingsScope
		{
			[Token(Token = "0x6006039")]
			[Address(RVA = "0xAC66", Offset = "0xAC66", VA = "0xAC66")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600603A")]
			[Address(RVA = "0xAC67", Offset = "0xAC67", VA = "0xAC67")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170012DC RID: 4828
		// (get) Token: 0x0600603B RID: 24635 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600603C RID: 24636 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170012DC")]
		public GuideScope GuideScope
		{
			[Token(Token = "0x600603B")]
			[Address(RVA = "0xAC68", Offset = "0xAC68", VA = "0xAC68")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600603C")]
			[Address(RVA = "0xAC69", Offset = "0xAC69", VA = "0xAC69")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170012DD RID: 4829
		// (get) Token: 0x0600603D RID: 24637 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600603E RID: 24638 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170012DD")]
		public CombatScope CombatScope
		{
			[Token(Token = "0x600603D")]
			[Address(RVA = "0xAC6A", Offset = "0xAC6A", VA = "0xAC6A")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600603E")]
			[Address(RVA = "0xAC6B", Offset = "0xAC6B", VA = "0xAC6B")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170012DE RID: 4830
		// (get) Token: 0x0600603F RID: 24639 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006040 RID: 24640 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170012DE")]
		public TournamentsScope TournamentsScope
		{
			[Token(Token = "0x600603F")]
			[Address(RVA = "0xAC6C", Offset = "0xAC6C", VA = "0xAC6C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006040")]
			[Address(RVA = "0xAC6D", Offset = "0xAC6D", VA = "0xAC6D")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170012DF RID: 4831
		// (get) Token: 0x06006041 RID: 24641 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006042 RID: 24642 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170012DF")]
		public BlitzTournamentScope BlitzTournamentScope
		{
			[Token(Token = "0x6006041")]
			[Address(RVA = "0xAC6E", Offset = "0xAC6E", VA = "0xAC6E")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006042")]
			[Address(RVA = "0xAC6F", Offset = "0xAC6F", VA = "0xAC6F")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170012E0 RID: 4832
		// (get) Token: 0x06006043 RID: 24643 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006044 RID: 24644 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170012E0")]
		public BossScope BossScope
		{
			[Token(Token = "0x6006043")]
			[Address(RVA = "0xAC70", Offset = "0xAC70", VA = "0xAC70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006044")]
			[Address(RVA = "0xAC71", Offset = "0xAC71", VA = "0xAC71")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170012E1 RID: 4833
		// (get) Token: 0x06006045 RID: 24645 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006046 RID: 24646 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170012E1")]
		public IsleScope IsleScope
		{
			[Token(Token = "0x6006045")]
			[Address(RVA = "0xAC72", Offset = "0xAC72", VA = "0xAC72")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006046")]
			[Address(RVA = "0xAC73", Offset = "0xAC73", VA = "0xAC73")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170012E2 RID: 4834
		// (get) Token: 0x06006047 RID: 24647 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006048 RID: 24648 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170012E2")]
		public InventoryScope InventoryScope
		{
			[Token(Token = "0x6006047")]
			[Address(RVA = "0xAC74", Offset = "0xAC74", VA = "0xAC74")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006048")]
			[Address(RVA = "0xAC75", Offset = "0xAC75", VA = "0xAC75")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170012E3 RID: 4835
		// (get) Token: 0x06006049 RID: 24649 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600604A RID: 24650 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170012E3")]
		public UiScope UiScope
		{
			[Token(Token = "0x6006049")]
			[Address(RVA = "0xAC76", Offset = "0xAC76", VA = "0xAC76")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600604A")]
			[Address(RVA = "0xAC77", Offset = "0xAC77", VA = "0xAC77")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170012E4 RID: 4836
		// (get) Token: 0x0600604B RID: 24651 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600604C RID: 24652 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170012E4")]
		public BankScope BankScope
		{
			[Token(Token = "0x600604B")]
			[Address(RVA = "0xAC78", Offset = "0xAC78", VA = "0xAC78")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600604C")]
			[Address(RVA = "0xAC79", Offset = "0xAC79", VA = "0xAC79")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170012E5 RID: 4837
		// (get) Token: 0x0600604D RID: 24653 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600604E RID: 24654 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170012E5")]
		public DiscountsScope DiscountsScope
		{
			[Token(Token = "0x600604D")]
			[Address(RVA = "0xAC7A", Offset = "0xAC7A", VA = "0xAC7A")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600604E")]
			[Address(RVA = "0xAC7B", Offset = "0xAC7B", VA = "0xAC7B")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170012E6 RID: 4838
		// (get) Token: 0x0600604F RID: 24655 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006050 RID: 24656 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170012E6")]
		public MedalsScope MedalsScope
		{
			[Token(Token = "0x600604F")]
			[Address(RVA = "0xAC7C", Offset = "0xAC7C", VA = "0xAC7C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006050")]
			[Address(RVA = "0xAC7D", Offset = "0xAC7D", VA = "0xAC7D")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170012E7 RID: 4839
		// (get) Token: 0x06006051 RID: 24657 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006052 RID: 24658 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170012E7")]
		public AprsScope AprsScope
		{
			[Token(Token = "0x6006051")]
			[Address(RVA = "0xAC7E", Offset = "0xAC7E", VA = "0xAC7E")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006052")]
			[Address(RVA = "0xAC7F", Offset = "0xAC7F", VA = "0xAC7F")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170012E8 RID: 4840
		// (get) Token: 0x06006053 RID: 24659 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006054 RID: 24660 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170012E8")]
		public CollectionsScope CollectionsScope
		{
			[Token(Token = "0x6006053")]
			[Address(RVA = "0xAC80", Offset = "0xAC80", VA = "0xAC80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006054")]
			[Address(RVA = "0xAC81", Offset = "0xAC81", VA = "0xAC81")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170012E9 RID: 4841
		// (get) Token: 0x06006055 RID: 24661 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006056 RID: 24662 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170012E9")]
		public DailyQuestScope DailyQuestScope
		{
			[Token(Token = "0x6006055")]
			[Address(RVA = "0xAC82", Offset = "0xAC82", VA = "0xAC82")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006056")]
			[Address(RVA = "0xAC83", Offset = "0xAC83", VA = "0xAC83")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170012EA RID: 4842
		// (get) Token: 0x06006057 RID: 24663 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006058 RID: 24664 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170012EA")]
		public GoalsScope GoalsScope
		{
			[Token(Token = "0x6006057")]
			[Address(RVA = "0xAC84", Offset = "0xAC84", VA = "0xAC84")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006058")]
			[Address(RVA = "0xAC85", Offset = "0xAC85", VA = "0xAC85")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170012EB RID: 4843
		// (get) Token: 0x06006059 RID: 24665 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600605A RID: 24666 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170012EB")]
		public SmallGamesScope SmallGamesScope
		{
			[Token(Token = "0x6006059")]
			[Address(RVA = "0xAC86", Offset = "0xAC86", VA = "0xAC86")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600605A")]
			[Address(RVA = "0xAC87", Offset = "0xAC87", VA = "0xAC87")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170012EC RID: 4844
		// (get) Token: 0x0600605B RID: 24667 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600605C RID: 24668 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170012EC")]
		public ShopScope ShopScope
		{
			[Token(Token = "0x600605B")]
			[Address(RVA = "0xAC88", Offset = "0xAC88", VA = "0xAC88")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600605C")]
			[Address(RVA = "0xAC89", Offset = "0xAC89", VA = "0xAC89")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170012ED RID: 4845
		// (get) Token: 0x0600605D RID: 24669 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600605E RID: 24670 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170012ED")]
		public SchoolScope SchoolScope
		{
			[Token(Token = "0x600605D")]
			[Address(RVA = "0xAC8A", Offset = "0xAC8A", VA = "0xAC8A")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600605E")]
			[Address(RVA = "0xAC8B", Offset = "0xAC8B", VA = "0xAC8B")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170012EE RID: 4846
		// (get) Token: 0x0600605F RID: 24671 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006060 RID: 24672 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170012EE")]
		public ChatScope ChatScope
		{
			[Token(Token = "0x600605F")]
			[Address(RVA = "0xAC8C", Offset = "0xAC8C", VA = "0xAC8C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006060")]
			[Address(RVA = "0xAC8D", Offset = "0xAC8D", VA = "0xAC8D")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170012EF RID: 4847
		// (get) Token: 0x06006061 RID: 24673 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006062 RID: 24674 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170012EF")]
		public AuchanScope AuchanScope
		{
			[Token(Token = "0x6006061")]
			[Address(RVA = "0xAC8E", Offset = "0xAC8E", VA = "0xAC8E")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006062")]
			[Address(RVA = "0xAC8F", Offset = "0xAC8F", VA = "0xAC8F")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170012F0 RID: 4848
		// (get) Token: 0x06006063 RID: 24675 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006064 RID: 24676 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170012F0")]
		public CraftScope CraftScope
		{
			[Token(Token = "0x6006063")]
			[Address(RVA = "0xAC90", Offset = "0xAC90", VA = "0xAC90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006064")]
			[Address(RVA = "0xAC91", Offset = "0xAC91", VA = "0xAC91")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170012F1 RID: 4849
		// (get) Token: 0x06006065 RID: 24677 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006066 RID: 24678 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170012F1")]
		public ManufactureAssistScope ManufactureAssistScope
		{
			[Token(Token = "0x6006065")]
			[Address(RVA = "0xAC92", Offset = "0xAC92", VA = "0xAC92")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006066")]
			[Address(RVA = "0xAC93", Offset = "0xAC93", VA = "0xAC93")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170012F2 RID: 4850
		// (get) Token: 0x06006067 RID: 24679 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006068 RID: 24680 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170012F2")]
		public GiftsScope GiftsScope
		{
			[Token(Token = "0x6006067")]
			[Address(RVA = "0xAC94", Offset = "0xAC94", VA = "0xAC94")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006068")]
			[Address(RVA = "0xAC95", Offset = "0xAC95", VA = "0xAC95")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170012F3 RID: 4851
		// (get) Token: 0x06006069 RID: 24681 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600606A RID: 24682 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170012F3")]
		public ClansScope ClansScope
		{
			[Token(Token = "0x6006069")]
			[Address(RVA = "0xAC96", Offset = "0xAC96", VA = "0xAC96")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600606A")]
			[Address(RVA = "0xAC97", Offset = "0xAC97", VA = "0xAC97")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170012F4 RID: 4852
		// (get) Token: 0x0600606B RID: 24683 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600606C RID: 24684 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170012F4")]
		public RateGameScope RateGameScope
		{
			[Token(Token = "0x600606B")]
			[Address(RVA = "0xAC98", Offset = "0xAC98", VA = "0xAC98")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600606C")]
			[Address(RVA = "0xAC99", Offset = "0xAC99", VA = "0xAC99")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170012F5 RID: 4853
		// (get) Token: 0x0600606D RID: 24685 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600606E RID: 24686 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170012F5")]
		public NotificationScope NotificationScope
		{
			[Token(Token = "0x600606D")]
			[Address(RVA = "0xAC9A", Offset = "0xAC9A", VA = "0xAC9A")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600606E")]
			[Address(RVA = "0xAC9B", Offset = "0xAC9B", VA = "0xAC9B")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170012F6 RID: 4854
		// (get) Token: 0x0600606F RID: 24687 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006070 RID: 24688 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170012F6")]
		public AdScope AdScope
		{
			[Token(Token = "0x600606F")]
			[Address(RVA = "0xAC9C", Offset = "0xAC9C", VA = "0xAC9C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006070")]
			[Address(RVA = "0xAC9D", Offset = "0xAC9D", VA = "0xAC9D")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170012F7 RID: 4855
		// (get) Token: 0x06006071 RID: 24689 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006072 RID: 24690 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170012F7")]
		public GdEventsScope GdEventsScope
		{
			[Token(Token = "0x6006071")]
			[Address(RVA = "0xAC9E", Offset = "0xAC9E", VA = "0xAC9E")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006072")]
			[Address(RVA = "0xAC9F", Offset = "0xAC9F", VA = "0xAC9F")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170012F8 RID: 4856
		// (get) Token: 0x06006073 RID: 24691 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006074 RID: 24692 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170012F8")]
		public ThemeDuelScope ThemeDuelScope
		{
			[Token(Token = "0x6006073")]
			[Address(RVA = "0xACA0", Offset = "0xACA0", VA = "0xACA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006074")]
			[Address(RVA = "0xACA1", Offset = "0xACA1", VA = "0xACA1")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170012F9 RID: 4857
		// (get) Token: 0x06006075 RID: 24693 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006076 RID: 24694 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170012F9")]
		public PortalsScope PortalsScope
		{
			[Token(Token = "0x6006075")]
			[Address(RVA = "0xACA2", Offset = "0xACA2", VA = "0xACA2")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006076")]
			[Address(RVA = "0xACA3", Offset = "0xACA3", VA = "0xACA3")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06006077 RID: 24695 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006077")]
		[Address(RVA = "0xACA4", Offset = "0xACA4", VA = "0xACA4")]
		public EventBus()
		{
		/* --- GHIDRA: .ctor ---
		void Core_Events_EventBus___ctor(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5a34b == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_AdScope_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_AnalyticsEventMediatorScope_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_AppScope_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_AprsScope_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_AuchanScope_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_AuthScope_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_BankScope_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_BillingScope_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_BlitzTournamentScope_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_BossScope_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_ChatScope_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_ClansScope_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_CollectionsScope_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_CombatScope_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_CraftScope_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_DailyQuestScope_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_DiscountsScope_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_GdEventsScope_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_GiftsScope_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_GoalsScope_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_GuideScope_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_HashSet_AbstractEventBusScope__Add__);
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_InventoryScope_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_IsleScope_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_ManufactureAssistScope_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_MedalsScope_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_NotificationScope_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_PlatformSpecificScope_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_PortalsScope_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_RateGameScope_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_SchoolScope_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_SettingsScope_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_ShopScope_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_SmallGamesScope_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_ThemeDuelScope_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_TournamentsScope_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_Tutorial2Scope_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_UiScope_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_UserScope_TypeInfo);
		    DAT_ram_00a5a34b = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Core_Events_Scopes_PlatformSpecificScope_TypeInfo);
		  *(undefined4 *)(param1 + 0x18) = uVar1;
		  System_Collections_Generic_HashSet_object___Clear
		            (*(undefined4 *)(param1 + 0xa0),uVar1,
		             Method_System_Collections_Generic_HashSet_AbstractEventBusScope__Add__);
		  uVar1 = unnamed_function_1417(Core_Events_Scopes_AppScope_TypeInfo);
		  *(undefined4 *)(param1 + 0x1c) = uVar1;
		  System_Collections_Generic_HashSet_object___Clear
		            (*(undefined4 *)(param1 + 0xa0),uVar1,
		             Method_System_Collections_Generic_HashSet_AbstractEventBusScope__Add__);
		  uVar1 = unnamed_function_1417(Core_Events_Scopes_AuthScope_TypeInfo);
		  *(undefined4 *)(param1 + 8) = uVar1;
		  System_Collections_Generic_HashSet_object___Clear
		            (*(undefined4 *)(param1 + 0xa0),uVar1,
		             Method_System_Collections_Generic_HashSet_AbstractEventBusScope__Add__);
		  uVar1 = unnamed_function_1417(Core_Events_Scopes_UserScope_TypeInfo);
		  *(undefined4 *)(param1 + 0xc) = uVar1;
		  System_Collections_Generic_HashSet_object___Clear
		            (*(undefined4 *)(param1 + 0xa0),uVar1,
		             Method_System_Collections_Generic_HashSet_AbstractEventBusScope__Add__);
		  uVar1 = unnamed_function_1417(Core_Events_Scopes_Tutorial2Scope_TypeInfo);
		  *(undefined4 *)(param1 + 0x10) = uVar1;
		  System_Collections_Generic_HashSet_object___Clear
		            (*(undefined4 *)(param1 + 0xa0),uVar1,
		             Method_System_Collections_Generic_HashSet_AbstractEventBusScope__Add__);
		  uVar1 = unnamed_function_1417(Core_Events_Scopes_AnalyticsEventMediatorScope_TypeInfo);
		  *(undefined4 *)(param1 + 0x14) = uVar1;
		  System_Collections_Generic_HashSet_object___Clear
		            (*(undefined4 *)(param1 + 0xa0),uVar1,
		             Method_System_Collections_Generic_HashSet_AbstractEventBusScope__Add__);
		  uVar1 = unnamed_function_1417(Core_Events_Scopes_BillingScope_TypeInfo);
		  *(undefined4 *)(param1 + 0x20) = uVar1;
		  System_Collections_Generic_HashSet_object___Clear
		            (*(undefined4 *)(param1 + 0xa0),uVar1,
		             Method_System_Collections_Generic_HashSet_AbstractEventBusScope__Add__);
		  uVar1 = unnamed_function_1417(Core_Events_Scopes_SettingsScope_TypeInfo);
		  *(undefined4 *)(param1 + 0x24) = uVar1;
		  System_Collections_Generic_HashSet_object___Clear
		            (*(undefined4 *)(param1 + 0xa0),uVar1,
		             Method_System_Collections_Generic_HashSet_AbstractEventBusScope__Add__);
		  uVar1 = unnamed_function_1417(Core_Events_Scopes_GuideScope_TypeInfo);
		  *(undefined4 *)(param1 + 0x28) = uVar1;
		  System_Collections_Generic_HashSet_object___Clear
		            (*(undefined4 *)(param1 + 0xa0),uVar1,
		             Method_System_Collections_Generic_HashSet_AbstractEventBusScope__Add__);
		  uVar1 = unnamed_function_1417(Core_Events_Scopes_CombatScope_TypeInfo);
		  *(undefined4 *)(param1 + 0x2c) = uVar1;
		  System_Collections_Generic_HashSet_object___Clear
		            (*(undefined4 *)(param1 + 0xa0),uVar1,
		             Method_System_Collections_Generic_HashSet_AbstractEventBusScope__Add__);
		  uVar1 = unnamed_function_1417(Core_Events_Scopes_TournamentsScope_TypeInfo);
		  *(undefined4 *)(param1 + 0x30) = uVar1;
		  System_Collections_Generic_HashSet_object___Clear
		            (*(undefined4 *)(param1 + 0xa0),uVar1,
		             Method_System_Collections_Generic_HashSet_AbstractEventBusScope__Add__);
		  uVar1 = unnamed_function_1417(Core_Events_Scopes_BlitzTournamentScope_TypeInfo);
		  *(undefined4 *)(param1 + 0x34) = uVar1;
		  System_Collections_Generic_HashSet_object___Clear
		            (*(undefined4 *)(param1 + 0xa0),uVar1,
		             Method_System_Collections_Generic_HashSet_AbstractEventBusScope__Add__);
		  uVar1 = unnamed_function_1417(Core_Events_Scopes_BossScope_TypeInfo);
		  *(undefined4 *)(param1 + 0x38) = uVar1;
		  System_Collections_Generic_HashSet_object___Clear
		            (*(undefined4 *)(param1 + 0xa0),uVar1,
		             Method_System_Collections_Generic_HashSet_AbstractEventBusScope__Add__);
		  uVar1 = unnamed_function_1417(Core_Events_Scopes_IsleScope_TypeInfo);
		  *(undefined4 *)(param1 + 0x3c) = uVar1;
		  System_Collections_Generic_HashSet_object___Clear
		            (*(undefined4 *)(param1 + 0xa0),uVar1,
		             Method_System_Collections_Generic_HashSet_AbstractEventBusScope__Add__);
		  uVar1 = unnamed_function_1417(Core_Events_Scopes_InventoryScope_TypeInfo);
		  *(undefined4 *)(param1 + 0x40) = uVar1;
		  System_Collections_Generic_HashSet_object___Clear
		            (*(undefined4 *)(param1 + 0xa0),uVar1,
		             Method_System_Collections_Generic_HashSet_AbstractEventBusScope__Add__);
		  uVar1 = unnamed_function_1417(Core_Events_Scopes_UiScope_TypeInfo);
		  *(undefined4 *)(param1 + 0x44) = uVar1;
		  System_Collections_Generic_HashSet_object___Clear
		            (*(undefined4 *)(param1 + 0xa0),uVar1,
		             Method_System_Collections_Generic_HashSet_AbstractEventBusScope__Add__);
		  uVar1 = unnamed_function_1417(Core_Events_Scopes_BankScope_TypeInfo);
		  *(undefined4 *)(param1 + 0x48) = uVar1;
		  System_Collections_Generic_HashSet_object___Clear
		            (*(undefined4 *)(param1 + 0xa0),uVar1,
		             Method_System_Collections_Generic_HashSet_AbstractEventBusScope__Add__);
		  uVar1 = unnamed_function_1417(Core_Events_Scopes_DiscountsScope_TypeInfo);
		  *(undefined4 *)(param1 + 0x4c) = uVar1;
		  System_Collections_Generic_HashSet_object___Clear
		            (*(undefined4 *)(param1 + 0xa0),uVar1,
		             Method_System_Collections_Generic_HashSet_AbstractEventBusScope__Add__);
		  uVar1 = unnamed_function_1417(Core_Events_Scopes_MedalsScope_TypeInfo);
		  *(undefined4 *)(param1 + 0x50) = uVar1;
		  System_Collections_Generic_HashSet_object___Clear
		            (*(undefined4 *)(param1 + 0xa0),uVar1,
		             Method_System_Collections_Generic_HashSet_AbstractEventBusScope__Add__);
		  uVar1 = unnamed_function_1417(Core_Events_Scopes_AprsScope_TypeInfo);
		  *(undefined4 *)(param1 + 0x54) = uVar1;
		  System_Collections_Generic_HashSet_object___Clear
		            (*(undefined4 *)(param1 + 0xa0),uVar1,
		             Method_System_Collections_Generic_HashSet_AbstractEventBusScope__Add__);
		  uVar1 = unnamed_function_1417(Core_Events_Scopes_CollectionsScope_TypeInfo);
		  *(undefined4 *)(param1 + 0x58) = uVar1;
		  System_Collections_Generic_HashSet_object___Clear
		            (*(undefined4 *)(param1 + 0xa0),uVar1,
		             Method_System_Collections_Generic_HashSet_AbstractEventBusScope__Add__);
		  uVar1 = unnamed_function_1417(Core_Events_Scopes_DailyQuestScope_TypeInfo);
		  *(undefined4 *)(param1 + 0x5c) = uVar1;
		  System_Collections_Generic_HashSet_object___Clear
		            (*(undefined4 *)(param1 + 0xa0),uVar1,
		             Method_System_Collections_Generic_HashSet_AbstractEventBusScope__Add__);
		  uVar1 = unnamed_function_1417(Core_Events_Scopes_SmallGamesScope_TypeInfo);
		  *(undefined4 *)(param1 + 100) = uVar1;
		  System_Collections_Generic_HashSet_object___Clear
		            (*(undefined4 *)(param1 + 0xa0),uVar1,
		             Method_System_Collections_Generic_HashSet_AbstractEventBusScope__Add__);
		  uVar1 = unnamed_function_1417(Core_Events_Scopes_ShopScope_TypeInfo);
		  *(undefined4 *)(param1 + 0x68) = uVar1;
		  System_Collections_Generic_HashSet_object___Clear
		            (*(undefined4 *)(param1 + 0xa0),uVar1,
		             Method_System_Collections_Generic_HashSet_AbstractEventBusScope__Add__);
		  uVar1 = unnamed_function_1417(Core_Events_Scopes_SchoolScope_TypeInfo);
		  *(undefined4 *)(param1 + 0x6c) = uVar1;
		  System_Collections_Generic_HashSet_object___Clear
		            (*(undefined4 *)(param1 + 0xa0),uVar1,
		             Method_System_Collections_Generic_HashSet_AbstractEventBusScope__Add__);
		  uVar1 = unnamed_function_1417(Core_Events_Scopes_ChatScope_TypeInfo);
		  *(undefined4 *)(param1 + 0x70) = uVar1;
		  System_Collections_Generic_HashSet_object___Clear
		            (*(undefined4 *)(param1 + 0xa0),uVar1,
		             Method_System_Collections_Generic_HashSet_AbstractEventBusScope__Add__);
		  uVar1 = unnamed_function_1417(Core_Events_Scopes_AuchanScope_TypeInfo);
		  *(undefined4 *)(param1 + 0x74) = uVar1;
		  System_Collections_Generic_HashSet_object___Clear
		            (*(undefined4 *)(param1 + 0xa0),uVar1,
		             Method_System_Collections_Generic_HashSet_AbstractEventBusScope__Add__);
		  uVar1 = unnamed_function_1417(Core_Events_Scopes_CraftScope_TypeInfo);
		  *(undefined4 *)(param1 + 0x78) = uVar1;
		  System_Collections_Generic_HashSet_object___Clear
		            (*(undefined4 *)(param1 + 0xa0),uVar1,
		             Method_System_Collections_Generic_HashSet_AbstractEventBusScope__Add__);
		  uVar1 = unnamed_function_1417(Core_Events_Scopes_ManufactureAssistScope_TypeInfo);
		  *(undefined4 *)(param1 + 0x7c) = uVar1;
		  System_Collections_Generic_HashSet_object___Clear
		            (*(undefined4 *)(param1 + 0xa0),uVar1,
		             Method_System_Collections_Generic_HashSet_AbstractEventBusScope__Add__);
		  uVar1 = unnamed_function_1417(Core_Events_Scopes_GiftsScope_TypeInfo);
		  *(undefined4 *)(param1 + 0x80) = uVar1;
		  System_Collections_Generic_HashSet_object___Clear
		            (*(undefined4 *)(param1 + 0xa0),uVar1,
		             Method_System_Collections_Generic_HashSet_AbstractEventBusScope__Add__);
		  uVar1 = unnamed_function_1417(Core_Events_Scopes_ClansScope_TypeInfo);
		  *(undefined4 *)(param1 + 0x84) = uVar1;
		  System_Collections_Generic_HashSet_object___Clear
		            (*(undefined4 *)(param1 + 0xa0),uVar1,
		             Method_System_Collections_Generic_HashSet_AbstractEventBusScope__Add__);
		  uVar1 = unnamed_function_1417(Core_Events_Scopes_RateGameScope_TypeInfo);
		  *(undefined4 *)(param1 + 0x88) = uVar1;
		  System_Collections_Generic_HashSet_object___Clear
		            (*(undefined4 *)(param1 + 0xa0),uVar1,
		             Method_System_Collections_Generic_HashSet_AbstractEventBusScope__Add__);
		  uVar1 = unnamed_function_1417(Core_Events_Scopes_NotificationScope_TypeInfo);
		  *(undefined4 *)(param1 + 0x8c) = uVar1;
		  System_Collections_Generic_HashSet_object___Clear
		            (*(undefined4 *)(param1 + 0xa0),uVar1,
		             Method_System_Collections_Generic_HashSet_AbstractEventBusScope__Add__);
		  uVar1 = unnamed_function_1417(Core_Events_Scopes_AdScope_TypeInfo);
		  *(undefined4 *)(param1 + 0x90) = uVar1;
		  System_Collections_Generic_HashSet_object___Clear
		            (*(undefined4 *)(param1 + 0xa0),uVar1,
		             Method_System_Collections_Generic_HashSet_AbstractEventBusScope__Add__);
		  uVar1 = unnamed_function_1417(Core_Events_Scopes_GdEventsScope_TypeInfo);
		  *(undefined4 *)(param1 + 0x94) = uVar1;
		  System_Collections_Generic_HashSet_object___Clear
		            (*(undefined4 *)(param1 + 0xa0),uVar1,
		             Method_System_Collections_Generic_HashSet_AbstractEventBusScope__Add__);
		  uVar1 = unnamed_function_1417(Core_Events_Scopes_GoalsScope_TypeInfo);
		  *(undefined4 *)(param1 + 0x60) = uVar1;
		  System_Collections_Generic_HashSet_object___Clear
		            (*(undefined4 *)(param1 + 0xa0),uVar1,
		             Method_System_Collections_Generic_HashSet_AbstractEventBusScope__Add__);
		  uVar1 = unnamed_function_1417(Core_Events_Scopes_ThemeDuelScope_TypeInfo);
		  *(undefined4 *)(param1 + 0x98) = uVar1;
		  System_Collections_Generic_HashSet_object___Clear
		            (*(undefined4 *)(param1 + 0xa0),uVar1,
		             Method_System_Collections_Generic_HashSet_AbstractEventBusScope__Add__);
		  uVar1 = unnamed_function_1417(Core_Events_Scopes_PortalsScope_TypeInfo);
		  *(undefined4 *)(param1 + 0x9c) = uVar1;
		  System_Collections_Generic_HashSet_object___Clear
		            (*(undefined4 *)(param1 + 0xa0),uVar1,
		             Method_System_Collections_Generic_HashSet_AbstractEventBusScope__Add__);
		  return;
		}
		*/

		}

		// Token: 0x06006078 RID: 24696 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006078")]
		[Address(RVA = "0xACA5", Offset = "0xACA5", VA = "0xACA5")]
		private void InitAllScopes()
		{
		/* --- GHIDRA: InitAllScopes ---
		void Core_Events_EventBus__InitAllScopes(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 param1_00;
		  int *piVar3;
		  int local_18;
		  undefined8 *local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5a34c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_HashSet_Enumerator_AbstractEventBusScope__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_HashSet_Enumerator_AbstractEventBusScope__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_HashSet_Enumerator_AbstractEventBusScope__get_Current__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_HashSet_AbstractEventBusScope__Clear__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_HashSet_AbstractEventBusScope__GetEnumerator__);
		    DAT_ram_00a5a34c = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  Sirenix_Utilities_TypeExtensions__AreGenericConstraintsSatisfiedBy
		            (&local_10,*(undefined4 *)(param1 + 0xa0),
		             Method_System_Collections_Generic_HashSet_AbstractEventBusScope__GetEnumerator__);
		  local_18 = 0;
		  local_14 = &local_10;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar2 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x4d,&local_10,
		                       Method_System_Collections_Generic_HashSet_Enumerator_AbstractEventBusScope__MoveNext__
		                      );
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) {
		      param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81208d8d;
		    }
		    if (iVar2 == 0) goto code_r0x81208de3;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_vii
		              (*(undefined4 *)(*local_8._4_4_ + 0xe8),local_8._4_4_,
		               *(undefined4 *)(*local_8._4_4_ + 0xec));
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar1 != 1);
		  param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x81208d8d:
		  iVar1 = global_1;
		  iVar2 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar1 == iVar2) {
		    piVar3 = (int *)import::env::__cxa_begin_catch(param1_00);
		    iVar2 = *piVar3;
		    DAT_ram_009d3e38 = 0;
		    local_18 = iVar2;
		    import::env::invoke_v(0x123);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 != 1) {
		      if (iVar2 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		code_r0x81208de3:
		      DAT_ram_009d3e38 = 0;
		      System_Collections_Generic_HashSet___Il2CppFullySharedGenericType___AreEqualityComparersEqual
		                (*(undefined4 *)(param1 + 0xa0),
		                 Method_System_Collections_Generic_HashSet_AbstractEventBusScope__Clear__);
		      return;
		    }
		    param1_00 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001f04 + 0x2ac,&local_18);
		  iVar1 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar1 == 1) {
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__resumeException(param1_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06006079 RID: 24697 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006079")]
		[Address(RVA = "0xACA6", Offset = "0xACA6", VA = "0xACA6", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x04003363 RID: 13155
		[Token(Token = "0x4003363")]
		[FieldOffset(Offset = "0xA0")]
		private HashSet<AbstractEventBusScope> _allScopes;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_PortalsScope ---
		void Core_Events_EventBus__set_PortalsScope(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5a34a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_HashSet_AbstractEventBusScope___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_HashSet_AbstractEventBusScope__TypeInfo);
		    DAT_ram_00a5a34a = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (System_Collections_Generic_HashSet_AbstractEventBusScope__TypeInfo);
		  func_ii_7115(param1_00,Method_System_Collections_Generic_HashSet_AbstractEventBusScope___ctor__);
		  *(undefined4 *)(param1 + 0xa0) = param1_00;
		  Core_Events_EventBus___ctor(param1,param1);
		  return;
		}
		*/

}
