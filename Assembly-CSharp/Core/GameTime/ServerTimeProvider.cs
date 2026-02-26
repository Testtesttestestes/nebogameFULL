using System;
using Core.Application.Managers.Connection;
using Google.Protobuf;
using Il2CppDummyDll;
using JetBrains.Annotations;
using Utils;

namespace Core.GameTime
{
	// Token: 0x02000EC9 RID: 3785
	[Token(Token = "0x2000EC9")]
	public class ServerTimeProvider : AbstractCurrentTimeProvider
	{
		// Token: 0x06005C2D RID: 23597 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C2D")]
		[Address(RVA = "0xA8D6", Offset = "0xA8D6", VA = "0xA8D6", Slot = "6")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Core_GameTime_ServerTimeProvider__Dispose(int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a60642 == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_OpTokenRepository_TypeInfo);
		    DAT_ram_00a60642 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(Utils_OpTokenRepository_TypeInfo);
		  Utils_OpTokenRepository__Dispose(param1_00,0);
		  *(undefined4 *)(param1 + 0x14) = param2;
		  *(undefined4 *)(param1 + 0x10) = param1_00;
		  return;
		}
		*/

		}

		// Token: 0x06005C2E RID: 23598 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C2E")]
		[Address(RVA = "0xA8D7", Offset = "0xA8D7", VA = "0xA8D7")]
		public ServerTimeProvider([NotNull] IPing ping)
		{
		/* --- GHIDRA: .ctor ---
		longlong Core_GameTime_ServerTimeProvider___ctor(int param1,undefined4 param2)
		
		{
		  longlong lVar1;
		  longlong lVar2;
		  
		  if (DAT_ram_00a60643 == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    DAT_ram_00a60643 = '\x01';
		  }
		  lVar2 = *(longlong *)(param1 + 0x18);
		  if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Utils_TimeUtils_TypeInfo);
		  }
		  lVar1 = Utils_LocalProps__Reset(0);
		  return (lVar1 + lVar2) - *(longlong *)(param1 + 0x20);
		}
		*/

		}

		// Token: 0x06005C2F RID: 23599 RVA: 0x000108D8 File Offset: 0x0000EAD8
		[Token(Token = "0x6005C2F")]
		[Address(RVA = "0xA8D8", Offset = "0xA8D8", VA = "0xA8D8", Slot = "7")]
		public override ulong GetUnixTimeMilliseconds()
		{
		/* --- GHIDRA: GetUnixTimeMilliseconds ---
		void Core_GameTime_ServerTimeProvider__GetUnixTimeMilliseconds(int param1,undefined4 param2)
		
		{
		  Utils_OpTokenRepository__Remove(*(undefined4 *)(param1 + 0x10),0);
		  return;
		}
		*/

			return 0UL;
		}

