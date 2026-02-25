using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Application;
using Core.Gameplay;
using Il2CppDummyDll;
using UI.Windows;

namespace Core.Events.Scopes
{
	// Token: 0x0200102B RID: 4139
	[Token(Token = "0x200102B")]
	public class ThemeDuelScope : AbstractEventBusScope
	{
		// Token: 0x060061B2 RID: 25010 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60061B2")]
		[Address(RVA = "0xADDD", Offset = "0xADDD", VA = "0xADDD", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x060061B3 RID: 25011 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60061B3")]
		[Address(RVA = "0xADDE", Offset = "0xADDE", VA = "0xADDE")]
		public ThemeDuelScope()
		{
		}

		// Token: 0x04003486 RID: 13446
		[Token(Token = "0x4003486")]
		[FieldOffset(Offset = "0x8")]
		public Action<ThemeDuelScope.BattleBeginEventArgs> BattleBeginEvent;

		// Token: 0x04003487 RID: 13447
		[Token(Token = "0x4003487")]
		[FieldOffset(Offset = "0xC")]
		public Action<ThemeDuelScope.BattleFinishedArgs> BattleFinishedEvent;

		// Token: 0x04003488 RID: 13448
		[Token(Token = "0x4003488")]
		[FieldOffset(Offset = "0x10")]
		public Action<ThemeDuelScope.OpenWindowEventArgs> OpenWindowEvent;

		// Token: 0x04003489 RID: 13449
		[Token(Token = "0x4003489")]
		[FieldOffset(Offset = "0x14")]
		public Action<ThemeDuelScope.BuyItemEventArgs> BuyItemEvent;

		// Token: 0x0200102C RID: 4140
		[Token(Token = "0x200102C")]
		public abstract class BaseThemeDuelEventArgs : BaseEventBusEventArgs
		{
			// Token: 0x060061B4 RID: 25012 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60061B4")]
			[Address(RVA = "0xADDF", Offset = "0xADDF", VA = "0xADDF")]
			protected BaseThemeDuelEventArgs(IApp app, IGame game, long eventId)
			{
			}

			// Token: 0x1700137A RID: 4986
			// (get) Token: 0x060061B5 RID: 25013 RVA: 0x00011FD0 File Offset: 0x000101D0
			[Token(Token = "0x1700137A")]
			public long EventId
			{
				[Token(Token = "0x60061B5")]
				[Address(RVA = "0xADE0", Offset = "0xADE0", VA = "0xADE0")]
				[CompilerGenerated]
				get
				{
					return 0L;
				}
			}
		}

		// Token: 0x0200102D RID: 4141
		[Token(Token = "0x200102D")]
		public class BattleBeginEventArgs : ThemeDuelScope.BaseThemeDuelEventArgs
		{
			// Token: 0x060061B6 RID: 25014 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60061B6")]
			[Address(RVA = "0xADE1", Offset = "0xADE1", VA = "0xADE1")]
			public BattleBeginEventArgs(IApp app, IGame game, long eventId, long balance, ulong opponentId, int battleId, long amountDiamonds, long amountCrystals, long amountEnergy, long amountOnyxes, int amountFragments, long balanceDiamonds, long balanceCrystals, long balanceEnergy, long balanceOnyxes, int balanceFragments)
			{
			}

			// Token: 0x1700137B RID: 4987
			// (get) Token: 0x060061B7 RID: 25015 RVA: 0x00011FE8 File Offset: 0x000101E8
			[Token(Token = "0x1700137B")]
			public long Balance
			{
				[Token(Token = "0x60061B7")]
				[Address(RVA = "0xADE2", Offset = "0xADE2", VA = "0xADE2")]
				[CompilerGenerated]
				get
				{
					return 0L;
				}
			}

			// Token: 0x1700137C RID: 4988
			// (get) Token: 0x060061B8 RID: 25016 RVA: 0x00012000 File Offset: 0x00010200
			[Token(Token = "0x1700137C")]
			public ulong OpponentId
			{
				[Token(Token = "0x60061B8")]
				[Address(RVA = "0xADE3", Offset = "0xADE3", VA = "0xADE3")]
				[CompilerGenerated]
				get
				{
					return 0UL;
				}
			}

			// Token: 0x1700137D RID: 4989
			// (get) Token: 0x060061B9 RID: 25017 RVA: 0x00012018 File Offset: 0x00010218
			[Token(Token = "0x1700137D")]
			public int BattleId
			{
				[Token(Token = "0x60061B9")]
				[Address(RVA = "0xADE4", Offset = "0xADE4", VA = "0xADE4")]
				[CompilerGenerated]
				get
				{
					return 0;
				}
			}

			// Token: 0x1700137E RID: 4990
			// (get) Token: 0x060061BA RID: 25018 RVA: 0x00012030 File Offset: 0x00010230
			[Token(Token = "0x1700137E")]
			public long AmountDiamonds
			{
				[Token(Token = "0x60061BA")]
				[Address(RVA = "0xADE5", Offset = "0xADE5", VA = "0xADE5")]
				[CompilerGenerated]
				get
				{
					return 0L;
				}
			}

			// Token: 0x1700137F RID: 4991
			// (get) Token: 0x060061BB RID: 25019 RVA: 0x00012048 File Offset: 0x00010248
			[Token(Token = "0x1700137F")]
			public long AmountCrystals
			{
				[Token(Token = "0x60061BB")]
				[Address(RVA = "0xADE6", Offset = "0xADE6", VA = "0xADE6")]
				[CompilerGenerated]
				get
				{
					return 0L;
				}
			}

			// Token: 0x17001380 RID: 4992
			// (get) Token: 0x060061BC RID: 25020 RVA: 0x00012060 File Offset: 0x00010260
			[Token(Token = "0x17001380")]
			public long AmountEnergy
			{
				[Token(Token = "0x60061BC")]
				[Address(RVA = "0xADE7", Offset = "0xADE7", VA = "0xADE7")]
				[CompilerGenerated]
				get
				{
					return 0L;
				}
			}

			// Token: 0x17001381 RID: 4993
			// (get) Token: 0x060061BD RID: 25021 RVA: 0x00012078 File Offset: 0x00010278
			[Token(Token = "0x17001381")]
			public long AmountOnyxes
			{
				[Token(Token = "0x60061BD")]
				[Address(RVA = "0xADE8", Offset = "0xADE8", VA = "0xADE8")]
				[CompilerGenerated]
				get
				{
					return 0L;
				}
			}

			// Token: 0x17001382 RID: 4994
			// (get) Token: 0x060061BE RID: 25022 RVA: 0x00012090 File Offset: 0x00010290
			[Token(Token = "0x17001382")]
			public int AmountFragments
			{
				[Token(Token = "0x60061BE")]
				[Address(RVA = "0xADE9", Offset = "0xADE9", VA = "0xADE9")]
				[CompilerGenerated]
				get
				{
					return 0;
				}
			}

			// Token: 0x17001383 RID: 4995
			// (get) Token: 0x060061BF RID: 25023 RVA: 0x000120A8 File Offset: 0x000102A8
			[Token(Token = "0x17001383")]
			public long BalanceDiamonds
			{
				[Token(Token = "0x60061BF")]
				[Address(RVA = "0xADEA", Offset = "0xADEA", VA = "0xADEA")]
				[CompilerGenerated]
				get
				{
					return 0L;
				}
			}

			// Token: 0x17001384 RID: 4996
			// (get) Token: 0x060061C0 RID: 25024 RVA: 0x000120C0 File Offset: 0x000102C0
			[Token(Token = "0x17001384")]
			public long BalanceCrystals
			{
				[Token(Token = "0x60061C0")]
				[Address(RVA = "0xADEB", Offset = "0xADEB", VA = "0xADEB")]
				[CompilerGenerated]
				get
				{
					return 0L;
				}
			}

			// Token: 0x17001385 RID: 4997
			// (get) Token: 0x060061C1 RID: 25025 RVA: 0x000120D8 File Offset: 0x000102D8
			[Token(Token = "0x17001385")]
			public long BalanceEnergy
			{
				[Token(Token = "0x60061C1")]
				[Address(RVA = "0xADEC", Offset = "0xADEC", VA = "0xADEC")]
				[CompilerGenerated]
				get
				{
					return 0L;
				}
			}

			// Token: 0x17001386 RID: 4998
			// (get) Token: 0x060061C2 RID: 25026 RVA: 0x000120F0 File Offset: 0x000102F0
			[Token(Token = "0x17001386")]
			public long BalanceOnyxes
			{
				[Token(Token = "0x60061C2")]
				[Address(RVA = "0xADED", Offset = "0xADED", VA = "0xADED")]
				[CompilerGenerated]
				get
				{
					return 0L;
				}
			}

			// Token: 0x17001387 RID: 4999
			// (get) Token: 0x060061C3 RID: 25027 RVA: 0x00012108 File Offset: 0x00010308
			[Token(Token = "0x17001387")]
			public int BalanceFragments
			{
				[Token(Token = "0x60061C3")]
				[Address(RVA = "0xADEE", Offset = "0xADEE", VA = "0xADEE")]
				[CompilerGenerated]
				get
				{
					return 0;
				}
			}
		}

		// Token: 0x0200102E RID: 4142
		[Token(Token = "0x200102E")]
		public class BattleFinishedArgs : ThemeDuelScope.BaseThemeDuelEventArgs
		{
			// Token: 0x060061C4 RID: 25028 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60061C4")]
			[Address(RVA = "0xADEF", Offset = "0xADEF", VA = "0xADEF")]
			public BattleFinishedArgs(IApp app, IGame game, long eventId, long amount, long balance, IReadOnlyDictionary<int, int> combinations, int battleId, long stepTime, int stepNumber, ulong winnerId)
			{
			}

			// Token: 0x17001388 RID: 5000
			// (get) Token: 0x060061C5 RID: 25029 RVA: 0x00012120 File Offset: 0x00010320
			[Token(Token = "0x17001388")]
			public long Amount
			{
				[Token(Token = "0x60061C5")]
				[Address(RVA = "0xADF0", Offset = "0xADF0", VA = "0xADF0")]
				[CompilerGenerated]
				get
				{
					return 0L;
				}
			}

			// Token: 0x17001389 RID: 5001
			// (get) Token: 0x060061C6 RID: 25030 RVA: 0x00012138 File Offset: 0x00010338
			[Token(Token = "0x17001389")]
			public long Balance
			{
				[Token(Token = "0x60061C6")]
				[Address(RVA = "0xADF1", Offset = "0xADF1", VA = "0xADF1")]
				[CompilerGenerated]
				get
				{
					return 0L;
				}
			}

			// Token: 0x1700138A RID: 5002
			// (get) Token: 0x060061C7 RID: 25031 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x1700138A")]
			public IReadOnlyDictionary<int, int> Combinations
			{
				[Token(Token = "0x60061C7")]
				[Address(RVA = "0xADF2", Offset = "0xADF2", VA = "0xADF2")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x1700138B RID: 5003
			// (get) Token: 0x060061C8 RID: 25032 RVA: 0x00012150 File Offset: 0x00010350
			[Token(Token = "0x1700138B")]
			public int BattleId
			{
				[Token(Token = "0x60061C8")]
				[Address(RVA = "0xADF3", Offset = "0xADF3", VA = "0xADF3")]
				[CompilerGenerated]
				get
				{
					return 0;
				}
			}

			// Token: 0x1700138C RID: 5004
			// (get) Token: 0x060061C9 RID: 25033 RVA: 0x00012168 File Offset: 0x00010368
			[Token(Token = "0x1700138C")]
			public long StepTime
			{
				[Token(Token = "0x60061C9")]
				[Address(RVA = "0xADF4", Offset = "0xADF4", VA = "0xADF4")]
				[CompilerGenerated]
				get
				{
					return 0L;
				}
			}

			// Token: 0x1700138D RID: 5005
			// (get) Token: 0x060061CA RID: 25034 RVA: 0x00012180 File Offset: 0x00010380
			[Token(Token = "0x1700138D")]
			public int StepNumber
			{
				[Token(Token = "0x60061CA")]
				[Address(RVA = "0xADF5", Offset = "0xADF5", VA = "0xADF5")]
				[CompilerGenerated]
				get
				{
					return 0;
				}
			}

			// Token: 0x1700138E RID: 5006
			// (get) Token: 0x060061CB RID: 25035 RVA: 0x00012198 File Offset: 0x00010398
			[Token(Token = "0x1700138E")]
			public ulong WinnerId
			{
				[Token(Token = "0x60061CB")]
				[Address(RVA = "0xADF6", Offset = "0xADF6", VA = "0xADF6")]
				[CompilerGenerated]
				get
				{
					return 0UL;
				}
			}
		}

		// Token: 0x0200102F RID: 4143
		[Token(Token = "0x200102F")]
		public class OpenWindowEventArgs : ThemeDuelScope.BaseThemeDuelEventArgs
		{
			// Token: 0x060061CC RID: 25036 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60061CC")]
			[Address(RVA = "0xADF7", Offset = "0xADF7", VA = "0xADF7")]
			public OpenWindowEventArgs(IApp app, IGame game, long eventId, WindowOpenReasonSource openReasonSource)
			{
			}

			// Token: 0x1700138F RID: 5007
			// (get) Token: 0x060061CD RID: 25037 RVA: 0x000121B0 File Offset: 0x000103B0
			[Token(Token = "0x1700138F")]
			public WindowOpenReasonSource OpenReasonSource
			{
				[Token(Token = "0x60061CD")]
				[Address(RVA = "0xADF8", Offset = "0xADF8", VA = "0xADF8")]
				[CompilerGenerated]
				get
				{
					return WindowOpenReasonSource.DefaultSource;
				}
			}
		}

		// Token: 0x02001030 RID: 4144
		[Token(Token = "0x2001030")]
		public class BuyItemEventArgs : ThemeDuelScope.BaseThemeDuelEventArgs
		{
			// Token: 0x060061CE RID: 25038 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60061CE")]
			[Address(RVA = "0xADF9", Offset = "0xADF9", VA = "0xADF9")]
			public BuyItemEventArgs(IApp app, IGame game, long eventId, long amount, long balance, int articleId, int count)
			{
			}

			// Token: 0x17001390 RID: 5008
			// (get) Token: 0x060061CF RID: 25039 RVA: 0x000121C8 File Offset: 0x000103C8
			[Token(Token = "0x17001390")]
			public long Amount
			{
				[Token(Token = "0x60061CF")]
				[Address(RVA = "0xADFA", Offset = "0xADFA", VA = "0xADFA")]
				[CompilerGenerated]
				get
				{
					return 0L;
				}
			}

			// Token: 0x17001391 RID: 5009
			// (get) Token: 0x060061D0 RID: 25040 RVA: 0x000121E0 File Offset: 0x000103E0
			[Token(Token = "0x17001391")]
			public long Balance
			{
				[Token(Token = "0x60061D0")]
				[Address(RVA = "0xADFB", Offset = "0xADFB", VA = "0xADFB")]
				[CompilerGenerated]
				get
				{
					return 0L;
				}
			}

			// Token: 0x17001392 RID: 5010
			// (get) Token: 0x060061D1 RID: 25041 RVA: 0x000121F8 File Offset: 0x000103F8
			[Token(Token = "0x17001392")]
			public int ArticleId
			{
				[Token(Token = "0x60061D1")]
				[Address(RVA = "0xADFC", Offset = "0xADFC", VA = "0xADFC")]
				[CompilerGenerated]
				get
				{
					return 0;
				}
			}

			// Token: 0x17001393 RID: 5011
			// (get) Token: 0x060061D2 RID: 25042 RVA: 0x00012210 File Offset: 0x00010410
			[Token(Token = "0x17001393")]
			public int Count
			{
				[Token(Token = "0x60061D2")]
				[Address(RVA = "0xADFD", Offset = "0xADFD", VA = "0xADFD")]
				[CompilerGenerated]
				get
				{
					return 0;
				}
			}
		}
	}
}
