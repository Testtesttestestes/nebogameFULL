using System;
using Core.Gameplay.Managers.Configuration;
using Il2CppDummyDll;
using UnityEngine;

namespace Localization.Culture.WebGL
{
	// Token: 0x020000D9 RID: 217
	[Token(Token = "0x20000D9")]
	public class CultureProvider : BaseCultureProvider
	{
		// Token: 0x0600079A RID: 1946 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600079A")]
		[Address(RVA = "0x23A0", Offset = "0x23A0", VA = "0x23A0")]
		public CultureProvider(IPlatformConfigurationProvider configurationProvider)
		{
		}

		// Token: 0x0600079B RID: 1947 RVA: 0x00003390 File Offset: 0x00001590
		[Token(Token = "0x600079B")]
		[Address(RVA = "0x5B71", Offset = "0x5B71", VA = "0x5B71")]
		private static SystemLanguage LocaleToSystemLang(string locale)
		{
		/* --- GHIDRA: LocaleToSystemLang ---
		void Localization_Culture_WebGL_CultureProvider__LocaleToSystemLang
		               (undefined8 *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  undefined4 param4;
		  
		  if (DAT_ram_00a5b851 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Newtonsoft_Json_JsonConvert_DeserializeObject_JwtHeader___)
		    ;
		    Mono_Security_ASN1__get_Item(&Newtonsoft_Json_JsonConvert_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_ValueTuple_JwtHeader__string__string___ctor__);
		    DAT_ram_00a5b851 = '\x01';
		  }
		  iVar1 = System_Net_WebConnection__ReadLine(param2,0x2e,0,0);
		  if (1 < *(int *)(iVar1 + 0xc)) {
		    uVar2 = JWTDecoder_Decoder__DecodeToken(*(undefined4 *)(iVar1 + 0x10),param1);
		    if (*(int *)(Newtonsoft_Json_JsonConvert_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Newtonsoft_Json_JsonConvert_TypeInfo);
		    }
		    uVar2 = func_ii_14092(uVar2,Method_Newtonsoft_Json_JsonConvert_DeserializeObject_JwtHeader___);
		    uVar3 = JWTDecoder_Decoder__DecodeToken(*(undefined4 *)(iVar1 + 0x14),param1);
		    param4 = *(undefined4 *)(iVar1 + 0x18);
		    *(undefined4 *)(param1 + 1) = 0;
		    *param1 = 0;
		    System_Text_Formatting_Arg2___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType___get_Count
		              (param1,uVar2,uVar3,param4,Method_System_ValueTuple_JwtHeader__string__string___ctor__
		              );
		    return;
		  }
		  uVar2 = unnamed_function_2232(&JWTDecoder_InvalidTokenPartsException_TypeInfo);
		  uVar2 = unnamed_function_1417(uVar2);
		  uVar3 = unnamed_function_2232(&StringLiteral_27755);
		  JWTDecoder_Decoder__IsExpired(uVar2,uVar3,uVar2);
		  uVar3 = unnamed_function_2232(&Method_JWTDecoder_Decoder_DecodeToken__);
		  func_ii_1050(uVar2,uVar3);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

			return SystemLanguage.Afrikaans;
		}
	}
}
