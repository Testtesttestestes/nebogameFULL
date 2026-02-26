using System;
using System.Threading;
using Core.Animations;
using Core.Gameplay.Managers.Skins;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine;

namespace UI.SkinsV2
{
	// Token: 0x02000183 RID: 387
	[Token(Token = "0x2000183")]
	[AddComponentMenu("SkinsV2/GameAnimationSkin (Skin Resolver)")]
	[DisallowMultipleComponent]
	public class GameAnimationSkinResolver : AbstractSkinResolver<IGameAnimation, MonoBehaviour>
	{
		// Token: 0x06000AF3 RID: 2803 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AF3")]
		[Address(RVA = "0x5E15", Offset = "0x5E15", VA = "0x5E15")]
		private void SetSkinApr(GameObject value)
		{
		/* --- GHIDRA: SetSkinApr ---
		void UI_SkinsV2_GameAnimationSkinResolver__SetSkinApr
		               (undefined4 param1,undefined4 param2,undefined4 *param3,undefined4 param4)
		
		{
		  uint uVar1;
		  int *param1_00;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 param1_01;
		  int iVar4;
		  
		  if (DAT_ram_00a599e3 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_Component_GetComponent_IHasSkeletonDataAsset___);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_SkinsV2_AbstractSkinResolver_ContentInfo_IGameAnimation__MonoBehaviour___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&UI_SkinsV2_AbstractSkinResolver_ContentInfo_IGameAnimation__MonoBehaviour__TypeInfo)
		    ;
		    Mono_Security_ASN1__get_Item(&Spine_Unity_IHasSkeletonDataAsset_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_MonoBehaviour_TypeInfo);
		    DAT_ram_00a599e3 = '\x01';
		  }
		  param1_00 = (int *)func_ii_5677(param1,
		                                  Method_UnityEngine_Component_GetComponent_IHasSkeletonDataAsset___
		                                 );
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Spine_Unity_IHasSkeletonDataAsset_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)
		         ) {
		        puVar2 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x810a24be;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Spine_Unity_IHasSkeletonDataAsset_TypeInfo,0);
		code_r0x810a24be:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  uVar3 = GAFInternal_Assets_GAFAnimationAssetInternal__collectExternalData(uVar3,0);
		  param1_01 = unnamed_function_1417
		                        (
		                        UI_SkinsV2_AbstractSkinResolver_ContentInfo_IGameAnimation__MonoBehaviour__TypeInfo
		                        );
		  if (((uint)*(byte *)(UnityEngine_MonoBehaviour_TypeInfo + 0xb8) <=
		       (uint)*(byte *)(*param1_00 + 0xb8)) &&
		     (*(int *)(*(int *)(*param1_00 + 100) +
		               (uint)*(byte *)(UnityEngine_MonoBehaviour_TypeInfo + 0xb8) * 4 + -4) ==
		      UnityEngine_MonoBehaviour_TypeInfo)) {
		    UnityEngine_Purchasing_Default_Factory__Create
		              (param1_01,uVar3,param1_00,
		               Method_UI_SkinsV2_AbstractSkinResolver_ContentInfo_IGameAnimation__MonoBehaviour___ctor__
		              );
		    *param3 = param1_01;
		    return;
		  }
		  System_Activator__CreateInstance(param1_00,UnityEngine_MonoBehaviour_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06000AF4 RID: 2804 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AF4")]
		[Address(RVA = "0x5E16", Offset = "0x5E16", VA = "0x5E16", Slot = "4")]
		protected override void GetDefaultContent(IGameAnimation component, out AbstractSkinResolver<IGameAnimation, MonoBehaviour>.ContentInfo content)
		{
		/* --- GHIDRA: GetDefaultContent ---
		void UI_SkinsV2_GameAnimationSkinResolver__GetDefaultContent
		               (int param1,int *param2,undefined4 param3,undefined4 param4)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a599e4 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Animations_IGameAnimation_TypeInfo);
		    DAT_ram_00a599e4 = '\x01';
		  }
		  UnityEngine_Object__op_Implicit(param3,1,0);
		  iVar4 = *param2;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Animations_IGameAnimation_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x118);
		        goto code_r0x810a25d3;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,Core_Animations_IGameAnimation_TypeInfo,0xb);
		code_r0x810a25d3:
		  uVar1 = 0;
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  iVar4 = *param2;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Animations_IGameAnimation_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x120);
		        goto code_r0x810a2657;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,Core_Animations_IGameAnimation_TypeInfo,0xc);
		code_r0x810a2657:
		  (**(code **)((ulonglong)*puVar2 * 4))(param2,uVar3,puVar2[1]);
		  if (DAT_ram_00a599e2 == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a599e2 = '\x01';
		  }
		  uVar3 = *(undefined4 *)(param1 + 0x20);
		  *(undefined4 *)(param1 + 0x20) = 0;
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  UnityEngine_Application__get_isPlaying(uVar3,0);
		  return;
		}
		*/

		}

