using System;
using Gameplay.Inventory.View;
using Il2CppDummyDll;

namespace Gameplay.UserInfo.View.Equipment
{
	// Token: 0x0200040A RID: 1034
	[Token(Token = "0x200040A")]
	public interface IEquipmentSlotConfig
	{
		// Token: 0x1700044A RID: 1098
		// (get) Token: 0x0600184D RID: 6221
		[Token(Token = "0x1700044A")]
		EquipmentSlotView Slot { [Token(Token = "0x600184D")] get; }

		// Token: 0x0600184E RID: 6222
		[Token(Token = "0x600184E")]
		int GetSlotId();
	}
}
