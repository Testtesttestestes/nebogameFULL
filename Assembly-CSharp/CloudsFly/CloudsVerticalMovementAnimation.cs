using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.U2D;

namespace CloudsFly
{
	// Token: 0x020012FF RID: 4863
	[Token(Token = "0x20012FF")]
	public class CloudsVerticalMovementAnimation : MonoBehaviour
	{
		// Token: 0x060073B7 RID: 29623 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60073B7")]
		[Address(RVA = "0xBD9E", Offset = "0xBD9E", VA = "0xBD9E")]
		private void OnDestroy()
		{
		/* --- GHIDRA: <Animate>b__7_0 ---
		void CloudsFly_CloudsVerticalMovementAnimation___Animate_b__7_0
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  int iVar1;
		  int param3_00;
		  undefined4 param3_01;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a59689 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_CloudsFly_CloudsWorldObjectEngine_OnReleaseCloud__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Utils_Cache_GameObjectPool_TiledCloudSpriteWorldObject___ctor__);
		    Mono_Security_ASN1__get_Item(&Utils_Cache_GameObjectPool_TiledCloudSpriteWorldObject__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_TiledCloudSpriteWorldObject__Clear__);
		    Mono_Security_ASN1__get_Item
		              (&Utils_Cache_ObjectPool_ResetPoolObjectDelegate_TiledCloudSpriteWorldObject__TypeInfo
		              );
		    DAT_ram_00a59689 = '\x01';
		  }
		  *(int *)(param1 + 0x28) = param2;
		  iVar1 = *(int *)(param1 + 0x2c);
		  param3_00 = *(int *)(iVar1 + 0xc);
		  *(undefined4 *)(iVar1 + 0xc) = 0;
		  *(int *)(iVar1 + 0x10) = *(int *)(iVar1 + 0x10) + 1;
		  if (0 < param3_00) {
		    func_ii_2064(*(undefined4 *)(iVar1 + 8),0,param3_00,0);
		    param2 = *(int *)(param1 + 0x28);
		  }
		  param3_01 = *(undefined4 *)(param2 + 0x44);
		  param2_00 = *(undefined4 *)(param2 + 0x48);
		  param1_00 = unnamed_function_1417
		                        (
		                        Utils_Cache_ObjectPool_ResetPoolObjectDelegate_TiledCloudSpriteWorldObject__TypeInfo
		                        );
		  Core_Cache_AbstractCache_RequestInvoker___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType____ctor
		            (param1_00,param1,Method_CloudsFly_CloudsWorldObjectEngine_OnReleaseCloud__,0);
		  param1_01 = unnamed_function_1417
		                        (Utils_Cache_GameObjectPool_TiledCloudSpriteWorldObject__TypeInfo);
		  Utils_Cache_GameObjectPoolRestricted_object___CreateInstance
		            (param1_01,param2_00,param3_01,param1_00,
		             Method_Utils_Cache_GameObjectPool_TiledCloudSpriteWorldObject___ctor__);
		  *(undefined4 *)(param1 + 0x30) = param1_01;
		  CloudsFly_CloudsWorldObjectEngine__OnReleaseCloud(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x060073B8 RID: 29624 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60073B8")]
		[Address(RVA = "0xBD9F", Offset = "0xBD9F", VA = "0xBD9F")]
		private void Awake()
		{
		/* --- GHIDRA: Awake ---
		void CloudsFly_CloudsVerticalMovementAnimation__Awake(int param1,int param2,undefined4 param3)
		
		{
		  float4 fVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int iVar5;
		  undefined8 local_40;
		  float4 local_38;
		  undefined8 local_30;
		  float4 local_28;
		  float4 local_24;
		  float4 local_20;
		  float4 local_1c;
		  float4 local_18;
		  float4 local_14;
		  float4 local_10;
		  float4 local_c;
		  float4 local_4;
		  
		  if (DAT_ram_00a59687 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_CloudsFly_CloudsVerticalMovementAnimation__Animate_b__7_0__);
		    Mono_Security_ASN1__get_Item(&DG_Tweening_TweenCallback_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_OnComplete_TweenerCore_Vector3__Vector3__VectorOptions____
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_SetDelay_TweenerCore_Vector3__Vector3__VectorOptions____
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_SetEase_TweenerCore_Vector3__Vector3__VectorOptions____
		              );
		    DAT_ram_00a59687 = '\x01';
		  }
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x10),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar2,1,0);
		  uVar2 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                    (*(undefined4 *)(param1 + 0x10),0);
		  uVar3 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                    (*(undefined4 *)(param1 + 0x10),0);
		  UnityEngine_Transform___ctor(&local_c,uVar3,0);
		  fVar1 = local_c;
		  iVar4 = *(int *)(param1 + 0x14);
		  uVar3 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                    (*(undefined4 *)(param1 + 0x10),0);
		  UnityEngine_Transform___ctor(&local_c,uVar3,0);
		  local_10 = local_4;
		  local_28 = local_4;
		  if (param2 == 0) {
		    iVar4 = -iVar4;
		  }
		  local_14 = (float4)(float)iVar4;
		  local_18 = fVar1;
		  local_30 = CONCAT44(local_14,fVar1);
		  Gameplay_Isles_User_View_IsleAccountMarkersLayerView__GetView(uVar2,&local_30,0);
		  uVar2 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                    (*(undefined4 *)(param1 + 0x10),0);
		  uVar3 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                    (*(undefined4 *)(param1 + 0x10),0);
		  UnityEngine_Transform___ctor(&local_c,uVar3,0);
		  iVar5 = *(int *)(param1 + 0x14);
		  uVar3 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                    (*(undefined4 *)(param1 + 0x10),0);
		  UnityEngine_Transform___ctor(&local_c,uVar3,0);
		  local_1c = local_4;
		  local_38 = local_4;
		  iVar4 = -iVar5;
		  if (param2 == 0) {
		    iVar4 = iVar5;
		  }
		  local_20 = (float4)(float)iVar4;
		  local_24 = local_c;
		  local_40 = CONCAT44(local_20,local_c);
		  uVar2 = DG_Tweening_ShortcutExtensions__DOMoveZ(uVar2,&local_40,*(float *)(param1 + 0x18),0,0);
		  uVar2 = DG_Tweening_DOTweenModuleUI__DOFade
		                    (uVar2,*(float *)(param1 + 0x1c),
		                     Method_DG_Tweening_TweenSettingsExtensions_SetDelay_TweenerCore_Vector3__Vector3__VectorOptions____
		                    );
		  uVar2 = DG_Tweening_ShortcutExtensions__DOScale
		                    (uVar2,*(undefined4 *)(param1 + 0x20),
		                     Method_DG_Tweening_TweenSettingsExtensions_SetEase_TweenerCore_Vector3__Vector3__VectorOptions____
		                    );
		  uVar3 = unnamed_function_1417(DG_Tweening_TweenCallback_TypeInfo);
		  DG_Tweening_Color2__op_Multiply
		            (uVar3,param1,Method_CloudsFly_CloudsVerticalMovementAnimation__Animate_b__7_0__,0);
		  DG_Tweening_TweenSettingsExtensions__From___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType____Il2CppFullySharedGenericStructType_
		            (uVar2,uVar3,
		             Method_DG_Tweening_TweenSettingsExtensions_OnComplete_TweenerCore_Vector3__Vector3__VectorOptions____
		            );
		  return;
		}
		*/

		}

