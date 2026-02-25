using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gameplay.World.Model;
using Gameplay.WorldAxis.Model;
using Il2CppDummyDll;
using Protocol.Colossus;
using Protocol.Dic;
using Utils;

namespace Core.Data
{
	// Token: 0x020010B8 RID: 4280
	[Token(Token = "0x20010B8")]
	public class ColossusBattleData
	{
		// Token: 0x1700140A RID: 5130
		// (get) Token: 0x060063C9 RID: 25545 RVA: 0x00012E58 File Offset: 0x00011058
		// (set) Token: 0x060063CA RID: 25546 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700140A")]
		public ColossusBattleData.State ColossusState
		{
			[Token(Token = "0x60063C9")]
			[Address(RVA = "0xAFC8", Offset = "0xAFC8", VA = "0xAFC8")]
			[CompilerGenerated]
			get
			{
				return ColossusBattleData.State.UNKNOWN_STATE;
			}
			[Token(Token = "0x60063CA")]
			[Address(RVA = "0xAFC9", Offset = "0xAFC9", VA = "0xAFC9")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700140B RID: 5131
		// (get) Token: 0x060063CB RID: 25547 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060063CC RID: 25548 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700140B")]
		public string StateLabel
		{
			[Token(Token = "0x60063CB")]
			[Address(RVA = "0xAFCA", Offset = "0xAFCA", VA = "0xAFCA")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60063CC")]
			[Address(RVA = "0xAFCB", Offset = "0xAFCB", VA = "0xAFCB")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700140C RID: 5132
		// (get) Token: 0x060063CD RID: 25549 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060063CE RID: 25550 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700140C")]
		public ColossusDic ColossusDic
		{
			[Token(Token = "0x60063CD")]
			[Address(RVA = "0xAFCC", Offset = "0xAFCC", VA = "0xAFCC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60063CE")]
			[Address(RVA = "0xAFCD", Offset = "0xAFCD", VA = "0xAFCD")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700140D RID: 5133
		// (get) Token: 0x060063CF RID: 25551 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060063D0 RID: 25552 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700140D")]
		public ClanData ClanData
		{
			[Token(Token = "0x60063CF")]
			[Address(RVA = "0xAFCE", Offset = "0xAFCE", VA = "0xAFCE")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60063D0")]
			[Address(RVA = "0xAFCF", Offset = "0xAFCF", VA = "0xAFCF")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700140E RID: 5134
		// (get) Token: 0x060063D1 RID: 25553 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060063D2 RID: 25554 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700140E")]
		public BackTime Backtime
		{
			[Token(Token = "0x60063D1")]
			[Address(RVA = "0xAFD0", Offset = "0xAFD0", VA = "0xAFD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60063D2")]
			[Address(RVA = "0xAFD1", Offset = "0xAFD1", VA = "0xAFD1")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700140F RID: 5135
		// (get) Token: 0x060063D3 RID: 25555 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060063D4 RID: 25556 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700140F")]
		public BackTime ShieldBacktime
		{
			[Token(Token = "0x60063D3")]
			[Address(RVA = "0xAFD2", Offset = "0xAFD2", VA = "0xAFD2")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60063D4")]
			[Address(RVA = "0xAFD3", Offset = "0xAFD3", VA = "0xAFD3")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001410 RID: 5136
		// (get) Token: 0x060063D5 RID: 25557 RVA: 0x00012E70 File Offset: 0x00011070
		[Token(Token = "0x17001410")]
		public bool ShieldActive
		{
			[Token(Token = "0x60063D5")]
			[Address(RVA = "0xAFD4", Offset = "0xAFD4", VA = "0xAFD4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001411 RID: 5137
		// (get) Token: 0x060063D6 RID: 25558 RVA: 0x00012E88 File Offset: 0x00011088
		[Token(Token = "0x17001411")]
		public bool IsValid
		{
			[Token(Token = "0x60063D6")]
			[Address(RVA = "0xAFD5", Offset = "0xAFD5", VA = "0xAFD5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001412 RID: 5138
		// (get) Token: 0x060063D7 RID: 25559 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001412")]
		public string BattleStatusLabel
		{
			[Token(Token = "0x60063D7")]
			[Address(RVA = "0xAFD6", Offset = "0xAFD6", VA = "0xAFD6")]
			get
			{
				return null;
			}
		}

		// Token: 0x060063D8 RID: 25560 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60063D8")]
		[Address(RVA = "0x1DC8", Offset = "0x1DC8", VA = "0x1DC8")]
		public void UpdateInfo(ColossusInfo info)
		{
		}

		// Token: 0x060063D9 RID: 25561 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60063D9")]
		[Address(RVA = "0x1DC6", Offset = "0x1DC6", VA = "0x1DC6")]
		public void UpdateData(ScheduleEvent evt, ColossusBattleData.State attackState, WorldAxisModel model)
		{
		}

		// Token: 0x060063DA RID: 25562 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60063DA")]
		[Address(RVA = "0xAFD7", Offset = "0xAFD7", VA = "0xAFD7")]
		public static ColossusBattleData Create(ScheduleEvent evt, ColossusBattleData.State attackState, WorldAxisModel model)
		{
			return null;
		}

		// Token: 0x060063DB RID: 25563 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60063DB")]
		[Address(RVA = "0xAFD8", Offset = "0xAFD8", VA = "0xAFD8")]
		public static ColossusBattleData Create(ColossusDic dic)
		{
			return null;
		}

		// Token: 0x060063DC RID: 25564 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60063DC")]
		[Address(RVA = "0xAFD9", Offset = "0xAFD9", VA = "0xAFD9")]
		public ColossusBattleData()
		{
		}

		// Token: 0x04003565 RID: 13669
		[Token(Token = "0x4003565")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<ColossusBattleData.State, string> _labelByState;

		// Token: 0x020010B9 RID: 4281
		[Token(Token = "0x20010B9")]
		public enum State
		{
			// Token: 0x04003567 RID: 13671
			[Token(Token = "0x4003567")]
			UNKNOWN_STATE,
			// Token: 0x04003568 RID: 13672
			[Token(Token = "0x4003568")]
			ENEMY,
			// Token: 0x04003569 RID: 13673
			[Token(Token = "0x4003569")]
			NEUTRAL,
			// Token: 0x0400356A RID: 13674
			[Token(Token = "0x400356A")]
			ALLY
		}
	}
}
