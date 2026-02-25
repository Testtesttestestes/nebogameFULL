using System;
using Gameplay.Inventory.View.Chest;
using Il2CppDummyDll;
using UI.Tabs;

namespace Gameplay.Medals.View
{
	// Token: 0x020005FA RID: 1530
	[Token(Token = "0x20005FA")]
	public class MedalsCategoryTabBarItemData : TabBarItemData
	{
		// Token: 0x0600252B RID: 9515 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600252B")]
		[Address(RVA = "0x7674", Offset = "0x7674", VA = "0x7674")]
		public MedalsCategoryTabBarItemData()
		{
		}

		// Token: 0x04001453 RID: 5203
		[Token(Token = "0x4001453")]
		[FieldOffset(Offset = "0x20")]
		public MedalsCategoryData MedalsCategoryData;
	}
}
