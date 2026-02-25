using System;
using Gameplay.Clans.Combat.Model;
using Gameplay.Combat.Control;
using Gameplay.Combat.Model;
using Google.Protobuf;
using Il2CppDummyDll;
using Protocol.ClanWar;
using Protocol.Combat;
using Protocol.Common;
using ServicesNamespace;
using Utils;

namespace Gameplay.Clans.Combat.Control
{
	// Token: 0x02000AA2 RID: 2722
	[Token(Token = "0x2000AA2")]
	public class ClanCombatController : CombatController<ClanCombatModel, ClanCombatEvents>
	{
		// Token: 0x06004179 RID: 16761 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004179")]
		[Address(RVA = "0x9030", Offset = "0x9030", VA = "0x9030", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x0600417A RID: 16762 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600417A")]
		[Address(RVA = "0x9031", Offset = "0x9031", VA = "0x9031")]
		public ClanCombatController(ClanWarsService clanWarsService, ICombatService service, ClanCombatModel model, ClanCombatEvents events)
		{
		}

		// Token: 0x0600417B RID: 16763 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600417B")]
		[Address(RVA = "0x9032", Offset = "0x9032", VA = "0x9032", Slot = "7")]
		protected override void HandleRun()
		{
		}

		// Token: 0x0600417C RID: 16764 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600417C")]
		[Address(RVA = "0x9033", Offset = "0x9033", VA = "0x9033", Slot = "15")]
		protected override void AddCombatServiceEventsHandlers()
		{
		}

		// Token: 0x0600417D RID: 16765 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600417D")]
		[Address(RVA = "0x9034", Offset = "0x9034", VA = "0x9034", Slot = "16")]
		protected override void RemoveCombatServiceEventsHandlers()
		{
		}

		// Token: 0x0600417E RID: 16766 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600417E")]
		[Address(RVA = "0x9035", Offset = "0x9035", VA = "0x9035")]
		private void AddPlayer(PlayerInfo info)
		{
		}

		// Token: 0x0600417F RID: 16767 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600417F")]
		[Address(RVA = "0x9036", Offset = "0x9036", VA = "0x9036")]
		private void RemovePlayer(ulong userId)
		{
		}

		// Token: 0x06004180 RID: 16768 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004180")]
		[Address(RVA = "0x9037", Offset = "0x9037", VA = "0x9037")]
		private void Join(ProtoJoinToCombatAns msg)
		{
		}

		// Token: 0x06004181 RID: 16769 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004181")]
		[Address(RVA = "0x9038", Offset = "0x9038", VA = "0x9038", Slot = "19")]
		protected override void HandleGameOver(ProtoCombatCompleteEvt msg)
		{
		}

		// Token: 0x06004182 RID: 16770 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004182")]
		[Address(RVA = "0x9039", Offset = "0x9039", VA = "0x9039", Slot = "18")]
		protected override void HandleJoinToCombatInfoChanged()
		{
		}

		// Token: 0x06004183 RID: 16771 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004183")]
		[Address(RVA = "0x903A", Offset = "0x903A", VA = "0x903A", Slot = "23")]
		protected override void HandleGameOverInfoChanged(Gameplay.Combat.Model.GameOverData gameOverData)
		{
		}

		// Token: 0x06004184 RID: 16772 RVA: 0x0000C978 File Offset: 0x0000AB78
		[Token(Token = "0x6004184")]
		[Address(RVA = "0x903B", Offset = "0x903B", VA = "0x903B", Slot = "22")]
		protected override bool IsOtherPlayer(ProtoPlayerActionEvt msg)
		{
			return default(bool);
		}

		// Token: 0x06004185 RID: 16773 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004185")]
		[Address(RVA = "0x903C", Offset = "0x903C", VA = "0x903C")]
		private void HandlePlayerAddedEvent(ProtoPlayerAddedEvt msg)
		{
		}

		// Token: 0x06004186 RID: 16774 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004186")]
		[Address(RVA = "0x903D", Offset = "0x903D", VA = "0x903D")]
		private void HandlePlayerRemovedEvent(ProtoDefaultUserCmd msg)
		{
		}

		// Token: 0x06004187 RID: 16775 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004187")]
		[Address(RVA = "0x903E", Offset = "0x903E", VA = "0x903E")]
		private void HandleSwitchTurnServiceEvent(ProtoSwitchTurnEvt msg)
		{
		}

		// Token: 0x06004188 RID: 16776 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004188")]
		[Address(RVA = "0x903F", Offset = "0x903F", VA = "0x903F")]
		private void HandleClanWarComplete(ProtoClanWarCompleteEvt msg)
		{
		}

		// Token: 0x06004189 RID: 16777 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004189")]
		[Address(RVA = "0x9040", Offset = "0x9040", VA = "0x9040")]
		private void RequestJoin()
		{
		}

		// Token: 0x0600418A RID: 16778 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600418A")]
		[Address(RVA = "0x9041", Offset = "0x9041", VA = "0x9041")]
		private void HandleJoinToCombatService(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x0600418B RID: 16779 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600418B")]
		[Address(RVA = "0x9042", Offset = "0x9042", VA = "0x9042")]
		private void RequestCombat(uint clanWarId)
		{
		}

		// Token: 0x0600418C RID: 16780 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600418C")]
		[Address(RVA = "0x9043", Offset = "0x9043", VA = "0x9043")]
		private void HandleRequestCombatService(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x0600418D RID: 16781 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600418D")]
		[Address(RVA = "0x9044", Offset = "0x9044", VA = "0x9044")]
		private void RequestJoinCombatAsViewer(uint clanWarId)
		{
		}

		// Token: 0x0600418E RID: 16782 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600418E")]
		[Address(RVA = "0x9045", Offset = "0x9045", VA = "0x9045")]
		private void HandleJoinCombatAsViewerService(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x0600418F RID: 16783 RVA: 0x0000C990 File Offset: 0x0000AB90
		[Token(Token = "0x600418F")]
		[Address(RVA = "0x9046", Offset = "0x9046", VA = "0x9046")]
		public bool TryRequestCombat(uint clanWarId)
		{
			return default(bool);
		}

		// Token: 0x06004190 RID: 16784 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004190")]
		[Address(RVA = "0x9047", Offset = "0x9047", VA = "0x9047", Slot = "25")]
		public override void NotifyShowViewProcessComplete()
		{
		}

		// Token: 0x06004191 RID: 16785 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004191")]
		[Address(RVA = "0x9048", Offset = "0x9048", VA = "0x9048")]
		public void Exit()
		{
		}

		// Token: 0x04002448 RID: 9288
		[Token(Token = "0x4002448")]
		[FieldOffset(Offset = "0x20")]
		private ClanWarsService _clanWarsService;
	}
}
