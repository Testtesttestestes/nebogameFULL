using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CloudsFly;
using CloudsFly.Movement;
using Gameplay.Isles.Base;
using Gameplay.World.Controller;
using Gameplay.World.Model.View.IslandEngineActions;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.World.View
{
	// Token: 0x02000358 RID: 856
	[Token(Token = "0x2000358")]
	public class WorldView : MonoBehaviour
	{
		// Token: 0x1700030D RID: 781
		// (get) Token: 0x06001385 RID: 4997 RVA: 0x00004B90 File Offset: 0x00002D90
		[Token(Token = "0x1700030D")]
		public WorldLevel CurrentWorldLevel
		{
			[Token(Token = "0x6001385")]
			[Address(RVA = "0x6575", Offset = "0x6575", VA = "0x6575")]
			get
			{
				return WorldLevel.Unknown;
			}
		}

		// Token: 0x1700030E RID: 782
		// (get) Token: 0x06001386 RID: 4998 RVA: 0x00004BA8 File Offset: 0x00002DA8
		[Token(Token = "0x1700030E")]
		public bool AnyTweenHappened
		{
			[Token(Token = "0x6001386")]
			[Address(RVA = "0x6576", Offset = "0x6576", VA = "0x6576")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700030F RID: 783
		// (get) Token: 0x06001387 RID: 4999 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700030F")]
		public CloudObjectsEngineController CloudObjectsEngineController
		{
			[Token(Token = "0x6001387")]
			[Address(RVA = "0x6577", Offset = "0x6577", VA = "0x6577")]
			get
			{
				return null;
			}
		}

		// Token: 0x14000107 RID: 263
		// (add) Token: 0x06001388 RID: 5000 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06001389 RID: 5001 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000107")]
		public event Action<WorldMovementTypes> MovStartEvent
		{
			[Token(Token = "0x6001388")]
			[Address(RVA = "0x6578", Offset = "0x6578", VA = "0x6578")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6001389")]
			[Address(RVA = "0x6579", Offset = "0x6579", VA = "0x6579")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000108 RID: 264
		// (add) Token: 0x0600138A RID: 5002 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600138B RID: 5003 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000108")]
		public event Action<WorldMovementTypes> MovCompleteEvent
		{
			[Token(Token = "0x600138A")]
			[Address(RVA = "0x657A", Offset = "0x657A", VA = "0x657A")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600138B")]
			[Address(RVA = "0x657B", Offset = "0x657B", VA = "0x657B")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000109 RID: 265
		// (add) Token: 0x0600138C RID: 5004 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600138D RID: 5005 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000109")]
		public event Action<WorldLevel, WorldLevel> WorldLevelChangedEvent
		{
			[Token(Token = "0x600138C")]
			[Address(RVA = "0x657C", Offset = "0x657C", VA = "0x657C")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600138D")]
			[Address(RVA = "0x657D", Offset = "0x657D", VA = "0x657D")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x0600138E RID: 5006 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600138E")]
		[Address(RVA = "0x657E", Offset = "0x657E", VA = "0x657E")]
		private void Awake()
		{
		/* --- GHIDRA: Awake ---
		void Gameplay_World_View_WorldView__Awake(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  int *piVar3;
		  int iVar4;
		  int iVar5;
		  
		  if (DAT_ram_00a58c60 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UI_Windows_PopupController_StateChanged_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_World_View_WorldView_OnChangeWindows__);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_World_View_WorldView_OnEngineInitialized__);
		    DAT_ram_00a58c60 = '\x01';
		  }
		  uVar1 = System_Uri___ctor(0);
		  uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar1,0);
		  uVar2 = unnamed_function_1417(UI_Windows_PopupController_StateChanged_TypeInfo);
		  UI_Windows_PopupController___ctor
		            (uVar2,param1,Method_Gameplay_World_View_WorldView_OnChangeWindows__,0);
		  UI_Windows_PopupController__add_OnChangeStateEvent(uVar1,uVar2,0);
		  uVar2 = *(undefined4 *)(param1 + 0x10);
		  uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar1,param1,Method_Gameplay_World_View_WorldView_OnEngineInitialized__,0);
		  CloudsFly_CloudObjectsEngineController__add_OnInitialized(uVar2,uVar1,0);
		  piVar3 = *(int **)(param1 + 0x34);
		  if (piVar3 != (int *)0x0) {
		    (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x130) * 4))
		              (piVar3,*(undefined4 *)(*piVar3 + 0x134));
		  }
		  *(undefined4 *)(param1 + 0x34) = 0;
		  if (DAT_ram_00a58c62 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Queue_BaseIsleEngineAction__Dequeue__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Queue_BaseIsleEngineAction__get_Count__);
		    DAT_ram_00a58c62 = '\x01';
		  }
		  piVar3 = *(int **)(param1 + 0x3c);
		  if (piVar3 != (int *)0x0) {
		    (**(code **)((ulonglong)*(uint *)(*piVar3 + 0xf0) * 4))(piVar3,*(undefined4 *)(*piVar3 + 0xf4));
		    iVar4 = **(int **)(param1 + 0x3c);
		    (**(code **)((ulonglong)*(uint *)(iVar4 + 0xf8) * 4))
		              (*(int **)(param1 + 0x3c),*(undefined4 *)(iVar4 + 0xfc));
		    *(undefined4 *)(param1 + 0x3c) = 0;
		  }
		  iVar4 = *(int *)(param1 + 0x38);
		  iVar5 = *(int *)(iVar4 + 0x14);
		  while (0 < iVar5) {
		    piVar3 = (int *)func_ii_7387(iVar4,
		                                 Method_System_Collections_Generic_Queue_BaseIsleEngineAction__Dequeue__
		                                );
		    (**(code **)((ulonglong)*(uint *)(*piVar3 + 0xf8) * 4))(piVar3,*(undefined4 *)(*piVar3 + 0xfc));
		    iVar4 = *(int *)(param1 + 0x38);
		    iVar5 = *(int *)(iVar4 + 0x14);
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600138F RID: 5007 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600138F")]
		[Address(RVA = "0x657F", Offset = "0x657F", VA = "0x657F")]
		private void OnDestroy()
		{
		}

		// Token: 0x06001390 RID: 5008 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001390")]
		[Address(RVA = "0x6580", Offset = "0x6580", VA = "0x6580")]
		public void StopAnyMovement()
		{
		/* --- GHIDRA: StopAnyMovement ---
		void Gameplay_World_View_WorldView__StopAnyMovement(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  int *piVar5;
		  int iVar6;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a58c61 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_CloudsFly_CloudObjectsEngineController_GetEngine_AxisIsleWorldObjectEngine___
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_CloudsFly_CloudObjectsEngineController_GetEngine_ClanIsleWorldObjectEngine___
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_CloudsFly_CloudObjectsEngineController_GetEngine_UserIsleWorldObjectEngine___
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_World_Controller_WorldViewMediator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_World_View_WorldView_OnEngineInitialized__);
		    DAT_ram_00a58c61 = '\x01';
		  }
		  uVar4 = *(undefined4 *)(param1 + 0x10);
		  uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,param1,Method_Gameplay_World_View_WorldView_OnEngineInitialized__,0);
		  CloudsFly_CloudObjectsEngineController__add_OnInitialized(uVar4,uVar2,0);
		  uVar2 = HuaweiMobileServices_CloudDB_CloudDBZone__SubscribeSnapshot___Il2CppFullySharedGenericType_
		                    (*(undefined4 *)(param1 + 0x10),
		                     Method_CloudsFly_CloudObjectsEngineController_GetEngine_UserIsleWorldObjectEngine___
		                    );
		  *(undefined4 *)(param1 + 0x1c) = uVar2;
		  uVar2 = HuaweiMobileServices_CloudDB_CloudDBZone__SubscribeSnapshot___Il2CppFullySharedGenericType_
		                    (*(undefined4 *)(param1 + 0x10),
		                     Method_CloudsFly_CloudObjectsEngineController_GetEngine_ClanIsleWorldObjectEngine___
		                    );
		  *(undefined4 *)(param1 + 0x20) = uVar2;
		  uVar2 = HuaweiMobileServices_CloudDB_CloudDBZone__SubscribeSnapshot___Il2CppFullySharedGenericType_
		                    (*(undefined4 *)(param1 + 0x10),
		                     Method_CloudsFly_CloudObjectsEngineController_GetEngine_AxisIsleWorldObjectEngine___
		                    );
		  *(undefined4 *)(param1 + 0x24) = uVar2;
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x110);
		        goto code_r0x80f90b0b;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,10);
		code_r0x80f90b0b:
		  iVar6 = (**(code **)((ulonglong)*puVar3 * 4))(piVar5,puVar3[1]);
		  uVar2 = *(undefined4 *)(iVar6 + 0x10);
		  uVar4 = *(undefined4 *)(iVar6 + 0xc);
		  param2_00 = *(undefined4 *)(iVar6 + 0x14);
		  piVar5 = (int *)unnamed_function_1417(Gameplay_World_Controller_WorldViewMediator_TypeInfo);
		  Gameplay_World_Controller_WorldUserLevelViewMediator___c__DisplayClass3_0___CurrentIsleChangedEventHandler_b__1
		            (piVar5,param2_00,uVar4,uVar2,0);
		  *(int **)(param1 + 0x34) = piVar5;
		  (**(code **)((ulonglong)*(uint *)(*piVar5 + 0x160) * 4))
		            (piVar5,param1,*(undefined4 *)(*piVar5 + 0x164));
		  Gameplay_World_View_WorldView__InvokeIslandEngineAction(param1,piVar5);
		  return;
		}
		*/

		}

		// Token: 0x06001391 RID: 5009 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001391")]
		[Address(RVA = "0x6581", Offset = "0x6581", VA = "0x6581")]
		private void OnEngineInitialized()
		{
		/* --- GHIDRA: OnEngineInitialized ---
		void Gameplay_World_View_WorldView__OnEngineInitialized(int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  int iVar2;
		  
		  iVar1 = 0;
		  UnityEngine_Object__op_Implicit(*(undefined4 *)(param1 + 0x10),(uint)(param2 == 0),0);
		  iVar2 = *(int *)(param1 + 0x14);
		  if (0 < *(int *)(iVar2 + 0xc)) {
		    do {
		      param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                            (*(undefined4 *)(iVar2 + iVar1 * 4 + 0x10),0);
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (param1_00,(uint)(param2 == 0),0);
		      iVar1 = iVar1 + 1;
		    } while (iVar1 < *(int *)(iVar2 + 0xc));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001392 RID: 5010 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001392")]
		[Address(RVA = "0x6582", Offset = "0x6582", VA = "0x6582")]
		private void OnChangeWindows(int visibleFullscreenWndCount)
		{
		/* --- GHIDRA: OnChangeWindows ---
		void Gameplay_World_View_WorldView__OnChangeWindows(int param1,undefined4 param2)
		
		{
		  int *piVar1;
		  int iVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a58c62 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Queue_BaseIsleEngineAction__Dequeue__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Queue_BaseIsleEngineAction__get_Count__);
		    DAT_ram_00a58c62 = '\x01';
		  }
		  piVar1 = *(int **)(param1 + 0x3c);
		  if (piVar1 != (int *)0x0) {
		    (**(code **)((ulonglong)*(uint *)(*piVar1 + 0xf0) * 4))(piVar1,*(undefined4 *)(*piVar1 + 0xf4));
		    iVar2 = **(int **)(param1 + 0x3c);
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xf8) * 4))
		              (*(int **)(param1 + 0x3c),*(undefined4 *)(iVar2 + 0xfc));
		    *(undefined4 *)(param1 + 0x3c) = 0;
		  }
		  iVar2 = *(int *)(param1 + 0x38);
		  iVar3 = *(int *)(iVar2 + 0x14);
		  while (0 < iVar3) {
		    piVar1 = (int *)func_ii_7387(iVar2,
		                                 Method_System_Collections_Generic_Queue_BaseIsleEngineAction__Dequeue__
		                                );
		    (**(code **)((ulonglong)*(uint *)(*piVar1 + 0xf8) * 4))(piVar1,*(undefined4 *)(*piVar1 + 0xfc));
		    iVar2 = *(int *)(param1 + 0x38);
		    iVar3 = *(int *)(iVar2 + 0x14);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001393 RID: 5011 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001393")]
		[Address(RVA = "0x6583", Offset = "0x6583", VA = "0x6583")]
		private void CancelCurrentQueue()
		{
		/* --- GHIDRA: CancelCurrentQueue ---
		void Gameplay_World_View_WorldView__CancelCurrentQueue
		               (int param1,int param2,int param3,undefined4 param4)
		
		{
		  undefined4 param1_00;
		  int *piVar1;
		  int iVar2;
		  int iVar3;
		  undefined4 *puVar4;
		  undefined4 uVar5;
		  undefined4 uVar6;
		  undefined4 uVar7;
		  
		  if (DAT_ram_00a58c63 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_WorldLevel__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_World_Model_View_IslandEngineActions_MoveToLevelEngineAction_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_World_View_WorldView_LevelChangedCallback__);
		    DAT_ram_00a58c63 = '\x01';
		  }
		  if (DAT_ram_00a58c62 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Queue_BaseIsleEngineAction__Dequeue__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Queue_BaseIsleEngineAction__get_Count__);
		    DAT_ram_00a58c62 = '\x01';
		  }
		  piVar1 = *(int **)(param1 + 0x3c);
		  if (piVar1 != (int *)0x0) {
		    (**(code **)((ulonglong)*(uint *)(*piVar1 + 0xf0) * 4))(piVar1,*(undefined4 *)(*piVar1 + 0xf4));
		    iVar2 = **(int **)(param1 + 0x3c);
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xf8) * 4))
		              (*(int **)(param1 + 0x3c),*(undefined4 *)(iVar2 + 0xfc));
		    *(undefined4 *)(param1 + 0x3c) = 0;
		  }
		  iVar2 = *(int *)(param1 + 0x38);
		  iVar3 = *(int *)(iVar2 + 0x14);
		  while (0 < iVar3) {
		    piVar1 = (int *)func_ii_7387(iVar2,
		                                 Method_System_Collections_Generic_Queue_BaseIsleEngineAction__Dequeue__
		                                );
		    (**(code **)((ulonglong)*(uint *)(*piVar1 + 0xf8) * 4))(piVar1,*(undefined4 *)(*piVar1 + 0xfc));
		    iVar2 = *(int *)(param1 + 0x38);
		    iVar3 = *(int *)(iVar2 + 0x14);
		  }
		  if (param3 != 0) {
		    uVar7 = *(undefined4 *)(param1 + 0x18);
		    *(int *)(param1 + 0x18) = param2;
		    iVar2 = *(int *)(param1 + 0x30);
		    if (iVar2 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                (*(undefined4 *)(iVar2 + 0x20),uVar7,param2,*(undefined4 *)(iVar2 + 0x14));
		    }
		    return;
		  }
		  iVar2 = *(int *)(param1 + 0x28);
		  if (iVar2 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		              (*(undefined4 *)(iVar2 + 0x20),6,*(undefined4 *)(iVar2 + 0x14));
		  }
		  uVar7 = 0;
		  if (param2 == -1) {
		    puVar4 = (undefined4 *)(param1 + 0x24);
		  }
		  else {
		    if (param2 == 0) goto code_r0x80f90d4c;
		    if (param2 == 1) {
		      puVar4 = (undefined4 *)(param1 + 0x1c);
		    }
		    else {
		      if (param2 != 2) goto code_r0x80f90d4c;
		      puVar4 = (undefined4 *)(param1 + 0x20);
		    }
		  }
		  uVar7 = *puVar4;
		code_r0x80f90d4c:
		  uVar5 = *(undefined4 *)(param1 + 0x18);
		  param1_00 = unnamed_function_1417(System_Action_WorldLevel__TypeInfo);
		  System_Action_int___Invoke
		            (param1_00,param1,Method_Gameplay_World_View_WorldView_LevelChangedCallback__,0);
		  uVar6 = *(undefined4 *)(*(int *)(param1 + 0x10) + 0x14);
		  iVar2 = unnamed_function_1417
		                    (Gameplay_World_Model_View_IslandEngineActions_MoveToLevelEngineAction_TypeInfo)
		  ;
		  *(undefined4 *)(iVar2 + 0x18) = uVar6;
		  *(undefined4 *)(iVar2 + 0x14) = param1_00;
		  *(int *)(iVar2 + 0x10) = param2;
		  *(undefined4 *)(iVar2 + 0xc) = uVar5;
		  *(undefined4 *)(iVar2 + 8) = uVar7;
		  if (DAT_ram_00a58c66 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Queue_BaseIsleEngineAction__Enqueue__);
		    DAT_ram_00a58c66 = '\x01';
		  }
		  System_Collections_Generic_Dictionary_Int32Enum__object___TryGetValue
		            (*(undefined4 *)(param1 + 0x38),iVar2,
		             Method_System_Collections_Generic_Queue_BaseIsleEngineAction__Enqueue__);
		  Gameplay_World_View_WorldView__InvokeIslandEngineAction(param1,iVar2);
		  return;
		}
		*/

		}

		// Token: 0x06001394 RID: 5012 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001394")]
		[Address(RVA = "0x6584", Offset = "0x6584", VA = "0x6584")]
		public void MoveToLevel(WorldLevel targetLevel, bool immediate)
		{
		/* --- GHIDRA: MoveToLevel ---
		void Gameplay_World_View_WorldView__MoveToLevel(int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  uVar1 = *(undefined4 *)(param1 + 0x18);
		  *(undefined4 *)(param1 + 0x18) = param2;
		  iVar2 = *(int *)(param1 + 0x30);
		  if (iVar2 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		              (*(undefined4 *)(iVar2 + 0x20),uVar1,param2,*(undefined4 *)(iVar2 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001395 RID: 5013 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001395")]
		[Address(RVA = "0x6585", Offset = "0x6585", VA = "0x6585")]
		private void LevelChangedCallback(WorldLevel level)
		{
		/* --- GHIDRA: LevelChangedCallback ---
		undefined4
		Gameplay_World_View_WorldView__LevelChangedCallback(int param1,int param2,undefined4 param3)
		
		{
		  undefined4 *puVar1;
		  
		  if (param2 == -1) {
		    puVar1 = (undefined4 *)(param1 + 0x24);
		  }
		  else {
		    if (param2 == 0) {
		      return 0;
		    }
		    if (param2 == 1) {
		      puVar1 = (undefined4 *)(param1 + 0x1c);
		    }
		    else {
		      if (param2 != 2) {
		        return 0;
		      }
		      puVar1 = (undefined4 *)(param1 + 0x20);
		    }
		  }
		  return *puVar1;
		}
		*/

		}

		// Token: 0x06001396 RID: 5014 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001396")]
		[Address(RVA = "0x6586", Offset = "0x6586", VA = "0x6586")]
		private IIsleWorldObjectEngine GetIsleEngineByLevel(WorldLevel worldLevel)
		{
		/* --- GHIDRA: GetIsleEngineByLevel ---
		void Gameplay_World_View_WorldView__GetIsleEngineByLevel
		               (int param1,int param2,int *param3,undefined4 param4,undefined4 param5,int param6,
		               undefined4 param7,undefined4 param8)
		
		{
		  undefined4 in_register_20000014;
		  undefined8 uVar1;
		  longlong lVar2;
		  int iVar3;
		  uint *puVar4;
		  undefined4 uVar5;
		  undefined4 uVar6;
		  undefined4 uVar7;
		  undefined4 uVar8;
		  int *piVar9;
		  int iVar10;
		  undefined4 *puVar11;
		  undefined4 uVar12;
		  float fVar13;
		  uint uVar14;
		  int iVar15;
		  uint uVar16;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a58c64 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_World_View_CallbackIslandEngineAction_TypeInfo);
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_World_Model_View_IslandEngineActions_DelayIsleEngineAction_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ulong__BaseIsleWorldObject__ContainsKey__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_ulong__BaseIsleWorldObject__get_Count__
		              );
		    Mono_Security_ASN1__get_Item(&CloudsFly_IIsleWorldObjectEngine_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Isles_Base_IIsle_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_World_Model_View_IslandEngineActions_MoveToIslandEngineAction_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_ulong___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Nullable_ulong__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_World_Model_View_IslandEngineActions_SetIsleEngineAction_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_World_View_WorldView___c__DisplayClass33_0__MoveToIsle_b__0__);
		    Mono_Security_ASN1__get_Item(&Gameplay_World_View_WorldView___c__DisplayClass33_0_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_World_View_WorldView_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_17940);
		    DAT_ram_00a58c64 = '\x01';
		  }
		  iVar3 = unnamed_function_1417(Gameplay_World_View_WorldView___c__DisplayClass33_0_TypeInfo);
		  *(undefined4 *)(iVar3 + 0x1c) = param7;
		  *(undefined4 *)(iVar3 + 0x18) = param5;
		  *(int *)(iVar3 + 0x10) = param1;
		  *(undefined4 *)(iVar3 + 0xc) = param4;
		  *(int **)(iVar3 + 8) = param3;
		  iVar15 = *param3;
		  if (*(ushort *)(iVar15 + 0xb6) != 0) {
		    uVar14 = 0;
		    do {
		      if (Gameplay_Isles_Base_IIsle_TypeInfo == *(int *)(*(int *)(iVar15 + 0x58) + uVar14 * 8)) {
		        puVar4 = (uint *)(iVar15 + *(int *)(*(int *)(iVar15 + 0x58) + uVar14 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80f91002;
		      }
		      uVar14 = uVar14 + 1;
		    } while (*(ushort *)(iVar15 + 0xb6) != uVar14);
		  }
		  puVar4 = (uint *)func_ii_1080(param3,Gameplay_Isles_Base_IIsle_TypeInfo,0);
		code_r0x80f91002:
		  uVar1 = CONCAT44(in_register_20000014,puVar4[1]);
		  local_10 = (**(code **)((ulonglong)*puVar4 * 4))(param3,uVar1);
		  uVar14 = (uint)((ulonglong)uVar1 >> 0x20);
		  uVar5 = func_ii_1081(DAT_ram_00a66968,&local_10);
		  uVar7 = StringLiteral_17940;
		  piVar9 = *(int **)(iVar3 + 0xc);
		  if (piVar9 == (int *)0x0) {
		    local_8 = 0;
		    local_10 = 0;
		  }
		  else {
		    iVar15 = *piVar9;
		    if (*(ushort *)(iVar15 + 0xb6) != 0) {
		      uVar16 = 0;
		      do {
		        if (Gameplay_Isles_Base_IIsle_TypeInfo == *(int *)(*(int *)(iVar15 + 0x58) + uVar16 * 8)) {
		          puVar4 = (uint *)(iVar15 + *(int *)(*(int *)(iVar15 + 0x58) + uVar16 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x80f910ba;
		        }
		        uVar16 = uVar16 + 1;
		      } while (*(ushort *)(iVar15 + 0xb6) != uVar16);
		    }
		    puVar4 = (uint *)func_ii_1080(piVar9,Gameplay_Isles_Base_IIsle_TypeInfo,0);
		code_r0x80f910ba:
		    uVar1 = (**(code **)((ulonglong)*puVar4 * 4))(piVar9,CONCAT44(uVar14,puVar4[1]));
		    local_18 = 0;
		    local_20 = 0;
		    Core_Log_Files_FileDownloadLogger__LogDownload
		              (&local_20,uVar1,Method_System_Nullable_ulong___ctor__);
		    uVar14 = (uint)((ulonglong)uVar1 >> 0x20);
		    local_8 = local_18;
		    local_10 = local_20;
		  }
		  local_18 = local_8;
		  local_20 = local_10;
		  uVar6 = func_ii_1081(System_Nullable_ulong__TypeInfo,&local_20);
		  uVar7 = System_Collections_Generic_Dictionary_int__object___ContainsKey(uVar7,uVar5,uVar6,0);
		  if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		    func_ii_306000(OKG_Logs_Debug_TypeInfo);
		  }
		  lVar2 = (ulonglong)uVar14 << 0x20;
		  System_Collections_Generic_Dictionary_uint__object___get_Count(uVar7,0);
		  if (DAT_ram_00a58c62 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Queue_BaseIsleEngineAction__Dequeue__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Queue_BaseIsleEngineAction__get_Count__);
		    DAT_ram_00a58c62 = '\x01';
		  }
		  piVar9 = *(int **)(param1 + 0x3c);
		  if (piVar9 != (int *)0x0) {
		    uVar1 = CONCAT44((int)((ulonglong)lVar2 >> 0x20),*(undefined4 *)(*piVar9 + 0xf4));
		    (**(code **)((ulonglong)*(uint *)(*piVar9 + 0xf0) * 4))(piVar9,uVar1);
		    iVar15 = **(int **)(param1 + 0x3c);
		    lVar2 = CONCAT44((int)((ulonglong)uVar1 >> 0x20),*(undefined4 *)(iVar15 + 0xfc));
		    (**(code **)((ulonglong)*(uint *)(iVar15 + 0xf8) * 4))(*(int **)(param1 + 0x3c),lVar2);
		    *(undefined4 *)(param1 + 0x3c) = 0;
		  }
		  uVar7 = (undefined4)((ulonglong)lVar2 >> 0x20);
		  iVar15 = *(int *)(param1 + 0x38);
		  iVar10 = *(int *)(iVar15 + 0x14);
		  while (0 < iVar10) {
		    uVar7 = (undefined4)((ulonglong)lVar2 >> 0x20);
		    piVar9 = (int *)func_ii_7387(iVar15,
		                                 Method_System_Collections_Generic_Queue_BaseIsleEngineAction__Dequeue__
		                                );
		    lVar2 = CONCAT44(uVar7,*(undefined4 *)(*piVar9 + 0xfc));
		    (**(code **)((ulonglong)*(uint *)(*piVar9 + 0xf8) * 4))(piVar9,lVar2);
		    uVar7 = (undefined4)((ulonglong)lVar2 >> 0x20);
		    iVar15 = *(int *)(param1 + 0x38);
		    iVar10 = *(int *)(iVar15 + 0x14);
		  }
		  if (DAT_ram_00a65020 == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Vector3_TypeInfo);
		    DAT_ram_00a65020 = '\x01';
		  }
		  puVar11 = *(undefined4 **)(UnityEngine_Vector3_TypeInfo + 0x5c);
		  uVar5 = puVar11[2];
		  uVar6 = puVar11[1];
		  uVar12 = *puVar11;
		  if (param2 == 0) {
		    do {
		      halt_trap();
		    } while( true );
		  }
		  if (param2 == 1) {
		    puVar11 = (undefined4 *)(param1 + 0x1c);
		  }
		  else if (param2 == 2) {
		    puVar11 = (undefined4 *)(param1 + 0x20);
		  }
		  else {
		    puVar11 = (undefined4 *)(param1 + 0x24);
		  }
		  piVar9 = (int *)*puVar11;
		  *(int **)(iVar3 + 0x14) = piVar9;
		  uVar14 = 0;
		  iVar15 = *piVar9;
		  if (*(ushort *)(iVar15 + 0xb6) != 0) {
		    do {
		      if (CloudsFly_IIsleWorldObjectEngine_TypeInfo ==
		          *(int *)(*(int *)(iVar15 + 0x58) + uVar14 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar15 + 0x58) + uVar14 * 8 + 4) * 8 + iVar15 + 0xf8);
		        goto code_r0x80f912e1;
		      }
		      uVar14 = uVar14 + 1;
		    } while (*(ushort *)(iVar15 + 0xb6) != uVar14);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar9,CloudsFly_IIsleWorldObjectEngine_TypeInfo,7);
		code_r0x80f912e1:
		  uVar1 = CONCAT44(uVar7,puVar4[1]);
		  uVar8 = (**(code **)((ulonglong)*puVar4 * 4))(piVar9,uVar1);
		  uVar7 = (undefined4)((ulonglong)uVar1 >> 0x20);
		  iVar15 = System_Collections_Generic_HashSet_Enumerator_object___Dispose
		                     (uVar8,
		                      Method_System_Collections_Generic_Dictionary_ulong__BaseIsleWorldObject__get_Count__
		                     );
		  if (iVar15 == 0) {
		    if (**(char **)(Gameplay_World_View_WorldView_TypeInfo + 0x5c) == '\0') {
		      uVar8 = 1;
		      **(char **)(Gameplay_World_View_WorldView_TypeInfo + 0x5c) = '\x01';
		      *(undefined4 *)(iVar3 + 0x20) = 1;
		      uVar5 = 0x469c4000;
		      uVar12 = 0;
		      uVar6 = 0;
		      fVar13 = 0.4;
		      goto code_r0x80f914cd;
		    }
		    uVar8 = 4;
		    *(undefined4 *)(iVar3 + 0x20) = 4;
		    uVar5 = 0x43fa0000;
		    uVar12 = 0;
		    uVar6 = 0;
		  }
		  else {
		    piVar9 = *(int **)(iVar3 + 0x14);
		    iVar15 = *piVar9;
		    if (*(ushort *)(iVar15 + 0xb6) != 0) {
		      uVar14 = 0;
		      do {
		        if (CloudsFly_IIsleWorldObjectEngine_TypeInfo ==
		            *(int *)(*(int *)(iVar15 + 0x58) + uVar14 * 8)) {
		          puVar4 = (uint *)(*(int *)(*(int *)(iVar15 + 0x58) + uVar14 * 8 + 4) * 8 + iVar15 + 0xf8);
		          goto code_r0x80f913d3;
		        }
		        uVar14 = uVar14 + 1;
		      } while (*(ushort *)(iVar15 + 0xb6) != uVar14);
		    }
		    puVar4 = (uint *)func_ii_1080(piVar9,CloudsFly_IIsleWorldObjectEngine_TypeInfo,7);
		code_r0x80f913d3:
		    uVar14 = 0;
		    uVar1 = CONCAT44(uVar7,puVar4[1]);
		    uVar8 = (**(code **)((ulonglong)*puVar4 * 4))(piVar9,uVar1);
		    uVar7 = (undefined4)((ulonglong)uVar1 >> 0x20);
		    piVar9 = *(int **)(iVar3 + 8);
		    iVar15 = *piVar9;
		    if (*(ushort *)(iVar15 + 0xb6) != 0) {
		      do {
		        if (Gameplay_Isles_Base_IIsle_TypeInfo == *(int *)(*(int *)(iVar15 + 0x58) + uVar14 * 8)) {
		          puVar4 = (uint *)(iVar15 + *(int *)(*(int *)(iVar15 + 0x58) + uVar14 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x80f91458;
		        }
		        uVar14 = uVar14 + 1;
		      } while (*(ushort *)(iVar15 + 0xb6) != uVar14);
		    }
		    puVar4 = (uint *)func_ii_1080(piVar9,Gameplay_Isles_Base_IIsle_TypeInfo,0);
		code_r0x80f91458:
		    uVar1 = (**(code **)((ulonglong)*puVar4 * 4))(piVar9,CONCAT44(uVar7,puVar4[1]));
		    iVar15 = Google_Protobuf_Collections_RepeatedField_ulong___GetEnumerator
		                       (uVar8,uVar1,
		                        Method_System_Collections_Generic_Dictionary_ulong__BaseIsleWorldObject__ContainsKey__
		                       );
		    uVar7 = (undefined4)((ulonglong)uVar1 >> 0x20);
		    if (iVar15 == 0) {
		      if (param6 == 0) {
		        uVar8 = 5;
		        *(undefined4 *)(iVar3 + 0x20) = 5;
		        uVar5 = 0x45fa0000;
		      }
		      else {
		        uVar8 = 3;
		        *(undefined4 *)(iVar3 + 0x20) = 3;
		        uVar5 = 0xc5fa0000;
		      }
		      uVar6 = 0;
		      uVar12 = 0xc57a0000;
		    }
		    else {
		      uVar8 = 2;
		      *(undefined4 *)(iVar3 + 0x20) = 2;
		    }
		  }
		  fVar13 = 0.0;
		code_r0x80f914cd:
		  iVar15 = *(int *)(param1 + 0x28);
		  if (iVar15 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar15 + 0xc) * 4))
		              (*(undefined4 *)(iVar15 + 0x20),CONCAT44(uVar7,uVar8),*(undefined4 *)(iVar15 + 0x14));
		  }
		  uVar7 = *(undefined4 *)(iVar3 + 0x14);
		  uVar8 = *(undefined4 *)(iVar3 + 8);
		  iVar15 = unnamed_function_1417
		                     (Gameplay_World_Model_View_IslandEngineActions_SetIsleEngineAction_TypeInfo);
		  *(undefined4 *)(iVar15 + 0x1c) = uVar5;
		  *(undefined4 *)(iVar15 + 0x18) = uVar6;
		  *(undefined4 *)(iVar15 + 0x14) = uVar12;
		  *(undefined4 *)(iVar15 + 0x10) = 0;
		  *(undefined4 *)(iVar15 + 0xc) = uVar8;
		  *(undefined4 *)(iVar15 + 8) = uVar7;
		  if (DAT_ram_00a58c66 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Queue_BaseIsleEngineAction__Enqueue__);
		    DAT_ram_00a58c66 = '\x01';
		  }
		  System_Collections_Generic_Dictionary_Int32Enum__object___TryGetValue
		            (*(undefined4 *)(param1 + 0x38),iVar15,
		             Method_System_Collections_Generic_Queue_BaseIsleEngineAction__Enqueue__);
		  Gameplay_World_View_WorldView__InvokeIslandEngineAction(param1,iVar15);
		  if (0.0 < fVar13) {
		    uVar7 = *(undefined4 *)(iVar3 + 0x14);
		    iVar15 = unnamed_function_1417
		                       (Gameplay_World_Model_View_IslandEngineActions_DelayIsleEngineAction_TypeInfo
		                       );
		    *(float *)(iVar15 + 0xc) = fVar13;
		    *(undefined4 *)(iVar15 + 8) = uVar7;
		    if (DAT_ram_00a58c66 == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&Method_System_Collections_Generic_Queue_BaseIsleEngineAction__Enqueue__);
		      DAT_ram_00a58c66 = '\x01';
		    }
		    System_Collections_Generic_Dictionary_Int32Enum__object___TryGetValue
		              (*(undefined4 *)(param1 + 0x38),iVar15,
		               Method_System_Collections_Generic_Queue_BaseIsleEngineAction__Enqueue__);
		    Gameplay_World_View_WorldView__InvokeIslandEngineAction(param1,iVar15);
		  }
		  uVar7 = *(undefined4 *)(iVar3 + 0x14);
		  uVar5 = *(undefined4 *)(iVar3 + 8);
		  uVar6 = *(undefined4 *)(iVar3 + 0x20);
		  iVar15 = unnamed_function_1417
		                     (
		                     Gameplay_World_Model_View_IslandEngineActions_MoveToIslandEngineAction_TypeInfo
		                     );
		  *(undefined4 *)(iVar15 + 0x10) = uVar6;
		  *(undefined4 *)(iVar15 + 0xc) = uVar5;
		  *(undefined4 *)(iVar15 + 8) = uVar7;
		  if (DAT_ram_00a58c66 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Queue_BaseIsleEngineAction__Enqueue__);
		    DAT_ram_00a58c66 = '\x01';
		  }
		  System_Collections_Generic_Dictionary_Int32Enum__object___TryGetValue
		            (*(undefined4 *)(param1 + 0x38),iVar15,
		             Method_System_Collections_Generic_Queue_BaseIsleEngineAction__Enqueue__);
		  Gameplay_World_View_WorldView__InvokeIslandEngineAction(param1,iVar15);
		  uVar5 = *(undefined4 *)(iVar3 + 0x14);
		  uVar7 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar7,iVar3,
		             Method_Gameplay_World_View_WorldView___c__DisplayClass33_0__MoveToIsle_b__0__,0);
		  iVar3 = unnamed_function_1417(Gameplay_World_View_CallbackIslandEngineAction_TypeInfo);
		  *(undefined4 *)(iVar3 + 0xc) = uVar7;
		  *(undefined4 *)(iVar3 + 8) = uVar5;
		  if (DAT_ram_00a58c66 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Queue_BaseIsleEngineAction__Enqueue__);
		    DAT_ram_00a58c66 = '\x01';
		  }
		  System_Collections_Generic_Dictionary_Int32Enum__object___TryGetValue
		            (*(undefined4 *)(param1 + 0x38),iVar3,
		             Method_System_Collections_Generic_Queue_BaseIsleEngineAction__Enqueue__);
		  Gameplay_World_View_WorldView__InvokeIslandEngineAction(param1,iVar3);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06001397 RID: 5015 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001397")]
		[Address(RVA = "0x6587", Offset = "0x6587", VA = "0x6587")]
		public void MoveToIsle(WorldLevel worldLevel, IIsle target, IIsle next1, IIsle next2, bool isHome, List<IIsle> validIsles)
		{
		/* --- GHIDRA: MoveToIsle ---
		void Gameplay_World_View_WorldView__MoveToIsle(int param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int *param1_00;
		  uint *puVar2;
		  undefined4 *puVar3;
		  int iVar4;
		  
		  param1_00 = (int *)0x0;
		  if (DAT_ram_00a58c65 == '\0') {
		    Mono_Security_ASN1__get_Item(&CloudsFly_IIsleWorldObjectEngine_TypeInfo);
		    DAT_ram_00a58c65 = '\x01';
		  }
		  if (param2 == -1) {
		    puVar3 = (undefined4 *)(param1 + 0x24);
		  }
		  else {
		    if (param2 == 0) goto code_r0x80f9173f;
		    if (param2 == 1) {
		      puVar3 = (undefined4 *)(param1 + 0x1c);
		    }
		    else {
		      if (param2 != 2) goto code_r0x80f9173f;
		      puVar3 = (undefined4 *)(param1 + 0x20);
		    }
		  }
		  param1_00 = (int *)*puVar3;
		code_r0x80f9173f:
		  uVar1 = 0;
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (CloudsFly_IIsleWorldObjectEngine_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8))
		      {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xe8);
		        goto code_r0x80f917ae;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,CloudsFly_IIsleWorldObjectEngine_TypeInfo,5);
		code_r0x80f917ae:
		  (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  return;
		}
		*/

		}

		// Token: 0x06001398 RID: 5016 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001398")]
		[Address(RVA = "0x6588", Offset = "0x6588", VA = "0x6588")]
		public void Clear(WorldLevel worldLevel)
		{
		/* --- GHIDRA: Clear ---
		void Gameplay_World_View_WorldView__Clear(int param1,undefined4 param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a58c66 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Queue_BaseIsleEngineAction__Enqueue__);
		    DAT_ram_00a58c66 = '\x01';
		  }
		  System_Collections_Generic_Dictionary_Int32Enum__object___TryGetValue
		            (*(undefined4 *)(param1 + 0x38),param2,
		             Method_System_Collections_Generic_Queue_BaseIsleEngineAction__Enqueue__);
		  Gameplay_World_View_WorldView__InvokeIslandEngineAction(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06001399 RID: 5017 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001399")]
		[Address(RVA = "0x6589", Offset = "0x6589", VA = "0x6589")]
		private void InvokeIslandEngineAction(BaseIsleEngineAction action)
		{
		/* --- GHIDRA: InvokeIslandEngineAction ---
		void Gameplay_World_View_WorldView__InvokeIslandEngineAction(int param1,undefined4 param2)
		
		{
		  int *piVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a58c67 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_BaseIsleEngineAction__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Queue_BaseIsleEngineAction__Dequeue__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Queue_BaseIsleEngineAction__get_Count__);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_World_View_WorldView_ActionCompleteCallback__);
		    DAT_ram_00a58c67 = '\x01';
		  }
		  if ((*(int *)(param1 + 0x3c) == 0) && (0 < *(int *)(*(int *)(param1 + 0x38) + 0x14))) {
		    piVar1 = (int *)func_ii_7387(*(int *)(param1 + 0x38),
		                                 Method_System_Collections_Generic_Queue_BaseIsleEngineAction__Dequeue__
		                                );
		    *(int **)(param1 + 0x3c) = piVar1;
		    param1_00 = unnamed_function_1417(System_Action_BaseIsleEngineAction__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (param1_00,param1,Method_Gameplay_World_View_WorldView_ActionCompleteCallback__,0);
		    (**(code **)((ulonglong)*(uint *)(*piVar1 + 0xe8) * 4))
		              (piVar1,param1_00,*(undefined4 *)(*piVar1 + 0xec));
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600139A RID: 5018 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600139A")]
		[Address(RVA = "0x658A", Offset = "0x658A", VA = "0x658A")]
		private void HandleQueue()
		{
		/* --- GHIDRA: HandleQueue ---
		void Gameplay_World_View_WorldView__HandleQueue(int param1,int *param2,undefined4 param3)
		
		{
		  *(undefined4 *)(param1 + 0x3c) = 0;
		  (**(code **)((ulonglong)*(uint *)(*param2 + 0xf8) * 4))(param2,*(undefined4 *)(*param2 + 0xfc));
		  Gameplay_World_View_WorldView__InvokeIslandEngineAction(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x0600139B RID: 5019 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600139B")]
		[Address(RVA = "0x658B", Offset = "0x658B", VA = "0x658B")]
		private void ActionCompleteCallback(BaseIsleEngineAction action)
		{
		/* --- GHIDRA: ActionCompleteCallback ---
		void Gameplay_World_View_WorldView__ActionCompleteCallback(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a58c68 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Queue_BaseIsleEngineAction___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Queue_BaseIsleEngineAction__TypeInfo);
		    DAT_ram_00a58c68 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Collections_Generic_Queue_BaseIsleEngineAction__TypeInfo)
		  ;
		  Sirenix_Serialization_StackFormatter_object____Il2CppFullySharedGenericType___SerializeImplementation
		            (param1_00,Method_System_Collections_Generic_Queue_BaseIsleEngineAction___ctor__);
		  *(undefined4 *)(param1 + 0x38) = param1_00;
		  UnityEngine_RectTransform__GetParentSize(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x0600139C RID: 5020 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600139C")]
		[Address(RVA = "0x658C", Offset = "0x658C", VA = "0x658C")]
		public WorldView()
		{
		}

		// Token: 0x04000A7B RID: 2683
		[Token(Token = "0x4000A7B")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private CloudObjectsEngineController _cloudObjectsEngineController;

		// Token: 0x04000A7C RID: 2684
		[Token(Token = "0x4000A7C")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Transform[] _worldParts;

		// Token: 0x04000A7D RID: 2685
		[Token(Token = "0x4000A7D")]
		[FieldOffset(Offset = "0x18")]
		private WorldLevel _currentWorldLevel;

		// Token: 0x04000A7E RID: 2686
		[Token(Token = "0x4000A7E")]
		[FieldOffset(Offset = "0x0")]
		private static bool _anyTweenHappened;

		// Token: 0x04000A7F RID: 2687
		[Token(Token = "0x4000A7F")]
		[FieldOffset(Offset = "0x1C")]
		private UserIsleWorldObjectEngine _userIsleEngine;

		// Token: 0x04000A80 RID: 2688
		[Token(Token = "0x4000A80")]
		[FieldOffset(Offset = "0x20")]
		private ClanIsleWorldObjectEngine _clanIsleEngine;

		// Token: 0x04000A81 RID: 2689
		[Token(Token = "0x4000A81")]
		[FieldOffset(Offset = "0x24")]
		private AxisIsleWorldObjectEngine _axisIsleEngine;

		// Token: 0x04000A85 RID: 2693
		[Token(Token = "0x4000A85")]
		[FieldOffset(Offset = "0x34")]
		private WorldViewMediator _mediator;

		// Token: 0x04000A86 RID: 2694
		[Token(Token = "0x4000A86")]
		[FieldOffset(Offset = "0x38")]
		private readonly Queue<BaseIsleEngineAction> _actionsQueue;

		// Token: 0x04000A87 RID: 2695
		[Token(Token = "0x4000A87")]
		[FieldOffset(Offset = "0x3C")]
		private BaseIsleEngineAction _currentAction;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_CurrentWorldLevel ---
		uint Gameplay_World_View_WorldView__get_CurrentWorldLevel(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a58c58 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_World_View_WorldView_TypeInfo);
		    DAT_ram_00a58c58 = '\x01';
		  }
		  return (uint)**(byte **)(Gameplay_World_View_WorldView_TypeInfo + 0x5c);
		}
		*/


		/* --- GHIDRA: get_CloudObjectsEngineController ---
		void Gameplay_World_View_WorldView__get_CloudObjectsEngineController
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a58c59 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_WorldMovementTypes__TypeInfo);
		    DAT_ram_00a58c59 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x28);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_WorldMovementTypes__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_WorldMovementTypes__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(param1 + 0x28,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: add_MovStartEvent ---
		void Gameplay_World_View_WorldView__add_MovStartEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a58c5a == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_WorldMovementTypes__TypeInfo);
		    DAT_ram_00a58c5a = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x28);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_WorldMovementTypes__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_WorldMovementTypes__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(param1 + 0x28,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: remove_MovStartEvent ---
		void Gameplay_World_View_WorldView__remove_MovStartEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a58c5b == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_WorldMovementTypes__TypeInfo);
		    DAT_ram_00a58c5b = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x2c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_WorldMovementTypes__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_WorldMovementTypes__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(param1 + 0x2c,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: add_MovCompleteEvent ---
		void Gameplay_World_View_WorldView__add_MovCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a58c5c == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_WorldMovementTypes__TypeInfo);
		    DAT_ram_00a58c5c = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x2c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_WorldMovementTypes__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_WorldMovementTypes__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(param1 + 0x2c,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: remove_MovCompleteEvent ---
		void Gameplay_World_View_WorldView__remove_MovCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a58c5d == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_WorldLevel__WorldLevel__TypeInfo);
		    DAT_ram_00a58c5d = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x30);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_WorldLevel__WorldLevel__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_WorldLevel__WorldLevel__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(param1 + 0x30,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: add_WorldLevelChangedEvent ---
		void Gameplay_World_View_WorldView__add_WorldLevelChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a58c5e == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_WorldLevel__WorldLevel__TypeInfo);
		    DAT_ram_00a58c5e = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x30);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_WorldLevel__WorldLevel__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_WorldLevel__WorldLevel__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(param1 + 0x30,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: remove_WorldLevelChangedEvent ---
		void Gameplay_World_View_WorldView__remove_WorldLevelChangedEvent(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int iVar5;
		  
		  iVar5 = 0;
		  if (DAT_ram_00a58c5f == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UI_Windows_PopupController_StateChanged_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_World_View_WorldView_OnChangeWindows__);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_World_View_WorldView_OnEngineInitialized__);
		    DAT_ram_00a58c5f = '\x01';
		  }
		  uVar3 = *(undefined4 *)(param1 + 0x10);
		  uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar1,param1,Method_Gameplay_World_View_WorldView_OnEngineInitialized__,0);
		  CloudsFly_CloudBGParallax__MoveBG_d__8__System_Collections_IEnumerator_get_Current(uVar3,uVar1,0);
		  uVar1 = System_Uri___ctor(0);
		  uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar1,0);
		  uVar3 = unnamed_function_1417(UI_Windows_PopupController_StateChanged_TypeInfo);
		  UI_Windows_PopupController___ctor
		            (uVar3,param1,Method_Gameplay_World_View_WorldView_OnChangeWindows__,0);
		  UI_Windows_Layer___ctor(uVar1,uVar3,0);
		  uVar1 = System_Uri___ctor(0);
		  uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar1,0);
		  iVar2 = UI_Windows_PopupController__BringWindowToFront(uVar1,0);
		  UnityEngine_Object__op_Implicit(*(undefined4 *)(param1 + 0x10),(uint)(iVar2 == 0),0);
		  iVar4 = *(int *)(param1 + 0x14);
		  if (0 < *(int *)(iVar4 + 0xc)) {
		    do {
		      uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(iVar4 + iVar5 * 4 + 0x10),0);
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (uVar1,(uint)(iVar2 == 0),0);
		      iVar5 = iVar5 + 1;
		    } while (iVar5 < *(int *)(iVar4 + 0xc));
		  }
		  return;
		}
		*/

}
