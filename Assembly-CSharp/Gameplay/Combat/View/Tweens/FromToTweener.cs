using System;
using Core.Extensions;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;
using Utils;

namespace Gameplay.Combat.View.Tweens
{
	// Token: 0x02000931 RID: 2353
	[Token(Token = "0x2000931")]
	public class FromToTweener : FromToSpriteRenderTweener
	{
		// Token: 0x06003783 RID: 14211 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003783")]
		[Address(RVA = "0x876E", Offset = "0x876E", VA = "0x876E")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_Combat_View_Tweens_FromToTweener__OnDestroy(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  param1_00 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                        (param1,0);
		  Core_Extensions_StringExt__GetDeclension(param1_00,param1 + 0x90,0);
		  return;
		}
		*/

		}

		// Token: 0x06003784 RID: 14212 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003784")]
		[Address(RVA = "0x876F", Offset = "0x876F", VA = "0x876F")]
		private void Awake()
		{
		/* --- GHIDRA: Awake ---
		void Gameplay_Combat_View_Tweens_FromToTweener__Awake(undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_Combat_View_Tweens_FromToSpriteRenderTweener__Awake(param1,param1);
		  Gameplay_Combat_View_Tweens_FromToTweener__Start(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06003785 RID: 14213 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003785")]
		[Address(RVA = "0x8770", Offset = "0x8770", VA = "0x8770", Slot = "4")]
		protected override void Start()
		{
		/* --- GHIDRA: Start ---
		void Gameplay_Combat_View_Tweens_FromToTweener__Start(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 param1_00;
		  int *piVar3;
		  undefined1 auStack_20 [8];
		  int local_18;
		  undefined8 *local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a566c6 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_FromToSpriteRenderTweener__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_FromToSpriteRenderTweener__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_FromToSpriteRenderTweener__get_Current__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_FromToSpriteRenderTweener__GetEnumerator__);
		    DAT_ram_00a566c6 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  Gameplay_Combat_View_Tweens_FromToTweener__Play
		            (param1,param1 + 0x40,auStack_20,0.0,0.0,0.0,0.0,auStack_20);
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_10,*(undefined4 *)(param1 + 0x3c),
		             Method_System_Collections_Generic_List_FromToSpriteRenderTweener__GetEnumerator__);
		  local_18 = 0;
		  local_14 = &local_10;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar2 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_10,
		                       Method_System_Collections_Generic_List_Enumerator_FromToSpriteRenderTweener__MoveNext__
		                      );
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) {
		      param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80c66be0;
		    }
		    if (iVar2 == 0) {
		      DAT_ram_009d3e38 = 0;
		      return;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_vii
		              (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x205,local_8._4_4_,auStack_20);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar1 != 1);
		  param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80c66be0:
		  iVar1 = global_1;
		  iVar2 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar1 == iVar2) {
		    piVar3 = (int *)import::env::__cxa_begin_catch(param1_00);
		    iVar2 = *piVar3;
		    DAT_ram_009d3e38 = 0;
		    local_18 = iVar2;
		    import::env::invoke_v(0x123);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 != 1) {
		      if (iVar2 == 0) {
		        DAT_ram_009d3e38 = 0;
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    param1_00 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_000017c8 + 0x209,&local_18);
		  iVar1 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar1 != 1) {
		    import::env::__resumeException(param1_00);
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

		// Token: 0x06003786 RID: 14214 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003786")]
		[Address(RVA = "0x8771", Offset = "0x8771", VA = "0x8771")]
		public new void Rollback()
		{
		/* --- GHIDRA: Rollback ---
		void Gameplay_Combat_View_Tweens_FromToTweener__Rollback(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 param1_00;
		  int *piVar3;
		  undefined1 auStack_20 [8];
		  int local_18;
		  undefined8 *local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a566c7 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_FromToSpriteRenderTweener__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_FromToSpriteRenderTweener__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_FromToSpriteRenderTweener__get_Current__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_FromToSpriteRenderTweener__GetEnumerator__);
		    DAT_ram_00a566c7 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  Gameplay_Combat_View_Tweens_FromToTweener__Play
		            (param1,param1 + 0x90,auStack_20,*(float *)(param1 + 0x8c),0.0,*(float *)(param1 + 0x88)
		             ,0.0,auStack_20);
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_10,*(undefined4 *)(param1 + 0x3c),
		             Method_System_Collections_Generic_List_FromToSpriteRenderTweener__GetEnumerator__);
		  local_18 = 0;
		  local_14 = &local_10;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar2 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_10,
		                       Method_System_Collections_Generic_List_Enumerator_FromToSpriteRenderTweener__MoveNext__
		                      );
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) {
		      param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80c66fb4;
		    }
		    if (iVar2 == 0) {
		      DAT_ram_009d3e38 = 0;
		      return;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_vii
		              (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x207,local_8._4_4_,auStack_20);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar1 != 1);
		  param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80c66fb4:
		  iVar1 = global_1;
		  iVar2 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar1 == iVar2) {
		    piVar3 = (int *)import::env::__cxa_begin_catch(param1_00);
		    iVar2 = *piVar3;
		    DAT_ram_009d3e38 = 0;
		    local_18 = iVar2;
		    import::env::invoke_v(0x123);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 != 1) {
		      if (iVar2 == 0) {
		        DAT_ram_009d3e38 = 0;
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    param1_00 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_000017c8 + 0x20a,&local_18);
		  iVar1 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar1 != 1) {
		    import::env::__resumeException(param1_00);
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

		// Token: 0x06003787 RID: 14215 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003787")]
		[Address(RVA = "0x8772", Offset = "0x8772", VA = "0x8772")]
		public new void Play()
		{
		/* --- GHIDRA: Play ---
		void Gameplay_Combat_View_Tweens_FromToTweener__Play(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a566c9 == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_TweenContainer_TypeInfo);
		    DAT_ram_00a566c9 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Utils_TweenContainer_TypeInfo);
		  Utils_TweenContainer__Dispose(uVar1,0);
		  *(undefined4 *)(param1 + 0xd8) = uVar1;
		  if (DAT_ram_00a566c5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_FromToSpriteRenderTweener___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_List_FromToSpriteRenderTweener__TypeInfo);
		    DAT_ram_00a566c5 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(System_Collections_Generic_List_FromToSpriteRenderTweener__TypeInfo)
		  ;
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (uVar1,Method_System_Collections_Generic_List_FromToSpriteRenderTweener___ctor__);
		  *(undefined4 *)(param1 + 0x3c) = uVar1;
		  UnityEngine_RectTransform__GetParentSize(param1,0);
		  return;
		}
		*/

		/* --- GHIDRA: Play ---
		void Gameplay_Combat_View_Tweens_FromToTweener__Play(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a566c9 == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_TweenContainer_TypeInfo);
		    DAT_ram_00a566c9 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Utils_TweenContainer_TypeInfo);
		  Utils_TweenContainer__Dispose(uVar1,0);
		  *(undefined4 *)(param1 + 0xd8) = uVar1;
		  if (DAT_ram_00a566c5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_FromToSpriteRenderTweener___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_List_FromToSpriteRenderTweener__TypeInfo);
		    DAT_ram_00a566c5 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(System_Collections_Generic_List_FromToSpriteRenderTweener__TypeInfo)
		  ;
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (uVar1,Method_System_Collections_Generic_List_FromToSpriteRenderTweener___ctor__);
		  *(undefined4 *)(param1 + 0x3c) = uVar1;
		  UnityEngine_RectTransform__GetParentSize(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x06003788 RID: 14216 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003788")]
		[Address(RVA = "0x8773", Offset = "0x8773", VA = "0x8773")]
		private void Play(in TransformExt.TransformData toTransformData, in Color toColor, float transformDelay, float fadeDelay, float transformDuration, float fadeDuration)
		{
		}

		// Token: 0x06003789 RID: 14217 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003789")]
		[Address(RVA = "0x8774", Offset = "0x8774", VA = "0x8774")]
		public FromToTweener()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Combat_View_Tweens_FromToTweener___ctor(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined8 local_10;
		  undefined4 local_8;
		  
		  if (DAT_ram_00a566ca == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_SetEase_TweenerCore_Vector3__Vector3__VectorOptions____
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_SetLoops_TweenerCore_Vector3__Vector3__VectorOptions____
		              );
		    DAT_ram_00a566ca = '\x01';
		  }
		  uVar1 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                    (param1,0);
		  local_8 = *(undefined4 *)(param1 + 0x18);
		  local_10 = *(undefined8 *)(param1 + 0x10);
		  uVar1 = System_Collections_Generic_Queue_object___Dequeue
		                    (uVar1,&local_10,*(float *)(param1 + 0x1c),0);
		  uVar1 = DG_Tweening_TweenSettingsExtensions__SetLoops_object_
		                    (uVar1,0xffffffff,1,
		                     Method_DG_Tweening_TweenSettingsExtensions_SetLoops_TweenerCore_Vector3__Vector3__VectorOptions____
		                    );
		  uVar1 = DG_Tweening_ShortcutExtensions__DOScale
		                    (uVar1,*(undefined4 *)(param1 + 0x20),
		                     Method_DG_Tweening_TweenSettingsExtensions_SetEase_TweenerCore_Vector3__Vector3__VectorOptions____
		                    );
		  *(undefined4 *)(param1 + 0x24) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x04001EA3 RID: 7843
		[Token(Token = "0x4001EA3")]
		[FieldOffset(Offset = "0x40")]
		public TransformExt.TransformData FromTransform;

		// Token: 0x04001EA4 RID: 7844
		[Token(Token = "0x4001EA4")]
		[FieldOffset(Offset = "0x88")]
		[FormerlySerializedAs("_transfromDuration")]
		public float TransfromDuration;

		// Token: 0x04001EA5 RID: 7845
		[Token(Token = "0x4001EA5")]
		[FieldOffset(Offset = "0x8C")]
		[FormerlySerializedAs("_transformDelay")]
		public float TransformDelay;

		// Token: 0x04001EA6 RID: 7846
		[Token(Token = "0x4001EA6")]
		[FieldOffset(Offset = "0x90")]
		public TransformExt.TransformData ToTransform;

		// Token: 0x04001EA7 RID: 7847
		[Token(Token = "0x4001EA7")]
		[FieldOffset(Offset = "0xD8")]
		private TweenContainer _tweenContainer;
	}
}
