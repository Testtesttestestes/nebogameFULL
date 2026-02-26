using System;
using Il2CppDummyDll;

namespace JWTDecoder.Helpers
{
	// Token: 0x020000DF RID: 223
	[Token(Token = "0x20000DF")]
	internal static class DateTimeHelpers
	{
		// Token: 0x060007AA RID: 1962 RVA: 0x00003408 File Offset: 0x00001608
		[Token(Token = "0x60007AA")]
		[Address(RVA = "0x5B7F", Offset = "0x5B7F", VA = "0x5B7F")]
		internal static DateTime FromUnixTime(long unixTime)
		{
		/* --- GHIDRA: FromUnixTime ---
		void JWTDecoder_Helpers_DateTimeHelpers__FromUnixTime(undefined4 param1)
		
		{
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5b857 == '\0') {
		    Mono_Security_ASN1__get_Item(&JWTDecoder_Helpers_DateTimeHelpers_TypeInfo);
		    DAT_ram_00a5b857 = '\x01';
		  }
		  local_8 = 0;
		  System_DateTime___ctor
		            (&local_8,s_var<private>_posTex__array<vec4<_ram_00000655 + 0x15d,1,1,0,0,0,1,0);
		  **(undefined8 **)(JWTDecoder_Helpers_DateTimeHelpers_TypeInfo + 0x5c) = local_8;
		  return;
		}
		*/

			return default(DateTime);
		}

		// Token: 0x040002AA RID: 682
		[Token(Token = "0x40002AA")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly DateTime epoch;
	}
}
