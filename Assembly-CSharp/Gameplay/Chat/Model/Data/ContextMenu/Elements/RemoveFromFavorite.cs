using System;
using Il2CppDummyDll;
using Protocol.Dic;
using UI.UserContextMenu;
using UI.UserContextMenu.ContextElements;

namespace Gameplay.Chat.Model.Data.ContextMenu.Elements
{
	// Token: 0x02000B25 RID: 2853
	[Token(Token = "0x2000B25")]
	public class RemoveFromFavorite : AbstractUserContextMenuElement
	{
		// Token: 0x17000DAC RID: 3500
		// (get) Token: 0x060044E4 RID: 17636 RVA: 0x0000D050 File Offset: 0x0000B250
		[Token(Token = "0x17000DAC")]
		public override UserMenuActionDic.Types.Actions ActionId
		{
			[Token(Token = "0x60044E4")]
			[Address(RVA = "0x938A", Offset = "0x938A", VA = "0x938A", Slot = "4")]
			get
			{
				return UserMenuActionDic.Types.Actions.UnknownAction;
			}
		}

		// Token: 0x060044E5 RID: 17637 RVA: 0x0000D068 File Offset: 0x0000B268
		[Token(Token = "0x60044E5")]
		[Address(RVA = "0x938B", Offset = "0x938B", VA = "0x938B", Slot = "5")]
		public override bool Validate(IUserMenuContext context)
		{
			return default(bool);
		}

		// Token: 0x060044E6 RID: 17638 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044E6")]
		[Address(RVA = "0x938C", Offset = "0x938C", VA = "0x938C", Slot = "7")]
		public override void Handle(IUserMenuContext context)
		{
		}

		// Token: 0x060044E7 RID: 17639 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044E7")]
		[Address(RVA = "0x938D", Offset = "0x938D", VA = "0x938D")]
		public RemoveFromFavorite()
		{
		}
	}
}
