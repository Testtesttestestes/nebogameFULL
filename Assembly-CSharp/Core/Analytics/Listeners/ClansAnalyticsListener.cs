using System;
using System.Collections.Generic;
using Core.Events.Scopes;
using Il2CppDummyDll;

namespace Core.Analytics.Listeners
{
	// Token: 0x020012C8 RID: 4808
	[Token(Token = "0x20012C8")]
	public class ClansAnalyticsListener : AbstractAnalyticsListener
	{
		// Token: 0x1700172C RID: 5932
		// (get) Token: 0x06007245 RID: 29253 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700172C")]
		protected override string Theme
		{
			[Token(Token = "0x6007245")]
			[Address(RVA = "0xBC4E", Offset = "0xBC4E", VA = "0xBC4E", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x06007246 RID: 29254 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007246")]
		[Address(RVA = "0xBC4F", Offset = "0xBC4F", VA = "0xBC4F", Slot = "10")]
		public override void Init()
		{
		/* --- GHIDRA: Init ---
		void Core_Analytics_Listeners_ClansAnalyticsListener__Init(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int *param1_00;
		  int iVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a5959b == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ClansScope_BaseClansEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ClansScope_ClanWarsEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ClansScope_ClanIsleEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ClansScope_ClansEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ClansScope_ClanCombatFinishEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ClansScope_ClanWarsDeclarationEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ClansScope_ClanSpellEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ClansScope_ClanCombatEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ClansScope_ClanBuildingEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ClansScope_CreateClanEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_UserScope_BaseUserEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_ClansAnalyticsListener_AddMoneyToClanEventHandler__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_ClansAnalyticsListener_BuyClanSlotEventHandler__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Analytics_Listeners_ClansAnalyticsListener_ClanCombatFinishedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Analytics_Listeners_ClansAnalyticsListener_ClanCombatStartedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_ClansAnalyticsListener_ConfirmJoinClanEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_ClansAnalyticsListener_CreateClanEventHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_ClansAnalyticsListener_DissolveClanEventHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_ClansAnalyticsListener_JoinRequestEventHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_ClansAnalyticsListener_LeaveClanEventHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_ClansAnalyticsListener_StartClanBuildEventHandler__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_ClansAnalyticsListener_StartLearnSpellEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_ClansAnalyticsListener_TakeGolemOutEventHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_ClansAnalyticsListener_UseSpellEventHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_ClansAnalyticsListener_WarDeclaredEventHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_ClansAnalyticsListener_WarPayoffEventHandler__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Analytics_Listeners_ClansAnalyticsListener_WarPrepareCancelSpeedupEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Analytics_Listeners_ClansAnalyticsListener_WarPrepareSpeedupEventHandler__
		              );
		    DAT_ram_00a5959b = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x84);
		  uVar5 = *(undefined4 *)(iVar4 + 8);
		  uVar2 = unnamed_function_1417(System_Action_ClansScope_CreateClanEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_ClansAnalyticsListener_CreateClanEventHandler__,0);
		  iVar1 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_ClansScope_CreateClanEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 8) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_ClansScope_CreateClanEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 8) = iVar3;
		    uVar2 = System_Action_ClansScope_CreateClanEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_ClansScope_CreateClanEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x84);
		  uVar5 = *(undefined4 *)(iVar4 + 0xc);
		  uVar2 = unnamed_function_1417(System_Action_ClansScope_ClansEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_ClansAnalyticsListener_JoinRequestEventHandler__,0);
		  iVar1 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_ClansScope_ClansEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0xc) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_ClansScope_ClansEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0xc) = iVar3;
		    uVar2 = System_Action_ClansScope_ClansEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_ClansScope_ClansEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x84);
		  uVar5 = *(undefined4 *)(iVar4 + 0x10);
		  uVar2 = unnamed_function_1417(System_Action_UserScope_BaseUserEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_ClansAnalyticsListener_ConfirmJoinClanEventHandler__,0)
		  ;
		  iVar1 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_UserScope_BaseUserEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x10) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_UserScope_BaseUserEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x10) = iVar3;
		    uVar2 = System_Action_UserScope_BaseUserEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_UserScope_BaseUserEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x84);
		  uVar5 = *(undefined4 *)(iVar4 + 0x14);
		  uVar2 = unnamed_function_1417(System_Action_ClansScope_ClansEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_ClansAnalyticsListener_AddMoneyToClanEventHandler__,0);
		  iVar1 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_ClansScope_ClansEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x14) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_ClansScope_ClansEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x14) = iVar3;
		    uVar2 = System_Action_ClansScope_ClansEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_ClansScope_ClansEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x84);
		  uVar5 = *(undefined4 *)(iVar4 + 0x18);
		  uVar2 = unnamed_function_1417(System_Action_ClansScope_ClanBuildingEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_ClansAnalyticsListener_StartClanBuildEventHandler__,0);
		  iVar1 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_ClansScope_ClanBuildingEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x18) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_ClansScope_ClanBuildingEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x18) = iVar3;
		    uVar2 = System_Action_ClansScope_ClanBuildingEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_ClansScope_ClanBuildingEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x84);
		  uVar5 = *(undefined4 *)(iVar4 + 0x1c);
		  uVar2 = unnamed_function_1417(System_Action_ClansScope_ClanIsleEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_ClansAnalyticsListener_BuyClanSlotEventHandler__,0);
		  iVar1 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_ClansScope_ClanIsleEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x1c) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_ClansScope_ClanIsleEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x1c) = iVar3;
		    uVar2 = System_Action_ClansScope_ClanIsleEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_ClansScope_ClanIsleEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x84);
		  uVar5 = *(undefined4 *)(iVar4 + 0x20);
		  uVar2 = unnamed_function_1417(System_Action_ClansScope_ClanSpellEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_ClansAnalyticsListener_StartLearnSpellEventHandler__,0)
		  ;
		  iVar1 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_ClansScope_ClanSpellEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x20) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_ClansScope_ClanSpellEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x20) = iVar3;
		    uVar2 = System_Action_ClansScope_ClanSpellEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_ClansScope_ClanSpellEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x84);
		  uVar5 = *(undefined4 *)(iVar4 + 0x24);
		  uVar2 = unnamed_function_1417(System_Action_ClansScope_ClanSpellEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_ClansAnalyticsListener_UseSpellEventHandler__,0);
		  iVar1 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_ClansScope_ClanSpellEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x24) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_ClansScope_ClanSpellEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x24) = iVar3;
		    uVar2 = System_Action_ClansScope_ClanSpellEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_ClansScope_ClanSpellEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x84);
		  uVar5 = *(undefined4 *)(iVar4 + 0x28);
		  uVar2 = unnamed_function_1417(System_Action_ClansScope_ClanWarsDeclarationEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_ClansAnalyticsListener_WarDeclaredEventHandler__,0);
		  iVar1 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_ClansScope_ClanWarsDeclarationEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x28) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_ClansScope_ClanWarsDeclarationEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x28) = iVar3;
		    uVar2 = System_Action_ClansScope_ClanWarsDeclarationEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_ClansScope_ClanWarsDeclarationEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x84);
		  uVar5 = *(undefined4 *)(iVar4 + 0x2c);
		  uVar2 = unnamed_function_1417(System_Action_ClansScope_ClanWarsEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_ClansAnalyticsListener_WarPrepareSpeedupEventHandler__,
		             0);
		  iVar1 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_ClansScope_ClanWarsEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x2c) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_ClansScope_ClanWarsEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x2c) = iVar3;
		    uVar2 = System_Action_ClansScope_ClanWarsEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_ClansScope_ClanWarsEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x84);
		  uVar5 = *(undefined4 *)(iVar4 + 0x30);
		  uVar2 = unnamed_function_1417(System_Action_ClansScope_ClanWarsEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_ClansAnalyticsListener_WarPrepareCancelSpeedupEventHandler__
		             ,0);
		  iVar1 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_ClansScope_ClanWarsEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x30) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_ClansScope_ClanWarsEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x30) = iVar3;
		    uVar2 = System_Action_ClansScope_ClanWarsEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_ClansScope_ClanWarsEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x84);
		  uVar5 = *(undefined4 *)(iVar4 + 0x34);
		  uVar2 = unnamed_function_1417(System_Action_ClansScope_ClanWarsEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_ClansAnalyticsListener_WarPayoffEventHandler__,0);
		  iVar1 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_ClansScope_ClanWarsEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x34) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_ClansScope_ClanWarsEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x34) = iVar3;
		    uVar2 = System_Action_ClansScope_ClanWarsEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_ClansScope_ClanWarsEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x84);
		  uVar5 = *(undefined4 *)(iVar4 + 0x38);
		  uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_ClansAnalyticsListener_TakeGolemOutEventHandler__,0);
		  param1_00 = (int *)func_ii_7048(uVar5,uVar2,0);
		  iVar1 = System_Action_TypeInfo;
		  if (param1_00 == (int *)0x0) {
		    *(undefined4 *)(iVar4 + 0x38) = 0;
		  }
		  else if ((System_Action_TypeInfo != *param1_00) ||
		          (*(int **)(iVar4 + 0x38) = param1_00, *param1_00 != iVar1)) {
		    System_Activator__CreateInstance(param1_00,iVar1);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x84);
		  uVar5 = *(undefined4 *)(iVar4 + 0x3c);
		  uVar2 = unnamed_function_1417(System_Action_ClansScope_BaseClansEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_ClansAnalyticsListener_LeaveClanEventHandler__,0);
		  iVar1 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_ClansScope_BaseClansEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x3c) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_ClansScope_BaseClansEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x3c) = iVar3;
		    uVar2 = System_Action_ClansScope_BaseClansEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_ClansScope_BaseClansEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x84);
		  uVar5 = *(undefined4 *)(iVar4 + 0x40);
		  uVar2 = unnamed_function_1417(System_Action_ClansScope_BaseClansEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_ClansAnalyticsListener_DissolveClanEventHandler__,0);
		  iVar1 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_ClansScope_BaseClansEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x40) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_ClansScope_BaseClansEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x40) = iVar3;
		    uVar2 = System_Action_ClansScope_BaseClansEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_ClansScope_BaseClansEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x84);
		  uVar5 = *(undefined4 *)(iVar4 + 0x44);
		  uVar2 = unnamed_function_1417(System_Action_ClansScope_ClanCombatEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_ClansAnalyticsListener_ClanCombatStartedEventHandler__,
		             0);
		  iVar1 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_ClansScope_ClanCombatEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x44) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_ClansScope_ClanCombatEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x44) = iVar3;
		    uVar2 = System_Action_ClansScope_ClanCombatEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_ClansScope_ClanCombatEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x84);
		  uVar5 = *(undefined4 *)(iVar4 + 0x48);
		  uVar2 = unnamed_function_1417(System_Action_ClansScope_ClanCombatFinishEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_ClansAnalyticsListener_ClanCombatFinishedEventHandler__
		             ,0);
		  iVar1 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_ClansScope_ClanCombatFinishEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x48) = 0;
		    return;
		  }
		  iVar3 = func_ii_1082(iVar1,System_Action_ClansScope_ClanCombatFinishEventArgs__TypeInfo);
		  if (iVar3 != 0) {
		    *(int *)(iVar4 + 0x48) = iVar3;
		    uVar2 = System_Action_ClansScope_ClanCombatFinishEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_ClansScope_ClanCombatFinishEventArgs__TypeInfo);
		    if (iVar4 != 0) {
		      return;
		    }
		    System_Activator__CreateInstance(iVar1,uVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  System_Activator__CreateInstance(iVar1,uVar2);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06007247 RID: 29255 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007247")]
		[Address(RVA = "0xBC50", Offset = "0xBC50", VA = "0xBC50", Slot = "11")]
		protected override void Deinit()
		{
		/* --- GHIDRA: Deinit ---
		void Core_Analytics_Listeners_ClansAnalyticsListener__Deinit
		               (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 param1_00;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  int *param1_01;
		  int iVar5;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5959c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_21208);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26155);
		    Mono_Security_ASN1__get_Item(&StringLiteral_21201);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22035);
		    DAT_ram_00a5959c = '\x01';
		  }
		  param1_00 = Core_Analytics_Listeners_AbstractAnalyticsListener__RemoveService(param1,0);
		  local_8 = *(undefined8 *)(param2 + 0x10);
		  uVar2 = func_ii_1081(DAT_ram_00a66968,&local_8);
		  func_ii_2946(param1_00,StringLiteral_21201,uVar2,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  func_ii_2946(param1_00,StringLiteral_21208,*(undefined4 *)(param2 + 0x18),
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  Gameplay_Boss_Model_BossInfo_BossAttackOption_BossAttackOptionVariant__get_Price
		            (param1,param1_00,*(undefined4 *)(param2 + 0x1c),StringLiteral_26155,0);
		  param1_01 = (int *)param1[2];
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xec));
		  uVar2 = StringLiteral_22035;
		  iVar5 = *param1_01;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd8);
		        goto code_r0x810317e4;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(param1_01,Core_Analytics_Service_IAnalyticsApi_TypeInfo,3);
		code_r0x810317e4:
		  (**(code **)((ulonglong)*puVar4 * 4))(param1_01,uVar3,uVar2,param1_00,puVar4[1]);
		  return;
		}
		*/

		}

		// Token: 0x06007248 RID: 29256 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007248")]
		[Address(RVA = "0xBC51", Offset = "0xBC51", VA = "0xBC51")]
		private void CreateClanEventHandler(ClansScope.CreateClanEventArgs args)
		{
		/* --- GHIDRA: CreateClanEventHandler ---
		void Core_Analytics_Listeners_ClansAnalyticsListener__CreateClanEventHandler
		               (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 param1_00;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  uint *puVar5;
		  int *param1_01;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5959d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_24934);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26155);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22636);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22635);
		    DAT_ram_00a5959d = '\x01';
		  }
		  param1_00 = Core_Analytics_Listeners_AbstractAnalyticsListener__RemoveService(param1,0);
		  iVar2 = System_Xml_XmlElement__get_ParentNode(param2,0);
		  local_8 = *(undefined8 *)(iVar2 + 0x10);
		  uVar3 = func_ii_8783(&local_8,0);
		  func_ii_2946(param1_00,StringLiteral_22635,uVar3,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  iVar2 = System_Xml_XmlElement__get_ParentNode(param2,0);
		  func_ii_2946(param1_00,StringLiteral_22636,*(undefined4 *)(iVar2 + 0x18),
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  Gameplay_Boss_Model_BossInfo_BossAttackOption_BossAttackOptionVariant__get_Price
		            (param1,param1_00,*(undefined4 *)(param2 + 0x14),StringLiteral_26155,0);
		  param1_01 = (int *)param1[2];
		  uVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xec));
		  uVar3 = StringLiteral_24934;
		  iVar2 = *param1_01;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar5 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0xd8);
		        goto code_r0x81031962;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar5 = (uint *)func_ii_1080(param1_01,Core_Analytics_Service_IAnalyticsApi_TypeInfo,3);
		code_r0x81031962:
		  (**(code **)((ulonglong)*puVar5 * 4))(param1_01,uVar4,uVar3,param1_00,puVar5[1]);
		  return;
		}
		*/

		}

		// Token: 0x06007249 RID: 29257 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007249")]
		[Address(RVA = "0xBC52", Offset = "0xBC52", VA = "0xBC52")]
		private void JoinRequestEventHandler(ClansScope.ClansEventArgs args)
		{
		/* --- GHIDRA: JoinRequestEventHandler ---
		void Core_Analytics_Listeners_ClansAnalyticsListener__JoinRequestEventHandler
		               (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 param1_00;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  int *param1_01;
		  int iVar5;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5959e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_21893);
		    Mono_Security_ASN1__get_Item(&StringLiteral_21205);
		    DAT_ram_00a5959e = '\x01';
		  }
		  param1_00 = Core_Analytics_Listeners_AbstractAnalyticsListener__RemoveService(param1,0);
		  local_8 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                      (*(undefined4 *)(param2 + 0x10),0);
		  uVar2 = func_ii_8783(&local_8,0);
		  func_ii_2946(param1_00,StringLiteral_21205,uVar2,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  param1_01 = (int *)param1[2];
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xec));
		  uVar2 = StringLiteral_21893;
		  iVar5 = *param1_01;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd8);
		        goto code_r0x81031a94;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(param1_01,Core_Analytics_Service_IAnalyticsApi_TypeInfo,3);
		code_r0x81031a94:
		  (**(code **)((ulonglong)*puVar4 * 4))(param1_01,uVar3,uVar2,param1_00,puVar4[1]);
		  return;
		}
		*/

		}

		// Token: 0x0600724A RID: 29258 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600724A")]
		[Address(RVA = "0xBC53", Offset = "0xBC53", VA = "0xBC53")]
		private void ConfirmJoinClanEventHandler(UserScope.BaseUserEventArgs args)
		{
		/* --- GHIDRA: ConfirmJoinClanEventHandler ---
		void Core_Analytics_Listeners_ClansAnalyticsListener__ConfirmJoinClanEventHandler
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  uint uVar2;
		  undefined4 param2_00;
		  undefined4 uVar3;
		  uint *puVar4;
		  int *param1_00;
		  int iVar5;
		  
		  if (DAT_ram_00a5959f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26155);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19732);
		    DAT_ram_00a5959f = '\x01';
		  }
		  param2_00 = Core_Analytics_Listeners_AbstractAnalyticsListener__RemoveService(param1,0);
		  Gameplay_Boss_Model_BossInfo_BossAttackOption_BossAttackOptionVariant__get_Price
		            (param1,param2_00,*(undefined4 *)(param2 + 0x14),StringLiteral_26155,0);
		  param1_00 = (int *)param1[2];
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xec));
		  uVar1 = StringLiteral_19732;
		  iVar5 = *param1_00;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar2 = 0;
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar2 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar2 * 8 + 4) * 8 + iVar5 + 0xd8);
		        goto code_r0x81031b95;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar2);
		  }
		  puVar4 = (uint *)func_ii_1080(param1_00,Core_Analytics_Service_IAnalyticsApi_TypeInfo,3);
		code_r0x81031b95:
		  (**(code **)((ulonglong)*puVar4 * 4))(param1_00,uVar3,uVar1,param2_00,puVar4[1]);
		  return;
		}
		*/

		}

		// Token: 0x0600724B RID: 29259 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600724B")]
		[Address(RVA = "0xBC54", Offset = "0xBC54", VA = "0xBC54")]
		private void AddMoneyToClanEventHandler(ClansScope.ClansEventArgs args)
		{
		/* --- GHIDRA: AddMoneyToClanEventHandler ---
		void Core_Analytics_Listeners_ClansAnalyticsListener__AddMoneyToClanEventHandler
		               (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 param1_00;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  int *param1_01;
		  int iVar5;
		  undefined4 local_8;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a595a0 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_20791);
		    Mono_Security_ASN1__get_Item(&StringLiteral_20790);
		    Mono_Security_ASN1__get_Item(&StringLiteral_20792);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27414);
		    DAT_ram_00a595a0 = '\x01';
		  }
		  param1_00 = Core_Analytics_Listeners_AbstractAnalyticsListener__RemoveService(param1,0);
		  local_4 = Newtonsoft_Json_Converters_XDeclarationWrapper__get_Encoding
		                      (*(undefined4 *)(param2 + 0x14),0);
		  uVar2 = func_ii_1081(DAT_ram_00a66958,&local_4);
		  func_ii_2946(param1_00,StringLiteral_20790,uVar2,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  iVar5 = **(int **)(param2 + 0x14);
		  uVar2 = (**(code **)((ulonglong)*(uint *)(iVar5 + 0xe8) * 4))
		                    (*(int **)(param2 + 0x14),*(undefined4 *)(iVar5 + 0xec));
		  func_ii_2946(param1_00,StringLiteral_20791,uVar2,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  local_8 = UnityEngine_AndroidJavaObject___GetRawObject(*(undefined4 *)(param2 + 0x14),0);
		  uVar2 = func_ii_1081(DAT_ram_00a66958,&local_8);
		  func_ii_2946(param1_00,StringLiteral_20792,uVar2,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  param1_01 = (int *)param1[2];
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xec));
		  uVar2 = StringLiteral_27414;
		  iVar5 = *param1_01;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd8);
		        goto code_r0x81031d44;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(param1_01,Core_Analytics_Service_IAnalyticsApi_TypeInfo,3);
		code_r0x81031d44:
		  (**(code **)((ulonglong)*puVar4 * 4))(param1_01,uVar3,uVar2,param1_00,puVar4[1]);
		  return;
		}
		*/

		}

		// Token: 0x0600724C RID: 29260 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600724C")]
		[Address(RVA = "0xBC55", Offset = "0xBC55", VA = "0xBC55")]
		private void StartClanBuildEventHandler(ClansScope.ClanBuildingEventArgs args)
		{
		/* --- GHIDRA: StartClanBuildEventHandler ---
		void Core_Analytics_Listeners_ClansAnalyticsListener__StartClanBuildEventHandler
		               (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 param1_00;
		  undefined4 uVar2;
		  int iVar3;
		  undefined4 uVar4;
		  uint *puVar5;
		  int *param1_01;
		  longlong local_10;
		  undefined4 local_8;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a595a1 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_21978);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26155);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22881);
		    Mono_Security_ASN1__get_Item(&StringLiteral_20806);
		    Mono_Security_ASN1__get_Item(&StringLiteral_20027);
		    DAT_ram_00a595a1 = '\x01';
		  }
		  param1_00 = Core_Analytics_Listeners_AbstractAnalyticsListener__RemoveService(param1,0);
		  local_4 = *(undefined4 *)(*(int *)(param2 + 0x10) + 0x1c);
		  uVar2 = func_ii_1081(DAT_ram_00a66958,&local_4);
		  func_ii_2946(param1_00,StringLiteral_20027,uVar2,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  local_8 = 1;
		  uVar2 = func_ii_1081(DAT_ram_00a66954,&local_8);
		  func_ii_2946(param1_00,StringLiteral_21978,uVar2,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  uVar1 = *(uint *)(*(int *)(param2 + 0x10) + 0x1c);
		  iVar3 = Core_Extensions_ClanInfoExt__GetHonorRating
		                    (*(undefined4 *)(*(int *)(param2 + 0x10) + 0x10),0);
		  local_10 = (ulonglong)uVar1 - (longlong)iVar3;
		  uVar2 = func_ii_1081(DAT_ram_00a66964,&local_10);
		  func_ii_2946(param1_00,StringLiteral_22881,uVar2,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  Gameplay_Boss_Model_BossInfo_BossAttackOption_BossAttackOptionVariant__get_Price
		            (param1,param1_00,*(undefined4 *)(param2 + 0x14),StringLiteral_26155,0);
		  param1_01 = (int *)param1[2];
		  uVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xec));
		  uVar2 = StringLiteral_20806;
		  iVar3 = *param1_01;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar5 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0xd8);
		        goto code_r0x81031f1b;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar5 = (uint *)func_ii_1080(param1_01,Core_Analytics_Service_IAnalyticsApi_TypeInfo,3);
		code_r0x81031f1b:
		  (**(code **)((ulonglong)*puVar5 * 4))(param1_01,uVar4,uVar2,param1_00,puVar5[1]);
		  return;
		}
		*/

		}

		// Token: 0x0600724D RID: 29261 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600724D")]
		[Address(RVA = "0xBC56", Offset = "0xBC56", VA = "0xBC56")]
		private void BuyClanSlotEventHandler(ClansScope.ClanIsleEventArgs args)
		{
		/* --- GHIDRA: BuyClanSlotEventHandler ---
		void Core_Analytics_Listeners_ClansAnalyticsListener__BuyClanSlotEventHandler
		               (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 param1_00;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  int *param1_01;
		  int iVar5;
		  undefined4 local_8;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a595a2 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26155);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27415);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27349);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27347);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27348);
		    DAT_ram_00a595a2 = '\x01';
		  }
		  param1_00 = Core_Analytics_Listeners_AbstractAnalyticsListener__RemoveService(param1,0);
		  local_4 = UnityEngine_AndroidJavaObject___GetRawObject(*(undefined4 *)(param2 + 0x10),0);
		  uVar2 = func_ii_1081(DAT_ram_00a66958,&local_4);
		  func_ii_2946(param1_00,StringLiteral_27347,uVar2,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  iVar5 = **(int **)(param2 + 0x10);
		  local_8 = (**(code **)((ulonglong)*(uint *)(iVar5 + 0xf0) * 4))
		                      (*(int **)(param2 + 0x10),*(undefined4 *)(iVar5 + 0xf4));
		  uVar2 = func_ii_1081(DAT_ram_00a66958,&local_8);
		  func_ii_2946(param1_00,StringLiteral_27348,uVar2,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  uVar2 = Core_Extensions_Dict_SpellDicExt__GetAnimationOnAvatarCanvasAssetId
		                    (*(undefined4 *)(*(int *)(param2 + 0x10) + 0xc),0);
		  func_ii_2946(param1_00,StringLiteral_27349,uVar2,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  Gameplay_Boss_Model_BossInfo_BossAttackOption_BossAttackOptionVariant__get_Price
		            (param1,param1_00,*(undefined4 *)(param2 + 0x14),StringLiteral_26155,0);
		  param1_01 = (int *)param1[2];
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xec));
		  uVar2 = StringLiteral_27415;
		  iVar5 = *param1_01;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd8);
		        goto code_r0x810320f3;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(param1_01,Core_Analytics_Service_IAnalyticsApi_TypeInfo,3);
		code_r0x810320f3:
		  (**(code **)((ulonglong)*puVar4 * 4))(param1_01,uVar3,uVar2,param1_00,puVar4[1]);
		  return;
		}
		*/

		}

		// Token: 0x0600724E RID: 29262 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600724E")]
		[Address(RVA = "0xBC57", Offset = "0xBC57", VA = "0xBC57")]
		private void StartLearnSpellEventHandler(ClansScope.ClanSpellEventArgs args)
		{
		/* --- GHIDRA: StartLearnSpellEventHandler ---
		void Core_Analytics_Listeners_ClansAnalyticsListener__StartLearnSpellEventHandler
		               (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 param1_00;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  int *param1_01;
		  int iVar5;
		  undefined4 local_8;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a595a3 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26155);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27349);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27347);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28162);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27348);
		    DAT_ram_00a595a3 = '\x01';
		  }
		  param1_00 = Core_Analytics_Listeners_AbstractAnalyticsListener__RemoveService(param1,0);
		  local_4 = UnityEngine_AndroidJavaObject___GetRawObject(*(undefined4 *)(param2 + 0x10),0);
		  uVar2 = func_ii_1081(DAT_ram_00a66958,&local_4);
		  func_ii_2946(param1_00,StringLiteral_27347,uVar2,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  iVar5 = **(int **)(param2 + 0x10);
		  local_8 = (**(code **)((ulonglong)*(uint *)(iVar5 + 0xf0) * 4))
		                      (*(int **)(param2 + 0x10),*(undefined4 *)(iVar5 + 0xf4));
		  uVar2 = func_ii_1081(DAT_ram_00a66958,&local_8);
		  func_ii_2946(param1_00,StringLiteral_27348,uVar2,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  uVar2 = Core_Extensions_Dict_SpellDicExt__GetAnimationOnAvatarCanvasAssetId
		                    (*(undefined4 *)(*(int *)(param2 + 0x10) + 0xc),0);
		  func_ii_2946(param1_00,StringLiteral_27349,uVar2,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  Gameplay_Boss_Model_BossInfo_BossAttackOption_BossAttackOptionVariant__get_Price
		            (param1,param1_00,*(undefined4 *)(param2 + 0x14),StringLiteral_26155,0);
		  param1_01 = (int *)param1[2];
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xec));
		  uVar2 = StringLiteral_28162;
		  iVar5 = *param1_01;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd8);
		        goto code_r0x810322cb;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(param1_01,Core_Analytics_Service_IAnalyticsApi_TypeInfo,3);
		code_r0x810322cb:
		  (**(code **)((ulonglong)*puVar4 * 4))(param1_01,uVar3,uVar2,param1_00,puVar4[1]);
		  return;
		}
		*/

		}

		// Token: 0x0600724F RID: 29263 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600724F")]
		[Address(RVA = "0xBC58", Offset = "0xBC58", VA = "0xBC58")]
		private void UseSpellEventHandler(ClansScope.ClanSpellEventArgs args)
		{
		/* --- GHIDRA: UseSpellEventHandler ---
		void Core_Analytics_Listeners_ClansAnalyticsListener__UseSpellEventHandler
		               (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 param1_00;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  int *param1_01;
		  int iVar5;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a595a4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28320);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22576);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19988);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19989);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22575);
		    DAT_ram_00a595a4 = '\x01';
		  }
		  param1_00 = Core_Analytics_Listeners_AbstractAnalyticsListener__RemoveService(param1,0);
		  local_8 = *(undefined8 *)(*(int *)(param2 + 0x10) + 0x10);
		  uVar2 = func_ii_8783(&local_8,0);
		  func_ii_2946(param1_00,StringLiteral_19988,uVar2,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  func_ii_2946(param1_00,StringLiteral_19989,*(undefined4 *)(*(int *)(param2 + 0x10) + 0x18),
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  local_10 = *(undefined8 *)(param2 + 0x18);
		  uVar2 = func_ii_1081(DAT_ram_00a66968,&local_10);
		  func_ii_2946(param1_00,StringLiteral_22575,uVar2,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  func_ii_2946(param1_00,StringLiteral_22576,*(undefined4 *)(param2 + 0x20),
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  param1_01 = (int *)param1[2];
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xec));
		  uVar2 = StringLiteral_28320;
		  iVar5 = *param1_01;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd8);
		        goto code_r0x8103247c;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(param1_01,Core_Analytics_Service_IAnalyticsApi_TypeInfo,3);
		code_r0x8103247c:
		  (**(code **)((ulonglong)*puVar4 * 4))(param1_01,uVar3,uVar2,param1_00,puVar4[1]);
		  return;
		}
		*/

		}

		// Token: 0x06007250 RID: 29264 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007250")]
		[Address(RVA = "0xBC59", Offset = "0xBC59", VA = "0xBC59")]
		private void WarDeclaredEventHandler(ClansScope.ClanWarsDeclarationEventArgs args)
		{
		/* --- GHIDRA: WarDeclaredEventHandler ---
		void Core_Analytics_Listeners_ClansAnalyticsListener__WarDeclaredEventHandler
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  uint uVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  uint *puVar5;
		  int *param1_00;
		  int iVar6;
		  
		  if (DAT_ram_00a595a5 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28324);
		    DAT_ram_00a595a5 = '\x01';
		  }
		  uVar3 = Core_Analytics_Listeners_ClansAnalyticsListener__ClanCombatFinishedEventHandler
		                    (param1,param2,param1);
		  param1_00 = (int *)param1[2];
		  uVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xec));
		  uVar1 = StringLiteral_28324;
		  iVar6 = *param1_00;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar2 = 0;
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8)) {
		        puVar5 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8 + 4) * 8 + iVar6 + 0xd8);
		        goto code_r0x81032562;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar2);
		  }
		  puVar5 = (uint *)func_ii_1080(param1_00,Core_Analytics_Service_IAnalyticsApi_TypeInfo,3);
		code_r0x81032562:
		  (**(code **)((ulonglong)*puVar5 * 4))(param1_00,uVar4,uVar1,uVar3,puVar5[1]);
		  return;
		}
		*/

		}

		// Token: 0x06007251 RID: 29265 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007251")]
		[Address(RVA = "0xBC5A", Offset = "0xBC5A", VA = "0xBC5A")]
		private void WarPrepareSpeedupEventHandler(ClansScope.ClanWarsEventArgs args)
		{
		/* --- GHIDRA: WarPrepareSpeedupEventHandler ---
		void Core_Analytics_Listeners_ClansAnalyticsListener__WarPrepareSpeedupEventHandler
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  uint uVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  uint *puVar5;
		  int *param1_00;
		  int iVar6;
		  
		  if (DAT_ram_00a595a6 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28323);
		    DAT_ram_00a595a6 = '\x01';
		  }
		  uVar3 = Core_Analytics_Listeners_ClansAnalyticsListener__ClanCombatFinishedEventHandler
		                    (param1,param2,param1);
		  param1_00 = (int *)param1[2];
		  uVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xec));
		  uVar1 = StringLiteral_28323;
		  iVar6 = *param1_00;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar2 = 0;
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8)) {
		        puVar5 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8 + 4) * 8 + iVar6 + 0xd8);
		        goto code_r0x81032741;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar2);
		  }
		  puVar5 = (uint *)func_ii_1080(param1_00,Core_Analytics_Service_IAnalyticsApi_TypeInfo,3);
		code_r0x81032741:
		  (**(code **)((ulonglong)*puVar5 * 4))(param1_00,uVar4,uVar1,uVar3,puVar5[1]);
		  return;
		}
		*/

		}

		// Token: 0x06007252 RID: 29266 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007252")]
		[Address(RVA = "0xBC5B", Offset = "0xBC5B", VA = "0xBC5B")]
		private void WarPrepareCancelSpeedupEventHandler(ClansScope.ClanWarsEventArgs args)
		{
		/* --- GHIDRA: WarPrepareCancelSpeedupEventHandler ---
		void Core_Analytics_Listeners_ClansAnalyticsListener__WarPrepareCancelSpeedupEventHandler
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  uint uVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  uint *puVar5;
		  int *param1_00;
		  int iVar6;
		  
		  if (DAT_ram_00a595a7 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28321);
		    DAT_ram_00a595a7 = '\x01';
		  }
		  uVar3 = Core_Analytics_Listeners_ClansAnalyticsListener__ClanCombatFinishedEventHandler
		                    (param1,param2,param1);
		  param1_00 = (int *)param1[2];
		  uVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xec));
		  uVar1 = StringLiteral_28321;
		  iVar6 = *param1_00;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar2 = 0;
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8)) {
		        puVar5 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8 + 4) * 8 + iVar6 + 0xd8);
		        goto code_r0x81032820;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar2);
		  }
		  puVar5 = (uint *)func_ii_1080(param1_00,Core_Analytics_Service_IAnalyticsApi_TypeInfo,3);
		code_r0x81032820:
		  (**(code **)((ulonglong)*puVar5 * 4))(param1_00,uVar4,uVar1,uVar3,puVar5[1]);
		  return;
		}
		*/

		}

		// Token: 0x06007253 RID: 29267 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007253")]
		[Address(RVA = "0xBC5C", Offset = "0xBC5C", VA = "0xBC5C")]
		private void WarPayoffEventHandler(ClansScope.ClanWarsEventArgs args)
		{
		/* --- GHIDRA: WarPayoffEventHandler ---
		void Core_Analytics_Listeners_ClansAnalyticsListener__WarPayoffEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  uint uVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  uint *puVar5;
		  int *param1_00;
		  int iVar6;
		  
		  if (DAT_ram_00a595a8 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27625);
		    DAT_ram_00a595a8 = '\x01';
		  }
		  uVar3 = Core_Analytics_Listeners_AbstractAnalyticsListener__RemoveService(param1,0);
		  param1_00 = (int *)param1[2];
		  uVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xec));
		  uVar1 = StringLiteral_27625;
		  iVar6 = *param1_00;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar2 = 0;
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8)) {
		        puVar5 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8 + 4) * 8 + iVar6 + 0xd8);
		        goto code_r0x810328fd;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar2);
		  }
		  puVar5 = (uint *)func_ii_1080(param1_00,Core_Analytics_Service_IAnalyticsApi_TypeInfo,3);
		code_r0x810328fd:
		  (**(code **)((ulonglong)*puVar5 * 4))(param1_00,uVar4,uVar1,uVar3,puVar5[1]);
		  return;
		}
		*/

		}

		// Token: 0x06007254 RID: 29268 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007254")]
		[Address(RVA = "0xBC5D", Offset = "0xBC5D", VA = "0xBC5D")]
		private void TakeGolemOutEventHandler()
		{
		/* --- GHIDRA: TakeGolemOutEventHandler ---
		void Core_Analytics_Listeners_ClansAnalyticsListener__TakeGolemOutEventHandler
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 param1_00;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  uint *puVar5;
		  int *param1_01;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a595a9 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_23068);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25054);
		    Mono_Security_ASN1__get_Item(&StringLiteral_23067);
		    DAT_ram_00a595a9 = '\x01';
		  }
		  param1_00 = Core_Analytics_Listeners_AbstractAnalyticsListener__RemoveService(param1,0);
		  iVar2 = System_Xml_XmlElement__get_ParentNode(param2,0);
		  local_8 = *(undefined8 *)(iVar2 + 0x10);
		  uVar3 = func_ii_8783(&local_8,0);
		  func_ii_2946(param1_00,StringLiteral_23067,uVar3,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  iVar2 = System_Xml_XmlElement__get_ParentNode(param2,0);
		  func_ii_2946(param1_00,StringLiteral_23068,*(undefined4 *)(iVar2 + 0x18),
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  param1_01 = (int *)param1[2];
		  uVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xec));
		  uVar3 = StringLiteral_25054;
		  iVar2 = *param1_01;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar5 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0xd8);
		        goto code_r0x81032a55;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar5 = (uint *)func_ii_1080(param1_01,Core_Analytics_Service_IAnalyticsApi_TypeInfo,3);
		code_r0x81032a55:
		  (**(code **)((ulonglong)*puVar5 * 4))(param1_01,uVar4,uVar3,param1_00,puVar5[1]);
		  return;
		}
		*/

		}

		// Token: 0x06007255 RID: 29269 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007255")]
		[Address(RVA = "0xBC5E", Offset = "0xBC5E", VA = "0xBC5E")]
		private void LeaveClanEventHandler(ClansScope.BaseClansEventArgs args)
		{
		/* --- GHIDRA: LeaveClanEventHandler ---
		void Core_Analytics_Listeners_ClansAnalyticsListener__LeaveClanEventHandler
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 param1_00;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  uint *puVar5;
		  int *param1_01;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a595aa == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22601);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22602);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22698);
		    DAT_ram_00a595aa = '\x01';
		  }
		  param1_00 = Core_Analytics_Listeners_AbstractAnalyticsListener__RemoveService(param1,0);
		  iVar2 = System_Xml_XmlElement__get_ParentNode(param2,0);
		  local_8 = *(undefined8 *)(iVar2 + 0x10);
		  uVar3 = func_ii_8783(&local_8,0);
		  func_ii_2946(param1_00,StringLiteral_22601,uVar3,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  iVar2 = System_Xml_XmlElement__get_ParentNode(param2,0);
		  func_ii_2946(param1_00,StringLiteral_22602,*(undefined4 *)(iVar2 + 0x18),
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  param1_01 = (int *)param1[2];
		  uVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xec));
		  uVar3 = StringLiteral_22698;
		  iVar2 = *param1_01;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar5 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0xd8);
		        goto code_r0x81032bb4;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar5 = (uint *)func_ii_1080(param1_01,Core_Analytics_Service_IAnalyticsApi_TypeInfo,3);
		code_r0x81032bb4:
		  (**(code **)((ulonglong)*puVar5 * 4))(param1_01,uVar4,uVar3,param1_00,puVar5[1]);
		  return;
		}
		*/

		}

		// Token: 0x06007256 RID: 29270 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007256")]
		[Address(RVA = "0xBC5F", Offset = "0xBC5F", VA = "0xBC5F")]
		private void DissolveClanEventHandler(ClansScope.BaseClansEventArgs args)
		{
		/* --- GHIDRA: DissolveClanEventHandler ---
		void Core_Analytics_Listeners_ClansAnalyticsListener__DissolveClanEventHandler
		               (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 param1_00;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  int *param1_01;
		  int iVar5;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a595ab == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25862);
		    Mono_Security_ASN1__get_Item(&StringLiteral_21196);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25861);
		    DAT_ram_00a595ab = '\x01';
		  }
		  param1_00 = Core_Analytics_Listeners_AbstractAnalyticsListener__RemoveService(param1,0);
		  local_8 = *(undefined8 *)(*(int *)(param2 + 0x10) + 0x10);
		  uVar2 = func_ii_8783(&local_8,0);
		  func_ii_2946(param1_00,StringLiteral_25861,uVar2,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  func_ii_2946(param1_00,StringLiteral_25862,*(undefined4 *)(*(int *)(param2 + 0x10) + 0x18),
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  param1_01 = (int *)param1[2];
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xec));
		  uVar2 = StringLiteral_21196;
		  iVar5 = *param1_01;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd8);
		        goto code_r0x81032d09;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(param1_01,Core_Analytics_Service_IAnalyticsApi_TypeInfo,3);
		code_r0x81032d09:
		  (**(code **)((ulonglong)*puVar4 * 4))(param1_01,uVar3,uVar2,param1_00,puVar4[1]);
		  return;
		}
		*/

		}

		// Token: 0x06007257 RID: 29271 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007257")]
		[Address(RVA = "0xBC60", Offset = "0xBC60", VA = "0xBC60")]
		private void ClanCombatStartedEventHandler(ClansScope.ClanCombatEventArgs args)
		{
		/* --- GHIDRA: ClanCombatStartedEventHandler ---
		void Core_Analytics_Listeners_ClansAnalyticsListener__ClanCombatStartedEventHandler
		               (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 param1_00;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  int *param1_01;
		  int iVar5;
		  byte local_9;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a595ac == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Core_Analytics_Listeners_ClansAnalyticsListener_CombatResult_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_21195);
		    Mono_Security_ASN1__get_Item(&StringLiteral_24820);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25862);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25861);
		    DAT_ram_00a595ac = '\x01';
		  }
		  param1_00 = Core_Analytics_Listeners_AbstractAnalyticsListener__RemoveService(param1,0);
		  local_9 = 2;
		  if (*(int *)(*(int *)(param2 + 0x14) + 0x24) != 1) {
		    local_9 = *(byte *)(*(int *)(param2 + 0x14) + 8) ^ 1;
		  }
		  local_8 = *(undefined8 *)(*(int *)(param2 + 0x10) + 0x10);
		  uVar1 = 0;
		  uVar2 = func_ii_8783(&local_8,0);
		  func_ii_2946(param1_00,StringLiteral_25861,uVar2,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  func_ii_2946(param1_00,StringLiteral_25862,*(undefined4 *)(*(int *)(param2 + 0x10) + 0x18),
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  uVar2 = func_ii_1081(Core_Analytics_Listeners_ClansAnalyticsListener_CombatResult_TypeInfo,
		                       &local_9);
		  func_ii_2946(param1_00,StringLiteral_24820,uVar2,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  param1_01 = (int *)param1[2];
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xec));
		  uVar2 = StringLiteral_21195;
		  iVar5 = *param1_01;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd8);
		        goto code_r0x81032ebd;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(param1_01,Core_Analytics_Service_IAnalyticsApi_TypeInfo,3);
		code_r0x81032ebd:
		  (**(code **)((ulonglong)*puVar4 * 4))(param1_01,uVar3,uVar2,param1_00,puVar4[1]);
		  return;
		}
		*/

		}

		// Token: 0x06007258 RID: 29272 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007258")]
		[Address(RVA = "0xBC61", Offset = "0xBC61", VA = "0xBC61")]
		private void ClanCombatFinishedEventHandler(ClansScope.ClanCombatFinishEventArgs args)
		{
		/* --- GHIDRA: ClanCombatFinishedEventHandler ---
		undefined4
		Core_Analytics_Listeners_ClansAnalyticsListener__ClanCombatFinishedEventHandler
		          (undefined4 param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  undefined4 uVar1;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a595ad == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22576);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19988);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19989);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22575);
		    DAT_ram_00a595ad = '\x01';
		  }
		  param1_00 = Core_Analytics_Listeners_AbstractAnalyticsListener__RemoveService(param1,0);
		  local_8 = *(undefined8 *)(*(int *)(param2 + 0x10) + 0x10);
		  uVar1 = func_ii_8783(&local_8,0);
		  func_ii_2946(param1_00,StringLiteral_19988,uVar1,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  func_ii_2946(param1_00,StringLiteral_19989,*(undefined4 *)(*(int *)(param2 + 0x10) + 0x18),
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  local_8 = *(undefined8 *)(*(int *)(param2 + 0x14) + 0x10);
		  uVar1 = func_ii_8783(&local_8,0);
		  func_ii_2946(param1_00,StringLiteral_22575,uVar1,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  func_ii_2946(param1_00,StringLiteral_22576,*(undefined4 *)(*(int *)(param2 + 0x14) + 0x18),
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  return param1_00;
		}
		*/

		}

		// Token: 0x06007259 RID: 29273 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007259")]
		[Address(RVA = "0xBC62", Offset = "0xBC62", VA = "0xBC62")]
		private Dictionary<string, object> PopulateClanWarProperties(ClansScope.ClanWarsEventArgs args)
		{
			return null;
		}

		// Token: 0x0600725A RID: 29274 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600725A")]
		[Address(RVA = "0xBC63", Offset = "0xBC63", VA = "0xBC63")]
		public ClansAnalyticsListener()
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Core_Analytics_Listeners_ClansAnalyticsListener___ctor(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a595ae == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_21411);
		    DAT_ram_00a595ae = '\x01';
		  }
		  return StringLiteral_21411;
		}
		*/

		}

