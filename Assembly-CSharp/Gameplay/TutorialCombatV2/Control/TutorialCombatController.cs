using System;
using System.Collections;
using Gameplay.Combat.Control;
using Gameplay.Combat.Model;
using Gameplay.TutorialCombatV2.Model;
using Il2CppDummyDll;
using ServicesNamespace;
using UnityEngine;

namespace Gameplay.TutorialCombatV2.Control
{
	// Token: 0x02000452 RID: 1106
	[Token(Token = "0x2000452")]
	public class TutorialCombatController : CombatController<TutorialCombatModel, TutorialCombatEvents>
	{
		// Token: 0x06001A33 RID: 6707 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A33")]
		[Address(RVA = "0x6BCA", Offset = "0x6BCA", VA = "0x6BCA", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x06001A34 RID: 6708 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A34")]
		[Address(RVA = "0x6BCB", Offset = "0x6BCB", VA = "0x6BCB")]
		public TutorialCombatController(ICombatService service, TutorialCombatModel model, TutorialCombatEvents events)
		{
		}

		// Token: 0x06001A35 RID: 6709 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A35")]
		[Address(RVA = "0x6BCC", Offset = "0x6BCC", VA = "0x6BCC", Slot = "7")]
		protected override void HandleRun()
		{
		}

		// Token: 0x06001A36 RID: 6710 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A36")]
		[Address(RVA = "0x6BCD", Offset = "0x6BCD", VA = "0x6BCD", Slot = "14")]
		protected override void HandleSetDrop(GameOverData data)
		{
		}

		// Token: 0x06001A37 RID: 6711 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A37")]
		[Address(RVA = "0x6BCE", Offset = "0x6BCE", VA = "0x6BCE", Slot = "13")]
		protected override void HandleRewardsGot()
		{
		}

		// Token: 0x06001A38 RID: 6712 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A38")]
		[Address(RVA = "0x6BCF", Offset = "0x6BCF", VA = "0x6BCF")]
		public void RunComplete()
		{
		}

		// Token: 0x06001A39 RID: 6713 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001A39")]
		[Address(RVA = "0x6BD0", Offset = "0x6BD0", VA = "0x6BD0")]
		private IEnumerator CombatCompleteCoroutine(float delay)
		{
			return null;
		}

		// Token: 0x04000E19 RID: 3609
		[Token(Token = "0x4000E19")]
		public const float COMBAT_COMPLETE_DELAY = 2.5f;

		// Token: 0x04000E1A RID: 3610
		[Token(Token = "0x4000E1A")]
		[FieldOffset(Offset = "0x20")]
		private Coroutine _runCompleteCoroutine;
	}
}
