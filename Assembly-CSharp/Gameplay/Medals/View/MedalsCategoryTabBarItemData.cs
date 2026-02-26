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
		/* --- GHIDRA: .ctor ---
		undefined4
		Gameplay_Medals_View_MedalsCategoryTabBarItemData___ctor(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57d96 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_12652);
		    DAT_ram_00a57d96 = '\x01';
		  }
		  return StringLiteral_12652;
		}
		*/

		}

		// Token: 0x04001453 RID: 5203
		[Token(Token = "0x4001453")]
		[FieldOffset(Offset = "0x20")]
		public MedalsCategoryData MedalsCategoryData;
	}
}
