using System;
using Il2CppDummyDll;
using UnityEngine.Networking;

namespace I2.Loc
{
	// Token: 0x02001362 RID: 4962
	[Token(Token = "0x2001362")]
	public class TranslationJob_WWW : TranslationJob
	{
		// Token: 0x060075CD RID: 30157 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60075CD")]
		[Address(RVA = "0xBF56", Offset = "0xBF56", VA = "0xBF56", Slot = "6")]
		public override void Dispose()
		{
		}

		// Token: 0x060075CE RID: 30158 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60075CE")]
		[Address(RVA = "0xBF57", Offset = "0xBF57", VA = "0xBF57")]
		public TranslationJob_WWW()
		{
		/* --- GHIDRA: .ctor ---
		void I2_Loc_TranslationJob_WWW___ctor(int *param1,int param2,int param3,undefined4 param4)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a60467 == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_GoogleTranslation_TypeInfo);
		    DAT_ram_00a60467 = '\x01';
		  }
		  param1[5] = param3;
		  param1[4] = param2;
		  if (*(int *)(I2_Loc_GoogleTranslation_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_GoogleTranslation_TypeInfo);
		  }
		  iVar1 = I2_Loc_GoogleTranslation__ForceTranslate(param2,1,0);
		  param1[6] = iVar1;
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))(param1,*(undefined4 *)(*param1 + 0xec));
		  return;
		}
		*/

		}

		// Token: 0x04003D81 RID: 15745
		[Token(Token = "0x4003D81")]
		[FieldOffset(Offset = "0xC")]
		public UnityWebRequest www;
	}
}
