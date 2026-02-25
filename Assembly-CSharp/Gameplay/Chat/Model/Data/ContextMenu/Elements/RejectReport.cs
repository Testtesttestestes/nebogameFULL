using System;
using Il2CppDummyDll;
using Protocol.Dic;
using UI.UserContextMenu;
using UI.UserContextMenu.ContextElements;

namespace Gameplay.Chat.Model.Data.ContextMenu.Elements
{
	// Token: 0x02000B24 RID: 2852
	[Token(Token = "0x2000B24")]
	public class RejectReport : AbstractUserContextMenuElement
	{
		// Token: 0x17000DAB RID: 3499
		// (get) Token: 0x060044E0 RID: 17632 RVA: 0x0000D020 File Offset: 0x0000B220
		[Token(Token = "0x17000DAB")]
		public override UserMenuActionDic.Types.Actions ActionId
		{
			[Token(Token = "0x60044E0")]
			[Address(RVA = "0x9386", Offset = "0x9386", VA = "0x9386", Slot = "4")]
			get
			{
				return UserMenuActionDic.Types.Actions.UnknownAction;
			}
		}

		// Token: 0x060044E1 RID: 17633 RVA: 0x0000D038 File Offset: 0x0000B238
		[Token(Token = "0x60044E1")]
		[Address(RVA = "0x9387", Offset = "0x9387", VA = "0x9387", Slot = "5")]
		public override bool Validate(IUserMenuContext context)
		{
			return default(bool);
		}

		// Token: 0x060044E2 RID: 17634 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044E2")]
		[Address(RVA = "0x9388", Offset = "0x9388", VA = "0x9388", Slot = "7")]
		public override void Handle(IUserMenuContext context)
		{
		}

		// Token: 0x060044E3 RID: 17635 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044E3")]
		[Address(RVA = "0x9389", Offset = "0x9389", VA = "0x9389")]
		public RejectReport()
		{
		}
	}
}
