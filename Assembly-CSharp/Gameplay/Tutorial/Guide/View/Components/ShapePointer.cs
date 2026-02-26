using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Coffee.UISoftMask;
using Gameplay.Tutorial.Guide.Model;
using Gameplay.Tutorial.Guide.Model.Data.Config;
using Gameplay.Tutorial.Guide.Model.Shapes;
using Gameplay.Tutorial.Guide.View.Outline;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Tutorial.Guide.View.Components
{
	// Token: 0x02000476 RID: 1142
	[Token(Token = "0x2000476")]
	public class ShapePointer : MonoBehaviour
	{
		// Token: 0x170004B4 RID: 1204
		// (get) Token: 0x06001B06 RID: 6918 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170004B4")]
		public Overlap Overlap
		{
			[Token(Token = "0x6001B06")]
			[Address(RVA = "0x6C90", Offset = "0x6C90", VA = "0x6C90")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004B5 RID: 1205
		// (get) Token: 0x06001B07 RID: 6919 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170004B5")]
		public MaskingShape MaskingShape
		{
			[Token(Token = "0x6001B07")]
			[Address(RVA = "0x6C91", Offset = "0x6C91", VA = "0x6C91")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004B6 RID: 1206
		// (get) Token: 0x06001B08 RID: 6920 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001B09 RID: 6921 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004B6")]
		public GuideView GuideView
		{
			[Token(Token = "0x6001B08")]
			[Address(RVA = "0x6C92", Offset = "0x6C92", VA = "0x6C92")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001B09")]
			[Address(RVA = "0x6C93", Offset = "0x6C93", VA = "0x6C93")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170004B7 RID: 1207
		// (get) Token: 0x06001B0A RID: 6922 RVA: 0x00005B38 File Offset: 0x00003D38
		// (set) Token: 0x06001B0B RID: 6923 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004B7")]
		public Vector3 IdlePosition
		{
			[Token(Token = "0x6001B0A")]
			[Address(RVA = "0x6C94", Offset = "0x6C94", VA = "0x6C94")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6001B0B")]
			[Address(RVA = "0x6C95", Offset = "0x6C95", VA = "0x6C95")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170004B8 RID: 1208
		// (get) Token: 0x06001B0C RID: 6924 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170004B8")]
		public Image ShapeRender
		{
			[Token(Token = "0x6001B0C")]
			[Address(RVA = "0x6C96", Offset = "0x6C96", VA = "0x6C96")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004B9 RID: 1209
		// (get) Token: 0x06001B0D RID: 6925 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170004B9")]
		public RectTransform ShapeTransform
		{
			[Token(Token = "0x6001B0D")]
			[Address(RVA = "0x6C97", Offset = "0x6C97", VA = "0x6C97")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004BA RID: 1210
		// (get) Token: 0x06001B0E RID: 6926 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170004BA")]
		public RectTransform OverlapTransform
		{
			[Token(Token = "0x6001B0E")]
			[Address(RVA = "0x6C98", Offset = "0x6C98", VA = "0x6C98")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001B0F RID: 6927 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B0F")]
		[Address(RVA = "0x6C99", Offset = "0x6C99", VA = "0x6C99")]
		private void OnDisable()
		{
		/* --- GHIDRA: OnDisable ---
		void Gameplay_Tutorial_Guide_View_Components_ShapePointer__OnDisable(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int *piVar4;
		  int local_18;
		  undefined8 *local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5847a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_TargetPointerShape__AbstractGuideOutline__get_Values__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_TargetPointerShape__AbstractGuideOutline__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_TargetPointerShape__AbstractGuideOutline__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_TargetPointerShape__AbstractGuideOutline__get_Current__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_TargetPointerShape__AbstractGuideOutline__GetEnumerator__
		              );
		    DAT_ram_00a5847a = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  if (*(int *)(param1 + 0x54) != 0) {
		    *(undefined4 *)(*(int *)(param1 + 0x54) + 0x20) = 0;
		  }
		  uVar2 = System_Collections_Generic_Dictionary_int__object___TryAdd
		                    (*(undefined4 *)(param1 + 0x30),
		                     Method_System_Collections_Generic_Dictionary_TargetPointerShape__AbstractGuideOutline__get_Values__
		                    );
		  System_Collections_Generic_Dictionary_Int32Enum__object___get_Values
		            (&local_10,uVar2,
		             Method_System_Collections_Generic_Dictionary_ValueCollection_TargetPointerShape__AbstractGuideOutline__GetEnumerator__
		            );
		  local_18 = 0;
		  local_14 = &local_10;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar3 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00001b87 + 0xa1,&local_10,
		                       Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_TargetPointerShape__AbstractGuideOutline__MoveNext__
		                      );
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80ef1044;
		    }
		    if (iVar3 == 0) goto code_r0x80ef109a;
		    DAT_ram_009d3e38 = 0;
		    uVar2 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x25c,local_8._4_4_,0);
		    if (DAT_ram_009d3e38 == 1) break;
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
		code_r0x80ef1044:
		  iVar1 = global_1;
		  iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar1 == iVar3) {
		    piVar4 = (int *)import::env::__cxa_begin_catch(uVar2);
		    iVar3 = *piVar4;
		    DAT_ram_009d3e38 = 0;
		    local_18 = iVar3;
		    import::env::invoke_v(0x123);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 != 1) {
		      if (iVar3 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		code_r0x80ef109a:
		      DAT_ram_009d3e38 = 0;
		      *(undefined4 *)(param1 + 0x2c) = 0;
		      *(undefined4 *)(param1 + 0x24) = 0;
		      if (*(int *)(param1 + 0x54) != 0) {
		        *(undefined4 *)(param1 + 0x54) = 0;
		      }
		      *(undefined4 *)(param1 + 0x30) = 0;
		      return;
		    }
		    uVar2 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x16c,&local_18);
		  iVar1 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar1 == 1) {
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__resumeException(uVar2);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06001B10 RID: 6928 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B10")]
		[Address(RVA = "0x6C9A", Offset = "0x6C9A", VA = "0x6C9A")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_Tutorial_Guide_View_Components_ShapePointer__OnDestroy(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined8 local_30;
		  undefined4 local_28;
		  undefined8 local_20;
		  undefined8 local_14;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a58477 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_RectTransform___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a58477 = '\x01';
		  }
		  uVar2 = *(undefined4 *)(param1 + 0x2c);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar1 = UnityEngine_Component__GetComponent_object_(uVar2,0);
		  if (iVar1 == 0) {
		    uVar2 = func_ii_5677(*(undefined4 *)(param1 + 0x14),
		                         Method_UnityEngine_Component_GetComponent_RectTransform___);
		    *(undefined4 *)(param1 + 0x2c) = uVar2;
		  }
		  else {
		    uVar2 = *(undefined4 *)(param1 + 0x2c);
		  }
		  func_ii_7888(&local_14,uVar2,0);
		  *(undefined4 *)(param1 + 0x48) = local_c;
		  *(undefined8 *)(param1 + 0x40) = local_14;
		  local_20 = *(undefined8 *)(param1 + 0x38);
		  local_8 = local_20;
		  Gameplay_Tutorial_Guide_View_Components_ShapePointer__TryGetShapeSprite
		            (param1,&local_20,&local_30);
		  uVar2 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                    (*(undefined4 *)(param1 + 0x14),0);
		  local_28 = *(undefined4 *)(param1 + 0x48);
		  local_30 = *(undefined8 *)(param1 + 0x40);
		  UnityEngine_Transform__get_position(uVar2,&local_30,0);
		  Gameplay_Tutorial_Guide_View_Components_ShapePointer__Move(param1,&local_30);
		  return;
		}
		*/

		}

		// Token: 0x06001B11 RID: 6929 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B11")]
		[Address(RVA = "0x6C9B", Offset = "0x6C9B", VA = "0x6C9B")]
		private void Awake()
		{
		/* --- GHIDRA: Awake ---
		uint Gameplay_Tutorial_Guide_View_Components_ShapePointer__Awake
		               (int param1,int param2,int *param3,undefined4 param4)
		
		{
		  int iVar1;
		  uint uVar2;
		  int iVar3;
		  int iVar4;
		  int iVar5;
		  int iVar6;
		  
		  uVar2 = 1;
		  iVar3 = *(int *)(param1 + 0x1c);
		  iVar4 = *(int *)(iVar3 + 0xc);
		  if (iVar4 < 1) {
		    *param3 = 0;
		    return 0;
		  }
		  iVar5 = *(int *)(*(int *)(*(int *)(param2 + 8) + 0x24) + 8);
		  iVar6 = *(int *)(iVar3 + 0x10);
		  if (iVar5 != *(int *)(iVar6 + 8)) {
		    iVar1 = 0;
		    do {
		      iVar1 = iVar1 + 1;
		      if (iVar4 == iVar1) {
		        iVar6 = 0;
		        break;
		      }
		      iVar6 = *(int *)(iVar3 + iVar1 * 4 + 0x10);
		    } while (iVar5 != *(int *)(iVar6 + 8));
		    uVar2 = (uint)(iVar1 < iVar4);
		  }
		  *param3 = iVar6;
		  return uVar2;
		}
		*/

		}

		// Token: 0x06001B12 RID: 6930 RVA: 0x00005B50 File Offset: 0x00003D50
		[Token(Token = "0x6001B12")]
		[Address(RVA = "0x6C9C", Offset = "0x6C9C", VA = "0x6C9C")]
		public bool TryGetShapeConfig(AbstractShape shape, out ShapePointer.ShapeSpriteConfig result)
		{
		/* --- GHIDRA: TryGetShapeConfig ---
		undefined4
		Gameplay_Tutorial_Guide_View_Components_ShapePointer__TryGetShapeConfig
		          (int param1,int *param2,undefined4 *param3,undefined4 param4)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int iVar4;
		  undefined4 local_4;
		  
		  local_4 = 0;
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param2 + 0xf8) * 4))
		                    (param2,&local_4,*(undefined4 *)(*param2 + 0xfc));
		  if (iVar2 == 0) {
		    iVar2 = *(int *)(*(int *)(param1 + 0x1c) + 0xc);
		    if (0 < iVar2) {
		      iVar1 = 0;
		      do {
		        iVar4 = *(int *)(*(int *)(param1 + 0x1c) + iVar1 * 4 + 0x10);
		        if (*(int *)(*(int *)(param2[2] + 0x24) + 8) == *(int *)(iVar4 + 8)) {
		          local_4 = *(undefined4 *)(iVar4 + 0xc);
		          uVar3 = 1;
		          goto code_r0x80ef197c;
		        }
		        iVar1 = iVar1 + 1;
		      } while (iVar1 != iVar2);
		    }
		    local_4 = 0;
		    uVar3 = 0;
		  }
		  else {
		    uVar3 = 1;
		  }
		code_r0x80ef197c:
		  *param3 = local_4;
		  return uVar3;
		}
		*/

			return default(bool);
		}

		// Token: 0x06001B13 RID: 6931 RVA: 0x00005B68 File Offset: 0x00003D68
		[Token(Token = "0x6001B13")]
		[Address(RVA = "0x6C9D", Offset = "0x6C9D", VA = "0x6C9D")]
		public bool TryGetShapeSprite(AbstractShape shape, out Sprite spriteOut)
		{
		/* --- GHIDRA: TryGetShapeSprite ---
		void Gameplay_Tutorial_Guide_View_Components_ShapePointer__TryGetShapeSprite
		               (int param1,undefined8 *param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  Gameplay_Tutorial_Guide_View_Components_ShapePointer__set_IsResizeProcessNow(param1,param1);
		  if (DAT_ram_00a58477 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_RectTransform___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a58477 = '\x01';
		  }
		  uVar2 = *(undefined4 *)(param1 + 0x2c);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar1 = UnityEngine_Component__GetComponent_object_(uVar2,0);
		  if (iVar1 == 0) {
		    uVar2 = func_ii_5677(*(undefined4 *)(param1 + 0x14),
		                         Method_UnityEngine_Component_GetComponent_RectTransform___);
		    *(undefined4 *)(param1 + 0x2c) = uVar2;
		  }
		  else {
		    uVar2 = *(undefined4 *)(param1 + 0x2c);
		  }
		  local_10 = *param2;
		  local_8 = local_10;
		  UnityEngine_RectTransform__get_sizeDelta(uVar2,&local_10,0);
		  Gameplay_Tutorial_Guide_View_Components_ShapePointer__ReSizeStart(param1,param1);
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x06001B14 RID: 6932 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B14")]
		[Address(RVA = "0x6C9E", Offset = "0x6C9E", VA = "0x6C9E")]
		public void SetSize(Vector2 value)
		{
		/* --- GHIDRA: SetSize ---
		void Gameplay_Tutorial_Guide_View_Components_ShapePointer__SetSize
		               (int param1,undefined8 *param2,float param3,undefined4 param4)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5847b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Tutorial_Guide_View_Components_ShapePointer_ReSizeComplete__);
		    Mono_Security_ASN1__get_Item(&DG_Tweening_TweenCallback_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_OnComplete_TweenerCore_Vector2__Vector2__VectorOptions____
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_SetLink_TweenerCore_Vector2__Vector2__VectorOptions____
		              );
		    DAT_ram_00a5847b = '\x01';
		  }
		  if (param3 == 0.0) {
		    local_20 = *param2;
		    local_8 = local_20;
		    Gameplay_Tutorial_Guide_View_Components_ShapePointer__TryGetShapeSprite
		              (param1,&local_20,&local_20);
		  }
		  else {
		    Gameplay_Tutorial_Guide_View_Components_ShapePointer__set_IsResizeProcessNow(param1,&local_20);
		    if (DAT_ram_00a58477 == '\0') {
		      Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_RectTransform___);
		      Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		      DAT_ram_00a58477 = '\x01';
		    }
		    uVar2 = *(undefined4 *)(param1 + 0x2c);
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UnityEngine_Object_TypeInfo);
		    }
		    iVar1 = UnityEngine_Component__GetComponent_object_(uVar2,0);
		    if (iVar1 == 0) {
		      uVar2 = func_ii_5677(*(undefined4 *)(param1 + 0x14),
		                           Method_UnityEngine_Component_GetComponent_RectTransform___);
		      *(undefined4 *)(param1 + 0x2c) = uVar2;
		    }
		    else {
		      uVar2 = *(undefined4 *)(param1 + 0x2c);
		    }
		    local_18 = *param2;
		    local_10 = local_18;
		    uVar2 = DG_Tweening_DOTweenModuleUI__DOPivotY(uVar2,&local_18,param3,0,0);
		    if (DAT_ram_00a58477 == '\0') {
		      Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_RectTransform___);
		      Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		      DAT_ram_00a58477 = '\x01';
		    }
		    uVar3 = *(undefined4 *)(param1 + 0x2c);
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UnityEngine_Object_TypeInfo);
		    }
		    iVar1 = UnityEngine_Component__GetComponent_object_(uVar3,0);
		    if (iVar1 == 0) {
		      uVar3 = func_ii_5677(*(undefined4 *)(param1 + 0x14),
		                           Method_UnityEngine_Component_GetComponent_RectTransform___);
		      *(undefined4 *)(param1 + 0x2c) = uVar3;
		    }
		    else {
		      uVar3 = *(undefined4 *)(param1 + 0x2c);
		    }
		    uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (uVar3,0);
		    uVar2 = DG_Tweening_TweenSettingsExtensions__SetDelay_object_
		                      (uVar2,uVar3,
		                       Method_DG_Tweening_TweenSettingsExtensions_SetLink_TweenerCore_Vector2__Vector2__VectorOptions____
		                      );
		    uVar3 = unnamed_function_1417(DG_Tweening_TweenCallback_TypeInfo);
		    DG_Tweening_Color2__op_Multiply
		              (uVar3,param1,
		               Method_Gameplay_Tutorial_Guide_View_Components_ShapePointer_ReSizeComplete__,0);
		    DG_Tweening_TweenSettingsExtensions__From___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType____Il2CppFullySharedGenericStructType_
		              (uVar2,uVar3,
		               Method_DG_Tweening_TweenSettingsExtensions_OnComplete_TweenerCore_Vector2__Vector2__VectorOptions____
		              );
		  }
		  return;
		}
		*/

		/* --- GHIDRA: SetSize ---
		void Gameplay_Tutorial_Guide_View_Components_ShapePointer__SetSize
		               (int param1,undefined8 *param2,float param3,undefined4 param4)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5847b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Tutorial_Guide_View_Components_ShapePointer_ReSizeComplete__);
		    Mono_Security_ASN1__get_Item(&DG_Tweening_TweenCallback_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_OnComplete_TweenerCore_Vector2__Vector2__VectorOptions____
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_SetLink_TweenerCore_Vector2__Vector2__VectorOptions____
		              );
		    DAT_ram_00a5847b = '\x01';
		  }
		  if (param3 == 0.0) {
		    local_20 = *param2;
		    local_8 = local_20;
		    Gameplay_Tutorial_Guide_View_Components_ShapePointer__TryGetShapeSprite
		              (param1,&local_20,&local_20);
		  }
		  else {
		    Gameplay_Tutorial_Guide_View_Components_ShapePointer__set_IsResizeProcessNow(param1,&local_20);
		    if (DAT_ram_00a58477 == '\0') {
		      Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_RectTransform___);
		      Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		      DAT_ram_00a58477 = '\x01';
		    }
		    uVar2 = *(undefined4 *)(param1 + 0x2c);
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UnityEngine_Object_TypeInfo);
		    }
		    iVar1 = UnityEngine_Component__GetComponent_object_(uVar2,0);
		    if (iVar1 == 0) {
		      uVar2 = func_ii_5677(*(undefined4 *)(param1 + 0x14),
		                           Method_UnityEngine_Component_GetComponent_RectTransform___);
		      *(undefined4 *)(param1 + 0x2c) = uVar2;
		    }
		    else {
		      uVar2 = *(undefined4 *)(param1 + 0x2c);
		    }
		    local_18 = *param2;
		    local_10 = local_18;
		    uVar2 = DG_Tweening_DOTweenModuleUI__DOPivotY(uVar2,&local_18,param3,0,0);
		    if (DAT_ram_00a58477 == '\0') {
		      Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_RectTransform___);
		      Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		      DAT_ram_00a58477 = '\x01';
		    }
		    uVar3 = *(undefined4 *)(param1 + 0x2c);
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UnityEngine_Object_TypeInfo);
		    }
		    iVar1 = UnityEngine_Component__GetComponent_object_(uVar3,0);
		    if (iVar1 == 0) {
		      uVar3 = func_ii_5677(*(undefined4 *)(param1 + 0x14),
		                           Method_UnityEngine_Component_GetComponent_RectTransform___);
		      *(undefined4 *)(param1 + 0x2c) = uVar3;
		    }
		    else {
		      uVar3 = *(undefined4 *)(param1 + 0x2c);
		    }
		    uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (uVar3,0);
		    uVar2 = DG_Tweening_TweenSettingsExtensions__SetDelay_object_
		                      (uVar2,uVar3,
		                       Method_DG_Tweening_TweenSettingsExtensions_SetLink_TweenerCore_Vector2__Vector2__VectorOptions____
		                      );
		    uVar3 = unnamed_function_1417(DG_Tweening_TweenCallback_TypeInfo);
		    DG_Tweening_Color2__op_Multiply
		              (uVar3,param1,
		               Method_Gameplay_Tutorial_Guide_View_Components_ShapePointer_ReSizeComplete__,0);
		    DG_Tweening_TweenSettingsExtensions__From___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType____Il2CppFullySharedGenericStructType_
		              (uVar2,uVar3,
		               Method_DG_Tweening_TweenSettingsExtensions_OnComplete_TweenerCore_Vector2__Vector2__VectorOptions____
		              );
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001B15 RID: 6933 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B15")]
		[Address(RVA = "0x6C9F", Offset = "0x6C9F", VA = "0x6C9F")]
		public void SetSize(Vector2 value, float duration)
		{
		}

		// Token: 0x170004BB RID: 1211
		// (get) Token: 0x06001B16 RID: 6934 RVA: 0x00005B80 File Offset: 0x00003D80
		// (set) Token: 0x06001B17 RID: 6935 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004BB")]
		public bool IsResizeProcessNow
		{
			[Token(Token = "0x6001B16")]
			[Address(RVA = "0x6CA0", Offset = "0x6CA0", VA = "0x6CA0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001B17")]
			[Address(RVA = "0x6CA1", Offset = "0x6CA1", VA = "0x6CA1")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06001B18 RID: 6936 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B18")]
		[Address(RVA = "0x6CA2", Offset = "0x6CA2", VA = "0x6CA2")]
		private void ReSizeStart()
		{
		/* --- GHIDRA: ReSizeStart ---
		void Gameplay_Tutorial_Guide_View_Components_ShapePointer__ReSizeStart(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int *piVar2;
		  undefined4 param1_00;
		  
		  *(undefined1 *)(param1 + 0x50) = 0;
		  if (DAT_ram_00a58476 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_Image___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a58476 = '\x01';
		  }
		  param1_00 = *(undefined4 *)(param1 + 0x24);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar1 = UnityEngine_Component__GetComponent_object_(param1_00,0);
		  if (iVar1 == 0) {
		    piVar2 = (int *)func_ii_5677(*(undefined4 *)(param1 + 0x14),
		                                 Method_UnityEngine_Component_GetComponent_Image___);
		    *(int **)(param1 + 0x24) = piVar2;
		  }
		  else {
		    piVar2 = *(int **)(param1 + 0x24);
		  }
		  (**(code **)((ulonglong)*(uint *)(*piVar2 + 0x188) * 4))
		            (piVar2,0,*(undefined4 *)(*piVar2 + 0x18c));
		  return;
		}
		*/

		}

		// Token: 0x06001B19 RID: 6937 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B19")]
		[Address(RVA = "0x6CA3", Offset = "0x6CA3", VA = "0x6CA3")]
		private void ReSizeComplete()
		{
		/* --- GHIDRA: ReSizeComplete ---
		void Gameplay_Tutorial_Guide_View_Components_ShapePointer__ReSizeComplete
		               (undefined4 param1,undefined4 param2,undefined8 *param3,undefined4 param4)
		
		{
		  undefined8 local_10;
		  undefined4 local_8;
		  
		  local_8 = *(undefined4 *)(param3 + 1);
		  local_10 = *param3;
		  UnityEngine_Transform__get_position(param2,&local_10,0);
		  Gameplay_Tutorial_Guide_View_Components_ShapePointer__Move(param1,&local_10);
		  return;
		}
		*/

		}

		// Token: 0x06001B1A RID: 6938 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B1A")]
		[Address(RVA = "0x6CA4", Offset = "0x6CA4", VA = "0x6CA4")]
		public void Move(Transform target, Vector3 value)
		{
		/* --- GHIDRA: Move ---
		void Gameplay_Tutorial_Guide_View_Components_ShapePointer__Move
		               (undefined4 param1,undefined4 param2,undefined8 *param3,float param4,
		               undefined4 param5)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  undefined8 local_20;
		  undefined4 local_18;
		  undefined8 local_10;
		  undefined4 local_8;
		  
		  if (DAT_ram_00a5847c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Tutorial_Guide_View_Components_ShapePointer_MoveUpdate__);
		    Mono_Security_ASN1__get_Item(&DG_Tweening_TweenCallback_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_OnUpdate_TweenerCore_Vector3__Vector3__VectorOptions____
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_SetLink_TweenerCore_Vector3__Vector3__VectorOptions____
		              );
		    DAT_ram_00a5847c = '\x01';
		  }
		  if (param4 == 0.0) {
		    local_18 = *(undefined4 *)(param3 + 1);
		    local_20 = *param3;
		    UnityEngine_Transform__get_position(param2,&local_20,0);
		    Gameplay_Tutorial_Guide_View_Components_ShapePointer__Move(param1,&local_20);
		  }
		  else {
		    local_8 = *(undefined4 *)(param3 + 1);
		    local_10 = *param3;
		    uVar1 = DG_Tweening_ShortcutExtensions__DOTime(param2,&local_10,param4,0,0);
		    uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (param1,0);
		    uVar1 = DG_Tweening_TweenSettingsExtensions__SetDelay_object_
		                      (uVar1,uVar2,
		                       Method_DG_Tweening_TweenSettingsExtensions_SetLink_TweenerCore_Vector3__Vector3__VectorOptions____
		                      );
		    uVar2 = unnamed_function_1417(DG_Tweening_TweenCallback_TypeInfo);
		    DG_Tweening_Color2__op_Multiply
		              (uVar2,param1,Method_Gameplay_Tutorial_Guide_View_Components_ShapePointer_MoveUpdate__
		               ,0);
		    DG_Tweening_TweenSettingsExtensions__OnStepComplete_object_
		              (uVar1,uVar2,
		               Method_DG_Tweening_TweenSettingsExtensions_OnUpdate_TweenerCore_Vector3__Vector3__VectorOptions____
		              );
		  }
		  return;
		}
		*/

		/* --- GHIDRA: Move ---
		void Gameplay_Tutorial_Guide_View_Components_ShapePointer__Move
		               (undefined4 param1,undefined4 param2,undefined8 *param3,float param4,
		               undefined4 param5)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  undefined8 local_20;
		  undefined4 local_18;
		  undefined8 local_10;
		  undefined4 local_8;
		  
		  if (DAT_ram_00a5847c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Tutorial_Guide_View_Components_ShapePointer_MoveUpdate__);
		    Mono_Security_ASN1__get_Item(&DG_Tweening_TweenCallback_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_OnUpdate_TweenerCore_Vector3__Vector3__VectorOptions____
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_SetLink_TweenerCore_Vector3__Vector3__VectorOptions____
		              );
		    DAT_ram_00a5847c = '\x01';
		  }
		  if (param4 == 0.0) {
		    local_18 = *(undefined4 *)(param3 + 1);
		    local_20 = *param3;
		    UnityEngine_Transform__get_position(param2,&local_20,0);
		    Gameplay_Tutorial_Guide_View_Components_ShapePointer__Move(param1,&local_20);
		  }
		  else {
		    local_8 = *(undefined4 *)(param3 + 1);
		    local_10 = *param3;
		    uVar1 = DG_Tweening_ShortcutExtensions__DOTime(param2,&local_10,param4,0,0);
		    uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (param1,0);
		    uVar1 = DG_Tweening_TweenSettingsExtensions__SetDelay_object_
		                      (uVar1,uVar2,
		                       Method_DG_Tweening_TweenSettingsExtensions_SetLink_TweenerCore_Vector3__Vector3__VectorOptions____
		                      );
		    uVar2 = unnamed_function_1417(DG_Tweening_TweenCallback_TypeInfo);
		    DG_Tweening_Color2__op_Multiply
		              (uVar2,param1,Method_Gameplay_Tutorial_Guide_View_Components_ShapePointer_MoveUpdate__
		               ,0);
		    DG_Tweening_TweenSettingsExtensions__OnStepComplete_object_
		              (uVar1,uVar2,
		               Method_DG_Tweening_TweenSettingsExtensions_OnUpdate_TweenerCore_Vector3__Vector3__VectorOptions____
		              );
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001B1B RID: 6939 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B1B")]
		[Address(RVA = "0x6CA5", Offset = "0x6CA5", VA = "0x6CA5")]
		public void Move(Transform target, Vector3 value, float duration)
		{
		}

		// Token: 0x06001B1C RID: 6940 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B1C")]
		[Address(RVA = "0x6CA6", Offset = "0x6CA6", VA = "0x6CA6")]
		private void MoveUpdate()
		{
		}

		// Token: 0x170004BC RID: 1212
		// (get) Token: 0x06001B1D RID: 6941 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001B1E RID: 6942 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004BC")]
		public AbstractShape Shape
		{
			[Token(Token = "0x6001B1D")]
			[Address(RVA = "0x6CA7", Offset = "0x6CA7", VA = "0x6CA7")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001B1E")]
			[Address(RVA = "0x6CA8", Offset = "0x6CA8", VA = "0x6CA8")]
			set
			{
			}
		}

		// Token: 0x06001B1F RID: 6943 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B1F")]
		[Address(RVA = "0x6CA9", Offset = "0x6CA9", VA = "0x6CA9")]
		private void HandleCurrentShapeChanged(AbstractShape from, AbstractShape to)
		{
		/* --- GHIDRA: HandleCurrentShapeChanged ---
		undefined4
		Gameplay_Tutorial_Guide_View_Components_ShapePointer__HandleCurrentShapeChanged
		          (int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5847e == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_MonoBehaviourWithStates_OverlapType__get_CurrentState__)
		    ;
		    DAT_ram_00a5847e = '\x01';
		  }
		  return *(undefined4 *)(*(int *)(param1 + 0x10) + 0x18);
		}
		*/

		}

		// Token: 0x170004BD RID: 1213
		// (get) Token: 0x06001B20 RID: 6944 RVA: 0x00005B98 File Offset: 0x00003D98
		// (set) Token: 0x06001B21 RID: 6945 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004BD")]
		public OverlapType OverlapType
		{
			[Token(Token = "0x6001B20")]
			[Address(RVA = "0x6CAA", Offset = "0x6CAA", VA = "0x6CAA")]
			get
			{
				return OverlapType.UNKNOWN;
			}
			[Token(Token = "0x6001B21")]
			[Address(RVA = "0x6CAB", Offset = "0x6CAB", VA = "0x6CAB")]
			set
			{
			}
		}

		// Token: 0x06001B22 RID: 6946 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B22")]
		[Address(RVA = "0x6CAC", Offset = "0x6CAC", VA = "0x6CAC")]
		public void SetRect(in Rect rect)
		{
		/* --- GHIDRA: SetRect ---
		void Gameplay_Tutorial_Guide_View_Components_ShapePointer__SetRect
		               (int param1,int param2,undefined4 param3,undefined4 param4)
		
		{
		  int param2_00;
		  
		  if (DAT_ram_00a58480 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_TargetPointerShape__AbstractShape__get_Item__
		              );
		    DAT_ram_00a58480 = '\x01';
		  }
		  param2_00 = GAFInternal_Reader_GAFReader__OpenTag
		                        (*(undefined4 *)(param1 + 0x4c),*(undefined4 *)(*(int *)(param2 + 0x24) + 8)
		                         ,
		                         Method_System_Collections_Generic_Dictionary_TargetPointerShape__AbstractShape__get_Item__
		                        );
		  *(int *)(param2_00 + 8) = param2;
		  Gameplay_Tutorial_Guide_View_Components_ShapePointer__StartDraw(param1,param2_00,param3,param2);
		  return;
		}
		*/

		}

		// Token: 0x06001B23 RID: 6947 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B23")]
		[Address(RVA = "0x6CAD", Offset = "0x6CAD", VA = "0x6CAD")]
		public void StartDraw(StepLayoutConfig config, in Rect rect)
		{
		/* --- GHIDRA: StartDraw ---
		undefined4
		Gameplay_Tutorial_Guide_View_Components_ShapePointer__StartDraw
		          (int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  int iVar5;
		  int iVar6;
		  undefined4 param1_00;
		  undefined4 param2_00;
		  int iVar7;
		  
		  if (DAT_ram_00a58481 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_TargetPointerShape__AbstractGuideOutline__ContainsKey__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_TargetPointerShape__AbstractGuideOutline__get_Item__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_TargetPointerShape__AbstractGuideOutline__set_Item__
		              );
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_AbstractGuideOutline___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a58481 = '\x01';
		  }
		  iVar2 = System_Collections_Generic_Dictionary_Int32Enum__uint___Clear
		                    (*(undefined4 *)(param1 + 0x30),
		                     *(undefined4 *)(*(int *)(*(int *)(*(int *)(param1 + 0x54) + 8) + 0x24) + 8),
		                     Method_System_Collections_Generic_Dictionary_TargetPointerShape__AbstractGuideOutline__ContainsKey__
		                    );
		  if (iVar2 == 0) {
		    iVar2 = *(int *)(param1 + 0x1c);
		    iVar5 = *(int *)(iVar2 + 0xc);
		    if (iVar5 < 1) {
		code_r0x80ef2420:
		      uVar3 = unnamed_function_2232(&StringLiteral_14291);
		      uVar3 = func_ii_4419(uVar3,param2,0);
		      uVar4 = unnamed_function_2232(&System_Exception_TypeInfo);
		      uVar4 = unnamed_function_1417(uVar4);
		      System_String__Concat(uVar4,uVar3,0);
		      uVar3 = unnamed_function_2232
		                        (&
		                         Method_Gameplay_Tutorial_Guide_View_Components_ShapePointer_GetCachedOutline__
		                        );
		      func_ii_1050(uVar4,uVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar6 = *(int *)(*(int *)(*(int *)(param2 + 8) + 0x24) + 8);
		    iVar7 = *(int *)(iVar2 + 0x10);
		    if (iVar6 != *(int *)(iVar7 + 8)) {
		      iVar1 = 0;
		      do {
		        iVar1 = iVar1 + 1;
		        if (iVar5 == iVar1) {
		          iVar7 = 0;
		          break;
		        }
		        iVar7 = *(int *)(iVar2 + iVar1 * 4 + 0x10);
		      } while (iVar6 != *(int *)(iVar7 + 8));
		      if (iVar5 <= iVar1) goto code_r0x80ef2420;
		    }
		    uVar3 = *(undefined4 *)(param1 + 0x18);
		    uVar4 = *(undefined4 *)(iVar7 + 0x10);
		    param1_00 = *(undefined4 *)(param1 + 0x30);
		    param2_00 = *(undefined4 *)(*(int *)(*(int *)(*(int *)(param1 + 0x54) + 8) + 0x24) + 8);
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UnityEngine_Object_TypeInfo);
		    }
		    uVar3 = func_ii_6805(uVar4,uVar3,Method_UnityEngine_Object_Instantiate_AbstractGuideOutline___);
		    System_Collections_Generic_Dictionary_Int32Enum__object___ContainsKey
		              (param1_00,param2_00,uVar3,
		               Method_System_Collections_Generic_Dictionary_TargetPointerShape__AbstractGuideOutline__set_Item__
		              );
		  }
		  uVar3 = GAFInternal_Reader_GAFReader__OpenTag
		                    (*(undefined4 *)(param1 + 0x30),
		                     *(undefined4 *)(*(int *)(*(int *)(*(int *)(param1 + 0x54) + 8) + 0x24) + 8),
		                     Method_System_Collections_Generic_Dictionary_TargetPointerShape__AbstractGuideOutline__get_Item__
		                    );
		  return uVar3;
		}
		*/

		/* --- GHIDRA: StartDraw ---
		undefined4
		Gameplay_Tutorial_Guide_View_Components_ShapePointer__StartDraw
		          (int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  int iVar5;
		  int iVar6;
		  undefined4 param1_00;
		  undefined4 param2_00;
		  int iVar7;
		  
		  if (DAT_ram_00a58481 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_TargetPointerShape__AbstractGuideOutline__ContainsKey__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_TargetPointerShape__AbstractGuideOutline__get_Item__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_TargetPointerShape__AbstractGuideOutline__set_Item__
		              );
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_AbstractGuideOutline___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a58481 = '\x01';
		  }
		  iVar2 = System_Collections_Generic_Dictionary_Int32Enum__uint___Clear
		                    (*(undefined4 *)(param1 + 0x30),
		                     *(undefined4 *)(*(int *)(*(int *)(*(int *)(param1 + 0x54) + 8) + 0x24) + 8),
		                     Method_System_Collections_Generic_Dictionary_TargetPointerShape__AbstractGuideOutline__ContainsKey__
		                    );
		  if (iVar2 == 0) {
		    iVar2 = *(int *)(param1 + 0x1c);
		    iVar5 = *(int *)(iVar2 + 0xc);
		    if (iVar5 < 1) {
		code_r0x80ef2420:
		      uVar3 = unnamed_function_2232(&StringLiteral_14291);
		      uVar3 = func_ii_4419(uVar3,param2,0);
		      uVar4 = unnamed_function_2232(&System_Exception_TypeInfo);
		      uVar4 = unnamed_function_1417(uVar4);
		      System_String__Concat(uVar4,uVar3,0);
		      uVar3 = unnamed_function_2232
		                        (&
		                         Method_Gameplay_Tutorial_Guide_View_Components_ShapePointer_GetCachedOutline__
		                        );
		      func_ii_1050(uVar4,uVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar6 = *(int *)(*(int *)(*(int *)(param2 + 8) + 0x24) + 8);
		    iVar7 = *(int *)(iVar2 + 0x10);
		    if (iVar6 != *(int *)(iVar7 + 8)) {
		      iVar1 = 0;
		      do {
		        iVar1 = iVar1 + 1;
		        if (iVar5 == iVar1) {
		          iVar7 = 0;
		          break;
		        }
		        iVar7 = *(int *)(iVar2 + iVar1 * 4 + 0x10);
		      } while (iVar6 != *(int *)(iVar7 + 8));
		      if (iVar5 <= iVar1) goto code_r0x80ef2420;
		    }
		    uVar3 = *(undefined4 *)(param1 + 0x18);
		    uVar4 = *(undefined4 *)(iVar7 + 0x10);
		    param1_00 = *(undefined4 *)(param1 + 0x30);
		    param2_00 = *(undefined4 *)(*(int *)(*(int *)(*(int *)(param1 + 0x54) + 8) + 0x24) + 8);
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UnityEngine_Object_TypeInfo);
		    }
		    uVar3 = func_ii_6805(uVar4,uVar3,Method_UnityEngine_Object_Instantiate_AbstractGuideOutline___);
		    System_Collections_Generic_Dictionary_Int32Enum__object___ContainsKey
		              (param1_00,param2_00,uVar3,
		               Method_System_Collections_Generic_Dictionary_TargetPointerShape__AbstractGuideOutline__set_Item__
		              );
		  }
		  uVar3 = GAFInternal_Reader_GAFReader__OpenTag
		                    (*(undefined4 *)(param1 + 0x30),
		                     *(undefined4 *)(*(int *)(*(int *)(*(int *)(param1 + 0x54) + 8) + 0x24) + 8),
		                     Method_System_Collections_Generic_Dictionary_TargetPointerShape__AbstractGuideOutline__get_Item__
		                    );
		  return uVar3;
		}
		*/

		}

		// Token: 0x06001B24 RID: 6948 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B24")]
		[Address(RVA = "0x6CAE", Offset = "0x6CAE", VA = "0x6CAE")]
		public void StartDraw(AbstractShape shape, in Rect rect)
		{
		}

		// Token: 0x06001B25 RID: 6949 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001B25")]
		[Address(RVA = "0x6CAF", Offset = "0x6CAF", VA = "0x6CAF")]
		private AbstractGuideOutline GetCachedOutline(AbstractShape shape)
		{
			return null;
		}

		// Token: 0x06001B26 RID: 6950 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B26")]
		[Address(RVA = "0x6CB0", Offset = "0x6CB0", VA = "0x6CB0")]
		public void StopDraw()
		{
		/* --- GHIDRA: StopDraw ---
		void Gameplay_Tutorial_Guide_View_Components_ShapePointer__StopDraw
		               (int param1,float param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  undefined8 local_30;
		  undefined4 local_28;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a58482 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Tutorial_Guide_View_Components_ShapePointer__StopDraw_b__62_0__);
		    Mono_Security_ASN1__get_Item(&DG_Tweening_TweenCallback_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_OnComplete_TweenerCore_Vector2__Vector2__VectorOptions____
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_SetLink_TweenerCore_Vector2__Vector2__VectorOptions____
		              );
		    DAT_ram_00a58482 = '\x01';
		  }
		  if (param2 == 0.0) {
		    local_20 = *(undefined8 *)(param1 + 0x38);
		    local_8 = local_20;
		    Gameplay_Tutorial_Guide_View_Components_ShapePointer__TryGetShapeSprite(param1,&local_20,param1)
		    ;
		    uVar2 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                      (*(undefined4 *)(param1 + 0x14),0);
		    local_28 = *(undefined4 *)(param1 + 0x48);
		    local_30 = *(undefined8 *)(param1 + 0x40);
		    UnityEngine_Transform__get_position(uVar2,&local_30,0);
		    Gameplay_Tutorial_Guide_View_Components_ShapePointer__Move(param1,param1);
		  }
		  else {
		    if (DAT_ram_00a58477 == '\0') {
		      Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_RectTransform___);
		      Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		      DAT_ram_00a58477 = '\x01';
		    }
		    uVar2 = *(undefined4 *)(param1 + 0x2c);
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UnityEngine_Object_TypeInfo);
		    }
		    iVar1 = UnityEngine_Component__GetComponent_object_(uVar2,0);
		    if (iVar1 == 0) {
		      uVar2 = func_ii_5677(*(undefined4 *)(param1 + 0x14),
		                           Method_UnityEngine_Component_GetComponent_RectTransform___);
		      *(undefined4 *)(param1 + 0x2c) = uVar2;
		    }
		    else {
		      uVar2 = *(undefined4 *)(param1 + 0x2c);
		    }
		    local_18 = *(undefined8 *)(param1 + 0x38);
		    local_10 = local_18;
		    uVar2 = DG_Tweening_DOTweenModuleUI__DOPivotY(uVar2,&local_18,param2,0,0);
		    if (DAT_ram_00a58477 == '\0') {
		      Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_RectTransform___);
		      Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		      DAT_ram_00a58477 = '\x01';
		    }
		    uVar3 = *(undefined4 *)(param1 + 0x2c);
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UnityEngine_Object_TypeInfo);
		    }
		    iVar1 = UnityEngine_Component__GetComponent_object_(uVar3,0);
		    if (iVar1 == 0) {
		      uVar3 = func_ii_5677(*(undefined4 *)(param1 + 0x14),
		                           Method_UnityEngine_Component_GetComponent_RectTransform___);
		      *(undefined4 *)(param1 + 0x2c) = uVar3;
		    }
		    else {
		      uVar3 = *(undefined4 *)(param1 + 0x2c);
		    }
		    uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (uVar3,0);
		    uVar2 = DG_Tweening_TweenSettingsExtensions__SetDelay_object_
		                      (uVar2,uVar3,
		                       Method_DG_Tweening_TweenSettingsExtensions_SetLink_TweenerCore_Vector2__Vector2__VectorOptions____
		                      );
		    uVar3 = unnamed_function_1417(DG_Tweening_TweenCallback_TypeInfo);
		    DG_Tweening_Color2__op_Multiply
		              (uVar3,param1,
		               Method_Gameplay_Tutorial_Guide_View_Components_ShapePointer__StopDraw_b__62_0__,0);
		    DG_Tweening_TweenSettingsExtensions__From___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType____Il2CppFullySharedGenericStructType_
		              (uVar2,uVar3,
		               Method_DG_Tweening_TweenSettingsExtensions_OnComplete_TweenerCore_Vector2__Vector2__VectorOptions____
		              );
		  }
		  return;
		}
		*/

		/* --- GHIDRA: StopDraw ---
		void Gameplay_Tutorial_Guide_View_Components_ShapePointer__StopDraw
		               (int param1,float param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  undefined8 local_30;
		  undefined4 local_28;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a58482 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Tutorial_Guide_View_Components_ShapePointer__StopDraw_b__62_0__);
		    Mono_Security_ASN1__get_Item(&DG_Tweening_TweenCallback_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_OnComplete_TweenerCore_Vector2__Vector2__VectorOptions____
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_SetLink_TweenerCore_Vector2__Vector2__VectorOptions____
		              );
		    DAT_ram_00a58482 = '\x01';
		  }
		  if (param2 == 0.0) {
		    local_20 = *(undefined8 *)(param1 + 0x38);
		    local_8 = local_20;
		    Gameplay_Tutorial_Guide_View_Components_ShapePointer__TryGetShapeSprite(param1,&local_20,param1)
		    ;
		    uVar2 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                      (*(undefined4 *)(param1 + 0x14),0);
		    local_28 = *(undefined4 *)(param1 + 0x48);
		    local_30 = *(undefined8 *)(param1 + 0x40);
		    UnityEngine_Transform__get_position(uVar2,&local_30,0);
		    Gameplay_Tutorial_Guide_View_Components_ShapePointer__Move(param1,param1);
		  }
		  else {
		    if (DAT_ram_00a58477 == '\0') {
		      Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_RectTransform___);
		      Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		      DAT_ram_00a58477 = '\x01';
		    }
		    uVar2 = *(undefined4 *)(param1 + 0x2c);
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UnityEngine_Object_TypeInfo);
		    }
		    iVar1 = UnityEngine_Component__GetComponent_object_(uVar2,0);
		    if (iVar1 == 0) {
		      uVar2 = func_ii_5677(*(undefined4 *)(param1 + 0x14),
		                           Method_UnityEngine_Component_GetComponent_RectTransform___);
		      *(undefined4 *)(param1 + 0x2c) = uVar2;
		    }
		    else {
		      uVar2 = *(undefined4 *)(param1 + 0x2c);
		    }
		    local_18 = *(undefined8 *)(param1 + 0x38);
		    local_10 = local_18;
		    uVar2 = DG_Tweening_DOTweenModuleUI__DOPivotY(uVar2,&local_18,param2,0,0);
		    if (DAT_ram_00a58477 == '\0') {
		      Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_RectTransform___);
		      Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		      DAT_ram_00a58477 = '\x01';
		    }
		    uVar3 = *(undefined4 *)(param1 + 0x2c);
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UnityEngine_Object_TypeInfo);
		    }
		    iVar1 = UnityEngine_Component__GetComponent_object_(uVar3,0);
		    if (iVar1 == 0) {
		      uVar3 = func_ii_5677(*(undefined4 *)(param1 + 0x14),
		                           Method_UnityEngine_Component_GetComponent_RectTransform___);
		      *(undefined4 *)(param1 + 0x2c) = uVar3;
		    }
		    else {
		      uVar3 = *(undefined4 *)(param1 + 0x2c);
		    }
		    uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (uVar3,0);
		    uVar2 = DG_Tweening_TweenSettingsExtensions__SetDelay_object_
		                      (uVar2,uVar3,
		                       Method_DG_Tweening_TweenSettingsExtensions_SetLink_TweenerCore_Vector2__Vector2__VectorOptions____
		                      );
		    uVar3 = unnamed_function_1417(DG_Tweening_TweenCallback_TypeInfo);
		    DG_Tweening_Color2__op_Multiply
		              (uVar3,param1,
		               Method_Gameplay_Tutorial_Guide_View_Components_ShapePointer__StopDraw_b__62_0__,0);
		    DG_Tweening_TweenSettingsExtensions__From___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType____Il2CppFullySharedGenericStructType_
		              (uVar2,uVar3,
		               Method_DG_Tweening_TweenSettingsExtensions_OnComplete_TweenerCore_Vector2__Vector2__VectorOptions____
		              );
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001B27 RID: 6951 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B27")]
		[Address(RVA = "0x6CB1", Offset = "0x6CB1", VA = "0x6CB1")]
		public void StopDraw(float duration)
		{
		}

		// Token: 0x06001B28 RID: 6952 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B28")]
		[Address(RVA = "0x6CB2", Offset = "0x6CB2", VA = "0x6CB2")]
		public void SetShapeRenderRayCastEnabled(bool value)
		{
		/* --- GHIDRA: SetShapeRenderRayCastEnabled ---
		void Gameplay_Tutorial_Guide_View_Components_ShapePointer__SetShapeRenderRayCastEnabled
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a58483 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Tutorial_Guide_Model_Shapes_CircleShape_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_TargetPointerShape__AbstractShape__Add__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_TargetPointerShape__AbstractGuideOutline___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_TargetPointerShape__AbstractShape___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_Dictionary_TargetPointerShape__AbstractGuideOutline__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_Dictionary_TargetPointerShape__AbstractShape__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Tutorial_Guide_Model_Shapes_RectangleShape_TypeInfo);
		    DAT_ram_00a58483 = '\x01';
		  }
		  uVar1 = unnamed_function_1417
		                    (
		                    System_Collections_Generic_Dictionary_TargetPointerShape__AbstractGuideOutline__TypeInfo
		                    );
		  System_Collections_Generic_Dictionary_Int32Enum__Int32Enum___set_Item
		            (uVar1,
		             Method_System_Collections_Generic_Dictionary_TargetPointerShape__AbstractGuideOutline___ctor__
		            );
		  *(undefined8 *)(param1 + 0x38) = 0x457a0000457a0000;
		  *(undefined4 *)(param1 + 0x30) = uVar1;
		  uVar1 = unnamed_function_1417
		                    (
		                    System_Collections_Generic_Dictionary_TargetPointerShape__AbstractShape__TypeInfo
		                    );
		  System_Collections_Generic_Dictionary_Int32Enum__Int32Enum___set_Item
		            (uVar1,
		             Method_System_Collections_Generic_Dictionary_TargetPointerShape__AbstractShape___ctor__
		            );
		  uVar2 = unnamed_function_1417(Gameplay_Tutorial_Guide_Model_Shapes_CircleShape_TypeInfo);
		  func_ii_10812(uVar1,1,uVar2,
		                Method_System_Collections_Generic_Dictionary_TargetPointerShape__AbstractShape__Add__
		               );
		  uVar2 = unnamed_function_1417(Gameplay_Tutorial_Guide_Model_Shapes_RectangleShape_TypeInfo);
		  func_ii_10812(uVar1,2,uVar2,
		                Method_System_Collections_Generic_Dictionary_TargetPointerShape__AbstractShape__Add__
		               );
		  uVar2 = unnamed_function_1417(Gameplay_Tutorial_Guide_Model_Shapes_CircleShape_TypeInfo);
		  func_ii_10812(uVar1,3,uVar2,
		                Method_System_Collections_Generic_Dictionary_TargetPointerShape__AbstractShape__Add__
		               );
		  uVar2 = unnamed_function_1417(Gameplay_Tutorial_Guide_Model_Shapes_RectangleShape_TypeInfo);
		  func_ii_10812(uVar1,4,uVar2,
		                Method_System_Collections_Generic_Dictionary_TargetPointerShape__AbstractShape__Add__
		               );
		  *(undefined4 *)(param1 + 0x4c) = uVar1;
		  UnityEngine_RectTransform__GetParentSize(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x06001B29 RID: 6953 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B29")]
		[Address(RVA = "0x6CB3", Offset = "0x6CB3", VA = "0x6CB3")]
		public ShapePointer()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Tutorial_Guide_View_Components_ShapePointer___ctor(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined8 local_20;
		  undefined4 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  local_10 = *(undefined8 *)(param1 + 0x38);
		  local_8 = local_10;
		  Gameplay_Tutorial_Guide_View_Components_ShapePointer__TryGetShapeSprite
		            (param1,&local_10,&local_20);
		  param1_00 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                        (*(undefined4 *)(param1 + 0x14),0);
		  local_18 = *(undefined4 *)(param1 + 0x48);
		  local_20 = *(undefined8 *)(param1 + 0x40);
		  UnityEngine_Transform__get_position(param1_00,&local_20,0);
		  Gameplay_Tutorial_Guide_View_Components_ShapePointer__Move(param1,&local_20);
		  return;
		}
		*/

		}

		// Token: 0x04000E90 RID: 3728
		[Token(Token = "0x4000E90")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Overlap _overlap;

		// Token: 0x04000E91 RID: 3729
		[Token(Token = "0x4000E91")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private MaskingShape _maskingShape;

		// Token: 0x04000E92 RID: 3730
		[Token(Token = "0x4000E92")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform _outlineContainer;

		// Token: 0x04000E93 RID: 3731
		[Token(Token = "0x4000E93")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private ShapePointer.ShapeSpriteConfig[] _shapeSpritesConfigs;

		// Token: 0x04000E94 RID: 3732
		[Token(Token = "0x4000E94")]
		public const float MOVE_DURATION = 0.5f;

		// Token: 0x04000E95 RID: 3733
		[Token(Token = "0x4000E95")]
		public const float CHANGE_SIZE_DURATION = 0.7f;

		// Token: 0x04000E96 RID: 3734
		[Token(Token = "0x4000E96")]
		public const float OUTLINE_START_DELAY = 0.5f;

		// Token: 0x04000E98 RID: 3736
		[Token(Token = "0x4000E98")]
		[FieldOffset(Offset = "0x24")]
		private Image _shapeRender;

		// Token: 0x04000E99 RID: 3737
		[Token(Token = "0x4000E99")]
		[FieldOffset(Offset = "0x28")]
		private RectTransform _overlapTransform;

		// Token: 0x04000E9A RID: 3738
		[Token(Token = "0x4000E9A")]
		[FieldOffset(Offset = "0x2C")]
		private RectTransform _shapeTransform;

		// Token: 0x04000E9B RID: 3739
		[Token(Token = "0x4000E9B")]
		[FieldOffset(Offset = "0x30")]
		private Dictionary<TargetPointerShape, AbstractGuideOutline> _outlinesCache;

		// Token: 0x04000E9C RID: 3740
		[Token(Token = "0x4000E9C")]
		[FieldOffset(Offset = "0x34")]
		private AbstractGuideOutline _currentOutline;

		// Token: 0x04000E9D RID: 3741
		[Token(Token = "0x4000E9D")]
		[FieldOffset(Offset = "0x38")]
		public readonly Vector2 IdleSize;

		// Token: 0x04000E9F RID: 3743
		[Token(Token = "0x4000E9F")]
		[FieldOffset(Offset = "0x4C")]
		private Dictionary<TargetPointerShape, AbstractShape> _availShapes;

		// Token: 0x04000EA1 RID: 3745
		[Token(Token = "0x4000EA1")]
		[FieldOffset(Offset = "0x54")]
		private AbstractShape _shape;

		// Token: 0x02000477 RID: 1143
		[Token(Token = "0x2000477")]
		[Serializable]
		public class ShapeSpriteConfig
		{
			// Token: 0x06001B2B RID: 6955 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001B2B")]
			[Address(RVA = "0x6CB5", Offset = "0x6CB5", VA = "0x6CB5")]
			public ShapeSpriteConfig()
			{
			}

			// Token: 0x04000EA2 RID: 3746
			[Token(Token = "0x4000EA2")]
			[FieldOffset(Offset = "0x8")]
			public TargetPointerShape Shape;

			// Token: 0x04000EA3 RID: 3747
			[Token(Token = "0x4000EA3")]
			[FieldOffset(Offset = "0xC")]
			public Sprite Sprite;

			// Token: 0x04000EA4 RID: 3748
			[Token(Token = "0x4000EA4")]
			[FieldOffset(Offset = "0x10")]
			public AbstractGuideOutline Outline;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_IdlePosition ---
		undefined4
		Gameplay_Tutorial_Guide_View_Components_ShapePointer__set_IdlePosition(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a58476 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_Image___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a58476 = '\x01';
		  }
		  uVar2 = *(undefined4 *)(param1 + 0x24);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar1 = UnityEngine_Component__GetComponent_object_(uVar2,0);
		  if (iVar1 != 0) {
		    return *(undefined4 *)(param1 + 0x24);
		  }
		  uVar2 = func_ii_5677(*(undefined4 *)(param1 + 0x14),
		                       Method_UnityEngine_Component_GetComponent_Image___);
		  *(undefined4 *)(param1 + 0x24) = uVar2;
		  return uVar2;
		}
		*/


		/* --- GHIDRA: get_ShapeRender ---
		undefined4
		Gameplay_Tutorial_Guide_View_Components_ShapePointer__get_ShapeRender(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a58477 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_RectTransform___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a58477 = '\x01';
		  }
		  uVar2 = *(undefined4 *)(param1 + 0x2c);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar1 = UnityEngine_Component__GetComponent_object_(uVar2,0);
		  if (iVar1 != 0) {
		    return *(undefined4 *)(param1 + 0x2c);
		  }
		  uVar2 = func_ii_5677(*(undefined4 *)(param1 + 0x14),
		                       Method_UnityEngine_Component_GetComponent_RectTransform___);
		  *(undefined4 *)(param1 + 0x2c) = uVar2;
		  return uVar2;
		}
		*/


		/* --- GHIDRA: get_ShapeTransform ---
		undefined4
		Gameplay_Tutorial_Guide_View_Components_ShapePointer__get_ShapeTransform
		          (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a58478 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_RectTransform___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a58478 = '\x01';
		  }
		  uVar2 = *(undefined4 *)(param1 + 0x28);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar1 = UnityEngine_Component__GetComponent_object_(uVar2,0);
		  if (iVar1 != 0) {
		    return *(undefined4 *)(param1 + 0x28);
		  }
		  uVar2 = func_ii_5677(*(undefined4 *)(param1 + 0x10),
		                       Method_UnityEngine_Component_GetComponent_RectTransform___);
		  *(undefined4 *)(param1 + 0x28) = uVar2;
		  return uVar2;
		}
		*/


		/* --- GHIDRA: get_OverlapTransform ---
		void Gameplay_Tutorial_Guide_View_Components_ShapePointer__get_OverlapTransform
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a58479 == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a58479 = '\x01';
		  }
		  param1_00 = *(undefined4 *)(param1 + 0x34);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar1 = UnityEngine_TextCore_Text_TextElement__get_textAsset(param1_00,0,0);
		  if (iVar1 != 0) {
		    iVar1 = **(int **)(param1 + 0x34);
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xf0) * 4))
		              (*(int **)(param1 + 0x34),*(undefined4 *)(iVar1 + 0xf4));
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_IsResizeProcessNow ---
		void Gameplay_Tutorial_Guide_View_Components_ShapePointer__set_IsResizeProcessNow
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int *piVar2;
		  undefined4 param1_00;
		  
		  *(undefined1 *)(param1 + 0x50) = 1;
		  if (DAT_ram_00a58476 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_Image___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a58476 = '\x01';
		  }
		  param1_00 = *(undefined4 *)(param1 + 0x24);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar1 = UnityEngine_Component__GetComponent_object_(param1_00,0);
		  if (iVar1 == 0) {
		    piVar2 = (int *)func_ii_5677(*(undefined4 *)(param1 + 0x14),
		                                 Method_UnityEngine_Component_GetComponent_Image___);
		    *(int **)(param1 + 0x24) = piVar2;
		  }
		  else {
		    piVar2 = *(int **)(param1 + 0x24);
		  }
		  (**(code **)((ulonglong)*(uint *)(*piVar2 + 0x188) * 4))
		            (piVar2,1,*(undefined4 *)(*piVar2 + 0x18c));
		  return;
		}
		*/


		/* --- GHIDRA: get_Shape ---
		void Gameplay_Tutorial_Guide_View_Components_ShapePointer__get_Shape
		               (int param1,int param2,undefined4 param3)
		
		{
		  if (param2 != *(int *)(param1 + 0x54)) {
		    *(int *)(param1 + 0x54) = param2;
		    Gameplay_Tutorial_Guide_View_Components_ShapePointer__set_Shape(param1,param1,param2,param1);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_Shape ---
		void Gameplay_Tutorial_Guide_View_Components_ShapePointer__set_Shape
		               (int param1,undefined4 param2,int *param3,undefined4 param4)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 *puVar3;
		  undefined4 param2_00;
		  undefined4 uVar4;
		  int iVar5;
		  undefined4 local_4;
		  
		  if (param3 != (int *)0x0) {
		    local_4 = 0;
		    puVar3 = &local_4;
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param3 + 0xf8) * 4))
		                      (param3,&local_4,*(undefined4 *)(*param3 + 0xfc));
		    if (iVar2 == 0) {
		      iVar2 = *(int *)(*(int *)(param1 + 0x1c) + 0xc);
		      if (0 < iVar2) {
		        iVar1 = 0;
		        do {
		          iVar5 = *(int *)(*(int *)(param1 + 0x1c) + iVar1 * 4 + 0x10);
		          if (*(int *)(*(int *)(param3[2] + 0x24) + 8) == *(int *)(iVar5 + 8)) {
		            puVar3 = (undefined4 *)(iVar5 + 0xc);
		            goto code_r0x80ef11ef;
		          }
		          iVar1 = iVar1 + 1;
		        } while (iVar1 != iVar2);
		      }
		    }
		    else {
		code_r0x80ef11ef:
		      param2_00 = *puVar3;
		      if (DAT_ram_00a58476 == '\0') {
		        Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_Image___);
		        Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		        DAT_ram_00a58476 = '\x01';
		      }
		      uVar4 = *(undefined4 *)(param1 + 0x24);
		      if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		        func_ii_306000(UnityEngine_Object_TypeInfo);
		      }
		      iVar2 = UnityEngine_Component__GetComponent_object_(uVar4,0);
		      if (iVar2 == 0) {
		        uVar4 = func_ii_5677(*(undefined4 *)(param1 + 0x14),
		                             Method_UnityEngine_Component_GetComponent_Image___);
		        *(undefined4 *)(param1 + 0x24) = uVar4;
		      }
		      else {
		        uVar4 = *(undefined4 *)(param1 + 0x24);
		      }
		      func_ii_7050(uVar4,param2_00,0);
		    }
		  }
		  return;
		}
		*/


		/* --- GHIDRA: get_OverlapType ---
		void Gameplay_Tutorial_Guide_View_Components_ShapePointer__get_OverlapType
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a5847f == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_MonoBehaviourWithStates_OverlapType__set_CurrentState__)
		    ;
		    DAT_ram_00a5847f = '\x01';
		  }
		  Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		            (*(undefined4 *)(param1 + 0x10),param2,
		             Method_UI_MonoBehaviourWithStates_OverlapType__set_CurrentState__);
		  return;
		}
		*/


		/* --- GHIDRA: set_OverlapType ---
		void Gameplay_Tutorial_Guide_View_Components_ShapePointer__set_OverlapType
		               (int param1,undefined8 *param2,undefined4 param3)
		
		{
		  undefined4 param2_00;
		  int iVar1;
		  undefined8 uVar2;
		  undefined1 auStack_20 [8];
		  undefined8 local_18;
		  undefined4 local_10;
		  undefined8 local_c;
		  undefined4 local_4;
		  
		  uVar2 = *param2;
		  iVar1 = *(int *)(param1 + 0x54);
		  *(undefined8 *)(iVar1 + 0x14) = param2[1];
		  *(undefined8 *)(iVar1 + 0xc) = uVar2;
		  param2_00 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                        (*(undefined4 *)(param1 + 0x14),0);
		  local_18 = *(undefined8 *)(*(int *)(param1 + 0x54) + 0xc);
		  local_4 = 0;
		  local_10 = 0;
		  local_c = local_18;
		  Gameplay_Tutorial_Guide_View_Components_ShapePointer__Move
		            (param1,param2_00,&local_18,0.5,auStack_20);
		  return;
		}
		*/

}
