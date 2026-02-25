using System;
using System.Collections.Generic;
using Core.Events.Scopes;
using Il2CppDummyDll;

namespace Core.Analytics.Listeners
{
	// Token: 0x020012DC RID: 4828
	[Token(Token = "0x20012DC")]
	public class SchoolAnalyticsListener : AbstractAnalyticsListener
	{
		// Token: 0x17001740 RID: 5952
		// (get) Token: 0x060072DB RID: 29403 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001740")]
		protected override string Theme
		{
			[Token(Token = "0x60072DB")]
			[Address(RVA = "0xBCE4", Offset = "0xBCE4", VA = "0xBCE4", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x060072DC RID: 29404 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072DC")]
		[Address(RVA = "0xBCE5", Offset = "0xBCE5", VA = "0xBCE5", Slot = "10")]
		public override void Init()
		{
		}

		// Token: 0x060072DD RID: 29405 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072DD")]
		[Address(RVA = "0xBCE6", Offset = "0xBCE6", VA = "0xBCE6", Slot = "11")]
		protected override void Deinit()
		{
		}

		// Token: 0x060072DE RID: 29406 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072DE")]
		[Address(RVA = "0xBCE7", Offset = "0xBCE7", VA = "0xBCE7")]
		private void CancelLearnEvent(SchoolScope.SchoolEventArgs e)
		{
		}

		// Token: 0x060072DF RID: 29407 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072DF")]
		[Address(RVA = "0xBCE8", Offset = "0xBCE8", VA = "0xBCE8")]
		private void AccelerateLearnEvent(SchoolScope.SchoolEventArgs e)
		{
		}

		// Token: 0x060072E0 RID: 29408 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072E0")]
		[Address(RVA = "0xBCE9", Offset = "0xBCE9", VA = "0xBCE9")]
		private void StartLearnEvent(SchoolScope.SchoolEventArgs e)
		{
		}

		// Token: 0x060072E1 RID: 29409 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072E1")]
		[Address(RVA = "0xBCEA", Offset = "0xBCEA", VA = "0xBCEA")]
		private void AppendSpellProperties(Dictionary<string, object> properties, SchoolScope.SchoolEventArgs e)
		{
		}

		// Token: 0x060072E2 RID: 29410 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072E2")]
		[Address(RVA = "0xBCEB", Offset = "0xBCEB", VA = "0xBCEB")]
		public SchoolAnalyticsListener()
		{
		}

		// Token: 0x04003C28 RID: 15400
		[Token(Token = "0x4003C28")]
		private const string START_LEARN = "start_learn";

		// Token: 0x04003C29 RID: 15401
		[Token(Token = "0x4003C29")]
		private const string CANCEL_LEARN = "cancel_learn";

		// Token: 0x04003C2A RID: 15402
		[Token(Token = "0x4003C2A")]
		private const string ACCELERATE_LEARN = "accelerate_learn";
	}
}
