using System;
using System.Runtime.CompilerServices;
using Core.Net;
using Google.Protobuf;
using Il2CppDummyDll;
using Protocol.BlitzTournaments;
using Protocol.Tournaments;
using Utils;

namespace ServicesNamespace
{
	// Token: 0x0200008F RID: 143
	[Token(Token = "0x200008F")]
	public class BlitzTournamentService : AbstractService
	{
		// Token: 0x14000018 RID: 24
		// (add) Token: 0x060003F9 RID: 1017 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060003FA RID: 1018 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000018")]
		public event Action<Protocol.BlitzTournaments.ProtoStateChangedEvt> StateChangedEvent
		{
			[Token(Token = "0x60003F9")]
			[Address(RVA = "0x5826", Offset = "0x5826", VA = "0x5826")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60003FA")]
			[Address(RVA = "0x5827", Offset = "0x5827", VA = "0x5827")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000019 RID: 25
		// (add) Token: 0x060003FB RID: 1019 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060003FC RID: 1020 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000019")]
		public event Action<ProtoCurrentTnmCombatCompleteEvt> CurrentBattleCompleteEvent
		{
			[Token(Token = "0x60003FB")]
			[Address(RVA = "0x5828", Offset = "0x5828", VA = "0x5828")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60003FC")]
			[Address(RVA = "0x5829", Offset = "0x5829", VA = "0x5829")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400001A RID: 26
		// (add) Token: 0x060003FD RID: 1021 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060003FE RID: 1022 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400001A")]
		public event Action<ProtoFinalTnmCombatCompleteEvt> FinalBattleCompleteEvent
		{
			[Token(Token = "0x60003FD")]
			[Address(RVA = "0x582A", Offset = "0x582A", VA = "0x582A")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60003FE")]
			[Address(RVA = "0x582B", Offset = "0x582B", VA = "0x582B")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400001B RID: 27
		// (add) Token: 0x060003FF RID: 1023 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000400 RID: 1024 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400001B")]
		public event Action<ProtoHealthChangedEvt> HealthChangedEvent
		{
			[Token(Token = "0x60003FF")]
			[Address(RVA = "0x582C", Offset = "0x582C", VA = "0x582C")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000400")]
			[Address(RVA = "0x582D", Offset = "0x582D", VA = "0x582D")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400001C RID: 28
		// (add) Token: 0x06000401 RID: 1025 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000402 RID: 1026 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400001C")]
		public event Action<ProtoRequestCanceledEvt> JoinRequestCancelledEvent
		{
			[Token(Token = "0x6000401")]
			[Address(RVA = "0x582E", Offset = "0x582E", VA = "0x582E")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000402")]
			[Address(RVA = "0x582F", Offset = "0x582F", VA = "0x582F")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400001D RID: 29
		// (add) Token: 0x06000403 RID: 1027 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000404 RID: 1028 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400001D")]
		public event Action<ProtoFighterCountChangedEvt> FightersCountChangedEvent
		{
			[Token(Token = "0x6000403")]
			[Address(RVA = "0x5830", Offset = "0x5830", VA = "0x5830")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000404")]
			[Address(RVA = "0x5831", Offset = "0x5831", VA = "0x5831")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x06000405 RID: 1029 RVA: 0x00002E68 File Offset: 0x00001068
		[Token(Token = "0x17000093")]
		public override short ServiceId
		{
			[Token(Token = "0x6000405")]
			[Address(RVA = "0x5832", Offset = "0x5832", VA = "0x5832", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000406 RID: 1030 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000406")]
		[Address(RVA = "0x5833", Offset = "0x5833", VA = "0x5833", Slot = "6")]
		protected override void ServerEventHandler(SrvAnswer evt)
		{
		}

		// Token: 0x06000407 RID: 1031 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000407")]
		[Address(RVA = "0x5834", Offset = "0x5834", VA = "0x5834")]
		public OpToken<IMessage, object> GetTournamentInfo()
		{
			return null;
		}

		// Token: 0x06000408 RID: 1032 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000408")]
		[Address(RVA = "0x5835", Offset = "0x5835", VA = "0x5835")]
		public OpToken<IMessage, object> GetTournamentList()
		{
			return null;
		}

		// Token: 0x06000409 RID: 1033 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000409")]
		[Address(RVA = "0x5836", Offset = "0x5836", VA = "0x5836")]
		public OpToken<IMessage, object> JoinQueue(uint tournamentType)
		{
			return null;
		}

		// Token: 0x0600040A RID: 1034 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600040A")]
		[Address(RVA = "0x5837", Offset = "0x5837", VA = "0x5837")]
		public OpToken<IMessage, object> LeaveQueue()
		{
			return null;
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600040B")]
		[Address(RVA = "0x5838", Offset = "0x5838", VA = "0x5838")]
		public BlitzTournamentService()
		{
		}
	}
}
