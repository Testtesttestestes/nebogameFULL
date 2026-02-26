using System;
using System.Collections;
using System.Collections.Generic;
using Gameplay.Combat.View.TurnDisplay;
using Il2CppDummyDll;
using JetBrains.Annotations;
using Protocol.Combat;
using Sirenix.OdinInspector;
using UI.Elements.ProgressBars;
using UnityEngine;

namespace Gameplay.Combat.View.GameField.Hint
{
	// Token: 0x02000974 RID: 2420
	[Token(Token = "0x2000974")]
	public class IdleHint : SerializedMonoBehaviour
	{
		// Token: 0x17000B4E RID: 2894
		// (get) Token: 0x06003993 RID: 14739 RVA: 0x0000B718 File Offset: 0x00009918
		[Token(Token = "0x17000B4E")]
		private TurnStates CurrentState
		{
			[Token(Token = "0x6003993")]
			[Address(RVA = "0x8924", Offset = "0x8924", VA = "0x8924")]
			get
			{
				return TurnStates.NoTurn;
			}
		}

		// Token: 0x06003994 RID: 14740 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003994")]
		[Address(RVA = "0x8925", Offset = "0x8925", VA = "0x8925")]
		protected void Start()
		{
		/* --- GHIDRA: <HintCor>b__19_3 ---
		void Gameplay_Combat_View_GameField_Hint_IdleHint___HintCor_b__19_3
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  uint uVar3;
		  
		  if (DAT_ram_00a57dee == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_StoneMono__Add__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a57dee = '\x01';
		  }
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar2 = UnityEngine_Component__GetComponent_object_(param2,0);
		  iVar1 = Method_System_Collections_Generic_List_StoneMono__Add__;
		  if (iVar2 != 0) {
		    iVar2 = *(int *)(param1 + 0x10);
		    *(int *)(iVar2 + 0x10) = *(int *)(iVar2 + 0x10) + 1;
		    uVar3 = *(uint *)(iVar2 + 0xc);
		    if (uVar3 < *(uint *)(*(int *)(iVar2 + 8) + 0xc)) {
		      *(uint *)(iVar2 + 0xc) = uVar3 + 1;
		      *(undefined4 *)(*(int *)(iVar2 + 8) + uVar3 * 4 + 0x10) = param2;
		      return;
		    }
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar2,param2,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  return;
		}
		*/

		/* --- GHIDRA: <HintCor>b__19_2 ---
		uint Gameplay_Combat_View_GameField_Hint_IdleHint___HintCor_b__19_2(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *param1_00;
		  int iVar3;
		  
		  uVar1 = 0;
		  if (DAT_ram_00a56768 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_View_TurnDisplay_ITurnStatePointer_TypeInfo);
		    DAT_ram_00a56768 = '\x01';
		  }
		  param1_00 = *(int **)(param1 + 0x34);
		  if (param1_00 == (int *)0x0) {
		    uVar1 = 0;
		  }
		  else {
		    iVar3 = *param1_00;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      do {
		        if (Gameplay_Combat_View_TurnDisplay_ITurnStatePointer_TypeInfo ==
		            *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0xe0);
		          goto code_r0x80c76da6;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param1_00,
		                                  Gameplay_Combat_View_TurnDisplay_ITurnStatePointer_TypeInfo,4);
		code_r0x80c76da6:
		    iVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		    uVar1 = (uint)(iVar3 == 3);
		  }
		  return uVar1;
		}
		*/

		/* --- GHIDRA: <HintCor>b__19_1 ---
		uint Gameplay_Combat_View_GameField_Hint_IdleHint___HintCor_b__19_1(int param1,undefined4 param2)
		
		{
		  return (uint)*(byte *)(*(int *)(param1 + 0x30) + 0x48);
		}
		*/

		/* --- GHIDRA: <HintCor>b__19_0 ---
		uint Gameplay_Combat_View_GameField_Hint_IdleHint___HintCor_b__19_0(int param1,undefined4 param2)
		
		{
		  return (uint)*(byte *)(*(int *)(param1 + 0x30) + 0xb4);
		}
		*/

		/* --- GHIDRA: Start ---
		void Gameplay_Combat_View_GameField_Hint_IdleHint__Start(int param1,undefined4 param2)
		
		{
		  bool bVar1;
		  undefined4 uVar2;
		  int iVar3;
		  undefined4 uVar4;
		  int *piVar5;
		  int iVar6;
		  int iVar7;
		  int iVar8;
		  
		  if (DAT_ram_00a5676a == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_BaseGameFieldMono__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_StoneMono__StoneMono__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Combat_View_GameField_Hint_IdleHint_HandleOnMouseDownEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Combat_View_GameField_Hint_IdleHint_HandleSwapEvent__);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_Combat_View_GameField_Hint_IdleHint_RestartHint__)
		    ;
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_Combat_View_GameField_Hint_IdleHint_StopHint__);
		    DAT_ram_00a5676a = '\x01';
		  }
		  iVar8 = *(int *)(param1 + 0x30);
		  uVar4 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar4,param1,Method_Gameplay_Combat_View_GameField_Hint_IdleHint_StopHint__,0);
		  if (DAT_ram_00a56733 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a56733 = '\x01';
		  }
		  iVar3 = *(int *)(iVar8 + 0x50);
		  while ((piVar5 = (int *)func_ii_7048(iVar3,uVar4,0), piVar5 == (int *)0x0 ||
		         (System_Action_TypeInfo == *piVar5))) {
		    iVar6 = func_ii_4329(iVar8 + 0x50,piVar5,iVar3);
		    bVar1 = iVar6 == iVar3;
		    iVar3 = iVar6;
		    if (bVar1) {
		      iVar8 = *(int *)(param1 + 0x30);
		      uVar4 = unnamed_function_1417(System_Action_StoneMono__StoneMono__TypeInfo);
		      System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		                (uVar4,param1,Method_Gameplay_Combat_View_GameField_Hint_IdleHint_HandleSwapEvent__,
		                 0);
		      if (DAT_ram_00a5671c == '\0') {
		        Mono_Security_ASN1__get_Item(&System_Action_StoneMono__StoneMono__TypeInfo);
		        DAT_ram_00a5671c = '\x01';
		      }
		      iVar3 = *(int *)(iVar8 + 0x10);
		      while( true ) {
		        iVar6 = 0;
		        iVar7 = func_ii_7048(iVar3,uVar4,0);
		        uVar2 = System_Action_StoneMono__StoneMono__TypeInfo;
		        if ((iVar7 != 0) &&
		           (iVar6 = func_ii_1082(iVar7,System_Action_StoneMono__StoneMono__TypeInfo), iVar6 == 0))
		        break;
		        iVar6 = func_ii_4329(iVar8 + 0x10,iVar6,iVar3);
		        bVar1 = iVar6 == iVar3;
		        iVar3 = iVar6;
		        if (bVar1) {
		          iVar8 = *(int *)(param1 + 0x30);
		          uVar4 = unnamed_function_1417(System_Action_TypeInfo);
		          UnityEngine_Events_UnityEvent__AddListener
		                    (uVar4,param1,Method_Gameplay_Combat_View_GameField_Hint_IdleHint_RestartHint__,
		                     0);
		          if (DAT_ram_00a56731 == '\0') {
		            Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		            DAT_ram_00a56731 = '\x01';
		          }
		          iVar3 = *(int *)(iVar8 + 0x4c);
		          while ((piVar5 = (int *)func_ii_7048(iVar3,uVar4,0), piVar5 == (int *)0x0 ||
		                 (System_Action_TypeInfo == *piVar5))) {
		            iVar6 = func_ii_4329(iVar8 + 0x4c,piVar5,iVar3);
		            bVar1 = iVar6 == iVar3;
		            iVar3 = iVar6;
		            if (bVar1) {
		              iVar8 = *(int *)(param1 + 0x30);
		              uVar4 = unnamed_function_1417(System_Action_TypeInfo);
		              UnityEngine_Events_UnityEvent__AddListener
		                        (uVar4,param1,
		                         Method_Gameplay_Combat_View_GameField_Hint_IdleHint_RestartHint__,0);
		              if (DAT_ram_00a56734 == '\0') {
		                Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		                DAT_ram_00a56734 = '\x01';
		              }
		              iVar3 = *(int *)(iVar8 + 0x54);
		              while ((piVar5 = (int *)UnityEngine_UI_Image__set_sprite(iVar3,uVar4,0),
		                     piVar5 == (int *)0x0 || (System_Action_TypeInfo == *piVar5))) {
		                iVar6 = func_ii_4329(iVar8 + 0x54,piVar5,iVar3);
		                bVar1 = iVar6 == iVar3;
		                iVar3 = iVar6;
		                if (bVar1) {
		                  iVar8 = *(int *)(param1 + 0x30);
		                  uVar4 = unnamed_function_1417(System_Action_BaseGameFieldMono__TypeInfo);
		                  UnityEngine_UIElements_VisualElement__get_layout
		                            (uVar4,param1,
		                             Method_Gameplay_Combat_View_GameField_Hint_IdleHint_HandleOnMouseDownEvent__
		                             ,0);
		                  if (DAT_ram_00a5671e == '\0') {
		                    Mono_Security_ASN1__get_Item(&System_Action_BaseGameFieldMono__TypeInfo);
		                    DAT_ram_00a5671e = '\x01';
		                  }
		                  iVar3 = *(int *)(iVar8 + 0x14);
		                  while( true ) {
		                    iVar6 = 0;
		                    iVar7 = func_ii_7048(iVar3,uVar4,0);
		                    uVar2 = System_Action_BaseGameFieldMono__TypeInfo;
		                    if ((iVar7 != 0) &&
		                       (iVar6 = func_ii_1082(iVar7,System_Action_BaseGameFieldMono__TypeInfo),
		                       iVar6 == 0)) break;
		                    iVar6 = func_ii_4329(iVar8 + 0x14,iVar6,iVar3);
		                    bVar1 = iVar6 == iVar3;
		                    iVar3 = iVar6;
		                    if (bVar1) {
		                      if (*(int *)(param1 + 0x50) != 0) {
		                        func_ii_20511(param1,*(int *)(param1 + 0x50),0);
		                      }
		                      if (*(int *)(param1 + 0x54) != 0) {
		                        func_ii_20511(param1,*(int *)(param1 + 0x54),0);
		                      }
		                      return;
		                    }
		                  }
		                  System_Activator__CreateInstance(iVar7,uVar2);
		                  do {
		                    halt_trap();
		                  } while( true );
		                }
		              }
		              System_Activator__CreateInstance(piVar5,System_Action_TypeInfo);
		              do {
		                halt_trap();
		              } while( true );
		            }
		          }
		          System_Activator__CreateInstance(piVar5,System_Action_TypeInfo);
		          do {
		            halt_trap();
		          } while( true );
		        }
		      }
		      System_Activator__CreateInstance(iVar7,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  System_Activator__CreateInstance(piVar5,System_Action_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06003995 RID: 14741 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003995")]
		[Address(RVA = "0x8926", Offset = "0x8926", VA = "0x8926")]
		protected void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_Combat_View_GameField_Hint_IdleHint__OnDestroy(int param1,undefined4 param2)
		
		{
		  if (*(int *)(param1 + 0x50) != 0) {
		    func_ii_20511(param1,*(int *)(param1 + 0x50),0);
		  }
		  if (*(int *)(param1 + 0x54) != 0) {
		    func_ii_20511(param1,*(int *)(param1 + 0x54),0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003996 RID: 14742 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003996")]
		[Address(RVA = "0x8927", Offset = "0x8927", VA = "0x8927")]
		private void StopHint()
		{
		/* --- GHIDRA: StopHint ---
		void Gameplay_Combat_View_GameField_Hint_IdleHint__StopHint
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  Gameplay_Combat_View_GameField_Hint_IdleHint__HandleSwapEvent(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06003997 RID: 14743 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003997")]
		[Address(RVA = "0x8928", Offset = "0x8928", VA = "0x8928")]
		private void HandleOnMouseDownEvent(BaseGameFieldMono _)
		{
		/* --- GHIDRA: HandleOnMouseDownEvent ---
		void Gameplay_Combat_View_GameField_Hint_IdleHint__HandleOnMouseDownEvent
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  Gameplay_Combat_View_GameField_Hint_IdleHint__HandleSwapEvent(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06003998 RID: 14744 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003998")]
		[Address(RVA = "0x8929", Offset = "0x8929", VA = "0x8929")]
		private void HandleSwapEvent(StoneMono _, StoneMono __)
		{
		/* --- GHIDRA: HandleSwapEvent ---
		void Gameplay_Combat_View_GameField_Hint_IdleHint__HandleSwapEvent(int param1,undefined4 param2)
		
		{
		  int param1_00;
		  undefined4 uVar1;
		  
		  if (*(int *)(param1 + 0x50) != 0) {
		    func_ii_20511(param1,*(int *)(param1 + 0x50),0);
		  }
		  if (*(int *)(param1 + 0x54) != 0) {
		    func_ii_20511(param1,*(int *)(param1 + 0x54),0);
		  }
		  if (DAT_ram_00a5676b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Combat_View_GameField_Hint_IdleHint__HintCor_d__19_TypeInfo);
		    DAT_ram_00a5676b = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (Gameplay_Combat_View_GameField_Hint_IdleHint__HintCor_d__19_TypeInfo);
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(param1_00,0,0);
		  *(int *)(param1_00 + 0x10) = param1;
		  uVar1 = UnityEngine_MonoBehaviour__StartCoroutine(param1,param1_00,0);
		  *(undefined4 *)(param1 + 0x50) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x06003999 RID: 14745 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003999")]
		[Address(RVA = "0x892A", Offset = "0x892A", VA = "0x892A")]
		private void RestartHint()
		{
		/* --- GHIDRA: RestartHint ---
		int Gameplay_Combat_View_GameField_Hint_IdleHint__RestartHint(undefined4 param1,undefined4 param2)
		
		{
		  int param1_00;
		  
		  if (DAT_ram_00a5676b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Combat_View_GameField_Hint_IdleHint__HintCor_d__19_TypeInfo);
		    DAT_ram_00a5676b = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (Gameplay_Combat_View_GameField_Hint_IdleHint__HintCor_d__19_TypeInfo);
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(param1_00,0,0);
		  *(undefined4 *)(param1_00 + 0x10) = param1;
		  return param1_00;
		}
		*/

		}

