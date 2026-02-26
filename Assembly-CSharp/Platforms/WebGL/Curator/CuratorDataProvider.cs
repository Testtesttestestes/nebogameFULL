using System;
using Core.Application.Managers.Configuration.Curator;
using Il2CppDummyDll;
using Protocol.Consts;

namespace Platforms.WebGL.Curator
{
	// Token: 0x020000C7 RID: 199
	[Token(Token = "0x20000C7")]
	public class CuratorDataProvider : AbstractCuratorDataProvider
	{
		// Token: 0x0600074C RID: 1868 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600074C")]
		[Address(RVA = "0x225D", Offset = "0x225D", VA = "0x225D")]
		public CuratorDataProvider(ClientPlatform platform, CuratorService service)
		{
		/* --- GHIDRA: .ctor ---
		void Platforms_Android_Curator_CuratorDataProvider___ctor(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a5b840 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&System_Action_OpToken_CuratorJsonMessages_BootAns__HTTPResponse___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Platforms_Android_Curator_CuratorDataProvider__Run_b__4_0__);
		    Mono_Security_ASN1__get_Item
		              (&Core_Application_Managers_Configuration_Curator_CuratorData_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_JsonUtility_FromJson_CuratorDataProvider_BootData___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Utils_OpToken_CuratorJsonMessages_BootAns__HTTPResponse__AddResultHandler__);
		    Mono_Security_ASN1__get_Item(&System_Uri_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4513);
		    DAT_ram_00a5b840 = '\x01';
		  }
		  if (*(int *)(param1 + 0x14) != 0) {
		    Core_Application_Managers_Configuration_Curator_AbstractCuratorDataProvider__RemoveRequestToken
		              (param1,0);
		    return;
		  }
		  iVar1 = UnityEngine_PlayerPrefs__GetString(StringLiteral_4513,0);
		  if (iVar1 != 0) {
		    uVar4 = UnityEngine_PlayerPrefs__GetInt(StringLiteral_4513,0);
		    iVar1 = func_ii_5995(uVar4,
		                         Method_UnityEngine_JsonUtility_FromJson_CuratorDataProvider_BootData___);
		    uVar5 = *(undefined4 *)(iVar1 + 0x10);
		    uVar4 = func_ii_8749(*(undefined4 *)(*(int *)(param1 + 0xc) + 0x10),0);
		    iVar2 = System_Collections_CollectionBase___ctor(uVar5,uVar4,0);
		    if (iVar2 != 0) {
		      uVar5 = *(undefined4 *)(iVar1 + 8);
		      uVar4 = unnamed_function_1417(System_Uri_TypeInfo);
		      UI_Windows_ClosableBaseWindow_object___HandleCloseButton(uVar4,uVar5,0);
		      uVar3 = *(undefined4 *)(iVar1 + 0xc);
		      uVar5 = unnamed_function_1417
		                        (Core_Application_Managers_Configuration_Curator_CuratorData_TypeInfo);
		      Core_Application_Managers_Configuration_Curator_CuratorData___ctor(uVar5,uVar4,uVar3,0);
		      *(undefined4 *)(param1 + 0x14) = uVar5;
		      Core_Application_Managers_Configuration_Curator_AbstractCuratorDataProvider__RemoveRequestToken
		                (param1,0);
		      return;
		    }
		  }
		  uVar4 = *(undefined4 *)(param1 + 0x10);
		  uVar5 = *(undefined4 *)(param1 + 0xc);
		  if (DAT_ram_00a63c4b == '\0') {
		    Mono_Security_ASN1__get_Item(&Localization_Culture_Culture_TypeInfo);
		    DAT_ram_00a63c4b = '\x01';
		  }
		  uVar3 = Gameplay_FeedbackForm_Model_Controll_FeedbackFormController__GetBase64ZipContent
		                    (*(undefined4 *)(*(int *)(Localization_Culture_Culture_TypeInfo + 0x5c) + 4),
		                     param1);
		  uVar4 = Core_Application_Managers_Configuration_Curator_CuratorService__BootInternal
		                    (uVar5,uVar4,uVar3,0);
		  uVar5 = unnamed_function_1417
		                    (System_Action_OpToken_CuratorJsonMessages_BootAns__HTTPResponse___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar5,param1,Method_Platforms_Android_Curator_CuratorDataProvider__Run_b__4_0__,0);
		  uVar4 = ServicesNamespace_MainService__GetUserStats
		                    (uVar4,uVar5,0,
		                     Method_Utils_OpToken_CuratorJsonMessages_BootAns__HTTPResponse__AddResultHandler__
		                    );
		  Core_Application_Managers_Configuration_Curator_AbstractCuratorDataProvider___ctor(param1,uVar4,0)
		  ;
		  return;
		}
		*/

		/* --- GHIDRA: .ctor ---
		void Platforms_Android_Curator_CuratorDataProvider___ctor(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a5b840 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&System_Action_OpToken_CuratorJsonMessages_BootAns__HTTPResponse___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Platforms_Android_Curator_CuratorDataProvider__Run_b__4_0__);
		    Mono_Security_ASN1__get_Item
		              (&Core_Application_Managers_Configuration_Curator_CuratorData_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_JsonUtility_FromJson_CuratorDataProvider_BootData___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Utils_OpToken_CuratorJsonMessages_BootAns__HTTPResponse__AddResultHandler__);
		    Mono_Security_ASN1__get_Item(&System_Uri_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4513);
		    DAT_ram_00a5b840 = '\x01';
		  }
		  if (*(int *)(param1 + 0x14) != 0) {
		    Core_Application_Managers_Configuration_Curator_AbstractCuratorDataProvider__RemoveRequestToken
		              (param1,0);
		    return;
		  }
		  iVar1 = UnityEngine_PlayerPrefs__GetString(StringLiteral_4513,0);
		  if (iVar1 != 0) {
		    uVar4 = UnityEngine_PlayerPrefs__GetInt(StringLiteral_4513,0);
		    iVar1 = func_ii_5995(uVar4,
		                         Method_UnityEngine_JsonUtility_FromJson_CuratorDataProvider_BootData___);
		    uVar5 = *(undefined4 *)(iVar1 + 0x10);
		    uVar4 = func_ii_8749(*(undefined4 *)(*(int *)(param1 + 0xc) + 0x10),0);
		    iVar2 = System_Collections_CollectionBase___ctor(uVar5,uVar4,0);
		    if (iVar2 != 0) {
		      uVar5 = *(undefined4 *)(iVar1 + 8);
		      uVar4 = unnamed_function_1417(System_Uri_TypeInfo);
		      UI_Windows_ClosableBaseWindow_object___HandleCloseButton(uVar4,uVar5,0);
		      uVar3 = *(undefined4 *)(iVar1 + 0xc);
		      uVar5 = unnamed_function_1417
		                        (Core_Application_Managers_Configuration_Curator_CuratorData_TypeInfo);
		      Core_Application_Managers_Configuration_Curator_CuratorData___ctor(uVar5,uVar4,uVar3,0);
		      *(undefined4 *)(param1 + 0x14) = uVar5;
		      Core_Application_Managers_Configuration_Curator_AbstractCuratorDataProvider__RemoveRequestToken
		                (param1,0);
		      return;
		    }
		  }
		  uVar4 = *(undefined4 *)(param1 + 0x10);
		  uVar5 = *(undefined4 *)(param1 + 0xc);
		  if (DAT_ram_00a63c4b == '\0') {
		    Mono_Security_ASN1__get_Item(&Localization_Culture_Culture_TypeInfo);
		    DAT_ram_00a63c4b = '\x01';
		  }
		  uVar3 = Gameplay_FeedbackForm_Model_Controll_FeedbackFormController__GetBase64ZipContent
		                    (*(undefined4 *)(*(int *)(Localization_Culture_Culture_TypeInfo + 0x5c) + 4),
		                     param1);
		  uVar4 = Core_Application_Managers_Configuration_Curator_CuratorService__BootInternal
		                    (uVar5,uVar4,uVar3,0);
		  uVar5 = unnamed_function_1417
		                    (System_Action_OpToken_CuratorJsonMessages_BootAns__HTTPResponse___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar5,param1,Method_Platforms_Android_Curator_CuratorDataProvider__Run_b__4_0__,0);
		  uVar4 = ServicesNamespace_MainService__GetUserStats
		                    (uVar4,uVar5,0,
		                     Method_Utils_OpToken_CuratorJsonMessages_BootAns__HTTPResponse__AddResultHandler__
		                    );
		  Core_Application_Managers_Configuration_Curator_AbstractCuratorDataProvider___ctor(param1,uVar4,0)
		  ;
		  return;
		}
		*/

		/* --- GHIDRA: <Run>b__3_0 ---
		void Platforms_UnityEditor_Curator_CuratorDataProvider___Run_b__3_0
		               (undefined4 *param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5)
		
		{
		  param1[6] = 0;
		  *(undefined8 *)(param1 + 4) = 0x100000004;
		  param1[3] = s_JPEG_parameter_struct_mismatch__l_ram_0000fffe + 3;
		  param1[2] = param4;
		  param1[1] = param3;
		  *param1 = param2;
		  return;
		}
		*/

		/* --- GHIDRA: .ctor ---
		void Platforms_WebGL_Curator_CuratorDataProvider___ctor(undefined4 param1,undefined4 param2)
		
		{
		  System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_TaskAwaiter__UnityServicesInitializer__InitService_d__1_
		            (param1,0);
		  return;
		}
		*/

		/* --- GHIDRA: .ctor ---
		void Platforms_WebGL_Curator_CuratorDataProvider___ctor(undefined4 param1,undefined4 param2)
		
		{
		  System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_TaskAwaiter__UnityServicesInitializer__InitService_d__1_
		            (param1,0);
		  return;
		}
		*/

		}

