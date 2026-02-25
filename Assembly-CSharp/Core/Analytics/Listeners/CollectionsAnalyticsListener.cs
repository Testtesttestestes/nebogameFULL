using System;
using Core.Events.Scopes;
using Il2CppDummyDll;

namespace Core.Analytics.Listeners
{
	// Token: 0x020012CA RID: 4810
	[Token(Token = "0x20012CA")]
	public class CollectionsAnalyticsListener : AbstractAnalyticsListener
	{
		// Token: 0x1700172D RID: 5933
		// (get) Token: 0x0600725B RID: 29275 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700172D")]
		protected override string Theme
		{
			[Token(Token = "0x600725B")]
			[Address(RVA = "0xBC64", Offset = "0xBC64", VA = "0xBC64", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600725C RID: 29276 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600725C")]
		[Address(RVA = "0xBC65", Offset = "0xBC65", VA = "0xBC65", Slot = "10")]
		public override void Init()
		{
		}

		// Token: 0x0600725D RID: 29277 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600725D")]
		[Address(RVA = "0xBC66", Offset = "0xBC66", VA = "0xBC66", Slot = "11")]
		protected override void Deinit()
		{
		}

		// Token: 0x0600725E RID: 29278 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600725E")]
		[Address(RVA = "0xBC67", Offset = "0xBC67", VA = "0xBC67")]
		private void CollectionImprovedEvent(CollectionsScope.CollectionsEventArgs e)
		{
		}

		// Token: 0x0600725F RID: 29279 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600725F")]
		[Address(RVA = "0xBC68", Offset = "0xBC68", VA = "0xBC68")]
		public CollectionsAnalyticsListener()
		{
		}

		// Token: 0x04003BF6 RID: 15350
		[Token(Token = "0x4003BF6")]
		private const string COLLECTION_IMPROVED = "collection_improved";
	}
}