		// Token: 0x0600399A RID: 14746 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600399A")]
		[Address(RVA = "0x892B", Offset = "0x892B", VA = "0x892B")]
		private IEnumerator HintCor()
		{
		/* --- GHIDRA: HintCor ---
		void Gameplay_Combat_View_GameField_Hint_IdleHint__HintCor
		               (undefined4 param1,int param2,int param3,undefined4 param4)
		
		{
		  int param2_00;
		  int iVar1;
		  int iVar2;
		  int iVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a56771 == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Vector2___TypeInfo);
		    DAT_ram_00a56771 = '\x01';
		  }
		  iVar1 = *(int *)(param2 + 0x50);
		  iVar2 = *(int *)(param3 + 0x50);
		  iVar3 = *(int *)(param2 + 0x54);
		  iVar4 = *(int *)(param3 + 0x54);
		  param2_00 = Mono_Security_ASN1Convert__ToOid(UnityEngine_Vector2___TypeInfo,1);
		  *(ulonglong *)(param2_00 + 0x10) = CONCAT44((float)(iVar1 * 2 - iVar2),(float)(iVar3 * 2 - iVar4))
		  ;
		  Gameplay_Combat_View_GameField_StoneMono__Impact(param2,param2_00,0.0,param2);
		  return;
		}
		*/

		/* --- GHIDRA: HintCor ---
		void Gameplay_Combat_View_GameField_Hint_IdleHint__HintCor
		               (undefined4 param1,int param2,int param3,undefined4 param4)
		
		{
		  int param2_00;
		  int iVar1;
		  int iVar2;
		  int iVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a56771 == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Vector2___TypeInfo);
		    DAT_ram_00a56771 = '\x01';
		  }
		  iVar1 = *(int *)(param2 + 0x50);
		  iVar2 = *(int *)(param3 + 0x50);
		  iVar3 = *(int *)(param2 + 0x54);
		  iVar4 = *(int *)(param3 + 0x54);
		  param2_00 = Mono_Security_ASN1Convert__ToOid(UnityEngine_Vector2___TypeInfo,1);
		  *(ulonglong *)(param2_00 + 0x10) = CONCAT44((float)(iVar1 * 2 - iVar2),(float)(iVar3 * 2 - iVar4))
		  ;
		  Gameplay_Combat_View_GameField_StoneMono__Impact(param2,param2_00,0.0,param2);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x0600399B RID: 14747 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600399B")]
		[Address(RVA = "0x892C", Offset = "0x892C", VA = "0x892C")]
		private void CalculateHint()
		{
		/* --- GHIDRA: CalculateHint ---
		void Gameplay_Combat_View_GameField_Hint_IdleHint__CalculateHint(int param1,undefined4 param2)
		
		{
		  bool bVar1;
		  int *param1_00;
		  undefined4 param2_00;
		  undefined4 param3;
		  undefined4 param3_00;
		  uint uVar2;
		  uint param2_01;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a5676e == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_HintPatternSO__get_Count__)
		    ;
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_HintPatternSO__get_Item__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_HintPatternSO__set_Item__);
		    Mono_Security_ASN1__get_Item(&System_Random_TypeInfo);
		    DAT_ram_00a5676e = '\x01';
		  }
		  param1_00 = (int *)unnamed_function_1417(System_Random_TypeInfo);
		  System_PlatformNotSupportedException___ctor(param1_00,0);
		  uVar2 = *(uint *)(*(int *)(param1 + 0x48) + 0xc);
		  param2_01 = uVar2 - 1;
		  if (0 < (int)param2_01) {
		    do {
		      param2_00 = (**(code **)((ulonglong)*(uint *)(*param1_00 + 0xf8) * 4))
		                            (param1_00,uVar2,*(undefined4 *)(*param1_00 + 0xfc));
		      param1_01 = *(undefined4 *)(param1 + 0x48);
		      param3 = System_Linq_Enumerable__ToList_object_
		                         (param1_01,param2_00,
		                          Method_System_Collections_Generic_List_HintPatternSO__get_Item__);
		      param3_00 = System_Linq_Enumerable__ToList_object_
		                            (*(undefined4 *)(param1 + 0x48),param2_01,
		                             Method_System_Collections_Generic_List_HintPatternSO__get_Item__);
		      System_Collections_Generic_List_UsageHint___get_Item
		                (param1_01,param2_01,param3,
		                 Method_System_Collections_Generic_List_HintPatternSO__set_Item__);
		      System_Collections_Generic_List_UsageHint___get_Item
		                (param1_01,param2_00,param3_00,
		                 Method_System_Collections_Generic_List_HintPatternSO__set_Item__);
		      bVar1 = 1 < param2_01;
		      uVar2 = param2_01;
		      param2_01 = param2_01 - 1;
		    } while (bVar1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600399C RID: 14748 RVA: 0x0000B730 File Offset: 0x00009930
		[Token(Token = "0x600399C")]
		[Address(RVA = "0x19E8", Offset = "0x19E8", VA = "0x19E8")]
		private bool CheckHint(StonesTypes type)
		{
		/* --- GHIDRA: CheckHint ---
		int * Gameplay_Combat_View_GameField_Hint_IdleHint__CheckHint(int *param1)
		
		{
		  if (*param1 == 0) {
		    return param1;
		  }
		  System_Data_DataSet__ValidateLocaleConstraint(*param1);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

			return default(bool);
		}

		// Token: 0x0600399D RID: 14749 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600399D")]
		[Address(RVA = "0x892D", Offset = "0x892D", VA = "0x892D")]
		private void ShufflePatterns()
		{
		/* --- GHIDRA: ShufflePatterns ---
		undefined4
		Gameplay_Combat_View_GameField_Hint_IdleHint__ShufflePatterns
		          (int param1,uint param2,uint param3,int param4,int param5,uint param6,int param7,
		          int param8,undefined4 param9)
		
		{
		  undefined4 param7_00;
		  int iVar1;
		  undefined4 uVar2;
		  uint uVar3;
		  uint uVar4;
		  int iVar5;
		  uint uVar6;
		  uint uVar7;
		  uint uVar8;
		  int iVar9;
		  uint uVar10;
		  uint uVar11;
		  undefined8 uVar12;
		  undefined8 uVar13;
		  uint uVar14;
		  uint uVar15;
		  undefined1 auStack_f0 [8];
		  undefined8 local_e8;
		  undefined8 local_e0;
		  undefined8 local_d8;
		  undefined8 local_d0;
		  undefined8 local_c8;
		  undefined8 local_c0;
		  undefined8 local_b8;
		  undefined8 local_b0;
		  undefined8 local_a8;
		  undefined8 local_a0;
		  undefined8 local_98;
		  undefined8 local_90;
		  undefined8 local_88;
		  undefined8 local_80;
		  undefined8 local_78;
		  undefined8 local_70;
		  undefined8 local_68;
		  undefined8 local_60;
		  undefined8 local_58;
		  undefined8 local_50;
		  undefined8 local_48;
		  undefined8 local_40;
		  undefined8 local_38;
		  undefined8 local_30;
		  undefined8 local_28;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined4 local_8;
		  undefined4 local_4;
		  
		  uVar2 = 0;
		  uVar11 = 0;
		  iVar9 = 0;
		  if (DAT_ram_00a5676f == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_View_GameField_Hint_IdleHint_HintInfo_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a5676f = '\x01';
		  }
		  local_8 = 0;
		  iVar5 = *(int *)(param1 + 0x30);
		  if (DAT_ram_00a56728 == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a56728 = '\x01';
		  }
		  if ((((-1 < (int)param3) && (-1 < (int)param2)) && (param3 <= *(int *)(iVar5 + 0x40) - 1U)) &&
		     (param2 <= *(int *)(iVar5 + 0x44) - 1U)) {
		    iVar5 = *(int *)(*(int *)(iVar5 + 0x3c) +
		                     (*(int *)(*(int *)(*(int *)(iVar5 + 0x3c) + 8) + 8) * param2 + param3) * 4 +
		                    0x10);
		    uVar2 = 0;
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UnityEngine_Object_TypeInfo);
		    }
		    iVar1 = UnityEngine_TextCore_Text_TextElement__get_textAsset(iVar5,0,0);
		    if (iVar1 != 0) {
		      if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		        func_ii_306000(UnityEngine_Object_TypeInfo);
		      }
		      iVar1 = UnityEngine_Component__GetComponent_object_(iVar5,0);
		      uVar2 = 0;
		      if ((iVar1 != 0) && (*(int *)(iVar5 + 0x58) == param4)) {
		        uVar2 = unnamed_function_1417
		                          (Gameplay_Combat_View_GameField_Hint_IdleHint_HintInfo_TypeInfo);
		        Gameplay_Combat_View_GameField_Hint_IdleHint_HintInfo__TryGetDestination(uVar2,0);
		        local_4 = uVar2;
		        uVar3 = System_Array__get_LongLength(*(undefined4 *)(param5 + 0x2c),param6,0);
		        uVar4 = System_Array__get_LongLength(*(undefined4 *)(param5 + 0x2c),param6 ^ 1,0);
		        if ((0 < (int)uVar3) && (0 < (int)uVar4)) {
		          uVar12 = CONCAT44(param3,param2);
		          do {
		            uVar6 = uVar3 + (uVar11 ^ 0xffffffff);
		            if (param7 == 0) {
		              uVar6 = uVar11;
		            }
		            uVar7 = -uVar11;
		            if (param7 == 0) {
		              uVar7 = uVar11;
		            }
		            uVar10 = 0;
		            do {
		              uVar8 = uVar4 + (uVar10 ^ 0xffffffff);
		              if (param8 == 0) {
		                uVar8 = uVar10;
		              }
		              uVar14 = uVar8;
		              if (param6 == 0) {
		                uVar14 = uVar6;
		              }
		              uVar15 = uVar6;
		              if (param6 == 0) {
		                uVar15 = uVar8;
		              }
		              if (*(char *)(*(int *)(*(int *)(param5 + 0x2c) +
		                                     (*(int *)(*(int *)(*(int *)(param5 + 0x2c) + 8) + 8) * uVar14 +
		                                     uVar15) * 4 + 0x10) + 8) != '\0') {
		                uVar8 = -uVar10;
		                if (param8 == 0) {
		                  uVar8 = uVar10;
		                }
		                if ((int)(uVar8 + param3 | uVar7 + param2) < 0) {
		                  return 0;
		                }
		                if (*(uint *)(*(int *)(param1 + 0x30) + 0x44) <= uVar7 + param2) {
		                  return 0;
		                }
		                if (*(uint *)(*(int *)(param1 + 0x30) + 0x40) <= uVar8 + param3) {
		                  return 0;
		                }
		                uVar13 = CONCAT44(uVar8,uVar7);
		                local_88 = uVar13;
		                local_80 = uVar12;
		                local_18 = uVar13;
		                local_10 = uVar12;
		                iVar5 = Gameplay_Combat_View_GameField_Hint_IdleHint__CheckForSwap
		                                  (param1,&local_80,param4,&local_88,&local_8,auStack_f0);
		                if (iVar5 == 0) {
		                  iVar9 = iVar9 + 1;
		                  if (1 < iVar9) {
		                    return 0;
		                  }
		                  if (DAT_ram_00a56773 == '\0') {
		                    Mono_Security_ASN1__get_Item(&UnityEngine_Vector2Int_TypeInfo);
		                    DAT_ram_00a56773 = '\x01';
		                  }
		                  param7_00 = local_8;
		                  local_a0 = *(undefined8 *)
		                              (*(int *)(UnityEngine_Vector2Int_TypeInfo + 0x5c) + 0x10);
		                  local_98 = uVar13;
		                  local_90 = uVar12;
		                  local_30 = local_a0;
		                  local_28 = uVar13;
		                  local_20 = uVar12;
		                  iVar5 = Gameplay_Combat_View_GameField_Hint_IdleHint__Bump
		                                    (param1,&local_90,param4,&local_98,&local_a0,&local_4,local_8,
		                                     param5,param6,param7,param8,auStack_f0);
		                  if (iVar5 == 0) {
		                    if (DAT_ram_00a56774 == '\0') {
		                      Mono_Security_ASN1__get_Item(&UnityEngine_Vector2Int_TypeInfo);
		                      DAT_ram_00a56774 = '\x01';
		                    }
		                    local_b8 = *(undefined8 *)
		                                (*(int *)(UnityEngine_Vector2Int_TypeInfo + 0x5c) + 0x28);
		                    local_b0 = uVar13;
		                    local_a8 = uVar12;
		                    local_48 = local_b8;
		                    local_40 = uVar13;
		                    local_38 = uVar12;
		                    iVar5 = Gameplay_Combat_View_GameField_Hint_IdleHint__Bump
		                                      (param1,&local_a8,param4,&local_b0,&local_b8,&local_4,
		                                       param7_00,param5,param6,param7,param8,auStack_f0);
		                    if (iVar5 == 0) {
		                      if (DAT_ram_00a56775 == '\0') {
		                        Mono_Security_ASN1__get_Item(&UnityEngine_Vector2Int_TypeInfo);
		                        DAT_ram_00a56775 = '\x01';
		                      }
		                      local_d0 = *(undefined8 *)
		                                  (*(int *)(UnityEngine_Vector2Int_TypeInfo + 0x5c) + 0x18);
		                      local_c8 = uVar13;
		                      local_c0 = uVar12;
		                      local_60 = local_d0;
		                      local_58 = uVar13;
		                      local_50 = uVar12;
		                      iVar5 = Gameplay_Combat_View_GameField_Hint_IdleHint__Bump
		                                        (param1,&local_c0,param4,&local_c8,&local_d0,&local_4,
		                                         param7_00,param5,param6,param7,param8,auStack_f0);
		                      if (iVar5 == 0) {
		                        if (DAT_ram_00a56776 == '\0') {
		                          Mono_Security_ASN1__get_Item(&UnityEngine_Vector2Int_TypeInfo);
		                          DAT_ram_00a56776 = '\x01';
		                        }
		                        local_e8 = *(undefined8 *)
		                                    (*(int *)(UnityEngine_Vector2Int_TypeInfo + 0x5c) + 0x20);
		                        local_e0 = uVar13;
		                        local_d8 = uVar12;
		                        local_78 = local_e8;
		                        local_70 = uVar13;
		                        local_68 = uVar12;
		                        iVar5 = Gameplay_Combat_View_GameField_Hint_IdleHint__Bump
		                                          (param1,&local_d8,param4,&local_e0,&local_e8,&local_4,
		                                           param7_00,param5,param6,param7,param8,auStack_f0);
		                        if (iVar5 == 0) {
		                          return 0;
		                        }
		                      }
		                    }
		                  }
		                }
		                else {
		                  Gameplay_Combat_View_GameField_Hint_IdleHint___HintCor_b__19_3(uVar2,local_8,0);
		                }
		              }
		              uVar10 = uVar10 + 1;
		            } while (uVar10 != uVar4);
		            uVar11 = uVar11 + 1;
		          } while (uVar11 != uVar3);
		        }
		        Gameplay_Combat_View_GameField_Hint_IdleHint__CheckStone(param1,uVar2,auStack_f0);
		        uVar2 = 1;
		      }
		    }
		  }
		  return uVar2;
		}
		*/

		}

