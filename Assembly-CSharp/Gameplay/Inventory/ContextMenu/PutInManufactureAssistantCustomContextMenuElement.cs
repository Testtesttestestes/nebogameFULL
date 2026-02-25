using System;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Gameplay.Inventory.ContextMenu
{
	// Token: 0x020006DC RID: 1756
	[Token(Token = "0x20006DC")]
	public class PutInManufactureAssistantCustomContextMenuElement : PutInManufactureAssistantContextMenuElement
	{
		// Token: 0x17000800 RID: 2048
		// (get) Token: 0x06002A46 RID: 10822 RVA: 0x00008268 File Offset: 0x00006468
		[Token(Token = "0x17000800")]
		public override ArtikulMenuActionDic.Types.Actions ActionId
		{
			[Token(Token = "0x6002A46")]
			[Address(RVA = "0x7AE9", Offset = "0x7AE9", VA = "0x7AE9", Slot = "4")]
			get
			{
				return ArtikulMenuActionDic.Types.Actions.UnknownAction;
			}
		}

		// Token: 0x06002A47 RID: 10823 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A47")]
		[Address(RVA = "0x7AEA", Offset = "0x7AEA", VA = "0x7AEA")]
		public PutInManufactureAssistantCustomContextMenuElement()
		{
		}
	}
}
