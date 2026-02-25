using System;
using Il2CppDummyDll;
using Protocol.Dic;
using UI.UserContextMenu;
using UI.UserContextMenu.ContextElements;

namespace Gameplay.Chat.Model.Data.ContextMenu.Elements
{
	// Token: 0x02000B1F RID: 2847
	[Token(Token = "0x2000B1F")]
	public class ChatReport : AbstractUserContextMenuElement
	{
		// Token: 0x17000DA7 RID: 3495
		// (get) Token: 0x060044CD RID: 17613 RVA: 0x0000CF60 File Offset: 0x0000B160
		[Token(Token = "0x17000DA7")]
		public override UserMenuActionDic.Types.Actions ActionId
		{
			[Token(Token = "0x60044CD")]
			[Address(RVA = "0x9373", Offset = "0x9373", VA = "0x9373", Slot = "4")]
			get
			{
				return UserMenuActionDic.Types.Actions.UnknownAction;
			}
		}

		// Token: 0x060044CE RID: 17614 RVA: 0x0000CF78 File Offset: 0x0000B178
		[Token(Token = "0x60044CE")]
		[Address(RVA = "0x9374", Offset = "0x9374", VA = "0x9374", Slot = "5")]
		public override bool Validate(IUserMenuContext context)
		{
			return default(bool);
		}

		// Token: 0x060044CF RID: 17615 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044CF")]
		[Address(RVA = "0x9375", Offset = "0x9375", VA = "0x9375", Slot = "7")]
		public override void Handle(IUserMenuContext context)
		{
		}

		// Token: 0x060044D0 RID: 17616 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044D0")]
		[Address(RVA = "0x9376", Offset = "0x9376", VA = "0x9376")]
		public ChatReport()
		{
		}
	}
}