		// Token: 0x0600399E RID: 14750 RVA: 0x0000B748 File Offset: 0x00009948
		[Token(Token = "0x600399E")]
		[Address(RVA = "0x892E", Offset = "0x892E", VA = "0x892E")]
		private bool CheckStone(int col, int row, StonesTypes type, HintPatternSO hintPattern, bool transpose, bool invertX, bool invertY)
		{
		/* --- GHIDRA: CheckStone ---
		void Gameplay_Combat_View_GameField_Hint_IdleHint__CheckStone
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int param1_00;
		  undefined4 uVar1;
		  
		  if (*(int *)(param1 + 0x54) != 0) {
		    func_ii_20511(param1,*(int *)(param1 + 0x54),0);
		  }
		  if (DAT_ram_00a56770 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Combat_View_GameField_Hint_IdleHint__HintCor_d__25_TypeInfo);
		    DAT_ram_00a56770 = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (Gameplay_Combat_View_GameField_Hint_IdleHint__HintCor_d__25_TypeInfo);
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(param1_00,0,0);
		  *(undefined4 *)(param1_00 + 0x10) = param2;
		  *(int *)(param1_00 + 0x14) = param1;
		  uVar1 = UnityEngine_MonoBehaviour__StartCoroutine(param1,param1_00,0);
		  *(undefined4 *)(param1 + 0x54) = uVar1;
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x0600399F RID: 14751 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600399F")]
		[Address(RVA = "0x892F", Offset = "0x892F", VA = "0x892F")]
		private void ShowHint(IdleHint.HintInfo info)
		{
		/* --- GHIDRA: ShowHint ---
		int Gameplay_Combat_View_GameField_Hint_IdleHint__ShowHint
		              (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  int param1_00;
		  
		  if (DAT_ram_00a56770 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Combat_View_GameField_Hint_IdleHint__HintCor_d__25_TypeInfo);
		    DAT_ram_00a56770 = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (Gameplay_Combat_View_GameField_Hint_IdleHint__HintCor_d__25_TypeInfo);
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(param1_00,0,0);
		  *(undefined4 *)(param1_00 + 0x10) = param2;
		  *(undefined4 *)(param1_00 + 0x14) = param1;
		  return param1_00;
		}
		*/

		}

