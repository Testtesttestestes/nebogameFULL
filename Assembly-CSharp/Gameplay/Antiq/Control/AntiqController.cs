using System;
using Gameplay.Antiq.Model;
using Google.Protobuf;
using Il2CppDummyDll;
using MVC;
using Protocol.Main;
using ServicesNamespace;
using Utils;

namespace Gameplay.Antiq.Control
{
	// Token: 0x02000D95 RID: 3477
	[Token(Token = "0x2000D95")]
	internal class AntiqController : AbstractController<AntiqModel, AntiqEvents>
	{
		// Token: 0x0600550D RID: 21773 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600550D")]
		[Address(RVA = "0xA2B1", Offset = "0xA2B1", VA = "0xA2B1")]
		public AntiqController(AntiqModel model, AntiqEvents events, MainService mainService)
		{
		}

		// Token: 0x0600550E RID: 21774 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600550E")]
		[Address(RVA = "0xA2B2", Offset = "0xA2B2", VA = "0xA2B2")]
		private void ValidateInit()
		{
		/* --- GHIDRA: ValidateInit ---
		void Gameplay_Antiq_Control_AntiqController__ValidateInit(undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_Antiq_Control_AntiqController__HandleRun(param1,param1);
		  Gameplay_Antiq_Control_AntiqController__SetUserArtifacts(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x0600550F RID: 21775 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600550F")]
		[Address(RVA = "0xA2B3", Offset = "0xA2B3", VA = "0xA2B3", Slot = "7")]
		protected override void HandleRun()
		{
		/* --- GHIDRA: HandleRun ---
		/* WARNING: Removing unreachable block (ram,0x80f2d3bd) */
		/* WARNING: Removing unreachable block (ram,0x80f2cfdd) */
		/* WARNING: Removing unreachable block (ram,0x80f2dbac) */
		
		void Gameplay_Antiq_Control_AntiqController__HandleRun(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  undefined4 uVar2;
		  int iVar3;
		  uint *puVar4;
		  undefined4 *puVar5;
		  int param2_00;
		  int iVar6;
		  undefined4 uVar7;
		  undefined4 uVar8;
		  int iVar9;
		  undefined8 param3;
		  int *piVar10;
		  undefined4 uVar11;
		  undefined4 uVar12;
		  int *piVar13;
		  uint uVar14;
		  int local_1c;
		  int **local_18;
		  int local_14;
		  int **local_10;
		  undefined4 local_c;
		  int *local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a587ff == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Antiq_Model_ArtifactData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Select_RewardInfo__EffectData___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Single_CategoryData___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Where_EffectData___);
		    Mono_Security_ASN1__get_Item(&System_Func_EffectData__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_CategoryData__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_RewardInfo__EffectData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Antiq_Model_GroupData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_ICollection_GroupData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_IEnumerator_Antiq_Types_ArtifactGroupsDic__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_ulong__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Sirenix_Utilities_LinqExtensions_AddRange_GroupData___);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ArtifactData__AddRange__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ArtifactData__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_GroupData__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ArtifactData___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_GroupData___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ArtifactData__get_Count__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_GroupData__get_Count__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_GroupData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_ArtifactData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_ObjectModel_ReadOnlyCollection_ArtifactData___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_ObjectModel_ReadOnlyCollection_ArtifactData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Google_Protobuf_Collections_RepeatedField_Antiq_Types_ArtifactGroupsDic__GetEnumerator__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ulong__GetEnumerator__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Antiq_Control_AntiqController___c__CreateEntities_b__4_2__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Antiq_Control_AntiqController___c__DisplayClass4_0__CreateEntities_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Antiq_Control_AntiqController___c__DisplayClass4_0_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Antiq_Control_AntiqController___c__DisplayClass4_1__CreateEntities_b__1__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Antiq_Control_AntiqController___c__DisplayClass4_1_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Antiq_Control_AntiqController___c_TypeInfo);
		    DAT_ram_00a587ff = '\x01';
		  }
		  local_4 = (int *)0x0;
		  local_8 = (int *)0x0;
		  local_c = 0;
		  iVar1 = unnamed_function_1417(System_Collections_Generic_List_GroupData__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (iVar1,Method_System_Collections_Generic_List_GroupData___ctor__);
		  param1_00 = unnamed_function_1417(System_Collections_Generic_List_ArtifactData__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,Method_System_Collections_Generic_List_ArtifactData___ctor__);
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar2 = Gameplay_Antiq_Model_AntiqModel__GetIsArtifactsScrollEnabled(uVar2,0);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  piVar10 = *(int **)(iVar3 + 0x14);
		  iVar3 = *piVar10;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar14 = 0;
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar14 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar14 * 8 + 4) * 8 + iVar3 + 0xd0);
		        goto code_r0x80f2ce48;
		      }
		      uVar14 = uVar14 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar14);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar10,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x80f2ce48:
		  iVar3 = (**(code **)((ulonglong)*puVar4 * 4))(piVar10,puVar4[1]);
		  local_4 = (int *)Google_Protobuf_Collections_RepeatedField_float___Equals
		                             (*(undefined4 *)(iVar3 + 800),
		                              Method_Google_Protobuf_Collections_RepeatedField_Antiq_Types_ArtifactGroupsDic__GetEnumerator__
		                             );
		  local_14 = 0;
		  local_10 = &local_4;
		code_r0x80f2cea7:
		  do {
		    piVar10 = local_4;
		    iVar3 = *local_4;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      uVar14 = 0;
		      do {
		        piVar13 = (int *)(*(int *)(iVar3 + 0x58) + uVar14 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar13) {
		          puVar5 = (undefined4 *)(iVar3 + piVar13[1] * 8 + 0xc0);
		          goto code_r0x80f2cf3b;
		        }
		        uVar14 = uVar14 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar14);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar5 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80f2dcf2:
		      DAT_ram_009d3e38 = 0;
		      uVar8 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      iVar3 = global_1;
		      goto code_r0x80f2dd01;
		    }
		code_r0x80f2cf3b:
		    DAT_ram_009d3e38 = 0;
		    iVar3 = import::env::invoke_iii(*puVar5,piVar10,puVar5[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80f2dcf2;
		    if (iVar3 == 0) {
		      iVar3 = 8;
		      goto code_r0x80f2dd4c;
		    }
		    DAT_ram_009d3e38 = 0;
		    iVar9 = import::env::invoke_ii
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                       Gameplay_Antiq_Control_AntiqController___c__DisplayClass4_0_TypeInfo);
		    piVar10 = local_4;
		    if (DAT_ram_009d3e38 == 1) {
		      DAT_ram_009d3e38 = 0;
		      uVar8 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      iVar3 = global_1;
		      goto code_r0x80f2dd01;
		    }
		    *(int **)(iVar9 + 0xc) = param1;
		    iVar3 = *local_4;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      uVar14 = 0;
		      do {
		        piVar13 = (int *)(*(int *)(iVar3 + 0x58) + uVar14 * 8);
		        if (System_Collections_Generic_IEnumerator_Antiq_Types_ArtifactGroupsDic__TypeInfo ==
		            *piVar13) {
		          puVar5 = (undefined4 *)(iVar3 + piVar13[1] * 8 + 0xc0);
		          goto code_r0x80f2d07f;
		        }
		        uVar14 = uVar14 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar14);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar5 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_Generic_IEnumerator_Antiq_Types_ArtifactGroupsDic__TypeInfo
		                        ,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80f2d190:
		      DAT_ram_009d3e38 = 0;
		      uVar8 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      iVar3 = global_1;
		      goto code_r0x80f2dd01;
		    }
		code_r0x80f2d07f:
		    DAT_ram_009d3e38 = 0;
		    uVar8 = import::env::invoke_iii(*puVar5,piVar10,puVar5[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80f2d190;
		    *(undefined4 *)(iVar9 + 8) = uVar8;
		    DAT_ram_009d3e38 = 0;
		    param2_00 = import::env::invoke_ii
		                          (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                           System_Collections_Generic_List_ArtifactData__TypeInfo);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80f2d19a:
		      DAT_ram_009d3e38 = 0;
		      uVar8 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      iVar3 = global_1;
		      goto code_r0x80f2dd01;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_vii
		              (s_struct_Uniforms___color__array<v_ram_00000aff + 0x252,param2_00,
		               Method_System_Collections_Generic_List_ArtifactData___ctor__);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80f2d19a;
		    DAT_ram_009d3e38 = 0;
		    piVar10 = (int *)import::env::invoke_iii
		                               (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x2e7,
		                                *(undefined4 *)(*(int *)(iVar9 + 8) + 0x28),
		                                Method_Google_Protobuf_Collections_RepeatedField_ulong__GetEnumerator__
		                               );
		    iVar3 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar3 == 1) {
		      uVar8 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      iVar3 = global_1;
		      goto code_r0x80f2dd01;
		    }
		    local_1c = 0;
		    local_18 = &local_8;
		    local_8 = piVar10;
		code_r0x80f2d1b4:
		    do {
		      do {
		        piVar10 = local_8;
		        iVar3 = *local_8;
		        if (*(ushort *)(iVar3 + 0xb6) != 0) {
		          uVar14 = 0;
		          do {
		            piVar13 = (int *)(*(int *)(iVar3 + 0x58) + uVar14 * 8);
		            if (System_Collections_IEnumerator_TypeInfo == *piVar13) {
		              puVar5 = (undefined4 *)(iVar3 + piVar13[1] * 8 + 0xc0);
		              goto code_r0x80f2d24d;
		            }
		            uVar14 = uVar14 + 1;
		          } while (*(ushort *)(iVar3 + 0xb6) != uVar14);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar5 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_8,
		                            System_Collections_IEnumerator_TypeInfo,0);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80f2d88a;
		code_r0x80f2d24d:
		        DAT_ram_009d3e38 = 0;
		        iVar3 = import::env::invoke_iii(*puVar5,piVar10,puVar5[1]);
		        piVar10 = local_8;
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80f2d88a;
		        if (iVar3 == 0) {
		          iVar3 = 7;
		          goto code_r0x80f2d8e0;
		        }
		        iVar3 = *local_8;
		        if (*(ushort *)(iVar3 + 0xb6) != 0) {
		          uVar14 = 0;
		          do {
		            piVar13 = (int *)(*(int *)(iVar3 + 0x58) + uVar14 * 8);
		            if (System_Collections_Generic_IEnumerator_ulong__TypeInfo == *piVar13) {
		              puVar5 = (undefined4 *)(iVar3 + piVar13[1] * 8 + 0xc0);
		              goto code_r0x80f2d327;
		            }
		            uVar14 = uVar14 + 1;
		          } while (*(ushort *)(iVar3 + 0xb6) != uVar14);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar5 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_8,
		                            System_Collections_Generic_IEnumerator_ulong__TypeInfo,0);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80f2d88a;
		code_r0x80f2d327:
		        DAT_ram_009d3e38 = 0;
		        param3 = unnamed_function_184054(*puVar5,piVar10,puVar5[1]);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80f2d88a;
		        DAT_ram_009d3e38 = 0;
		        iVar3 = import::env::invoke_ii
		                          (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                           Gameplay_Antiq_Control_AntiqController___c__DisplayClass4_1_TypeInfo);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80f2d88a;
		        *(int *)(iVar3 + 0xc) = iVar9;
		        DAT_ram_009d3e38 = 0;
		        iVar6 = import::env::invoke_iii
		                          (*(undefined4 *)(*param1 + 0x100),param1,*(undefined4 *)(*param1 + 0x104))
		        ;
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80f2d88a;
		        piVar10 = *(int **)(iVar6 + 0x14);
		        iVar6 = *piVar10;
		        if (*(ushort *)(iVar6 + 0xb6) != 0) {
		          uVar14 = 0;
		          do {
		            piVar13 = (int *)(*(int *)(iVar6 + 0x58) + uVar14 * 8);
		            if (Core_Dict_IDictProvider_TypeInfo == *piVar13) {
		              puVar5 = (undefined4 *)(piVar13[1] * 8 + iVar6 + 0xd0);
		              goto code_r0x80f2d4a3;
		            }
		            uVar14 = uVar14 + 1;
		          } while (*(ushort *)(iVar6 + 0xb6) != uVar14);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar5 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar10,
		                            Core_Dict_IDictProvider_TypeInfo,2);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80f2d88a;
		code_r0x80f2d4a3:
		        DAT_ram_009d3e38 = 0;
		        uVar8 = import::env::invoke_iii(*puVar5,piVar10,puVar5[1]);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80f2d88a;
		        DAT_ram_009d3e38 = 0;
		        iVar6 = unnamed_function_184060
		                          (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x191,uVar8,param3,
		                           &local_c,0);
		        uVar8 = local_c;
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80f2d88a;
		      } while (iVar6 == 0);
		      uVar11 = *(undefined4 *)(param2_00 + 0xc);
		      DAT_ram_009d3e38 = 0;
		      uVar7 = import::env::invoke_ii
		                        (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                         Gameplay_Antiq_Model_ArtifactData_TypeInfo);
		      if (DAT_ram_009d3e38 == 1) break;
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_viiii
		                (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x192,uVar7,uVar11,uVar8,0);
		      if (DAT_ram_009d3e38 == 1) break;
		      *(undefined4 *)(iVar3 + 8) = uVar7;
		      DAT_ram_009d3e38 = 0;
		      uVar8 = import::env::invoke_iii
		                        (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x193,uVar7,0);
		      if (DAT_ram_009d3e38 == 1) break;
		      DAT_ram_009d3e38 = 0;
		      uVar7 = import::env::invoke_ii
		                        (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                         System_Func_RewardInfo__EffectData__TypeInfo);
		      if (DAT_ram_009d3e38 == 1) break;
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_viiii
		                (s_struct_Uniforms___color__array<v_ram_00000aff + 0x227,uVar7,iVar3,
		                 Method_Gameplay_Antiq_Control_AntiqController___c__DisplayClass4_1__CreateEntities_b__1__
		                 ,0);
		      if (DAT_ram_009d3e38 == 1) break;
		      DAT_ram_009d3e38 = 0;
		      uVar8 = import::env::invoke_iiii
		                        (s_struct_Uniforms___color__array<v_ram_00000aff + 0x228,uVar8,uVar7,
		                         Method_System_Linq_Enumerable_Select_RewardInfo__EffectData___);
		      if (DAT_ram_009d3e38 == 1) break;
		      if (*(int *)(Gameplay_Antiq_Control_AntiqController___c_TypeInfo + 0x74) == 0) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vi
		                  (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                   Gameplay_Antiq_Control_AntiqController___c_TypeInfo);
		        if (DAT_ram_009d3e38 == 1) break;
		      }
		      puVar5 = *(undefined4 **)(Gameplay_Antiq_Control_AntiqController___c_TypeInfo + 0x5c);
		      iVar6 = puVar5[1];
		      if (iVar6 == 0) {
		        if (*(int *)(Gameplay_Antiq_Control_AntiqController___c_TypeInfo + 0x74) == 0) {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vi
		                    (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                     Gameplay_Antiq_Control_AntiqController___c_TypeInfo);
		          if (DAT_ram_009d3e38 == 1) break;
		          puVar5 = *(undefined4 **)(Gameplay_Antiq_Control_AntiqController___c_TypeInfo + 0x5c);
		        }
		        uVar7 = *puVar5;
		        DAT_ram_009d3e38 = 0;
		        iVar6 = import::env::invoke_ii
		                          (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                           System_Func_EffectData__bool__TypeInfo);
		        if (DAT_ram_009d3e38 == 1) break;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viiii
		                  (s_struct_Uniforms___color__array<v_ram_00000aff + 0x21b,iVar6,uVar7,
		                   Method_Gameplay_Antiq_Control_AntiqController___c__CreateEntities_b__4_2__,0);
		        if (DAT_ram_009d3e38 == 1) break;
		        *(int *)(*(int *)(Gameplay_Antiq_Control_AntiqController___c_TypeInfo + 0x5c) + 4) = iVar6;
		      }
		      DAT_ram_009d3e38 = 0;
		      uVar8 = import::env::invoke_iiii
		                        (s_struct_Uniforms___color__array<v_ram_00000aff + 0x226,uVar8,iVar6,
		                         Method_System_Linq_Enumerable_Where_EffectData___);
		      if (DAT_ram_009d3e38 == 1) break;
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_viii
		                (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x194,*(undefined4 *)(iVar3 + 8),
		                 uVar8,0);
		      iVar6 = Method_System_Collections_Generic_List_ArtifactData__Add__;
		      if (DAT_ram_009d3e38 == 1) break;
		      uVar8 = *(undefined4 *)(iVar3 + 8);
		      *(int *)(param2_00 + 0x10) = *(int *)(param2_00 + 0x10) + 1;
		      uVar14 = *(uint *)(param2_00 + 0xc);
		      if (uVar14 < *(uint *)(*(int *)(param2_00 + 8) + 0xc)) {
		        *(uint *)(param2_00 + 0xc) = uVar14 + 1;
		        *(undefined4 *)(*(int *)(param2_00 + 8) + uVar14 * 4 + 0x10) = uVar8;
		        goto code_r0x80f2d1b4;
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_viii
		                (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,param2_00,uVar8,
		                 *(undefined4 *)(*(int *)(*(int *)(iVar6 + 0x10) + 0x60) + 0x38));
		    } while (DAT_ram_009d3e38 != 1);
		code_r0x80f2d88a:
		    DAT_ram_009d3e38 = 0;
		    uVar8 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    iVar3 = global_1;
		    iVar6 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		    if (iVar3 != iVar6) {
		code_r0x80f2dc83:
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x196,&local_1c);
		      iVar9 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar9 == 1) goto code_r0x80f2df55;
		      goto code_r0x80f2dd01;
		    }
		    piVar10 = (int *)import::env::__cxa_begin_catch(uVar8);
		    local_1c = *piVar10;
		    iVar3 = 0;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 == 1) {
		      uVar8 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      iVar3 = global_1;
		      goto code_r0x80f2dc83;
		    }
		code_r0x80f2d8e0:
		    piVar10 = *local_18;
		    if (piVar10 != (int *)0x0) {
		      iVar6 = *piVar10;
		      if (*(ushort *)(iVar6 + 0xb6) != 0) {
		        uVar14 = 0;
		        do {
		          piVar13 = (int *)(*(int *)(iVar6 + 0x58) + uVar14 * 8);
		          if (System_IDisposable_TypeInfo == *piVar13) {
		            puVar5 = (undefined4 *)(iVar6 + piVar13[1] * 8 + 0xc0);
		            goto code_r0x80f2d980;
		          }
		          uVar14 = uVar14 + 1;
		        } while (*(ushort *)(iVar6 + 0xb6) != uVar14);
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar5 = (undefined4 *)
		               import::env::invoke_iiii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar10,
		                          System_IDisposable_TypeInfo,0);
		      if (DAT_ram_009d3e38 != 1) {
		code_r0x80f2d980:
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vii(*puVar5,piVar10,puVar5[1]);
		        if (DAT_ram_009d3e38 != 1) goto code_r0x80f2d9bc;
		      }
		      DAT_ram_009d3e38 = 0;
		      uVar8 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      iVar3 = global_1;
		      goto code_r0x80f2dd01;
		    }
		code_r0x80f2d9bc:
		    if (local_1c != 0) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi(s_var<private>_posTex__array<vec4<_ram_00000655 + 0x1d3,local_1c);
		      iVar3 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar3 != 1) {
		        do {
		          halt_trap();
		        } while( true );
		      }
		      uVar8 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      iVar3 = global_1;
		      goto code_r0x80f2dd01;
		    }
		    if ((iVar3 != 0) &&
		       ((((iVar3 == 1 || (iVar3 == 2)) || (iVar3 == 3)) ||
		        (((iVar3 == 4 || (iVar3 == 5)) || ((iVar3 == 6 || (iVar3 != 7)))))))) goto code_r0x80f2dd4c;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_000017c8 + 0xf8,param1_00,param2_00,
		               Method_System_Collections_Generic_List_ArtifactData__AddRange__);
		    iVar3 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar3 == 1) {
		      uVar8 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      iVar3 = global_1;
		      goto code_r0x80f2dd01;
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar8 = import::env::invoke_ii
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                       System_Func_CategoryData__bool__TypeInfo);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80f2dcc0:
		      DAT_ram_009d3e38 = 0;
		      uVar8 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      iVar3 = global_1;
		      goto code_r0x80f2dd01;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viiii
		              (s_struct_Uniforms___color__array<v_ram_00000aff + 0x21b,uVar8,iVar9,
		               Method_Gameplay_Antiq_Control_AntiqController___c__DisplayClass4_0__CreateEntities_b__0__
		               ,0);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80f2dcc0;
		    DAT_ram_009d3e38 = 0;
		    uVar8 = import::env::invoke_iiii
		                      (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x33e,uVar2,uVar8,
		                       Method_System_Linq_Enumerable_Single_CategoryData___);
		    iVar3 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar3 == 1) {
		      uVar8 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      iVar3 = global_1;
		      goto code_r0x80f2dd01;
		    }
		    uVar11 = *(undefined4 *)(iVar9 + 8);
		    uVar12 = *(undefined4 *)(iVar1 + 0xc);
		    DAT_ram_009d3e38 = 0;
		    uVar7 = import::env::invoke_ii
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                       System_Collections_ObjectModel_ReadOnlyCollection_ArtifactData__TypeInfo);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80f2dcd4:
		      DAT_ram_009d3e38 = 0;
		      uVar8 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      iVar3 = global_1;
		      goto code_r0x80f2dd01;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x195,uVar7,param2_00,
		               Method_System_Collections_ObjectModel_ReadOnlyCollection_ArtifactData___ctor__);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80f2dcd4;
		    DAT_ram_009d3e38 = 0;
		    iVar3 = import::env::invoke_ii
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                       Gameplay_Antiq_Model_GroupData_TypeInfo);
		    if (DAT_ram_009d3e38 == 1) {
		      DAT_ram_009d3e38 = 0;
		      uVar8 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      iVar3 = global_1;
		      goto code_r0x80f2dd01;
		    }
		    *(undefined4 *)(iVar3 + 0xc) = uVar11;
		    *(undefined4 *)(iVar3 + 0x14) = uVar12;
		    *(undefined4 *)(iVar3 + 0x10) = uVar8;
		    *(undefined4 *)(iVar3 + 8) = uVar7;
		    iVar9 = Method_System_Collections_Generic_List_GroupData__Add__;
		    *(int *)(iVar1 + 0x10) = *(int *)(iVar1 + 0x10) + 1;
		    uVar14 = *(uint *)(iVar1 + 0xc);
		    if (uVar14 < *(uint *)(*(int *)(iVar1 + 8) + 0xc)) {
		      *(uint *)(iVar1 + 0xc) = uVar14 + 1;
		      *(int *)(*(int *)(iVar1 + 8) + uVar14 * 4 + 0x10) = iVar3;
		      goto code_r0x80f2cea7;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar1,iVar3,
		               *(undefined4 *)(*(int *)(*(int *)(iVar9 + 0x10) + 0x60) + 0x38));
		    iVar3 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar3 != 1);
		  uVar8 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  iVar3 = global_1;
		code_r0x80f2dd01:
		  iVar9 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar9 == iVar3) {
		    piVar10 = (int *)import::env::__cxa_begin_catch(uVar8);
		    local_14 = *piVar10;
		    iVar3 = 0;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar9 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar9 != 1) {
		code_r0x80f2dd4c:
		      DAT_ram_009d3e38 = 0;
		      piVar10 = *local_10;
		      if (piVar10 != (int *)0x0) {
		        uVar14 = 0;
		        iVar9 = *piVar10;
		        if (*(ushort *)(iVar9 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar9 + 0x58) + uVar14 * 8)) {
		              puVar4 = (uint *)(iVar9 + *(int *)(*(int *)(iVar9 + 0x58) + uVar14 * 8 + 4) * 8 + 0xc0
		                               );
		              goto code_r0x80f2ddc7;
		            }
		            uVar14 = uVar14 + 1;
		          } while (*(ushort *)(iVar9 + 0xb6) != uVar14);
		        }
		        puVar4 = (uint *)func_ii_1080(piVar10,System_IDisposable_TypeInfo,0);
		code_r0x80f2ddc7:
		        (**(code **)((ulonglong)*puVar4 * 4))(piVar10,puVar4[1]);
		      }
		      if (local_14 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(local_14);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      if ((iVar3 == 0) ||
		         (((iVar3 != 1 && (iVar3 != 2)) &&
		          ((iVar3 != 3 &&
		           ((((iVar3 != 4 && (iVar3 != 5)) && (iVar3 != 6)) && ((iVar3 != 7 && (iVar3 == 8))))))))))
		      {
		        uVar14 = 0;
		        uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0x104));
		        Gameplay_Antiq_Model_AntiqModel__GetCategories(uVar2,param1_00,0);
		        iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0x104));
		        piVar10 = *(int **)(iVar3 + 0x24);
		        iVar3 = *piVar10;
		        if (*(ushort *)(iVar3 + 0xb6) != 0) {
		          do {
		            if (System_Collections_Generic_ICollection_GroupData__TypeInfo ==
		                *(int *)(*(int *)(iVar3 + 0x58) + uVar14 * 8)) {
		              puVar4 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar14 * 8 + 4) * 8 + iVar3 + 0xd8
		                               );
		              goto code_r0x80f2de99;
		            }
		            uVar14 = uVar14 + 1;
		          } while (*(ushort *)(iVar3 + 0xb6) != uVar14);
		        }
		        puVar4 = (uint *)func_ii_1080(piVar10,
		                                      System_Collections_Generic_ICollection_GroupData__TypeInfo,3);
		code_r0x80f2de99:
		        (**(code **)((ulonglong)*puVar4 * 4))(piVar10,puVar4[1]);
		        iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0x104));
		        Core_Extensions_Dict_ArtikulTypeFilterDicExt__GetTitle
		                  (*(undefined4 *)(iVar3 + 0x24),iVar1,
		                   Method_Sirenix_Utilities_LinqExtensions_AddRange_GroupData___);
		        if (*(char *)((int)param1 + 9) != '\0') {
		          iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                            (param1,*(undefined4 *)(*param1 + 0x114));
		          iVar1 = *(int *)(iVar1 + 0x14);
		          if (iVar1 != 0) {
		            (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                      (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		          }
		        }
		      }
		      return;
		    }
		    uVar8 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x197,&local_14);
		  iVar1 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar1 != 1) {
		    import::env::__resumeException(uVar8);
		    do {
		      halt_trap();
		    } while( true );
		  }
		code_r0x80f2df55:
		  DAT_ram_009d3e38 = 0;
		  import::env::__cxa_find_matching_catch_3(0);
		  unnamed_function_937();
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06005510 RID: 21776 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005510")]
		[Address(RVA = "0xA2B4", Offset = "0xA2B4", VA = "0xA2B4")]
		private void CreateEntities()
		{
		/* --- GHIDRA: CreateEntities ---
		/* WARNING: Removing unreachable block (ram,0x80f2e1fe) */
		
		void Gameplay_Antiq_Control_AntiqController__CreateEntities
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000024;
		  int iVar1;
		  undefined4 *puVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int iVar5;
		  int iVar6;
		  int *piVar7;
		  uint *puVar8;
		  int iVar9;
		  undefined4 param2_00;
		  undefined8 param3_00;
		  int *piVar10;
		  uint uVar11;
		  int local_c;
		  int **local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a58800 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Single_GroupData___);
		    Mono_Security_ASN1__get_Item(&System_Func_GroupData__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_IEnumerator_ProtoGetUserAnitiqArtifactsAns_Types_ArtifactGroup__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_GroupData__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_GroupData___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_GroupData__get_Count__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_GroupData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Google_Protobuf_Collections_RepeatedField_ProtoGetUserAnitiqArtifactsAns_Types_ArtifactGroup__GetEnumerator__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Antiq_Control_AntiqController___c__DisplayClass5_0__SetUserArtifacts_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Antiq_Control_AntiqController___c__DisplayClass5_0_TypeInfo);
		    DAT_ram_00a58800 = '\x01';
		  }
		  iVar1 = unnamed_function_1417(System_Collections_Generic_List_GroupData__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (iVar1,Method_System_Collections_Generic_List_GroupData___ctor__);
		  local_4 = (int *)Google_Protobuf_Collections_RepeatedField_float___Equals
		                             (*(undefined4 *)(param2 + 0xc),
		                              Method_Google_Protobuf_Collections_RepeatedField_ProtoGetUserAnitiqArtifactsAns_Types_ArtifactGroup__GetEnumerator__
		                             );
		  local_c = 0;
		  local_8 = &local_4;
		code_r0x80f2e09f:
		  do {
		    do {
		      piVar7 = local_4;
		      iVar9 = *local_4;
		      if (*(ushort *)(iVar9 + 0xb6) != 0) {
		        uVar11 = 0;
		        do {
		          piVar10 = (int *)(*(int *)(iVar9 + 0x58) + uVar11 * 8);
		          if (System_Collections_IEnumerator_TypeInfo == *piVar10) {
		            puVar2 = (undefined4 *)(iVar9 + piVar10[1] * 8 + 0xc0);
		            goto code_r0x80f2e145;
		          }
		          uVar11 = uVar11 + 1;
		        } while (*(ushort *)(iVar9 + 0xb6) != uVar11);
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar2 = (undefined4 *)
		               import::env::invoke_iiii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                          System_Collections_IEnumerator_TypeInfo,0);
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x80f2e189:
		        DAT_ram_009d3e38 = 0;
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80f2e660;
		      }
		code_r0x80f2e145:
		      DAT_ram_009d3e38 = 0;
		      iVar9 = import::env::invoke_iii(*puVar2,piVar7,puVar2[1]);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x80f2e189;
		      if (iVar9 == 0) goto code_r0x80f2e6a9;
		      DAT_ram_009d3e38 = 0;
		      iVar9 = import::env::invoke_ii
		                        (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                         Gameplay_Antiq_Control_AntiqController___c__DisplayClass5_0_TypeInfo);
		      piVar7 = local_4;
		      if (DAT_ram_009d3e38 == 1) {
		        DAT_ram_009d3e38 = 0;
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80f2e660;
		      }
		      iVar6 = *local_4;
		      if (*(ushort *)(iVar6 + 0xb6) != 0) {
		        uVar11 = 0;
		        do {
		          piVar10 = (int *)(*(int *)(iVar6 + 0x58) + uVar11 * 8);
		          if (System_Collections_Generic_IEnumerator_ProtoGetUserAnitiqArtifactsAns_Types_ArtifactGroup__TypeInfo
		              == *piVar10) {
		            puVar2 = (undefined4 *)(iVar6 + piVar10[1] * 8 + 0xc0);
		            goto code_r0x80f2e299;
		          }
		          uVar11 = uVar11 + 1;
		        } while (*(ushort *)(iVar6 + 0xb6) != uVar11);
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar2 = (undefined4 *)
		               import::env::invoke_iiii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                          System_Collections_Generic_IEnumerator_ProtoGetUserAnitiqArtifactsAns_Types_ArtifactGroup__TypeInfo
		                          ,0);
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x80f2e57f:
		        DAT_ram_009d3e38 = 0;
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80f2e660;
		      }
		code_r0x80f2e299:
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::invoke_iii(*puVar2,piVar7,puVar2[1]);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x80f2e57f;
		      *(undefined4 *)(iVar9 + 8) = uVar3;
		      DAT_ram_009d3e38 = 0;
		      iVar4 = import::env::invoke_iii
		                        (*(undefined4 *)(*param1 + 0x100),param1,*(undefined4 *)(*param1 + 0x104));
		      iVar6 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar6 == 1) {
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80f2e660;
		      }
		      param2_00 = *(undefined4 *)(iVar4 + 0x24);
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::invoke_ii
		                        (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                         System_Func_GroupData__bool__TypeInfo);
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x80f2e593:
		        DAT_ram_009d3e38 = 0;
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80f2e660;
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_viiii
		                (s_struct_Uniforms___color__array<v_ram_00000aff + 0x21b,uVar3,iVar9,
		                 Method_Gameplay_Antiq_Control_AntiqController___c__DisplayClass5_0__SetUserArtifacts_b__0__
		                 ,0);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x80f2e593;
		      DAT_ram_009d3e38 = 0;
		      iVar4 = import::env::invoke_iiii
		                        (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x33e,param2_00,uVar3,
		                         Method_System_Linq_Enumerable_Single_GroupData___);
		      iVar6 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar6 == 1) {
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80f2e660;
		      }
		      if (DAT_ram_00a587fd == '\0') {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vi
		                  (0x7ff,&
		                         Method_System_Collections_ObjectModel_ReadOnlyCollection_ArtifactData__Contains__
		                  );
		        if (DAT_ram_009d3e38 != 1) {
		          DAT_ram_00a587fd = '\x01';
		          goto code_r0x80f2e411;
		        }
		code_r0x80f2e5a7:
		        DAT_ram_009d3e38 = 0;
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80f2e660;
		      }
		code_r0x80f2e411:
		      DAT_ram_009d3e38 = 0;
		      iVar6 = import::env::invoke_iiii
		                        (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x198,
		                         *(undefined4 *)(iVar4 + 8),*(undefined4 *)(iVar4 + 0x18),
		                         Method_System_Collections_ObjectModel_ReadOnlyCollection_ArtifactData__Contains__
		                        );
		      if (DAT_ram_009d3e38 == 1) goto code_r0x80f2e5a7;
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::invoke_iii
		                        (*(undefined4 *)(*param1 + 0x100),param1,*(undefined4 *)(*param1 + 0x104));
		      iVar5 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar5 == 1) {
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80f2e660;
		      }
		      param3_00 = *(undefined8 *)(*(int *)(iVar9 + 8) + 0x18);
		      DAT_ram_009d3e38 = 0;
		      uVar3 = unnamed_function_184070
		                        (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x199,uVar3,param3_00,0);
		      iVar9 = DAT_ram_009d3e38;
		      in_register_20000024 = (undefined4)((ulonglong)param3_00 >> 0x20);
		      DAT_ram_009d3e38 = 0;
		      if (iVar9 == 1) {
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80f2e660;
		      }
		      *(undefined4 *)(iVar4 + 0x18) = uVar3;
		      if (DAT_ram_00a587fd == '\0') {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vi
		                  (0x7ff,&
		                         Method_System_Collections_ObjectModel_ReadOnlyCollection_ArtifactData__Contains__
		                  );
		        if (DAT_ram_009d3e38 != 1) {
		          DAT_ram_00a587fd = '\x01';
		          uVar3 = *(undefined4 *)(iVar4 + 0x18);
		          goto code_r0x80f2e52c;
		        }
		code_r0x80f2e5c5:
		        DAT_ram_009d3e38 = 0;
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80f2e660;
		      }
		code_r0x80f2e52c:
		      DAT_ram_009d3e38 = 0;
		      iVar5 = import::env::invoke_iiii
		                        (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x198,
		                         *(undefined4 *)(iVar4 + 8),uVar3,
		                         Method_System_Collections_ObjectModel_ReadOnlyCollection_ArtifactData__Contains__
		                        );
		      iVar9 = Method_System_Collections_Generic_List_GroupData__Add__;
		      if (DAT_ram_009d3e38 == 1) goto code_r0x80f2e5c5;
		    } while (iVar5 == iVar6);
		    *(int *)(iVar1 + 0x10) = *(int *)(iVar1 + 0x10) + 1;
		    uVar11 = *(uint *)(iVar1 + 0xc);
		    if (uVar11 < *(uint *)(*(int *)(iVar1 + 8) + 0xc)) {
		      *(uint *)(iVar1 + 0xc) = uVar11 + 1;
		      *(int *)(*(int *)(iVar1 + 8) + uVar11 * 4 + 0x10) = iVar4;
		      goto code_r0x80f2e09f;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar1,iVar4,
		               *(undefined4 *)(*(int *)(*(int *)(iVar9 + 0x10) + 0x60) + 0x38));
		    iVar9 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar9 != 1);
		  uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80f2e660:
		  iVar9 = global_1;
		  iVar6 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar9 == iVar6) {
		    piVar7 = (int *)import::env::__cxa_begin_catch(uVar3);
		    local_c = *piVar7;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar9 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar9 != 1) {
		code_r0x80f2e6a9:
		      DAT_ram_009d3e38 = 0;
		      piVar7 = *local_8;
		      if (piVar7 != (int *)0x0) {
		        uVar11 = 0;
		        iVar9 = *piVar7;
		        if (*(ushort *)(iVar9 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar9 + 0x58) + uVar11 * 8)) {
		              puVar8 = (uint *)(iVar9 + *(int *)(*(int *)(iVar9 + 0x58) + uVar11 * 8 + 4) * 8 + 0xc0
		                               );
		              goto code_r0x80f2e724;
		            }
		            uVar11 = uVar11 + 1;
		          } while (*(ushort *)(iVar9 + 0xb6) != uVar11);
		        }
		        puVar8 = (uint *)func_ii_1080(piVar7,System_IDisposable_TypeInfo,0);
		code_r0x80f2e724:
		        (**(code **)((ulonglong)*puVar8 * 4))(piVar7,puVar8[1]);
		      }
		      if (local_c != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(local_c);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      if ((0 < *(int *)(iVar1 + 0xc)) && (*(char *)((int)param1 + 9) != '\0')) {
		        iVar9 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0x114));
		        iVar9 = *(int *)(iVar9 + 0x18);
		        if (iVar9 != 0) {
		          (**(code **)((ulonglong)*(uint *)(iVar9 + 0xc) * 4))
		                    (*(undefined4 *)(iVar9 + 0x20),iVar1,
		                     CONCAT44(in_register_20000024,*(undefined4 *)(iVar9 + 0x14)));
		        }
		      }
		      return;
		    }
		    uVar3 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x19a,&local_c);
		  iVar1 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar1 != 1) {
		    import::env::__resumeException(uVar3);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__cxa_find_matching_catch_3(0);
		  unnamed_function_937();
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06005511 RID: 21777 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005511")]
		[Address(RVA = "0xA2B5", Offset = "0xA2B5", VA = "0xA2B5")]
		private void SetUserArtifacts(ProtoGetUserAnitiqArtifactsAns msg)
		{
		/* --- GHIDRA: SetUserArtifacts ---
		void Gameplay_Antiq_Control_AntiqController__SetUserArtifacts(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a58801 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Antiq_Control_AntiqController_HandleGetUserAntiqArtifactsService__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    DAT_ram_00a58801 = '\x01';
		  }
		  uVar1 = ServicesNamespace_MainService__GetUserLevelReward(*(undefined4 *)(param1 + 0x18),0);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_Antiq_Control_AntiqController_HandleGetUserAntiqArtifactsService__,0);
		  uVar1 = ServicesNamespace_MainService__GetUserStats
		                    (uVar1,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x06005512 RID: 21778 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005512")]
		[Address(RVA = "0xA2B6", Offset = "0xA2B6", VA = "0xA2B6")]
		private void RequestUpdateUserArtifacts()
		{
		/* --- GHIDRA: RequestUpdateUserArtifacts ---
		void Gameplay_Antiq_Control_AntiqController__RequestUpdateUserArtifacts
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int *param1_00;
		  
		  if (DAT_ram_00a58802 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Main_ProtoGetUserAnitiqArtifactsAns_TypeInfo);
		    DAT_ram_00a58802 = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  param1_00 = *(int **)(param2 + 0x20);
		  if ((param1_00 != (int *)0x0) &&
		     (Protocol_Main_ProtoGetUserAnitiqArtifactsAns_TypeInfo != *param1_00)) {
		    System_Activator__CreateInstance
		              (param1_00,Protocol_Main_ProtoGetUserAnitiqArtifactsAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  Gameplay_Antiq_Control_AntiqController__CreateEntities(param1,param1_00,param1);
		  if (*(char *)((int)param1 + 9) == '\0') {
		    *(undefined1 *)((int)param1 + 9) = 1;
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar1 = *(int *)(iVar1 + 8);
		    if (iVar1 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06005513 RID: 21779 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005513")]
		[Address(RVA = "0xA2B7", Offset = "0xA2B7", VA = "0xA2B7")]
		private void HandleGetUserAntiqArtifactsService(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: HandleGetUserAntiqArtifactsService ---
		void Gameplay_Antiq_Control_AntiqController__HandleGetUserAntiqArtifactsService
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if (*(int *)(iVar1 + 0x2c) != param2) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    *(int *)(iVar1 + 0x2c) = param2;
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar1 = *(int *)(iVar1 + 0x20);
		    if (iVar1 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),param2,*(undefined4 *)(iVar1 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06005514 RID: 21780 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005514")]
		[Address(RVA = "0xA2B8", Offset = "0xA2B8", VA = "0xA2B8")]
		private void SetCurrentArtifact(ArtifactData artifact)
		{
		/* --- GHIDRA: SetCurrentArtifact ---
		void Gameplay_Antiq_Control_AntiqController__SetCurrentArtifact
		               (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  int iVar4;
		  undefined4 param2_00;
		  int iVar5;
		  int *piVar6;
		  
		  if (DAT_ram_00a58803 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_ICollection_GroupData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IList_GroupData__TypeInfo);
		    DAT_ram_00a58803 = '\x01';
		  }
		  iVar5 = *(int *)(param2 + 0x14);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  piVar6 = *(int **)(iVar2 + 0x24);
		  iVar2 = *piVar6;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (System_Collections_Generic_ICollection_GroupData__TypeInfo ==
		          *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(iVar2 + *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80f2eaa1;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar6,System_Collections_Generic_ICollection_GroupData__TypeInfo,0)
		  ;
		code_r0x80f2eaa1:
		  iVar2 = (**(code **)((ulonglong)*puVar3 * 4))(piVar6,puVar3[1]);
		  iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar1 = 0;
		  piVar6 = *(int **)(iVar4 + 0x24);
		  iVar4 = *piVar6;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (System_Collections_Generic_IList_GroupData__TypeInfo ==
		          *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80f2eb3e;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar6,System_Collections_Generic_IList_GroupData__TypeInfo,0);
		code_r0x80f2eb3e:
		  iVar5 = iVar5 + 1;
		  if (iVar2 + -1 < iVar5) {
		    iVar5 = 0;
		  }
		  param2_00 = (**(code **)((ulonglong)*puVar3 * 4))(piVar6,iVar5,puVar3[1]);
		  System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___UserEquipmentViewMediator__ShowAntiqGroupReview_d__13_
		            (param1,param2_00,puVar3);
		  return;
		}
		*/

		}

		// Token: 0x06005515 RID: 21781 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005515")]
		[Address(RVA = "0x1F40", Offset = "0x1F40", VA = "0x1F40")]
		public void SetCurrentGroup(GroupData group)
		{
		}

		// Token: 0x06005516 RID: 21782 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005516")]
		[Address(RVA = "0xA2B9", Offset = "0xA2B9", VA = "0xA2B9")]
		public void SelectGroupNext(GroupData group)
		{
		/* --- GHIDRA: SelectGroupNext ---
		void Gameplay_Antiq_Control_AntiqController__SelectGroupNext
		               (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 param2_00;
		  int iVar4;
		  int *piVar5;
		  
		  if (DAT_ram_00a58804 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_ICollection_GroupData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IList_GroupData__TypeInfo);
		    DAT_ram_00a58804 = '\x01';
		  }
		  iVar4 = *(int *)(param2 + 0x14) + -1;
		  if (iVar4 < 0) {
		    iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    uVar1 = 0;
		    piVar5 = *(int **)(iVar4 + 0x24);
		    iVar4 = *piVar5;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      do {
		        if (System_Collections_Generic_ICollection_GroupData__TypeInfo ==
		            *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x80f2ec2e;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar5,System_Collections_Generic_ICollection_GroupData__TypeInfo,
		                                  0);
		code_r0x80f2ec2e:
		    iVar4 = (**(code **)((ulonglong)*puVar3 * 4))(piVar5,puVar3[1]);
		    iVar4 = iVar4 + -1;
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar1 = 0;
		  piVar5 = *(int **)(iVar2 + 0x24);
		  iVar2 = *piVar5;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    do {
		      if (System_Collections_Generic_IList_GroupData__TypeInfo ==
		          *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(iVar2 + *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80f2eccf;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar5,System_Collections_Generic_IList_GroupData__TypeInfo,0);
		code_r0x80f2eccf:
		  param2_00 = (**(code **)((ulonglong)*puVar3 * 4))(piVar5,iVar4,puVar3[1]);
		  System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___UserEquipmentViewMediator__ShowAntiqGroupReview_d__13_
		            (param1,param2_00,puVar3);
		  return;
		}
		*/

		}

		// Token: 0x06005517 RID: 21783 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005517")]
		[Address(RVA = "0xA2BA", Offset = "0xA2BA", VA = "0xA2BA")]
		public void SelectGroupBack(GroupData group)
		{
		/* --- GHIDRA: SelectGroupBack ---
		void Gameplay_Antiq_Control_AntiqController__SelectGroupBack
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a58805 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_ObjectModel_ReadOnlyCollection_ArtifactData__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_ObjectModel_ReadOnlyCollection_ArtifactData__get_Item__);
		    DAT_ram_00a58805 = '\x01';
		  }
		  iVar3 = *(int *)(param2 + 0x14);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  iVar1 = Sirenix_Utilities_ImmutableList___Il2CppFullySharedGenericType___System_Collections_IList_set_Item
		                    (*(undefined4 *)(*(int *)(iVar1 + 0x28) + 8),
		                     Method_System_Collections_ObjectModel_ReadOnlyCollection_ArtifactData__get_Count__
		                    );
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  iVar3 = iVar3 + 1;
		  if (iVar1 + -1 < iVar3) {
		    iVar1 = Gameplay_Antiq_Model_GroupData___ctor(*(int *)(iVar2 + 0x28),param1);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    if (iVar1 == *(int *)(iVar2 + 0x2c)) {
		      return;
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    *(int *)(iVar2 + 0x2c) = iVar1;
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar2 = *(int *)(iVar2 + 0x20);
		  }
		  else {
		    iVar1 = System_Collections_ObjectModel_ReadOnlyDictionary_object__object___get_Count
		                      (*(undefined4 *)(*(int *)(iVar2 + 0x28) + 8),iVar3,
		                       Method_System_Collections_ObjectModel_ReadOnlyCollection_ArtifactData__get_Item__
		                      );
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    if (iVar1 == *(int *)(iVar2 + 0x2c)) {
		      return;
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    *(int *)(iVar2 + 0x2c) = iVar1;
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar2 = *(int *)(iVar2 + 0x20);
		  }
		  if (iVar2 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		              (*(undefined4 *)(iVar2 + 0x20),iVar1,*(undefined4 *)(iVar2 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06005518 RID: 21784 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005518")]
		[Address(RVA = "0xA2BB", Offset = "0xA2BB", VA = "0xA2BB")]
		public void SelectArtifactNext(ArtifactData artifact)
		{
		/* --- GHIDRA: SelectArtifactNext ---
		void Gameplay_Antiq_Control_AntiqController__SelectArtifactNext
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a58806 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Last_ArtifactData___);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_ObjectModel_ReadOnlyCollection_ArtifactData__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_ObjectModel_ReadOnlyCollection_ArtifactData__get_Item__);
		    DAT_ram_00a58806 = '\x01';
		  }
		  iVar2 = *(int *)(param2 + 0x14) + -1;
		  if (iVar2 < 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    iVar2 = Sirenix_Utilities_ImmutableList___Il2CppFullySharedGenericType___System_Collections_IList_set_Item
		                      (*(undefined4 *)(*(int *)(iVar2 + 0x28) + 8),
		                       Method_System_Collections_ObjectModel_ReadOnlyCollection_ArtifactData__get_Count__
		                      );
		    iVar2 = iVar2 + -1;
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  iVar2 = System_Collections_ObjectModel_ReadOnlyDictionary_object__object___get_Count
		                    (*(undefined4 *)(*(int *)(iVar1 + 0x28) + 8),iVar2,
		                     Method_System_Collections_ObjectModel_ReadOnlyCollection_ArtifactData__get_Item__
		                    );
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if (iVar2 == *(int *)(*(int *)(iVar1 + 0x28) + 0x18)) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    iVar2 = System_Linq_Enumerable__IntersectIterator___Il2CppFullySharedGenericType_
		                      (*(undefined4 *)(*(int *)(iVar2 + 0x28) + 8),
		                       Method_System_Linq_Enumerable_Last_ArtifactData___);
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if (*(int *)(iVar1 + 0x2c) != iVar2) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    *(int *)(iVar1 + 0x2c) = iVar2;
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar1 = *(int *)(iVar1 + 0x20);
		    if (iVar1 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),iVar2,*(undefined4 *)(iVar1 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06005519 RID: 21785 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005519")]
		[Address(RVA = "0xA2BC", Offset = "0xA2BC", VA = "0xA2BC")]
		public void SelectArtifactBack(ArtifactData artifact)
		{
		/* --- GHIDRA: SelectArtifactBack ---
		void Gameplay_Antiq_Control_AntiqController__SelectArtifactBack(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a58807 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Antiq_Control_AntiqController___c_TypeInfo);
		    DAT_ram_00a58807 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Gameplay_Antiq_Control_AntiqController___c_TypeInfo);
		  **(undefined4 **)(Gameplay_Antiq_Control_AntiqController___c_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x04002E18 RID: 11800
		[Token(Token = "0x4002E18")]
		[FieldOffset(Offset = "0x18")]
		private readonly MainService _mainService;
	}
}
