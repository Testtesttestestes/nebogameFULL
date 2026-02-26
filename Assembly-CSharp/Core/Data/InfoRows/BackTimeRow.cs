using System;
using Il2CppDummyDll;
using Utils;

namespace Core.Data.InfoRows
{
	// Token: 0x020010E1 RID: 4321
	[Token(Token = "0x20010E1")]
	public class BackTimeRow : CommonRow
	{
		// Token: 0x06006521 RID: 25889 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006521")]
		[Address(RVA = "0xB0F1", Offset = "0xB0F1", VA = "0xB0F1")]
		public BackTimeRow(BackTime backTime)
		{
		/* --- GHIDRA: .ctor ---
		void Core_Data_InfoRows_BackTimeRow___ctor(int param1,undefined4 param2)
		
		{
		  undefined8 local_28;
		  undefined8 local_20;
		  undefined8 local_14;
		  undefined8 local_c;
		  undefined4 local_4;
		  
		  local_c = 0x3f8000003f800000;
		  local_20 = 0x3f8000003f800000;
		  local_14 = 0x3f8000003f800000;
		  local_28 = 0x3f8000003f800000;
		  UnityEngine_Color32___ctor(&local_4,&local_28,0);
		  *(undefined4 *)(param1 + 0x10) = local_4;
		  *(undefined4 *)(param1 + 8) = 3;
		  return;
		}
		*/

		}

		// Token: 0x04003609 RID: 13833
		[Token(Token = "0x4003609")]
		[FieldOffset(Offset = "0x10")]
		public readonly BackTime BackTime;

		// Token: 0x0400360A RID: 13834
		[Token(Token = "0x400360A")]
		[FieldOffset(Offset = "0x14")]
		public float MinThreshold;
	}
}
