using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace I2.Loc
{
	// Token: 0x02001363 RID: 4963
	[Token(Token = "0x2001363")]
	public class TranslationJob_GET : TranslationJob_WWW
	{
		// Token: 0x060075CF RID: 30159 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60075CF")]
		[Address(RVA = "0xBF58", Offset = "0xBF58", VA = "0xBF58")]
		public TranslationJob_GET(Dictionary<string, TranslationQuery> requests, GoogleTranslation.fnOnTranslationReady OnTranslationReady)
		{
		/* --- GHIDRA: .ctor ---
		void I2_Loc_TranslationJob_GET___ctor(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  int iVar2;
		  
		  if (DAT_ram_00a60468 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_string__RemoveAt__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_string__get_Count__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_string__get_Item__);
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2380);
		    DAT_ram_00a60468 = '\x01';
		  }
		  iVar2 = *(int *)(*(int *)(param1 + 0x18) + 0xc);
		  if (iVar2 == 0) {
		    *(undefined4 *)(param1 + 8) = 1;
		    return;
		  }
		  iVar2 = iVar2 + -1;
		  uVar1 = System_Linq_Enumerable__ToList_object_
		                    (*(int *)(param1 + 0x18),iVar2,
		                     Method_System_Collections_Generic_List_string__get_Item__);
		  UnityEngine_TextCore_Glyph__set_atlasIndex
		            (*(undefined4 *)(param1 + 0x18),iVar2,
		             Method_System_Collections_Generic_List_string__RemoveAt__);
		  if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		  }
		  param1_00 = I2_Loc_LocalizationManager__GetRequiredWebServiceVersion(0,param1);
		  uVar1 = UnityEngine_AndroidJavaObject__FromJavaArray_Nullable_int__
		                    (param1_00,StringLiteral_2380,uVar1,0);
		  uVar1 = UnityEngine_Networking_UnityWebRequest__get_timeout(uVar1,0);
		  *(undefined4 *)(param1 + 0xc) = uVar1;
		  I2_Loc_I2Utils__GetCaptureMatch(uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x060075D0 RID: 30160 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60075D0")]
		[Address(RVA = "0xBF59", Offset = "0xBF59", VA = "0xBF59")]
		private void ExecuteNextQuery()
		{
		/* --- GHIDRA: ExecuteNextQuery ---
		undefined4 I2_Loc_TranslationJob_GET__ExecuteNextQuery(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param2_00;
		  undefined4 param3;
		  
		  if (*(int *)(param1 + 0xc) != 0) {
		    iVar1 = UnityEngine_Networking_UnityWebRequest__get_isModifiable(*(int *)(param1 + 0xc),0);
		    if (iVar1 == 0) {
		      if (*(int *)(param1 + 0xc) != 0) goto code_r0x81c8db61;
		    }
		    else {
		      param2_00 = UnityEngine_Networking_DownloadHandler__Dispose
		                            (*(undefined4 *)(*(int *)(param1 + 0xc) + 0xc),0);
		      param3 = UnityEngine_Networking_UnityWebRequest__get_url(*(undefined4 *)(param1 + 0xc),0);
		      I2_Loc_TranslationJob_GET__GetState(param1,param2_00,param3,param1);
		      UnityEngine_Networking_UnityWebRequest__Finalize(*(undefined4 *)(param1 + 0xc),0);
		      *(undefined4 *)(param1 + 0xc) = 0;
		    }
		  }
		  I2_Loc_TranslationJob_GET___ctor(param1,param1);
		code_r0x81c8db61:
		  return *(undefined4 *)(param1 + 8);
		}
		*/

		}

		// Token: 0x060075D1 RID: 30161 RVA: 0x00015450 File Offset: 0x00013650
		[Token(Token = "0x60075D1")]
		[Address(RVA = "0xBF5A", Offset = "0xBF5A", VA = "0xBF5A", Slot = "5")]
		public override TranslationJob.eJobState GetState()
		{
		/* --- GHIDRA: GetState ---
		void I2_Loc_TranslationJob_GET__GetState(int param1,int param2,undefined4 param3,undefined4 param4)
		
		{
		  int iVar1;
		  int *piVar2;
		  undefined4 param1_00;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a60469 == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_GoogleTranslation_TypeInfo);
		    DAT_ram_00a60469 = '\x01';
		  }
		  iVar1 = func_ii_4769(param3,0);
		  if (iVar1 != 0) {
		    piVar2 = (int *)func_ii_5618(0);
		    param1_00 = (**(code **)((ulonglong)*(uint *)(*piVar2 + 0x1f0) * 4))
		                          (piVar2,param2,0,*(undefined4 *)(param2 + 0xc),
		                           *(undefined4 *)(*piVar2 + 500));
		    param2_00 = *(undefined4 *)(param1 + 0x10);
		    if (*(int *)(I2_Loc_GoogleTranslation_TypeInfo + 0x74) == 0) {
		      func_ii_306000(I2_Loc_GoogleTranslation_TypeInfo);
		    }
		    param3 = I2_Loc_GoogleTranslation__WaitForTranslations(param1_00,param2_00,0);
		    iVar1 = func_ii_4769(param3,0);
		    if (iVar1 != 0) {
		      iVar1 = *(int *)(param1 + 0x14);
		      if (iVar1 == 0) {
		        return;
		      }
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(param1 + 0x10),0,
		                 *(undefined4 *)(iVar1 + 0x14));
		      return;
		    }
		  }
		  *(undefined4 *)(param1 + 0x1c) = param3;
		  *(undefined4 *)(param1 + 8) = 2;
		  return;
		}
		*/

			return TranslationJob.eJobState.Running;
		}

		// Token: 0x060075D2 RID: 30162 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60075D2")]
		[Address(RVA = "0xBF5B", Offset = "0xBF5B", VA = "0xBF5B")]
		public void ProcessResult(byte[] bytes, string errorMsg)
		{
		/* --- GHIDRA: ProcessResult ---
		void I2_Loc_TranslationJob_GET__ProcessResult
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a6046a == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_TranslationJob_POST_TypeInfo);
		    DAT_ram_00a6046a = '\x01';
		  }
		  *(undefined4 *)(param1 + 0x1c) = param3;
		  *(undefined4 *)(param1 + 0x18) = param2;
		  param1_00 = unnamed_function_1417(I2_Loc_TranslationJob_POST_TypeInfo);
		  I2_Loc_TranslationJob_Main__Dispose(param1_00,param2,param3,param1);
		  *(undefined4 *)(param1 + 0x10) = param1_00;
		  return;
		}
		*/

		}

		// Token: 0x04003D82 RID: 15746
		[Token(Token = "0x4003D82")]
		[FieldOffset(Offset = "0x10")]
		private Dictionary<string, TranslationQuery> _requests;

		// Token: 0x04003D83 RID: 15747
		[Token(Token = "0x4003D83")]
		[FieldOffset(Offset = "0x14")]
		private GoogleTranslation.fnOnTranslationReady _OnTranslationReady;

		// Token: 0x04003D84 RID: 15748
		[Token(Token = "0x4003D84")]
		[FieldOffset(Offset = "0x18")]
		private List<string> mQueries;

		// Token: 0x04003D85 RID: 15749
		[Token(Token = "0x4003D85")]
		[FieldOffset(Offset = "0x1C")]
		public string mErrorMessage;
	}
}
