using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Money;
using Il2CppDummyDll;
using MVC;
using Protocol.Common;
using Protocol.Consts;
using Protocol.Dic;
using Protocol.SmallGames;
using Utils;

namespace Gameplay.SmallGames.Model
{
	// Token: 0x02000535 RID: 1333
	[Token(Token = "0x2000535")]
	public class SmallGamesModel : AbstractModel
	{
		// Token: 0x170005CB RID: 1483
		// (get) Token: 0x06001FB0 RID: 8112 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170005CB")]
		public FreeAttemptsInfo FreeAttemptsDiamond
		{
			[Token(Token = "0x6001FB0")]
			[Address(RVA = "0x7115", Offset = "0x7115", VA = "0x7115")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005CC RID: 1484
		// (get) Token: 0x06001FB1 RID: 8113 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170005CC")]
		public FreeAttemptsInfo FreeAttemptsOnyx
		{
			[Token(Token = "0x6001FB1")]
			[Address(RVA = "0x7116", Offset = "0x7116", VA = "0x7116")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005CD RID: 1485
		// (get) Token: 0x06001FB2 RID: 8114 RVA: 0x000066A8 File Offset: 0x000048A8
		// (set) Token: 0x06001FB3 RID: 8115 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005CD")]
		public uint LastScrollCount
		{
			[Token(Token = "0x6001FB2")]
			[Address(RVA = "0x7117", Offset = "0x7117", VA = "0x7117")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001FB3")]
			[Address(RVA = "0x7118", Offset = "0x7118", VA = "0x7118")]
			set
			{
			}
		}

		// Token: 0x170005CE RID: 1486
		// (get) Token: 0x06001FB4 RID: 8116 RVA: 0x000066C0 File Offset: 0x000048C0
		// (set) Token: 0x06001FB5 RID: 8117 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005CE")]
		public bool HasDrop
		{
			[Token(Token = "0x6001FB4")]
			[Address(RVA = "0x7119", Offset = "0x7119", VA = "0x7119")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001FB5")]
			[Address(RVA = "0x711A", Offset = "0x711A", VA = "0x711A")]
			private set
			{
			}
		}

		// Token: 0x170005CF RID: 1487
		// (get) Token: 0x06001FB6 RID: 8118 RVA: 0x000066D8 File Offset: 0x000048D8
		// (set) Token: 0x06001FB7 RID: 8119 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005CF")]
		public SlotMachineType CurrentSlotMachineType
		{
			[Token(Token = "0x6001FB6")]
			[Address(RVA = "0x711B", Offset = "0x711B", VA = "0x711B")]
			[CompilerGenerated]
			get
			{
				return SlotMachineType.UnknownMachine;
			}
			[Token(Token = "0x6001FB7")]
			[Address(RVA = "0x711C", Offset = "0x711C", VA = "0x711C")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170005D0 RID: 1488
		// (get) Token: 0x06001FB8 RID: 8120 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001FB9 RID: 8121 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005D0")]
		public ProtoLaunchWheelsAns WheelResult
		{
			[Token(Token = "0x6001FB8")]
			[Address(RVA = "0x711D", Offset = "0x711D", VA = "0x711D")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001FB9")]
			[Address(RVA = "0x711E", Offset = "0x711E", VA = "0x711E")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170005D1 RID: 1489
		// (get) Token: 0x06001FBA RID: 8122 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001FBB RID: 8123 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005D1")]
		public ResourceSet Jackpot
		{
			[Token(Token = "0x6001FBA")]
			[Address(RVA = "0x711F", Offset = "0x711F", VA = "0x711F")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001FBB")]
			[Address(RVA = "0x7120", Offset = "0x7120", VA = "0x7120")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170005D2 RID: 1490
		// (get) Token: 0x06001FBC RID: 8124 RVA: 0x000066F0 File Offset: 0x000048F0
		// (set) Token: 0x06001FBD RID: 8125 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005D2")]
		public int RewardNotificationsCount
		{
			[Token(Token = "0x6001FBC")]
			[Address(RVA = "0x7121", Offset = "0x7121", VA = "0x7121")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001FBD")]
			[Address(RVA = "0x7122", Offset = "0x7122", VA = "0x7122")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170005D3 RID: 1491
		// (get) Token: 0x06001FBE RID: 8126 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170005D3")]
		public SlotMachineDic CurrentSlotMachineDic
		{
			[Token(Token = "0x6001FBE")]
			[Address(RVA = "0x7123", Offset = "0x7123", VA = "0x7123")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005D4 RID: 1492
		// (get) Token: 0x06001FBF RID: 8127 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170005D4")]
		public FreeAttemptsInfo CurrentFreeAttempts
		{
			[Token(Token = "0x6001FBF")]
			[Address(RVA = "0x7124", Offset = "0x7124", VA = "0x7124")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005D5 RID: 1493
		// (get) Token: 0x06001FC0 RID: 8128 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170005D5")]
		public BackTime CurrentBacktime
		{
			[Token(Token = "0x6001FC0")]
			[Address(RVA = "0x7125", Offset = "0x7125", VA = "0x7125")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005D6 RID: 1494
		// (get) Token: 0x06001FC1 RID: 8129 RVA: 0x00006708 File Offset: 0x00004908
		[Token(Token = "0x170005D6")]
		public Resources CurrentResource
		{
			[Token(Token = "0x6001FC1")]
			[Address(RVA = "0x7126", Offset = "0x7126", VA = "0x7126")]
			get
			{
				return Resources.UnknownResource;
			}
		}

		// Token: 0x06001FC2 RID: 8130 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001FC2")]
		[Address(RVA = "0x7127", Offset = "0x7127", VA = "0x7127")]
		public BackTime GetCurrentBacktime(SlotMachineType slotMachineType)
		{
			return null;
		}

		// Token: 0x06001FC3 RID: 8131 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FC3")]
		[Address(RVA = "0x7128", Offset = "0x7128", VA = "0x7128", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x06001FC4 RID: 8132 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FC4")]
		[Address(RVA = "0x7129", Offset = "0x7129", VA = "0x7129")]
		public SmallGamesModel(SmallGamesModel.DailyRewardsInfo dailyRewards, UserData user)
		{
		}

		// Token: 0x06001FC5 RID: 8133 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FC5")]
		[Address(RVA = "0x712A", Offset = "0x712A", VA = "0x712A")]
		public void PopulateModel(ProtoRegisterVisitAns msg)
		{
		}

		// Token: 0x06001FC6 RID: 8134 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FC6")]
		[Address(RVA = "0x712B", Offset = "0x712B", VA = "0x712B")]
		public void SetLastJackpot(SlotMachineType type, ProtoGetLastJackpotInfoAns msg)
		{
		}

		// Token: 0x06001FC7 RID: 8135 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FC7")]
		[Address(RVA = "0x712C", Offset = "0x712C", VA = "0x712C")]
		public void SetJackpot(ResourceSet jackpot)
		{
		}

		// Token: 0x06001FC8 RID: 8136 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FC8")]
		[Address(RVA = "0x712D", Offset = "0x712D", VA = "0x712D")]
		public void SetFreeAttempts(FreeAttemptsInfo freeAttempts, SlotMachineType type)
		{
		}

		// Token: 0x06001FC9 RID: 8137 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FC9")]
		[Address(RVA = "0x712E", Offset = "0x712E", VA = "0x712E")]
		public void SetLastDrop(IList<ArtifactData> artifacts)
		{
		}

		// Token: 0x06001FCA RID: 8138 RVA: 0x00006720 File Offset: 0x00004920
		[Token(Token = "0x6001FCA")]
		[Address(RVA = "0x712F", Offset = "0x712F", VA = "0x712F")]
		public uint GetFreeAttempts(SlotMachineType type)
		{
			return 0U;
		}

		// Token: 0x06001FCB RID: 8139 RVA: 0x00006738 File Offset: 0x00004938
		[Token(Token = "0x6001FCB")]
		[Address(RVA = "0x7130", Offset = "0x7130", VA = "0x7130")]
		public Resources GetResourceId(SlotMachineType type)
		{
			return Resources.UnknownResource;
		}

		// Token: 0x0400116A RID: 4458
		[Token(Token = "0x400116A")]
		[FieldOffset(Offset = "0xC")]
		public readonly uint[] BonusUserAccountIds;

		// Token: 0x0400116B RID: 4459
		[Token(Token = "0x400116B")]
		[FieldOffset(Offset = "0x10")]
		public readonly Dictionaries Dict;

		// Token: 0x0400116C RID: 4460
		[Token(Token = "0x400116C")]
		[FieldOffset(Offset = "0x14")]
		public readonly SmallGamesModel.DailyRewardsInfo DailyRewards;

		// Token: 0x0400116D RID: 4461
		[Token(Token = "0x400116D")]
		[FieldOffset(Offset = "0x18")]
		[TupleElementNames(new string[]
		{
			"SortOrder",
			"ArtifactData"
		})]
		public List<ValueTuple<uint, ArtifactData>> ArtifactsWithSortOrders;

		// Token: 0x0400116E RID: 4462
		[Token(Token = "0x400116E")]
		[FieldOffset(Offset = "0x1C")]
		public Dictionary<SlotMachineType, Dictionary<uint, WinCombinationDic>> WinCombinationsBySlotMachineByCombinationId;

		// Token: 0x0400116F RID: 4463
		[Token(Token = "0x400116F")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<SlotMachineType, SmallGamesModel.JackpotInfo> LastJackpots;

		// Token: 0x04001170 RID: 4464
		[Token(Token = "0x4001170")]
		[FieldOffset(Offset = "0x24")]
		private Dictionary<SlotMachineType, SlotMachineDic> _slotMachineDicts;

		// Token: 0x04001171 RID: 4465
		[Token(Token = "0x4001171")]
		[FieldOffset(Offset = "0x28")]
		private Dictionary<SlotMachineType, uint> _scrollCountsBySlotMachine;

		// Token: 0x04001172 RID: 4466
		[Token(Token = "0x4001172")]
		[FieldOffset(Offset = "0x2C")]
		private FreeAttemptsInfo _freeAttemptsDiamond;

		// Token: 0x04001173 RID: 4467
		[Token(Token = "0x4001173")]
		[FieldOffset(Offset = "0x30")]
		private FreeAttemptsInfo _freeAttemptsOnyx;

		// Token: 0x04001174 RID: 4468
		[Token(Token = "0x4001174")]
		[FieldOffset(Offset = "0x34")]
		public Dictionary<SlotMachineType, BackTime> FreeSpinsBacktimeByType;

		// Token: 0x02000536 RID: 1334
		[Token(Token = "0x2000536")]
		public class JackpotInfo
		{
			// Token: 0x06001FCC RID: 8140 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001FCC")]
			[Address(RVA = "0x7131", Offset = "0x7131", VA = "0x7131")]
			public JackpotInfo(ProtoGetLastJackpotInfoAns msg, Resources resourceId)
			{
			}

			// Token: 0x04001179 RID: 4473
			[Token(Token = "0x4001179")]
			[FieldOffset(Offset = "0x8")]
			public string Nickname;

			// Token: 0x0400117A RID: 4474
			[Token(Token = "0x400117A")]
			[FieldOffset(Offset = "0xC")]
			public Money Resources;

			// Token: 0x0400117B RID: 4475
			[Token(Token = "0x400117B")]
			[FieldOffset(Offset = "0x10")]
			public UserData User;

			// Token: 0x0400117C RID: 4476
			[Token(Token = "0x400117C")]
			[FieldOffset(Offset = "0x14")]
			public string DateString;
		}

		// Token: 0x02000537 RID: 1335
		[Token(Token = "0x2000537")]
		public class DailyRewardsInfo
		{
			// Token: 0x170005D7 RID: 1495
			// (get) Token: 0x06001FCD RID: 8141 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x06001FCE RID: 8142 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170005D7")]
			public ProtoRegisterVisitAns RegisterVisitAns
			{
				[Token(Token = "0x6001FCD")]
				[Address(RVA = "0x7132", Offset = "0x7132", VA = "0x7132")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6001FCE")]
				[Address(RVA = "0x7133", Offset = "0x7133", VA = "0x7133")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x170005D8 RID: 1496
			// (get) Token: 0x06001FCF RID: 8143 RVA: 0x00006750 File Offset: 0x00004950
			[Token(Token = "0x170005D8")]
			public bool CanTakeAdditional
			{
				[Token(Token = "0x6001FCF")]
				[Address(RVA = "0x7134", Offset = "0x7134", VA = "0x7134")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x1400013C RID: 316
			// (add) Token: 0x06001FD0 RID: 8144 RVA: 0x00002050 File Offset: 0x00000250
			// (remove) Token: 0x06001FD1 RID: 8145 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1400013C")]
			public event Action DailyRewardsStatusChangedEvent
			{
				[Token(Token = "0x6001FD0")]
				[Address(RVA = "0x7135", Offset = "0x7135", VA = "0x7135")]
				[CompilerGenerated]
				add
				{
				}
				[Token(Token = "0x6001FD1")]
				[Address(RVA = "0x7136", Offset = "0x7136", VA = "0x7136")]
				[CompilerGenerated]
				remove
				{
				}
			}

			// Token: 0x170005D9 RID: 1497
			// (get) Token: 0x06001FD2 RID: 8146 RVA: 0x00006768 File Offset: 0x00004968
			// (set) Token: 0x06001FD3 RID: 8147 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170005D9")]
			public ProtoRegisterVisitAns.Types.RegisterVisitStatus Status
			{
				[Token(Token = "0x6001FD2")]
				[Address(RVA = "0x7137", Offset = "0x7137", VA = "0x7137")]
				get
				{
					return ProtoRegisterVisitAns.Types.RegisterVisitStatus.BonusNotTaken;
				}
				[Token(Token = "0x6001FD3")]
				[Address(RVA = "0x7138", Offset = "0x7138", VA = "0x7138")]
				set
				{
				}
			}

			// Token: 0x06001FD4 RID: 8148 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001FD4")]
			[Address(RVA = "0x7139", Offset = "0x7139", VA = "0x7139")]
			public void Init(ProtoRegisterVisitAns registerVisitAns)
			{
			}

			// Token: 0x06001FD5 RID: 8149 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001FD5")]
			[Address(RVA = "0x713A", Offset = "0x713A", VA = "0x713A")]
			public DailyRewardsInfo()
			{
			}

			// Token: 0x0400117E RID: 4478
			[Token(Token = "0x400117E")]
			[FieldOffset(Offset = "0xC")]
			public ProtoRegisterVisitAns.Types.DailyRewards[] DailyRewards;
		}
	}
}
