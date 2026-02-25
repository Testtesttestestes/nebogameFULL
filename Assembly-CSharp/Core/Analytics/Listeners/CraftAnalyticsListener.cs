using System;
using Core.Events.Scopes;
using Il2CppDummyDll;

namespace Core.Analytics.Listeners
{
	// Token: 0x020012CC RID: 4812
	[Token(Token = "0x20012CC")]
	public class CraftAnalyticsListener : AbstractAnalyticsListener
	{
		// Token: 0x1700172F RID: 5935
		// (get) Token: 0x06007269 RID: 29289 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700172F")]
		protected override string Theme
		{
			[Token(Token = "0x6007269")]
			[Address(RVA = "0xBC72", Offset = "0xBC72", VA = "0xBC72", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600726A RID: 29290 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600726A")]
		[Address(RVA = "0xBC73", Offset = "0xBC73", VA = "0xBC73", Slot = "10")]
		public override void Init()
		{
		}

		// Token: 0x0600726B RID: 29291 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600726B")]
		[Address(RVA = "0xBC74", Offset = "0xBC74", VA = "0xBC74", Slot = "11")]
		protected override void Deinit()
		{
		}

		// Token: 0x0600726C RID: 29292 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600726C")]
		[Address(RVA = "0xBC75", Offset = "0xBC75", VA = "0xBC75")]
		private void StartCraftEvent(CraftScope.CraftEventArgs e)
		{
		}

		// Token: 0x0600726D RID: 29293 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600726D")]
		[Address(RVA = "0xBC76", Offset = "0xBC76", VA = "0xBC76")]
		public CraftAnalyticsListener()
		{
		}

		// Token: 0x04003BFC RID: 15356
		[Token(Token = "0x4003BFC")]
		private const string START = "start";
	}
}
