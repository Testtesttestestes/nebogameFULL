using System;
using Core.Events.Scopes;
using Il2CppDummyDll;

namespace Core.Analytics.Listeners
{
	// Token: 0x020012D0 RID: 4816
	[Token(Token = "0x20012D0")]
	public class GdEventsAnalyticListener : AbstractAnalyticsListener
	{
		// Token: 0x17001734 RID: 5940
		// (get) Token: 0x0600727F RID: 29311 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001734")]
		protected override string Theme
		{
			[Token(Token = "0x600727F")]
			[Address(RVA = "0xBC88", Offset = "0xBC88", VA = "0xBC88", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x06007280 RID: 29312 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007280")]
		[Address(RVA = "0xBC89", Offset = "0xBC89", VA = "0xBC89", Slot = "10")]
		public override void Init()
		{
		/* --- GHIDRA: Init ---
		void Core_Analytics_Listeners_GdEventsAnalyticListener__Init(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a595ca == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_GdEventsScope_CompletionsArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_GdEventsScope_Args__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_GdEventsAnalyticListener_HandleEvtCompleteEvent__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Analytics_Listeners_GdEventsAnalyticListener_HandleGameActivityNavigationEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Analytics_Listeners_GdEventsAnalyticListener_HandleMilestoneCompleteEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Analytics_Listeners_GdEventsAnalyticListener_HandleMilestoneSelectedEvent__
		              );
		    DAT_ram_00a595ca = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x94);
		  uVar5 = *(undefined4 *)(iVar4 + 8);
		  uVar2 = unnamed_function_1417(System_Action_GdEventsScope_Args__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_GdEventsAnalyticListener_HandleMilestoneSelectedEvent__
		             ,0);
		  iVar1 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_GdEventsScope_Args__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 8) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_GdEventsScope_Args__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 8) = iVar3;
		    uVar2 = System_Action_GdEventsScope_Args__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_GdEventsScope_Args__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x94);
		  uVar5 = *(undefined4 *)(iVar4 + 0xc);
		  uVar2 = unnamed_function_1417(System_Action_GdEventsScope_Args__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_GdEventsAnalyticListener_HandleGameActivityNavigationEvent__
		             ,0);
		  iVar1 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_GdEventsScope_Args__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0xc) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_GdEventsScope_Args__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0xc) = iVar3;
		    uVar2 = System_Action_GdEventsScope_Args__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_GdEventsScope_Args__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x94);
		  uVar5 = *(undefined4 *)(iVar4 + 0x10);
		  uVar2 = unnamed_function_1417(System_Action_GdEventsScope_CompletionsArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_GdEventsAnalyticListener_HandleMilestoneCompleteEvent__
		             ,0);
		  iVar1 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_GdEventsScope_CompletionsArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x10) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_GdEventsScope_CompletionsArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x10) = iVar3;
		    uVar2 = System_Action_GdEventsScope_CompletionsArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_GdEventsScope_CompletionsArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x94);
		  uVar5 = *(undefined4 *)(iVar4 + 0x14);
		  uVar2 = unnamed_function_1417(System_Action_GdEventsScope_CompletionsArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_GdEventsAnalyticListener_HandleEvtCompleteEvent__,0);
		  iVar1 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_GdEventsScope_CompletionsArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x14) = 0;
		    return;
		  }
		  iVar3 = func_ii_1082(iVar1,System_Action_GdEventsScope_CompletionsArgs__TypeInfo);
		  if (iVar3 != 0) {
		    *(int *)(iVar4 + 0x14) = iVar3;
		    uVar2 = System_Action_GdEventsScope_CompletionsArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_GdEventsScope_CompletionsArgs__TypeInfo);
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

		// Token: 0x06007281 RID: 29313 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007281")]
		[Address(RVA = "0xBC8A", Offset = "0xBC8A", VA = "0xBC8A", Slot = "11")]
		protected override void Deinit()
		{
		/* --- GHIDRA: Deinit ---
		void Core_Analytics_Listeners_GdEventsAnalyticListener__Deinit
		               (int *param1,int *param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  uint uVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  uint *puVar5;
		  int *param1_00;
		  int iVar6;
		  
		  if (DAT_ram_00a595cb == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_21872);
		    DAT_ram_00a595cb = '\x01';
		  }
		  param1_00 = (int *)param1[2];
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xec));
		  uVar4 = (**(code **)((ulonglong)*(uint *)(*param2 + 0xe0) * 4))
		                    (param2,*(undefined4 *)(*param2 + 0xe4));
		  uVar1 = StringLiteral_21872;
		  iVar6 = *param1_00;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar2 = 0;
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8)) {
		        puVar5 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8 + 4) * 8 + iVar6 + 0xd8);
		        goto code_r0x81035606;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar2);
		  }
		  puVar5 = (uint *)func_ii_1080(param1_00,Core_Analytics_Service_IAnalyticsApi_TypeInfo,3);
		code_r0x81035606:
		  (**(code **)((ulonglong)*puVar5 * 4))(param1_00,uVar3,uVar1,uVar4,puVar5[1]);
		  return;
		}
		*/

		}

		// Token: 0x06007282 RID: 29314 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007282")]
		[Address(RVA = "0xBC8B", Offset = "0xBC8B", VA = "0xBC8B")]
		private void HandleEvtCompleteEvent(GdEventsScope.CompletionsArgs args)
		{
		/* --- GHIDRA: HandleEvtCompleteEvent ---
		void Core_Analytics_Listeners_GdEventsAnalyticListener__HandleEvtCompleteEvent
		               (int *param1,int *param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  uint uVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  uint *puVar5;
		  int *param1_00;
		  int iVar6;
		  
		  if (DAT_ram_00a595cc == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25392);
		    DAT_ram_00a595cc = '\x01';
		  }
		  param1_00 = (int *)param1[2];
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xec));
		  uVar4 = (**(code **)((ulonglong)*(uint *)(*param2 + 0xe0) * 4))
		                    (param2,*(undefined4 *)(*param2 + 0xe4));
		  uVar1 = StringLiteral_25392;
		  iVar6 = *param1_00;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar2 = 0;
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8)) {
		        puVar5 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8 + 4) * 8 + iVar6 + 0xd8);
		        goto code_r0x810356f1;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar2);
		  }
		  puVar5 = (uint *)func_ii_1080(param1_00,Core_Analytics_Service_IAnalyticsApi_TypeInfo,3);
		code_r0x810356f1:
		  (**(code **)((ulonglong)*puVar5 * 4))(param1_00,uVar3,uVar1,uVar4,puVar5[1]);
		  return;
		}
		*/

		}

		// Token: 0x06007283 RID: 29315 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007283")]
		[Address(RVA = "0xBC8C", Offset = "0xBC8C", VA = "0xBC8C")]
		private void HandleMilestoneCompleteEvent(GdEventsScope.CompletionsArgs args)
		{
		/* --- GHIDRA: HandleMilestoneCompleteEvent ---
		void Core_Analytics_Listeners_GdEventsAnalyticListener__HandleMilestoneCompleteEvent
		               (int *param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 param1_00;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  int *param1_01;
		  int iVar5;
		  
		  if (DAT_ram_00a595cd == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Facebook_Unity_Utilities_AddAllKVPFrom_string__object___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_23312);
		    DAT_ram_00a595cd = '\x01';
		  }
		  param1_00 = Core_Analytics_Listeners_AbstractAnalyticsListener__RemoveService(param1,0);
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param2 + 0xe0) * 4))
		                    (param2,*(undefined4 *)(*param2 + 0xe4));
		  BestHTTP_SignalRCore_UploadItemControllerExtensions__UploadParam___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType____Il2CppFullySharedGenericType____Il2CppFullySharedGenericType____Il2CppFullySharedGenericType____Il2CppFullySharedGenericType_
		            (param1_00,uVar2,Method_Facebook_Unity_Utilities_AddAllKVPFrom_string__object___);
		  param1_01 = (int *)param1[2];
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xec));
		  uVar2 = StringLiteral_23312;
		  iVar5 = *param1_01;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd8);
		        goto code_r0x810357f8;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(param1_01,Core_Analytics_Service_IAnalyticsApi_TypeInfo,3);
		code_r0x810357f8:
		  (**(code **)((ulonglong)*puVar4 * 4))(param1_01,uVar3,uVar2,param1_00,puVar4[1]);
		  return;
		}
		*/

		}

		// Token: 0x06007284 RID: 29316 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007284")]
		[Address(RVA = "0xBC8D", Offset = "0xBC8D", VA = "0xBC8D")]
		private void HandleGameActivityNavigationEvent(GdEventsScope.Args args)
		{
		/* --- GHIDRA: HandleGameActivityNavigationEvent ---
		void Core_Analytics_Listeners_GdEventsAnalyticListener__HandleGameActivityNavigationEvent
		               (int *param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 param1_00;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  int *param1_01;
		  int iVar5;
		  
		  if (DAT_ram_00a595ce == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Facebook_Unity_Utilities_AddAllKVPFrom_string__object___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25395);
		    DAT_ram_00a595ce = '\x01';
		  }
		  param1_00 = Core_Analytics_Listeners_AbstractAnalyticsListener__RemoveService(param1,0);
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param2 + 0xe0) * 4))
		                    (param2,*(undefined4 *)(*param2 + 0xe4));
		  BestHTTP_SignalRCore_UploadItemControllerExtensions__UploadParam___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType____Il2CppFullySharedGenericType____Il2CppFullySharedGenericType____Il2CppFullySharedGenericType____Il2CppFullySharedGenericType_
		            (param1_00,uVar2,Method_Facebook_Unity_Utilities_AddAllKVPFrom_string__object___);
		  param1_01 = (int *)param1[2];
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xec));
		  uVar2 = StringLiteral_25395;
		  iVar5 = *param1_01;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd8);
		        goto code_r0x810358ff;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(param1_01,Core_Analytics_Service_IAnalyticsApi_TypeInfo,3);
		code_r0x810358ff:
		  (**(code **)((ulonglong)*puVar4 * 4))(param1_01,uVar3,uVar2,param1_00,puVar4[1]);
		  return;
		}
		*/

		}

		// Token: 0x06007285 RID: 29317 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007285")]
		[Address(RVA = "0xBC8E", Offset = "0xBC8E", VA = "0xBC8E")]
		private void HandleMilestoneSelectedEvent(GdEventsScope.Args args)
		{
		}

		// Token: 0x06007286 RID: 29318 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007286")]
		[Address(RVA = "0xBC8F", Offset = "0xBC8F", VA = "0xBC8F")]
		public GdEventsAnalyticListener()
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Core_Analytics_Listeners_GdEventsAnalyticListener___ctor(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a595cf == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_24204);
		    DAT_ram_00a595cf = '\x01';
		  }
		  return StringLiteral_24204;
		}
		*/

		}

