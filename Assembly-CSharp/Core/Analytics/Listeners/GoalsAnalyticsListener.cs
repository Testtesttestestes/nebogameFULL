using System;
using Core.Events.Scopes;
using Il2CppDummyDll;

namespace Core.Analytics.Listeners
{
	// Token: 0x020012D2 RID: 4818
	[Token(Token = "0x20012D2")]
	public class GoalsAnalyticsListener : AbstractAnalyticsListener
	{
		// Token: 0x17001736 RID: 5942
		// (get) Token: 0x0600728C RID: 29324 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001736")]
		protected override string Theme
		{
			[Token(Token = "0x600728C")]
			[Address(RVA = "0xBC95", Offset = "0xBC95", VA = "0xBC95", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600728D RID: 29325 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600728D")]
		[Address(RVA = "0xBC96", Offset = "0xBC96", VA = "0xBC96", Slot = "10")]
		public override void Init()
		{
		}

		// Token: 0x0600728E RID: 29326 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600728E")]
		[Address(RVA = "0xBC97", Offset = "0xBC97", VA = "0xBC97", Slot = "11")]
		protected override void Deinit()
		{
		}

		// Token: 0x0600728F RID: 29327 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600728F")]
		[Address(RVA = "0xBC98", Offset = "0xBC98", VA = "0xBC98")]
		private void RewardTakenEvent(GoalsScope.GoalEventArgs e)
		{
		}

		// Token: 0x06007290 RID: 29328 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007290")]
		[Address(RVA = "0xBC99", Offset = "0xBC99", VA = "0xBC99")]
		public GoalsAnalyticsListener()
		{
		}

		// Token: 0x04003C06 RID: 15366
		[Token(Token = "0x4003C06")]
		private const string REWARD_TAKEN = "reward_taken";
	}
}
