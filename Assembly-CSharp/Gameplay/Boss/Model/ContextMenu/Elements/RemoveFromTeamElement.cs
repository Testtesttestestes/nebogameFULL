using System;
using Il2CppDummyDll;
using Protocol.Dic;
using UI.UserContextMenu;
using UI.UserContextMenu.ContextElements;

namespace Gameplay.Boss.Model.ContextMenu.Elements
{
	// Token: 0x02000B9E RID: 2974
	[Token(Token = "0x2000B9E")]
	public class RemoveFromTeamElement : AbstractUserContextMenuElement
	{
		// Token: 0x17000ED5 RID: 3797
		// (get) Token: 0x060048BB RID: 18619 RVA: 0x0000D7E8 File Offset: 0x0000B9E8
		[Token(Token = "0x17000ED5")]
		public override UserMenuActionDic.Types.Actions ActionId
		{
			[Token(Token = "0x60048BB")]
			[Address(RVA = "0x9734", Offset = "0x9734", VA = "0x9734", Slot = "4")]
			get
			{
				return UserMenuActionDic.Types.Actions.UnknownAction;
			}
		}

		// Token: 0x060048BC RID: 18620 RVA: 0x0000D800 File Offset: 0x0000BA00
		[Token(Token = "0x60048BC")]
		[Address(RVA = "0x9735", Offset = "0x9735", VA = "0x9735", Slot = "5")]
		public override bool Validate(IUserMenuContext context)
		{
			return default(bool);
		}

		// Token: 0x060048BD RID: 18621 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048BD")]
		[Address(RVA = "0x9736", Offset = "0x9736", VA = "0x9736", Slot = "7")]
		public override void Handle(IUserMenuContext context)
		{
		}

		// Token: 0x060048BE RID: 18622 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048BE")]
		[Address(RVA = "0x9737", Offset = "0x9737", VA = "0x9737")]
		public RemoveFromTeamElement()
		{
		}
	}
}
