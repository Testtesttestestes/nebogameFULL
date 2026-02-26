using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace I2.Loc
{
	// Token: 0x02001364 RID: 4964
	[Token(Token = "0x2001364")]
	public class TranslationJob_Main : TranslationJob
	{
		// Token: 0x060075D3 RID: 30163 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60075D3")]
		[Address(RVA = "0xBF5C", Offset = "0xBF5C", VA = "0xBF5C")]
		public TranslationJob_Main(Dictionary<string, TranslationQuery> requests, GoogleTranslation.fnOnTranslationReady OnTranslationReady)
		{
		/* --- GHIDRA: .ctor ---
		undefined4 I2_Loc_TranslationJob_Main___ctor(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  int *piVar2;
		  undefined4 param2_00;
		  undefined4 param3;
		  int iVar3;
		  
		  if (DAT_ram_00a6046b == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_TranslationJob_GET_TypeInfo);
		    Mono_Security_ASN1__get_Item(&I2_Loc_TranslationJob_POST_TypeInfo);
		    DAT_ram_00a6046b = '\x01';
		  }
		  piVar2 = *(int **)(param1 + 0xc);
		  if (piVar2 != (int *)0x0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*piVar2 + 0xe8) * 4))
		                      (piVar2,*(undefined4 *)(*piVar2 + 0xec));
		    if (iVar1 == 0) {
		      return 0;
		    }
		    if (iVar1 == 1) {
		      *(undefined4 *)(param1 + 8) = 1;
		    }
		    else if (iVar1 == 2) {
		      iVar1 = **(int **)(param1 + 0xc);
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xf0) * 4))
		                (*(int **)(param1 + 0xc),*(undefined4 *)(iVar1 + 0xf4));
		      *(undefined4 *)(param1 + 0xc) = 0;
		      param2_00 = *(undefined4 *)(param1 + 0x18);
		      param3 = *(undefined4 *)(param1 + 0x1c);
		      param1_00 = unnamed_function_1417(I2_Loc_TranslationJob_POST_TypeInfo);
		      I2_Loc_TranslationJob_Main__Dispose(param1_00,param2_00,param3,param1);
		      *(undefined4 *)(param1 + 0x10) = param1_00;
		    }
		  }
		  piVar2 = *(int **)(param1 + 0x10);
		  if (piVar2 != (int *)0x0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*piVar2 + 0xe8) * 4))
		                      (piVar2,*(undefined4 *)(*piVar2 + 0xec));
		    if (iVar1 == 0) {
		      return 0;
		    }
		    if (iVar1 == 1) {
		      *(undefined4 *)(param1 + 8) = 1;
		    }
		    else if (iVar1 == 2) {
		      iVar1 = **(int **)(param1 + 0x10);
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xf0) * 4))
		                (*(int **)(param1 + 0x10),*(undefined4 *)(iVar1 + 0xf4));
		      *(undefined4 *)(param1 + 0x10) = 0;
		      iVar1 = *(int *)(param1 + 0x18);
		      iVar3 = *(int *)(param1 + 0x1c);
		      piVar2 = (int *)unnamed_function_1417(I2_Loc_TranslationJob_GET_TypeInfo);
		      if (DAT_ram_00a60467 == '\0') {
		        Mono_Security_ASN1__get_Item(&I2_Loc_GoogleTranslation_TypeInfo);
		        DAT_ram_00a60467 = '\x01';
		      }
		      piVar2[5] = iVar3;
		      piVar2[4] = iVar1;
		      if (*(int *)(I2_Loc_GoogleTranslation_TypeInfo + 0x74) == 0) {
		        func_ii_306000(I2_Loc_GoogleTranslation_TypeInfo);
		      }
		      iVar1 = I2_Loc_GoogleTranslation__ForceTranslate(iVar1,1,0);
		      piVar2[6] = iVar1;
		      (**(code **)((ulonglong)*(uint *)(*piVar2 + 0xe8) * 4))
		                (piVar2,*(undefined4 *)(*piVar2 + 0xec));
		      *(int **)(param1 + 0x14) = piVar2;
		    }
		  }
		  piVar2 = *(int **)(param1 + 0x14);
		  if (piVar2 != (int *)0x0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*piVar2 + 0xe8) * 4))
		                      (piVar2,*(undefined4 *)(*piVar2 + 0xec));
		    if (iVar1 == 0) {
		      return 0;
		    }
		    if (iVar1 == 1) {
		      *(undefined4 *)(param1 + 8) = 1;
		    }
		    else if (iVar1 == 2) {
		      piVar2 = *(int **)(param1 + 0x14);
		      iVar3 = piVar2[7];
		      *(int *)(param1 + 0x20) = iVar3;
		      iVar1 = *(int *)(param1 + 0x1c);
		      if (iVar1 != 0) {
		        (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                  (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(param1 + 0x18),iVar3,
		                   *(undefined4 *)(iVar1 + 0x14));
		        piVar2 = *(int **)(param1 + 0x14);
		      }
		      (**(code **)((ulonglong)*(uint *)(*piVar2 + 0xf0) * 4))
		                (piVar2,*(undefined4 *)(*piVar2 + 0xf4));
		      *(undefined4 *)(param1 + 0x14) = 0;
		    }
		  }
		  return *(undefined4 *)(param1 + 8);
		}
		*/

		}

		// Token: 0x060075D4 RID: 30164 RVA: 0x00015468 File Offset: 0x00013668
		[Token(Token = "0x60075D4")]
		[Address(RVA = "0xBF5D", Offset = "0xBF5D", VA = "0xBF5D", Slot = "5")]
		public override TranslationJob.eJobState GetState()
		{
		/* --- GHIDRA: GetState ---
		void I2_Loc_TranslationJob_Main__GetState(int param1,undefined4 param2)
		
		{
		  int *piVar1;
		  
		  piVar1 = *(int **)(param1 + 0x10);
		  if (piVar1 != (int *)0x0) {
		    (**(code **)((ulonglong)*(uint *)(*piVar1 + 0xf0) * 4))(piVar1,*(undefined4 *)(*piVar1 + 0xf4));
		  }
		  piVar1 = *(int **)(param1 + 0x14);
		  if (piVar1 != (int *)0x0) {
		    (**(code **)((ulonglong)*(uint *)(*piVar1 + 0xf0) * 4))(piVar1,*(undefined4 *)(*piVar1 + 0xf4));
		  }
		  *(undefined8 *)(param1 + 0x10) = 0;
		  return;
		}
		*/

			return TranslationJob.eJobState.Running;
		}

		// Token: 0x060075D5 RID: 30165 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60075D5")]
		[Address(RVA = "0xBF5E", Offset = "0xBF5E", VA = "0xBF5E", Slot = "6")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void I2_Loc_TranslationJob_Main__Dispose
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a6046c == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_GoogleTranslation_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_string__get_Item__);
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_WWWForm_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_16439);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25144);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19683);
		    DAT_ram_00a6046c = '\x01';
		  }
		  *(undefined4 *)(param1 + 0x14) = param3;
		  *(undefined4 *)(param1 + 0x10) = param2;
		  if (*(int *)(I2_Loc_GoogleTranslation_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_GoogleTranslation_TypeInfo);
		  }
		  uVar1 = I2_Loc_GoogleTranslation__ForceTranslate(param2,0,0);
		  param1_00 = unnamed_function_1417(UnityEngine_WWWForm_TypeInfo);
		  UnityEngine_WWWForm__get_DefaultEncoding(param1_00,0);
		  func_ii_8959(param1_00,StringLiteral_19683,StringLiteral_16439,0);
		  uVar1 = System_Linq_Enumerable__ToList_object_
		                    (uVar1,0,Method_System_Collections_Generic_List_string__get_Item__);
		  func_ii_8959(param1_00,StringLiteral_25144,uVar1,0);
		  if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		  }
		  uVar1 = I2_Loc_LocalizationManager__GetRequiredWebServiceVersion(0,param1);
		  uVar1 = UnityEngine_Networking_UnityWebRequest__Put(uVar1,param1_00,0);
		  *(undefined4 *)(param1 + 0xc) = uVar1;
		  I2_Loc_I2Utils__GetCaptureMatch(uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x04003D86 RID: 15750
		[Token(Token = "0x4003D86")]
		[FieldOffset(Offset = "0xC")]
		private TranslationJob_WEB mWeb;

		// Token: 0x04003D87 RID: 15751
		[Token(Token = "0x4003D87")]
		[FieldOffset(Offset = "0x10")]
		private TranslationJob_POST mPost;

		// Token: 0x04003D88 RID: 15752
		[Token(Token = "0x4003D88")]
		[FieldOffset(Offset = "0x14")]
		private TranslationJob_GET mGet;

		// Token: 0x04003D89 RID: 15753
		[Token(Token = "0x4003D89")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<string, TranslationQuery> _requests;

		// Token: 0x04003D8A RID: 15754
		[Token(Token = "0x4003D8A")]
		[FieldOffset(Offset = "0x1C")]
		private GoogleTranslation.fnOnTranslationReady _OnTranslationReady;

		// Token: 0x04003D8B RID: 15755
		[Token(Token = "0x4003D8B")]
		[FieldOffset(Offset = "0x20")]
		public string mErrorMessage;
	}
}
