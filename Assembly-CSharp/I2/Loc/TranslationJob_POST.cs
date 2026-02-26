using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace I2.Loc
{
	// Token: 0x02001365 RID: 4965
	[Token(Token = "0x2001365")]
	public class TranslationJob_POST : TranslationJob_WWW
	{
		// Token: 0x060075D6 RID: 30166 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60075D6")]
		[Address(RVA = "0xBF5F", Offset = "0xBF5F", VA = "0xBF5F")]
		public TranslationJob_POST(Dictionary<string, TranslationQuery> requests, GoogleTranslation.fnOnTranslationReady OnTranslationReady)
		{
		/* --- GHIDRA: .ctor ---
		undefined4 I2_Loc_TranslationJob_POST___ctor(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param2_00;
		  undefined4 param3;
		  
		  if ((*(int *)(param1 + 0xc) != 0) &&
		     (iVar1 = UnityEngine_Networking_UnityWebRequest__get_isModifiable(*(int *)(param1 + 0xc),0),
		     iVar1 != 0)) {
		    param2_00 = UnityEngine_Networking_DownloadHandler__Dispose
		                          (*(undefined4 *)(*(int *)(param1 + 0xc) + 0xc),0);
		    param3 = UnityEngine_Networking_UnityWebRequest__get_url(*(undefined4 *)(param1 + 0xc),0);
		    I2_Loc_TranslationJob_POST__GetState(param1,param2_00,param3,param1);
		    UnityEngine_Networking_UnityWebRequest__Finalize(*(undefined4 *)(param1 + 0xc),0);
		    *(undefined4 *)(param1 + 0xc) = 0;
		  }
		  return *(undefined4 *)(param1 + 8);
		}
		*/

		}

		// Token: 0x060075D7 RID: 30167 RVA: 0x00015480 File Offset: 0x00013680
		[Token(Token = "0x60075D7")]
		[Address(RVA = "0xBF60", Offset = "0xBF60", VA = "0xBF60", Slot = "5")]
		public override TranslationJob.eJobState GetState()
		{
		/* --- GHIDRA: GetState ---
		void I2_Loc_TranslationJob_POST__GetState(int param1,int param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int *piVar3;
		  undefined4 uVar4;
		  
		  if (DAT_ram_00a6046d == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_GoogleTranslation_TypeInfo);
		    DAT_ram_00a6046d = '\x01';
		  }
		  uVar1 = 2;
		  iVar2 = func_ii_4769(param3,0);
		  if (iVar2 != 0) {
		    piVar3 = (int *)func_ii_5618(0);
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x1f0) * 4))
		                      (piVar3,param2,0,*(undefined4 *)(param2 + 0xc),*(undefined4 *)(*piVar3 + 500))
		    ;
		    uVar4 = *(undefined4 *)(param1 + 0x10);
		    if (*(int *)(I2_Loc_GoogleTranslation_TypeInfo + 0x74) == 0) {
		      func_ii_306000(I2_Loc_GoogleTranslation_TypeInfo);
		    }
		    uVar4 = I2_Loc_GoogleTranslation__WaitForTranslations(uVar1,uVar4,0);
		    uVar1 = 1;
		    iVar2 = *(int *)(param1 + 0x14);
		    if (iVar2 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                (*(undefined4 *)(iVar2 + 0x20),*(undefined4 *)(param1 + 0x10),uVar4,
		                 *(undefined4 *)(iVar2 + 0x14));
		    }
		  }
		  *(undefined4 *)(param1 + 8) = uVar1;
		  return;
		}
		*/

			return TranslationJob.eJobState.Running;
		}

		// Token: 0x060075D8 RID: 30168 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60075D8")]
		[Address(RVA = "0xBF61", Offset = "0xBF61", VA = "0xBF61")]
		public void ProcessResult(byte[] bytes, string errorMsg)
		{
		/* --- GHIDRA: ProcessResult ---
		void I2_Loc_TranslationJob_POST__ProcessResult
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  *(undefined4 *)(param1 + 0x14) = param3;
		  *(undefined4 *)(param1 + 0x10) = param2;
		  I2_Loc_TranslationJob_WEB___ctor(param1,param1);
		  I2_Loc_TranslationJob_WEB__FindAllQueries(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x04003D8C RID: 15756
		[Token(Token = "0x4003D8C")]
		[FieldOffset(Offset = "0x10")]
		private Dictionary<string, TranslationQuery> _requests;

		// Token: 0x04003D8D RID: 15757
		[Token(Token = "0x4003D8D")]
		[FieldOffset(Offset = "0x14")]
		private GoogleTranslation.fnOnTranslationReady _OnTranslationReady;
	}
}