		// Token: 0x060073B9 RID: 29625 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60073B9")]
		[Address(RVA = "0xBDA0", Offset = "0xBDA0", VA = "0xBDA0")]
		public void Animate(bool toUp)
		{
		/* --- GHIDRA: Animate ---
		void CloudsFly_CloudsVerticalMovementAnimation__Animate
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 *puVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int *piVar5;
		  uint *puVar6;
		  int iVar7;
		  int *piVar8;
		  int local_1c;
		  int **local_18;
		  int *local_14;
		  int local_10;
		  undefined4 local_c;
		  undefined4 local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a59688 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_TryGetComponent_SpriteRenderer___);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Transform_TypeInfo);
		    DAT_ram_00a59688 = '\x01';
		  }
		  local_8 = 0;
		  local_c = 0;
		  local_10 = 0;
		  local_4 = (int *)UnityEngine_Transform__set_hasChanged(*(undefined4 *)(param1 + 0x10),0);
		  local_14 = &local_10;
		  local_1c = 0;
		  local_18 = &local_4;
		  do {
		    do {
		      do {
		        piVar5 = local_4;
		        iVar7 = *local_4;
		        if (*(ushort *)(iVar7 + 0xb6) != 0) {
		          uVar1 = 0;
		          do {
		            piVar8 = (int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8);
		            if (System_Collections_IEnumerator_TypeInfo == *piVar8) {
		              puVar2 = (undefined4 *)(iVar7 + piVar8[1] * 8 + 0xc0);
		              goto code_r0x81048d1c;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar2 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                            System_Collections_IEnumerator_TypeInfo,0);
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x81048d60:
		          DAT_ram_009d3e38 = 0;
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x81049013;
		        }
		code_r0x81048d1c:
		        DAT_ram_009d3e38 = 0;
		        iVar7 = import::env::invoke_iii(*puVar2,piVar5,puVar2[1]);
		        piVar5 = local_4;
		        if (DAT_ram_009d3e38 == 1) goto code_r0x81048d60;
		        if (iVar7 == 0) goto code_r0x8104905c;
		        iVar7 = *local_4;
		        if (*(ushort *)(iVar7 + 0xb6) != 0) {
		          uVar1 = 0;
		          do {
		            piVar8 = (int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8);
		            if (System_Collections_IEnumerator_TypeInfo == *piVar8) {
		              puVar2 = (undefined4 *)(piVar8[1] * 8 + iVar7 + 200);
		              goto code_r0x81048e0b;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar2 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                            System_Collections_IEnumerator_TypeInfo,1);
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x81048ef6:
		          DAT_ram_009d3e38 = 0;
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x81049013;
		        }
		code_r0x81048e0b:
		        DAT_ram_009d3e38 = 0;
		        piVar5 = (int *)import::env::invoke_iii(*puVar2,piVar5,puVar2[1]);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x81048ef6;
		        if (piVar5 != (int *)0x0) {
		          if (((uint)*(byte *)(*piVar5 + 0xb8) <
		               (uint)*(byte *)(UnityEngine_Transform_TypeInfo + 0xb8)) ||
		             (*(int *)(*(int *)(*piVar5 + 100) +
		                       (uint)*(byte *)(UnityEngine_Transform_TypeInfo + 0xb8) * 4 + -4) !=
		              UnityEngine_Transform_TypeInfo)) {
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_vii
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x183,piVar5,
		                       UnityEngine_Transform_TypeInfo);
		            iVar7 = DAT_ram_009d3e38;
		            DAT_ram_009d3e38 = 0;
		            if (iVar7 != 1) {
		              do {
		                halt_trap();
		              } while( true );
		            }
		            uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x81049013;
		          }
		        }
		        DAT_ram_009d3e38 = 0;
		        iVar4 = import::env::invoke_iiii
		                          (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x5f,piVar5,&local_8,
		                           Method_UnityEngine_Component_TryGetComponent_SpriteRenderer___);
		        iVar7 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar7 == 1) {
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x81049013;
		        }
		      } while (iVar4 == 0);
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::invoke_iii
		                        (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x346,local_8,0);
		      iVar7 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar7 == 1) {
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x81049013;
		      }
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::invoke_iii
		                        (s_struct_Uniforms___color__array<v_ram_00000aff + 0x215,uVar3,0);
		      iVar7 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar7 == 1) {
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x81049013;
		      }
		      DAT_ram_009d3e38 = 0;
		      iVar4 = import::env::invoke_iiiii
		                        (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x347,param2,uVar3,
		                         &local_c,0);
		      iVar7 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar7 == 1) {
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x81049013;
		      }
		    } while (iVar4 == 0);
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x348,local_8,local_c,0);
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar7 != 1);
		  uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x81049013:
		  iVar7 = global_1;
		  iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar7 == iVar4) {
		    piVar5 = (int *)import::env::__cxa_begin_catch(uVar3);
		    local_1c = *piVar5;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar7 != 1) {
		code_r0x8104905c:
		      DAT_ram_009d3e38 = 0;
		      local_10 = func_ii_1082(local_4,System_IDisposable_TypeInfo);
		      piVar5 = (int *)*local_14;
		      if (piVar5 != (int *)0x0) {
		        iVar7 = *piVar5;
		        if (*(ushort *)(iVar7 + 0xb6) != 0) {
		          uVar1 = 0;
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		              puVar6 = (uint *)(iVar7 + *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x810490ec;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		        }
		        puVar6 = (uint *)func_ii_1080(piVar5,System_IDisposable_TypeInfo,0);
		code_r0x810490ec:
		        (**(code **)((ulonglong)*puVar6 * 4))(piVar5,puVar6[1]);
		      }
		      if (local_1c == 0) {
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(local_1c);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar3 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x349,&local_1c);
		  iVar7 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar7 == 1) {
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

		// Token: 0x060073BA RID: 29626 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60073BA")]
		[Address(RVA = "0xBDA1", Offset = "0xBDA1", VA = "0xBDA1")]
		public void SetAtlas(SpriteAtlas atlas)
		{
		/* --- GHIDRA: SetAtlas ---
		void CloudsFly_CloudsVerticalMovementAnimation__SetAtlas(int param1,undefined4 param2)
		
		{
		  *(undefined4 *)(param1 + 0x20) = 1;
		  UnityEngine_RectTransform__GetParentSize(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x060073BB RID: 29627 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60073BB")]
		[Address(RVA = "0xBDA2", Offset = "0xBDA2", VA = "0xBDA2")]
		public CloudsVerticalMovementAnimation()
		{
		}

		// Token: 0x04003C9B RID: 15515
		[Token(Token = "0x4003C9B")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Transform _cloudsContainer;

		// Token: 0x04003C9C RID: 15516
		[Token(Token = "0x4003C9C")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private int _distance;

		// Token: 0x04003C9D RID: 15517
		[Token(Token = "0x4003C9D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _duration;

		// Token: 0x04003C9E RID: 15518
		[Token(Token = "0x4003C9E")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float _delay;

		// Token: 0x04003C9F RID: 15519
		[Token(Token = "0x4003C9F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Ease _ease;
	}
}
