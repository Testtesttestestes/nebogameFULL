using System;
using Core.Events.Scopes;
using Il2CppDummyDll;

namespace Core.Analytics.Listeners
{
	// Token: 0x020012BD RID: 4797
	[Token(Token = "0x20012BD")]
	public class AnalyticsEventMediatorListener : AbstractAnalyticsListener
	{
		// Token: 0x17001722 RID: 5922
		// (get) Token: 0x060071E5 RID: 29157 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001722")]
		protected override string Theme
		{
			[Token(Token = "0x60071E5")]
			[Address(RVA = "0xBBEE", Offset = "0xBBEE", VA = "0xBBEE", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x060071E6 RID: 29158 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60071E6")]
		[Address(RVA = "0xBBEF", Offset = "0xBBEF", VA = "0xBBEF", Slot = "10")]
		public override void Init()
		{
		/* --- GHIDRA: Init ---
		void Core_Analytics_Listeners_AnalyticsEventMediatorListener__Init
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  uint uVar2;
		  undefined4 param1_00;
		  undefined4 uVar3;
		  uint *puVar4;
		  int *param1_01;
		  int iVar5;
		  
		  if (DAT_ram_00a59543 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_23038);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26192);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27884);
		    DAT_ram_00a59543 = '\x01';
		  }
		  if (DAT_ram_00a59526 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_string__object__TypeInfo);
		    DAT_ram_00a59526 = '\x01';
		  }
		  uVar2 = 0;
		  param1_00 = unnamed_function_1417(System_Collections_Generic_Dictionary_string__object__TypeInfo);
		  System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		            (param1_00,Method_System_Collections_Generic_Dictionary_string__object___ctor__);
		  func_ii_2946(param1_00,StringLiteral_23038,*(undefined4 *)(param2 + 8),
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  func_ii_2946(param1_00,StringLiteral_26192,*(undefined4 *)(param2 + 0xc),
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  param1_01 = (int *)param1[2];
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xec));
		  uVar1 = StringLiteral_27884;
		  iVar5 = *param1_01;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar2 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar2 * 8 + 4) * 8 + iVar5 + 0xd8);
		        goto code_r0x81025866;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar2);
		  }
		  puVar4 = (uint *)func_ii_1080(param1_01,Core_Analytics_Service_IAnalyticsApi_TypeInfo,3);
		code_r0x81025866:
		  (**(code **)((ulonglong)*puVar4 * 4))(param1_01,uVar3,uVar1,param1_00,puVar4[1]);
		  return;
		}
		*/

		}

		// Token: 0x060071E7 RID: 29159 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60071E7")]
		[Address(RVA = "0xBBF0", Offset = "0xBBF0", VA = "0xBBF0")]
		private void OnTutorialStepEvent(AnalyticsEventMediatorScope.AnalyticsEventMediatorArgs args)
		{
		/* --- GHIDRA: OnTutorialStepEvent ---
		void Core_Analytics_Listeners_AnalyticsEventMediatorListener__OnTutorialStepEvent
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  uint uVar2;
		  undefined4 param1_00;
		  undefined4 uVar3;
		  uint *puVar4;
		  int *param1_01;
		  int iVar5;
		  
		  if (DAT_ram_00a59544 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_23038);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26192);
		    Mono_Security_ASN1__get_Item(&StringLiteral_23315);
		    DAT_ram_00a59544 = '\x01';
		  }
		  if (DAT_ram_00a59526 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_string__object__TypeInfo);
		    DAT_ram_00a59526 = '\x01';
		  }
		  uVar2 = 0;
		  param1_00 = unnamed_function_1417(System_Collections_Generic_Dictionary_string__object__TypeInfo);
		  System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		            (param1_00,Method_System_Collections_Generic_Dictionary_string__object___ctor__);
		  func_ii_2946(param1_00,StringLiteral_23038,*(undefined4 *)(param2 + 8),
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  func_ii_2946(param1_00,StringLiteral_26192,*(undefined4 *)(param2 + 0xc),
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  param1_01 = (int *)param1[2];
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xec));
		  uVar1 = StringLiteral_23315;
		  iVar5 = *param1_01;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar2 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar2 * 8 + 4) * 8 + iVar5 + 0xd8);
		        goto code_r0x810259c5;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar2);
		  }
		  puVar4 = (uint *)func_ii_1080(param1_01,Core_Analytics_Service_IAnalyticsApi_TypeInfo,3);
		code_r0x810259c5:
		  (**(code **)((ulonglong)*puVar4 * 4))(param1_01,uVar3,uVar1,param1_00,puVar4[1]);
		  return;
		}
		*/

		}

		// Token: 0x060071E8 RID: 29160 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60071E8")]
		[Address(RVA = "0xBBF1", Offset = "0xBBF1", VA = "0xBBF1")]
		private void OnGameLoadingEvent(AnalyticsEventMediatorScope.AnalyticsEventMediatorArgs args)
		{
		/* --- GHIDRA: OnGameLoadingEvent ---
		void Core_Analytics_Listeners_AnalyticsEventMediatorListener__OnGameLoadingEvent
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a59545 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&System_Action_AnalyticsEventMediatorScope_AnalyticsEventMediatorArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_AnalyticsEventMediatorListener_OnGameLoadingEvent__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_AnalyticsEventMediatorListener_OnTutorialStepEvent__
		              );
		    DAT_ram_00a59545 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x14);
		  uVar5 = *(undefined4 *)(iVar4 + 8);
		  uVar2 = unnamed_function_1417
		                    (System_Action_AnalyticsEventMediatorScope_AnalyticsEventMediatorArgs__TypeInfo)
		  ;
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_AnalyticsEventMediatorListener_OnGameLoadingEvent__,0);
		  iVar1 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_AnalyticsEventMediatorScope_AnalyticsEventMediatorArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 8) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,
		                         System_Action_AnalyticsEventMediatorScope_AnalyticsEventMediatorArgs__TypeInfo
		                        );
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 8) = iVar3;
		    uVar2 = System_Action_AnalyticsEventMediatorScope_AnalyticsEventMediatorArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,
		                         System_Action_AnalyticsEventMediatorScope_AnalyticsEventMediatorArgs__TypeInfo
		                        );
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x14);
		  uVar5 = *(undefined4 *)(iVar4 + 0xc);
		  uVar2 = unnamed_function_1417
		                    (System_Action_AnalyticsEventMediatorScope_AnalyticsEventMediatorArgs__TypeInfo)
		  ;
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_AnalyticsEventMediatorListener_OnTutorialStepEvent__,0)
		  ;
		  iVar1 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_AnalyticsEventMediatorScope_AnalyticsEventMediatorArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0xc) = 0;
		    return;
		  }
		  iVar3 = func_ii_1082(iVar1,
		                       System_Action_AnalyticsEventMediatorScope_AnalyticsEventMediatorArgs__TypeInfo
		                      );
		  if (iVar3 != 0) {
		    *(int *)(iVar4 + 0xc) = iVar3;
		    uVar2 = System_Action_AnalyticsEventMediatorScope_AnalyticsEventMediatorArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,
		                         System_Action_AnalyticsEventMediatorScope_AnalyticsEventMediatorArgs__TypeInfo
		                        );
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

		// Token: 0x060071E9 RID: 29161 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60071E9")]
		[Address(RVA = "0xBBF2", Offset = "0xBBF2", VA = "0xBBF2", Slot = "11")]
		protected override void Deinit()
		{
		}

		// Token: 0x060071EA RID: 29162 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60071EA")]
		[Address(RVA = "0xBBF3", Offset = "0xBBF3", VA = "0xBBF3")]
		public AnalyticsEventMediatorListener()
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Core_Analytics_Listeners_AnalyticsEventMediatorListener___ctor(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a59546 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_19850);
		    DAT_ram_00a59546 = '\x01';
		  }
		  return StringLiteral_19850;
		}
		*/

		}

		// Token: 0x04003BAB RID: 15275
		[Token(Token = "0x4003BAB")]
		public const string THEME = "analytics_event_mediator";

		// Token: 0x04003BAC RID: 15276
		[Token(Token = "0x4003BAC")]
		public const string GAME_LOADING = "game_loading";

		// Token: 0x04003BAD RID: 15277
		[Token(Token = "0x4003BAD")]
		public const string TUTORIAL_STEP_NEW = "tutorial_step_new";
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Theme ---
		void Core_Analytics_Listeners_AnalyticsEventMediatorListener__get_Theme
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a59542 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&System_Action_AnalyticsEventMediatorScope_AnalyticsEventMediatorArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_AnalyticsEventMediatorListener_OnGameLoadingEvent__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_AnalyticsEventMediatorListener_OnTutorialStepEvent__
		              );
		    DAT_ram_00a59542 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x14);
		  uVar5 = *(undefined4 *)(iVar4 + 8);
		  uVar2 = unnamed_function_1417
		                    (System_Action_AnalyticsEventMediatorScope_AnalyticsEventMediatorArgs__TypeInfo)
		  ;
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_AnalyticsEventMediatorListener_OnGameLoadingEvent__,0);
		  iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_AnalyticsEventMediatorScope_AnalyticsEventMediatorArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 8) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,
		                         System_Action_AnalyticsEventMediatorScope_AnalyticsEventMediatorArgs__TypeInfo
		                        );
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 8) = iVar3;
		    uVar2 = System_Action_AnalyticsEventMediatorScope_AnalyticsEventMediatorArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,
		                         System_Action_AnalyticsEventMediatorScope_AnalyticsEventMediatorArgs__TypeInfo
		                        );
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x14);
		  uVar5 = *(undefined4 *)(iVar4 + 0xc);
		  uVar2 = unnamed_function_1417
		                    (System_Action_AnalyticsEventMediatorScope_AnalyticsEventMediatorArgs__TypeInfo)
		  ;
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_AnalyticsEventMediatorListener_OnTutorialStepEvent__,0)
		  ;
		  iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_AnalyticsEventMediatorScope_AnalyticsEventMediatorArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0xc) = 0;
		    return;
		  }
		  iVar3 = func_ii_1082(iVar1,
		                       System_Action_AnalyticsEventMediatorScope_AnalyticsEventMediatorArgs__TypeInfo
		                      );
		  if (iVar3 != 0) {
		    *(int *)(iVar4 + 0xc) = iVar3;
		    uVar2 = System_Action_AnalyticsEventMediatorScope_AnalyticsEventMediatorArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,
		                         System_Action_AnalyticsEventMediatorScope_AnalyticsEventMediatorArgs__TypeInfo
		                        );
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
