using System;
using Il2CppDummyDll;

namespace Gameplay.Chat.Model.Data.Message.Format
{
	// Token: 0x02000B1B RID: 2843
	[Token(Token = "0x2000B1B")]
	public interface IChatMsgPresenter
	{
		// Token: 0x060044B9 RID: 17593
		[Token(Token = "0x60044B9")]
		string GetText(ChatUserMessageData message, MessageDrawTarget messageDrawTarget);
	}
}
