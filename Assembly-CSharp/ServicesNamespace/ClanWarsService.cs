using System;
using System.Runtime.CompilerServices;
using Core.Net;
using Google.Protobuf;
using Il2CppDummyDll;
using Protocol.ClanWar;
using Utils;

namespace ServicesNamespace
{
	// Token: 0x02000094 RID: 148
	[Token(Token = "0x2000094")]
	public class ClanWarsService : AbstractService
	{
		// Token: 0x17000098 RID: 152
		// (get) Token: 0x0600047C RID: 1148 RVA: 0x00002EE0 File Offset: 0x000010E0
		[Token(Token = "0x17000098")]
		public override short ServiceId
		{
			[Token(Token = "0x600047C")]
			[Address(RVA = "0x58A7", Offset = "0x58A7", VA = "0x58A7", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1400003C RID: 60
		// (add) Token: 0x0600047D RID: 1149 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600047E RID: 1150 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400003C")]
		public event Action<ProtoNewWarDeclaredEvt> NewWarDeclaredEvent
		{
			[Token(Token = "0x600047D")]
			[Address(RVA = "0x58A8", Offset = "0x58A8", VA = "0x58A8")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600047E")]
			[Address(RVA = "0x58A9", Offset = "0x58A9", VA = "0x58A9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400003D RID: 61
		// (add) Token: 0x0600047F RID: 1151 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000480 RID: 1152 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400003D")]
		public event Action<ProtoWarStateChangedEvt> WarStateChanged
		{
			[Token(Token = "0x600047F")]
			[Address(RVA = "0x58AA", Offset = "0x58AA", VA = "0x58AA")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000480")]
			[Address(RVA = "0x58AB", Offset = "0x58AB", VA = "0x58AB")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400003E RID: 62
		// (add) Token: 0x06000481 RID: 1153 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000482 RID: 1154 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400003E")]
		public event Action<ProtoPlayersCountChangedEvt> PlayersCountChangedEvent
		{
			[Token(Token = "0x6000481")]
			[Address(RVA = "0x58AC", Offset = "0x58AC", VA = "0x58AC")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000482")]
			[Address(RVA = "0x58AD", Offset = "0x58AD", VA = "0x58AD")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400003F RID: 63
		// (add) Token: 0x06000483 RID: 1155 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000484 RID: 1156 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400003F")]
		public event Action<ProtoClanWarCompleteEvt> ClanWarCompletedEvent
		{
			[Token(Token = "0x6000483")]
			[Address(RVA = "0x58AE", Offset = "0x58AE", VA = "0x58AE")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000484")]
			[Address(RVA = "0x58AF", Offset = "0x58AF", VA = "0x58AF")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000040 RID: 64
		// (add) Token: 0x06000485 RID: 1157 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000486 RID: 1158 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000040")]
		public event Action<ProtoSeasonStartedEvt> SeasonStartedEvent
		{
			[Token(Token = "0x6000485")]
			[Address(RVA = "0x58B0", Offset = "0x58B0", VA = "0x58B0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000486")]
			[Address(RVA = "0x58B1", Offset = "0x58B1", VA = "0x58B1")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000041 RID: 65
		// (add) Token: 0x06000487 RID: 1159 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000488 RID: 1160 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000041")]
		public event Action<ProtoSeasonFinishedEvt> SeasonFinishedEvent
		{
			[Token(Token = "0x6000487")]
			[Address(RVA = "0x58B2", Offset = "0x58B2", VA = "0x58B2")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000488")]
			[Address(RVA = "0x58B3", Offset = "0x58B3", VA = "0x58B3")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000042 RID: 66
		// (add) Token: 0x06000489 RID: 1161 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600048A RID: 1162 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000042")]
		public event Action<ProtoWarModeChangedEvt> WarModeChangedEvent
		{
			[Token(Token = "0x6000489")]
			[Address(RVA = "0x58B4", Offset = "0x58B4", VA = "0x58B4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600048A")]
			[Address(RVA = "0x58B5", Offset = "0x58B5", VA = "0x58B5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x0600048B RID: 1163 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600048B")]
		[Address(RVA = "0x58B6", Offset = "0x58B6", VA = "0x58B6", Slot = "6")]
		protected override void ServerEventHandler(SrvAnswer evt)
		{
		}

		// Token: 0x0600048C RID: 1164 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600048C")]
		[Address(RVA = "0x58B7", Offset = "0x58B7", VA = "0x58B7")]
		public OpToken<IMessage, object> GetSeasonBankDistribution()
		{
			return null;
		}

		// Token: 0x0600048D RID: 1165 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600048D")]
		[Address(RVA = "0x58B8", Offset = "0x58B8", VA = "0x58B8")]
		public OpToken<IMessage, object> RequestPolitics(ProtoRequestClanPolicyCmd msg)
		{
			return null;
		}

		// Token: 0x0600048E RID: 1166 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600048E")]
		[Address(RVA = "0x58B9", Offset = "0x58B9", VA = "0x58B9")]
		public OpToken<IMessage, object> GetActiveWarInfo()
		{
			return null;
		}

		// Token: 0x0600048F RID: 1167 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600048F")]
		[Address(RVA = "0x58BA", Offset = "0x58BA", VA = "0x58BA")]
		public OpToken<IMessage, object> GetWarsHistory(uint linesCount, uint previousWarId)
		{
			return null;
		}

		// Token: 0x06000490 RID: 1168 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000490")]
		[Address(RVA = "0x58BB", Offset = "0x58BB", VA = "0x58BB")]
		public OpToken<IMessage, object> GetCurrentSeasonInfo()
		{
			return null;
		}

		// Token: 0x06000491 RID: 1169 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000491")]
		[Address(RVA = "0x58BC", Offset = "0x58BC", VA = "0x58BC")]
		public OpToken<IMessage, object> TakeOutGolem()
		{
			return null;
		}

		// Token: 0x06000492 RID: 1170 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000492")]
		[Address(RVA = "0x58BD", Offset = "0x58BD", VA = "0x58BD")]
		public OpToken<IMessage, object> RepairGolem()
		{
			return null;
		}

		// Token: 0x06000493 RID: 1171 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000493")]
		[Address(RVA = "0x58BE", Offset = "0x58BE", VA = "0x58BE")]
		public OpToken<IMessage, object> DeclareWar(ulong clanId)
		{
			return null;
		}

		// Token: 0x06000494 RID: 1172 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000494")]
		[Address(RVA = "0x58BF", Offset = "0x58BF", VA = "0x58BF")]
		public OpToken<IMessage, object> PayOff(uint warId)
		{
			return null;
		}

		// Token: 0x06000495 RID: 1173 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000495")]
		[Address(RVA = "0x58C0", Offset = "0x58C0", VA = "0x58C0")]
		public OpToken<IMessage, object> AcceleratePreparation(uint warId)
		{
			return null;
		}

		// Token: 0x06000496 RID: 1174 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000496")]
		[Address(RVA = "0x58C1", Offset = "0x58C1", VA = "0x58C1")]
		public OpToken<IMessage, object> CancelAcceleration(uint warId)
		{
			return null;
		}

		// Token: 0x06000497 RID: 1175 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000497")]
		[Address(RVA = "0x58C2", Offset = "0x58C2", VA = "0x58C2")]
		public OpToken<IMessage, object> JoinCombatAsViewer(uint clanWarId)
		{
			return null;
		}

		// Token: 0x06000498 RID: 1176 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000498")]
		[Address(RVA = "0x58C3", Offset = "0x58C3", VA = "0x58C3")]
		public OpToken<IMessage, object> RequestClanCombat(uint clanWarId)
		{
			return null;
		}

		// Token: 0x06000499 RID: 1177 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000499")]
		[Address(RVA = "0x58C4", Offset = "0x58C4", VA = "0x58C4")]
		public OpToken<IMessage, object> UnjoinCombatAsViewer()
		{
			return null;
		}

		// Token: 0x0600049A RID: 1178 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600049A")]
		[Address(RVA = "0x58C5", Offset = "0x58C5", VA = "0x58C5")]
		public ClanWarsService()
		{
		}
	}
}
