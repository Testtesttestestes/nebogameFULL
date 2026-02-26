using System;
using Gameplay.UserInterface.Menu.ExternalLinks.Model;
using Gameplay.UserInterface.Menu.ExternalLinks.View;
using Il2CppDummyDll;
using MVC;
using Protocol.Dic;

namespace Gameplay.UserInterface.Menu.ExternalLinks.Control
{
	// Token: 0x020003E7 RID: 999
	[Token(Token = "0x20003E7")]
	public class ExternalLinksMediator : AbstractViewMediator<ExternalLinksModel, ExternalLinksEvents, ExternalLinksController, ExternalLinksView>
	{
		// Token: 0x06001750 RID: 5968 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001750")]
		[Address(RVA = "0x690D", Offset = "0x690D", VA = "0x690D")]
		public ExternalLinksMediator(ExternalLinksModel model, ExternalLinksEvents events, ExternalLinksController controller)
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Gameplay_UserInterface_Menu_ExternalLinks_Control_ExternalLinksMediator___ctor
		          (int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5989d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ExternalLinksModel__ExternalLinksEvents__ExternalLinksController__ExternalLinksView__get_View__
		              );
		    DAT_ram_00a5989d = '\x01';
		  }
		  return *(undefined4 *)(param1 + 0x14);
		}
		*/

		}

		// Token: 0x1700040C RID: 1036
		// (get) Token: 0x06001751 RID: 5969 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001752 RID: 5970 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700040C")]
		public override ExternalLinksView View
		{
			[Token(Token = "0x6001751")]
			[Address(RVA = "0x690E", Offset = "0x690E", VA = "0x690E", Slot = "19")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001752")]
			[Address(RVA = "0x690F", Offset = "0x690F", VA = "0x690F", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06001753 RID: 5971 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001753")]
		[Address(RVA = "0x6910", Offset = "0x6910", VA = "0x6910")]
		private void OnButtonClick(OptionsMenuButton data)
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_View ---
		void Gameplay_UserInterface_Menu_ExternalLinks_Control_ExternalLinksMediator__get_View
		               (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  int iVar3;
		  undefined4 *puVar4;
		  undefined4 uVar5;
		  int iVar6;
		  int *piVar7;
		  uint *puVar8;
		  undefined4 uVar9;
		  undefined4 param3_00;
		  int *piVar10;
		  int local_18;
		  int **local_14;
		  int *local_10;
		  int *local_c;
		  int local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a5989e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ExternalLinksModel__ExternalLinksEvents__ExternalLinksController__ExternalLinksView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ExternalLinksModel__ExternalLinksEvents__ExternalLinksController__ExternalLinksView__get_View__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ExternalLinksModel__ExternalLinksEvents__ExternalLinksController__ExternalLinksView__set_View__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_Component_GetComponent_ExternalLinkButtonView___);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_UserInterface_Menu_ExternalLinks_Control_ExternalLinksMediator_OnButtonClick__
		              );
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_IEnumerable_OptionsMenuButton__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_IEnumerator_OptionsMenuButton__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_ExternalLinkButtonView___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Transform_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_OptionsMenuButton__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_Events_UnityEvent_OptionsMenuButton__AddListener__);
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_Events_UnityEvent_OptionsMenuButton__RemoveListener__);
		    DAT_ram_00a5989e = '\x01';
		  }
		  local_4 = (int *)0x0;
		  local_8 = 0;
		  local_c = (int *)0x0;
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(param1[5],0);
		  if (iVar2 == 0) {
		code_r0x8108035b:
		    param1[5] = param2;
		    iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(param2,0);
		    if (iVar2 == 0) {
		      return;
		    }
		    local_4 = (int *)UnityEngine_Transform__set_hasChanged(*(undefined4 *)(param1[5] + 0x10),0);
		    local_10 = &local_8;
		    local_18 = 0;
		    local_14 = &local_4;
		    do {
		      piVar7 = local_4;
		      iVar2 = *local_4;
		      if (*(ushort *)(iVar2 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          piVar10 = (int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8);
		          if (System_Collections_IEnumerator_TypeInfo == *piVar10) {
		            puVar4 = (undefined4 *)(iVar2 + piVar10[1] * 8 + 0xc0);
		            goto code_r0x81080447;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar4 = (undefined4 *)
		               import::env::invoke_iiii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                          System_Collections_IEnumerator_TypeInfo,0);
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x81080688:
		        DAT_ram_009d3e38 = 0;
		        uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x81080690;
		      }
		code_r0x81080447:
		      DAT_ram_009d3e38 = 0;
		      iVar2 = import::env::invoke_iii(*puVar4,piVar7,puVar4[1]);
		      piVar7 = local_4;
		      if (DAT_ram_009d3e38 == 1) goto code_r0x81080688;
		      if (iVar2 == 0) goto code_r0x810806d9;
		      iVar2 = *local_4;
		      if (*(ushort *)(iVar2 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          piVar10 = (int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8);
		          if (System_Collections_IEnumerator_TypeInfo == *piVar10) {
		            puVar4 = (undefined4 *)(piVar10[1] * 8 + iVar2 + 200);
		            goto code_r0x81080524;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar4 = (undefined4 *)
		               import::env::invoke_iiii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                          System_Collections_IEnumerator_TypeInfo,1);
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x81080674:
		        DAT_ram_009d3e38 = 0;
		        uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x81080690;
		      }
		code_r0x81080524:
		      DAT_ram_009d3e38 = 0;
		      piVar7 = (int *)import::env::invoke_iii(*puVar4,piVar7,puVar4[1]);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x81080674;
		      if (piVar7 != (int *)0x0) {
		        if (((uint)*(byte *)(*piVar7 + 0xb8) <
		             (uint)*(byte *)(UnityEngine_Transform_TypeInfo + 0xb8)) ||
		           (*(int *)(*(int *)(*piVar7 + 100) +
		                     (uint)*(byte *)(UnityEngine_Transform_TypeInfo + 0xb8) * 4 + -4) !=
		            UnityEngine_Transform_TypeInfo)) {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vii
		                    (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x183,piVar7,
		                     UnityEngine_Transform_TypeInfo);
		          iVar2 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar2 != 1) {
		code_r0x81080d8d:
		            do {
		              halt_trap();
		            } while( true );
		          }
		          uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x81080690;
		        }
		      }
		      DAT_ram_009d3e38 = 0;
		      uVar5 = import::env::invoke_iii
		                        (s_struct_Uniforms___color__array<v_ram_00000aff + 0x25c,piVar7,0);
		      if (DAT_ram_009d3e38 == 1) break;
		      if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vi
		                  (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                   UnityEngine_Object_TypeInfo);
		        if (DAT_ram_009d3e38 == 1) break;
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vii(s_struct_Uniforms___color__array<v_ram_00000aff + 0x274,uVar5,0);
		    } while (DAT_ram_009d3e38 != 1);
		    DAT_ram_009d3e38 = 0;
		    uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x81080690:
		    iVar2 = global_1;
		    iVar6 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		    if (iVar2 == iVar6) {
		      piVar7 = (int *)import::env::__cxa_begin_catch(uVar5);
		      local_18 = *piVar7;
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_v(0x123);
		      iVar2 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar2 != 1) {
		code_r0x810806d9:
		        DAT_ram_009d3e38 = 0;
		        local_8 = func_ii_1082(local_4,System_IDisposable_TypeInfo);
		        piVar7 = (int *)*local_10;
		        if (piVar7 != (int *)0x0) {
		          iVar2 = *piVar7;
		          if (*(ushort *)(iVar2 + 0xb6) != 0) {
		            uVar1 = 0;
		            do {
		              if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		                puVar8 = (uint *)(iVar2 + *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 +
		                                 0xc0);
		                goto code_r0x81080769;
		              }
		              uVar1 = uVar1 + 1;
		            } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		          }
		          puVar8 = (uint *)func_ii_1080(piVar7,System_IDisposable_TypeInfo,0);
		code_r0x81080769:
		          (**(code **)((ulonglong)*puVar8 * 4))(piVar7,puVar8[1]);
		        }
		        if (local_18 != 0) {
		          System_Data_DataSet__ValidateLocaleConstraint(local_18);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        uVar1 = 0;
		        piVar7 = *(int **)(param1[2] + 0xc);
		        iVar2 = *piVar7;
		        if (*(ushort *)(iVar2 + 0xb6) != 0) {
		          do {
		            if (System_Collections_Generic_IEnumerable_OptionsMenuButton__TypeInfo ==
		                *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		              puVar8 = (uint *)(iVar2 + *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x810807f5;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		        }
		        puVar8 = (uint *)func_ii_1080(piVar7,
		                                      System_Collections_Generic_IEnumerable_OptionsMenuButton__TypeInfo
		                                      ,0);
		code_r0x810807f5:
		        local_c = (int *)(**(code **)((ulonglong)*puVar8 * 4))(piVar7,puVar8[1]);
		        local_18 = 0;
		        local_14 = &local_c;
		        do {
		          piVar7 = local_c;
		          iVar2 = *local_c;
		          if (*(ushort *)(iVar2 + 0xb6) != 0) {
		            uVar1 = 0;
		            do {
		              piVar10 = (int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8);
		              if (System_Collections_IEnumerator_TypeInfo == *piVar10) {
		                puVar4 = (undefined4 *)(iVar2 + piVar10[1] * 8 + 0xc0);
		                goto code_r0x81080904;
		              }
		              uVar1 = uVar1 + 1;
		            } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		          }
		          DAT_ram_009d3e38 = 0;
		          puVar4 = (undefined4 *)
		                   import::env::invoke_iiii
		                             (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_c,
		                              System_Collections_IEnumerator_TypeInfo,0);
		          if (DAT_ram_009d3e38 == 1) {
		code_r0x81080c4c:
		            DAT_ram_009d3e38 = 0;
		            uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x81080c54;
		          }
		code_r0x81080904:
		          DAT_ram_009d3e38 = 0;
		          iVar2 = import::env::invoke_iii(*puVar4,piVar7,puVar4[1]);
		          piVar7 = local_c;
		          if (DAT_ram_009d3e38 == 1) goto code_r0x81080c4c;
		          if (iVar2 == 0) goto code_r0x81080c9d;
		          iVar2 = *local_c;
		          if (*(ushort *)(iVar2 + 0xb6) != 0) {
		            uVar1 = 0;
		            do {
		              piVar10 = (int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8);
		              if (System_Collections_Generic_IEnumerator_OptionsMenuButton__TypeInfo == *piVar10) {
		                puVar4 = (undefined4 *)(iVar2 + piVar10[1] * 8 + 0xc0);
		                goto code_r0x810809e1;
		              }
		              uVar1 = uVar1 + 1;
		            } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		          }
		          DAT_ram_009d3e38 = 0;
		          puVar4 = (undefined4 *)
		                   import::env::invoke_iiii
		                             (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_c,
		                              System_Collections_Generic_IEnumerator_OptionsMenuButton__TypeInfo,0);
		          if (DAT_ram_009d3e38 == 1) {
		code_r0x81080c06:
		            DAT_ram_009d3e38 = 0;
		            uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x81080c54;
		          }
		code_r0x810809e1:
		          DAT_ram_009d3e38 = 0;
		          uVar5 = import::env::invoke_iii(*puVar4,piVar7,puVar4[1]);
		          if (DAT_ram_009d3e38 == 1) goto code_r0x81080c06;
		          DAT_ram_009d3e38 = 0;
		          iVar6 = import::env::invoke_iii
		                            (*(undefined4 *)(*param1 + 0x158),param1,
		                             *(undefined4 *)(*param1 + 0x15c));
		          iVar2 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar2 == 1) {
		            uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x81080c54;
		          }
		          uVar9 = *(undefined4 *)(iVar6 + 0x14);
		          DAT_ram_009d3e38 = 0;
		          iVar6 = import::env::invoke_iii
		                            (*(undefined4 *)(*param1 + 0x158),param1,
		                             *(undefined4 *)(*param1 + 0x15c));
		          iVar2 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar2 == 1) {
		            uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x81080c54;
		          }
		          param3_00 = *(undefined4 *)(iVar6 + 0x10);
		          if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_vi
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                       UnityEngine_Object_TypeInfo);
		            iVar2 = DAT_ram_009d3e38;
		            DAT_ram_009d3e38 = 0;
		            if (iVar2 == 1) {
		              uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		              goto code_r0x81080c54;
		            }
		          }
		          DAT_ram_009d3e38 = 0;
		          iVar6 = import::env::invoke_iiii
		                            (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x2ce,uVar9,param3_00
		                             ,Method_UnityEngine_Object_Instantiate_ExternalLinkButtonView___);
		          iVar2 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar2 == 1) {
		            uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x81080c54;
		          }
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_viii
		                    (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x1e,iVar6,uVar5,iVar6);
		          iVar2 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar2 == 1) {
		            uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x81080c54;
		          }
		          uVar9 = *(undefined4 *)(iVar6 + 0x20);
		          DAT_ram_009d3e38 = 0;
		          uVar5 = import::env::invoke_ii
		                            (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                             UnityEngine_Events_UnityAction_OptionsMenuButton__TypeInfo);
		          if (DAT_ram_009d3e38 == 1) break;
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_viiii
		                    (s_struct_Uniforms___color__array<v_ram_00001b87 + 8,uVar5,param1,
		                     Method_Gameplay_UserInterface_Menu_ExternalLinks_Control_ExternalLinksMediator_OnButtonClick__
		                     ,0);
		          if (DAT_ram_009d3e38 == 1) break;
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_viii
		                    (s_struct_Uniforms___color__array<v_ram_00001b87 + 0xd,uVar9,uVar5,
		                     Method_UnityEngine_Events_UnityEvent_OptionsMenuButton__AddListener__);
		        } while (DAT_ram_009d3e38 != 1);
		        DAT_ram_009d3e38 = 0;
		        uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x81080c54:
		        iVar2 = global_1;
		        iVar6 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		        if (iVar2 == iVar6) {
		          piVar7 = (int *)import::env::__cxa_begin_catch(uVar5);
		          local_18 = *piVar7;
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_v(0x123);
		          iVar2 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar2 != 1) {
		code_r0x81080c9d:
		            DAT_ram_009d3e38 = 0;
		            piVar7 = *local_14;
		            if (piVar7 != (int *)0x0) {
		              uVar1 = 0;
		              iVar2 = *piVar7;
		              if (*(ushort *)(iVar2 + 0xb6) != 0) {
		                do {
		                  if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		                    puVar8 = (uint *)(iVar2 + *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 +
		                                     0xc0);
		                    goto code_r0x81080d18;
		                  }
		                  uVar1 = uVar1 + 1;
		                } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		              }
		              puVar8 = (uint *)func_ii_1080(piVar7,System_IDisposable_TypeInfo,0);
		code_r0x81080d18:
		              (**(code **)((ulonglong)*puVar8 * 4))(piVar7,puVar8[1]);
		            }
		            if (local_18 == 0) {
		              return;
		            }
		            System_Data_DataSet__ValidateLocaleConstraint(local_18);
		            do {
		              halt_trap();
		            } while( true );
		          }
		          uVar5 = import::env::__cxa_find_matching_catch_2();
		        }
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001f04 + 0x1f,&local_18);
		        goto joined_r0x81080d6c;
		      }
		      uVar5 = import::env::__cxa_find_matching_catch_2();
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001f04 + 0x1d,&local_18);
		  }
		  else {
		    local_4 = (int *)UnityEngine_Transform__set_hasChanged(*(undefined4 *)(param1[5] + 0x10),0);
		    local_10 = &local_8;
		    local_18 = 0;
		    local_14 = &local_4;
		    do {
		      do {
		        piVar7 = local_4;
		        iVar2 = *local_4;
		        if (*(ushort *)(iVar2 + 0xb6) != 0) {
		          uVar1 = 0;
		          do {
		            piVar10 = (int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8);
		            if (System_Collections_IEnumerator_TypeInfo == *piVar10) {
		              puVar4 = (undefined4 *)(iVar2 + piVar10[1] * 8 + 0xc0);
		              goto code_r0x8107fef0;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar4 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                            System_Collections_IEnumerator_TypeInfo,0);
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x8107ff34:
		          DAT_ram_009d3e38 = 0;
		          uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x8108021d;
		        }
		code_r0x8107fef0:
		        DAT_ram_009d3e38 = 0;
		        iVar2 = import::env::invoke_iii(*puVar4,piVar7,puVar4[1]);
		        piVar7 = local_4;
		        if (DAT_ram_009d3e38 == 1) goto code_r0x8107ff34;
		        if (iVar2 == 0) goto code_r0x81080266;
		        iVar2 = *local_4;
		        if (*(ushort *)(iVar2 + 0xb6) != 0) {
		          uVar1 = 0;
		          do {
		            piVar10 = (int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8);
		            if (System_Collections_IEnumerator_TypeInfo == *piVar10) {
		              puVar4 = (undefined4 *)(piVar10[1] * 8 + iVar2 + 200);
		              goto code_r0x8107ffe3;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar4 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                            System_Collections_IEnumerator_TypeInfo,1);
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x81080137:
		          DAT_ram_009d3e38 = 0;
		          uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x8108021d;
		        }
		code_r0x8107ffe3:
		        DAT_ram_009d3e38 = 0;
		        piVar7 = (int *)import::env::invoke_iii(*puVar4,piVar7,puVar4[1]);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x81080137;
		        if (piVar7 != (int *)0x0) {
		          if (((uint)*(byte *)(*piVar7 + 0xb8) <
		               (uint)*(byte *)(UnityEngine_Transform_TypeInfo + 0xb8)) ||
		             (*(int *)(*(int *)(*piVar7 + 100) +
		                       (uint)*(byte *)(UnityEngine_Transform_TypeInfo + 0xb8) * 4 + -4) !=
		              UnityEngine_Transform_TypeInfo)) {
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_vii
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x183,piVar7,
		                       UnityEngine_Transform_TypeInfo);
		            iVar2 = DAT_ram_009d3e38;
		            DAT_ram_009d3e38 = 0;
		            if (iVar2 != 1) goto code_r0x81080d8d;
		            uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x8108021d;
		          }
		        }
		        DAT_ram_009d3e38 = 0;
		        iVar6 = import::env::invoke_iii
		                          (s_struct_Uniforms___color__array<v_ram_000013c7 + 0x267,piVar7,
		                           Method_UnityEngine_Component_GetComponent_ExternalLinkButtonView___);
		        iVar2 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar2 == 1) {
		          uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x8108021d;
		        }
		        if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vi
		                    (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                     UnityEngine_Object_TypeInfo);
		          iVar2 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar2 == 1) {
		            uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x8108021d;
		          }
		        }
		        DAT_ram_009d3e38 = 0;
		        iVar3 = import::env::invoke_iii
		                          (s_struct_Uniforms___color__array<v_ram_000013c7 + 0x268,iVar6,0);
		        iVar2 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar2 == 1) {
		          uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x8108021d;
		        }
		      } while (iVar3 == 0);
		      uVar9 = *(undefined4 *)(iVar6 + 0x20);
		      DAT_ram_009d3e38 = 0;
		      uVar5 = import::env::invoke_ii
		                        (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                         UnityEngine_Events_UnityAction_OptionsMenuButton__TypeInfo);
		      if (DAT_ram_009d3e38 == 1) break;
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_viiii
		                (s_struct_Uniforms___color__array<v_ram_00001b87 + 8,uVar5,param1,
		                 Method_Gameplay_UserInterface_Menu_ExternalLinks_Control_ExternalLinksMediator_OnButtonClick__
		                 ,0);
		      if (DAT_ram_009d3e38 == 1) break;
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_viii
		                (s_struct_Uniforms___color__array<v_ram_00001b87 + 9,uVar9,uVar5,
		                 Method_UnityEngine_Events_UnityEvent_OptionsMenuButton__RemoveListener__);
		    } while (DAT_ram_009d3e38 != 1);
		    DAT_ram_009d3e38 = 0;
		    uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x8108021d:
		    iVar2 = global_1;
		    iVar6 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		    if (iVar2 == iVar6) {
		      piVar7 = (int *)import::env::__cxa_begin_catch(uVar5);
		      local_18 = *piVar7;
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_v(0x123);
		      iVar2 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar2 != 1) {
		code_r0x81080266:
		        DAT_ram_009d3e38 = 0;
		        local_8 = func_ii_1082(local_4,System_IDisposable_TypeInfo);
		        piVar7 = (int *)*local_10;
		        if (piVar7 != (int *)0x0) {
		          iVar2 = *piVar7;
		          if (*(ushort *)(iVar2 + 0xb6) != 0) {
		            uVar1 = 0;
		            do {
		              if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		                puVar8 = (uint *)(iVar2 + *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 +
		                                 0xc0);
		                goto code_r0x810802f6;
		              }
		              uVar1 = uVar1 + 1;
		            } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		          }
		          puVar8 = (uint *)func_ii_1080(piVar7,System_IDisposable_TypeInfo,0);
		code_r0x810802f6:
		          (**(code **)((ulonglong)*puVar8 * 4))(piVar7,puVar8[1]);
		        }
		        if (local_18 != 0) {
		          System_Data_DataSet__ValidateLocaleConstraint(local_18);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        goto code_r0x8108035b;
		      }
		      uVar5 = import::env::__cxa_find_matching_catch_2();
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001f04 + 0x1c,&local_18);
		  }
		joined_r0x81080d6c:
		  if (DAT_ram_009d3e38 != 1) {
		    DAT_ram_009d3e38 = 0;
		    import::env::__resumeException(uVar5);
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


		/* --- GHIDRA: set_View ---
		void Gameplay_UserInterface_Menu_ExternalLinks_Control_ExternalLinksMediator__set_View
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  iVar1 = *(int *)(iVar1 + 0x14);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param2,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

}
