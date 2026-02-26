using System;
using Core.Events;
using Core.Events.Scopes;
using Il2CppDummyDll;

namespace Core.Analytics.Listeners
{
	// Token: 0x020012DB RID: 4827
	[Token(Token = "0x20012DB")]
	public class RateGameAnalyticsListener : AbstractAnalyticsListener
	{
		// Token: 0x1700173F RID: 5951
		// (get) Token: 0x060072D2 RID: 29394 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700173F")]
		protected override string Theme
		{
			[Token(Token = "0x60072D2")]
			[Address(RVA = "0xBCDB", Offset = "0xBCDB", VA = "0xBCDB", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x060072D3 RID: 29395 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072D3")]
		[Address(RVA = "0xBCDC", Offset = "0xBCDC", VA = "0xBCDC", Slot = "10")]
		public override void Init()
		{
		/* --- GHIDRA: Init ---
		void Core_Analytics_Listeners_RateGameAnalyticsListener__Init(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a59613 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_BaseEventBusEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_RateGameScope_RateGameEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Analytics_Listeners_RateGameAnalyticsListener_CloseButtonClickedAfterPositiveRateEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_RateGameAnalyticsListener_RateGameCancelEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_RateGameAnalyticsListener_RateGameRequestEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_RateGameAnalyticsListener_RateGameSuccessEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_RateGameAnalyticsListener_StoreButtonClickEvent__);
		    DAT_ram_00a59613 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x88);
		  uVar5 = *(undefined4 *)(iVar4 + 8);
		  uVar2 = unnamed_function_1417(System_Action_BaseEventBusEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_RateGameAnalyticsListener_RateGameCancelEvent__,0);
		  iVar1 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_BaseEventBusEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 8) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_BaseEventBusEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 8) = iVar3;
		    uVar2 = System_Action_BaseEventBusEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_BaseEventBusEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x88);
		  uVar5 = *(undefined4 *)(iVar4 + 0x18);
		  uVar2 = unnamed_function_1417(System_Action_RateGameScope_RateGameEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_RateGameAnalyticsListener_RateGameSuccessEvent__,0);
		  iVar1 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_RateGameScope_RateGameEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x18) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_RateGameScope_RateGameEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x18) = iVar3;
		    uVar2 = System_Action_RateGameScope_RateGameEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_RateGameScope_RateGameEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x88);
		  uVar5 = *(undefined4 *)(iVar4 + 0x14);
		  uVar2 = unnamed_function_1417(System_Action_RateGameScope_RateGameEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_RateGameAnalyticsListener_RateGameRequestEvent__,0);
		  iVar1 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_RateGameScope_RateGameEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x14) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_RateGameScope_RateGameEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x14) = iVar3;
		    uVar2 = System_Action_RateGameScope_RateGameEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_RateGameScope_RateGameEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x88);
		  uVar5 = *(undefined4 *)(iVar4 + 0x10);
		  uVar2 = unnamed_function_1417(System_Action_BaseEventBusEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_RateGameAnalyticsListener_StoreButtonClickEvent__,0);
		  iVar1 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_BaseEventBusEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x10) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_BaseEventBusEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x10) = iVar3;
		    uVar2 = System_Action_BaseEventBusEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_BaseEventBusEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x88);
		  uVar5 = *(undefined4 *)(iVar4 + 0xc);
		  uVar2 = unnamed_function_1417(System_Action_BaseEventBusEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_RateGameAnalyticsListener_CloseButtonClickedAfterPositiveRateEvent__
		             ,0);
		  iVar1 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_BaseEventBusEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0xc) = 0;
		    return;
		  }
		  iVar3 = func_ii_1082(iVar1,System_Action_BaseEventBusEventArgs__TypeInfo);
		  if (iVar3 != 0) {
		    *(int *)(iVar4 + 0xc) = iVar3;
		    uVar2 = System_Action_BaseEventBusEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_BaseEventBusEventArgs__TypeInfo);
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

		// Token: 0x060072D4 RID: 29396 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072D4")]
		[Address(RVA = "0xBCDD", Offset = "0xBCDD", VA = "0xBCDD", Slot = "11")]
		protected override void Deinit()
		{
		/* --- GHIDRA: Deinit ---
		void Core_Analytics_Listeners_RateGameAnalyticsListener__Deinit
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  uint uVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  uint *puVar5;
		  int *param1_00;
		  int iVar6;
		  
		  if (DAT_ram_00a59614 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_21239);
		    DAT_ram_00a59614 = '\x01';
		  }
		  uVar3 = Core_Analytics_Listeners_AbstractAnalyticsListener__RemoveService(param1,0);
		  param1_00 = (int *)param1[2];
		  uVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xec));
		  uVar1 = StringLiteral_21239;
		  iVar6 = *param1_00;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar2 = 0;
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8)) {
		        puVar5 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8 + 4) * 8 + iVar6 + 0xd8);
		        goto code_r0x8103ce9e;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar2);
		  }
		  puVar5 = (uint *)func_ii_1080(param1_00,Core_Analytics_Service_IAnalyticsApi_TypeInfo,3);
		code_r0x8103ce9e:
		  (**(code **)((ulonglong)*puVar5 * 4))(param1_00,uVar4,uVar1,uVar3,puVar5[1]);
		  return;
		}
		*/

		}

		// Token: 0x060072D5 RID: 29397 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072D5")]
		[Address(RVA = "0xBCDE", Offset = "0xBCDE", VA = "0xBCDE")]
		private void CloseButtonClickedAfterPositiveRateEvent(BaseEventBusEventArgs obj)
		{
		/* --- GHIDRA: CloseButtonClickedAfterPositiveRateEvent ---
		void Core_Analytics_Listeners_RateGameAnalyticsListener__CloseButtonClickedAfterPositiveRateEvent
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  uint uVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  uint *puVar5;
		  int *param1_00;
		  int iVar6;
		  
		  if (DAT_ram_00a59615 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27465);
		    DAT_ram_00a59615 = '\x01';
		  }
		  uVar3 = Core_Analytics_Listeners_AbstractAnalyticsListener__RemoveService(param1,0);
		  param1_00 = (int *)param1[2];
		  uVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xec));
		  uVar1 = StringLiteral_27465;
		  iVar6 = *param1_00;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar2 = 0;
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8)) {
		        puVar5 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8 + 4) * 8 + iVar6 + 0xd8);
		        goto code_r0x8103cf7b;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar2);
		  }
		  puVar5 = (uint *)func_ii_1080(param1_00,Core_Analytics_Service_IAnalyticsApi_TypeInfo,3);
		code_r0x8103cf7b:
		  (**(code **)((ulonglong)*puVar5 * 4))(param1_00,uVar4,uVar1,uVar3,puVar5[1]);
		  return;
		}
		*/

		}

		// Token: 0x060072D6 RID: 29398 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072D6")]
		[Address(RVA = "0xBCDF", Offset = "0xBCDF", VA = "0xBCDF")]
		private void StoreButtonClickEvent(BaseEventBusEventArgs obj)
		{
		/* --- GHIDRA: StoreButtonClickEvent ---
		void Core_Analytics_Listeners_RateGameAnalyticsListener__StoreButtonClickEvent
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
		  
		  if (DAT_ram_00a59616 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26298);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26301);
		    DAT_ram_00a59616 = '\x01';
		  }
		  param1_00 = Core_Analytics_Listeners_AbstractAnalyticsListener__RemoveService(param1,0);
		  local_4 = *(undefined4 *)(param2 + 0x10);
		  uVar2 = func_ii_1081(DAT_ram_00a66958,&local_4);
		  func_ii_2946(param1_00,StringLiteral_26298,uVar2,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  param1_01 = (int *)param1[2];
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xec));
		  uVar2 = StringLiteral_26301;
		  iVar5 = *param1_01;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd8);
		        goto code_r0x8103d0a5;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(param1_01,Core_Analytics_Service_IAnalyticsApi_TypeInfo,3);
		code_r0x8103d0a5:
		  (**(code **)((ulonglong)*puVar4 * 4))(param1_01,uVar3,uVar2,param1_00,puVar4[1]);
		  return;
		}
		*/

		}

		// Token: 0x060072D7 RID: 29399 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072D7")]
		[Address(RVA = "0xBCE0", Offset = "0xBCE0", VA = "0xBCE0")]
		private void RateGameRequestEvent(RateGameScope.RateGameEventArgs e)
		{
		/* --- GHIDRA: RateGameRequestEvent ---
		void Core_Analytics_Listeners_RateGameAnalyticsListener__RateGameRequestEvent
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
		  
		  if (DAT_ram_00a59617 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26298);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26302);
		    DAT_ram_00a59617 = '\x01';
		  }
		  param1_00 = Core_Analytics_Listeners_AbstractAnalyticsListener__RemoveService(param1,0);
		  local_4 = *(undefined4 *)(param2 + 0x10);
		  uVar2 = func_ii_1081(DAT_ram_00a66958,&local_4);
		  func_ii_2946(param1_00,StringLiteral_26298,uVar2,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  param1_01 = (int *)param1[2];
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xec));
		  uVar2 = StringLiteral_26302;
		  iVar5 = *param1_01;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd8);
		        goto code_r0x8103d1d6;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(param1_01,Core_Analytics_Service_IAnalyticsApi_TypeInfo,3);
		code_r0x8103d1d6:
		  (**(code **)((ulonglong)*puVar4 * 4))(param1_01,uVar3,uVar2,param1_00,puVar4[1]);
		  return;
		}
		*/

		}

		// Token: 0x060072D8 RID: 29400 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072D8")]
		[Address(RVA = "0xBCE1", Offset = "0xBCE1", VA = "0xBCE1")]
		private void RateGameSuccessEvent(RateGameScope.RateGameEventArgs e)
		{
		/* --- GHIDRA: RateGameSuccessEvent ---
		void Core_Analytics_Listeners_RateGameAnalyticsListener__RateGameSuccessEvent
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  uint uVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  uint *puVar5;
		  int *param1_00;
		  int iVar6;
		  
		  if (DAT_ram_00a59618 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26300);
		    DAT_ram_00a59618 = '\x01';
		  }
		  uVar3 = Core_Analytics_Listeners_AbstractAnalyticsListener__RemoveService(param1,0);
		  param1_00 = (int *)param1[2];
		  uVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xec));
		  uVar1 = StringLiteral_26300;
		  iVar6 = *param1_00;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar2 = 0;
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8)) {
		        puVar5 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8 + 4) * 8 + iVar6 + 0xd8);
		        goto code_r0x8103d2ba;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar2);
		  }
		  puVar5 = (uint *)func_ii_1080(param1_00,Core_Analytics_Service_IAnalyticsApi_TypeInfo,3);
		code_r0x8103d2ba:
		  (**(code **)((ulonglong)*puVar5 * 4))(param1_00,uVar4,uVar1,uVar3,puVar5[1]);
		  return;
		}
		*/

		}

		// Token: 0x060072D9 RID: 29401 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072D9")]
		[Address(RVA = "0xBCE2", Offset = "0xBCE2", VA = "0xBCE2")]
		private void RateGameCancelEvent(BaseEventBusEventArgs e)
		{
		}

		// Token: 0x060072DA RID: 29402 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072DA")]
		[Address(RVA = "0xBCE3", Offset = "0xBCE3", VA = "0xBCE3")]
		public RateGameAnalyticsListener()
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Core_Analytics_Listeners_RateGameAnalyticsListener___ctor(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a59619 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_26575);
		    DAT_ram_00a59619 = '\x01';
		  }
		  return StringLiteral_26575;
		}
		*/

		}

