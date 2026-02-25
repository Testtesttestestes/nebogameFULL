using System;
using Core.Events.Scopes;
using Il2CppDummyDll;

namespace Core.Analytics.Listeners
{
	// Token: 0x020012D3 RID: 4819
	[Token(Token = "0x20012D3")]
	public class GuideAnalyticsListener : AbstractAnalyticsListener
	{
		// Token: 0x17001737 RID: 5943
		// (get) Token: 0x06007291 RID: 29329 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001737")]
		protected override string Theme
		{
			[Token(Token = "0x6007291")]
			[Address(RVA = "0xBC9A", Offset = "0xBC9A", VA = "0xBC9A", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x06007292 RID: 29330 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007292")]
		[Address(RVA = "0xBC9B", Offset = "0xBC9B", VA = "0xBC9B", Slot = "10")]
		public override void Init()
		{
		}

		// Token: 0x06007293 RID: 29331 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007293")]
		[Address(RVA = "0xBC9C", Offset = "0xBC9C", VA = "0xBC9C", Slot = "11")]
		protected override void Deinit()
		{
		}

		// Token: 0x06007294 RID: 29332 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007294")]
		[Address(RVA = "0xBC9D", Offset = "0xBC9D", VA = "0xBC9D")]
		private void GuideStepCompleteEvent(GuideScope.GuideEventArgs e)
		{
		}

		// Token: 0x06007295 RID: 29333 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007295")]
		[Address(RVA = "0xBC9E", Offset = "0xBC9E", VA = "0xBC9E")]
		public GuideAnalyticsListener()
		{
		}

		// Token: 0x04003C07 RID: 15367
		[Token(Token = "0x4003C07")]
		private const string STEP_COMPLETE = "step_complete";
	}
}
