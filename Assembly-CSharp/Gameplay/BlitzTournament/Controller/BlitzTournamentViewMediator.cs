using System;
using Core.Data.Tournaments;
using Gameplay.BlitzTournament.Events;
using Gameplay.BlitzTournament.Model;
using Gameplay.BlitzTournament.View;
using Il2CppDummyDll;
using MVC;
using Protocol.BlitzTournaments;

namespace Gameplay.BlitzTournament.Controller
{
	// Token: 0x02000BDC RID: 3036
	[Token(Token = "0x2000BDC")]
	public class BlitzTournamentViewMediator : AbstractViewMediator<BlitzTournamentModel, Gameplay.BlitzTournament.Events.BlitzTournamentEvents, BlitzTournamentController, BlitzTournamentWindow>
	{
		// Token: 0x06004A7C RID: 19068 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A7C")]
		[Address(RVA = "0x98DE", Offset = "0x98DE", VA = "0x98DE")]
		public BlitzTournamentViewMediator(BlitzTournamentModel model, Gameplay.BlitzTournament.Events.BlitzTournamentEvents events, BlitzTournamentController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_BlitzTournament_Controller_BlitzTournamentViewMediator___ctor
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  int iVar5;
		  undefined4 uVar6;
		  
		  if (DAT_ram_00a608e2 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_BlitzTournamentModel__BlitzTournamentEvents__BlitzTournamentController__BlitzTournamentWindow__set_Events__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoStateChangedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_uint__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_BlitzTournament_Controller_BlitzTournamentViewMediator_BlockUIEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_BlitzTournament_Controller_BlitzTournamentViewMediator_FightersCountChangedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_BlitzTournament_Controller_BlitzTournamentViewMediator_JoinedQueueEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_BlitzTournament_Controller_BlitzTournamentViewMediator_LeftQueueEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_BlitzTournament_Controller_BlitzTournamentViewMediator_StateChangedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_BlitzTournament_Controller_BlitzTournamentViewMediator_TournamentInfoReceivedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_BlitzTournament_Controller_BlitzTournamentViewMediator_TournamentListReceivedEventHandler__
		              );
		    DAT_ram_00a608e2 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar2 + 0x14);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_BlitzTournament_Controller_BlitzTournamentViewMediator_TournamentInfoReceivedEventHandler__
		               ,0);
		    piVar4 = (int *)func_ii_7048(uVar6,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x14) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x14) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar2 + 0x18);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_BlitzTournament_Controller_BlitzTournamentViewMediator_TournamentListReceivedEventHandler__
		               ,0);
		    piVar4 = (int *)func_ii_7048(uVar6,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x18) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x18) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar2 + 0x1c);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_BlitzTournament_Controller_BlitzTournamentViewMediator_JoinedQueueEventHandler__
		               ,0);
		    piVar4 = (int *)func_ii_7048(uVar6,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x1c) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x1c) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar2 + 0x20);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_BlitzTournament_Controller_BlitzTournamentViewMediator_LeftQueueEventHandler__
		               ,0);
		    piVar4 = (int *)func_ii_7048(uVar6,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x20) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x20) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar1 + 0x24);
		    uVar3 = unnamed_function_1417(System_Action_ProtoStateChangedEvt__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar3,param1,
		               Method_Gameplay_BlitzTournament_Controller_BlitzTournamentViewMediator_StateChangedEventHandler__
		               ,0);
		    iVar2 = func_ii_7048(uVar6,uVar3,0);
		    uVar3 = System_Action_ProtoStateChangedEvt__TypeInfo;
		    if (iVar2 == 0) {
		      *(undefined4 *)(iVar1 + 0x24) = 0;
		    }
		    else {
		      iVar5 = func_ii_1082(iVar2,System_Action_ProtoStateChangedEvt__TypeInfo);
		      if (iVar5 == 0) {
		        System_Activator__CreateInstance(iVar2,uVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x24) = iVar5;
		      uVar3 = System_Action_ProtoStateChangedEvt__TypeInfo;
		      iVar1 = func_ii_1082(iVar2,System_Action_ProtoStateChangedEvt__TypeInfo);
		      if (iVar1 == 0) {
		        System_Activator__CreateInstance(iVar2,uVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar1 + 0x28);
		    uVar3 = unnamed_function_1417(System_Action_uint__TypeInfo);
		    func_ii_12322(uVar3,param1,
		                  Method_Gameplay_BlitzTournament_Controller_BlitzTournamentViewMediator_FightersCountChangedEventHandler__
		                  ,0);
		    iVar2 = func_ii_7048(uVar6,uVar3,0);
		    uVar3 = System_Action_uint__TypeInfo;
		    if (iVar2 == 0) {
		      *(undefined4 *)(iVar1 + 0x28) = 0;
		    }
		    else {
		      iVar5 = func_ii_1082(iVar2,System_Action_uint__TypeInfo);
		      if (iVar5 == 0) {
		        System_Activator__CreateInstance(iVar2,uVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x28) = iVar5;
		      uVar3 = System_Action_uint__TypeInfo;
		      iVar1 = func_ii_1082(iVar2,System_Action_uint__TypeInfo);
		      if (iVar1 == 0) {
		        System_Activator__CreateInstance(iVar2,uVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar1 + 0x2c);
		    uVar3 = unnamed_function_1417(System_Action_bool__TypeInfo);
		    System_Action_AsyncGPUReadbackRequest___Invoke
		              (uVar3,param1,
		               Method_Gameplay_BlitzTournament_Controller_BlitzTournamentViewMediator_BlockUIEventHandler__
		               ,0);
		    iVar2 = func_ii_7048(uVar6,uVar3,0);
		    uVar3 = System_Action_bool__TypeInfo;
		    if (iVar2 == 0) {
		      *(undefined4 *)(iVar1 + 0x2c) = 0;
		    }
		    else {
		      iVar5 = func_ii_1082(iVar2,System_Action_bool__TypeInfo);
		      if (iVar5 == 0) {
		        System_Activator__CreateInstance(iVar2,uVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x2c) = iVar5;
		      uVar3 = System_Action_bool__TypeInfo;
		      iVar1 = func_ii_1082(iVar2,System_Action_bool__TypeInfo);
		      if (iVar1 == 0) {
		        System_Activator__CreateInstance(iVar2,uVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		  }
		  param1[3] = param2;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar2 + 0x14);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_BlitzTournament_Controller_BlitzTournamentViewMediator_TournamentInfoReceivedEventHandler__
		               ,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar6,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x14) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x14) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar2 + 0x18);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_BlitzTournament_Controller_BlitzTournamentViewMediator_TournamentListReceivedEventHandler__
		               ,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar6,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x18) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x18) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar2 + 0x1c);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_BlitzTournament_Controller_BlitzTournamentViewMediator_JoinedQueueEventHandler__
		               ,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar6,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x1c) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x1c) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar2 + 0x20);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_BlitzTournament_Controller_BlitzTournamentViewMediator_LeftQueueEventHandler__
		               ,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar6,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x20) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x20) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar1 + 0x24);
		    uVar3 = unnamed_function_1417(System_Action_ProtoStateChangedEvt__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar3,param1,
		               Method_Gameplay_BlitzTournament_Controller_BlitzTournamentViewMediator_StateChangedEventHandler__
		               ,0);
		    iVar2 = UnityEngine_UI_Image__set_sprite(uVar6,uVar3,0);
		    uVar3 = System_Action_ProtoStateChangedEvt__TypeInfo;
		    if (iVar2 == 0) {
		      *(undefined4 *)(iVar1 + 0x24) = 0;
		    }
		    else {
		      iVar5 = func_ii_1082(iVar2,System_Action_ProtoStateChangedEvt__TypeInfo);
		      if (iVar5 == 0) {
		        System_Activator__CreateInstance(iVar2,uVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x24) = iVar5;
		      uVar3 = System_Action_ProtoStateChangedEvt__TypeInfo;
		      iVar1 = func_ii_1082(iVar2,System_Action_ProtoStateChangedEvt__TypeInfo);
		      if (iVar1 == 0) {
		        System_Activator__CreateInstance(iVar2,uVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar1 + 0x28);
		    uVar3 = unnamed_function_1417(System_Action_uint__TypeInfo);
		    func_ii_12322(uVar3,param1,
		                  Method_Gameplay_BlitzTournament_Controller_BlitzTournamentViewMediator_FightersCountChangedEventHandler__
		                  ,0);
		    iVar2 = UnityEngine_UI_Image__set_sprite(uVar6,uVar3,0);
		    uVar3 = System_Action_uint__TypeInfo;
		    if (iVar2 == 0) {
		      *(undefined4 *)(iVar1 + 0x28) = 0;
		    }
		    else {
		      iVar5 = func_ii_1082(iVar2,System_Action_uint__TypeInfo);
		      if (iVar5 == 0) {
		        System_Activator__CreateInstance(iVar2,uVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x28) = iVar5;
		      uVar3 = System_Action_uint__TypeInfo;
		      iVar1 = func_ii_1082(iVar2,System_Action_uint__TypeInfo);
		      if (iVar1 == 0) {
		        System_Activator__CreateInstance(iVar2,uVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar1 + 0x2c);
		    uVar3 = unnamed_function_1417(System_Action_bool__TypeInfo);
		    System_Action_AsyncGPUReadbackRequest___Invoke
		              (uVar3,param1,
		               Method_Gameplay_BlitzTournament_Controller_BlitzTournamentViewMediator_BlockUIEventHandler__
		               ,0);
		    iVar2 = UnityEngine_UI_Image__set_sprite(uVar6,uVar3,0);
		    uVar3 = System_Action_bool__TypeInfo;
		    if (iVar2 == 0) {
		      *(undefined4 *)(iVar1 + 0x2c) = 0;
		      return;
		    }
		    iVar5 = func_ii_1082(iVar2,System_Action_bool__TypeInfo);
		    if (iVar5 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar1 + 0x2c) = iVar5;
		    uVar3 = System_Action_bool__TypeInfo;
		    iVar1 = func_ii_1082(iVar2,System_Action_bool__TypeInfo);
		    if (iVar1 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x17000F0B RID: 3851
		// (set) Token: 0x06004A7D RID: 19069 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000F0B")]
		public override Gameplay.BlitzTournament.Events.BlitzTournamentEvents Events
		{
			[Token(Token = "0x6004A7D")]
			[Address(RVA = "0x98DF", Offset = "0x98DF", VA = "0x98DF", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x17000F0C RID: 3852
		// (set) Token: 0x06004A7E RID: 19070 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000F0C")]
		public override BlitzTournamentWindow View
		{
			[Token(Token = "0x6004A7E")]
			[Address(RVA = "0x98E0", Offset = "0x98E0", VA = "0x98E0", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06004A7F RID: 19071 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A7F")]
		[Address(RVA = "0x98E1", Offset = "0x98E1", VA = "0x98E1")]
		private void RulesButtonClickHandler()
		{
		/* --- GHIDRA: RulesButtonClickHandler ---
		void Gameplay_BlitzTournament_Controller_BlitzTournamentViewMediator__RulesButtonClickHandler
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  if (param2 != 0) {
		    Gameplay_BlitzTournament_Controller_BlitzTournamentViewMediator__ResolveTournamentState
		              (param1,param2,param2);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004A80 RID: 19072 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A80")]
		[Address(RVA = "0x98E2", Offset = "0x98E2", VA = "0x98E2")]
		private void ResolveWindowState(BlitzTournamentWindow.WindowState windowState)
		{
		/* --- GHIDRA: ResolveWindowState ---
		void Gameplay_BlitzTournament_Controller_BlitzTournamentViewMediator__ResolveWindowState
		               (int *param1,uint param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a608e5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_BlitzTournament_Controller_BlitzTournamentViewMediator_CheckForClosePermission__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_ClosableBaseWindow_BlitzTournamentWindow_BlitzTournamentWindowArgs__get_BackButton__
		              );
		    Mono_Security_ASN1__get_Item(&System_Func_bool__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_WindowWhitCloseButton_BlitzTournamentWindow_BlitzTournamentWindowArgs__get_CloseButton__
		              );
		    DAT_ram_00a608e5 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_00 = unnamed_function_1417(System_Func_bool__TypeInfo);
		  System_Func_BackgroundSize___Invoke
		            (param1_00,param1,
		             Method_Gameplay_BlitzTournament_Controller_BlitzTournamentViewMediator_CheckForClosePermission__
		             ,0);
		  *(undefined4 *)(iVar1 + 0x50) = param1_00;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  System_Linq_Enumerable__First_object_(*(undefined4 *)(iVar1 + 0x34),param2 ^ 1,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  System_Linq_Enumerable__First_object_(*(undefined4 *)(iVar1 + 0x38),param2 ^ 1,0);
		  return;
		}
		*/

		}

		// Token: 0x06004A81 RID: 19073 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A81")]
		[Address(RVA = "0x98E3", Offset = "0x98E3", VA = "0x98E3")]
		private void BlockUIEventHandler(bool block)
		{
		/* --- GHIDRA: BlockUIEventHandler ---
		uint Gameplay_BlitzTournament_Controller_BlitzTournamentViewMediator__BlockUIEventHandler
		               (int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a608e6 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_BlitzTournamentModel__BlitzTournamentEvents__BlitzTournamentController__BlitzTournamentWindow__get_Model__
		              );
		    DAT_ram_00a608e6 = '\x01';
		  }
		  return (uint)(*(char *)(*(int *)(param1 + 8) + 0x20) == '\0');
		}
		*/

		}

		// Token: 0x06004A82 RID: 19074 RVA: 0x0000DB90 File Offset: 0x0000BD90
		[Token(Token = "0x6004A82")]
		[Address(RVA = "0x98E4", Offset = "0x98E4", VA = "0x98E4")]
		private bool CheckForClosePermission()
		{
		/* --- GHIDRA: CheckForClosePermission ---
		void Gameplay_BlitzTournament_Controller_BlitzTournamentViewMediator__CheckForClosePermission
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a608e7 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_BlitzTournamentModel__BlitzTournamentEvents__BlitzTournamentController__BlitzTournamentWindow__get_Model__
		              );
		    DAT_ram_00a608e7 = '\x01';
		  }
		  if (*(int *)(param1[2] + 0x1c) != 0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    Gameplay_BlitzTournament_View_BlitzTournamentInfoBox__SetState
		              (*(undefined4 *)(iVar1 + 0x44),param2,
		               *(undefined4 *)(*(int *)(*(int *)(param1[2] + 0x1c) + 8) + 0x18),param1);
		  }
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x06004A83 RID: 19075 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A83")]
		[Address(RVA = "0x98E5", Offset = "0x98E5", VA = "0x98E5")]
		private void FightersCountChangedEventHandler(uint count)
		{
		/* --- GHIDRA: FightersCountChangedEventHandler ---
		void Gameplay_BlitzTournament_Controller_BlitzTournamentViewMediator__FightersCountChangedEventHandler
		               (int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a608e8 == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a608e8 = '\x01';
		  }
		  iVar1 = *(int *)(param2 + 0xc);
		  if ((iVar1 != 0) && ((((iVar1 == 1 || (iVar1 == 2)) || (iVar1 == 3)) || (iVar1 != 4)))) {
		    param1_00 = *(undefined4 *)(param1 + 0x1c);
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UnityEngine_Object_TypeInfo);
		    }
		    iVar1 = func_ii_3812(param1_00,0,0);
		    if (iVar1 != 0) {
		      Gameplay_BlitzTournament_Controller_BlitzTournamentViewMediator__ResolveTournamentState
		                (param1,0,param1_00);
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004A84 RID: 19076 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A84")]
		[Address(RVA = "0x98E6", Offset = "0x98E6", VA = "0x98E6")]
		private void StateChangedEventHandler(ProtoStateChangedEvt evt)
		{
		/* --- GHIDRA: StateChangedEventHandler ---
		void Gameplay_BlitzTournament_Controller_BlitzTournamentViewMediator__StateChangedEventHandler
		               (int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a608e9 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_BlitzTournamentModel__BlitzTournamentEvents__BlitzTournamentController__BlitzTournamentWindow__get_Model__
		              );
		    DAT_ram_00a608e9 = '\x01';
		  }
		  Gameplay_BlitzTournament_Controller_BlitzTournamentViewMediator__SelectListElement
		            (param1,*(undefined4 *)(*(int *)(param1 + 8) + 0x1c),param1);
		  Gameplay_BlitzTournament_Controller_BlitzTournamentViewMediator__TournamentInfoReceivedEventHandler
		            (param1,*(undefined4 *)(*(int *)(param1 + 8) + 0x10),param1);
		  return;
		}
		*/

		}

		// Token: 0x06004A85 RID: 19077 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A85")]
		[Address(RVA = "0x98E7", Offset = "0x98E7", VA = "0x98E7")]
		private void TournamentInfoReceivedEventHandler()
		{
		/* --- GHIDRA: TournamentInfoReceivedEventHandler ---
		void Gameplay_BlitzTournament_Controller_BlitzTournamentViewMediator__TournamentInfoReceivedEventHandler
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int param4;
		  
		  if (DAT_ram_00a608ea == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_BlitzTournamentModel__BlitzTournamentEvents__BlitzTournamentController__BlitzTournamentWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_FirstOrDefault_BlitzTournamentListElement___);
		    Mono_Security_ASN1__get_Item(&System_Func_BlitzTournamentListElement__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_BlitzTournament_Controller_BlitzTournamentViewMediator___c__DisplayClass18_0__ResolveTournamentState_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_BlitzTournament_Controller_BlitzTournamentViewMediator___c__DisplayClass18_0_TypeInfo
		              );
		    DAT_ram_00a608ea = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (
		                    Gameplay_BlitzTournament_Controller_BlitzTournamentViewMediator___c__DisplayClass18_0_TypeInfo
		                    );
		  *(int *)(iVar1 + 8) = param2;
		  if (*(int *)(param2 + 0xc) == 1) {
		    iVar3 = param1[8];
		    uVar2 = unnamed_function_1417(System_Func_BlitzTournamentListElement__bool__TypeInfo);
		    System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		              (uVar2,iVar1,
		               Method_Gameplay_BlitzTournament_Controller_BlitzTournamentViewMediator___c__DisplayClass18_0__ResolveTournamentState_b__0__
		               ,0);
		    uVar2 = System_Func_object__bool____ctor
		                      (iVar3,uVar2,
		                       Method_System_Linq_Enumerable_FirstOrDefault_BlitzTournamentListElement___);
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UnityEngine_Object_TypeInfo);
		    }
		    iVar3 = UnityEngine_TextCore_Text_TextElement__get_textAsset(uVar2,0,0);
		    if (iVar3 != 0) {
		      Gameplay_BlitzTournament_Controller_BlitzTournamentViewMediator__TournamentSelectedEventHandler
		                (param1,uVar2,uVar2);
		      param4 = *param1;
		      iVar3 = (**(code **)((ulonglong)*(uint *)(param4 + 0x158) * 4))
		                        (param1,*(undefined4 *)(param4 + 0x15c));
		      Gameplay_BlitzTournament_View_BlitzTournamentInfoBox__SetState
		                (*(undefined4 *)(iVar3 + 0x44),*(undefined4 *)(*(int *)(iVar1 + 8) + 0x14),
		                 *(undefined4 *)(*(int *)(*(int *)(param1[2] + 0x1c) + 8) + 0x18),param4);
		      Gameplay_BlitzTournament_Controller_BlitzTournamentViewMediator__LeftQueueEventHandler
		                (param1,param4);
		      return;
		    }
		    iVar1 = *param1;
		    uVar2 = (**(code **)((ulonglong)*(uint *)(iVar1 + 0x148) * 4))
		                      (param1,*(undefined4 *)(iVar1 + 0x14c));
		    Gameplay_BlitzTournament_Controller_BlitzTournamentController__JoinQueueResultHandler
		              (uVar2,iVar1);
		    return;
		  }
		  if (*(int *)(param2 + 0xc) == 2) {
		    if (*(int *)(param2 + 0x18) == 1) {
		      iVar1 = param1[7];
		      if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		        func_ii_306000(UnityEngine_Object_TypeInfo);
		      }
		      iVar3 = func_ii_3812(iVar1,0,0);
		      if (iVar3 != 0) {
		        Gameplay_BlitzTournament_Controller_BlitzTournamentViewMediator__ResolveTournamentState
		                  (param1,0,iVar1);
		      }
		    }
		    else if (*(int *)(param2 + 0x18) == 2) {
		      iVar1 = param1[7];
		      if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		        func_ii_306000(UnityEngine_Object_TypeInfo);
		      }
		      iVar3 = func_ii_3812(iVar1,0,0);
		      if (iVar3 != 0) {
		        Gameplay_BlitzTournament_Controller_BlitzTournamentViewMediator__ResolveTournamentState
		                  (param1,0,iVar1);
		        return;
		      }
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004A86 RID: 19078 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A86")]
		[Address(RVA = "0x98E8", Offset = "0x98E8", VA = "0x98E8")]
		private void ResolveTournamentState(ProtoGetTournamentInfoAns.Types.TournamentInfo info)
		{
		/* --- GHIDRA: ResolveTournamentState ---
		void Gameplay_BlitzTournament_Controller_BlitzTournamentViewMediator__ResolveTournamentState
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a608eb == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_BlitzTournament_View_BlitzTournamentProgressWindow_BlitzTournamentProgressWindowArgs_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_PopupController_Show_BlitzTournamentProgressWindow___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12575);
		    DAT_ram_00a608eb = '\x01';
		  }
		  uVar1 = System_Uri___ctor(0);
		  uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar1,0);
		  iVar2 = unnamed_function_1417
		                    (
		                    Gameplay_BlitzTournament_View_BlitzTournamentProgressWindow_BlitzTournamentProgressWindowArgs_TypeInfo
		                    );
		  UI_Windows_BaseWindowArgs__Dispose(iVar2,0);
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x14c));
		  *(undefined4 *)(iVar2 + 0x1c) = param2;
		  *(undefined4 *)(iVar2 + 0x18) = uVar3;
		  iVar2 = Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		                    (uVar1,StringLiteral_12575,iVar2,
		                     Method_UI_Windows_PopupController_Show_BlitzTournamentProgressWindow___);
		  param1[7] = iVar2;
		  return;
		}
		*/

		}

		// Token: 0x06004A87 RID: 19079 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A87")]
		[Address(RVA = "0x98E9", Offset = "0x98E9", VA = "0x98E9")]
		private void ShowTournamentProgressWindow(BlitzTournamentWindow.WindowState windowState = BlitzTournamentWindow.WindowState.Default)
		{
		/* --- GHIDRA: ShowTournamentProgressWindow ---
		void Gameplay_BlitzTournament_Controller_BlitzTournamentViewMediator__ShowTournamentProgressWindow
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a608ec == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_BlitzTournamentModel__BlitzTournamentEvents__BlitzTournamentController__BlitzTournamentWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_BlitzTournament_Controller_BlitzTournamentViewMediator_EnterTournamentButtonClickHandler__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a608ec = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  func_ii_14558(*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x44) + 0x28) + 0xb4),0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_01 = *(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x44) + 0x28) + 0xb4);
		  param1_00 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (param1_00,param1,
		             Method_Gameplay_BlitzTournament_Controller_BlitzTournamentViewMediator_EnterTournamentButtonClickHandler__
		             ,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(param1_01,param1_00,0);
		  Gameplay_BlitzTournament_Controller_BlitzTournamentViewMediator__SelectListElement
		            (param1,*(undefined4 *)(param1[2] + 0x1c),param1);
		  return;
		}
		*/

		}

		// Token: 0x06004A88 RID: 19080 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A88")]
		[Address(RVA = "0x98EA", Offset = "0x98EA", VA = "0x98EA")]
		private void LeftQueueEventHandler()
		{
		/* --- GHIDRA: LeftQueueEventHandler ---
		void Gameplay_BlitzTournament_Controller_BlitzTournamentViewMediator__LeftQueueEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a608ed == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_BlitzTournament_Controller_BlitzTournamentViewMediator_ExitTournamentButtonClickHandler__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a608ed = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  func_ii_14558(*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x44) + 0x28) + 0xb4),0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_01 = *(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x44) + 0x28) + 0xb4);
		  param1_00 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (param1_00,param1,
		             Method_Gameplay_BlitzTournament_Controller_BlitzTournamentViewMediator_ExitTournamentButtonClickHandler__
		             ,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(param1_01,param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06004A89 RID: 19081 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A89")]
		[Address(RVA = "0x98EB", Offset = "0x98EB", VA = "0x98EB")]
		private void JoinedQueueEventHandler()
		{
		/* --- GHIDRA: JoinedQueueEventHandler ---
		void Gameplay_BlitzTournament_Controller_BlitzTournamentViewMediator__JoinedQueueEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a608ee == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_BlitzTournament_View_TournamentListElementBase_BlitzTournamentData__get_TournamentData__
		              );
		    DAT_ram_00a608ee = '\x01';
		  }
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		  param2_00 = UnityEngine_UI_Collections_IndexedSet_object___System_Collections_IEnumerable_GetEnumerator
		                        (*(undefined4 *)(param1[6] + 0x2c),0);
		  Gameplay_BlitzTournament_Controller_BlitzTournamentController__GetTournamentListResultHandler
		            (param1_00,param2_00,param1);
		  return;
		}
		*/

		}

		// Token: 0x06004A8A RID: 19082 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A8A")]
		[Address(RVA = "0x98EC", Offset = "0x98EC", VA = "0x98EC")]
		private void EnterTournamentButtonClickHandler()
		{
		/* --- GHIDRA: EnterTournamentButtonClickHandler ---
		void Gameplay_BlitzTournament_Controller_BlitzTournamentViewMediator__EnterTournamentButtonClickHandler
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		  Gameplay_BlitzTournament_Controller_BlitzTournamentController__JoinQueueResultHandler
		            (param1_00,param1);
		  return;
		}
		*/

		}

		// Token: 0x06004A8B RID: 19083 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A8B")]
		[Address(RVA = "0x98ED", Offset = "0x98ED", VA = "0x98ED")]
		private void ExitTournamentButtonClickHandler()
		{
		/* --- GHIDRA: ExitTournamentButtonClickHandler ---
		void Gameplay_BlitzTournament_Controller_BlitzTournamentViewMediator__ExitTournamentButtonClickHandler
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  int iVar2;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a608ef == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_BlitzTournamentModel__BlitzTournamentEvents__BlitzTournamentController__BlitzTournamentWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TournamentListElementBase__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_BlitzTournament_Controller_BlitzTournamentViewMediator_TournamentSelectedEventHandler__
		              );
		    DAT_ram_00a608ef = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param2_00 = *(undefined4 *)(param1[2] + 0xc);
		  param1_00 = unnamed_function_1417(System_Action_TournamentListElementBase__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_BlitzTournament_Controller_BlitzTournamentViewMediator_TournamentSelectedEventHandler__
		             ,0);
		  iVar2 = Gameplay_BlitzTournament_View_BlitzTournamentWindow__OnClose
		                    (uVar1,param2_00,param1_00,param1);
		  param1[8] = iVar2;
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(iVar2 + 0x44),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,1,0);
		  Gameplay_BlitzTournament_Controller_BlitzTournamentViewMediator__TournamentSelectedEventHandler
		            (param1,*(undefined4 *)(param1[8] + 0x10),param1);
		  return;
		}
		*/

		}

		// Token: 0x06004A8C RID: 19084 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A8C")]
		[Address(RVA = "0x98EE", Offset = "0x98EE", VA = "0x98EE")]
		private void TournamentListReceivedEventHandler()
		{
		/* --- GHIDRA: TournamentListReceivedEventHandler ---
		void Gameplay_BlitzTournament_Controller_BlitzTournamentViewMediator__TournamentListReceivedEventHandler
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param3_00;
		  
		  if (DAT_ram_00a608f0 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_BlitzTournamentModel__BlitzTournamentEvents__BlitzTournamentController__BlitzTournamentWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3614);
		    DAT_ram_00a608f0 = '\x01';
		  }
		  if (*(char *)(*(int *)(param1 + 8) + 0x20) != '\0') {
		    uVar1 = System_Uri___ctor(0);
		    uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar1,0);
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    param3_00 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_3614,1,0,1,0,0,0,0);
		    Core_Application_App__get_ToastController(uVar1,6,param3_00,0);
		    return;
		  }
		  Gameplay_BlitzTournament_Controller_BlitzTournamentViewMediator__TournamentSelectedEventHandler
		            (param1,param2,param1);
		  return;
		}
		*/

		}

		// Token: 0x06004A8D RID: 19085 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A8D")]
		[Address(RVA = "0x98EF", Offset = "0x98EF", VA = "0x98EF")]
		private void TournamentSelectedEventHandler(TournamentListElementBase listElement)
		{
		/* --- GHIDRA: TournamentSelectedEventHandler ---
		void Gameplay_BlitzTournament_Controller_BlitzTournamentViewMediator__TournamentSelectedEventHandler
		               (int param1,int *param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a608f1 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_BlitzTournament_View_BlitzTournamentListElement_TypeInfo)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_BlitzTournament_View_TournamentListElementBase_BlitzTournamentData__SetSelected__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_BlitzTournament_View_TournamentListElementBase_BlitzTournamentData__get_TournamentData__
		              );
		    DAT_ram_00a608f1 = '\x01';
		  }
		  if (*(int *)(param1 + 0x18) != 0) {
		    Gameplay_BlitzTournament_View_TournamentListElementBase_object___Init
		              (*(int *)(param1 + 0x18),0,
		               Method_Gameplay_BlitzTournament_View_TournamentListElementBase_BlitzTournamentData__SetSelected__
		              );
		  }
		  if (param2 != (int *)0x0) {
		    if (((uint)*(byte *)(*param2 + 0xb8) <
		         (uint)*(byte *)(Gameplay_BlitzTournament_View_BlitzTournamentListElement_TypeInfo + 0xb8))
		       || (*(int *)(*(int *)(*param2 + 100) +
		                    (uint)*(byte *)(
		                                   Gameplay_BlitzTournament_View_BlitzTournamentListElement_TypeInfo
		                                   + 0xb8) * 4 + -4) !=
		           Gameplay_BlitzTournament_View_BlitzTournamentListElement_TypeInfo)) {
		      System_Activator__CreateInstance
		                (param2,Gameplay_BlitzTournament_View_BlitzTournamentListElement_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  Gameplay_BlitzTournament_View_TournamentListElementBase_object___Init
		            (param2,1,
		             Method_Gameplay_BlitzTournament_View_TournamentListElementBase_BlitzTournamentData__SetSelected__
		            );
		  *(int **)(param1 + 0x18) = param2;
		  Gameplay_BlitzTournament_Controller_BlitzTournamentViewMediator__SelectListElement
		            (param1,param2[0xb],param2);
		  return;
		}
		*/

		}

		// Token: 0x06004A8E RID: 19086 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A8E")]
		[Address(RVA = "0x98F0", Offset = "0x98F0", VA = "0x98F0")]
		private void SelectListElement(TournamentListElementBase listElement)
		{
		/* --- GHIDRA: SelectListElement ---
		void Gameplay_BlitzTournament_Controller_BlitzTournamentViewMediator__SelectListElement
		               (int *param1,int param2,undefined4 param3)
		
		{
		  char cVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 *puVar4;
		  undefined4 uVar5;
		  int iVar6;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a608f2 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_BlitzTournamentModel__BlitzTournamentEvents__BlitzTournamentController__BlitzTournamentWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3607);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3612);
		    DAT_ram_00a608f2 = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = *(int *)(iVar2 + 0x44);
		  puVar4 = &StringLiteral_3607;
		  cVar1 = *(char *)(param1[2] + 0x14);
		  if (cVar1 == '\0') {
		    puVar4 = &StringLiteral_3612;
		  }
		  uVar5 = *puVar4;
		  if (cVar1 == '\0') {
		    if ((DAT_ram_00a60896 & 1) == 0) {
		      Mono_Security_ASN1__get_Item
		                (&Method_UI_MonoBehaviourWithStates_BlitzTournamentInfoBox_State__set_CurrentState__
		                );
		      DAT_ram_00a60896 = 1;
		    }
		    Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		              (iVar2,3,
		               Method_UI_MonoBehaviourWithStates_BlitzTournamentInfoBox_State__set_CurrentState__);
		  }
		  else {
		    iVar6 = iVar2;
		    if (cVar1 == '\0') {
		      iVar6 = 0;
		    }
		    if ((DAT_ram_00a60896 & 1) == 0) {
		      Mono_Security_ASN1__get_Item
		                (&Method_UI_MonoBehaviourWithStates_BlitzTournamentInfoBox_State__set_CurrentState__
		                );
		      DAT_ram_00a60896 = 1;
		    }
		    Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		              (iVar6,4,
		               Method_UI_MonoBehaviourWithStates_BlitzTournamentInfoBox_State__set_CurrentState__);
		  }
		  uVar3 = Core_Extensions_Dict_BaseOptionExt__GetExternalPrice(*(undefined4 *)(param2 + 8),0);
		  UnityEngine_Component__GetComponentInChildren_object_(*(undefined4 *)(iVar2 + 0x1c),uVar3,0);
		  uVar3 = Core_Extensions_Dict_BlitzTournamentsDicExt__GetTitle(*(undefined4 *)(param2 + 8),0);
		  UnityEngine_Component__GetComponentInChildren_object_(*(undefined4 *)(iVar2 + 0x20),uVar3,0);
		  uVar3 = *(undefined4 *)(*(int *)(param2 + 8) + 0x10);
		  param2_00 = *(undefined4 *)(param1[2] + 8);
		  if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_Money_TypeInfo);
		  }
		  uVar3 = Core_Money_Money__op_Explicit(uVar3,0);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar5 = Core_Extensions_Dict_CultDicExt__GetTitle(uVar5,1,0,1,0,0,0,0);
		  if (DAT_ram_00a60898 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_Component_GetComponentInChildren_TextMeshProUGUI___);
		    DAT_ram_00a60898 = '\x01';
		  }
		  UI_Price_Price__SetColor(*(undefined4 *)(*(int *)(iVar2 + 0x28) + 0xb8),param2_00,uVar3,0);
		  uVar3 = UI_Rewards_AbstractRewardsRender__SetRewards
		                    (*(undefined4 *)(iVar2 + 0x28),
		                     Method_UnityEngine_Component_GetComponentInChildren_TextMeshProUGUI___);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar3,uVar5,0);
		  UI_Rewards_AbstractRewardsRender__get_Rewards
		            (*(undefined4 *)(iVar2 + 0x24),*(undefined4 *)(param2 + 0xc),0);
		  iVar6 = **(int **)(iVar2 + 0x24);
		  (**(code **)((ulonglong)*(uint *)(iVar6 + 0xf0) * 4))
		            (*(int **)(iVar2 + 0x24),*(undefined4 *)(iVar6 + 0xf4));
		  return;
		}
		*/

		}

		// Token: 0x06004A8F RID: 19087 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A8F")]
		[Address(RVA = "0x98F1", Offset = "0x98F1", VA = "0x98F1")]
		private void UpdateInfoBox(BlitzTournamentData data)
		{
		}

		// Token: 0x0400288A RID: 10378
		[Token(Token = "0x400288A")]
		private const string LOCALIZATION_ABANDON = "BLITZ/ABANDON";

		// Token: 0x0400288B RID: 10379
		[Token(Token = "0x400288B")]
		private const string LOCALIZATION_ENTER_TOURNAMENT = "BLITZ/ENTER_TOURNAMENT";

		// Token: 0x0400288C RID: 10380
		[Token(Token = "0x400288C")]
		private const string LOCALIZATION_LEAVE_QUEUE_FIRST = "BLITZ/LEAVE_QUEUE_FIRST";

		// Token: 0x0400288D RID: 10381
		[Token(Token = "0x400288D")]
		[FieldOffset(Offset = "0x18")]
		private BlitzTournamentListElement _selectedTournament;

		// Token: 0x0400288E RID: 10382
		[Token(Token = "0x400288E")]
		[FieldOffset(Offset = "0x1C")]
		private BlitzTournamentProgressWindow _tournamentProgressWindow;

		// Token: 0x0400288F RID: 10383
		[Token(Token = "0x400288F")]
		[FieldOffset(Offset = "0x20")]
		private BlitzTournamentListElement[] _spawnedElements;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Events ---
		void Gameplay_BlitzTournament_Controller_BlitzTournamentViewMediator__set_Events
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a608e3 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_BlitzTournamentModel__BlitzTournamentEvents__BlitzTournamentController__BlitzTournamentWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_BlitzTournamentModel__BlitzTournamentEvents__BlitzTournamentController__BlitzTournamentWindow__set_View__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseWindow_BlitzTournamentWindow_BlitzTournamentWindowArgs__get_WindowArgs__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_BlitzTournament_Controller_BlitzTournamentViewMediator_EnterTournamentButtonClickHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_BlitzTournament_Controller_BlitzTournamentViewMediator_RulesButtonClickHandler__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a608e3 = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    func_ii_14558(*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x44) + 0x28) + 0xb4),0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x4c) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_BlitzTournament_Controller_BlitzTournamentViewMediator_RulesButtonClickHandler__
		               ,0);
		    UnityEngine_Events_UnityAction___ctor(uVar3,uVar1,0);
		  }
		  param1[5] = param2;
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x4c) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_BlitzTournament_Controller_BlitzTournamentViewMediator_RulesButtonClickHandler__
		               ,0);
		    Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x44) + 0x28) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_BlitzTournament_Controller_BlitzTournamentViewMediator_EnterTournamentButtonClickHandler__
		               ,0);
		    Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    UI_Tabs_TabBar__HandleSelected
		              (*(undefined4 *)(iVar2 + 0x48),*(undefined4 *)(param1[2] + 0x2c),0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    Gameplay_GameEvents_Model_GameEventData__get_ContainsArtifactRewards
		              (*(undefined4 *)(iVar2 + 0x48),0,0,0);
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    iVar2 = func_ii_8093(uVar1,
		                         Method_UI_Windows_BaseWindow_BlitzTournamentWindow_BlitzTournamentWindowArgs__get_WindowArgs__
		                        );
		    if (*(int *)(iVar2 + 0x1c) != 0) {
		      Gameplay_BlitzTournament_Controller_BlitzTournamentViewMediator__ResolveTournamentState
		                (param1,*(int *)(iVar2 + 0x1c),param1);
		    }
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x14c));
		    Gameplay_BlitzTournament_Controller_BlitzTournamentController__GetTournamentInfoResultHandler
		              (uVar1,param1);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_View ---
		void Gameplay_BlitzTournament_Controller_BlitzTournamentViewMediator__set_View
		               (undefined4 param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *param1_00;
		  int iVar4;
		  
		  if (DAT_ram_00a608e4 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19433);
		    Mono_Security_ASN1__get_Item(&StringLiteral_20574);
		    DAT_ram_00a608e4 = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x178);
		        goto code_r0x81cf81ec;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x81cf81ec:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  uVar3 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar3,0);
		  uVar3 = Core_Extensions_Dict_DictExt__GetResourceSetParameter(uVar3,StringLiteral_20574,0);
		  Core_ExternAppMethods__OpenPaymentWindow(uVar3,StringLiteral_19433,0,0);
		  return;
		}
		*/

}
