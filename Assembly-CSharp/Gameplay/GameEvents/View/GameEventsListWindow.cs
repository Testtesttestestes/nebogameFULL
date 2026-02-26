using System;
using Gameplay.GameEvents.Control;
using Gameplay.GameEvents.Model;
using Il2CppDummyDll;
using UI.Windows;
using UnityEngine;

namespace Gameplay.GameEvents.View
{
	// Token: 0x0200077F RID: 1919
	[Token(Token = "0x200077F")]
	public class GameEventsListWindow : ClosableBaseWindow<GameEventsListWindow.GameEventsListWindowArgs>
	{
		// Token: 0x170008C9 RID: 2249
		// (get) Token: 0x06002DB4 RID: 11700 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170008C9")]
		public override string WindowId
		{
			[Token(Token = "0x6002DB4")]
			[Address(RVA = "0x7E32", Offset = "0x7E32", VA = "0x7E32", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002DB5 RID: 11701 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DB5")]
		[Address(RVA = "0x7E33", Offset = "0x7E33", VA = "0x7E33", Slot = "22")]
		protected override void OnShow(GameEventsListWindow.GameEventsListWindowArgs args)
		{
		/* --- GHIDRA: OnShow ---
		void Gameplay_GameEvents_View_GameEventsListWindow__OnShow
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int iVar2;
		  undefined4 uVar3;
		  int param1_01;
		  int iVar4;
		  undefined4 uVar5;
		  int *piVar6;
		  undefined4 param4;
		  
		  if (DAT_ram_00a5749b == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_GameEventsListView__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_GameEvents_Control_GameEventsListViewMediator_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_GameEvents_View_GameEventsListWindow_HandleListOnReadyEvent__);
		    DAT_ram_00a5749b = '\x01';
		  }
		  iVar4 = *(int *)(param1 + 0x3c);
		  uVar3 = unnamed_function_1417(System_Action_GameEventsListView__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar3,param1,
		             Method_Gameplay_GameEvents_View_GameEventsListWindow_HandleListOnReadyEvent__,0);
		  if (DAT_ram_00a5748d == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_GameEventsListView__TypeInfo);
		    DAT_ram_00a5748d = '\x01';
		  }
		  param1_00 = *(int *)(iVar4 + 0x38);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,uVar3,0);
		    uVar5 = System_Action_GameEventsListView__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_GameEventsListView__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(iVar4 + 0x38,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      uVar5 = *(undefined4 *)(*(int *)(param1 + 0x44) + 0x18);
		      piVar6 = *(int **)(*(int *)(param1 + 0x44) + 0x1c);
		      iVar4 = *piVar6;
		      uVar3 = (**(code **)((ulonglong)*(uint *)(iVar4 + 0x110) * 4))
		                        (piVar6,*(undefined4 *)(iVar4 + 0x114));
		      param4 = *(undefined4 *)(*(int *)(param1 + 0x44) + 0x1c);
		      piVar6 = (int *)unnamed_function_1417
		                                (Gameplay_GameEvents_Control_GameEventsListViewMediator_TypeInfo);
		      if (DAT_ram_00a5753b == '\0') {
		        Mono_Security_ASN1__get_Item
		                  (&
		                   Method_MVC_AbstractCozyViewMediator_GameEventsModel__GameEventsEvents__GameEventsController__GameEventsListView___ctor__
		                  );
		        DAT_ram_00a5753b = '\x01';
		      }
		      MVC_AbstractController_object__object___set_Model
		                (piVar6,uVar5,uVar3,param4,
		                 Method_MVC_AbstractCozyViewMediator_GameEventsModel__GameEventsEvents__GameEventsController__GameEventsListView___ctor__
		                );
		      *(int **)(param1 + 0x40) = piVar6;
		      (**(code **)((ulonglong)*(uint *)(*piVar6 + 0x160) * 4))
		                (piVar6,*(undefined4 *)(param1 + 0x3c),*(undefined4 *)(*piVar6 + 0x164));
		      *(undefined1 *)(*(int *)(*(int *)(param1 + 0x44) + 0x18) + 0x30) = 1;
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,uVar5);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06002DB6 RID: 11702 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DB6")]
		[Address(RVA = "0x7E34", Offset = "0x7E34", VA = "0x7E34")]
		private void HandleListOnReadyEvent(GameEventsListView listView)
		{
		/* --- GHIDRA: HandleListOnReadyEvent ---
		void Gameplay_GameEvents_View_GameEventsListWindow__HandleListOnReadyEvent
		               (int param1,undefined4 param2)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  undefined4 param1_01;
		  int param1_02;
		  int iVar3;
		  int *piVar4;
		  
		  if (DAT_ram_00a5749c == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_GameEventsListView__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_GameEvents_View_GameEventsListWindow_HandleListOnReadyEvent__);
		    DAT_ram_00a5749c = '\x01';
		  }
		  *(undefined1 *)(*(int *)(*(int *)(param1 + 0x44) + 0x18) + 0x30) = 0;
		  iVar3 = *(int *)(param1 + 0x3c);
		  param1_01 = unnamed_function_1417(System_Action_GameEventsListView__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_01,param1,
		             Method_Gameplay_GameEvents_View_GameEventsListWindow_HandleListOnReadyEvent__,0);
		  if (DAT_ram_00a5748d == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_GameEventsListView__TypeInfo);
		    DAT_ram_00a5748d = '\x01';
		  }
		  param1_00 = *(int *)(iVar3 + 0x38);
		  while( true ) {
		    iVar2 = 0;
		    param1_02 = func_ii_7048(param1_00,param1_01,0);
		    param2_00 = System_Action_GameEventsListView__TypeInfo;
		    if ((param1_02 != 0) &&
		       (iVar2 = func_ii_1082(param1_02,System_Action_GameEventsListView__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(iVar3 + 0x38,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      piVar4 = *(int **)(param1 + 0x40);
		      if (piVar4 != (int *)0x0) {
		        (**(code **)((ulonglong)*(uint *)(*piVar4 + 0x130) * 4))
		                  (piVar4,*(undefined4 *)(*piVar4 + 0x134));
		      }
		      *(undefined8 *)(param1 + 0x40) = 0;
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_02,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06002DB7 RID: 11703 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DB7")]
		[Address(RVA = "0x7E35", Offset = "0x7E35", VA = "0x7E35")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_GameEvents_View_GameEventsListWindow__OnDestroy(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5749d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_ClosableBaseWindow_GameEventsListWindow_GameEventsListWindowArgs___ctor__
		              );
		    DAT_ram_00a5749d = '\x01';
		  }
		  UI_MonoBehaviourWithStates_ClientStateChangedDelegate___Il2CppFullySharedGenericStructType___Invoke
		            (param1,
		             Method_UI_Windows_ClosableBaseWindow_GameEventsListWindow_GameEventsListWindowArgs___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06002DB8 RID: 11704 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DB8")]
		[Address(RVA = "0x7E36", Offset = "0x7E36", VA = "0x7E36")]
		public GameEventsListWindow()
		{
		}

		// Token: 0x04001912 RID: 6418
		[Token(Token = "0x4001912")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/GameEvents/GameEventsListWindow";

		// Token: 0x04001913 RID: 6419
		[Token(Token = "0x4001913")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private GameEventsListView eventsListView;

		// Token: 0x04001914 RID: 6420
		[Token(Token = "0x4001914")]
		[FieldOffset(Offset = "0x40")]
		private GameEventsListViewMediator _mediator;

		// Token: 0x04001915 RID: 6421
		[Token(Token = "0x4001915")]
		[FieldOffset(Offset = "0x44")]
		private GameEventsListWindow.GameEventsListWindowArgs _listWindowArgs;

		// Token: 0x02000780 RID: 1920
		[Token(Token = "0x2000780")]
		public class GameEventsListWindowArgs : BaseWindowArgs
		{
			// Token: 0x06002DB9 RID: 11705 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002DB9")]
			[Address(RVA = "0x7E37", Offset = "0x7E37", VA = "0x7E37")]
			public GameEventsListWindowArgs()
			{
			}

			// Token: 0x04001916 RID: 6422
			[Token(Token = "0x4001916")]
			[FieldOffset(Offset = "0x18")]
			public GameEventsModel Model;

			// Token: 0x04001917 RID: 6423
			[Token(Token = "0x4001917")]
			[FieldOffset(Offset = "0x1C")]
			public GameEventsController Controller;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_WindowId ---
		void Gameplay_GameEvents_View_GameEventsListWindow__get_WindowId
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  undefined4 param1_01;
		  int param1_02;
		  int iVar3;
		  
		  if (DAT_ram_00a5749a == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_GameEventsListView__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_ClosableBaseWindow_GameEventsListWindow_GameEventsListWindowArgs__OnShow__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_GameEvents_View_GameEventsListWindow_HandleListOnReadyEvent__);
		    DAT_ram_00a5749a = '\x01';
		  }
		  func_ii_7769(param1,param2,
		               Method_UI_Windows_ClosableBaseWindow_GameEventsListWindow_GameEventsListWindowArgs__OnShow__
		              );
		  *(undefined4 *)(param1 + 0x44) = param2;
		  iVar3 = *(int *)(param1 + 0x3c);
		  param1_01 = unnamed_function_1417(System_Action_GameEventsListView__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_01,param1,
		             Method_Gameplay_GameEvents_View_GameEventsListWindow_HandleListOnReadyEvent__,0);
		  if (DAT_ram_00a5748c == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_GameEventsListView__TypeInfo);
		    DAT_ram_00a5748c = '\x01';
		  }
		  param1_00 = *(int *)(iVar3 + 0x38);
		  while( true ) {
		    iVar2 = 0;
		    param1_02 = UnityEngine_UI_Image__set_sprite(param1_00,param1_01,0);
		    param2_00 = System_Action_GameEventsListView__TypeInfo;
		    if ((param1_02 != 0) &&
		       (iVar2 = func_ii_1082(param1_02,System_Action_GameEventsListView__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(iVar3 + 0x38,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_02,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

}
