using System;
using Il2CppDummyDll;
using TMPro;

namespace Gameplay.FeedbackForm.Model
{
	// Token: 0x02000820 RID: 2080
	[Token(Token = "0x2000820")]
	public class FeedbackThemeOption : TMP_Dropdown.OptionData
	{
		// Token: 0x060030F8 RID: 12536 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030F8")]
		[Address(RVA = "0x8159", Offset = "0x8159", VA = "0x8159")]
		public FeedbackThemeOption(Themes theme)
		{
		/* --- GHIDRA: .ctor ---
		int Gameplay_FeedbackForm_Model_FeedbackThemeOption___ctor(undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a57600 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_FeedbackForm_Model_Themes___TypeInfo);
		    DAT_ram_00a57600 = '\x01';
		  }
		  iVar1 = Mono_Security_ASN1Convert__ToOid(Gameplay_FeedbackForm_Model_Themes___TypeInfo,2);
		  *(undefined2 *)(iVar1 + 0x10) = 0xd03;
		  return iVar1;
		}
		*/

		}

		// Token: 0x04001AC2 RID: 6850
		[Token(Token = "0x4001AC2")]
		[FieldOffset(Offset = "0x20")]
		public readonly Themes Theme;
	}
}
