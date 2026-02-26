using System;
using System.Collections;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Animations
{
	// Token: 0x0200132C RID: 4908
	[Token(Token = "0x200132C")]
	public class ChestAnimationTarget : MonoBehaviour, IAnimationTarget
	{
		// Token: 0x0600744E RID: 29774 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600744E")]
		[Address(RVA = "0xBE1A", Offset = "0xBE1A", VA = "0xBE1A")]
		private void OnEnable()
		{
		/* --- GHIDRA: <OnAnimationEnd>b__12_0 ---
		void Animations_ChestAnimationTarget___OnAnimationEnd_b__12_0
		               (undefined8 *param1,undefined8 *param2,undefined8 *param3,undefined8 *param4,
		               undefined4 param5)
		
		{
		  *param1 = *param2;
		  *(undefined4 *)(param1 + 1) = *(undefined4 *)(param2 + 1);
		  *(undefined8 *)((int)param1 + 0xc) = *param3;
		  *(undefined4 *)((int)param1 + 0x14) = *(undefined4 *)(param3 + 1);
		  param1[3] = *param4;
		  *(undefined4 *)(param1 + 4) = *(undefined4 *)(param4 + 1);
		  return;
		}
		*/

		/* --- GHIDRA: OnEnable ---
		void Animations_ChestAnimationTarget__OnEnable(undefined4 param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar3;
		  
		  if (DAT_ram_00a596a9 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a596a9 = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_01 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar3 = *param1_01;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x150);
		        goto code_r0x8104c314;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0x12);
		code_r0x8104c314:
		  param1_00 = (**(code **)((ulonglong)*puVar2 * 4))(param1_01,puVar2[1]);
		  Core_Gameplay_Managers_ArtifactDropManager__AddAnimationTarget(param1_00,param1,0);
		  return;
		}
		*/

		}

		// Token: 0x0600744F RID: 29775 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600744F")]
		[Address(RVA = "0xBE1B", Offset = "0xBE1B", VA = "0xBE1B")]
		private void OnDisable()
		{
		/* --- GHIDRA: OnDisable ---
		float Animations_ChestAnimationTarget__OnDisable(int param1,undefined4 param2,undefined4 param3)
		
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
		  float4 fVar12;
		  undefined4 uVar13;
		  undefined4 uVar14;
		  float fVar15;
		  float *pfVar16;
		  int iVar17;
		  float fVar18;
		  float fVar19;
		  float fVar20;
		  undefined8 local_68;
		  undefined4 local_60;
		  undefined8 local_58;
		  undefined8 local_50;
		  undefined8 local_48;
		  undefined4 local_40;
		  undefined8 local_38;
		  undefined4 local_30;
		  float4 local_2c;
		  float4 local_28;
		  float4 local_24;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined8 local_c;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a596aa == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Animations_ChestAnimationTarget_ModifyPosition__);
		    Mono_Security_ASN1__get_Item(&Method_Animations_ChestAnimationTarget_OnAnimationEnd__);
		    Mono_Security_ASN1__get_Item(&Method_Animations_ChestAnimationTarget__StartAnimation_b__11_0__);
		    Mono_Security_ASN1__get_Item(&DG_Tweening_Core_DOGetter_float__TypeInfo);
		    Mono_Security_ASN1__get_Item(&DG_Tweening_Core_DOSetter_float__TypeInfo);
		    Mono_Security_ASN1__get_Item(&DG_Tweening_DOTween_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_ParticleSystem___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item(&DG_Tweening_TweenCallback_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_OnComplete_TweenerCore_float__float__FloatOptions____
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_SetEase_TweenerCore_float__float__FloatOptions____
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_SetEase_TweenerCore_Vector3__Vector3__VectorOptions____
		              );
		    Mono_Security_ASN1__get_Item(&Method_DG_Tweening_TweenSettingsExtensions_SetLink_Sequence___);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_SetLink_TweenerCore_float__float__FloatOptions____
		              );
		    DAT_ram_00a596aa = '\x01';
		  }
		  *(undefined4 *)(param1 + 0x18) = 0;
		  *(undefined4 *)(param1 + 0x28) = param2;
		  uVar13 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                     (param1,0);
		  UnityEngine_GameObject___ctor(param2,uVar13,1,0);
		  uVar14 = *(undefined4 *)(param1 + 0x14);
		  uVar13 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                     (param1,0);
		  func_ii_7888(&local_c,uVar13,0);
		  if (DAT_ram_00a65d4a == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Quaternion_TypeInfo);
		    DAT_ram_00a65d4a = '\x01';
		  }
		  local_18 = (*(undefined8 **)(UnityEngine_Quaternion_TypeInfo + 0x5c))[1];
		  local_20 = **(undefined8 **)(UnityEngine_Quaternion_TypeInfo + 0x5c);
		  uVar13 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                     (param1,0);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  local_40 = local_4;
		  local_50 = local_18;
		  local_48 = local_c;
		  local_58 = local_20;
		  uVar13 = UnityEngine_Object__Instantiate_object_
		                     (uVar14,&local_48,&local_58,uVar13,
		                      Method_UnityEngine_Object_Instantiate_ParticleSystem___);
		  *(undefined4 *)(param1 + 0x50) = uVar13;
		  UnityEngine_ParticleSystem__Play(uVar13,0);
		  uVar13 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                     (param1,0);
		  func_ii_7888(&local_2c,uVar13,0);
		  fVar9 = local_24;
		  fVar5 = local_28;
		  fVar1 = local_2c;
		  func_ii_7888(&local_2c,param2,0);
		  fVar10 = local_24;
		  fVar6 = local_28;
		  fVar2 = local_2c;
		  uVar13 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                     (param1,0);
		  func_ii_7888(&local_2c,uVar13,0);
		  fVar11 = local_24;
		  fVar7 = local_28;
		  fVar3 = local_2c;
		  func_ii_7888(&local_2c,param2,0);
		  fVar12 = local_24;
		  fVar8 = local_28;
		  fVar4 = local_2c;
		  if (DAT_ram_00a50fa0 == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Vector3_TypeInfo);
		    DAT_ram_00a50fa0 = '\x01';
		  }
		  iVar17 = *(int *)(UnityEngine_Vector3_TypeInfo + 0x5c);
		  fVar18 = *(float *)(iVar17 + 0x54);
		  fVar19 = *(float *)(iVar17 + 0x58);
		  fVar20 = *(float *)(iVar17 + 0x5c);
		  if (DAT_ram_00a648f0 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Math_TypeInfo);
		    DAT_ram_00a648f0 = '\x01';
		  }
		  fVar15 = ((float)fVar5 - (float)fVar6) * fVar18 - ((float)fVar1 - (float)fVar2) * fVar19;
		  fVar18 = ((float)fVar1 - (float)fVar2) * fVar20 - ((float)fVar9 - (float)fVar10) * fVar18;
		  fVar19 = ((float)fVar9 - (float)fVar10) * fVar19 - ((float)fVar5 - (float)fVar6) * fVar20;
		  if (*(int *)(System_Math_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_Math_TypeInfo);
		  }
		  fVar20 = SQRT(fVar15 * fVar15 + fVar19 * fVar19 + fVar18 * fVar18);
		  if (1e-05 < fVar20) {
		    fVar15 = fVar15 / fVar20;
		    fVar18 = fVar18 / fVar20;
		    fVar19 = fVar19 / fVar20;
		  }
		  else {
		    if (DAT_ram_00a65020 == '\0') {
		      Mono_Security_ASN1__get_Item(&UnityEngine_Vector3_TypeInfo);
		      DAT_ram_00a65020 = '\x01';
		    }
		    pfVar16 = *(float **)(UnityEngine_Vector3_TypeInfo + 0x5c);
		    fVar15 = pfVar16[2];
		    fVar18 = pfVar16[1];
		    fVar19 = *pfVar16;
		  }
		  fVar20 = *(float *)(param1 + 0x1c);
		  func_ii_7888(&local_2c,param2,0);
		  uVar13 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                     (param1,0);
		  func_ii_7888(&local_38,uVar13,0);
		  *(float4 *)(param1 + 0x34) = local_24;
		  *(ulonglong *)(param1 + 0x2c) = CONCAT44(local_28,local_2c);
		  *(float *)(param1 + 0x40) = ((float)fVar11 + (float)fVar12) * 0.5 + fVar15 * fVar20;
		  *(float *)(param1 + 0x3c) = ((float)fVar7 + (float)fVar8) * 0.5 + fVar18 * fVar20;
		  *(float *)(param1 + 0x38) = ((float)fVar3 + (float)fVar4) * 0.5 + fVar19 * fVar20;
		  *(undefined8 *)(param1 + 0x44) = local_38;
		  *(undefined4 *)(param1 + 0x4c) = local_30;
		  uVar13 = unnamed_function_1417(DG_Tweening_Core_DOGetter_float__TypeInfo);
		  DG_Tweening_Core_DOGetter_Rect___Invoke
		            (uVar13,param1,Method_Animations_ChestAnimationTarget__StartAnimation_b__11_0__,0);
		  uVar14 = unnamed_function_1417(DG_Tweening_Core_DOSetter_float__TypeInfo);
		  DG_Tweening_Core_DOSetter_Rect___Invoke
		            (uVar14,param1,Method_Animations_ChestAnimationTarget_ModifyPosition__,0);
		  fVar18 = *(float *)(param1 + 0x20);
		  if (*(int *)(DG_Tweening_DOTween_TypeInfo + 0x74) == 0) {
		    func_ii_306000(DG_Tweening_DOTween_TypeInfo);
		  }
		  uVar13 = DG_Tweening_DOTween__ManualUpdate(uVar13,uVar14,1.0,fVar18,0);
		  uVar13 = DG_Tweening_ShortcutExtensions__DOScale
		                     (uVar13,*(undefined4 *)(param1 + 0x24),
		                      Method_DG_Tweening_TweenSettingsExtensions_SetEase_TweenerCore_float__float__FloatOptions____
		                     );
		  uVar14 = unnamed_function_1417(DG_Tweening_TweenCallback_TypeInfo);
		  DG_Tweening_Color2__op_Multiply
		            (uVar14,param1,Method_Animations_ChestAnimationTarget_OnAnimationEnd__,0);
		  uVar13 = DG_Tweening_TweenSettingsExtensions__From___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType____Il2CppFullySharedGenericStructType_
		                     (uVar13,uVar14,
		                      Method_DG_Tweening_TweenSettingsExtensions_OnComplete_TweenerCore_float__float__FloatOptions____
		                     );
		  uVar14 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                     (param2,0);
		  DG_Tweening_TweenSettingsExtensions__SetDelay_object_
		            (uVar13,uVar14,
		             Method_DG_Tweening_TweenSettingsExtensions_SetLink_TweenerCore_float__float__FloatOptions____
		            );
		  uVar13 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                     (param2,0);
		  if (DAT_ram_00a6501f == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Vector3_TypeInfo);
		    DAT_ram_00a6501f = '\x01';
		  }
		  local_60 = *(undefined4 *)(*(int *)(UnityEngine_Vector3_TypeInfo + 0x5c) + 0x14);
		  local_68 = *(undefined8 *)(*(int *)(UnityEngine_Vector3_TypeInfo + 0x5c) + 0xc);
		  Com_TheFallenGames_OSA_Core_OSA_object__object___SetNormalizedPosition(uVar13,&local_68,0);
		  uVar13 = DG_Tweening_DOTween__To(0);
		  uVar14 = DG_Tweening_ShortcutExtensions__DOLocalRotateQuaternion(param2,0.7,0.2,0);
		  DG_Tweening_TweenParams___cctor(uVar13,uVar14,0);
		  uVar14 = DG_Tweening_ShortcutExtensions__DOLocalRotateQuaternion(param2,0.9,0.2,0);
		  DG_Tweening_TweenParams___cctor(uVar13,uVar14,0);
		  uVar14 = DG_Tweening_ShortcutExtensions__DOLocalRotateQuaternion(param2,0.4,0.2,0);
		  uVar14 = DG_Tweening_ShortcutExtensions__DOScale
		                     (uVar14,0x1a,
		                      Method_DG_Tweening_TweenSettingsExtensions_SetEase_TweenerCore_Vector3__Vector3__VectorOptions____
		                     );
		  DG_Tweening_TweenParams___cctor(uVar13,uVar14,0);
		  uVar14 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                     (param2,0);
		  DG_Tweening_TweenSettingsExtensions__SetDelay_object_
		            (uVar13,uVar14,Method_DG_Tweening_TweenSettingsExtensions_SetLink_Sequence___);
		  return 0.6;
		}
		*/

		}

		// Token: 0x06007450 RID: 29776 RVA: 0x00014EF8 File Offset: 0x000130F8
		[Token(Token = "0x6007450")]
		[Address(RVA = "0xBE1C", Offset = "0xBE1C", VA = "0xBE1C", Slot = "4")]
		public float StartAnimation(Transform movable)
		{
		/* --- GHIDRA: StartAnimation ---
		void Animations_ChestAnimationTarget__StartAnimation(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  undefined8 local_18;
		  undefined4 local_10;
		  undefined8 local_c;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a596ab == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Animations_ChestAnimationTarget__OnAnimationEnd_b__12_0__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item(&DG_Tweening_TweenCallback_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_OnComplete_TweenerCore_Vector3__Vector3__VectorOptions____
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_SetLink_TweenerCore_Vector3__Vector3__VectorOptions____
		              );
		    DAT_ram_00a596ab = '\x01';
		  }
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x10),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,1,0);
		  uVar1 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                    (*(undefined4 *)(param1 + 0x10),0);
		  local_4 = 0x3dcccccd;
		  local_10 = 0x3dcccccd;
		  local_c = 0x3dcccccd3dcccccd;
		  local_18 = 0x3dcccccd3dcccccd;
		  Com_TheFallenGames_OSA_Core_OSA_object__object___SetNormalizedPosition(uVar1,&local_18,0);
		  uVar1 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                    (*(undefined4 *)(param1 + 0x10),0);
		  uVar1 = DG_Tweening_ShortcutExtensions__DOLocalRotateQuaternion(uVar1,1.0,0.2,0);
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x10),0);
		  uVar1 = DG_Tweening_TweenSettingsExtensions__SetDelay_object_
		                    (uVar1,uVar2,
		                     Method_DG_Tweening_TweenSettingsExtensions_SetLink_TweenerCore_Vector3__Vector3__VectorOptions____
		                    );
		  uVar2 = unnamed_function_1417(DG_Tweening_TweenCallback_TypeInfo);
		  DG_Tweening_Color2__op_Multiply
		            (uVar2,param1,Method_Animations_ChestAnimationTarget__OnAnimationEnd_b__12_0__,0);
		  DG_Tweening_TweenSettingsExtensions__From___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType____Il2CppFullySharedGenericStructType_
		            (uVar1,uVar2,
		             Method_DG_Tweening_TweenSettingsExtensions_OnComplete_TweenerCore_Vector3__Vector3__VectorOptions____
		            );
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x28),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,0,0);
		  UnityEngine_ParticleSystem__Play(*(undefined4 *)(param1 + 0x50),1,1,0);
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (param1,0);
		  iVar3 = UnityEngine_InputSystem_Users_InputUser__UnpairDevices(uVar1,0);
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x50),0);
		  if (iVar3 == 0) {
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UnityEngine_Object_TypeInfo);
		    }
		    UnityEngine_Application__get_isPlaying(uVar1,0);
		  }
		  else {
		    if (DAT_ram_00a596ac == '\0') {
		      Mono_Security_ASN1__get_Item(&Animations_ChestAnimationTarget__DelayedDestroy_d__14_TypeInfo);
		      DAT_ram_00a596ac = '\x01';
		    }
		    iVar3 = unnamed_function_1417(Animations_ChestAnimationTarget__DelayedDestroy_d__14_TypeInfo);
		    *(undefined4 *)(iVar3 + 0x10) = uVar1;
		    *(undefined4 *)(iVar3 + 8) = 0;
		    UnityEngine_MonoBehaviour__StartCoroutine(param1,iVar3,0);
		  }
		  return;
		}
		*/

			return 0f;
		}

		// Token: 0x06007451 RID: 29777 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007451")]
		[Address(RVA = "0xBE1D", Offset = "0xBE1D", VA = "0xBE1D")]
		private void OnAnimationEnd()
		{
		/* --- GHIDRA: OnAnimationEnd ---
		void Animations_ChestAnimationTarget__OnAnimationEnd(int param1,float param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  float fVar1;
		  float fVar2;
		  float fVar3;
		  undefined8 local_38;
		  undefined4 local_30;
		  undefined8 local_28;
		  float local_20;
		  undefined8 local_18;
		  undefined4 local_10;
		  float4 local_c;
		  float4 local_8;
		  float4 local_4;
		  
		  *(float *)(param1 + 0x18) = param2;
		  fVar1 = 1.0 - param2;
		  fVar2 = fVar1 * fVar1;
		  fVar1 = (fVar1 + fVar1) * param2;
		  fVar3 = param2 * param2;
		  local_20 = fVar2 * *(float *)(param1 + 0x34) + fVar1 * *(float *)(param1 + 0x40) +
		             fVar3 * *(float *)(param1 + 0x4c);
		  local_8 = (float4)(fVar2 * *(float *)(param1 + 0x30) + fVar1 * *(float *)(param1 + 0x3c) +
		                    fVar3 * *(float *)(param1 + 0x48));
		  local_c = (float4)(fVar2 * *(float *)(param1 + 0x2c) + fVar1 * *(float *)(param1 + 0x38) +
		                    fVar3 * *(float *)(param1 + 0x44));
		  local_28 = CONCAT44(local_8,local_c);
		  local_4 = (float4)local_20;
		  UnityEngine_Transform__get_position(*(undefined4 *)(param1 + 0x28),&local_28,0);
		  param1_00 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                        (*(undefined4 *)(param1 + 0x50),0);
		  func_ii_7888(&local_18,*(undefined4 *)(param1 + 0x28),0);
		  local_30 = local_10;
		  local_38 = local_18;
		  UnityEngine_Transform__get_position(param1_00,&local_38,0);
		  return;
		}
		*/

		}

		// Token: 0x06007452 RID: 29778 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007452")]
		[Address(RVA = "0xBE1E", Offset = "0xBE1E", VA = "0xBE1E")]
		private void ModifyPosition(float t)
		{
		/* --- GHIDRA: ModifyPosition ---
		int Animations_ChestAnimationTarget__ModifyPosition
		              (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a596ac == '\0') {
		    Mono_Security_ASN1__get_Item(&Animations_ChestAnimationTarget__DelayedDestroy_d__14_TypeInfo);
		    DAT_ram_00a596ac = '\x01';
		  }
		  iVar1 = unnamed_function_1417(Animations_ChestAnimationTarget__DelayedDestroy_d__14_TypeInfo);
		  *(undefined4 *)(iVar1 + 0x10) = param2;
		  *(undefined4 *)(iVar1 + 8) = 0;
		  return iVar1;
		}
		*/

		}

		// Token: 0x06007453 RID: 29779 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007453")]
		[Address(RVA = "0xBE1F", Offset = "0xBE1F", VA = "0xBE1F")]
		private IEnumerator DelayedDestroy(GameObject go)
		{
		/* --- GHIDRA: DelayedDestroy ---
		void Animations_ChestAnimationTarget__DelayedDestroy(int param1,undefined4 param2)
		
		{
		  *(undefined4 *)(param1 + 0x24) = 2;
		  *(undefined8 *)(param1 + 0x1c) = 0x3f19999a42c80000;
		  UnityEngine_RectTransform__GetParentSize(param1,0);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06007454 RID: 29780 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007454")]
		[Address(RVA = "0xBE20", Offset = "0xBE20", VA = "0xBE20")]
		public ChestAnimationTarget()
		{
		}

		// Token: 0x04003CE3 RID: 15587
		[Token(Token = "0x4003CE3")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Image _image;

		// Token: 0x04003CE4 RID: 15588
		[Token(Token = "0x4003CE4")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private ParticleSystem _particleSystem;

		// Token: 0x04003CE5 RID: 15589
		[Token(Token = "0x4003CE5")]
		[FieldOffset(Offset = "0x18")]
		private float _t;

		// Token: 0x04003CE6 RID: 15590
		[Token(Token = "0x4003CE6")]
		[FieldOffset(Offset = "0x1C")]
		private float _curve;

		// Token: 0x04003CE7 RID: 15591
		[Token(Token = "0x4003CE7")]
		[FieldOffset(Offset = "0x20")]
		private float _duration;

		// Token: 0x04003CE8 RID: 15592
		[Token(Token = "0x4003CE8")]
		[FieldOffset(Offset = "0x24")]
		private Ease _ease;

		// Token: 0x04003CE9 RID: 15593
		[Token(Token = "0x4003CE9")]
		[FieldOffset(Offset = "0x28")]
		private Transform _movable;

		// Token: 0x04003CEA RID: 15594
		[Token(Token = "0x4003CEA")]
		[FieldOffset(Offset = "0x2C")]
		private ChestAnimationTarget.BezierCurve _bezierCurve;

		// Token: 0x04003CEB RID: 15595
		[Token(Token = "0x4003CEB")]
		[FieldOffset(Offset = "0x50")]
		private ParticleSystem _ps;

		// Token: 0x0200132D RID: 4909
		[Token(Token = "0x200132D")]
		private readonly struct BezierCurve
		{
			// Token: 0x06007457 RID: 29783 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007457")]
			[Address(RVA = "0xBE23", Offset = "0xBE23", VA = "0xBE23")]
			public BezierCurve(Vector3 a, Vector3 b, Vector3 c)
			{
			}

			// Token: 0x06007458 RID: 29784 RVA: 0x00014F28 File Offset: 0x00013128
			[Token(Token = "0x6007458")]
			[Address(RVA = "0xBE24", Offset = "0xBE24", VA = "0xBE24")]
			public Vector3 GetPosition(float t)
			{
				return default(Vector3);
			}

			// Token: 0x04003CEC RID: 15596
			[Token(Token = "0x4003CEC")]
			[FieldOffset(Offset = "0x0")]
			public readonly Vector3 A;

			// Token: 0x04003CED RID: 15597
			[Token(Token = "0x4003CED")]
			[FieldOffset(Offset = "0xC")]
			public readonly Vector3 B;

			// Token: 0x04003CEE RID: 15598
			[Token(Token = "0x4003CEE")]
			[FieldOffset(Offset = "0x18")]
			public readonly Vector3 C;
		}
	}
}
