using System;
using Core.Net.Monitor.Responseability.Testing.Common;
using Il2CppDummyDll;

namespace Core.Net.Monitor.Responseability
{
	// Token: 0x02000E94 RID: 3732
	[Token(Token = "0x2000E94")]
	public class FrequencyLimitHttpNetTestLauncher : INetTestLauncher
	{
		// Token: 0x06005AC0 RID: 23232 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005AC0")]
		[Address(RVA = "0xA7AB", Offset = "0xA7AB", VA = "0xA7AB")]
		public FrequencyLimitHttpNetTestLauncher(long period, Uri uri, Configuration configuration, object syncMonitor)
		{
		/* --- GHIDRA: .ctor ---
		uint Core_Net_Monitor_Responseability_FrequencyLimitHttpNetTestLauncher___ctor
		               (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint uVar2;
		  
		  uVar2 = *(int *)(*(int *)(param1 + 0xc) + 8) << 2;
		  uVar1 = 1;
		  if (1 < uVar2) {
		    uVar1 = uVar2;
		  }
		  return uVar1;
		}
		*/

		}

		// Token: 0x17001282 RID: 4738
		// (get) Token: 0x06005AC1 RID: 23233 RVA: 0x00010200 File Offset: 0x0000E400
		[Token(Token = "0x17001282")]
		private int DampingThreshold
		{
			[Token(Token = "0x6005AC1")]
			[Address(RVA = "0xA7AC", Offset = "0xA7AC", VA = "0xA7AC")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06005AC2 RID: 23234 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005AC2")]
		[Address(RVA = "0xA7AD", Offset = "0xA7AD", VA = "0xA7AD")]
		private void SetCount(long value)
		{
		/* --- GHIDRA: SetCount ---
		void Core_Net_Monitor_Responseability_FrequencyLimitHttpNetTestLauncher__SetCount
		               (int param1,undefined4 param2)
		
		{
		  longlong lVar1;
		  undefined8 uVar2;
		  undefined8 local_30;
		  undefined8 local_28;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a605a1 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_DateTimeOffset_TypeInfo);
		    DAT_ram_00a605a1 = '\x01';
		  }
		  if (*(int *)(System_DateTimeOffset_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_DateTimeOffset_TypeInfo);
		  }
		  func_ii_13875(&local_20,0);
		  local_8 = local_18;
		  local_10 = local_20;
		  lVar1 = System_DateTimeOffset__get_UtcNow(&local_10,0);
		  *(longlong *)(param1 + 0x30) = lVar1 - *(longlong *)(param1 + 0x28);
		  func_ii_13875(&local_30,0);
		  local_8 = local_28;
		  local_10 = local_30;
		  uVar2 = System_DateTimeOffset__get_UtcNow(&local_10,0);
		  *(undefined8 *)(param1 + 0x28) = uVar2;
		  return;
		}
		*/

		}

		// Token: 0x06005AC3 RID: 23235 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005AC3")]
		[Address(RVA = "0xA7AE", Offset = "0xA7AE", VA = "0xA7AE")]
		private void CommitTimes()
		{
		/* --- GHIDRA: CommitTimes ---
		undefined4
		Core_Net_Monitor_Responseability_FrequencyLimitHttpNetTestLauncher__CommitTimes
		          (int param1,undefined4 *param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  longlong lVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  uint uVar5;
		  int iVar6;
		  uint uVar7;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  param1_00 = 0;
		  if (DAT_ram_00a605a2 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_DateTimeOffset_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Core_Net_Monitor_Responseability_Testing_Http_HttpNetTest_TypeInfo);
		    DAT_ram_00a605a2 = '\x01';
		  }
		  if (*(longlong *)(param1 + 0x20) == 0) {
		    Core_Net_Monitor_Responseability_FrequencyLimitHttpNetTestLauncher__SetCount(param1,param1);
		    lVar2 = *(longlong *)(param1 + 0x20) + 1;
		    *(longlong *)(param1 + 0x20) = lVar2;
		    uVar1 = 1;
		    iVar6 = *(int *)(param1 + 0xc);
		    uVar7 = *(int *)(iVar6 + 8) << 2;
		    uVar5 = 1;
		    if (1 < uVar7) {
		      uVar5 = uVar7;
		    }
		    if (lVar2 % (longlong)(int)uVar5 == 0) {
		      *(int *)(param1 + 0x38) = *(int *)(param1 + 0x38) + 1;
		    }
		    uVar3 = *(undefined4 *)(param1 + 0x10);
		    uVar4 = *(undefined4 *)(param1 + 8);
		    param1_00 = unnamed_function_1417
		                          (Core_Net_Monitor_Responseability_Testing_Http_HttpNetTest_TypeInfo);
		    Core_Net_Monitor_Responseability_Testing_Http_HttpNetTest__Dispose
		              (param1_00,uVar4,iVar6,uVar3,uVar4);
		  }
		  else {
		    if (*(int *)(System_DateTimeOffset_TypeInfo + 0x74) == 0) {
		      func_ii_306000(System_DateTimeOffset_TypeInfo);
		    }
		    func_ii_13875(&local_20,0);
		    local_8 = local_18;
		    local_10 = local_20;
		    lVar2 = System_DateTimeOffset__get_UtcNow(&local_10,0);
		    lVar2 = lVar2 - *(longlong *)(param1 + 0x28);
		    *(longlong *)(param1 + 0x30) = lVar2;
		    uVar1 = 0;
		    if (*(longlong *)(param1 + 0x18) * (longlong)*(int *)(param1 + 0x38) <= lVar2) {
		      Core_Net_Monitor_Responseability_FrequencyLimitHttpNetTestLauncher__SetCount(param1,param1);
		      lVar2 = *(longlong *)(param1 + 0x20) + 1;
		      *(longlong *)(param1 + 0x20) = lVar2;
		      uVar1 = 1;
		      iVar6 = *(int *)(param1 + 0xc);
		      uVar7 = *(int *)(iVar6 + 8) << 2;
		      uVar5 = 1;
		      if (1 < uVar7) {
		        uVar5 = uVar7;
		      }
		      if (lVar2 % (longlong)(int)uVar5 == 0) {
		        *(int *)(param1 + 0x38) = *(int *)(param1 + 0x38) + 1;
		      }
		      uVar3 = *(undefined4 *)(param1 + 0x10);
		      uVar4 = *(undefined4 *)(param1 + 8);
		      param1_00 = unnamed_function_1417
		                            (Core_Net_Monitor_Responseability_Testing_Http_HttpNetTest_TypeInfo);
		      Core_Net_Monitor_Responseability_Testing_Http_HttpNetTest__Dispose
		                (param1_00,uVar4,iVar6,uVar3,uVar4);
		    }
		  }
		  *param2 = param1_00;
		  return uVar1;
		}
		*/

		}

		// Token: 0x06005AC4 RID: 23236 RVA: 0x00010218 File Offset: 0x0000E418
		[Token(Token = "0x6005AC4")]
		[Address(RVA = "0xA7AF", Offset = "0xA7AF", VA = "0xA7AF", Slot = "4")]
		public bool TryCreateTest(out INetTest test)
		{
		/* --- GHIDRA: TryCreateTest ---
		undefined4
		Core_Net_Monitor_Responseability_FrequencyLimitHttpNetTestLauncher__TryCreateTest
		          (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  longlong lVar2;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a605a3 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_TimeSpan_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_14354);
		    DAT_ram_00a605a3 = '\x01';
		  }
		  lVar2 = *(longlong *)(param1 + 0x30);
		  if (*(int *)(System_TimeSpan_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_TimeSpan_TypeInfo);
		  }
		  local_8 = func_ii_7125((double)lVar2,0);
		  uVar1 = func_ii_1081(System_TimeSpan_TypeInfo,&local_8);
		  uVar1 = func_ii_4419(StringLiteral_14354,uVar1,0);
		  return uVar1;
		}
		*/

			return default(bool);
		}

		// Token: 0x06005AC5 RID: 23237 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005AC5")]
		[Address(RVA = "0xA7B0", Offset = "0xA7B0", VA = "0xA7B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x04003198 RID: 12696
		[Token(Token = "0x4003198")]
		[FieldOffset(Offset = "0x8")]
		private readonly Uri _uri;

		// Token: 0x04003199 RID: 12697
		[Token(Token = "0x4003199")]
		[FieldOffset(Offset = "0xC")]
		private readonly Configuration _configuration;

		// Token: 0x0400319A RID: 12698
		[Token(Token = "0x400319A")]
		[FieldOffset(Offset = "0x10")]
		private object _syncMonitor;

		// Token: 0x0400319B RID: 12699
		[Token(Token = "0x400319B")]
		[FieldOffset(Offset = "0x18")]
		private readonly long _period;

		// Token: 0x0400319C RID: 12700
		[Token(Token = "0x400319C")]
		[FieldOffset(Offset = "0x20")]
		private long _count;

		// Token: 0x0400319D RID: 12701
		[Token(Token = "0x400319D")]
		[FieldOffset(Offset = "0x28")]
		private long _last;

		// Token: 0x0400319E RID: 12702
		[Token(Token = "0x400319E")]
		[FieldOffset(Offset = "0x30")]
		private long _sinceCall;

		// Token: 0x0400319F RID: 12703
		[Token(Token = "0x400319F")]
		[FieldOffset(Offset = "0x38")]
		private int _dampingCoeff;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_DampingThreshold ---
		void Core_Net_Monitor_Responseability_FrequencyLimitHttpNetTestLauncher__get_DampingThreshold
		               (int param1,longlong param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint uVar2;
		  
		  if (*(longlong *)(param1 + 0x20) != param2) {
		    *(longlong *)(param1 + 0x20) = param2;
		    uVar2 = *(int *)(*(int *)(param1 + 0xc) + 8) << 2;
		    uVar1 = 1;
		    if (1 < uVar2) {
		      uVar1 = uVar2;
		    }
		    if (param2 % (longlong)(int)uVar1 == 0) {
		      *(int *)(param1 + 0x38) = *(int *)(param1 + 0x38) + 1;
		    }
		  }
		  return;
		}
		*/

}
