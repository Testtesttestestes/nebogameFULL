using System;
using System.Collections.Generic;
using Core.Money;
using Il2CppDummyDll;

namespace UI.Price
{
	// Token: 0x020001C2 RID: 450
	[Token(Token = "0x20001C2")]
	public class PriceWithZeroResources : Price
	{
		// Token: 0x06000C02 RID: 3074 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000C02")]
		[Address(RVA = "0x5F15", Offset = "0x5F15", VA = "0x5F15", Slot = "6")]
		protected override List<Money> GetGameResources()
		{
		/* --- GHIDRA: GetGameResources ---
		void UI_Price_PriceWithZeroResources__GetGameResources(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a638ed == '\0') {
		    Mono_Security_ASN1__get_Item(&UI_Price_Price_TypeInfo);
		    DAT_ram_00a638ed = '\x01';
		  }
		  if (*(int *)(UI_Price_Price_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UI_Price_Price_TypeInfo);
		  }
		  UI_Price_Price__HidePrices(param1,0);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06000C03 RID: 3075 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C03")]
		[Address(RVA = "0x5F16", Offset = "0x5F16", VA = "0x5F16")]
		public PriceWithZeroResources()
		{
		/* --- GHIDRA: .ctor ---
		void UI_Price_PriceWithZeroResources___ctor(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a638ee == '\0') {
		    Mono_Security_ASN1__get_Item(&UI_Price_PriceWithZeroResources___c_TypeInfo);
		    DAT_ram_00a638ee = '\x01';
		  }
		  uVar1 = unnamed_function_1417(UI_Price_PriceWithZeroResources___c_TypeInfo);
		  **(undefined4 **)(UI_Price_PriceWithZeroResources___c_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

		}
	}
}
