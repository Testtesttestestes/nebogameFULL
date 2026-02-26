using System;
using Il2CppDummyDll;

namespace Core.Errors.Expected
{
	// Token: 0x02001065 RID: 4197
	[Token(Token = "0x2001065")]
	public class ExpectedJoinBlitzTournamentErrors : ExpectedDefaultError
	{
		// Token: 0x0600625E RID: 25182 RVA: 0x00012618 File Offset: 0x00010818
		[Token(Token = "0x600625E")]
		[Address(RVA = "0xAE84", Offset = "0xAE84", VA = "0xAE84", Slot = "4")]
		public override bool Handle(int errorCode)
		{
			return default(bool);
		}

		// Token: 0x0600625F RID: 25183 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600625F")]
		[Address(RVA = "0xAE85", Offset = "0xAE85", VA = "0xAE85")]
		public ExpectedJoinBlitzTournamentErrors()
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Core_Errors_Expected_ExpectedJoinBlitzTournamentErrors___ctor
		          (undefined4 param1,int param2,undefined4 param3)
		
		{
		  undefined4 *puVar1;
		  int param1_00;
		  undefined4 uVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a5a386 == '\0') {
		    Mono_Security_ASN1__get_Item(&UI_Windows_Alert_AlertArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_6934);
		    Mono_Security_ASN1__get_Item(&StringLiteral_6933);
		    DAT_ram_00a5a386 = '\x01';
		  }
		  if (param2 == -7) {
		    param1_00 = unnamed_function_1417(UI_Windows_Alert_AlertArgs_TypeInfo);
		    UI_Windows_Alert__Show(param1_00,0);
		    puVar1 = &StringLiteral_6933;
		    iVar3 = *(int *)(Core_GameLocalization_TypeInfo + 0x74);
		  }
		  else {
		    if (param2 == -6) {
		      return 0;
		    }
		    if (param2 == -5) {
		      return 0;
		    }
		    if (param2 == -4) {
		      return 0;
		    }
		    if (param2 == -3) {
		      return 0;
		    }
		    if (param2 == -2) {
		      return 0;
		    }
		    if (param2 != -1) {
		      return 0;
		    }
		    param1_00 = unnamed_function_1417(UI_Windows_Alert_AlertArgs_TypeInfo);
		    UI_Windows_Alert__Show(param1_00,0);
		    puVar1 = &StringLiteral_6934;
		    iVar3 = *(int *)(Core_GameLocalization_TypeInfo + 0x74);
		  }
		  if (iVar3 == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar2 = func_ii_7508(*puVar1,1,0,1,0,0,0,0);
		  *(undefined4 *)(param1_00 + 0x1c) = uVar2;
		  UI_Windows_UnityInstantiator___ctor(param1_00,0);
		  return 1;
		}
		*/

		}
	}
}
