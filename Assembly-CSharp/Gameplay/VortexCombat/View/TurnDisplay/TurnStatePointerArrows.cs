using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Gameplay.Combat.View.TurnDisplay;
using Gameplay.Sound.Control;
using Il2CppDummyDll;
using Protocol.Combat;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Utils;

namespace Gameplay.VortexCombat.View.TurnDisplay
{
	// Token: 0x020003A6 RID: 934
	[Token(Token = "0x20003A6")]
	public class TurnStatePointerArrows : MonoBehaviour, ITurnStatePointer
	{
		// Token: 0x060015C9 RID: 5577 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015C9")]
		[Address(RVA = "0x678B", Offset = "0x678B", VA = "0x678B", Slot = "13")]
		protected virtual void HandleTurnStateChanged()
		{
		/* --- GHIDRA: HandleTurnStateChanged ---
		int Gameplay_VortexCombat_View_TurnDisplay_TurnStatePointerArrows__HandleTurnStateChanged
		              (undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a58210 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_VortexCombat_View_TurnDisplay_TurnStatePointerArrows__HandleBackTimeCoroutine_d__9_TypeInfo
		              );
		    DAT_ram_00a58210 = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (
		                    Gameplay_VortexCombat_View_TurnDisplay_TurnStatePointerArrows__HandleBackTimeCoroutine_d__9_TypeInfo
		                    );
		  *(undefined4 *)(iVar1 + 0x10) = param1;
		  *(undefined4 *)(iVar1 + 8) = 0;
		  return iVar1;
		}
		*/

		}

		// Token: 0x060015CA RID: 5578 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60015CA")]
		[Address(RVA = "0x678C", Offset = "0x678C", VA = "0x678C")]
		private IEnumerator HandleBackTimeCoroutine()
		{
		/* --- GHIDRA: HandleBackTimeCoroutine ---
		void Gameplay_VortexCombat_View_TurnDisplay_TurnStatePointerArrows__HandleBackTimeCoroutine
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  double dVar1;
		  float fVar3;
		  undefined4 uVar4;
		  double dVar5;
		  int *piVar6;
		  double param1_00;
		  int iVar7;
		  ulonglong uVar8;
		  float8 local_8;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a58211 == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    DAT_ram_00a58211 = '\x01';
		  }
		  fVar3 = func_ii_7103(param2,0);
		  if (DAT_ram_00a6445d == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Math_TypeInfo);
		    DAT_ram_00a6445d = '\x01';
		  }
		  if (*(int *)(System_Math_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_Math_TypeInfo);
		  }
		  param1_00 = (double)fVar3;
		  dVar1 = param1_00;
		  dVar5 = unnamed_function_4206(param1_00,&local_8);
		  uVar2 = (undefined4)((ulonglong)dVar1 >> 0x20);
		  dVar1 = (double)local_8;
		  if (0.0 <= fVar3) {
		    if (dVar5 == 0.5) {
		      if (ABS((double)local_8) < 9.223372036854776e+18) {
		        uVar8 = (ulonglong)(double)local_8;
		      }
		      else {
		        uVar8 = 0;
		      }
		      if ((uVar8 & 1) != 0) {
		        dVar1 = (double)local_8 + 1.0;
		      }
		    }
		    else {
		      dVar1 = FLOOR(param1_00 + 0.5);
		    }
		  }
		  else if (dVar5 == -0.5) {
		    if (ABS((double)local_8) < 9.223372036854776e+18) {
		      uVar8 = (ulonglong)(double)local_8;
		    }
		    else {
		      uVar8 = 0;
		    }
		    if ((uVar8 & 1) != 0) {
		      dVar1 = (double)local_8 + -1.0;
		    }
		  }
		  else {
		    dVar1 = CEIL(param1_00 + -0.5);
		  }
		  if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Utils_TimeUtils_TypeInfo);
		  }
		  if (ABS(dVar1) < 2147483648.0) {
		    iVar7 = (int)dVar1;
		  }
		  else {
		    iVar7 = -0x80000000;
		  }
		  uVar4 = Utils_TimeUtils__SecToMs(iVar7,0);
		  piVar6 = *(int **)(*(int *)(param1 + 0x10) + 8);
		  iVar7 = *piVar6;
		  (**(code **)((ulonglong)*(uint *)(iVar7 + 0x2d0) * 4))
		            (CONCAT44(uVar2,piVar6),uVar4,*(undefined4 *)(iVar7 + 0x2d4));
		  piVar6 = *(int **)(*(int *)(param1 + 0x14) + 8);
		  iVar7 = *piVar6;
		  (**(code **)((ulonglong)*(uint *)(iVar7 + 0x2d0) * 4))
		            (piVar6,uVar4,*(undefined4 *)(iVar7 + 0x2d4));
		  return;
		}
		*/

			return null;
		}

