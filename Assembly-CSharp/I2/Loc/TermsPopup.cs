using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace I2.Loc
{
	// Token: 0x0200139D RID: 5021
	[Token(Token = "0x200139D")]
	public class TermsPopup : PropertyAttribute
	{
		// Token: 0x0600779A RID: 30618 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600779A")]
		[Address(RVA = "0xC0F8", Offset = "0xC0F8", VA = "0xC0F8")]
		public TermsPopup(string filter = "")
		{
		}

		// Token: 0x170017B4 RID: 6068
		// (get) Token: 0x0600779B RID: 30619 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600779C RID: 30620 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170017B4")]
		public string Filter
		{
			[Token(Token = "0x600779B")]
			[Address(RVA = "0xC0F9", Offset = "0xC0F9", VA = "0xC0F9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600779C")]
			[Address(RVA = "0xC0FA", Offset = "0xC0FA", VA = "0xC0FA")]
			[CompilerGenerated]
			private set
			{
			}
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Filter ---
		void I2_Loc_TermsPopup__set_Filter(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a54dfd == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		    DAT_ram_00a54dfd = '\x01';
		  }
		  if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		  }
		  I2_Loc_LocalizationManager__CreateCultureForCode(1,0);
		  return;
		}
		*/

}
