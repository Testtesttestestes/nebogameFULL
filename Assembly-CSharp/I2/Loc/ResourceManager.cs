using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace I2.Loc
{
	// Token: 0x020013B4 RID: 5044
	[Token(Token = "0x20013B4")]
	public class ResourceManager : MonoBehaviour
	{
		// Token: 0x170017B7 RID: 6071
		// (get) Token: 0x060077E6 RID: 30694 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170017B7")]
		public static ResourceManager pInstance
		{
			[Token(Token = "0x60077E6")]
			[Address(RVA = "0xC140", Offset = "0xC140", VA = "0xC140")]
			get
			{
				return null;
			}
		}

		// Token: 0x060077E7 RID: 30695 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60077E7")]
		[Address(RVA = "0xC141", Offset = "0xC141", VA = "0xC141")]
		public static void MyOnLevelWasLoaded(Scene scene, LoadSceneMode mode)
		{
		/* --- GHIDRA: MyOnLevelWasLoaded ---
		undefined4
		I2_Loc_ResourceManager__MyOnLevelWasLoaded(int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  int iVar3;
		  undefined4 uVar4;
		  
		  iVar1 = 0;
		  if (DAT_ram_00a54e27 == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a54e27 = '\x01';
		  }
		  if ((*(int *)(param1 + 0x14) != 0) && (iVar3 = *(int *)(*(int *)(param1 + 0x14) + 0xc), 0 < iVar3)
		     ) {
		    do {
		      uVar4 = *(undefined4 *)(iVar1 * 4 + *(int *)(param1 + 0x14) + 0x10);
		      if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		        func_ii_306000(UnityEngine_Object_TypeInfo);
		      }
		      iVar2 = UnityEngine_TextCore_Text_TextElement__get_textAsset(uVar4,0,0);
		      if (iVar2 != 0) {
		        uVar4 = GAFInternal_Assets_GAFAnimationAssetInternal__collectExternalData
		                          (*(undefined4 *)(*(int *)(param1 + 0x14) + iVar1 * 4 + 0x10),0);
		        iVar2 = System_Collections_CollectionBase___ctor(uVar4,param2,0);
		        if (iVar2 != 0) {
		          return *(undefined4 *)(*(int *)(param1 + 0x14) + iVar1 * 4 + 0x10);
		        }
		      }
		      iVar1 = iVar1 + 1;
		    } while (iVar1 != iVar3);
		  }
		  return 0;
		}
		*/

		}

		// Token: 0x060077E8 RID: 30696 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60077E8")]
		public T GetAsset<T>(string Name) where T : UnityEngine.Object
		{
			return null;
		}

		// Token: 0x060077E9 RID: 30697 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60077E9")]
		[Address(RVA = "0xC142", Offset = "0xC142", VA = "0xC142")]
		private UnityEngine.Object FindAsset(string Name)
		{
		/* --- GHIDRA: FindAsset ---
		uint I2_Loc_ResourceManager__FindAsset(int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  uint uVar2;
		  
		  if (DAT_ram_00a54e28 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Array_IndexOf_Object___);
		    DAT_ram_00a54e28 = '\x01';
		  }
		  if (*(int *)(param1 + 0x14) == 0) {
		    uVar2 = 0;
		  }
		  else {
		    iVar1 = LunarConsolePlugin_CVar__set_Value
		                      (*(int *)(param1 + 0x14),param2,Method_System_Array_IndexOf_Object___);
		    uVar2 = (uint)(-1 < iVar1);
		  }
		  return uVar2;
		}
		*/

			return null;
		}

		// Token: 0x060077EA RID: 30698 RVA: 0x00016080 File Offset: 0x00014280
		[Token(Token = "0x60077EA")]
		[Address(RVA = "0xC143", Offset = "0xC143", VA = "0xC143")]
		public bool HasAsset(UnityEngine.Object Obj)
		{
		/* --- GHIDRA: HasAsset ---
		void I2_Loc_ResourceManager__HasAsset(int param1,int param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a54e29 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__Object__Clear__);
		    DAT_ram_00a54e29 = '\x01';
		  }
		  System_Xml_XmlWellFormedWriter__PushNamespaceImplicit
		            (*(undefined4 *)(param1 + 0x18),
		             Method_System_Collections_Generic_Dictionary_string__Object__Clear__);
		  if (param2 != 0) {
		    UnityEngine_Resources__GetBuiltinResource(0);
		  }
		  UnityEngine_MonoBehaviour__IsInvoking(param1,0);
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x060077EB RID: 30699 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60077EB")]
		public T LoadFromResources<T>(string Path) where T : UnityEngine.Object
		{
			return null;
		}

		// Token: 0x060077EC RID: 30700 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60077EC")]
		public T LoadFromBundle<T>(string path) where T : UnityEngine.Object
		{
			return null;
		}

		// Token: 0x060077ED RID: 30701 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60077ED")]
		[Address(RVA = "0xC144", Offset = "0xC144", VA = "0xC144")]
		public void CleanResourceCache(bool unloadResources = false)
		{
		/* --- GHIDRA: CleanResourceCache ---
		void I2_Loc_ResourceManager__CleanResourceCache(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a54e2a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__Object___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_string__Object__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_IResourceManager_Bundles___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_List_IResourceManager_Bundles__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_StringComparer_TypeInfo);
		    DAT_ram_00a54e2a = '\x01';
		  }
		  uVar1 = unnamed_function_1417(System_Collections_Generic_List_IResourceManager_Bundles__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (uVar1,Method_System_Collections_Generic_List_IResourceManager_Bundles___ctor__);
		  *(undefined4 *)(param1 + 0x10) = uVar1;
		  if (*(int *)(System_StringComparer_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_StringComparer_TypeInfo);
		  }
		  if (DAT_ram_00a6628f == '\0') {
		    Mono_Security_ASN1__get_Item(&System_StringComparer_TypeInfo);
		    DAT_ram_00a6628f = '\x01';
		  }
		  if (*(int *)(System_StringComparer_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_StringComparer_TypeInfo);
		  }
		  param2_00 = *(undefined4 *)(*(int *)(System_StringComparer_TypeInfo + 0x5c) + 8);
		  uVar1 = unnamed_function_1417(System_Collections_Generic_Dictionary_string__Object__TypeInfo);
		  System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData____ctor
		            (uVar1,param2_00,Method_System_Collections_Generic_Dictionary_string__Object___ctor__);
		  *(undefined4 *)(param1 + 0x18) = uVar1;
		  UnityEngine_RectTransform__GetParentSize(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x060077EE RID: 30702 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60077EE")]
		[Address(RVA = "0xC145", Offset = "0xC145", VA = "0xC145")]
		public ResourceManager()
		{
		}

		// Token: 0x04003EE1 RID: 16097
		[Token(Token = "0x4003EE1")]
		[FieldOffset(Offset = "0x0")]
		private static ResourceManager mInstance;

		// Token: 0x04003EE2 RID: 16098
		[Token(Token = "0x4003EE2")]
		[FieldOffset(Offset = "0x10")]
		public List<IResourceManager_Bundles> mBundleManagers;

		// Token: 0x04003EE3 RID: 16099
		[Token(Token = "0x4003EE3")]
		[FieldOffset(Offset = "0x14")]
		public UnityEngine.Object[] Assets;

		// Token: 0x04003EE4 RID: 16100
		[Token(Token = "0x4003EE4")]
		[FieldOffset(Offset = "0x18")]
		private readonly Dictionary<string, UnityEngine.Object> mResourcesCache;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_pInstance ---
		void I2_Loc_ResourceManager__get_pInstance(undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  int param1_00;
		  
		  if (DAT_ram_00a54e26 == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		    DAT_ram_00a54e26 = '\x01';
		  }
		  param1_00 = I2_Loc_RegisterGlobalParameters___ctor(0);
		  if (DAT_ram_00a54e29 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__Object__Clear__);
		    DAT_ram_00a54e29 = '\x01';
		  }
		  System_Xml_XmlWellFormedWriter__PushNamespaceImplicit
		            (*(undefined4 *)(param1_00 + 0x18),
		             Method_System_Collections_Generic_Dictionary_string__Object__Clear__);
		  UnityEngine_MonoBehaviour__IsInvoking(param1_00,0);
		  if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		  }
		  I2_Loc_LocalizationManager__IsRTL(0);
		  return;
		}
		*/


		/* --- GHIDRA: GetAsset<object> ---
		undefined4 I2_Loc_ResourceManager__GetAsset_object_(int param1,int param2,int param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int iVar5;
		  int iVar6;
		  undefined4 *puVar7;
		  undefined4 uVar8;
		  undefined4 param1_00;
		  undefined4 param5;
		  undefined4 *param2_00;
		  int *piVar9;
		  int iVar10;
		  undefined4 local_4;
		  
		  if (*(int *)(param3 + 0x1c) == 0) {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__Object__TryGetValue__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__Object__set_Item__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_18830);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19094);
		    if (*(int *)(param3 + 0x1c) == 0) {
		      System_ReadOnlySpan_char___GetPinnableReference(param3);
		    }
		  }
		  DAT_ram_009d3e38 = 0;
		  local_4 = 0;
		  iVar2 = func_ii_4769(param2,0);
		  iVar10 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  iVar4 = param2;
		  if (iVar10 == 1) {
		    uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  }
		  else {
		    if (iVar2 != 0) {
		      DAT_ram_009d3e38 = 0;
		      return 0;
		    }
		    DAT_ram_009d3e38 = 0;
		    iVar2 = import::env::invoke_iiiii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x49,
		                       *(undefined4 *)(param1 + 0x18),param2,&local_4,
		                       Method_System_Collections_Generic_Dictionary_string__Object__TryGetValue__);
		    uVar3 = local_4;
		    iVar10 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar10 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    }
		    else if (iVar2 == 0) {
		code_r0x824380ea:
		      DAT_ram_009d3e38 = 0;
		      iVar2 = import::env::invoke_iiiii
		                        (s___Scripting__UnityEngine__Raycas_ram_00004083 + 0xd,param2,
		                         StringLiteral_19094,5,0);
		      iVar10 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar10 == 1) {
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x824386fb;
		      }
		      if (iVar2 != 0) {
		        DAT_ram_009d3e38 = 0;
		        iVar2 = import::env::invoke_iiiii
		                          (s___Scripting__UnityEngine___Scrip_ram_000049d4 + 0xb,param2,
		                           StringLiteral_18830,5,0);
		        iVar10 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar10 == 1) {
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        }
		        else {
		          DAT_ram_009d3e38 = 0;
		          uVar3 = import::env::invoke_iiiii
		                            (s_struct_Uniforms___color__array<v_ram_000013c7 + 0xc1,param2,iVar2 + 1
		                             ,(*(int *)(param2 + 8) - iVar2) + -2,0);
		          iVar10 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar10 == 1) {
		            uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          }
		          else {
		            DAT_ram_009d3e38 = 0;
		            iVar4 = import::env::invoke_iiiii
		                              (s_struct_Uniforms___color__array<v_ram_000013c7 + 0xc1,param2,0,iVar2
		                               ,0);
		            iVar10 = DAT_ram_009d3e38;
		            DAT_ram_009d3e38 = 0;
		            if (iVar10 == 1) {
		              uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		              iVar4 = param2;
		            }
		            else {
		              iVar10 = *(int *)(*(int *)(param3 + 0x1c) + 4);
		              puVar7 = *(undefined4 **)(iVar10 + 0x1c);
		              if (puVar7 == (undefined4 *)0x0) {
		                DAT_ram_009d3e38 = 0;
		                import::env::invoke_ii(s_struct_Uniforms___color__vec4<f3_ram_00000856 + 6,iVar10);
		                if (DAT_ram_009d3e38 != 1) {
		                  puVar7 = *(undefined4 **)(iVar10 + 0x1c);
		                  goto code_r0x82438235;
		                }
		              }
		              else {
		code_r0x82438235:
		                uVar8 = *puVar7;
		                if (*(int *)(DAT_ram_00a669a0 + 0x74) == 0) {
		                  DAT_ram_009d3e38 = 0;
		                  import::env::invoke_vi
		                            (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                             DAT_ram_00a669a0);
		                  if (DAT_ram_009d3e38 == 1) goto code_r0x824386c7;
		                }
		                DAT_ram_009d3e38 = 0;
		                uVar8 = import::env::invoke_iii
		                                  (s_struct_Uniforms___color__vec4<f3_ram_00000856 + 0x259,uVar8,0);
		                if (DAT_ram_009d3e38 != 1) {
		                  DAT_ram_009d3e38 = 0;
		                  uVar8 = import::env::invoke_iiii
		                                    (s___Scripting__UnityEngine___Scrip_ram_000049d4 + 0xc,iVar4,
		                                     uVar8,0);
		                  if (DAT_ram_009d3e38 != 1) {
		                    iVar2 = 0;
		                    DAT_ram_009d3e38 = 0;
		                    iVar10 = import::env::invoke_iii
		                                       (s___Scripting__UnityEngine___Scrip_ram_000049d4 + 0xd,uVar8,
		                                        *(undefined4 *)(*(int *)(iVar10 + 0x1c) + 4));
		                    if (DAT_ram_009d3e38 != 1) {
		                      iVar6 = *(int *)(iVar10 + 0xc);
		                      param2 = iVar4;
		                      if (0 < iVar6) {
		                        do {
		                          piVar9 = (int *)(iVar10 + iVar2 * 4 + 0x10);
		                          DAT_ram_009d3e38 = 0;
		                          uVar8 = import::env::invoke_iii
		                                            (s_struct_Uniforms___color__array<v_ram_00000aff + 0x215
		                                             ,*piVar9,0);
		                          iVar1 = DAT_ram_009d3e38;
		                          DAT_ram_009d3e38 = 0;
		                          if (iVar1 == 1) {
		                            uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                            goto code_r0x824386fb;
		                          }
		                          DAT_ram_009d3e38 = 0;
		                          iVar5 = func_ii_2066(uVar8,uVar3,0);
		                          iVar1 = DAT_ram_009d3e38;
		                          DAT_ram_009d3e38 = 0;
		                          if (iVar1 == 1) {
		                            uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                            goto code_r0x824386fb;
		                          }
		                          if (iVar5 != 0) {
		                            iVar2 = *piVar9;
		                            goto code_r0x824384f7;
		                          }
		                          iVar2 = iVar2 + 1;
		                        } while (iVar2 != iVar6);
		                        iVar2 = 0;
		                      }
		                      goto code_r0x824384f7;
		                    }
		                  }
		                }
		              }
		code_r0x824386c7:
		              DAT_ram_009d3e38 = 0;
		              uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            }
		          }
		        }
		        goto code_r0x824386fb;
		      }
		      uVar3 = *(undefined4 *)(*(int *)(param3 + 0x1c) + 0xc);
		      if (*(int *)(DAT_ram_00a669a0 + 0x74) == 0) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vi
		                  (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,DAT_ram_00a669a0);
		        iVar10 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar10 == 1) {
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x824386fb;
		        }
		      }
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::invoke_iii
		                        (s_struct_Uniforms___color__vec4<f3_ram_00000856 + 0x259,uVar3,0);
		      iVar10 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar10 == 1) {
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x824386fb;
		      }
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::invoke_iiii
		                        (s___Scripting__UnityEngine___Scrip_ram_000049d4 + 0xe,param2,uVar3,0);
		      if (DAT_ram_009d3e38 != 1) {
		        iVar10 = **(int **)(param3 + 0x1c);
		        if ((*(byte *)(iVar10 + 0xbd) & 1) == 0) {
		          DAT_ram_009d3e38 = 0;
		          iVar10 = import::env::invoke_ii
		                             (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x17,iVar10);
		          if (DAT_ram_009d3e38 == 1) goto code_r0x82438601;
		        }
		        DAT_ram_009d3e38 = 0;
		        iVar2 = import::env::invoke_iii
		                          (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1a,uVar3,iVar10);
		        if (DAT_ram_009d3e38 != 1) {
		code_r0x824384f7:
		          iVar4 = param2;
		          if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_vi
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                       UnityEngine_Object_TypeInfo);
		            iVar10 = DAT_ram_009d3e38;
		            DAT_ram_009d3e38 = 0;
		            if (iVar10 == 1) {
		              uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		              goto code_r0x824386fb;
		            }
		          }
		          DAT_ram_009d3e38 = 0;
		          iVar6 = import::env::invoke_iiii
		                            (s_struct_Uniforms___color__array<v_ram_00000aff + 0x3e6,iVar2,0,0);
		          iVar10 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar10 == 1) {
		            uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          }
		          else {
		            if (iVar6 != 0) {
		              DAT_ram_009d3e38 = 0;
		              iVar2 = import::env::invoke_iiii
		                                (s___Scripting__UnityEngine___Scrip_ram_000049d4 + 0xf,param1,param2
		                                 ,*(undefined4 *)(*(int *)(param3 + 0x1c) + 0x10));
		              iVar10 = DAT_ram_009d3e38;
		              DAT_ram_009d3e38 = 0;
		              if (iVar10 == 1) {
		                uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                goto code_r0x824386fb;
		              }
		            }
		            if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		              DAT_ram_009d3e38 = 0;
		              import::env::invoke_vi
		                        (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                         UnityEngine_Object_TypeInfo);
		              iVar10 = DAT_ram_009d3e38;
		              DAT_ram_009d3e38 = 0;
		              if (iVar10 == 1) {
		                uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                goto code_r0x824386fb;
		              }
		            }
		            DAT_ram_009d3e38 = 0;
		            iVar6 = import::env::invoke_iiii
		                              (s_struct_Uniforms___color__array<v_ram_00000aff + 0x3b7,iVar2,0,0);
		            iVar10 = DAT_ram_009d3e38;
		            DAT_ram_009d3e38 = 0;
		            if (iVar10 == 1) {
		              uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            }
		            else {
		              if (iVar6 == 0) {
		                DAT_ram_009d3e38 = 0;
		                return iVar2;
		              }
		              DAT_ram_009d3e38 = 0;
		              import::env::invoke_viiii
		                        (s_struct_Uniforms___color__array<v_ram_00000aff + 0x84,
		                         *(undefined4 *)(param1 + 0x18),param2,iVar2,
		                         Method_System_Collections_Generic_Dictionary_string__Object__set_Item__);
		              iVar10 = DAT_ram_009d3e38;
		              DAT_ram_009d3e38 = 0;
		              if (iVar10 != 1) {
		                DAT_ram_009d3e38 = 0;
		                return iVar2;
		              }
		              uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            }
		          }
		          goto code_r0x824386fb;
		        }
		      }
		code_r0x82438601:
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    }
		    else {
		      if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vi
		                  (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                   UnityEngine_Object_TypeInfo);
		        iVar10 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar10 == 1) {
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x824386fb;
		        }
		      }
		      DAT_ram_009d3e38 = 0;
		      iVar2 = import::env::invoke_iiii
		                        (s_struct_Uniforms___color__array<v_ram_00000aff + 0x3b7,uVar3,0,0);
		      uVar3 = local_4;
		      iVar10 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar10 == 1) {
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x824386fb;
		      }
		      if (iVar2 == 0) goto code_r0x824380ea;
		      iVar10 = **(int **)(param3 + 0x1c);
		      if ((*(byte *)(iVar10 + 0xbd) & 1) == 0) {
		        DAT_ram_009d3e38 = 0;
		        iVar10 = import::env::invoke_ii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x17,iVar10);
		        if (DAT_ram_009d3e38 != 1) goto code_r0x8243809b;
		      }
		      else {
		code_r0x8243809b:
		        DAT_ram_009d3e38 = 0;
		        uVar3 = import::env::invoke_iii
		                          (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1a,uVar3,iVar10);
		        if (DAT_ram_009d3e38 != 1) {
		          DAT_ram_009d3e38 = 0;
		          return uVar3;
		        }
		      }
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    }
		  }
		code_r0x824386fb:
		  iVar10 = global_1;
		  iVar2 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar2 == iVar10) {
		    puVar7 = (undefined4 *)import::env::__cxa_begin_catch(uVar3);
		    DAT_ram_009d3e38 = 0;
		    uVar3 = import::env::invoke_ii
		                      (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1c,
		                       &System_Exception_TypeInfo);
		    if (DAT_ram_009d3e38 != 1) {
		      DAT_ram_009d3e38 = 0;
		      iVar2 = import::env::invoke_iii
		                        (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1d,uVar3,
		                         *(undefined4 *)*puVar7);
		      iVar10 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar10 != 1) {
		        if (iVar2 != 0) {
		          piVar9 = (int *)*puVar7;
		          import::env::__cxa_end_catch();
		          uVar3 = *(undefined4 *)(*(int *)(param3 + 0x1c) + 0xc);
		          if (*(int *)(DAT_ram_00a669a0 + 0x74) == 0) {
		            func_ii_306000(DAT_ram_00a669a0);
		          }
		          uVar3 = func_ii_2734(uVar3,0);
		          iVar10 = *piVar9;
		          uVar8 = (**(code **)((ulonglong)*(uint *)(iVar10 + 0xd8) * 4))
		                            (piVar9,*(undefined4 *)(iVar10 + 0xdc));
		          iVar10 = unnamed_function_2232(&OKG_Logs_Debug_TypeInfo);
		          if (*(int *)(iVar10 + 0x74) == 0) {
		            func_ii_306000(iVar10);
		          }
		          param1_00 = unnamed_function_2232(&StringLiteral_16966);
		          param5 = unnamed_function_2232
		                             (&Method_OKG_Logs_Debug_LogErrorFormat_Type__string__string___);
		          OKG_Logs_Debug__LogErrorFormat___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType_
		                    (param1_00,uVar3,iVar4,uVar8,param5);
		          return 0;
		        }
		        param2_00 = (undefined4 *)unnamed_function_951(4);
		        *param2_00 = *puVar7;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1e,param2_00,
		                   &DAT_ram_0072c9c8,0);
		        if (DAT_ram_009d3e38 != 1) goto code_r0x82438882;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar3 = import::env::__cxa_find_matching_catch_2();
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar10 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar10 == 1) {
		      import::env::__cxa_find_matching_catch_3(0);
		      unnamed_function_937();
		code_r0x82438882:
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  import::env::__resumeException(uVar3);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: LoadFromResources<object> ---
		undefined4 I2_Loc_ResourceManager__LoadFromResources_object_(int param1)
		
		{
		  undefined4 *puVar1;
		  undefined4 uVar2;
		  
		  puVar1 = *(undefined4 **)(param1 + 0x1c);
		  if (puVar1 == (undefined4 *)0x0) {
		    System_ReadOnlySpan_char___GetPinnableReference(param1);
		    puVar1 = *(undefined4 **)(param1 + 0x1c);
		  }
		  uVar2 = *puVar1;
		  if (*(int *)(DAT_ram_00a669a0 + 0x74) == 0) {
		    func_ii_306000(DAT_ram_00a669a0);
		  }
		  uVar2 = func_ii_2734(uVar2,0);
		  uVar2 = UnityEngine_ResourcesAPI___cctor(uVar2,0);
		  uVar2 = UnityEngine_Resources__LoadAll(uVar2,*(undefined4 *)(*(int *)(param1 + 0x1c) + 4));
		  return uVar2;
		}
		*/

}
