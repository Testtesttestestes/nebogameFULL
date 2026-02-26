using System;
using DG.Tweening;
using Il2CppDummyDll;
using TMPro;
using UI;
using UI.Elements.Counters;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Gameplay.SmallGames.View.DailyRewards
{
	// Token: 0x02000530 RID: 1328
	[Token(Token = "0x2000530")]
	public class RewardsTab : MonoBehaviourWithStates<RewardsTab.State>, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		// Token: 0x170005C6 RID: 1478
		// (get) Token: 0x06001F98 RID: 8088 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170005C6")]
		public TextMeshProUGUI Title
		{
			[Token(Token = "0x6001F98")]
			[Address(RVA = "0x70FD", Offset = "0x70FD", VA = "0x70FD")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005C7 RID: 1479
		// (get) Token: 0x06001F99 RID: 8089 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170005C7")]
		public CounterAutoHide RedCounter
		{
			[Token(Token = "0x6001F99")]
			[Address(RVA = "0x70FE", Offset = "0x70FE", VA = "0x70FE")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005C8 RID: 1480
		// (get) Token: 0x06001F9A RID: 8090 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170005C8")]
		public TextMeshProUGUI StatusText
		{
			[Token(Token = "0x6001F9A")]
			[Address(RVA = "0x70FF", Offset = "0x70FF", VA = "0x70FF")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005C9 RID: 1481
		// (get) Token: 0x06001F9B RID: 8091 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170005C9")]
		public Button Button
		{
			[Token(Token = "0x6001F9B")]
			[Address(RVA = "0x7100", Offset = "0x7100", VA = "0x7100")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005CA RID: 1482
		// (get) Token: 0x06001F9C RID: 8092 RVA: 0x00006690 File Offset: 0x00004890
		// (set) Token: 0x06001F9D RID: 8093 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005CA")]
		public bool Selected
		{
			[Token(Token = "0x6001F9C")]
			[Address(RVA = "0x7101", Offset = "0x7101", VA = "0x7101")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001F9D")]
			[Address(RVA = "0x7102", Offset = "0x7102", VA = "0x7102")]
			set
			{
			}
		}

		// Token: 0x06001F9E RID: 8094 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F9E")]
		[Address(RVA = "0x7103", Offset = "0x7103", VA = "0x7103")]
		public void Init(RectTransform activeParent, RectTransform inactiveParent)
		{
		/* --- GHIDRA: Init ---
		void Gameplay_SmallGames_View_DailyRewards_RewardsTab__Init
		               (int param1,int param2,int param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a582a0 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_RewardsTab_State__HandleCurrentStateChanged__);
		    DAT_ram_00a582a0 = '\x01';
		  }
		  UI_MonoBehaviourWithStates_Int32Enum____ctor
		            (param1,param2,param3,
		             Method_UI_MonoBehaviourWithStates_RewardsTab_State__HandleCurrentStateChanged__);
		  if (param3 == 0) {
		    uVar1 = *(undefined4 *)(param1 + 0x20);
		    if (*(int *)(param1 + 0x4c) != 0) {
		      func_ii_7891(*(int *)(param1 + 0x4c),0,0);
		    }
		    uVar1 = func_ii_9125(uVar1,0.0,0.5,0);
		    *(undefined4 *)(param1 + 0x4c) = uVar1;
		    if (param2 == 2) {
		      uVar1 = *(undefined4 *)(param1 + 0x1c);
		      if (*(int *)(param1 + 0x50) != 0) {
		        func_ii_7891(*(int *)(param1 + 0x50),0,0);
		      }
		      uVar1 = func_ii_9125(uVar1,0.0,0.5,0);
		      *(undefined4 *)(param1 + 0x50) = uVar1;
		      uVar1 = *(undefined4 *)(param1 + 0x20);
		      if (*(int *)(param1 + 0x4c) != 0) {
		        func_ii_7891(*(int *)(param1 + 0x4c),0,0);
		      }
		      uVar1 = func_ii_9125(uVar1,0.0,0.5,0);
		      *(undefined4 *)(param1 + 0x4c) = uVar1;
		      Gameplay_SmallGames_View_DailyRewards_RewardsTab__AnimateAlpha(param1,0,param1);
		      return;
		    }
		  }
		  else {
		    if (param3 == 1) {
		      Gameplay_SmallGames_View_DailyRewards_RewardsTab__ChangeParent(param1,param1);
		      return;
		    }
		    if (param3 == 2) {
		      uVar1 = *(undefined4 *)(param1 + 0x1c);
		      if (*(int *)(param1 + 0x50) != 0) {
		        func_ii_7891(*(int *)(param1 + 0x50),0,0);
		      }
		      uVar1 = func_ii_9125(uVar1,1.0,0.5,0);
		      *(undefined4 *)(param1 + 0x50) = uVar1;
		      uVar1 = *(undefined4 *)(param1 + 0x20);
		      if (*(int *)(param1 + 0x4c) != 0) {
		        func_ii_7891(*(int *)(param1 + 0x4c),0,0);
		      }
		      uVar1 = func_ii_9125(uVar1,1.0,0.5,0);
		      *(undefined4 *)(param1 + 0x4c) = uVar1;
		      Gameplay_SmallGames_View_DailyRewards_RewardsTab__AnimateAlpha(param1,1,param1);
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001F9F RID: 8095 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F9F")]
		[Address(RVA = "0x7104", Offset = "0x7104", VA = "0x7104", Slot = "4")]
		protected override void HandleCurrentStateChanged(RewardsTab.State fromState, RewardsTab.State toState)
		{
		/* --- GHIDRA: HandleCurrentStateChanged ---
		void Gameplay_SmallGames_View_DailyRewards_RewardsTab__HandleCurrentStateChanged
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a582a1 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_RewardsTab_State__get_CurrentState__);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_RewardsTab_State__set_CurrentState__);
		    DAT_ram_00a582a1 = '\x01';
		  }
		  if (*(int *)(param1 + 0x18) != 2) {
		    Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		              (param1,1,Method_UI_MonoBehaviourWithStates_RewardsTab_State__set_CurrentState__);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001FA0 RID: 8096 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FA0")]
		[Address(RVA = "0x7105", Offset = "0x7105", VA = "0x7105", Slot = "5")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		/* --- GHIDRA: OnPointerEnter ---
		void Gameplay_SmallGames_View_DailyRewards_RewardsTab__OnPointerEnter
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a582a2 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_RewardsTab_State__get_CurrentState__);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_RewardsTab_State__set_CurrentState__);
		    DAT_ram_00a582a2 = '\x01';
		  }
		  if (*(int *)(param1 + 0x18) != 2) {
		    Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		              (param1,0,Method_UI_MonoBehaviourWithStates_RewardsTab_State__set_CurrentState__);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001FA1 RID: 8097 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FA1")]
		[Address(RVA = "0x7106", Offset = "0x7106", VA = "0x7106", Slot = "6")]
		public void OnPointerExit(PointerEventData eventData)
		{
		/* --- GHIDRA: OnPointerExit ---
		void Gameplay_SmallGames_View_DailyRewards_RewardsTab__OnPointerExit(int param1,undefined4 param2)
		
		{
		  if (*(int *)(param1 + 0x4c) != 0) {
		    func_ii_7891(*(int *)(param1 + 0x4c),0,0);
		  }
		  if (*(int *)(param1 + 0x50) != 0) {
		    func_ii_7891(*(int *)(param1 + 0x50),0,0);
		  }
		  if (*(int *)(param1 + 0x54) != 0) {
		    func_ii_7891(*(int *)(param1 + 0x54),0,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001FA2 RID: 8098 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FA2")]
		[Address(RVA = "0x7107", Offset = "0x7107", VA = "0x7107")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_SmallGames_View_DailyRewards_RewardsTab__OnDestroy
		               (undefined4 param1,undefined4 param2,float param3,int *param4,undefined4 param5)
		
		{
		  int iVar1;
		  
		  if (*param4 != 0) {
		    func_ii_7891(*param4,0,0);
		  }
		  iVar1 = func_ii_9125(param2,param3,0.5,0);
		  *param4 = iVar1;
		  return;
		}
		*/

		}

		// Token: 0x06001FA3 RID: 8099 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FA3")]
		[Address(RVA = "0x7108", Offset = "0x7108", VA = "0x7108")]
		private void AnimateAlpha(Image target, float endValue, ref Tweener tweener)
		{
		/* --- GHIDRA: AnimateAlpha ---
		void Gameplay_SmallGames_View_DailyRewards_RewardsTab__AnimateAlpha
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int param2_00;
		  int param2_01;
		  undefined4 uVar1;
		  int param2_02;
		  int *param1_00;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a582a3 == '\0') {
		    Mono_Security_ASN1__get_Item(&DG_Tweening_DOTween_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_SmallGames_View_DailyRewards_RewardsTab_StartGlowing__);
		    Mono_Security_ASN1__get_Item(&DG_Tweening_TweenCallback_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_SetEase_TweenerCore_Vector3__Vector3__VectorOptions____
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_SmallGames_View_DailyRewards_RewardsTab___c__DisplayClass34_0__AnimatePosition_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_SmallGames_View_DailyRewards_RewardsTab___c__DisplayClass34_0_TypeInfo);
		    DAT_ram_00a582a3 = '\x01';
		  }
		  param2_01 = unnamed_function_1417
		                        (
		                        Gameplay_SmallGames_View_DailyRewards_RewardsTab___c__DisplayClass34_0_TypeInfo
		                        );
		  *(undefined1 *)(param2_01 + 0xc) = (undefined1)param2;
		  *(int *)(param2_01 + 8) = param1;
		  if (*(int *)(param1 + 0x54) != 0) {
		    func_ii_7891(*(int *)(param1 + 0x54),0,0);
		  }
		  if (*(int *)(DG_Tweening_DOTween_TypeInfo + 0x74) == 0) {
		    func_ii_306000(DG_Tweening_DOTween_TypeInfo);
		  }
		  uVar1 = DG_Tweening_DOTween__To(0);
		  *(undefined4 *)(param1 + 0x54) = uVar1;
		  uVar1 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                    (param1,0);
		  uVar1 = DG_Tweening_ShortcutExtensions__DOLocalMove
		                    (uVar1,*(float *)(param1 + 0x3c) + -90.0,0.5,0,0);
		  uVar2 = 0x1c;
		  if (*(char *)(param2_01 + 0xc) == '\0') {
		    uVar2 = 1;
		  }
		  param2_02 = DG_Tweening_ShortcutExtensions__DOScale
		                        (uVar1,uVar2,
		                         Method_DG_Tweening_TweenSettingsExtensions_SetEase_TweenerCore_Vector3__Vector3__VectorOptions____
		                        );
		  uVar2 = *(undefined4 *)(param2_02 + 0x4c);
		  uVar1 = unnamed_function_1417(DG_Tweening_TweenCallback_TypeInfo);
		  DG_Tweening_Color2__op_Multiply
		            (uVar1,param2_01,
		             Method_Gameplay_SmallGames_View_DailyRewards_RewardsTab___c__DisplayClass34_0__AnimatePosition_b__0__
		             ,0);
		  param1_00 = (int *)UnityEngine_UI_Image__set_sprite(uVar2,uVar1,0);
		  param2_00 = DG_Tweening_TweenCallback_TypeInfo;
		  if (param1_00 == (int *)0x0) {
		    *(undefined4 *)(param2_02 + 0x4c) = 0;
		  }
		  else if ((DG_Tweening_TweenCallback_TypeInfo != *param1_00) ||
		          (*(int **)(param2_02 + 0x4c) = param1_00, *param1_00 != param2_00)) {
		    System_Activator__CreateInstance(param1_00,param2_00);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  uVar1 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                    (param1,0);
		  uVar1 = DG_Tweening_ShortcutExtensions__DOLocalMove(uVar1,*(float *)(param1 + 0x3c),0.5,0,0);
		  uVar2 = 1;
		  if (*(char *)(param2_01 + 0xc) == '\0') {
		    uVar2 = 0x1c;
		  }
		  uVar1 = DG_Tweening_ShortcutExtensions__DOScale
		                    (uVar1,uVar2,
		                     Method_DG_Tweening_TweenSettingsExtensions_SetEase_TweenerCore_Vector3__Vector3__VectorOptions____
		                    );
		  DG_Tweening_TweenParams___cctor(*(undefined4 *)(param1 + 0x54),param2_02,0);
		  DG_Tweening_TweenParams___cctor(*(undefined4 *)(param1 + 0x54),uVar1,0);
		  if (*(char *)(param2_01 + 0xc) != '\0') {
		    uVar2 = *(undefined4 *)(param1 + 0x54);
		    uVar1 = unnamed_function_1417(DG_Tweening_TweenCallback_TypeInfo);
		    DG_Tweening_Color2__op_Multiply
		              (uVar1,param1,Method_Gameplay_SmallGames_View_DailyRewards_RewardsTab_StartGlowing__,0
		              );
		    DG_Tweening_TweenSettingsExtensions__PrependInterval(uVar2,uVar1,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001FA4 RID: 8100 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FA4")]
		[Address(RVA = "0x7109", Offset = "0x7109", VA = "0x7109")]
		private void AnimatePosition(bool enable)
		{
		/* --- GHIDRA: AnimatePosition ---
		void Gameplay_SmallGames_View_DailyRewards_RewardsTab__AnimatePosition
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  
		  param1_00 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                        (param1,0);
		  iVar1 = 0x34;
		  if (param2 == 0) {
		    iVar1 = 0x38;
		  }
		  UnityEngine_Transform__GetParent(param1_00,*(undefined4 *)(param1 + iVar1),0);
		  return;
		}
		*/

		}

		// Token: 0x06001FA5 RID: 8101 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FA5")]
		[Address(RVA = "0x710A", Offset = "0x710A", VA = "0x710A")]
		private void ChangeParent(bool enable)
		{
		/* --- GHIDRA: ChangeParent ---
		void Gameplay_SmallGames_View_DailyRewards_RewardsTab__ChangeParent(int param1,undefined4 param2)
		
		{
		  int param2_00;
		  int iVar1;
		  int *param1_00;
		  undefined4 uVar2;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a582a4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_SmallGames_View_DailyRewards_RewardsTab_StartGlowing__);
		    Mono_Security_ASN1__get_Item(&DG_Tweening_TweenCallback_TypeInfo);
		    DAT_ram_00a582a4 = '\x01';
		  }
		  uVar2 = *(undefined4 *)(param1 + 0x20);
		  if (*(int *)(param1 + 0x4c) != 0) {
		    func_ii_7891(*(int *)(param1 + 0x4c),0,0);
		  }
		  iVar1 = func_ii_9125(uVar2,1.0,0.5,0);
		  *(int *)(param1 + 0x4c) = iVar1;
		  param1_01 = *(undefined4 *)(iVar1 + 0x4c);
		  uVar2 = unnamed_function_1417(DG_Tweening_TweenCallback_TypeInfo);
		  DG_Tweening_Color2__op_Multiply
		            (uVar2,param1,Method_Gameplay_SmallGames_View_DailyRewards_RewardsTab_StartGlowing__,0);
		  param1_00 = (int *)UnityEngine_UI_Image__set_sprite(param1_01,uVar2,0);
		  param2_00 = DG_Tweening_TweenCallback_TypeInfo;
		  if (param1_00 == (int *)0x0) {
		    *(undefined4 *)(iVar1 + 0x4c) = 0;
		    return;
		  }
		  if ((DG_Tweening_TweenCallback_TypeInfo == *param1_00) &&
		     (*(int **)(iVar1 + 0x4c) = param1_00, *param1_00 == param2_00)) {
		    return;
		  }
		  System_Activator__CreateInstance(param1_00,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06001FA6 RID: 8102 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FA6")]
		[Address(RVA = "0x710B", Offset = "0x710B", VA = "0x710B")]
		private void Highlight()
		{
		/* --- GHIDRA: Highlight ---
		void Gameplay_SmallGames_View_DailyRewards_RewardsTab__Highlight(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = *(undefined4 *)(param1 + 0x20);
		  if (*(int *)(param1 + 0x4c) != 0) {
		    func_ii_7891(*(int *)(param1 + 0x4c),0,0);
		  }
		  uVar1 = func_ii_9125(uVar1,0.0,0.5,0);
		  *(undefined4 *)(param1 + 0x4c) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x06001FA7 RID: 8103 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FA7")]
		[Address(RVA = "0x710C", Offset = "0x710C", VA = "0x710C")]
		private void TurnOff()
		{
		/* --- GHIDRA: TurnOff ---
		void Gameplay_SmallGames_View_DailyRewards_RewardsTab__TurnOff(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = *(undefined4 *)(param1 + 0x1c);
		  if (*(int *)(param1 + 0x50) != 0) {
		    func_ii_7891(*(int *)(param1 + 0x50),0,0);
		  }
		  uVar1 = func_ii_9125(uVar1,1.0,0.5,0);
		  *(undefined4 *)(param1 + 0x50) = uVar1;
		  uVar1 = *(undefined4 *)(param1 + 0x20);
		  if (*(int *)(param1 + 0x4c) != 0) {
		    func_ii_7891(*(int *)(param1 + 0x4c),0,0);
		  }
		  uVar1 = func_ii_9125(uVar1,1.0,0.5,0);
		  *(undefined4 *)(param1 + 0x4c) = uVar1;
		  Gameplay_SmallGames_View_DailyRewards_RewardsTab__AnimateAlpha(param1,1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06001FA8 RID: 8104 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FA8")]
		[Address(RVA = "0x710D", Offset = "0x710D", VA = "0x710D")]
		private void TweenSelect()
		{
		/* --- GHIDRA: TweenSelect ---
		void Gameplay_SmallGames_View_DailyRewards_RewardsTab__TweenSelect(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = *(undefined4 *)(param1 + 0x1c);
		  if (*(int *)(param1 + 0x50) != 0) {
		    func_ii_7891(*(int *)(param1 + 0x50),0,0);
		  }
		  uVar1 = func_ii_9125(uVar1,0.0,0.5,0);
		  *(undefined4 *)(param1 + 0x50) = uVar1;
		  uVar1 = *(undefined4 *)(param1 + 0x20);
		  if (*(int *)(param1 + 0x4c) != 0) {
		    func_ii_7891(*(int *)(param1 + 0x4c),0,0);
		  }
		  uVar1 = func_ii_9125(uVar1,0.0,0.5,0);
		  *(undefined4 *)(param1 + 0x4c) = uVar1;
		  Gameplay_SmallGames_View_DailyRewards_RewardsTab__AnimateAlpha(param1,0,param1);
		  return;
		}
		*/

		}

		// Token: 0x06001FA9 RID: 8105 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FA9")]
		[Address(RVA = "0x710E", Offset = "0x710E", VA = "0x710E")]
		private void TweenDeselect()
		{
		/* --- GHIDRA: TweenDeselect ---
		void Gameplay_SmallGames_View_DailyRewards_RewardsTab__TweenDeselect(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a582a5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_SetLoops_TweenerCore_Color__Color__ColorOptions____
		              );
		    DAT_ram_00a582a5 = '\x01';
		  }
		  uVar1 = func_ii_9125(*(undefined4 *)(param1 + 0x20),0.5,1.0,0);
		  uVar1 = DG_Tweening_TweenSettingsExtensions__SetLoops_object_
		                    (uVar1,0xffffffff,1,
		                     Method_DG_Tweening_TweenSettingsExtensions_SetLoops_TweenerCore_Color__Color__ColorOptions____
		                    );
		  *(undefined4 *)(param1 + 0x4c) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x06001FAA RID: 8106 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FAA")]
		[Address(RVA = "0x710F", Offset = "0x710F", VA = "0x710F")]
		private void StartGlowing()
		{
		/* --- GHIDRA: StartGlowing ---
		void Gameplay_SmallGames_View_DailyRewards_RewardsTab__StartGlowing
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a582a6 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_MonoBehaviourWithStates_RewardsTab_State___ctor__);
		    DAT_ram_00a582a6 = '\x01';
		  }
		  ScreenAdaptation_Common_AppSize__Update
		            (param1,Method_UI_MonoBehaviourWithStates_RewardsTab_State___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x06001FAB RID: 8107 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FAB")]
		[Address(RVA = "0x7110", Offset = "0x7110", VA = "0x7110")]
		public RewardsTab()
		{
		}

		// Token: 0x0400114A RID: 4426
		[Token(Token = "0x400114A")]
		private const float TRANSITION_TIME = 0.5f;

		// Token: 0x0400114B RID: 4427
		[Token(Token = "0x400114B")]
		private const float GLOW_TIME = 1f;

		// Token: 0x0400114C RID: 4428
		[Token(Token = "0x400114C")]
		private const float X_SHIFT = -90f;

		// Token: 0x0400114D RID: 4429
		[Token(Token = "0x400114D")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Image _selector;

		// Token: 0x0400114E RID: 4430
		[Token(Token = "0x400114E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _lineSelector;

		// Token: 0x0400114F RID: 4431
		[Token(Token = "0x400114F")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private Button _button;

		// Token: 0x04001150 RID: 4432
		[Token(Token = "0x4001150")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x04001151 RID: 4433
		[Token(Token = "0x4001151")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private CounterAutoHide _redCounter;

		// Token: 0x04001152 RID: 4434
		[Token(Token = "0x4001152")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private TextMeshProUGUI _status;

		// Token: 0x04001153 RID: 4435
		[Token(Token = "0x4001153")]
		[FieldOffset(Offset = "0x34")]
		private RectTransform _activeParent;

		// Token: 0x04001154 RID: 4436
		[Token(Token = "0x4001154")]
		[FieldOffset(Offset = "0x38")]
		private RectTransform _inactiveParent;

		// Token: 0x04001155 RID: 4437
		[Token(Token = "0x4001155")]
		[FieldOffset(Offset = "0x3C")]
		private Vector3 _startPosition;

		// Token: 0x04001156 RID: 4438
		[Token(Token = "0x4001156")]
		[FieldOffset(Offset = "0x48")]
		private bool _selected;

		// Token: 0x04001157 RID: 4439
		[Token(Token = "0x4001157")]
		[FieldOffset(Offset = "0x4C")]
		private Tweener _lineTweener;

		// Token: 0x04001158 RID: 4440
		[Token(Token = "0x4001158")]
		[FieldOffset(Offset = "0x50")]
		private Tweener _selectorTweener;

		// Token: 0x04001159 RID: 4441
		[Token(Token = "0x4001159")]
		[FieldOffset(Offset = "0x54")]
		private Sequence _moveSequence;

		// Token: 0x02000531 RID: 1329
		[Token(Token = "0x2000531")]
		public enum State
		{
			// Token: 0x0400115B RID: 4443
			[Token(Token = "0x400115B")]
			INACTIVE,
			// Token: 0x0400115C RID: 4444
			[Token(Token = "0x400115C")]
			HIGHLIGHTED,
			// Token: 0x0400115D RID: 4445
			[Token(Token = "0x400115D")]
			SELECTED
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Selected ---
		void Gameplay_SmallGames_View_DailyRewards_RewardsTab__get_Selected
		               (int param1,uint param2,undefined4 param3)
		
		{
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a5829f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_RewardsTab_State__set_CurrentState__);
		    DAT_ram_00a5829f = '\x01';
		  }
		  if (param2 != *(byte *)(param1 + 0x48)) {
		    *(char *)(param1 + 0x48) = (char)param2;
		    param2_00 = 2;
		    if (param2 == 0) {
		      param2_00 = 0;
		    }
		    Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		              (param1,param2_00,
		               Method_UI_MonoBehaviourWithStates_RewardsTab_State__set_CurrentState__);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_Selected ---
		void Gameplay_SmallGames_View_DailyRewards_RewardsTab__set_Selected
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 param2_00;
		  undefined8 local_c;
		  undefined4 local_4;
		  
		  param2_00 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                        (param1,0);
		  UnityEngine_Transform___ctor(&local_c,param2_00,0);
		  *(undefined4 *)(param1 + 0x44) = local_4;
		  *(undefined8 *)(param1 + 0x3c) = local_c;
		  *(undefined4 *)(param1 + 0x38) = param3;
		  *(undefined4 *)(param1 + 0x34) = param2;
		  return;
		}
		*/

}
