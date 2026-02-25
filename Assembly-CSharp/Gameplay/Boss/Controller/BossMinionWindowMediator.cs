using System;
using Gameplay.Boss.Events;
using Gameplay.Boss.Model;
using Gameplay.Boss.View;
using Gameplay.Combat.Model;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Boss.Controller
{
	// Token: 0x02000BAD RID: 2989
	[Token(Token = "0x2000BAD")]
	public class BossMinionWindowMediator : AbstractViewMediator<BossModel, BossEvents, BossController, BossMinionWindow>
	{
		// Token: 0x06004944 RID: 18756 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004944")]
		[Address(RVA = "0x97B6", Offset = "0x97B6", VA = "0x97B6")]
		public BossMinionWindowMediator(BossModel model, BossEvents events, BossController controller)
		{
		}

		// Token: 0x17000ED8 RID: 3800
		// (set) Token: 0x06004945 RID: 18757 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000ED8")]
		public override BossEvents Events
		{
			[Token(Token = "0x6004945")]
			[Address(RVA = "0x97B7", Offset = "0x97B7", VA = "0x97B7", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x17000ED9 RID: 3801
		// (set) Token: 0x06004946 RID: 18758 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000ED9")]
		public override BossMinionWindow View
		{
			[Token(Token = "0x6004946")]
			[Address(RVA = "0x97B8", Offset = "0x97B8", VA = "0x97B8", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06004947 RID: 18759 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004947")]
		[Address(RVA = "0x97B9", Offset = "0x97B9", VA = "0x97B9")]
		private void ResetView()
		{
		}

		// Token: 0x06004948 RID: 18760 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004948")]
		[Address(RVA = "0x97BA", Offset = "0x97BA", VA = "0x97BA")]
		private void SetupView()
		{
		}

		// Token: 0x06004949 RID: 18761 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004949")]
		[Address(RVA = "0x97BB", Offset = "0x97BB", VA = "0x97BB")]
		private void KickButtonClickHandler()
		{
		}

		// Token: 0x0600494A RID: 18762 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600494A")]
		[Address(RVA = "0x97BC", Offset = "0x97BC", VA = "0x97BC")]
		private void AttackButtonClickHandler()
		{
		}

		// Token: 0x0600494B RID: 18763 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600494B")]
		[Address(RVA = "0x97BD", Offset = "0x97BD", VA = "0x97BD")]
		private void MinionSuccessPayoffEvent()
		{
		}

		// Token: 0x0600494C RID: 18764 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600494C")]
		[Address(RVA = "0x97BE", Offset = "0x97BE", VA = "0x97BE")]
		private void BossManagerOnBossMinionCombatStartedEvent(CombatModel model)
		{
		}

		// Token: 0x0600494D RID: 18765 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600494D")]
		[Address(RVA = "0x97BF", Offset = "0x97BF", VA = "0x97BF")]
		private void MinionSuccessAttackEvent()
		{
		}

		// Token: 0x0600494E RID: 18766 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600494E")]
		[Address(RVA = "0x97C0", Offset = "0x97C0", VA = "0x97C0")]
		private void MinionCanceledEvent()
		{
		}
	}
}
