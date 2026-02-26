using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Animations;
using DG.Tweening;
using Gameplay.Sound.Control;
using Il2CppDummyDll;
using TMPro;
using UI.Windows;
using UnityEngine;
using UnityEngine.UI;
using Utils;

namespace Gameplay.Combat.View
{
	// Token: 0x0200091B RID: 2331
	[Token(Token = "0x200091B")]
	public class CombatWaitingWindowMono : BaseWindow<CombatWaitingWindowMono.CombatWaitingWindowArgs>
	{
		// Token: 0x17000AD5 RID: 2773
		// (get) Token: 0x060036E8 RID: 14056 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000AD5")]
		public override string WindowId
		{
			[Token(Token = "0x60036E8")]
			[Address(RVA = "0x86D7", Offset = "0x86D7", VA = "0x86D7", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000AD6 RID: 2774
		// (get) Token: 0x060036E9 RID: 14057 RVA: 0x0000B010 File Offset: 0x00009210
		[Token(Token = "0x17000AD6")]
		public override bool IsFullscreenWindow
		{
			[Token(Token = "0x60036E9")]
			[Address(RVA = "0x86D8", Offset = "0x86D8", VA = "0x86D8", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000AD7 RID: 2775
		// (get) Token: 0x060036EA RID: 14058 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060036EB RID: 14059 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AD7")]
		public IGameAudio GameAudio
		{
			[Token(Token = "0x60036EA")]
			[Address(RVA = "0x86D9", Offset = "0x86D9", VA = "0x86D9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60036EB")]
			[Address(RVA = "0x86DA", Offset = "0x86DA", VA = "0x86DA")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000AD8 RID: 2776
		// (get) Token: 0x060036EC RID: 14060 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060036ED RID: 14061 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AD8")]
		public BackTime BackTimer
		{
			[Token(Token = "0x60036EC")]
			[Address(RVA = "0x86DB", Offset = "0x86DB", VA = "0x86DB")]
			get
			{
				return null;
			}
			[Token(Token = "0x60036ED")]
			[Address(RVA = "0x86DC", Offset = "0x86DC", VA = "0x86DC")]
			private set
			{
			}
		}

		// Token: 0x060036EE RID: 14062 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036EE")]
		[Address(RVA = "0x86DD", Offset = "0x86DD", VA = "0x86DD")]
		private void HandleBackTimerChanged()
		{
		/* --- GHIDRA: HandleBackTimerChanged ---
		int Gameplay_Combat_View_CombatWaitingWindowMono__HandleBackTimerChanged
		              (undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a63b2d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Combat_View_CombatWaitingWindowMono__ShowCurrentState_d__23_TypeInfo);
		    DAT_ram_00a63b2d = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (Gameplay_Combat_View_CombatWaitingWindowMono__ShowCurrentState_d__23_TypeInfo);
		  *(undefined4 *)(iVar1 + 0x10) = param1;
		  *(undefined4 *)(iVar1 + 8) = 0;
		  return iVar1;
		}
		*/

		}

		// Token: 0x060036EF RID: 14063 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60036EF")]
		[Address(RVA = "0x86DE", Offset = "0x86DE", VA = "0x86DE")]
		private IEnumerator ShowCurrentState()
		{
		/* --- GHIDRA: ShowCurrentState ---
		void Gameplay_Combat_View_CombatWaitingWindowMono__ShowCurrentState
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  int iVar5;
		  int local_20;
		  undefined8 *local_1c;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined4 local_4;
		  
		  local_4 = param2;
		  if (DAT_ram_00a63b2e == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Select_char__int___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToArray_int___);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_Image__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_Image__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_Image__get_Current__);
		    Mono_Security_ASN1__get_Item(&System_Func_char__int__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Image__GetEnumerator__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Image__get_Item__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Combat_View_CombatWaitingWindowMono___c__SetSpritesByDigit_b__24_0__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_View_CombatWaitingWindowMono___c_TypeInfo);
		    DAT_ram_00a63b2e = '\x01';
		  }
		  local_10 = 0;
		  local_18 = 0;
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_18,*(undefined4 *)(param1 + 0x58),
		             Method_System_Collections_Generic_List_Image__GetEnumerator__);
		  local_20 = 0;
		  local_1c = &local_18;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar2 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_18,
		                       Method_System_Collections_Generic_List_Enumerator_Image__MoveNext__);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x82340b80;
		    }
		    if (iVar2 == 0) goto code_r0x82340bd6;
		    DAT_ram_009d3e38 = 0;
		    uVar3 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x25c,local_10._4_4_,0);
		    if (DAT_ram_009d3e38 == 1) break;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii(s_struct_Uniforms___color__array<v_ram_000013c7 + 0x26d,uVar3,0,0);
		  } while (DAT_ram_009d3e38 != 1);
		  DAT_ram_009d3e38 = 0;
		  uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x82340b80:
		  iVar1 = global_1;
		  iVar2 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar1 == iVar2) {
		    piVar4 = (int *)import::env::__cxa_begin_catch(uVar3);
		    iVar2 = *piVar4;
		    DAT_ram_009d3e38 = 0;
		    local_20 = iVar2;
		    import::env::invoke_v(0x123);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 != 1) {
		      if (iVar2 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		code_r0x82340bd6:
		      DAT_ram_009d3e38 = 0;
		      uVar3 = func_ii_4443(&local_4,0);
		      if (*(int *)(Gameplay_Combat_View_CombatWaitingWindowMono___c_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Gameplay_Combat_View_CombatWaitingWindowMono___c_TypeInfo);
		      }
		      piVar4 = *(int **)(Gameplay_Combat_View_CombatWaitingWindowMono___c_TypeInfo + 0x5c);
		      iVar2 = piVar4[1];
		      iVar1 = Gameplay_Combat_View_CombatWaitingWindowMono___c_TypeInfo;
		      if (iVar2 == 0) {
		        if (*(int *)(Gameplay_Combat_View_CombatWaitingWindowMono___c_TypeInfo + 0x74) == 0) {
		          func_ii_306000(Gameplay_Combat_View_CombatWaitingWindowMono___c_TypeInfo);
		          piVar4 = *(int **)(Gameplay_Combat_View_CombatWaitingWindowMono___c_TypeInfo + 0x5c);
		        }
		        iVar1 = *piVar4;
		        iVar2 = unnamed_function_1417(System_Func_char__int__TypeInfo);
		        System_Func_char__bool___Invoke
		                  (iVar2,iVar1,
		                   Method_Gameplay_Combat_View_CombatWaitingWindowMono___c__SetSpritesByDigit_b__24_0__
		                   ,0);
		        *(int *)(*(int *)(Gameplay_Combat_View_CombatWaitingWindowMono___c_TypeInfo + 0x5c) + 4) =
		             iVar2;
		      }
		      uVar3 = System_Linq_Enumerable__ReverseIterator___Il2CppFullySharedGenericType_
		                        (uVar3,iVar2,Method_System_Linq_Enumerable_Select_char__int___);
		      iVar2 = System_Linq_Enumerable__ToArray_double_
		                        (uVar3,Method_System_Linq_Enumerable_ToArray_int___);
		      if (0 < *(int *)(iVar2 + 0xc)) {
		        iVar1 = 0;
		        do {
		          iVar5 = *(int *)(iVar2 + iVar1 * 4 + 0x10);
		          uVar3 = System_Linq_Enumerable__ToList_object_
		                            (*(undefined4 *)(param1 + 0x58),iVar1,
		                             Method_System_Collections_Generic_List_Image__get_Item__);
		          uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                            (uVar3,0);
		          Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                    (uVar3,1,0);
		          uVar3 = System_Linq_Enumerable__ToList_object_
		                            (*(undefined4 *)(param1 + 0x58),iVar1,
		                             Method_System_Collections_Generic_List_Image__get_Item__);
		          func_ii_7050(uVar3,*(undefined4 *)(*(int *)(param1 + 0x48) + iVar5 * 4 + 0x10),0);
		          iVar1 = iVar1 + 1;
		        } while (iVar1 < *(int *)(iVar2 + 0xc));
		      }
		      Gameplay_Combat_View_CombatWaitingWindowMono__SetSpritesByDigit(param1,iVar1);
		      return;
		    }
		    uVar3 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s___Scripting__UnityEngine__Player_ram_000044a6 + 1,&local_20);
		  iVar1 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar1 == 1) {
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__resumeException(uVar3);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

			return null;
		}

		// Token: 0x060036F0 RID: 14064 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036F0")]
		[Address(RVA = "0x86DF", Offset = "0x86DF", VA = "0x86DF")]
		private void SetSpritesByDigit(int value)
		{
		/* --- GHIDRA: SetSpritesByDigit ---
		void Gameplay_Combat_View_CombatWaitingWindowMono__SetSpritesByDigit(int param1,undefined4 param2)
		
		{
		  undefined4 param2_00;
		  undefined4 uVar1;
		  undefined8 local_10;
		  undefined4 local_8;
		  
		  if (DAT_ram_00a63b2f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_SetLink_TweenerCore_Vector3__Vector3__VectorOptions____
		              );
		    DAT_ram_00a63b2f = '\x01';
		  }
		  if (*(int *)(param1 + 0x54) != 0) {
		    func_ii_7891(*(int *)(param1 + 0x54),0,0);
		  }
		  uVar1 = *(undefined4 *)(param1 + 0x44);
		  if (DAT_ram_00a6501f == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Vector3_TypeInfo);
		    DAT_ram_00a6501f = '\x01';
		  }
		  local_8 = *(undefined4 *)(*(int *)(UnityEngine_Vector3_TypeInfo + 0x5c) + 0x14);
		  local_10 = *(undefined8 *)(*(int *)(UnityEngine_Vector3_TypeInfo + 0x5c) + 0xc);
		  Com_TheFallenGames_OSA_Core_OSA_object__object___SetNormalizedPosition(uVar1,&local_10,0);
		  uVar1 = DG_Tweening_ShortcutExtensions__DOLocalRotateQuaternion
		                    (*(undefined4 *)(param1 + 0x44),0.0,6.0,0);
		  param2_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(param1 + 0x44),0);
		  uVar1 = DG_Tweening_TweenSettingsExtensions__SetDelay_object_
		                    (uVar1,param2_00,
		                     Method_DG_Tweening_TweenSettingsExtensions_SetLink_TweenerCore_Vector3__Vector3__VectorOptions____
		                    );
		  *(undefined4 *)(param1 + 0x54) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x060036F1 RID: 14065 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036F1")]
		[Address(RVA = "0x86E0", Offset = "0x86E0", VA = "0x86E0")]
		private void StartScaling()
		{
		/* --- GHIDRA: StartScaling ---
		uint Gameplay_Combat_View_CombatWaitingWindowMono__StartScaling
		               (int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param1 + 0x5c);
		  if (param2 != iVar1) {
		    *(int *)(param1 + 0x5c) = param2;
		    Gameplay_Combat_View_CombatWaitingWindowMono__TrySetLastValue(param1,param2,param2);
		  }
		  return (uint)(param2 != iVar1);
		}
		*/

		}

		// Token: 0x060036F2 RID: 14066 RVA: 0x0000B028 File Offset: 0x00009228
		[Token(Token = "0x60036F2")]
		[Address(RVA = "0x86E1", Offset = "0x86E1", VA = "0x86E1")]
		private bool TrySetLastValue(int value)
		{
		/* --- GHIDRA: TrySetLastValue ---
		void Gameplay_Combat_View_CombatWaitingWindowMono__TrySetLastValue
		               (int param1,uint param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *piVar3;
		  int iVar4;
		  uint uVar5;
		  
		  if (DAT_ram_00a63b30 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Sound_Control_IGameAudio_TypeInfo);
		    DAT_ram_00a63b30 = '\x01';
		  }
		  if (param2 == 0) {
		    uVar5 = 0;
		    piVar3 = *(int **)(param1 + 0x4c);
		    iVar4 = *piVar3;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      do {
		        if (Gameplay_Sound_Control_IGameAudio_TypeInfo ==
		            *(int *)(*(int *)(iVar4 + 0x58) + uVar5 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar5 * 8 + 4) * 8 + iVar4 + 200);
		          goto code_r0x82340ed3;
		        }
		        uVar5 = uVar5 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar5);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar3,Gameplay_Sound_Control_IGameAudio_TypeInfo,1);
		code_r0x82340ed3:
		    (**(code **)((ulonglong)*puVar2 * 4))(piVar3,0xb,puVar2[1]);
		    return;
		  }
		  piVar3 = *(int **)(param1 + 0x4c);
		  iVar4 = *piVar3;
		  uVar5 = (uint)*(ushort *)(iVar4 + 0xb6);
		  if ((param2 & 1) == 0) {
		    if (uVar5 != 0) {
		      uVar1 = 0;
		      do {
		        if (Gameplay_Sound_Control_IGameAudio_TypeInfo ==
		            *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 200);
		          goto code_r0x82340f68;
		        }
		        uVar1 = uVar1 + 1;
		      } while (uVar5 != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar3,Gameplay_Sound_Control_IGameAudio_TypeInfo,1);
		code_r0x82340f68:
		    (**(code **)((ulonglong)*puVar2 * 4))(piVar3,9,puVar2[1]);
		    return;
		  }
		  if (uVar5 != 0) {
		    uVar1 = 0;
		    do {
		      if (Gameplay_Sound_Control_IGameAudio_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)
		         ) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 200);
		        goto code_r0x82340fd3;
		      }
		      uVar1 = uVar1 + 1;
		    } while (uVar5 != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Gameplay_Sound_Control_IGameAudio_TypeInfo,1);
		code_r0x82340fd3:
		  (**(code **)((ulonglong)*puVar2 * 4))(piVar3,10,puVar2[1]);
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x060036F3 RID: 14067 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036F3")]
		[Address(RVA = "0x86E2", Offset = "0x86E2", VA = "0x86E2")]
		private void PlaySound(int value)
		{
		}

		// Token: 0x060036F4 RID: 14068 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036F4")]
		[Address(RVA = "0x86E3", Offset = "0x86E3", VA = "0x86E3")]
		public void HideWaitingWindow()
		{
		/* --- GHIDRA: HideWaitingWindow ---
		void Gameplay_Combat_View_CombatWaitingWindowMono__HideWaitingWindow
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  UnityEngine_Component__GetComponentInChildren_object_(*(undefined4 *)(param1 + 0x34),param2,0);
		  return;
		}
		*/

		}

		// Token: 0x060036F5 RID: 14069 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036F5")]
		[Address(RVA = "0x86E4", Offset = "0x86E4", VA = "0x86E4")]
		public void SetTitle(string value)
		{
		}

		// Token: 0x060036F6 RID: 14070 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036F6")]
		[Address(RVA = "0x86E5", Offset = "0x86E5", VA = "0x86E5")]
		public void SetDescription(string value)
		{
		/* --- GHIDRA: SetDescription ---
		void Gameplay_Combat_View_CombatWaitingWindowMono__SetDescription(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (*(int *)(param1 + 0x54) != 0) {
		    func_ii_7891(*(int *)(param1 + 0x54),0,0);
		  }
		  param1_00 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                        (*(undefined4 *)(param1 + 0x40),0);
		  func_ii_8007(param1_00,0,0);
		  *(undefined4 *)(param1 + 0x4c) = 0;
		  return;
		}
		*/

		}

		// Token: 0x060036F7 RID: 14071 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036F7")]
		[Address(RVA = "0x86E6", Offset = "0x86E6", VA = "0x86E6")]
		private void OnDestroy()
		{
		}

		// Token: 0x060036F8 RID: 14072 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036F8")]
		[Address(RVA = "0x86E7", Offset = "0x86E7", VA = "0x86E7", Slot = "19")]
		protected override void OnClose()
		{
		/* --- GHIDRA: OnClose ---
		void Gameplay_Combat_View_CombatWaitingWindowMono__OnClose(int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param2_00;
		  undefined1 auStack_50 [8];
		  undefined8 local_48;
		  undefined4 local_40;
		  undefined8 local_38;
		  undefined4 local_30;
		  undefined8 local_28;
		  undefined4 local_20;
		  undefined8 local_1c;
		  undefined4 local_14;
		  undefined8 local_10;
		  undefined4 local_8;
		  
		  if (DAT_ram_00a63b31 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_SetEase_TweenerCore_Vector3__Vector3__VectorOptions____
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_SetLink_TweenerCore_Vector3__Vector3__VectorOptions____
		              );
		    DAT_ram_00a63b31 = '\x01';
		  }
		  *(undefined4 *)(param1 + 0x4c) = *(undefined4 *)(param2 + 0x18);
		  if (*(int *)(param2 + 0x1c) != *(int *)(param1 + 0x50)) {
		    *(int *)(param1 + 0x50) = *(int *)(param2 + 0x1c);
		    Gameplay_Combat_View_CombatWaitingWindowMono__set_BackTimer(param1,auStack_50);
		  }
		  func_ii_7357(*(undefined4 *)(param1 + 0x40),1,0);
		  uVar1 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                    (*(undefined4 *)(param1 + 0x40),0);
		  func_ii_20513(&local_1c,uVar1,0);
		  local_8 = local_14;
		  local_10 = local_1c;
		  uVar1 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                    (*(undefined4 *)(param1 + 0x40),0);
		  if (DAT_ram_00a65020 == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Vector3_TypeInfo);
		    DAT_ram_00a65020 = '\x01';
		  }
		  local_38 = **(undefined8 **)(UnityEngine_Vector3_TypeInfo + 0x5c);
		  local_30 = *(undefined4 *)(*(undefined8 **)(UnityEngine_Vector3_TypeInfo + 0x5c) + 1);
		  local_28 = local_38;
		  local_20 = local_30;
		  Com_TheFallenGames_OSA_Core_OSA_object__object___SetNormalizedPosition(uVar1,&local_38,0);
		  uVar1 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                    (*(undefined4 *)(param1 + 0x40),0);
		  local_40 = local_8;
		  local_48 = local_10;
		  uVar1 = System_Collections_Generic_Queue_object___Dequeue(uVar1,&local_48,0.8,0);
		  uVar1 = DG_Tweening_ShortcutExtensions__DOScale
		                    (uVar1,0x1b,
		                     Method_DG_Tweening_TweenSettingsExtensions_SetEase_TweenerCore_Vector3__Vector3__VectorOptions____
		                    );
		  param2_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(param1 + 0x40),0);
		  DG_Tweening_TweenSettingsExtensions__SetDelay_object_
		            (uVar1,param2_00,
		             Method_DG_Tweening_TweenSettingsExtensions_SetLink_TweenerCore_Vector3__Vector3__VectorOptions____
		            );
		  return;
		}
		*/

		}

		// Token: 0x060036F9 RID: 14073 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036F9")]
		[Address(RVA = "0x86E8", Offset = "0x86E8", VA = "0x86E8", Slot = "22")]
		protected override void OnShow(CombatWaitingWindowMono.CombatWaitingWindowArgs args)
		{
		/* --- GHIDRA: OnShow ---
		void Gameplay_Combat_View_CombatWaitingWindowMono__OnShow(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a63b32 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseWindow_CombatWaitingWindowMono_CombatWaitingWindowArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Image___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_Image__TypeInfo);
		    DAT_ram_00a63b32 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Collections_Generic_List_Image__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,Method_System_Collections_Generic_List_Image___ctor__);
		  *(undefined4 *)(param1 + 0x58) = param1_00;
		  UnityEngine_UIElements_BaseUxmlFactory___Il2CppFullySharedGenericType__object___get_uxmlType
		            (param1,
		             Method_UI_Windows_BaseWindow_CombatWaitingWindowMono_CombatWaitingWindowArgs___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x060036FA RID: 14074 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036FA")]
		[Address(RVA = "0x86E9", Offset = "0x86E9", VA = "0x86E9")]
		public CombatWaitingWindowMono()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Combat_View_CombatWaitingWindowMono___ctor
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  UI_Windows_BaseWindowArgs__Dispose(param1,0);
		  *(undefined4 *)(param1 + 0x18) = param3;
		  *(undefined4 *)(param1 + 0x1c) = param2;
		  *(undefined1 *)(param1 + 0xc) = 0;
		  return;
		}
		*/

		}

		// Token: 0x04001E14 RID: 7700
		[Token(Token = "0x4001E14")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Combat/CombatWaitingWindow";

		// Token: 0x04001E15 RID: 7701
		[Token(Token = "0x4001E15")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x04001E16 RID: 7702
		[Token(Token = "0x4001E16")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private TextMeshProUGUI _description;

		// Token: 0x04001E17 RID: 7703
		[Token(Token = "0x4001E17")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private Image _timeOutImage;

		// Token: 0x04001E18 RID: 7704
		[Token(Token = "0x4001E18")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameSpineUiAnimation _bgAnimation;

		// Token: 0x04001E19 RID: 7705
		[Token(Token = "0x4001E19")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private RectTransform _timeoutTransform;

		// Token: 0x04001E1A RID: 7706
		[Token(Token = "0x4001E1A")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Sprite[] _digidsSprites;

		// Token: 0x04001E1C RID: 7708
		[Token(Token = "0x4001E1C")]
		[FieldOffset(Offset = "0x50")]
		private BackTime _bactime;

		// Token: 0x04001E1D RID: 7709
		[Token(Token = "0x4001E1D")]
		[FieldOffset(Offset = "0x54")]
		private Tween _scaleTween;

		// Token: 0x04001E1E RID: 7710
		[Token(Token = "0x4001E1E")]
		[FieldOffset(Offset = "0x58")]
		private List<Image> _pool;

		// Token: 0x04001E1F RID: 7711
		[Token(Token = "0x4001E1F")]
		[FieldOffset(Offset = "0x5C")]
		private int _lastValue;

		// Token: 0x0200091C RID: 2332
		[Token(Token = "0x200091C")]
		public class CombatWaitingWindowArgs : BaseWindowArgs
		{
			// Token: 0x060036FB RID: 14075 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60036FB")]
			[Address(RVA = "0x86EA", Offset = "0x86EA", VA = "0x86EA")]
			public CombatWaitingWindowArgs(BackTime backTimer, IGameAudio gameAudio)
			{
			}

			// Token: 0x04001E20 RID: 7712
			[Token(Token = "0x4001E20")]
			[FieldOffset(Offset = "0x18")]
			public readonly IGameAudio GameAudio;

			// Token: 0x04001E21 RID: 7713
			[Token(Token = "0x4001E21")]
			[FieldOffset(Offset = "0x1C")]
			public readonly BackTime BackTimer;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_BackTimer ---
		void Gameplay_Combat_View_CombatWaitingWindowMono__get_BackTimer
		               (int param1,int param2,undefined4 param3)
		
		{
		  if (param2 != *(int *)(param1 + 0x50)) {
		    *(int *)(param1 + 0x50) = param2;
		    Gameplay_Combat_View_CombatWaitingWindowMono__set_BackTimer(param1,param1);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_BackTimer ---
		void Gameplay_Combat_View_CombatWaitingWindowMono__set_BackTimer(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  float fVar5;
		  double dVar6;
		  int iVar7;
		  undefined4 param1_00;
		  uint uVar8;
		  double param1_01;
		  ulonglong uVar9;
		  float8 local_28;
		  undefined8 local_20;
		  int local_14;
		  undefined1 local_10 [8];
		  undefined8 local_8;
		  
		  if (DAT_ram_00a63b2c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_Image__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_Image__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_Image__get_Current__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Image__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Image__Clear__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Image__GetEnumerator__);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_Image___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a63b2c = '\x01';
		  }
		  local_14 = 0;
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_28,*(undefined4 *)(param1 + 0x58),
		             Method_System_Collections_Generic_List_Image__GetEnumerator__);
		  local_8 = local_20;
		  local_28._0_4_ = 0;
		  local_28._4_4_ = local_10;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar2 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,local_10,
		                       Method_System_Collections_Generic_List_Enumerator_Image__MoveNext__);
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar7 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x82340656;
		    }
		    if (iVar2 == 0) goto code_r0x823406ac;
		    DAT_ram_009d3e38 = 0;
		    uVar3 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x25c,local_8._4_4_,0);
		    if (DAT_ram_009d3e38 == 1) break;
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi
		                (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,UnityEngine_Object_TypeInfo
		                );
		      if (DAT_ram_009d3e38 == 1) break;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_vii(s_struct_Uniforms___color__array<v_ram_00000aff + 0x274,uVar3,0);
		  } while (DAT_ram_009d3e38 != 1);
		  DAT_ram_009d3e38 = 0;
		  uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x82340656:
		  iVar7 = global_1;
		  iVar2 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar7 == iVar2) {
		    piVar4 = (int *)import::env::__cxa_begin_catch(uVar3);
		    iVar2 = *piVar4;
		    DAT_ram_009d3e38 = 0;
		    local_28._0_4_ = iVar2;
		    import::env::invoke_v(0x123);
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar7 != 1) {
		      if (iVar2 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		code_r0x823406ac:
		      DAT_ram_009d3e38 = 0;
		      iVar7 = *(int *)(param1 + 0x58);
		      iVar2 = *(int *)(iVar7 + 0xc);
		      *(undefined4 *)(iVar7 + 0xc) = 0;
		      *(int *)(iVar7 + 0x10) = *(int *)(iVar7 + 0x10) + 1;
		      if (0 < iVar2) {
		        func_ii_2064(*(undefined4 *)(iVar7 + 8),0,iVar2,0);
		      }
		      fVar5 = func_ii_7103(*(undefined4 *)(param1 + 0x50),0);
		      if (DAT_ram_00a6445d == '\0') {
		        Mono_Security_ASN1__get_Item(&System_Math_TypeInfo);
		        DAT_ram_00a6445d = '\x01';
		      }
		      if (*(int *)(System_Math_TypeInfo + 0x74) == 0) {
		        func_ii_306000(System_Math_TypeInfo);
		      }
		      param1_01 = (double)fVar5;
		      dVar6 = unnamed_function_4206(param1_01,&local_28);
		      if (0.0 <= fVar5) {
		        if (dVar6 == 0.5) {
		          dVar6 = (double)CONCAT44(local_28._4_4_,local_28._0_4_);
		          if (ABS(dVar6) < 9.223372036854776e+18) {
		            uVar9 = (ulonglong)dVar6;
		          }
		          else {
		            uVar9 = 0;
		          }
		          if ((uVar9 & 1) != 0) {
		            dVar6 = dVar6 + 1.0;
		          }
		        }
		        else {
		          dVar6 = FLOOR(param1_01 + 0.5);
		        }
		      }
		      else if (dVar6 == -0.5) {
		        dVar6 = (double)CONCAT44(local_28._4_4_,local_28._0_4_);
		        if (ABS(dVar6) < 9.223372036854776e+18) {
		          uVar9 = (ulonglong)dVar6;
		        }
		        else {
		          uVar9 = 0;
		        }
		        if ((uVar9 & 1) != 0) {
		          dVar6 = dVar6 + -1.0;
		        }
		      }
		      else {
		        dVar6 = CEIL(param1_01 + -0.5);
		      }
		      if (ABS(dVar6) < 2147483648.0) {
		        local_14 = (int)dVar6;
		      }
		      else {
		        local_14 = -0x80000000;
		      }
		      iVar7 = func_ii_4443(&local_14,0);
		      local_14 = 0;
		      if (0 < *(int *)(iVar7 + 8)) {
		        do {
		          func_ii_3010(iVar7,local_14,0);
		          uVar3 = *(undefined4 *)(param1 + 0x44);
		          param1_00 = *(undefined4 *)(param1 + 0x3c);
		          iVar2 = *(int *)(param1 + 0x58);
		          if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		            func_ii_306000(UnityEngine_Object_TypeInfo);
		          }
		          uVar3 = func_ii_6805(param1_00,uVar3,Method_UnityEngine_Object_Instantiate_Image___);
		          iVar1 = Method_System_Collections_Generic_List_Image__Add__;
		          *(int *)(iVar2 + 0x10) = *(int *)(iVar2 + 0x10) + 1;
		          uVar8 = *(uint *)(iVar2 + 0xc);
		          if (uVar8 < *(uint *)(*(int *)(iVar2 + 8) + 0xc)) {
		            *(uint *)(iVar2 + 0xc) = uVar8 + 1;
		            *(undefined4 *)(*(int *)(iVar2 + 8) + uVar8 * 4 + 0x10) = uVar3;
		          }
		          else {
		            System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                      (iVar2,uVar3,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		          }
		          local_14 = local_14 + 1;
		        } while (local_14 < *(int *)(iVar7 + 8));
		      }
		      if (DAT_ram_00a63b2d == '\0') {
		        Mono_Security_ASN1__get_Item
		                  (&Gameplay_Combat_View_CombatWaitingWindowMono__ShowCurrentState_d__23_TypeInfo);
		        DAT_ram_00a63b2d = '\x01';
		      }
		      iVar7 = unnamed_function_1417
		                        (
		                        Gameplay_Combat_View_CombatWaitingWindowMono__ShowCurrentState_d__23_TypeInfo
		                        );
		      *(int *)(iVar7 + 0x10) = param1;
		      *(undefined4 *)(iVar7 + 8) = 0;
		      UnityEngine_MonoBehaviour__StartCoroutine(param1,iVar7,0);
		      return;
		    }
		    uVar3 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s___Scripting__UnityEngine__Player_ram_000044a6,&local_28);
		  iVar7 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar7 != 1) {
		    import::env::__resumeException(uVar3);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__cxa_find_matching_catch_3(0);
		  unnamed_function_937();
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

}