		// Token: 0x04003C00 RID: 15360
		[Token(Token = "0x4003C00")]
		public const string THEME = "gdevents";

		// Token: 0x04003C01 RID: 15361
		[Token(Token = "0x4003C01")]
		private const string GAME_ACTIVITY_NAVIGATION = "game_activity_navigation";

		// Token: 0x04003C02 RID: 15362
		[Token(Token = "0x4003C02")]
		public const string MILESTONE_SELECTED = "milestone_selected";

		// Token: 0x04003C03 RID: 15363
		[Token(Token = "0x4003C03")]
		private const string COMPLETE = "complete";

		// Token: 0x04003C04 RID: 15364
		[Token(Token = "0x4003C04")]
		private const string MILESTINE_COMPLETE = "milestine_complete";
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Theme ---
		void Core_Analytics_Listeners_GdEventsAnalyticListener__get_Theme(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a595c9 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_GdEventsScope_CompletionsArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_GdEventsScope_Args__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_GdEventsAnalyticListener_HandleEvtCompleteEvent__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Analytics_Listeners_GdEventsAnalyticListener_HandleGameActivityNavigationEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Analytics_Listeners_GdEventsAnalyticListener_HandleMilestoneCompleteEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Analytics_Listeners_GdEventsAnalyticListener_HandleMilestoneSelectedEvent__
		              );
		    DAT_ram_00a595c9 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x94);
		  uVar5 = *(undefined4 *)(iVar4 + 8);
		  uVar2 = unnamed_function_1417(System_Action_GdEventsScope_Args__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_GdEventsAnalyticListener_HandleMilestoneSelectedEvent__
		             ,0);
		  iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_GdEventsScope_Args__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 8) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_GdEventsScope_Args__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 8) = iVar3;
		    uVar2 = System_Action_GdEventsScope_Args__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_GdEventsScope_Args__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x94);
		  uVar5 = *(undefined4 *)(iVar4 + 0xc);
		  uVar2 = unnamed_function_1417(System_Action_GdEventsScope_Args__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_GdEventsAnalyticListener_HandleGameActivityNavigationEvent__
		             ,0);
		  iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_GdEventsScope_Args__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0xc) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_GdEventsScope_Args__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0xc) = iVar3;
		    uVar2 = System_Action_GdEventsScope_Args__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_GdEventsScope_Args__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x94);
		  uVar5 = *(undefined4 *)(iVar4 + 0x10);
		  uVar2 = unnamed_function_1417(System_Action_GdEventsScope_CompletionsArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_GdEventsAnalyticListener_HandleMilestoneCompleteEvent__
		             ,0);
		  iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_GdEventsScope_CompletionsArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x10) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_GdEventsScope_CompletionsArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x10) = iVar3;
		    uVar2 = System_Action_GdEventsScope_CompletionsArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_GdEventsScope_CompletionsArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x94);
		  uVar5 = *(undefined4 *)(iVar4 + 0x14);
		  uVar2 = unnamed_function_1417(System_Action_GdEventsScope_CompletionsArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_GdEventsAnalyticListener_HandleEvtCompleteEvent__,0);
		  iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_GdEventsScope_CompletionsArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x14) = 0;
		    return;
		  }
		  iVar3 = func_ii_1082(iVar1,System_Action_GdEventsScope_CompletionsArgs__TypeInfo);
		  if (iVar3 != 0) {
		    *(int *)(iVar4 + 0x14) = iVar3;
		    uVar2 = System_Action_GdEventsScope_CompletionsArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_GdEventsScope_CompletionsArgs__TypeInfo);
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