		// Token: 0x060039A0 RID: 14752 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60039A0")]
		[Address(RVA = "0x8930", Offset = "0x8930", VA = "0x8930")]
		private IEnumerator HintCor(IdleHint.HintInfo info)
		{
			return null;
		}

		// Token: 0x060039A1 RID: 14753 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60039A1")]
		[Address(RVA = "0x8931", Offset = "0x8931", VA = "0x8931")]
		private void Bump(StoneMono src, StoneMono dst)
		{
		/* --- GHIDRA: Bump ---
		uint Gameplay_Combat_View_GameField_Hint_IdleHint__Bump
		               (undefined4 param1,longlong *param2,undefined4 param3,ulonglong *param4,
		               undefined8 *param5,int *param6,undefined4 param7,uint param8,uint param9,int param10,
		               int param11,undefined4 param12)
		
		{
		  int *piVar1;
		  uint uVar2;
		  uint uVar3;
		  int iVar4;
		  uint uVar5;
		  ulonglong uVar6;
		  uint uVar7;
		  uint uVar8;
		  uint uVar9;
		  uint uVar10;
		  undefined8 local_28;
		  ulonglong local_20;
		  undefined8 local_18;
		  ulonglong local_10;
		  undefined4 local_4;
		  
		  uVar5 = 0;
		  local_4 = 0;
		  uVar2 = System_Array__get_LongLength(*(undefined4 *)(param8 + 0x2c),param9,0);
		  uVar3 = System_Array__get_LongLength(*(undefined4 *)(param8 + 0x2c),param9 ^ 1,0);
		  if ((int)uVar2 < 1) {
		    local_28 = *param5;
		    uVar6 = *param4;
		  }
		  else {
		    uVar6 = *param4;
		    local_28 = *param5;
		    if (0 < (int)uVar3) {
		      piVar1 = (int *)(param8 + 0x2c);
		      do {
		        uVar7 = -uVar5;
		        if (param10 == 0) {
		          uVar7 = uVar5;
		        }
		        if ((int)local_28 + (int)uVar6 == uVar7) {
		          uVar7 = uVar2 + (uVar5 ^ 0xffffffff);
		          if (param10 == 0) {
		            uVar7 = uVar5;
		          }
		          param8 = 0;
		          do {
		            uVar8 = uVar3 + (param8 ^ 0xffffffff);
		            if (param11 == 0) {
		              uVar8 = param8;
		            }
		            uVar9 = uVar8;
		            if (param9 == 0) {
		              uVar9 = uVar7;
		            }
		            uVar10 = uVar7;
		            if (param9 == 0) {
		              uVar10 = uVar8;
		            }
		            if (*(char *)(*(int *)(*piVar1 + (*(int *)(*(int *)(*piVar1 + 8) + 8) * uVar9 + uVar10)
		                                             * 4 + 0x10) + 8) != '\0') {
		              uVar8 = -param8;
		              if (param11 == 0) {
		                uVar8 = param8;
		              }
		              if (uVar8 == (int)((ulonglong)local_28 >> 0x20) + (int)(uVar6 >> 0x20)) {
		                return 0;
		              }
		            }
		            param8 = param8 + 1;
		          } while (param8 != uVar3);
		        }
		        uVar5 = uVar5 + 1;
		      } while (uVar5 != uVar2);
		    }
		  }
		  local_20 = *param2 + (uVar6 & 0xffffffff00000000) & 0xffffffff00000000 |
		             uVar6 + *param2 & 0xffffffff;
		  local_18 = local_28;
		  local_10 = local_20;
		  iVar4 = Gameplay_Combat_View_GameField_Hint_IdleHint__CheckForSwap
		                    (param1,&local_20,param3,&local_28,&local_4,param8);
		  if (iVar4 != 0) {
		    *(undefined4 *)(*param6 + 8) = local_4;
		    *(undefined4 *)(*param6 + 0xc) = param7;
		    Gameplay_Combat_View_GameField_Hint_IdleHint___HintCor_b__19_3(*param6,local_4,0);
		  }
		  return (uint)(iVar4 != 0);
		}
		*/

		}

