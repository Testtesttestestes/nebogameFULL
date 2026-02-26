using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace JWTDecoder
{
	// Token: 0x020000DE RID: 222
	[Token(Token = "0x20000DE")]
	public class JwtExpiration
	{
		// Token: 0x170000DE RID: 222
		// (get) Token: 0x060007A7 RID: 1959 RVA: 0x000033F0 File Offset: 0x000015F0
		// (set) Token: 0x060007A8 RID: 1960 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000DE")]
		[JsonProperty("exp")]
		public double? Expiration
		{
			[Token(Token = "0x60007A7")]
			[Address(RVA = "0x5B7C", Offset = "0x5B7C", VA = "0x5B7C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60007A8")]
			[Address(RVA = "0x5B7D", Offset = "0x5B7D", VA = "0x5B7D")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060007A9 RID: 1961 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007A9")]
		[Address(RVA = "0x5B7E", Offset = "0x5B7E", VA = "0x5B7E")]
		public JwtExpiration()
		{
		/* --- GHIDRA: .ctor ---
		undefined8 JWTDecoder_JwtExpiration___ctor(longlong param1,undefined4 param2)
		
		{
		  undefined8 uVar1;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5b856 == '\0') {
		    Mono_Security_ASN1__get_Item(&JWTDecoder_Helpers_DateTimeHelpers_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_DateTime_TypeInfo);
		    DAT_ram_00a5b856 = '\x01';
		  }
		  if (*(int *)(JWTDecoder_Helpers_DateTimeHelpers_TypeInfo + 0x74) == 0) {
		    func_ii_306000(JWTDecoder_Helpers_DateTimeHelpers_TypeInfo);
		  }
		  local_8 = **(undefined8 **)(JWTDecoder_Helpers_DateTimeHelpers_TypeInfo + 0x5c);
		  if (*(int *)(System_DateTime_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_DateTime_TypeInfo);
		  }
		  uVar1 = System_DateTime__AddMonths(&local_8,(double)param1,0);
		  return uVar1;
		}
		*/

		}
	}
}
