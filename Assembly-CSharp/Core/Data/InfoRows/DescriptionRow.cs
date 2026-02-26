using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Core.Data.InfoRows
{
	// Token: 0x020010E2 RID: 4322
	[Token(Token = "0x20010E2")]
	public class DescriptionRow : CommonRow
	{
		// Token: 0x06006522 RID: 25890 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006522")]
		[Address(RVA = "0xB0F2", Offset = "0xB0F2", VA = "0xB0F2")]
		public DescriptionRow()
		{
		/* --- GHIDRA: .ctor ---
		void Core_Data_InfoRows_DescriptionRow___ctor(int param1,undefined4 param2,undefined4 param3)
		
		{
		  *(undefined4 *)(param1 + 8) = 4;
		  *(undefined4 *)(param1 + 0x20) = param2;
		  return;
		}
		*/

		}

		// Token: 0x0400360B RID: 13835
		[Token(Token = "0x400360B")]
		[FieldOffset(Offset = "0x10")]
		public Color32 Color;
	}
}
