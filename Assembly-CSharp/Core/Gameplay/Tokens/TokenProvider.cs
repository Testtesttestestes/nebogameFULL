using System;
using System.Threading;
using Cysharp.Threading.Tasks;
using Google.Protobuf;
using Il2CppDummyDll;
using Protocol.Tokenator;
using ServicesNamespace;
using Utils;

namespace Core.Gameplay.Tokens
{
	// Token: 0x0200112C RID: 4396
	[Token(Token = "0x200112C")]
	public class TokenProvider : ITokenProvider, IDisposable
	{
		// Token: 0x0600670B RID: 26379 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600670B")]
		[Address(RVA = "0xB243", Offset = "0xB243", VA = "0xB243")]
		public TokenProvider(string clientId, string scope, TokenatorService tokenatorService)
		{
		/* --- GHIDRA: .ctor ---
		void Core_Gameplay_Tokens_TokenProvider___ctor(undefined8 *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  float fVar2;
		  undefined4 param1_00;
		  undefined8 local_c;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5a92e == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Threading_CancellationTokenSource_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Gameplay_Tokens_TokenProvider_GetTokenResultHandler__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_Cysharp_Threading_Tasks_UniTaskCompletionSource_string__TrySetResult__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Cysharp_Threading_Tasks_UniTaskCompletionSource_string___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Cysharp_Threading_Tasks_UniTaskCompletionSource_string__get_Task__);
		    Mono_Security_ASN1__get_Item(&Cysharp_Threading_Tasks_UniTaskCompletionSource_string__TypeInfo);
		    DAT_ram_00a5a92e = '\x01';
		  }
		  if (*(int *)(param2 + 0x20) == 0) {
		    uVar1 = unnamed_function_1417(Cysharp_Threading_Tasks_UniTaskCompletionSource_string__TypeInfo);
		    *(undefined4 *)(param2 + 0x20) = uVar1;
		    fVar2 = func_ii_7103(*(undefined4 *)(param2 + 0x18),0);
		    if (0.0 < fVar2) {
		      func_ii_5553(*(undefined4 *)(param2 + 0x20),*(undefined4 *)(*(int *)(param2 + 0x14) + 0xc),
		                   Method_Cysharp_Threading_Tasks_UniTaskCompletionSource_string__TrySetResult__);
		      Cysharp_Threading_Tasks_UniTaskCompletionSource_object___UnsafeGetStatus
		                (&local_c,*(undefined4 *)(param2 + 0x20),
		                 Method_Cysharp_Threading_Tasks_UniTaskCompletionSource_string__get_Task__);
		      *(undefined4 *)(param1 + 1) = local_4;
		      *param1 = local_c;
		      *(undefined4 *)(param2 + 0x20) = 0;
		    }
		    else {
		      System_Threading_CancellationTokenSource__Cancel(*(undefined4 *)(param2 + 0x1c),0);
		      uVar1 = unnamed_function_1417(System_Threading_CancellationTokenSource_TypeInfo);
		      Gameplay_Combat_Control_Conveyor__Next(uVar1,0);
		      *(undefined4 *)(param2 + 0x1c) = uVar1;
		      uVar1 = ServicesNamespace_TokenatorService__get_ServiceId
		                        (*(undefined4 *)(param2 + 0x10),*(undefined4 *)(param2 + 0xc),
		                         *(undefined4 *)(param2 + 8),0);
		      param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		      UnityEngine_UIElements_VisualElement__get_layout
		                (param1_00,param2,Method_Core_Gameplay_Tokens_TokenProvider_GetTokenResultHandler__,
		                 0);
		      ServicesNamespace_MainService__GetUserStats
		                (uVar1,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		      Cysharp_Threading_Tasks_UniTaskCompletionSource_object___UnsafeGetStatus
		                (&local_c,*(undefined4 *)(param2 + 0x20),
		                 Method_Cysharp_Threading_Tasks_UniTaskCompletionSource_string__get_Task__);
		      *(undefined4 *)(param1 + 1) = local_4;
		      *param1 = local_c;
		    }
		  }
		  else {
		    Cysharp_Threading_Tasks_UniTaskCompletionSource_object___UnsafeGetStatus
		              (&local_c,*(int *)(param2 + 0x20),
		               Method_Cysharp_Threading_Tasks_UniTaskCompletionSource_string__get_Task__);
		    *(undefined4 *)(param1 + 1) = local_4;
		    *param1 = local_c;
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600670C RID: 26380 RVA: 0x00013788 File Offset: 0x00011988
		[Token(Token = "0x600670C")]
		[Address(RVA = "0xB244", Offset = "0xB244", VA = "0xB244", Slot = "4")]
		public UniTask<string> GetTokenAsync()
		{
		/* --- GHIDRA: GetTokenAsync ---
		void Core_Gameplay_Tokens_TokenProvider__GetTokenAsync(int param1,int param2,undefined4 param3)
		
		{
		  int param2_00;
		  int iVar1;
		  undefined4 param1_00;
		  int *param1_01;
		  ulonglong uVar2;
		  
		  if (DAT_ram_00a5a92f == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Tokenator_GenIDTokenCmd_Types_Ans_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_BackTime_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Cysharp_Threading_Tasks_UniTaskCompletionSource_string__TrySetResult__);
		    DAT_ram_00a5a92f = '\x01';
		  }
		  iVar1 = System_Collections_Generic_LinkedList_object___AddFirst(*(undefined4 *)(param1 + 0x1c),0);
		  param2_00 = Protocol_Tokenator_GenIDTokenCmd_Types_Ans_TypeInfo;
		  if (iVar1 == 0) {
		    param1_01 = *(int **)(param2 + 0x20);
		    if (param1_01 == (int *)0x0) {
		      *(undefined4 *)(param1 + 0x14) = 0;
		    }
		    else if ((Protocol_Tokenator_GenIDTokenCmd_Types_Ans_TypeInfo != *param1_01) ||
		            (*(int **)(param1 + 0x14) = param1_01, *param1_01 != param2_00)) {
		      System_Activator__CreateInstance(param1_01,param2_00);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar2 = *(ulonglong *)(param1_01 + 4);
		    param1_00 = unnamed_function_1417(Utils_BackTime_TypeInfo);
		    Core_Extensions_Dict_DictExt__BinarySearch_object__uint_(param1_00,(float)uVar2,0);
		    *(undefined4 *)(param1 + 0x18) = param1_00;
		    func_ii_5553(*(undefined4 *)(param1 + 0x20),*(undefined4 *)(*(int *)(param1 + 0x14) + 0xc),
		                 Method_Cysharp_Threading_Tasks_UniTaskCompletionSource_string__TrySetResult__);
		    *(undefined4 *)(param1 + 0x20) = 0;
		  }
		  return;
		}
		*/

			return default(UniTask<string>);
		}

