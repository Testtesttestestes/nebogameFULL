using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;
using JetBrains.Annotations;

namespace Core.Gameplay
{
	// Token: 0x0200111A RID: 4378
	[Token(Token = "0x200111A")]
	public class AuthTokenSourceEternal : IAuthTokenSource
	{
		// Token: 0x14000248 RID: 584
		// (add) Token: 0x0600669B RID: 26267 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600669C RID: 26268 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000248")]
		public event Action<IAuthTokenSource> TokenChangedEvent
		{
			[Token(Token = "0x600669B")]
			[Address(RVA = "0xB21F", Offset = "0xB21F", VA = "0xB21F")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600669C")]
			[Address(RVA = "0xB220", Offset = "0xB220", VA = "0xB220")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x0600669D RID: 26269 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600669D")]
		[Address(RVA = "0x225B", Offset = "0x225B", VA = "0x225B")]
		public AuthTokenSourceEternal([NotNull] string token)
		{
		/* --- GHIDRA: .ctor ---
		void Core_Gameplay_AuthTokenSourceEternal___ctor
		               (int param1,undefined4 param2,undefined4 param3,undefined8 param4,undefined4 param5)
		
		{
		  *(undefined4 *)(param1 + 0x14) = param3;
		  *(undefined4 *)(param1 + 0x10) = param2;
		  *(undefined8 *)(param1 + 8) = param4;
		  return;
		}
		*/

		}

		// Token: 0x0600669E RID: 26270 RVA: 0x00013758 File Offset: 0x00011958
		[Token(Token = "0x600669E")]
		[Address(RVA = "0xB221", Offset = "0xB221", VA = "0xB221", Slot = "4")]
		public UniTask<string> GetToken()
		{
		/* --- GHIDRA: GetToken ---
		undefined4 Core_Gameplay_AuthTokenSourceEternal__GetToken(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5a91a == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_19466);
		    DAT_ram_00a5a91a = '\x01';
		  }
		  uVar1 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor
		                    (StringLiteral_19466,*(undefined4 *)(param1 + 0xc),0);
		  return uVar1;
		}
		*/

			return default(UniTask<string>);
		}

		// Token: 0x0600669F RID: 26271 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600669F")]
		[Address(RVA = "0xB222", Offset = "0xB222", VA = "0xB222", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x040036D9 RID: 14041
		[Token(Token = "0x40036D9")]
		[FieldOffset(Offset = "0xC")]
		private readonly string _token;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_TokenChangedEvent ---
		void Core_Gameplay_AuthTokenSourceEternal__add_TokenChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a918 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IAuthTokenSource__TypeInfo);
		    DAT_ram_00a5a918 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 8);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_IAuthTokenSource__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IAuthTokenSource__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(param1 + 8,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: remove_TokenChangedEvent ---
		void Core_Gameplay_AuthTokenSourceEternal__remove_TokenChangedEvent
		               (undefined8 *param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  undefined8 local_c;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5a919 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Cysharp_Threading_Tasks_UniTaskCompletionSource_string__TrySetResult__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Cysharp_Threading_Tasks_UniTaskCompletionSource_string___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Cysharp_Threading_Tasks_UniTaskCompletionSource_string__get_Task__);
		    Mono_Security_ASN1__get_Item(&Cysharp_Threading_Tasks_UniTaskCompletionSource_string__TypeInfo);
		    DAT_ram_00a5a919 = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (Cysharp_Threading_Tasks_UniTaskCompletionSource_string__TypeInfo);
		  func_ii_5553(param1_00,*(undefined4 *)(param2 + 0xc),
		               Method_Cysharp_Threading_Tasks_UniTaskCompletionSource_string__TrySetResult__);
		  Cysharp_Threading_Tasks_UniTaskCompletionSource_object___UnsafeGetStatus
		            (&local_c,param1_00,
		             Method_Cysharp_Threading_Tasks_UniTaskCompletionSource_string__get_Task__);
		  *(undefined4 *)(param1 + 1) = local_4;
		  *param1 = local_c;
		  return;
		}
		*/

}
