using System;
using Core.Data;
using Il2CppDummyDll;
using Protocol.Dic;
using UI.UserContextMenu;
using UI.UserContextMenu.ContextElements;
using UI.Windows;

namespace Gameplay.Chat.Model.Data.ContextMenu.Elements
{
	// Token: 0x02000B20 RID: 2848
	[Token(Token = "0x2000B20")]
	public class KickFromIsleContextMenuElement : AbstractUserContextMenuElement
	{
		// Token: 0x17000DA8 RID: 3496
		// (get) Token: 0x060044D1 RID: 17617 RVA: 0x0000CF90 File Offset: 0x0000B190
		[Token(Token = "0x17000DA8")]
		public override UserMenuActionDic.Types.Actions ActionId
		{
			[Token(Token = "0x60044D1")]
			[Address(RVA = "0x9377", Offset = "0x9377", VA = "0x9377", Slot = "4")]
			get
			{
				return UserMenuActionDic.Types.Actions.UnknownAction;
			}
		}

		// Token: 0x060044D2 RID: 17618 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044D2")]
		[Address(RVA = "0x9378", Offset = "0x9378", VA = "0x9378", Slot = "7")]
		public override void Handle(IUserMenuContext context)
		{
		}

		// Token: 0x060044D3 RID: 17619 RVA: 0x0000CFA8 File Offset: 0x0000B1A8
		[Token(Token = "0x60044D3")]
		[Address(RVA = "0x9379", Offset = "0x9379", VA = "0x9379", Slot = "5")]
		public override bool Validate(IUserMenuContext context)
		{
			return default(bool);
		}

		// Token: 0x060044D4 RID: 17620 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60044D4")]
		[Address(RVA = "0x937A", Offset = "0x937A", VA = "0x937A")]
		private DialogWindow ShowKickConfirmationWindow(UserData user)
		{
			return null;
		}

		// Token: 0x060044D5 RID: 17621 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044D5")]
		[Address(RVA = "0x937B", Offset = "0x937B", VA = "0x937B")]
		public KickFromIsleContextMenuElement()
		{
		}
	}
}