		// Token: 0x060015CB RID: 5579 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015CB")]
		[Address(RVA = "0x678D", Offset = "0x678D", VA = "0x678D")]
		private void DisplayBackTime(BackTime backTime)
		{
		/* --- GHIDRA: DisplayBackTime ---
		void Gameplay_VortexCombat_View_TurnDisplay_TurnStatePointerArrows__DisplayBackTime
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param1 + 0x10);
		  func_ii_9125(*(undefined4 *)(iVar1 + 0x10),0.0,0.0,0);
		  Core_Animations_GameSpineUiAnimation__get_SkeletonGraphic(*(undefined4 *)(iVar1 + 0xc),0.0,0.0,0);
		  Core_Animations_GameSpineUiAnimation__get_SkeletonGraphic(*(undefined4 *)(iVar1 + 8),0.0,0.0,0);
		  iVar1 = *(int *)(param1 + 0x14);
		  func_ii_9125(*(undefined4 *)(iVar1 + 0x10),0.0,0.0,0);
		  Core_Animations_GameSpineUiAnimation__get_SkeletonGraphic(*(undefined4 *)(iVar1 + 0xc),0.0,0.0,0);
		  Core_Animations_GameSpineUiAnimation__get_SkeletonGraphic(*(undefined4 *)(iVar1 + 8),0.0,0.0,0);
		  return;
		}
		*/

		}

		// Token: 0x060015CC RID: 5580 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015CC")]
		[Address(RVA = "0x678E", Offset = "0x678E", VA = "0x678E")]
		private void Awake()
		{
		/* --- GHIDRA: Awake ---
		void Gameplay_VortexCombat_View_TurnDisplay_TurnStatePointerArrows__Awake
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a58212 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a58212 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x28);
		  while ((param1_01 = (int *)UnityEngine_UI_Image__set_sprite(param1_00,param2,0),
		         param1_01 == (int *)0x0 || (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x28,param1_01,param1_00);
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

		}

		// Token: 0x14000110 RID: 272
		// (add) Token: 0x060015CD RID: 5581 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060015CE RID: 5582 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000110")]
		public event Action TimeOutEvent
		{
			[Token(Token = "0x60015CD")]
			[Address(RVA = "0x678F", Offset = "0x678F", VA = "0x678F", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60015CE")]
			[Address(RVA = "0x6790", Offset = "0x6790", VA = "0x6790", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000111 RID: 273
		// (add) Token: 0x060015CF RID: 5583 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060015D0 RID: 5584 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000111")]
		public event Action TurnStateChangedEvent
		{
			[Token(Token = "0x60015CF")]
			[Address(RVA = "0x6791", Offset = "0x6791", VA = "0x6791", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60015D0")]
			[Address(RVA = "0x6792", Offset = "0x6792", VA = "0x6792", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000398 RID: 920
		// (get) Token: 0x060015D1 RID: 5585 RVA: 0x00005298 File Offset: 0x00003498
		// (set) Token: 0x060015D2 RID: 5586 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000398")]
		public TurnStates TurnState
		{
			[Token(Token = "0x60015D1")]
			[Address(RVA = "0x6793", Offset = "0x6793", VA = "0x6793", Slot = "8")]
			get
			{
				return TurnStates.NoTurn;
			}
			[Token(Token = "0x60015D2")]
			[Address(RVA = "0x6794", Offset = "0x6794", VA = "0x6794")]
			set
			{
			}
		}

		// Token: 0x17000399 RID: 921
		// (get) Token: 0x060015D3 RID: 5587 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060015D4 RID: 5588 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000399")]
		public IGameAudio GameAudio
		{
			[Token(Token = "0x60015D3")]
			[Address(RVA = "0x6795", Offset = "0x6795", VA = "0x6795", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60015D4")]
			[Address(RVA = "0x6796", Offset = "0x6796", VA = "0x6796", Slot = "10")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060015D5 RID: 5589 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015D5")]
		[Address(RVA = "0x6797", Offset = "0x6797", VA = "0x6797", Slot = "11")]
		public void SetTurnState(TurnStates state, float timeout)
		{
		/* --- GHIDRA: SetTurnState ---
		void Gameplay_VortexCombat_View_TurnDisplay_TurnStatePointerArrows__SetTurnState
		               (int param1,undefined4 param2)
		
		{
		  if (*(int *)(param1 + 0x24) != 0) {
		    func_ii_20511(param1,*(int *)(param1 + 0x24),0);
		  }
		  *(undefined4 *)(param1 + 0x24) = 0;
		  return;
		}
		*/

		}

