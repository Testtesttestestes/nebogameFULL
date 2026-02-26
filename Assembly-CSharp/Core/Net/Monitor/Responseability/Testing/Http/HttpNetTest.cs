using System;
using System.Runtime.CompilerServices;
using BestHTTP;
using Core.Net.Monitor.Responseability.Testing.Common;
using Il2CppDummyDll;

namespace Core.Net.Monitor.Responseability.Testing.Http
{
	// Token: 0x02000E9A RID: 3738
	[Token(Token = "0x2000E9A")]
	public class HttpNetTest : INetTest, IDisposable
	{
		// Token: 0x17001285 RID: 4741
		// (get) Token: 0x06005AE7 RID: 23271 RVA: 0x00010248 File Offset: 0x0000E448
		[Token(Token = "0x17001285")]
		public long Index
		{
			[Token(Token = "0x6005AE7")]
			[Address(RVA = "0xA7CA", Offset = "0xA7CA", VA = "0xA7CA", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return 0L;
			}
		}

		// Token: 0x06005AE8 RID: 23272 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005AE8")]
		[Address(RVA = "0xA7CB", Offset = "0xA7CB", VA = "0xA7CB", Slot = "7")]
		public void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Core_Net_Monitor_Responseability_Testing_Http_HttpNetTest__Dispose
		               (int param1,undefined4 param2,int param3,undefined4 param4,undefined4 param5)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  undefined4 param2_00;
		  undefined8 uVar3;
		  int iVar4;
		  longlong lVar5;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a605b3 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_DateTimeOffset_TypeInfo);
		    Mono_Security_ASN1__get_Item(&BestHTTP_HTTPRequest_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Net_Monitor_Responseability_Testing_Http_HttpNetTest_RequestCallback__);
		    Mono_Security_ASN1__get_Item
		              (&Core_Net_Monitor_Responseability_Testing_Http_HttpNetTest_TypeInfo);
		    Mono_Security_ASN1__get_Item(&BestHTTP_OnRequestFinishedDelegate_TypeInfo);
		    DAT_ram_00a605b3 = '\x01';
		  }
		  *(undefined4 *)(param1 + 0x14) = param4;
		  *(int *)(param1 + 0xc) = param3;
		  *(undefined4 *)(param1 + 0x10) = param2;
		  if (0 < *(int *)(param3 + 0x14)) {
		    lVar5 = **(longlong **)
		              (Core_Net_Monitor_Responseability_Testing_Http_HttpNetTest_TypeInfo + 0x5c) + 1;
		    **(longlong **)(Core_Net_Monitor_Responseability_Testing_Http_HttpNetTest_TypeInfo + 0x5c) =
		         lVar5;
		    *(longlong *)(param1 + 0x18) = lVar5;
		    uVar1 = unnamed_function_1417(BestHTTP_HTTPRequest_TypeInfo);
		    BestHTTP_HTTPRequest___ctor(uVar1,param2,0,0);
		    *(undefined4 *)(param1 + 8) = uVar1;
		    BestHTTP_HTTPRequest__get_DisableCache(uVar1,1,0);
		    iVar4 = *(int *)(param1 + 8);
		    uVar1 = unnamed_function_1417(BestHTTP_OnRequestFinishedDelegate_TypeInfo);
		    BestHTTP_HTTPRange__ToString
		              (uVar1,param1,
		               Method_Core_Net_Monitor_Responseability_Testing_Http_HttpNetTest_RequestCallback__,0)
		    ;
		    *(undefined4 *)(iVar4 + 0x2c) = uVar1;
		    if (*(int *)(System_DateTimeOffset_TypeInfo + 0x74) == 0) {
		      func_ii_306000(System_DateTimeOffset_TypeInfo);
		    }
		    func_ii_13875(&local_20,0);
		    local_8 = local_18;
		    local_10 = local_20;
		    uVar3 = System_DateTimeOffset__get_UtcNow(&local_10,0);
		    *(undefined8 *)(param1 + 0x20) = uVar3;
		    BestHTTP_HTTPRequest__CallCustomCertificationValidator(*(undefined4 *)(param1 + 8),0);
		    return;
		  }
		  local_10 = CONCAT44(local_10._4_4_,*(int *)(param3 + 0x14));
		  uVar1 = func_ii_1081(DAT_ram_00a66954,&local_10);
		  uVar2 = unnamed_function_2232(&StringLiteral_28617);
		  param2_00 = unnamed_function_2232(&StringLiteral_8896);
		  uVar1 = System_Collections_Generic_Dictionary_int__object___ContainsKey(uVar2,param2_00,uVar1,0);
		  uVar2 = unnamed_function_2232(&System_Exception_TypeInfo);
		  uVar2 = unnamed_function_1417(uVar2);
		  System_String__Concat(uVar2,uVar1,0);
		  uVar1 = unnamed_function_2232
		                    (&Method_Core_Net_Monitor_Responseability_Testing_Http_HttpNetTest__ctor__);
		  func_ii_1050(uVar2,uVar1);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06005AE9 RID: 23273 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005AE9")]
		[Address(RVA = "0xA7CC", Offset = "0xA7CC", VA = "0xA7CC")]
		public HttpNetTest(Uri url, Configuration configuration, object syncMonitor)
		{
		/* --- GHIDRA: .ctor ---
		void Core_Net_Monitor_Responseability_Testing_Http_HttpNetTest___ctor(int param1,undefined4 param2)
		
		{
		  BestHTTP_HTTPRequest__Send(*(undefined4 *)(param1 + 8),0);
		  return;
		}
		*/

		}

