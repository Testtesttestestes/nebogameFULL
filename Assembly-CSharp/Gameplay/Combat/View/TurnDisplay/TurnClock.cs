using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Core.Animations;
using DG.Tweening;
using Gameplay.Sound.Control;
using Il2CppDummyDll;
using Protocol.Combat;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Utils;

namespace Gameplay.Combat.View.TurnDisplay
{
	// Token: 0x02000935 RID: 2357
	[Token(Token = "0x2000935")]
	public class TurnClock : MonoBehaviour
	{
		// Token: 0x17000AF5 RID: 2805
		// (get) Token: 0x0600379A RID: 14234 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600379B RID: 14235 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AF5")]
		public IGameAudio GameAudio
		{
			[Token(Token = "0x600379A")]
			[Address(RVA = "0x877C", Offset = "0x877C", VA = "0x877C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600379B")]
			[Address(RVA = "0x877D", Offset = "0x877D", VA = "0x877D")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000AF6 RID: 2806
		// (get) Token: 0x0600379C RID: 14236 RVA: 0x0000B268 File Offset: 0x00009468
		// (set) Token: 0x0600379D RID: 14237 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AF6")]
		public bool IsUseScaleWhenSetDuration
		{
			[Token(Token = "0x600379C")]
			[Address(RVA = "0x877E", Offset = "0x877E", VA = "0x877E")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600379D")]
			[Address(RVA = "0x877F", Offset = "0x877F", VA = "0x877F")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000AF7 RID: 2807
		// (get) Token: 0x0600379E RID: 14238 RVA: 0x0000B280 File Offset: 0x00009480
		// (set) Token: 0x0600379F RID: 14239 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AF7")]
		public TurnStates TurnState
		{
			[Token(Token = "0x600379E")]
			[Address(RVA = "0x8780", Offset = "0x8780", VA = "0x8780")]
			[CompilerGenerated]
			get
			{
				return TurnStates.NoTurn;
			}
			[Token(Token = "0x600379F")]
			[Address(RVA = "0x8781", Offset = "0x8781", VA = "0x8781")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060037A0 RID: 14240 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60037A0")]
		[Address(RVA = "0x8782", Offset = "0x8782", VA = "0x8782")]
		public void SetDuration(int value)
		{
		/* --- GHIDRA: SetDuration ---
		void Gameplay_Combat_View_TurnDisplay_TurnClock__SetDuration
		               (int param1,uint param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (param2 != *(byte *)(param1 + 0x55)) {
		    *(char *)(param1 + 0x55) = (char)param2;
		    iVar1 = 0x20;
		    if (param2 == 0) {
		      iVar1 = 0x30;
		    }
		    local_18 = ((undefined8 *)(param1 + iVar1))[1];
		    local_20 = *(undefined8 *)(param1 + iVar1);
		    iVar1 = **(int **)(param1 + 0x1c);
		    local_10 = local_20;
		    local_8 = local_18;
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0x178) * 4))
		              (*(int **)(param1 + 0x1c),&local_20,*(undefined4 *)(iVar1 + 0x17c));
		  }
		  return;
		}
		*/

		}

		// Token: 0x17000AF8 RID: 2808
		// (set) Token: 0x060037A1 RID: 14241 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AF8")]
		private bool WarningEnabled
		{
			[Token(Token = "0x60037A1")]
			[Address(RVA = "0x8783", Offset = "0x8783", VA = "0x8783")]
			set
			{
			}
		}

		// Token: 0x060037A2 RID: 14242 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60037A2")]
		[Address(RVA = "0x8784", Offset = "0x8784", VA = "0x8784")]
		private void HandleSetDuration(float value)
		{
		/* --- GHIDRA: HandleSetDuration ---
		void Gameplay_Combat_View_TurnDisplay_TurnClock__HandleSetDuration
		               (int param1,uint param2,undefined4 param3)
		
		{
		  bool bVar1;
		  uint uVar2;
		  undefined4 param1_00;
		  
		  if (*(byte *)(param1 + 0x54) != param2) {
		    *(char *)(param1 + 0x54) = (char)param2;
		    uVar2 = *(uint *)(*(int *)(param1 + 0x10) + 0xc);
		    if (0 < (int)uVar2) {
		      do {
		        param1_00 = *(undefined4 *)(*(int *)(param1 + 0x10) + (uVar2 - 1) * 4 + 0x10);
		        if (*(char *)(param1 + 0x54) == '\0') {
		          Core_Animations_GameSpineUiAnimation__AnimationStateOnComplete(param1_00,0);
		        }
		        else {
		          func_ii_7357(param1_00,1,0);
		        }
		        bVar1 = 1 < uVar2;
		        uVar2 = uVar2 - 1;
		      } while (bVar1);
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x060037A3 RID: 14243 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60037A3")]
		[Address(RVA = "0x8785", Offset = "0x8785", VA = "0x8785")]
		private void SetEnableAnimations(bool value)
		{
		/* --- GHIDRA: SetEnableAnimations ---
		void Gameplay_Combat_View_TurnDisplay_TurnClock__SetEnableAnimations(int param1,undefined4 param2)
		
		{
		  bool bVar1;
		  uint uVar2;
		  undefined4 param1_00;
		  
		  uVar2 = *(uint *)(*(int *)(param1 + 0x10) + 0xc);
		  if (0 < (int)uVar2) {
		    do {
		      param1_00 = *(undefined4 *)(*(int *)(param1 + 0x10) + (uVar2 - 1) * 4 + 0x10);
		      if (*(char *)(param1 + 0x54) == '\0') {
		        Core_Animations_GameSpineUiAnimation__AnimationStateOnComplete(param1_00,0);
		      }
		      else {
		        func_ii_7357(param1_00,1,0);
		      }
		      bVar1 = 1 < uVar2;
		      uVar2 = uVar2 - 1;
		    } while (bVar1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060037A4 RID: 14244 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60037A4")]
		[Address(RVA = "0x8786", Offset = "0x8786", VA = "0x8786")]
		private void HandleEnableAnimationChanged()
		{
		/* --- GHIDRA: HandleEnableAnimationChanged ---
		int Gameplay_Combat_View_TurnDisplay_TurnClock__HandleEnableAnimationChanged
		              (undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a566cc == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Combat_View_TurnDisplay_TurnClock__EdgeFillRoutine_d__35_TypeInfo);
		    DAT_ram_00a566cc = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (Gameplay_Combat_View_TurnDisplay_TurnClock__EdgeFillRoutine_d__35_TypeInfo);
		  *(undefined4 *)(iVar1 + 0x10) = param1;
		  *(undefined4 *)(iVar1 + 8) = 0;
		  return iVar1;
		}
		*/

		}

		// Token: 0x060037A5 RID: 14245 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60037A5")]
		[Address(RVA = "0x8787", Offset = "0x8787", VA = "0x8787")]
		private IEnumerator EdgeFillRoutine()
		{
		/* --- GHIDRA: EdgeFillRoutine ---
		int Gameplay_Combat_View_TurnDisplay_TurnClock__EdgeFillRoutine(undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a566cd == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Combat_View_TurnDisplay_TurnClock__TimerRoutine_d__36_TypeInfo);
		    DAT_ram_00a566cd = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (Gameplay_Combat_View_TurnDisplay_TurnClock__TimerRoutine_d__36_TypeInfo);
		  *(undefined4 *)(iVar1 + 0x10) = param1;
		  *(undefined4 *)(iVar1 + 8) = 0;
		  return iVar1;
		}
		*/

			return null;
		}

		// Token: 0x060037A6 RID: 14246 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60037A6")]
		[Address(RVA = "0x8788", Offset = "0x8788", VA = "0x8788")]
		private IEnumerator TimerRoutine()
		{
		/* --- GHIDRA: TimerRoutine ---
		void Gameplay_Combat_View_TurnDisplay_TurnClock__TimerRoutine
		               (int param1,float param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  double dVar3;
		  double param1_00;
		  double dVar4;
		  int iVar5;
		  ulonglong uVar6;
		  float8 local_8;
		  
		  if (DAT_ram_00a566ce == '\0') {
		    Mono_Security_ASN1__get_Item(&System_TimeSpan_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27375);
		    DAT_ram_00a566ce = '\x01';
		  }
		  if (DAT_ram_00a6445d == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Math_TypeInfo);
		    DAT_ram_00a6445d = '\x01';
		  }
		  if (*(int *)(System_Math_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_Math_TypeInfo);
		  }
		  param1_00 = (double)param2;
		  dVar3 = unnamed_function_4206(param1_00,&local_8);
		  dVar4 = (double)local_8;
		  if (0.0 <= param2) {
		    if (dVar3 == 0.5) {
		      if (ABS((double)local_8) < 9.223372036854776e+18) {
		        uVar6 = (ulonglong)(double)local_8;
		      }
		      else {
		        uVar6 = 0;
		      }
		      if ((uVar6 & 1) != 0) {
		        dVar4 = (double)local_8 + 1.0;
		      }
		    }
		    else {
		      dVar4 = FLOOR(param1_00 + 0.5);
		    }
		  }
		  else if (dVar3 == -0.5) {
		    if (ABS((double)local_8) < 9.223372036854776e+18) {
		      uVar6 = (ulonglong)(double)local_8;
		    }
		    else {
		      uVar6 = 0;
		    }
		    if ((uVar6 & 1) != 0) {
		      dVar4 = (double)local_8 + -1.0;
		    }
		  }
		  else {
		    dVar4 = CEIL(param1_00 + -0.5);
		  }
		  if (*(int *)(System_TimeSpan_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_TimeSpan_TypeInfo);
		  }
		  if (ABS(dVar4) < 2147483648.0) {
		    iVar5 = (int)dVar4;
		  }
		  else {
		    iVar5 = -0x80000000;
		  }
		  dVar4 = (double)iVar5;
		  local_8 = (float8)System_Threading_CancellationTokenSource___ctor(dVar4,0);
		  uVar1 = (undefined4)((ulonglong)dVar4 >> 0x20);
		  uVar2 = System_TimeSpan__ToString(&local_8,StringLiteral_27375,0);
		  iVar5 = **(int **)(param1 + 0x1c);
		  (**(code **)((ulonglong)*(uint *)(iVar5 + 0x2d0) * 4))
		            (CONCAT44(uVar1,*(int **)(param1 + 0x1c)),uVar2,*(undefined4 *)(iVar5 + 0x2d4));
		  return;
		}
		*/

			return null;
		}

		// Token: 0x060037A7 RID: 14247 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60037A7")]
		[Address(RVA = "0x8789", Offset = "0x8789", VA = "0x8789")]
		private void DisplayBackTime(float value)
		{
		/* --- GHIDRA: DisplayBackTime ---
		void Gameplay_Combat_View_TurnDisplay_TurnClock__DisplayBackTime
		               (int param1,float param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param2_00;
		  undefined8 local_20;
		  undefined4 local_18;
		  undefined8 local_10;
		  undefined4 local_8;
		  
		  if (DAT_ram_00a566cf == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_SetLink_TweenerCore_Vector3__Vector3__VectorOptions____
		              );
		    DAT_ram_00a566cf = '\x01';
		  }
		  Gameplay_Combat_View_TurnDisplay_TurnClock__TimerRoutine(param1,param2,param1);
		  uVar1 = TMPro_TMP_Text__set_isUsingLegacyAnimationComponent(*(undefined4 *)(param1 + 0x1c),0);
		  local_8 = *(undefined4 *)(param1 + 0x48);
		  local_10 = *(undefined8 *)(param1 + 0x40);
		  Com_TheFallenGames_OSA_Core_OSA_object__object___SetNormalizedPosition(uVar1,&local_10,0);
		  uVar1 = TMPro_TMP_Text__set_isUsingLegacyAnimationComponent(*(undefined4 *)(param1 + 0x1c),0);
		  if (DAT_ram_00a6501f == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Vector3_TypeInfo);
		    DAT_ram_00a6501f = '\x01';
		  }
		  local_18 = *(undefined4 *)(*(int *)(UnityEngine_Vector3_TypeInfo + 0x5c) + 0x14);
		  local_20 = *(undefined8 *)(*(int *)(UnityEngine_Vector3_TypeInfo + 0x5c) + 0xc);
		  uVar1 = System_Collections_Generic_Queue_object___Dequeue
		                    (uVar1,&local_20,*(float *)(param1 + 0x50),0);
		  param2_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(param1 + 0x1c),0);
		  uVar1 = DG_Tweening_TweenSettingsExtensions__SetDelay_object_
		                    (uVar1,param2_00,
		                     Method_DG_Tweening_TweenSettingsExtensions_SetLink_TweenerCore_Vector3__Vector3__VectorOptions____
		                    );
		  *(undefined4 *)(param1 + 0x58) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x060037A8 RID: 14248 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60037A8")]
		[Address(RVA = "0x878A", Offset = "0x878A", VA = "0x878A")]
		private void DisplayBackTimeScaleOut(float value)
		{
		/* --- GHIDRA: DisplayBackTimeScaleOut ---
		void Gameplay_Combat_View_TurnDisplay_TurnClock__DisplayBackTimeScaleOut
		               (int param1,undefined4 param2)
		
		{
		  if (*(int *)(param1 + 0x58) != 0) {
		    func_ii_7891(*(int *)(param1 + 0x58),0,0);
		  }
		  *(undefined4 *)(param1 + 0x68) = 0;
		  return;
		}
		*/

		}

		// Token: 0x060037A9 RID: 14249 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60037A9")]
		[Address(RVA = "0x878B", Offset = "0x878B", VA = "0x878B")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_Combat_View_TurnDisplay_TurnClock__OnDestroy(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  double dVar1;
		  float fVar2;
		  int iVar3;
		  double param1_01;
		  double dVar4;
		  ulonglong uVar5;
		  float8 local_8;
		  
		  fVar2 = *(float *)(param1 + 0x74);
		  if (DAT_ram_00a6445d == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Math_TypeInfo);
		    DAT_ram_00a6445d = '\x01';
		  }
		  if (*(int *)(System_Math_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_Math_TypeInfo);
		  }
		  param1_01 = (double)fVar2;
		  dVar1 = unnamed_function_4206(param1_01,&local_8);
		  dVar4 = (double)local_8;
		  if (0.0 <= fVar2) {
		    if (dVar1 == 0.5) {
		      if (ABS((double)local_8) < 9.223372036854776e+18) {
		        uVar5 = (ulonglong)(double)local_8;
		      }
		      else {
		        uVar5 = 0;
		      }
		      if ((uVar5 & 1) != 0) {
		        dVar4 = (double)local_8 + 1.0;
		      }
		    }
		    else {
		      dVar4 = FLOOR(param1_01 + 0.5);
		    }
		  }
		  else if (dVar1 == -0.5) {
		    if (ABS((double)local_8) < 9.223372036854776e+18) {
		      uVar5 = (ulonglong)(double)local_8;
		    }
		    else {
		      uVar5 = 0;
		    }
		    if ((uVar5 & 1) != 0) {
		      dVar4 = (double)local_8 + -1.0;
		    }
		  }
		  else {
		    dVar4 = CEIL(param1_01 + -0.5);
		  }
		  if (DAT_ram_00a566cb == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_BackTime_TypeInfo);
		    DAT_ram_00a566cb = '\x01';
		  }
		  if (ABS(dVar4) < 2147483648.0) {
		    iVar3 = (int)dVar4;
		  }
		  else {
		    iVar3 = -0x80000000;
		  }
		  param1_00 = unnamed_function_1417(Utils_BackTime_TypeInfo);
		  Core_Extensions_Dict_DictExt__BinarySearch_object__uint_(param1_00,(float)iVar3,0);
		  *(undefined4 *)(param1 + 0x5c) = param1_00;
		  Gameplay_Combat_View_TurnDisplay_TurnClock__set_WarningEnabled(param1,(float)iVar3,param1);
		  return;
		}
		*/

		}

		// Token: 0x060037AA RID: 14250 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60037AA")]
		[Address(RVA = "0x878C", Offset = "0x878C", VA = "0x878C")]
		public void Test()
		{
		/* --- GHIDRA: Test ---
		void Gameplay_Combat_View_TurnDisplay_TurnClock__Test(int param1,undefined4 param2)
		
		{
		  undefined8 uVar1;
		  
		  *(undefined8 *)(param1 + 0x30) = 0x3f8000003f800000;
		  *(undefined8 *)(param1 + 0x20) = 0x3f800000;
		  *(undefined8 *)(param1 + 0x38) = 0x3f8000003f800000;
		  *(undefined8 *)(param1 + 0x28) = 0x3f80000000000000;
		  if (DAT_ram_00a6501f == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Vector3_TypeInfo);
		    DAT_ram_00a6501f = '\x01';
		  }
		  uVar1 = *(undefined8 *)(*(int *)(UnityEngine_Vector3_TypeInfo + 0x5c) + 0xc);
		  *(undefined4 *)(param1 + 0x48) =
		       *(undefined4 *)(*(int *)(UnityEngine_Vector3_TypeInfo + 0x5c) + 0x14);
		  *(undefined8 *)(param1 + 0x40) = uVar1;
		  *(undefined8 *)(param1 + 0x4c) = 0x3e99999a40a00000;
		  UnityEngine_RectTransform__GetParentSize(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x060037AB RID: 14251 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60037AB")]
		[Address(RVA = "0x878D", Offset = "0x878D", VA = "0x878D")]
		public TurnClock()
		{
		}

		// Token: 0x04001EAD RID: 7853
		[Token(Token = "0x4001EAD")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private GameSpineUiAnimation[] _animations;

		// Token: 0x04001EAE RID: 7854
		[Token(Token = "0x4001EAE")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private GameSpineUiAnimation _edge;

		// Token: 0x04001EAF RID: 7855
		[Token(Token = "0x4001EAF")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _mask;

		// Token: 0x04001EB0 RID: 7856
		[Token(Token = "0x4001EB0")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private TextMeshProUGUI _backtimeField;

		// Token: 0x04001EB1 RID: 7857
		[Token(Token = "0x4001EB1")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Color _thresholdWarningColor;

		// Token: 0x04001EB2 RID: 7858
		[Token(Token = "0x4001EB2")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Color _defaultColor;

		// Token: 0x04001EB3 RID: 7859
		[Token(Token = "0x4001EB3")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Vector3 _displayedValueScale;

		// Token: 0x04001EB4 RID: 7860
		[Token(Token = "0x4001EB4")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private float _thresholdWarningValue;

		// Token: 0x04001EB5 RID: 7861
		[Token(Token = "0x4001EB5")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float _scaleDuration;

		// Token: 0x04001EB6 RID: 7862
		[Token(Token = "0x4001EB6")]
		public const float FULL_ANGLE = 360f;

		// Token: 0x04001EB7 RID: 7863
		[Token(Token = "0x4001EB7")]
		public const float REDRAW_RATE = 0.03f;

		// Token: 0x04001EB8 RID: 7864
		[Token(Token = "0x4001EB8")]
		[FieldOffset(Offset = "0x54")]
		private bool _enableAnimation;

		// Token: 0x04001EB9 RID: 7865
		[Token(Token = "0x4001EB9")]
		[FieldOffset(Offset = "0x55")]
		private bool _warningEnabled;

		// Token: 0x04001EBA RID: 7866
		[Token(Token = "0x4001EBA")]
		[FieldOffset(Offset = "0x58")]
		private Tween _scaleTween;

		// Token: 0x04001EBB RID: 7867
		[Token(Token = "0x4001EBB")]
		[FieldOffset(Offset = "0x5C")]
		private BackTime _backTime;

		// Token: 0x04001EBC RID: 7868
		[Token(Token = "0x4001EBC")]
		[FieldOffset(Offset = "0x60")]
		private Coroutine _timerRoutine;

		// Token: 0x04001EBD RID: 7869
		[Token(Token = "0x4001EBD")]
		[FieldOffset(Offset = "0x64")]
		private Coroutine _edgeRoutine;

		// Token: 0x04001EC1 RID: 7873
		[Token(Token = "0x4001EC1")]
		[FieldOffset(Offset = "0x74")]
		[SerializeField]
		private float _testDuration;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_TurnState ---
		void Gameplay_Combat_View_TurnDisplay_TurnClock__set_TurnState
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a566cb == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_BackTime_TypeInfo);
		    DAT_ram_00a566cb = '\x01';
		  }
		  param1_00 = unnamed_function_1417(Utils_BackTime_TypeInfo);
		  Core_Extensions_Dict_DictExt__BinarySearch_object__uint_(param1_00,(float)param2,0);
		  *(undefined4 *)(param1 + 0x5c) = param1_00;
		  Gameplay_Combat_View_TurnDisplay_TurnClock__set_WarningEnabled(param1,(float)param2,param1);
		  return;
		}
		*/


		/* --- GHIDRA: set_WarningEnabled ---
		void Gameplay_Combat_View_TurnDisplay_TurnClock__set_WarningEnabled
		               (int param1,float param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int iVar2;
		  undefined4 uVar3;
		  uint uVar4;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (0.0 < param2 != (bool)*(char *)(param1 + 0x54)) {
		    *(bool *)(param1 + 0x54) = 0.0 < param2;
		    uVar4 = *(uint *)(*(int *)(param1 + 0x10) + 0xc);
		    if (0 < (int)uVar4) {
		      do {
		        uVar3 = *(undefined4 *)(*(int *)(param1 + 0x10) + (uVar4 - 1) * 4 + 0x10);
		        if (*(char *)(param1 + 0x54) == '\0') {
		          Core_Animations_GameSpineUiAnimation__AnimationStateOnComplete(uVar3,0);
		        }
		        else {
		          func_ii_7357(uVar3,1,0);
		        }
		        bVar1 = 1 < uVar4;
		        uVar4 = uVar4 - 1;
		      } while (bVar1);
		    }
		  }
		  bVar1 = param2 <= *(float *)(param1 + 0x4c);
		  if (bVar1 != (bool)*(char *)(param1 + 0x55)) {
		    *(bool *)(param1 + 0x55) = bVar1;
		    iVar2 = 0x20;
		    if (!bVar1) {
		      iVar2 = 0x30;
		    }
		    local_18 = ((undefined8 *)(param1 + iVar2))[1];
		    local_20 = *(undefined8 *)(param1 + iVar2);
		    iVar2 = **(int **)(param1 + 0x1c);
		    local_10 = local_20;
		    local_8 = local_18;
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0x178) * 4))
		              (*(int **)(param1 + 0x1c),&local_20,*(undefined4 *)(iVar2 + 0x17c));
		  }
		  if (*(char *)(param1 + 0x6c) == '\0') {
		    Gameplay_Combat_View_TurnDisplay_TurnClock__TimerRoutine(param1,param2,param1);
		  }
		  else {
		    Gameplay_Combat_View_TurnDisplay_TurnClock__DisplayBackTime(param1,param2,param1);
		  }
		  if (*(int *)(param1 + 0x60) != 0) {
		    func_ii_20511(param1,*(int *)(param1 + 0x60),0);
		  }
		  if (*(int *)(param1 + 100) != 0) {
		    func_ii_20511(param1,*(int *)(param1 + 100),0);
		  }
		  if (DAT_ram_00a566cd == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Combat_View_TurnDisplay_TurnClock__TimerRoutine_d__36_TypeInfo);
		    DAT_ram_00a566cd = '\x01';
		  }
		  iVar2 = unnamed_function_1417
		                    (Gameplay_Combat_View_TurnDisplay_TurnClock__TimerRoutine_d__36_TypeInfo);
		  *(int *)(iVar2 + 0x10) = param1;
		  *(undefined4 *)(iVar2 + 8) = 0;
		  uVar3 = UnityEngine_MonoBehaviour__StartCoroutine(param1,iVar2,0);
		  *(undefined4 *)(param1 + 0x60) = uVar3;
		  if (DAT_ram_00a566cc == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Combat_View_TurnDisplay_TurnClock__EdgeFillRoutine_d__35_TypeInfo);
		    DAT_ram_00a566cc = '\x01';
		  }
		  iVar2 = unnamed_function_1417
		                    (Gameplay_Combat_View_TurnDisplay_TurnClock__EdgeFillRoutine_d__35_TypeInfo);
		  *(int *)(iVar2 + 0x10) = param1;
		  *(undefined4 *)(iVar2 + 8) = 0;
		  uVar3 = UnityEngine_MonoBehaviour__StartCoroutine(param1,iVar2,0);
		  *(undefined4 *)(param1 + 100) = uVar3;
		  return;
		}
		*/

}
