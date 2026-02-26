using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CloudsFly;
using Core.Animations;
using Core.Events.Scopes;
using Core.Materials;
using DG.Tweening;
using Gameplay.Isles.User;
using Gameplay.Portals.Controller;
using Il2CppDummyDll;
using UI;
using UnityEngine;
using UnityEngine.EventSystems;
using Utils;

namespace Gameplay.Portals.View
{
	// Token: 0x020005AF RID: 1455
	[Token(Token = "0x20005AF")]
	public class PortalsEntryPointView : BaseWorldObjectRenderer, IDisposable, IPointerClickHandler, IEventSystemHandler, IAlpha
	{
		// Token: 0x1400014B RID: 331
		// (add) Token: 0x060022E0 RID: 8928 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060022E1 RID: 8929 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400014B")]
		public event Action ClickEvent
		{
			[Token(Token = "0x60022E0")]
			[Address(RVA = "0x7434", Offset = "0x7434", VA = "0x7434")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60022E1")]
			[Address(RVA = "0x7435", Offset = "0x7435", VA = "0x7435")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x060022E2 RID: 8930 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022E2")]
		[Address(RVA = "0x7436", Offset = "0x7436", VA = "0x7436")]
		private void Awake()
		{
		/* --- GHIDRA: Awake ---
		void Gameplay_Portals_View_PortalsEntryPointView__Awake(int param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar3;
		  
		  if (DAT_ram_00a580dd == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Portals_View_PortalsEntryPointView__RestartAnimation_b__9_0__);
		    Mono_Security_ASN1__get_Item(&DG_Tweening_TweenCallback_TypeInfo);
		    DAT_ram_00a580dd = '\x01';
		  }
		  if (param2 == 0) {
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    param1_01 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar3 = *param1_01;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x148);
		          goto code_r0x80ea0bad;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0x11);
		code_r0x80ea0bad:
		    param2 = (**(code **)((ulonglong)*puVar2 * 4))(param1_01,puVar2[1]);
		  }
		  iVar3 = *(int *)(param2 + 0x10);
		  Core_Animations_GameSpineAnimation__Init(*(undefined4 *)(param1 + 0x24),1,0);
		  if (*(char *)(iVar3 + 0xc) == '\0') {
		    param1_00 = unnamed_function_1417(DG_Tweening_TweenCallback_TypeInfo);
		    DG_Tweening_Color2__op_Multiply
		              (param1_00,param1,
		               Method_Gameplay_Portals_View_PortalsEntryPointView__RestartAnimation_b__9_0__,0);
		    DG_Tweening_DOVirtual__EasedValue(0.05,param1_00,1,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060022E3 RID: 8931 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022E3")]
		[Address(RVA = "0x7437", Offset = "0x7437", VA = "0x7437")]
		private void RestartAnimation([Optional] SettingsScope.SettingsEventArgs settingsEventArgs)
		{
		}

		// Token: 0x060022E4 RID: 8932 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022E4")]
		[Address(RVA = "0x7438", Offset = "0x7438", VA = "0x7438", Slot = "10")]
		public void Dispose()
		{
		}

		// Token: 0x060022E5 RID: 8933 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022E5")]
		[Address(RVA = "0x7439", Offset = "0x7439", VA = "0x7439", Slot = "11")]
		public void OnPointerClick(PointerEventData eventData)
		{
		}

		// Token: 0x060022E6 RID: 8934 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022E6")]
		[Address(RVA = "0x743A", Offset = "0x743A", VA = "0x743A")]
		public void Show()
		{
		}

		// Token: 0x060022E7 RID: 8935 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022E7")]
		[Address(RVA = "0x743B", Offset = "0x743B", VA = "0x743B")]
		public void Hide()
		{
		/* --- GHIDRA: Hide ---
		void Gameplay_Portals_View_PortalsEntryPointView__Hide
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  float fVar1;
		  undefined4 uVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a580de == '\0') {
		    Mono_Security_ASN1__get_Item(&UI_AbstractBacktimeView_FormatCallback_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Portals_View_PortalsEntryPointView_FormatBackTime__);
		    DAT_ram_00a580de = '\x01';
		  }
		  fVar1 = func_ii_7103(param2,0);
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x28),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar2,(uint)(0.0 < fVar1),0);
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x2c),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar2,(uint)(0.0 < fVar1),0);
		  UI_Elements_RightPanel_TitleWithLevel__set_Level(*(undefined4 *)(param1 + 0x28),param2,0);
		  iVar3 = *(int *)(param1 + 0x28);
		  uVar2 = unnamed_function_1417(UI_AbstractBacktimeView_FormatCallback_TypeInfo);
		  UI_AbstractBacktimeView___ctor
		            (uVar2,param1,Method_Gameplay_Portals_View_PortalsEntryPointView_FormatBackTime__,0);
		  *(undefined4 *)(iVar3 + 0x14) = uVar2;
		  return;
		}
		*/

		}

		// Token: 0x060022E8 RID: 8936 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022E8")]
		[Address(RVA = "0x743C", Offset = "0x743C", VA = "0x743C")]
		public void SetBackTimer(BackTime backTime)
		{
		/* --- GHIDRA: SetBackTimer ---
		void Gameplay_Portals_View_PortalsEntryPointView__SetBackTimer(int param1,undefined4 param2)
		
		{
		  Core_Animations_GameSpineAnimation__get_SortingOrder
		            (*(undefined4 *)(param1 + 0x24),*(int *)(param1 + 0x10) + *(int *)(param1 + 0x14),0);
		  return;
		}
		*/

		}

		// Token: 0x060022E9 RID: 8937 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022E9")]
		[Address(RVA = "0x743D", Offset = "0x743D", VA = "0x743D", Slot = "8")]
		protected override void ApplySortingOrder()
		{
		/* --- GHIDRA: ApplySortingOrder ---
		void Gameplay_Portals_View_PortalsEntryPointView__ApplySortingOrder(int param1,undefined4 param2)
		
		{
		  Core_Animations_GameSpineAnimation__get_SortingLayerId
		            (*(undefined4 *)(param1 + 0x24),*(undefined4 *)(param1 + 0x18),0);
		  return;
		}
		*/

		}

		// Token: 0x060022EA RID: 8938 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022EA")]
		[Address(RVA = "0x743E", Offset = "0x743E", VA = "0x743E", Slot = "9")]
		protected override void ApplySortingLayerId()
		{
		/* --- GHIDRA: ApplySortingLayerId ---
		void Gameplay_Portals_View_PortalsEntryPointView__ApplySortingLayerId
		               (int param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *piVar3;
		  int iVar4;
		  undefined4 param4;
		  undefined4 param3_00;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a580df == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Portals_Controller_IslePortalsEntryPointMediator_TypeInfo);
		    DAT_ram_00a580df = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  piVar3 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x290);
		        goto code_r0x80ea0d97;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,0x3a);
		code_r0x80ea0d97:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  param4 = *(undefined4 *)(iVar4 + 0x18);
		  param3_00 = *(undefined4 *)(iVar4 + 0x14);
		  param2_00 = *(undefined4 *)(iVar4 + 0x10);
		  piVar3 = (int *)unnamed_function_1417
		                            (Gameplay_Portals_Controller_IslePortalsEntryPointMediator_TypeInfo);
		  if (DAT_ram_00a5813a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_PortalsModel__PortalsEvents__PortalsController__PortalsEntryPointView___ctor__
		              );
		    DAT_ram_00a5813a = '\x01';
		  }
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (piVar3,param2_00,param3_00,param4,
		             Method_MVC_AbstractViewMediator_PortalsModel__PortalsEvents__PortalsController__PortalsEntryPointView___ctor__
		            );
		  piVar3[6] = param2;
		  *(int **)(param1 + 0x38) = piVar3;
		  (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x160) * 4))
		            (piVar3,param1,*(undefined4 *)(*piVar3 + 0x164));
		  return;
		}
		*/

		}

		// Token: 0x060022EB RID: 8939 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022EB")]
		[Address(RVA = "0x743F", Offset = "0x743F", VA = "0x743F")]
		public void Init(UserIsle isle)
		{
		/* --- GHIDRA: Init ---
		void Gameplay_Portals_View_PortalsEntryPointView__Init(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a580e0 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_From_TweenerCore_Color__Color__ColorOptions____
		              );
		    DAT_ram_00a580e0 = '\x01';
		  }
		  if (*(int *)(param1 + 0x34) != 0) {
		    func_ii_7891(*(int *)(param1 + 0x34),0,0);
		  }
		  uVar1 = UnityEngine_Renderer__set_material(*(undefined4 *)(*(int *)(param1 + 0x24) + 0x14),0);
		  uVar1 = DG_Tweening_ShortcutExtensions__DOColor(uVar1,0.0,0.5,0);
		  DG_Tweening_Core_TweenManager__GetTweener___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType____Il2CppFullySharedGenericStructType_
		            (uVar1,
		             Method_DG_Tweening_TweenSettingsExtensions_From_TweenerCore_Color__Color__ColorOptions____
		            );
		  return;
		}
		*/

		}

		// Token: 0x060022EC RID: 8940 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022EC")]
		[Address(RVA = "0x7440", Offset = "0x7440", VA = "0x7440")]
		private void FadeIn()
		{
		/* --- GHIDRA: FadeIn ---
		void Gameplay_Portals_View_PortalsEntryPointView__FadeIn(int param1,undefined4 param2)
		
		{
		  int *piVar1;
		  
		  piVar1 = *(int **)(param1 + 0x38);
		  if (piVar1 != (int *)0x0) {
		    (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x130) * 4))
		              (piVar1,*(undefined4 *)(*piVar1 + 0x134));
		  }
		  *(undefined4 *)(param1 + 0x38) = 0;
		  return;
		}
		*/

		}

		// Token: 0x060022ED RID: 8941 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022ED")]
		[Address(RVA = "0x7441", Offset = "0x7441", VA = "0x7441")]
		public void Deinit()
		{
		/* --- GHIDRA: Deinit ---
		void Gameplay_Portals_View_PortalsEntryPointView__Deinit(int param1,float param2,undefined4 param3)
		
		{
		  Core_Animations_GameSpineAnimation__SetGrayscale(*(undefined4 *)(param1 + 0x24),param2,0);
		  return;
		}
		*/

		}

		// Token: 0x060022EE RID: 8942 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022EE")]
		[Address(RVA = "0x7442", Offset = "0x7442", VA = "0x7442", Slot = "12")]
		public void SetAlpha(float value)
		{
		/* --- GHIDRA: SetAlpha ---
		void Gameplay_Portals_View_PortalsEntryPointView__SetAlpha(undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a580e1 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SettingsScope_SettingsEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Portals_View_PortalsEntryPointView_RestartAnimation__);
		    DAT_ram_00a580e1 = '\x01';
		  }
		  iVar1 = System_Uri___ctor(0);
		  iVar4 = *(int *)(*(int *)(*(int *)(iVar1 + 0x38) + 0x10) + 0x24);
		  param1_00 = *(undefined4 *)(iVar4 + 0xc);
		  uVar2 = unnamed_function_1417(System_Action_SettingsScope_SettingsEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,Method_Gameplay_Portals_View_PortalsEntryPointView_RestartAnimation__,0);
		  iVar1 = func_ii_7048(param1_00,uVar2,0);
		  uVar2 = System_Action_SettingsScope_SettingsEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0xc) = 0;
		    return;
		  }
		  iVar3 = func_ii_1082(iVar1,System_Action_SettingsScope_SettingsEventArgs__TypeInfo);
		  if (iVar3 == 0) {
		    System_Activator__CreateInstance(iVar1,uVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  *(int *)(iVar4 + 0xc) = iVar3;
		  uVar2 = System_Action_SettingsScope_SettingsEventArgs__TypeInfo;
		  iVar4 = func_ii_1082(iVar1,System_Action_SettingsScope_SettingsEventArgs__TypeInfo);
		  if (iVar4 != 0) {
		    return;
		  }
		  System_Activator__CreateInstance(iVar1,uVar2);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x060022EF RID: 8943 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022EF")]
		[Address(RVA = "0x7443", Offset = "0x7443", VA = "0x7443")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		undefined4
		Gameplay_Portals_View_PortalsEntryPointView__OnDestroy
		          (undefined4 param1,float param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a580e2 == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    DAT_ram_00a580e2 = '\x01';
		  }
		  if (param2 <= 0.0) {
		    return **(undefined4 **)(DAT_ram_00a66978 + 0x5c);
		  }
		  if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Utils_TimeUtils_TypeInfo);
		  }
		  uVar1 = Utils_TimeUtils__DateFormat((double)param2,0);
		  return uVar1;
		}
		*/

		}

		// Token: 0x060022F0 RID: 8944 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60022F0")]
		[Address(RVA = "0x7444", Offset = "0x7444", VA = "0x7444")]
		private string FormatBackTime(float value)
		{
			return null;
		}

		// Token: 0x060022F1 RID: 8945 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022F1")]
		[Address(RVA = "0x7445", Offset = "0x7445", VA = "0x7445")]
		public PortalsEntryPointView()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Portals_View_PortalsEntryPointView___ctor(int param1,undefined4 param2)
		
		{
		  Core_Animations_GameSpineAnimation__AnimationStateOnComplete(*(undefined4 *)(param1 + 0x24),0);
		  return;
		}
		*/

		}

		// Token: 0x04001305 RID: 4869
		[Token(Token = "0x4001305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private GameSpineAnimation _portalAnimation;

		// Token: 0x04001306 RID: 4870
		[Token(Token = "0x4001306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private BacktimeView _endTimer;

		// Token: 0x04001307 RID: 4871
		[Token(Token = "0x4001307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private SpriteRenderer _cloud;

		// Token: 0x04001309 RID: 4873
		[Token(Token = "0x4001309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Tween _fadeTween;

		// Token: 0x0400130A RID: 4874
		[Token(Token = "0x400130A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private IslePortalsEntryPointMediator _mediator;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_ClickEvent ---
		void Gameplay_Portals_View_PortalsEntryPointView__add_ClickEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a580db == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a580db = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x30);
		  while ((param1_01 = (int *)func_ii_7048(param1_00,param2,0), param1_01 == (int *)0x0 ||
		         (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x30,param1_01,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,System_Action_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: remove_ClickEvent ---
		void Gameplay_Portals_View_PortalsEntryPointView__remove_ClickEvent
		               (undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a580dc == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SettingsScope_SettingsEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Portals_View_PortalsEntryPointView_RestartAnimation__);
		    DAT_ram_00a580dc = '\x01';
		  }
		  Gameplay_Portals_View_PortalsEntryPointView__Awake(param1,0,param1);
		  iVar1 = System_Uri___ctor(0);
		  iVar4 = *(int *)(*(int *)(*(int *)(iVar1 + 0x38) + 0x10) + 0x24);
		  param1_00 = *(undefined4 *)(iVar4 + 0xc);
		  uVar2 = unnamed_function_1417(System_Action_SettingsScope_SettingsEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,Method_Gameplay_Portals_View_PortalsEntryPointView_RestartAnimation__,0);
		  iVar1 = UnityEngine_UI_Image__set_sprite(param1_00,uVar2,0);
		  uVar2 = System_Action_SettingsScope_SettingsEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0xc) = 0;
		    return;
		  }
		  iVar3 = func_ii_1082(iVar1,System_Action_SettingsScope_SettingsEventArgs__TypeInfo);
		  if (iVar3 == 0) {
		    System_Activator__CreateInstance(iVar1,uVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  *(int *)(iVar4 + 0xc) = iVar3;
		  uVar2 = System_Action_SettingsScope_SettingsEventArgs__TypeInfo;
		  iVar4 = func_ii_1082(iVar1,System_Action_SettingsScope_SettingsEventArgs__TypeInfo);
		  if (iVar4 != 0) {
		    return;
		  }
		  System_Activator__CreateInstance(iVar1,uVar2);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

}
