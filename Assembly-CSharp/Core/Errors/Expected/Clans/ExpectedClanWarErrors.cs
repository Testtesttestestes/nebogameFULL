using System;
using Il2CppDummyDll;

namespace Core.Errors.Expected.Clans
{
	// Token: 0x02001081 RID: 4225
	[Token(Token = "0x2001081")]
	public class ExpectedClanWarErrors : ExpectedDefaultError
	{
		// Token: 0x06006297 RID: 25239 RVA: 0x00012858 File Offset: 0x00010A58
		[Token(Token = "0x6006297")]
		[Address(RVA = "0xAEBD", Offset = "0xAEBD", VA = "0xAEBD", Slot = "4")]
		public override bool Handle(int errorCode)
		{
		/* --- GHIDRA: Handle ---
		/* WARNING: Type propagation algorithm not settling */
		
		undefined4
		Core_Errors_Expected_Clans_ExpectedClanWarErrors__Handle(uint param1,int param2,undefined4 param3)
		
		{
		  undefined4 *puVar1;
		  undefined4 uVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a5a3a1 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4233);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4226);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4244);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4230);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4236);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4242);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4227);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4223);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4231);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4234);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4241);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4235);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4224);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4243);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4222);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4237);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4232);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4238);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4239);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4240);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4225);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4228);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4229);
		    DAT_ram_00a5a3a1 = '\x01';
		  }
		  if ((int)param1 < -0x3d) {
		    if (param1 < 0xfffffed5) {
		      if (param1 == 0xffffd8f0) {
		        puVar1 = &StringLiteral_4239;
		        iVar3 = *(int *)(Core_GameLocalization_TypeInfo + 0x74);
		      }
		      else {
		        if (param1 != 0xfffffed4) {
		          return 0;
		        }
		        puVar1 = &StringLiteral_4241;
		        iVar3 = *(int *)(Core_GameLocalization_TypeInfo + 0x74);
		      }
		    }
		    else if (param1 == 0xffffff9c) {
		      puVar1 = &StringLiteral_4243;
		      iVar3 = *(int *)(Core_GameLocalization_TypeInfo + 0x74);
		    }
		    else {
		      if (param1 == 0xffffff9d) {
		        return 0;
		      }
		      if (param1 == 0xffffff9e) {
		        return 0;
		      }
		      if (param1 == 0xffffff9f) {
		        return 0;
		      }
		      if (param1 == 0xffffffa0) {
		        return 0;
		      }
		      if (param1 == 0xffffffa1) {
		        return 0;
		      }
		      if (param1 == 0xffffffa2) {
		        return 0;
		      }
		      if (param1 == 0xffffffa3) {
		        return 0;
		      }
		      if (param1 == 0xffffffa4) {
		        return 0;
		      }
		      if (param1 == 0xffffffa5) {
		        return 0;
		      }
		      if (param1 == 0xffffffa6) {
		        return 0;
		      }
		      if (param1 == 0xffffffa7) {
		        return 0;
		      }
		      if (param1 == 0xffffffa8) {
		        return 0;
		      }
		      if (param1 == 0xffffffa9) {
		        return 0;
		      }
		      if (param1 == 0xffffffaa) {
		        return 0;
		      }
		      if (param1 == 0xffffffab) {
		        return 0;
		      }
		      if (param1 == 0xffffffac) {
		        return 0;
		      }
		      if (param1 == 0xffffffad) {
		        return 0;
		      }
		      if (param1 == 0xffffffae) {
		        return 0;
		      }
		      if (param1 == 0xffffffaf) {
		        return 0;
		      }
		      if (param1 == 0xffffffb0) {
		        return 0;
		      }
		      if (param1 == 0xffffffb1) {
		        return 0;
		      }
		      if (param1 == 0xffffffb2) {
		        return 0;
		      }
		      if (param1 == 0xffffffb3) {
		        return 0;
		      }
		      if (param1 == 0xffffffb4) {
		        return 0;
		      }
		      if (param1 == 0xffffffb5) {
		        return 0;
		      }
		      if (param1 == 0xffffffb6) {
		        return 0;
		      }
		      if (param1 == 0xffffffb7) {
		        return 0;
		      }
		      if (param1 == 0xffffffb8) {
		        return 0;
		      }
		      if (param1 == 0xffffffb9) {
		        return 0;
		      }
		      if (param1 == 0xffffffba) {
		        return 0;
		      }
		      if (param1 == 0xffffffbb) {
		        return 0;
		      }
		      if (param1 == 0xffffffbc) {
		        return 0;
		      }
		      if (param1 == 0xffffffbd) {
		        return 0;
		      }
		      if (param1 == 0xffffffbe) {
		        return 0;
		      }
		      if (param1 == 0xffffffbf) {
		        return 0;
		      }
		      if (param1 == 0xffffffc0) {
		        puVar1 = (undefined4 *)&StringLiteral_4237;
		        if (*(char *)(param2 + 8) == '\0') {
		          puVar1 = &StringLiteral_4224;
		        }
		        iVar3 = *(int *)(Core_GameLocalization_TypeInfo + 0x74);
		      }
		      else if (param1 == 0xffffffc1) {
		        puVar1 = &StringLiteral_4236;
		        iVar3 = *(int *)(Core_GameLocalization_TypeInfo + 0x74);
		      }
		      else {
		        if (param1 != 0xffffffc2) {
		          return 0;
		        }
		        puVar1 = &StringLiteral_4240;
		        iVar3 = *(int *)(Core_GameLocalization_TypeInfo + 0x74);
		      }
		    }
		  }
		  else if ((int)param1 < -0x1e) {
		    if (param1 == 0xffffffcd) {
		      puVar1 = &StringLiteral_4222;
		      iVar3 = *(int *)(Core_GameLocalization_TypeInfo + 0x74);
		    }
		    else {
		      if (param1 == 0xffffffce) {
		        return 0;
		      }
		      if (param1 == 0xffffffcf) {
		        return 0;
		      }
		      if (param1 == 0xffffffd0) {
		        return 0;
		      }
		      if (param1 == 0xffffffd1) {
		        return 0;
		      }
		      if (param1 == 0xffffffd2) {
		        return 0;
		      }
		      if (param1 == 0xffffffd3) {
		        return 0;
		      }
		      if (param1 == 0xffffffd4) {
		        return 0;
		      }
		      if (param1 == 0xffffffd5) {
		        return 0;
		      }
		      if (param1 == 0xffffffd6) {
		        puVar1 = &StringLiteral_4223;
		        iVar3 = *(int *)(Core_GameLocalization_TypeInfo + 0x74);
		      }
		      else if (param1 == 0xffffffd7) {
		        puVar1 = &StringLiteral_4225;
		        iVar3 = *(int *)(Core_GameLocalization_TypeInfo + 0x74);
		      }
		      else if (param1 == 0xffffffd8) {
		        puVar1 = &StringLiteral_4226;
		        iVar3 = *(int *)(Core_GameLocalization_TypeInfo + 0x74);
		      }
		      else {
		        if (param1 == 0xffffffd9) {
		          return 0;
		        }
		        if (param1 == 0xffffffda) {
		          return 0;
		        }
		        if (param1 == 0xffffffdb) {
		          return 0;
		        }
		        if (param1 == 0xffffffdc) {
		          return 0;
		        }
		        if (param1 == 0xffffffdd) {
		          return 0;
		        }
		        if (param1 == 0xffffffde) {
		          puVar1 = &StringLiteral_4234;
		          iVar3 = *(int *)(Core_GameLocalization_TypeInfo + 0x74);
		        }
		        else if (param1 == 0xffffffdf) {
		          puVar1 = &StringLiteral_4233;
		          iVar3 = *(int *)(Core_GameLocalization_TypeInfo + 0x74);
		        }
		        else if (param1 == 0xffffffe0) {
		          puVar1 = &StringLiteral_4235;
		          iVar3 = *(int *)(Core_GameLocalization_TypeInfo + 0x74);
		        }
		        else {
		          if (param1 != 0xffffffe1) {
		            return 0;
		          }
		          puVar1 = &StringLiteral_4232;
		          iVar3 = *(int *)(Core_GameLocalization_TypeInfo + 0x74);
		        }
		      }
		    }
		  }
		  else if (param1 == 0xffffffe8) {
		    puVar1 = &StringLiteral_4229;
		    iVar3 = *(int *)(Core_GameLocalization_TypeInfo + 0x74);
		  }
		  else if (param1 == 0xffffffe9) {
		    puVar1 = &StringLiteral_4228;
		    iVar3 = *(int *)(Core_GameLocalization_TypeInfo + 0x74);
		  }
		  else if (param1 == 0xffffffea) {
		    puVar1 = &StringLiteral_4230;
		    iVar3 = *(int *)(Core_GameLocalization_TypeInfo + 0x74);
		  }
		  else if (param1 == 0xffffffeb) {
		    puVar1 = &StringLiteral_4244;
		    iVar3 = *(int *)(Core_GameLocalization_TypeInfo + 0x74);
		  }
		  else {
		    if (param1 == 0xffffffec) {
		      return 0;
		    }
		    if (param1 == 0xffffffed) {
		      return 0;
		    }
		    if (param1 == 0xffffffee) {
		      return 0;
		    }
		    if (param1 == 0xffffffef) {
		      return 0;
		    }
		    if (param1 == 0xfffffff0) {
		      return 0;
		    }
		    if (param1 == 0xfffffff1) {
		      return 0;
		    }
		    if (param1 == 0xfffffff2) {
		      return 0;
		    }
		    if (param1 == 0xfffffff3) {
		      return 0;
		    }
		    if (param1 == 0xfffffff4) {
		      return 0;
		    }
		    if (param1 == 0xfffffff5) {
		      return 0;
		    }
		    if (param1 == 0xfffffff6) {
		      return 0;
		    }
		    if (param1 == 0xfffffff7) {
		      return 0;
		    }
		    if (param1 == 0xfffffff8) {
		      return 0;
		    }
		    if (param1 == 0xfffffff9) {
		      return 0;
		    }
		    if (param1 == 0xfffffffa) {
		      puVar1 = &StringLiteral_4231;
		      iVar3 = *(int *)(Core_GameLocalization_TypeInfo + 0x74);
		    }
		    else if (param1 == 0xfffffffb) {
		      puVar1 = &StringLiteral_4242;
		      iVar3 = *(int *)(Core_GameLocalization_TypeInfo + 0x74);
		    }
		    else if (param1 == 0xfffffffc) {
		      puVar1 = &StringLiteral_4238;
		      iVar3 = *(int *)(Core_GameLocalization_TypeInfo + 0x74);
		    }
		    else {
		      if (param1 != 0xfffffffd) {
		        return 0;
		      }
		      puVar1 = &StringLiteral_4227;
		      iVar3 = *(int *)(Core_GameLocalization_TypeInfo + 0x74);
		    }
		  }
		  if (iVar3 == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(*puVar1,1,0,1,0,0,0,0);
		  return uVar2;
		}
		*/

			return default(bool);
		}

		// Token: 0x06006298 RID: 25240 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006298")]
		[Address(RVA = "0xAEBE", Offset = "0xAEBE", VA = "0xAEBE")]
		public static string GetClanWarErrorLocalization(int errorCode, ExpectedClanWarErrors.ExpectedClanWarsErrorsArgs args)
		{
			return null;
		}

		// Token: 0x06006299 RID: 25241 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006299")]
		[Address(RVA = "0xAEBF", Offset = "0xAEBF", VA = "0xAEBF")]
		public ExpectedClanWarErrors()
		{
		}

		// Token: 0x02001082 RID: 4226
		[Token(Token = "0x2001082")]
		public class ExpectedClanWarsErrorsArgs
		{
			// Token: 0x0600629A RID: 25242 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600629A")]
			[Address(RVA = "0xAEC0", Offset = "0xAEC0", VA = "0xAEC0")]
			public ExpectedClanWarsErrorsArgs()
			{
			}

			// Token: 0x040034F6 RID: 13558
			[Token(Token = "0x40034F6")]
			[FieldOffset(Offset = "0x8")]
			public bool BlitzModeEnabled;
		}
	}
}
