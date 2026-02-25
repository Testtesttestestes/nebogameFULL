using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Dict;
using Core.Gameplay.Managers.Inventory;
using Gameplay.WorldAxis.Colossus.Combat;
using Il2CppDummyDll;
using MVC;
using Protocol.Colossus;
using Protocol.Common;
using Protocol.Dic;
using Utils;

namespace Gameplay.WorldAxis.Model
{
	// Token: 0x020002C3 RID: 707
	[Token(Token = "0x20002C3")]
	public class WorldAxisModel : AbstractModel
	{
		// Token: 0x17000270 RID: 624
		// (get) Token: 0x0600109F RID: 4255 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000270")]
		public Dictionaries Dict
		{
			[Token(Token = "0x600109F")]
			[Address(RVA = "0x629C", Offset = "0x629C", VA = "0x629C")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000271 RID: 625
		// (get) Token: 0x060010A0 RID: 4256 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060010A1 RID: 4257 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000271")]
		public IColossusCombatLauncher CombatLauncher
		{
			[Token(Token = "0x60010A0")]
			[Address(RVA = "0x629D", Offset = "0x629D", VA = "0x629D")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60010A1")]
			[Address(RVA = "0x629E", Offset = "0x629E", VA = "0x629E")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060010A2 RID: 4258 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010A2")]
		[Address(RVA = "0x629F", Offset = "0x629F", VA = "0x629F", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x060010A3 RID: 4259 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010A3")]
		[Address(RVA = "0x62A0", Offset = "0x62A0", VA = "0x62A0")]
		public WorldAxisModel(IColossusCombatLauncher combatLauncher, UserData user, GolemInventoryManager golemInventoryManager, IDictProvider dictProvider)
		{
		}

		// Token: 0x17000272 RID: 626
		// (get) Token: 0x060010A4 RID: 4260 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060010A5 RID: 4261 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000272")]
		public ColossusBattleData[] ColossusBattles
		{
			[Token(Token = "0x60010A4")]
			[Address(RVA = "0x62A1", Offset = "0x62A1", VA = "0x62A1")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60010A5")]
			[Address(RVA = "0x62A2", Offset = "0x62A2", VA = "0x62A2")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000273 RID: 627
		// (get) Token: 0x060010A6 RID: 4262 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060010A7 RID: 4263 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000273")]
		public BackTime SeasonBacktime
		{
			[Token(Token = "0x60010A6")]
			[Address(RVA = "0x62A3", Offset = "0x62A3", VA = "0x62A3")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60010A7")]
			[Address(RVA = "0x62A4", Offset = "0x62A4", VA = "0x62A4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000274 RID: 628
		// (get) Token: 0x060010A8 RID: 4264 RVA: 0x000045C0 File Offset: 0x000027C0
		// (set) Token: 0x060010A9 RID: 4265 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000274")]
		public bool SeasonActive
		{
			[Token(Token = "0x60010A8")]
			[Address(RVA = "0x62A5", Offset = "0x62A5", VA = "0x62A5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60010A9")]
			[Address(RVA = "0x62A6", Offset = "0x62A6", VA = "0x62A6")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000275 RID: 629
		// (get) Token: 0x060010AA RID: 4266 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000275")]
		public string SeasonStatusText
		{
			[Token(Token = "0x60010AA")]
			[Address(RVA = "0x62A7", Offset = "0x62A7", VA = "0x62A7")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000276 RID: 630
		// (get) Token: 0x060010AB RID: 4267 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060010AC RID: 4268 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000276")]
		public DollsInfoDic SelectedDoll
		{
			[Token(Token = "0x60010AB")]
			[Address(RVA = "0x62A8", Offset = "0x62A8", VA = "0x62A8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60010AC")]
			[Address(RVA = "0x62A9", Offset = "0x62A9", VA = "0x62A9")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000277 RID: 631
		// (get) Token: 0x060010AD RID: 4269 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060010AE RID: 4270 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000277")]
		public DollsInfoDic[] AvailableDolls
		{
			[Token(Token = "0x60010AD")]
			[Address(RVA = "0x62AA", Offset = "0x62AA", VA = "0x62AA")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60010AE")]
			[Address(RVA = "0x62AB", Offset = "0x62AB", VA = "0x62AB")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000278 RID: 632
		// (get) Token: 0x060010AF RID: 4271 RVA: 0x000045D8 File Offset: 0x000027D8
		// (set) Token: 0x060010B0 RID: 4272 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000278")]
		public uint SelectedSlotId
		{
			[Token(Token = "0x60010AF")]
			[Address(RVA = "0x62AC", Offset = "0x62AC", VA = "0x62AC")]
			[CompilerGenerated]
			get
			{
				return 0U;
			}
			[Token(Token = "0x60010B0")]
			[Address(RVA = "0x62AD", Offset = "0x62AD", VA = "0x62AD")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000279 RID: 633
		// (get) Token: 0x060010B1 RID: 4273 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060010B2 RID: 4274 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000279")]
		public ColossusPartiesInfoDic SelectedParty
		{
			[Token(Token = "0x60010B1")]
			[Address(RVA = "0x62AE", Offset = "0x62AE", VA = "0x62AE")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60010B2")]
			[Address(RVA = "0x62AF", Offset = "0x62AF", VA = "0x62AF")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700027A RID: 634
		// (get) Token: 0x060010B3 RID: 4275 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700027A")]
		public ResourceSet AttackPrice
		{
			[Token(Token = "0x60010B3")]
			[Address(RVA = "0x62B0", Offset = "0x62B0", VA = "0x62B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700027B RID: 635
		// (get) Token: 0x060010B4 RID: 4276 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700027B")]
		public ResourceSet DefencePrice
		{
			[Token(Token = "0x60010B4")]
			[Address(RVA = "0x62B1", Offset = "0x62B1", VA = "0x62B1")]
			get
			{
				return null;
			}
		}

		// Token: 0x060010B5 RID: 4277 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010B5")]
		[Address(RVA = "0x62B2", Offset = "0x62B2", VA = "0x62B2")]
		public void PopulateSchedule(ProtoGetScheduleAns msg)
		{
		}

		// Token: 0x060010B6 RID: 4278 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010B6")]
		[Address(RVA = "0x62B3", Offset = "0x62B3", VA = "0x62B3")]
		public void CreateData(ProtoGetScheduleAns msg)
		{
		}

		// Token: 0x060010B7 RID: 4279 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010B7")]
		[Address(RVA = "0x62B4", Offset = "0x62B4", VA = "0x62B4")]
		private void UpdateData(ProtoGetScheduleAns msg)
		{
		}

		// Token: 0x060010B8 RID: 4280 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010B8")]
		[Address(RVA = "0x62B5", Offset = "0x62B5", VA = "0x62B5")]
		public void UpdateColossusInfo(ProtoGetColossusInfoAns msg)
		{
		}

		// Token: 0x060010B9 RID: 4281 RVA: 0x000045F0 File Offset: 0x000027F0
		[Token(Token = "0x60010B9")]
		[Address(RVA = "0x62B6", Offset = "0x62B6", VA = "0x62B6")]
		private ColossusBattleData.State GetAttackState(ProtoGetScheduleAns msg)
		{
			return ColossusBattleData.State.UNKNOWN_STATE;
		}

		// Token: 0x060010BA RID: 4282 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60010BA")]
		[Address(RVA = "0x62B7", Offset = "0x62B7", VA = "0x62B7")]
		private BackTime CreateBacktime(long startTime, ulong duration)
		{
			return null;
		}

		// Token: 0x060010BB RID: 4283 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010BB")]
		[Address(RVA = "0x62B8", Offset = "0x62B8", VA = "0x62B8")]
		public void PopulateDolls(ProtoGetAvailDollsAns msg)
		{
		}

		// Token: 0x060010BC RID: 4284 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010BC")]
		[Address(RVA = "0x62B9", Offset = "0x62B9", VA = "0x62B9")]
		public void DeterminePartyInfo(ProtoGetPartyInfoAns msg)
		{
		}

		// Token: 0x060010BD RID: 4285 RVA: 0x00004608 File Offset: 0x00002808
		[Token(Token = "0x60010BD")]
		[Address(RVA = "0x62BA", Offset = "0x62BA", VA = "0x62BA")]
		public bool TryGetColossusDataByClanId(ulong clanId, out ColossusBattleData colossusData)
		{
			return default(bool);
		}

		// Token: 0x0400089C RID: 2204
		[Token(Token = "0x400089C")]
		[FieldOffset(Offset = "0xC")]
		private readonly IDictProvider _dictProvider;

		// Token: 0x0400089D RID: 2205
		[Token(Token = "0x400089D")]
		[FieldOffset(Offset = "0x10")]
		public readonly GolemInventoryManager GolemInventoryManager;
	}
}