		// Token: 0x04003BE1 RID: 15329
		[Token(Token = "0x4003BE1")]
		private const string CREATE_CLAN = "create_clan";

		// Token: 0x04003BE2 RID: 15330
		[Token(Token = "0x4003BE2")]
		private const string JOIN_REQUEST_CLAN = "join_request_clan";

		// Token: 0x04003BE3 RID: 15331
		[Token(Token = "0x4003BE3")]
		private const string CONFIRM_JOIN_CLAN = "confirm_join_clan";

		// Token: 0x04003BE4 RID: 15332
		[Token(Token = "0x4003BE4")]
		private const string ADD_MONEY_TO_CLAN = "add_money_to_clan";

		// Token: 0x04003BE5 RID: 15333
		[Token(Token = "0x4003BE5")]
		private const string START_CLAN_BUILD = "start_clan_build";

		// Token: 0x04003BE6 RID: 15334
		[Token(Token = "0x4003BE6")]
		private const string BUY_CLAN_SLOT = "buy_clan_slot";

		// Token: 0x04003BE7 RID: 15335
		[Token(Token = "0x4003BE7")]
		private const string START_CLAN_LEARN = "start_clan_learn";

		// Token: 0x04003BE8 RID: 15336
		[Token(Token = "0x4003BE8")]
		private const string USE_CLAN_SPELL = "use_clan_spell";

