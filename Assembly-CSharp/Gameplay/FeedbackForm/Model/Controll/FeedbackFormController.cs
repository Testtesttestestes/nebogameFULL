using System;
using BestHTTP;
using Gameplay.FeedbackForm.Service;
using Il2CppDummyDll;
using MVC;
using Utils;

namespace Gameplay.FeedbackForm.Model.Controll
{
	// Token: 0x02000827 RID: 2087
	[Token(Token = "0x2000827")]
	public class FeedbackFormController : AbstractController<FeedbackFormModel, FeedbackFormEvents>
	{
		// Token: 0x06003128 RID: 12584 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003128")]
		[Address(RVA = "0x8181", Offset = "0x8181", VA = "0x8181", Slot = "5")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_FeedbackForm_Model_Controll_FeedbackFormController__Dispose
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  if (DAT_ram_00a57607 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_MVC_AbstractController_FeedbackFormModel__FeedbackFormEvents___ctor__);
		    DAT_ram_00a57607 = '\x01';
		  }
		  Gameplay_Combat_AbstractCombat_object__object__object__object__object___set_User
		            (param1,param3,param4,
		             Method_MVC_AbstractController_FeedbackFormModel__FeedbackFormEvents___ctor__);
		  *(undefined4 *)(param1 + 0x18) = param2;
		  return;
		}
		*/

		}

		// Token: 0x06003129 RID: 12585 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003129")]
		[Address(RVA = "0x8182", Offset = "0x8182", VA = "0x8182")]
		public FeedbackFormController(FeedbackFormService service, FeedbackFormModel model, FeedbackFormEvents events)
		{
		}

		// Token: 0x0600312A RID: 12586 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600312A")]
		[Address(RVA = "0x8183", Offset = "0x8183", VA = "0x8183", Slot = "7")]
		protected override void HandleRun()
		{
		/* --- GHIDRA: HandleRun ---
		/* WARNING: Removing unreachable block (ram,0x80db63bf) */
		/* WARNING: Removing unreachable block (ram,0x80db607a) */
		
		void Gameplay_FeedbackForm_Model_Controll_FeedbackFormController__HandleRun
		               (int *param1,int param2,undefined4 param3,undefined4 param4,undefined4 param5,
		               undefined4 param6)
		
		{
		  undefined1 uVar1;
		  uint uVar2;
		  int iVar3;
		  int *piVar4;
		  undefined4 uVar5;
		  int iVar6;
		  undefined4 uVar7;
		  int iVar8;
		  undefined4 *puVar9;
		  undefined4 *param2_00;
		  undefined4 uVar10;
		  int *local_4;
		  
		  if (DAT_ram_00a57608 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_int__HTTPResponse___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_FeedbackForm_Model_Controll_FeedbackFormController_HandleSubmitFormFailed__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_FeedbackForm_Model_Controll_FeedbackFormController_HandleSubmitFormSuccess__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_FeedbackForm_Service_ServiceMessages_FeedbackFormMessage_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_Managers_IClientVersionProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Core_Application_Managers_Configuration_Curator_ICuratorDataProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_FeedbackForm_Model_Source_IFeedbackFormSource_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Core_Gameplay_Managers_Configuration_IPlatformConfigurationProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_Managers_IPlatformSigninProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_int__HTTPResponse__AddHandlers__);
		    DAT_ram_00a57608 = '\x01';
		  }
		  local_4 = (int *)0x0;
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if (*(int *)(iVar3 + 0x14) != 0) {
		    return;
		  }
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar3 = *(int *)(iVar3 + 0xc);
		  (**(code **)((ulonglong)*(uint *)(iVar3 + 0xc) * 4))
		            (*(undefined4 *)(iVar3 + 0x20),*(undefined4 *)(iVar3 + 0x14));
		  uVar1 = *(undefined1 *)(param2 + 0x20);
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_000017c8 + 799,0);
		  iVar3 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar3 == 1) {
		    uVar7 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  }
		  else {
		    DAT_ram_009d3e38 = 0;
		    uVar7 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x321,param1,param1);
		    iVar3 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar3 == 1) {
		      uVar7 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    }
		    else {
		      if (DAT_ram_00a63c4b == '\0') {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vi(0x7ff,&Localization_Culture_Culture_TypeInfo);
		        iVar3 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar3 == 1) {
		          uVar7 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80db70ce;
		        }
		        DAT_ram_00a63c4b = '\x01';
		      }
		      DAT_ram_009d3e38 = 0;
		      piVar4 = (int *)import::env::invoke_iii
		                                (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x322,
		                                 *(undefined4 *)
		                                  (*(int *)(Localization_Culture_Culture_TypeInfo + 0x5c) + 4),0);
		      iVar3 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar3 == 1) {
		        uVar7 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      }
		      else {
		        DAT_ram_009d3e38 = 0;
		        uVar10 = import::env::invoke_iii
		                           (*(undefined4 *)(*piVar4 + 0xf8),piVar4,*(undefined4 *)(*piVar4 + 0xfc));
		        iVar3 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar3 == 1) {
		          uVar7 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        }
		        else {
		          DAT_ram_009d3e38 = 0;
		          iVar8 = import::env::invoke_iii
		                            (*(undefined4 *)(*param1 + 0x100),param1,
		                             *(undefined4 *)(*param1 + 0x104));
		          iVar3 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar3 == 1) {
		            uVar7 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          }
		          else {
		            piVar4 = *(int **)(iVar8 + 0x18);
		            iVar3 = *piVar4;
		            if (*(ushort *)(iVar3 + 0xb6) != 0) {
		              uVar2 = 0;
		              do {
		                if (Gameplay_FeedbackForm_Model_Source_IFeedbackFormSource_TypeInfo ==
		                    *(int *)(*(int *)(iVar3 + 0x58) + uVar2 * 8)) {
		                  puVar9 = (undefined4 *)
		                           (*(int *)(*(int *)(iVar3 + 0x58) + uVar2 * 8 + 4) * 8 + iVar3 + 0xe8);
		                  goto code_r0x80db6256;
		                }
		                uVar2 = uVar2 + 1;
		              } while (*(ushort *)(iVar3 + 0xb6) != uVar2);
		            }
		            DAT_ram_009d3e38 = 0;
		            puVar9 = (undefined4 *)
		                     import::env::invoke_iiii
		                               (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar4,
		                                Gameplay_FeedbackForm_Model_Source_IFeedbackFormSource_TypeInfo,5);
		            if (DAT_ram_009d3e38 != 1) {
		code_r0x80db6256:
		              DAT_ram_009d3e38 = 0;
		              piVar4 = (int *)import::env::invoke_iii(*puVar9,piVar4,puVar9[1]);
		              if (DAT_ram_009d3e38 != 1) {
		                iVar3 = *piVar4;
		                if (*(ushort *)(iVar3 + 0xb6) != 0) {
		                  uVar2 = 0;
		                  do {
		                    if (Core_Application_Managers_IClientVersionProvider_TypeInfo ==
		                        *(int *)(*(int *)(iVar3 + 0x58) + uVar2 * 8)) {
		                      puVar9 = (undefined4 *)
		                               (iVar3 + *(int *)(*(int *)(iVar3 + 0x58) + uVar2 * 8 + 4) * 8 + 0xc0)
		                      ;
		                      goto code_r0x80db632b;
		                    }
		                    uVar2 = uVar2 + 1;
		                  } while (*(ushort *)(iVar3 + 0xb6) != uVar2);
		                }
		                DAT_ram_009d3e38 = 0;
		                puVar9 = (undefined4 *)
		                         import::env::invoke_iiii
		                                   (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar4,
		                                    Core_Application_Managers_IClientVersionProvider_TypeInfo,0);
		                if (DAT_ram_009d3e38 != 1) {
		code_r0x80db632b:
		                  DAT_ram_009d3e38 = 0;
		                  uVar5 = import::env::invoke_iii(*puVar9,piVar4,puVar9[1]);
		                  if (DAT_ram_009d3e38 != 1) {
		                    DAT_ram_009d3e38 = 0;
		                    iVar3 = import::env::invoke_ii
		                                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                                       Gameplay_FeedbackForm_Service_ServiceMessages_FeedbackFormMessage_TypeInfo
		                                      );
		                    if (DAT_ram_009d3e38 == 1) {
		                      DAT_ram_009d3e38 = 0;
		                      uVar7 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                    }
		                    else {
		                      *(undefined4 *)(iVar3 + 0x18) = uVar5;
		                      *(undefined4 *)(iVar3 + 0x14) = uVar10;
		                      *(undefined4 *)(iVar3 + 0x10) = uVar7;
		                      *(undefined4 *)(iVar3 + 0xc) = 1;
		                      *(undefined1 *)(iVar3 + 8) = uVar1;
		                      DAT_ram_009d3e38 = 0;
		                      uVar7 = import::env::invoke_iii
		                                        (*(undefined4 *)(*param1 + 0x100),param1,
		                                         *(undefined4 *)(*param1 + 0x104));
		                      iVar8 = DAT_ram_009d3e38;
		                      DAT_ram_009d3e38 = 0;
		                      if (iVar8 == 1) {
		                        uVar7 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                      }
		                      else {
		                        DAT_ram_009d3e38 = 0;
		                        uVar7 = import::env::invoke_iii
		                                          (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x323,
		                                           uVar7,param1);
		                        iVar8 = DAT_ram_009d3e38;
		                        DAT_ram_009d3e38 = 0;
		                        if (iVar8 == 1) {
		                          uVar7 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                        }
		                        else {
		                          *(undefined4 *)(iVar3 + 0x30) = param5;
		                          *(undefined4 *)(iVar3 + 0x2c) = param3;
		                          *(undefined4 *)(iVar3 + 0x28) = param4;
		                          *(undefined4 *)(iVar3 + 0x24) = uVar7;
		                          DAT_ram_009d3e38 = 0;
		                          iVar6 = import::env::invoke_iii
		                                            (*(undefined4 *)(*param1 + 0x100),param1,
		                                             *(undefined4 *)(*param1 + 0x104));
		                          iVar8 = DAT_ram_009d3e38;
		                          DAT_ram_009d3e38 = 0;
		                          if (iVar8 == 1) {
		                            uVar7 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                          }
		                          else {
		                            uVar2 = 0;
		                            piVar4 = *(int **)(iVar6 + 0x18);
		                            iVar8 = *piVar4;
		                            if (*(ushort *)(iVar8 + 0xb6) != 0) {
		                              do {
		                                if (Gameplay_FeedbackForm_Model_Source_IFeedbackFormSource_TypeInfo
		                                    == *(int *)(*(int *)(iVar8 + 0x58) + uVar2 * 8)) {
		                                  puVar9 = (undefined4 *)
		                                           (*(int *)(*(int *)(iVar8 + 0x58) + uVar2 * 8 + 4) * 8 +
		                                            iVar8 + 0xf0);
		                                  goto code_r0x80db6555;
		                                }
		                                uVar2 = uVar2 + 1;
		                              } while (*(ushort *)(iVar8 + 0xb6) != uVar2);
		                            }
		                            DAT_ram_009d3e38 = 0;
		                            puVar9 = (undefined4 *)
		                                     import::env::invoke_iiii
		                                               (s_Allocator__0___Blocksize__1__mus_ram_00000421 +
		                                                0x18,piVar4,
		                                                Gameplay_FeedbackForm_Model_Source_IFeedbackFormSource_TypeInfo
		                                                ,6);
		                            if (DAT_ram_009d3e38 != 1) {
		code_r0x80db6555:
		                              DAT_ram_009d3e38 = 0;
		                              iVar8 = import::env::invoke_iii(*puVar9,piVar4,puVar9[1]);
		                              if (DAT_ram_009d3e38 != 1) {
		                                if (iVar8 == 0) goto code_r0x80db6a35;
		                                DAT_ram_009d3e38 = 0;
		                                iVar6 = import::env::invoke_iii
		                                                  (*(undefined4 *)(*param1 + 0x100),param1,
		                                                   *(undefined4 *)(*param1 + 0x104));
		                                iVar8 = DAT_ram_009d3e38;
		                                DAT_ram_009d3e38 = 0;
		                                if (iVar8 == 1) {
		                                  uVar7 = import::env::__cxa_find_matching_catch_3
		                                                    (&DAT_ram_0072c9c8);
		                                  goto code_r0x80db70ce;
		                                }
		                                piVar4 = *(int **)(iVar6 + 0x18);
		                                iVar8 = *piVar4;
		                                if (*(ushort *)(iVar8 + 0xb6) != 0) {
		                                  uVar2 = 0;
		                                  do {
		                                    if (Gameplay_FeedbackForm_Model_Source_IFeedbackFormSource_TypeInfo
		                                        == *(int *)(*(int *)(iVar8 + 0x58) + uVar2 * 8)) {
		                                      puVar9 = (undefined4 *)
		                                               (*(int *)(*(int *)(iVar8 + 0x58) + uVar2 * 8 + 4) * 8
		                                                + iVar8 + 0xf0);
		                                      goto code_r0x80db6703;
		                                    }
		                                    uVar2 = uVar2 + 1;
		                                  } while (*(ushort *)(iVar8 + 0xb6) != uVar2);
		                                }
		                                DAT_ram_009d3e38 = 0;
		                                puVar9 = (undefined4 *)
		                                         import::env::invoke_iiii
		                                                   (s_Allocator__0___Blocksize__1__mus_ram_00000421
		                                                    + 0x18,piVar4,
		                                                                                                        
		                                                  Gameplay_FeedbackForm_Model_Source_IFeedbackFormSource_TypeInfo
		                                                  ,6);
		                                if (DAT_ram_009d3e38 != 1) {
		code_r0x80db6703:
		                                  DAT_ram_009d3e38 = 0;
		                                  piVar4 = (int *)import::env::invoke_iii(*puVar9,piVar4,puVar9[1]);
		                                  if (DAT_ram_009d3e38 != 1) {
		                                    iVar8 = *piVar4;
		                                    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		                                      uVar2 = 0;
		                                      do {
		                                        if (Core_Application_Managers_IPlatformSigninProvider_TypeInfo
		                                            == *(int *)(*(int *)(iVar8 + 0x58) + uVar2 * 8)) {
		                                          puVar9 = (undefined4 *)
		                                                   (*(int *)(*(int *)(iVar8 + 0x58) + uVar2 * 8 + 4)
		                                                    * 8 + iVar8 + 0xd0);
		                                          goto code_r0x80db67d8;
		                                        }
		                                        uVar2 = uVar2 + 1;
		                                      } while (*(ushort *)(iVar8 + 0xb6) != uVar2);
		                                    }
		                                    DAT_ram_009d3e38 = 0;
		                                    puVar9 = (undefined4 *)
		                                             import::env::invoke_iiii
		                                                       (
		                                                  s_Allocator__0___Blocksize__1__mus_ram_00000421 +
		                                                  0x18,piVar4,
		                                                  Core_Application_Managers_IPlatformSigninProvider_TypeInfo
		                                                  ,2);
		                                    if (DAT_ram_009d3e38 != 1) {
		code_r0x80db67d8:
		                                      DAT_ram_009d3e38 = 0;
		                                      iVar8 = import::env::invoke_iii(*puVar9,piVar4,puVar9[1]);
		                                      if (DAT_ram_009d3e38 != 1) {
		                                        if (iVar8 == 0) {
		code_r0x80db6a35:
		                                          DAT_ram_009d3e38 = 0;
		                                          iVar6 = import::env::invoke_iii
		                                                            (*(undefined4 *)(*param1 + 0x100),param1
		                                                             ,*(undefined4 *)(*param1 + 0x104));
		                                          iVar8 = DAT_ram_009d3e38;
		                                          DAT_ram_009d3e38 = 0;
		                                          if (iVar8 == 1) {
		                                            uVar7 = import::env::__cxa_find_matching_catch_3
		                                                              (&DAT_ram_0072c9c8);
		                                          }
		                                          else {
		                                            piVar4 = *(int **)(iVar6 + 0x18);
		                                            iVar8 = *piVar4;
		                                            if (*(ushort *)(iVar8 + 0xb6) != 0) {
		                                              uVar2 = 0;
		                                              do {
		                                                if (
		                                                  Gameplay_FeedbackForm_Model_Source_IFeedbackFormSource_TypeInfo
		                                                  == *(int *)(*(int *)(iVar8 + 0x58) + uVar2 * 8)) {
		                                                  puVar9 = (undefined4 *)
		                                                           (*(int *)(*(int *)(iVar8 + 0x58) +
		                                                                     uVar2 * 8 + 4) * 8 + iVar8 +
		                                                           0xe0);
		                                                  goto code_r0x80db6b16;
		                                                }
		                                                uVar2 = uVar2 + 1;
		                                              } while (*(ushort *)(iVar8 + 0xb6) != uVar2);
		                                            }
		                                            DAT_ram_009d3e38 = 0;
		                                            puVar9 = (undefined4 *)
		                                                     import::env::invoke_iiii
		                                                               (
		                                                  s_Allocator__0___Blocksize__1__mus_ram_00000421 +
		                                                  0x18,piVar4,
		                                                  Gameplay_FeedbackForm_Model_Source_IFeedbackFormSource_TypeInfo
		                                                  ,4);
		                                            if (DAT_ram_009d3e38 != 1) {
		code_r0x80db6b16:
		                                              DAT_ram_009d3e38 = 0;
		                                              piVar4 = (int *)import::env::invoke_iii
		                                                                        (*puVar9,piVar4,puVar9[1]);
		                                              if (DAT_ram_009d3e38 != 1) {
		                                                iVar8 = *piVar4;
		                                                if (*(ushort *)(iVar8 + 0xb6) != 0) {
		                                                  uVar2 = 0;
		                                                  do {
		                                                    if (
		                                                  Core_Gameplay_Managers_Configuration_IPlatformConfigurationProvider_TypeInfo
		                                                  == *(int *)(*(int *)(iVar8 + 0x58) + uVar2 * 8)) {
		                                                    puVar9 = (undefined4 *)
		                                                             (*(int *)(*(int *)(iVar8 + 0x58) +
		                                                                       uVar2 * 8 + 4) * 8 + iVar8 +
		                                                             0xe8);
		                                                    goto code_r0x80db6beb;
		                                                  }
		                                                  uVar2 = uVar2 + 1;
		                                                  } while (*(ushort *)(iVar8 + 0xb6) != uVar2);
		                                                }
		                                                DAT_ram_009d3e38 = 0;
		                                                puVar9 = (undefined4 *)
		                                                         import::env::invoke_iiii
		                                                                   (
		                                                  s_Allocator__0___Blocksize__1__mus_ram_00000421 +
		                                                  0x18,piVar4,
		                                                  Core_Gameplay_Managers_Configuration_IPlatformConfigurationProvider_TypeInfo
		                                                  ,5);
		                                                if (DAT_ram_009d3e38 != 1) {
		code_r0x80db6beb:
		                                                  DAT_ram_009d3e38 = 0;
		                                                  iVar8 = import::env::invoke_iiii
		                                                                    (*puVar9,piVar4,&local_4,
		                                                                     puVar9[1]);
		                                                  piVar4 = local_4;
		                                                  if (DAT_ram_009d3e38 != 1) {
		                                                    if (iVar8 == 0) {
		code_r0x80db6d52:
		                                                      DAT_ram_009d3e38 = 0;
		                                                      iVar6 = import::env::invoke_iii
		                                                                        (*(undefined4 *)
		                                                                          (*param1 + 0x100),param1,
		                                                                         *(undefined4 *)
		                                                                          (*param1 + 0x104));
		                                                      iVar8 = DAT_ram_009d3e38;
		                                                      DAT_ram_009d3e38 = 0;
		                                                      if (iVar8 == 1) {
		                                                        uVar7 = import::env::
		                                                                __cxa_find_matching_catch_3
		                                                                          (&DAT_ram_0072c9c8);
		                                                      }
		                                                      else {
		                                                        iVar8 = param1[6];
		                                                        if (DAT_ram_00a575f6 == '\0') {
		                                                          DAT_ram_009d3e38 = 0;
		                                                          import::env::invoke_vi
		                                                                    (0x7ff,&
		                                                  Method_Utils_OpToken_int__HTTPResponse___ctor__);
		                                                  if (DAT_ram_009d3e38 != 1) {
		                                                    DAT_ram_009d3e38 = 0;
		                                                    import::env::invoke_vi
		                                                              (0x7ff,&
		                                                  Utils_OpToken_int__HTTPResponse__TypeInfo);
		                                                  if (DAT_ram_009d3e38 != 1) {
		                                                    DAT_ram_00a575f6 = '\x01';
		                                                    goto code_r0x80db6e11;
		                                                  }
		                                                  }
		                                                  }
		                                                  else {
		code_r0x80db6e11:
		                                                    DAT_ram_009d3e38 = 0;
		                                                    piVar4 = (int *)import::env::invoke_ii
		                                                                              (
		                                                  s_var<private>_posTex__array<vec4<_ram_00000655 +
		                                                  0x199,Utils_OpToken_int__HTTPResponse__TypeInfo);
		                                                  if (DAT_ram_009d3e38 != 1) {
		                                                    DAT_ram_009d3e38 = 0;
		                                                                                                        
		                                                  Gameplay_FeedbackForm_Model_FeedbackFormModel__GetUid
		                                                            (piVar4,
		                                                  Method_Utils_OpToken_int__HTTPResponse___ctor__);
		                                                  if (DAT_ram_009d3e38 != 1) {
		                                                    DAT_ram_009d3e38 = 0;
		                                                    import::env::invoke_vii
		                                                              (*(undefined4 *)(*piVar4 + 0x110),
		                                                               piVar4,*(undefined4 *)
		                                                                       (*piVar4 + 0x114));
		                                                    if (DAT_ram_009d3e38 != 1) {
		                                                      DAT_ram_009d3e38 = 0;
		                                                      import::env::invoke_viiii
		                                                                (
		                                                  s_struct_Uniforms___color__array<v_ram_000017c8 +
		                                                  0x325,iVar8,piVar4,iVar3,param1);
		                                                  if (DAT_ram_009d3e38 != 1) {
		                                                    DAT_ram_009d3e38 = 0;
		                                                    uVar7 = import::env::invoke_ii
		                                                                      (
		                                                  s_var<private>_posTex__array<vec4<_ram_00000655 +
		                                                  0x199,
		                                                  System_Action_OpToken_int__HTTPResponse___TypeInfo
		                                                  );
		                                                  if (DAT_ram_009d3e38 != 1) {
		                                                    DAT_ram_009d3e38 = 0;
		                                                    import::env::invoke_viiii
		                                                              (
		                                                  s_struct_Uniforms___color__array<v_ram_000017c8 +
		                                                  0x241,uVar7,param1,
		                                                  Method_Gameplay_FeedbackForm_Model_Controll_FeedbackFormController_HandleSubmitFormSuccess__
		                                                  ,0);
		                                                  if (DAT_ram_009d3e38 != 1) {
		                                                    DAT_ram_009d3e38 = 0;
		                                                    uVar10 = import::env::invoke_ii
		                                                                       (
		                                                  s_var<private>_posTex__array<vec4<_ram_00000655 +
		                                                  0x199,
		                                                  System_Action_OpToken_int__HTTPResponse___TypeInfo
		                                                  );
		                                                  if (DAT_ram_009d3e38 != 1) {
		                                                    DAT_ram_009d3e38 = 0;
		                                                    import::env::invoke_viiii
		                                                              (
		                                                  s_struct_Uniforms___color__array<v_ram_000017c8 +
		                                                  0x241,uVar10,param1,
		                                                  Method_Gameplay_FeedbackForm_Model_Controll_FeedbackFormController_HandleSubmitFormFailed__
		                                                  ,0);
		                                                  if (DAT_ram_009d3e38 != 1) {
		                                                    DAT_ram_009d3e38 = 0;
		                                                    uVar7 = import::env::invoke_iiiii
		                                                                      (
		                                                  s_struct_Uniforms___color__array<v_ram_000017c8 +
		                                                  0x326,piVar4,uVar7,uVar10,
		                                                  Method_Utils_OpToken_int__HTTPResponse__AddHandlers__
		                                                  );
		                                                  iVar3 = DAT_ram_009d3e38;
		                                                  DAT_ram_009d3e38 = 0;
		                                                  if (iVar3 == 1) {
		                                                    uVar7 = import::env::__cxa_find_matching_catch_3
		                                                                      (&DAT_ram_0072c9c8);
		                                                  }
		                                                  else {
		                                                    *(undefined4 *)(iVar6 + 0x14) = uVar7;
		                                                    DAT_ram_009d3e38 = 0;
		                                                    iVar8 = import::env::invoke_iii
		                                                                      (*(undefined4 *)
		                                                                        (*param1 + 0x100),param1,
		                                                                       *(undefined4 *)
		                                                                        (*param1 + 0x104));
		                                                    iVar3 = DAT_ram_009d3e38;
		                                                    DAT_ram_009d3e38 = 0;
		                                                    if (iVar3 == 1) {
		                                                      uVar7 = import::env::
		                                                              __cxa_find_matching_catch_3
		                                                                        (&DAT_ram_0072c9c8);
		                                                    }
		                                                    else {
		                                                      DAT_ram_009d3e38 = 0;
		                                                      import::env::invoke_viii
		                                                                (
		                                                  s_struct_Uniforms___color__array<v_ram_000017c8 +
		                                                  0x327,param1,*(undefined4 *)(iVar8 + 0x14),0);
		                                                  iVar3 = DAT_ram_009d3e38;
		                                                  DAT_ram_009d3e38 = 0;
		                                                  if (iVar3 != 1) {
		                                                    DAT_ram_009d3e38 = 0;
		                                                    return;
		                                                  }
		                                                  uVar7 = import::env::__cxa_find_matching_catch_3
		                                                                    (&DAT_ram_0072c9c8);
		                                                  }
		                                                  }
		                                                  goto code_r0x80db70ce;
		                                                  }
		                                                  }
		                                                  DAT_ram_009d3e38 = 0;
		                                                  uVar7 = import::env::__cxa_find_matching_catch_3
		                                                                    (&DAT_ram_0072c9c8);
		                                                  goto code_r0x80db70ce;
		                                                  }
		                                                  }
		                                                  DAT_ram_009d3e38 = 0;
		                                                  uVar7 = import::env::__cxa_find_matching_catch_3
		                                                                    (&DAT_ram_0072c9c8);
		                                                  goto code_r0x80db70ce;
		                                                  }
		                                                  }
		                                                  }
		                                                  }
		                                                  }
		                                                  DAT_ram_009d3e38 = 0;
		                                                  uVar7 = import::env::__cxa_find_matching_catch_3
		                                                                    (&DAT_ram_0072c9c8);
		                                                  }
		                                                  }
		                                                  else {
		                                                    uVar2 = 0;
		                                                    iVar8 = *local_4;
		                                                    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		                                                      do {
		                                                        if (
		                                                  Core_Application_Managers_Configuration_Curator_ICuratorDataProvider_TypeInfo
		                                                  == *(int *)(*(int *)(iVar8 + 0x58) + uVar2 * 8)) {
		                                                    puVar9 = (undefined4 *)
		                                                             (*(int *)(*(int *)(iVar8 + 0x58) +
		                                                                       uVar2 * 8 + 4) * 8 + iVar8 +
		                                                             0xd0);
		                                                    goto code_r0x80db6d0a;
		                                                  }
		                                                  uVar2 = uVar2 + 1;
		                                                  } while (*(ushort *)(iVar8 + 0xb6) != uVar2);
		                                                  }
		                                                  DAT_ram_009d3e38 = 0;
		                                                  puVar9 = (undefined4 *)
		                                                           import::env::invoke_iiii
		                                                                     (
		                                                  s_Allocator__0___Blocksize__1__mus_ram_00000421 +
		                                                  0x18,local_4,
		                                                  Core_Application_Managers_Configuration_Curator_ICuratorDataProvider_TypeInfo
		                                                  ,2);
		                                                  if (DAT_ram_009d3e38 != 1) {
		code_r0x80db6d0a:
		                                                    DAT_ram_009d3e38 = 0;
		                                                    iVar8 = import::env::invoke_iii
		                                                                      (*puVar9,piVar4,puVar9[1]);
		                                                    if (DAT_ram_009d3e38 != 1) {
		                                                      *(undefined4 *)(iVar3 + 0x20) =
		                                                           *(undefined4 *)(iVar8 + 0x14);
		                                                      goto code_r0x80db6d52;
		                                                    }
		                                                  }
		                                                  DAT_ram_009d3e38 = 0;
		                                                  uVar7 = import::env::__cxa_find_matching_catch_3
		                                                                    (&DAT_ram_0072c9c8);
		                                                  }
		                                                  goto code_r0x80db70ce;
		                                                  }
		                                                }
		                                                DAT_ram_009d3e38 = 0;
		                                                uVar7 = import::env::__cxa_find_matching_catch_3
		                                                                  (&DAT_ram_0072c9c8);
		                                                goto code_r0x80db70ce;
		                                              }
		                                            }
		                                            DAT_ram_009d3e38 = 0;
		                                            uVar7 = import::env::__cxa_find_matching_catch_3
		                                                              (&DAT_ram_0072c9c8);
		                                          }
		                                        }
		                                        else {
		                                          DAT_ram_009d3e38 = 0;
		                                          iVar6 = import::env::invoke_iii
		                                                            (*(undefined4 *)(*param1 + 0x100),param1
		                                                             ,*(undefined4 *)(*param1 + 0x104));
		                                          iVar8 = DAT_ram_009d3e38;
		                                          DAT_ram_009d3e38 = 0;
		                                          if (iVar8 == 1) {
		                                            uVar7 = import::env::__cxa_find_matching_catch_3
		                                                              (&DAT_ram_0072c9c8);
		                                            goto code_r0x80db70ce;
		                                          }
		                                          piVar4 = *(int **)(iVar6 + 0x18);
		                                          iVar8 = *piVar4;
		                                          if (*(ushort *)(iVar8 + 0xb6) != 0) {
		                                            uVar2 = 0;
		                                            do {
		                                              if (Gameplay_FeedbackForm_Model_Source_IFeedbackFormSource_TypeInfo
		                                                  == *(int *)(*(int *)(iVar8 + 0x58) + uVar2 * 8)) {
		                                                puVar9 = (undefined4 *)
		                                                         (*(int *)(*(int *)(iVar8 + 0x58) +
		                                                                   uVar2 * 8 + 4) * 8 + iVar8 + 0xf0
		                                                         );
		                                                goto code_r0x80db6918;
		                                              }
		                                              uVar2 = uVar2 + 1;
		                                            } while (*(ushort *)(iVar8 + 0xb6) != uVar2);
		                                          }
		                                          DAT_ram_009d3e38 = 0;
		                                          puVar9 = (undefined4 *)
		                                                   import::env::invoke_iiii
		                                                             (
		                                                  s_Allocator__0___Blocksize__1__mus_ram_00000421 +
		                                                  0x18,piVar4,
		                                                  Gameplay_FeedbackForm_Model_Source_IFeedbackFormSource_TypeInfo
		                                                  ,6);
		                                          if (DAT_ram_009d3e38 != 1) {
		code_r0x80db6918:
		                                            DAT_ram_009d3e38 = 0;
		                                            piVar4 = (int *)import::env::invoke_iii
		                                                                      (*puVar9,piVar4,puVar9[1]);
		                                            if (DAT_ram_009d3e38 != 1) {
		                                              iVar8 = *piVar4;
		                                              if (*(ushort *)(iVar8 + 0xb6) != 0) {
		                                                uVar2 = 0;
		                                                do {
		                                                  if (
		                                                  Core_Application_Managers_IPlatformSigninProvider_TypeInfo
		                                                  == *(int *)(*(int *)(iVar8 + 0x58) + uVar2 * 8)) {
		                                                    puVar9 = (undefined4 *)
		                                                             (*(int *)(*(int *)(iVar8 + 0x58) +
		                                                                       uVar2 * 8 + 4) * 8 + iVar8 +
		                                                             0xd0);
		                                                    goto code_r0x80db69ed;
		                                                  }
		                                                  uVar2 = uVar2 + 1;
		                                                } while (*(ushort *)(iVar8 + 0xb6) != uVar2);
		                                              }
		                                              DAT_ram_009d3e38 = 0;
		                                              puVar9 = (undefined4 *)
		                                                       import::env::invoke_iiii
		                                                                 (
		                                                  s_Allocator__0___Blocksize__1__mus_ram_00000421 +
		                                                  0x18,piVar4,
		                                                  Core_Application_Managers_IPlatformSigninProvider_TypeInfo
		                                                  ,2);
		                                              if (DAT_ram_009d3e38 != 1) {
		code_r0x80db69ed:
		                                                DAT_ram_009d3e38 = 0;
		                                                iVar8 = import::env::invoke_iii
		                                                                  (*puVar9,piVar4,puVar9[1]);
		                                                if (DAT_ram_009d3e38 != 1) {
		                                                  *(undefined4 *)(iVar3 + 0x1c) =
		                                                       *(undefined4 *)(iVar8 + 0xc);
		                                                  goto code_r0x80db6a35;
		                                                }
		                                              }
		                                              DAT_ram_009d3e38 = 0;
		                                              uVar7 = import::env::__cxa_find_matching_catch_3
		                                                                (&DAT_ram_0072c9c8);
		                                              goto code_r0x80db70ce;
		                                            }
		                                          }
		                                          DAT_ram_009d3e38 = 0;
		                                          uVar7 = import::env::__cxa_find_matching_catch_3
		                                                            (&DAT_ram_0072c9c8);
		                                        }
		                                        goto code_r0x80db70ce;
		                                      }
		                                    }
		                                    DAT_ram_009d3e38 = 0;
		                                    uVar7 = import::env::__cxa_find_matching_catch_3
		                                                      (&DAT_ram_0072c9c8);
		                                    goto code_r0x80db70ce;
		                                  }
		                                }
		                                DAT_ram_009d3e38 = 0;
		                                uVar7 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                                goto code_r0x80db70ce;
		                              }
		                            }
		                            DAT_ram_009d3e38 = 0;
		                            uVar7 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                          }
		                        }
		                      }
		                    }
		                    goto code_r0x80db70ce;
		                  }
		                }
		                DAT_ram_009d3e38 = 0;
		                uVar7 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                goto code_r0x80db70ce;
		              }
		            }
		            DAT_ram_009d3e38 = 0;
		            uVar7 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          }
		        }
		      }
		    }
		  }
		code_r0x80db70ce:
		  iVar3 = global_1;
		  iVar8 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar3 == iVar8) {
		    puVar9 = (undefined4 *)import::env::__cxa_begin_catch(uVar7);
		    DAT_ram_009d3e38 = 0;
		    uVar7 = import::env::invoke_ii
		                      (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1c,
		                       &System_Exception_TypeInfo);
		    if (DAT_ram_009d3e38 != 1) {
		      DAT_ram_009d3e38 = 0;
		      iVar8 = import::env::invoke_iii
		                        (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1d,uVar7,
		                         *(undefined4 *)*puVar9);
		      iVar3 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar3 != 1) {
		        if (iVar8 != 0) {
		          uVar10 = *puVar9;
		          import::env::__cxa_end_catch();
		          iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                            (param1,*(undefined4 *)(*param1 + 0x104));
		          *(undefined4 *)(iVar3 + 0x14) = 0;
		          iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                            (param1,*(undefined4 *)(*param1 + 0x114));
		          iVar3 = *(int *)(iVar3 + 0x10);
		          (**(code **)((ulonglong)*(uint *)(iVar3 + 0xc) * 4))
		                    (*(undefined4 *)(iVar3 + 0x20),*(undefined4 *)(iVar3 + 0x14));
		          uVar7 = unnamed_function_2232(&StringLiteral_7998);
		          uVar7 = func_ii_4419(uVar7,uVar10,0);
		          iVar3 = unnamed_function_2232(&OKG_Logs_Debug_TypeInfo);
		          if (*(int *)(iVar3 + 0x74) == 0) {
		            func_ii_306000(iVar3);
		          }
		          func_ii_7109(uVar7,0);
		          return;
		        }
		        param2_00 = (undefined4 *)unnamed_function_951(4);
		        *param2_00 = *puVar9;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1e,param2_00,
		                   &DAT_ram_0072c9c8,0);
		        if (DAT_ram_009d3e38 != 1) goto code_r0x80db7256;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar7 = import::env::__cxa_find_matching_catch_2();
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar3 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar3 == 1) {
		      import::env::__cxa_find_matching_catch_3(0);
		      unnamed_function_937();
		code_r0x80db7256:
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  import::env::__resumeException(uVar7);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x0600312B RID: 12587 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600312B")]
		[Address(RVA = "0x8184", Offset = "0x8184", VA = "0x8184")]
		private void RequestSubmit(FeedbackThemeOption theme, string name, string email, string message)
		{
		/* --- GHIDRA: RequestSubmit ---
		void Gameplay_FeedbackForm_Model_Controll_FeedbackFormController__RequestSubmit
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int local_4;
		  
		  if (DAT_ram_00a57609 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_int__HTTPResponse__get_Result__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_7489);
		    Mono_Security_ASN1__get_Item(&StringLiteral_7794);
		    DAT_ram_00a57609 = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  *(undefined4 *)(iVar1 + 0x14) = 0;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x10);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		            (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  local_4 = *(int *)(param2 + 0x20);
		  uVar2 = func_ii_4443(&local_4,0);
		  uVar2 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(StringLiteral_7489,uVar2,0);
		  iVar1 = local_4;
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar3 = *(int *)(iVar3 + 0x18);
		  if (iVar1 < 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar3 + 0xc) * 4))
		              (*(undefined4 *)(iVar3 + 0x20),uVar2,*(undefined4 *)(iVar3 + 0x14));
		  }
		  else {
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar2 = func_ii_7508(StringLiteral_7794,1,0,1,0,0,0,0);
		    (**(code **)((ulonglong)*(uint *)(iVar3 + 0xc) * 4))
		              (*(undefined4 *)(iVar3 + 0x20),uVar2,*(undefined4 *)(iVar3 + 0x14));
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar1 = *(int *)(iVar1 + 0x1c);
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600312C RID: 12588 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600312C")]
		[Address(RVA = "0x8185", Offset = "0x8185", VA = "0x8185")]
		private void HandleSubmitFormSuccess(OpToken<int, HTTPResponse> op)
		{
		/* --- GHIDRA: HandleSubmitFormSuccess ---
		void Gameplay_FeedbackForm_Model_Controll_FeedbackFormController__HandleSubmitFormSuccess
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined1 local_1;
		  
		  if (DAT_ram_00a5760a == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_int__HTTPResponse__get_Fault__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_14750);
		    DAT_ram_00a5760a = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  *(undefined4 *)(iVar1 + 0x14) = 0;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x10);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		            (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x18);
		  local_1 = *(int *)(param2 + 0x24) == 0;
		  uVar2 = func_ii_1081(DAT_ram_00a66944,&local_1);
		  uVar2 = func_ii_4419(StringLiteral_14750,uVar2,0);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		            (*(undefined4 *)(iVar1 + 0x20),uVar2,*(undefined4 *)(iVar1 + 0x14));
		  return;
		}
		*/

		}

		// Token: 0x0600312D RID: 12589 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600312D")]
		[Address(RVA = "0x8186", Offset = "0x8186", VA = "0x8186")]
		private void HandleSubmitFormFailed(OpToken<int, HTTPResponse> op)
		{
		/* --- GHIDRA: HandleSubmitFormFailed ---
		void Gameplay_FeedbackForm_Model_Controll_FeedbackFormController__HandleSubmitFormFailed
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  *(undefined4 *)(iVar1 + 0x10) = param2;
		  return;
		}
		*/

		}

		// Token: 0x0600312E RID: 12590 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600312E")]
		[Address(RVA = "0x1AE9", Offset = "0x1AE9", VA = "0x1AE9")]
		private string GetBase64ZipContent()
		{
		/* --- GHIDRA: GetBase64ZipContent ---
		undefined4
		Gameplay_FeedbackForm_Model_Controll_FeedbackFormController__GetBase64ZipContent
		          (int param1,undefined4 param2)
		
		{
		  int param2_00;
		  undefined4 uVar1;
		  undefined4 param1_00;
		  int *piVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a5b849 == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Application_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Globalization_CultureInfo_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_FirstOrDefault_CultureInfo___);
		    Mono_Security_ASN1__get_Item(&System_Func_CultureInfo__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Localization_Culture_BaseCultureProvider___c__DisplayClass6_0__GetCulture_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Localization_Culture_BaseCultureProvider___c__DisplayClass6_0_TypeInfo);
		    DAT_ram_00a5b849 = '\x01';
		  }
		  param2_00 = unnamed_function_1417
		                        (Localization_Culture_BaseCultureProvider___c__DisplayClass6_0_TypeInfo);
		  iVar3 = *(int *)(param1 + 8);
		  *(int *)(param2_00 + 8) = iVar3;
		  if (iVar3 == 0x2b) {
		    if (*(int *)(UnityEngine_Application_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UnityEngine_Application_TypeInfo);
		    }
		    uVar1 = UnityEngine_Application__get_isMobilePlatform(0);
		    *(undefined4 *)(param2_00 + 8) = uVar1;
		  }
		  if (*(int *)(System_Globalization_CultureInfo_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_Globalization_CultureInfo_TypeInfo);
		  }
		  uVar1 = System_Globalization_CultureInfo__Equals(7,0);
		  param1_00 = unnamed_function_1417(System_Func_CultureInfo__bool__TypeInfo);
		  System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		            (param1_00,param2_00,
		             Method_Localization_Culture_BaseCultureProvider___c__DisplayClass6_0__GetCulture_b__0__
		             ,0);
		  piVar2 = (int *)System_Func_object__bool____ctor
		                            (uVar1,param1_00,
		                             Method_System_Linq_Enumerable_FirstOrDefault_CultureInfo___);
		  if (piVar2 == (int *)0x0) {
		    if (*(int *)(System_Globalization_CultureInfo_TypeInfo + 0x74) == 0) {
		      func_ii_306000(System_Globalization_CultureInfo_TypeInfo);
		    }
		    uVar1 = System_String__StartsWith(0);
		    return uVar1;
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*piVar2 + 0x118) * 4))
		                    (piVar2,*(undefined4 *)(*piVar2 + 0x11c));
		  if (*(int *)(System_Globalization_CultureInfo_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_Globalization_CultureInfo_TypeInfo);
		  }
		  uVar1 = func_ii_13847(uVar1,0);
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x0600312F RID: 12591 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600312F")]
		[Address(RVA = "0x8187", Offset = "0x8187", VA = "0x8187")]
		public void SetCurrentTheme(FeedbackThemeOption theme)
		{
		/* --- GHIDRA: SetCurrentTheme ---
		undefined4
		Gameplay_FeedbackForm_Model_Controll_FeedbackFormController__SetCurrentTheme
		          (int *param1,undefined4 param2,undefined4 param3,int param4,undefined4 param5)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  uint *puVar4;
		  undefined4 uVar5;
		  int param2_00;
		  int *piVar6;
		  int iVar7;
		  undefined8 local_10;
		  undefined4 local_8;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5760c == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_FeedbackForm_Model_Source_IFeedbackFormSource_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_KeyValuePair_string__string____TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		    Mono_Security_ASN1__get_Item(&Utils_StringUtils_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_6812);
		    Mono_Security_ASN1__get_Item(&StringLiteral_21121);
		    Mono_Security_ASN1__get_Item(&StringLiteral_7793);
		    Mono_Security_ASN1__get_Item(&StringLiteral_7791);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    DAT_ram_00a5760c = '\x01';
		  }
		  local_8 = 0;
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  piVar6 = *(int **)(iVar3 + 0x18);
		  iVar3 = *piVar6;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Gameplay_FeedbackForm_Model_Source_IFeedbackFormSource_TypeInfo ==
		          *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0xd0);
		        goto code_r0x80db7e9f;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar6,
		                                Gameplay_FeedbackForm_Model_Source_IFeedbackFormSource_TypeInfo,2);
		code_r0x80db7e9f:
		  local_4 = (**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		  iVar3 = UnityEngine_InputForUI_PointerEvent_ButtonsState__Set(&local_4,2,0);
		  if ((iVar3 == 0) ||
		     (iVar3 = Newtonsoft_Json_Serialization_JsonSerializerInternalReader__ShouldDeserialize
		                        (param2,0), iVar3 == 0)) {
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    piVar6 = *(int **)(iVar3 + 0x18);
		    iVar3 = *piVar6;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Gameplay_FeedbackForm_Model_Source_IFeedbackFormSource_TypeInfo ==
		            *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		          puVar4 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0xd0);
		          goto code_r0x80db7fc7;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		    }
		    puVar4 = (uint *)func_ii_1080(piVar6,
		                                  Gameplay_FeedbackForm_Model_Source_IFeedbackFormSource_TypeInfo,2)
		    ;
		code_r0x80db7fc7:
		    local_4 = (**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		    iVar3 = UnityEngine_InputForUI_PointerEvent_ButtonsState__Set(&local_4,4,0);
		    if (iVar3 != 0) {
		      if (*(int *)(Utils_StringUtils_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Utils_StringUtils_TypeInfo);
		      }
		      iVar3 = System_Text_RegularExpressions_Regex__IsMatch
		                        (*(undefined4 *)(*(int *)(Utils_StringUtils_TypeInfo + 0x5c) + 4),param3,0);
		      if (iVar3 == 0) {
		        iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0x114));
		        iVar3 = *(int *)(iVar3 + 0x14);
		        if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		          func_ii_306000(Core_GameLocalization_TypeInfo);
		        }
		        uVar2 = func_ii_7508(StringLiteral_6812,1,0,1,0,0,0,0);
		        (**(code **)((ulonglong)*(uint *)(iVar3 + 0xc) * 4))
		                  (*(undefined4 *)(iVar3 + 0x20),uVar2,*(undefined4 *)(iVar3 + 0x14));
		        return 0;
		      }
		    }
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    piVar6 = *(int **)(iVar3 + 0x18);
		    iVar3 = *piVar6;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Gameplay_FeedbackForm_Model_Source_IFeedbackFormSource_TypeInfo ==
		            *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		          puVar4 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0xd0);
		          goto code_r0x80db8113;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		    }
		    puVar4 = (uint *)func_ii_1080(piVar6,
		                                  Gameplay_FeedbackForm_Model_Source_IFeedbackFormSource_TypeInfo,2)
		    ;
		code_r0x80db8113:
		    local_4 = (**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		    iVar3 = UnityEngine_InputForUI_PointerEvent_ButtonsState__Set(&local_4,8,0);
		    if ((iVar3 == 0) ||
		       (iVar7 = *(int *)(param4 + 8),
		       iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                         (param1,*(undefined4 *)(*param1 + 0x104)), *(int *)(iVar3 + 0xc) <= iVar7))
		    {
		      iVar7 = *param1;
		      iVar3 = (**(code **)((ulonglong)*(uint *)(iVar7 + 0x100) * 4))
		                        (param1,*(undefined4 *)(iVar7 + 0x104));
		      Gameplay_FeedbackForm_Model_Controll_FeedbackFormController__HandleRun
		                (param1,*(undefined4 *)(iVar3 + 0x10),param2,param3,param4,iVar7);
		      uVar2 = 1;
		    }
		    else {
		      iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x114));
		      iVar3 = *(int *)(iVar3 + 0x14);
		      uVar2 = 0;
		      if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_GameLocalization_TypeInfo);
		      }
		      uVar5 = func_ii_7508(StringLiteral_7791,1,0,1,0,0,0,0);
		      param2_00 = Mono_Security_ASN1Convert__ToOid
		                            (System_Collections_Generic_KeyValuePair_string__string____TypeInfo,1);
		      iVar7 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		      local_8 = *(undefined4 *)(iVar7 + 0xc);
		      iVar7 = func_ii_4443(&local_8,0);
		      local_10 = 0;
		      if (iVar7 == 0) {
		        iVar7 = StringLiteral_5;
		      }
		      System_Text_Formatting_StringView__get_IsEmpty
		                (&local_10,StringLiteral_21121,iVar7,
		                 Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		      *(undefined8 *)(param2_00 + 0x10) = local_10;
		      uVar5 = Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsRewardsTab_ClanWarsRewardsView__GetPlacesText
		                        (uVar5,param2_00,0);
		      (**(code **)((ulonglong)*(uint *)(iVar3 + 0xc) * 4))
		                (*(undefined4 *)(iVar3 + 0x20),uVar5,*(undefined4 *)(iVar3 + 0x14));
		    }
		  }
		  else {
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar3 = *(int *)(iVar3 + 0x14);
		    uVar2 = 0;
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar5 = func_ii_7508(StringLiteral_7793,1,0,1,0,0,0,0);
		    (**(code **)((ulonglong)*(uint *)(iVar3 + 0xc) * 4))
		              (*(undefined4 *)(iVar3 + 0x20),uVar5,*(undefined4 *)(iVar3 + 0x14));
		  }
		  return uVar2;
		}
		*/

		}

		// Token: 0x06003130 RID: 12592 RVA: 0x00009FD8 File Offset: 0x000081D8
		[Token(Token = "0x6003130")]
		[Address(RVA = "0x8188", Offset = "0x8188", VA = "0x8188")]
		public bool TrySubmit(string name, string email, string message)
		{
		/* --- GHIDRA: TrySubmit ---
		void Gameplay_FeedbackForm_Model_Controll_FeedbackFormController__TrySubmit
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5)
		
		{
		  if (DAT_ram_00a5760d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_FeedbackFormModel__FeedbackFormEvents__FeedbackFormController__FeedbackFormView___ctor__
		              );
		    DAT_ram_00a5760d = '\x01';
		  }
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (param1,param2,param3,param4,
		             Method_MVC_AbstractViewMediator_FeedbackFormModel__FeedbackFormEvents__FeedbackFormController__FeedbackFormView___ctor__
		            );
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x04001AE3 RID: 6883
		[Token(Token = "0x4001AE3")]
		[FieldOffset(Offset = "0x18")]
		private FeedbackFormService _service;
	}
}
