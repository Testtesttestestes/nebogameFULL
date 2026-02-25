using System;
using System.Collections.Generic;
using Gameplay.Boss.Events;
using Gameplay.Boss.Model;
using Gameplay.Boss.View.RatingTab;
using Il2CppDummyDll;

namespace Gameplay.Boss.Controller
{
	// Token: 0x02000BAE RID: 2990
	[Token(Token = "0x2000BAE")]
	public class BossRatingViewMediator : AbstractBossWindowViewMediator<BossRatingView>
	{
		// Token: 0x0600494F RID: 18767 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600494F")]
		[Address(RVA = "0x97C1", Offset = "0x97C1", VA = "0x97C1")]
		public BossRatingViewMediator(BossInstanceModel model, BossInstanceEvents events, BossInstanceController controller)
		{
		}

		// Token: 0x06004950 RID: 18768 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004950")]
		[Address(RVA = "0x97C2", Offset = "0x97C2", VA = "0x97C2", Slot = "21")]
		protected override void ResetEvents(BossInstanceEvents events)
		{
		}

		// Token: 0x06004951 RID: 18769 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004951")]
		[Address(RVA = "0x97C3", Offset = "0x97C3", VA = "0x97C3", Slot = "22")]
		protected override void SetupEvents(BossInstanceEvents events)
		{
		}

		// Token: 0x06004952 RID: 18770 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004952")]
		[Address(RVA = "0x97C4", Offset = "0x97C4", VA = "0x97C4", Slot = "23")]
		protected override void ResetView(BossRatingView view)
		{
		}

		// Token: 0x06004953 RID: 18771 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004953")]
		[Address(RVA = "0x97C5", Offset = "0x97C5", VA = "0x97C5", Slot = "24")]
		protected override void SetupView(BossRatingView view)
		{
		}

		// Token: 0x06004954 RID: 18772 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004954")]
		[Address(RVA = "0x97C6", Offset = "0x97C6", VA = "0x97C6")]
		private void RatingReceivedEvent(List<BossCaptainRatingData> captainRatings)
		{
		}

		// Token: 0x06004955 RID: 18773 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004955")]
		[Address(RVA = "0x97C7", Offset = "0x97C7", VA = "0x97C7")]
		private void RenderRatingList()
		{
		}

		// Token: 0x06004956 RID: 18774 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004956")]
		[Address(RVA = "0x97C8", Offset = "0x97C8", VA = "0x97C8")]
		private void GreenToggleOnChangedEvent()
		{
		}

		// Token: 0x06004957 RID: 18775 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004957")]
		[Address(RVA = "0x97C9", Offset = "0x97C9", VA = "0x97C9")]
		private void ListAdapterOnClickEvent(BossCaptainRatingData data)
		{
		}

		// Token: 0x040027F7 RID: 10231
		[Token(Token = "0x40027F7")]
		[FieldOffset(Offset = "0x18")]
		private List<BossCaptainRatingData> _currentRatings;
	}
}
