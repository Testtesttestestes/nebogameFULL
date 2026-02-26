using System;
using System.Collections.Generic;
using Core.Gameplay.Managers.Ad.Events;
using Core.Gameplay.Managers.Ad.Model;
using Il2CppDummyDll;

namespace Core.Gameplay.Managers.Ad.Statistics
{
	// Token: 0x020011F8 RID: 4600
	[Token(Token = "0x20011F8")]
	public class AdStatisticsHelper : IDisposable
	{
		// Token: 0x06006D42 RID: 27970 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D42")]
		[Address(RVA = "0xB82A", Offset = "0xB82A", VA = "0xB82A")]
		public AdStatisticsHelper(AdManager adManager)
		{
		/* --- GHIDRA: .ctor ---
		void Core_Gameplay_Managers_Ad_Statistics_AdStatisticsHelper___ctor
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int iVar3;
		  longlong lVar4;
		  int local_24;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5a75f == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_string__AdTransactionStatisticsInfo__TryGetValue__
		              );
		    Mono_Security_ASN1__get_Item(&StringLiteral_440);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2923);
		    DAT_ram_00a5a75f = '\x01';
		  }
		  local_24 = 0;
		  uVar1 = Core_Gameplay_Managers_Ad_Model_AdTransaction__set_Payload(param2,0);
		  iVar2 = Newtonsoft_Json_Serialization_JsonSerializerInternalReader__ShouldDeserialize(uVar1,0);
		  if ((iVar2 == 0) &&
		     (iVar3 = Spine_Unity_AttachmentTools_AttachmentRegionExtensions__GetRegion
		                        (*(undefined4 *)(param1 + 0x10),uVar1,&local_24,
		                         Method_System_Collections_Generic_Dictionary_string__AdTransactionStatisticsInfo__TryGetValue__
		                        ), iVar2 = local_24, iVar3 != 0)) {
		    if (DAT_ram_00a5a764 == '\0') {
		      Mono_Security_ASN1__get_Item(&System_DateTimeOffset_TypeInfo);
		      DAT_ram_00a5a764 = '\x01';
		    }
		    if (*(int *)(System_DateTimeOffset_TypeInfo + 0x74) == 0) {
		      func_ii_306000(System_DateTimeOffset_TypeInfo);
		    }
		    func_ii_13875(&local_20,0);
		    local_8 = local_18;
		    local_10 = local_20;
		    lVar4 = System_DateTimeOffset__get_UtcNow(&local_10,0);
		    *(double *)(iVar2 + 0x20) = (double)lVar4;
		  }
		  else {
		    uVar1 = UnityEngine_AndroidJavaObject__FromJavaArray_Nullable_int__
		                      (StringLiteral_2923,uVar1,StringLiteral_440,0);
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    func_ii_7830(uVar1,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06006D43 RID: 27971 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D43")]
		[Address(RVA = "0xB82B", Offset = "0xB82B", VA = "0xB82B")]
		private void AdRewardedEvent(AdTransaction transactionData)
		{
		/* --- GHIDRA: AdRewardedEvent ---
		void Core_Gameplay_Managers_Ad_Statistics_AdStatisticsHelper__AdRewardedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 param1_00;
		  undefined4 uVar3;
		  longlong lVar4;
		  undefined4 param3_00;
		  int local_24;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5a760 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_AdScope_AdTransactionInfoEventArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_string__AdTransactionStatisticsInfo__TryGetValue__
		              );
		    Mono_Security_ASN1__get_Item(&StringLiteral_440);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2923);
		    DAT_ram_00a5a760 = '\x01';
		  }
		  local_24 = 0;
		  iVar1 = Spine_Unity_AttachmentTools_AttachmentRegionExtensions__GetRegion
		                    (*(undefined4 *)(param1 + 0x10),param2,&local_24,
		                     Method_System_Collections_Generic_Dictionary_string__AdTransactionStatisticsInfo__TryGetValue__
		                    );
		  iVar2 = local_24;
		  if (iVar1 == 0) {
		    uVar3 = UnityEngine_AndroidJavaObject__FromJavaArray_Nullable_int__
		                      (StringLiteral_2923,param2,StringLiteral_440,0);
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    func_ii_7830(uVar3,0);
		  }
		  else {
		    if (DAT_ram_00a5a765 == '\0') {
		      Mono_Security_ASN1__get_Item(&System_DateTimeOffset_TypeInfo);
		      DAT_ram_00a5a765 = '\x01';
		    }
		    if (*(int *)(System_DateTimeOffset_TypeInfo + 0x74) == 0) {
		      func_ii_306000(System_DateTimeOffset_TypeInfo);
		    }
		    func_ii_13875(&local_20,0);
		    local_8 = local_18;
		    local_10 = local_20;
		    lVar4 = System_DateTimeOffset__get_UtcNow(&local_10,0);
		    *(double *)(iVar2 + 0x28) = (double)lVar4;
		    iVar2 = System_Uri___ctor(0);
		    iVar2 = *(int *)(*(int *)(*(int *)(*(int *)(iVar2 + 0x38) + 0x10) + 0x90) + 0x1c);
		    if (iVar2 != 0) {
		      uVar3 = System_Uri___ctor(0);
		      if (DAT_ram_00a6456f == '\0') {
		        Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		        DAT_ram_00a6456f = '\x01';
		      }
		      iVar1 = local_24;
		      param3_00 = **(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		      param1_00 = unnamed_function_1417
		                            (Core_Events_Scopes_AdScope_AdTransactionInfoEventArgs_TypeInfo);
		      Core_Events_Scopes_UserScope_BaseUserEventArgs__set_UserData
		                (param1_00,uVar3,param3_00,iVar1,0);
		      (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                (*(undefined4 *)(iVar2 + 0x20),param1_00,*(undefined4 *)(iVar2 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06006D44 RID: 27972 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D44")]
		[Address(RVA = "0xB82C", Offset = "0xB82C", VA = "0xB82C")]
		private void TransactionClosedEvent(string transactionId)
		{
		/* --- GHIDRA: TransactionClosedEvent ---
		void Core_Gameplay_Managers_Ad_Statistics_AdStatisticsHelper__TransactionClosedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5a761 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Core_Gameplay_Managers_Ad_Statistics_AdTransactionStatisticsInfo_TypeInfo);
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_string__AdTransactionStatisticsInfo__Add__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_string__AdTransactionStatisticsInfo__ContainsKey__
		              );
		    Mono_Security_ASN1__get_Item(&StringLiteral_273);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2925);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2924);
		    DAT_ram_00a5a761 = '\x01';
		  }
		  uVar3 = *(undefined4 *)(param1 + 0x10);
		  uVar1 = Core_Gameplay_Managers_Ad_Model_AdTransaction__set_Payload(param2,0);
		  iVar2 = System_Xml_Schema_SchemaInfo__get_Notations
		                    (uVar3,uVar1,
		                     Method_System_Collections_Generic_Dictionary_string__AdTransactionStatisticsInfo__ContainsKey__
		                    );
		  uVar1 = Core_Gameplay_Managers_Ad_Model_AdTransaction__set_Payload(param2,0);
		  if (iVar2 != 0) {
		    uVar1 = UnityEngine_AndroidJavaObject__FromJavaArray_Nullable_int__
		                      (StringLiteral_2925,uVar1,StringLiteral_273,0);
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    func_ii_7830(uVar1,0);
		    return;
		  }
		  uVar1 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(StringLiteral_2924,uVar1,0);
		  if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		    func_ii_306000(OKG_Logs_Debug_TypeInfo);
		  }
		  System_Collections_Generic_Dictionary_uint__object___get_Count(uVar1,0);
		  param1_00 = *(undefined4 *)(param1 + 0x10);
		  uVar1 = Core_Gameplay_Managers_Ad_Model_AdTransaction__set_Payload(param2,0);
		  uVar3 = unnamed_function_1417
		                    (Core_Gameplay_Managers_Ad_Statistics_AdTransactionStatisticsInfo_TypeInfo);
		  Core_Gameplay_Managers_Ad_Statistics_AdTransactionStatisticsInfo__set_CloseTime
		            (uVar3,param2,param2);
		  System_Reflection_FieldInfo__get_IsStatic
		            (param1_00,uVar1,uVar3,
		             Method_System_Collections_Generic_Dictionary_string__AdTransactionStatisticsInfo__Add__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06006D45 RID: 27973 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D45")]
		[Address(RVA = "0xB82D", Offset = "0xB82D", VA = "0xB82D")]
		private void TransactionCreatedEvent(AdTransaction transaction)
		{
		/* --- GHIDRA: TransactionCreatedEvent ---
		void Core_Gameplay_Managers_Ad_Statistics_AdStatisticsHelper__TransactionCreatedEvent
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a5a762 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_AdTransaction__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Gameplay_Managers_Ad_Statistics_AdStatisticsHelper_AdRewardedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_Ad_Statistics_AdStatisticsHelper_TransactionClosedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_Ad_Statistics_AdStatisticsHelper_TransactionCreatedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_string__AdTransactionStatisticsInfo__Clear__
		              );
		    DAT_ram_00a5a762 = '\x01';
		  }
		  iVar4 = *(int *)(param1 + 0xc);
		  uVar5 = *(undefined4 *)(iVar4 + 0x1c);
		  uVar1 = unnamed_function_1417(System_Action_AdTransaction__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Core_Gameplay_Managers_Ad_Statistics_AdStatisticsHelper_TransactionCreatedEvent__
		             ,0);
		  iVar2 = func_ii_7048(uVar5,uVar1,0);
		  uVar1 = System_Action_AdTransaction__TypeInfo;
		  if (iVar2 == 0) {
		    *(undefined4 *)(iVar4 + 0x1c) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar2,System_Action_AdTransaction__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x1c) = iVar3;
		    uVar1 = System_Action_AdTransaction__TypeInfo;
		    iVar4 = func_ii_1082(iVar2,System_Action_AdTransaction__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar4 = *(int *)(param1 + 0xc);
		  uVar5 = *(undefined4 *)(iVar4 + 0x20);
		  uVar1 = unnamed_function_1417(System_Action_string__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Core_Gameplay_Managers_Ad_Statistics_AdStatisticsHelper_TransactionClosedEvent__
		             ,0);
		  iVar2 = func_ii_7048(uVar5,uVar1,0);
		  uVar1 = System_Action_string__TypeInfo;
		  if (iVar2 == 0) {
		    *(undefined4 *)(iVar4 + 0x20) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar2,System_Action_string__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x20) = iVar3;
		    uVar1 = System_Action_string__TypeInfo;
		    iVar4 = func_ii_1082(iVar2,System_Action_string__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar4 = *(int *)(param1 + 0xc);
		  uVar5 = *(undefined4 *)(iVar4 + 0x14);
		  uVar1 = unnamed_function_1417(System_Action_AdTransaction__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Core_Gameplay_Managers_Ad_Statistics_AdStatisticsHelper_AdRewardedEvent__,0);
		  iVar2 = func_ii_7048(uVar5,uVar1,0);
		  uVar1 = System_Action_AdTransaction__TypeInfo;
		  if (iVar2 == 0) {
		    *(undefined4 *)(iVar4 + 0x14) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar2,System_Action_AdTransaction__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x14) = iVar3;
		    uVar1 = System_Action_AdTransaction__TypeInfo;
		    iVar4 = func_ii_1082(iVar2,System_Action_AdTransaction__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  *(undefined8 *)(param1 + 8) = 0;
		  System_Xml_XmlWellFormedWriter__PushNamespaceImplicit
		            (*(undefined4 *)(param1 + 0x10),
		             Method_System_Collections_Generic_Dictionary_string__AdTransactionStatisticsInfo__Clear__
		            );
		  *(undefined4 *)(param1 + 0x10) = 0;
		  return;
		}
		*/

		}

		// Token: 0x06006D46 RID: 27974 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D46")]
		[Address(RVA = "0xB82E", Offset = "0xB82E", VA = "0xB82E", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x0400392D RID: 14637
		[Token(Token = "0x400392D")]
		[FieldOffset(Offset = "0x8")]
		private AdManager _adManager;

		// Token: 0x0400392E RID: 14638
		[Token(Token = "0x400392E")]
		[FieldOffset(Offset = "0xC")]
		private AdEvents _events;

		// Token: 0x0400392F RID: 14639
		[Token(Token = "0x400392F")]
		[FieldOffset(Offset = "0x10")]
		private Dictionary<string, AdTransactionStatisticsInfo> _transactions;
	}
}
