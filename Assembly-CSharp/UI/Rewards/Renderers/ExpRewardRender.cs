using System;
using Il2CppDummyDll;

namespace UI.Rewards.Renderers
{
	// Token: 0x020001AA RID: 426
	[Token(Token = "0x20001AA")]
	public class ExpRewardRender : AbstractRewardRender
	{
		// Token: 0x06000B93 RID: 2963 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B93")]
		[Address(RVA = "0x5EAC", Offset = "0x5EAC", VA = "0x5EAC", Slot = "8")]
		protected override void HandleRewardChanged()
		{
		}

		// Token: 0x06000B94 RID: 2964 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B94")]
		[Address(RVA = "0x5EAD", Offset = "0x5EAD", VA = "0x5EAD")]
		public ExpRewardRender()
		{
		/* --- GHIDRA: .ctor ---
		void UI_Rewards_Renderers_ExpRewardRender___ctor(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  undefined4 uVar3;
		  int *piVar4;
		  uint *puVar5;
		  undefined4 *puVar6;
		  undefined8 uVar7;
		  int iVar8;
		  int *piVar9;
		  int iVar10;
		  uint uVar11;
		  int local_10;
		  int **local_c;
		  int local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a59a2f == '\0') {
		    Mono_Security_ASN1__get_Item(&UI_Rewards_Renderers_ArtifactRewardRender_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_Select_ArtifactInfo__ArtifactData___);
		    Mono_Security_ASN1__get_Item(&System_Func_ArtifactInfo__ArtifactData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerable_long__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_long__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Data_Decorators_IRewardInfo_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ArtifactData__AddRange__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ArtifactData__ToArray__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ArtifactData___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_ArtifactData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Rewards_Renderers_MarketArtifactRewardRender___c__DisplayClass0_0__HandleRewardChanged_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&UI_Rewards_Renderers_MarketArtifactRewardRender___c__DisplayClass0_0_TypeInfo);
		    DAT_ram_00a59a2f = '\x01';
		  }
		  local_4 = (int *)0x0;
		  local_8 = 0;
		  iVar1 = unnamed_function_1417
		                    (UI_Rewards_Renderers_MarketArtifactRewardRender___c__DisplayClass0_0_TypeInfo);
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  uVar2 = func_ii_8038(uVar2,0);
		  uVar2 = Core_Data_RewardData___ctor(uVar2,0);
		  param1_00 = unnamed_function_1417(System_Collections_Generic_List_ArtifactData__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,Method_System_Collections_Generic_List_ArtifactData___ctor__);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar11 = 0;
		  *(undefined4 *)(iVar1 + 8) = **(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  piVar4 = (int *)func_ii_7225(uVar3,0);
		  iVar8 = *piVar4;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    do {
		      if (Core_Data_Decorators_IRewardInfo_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar11 * 8)
		         ) {
		        puVar5 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar11 * 8 + 4) * 8 + iVar8 + 0xd0);
		        goto code_r0x810aeb94;
		      }
		      uVar11 = uVar11 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar11);
		  }
		  puVar5 = (uint *)func_ii_1080(piVar4,Core_Data_Decorators_IRewardInfo_TypeInfo,2);
		code_r0x810aeb94:
		  piVar4 = (int *)(**(code **)((ulonglong)*puVar5 * 4))(piVar4,puVar5[1]);
		  uVar11 = 0;
		  iVar8 = *piVar4;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    do {
		      if (System_Collections_Generic_IEnumerable_long__TypeInfo ==
		          *(int *)(*(int *)(iVar8 + 0x58) + uVar11 * 8)) {
		        puVar5 = (uint *)(iVar8 + *(int *)(*(int *)(iVar8 + 0x58) + uVar11 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x810aec14;
		      }
		      uVar11 = uVar11 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar11);
		  }
		  puVar5 = (uint *)func_ii_1080(piVar4,System_Collections_Generic_IEnumerable_long__TypeInfo,0);
		code_r0x810aec14:
		  local_4 = (int *)(**(code **)((ulonglong)*puVar5 * 4))(piVar4,puVar5[1]);
		  local_10 = 0;
		  local_c = &local_4;
		  do {
		    do {
		      piVar4 = local_4;
		      iVar8 = *local_4;
		      if (*(ushort *)(iVar8 + 0xb6) != 0) {
		        uVar11 = 0;
		        do {
		          piVar9 = (int *)(*(int *)(iVar8 + 0x58) + uVar11 * 8);
		          if (System_Collections_IEnumerator_TypeInfo == *piVar9) {
		            puVar6 = (undefined4 *)(iVar8 + piVar9[1] * 8 + 0xc0);
		            goto code_r0x810aecec;
		          }
		          uVar11 = uVar11 + 1;
		        } while (*(ushort *)(iVar8 + 0xb6) != uVar11);
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar6 = (undefined4 *)
		               import::env::invoke_iiii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                          System_Collections_IEnumerator_TypeInfo,0);
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x810aed38:
		        DAT_ram_009d3e38 = 0;
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x810af08e;
		      }
		code_r0x810aecec:
		      DAT_ram_009d3e38 = 0;
		      iVar8 = import::env::invoke_iii(*puVar6,piVar4,puVar6[1]);
		      piVar4 = local_4;
		      if (DAT_ram_009d3e38 == 1) goto code_r0x810aed38;
		      if (iVar8 == 0) {
		        iVar8 = 5;
		        iVar1 = 0;
		        goto code_r0x810af0db;
		      }
		      iVar8 = *local_4;
		      if (*(ushort *)(iVar8 + 0xb6) != 0) {
		        uVar11 = 0;
		        do {
		          piVar9 = (int *)(*(int *)(iVar8 + 0x58) + uVar11 * 8);
		          if (System_Collections_Generic_IEnumerator_long__TypeInfo == *piVar9) {
		            puVar6 = (undefined4 *)(iVar8 + piVar9[1] * 8 + 0xc0);
		            goto code_r0x810aeddb;
		          }
		          uVar11 = uVar11 + 1;
		        } while (*(ushort *)(iVar8 + 0xb6) != uVar11);
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar6 = (undefined4 *)
		               import::env::invoke_iiii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                          System_Collections_Generic_IEnumerator_long__TypeInfo,0);
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x810af05e:
		        DAT_ram_009d3e38 = 0;
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x810af08e;
		      }
		code_r0x810aeddb:
		      DAT_ram_009d3e38 = 0;
		      uVar7 = unnamed_function_184054(*puVar6,piVar4,puVar6[1]);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x810af05e;
		      piVar4 = *(int **)(iVar1 + 8);
		      iVar8 = *piVar4;
		      if (*(ushort *)(iVar8 + 0xb6) != 0) {
		        uVar11 = 0;
		        do {
		          piVar9 = (int *)(*(int *)(iVar8 + 0x58) + uVar11 * 8);
		          if (Core_Gameplay_IGame_TypeInfo == *piVar9) {
		            puVar6 = (undefined4 *)(piVar9[1] * 8 + iVar8 + 0x178);
		            goto code_r0x810aeeb3;
		          }
		          uVar11 = uVar11 + 1;
		        } while (*(ushort *)(iVar8 + 0xb6) != uVar11);
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar6 = (undefined4 *)
		               import::env::invoke_iiii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar4,
		                          Core_Gameplay_IGame_TypeInfo,0x17);
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x810af068:
		        DAT_ram_009d3e38 = 0;
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x810af08e;
		      }
		code_r0x810aeeb3:
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::invoke_iii(*puVar6,piVar4,puVar6[1]);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x810af068;
		      DAT_ram_009d3e38 = 0;
		      uVar3 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar3,0);
		      iVar8 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar8 == 1) {
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x810af08e;
		      }
		      DAT_ram_009d3e38 = 0;
		      iVar10 = import::env::invoke_iiiii
		                         (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x73,uVar3,(int)uVar7,
		                          &local_8,0);
		      iVar8 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar8 == 1) {
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x810af08e;
		      }
		    } while (iVar10 == 0);
		    uVar3 = *(undefined4 *)(local_8 + 0x10);
		    iVar8 = *(int *)(iVar1 + 0xc);
		    if (iVar8 == 0) {
		      DAT_ram_009d3e38 = 0;
		      iVar8 = import::env::invoke_ii
		                        (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                         System_Func_ArtifactInfo__ArtifactData__TypeInfo);
		      if (DAT_ram_009d3e38 != 1) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viiii
		                  (s_struct_Uniforms___color__array<v_ram_00000aff + 0x227,iVar8,iVar1,
		                   Method_UI_Rewards_Renderers_MarketArtifactRewardRender___c__DisplayClass0_0__HandleRewardChanged_b__0__
		                   ,0);
		        if (DAT_ram_009d3e38 != 1) {
		          *(int *)(iVar1 + 0xc) = iVar8;
		          goto code_r0x810aefe4;
		        }
		      }
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x810af08e;
		    }
		code_r0x810aefe4:
		    DAT_ram_009d3e38 = 0;
		    uVar3 = import::env::invoke_iiii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x228,uVar3,iVar8,
		                       Method_System_Linq_Enumerable_Select_ArtifactInfo__ArtifactData___);
		    if (DAT_ram_009d3e38 == 1) break;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_000017c8 + 0xf8,param1_00,uVar3,
		               Method_System_Collections_Generic_List_ArtifactData__AddRange__);
		  } while (DAT_ram_009d3e38 != 1);
		  DAT_ram_009d3e38 = 0;
		  uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x810af08e:
		  iVar1 = global_1;
		  iVar8 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar1 == iVar8) {
		    piVar4 = (int *)import::env::__cxa_begin_catch(uVar3);
		    iVar1 = *piVar4;
		    iVar8 = 0;
		    DAT_ram_009d3e38 = 0;
		    local_10 = iVar1;
		    import::env::invoke_v(0x123);
		    iVar10 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar10 != 1) {
		code_r0x810af0db:
		      piVar4 = local_4;
		      DAT_ram_009d3e38 = 0;
		      if (local_4 != (int *)0x0) {
		        uVar11 = 0;
		        iVar10 = *local_4;
		        if (*(ushort *)(iVar10 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar10 + 0x58) + uVar11 * 8)) {
		              puVar5 = (uint *)(iVar10 + *(int *)(*(int *)(iVar10 + 0x58) + uVar11 * 8 + 4) * 8 +
		                               0xc0);
		              goto code_r0x810af153;
		            }
		            uVar11 = uVar11 + 1;
		          } while (*(ushort *)(iVar10 + 0xb6) != uVar11);
		        }
		        puVar5 = (uint *)func_ii_1080(local_4,System_IDisposable_TypeInfo,0);
		code_r0x810af153:
		        (**(code **)((ulonglong)*puVar5 * 4))(piVar4,puVar5[1]);
		      }
		      if (iVar1 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar1);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      if ((iVar8 == 0) ||
		         ((((iVar8 != 1 && (iVar8 != 2)) && (iVar8 != 3)) && ((iVar8 != 4 && (iVar8 == 5)))))) {
		        iVar1 = *(int *)param1[5];
		        (**(code **)((ulonglong)*(uint *)(iVar1 + 0xe8) * 4))
		                  ((int *)param1[5],param1[4],uVar2,*(undefined4 *)(iVar1 + 0xec));
		        piVar4 = (int *)param1[5];
		        uVar2 = UnityEngine_TextCore_Text_FontAsset__UpdateFontFeaturesForNewlyAddedGlyphs
		                          (param1_00,Method_System_Collections_Generic_List_ArtifactData__ToArray__)
		        ;
		        if (piVar4 != (int *)0x0) {
		          if (((uint)*(byte *)(*piVar4 + 0xb8) <
		               (uint)*(byte *)(UI_Rewards_Renderers_ArtifactRewardRender_TypeInfo + 0xb8)) ||
		             (*(int *)(*(int *)(*piVar4 + 100) +
		                       (uint)*(byte *)(UI_Rewards_Renderers_ArtifactRewardRender_TypeInfo + 0xb8) *
		                       4 + -4) != UI_Rewards_Renderers_ArtifactRewardRender_TypeInfo)) {
		            System_Activator__CreateInstance
		                      (piVar4,UI_Rewards_Renderers_ArtifactRewardRender_TypeInfo);
		            do {
		              halt_trap();
		            } while( true );
		          }
		        }
		        UI_Rewards_Renderers_ArtifactRewardRender__HandleOnDestroyEvent(piVar4,uVar2,piVar4);
		      }
		      return;
		    }
		    uVar3 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001f04 + 0x74,&local_10);
		  iVar1 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar1 == 1) {
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__resumeException(uVar3);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}
	}
}
