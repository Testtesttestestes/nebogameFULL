using System;
using System.Collections;
using System.Collections.Generic;
using AssetContent;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Gameplay.Combat.Model;
using Il2CppDummyDll;
using Protocol.Consts;
using TMPro;
using UI.Rewards;
using UnityEngine;

namespace Gameplay.Combat.View
{
	// Token: 0x02000924 RID: 2340
	[Token(Token = "0x2000924")]
	[AddComponentMenu("Combat/RewardToBalanceTweener")]
	public class RewardToBalanceTweener : MonoBehaviour
	{
		// Token: 0x17000AE5 RID: 2789
		// (get) Token: 0x06003728 RID: 14120 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000AE5")]
		public RewardToBalanceTweener.Balance Ballance
		{
			[Token(Token = "0x6003728")]
			[Address(RVA = "0x8717", Offset = "0x8717", VA = "0x8717")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003729 RID: 14121 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003729")]
		[Address(RVA = "0x8718", Offset = "0x8718", VA = "0x8718")]
		public void Play(PlayerProfitData playerProfit, float delay)
		{
		/* --- GHIDRA: <Play_internal>b__25_0 ---
		uint Gameplay_Combat_View_RewardToBalanceTweener___Play_internal_b__25_0
		               (int param1,int param2,undefined4 param3)
		
		{
		  float fVar1;
		  float fVar2;
		  uint uVar3;
		  
		  fVar1 = (float)*(longlong *)(param1 + 0x70);
		  fVar2 = *(float *)(param2 + 8);
		  if (((uint)ABS(fVar2) < 0x7f800001) && ((uint)ABS(*(float *)(param2 + 0xc)) < 0x7f800001)) {
		    if (fVar2 <= fVar1) {
		      return (uint)(fVar1 <= *(float *)(param2 + 0xc));
		    }
		    uVar3 = 0;
		  }
		  else {
		    uVar3 = (uint)(fVar2 <= fVar1);
		  }
		  return uVar3;
		}
		*/

		/* --- GHIDRA: Play ---
		int Gameplay_Combat_View_RewardToBalanceTweener__Play
		              (undefined4 param1,undefined4 param2,float param3,undefined4 param4)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a566a3 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Combat_View_RewardToBalanceTweener__PlayRoutine_d__24_TypeInfo);
		    DAT_ram_00a566a3 = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (Gameplay_Combat_View_RewardToBalanceTweener__PlayRoutine_d__24_TypeInfo);
		  *(undefined4 *)(iVar1 + 0x18) = param2;
		  *(undefined4 *)(iVar1 + 0x14) = param1;
		  *(undefined4 *)(iVar1 + 8) = 0;
		  *(float *)(iVar1 + 0x10) = param3;
		  return iVar1;
		}
		*/

		}

		// Token: 0x0600372A RID: 14122 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600372A")]
		[Address(RVA = "0x8719", Offset = "0x8719", VA = "0x8719")]
		private IEnumerator PlayRoutine(PlayerProfitData playerProfit, float delay)
		{
		/* --- GHIDRA: PlayRoutine ---
		void Gameplay_Combat_View_RewardToBalanceTweener__PlayRoutine
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  int *param1_00;
		  uint *puVar5;
		  undefined8 uVar6;
		  undefined4 uVar7;
		  int local_4;
		  
		  if (DAT_ram_00a566a4 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_RectTransform___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Any_RewardData___);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_First_RewardToBalanceTweener_DurationCfg___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_First_long___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_First_RewardData___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Where_RewardData___);
		    Mono_Security_ASN1__get_Item(&System_Func_RewardToBalanceTweener_DurationCfg__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_RewardData__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Data_Decorators_IRewardInfo_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_UI_LayoutRebuilder_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_GameRawImage___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Combat_View_RewardToBalanceTweener__Play_internal_b__25_0__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Combat_View_RewardToBalanceTweener__Play_internal_b__25_1__);
		    Mono_Security_ASN1__get_Item(&Method_UI_Rewards_RewardsRender_TryGetRender_IconValueRender___);
		    DAT_ram_00a566a4 = '\x01';
		  }
		  local_4 = 0;
		  iVar2 = UI_Rewards_RewardsContainer__Add_object_
		                    (*(undefined4 *)(param1 + 0x10),*(undefined4 *)(param1 + 0x28),&local_4,
		                     Method_UI_Rewards_RewardsRender_TryGetRender_IconValueRender___);
		  if (iVar2 != 0) {
		    uVar3 = func_ii_5677(*(undefined4 *)(param1 + 0x10),
		                         Method_UnityEngine_Component_GetComponent_RectTransform___);
		    if (*(int *)(UnityEngine_UI_LayoutRebuilder_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UnityEngine_UI_LayoutRebuilder_TypeInfo);
		    }
		    UnityEngine_UI_LayoutRebuilder__StripDisabledBehavioursFromList(uVar3,0);
		    uVar7 = *(undefined4 *)(local_4 + 0x28);
		    uVar3 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                      (uVar7,0);
		    uVar3 = UnityEngine_Transform__set_parent(uVar3,0);
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UnityEngine_Object_TypeInfo);
		    }
		    uVar3 = func_ii_6805(uVar7,uVar3,Method_UnityEngine_Object_Instantiate_GameRawImage___);
		    uVar7 = AssetContent_GameImage___ctor(*(undefined4 *)(local_4 + 0x28),0);
		    Core_Extensions_Dict_PortalDicExt__GetCurrencyIcon60x66(uVar3,uVar7,0);
		    uVar7 = func_ii_5677(*(undefined4 *)(param1 + 0x10),
		                         Method_UnityEngine_Component_GetComponent_RectTransform___);
		    UnityEngine_UI_LayoutRebuilder__StripDisabledBehavioursFromList(uVar7,0);
		    uVar7 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                      (uVar3,0);
		    uVar4 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                      (*(undefined4 *)(param1 + 0x1c),0);
		    UnityEngine_Transform__GetParent(uVar7,uVar4,0);
		    uVar7 = Gameplay_Combat_Control_AbstractOneOnOneCombatViewMediator_object__object__object__object___HandleGameOver
		                      (*(undefined4 *)(param1 + 0x6c),0);
		    uVar4 = unnamed_function_1417(System_Func_RewardData__bool__TypeInfo);
		    System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		              (uVar4,param1,
		               Method_Gameplay_Combat_View_RewardToBalanceTweener__Play_internal_b__25_0__,0);
		    uVar7 = System_Linq_Enumerable__Where_PlayerLoopSystem_
		                      (uVar7,uVar4,Method_System_Linq_Enumerable_Where_RewardData___);
		    iVar2 = System_Linq_Enumerable__OrderBy_object__ulong_
		                      (uVar7,Method_System_Linq_Enumerable_Any_RewardData___);
		    if (iVar2 != 0) {
		      uVar7 = System_Linq_Enumerable__Count_object_
		                        (uVar7,Method_System_Linq_Enumerable_First_RewardData___);
		      param1_00 = (int *)func_ii_7225(uVar7,0);
		      iVar2 = *param1_00;
		      if (*(ushort *)(iVar2 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          if (Core_Data_Decorators_IRewardInfo_TypeInfo ==
		              *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		            puVar5 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0xd0);
		            goto code_r0x80c62e10;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		      }
		      puVar5 = (uint *)func_ii_1080(param1_00,Core_Data_Decorators_IRewardInfo_TypeInfo,2);
		code_r0x80c62e10:
		      uVar7 = (**(code **)((ulonglong)*puVar5 * 4))(param1_00,puVar5[1]);
		      uVar6 = System_Linq_Enumerable__First_Int32Enum_
		                        (uVar7,Method_System_Linq_Enumerable_First_long___);
		      *(undefined8 *)(param1 + 0x70) = uVar6;
		      uVar4 = *(undefined4 *)(param1 + 0x24);
		      uVar7 = unnamed_function_1417(System_Func_RewardToBalanceTweener_DurationCfg__bool__TypeInfo);
		      System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		                (uVar7,param1,
		                 Method_Gameplay_Combat_View_RewardToBalanceTweener__Play_internal_b__25_1__,0);
		      uVar7 = func_ii_7423(uVar4,uVar7,
		                           Method_System_Linq_Enumerable_First_RewardToBalanceTweener_DurationCfg___
		                          );
		      *(undefined4 *)(param1 + 0x68) = uVar7;
		      uVar3 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                        (uVar3,0);
		      Gameplay_Combat_View_RewardToBalanceTweener__Play_internal
		                (param1,uVar3,*(float *)(param1 + 0x34),uVar4);
		    }
		  }
		  return;
		}
		*/

			return null;
		}

		// Token: 0x0600372B RID: 14123 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600372B")]
		[Address(RVA = "0x871A", Offset = "0x871A", VA = "0x871A")]
		private void Play_internal(PlayerProfitData playerProfit)
		{
		/* --- GHIDRA: Play_internal ---
		void Gameplay_Combat_View_RewardToBalanceTweener__Play_internal
		               (int param1,undefined4 param2,float param3,undefined4 param4)
		
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
		  
		  if (DAT_ram_00a566a5 == '\0') {
		    Mono_Security_ASN1__get_Item(&DG_Tweening_Core_DOGetter_float__TypeInfo);
		    Mono_Security_ASN1__get_Item(&DG_Tweening_Core_DOSetter_float__TypeInfo);
		    Mono_Security_ASN1__get_Item(&DG_Tweening_DOTween_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_ParticleSystem___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Combat_View_RewardToBalanceTweener_ModifyPosition__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Combat_View_RewardToBalanceTweener_OnAnimationEnd__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Combat_View_RewardToBalanceTweener__StartAnimation_b__26_0__);
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
		               Method_DG_Tweening_TweenSettingsExtensions_SetLink_TweenerCore_float__float__FloatOptions____
		              );
		    DAT_ram_00a566a5 = '\x01';
		  }
		  if (*(int *)(param1 + 0x78) != 0) {
		    DG_Tweening_EaseFactory___c__DisplayClass2_0___StopMotion_b__0(*(int *)(param1 + 0x78),0);
		  }
		  *(undefined4 *)(param1 + 0x38) = 0;
		  *(undefined4 *)(param1 + 0x3c) = param2;
		  uVar13 = *(undefined4 *)(param1 + 0x20);
		  func_ii_7888(&local_c,param2,0);
		  if (DAT_ram_00a65d4a == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Quaternion_TypeInfo);
		    DAT_ram_00a65d4a = '\x01';
		  }
		  local_18 = (*(undefined8 **)(UnityEngine_Quaternion_TypeInfo + 0x5c))[1];
		  local_20 = **(undefined8 **)(UnityEngine_Quaternion_TypeInfo + 0x5c);
		  uVar14 = *(undefined4 *)(param1 + 0x3c);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  local_40 = local_4;
		  local_50 = local_18;
		  local_48 = local_c;
		  local_58 = local_20;
		  uVar13 = UnityEngine_Object__Instantiate_object_
		                     (uVar13,&local_48,&local_58,uVar14,
		                      Method_UnityEngine_Object_Instantiate_ParticleSystem___);
		  *(undefined4 *)(param1 + 100) = uVar13;
		  UnityEngine_ParticleSystem__Play(uVar13,0);
		  func_ii_7888(&local_2c,*(undefined4 *)(param1 + 0x1c),0);
		  fVar9 = local_24;
		  fVar5 = local_28;
		  fVar1 = local_2c;
		  func_ii_7888(&local_2c,param2,0);
		  fVar10 = local_24;
		  fVar6 = local_28;
		  fVar2 = local_2c;
		  func_ii_7888(&local_2c,*(undefined4 *)(param1 + 0x1c),0);
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
		  fVar20 = *(float *)(param1 + 0x2c);
		  func_ii_7888(&local_2c,param2,0);
		  func_ii_7888(&local_38,*(undefined4 *)(param1 + 0x1c),0);
		  *(float4 *)(param1 + 0x48) = local_24;
		  *(ulonglong *)(param1 + 0x40) = CONCAT44(local_28,local_2c);
		  *(float *)(param1 + 0x54) = ((float)fVar11 + (float)fVar12) * 0.5 + fVar15 * fVar20;
		  *(float *)(param1 + 0x50) = ((float)fVar7 + (float)fVar8) * 0.5 + fVar18 * fVar20;
		  *(float *)(param1 + 0x4c) = ((float)fVar3 + (float)fVar4) * 0.5 + fVar19 * fVar20;
		  *(undefined8 *)(param1 + 0x58) = local_38;
		  *(undefined4 *)(param1 + 0x60) = local_30;
		  uVar13 = unnamed_function_1417(DG_Tweening_Core_DOGetter_float__TypeInfo);
		  DG_Tweening_Core_DOGetter_Rect___Invoke
		            (uVar13,param1,
		             Method_Gameplay_Combat_View_RewardToBalanceTweener__StartAnimation_b__26_0__,0);
		  uVar14 = unnamed_function_1417(DG_Tweening_Core_DOSetter_float__TypeInfo);
		  DG_Tweening_Core_DOSetter_Rect___Invoke
		            (uVar14,param1,Method_Gameplay_Combat_View_RewardToBalanceTweener_ModifyPosition__,0);
		  if (*(int *)(DG_Tweening_DOTween_TypeInfo + 0x74) == 0) {
		    func_ii_306000(DG_Tweening_DOTween_TypeInfo);
		  }
		  uVar13 = DG_Tweening_DOTween__ManualUpdate(uVar13,uVar14,1.0,param3,0);
		  uVar13 = DG_Tweening_ShortcutExtensions__DOScale
		                     (uVar13,*(undefined4 *)(param1 + 0x30),
		                      Method_DG_Tweening_TweenSettingsExtensions_SetEase_TweenerCore_float__float__FloatOptions____
		                     );
		  uVar14 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                     (param2,0);
		  uVar13 = DG_Tweening_TweenSettingsExtensions__SetDelay_object_
		                     (uVar13,uVar14,
		                      Method_DG_Tweening_TweenSettingsExtensions_SetLink_TweenerCore_float__float__FloatOptions____
		                     );
		  uVar14 = unnamed_function_1417(DG_Tweening_TweenCallback_TypeInfo);
		  DG_Tweening_Color2__op_Multiply
		            (uVar14,param1,Method_Gameplay_Combat_View_RewardToBalanceTweener_OnAnimationEnd__,0);
		  uVar13 = DG_Tweening_TweenSettingsExtensions__From___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType____Il2CppFullySharedGenericStructType_
		                     (uVar13,uVar14,
		                      Method_DG_Tweening_TweenSettingsExtensions_OnComplete_TweenerCore_float__float__FloatOptions____
		                     );
		  *(undefined4 *)(param1 + 0x78) = uVar13;
		  return;
		}
		*/

		}

		// Token: 0x0600372C RID: 14124 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600372C")]
		[Address(RVA = "0x871B", Offset = "0x871B", VA = "0x871B")]
		private void StartAnimation(Transform movable, float duration)
		{
		/* --- GHIDRA: StartAnimation ---
		void Gameplay_Combat_View_RewardToBalanceTweener__StartAnimation(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a566a6 == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a566a6 = '\x01';
		  }
		  param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(param1 + 0x3c),0);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  UnityEngine_Application__get_isPlaying(param1_00,0);
		  Gameplay_Combat_View_RewardToBalanceTweener_Balance__get_Icon
		            (*(int *)(param1 + 0x14),
		             *(float *)(*(int *)(param1 + 0x14) + 0x14) + (float)*(longlong *)(param1 + 0x70),
		             *(float *)(*(int *)(param1 + 0x68) + 0x10),param1);
		  return;
		}
		*/

		}

		// Token: 0x0600372D RID: 14125 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600372D")]
		[Address(RVA = "0x871C", Offset = "0x871C", VA = "0x871C")]
		private void OnAnimationEnd()
		{
		/* --- GHIDRA: OnAnimationEnd ---
		void Gameplay_Combat_View_RewardToBalanceTweener__OnAnimationEnd
		               (int param1,float param2,undefined4 param3)
		
		{
		  float fVar1;
		  float fVar2;
		  float fVar3;
		  undefined8 local_18;
		  float local_10;
		  float4 local_c;
		  float4 local_8;
		  float4 local_4;
		  
		  *(float *)(param1 + 0x38) = param2;
		  fVar1 = 1.0 - param2;
		  fVar2 = fVar1 * fVar1;
		  fVar1 = (fVar1 + fVar1) * param2;
		  fVar3 = param2 * param2;
		  local_10 = fVar2 * *(float *)(param1 + 0x48) + fVar1 * *(float *)(param1 + 0x54) +
		             fVar3 * *(float *)(param1 + 0x60);
		  local_8 = (float4)(fVar2 * *(float *)(param1 + 0x44) + fVar1 * *(float *)(param1 + 0x50) +
		                    fVar3 * *(float *)(param1 + 0x5c));
		  local_c = (float4)(fVar2 * *(float *)(param1 + 0x40) + fVar1 * *(float *)(param1 + 0x4c) +
		                    fVar3 * *(float *)(param1 + 0x58));
		  local_18 = CONCAT44(local_8,local_c);
		  local_4 = (float4)local_10;
		  UnityEngine_Transform__get_position(*(undefined4 *)(param1 + 0x3c),&local_18,0);
		  return;
		}
		*/

		}

		// Token: 0x0600372E RID: 14126 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600372E")]
		[Address(RVA = "0x871D", Offset = "0x871D", VA = "0x871D")]
		private void ModifyPosition(float t)
		{
		/* --- GHIDRA: ModifyPosition ---
		void Gameplay_Combat_View_RewardToBalanceTweener__ModifyPosition
		               (int param1,float param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int param3_00;
		  
		  if (DAT_ram_00a566a7 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Google_Protobuf_Collections_RepeatedField_uint__set_Item__)
		    ;
		    DAT_ram_00a566a7 = '\x01';
		  }
		  if (((uint)ABS(param2) < 0x7f800001) &&
		     (iVar1 = *(int *)(*(int *)(*(int *)(param1 + 0x6c) + 8) + 0x20),
		     (ulonglong)*(uint *)(iVar1 + 0xc) == (longlong)*(int *)(param1 + 0x28))) {
		    if (param2 < 4.2949673e+09 && 0.0 <= param2) {
		      iVar2 = (int)param2;
		    }
		    else {
		      iVar2 = 0;
		    }
		    if (ABS(param2) < 2.1474836e+09) {
		      param3_00 = (int)param2;
		    }
		    else {
		      param3_00 = -0x80000000;
		    }
		    if (0.0 <= param2) {
		      param3_00 = iVar2;
		    }
		    Google_Protobuf_Collections_RepeatedField_uint___get_IsReadOnly
		              (*(undefined4 *)(iVar1 + 0x10),0,param3_00,
		               Method_Google_Protobuf_Collections_RepeatedField_uint__set_Item__);
		  }
		  uVar3 = *(undefined4 *)(param1 + 0x6c);
		  if (DAT_ram_00a566a3 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Combat_View_RewardToBalanceTweener__PlayRoutine_d__24_TypeInfo);
		    DAT_ram_00a566a3 = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (Gameplay_Combat_View_RewardToBalanceTweener__PlayRoutine_d__24_TypeInfo);
		  *(undefined4 *)(iVar1 + 0x18) = uVar3;
		  *(int *)(iVar1 + 0x14) = param1;
		  *(undefined4 *)(iVar1 + 8) = 0;
		  *(undefined4 *)(iVar1 + 0x10) = 0;
		  UnityEngine_MonoBehaviour__StartCoroutine(param1,iVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x0600372F RID: 14127 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600372F")]
		[Address(RVA = "0x871E", Offset = "0x871E", VA = "0x871E")]
		public void Test(float pointsValue = float.NaN)
		{
		/* --- GHIDRA: Test ---
		void Gameplay_Combat_View_RewardToBalanceTweener__Test(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a566a8 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_RewardToBalanceTweener_DurationCfg___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_List_RewardToBalanceTweener_DurationCfg__TypeInfo);
		    DAT_ram_00a566a8 = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (
		                        System_Collections_Generic_List_RewardToBalanceTweener_DurationCfg__TypeInfo
		                        );
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,
		             Method_System_Collections_Generic_List_RewardToBalanceTweener_DurationCfg___ctor__);
		  *(undefined8 *)(param1 + 0x2c) = 0x242c80000;
		  *(undefined4 *)(param1 + 0x24) = param1_00;
		  UnityEngine_RectTransform__GetParentSize(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x06003730 RID: 14128 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003730")]
		[Address(RVA = "0x871F", Offset = "0x871F", VA = "0x871F")]
		public RewardToBalanceTweener()
		{
		/* --- GHIDRA: .ctor ---
		uint Gameplay_Combat_View_RewardToBalanceTweener___ctor
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  
		  uVar1 = func_ii_8038(param2,0);
		  return (uint)((ulonglong)uVar1 == (longlong)*(int *)(param1 + 0x28));
		}
		*/

		}

		// Token: 0x04001E45 RID: 7749
		[Token(Token = "0x4001E45")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private RewardsRender _rewardsBox;

		// Token: 0x04001E46 RID: 7750
		[Token(Token = "0x4001E46")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private RewardToBalanceTweener.Balance _ballance;

		// Token: 0x04001E47 RID: 7751
		[Token(Token = "0x4001E47")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform _layer;

		// Token: 0x04001E48 RID: 7752
		[Token(Token = "0x4001E48")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Transform _target;

		// Token: 0x04001E49 RID: 7753
		[Token(Token = "0x4001E49")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ParticleSystem _particleSystem;

		// Token: 0x04001E4A RID: 7754
		[Token(Token = "0x4001E4A")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private List<RewardToBalanceTweener.DurationCfg> _addtionsDiuration;

		// Token: 0x04001E4B RID: 7755
		[Token(Token = "0x4001E4B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RewardTypes _targetReward;

		// Token: 0x04001E4C RID: 7756
		[Token(Token = "0x4001E4C")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float _curve;

		// Token: 0x04001E4D RID: 7757
		[Token(Token = "0x4001E4D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Ease _flyEase;

		// Token: 0x04001E4E RID: 7758
		[Token(Token = "0x4001E4E")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float _flyoTargetDuration;

		// Token: 0x04001E4F RID: 7759
		[Token(Token = "0x4001E4F")]
		[FieldOffset(Offset = "0x38")]
		private float _t;

		// Token: 0x04001E50 RID: 7760
		[Token(Token = "0x4001E50")]
		[FieldOffset(Offset = "0x3C")]
		private Transform _movable;

		// Token: 0x04001E51 RID: 7761
		[Token(Token = "0x4001E51")]
		[FieldOffset(Offset = "0x40")]
		private RewardToBalanceTweener.BezierCurve _bezierCurve;

		// Token: 0x04001E52 RID: 7762
		[Token(Token = "0x4001E52")]
		[FieldOffset(Offset = "0x64")]
		private ParticleSystem _ps;

		// Token: 0x04001E53 RID: 7763
		[Token(Token = "0x4001E53")]
		[FieldOffset(Offset = "0x68")]
		private RewardToBalanceTweener.DurationCfg _durationCfg;

		// Token: 0x04001E54 RID: 7764
		[Token(Token = "0x4001E54")]
		[FieldOffset(Offset = "0x6C")]
		private PlayerProfitData _playerProfit;

		// Token: 0x04001E55 RID: 7765
		[Token(Token = "0x4001E55")]
		[FieldOffset(Offset = "0x70")]
		private long _pointToAdd;

		// Token: 0x04001E56 RID: 7766
		[Token(Token = "0x4001E56")]
		[FieldOffset(Offset = "0x78")]
		private TweenerCore<float, float, FloatOptions> _flyTween;

		// Token: 0x02000925 RID: 2341
		[Token(Token = "0x2000925")]
		[Serializable]
		public class Balance
		{
			// Token: 0x17000AE6 RID: 2790
			// (get) Token: 0x06003734 RID: 14132 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000AE6")]
			public GameRawImage Icon
			{
				[Token(Token = "0x6003734")]
				[Address(RVA = "0x8723", Offset = "0x8723", VA = "0x8723")]
				get
				{
					return null;
				}
			}

			// Token: 0x06003735 RID: 14133 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003735")]
			[Address(RVA = "0x1BEA", Offset = "0x1BEA", VA = "0x1BEA")]
			public void SetValue(float value)
			{
			}

			// Token: 0x06003736 RID: 14134 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003736")]
			[Address(RVA = "0x8724", Offset = "0x8724", VA = "0x8724")]
			public void SetValue(float value, float duration)
			{
			}

			// Token: 0x06003737 RID: 14135 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003737")]
			[Address(RVA = "0x8725", Offset = "0x8725", VA = "0x8725")]
			public void Add(float value, float duration)
			{
			}

			// Token: 0x06003738 RID: 14136 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003738")]
			[Address(RVA = "0x8726", Offset = "0x8726", VA = "0x8726")]
			public Balance()
			{
			}

			// Token: 0x04001E57 RID: 7767
			[Token(Token = "0x4001E57")]
			[FieldOffset(Offset = "0x8")]
			[SerializeField]
			private TextMeshProUGUI _valueTextField;

			// Token: 0x04001E58 RID: 7768
			[Token(Token = "0x4001E58")]
			[FieldOffset(Offset = "0xC")]
			[SerializeField]
			private GameRawImage _icon;

			// Token: 0x04001E59 RID: 7769
			[Token(Token = "0x4001E59")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private Ease _easeForAdditionValue;

			// Token: 0x04001E5A RID: 7770
			[Token(Token = "0x4001E5A")]
			[FieldOffset(Offset = "0x14")]
			private float _value;

			// Token: 0x04001E5B RID: 7771
			[Token(Token = "0x4001E5B")]
			[FieldOffset(Offset = "0x18")]
			private Tweener _addTween;
		}

		// Token: 0x02000927 RID: 2343
		[Token(Token = "0x2000927")]
		private readonly struct BezierCurve
		{
			// Token: 0x0600373B RID: 14139 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600373B")]
			[Address(RVA = "0x8729", Offset = "0x8729", VA = "0x8729")]
			public BezierCurve(Vector3 a, Vector3 b, Vector3 c)
			{
			}

			// Token: 0x0600373C RID: 14140 RVA: 0x0000B0E8 File Offset: 0x000092E8
			[Token(Token = "0x600373C")]
			[Address(RVA = "0x872A", Offset = "0x872A", VA = "0x872A")]
			public Vector3 GetPosition(float t)
			{
				return default(Vector3);
			}

			// Token: 0x04001E5F RID: 7775
			[Token(Token = "0x4001E5F")]
			[FieldOffset(Offset = "0x0")]
			public readonly Vector3 A;

			// Token: 0x04001E60 RID: 7776
			[Token(Token = "0x4001E60")]
			[FieldOffset(Offset = "0xC")]
			public readonly Vector3 B;

			// Token: 0x04001E61 RID: 7777
			[Token(Token = "0x4001E61")]
			[FieldOffset(Offset = "0x18")]
			public readonly Vector3 C;
		}

		// Token: 0x02000928 RID: 2344
		[Token(Token = "0x2000928")]
		[Serializable]
		public class DurationCfg
		{
			// Token: 0x0600373D RID: 14141 RVA: 0x0000B100 File Offset: 0x00009300
			[Token(Token = "0x600373D")]
			[Address(RVA = "0x872B", Offset = "0x872B", VA = "0x872B")]
			public bool IsFit(float value)
			{
				return default(bool);
			}

			// Token: 0x17000AE7 RID: 2791
			// (get) Token: 0x0600373E RID: 14142 RVA: 0x0000B118 File Offset: 0x00009318
			[Token(Token = "0x17000AE7")]
			public float DurationForAddition
			{
				[Token(Token = "0x600373E")]
				[Address(RVA = "0x872C", Offset = "0x872C", VA = "0x872C")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x0600373F RID: 14143 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600373F")]
			[Address(RVA = "0x872D", Offset = "0x872D", VA = "0x872D")]
			public DurationCfg()
			{
			}

			// Token: 0x04001E62 RID: 7778
			[Token(Token = "0x4001E62")]
			[FieldOffset(Offset = "0x8")]
			[SerializeField]
			private float _from;

			// Token: 0x04001E63 RID: 7779
			[Token(Token = "0x4001E63")]
			[FieldOffset(Offset = "0xC")]
			[SerializeField]
			private float _to;

			// Token: 0x04001E64 RID: 7780
			[Token(Token = "0x4001E64")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private float durationForAddition;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Ballance ---
		void Gameplay_Combat_View_RewardToBalanceTweener__get_Ballance
		               (int param1,undefined4 param2,float param3,undefined4 param4)
		
		{
		  int param2_00;
		  
		  *(undefined4 *)(param1 + 0x6c) = param2;
		  if (DAT_ram_00a566a3 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Combat_View_RewardToBalanceTweener__PlayRoutine_d__24_TypeInfo);
		    DAT_ram_00a566a3 = '\x01';
		  }
		  param2_00 = unnamed_function_1417
		                        (Gameplay_Combat_View_RewardToBalanceTweener__PlayRoutine_d__24_TypeInfo);
		  *(undefined4 *)(param2_00 + 0x18) = param2;
		  *(int *)(param2_00 + 0x14) = param1;
		  *(undefined4 *)(param2_00 + 8) = 0;
		  *(float *)(param2_00 + 0x10) = param3;
		  UnityEngine_MonoBehaviour__StartCoroutine(param1,param2_00,0);
		  return;
		}
		*/

}