		// Token: 0x06000AF5 RID: 2805 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AF5")]
		[Address(RVA = "0x5E17", Offset = "0x5E17", VA = "0x5E17", Slot = "5")]
		protected override void Rollback(IGameAnimation component, MonoBehaviour content)
		{
		/* --- GHIDRA: Rollback ---
		void UI_SkinsV2_GameAnimationSkinResolver__Rollback
		               (undefined8 *param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5,undefined4 param6)
		
		{
		  undefined8 local_40;
		  undefined4 local_34;
		  undefined8 local_30;
		  undefined4 local_28;
		  undefined4 local_24;
		  undefined4 local_20;
		  undefined4 local_1c;
		  undefined4 local_18;
		  undefined8 local_14;
		  undefined8 local_c;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a599e5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_bool__Create__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_bool__Start_GameAnimationSkinResolver__TryResolve_d__4___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_bool__get_Task__
		              );
		    DAT_ram_00a599e5 = '\x01';
		  }
		  local_4 = 0;
		  local_c = 0;
		  local_28 = 0;
		  local_14 = 0;
		  local_30 = 0;
		  local_34 = 0xffffffff;
		  local_24 = param3;
		  local_20 = param4;
		  local_1c = param5;
		  local_18 = param2;
		  if (*(int *)(
		              Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_bool__Start_GameAnimationSkinResolver__TryResolve_d__4___
		              + 0x1c) == 0) {
		    System_ReadOnlySpan_char___GetPinnableReference
		              (
		              Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_bool__Start_GameAnimationSkinResolver__TryResolve_d__4___
		              );
		  }
		  UI_SkinsV2_GameAnimationSkinResolver___ctor(&local_34,&local_40);
		  unnamed_function_62983
		            (&local_40,&local_30,
		             Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_bool__get_Task__
		            );
		  *param1 = local_40;
		  return;
		}
		*/

		}

		// Token: 0x06000AF6 RID: 2806 RVA: 0x00003A50 File Offset: 0x00001C50
		[Token(Token = "0x6000AF6")]
		[Address(RVA = "0x5E18", Offset = "0x5E18", VA = "0x5E18", Slot = "6")]
		protected override UniTask<bool> TryResolve(IGameAnimation component, Skin skin, CancellationToken cancellationToken)
		{
		/* --- GHIDRA: TryResolve ---
		void UI_SkinsV2_GameAnimationSkinResolver__TryResolve(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a599e6 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_SkinsV2_AbstractSkinResolver_IGameAnimation__MonoBehaviour___ctor__);
		    DAT_ram_00a599e6 = '\x01';
		  }
		  Gameplay_Combat_Model_SkillsChange_AbstractShortSpellInfo_object___Dispose
		            (param1,Method_UI_SkinsV2_AbstractSkinResolver_IGameAnimation__MonoBehaviour___ctor__);
		  return;
		}
		*/

			return default(UniTask<bool>);
		}

