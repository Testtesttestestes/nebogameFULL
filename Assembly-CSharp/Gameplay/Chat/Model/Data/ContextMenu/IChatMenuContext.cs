using System;
using Gameplay.Chat.Control;
using Gameplay.Chat.Model.Data.Message;
using Il2CppDummyDll;
using UI.UserContextMenu;

namespace Gameplay.Chat.Model.Data.ContextMenu
{
	// Token: 0x02000B1C RID: 2844
	[Token(Token = "0x2000B1C")]
	public interface IChatMenuContext : IUserMenuContext
	{
		// Token: 0x17000D9F RID: 3487
		// (get) Token: 0x060044BA RID: 17594
		// (set) Token: 0x060044BB RID: 17595
		[Token(Token = "0x17000D9F")]
		ChatVisitorData Visitor { [Token(Token = "0x60044BA")] get; [Token(Token = "0x60044BB")] set; }

		// Token: 0x17000DA0 RID: 3488
		// (get) Token: 0x060044BC RID: 17596
		// (set) Token: 0x060044BD RID: 17597
		[Token(Token = "0x17000DA0")]
		ChatMessageItem MessageItem { [Token(Token = "0x60044BC")] get; [Token(Token = "0x60044BD")] set; }

		// Token: 0x17000DA1 RID: 3489
		// (get) Token: 0x060044BE RID: 17598
		// (set) Token: 0x060044BF RID: 17599
		[Token(Token = "0x17000DA1")]
		ChatController Controller { [Token(Token = "0x60044BE")] get; [Token(Token = "0x60044BF")] set; }
	}
}
