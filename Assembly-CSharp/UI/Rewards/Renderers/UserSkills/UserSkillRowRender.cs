using System;
using Gameplay.Inventory.View.Info.InfoBox;
using Il2CppDummyDll;
using UnityEngine;

namespace UI.Rewards.Renderers.UserSkills
{
	// Token: 0x020001AE RID: 430
	[Token(Token = "0x20001AE")]
	[RequireComponent(typeof(TitleIconLoaderValueRow))]
	public class UserSkillRowRender : AbstractRewardRender
	{
		// Token: 0x17000183 RID: 387
		// (get) Token: 0x06000B9B RID: 2971 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000183")]
		public TitleIconLoaderValueRow Row
		{
			[Token(Token = "0x6000B9B")]
			[Address(RVA = "0x5EB4", Offset = "0x5EB4", VA = "0x5EB4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000B9C RID: 2972 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B9C")]
		[Address(RVA = "0x5EB5", Offset = "0x5EB5", VA = "0x5EB5")]
		public UserSkillRowRender()
		{
		/* --- GHIDRA: .ctor ---
		void UI_Rewards_Renderers_UserSkills_UserSkillRowRender___ctor(int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint uVar2;
		  undefined4 param1_00;
		  undefined4 uVar3;
		  int iVar4;
		  undefined4 uVar5;
		  int *piVar6;
		  int iVar7;
		  undefined4 *puVar8;
		  undefined4 uVar9;
		  int iVar10;
		  int iVar11;
		  int *piVar12;
		  int local_34;
		  undefined8 *puStack_30;
		  undefined8 local_2c;
		  int *local_24;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a59a33 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_UserSkillRowRender___);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_int__TitleIconLoaderValueRow__TryGetValue__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_int__TitleIconLoaderValueRow___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_int__TitleIconLoaderValueRow__get_Count__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_int__SkillData__get_Values__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_int__TitleIconLoaderValueRow__set_Item__
		              );
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_Dictionary_int__TitleIconLoaderValueRow__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToList_SkillData___);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_int__SkillData__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_IRewardInfo__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_IRewardInfo__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_int__SkillData__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_IRewardInfo__get_Current__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_int__SkillData__get_Current__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Data_Decorators_IRewardInfo_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_IRewardInfo__GetEnumerator__);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_AbstractRewardRender___);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_GameObject___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Data_Skills_SkillCollection_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_int__SkillData__GetEnumerator__
		              );
		    Mono_Security_ASN1__get_Item(&StringLiteral_2003);
		    DAT_ram_00a59a33 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  local_18 = 0;
		  local_20 = 0;
		  local_24 = (int *)0x0;
		  param1_00 = unnamed_function_1417
		                        (
		                        System_Collections_Generic_Dictionary_int__TitleIconLoaderValueRow__TypeInfo
		                        );
		  System_Collections_Generic_Dictionary_int__TMP_ResourceManager_FontAssetRef___set_Item
		            (param1_00,
		             Method_System_Collections_Generic_Dictionary_int__TitleIconLoaderValueRow___ctor__);
		  iVar11 = param1[10];
		  uVar3 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                    (param1[4],0);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  uVar3 = func_ii_6805(iVar11,uVar3,Method_UnityEngine_Object_Instantiate_GameObject___);
		  iVar11 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                     (param1,*(undefined4 *)(*param1 + 0xf4));
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_34,*(undefined4 *)(iVar11 + 8),
		             Method_System_Collections_Generic_List_IRewardInfo__GetEnumerator__);
		  local_8 = local_2c;
		  local_34 = 0;
		  puStack_30 = &local_10;
		  iVar11 = 0;
		code_r0x810af97f:
		  do {
		    iVar10 = iVar11;
		    DAT_ram_009d3e38 = 0;
		    iVar4 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_10,
		                       Method_System_Collections_Generic_List_Enumerator_IRewardInfo__MoveNext__);
		    iVar11 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar11 == 1) {
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x810afca6;
		    }
		    if (iVar4 == 0) goto code_r0x810afcfc;
		    piVar6 = local_8._4_4_;
		    iVar11 = *local_8._4_4_;
		    uVar2 = (uint)*(ushort *)(iVar11 + 0xb6);
		    if (iVar10 == 0) {
		      if (uVar2 != 0) {
		        uVar1 = 0;
		        do {
		          piVar12 = (int *)(*(int *)(iVar11 + 0x58) + uVar1 * 8);
		          if (Core_Data_Decorators_IRewardInfo_TypeInfo == *piVar12) {
		            puVar8 = (undefined4 *)(piVar12[1] * 8 + iVar11 + 0xd0);
		            goto code_r0x810afa60;
		          }
		          uVar1 = uVar1 + 1;
		        } while (uVar2 != uVar1);
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar8 = (undefined4 *)
		               import::env::invoke_iiii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_8._4_4_,
		                          Core_Data_Decorators_IRewardInfo_TypeInfo,2);
		      if (DAT_ram_009d3e38 != 1) {
		code_r0x810afa60:
		        DAT_ram_009d3e38 = 0;
		        uVar5 = import::env::invoke_iii(*puVar8,piVar6,puVar8[1]);
		        if (DAT_ram_009d3e38 != 1) {
		          DAT_ram_009d3e38 = 0;
		          iVar11 = import::env::invoke_ii
		                             (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                              Core_Data_Skills_SkillCollection_TypeInfo);
		          if (DAT_ram_009d3e38 != 1) {
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_viii
		                      (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x75,iVar11,uVar5,0);
		            if (DAT_ram_009d3e38 != 1) goto code_r0x810af97f;
		          }
		          DAT_ram_009d3e38 = 0;
		          iVar10 = 0;
		          uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x810afca6;
		        }
		      }
		      DAT_ram_009d3e38 = 0;
		      iVar10 = 0;
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x810afca6;
		    }
		    if (uVar2 != 0) {
		      uVar1 = 0;
		      do {
		        piVar12 = (int *)(*(int *)(iVar11 + 0x58) + uVar1 * 8);
		        if (Core_Data_Decorators_IRewardInfo_TypeInfo == *piVar12) {
		          puVar8 = (undefined4 *)(piVar12[1] * 8 + iVar11 + 0xd0);
		          goto code_r0x810afb8f;
		        }
		        uVar1 = uVar1 + 1;
		      } while (uVar2 != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar8 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_8._4_4_,
		                        Core_Data_Decorators_IRewardInfo_TypeInfo,2);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x810afc72:
		      DAT_ram_009d3e38 = 0;
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x810afca6;
		    }
		code_r0x810afb8f:
		    DAT_ram_009d3e38 = 0;
		    uVar5 = import::env::invoke_iii(*puVar8,piVar6,puVar8[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x810afc72;
		    DAT_ram_009d3e38 = 0;
		    uVar9 = import::env::invoke_ii
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                       Core_Data_Skills_SkillCollection_TypeInfo);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x810afc7c:
		      DAT_ram_009d3e38 = 0;
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x810afca6;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii(s_struct_Uniforms___color__array<v_ram_00001f04 + 0x75,uVar9,uVar5,0);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x810afc7c;
		    DAT_ram_009d3e38 = 0;
		    iVar11 = import::env::invoke_iiii
		                       (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x76,iVar10,uVar9,0);
		    iVar4 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar4 != 1);
		  uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x810afca6:
		  iVar11 = global_1;
		  iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar11 == iVar4) {
		    piVar6 = (int *)import::env::__cxa_begin_catch(uVar5);
		    iVar4 = *piVar6;
		    DAT_ram_009d3e38 = 0;
		    local_34 = iVar4;
		    import::env::invoke_v(0x123);
		    iVar11 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar11 != 1) {
		      if (iVar4 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar4);
		        do {
		          halt_trap();
		        } while( true );
		      }
		code_r0x810afcfc:
		      DAT_ram_009d3e38 = 0;
		      uVar5 = System_Collections_Generic_Dictionary_int__object___TryAdd
		                        (iVar10,
		                         Method_System_Collections_Generic_Dictionary_int__SkillData__get_Values__);
		      System_Linq_Enumerable__Select_object__object_
		                (uVar5,Method_System_Linq_Enumerable_ToList_SkillData___);
		      uVar5 = System_Collections_Generic_Dictionary_int__object___TryAdd
		                        (iVar10,
		                         Method_System_Collections_Generic_Dictionary_int__SkillData__get_Values__);
		      System_Collections_Generic_Dictionary_Int32Enum__object___get_Values
		                (&local_34,uVar5,
		                 Method_System_Collections_Generic_Dictionary_ValueCollection_int__SkillData__GetEnumerator__
		                );
		      local_18 = local_2c;
		      local_20 = CONCAT44(puStack_30,local_34);
		      local_34 = 0;
		      puStack_30 = &local_20;
		      iVar11 = 0;
		      while( true ) {
		        DAT_ram_009d3e38 = 0;
		        iVar4 = import::env::invoke_iii
		                          (s_struct_Uniforms___color__array<v_ram_00000aff + 0x152,&local_20,
		                           Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_int__SkillData__MoveNext__
		                          );
		        iVar10 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar10 == 1) break;
		        if (iVar4 == 0) {
		          DAT_ram_009d3e38 = 0;
		          return;
		        }
		        DAT_ram_009d3e38 = 0;
		        iVar4 = local_18._4_4_;
		        iVar7 = func_ii_7588(local_18._4_4_,0);
		        iVar10 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar10 == 1) {
		          uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x810b05ac;
		        }
		        if (iVar7 == 0) {
		          DAT_ram_009d3e38 = 0;
		          iVar7 = import::env::invoke_iiiii
		                            (s_struct_Uniforms___color__array<v_ram_000013c7 + 0x217,param1_00,
		                             iVar11,&local_24,
		                             Method_System_Collections_Generic_Dictionary_int__TitleIconLoaderValueRow__TryGetValue__
		                            );
		          iVar10 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar10 == 1) {
		            uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x810b05ac;
		          }
		          if (iVar7 == 0) {
		            iVar10 = param1[5];
		            DAT_ram_009d3e38 = 0;
		            uVar5 = import::env::invoke_iii
		                              (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x17b,uVar3,0);
		            if (DAT_ram_009d3e38 == 1) {
		code_r0x810b04e9:
		              DAT_ram_009d3e38 = 0;
		              uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            }
		            else {
		              if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		                DAT_ram_009d3e38 = 0;
		                import::env::invoke_vi
		                          (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                           UnityEngine_Object_TypeInfo);
		                if (DAT_ram_009d3e38 == 1) goto code_r0x810b04e9;
		              }
		              DAT_ram_009d3e38 = 0;
		              uVar5 = import::env::invoke_iiii
		                                (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x2ce,iVar10,
		                                 uVar5,Method_UnityEngine_Object_Instantiate_AbstractRewardRender___
		                                );
		              iVar10 = DAT_ram_009d3e38;
		              DAT_ram_009d3e38 = 0;
		              if (iVar10 == 1) {
		                uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		              }
		              else {
		                DAT_ram_009d3e38 = 0;
		                iVar7 = import::env::invoke_iii
		                                  (s_struct_Uniforms___color__array<v_ram_000013c7 + 0x267,uVar5,
		                                   Method_UnityEngine_Component_GetComponent_UserSkillRowRender___);
		                iVar10 = DAT_ram_009d3e38;
		                DAT_ram_009d3e38 = 0;
		                if (iVar10 == 1) {
		                  uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                }
		                else {
		                  if (DAT_ram_00a59a32 == '\0') {
		                    DAT_ram_009d3e38 = 0;
		                    import::env::invoke_vi
		                              (0x7ff,&
		                                     Method_UnityEngine_Component_GetComponent_TitleIconLoaderValueRow___
		                              );
		                    if (DAT_ram_009d3e38 != 1) {
		                      DAT_ram_009d3e38 = 0;
		                      import::env::invoke_vi(0x7ff,&UnityEngine_Object_TypeInfo);
		                      if (DAT_ram_009d3e38 != 1) {
		                        DAT_ram_00a59a32 = '\x01';
		                        goto code_r0x810affc9;
		                      }
		                    }
		                  }
		                  else {
		code_r0x810affc9:
		                    uVar5 = *(undefined4 *)(iVar7 + 0x28);
		                    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		                      DAT_ram_009d3e38 = 0;
		                      import::env::invoke_vi
		                                (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                                 UnityEngine_Object_TypeInfo);
		                      if (DAT_ram_009d3e38 == 1) goto code_r0x810b0507;
		                    }
		                    DAT_ram_009d3e38 = 0;
		                    iVar10 = import::env::invoke_iiii
		                                       (s_struct_Uniforms___color__array<v_ram_00000aff + 0x3e6,
		                                        uVar5,0,0);
		                    if (DAT_ram_009d3e38 != 1) {
		                      if (iVar10 == 0) {
		                        piVar6 = *(int **)(iVar7 + 0x28);
		                      }
		                      else {
		                        DAT_ram_009d3e38 = 0;
		                        piVar6 = (int *)import::env::invoke_iii
		                                                  (s_struct_Uniforms___color__array<v_ram_000013c7 +
		                                                   0x267,iVar7,
		                                                                                                      
		                                                  Method_UnityEngine_Component_GetComponent_TitleIconLoaderValueRow___
		                                                  );
		                        if (DAT_ram_009d3e38 == 1) goto code_r0x810b0507;
		                        *(int **)(iVar7 + 0x28) = piVar6;
		                      }
		                      DAT_ram_009d3e38 = 0;
		                      local_24 = piVar6;
		                      uVar5 = System_Collections_Generic_HashSet_Enumerator_object___Dispose
		                                        (param1_00,
		                                         Method_System_Collections_Generic_Dictionary_int__TitleIconLoaderValueRow__get_Count__
		                                        );
		                      if (DAT_ram_009d3e38 != 1) {
		                        DAT_ram_009d3e38 = 0;
		                        import::env::invoke_viii
		                                  (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x79,piVar6,
		                                   uVar5,0);
		                        if (DAT_ram_009d3e38 != 1) {
		                          if (DAT_ram_00a6456f == '\0') {
		                            DAT_ram_009d3e38 = 0;
		                            import::env::invoke_vi(0x7ff,&Core_Gameplay_Game_TypeInfo);
		                            iVar10 = DAT_ram_009d3e38;
		                            DAT_ram_009d3e38 = 0;
		                            if (iVar10 == 1) {
		                              uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                              goto code_r0x810b05ac;
		                            }
		                            DAT_ram_00a6456f = '\x01';
		                          }
		                          piVar6 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		                          iVar10 = *piVar6;
		                          if (*(ushort *)(iVar10 + 0xb6) != 0) {
		                            uVar2 = 0;
		                            do {
		                              piVar12 = (int *)(*(int *)(iVar10 + 0x58) + uVar2 * 8);
		                              if (Core_Gameplay_IGame_TypeInfo == *piVar12) {
		                                puVar8 = (undefined4 *)(piVar12[1] * 8 + iVar10 + 0x178);
		                                goto code_r0x810b01e0;
		                              }
		                              uVar2 = uVar2 + 1;
		                            } while (*(ushort *)(iVar10 + 0xb6) != uVar2);
		                          }
		                          DAT_ram_009d3e38 = 0;
		                          puVar8 = (undefined4 *)
		                                   import::env::invoke_iiii
		                                             (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18
		                                              ,piVar6,Core_Gameplay_IGame_TypeInfo,0x17);
		                          if (DAT_ram_009d3e38 != 1) {
		code_r0x810b01e0:
		                            DAT_ram_009d3e38 = 0;
		                            uVar5 = import::env::invoke_iii(*puVar8,piVar6,puVar8[1]);
		                            if (DAT_ram_009d3e38 != 1) {
		                              DAT_ram_009d3e38 = 0;
		                              uVar5 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System
		                                                (uVar5,0);
		                              iVar10 = DAT_ram_009d3e38;
		                              DAT_ram_009d3e38 = 0;
		                              if (iVar10 == 1) {
		                                uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                              }
		                              else {
		                                DAT_ram_009d3e38 = 0;
		                                uVar5 = import::env::invoke_iiii
		                                                  (s_struct_Uniforms___color__array<v_ram_00001b87 +
		                                                   0x33,uVar5,*(undefined4 *)(iVar4 + 8),0);
		                                piVar6 = local_24;
		                                iVar10 = DAT_ram_009d3e38;
		                                DAT_ram_009d3e38 = 0;
		                                if (iVar10 == 1) {
		                                  uVar5 = import::env::__cxa_find_matching_catch_3
		                                                    (&DAT_ram_0072c9c8);
		                                }
		                                else {
		                                  DAT_ram_009d3e38 = 0;
		                                  uVar9 = import::env::invoke_iii
		                                                    (s_struct_Uniforms___color__array<v_ram_00001f04
		                                                     + 0x33,uVar5,0);
		                                  iVar10 = DAT_ram_009d3e38;
		                                  DAT_ram_009d3e38 = 0;
		                                  if (iVar10 == 1) {
		                                    uVar5 = import::env::__cxa_find_matching_catch_3
		                                                      (&DAT_ram_0072c9c8);
		                                  }
		                                  else {
		                                    DAT_ram_009d3e38 = 0;
		                                    uVar9 = import::env::invoke_iiii
		                                                      (
		                                                  s_var<private>_posTex__array<vec4<_ram_00000655 +
		                                                  0x1e4,uVar9,StringLiteral_2003,0);
		                                    if (DAT_ram_009d3e38 != 1) {
		                                      iVar10 = *piVar6;
		                                      DAT_ram_009d3e38 = 0;
		                                      import::env::invoke_viii
		                                                (*(undefined4 *)(iVar10 + 0xf0),piVar6,uVar9,
		                                                 *(undefined4 *)(iVar10 + 0xf4));
		                                      if (DAT_ram_009d3e38 != 1) {
		                                        DAT_ram_009d3e38 = 0;
		                                        import::env::invoke_viii
		                                                  (*(undefined4 *)(*local_24 + 0xf8),local_24,
		                                                   param1[4] + 0x14,
		                                                   *(undefined4 *)(*local_24 + 0xfc));
		                                        iVar10 = DAT_ram_009d3e38;
		                                        DAT_ram_009d3e38 = 0;
		                                        if (iVar10 == 1) {
		                                          uVar5 = import::env::__cxa_find_matching_catch_3
		                                                            (&DAT_ram_0072c9c8);
		                                        }
		                                        else {
		                                          DAT_ram_009d3e38 = 0;
		                                          import::env::invoke_viii
		                                                    (s_struct_Uniforms___color__array<v_ram_00001f04
		                                                     + 0x7a,local_24,param1[4] + 0x18,0);
		                                          piVar6 = local_24;
		                                          iVar10 = DAT_ram_009d3e38;
		                                          DAT_ram_009d3e38 = 0;
		                                          if (iVar10 == 1) {
		                                            uVar5 = import::env::__cxa_find_matching_catch_3
		                                                              (&DAT_ram_0072c9c8);
		                                          }
		                                          else {
		                                            DAT_ram_009d3e38 = 0;
		                                            uVar5 = import::env::invoke_iii
		                                                              (
		                                                  s_struct_Uniforms___color__array<v_ram_00001f04 +
		                                                  0x34,uVar5,0);
		                                            if (DAT_ram_009d3e38 != 1) {
		                                              DAT_ram_009d3e38 = 0;
		                                              import::env::invoke_viii
		                                                        (
		                                                  s_struct_Uniforms___color__array<v_ram_00001f04 +
		                                                  0x7b,piVar6,uVar5,0);
		                                              piVar6 = local_24;
		                                              if (DAT_ram_009d3e38 != 1) {
		                                                DAT_ram_009d3e38 = 0;
		                                                uVar5 = import::env::invoke_iii
		                                                                  (
		                                                  s_struct_Uniforms___color__array<v_ram_00001b87 +
		                                                  0x259,iVar4,0);
		                                                if (DAT_ram_009d3e38 != 1) {
		                                                  DAT_ram_009d3e38 = 0;
		                                                  import::env::invoke_viii(0x1f80,piVar6,uVar5,0);
		                                                  if (DAT_ram_009d3e38 != 1) {
		                                                    DAT_ram_009d3e38 = 0;
		                                                    import::env::invoke_viiii
		                                                              (
		                                                  s_struct_Uniforms___color__array<v_ram_00001f04 +
		                                                  0x7d,param1_00,iVar11,local_24,
		                                                  Method_System_Collections_Generic_Dictionary_int__TitleIconLoaderValueRow__set_Item__
		                                                  );
		                                                  iVar10 = DAT_ram_009d3e38;
		                                                  DAT_ram_009d3e38 = 0;
		                                                  if (iVar10 != 1) goto code_r0x810b04d2;
		                                                  uVar5 = import::env::__cxa_find_matching_catch_3
		                                                                    (&DAT_ram_0072c9c8);
		                                                  goto code_r0x810b05ac;
		                                                  }
		                                                }
		                                                DAT_ram_009d3e38 = 0;
		                                                uVar5 = import::env::__cxa_find_matching_catch_3
		                                                                  (&DAT_ram_0072c9c8);
		                                                goto code_r0x810b05ac;
		                                              }
		                                            }
		                                            DAT_ram_009d3e38 = 0;
		                                            uVar5 = import::env::__cxa_find_matching_catch_3
		                                                              (&DAT_ram_0072c9c8);
		                                          }
		                                        }
		                                        goto code_r0x810b05ac;
		                                      }
		                                    }
		                                    DAT_ram_009d3e38 = 0;
		                                    uVar5 = import::env::__cxa_find_matching_catch_3
		                                                      (&DAT_ram_0072c9c8);
		                                  }
		                                }
		                              }
		                              goto code_r0x810b05ac;
		                            }
		                          }
		                          DAT_ram_009d3e38 = 0;
		                          uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                          goto code_r0x810b05ac;
		                        }
		                      }
		                      DAT_ram_009d3e38 = 0;
		                      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                      goto code_r0x810b05ac;
		                    }
		                  }
		code_r0x810b0507:
		                  DAT_ram_009d3e38 = 0;
		                  uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                }
		              }
		            }
		            goto code_r0x810b05ac;
		          }
		code_r0x810b04d2:
		          iVar11 = iVar11 + 1;
		        }
		      }
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x810b05ac:
		      iVar11 = global_1;
		      iVar10 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar11 == iVar10) {
		        piVar6 = (int *)import::env::__cxa_begin_catch(uVar5);
		        iVar10 = *piVar6;
		        DAT_ram_009d3e38 = 0;
		        local_34 = iVar10;
		        import::env::invoke_v(0x123);
		        iVar11 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar11 != 1) {
		          if (iVar10 == 0) {
		            DAT_ram_009d3e38 = 0;
		            return;
		          }
		          System_Data_DataSet__ValidateLocaleConstraint(iVar10);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        uVar5 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001f04 + 0x7e,&local_34);
		      goto joined_r0x810b063c;
		    }
		    uVar5 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001f04 + 0x77,&local_34);
		joined_r0x810b063c:
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

		}

		// Token: 0x04000565 RID: 1381
		[Token(Token = "0x4000565")]
		[FieldOffset(Offset = "0x28")]
		private TitleIconLoaderValueRow _row;
	}
}
