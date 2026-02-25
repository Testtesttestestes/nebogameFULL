using System;
using System.Collections.Generic;
using Gameplay.Combat.Control;
using Gameplay.Combat.Model;
using Google.Protobuf.Collections;
using Il2CppDummyDll;
using MVC;
using Protocol.Combat;
using Utils;

namespace Gameplay.Combat.Events
{
	// Token: 0x020009AE RID: 2478
	[Token(Token = "0x20009AE")]
	public class CombatEvents : AbstractMVCEvents
	{
		// Token: 0x06003B19 RID: 15129 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B19")]
		[Address(RVA = "0x8A7A", Offset = "0x8A7A", VA = "0x8A7A")]
		public CombatEvents()
		{
		}

		// Token: 0x04002096 RID: 8342
		[Token(Token = "0x4002096")]
		[FieldOffset(Offset = "0x14")]
		public Action<ProtoCombatTerminatedEvt> CombatTerminatedEvent;

		// Token: 0x04002097 RID: 8343
		[Token(Token = "0x4002097")]
		[FieldOffset(Offset = "0x18")]
		public Action<BackTime> StartAwaitCombat;

		// Token: 0x04002098 RID: 8344
		[Token(Token = "0x4002098")]
		[FieldOffset(Offset = "0x1C")]
		public Action<CombatModel> FinishAwaitCombat;

		// Token: 0x04002099 RID: 8345
		[Token(Token = "0x4002099")]
		[FieldOffset(Offset = "0x20")]
		public Action<CombatFieldChangesConvItem> CombatGameEvents;

		// Token: 0x0400209A RID: 8346
		[Token(Token = "0x400209A")]
		[FieldOffset(Offset = "0x24")]
		public Action CombatGameEventsFinish;

		// Token: 0x0400209B RID: 8347
		[Token(Token = "0x400209B")]
		[FieldOffset(Offset = "0x28")]
		public Action<ProtoCombatEventsEvt> SkillsWorkedEvents;

		// Token: 0x0400209C RID: 8348
		[Token(Token = "0x400209C")]
		[FieldOffset(Offset = "0x2C")]
		public Action RequestPrepareView;

		// Token: 0x0400209D RID: 8349
		[Token(Token = "0x400209D")]
		[FieldOffset(Offset = "0x30")]
		public Action<CombatPlayer> PlayerAdded;

		// Token: 0x0400209E RID: 8350
		[Token(Token = "0x400209E")]
		[FieldOffset(Offset = "0x34")]
		public Action<CombatPlayer> PlayerRemoved;

		// Token: 0x0400209F RID: 8351
		[Token(Token = "0x400209F")]
		[FieldOffset(Offset = "0x38")]
		public Action<RepeatedField<ProtoAntiqEffectTriggeredEvt.Types.EffectResult>> AntiqEffectTriggeredEvent;

		// Token: 0x040020A0 RID: 8352
		[Token(Token = "0x40020A0")]
		[FieldOffset(Offset = "0x3C")]
		public Action<ulong> OtherPlayerTriggersChanged;

		// Token: 0x040020A1 RID: 8353
		[Token(Token = "0x40020A1")]
		[FieldOffset(Offset = "0x40")]
		public Action<TurnStates> SwitchTurn;

		// Token: 0x040020A2 RID: 8354
		[Token(Token = "0x40020A2")]
		[FieldOffset(Offset = "0x44")]
		public Action<ProtoShowHintEvt> DisplayHintEvent;

		// Token: 0x040020A3 RID: 8355
		[Token(Token = "0x40020A3")]
		[FieldOffset(Offset = "0x48")]
		public Action<int, int, int, int> SwapStonesRequest;

		// Token: 0x040020A4 RID: 8356
		[Token(Token = "0x40020A4")]
		[FieldOffset(Offset = "0x4C")]
		public Action<int, int, int, int> SwapStonesError;

		// Token: 0x040020A5 RID: 8357
		[Token(Token = "0x40020A5")]
		[FieldOffset(Offset = "0x50")]
		public Action<List<CombatSpellData>> CooldownChanged;

		// Token: 0x040020A6 RID: 8358
		[Token(Token = "0x40020A6")]
		[FieldOffset(Offset = "0x54")]
		public Action<CombatSpellData> SpellUsed;

		// Token: 0x040020A7 RID: 8359
		[Token(Token = "0x40020A7")]
		[FieldOffset(Offset = "0x58")]
		public Action<CombatPlayer, CombatSpellData, List<CombatPlayer>> SpellApplied;

		// Token: 0x040020A8 RID: 8360
		[Token(Token = "0x40020A8")]
		[FieldOffset(Offset = "0x5C")]
		public Action<CombatSpellData, CombatSpellData> SelectedSpellChanged;

		// Token: 0x040020A9 RID: 8361
		[Token(Token = "0x40020A9")]
		[FieldOffset(Offset = "0x60")]
		public Action<IList<CombatPlayer>> EffectsChanged;

		// Token: 0x040020AA RID: 8362
		[Token(Token = "0x40020AA")]
		[FieldOffset(Offset = "0x64")]
		public Action<IList<CombatPlayer>> UserSkillsChanged;

		// Token: 0x040020AB RID: 8363
		[Token(Token = "0x40020AB")]
		[FieldOffset(Offset = "0x68")]
		public Action<CombatPlayer> UserBalanceChanged;

		// Token: 0x040020AC RID: 8364
		[Token(Token = "0x40020AC")]
		[FieldOffset(Offset = "0x6C")]
		public Action<CombatPlayer, string> ChatEvent;
	}
}
