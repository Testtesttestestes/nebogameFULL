using System;
using Il2CppDummyDll;
using Protocol.Dic;

namespace UI.UserContextMenu.ContextElements
{
	// Token: 0x0200012C RID: 300
	[Token(Token = "0x200012C")]
	public class ProfileUserContextMenuElement : AbstractUserContextMenuElement
	{
		// Token: 0x17000131 RID: 305
		// (get) Token: 0x06000937 RID: 2359 RVA: 0x00003648 File Offset: 0x00001848
		[Token(Token = "0x17000131")]
		public override UserMenuActionDic.Types.Actions ActionId
		{
			[Token(Token = "0x6000937")]
			[Address(RVA = "0x5CB1", Offset = "0x5CB1", VA = "0x5CB1", Slot = "4")]
			get
			{
				return UserMenuActionDic.Types.Actions.UnknownAction;
			}
		}

		// Token: 0x06000938 RID: 2360 RVA: 0x00003660 File Offset: 0x00001860
		[Token(Token = "0x6000938")]
		[Address(RVA = "0x5CB2", Offset = "0x5CB2", VA = "0x5CB2", Slot = "5")]
		public override bool Validate(IUserMenuContext context)
		{
			return default(bool);
		}

		// Token: 0x06000939 RID: 2361 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000939")]
		[Address(RVA = "0x5CB3", Offset = "0x5CB3", VA = "0x5CB3", Slot = "7")]
		public override void Handle(IUserMenuContext context)
		{
		}

		// Token: 0x0600093A RID: 2362 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600093A")]
		[Address(RVA = "0x5CB4", Offset = "0x5CB4", VA = "0x5CB4")]
		public ProfileUserContextMenuElement()
		{
		}
	}
}
