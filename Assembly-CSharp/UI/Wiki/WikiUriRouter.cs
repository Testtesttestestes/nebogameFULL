using System;
using Core.Dict;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using Utils;

namespace UI.Wiki
{
	// Token: 0x02000118 RID: 280
	[Token(Token = "0x2000118")]
	public class WikiUriRouter : MonoPointerClickHandler
	{
		// Token: 0x060008CC RID: 2252 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008CC")]
		[Address(RVA = "0x5C58", Offset = "0x5C58", VA = "0x5C58")]
		private void Start()
		{
		}

		// Token: 0x060008CD RID: 2253 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008CD")]
		[Address(RVA = "0x5C59", Offset = "0x5C59", VA = "0x5C59")]
		public void SetData(Uri uri, params object[] args)
		{
		/* --- GHIDRA: SetData ---
		void UI_Wiki_WikiUriRouter__SetData(int param1,undefined4 param2,undefined4 param3)
		
		{
		  UI_Wiki_WikiUriRouter__HandleClickEvent
		            (param1,*(undefined4 *)(param1 + 0x24),*(undefined4 *)(param1 + 0x28),param1);
		  return;
		}
		*/

		/* --- GHIDRA: SetData ---
		void UI_Wiki_WikiUriRouter__SetData(int param1,undefined4 param2,undefined4 param3)
		
		{
		  UI_Wiki_WikiUriRouter__HandleClickEvent
		            (param1,*(undefined4 *)(param1 + 0x24),*(undefined4 *)(param1 + 0x28),param1);
		  return;
		}
		*/

		}

		// Token: 0x060008CE RID: 2254 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008CE")]
		[Address(RVA = "0x1B4E", Offset = "0x1B4E", VA = "0x1B4E")]
		public void SetData(IDictProvider dictProvider, params object[] args)
		{
		}

		// Token: 0x060008CF RID: 2255 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008CF")]
		[Address(RVA = "0x5C5A", Offset = "0x5C5A", VA = "0x5C5A")]
		private void HandleClickEvent(PointerEventData obj)
		{
		/* --- GHIDRA: HandleClickEvent ---
		void UI_Wiki_WikiUriRouter__HandleClickEvent
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int *param1_00;
		  int *piVar1;
		  undefined4 uVar2;
		  int iVar3;
		  undefined4 uVar4;
		  
		  if (DAT_ram_00a5b8a4 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Sirenix_Utilities_LinqExtensions_IsNullOrEmpty_object___);
		    Mono_Security_ASN1__get_Item(&System_UriBuilder_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_Uri_UriQuery_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19433);
		    Mono_Security_ASN1__get_Item(&StringLiteral_17911);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25024);
		    DAT_ram_00a5b8a4 = '\x01';
		  }
		  param1_00 = (int *)unnamed_function_1417(Utils_Uri_UriQuery_TypeInfo);
		  Utils_Uri_UriQuery___ctor(param1_00,param2,0);
		  if (DAT_ram_00a63c4b == '\0') {
		    Mono_Security_ASN1__get_Item(&Localization_Culture_Culture_TypeInfo);
		    DAT_ram_00a63c4b = '\x01';
		  }
		  piVar1 = (int *)Gameplay_FeedbackForm_Model_Controll_FeedbackFormController__GetBase64ZipContent
		                            (*(undefined4 *)
		                              (*(int *)(Localization_Culture_Culture_TypeInfo + 0x5c) + 4),0);
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*piVar1 + 0xf8) * 4))
		                    (piVar1,*(undefined4 *)(*piVar1 + 0xfc));
		  uVar2 = func_ii_7775(uVar2,0);
		  Utils_Uri_UriQuery___ctor(param1_00,StringLiteral_25024,uVar2,0);
		  uVar2 = unnamed_function_1417(System_UriBuilder_TypeInfo);
		  System_Uri__get_IsAbsoluteUri(uVar2,param2,0);
		  iVar3 = Sirenix_Utilities_LinqExtensions__IsNullOrEmpty_object_
		                    (param3,Method_Sirenix_Utilities_LinqExtensions_IsNullOrEmpty_object___);
		  if (iVar3 == 0) {
		    uVar4 = UnityEngine_InputSystem_Utilities_TypeHelpers__GetNiceTypeName
		                      (*(undefined4 *)(param1 + 0x20),param3,0);
		    System_UriBuilder__set_Query(uVar2,uVar4,0);
		  }
		  uVar4 = (**(code **)((ulonglong)*(uint *)(*param1_00 + 0xd8) * 4))
		                    (param1_00,*(undefined4 *)(*param1_00 + 0xdc));
		  System_String__Split(uVar2,uVar4,0);
		  uVar4 = System_UriBuilder__set_Path(uVar2,0);
		  uVar4 = System_Uri__get_PrivateAbsolutePath(uVar4,0);
		  uVar4 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(StringLiteral_17911,uVar4,0);
		  if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		    func_ii_306000(OKG_Logs_Debug_TypeInfo);
		  }
		  System_Collections_Generic_Dictionary_uint__object___get_Count(uVar4,0);
		  uVar2 = System_UriBuilder__set_Path(uVar2,0);
		  uVar2 = System_Uri__get_PrivateAbsolutePath(uVar2,0);
		  Core_ExternAppMethods__OpenPaymentWindow(uVar2,StringLiteral_19433,0,0);
		  return;
		}
		*/

		}

		// Token: 0x060008D0 RID: 2256 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008D0")]
		[Address(RVA = "0x5C5B", Offset = "0x5C5B", VA = "0x5C5B")]
		public void Execute(Uri uri, params object[] args)
		{
		}

		// Token: 0x060008D1 RID: 2257 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008D1")]
		[Address(RVA = "0x5C5C", Offset = "0x5C5C", VA = "0x5C5C")]
		public WikiUriRouter()
		{
		/* --- GHIDRA: .ctor ---
		void UI_Wiki_WikiUriRouter___ctor(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5b8a5 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_ValuePicker_ValuePicker_int___ctor__);
		    DAT_ram_00a5b8a5 = '\x01';
		  }
		  ScreenAdaptation_Common_AppSize__Update(param1,Method_UI_ValuePicker_ValuePicker_int___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x04000334 RID: 820
		[Token(Token = "0x4000334")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string _relativePathTpl;

		// Token: 0x04000335 RID: 821
		[Token(Token = "0x4000335")]
		[FieldOffset(Offset = "0x24")]
		private Uri _uri;

		// Token: 0x04000336 RID: 822
		[Token(Token = "0x4000336")]
		[FieldOffset(Offset = "0x28")]
		private object[] _args;
	}
}
