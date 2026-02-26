using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Animations;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.SmallGames.View
{
	// Token: 0x0200051B RID: 1307
	[Token(Token = "0x200051B")]
	[RequireComponent(typeof(Button))]
	public class SlotWheelsView : MonoBehaviour
	{
		// Token: 0x14000138 RID: 312
		// (add) Token: 0x06001F1A RID: 7962 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06001F1B RID: 7963 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000138")]
		public event Action WheelsStoppedSpinningEvent
		{
			[Token(Token = "0x6001F1A")]
			[Address(RVA = "0x7081", Offset = "0x7081", VA = "0x7081")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6001F1B")]
			[Address(RVA = "0x7082", Offset = "0x7082", VA = "0x7082")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06001F1C RID: 7964 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F1C")]
		[Address(RVA = "0x7083", Offset = "0x7083", VA = "0x7083")]
		private void Start()
		{
		/* --- GHIDRA: Start ---
		void Gameplay_SmallGames_View_SlotWheelsView__Start(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a5866c == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_SmallGames_View_SlotWheelsView_StopSpin__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a5866c = '\x01';
		  }
		  param1_01 = *(undefined4 *)(*(int *)(param1 + 0x20) + 0xb4);
		  param1_00 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (param1_00,param1,Method_Gameplay_SmallGames_View_SlotWheelsView_StopSpin__,0);
		  UnityEngine_Events_UnityAction___ctor(param1_01,param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06001F1D RID: 7965 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F1D")]
		[Address(RVA = "0x7084", Offset = "0x7084", VA = "0x7084")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_SmallGames_View_SlotWheelsView__OnDestroy(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  Gameplay_SmallGames_View_SlotWheelsView__StopSpin(param1,param1);
		  uVar2 = *(undefined4 *)(param1 + 0x10);
		  uVar1 = UnityEngine_Random__Range(1,6,0);
		  Animations_SlotsWheelAnimationBase__get_Prefix(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x14);
		  uVar1 = UnityEngine_Random__Range(1,6,0);
		  Animations_SlotsWheelAnimationBase__get_Prefix(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = UnityEngine_Random__Range(1,6,0);
		  Animations_SlotsWheelAnimationBase__get_Prefix(uVar2,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x06001F1E RID: 7966 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F1E")]
		[Address(RVA = "0x7085", Offset = "0x7085", VA = "0x7085")]
		public void Init()
		{
		/* --- GHIDRA: Init ---
		void Gameplay_SmallGames_View_SlotWheelsView__Init(int param1,undefined4 param2,undefined4 param3)
		
		{
		  int param2_00;
		  undefined4 uVar1;
		  
		  *(undefined4 *)(param1 + 0x30) = param2;
		  Animations_SlotsWheelAnimationBase__Init(*(undefined4 *)(param1 + 0x18),0);
		  Animations_SlotsWheelAnimationBase__Init(*(undefined4 *)(param1 + 0x14),0);
		  Animations_SlotsWheelAnimationBase__Init(*(undefined4 *)(param1 + 0x10),0);
		  if (DAT_ram_00a5866f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_SmallGames_View_SlotWheelsView__StopSpinDelayed_d__21_TypeInfo);
		    DAT_ram_00a5866f = '\x01';
		  }
		  param2_00 = unnamed_function_1417
		                        (Gameplay_SmallGames_View_SlotWheelsView__StopSpinDelayed_d__21_TypeInfo);
		  *(int *)(param2_00 + 0x14) = param1;
		  *(undefined4 *)(param2_00 + 8) = 0;
		  *(undefined4 *)(param2_00 + 0x18) = param2;
		  *(undefined4 *)(param2_00 + 0x10) = 0x40000000;
		  uVar1 = UnityEngine_MonoBehaviour__StartCoroutine(param1,param2_00,0);
		  *(undefined4 *)(param1 + 0x28) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x06001F1F RID: 7967 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F1F")]
		[Address(RVA = "0x7086", Offset = "0x7086", VA = "0x7086")]
		public void StartSpinning(IList<uint> resultSlotIds)
		{
		/* --- GHIDRA: StartSpinning ---
		void Gameplay_SmallGames_View_SlotWheelsView__StartSpinning
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int param2_00;
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a5866d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_Component_GetComponentInChildren_TextMeshProUGUI___);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_SmallGames_View_SlotWheelsView___c__DisplayClass17_0__UpdateSpinButton_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_SmallGames_View_SlotWheelsView___c__DisplayClass17_0_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a5866d = '\x01';
		  }
		  param2_00 = unnamed_function_1417
		                        (Gameplay_SmallGames_View_SlotWheelsView___c__DisplayClass17_0_TypeInfo);
		  *(undefined4 *)(param2_00 + 0xc) = param2;
		  *(int *)(param2_00 + 8) = param1;
		  func_ii_14558(*(undefined4 *)(*(int *)(param1 + 0x1c) + 0xb4),0);
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 0x1c) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param2_00,
		             Method_Gameplay_SmallGames_View_SlotWheelsView___c__DisplayClass17_0__UpdateSpinButton_b__0__
		             ,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar2,uVar1,0);
		  uVar1 = UI_Rewards_AbstractRewardsRender__SetRewards
		                    (*(undefined4 *)(param1 + 0x1c),
		                     Method_UnityEngine_Component_GetComponentInChildren_TextMeshProUGUI___);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(param3,1,0,1,0,0,0,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar1,uVar2,0);
		  return;
		}
		*/

		}

		// Token: 0x06001F20 RID: 7968 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F20")]
		[Address(RVA = "0x7087", Offset = "0x7087", VA = "0x7087")]
		public void UpdateSpinButton(Action callback, string localizationKey)
		{
		/* --- GHIDRA: UpdateSpinButton ---
		void Gameplay_SmallGames_View_SlotWheelsView__UpdateSpinButton(int param1,undefined4 param2)
		
		{
		  if ((*(char *)(param1 + 0x34) == '\0') && (*(int *)(param1 + 0x30) != 0)) {
		    Gameplay_SmallGames_View_SlotWheelsView__StopSpin(param1,*(int *)(param1 + 0x30),param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001F21 RID: 7969 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F21")]
		[Address(RVA = "0x7088", Offset = "0x7088", VA = "0x7088")]
		public void StopSpin()
		{
		/* --- GHIDRA: StopSpin ---
		void Gameplay_SmallGames_View_SlotWheelsView__StopSpin
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int param2_00;
		  undefined4 uVar1;
		  
		  System_Linq_Enumerable__First_object_(*(undefined4 *)(param1 + 0x1c),0,0);
		  *(undefined1 *)(param1 + 0x34) = 1;
		  if (*(int *)(param1 + 0x28) != 0) {
		    func_ii_20511(param1,*(int *)(param1 + 0x28),0);
		  }
		  if (DAT_ram_00a58670 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_SmallGames_View_SlotWheelsView__StoppingSpin_d__22_TypeInfo);
		    DAT_ram_00a58670 = '\x01';
		  }
		  param2_00 = unnamed_function_1417
		                        (Gameplay_SmallGames_View_SlotWheelsView__StoppingSpin_d__22_TypeInfo);
		  *(undefined4 *)(param2_00 + 0x14) = param2;
		  *(int *)(param2_00 + 0x10) = param1;
		  *(undefined4 *)(param2_00 + 8) = 0;
		  uVar1 = UnityEngine_MonoBehaviour__StartCoroutine(param1,param2_00,0);
		  *(undefined4 *)(param1 + 0x2c) = uVar1;
		  return;
		}
		*/

		/* --- GHIDRA: StopSpin ---
		void Gameplay_SmallGames_View_SlotWheelsView__StopSpin
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int param2_00;
		  undefined4 uVar1;
		  
		  System_Linq_Enumerable__First_object_(*(undefined4 *)(param1 + 0x1c),0,0);
		  *(undefined1 *)(param1 + 0x34) = 1;
		  if (*(int *)(param1 + 0x28) != 0) {
		    func_ii_20511(param1,*(int *)(param1 + 0x28),0);
		  }
		  if (DAT_ram_00a58670 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_SmallGames_View_SlotWheelsView__StoppingSpin_d__22_TypeInfo);
		    DAT_ram_00a58670 = '\x01';
		  }
		  param2_00 = unnamed_function_1417
		                        (Gameplay_SmallGames_View_SlotWheelsView__StoppingSpin_d__22_TypeInfo);
		  *(undefined4 *)(param2_00 + 0x14) = param2;
		  *(int *)(param2_00 + 0x10) = param1;
		  *(undefined4 *)(param2_00 + 8) = 0;
		  uVar1 = UnityEngine_MonoBehaviour__StartCoroutine(param1,param2_00,0);
		  *(undefined4 *)(param1 + 0x2c) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x06001F22 RID: 7970 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F22")]
		[Address(RVA = "0x7089", Offset = "0x7089", VA = "0x7089")]
		private void StopSpin(IList<uint> resultSlotIds)
		{
		}

		// Token: 0x06001F23 RID: 7971 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F23")]
		[Address(RVA = "0x708A", Offset = "0x708A", VA = "0x708A")]
		public void AbortSpin()
		{
		/* --- GHIDRA: AbortSpin ---
		int Gameplay_SmallGames_View_SlotWheelsView__AbortSpin
		              (undefined4 param1,float param2,undefined4 param3,undefined4 param4)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a5866f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_SmallGames_View_SlotWheelsView__StopSpinDelayed_d__21_TypeInfo);
		    DAT_ram_00a5866f = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (Gameplay_SmallGames_View_SlotWheelsView__StopSpinDelayed_d__21_TypeInfo);
		  *(undefined4 *)(iVar1 + 0x14) = param1;
		  *(undefined4 *)(iVar1 + 8) = 0;
		  *(undefined4 *)(iVar1 + 0x18) = param3;
		  *(float *)(iVar1 + 0x10) = param2;
		  return iVar1;
		}
		*/

		}

		// Token: 0x06001F24 RID: 7972 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001F24")]
		[Address(RVA = "0x708B", Offset = "0x708B", VA = "0x708B")]
		private IEnumerator StopSpinDelayed(float delay, IList<uint> resultSlotIds)
		{
		/* --- GHIDRA: StopSpinDelayed ---
		int Gameplay_SmallGames_View_SlotWheelsView__StopSpinDelayed
		              (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a58670 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_SmallGames_View_SlotWheelsView__StoppingSpin_d__22_TypeInfo);
		    DAT_ram_00a58670 = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (Gameplay_SmallGames_View_SlotWheelsView__StoppingSpin_d__22_TypeInfo);
		  *(undefined4 *)(iVar1 + 0x14) = param2;
		  *(undefined4 *)(iVar1 + 0x10) = param1;
		  *(undefined4 *)(iVar1 + 8) = 0;
		  return iVar1;
		}
		*/

			return null;
		}

		// Token: 0x06001F25 RID: 7973 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001F25")]
		[Address(RVA = "0x708C", Offset = "0x708C", VA = "0x708C")]
		private IEnumerator StoppingSpin(IList<uint> resultSlotIds)
		{
			return null;
		}

		// Token: 0x06001F26 RID: 7974 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F26")]
		[Address(RVA = "0x708D", Offset = "0x708D", VA = "0x708D")]
		public SlotWheelsView()
		{
		}

		// Token: 0x040010DC RID: 4316
		[Token(Token = "0x40010DC")]
		private const float STOP_SPIN_DELAY = 2f;

		// Token: 0x040010DD RID: 4317
		[Token(Token = "0x40010DD")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private SlotsWheelAnimationBase _wheel1;

		// Token: 0x040010DE RID: 4318
		[Token(Token = "0x40010DE")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private SlotsWheelAnimationBase _wheel2;

		// Token: 0x040010DF RID: 4319
		[Token(Token = "0x40010DF")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SlotsWheelAnimationBase _wheel3;

		// Token: 0x040010E0 RID: 4320
		[Token(Token = "0x40010E0")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Button _spinButton;

		// Token: 0x040010E1 RID: 4321
		[Token(Token = "0x40010E1")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Button _areaButton;

		// Token: 0x040010E3 RID: 4323
		[Token(Token = "0x40010E3")]
		[FieldOffset(Offset = "0x28")]
		private Coroutine _stopSpinDelayedRoutine;

		// Token: 0x040010E4 RID: 4324
		[Token(Token = "0x40010E4")]
		[FieldOffset(Offset = "0x2C")]
		private Coroutine _stoppingSpinRoutine;

		// Token: 0x040010E5 RID: 4325
		[Token(Token = "0x40010E5")]
		[FieldOffset(Offset = "0x30")]
		private IList<uint> _resultSlotIds;

		// Token: 0x040010E6 RID: 4326
		[Token(Token = "0x40010E6")]
		[FieldOffset(Offset = "0x34")]
		private bool _stoppingFlag;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_WheelsStoppedSpinningEvent ---
		void Gameplay_SmallGames_View_SlotWheelsView__add_WheelsStoppedSpinningEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a5866a == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a5866a = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x24);
		  while ((param1_01 = (int *)func_ii_7048(param1_00,param2,0), param1_01 == (int *)0x0 ||
		         (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x24,param1_01,param1_00);
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


		/* --- GHIDRA: remove_WheelsStoppedSpinningEvent ---
		void Gameplay_SmallGames_View_SlotWheelsView__remove_WheelsStoppedSpinningEvent
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a5866b == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_SmallGames_View_SlotWheelsView_StopSpin__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a5866b = '\x01';
		  }
		  param1_01 = *(undefined4 *)(*(int *)(param1 + 0x20) + 0xb4);
		  param1_00 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (param1_00,param1,Method_Gameplay_SmallGames_View_SlotWheelsView_StopSpin__,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(param1_01,param1_00,0);
		  return;
		}
		*/

}
