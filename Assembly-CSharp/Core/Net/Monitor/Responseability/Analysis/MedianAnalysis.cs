using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Core.Net.Monitor.Responseability.Analysis
{
	// Token: 0x02000EA0 RID: 3744
	[Token(Token = "0x2000EA0")]
	public class MedianAnalysis : AbstractAnalysis
	{
		// Token: 0x06005B00 RID: 23296 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B00")]
		[Address(RVA = "0xA7DE", Offset = "0xA7DE", VA = "0xA7DE", Slot = "6")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Core_Net_Monitor_Responseability_Analysis_MedianAnalysis__Dispose
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a605bb == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_LatencyDto___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_LatencyDto__TypeInfo);
		    DAT_ram_00a605bb = '\x01';
		  }
		  *(int *)(param1 + 8) = param2;
		  param2_00 = *(undefined4 *)(param2 + 8);
		  param1_00 = unnamed_function_1417(System_Collections_Generic_List_LatencyDto__TypeInfo);
		  Unity_Services_Core_Internal_UnityServicesInternal___c__DisplayClass33_0___InitializeServicesAsync_g__FailServicesInitialization_2
		            (param1_00,param2_00,Method_System_Collections_Generic_List_LatencyDto___ctor__);
		  *(undefined4 *)(param1 + 0xc) = param1_00;
		  return;
		}
		*/

		}

		// Token: 0x06005B01 RID: 23297 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B01")]
		[Address(RVA = "0xA7DF", Offset = "0xA7DF", VA = "0xA7DF")]
		public MedianAnalysis(Configuration config)
		{
		/* --- GHIDRA: .ctor ---
		/* WARNING: Removing unreachable block (ram,0x81cb0273) */
		/* WARNING: Removing unreachable block (ram,0x81cb00a2) */
		
		undefined4
		Core_Net_Monitor_Responseability_Analysis_MedianAnalysis___ctor
		          (int param1,int *param2,double *param3,undefined4 param4)
		
		{
		  uint *puVar1;
		  undefined4 *puVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int *piVar5;
		  int iVar6;
		  int *piVar7;
		  longlong lVar8;
		  longlong lVar9;
		  uint uVar10;
		  int iVar11;
		  int iVar12;
		  int iVar13;
		  uint uVar14;
		  int local_40;
		  undefined8 *puStack_3c;
		  undefined8 local_38;
		  int local_30;
		  int **local_2c;
		  undefined8 local_28;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  int *local_4;
		  
		  iVar11 = 0;
		  uVar14 = 0;
		  if (DAT_ram_00a605bc == '\0') {
		    Mono_Security_ASN1__get_Item(&System_DateTimeOffset_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToList_LatencyDto___);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_LatencyDto__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_LatencyDto__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_LatencyDto__get_Current__);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerable_ISrvCommand__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_ISrvCommand__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Net_ISrvCommand_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Net_Monitor_Responseability_LatencyDto_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_LatencyDto__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_LatencyDto__GetEnumerator__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_LatencyDto__Sort__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_LatencyDto__get_Count__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_LatencyDto__set_Item__);
		    DAT_ram_00a605bc = '\x01';
		  }
		  local_4 = (int *)0x0;
		  local_10 = 0;
		  local_18 = 0;
		  local_20 = 0;
		  local_28 = 0;
		  *param3 = 0.0;
		  uVar10 = *(uint *)(*(int *)(param1 + 8) + 8);
		  if ((int)uVar10 < 1) {
		    return 0;
		  }
		  iVar13 = *param2;
		  if (*(ushort *)(iVar13 + 0xb6) != 0) {
		    do {
		      if (System_Collections_Generic_IEnumerable_ISrvCommand__TypeInfo ==
		          *(int *)(*(int *)(iVar13 + 0x58) + uVar14 * 8)) {
		        puVar1 = (uint *)(iVar13 + *(int *)(*(int *)(iVar13 + 0x58) + uVar14 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x81cafa92;
		      }
		      uVar14 = uVar14 + 1;
		    } while (*(ushort *)(iVar13 + 0xb6) != uVar14);
		  }
		  puVar1 = (uint *)func_ii_1080(param2,System_Collections_Generic_IEnumerable_ISrvCommand__TypeInfo,
		                                0);
		code_r0x81cafa92:
		  local_4 = (int *)(**(code **)((ulonglong)*puVar1 * 4))(param2,puVar1[1]);
		  local_30 = 0;
		  local_2c = &local_4;
		code_r0x81cafab7:
		  do {
		    do {
		      piVar7 = local_4;
		      iVar13 = *local_4;
		      if (*(ushort *)(iVar13 + 0xb6) != 0) {
		        uVar14 = 0;
		        do {
		          piVar5 = (int *)(*(int *)(iVar13 + 0x58) + uVar14 * 8);
		          if (System_Collections_IEnumerator_TypeInfo == *piVar5) {
		            puVar2 = (undefined4 *)(iVar13 + piVar5[1] * 8 + 0xc0);
		            goto code_r0x81cafb5f;
		          }
		          uVar14 = uVar14 + 1;
		        } while (*(ushort *)(iVar13 + 0xb6) != uVar14);
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar2 = (undefined4 *)
		               import::env::invoke_iiii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                          System_Collections_IEnumerator_TypeInfo,0);
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x81cafba7:
		        DAT_ram_009d3e38 = 0;
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        iVar13 = global_1;
		        goto code_r0x81cb0410;
		      }
		code_r0x81cafb5f:
		      DAT_ram_009d3e38 = 0;
		      iVar13 = import::env::invoke_iii(*puVar2,piVar7,puVar2[1]);
		      piVar7 = local_4;
		      if (DAT_ram_009d3e38 == 1) goto code_r0x81cafba7;
		      if (iVar13 == 0) {
		        iVar13 = 9;
		        goto code_r0x81cb045b;
		      }
		      iVar13 = *local_4;
		      if (*(ushort *)(iVar13 + 0xb6) != 0) {
		        uVar14 = 0;
		        do {
		          piVar5 = (int *)(*(int *)(iVar13 + 0x58) + uVar14 * 8);
		          if (System_Collections_Generic_IEnumerator_ISrvCommand__TypeInfo == *piVar5) {
		            puVar2 = (undefined4 *)(iVar13 + piVar5[1] * 8 + 0xc0);
		            goto code_r0x81cafc58;
		          }
		          uVar14 = uVar14 + 1;
		        } while (*(ushort *)(iVar13 + 0xb6) != uVar14);
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar2 = (undefined4 *)
		               import::env::invoke_iiii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                          System_Collections_Generic_IEnumerator_ISrvCommand__TypeInfo,0);
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x81cafe98:
		        DAT_ram_009d3e38 = 0;
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        iVar13 = global_1;
		        goto code_r0x81cb0410;
		      }
		code_r0x81cafc58:
		      DAT_ram_009d3e38 = 0;
		      piVar7 = (int *)import::env::invoke_iii(*puVar2,piVar7,puVar2[1]);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x81cafe98;
		      iVar11 = iVar11 + 1;
		      if (*(int *)(System_DateTimeOffset_TypeInfo + 0x74) == 0) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vi
		                  (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                   System_DateTimeOffset_TypeInfo);
		        iVar13 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar13 == 1) {
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          iVar13 = global_1;
		          goto code_r0x81cb0410;
		        }
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vii(s___Scripting__UnityEngine__Contex_ram_0000360b + 0x29,&local_40,0);
		      iVar13 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar13 == 1) {
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        iVar13 = global_1;
		        goto code_r0x81cb0410;
		      }
		      local_10 = local_38;
		      local_18 = CONCAT44(puStack_3c,local_40);
		      DAT_ram_009d3e38 = 0;
		      lVar9 = unnamed_function_184054
		                        (s___Scripting__UnityEngine__Contex_ram_0000360b + 0x2a,&local_18,0);
		      iVar13 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar13 == 1) {
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        iVar13 = global_1;
		        goto code_r0x81cb0410;
		      }
		      iVar13 = *piVar7;
		      if (*(ushort *)(iVar13 + 0xb6) != 0) {
		        uVar14 = 0;
		        do {
		          piVar5 = (int *)(*(int *)(iVar13 + 0x58) + uVar14 * 8);
		          if (Core_Net_ISrvCommand_TypeInfo == *piVar5) {
		            puVar2 = (undefined4 *)(piVar5[1] * 8 + iVar13 + 200);
		            goto code_r0x81cafdeb;
		          }
		          uVar14 = uVar14 + 1;
		        } while (*(ushort *)(iVar13 + 0xb6) != uVar14);
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar2 = (undefined4 *)
		               import::env::invoke_iiii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar7,
		                          Core_Net_ISrvCommand_TypeInfo,1);
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x81cafec0:
		        DAT_ram_009d3e38 = 0;
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        iVar13 = global_1;
		        goto code_r0x81cb0410;
		      }
		code_r0x81cafdeb:
		      DAT_ram_009d3e38 = 0;
		      lVar8 = unnamed_function_184054(*puVar2,piVar7,puVar2[1]);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x81cafec0;
		      DAT_ram_009d3e38 = 0;
		      System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		                (&local_40,*(undefined4 *)(param1 + 0xc),
		                 Method_System_Collections_Generic_List_LatencyDto__GetEnumerator__);
		      iVar13 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar13 == 1) {
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        iVar13 = global_1;
		        goto code_r0x81cb0410;
		      }
		      local_20 = local_38;
		      local_28 = CONCAT44(puStack_3c,local_40);
		      iVar6 = 0;
		      local_40 = 0;
		      puStack_3c = &local_28;
		      while( true ) {
		        DAT_ram_009d3e38 = 0;
		        iVar13 = import::env::invoke_iii
		                           (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_28,
		                            Method_System_Collections_Generic_List_Enumerator_LatencyDto__MoveNext__
		                           );
		        if (DAT_ram_009d3e38 == 1) break;
		        if (iVar13 == 0) {
		          iVar13 = 7;
		          iVar4 = 0;
		          goto code_r0x81cb0074;
		        }
		        iVar13 = local_20._4_4_;
		        iVar4 = *(int *)(local_20._4_4_ + 8);
		        iVar12 = *piVar7;
		        if (*(ushort *)(iVar12 + 0xb6) != 0) {
		          uVar14 = 0;
		          do {
		            piVar5 = (int *)(*(int *)(iVar12 + 0x58) + uVar14 * 8);
		            if (Core_Net_ISrvCommand_TypeInfo == *piVar5) {
		              puVar2 = (undefined4 *)(iVar12 + piVar5[1] * 8 + 0xc0);
		              goto code_r0x81caffbd;
		            }
		            uVar14 = uVar14 + 1;
		          } while (*(ushort *)(iVar12 + 0xb6) != uVar14);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar2 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar7,
		                            Core_Net_ISrvCommand_TypeInfo,0);
		        if (DAT_ram_009d3e38 == 1) break;
		code_r0x81caffbd:
		        DAT_ram_009d3e38 = 0;
		        iVar12 = import::env::invoke_iii(*puVar2,piVar7,puVar2[1]);
		        if (DAT_ram_009d3e38 == 1) break;
		        if (iVar12 == iVar4) {
		          *(longlong *)(iVar13 + 0x10) = lVar9 - lVar8;
		          iVar6 = iVar6 + 1;
		        }
		      }
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      iVar13 = global_1;
		      iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar13 != iVar4) {
		code_r0x81cb0110:
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_ii(s___Scripting__UnityEngine__UnityS_ram_00003636 + 7,&local_40);
		        iVar6 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar6 == 1) goto code_r0x81cb059b;
		        goto code_r0x81cb0410;
		      }
		      piVar5 = (int *)import::env::__cxa_begin_catch(uVar3);
		      iVar4 = *piVar5;
		      iVar13 = 0;
		      DAT_ram_009d3e38 = 0;
		      local_40 = iVar4;
		      import::env::invoke_v(0x123);
		      iVar12 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar12 == 1) {
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        iVar13 = global_1;
		        goto code_r0x81cb0110;
		      }
		code_r0x81cb0074:
		      if (iVar4 != 0) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vi(s_var<private>_posTex__array<vec4<_ram_00000655 + 0x1d3,iVar4);
		        iVar13 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar13 != 1) {
		          do {
		            halt_trap();
		          } while( true );
		        }
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        iVar13 = global_1;
		        goto code_r0x81cb0410;
		      }
		      if ((iVar13 != 0) &&
		         ((((iVar13 == 1 || (iVar13 == 2)) || (iVar13 == 3)) ||
		          (((iVar13 == 4 || (iVar13 == 5)) || ((iVar13 == 6 || (iVar13 != 7))))))))
		      goto code_r0x81cb045b;
		    } while (iVar6 != 0);
		    iVar13 = *piVar7;
		    if (*(ushort *)(iVar13 + 0xb6) != 0) {
		      uVar14 = 0;
		      do {
		        piVar5 = (int *)(*(int *)(iVar13 + 0x58) + uVar14 * 8);
		        if (Core_Net_ISrvCommand_TypeInfo == *piVar5) {
		          puVar2 = (undefined4 *)(iVar13 + piVar5[1] * 8 + 0xc0);
		          goto code_r0x81cb01df;
		        }
		        uVar14 = uVar14 + 1;
		      } while (*(ushort *)(iVar13 + 0xb6) != uVar14);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar2 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar7,
		                        Core_Net_ISrvCommand_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x81cb0355:
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      iVar13 = global_1;
		      goto code_r0x81cb0410;
		    }
		code_r0x81cb01df:
		    DAT_ram_009d3e38 = 0;
		    uVar3 = import::env::invoke_iii(*puVar2,piVar7,puVar2[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x81cb0355;
		    DAT_ram_009d3e38 = 0;
		    iVar13 = import::env::invoke_ii
		                       (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                        Core_Net_Monitor_Responseability_LatencyDto_TypeInfo);
		    if (DAT_ram_009d3e38 == 1) {
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      iVar13 = global_1;
		      goto code_r0x81cb0410;
		    }
		    *(longlong *)(iVar13 + 0x10) = lVar9 - lVar8;
		    *(undefined4 *)(iVar13 + 8) = uVar3;
		    iVar6 = Method_System_Collections_Generic_List_LatencyDto__Add__;
		    iVar4 = *(int *)(param1 + 0xc);
		    uVar14 = *(uint *)(iVar4 + 0xc);
		    if (uVar14 == uVar10) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_viiii
		                (s_struct_Uniforms___color__array<v_ram_00001b87 + 0xff,iVar4,0,0,
		                 Method_System_Collections_Generic_List_LatencyDto__set_Item__);
		      iVar6 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar6 == 1) {
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        iVar13 = global_1;
		        goto code_r0x81cb0410;
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_viii
		                (s___Scripting__UnityEngine__UnityS_ram_00003636 + 8,iVar13,
		                 *(undefined4 *)(param1 + 0xc),iVar13);
		      iVar6 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar6 == 1) {
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        iVar13 = global_1;
		        goto code_r0x81cb0410;
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_viiii
		                (s_struct_Uniforms___color__array<v_ram_00001b87 + 0xff,*(int *)(param1 + 0xc),
		                 *(int *)(*(int *)(param1 + 0xc) + 0xc) + -1,iVar13,
		                 Method_System_Collections_Generic_List_LatencyDto__set_Item__);
		      iVar13 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar13 == 1) {
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        iVar13 = global_1;
		        goto code_r0x81cb0410;
		      }
		      goto code_r0x81cafab7;
		    }
		    *(int *)(iVar4 + 0x10) = *(int *)(iVar4 + 0x10) + 1;
		    if (uVar14 < *(uint *)(*(int *)(iVar4 + 8) + 0xc)) {
		      *(uint *)(iVar4 + 0xc) = uVar14 + 1;
		      *(int *)(*(int *)(iVar4 + 8) + uVar14 * 4 + 0x10) = iVar13;
		      goto code_r0x81cafab7;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar4,iVar13,
		               *(undefined4 *)(*(int *)(*(int *)(iVar6 + 0x10) + 0x60) + 0x38));
		    iVar13 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar13 != 1);
		  uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  iVar13 = global_1;
		code_r0x81cb0410:
		  iVar6 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar6 == iVar13) {
		    piVar7 = (int *)import::env::__cxa_begin_catch(uVar3);
		    local_30 = *piVar7;
		    iVar13 = 0;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 != 1) {
		code_r0x81cb045b:
		      DAT_ram_009d3e38 = 0;
		      piVar7 = *local_2c;
		      if (piVar7 != (int *)0x0) {
		        uVar14 = 0;
		        iVar6 = *piVar7;
		        if (*(ushort *)(iVar6 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar14 * 8)) {
		              puVar1 = (uint *)(iVar6 + *(int *)(*(int *)(iVar6 + 0x58) + uVar14 * 8 + 4) * 8 + 0xc0
		                               );
		              goto code_r0x81cb04d6;
		            }
		            uVar14 = uVar14 + 1;
		          } while (*(ushort *)(iVar6 + 0xb6) != uVar14);
		        }
		        puVar1 = (uint *)func_ii_1080(piVar7,System_IDisposable_TypeInfo,0);
		code_r0x81cb04d6:
		        (**(code **)((ulonglong)*puVar1 * 4))(piVar7,puVar1[1]);
		      }
		      if (local_30 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(local_30);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      if (iVar13 != 0) {
		        if (iVar13 == 1) {
		          return 0;
		        }
		        if (iVar13 == 2) {
		          return 0;
		        }
		        if (iVar13 == 3) {
		          return 0;
		        }
		        if (iVar13 == 4) {
		          return 0;
		        }
		        if (iVar13 == 5) {
		          return 0;
		        }
		        if (iVar13 == 6) {
		          return 0;
		        }
		        if (iVar13 == 7) {
		          return 0;
		        }
		        if (iVar13 == 8) {
		          return 0;
		        }
		        if (iVar13 != 9) {
		          return 0;
		        }
		      }
		      if (iVar11 < 1) {
		        return 0;
		      }
		      if (*(uint *)(*(int *)(param1 + 0xc) + 0xc) != uVar10) {
		        return 0;
		      }
		      uVar3 = System_Linq_Enumerable__Select_object__object_
		                        (*(int *)(param1 + 0xc),Method_System_Linq_Enumerable_ToList_LatencyDto___);
		      func_ii_15909(uVar3,Method_System_Collections_Generic_List_LatencyDto__Sort__);
		      lVar9 = Core_Net_Monitor_Responseability_Analysis_MedianAnalysis__Analyze(uVar3,uVar3,uVar3);
		      *param3 = (double)lVar9;
		      return (uint)((double)*(int *)(*(int *)(param1 + 8) + 0xc) < (double)lVar9);
		    }
		    uVar3 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s___Scripting__UnityEngine__UnityS_ram_00003636 + 9,&local_30);
		  iVar11 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar11 != 1) {
		    import::env::__resumeException(uVar3);
		    do {
		      halt_trap();
		    } while( true );
		  }
		code_r0x81cb059b:
		  DAT_ram_009d3e38 = 0;
		  import::env::__cxa_find_matching_catch_3(0);
		  unnamed_function_937();
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06005B02 RID: 23298 RVA: 0x000102F0 File Offset: 0x0000E4F0
		[Token(Token = "0x6005B02")]
		[Address(RVA = "0xA7E0", Offset = "0xA7E0", VA = "0xA7E0", Slot = "7")]
		public override bool Analyze(IEnumerable<ISrvCommand> value, out double calcValue)
		{
		/* --- GHIDRA: Analyze ---
		longlong Core_Net_Monitor_Responseability_Analysis_MedianAnalysis__Analyze
		                   (undefined4 param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  uint uVar2;
		  longlong lVar3;
		  
		  if (DAT_ram_00a605be == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_LatencyDto__get_Count__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_LatencyDto__get_Item__);
		    Mono_Security_ASN1__get_Item(&System_Math_TypeInfo);
		    DAT_ram_00a605be = '\x01';
		  }
		  uVar2 = *(uint *)(param2 + 0xc);
		  if ((uVar2 & 1) != 0) {
		    if (*(int *)(System_Math_TypeInfo + 0x74) == 0) {
		      func_ii_306000(System_Math_TypeInfo);
		    }
		    if (ABS(FLOOR((double)(int)uVar2 * 0.5)) < 2147483648.0) {
		      iVar1 = (int)FLOOR((double)(int)uVar2 * 0.5);
		    }
		    else {
		      iVar1 = -0x80000000;
		    }
		    iVar1 = System_Linq_Enumerable__ToList_object_
		                      (param2,iVar1,Method_System_Collections_Generic_List_LatencyDto__get_Item__);
		    return *(undefined8 *)(iVar1 + 0x10);
		  }
		  iVar1 = System_Linq_Enumerable__ToList_object_
		                    (param2,(int)uVar2 / 2 + -1,
		                     Method_System_Collections_Generic_List_LatencyDto__get_Item__);
		  lVar3 = *(longlong *)(iVar1 + 0x10);
		  iVar1 = System_Linq_Enumerable__ToList_object_
		                    (param2,(int)uVar2 / 2,
		                     Method_System_Collections_Generic_List_LatencyDto__get_Item__);
		  return (lVar3 + *(longlong *)(iVar1 + 0x10)) / 2;
		}
		*/

			return default(bool);
		}

		// Token: 0x06005B03 RID: 23299 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B03")]
		[Address(RVA = "0x363E", Offset = "0x363E", VA = "0x363E")]
		private void Shift(List<LatencyDto> arr)
		{
		}

		// Token: 0x06005B04 RID: 23300 RVA: 0x00010308 File Offset: 0x0000E508
		[Token(Token = "0x6005B04")]
		[Address(RVA = "0xA7E1", Offset = "0xA7E1", VA = "0xA7E1")]
		private long GetMedian(List<LatencyDto> arr)
		{
		/* --- GHIDRA: GetMedian ---
		void Core_Net_Monitor_Responseability_Analysis_MedianAnalysis__GetMedian
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a605bf == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ConnectionState__TypeInfo);
		    DAT_ram_00a605bf = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 8);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ConnectionState__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ConnectionState__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 8,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

			return 0L;
		}

		// Token: 0x040031C1 RID: 12737
		[Token(Token = "0x40031C1")]
		[FieldOffset(Offset = "0xC")]
		private readonly List<LatencyDto> _latencies;
	}
}
