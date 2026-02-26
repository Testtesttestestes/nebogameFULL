using System;
using Il2CppDummyDll;

namespace Utils
{
	// Token: 0x02000039 RID: 57
	[Token(Token = "0x2000039")]
	public class CryptoUtils
	{
		// Token: 0x06000237 RID: 567 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000237")]
		[Address(RVA = "0x56DC", Offset = "0x56DC", VA = "0x56DC")]
		public static string CreateMD5(string input)
		{
			return null;
		}

		// Token: 0x06000238 RID: 568 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000238")]
		[Address(RVA = "0x56DD", Offset = "0x56DD", VA = "0x56DD")]
		public CryptoUtils()
		{
		/* --- GHIDRA: .ctor ---
		void Utils_CryptoUtils___ctor(int *param1,undefined4 param2)
		
		{
		  float fVar1;
		  float fVar2;
		  
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))(param1,*(undefined4 *)(*param1 + 0xe4));
		  param1[5] = (int)((float)param1[5] + 1.0);
		  fVar2 = (float)param1[6];
		  fVar1 = UnityEngine_Time__get_timeAsRational(0);
		  fVar2 = fVar2 + fVar1;
		  param1[6] = (int)fVar2;
		  if ((float)param1[4] <= fVar2) {
		    fVar1 = (float)param1[5];
		    param1[5] = 0;
		    param1[6] = 0;
		    (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		              (param1,fVar1 / fVar2,*(undefined4 *)(*param1 + 0xec));
		  }
		  return;
		}
		*/

		}
	}
}
