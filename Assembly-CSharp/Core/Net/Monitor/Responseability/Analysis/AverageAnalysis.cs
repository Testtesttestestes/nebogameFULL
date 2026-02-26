using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Core.Net.Monitor.Responseability.Analysis
{
	// Token: 0x02000E9D RID: 3741
	[Token(Token = "0x2000E9D")]
	public class AverageAnalysis : AbstractAnalysis
	{
		// Token: 0x06005AFA RID: 23290 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005AFA")]
		[Address(RVA = "0xA7D9", Offset = "0xA7D9", VA = "0xA7D9")]
		public AverageAnalysis(Configuration config)
		{
		/* --- GHIDRA: .ctor ---
		/* WARNING: Removing unreachable block (ram,0x81caf56f) */
		
		uint Core_Net_Monitor_Responseability_Analysis_AverageAnalysis___ctor
		               (int param1,int *param2,double *param3,undefined4 param4)
		
		{
		  uint *puVar1;
		  undefined4 *puVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  undefined4 uVar5;
		  int iVar6;
		  int *piVar7;
		  longlong lVar8;
		  longlong lVar9;
		  double dVar10;
		  int iVar11;
		  int iVar12;
		  int iVar13;
		  int iVar14;
		  uint uVar15;
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
		  
		  puVar1 = (uint *)0x0;
		  if (DAT_ram_00a605b8 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_DateTimeOffset_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Average_LatencyDto___);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Queue_Enumerator_LatencyDto__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Queue_Enumerator_LatencyDto__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Queue_Enumerator_LatencyDto__get_Current__);
		    Mono_Security_ASN1__get_Item(&System_Func_LatencyDto__long__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerable_ISrvCommand__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_ISrvCommand__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Net_ISrvCommand_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Net_Monitor_Responseability_LatencyDto_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_Queue_LatencyDto__Dequeue__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_Queue_LatencyDto__Enqueue__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Queue_LatencyDto__GetEnumerator__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_Queue_LatencyDto__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Net_Monitor_Responseability_Analysis_AverageAnalysis___c__Analyze_b__2_0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Core_Net_Monitor_Responseability_Analysis_AverageAnalysis___c_TypeInfo);
		    DAT_ram_00a605b8 = '\x01';
		  }
		  local_4 = (int *)0x0;
		  local_10 = 0;
		  local_18 = 0;
		  local_20 = 0;
		  local_28 = 0;
		  *param3 = 0.0;
		  iVar11 = *(int *)(*(int *)(param1 + 8) + 8);
		  if (0 < iVar11) {
		    iVar14 = *param2;
		    if ((uint *)(uint)*(ushort *)(iVar14 + 0xb6) != (uint *)0x0) {
		      do {
		        if (System_Collections_Generic_IEnumerable_ISrvCommand__TypeInfo ==
		            *(int *)(*(int *)(iVar14 + 0x58) + (int)puVar1 * 8)) {
		          puVar1 = (uint *)(iVar14 + *(int *)(*(int *)(iVar14 + 0x58) + (int)puVar1 * 8 + 4) * 8 +
		                           0xc0);
		          goto code_r0x81caed59;
		        }
		        puVar1 = (uint *)((int)puVar1 + 1);
		      } while ((uint *)(uint)*(ushort *)(iVar14 + 0xb6) != puVar1);
		    }
		    puVar1 = (uint *)func_ii_1080(param2,
		                                  System_Collections_Generic_IEnumerable_ISrvCommand__TypeInfo,0);
		code_r0x81caed59:
		    local_4 = (int *)(**(code **)((ulonglong)*puVar1 * 4))(param2,puVar1[1]);
		    local_30 = 0;
		    local_2c = &local_4;
		    do {
		      do {
		        do {
		          piVar7 = local_4;
		          iVar14 = *local_4;
		          if (*(ushort *)(iVar14 + 0xb6) != 0) {
		            uVar15 = 0;
		            do {
		              piVar4 = (int *)(*(int *)(iVar14 + 0x58) + uVar15 * 8);
		              if (System_Collections_IEnumerator_TypeInfo == *piVar4) {
		                puVar2 = (undefined4 *)(iVar14 + piVar4[1] * 8 + 0xc0);
		                goto code_r0x81caee28;
		              }
		              uVar15 = uVar15 + 1;
		            } while (*(ushort *)(iVar14 + 0xb6) != uVar15);
		          }
		          DAT_ram_009d3e38 = (uint *)0x0;
		          puVar2 = (undefined4 *)
		                   import::env::invoke_iiii
		                             (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                              System_Collections_IEnumerator_TypeInfo,0);
		          if (DAT_ram_009d3e38 == (uint *)0x1) {
		code_r0x81caee74:
		            DAT_ram_009d3e38 = (uint *)0x0;
		            uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            iVar14 = global_1;
		            goto code_r0x81caf61c;
		          }
		code_r0x81caee28:
		          DAT_ram_009d3e38 = (uint *)0x0;
		          iVar14 = import::env::invoke_iii(*puVar2,piVar7,puVar2[1]);
		          piVar7 = local_4;
		          if (DAT_ram_009d3e38 == (uint *)0x1) goto code_r0x81caee74;
		          if (iVar14 == 0) {
		            iVar14 = 8;
		            iVar6 = 0;
		            puVar1 = DAT_ram_009d3e38;
		            goto code_r0x81caf667;
		          }
		          iVar14 = *local_4;
		          if (*(ushort *)(iVar14 + 0xb6) != 0) {
		            uVar15 = 0;
		            do {
		              piVar4 = (int *)(*(int *)(iVar14 + 0x58) + uVar15 * 8);
		              if (System_Collections_Generic_IEnumerator_ISrvCommand__TypeInfo == *piVar4) {
		                puVar2 = (undefined4 *)(iVar14 + piVar4[1] * 8 + 0xc0);
		                goto code_r0x81caef23;
		              }
		              uVar15 = uVar15 + 1;
		            } while (*(ushort *)(iVar14 + 0xb6) != uVar15);
		          }
		          DAT_ram_009d3e38 = (uint *)0x0;
		          puVar2 = (undefined4 *)
		                   import::env::invoke_iiii
		                             (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                              System_Collections_Generic_IEnumerator_ISrvCommand__TypeInfo,0);
		          if (DAT_ram_009d3e38 == (uint *)0x1) {
		code_r0x81caf15d:
		            DAT_ram_009d3e38 = (uint *)0x0;
		            uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            iVar14 = global_1;
		            goto code_r0x81caf61c;
		          }
		code_r0x81caef23:
		          DAT_ram_009d3e38 = (uint *)0x0;
		          piVar7 = (int *)import::env::invoke_iii(*puVar2,piVar7,puVar2[1]);
		          if (DAT_ram_009d3e38 == (uint *)0x1) goto code_r0x81caf15d;
		          if (*(int *)(System_DateTimeOffset_TypeInfo + 0x74) == 0) {
		            DAT_ram_009d3e38 = (uint *)0x0;
		            import::env::invoke_vi
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                       System_DateTimeOffset_TypeInfo);
		            if (DAT_ram_009d3e38 == (uint *)0x1) goto code_r0x81caf15d;
		          }
		          DAT_ram_009d3e38 = (uint *)0x0;
		          import::env::invoke_vii
		                    (s___Scripting__UnityEngine__Contex_ram_0000360b + 0x29,&local_40,0);
		          iVar14 = (int)DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = (uint *)0x0;
		          if (iVar14 == 1) {
		            uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            iVar14 = global_1;
		            goto code_r0x81caf61c;
		          }
		          local_10 = local_38;
		          local_18 = CONCAT44(puStack_3c,local_40);
		          DAT_ram_009d3e38 = (uint *)0x0;
		          lVar8 = unnamed_function_184054
		                            (s___Scripting__UnityEngine__Contex_ram_0000360b + 0x2a,&local_18,0);
		          iVar14 = (int)DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = (uint *)0x0;
		          if (iVar14 == 1) {
		            uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            iVar14 = global_1;
		            goto code_r0x81caf61c;
		          }
		          iVar14 = *piVar7;
		          if (*(ushort *)(iVar14 + 0xb6) != 0) {
		            uVar15 = 0;
		            do {
		              piVar4 = (int *)(*(int *)(iVar14 + 0x58) + uVar15 * 8);
		              if (Core_Net_ISrvCommand_TypeInfo == *piVar4) {
		                puVar2 = (undefined4 *)(piVar4[1] * 8 + iVar14 + 200);
		                goto code_r0x81caf0af;
		              }
		              uVar15 = uVar15 + 1;
		            } while (*(ushort *)(iVar14 + 0xb6) != uVar15);
		          }
		          DAT_ram_009d3e38 = (uint *)0x0;
		          puVar2 = (undefined4 *)
		                   import::env::invoke_iiii
		                             (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar7,
		                              Core_Net_ISrvCommand_TypeInfo,1);
		          if (DAT_ram_009d3e38 == (uint *)0x1) {
		code_r0x81caf17b:
		            DAT_ram_009d3e38 = (uint *)0x0;
		            uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            iVar14 = global_1;
		            goto code_r0x81caf61c;
		          }
		code_r0x81caf0af:
		          DAT_ram_009d3e38 = (uint *)0x0;
		          lVar9 = unnamed_function_184054(*puVar2,piVar7,puVar2[1]);
		          if (DAT_ram_009d3e38 == (uint *)0x1) goto code_r0x81caf17b;
		          DAT_ram_009d3e38 = (uint *)0x0;
		          System_Collections_Generic_Queue_uint___Enqueue
		                    (&local_40,*(undefined4 *)(param1 + 0xc),
		                     Method_System_Collections_Generic_Queue_LatencyDto__GetEnumerator__);
		          iVar14 = (int)DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = (uint *)0x0;
		          if (iVar14 == 1) {
		            uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            iVar14 = global_1;
		            goto code_r0x81caf61c;
		          }
		          local_20 = local_38;
		          local_28 = CONCAT44(puStack_3c,local_40);
		          iVar13 = 0;
		          local_40 = 0;
		          puStack_3c = &local_28;
		          while( true ) {
		            DAT_ram_009d3e38 = (uint *)0x0;
		            iVar14 = import::env::invoke_iii
		                               (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x46,&local_28,
		                                Method_System_Collections_Generic_Queue_Enumerator_LatencyDto__MoveNext__
		                               );
		            if (DAT_ram_009d3e38 == (uint *)0x1) break;
		            if (iVar14 == 0) {
		              iVar14 = 7;
		              iVar6 = 0;
		              goto code_r0x81caf363;
		            }
		            DAT_ram_009d3e38 = (uint *)0x0;
		            iVar14 = import::env::invoke_iii
		                               (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x47,&local_28,
		                                Method_System_Collections_Generic_Queue_Enumerator_LatencyDto__get_Current__
		                               );
		            if (DAT_ram_009d3e38 == (uint *)0x1) break;
		            iVar6 = *(int *)(iVar14 + 8);
		            iVar12 = *piVar7;
		            if (*(ushort *)(iVar12 + 0xb6) != 0) {
		              uVar15 = 0;
		              do {
		                piVar4 = (int *)(*(int *)(iVar12 + 0x58) + uVar15 * 8);
		                if (Core_Net_ISrvCommand_TypeInfo == *piVar4) {
		                  puVar2 = (undefined4 *)(iVar12 + piVar4[1] * 8 + 0xc0);
		                  goto code_r0x81caf2ac;
		                }
		                uVar15 = uVar15 + 1;
		              } while (*(ushort *)(iVar12 + 0xb6) != uVar15);
		            }
		            DAT_ram_009d3e38 = (uint *)0x0;
		            puVar2 = (undefined4 *)
		                     import::env::invoke_iiii
		                               (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar7,
		                                Core_Net_ISrvCommand_TypeInfo,0);
		            if (DAT_ram_009d3e38 == (uint *)0x1) break;
		code_r0x81caf2ac:
		            DAT_ram_009d3e38 = (uint *)0x0;
		            iVar12 = import::env::invoke_iii(*puVar2,piVar7,puVar2[1]);
		            if (DAT_ram_009d3e38 == (uint *)0x1) break;
		            if (iVar12 == iVar6) {
		              *(longlong *)(iVar14 + 0x10) = lVar8 - lVar9;
		              iVar13 = iVar13 + 1;
		            }
		          }
		          DAT_ram_009d3e38 = (uint *)0x0;
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          iVar14 = global_1;
		          iVar6 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		          if (iVar14 != iVar6) {
		code_r0x81caf40b:
		            DAT_ram_009d3e38 = (uint *)0x0;
		            import::env::invoke_ii(s___Scripting__UnityEngine__UnityS_ram_00003636 + 5,&local_40);
		            iVar6 = (int)DAT_ram_009d3e38;
		            DAT_ram_009d3e38 = (uint *)0x0;
		            if (iVar6 != 1) goto code_r0x81caf61c;
		            goto code_r0x81caf7fc;
		          }
		          piVar4 = (int *)import::env::__cxa_begin_catch(uVar3);
		          iVar6 = *piVar4;
		          iVar14 = 0;
		          DAT_ram_009d3e38 = (uint *)0x0;
		          local_40 = iVar6;
		          import::env::invoke_v(0x123);
		          iVar12 = (int)DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = (uint *)0x0;
		          if (iVar12 == 1) {
		            uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            iVar14 = global_1;
		            goto code_r0x81caf40b;
		          }
		code_r0x81caf363:
		          DAT_ram_009d3e38 = (uint *)0x0;
		          System_Collections_Generic_Queue_object___GetEnumerator
		                    (&local_28,
		                     Method_System_Collections_Generic_Queue_Enumerator_LatencyDto__Dispose__);
		          iVar12 = (int)DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = (uint *)0x0;
		          if (iVar12 == 1) {
		            uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            iVar14 = global_1;
		            goto code_r0x81caf61c;
		          }
		          if (iVar6 != 0) {
		            DAT_ram_009d3e38 = (uint *)0x0;
		            import::env::invoke_vi(s_var<private>_posTex__array<vec4<_ram_00000655 + 0x1d3,iVar6);
		            iVar14 = (int)DAT_ram_009d3e38;
		            DAT_ram_009d3e38 = (uint *)0x0;
		            if (iVar14 != 1) {
		              do {
		                halt_trap();
		              } while( true );
		            }
		            uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            iVar14 = global_1;
		            goto code_r0x81caf61c;
		          }
		          iVar6 = 0;
		          if ((iVar14 != 0) &&
		             ((((puVar1 = (uint *)0x0, iVar14 == 1 || (iVar14 == 2)) || (iVar14 == 3)) ||
		              (((iVar14 == 4 || (iVar14 == 5)) || ((iVar14 == 6 || (iVar14 != 7))))))))
		          goto code_r0x81caf667;
		        } while (iVar13 != 0);
		        uVar3 = *(undefined4 *)(param1 + 0xc);
		        iVar14 = *piVar7;
		        if (*(ushort *)(iVar14 + 0xb6) != 0) {
		          uVar15 = 0;
		          do {
		            piVar4 = (int *)(*(int *)(iVar14 + 0x58) + uVar15 * 8);
		            if (Core_Net_ISrvCommand_TypeInfo == *piVar4) {
		              puVar2 = (undefined4 *)(iVar14 + piVar4[1] * 8 + 0xc0);
		              goto code_r0x81caf4db;
		            }
		            uVar15 = uVar15 + 1;
		          } while (*(ushort *)(iVar14 + 0xb6) != uVar15);
		        }
		        DAT_ram_009d3e38 = (uint *)0x0;
		        puVar2 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar7,
		                            Core_Net_ISrvCommand_TypeInfo,0);
		        if (DAT_ram_009d3e38 == (uint *)0x1) {
		code_r0x81caf603:
		          DAT_ram_009d3e38 = (uint *)0x0;
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          iVar14 = global_1;
		          goto code_r0x81caf61c;
		        }
		code_r0x81caf4db:
		        DAT_ram_009d3e38 = (uint *)0x0;
		        uVar5 = import::env::invoke_iii(*puVar2,piVar7,puVar2[1]);
		        if (DAT_ram_009d3e38 == (uint *)0x1) goto code_r0x81caf603;
		        DAT_ram_009d3e38 = (uint *)0x0;
		        iVar14 = import::env::invoke_ii
		                           (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                            Core_Net_Monitor_Responseability_LatencyDto_TypeInfo);
		        if (DAT_ram_009d3e38 == (uint *)0x1) {
		code_r0x81caf60d:
		          DAT_ram_009d3e38 = (uint *)0x0;
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          iVar14 = global_1;
		          goto code_r0x81caf61c;
		        }
		        *(longlong *)(iVar14 + 0x10) = lVar8 - lVar9;
		        *(undefined4 *)(iVar14 + 8) = uVar5;
		        DAT_ram_009d3e38 = (uint *)0x0;
		        import::env::invoke_viii
		                  (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x14c,uVar3,iVar14,
		                   Method_System_Collections_Generic_Queue_LatencyDto__Enqueue__);
		        if (DAT_ram_009d3e38 == (uint *)0x1) goto code_r0x81caf60d;
		      } while (*(int *)(*(int *)(param1 + 0xc) + 0x14) != iVar11);
		      DAT_ram_009d3e38 = (uint *)0x0;
		      import::env::invoke_iii
		                (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x155,*(int *)(param1 + 0xc),
		                 Method_System_Collections_Generic_Queue_LatencyDto__Dequeue__);
		      iVar14 = (int)DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = (uint *)0x0;
		    } while (iVar14 != 1);
		    uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    iVar14 = global_1;
		code_r0x81caf61c:
		    iVar6 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		    if (iVar6 == iVar14) {
		      piVar7 = (int *)import::env::__cxa_begin_catch(uVar3);
		      iVar6 = *piVar7;
		      iVar14 = 0;
		      DAT_ram_009d3e38 = (uint *)0x0;
		      local_30 = iVar6;
		      import::env::invoke_v(0x123);
		      puVar1 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = (uint *)0x0;
		      if (puVar1 != (uint *)0x1) {
		code_r0x81caf667:
		        piVar7 = local_4;
		        DAT_ram_009d3e38 = (uint *)0x0;
		        if (local_4 != (int *)0x0) {
		          uVar15 = 0;
		          iVar13 = *local_4;
		          if (*(ushort *)(iVar13 + 0xb6) != 0) {
		            do {
		              if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar13 + 0x58) + uVar15 * 8)) {
		                puVar1 = (uint *)(iVar13 + *(int *)(*(int *)(iVar13 + 0x58) + uVar15 * 8 + 4) * 8 +
		                                 0xc0);
		                goto code_r0x81caf6df;
		              }
		              uVar15 = uVar15 + 1;
		            } while (*(ushort *)(iVar13 + 0xb6) != uVar15);
		          }
		          puVar1 = (uint *)func_ii_1080(local_4,System_IDisposable_TypeInfo,0);
		code_r0x81caf6df:
		          (**(code **)((ulonglong)*puVar1 * 4))(piVar7,puVar1[1]);
		        }
		        if (iVar6 != 0) {
		          System_Data_DataSet__ValidateLocaleConstraint(iVar6);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        if ((iVar14 == 0) ||
		           (((iVar14 != 1 && (iVar14 != 2)) &&
		            ((iVar14 != 3 &&
		             ((((iVar14 != 4 && (iVar14 != 5)) && (iVar14 != 6)) && ((iVar14 != 7 && (iVar14 == 8)))
		              ))))))) {
		          puVar1 = (uint *)0x0;
		          iVar14 = *(int *)(param1 + 0xc);
		          if (*(int *)(iVar14 + 0x14) == iVar11) {
		            if (*(int *)(Core_Net_Monitor_Responseability_Analysis_AverageAnalysis___c_TypeInfo +
		                        0x74) == 0) {
		              func_ii_306000(Core_Net_Monitor_Responseability_Analysis_AverageAnalysis___c_TypeInfo)
		              ;
		            }
		            puVar2 = *(undefined4 **)
		                      (Core_Net_Monitor_Responseability_Analysis_AverageAnalysis___c_TypeInfo + 0x5c
		                      );
		            iVar11 = puVar2[1];
		            if (iVar11 == 0) {
		              if (*(int *)(Core_Net_Monitor_Responseability_Analysis_AverageAnalysis___c_TypeInfo +
		                          0x74) == 0) {
		                func_ii_306000(
		                              Core_Net_Monitor_Responseability_Analysis_AverageAnalysis___c_TypeInfo
		                              );
		                puVar2 = *(undefined4 **)
		                          (Core_Net_Monitor_Responseability_Analysis_AverageAnalysis___c_TypeInfo +
		                          0x5c);
		              }
		              uVar3 = *puVar2;
		              iVar11 = unnamed_function_1417(System_Func_LatencyDto__long__TypeInfo);
		              System_Func_object__Int32Enum___Invoke
		                        (iVar11,uVar3,
		                         Method_Core_Net_Monitor_Responseability_Analysis_AverageAnalysis___c__Analyze_b__2_0__
		                         ,0);
		              *(int *)(*(int *)(
		                               Core_Net_Monitor_Responseability_Analysis_AverageAnalysis___c_TypeInfo
		                               + 0x5c) + 4) = iVar11;
		            }
		            dVar10 = System_Linq_Enumerable__Any___Il2CppFullySharedGenericType_
		                               (iVar14,iVar11,Method_System_Linq_Enumerable_Average_LatencyDto___);
		            *param3 = dVar10;
		            puVar1 = (uint *)(uint)((double)*(int *)(*(int *)(param1 + 8) + 0xc) < dVar10);
		          }
		        }
		        goto code_r0x81caf812;
		      }
		      uVar3 = import::env::__cxa_find_matching_catch_2();
		    }
		    DAT_ram_009d3e38 = (uint *)0x0;
		    import::env::invoke_ii(s___Scripting__UnityEngine__UnityS_ram_00003636 + 6,&local_30);
		    iVar11 = (int)DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = (uint *)0x0;
		    if (iVar11 != 1) {
		      import::env::__resumeException(uVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		code_r0x81caf7fc:
		    DAT_ram_009d3e38 = (uint *)0x0;
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		code_r0x81caf812:
		  return (uint)puVar1 & 1;
		}
		*/

		}

		// Token: 0x06005AFB RID: 23291 RVA: 0x000102C0 File Offset: 0x0000E4C0
		[Token(Token = "0x6005AFB")]
		[Address(RVA = "0xA7DA", Offset = "0xA7DA", VA = "0xA7DA", Slot = "7")]
		public override bool Analyze(IEnumerable<ISrvCommand> value, out double calcValue)
		{
		/* --- GHIDRA: Analyze ---
		void Core_Net_Monitor_Responseability_Analysis_AverageAnalysis__Analyze(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a605b9 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Core_Net_Monitor_Responseability_Analysis_AverageAnalysis___c_TypeInfo);
		    DAT_ram_00a605b9 = '\x01';
		  }
		  uVar1 = unnamed_function_1417
		                    (Core_Net_Monitor_Responseability_Analysis_AverageAnalysis___c_TypeInfo);
		  **(undefined4 **)(Core_Net_Monitor_Responseability_Analysis_AverageAnalysis___c_TypeInfo + 0x5c) =
		       uVar1;
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x040031BE RID: 12734
		[Token(Token = "0x40031BE")]
		[FieldOffset(Offset = "0xC")]
		private Queue<LatencyDto> _latencies;
	}
}
