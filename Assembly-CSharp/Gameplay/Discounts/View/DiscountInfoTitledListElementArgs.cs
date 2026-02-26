using System;
using Gameplay.Discounts.Model;
using Il2CppDummyDll;
using UI.Elements.RightPanel.TitledList;

namespace Gameplay.Discounts.View
{
	// Token: 0x02000893 RID: 2195
	[Token(Token = "0x2000893")]
	public class DiscountInfoTitledListElementArgs : BaseTitledListElementArgs
	{
		// Token: 0x060033C7 RID: 13255 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033C7")]
		[Address(RVA = "0x1DB8", Offset = "0x1DB8", VA = "0x1DB8")]
		public DiscountInfoTitledListElementArgs(IDiscountArgs discount)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Discounts_View_DiscountInfoTitledListElementArgs___ctor
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		            (param1,param2,*(undefined4 *)(*param1 + 0xec));
		  return;
		}
		*/

		}

		// Token: 0x04001C2F RID: 7215
		[Token(Token = "0x4001C2F")]
		[FieldOffset(Offset = "0x8")]
		public readonly IDiscountArgs Discount;
	}
}
