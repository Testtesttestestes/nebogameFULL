using System;
using System.Collections.Generic;
using Gameplay.Combat.Control;
using Gameplay.Combat.Model;
using Gameplay.VortexCombat.Model;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Il2CppDummyDll;
using Protocol.Combat;
using Protocol.Partycombat;
using ServicesNamespace;
using Utils;

namespace Gameplay.VortexCombat.Control
{
	// Token: 0x020003B8 RID: 952
	[Token(Token = "0x20003B8")]
	public class VortexCombatController : CombatController<VortexCombatModel, VortexCombatEvents>
	{
		// Token: 0x170003B9 RID: 953
		// (get) Token: 0x06001642 RID: 5698 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170003B9")]
		public PartyCombatService PartyCombatService
		{
			[Token(Token = "0x6001642")]
			[Address(RVA = "0x6803", Offset = "0x6803", VA = "0x6803")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001643 RID: 5699 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001643")]
		[Address(RVA = "0x6804", Offset = "0x6804", VA = "0x6804")]
		public VortexCombatController(ICombatService service, VortexCombatModel model, VortexCombatEvents events)
		{
		}

		// Token: 0x06001644 RID: 5700 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001644")]
		[Address(RVA = "0x6805", Offset = "0x6805", VA = "0x6805", Slot = "7")]
		protected override void HandleRun()
		{
		}

		// Token: 0x06001645 RID: 5701 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001645")]
		[Address(RVA = "0x6806", Offset = "0x6806", VA = "0x6806", Slot = "12")]
		protected override List<CombatSpellData> HandleCoolDowns(RepeatedField<SpellCoolDown> items)
		{
			return null;
		}

		// Token: 0x06001646 RID: 5702 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001646")]
		[Address(RVA = "0x6807", Offset = "0x6807", VA = "0x6807", Slot = "15")]
		protected override void AddCombatServiceEventsHandlers()
		{
		}

		// Token: 0x06001647 RID: 5703 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001647")]
		[Address(RVA = "0x6808", Offset = "0x6808", VA = "0x6808", Slot = "16")]
		protected override void RemoveCombatServiceEventsHandlers()
		{
		}

		// Token: 0x06001648 RID: 5704 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001648")]
		[Address(RVA = "0x6809", Offset = "0x6809", VA = "0x6809", Slot = "25")]
		public override void NotifyShowViewProcessComplete()
		{
		}

		// Token: 0x06001649 RID: 5705 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001649")]
		[Address(RVA = "0x680A", Offset = "0x680A", VA = "0x680A")]
		private void HandleSkillsChangedServiceEvent(Protocol.Partycombat.ProtoSkillsChangedEvt msg)
		{
		}

		// Token: 0x0600164A RID: 5706 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600164A")]
		[Address(RVA = "0x680B", Offset = "0x680B", VA = "0x680B")]
		private void HandleFieldChangedServiceEvent(Protocol.Partycombat.ProtoFieldChangedEvt msg)
		{
		}

		// Token: 0x0600164B RID: 5707 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600164B")]
		[Address(RVA = "0x680C", Offset = "0x680C", VA = "0x680C")]
		private void HandleCombatCompleteServiceEvent(Protocol.Partycombat.ProtoCombatCompleteEvt msg)
		{
		}

		// Token: 0x0600164C RID: 5708 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600164C")]
		[Address(RVA = "0x680D", Offset = "0x680D", VA = "0x680D")]
		private void HandleSwitchTurnEvent(ProtoSwitchTurnEvt msg)
		{
		}

		// Token: 0x0600164D RID: 5709 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600164D")]
		[Address(RVA = "0x680E", Offset = "0x680E", VA = "0x680E", Slot = "21")]
		protected override void HandleShowHintServiceEvent(ProtoShowHintEvt msg)
		{
		}

		// Token: 0x0600164E RID: 5710 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600164E")]
		[Address(RVA = "0x680F", Offset = "0x680F", VA = "0x680F")]
		private void HandlePutJoinRequestService(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x0600164F RID: 5711 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600164F")]
		[Address(RVA = "0x6810", Offset = "0x6810", VA = "0x6810")]
		private void HandleJoinToCombatService(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06001650 RID: 5712 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001650")]
		[Address(RVA = "0x6811", Offset = "0x6811", VA = "0x6811", Slot = "18")]
		protected override void HandleJoinToCombatInfoChanged()
		{
		}
	}
}
