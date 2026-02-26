using System;
using System.Collections;
using AssetContent;
using Core.Animations;
using Gameplay.EndlessPaymentOptionsList.Model;
using Il2CppDummyDll;
using Protocol.Consts;
using TMPro;
using UI;
using UI.Rewards;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.EndlessPaymentOptionsList.View
{
	// Token: 0x02000831 RID: 2097
	[Token(Token = "0x2000831")]
	public class EndlessPaymentOptionView : AbstractDataRenderer<CardData>
	{
		// Token: 0x06003153 RID: 12627 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003153")]
		[Address(RVA = "0x81AB", Offset = "0x81AB", VA = "0x81AB", Slot = "19")]
		protected override void HandleDataChanged()
		{
		/* --- GHIDRA: HandleDataChanged ---
		void Gameplay_EndlessPaymentOptionsList_View_EndlessPaymentOptionView__HandleDataChanged
		               (int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int *piVar3;
		  int local_4;
		  
		  if (DAT_ram_00a57622 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_1234);
		    DAT_ram_00a57622 = '\x01';
		  }
		  iVar1 = Core_Extensions_Dict_AccountOptionsDicExt__GetTitle(*(undefined4 *)(param2 + 0x10),0);
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x44),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar2,(uint)(0 < iVar1),0);
		  piVar3 = *(int **)(param1 + 0x28);
		  local_4 = iVar1;
		  uVar2 = func_ii_1081(DAT_ram_00a66954,&local_4);
		  uVar2 = func_ii_4419(StringLiteral_1234,uVar2,0);
		  iVar1 = *piVar3;
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x2d0) * 4))
		            (piVar3,uVar2,*(undefined4 *)(iVar1 + 0x2d4));
		  return;
		}
		*/

		}

		// Token: 0x06003154 RID: 12628 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003154")]
		[Address(RVA = "0x81AC", Offset = "0x81AC", VA = "0x81AC")]
		private void DrawVipPoints(CardData data)
		{
		/* --- GHIDRA: DrawVipPoints ---
		/* WARNING: Removing unreachable block (ram,0x80dba452) */
		
		void Gameplay_EndlessPaymentOptionsList_View_EndlessPaymentOptionView__DrawVipPoints
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 *puVar3;
		  undefined4 uVar4;
		  int iVar5;
		  int *piVar6;
		  uint *puVar7;
		  undefined4 uVar8;
		  double param2_00;
		  int iVar9;
		  int iVar10;
		  undefined4 uVar11;
		  undefined4 uVar12;
		  int *piVar13;
		  uint uVar14;
		  float4 local_20;
		  float4 local_28;
		  int local_38;
		  int **local_34;
		  int *local_30;
		  undefined4 uStack_2c;
		  undefined8 local_18;
		  int *local_10;
		  undefined4 uStack_c;
		  int local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a57623 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_SingleOrDefault_EndlessPaymentOptionView_ResourceValueColorsConfig___
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_Resources__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_Resources__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_Resources__get_Current__);
		    Mono_Security_ASN1__get_Item
		              (&System_Func_EndlessPaymentOptionView_ResourceValueColorsConfig__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Resources__GetEnumerator__)
		    ;
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_SimpleIconValue___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_StringUtils_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Transform_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_EndlessPaymentOptionsList_View_EndlessPaymentOptionView___c__DisplayClass22_0__DrawResourceAmount_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_EndlessPaymentOptionsList_View_EndlessPaymentOptionView___c__DisplayClass22_0_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&StringLiteral_28780);
		    DAT_ram_00a57623 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = (int *)0x0;
		  uStack_c = 0;
		  local_18 = 0;
		  _local_20 = 0;
		  _local_28 = 0;
		  uVar8 = 0;
		  uVar2 = Core_Extensions_Dict_ResourceSetExt__Less
		                    (*(undefined4 *)(*(int *)(*(int *)(param2 + 0x10) + 0x34) + 0xc),0.0,0);
		  local_4 = (int *)UnityEngine_Transform__set_hasChanged(param1[0x19],0);
		  local_30 = &local_8;
		  local_38 = 0;
		  local_34 = &local_4;
		  do {
		    piVar6 = local_4;
		    iVar9 = *local_4;
		    if (*(ushort *)(iVar9 + 0xb6) != 0) {
		      uVar14 = 0;
		      do {
		        piVar13 = (int *)(*(int *)(iVar9 + 0x58) + uVar14 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar13) {
		          puVar3 = (undefined4 *)(iVar9 + piVar13[1] * 8 + 0xc0);
		          goto code_r0x80db9fe5;
		        }
		        uVar14 = uVar14 + 1;
		      } while (*(ushort *)(iVar9 + 0xb6) != uVar14);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar3 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80dba228:
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80dba230;
		    }
		code_r0x80db9fe5:
		    DAT_ram_009d3e38 = 0;
		    iVar9 = import::env::invoke_iii(*puVar3,piVar6,puVar3[1]);
		    piVar6 = local_4;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80dba228;
		    if (iVar9 == 0) goto code_r0x80dba279;
		    iVar9 = *local_4;
		    if (*(ushort *)(iVar9 + 0xb6) != 0) {
		      uVar14 = 0;
		      do {
		        piVar13 = (int *)(*(int *)(iVar9 + 0x58) + uVar14 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar13) {
		          puVar3 = (undefined4 *)(piVar13[1] * 8 + iVar9 + 200);
		          goto code_r0x80dba0c2;
		        }
		        uVar14 = uVar14 + 1;
		      } while (*(ushort *)(iVar9 + 0xb6) != uVar14);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar3 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,1);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80dba20a:
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80dba230;
		    }
		code_r0x80dba0c2:
		    DAT_ram_009d3e38 = 0;
		    piVar6 = (int *)import::env::invoke_iii(*puVar3,piVar6,puVar3[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80dba20a;
		    if (piVar6 != (int *)0x0) {
		      if (((uint)*(byte *)(*piVar6 + 0xb8) < (uint)*(byte *)(UnityEngine_Transform_TypeInfo + 0xb8))
		         || (*(int *)(*(int *)(*piVar6 + 100) +
		                      (uint)*(byte *)(UnityEngine_Transform_TypeInfo + 0xb8) * 4 + -4) !=
		             UnityEngine_Transform_TypeInfo)) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vii
		                  (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x183,piVar6,
		                   UnityEngine_Transform_TypeInfo);
		        iVar9 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar9 != 1) {
		          do {
		            halt_trap();
		          } while( true );
		        }
		        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80dba230;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar4 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x25c,piVar6,0);
		    if (DAT_ram_009d3e38 == 1) break;
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi
		                (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,UnityEngine_Object_TypeInfo
		                );
		      if (DAT_ram_009d3e38 == 1) break;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_vii(s_struct_Uniforms___color__array<v_ram_00000aff + 0x274,uVar4,0);
		  } while (DAT_ram_009d3e38 != 1);
		  DAT_ram_009d3e38 = 0;
		  uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80dba230:
		  iVar9 = global_1;
		  iVar5 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar9 == iVar5) {
		    piVar6 = (int *)import::env::__cxa_begin_catch(uVar4);
		    local_38 = *piVar6;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar9 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar9 != 1) {
		code_r0x80dba279:
		      DAT_ram_009d3e38 = 0;
		      local_8 = func_ii_1082(local_4,System_IDisposable_TypeInfo);
		      piVar6 = (int *)*local_30;
		      if (piVar6 != (int *)0x0) {
		        iVar9 = *piVar6;
		        if (*(ushort *)(iVar9 + 0xb6) != 0) {
		          uVar14 = 0;
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar9 + 0x58) + uVar14 * 8)) {
		              puVar7 = (uint *)(iVar9 + *(int *)(*(int *)(iVar9 + 0x58) + uVar14 * 8 + 4) * 8 + 0xc0
		                               );
		              goto code_r0x80dba309;
		            }
		            uVar14 = uVar14 + 1;
		          } while (*(ushort *)(iVar9 + 0xb6) != uVar14);
		        }
		        puVar7 = (uint *)func_ii_1080(piVar6,System_IDisposable_TypeInfo,0);
		code_r0x80dba309:
		        (**(code **)((ulonglong)*puVar7 * 4))(piVar6,CONCAT44(uVar8,puVar7[1]));
		      }
		      if (local_38 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(local_38);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		                (&local_38,uVar2,Method_System_Collections_Generic_List_Resources__GetEnumerator__);
		      local_10 = local_30;
		      uStack_c = uStack_2c;
		      local_18 = CONCAT44(local_34,local_38);
		      local_38 = 0;
		      local_34 = (int **)&local_18;
		      do {
		        DAT_ram_009d3e38 = 0;
		        iVar5 = import::env::invoke_iii
		                          (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x21f,&local_18,
		                           Method_System_Collections_Generic_List_Enumerator_Resources__MoveNext__);
		        iVar9 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar9 == 1) {
		          uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80dba9b6;
		        }
		        if (iVar5 == 0) {
		          DAT_ram_009d3e38 = 0;
		          return;
		        }
		        DAT_ram_009d3e38 = 0;
		        iVar9 = import::env::invoke_ii
		                          (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                           Gameplay_EndlessPaymentOptionsList_View_EndlessPaymentOptionView___c__DisplayClass22_0_TypeInfo
		                          );
		        if (DAT_ram_009d3e38 == 1) {
		          DAT_ram_009d3e38 = 0;
		          uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80dba9b6;
		        }
		        *(undefined4 *)(iVar9 + 8) = uStack_c;
		        DAT_ram_009d3e38 = 0;
		        param2_00 = func_ii_6906(*(undefined4 *)(*(int *)(*(int *)(param2 + 0x10) + 0x34) + 0xc),
		                                 uStack_c,0);
		        iVar5 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar5 == 1) {
		          uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80dba9b6;
		        }
		        iVar5 = param1[0x19];
		        iVar10 = param1[0x17];
		        if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vi
		                    (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                     UnityEngine_Object_TypeInfo);
		          iVar1 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar1 == 1) {
		            uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x80dba9b6;
		          }
		        }
		        DAT_ram_009d3e38 = 0;
		        uVar8 = import::env::invoke_iiii
		                          (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x2ce,iVar10,iVar5,
		                           Method_UnityEngine_Object_Instantiate_SimpleIconValue___);
		        iVar5 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar5 == 1) {
		          uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80dba9b6;
		        }
		        DAT_ram_009d3e38 = 0;
		        iVar10 = import::env::invoke_iii
		                           (*(undefined4 *)(*param1 + 0x130),param1,*(undefined4 *)(*param1 + 0x134)
		                           );
		        iVar5 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar5 == 1) {
		          uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80dba9b6;
		        }
		        piVar6 = *(int **)(iVar10 + 8);
		        iVar5 = *piVar6;
		        if (*(ushort *)(iVar5 + 0xb6) != 0) {
		          uVar14 = 0;
		          do {
		            piVar13 = (int *)(*(int *)(iVar5 + 0x58) + uVar14 * 8);
		            if (Core_Dict_IDictProvider_TypeInfo == *piVar13) {
		              puVar3 = (undefined4 *)(piVar13[1] * 8 + iVar5 + 0xd0);
		              goto code_r0x80dba5fe;
		            }
		            uVar14 = uVar14 + 1;
		          } while (*(ushort *)(iVar5 + 0xb6) != uVar14);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar3 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar6,
		                            Core_Dict_IDictProvider_TypeInfo,2);
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x80dba878:
		          DAT_ram_009d3e38 = 0;
		          uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80dba9b6;
		        }
		code_r0x80dba5fe:
		        DAT_ram_009d3e38 = 0;
		        uVar2 = import::env::invoke_iii(*puVar3,piVar6,puVar3[1]);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80dba878;
		        DAT_ram_009d3e38 = 0;
		        uVar2 = import::env::invoke_iiii
		                          (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x334,uVar2,
		                           *(undefined4 *)(iVar9 + 8),0);
		        iVar5 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar5 == 1) {
		          uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80dba9b6;
		        }
		        DAT_ram_009d3e38 = 0;
		        uVar2 = import::env::invoke_iii
		                          (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x335,uVar2,0);
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x80dba88c:
		          DAT_ram_009d3e38 = 0;
		          uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80dba9b6;
		        }
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x336,uVar8,uVar2,0);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80dba88c;
		        if (*(int *)(Utils_StringUtils_TypeInfo + 0x74) == 0) {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vi
		                    (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                     Utils_StringUtils_TypeInfo);
		          iVar5 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar5 == 1) {
		            uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x80dba9b6;
		          }
		        }
		        DAT_ram_009d3e38 = 0;
		        uVar2 = import::env::invoke_idii
		                          (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x337,param2_00,
		                           StringLiteral_28780,0);
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x80dba8a0:
		          DAT_ram_009d3e38 = 0;
		          uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80dba9b6;
		        }
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x338,uVar8,uVar2,0);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80dba8a0;
		        iVar5 = param1[0x16];
		        DAT_ram_009d3e38 = 0;
		        uVar2 = import::env::invoke_ii
		                          (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                           System_Func_EndlessPaymentOptionView_ResourceValueColorsConfig__bool__TypeInfo
		                          );
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x80dba8aa:
		          DAT_ram_009d3e38 = 0;
		          uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80dba9b6;
		        }
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viiii
		                  (s_struct_Uniforms___color__array<v_ram_00000aff + 0x21b,uVar2,iVar9,
		                   Method_Gameplay_EndlessPaymentOptionsList_View_EndlessPaymentOptionView___c__DisplayClass22_0__DrawResourceAmount_b__0__
		                   ,0);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80dba8aa;
		        DAT_ram_009d3e38 = 0;
		        iVar5 = import::env::invoke_iiii
		                          (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x339,iVar5,uVar2,
		                           Method_System_Linq_Enumerable_SingleOrDefault_EndlessPaymentOptionView_ResourceValueColorsConfig___
		                          );
		        iVar9 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar9 == 1) {
		          uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80dba9b6;
		        }
		        if (iVar5 == 0) {
		          uVar2 = 0x3f800000;
		          uVar4 = 0;
		          uVar11 = 0;
		          uVar12 = 0;
		        }
		        else {
		          uVar2 = *(undefined4 *)(iVar5 + 0x18);
		          uVar4 = *(undefined4 *)(iVar5 + 0x10);
		          uVar11 = *(undefined4 *)(iVar5 + 0xc);
		          uVar12 = *(undefined4 *)(iVar5 + 0x14);
		        }
		        _local_20 = CONCAT44(uVar2,uVar12);
		        _local_28 = CONCAT44(uVar4,uVar11);
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x33a,uVar8,&local_28,0);
		        iVar9 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar9 == 1) {
		          uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80dba9b6;
		        }
		        DAT_ram_009d3e38 = 0;
		        uVar8 = import::env::invoke_iii
		                          (s_struct_Uniforms___color__array<v_ram_00000aff + 0x25c,uVar8,0);
		        if (DAT_ram_009d3e38 == 1) break;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii(s_struct_Uniforms___color__array<v_ram_000013c7 + 0x26d,uVar8,1,0);
		      } while (DAT_ram_009d3e38 != 1);
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80dba9b6:
		      iVar9 = global_1;
		      iVar5 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar9 == iVar5) {
		        piVar6 = (int *)import::env::__cxa_begin_catch(uVar4);
		        iVar5 = *piVar6;
		        DAT_ram_009d3e38 = 0;
		        local_38 = iVar5;
		        import::env::invoke_v(0x123);
		        iVar9 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar9 != 1) {
		          if (iVar5 == 0) {
		            DAT_ram_009d3e38 = 0;
		            return;
		          }
		          System_Data_DataSet__ValidateLocaleConstraint(iVar5);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        uVar4 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_000017c8 + 0x33b,&local_38);
		      goto joined_r0x80dbaa48;
		    }
		    uVar4 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_000017c8 + 0x332,&local_38);
		joined_r0x80dbaa48:
		  if (DAT_ram_009d3e38 != 1) {
		    DAT_ram_009d3e38 = 0;
		    import::env::__resumeException(uVar4);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::__cxa_find_matching_catch_3(0);
		  unnamed_function_937();
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06003155 RID: 12629 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003155")]
		[Address(RVA = "0x81AD", Offset = "0x81AD", VA = "0x81AD")]
		private void DrawResourceAmount(CardData data)
		{
		/* --- GHIDRA: DrawResourceAmount ---
		void Gameplay_EndlessPaymentOptionsList_View_EndlessPaymentOptionView__DrawResourceAmount
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x38),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,0,0);
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x4c),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,1,0);
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x2c),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,0,0);
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x60),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,0,0);
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x40),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,0,0);
		  func_ii_7357(*(undefined4 *)(param1 + 0x4c),0,0);
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x50),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,0,0);
		  return;
		}
		*/

		}

		// Token: 0x06003156 RID: 12630 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003156")]
		[Address(RVA = "0x81AE", Offset = "0x81AE", VA = "0x81AE")]
		private void DrawEmptyState(CardData data)
		{
		/* --- GHIDRA: DrawEmptyState ---
		void Gameplay_EndlessPaymentOptionsList_View_EndlessPaymentOptionView__DrawEmptyState
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  uint param2_00;
		  
		  param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(param1 + 0x40),0);
		  if (*(int *)(*(int *)(param2 + 0xc) + 8) == 0) {
		    param2_00 = (uint)(*(char *)(param2 + 0x18) != '\0');
		  }
		  else {
		    param2_00 = 1;
		  }
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (param1_00,param2_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06003157 RID: 12631 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003157")]
		[Address(RVA = "0x81AF", Offset = "0x81AF", VA = "0x81AF")]
		private void DrawLock(CardData data)
		{
		/* --- GHIDRA: DrawLock ---
		void Gameplay_EndlessPaymentOptionsList_View_EndlessPaymentOptionView__DrawLock
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int *piVar2;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a57624 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Extensions_Dict_RewardInfoExt_TypeInfo);
		    DAT_ram_00a57624 = '\x01';
		  }
		  param1_00 = *(undefined4 *)(param1 + 0x2c);
		  if (DAT_ram_00a57643 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToArray_RewardInfo___);
		    DAT_ram_00a57643 = '\x01';
		  }
		  uVar1 = func_ii_6295(*(undefined4 *)(*(int *)(param2 + 0x1c) + 0x14),
		                       Method_System_Linq_Enumerable_ToArray_RewardInfo___);
		  if (*(int *)(Core_Extensions_Dict_RewardInfoExt_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Extensions_Dict_RewardInfoExt_TypeInfo);
		  }
		  uVar1 = Core_Extensions_Dict_RewardInfoExt__GetGroupIndex(uVar1,0);
		  piVar2 = (int *)func_ii_7307(param1_00,uVar1,0);
		  (**(code **)((ulonglong)*(uint *)(*piVar2 + 0xf0) * 4))(piVar2,*(undefined4 *)(*piVar2 + 0xf4));
		  return;
		}
		*/

		}

		// Token: 0x06003158 RID: 12632 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003158")]
		[Address(RVA = "0x81B0", Offset = "0x81B0", VA = "0x81B0")]
		private void DrawReward(CardData data)
		{
		/* --- GHIDRA: DrawReward ---
		void Gameplay_EndlessPaymentOptionsList_View_EndlessPaymentOptionView__DrawReward
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (param1[0xd],0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x134));
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,(uint)(*(double *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x18) + 8) <= 0.0),0);
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (param1[0xc],0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x134));
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,(uint)(0.0 < *(double *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x18) + 8)),0);
		  iVar2 = param1[0xe];
		  uVar1 = Core_Extensions_Dict_EndlessPaymentOptionListDicExt__GetDiscountChanceDescription
		                    (*(undefined4 *)(*(int *)(param2 + 0x10) + 0x70),0);
		  Core_Extensions_Dict_PortalDicExt__GetCurrencyIcon60x66(iVar2,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x06003159 RID: 12633 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003159")]
		[Address(RVA = "0x81B1", Offset = "0x81B1", VA = "0x81B1")]
		private void DrawImages(CardData data)
		{
		/* --- GHIDRA: DrawImages ---
		void Gameplay_EndlessPaymentOptionsList_View_EndlessPaymentOptionView__DrawImages
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  
		  param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(param1 + 0x54),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (param1_00,(uint)(*(int *)(*(int *)(param2 + 0xc) + 0xc) != 0),0);
		  return;
		}
		*/

		}

		// Token: 0x0600315A RID: 12634 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600315A")]
		[Address(RVA = "0x81B2", Offset = "0x81B2", VA = "0x81B2")]
		private void DrawNextArrow(CardData data)
		{
		/* --- GHIDRA: DrawNextArrow ---
		void Gameplay_EndlessPaymentOptionsList_View_EndlessPaymentOptionView__DrawNextArrow
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int *piVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a57625 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_6822);
		    DAT_ram_00a57625 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x134));
		  piVar2 = (int *)param1[9];
		  if (*(double *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x18) + 8) <= 0.0) {
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar3 = func_ii_7508(StringLiteral_6822,1,0,1,0,0,0,0);
		  }
		  else {
		    uVar3 = *(undefined4 *)(*(int *)(*(int *)(param2 + 0x10) + 0x18) + 0x18);
		  }
		  iVar1 = *piVar2;
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x2d0) * 4))
		            (piVar2,uVar3,*(undefined4 *)(iVar1 + 0x2d4));
		  return;
		}
		*/

		}

		// Token: 0x0600315B RID: 12635 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600315B")]
		[Address(RVA = "0x81B3", Offset = "0x81B3", VA = "0x81B3")]
		private void DrawLabel(CardData data)
		{
		/* --- GHIDRA: DrawLabel ---
		void Gameplay_EndlessPaymentOptionsList_View_EndlessPaymentOptionView__DrawLabel
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  uint param2_00;
		  
		  param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (param1[0x14],0);
		  if (*(int *)(*(int *)(*(int *)(param2 + 0x10) + 0x70) + 0x10) == 0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x134));
		    param2_00 = (uint)(0.0 < *(double *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x18) + 8));
		  }
		  else {
		    param2_00 = 0;
		  }
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (param1_00,param2_00,0);
		  return;
		}
		*/

		}

		// Token: 0x0600315C RID: 12636 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600315C")]
		[Address(RVA = "0x81B4", Offset = "0x81B4", VA = "0x81B4")]
		private void DrawDiscountTopBanner(CardData data)
		{
		/* --- GHIDRA: DrawDiscountTopBanner ---
		uint Gameplay_EndlessPaymentOptionsList_View_EndlessPaymentOptionView__DrawDiscountTopBanner
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x134));
		  return (uint)(*(double *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x18) + 8) <= 0.0);
		}
		*/

		}

		// Token: 0x170009B3 RID: 2483
		// (get) Token: 0x0600315D RID: 12637 RVA: 0x0000A050 File Offset: 0x00008250
		[Token(Token = "0x170009B3")]
		private bool IsFree
		{
			[Token(Token = "0x600315D")]
			[Address(RVA = "0x81B5", Offset = "0x81B5", VA = "0x81B5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600315E RID: 12638 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600315E")]
		[Address(RVA = "0x81B6", Offset = "0x81B6", VA = "0x81B6")]
		private IEnumerator PlayBuyRoutine(bool hide)
		{
		/* --- GHIDRA: PlayBuyRoutine ---
		int Gameplay_EndlessPaymentOptionsList_View_EndlessPaymentOptionView__PlayBuyRoutine
		              (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a57627 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_EndlessPaymentOptionsList_View_EndlessPaymentOptionView__PlayBuy_d__33_TypeInfo
		              );
		    DAT_ram_00a57627 = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (
		                    Gameplay_EndlessPaymentOptionsList_View_EndlessPaymentOptionView__PlayBuy_d__33_TypeInfo
		                    );
		  *(undefined1 *)(iVar1 + 0x14) = (undefined1)param2;
		  *(undefined4 *)(iVar1 + 0x10) = param1;
		  *(undefined4 *)(iVar1 + 8) = 0;
		  return iVar1;
		}
		*/

			return null;
		}

		// Token: 0x0600315F RID: 12639 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600315F")]
		[Address(RVA = "0x81B7", Offset = "0x81B7", VA = "0x81B7")]
		public IEnumerator PlayBuy(bool hide)
		{
		/* --- GHIDRA: PlayBuy ---
		int Gameplay_EndlessPaymentOptionsList_View_EndlessPaymentOptionView__PlayBuy
		              (undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a57628 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_EndlessPaymentOptionsList_View_EndlessPaymentOptionView__ShowUnlock_d__34_TypeInfo
		              );
		    DAT_ram_00a57628 = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (
		                    Gameplay_EndlessPaymentOptionsList_View_EndlessPaymentOptionView__ShowUnlock_d__34_TypeInfo
		                    );
		  *(undefined4 *)(iVar1 + 0x10) = param1;
		  *(undefined4 *)(iVar1 + 8) = 0;
		  return iVar1;
		}
		*/

			return null;
		}

		// Token: 0x06003160 RID: 12640 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003160")]
		[Address(RVA = "0x81B8", Offset = "0x81B8", VA = "0x81B8")]
		public IEnumerator ShowUnlock()
		{
		/* --- GHIDRA: ShowUnlock ---
		int Gameplay_EndlessPaymentOptionsList_View_EndlessPaymentOptionView__ShowUnlock
		              (undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a57629 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_EndlessPaymentOptionsList_View_EndlessPaymentOptionView__ShowUnlockRoutine_d__35_TypeInfo
		              );
		    DAT_ram_00a57629 = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (
		                    Gameplay_EndlessPaymentOptionsList_View_EndlessPaymentOptionView__ShowUnlockRoutine_d__35_TypeInfo
		                    );
		  *(undefined4 *)(iVar1 + 0x10) = param1;
		  *(undefined4 *)(iVar1 + 8) = 0;
		  return iVar1;
		}
		*/

			return null;
		}

		// Token: 0x06003161 RID: 12641 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003161")]
		[Address(RVA = "0x81B9", Offset = "0x81B9", VA = "0x81B9")]
		private IEnumerator ShowUnlockRoutine()
		{
		/* --- GHIDRA: ShowUnlockRoutine ---
		void Gameplay_EndlessPaymentOptionsList_View_EndlessPaymentOptionView__ShowUnlockRoutine
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5762a == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_AbstractDataRenderer_CardData___ctor__);
		    DAT_ram_00a5762a = '\x01';
		  }
		  UnityEngine_ParticleSystemRenderer__GetMeshes
		            (param1,Method_UI_AbstractDataRenderer_CardData___ctor__);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06003162 RID: 12642 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003162")]
		[Address(RVA = "0x81BA", Offset = "0x81BA", VA = "0x81BA")]
		public EndlessPaymentOptionView()
		{
		}

		// Token: 0x04001AF2 RID: 6898
		[Token(Token = "0x4001AF2")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private TextMeshProUGUI _label;

		// Token: 0x04001AF3 RID: 6899
		[Token(Token = "0x4001AF3")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TextMeshProUGUI _vipPointsValue;

		// Token: 0x04001AF4 RID: 6900
		[Token(Token = "0x4001AF4")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private RewardsRender _rewardsRender;

		// Token: 0x04001AF5 RID: 6901
		[Token(Token = "0x4001AF5")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _backgroundPaid;

		// Token: 0x04001AF6 RID: 6902
		[Token(Token = "0x4001AF6")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private Image _backgroundFree;

		// Token: 0x04001AF7 RID: 6903
		[Token(Token = "0x4001AF7")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameRawImage _cover;

		// Token: 0x04001AF8 RID: 6904
		[Token(Token = "0x4001AF8")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private GameSpineUiAnimation _lockAnimation;

		// Token: 0x04001AF9 RID: 6905
		[Token(Token = "0x4001AF9")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Transform _lockOwner;

		// Token: 0x04001AFA RID: 6906
		[Token(Token = "0x4001AFA")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private Transform _vipPoints;

		// Token: 0x04001AFB RID: 6907
		[Token(Token = "0x4001AFB")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameSpineUiAnimation _idleBlickAnimation;

		// Token: 0x04001AFC RID: 6908
		[Token(Token = "0x4001AFC")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private GameSpineUiAnimation _getMerkerAnimation;

		// Token: 0x04001AFD RID: 6909
		[Token(Token = "0x4001AFD")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Image _saleTopMarker;

		// Token: 0x04001AFE RID: 6910
		[Token(Token = "0x4001AFE")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private Image _rightArrow;

		// Token: 0x04001AFF RID: 6911
		[Token(Token = "0x4001AFF")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private EndlessPaymentOptionView.ResourceValueColorsConfig[] _resourceValueColors;

		// Token: 0x04001B00 RID: 6912
		[Token(Token = "0x4001B00")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private SimpleIconValue _resourceAmontPrefab;

		// Token: 0x04001B01 RID: 6913
		[Token(Token = "0x4001B01")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Transform _amountOwner;

		// Token: 0x04001B02 RID: 6914
		[Token(Token = "0x4001B02")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		private Transform _resourcesAmountOwner;

		// Token: 0x04001B03 RID: 6915
		[Token(Token = "0x4001B03")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private TextMeshProUGUI _optionIdDbgField;

		// Token: 0x04001B04 RID: 6916
		[Token(Token = "0x4001B04")]
		[FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private Transform _lockWidget;

		// Token: 0x02000832 RID: 2098
		[Token(Token = "0x2000832")]
		[Serializable]
		public class ResourceValueColorsConfig
		{
			// Token: 0x170009B4 RID: 2484
			// (get) Token: 0x06003163 RID: 12643 RVA: 0x0000A068 File Offset: 0x00008268
			[Token(Token = "0x170009B4")]
			public Protocol.Consts.Resources ResourcesId
			{
				[Token(Token = "0x6003163")]
				[Address(RVA = "0x81BB", Offset = "0x81BB", VA = "0x81BB")]
				get
				{
					return Protocol.Consts.Resources.UnknownResource;
				}
			}

			// Token: 0x170009B5 RID: 2485
			// (get) Token: 0x06003164 RID: 12644 RVA: 0x0000A080 File Offset: 0x00008280
			[Token(Token = "0x170009B5")]
			public Color Color
			{
				[Token(Token = "0x6003164")]
				[Address(RVA = "0x81BC", Offset = "0x81BC", VA = "0x81BC")]
				get
				{
					return default(Color);
				}
			}

			// Token: 0x06003165 RID: 12645 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003165")]
			[Address(RVA = "0x81BD", Offset = "0x81BD", VA = "0x81BD")]
			public ResourceValueColorsConfig()
			{
			}

			// Token: 0x04001B05 RID: 6917
			[Token(Token = "0x4001B05")]
			[FieldOffset(Offset = "0x8")]
			[SerializeField]
			private Protocol.Consts.Resources _resourcesId;

			// Token: 0x04001B06 RID: 6918
			[Token(Token = "0x4001B06")]
			[FieldOffset(Offset = "0xC")]
			[SerializeField]
			private Color _color;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_IsFree ---
		int Gameplay_EndlessPaymentOptionsList_View_EndlessPaymentOptionView__get_IsFree
		              (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a57626 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_EndlessPaymentOptionsList_View_EndlessPaymentOptionView__PlayBuyRoutine_d__32_TypeInfo
		              );
		    DAT_ram_00a57626 = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (
		                    Gameplay_EndlessPaymentOptionsList_View_EndlessPaymentOptionView__PlayBuyRoutine_d__32_TypeInfo
		                    );
		  *(undefined1 *)(iVar1 + 0x14) = (undefined1)param2;
		  *(undefined4 *)(iVar1 + 0x10) = param1;
		  *(undefined4 *)(iVar1 + 8) = 0;
		  return iVar1;
		}
		*/

}
