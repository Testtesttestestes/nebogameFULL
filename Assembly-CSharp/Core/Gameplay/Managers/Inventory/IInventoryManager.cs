using System;
using Gameplay.Inventory.Events;
using Gameplay.Inventory.Model;
using Il2CppDummyDll;

namespace Core.Gameplay.Managers.Inventory
{
	// Token: 0x020011C0 RID: 4544
	[Token(Token = "0x20011C0")]
	[Obsolete("Require refactoring. Note: Remove this and refactoring dependencies who use this fields. ArtifactInfoPopupWindow, etcs")]
	public interface IInventoryManager
	{
		// Token: 0x17001618 RID: 5656
		// (get) Token: 0x06006C1E RID: 27678
		[Token(Token = "0x17001618")]
		InventoryBaseModel Model { [Token(Token = "0x6006C1E")] get; }

		// Token: 0x17001619 RID: 5657
		// (get) Token: 0x06006C1F RID: 27679
		[Token(Token = "0x17001619")]
		InventoryBaseEvents Events { [Token(Token = "0x6006C1F")] get; }
	}
}
