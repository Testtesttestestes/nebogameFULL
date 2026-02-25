using System;
using Gameplay.Boss.Events;
using Gameplay.Boss.Model;
using Gameplay.Boss.View;
using Il2CppDummyDll;

namespace Gameplay.Boss.Controller
{
	// Token: 0x02000BB2 RID: 2994
	[Token(Token = "0x2000BB2")]
	public class BossRewardsViewMediator : AbstractBossWindowViewMediator<BossRewardsView>
	{
		// Token: 0x06004971 RID: 18801 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004971")]
		[Address(RVA = "0x97E3", Offset = "0x97E3", VA = "0x97E3")]
		public BossRewardsViewMediator(BossInstanceModel model, BossInstanceEvents events, BossInstanceController controller)
		{
		}

		// Token: 0x06004972 RID: 18802 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004972")]
		[Address(RVA = "0x97E4", Offset = "0x97E4", VA = "0x97E4", Slot = "21")]
		protected override void ResetEvents(BossInstanceEvents events)
		{
		}

		// Token: 0x06004973 RID: 18803 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004973")]
		[Address(RVA = "0x97E5", Offset = "0x97E5", VA = "0x97E5", Slot = "22")]
		protected override void SetupEvents(BossInstanceEvents events)
		{
		}

		// Token: 0x06004974 RID: 18804 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004974")]
		[Address(RVA = "0x97E6", Offset = "0x97E6", VA = "0x97E6", Slot = "23")]
		protected override void ResetView(BossRewardsView view)
		{
		}

		// Token: 0x06004975 RID: 18805 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004975")]
		[Address(RVA = "0x97E7", Offset = "0x97E7", VA = "0x97E7", Slot = "24")]
		protected override void SetupView(BossRewardsView view)
		{
		}

		// Token: 0x06004976 RID: 18806 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004976")]
		[Address(RVA = "0x97E8", Offset = "0x97E8", VA = "0x97E8")]
		private void ViewOnSelectedEvent(BossInfo.BossRewardRangeData data)
		{
		}
	}
}
