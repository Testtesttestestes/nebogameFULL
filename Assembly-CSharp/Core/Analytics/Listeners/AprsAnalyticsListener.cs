using System;
using System.Collections.Generic;
using Core.Events.Scopes;
using Gameplay.Aprs.Model;
using Il2CppDummyDll;

namespace Core.Analytics.Listeners
{
	// Token: 0x020012C0 RID: 4800
	[Token(Token = "0x20012C0")]
	public class AprsAnalyticsListener : AbstractAnalyticsListener
	{
		// Token: 0x17001724 RID: 5924
		// (get) Token: 0x060071FC RID: 29180 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001724")]
		protected override string Theme
		{
			[Token(Token = "0x60071FC")]
			[Address(RVA = "0xBC05", Offset = "0xBC05", VA = "0xBC05", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x060071FD RID: 29181 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60071FD")]
		[Address(RVA = "0xBC06", Offset = "0xBC06", VA = "0xBC06", Slot = "10")]
		public override void Init()
		{
		}

		// Token: 0x060071FE RID: 29182 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60071FE")]
		[Address(RVA = "0xBC07", Offset = "0xBC07", VA = "0xBC07", Slot = "11")]
		protected override void Deinit()
		{
		}

		// Token: 0x060071FF RID: 29183 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60071FF")]
		[Address(RVA = "0xBC08", Offset = "0xBC08", VA = "0xBC08")]
		private void NewAprEvent(AprsScope.AprsEventArgs e)
		{
		}

		// Token: 0x06007200 RID: 29184 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007200")]
		[Address(RVA = "0xBC09", Offset = "0xBC09", VA = "0xBC09")]
		private void BuyAprEvent(AprsScope.AprsEventArgs e)
		{
		}

		// Token: 0x06007201 RID: 29185 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007201")]
		[Address(RVA = "0xBC0A", Offset = "0xBC0A", VA = "0xBC0A")]
		private void AppendAprProperties(Dictionary<string, object> properties, AprData aprData, bool includePrice)
		{
		}

		// Token: 0x06007202 RID: 29186 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007202")]
		[Address(RVA = "0xBC0B", Offset = "0xBC0B", VA = "0xBC0B")]
		public AprsAnalyticsListener()
		{
		}

		// Token: 0x04003BBD RID: 15293
		[Token(Token = "0x4003BBD")]
		private const string BUY_APR = "buy_apr";

		// Token: 0x04003BBE RID: 15294
		[Token(Token = "0x4003BBE")]
		private const string NEW_APR = "new_apr";
	}
}
