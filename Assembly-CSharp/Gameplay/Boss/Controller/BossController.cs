using System;
using Gameplay.Boss.Events;
using Gameplay.Boss.Model;
using Gameplay.Combat;
using Google.Protobuf;
using Il2CppDummyDll;
using MVC;
using Protocol.Boss;
using ServicesNamespace;
using Utils;

namespace Gameplay.Boss.Controller
{
	// Token: 0x02000BA4 RID: 2980
	[Token(Token = "0x2000BA4")]
	public class BossController : AbstractController<BossModel, BossEvents>
	{
		// Token: 0x060048D1 RID: 18641 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048D1")]
		[Address(RVA = "0x9746", Offset = "0x9746", VA = "0x9746")]
		public BossController(BossModel model, BossEvents events)
		{
		}

		// Token: 0x060048D2 RID: 18642 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60048D2")]
		[Address(RVA = "0x1B66", Offset = "0x1B66", VA = "0x1B66")]
		public BossInstance AddBoss(InstanceInfo instanceInfo)
		{
			return null;
		}

		// Token: 0x060048D3 RID: 18643 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048D3")]
		[Address(RVA = "0x1B62", Offset = "0x1B62", VA = "0x1B62")]
		public void RemoveBoss(BossInstance instance)
		{
		}

		// Token: 0x060048D4 RID: 18644 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048D4")]
		[Address(RVA = "0x9747", Offset = "0x9747", VA = "0x9747")]
		private void CaptainInvitesChangedEvent()
		{
		}

		// Token: 0x060048D5 RID: 18645 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048D5")]
		[Address(RVA = "0x9748", Offset = "0x9748", VA = "0x9748")]
		private void MyTeamsInfoChangedEvent()
		{
		}

		// Token: 0x060048D6 RID: 18646 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048D6")]
		[Address(RVA = "0x9749", Offset = "0x9749", VA = "0x9749", Slot = "7")]
		protected override void HandleRun()
		{
		}

		// Token: 0x060048D7 RID: 18647 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048D7")]
		[Address(RVA = "0x974A", Offset = "0x974A", VA = "0x974A")]
		private void CurrentIsleChangedEvent(ulong id)
		{
		}

		// Token: 0x060048D8 RID: 18648 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048D8")]
		[Address(RVA = "0x974B", Offset = "0x974B", VA = "0x974B")]
		private void HandleServiceReadyToListen(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x060048D9 RID: 18649 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048D9")]
		[Address(RVA = "0x974C", Offset = "0x974C", VA = "0x974C", Slot = "6")]
		protected override void HandleStop()
		{
		}

		// Token: 0x060048DA RID: 18650 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048DA")]
		[Address(RVA = "0x974D", Offset = "0x974D", VA = "0x974D", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x060048DB RID: 18651 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048DB")]
		[Address(RVA = "0x974E", Offset = "0x974E", VA = "0x974E")]
		public void GetInstanceList()
		{
		}

		// Token: 0x060048DC RID: 18652 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048DC")]
		[Address(RVA = "0x974F", Offset = "0x974F", VA = "0x974F")]
		public void BeginBattle(long optionId, int variantId)
		{
		}

		// Token: 0x060048DD RID: 18653 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048DD")]
		[Address(RVA = "0x9750", Offset = "0x9750", VA = "0x9750")]
		public void AttackMinion(ICombat combat)
		{
		}

		// Token: 0x060048DE RID: 18654 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048DE")]
		[Address(RVA = "0x9751", Offset = "0x9751", VA = "0x9751")]
		public void PayoffMinion(ICombat combat)
		{
		}

		// Token: 0x060048DF RID: 18655 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048DF")]
		[Address(RVA = "0x9752", Offset = "0x9752", VA = "0x9752")]
		private void HandleServiceGetInstanceList(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x060048E0 RID: 18656 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048E0")]
		[Address(RVA = "0x9753", Offset = "0x9753", VA = "0x9753")]
		private void BeginBattleServiceHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x060048E1 RID: 18657 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048E1")]
		[Address(RVA = "0x9754", Offset = "0x9754", VA = "0x9754")]
		private void HandleServiceMinionAttackCancel(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x060048E2 RID: 18658 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048E2")]
		[Address(RVA = "0x9755", Offset = "0x9755", VA = "0x9755")]
		private void HandleServiceMinionJumpToCombat(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x060048E3 RID: 18659 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048E3")]
		[Address(RVA = "0x9756", Offset = "0x9756", VA = "0x9756")]
		private void BossServiceOnMonsterHealthChangedEvent(MonsterHealthEvt monsterHealthEvt)
		{
		}

		// Token: 0x060048E4 RID: 18660 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048E4")]
		[Address(RVA = "0x9757", Offset = "0x9757", VA = "0x9757")]
		private void BossServiceOnInstanceInfoEvent(InstanceInfoEvt instanceInfo)
		{
		}

		// Token: 0x060048E5 RID: 18661 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048E5")]
		[Address(RVA = "0x9758", Offset = "0x9758", VA = "0x9758")]
		private void BossServiceOnCreateRequestEvent(CreateRequestEvt createRequestEvt)
		{
		}

		// Token: 0x060048E6 RID: 18662 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048E6")]
		[Address(RVA = "0x9759", Offset = "0x9759", VA = "0x9759")]
		public void HandleExternalMinionAttack(MinionAttackEvt evt)
		{
		}

		// Token: 0x060048E7 RID: 18663 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048E7")]
		[Address(RVA = "0x975A", Offset = "0x975A", VA = "0x975A")]
		private void BossServiceOnMinionAttackEvent(MinionAttackEvt evt)
		{
		}

		// Token: 0x060048E8 RID: 18664 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048E8")]
		[Address(RVA = "0x975B", Offset = "0x975B", VA = "0x975B")]
		private void BossServiceOnMinionAttackServerCancelationEvent(MinionAttackServerCancelationEvt evt)
		{
		}

		// Token: 0x040027EB RID: 10219
		[Token(Token = "0x40027EB")]
		[FieldOffset(Offset = "0x18")]
		private BossService _bossService;
	}
}