		// Token: 0x04003C23 RID: 15395
		[Token(Token = "0x4003C23")]
		private const string RATE_GAME_CANCEL = "rate_game_cancel";

		// Token: 0x04003C24 RID: 15396
		[Token(Token = "0x4003C24")]
		private const string RATE_GAME_REQUEST = "rate_game_request";

		// Token: 0x04003C25 RID: 15397
		[Token(Token = "0x4003C25")]
		private const string RATE_GAME_SUCCESS = "rate_game_success";

		// Token: 0x04003C26 RID: 15398
		[Token(Token = "0x4003C26")]
		private const string STORE_BUTTON_CLICK = "store_button_click";

		// Token: 0x04003C27 RID: 15399
		[Token(Token = "0x4003C27")]
		private const string CLOSE_BUTTON_CLICK_ON_POSITIVE_RATE = "close_button_click_on_positive_rate";
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Theme ---
		void Core_Analytics_Listeners_RateGameAnalyticsListener__get_Theme(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a59612 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_BaseEventBusEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_RateGameScope_RateGameEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Analytics_Listeners_RateGameAnalyticsListener_CloseButtonClickedAfterPositiveRateEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_RateGameAnalyticsListener_RateGameCancelEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_RateGameAnalyticsListener_RateGameRequestEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_RateGameAnalyticsListener_RateGameSuccessEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_RateGameAnalyticsListener_StoreButtonClickEvent__);
		    DAT_ram_00a59612 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x88);
		  uVar5 = *(undefined4 *)(iVar4 + 8);
		  uVar2 = unnamed_function_1417(System_Action_BaseEventBusEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_RateGameAnalyticsListener_RateGameCancelEvent__,0);
		  iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_BaseEventBusEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 8) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_BaseEventBusEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 8) = iVar3;
		    uVar2 = System_Action_BaseEventBusEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_BaseEventBusEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x88);
		  uVar5 = *(undefined4 *)(iVar4 + 0x18);
		  uVar2 = unnamed_function_1417(System_Action_RateGameScope_RateGameEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_RateGameAnalyticsListener_RateGameSuccessEvent__,0);
		  iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_RateGameScope_RateGameEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x18) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_RateGameScope_RateGameEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x18) = iVar3;
		    uVar2 = System_Action_RateGameScope_RateGameEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_RateGameScope_RateGameEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x88);
		  uVar5 = *(undefined4 *)(iVar4 + 0x14);
		  uVar2 = unnamed_function_1417(System_Action_RateGameScope_RateGameEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_RateGameAnalyticsListener_RateGameRequestEvent__,0);
		  iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_RateGameScope_RateGameEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x14) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_RateGameScope_RateGameEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x14) = iVar3;
		    uVar2 = System_Action_RateGameScope_RateGameEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_RateGameScope_RateGameEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x88);
		  uVar5 = *(undefined4 *)(iVar4 + 0x10);
		  uVar2 = unnamed_function_1417(System_Action_BaseEventBusEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_RateGameAnalyticsListener_StoreButtonClickEvent__,0);
		  iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_BaseEventBusEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x10) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_BaseEventBusEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x10) = iVar3;
		    uVar2 = System_Action_BaseEventBusEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_BaseEventBusEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x88);
		  uVar5 = *(undefined4 *)(iVar4 + 0xc);
		  uVar2 = unnamed_function_1417(System_Action_BaseEventBusEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_RateGameAnalyticsListener_CloseButtonClickedAfterPositiveRateEvent__
		             ,0);
		  iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_BaseEventBusEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0xc) = 0;
		    return;
		  }
		  iVar3 = func_ii_1082(iVar1,System_Action_BaseEventBusEventArgs__TypeInfo);
		  if (iVar3 != 0) {
		    *(int *)(iVar4 + 0xc) = iVar3;
		    uVar2 = System_Action_BaseEventBusEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_BaseEventBusEventArgs__TypeInfo);
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
