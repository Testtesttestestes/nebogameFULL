using System;
using System.Collections.Generic;
using Core.Events.Scopes;
using Il2CppDummyDll;

namespace Core.Analytics.Listeners.DebugListeners
{
	// Token: 0x020012E8 RID: 4840
	[Token(Token = "0x20012E8")]
	public class Debug107447AnalyticsListener : AbstractAnalyticsListener
	{
		// Token: 0x17001749 RID: 5961
		// (get) Token: 0x0600733F RID: 29503 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001749")]
		protected override string Theme
		{
			[Token(Token = "0x600733F")]
			[Address(RVA = "0xBD48", Offset = "0xBD48", VA = "0xBD48", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700174A RID: 5962
		// (get) Token: 0x06007340 RID: 29504 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700174A")]
		private string TASK_EVENT_NAME
		{
			[Token(Token = "0x6007340")]
			[Address(RVA = "0xBD49", Offset = "0xBD49", VA = "0xBD49")]
			get
			{
				return null;
			}
		}

		// Token: 0x06007341 RID: 29505 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007341")]
		[Address(RVA = "0xBD4A", Offset = "0xBD4A", VA = "0xBD4A", Slot = "10")]
		public override void Init()
		{
		}

		// Token: 0x06007342 RID: 29506 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007342")]
		[Address(RVA = "0xBD4B", Offset = "0xBD4B", VA = "0xBD4B", Slot = "11")]
		protected override void Deinit()
		{
		}

		// Token: 0x06007343 RID: 29507 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007343")]
		[Address(RVA = "0xBD4C", Offset = "0xBD4C", VA = "0xBD4C")]
		private void PaymentBonusReceivedEvent(BankScope.PaymentBonusEventArgs e)
		{
		}

		// Token: 0x06007344 RID: 29508 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007344")]
		[Address(RVA = "0xBD4D", Offset = "0xBD4D", VA = "0xBD4D")]
		public Debug107447AnalyticsListener()
		{
		}

		// Token: 0x04003C56 RID: 15446
		[Token(Token = "0x4003C56")]
		private const string TASK_ID = "107447";

		// Token: 0x04003C57 RID: 15447
		[Token(Token = "0x4003C57")]
		[FieldOffset(Offset = "0x10")]
		private List<uint> _bonusIds;
	}
}
