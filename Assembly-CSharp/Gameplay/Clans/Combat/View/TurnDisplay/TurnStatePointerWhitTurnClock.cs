using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Gameplay.Combat.View.TurnDisplay;
using Gameplay.Sound.Control;
using Il2CppDummyDll;
using Protocol.Combat;
using UnityEngine;

namespace Gameplay.Clans.Combat.View.TurnDisplay
{
	// Token: 0x02000A96 RID: 2710
	[Token(Token = "0x2000A96")]
	public class TurnStatePointerWhitTurnClock : MonoBehaviour, ITurnStatePointer
	{
		// Token: 0x1400019B RID: 411
		// (add) Token: 0x0600410F RID: 16655 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06004110 RID: 16656 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400019B")]
		public event Action TimeOutEvent
		{
			[Token(Token = "0x600410F")]
			[Address(RVA = "0x8FC6", Offset = "0x8FC6", VA = "0x8FC6", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6004110")]
			[Address(RVA = "0x8FC7", Offset = "0x8FC7", VA = "0x8FC7", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400019C RID: 412
		// (add) Token: 0x06004111 RID: 16657 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06004112 RID: 16658 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400019C")]
		public event Action TurnStateChangedEvent
		{
			[Token(Token = "0x6004111")]
			[Address(RVA = "0x8FC8", Offset = "0x8FC8", VA = "0x8FC8", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6004112")]
			[Address(RVA = "0x8FC9", Offset = "0x8FC9", VA = "0x8FC9", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000CD3 RID: 3283
		// (get) Token: 0x06004113 RID: 16659 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004114 RID: 16660 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CD3")]
		public IGameAudio GameAudio
		{
			[Token(Token = "0x6004113")]
			[Address(RVA = "0x8FCA", Offset = "0x8FCA", VA = "0x8FCA", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004114")]
			[Address(RVA = "0x8FCB", Offset = "0x8FCB", VA = "0x8FCB", Slot = "10")]
			set
			{
			}
		}

		// Token: 0x17000CD4 RID: 3284
		// (get) Token: 0x06004115 RID: 16661 RVA: 0x0000C828 File Offset: 0x0000AA28
		// (set) Token: 0x06004116 RID: 16662 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CD4")]
		public TurnStates TurnState
		{
			[Token(Token = "0x6004115")]
			[Address(RVA = "0x8FCC", Offset = "0x8FCC", VA = "0x8FCC", Slot = "8")]
			get
			{
				return TurnStates.NoTurn;
			}
			[Token(Token = "0x6004116")]
			[Address(RVA = "0x8FCD", Offset = "0x8FCD", VA = "0x8FCD")]
			private set
			{
			}
		}

		// Token: 0x06004117 RID: 16663 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004117")]
		[Address(RVA = "0x8FCE", Offset = "0x8FCE", VA = "0x8FCE")]
		private void HandleTurnStateChanged()
		{
		}

		// Token: 0x17000CD5 RID: 3285
		// (get) Token: 0x06004118 RID: 16664 RVA: 0x0000C840 File Offset: 0x0000AA40
		// (set) Token: 0x06004119 RID: 16665 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CD5")]
		public float Timeout
		{
			[Token(Token = "0x6004118")]
			[Address(RVA = "0x8FCF", Offset = "0x8FCF", VA = "0x8FCF")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6004119")]
			[Address(RVA = "0x8FD0", Offset = "0x8FD0", VA = "0x8FD0")]
			private set
			{
			}
		}

		// Token: 0x0600411A RID: 16666 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600411A")]
		[Address(RVA = "0x8FD1", Offset = "0x8FD1", VA = "0x8FD1")]
		private IEnumerator HandleBackTimeCoroutine(float duration)
		{
		/* --- GHIDRA: HandleBackTimeCoroutine ---
		undefined4
		Gameplay_Clans_Combat_View_TurnDisplay_TurnStatePointerWhitTurnClock__HandleBackTimeCoroutine
		          (int param1,undefined4 *param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  
		  uVar1 = 0;
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x10),0);
		  iVar3 = func_ii_7305(uVar2,0);
		  if (iVar3 == 0) {
		    uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(param1 + 0x14),0);
		    iVar3 = func_ii_7305(uVar2,0);
		    if (iVar3 == 0) {
		      uVar2 = 0;
		      goto code_r0x80dd79b4;
		    }
		    iVar3 = 0x14;
		  }
		  else {
		    iVar3 = 0x10;
		  }
		  uVar1 = *(undefined4 *)(param1 + iVar3);
		  uVar2 = 1;
		code_r0x80dd79b4:
		  *param2 = uVar1;
		  return uVar2;
		}
		*/

			return null;
		}

		// Token: 0x0600411B RID: 16667 RVA: 0x0000C858 File Offset: 0x0000AA58
		[Token(Token = "0x600411B")]
		[Address(RVA = "0x8FD2", Offset = "0x8FD2", VA = "0x8FD2")]
		private bool TryGetTurnPointerElement(out TurnClock clock)
		{
		/* --- GHIDRA: TryGetTurnPointerElement ---
		void Gameplay_Clans_Combat_View_TurnDisplay_TurnStatePointerWhitTurnClock__TryGetTurnPointerElement
		               (undefined4 param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  param1_00 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                        (param1,0);
		  func_ii_8007(param1_00,0,0);
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x0600411C RID: 16668 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600411C")]
		[Address(RVA = "0x8FD3", Offset = "0x8FD3", VA = "0x8FD3")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_Clans_Combat_View_TurnDisplay_TurnStatePointerWhitTurnClock__OnDestroy
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x10),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,0,0);
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x14),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,0,0);
		  return;
		}
		*/

		}

		// Token: 0x0600411D RID: 16669 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600411D")]
		[Address(RVA = "0x8FD4", Offset = "0x8FD4", VA = "0x8FD4")]
		private void Awake()
		{
		/* --- GHIDRA: Awake ---
		void Gameplay_Clans_Combat_View_TurnDisplay_TurnStatePointerWhitTurnClock__Awake
		               (undefined4 param1,undefined4 param2,float param3,undefined4 param4)
		
		{
		  Gameplay_Clans_Combat_View_TurnDisplay_TurnStatePointerWhitTurnClock__get_TurnState
		            (param1,param2,param1);
		  Gameplay_Clans_Combat_View_TurnDisplay_TurnStatePointerWhitTurnClock__get_Timeout
		            (param1,param3,param1);
		  return;
		}
		*/

		}

		// Token: 0x0600411E RID: 16670 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600411E")]
		[Address(RVA = "0x8FD5", Offset = "0x8FD5", VA = "0x8FD5", Slot = "11")]
		public void SetTurnState(TurnStates state, float timeout)
		{
		/* --- GHIDRA: SetTurnState ---
		void Gameplay_Clans_Combat_View_TurnDisplay_TurnStatePointerWhitTurnClock__SetTurnState
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a5777c == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a5777c = '\x01';
		  }
		  if (*(int *)(param1 + 0x24) != 0) {
		    func_ii_20511(param1,*(int *)(param1 + 0x24),0);
		  }
		  uVar2 = *(undefined4 *)(param1 + 0x10);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar1 = UnityEngine_TextCore_Text_TextElement__get_textAsset(uVar2,0,0);
		  if (iVar1 != 0) {
		    UnityEngine_Object__op_Implicit(*(undefined4 *)(param1 + 0x10),0,0);
		  }
		  uVar2 = *(undefined4 *)(param1 + 0x14);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar1 = UnityEngine_TextCore_Text_TextElement__get_textAsset(uVar2,0,0);
		  if (iVar1 != 0) {
		    UnityEngine_Object__op_Implicit(*(undefined4 *)(param1 + 0x14),0,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600411F RID: 16671 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600411F")]
		[Address(RVA = "0x8FD6", Offset = "0x8FD6", VA = "0x8FD6", Slot = "12")]
		public void Stop()
		{
		}

		// Token: 0x06004120 RID: 16672 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004120")]
		[Address(RVA = "0x8FD7", Offset = "0x8FD7", VA = "0x8FD7")]
		public TurnStatePointerWhitTurnClock()
		{
		}

		// Token: 0x0400241E RID: 9246
		[Token(Token = "0x400241E")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TurnClock _leftTurnView;

		// Token: 0x0400241F RID: 9247
		[Token(Token = "0x400241F")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private TurnClock _rightTurnView;

		// Token: 0x04002420 RID: 9248
		[Token(Token = "0x4002420")]
		[FieldOffset(Offset = "0x18")]
		private TurnStates _turnState;

		// Token: 0x04002423 RID: 9251
		[Token(Token = "0x4002423")]
		[FieldOffset(Offset = "0x24")]
		private Coroutine _timeoutCoroutine;

		// Token: 0x04002424 RID: 9252
		[Token(Token = "0x4002424")]
		[FieldOffset(Offset = "0x28")]
		private float _timeout;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_TimeOutEvent ---
		void Gameplay_Clans_Combat_View_TurnDisplay_TurnStatePointerWhitTurnClock__add_TimeOutEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a57778 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a57778 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x1c);
		  while ((param1_01 = (int *)func_ii_7048(param1_00,param2,0), param1_01 == (int *)0x0 ||
		         (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x1c,param1_01,param1_00);
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
		void Gameplay_Clans_Combat_View_TurnDisplay_TurnStatePointerWhitTurnClock__remove_TimeOutEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a57779 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a57779 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x20);
		  while ((param1_01 = (int *)UnityEngine_UI_Image__set_sprite(param1_00,param2,0),
		         param1_01 == (int *)0x0 || (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x20,param1_01,param1_00);
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
		void Gameplay_Clans_Combat_View_TurnDisplay_TurnStatePointerWhitTurnClock__add_TurnStateChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a5777a == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a5777a = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x20);
		  while ((param1_01 = (int *)func_ii_7048(param1_00,param2,0), param1_01 == (int *)0x0 ||
		         (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x20,param1_01,param1_00);
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


		/* --- GHIDRA: remove_TurnStateChangedEvent ---
		undefined4
		Gameplay_Clans_Combat_View_TurnDisplay_TurnStatePointerWhitTurnClock__remove_TurnStateChangedEvent
		          (int param1,undefined4 param2)
		
		{
		  return *(undefined4 *)(*(int *)(param1 + 0x10) + 0x68);
		}
		*/


		/* --- GHIDRA: get_GameAudio ---
		void Gameplay_Clans_Combat_View_TurnDisplay_TurnStatePointerWhitTurnClock__get_GameAudio
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  *(undefined4 *)(*(int *)(param1 + 0x10) + 0x68) = param2;
		  *(undefined4 *)(*(int *)(param1 + 0x14) + 0x68) = param2;
		  return;
		}
		*/


		/* --- GHIDRA: get_TurnState ---
		void Gameplay_Clans_Combat_View_TurnDisplay_TurnStatePointerWhitTurnClock__get_TurnState
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  if (*(int *)(param1 + 0x18) != param2) {
		    *(int *)(param1 + 0x18) = param2;
		    uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(param1 + 0x10),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar1,(uint)((*(uint *)(param1 + 0x18) & 0xfffffffd) == 1),0);
		    uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(param1 + 0x14),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar1,(uint)(*(int *)(param1 + 0x18) == 4 || *(int *)(param1 + 0x18) == 2),0);
		    uVar1 = *(undefined4 *)(param1 + 0x18);
		    *(undefined4 *)(*(int *)(param1 + 0x10) + 0x70) = uVar1;
		    *(undefined4 *)(*(int *)(param1 + 0x14) + 0x70) = uVar1;
		    iVar2 = *(int *)(param1 + 0x20);
		    if (iVar2 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                (*(undefined4 *)(iVar2 + 0x20),*(undefined4 *)(iVar2 + 0x14));
		    }
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_TurnState ---
		void Gameplay_Clans_Combat_View_TurnDisplay_TurnStatePointerWhitTurnClock__set_TurnState
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x10),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,(uint)((*(uint *)(param1 + 0x18) & 0xfffffffd) == 1),0);
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x14),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,(uint)(*(int *)(param1 + 0x18) == 4 || *(int *)(param1 + 0x18) == 2),0);
		  uVar1 = *(undefined4 *)(param1 + 0x18);
		  *(undefined4 *)(*(int *)(param1 + 0x10) + 0x70) = uVar1;
		  *(undefined4 *)(*(int *)(param1 + 0x14) + 0x70) = uVar1;
		  iVar2 = *(int *)(param1 + 0x20);
		  if (iVar2 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		              (*(undefined4 *)(iVar2 + 0x20),*(undefined4 *)(iVar2 + 0x14));
		  }
		  return;
		}
		*/


		/* --- GHIDRA: get_Timeout ---
		void Gameplay_Clans_Combat_View_TurnDisplay_TurnStatePointerWhitTurnClock__get_Timeout
		               (int param1,float param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  double dVar3;
		  undefined4 *puVar4;
		  float fVar5;
		  double param1_00;
		  ulonglong uVar6;
		  float8 local_8;
		  
		  *(float *)(param1 + 0x28) = param2;
		  if (*(int *)(param1 + 0x24) != 0) {
		    func_ii_20511(param1,*(int *)(param1 + 0x24),0);
		  }
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x10),0);
		  iVar2 = func_ii_7305(uVar1,0);
		  if (iVar2 == 0) {
		    uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(param1 + 0x14),0);
		    iVar2 = func_ii_7305(uVar1,0);
		    if (iVar2 == 0) {
		      return;
		    }
		    puVar4 = (undefined4 *)(param1 + 0x14);
		  }
		  else {
		    puVar4 = (undefined4 *)(param1 + 0x10);
		  }
		  fVar5 = *(float *)(param1 + 0x28);
		  uVar1 = *puVar4;
		  if (DAT_ram_00a6445d == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Math_TypeInfo);
		    DAT_ram_00a6445d = '\x01';
		  }
		  if (*(int *)(System_Math_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_Math_TypeInfo);
		  }
		  param1_00 = (double)fVar5;
		  dVar3 = unnamed_function_4206(param1_00,&local_8);
		  if (0.0 <= fVar5) {
		    if (dVar3 == 0.5) {
		      if (ABS((double)local_8) < 9.223372036854776e+18) {
		        uVar6 = (ulonglong)(double)local_8;
		      }
		      else {
		        uVar6 = 0;
		      }
		      if ((uVar6 & 1) != 0) {
		        local_8 = (float8)((double)local_8 + 1.0);
		      }
		    }
		    else {
		      local_8 = (float8)FLOOR(param1_00 + 0.5);
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
		      local_8 = (float8)((double)local_8 + -1.0);
		    }
		  }
		  else {
		    local_8 = (float8)CEIL(param1_00 + -0.5);
		  }
		  if (ABS((double)local_8) < 2147483648.0) {
		    iVar2 = (int)(double)local_8;
		  }
		  else {
		    iVar2 = -0x80000000;
		  }
		  Gameplay_Combat_View_TurnDisplay_TurnClock__set_TurnState(uVar1,iVar2,0);
		  *(undefined1 *)(*(int *)(param1 + 0x10) + 0x6c) = 1;
		  *(undefined1 *)(*(int *)(param1 + 0x14) + 0x6c) = 1;
		  uVar1 = *(undefined4 *)(param1 + 0x28);
		  if (DAT_ram_00a5777b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Clans_Combat_View_TurnDisplay_TurnStatePointerWhitTurnClock__HandleBackTimeCoroutine_d__21_TypeInfo
		              );
		    DAT_ram_00a5777b = '\x01';
		  }
		  iVar2 = unnamed_function_1417
		                    (
		                    Gameplay_Clans_Combat_View_TurnDisplay_TurnStatePointerWhitTurnClock__HandleBackTimeCoroutine_d__21_TypeInfo
		                    );
		  *(int *)(iVar2 + 0x14) = param1;
		  *(undefined4 *)(iVar2 + 8) = 0;
		  *(undefined4 *)(iVar2 + 0x10) = uVar1;
		  uVar1 = UnityEngine_MonoBehaviour__StartCoroutine(param1,iVar2,0);
		  *(undefined4 *)(param1 + 0x24) = uVar1;
		  return;
		}
		*/


		/* --- GHIDRA: set_Timeout ---
		int Gameplay_Clans_Combat_View_TurnDisplay_TurnStatePointerWhitTurnClock__set_Timeout
		              (undefined4 param1,float param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a5777b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Clans_Combat_View_TurnDisplay_TurnStatePointerWhitTurnClock__HandleBackTimeCoroutine_d__21_TypeInfo
		              );
		    DAT_ram_00a5777b = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (
		                    Gameplay_Clans_Combat_View_TurnDisplay_TurnStatePointerWhitTurnClock__HandleBackTimeCoroutine_d__21_TypeInfo
		                    );
		  *(undefined4 *)(iVar1 + 0x14) = param1;
		  *(undefined4 *)(iVar1 + 8) = 0;
		  *(float *)(iVar1 + 0x10) = param2;
		  return iVar1;
		}
		*/

}
