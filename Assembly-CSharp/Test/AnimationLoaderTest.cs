using System;
using Core.Animations;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Test
{
	// Token: 0x02000E43 RID: 3651
	[Token(Token = "0x2000E43")]
	public class AnimationLoaderTest : MonoBehaviour
	{
		// Token: 0x06005980 RID: 22912 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005980")]
		[Address(RVA = "0xA6AC", Offset = "0xA6AC", VA = "0xA6AC")]
		public AnimationLoaderTest()
		{
		/* --- GHIDRA: .ctor ---
		void Test_AnimationLoaderTest___ctor
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a63c1c == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Test_AnimationLoaderTest_CompleteCallback__);
		    Mono_Security_ASN1__get_Item(&Method_Test_AnimationLoaderTest_FailCallback__);
		    Mono_Security_ASN1__get_Item
		              (&Core_GameResources_GameResourcesManager_AnimationReadyDelegate_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameResources_GameResourcesManager_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Core_GameResources_GameResourcesManager_ResourceFailedDelegate_TypeInfo);
		    DAT_ram_00a63c1c = '\x01';
		  }
		  *(undefined4 *)(param1 + 0x1c) = param4;
		  *(undefined4 *)(param1 + 0x18) = param3;
		  *(undefined4 *)(param1 + 0x10) = param2;
		  param1_00 = unnamed_function_1417
		                        (Core_GameResources_GameResourcesManager_AnimationReadyDelegate_TypeInfo);
		  Core_GameResources_GameResourcesManager_AudioClipReadyDelegate__EndInvoke
		            (param1_00,param1,Method_Test_AnimationLoaderTest_CompleteCallback__,0);
		  param1_01 = unnamed_function_1417
		                        (Core_GameResources_GameResourcesManager_ResourceFailedDelegate_TypeInfo);
		  Core_GameResources_GameResourcesManager_SpriteAtlasReadyDelegate___ctor
		            (param1_01,param1,Method_Test_AnimationLoaderTest_FailCallback__,0);
		  if (*(int *)(Core_GameResources_GameResourcesManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameResources_GameResourcesManager_TypeInfo);
		  }
		  Core_GameResources_GameResourcesManager__ReleaseTextMeshProSpriteAsset
		            (param2,param1_00,param1_01,1,0);
		  return;
		}
		*/

		}

		// Token: 0x06005981 RID: 22913 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005981")]
		[Address(RVA = "0xA6AD", Offset = "0xA6AD", VA = "0xA6AD")]
		public void LoadAnimation(string url, Transform worldAnimationsContainer, Transform canvasAnimationsContainer)
		{
		/* --- GHIDRA: LoadAnimation ---
		void Test_AnimationLoaderTest__LoadAnimation(int param1,undefined4 param2,undefined4 param3)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a63c1d == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Lazy_Text__get_Value__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3120);
		    DAT_ram_00a63c1d = '\x01';
		  }
		  param1_00 = (int *)Core_Analytics_Okg_OkgAnalytics__DoSendLog
		                               (*(undefined4 *)(param1 + 0x28),Method_System_Lazy_Text__get_Value__)
		  ;
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar1 = UnityEngine_Component__GetComponent_object_(param1_00,0);
		  param1_01 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(StringLiteral_3120,param2,0);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(*param1_00 + 0x318) * 4))
		              (param1_00,param1_01,*(undefined4 *)(*param1_00 + 0x31c));
		    return;
		  }
		  if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		    func_ii_306000(OKG_Logs_Debug_TypeInfo);
		  }
		  func_ii_7109(param1_01,0);
		  return;
		}
		*/

		}

		// Token: 0x06005982 RID: 22914 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005982")]
		[Address(RVA = "0xA6AE", Offset = "0xA6AE", VA = "0xA6AE")]
		private void FailCallback(string resourceUrl)
		{
		/* --- GHIDRA: FailCallback ---
		uint Test_AnimationLoaderTest__FailCallback(undefined4 param1,undefined4 param2)
		
		{
		  int param1_00;
		  int iVar1;
		  uint uVar2;
		  
		  if (DAT_ram_00a63c1e == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_FindObjectOfType_AnimationTest___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a63c1e = '\x01';
		  }
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  param1_00 = UnityEngine_Object__FindFirstObjectByType_object_
		                        (Method_UnityEngine_Object_FindObjectOfType_AnimationTest___);
		  iVar1 = UnityEngine_Component__GetComponent_object_(param1_00,0);
		  if (iVar1 == 0) {
		    uVar2 = 0;
		  }
		  else {
		    uVar2 = (uint)(*(char *)(*(int *)(param1_00 + 0x28) + 0xc4) != '\0');
		  }
		  return uVar2;
		}
		*/

		}

		// Token: 0x17001241 RID: 4673
		// (get) Token: 0x06005983 RID: 22915 RVA: 0x0000FE28 File Offset: 0x0000E028
		[Token(Token = "0x17001241")]
		private bool IsPan
		{
			[Token(Token = "0x6005983")]
			[Address(RVA = "0xA6AF", Offset = "0xA6AF", VA = "0xA6AF")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06005984 RID: 22916 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005984")]
		[Address(RVA = "0xA6B0", Offset = "0xA6B0", VA = "0xA6B0")]
		private void CompleteCallback(IGameAnimation iGameAnimation, string resourceUrl)
		{
		/* --- GHIDRA: CompleteCallback ---
		void Test_AnimationLoaderTest__CompleteCallback(int param1,undefined4 param2)
		
		{
		  float4 fVar1;
		  float4 fVar2;
		  float4 fVar3;
		  float4 fVar4;
		  float4 fVar5;
		  float4 fVar6;
		  float4 fVar7;
		  float4 fVar8;
		  float4 fVar9;
		  float4 fVar10;
		  float4 fVar11;
		  undefined4 uVar12;
		  undefined4 *puVar13;
		  undefined4 param4;
		  undefined4 uVar14;
		  int iVar15;
		  float4 *pfVar16;
		  uint *puVar17;
		  float fVar18;
		  int iVar19;
		  int *piVar20;
		  float4 fVar21;
		  float fVar22;
		  float fVar23;
		  float fVar24;
		  uint uVar25;
		  int iVar26;
		  int iVar27;
		  uint uVar28;
		  int *piVar29;
		  float fVar30;
		  float fVar31;
		  float fVar32;
		  float fVar33;
		  float fVar34;
		  float fVar35;
		  float fVar36;
		  float fVar37;
		  undefined8 local_70;
		  undefined4 local_68;
		  undefined8 local_60;
		  float local_58;
		  float4 local_50;
		  float4 local_4c;
		  undefined4 local_48;
		  float4 local_44;
		  float4 local_40;
		  float4 local_3c;
		  float4 local_38;
		  float4 local_34;
		  float4 local_30;
		  float4 local_2c;
		  float4 local_28;
		  undefined8 local_20;
		  undefined4 local_18;
		  undefined4 uStack_14;
		  uint local_10;
		  undefined4 uStack_c;
		  undefined4 local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a63c20 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponentInParent_Canvas___);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_GameObject__bool__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_GameObject__bool__Clear__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_GameObject__bool__GetEnumerator__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_GameObject__bool___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_GameObject__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_Enumerator_GameObject__bool__Dispose__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_Enumerator_GameObject__bool__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_Enumerator_GameObject__bool__get_Current__
		              );
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_GameObject__bool__get_Key__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_GameObject__bool__get_Value__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_RectTransformUtility_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_RectTransform_TypeInfo);
		    Mono_Security_ASN1__get_Item(&float___TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Transform_TypeInfo);
		    DAT_ram_00a63c20 = '\x01';
		  }
		  local_4 = (int *)0x0;
		  local_8 = 0;
		  local_10 = 0;
		  uStack_c = 0;
		  local_18 = 0;
		  uStack_14 = 0;
		  local_20 = 0;
		  uVar12 = UnityEngine_UI_Selectable__set_interactable(*(undefined4 *)(param1 + 0x20),0);
		  if (*(int *)(UnityEngine_RectTransformUtility_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_RectTransformUtility_TypeInfo);
		  }
		  UnityEngine_RectTransformUtility__CalculateRelativeRectTransformBounds(&local_38,uVar12,0);
		  fVar11 = local_28;
		  fVar10 = local_2c;
		  fVar5 = local_34;
		  fVar1 = local_38;
		  uVar12 = unnamed_function_1417(System_Collections_Generic_Dictionary_GameObject__bool__TypeInfo);
		  System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		            (uVar12,Method_System_Collections_Generic_Dictionary_GameObject__bool___ctor__);
		  local_4 = (int *)UnityEngine_Transform__set_hasChanged(*(undefined4 *)(param1 + 0x1c),0);
		  local_30 = (float4)&local_8;
		  local_38 = 0.0;
		  local_34 = (float4)&local_4;
		  do {
		    piVar20 = local_4;
		    iVar19 = *local_4;
		    if (*(ushort *)(iVar19 + 0xb6) != 0) {
		      uVar25 = 0;
		      do {
		        piVar29 = (int *)(*(int *)(iVar19 + 0x58) + uVar25 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar29) {
		          puVar13 = (undefined4 *)(iVar19 + piVar29[1] * 8 + 0xc0);
		          goto code_r0x8236e9d5;
		        }
		        uVar25 = uVar25 + 1;
		      } while (*(ushort *)(iVar19 + 0xb6) != uVar25);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar13 = (undefined4 *)
		              import::env::invoke_iiii
		                        (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                         System_Collections_IEnumerator_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x8236ec5a:
		      DAT_ram_009d3e38 = 0;
		      uVar14 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x8236ec62;
		    }
		code_r0x8236e9d5:
		    DAT_ram_009d3e38 = 0;
		    iVar19 = import::env::invoke_iii(*puVar13,piVar20,puVar13[1]);
		    piVar20 = local_4;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x8236ec5a;
		    if (iVar19 == 0) goto code_r0x8236ecab;
		    iVar19 = *local_4;
		    if (*(ushort *)(iVar19 + 0xb6) != 0) {
		      uVar25 = 0;
		      do {
		        piVar29 = (int *)(*(int *)(iVar19 + 0x58) + uVar25 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar29) {
		          puVar13 = (undefined4 *)(piVar29[1] * 8 + iVar19 + 200);
		          goto code_r0x8236eab2;
		        }
		        uVar25 = uVar25 + 1;
		      } while (*(ushort *)(iVar19 + 0xb6) != uVar25);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar13 = (undefined4 *)
		              import::env::invoke_iiii
		                        (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                         System_Collections_IEnumerator_TypeInfo,1);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x8236ec28:
		      DAT_ram_009d3e38 = 0;
		      uVar14 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x8236ec62;
		    }
		code_r0x8236eab2:
		    DAT_ram_009d3e38 = 0;
		    piVar20 = (int *)import::env::invoke_iii(*puVar13,piVar20,puVar13[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x8236ec28;
		    if (piVar20 != (int *)0x0) {
		      if (((uint)*(byte *)(*piVar20 + 0xb8) < (uint)*(byte *)(UnityEngine_Transform_TypeInfo + 0xb8)
		          ) || (*(int *)(*(int *)(*piVar20 + 100) +
		                         (uint)*(byte *)(UnityEngine_Transform_TypeInfo + 0xb8) * 4 + -4) !=
		                UnityEngine_Transform_TypeInfo)) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vii
		                  (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x183,piVar20,
		                   UnityEngine_Transform_TypeInfo);
		        iVar19 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar19 != 1) {
		          do {
		            halt_trap();
		          } while( true );
		        }
		        uVar14 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x8236ec62;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar14 = import::env::invoke_iii
		                       (s_struct_Uniforms___color__array<v_ram_00000aff + 0x25c,piVar20,0);
		    iVar19 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar19 == 1) {
		      uVar14 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x8236ec62;
		    }
		    DAT_ram_009d3e38 = 0;
		    param4 = import::env::invoke_iii
		                       (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x103,uVar14,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x8236ec46:
		      DAT_ram_009d3e38 = 0;
		      uVar14 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x8236ec62;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viiii
		              (s___Scripting__Unity__Profiling__L_ram_0000315f + 0x1e,uVar12,uVar14,param4,
		               Method_System_Collections_Generic_Dictionary_GameObject__bool__Add__);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x8236ec46;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii(s_struct_Uniforms___color__array<v_ram_000013c7 + 0x26d,uVar14,0,0);
		    iVar19 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar19 != 1);
		  uVar14 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x8236ec62:
		  iVar19 = global_1;
		  iVar15 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar19 == iVar15) {
		    pfVar16 = (float4 *)import::env::__cxa_begin_catch(uVar14);
		    local_38 = *pfVar16;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar19 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar19 != 1) {
		code_r0x8236ecab:
		      DAT_ram_009d3e38 = 0;
		      local_8 = func_ii_1082(local_4,System_IDisposable_TypeInfo);
		      piVar20 = *(int **)local_30;
		      if (piVar20 != (int *)0x0) {
		        iVar19 = *piVar20;
		        if (*(ushort *)(iVar19 + 0xb6) != 0) {
		          uVar25 = 0;
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar19 + 0x58) + uVar25 * 8)) {
		              puVar17 = (uint *)(iVar19 + *(int *)(*(int *)(iVar19 + 0x58) + uVar25 * 8 + 4) * 8 +
		                                0xc0);
		              goto code_r0x8236ed3b;
		            }
		            uVar25 = uVar25 + 1;
		          } while (*(ushort *)(iVar19 + 0xb6) != uVar25);
		        }
		        puVar17 = (uint *)func_ii_1080(piVar20,System_IDisposable_TypeInfo,0);
		code_r0x8236ed3b:
		        (**(code **)((ulonglong)*puVar17 * 4))(piVar20,puVar17[1]);
		      }
		      if (local_38 != 0.0) {
		        System_Data_DataSet__ValidateLocaleConstraint(local_38);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      uVar14 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                         (*(undefined4 *)(param1 + 0x1c),0);
		      if (*(int *)(UnityEngine_RectTransformUtility_TypeInfo + 0x74) == 0) {
		        func_ii_306000(UnityEngine_RectTransformUtility_TypeInfo);
		      }
		      UnityEngine_RectTransformUtility__CalculateRelativeRectTransformBounds(&local_38,uVar14,0);
		      fVar6 = local_34;
		      fVar2 = local_38;
		      System_Collections_Generic_List_object___GetEnumerator
		                (&local_20,uVar12,
		                 Method_System_Collections_Generic_Dictionary_GameObject__bool__GetEnumerator__);
		      local_38 = 0.0;
		      local_34 = (float4)&local_20;
		      do {
		        DAT_ram_009d3e38 = 0;
		        iVar15 = import::env::invoke_iii
		                           (s___Scripting__UnityEngine__Render_ram_00004866 + 0x2d,&local_20,
		                            Method_System_Collections_Generic_Dictionary_Enumerator_GameObject__bool__MoveNext__
		                           );
		        iVar19 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar19 == 1) {
		          uVar14 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x8236eeaf;
		        }
		        if (iVar15 == 0) goto code_r0x8236ef05;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_struct_Uniforms___color__array<v_ram_000013c7 + 0x26d,uStack_14,
		                   (uint)((local_10 & 0xff) != 0),0);
		        iVar19 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		      } while (iVar19 != 1);
		      uVar14 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x8236eeaf:
		      iVar19 = global_1;
		      iVar15 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar19 == iVar15) {
		        pfVar16 = (float4 *)import::env::__cxa_begin_catch(uVar14);
		        fVar21 = *pfVar16;
		        DAT_ram_009d3e38 = 0;
		        local_38 = fVar21;
		        import::env::invoke_v(0x123);
		        iVar19 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar19 != 1) {
		          if (fVar21 != 0.0) {
		            System_Data_DataSet__ValidateLocaleConstraint(fVar21);
		            do {
		              halt_trap();
		            } while( true );
		          }
		code_r0x8236ef05:
		          DAT_ram_009d3e38 = 0;
		          System_Xml_XmlWellFormedWriter__PushNamespaceImplicit
		                    (uVar12,Method_System_Collections_Generic_Dictionary_GameObject__bool__Clear__);
		          uVar12 = UnityEngine_Component__GetComponentInChildren___Il2CppFullySharedGenericType_
		                             (*(undefined4 *)(param1 + 0x1c),
		                              Method_UnityEngine_Component_GetComponentInParent_Canvas___);
		          fVar18 = UnityEngine_Canvas__get_pixelRect(uVar12,0);
		          uVar12 = UnityEngine_UI_Selectable__set_interactable(*(undefined4 *)(param1 + 0x20),0);
		          func_ii_7888(&local_38,uVar12,0);
		          fVar7 = local_34;
		          fVar21 = local_38;
		          uVar12 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                             (*(undefined4 *)(param1 + 0x1c),0);
		          func_ii_7888(&local_38,uVar12,0);
		          fVar8 = local_34;
		          fVar3 = local_38;
		          piVar20 = (int *)UnityEngine_UI_Selectable__set_interactable
		                                     (*(undefined4 *)(param1 + 0x20),0);
		          if ((piVar20 != (int *)0x0) && (UnityEngine_RectTransform_TypeInfo != *piVar20)) {
		            System_Activator__CreateInstance(piVar20,UnityEngine_RectTransform_TypeInfo);
		            do {
		              halt_trap();
		            } while( true );
		          }
		          UnityEngine_RectTransform__set_sizeDelta(&local_38,piVar20,0);
		          fVar9 = local_34;
		          fVar4 = local_38;
		          fVar22 = ((float)fVar6 - (float)local_28) * fVar18 + (float)fVar8;
		          fVar30 = (((float)fVar6 + (float)local_28) * fVar18 + (float)fVar8) - fVar22;
		          fVar36 = ((float)fVar5 - (float)fVar11) + (float)fVar7;
		          fVar31 = ((float)fVar5 + (float)fVar11 + (float)fVar7) - fVar36;
		          fVar32 = fVar31 * 0.5;
		          fVar23 = (fVar22 + fVar30 * 0.5) - fVar32;
		          fVar24 = ((float)fVar2 - (float)local_2c) * fVar18 + (float)fVar3;
		          fVar33 = (((float)fVar2 + (float)local_2c) * fVar18 + (float)fVar3) - fVar24;
		          fVar37 = ((float)fVar1 - (float)fVar10) + (float)fVar21;
		          fVar34 = ((float)fVar1 + (float)fVar10 + (float)fVar21) - fVar37;
		          fVar35 = fVar34 * 0.5;
		          fVar18 = (fVar24 + fVar33 * 0.5) - fVar35;
		          if (((((fVar18 < fVar24) || (fVar24 + fVar33 <= fVar18)) || (fVar23 < fVar22)) ||
		              ((fVar22 + fVar30 <= fVar23 || (fVar34 + fVar18 < fVar24)))) ||
		             ((fVar24 + fVar33 <= fVar34 + fVar18 ||
		              ((fVar31 + fVar23 < fVar22 || (fVar24 = 1.0, fVar22 + fVar30 <= fVar31 + fVar23))))))
		          {
		            iVar19 = Mono_Security_ASN1Convert__ToOid(float___TypeInfo,3);
		            *(float *)(iVar19 + 0x18) = fVar30 / fVar31;
		            *(float *)(iVar19 + 0x14) = fVar33 / fVar34;
		            *(undefined4 *)(iVar19 + 0x10) = 0x3f800000;
		            iVar15 = *(int *)(iVar19 + 0xc);
		            if (iVar15 == 0) {
		              fVar24 = 0.0;
		            }
		            else {
		              fVar24 = 1.0;
		              if (1 < iVar15) {
		                uVar25 = iVar15 - 1U & 3;
		                if (iVar15 - 2U < 3) {
		                  iVar27 = 1;
		                }
		                else {
		                  uVar28 = 0;
		                  iVar27 = 1;
		                  do {
		                    iVar26 = iVar19 + iVar27 * 4;
		                    fVar22 = *(float *)(iVar26 + 0x10);
		                    if (fVar24 <= *(float *)(iVar26 + 0x10)) {
		                      fVar22 = fVar24;
		                    }
		                    fVar24 = *(float *)(iVar26 + 0x14);
		                    if (fVar22 <= *(float *)(iVar26 + 0x14)) {
		                      fVar24 = fVar22;
		                    }
		                    fVar22 = *(float *)(iVar26 + 0x18);
		                    if (fVar24 <= *(float *)(iVar26 + 0x18)) {
		                      fVar22 = fVar24;
		                    }
		                    fVar24 = *(float *)(iVar26 + 0x1c);
		                    if (fVar22 <= *(float *)(iVar26 + 0x1c)) {
		                      fVar24 = fVar22;
		                    }
		                    iVar27 = iVar27 + 4;
		                    uVar28 = uVar28 + 4;
		                  } while (uVar28 != (iVar15 - 1U & 0xfffffffc));
		                }
		                if (uVar25 != 0) {
		                  uVar28 = 0;
		                  do {
		                    fVar22 = *(float *)(iVar19 + iVar27 * 4 + 0x10);
		                    if (fVar24 <= fVar22) {
		                      fVar22 = fVar24;
		                    }
		                    fVar24 = fVar22;
		                    iVar27 = iVar27 + 1;
		                    uVar28 = uVar28 + 1;
		                  } while (uVar28 != uVar25);
		                }
		              }
		            }
		          }
		          uVar12 = UnityEngine_UI_Selectable__set_interactable(*(undefined4 *)(param1 + 0x20),0);
		          func_ii_20513(&local_38,uVar12,0);
		          fVar10 = local_30;
		          fVar5 = local_34;
		          fVar1 = local_38;
		          uVar12 = UnityEngine_UI_Selectable__set_interactable(*(undefined4 *)(param1 + 0x20),0);
		          local_58 = fVar24 * (float)fVar10;
		          local_40 = (float4)(fVar24 * (float)fVar5);
		          local_44 = (float4)(fVar24 * (float)fVar1);
		          local_60 = CONCAT44(local_40,local_44);
		          local_3c = (float4)local_58;
		          Com_TheFallenGames_OSA_Core_OSA_object__object___SetNormalizedPosition(uVar12,&local_60,0)
		          ;
		          uVar12 = UnityEngine_UI_Selectable__set_interactable(*(undefined4 *)(param1 + 0x20),0);
		          local_48 = 0;
		          local_68 = 0;
		          local_4c = (float4)(fVar32 + fVar23 +
		                             ((fVar36 + fVar31 * (float)fVar9) - (fVar36 + fVar32)) * fVar24);
		          local_50 = (float4)(fVar35 + fVar18 +
		                             ((fVar37 + fVar34 * (float)fVar4) - (fVar37 + fVar35)) * fVar24);
		          local_70 = CONCAT44(local_4c,local_50);
		          UnityEngine_Transform__get_position(uVar12,&local_70,0);
		          return;
		        }
		        uVar14 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s___Scripting__UnityEngine__Render_ram_00004866 + 0x2e,&local_38);
		      goto joined_r0x8236f106;
		    }
		    uVar14 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s___Scripting__UnityEngine__Render_ram_00004866 + 0x2c,&local_38);
		joined_r0x8236f106:
		  if (DAT_ram_009d3e38 == 1) {
		    DAT_ram_009d3e38 = 0;
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::__resumeException(uVar14);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06005985 RID: 22917 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005985")]
		[Address(RVA = "0xA6B1", Offset = "0xA6B1", VA = "0xA6B1")]
		private void AdjustCanvasAnimation()
		{
		/* --- GHIDRA: AdjustCanvasAnimation ---
		void Test_AnimationLoaderTest__AdjustCanvasAnimation(int param1,undefined4 param2)
		
		{
		  float4 fVar1;
		  float4 fVar2;
		  float4 fVar3;
		  float4 fVar4;
		  float4 fVar5;
		  float4 fVar6;
		  float4 fVar7;
		  float4 fVar8;
		  float4 fVar9;
		  float4 fVar10;
		  undefined4 param1_00;
		  undefined4 uVar11;
		  int iVar12;
		  float fVar13;
		  float fVar14;
		  float fVar15;
		  int iVar16;
		  uint uVar17;
		  int iVar18;
		  int iVar19;
		  uint uVar20;
		  float fVar21;
		  float fVar22;
		  float fVar23;
		  float fVar24;
		  float fVar25;
		  float fVar26;
		  float fVar27;
		  float fVar28;
		  float fVar29;
		  float fVar30;
		  float fVar31;
		  undefined8 local_a0;
		  float4 local_98;
		  undefined8 local_90;
		  float local_88;
		  undefined8 local_80;
		  float local_78;
		  undefined8 local_70;
		  float local_68;
		  undefined8 local_60;
		  float local_58;
		  float4 local_54;
		  float4 local_50;
		  float4 local_4c;
		  undefined8 local_48;
		  float4 local_40;
		  undefined8 local_3c;
		  float4 local_34;
		  float4 local_30;
		  float4 local_2c;
		  float4 local_28;
		  float4 local_24;
		  float4 local_20;
		  float4 local_1c;
		  float4 local_18;
		  float4 local_14;
		  float4 local_10;
		  float4 local_c;
		  float4 local_8;
		  
		  uVar20 = 0;
		  if (DAT_ram_00a63c21 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponentInParent_Canvas___);
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_GameObject_GetComponentInChildren_MeshFilter___);
		    Mono_Security_ASN1__get_Item(&Method_System_Lazy_Camera__get_Value__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_RectTransformUtility_TypeInfo);
		    Mono_Security_ASN1__get_Item(&float___TypeInfo);
		    DAT_ram_00a63c21 = '\x01';
		  }
		  param1_00 = Core_Analytics_Okg_OkgAnalytics__DoSendLog
		                        (*(undefined4 *)(param1 + 0x24),Method_System_Lazy_Camera__get_Value__);
		  uVar11 = UnityEngine_GameObject__GetComponent___Il2CppFullySharedGenericType_
		                     (*(undefined4 *)(param1 + 0x20),
		                      Method_UnityEngine_GameObject_GetComponentInChildren_MeshFilter___);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar12 = UnityEngine_Component__GetComponent_object_(param1_00,0);
		  if (iVar12 != 0) {
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UnityEngine_Object_TypeInfo);
		    }
		    iVar12 = UnityEngine_Component__GetComponent_object_(uVar11,0);
		    if (iVar12 != 0) {
		      uVar11 = UnityEngine_MeshFilter__get_sharedMesh(uVar11,0);
		      UnityEngine_Mesh__set_subMeshCount(&local_18,uVar11,0);
		      fVar10 = local_8;
		      fVar9 = local_c;
		      fVar5 = local_14;
		      fVar1 = local_18;
		      uVar11 = UnityEngine_UI_Selectable__set_interactable(*(undefined4 *)(param1 + 0x20),0);
		      func_ii_7888(&local_18,uVar11,0);
		      fVar3 = local_10;
		      uVar11 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                         (param1_00,0);
		      func_ii_7888(&local_18,uVar11,0);
		      uVar11 = UnityEngine_Component__GetComponentInChildren___Il2CppFullySharedGenericType_
		                         (*(undefined4 *)(param1 + 0x1c),
		                          Method_UnityEngine_Component_GetComponentInParent_Canvas___);
		      fVar13 = UnityEngine_Canvas__get_pixelRect(uVar11,0);
		      uVar11 = *(undefined4 *)(param1 + 0x1c);
		      if (*(int *)(UnityEngine_RectTransformUtility_TypeInfo + 0x74) == 0) {
		        func_ii_306000(UnityEngine_RectTransformUtility_TypeInfo);
		      }
		      UnityEngine_RectTransformUtility__CalculateRelativeRectTransformBounds(&local_18,uVar11,0);
		      fVar4 = local_14;
		      fVar2 = local_18;
		      func_ii_7888(&local_18,*(undefined4 *)(param1 + 0x1c),0);
		      fVar21 = (float)fVar3 - (float)local_10;
		      fVar30 = (float)local_18 / fVar13;
		      local_24 = (float4)(fVar13 * (((float)fVar2 - (float)local_c) + fVar30));
		      fVar31 = (float)local_14 / fVar13;
		      local_20 = (float4)(fVar13 * (((float)fVar4 - (float)local_8) + fVar31));
		      local_60 = CONCAT44(local_20,local_24);
		      local_58 = fVar21;
		      local_1c = (float4)fVar21;
		      UnityEngine_Camera__ViewportToWorldPoint(&local_18,param1_00,&local_60,0);
		      fVar6 = local_14;
		      fVar3 = local_18;
		      local_2c = (float4)(fVar13 * ((float)fVar4 + (float)local_8 + fVar31));
		      local_30 = (float4)(fVar13 * ((float)fVar2 + (float)local_c + fVar30));
		      local_70 = CONCAT44(local_2c,local_30);
		      local_68 = fVar21;
		      local_28 = (float4)fVar21;
		      UnityEngine_Camera__ViewportToWorldPoint(&local_18,param1_00,&local_70,0);
		      fVar7 = local_14;
		      fVar2 = local_18;
		      local_3c = 0;
		      local_80 = 0;
		      local_78 = fVar21;
		      local_34 = (float4)fVar21;
		      UnityEngine_Camera__WorldToViewportPoint(&local_18,param1_00,&local_80,0);
		      fVar8 = local_14;
		      fVar4 = local_18;
		      local_48 = 0x3f8000003f800000;
		      local_90 = 0x3f8000003f800000;
		      local_88 = fVar21;
		      local_40 = (float4)fVar21;
		      UnityEngine_Camera__WorldToViewportPoint(&local_18,param1_00,&local_90,0);
		      fVar13 = (float)fVar7 - (float)fVar6;
		      fVar22 = (float)fVar5 - (float)fVar10;
		      fVar28 = ((float)fVar5 + (float)fVar10) - fVar22;
		      fVar23 = fVar22 + fVar28 * 0.5;
		      fVar24 = fVar23 - fVar13 * 0.5;
		      fVar21 = fVar13 + fVar24;
		      fVar30 = (float)local_14 - (float)fVar8;
		      fVar31 = (float)fVar2 - (float)fVar3;
		      fVar25 = (float)fVar1 - (float)fVar9;
		      fVar29 = ((float)fVar1 + (float)fVar9) - fVar25;
		      fVar26 = fVar25 + fVar29 * 0.5;
		      fVar27 = fVar26 - fVar31 * 0.5;
		      fVar14 = fVar31 + fVar27;
		      fVar15 = (float)local_18 - (float)fVar4;
		      if (((((fVar25 < fVar27) || (fVar14 <= fVar25)) || (fVar22 < fVar24)) ||
		          ((fVar21 <= fVar22 || (fVar25 + fVar29 < fVar27)))) ||
		         ((fVar14 <= fVar25 + fVar29 ||
		          ((fVar22 + fVar28 < fVar24 || (fVar25 = 1.0, fVar21 <= fVar22 + fVar28)))))) {
		        iVar12 = Mono_Security_ASN1Convert__ToOid(float___TypeInfo,3);
		        *(float *)(iVar12 + 0x18) = fVar28 / fVar13;
		        *(float *)(iVar12 + 0x14) = fVar29 / fVar31;
		        *(undefined4 *)(iVar12 + 0x10) = 0x3f800000;
		        iVar16 = *(int *)(iVar12 + 0xc);
		        if (iVar16 == 0) {
		          fVar25 = 0.0;
		        }
		        else {
		          fVar25 = 1.0;
		          if (1 < iVar16) {
		            uVar17 = iVar16 - 1U & 3;
		            if (iVar16 - 2U < 3) {
		              iVar19 = 1;
		            }
		            else {
		              iVar19 = 1;
		              do {
		                iVar18 = iVar12 + iVar19 * 4;
		                fVar22 = *(float *)(iVar18 + 0x10);
		                if (*(float *)(iVar18 + 0x10) <= fVar25) {
		                  fVar22 = fVar25;
		                }
		                fVar25 = *(float *)(iVar18 + 0x14);
		                if (*(float *)(iVar18 + 0x14) <= fVar22) {
		                  fVar25 = fVar22;
		                }
		                fVar22 = *(float *)(iVar18 + 0x18);
		                if (*(float *)(iVar18 + 0x18) <= fVar25) {
		                  fVar22 = fVar25;
		                }
		                fVar25 = *(float *)(iVar18 + 0x1c);
		                if (*(float *)(iVar18 + 0x1c) <= fVar22) {
		                  fVar25 = fVar22;
		                }
		                iVar19 = iVar19 + 4;
		                uVar20 = uVar20 + 4;
		              } while (uVar20 != (iVar16 - 1U & 0xfffffffc));
		            }
		            if (uVar17 != 0) {
		              uVar20 = 0;
		              do {
		                fVar22 = *(float *)(iVar12 + iVar19 * 4 + 0x10);
		                if (fVar22 <= fVar25) {
		                  fVar22 = fVar25;
		                }
		                fVar25 = fVar22;
		                iVar19 = iVar19 + 1;
		                uVar20 = uVar20 + 1;
		              } while (uVar20 != uVar17);
		            }
		          }
		        }
		      }
		      uVar11 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                         (param1_00,0);
		      local_4c = local_10;
		      local_98 = local_10;
		      fVar22 = fVar30 * fVar25 * 0.5;
		      fVar21 = (fVar21 * fVar25 - fVar24 * fVar25) * 0.5;
		      local_50 = (float4)(fVar22 + ((((fVar30 * 0.5 + (float)fVar8) - (fVar13 * 0.5 + (float)fVar6))
		                                     * fVar25 + fVar21 + (fVar23 - fVar21)) - fVar22));
		      fVar13 = fVar15 * fVar25 * 0.5;
		      fVar21 = (fVar14 * fVar25 - fVar27 * fVar25) * 0.5;
		      local_54 = (float4)(fVar13 + ((((fVar15 * 0.5 + (float)fVar4) - (fVar31 * 0.5 + (float)fVar3))
		                                     * fVar25 + fVar21 + (fVar26 - fVar21)) - fVar13));
		      local_a0 = CONCAT44(local_50,local_54);
		      UnityEngine_Transform__get_position(uVar11,&local_a0,0);
		      ScreenAdaptation_Common_AppSize__GetCurrentScaleRatio(param1_00,fVar22,0);
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06005986 RID: 22918 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005986")]
		[Address(RVA = "0xA6B2", Offset = "0xA6B2", VA = "0xA6B2")]
		private void AdjustSceneAnimation()
		{
		/* --- GHIDRA: AdjustSceneAnimation ---
		void Test_AnimationLoaderTest__AdjustSceneAnimation(int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int *param1_00;
		  undefined4 uVar2;
		  uint *puVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a63c22 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IGameAnimation__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Test_AnimationLoaderTest_OnCompleteEvent__);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_GameObject_GetComponent_IGameAnimation___);
		    Mono_Security_ASN1__get_Item(&Core_Animations_IGameAnimation_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a63c22 = '\x01';
		  }
		  param1_00 = (int *)func_ii_6601(*(undefined4 *)(param1 + 0x20),
		                                  Method_UnityEngine_GameObject_GetComponent_IGameAnimation___);
		  uVar2 = unnamed_function_1417(System_Action_IGameAnimation__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,Method_Test_AnimationLoaderTest_OnCompleteEvent__,0);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Animations_IGameAnimation_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xd8);
		        goto code_r0x8236f9d3;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_00,Core_Animations_IGameAnimation_TypeInfo,3);
		code_r0x8236f9d3:
		  (**(code **)((ulonglong)*puVar3 * 4))(param1_00,uVar2,puVar3[1]);
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (param1,0);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  UnityEngine_Application__get_isPlaying(uVar2,0);
		  return;
		}
		*/

		}

		// Token: 0x06005987 RID: 22919 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005987")]
		[Address(RVA = "0xA6B3", Offset = "0xA6B3", VA = "0xA6B3")]
		private void OnCompleteEvent(IGameAnimation obj)
		{
		/* --- GHIDRA: OnCompleteEvent ---
		void Test_AnimationLoaderTest__OnCompleteEvent
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 param1_00;
		  int *param1_01;
		  uint *puVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a63c23 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_GameObject_GetComponent_IGameAnimation___);
		    Mono_Security_ASN1__get_Item(&Core_Animations_IGameAnimation_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_GameObject___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a63c23 = '\x01';
		  }
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  uVar1 = 0;
		  param1_00 = func_ii_5950(param2,Method_UnityEngine_Object_Instantiate_GameObject___);
		  param1_01 = (int *)func_ii_6601(param1_00,
		                                  Method_UnityEngine_GameObject_GetComponent_IGameAnimation___);
		  iVar3 = *param1_01;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Core_Animations_IGameAnimation_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x120);
		        goto code_r0x8236fae9;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_01,Core_Animations_IGameAnimation_TypeInfo,0xc);
		code_r0x8236fae9:
		  (**(code **)((ulonglong)*puVar2 * 4))(param1_01,1,puVar2[1]);
		  return;
		}
		*/

		}

		// Token: 0x06005988 RID: 22920 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005988")]
		[Address(RVA = "0xA6B4", Offset = "0xA6B4", VA = "0xA6B4")]
		public void ShowTestPrefab(GameObject animation)
		{
		/* --- GHIDRA: ShowTestPrefab ---
		void Test_AnimationLoaderTest__ShowTestPrefab(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  int *param1_00;
		  uint *puVar3;
		  undefined4 uVar4;
		  
		  if (DAT_ram_00a63c24 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IGameAnimation__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Test_AnimationLoaderTest_OnCompleteEvent__);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_GameObject_GetComponent_IGameAnimation___);
		    Mono_Security_ASN1__get_Item(&Core_GameResources_GameResourcesManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Animations_IGameAnimation_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a63c24 = '\x01';
		  }
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor
		                    (*(undefined4 *)(param1 + 0x20),0);
		  if (iVar2 != 0) {
		    uVar1 = 0;
		    param1_00 = (int *)func_ii_6601(*(undefined4 *)(param1 + 0x20),
		                                    Method_UnityEngine_GameObject_GetComponent_IGameAnimation___);
		    uVar4 = unnamed_function_1417(System_Action_IGameAnimation__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar4,param1,Method_Test_AnimationLoaderTest_OnCompleteEvent__,0);
		    iVar2 = *param1_00;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      do {
		        if (Core_Animations_IGameAnimation_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8))
		        {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0xd8);
		          goto code_r0x8236fbf0;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(param1_00,Core_Animations_IGameAnimation_TypeInfo,3);
		code_r0x8236fbf0:
		    (**(code **)((ulonglong)*puVar3 * 4))(param1_00,uVar4,puVar3[1]);
		    uVar4 = *(undefined4 *)(param1 + 0x20);
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UnityEngine_Object_TypeInfo);
		    }
		    UnityEngine_Application__get_isPlaying(uVar4,0);
		    *(undefined4 *)(param1 + 0x20) = 0;
		  }
		  uVar4 = *(undefined4 *)(param1 + 0x10);
		  if (*(int *)(Core_GameResources_GameResourcesManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameResources_GameResourcesManager_TypeInfo);
		  }
		  Core_GameResources_GameResourcesManager__GetAnimation(uVar4,0);
		  return;
		}
		*/

		}

		// Token: 0x06005989 RID: 22921 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005989")]
		[Address(RVA = "0xA6B5", Offset = "0xA6B5", VA = "0xA6B5")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Test_AnimationLoaderTest__OnDestroy(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a63c25 == '\0') {
		    Mono_Security_ASN1__get_Item(&Test_AnimationLoaderTest___c_TypeInfo);
		    DAT_ram_00a63c25 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Test_AnimationLoaderTest___c_TypeInfo);
		  **(undefined4 **)(Test_AnimationLoaderTest___c_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x04003049 RID: 12361
		[Token(Token = "0x4003049")]
		[FieldOffset(Offset = "0x10")]
		private string _url;

		// Token: 0x0400304A RID: 12362
		[Token(Token = "0x400304A")]
		[FieldOffset(Offset = "0x14")]
		private RawImage _testTextureImage;

		// Token: 0x0400304B RID: 12363
		[Token(Token = "0x400304B")]
		[FieldOffset(Offset = "0x18")]
		private Transform _worldAnimationsContainer;

		// Token: 0x0400304C RID: 12364
		[Token(Token = "0x400304C")]
		[FieldOffset(Offset = "0x1C")]
		private Transform _canvasAnimationsContainer;

		// Token: 0x0400304D RID: 12365
		[Token(Token = "0x400304D")]
		[FieldOffset(Offset = "0x20")]
		private GameObject _animationGameObject;

		// Token: 0x0400304E RID: 12366
		[Token(Token = "0x400304E")]
		[FieldOffset(Offset = "0x24")]
		private readonly Lazy<Camera> _camera;

		// Token: 0x0400304F RID: 12367
		[Token(Token = "0x400304F")]
		[FieldOffset(Offset = "0x28")]
		private readonly Lazy<Text> _debugText;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_IsPan ---
		void Test_AnimationLoaderTest__get_IsPan(int param1,int *param2,undefined4 param3,undefined4 param4)
		
		{
		  int *piVar1;
		  int iVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  int iVar5;
		  int iVar6;
		  int param1_00;
		  undefined4 uVar7;
		  undefined4 param2_00;
		  uint uVar8;
		  undefined8 local_58;
		  float4 local_50;
		  undefined8 local_48;
		  undefined8 local_40;
		  undefined4 local_38;
		  undefined8 local_30;
		  float4 local_28;
		  undefined8 local_24;
		  float4 local_1c;
		  undefined8 local_18;
		  undefined8 local_c;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a63c1f == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_TestCameraController___)
		    ;
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_GameObject_AddComponent_TestCameraController___);
		    Mono_Security_ASN1__get_Item(&Core_Animations_IGameAnimation_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Lazy_Camera__get_Value__);
		    Mono_Security_ASN1__get_Item(&Method_System_Lazy_Text__get_Value__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_RectTransform_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Animations_SpineUiButtonAnimation_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3136);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3137);
		    Mono_Security_ASN1__get_Item(&StringLiteral_199);
		    DAT_ram_00a63c1f = '\x01';
		  }
		  piVar1 = (int *)Core_Analytics_Okg_OkgAnalytics__DoSendLog
		                            (*(undefined4 *)(param1 + 0x28),Method_System_Lazy_Text__get_Value__);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar2 = UnityEngine_Component__GetComponent_object_(piVar1,0);
		  if (iVar2 != 0) {
		    (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x318) * 4))
		              (piVar1,**(undefined4 **)(DAT_ram_00a66978 + 0x5c),*(undefined4 *)(*piVar1 + 0x31c));
		  }
		  uVar3 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(StringLiteral_199,param3,0);
		  if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		    func_ii_306000(OKG_Logs_Debug_TypeInfo);
		  }
		  uVar8 = 0;
		  System_Collections_Generic_Dictionary_uint__object___get_Count(uVar3,0);
		  iVar2 = *param2;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    do {
		      if (Core_Animations_IGameAnimation_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar8 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar8 * 8 + 4) * 8 + iVar2 + 0xf0);
		        goto code_r0x8236e2b0;
		      }
		      uVar8 = uVar8 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar8);
		  }
		  puVar4 = (uint *)func_ii_1080(param2,Core_Animations_IGameAnimation_TypeInfo,6);
		code_r0x8236e2b0:
		  uVar3 = (**(code **)((ulonglong)*puVar4 * 4))(param2,puVar4[1]);
		  uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (uVar3,0);
		  *(undefined4 *)(param1 + 0x20) = uVar3;
		  iVar2 = 1;
		  iVar5 = UnityEngine_GameObject__set_layer(uVar3,StringLiteral_3136,0);
		  if (iVar5 == 0) {
		    iVar2 = UnityEngine_GameObject__set_layer(*(undefined4 *)(param1 + 0x20),StringLiteral_3137,0);
		  }
		  iVar5 = UnityEngine_GameObject__set_layer(*(undefined4 *)(param1 + 0x20),StringLiteral_3136,0);
		  uVar3 = Core_Analytics_Okg_OkgAnalytics__DoSendLog
		                    (*(undefined4 *)(param1 + 0x24),Method_System_Lazy_Camera__get_Value__);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  param1_00 = 0;
		  iVar6 = UnityEngine_Component__GetComponent_object_(uVar3,0);
		  if (iVar6 != 0) {
		    param1_00 = func_ii_5677(uVar3,Method_UnityEngine_Component_GetComponent_TestCameraController___
		                            );
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UnityEngine_Object_TypeInfo);
		    }
		    iVar6 = UnityEngine_Component__GetComponent_object_(param1_00,0);
		    if (iVar6 == 0) {
		      uVar7 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (uVar3,0);
		      param1_00 = UnityEngine_GameObject__GetComponent_object_
		                            (uVar7,
		                             Method_UnityEngine_GameObject_AddComponent_TestCameraController___);
		      piVar1 = *(int **)(param1 + 0x1c);
		      if ((piVar1 != (int *)0x0) && (UnityEngine_RectTransform_TypeInfo != *piVar1)) {
		        System_Activator__CreateInstance(piVar1,UnityEngine_RectTransform_TypeInfo);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int **)(param1_00 + 0x44) = piVar1;
		    }
		  }
		  uVar7 = UnityEngine_UI_Selectable__set_interactable(*(undefined4 *)(param1 + 0x20),0);
		  if (iVar2 == 0) {
		    UnityEngine_Transform__GetParent(uVar7,*(undefined4 *)(param1 + 0x18),0);
		    if (DAT_ram_00a63c1e == '\0') {
		      Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_FindObjectOfType_AnimationTest___);
		      Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		      DAT_ram_00a63c1e = '\x01';
		    }
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UnityEngine_Object_TypeInfo);
		    }
		    iVar2 = UnityEngine_Object__FindFirstObjectByType_object_
		                      (Method_UnityEngine_Object_FindObjectOfType_AnimationTest___);
		    iVar6 = UnityEngine_Component__GetComponent_object_(iVar2,0);
		    if ((iVar6 == 0) || (*(char *)(*(int *)(iVar2 + 0x28) + 0xc4) == '\0')) {
		      if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		        func_ii_306000(UnityEngine_Object_TypeInfo);
		      }
		      iVar2 = UnityEngine_Component__GetComponent_object_(param1_00,0);
		      if (iVar2 != 0) {
		        UnityEngine_Object__op_Implicit(param1_00,0,0);
		      }
		      Test_AnimationLoaderTest__AdjustCanvasAnimation(param1,param1_00);
		    }
		    else {
		      if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		        func_ii_306000(UnityEngine_Object_TypeInfo);
		      }
		      iVar2 = UnityEngine_Component__GetComponent_object_(uVar3,0);
		      if (iVar2 != 0) {
		        uVar7 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                          (uVar3,0);
		        func_ii_7888(&local_24,uVar7,0);
		        param2_00 = UnityEngine_UI_Selectable__set_interactable(*(undefined4 *)(param1 + 0x20),0);
		        func_ii_7888(&local_24,param2_00,0);
		        iVar2 = UnityEngine_Screen__get_width(0);
		        ScreenAdaptation_Common_AppSize__GetCurrentScaleRatio(uVar3,(float)iVar2 * 0.5,0);
		        local_28 = local_1c;
		        local_50 = local_1c;
		        local_30 = local_24;
		        local_58 = local_24;
		        UnityEngine_Transform__get_position(uVar7,&local_58,0);
		      }
		      if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		        func_ii_306000(UnityEngine_Object_TypeInfo);
		      }
		      iVar2 = UnityEngine_Component__GetComponent_object_(param1_00,0);
		      if (iVar2 != 0) {
		        UnityEngine_Object__op_Implicit(param1_00,1,0);
		      }
		    }
		  }
		  else {
		    UnityEngine_Transform__GetParent(uVar7,*(undefined4 *)(param1 + 0x1c),0);
		    uVar3 = UnityEngine_UI_Selectable__set_interactable(*(undefined4 *)(param1 + 0x20),0);
		    local_4 = 0;
		    local_38 = 0;
		    local_c = 0x42c8000042c80000;
		    local_40 = 0x42c8000042c80000;
		    Gameplay_Isles_User_View_IsleAccountMarkersLayerView__GetView(uVar3,&local_40,0);
		    if (DAT_ram_00a63c1e == '\0') {
		      Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_FindObjectOfType_AnimationTest___);
		      Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		      DAT_ram_00a63c1e = '\x01';
		    }
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UnityEngine_Object_TypeInfo);
		    }
		    iVar2 = UnityEngine_Object__FindFirstObjectByType_object_
		                      (Method_UnityEngine_Object_FindObjectOfType_AnimationTest___);
		    iVar6 = UnityEngine_Component__GetComponent_object_(iVar2,0);
		    if ((iVar6 == 0) || (*(char *)(*(int *)(iVar2 + 0x28) + 0xc4) == '\0')) {
		      if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		        func_ii_306000(UnityEngine_Object_TypeInfo);
		      }
		      iVar2 = UnityEngine_Component__GetComponent_object_(param1_00,0);
		      if (iVar2 != 0) {
		        UnityEngine_Object__op_Implicit(param1_00,0,0);
		      }
		      Test_AnimationLoaderTest__CompleteCallback(param1,param1_00);
		    }
		    else {
		      piVar1 = (int *)UnityEngine_UI_Selectable__set_interactable(*(undefined4 *)(param1 + 0x20),0);
		      if (DAT_ram_00a65d40 == '\0') {
		        Mono_Security_ASN1__get_Item(&UnityEngine_Vector2_TypeInfo);
		        DAT_ram_00a65d40 = '\x01';
		      }
		      local_48 = **(undefined8 **)(UnityEngine_Vector2_TypeInfo + 0x5c);
		      if ((piVar1 != (int *)0x0) && (UnityEngine_RectTransform_TypeInfo != *piVar1)) {
		        System_Activator__CreateInstance(piVar1,UnityEngine_RectTransform_TypeInfo);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      local_18 = local_48;
		      UnityEngine_RectTransform__get_anchoredPosition(piVar1,&local_48,0);
		      if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		        func_ii_306000(UnityEngine_Object_TypeInfo);
		      }
		      iVar2 = UnityEngine_Component__GetComponent_object_(param1_00,0);
		      if (iVar2 != 0) {
		        UnityEngine_Object__op_Implicit(param1_00,1,0);
		      }
		    }
		  }
		  iVar2 = *param2;
		  if (iVar5 == 0) {
		    uVar8 = 0;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      do {
		        if (Core_Animations_IGameAnimation_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar8 * 8))
		        {
		          puVar4 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar8 * 8 + 4) * 8 + iVar2 + 0x120);
		          goto code_r0x8236e741;
		        }
		        uVar8 = uVar8 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar8);
		    }
		    puVar4 = (uint *)func_ii_1080(param2,Core_Animations_IGameAnimation_TypeInfo,0xc);
		code_r0x8236e741:
		    (**(code **)((ulonglong)*puVar4 * 4))(param2,1,puVar4[1]);
		  }
		  else {
		    if (((uint)*(byte *)(iVar2 + 0xb8) <
		         (uint)*(byte *)(Animations_SpineUiButtonAnimation_TypeInfo + 0xb8)) ||
		       (*(int *)(*(int *)(iVar2 + 100) +
		                 (uint)*(byte *)(Animations_SpineUiButtonAnimation_TypeInfo + 0xb8) * 4 + -4) !=
		        Animations_SpineUiButtonAnimation_TypeInfo)) {
		      System_Activator__CreateInstance(param2,Animations_SpineUiButtonAnimation_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    Animations_SpineUiButtonAnimation__get_DemoMode(param2,1,0);
		  }
		  return;
		}
		*/

}
