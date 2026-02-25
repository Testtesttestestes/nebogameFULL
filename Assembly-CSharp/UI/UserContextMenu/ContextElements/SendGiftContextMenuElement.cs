using System;
using Il2CppDummyDll;
using Protocol.Dic;

namespace UI.UserContextMenu.ContextElements
{
	// Token: 0x0200012D RID: 301
	[Token(Token = "0x200012D")]
	public class SendGiftContextMenuElement : AbstractUserContextMenuElement
	{
		// Token: 0x17000132 RID: 306
		// (get) Token: 0x0600093B RID: 2363 RVA: 0x00003678 File Offset: 0x00001878
		[Token(Token = "0x17000132")]
		public override UserMenuActionDic.Types.Actions ActionId
		{
			[Token(Token = "0x600093B")]
			[Address(RVA = "0x5CB5", Offset = "0x5CB5", VA = "0x5CB5", Slot = "4")]
			get
			{
				return UserMenuActionDic.Types.Actions.UnknownAction;
			}
		}

		// Token: 0x0600093C RID: 2364 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600093C")]
		[Address(RVA = "0x5CB6", Offset = "0x5CB6", VA = "0x5CB6", Slot = "7")]
		public override void Handle(IUserMenuContext context)
		{
		}

		// Token: 0x0600093D RID: 2365 RVA: 0x00003690 File Offset: 0x00001890
		[Token(Token = "0x600093D")]
		[Address(RVA = "0x5CB7", Offset = "0x5CB7", VA = "0x5CB7", Slot = "5")]
		public override bool Validate(IUserMenuContext context)
		{
			return default(bool);
		}

		// Token: 0x0600093E RID: 2366 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600093E")]
		[Address(RVA = "0x5CB8", Offset = "0x5CB8", VA = "0x5CB8")]
		public SendGiftContextMenuElement()
		{
		}
	}
}
