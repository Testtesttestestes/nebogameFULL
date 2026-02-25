using System;
using Gameplay.Boss.Events;
using Gameplay.Boss.Model;
using Gameplay.Boss.View.GuestTab;
using Il2CppDummyDll;

namespace Gameplay.Boss.Controller
{
	// Token: 0x02000BA5 RID: 2981
	[Token(Token = "0x2000BA5")]
	public class BossGuestViewMediator : AbstractBossWindowViewMediator<BossGuestView>
	{
		// Token: 0x060048E9 RID: 18665 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048E9")]
		[Address(RVA = "0x975C", Offset = "0x975C", VA = "0x975C")]
		public BossGuestViewMediator(BossInstanceModel model, BossInstanceEvents events, BossInstanceController controller)
		{
		}

		// Token: 0x060048EA RID: 18666 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048EA")]
		[Address(RVA = "0x975D", Offset = "0x975D", VA = "0x975D", Slot = "21")]
		protected override void ResetEvents(BossInstanceEvents events)
		{
		}

		// Token: 0x060048EB RID: 18667 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048EB")]
		[Address(RVA = "0x975E", Offset = "0x975E", VA = "0x975E", Slot = "22")]
		protected override void SetupEvents(BossInstanceEvents events)
		{
		}

		// Token: 0x060048EC RID: 18668 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048EC")]
		[Address(RVA = "0x975F", Offset = "0x975F", VA = "0x975F", Slot = "23")]
		protected override void ResetView(BossGuestView view)
		{
		}

		// Token: 0x060048ED RID: 18669 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048ED")]
		[Address(RVA = "0x9760", Offset = "0x9760", VA = "0x9760", Slot = "24")]
		protected override void SetupView(BossGuestView view)
		{
		}

		// Token: 0x060048EE RID: 18670 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048EE")]
		[Address(RVA = "0x9761", Offset = "0x9761", VA = "0x9761")]
		private void SkillInfoButtonClickHandler()
		{
		}

		// Token: 0x060048EF RID: 18671 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048EF")]
		[Address(RVA = "0x9762", Offset = "0x9762", VA = "0x9762")]
		private void HealthChangedEvent()
		{
		}
	}
}