		// Token: 0x060039A2 RID: 14754 RVA: 0x0000B760 File Offset: 0x00009960
		[Token(Token = "0x60039A2")]
		[Address(RVA = "0x8932", Offset = "0x8932", VA = "0x8932")]
		private bool CheckForSwap(Vector2Int coords, StonesTypes stoneType, Vector2Int baseOffset, Vector2Int offset, ref IdleHint.HintInfo info, StoneMono neighbor, HintPatternSO hintPattern, bool transpose, bool invertX, bool invertY)
		{
		/* --- GHIDRA: CheckForSwap ---
		uint Gameplay_Combat_View_GameField_Hint_IdleHint__CheckForSwap
		               (int param1,int *param2,int param3,int *param4,int *param5,undefined4 param6)
		
		{
		  uint uVar1;
		  uint uVar2;
		  int iVar3;
		  uint uVar4;
		  
		  uVar1 = 0;
		  if (DAT_ram_00a56772 == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a56772 = '\x01';
		  }
		  *param5 = 0;
		  uVar2 = param4[1] + param2[1];
		  uVar4 = *param4 + *param2;
		  if (((-1 < (int)(uVar2 | uVar4)) &&
		      (iVar3 = *(int *)(param1 + 0x30), uVar4 < *(uint *)(iVar3 + 0x44))) &&
		     (uVar2 < *(uint *)(iVar3 + 0x40))) {
		    if (DAT_ram_00a56728 == '\0') {
		      Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		      DAT_ram_00a56728 = '\x01';
		    }
		    *param5 = 0;
		    if (((-1 < (int)uVar2) && (-1 < (int)uVar4)) &&
		       ((uVar2 <= *(int *)(iVar3 + 0x40) - 1U && (uVar4 <= *(int *)(iVar3 + 0x44) - 1U)))) {
		      iVar3 = *(int *)(*(int *)(iVar3 + 0x3c) +
		                       (*(int *)(*(int *)(*(int *)(iVar3 + 0x3c) + 8) + 8) * uVar4 + uVar2) * 4 +
		                      0x10);
		      *param5 = iVar3;
		      if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		        func_ii_306000(UnityEngine_Object_TypeInfo);
		      }
		      iVar3 = UnityEngine_TextCore_Text_TextElement__get_textAsset(iVar3,0,0);
		      if (iVar3 != 0) {
		        iVar3 = *param5;
		        if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		          func_ii_306000(UnityEngine_Object_TypeInfo);
		        }
		        iVar3 = UnityEngine_Component__GetComponent_object_(iVar3,0);
		        if (iVar3 != 0) {
		          uVar1 = (uint)(*(int *)(*param5 + 0x58) == param3);
		        }
		      }
		    }
		  }
		  return uVar1;
		}
		*/

			return default(bool);
		}

