using System;
using System.Collections;
using Core.Animations;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Animations
{
	// Token: 0x02001338 RID: 4920
	[Token(Token = "0x2001338")]
	public class SpineUiButtonAnimation : GameSpineUiAnimation, IPointerClickHandler, IEventSystemHandler, IPointerEnterHandler, IPointerExitHandler
	{
		// Token: 0x17001775 RID: 6005
		// (get) Token: 0x06007474 RID: 29812 RVA: 0x00014F70 File Offset: 0x00013170
		// (set) Token: 0x06007475 RID: 29813 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001775")]
		public bool DemoMode
		{
			[Token(Token = "0x6007474")]
			[Address(RVA = "0xBE40", Offset = "0xBE40", VA = "0xBE40")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6007475")]
			[Address(RVA = "0xBE41", Offset = "0xBE41", VA = "0xBE41")]
			set
			{
			}
		}

		// Token: 0x17001776 RID: 6006
		// (get) Token: 0x06007476 RID: 29814 RVA: 0x00014F88 File Offset: 0x00013188
		// (set) Token: 0x06007477 RID: 29815 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001776")]
		public bool Enabled
		{
			[Token(Token = "0x6007476")]
			[Address(RVA = "0xBE42", Offset = "0xBE42", VA = "0xBE42")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6007477")]
			[Address(RVA = "0xBE43", Offset = "0xBE43", VA = "0xBE43")]
			set
			{
			}
		}

		// Token: 0x06007478 RID: 29816 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007478")]
		[Address(RVA = "0xBE44", Offset = "0xBE44", VA = "0xBE44")]
		private void OnEnable()
		{
		/* --- GHIDRA: OnEnable ---
		void Animations_SpineUiButtonAnimation__OnEnable(int param1,undefined4 param2)
		
		{
		  *(undefined1 *)(param1 + 0x41) = 0;
		  return;
		}
		*/

		}

		// Token: 0x06007479 RID: 29817 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007479")]
		[Address(RVA = "0xBE45", Offset = "0xBE45", VA = "0xBE45")]
		private void OnDisable()
		{
		/* --- GHIDRA: OnDisable ---
		void Animations_SpineUiButtonAnimation__OnDisable(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a596b8 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Animations_SpineUiButtonAnimation_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_281);
		    Mono_Security_ASN1__get_Item(&StringLiteral_14573);
		    DAT_ram_00a596b8 = '\x01';
		  }
		  if (*(int *)(param1 + 0x34) != 0) {
		    func_ii_20511(param1,*(int *)(param1 + 0x34),0);
		  }
		  if ((*(char *)(param1 + 0x41) != '\0') && (*(char *)(param1 + 0x31) == '\0')) {
		    if (*(char *)(param1 + 0x40) == '\0') {
		      if (*(int *)(Animations_SpineUiButtonAnimation_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Animations_SpineUiButtonAnimation_TypeInfo);
		      }
		      uVar3 = *(undefined4 *)(*(int *)(Animations_SpineUiButtonAnimation_TypeInfo + 0x5c) + 4);
		      uVar1 = DG_Tweening_TweenSettingsExtensions__SetLink_object_(param1,0);
		      uVar1 = Spine_Unity_SkeletonGraphic__set_Skeleton(uVar1,0);
		      iVar2 = Spine_SkeletonData__set_Fps(uVar1,uVar3,0);
		      if (iVar2 != 0) {
		        if (*(int *)(Animations_SpineUiButtonAnimation_TypeInfo + 0x74) == 0) {
		          func_ii_306000(Animations_SpineUiButtonAnimation_TypeInfo);
		        }
		        UnityEngine_WaitForSeconds___ctor
		                  (param1,*(undefined4 *)
		                           (*(int *)(Animations_SpineUiButtonAnimation_TypeInfo + 0x5c) + 4),1,0);
		        return;
		      }
		      if (*(int *)(Animations_SpineUiButtonAnimation_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Animations_SpineUiButtonAnimation_TypeInfo);
		      }
		      uVar3 = *(undefined4 *)(*(int *)(Animations_SpineUiButtonAnimation_TypeInfo + 0x5c) + 4);
		      uVar1 = DG_Tweening_TweenSettingsExtensions__SetLink_object_(param1,0);
		      uVar1 = GAFInternal_Assets_GAFAnimationAssetInternal__collectExternalData(uVar1,0);
		      uVar1 = System_Int32__ToString(StringLiteral_14573,uVar3,StringLiteral_281,uVar1,0);
		      if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		        func_ii_306000(OKG_Logs_Debug_TypeInfo);
		      }
		      func_ii_7830(uVar1,0);
		    }
		    else {
		      if (*(char *)(param1 + 0x30) != '\0') {
		        if (*(int *)(Animations_SpineUiButtonAnimation_TypeInfo + 0x74) == 0) {
		          func_ii_306000(Animations_SpineUiButtonAnimation_TypeInfo);
		        }
		        UnityEngine_WaitForSeconds___ctor
		                  (param1,*(undefined4 *)
		                           (*(int *)(Animations_SpineUiButtonAnimation_TypeInfo + 0x5c) + 0xc),1,0);
		        return;
		      }
		      if (*(int *)(Animations_SpineUiButtonAnimation_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Animations_SpineUiButtonAnimation_TypeInfo);
		      }
		      UnityEngine_WaitForSeconds___ctor
		                (param1,**(undefined4 **)(Animations_SpineUiButtonAnimation_TypeInfo + 0x5c),1,0);
		      if (*(char *)(param1 + 0x32) != '\0') {
		        if (DAT_ram_00a596b9 == '\0') {
		          Mono_Security_ASN1__get_Item
		                    (&Animations_SpineUiButtonAnimation__ShowDemoCoroutine_d__21_TypeInfo);
		          DAT_ram_00a596b9 = '\x01';
		        }
		        iVar2 = unnamed_function_1417
		                          (Animations_SpineUiButtonAnimation__ShowDemoCoroutine_d__21_TypeInfo);
		        *(int *)(iVar2 + 0x10) = param1;
		        *(undefined4 *)(iVar2 + 8) = 0;
		        uVar1 = UnityEngine_MonoBehaviour__StartCoroutine(param1,iVar2,0);
		        *(undefined4 *)(param1 + 0x34) = uVar1;
		        return;
		      }
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600747A RID: 29818 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600747A")]
		[Address(RVA = "0xBE46", Offset = "0xBE46", VA = "0xBE46")]
		private void PlayCurrentState()
		{
		/* --- GHIDRA: PlayCurrentState ---
		int Animations_SpineUiButtonAnimation__PlayCurrentState(undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a596b9 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Animations_SpineUiButtonAnimation__ShowDemoCoroutine_d__21_TypeInfo);
		    DAT_ram_00a596b9 = '\x01';
		  }
		  iVar1 = unnamed_function_1417(Animations_SpineUiButtonAnimation__ShowDemoCoroutine_d__21_TypeInfo)
		  ;
		  *(undefined4 *)(iVar1 + 0x10) = param1;
		  *(undefined4 *)(iVar1 + 8) = 0;
		  return iVar1;
		}
		*/

		}

		// Token: 0x0600747B RID: 29819 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600747B")]
		[Address(RVA = "0xBE47", Offset = "0xBE47", VA = "0xBE47")]
		private IEnumerator ShowDemoCoroutine()
		{
		/* --- GHIDRA: ShowDemoCoroutine ---
		uint Animations_SpineUiButtonAnimation__ShowDemoCoroutine
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  uVar1 = DG_Tweening_TweenSettingsExtensions__SetLink_object_(param1,0);
		  uVar1 = Spine_Unity_SkeletonGraphic__set_Skeleton(uVar1,0);
		  iVar2 = Spine_SkeletonData__set_Fps(uVar1,param2,0);
		  return (uint)(iVar2 != 0);
		}
		*/

			return null;
		}

		// Token: 0x0600747C RID: 29820 RVA: 0x00014FA0 File Offset: 0x000131A0
		[Token(Token = "0x600747C")]
		[Address(RVA = "0xBE48", Offset = "0xBE48", VA = "0xBE48")]
		private bool HasAnimation(string animationName)
		{
		/* --- GHIDRA: HasAnimation ---
		void Animations_SpineUiButtonAnimation__HasAnimation(undefined4 param1,undefined4 param2)
		
		{
		  Animations_SpineUiButtonAnimation__OnDisable(param1,param1);
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x0600747D RID: 29821 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600747D")]
		[Address(RVA = "0xBE49", Offset = "0xBE49", VA = "0xBE49")]
		private void Start()
		{
		/* --- GHIDRA: Start ---
		void Animations_SpineUiButtonAnimation__Start(int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a596ba == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IGameAnimation__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Animations_SpineUiButtonAnimation_OnCompleteEvent__);
		    Mono_Security_ASN1__get_Item(&Animations_SpineUiButtonAnimation_TypeInfo);
		    DAT_ram_00a596ba = '\x01';
		  }
		  if (*(int *)(Animations_SpineUiButtonAnimation_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Animations_SpineUiButtonAnimation_TypeInfo);
		  }
		  param2_00 = *(undefined4 *)(*(int *)(Animations_SpineUiButtonAnimation_TypeInfo + 0x5c) + 8);
		  uVar1 = DG_Tweening_TweenSettingsExtensions__SetLink_object_(param1,0);
		  uVar1 = Spine_Unity_SkeletonGraphic__set_Skeleton(uVar1,0);
		  iVar2 = Spine_SkeletonData__set_Fps(uVar1,param2_00,0);
		  if (iVar2 != 0) {
		    *(undefined1 *)(param1 + 0x31) = 1;
		    uVar1 = unnamed_function_1417(System_Action_IGameAnimation__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar1,param1,Method_Animations_SpineUiButtonAnimation_OnCompleteEvent__,0);
		    Core_Animations_GameSpineUiAnimation__remove_ClickEvent(param1,uVar1,0);
		    if (*(int *)(Animations_SpineUiButtonAnimation_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Animations_SpineUiButtonAnimation_TypeInfo);
		    }
		    UnityEngine_WaitForSeconds___ctor
		              (param1,*(undefined4 *)
		                       (*(int *)(Animations_SpineUiButtonAnimation_TypeInfo + 0x5c) + 8),0,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600747E RID: 29822 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600747E")]
		[Address(RVA = "0xBE4A", Offset = "0xBE4A", VA = "0xBE4A", Slot = "24")]
		public void OnPointerClick(PointerEventData eventData)
		{
		/* --- GHIDRA: OnPointerClick ---
		void Animations_SpineUiButtonAnimation__OnPointerClick
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a596bb == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IGameAnimation__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Animations_SpineUiButtonAnimation_OnCompleteEvent__);
		    DAT_ram_00a596bb = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Action_IGameAnimation__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,Method_Animations_SpineUiButtonAnimation_OnCompleteEvent__,0);
		  Core_Animations_GameSpineUiAnimation__add_CompleteEvent(param1,param1_00,0);
		  *(undefined1 *)(param1 + 0x31) = 0;
		  Animations_SpineUiButtonAnimation__OnDisable(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x0600747F RID: 29823 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600747F")]
		[Address(RVA = "0xBE4B", Offset = "0xBE4B", VA = "0xBE4B")]
		private void OnCompleteEvent(IGameAnimation obj)
		{
		/* --- GHIDRA: OnCompleteEvent ---
		void Animations_SpineUiButtonAnimation__OnCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  *(undefined1 *)(param1 + 0x30) = 1;
		  Animations_SpineUiButtonAnimation__OnDisable(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06007480 RID: 29824 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007480")]
		[Address(RVA = "0xBE4C", Offset = "0xBE4C", VA = "0xBE4C", Slot = "25")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		/* --- GHIDRA: OnPointerEnter ---
		void Animations_SpineUiButtonAnimation__OnPointerEnter
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  *(undefined1 *)(param1 + 0x30) = 0;
		  Animations_SpineUiButtonAnimation__OnDisable(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06007481 RID: 29825 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007481")]
		[Address(RVA = "0xBE4D", Offset = "0xBE4D", VA = "0xBE4D", Slot = "26")]
		public void OnPointerExit(PointerEventData eventData)
		{
		/* --- GHIDRA: OnPointerExit ---
		void Animations_SpineUiButtonAnimation__OnPointerExit(int param1,undefined4 param2)
		
		{
		  *(undefined1 *)(param1 + 0x40) = 1;
		  *(undefined8 *)(param1 + 0x38) = 0x200000005;
		  ScreenAdaptation_Common_AppSize__Update(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x06007482 RID: 29826 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007482")]
		[Address(RVA = "0xBE4E", Offset = "0xBE4E", VA = "0xBE4E")]
		public SpineUiButtonAnimation()
		{
		/* --- GHIDRA: .ctor ---
		void Animations_SpineUiButtonAnimation___ctor(undefined4 param1)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a596bc == '\0') {
		    Mono_Security_ASN1__get_Item(&Animations_SpineUiButtonAnimation_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_24507);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25621);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25775);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25954);
		    DAT_ram_00a596bc = '\x01';
		  }
		  **(undefined4 **)(Animations_SpineUiButtonAnimation_TypeInfo + 0x5c) = StringLiteral_24507;
		  iVar1 = *(int *)(Animations_SpineUiButtonAnimation_TypeInfo + 0x5c);
		  *(undefined4 *)(iVar1 + 4) = StringLiteral_25621;
		  *(undefined4 *)(iVar1 + 8) = StringLiteral_25775;
		  *(undefined4 *)(iVar1 + 0xc) = StringLiteral_25954;
		  return;
		}
		*/

		}

		// Token: 0x04003D15 RID: 15637
		[Token(Token = "0x4003D15")]
		[FieldOffset(Offset = "0x0")]
		public static string IDLE;

		// Token: 0x04003D16 RID: 15638
		[Token(Token = "0x4003D16")]
		[FieldOffset(Offset = "0x4")]
		public static string NON_ACTIVE;

		// Token: 0x04003D17 RID: 15639
		[Token(Token = "0x4003D17")]
		[FieldOffset(Offset = "0x8")]
		public static string ON;

		// Token: 0x04003D18 RID: 15640
		[Token(Token = "0x4003D18")]
		[FieldOffset(Offset = "0xC")]
		public static string OVER;

		// Token: 0x04003D19 RID: 15641
		[Token(Token = "0x4003D19")]
		[FieldOffset(Offset = "0x30")]
		private bool _over;

		// Token: 0x04003D1A RID: 15642
		[Token(Token = "0x4003D1A")]
		[FieldOffset(Offset = "0x31")]
		private bool _playingOnAnimation;

		// Token: 0x04003D1B RID: 15643
		[Token(Token = "0x4003D1B")]
		[FieldOffset(Offset = "0x32")]
		private bool _demoMode;

		// Token: 0x04003D1C RID: 15644
		[Token(Token = "0x4003D1C")]
		[FieldOffset(Offset = "0x34")]
		private Coroutine _demoCoroutine;

		// Token: 0x04003D1D RID: 15645
		[Token(Token = "0x4003D1D")]
		[FieldOffset(Offset = "0x38")]
		public int DemoModeIdleDuration;

		// Token: 0x04003D1E RID: 15646
		[Token(Token = "0x4003D1E")]
		[FieldOffset(Offset = "0x3C")]
		public int DemoModeOverDuration;

		// Token: 0x04003D1F RID: 15647
		[Token(Token = "0x4003D1F")]
		[FieldOffset(Offset = "0x40")]
		private bool _enabled;

		// Token: 0x04003D20 RID: 15648
		[Token(Token = "0x4003D20")]
		[FieldOffset(Offset = "0x41")]
		private bool _isGameObjectEnabled;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_DemoMode ---
		void Animations_SpineUiButtonAnimation__get_DemoMode(int param1,undefined4 param2,undefined4 param3)
		
		{
		  *(undefined1 *)(param1 + 0x32) = (undefined1)param2;
		  Animations_SpineUiButtonAnimation__OnDisable(param1,param1);
		  return;
		}
		*/


		/* --- GHIDRA: get_Enabled ---
		void Animations_SpineUiButtonAnimation__get_Enabled(int param1,undefined4 param2,undefined4 param3)
		
		{
		  *(undefined1 *)(param1 + 0x40) = (undefined1)param2;
		  Animations_SpineUiButtonAnimation__OnDisable(param1,param1);
		  return;
		}
		*/


		/* --- GHIDRA: set_Enabled ---
		void Animations_SpineUiButtonAnimation__set_Enabled(int param1,undefined4 param2)
		
		{
		  *(undefined1 *)(param1 + 0x41) = 1;
		  Animations_SpineUiButtonAnimation__OnDisable(param1,param1);
		  return;
		}
		*/

}