		// Token: 0x06005AEA RID: 23274 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005AEA")]
		[Address(RVA = "0xA7CD", Offset = "0xA7CD", VA = "0xA7CD")]
		private void Stop()
		{
		/* --- GHIDRA: Stop ---
		void Core_Net_Monitor_Responseability_Testing_Http_HttpNetTest__Stop
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  *(undefined4 *)(*(int *)(param1 + 8) + 0x2c) = 0;
		  Core_Net_Monitor_Responseability_Testing_Http_HttpNetTest__RequestCallback(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06005AEB RID: 23275 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005AEB")]
		[Address(RVA = "0xA7CE", Offset = "0xA7CE", VA = "0xA7CE")]
		private void RequestCallback(HTTPRequest request, HTTPResponse response)
		{
		/* --- GHIDRA: RequestCallback ---
		/* WARNING: Removing unreachable block (ram,0x81cae1db) */
		/* WARNING: Removing unreachable block (ram,0x81cae175) */
		
		void Core_Net_Monitor_Responseability_Testing_Http_HttpNetTest__RequestCallback
		               (int param1,undefined4 param2)
		
		{
		  bool bVar1;
		  undefined4 param1_00;
		  int iVar2;
		  int *piVar3;
		  undefined8 uVar4;
		  int iVar5;
		  undefined8 local_38;
		  undefined8 local_30;
		  int local_24;
		  byte *local_20;
		  undefined4 *local_1c;
		  undefined8 local_18;
		  undefined8 local_10;
		  byte local_5;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a605b4 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_DateTimeOffset_TypeInfo);
		    DAT_ram_00a605b4 = '\x01';
		  }
		  local_10 = 0;
		  local_18 = 0;
		  local_4 = *(undefined4 *)(param1 + 0x14);
		  local_5 = 0;
		  DAT_ram_009d3e38 = 0;
		  local_1c = &local_4;
		  local_24 = 0;
		  local_20 = &local_5;
		  import::env::invoke_viii
		            (s_struct_Uniforms___color__array<v_ram_00000aff + 0x48,local_4,&local_5,0);
		  if (DAT_ram_009d3e38 == 1) {
		code_r0x81cae181:
		    DAT_ram_009d3e38 = 0;
		    param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  }
		  else {
		    if (*(int *)(System_DateTimeOffset_TypeInfo + 0x74) == 0) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi
		                (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                 System_DateTimeOffset_TypeInfo);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x81cae181;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_vii(s___Scripting__UnityEngine__Contex_ram_0000360b + 0x29,&local_38,0);
		    iVar5 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar5 == 1) {
		      param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    }
		    else {
		      local_10 = local_30;
		      local_18 = local_38;
		      DAT_ram_009d3e38 = 0;
		      uVar4 = unnamed_function_184054
		                        (s___Scripting__UnityEngine__Contex_ram_0000360b + 0x2a,&local_18,0);
		      iVar5 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar5 != 1) {
		        *(undefined8 *)(param1 + 0x30) = uVar4;
		        bVar1 = true;
		        if (*(int *)(*(int *)(param1 + 8) + 0x84) != 5) {
		          bVar1 = *(int *)(*(int *)(param1 + 8) + 0x84) == 6;
		        }
		        DAT_ram_009d3e38 = 0;
		        *(undefined1 *)(param1 + 0x28) = 1;
		        *(bool *)(param1 + 0x38) = bVar1;
		        iVar5 = 0;
		        goto code_r0x81cae290;
		      }
		      param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    }
		  }
		  iVar5 = global_1;
		  iVar2 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar5 == iVar2) {
		    piVar3 = (int *)import::env::__cxa_begin_catch(param1_00);
		    iVar5 = *piVar3;
		    DAT_ram_009d3e38 = 0;
		    local_24 = iVar5;
		    import::env::invoke_v(0x123);
		    iVar2 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar2 != 1) {
		code_r0x81cae290:
		      if (local_5 != 0) {
		        func_ii_21161(local_4);
		      }
		      if (iVar5 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar5);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      return;
		    }
		    param1_00 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s___Scripting__UnityEngine__UnityS_ram_00003636 + 1,&local_24);
		  iVar5 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar5 != 1) {
		    import::env::__resumeException(param1_00);
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

		// Token: 0x06005AEC RID: 23276 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005AEC")]
		[Address(RVA = "0xA7CF", Offset = "0xA7CF", VA = "0xA7CF")]
		private void Complete()
		{
		/* --- GHIDRA: Complete ---
		longlong Core_Net_Monitor_Responseability_Testing_Http_HttpNetTest__Complete
		                   (int param1,undefined4 param2)
		
		{
		  longlong lVar1;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a605b5 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_DateTimeOffset_TypeInfo);
		    DAT_ram_00a605b5 = '\x01';
		  }
		  if (*(char *)(param1 + 0x28) == '\0') {
		    if (*(int *)(System_DateTimeOffset_TypeInfo + 0x74) == 0) {
		      func_ii_306000(System_DateTimeOffset_TypeInfo);
		    }
		    func_ii_13875(&local_20,0);
		    local_8 = local_18;
		    local_10 = local_20;
		    lVar1 = System_DateTimeOffset__get_UtcNow(&local_10,0);
		    lVar1 = lVar1 - *(longlong *)(param1 + 0x20);
		  }
		  else {
		    lVar1 = *(longlong *)(param1 + 0x30) - *(longlong *)(param1 + 0x20);
		  }
		  return lVar1;
		}
		*/

		}

		// Token: 0x06005AED RID: 23277 RVA: 0x00010260 File Offset: 0x0000E460
		[Token(Token = "0x6005AED")]
		[Address(RVA = "0xA7D0", Offset = "0xA7D0", VA = "0xA7D0")]
		private long GetDuration()
		{
		/* --- GHIDRA: GetDuration ---
		uint Core_Net_Monitor_Responseability_Testing_Http_HttpNetTest__GetDuration
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  uint uVar2;
		  undefined4 param1_00;
		  int iVar3;
		  int *piVar4;
		  longlong lVar5;
		  int local_34;
		  byte *local_30;
		  undefined4 *local_2c;
		  byte local_25;
		  undefined4 local_24;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  iVar3 = 0;
		  local_24 = *(undefined4 *)(param1 + 0x14);
		  local_25 = 0;
		  DAT_ram_009d3e38 = 0;
		  local_2c = &local_24;
		  local_34 = 0;
		  local_30 = &local_25;
		  import::env::invoke_viii
		            (s_struct_Uniforms___color__array<v_ram_00000aff + 0x48,local_24,&local_25,0);
		  iVar1 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar1 == 1) {
		    param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  }
		  else {
		    uVar2 = 1;
		    if ((*(char *)(param1 + 0x28) != '\0') || (uVar2 = 1, *(char *)(param1 + 0x38) != '\0'))
		    goto code_r0x81cae573;
		    if (DAT_ram_00a605b5 == '\0') {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi(0x7ff,&System_DateTimeOffset_TypeInfo);
		      if (DAT_ram_009d3e38 != 1) {
		        DAT_ram_00a605b5 = '\x01';
		        if (*(char *)(param1 + 0x28) == '\0') goto code_r0x81cae43c;
		        lVar5 = *(longlong *)(param1 + 0x30) - *(longlong *)(param1 + 0x20);
		code_r0x81cae4fe:
		        iVar3 = 0;
		        uVar2 = (uint)(*(int *)(*(int *)(param1 + 0xc) + 0x14) < lVar5);
		        goto code_r0x81cae573;
		      }
		    }
		    else {
		code_r0x81cae43c:
		      if (*(int *)(System_DateTimeOffset_TypeInfo + 0x74) == 0) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vi
		                  (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                   System_DateTimeOffset_TypeInfo);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x81cae514;
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vii(s___Scripting__UnityEngine__Contex_ram_0000360b + 0x29,&local_20,0);
		      if (DAT_ram_009d3e38 != 1) {
		        local_8 = local_18;
		        local_10 = local_20;
		        DAT_ram_009d3e38 = 0;
		        lVar5 = unnamed_function_184054
		                          (s___Scripting__UnityEngine__Contex_ram_0000360b + 0x2a,&local_10,0);
		        if (DAT_ram_009d3e38 != 1) {
		          lVar5 = lVar5 - *(longlong *)(param1 + 0x20);
		          goto code_r0x81cae4fe;
		        }
		      }
		    }
		code_r0x81cae514:
		    DAT_ram_009d3e38 = 0;
		    param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  }
		  iVar1 = global_1;
		  iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar1 == iVar3) {
		    piVar4 = (int *)import::env::__cxa_begin_catch(param1_00);
		    iVar3 = *piVar4;
		    DAT_ram_009d3e38 = 0;
		    local_34 = iVar3;
		    import::env::invoke_v(0x123);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    uVar2 = 0;
		    if (iVar1 != 1) {
		code_r0x81cae573:
		      DAT_ram_009d3e38 = 0;
		      if (local_25 != 0) {
		        func_ii_21161(local_24);
		      }
		      if (iVar3 == 0) {
		        return uVar2;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    param1_00 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s___Scripting__UnityEngine__UnityS_ram_00003636 + 2,&local_34);
		  iVar1 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar1 == 1) {
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__resumeException(param1_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

			return 0L;
		}

		// Token: 0x06005AEE RID: 23278 RVA: 0x00010278 File Offset: 0x0000E478
		[Token(Token = "0x6005AEE")]
		[Address(RVA = "0xA7D1", Offset = "0xA7D1", VA = "0xA7D1", Slot = "5")]
		public bool IsComplete()
		{
		/* --- GHIDRA: IsComplete ---
		uint Core_Net_Monitor_Responseability_Testing_Http_HttpNetTest__IsComplete
		               (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  longlong lVar2;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  uVar1 = 1;
		  if (*(char *)(param1 + 0x38) == '\0') {
		    if (DAT_ram_00a605b5 == '\0') {
		      Mono_Security_ASN1__get_Item(&System_DateTimeOffset_TypeInfo);
		      DAT_ram_00a605b5 = '\x01';
		    }
		    if (*(char *)(param1 + 0x28) == '\0') {
		      if (*(int *)(System_DateTimeOffset_TypeInfo + 0x74) == 0) {
		        func_ii_306000(System_DateTimeOffset_TypeInfo);
		      }
		      func_ii_13875(&local_20,0);
		      local_8 = local_18;
		      local_10 = local_20;
		      lVar2 = System_DateTimeOffset__get_UtcNow(&local_10,0);
		      lVar2 = lVar2 - *(longlong *)(param1 + 0x20);
		    }
		    else {
		      lVar2 = *(longlong *)(param1 + 0x30) - *(longlong *)(param1 + 0x20);
		    }
		    uVar1 = (uint)(*(int *)(*(int *)(param1 + 0xc) + 0x14) < lVar2);
		  }
		  return uVar1;
		}
		*/

			return default(bool);
		}

		// Token: 0x06005AEF RID: 23279 RVA: 0x00010290 File Offset: 0x0000E490
		[Token(Token = "0x6005AEF")]
		[Address(RVA = "0xA7D2", Offset = "0xA7D2", VA = "0xA7D2")]
		private bool IsFailed()
		{
		/* --- GHIDRA: IsFailed ---
		undefined4
		Core_Net_Monitor_Responseability_Testing_Http_HttpNetTest__IsFailed(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  longlong lVar2;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  uVar1 = 2;
		  if (*(char *)(param1 + 0x38) == '\0') {
		    if (DAT_ram_00a605b5 == '\0') {
		      Mono_Security_ASN1__get_Item(&System_DateTimeOffset_TypeInfo);
		      DAT_ram_00a605b5 = '\x01';
		    }
		    if (*(char *)(param1 + 0x28) == '\0') {
		      if (*(int *)(System_DateTimeOffset_TypeInfo + 0x74) == 0) {
		        func_ii_306000(System_DateTimeOffset_TypeInfo);
		      }
		      func_ii_13875(&local_20,0);
		      local_8 = local_18;
		      local_10 = local_20;
		      lVar2 = System_DateTimeOffset__get_UtcNow(&local_10,0);
		      lVar2 = lVar2 - *(longlong *)(param1 + 0x20);
		    }
		    else {
		      lVar2 = *(longlong *)(param1 + 0x30) - *(longlong *)(param1 + 0x20);
		    }
		    if (lVar2 <= *(int *)(*(int *)(param1 + 0xc) + 0x14)) {
		      if (DAT_ram_00a605b5 == '\0') {
		        Mono_Security_ASN1__get_Item(&System_DateTimeOffset_TypeInfo);
		        DAT_ram_00a605b5 = '\x01';
		      }
		      if (*(char *)(param1 + 0x28) == '\0') {
		        if (*(int *)(System_DateTimeOffset_TypeInfo + 0x74) == 0) {
		          func_ii_306000(System_DateTimeOffset_TypeInfo);
		        }
		        func_ii_13875(&local_20,0);
		        local_8 = local_18;
		        local_10 = local_20;
		        lVar2 = System_DateTimeOffset__get_UtcNow(&local_10,0);
		        lVar2 = lVar2 - *(longlong *)(param1 + 0x20);
		      }
		      else {
		        lVar2 = *(longlong *)(param1 + 0x30) - *(longlong *)(param1 + 0x20);
		      }
		      if ((lVar2 <= *(int *)(*(int *)(param1 + 0xc) + 0x10)) ||
		         (uVar1 = 1, *(int *)(*(int *)(param1 + 0xc) + 0x14) <= lVar2)) {
		        uVar1 = 0;
		      }
		    }
		  }
		  return uVar1;
		}
		*/

			return default(bool);
		}

		// Token: 0x06005AF0 RID: 23280 RVA: 0x000102A8 File Offset: 0x0000E4A8
		[Token(Token = "0x6005AF0")]
		[Address(RVA = "0xA7D3", Offset = "0xA7D3", VA = "0xA7D3", Slot = "6")]
		public ResponseAbilityStatus GetStatus()
		{
		/* --- GHIDRA: GetStatus ---
		undefined4
		Core_Net_Monitor_Responseability_Testing_Http_HttpNetTest__GetStatus(int param1,undefined4 param2)
		
		{
		  int *param1_00;
		  undefined4 uVar1;
		  undefined4 uVar2;
		  longlong lVar3;
		  int iVar4;
		  double param1_01;
		  undefined1 auStack_30 [6];
		  undefined1 local_2a;
		  undefined1 local_29;
		  undefined8 local_28;
		  undefined4 local_20 [2];
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a605b6 == '\0') {
		    Mono_Security_ASN1__get_Item(&BestHTTP_HTTPRequestStates_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Text_StringBuilder_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_TimeSpan_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_7560);
		    Mono_Security_ASN1__get_Item(&StringLiteral_9837);
		    Mono_Security_ASN1__get_Item(&StringLiteral_9332);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1238);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5524);
		    Mono_Security_ASN1__get_Item(&StringLiteral_9857);
		    Mono_Security_ASN1__get_Item(&StringLiteral_6686);
		    Mono_Security_ASN1__get_Item(&StringLiteral_14643);
		    DAT_ram_00a605b6 = '\x01';
		  }
		  param1_00 = (int *)unnamed_function_1417(System_Text_StringBuilder_TypeInfo);
		  func_ii_2101(param1_00,0);
		  local_28 = *(undefined8 *)(param1 + 0x18);
		  uVar1 = func_ii_1081(DAT_ram_00a66964,&local_28);
		  uVar1 = func_ii_4419(StringLiteral_9332,uVar1,0);
		  func_ii_2010(param1_00,uVar1,0);
		  func_ii_2010(param1_00,StringLiteral_1238,0);
		  uVar1 = Core_Net_Monitor_Responseability_Testing_Http_HttpNetTest__GetDuration(param1,auStack_30);
		  local_29 = (undefined1)uVar1;
		  uVar1 = func_ii_1081(DAT_ram_00a66944,&local_29);
		  uVar1 = func_ii_4419(StringLiteral_9837,uVar1,0);
		  func_ii_2010(param1_00,uVar1,0);
		  func_ii_2010(param1_00,StringLiteral_1238,0);
		  if (*(char *)(param1 + 0x38) == '\0') {
		    if (DAT_ram_00a605b5 == '\0') {
		      Mono_Security_ASN1__get_Item(&System_DateTimeOffset_TypeInfo);
		      DAT_ram_00a605b5 = '\x01';
		    }
		    if (*(char *)(param1 + 0x28) == '\0') {
		      if (*(int *)(System_DateTimeOffset_TypeInfo + 0x74) == 0) {
		        func_ii_306000(System_DateTimeOffset_TypeInfo);
		      }
		      func_ii_13875(local_20,0);
		      local_8 = local_18;
		      lVar3 = System_DateTimeOffset__get_UtcNow(&local_10,0);
		      lVar3 = lVar3 - *(longlong *)(param1 + 0x20);
		    }
		    else {
		      lVar3 = *(longlong *)(param1 + 0x30) - *(longlong *)(param1 + 0x20);
		    }
		    local_2a = *(int *)(*(int *)(param1 + 0xc) + 0x14) < lVar3;
		  }
		  else {
		    local_2a = true;
		  }
		  uVar1 = func_ii_1081(DAT_ram_00a66944,&local_2a);
		  uVar1 = func_ii_4419(StringLiteral_9857,uVar1,0);
		  func_ii_2010(param1_00,uVar1,0);
		  func_ii_2010(param1_00,StringLiteral_1238,0);
		  if (DAT_ram_00a605b5 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_DateTimeOffset_TypeInfo);
		    DAT_ram_00a605b5 = '\x01';
		  }
		  if (*(char *)(param1 + 0x28) == '\0') {
		    if (*(int *)(System_DateTimeOffset_TypeInfo + 0x74) == 0) {
		      func_ii_306000(System_DateTimeOffset_TypeInfo);
		    }
		    func_ii_13875(local_20,0);
		    local_8 = local_18;
		    lVar3 = System_DateTimeOffset__get_UtcNow(&local_10,0);
		    lVar3 = lVar3 - *(longlong *)(param1 + 0x20);
		  }
		  else {
		    lVar3 = *(longlong *)(param1 + 0x30) - *(longlong *)(param1 + 0x20);
		  }
		  if (*(int *)(System_TimeSpan_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_TimeSpan_TypeInfo);
		  }
		  param1_01 = (double)lVar3;
		  local_10 = func_ii_7125(param1_01,0);
		  uVar1 = (undefined4)((ulonglong)param1_01 >> 0x20);
		  uVar2 = func_ii_1081(System_TimeSpan_TypeInfo,&local_10);
		  uVar2 = func_ii_4419(StringLiteral_6686,uVar2,0);
		  func_ii_2010(param1_00,uVar2,0);
		  func_ii_2010(param1_00,StringLiteral_1238,0);
		  local_20[0] = *(undefined4 *)(*(int *)(param1 + 8) + 0x84);
		  uVar2 = func_ii_1081(BestHTTP_HTTPRequestStates_TypeInfo,local_20);
		  uVar2 = func_ii_4419(StringLiteral_14643,uVar2,0);
		  func_ii_2010(param1_00,uVar2,0);
		  iVar4 = *(int *)(param1 + 8);
		  if (*(int *)(iVar4 + 0x5c) != 0) {
		    func_ii_2010(param1_00,StringLiteral_1238,0);
		    local_10 = CONCAT44(local_10._4_4_,*(undefined4 *)(*(int *)(*(int *)(param1 + 8) + 0x5c) + 0x10)
		                       );
		    uVar2 = func_ii_1081(DAT_ram_00a66954,&local_10);
		    uVar2 = func_ii_4419(StringLiteral_5524,uVar2,0);
		    func_ii_2010(param1_00,uVar2,0);
		    iVar4 = *(int *)(param1 + 8);
		  }
		  if (*(int *)(iVar4 + 100) != 0) {
		    func_ii_2010(param1_00,StringLiteral_1238,0);
		    uVar2 = func_ii_4419(StringLiteral_7560,*(undefined4 *)(*(int *)(param1 + 8) + 100),0);
		    func_ii_2010(param1_00,uVar2,0);
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1_00 + 0xd8) * 4))
		                    (CONCAT44(uVar1,param1_00),*(undefined4 *)(*param1_00 + 0xdc));
		  return uVar1;
		}
		*/

			return ResponseAbilityStatus.Normal;
		}

		// Token: 0x06005AF1 RID: 23281 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005AF1")]
		[Address(RVA = "0xA7D4", Offset = "0xA7D4", VA = "0xA7D4", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x040031B3 RID: 12723
		[Token(Token = "0x40031B3")]
		[FieldOffset(Offset = "0x0")]
		private static long _globalIndex;

		// Token: 0x040031B4 RID: 12724
		[Token(Token = "0x40031B4")]
		[FieldOffset(Offset = "0x8")]
		private readonly HTTPRequest _request;

		// Token: 0x040031B5 RID: 12725
		[Token(Token = "0x40031B5")]
		[FieldOffset(Offset = "0xC")]
		private readonly Configuration _configuration;

		// Token: 0x040031B6 RID: 12726
		[Token(Token = "0x40031B6")]
		[FieldOffset(Offset = "0x10")]
		private readonly Uri _url;

		// Token: 0x040031B7 RID: 12727
		[Token(Token = "0x40031B7")]
		[FieldOffset(Offset = "0x14")]
		private readonly object _syncMonitor;

		// Token: 0x040031B9 RID: 12729
		[Token(Token = "0x40031B9")]
		[FieldOffset(Offset = "0x20")]
		private readonly long _startTime;

		// Token: 0x040031BA RID: 12730
		[Token(Token = "0x40031BA")]
		[FieldOffset(Offset = "0x28")]
		private bool _isComplete;

		// Token: 0x040031BB RID: 12731
		[Token(Token = "0x40031BB")]
		[FieldOffset(Offset = "0x30")]
		private long _finishTime;

		// Token: 0x040031BC RID: 12732
		[Token(Token = "0x40031BC")]
		[FieldOffset(Offset = "0x38")]
		private bool _requestIsFailed;
	}
}
