using System;
using Google.Protobuf;
using Il2CppDummyDll;
using Protocol.Combat;
using Protocol.Common;
using Utils;

namespace ServicesNamespace
{
	// Token: 0x0200009F RID: 159
	[Token(Token = "0x200009F")]
	public interface ICombatService
	{
		// Token: 0x1400006A RID: 106
		// (add) Token: 0x06000566 RID: 1382
		// (remove) Token: 0x06000567 RID: 1383
		[Token(Token = "0x1400006A")]
		event Action<ProtoJumpToCombatEvt> JumpToCombatEvent;

		// Token: 0x1400006B RID: 107
		// (add) Token: 0x06000568 RID: 1384
		// (remove) Token: 0x06000569 RID: 1385
		[Token(Token = "0x1400006B")]
		event Action<ProtoSwitchTurnEvt> SwitchTurnEvent;

		// Token: 0x1400006C RID: 108
		// (add) Token: 0x0600056A RID: 1386
		// (remove) Token: 0x0600056B RID: 1387
		[Token(Token = "0x1400006C")]
		event Action<ProtoFieldChangedEvt> FieldChangedEvent;

		// Token: 0x1400006D RID: 109
		// (add) Token: 0x0600056C RID: 1388
		// (remove) Token: 0x0600056D RID: 1389
		[Token(Token = "0x1400006D")]
		event Action<ProtoPlayerActionEvt> PlayersActionEvent;

		// Token: 0x1400006E RID: 110
		// (add) Token: 0x0600056E RID: 1390
		// (remove) Token: 0x0600056F RID: 1391
		[Token(Token = "0x1400006E")]
		event Action<ProtoCombatEventsEvt> CombatEventsEvent;

		// Token: 0x1400006F RID: 111
		// (add) Token: 0x06000570 RID: 1392
		// (remove) Token: 0x06000571 RID: 1393
		[Token(Token = "0x1400006F")]
		event Action<ProtoCombatCompleteEvt> CombatCompleteEvent;

		// Token: 0x14000070 RID: 112
		// (add) Token: 0x06000572 RID: 1394
		// (remove) Token: 0x06000573 RID: 1395
		[Token(Token = "0x14000070")]
		event Action<ProtoShowHintEvt> ShowHintEvent;

		// Token: 0x14000071 RID: 113
		// (add) Token: 0x06000574 RID: 1396
		// (remove) Token: 0x06000575 RID: 1397
		[Token(Token = "0x14000071")]
		event Action<ProtoCombatTerminatedEvt> CombatTerminatedEvent;

		// Token: 0x14000072 RID: 114
		// (add) Token: 0x06000576 RID: 1398
		// (remove) Token: 0x06000577 RID: 1399
		[Token(Token = "0x14000072")]
		event Action<ProtoSkillsChangedEvt> SkillsChangedEvent;

		// Token: 0x14000073 RID: 115
		// (add) Token: 0x06000578 RID: 1400
		// (remove) Token: 0x06000579 RID: 1401
		[Token(Token = "0x14000073")]
		event Action<ProtoSpellCoolDownChangedEvt> CooldownChangedEvent;

		// Token: 0x14000074 RID: 116
		// (add) Token: 0x0600057A RID: 1402
		// (remove) Token: 0x0600057B RID: 1403
		[Token(Token = "0x14000074")]
		event Action<ProtoSpellAppliedEvt> SpellAppliedEvent;

		// Token: 0x14000075 RID: 117
		// (add) Token: 0x0600057C RID: 1404
		// (remove) Token: 0x0600057D RID: 1405
		[Token(Token = "0x14000075")]
		event Action<ProtoEffectsChangedEvt> EffectsChangedEvent;

		// Token: 0x14000076 RID: 118
		// (add) Token: 0x0600057E RID: 1406
		// (remove) Token: 0x0600057F RID: 1407
		[Token(Token = "0x14000076")]
		event Action<ProtoChatEvt> ChatEventEvent;

		// Token: 0x14000077 RID: 119
		// (add) Token: 0x06000580 RID: 1408
		// (remove) Token: 0x06000581 RID: 1409
		[Token(Token = "0x14000077")]
		event Action<ProtoPlayerAddedEvt> PlayerAddedEvent;

		// Token: 0x14000078 RID: 120
		// (add) Token: 0x06000582 RID: 1410
		// (remove) Token: 0x06000583 RID: 1411
		[Token(Token = "0x14000078")]
		event Action<ProtoDefaultUserCmd> PlayerRemovedEvent;

		// Token: 0x14000079 RID: 121
		// (add) Token: 0x06000584 RID: 1412
		// (remove) Token: 0x06000585 RID: 1413
		[Token(Token = "0x14000079")]
		event Action<ProtoThemeScoreChangedEvt> ThemeScoreChangedEvt;

		// Token: 0x1400007A RID: 122
		// (add) Token: 0x06000586 RID: 1414
		// (remove) Token: 0x06000587 RID: 1415
		[Token(Token = "0x1400007A")]
		event Action<ProtoAntiqEffectTriggeredEvt> AntiqEffectTriggeredEvt;

		// Token: 0x06000588 RID: 1416
		[Token(Token = "0x6000588")]
		OpToken<IMessage, object> PutJoinRequest(ProtoRequestCombatCmd.Types.ArenaCombatTypes arenaCombatType, CombatTypes combatType = CombatTypes.UnknownCombat);

		// Token: 0x06000589 RID: 1417
		[Token(Token = "0x6000589")]
		OpToken<IMessage, object> JoinToCombat();

		// Token: 0x0600058A RID: 1418
		[Token(Token = "0x600058A")]
		OpToken<IMessage, object> PlayerAction(PlayerActionTypes id, Point src, Point dst, SpellKey spellKey, params ulong[] targetUserIds);

		// Token: 0x0600058B RID: 1419
		[Token(Token = "0x600058B")]
		OpToken<IMessage, object> RewardsGot();
	}
}
