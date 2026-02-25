using System;
using System.Threading;
using Gameplay.Boss.Events;
using Gameplay.Boss.Model;
using Gameplay.Boss.View.CaptainTab;
using Il2CppDummyDll;

namespace Gameplay.Boss.Controller
{
	// Token: 0x02000BA2 RID: 2978
	[Token(Token = "0x2000BA2")]
	public class BossCaptainViewMediator : AbstractBossWindowViewMediator<BossCaptainView>
	{
		// Token: 0x060048C2 RID: 18626 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048C2")]
		[Address(RVA = "0x973A", Offset = "0x973A", VA = "0x973A", Slot = "14")]
		public override void Dispose()
		{
		}

		// Token: 0x060048C3 RID: 18627 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048C3")]
		[Address(RVA = "0x973B", Offset = "0x973B", VA = "0x973B")]
		public BossCaptainViewMediator(BossInstanceModel model, BossInstanceEvents events, BossInstanceController controller)
		{
		}

		// Token: 0x060048C4 RID: 18628 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048C4")]
		[Address(RVA = "0x1B5F", Offset = "0x1B5F", VA = "0x1B5F")]
		private void HealthChangedEvent()
		{
		}

		// Token: 0x060048C5 RID: 18629 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048C5")]
		[Address(RVA = "0x973C", Offset = "0x973C", VA = "0x973C")]
		private void TeamInfoChangedEvent()
		{
		}

		// Token: 0x060048C6 RID: 18630 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048C6")]
		[Address(RVA = "0x973D", Offset = "0x973D", VA = "0x973D", Slot = "21")]
		protected override void ResetEvents(BossInstanceEvents events)
		{
		}

		// Token: 0x060048C7 RID: 18631 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048C7")]
		[Address(RVA = "0x973E", Offset = "0x973E", VA = "0x973E", Slot = "22")]
		protected override void SetupEvents(BossInstanceEvents events)
		{
		}

		// Token: 0x060048C8 RID: 18632 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048C8")]
		[Address(RVA = "0x973F", Offset = "0x973F", VA = "0x973F", Slot = "23")]
		protected override void ResetView(BossCaptainView view)
		{
		}

		// Token: 0x060048C9 RID: 18633 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048C9")]
		[Address(RVA = "0x9740", Offset = "0x9740", VA = "0x9740", Slot = "24")]
		protected override void SetupView(BossCaptainView view)
		{
		}

		// Token: 0x060048CA RID: 18634 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048CA")]
		[Address(RVA = "0x1B60", Offset = "0x1B60", VA = "0x1B60")]
		private void TrySelectLastSavedOptionAndVariant()
		{
		}

		// Token: 0x060048CB RID: 18635 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048CB")]
		[Address(RVA = "0x9741", Offset = "0x9741", VA = "0x9741")]
		private void BossInfoViewOnAttackButtonClickEvent(BossInfo.BossAttackOption attackOption, BossInfo.BossAttackOption.BossAttackOptionVariant variant)
		{
		}

		// Token: 0x060048CC RID: 18636 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048CC")]
		[Address(RVA = "0x9742", Offset = "0x9742", VA = "0x9742")]
		private void SkillInfoButtonClickHandler()
		{
		}

		// Token: 0x060048CD RID: 18637 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048CD")]
		[Address(RVA = "0x9743", Offset = "0x9743", VA = "0x9743")]
		private void TeamEditViewOnExitEditModeEvent()
		{
		}

		// Token: 0x060048CE RID: 18638 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048CE")]
		[Address(RVA = "0x9744", Offset = "0x9744", VA = "0x9744")]
		private void TeamViewOnAssistantClickedEvent(TeamData.TeamAssistantData assistantData)
		{
		}

		// Token: 0x040027E5 RID: 10213
		[Token(Token = "0x40027E5")]
		[FieldOffset(Offset = "0x18")]
		private readonly CancellationTokenSource _cancellationTokenSource;
	}
}
