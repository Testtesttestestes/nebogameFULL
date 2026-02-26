using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Gameplay.Sound.Control;
using Il2CppDummyDll;
using Protocol.Combat;
using TMPro;
using UnityEngine;
using Utils;

namespace Gameplay.Combat.View.TurnDisplay
{
	// Token: 0x02000938 RID: 2360
	[Token(Token = "0x2000938")]
	public class TurnStatePointerDefault : MonoBehaviour, ITurnStatePointer
	{
		// Token: 0x1400017A RID: 378
		// (add) Token: 0x060037B8 RID: 14264 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060037B9 RID: 14265 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400017A")]
		public event Action TimeOutEvent
		{
			[Token(Token = "0x60037B8")]
			[Address(RVA = "0x879A", Offset = "0x879A", VA = "0x879A", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60037B9")]
			[Address(RVA = "0x879B", Offset = "0x879B", VA = "0x879B", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400017B RID: 379
		// (add) Token: 0x060037BA RID: 14266 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060037BB RID: 14267 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400017B")]
		public event Action TurnStateChangedEvent
		{
			[Token(Token = "0x60037BA")]
			[Address(RVA = "0x879C", Offset = "0x879C", VA = "0x879C", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60037BB")]
			[Address(RVA = "0x879D", Offset = "0x879D", VA = "0x879D", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000AFD RID: 2813
		// (get) Token: 0x060037BC RID: 14268 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060037BD RID: 14269 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AFD")]
		public IGameAudio GameAudio
		{
			[Token(Token = "0x60037BC")]
			[Address(RVA = "0x879E", Offset = "0x879E", VA = "0x879E", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60037BD")]
			[Address(RVA = "0x879F", Offset = "0x879F", VA = "0x879F", Slot = "10")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000AFE RID: 2814
		// (get) Token: 0x060037BE RID: 14270 RVA: 0x0000B2C8 File Offset: 0x000094C8
		// (set) Token: 0x060037BF RID: 14271 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AFE")]
		public TurnStates TurnState
		{
			[Token(Token = "0x60037BE")]
			[Address(RVA = "0x87A0", Offset = "0x87A0", VA = "0x87A0", Slot = "8")]
			get
			{
				return TurnStates.NoTurn;
			}
			[Token(Token = "0x60037BF")]
			[Address(RVA = "0x87A1", Offset = "0x87A1", VA = "0x87A1")]
			private set
			{
			}
		}

		// Token: 0x060037C0 RID: 14272 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60037C0")]
		[Address(RVA = "0x87A2", Offset = "0x87A2", VA = "0x87A2")]
		private void HandleTurnStateChanged()
		{
		}

		// Token: 0x17000AFF RID: 2815
		// (get) Token: 0x060037C1 RID: 14273 RVA: 0x0000B2E0 File Offset: 0x000094E0
		// (set) Token: 0x060037C2 RID: 14274 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AFF")]
		public float Timeout
		{
			[Token(Token = "0x60037C1")]
			[Address(RVA = "0x87A3", Offset = "0x87A3", VA = "0x87A3")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60037C2")]
			[Address(RVA = "0x87A4", Offset = "0x87A4", VA = "0x87A4")]
			private set
			{
			}
		}

		// Token: 0x060037C3 RID: 14275 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60037C3")]
		[Address(RVA = "0x87A5", Offset = "0x87A5", VA = "0x87A5")]
		private IEnumerator HandleBackTimeCoroutine(TextMeshProUGUI display, BackTime backTime)
		{
		/* --- GHIDRA: HandleBackTimeCoroutine ---
		undefined4
		Gameplay_Combat_View_TurnDisplay_TurnStatePointerDefault__HandleBackTimeCoroutine
		          (int param1,undefined4 *param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  
		  uVar1 = 0;
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x18),0);
		  iVar3 = func_ii_7305(uVar2,0);
		  if (iVar3 == 0) {
		    uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(param1 + 0x1c),0);
		    iVar3 = func_ii_7305(uVar2,0);
		    if (iVar3 == 0) {
		      uVar2 = 0;
		      goto code_r0x80c68451;
		    }
		    iVar3 = 0x14;
		  }
		  else {
		    iVar3 = 0x10;
		  }
		  uVar1 = *(undefined4 *)(param1 + iVar3);
		  uVar2 = 1;
		code_r0x80c68451:
		  *param2 = uVar1;
		  return uVar2;
		}
		*/

			return null;
		}

		// Token: 0x060037C4 RID: 14276 RVA: 0x0000B2F8 File Offset: 0x000094F8
		[Token(Token = "0x60037C4")]
		[Address(RVA = "0x87A6", Offset = "0x87A6", VA = "0x87A6")]
		private bool TryGetTurnPointerElement(out TextMeshProUGUI display)
		{
		/* --- GHIDRA: TryGetTurnPointerElement ---
		void Gameplay_Combat_View_TurnDisplay_TurnStatePointerDefault__TryGetTurnPointerElement
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x18),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,0,0);
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x1c),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,0,0);
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x060037C5 RID: 14277 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60037C5")]
		[Address(RVA = "0x87A7", Offset = "0x87A7", VA = "0x87A7")]
		private void Awake()
		{
		/* --- GHIDRA: Awake ---
		void Gameplay_Combat_View_TurnDisplay_TurnStatePointerDefault__Awake
		               (int param1,int param2,float param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  if (*(int *)(param1 + 0x24) != param2) {
		    *(int *)(param1 + 0x24) = param2;
		    uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(param1 + 0x18),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar1,(uint)((*(uint *)(param1 + 0x24) & 0xfffffffd) == 1),0);
		    uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(param1 + 0x1c),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar1,(uint)(*(int *)(param1 + 0x24) == 4 || *(int *)(param1 + 0x24) == 2),0);
		    iVar2 = *(int *)(param1 + 0x2c);
		    if (iVar2 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                (*(undefined4 *)(iVar2 + 0x20),*(undefined4 *)(iVar2 + 0x14));
		    }
		  }
		  Gameplay_Combat_View_TurnDisplay_TurnStatePointerDefault__get_Timeout(param1,param3,param1);
		  return;
		}
		*/

		}

		// Token: 0x060037C6 RID: 14278 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60037C6")]
		[Address(RVA = "0x87A8", Offset = "0x87A8", VA = "0x87A8", Slot = "11")]
		public void SetTurnState(TurnStates state, float timeout)
		{
		/* --- GHIDRA: SetTurnState ---
		void Gameplay_Combat_View_TurnDisplay_TurnStatePointerDefault__SetTurnState
		               (int param1,undefined4 param2)
		
		{
		  if (*(int *)(param1 + 0x34) != 0) {
		    func_ii_20511(param1,*(int *)(param1 + 0x34),0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060037C7 RID: 14279 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60037C7")]
		[Address(RVA = "0x87A9", Offset = "0x87A9", VA = "0x87A9", Slot = "12")]
		public void Stop()
		{
		/* --- GHIDRA: Stop ---
		void Gameplay_Combat_View_TurnDisplay_TurnStatePointerDefault__Stop(int param1,undefined4 param2)
		
		{
		  *(undefined4 *)(param1 + 0x20) = 0x40a00000;
		  UnityEngine_RectTransform__GetParentSize(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x060037C8 RID: 14280 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60037C8")]
		[Address(RVA = "0x87AA", Offset = "0x87AA", VA = "0x87AA")]
		public TurnStatePointerDefault()
		{
		}

		// Token: 0x04001EC9 RID: 7881
		[Token(Token = "0x4001EC9")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextMeshProUGUI _leftTextField;

		// Token: 0x04001ECA RID: 7882
		[Token(Token = "0x4001ECA")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private TextMeshProUGUI _rightTextField;

		// Token: 0x04001ECB RID: 7883
		[Token(Token = "0x4001ECB")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform _leftTurnView;

		// Token: 0x04001ECC RID: 7884
		[Token(Token = "0x4001ECC")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Transform _rightTurnView;

		// Token: 0x04001ECD RID: 7885
		[Token(Token = "0x4001ECD")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _timeLeftWarningValue;

		// Token: 0x04001ECE RID: 7886
		[Token(Token = "0x4001ECE")]
		[FieldOffset(Offset = "0x24")]
		private TurnStates _turnState;

		// Token: 0x04001ED2 RID: 7890
		[Token(Token = "0x4001ED2")]
		[FieldOffset(Offset = "0x34")]
		private Coroutine _timeoutCoroutine;

		// Token: 0x04001ED3 RID: 7891
		[Token(Token = "0x4001ED3")]
		[FieldOffset(Offset = "0x38")]
		private float _timeout;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_TimeOutEvent ---
		void Gameplay_Combat_View_TurnDisplay_TurnStatePointerDefault__add_TimeOutEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a566d3 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a566d3 = '\x01';
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
		void Gameplay_Combat_View_TurnDisplay_TurnStatePointerDefault__remove_TimeOutEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a566d4 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a566d4 = '\x01';
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
		void Gameplay_Combat_View_TurnDisplay_TurnStatePointerDefault__add_TurnStateChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a566d5 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a566d5 = '\x01';
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
		void Gameplay_Combat_View_TurnDisplay_TurnStatePointerDefault__get_TurnState
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  if (*(int *)(param1 + 0x24) != param2) {
		    *(int *)(param1 + 0x24) = param2;
		    uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(param1 + 0x18),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar1,(uint)((*(uint *)(param1 + 0x24) & 0xfffffffd) == 1),0);
		    uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(param1 + 0x1c),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar1,(uint)(*(int *)(param1 + 0x24) == 4 || *(int *)(param1 + 0x24) == 2),0);
		    iVar2 = *(int *)(param1 + 0x2c);
		    if (iVar2 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                (*(undefined4 *)(iVar2 + 0x20),*(undefined4 *)(iVar2 + 0x14));
		    }
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_TurnState ---
		void Gameplay_Combat_View_TurnDisplay_TurnStatePointerDefault__set_TurnState
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x18),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,(uint)((*(uint *)(param1 + 0x24) & 0xfffffffd) == 1),0);
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x1c),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,(uint)(*(int *)(param1 + 0x24) == 4 || *(int *)(param1 + 0x24) == 2),0);
		  iVar2 = *(int *)(param1 + 0x2c);
		  if (iVar2 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		              (*(undefined4 *)(iVar2 + 0x20),*(undefined4 *)(iVar2 + 0x14));
		  }
		  return;
		}
		*/


		/* --- GHIDRA: get_Timeout ---
		void Gameplay_Combat_View_TurnDisplay_TurnStatePointerDefault__get_Timeout
		               (int param1,float param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 param1_00;
		  double dVar3;
		  undefined4 *puVar4;
		  float fVar5;
		  double param1_01;
		  ulonglong uVar6;
		  float8 local_8;
		  
		  if (DAT_ram_00a566d6 == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_BackTime_TypeInfo);
		    DAT_ram_00a566d6 = '\x01';
		  }
		  *(float *)(param1 + 0x38) = param2;
		  if (*(int *)(param1 + 0x34) != 0) {
		    func_ii_20511(param1,*(int *)(param1 + 0x34),0);
		  }
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x18),0);
		  iVar2 = func_ii_7305(uVar1,0);
		  if (iVar2 == 0) {
		    uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(param1 + 0x1c),0);
		    iVar2 = func_ii_7305(uVar1,0);
		    if (iVar2 == 0) {
		      return;
		    }
		    puVar4 = (undefined4 *)(param1 + 0x14);
		  }
		  else {
		    puVar4 = (undefined4 *)(param1 + 0x10);
		  }
		  fVar5 = *(float *)(param1 + 0x38);
		  uVar1 = *puVar4;
		  if (DAT_ram_00a6445d == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Math_TypeInfo);
		    DAT_ram_00a6445d = '\x01';
		  }
		  if (*(int *)(System_Math_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_Math_TypeInfo);
		  }
		  param1_01 = (double)fVar5;
		  dVar3 = unnamed_function_4206(param1_01,&local_8);
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
		      local_8 = (float8)FLOOR(param1_01 + 0.5);
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
		    local_8 = (float8)CEIL(param1_01 + -0.5);
		  }
		  if (ABS((double)local_8) < 2147483648.0) {
		    iVar2 = (int)(double)local_8;
		  }
		  else {
		    iVar2 = -0x80000000;
		  }
		  param1_00 = unnamed_function_1417(Utils_BackTime_TypeInfo);
		  Core_Extensions_Dict_DictExt__BinarySearch_object__uint_(param1_00,(float)iVar2,0);
		  if (DAT_ram_00a566d7 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Combat_View_TurnDisplay_TurnStatePointerDefault__HandleBackTimeCoroutine_d__25_TypeInfo
		              );
		    DAT_ram_00a566d7 = '\x01';
		  }
		  iVar2 = unnamed_function_1417
		                    (
		                    Gameplay_Combat_View_TurnDisplay_TurnStatePointerDefault__HandleBackTimeCoroutine_d__25_TypeInfo
		                    );
		  *(int *)(iVar2 + 0x18) = param1;
		  *(undefined4 *)(iVar2 + 8) = 0;
		  *(undefined4 *)(iVar2 + 0x14) = uVar1;
		  *(undefined4 *)(iVar2 + 0x10) = param1_00;
		  uVar1 = UnityEngine_MonoBehaviour__StartCoroutine(param1,iVar2,0);
		  *(undefined4 *)(param1 + 0x34) = uVar1;
		  return;
		}
		*/


		/* --- GHIDRA: set_Timeout ---
		int Gameplay_Combat_View_TurnDisplay_TurnStatePointerDefault__set_Timeout
		              (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a566d7 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Combat_View_TurnDisplay_TurnStatePointerDefault__HandleBackTimeCoroutine_d__25_TypeInfo
		              );
		    DAT_ram_00a566d7 = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (
		                    Gameplay_Combat_View_TurnDisplay_TurnStatePointerDefault__HandleBackTimeCoroutine_d__25_TypeInfo
		                    );
		  *(undefined4 *)(iVar1 + 0x18) = param1;
		  *(undefined4 *)(iVar1 + 8) = 0;
		  *(undefined4 *)(iVar1 + 0x14) = param2;
		  *(undefined4 *)(iVar1 + 0x10) = param3;
		  return iVar1;
		}
		*/

}
