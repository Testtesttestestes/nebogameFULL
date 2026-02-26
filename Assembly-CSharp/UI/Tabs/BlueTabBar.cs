using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using Utils;

namespace UI.Tabs
{
	// Token: 0x02000176 RID: 374
	[Token(Token = "0x2000176")]
	public class BlueTabBar : TabBar
	{
		// Token: 0x06000A7C RID: 2684 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A7C")]
		[Address(RVA = "0x5DCE", Offset = "0x5DCE", VA = "0x5DCE", Slot = "4")]
		protected override void OnDestroy()
		{
		/* --- GHIDRA: <ShowInitialAnimation>b__10_0 ---
		int UI_Tabs_BlueTabBar___ShowInitialAnimation_b__10_0(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a599c5 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_IGuideTarget___);
		    DAT_ram_00a599c5 = '\x01';
		  }
		  iVar1 = *(int *)(param1 + 0x40);
		  if (iVar1 == 0) {
		    iVar1 = func_ii_5677(param1,Method_UnityEngine_Component_GetComponent_IGuideTarget___);
		    *(int *)(param1 + 0x40) = iVar1;
		  }
		  return iVar1;
		}
		*/

		/* --- GHIDRA: OnDestroy ---
		void UI_Tabs_BlueTabBar__OnDestroy(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param2_00;
		  
		  Utils_TweenContainer__AddTween(*(undefined4 *)(param1 + 0x54),0);
		  param1_00 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                        (*(undefined4 *)(param1 + 0x48),0);
		  param2_00 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                        (param1,0);
		  UnityEngine_Transform__GetParent(param1_00,param2_00,0);
		  UI_Tabs_TabBar__ItemOnSelectEvent(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06000A7D RID: 2685 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A7D")]
		[Address(RVA = "0x5DCF", Offset = "0x5DCF", VA = "0x5DCF", Slot = "5")]
		protected override void ResetView()
		{
		/* --- GHIDRA: ResetView ---
		void UI_Tabs_BlueTabBar__ResetView(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int *piVar4;
		  uint *puVar5;
		  int *param1_00;
		  float fVar6;
		  undefined4 uVar7;
		  uint uVar8;
		  undefined8 local_48;
		  undefined1 local_40 [8];
		  undefined8 local_38;
		  undefined8 local_30;
		  float4 local_28;
		  undefined4 local_24;
		  float4 local_20;
		  undefined4 local_1c;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined4 local_8;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a599c2 == '\0') {
		    Mono_Security_ASN1__get_Item(&UI_Tabs_ITabBarItemView_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ITabBarItemView__get_Item__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_RectTransform_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_SetEase_TweenerCore_Vector2__Vector2__VectorOptions____
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_SetEase_TweenerCore_Vector3__Vector3__VectorOptions____
		              );
		    DAT_ram_00a599c2 = '\x01';
		  }
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (param1,0);
		  iVar3 = UnityEngine_InputSystem_Users_InputUser__UnpairDevices(uVar2,0);
		  if (iVar3 != 0) {
		    Utils_TweenContainer__AddTween(*(undefined4 *)(param1 + 0x54),0);
		    if (*(int *)(param1 + 0x50) == 0) {
		      piVar4 = (int *)System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                                (*(undefined4 *)(param1 + 0x48),0);
		      iVar3 = UnityEngine_RectTransform_TypeInfo;
		      if (piVar4 == (int *)0x0) {
		        *(undefined4 *)(param1 + 0x50) = 0;
		      }
		      else if ((UnityEngine_RectTransform_TypeInfo != *piVar4) ||
		              (*(int **)(param1 + 0x50) = piVar4, *piVar4 != iVar3)) {
		        System_Activator__CreateInstance(piVar4,iVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    piVar4 = (int *)System_Linq_Enumerable__ToList_object_
		                              (*(undefined4 *)(param1 + 0x44),*(undefined4 *)(param1 + 0x3c),
		                               Method_System_Collections_Generic_List_ITabBarItemView__get_Item__);
		    iVar3 = *piVar4;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      uVar8 = 0;
		      do {
		        if (UI_Tabs_ITabBarItemView_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar8 * 8)) {
		          puVar5 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar8 * 8 + 4) * 8 + iVar3 + 0xf0);
		          goto code_r0x8109fd36;
		        }
		        uVar8 = uVar8 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar8);
		    }
		    puVar5 = (uint *)func_ii_1080(piVar4,UI_Tabs_ITabBarItemView_TypeInfo,6);
		code_r0x8109fd36:
		    uVar2 = (**(code **)((ulonglong)*puVar5 * 4))(piVar4,puVar5[1]);
		    param1_00 = (int *)UnityEngine_UI_Selectable__set_interactable(uVar2,0);
		    if ((param1_00 != (int *)0x0) && (UnityEngine_RectTransform_TypeInfo != *param1_00)) {
		      System_Activator__CreateInstance(param1_00,UnityEngine_RectTransform_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    local_4 = *(undefined4 *)(param1 + 0x4c);
		    UnityEngine_RectTransform__set_anchoredPosition(&local_20,param1_00,0);
		    UnityEngine_ParticleSystem_ShapeModule__get_radius(&local_4,(float)local_20 * 0.5 + -8.0,0);
		    local_8 = *(undefined4 *)(param1 + 0x4c);
		    fVar6 = UnityEngine_ParticleSystem_ShapeModule___ctor(&local_4,0);
		    UnityEngine_ParticleSystem_MinMaxCurve__get_curve(&local_20,fVar6 * 0.25,0);
		    local_30 = local_10;
		    local_38 = local_18;
		    UnityEngine_ParticleSystem_EmissionModule__set_enabled(&local_8,local_40,0);
		    uVar2 = *(undefined4 *)(param1 + 0x50);
		    iVar3 = *piVar4;
		    uVar8 = (uint)*(ushort *)(iVar3 + 0xb6);
		    if (*(char *)(param1 + 0x58) == '\0') {
		      if (uVar8 != 0) {
		        uVar1 = 0;
		        do {
		          if (UI_Tabs_ITabBarItemView_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		            puVar5 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0xf0);
		            goto code_r0x8109ffbe;
		          }
		          uVar1 = uVar1 + 1;
		        } while (uVar8 != uVar1);
		      }
		      puVar5 = (uint *)func_ii_1080(piVar4,UI_Tabs_ITabBarItemView_TypeInfo,6);
		code_r0x8109ffbe:
		      uVar7 = (**(code **)((ulonglong)*puVar5 * 4))(piVar4,puVar5[1]);
		      uVar7 = UnityEngine_UI_Selectable__set_interactable(uVar7,0);
		      UnityEngine_GameObject___ctor(uVar2,uVar7,0,0);
		      Gameplay_SmallGames_View_SmallGamesResourceRenderer__Init(*(undefined4 *)(param1 + 0x50),0);
		      UI_Tabs_BlueTabBar__HandleSelected(param1,param1_00,puVar5);
		    }
		    else {
		      if (uVar8 != 0) {
		        uVar1 = 0;
		        do {
		          if (UI_Tabs_ITabBarItemView_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		            puVar5 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0xf0);
		            goto code_r0x8109fe6e;
		          }
		          uVar1 = uVar1 + 1;
		        } while (uVar8 != uVar1);
		      }
		      puVar5 = (uint *)func_ii_1080(piVar4,UI_Tabs_ITabBarItemView_TypeInfo,6);
		code_r0x8109fe6e:
		      uVar7 = (**(code **)((ulonglong)*puVar5 * 4))(piVar4,puVar5[1]);
		      uVar7 = UnityEngine_UI_Selectable__set_interactable(uVar7,0);
		      UnityEngine_Transform__GetParent(uVar2,uVar7,0);
		      Gameplay_SmallGames_View_SmallGamesResourceRenderer__Init(*(undefined4 *)(param1 + 0x50),0);
		      uVar2 = *(undefined4 *)(param1 + 0x50);
		      UnityEngine_RectTransform__set_anchoredPosition(&local_20,param1_00,0);
		      uVar2 = DG_Tweening_ShortcutExtensions__DOLocalMove(uVar2,(float)local_20 * 0.5,0.4,0,0);
		      uVar2 = DG_Tweening_TweenSettingsExtensions__SetEase_object_
		                        (uVar2,0x1b,0.9,
		                         Method_DG_Tweening_TweenSettingsExtensions_SetEase_TweenerCore_Vector3__Vector3__VectorOptions____
		                        );
		      Utils_TimeUtils___cctor(*(undefined4 *)(param1 + 0x54),uVar2,0);
		      uVar2 = *(undefined4 *)(param1 + 0x50);
		      UnityEngine_RectTransform__set_anchoredPosition(&local_20,param1_00,0);
		      UnityEngine_RectTransform__set_anchoredPosition(&local_20,*(undefined4 *)(param1 + 0x50),0);
		      local_28 = (float4)((float)local_20 + 30.0);
		      local_24 = local_1c;
		      local_48 = CONCAT44(local_1c,local_28);
		      uVar2 = DG_Tweening_DOTweenModuleUI__DOPivotY(uVar2,&local_48,0.4,0,0);
		      uVar2 = DG_Tweening_ShortcutExtensions__DOScale
		                        (uVar2,6,
		                         Method_DG_Tweening_TweenSettingsExtensions_SetEase_TweenerCore_Vector2__Vector2__VectorOptions____
		                        );
		      Utils_TimeUtils___cctor(*(undefined4 *)(param1 + 0x54),uVar2,0);
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06000A7E RID: 2686 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A7E")]
		[Address(RVA = "0x5DD0", Offset = "0x5DD0", VA = "0x5DD0", Slot = "6")]
		protected override void HandleSelected()
		{
		/* --- GHIDRA: HandleSelected ---
		/* WARNING: Type propagation algorithm not settling */
		
		void UI_Tabs_BlueTabBar__HandleSelected(int param1,undefined4 param2,undefined4 param3)
		
		{
		  float4 fVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  undefined8 local_68;
		  undefined8 local_60;
		  undefined4 local_58;
		  longlong local_50 [3];
		  float4 local_38;
		  float4 local_34;
		  float4 local_30;
		  float4 local_2c;
		  undefined4 local_28;
		  float4 local_24;
		  float4 local_20;
		  undefined4 local_18;
		  float4 local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a599c3 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_Tabs_BlueTabBar__ShowInitialAnimation_b__10_0__);
		    Mono_Security_ASN1__get_Item(&DG_Tweening_TweenCallback_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_OnComplete_TweenerCore_Color__Color__ColorOptions____
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_SetDelay_TweenerCore_Vector2__Vector2__VectorOptions____
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_SetDelay_TweenerCore_Color__Color__ColorOptions____
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_SetEase_TweenerCore_Vector2__Vector2__VectorOptions____
		              );
		    DAT_ram_00a599c3 = '\x01';
		  }
		  local_8 = 0x3f8000003f800000;
		  local_50[2] = 0x3f8000003f800000;
		  local_10 = 0x3f8000003f800000;
		  local_50[1] = 0x3f8000003f800000;
		  uVar2 = DG_Tweening_DOTweenModuleSprite___c__DisplayClass3_0___DOBlendableColor_b__1
		                    (*(undefined4 *)(param1 + 0x48),local_50 + 1,0.4,0);
		  uVar2 = DG_Tweening_DOTweenModuleUI__DOFade
		                    (uVar2,0.1,
		                     Method_DG_Tweening_TweenSettingsExtensions_SetDelay_TweenerCore_Color__Color__ColorOptions____
		                    );
		  param1_00 = unnamed_function_1417(DG_Tweening_TweenCallback_TypeInfo);
		  DG_Tweening_Color2__op_Multiply
		            (param1_00,param1,Method_UI_Tabs_BlueTabBar__ShowInitialAnimation_b__10_0__,0);
		  uVar2 = DG_Tweening_TweenSettingsExtensions__From___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType____Il2CppFullySharedGenericStructType_
		                    (uVar2,param1_00,
		                     Method_DG_Tweening_TweenSettingsExtensions_OnComplete_TweenerCore_Color__Color__ColorOptions____
		                    );
		  Utils_TimeUtils___cctor(*(undefined4 *)(param1 + 0x54),uVar2,0);
		  uVar2 = *(undefined4 *)(param1 + 0x50);
		  UnityEngine_RectTransform__set_anchoredPosition(&local_24,uVar2,0);
		  local_18 = 0;
		  local_14 = local_20;
		  local_50[0] = (ulonglong)(uint)local_20 << 0x20;
		  UnityEngine_RectTransform__get_sizeDelta(uVar2,local_50,0);
		  uVar2 = *(undefined4 *)(param1 + 0x50);
		  UnityEngine_RectTransform__set_anchoredPosition(&local_24,param2,0);
		  fVar1 = local_24;
		  UnityEngine_Transform___ctor(&local_24,*(undefined4 *)(param1 + 0x50),0);
		  local_28 = 0;
		  local_58 = 0;
		  local_30 = (float4)((float)fVar1 * 0.5);
		  local_2c = local_20;
		  local_60 = CONCAT44(local_20,local_30);
		  Gameplay_Isles_User_View_IsleAccountMarkersLayerView__GetView(uVar2,&local_60,0);
		  uVar2 = *(undefined4 *)(param1 + 0x50);
		  UnityEngine_RectTransform__set_anchoredPosition(&local_24,param2,0);
		  UnityEngine_RectTransform__set_anchoredPosition(&local_24,*(undefined4 *)(param1 + 0x50),0);
		  local_38 = (float4)((float)local_24 + 30.0);
		  local_34 = local_20;
		  local_68 = CONCAT44(local_20,local_38);
		  uVar2 = DG_Tweening_DOTweenModuleUI__DOPivotY(uVar2,&local_68,0.4,0,0);
		  uVar2 = DG_Tweening_ShortcutExtensions__DOScale
		                    (uVar2,6,
		                     Method_DG_Tweening_TweenSettingsExtensions_SetEase_TweenerCore_Vector2__Vector2__VectorOptions____
		                    );
		  uVar2 = DG_Tweening_DOTweenModuleUI__DOFade
		                    (uVar2,0.1,
		                     Method_DG_Tweening_TweenSettingsExtensions_SetDelay_TweenerCore_Vector2__Vector2__VectorOptions____
		                    );
		  Utils_TimeUtils___cctor(*(undefined4 *)(param1 + 0x54),uVar2,0);
		  return;
		}
		*/

		}

		// Token: 0x06000A7F RID: 2687 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A7F")]
		[Address(RVA = "0x5DD1", Offset = "0x5DD1", VA = "0x5DD1")]
		private void ShowInitialAnimation(RectTransform size)
		{
		/* --- GHIDRA: ShowInitialAnimation ---
		void UI_Tabs_BlueTabBar__ShowInitialAnimation(int param1,undefined4 param2,undefined4 param3)
		
		{
		  float fVar1;
		  undefined1 local_38 [8];
		  undefined8 local_30;
		  undefined8 local_28;
		  float4 local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined4 local_8;
		  undefined4 local_4;
		  
		  local_4 = *(undefined4 *)(param1 + 0x4c);
		  UnityEngine_RectTransform__set_anchoredPosition(&local_20,param2,0);
		  UnityEngine_ParticleSystem_ShapeModule__get_radius(&local_4,(float)local_20 * 0.5 + -8.0,0);
		  local_8 = *(undefined4 *)(param1 + 0x4c);
		  fVar1 = UnityEngine_ParticleSystem_ShapeModule___ctor(&local_4,0);
		  UnityEngine_ParticleSystem_MinMaxCurve__get_curve(&local_20,fVar1 * 0.25,0);
		  local_28 = local_10;
		  local_30 = local_18;
		  UnityEngine_ParticleSystem_EmissionModule__set_enabled(&local_8,local_38,0);
		  return;
		}
		*/

		}

		// Token: 0x06000A80 RID: 2688 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A80")]
		[Address(RVA = "0x5DD2", Offset = "0x5DD2", VA = "0x5DD2")]
		private void AdjustParticlesSettings(RectTransform size)
		{
		/* --- GHIDRA: AdjustParticlesSettings ---
		void UI_Tabs_BlueTabBar__AdjustParticlesSettings(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a599c4 == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_TweenContainer_TypeInfo);
		    DAT_ram_00a599c4 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(Utils_TweenContainer_TypeInfo);
		  Utils_TweenContainer__Dispose(param1_00,0);
		  *(undefined4 *)(param1 + 0x54) = param1_00;
		  UI_Tabs_TabBar__GetItem(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06000A81 RID: 2689 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A81")]
		[Address(RVA = "0x5DD3", Offset = "0x5DD3", VA = "0x5DD3")]
		public BlueTabBar()
		{
		}

		// Token: 0x04000494 RID: 1172
		[Token(Token = "0x4000494")]
		private const float PARTICLES_PER_PIXEL = 0.25f;

		// Token: 0x04000495 RID: 1173
		[Token(Token = "0x4000495")]
		private const float DURATION = 0.4f;

		// Token: 0x04000496 RID: 1174
		[Token(Token = "0x4000496")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Image _selector;

		// Token: 0x04000497 RID: 1175
		[Token(Token = "0x4000497")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private ParticleSystem _selectorParticles;

		// Token: 0x04000498 RID: 1176
		[Token(Token = "0x4000498")]
		[FieldOffset(Offset = "0x50")]
		private RectTransform _selectorRectTransform;

		// Token: 0x04000499 RID: 1177
		[Token(Token = "0x4000499")]
		[FieldOffset(Offset = "0x54")]
		private TweenContainer _tweenContainer;

		// Token: 0x0400049A RID: 1178
		[Token(Token = "0x400049A")]
		[FieldOffset(Offset = "0x58")]
		private bool _initialAnimationShown;
	}
}
