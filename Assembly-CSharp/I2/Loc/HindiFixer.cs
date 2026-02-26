using System;
using Il2CppDummyDll;

namespace I2.Loc
{
	// Token: 0x020013A1 RID: 5025
	[Token(Token = "0x20013A1")]
	public class HindiFixer
	{
		// Token: 0x060077A7 RID: 30631 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60077A7")]
		[Address(RVA = "0xC105", Offset = "0xC105", VA = "0xC105")]
		internal static string Fix(string text)
		{
			return null;
		}

		// Token: 0x060077A8 RID: 30632 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60077A8")]
		[Address(RVA = "0xC106", Offset = "0xC106", VA = "0xC106")]
		public HindiFixer()
		{
		/* --- GHIDRA: .ctor ---
		void I2_Loc_HindiFixer___ctor(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a54e04 == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_HindiFixer___c_TypeInfo);
		    DAT_ram_00a54e04 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(I2_Loc_HindiFixer___c_TypeInfo);
		  **(undefined4 **)(I2_Loc_HindiFixer___c_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

		}
	}
}
