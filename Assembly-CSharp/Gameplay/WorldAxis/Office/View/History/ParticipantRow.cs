using System;
using Gameplay.UserInfo.View;
using Gameplay.WorldAxis.Office.Model;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.WorldAxis.Office.View.History
{
	// Token: 0x02000317 RID: 791
	[Token(Token = "0x2000317")]
	public class ParticipantRow : TitleIconValueBackground
	{
		// Token: 0x0600124B RID: 4683 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600124B")]
		[Address(RVA = "0x6445", Offset = "0x6445", VA = "0x6445")]
		public void Init(HistoryModel.Participant participant)
		{
		}

		// Token: 0x0600124C RID: 4684 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600124C")]
		[Address(RVA = "0x6446", Offset = "0x6446", VA = "0x6446")]
		public ParticipantRow()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_WorldAxis_Office_View_History_ParticipantRow___ctor
		               (int param1,int *param2,undefined4 param3,undefined4 param4)
		
		{
		  int iVar1;
		  uint uVar2;
		  undefined4 *puVar3;
		  undefined4 uVar4;
		  int iVar5;
		  undefined4 uVar6;
		  uint *puVar7;
		  undefined4 uVar8;
		  int iVar9;
		  int *piVar10;
		  int *piVar11;
		  undefined8 local_28;
		  undefined4 local_20;
		  undefined4 local_1c;
		  longlong local_18;
		  int *local_10;
		  int *local_c;
		  int local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a58bc5 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_ICollection_HistoryModel_Participant__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_IEnumerable_HistoryModel_Participant__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_IEnumerator_HistoryModel_Participant__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_KeyValuePair_string__string____TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_ParticipantRow___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Transform_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_21978);
		    Mono_Security_ASN1__get_Item(&StringLiteral_17774);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28579);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25302);
		    DAT_ram_00a58bc5 = '\x01';
		  }
		  local_8 = 0;
		  local_c = (int *)0x0;
		  local_4 = (int *)UnityEngine_Transform__set_hasChanged(*(undefined4 *)(param1 + 0x10),0);
		  local_10 = &local_8;
		  local_18 = ZEXT48(&local_4) << 0x20;
		  do {
		    piVar10 = local_4;
		    iVar9 = *local_4;
		    if (*(ushort *)(iVar9 + 0xb6) != 0) {
		      uVar2 = 0;
		      do {
		        piVar11 = (int *)(*(int *)(iVar9 + 0x58) + uVar2 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar11) {
		          puVar3 = (undefined4 *)(iVar9 + piVar11[1] * 8 + 0xc0);
		          goto code_r0x80f831b1;
		        }
		        uVar2 = uVar2 + 1;
		      } while (*(ushort *)(iVar9 + 0xb6) != uVar2);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar3 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80f833f4:
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f833fc;
		    }
		code_r0x80f831b1:
		    DAT_ram_009d3e38 = 0;
		    iVar9 = import::env::invoke_iii(*puVar3,piVar10,puVar3[1]);
		    piVar10 = local_4;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80f833f4;
		    if (iVar9 == 0) goto code_r0x80f83445;
		    iVar9 = *local_4;
		    if (*(ushort *)(iVar9 + 0xb6) != 0) {
		      uVar2 = 0;
		      do {
		        piVar11 = (int *)(*(int *)(iVar9 + 0x58) + uVar2 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar11) {
		          puVar3 = (undefined4 *)(piVar11[1] * 8 + iVar9 + 200);
		          goto code_r0x80f8328e;
		        }
		        uVar2 = uVar2 + 1;
		      } while (*(ushort *)(iVar9 + 0xb6) != uVar2);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar3 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,1);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80f833d6:
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f833fc;
		    }
		code_r0x80f8328e:
		    DAT_ram_009d3e38 = 0;
		    piVar10 = (int *)import::env::invoke_iii(*puVar3,piVar10,puVar3[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80f833d6;
		    if (piVar10 != (int *)0x0) {
		      if (((uint)*(byte *)(*piVar10 + 0xb8) < (uint)*(byte *)(UnityEngine_Transform_TypeInfo + 0xb8)
		          ) || (*(int *)(*(int *)(*piVar10 + 100) +
		                         (uint)*(byte *)(UnityEngine_Transform_TypeInfo + 0xb8) * 4 + -4) !=
		                UnityEngine_Transform_TypeInfo)) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vii
		                  (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x183,piVar10,
		                   UnityEngine_Transform_TypeInfo);
		        iVar9 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar9 != 1) {
		          do {
		            halt_trap();
		          } while( true );
		        }
		        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80f833fc;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar4 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x25c,piVar10,0);
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
		code_r0x80f833fc:
		  iVar9 = global_1;
		  iVar5 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar9 == iVar5) {
		    puVar3 = (undefined4 *)import::env::__cxa_begin_catch(uVar4);
		    DAT_ram_009d3e38 = 0;
		    local_18 = CONCAT44(local_18._4_4_,*puVar3);
		    import::env::invoke_v(0x123);
		    iVar9 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar9 != 1) {
		code_r0x80f83445:
		      DAT_ram_009d3e38 = 0;
		      local_8 = func_ii_1082(local_4,System_IDisposable_TypeInfo);
		      piVar10 = (int *)*local_10;
		      if (piVar10 != (int *)0x0) {
		        iVar9 = *piVar10;
		        if (*(ushort *)(iVar9 + 0xb6) != 0) {
		          uVar2 = 0;
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar9 + 0x58) + uVar2 * 8)) {
		              puVar7 = (uint *)(iVar9 + *(int *)(*(int *)(iVar9 + 0x58) + uVar2 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x80f834d5;
		            }
		            uVar2 = uVar2 + 1;
		          } while (*(ushort *)(iVar9 + 0xb6) != uVar2);
		        }
		        puVar7 = (uint *)func_ii_1080(piVar10,System_IDisposable_TypeInfo,0);
		code_r0x80f834d5:
		        (**(code **)((ulonglong)*puVar7 * 4))(piVar10,puVar7[1]);
		      }
		      if ((int)local_18 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint((int)local_18);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      uVar4 = *(undefined4 *)(param1 + 0x18);
		      if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_GameLocalization_TypeInfo);
		      }
		      uVar6 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_17774,1,0,1,0,0,0,0);
		      iVar9 = Mono_Security_ASN1Convert__ToOid
		                        (System_Collections_Generic_KeyValuePair_string__string____TypeInfo,2);
		      iVar5 = *param2;
		      if (*(ushort *)(iVar5 + 0xb6) != 0) {
		        uVar2 = 0;
		        do {
		          if (System_Collections_Generic_ICollection_HistoryModel_Participant__TypeInfo ==
		              *(int *)(*(int *)(iVar5 + 0x58) + uVar2 * 8)) {
		            puVar7 = (uint *)(iVar5 + *(int *)(*(int *)(iVar5 + 0x58) + uVar2 * 8 + 4) * 8 + 0xc0);
		            goto code_r0x80f835a6;
		          }
		          uVar2 = uVar2 + 1;
		        } while (*(ushort *)(iVar5 + 0xb6) != uVar2);
		      }
		      puVar7 = (uint *)func_ii_1080(param2,
		                                    System_Collections_Generic_ICollection_HistoryModel_Participant__TypeInfo
		                                    ,0);
		code_r0x80f835a6:
		      local_1c = (**(code **)((ulonglong)*puVar7 * 4))(param2,puVar7[1]);
		      uVar2 = 0;
		      uVar8 = func_ii_1081(DAT_ram_00a66954,&local_1c);
		      uVar8 = func_ii_4419(StringLiteral_28579,uVar8,0);
		      local_18 = 0;
		      System_Text_Formatting_StringView__get_IsEmpty
		                (&local_18,StringLiteral_21978,uVar8,
		                 Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		      *(longlong *)(iVar9 + 0x10) = local_18;
		      local_20 = param3;
		      uVar8 = func_ii_1081(DAT_ram_00a66954,&local_20);
		      uVar8 = func_ii_4419(StringLiteral_28579,uVar8,0);
		      local_28 = 0;
		      System_Text_Formatting_StringView__get_IsEmpty
		                (&local_28,StringLiteral_25302,uVar8,
		                 Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		      *(undefined8 *)(iVar9 + 0x18) = local_28;
		      uVar6 = Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsRewardsTab_ClanWarsRewardsView__GetPlacesText
		                        (uVar6,iVar9,0);
		      UnityEngine_Component__GetComponentInChildren_object_(uVar4,uVar6,0);
		      iVar9 = *param2;
		      if (*(ushort *)(iVar9 + 0xb6) != 0) {
		        do {
		          if (System_Collections_Generic_IEnumerable_HistoryModel_Participant__TypeInfo ==
		              *(int *)(*(int *)(iVar9 + 0x58) + uVar2 * 8)) {
		            puVar7 = (uint *)(iVar9 + *(int *)(*(int *)(iVar9 + 0x58) + uVar2 * 8 + 4) * 8 + 0xc0);
		            goto code_r0x80f836de;
		          }
		          uVar2 = uVar2 + 1;
		        } while (*(ushort *)(iVar9 + 0xb6) != uVar2);
		      }
		      puVar7 = (uint *)func_ii_1080(param2,
		                                    System_Collections_Generic_IEnumerable_HistoryModel_Participant__TypeInfo
		                                    ,0);
		code_r0x80f836de:
		      local_c = (int *)(**(code **)((ulonglong)*puVar7 * 4))(param2,puVar7[1]);
		      local_18 = ZEXT48(&local_c) << 0x20;
		      iVar9 = 0;
		      do {
		        piVar10 = local_c;
		        iVar5 = *local_c;
		        if (*(ushort *)(iVar5 + 0xb6) != 0) {
		          uVar2 = 0;
		          do {
		            piVar11 = (int *)(*(int *)(iVar5 + 0x58) + uVar2 * 8);
		            if (System_Collections_IEnumerator_TypeInfo == *piVar11) {
		              puVar3 = (undefined4 *)(iVar5 + piVar11[1] * 8 + 0xc0);
		              goto code_r0x80f837f1;
		            }
		            uVar2 = uVar2 + 1;
		          } while (*(ushort *)(iVar5 + 0xb6) != uVar2);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar3 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_c,
		                            System_Collections_IEnumerator_TypeInfo,0);
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x80f83b79:
		          DAT_ram_009d3e38 = 0;
		          uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80f83b81;
		        }
		code_r0x80f837f1:
		        DAT_ram_009d3e38 = 0;
		        iVar5 = import::env::invoke_iii(*puVar3,piVar10,puVar3[1]);
		        piVar10 = local_c;
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80f83b79;
		        if (iVar5 == 0) {
		          iVar9 = 0;
		          goto code_r0x80f83bca;
		        }
		        iVar5 = *local_c;
		        if (*(ushort *)(iVar5 + 0xb6) != 0) {
		          uVar2 = 0;
		          do {
		            piVar11 = (int *)(*(int *)(iVar5 + 0x58) + uVar2 * 8);
		            if (System_Collections_Generic_IEnumerator_HistoryModel_Participant__TypeInfo ==
		                *piVar11) {
		              puVar3 = (undefined4 *)(iVar5 + piVar11[1] * 8 + 0xc0);
		              goto code_r0x80f838cb;
		            }
		            uVar2 = uVar2 + 1;
		          } while (*(ushort *)(iVar5 + 0xb6) != uVar2);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar3 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_c,
		                            System_Collections_Generic_IEnumerator_HistoryModel_Participant__TypeInfo
		                            ,0);
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x80f83b33:
		          DAT_ram_009d3e38 = 0;
		          uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80f83b81;
		        }
		code_r0x80f838cb:
		        DAT_ram_009d3e38 = 0;
		        iVar5 = import::env::invoke_iii(*puVar3,piVar10,puVar3[1]);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80f83b33;
		        uVar4 = *(undefined4 *)(param1 + 0x10);
		        uVar6 = *(undefined4 *)(param1 + 0x14);
		        if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vi
		                    (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                     UnityEngine_Object_TypeInfo);
		          iVar1 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar1 == 1) {
		            uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x80f83b81;
		          }
		        }
		        DAT_ram_009d3e38 = 0;
		        piVar10 = (int *)import::env::invoke_iiii
		                                   (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x2ce,uVar6,
		                                    uVar4,Method_UnityEngine_Object_Instantiate_ParticipantRow___);
		        iVar1 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar1 == 1) {
		          uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80f83b81;
		        }
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x107,piVar10[7],
		                   *(undefined4 *)(*(int *)(iVar5 + 8) + 0x28),0);
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x80f83b51:
		          DAT_ram_009d3e38 = 0;
		          uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80f83b81;
		        }
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_struct_Uniforms___color__array<v_ram_00001b87 + 4,piVar10[0xf],
		                   *(undefined4 *)(iVar5 + 0x14),0);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80f83b51;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_struct_Uniforms___color__array<v_ram_000013c7 + 0x26d,piVar10[0xe],
		                   (uint)*(byte *)(iVar5 + 0xc),0);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80f83b51;
		        DAT_ram_009d3e38 = 0;
		        unnamed_function_184058
		                  (*(undefined4 *)(*piVar10 + 0xe0),piVar10,(longlong)(iVar9 + 1),
		                   *(undefined4 *)(*piVar10 + 0xe4));
		        iVar5 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar5 == 1) {
		          uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80f83b81;
		        }
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_struct_Uniforms___color__array<v_ram_00001b87 + 0xe2,piVar10,iVar9,0);
		        iVar5 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar5 == 1) {
		          uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80f83b81;
		        }
		        DAT_ram_009d3e38 = 0;
		        uVar4 = import::env::invoke_iii
		                          (s_struct_Uniforms___color__array<v_ram_00000aff + 0x25c,piVar10,0);
		        if (DAT_ram_009d3e38 == 1) break;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii(s_struct_Uniforms___color__array<v_ram_000013c7 + 0x26d,uVar4,1,0);
		        iVar9 = iVar9 + 1;
		      } while (DAT_ram_009d3e38 != 1);
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80f83b81:
		      iVar9 = global_1;
		      iVar5 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar9 == iVar5) {
		        piVar10 = (int *)import::env::__cxa_begin_catch(uVar4);
		        iVar9 = *piVar10;
		        DAT_ram_009d3e38 = 0;
		        local_18 = CONCAT44(local_18._4_4_,iVar9);
		        import::env::invoke_v(0x123);
		        iVar5 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar5 != 1) {
		code_r0x80f83bca:
		          piVar10 = local_c;
		          DAT_ram_009d3e38 = 0;
		          if (local_c != (int *)0x0) {
		            uVar2 = 0;
		            iVar5 = *local_c;
		            if (*(ushort *)(iVar5 + 0xb6) != 0) {
		              do {
		                if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar2 * 8)) {
		                  puVar7 = (uint *)(iVar5 + *(int *)(*(int *)(iVar5 + 0x58) + uVar2 * 8 + 4) * 8 +
		                                   0xc0);
		                  goto code_r0x80f83c42;
		                }
		                uVar2 = uVar2 + 1;
		              } while (*(ushort *)(iVar5 + 0xb6) != uVar2);
		            }
		            puVar7 = (uint *)func_ii_1080(local_c,System_IDisposable_TypeInfo,0);
		code_r0x80f83c42:
		            (**(code **)((ulonglong)*puVar7 * 4))(piVar10,puVar7[1]);
		          }
		          if (iVar9 != 0) {
		            System_Data_DataSet__ValidateLocaleConstraint(iVar9);
		            do {
		              halt_trap();
		            } while( true );
		          }
		          return;
		        }
		        uVar4 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x252,&local_18);
		      goto joined_r0x80f83c90;
		    }
		    uVar4 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x251,&local_18);
		joined_r0x80f83c90:
		  if (DAT_ram_009d3e38 == 1) {
		    DAT_ram_009d3e38 = 0;
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::__resumeException(uVar4);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x040009BF RID: 2495
		[Token(Token = "0x40009BF")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _deadObject;

		// Token: 0x040009C0 RID: 2496
		[Token(Token = "0x40009C0")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private Image _dollIcon;
	}
}
