using System;
using Il2CppDummyDll;
using Protocol.Dic;

namespace UI.UserContextMenu.ContextElements
{
	// Token: 0x0200012E RID: 302
	[Token(Token = "0x200012E")]
	public class VisitIsleUserContextMenuElement : AbstractUserContextMenuElement
	{
		// Token: 0x17000133 RID: 307
		// (get) Token: 0x0600093F RID: 2367 RVA: 0x000036A8 File Offset: 0x000018A8
		[Token(Token = "0x17000133")]
		public override UserMenuActionDic.Types.Actions ActionId
		{
			[Token(Token = "0x600093F")]
			[Address(RVA = "0x5CB9", Offset = "0x5CB9", VA = "0x5CB9", Slot = "4")]
			get
			{
				return UserMenuActionDic.Types.Actions.UnknownAction;
			}
		}

		// Token: 0x06000940 RID: 2368 RVA: 0x000036C0 File Offset: 0x000018C0
		[Token(Token = "0x6000940")]
		[Address(RVA = "0x5CBA", Offset = "0x5CBA", VA = "0x5CBA", Slot = "5")]
		public override bool Validate(IUserMenuContext context)
		{
			return default(bool);
		}

		// Token: 0x06000941 RID: 2369 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000941")]
		[Address(RVA = "0x5CBB", Offset = "0x5CBB", VA = "0x5CBB", Slot = "7")]
		public override void Handle(IUserMenuContext context)
		{
		}

		// Token: 0x06000942 RID: 2370 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000942")]
		[Address(RVA = "0x5CBC", Offset = "0x5CBC", VA = "0x5CBC")]
		public VisitIsleUserContextMenuElement()
		{
		}
	}
}