		// Token: 0x060039A3 RID: 14755 RVA: 0x0000B778 File Offset: 0x00009978
		[Token(Token = "0x60039A3")]
		[Address(RVA = "0x8933", Offset = "0x8933", VA = "0x8933")]
		private bool IsEqualType(Vector2Int coords, StonesTypes stoneType, Vector2Int offset, out StoneMono neighbor)
		{
		/* --- GHIDRA: IsEqualType ---
		uint Gameplay_Combat_View_GameField_Hint_IdleHint__IsEqualType
		               (int param1,uint param2,uint param3,undefined4 param4)
		
		{
		  uint uVar1;
		  
		  uVar1 = 0;
		  if ((-1 < (int)(param2 | param3)) && (param2 < *(uint *)(*(int *)(param1 + 0x30) + 0x44))) {
		    uVar1 = (uint)(param3 < *(uint *)(*(int *)(param1 + 0x30) + 0x40));
		  }
		  return uVar1;
		}
		*/

			return default(bool);
		}

		// Token: 0x060039A4 RID: 14756 RVA: 0x0000B790 File Offset: 0x00009990
		[Token(Token = "0x60039A4")]
		[Address(RVA = "0x8934", Offset = "0x8934", VA = "0x8934")]
		private bool IsInField(int col, int row)
		{
			return default(bool);
		}