		// Token: 0x04003BE9 RID: 15337
		[Token(Token = "0x4003BE9")]
		private const string WAR_DECLARATION = "war_declaration";

		// Token: 0x04003BEA RID: 15338
		[Token(Token = "0x4003BEA")]
		private const string WAR_PREPARE_SPEEDUP = "war_prepare_speedup";

		// Token: 0x04003BEB RID: 15339
		[Token(Token = "0x4003BEB")]
		private const string WAR_PREPARE_CANCEL_SPEEDUP = "war_prepare_cancel_speedup";

		// Token: 0x04003BEC RID: 15340
		[Token(Token = "0x4003BEC")]
		private const string WAR_PAY_OFF = "war_pay_off";

		// Token: 0x04003BED RID: 15341
		[Token(Token = "0x4003BED")]
		private const string TAKE_GOLEM_OUT = "take_golem_out";

		// Token: 0x04003BEE RID: 15342
		[Token(Token = "0x4003BEE")]
		private const string LEAVE_CLAN = "leave_clan";

		// Token: 0x04003BEF RID: 15343
		[Token(Token = "0x4003BEF")]
		private const string DISSOLVE_CLAN = "dissolve_clan";

		// Token: 0x04003BF0 RID: 15344
		[Token(Token = "0x4003BF0")]
		private const string CLAN_COMBAT_STARTED = "clan_combat_started";

