using System;
using Gameplay.ArenaCombat.Model;
using Gameplay.Combat.Control;
using Gameplay.Combat.Model;
using Google.Protobuf;
using Il2CppDummyDll;
using Protocol.Combat;
using ServicesNamespace;
using Utils;

namespace Gameplay.ArenaCombat.Control
{
	// Token: 0x02000D4A RID: 3402
	[Token(Token = "0x2000D4A")]
	public class ArenaCombatController : CombatController<ArenaCombatModel, ArenaCombatEvents>
	{
		// Token: 0x06005350 RID: 21328 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005350")]
		[Address(RVA = "0xA10F", Offset = "0xA10F", VA = "0xA10F")]
		public ArenaCombatController(ICombatService service, ArenaCombatModel model, ArenaCombatEvents events, MainService mainService)
		{
		}

		// Token: 0x06005351 RID: 21329 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005351")]
		[Address(RVA = "0xA110", Offset = "0xA110", VA = "0xA110", Slot = "18")]
		protected override void HandleJoinToCombatInfoChanged()
		{
		}

		// Token: 0x06005352 RID: 21330 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005352")]
		[Address(RVA = "0xA111", Offset = "0xA111", VA = "0xA111")]
		private void HandleGetOtherUserStatsService(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06005353 RID: 21331 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005353")]
		[Address(RVA = "0xA112", Offset = "0xA112", VA = "0xA112", Slot = "23")]
		protected override void HandleGameOverInfoChanged(GameOverData gameOverData)
		{
		}

		// Token: 0x06005354 RID: 21332 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005354")]
		[Address(RVA = "0xA113", Offset = "0xA113", VA = "0xA113", Slot = "7")]
		protected override void HandleRun()
		{
		}

		// Token: 0x06005355 RID: 21333 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005355")]
		[Address(RVA = "0xA114", Offset = "0xA114", VA = "0xA114")]
		private void HandleAttackMonsterServiceRequest(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06005356 RID: 21334 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005356")]
		[Address(RVA = "0xA115", Offset = "0xA115", VA = "0xA115")]
		private void RequestPutJoinRequest(ProtoRequestCombatCmd.Types.ArenaCombatTypes type)
		{
		}

		// Token: 0x06005357 RID: 21335 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005357")]
		[Address(RVA = "0xA116", Offset = "0xA116", VA = "0xA116")]
		private void HandlePutJoinServiceRequest(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x04002D25 RID: 11557
		[Token(Token = "0x4002D25")]
		[FieldOffset(Offset = "0x20")]
		private MainService _mainService;
	}
}
