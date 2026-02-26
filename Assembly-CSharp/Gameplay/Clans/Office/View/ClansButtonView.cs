using System;
using AssetContent;
using Gameplay.Clans.Office.Controller;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.Clans.Office.View
{
	// Token: 0x02000A00 RID: 2560
	[Token(Token = "0x2000A00")]
	public class ClansButtonView : MonoBehaviour
	{
		// Token: 0x17000C05 RID: 3077
		// (get) Token: 0x06003CEC RID: 15596 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C05")]
		public GameAnimatedButton GameAnimatedButton
		{
			[Token(Token = "0x6003CEC")]
			[Address(RVA = "0x8BAC", Offset = "0x8BAC", VA = "0x8BAC")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003CED RID: 15597 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CED")]
		[Address(RVA = "0x8BAD", Offset = "0x8BAD", VA = "0x8BAD")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_Clans_Office_View_ClansButtonView__OnDestroy(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param2_00;
		  undefined4 param3;
		  int *piVar3;
		  int iVar4;
		  int *param4;
		  
		  if (DAT_ram_00a57f09 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Clans_Office_Controller_ClansButtonViewMediator_TypeInfo)
		    ;
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a57f09 = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  piVar3 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x230);
		        goto code_r0x80e7e5e4;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,0x2e);
		code_r0x80e7e5e4:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  param4 = *(int **)(iVar4 + 0x18);
		  param2_00 = (**(code **)((ulonglong)*(uint *)(*param4 + 0x100) * 4))
		                        (param4,*(undefined4 *)(*param4 + 0x104));
		  param3 = (**(code **)((ulonglong)*(uint *)(*param4 + 0x110) * 4))
		                     (param4,*(undefined4 *)(*param4 + 0x114));
		  piVar3 = (int *)unnamed_function_1417
		                            (Gameplay_Clans_Office_Controller_ClansButtonViewMediator_TypeInfo);
		  Gameplay_Clans_Office_Controller_ClanTreasuryViewMediator___c__DisplayClass22_0___ShowColossusWarningWindow_b__0
		            (piVar3,param2_00,param3,param4,0);
		  (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x160) * 4))
		            (piVar3,param1,*(undefined4 *)(*piVar3 + 0x164));
		  *(int **)(param1 + 0x14) = piVar3;
		  return;
		}
		*/

		}

		// Token: 0x06003CEE RID: 15598 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CEE")]
		[Address(RVA = "0x8BAE", Offset = "0x8BAE", VA = "0x8BAE")]
		private void Start()
		{
		}

		// Token: 0x06003CEF RID: 15599 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CEF")]
		[Address(RVA = "0x8BAF", Offset = "0x8BAF", VA = "0x8BAF")]
		public ClansButtonView()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Clans_Office_View_ClansButtonView___ctor
		               (int param1,int param2,int param3,undefined4 param4)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int *piVar3;
		  undefined4 *puVar4;
		  uint *puVar5;
		  undefined8 param3_00;
		  int iVar6;
		  undefined4 param2_00;
		  int *piVar7;
		  int param2_01;
		  int iVar8;
		  uint uVar9;
		  int local_28;
		  int local_24;
		  int **ppiStack_20;
		  undefined8 local_1c;
		  int *local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  iVar8 = 0;
		  if (DAT_ram_00a57f0a == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_GameObject__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_GameObject__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_GameObject__get_Current__);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_IEnumerator_UserRatingKindDic__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_GameObject__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_GameObject__Clear__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_GameObject__GetEnumerator__);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_TitleIconValueBackground___)
		    ;
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_UserRatingKindDic__GetEnumerator__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ulong__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ulong__get_Item__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_16098);
		    DAT_ram_00a57f0a = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  local_14 = (int *)0x0;
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_24,*(undefined4 *)(param1 + 0x18),
		             Method_System_Collections_Generic_List_GameObject__GetEnumerator__);
		  local_8 = local_1c;
		  local_24 = 0;
		  ppiStack_20 = (int **)&local_10;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar1 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_10,
		                       Method_System_Collections_Generic_List_Enumerator_GameObject__MoveNext__);
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e7e850;
		    }
		    if (iVar1 == 0) goto code_r0x80e7e8a6;
		    uVar2 = local_8._4_4_;
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi
		                (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,UnityEngine_Object_TypeInfo
		                );
		      if (DAT_ram_009d3e38 == 1) break;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_vii(s_struct_Uniforms___color__array<v_ram_00000aff + 0x274,uVar2,0);
		  } while (DAT_ram_009d3e38 != 1);
		  DAT_ram_009d3e38 = 0;
		  uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80e7e850:
		  iVar6 = global_1;
		  iVar1 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar6 == iVar1) {
		    piVar3 = (int *)import::env::__cxa_begin_catch(uVar2);
		    iVar1 = *piVar3;
		    DAT_ram_009d3e38 = 0;
		    local_24 = iVar1;
		    import::env::invoke_v(0x123);
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 != 1) {
		      if (iVar1 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar1);
		        do {
		          halt_trap();
		        } while( true );
		      }
		code_r0x80e7e8a6:
		      DAT_ram_009d3e38 = 0;
		      iVar6 = *(int *)(param1 + 0x18);
		      iVar1 = *(int *)(iVar6 + 0xc);
		      *(undefined4 *)(iVar6 + 0xc) = 0;
		      *(int *)(iVar6 + 0x10) = *(int *)(iVar6 + 0x10) + 1;
		      if (0 < iVar1) {
		        func_ii_2064(*(undefined4 *)(iVar6 + 8),0,iVar1,0);
		      }
		      local_14 = (int *)Google_Protobuf_Collections_RepeatedField_float___Equals
		                                  (*(undefined4 *)(param3 + 0x260),
		                                   Method_Google_Protobuf_Collections_RepeatedField_UserRatingKindDic__GetEnumerator__
		                                  );
		      local_24 = 0;
		      ppiStack_20 = &local_14;
		code_r0x80e7e954:
		      do {
		        do {
		          piVar3 = local_14;
		          iVar6 = *local_14;
		          if (*(ushort *)(iVar6 + 0xb6) != 0) {
		            uVar9 = 0;
		            do {
		              piVar7 = (int *)(*(int *)(iVar6 + 0x58) + uVar9 * 8);
		              if (System_Collections_IEnumerator_TypeInfo == *piVar7) {
		                puVar4 = (undefined4 *)(iVar6 + piVar7[1] * 8 + 0xc0);
		                goto code_r0x80e7e9ed;
		              }
		              uVar9 = uVar9 + 1;
		            } while (*(ushort *)(iVar6 + 0xb6) != uVar9);
		          }
		          DAT_ram_009d3e38 = 0;
		          puVar4 = (undefined4 *)
		                   import::env::invoke_iiii
		                             (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_14,
		                              System_Collections_IEnumerator_TypeInfo,0);
		          if (DAT_ram_009d3e38 == 1) {
		code_r0x80e7ef8d:
		            DAT_ram_009d3e38 = 0;
		            uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x80e7efb0;
		          }
		code_r0x80e7e9ed:
		          DAT_ram_009d3e38 = 0;
		          iVar6 = import::env::invoke_iii(*puVar4,piVar3,puVar4[1]);
		          piVar3 = local_14;
		          if (DAT_ram_009d3e38 == 1) goto code_r0x80e7ef8d;
		          if (iVar6 == 0) goto code_r0x80e7eff9;
		          iVar6 = *local_14;
		          if (*(ushort *)(iVar6 + 0xb6) != 0) {
		            uVar9 = 0;
		            do {
		              piVar7 = (int *)(*(int *)(iVar6 + 0x58) + uVar9 * 8);
		              if (System_Collections_Generic_IEnumerator_UserRatingKindDic__TypeInfo == *piVar7) {
		                puVar4 = (undefined4 *)(iVar6 + piVar7[1] * 8 + 0xc0);
		                goto code_r0x80e7eac8;
		              }
		              uVar9 = uVar9 + 1;
		            } while (*(ushort *)(iVar6 + 0xb6) != uVar9);
		          }
		          DAT_ram_009d3e38 = 0;
		          puVar4 = (undefined4 *)
		                   import::env::invoke_iiii
		                             (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_14,
		                              System_Collections_Generic_IEnumerator_UserRatingKindDic__TypeInfo,0);
		          if (DAT_ram_009d3e38 == 1) {
		code_r0x80e7ef9e:
		            DAT_ram_009d3e38 = 0;
		            uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x80e7efb0;
		          }
		code_r0x80e7eac8:
		          DAT_ram_009d3e38 = 0;
		          iVar6 = import::env::invoke_iii(*puVar4,piVar3,puVar4[1]);
		          if (DAT_ram_009d3e38 == 1) goto code_r0x80e7ef9e;
		        } while (*(char *)(iVar6 + 0x10) == '\0');
		        iVar1 = *(int *)(iVar6 + 0xc) + -1;
		        param2_01 = *(int *)(*(int *)(param2 + 0x34) + 0x34);
		        if (iVar1 < *(int *)(param2_01 + 0xc)) {
		          DAT_ram_009d3e38 = 0;
		          param3_00 = unnamed_function_184059
		                                (s_struct_Uniforms___color__array<v_ram_00001b87 + 0xe1,param2_01,
		                                 iVar1,
		                                 Method_Google_Protobuf_Collections_RepeatedField_ulong__get_Item__)
		          ;
		          iVar1 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar1 == 1) {
		            uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x80e7efb0;
		          }
		          uVar2 = *(undefined4 *)(param1 + 0x14);
		          param2_00 = *(undefined4 *)(param1 + 0x10);
		          if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_vi
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                       UnityEngine_Object_TypeInfo);
		            iVar1 = DAT_ram_009d3e38;
		            DAT_ram_009d3e38 = 0;
		            if (iVar1 == 1) {
		              uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		              goto code_r0x80e7efb0;
		            }
		          }
		          DAT_ram_009d3e38 = 0;
		          piVar3 = (int *)import::env::invoke_iiii
		                                    (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x2ce,
		                                     param2_00,uVar2,
		                                     Method_UnityEngine_Object_Instantiate_TitleIconValueBackground___
		                                    );
		          iVar1 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar1 == 1) {
		            uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x80e7efb0;
		          }
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_viii
		                    (s_struct_Uniforms___color__array<v_ram_00001b87 + 0xe2,piVar3,iVar8,0);
		          iVar1 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar1 == 1) {
		            uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x80e7efb0;
		          }
		          DAT_ram_009d3e38 = 0;
		          uVar2 = import::env::invoke_iii
		                            (s_struct_Uniforms___color__array<v_ram_00000aff + 0x25c,piVar3,0);
		          if (DAT_ram_009d3e38 != 1) {
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_viii
		                      (s_struct_Uniforms___color__array<v_ram_000013c7 + 0x26d,uVar2,1,0);
		            if (DAT_ram_009d3e38 != 1) {
		              DAT_ram_009d3e38 = 0;
		              unnamed_function_184058
		                        (*(undefined4 *)(*piVar3 + 0xe0),piVar3,param3_00,
		                         *(undefined4 *)(*piVar3 + 0xe4));
		              iVar1 = DAT_ram_009d3e38;
		              DAT_ram_009d3e38 = 0;
		              if (iVar1 == 1) {
		                uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                goto code_r0x80e7efb0;
		              }
		              DAT_ram_009d3e38 = 0;
		              uVar2 = import::env::invoke_iii
		                                (s_struct_Uniforms___color__array<v_ram_00001b87 + 0xe3,iVar6,0);
		              if (DAT_ram_009d3e38 != 1) {
		                DAT_ram_009d3e38 = 0;
		                import::env::invoke_viii
		                          (s_struct_Uniforms___color__array<v_ram_00001b87 + 0xe4,piVar3,uVar2,0);
		                if (DAT_ram_009d3e38 != 1) {
		                  DAT_ram_009d3e38 = 0;
		                  uVar2 = import::env::invoke_iii
		                                    (s_struct_Uniforms___color__array<v_ram_00001b87 + 0xe5,iVar6,0)
		                  ;
		                  if (DAT_ram_009d3e38 != 1) {
		                    DAT_ram_009d3e38 = 0;
		                    import::env::invoke_viii
		                              (s_struct_Uniforms___color__array<v_ram_00001b87 + 0xe6,piVar3,uVar2,0
		                              );
		                    if (DAT_ram_009d3e38 != 1) {
		                      iVar1 = *(int *)(param1 + 0x18);
		                      DAT_ram_009d3e38 = 0;
		                      uVar2 = import::env::invoke_iii
		                                        (s_struct_Uniforms___color__array<v_ram_00000aff + 0x25c,
		                                         piVar3,0);
		                      iVar6 = Method_System_Collections_Generic_List_GameObject__Add__;
		                      if (DAT_ram_009d3e38 == 1) {
		code_r0x80e7ef83:
		                        DAT_ram_009d3e38 = 0;
		                        uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                        goto code_r0x80e7efb0;
		                      }
		                      *(int *)(iVar1 + 0x10) = *(int *)(iVar1 + 0x10) + 1;
		                      uVar9 = *(uint *)(iVar1 + 0xc);
		                      if (uVar9 < *(uint *)(*(int *)(iVar1 + 8) + 0xc)) {
		                        *(uint *)(iVar1 + 0xc) = uVar9 + 1;
		                        *(undefined4 *)(*(int *)(iVar1 + 8) + uVar9 * 4 + 0x10) = uVar2;
		                      }
		                      else {
		                        DAT_ram_009d3e38 = 0;
		                        import::env::invoke_viii
		                                  (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar1,
		                                   uVar2,*(undefined4 *)
		                                          (*(int *)(*(int *)(iVar6 + 0x10) + 0x60) + 0x38));
		                        if (DAT_ram_009d3e38 == 1) goto code_r0x80e7ef83;
		                      }
		                      iVar8 = iVar8 + 1;
		                      goto code_r0x80e7e954;
		                    }
		                  }
		                  DAT_ram_009d3e38 = 0;
		                  uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                  goto code_r0x80e7efb0;
		                }
		              }
		              DAT_ram_009d3e38 = 0;
		              uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		              goto code_r0x80e7efb0;
		            }
		          }
		          DAT_ram_009d3e38 = 0;
		          uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80e7efb0;
		        }
		        DAT_ram_009d3e38 = 0;
		        local_28 = *(int *)(iVar6 + 0xc);
		        uVar2 = import::env::invoke_iii
		                          (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x19,DAT_ram_00a66958,
		                           &local_28);
		        iVar6 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar6 == 1) {
		          uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80e7efb0;
		        }
		        DAT_ram_009d3e38 = 0;
		        uVar2 = import::env::invoke_iiii
		                          (s_struct_Uniforms___color__array<v_ram_00000f84 + 0x1c0,
		                           StringLiteral_16098,uVar2,0);
		        if (DAT_ram_009d3e38 == 1) break;
		        if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vi
		                    (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,OKG_Logs_Debug_TypeInfo
		                    );
		          if (DAT_ram_009d3e38 == 1) break;
		        }
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x3f,uVar2,0);
		      } while (DAT_ram_009d3e38 != 1);
		      DAT_ram_009d3e38 = 0;
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80e7efb0:
		      iVar8 = global_1;
		      iVar6 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar8 == iVar6) {
		        piVar3 = (int *)import::env::__cxa_begin_catch(uVar2);
		        local_24 = *piVar3;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_v(0x123);
		        iVar8 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar8 != 1) {
		code_r0x80e7eff9:
		          DAT_ram_009d3e38 = 0;
		          piVar3 = *ppiStack_20;
		          if (piVar3 != (int *)0x0) {
		            uVar9 = 0;
		            iVar8 = *piVar3;
		            if (*(ushort *)(iVar8 + 0xb6) != 0) {
		              do {
		                if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar9 * 8)) {
		                  puVar5 = (uint *)(iVar8 + *(int *)(*(int *)(iVar8 + 0x58) + uVar9 * 8 + 4) * 8 +
		                                   0xc0);
		                  goto code_r0x80e7f074;
		                }
		                uVar9 = uVar9 + 1;
		              } while (*(ushort *)(iVar8 + 0xb6) != uVar9);
		            }
		            puVar5 = (uint *)func_ii_1080(piVar3,System_IDisposable_TypeInfo,0);
		code_r0x80e7f074:
		            (**(code **)((ulonglong)*puVar5 * 4))(piVar3,puVar5[1]);
		          }
		          if (local_24 != 0) {
		            System_Data_DataSet__ValidateLocaleConstraint(local_24);
		            do {
		              halt_trap();
		            } while( true );
		          }
		          return;
		        }
		        uVar2 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0xe7,&local_24);
		      goto joined_r0x80e7f0c7;
		    }
		    uVar2 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0xe0,&local_24);
		joined_r0x80e7f0c7:
		  if (DAT_ram_009d3e38 == 1) {
		    DAT_ram_009d3e38 = 0;
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::__resumeException(uVar2);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x040021CC RID: 8652
		[Token(Token = "0x40021CC")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private GameAnimatedButton _gameAnimatedButton;

		// Token: 0x040021CD RID: 8653
		[Token(Token = "0x40021CD")]
		[FieldOffset(Offset = "0x14")]
		private ClansButtonViewMediator _mediator;
	}
}