		// Token: 0x060015D6 RID: 5590 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015D6")]
		[Address(RVA = "0x6798", Offset = "0x6798", VA = "0x6798", Slot = "12")]
		public void Stop()
		{
		/* --- GHIDRA: Stop ---
		void Gameplay_VortexCombat_View_TurnDisplay_TurnStatePointerArrows__Stop
		               (int param1,undefined4 param2)
		
		{
		  *(undefined4 *)(param1 + 0x18) = 0x40a00000;
		  UnityEngine_RectTransform__GetParentSize(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x060015D7 RID: 5591 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015D7")]
		[Address(RVA = "0x6799", Offset = "0x6799", VA = "0x6799")]
		public TurnStatePointerArrows()
		{
		}

		// Token: 0x04000B87 RID: 2951
		[Token(Token = "0x4000B87")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TurnStatePointerArrows.TurnPointerElements _leftTurnView;

		// Token: 0x04000B88 RID: 2952
		[Token(Token = "0x4000B88")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private TurnStatePointerArrows.TurnPointerElements _rightTurnView;

		// Token: 0x04000B89 RID: 2953
		[Token(Token = "0x4000B89")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _timeLeftWarningValue;

		// Token: 0x04000B8A RID: 2954
		[Token(Token = "0x4000B8A")]
		[FieldOffset(Offset = "0x1C")]
		private BackTime _backTime;

		// Token: 0x04000B8B RID: 2955
		[Token(Token = "0x4000B8B")]
		[FieldOffset(Offset = "0x20")]
		private TurnStates _turnState;

		// Token: 0x04000B8C RID: 2956
		[Token(Token = "0x4000B8C")]
		[FieldOffset(Offset = "0x24")]
		private Coroutine _timeDisplayCoroutine;

		// Token: 0x020003A7 RID: 935
		[Token(Token = "0x20003A7")]
		[Serializable]
		public struct TurnLocalize
		{
			// Token: 0x04000B90 RID: 2960
			[Token(Token = "0x4000B90")]
			[FieldOffset(Offset = "0x0")]
			public TurnStates State;

			// Token: 0x04000B91 RID: 2961
			[Token(Token = "0x4000B91")]
			[FieldOffset(Offset = "0x4")]
			public string LocaleKey;
		}

		// Token: 0x020003A8 RID: 936
		[Token(Token = "0x20003A8")]
		[Serializable]
		public class TurnPointerElements
		{
			// Token: 0x1700039A RID: 922
			// (get) Token: 0x060015D8 RID: 5592 RVA: 0x000052B0 File Offset: 0x000034B0
			// (set) Token: 0x060015D9 RID: 5593 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700039A")]
			public bool Visible
			{
				[Token(Token = "0x60015D8")]
				[Address(RVA = "0x679A", Offset = "0x679A", VA = "0x679A")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60015D9")]
				[Address(RVA = "0x679B", Offset = "0x679B", VA = "0x679B")]
				set
				{
				}
			}

			// Token: 0x060015DA RID: 5594 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60015DA")]
			[Address(RVA = "0x679C", Offset = "0x679C", VA = "0x679C")]
			private void HandleVisibleChanged()
			{
			}

			// Token: 0x060015DB RID: 5595 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60015DB")]
			[Address(RVA = "0x679D", Offset = "0x679D", VA = "0x679D")]
			public void FadeInOut(float alpha, float duration)
			{
			}

			// Token: 0x060015DC RID: 5596 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60015DC")]
			[Address(RVA = "0x679E", Offset = "0x679E", VA = "0x679E")]
			public void SetState(TurnStates state)
			{
			}

			// Token: 0x060015DD RID: 5597 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60015DD")]
			[Address(RVA = "0x679F", Offset = "0x679F", VA = "0x679F")]
			public TurnPointerElements()
			{
			}

			// Token: 0x04000B92 RID: 2962
			[Token(Token = "0x4000B92")]
			[FieldOffset(Offset = "0x8")]
			[SerializeField]
			public TextMeshProUGUI TimeoutField;

			// Token: 0x04000B93 RID: 2963
			[Token(Token = "0x4000B93")]
			[FieldOffset(Offset = "0xC")]
			[SerializeField]
			public TextMeshProUGUI Title;

			// Token: 0x04000B94 RID: 2964
			[Token(Token = "0x4000B94")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			public Image Image;

			// Token: 0x04000B95 RID: 2965
			[Token(Token = "0x4000B95")]
			[FieldOffset(Offset = "0x14")]
			[SerializeField]
			private TurnStatePointerArrows.TurnLocalize[] _localizes;

			// Token: 0x04000B96 RID: 2966
			[Token(Token = "0x4000B96")]
			[FieldOffset(Offset = "0x18")]
			private float _fadeInOutDuration;

			// Token: 0x04000B97 RID: 2967
			[Token(Token = "0x4000B97")]
			[FieldOffset(Offset = "0x1C")]
			private bool _visible;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_TimeOutEvent ---
		void Gameplay_VortexCombat_View_TurnDisplay_TurnStatePointerArrows__add_TimeOutEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a58213 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a58213 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x28);
		  while ((param1_01 = (int *)func_ii_7048(param1_00,param2,0), param1_01 == (int *)0x0 ||
		         (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x28,param1_01,param1_00);
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


		/* --- GHIDRA: remove_TimeOutEvent ---
		void Gameplay_VortexCombat_View_TurnDisplay_TurnStatePointerArrows__remove_TimeOutEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a58214 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a58214 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x2c);
		  while ((param1_01 = (int *)UnityEngine_UI_Image__set_sprite(param1_00,param2,0),
		         param1_01 == (int *)0x0 || (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x2c,param1_01,param1_00);
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


		/* --- GHIDRA: add_TurnStateChangedEvent ---
		void Gameplay_VortexCombat_View_TurnDisplay_TurnStatePointerArrows__add_TurnStateChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a58215 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a58215 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x2c);
		  while ((param1_01 = (int *)func_ii_7048(param1_00,param2,0), param1_01 == (int *)0x0 ||
		         (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x2c,param1_01,param1_00);
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


		/* --- GHIDRA: get_TurnState ---
		void Gameplay_VortexCombat_View_TurnDisplay_TurnStatePointerArrows__get_TurnState
		               (int *param1,int param2,undefined4 param3)
		
		{
		  if (param2 != param1[8]) {
		    param1[8] = param2;
		    (**(code **)((ulonglong)*(uint *)(*param1 + 0x128) * 4))(param1,*(undefined4 *)(*param1 + 300));
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_GameAudio ---
		void Gameplay_VortexCombat_View_TurnDisplay_TurnStatePointerArrows__set_GameAudio
		               (int *param1,int param2,float param3,undefined4 param4)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a58216 == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_BackTime_TypeInfo);
		    DAT_ram_00a58216 = '\x01';
		  }
		  if (param2 != param1[8]) {
		    param1[8] = param2;
		    (**(code **)((ulonglong)*(uint *)(*param1 + 0x128) * 4))(param1,*(undefined4 *)(*param1 + 300));
		  }
		  iVar1 = unnamed_function_1417(Utils_BackTime_TypeInfo);
		  Core_Extensions_Dict_DictExt__BinarySearch_object__uint_(iVar1,param3,0);
		  param1[7] = iVar1;
		  if (param1[9] == 0) {
		    param1[9] = 0;
		    if (DAT_ram_00a58210 == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&
		                 Gameplay_VortexCombat_View_TurnDisplay_TurnStatePointerArrows__HandleBackTimeCoroutine_d__9_TypeInfo
		                );
		      DAT_ram_00a58210 = '\x01';
		    }
		    iVar1 = unnamed_function_1417
		                      (
		                      Gameplay_VortexCombat_View_TurnDisplay_TurnStatePointerArrows__HandleBackTimeCoroutine_d__9_TypeInfo
		                      );
		    *(int **)(iVar1 + 0x10) = param1;
		    *(undefined4 *)(iVar1 + 8) = 0;
		    iVar1 = UnityEngine_MonoBehaviour__StartCoroutine(param1,iVar1,0);
		    param1[9] = iVar1;
		  }
		  return;
		}
		*/

}
