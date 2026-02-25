using System;
using System.Runtime.CompilerServices;
using Core.Net;
using Google.Protobuf;
using Il2CppDummyDll;
using Protocol.Combat;
using Protocol.Common;
using Utils;

namespace ServicesNamespace
{
	// Token: 0x02000098 RID: 152
	[Token(Token = "0x2000098")]
	public class CombatService : AbstractService, ICombatService
	{
		// Token: 0x1400004E RID: 78
		// (add) Token: 0x060004ED RID: 1261 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060004EE RID: 1262 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400004E")]
		public event Action<ProtoJumpToCombatEvt> JumpToCombatEvent
		{
			[Token(Token = "0x60004ED")]
			[Address(RVA = "0x5918", Offset = "0x5918", VA = "0x5918", Slot = "7")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60004EE")]
			[Address(RVA = "0x5919", Offset = "0x5919", VA = "0x5919", Slot = "8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400004F RID: 79
		// (add) Token: 0x060004EF RID: 1263 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060004F0 RID: 1264 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400004F")]
		public event Action<ProtoSwitchTurnEvt> SwitchTurnEvent
		{
			[Token(Token = "0x60004EF")]
			[Address(RVA = "0x591A", Offset = "0x591A", VA = "0x591A", Slot = "9")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60004F0")]
			[Address(RVA = "0x591B", Offset = "0x591B", VA = "0x591B", Slot = "10")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000050 RID: 80
		// (add) Token: 0x060004F1 RID: 1265 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060004F2 RID: 1266 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000050")]
		public event Action<ProtoFieldChangedEvt> FieldChangedEvent
		{
			[Token(Token = "0x60004F1")]
			[Address(RVA = "0x591C", Offset = "0x591C", VA = "0x591C", Slot = "11")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60004F2")]
			[Address(RVA = "0x591D", Offset = "0x591D", VA = "0x591D", Slot = "12")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000051 RID: 81
		// (add) Token: 0x060004F3 RID: 1267 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060004F4 RID: 1268 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000051")]
		public event Action<ProtoPlayerActionEvt> PlayersActionEvent
		{
			[Token(Token = "0x60004F3")]
			[Address(RVA = "0x591E", Offset = "0x591E", VA = "0x591E", Slot = "13")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60004F4")]
			[Address(RVA = "0x591F", Offset = "0x591F", VA = "0x591F", Slot = "14")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000052 RID: 82
		// (add) Token: 0x060004F5 RID: 1269 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060004F6 RID: 1270 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000052")]
		public event Action<ProtoCombatEventsEvt> CombatEventsEvent
		{
			[Token(Token = "0x60004F5")]
			[Address(RVA = "0x5920", Offset = "0x5920", VA = "0x5920", Slot = "15")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60004F6")]
			[Address(RVA = "0x5921", Offset = "0x5921", VA = "0x5921", Slot = "16")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000053 RID: 83
		// (add) Token: 0x060004F7 RID: 1271 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060004F8 RID: 1272 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000053")]
		public event Action<ProtoCombatCompleteEvt> CombatCompleteEvent
		{
			[Token(Token = "0x60004F7")]
			[Address(RVA = "0x5922", Offset = "0x5922", VA = "0x5922", Slot = "17")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60004F8")]
			[Address(RVA = "0x5923", Offset = "0x5923", VA = "0x5923", Slot = "18")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000054 RID: 84
		// (add) Token: 0x060004F9 RID: 1273 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060004FA RID: 1274 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000054")]
		public event Action<ProtoShowHintEvt> ShowHintEvent
		{
			[Token(Token = "0x60004F9")]
			[Address(RVA = "0x5924", Offset = "0x5924", VA = "0x5924", Slot = "19")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60004FA")]
			[Address(RVA = "0x5925", Offset = "0x5925", VA = "0x5925", Slot = "20")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000055 RID: 85
		// (add) Token: 0x060004FB RID: 1275 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060004FC RID: 1276 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000055")]
		public event Action<ProtoCombatTerminatedEvt> CombatTerminatedEvent
		{
			[Token(Token = "0x60004FB")]
			[Address(RVA = "0x5926", Offset = "0x5926", VA = "0x5926", Slot = "21")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60004FC")]
			[Address(RVA = "0x5927", Offset = "0x5927", VA = "0x5927", Slot = "22")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000056 RID: 86
		// (add) Token: 0x060004FD RID: 1277 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060004FE RID: 1278 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000056")]
		public event Action<ProtoSkillsChangedEvt> SkillsChangedEvent
		{
			[Token(Token = "0x60004FD")]
			[Address(RVA = "0x5928", Offset = "0x5928", VA = "0x5928", Slot = "23")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60004FE")]
			[Address(RVA = "0x5929", Offset = "0x5929", VA = "0x5929", Slot = "24")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000057 RID: 87
		// (add) Token: 0x060004FF RID: 1279 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000500 RID: 1280 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000057")]
		public event Action<ProtoSpellCoolDownChangedEvt> CooldownChangedEvent
		{
			[Token(Token = "0x60004FF")]
			[Address(RVA = "0x592A", Offset = "0x592A", VA = "0x592A", Slot = "25")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000500")]
			[Address(RVA = "0x592B", Offset = "0x592B", VA = "0x592B", Slot = "26")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000058 RID: 88
		// (add) Token: 0x06000501 RID: 1281 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000502 RID: 1282 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000058")]
		public event Action<ProtoSpellAppliedEvt> SpellAppliedEvent
		{
			[Token(Token = "0x6000501")]
			[Address(RVA = "0x592C", Offset = "0x592C", VA = "0x592C", Slot = "27")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000502")]
			[Address(RVA = "0x592D", Offset = "0x592D", VA = "0x592D", Slot = "28")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000059 RID: 89
		// (add) Token: 0x06000503 RID: 1283 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000504 RID: 1284 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000059")]
		public event Action<ProtoEffectsChangedEvt> EffectsChangedEvent
		{
			[Token(Token = "0x6000503")]
			[Address(RVA = "0x592E", Offset = "0x592E", VA = "0x592E", Slot = "29")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000504")]
			[Address(RVA = "0x592F", Offset = "0x592F", VA = "0x592F", Slot = "30")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400005A RID: 90
		// (add) Token: 0x06000505 RID: 1285 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000506 RID: 1286 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400005A")]
		public event Action<ProtoChatEvt> ChatEventEvent
		{
			[Token(Token = "0x6000505")]
			[Address(RVA = "0x5930", Offset = "0x5930", VA = "0x5930", Slot = "31")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000506")]
			[Address(RVA = "0x5931", Offset = "0x5931", VA = "0x5931", Slot = "32")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400005B RID: 91
		// (add) Token: 0x06000507 RID: 1287 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000508 RID: 1288 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400005B")]
		public event Action<ProtoPlayerAddedEvt> PlayerAddedEvent
		{
			[Token(Token = "0x6000507")]
			[Address(RVA = "0x5932", Offset = "0x5932", VA = "0x5932", Slot = "33")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000508")]
			[Address(RVA = "0x5933", Offset = "0x5933", VA = "0x5933", Slot = "34")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400005C RID: 92
		// (add) Token: 0x06000509 RID: 1289 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600050A RID: 1290 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400005C")]
		public event Action<ProtoDefaultUserCmd> PlayerRemovedEvent
		{
			[Token(Token = "0x6000509")]
			[Address(RVA = "0x5934", Offset = "0x5934", VA = "0x5934", Slot = "35")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600050A")]
			[Address(RVA = "0x5935", Offset = "0x5935", VA = "0x5935", Slot = "36")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400005D RID: 93
		// (add) Token: 0x0600050B RID: 1291 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600050C RID: 1292 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400005D")]
		public event Action<ProtoThemeScoreChangedEvt> ThemeScoreChangedEvt
		{
			[Token(Token = "0x600050B")]
			[Address(RVA = "0x5936", Offset = "0x5936", VA = "0x5936", Slot = "37")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600050C")]
			[Address(RVA = "0x5937", Offset = "0x5937", VA = "0x5937", Slot = "38")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400005E RID: 94
		// (add) Token: 0x0600050D RID: 1293 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600050E RID: 1294 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400005E")]
		public event Action<ProtoAntiqEffectTriggeredEvt> AntiqEffectTriggeredEvt
		{
			[Token(Token = "0x600050D")]
			[Address(RVA = "0x5938", Offset = "0x5938", VA = "0x5938", Slot = "39")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600050E")]
			[Address(RVA = "0x5939", Offset = "0x5939", VA = "0x5939", Slot = "40")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x0600050F RID: 1295 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600050F")]
		[Address(RVA = "0x593A", Offset = "0x593A", VA = "0x593A")]
		public CombatService()
		{
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x06000510 RID: 1296 RVA: 0x00002F40 File Offset: 0x00001140
		[Token(Token = "0x1700009C")]
		public override short ServiceId
		{
			[Token(Token = "0x6000510")]
			[Address(RVA = "0x593B", Offset = "0x593B", VA = "0x593B", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000511 RID: 1297 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000511")]
		[Address(RVA = "0x593C", Offset = "0x593C", VA = "0x593C", Slot = "6")]
		protected override void ServerEventHandler(SrvAnswer evt)
		{
		}

		// Token: 0x06000512 RID: 1298 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000512")]
		[Address(RVA = "0x593D", Offset = "0x593D", VA = "0x593D", Slot = "45")]
		public virtual OpToken<IMessage, object> PutJoinRequest(ProtoRequestCombatCmd.Types.ArenaCombatTypes arenaCombatType, CombatTypes combatType)
		{
			return null;
		}

		// Token: 0x06000513 RID: 1299 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000513")]
		[Address(RVA = "0x593E", Offset = "0x593E", VA = "0x593E", Slot = "46")]
		public virtual OpToken<IMessage, object> JoinToCombat()
		{
			return null;
		}

		// Token: 0x06000514 RID: 1300 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000514")]
		[Address(RVA = "0x593F", Offset = "0x593F", VA = "0x593F", Slot = "43")]
		public OpToken<IMessage, object> PlayerAction(PlayerActionTypes id, Point src, Point dst, SpellKey spellKey, params ulong[] targetUserIds)
		{
			return null;
		}

		// Token: 0x06000515 RID: 1301 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000515")]
		[Address(RVA = "0x5940", Offset = "0x5940", VA = "0x5940", Slot = "44")]
		public OpToken<IMessage, object> RewardsGot()
		{
			return null;
		}
	}
}
