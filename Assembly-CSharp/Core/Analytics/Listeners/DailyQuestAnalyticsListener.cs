using System;
using Core.Events.Scopes;
using Il2CppDummyDll;

namespace Core.Analytics.Listeners
{
	// Token: 0x020012CD RID: 4813
	[Token(Token = "0x20012CD")]
	public class DailyQuestAnalyticsListener : AbstractAnalyticsListener
	{
		// Token: 0x17001730 RID: 5936
		// (get) Token: 0x0600726E RID: 29294 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001730")]
		protected override string Theme
		{
			[Token(Token = "0x600726E")]
			[Address(RVA = "0xBC77", Offset = "0xBC77", VA = "0xBC77", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600726F RID: 29295 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600726F")]
		[Address(RVA = "0xBC78", Offset = "0xBC78", VA = "0xBC78", Slot = "10")]
		public override void Init()
		{
		}

		// Token: 0x06007270 RID: 29296 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007270")]
		[Address(RVA = "0xBC79", Offset = "0xBC79", VA = "0xBC79", Slot = "11")]
		protected override void Deinit()
		{
		}

		// Token: 0x06007271 RID: 29297 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007271")]
		[Address(RVA = "0xBC7A", Offset = "0xBC7A", VA = "0xBC7A")]
		private void RewardTakenEvent(DailyQuestScope.DailyQuestEventArgs e)
		{
		}

		// Token: 0x06007272 RID: 29298 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007272")]
		[Address(RVA = "0xBC7B", Offset = "0xBC7B", VA = "0xBC7B")]
		public DailyQuestAnalyticsListener()
		{
		}

		// Token: 0x04003BFD RID: 15357
		[Token(Token = "0x4003BFD")]
		private const string REWARD_TAKEN = "reward_taken";
	}
}
