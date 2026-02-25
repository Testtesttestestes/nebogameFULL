using System;
using Il2CppDummyDll;
using Protocol.Dic;
using UI.UserContextMenu;
using UI.UserContextMenu.ContextElements;

namespace Gameplay.Chat.Model.Data.ContextMenu.Elements
{
	// Token: 0x02000B1E RID: 2846
	[Token(Token = "0x2000B1E")]
	public class AddToFavoriteContextMenuElement : AbstractUserContextMenuElement
	{
		// Token: 0x17000DA6 RID: 3494
		// (get) Token: 0x060044C9 RID: 17609 RVA: 0x0000CF30 File Offset: 0x0000B130
		[Token(Token = "0x17000DA6")]
		public override UserMenuActionDic.Types.Actions ActionId
		{
			[Token(Token = "0x60044C9")]
			[Address(RVA = "0x936F", Offset = "0x936F", VA = "0x936F", Slot = "4")]
			get
			{
				return UserMenuActionDic.Types.Actions.UnknownAction;
			}
		}

		// Token: 0x060044CA RID: 17610 RVA: 0x0000CF48 File Offset: 0x0000B148
		[Token(Token = "0x60044CA")]
		[Address(RVA = "0x9370", Offset = "0x9370", VA = "0x9370", Slot = "5")]
		public override bool Validate(IUserMenuContext context)
		{
			return default(bool);
		}

		// Token: 0x060044CB RID: 17611 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044CB")]
		[Address(RVA = "0x9371", Offset = "0x9371", VA = "0x9371", Slot = "7")]
		public override void Handle(IUserMenuContext context)
		{
		}

		// Token: 0x060044CC RID: 17612 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044CC")]
		[Address(RVA = "0x9372", Offset = "0x9372", VA = "0x9372")]
		public AddToFavoriteContextMenuElement()
		{
		}
	}
}
