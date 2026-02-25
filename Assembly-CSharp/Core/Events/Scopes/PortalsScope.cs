using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Application;
using Core.Gameplay;
using Il2CppDummyDll;
using Protocol.Common;
using UI.Windows;

namespace Core.Events.Scopes
{
	// Token: 0x0200101B RID: 4123
	[Token(Token = "0x200101B")]
	public class PortalsScope : AbstractEventBusScope
	{
		// Token: 0x0600617A RID: 24954 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600617A")]
		[Address(RVA = "0xADA5", Offset = "0xADA5", VA = "0xADA5", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x0600617B RID: 24955 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600617B")]
		[Address(RVA = "0xADA6", Offset = "0xADA6", VA = "0xADA6")]
		public PortalsScope()
		{
		}

		// Token: 0x04003453 RID: 13395
		[Token(Token = "0x4003453")]
		[FieldOffset(Offset = "0x8")]
		public Action<PortalsScope.BattleBeginEventArgs> BattleBeginEvent;

		// Token: 0x04003454 RID: 13396
		[Token(Token = "0x4003454")]
		[FieldOffset(Offset = "0xC")]
		public Action<PortalsScope.BattleFinishedArgs> BattleFinishedEvent;

		// Token: 0x04003455 RID: 13397
		[Token(Token = "0x4003455")]
		[FieldOffset(Offset = "0x10")]
		public Action<PortalsScope.OpenWindowEventArgs> OpenWindowEvent;

		// Token: 0x04003456 RID: 13398
		[Token(Token = "0x4003456")]
		[FieldOffset(Offset = "0x14")]
		public Action<PortalsScope.BuyItemEventArgs> BuyItemEvent;

		// Token: 0x0200101C RID: 4124
		[Token(Token = "0x200101C")]
		public abstract class BasePortalsEventArgs : BaseEventBusEventArgs
		{
			// Token: 0x0600617C RID: 24956 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600617C")]
			[Address(RVA = "0xADA7", Offset = "0xADA7", VA = "0xADA7")]
			protected BasePortalsEventArgs(IApp app, IGame game, long eventId)
			{
			}

			// Token: 0x17001358 RID: 4952
			// (get) Token: 0x0600617D RID: 24957 RVA: 0x00011D00 File Offset: 0x0000FF00
			[Token(Token = "0x17001358")]
			public long EventId
			{
				[Token(Token = "0x600617D")]
				[Address(RVA = "0xADA8", Offset = "0xADA8", VA = "0xADA8")]
				[CompilerGenerated]
				get
				{
					return 0L;
				}
			}
		}

		// Token: 0x0200101D RID: 4125
		[Token(Token = "0x200101D")]
		public class BattleBeginEventArgs : PortalsScope.BasePortalsEventArgs
		{
			// Token: 0x0600617E RID: 24958 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600617E")]
			[Address(RVA = "0xADA9", Offset = "0xADA9", VA = "0xADA9")]
			public BattleBeginEventArgs(IApp app, IGame game, long eventId, long eventBalance, ulong opponentId, int battleId, ResourceSet price, ResourceSet balance)
			{
			}

			// Token: 0x17001359 RID: 4953
			// (get) Token: 0x0600617F RID: 24959 RVA: 0x00011D18 File Offset: 0x0000FF18
			[Token(Token = "0x17001359")]
			public long EventBalance
			{
				[Token(Token = "0x600617F")]
				[Address(RVA = "0xADAA", Offset = "0xADAA", VA = "0xADAA")]
				[CompilerGenerated]
				get
				{
					return 0L;
				}
			}

			// Token: 0x1700135A RID: 4954
			// (get) Token: 0x06006180 RID: 24960 RVA: 0x00011D30 File Offset: 0x0000FF30
			[Token(Token = "0x1700135A")]
			public ulong OpponentId
			{
				[Token(Token = "0x6006180")]
				[Address(RVA = "0xADAB", Offset = "0xADAB", VA = "0xADAB")]
				[CompilerGenerated]
				get
				{
					return 0UL;
				}
			}

			// Token: 0x1700135B RID: 4955
			// (get) Token: 0x06006181 RID: 24961 RVA: 0x00011D48 File Offset: 0x0000FF48
			[Token(Token = "0x1700135B")]
			public int BattleId
			{
				[Token(Token = "0x6006181")]
				[Address(RVA = "0xADAC", Offset = "0xADAC", VA = "0xADAC")]
				[CompilerGenerated]
				get
				{
					return 0;
				}
			}

			// Token: 0x1700135C RID: 4956
			// (get) Token: 0x06006182 RID: 24962 RVA: 0x00011D60 File Offset: 0x0000FF60
			[Token(Token = "0x1700135C")]
			public long AmountDiamonds
			{
				[Token(Token = "0x6006182")]
				[Address(RVA = "0xADAD", Offset = "0xADAD", VA = "0xADAD")]
				[CompilerGenerated]
				get
				{
					return 0L;
				}
			}

			// Token: 0x1700135D RID: 4957
			// (get) Token: 0x06006183 RID: 24963 RVA: 0x00011D78 File Offset: 0x0000FF78
			[Token(Token = "0x1700135D")]
			public long AmountCrystals
			{
				[Token(Token = "0x6006183")]
				[Address(RVA = "0xADAE", Offset = "0xADAE", VA = "0xADAE")]
				[CompilerGenerated]
				get
				{
					return 0L;
				}
			}

			// Token: 0x1700135E RID: 4958
			// (get) Token: 0x06006184 RID: 24964 RVA: 0x00011D90 File Offset: 0x0000FF90
			[Token(Token = "0x1700135E")]
			public long AmountEnergy
			{
				[Token(Token = "0x6006184")]
				[Address(RVA = "0xADAF", Offset = "0xADAF", VA = "0xADAF")]
				[CompilerGenerated]
				get
				{
					return 0L;
				}
			}

			// Token: 0x1700135F RID: 4959
			// (get) Token: 0x06006185 RID: 24965 RVA: 0x00011DA8 File Offset: 0x0000FFA8
			[Token(Token = "0x1700135F")]
			public long AmountOnyxes
			{
				[Token(Token = "0x6006185")]
				[Address(RVA = "0xADB0", Offset = "0xADB0", VA = "0xADB0")]
				[CompilerGenerated]
				get
				{
					return 0L;
				}
			}

			// Token: 0x17001360 RID: 4960
			// (get) Token: 0x06006186 RID: 24966 RVA: 0x00011DC0 File Offset: 0x0000FFC0
			[Token(Token = "0x17001360")]
			public int AmountFragments
			{
				[Token(Token = "0x6006186")]
				[Address(RVA = "0xADB1", Offset = "0xADB1", VA = "0xADB1")]
				[CompilerGenerated]
				get
				{
					return 0;
				}
			}

			// Token: 0x17001361 RID: 4961
			// (get) Token: 0x06006187 RID: 24967 RVA: 0x00011DD8 File Offset: 0x0000FFD8
			[Token(Token = "0x17001361")]
			public long BalanceDiamonds
			{
				[Token(Token = "0x6006187")]
				[Address(RVA = "0xADB2", Offset = "0xADB2", VA = "0xADB2")]
				[CompilerGenerated]
				get
				{
					return 0L;
				}
			}

			// Token: 0x17001362 RID: 4962
			// (get) Token: 0x06006188 RID: 24968 RVA: 0x00011DF0 File Offset: 0x0000FFF0
			[Token(Token = "0x17001362")]
			public long BalanceCrystals
			{
				[Token(Token = "0x6006188")]
				[Address(RVA = "0xADB3", Offset = "0xADB3", VA = "0xADB3")]
				[CompilerGenerated]
				get
				{
					return 0L;
				}
			}

			// Token: 0x17001363 RID: 4963
			// (get) Token: 0x06006189 RID: 24969 RVA: 0x00011E08 File Offset: 0x00010008
			[Token(Token = "0x17001363")]
			public long BalanceEnergy
			{
				[Token(Token = "0x6006189")]
				[Address(RVA = "0xADB4", Offset = "0xADB4", VA = "0xADB4")]
				[CompilerGenerated]
				get
				{
					return 0L;
				}
			}

			// Token: 0x17001364 RID: 4964
			// (get) Token: 0x0600618A RID: 24970 RVA: 0x00011E20 File Offset: 0x00010020
			[Token(Token = "0x17001364")]
			public long BalanceOnyxes
			{
				[Token(Token = "0x600618A")]
				[Address(RVA = "0xADB5", Offset = "0xADB5", VA = "0xADB5")]
				[CompilerGenerated]
				get
				{
					return 0L;
				}
			}

			// Token: 0x17001365 RID: 4965
			// (get) Token: 0x0600618B RID: 24971 RVA: 0x00011E38 File Offset: 0x00010038
			[Token(Token = "0x17001365")]
			public int BalanceFragments
			{
				[Token(Token = "0x600618B")]
				[Address(RVA = "0xADB6", Offset = "0xADB6", VA = "0xADB6")]
				[CompilerGenerated]
				get
				{
					return 0;
				}
			}
		}

		// Token: 0x0200101E RID: 4126
		[Token(Token = "0x200101E")]
		public class BattleFinishedArgs : PortalsScope.BasePortalsEventArgs
		{
			// Token: 0x0600618C RID: 24972 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600618C")]
			[Address(RVA = "0xADB7", Offset = "0xADB7", VA = "0xADB7")]
			public BattleFinishedArgs(IApp app, IGame game, long eventId, long amount, ulong balance, IReadOnlyDictionary<int, int> combinations, int battleId, long stepTime, int stepNumber, ulong winnerId)
			{
			}

			// Token: 0x17001366 RID: 4966
			// (get) Token: 0x0600618D RID: 24973 RVA: 0x00011E50 File Offset: 0x00010050
			[Token(Token = "0x17001366")]
			public long Amount
			{
				[Token(Token = "0x600618D")]
				[Address(RVA = "0xADB8", Offset = "0xADB8", VA = "0xADB8")]
				[CompilerGenerated]
				get
				{
					return 0L;
				}
			}

			// Token: 0x17001367 RID: 4967
			// (get) Token: 0x0600618E RID: 24974 RVA: 0x00011E68 File Offset: 0x00010068
			[Token(Token = "0x17001367")]
			public ulong Balance
			{
				[Token(Token = "0x600618E")]
				[Address(RVA = "0xADB9", Offset = "0xADB9", VA = "0xADB9")]
				[CompilerGenerated]
				get
				{
					return 0UL;
				}
			}

			// Token: 0x17001368 RID: 4968
			// (get) Token: 0x0600618F RID: 24975 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17001368")]
			public IReadOnlyDictionary<int, int> Combinations
			{
				[Token(Token = "0x600618F")]
				[Address(RVA = "0xADBA", Offset = "0xADBA", VA = "0xADBA")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x17001369 RID: 4969
			// (get) Token: 0x06006190 RID: 24976 RVA: 0x00011E80 File Offset: 0x00010080
			[Token(Token = "0x17001369")]
			public int BattleId
			{
				[Token(Token = "0x6006190")]
				[Address(RVA = "0xADBB", Offset = "0xADBB", VA = "0xADBB")]
				[CompilerGenerated]
				get
				{
					return 0;
				}
			}

			// Token: 0x1700136A RID: 4970
			// (get) Token: 0x06006191 RID: 24977 RVA: 0x00011E98 File Offset: 0x00010098
			[Token(Token = "0x1700136A")]
			public long StepTime
			{
				[Token(Token = "0x6006191")]
				[Address(RVA = "0xADBC", Offset = "0xADBC", VA = "0xADBC")]
				[CompilerGenerated]
				get
				{
					return 0L;
				}
			}

			// Token: 0x1700136B RID: 4971
			// (get) Token: 0x06006192 RID: 24978 RVA: 0x00011EB0 File Offset: 0x000100B0
			[Token(Token = "0x1700136B")]
			public int StepNumber
			{
				[Token(Token = "0x6006192")]
				[Address(RVA = "0xADBD", Offset = "0xADBD", VA = "0xADBD")]
				[CompilerGenerated]
				get
				{
					return 0;
				}
			}

			// Token: 0x1700136C RID: 4972
			// (get) Token: 0x06006193 RID: 24979 RVA: 0x00011EC8 File Offset: 0x000100C8
			[Token(Token = "0x1700136C")]
			public ulong WinnerId
			{
				[Token(Token = "0x6006193")]
				[Address(RVA = "0xADBE", Offset = "0xADBE", VA = "0xADBE")]
				[CompilerGenerated]
				get
				{
					return 0UL;
				}
			}
		}

		// Token: 0x0200101F RID: 4127
		[Token(Token = "0x200101F")]
		public class OpenWindowEventArgs : PortalsScope.BasePortalsEventArgs
		{
			// Token: 0x06006194 RID: 24980 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006194")]
			[Address(RVA = "0xADBF", Offset = "0xADBF", VA = "0xADBF")]
			public OpenWindowEventArgs(IApp app, IGame game, long eventId, WindowOpenReasonSource openReasonSource)
			{
			}

			// Token: 0x1700136D RID: 4973
			// (get) Token: 0x06006195 RID: 24981 RVA: 0x00011EE0 File Offset: 0x000100E0
			[Token(Token = "0x1700136D")]
			public WindowOpenReasonSource OpenReasonSource
			{
				[Token(Token = "0x6006195")]
				[Address(RVA = "0xADC0", Offset = "0xADC0", VA = "0xADC0")]
				[CompilerGenerated]
				get
				{
					return WindowOpenReasonSource.DefaultSource;
				}
			}
		}

		// Token: 0x02001020 RID: 4128
		[Token(Token = "0x2001020")]
		public class BuyItemEventArgs : PortalsScope.BasePortalsEventArgs
		{
			// Token: 0x06006196 RID: 24982 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006196")]
			[Address(RVA = "0xADC1", Offset = "0xADC1", VA = "0xADC1")]
			public BuyItemEventArgs(IApp app, IGame game, long eventId, long amount, ulong balance, int articleId, int count)
			{
			}

			// Token: 0x1700136E RID: 4974
			// (get) Token: 0x06006197 RID: 24983 RVA: 0x00011EF8 File Offset: 0x000100F8
			[Token(Token = "0x1700136E")]
			public long Amount
			{
				[Token(Token = "0x6006197")]
				[Address(RVA = "0xADC2", Offset = "0xADC2", VA = "0xADC2")]
				[CompilerGenerated]
				get
				{
					return 0L;
				}
			}

			// Token: 0x1700136F RID: 4975
			// (get) Token: 0x06006198 RID: 24984 RVA: 0x00011F10 File Offset: 0x00010110
			[Token(Token = "0x1700136F")]
			public ulong Balance
			{
				[Token(Token = "0x6006198")]
				[Address(RVA = "0xADC3", Offset = "0xADC3", VA = "0xADC3")]
				[CompilerGenerated]
				get
				{
					return 0UL;
				}
			}

			// Token: 0x17001370 RID: 4976
			// (get) Token: 0x06006199 RID: 24985 RVA: 0x00011F28 File Offset: 0x00010128
			[Token(Token = "0x17001370")]
			public int ArticleId
			{
				[Token(Token = "0x6006199")]
				[Address(RVA = "0xADC4", Offset = "0xADC4", VA = "0xADC4")]
				[CompilerGenerated]
				get
				{
					return 0;
				}
			}

			// Token: 0x17001371 RID: 4977
			// (get) Token: 0x0600619A RID: 24986 RVA: 0x00011F40 File Offset: 0x00010140
			[Token(Token = "0x17001371")]
			public int Count
			{
				[Token(Token = "0x600619A")]
				[Address(RVA = "0xADC5", Offset = "0xADC5", VA = "0xADC5")]
				[CompilerGenerated]
				get
				{
					return 0;
				}
			}
		}
	}
}
