using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

namespace Gameplay.Combat.View.Tweens
{
	// Token: 0x02000930 RID: 2352
	[Token(Token = "0x2000930")]
	public class FromToSpriteRenderTweener : MonoBehaviour
	{
		// Token: 0x0600377C RID: 14204 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600377C")]
		[Address(RVA = "0x8769", Offset = "0x8769", VA = "0x8769")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_Combat_View_Tweens_FromToSpriteRenderTweener__OnDestroy(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a566c0 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_GameObject_GetComponent_SpriteRenderer___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a566c0 = '\x01';
		  }
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (param1,0);
		  uVar1 = func_ii_6601(uVar1,Method_UnityEngine_GameObject_GetComponent_SpriteRenderer___);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar2 = UnityEngine_Component__GetComponent_object_(uVar1,0);
		  if (iVar2 != 0) {
		    UnityEngine_SpriteRenderer__set_size(&local_10,uVar1,0);
		    *(undefined8 *)(param1 + 0x34) = local_8;
		    *(undefined8 *)(param1 + 0x2c) = local_10;
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600377D RID: 14205 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600377D")]
		[Address(RVA = "0x876A", Offset = "0x876A", VA = "0x876A")]
		private void Awake()
		{
		/* --- GHIDRA: Awake ---
		void Gameplay_Combat_View_Tweens_FromToSpriteRenderTweener__Awake(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 *puVar2;
		  int iVar3;
		  int *piVar4;
		  uint *puVar5;
		  int iVar6;
		  int param2_00;
		  undefined8 uVar7;
		  int *piVar8;
		  uint uVar9;
		  int local_14;
		  int **local_10;
		  int *local_c;
		  int local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a566c1 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_GameObject_AddComponent_FromToSpriteRenderTweener___);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_GameObject_GetComponent_SpriteRenderer___);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_FromToSpriteRenderTweener__Add__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Transform_TypeInfo);
		    DAT_ram_00a566c1 = '\x01';
		  }
		  local_4 = (int *)0x0;
		  local_8 = 0;
		  if (*(char *)(param1 + 0x10) == '\0') {
		code_r0x80c664d3:
		    func_ii_6604(param1,0);
		    return;
		  }
		  uVar1 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                    (param1,0);
		  local_4 = (int *)UnityEngine_Transform__set_hasChanged(uVar1,0);
		  local_c = &local_8;
		  local_14 = 0;
		  local_10 = &local_4;
		code_r0x80c65f51:
		  do {
		    do {
		      piVar4 = local_4;
		      iVar6 = *local_4;
		      if (*(ushort *)(iVar6 + 0xb6) != 0) {
		        uVar9 = 0;
		        do {
		          piVar8 = (int *)(*(int *)(iVar6 + 0x58) + uVar9 * 8);
		          if (System_Collections_IEnumerator_TypeInfo == *piVar8) {
		            puVar2 = (undefined4 *)(iVar6 + piVar8[1] * 8 + 0xc0);
		            goto code_r0x80c65fe5;
		          }
		          uVar9 = uVar9 + 1;
		        } while (*(ushort *)(iVar6 + 0xb6) != uVar9);
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar2 = (undefined4 *)
		               import::env::invoke_iiii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                          System_Collections_IEnumerator_TypeInfo,0);
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x80c663d0:
		        DAT_ram_009d3e38 = 0;
		        uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80c663d8;
		      }
		code_r0x80c65fe5:
		      DAT_ram_009d3e38 = 0;
		      iVar6 = import::env::invoke_iii(*puVar2,piVar4,puVar2[1]);
		      piVar4 = local_4;
		      if (DAT_ram_009d3e38 == 1) goto code_r0x80c663d0;
		      if (iVar6 == 0) goto code_r0x80c66421;
		      iVar6 = *local_4;
		      if (*(ushort *)(iVar6 + 0xb6) != 0) {
		        uVar9 = 0;
		        do {
		          piVar8 = (int *)(*(int *)(iVar6 + 0x58) + uVar9 * 8);
		          if (System_Collections_IEnumerator_TypeInfo == *piVar8) {
		            puVar2 = (undefined4 *)(piVar8[1] * 8 + iVar6 + 200);
		            goto code_r0x80c660d0;
		          }
		          uVar9 = uVar9 + 1;
		        } while (*(ushort *)(iVar6 + 0xb6) != uVar9);
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar2 = (undefined4 *)
		               import::env::invoke_iiii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                          System_Collections_IEnumerator_TypeInfo,1);
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x80c66337:
		        DAT_ram_009d3e38 = 0;
		        uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80c663d8;
		      }
		code_r0x80c660d0:
		      DAT_ram_009d3e38 = 0;
		      piVar4 = (int *)import::env::invoke_iii(*puVar2,piVar4,puVar2[1]);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x80c66337;
		      if (piVar4 != (int *)0x0) {
		        if (((uint)*(byte *)(*piVar4 + 0xb8) <
		             (uint)*(byte *)(UnityEngine_Transform_TypeInfo + 0xb8)) ||
		           (*(int *)(*(int *)(*piVar4 + 100) +
		                     (uint)*(byte *)(UnityEngine_Transform_TypeInfo + 0xb8) * 4 + -4) !=
		            UnityEngine_Transform_TypeInfo)) {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vii
		                    (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x183,piVar4,
		                     UnityEngine_Transform_TypeInfo);
		          iVar6 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar6 != 1) {
		            do {
		              halt_trap();
		            } while( true );
		          }
		          uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80c663d8;
		        }
		      }
		      DAT_ram_009d3e38 = 0;
		      uVar1 = import::env::invoke_iii
		                        (s_struct_Uniforms___color__array<v_ram_00000aff + 0x25c,piVar4,0);
		      iVar6 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar6 == 1) {
		        uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80c663d8;
		      }
		      DAT_ram_009d3e38 = 0;
		      uVar1 = import::env::invoke_iii
		                        (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x202,uVar1,
		                         Method_UnityEngine_GameObject_GetComponent_SpriteRenderer___);
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x80c66355:
		        DAT_ram_009d3e38 = 0;
		        uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80c663d8;
		      }
		      if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vi
		                  (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                   UnityEngine_Object_TypeInfo);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80c66355;
		      }
		      DAT_ram_009d3e38 = 0;
		      iVar3 = import::env::invoke_iii
		                        (s_struct_Uniforms___color__array<v_ram_000013c7 + 0x268,uVar1,0);
		      iVar6 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar6 == 1) {
		        uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80c663d8;
		      }
		    } while (iVar3 == 0);
		    DAT_ram_009d3e38 = 0;
		    uVar1 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x25c,piVar4,0);
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 == 1) {
		      uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80c663d8;
		    }
		    DAT_ram_009d3e38 = 0;
		    iVar3 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x203,uVar1,
		                       Method_UnityEngine_GameObject_AddComponent_FromToSpriteRenderTweener___);
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 == 1) {
		      uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80c663d8;
		    }
		    *(undefined1 *)(iVar3 + 0x10) = *(undefined1 *)(param1 + 0x10);
		    uVar7 = *(undefined8 *)(param1 + 0x14);
		    *(undefined8 *)(iVar3 + 0x1c) = *(undefined8 *)(param1 + 0x1c);
		    *(undefined8 *)(iVar3 + 0x14) = uVar7;
		    *(undefined4 *)(iVar3 + 0x24) = *(undefined4 *)(param1 + 0x24);
		    *(undefined4 *)(iVar3 + 0x28) = *(undefined4 *)(param1 + 0x28);
		    iVar6 = Method_System_Collections_Generic_List_FromToSpriteRenderTweener__Add__;
		    param2_00 = *(int *)(param1 + 0x3c);
		    *(int *)(param2_00 + 0x10) = *(int *)(param2_00 + 0x10) + 1;
		    uVar9 = *(uint *)(param2_00 + 0xc);
		    if (uVar9 < *(uint *)(*(int *)(param2_00 + 8) + 0xc)) {
		      *(uint *)(param2_00 + 0xc) = uVar9 + 1;
		      *(int *)(*(int *)(param2_00 + 8) + uVar9 * 4 + 0x10) = iVar3;
		      goto code_r0x80c65f51;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,param2_00,iVar3,
		               *(undefined4 *)(*(int *)(*(int *)(iVar6 + 0x10) + 0x60) + 0x38));
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar6 != 1);
		  uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80c663d8:
		  iVar6 = global_1;
		  iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar6 == iVar3) {
		    piVar4 = (int *)import::env::__cxa_begin_catch(uVar1);
		    local_14 = *piVar4;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 != 1) {
		code_r0x80c66421:
		      DAT_ram_009d3e38 = 0;
		      iVar6 = func_ii_1082(*local_10,System_IDisposable_TypeInfo);
		      *local_c = iVar6;
		      piVar4 = (int *)*local_c;
		      if (piVar4 != (int *)0x0) {
		        iVar6 = *piVar4;
		        if (*(ushort *)(iVar6 + 0xb6) != 0) {
		          uVar9 = 0;
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar9 * 8)) {
		              puVar5 = (uint *)(iVar6 + *(int *)(*(int *)(iVar6 + 0x58) + uVar9 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x80c664bb;
		            }
		            uVar9 = uVar9 + 1;
		          } while (*(ushort *)(iVar6 + 0xb6) != uVar9);
		        }
		        puVar5 = (uint *)func_ii_1080(piVar4,System_IDisposable_TypeInfo,0);
		code_r0x80c664bb:
		        (**(code **)((ulonglong)*puVar5 * 4))(piVar4,puVar5[1]);
		      }
		      if (local_14 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(local_14);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      goto code_r0x80c664d3;
		    }
		    uVar1 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_000017c8 + 0x204,&local_14);
		  iVar6 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar6 == 1) {
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__resumeException(uVar1);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x0600377E RID: 14206 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600377E")]
		[Address(RVA = "0x876B", Offset = "0x876B", VA = "0x876B", Slot = "4")]
		protected virtual void Start()
		{
		/* --- GHIDRA: Start ---
		void Gameplay_Combat_View_Tweens_FromToSpriteRenderTweener__Start
		               (undefined4 param1,int param2,float param3,float param4,undefined4 param5)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined8 local_40;
		  undefined8 local_38;
		  undefined8 local_30;
		  undefined4 local_28;
		  float4 local_24;
		  undefined8 local_20;
		  undefined4 local_18;
		  undefined8 local_10;
		  undefined4 local_8;
		  
		  if (DAT_ram_00a566c3 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_SpriteRenderer___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_SetDelay_TweenerCore_Color__Color__ColorOptions____
		              );
		    DAT_ram_00a566c3 = '\x01';
		  }
		  uVar1 = func_ii_5677(param1,Method_UnityEngine_Component_GetComponent_SpriteRenderer___);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar2 = UnityEngine_TextCore_Text_TextElement__get_textAsset(uVar1,0,0);
		  if (iVar2 != 0) {
		    if (param4 <= 0.0) {
		      UnityEngine_SpriteRenderer__set_size(&local_20,uVar1,0);
		      local_8 = local_18;
		      local_10 = local_20;
		      local_24 = *(float4 *)(param2 + 0xc);
		      local_28 = local_18;
		      local_38 = CONCAT44(local_24,local_18);
		      local_30 = local_20;
		      local_40 = local_20;
		      UnityEngine_SpriteRenderer__get_color(uVar1,&local_40,0);
		    }
		    else {
		      uVar1 = DG_Tweening_DOTweenModuleSprite__DOColor(uVar1,*(float *)(param2 + 0xc),param4,0);
		      DG_Tweening_DOTweenModuleUI__DOFade
		                (uVar1,param3,
		                 Method_DG_Tweening_TweenSettingsExtensions_SetDelay_TweenerCore_Color__Color__ColorOptions____
		                );
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600377F RID: 14207 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600377F")]
		[Address(RVA = "0x19CD", Offset = "0x19CD", VA = "0x19CD")]
		public void Rollback()
		{
		}

		// Token: 0x06003780 RID: 14208 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003780")]
		[Address(RVA = "0x876C", Offset = "0x876C", VA = "0x876C")]
		public void Play(in Color toColor, float fadeDelay, float fadeDuration)
		{
		/* --- GHIDRA: Play ---
		void Gameplay_Combat_View_Tweens_FromToSpriteRenderTweener__Play(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a566c5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_FromToSpriteRenderTweener___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_List_FromToSpriteRenderTweener__TypeInfo);
		    DAT_ram_00a566c5 = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (System_Collections_Generic_List_FromToSpriteRenderTweener__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,Method_System_Collections_Generic_List_FromToSpriteRenderTweener___ctor__);
		  *(undefined4 *)(param1 + 0x3c) = param1_00;
		  UnityEngine_RectTransform__GetParentSize(param1,0);
		  return;
		}
		*/

		/* --- GHIDRA: Play ---
		void Gameplay_Combat_View_Tweens_FromToSpriteRenderTweener__Play(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a566c5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_FromToSpriteRenderTweener___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_List_FromToSpriteRenderTweener__TypeInfo);
		    DAT_ram_00a566c5 = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (System_Collections_Generic_List_FromToSpriteRenderTweener__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,Method_System_Collections_Generic_List_FromToSpriteRenderTweener___ctor__);
		  *(undefined4 *)(param1 + 0x3c) = param1_00;
		  UnityEngine_RectTransform__GetParentSize(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x06003781 RID: 14209 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003781")]
		[Address(RVA = "0x19CF", Offset = "0x19CF", VA = "0x19CF")]
		public void Play()
		{
		}

		// Token: 0x06003782 RID: 14210 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003782")]
		[Address(RVA = "0x876D", Offset = "0x876D", VA = "0x876D")]
		public FromToSpriteRenderTweener()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Combat_View_Tweens_FromToSpriteRenderTweener___ctor(int param1,undefined4 param2)
		
		{
		  Utils_TweenContainer__StopAllTweens(*(undefined4 *)(param1 + 0xd8),0);
		  return;
		}
		*/

		}

		// Token: 0x04001E9D RID: 7837
		[Token(Token = "0x4001E9D")]
		[FieldOffset(Offset = "0x10")]
		[FormerlySerializedAs("HandleChildrent")]
		public bool HandleChilds;

		// Token: 0x04001E9E RID: 7838
		[Token(Token = "0x4001E9E")]
		[FieldOffset(Offset = "0x14")]
		public Color FromColor;

		// Token: 0x04001E9F RID: 7839
		[Token(Token = "0x4001E9F")]
		[FieldOffset(Offset = "0x24")]
		[FormerlySerializedAs("_fadeDuration")]
		public float FadeDuration;

		// Token: 0x04001EA0 RID: 7840
		[Token(Token = "0x4001EA0")]
		[FieldOffset(Offset = "0x28")]
		[FormerlySerializedAs("_fadeDelay")]
		public float FadeDelay;

		// Token: 0x04001EA1 RID: 7841
		[Token(Token = "0x4001EA1")]
		[FieldOffset(Offset = "0x2C")]
		public Color ToColor;

		// Token: 0x04001EA2 RID: 7842
		[Token(Token = "0x4001EA2")]
		[FieldOffset(Offset = "0x3C")]
		public List<FromToSpriteRenderTweener> Childrent;
	}
}