		// Token: 0x04003BF1 RID: 15345
		[Token(Token = "0x4003BF1")]
		private const string CLAN_COMBAT_FINISHED = "clan_combat_finished";

		// Token: 0x020012C9 RID: 4809
		[Token(Token = "0x20012C9")]
		private enum CombatResult : byte
		{
			// Token: 0x04003BF3 RID: 15347
			[Token(Token = "0x4003BF3")]
			@true,
			// Token: 0x04003BF4 RID: 15348
			[Token(Token = "0x4003BF4")]
			@false,
			// Token: 0x04003BF5 RID: 15349
			[Token(Token = "0x4003BF5")]
			draw
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Theme ---
		void Core_Analytics_Listeners_ClansAnalyticsListener__get_Theme(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int *param1_00;
		  int iVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a5959a == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ClansScope_BaseClansEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ClansScope_ClanWarsEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ClansScope_ClanIsleEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ClansScope_ClansEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ClansScope_ClanCombatFinishEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ClansScope_ClanWarsDeclarationEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ClansScope_ClanSpellEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ClansScope_ClanCombatEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ClansScope_ClanBuildingEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ClansScope_CreateClanEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_UserScope_BaseUserEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_ClansAnalyticsListener_AddMoneyToClanEventHandler__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_ClansAnalyticsListener_BuyClanSlotEventHandler__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Analytics_Listeners_ClansAnalyticsListener_ClanCombatFinishedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Analytics_Listeners_ClansAnalyticsListener_ClanCombatStartedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_ClansAnalyticsListener_ConfirmJoinClanEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_ClansAnalyticsListener_CreateClanEventHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_ClansAnalyticsListener_DissolveClanEventHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_ClansAnalyticsListener_JoinRequestEventHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_ClansAnalyticsListener_LeaveClanEventHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_ClansAnalyticsListener_StartClanBuildEventHandler__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_ClansAnalyticsListener_StartLearnSpellEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_ClansAnalyticsListener_TakeGolemOutEventHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_ClansAnalyticsListener_UseSpellEventHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_ClansAnalyticsListener_WarDeclaredEventHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_ClansAnalyticsListener_WarPayoffEventHandler__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Analytics_Listeners_ClansAnalyticsListener_WarPrepareCancelSpeedupEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Analytics_Listeners_ClansAnalyticsListener_WarPrepareSpeedupEventHandler__
		              );
		    DAT_ram_00a5959a = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x84);
		  uVar5 = *(undefined4 *)(iVar4 + 8);
		  uVar2 = unnamed_function_1417(System_Action_ClansScope_CreateClanEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_ClansAnalyticsListener_CreateClanEventHandler__,0);
		  iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_ClansScope_CreateClanEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 8) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_ClansScope_CreateClanEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 8) = iVar3;
		    uVar2 = System_Action_ClansScope_CreateClanEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_ClansScope_CreateClanEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x84);
		  uVar5 = *(undefined4 *)(iVar4 + 0xc);
		  uVar2 = unnamed_function_1417(System_Action_ClansScope_ClansEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_ClansAnalyticsListener_JoinRequestEventHandler__,0);
		  iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_ClansScope_ClansEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0xc) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_ClansScope_ClansEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0xc) = iVar3;
		    uVar2 = System_Action_ClansScope_ClansEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_ClansScope_ClansEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x84);
		  uVar5 = *(undefined4 *)(iVar4 + 0x10);
		  uVar2 = unnamed_function_1417(System_Action_UserScope_BaseUserEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_ClansAnalyticsListener_ConfirmJoinClanEventHandler__,0)
		  ;
		  iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_UserScope_BaseUserEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x10) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_UserScope_BaseUserEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x10) = iVar3;
		    uVar2 = System_Action_UserScope_BaseUserEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_UserScope_BaseUserEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x84);
		  uVar5 = *(undefined4 *)(iVar4 + 0x14);
		  uVar2 = unnamed_function_1417(System_Action_ClansScope_ClansEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_ClansAnalyticsListener_AddMoneyToClanEventHandler__,0);
		  iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_ClansScope_ClansEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x14) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_ClansScope_ClansEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x14) = iVar3;
		    uVar2 = System_Action_ClansScope_ClansEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_ClansScope_ClansEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x84);
		  uVar5 = *(undefined4 *)(iVar4 + 0x18);
		  uVar2 = unnamed_function_1417(System_Action_ClansScope_ClanBuildingEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_ClansAnalyticsListener_StartClanBuildEventHandler__,0);
		  iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_ClansScope_ClanBuildingEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x18) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_ClansScope_ClanBuildingEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x18) = iVar3;
		    uVar2 = System_Action_ClansScope_ClanBuildingEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_ClansScope_ClanBuildingEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x84);
		  uVar5 = *(undefined4 *)(iVar4 + 0x1c);
		  uVar2 = unnamed_function_1417(System_Action_ClansScope_ClanIsleEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_ClansAnalyticsListener_BuyClanSlotEventHandler__,0);
		  iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_ClansScope_ClanIsleEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x1c) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_ClansScope_ClanIsleEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x1c) = iVar3;
		    uVar2 = System_Action_ClansScope_ClanIsleEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_ClansScope_ClanIsleEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x84);
		  uVar5 = *(undefined4 *)(iVar4 + 0x20);
		  uVar2 = unnamed_function_1417(System_Action_ClansScope_ClanSpellEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_ClansAnalyticsListener_StartLearnSpellEventHandler__,0)
		  ;
		  iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_ClansScope_ClanSpellEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x20) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_ClansScope_ClanSpellEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x20) = iVar3;
		    uVar2 = System_Action_ClansScope_ClanSpellEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_ClansScope_ClanSpellEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x84);
		  uVar5 = *(undefined4 *)(iVar4 + 0x24);
		  uVar2 = unnamed_function_1417(System_Action_ClansScope_ClanSpellEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_ClansAnalyticsListener_UseSpellEventHandler__,0);
		  iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_ClansScope_ClanSpellEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x24) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_ClansScope_ClanSpellEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x24) = iVar3;
		    uVar2 = System_Action_ClansScope_ClanSpellEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_ClansScope_ClanSpellEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x84);
		  uVar5 = *(undefined4 *)(iVar4 + 0x28);
		  uVar2 = unnamed_function_1417(System_Action_ClansScope_ClanWarsDeclarationEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_ClansAnalyticsListener_WarDeclaredEventHandler__,0);
		  iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_ClansScope_ClanWarsDeclarationEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x28) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_ClansScope_ClanWarsDeclarationEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x28) = iVar3;
		    uVar2 = System_Action_ClansScope_ClanWarsDeclarationEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_ClansScope_ClanWarsDeclarationEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x84);
		  uVar5 = *(undefined4 *)(iVar4 + 0x2c);
		  uVar2 = unnamed_function_1417(System_Action_ClansScope_ClanWarsEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_ClansAnalyticsListener_WarPrepareSpeedupEventHandler__,
		             0);
		  iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_ClansScope_ClanWarsEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x2c) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_ClansScope_ClanWarsEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x2c) = iVar3;
		    uVar2 = System_Action_ClansScope_ClanWarsEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_ClansScope_ClanWarsEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x84);
		  uVar5 = *(undefined4 *)(iVar4 + 0x30);
		  uVar2 = unnamed_function_1417(System_Action_ClansScope_ClanWarsEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_ClansAnalyticsListener_WarPrepareCancelSpeedupEventHandler__
		             ,0);
		  iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_ClansScope_ClanWarsEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x30) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_ClansScope_ClanWarsEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x30) = iVar3;
		    uVar2 = System_Action_ClansScope_ClanWarsEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_ClansScope_ClanWarsEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x84);
		  uVar5 = *(undefined4 *)(iVar4 + 0x34);
		  uVar2 = unnamed_function_1417(System_Action_ClansScope_ClanWarsEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_ClansAnalyticsListener_WarPayoffEventHandler__,0);
		  iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_ClansScope_ClanWarsEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x34) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_ClansScope_ClanWarsEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x34) = iVar3;
		    uVar2 = System_Action_ClansScope_ClanWarsEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_ClansScope_ClanWarsEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x84);
		  uVar5 = *(undefined4 *)(iVar4 + 0x38);
		  uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_ClansAnalyticsListener_TakeGolemOutEventHandler__,0);
		  param1_00 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  iVar1 = System_Action_TypeInfo;
		  if (param1_00 == (int *)0x0) {
		    *(undefined4 *)(iVar4 + 0x38) = 0;
		  }
		  else if ((System_Action_TypeInfo != *param1_00) ||
		          (*(int **)(iVar4 + 0x38) = param1_00, *param1_00 != iVar1)) {
		    System_Activator__CreateInstance(param1_00,iVar1);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x84);
		  uVar5 = *(undefined4 *)(iVar4 + 0x3c);
		  uVar2 = unnamed_function_1417(System_Action_ClansScope_BaseClansEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_ClansAnalyticsListener_LeaveClanEventHandler__,0);
		  iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_ClansScope_BaseClansEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x3c) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_ClansScope_BaseClansEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x3c) = iVar3;
		    uVar2 = System_Action_ClansScope_BaseClansEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_ClansScope_BaseClansEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x84);
		  uVar5 = *(undefined4 *)(iVar4 + 0x40);
		  uVar2 = unnamed_function_1417(System_Action_ClansScope_BaseClansEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_ClansAnalyticsListener_DissolveClanEventHandler__,0);
		  iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_ClansScope_BaseClansEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x40) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_ClansScope_BaseClansEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x40) = iVar3;
		    uVar2 = System_Action_ClansScope_BaseClansEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_ClansScope_BaseClansEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x84);
		  uVar5 = *(undefined4 *)(iVar4 + 0x44);
		  uVar2 = unnamed_function_1417(System_Action_ClansScope_ClanCombatEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_ClansAnalyticsListener_ClanCombatStartedEventHandler__,
		             0);
		  iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_ClansScope_ClanCombatEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x44) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_ClansScope_ClanCombatEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x44) = iVar3;
		    uVar2 = System_Action_ClansScope_ClanCombatEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_ClansScope_ClanCombatEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x84);
		  uVar5 = *(undefined4 *)(iVar4 + 0x48);
		  uVar2 = unnamed_function_1417(System_Action_ClansScope_ClanCombatFinishEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_ClansAnalyticsListener_ClanCombatFinishedEventHandler__
		             ,0);
		  iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_ClansScope_ClanCombatFinishEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x48) = 0;
		    return;
		  }
		  iVar3 = func_ii_1082(iVar1,System_Action_ClansScope_ClanCombatFinishEventArgs__TypeInfo);
		  if (iVar3 != 0) {
		    *(int *)(iVar4 + 0x48) = iVar3;
		    uVar2 = System_Action_ClansScope_ClanCombatFinishEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_ClansScope_ClanCombatFinishEventArgs__TypeInfo);
		    if (iVar4 != 0) {
		      return;
		    }
		    System_Activator__CreateInstance(iVar1,uVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  System_Activator__CreateInstance(iVar1,uVar2);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

}