		// Token: 0x06005C30 RID: 23600 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C30")]
		[Address(RVA = "0xA8D9", Offset = "0xA8D9", VA = "0xA8D9", Slot = "9")]
		protected override void HandleStop()
		{
		/* --- GHIDRA: HandleStop ---
		void Core_GameTime_ServerTimeProvider__HandleStop(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  uint uVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  int *param1_00;
		  int iVar5;
		  undefined8 local_10;
		  undefined4 local_8;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a60644 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_Managers_Connection_IPing_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__SetCustomData__);
		    Mono_Security_ASN1__get_Item(&Method_Core_GameTime_ServerTimeProvider_Handler__);
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    DAT_ram_00a60644 = '\x01';
		  }
		  local_4 = 0;
		  local_8 = 0;
		  param1_00 = *(int **)(param1 + 0x14);
		  iVar5 = *param1_00;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar2 = 0;
		    do {
		      if (Core_Application_Managers_Connection_IPing_TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar2 * 8)) {
		        puVar3 = (uint *)(iVar5 + *(int *)(*(int *)(iVar5 + 0x58) + uVar2 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x81cbdd90;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar2);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_00,Core_Application_Managers_Connection_IPing_TypeInfo,0);
		code_r0x81cbdd90:
		  iVar5 = (**(code **)((ulonglong)*puVar3 * 4))(param1_00,&local_8,&local_4,puVar3[1]);
		  uVar1 = local_4;
		  if (iVar5 != 0) {
		    if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Utils_TimeUtils_TypeInfo);
		    }
		    local_10 = Utils_LocalProps__Reset(0);
		    uVar4 = func_ii_1081(DAT_ram_00a66964,&local_10);
		    DG_Tweening_TweenParams__SetId
		              (uVar1,uVar4,Method_Utils_OpToken_IMessage__object__SetCustomData__);
		    uVar1 = local_4;
		    uVar4 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar4,param1,Method_Core_GameTime_ServerTimeProvider_Handler__,0);
		    ServicesNamespace_MainService__GetUserStats
		              (uVar1,uVar4,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Utils_OpTokenRepository__TryGet(*(undefined4 *)(param1 + 0x10),local_4,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06005C31 RID: 23601 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C31")]
		[Address(RVA = "0xA8DA", Offset = "0xA8DA", VA = "0xA8DA", Slot = "8")]
		protected override void HandleRun()
		{
		/* --- GHIDRA: HandleRun ---
		void Core_GameTime_ServerTimeProvider__HandleRun(int param1,int param2,undefined4 param3)
		
		{
		  longlong *plVar1;
		  longlong lVar2;
		  undefined8 uVar3;
		  int *param1_00;
		  int *param1_01;
		  int iVar4;
		  longlong lVar5;
		  longlong lVar6;
		  
		  if (DAT_ram_00a60645 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Main_ProtoPingAns_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    DAT_ram_00a60645 = '\x01';
		  }
		  Utils_OpTokenRepository__Add(*(undefined4 *)(param1 + 0x10),param2,0);
		  param1_00 = *(int **)(param2 + 0xc);
		  if (param1_00 == (int *)0x0) {
		    System_Collections_Generic_Comparer_ValueTuple_int__Int32Enum__object____get_Default();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  if (*(int *)(*param1_00 + 0x20) != *(int *)(DAT_ram_00a66964 + 0x20)) {
		    System_Activator__CreateInstance(param1_00,DAT_ram_00a66964);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param1_01 = *(int **)(param2 + 0x20);
		  plVar1 = (longlong *)func_ii_15774(param1_00);
		  lVar5 = *plVar1;
		  if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Utils_TimeUtils_TypeInfo);
		  }
		  lVar2 = Utils_LocalProps__Reset(0);
		  if ((param1_01 != (int *)0x0) && (Protocol_Main_ProtoPingAns_TypeInfo != *param1_01)) {
		    System_Activator__CreateInstance(param1_01,Protocol_Main_ProtoPingAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  lVar6 = *(longlong *)(param1_01 + 4);
		  if (DAT_ram_00a60646 == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    DAT_ram_00a60646 = '\x01';
		  }
		  *(longlong *)(param1 + 0x18) = lVar6 + (lVar2 - lVar5);
		  if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Utils_TimeUtils_TypeInfo);
		  }
		  uVar3 = Utils_LocalProps__Reset(0);
		  *(undefined8 *)(param1 + 0x20) = uVar3;
		  if (*(char *)(param1 + 0xd) == '\0') {
		    *(undefined1 *)(param1 + 0xd) = 1;
		    iVar4 = *(int *)(param1 + 8);
		    if (iVar4 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar4 + 0xc) * 4))
		                (*(undefined4 *)(iVar4 + 0x20),param1,*(undefined4 *)(iVar4 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06005C32 RID: 23602 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C32")]
		[Address(RVA = "0xA8DB", Offset = "0xA8DB", VA = "0xA8DB")]
		private void Handler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: Handler ---
		void Core_GameTime_ServerTimeProvider__Handler(int param1,undefined8 param2,undefined4 param3)
		
		{
		  undefined8 uVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a60646 == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    DAT_ram_00a60646 = '\x01';
		  }
		  *(undefined8 *)(param1 + 0x18) = param2;
		  if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Utils_TimeUtils_TypeInfo);
		  }
		  uVar1 = Utils_LocalProps__Reset(0);
		  *(undefined8 *)(param1 + 0x20) = uVar1;
		  if (*(char *)(param1 + 0xd) == '\0') {
		    *(undefined1 *)(param1 + 0xd) = 1;
		    iVar2 = *(int *)(param1 + 8);
		    if (iVar2 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                (*(undefined4 *)(iVar2 + 0x20),param1,*(undefined4 *)(iVar2 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06005C33 RID: 23603 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C33")]
		[Address(RVA = "0xA8DC", Offset = "0xA8DC", VA = "0xA8DC")]
		private void SetUnixTime(ulong value)
		{
		/* --- GHIDRA: SetUnixTime ---
		undefined4 Core_GameTime_ServerTimeProvider__SetUnixTime(int *param1,undefined4 param2)
		
		{
		  int *param2_00;
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a60647 == '\0') {
		    Mono_Security_ASN1__get_Item(&object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19461);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19435);
		    Mono_Security_ASN1__get_Item(&StringLiteral_8538);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28693);
		    DAT_ram_00a60647 = '\x01';
		  }
		  param2_00 = (int *)Mono_Security_ASN1Convert__ToOid(object___TypeInfo,6);
		  if (StringLiteral_19461 == 0) {
		    iVar1 = 0;
		  }
		  else {
		    iVar2 = func_ii_1082(StringLiteral_19461,*(undefined4 *)(*param2_00 + 0x20));
		    iVar1 = StringLiteral_19461;
		    if (iVar2 == 0) {
		      uVar3 = func_ii_1083();
		      func_ii_1050(uVar3,0);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  param2_00[4] = iVar1;
		  local_8 = *(undefined8 *)(param1 + 6);
		  iVar1 = func_ii_1081(DAT_ram_00a66968,&local_8);
		  if ((iVar1 != 0) && (iVar2 = func_ii_1082(iVar1,*(undefined4 *)(*param2_00 + 0x20)), iVar2 == 0))
		  {
		    uVar3 = func_ii_1083();
		    func_ii_1050(uVar3,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param2_00[5] = iVar1;
		  if (StringLiteral_19435 == 0) {
		    iVar1 = 0;
		  }
		  else {
		    iVar2 = func_ii_1082(StringLiteral_19435,*(undefined4 *)(*param2_00 + 0x20));
		    iVar1 = StringLiteral_19435;
		    if (iVar2 == 0) {
		      uVar3 = func_ii_1083();
		      func_ii_1050(uVar3,0);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  param2_00[6] = iVar1;
		  local_10 = *(undefined8 *)(param1 + 8);
		  iVar1 = func_ii_1081(DAT_ram_00a66964,&local_10);
		  if ((iVar1 != 0) && (iVar2 = func_ii_1082(iVar1,*(undefined4 *)(*param2_00 + 0x20)), iVar2 == 0))
		  {
		    uVar3 = func_ii_1083();
		    func_ii_1050(uVar3,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param2_00[7] = iVar1;
		  if (StringLiteral_8538 == 0) {
		    iVar1 = 0;
		  }
		  else {
		    iVar2 = func_ii_1082(StringLiteral_8538,*(undefined4 *)(*param2_00 + 0x20));
		    iVar1 = StringLiteral_8538;
		    if (iVar2 == 0) {
		      uVar3 = func_ii_1083();
		      func_ii_1050(uVar3,0);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  param2_00[8] = iVar1;
		  local_18 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf8) * 4))
		                       (param1,*(undefined4 *)(*param1 + 0xfc));
		  iVar1 = func_ii_1081(DAT_ram_00a66968,&local_18);
		  if ((iVar1 != 0) && (iVar2 = func_ii_1082(iVar1,*(undefined4 *)(*param2_00 + 0x20)), iVar2 == 0))
		  {
		    uVar3 = func_ii_1083();
		    func_ii_1050(uVar3,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param2_00[9] = iVar1;
		  uVar3 = UnityEngine_InputSystem_Utilities_TypeHelpers__GetNiceTypeName
		                    (StringLiteral_28693,param2_00,0);
		  return uVar3;
		}
		*/

		}

		// Token: 0x06005C34 RID: 23604 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005C34")]
		[Address(RVA = "0xA8DD", Offset = "0xA8DD", VA = "0xA8DD", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0400325C RID: 12892
		[Token(Token = "0x400325C")]
		[FieldOffset(Offset = "0x10")]
		private readonly OpTokenRepository _tokenRepository;

		// Token: 0x0400325D RID: 12893
		[Token(Token = "0x400325D")]
		[FieldOffset(Offset = "0x14")]
		private IPing _ping;

		// Token: 0x0400325E RID: 12894
		[Token(Token = "0x400325E")]
		[FieldOffset(Offset = "0x18")]
		private ulong _serverUnixTimeMs;

		// Token: 0x0400325F RID: 12895
		[Token(Token = "0x400325F")]
		[FieldOffset(Offset = "0x20")]
		private long _clientUnixTimeMsWhenReady;
	}
}
