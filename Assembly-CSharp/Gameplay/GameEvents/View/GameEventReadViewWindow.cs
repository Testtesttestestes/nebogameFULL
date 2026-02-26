using System;
using Gameplay.GameEvents.Control;
using Gameplay.GameEvents.Model;
using Il2CppDummyDll;
using UI.Windows;
using UnityEngine;

namespace Gameplay.GameEvents.View
{
	// Token: 0x0200077A RID: 1914
	[Token(Token = "0x200077A")]
	public class GameEventReadViewWindow : ClosableBaseWindow<GameEventReadViewWindow.GameEventReadViewWindowArgs>
	{
		// Token: 0x170008C1 RID: 2241
		// (get) Token: 0x06002D93 RID: 11667 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170008C1")]
		public override string WindowId
		{
			[Token(Token = "0x6002D93")]
			[Address(RVA = "0x7E11", Offset = "0x7E11", VA = "0x7E11", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002D94 RID: 11668 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D94")]
		[Address(RVA = "0x7E12", Offset = "0x7E12", VA = "0x7E12")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_GameEvents_View_GameEventReadViewWindow__OnDestroy(int param1,undefined4 param2)
		
		{
		  int *piVar1;
		  int iVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a57489 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_ClosableBaseWindow_GameEventReadViewWindow_GameEventReadViewWindowArgs__OnClose__
		              );
		    DAT_ram_00a57489 = '\x01';
		  }
		  UI_Windows_ClosableBaseWindow_object___OnClickBack
		            (param1,
		             Method_UI_Windows_ClosableBaseWindow_GameEventReadViewWindow_GameEventReadViewWindowArgs__OnClose__
		            );
		  iVar3 = **(int **)(param1 + 0x40);
		  piVar1 = (int *)(**(code **)((ulonglong)*(uint *)(iVar3 + 0x148) * 4))
		                            (*(int **)(param1 + 0x40),*(undefined4 *)(iVar3 + 0x14c));
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x100) * 4))
		                    (piVar1,*(undefined4 *)(*piVar1 + 0x104));
		  if (*(int *)(iVar3 + 0x34) != 0) {
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x100) * 4))
		                      (piVar1,*(undefined4 *)(*piVar1 + 0x104));
		    *(undefined4 *)(iVar3 + 0x34) = 0;
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x110) * 4))
		                      (piVar1,*(undefined4 *)(*piVar1 + 0x114));
		    iVar3 = *(int *)(iVar3 + 0x20);
		    if (iVar3 != 0) {
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x100) * 4))
		                        (piVar1,*(undefined4 *)(*piVar1 + 0x104));
		      (**(code **)((ulonglong)*(uint *)(iVar3 + 0xc) * 4))
		                (*(undefined4 *)(iVar3 + 0x20),*(undefined4 *)(iVar2 + 0x34),
		                 *(undefined4 *)(iVar3 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002D95 RID: 11669 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D95")]
		[Address(RVA = "0x7E13", Offset = "0x7E13", VA = "0x7E13", Slot = "19")]
		protected override void OnClose()
		{
		/* --- GHIDRA: OnClose ---
		void Gameplay_GameEvents_View_GameEventReadViewWindow__OnClose
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 param3_00;
		  int *param1_00;
		  undefined4 param2_00;
		  undefined4 param4;
		  int iVar1;
		  
		  if (DAT_ram_00a5748a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_ClosableBaseWindow_GameEventReadViewWindow_GameEventReadViewWindowArgs__OnShow__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_GameEvents_Control_GameEventReadViewMediator_TypeInfo);
		    DAT_ram_00a5748a = '\x01';
		  }
		  func_ii_7769(param1,param2,
		               Method_UI_Windows_ClosableBaseWindow_GameEventReadViewWindow_GameEventReadViewWindowArgs__OnShow__
		              );
		  param2_00 = *(undefined4 *)(param2 + 0x18);
		  iVar1 = **(int **)(param2 + 0x1c);
		  param3_00 = (**(code **)((ulonglong)*(uint *)(iVar1 + 0x110) * 4))
		                        (*(int **)(param2 + 0x1c),*(undefined4 *)(iVar1 + 0x114));
		  param4 = *(undefined4 *)(param2 + 0x1c);
		  param1_00 = (int *)unnamed_function_1417
		                               (Gameplay_GameEvents_Control_GameEventReadViewMediator_TypeInfo);
		  if (DAT_ram_00a5750a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_GameEventsModel__GameEventsEvents__GameEventsController__GameEventReadView___ctor__
		              );
		    DAT_ram_00a5750a = '\x01';
		  }
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (param1_00,param2_00,param3_00,param4,
		             Method_MVC_AbstractViewMediator_GameEventsModel__GameEventsEvents__GameEventsController__GameEventReadView___ctor__
		            );
		  *(int **)(param1 + 0x40) = param1_00;
		  (**(code **)((ulonglong)*(uint *)(*param1_00 + 0x160) * 4))
		            (param1_00,*(undefined4 *)(param1 + 0x3c),*(undefined4 *)(*param1_00 + 0x164));
		  return;
		}
		*/

		}

		// Token: 0x06002D96 RID: 11670 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D96")]
		[Address(RVA = "0x7E14", Offset = "0x7E14", VA = "0x7E14", Slot = "22")]
		protected override void OnShow(GameEventReadViewWindow.GameEventReadViewWindowArgs args)
		{
		/* --- GHIDRA: OnShow ---
		void Gameplay_GameEvents_View_GameEventReadViewWindow__OnShow(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5748b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_ClosableBaseWindow_GameEventReadViewWindow_GameEventReadViewWindowArgs___ctor__
		              );
		    DAT_ram_00a5748b = '\x01';
		  }
		  UI_MonoBehaviourWithStates_ClientStateChangedDelegate___Il2CppFullySharedGenericStructType___Invoke
		            (param1,
		             Method_UI_Windows_ClosableBaseWindow_GameEventReadViewWindow_GameEventReadViewWindowArgs___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06002D97 RID: 11671 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D97")]
		[Address(RVA = "0x7E15", Offset = "0x7E15", VA = "0x7E15")]
		public GameEventReadViewWindow()
		{
		}

		// Token: 0x040018F8 RID: 6392
		[Token(Token = "0x40018F8")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/GameEvents/GameEventReadViewWindow";

		// Token: 0x040018F9 RID: 6393
		[Token(Token = "0x40018F9")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private GameEventReadView _view;

		// Token: 0x040018FA RID: 6394
		[Token(Token = "0x40018FA")]
		[FieldOffset(Offset = "0x40")]
		private GameEventReadViewMediator _mediator;

		// Token: 0x0200077B RID: 1915
		[Token(Token = "0x200077B")]
		public class GameEventReadViewWindowArgs : BaseWindowArgs
		{
			// Token: 0x06002D98 RID: 11672 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002D98")]
			[Address(RVA = "0x7E16", Offset = "0x7E16", VA = "0x7E16")]
			public GameEventReadViewWindowArgs()
			{
			}

			// Token: 0x040018FB RID: 6395
			[Token(Token = "0x40018FB")]
			[FieldOffset(Offset = "0x18")]
			public GameEventsModel Model;

			// Token: 0x040018FC RID: 6396
			[Token(Token = "0x40018FC")]
			[FieldOffset(Offset = "0x1C")]
			public GameEventsController Controller;

			// Token: 0x040018FD RID: 6397
			[Token(Token = "0x40018FD")]
			[FieldOffset(Offset = "0x20")]
			public GameEventData EventData;
		}
	}
}