		// Token: 0x0600074D RID: 1869 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600074D")]
		[Address(RVA = "0x2259", Offset = "0x2259", VA = "0x2259")]
		public CuratorDataProvider(CuratorData data)
		{
		}

		// Token: 0x0600074E RID: 1870 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600074E")]
		[Address(RVA = "0x5B3F", Offset = "0x5B3F", VA = "0x5B3F", Slot = "13")]
		public override void Commit()
		{
		/* --- GHIDRA: Commit ---
		void Platforms_Android_Curator_CuratorDataProvider__Commit
		               (int *param1,int *param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 param4;
		  undefined4 param3_00;
		  
		  if (DAT_ram_00a5b842 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Core_Application_Managers_Configuration_Curator_CuratorData_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Utils_OpToken_CuratorJsonMessages_BootAns__HTTPResponse__get_Result__);
		    Mono_Security_ASN1__get_Item(&System_Uri_TypeInfo);
		    DAT_ram_00a5b842 = '\x01';
		  }
		  Core_Application_Managers_Configuration_Curator_AbstractCuratorDataProvider__AddRequestToken
		            (param1,param2,0);
		  uVar1 = *(undefined4 *)(param2[8] + 8);
		  param1_00 = unnamed_function_1417(System_Uri_TypeInfo);
		  UI_Windows_ClosableBaseWindow_object___HandleCloseButton(param1_00,uVar1,0);
		  iVar2 = param2[8];
		  uVar1 = *(undefined4 *)(iVar2 + 0x14);
		  param4 = *(undefined4 *)(iVar2 + 0x10);
		  param3_00 = *(undefined4 *)(iVar2 + 0xc);
		  iVar2 = unnamed_function_1417
		                    (Core_Application_Managers_Configuration_Curator_CuratorData_TypeInfo);
		  Core_Application_Managers_Configuration_Curator_CuratorData___ctor
		            (iVar2,param1_00,param3_00,param4,uVar1,0);
		  param1[5] = iVar2;
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0x128) * 4))(param1,*(undefined4 *)(*param1 + 300));
		  Core_Application_Managers_Configuration_Curator_AbstractCuratorDataProvider__RemoveRequestToken
		            (param1,0);
		  (**(code **)((ulonglong)*(uint *)(*param2 + 0x108) * 4))(param2,*(undefined4 *)(*param2 + 0x10c));
		  return;
		}
		*/

		/* --- GHIDRA: Commit ---
		void Platforms_UnityEditor_Curator_CuratorDataProvider__Commit(int param1,undefined4 param2)
		
		{
		  undefined4 param3;
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a5b83c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&System_Action_OpToken_CuratorJsonMessages_BootAns__HTTPResponse___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Platforms_UnityEditor_Curator_CuratorDataProvider__Run_b__3_0__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Utils_OpToken_CuratorJsonMessages_BootAns__HTTPResponse__AddResultHandler__);
		    DAT_ram_00a5b83c = '\x01';
		  }
		  uVar1 = *(undefined4 *)(param1 + 0x10);
		  uVar2 = *(undefined4 *)(param1 + 0xc);
		  if (DAT_ram_00a63c4b == '\0') {
		    Mono_Security_ASN1__get_Item(&Localization_Culture_Culture_TypeInfo);
		    DAT_ram_00a63c4b = '\x01';
		  }
		  param3 = Gameplay_FeedbackForm_Model_Controll_FeedbackFormController__GetBase64ZipContent
		                     (*(undefined4 *)(*(int *)(Localization_Culture_Culture_TypeInfo + 0x5c) + 4),
		                      param1);
		  uVar1 = Core_Application_Managers_Configuration_Curator_CuratorService__BootInternal
		                    (uVar2,uVar1,param3,0);
		  uVar2 = unnamed_function_1417
		                    (System_Action_OpToken_CuratorJsonMessages_BootAns__HTTPResponse___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,Method_Platforms_UnityEditor_Curator_CuratorDataProvider__Run_b__3_0__,0);
		  uVar1 = ServicesNamespace_MainService__GetUserStats
		                    (uVar1,uVar2,0,
		                     Method_Utils_OpToken_CuratorJsonMessages_BootAns__HTTPResponse__AddResultHandler__
		                    );
		  Core_Application_Managers_Configuration_Curator_AbstractCuratorDataProvider___ctor(param1,uVar1,0)
		  ;
		  return;
		}
		*/

		/* --- GHIDRA: Commit ---
		undefined4 Platforms_WebGL_Curator_CuratorDataProvider__Commit(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5b833 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_12411);
		    DAT_ram_00a5b833 = '\x01';
		  }
		  return StringLiteral_12411;
		}
		*/

		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: Run ---
		void Platforms_UnityEditor_Curator_CuratorDataProvider__Run
		               (int *param1,int *param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 param4;
		  undefined4 param3_00;
		  
		  if (DAT_ram_00a5b83d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Core_Application_Managers_Configuration_Curator_CuratorData_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Utils_OpToken_CuratorJsonMessages_BootAns__HTTPResponse__get_Result__);
		    Mono_Security_ASN1__get_Item(&System_Uri_TypeInfo);
		    DAT_ram_00a5b83d = '\x01';
		  }
		  Core_Application_Managers_Configuration_Curator_AbstractCuratorDataProvider__AddRequestToken
		            (param1,param2,0);
		  uVar1 = *(undefined4 *)(param2[8] + 8);
		  param1_00 = unnamed_function_1417(System_Uri_TypeInfo);
		  UI_Windows_ClosableBaseWindow_object___HandleCloseButton(param1_00,uVar1,0);
		  iVar2 = param2[8];
		  uVar1 = *(undefined4 *)(iVar2 + 0x14);
		  param4 = *(undefined4 *)(iVar2 + 0x10);
		  param3_00 = *(undefined4 *)(iVar2 + 0xc);
		  iVar2 = unnamed_function_1417
		                    (Core_Application_Managers_Configuration_Curator_CuratorData_TypeInfo);
		  Core_Application_Managers_Configuration_Curator_CuratorData___ctor
		            (iVar2,param1_00,param3_00,param4,uVar1,0);
		  param1[5] = iVar2;
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0x128) * 4))(param1,*(undefined4 *)(*param1 + 300));
		  Core_Application_Managers_Configuration_Curator_AbstractCuratorDataProvider__RemoveRequestToken
		            (param1,0);
		  (**(code **)((ulonglong)*(uint *)(*param2 + 0x108) * 4))(param2,*(undefined4 *)(*param2 + 0x10c));
		  return;
		}
		*/


		/* --- GHIDRA: Run ---
		void Platforms_Android_Curator_CuratorDataProvider__Run(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  int *piVar3;
		  undefined4 uVar4;
		  int iVar5;
		  
		  if (DAT_ram_00a5b841 == '\0') {
		    Mono_Security_ASN1__get_Item(&Platforms_Android_Curator_CuratorDataProvider_BootData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4513);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28662);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5998);
		    DAT_ram_00a5b841 = '\x01';
		  }
		  piVar3 = *(int **)(*(int *)(param1 + 0x14) + 8);
		  iVar5 = *piVar3;
		  uVar1 = (**(code **)((ulonglong)*(uint *)(iVar5 + 0xd8) * 4))
		                    (piVar3,*(undefined4 *)(iVar5 + 0xdc));
		  uVar4 = *(undefined4 *)(*(int *)(param1 + 0x14) + 0x14);
		  uVar2 = func_ii_8749(*(undefined4 *)(*(int *)(param1 + 0xc) + 0x10),0);
		  iVar5 = unnamed_function_1417(Platforms_Android_Curator_CuratorDataProvider_BootData_TypeInfo);
		  *(undefined4 *)(iVar5 + 0x10) = uVar2;
		  *(undefined4 *)(iVar5 + 0xc) = uVar4;
		  *(undefined4 *)(iVar5 + 8) = uVar1;
		  uVar1 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                    (StringLiteral_28662,StringLiteral_5998,iVar5,0);
		  if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		    func_ii_306000(OKG_Logs_Debug_TypeInfo);
		  }
		  System_Collections_Generic_Dictionary_uint__object___get_Count(uVar1,0);
		  uVar1 = UI_Preloader_PreloaderBackgroundLoader_PreloaderBackgroundDto___ctor(iVar5,0);
		  func_ii_7893(StringLiteral_4513,uVar1,0);
		  func_ii_10838(0);
		  return;
		}
		*/

}
