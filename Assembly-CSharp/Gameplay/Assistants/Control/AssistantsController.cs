using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gameplay.Assistants.Model;
using Google.Protobuf;
using Il2CppDummyDll;
using MVC;
using Protocol.Services;
using ServicesNamespace;
using Utils;

namespace Gameplay.Assistants.Control
{
	// Token: 0x02000CB6 RID: 3254
	[Token(Token = "0x2000CB6")]
	public class AssistantsController : AbstractController<AssistantsListModel, AssistantsEvents>
	{
		// Token: 0x1700101F RID: 4127
		// (get) Token: 0x06004F53 RID: 20307 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004F54 RID: 20308 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700101F")]
		public ServicesService ServicesService
		{
			[Token(Token = "0x6004F53")]
			[Address(RVA = "0x9D7B", Offset = "0x9D7B", VA = "0x9D7B")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004F54")]
			[Address(RVA = "0x9D7C", Offset = "0x9D7C", VA = "0x9D7C")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06004F55 RID: 20309 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F55")]
		[Address(RVA = "0x9D7D", Offset = "0x9D7D", VA = "0x9D7D", Slot = "5")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_Assistants_Control_AssistantsController__Dispose
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  if (DAT_ram_00a589b8 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_MVC_AbstractController_AssistantsListModel__AssistantsEvents___ctor__);
		    DAT_ram_00a589b8 = '\x01';
		  }
		  Gameplay_Combat_AbstractCombat_object__object__object__object__object___set_User
		            (param1,param2,param3,
		             Method_MVC_AbstractController_AssistantsListModel__AssistantsEvents___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x06004F56 RID: 20310 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F56")]
		[Address(RVA = "0x9D7E", Offset = "0x9D7E", VA = "0x9D7E")]
		public AssistantsController(AssistantsListModel model, AssistantsEvents events)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Assistants_Control_AssistantsController___ctor(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a589b9 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Assistants_Control_AssistantsController_GetAssistantsStatusService__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    DAT_ram_00a589b9 = '\x01';
		  }
		  uVar1 = ServicesNamespace_ServicesService__GetDiscounts(*(undefined4 *)(param1 + 0x18),0);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_Assistants_Control_AssistantsController_GetAssistantsStatusService__,0)
		  ;
		  uVar1 = ServicesNamespace_MainService__GetUserStats
		                    (uVar1,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x06004F57 RID: 20311 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F57")]
		[Address(RVA = "0x9D7F", Offset = "0x9D7F", VA = "0x9D7F", Slot = "7")]
		protected override void HandleRun()
		{
		/* --- GHIDRA: HandleRun ---
		void Gameplay_Assistants_Control_AssistantsController__HandleRun
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  Gameplay_Assistants_Control_AssistantsController__GetAssistantsStatusService(param1,param2,param1)
		  ;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 8);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004F58 RID: 20312 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F58")]
		[Address(RVA = "0x9D80", Offset = "0x9D80", VA = "0x9D80")]
		private void Internal_HandleRun(IEnumerable<ProtoGetAssistantsStatusAns.Types.Info> infos)
		{
		/* --- GHIDRA: Internal_HandleRun ---
		void Gameplay_Assistants_Control_AssistantsController__Internal_HandleRun
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int *param1_00;
		  
		  if (DAT_ram_00a589ba == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Services_ProtoGetAssistantsStatusAns_TypeInfo);
		    DAT_ram_00a589ba = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  param1_00 = *(int **)(param2 + 0x20);
		  if ((param1_00 != (int *)0x0) &&
		     (Protocol_Services_ProtoGetAssistantsStatusAns_TypeInfo != *param1_00)) {
		    System_Activator__CreateInstance
		              (param1_00,Protocol_Services_ProtoGetAssistantsStatusAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  Gameplay_Assistants_Control_AssistantsController__GetAssistantsStatusService
		            (param1,param1_00[3],param1);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 8);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004F59 RID: 20313 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F59")]
		[Address(RVA = "0x9D81", Offset = "0x9D81", VA = "0x9D81")]
		private void GetAssistantsStatusService(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: GetAssistantsStatusService ---
		void Gameplay_Assistants_Control_AssistantsController__GetAssistantsStatusService
		               (int *param1,int *param2,undefined4 param3)
		
		{
		  int iVar1;
		  uint uVar2;
		  int iVar3;
		  undefined4 *puVar4;
		  undefined4 uVar5;
		  int param2_00;
		  int *piVar6;
		  undefined4 uVar7;
		  int iVar8;
		  int *piVar9;
		  uint *puVar10;
		  int iVar11;
		  int *piVar12;
		  int local_18;
		  int **local_14;
		  int local_10;
		  int **local_c;
		  int *local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a589bb == '\0') {
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_IEnumerable_ProtoGetAssistantsStatusAns_Types_Info__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_AssistantsDic__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_IEnumerator_ProtoGetAssistantsStatusAns_Types_Info__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_AssistantsDic__GetEnumerator__);
		    DAT_ram_00a589bb = '\x01';
		  }
		  local_4 = (int *)0x0;
		  local_8 = (int *)0x0;
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  local_4 = (int *)Google_Protobuf_Collections_RepeatedField_float___Equals
		                             (*(undefined4 *)(iVar3 + 0x10),
		                              Method_Google_Protobuf_Collections_RepeatedField_AssistantsDic__GetEnumerator__
		                             );
		  local_10 = 0;
		  local_c = &local_4;
		  do {
		    do {
		      piVar9 = local_4;
		      iVar3 = *local_4;
		      if (*(ushort *)(iVar3 + 0xb6) != 0) {
		        uVar2 = 0;
		        do {
		          piVar6 = (int *)(*(int *)(iVar3 + 0x58) + uVar2 * 8);
		          if (System_Collections_IEnumerator_TypeInfo == *piVar6) {
		            puVar4 = (undefined4 *)(iVar3 + piVar6[1] * 8 + 0xc0);
		            goto code_r0x80f561c5;
		          }
		          uVar2 = uVar2 + 1;
		        } while (*(ushort *)(iVar3 + 0xb6) != uVar2);
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar4 = (undefined4 *)
		               import::env::invoke_iiii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                          System_Collections_IEnumerator_TypeInfo,0);
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x80f5620d:
		        DAT_ram_009d3e38 = 0;
		        uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        iVar3 = global_1;
		        goto code_r0x80f56a7f;
		      }
		code_r0x80f561c5:
		      DAT_ram_009d3e38 = 0;
		      iVar3 = import::env::invoke_iii(*puVar4,piVar9,puVar4[1]);
		      piVar9 = local_4;
		      if (DAT_ram_009d3e38 == 1) goto code_r0x80f5620d;
		      if (iVar3 == 0) {
		        iVar3 = 0;
		        goto code_r0x80f56ac6;
		      }
		      iVar3 = *local_4;
		      if (*(ushort *)(iVar3 + 0xb6) != 0) {
		        uVar2 = 0;
		        do {
		          piVar6 = (int *)(*(int *)(iVar3 + 0x58) + uVar2 * 8);
		          if (System_Collections_Generic_IEnumerator_AssistantsDic__TypeInfo == *piVar6) {
		            puVar4 = (undefined4 *)(iVar3 + piVar6[1] * 8 + 0xc0);
		            goto code_r0x80f562b2;
		          }
		          uVar2 = uVar2 + 1;
		        } while (*(ushort *)(iVar3 + 0xb6) != uVar2);
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar4 = (undefined4 *)
		               import::env::invoke_iiii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                          System_Collections_Generic_IEnumerator_AssistantsDic__TypeInfo,0);
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x80f56a70:
		        DAT_ram_009d3e38 = 0;
		        uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        iVar3 = global_1;
		        goto code_r0x80f56a7f;
		      }
		code_r0x80f562b2:
		      DAT_ram_009d3e38 = 0;
		      iVar3 = import::env::invoke_iii(*puVar4,piVar9,puVar4[1]);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x80f56a70;
		      DAT_ram_009d3e38 = 0;
		      param2_00 = import::env::invoke_iii
		                            (*(undefined4 *)(*param1 + 0x100),param1,
		                             *(undefined4 *)(*param1 + 0x104));
		      iVar8 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar8 == 1) {
		        uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        iVar3 = global_1;
		        goto code_r0x80f56a7f;
		      }
		      if (DAT_ram_00a58975 == '\0') {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vi
		                  (0x7ff,&Method_System_Collections_Generic_List_BaseAssistant__get_Count__);
		        if (DAT_ram_009d3e38 != 1) {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vi
		                    (0x7ff,&Method_System_Collections_Generic_List_BaseAssistant__get_Item__);
		          if (DAT_ram_009d3e38 != 1) {
		            DAT_ram_00a58975 = '\x01';
		            iVar8 = DAT_ram_009d3e38;
		            goto code_r0x80f563ad;
		          }
		        }
		code_r0x80f5646c:
		        DAT_ram_009d3e38 = 0;
		        uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        iVar3 = global_1;
		        goto code_r0x80f56a7f;
		      }
		code_r0x80f563ad:
		      iVar11 = *(int *)(*(int *)(param2_00 + 0x14) + 0xc);
		      if (0 < iVar11) {
		        iVar8 = 0;
		        do {
		          DAT_ram_009d3e38 = 0;
		          piVar9 = (int *)import::env::invoke_iiii
		                                    (s_struct_Uniforms___color__array<v_ram_00000aff + 0x22a,
		                                     *(undefined4 *)(param2_00 + 0x14),iVar8,
		                                     Method_System_Collections_Generic_List_BaseAssistant__get_Item__
		                                    );
		          iVar1 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar1 == 1) {
		            uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            iVar3 = global_1;
		            goto code_r0x80f56a7f;
		          }
		          if (*(int *)(piVar9[2] + 0xc) == *(int *)(iVar3 + 0xc)) goto code_r0x80f56476;
		          iVar8 = iVar8 + 1;
		        } while (iVar8 != iVar11);
		      }
		      DAT_ram_009d3e38 = 0;
		      piVar9 = (int *)import::env::invoke_iiii
		                                (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x1e3,param2_00,
		                                 iVar3,iVar8);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x80f5646c;
		    } while (piVar9 == (int *)0x0);
		code_r0x80f56476:
		    iVar3 = *param2;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      uVar2 = 0;
		      do {
		        piVar6 = (int *)(*(int *)(iVar3 + 0x58) + uVar2 * 8);
		        if (System_Collections_Generic_IEnumerable_ProtoGetAssistantsStatusAns_Types_Info__TypeInfo
		            == *piVar6) {
		          puVar4 = (undefined4 *)(iVar3 + piVar6[1] * 8 + 0xc0);
		          goto code_r0x80f5650c;
		        }
		        uVar2 = uVar2 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar2);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar4 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,param2,
		                        System_Collections_Generic_IEnumerable_ProtoGetAssistantsStatusAns_Types_Info__TypeInfo
		                        ,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80f56a66:
		      DAT_ram_009d3e38 = 0;
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      iVar3 = global_1;
		      goto code_r0x80f56a7f;
		    }
		code_r0x80f5650c:
		    DAT_ram_009d3e38 = 0;
		    piVar6 = (int *)import::env::invoke_iii(*puVar4,param2,puVar4[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80f56a66;
		    local_18 = 0;
		    local_14 = &local_8;
		    local_8 = piVar6;
		    do {
		      piVar6 = local_8;
		      iVar3 = *local_8;
		      if (*(ushort *)(iVar3 + 0xb6) != 0) {
		        uVar2 = 0;
		        do {
		          piVar12 = (int *)(*(int *)(iVar3 + 0x58) + uVar2 * 8);
		          if (System_Collections_IEnumerator_TypeInfo == *piVar12) {
		            puVar4 = (undefined4 *)(iVar3 + piVar12[1] * 8 + 0xc0);
		            goto code_r0x80f56606;
		          }
		          uVar2 = uVar2 + 1;
		        } while (*(ushort *)(iVar3 + 0xb6) != uVar2);
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar4 = (undefined4 *)
		               import::env::invoke_iiii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_8,
		                          System_Collections_IEnumerator_TypeInfo,0);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x80f568b1;
		code_r0x80f56606:
		      DAT_ram_009d3e38 = 0;
		      iVar3 = import::env::invoke_iii(*puVar4,piVar6,puVar4[1]);
		      piVar6 = local_8;
		      if (DAT_ram_009d3e38 == 1) goto code_r0x80f568b1;
		      iVar8 = 0;
		      if (iVar3 == 0) goto code_r0x80f56905;
		      iVar3 = *local_8;
		      if (*(ushort *)(iVar3 + 0xb6) != 0) {
		        uVar2 = 0;
		        do {
		          piVar12 = (int *)(*(int *)(iVar3 + 0x58) + uVar2 * 8);
		          if (System_Collections_Generic_IEnumerator_ProtoGetAssistantsStatusAns_Types_Info__TypeInfo
		              == *piVar12) {
		            puVar4 = (undefined4 *)(iVar3 + piVar12[1] * 8 + 0xc0);
		            goto code_r0x80f566e5;
		          }
		          uVar2 = uVar2 + 1;
		        } while (*(ushort *)(iVar3 + 0xb6) != uVar2);
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar4 = (undefined4 *)
		               import::env::invoke_iiii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_8,
		                          System_Collections_Generic_IEnumerator_ProtoGetAssistantsStatusAns_Types_Info__TypeInfo
		                          ,0);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x80f568b1;
		code_r0x80f566e5:
		      DAT_ram_009d3e38 = 0;
		      iVar3 = import::env::invoke_iii(*puVar4,piVar6,puVar4[1]);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x80f568b1;
		    } while (*(int *)(piVar9[2] + 0xc) != *(int *)(iVar3 + 0xc));
		    if ((char)piVar9[3] != '\0') {
		      DAT_ram_009d3e38 = 0;
		      uVar5 = import::env::invoke_ii
		                        (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1c,
		                         &System_Exception_TypeInfo);
		      if (DAT_ram_009d3e38 != 1) {
		        DAT_ram_009d3e38 = 0;
		        uVar5 = import::env::invoke_ii
		                          (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,uVar5);
		        if (DAT_ram_009d3e38 != 1) {
		          DAT_ram_009d3e38 = 0;
		          uVar7 = import::env::invoke_ii
		                            (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1c,
		                             &StringLiteral_3027);
		          if (DAT_ram_009d3e38 != 1) {
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_viii
		                      (s_struct_Uniforms___color__vec4<f3_ram_00000856 + 0x26f,uVar5,uVar7,0);
		            if (DAT_ram_009d3e38 != 1) {
		              DAT_ram_009d3e38 = 0;
		              uVar7 = import::env::invoke_ii
		                                (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1c,
		                                 &Method_Gameplay_Assistants_BaseAssistant_Run__);
		              if (DAT_ram_009d3e38 != 1) {
		                DAT_ram_009d3e38 = 0;
		                import::env::invoke_vii(0x41b,uVar5,uVar7);
		                if (DAT_ram_009d3e38 != 1) goto code_r0x80f56a64;
		              }
		            }
		          }
		        }
		      }
		code_r0x80f568b1:
		      DAT_ram_009d3e38 = 0;
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      iVar3 = global_1;
		      iVar8 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar3 == iVar8) {
		        piVar9 = (int *)import::env::__cxa_begin_catch(uVar5);
		        iVar8 = *piVar9;
		        DAT_ram_009d3e38 = 0;
		        local_18 = iVar8;
		        import::env::invoke_v(0x123);
		        iVar3 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar3 != 1) goto code_r0x80f56905;
		        uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        iVar3 = global_1;
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x1e4,&local_18);
		      iVar8 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar8 == 1) goto code_r0x80f56b8f;
		      goto code_r0x80f56a7f;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (*(undefined4 *)(*piVar9 + 0xf0),piVar9,*(undefined4 *)(iVar3 + 0x10),
		               *(undefined4 *)(*piVar9 + 0xf4));
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80f568b1;
		    *(undefined1 *)(piVar9 + 3) = 1;
		code_r0x80f56905:
		    piVar9 = local_8;
		    if (local_8 != (int *)0x0) {
		      iVar3 = *local_8;
		      if (*(ushort *)(iVar3 + 0xb6) != 0) {
		        uVar2 = 0;
		        do {
		          piVar6 = (int *)(*(int *)(iVar3 + 0x58) + uVar2 * 8);
		          if (System_IDisposable_TypeInfo == *piVar6) {
		            puVar4 = (undefined4 *)(iVar3 + piVar6[1] * 8 + 0xc0);
		            goto code_r0x80f569a2;
		          }
		          uVar2 = uVar2 + 1;
		        } while (*(ushort *)(iVar3 + 0xb6) != uVar2);
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar4 = (undefined4 *)
		               import::env::invoke_iiii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_8,
		                          System_IDisposable_TypeInfo,0);
		      if (DAT_ram_009d3e38 != 1) {
		code_r0x80f569a2:
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vii(*puVar4,piVar9,puVar4[1]);
		        if (DAT_ram_009d3e38 != 1) goto code_r0x80f569de;
		      }
		      DAT_ram_009d3e38 = 0;
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      iVar3 = global_1;
		      goto code_r0x80f56a7f;
		    }
		code_r0x80f569de:
		  } while (iVar8 == 0);
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_vi(s_var<private>_posTex__array<vec4<_ram_00000655 + 0x1d3,iVar8);
		  iVar3 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar3 != 1) {
		code_r0x80f56a64:
		    do {
		      halt_trap();
		    } while( true );
		  }
		  uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  iVar3 = global_1;
		code_r0x80f56a7f:
		  iVar8 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar8 == iVar3) {
		    piVar9 = (int *)import::env::__cxa_begin_catch(uVar5);
		    iVar3 = *piVar9;
		    DAT_ram_009d3e38 = 0;
		    local_10 = iVar3;
		    import::env::invoke_v(0x123);
		    iVar8 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar8 != 1) {
		code_r0x80f56ac6:
		      piVar9 = local_4;
		      DAT_ram_009d3e38 = 0;
		      if (local_4 != (int *)0x0) {
		        uVar2 = 0;
		        iVar8 = *local_4;
		        if (*(ushort *)(iVar8 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar2 * 8)) {
		              puVar10 = (uint *)(iVar8 + *(int *)(*(int *)(iVar8 + 0x58) + uVar2 * 8 + 4) * 8 + 0xc0
		                                );
		              goto code_r0x80f56b3e;
		            }
		            uVar2 = uVar2 + 1;
		          } while (*(ushort *)(iVar8 + 0xb6) != uVar2);
		        }
		        puVar10 = (uint *)func_ii_1080(local_4,System_IDisposable_TypeInfo,0);
		code_r0x80f56b3e:
		        (**(code **)((ulonglong)*puVar10 * 4))(piVar9,puVar10[1]);
		      }
		      if (iVar3 == 0) {
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar5 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x1e5,&local_10);
		  iVar3 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar3 != 1) {
		    import::env::__resumeException(uVar5);
		    do {
		      halt_trap();
		    } while( true );
		  }
		code_r0x80f56b8f:
		  DAT_ram_009d3e38 = 0;
		  import::env::__cxa_find_matching_catch_3(0);
		  unnamed_function_937();
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06004F5A RID: 20314 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F5A")]
		[Address(RVA = "0x9D82", Offset = "0x9D82", VA = "0x9D82")]
		private void RunAssistants(IEnumerable<ProtoGetAssistantsStatusAns.Types.Info> infos)
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_ServicesService ---
		void Gameplay_Assistants_Control_AssistantsController__set_ServicesService
		               (int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a589b7 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_MVC_AbstractController_AssistantsListModel__AssistantsEvents__Dispose__);
		    DAT_ram_00a589b7 = '\x01';
		  }
		  *(undefined4 *)(param1 + 0x18) = 0;
		  MVC_AbstractController_object__object____ctor
		            (param1,Method_MVC_AbstractController_AssistantsListModel__AssistantsEvents__Dispose__);
		  return;
		}
		*/

}
