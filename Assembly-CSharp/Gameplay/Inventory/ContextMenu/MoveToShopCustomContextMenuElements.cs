using System;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Gameplay.Inventory.ContextMenu
{
	// Token: 0x020006DA RID: 1754
	[Token(Token = "0x20006DA")]
	public class MoveToShopCustomContextMenuElements : MoveToShopContextMenuElement
	{
		// Token: 0x170007FE RID: 2046
		// (get) Token: 0x06002A40 RID: 10816 RVA: 0x00008220 File Offset: 0x00006420
		[Token(Token = "0x170007FE")]
		public override ArtikulMenuActionDic.Types.Actions ActionId
		{
			[Token(Token = "0x6002A40")]
			[Address(RVA = "0x7AE3", Offset = "0x7AE3", VA = "0x7AE3", Slot = "4")]
			get
			{
				return ArtikulMenuActionDic.Types.Actions.UnknownAction;
			}
		}

		// Token: 0x06002A41 RID: 10817 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A41")]
		[Address(RVA = "0x7AE4", Offset = "0x7AE4", VA = "0x7AE4")]
		public MoveToShopCustomContextMenuElements()
		{
		}
	}
}
