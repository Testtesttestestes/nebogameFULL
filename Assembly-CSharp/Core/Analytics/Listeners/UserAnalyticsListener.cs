using System;
using System.Collections.Generic;
using Core.Data;
using Core.Events.Scopes;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Core.Analytics.Listeners
{
	// Token: 0x020012E6 RID: 4838
	[Token(Token = "0x20012E6")]
	public class UserAnalyticsListener : AbstractAnalyticsListener
	{
		// Token: 0x17001748 RID: 5960
		// (get) Token: 0x0600731C RID: 29468 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001748")]
		protected override string Theme
		{
			[Token(Token = "0x600731C")]
			[Address(RVA = "0xBD25", Offset = "0xBD25", VA = "0xBD25", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600731D RID: 29469 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600731D")]
		[Address(RVA = "0xBD26", Offset = "0xBD26", VA = "0xBD26", Slot = "10")]
		public override void Init()
		{
		/* --- GHIDRA: Init ---
		void Core_Analytics_Listeners_UserAnalyticsListener__Init(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a59650 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_UserScope_BaseUserEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_UserAnalyticsListener_AccountsChangedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_UserAnalyticsListener_AprChangedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_UserAnalyticsListener_BalanceChangedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_UserAnalyticsListener_BuyTreeLicenceSuccessEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_UserAnalyticsListener_CultChangedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_UserAnalyticsListener_ExpChangedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_UserAnalyticsListener_GenderChangedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_UserAnalyticsListener_LevelChangedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_UserAnalyticsListener_NickChangedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_UserAnalyticsListener_SkillsChangedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_UserAnalyticsListener_TreeLicenceCountChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_UserAnalyticsListener_TriggersChangedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_UserAnalyticsListener_UserClanUpdatedEventHandler__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_UserAnalyticsListener_UserDataInitializedEvent__);
		    DAT_ram_00a59650 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0xc);
		  uVar5 = *(undefined4 *)(iVar4 + 0xc);
		  uVar2 = unnamed_function_1417(System_Action_UserScope_BaseUserEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_UserAnalyticsListener_UserDataInitializedEvent__,0);
		  iVar1 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_UserScope_BaseUserEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0xc) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_UserScope_BaseUserEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0xc) = iVar3;
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
		  iVar4 = *(int *)(iVar1 + 0xc);
		  uVar5 = *(undefined4 *)(iVar4 + 8);
		  uVar2 = unnamed_function_1417(System_Action_UserScope_BaseUserEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_UserAnalyticsListener_BalanceChangedEvent__,0);
		  iVar1 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_UserScope_BaseUserEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 8) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_UserScope_BaseUserEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 8) = iVar3;
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
		  iVar4 = *(int *)(iVar1 + 0xc);
		  uVar5 = *(undefined4 *)(iVar4 + 0x10);
		  uVar2 = unnamed_function_1417(System_Action_UserScope_BaseUserEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_UserAnalyticsListener_TriggersChangedEvent__,0);
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
		  iVar4 = *(int *)(iVar1 + 0xc);
		  uVar5 = *(undefined4 *)(iVar4 + 0x14);
		  uVar2 = unnamed_function_1417(System_Action_UserScope_BaseUserEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,Method_Core_Analytics_Listeners_UserAnalyticsListener_NickChangedEvent__,0
		            );
		  iVar1 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_UserScope_BaseUserEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x14) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_UserScope_BaseUserEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x14) = iVar3;
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
		  iVar4 = *(int *)(iVar1 + 0xc);
		  uVar5 = *(undefined4 *)(iVar4 + 0x24);
		  uVar2 = unnamed_function_1417(System_Action_UserScope_BaseUserEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,Method_Core_Analytics_Listeners_UserAnalyticsListener_AprChangedEvent__,0)
		  ;
		  iVar1 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_UserScope_BaseUserEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x24) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_UserScope_BaseUserEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x24) = iVar3;
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
		  iVar4 = *(int *)(iVar1 + 0xc);
		  uVar5 = *(undefined4 *)(iVar4 + 0x1c);
		  uVar2 = unnamed_function_1417(System_Action_UserScope_BaseUserEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,Method_Core_Analytics_Listeners_UserAnalyticsListener_CultChangedEvent__,0
		            );
		  iVar1 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_UserScope_BaseUserEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x1c) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_UserScope_BaseUserEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x1c) = iVar3;
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
		  iVar4 = *(int *)(iVar1 + 0xc);
		  uVar5 = *(undefined4 *)(iVar4 + 0x20);
		  uVar2 = unnamed_function_1417(System_Action_UserScope_BaseUserEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,Method_Core_Analytics_Listeners_UserAnalyticsListener_GenderChangedEvent__
		             ,0);
		  iVar1 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_UserScope_BaseUserEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x20) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_UserScope_BaseUserEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x20) = iVar3;
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
		  iVar4 = *(int *)(iVar1 + 0xc);
		  uVar5 = *(undefined4 *)(iVar4 + 0x28);
		  uVar2 = unnamed_function_1417(System_Action_UserScope_BaseUserEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,Method_Core_Analytics_Listeners_UserAnalyticsListener_LevelChangedEvent__,
		             0);
		  iVar1 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_UserScope_BaseUserEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x28) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_UserScope_BaseUserEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x28) = iVar3;
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
		  iVar4 = *(int *)(iVar1 + 0xc);
		  uVar5 = *(undefined4 *)(iVar4 + 0x18);
		  uVar2 = unnamed_function_1417(System_Action_UserScope_BaseUserEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,Method_Core_Analytics_Listeners_UserAnalyticsListener_SkillsChangedEvent__
		             ,0);
		  iVar1 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_UserScope_BaseUserEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x18) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_UserScope_BaseUserEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x18) = iVar3;
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
		  iVar4 = *(int *)(iVar1 + 0xc);
		  uVar5 = *(undefined4 *)(iVar4 + 0x2c);
		  uVar2 = unnamed_function_1417(System_Action_UserScope_BaseUserEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,Method_Core_Analytics_Listeners_UserAnalyticsListener_ExpChangedEvent__,0)
		  ;
		  iVar1 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_UserScope_BaseUserEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x2c) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_UserScope_BaseUserEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x2c) = iVar3;
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
		  iVar4 = *(int *)(iVar1 + 0xc);
		  uVar5 = *(undefined4 *)(iVar4 + 0x30);
		  uVar2 = unnamed_function_1417(System_Action_UserScope_BaseUserEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_UserAnalyticsListener_AccountsChangedEvent__,0);
		  iVar1 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_UserScope_BaseUserEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x30) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_UserScope_BaseUserEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x30) = iVar3;
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
		  iVar4 = *(int *)(iVar1 + 0xc);
		  uVar5 = *(undefined4 *)(iVar4 + 0x34);
		  uVar2 = unnamed_function_1417(System_Action_UserScope_BaseUserEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_UserAnalyticsListener_TreeLicenceCountChangedEvent__,0)
		  ;
		  iVar1 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_UserScope_BaseUserEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x34) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_UserScope_BaseUserEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x34) = iVar3;
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
		  iVar4 = *(int *)(iVar1 + 0xc);
		  uVar5 = *(undefined4 *)(iVar4 + 0x38);
		  uVar2 = unnamed_function_1417(System_Action_UserScope_BaseUserEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_UserAnalyticsListener_BuyTreeLicenceSuccessEvent__,0);
		  iVar1 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_UserScope_BaseUserEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x38) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_UserScope_BaseUserEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x38) = iVar3;
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
		  iVar4 = *(int *)(iVar1 + 0xc);
		  uVar5 = *(undefined4 *)(iVar4 + 0x3c);
		  uVar2 = unnamed_function_1417(System_Action_UserScope_BaseUserEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_UserAnalyticsListener_UserClanUpdatedEventHandler__,0);
		  iVar1 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_UserScope_BaseUserEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x3c) = 0;
		    return;
		  }
		  iVar3 = func_ii_1082(iVar1,System_Action_UserScope_BaseUserEventArgs__TypeInfo);
		  if (iVar3 != 0) {
		    *(int *)(iVar4 + 0x3c) = iVar3;
		    uVar2 = System_Action_UserScope_BaseUserEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_UserScope_BaseUserEventArgs__TypeInfo);
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

		// Token: 0x0600731E RID: 29470 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600731E")]
		[Address(RVA = "0xBD27", Offset = "0xBD27", VA = "0xBD27", Slot = "11")]
		protected override void Deinit()
		{
		/* --- GHIDRA: Deinit ---
		void Core_Analytics_Listeners_UserAnalyticsListener__Deinit
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  Core_Analytics_Listeners_UserAnalyticsListener__SetRank
		            (param1,*(undefined4 *)(param2 + 0x10),param2);
		  return;
		}
		*/

		}

		// Token: 0x0600731F RID: 29471 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600731F")]
		[Address(RVA = "0xBD28", Offset = "0xBD28", VA = "0xBD28")]
		private void UserClanUpdatedEventHandler(UserScope.BaseUserEventArgs e)
		{
		/* --- GHIDRA: UserClanUpdatedEventHandler ---
		void Core_Analytics_Listeners_UserAnalyticsListener__UserClanUpdatedEventHandler
		               (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 param2_00;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  int *piVar5;
		  int iVar6;
		  undefined4 local_4;
		  
		  uVar1 = 0;
		  if (DAT_ram_00a59651 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27859);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26155);
		    Mono_Security_ASN1__get_Item(&StringLiteral_20809);
		    DAT_ram_00a59651 = '\x01';
		  }
		  param2_00 = Core_Analytics_Listeners_AbstractAnalyticsListener__RemoveService(param1,0);
		  piVar5 = *(int **)(param2 + 0xc);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x140);
		        goto code_r0x8104411d;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x8104411d:
		  uVar1 = 0;
		  iVar6 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		  uVar3 = Gameplay_User_Model_UserModel__get_PremiumExpMinLevel(*(undefined4 *)(iVar6 + 0x14),0);
		  Gameplay_Boss_Model_BossInfo_BossAttackOption_BossAttackOptionVariant__get_Price
		            (param1,param2_00,uVar3,StringLiteral_26155,0);
		  local_4 = *(undefined4 *)(*(int *)(param2 + 0x10) + 0x60);
		  uVar3 = func_ii_1081(DAT_ram_00a66958,&local_4);
		  func_ii_2946(param2_00,StringLiteral_27859,uVar3,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  piVar5 = (int *)param1[2];
		  uVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xec));
		  uVar3 = StringLiteral_20809;
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0xd8);
		        goto code_r0x8104421a;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,Core_Analytics_Service_IAnalyticsApi_TypeInfo,3);
		code_r0x8104421a:
		  (**(code **)((ulonglong)*puVar2 * 4))(piVar5,uVar4,uVar3,param2_00,puVar2[1]);
		  return;
		}
		*/

		}

		// Token: 0x06007320 RID: 29472 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007320")]
		[Address(RVA = "0xBD29", Offset = "0xBD29", VA = "0xBD29")]
		private void BuyTreeLicenceSuccessEvent(UserScope.BaseUserEventArgs e)
		{
		/* --- GHIDRA: BuyTreeLicenceSuccessEvent ---
		void Core_Analytics_Listeners_UserAnalyticsListener__BuyTreeLicenceSuccessEvent
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  Core_Analytics_Listeners_UserAnalyticsListener__TreeLicenceCountChangedEvent
		            (param1,*(undefined4 *)(param2 + 0x10),param2);
		  return;
		}
		*/

		}

		// Token: 0x06007321 RID: 29473 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007321")]
		[Address(RVA = "0xBD2A", Offset = "0xBD2A", VA = "0xBD2A")]
		private void TreeLicenceCountChangedEvent(UserScope.BaseUserEventArgs obj)
		{
		/* --- GHIDRA: TreeLicenceCountChangedEvent ---
		void Core_Analytics_Listeners_UserAnalyticsListener__TreeLicenceCountChangedEvent
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  uint uVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  int *param1_00;
		  int iVar5;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a59652 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27859);
		    DAT_ram_00a59652 = '\x01';
		  }
		  param1_00 = *(int **)(param1 + 8);
		  local_4 = *(undefined4 *)(param2 + 0x60);
		  uVar3 = func_ii_1081(DAT_ram_00a66958,&local_4);
		  uVar1 = StringLiteral_27859;
		  iVar5 = *param1_00;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar2 = 0;
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar2 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar2 * 8 + 4) * 8 + iVar5 + 200);
		        goto code_r0x8104430f;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar2);
		  }
		  puVar4 = (uint *)func_ii_1080(param1_00,Core_Analytics_Service_IAnalyticsApi_TypeInfo,1);
		code_r0x8104430f:
		  (**(code **)((ulonglong)*puVar4 * 4))(param1_00,uVar1,uVar3,puVar4[1]);
		  return;
		}
		*/

		}

		// Token: 0x06007322 RID: 29474 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007322")]
		[Address(RVA = "0xBD2B", Offset = "0xBD2B", VA = "0xBD2B")]
		private void SetTreeLicenceCount(UserData userData)
		{
		/* --- GHIDRA: SetTreeLicenceCount ---
		void Core_Analytics_Listeners_UserAnalyticsListener__SetTreeLicenceCount
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  Core_Analytics_Listeners_UserAnalyticsListener__UserDataInitializedEvent
		            (param1,*(undefined4 *)(param2 + 0x10),param2);
		  return;
		}
		*/

		}

		// Token: 0x06007323 RID: 29475 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007323")]
		[Address(RVA = "0xBD2C", Offset = "0xBD2C", VA = "0xBD2C")]
		private void AccountsChangedEvent(UserScope.BaseUserEventArgs e)
		{
		/* --- GHIDRA: AccountsChangedEvent ---
		void Core_Analytics_Listeners_UserAnalyticsListener__AccountsChangedEvent
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  Core_Analytics_Listeners_UserAnalyticsListener__SetLevel
		            (param1,*(undefined4 *)(param2 + 0x10),param2);
		  return;
		}
		*/

		}

		// Token: 0x06007324 RID: 29476 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007324")]
		[Address(RVA = "0xBD2D", Offset = "0xBD2D", VA = "0xBD2D")]
		private void ExpChangedEvent(UserScope.BaseUserEventArgs e)
		{
		/* --- GHIDRA: ExpChangedEvent ---
		void Core_Analytics_Listeners_UserAnalyticsListener__ExpChangedEvent
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  Core_Analytics_Listeners_UserAnalyticsListener__SetRefData
		            (param1,*(undefined4 *)(param2 + 0x10),param2);
		  return;
		}
		*/

		}

		// Token: 0x06007325 RID: 29477 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007325")]
		[Address(RVA = "0xBD2E", Offset = "0xBD2E", VA = "0xBD2E")]
		private void SkillsChangedEvent(UserScope.BaseUserEventArgs e)
		{
		/* --- GHIDRA: SkillsChangedEvent ---
		void Core_Analytics_Listeners_UserAnalyticsListener__SkillsChangedEvent
		               (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 param1_00;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  int *param1_01;
		  int iVar5;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a59653 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25097);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25096);
		    DAT_ram_00a59653 = '\x01';
		  }
		  Core_Analytics_Listeners_UserAnalyticsListener__SetSkills
		            (param1,*(undefined4 *)(param2 + 0x10),param1);
		  param1_00 = Core_Analytics_Listeners_AbstractAnalyticsListener__RemoveService(param1,0);
		  local_4 = Core_Data_UserData__set_LevelDic(*(undefined4 *)(param2 + 0x10),0);
		  uVar2 = func_ii_1081(DAT_ram_00a66958,&local_4);
		  func_ii_2946(param1_00,StringLiteral_25096,uVar2,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  param1_01 = (int *)param1[2];
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xec));
		  uVar2 = StringLiteral_25097;
		  iVar5 = *param1_01;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd8);
		        goto code_r0x810450e1;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(param1_01,Core_Analytics_Service_IAnalyticsApi_TypeInfo,3);
		code_r0x810450e1:
		  (**(code **)((ulonglong)*puVar4 * 4))(param1_01,uVar3,uVar2,param1_00,puVar4[1]);
		  return;
		}
		*/

		}

		// Token: 0x06007326 RID: 29478 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007326")]
		[Address(RVA = "0xBD2F", Offset = "0xBD2F", VA = "0xBD2F")]
		private void LevelChangedEvent(UserScope.BaseUserEventArgs e)
		{
		/* --- GHIDRA: LevelChangedEvent ---
		void Core_Analytics_Listeners_UserAnalyticsListener__LevelChangedEvent
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  Core_Analytics_Listeners_UserAnalyticsListener__SetApr
		            (param1,*(undefined4 *)(param2 + 0x10),param2);
		  return;
		}
		*/

		}

		// Token: 0x06007327 RID: 29479 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007327")]
		[Address(RVA = "0xBD30", Offset = "0xBD30", VA = "0xBD30")]
		private void GenderChangedEvent(UserScope.BaseUserEventArgs e)
		{
		/* --- GHIDRA: GenderChangedEvent ---
		void Core_Analytics_Listeners_UserAnalyticsListener__GenderChangedEvent
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  Core_Analytics_Listeners_UserAnalyticsListener__SetExp
		            (param1,*(undefined4 *)(param2 + 0x10),param2);
		  return;
		}
		*/

		}

		// Token: 0x06007328 RID: 29480 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007328")]
		[Address(RVA = "0xBD31", Offset = "0xBD31", VA = "0xBD31")]
		private void CultChangedEvent(UserScope.BaseUserEventArgs e)
		{
		/* --- GHIDRA: CultChangedEvent ---
		void Core_Analytics_Listeners_UserAnalyticsListener__CultChangedEvent
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  Core_Analytics_Listeners_UserAnalyticsListener__SetCult
		            (param1,*(undefined4 *)(param2 + 0x10),param2);
		  return;
		}
		*/

		}

		// Token: 0x06007329 RID: 29481 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007329")]
		[Address(RVA = "0xBD32", Offset = "0xBD32", VA = "0xBD32")]
		private void AprChangedEvent(UserScope.BaseUserEventArgs e)
		{
		/* --- GHIDRA: AprChangedEvent ---
		void Core_Analytics_Listeners_UserAnalyticsListener__AprChangedEvent
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  uint uVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  uint *puVar5;
		  int *param1_00;
		  int iVar6;
		  
		  if (DAT_ram_00a59654 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25590);
		    DAT_ram_00a59654 = '\x01';
		  }
		  Core_Analytics_Listeners_UserAnalyticsListener__SetGender
		            (param1,*(undefined4 *)(param2 + 0x10),param1);
		  param1_00 = (int *)param1[2];
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xec));
		  uVar4 = Core_Analytics_Listeners_AbstractAnalyticsListener__RemoveService(param1,0);
		  uVar1 = StringLiteral_25590;
		  iVar6 = *param1_00;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar2 = 0;
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8)) {
		        puVar5 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8 + 4) * 8 + iVar6 + 0xd8);
		        goto code_r0x810455ad;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar2);
		  }
		  puVar5 = (uint *)func_ii_1080(param1_00,Core_Analytics_Service_IAnalyticsApi_TypeInfo,3);
		code_r0x810455ad:
		  (**(code **)((ulonglong)*puVar5 * 4))(param1_00,uVar3,uVar1,uVar4,puVar5[1]);
		  return;
		}
		*/

		}

		// Token: 0x0600732A RID: 29482 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600732A")]
		[Address(RVA = "0xBD33", Offset = "0xBD33", VA = "0xBD33")]
		private void NickChangedEvent(UserScope.BaseUserEventArgs e)
		{
		/* --- GHIDRA: NickChangedEvent ---
		void Core_Analytics_Listeners_UserAnalyticsListener__NickChangedEvent
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *param4;
		  undefined4 uVar2;
		  undefined4 param2_00;
		  int *param1_00;
		  int iVar3;
		  
		  if (DAT_ram_00a59655 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a59655 = '\x01';
		  }
		  param2_00 = *(undefined4 *)(param2 + 0x10);
		  param1_00 = *(int **)(param2 + 0xc);
		  iVar3 = *param1_00;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        param4 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x178);
		        goto code_r0x8104571a;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  param4 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x8104571a:
		  uVar2 = (**(code **)((ulonglong)*param4 * 4))(param1_00,param4[1]);
		  uVar2 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar2,0);
		  Core_Analytics_Listeners_UserAnalyticsListener__TriggersChangedEvent
		            (param1,param2_00,uVar2,param4);
		  return;
		}
		*/

		}

		// Token: 0x0600732B RID: 29483 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600732B")]
		[Address(RVA = "0xBD34", Offset = "0xBD34", VA = "0xBD34")]
		private void TriggersChangedEvent(UserScope.BaseUserEventArgs e)
		{
		/* --- GHIDRA: TriggersChangedEvent ---
		void Core_Analytics_Listeners_UserAnalyticsListener__TriggersChangedEvent
		               (int param1,undefined4 param2,int param3,undefined4 param4)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 *puVar3;
		  undefined4 uVar4;
		  int *piVar5;
		  int iVar6;
		  int *piVar7;
		  uint uVar8;
		  undefined8 local_30;
		  undefined4 local_28;
		  int local_24;
		  undefined1 *puStack_20;
		  undefined8 local_1c;
		  int local_14;
		  undefined1 local_10 [8];
		  undefined8 local_8;
		  
		  if (DAT_ram_00a59656 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToList_TriggerDic___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Where_TriggerDic___);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_TriggerDic__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_TriggerDic__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_TriggerDic__get_Current__);
		    Mono_Security_ASN1__get_Item(&System_Func_TriggerDic__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_TriggerDic__GetEnumerator__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Analytics_Listeners_UserAnalyticsListener___c__SetTriggerProperties_b__21_0__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Listeners_UserAnalyticsListener___c_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27867);
		    DAT_ram_00a59656 = '\x01';
		  }
		  local_14 = 0;
		  iVar6 = *(int *)(param1 + 0x10);
		  if (iVar6 == 0) {
		    uVar4 = *(undefined4 *)(param3 + 0x74);
		    if (*(int *)(Core_Analytics_Listeners_UserAnalyticsListener___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Analytics_Listeners_UserAnalyticsListener___c_TypeInfo);
		    }
		    puVar3 = *(undefined4 **)(Core_Analytics_Listeners_UserAnalyticsListener___c_TypeInfo + 0x5c);
		    iVar6 = puVar3[1];
		    if (iVar6 == 0) {
		      if (*(int *)(Core_Analytics_Listeners_UserAnalyticsListener___c_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_Analytics_Listeners_UserAnalyticsListener___c_TypeInfo);
		        puVar3 = *(undefined4 **)
		                  (Core_Analytics_Listeners_UserAnalyticsListener___c_TypeInfo + 0x5c);
		      }
		      uVar2 = *puVar3;
		      iVar6 = unnamed_function_1417(System_Func_TriggerDic__bool__TypeInfo);
		      System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		                (iVar6,uVar2,
		                 Method_Core_Analytics_Listeners_UserAnalyticsListener___c__SetTriggerProperties_b__21_0__
		                 ,0);
		      *(int *)(*(int *)(Core_Analytics_Listeners_UserAnalyticsListener___c_TypeInfo + 0x5c) + 4) =
		           iVar6;
		    }
		    uVar4 = System_Linq_Enumerable__Where_PlayerLoopSystem_
		                      (uVar4,iVar6,Method_System_Linq_Enumerable_Where_TriggerDic___);
		    iVar6 = System_Linq_Enumerable__Select_object__object_
		                      (uVar4,Method_System_Linq_Enumerable_ToList_TriggerDic___);
		    *(int *)(param1 + 0x10) = iVar6;
		  }
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_24,iVar6,Method_System_Collections_Generic_List_TriggerDic__GetEnumerator__);
		  local_8 = local_1c;
		  local_24 = 0;
		  puStack_20 = local_10;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar1 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,local_10,
		                       Method_System_Collections_Generic_List_Enumerator_TriggerDic__MoveNext__);
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 == 1) {
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81045b7d;
		    }
		    if (iVar1 == 0) {
		      DAT_ram_009d3e38 = 0;
		      return;
		    }
		    DAT_ram_009d3e38 = 0;
		    iVar1 = local_8._4_4_;
		    piVar5 = (int *)import::env::invoke_iii
		                              (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x43,param2,0);
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 == 1) {
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81045b7d;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_iiiii
		              (*(undefined4 *)(*piVar5 + 0x100),piVar5,*(undefined4 *)(iVar1 + 0xc),&local_14,
		               *(undefined4 *)(*piVar5 + 0x104));
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 == 1) {
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81045b7d;
		    }
		    local_28 = *(undefined4 *)(iVar1 + 0xc);
		    DAT_ram_009d3e38 = 0;
		    uVar4 = import::env::invoke_iii
		                      (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x19,DAT_ram_00a66958,
		                       &local_28);
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 == 1) {
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81045b7d;
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar4 = import::env::invoke_iiiii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x261,StringLiteral_27867,
		                       uVar4,*(undefined4 *)(iVar1 + 0x14),0);
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 == 1) {
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81045b7d;
		    }
		    piVar5 = *(int **)(param1 + 8);
		    local_30 = *(undefined8 *)(local_14 + 0x10);
		    DAT_ram_009d3e38 = 0;
		    uVar2 = import::env::invoke_iii
		                      (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x19,DAT_ram_00a66964,
		                       &local_30);
		    if (DAT_ram_009d3e38 == 1) break;
		    iVar6 = *piVar5;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      uVar8 = 0;
		      do {
		        piVar7 = (int *)(*(int *)(iVar6 + 0x58) + uVar8 * 8);
		        if (Core_Analytics_Service_IAnalyticsApi_TypeInfo == *piVar7) {
		          puVar3 = (undefined4 *)(piVar7[1] * 8 + iVar6 + 200);
		          goto code_r0x81045af4;
		        }
		        uVar8 = uVar8 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar8);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar3 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar5,
		                        Core_Analytics_Service_IAnalyticsApi_TypeInfo,1);
		    if (DAT_ram_009d3e38 == 1) break;
		code_r0x81045af4:
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viiii(*puVar3,piVar5,uVar4,uVar2,puVar3[1]);
		  } while (DAT_ram_009d3e38 != 1);
		  DAT_ram_009d3e38 = 0;
		  uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x81045b7d:
		  iVar6 = global_1;
		  iVar1 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar6 == iVar1) {
		    piVar5 = (int *)import::env::__cxa_begin_catch(uVar4);
		    iVar1 = *piVar5;
		    DAT_ram_009d3e38 = 0;
		    local_24 = iVar1;
		    import::env::invoke_v(0x123);
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 != 1) {
		      if (iVar1 == 0) {
		        DAT_ram_009d3e38 = 0;
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar4 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x342,&local_24);
		  iVar6 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar6 != 1) {
		    import::env::__resumeException(uVar4);
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

		// Token: 0x0600732C RID: 29484 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600732C")]
		[Address(RVA = "0xBD35", Offset = "0xBD35", VA = "0xBD35")]
		private void SetTriggerProperties(UserData userData, Dictionaries dictionaries)
		{
		/* --- GHIDRA: SetTriggerProperties ---
		void Core_Analytics_Listeners_UserAnalyticsListener__SetTriggerProperties
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *param4;
		  undefined4 uVar2;
		  int *param1_00;
		  int iVar3;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a59657 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a59657 = '\x01';
		  }
		  param2_00 = *(undefined4 *)(param2 + 0x10);
		  Core_Analytics_Listeners_UserAnalyticsListener__SetGender(param1,param2_00,param2);
		  Core_Analytics_Listeners_UserAnalyticsListener__SetExp(param1,param2_00,param2);
		  Core_Analytics_Listeners_UserAnalyticsListener__SetCult(param1,param2_00,param2);
		  Core_Analytics_Listeners_UserAnalyticsListener__SetApr(param1,param2_00,param2);
		  Core_Analytics_Listeners_UserAnalyticsListener__SetLevel(param1,param2_00,param2);
		  Core_Analytics_Listeners_UserAnalyticsListener__SetSkills(param1,param2_00,param2);
		  Core_Analytics_Listeners_UserAnalyticsListener__SetRefData(param1,param2_00,param2);
		  Core_Analytics_Listeners_UserAnalyticsListener__SetNick(param1,param2_00,param2);
		  Core_Analytics_Listeners_UserAnalyticsListener__BalanceChangedEvent(param1,param2_00,param2);
		  param1_00 = *(int **)(param2 + 0xc);
		  iVar3 = *param1_00;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        param4 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x178);
		        goto code_r0x81045d42;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  param4 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x81045d42:
		  uVar2 = (**(code **)((ulonglong)*param4 * 4))(param1_00,param4[1]);
		  uVar2 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar2,0);
		  Core_Analytics_Listeners_UserAnalyticsListener__TriggersChangedEvent
		            (param1,param2_00,uVar2,param4);
		  Core_Analytics_Listeners_UserAnalyticsListener__SetAccounts(param1,param2_00,param4);
		  Core_Analytics_Listeners_UserAnalyticsListener__UserDataInitializedEvent(param1,param2_00,param4);
		  Core_Analytics_Listeners_UserAnalyticsListener__TreeLicenceCountChangedEvent
		            (param1,param2_00,param4);
		  return;
		}
		*/

		}

		// Token: 0x0600732D RID: 29485 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600732D")]
		[Address(RVA = "0xBD36", Offset = "0xBD36", VA = "0xBD36")]
		private void UserDataInitializedEvent(UserScope.BaseUserEventArgs e)
		{
		/* --- GHIDRA: UserDataInitializedEvent ---
		void Core_Analytics_Listeners_UserAnalyticsListener__UserDataInitializedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  float fVar1;
		  int param1_00;
		  undefined4 uVar2;
		  undefined4 *puVar3;
		  undefined4 uVar4;
		  int *piVar5;
		  uint uVar6;
		  int iVar7;
		  int iVar8;
		  uint uVar9;
		  int *piVar10;
		  float4 local_30;
		  int local_2c;
		  undefined8 *local_28;
		  undefined4 local_24;
		  undefined4 uStack_20;
		  undefined4 local_1c;
		  undefined4 uStack_18;
		  int *local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a59658 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_AccountDic_Types_UserAccounts__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_AccountDic_Types_UserAccounts__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_AccountDic_Types_UserAccounts__get_Current__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Data_Accounts_IAccountData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_AccountDic_Types_UserAccounts__Add__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_AccountDic_Types_UserAccounts__GetEnumerator__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_AccountDic_Types_UserAccounts___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_List_AccountDic_Types_UserAccounts__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Dic_AccountDic_Types_UserAccounts_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19432);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19675);
		    DAT_ram_00a59658 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  local_14 = (int *)0x0;
		  param1_00 = unnamed_function_1417
		                        (System_Collections_Generic_List_AccountDic_Types_UserAccounts__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,Method_System_Collections_Generic_List_AccountDic_Types_UserAccounts___ctor__
		            );
		  iVar7 = Method_System_Collections_Generic_List_AccountDic_Types_UserAccounts__Add__;
		  *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		  uVar6 = *(uint *)(param1_00 + 0xc);
		  iVar8 = *(int *)(param1_00 + 8);
		  uVar9 = *(uint *)(iVar8 + 0xc);
		  if (uVar6 < uVar9) {
		    *(uint *)(param1_00 + 0xc) = uVar6 + 1;
		    *(undefined4 *)(iVar8 + uVar6 * 4 + 0x10) = 1;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (param1_00,1,*(undefined4 *)(*(int *)(*(int *)(iVar7 + 0x10) + 0x60) + 0x38));
		    iVar8 = *(int *)(param1_00 + 8);
		    uVar9 = *(uint *)(iVar8 + 0xc);
		    iVar7 = Method_System_Collections_Generic_List_AccountDic_Types_UserAccounts__Add__;
		  }
		  *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		  uVar6 = *(uint *)(param1_00 + 0xc);
		  if (uVar6 < uVar9) {
		    *(uint *)(param1_00 + 0xc) = uVar6 + 1;
		    *(undefined4 *)(iVar8 + uVar6 * 4 + 0x10) = 3;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (param1_00,3,*(undefined4 *)(*(int *)(*(int *)(iVar7 + 0x10) + 0x60) + 0x38));
		    iVar8 = *(int *)(param1_00 + 8);
		    uVar9 = *(uint *)(iVar8 + 0xc);
		    iVar7 = Method_System_Collections_Generic_List_AccountDic_Types_UserAccounts__Add__;
		  }
		  *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		  uVar6 = *(uint *)(param1_00 + 0xc);
		  if (uVar6 < uVar9) {
		    *(uint *)(param1_00 + 0xc) = uVar6 + 1;
		    *(undefined4 *)(iVar8 + uVar6 * 4 + 0x10) = 5;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (param1_00,5,*(undefined4 *)(*(int *)(*(int *)(iVar7 + 0x10) + 0x60) + 0x38));
		  }
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_24,param1_00,
		             Method_System_Collections_Generic_List_AccountDic_Types_UserAccounts__GetEnumerator__);
		  local_8._4_4_ = uStack_18;
		  local_2c = 0;
		  local_28 = &local_10;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar8 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x21f,&local_10,
		                       Method_System_Collections_Generic_List_Enumerator_AccountDic_Types_UserAccounts__MoveNext__
		                      );
		    uVar4 = local_8._4_4_;
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar7 == 1) {
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81044956;
		    }
		    if (iVar8 == 0) {
		      DAT_ram_009d3e38 = 0;
		      return;
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar2 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x1ca,param2,0);
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar7 == 1) {
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81044956;
		    }
		    DAT_ram_009d3e38 = 0;
		    iVar8 = import::env::invoke_iiiii
		                      (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x1cb,uVar2,uVar4,&local_14
		                       ,0);
		    piVar5 = local_14;
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar7 == 1) {
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81044956;
		    }
		    fVar1 = 0.0;
		    if (iVar8 != 0) {
		      iVar7 = *local_14;
		      if (*(ushort *)(iVar7 + 0xb6) != 0) {
		        uVar9 = 0;
		        do {
		          piVar10 = (int *)(*(int *)(iVar7 + 0x58) + uVar9 * 8);
		          if (Core_Data_Accounts_IAccountData_TypeInfo == *piVar10) {
		            puVar3 = (undefined4 *)(piVar10[1] * 8 + iVar7 + 200);
		            goto code_r0x810446bf;
		          }
		          uVar9 = uVar9 + 1;
		        } while (*(ushort *)(iVar7 + 0xb6) != uVar9);
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar3 = (undefined4 *)
		               import::env::invoke_iiii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_14,
		                          Core_Data_Accounts_IAccountData_TypeInfo,1);
		      if (DAT_ram_009d3e38 != 1) {
		code_r0x810446bf:
		        DAT_ram_009d3e38 = 0;
		        uVar2 = import::env::invoke_iii(*puVar3,piVar5,puVar3[1]);
		        if (DAT_ram_009d3e38 != 1) {
		          DAT_ram_009d3e38 = 0;
		          fVar1 = import::env::invoke_fii
		                            (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x39,uVar2,0);
		          iVar7 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar7 != 1) goto code_r0x8104472d;
		          uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x81044956;
		        }
		      }
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81044956;
		    }
		code_r0x8104472d:
		    piVar5 = *(int **)(param1 + 8);
		    DAT_ram_009d3e38 = 0;
		    local_1c = uVar4;
		    uStack_20 = 0xffffffff;
		    local_24 = Protocol_Dic_AccountDic_Types_UserAccounts_TypeInfo;
		    uVar4 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_000013c7 + 0x293,&local_24,0);
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar7 == 1) {
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81044956;
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar4 = import::env::invoke_iii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x2d9,uVar4,0)
		    ;
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar7 == 1) {
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81044956;
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar4 = import::env::invoke_iiiii
		                      (s_struct_Uniforms___color__vec4<f3_ram_00000856 + 0x26e,StringLiteral_19675,
		                       uVar4,StringLiteral_19432,0);
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar7 == 1) {
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81044956;
		    }
		    DAT_ram_009d3e38 = 0;
		    local_30 = (float4)fVar1;
		    uVar2 = import::env::invoke_iii
		                      (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x19,DAT_ram_00a6696c,
		                       &local_30);
		    if (DAT_ram_009d3e38 == 1) break;
		    iVar7 = *piVar5;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      uVar9 = 0;
		      do {
		        piVar10 = (int *)(*(int *)(iVar7 + 0x58) + uVar9 * 8);
		        if (Core_Analytics_Service_IAnalyticsApi_TypeInfo == *piVar10) {
		          puVar3 = (undefined4 *)(piVar10[1] * 8 + iVar7 + 200);
		          goto code_r0x810448c3;
		        }
		        uVar9 = uVar9 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar9);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar3 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar5,
		                        Core_Analytics_Service_IAnalyticsApi_TypeInfo,1);
		    if (DAT_ram_009d3e38 == 1) break;
		code_r0x810448c3:
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viiii(*puVar3,piVar5,uVar4,uVar2,puVar3[1]);
		  } while (DAT_ram_009d3e38 != 1);
		  DAT_ram_009d3e38 = 0;
		  uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x81044956:
		  iVar7 = global_1;
		  iVar8 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar7 == iVar8) {
		    piVar5 = (int *)import::env::__cxa_begin_catch(uVar4);
		    iVar8 = *piVar5;
		    DAT_ram_009d3e38 = 0;
		    local_2c = iVar8;
		    import::env::invoke_v(0x123);
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar7 != 1) {
		      if (iVar8 == 0) {
		        DAT_ram_009d3e38 = 0;
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar8);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar4 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x340,&local_2c);
		  iVar7 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar7 != 1) {
		    import::env::__resumeException(uVar4);
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

		// Token: 0x0600732E RID: 29486 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600732E")]
		[Address(RVA = "0xBD37", Offset = "0xBD37", VA = "0xBD37")]
		private void SetAccounts(UserData userData)
		{
		/* --- GHIDRA: SetAccounts ---
		void Core_Analytics_Listeners_UserAnalyticsListener__SetAccounts
		               (int param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  undefined4 *puVar3;
		  undefined4 uVar4;
		  int *piVar5;
		  undefined4 param4;
		  int iVar6;
		  int *piVar7;
		  undefined4 local_1c;
		  int local_18;
		  undefined8 *local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a59659 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_RefAccountInfo__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_RefAccountInfo__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_RefAccountInfo__get_Current__);
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_RefAccountInfo__GetEnumerator__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28728);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26352);
		    DAT_ram_00a59659 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  if (*(int *)(param2 + 0x50) == 0) {
		    return;
		  }
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_10,*(int *)(param2 + 0x50),
		             Method_System_Collections_Generic_List_RefAccountInfo__GetEnumerator__);
		  local_18 = 0;
		  local_14 = &local_10;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar2 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_10,
		                       Method_System_Collections_Generic_List_Enumerator_RefAccountInfo__MoveNext__)
		    ;
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 == 1) {
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x810464ae;
		    }
		    if (iVar2 == 0) {
		      DAT_ram_009d3e38 = 0;
		      return;
		    }
		    piVar5 = *(int **)(param1 + 8);
		    iVar2 = local_8._4_4_;
		    local_1c = *(undefined4 *)(local_8._4_4_ + 0xc);
		    DAT_ram_009d3e38 = 0;
		    uVar4 = import::env::invoke_iii
		                      (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x19,DAT_ram_00a66958,
		                       &local_1c);
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 == 1) {
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x810464ae;
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar4 = import::env::invoke_iiiii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x261,StringLiteral_28728,
		                       StringLiteral_26352,uVar4,0);
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 == 1) {
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x810464ae;
		    }
		    param4 = *(undefined4 *)(iVar2 + 0x10);
		    iVar6 = *piVar5;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar7 = (int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8);
		        if (Core_Analytics_Service_IAnalyticsApi_TypeInfo == *piVar7) {
		          puVar3 = (undefined4 *)(piVar7[1] * 8 + iVar6 + 200);
		          goto code_r0x81046439;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar3 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar5,
		                        Core_Analytics_Service_IAnalyticsApi_TypeInfo,1);
		    if (DAT_ram_009d3e38 == 1) break;
		code_r0x81046439:
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viiii(*puVar3,piVar5,uVar4,param4,puVar3[1]);
		  } while (DAT_ram_009d3e38 != 1);
		  DAT_ram_009d3e38 = 0;
		  uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x810464ae:
		  iVar6 = global_1;
		  iVar2 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar6 == iVar2) {
		    piVar5 = (int *)import::env::__cxa_begin_catch(uVar4);
		    iVar2 = *piVar5;
		    DAT_ram_009d3e38 = 0;
		    local_18 = iVar2;
		    import::env::invoke_v(0x123);
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 != 1) {
		      if (iVar2 == 0) {
		        DAT_ram_009d3e38 = 0;
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar4 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x343,&local_18);
		  iVar6 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar6 == 1) {
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__resumeException(uVar4);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x0600732F RID: 29487 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600732F")]
		[Address(RVA = "0xBD38", Offset = "0xBD38", VA = "0xBD38")]
		private void SetRefData(UserData userData)
		{
		/* --- GHIDRA: SetRefData ---
		void Core_Analytics_Listeners_UserAnalyticsListener__SetRefData
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 *puVar4;
		  int iVar5;
		  int *piVar6;
		  int iVar7;
		  int *piVar8;
		  uint uVar9;
		  undefined8 local_38;
		  undefined4 local_2c;
		  int local_28;
		  undefined1 *local_24;
		  undefined4 local_20;
		  undefined4 uStack_1c;
		  int local_18;
		  int iStack_14;
		  undefined1 local_10 [12];
		  int iStack_4;
		  
		  if (DAT_ram_00a5965a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_int__SkillData__get_Values__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_int__SkillData__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_int__SkillData__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_int__SkillData__get_Current__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Data_Skills_UserSkillsIndexes_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_int__SkillData__GetEnumerator__
		              );
		    Mono_Security_ASN1__get_Item(&StringLiteral_27249);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19463);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    DAT_ram_00a5965a = '\x01';
		  }
		  uVar1 = System_Collections_Generic_Dictionary_int__object___TryAdd
		                    (*(undefined4 *)(*(int *)(param2 + 0x44) + 0x18),
		                     Method_System_Collections_Generic_Dictionary_int__SkillData__get_Values__);
		  System_Collections_Generic_Dictionary_Int32Enum__object___get_Values
		            (&local_20,uVar1,
		             Method_System_Collections_Generic_Dictionary_ValueCollection_int__SkillData__GetEnumerator__
		            );
		  iStack_4 = iStack_14;
		  local_28 = 0;
		  local_24 = local_10;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar2 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x152,local_10,
		                       Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_int__SkillData__MoveNext__
		                      );
		    iVar5 = iStack_4;
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar7 == 1) {
		      uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81044f07;
		    }
		    if (iVar2 == 0) {
		      DAT_ram_009d3e38 = 0;
		      return;
		    }
		    DAT_ram_009d3e38 = 0;
		    local_20 = Core_Data_Skills_UserSkillsIndexes_TypeInfo;
		    uStack_1c = 0xffffffff;
		    local_18 = *(int *)(iStack_4 + 8) + -1;
		    uVar1 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_000013c7 + 0x293,&local_20,0);
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar7 == 1) {
		      uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81044f07;
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar1 = import::env::invoke_iii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x2d9,uVar1,0)
		    ;
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar7 == 1) {
		      uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81044f07;
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar1 = import::env::invoke_iiiii
		                      (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x2a,uVar1,
		                       StringLiteral_19463,StringLiteral_5,0);
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar7 == 1) {
		      uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81044f07;
		    }
		    piVar6 = *(int **)(param1 + 8);
		    local_2c = *(undefined4 *)(iVar5 + 8);
		    DAT_ram_009d3e38 = 0;
		    uVar3 = import::env::invoke_iii
		                      (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x19,DAT_ram_00a66954,
		                       &local_2c);
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar7 == 1) {
		      uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81044f07;
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar1 = import::env::invoke_iiiii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x261,StringLiteral_27249,
		                       uVar3,uVar1,0);
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar7 == 1) {
		      uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81044f07;
		    }
		    local_38 = *(undefined8 *)(iVar5 + 0x10);
		    DAT_ram_009d3e38 = 0;
		    uVar3 = import::env::invoke_iii
		                      (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x19,DAT_ram_00a66964,
		                       &local_38);
		    if (DAT_ram_009d3e38 == 1) break;
		    iVar7 = *piVar6;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      uVar9 = 0;
		      do {
		        piVar8 = (int *)(*(int *)(iVar7 + 0x58) + uVar9 * 8);
		        if (Core_Analytics_Service_IAnalyticsApi_TypeInfo == *piVar8) {
		          puVar4 = (undefined4 *)(piVar8[1] * 8 + iVar7 + 200);
		          goto code_r0x81044e74;
		        }
		        uVar9 = uVar9 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar9);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar4 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar6,
		                        Core_Analytics_Service_IAnalyticsApi_TypeInfo,1);
		    if (DAT_ram_009d3e38 == 1) break;
		code_r0x81044e74:
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viiii(*puVar4,piVar6,uVar1,uVar3,puVar4[1]);
		  } while (DAT_ram_009d3e38 != 1);
		  DAT_ram_009d3e38 = 0;
		  uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x81044f07:
		  iVar7 = global_1;
		  iVar5 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar7 == iVar5) {
		    piVar6 = (int *)import::env::__cxa_begin_catch(uVar1);
		    iVar5 = *piVar6;
		    DAT_ram_009d3e38 = 0;
		    local_28 = iVar5;
		    import::env::invoke_v(0x123);
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar7 != 1) {
		      if (iVar5 == 0) {
		        DAT_ram_009d3e38 = 0;
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar5);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar1 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x341,&local_28);
		  iVar7 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar7 != 1) {
		    import::env::__resumeException(uVar1);
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

		// Token: 0x06007330 RID: 29488 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007330")]
		[Address(RVA = "0xBD39", Offset = "0xBD39", VA = "0xBD39")]
		private void SetSkills(UserData userData)
		{
		/* --- GHIDRA: SetSkills ---
		void Core_Analytics_Listeners_UserAnalyticsListener__SetSkills
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  uint uVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  int *param1_00;
		  int iVar5;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5965b == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25096);
		    DAT_ram_00a5965b = '\x01';
		  }
		  param1_00 = *(int **)(param1 + 8);
		  local_4 = Core_Data_UserData__set_LevelDic(param2,0);
		  uVar3 = func_ii_1081(DAT_ram_00a66958,&local_4);
		  uVar1 = StringLiteral_25096;
		  iVar5 = *param1_00;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar2 = 0;
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar2 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar2 * 8 + 4) * 8 + iVar5 + 200);
		        goto code_r0x810451c9;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar2);
		  }
		  puVar4 = (uint *)func_ii_1080(param1_00,Core_Analytics_Service_IAnalyticsApi_TypeInfo,1);
		code_r0x810451c9:
		  (**(code **)((ulonglong)*puVar4 * 4))(param1_00,uVar1,uVar3,puVar4[1]);
		  return;
		}
		*/

		}

		// Token: 0x06007331 RID: 29489 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007331")]
		[Address(RVA = "0xBD3A", Offset = "0xBD3A", VA = "0xBD3A")]
		private void SetLevel(UserData userData)
		{
		/* --- GHIDRA: SetLevel ---
		void Core_Analytics_Listeners_UserAnalyticsListener__SetLevel
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  uint uVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  int *param1_00;
		  int iVar5;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5965c == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_23069);
		    DAT_ram_00a5965c = '\x01';
		  }
		  param1_00 = *(int **)(param1 + 8);
		  local_8 = *(undefined8 *)(param2 + 0x58);
		  uVar3 = func_ii_1081(DAT_ram_00a66968,&local_8);
		  uVar1 = StringLiteral_23069;
		  iVar5 = *param1_00;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar2 = 0;
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar2 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar2 * 8 + 4) * 8 + iVar5 + 200);
		        goto code_r0x81044b07;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar2);
		  }
		  puVar4 = (uint *)func_ii_1080(param1_00,Core_Analytics_Service_IAnalyticsApi_TypeInfo,1);
		code_r0x81044b07:
		  (**(code **)((ulonglong)*puVar4 * 4))(param1_00,uVar1,uVar3,puVar4[1]);
		  return;
		}
		*/

		}

		// Token: 0x06007332 RID: 29490 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007332")]
		[Address(RVA = "0xBD3B", Offset = "0xBD3B", VA = "0xBD3B")]
		private void SetExp(UserData userData)
		{
		/* --- GHIDRA: SetExp ---
		void Core_Analytics_Listeners_UserAnalyticsListener__SetExp
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  uint uVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  int *param1_00;
		  int iVar5;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5965d == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22107);
		    DAT_ram_00a5965d = '\x01';
		  }
		  param1_00 = *(int **)(param1 + 8);
		  local_4 = func_ii_6965(param2,0);
		  uVar3 = func_ii_1081(DAT_ram_00a66958,&local_4);
		  uVar1 = StringLiteral_22107;
		  iVar5 = *param1_00;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar2 = 0;
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar2 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar2 * 8 + 4) * 8 + iVar5 + 200);
		        goto code_r0x810453b9;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar2);
		  }
		  puVar4 = (uint *)func_ii_1080(param1_00,Core_Analytics_Service_IAnalyticsApi_TypeInfo,1);
		code_r0x810453b9:
		  (**(code **)((ulonglong)*puVar4 * 4))(param1_00,uVar1,uVar3,puVar4[1]);
		  return;
		}
		*/

		}

		// Token: 0x06007333 RID: 29491 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007333")]
		[Address(RVA = "0xBD3C", Offset = "0xBD3C", VA = "0xBD3C")]
		private void SetCult(UserData userData)
		{
		/* --- GHIDRA: SetCult ---
		void Core_Analytics_Listeners_UserAnalyticsListener__SetCult
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  uint uVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  int *param1_00;
		  int iVar5;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5965e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_AprDic__uint__get_Data__);
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19893);
		    DAT_ram_00a5965e = '\x01';
		  }
		  param1_00 = *(int **)(param1 + 8);
		  local_4 = *(undefined4 *)(*(int *)(*(int *)(param2 + 0x38) + 0x10) + 0xc);
		  uVar3 = func_ii_1081(DAT_ram_00a66958,&local_4);
		  uVar1 = StringLiteral_19893;
		  iVar5 = *param1_00;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar2 = 0;
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar2 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar2 * 8 + 4) * 8 + iVar5 + 200);
		        goto code_r0x810454bc;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar2);
		  }
		  puVar4 = (uint *)func_ii_1080(param1_00,Core_Analytics_Service_IAnalyticsApi_TypeInfo,1);
		code_r0x810454bc:
		  (**(code **)((ulonglong)*puVar4 * 4))(param1_00,uVar1,uVar3,puVar4[1]);
		  return;
		}
		*/

		}

		// Token: 0x06007334 RID: 29492 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007334")]
		[Address(RVA = "0xBD3D", Offset = "0xBD3D", VA = "0xBD3D")]
		private void SetApr(UserData userData)
		{
		/* --- GHIDRA: SetApr ---
		void Core_Analytics_Listeners_UserAnalyticsListener__SetApr
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  uint uVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  int *param1_00;
		  int iVar5;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5965f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_23328);
		    DAT_ram_00a5965f = '\x01';
		  }
		  param1_00 = *(int **)(param1 + 8);
		  local_4 = Core_Dict_DictWrappers_Base_AbstractDictWrapperStorage_object__uint___GetWrapper
		                      (param2,0);
		  uVar3 = func_ii_1081(DAT_ram_00a66958,&local_4);
		  uVar1 = StringLiteral_23328;
		  iVar5 = *param1_00;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar2 = 0;
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar2 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar2 * 8 + 4) * 8 + iVar5 + 200);
		        goto code_r0x810452c1;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar2);
		  }
		  puVar4 = (uint *)func_ii_1080(param1_00,Core_Analytics_Service_IAnalyticsApi_TypeInfo,1);
		code_r0x810452c1:
		  (**(code **)((ulonglong)*puVar4 * 4))(param1_00,uVar1,uVar3,puVar4[1]);
		  return;
		}
		*/

		}

		// Token: 0x06007335 RID: 29493 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007335")]
		[Address(RVA = "0xBD3E", Offset = "0xBD3E", VA = "0xBD3E")]
		private void SetGender(UserData userData)
		{
		/* --- GHIDRA: SetGender ---
		void Core_Analytics_Listeners_UserAnalyticsListener__SetGender
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  uint uVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  int *param1_00;
		  int iVar5;
		  
		  if (DAT_ram_00a59660 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25589);
		    DAT_ram_00a59660 = '\x01';
		  }
		  param1_00 = *(int **)(param1 + 8);
		  uVar3 = Google_Protobuf_Collections_RepeatedField_object___GetEnumerator(param2,0);
		  uVar1 = StringLiteral_25589;
		  iVar5 = *param1_00;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar2 = 0;
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar2 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar2 * 8 + 4) * 8 + iVar5 + 200);
		        goto code_r0x81045670;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar2);
		  }
		  puVar4 = (uint *)func_ii_1080(param1_00,Core_Analytics_Service_IAnalyticsApi_TypeInfo,1);
		code_r0x81045670:
		  (**(code **)((ulonglong)*puVar4 * 4))(param1_00,uVar1,uVar3,puVar4[1]);
		  return;
		}
		*/

		}

		// Token: 0x06007336 RID: 29494 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007336")]
		[Address(RVA = "0xBD3F", Offset = "0xBD3F", VA = "0xBD3F")]
		private void SetNick(UserData userData)
		{
		/* --- GHIDRA: SetNick ---
		void Core_Analytics_Listeners_UserAnalyticsListener__SetNick
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  uint uVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  int *param1_00;
		  int iVar5;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a59661 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26296);
		    DAT_ram_00a59661 = '\x01';
		  }
		  param1_00 = *(int **)(param1 + 8);
		  local_4 = *(undefined4 *)(*(int *)(param2 + 0x34) + 0x28);
		  uVar3 = func_ii_1081(DAT_ram_00a66958,&local_4);
		  uVar1 = StringLiteral_26296;
		  iVar5 = *param1_00;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar2 = 0;
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar2 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar2 * 8 + 4) * 8 + iVar5 + 200);
		        goto code_r0x81045e55;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar2);
		  }
		  puVar4 = (uint *)func_ii_1080(param1_00,Core_Analytics_Service_IAnalyticsApi_TypeInfo,1);
		code_r0x81045e55:
		  (**(code **)((ulonglong)*puVar4 * 4))(param1_00,uVar1,uVar3,puVar4[1]);
		  return;
		}
		*/

		}

		// Token: 0x06007337 RID: 29495 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007337")]
		[Address(RVA = "0xBD40", Offset = "0xBD40", VA = "0xBD40")]
		private void SetRank(UserData userData)
		{
		/* --- GHIDRA: SetRank ---
		void Core_Analytics_Listeners_UserAnalyticsListener__SetRank
		               (int param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  int *piVar5;
		  int iVar6;
		  int iVar7;
		  undefined1 local_d;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a59662 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_21203);
		    Mono_Security_ASN1__get_Item(&StringLiteral_21201);
		    Mono_Security_ASN1__get_Item(&StringLiteral_21194);
		    Mono_Security_ASN1__get_Item(&StringLiteral_21202);
		    Mono_Security_ASN1__get_Item(&StringLiteral_21207);
		    DAT_ram_00a59662 = '\x01';
		  }
		  piVar5 = *(int **)(param1 + 8);
		  iVar6 = *(int *)(param2 + 0x68);
		  if (iVar6 == 0) {
		    uVar1 = 0;
		    local_8 = (ulonglong)local_8._4_4_ << 0x20;
		    uVar3 = func_ii_1081(DAT_ram_00a66954,&local_8);
		    uVar2 = StringLiteral_21201;
		    iVar6 = *piVar5;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      do {
		        if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		            *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		          puVar4 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 200);
		          goto code_r0x81043dad;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		    }
		    puVar4 = (uint *)func_ii_1080(piVar5,Core_Analytics_Service_IAnalyticsApi_TypeInfo,1);
		code_r0x81043dad:
		    (**(code **)((ulonglong)*puVar4 * 4))(piVar5,uVar2,uVar3,puVar4[1]);
		    uVar2 = StringLiteral_21207;
		    uVar1 = 0;
		    uVar3 = **(undefined4 **)(DAT_ram_00a66978 + 0x5c);
		    piVar5 = *(int **)(param1 + 8);
		    iVar6 = *piVar5;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      do {
		        if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		            *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		          puVar4 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 200);
		          goto code_r0x81043e46;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		    }
		    puVar4 = (uint *)func_ii_1080(piVar5,Core_Analytics_Service_IAnalyticsApi_TypeInfo,1);
		code_r0x81043e46:
		    (**(code **)((ulonglong)*puVar4 * 4))(piVar5,uVar2,uVar3,puVar4[1]);
		    piVar5 = *(int **)(param1 + 8);
		    uVar1 = 0;
		    local_c = 0;
		    uVar3 = func_ii_1081(DAT_ram_00a66954,&local_c);
		    uVar2 = StringLiteral_21202;
		    iVar6 = *piVar5;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      do {
		        if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		            *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		          puVar4 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 200);
		          goto code_r0x81043ef4;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		    }
		    puVar4 = (uint *)func_ii_1080(piVar5,Core_Analytics_Service_IAnalyticsApi_TypeInfo,1);
		code_r0x81043ef4:
		    (**(code **)((ulonglong)*puVar4 * 4))(piVar5,uVar2,uVar3,puVar4[1]);
		    uVar2 = StringLiteral_21203;
		    uVar1 = 0;
		    uVar3 = **(undefined4 **)(DAT_ram_00a66978 + 0x5c);
		    piVar5 = *(int **)(param1 + 8);
		    iVar6 = *piVar5;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      do {
		        if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		            *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		          puVar4 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 200);
		          goto code_r0x81043f8d;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		    }
		    puVar4 = (uint *)func_ii_1080(piVar5,Core_Analytics_Service_IAnalyticsApi_TypeInfo,1);
		code_r0x81043f8d:
		    (**(code **)((ulonglong)*puVar4 * 4))(piVar5,uVar2,uVar3,puVar4[1]);
		    piVar5 = *(int **)(param1 + 8);
		    uVar1 = 0;
		    local_d = 0;
		    uVar3 = func_ii_1081(DAT_ram_00a66944,&local_d);
		    uVar2 = StringLiteral_21194;
		    iVar6 = *piVar5;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      do {
		        if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		            *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		          puVar4 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 200);
		          goto code_r0x8104403b;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		    }
		    puVar4 = (uint *)func_ii_1080(piVar5,Core_Analytics_Service_IAnalyticsApi_TypeInfo,1);
		code_r0x8104403b:
		    (**(code **)((ulonglong)*puVar4 * 4))(piVar5,uVar2,uVar3,puVar4[1]);
		  }
		  else {
		    local_8 = *(undefined8 *)(*(int *)(iVar6 + 0x1c) + 0x10);
		    uVar1 = 0;
		    uVar3 = func_ii_8783(&local_8,0);
		    uVar2 = StringLiteral_21201;
		    iVar7 = *piVar5;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      do {
		        if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		            *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		          puVar4 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 200);
		          goto code_r0x81043a7b;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		    }
		    puVar4 = (uint *)func_ii_1080(piVar5,Core_Analytics_Service_IAnalyticsApi_TypeInfo,1);
		code_r0x81043a7b:
		    (**(code **)((ulonglong)*puVar4 * 4))(piVar5,uVar2,uVar3,puVar4[1]);
		    uVar2 = StringLiteral_21207;
		    uVar1 = 0;
		    uVar3 = *(undefined4 *)(*(int *)(iVar6 + 0x1c) + 0x18);
		    piVar5 = *(int **)(param1 + 8);
		    iVar7 = *piVar5;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      do {
		        if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		            *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		          puVar4 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 200);
		          goto code_r0x81043b0e;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		    }
		    puVar4 = (uint *)func_ii_1080(piVar5,Core_Analytics_Service_IAnalyticsApi_TypeInfo,1);
		code_r0x81043b0e:
		    (**(code **)((ulonglong)*puVar4 * 4))(piVar5,uVar2,uVar3,puVar4[1]);
		    piVar5 = *(int **)(param1 + 8);
		    local_c = *(undefined4 *)(*(int *)(*(int *)(iVar6 + 0x1c) + 0x3c) + 0xc);
		    uVar1 = 0;
		    uVar3 = func_ii_1081(DAT_ram_00a66958,&local_c);
		    uVar2 = StringLiteral_21202;
		    iVar7 = *piVar5;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      do {
		        if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		            *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		          puVar4 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 200);
		          goto code_r0x81043bc5;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		    }
		    puVar4 = (uint *)func_ii_1080(piVar5,Core_Analytics_Service_IAnalyticsApi_TypeInfo,1);
		code_r0x81043bc5:
		    (**(code **)((ulonglong)*puVar4 * 4))(piVar5,uVar2,uVar3,puVar4[1]);
		    piVar5 = *(int **)(param1 + 8);
		    uVar1 = 0;
		    uVar3 = Core_Extensions_Dict_ClanCultDicExt__GetTitle(*(undefined4 *)(iVar6 + 0x20),0);
		    uVar2 = StringLiteral_21203;
		    iVar6 = *piVar5;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      do {
		        if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		            *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		          puVar4 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 200);
		          goto code_r0x81043c5f;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		    }
		    puVar4 = (uint *)func_ii_1080(piVar5,Core_Analytics_Service_IAnalyticsApi_TypeInfo,1);
		code_r0x81043c5f:
		    (**(code **)((ulonglong)*puVar4 * 4))(piVar5,uVar2,uVar3,puVar4[1]);
		    piVar5 = *(int **)(param1 + 8);
		    uVar1 = 0;
		    uVar2 = Core_Data_UserData__get_ClanId(param2,0);
		    local_d = (undefined1)uVar2;
		    uVar3 = func_ii_1081(DAT_ram_00a66944,&local_d);
		    uVar2 = StringLiteral_21194;
		    iVar6 = *piVar5;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      do {
		        if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		            *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		          puVar4 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 200);
		          goto code_r0x81043d0b;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		    }
		    puVar4 = (uint *)func_ii_1080(piVar5,Core_Analytics_Service_IAnalyticsApi_TypeInfo,1);
		code_r0x81043d0b:
		    (**(code **)((ulonglong)*puVar4 * 4))(piVar5,uVar2,uVar3,puVar4[1]);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06007338 RID: 29496 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007338")]
		[Address(RVA = "0xBD41", Offset = "0xBD41", VA = "0xBD41")]
		private void SetClan(UserData userData)
		{
		/* --- GHIDRA: SetClan ---
		void Core_Analytics_Listeners_UserAnalyticsListener__SetClan
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  Core_Analytics_Listeners_UserAnalyticsListener__BalanceChangedEvent
		            (param1,*(undefined4 *)(param2 + 0x10),param2);
		  return;
		}
		*/

		}

		// Token: 0x06007339 RID: 29497 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007339")]
		[Address(RVA = "0xBD42", Offset = "0xBD42", VA = "0xBD42")]
		private void BalanceChangedEvent(UserScope.BaseUserEventArgs e)
		{
		/* --- GHIDRA: BalanceChangedEvent ---
		void Core_Analytics_Listeners_UserAnalyticsListener__BalanceChangedEvent
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  uint uVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  int *piVar5;
		  int iVar6;
		  float8 local_28;
		  float8 local_20;
		  float8 local_18;
		  float8 local_10;
		  float8 local_8;
		  
		  if (DAT_ram_00a59663 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_20458);
		    Mono_Security_ASN1__get_Item(&StringLiteral_20457);
		    Mono_Security_ASN1__get_Item(&StringLiteral_20461);
		    Mono_Security_ASN1__get_Item(&StringLiteral_20455);
		    Mono_Security_ASN1__get_Item(&StringLiteral_20456);
		    DAT_ram_00a59663 = '\x01';
		  }
		  if (*(int *)(param2 + 0x78) != 0) {
		    piVar5 = *(int **)(param1 + 8);
		    local_8 = *(float8 *)(*(int *)(param2 + 0x78) + 0x18);
		    uVar2 = 0;
		    uVar3 = func_ii_1081(DAT_ram_00a66970,&local_8);
		    uVar1 = StringLiteral_20457;
		    iVar6 = *piVar5;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      do {
		        if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		            *(int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8)) {
		          puVar4 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8 + 4) * 8 + iVar6 + 200);
		          goto code_r0x81045f63;
		        }
		        uVar2 = uVar2 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar2);
		    }
		    puVar4 = (uint *)func_ii_1080(piVar5,Core_Analytics_Service_IAnalyticsApi_TypeInfo,1);
		code_r0x81045f63:
		    (**(code **)((ulonglong)*puVar4 * 4))(piVar5,uVar1,uVar3,puVar4[1]);
		    piVar5 = *(int **)(param1 + 8);
		    local_10 = *(float8 *)(*(int *)(param2 + 0x78) + 0x10);
		    uVar2 = 0;
		    uVar3 = func_ii_1081(DAT_ram_00a66970,&local_10);
		    uVar1 = StringLiteral_20456;
		    iVar6 = *piVar5;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      do {
		        if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		            *(int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8)) {
		          puVar4 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8 + 4) * 8 + iVar6 + 200);
		          goto code_r0x8104600f;
		        }
		        uVar2 = uVar2 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar2);
		    }
		    puVar4 = (uint *)func_ii_1080(piVar5,Core_Analytics_Service_IAnalyticsApi_TypeInfo,1);
		code_r0x8104600f:
		    (**(code **)((ulonglong)*puVar4 * 4))(piVar5,uVar1,uVar3,puVar4[1]);
		    piVar5 = *(int **)(param1 + 8);
		    local_18 = *(float8 *)(*(int *)(param2 + 0x78) + 0x28);
		    uVar2 = 0;
		    uVar3 = func_ii_1081(DAT_ram_00a66970,&local_18);
		    uVar1 = StringLiteral_20461;
		    iVar6 = *piVar5;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      do {
		        if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		            *(int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8)) {
		          puVar4 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8 + 4) * 8 + iVar6 + 200);
		          goto code_r0x810460bb;
		        }
		        uVar2 = uVar2 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar2);
		    }
		    puVar4 = (uint *)func_ii_1080(piVar5,Core_Analytics_Service_IAnalyticsApi_TypeInfo,1);
		code_r0x810460bb:
		    (**(code **)((ulonglong)*puVar4 * 4))(piVar5,uVar1,uVar3,puVar4[1]);
		    piVar5 = *(int **)(param1 + 8);
		    local_20 = *(float8 *)(*(int *)(param2 + 0x78) + 0x30);
		    uVar2 = 0;
		    uVar3 = func_ii_1081(DAT_ram_00a66970,&local_20);
		    uVar1 = StringLiteral_20455;
		    iVar6 = *piVar5;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      do {
		        if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		            *(int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8)) {
		          puVar4 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8 + 4) * 8 + iVar6 + 200);
		          goto code_r0x81046167;
		        }
		        uVar2 = uVar2 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar2);
		    }
		    puVar4 = (uint *)func_ii_1080(piVar5,Core_Analytics_Service_IAnalyticsApi_TypeInfo,1);
		code_r0x81046167:
		    (**(code **)((ulonglong)*puVar4 * 4))(piVar5,uVar1,uVar3,puVar4[1]);
		    piVar5 = *(int **)(param1 + 8);
		    local_28 = *(float8 *)(*(int *)(param2 + 0x78) + 0x20);
		    uVar2 = 0;
		    uVar3 = func_ii_1081(DAT_ram_00a66970,&local_28);
		    uVar1 = StringLiteral_20458;
		    iVar6 = *piVar5;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      do {
		        if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		            *(int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8)) {
		          puVar4 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8 + 4) * 8 + iVar6 + 200);
		          goto code_r0x81046213;
		        }
		        uVar2 = uVar2 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar2);
		    }
		    puVar4 = (uint *)func_ii_1080(piVar5,Core_Analytics_Service_IAnalyticsApi_TypeInfo,1);
		code_r0x81046213:
		    (**(code **)((ulonglong)*puVar4 * 4))(piVar5,uVar1,uVar3,puVar4[1]);
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600733A RID: 29498 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600733A")]
		[Address(RVA = "0xBD43", Offset = "0xBD43", VA = "0xBD43")]
		private void SetBalanceProperties(UserData userData)
		{
		/* --- GHIDRA: SetBalanceProperties ---
		void Core_Analytics_Listeners_UserAnalyticsListener__SetBalanceProperties
		               (undefined4 param1,undefined4 param2)
		
		{
		  Core_Analytics_Listeners_AbstractAnalyticsListener__GetResourceAnalyticsName(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x0600733B RID: 29499 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600733B")]
		[Address(RVA = "0xBD44", Offset = "0xBD44", VA = "0xBD44")]
		public UserAnalyticsListener()
		{
		/* --- GHIDRA: .ctor ---
		void Core_Analytics_Listeners_UserAnalyticsListener___ctor(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a59664 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Listeners_UserAnalyticsListener___c_TypeInfo);
		    DAT_ram_00a59664 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Core_Analytics_Listeners_UserAnalyticsListener___c_TypeInfo);
		  **(undefined4 **)(Core_Analytics_Listeners_UserAnalyticsListener___c_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x04003C50 RID: 15440
		[Token(Token = "0x4003C50")]
		private const string NICK_CHANGED = "nick_changed";

		// Token: 0x04003C51 RID: 15441
		[Token(Token = "0x4003C51")]
		public const string LEVEL_CHANGED = "level_changed";

		// Token: 0x04003C52 RID: 15442
		[Token(Token = "0x4003C52")]
		private const string BUY_TREE_LICENCE = "buy_tree_licence";

		// Token: 0x04003C53 RID: 15443
		[Token(Token = "0x4003C53")]
		[FieldOffset(Offset = "0x10")]
		private List<TriggerDic> _loggableTriggers;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Theme ---
		void Core_Analytics_Listeners_UserAnalyticsListener__get_Theme(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a5964f == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_UserScope_BaseUserEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_UserAnalyticsListener_AccountsChangedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_UserAnalyticsListener_AprChangedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_UserAnalyticsListener_BalanceChangedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_UserAnalyticsListener_BuyTreeLicenceSuccessEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_UserAnalyticsListener_CultChangedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_UserAnalyticsListener_ExpChangedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_UserAnalyticsListener_GenderChangedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_UserAnalyticsListener_LevelChangedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_UserAnalyticsListener_NickChangedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_UserAnalyticsListener_SkillsChangedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_UserAnalyticsListener_TreeLicenceCountChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_UserAnalyticsListener_TriggersChangedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_UserAnalyticsListener_UserClanUpdatedEventHandler__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_UserAnalyticsListener_UserDataInitializedEvent__);
		    DAT_ram_00a5964f = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0xc);
		  uVar5 = *(undefined4 *)(iVar4 + 0xc);
		  uVar2 = unnamed_function_1417(System_Action_UserScope_BaseUserEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_UserAnalyticsListener_UserDataInitializedEvent__,0);
		  iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_UserScope_BaseUserEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0xc) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_UserScope_BaseUserEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0xc) = iVar3;
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
		  iVar4 = *(int *)(iVar1 + 0xc);
		  uVar5 = *(undefined4 *)(iVar4 + 8);
		  uVar2 = unnamed_function_1417(System_Action_UserScope_BaseUserEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_UserAnalyticsListener_BalanceChangedEvent__,0);
		  iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_UserScope_BaseUserEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 8) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_UserScope_BaseUserEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 8) = iVar3;
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
		  iVar4 = *(int *)(iVar1 + 0xc);
		  uVar5 = *(undefined4 *)(iVar4 + 0x10);
		  uVar2 = unnamed_function_1417(System_Action_UserScope_BaseUserEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_UserAnalyticsListener_TriggersChangedEvent__,0);
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
		  iVar4 = *(int *)(iVar1 + 0xc);
		  uVar5 = *(undefined4 *)(iVar4 + 0x14);
		  uVar2 = unnamed_function_1417(System_Action_UserScope_BaseUserEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,Method_Core_Analytics_Listeners_UserAnalyticsListener_NickChangedEvent__,0
		            );
		  iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_UserScope_BaseUserEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x14) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_UserScope_BaseUserEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x14) = iVar3;
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
		  iVar4 = *(int *)(iVar1 + 0xc);
		  uVar5 = *(undefined4 *)(iVar4 + 0x24);
		  uVar2 = unnamed_function_1417(System_Action_UserScope_BaseUserEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,Method_Core_Analytics_Listeners_UserAnalyticsListener_AprChangedEvent__,0)
		  ;
		  iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_UserScope_BaseUserEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x24) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_UserScope_BaseUserEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x24) = iVar3;
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
		  iVar4 = *(int *)(iVar1 + 0xc);
		  uVar5 = *(undefined4 *)(iVar4 + 0x1c);
		  uVar2 = unnamed_function_1417(System_Action_UserScope_BaseUserEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,Method_Core_Analytics_Listeners_UserAnalyticsListener_CultChangedEvent__,0
		            );
		  iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_UserScope_BaseUserEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x1c) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_UserScope_BaseUserEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x1c) = iVar3;
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
		  iVar4 = *(int *)(iVar1 + 0xc);
		  uVar5 = *(undefined4 *)(iVar4 + 0x20);
		  uVar2 = unnamed_function_1417(System_Action_UserScope_BaseUserEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,Method_Core_Analytics_Listeners_UserAnalyticsListener_GenderChangedEvent__
		             ,0);
		  iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_UserScope_BaseUserEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x20) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_UserScope_BaseUserEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x20) = iVar3;
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
		  iVar4 = *(int *)(iVar1 + 0xc);
		  uVar5 = *(undefined4 *)(iVar4 + 0x28);
		  uVar2 = unnamed_function_1417(System_Action_UserScope_BaseUserEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,Method_Core_Analytics_Listeners_UserAnalyticsListener_LevelChangedEvent__,
		             0);
		  iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_UserScope_BaseUserEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x28) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_UserScope_BaseUserEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x28) = iVar3;
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
		  iVar4 = *(int *)(iVar1 + 0xc);
		  uVar5 = *(undefined4 *)(iVar4 + 0x18);
		  uVar2 = unnamed_function_1417(System_Action_UserScope_BaseUserEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,Method_Core_Analytics_Listeners_UserAnalyticsListener_SkillsChangedEvent__
		             ,0);
		  iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_UserScope_BaseUserEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x18) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_UserScope_BaseUserEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x18) = iVar3;
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
		  iVar4 = *(int *)(iVar1 + 0xc);
		  uVar5 = *(undefined4 *)(iVar4 + 0x2c);
		  uVar2 = unnamed_function_1417(System_Action_UserScope_BaseUserEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,Method_Core_Analytics_Listeners_UserAnalyticsListener_ExpChangedEvent__,0)
		  ;
		  iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_UserScope_BaseUserEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x2c) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_UserScope_BaseUserEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x2c) = iVar3;
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
		  iVar4 = *(int *)(iVar1 + 0xc);
		  uVar5 = *(undefined4 *)(iVar4 + 0x30);
		  uVar2 = unnamed_function_1417(System_Action_UserScope_BaseUserEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_UserAnalyticsListener_AccountsChangedEvent__,0);
		  iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_UserScope_BaseUserEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x30) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_UserScope_BaseUserEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x30) = iVar3;
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
		  iVar4 = *(int *)(iVar1 + 0xc);
		  uVar5 = *(undefined4 *)(iVar4 + 0x34);
		  uVar2 = unnamed_function_1417(System_Action_UserScope_BaseUserEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_UserAnalyticsListener_TreeLicenceCountChangedEvent__,0)
		  ;
		  iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_UserScope_BaseUserEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x34) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_UserScope_BaseUserEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x34) = iVar3;
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
		  iVar4 = *(int *)(iVar1 + 0xc);
		  uVar5 = *(undefined4 *)(iVar4 + 0x38);
		  uVar2 = unnamed_function_1417(System_Action_UserScope_BaseUserEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_UserAnalyticsListener_BuyTreeLicenceSuccessEvent__,0);
		  iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_UserScope_BaseUserEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x38) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_UserScope_BaseUserEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x38) = iVar3;
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
		  iVar4 = *(int *)(iVar1 + 0xc);
		  uVar5 = *(undefined4 *)(iVar4 + 0x3c);
		  uVar2 = unnamed_function_1417(System_Action_UserScope_BaseUserEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_UserAnalyticsListener_UserClanUpdatedEventHandler__,0);
		  iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_UserScope_BaseUserEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x3c) = 0;
		    return;
		  }
		  iVar3 = func_ii_1082(iVar1,System_Action_UserScope_BaseUserEventArgs__TypeInfo);
		  if (iVar3 != 0) {
		    *(int *)(iVar4 + 0x3c) = iVar3;
		    uVar2 = System_Action_UserScope_BaseUserEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_UserScope_BaseUserEventArgs__TypeInfo);
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
