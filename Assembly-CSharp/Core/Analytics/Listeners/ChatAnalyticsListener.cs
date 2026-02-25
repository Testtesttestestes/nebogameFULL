using System;
using Core.Events.Scopes;
using Il2CppDummyDll;

namespace Core.Analytics.Listeners
{
	// Token: 0x020012C7 RID: 4807
	[Token(Token = "0x20012C7")]
	public class ChatAnalyticsListener : AbstractAnalyticsListener
	{
		// Token: 0x1700172B RID: 5931
		// (get) Token: 0x06007240 RID: 29248 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700172B")]
		protected override string Theme
		{
			[Token(Token = "0x6007240")]
			[Address(RVA = "0xBC49", Offset = "0xBC49", VA = "0xBC49", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x06007241 RID: 29249 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007241")]
		[Address(RVA = "0xBC4A", Offset = "0xBC4A", VA = "0xBC4A", Slot = "10")]
		public override void Init()
		{
		}

		// Token: 0x06007242 RID: 29250 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007242")]
		[Address(RVA = "0xBC4B", Offset = "0xBC4B", VA = "0xBC4B", Slot = "11")]
		protected override void Deinit()
		{
		}

		// Token: 0x06007243 RID: 29251 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007243")]
		[Address(RVA = "0xBC4C", Offset = "0xBC4C", VA = "0xBC4C")]
		private void SendMessageEvent(ChatScope.ChatEventArgs e)
		{
		}

		// Token: 0x06007244 RID: 29252 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007244")]
		[Address(RVA = "0xBC4D", Offset = "0xBC4D", VA = "0xBC4D")]
		public ChatAnalyticsListener()
		{
		}

		// Token: 0x04003BE0 RID: 15328
		[Token(Token = "0x4003BE0")]
		private const string SEND_MESSAGE = "send_message";
	}
}