		// Token: 0x060039A5 RID: 14757 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60039A5")]
		[Address(RVA = "0x8935", Offset = "0x8935", VA = "0x8935")]
		public IdleHint()
		{
		}

		// Token: 0x04001FDF RID: 8159
		[Token(Token = "0x4001FDF")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameFieldMono _field;

		// Token: 0x04001FE0 RID: 8160
		[Token(Token = "0x4001FE0")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private ITurnStatePointer _turnPointer;

		// Token: 0x04001FE1 RID: 8161
		[Token(Token = "0x4001FE1")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private ProgressBar _playerHpBar;

		// Token: 0x04001FE2 RID: 8162
		[Token(Token = "0x4001FE2")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float _waitDuration;

		// Token: 0x04001FE3 RID: 8163
		[Token(Token = "0x4001FE3")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _delay;

		// Token: 0x04001FE4 RID: 8164
		[Token(Token = "0x4001FE4")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private List<StonesTypes> _priority;

		// Token: 0x04001FE5 RID: 8165
		[Token(Token = "0x4001FE5")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private List<HintPatternSO> _patterns;

		// Token: 0x04001FE6 RID: 8166
		[Token(Token = "0x4001FE6")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private bool _shufflePatterns;

		// Token: 0x04001FE7 RID: 8167
		[Token(Token = "0x4001FE7")]
		[FieldOffset(Offset = "0x50")]
		private Coroutine _hintCor;

		// Token: 0x04001FE8 RID: 8168
		[Token(Token = "0x4001FE8")]
		[FieldOffset(Offset = "0x54")]
		private Coroutine _bumpCor;

		// Token: 0x02000975 RID: 2421
		[Token(Token = "0x2000975")]
		private class HintInfo
		{
			// Token: 0x060039AA RID: 14762 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60039AA")]
			[Address(RVA = "0x893A", Offset = "0x893A", VA = "0x893A")]
			public void TryAddStone([NotNull] StoneMono value)
			{
			}

			// Token: 0x060039AB RID: 14763 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x60039AB")]
			[Address(RVA = "0x893B", Offset = "0x893B", VA = "0x893B")]
			public IEnumerable<StoneMono> GetStones()
			{
				return null;
			}

			// Token: 0x060039AC RID: 14764 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60039AC")]
			[Address(RVA = "0x893C", Offset = "0x893C", VA = "0x893C")]
			public void SetSource([CanBeNull] StoneMono value)
			{
			}

			// Token: 0x060039AD RID: 14765 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60039AD")]
			[Address(RVA = "0x893D", Offset = "0x893D", VA = "0x893D")]
			public void SetDestination([CanBeNull] StoneMono value)
			{
			}

			// Token: 0x060039AE RID: 14766 RVA: 0x0000B808 File Offset: 0x00009A08
			[Token(Token = "0x60039AE")]
			[Address(RVA = "0x893E", Offset = "0x893E", VA = "0x893E")]
			public bool TryGetSource(out StoneMono stone)
			{
				return default(bool);
			}

			// Token: 0x060039AF RID: 14767 RVA: 0x0000B820 File Offset: 0x00009A20
			[Token(Token = "0x60039AF")]
			[Address(RVA = "0x893F", Offset = "0x893F", VA = "0x893F")]
			public bool TryGetDestination(out StoneMono stone)
			{
				return default(bool);
			}

			// Token: 0x060039B0 RID: 14768 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60039B0")]
			[Address(RVA = "0x8940", Offset = "0x8940", VA = "0x8940")]
			public HintInfo()
			{
			}

			// Token: 0x04001FE9 RID: 8169
			[Token(Token = "0x4001FE9")]
			[FieldOffset(Offset = "0x8")]
			[CanBeNull]
			private StoneMono _source;

			// Token: 0x04001FEA RID: 8170
			[Token(Token = "0x4001FEA")]
			[FieldOffset(Offset = "0xC")]
			[CanBeNull]
			private StoneMono _destination;

			// Token: 0x04001FEB RID: 8171
			[Token(Token = "0x4001FEB")]
			[FieldOffset(Offset = "0x10")]
			private readonly List<StoneMono> _stones;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_CurrentState ---
		void Gameplay_Combat_View_GameField_Hint_IdleHint__get_CurrentState(int param1,undefined4 param2)
		
		{
		  bool bVar1;
		  undefined4 uVar2;
		  int iVar3;
		  undefined4 uVar4;
		  int *piVar5;
		  int iVar6;
		  int iVar7;
		  int iVar8;
		  
		  if (DAT_ram_00a56769 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_BaseGameFieldMono__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_StoneMono__StoneMono__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Combat_View_GameField_Hint_IdleHint_HandleOnMouseDownEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Combat_View_GameField_Hint_IdleHint_HandleSwapEvent__);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_Combat_View_GameField_Hint_IdleHint_RestartHint__)
		    ;
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_Combat_View_GameField_Hint_IdleHint_StopHint__);
		    DAT_ram_00a56769 = '\x01';
		  }
		  iVar8 = *(int *)(param1 + 0x30);
		  uVar4 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar4,param1,Method_Gameplay_Combat_View_GameField_Hint_IdleHint_StopHint__,0);
		  if (DAT_ram_00a56732 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a56732 = '\x01';
		  }
		  iVar3 = *(int *)(iVar8 + 0x50);
		  while ((piVar5 = (int *)UnityEngine_UI_Image__set_sprite(iVar3,uVar4,0), piVar5 == (int *)0x0 ||
		         (System_Action_TypeInfo == *piVar5))) {
		    iVar6 = func_ii_4329(iVar8 + 0x50,piVar5,iVar3);
		    bVar1 = iVar6 == iVar3;
		    iVar3 = iVar6;
		    if (bVar1) {
		      iVar8 = *(int *)(param1 + 0x30);
		      uVar4 = unnamed_function_1417(System_Action_StoneMono__StoneMono__TypeInfo);
		      System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		                (uVar4,param1,Method_Gameplay_Combat_View_GameField_Hint_IdleHint_HandleSwapEvent__,
		                 0);
		      if (DAT_ram_00a5671b == '\0') {
		        Mono_Security_ASN1__get_Item(&System_Action_StoneMono__StoneMono__TypeInfo);
		        DAT_ram_00a5671b = '\x01';
		      }
		      iVar3 = *(int *)(iVar8 + 0x10);
		      while( true ) {
		        iVar6 = 0;
		        iVar7 = UnityEngine_UI_Image__set_sprite(iVar3,uVar4,0);
		        uVar2 = System_Action_StoneMono__StoneMono__TypeInfo;
		        if ((iVar7 != 0) &&
		           (iVar6 = func_ii_1082(iVar7,System_Action_StoneMono__StoneMono__TypeInfo), iVar6 == 0))
		        break;
		        iVar6 = func_ii_4329(iVar8 + 0x10,iVar6,iVar3);
		        bVar1 = iVar6 == iVar3;
		        iVar3 = iVar6;
		        if (bVar1) {
		          iVar8 = *(int *)(param1 + 0x30);
		          uVar4 = unnamed_function_1417(System_Action_TypeInfo);
		          UnityEngine_Events_UnityEvent__AddListener
		                    (uVar4,param1,Method_Gameplay_Combat_View_GameField_Hint_IdleHint_RestartHint__,
		                     0);
		          if (DAT_ram_00a56730 == '\0') {
		            Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		            DAT_ram_00a56730 = '\x01';
		          }
		          iVar3 = *(int *)(iVar8 + 0x4c);
		          while ((piVar5 = (int *)UnityEngine_UI_Image__set_sprite(iVar3,uVar4,0),
		                 piVar5 == (int *)0x0 || (System_Action_TypeInfo == *piVar5))) {
		            iVar6 = func_ii_4329(iVar8 + 0x4c,piVar5,iVar3);
		            bVar1 = iVar6 == iVar3;
		            iVar3 = iVar6;
		            if (bVar1) {
		              iVar8 = *(int *)(param1 + 0x30);
		              uVar4 = unnamed_function_1417(System_Action_TypeInfo);
		              UnityEngine_Events_UnityEvent__AddListener
		                        (uVar4,param1,
		                         Method_Gameplay_Combat_View_GameField_Hint_IdleHint_RestartHint__,0);
		              if (DAT_ram_00a56734 == '\0') {
		                Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		                DAT_ram_00a56734 = '\x01';
		              }
		              iVar3 = *(int *)(iVar8 + 0x54);
		              while ((piVar5 = (int *)UnityEngine_UI_Image__set_sprite(iVar3,uVar4,0),
		                     piVar5 == (int *)0x0 || (System_Action_TypeInfo == *piVar5))) {
		                iVar6 = func_ii_4329(iVar8 + 0x54,piVar5,iVar3);
		                bVar1 = iVar6 == iVar3;
		                iVar3 = iVar6;
		                if (bVar1) {
		                  iVar8 = *(int *)(param1 + 0x30);
		                  uVar4 = unnamed_function_1417(System_Action_BaseGameFieldMono__TypeInfo);
		                  UnityEngine_UIElements_VisualElement__get_layout
		                            (uVar4,param1,
		                             Method_Gameplay_Combat_View_GameField_Hint_IdleHint_HandleOnMouseDownEvent__
		                             ,0);
		                  if (DAT_ram_00a5671d == '\0') {
		                    Mono_Security_ASN1__get_Item(&System_Action_BaseGameFieldMono__TypeInfo);
		                    DAT_ram_00a5671d = '\x01';
		                  }
		                  iVar3 = *(int *)(iVar8 + 0x14);
		                  while( true ) {
		                    iVar6 = 0;
		                    iVar7 = UnityEngine_UI_Image__set_sprite(iVar3,uVar4,0);
		                    uVar2 = System_Action_BaseGameFieldMono__TypeInfo;
		                    if ((iVar7 != 0) &&
		                       (iVar6 = func_ii_1082(iVar7,System_Action_BaseGameFieldMono__TypeInfo),
		                       iVar6 == 0)) break;
		                    iVar6 = func_ii_4329(iVar8 + 0x14,iVar6,iVar3);
		                    bVar1 = iVar6 == iVar3;
		                    iVar3 = iVar6;
		                    if (bVar1) {
		                      Gameplay_Combat_View_GameField_Hint_IdleHint__HandleSwapEvent(param1,iVar6);
		                      return;
		                    }
		                  }
		                  System_Activator__CreateInstance(iVar7,uVar2);
		                  do {
		                    halt_trap();
		                  } while( true );
		                }
		              }
		              System_Activator__CreateInstance(piVar5,System_Action_TypeInfo);
		              do {
		                halt_trap();
		              } while( true );
		            }
		          }
		          System_Activator__CreateInstance(piVar5,System_Action_TypeInfo);
		          do {
		            halt_trap();
		          } while( true );
		        }
		      }
		      System_Activator__CreateInstance(iVar7,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  System_Activator__CreateInstance(piVar5,System_Action_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

}