		// Token: 0x06000AF7 RID: 2807 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AF7")]
		[Address(RVA = "0x5E19", Offset = "0x5E19", VA = "0x5E19")]
		public GameAnimationSkinResolver()
		{
		/* --- GHIDRA: .ctor ---
		void UI_SkinsV2_GameAnimationSkinResolver___ctor(int *param1,undefined4 param2)
		
		{
		  short sVar1;
		  uint uVar2;
		  undefined1 uVar3;
		  undefined4 *puVar4;
		  undefined4 uVar5;
		  undefined4 uVar6;
		  uint *puVar7;
		  undefined4 uVar8;
		  undefined4 *param2_00;
		  int iVar9;
		  int iVar10;
		  int iVar11;
		  int *piVar12;
		  undefined4 uVar13;
		  uint local_40;
		  undefined4 uStack_3c;
		  undefined4 local_38;
		  undefined4 uStack_34;
		  undefined8 local_30;
		  undefined8 local_28;
		  undefined8 local_20;
		  undefined4 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a599e7 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_bool__AwaitUnsafeOnCompleted_UniTask_Awaiter_ValueTuple_bool__string____GameAnimationSkinResolver__TryResolve_d__4___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_bool__SetResult__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Cysharp_Threading_Tasks_UniTask_Awaiter_ValueTuple_bool__string___GetResult__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Cysharp_Threading_Tasks_UniTask_Awaiter_ValueTuple_bool__string___get_IsCompleted__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_Component_TryGetComponent_IHasSkeletonDataAsset___);
		    Mono_Security_ASN1__get_Item(&AssetContent_GameAnimationView_var);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_GameObject_GetComponent_GameAnimationView___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_GameObject_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Animations_IGameAnimation_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Spine_Unity_IHasSkeletonDataAsset_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_MonoBehaviour_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Type___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Cysharp_Threading_Tasks_UniTask_ValueTuple_bool__string___GetAwaiter__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Cysharp_Threading_Tasks_UniTask_string__SuppressCancellationThrow__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19177);
		    DAT_ram_00a599e7 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  local_18 = 0;
		  local_20 = 0;
		  local_28 = 0;
		  local_30 = 0;
		  iVar9 = param1[7];
		  if (*param1 == 0) {
		    piVar12 = param1 + 0xb;
		    local_8 = *(undefined8 *)piVar12;
		    local_10 = *(undefined8 *)(param1 + 9);
		    param1[9] = 0;
		    param1[10] = 0;
		    piVar12[0] = 0;
		    piVar12[1] = 0;
		    *param1 = -1;
		    piVar12 = (int *)local_10;
		code_r0x810a2e0d:
		    if (piVar12 == (int *)0x0) {
		code_r0x810a2e12:
		      uVar8 = (undefined4)local_8;
		      local_40 = local_10._4_4_;
		code_r0x810a2f91:
		      uVar3 = 0;
		      if ((local_40 & 1) != 0) goto code_r0x810a366b;
		      DAT_ram_009d3e38 = 0;
		      uVar13 = import::env::invoke_iii
		                         (s_struct_Uniforms___color__array<v_ram_00000aff + 0x215,iVar9,0);
		      iVar10 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar10 == 1) {
		        uVar8 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      }
		      else {
		        DAT_ram_009d3e38 = 0;
		        uVar13 = import::env::invoke_iiii
		                           (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x1e4,uVar13,
		                            StringLiteral_19177,0);
		        iVar10 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar10 == 1) {
		          uVar8 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        }
		        else {
		          DAT_ram_009d3e38 = 0;
		          piVar12 = (int *)import::env::invoke_iii
		                                     (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x1b1,
		                                      System_Type___TypeInfo,1);
		          iVar10 = DAT_ram_009d3e38;
		          uVar5 = AssetContent_GameAnimationView_var;
		          DAT_ram_009d3e38 = 0;
		          if (iVar10 == 1) {
		            uVar8 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          }
		          else {
		            if (*(int *)(DAT_ram_00a669a0 + 0x74) == 0) {
		              DAT_ram_009d3e38 = 0;
		              import::env::invoke_vi
		                        (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,DAT_ram_00a669a0);
		              iVar10 = DAT_ram_009d3e38;
		              DAT_ram_009d3e38 = 0;
		              if (iVar10 == 1) {
		                uVar8 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                goto code_r0x810a374f;
		              }
		            }
		            DAT_ram_009d3e38 = 0;
		            iVar10 = import::env::invoke_iii
		                               (s_struct_Uniforms___color__vec4<f3_ram_00000856 + 0x259,uVar5,0);
		            if (DAT_ram_009d3e38 != 1) {
		              if (iVar10 == 0) {
		code_r0x810a316b:
		                piVar12[4] = iVar10;
		                DAT_ram_009d3e38 = 0;
		                uVar5 = import::env::invoke_ii
		                                  (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                                   UnityEngine_GameObject_TypeInfo);
		                if (DAT_ram_009d3e38 != 1) {
		                  DAT_ram_009d3e38 = 0;
		                  import::env::invoke_viiii
		                            (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x51,uVar5,uVar13,
		                             piVar12,0);
		                  if (DAT_ram_009d3e38 != 1) {
		                    DAT_ram_009d3e38 = 0;
		                    uVar13 = import::env::invoke_iii
		                                       (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x17b,
		                                        uVar5,0);
		                    iVar10 = DAT_ram_009d3e38;
		                    DAT_ram_009d3e38 = 0;
		                    if (iVar10 == 1) {
		                      uVar8 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                      goto code_r0x810a374f;
		                    }
		                    piVar12 = (int *)param1[4];
		                    iVar10 = *piVar12;
		                    if (*(ushort *)(iVar10 + 0xb6) != 0) {
		                      uVar2 = 0;
		                      do {
		                        if (Core_Animations_IGameAnimation_TypeInfo ==
		                            *(int *)(*(int *)(iVar10 + 0x58) + uVar2 * 8)) {
		                          puVar4 = (undefined4 *)
		                                   (*(int *)(*(int *)(iVar10 + 0x58) + uVar2 * 8 + 4) * 8 + iVar10 +
		                                   0xf0);
		                          goto code_r0x810a32a5;
		                        }
		                        uVar2 = uVar2 + 1;
		                      } while (*(ushort *)(iVar10 + 0xb6) != uVar2);
		                    }
		                    DAT_ram_009d3e38 = 0;
		                    puVar4 = (undefined4 *)
		                             import::env::invoke_iiii
		                                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,
		                                        piVar12,Core_Animations_IGameAnimation_TypeInfo,6);
		                    if (DAT_ram_009d3e38 != 1) {
		code_r0x810a32a5:
		                      DAT_ram_009d3e38 = 0;
		                      uVar6 = import::env::invoke_iii(*puVar4,piVar12,puVar4[1]);
		                      if (DAT_ram_009d3e38 != 1) {
		                        DAT_ram_009d3e38 = 0;
		                        uVar6 = import::env::invoke_iii
		                                          (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x30e,
		                                           uVar6,0);
		                        if (DAT_ram_009d3e38 != 1) {
		                          DAT_ram_009d3e38 = 0;
		                          import::env::invoke_viiii
		                                    (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x52,uVar13,
		                                     uVar6,0,0);
		                          if (DAT_ram_009d3e38 != 1) {
		                            DAT_ram_009d3e38 = 0;
		                            uVar13 = import::env::invoke_iii
		                                               (s_struct_Uniforms___color__array<v_ram_000017c8 +
		                                                0x202,uVar5,
		                                                Method_UnityEngine_GameObject_GetComponent_GameAnimationView___
		                                               );
		                            iVar10 = DAT_ram_009d3e38;
		                            DAT_ram_009d3e38 = 0;
		                            if (iVar10 == 1) {
		                              uVar8 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                            }
		                            else {
		                              DAT_ram_009d3e38 = 0;
		                              import::env::invoke_viii
		                                        (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x53,
		                                         uVar13,uVar8,0);
		                              iVar10 = DAT_ram_009d3e38;
		                              DAT_ram_009d3e38 = 0;
		                              if (iVar10 == 1) {
		                                uVar8 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                              }
		                              else {
		                                piVar12 = (int *)param1[8];
		                                if (piVar12 == (int *)0x0) {
		code_r0x810a341c:
		                                  DAT_ram_009d3e38 = 0;
		                                  import::env::invoke_viii
		                                            (s_struct_Uniforms___color__array<v_ram_000013c7 + 0x269
		                                             ,piVar12,0,0);
		                                  if (DAT_ram_009d3e38 != 1) {
		                                    piVar12 = (int *)param1[4];
		                                    iVar10 = *piVar12;
		                                    if (*(ushort *)(iVar10 + 0xb6) != 0) {
		                                      uVar2 = 0;
		                                      do {
		                                        if (Core_Animations_IGameAnimation_TypeInfo ==
		                                            *(int *)(*(int *)(iVar10 + 0x58) + uVar2 * 8)) {
		                                          puVar4 = (undefined4 *)
		                                                   (*(int *)(*(int *)(iVar10 + 0x58) + uVar2 * 8 + 4
		                                                            ) * 8 + iVar10 + 0x128);
		                                          goto code_r0x810a34e9;
		                                        }
		                                        uVar2 = uVar2 + 1;
		                                      } while (*(ushort *)(iVar10 + 0xb6) != uVar2);
		                                    }
		                                    DAT_ram_009d3e38 = 0;
		                                    puVar4 = (undefined4 *)
		                                             import::env::invoke_iiii
		                                                       (
		                                                  s_Allocator__0___Blocksize__1__mus_ram_00000421 +
		                                                  0x18,piVar12,
		                                                  Core_Animations_IGameAnimation_TypeInfo,0xd);
		                                    if (DAT_ram_009d3e38 != 1) {
		code_r0x810a34e9:
		                                      DAT_ram_009d3e38 = 0;
		                                      import::env::invoke_vii(*puVar4,piVar12,puVar4[1]);
		                                      if (DAT_ram_009d3e38 != 1) {
		                                        if (DAT_ram_00a599e2 == '\0') {
		                                          DAT_ram_009d3e38 = 0;
		                                          import::env::invoke_vi(0x7ff,&UnityEngine_Object_TypeInfo)
		                                          ;
		                                          if (DAT_ram_009d3e38 != 1) {
		                                            DAT_ram_00a599e2 = '\x01';
		                                            goto code_r0x810a356b;
		                                          }
		                                        }
		                                        else {
		code_r0x810a356b:
		                                          uVar8 = *(undefined4 *)(iVar9 + 0x20);
		                                          *(undefined4 *)(iVar9 + 0x20) = uVar5;
		                                          if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		                                            DAT_ram_009d3e38 = 0;
		                                            import::env::invoke_vi
		                                                      (
		                                                  s_var<private>_posTex__array<vec4<_ram_00000655 +
		                                                  0x180,UnityEngine_Object_TypeInfo);
		                                            if (DAT_ram_009d3e38 == 1) goto code_r0x810a35e9;
		                                          }
		                                          DAT_ram_009d3e38 = 0;
		                                          import::env::invoke_vii
		                                                    (s_struct_Uniforms___color__array<v_ram_00000aff
		                                                     + 0x274,uVar8,0);
		                                          iVar9 = DAT_ram_009d3e38;
		                                          DAT_ram_009d3e38 = 0;
		                                          uVar3 = 1;
		                                          if (iVar9 != 1) {
		code_r0x810a366b:
		                                            param1[8] = 0;
		                                            *param1 = -2;
		                                            piVar12 = (int *)param1[1];
		                                            if (piVar12 == (int *)0x0) {
		                                              *(undefined1 *)(param1 + 3) = uVar3;
		                                              return;
		                                            }
		                                            iVar9 = *(int *)(
		                                                  Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_bool__SetResult__
		                                                  + 0x10);
		                                            if ((*(byte *)(iVar9 + 0xbd) & 1) == 0) {
		                                              iVar9 = func_ii_1079(iVar9);
		                                            }
		                                            iVar9 = *(int *)(*(int *)(iVar9 + 0x60) + 4);
		                                            if ((*(byte *)(iVar9 + 0xbd) & 1) == 0) {
		                                              iVar9 = func_ii_1079(iVar9);
		                                            }
		                                            iVar10 = *piVar12;
		                                            if (*(ushort *)(iVar10 + 0xb6) != 0) {
		                                              uVar2 = 0;
		                                              do {
		                                                if (iVar9 == *(int *)(*(int *)(iVar10 + 0x58) +
		                                                                     uVar2 * 8)) {
		                                                  puVar7 = (uint *)(*(int *)(*(int *)(iVar10 + 0x58)
		                                                                             + uVar2 * 8 + 4) * 8 +
		                                                                    iVar10 + 0xd0);
		                                                  goto code_r0x810a372d;
		                                                }
		                                                uVar2 = uVar2 + 1;
		                                              } while (*(ushort *)(iVar10 + 0xb6) != uVar2);
		                                            }
		                                            puVar7 = (uint *)func_ii_1080(piVar12,iVar9,2);
		code_r0x810a372d:
		                                            (**(code **)((ulonglong)*puVar7 * 4))
		                                                      (piVar12,uVar3,puVar7[1]);
		                                            return;
		                                          }
		                                        }
		code_r0x810a35e9:
		                                        DAT_ram_009d3e38 = 0;
		                                        uVar8 = import::env::__cxa_find_matching_catch_3
		                                                          (&DAT_ram_0072c9c8);
		                                        goto code_r0x810a374f;
		                                      }
		                                    }
		                                    DAT_ram_009d3e38 = 0;
		                                    uVar8 = import::env::__cxa_find_matching_catch_3
		                                                      (&DAT_ram_0072c9c8);
		                                    goto code_r0x810a374f;
		                                  }
		                                }
		                                else {
		                                  if (((uint)*(byte *)(UnityEngine_MonoBehaviour_TypeInfo + 0xb8) <=
		                                       (uint)*(byte *)(*piVar12 + 0xb8)) &&
		                                     (*(int *)(*(int *)(*piVar12 + 100) +
		                                               (uint)*(byte *)(UnityEngine_MonoBehaviour_TypeInfo +
		                                                              0xb8) * 4 + -4) ==
		                                      UnityEngine_MonoBehaviour_TypeInfo)) goto code_r0x810a341c;
		                                  DAT_ram_009d3e38 = 0;
		                                  import::env::invoke_vii
		                                            (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x183
		                                             ,piVar12,UnityEngine_MonoBehaviour_TypeInfo);
		                                  if (DAT_ram_009d3e38 != 1) goto code_r0x810a388c;
		                                }
		                                DAT_ram_009d3e38 = 0;
		                                uVar8 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                              }
		                            }
		                            goto code_r0x810a374f;
		                          }
		                        }
		                        DAT_ram_009d3e38 = 0;
		                        uVar8 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                        goto code_r0x810a374f;
		                      }
		                    }
		                    DAT_ram_009d3e38 = 0;
		                    uVar8 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                    goto code_r0x810a374f;
		                  }
		                }
		                DAT_ram_009d3e38 = 0;
		                uVar8 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                goto code_r0x810a374f;
		              }
		              DAT_ram_009d3e38 = 0;
		              iVar11 = import::env::invoke_iii
		                                 (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1a,iVar10,
		                                  *(undefined4 *)(*piVar12 + 0x20));
		              if (DAT_ram_009d3e38 != 1) {
		                if (iVar11 != 0) goto code_r0x810a316b;
		                DAT_ram_009d3e38 = 0;
		                uVar8 = import::env::invoke_i
		                                  (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1b);
		                if (DAT_ram_009d3e38 != 1) {
		                  DAT_ram_009d3e38 = 0;
		                  import::env::invoke_vii(0x41b,uVar8,0);
		                  if (DAT_ram_009d3e38 != 1) goto code_r0x810a388c;
		                }
		              }
		            }
		            DAT_ram_009d3e38 = 0;
		            uVar8 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          }
		        }
		      }
		    }
		    else {
		      sVar1 = local_8._4_2_;
		      iVar10 = *(int *)(
		                       Method_Cysharp_Threading_Tasks_UniTask_Awaiter_ValueTuple_bool__string___GetResult__
		                       + 0x10);
		      if ((*(byte *)(iVar10 + 0xbd) & 1) == 0) {
		        DAT_ram_009d3e38 = 0;
		        iVar10 = import::env::invoke_ii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x17,iVar10);
		        if (DAT_ram_009d3e38 != 1) goto code_r0x810a2e6e;
		      }
		      else {
		code_r0x810a2e6e:
		        iVar10 = *(int *)(*(int *)(iVar10 + 0x60) + 0x14);
		        if ((*(byte *)(iVar10 + 0xbd) & 1) == 0) {
		          DAT_ram_009d3e38 = 0;
		          iVar10 = import::env::invoke_ii
		                             (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x17,iVar10);
		          if (DAT_ram_009d3e38 == 1) goto code_r0x810a373d;
		        }
		        iVar11 = *piVar12;
		        if (*(ushort *)(iVar11 + 0xb6) != 0) {
		          uVar2 = 0;
		          do {
		            if (iVar10 == *(int *)(*(int *)(iVar11 + 0x58) + uVar2 * 8)) {
		              puVar4 = (undefined4 *)
		                       (iVar11 + *(int *)(*(int *)(iVar11 + 0x58) + uVar2 * 8 + 4) * 8 + 0xc0);
		              goto code_r0x810a2f3f;
		            }
		            uVar2 = uVar2 + 1;
		          } while (*(ushort *)(iVar11 + 0xb6) != uVar2);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar4 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar12,iVar10,0)
		        ;
		        if (DAT_ram_009d3e38 != 1) {
		code_r0x810a2f3f:
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_viiii(*puVar4,&local_40,piVar12,(int)sVar1,puVar4[1]);
		          iVar10 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          uVar8 = uStack_3c;
		          if (iVar10 != 1) goto code_r0x810a2f91;
		        }
		      }
		code_r0x810a373d:
		      DAT_ram_009d3e38 = 0;
		      uVar8 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    }
		  }
		  else {
		    uVar2 = 0;
		    piVar12 = (int *)param1[4];
		    iVar10 = *piVar12;
		    if (*(ushort *)(iVar10 + 0xb6) != 0) {
		      do {
		        if (Core_Animations_IGameAnimation_TypeInfo == *(int *)(*(int *)(iVar10 + 0x58) + uVar2 * 8)
		           ) {
		          puVar4 = (undefined4 *)
		                   (*(int *)(*(int *)(iVar10 + 0x58) + uVar2 * 8 + 4) * 8 + iVar10 + 0xf0);
		          goto code_r0x810a291d;
		        }
		        uVar2 = uVar2 + 1;
		      } while (*(ushort *)(iVar10 + 0xb6) != uVar2);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar4 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar12,
		                        Core_Animations_IGameAnimation_TypeInfo,6);
		    if (DAT_ram_009d3e38 != 1) {
		code_r0x810a291d:
		      DAT_ram_009d3e38 = 0;
		      uVar8 = import::env::invoke_iii(*puVar4,piVar12,puVar4[1]);
		      if (DAT_ram_009d3e38 != 1) {
		        DAT_ram_009d3e38 = 0;
		        iVar11 = import::env::invoke_iiii
		                           (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x5f,uVar8,param1 + 8,
		                            Method_UnityEngine_Component_TryGetComponent_IHasSkeletonDataAsset___);
		        iVar10 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar10 == 1) {
		          uVar8 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x810a374f;
		        }
		        uVar3 = 0;
		        if (iVar11 == 0) goto code_r0x810a366b;
		        uVar2 = 0;
		        iVar10 = param1[5];
		        piVar12 = (int *)param1[8];
		        iVar11 = *piVar12;
		        if (*(ushort *)(iVar11 + 0xb6) != 0) {
		          do {
		            if (Spine_Unity_IHasSkeletonDataAsset_TypeInfo ==
		                *(int *)(*(int *)(iVar11 + 0x58) + uVar2 * 8)) {
		              puVar4 = (undefined4 *)
		                       (iVar11 + *(int *)(*(int *)(iVar11 + 0x58) + uVar2 * 8 + 4) * 8 + 0xc0);
		              goto code_r0x810a2a55;
		            }
		            uVar2 = uVar2 + 1;
		          } while (*(ushort *)(iVar11 + 0xb6) != uVar2);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar4 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar12,
		                            Spine_Unity_IHasSkeletonDataAsset_TypeInfo,0);
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x810a2d9b:
		          DAT_ram_009d3e38 = 0;
		          uVar8 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        }
		        else {
		code_r0x810a2a55:
		          DAT_ram_009d3e38 = 0;
		          uVar8 = import::env::invoke_iii(*puVar4,piVar12,puVar4[1]);
		          if (DAT_ram_009d3e38 == 1) goto code_r0x810a2d9b;
		          DAT_ram_009d3e38 = 0;
		          uVar8 = import::env::invoke_iii
		                            (s_struct_Uniforms___color__array<v_ram_00000aff + 0x215,uVar8,0);
		          iVar11 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar11 == 1) {
		            uVar8 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          }
		          else {
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_viiiii
		                      (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x4e,&local_40,iVar10,uVar8
		                       ,param1[6],0);
		            iVar10 = DAT_ram_009d3e38;
		            DAT_ram_009d3e38 = 0;
		            if (iVar10 == 1) {
		              uVar8 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            }
		            else {
		              local_18 = local_38;
		              local_20 = CONCAT44(uStack_3c,local_40);
		              DAT_ram_009d3e38 = 0;
		              import::env::invoke_viii
		                        (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x4f,&local_40,&local_20,
		                         Method_Cysharp_Threading_Tasks_UniTask_string__SuppressCancellationThrow__)
		              ;
		              iVar10 = DAT_ram_009d3e38;
		              DAT_ram_009d3e38 = 0;
		              if (iVar10 == 1) {
		                uVar8 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		              }
		              else {
		                local_28 = CONCAT44(uStack_34,local_38);
		                local_30 = CONCAT44(uStack_3c,local_40);
		                if ((*(byte *)(*(int *)(
		                                       Method_Cysharp_Threading_Tasks_UniTask_ValueTuple_bool__string___GetAwaiter__
		                                       + 0x10) + 0xbd) & 1) == 0) {
		                  DAT_ram_009d3e38 = 0;
		                  import::env::invoke_ii
		                            (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x17,
		                             *(int *)(
		                                     Method_Cysharp_Threading_Tasks_UniTask_ValueTuple_bool__string___GetAwaiter__
		                                     + 0x10));
		                  iVar10 = DAT_ram_009d3e38;
		                  DAT_ram_009d3e38 = 0;
		                  if (iVar10 == 1) {
		                    uVar8 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                    goto code_r0x810a374f;
		                  }
		                }
		                local_8 = local_28;
		                local_10 = local_30;
		                if ((*(byte *)(*(int *)(
		                                       Method_Cysharp_Threading_Tasks_UniTask_Awaiter_ValueTuple_bool__string___get_IsCompleted__
		                                       + 0x10) + 0xbd) & 1) == 0) {
		                  DAT_ram_009d3e38 = 0;
		                  import::env::invoke_ii
		                            (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x17,
		                             *(int *)(
		                                     Method_Cysharp_Threading_Tasks_UniTask_Awaiter_ValueTuple_bool__string___get_IsCompleted__
		                                     + 0x10));
		                  if (DAT_ram_009d3e38 != 1) goto code_r0x810a2c01;
		                }
		                else {
		code_r0x810a2c01:
		                  if (DAT_ram_00a60081 == '\0') {
		                    DAT_ram_009d3e38 = 0;
		                    import::env::invoke_vi(0x7ff,&Cysharp_Threading_Tasks_IUniTaskSource_TypeInfo);
		                    if (DAT_ram_009d3e38 == 1) goto code_r0x810a2dcd;
		                    DAT_ram_00a60081 = '\x01';
		                  }
		                  DAT_ram_009d3e38 = 0;
		                  piVar12 = (int *)local_10;
		                  if ((int *)local_10 == (int *)0x0) goto code_r0x810a2e12;
		                  uVar2 = 0;
		                  sVar1 = local_8._4_2_;
		                  iVar10 = *(int *)local_10;
		                  if (*(ushort *)(iVar10 + 0xb6) != 0) {
		                    do {
		                      if (Cysharp_Threading_Tasks_IUniTaskSource_TypeInfo ==
		                          *(int *)(*(int *)(iVar10 + 0x58) + uVar2 * 8)) {
		                        puVar4 = (undefined4 *)
		                                 (iVar10 + *(int *)(*(int *)(iVar10 + 0x58) + uVar2 * 8 + 4) * 8 +
		                                 0xc0);
		                        goto code_r0x810a2cef;
		                      }
		                      uVar2 = uVar2 + 1;
		                    } while (*(ushort *)(iVar10 + 0xb6) != uVar2);
		                  }
		                  DAT_ram_009d3e38 = 0;
		                  puVar4 = (undefined4 *)
		                           import::env::invoke_iiii
		                                     (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,
		                                      (int *)local_10,
		                                      Cysharp_Threading_Tasks_IUniTaskSource_TypeInfo,0);
		                  if (DAT_ram_009d3e38 != 1) {
		code_r0x810a2cef:
		                    DAT_ram_009d3e38 = 0;
		                    iVar11 = import::env::invoke_iiii(*puVar4,piVar12,(int)sVar1,puVar4[1]);
		                    iVar10 = DAT_ram_009d3e38;
		                    DAT_ram_009d3e38 = 0;
		                    if (iVar10 != 1) {
		                      if (iVar11 != 0) goto code_r0x810a2e0d;
		                      *param1 = 0;
		                      *(undefined8 *)(param1 + 9) = local_10;
		                      *(undefined8 *)(param1 + 0xb) = local_8;
		                      DAT_ram_009d3e38 = 0;
		                      import::env::invoke_viiii
		                                (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x50,param1 + 1,
		                                 &local_10,param1,
		                                 Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_bool__AwaitUnsafeOnCompleted_UniTask_Awaiter_ValueTuple_bool__string____GameAnimationSkinResolver__TryResolve_d__4___
		                                );
		                      iVar9 = DAT_ram_009d3e38;
		                      DAT_ram_009d3e38 = 0;
		                      if (iVar9 != 1) {
		                        DAT_ram_009d3e38 = 0;
		                        return;
		                      }
		                      uVar8 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                      goto code_r0x810a374f;
		                    }
		                  }
		                }
		code_r0x810a2dcd:
		                DAT_ram_009d3e38 = 0;
		                uVar8 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		              }
		            }
		          }
		        }
		        goto code_r0x810a374f;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar8 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  }
		code_r0x810a374f:
		  iVar9 = global_1;
		  iVar10 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar9 == iVar10) {
		    puVar4 = (undefined4 *)import::env::__cxa_begin_catch(uVar8);
		    DAT_ram_009d3e38 = 0;
		    uVar8 = import::env::invoke_ii
		                      (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1c,
		                       &System_Exception_TypeInfo);
		    if (DAT_ram_009d3e38 != 1) {
		      DAT_ram_009d3e38 = 0;
		      iVar10 = import::env::invoke_iii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1d,uVar8,
		                          *(undefined4 *)*puVar4);
		      iVar9 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar9 != 1) {
		        if (iVar10 != 0) {
		          uVar13 = *puVar4;
		          import::env::__cxa_end_catch();
		          param1[8] = 0;
		          *param1 = -2;
		          uVar8 = unnamed_function_2232
		                            (&
		                             Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_bool__SetException__
		                            );
		          Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_UniTask___Create
		                    (param1 + 1,uVar13,uVar8);
		          return;
		        }
		        param2_00 = (undefined4 *)unnamed_function_951(4);
		        *param2_00 = *puVar4;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1e,param2_00,
		                   &DAT_ram_0072c9c8,0);
		        if (DAT_ram_009d3e38 != 1) {
		code_r0x810a388c:
		          do {
		            halt_trap();
		          } while( true );
		        }
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar8 = import::env::__cxa_find_matching_catch_2();
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar9 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar9 == 1) {
		      import::env::__cxa_find_matching_catch_3(0);
		      unnamed_function_937();
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  import::env::__resumeException(uVar8);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x040004E0 RID: 1248
		[Token(Token = "0x40004E0")]
		[FieldOffset(Offset = "0x20")]
		private GameObject _skinApr;
	}
}
