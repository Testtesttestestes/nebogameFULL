using System;
using Il2CppDummyDll;
using Protocol.Dic;
using UI.UserContextMenu;
using UI.UserContextMenu.ContextElements;

namespace Gameplay.Chat.Model.Data.ContextMenu.Elements
{
	// Token: 0x02000B22 RID: 2850
	[Token(Token = "0x2000B22")]
	public class MessageToUser : AbstractUserContextMenuElement
	{
		// Token: 0x17000DA9 RID: 3497
		// (get) Token: 0x060044D8 RID: 17624 RVA: 0x0000CFC0 File Offset: 0x0000B1C0
		[Token(Token = "0x17000DA9")]
		public override UserMenuActionDic.Types.Actions ActionId
		{
			[Token(Token = "0x60044D8")]
			[Address(RVA = "0x937E", Offset = "0x937E", VA = "0x937E", Slot = "4")]
			get
			{
				return UserMenuActionDic.Types.Actions.UnknownAction;
			}
		}

		// Token: 0x060044D9 RID: 17625 RVA: 0x0000CFD8 File Offset: 0x0000B1D8
		[Token(Token = "0x60044D9")]
		[Address(RVA = "0x937F", Offset = "0x937F", VA = "0x937F", Slot = "5")]
		public override bool Validate(IUserMenuContext context)
		{
			return default(bool);
		}

		// Token: 0x060044DA RID: 17626 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044DA")]
		[Address(RVA = "0x9380", Offset = "0x9380", VA = "0x9380", Slot = "7")]
		public override void Handle(IUserMenuContext context)
		{
		}

		// Token: 0x060044DB RID: 17627 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044DB")]
		[Address(RVA = "0x9381", Offset = "0x9381", VA = "0x9381")]
		public MessageToUser()
		{
		}
	}
}
