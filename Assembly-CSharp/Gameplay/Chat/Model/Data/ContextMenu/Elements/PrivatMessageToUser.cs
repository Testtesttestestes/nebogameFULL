using System;
using Il2CppDummyDll;
using Protocol.Dic;
using UI.UserContextMenu;
using UI.UserContextMenu.ContextElements;

namespace Gameplay.Chat.Model.Data.ContextMenu.Elements
{
	// Token: 0x02000B23 RID: 2851
	[Token(Token = "0x2000B23")]
	public class PrivatMessageToUser : AbstractUserContextMenuElement
	{
		// Token: 0x17000DAA RID: 3498
		// (get) Token: 0x060044DC RID: 17628 RVA: 0x0000CFF0 File Offset: 0x0000B1F0
		[Token(Token = "0x17000DAA")]
		public override UserMenuActionDic.Types.Actions ActionId
		{
			[Token(Token = "0x60044DC")]
			[Address(RVA = "0x9382", Offset = "0x9382", VA = "0x9382", Slot = "4")]
			get
			{
				return UserMenuActionDic.Types.Actions.UnknownAction;
			}
		}

		// Token: 0x060044DD RID: 17629 RVA: 0x0000D008 File Offset: 0x0000B208
		[Token(Token = "0x60044DD")]
		[Address(RVA = "0x9383", Offset = "0x9383", VA = "0x9383", Slot = "5")]
		public override bool Validate(IUserMenuContext context)
		{
			return default(bool);
		}

		// Token: 0x060044DE RID: 17630 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044DE")]
		[Address(RVA = "0x9384", Offset = "0x9384", VA = "0x9384", Slot = "7")]
		public override void Handle(IUserMenuContext context)
		{
		}

		// Token: 0x060044DF RID: 17631 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044DF")]
		[Address(RVA = "0x9385", Offset = "0x9385", VA = "0x9385")]
		public PrivatMessageToUser()
		{
		}
	}
}
