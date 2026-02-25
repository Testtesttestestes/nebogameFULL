using System;
using System.Collections.Generic;
using Core.Data;
using Core.Events.Scopes;
using Il2CppDummyDll;

namespace Core.Analytics.Listeners
{
	// Token: 0x020012D7 RID: 4823
	[Token(Token = "0x20012D7")]
	public class MedalsAnalyticsListener : AbstractAnalyticsListener
	{
		// Token: 0x1700173B RID: 5947
		// (get) Token: 0x060072AB RID: 29355 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700173B")]
		protected override string Theme
		{
			[Token(Token = "0x60072AB")]
			[Address(RVA = "0xBCB4", Offset = "0xBCB4", VA = "0xBCB4", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x060072AC RID: 29356 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072AC")]
		[Address(RVA = "0xBCB5", Offset = "0xBCB5", VA = "0xBCB5", Slot = "10")]
		public override void Init()
		{
		}

		// Token: 0x060072AD RID: 29357 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072AD")]
		[Address(RVA = "0xBCB6", Offset = "0xBCB6", VA = "0xBCB6", Slot = "11")]
		protected override void Deinit()
		{
		}

		// Token: 0x060072AE RID: 29358 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072AE")]
		[Address(RVA = "0xBCB7", Offset = "0xBCB7", VA = "0xBCB7")]
		private void BuyMedalEvent(MedalsScope.MedalEventArgs e)
		{
		}

		// Token: 0x060072AF RID: 29359 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072AF")]
		[Address(RVA = "0xBCB8", Offset = "0xBCB8", VA = "0xBCB8")]
		private void NewMedalEvent(MedalsScope.MedalEventArgs e)
		{
		}

		// Token: 0x060072B0 RID: 29360 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072B0")]
		[Address(RVA = "0xBCB9", Offset = "0xBCB9", VA = "0xBCB9")]
		private void AppendMedalProperties(Dictionary<string, object> properties, MedalData medalData, uint medalId, bool includePrice)
		{
		}

		// Token: 0x060072B1 RID: 29361 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072B1")]
		[Address(RVA = "0xBCBA", Offset = "0xBCBA", VA = "0xBCBA")]
		public MedalsAnalyticsListener()
		{
		}

		// Token: 0x04003C11 RID: 15377
		[Token(Token = "0x4003C11")]
		private const string BUY_MEDAL = "buy_medal";

		// Token: 0x04003C12 RID: 15378
		[Token(Token = "0x4003C12")]
		private const string NEW_MEDAL = "new_medal";
	}
}
