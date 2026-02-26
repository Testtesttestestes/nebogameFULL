using System;
using Il2CppDummyDll;
using Protocol.Auth2;

namespace Core.Application.Managers
{
	// Token: 0x02001259 RID: 4697
	[Token(Token = "0x2001259")]
	[Serializable]
	public class SigninRecord
	{
		// Token: 0x06006F5C RID: 28508 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006F5C")]
		[Address(RVA = "0xB9C7", Offset = "0xB9C7", VA = "0xB9C7", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06006F5D RID: 28509 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006F5D")]
		[Address(RVA = "0x239A", Offset = "0x239A", VA = "0x239A")]
		public SigninRecord()
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Core_Application_Managers_SigninRecord___ctor(undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  undefined4 param3_00;
		  
		  if (DAT_ram_00a5b7ac == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_21847);
		    DAT_ram_00a5b7ac = '\x01';
		  }
		  iVar1 = func_ii_4769(param2,0);
		  if (iVar1 != 0) {
		    uVar2 = unnamed_function_2232(&System_ArgumentException_TypeInfo);
		    uVar2 = unnamed_function_1417(uVar2);
		    uVar3 = unnamed_function_2232(&StringLiteral_7389);
		    param3_00 = unnamed_function_2232(&StringLiteral_22962);
		    System_IO_EndOfStreamException___ctor(uVar2,uVar3,param3_00,0);
		    uVar3 = unnamed_function_2232
		                      (&
		                       Method_Unity_Services_Core_Environments_EnvironmentsOptionsExtensions_SetEnvironmentName__
		                      );
		    func_ii_1050(uVar2,uVar3);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  Unity_Services_Core_InitializationOptions___ctor(param1,StringLiteral_21847,param2,0);
		  return param1;
		}
		*/

		}

		// Token: 0x04003A22 RID: 14882
		[Token(Token = "0x4003A22")]
		[FieldOffset(Offset = "0x8")]
		public string Title;

		// Token: 0x04003A23 RID: 14883
		[Token(Token = "0x4003A23")]
		[FieldOffset(Offset = "0xC")]
		public Provider ProviderId;

		// Token: 0x04003A24 RID: 14884
		[Token(Token = "0x4003A24")]
		[FieldOffset(Offset = "0x10")]
		public string UserId;

		// Token: 0x04003A25 RID: 14885
		[Token(Token = "0x4003A25")]
		[FieldOffset(Offset = "0x14")]
		public string Token;
	}
}