		// Token: 0x0600670D RID: 26381 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600670D")]
		[Address(RVA = "0xB245", Offset = "0xB245", VA = "0xB245")]
		private void GetTokenResultHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: GetTokenResultHandler ---
		void Core_Gameplay_Tokens_TokenProvider__GetTokenResultHandler(int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5a930 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Cysharp_Threading_Tasks_UniTaskCompletionSource_string__TrySetResult__);
		    DAT_ram_00a5a930 = '\x01';
		  }
		  System_Runtime_CompilerServices_AsyncTaskMethodBuilder__AwaitUnsafeOnCompleted_ConfiguredTaskAwaitable_ConfiguredTaskAwaiter__WebRequestStream__WriteChunkTrailer_d__40_
		            (*(undefined4 *)(param1 + 0x1c),0);
		  if (*(int *)(param1 + 0x20) != 0) {
		    func_ii_5553(*(int *)(param1 + 0x20),0,
		                 Method_Cysharp_Threading_Tasks_UniTaskCompletionSource_string__TrySetResult__);
		  }
		  *(undefined4 *)(param1 + 0x20) = 0;
		  return;
		}
		*/

		}

		// Token: 0x0600670E RID: 26382 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600670E")]
		[Address(RVA = "0xB246", Offset = "0xB246", VA = "0xB246", Slot = "5")]
		public void Cancel()
		{
		/* --- GHIDRA: Cancel ---
		void Core_Gameplay_Tokens_TokenProvider__Cancel(int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5a930 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Cysharp_Threading_Tasks_UniTaskCompletionSource_string__TrySetResult__);
		    DAT_ram_00a5a930 = '\x01';
		  }
		  System_Runtime_CompilerServices_AsyncTaskMethodBuilder__AwaitUnsafeOnCompleted_ConfiguredTaskAwaitable_ConfiguredTaskAwaiter__WebRequestStream__WriteChunkTrailer_d__40_
		            (*(undefined4 *)(param1 + 0x1c),0);
		  if (*(int *)(param1 + 0x20) != 0) {
		    func_ii_5553(*(int *)(param1 + 0x20),0,
		                 Method_Cysharp_Threading_Tasks_UniTaskCompletionSource_string__TrySetResult__);
		  }
		  *(undefined4 *)(param1 + 0x20) = 0;
		  System_Threading_CancellationTokenSource__Cancel(*(undefined4 *)(param1 + 0x1c),0);
		  *(undefined4 *)(param1 + 0x10) = 0;
		  return;
		}
		*/

		}

		// Token: 0x0600670F RID: 26383 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600670F")]
		[Address(RVA = "0xB247", Offset = "0xB247", VA = "0xB247", Slot = "6")]
		private void Dispose()
		{
		}

		// Token: 0x040036EF RID: 14063
		[Token(Token = "0x40036EF")]
		[FieldOffset(Offset = "0x8")]
		private readonly string _scope;

		// Token: 0x040036F0 RID: 14064
		[Token(Token = "0x40036F0")]
		[FieldOffset(Offset = "0xC")]
		private readonly string _clientId;

		// Token: 0x040036F1 RID: 14065
		[Token(Token = "0x40036F1")]
		[FieldOffset(Offset = "0x10")]
		private TokenatorService _service;

		// Token: 0x040036F2 RID: 14066
		[Token(Token = "0x40036F2")]
		[FieldOffset(Offset = "0x14")]
		private GenIDTokenCmd.Types.Ans _token;

		// Token: 0x040036F3 RID: 14067
		[Token(Token = "0x40036F3")]
		[FieldOffset(Offset = "0x18")]
		private BackTime _backtime;

		// Token: 0x040036F4 RID: 14068
		[Token(Token = "0x40036F4")]
		[FieldOffset(Offset = "0x1C")]
		private CancellationTokenSource _cancellationSource;

		// Token: 0x040036F5 RID: 14069
		[Token(Token = "0x40036F5")]
		[FieldOffset(Offset = "0x20")]
		private UniTaskCompletionSource<string> _completionSource;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: System.IDisposable.Dispose ---
		uint Core_Gameplay_Tokens_TokenProvider__System_IDisposable_Dispose(int param1,undefined4 param2)
		
		{
		  return *(uint *)(param1 + 0x24) & 1;
		}
		*/

}
