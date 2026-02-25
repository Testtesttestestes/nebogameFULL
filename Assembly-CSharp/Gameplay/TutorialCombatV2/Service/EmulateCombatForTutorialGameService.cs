using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Net;
using Gameplay.TutorialV2.Controller;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Il2CppDummyDll;
using Protocol.Combat;
using Protocol.Common;
using ServicesNamespace;
using Utils;

namespace Gameplay.TutorialCombatV2.Service
{
	// Token: 0x02000449 RID: 1097
	[Token(Token = "0x2000449")]
	public class EmulateCombatForTutorialGameService : AbstractService, ICombatService
	{
		// Token: 0x1700048C RID: 1164
		// (get) Token: 0x060019DD RID: 6621 RVA: 0x000059A0 File Offset: 0x00003BA0
		[Token(Token = "0x1700048C")]
		public override short ServiceId
		{
			[Token(Token = "0x60019DD")]
			[Address(RVA = "0x6B75", Offset = "0x6B75", VA = "0x6B75", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1400011C RID: 284
		// (add) Token: 0x060019DE RID: 6622 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060019DF RID: 6623 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400011C")]
		public event Action<ProtoJumpToCombatEvt> JumpToCombatEvent
		{
			[Token(Token = "0x60019DE")]
			[Address(RVA = "0x6B76", Offset = "0x6B76", VA = "0x6B76", Slot = "7")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60019DF")]
			[Address(RVA = "0x6B77", Offset = "0x6B77", VA = "0x6B77", Slot = "8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400011D RID: 285
		// (add) Token: 0x060019E0 RID: 6624 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060019E1 RID: 6625 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400011D")]
		public event Action<ProtoSwitchTurnEvt> SwitchTurnEvent
		{
			[Token(Token = "0x60019E0")]
			[Address(RVA = "0x6B78", Offset = "0x6B78", VA = "0x6B78", Slot = "9")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60019E1")]
			[Address(RVA = "0x6B79", Offset = "0x6B79", VA = "0x6B79", Slot = "10")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400011E RID: 286
		// (add) Token: 0x060019E2 RID: 6626 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060019E3 RID: 6627 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400011E")]
		public event Action<ProtoFieldChangedEvt> FieldChangedEvent
		{
			[Token(Token = "0x60019E2")]
			[Address(RVA = "0x6B7A", Offset = "0x6B7A", VA = "0x6B7A", Slot = "11")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60019E3")]
			[Address(RVA = "0x6B7B", Offset = "0x6B7B", VA = "0x6B7B", Slot = "12")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400011F RID: 287
		// (add) Token: 0x060019E4 RID: 6628 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060019E5 RID: 6629 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400011F")]
		public event Action<ProtoPlayerActionEvt> PlayersActionEvent
		{
			[Token(Token = "0x60019E4")]
			[Address(RVA = "0x6B7C", Offset = "0x6B7C", VA = "0x6B7C", Slot = "13")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60019E5")]
			[Address(RVA = "0x6B7D", Offset = "0x6B7D", VA = "0x6B7D", Slot = "14")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000120 RID: 288
		// (add) Token: 0x060019E6 RID: 6630 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060019E7 RID: 6631 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000120")]
		public event Action<ProtoCombatEventsEvt> CombatEventsEvent
		{
			[Token(Token = "0x60019E6")]
			[Address(RVA = "0x6B7E", Offset = "0x6B7E", VA = "0x6B7E", Slot = "15")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60019E7")]
			[Address(RVA = "0x6B7F", Offset = "0x6B7F", VA = "0x6B7F", Slot = "16")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000121 RID: 289
		// (add) Token: 0x060019E8 RID: 6632 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060019E9 RID: 6633 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000121")]
		public event Action<ProtoCombatCompleteEvt> CombatCompleteEvent
		{
			[Token(Token = "0x60019E8")]
			[Address(RVA = "0x6B80", Offset = "0x6B80", VA = "0x6B80", Slot = "17")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60019E9")]
			[Address(RVA = "0x6B81", Offset = "0x6B81", VA = "0x6B81", Slot = "18")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000122 RID: 290
		// (add) Token: 0x060019EA RID: 6634 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060019EB RID: 6635 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000122")]
		public event Action<ProtoShowHintEvt> ShowHintEvent
		{
			[Token(Token = "0x60019EA")]
			[Address(RVA = "0x6B82", Offset = "0x6B82", VA = "0x6B82", Slot = "19")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60019EB")]
			[Address(RVA = "0x6B83", Offset = "0x6B83", VA = "0x6B83", Slot = "20")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000123 RID: 291
		// (add) Token: 0x060019EC RID: 6636 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060019ED RID: 6637 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000123")]
		public event Action<ProtoCombatTerminatedEvt> CombatTerminatedEvent
		{
			[Token(Token = "0x60019EC")]
			[Address(RVA = "0x6B84", Offset = "0x6B84", VA = "0x6B84", Slot = "21")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60019ED")]
			[Address(RVA = "0x6B85", Offset = "0x6B85", VA = "0x6B85", Slot = "22")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000124 RID: 292
		// (add) Token: 0x060019EE RID: 6638 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060019EF RID: 6639 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000124")]
		public event Action<ProtoSkillsChangedEvt> SkillsChangedEvent
		{
			[Token(Token = "0x60019EE")]
			[Address(RVA = "0x6B86", Offset = "0x6B86", VA = "0x6B86", Slot = "23")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60019EF")]
			[Address(RVA = "0x6B87", Offset = "0x6B87", VA = "0x6B87", Slot = "24")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000125 RID: 293
		// (add) Token: 0x060019F0 RID: 6640 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060019F1 RID: 6641 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000125")]
		public event Action<ProtoSpellCoolDownChangedEvt> CooldownChangedEvent
		{
			[Token(Token = "0x60019F0")]
			[Address(RVA = "0x6B88", Offset = "0x6B88", VA = "0x6B88", Slot = "25")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60019F1")]
			[Address(RVA = "0x6B89", Offset = "0x6B89", VA = "0x6B89", Slot = "26")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000126 RID: 294
		// (add) Token: 0x060019F2 RID: 6642 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060019F3 RID: 6643 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000126")]
		public event Action<ProtoSpellAppliedEvt> SpellAppliedEvent
		{
			[Token(Token = "0x60019F2")]
			[Address(RVA = "0x6B8A", Offset = "0x6B8A", VA = "0x6B8A", Slot = "27")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60019F3")]
			[Address(RVA = "0x6B8B", Offset = "0x6B8B", VA = "0x6B8B", Slot = "28")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000127 RID: 295
		// (add) Token: 0x060019F4 RID: 6644 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060019F5 RID: 6645 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000127")]
		public event Action<ProtoEffectsChangedEvt> EffectsChangedEvent
		{
			[Token(Token = "0x60019F4")]
			[Address(RVA = "0x6B8C", Offset = "0x6B8C", VA = "0x6B8C", Slot = "29")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60019F5")]
			[Address(RVA = "0x6B8D", Offset = "0x6B8D", VA = "0x6B8D", Slot = "30")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000128 RID: 296
		// (add) Token: 0x060019F6 RID: 6646 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060019F7 RID: 6647 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000128")]
		public event Action<ProtoChatEvt> ChatEventEvent
		{
			[Token(Token = "0x60019F6")]
			[Address(RVA = "0x6B8E", Offset = "0x6B8E", VA = "0x6B8E", Slot = "31")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60019F7")]
			[Address(RVA = "0x6B8F", Offset = "0x6B8F", VA = "0x6B8F", Slot = "32")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000129 RID: 297
		// (add) Token: 0x060019F8 RID: 6648 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060019F9 RID: 6649 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000129")]
		public event Action<ProtoPlayerAddedEvt> PlayerAddedEvent
		{
			[Token(Token = "0x60019F8")]
			[Address(RVA = "0x6B90", Offset = "0x6B90", VA = "0x6B90", Slot = "33")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60019F9")]
			[Address(RVA = "0x6B91", Offset = "0x6B91", VA = "0x6B91", Slot = "34")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400012A RID: 298
		// (add) Token: 0x060019FA RID: 6650 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060019FB RID: 6651 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400012A")]
		public event Action<ProtoDefaultUserCmd> PlayerRemovedEvent
		{
			[Token(Token = "0x60019FA")]
			[Address(RVA = "0x6B92", Offset = "0x6B92", VA = "0x6B92", Slot = "35")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60019FB")]
			[Address(RVA = "0x6B93", Offset = "0x6B93", VA = "0x6B93", Slot = "36")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400012B RID: 299
		// (add) Token: 0x060019FC RID: 6652 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060019FD RID: 6653 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400012B")]
		public event Action<ProtoThemeScoreChangedEvt> ThemeScoreChangedEvt
		{
			[Token(Token = "0x60019FC")]
			[Address(RVA = "0x6B94", Offset = "0x6B94", VA = "0x6B94", Slot = "37")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60019FD")]
			[Address(RVA = "0x6B95", Offset = "0x6B95", VA = "0x6B95", Slot = "38")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400012C RID: 300
		// (add) Token: 0x060019FE RID: 6654 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060019FF RID: 6655 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400012C")]
		public event Action<ProtoAntiqEffectTriggeredEvt> AntiqEffectTriggeredEvt
		{
			[Token(Token = "0x60019FE")]
			[Address(RVA = "0x6B96", Offset = "0x6B96", VA = "0x6B96", Slot = "39")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60019FF")]
			[Address(RVA = "0x6B97", Offset = "0x6B97", VA = "0x6B97", Slot = "40")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06001A00 RID: 6656 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A00")]
		[Address(RVA = "0x6B98", Offset = "0x6B98", VA = "0x6B98", Slot = "6")]
		protected override void ServerEventHandler(SrvAnswer evt)
		{
		}

		// Token: 0x06001A01 RID: 6657 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001A01")]
		[Address(RVA = "0x6B99", Offset = "0x6B99", VA = "0x6B99", Slot = "41")]
		public OpToken<IMessage, object> PutJoinRequest(ProtoRequestCombatCmd.Types.ArenaCombatTypes arenaCombatType, CombatTypes combatType)
		{
			return null;
		}

		// Token: 0x06001A02 RID: 6658 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001A02")]
		[Address(RVA = "0x6B9A", Offset = "0x6B9A", VA = "0x6B9A", Slot = "42")]
		public OpToken<IMessage, object> JoinToCombat()
		{
			return null;
		}

		// Token: 0x06001A03 RID: 6659 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001A03")]
		[Address(RVA = "0x6B9B", Offset = "0x6B9B", VA = "0x6B9B", Slot = "43")]
		public OpToken<IMessage, object> PlayerAction(PlayerActionTypes id, Point src, Point dst, SpellKey spellKey, params ulong[] targetUserIds)
		{
			return null;
		}

		// Token: 0x06001A04 RID: 6660 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001A04")]
		[Address(RVA = "0x6B9C", Offset = "0x6B9C", VA = "0x6B9C", Slot = "44")]
		public OpToken<IMessage, object> RewardsGot()
		{
			return null;
		}

		// Token: 0x06001A05 RID: 6661 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A05")]
		[Address(RVA = "0x6B9D", Offset = "0x6B9D", VA = "0x6B9D")]
		public EmulateCombatForTutorialGameService(ProtocolCommandInfoProvider protocolInfoProvider, TutorialStepsConveyor tutorialStepsConveyor, ulong myUserId)
		{
		}

		// Token: 0x06001A06 RID: 6662 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A06")]
		[Address(RVA = "0x6B9E", Offset = "0x6B9E", VA = "0x6B9E")]
		private void SetOpponentPlayer(PlayerInfo player)
		{
		}

		// Token: 0x06001A07 RID: 6663 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A07")]
		[Address(RVA = "0x6B9F", Offset = "0x6B9F", VA = "0x6B9F")]
		private void SetMyPlayer(PlayerInfo player)
		{
		}

		// Token: 0x06001A08 RID: 6664 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A08")]
		[Address(RVA = "0x6BA0", Offset = "0x6BA0", VA = "0x6BA0")]
		private void PlayerActionEmulate(PlayerActionTypes id, Point src, Point dst, SpellKey spellKey, ProtoDefaultAns msg, params ulong[] targetUserIds)
		{
		}

		// Token: 0x06001A09 RID: 6665 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A09")]
		[Address(RVA = "0x6BA1", Offset = "0x6BA1", VA = "0x6BA1")]
		private void HandleJointCmd(SrvCommand cmd, IMessage msg)
		{
		}

		// Token: 0x06001A0A RID: 6666 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001A0A")]
		[Address(RVA = "0x6BA2", Offset = "0x6BA2", VA = "0x6BA2")]
		private IEnumerator<EmulateCombatForTutorialGameService.Swap> GetOpponentSwaps()
		{
			return null;
		}

		// Token: 0x06001A0B RID: 6667 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001A0B")]
		[Address(RVA = "0x6BA3", Offset = "0x6BA3", VA = "0x6BA3")]
		private IEnumerator<EmulateCombatForTutorialGameService.Swap> GetAvailUserSwaps()
		{
			return null;
		}

		// Token: 0x06001A0C RID: 6668 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001A0C")]
		[Address(RVA = "0x6BA4", Offset = "0x6BA4", VA = "0x6BA4")]
		private IEnumerator<ProtoSwitchTurnEvt> GetTurnChanges()
		{
			return null;
		}

		// Token: 0x06001A0D RID: 6669 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001A0D")]
		[Address(RVA = "0x6BA5", Offset = "0x6BA5", VA = "0x6BA5")]
		private IEnumerator<ProtoFieldChangedEvt[]> GetFieldChange(ulong myUserId)
		{
			return null;
		}

		// Token: 0x06001A0E RID: 6670 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001A0E")]
		[Address(RVA = "0x6BA6", Offset = "0x6BA6", VA = "0x6BA6")]
		private IEnumerator<ProtoSkillsChangedEvt> GetSkillChanged()
		{
			return null;
		}

		// Token: 0x04000DF5 RID: 3573
		[Token(Token = "0x4000DF5")]
		private const int TURN_TIMEOUT = 2147483647;

		// Token: 0x04000DF6 RID: 3574
		[Token(Token = "0x4000DF6")]
		[FieldOffset(Offset = "0x58")]
		private PlayerInfo _myPlayer;

		// Token: 0x04000DF7 RID: 3575
		[Token(Token = "0x4000DF7")]
		[FieldOffset(Offset = "0x5C")]
		private PlayerInfo _opponentPlayer;

		// Token: 0x04000DF8 RID: 3576
		[Token(Token = "0x4000DF8")]
		[FieldOffset(Offset = "0x60")]
		private RepeatedField<PlayerSkill> _opponentPlayerOriginSkills;

		// Token: 0x04000DF9 RID: 3577
		[Token(Token = "0x4000DF9")]
		[FieldOffset(Offset = "0x64")]
		private RepeatedField<PlayerSkill> _myPlayerOriginSkills;

		// Token: 0x04000DFA RID: 3578
		[Token(Token = "0x4000DFA")]
		[FieldOffset(Offset = "0x68")]
		private readonly ulong _myUserId;

		// Token: 0x04000DFB RID: 3579
		[Token(Token = "0x4000DFB")]
		[FieldOffset(Offset = "0x70")]
		private readonly IEnumerator<ProtoSwitchTurnEvt> _turns;

		// Token: 0x04000DFC RID: 3580
		[Token(Token = "0x4000DFC")]
		[FieldOffset(Offset = "0x74")]
		private readonly IEnumerator<ProtoSkillsChangedEvt> _skills;

		// Token: 0x04000DFD RID: 3581
		[Token(Token = "0x4000DFD")]
		[FieldOffset(Offset = "0x78")]
		private readonly IEnumerator<ProtoFieldChangedEvt[]> _field;

		// Token: 0x04000DFE RID: 3582
		[Token(Token = "0x4000DFE")]
		[FieldOffset(Offset = "0x7C")]
		private readonly IEnumerator<EmulateCombatForTutorialGameService.Swap> _availUserSwaps;

		// Token: 0x04000DFF RID: 3583
		[Token(Token = "0x4000DFF")]
		[FieldOffset(Offset = "0x80")]
		private readonly IEnumerator<EmulateCombatForTutorialGameService.Swap> _opponentSwaps;

		// Token: 0x04000E00 RID: 3584
		[Token(Token = "0x4000E00")]
		[FieldOffset(Offset = "0x84")]
		private readonly RepeatedField<StonesTypes> _firstTimeField;

		// Token: 0x04000E01 RID: 3585
		[Token(Token = "0x4000E01")]
		[FieldOffset(Offset = "0x88")]
		private TutorialStepsConveyor _conveyor;

		// Token: 0x0200044A RID: 1098
		[Token(Token = "0x200044A")]
		private class Swap
		{
			// Token: 0x06001A0F RID: 6671 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001A0F")]
			[Address(RVA = "0x6BA7", Offset = "0x6BA7", VA = "0x6BA7")]
			public Swap(Point from, Point to)
			{
			}

			// Token: 0x04000E02 RID: 3586
			[Token(Token = "0x4000E02")]
			[FieldOffset(Offset = "0x8")]
			public readonly Point From;

			// Token: 0x04000E03 RID: 3587
			[Token(Token = "0x4000E03")]
			[FieldOffset(Offset = "0xC")]
			public readonly Point To;
		}
	}
}
