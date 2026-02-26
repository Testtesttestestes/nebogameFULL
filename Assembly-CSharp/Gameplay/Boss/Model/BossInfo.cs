using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Data.Skills;
using Core.Dict;
using Google.Protobuf.Collections;
using Il2CppDummyDll;
using Protocol.Common;
using Protocol.Dic;

namespace Gameplay.Boss.Model
{
	// Token: 0x02000B8A RID: 2954
	[Token(Token = "0x2000B8A")]
	public class BossInfo
	{
		// Token: 0x17000E66 RID: 3686
		// (get) Token: 0x060047D5 RID: 18389 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060047D6 RID: 18390 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E66")]
		public AprDic AprDic
		{
			[Token(Token = "0x60047D5")]
			[Address(RVA = "0x9660", Offset = "0x9660", VA = "0x9660")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60047D6")]
			[Address(RVA = "0x9661", Offset = "0x9661", VA = "0x9661")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000E67 RID: 3687
		// (get) Token: 0x060047D7 RID: 18391 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060047D8 RID: 18392 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E67")]
		public BossTypeDic BossTypeDic
		{
			[Token(Token = "0x60047D7")]
			[Address(RVA = "0x9662", Offset = "0x9662", VA = "0x9662")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60047D8")]
			[Address(RVA = "0x9663", Offset = "0x9663", VA = "0x9663")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000E68 RID: 3688
		// (get) Token: 0x060047D9 RID: 18393 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060047DA RID: 18394 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E68")]
		public BossCategoryDic BossCategoryDic
		{
			[Token(Token = "0x60047D9")]
			[Address(RVA = "0x9664", Offset = "0x9664", VA = "0x9664")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60047DA")]
			[Address(RVA = "0x9665", Offset = "0x9665", VA = "0x9665")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000E69 RID: 3689
		// (get) Token: 0x060047DB RID: 18395 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060047DC RID: 18396 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E69")]
		public MonsterDic MonsterDic
		{
			[Token(Token = "0x60047DB")]
			[Address(RVA = "0x9666", Offset = "0x9666", VA = "0x9666")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60047DC")]
			[Address(RVA = "0x9667", Offset = "0x9667", VA = "0x9667")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000E6A RID: 3690
		// (get) Token: 0x060047DD RID: 18397 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060047DE RID: 18398 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E6A")]
		public CultDic DominateCultDic
		{
			[Token(Token = "0x60047DD")]
			[Address(RVA = "0x9668", Offset = "0x9668", VA = "0x9668")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60047DE")]
			[Address(RVA = "0x9669", Offset = "0x9669", VA = "0x9669")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000E6B RID: 3691
		// (get) Token: 0x060047DF RID: 18399 RVA: 0x0000D320 File Offset: 0x0000B520
		// (set) Token: 0x060047E0 RID: 18400 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E6B")]
		public int DominateBonusPercent
		{
			[Token(Token = "0x60047DF")]
			[Address(RVA = "0x966A", Offset = "0x966A", VA = "0x966A")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60047E0")]
			[Address(RVA = "0x966B", Offset = "0x966B", VA = "0x966B")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000E6C RID: 3692
		// (get) Token: 0x060047E1 RID: 18401 RVA: 0x0000D338 File Offset: 0x0000B538
		// (set) Token: 0x060047E2 RID: 18402 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E6C")]
		public int AssistantBonusPercent
		{
			[Token(Token = "0x60047E1")]
			[Address(RVA = "0x966C", Offset = "0x966C", VA = "0x966C")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60047E2")]
			[Address(RVA = "0x966D", Offset = "0x966D", VA = "0x966D")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000E6D RID: 3693
		// (get) Token: 0x060047E3 RID: 18403 RVA: 0x0000D350 File Offset: 0x0000B550
		// (set) Token: 0x060047E4 RID: 18404 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E6D")]
		public int AssistantBonusSkillId
		{
			[Token(Token = "0x60047E3")]
			[Address(RVA = "0x966E", Offset = "0x966E", VA = "0x966E")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60047E4")]
			[Address(RVA = "0x966F", Offset = "0x966F", VA = "0x966F")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000E6E RID: 3694
		// (get) Token: 0x060047E5 RID: 18405 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060047E6 RID: 18406 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E6E")]
		public List<BossInfo.BossAttackOption> BossAttackOptions
		{
			[Token(Token = "0x60047E5")]
			[Address(RVA = "0x9670", Offset = "0x9670", VA = "0x9670")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60047E6")]
			[Address(RVA = "0x9671", Offset = "0x9671", VA = "0x9671")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000E6F RID: 3695
		// (get) Token: 0x060047E7 RID: 18407 RVA: 0x0000D368 File Offset: 0x0000B568
		[Token(Token = "0x17000E6F")]
		public int LicenceCountMax
		{
			[Token(Token = "0x60047E7")]
			[Address(RVA = "0x9672", Offset = "0x9672", VA = "0x9672")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000E70 RID: 3696
		// (get) Token: 0x060047E8 RID: 18408 RVA: 0x0000D380 File Offset: 0x0000B580
		[Token(Token = "0x17000E70")]
		public bool HasLossReward
		{
			[Token(Token = "0x60047E8")]
			[Address(RVA = "0x9673", Offset = "0x9673", VA = "0x9673")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000E71 RID: 3697
		// (get) Token: 0x060047E9 RID: 18409 RVA: 0x0000D398 File Offset: 0x0000B598
		[Token(Token = "0x17000E71")]
		public ulong TotalHealth
		{
			[Token(Token = "0x60047E9")]
			[Address(RVA = "0x9674", Offset = "0x9674", VA = "0x9674")]
			get
			{
				return 0UL;
			}
		}

		// Token: 0x17000E72 RID: 3698
		// (get) Token: 0x060047EA RID: 18410 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060047EB RID: 18411 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E72")]
		public SkillCollection BossSkills
		{
			[Token(Token = "0x60047EA")]
			[Address(RVA = "0x9675", Offset = "0x9675", VA = "0x9675")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60047EB")]
			[Address(RVA = "0x9676", Offset = "0x9676", VA = "0x9676")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000E73 RID: 3699
		// (get) Token: 0x060047EC RID: 18412 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060047ED RID: 18413 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E73")]
		public List<BossInfo.BossRewardRangeData> Rewards
		{
			[Token(Token = "0x60047EC")]
			[Address(RVA = "0x9677", Offset = "0x9677", VA = "0x9677")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60047ED")]
			[Address(RVA = "0x9678", Offset = "0x9678", VA = "0x9678")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000E74 RID: 3700
		// (get) Token: 0x060047EE RID: 18414 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060047EF RID: 18415 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E74")]
		public List<BossInfo.BossCultSpellData> CultSpells
		{
			[Token(Token = "0x60047EE")]
			[Address(RVA = "0x9679", Offset = "0x9679", VA = "0x9679")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60047EF")]
			[Address(RVA = "0x967A", Offset = "0x967A", VA = "0x967A")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060047F0 RID: 18416 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60047F0")]
		[Address(RVA = "0x967B", Offset = "0x967B", VA = "0x967B")]
		public BossInfo(int typeId, int categoryId, IDictProvider dictProvider)
		{
		}

		// Token: 0x0400277F RID: 10111
		[Token(Token = "0x400277F")]
		[FieldOffset(Offset = "0x30")]
		private ulong? _totalHealth;

		// Token: 0x02000B8B RID: 2955
		[Token(Token = "0x2000B8B")]
		public class BossAttackOption
		{
			// Token: 0x17000E75 RID: 3701
			// (get) Token: 0x060047F1 RID: 18417 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x060047F2 RID: 18418 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000E75")]
			public BossTypeDic.Types.AttackOption RawAttackOption
			{
				[Token(Token = "0x60047F1")]
				[Address(RVA = "0x967C", Offset = "0x967C", VA = "0x967C")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60047F2")]
				[Address(RVA = "0x967D", Offset = "0x967D", VA = "0x967D")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000E76 RID: 3702
			// (get) Token: 0x060047F3 RID: 18419 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x060047F4 RID: 18420 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000E76")]
			public List<BossInfo.BossAttackOption.BossAttackOptionVariant> Variants
			{
				[Token(Token = "0x60047F3")]
				[Address(RVA = "0x967E", Offset = "0x967E", VA = "0x967E")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60047F4")]
				[Address(RVA = "0x967F", Offset = "0x967F", VA = "0x967F")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000E77 RID: 3703
			// (get) Token: 0x060047F5 RID: 18421 RVA: 0x0000D3B0 File Offset: 0x0000B5B0
			[Token(Token = "0x17000E77")]
			public long OptionId
			{
				[Token(Token = "0x60047F5")]
				[Address(RVA = "0x1EBB", Offset = "0x1EBB", VA = "0x1EBB")]
				get
				{
					return 0L;
				}
			}

			// Token: 0x17000E78 RID: 3704
			// (get) Token: 0x060047F6 RID: 18422 RVA: 0x0000D3C8 File Offset: 0x0000B5C8
			[Token(Token = "0x17000E78")]
			public int SortOrder
			{
				[Token(Token = "0x60047F6")]
				[Address(RVA = "0x9680", Offset = "0x9680", VA = "0x9680")]
				get
				{
					return 0;
				}
			}

			// Token: 0x060047F7 RID: 18423 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60047F7")]
			[Address(RVA = "0x1B26", Offset = "0x1B26", VA = "0x1B26")]
			public BossAttackOption(BossTypeDic.Types.AttackOption attackOption)
			{
			}

			// Token: 0x02000B8C RID: 2956
			[Token(Token = "0x2000B8C")]
			public class BossAttackOptionVariant
			{
				// Token: 0x17000E79 RID: 3705
				// (get) Token: 0x060047F8 RID: 18424 RVA: 0x00002052 File Offset: 0x00000252
				// (set) Token: 0x060047F9 RID: 18425 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x17000E79")]
				public BossTypeDic.Types.AttackOption.Types.OptionVariant RawOptionVariant
				{
					[Token(Token = "0x60047F8")]
					[Address(RVA = "0x9681", Offset = "0x9681", VA = "0x9681")]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[Token(Token = "0x60047F9")]
					[Address(RVA = "0x9682", Offset = "0x9682", VA = "0x9682")]
					[CompilerGenerated]
					private set
					{
					}
				}

				// Token: 0x17000E7A RID: 3706
				// (get) Token: 0x060047FA RID: 18426 RVA: 0x00002052 File Offset: 0x00000252
				// (set) Token: 0x060047FB RID: 18427 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x17000E7A")]
				public Skills BonusSkills
				{
					[Token(Token = "0x60047FA")]
					[Address(RVA = "0x9683", Offset = "0x9683", VA = "0x9683")]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[Token(Token = "0x60047FB")]
					[Address(RVA = "0x9684", Offset = "0x9684", VA = "0x9684")]
					[CompilerGenerated]
					private set
					{
					}
				}

				// Token: 0x17000E7B RID: 3707
				// (get) Token: 0x060047FC RID: 18428 RVA: 0x0000D3E0 File Offset: 0x0000B5E0
				// (set) Token: 0x060047FD RID: 18429 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x17000E7B")]
				public bool HasBonusSkills
				{
					[Token(Token = "0x60047FC")]
					[Address(RVA = "0x9685", Offset = "0x9685", VA = "0x9685")]
					[CompilerGenerated]
					get
					{
						return default(bool);
					}
					[Token(Token = "0x60047FD")]
					[Address(RVA = "0x9686", Offset = "0x9686", VA = "0x9686")]
					[CompilerGenerated]
					private set
					{
					}
				}

				// Token: 0x17000E7C RID: 3708
				// (get) Token: 0x060047FE RID: 18430 RVA: 0x00002052 File Offset: 0x00000252
				[Token(Token = "0x17000E7C")]
				public ResourceSet Price
				{
					[Token(Token = "0x60047FE")]
					[Address(RVA = "0x1EBD", Offset = "0x1EBD", VA = "0x1EBD")]
					get
					{
						return null;
					}
				}

				// Token: 0x17000E7D RID: 3709
				// (get) Token: 0x060047FF RID: 18431 RVA: 0x00002052 File Offset: 0x00000252
				// (set) Token: 0x06004800 RID: 18432 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x17000E7D")]
				public string ValuePickerStringPresentation
				{
					[Token(Token = "0x60047FF")]
					[Address(RVA = "0x9687", Offset = "0x9687", VA = "0x9687")]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[Token(Token = "0x6004800")]
					[Address(RVA = "0x9688", Offset = "0x9688", VA = "0x9688")]
					[CompilerGenerated]
					private set
					{
					}
				}

				// Token: 0x17000E7E RID: 3710
				// (get) Token: 0x06004801 RID: 18433 RVA: 0x0000D3F8 File Offset: 0x0000B5F8
				[Token(Token = "0x17000E7E")]
				public int VariantId
				{
					[Token(Token = "0x6004801")]
					[Address(RVA = "0x1EBC", Offset = "0x1EBC", VA = "0x1EBC")]
					get
					{
						return 0;
					}
				}

				// Token: 0x06004802 RID: 18434 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6004802")]
				[Address(RVA = "0x1B2C", Offset = "0x1B2C", VA = "0x1B2C")]
				public BossAttackOptionVariant(BossTypeDic.Types.AttackOption.Types.OptionVariant optionVariant)
				{
				}
			}
		}

		// Token: 0x02000B8D RID: 2957
		[Token(Token = "0x2000B8D")]
		public class BossRewardRangeData
		{
			// Token: 0x17000E7F RID: 3711
			// (get) Token: 0x06004803 RID: 18435 RVA: 0x0000D410 File Offset: 0x0000B610
			// (set) Token: 0x06004804 RID: 18436 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000E7F")]
			public uint SortOrder
			{
				[Token(Token = "0x6004803")]
				[Address(RVA = "0x9689", Offset = "0x9689", VA = "0x9689")]
				[CompilerGenerated]
				get
				{
					return 0U;
				}
				[Token(Token = "0x6004804")]
				[Address(RVA = "0x968A", Offset = "0x968A", VA = "0x968A")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000E80 RID: 3712
			// (get) Token: 0x06004805 RID: 18437 RVA: 0x0000D428 File Offset: 0x0000B628
			// (set) Token: 0x06004806 RID: 18438 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000E80")]
			public int Index
			{
				[Token(Token = "0x6004805")]
				[Address(RVA = "0x968B", Offset = "0x968B", VA = "0x968B")]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[Token(Token = "0x6004806")]
				[Address(RVA = "0x968C", Offset = "0x968C", VA = "0x968C")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17000E81 RID: 3713
			// (get) Token: 0x06004807 RID: 18439 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x06004808 RID: 18440 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000E81")]
			public RewardData[] CaptainRewards
			{
				[Token(Token = "0x6004807")]
				[Address(RVA = "0x968D", Offset = "0x968D", VA = "0x968D")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6004808")]
				[Address(RVA = "0x968E", Offset = "0x968E", VA = "0x968E")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000E82 RID: 3714
			// (get) Token: 0x06004809 RID: 18441 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x0600480A RID: 18442 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000E82")]
			public RewardData[] AssistantRewards
			{
				[Token(Token = "0x6004809")]
				[Address(RVA = "0x968F", Offset = "0x968F", VA = "0x968F")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x600480A")]
				[Address(RVA = "0x9690", Offset = "0x9690", VA = "0x9690")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000E83 RID: 3715
			// (get) Token: 0x0600480B RID: 18443 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x0600480C RID: 18444 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000E83")]
			public string Label
			{
				[Token(Token = "0x600480B")]
				[Address(RVA = "0x9691", Offset = "0x9691", VA = "0x9691")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x600480C")]
				[Address(RVA = "0x9692", Offset = "0x9692", VA = "0x9692")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x0600480D RID: 18445 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x600480D")]
			[Address(RVA = "0x1B28", Offset = "0x1B28", VA = "0x1B28")]
			public static BossInfo.BossRewardRangeData CreatePlaceReward(BossTypeDic.Types.RewardPlace data)
			{
				return null;
			}

			// Token: 0x0600480E RID: 18446 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x600480E")]
			[Address(RVA = "0x9693", Offset = "0x9693", VA = "0x9693")]
			public static BossInfo.BossRewardRangeData CreateWinReward(RepeatedField<RewardInfo> rewards)
			{
				return null;
			}

			// Token: 0x0600480F RID: 18447 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x600480F")]
			[Address(RVA = "0x9694", Offset = "0x9694", VA = "0x9694")]
			public static BossInfo.BossRewardRangeData CreateLoseReward(RepeatedField<RewardInfo> rewards)
			{
				return null;
			}

			// Token: 0x06004810 RID: 18448 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004810")]
			[Address(RVA = "0x9695", Offset = "0x9695", VA = "0x9695")]
			private BossRewardRangeData(uint sortOrder, string label, RepeatedField<RewardInfo> captainRewards, RepeatedField<RewardInfo> assistantRewards)
			{
			}
		}

		// Token: 0x02000B8E RID: 2958
		[Token(Token = "0x2000B8E")]
		public class BossCultSpellData
		{
			// Token: 0x17000E84 RID: 3716
			// (get) Token: 0x06004811 RID: 18449 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x06004812 RID: 18450 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000E84")]
			public CultDic CultDic
			{
				[Token(Token = "0x6004811")]
				[Address(RVA = "0x9696", Offset = "0x9696", VA = "0x9696")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6004812")]
				[Address(RVA = "0x9697", Offset = "0x9697", VA = "0x9697")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000E85 RID: 3717
			// (get) Token: 0x06004813 RID: 18451 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x06004814 RID: 18452 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000E85")]
			public SpellDic SpellDic
			{
				[Token(Token = "0x6004813")]
				[Address(RVA = "0x9698", Offset = "0x9698", VA = "0x9698")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6004814")]
				[Address(RVA = "0x9699", Offset = "0x9699", VA = "0x9699")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000E86 RID: 3718
			// (get) Token: 0x06004815 RID: 18453 RVA: 0x0000D440 File Offset: 0x0000B640
			// (set) Token: 0x06004816 RID: 18454 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000E86")]
			public uint Level
			{
				[Token(Token = "0x6004815")]
				[Address(RVA = "0x969A", Offset = "0x969A", VA = "0x969A")]
				[CompilerGenerated]
				get
				{
					return 0U;
				}
				[Token(Token = "0x6004816")]
				[Address(RVA = "0x969B", Offset = "0x969B", VA = "0x969B")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17000E87 RID: 3719
			// (get) Token: 0x06004817 RID: 18455 RVA: 0x0000D458 File Offset: 0x0000B658
			[Token(Token = "0x17000E87")]
			public uint SpellId
			{
				[Token(Token = "0x6004817")]
				[Address(RVA = "0x1B96", Offset = "0x1B96", VA = "0x1B96")]
				get
				{
					return 0U;
				}
			}

			// Token: 0x17000E88 RID: 3720
			// (get) Token: 0x06004818 RID: 18456 RVA: 0x0000D470 File Offset: 0x0000B670
			[Token(Token = "0x17000E88")]
			public uint CultId
			{
				[Token(Token = "0x6004818")]
				[Address(RVA = "0x969C", Offset = "0x969C", VA = "0x969C")]
				get
				{
					return 0U;
				}
			}

			// Token: 0x06004819 RID: 18457 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004819")]
			[Address(RVA = "0x1B2A", Offset = "0x1B2A", VA = "0x1B2A")]
			public BossCultSpellData(BossTypeDic.Types.CultSpell cultSpellRaw)
			{
			}
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_LicenceCountMax ---
		uint Gameplay_Boss_Model_BossInfo__get_LicenceCountMax(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  uint uVar2;
		  
		  if (DAT_ram_00a5786e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_RewardInfo__get_Count__);
		    DAT_ram_00a5786e = '\x01';
		  }
		  iVar1 = *(int *)(*(int *)(param1 + 0xc) + 0x38);
		  if (iVar1 == 0) {
		    uVar2 = 0;
		  }
		  else {
		    uVar2 = (uint)(0 < *(int *)(iVar1 + 0xc));
		  }
		  return uVar2;
		}
		*/


		/* --- GHIDRA: get_HasLossReward ---
		undefined8 Gameplay_Boss_Model_BossInfo__get_HasLossReward(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined8 uVar2;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5786f == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_ulong___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_ulong__get_HasValue__);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_ulong__get_Value__);
		    Mono_Security_ASN1__get_Item(&Method_Google_Protobuf_Collections_RepeatedField_int__get_Item__);
		    DAT_ram_00a5786f = '\x01';
		  }
		  if (*(char *)(param1 + 0x30) == '\0') {
		    iVar1 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                      (*(undefined4 *)(*(int *)(param1 + 0xc) + 0x1c),1,
		                       Method_Google_Protobuf_Collections_RepeatedField_int__get_Item__);
		    local_8 = 0;
		    local_10 = 0;
		    Core_Log_Files_FileDownloadLogger__LogDownload
		              (&local_10,(longlong)iVar1,Method_System_Nullable_ulong___ctor__);
		    *(undefined8 *)(param1 + 0x38) = local_8;
		    *(undefined8 *)(param1 + 0x30) = local_10;
		  }
		  uVar2 = System_Nullable_TimeSpan___get_HasValue
		                    ((undefined8 *)(param1 + 0x30),Method_System_Nullable_ulong__get_Value__);
		  return uVar2;
		}
		*/


		/* --- GHIDRA: set_CultSpells ---
		void Gameplay_Boss_Model_BossInfo__set_CultSpells
		               (int param1,undefined4 param2,undefined4 param3,int *param4,undefined4 param5)
		
		{
		  undefined4 in_register_20000004;
		  undefined8 uVar1;
		  undefined4 uVar3;
		  double dVar2;
		  uint *puVar4;
		  undefined4 uVar5;
		  undefined4 *puVar6;
		  int *piVar7;
		  double dVar8;
		  int iVar9;
		  int iVar10;
		  int iVar11;
		  undefined4 uVar12;
		  double dVar13;
		  int *piVar14;
		  uint uVar15;
		  ulonglong uVar16;
		  int *local_14;
		  int *local_10;
		  int *local_c;
		  float8 local_8;
		  
		  if (DAT_ram_00a57870 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Boss_Model_BossInfo_BossAttackOption_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Boss_Model_BossInfo_BossCultSpellData_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_OrderBy_BossInfo_BossRewardRangeData__uint___);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_ToList_BossInfo_BossRewardRangeData___);
		    Mono_Security_ASN1__get_Item(&System_Func_BossInfo_BossRewardRangeData__uint__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_IEnumerator_BossTypeDic_Types_RewardPlace__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_IEnumerator_BossTypeDic_Types_AttackOption__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_IEnumerator_BossTypeDic_Types_CultSpell__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_BossInfo_BossRewardRangeData__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_BossInfo_BossCultSpellData__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_BossInfo_BossAttackOption__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_BossInfo_BossRewardRangeData___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_BossInfo_BossCultSpellData___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_BossInfo_BossAttackOption___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_BossInfo_BossRewardRangeData__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_BossInfo_BossRewardRangeData__get_Item__);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_List_BossInfo_BossCultSpellData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_List_BossInfo_BossAttackOption__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_List_BossInfo_BossRewardRangeData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Math_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Google_Protobuf_Collections_RepeatedField_BossTypeDic_Types_RewardPlace__GetEnumerator__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Google_Protobuf_Collections_RepeatedField_BossTypeDic_Types_CultSpell__GetEnumerator__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Google_Protobuf_Collections_RepeatedField_BossTypeDic_Types_AttackOption__GetEnumerator__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_double__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_RewardInfo__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_double__get_Item__);
		    Mono_Security_ASN1__get_Item(&Core_Data_Skills_SkillCollection_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_Boss_Model_BossInfo___c___ctor_b__58_0__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Boss_Model_BossInfo___c_TypeInfo);
		    DAT_ram_00a57870 = '\x01';
		  }
		  local_c = (int *)0x0;
		  local_10 = (int *)0x0;
		  local_14 = (int *)0x0;
		  iVar9 = *param4;
		  if (*(ushort *)(iVar9 + 0xb6) != 0) {
		    uVar15 = 0;
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar9 + 0x58) + uVar15 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar9 + 0x58) + uVar15 * 8 + 4) * 8 + iVar9 + 0xd0);
		        goto code_r0x80dea5fb;
		      }
		      uVar15 = uVar15 + 1;
		    } while (*(ushort *)(iVar9 + 0xb6) != uVar15);
		  }
		  puVar4 = (uint *)func_ii_1080(param4,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x80dea5fb:
		  uVar15 = 0;
		  uVar1 = CONCAT44(in_register_20000004,param4);
		  uVar5 = (**(code **)((ulonglong)*puVar4 * 4))(uVar1,puVar4[1]);
		  uVar3 = (undefined4)((ulonglong)uVar1 >> 0x20);
		  uVar5 = Core_Extensions_Dict_DictExt__GetStoneDic(uVar5,param2,0);
		  *(undefined4 *)(param1 + 0xc) = uVar5;
		  iVar9 = *param4;
		  if (*(ushort *)(iVar9 + 0xb6) != 0) {
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar9 + 0x58) + uVar15 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar9 + 0x58) + uVar15 * 8 + 4) * 8 + iVar9 + 0xd0);
		        goto code_r0x80dea686;
		      }
		      uVar15 = uVar15 + 1;
		    } while (*(ushort *)(iVar9 + 0xb6) != uVar15);
		  }
		  puVar4 = (uint *)func_ii_1080(param4,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x80dea686:
		  uVar15 = 0;
		  uVar1 = CONCAT44(uVar3,param4);
		  uVar5 = (**(code **)((ulonglong)*puVar4 * 4))(uVar1,puVar4[1]);
		  uVar3 = (undefined4)((ulonglong)uVar1 >> 0x20);
		  uVar5 = Core_Extensions_Dict_DictExt__GetBattleAccountCoeffsDic
		                    (uVar5,*(undefined4 *)(*(int *)(param1 + 0xc) + 0x10),0);
		  *(undefined4 *)(param1 + 0x14) = uVar5;
		  iVar9 = *param4;
		  if (*(ushort *)(iVar9 + 0xb6) != 0) {
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar9 + 0x58) + uVar15 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar9 + 0x58) + uVar15 * 8 + 4) * 8 + iVar9 + 0xd0);
		        goto code_r0x80dea717;
		      }
		      uVar15 = uVar15 + 1;
		    } while (*(ushort *)(iVar9 + 0xb6) != uVar15);
		  }
		  puVar4 = (uint *)func_ii_1080(param4,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x80dea717:
		  uVar15 = 0;
		  uVar1 = CONCAT44(uVar3,param4);
		  uVar5 = (**(code **)((ulonglong)*puVar4 * 4))(uVar1,puVar4[1]);
		  uVar3 = (undefined4)((ulonglong)uVar1 >> 0x20);
		  uVar5 = Core_Extensions_Dict_DictExt__GetArtikulTypeFiltersByFilterType
		                    (uVar5,*(undefined4 *)(*(int *)(param1 + 0x14) + 0x10),0);
		  *(undefined4 *)(param1 + 8) = uVar5;
		  iVar9 = *param4;
		  if (*(ushort *)(iVar9 + 0xb6) != 0) {
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar9 + 0x58) + uVar15 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar9 + 0x58) + uVar15 * 8 + 4) * 8 + iVar9 + 0xd0);
		        goto code_r0x80dea7a8;
		      }
		      uVar15 = uVar15 + 1;
		    } while (*(ushort *)(iVar9 + 0xb6) != uVar15);
		  }
		  puVar4 = (uint *)func_ii_1080(param4,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x80dea7a8:
		  iVar9 = 0;
		  uVar1 = CONCAT44(uVar3,param4);
		  uVar5 = (**(code **)((ulonglong)*puVar4 * 4))(uVar1,puVar4[1]);
		  uVar3 = (undefined4)((ulonglong)uVar1 >> 0x20);
		  uVar5 = func_ii_7023(uVar5,param3,0);
		  *(undefined4 *)(param1 + 0x10) = uVar5;
		  iVar10 = *(int *)(param1 + 0xc);
		  iVar11 = *(int *)(iVar10 + 0x28);
		  if (0 < *(int *)(iVar11 + 0xc)) {
		    do {
		      dVar13 = func_ii_7527(iVar11,iVar9,
		                            Method_Google_Protobuf_Collections_RepeatedField_double__get_Item__);
		      if (0.0 < dVar13) {
		        *(int *)(param1 + 0x24) = iVar9;
		        if (*(int *)(System_Math_TypeInfo + 0x74) == 0) {
		          func_ii_306000(System_Math_TypeInfo);
		        }
		        dVar13 = dVar13 * 100.0;
		        dVar2 = dVar13;
		        dVar8 = unnamed_function_4206(dVar13,&local_8);
		        uVar3 = (undefined4)((ulonglong)dVar2 >> 0x20);
		        if (0.0 <= dVar13) {
		          if (dVar8 == 0.5) {
		            dVar13 = (double)CONCAT44(local_8._4_4_,local_8._0_4_);
		            if (ABS(dVar13) < 9.223372036854776e+18) {
		              uVar16 = (ulonglong)dVar13;
		            }
		            else {
		              uVar16 = 0;
		            }
		            if ((uVar16 & 1) != 0) {
		              dVar13 = dVar13 + 1.0;
		            }
		          }
		          else {
		            dVar13 = FLOOR(dVar13 + 0.5);
		          }
		        }
		        else if (dVar8 == -0.5) {
		          dVar13 = (double)CONCAT44(local_8._4_4_,local_8._0_4_);
		          if (ABS(dVar13) < 9.223372036854776e+18) {
		            uVar16 = (ulonglong)dVar13;
		          }
		          else {
		            uVar16 = 0;
		          }
		          if ((uVar16 & 1) != 0) {
		            dVar13 = dVar13 + -1.0;
		          }
		        }
		        else {
		          dVar13 = CEIL(dVar13 + -0.5);
		        }
		        if (ABS(dVar13) < 2147483648.0) {
		          iVar9 = (int)dVar13;
		        }
		        else {
		          iVar9 = -0x80000000;
		        }
		        *(int *)(param1 + 0x20) = iVar9;
		        iVar10 = *(int *)(param1 + 0xc);
		        break;
		      }
		      iVar9 = iVar9 + 1;
		      iVar10 = *(int *)(param1 + 0xc);
		      iVar11 = *(int *)(iVar10 + 0x28);
		    } while (iVar9 < *(int *)(iVar11 + 0xc));
		  }
		  if (*(int *)(iVar10 + 0x2c) != 0) {
		    dVar13 = *(double *)(*(int *)(iVar10 + 0x2c) + 0x10);
		    if (*(int *)(System_Math_TypeInfo + 0x74) == 0) {
		      func_ii_306000(System_Math_TypeInfo);
		    }
		    dVar13 = dVar13 * 100.0;
		    dVar2 = dVar13;
		    dVar8 = unnamed_function_4206(dVar13,&local_8);
		    uVar3 = (undefined4)((ulonglong)dVar2 >> 0x20);
		    if (0.0 <= dVar13) {
		      if (dVar8 == 0.5) {
		        dVar13 = (double)CONCAT44(local_8._4_4_,local_8._0_4_);
		        if (ABS(dVar13) < 9.223372036854776e+18) {
		          uVar16 = (ulonglong)dVar13;
		        }
		        else {
		          uVar16 = 0;
		        }
		        if ((uVar16 & 1) != 0) {
		          dVar13 = dVar13 + 1.0;
		        }
		      }
		      else {
		        dVar13 = FLOOR(dVar13 + 0.5);
		      }
		    }
		    else if (dVar8 == -0.5) {
		      dVar13 = (double)CONCAT44(local_8._4_4_,local_8._0_4_);
		      if (ABS(dVar13) < 9.223372036854776e+18) {
		        uVar16 = (ulonglong)dVar13;
		      }
		      else {
		        uVar16 = 0;
		      }
		      if ((uVar16 & 1) != 0) {
		        dVar13 = dVar13 + -1.0;
		      }
		    }
		    else {
		      dVar13 = CEIL(dVar13 + -0.5);
		    }
		    if (ABS(dVar13) < 2147483648.0) {
		      iVar9 = (int)dVar13;
		    }
		    else {
		      iVar9 = -0x80000000;
		    }
		    *(int *)(param1 + 0x1c) = iVar9;
		    uVar15 = 0;
		    iVar9 = *param4;
		    if (*(ushort *)(iVar9 + 0xb6) != 0) {
		      do {
		        if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar9 + 0x58) + uVar15 * 8)) {
		          puVar4 = (uint *)(*(int *)(*(int *)(iVar9 + 0x58) + uVar15 * 8 + 4) * 8 + iVar9 + 0xd0);
		          goto code_r0x80deaaed;
		        }
		        uVar15 = uVar15 + 1;
		      } while (*(ushort *)(iVar9 + 0xb6) != uVar15);
		    }
		    puVar4 = (uint *)func_ii_1080(param4,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x80deaaed:
		    uVar1 = CONCAT44(uVar3,param4);
		    uVar5 = (**(code **)((ulonglong)*puVar4 * 4))(uVar1,puVar4[1]);
		    uVar3 = (undefined4)((ulonglong)uVar1 >> 0x20);
		    uVar5 = Core_Extensions_Dict_DictExt__GetAllArtikulTypeMetaFilterByType
		                      (uVar5,*(undefined4 *)(*(int *)(*(int *)(param1 + 0xc) + 0x2c) + 0xc),0);
		    *(undefined4 *)(param1 + 0x18) = uVar5;
		  }
		  uVar5 = unnamed_function_1417(System_Collections_Generic_List_BossInfo_BossAttackOption__TypeInfo)
		  ;
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (uVar5,Method_System_Collections_Generic_List_BossInfo_BossAttackOption___ctor__);
		  *(undefined4 *)(param1 + 0x28) = uVar5;
		  local_c = (int *)Google_Protobuf_Collections_RepeatedField_float___Equals
		                             (*(undefined4 *)(*(int *)(param1 + 0xc) + 0x20),
		                              Method_Google_Protobuf_Collections_RepeatedField_BossTypeDic_Types_AttackOption__GetEnumerator__
		                             );
		  local_8._0_4_ = 0;
		  local_8._4_4_ = &local_c;
		code_r0x80deab7c:
		  do {
		    piVar7 = local_c;
		    iVar9 = *local_c;
		    if (*(ushort *)(iVar9 + 0xb6) != 0) {
		      uVar15 = 0;
		      do {
		        piVar14 = (int *)(*(int *)(iVar9 + 0x58) + uVar15 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar14) {
		          puVar6 = (undefined4 *)(iVar9 + piVar14[1] * 8 + 0xc0);
		          goto code_r0x80deac10;
		        }
		        uVar15 = uVar15 + 1;
		      } while (*(ushort *)(iVar9 + 0xb6) != uVar15);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar6 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_c,
		                        System_Collections_IEnumerator_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80deae3d:
		      DAT_ram_009d3e38 = 0;
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80deae45;
		    }
		code_r0x80deac10:
		    DAT_ram_009d3e38 = 0;
		    iVar9 = import::env::invoke_iii(*puVar6,piVar7,puVar6[1]);
		    piVar7 = local_c;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80deae3d;
		    if (iVar9 == 0) {
		      iVar9 = 9;
		      goto code_r0x80deae92;
		    }
		    iVar9 = *local_c;
		    if (*(ushort *)(iVar9 + 0xb6) != 0) {
		      uVar15 = 0;
		      do {
		        piVar14 = (int *)(*(int *)(iVar9 + 0x58) + uVar15 * 8);
		        if (System_Collections_Generic_IEnumerator_BossTypeDic_Types_AttackOption__TypeInfo ==
		            *piVar14) {
		          puVar6 = (undefined4 *)(iVar9 + piVar14[1] * 8 + 0xc0);
		          goto code_r0x80deacea;
		        }
		        uVar15 = uVar15 + 1;
		      } while (*(ushort *)(iVar9 + 0xb6) != uVar15);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar6 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_c,
		                        System_Collections_Generic_IEnumerator_BossTypeDic_Types_AttackOption__TypeInfo
		                        ,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80deae29:
		      DAT_ram_009d3e38 = 0;
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80deae45;
		    }
		code_r0x80deacea:
		    DAT_ram_009d3e38 = 0;
		    uVar5 = import::env::invoke_iii(*puVar6,piVar7,puVar6[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80deae29;
		    iVar9 = *(int *)(param1 + 0x28);
		    DAT_ram_009d3e38 = 0;
		    uVar12 = import::env::invoke_ii
		                       (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                        Gameplay_Boss_Model_BossInfo_BossAttackOption_TypeInfo);
		    if (DAT_ram_009d3e38 == 1) break;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x35e,uVar12,uVar5,iVar9);
		    iVar11 = Method_System_Collections_Generic_List_BossInfo_BossAttackOption__Add__;
		    if (DAT_ram_009d3e38 == 1) break;
		    *(int *)(iVar9 + 0x10) = *(int *)(iVar9 + 0x10) + 1;
		    uVar15 = *(uint *)(iVar9 + 0xc);
		    if (uVar15 < *(uint *)(*(int *)(iVar9 + 8) + 0xc)) {
		      *(uint *)(iVar9 + 0xc) = uVar15 + 1;
		      *(undefined4 *)(*(int *)(iVar9 + 8) + uVar15 * 4 + 0x10) = uVar12;
		      goto code_r0x80deab7c;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar9,uVar12,
		               *(undefined4 *)(*(int *)(*(int *)(iVar11 + 0x10) + 0x60) + 0x38));
		  } while (DAT_ram_009d3e38 != 1);
		  DAT_ram_009d3e38 = 0;
		  uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80deae45:
		  iVar9 = global_1;
		  iVar11 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar9 == iVar11) {
		    piVar7 = (int *)import::env::__cxa_begin_catch(uVar5);
		    local_8._0_4_ = *piVar7;
		    iVar9 = 0;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar11 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar11 != 1) {
		code_r0x80deae92:
		      DAT_ram_009d3e38 = 0;
		      piVar7 = *local_8._4_4_;
		      if (piVar7 != (int *)0x0) {
		        uVar15 = 0;
		        iVar11 = *piVar7;
		        if (*(ushort *)(iVar11 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar11 + 0x58) + uVar15 * 8)) {
		              puVar4 = (uint *)(iVar11 + *(int *)(*(int *)(iVar11 + 0x58) + uVar15 * 8 + 4) * 8 +
		                               0xc0);
		              goto code_r0x80deaf0d;
		            }
		            uVar15 = uVar15 + 1;
		          } while (*(ushort *)(iVar11 + 0xb6) != uVar15);
		        }
		        puVar4 = (uint *)func_ii_1080(piVar7,System_IDisposable_TypeInfo,0);
		code_r0x80deaf0d:
		        uVar1 = CONCAT44(uVar3,piVar7);
		        (**(code **)((ulonglong)*puVar4 * 4))(uVar1,puVar4[1]);
		        uVar3 = (undefined4)((ulonglong)uVar1 >> 0x20);
		      }
		      if (local_8._0_4_ != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(local_8._0_4_);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      if (iVar9 != 0) {
		        if (iVar9 == 1) {
		          return;
		        }
		        if (iVar9 == 2) {
		          return;
		        }
		        if (iVar9 == 3) {
		          return;
		        }
		        if (iVar9 == 4) {
		          return;
		        }
		        if (iVar9 == 5) {
		          return;
		        }
		        if (iVar9 == 6) {
		          return;
		        }
		        if (iVar9 == 7) {
		          return;
		        }
		        if (iVar9 == 8) {
		          return;
		        }
		        if (iVar9 != 9) {
		          return;
		        }
		      }
		      uVar12 = *(undefined4 *)(*(int *)(param1 + 0xc) + 0x1c);
		      uVar5 = unnamed_function_1417(Core_Data_Skills_SkillCollection_TypeInfo);
		      Core_Data_Skills_SkillCollection___ctor(uVar5,uVar12,0);
		      uVar5 = Gameplay_UserInfo_Model_UserInfoModel__get_ExperienceProgress(uVar5,0);
		      *(undefined4 *)(param1 + 0x40) = uVar5;
		      iVar9 = unnamed_function_1417
		                        (System_Collections_Generic_List_BossInfo_BossRewardRangeData__TypeInfo);
		      GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		                (iVar9,Method_System_Collections_Generic_List_BossInfo_BossRewardRangeData___ctor__)
		      ;
		      local_10 = (int *)Google_Protobuf_Collections_RepeatedField_float___Equals
		                                  (*(undefined4 *)(*(int *)(param1 + 0xc) + 0x24),
		                                   Method_Google_Protobuf_Collections_RepeatedField_BossTypeDic_Types_RewardPlace__GetEnumerator__
		                                  );
		      local_8._0_4_ = 0;
		      local_8._4_4_ = &local_10;
		code_r0x80deaff5:
		      do {
		        piVar7 = local_10;
		        iVar11 = *local_10;
		        if (*(ushort *)(iVar11 + 0xb6) != 0) {
		          uVar15 = 0;
		          do {
		            piVar14 = (int *)(*(int *)(iVar11 + 0x58) + uVar15 * 8);
		            if (System_Collections_IEnumerator_TypeInfo == *piVar14) {
		              puVar6 = (undefined4 *)(iVar11 + piVar14[1] * 8 + 0xc0);
		              goto code_r0x80deb089;
		            }
		            uVar15 = uVar15 + 1;
		          } while (*(ushort *)(iVar11 + 0xb6) != uVar15);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar6 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_10,
		                            System_Collections_IEnumerator_TypeInfo,0);
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x80deb27b:
		          DAT_ram_009d3e38 = 0;
		          uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80deb283;
		        }
		code_r0x80deb089:
		        DAT_ram_009d3e38 = 0;
		        iVar11 = import::env::invoke_iii(*puVar6,piVar7,puVar6[1]);
		        piVar7 = local_10;
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80deb27b;
		        if (iVar11 == 0) {
		          iVar11 = 0xc;
		          goto code_r0x80deb2d0;
		        }
		        iVar11 = *local_10;
		        if (*(ushort *)(iVar11 + 0xb6) != 0) {
		          uVar15 = 0;
		          do {
		            piVar14 = (int *)(*(int *)(iVar11 + 0x58) + uVar15 * 8);
		            if (System_Collections_Generic_IEnumerator_BossTypeDic_Types_RewardPlace__TypeInfo ==
		                *piVar14) {
		              puVar6 = (undefined4 *)(iVar11 + piVar14[1] * 8 + 0xc0);
		              goto code_r0x80deb163;
		            }
		            uVar15 = uVar15 + 1;
		          } while (*(ushort *)(iVar11 + 0xb6) != uVar15);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar6 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_10,
		                            System_Collections_Generic_IEnumerator_BossTypeDic_Types_RewardPlace__TypeInfo
		                            ,0);
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x80deb267:
		          DAT_ram_009d3e38 = 0;
		          uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80deb283;
		        }
		code_r0x80deb163:
		        DAT_ram_009d3e38 = 0;
		        uVar5 = import::env::invoke_iii(*puVar6,piVar7,puVar6[1]);
		        iVar11 = DAT_ram_009d3e38;
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80deb267;
		        DAT_ram_009d3e38 = 0;
		        uVar5 = import::env::invoke_iii
		                          (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x360,uVar5,iVar11);
		        iVar11 = Method_System_Collections_Generic_List_BossInfo_BossRewardRangeData__Add__;
		        if (DAT_ram_009d3e38 == 1) break;
		        *(int *)(iVar9 + 0x10) = *(int *)(iVar9 + 0x10) + 1;
		        uVar15 = *(uint *)(iVar9 + 0xc);
		        if (uVar15 < *(uint *)(*(int *)(iVar9 + 8) + 0xc)) {
		          *(uint *)(iVar9 + 0xc) = uVar15 + 1;
		          *(undefined4 *)(*(int *)(iVar9 + 8) + uVar15 * 4 + 0x10) = uVar5;
		          goto code_r0x80deaff5;
		        }
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar9,uVar5,
		                   *(undefined4 *)(*(int *)(*(int *)(iVar11 + 0x10) + 0x60) + 0x38));
		      } while (DAT_ram_009d3e38 != 1);
		      DAT_ram_009d3e38 = 0;
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80deb283:
		      iVar11 = global_1;
		      iVar10 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar11 == iVar10) {
		        piVar7 = (int *)import::env::__cxa_begin_catch(uVar5);
		        local_8._0_4_ = *piVar7;
		        iVar11 = 0;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_v(0x123);
		        iVar10 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar10 != 1) {
		code_r0x80deb2d0:
		          DAT_ram_009d3e38 = 0;
		          piVar7 = *local_8._4_4_;
		          if (piVar7 != (int *)0x0) {
		            uVar15 = 0;
		            iVar10 = *piVar7;
		            if (*(ushort *)(iVar10 + 0xb6) != 0) {
		              do {
		                if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar10 + 0x58) + uVar15 * 8)) {
		                  puVar4 = (uint *)(iVar10 + *(int *)(*(int *)(iVar10 + 0x58) + uVar15 * 8 + 4) * 8
		                                   + 0xc0);
		                  goto code_r0x80deb34b;
		                }
		                uVar15 = uVar15 + 1;
		              } while (*(ushort *)(iVar10 + 0xb6) != uVar15);
		            }
		            puVar4 = (uint *)func_ii_1080(piVar7,System_IDisposable_TypeInfo,0);
		code_r0x80deb34b:
		            uVar1 = CONCAT44(uVar3,piVar7);
		            (**(code **)((ulonglong)*puVar4 * 4))(uVar1,puVar4[1]);
		            uVar3 = (undefined4)((ulonglong)uVar1 >> 0x20);
		          }
		          if (local_8._0_4_ != 0) {
		            System_Data_DataSet__ValidateLocaleConstraint(local_8._0_4_);
		            do {
		              halt_trap();
		            } while( true );
		          }
		          if ((iVar11 != 0) &&
		             (((((iVar11 == 1 || (iVar11 == 2)) || (iVar11 == 3)) ||
		               ((((iVar11 == 4 || (iVar11 == 5)) ||
		                 ((iVar11 == 6 || ((iVar11 == 7 || (iVar11 == 8)))))) || (iVar11 == 9)))) ||
		              (((iVar11 == 10 || (iVar11 == 0xb)) || (iVar11 != 0xc)))))) {
		            return;
		          }
		          if (*(int *)(Gameplay_Boss_Model_BossInfo___c_TypeInfo + 0x74) == 0) {
		            func_ii_306000(Gameplay_Boss_Model_BossInfo___c_TypeInfo);
		          }
		          puVar6 = *(undefined4 **)(Gameplay_Boss_Model_BossInfo___c_TypeInfo + 0x5c);
		          iVar11 = puVar6[1];
		          if (iVar11 == 0) {
		            if (*(int *)(Gameplay_Boss_Model_BossInfo___c_TypeInfo + 0x74) == 0) {
		              func_ii_306000(Gameplay_Boss_Model_BossInfo___c_TypeInfo);
		              puVar6 = *(undefined4 **)(Gameplay_Boss_Model_BossInfo___c_TypeInfo + 0x5c);
		            }
		            uVar5 = *puVar6;
		            iVar11 = unnamed_function_1417(System_Func_BossInfo_BossRewardRangeData__uint__TypeInfo)
		            ;
		            System_Collections_Generic_Dictionary_KeyCollection_uint__object___GetEnumerator
		                      (iVar11,uVar5,Method_Gameplay_Boss_Model_BossInfo___c___ctor_b__58_0__,0);
		            *(int *)(*(int *)(Gameplay_Boss_Model_BossInfo___c_TypeInfo + 0x5c) + 4) = iVar11;
		          }
		          uVar5 = System_Linq_Enumerable__Min___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType_
		                            (iVar9,iVar11,
		                             Method_System_Linq_Enumerable_OrderBy_BossInfo_BossRewardRangeData__uint___
		                            );
		          iVar9 = System_Linq_Enumerable__Select_object__object_
		                            (uVar5,
		                             Method_System_Linq_Enumerable_ToList_BossInfo_BossRewardRangeData___);
		          *(int *)(param1 + 0x44) = iVar9;
		          iVar11 = *(int *)(*(int *)(param1 + 0xc) + 0x34);
		          if (0 < *(int *)(iVar11 + 0xc)) {
		            uVar5 = Gameplay_Boss_Model_BossInfo_BossRewardRangeData__set_Label(iVar11,iVar9);
		            iVar11 = Method_System_Collections_Generic_List_BossInfo_BossRewardRangeData__Add__;
		            *(int *)(iVar9 + 0x10) = *(int *)(iVar9 + 0x10) + 1;
		            uVar15 = *(uint *)(iVar9 + 0xc);
		            if (uVar15 < *(uint *)(*(int *)(iVar9 + 8) + 0xc)) {
		              *(uint *)(iVar9 + 0xc) = uVar15 + 1;
		              *(undefined4 *)(*(int *)(iVar9 + 8) + uVar15 * 4 + 0x10) = uVar5;
		            }
		            else {
		              System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                        (iVar9,uVar5,
		                         *(undefined4 *)(*(int *)(*(int *)(iVar11 + 0x10) + 0x60) + 0x38));
		            }
		          }
		          iVar9 = *(int *)(*(int *)(param1 + 0xc) + 0x38);
		          if (0 < *(int *)(iVar9 + 0xc)) {
		            iVar11 = *(int *)(param1 + 0x44);
		            uVar5 = Gameplay_Boss_Model_BossInfo_BossRewardRangeData__CreateWinReward(iVar9,iVar11);
		            iVar9 = Method_System_Collections_Generic_List_BossInfo_BossRewardRangeData__Add__;
		            *(int *)(iVar11 + 0x10) = *(int *)(iVar11 + 0x10) + 1;
		            uVar15 = *(uint *)(iVar11 + 0xc);
		            if (uVar15 < *(uint *)(*(int *)(iVar11 + 8) + 0xc)) {
		              *(uint *)(iVar11 + 0xc) = uVar15 + 1;
		              *(undefined4 *)(*(int *)(iVar11 + 8) + uVar15 * 4 + 0x10) = uVar5;
		            }
		            else {
		              System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                        (iVar11,uVar5,
		                         *(undefined4 *)(*(int *)(*(int *)(iVar9 + 0x10) + 0x60) + 0x38));
		            }
		          }
		          iVar9 = *(int *)(param1 + 0x44);
		          if (0 < *(int *)(iVar9 + 0xc)) {
		            iVar11 = 0;
		            do {
		              iVar9 = System_Linq_Enumerable__ToList_object_
		                                (iVar9,iVar11,
		                                 Method_System_Collections_Generic_List_BossInfo_BossRewardRangeData__get_Item__
		                                );
		              *(int *)(iVar9 + 0xc) = iVar11;
		              iVar11 = iVar11 + 1;
		              iVar9 = *(int *)(param1 + 0x44);
		            } while (iVar11 < *(int *)(iVar9 + 0xc));
		          }
		          uVar5 = unnamed_function_1417
		                            (System_Collections_Generic_List_BossInfo_BossCultSpellData__TypeInfo);
		          GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		                    (uVar5,
		                     Method_System_Collections_Generic_List_BossInfo_BossCultSpellData___ctor__);
		          *(undefined4 *)(param1 + 0x48) = uVar5;
		          local_14 = (int *)Google_Protobuf_Collections_RepeatedField_float___Equals
		                                      (*(undefined4 *)(*(int *)(param1 + 0xc) + 0x30),
		                                       Method_Google_Protobuf_Collections_RepeatedField_BossTypeDic_Types_CultSpell__GetEnumerator__
		                                      );
		          local_8._0_4_ = 0;
		          local_8._4_4_ = &local_14;
		code_r0x80deb5d3:
		          do {
		            piVar7 = local_14;
		            iVar9 = *local_14;
		            if (*(ushort *)(iVar9 + 0xb6) != 0) {
		              uVar15 = 0;
		              do {
		                piVar14 = (int *)(*(int *)(iVar9 + 0x58) + uVar15 * 8);
		                if (System_Collections_IEnumerator_TypeInfo == *piVar14) {
		                  puVar6 = (undefined4 *)(iVar9 + piVar14[1] * 8 + 0xc0);
		                  goto code_r0x80deb667;
		                }
		                uVar15 = uVar15 + 1;
		              } while (*(ushort *)(iVar9 + 0xb6) != uVar15);
		            }
		            DAT_ram_009d3e38 = 0;
		            puVar6 = (undefined4 *)
		                     import::env::invoke_iiii
		                               (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_14,
		                                System_Collections_IEnumerator_TypeInfo,0);
		            if (DAT_ram_009d3e38 == 1) {
		code_r0x80deb890:
		              DAT_ram_009d3e38 = 0;
		              uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		              goto code_r0x80deb898;
		            }
		code_r0x80deb667:
		            DAT_ram_009d3e38 = 0;
		            iVar9 = import::env::invoke_iii(*puVar6,piVar7,puVar6[1]);
		            piVar7 = local_14;
		            if (DAT_ram_009d3e38 == 1) goto code_r0x80deb890;
		            if (iVar9 == 0) goto code_r0x80deb8e1;
		            iVar9 = *local_14;
		            if (*(ushort *)(iVar9 + 0xb6) != 0) {
		              uVar15 = 0;
		              do {
		                piVar14 = (int *)(*(int *)(iVar9 + 0x58) + uVar15 * 8);
		                if (System_Collections_Generic_IEnumerator_BossTypeDic_Types_CultSpell__TypeInfo ==
		                    *piVar14) {
		                  puVar6 = (undefined4 *)(iVar9 + piVar14[1] * 8 + 0xc0);
		                  goto code_r0x80deb744;
		                }
		                uVar15 = uVar15 + 1;
		              } while (*(ushort *)(iVar9 + 0xb6) != uVar15);
		            }
		            DAT_ram_009d3e38 = 0;
		            puVar6 = (undefined4 *)
		                     import::env::invoke_iiii
		                               (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_14,
		                                System_Collections_Generic_IEnumerator_BossTypeDic_Types_CultSpell__TypeInfo
		                                ,0);
		            if (DAT_ram_009d3e38 == 1) {
		code_r0x80deb87c:
		              DAT_ram_009d3e38 = 0;
		              uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		              goto code_r0x80deb898;
		            }
		code_r0x80deb744:
		            DAT_ram_009d3e38 = 0;
		            uVar5 = import::env::invoke_iii(*puVar6,piVar7,puVar6[1]);
		            if (DAT_ram_009d3e38 == 1) goto code_r0x80deb87c;
		            iVar9 = *(int *)(param1 + 0x48);
		            DAT_ram_009d3e38 = 0;
		            uVar12 = import::env::invoke_ii
		                               (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                                Gameplay_Boss_Model_BossInfo_BossCultSpellData_TypeInfo);
		            if (DAT_ram_009d3e38 == 1) break;
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_viii
		                      (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x362,uVar12,uVar5,iVar9);
		            iVar11 = Method_System_Collections_Generic_List_BossInfo_BossCultSpellData__Add__;
		            if (DAT_ram_009d3e38 == 1) break;
		            *(int *)(iVar9 + 0x10) = *(int *)(iVar9 + 0x10) + 1;
		            uVar15 = *(uint *)(iVar9 + 0xc);
		            if (uVar15 < *(uint *)(*(int *)(iVar9 + 8) + 0xc)) {
		              *(uint *)(iVar9 + 0xc) = uVar15 + 1;
		              *(undefined4 *)(*(int *)(iVar9 + 8) + uVar15 * 4 + 0x10) = uVar12;
		              goto code_r0x80deb5d3;
		            }
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_viii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar9,uVar12,
		                       *(undefined4 *)(*(int *)(*(int *)(iVar11 + 0x10) + 0x60) + 0x38));
		          } while (DAT_ram_009d3e38 != 1);
		          DAT_ram_009d3e38 = 0;
		          uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80deb898:
		          iVar9 = global_1;
		          iVar11 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		          if (iVar9 == iVar11) {
		            piVar7 = (int *)import::env::__cxa_begin_catch(uVar5);
		            local_8._0_4_ = *piVar7;
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_v(0x123);
		            iVar9 = DAT_ram_009d3e38;
		            DAT_ram_009d3e38 = 0;
		            if (iVar9 != 1) {
		code_r0x80deb8e1:
		              DAT_ram_009d3e38 = 0;
		              piVar7 = *local_8._4_4_;
		              if (piVar7 != (int *)0x0) {
		                uVar15 = 0;
		                iVar9 = *piVar7;
		                if (*(ushort *)(iVar9 + 0xb6) != 0) {
		                  do {
		                    if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar9 + 0x58) + uVar15 * 8)
		                       ) {
		                      puVar4 = (uint *)(iVar9 + *(int *)(*(int *)(iVar9 + 0x58) + uVar15 * 8 + 4) *
		                                                8 + 0xc0);
		                      goto code_r0x80deb95c;
		                    }
		                    uVar15 = uVar15 + 1;
		                  } while (*(ushort *)(iVar9 + 0xb6) != uVar15);
		                }
		                puVar4 = (uint *)func_ii_1080(piVar7,System_IDisposable_TypeInfo,0);
		code_r0x80deb95c:
		                (**(code **)((ulonglong)*puVar4 * 4))(CONCAT44(uVar3,piVar7),puVar4[1]);
		              }
		              if (local_8._0_4_ == 0) {
		                return;
		              }
		              System_Data_DataSet__ValidateLocaleConstraint(local_8._0_4_);
		              do {
		                halt_trap();
		              } while( true );
		            }
		            uVar5 = import::env::__cxa_find_matching_catch_2();
		          }
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_000017c8 + 0x363,&local_8);
		          goto joined_r0x80deb9b0;
		        }
		        uVar5 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_000017c8 + 0x361,&local_8);
		      goto joined_r0x80deb9b0;
		    }
		    uVar5 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_000017c8 + 0x35f,&local_8);
		joined_r0x80deb9b0:
		  if (DAT_ram_009d3e38 == 1) {
		    DAT_ram_009d3e38 = 0;
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::__resumeException(uVar5);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

}
