using System;
using Core.Events.Scopes;
using Il2CppDummyDll;

namespace Core.Analytics.Listeners
{
	// Token: 0x020012D6 RID: 4822
	[Token(Token = "0x20012D6")]
	public class ManufactureAssistAnalyticsListener : AbstractAnalyticsListener
	{
		// Token: 0x1700173A RID: 5946
		// (get) Token: 0x060072A6 RID: 29350 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700173A")]
		protected override string Theme
		{
			[Token(Token = "0x60072A6")]
			[Address(RVA = "0xBCAF", Offset = "0xBCAF", VA = "0xBCAF", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x060072A7 RID: 29351 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072A7")]
		[Address(RVA = "0xBCB0", Offset = "0xBCB0", VA = "0xBCB0", Slot = "10")]
		public override void Init()
		{
		}

		// Token: 0x060072A8 RID: 29352 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072A8")]
		[Address(RVA = "0xBCB1", Offset = "0xBCB1", VA = "0xBCB1", Slot = "11")]
		protected override void Deinit()
		{
		}

		// Token: 0x060072A9 RID: 29353 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072A9")]
		[Address(RVA = "0xBCB2", Offset = "0xBCB2", VA = "0xBCB2")]
		private void DismantleStartEvent(ManufactureAssistScope.ManufactureAssistEventArgs e)
		{
		}

		// Token: 0x060072AA RID: 29354 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072AA")]
		[Address(RVA = "0xBCB3", Offset = "0xBCB3", VA = "0xBCB3")]
		public ManufactureAssistAnalyticsListener()
		{
		}

		// Token: 0x04003C10 RID: 15376
		[Token(Token = "0x4003C10")]
		private const string START_DISMANTLE = "start_dismantle";
	}
}
