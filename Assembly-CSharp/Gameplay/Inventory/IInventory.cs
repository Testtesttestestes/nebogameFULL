using System;
using Il2CppDummyDll;
using UI.Windows;

namespace Gameplay.Inventory
{
	// Token: 0x02000651 RID: 1617
	[Token(Token = "0x2000651")]
	public interface IInventory
	{
		// Token: 0x0600273E RID: 10046
		[Token(Token = "0x600273E")]
		DialogWindow ShowNotAvailableSlotsWindow(int slotsCount);
	}
}
