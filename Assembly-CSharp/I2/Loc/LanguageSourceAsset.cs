using System;
using Il2CppDummyDll;
using UnityEngine;

namespace I2.Loc
{
	// Token: 0x0200136C RID: 4972
	[Token(Token = "0x200136C")]
	[CreateAssetMenu(fileName = "I2Languages", menuName = "I2 Localization/LanguageSource", order = 1)]
	public class LanguageSourceAsset : ScriptableObject, ILanguageSource
	{
		// Token: 0x170017A4 RID: 6052
		// (get) Token: 0x060075F9 RID: 30201 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060075FA RID: 30202 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170017A4")]
		public LanguageSourceData SourceData
		{
			[Token(Token = "0x60075F9")]
			[Address(RVA = "0xBF82", Offset = "0xBF82", VA = "0xBF82", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60075FA")]
			[Address(RVA = "0xBF83", Offset = "0xBF83", VA = "0xBF83", Slot = "5")]
			set
			{
			}
		}

		// Token: 0x060075FB RID: 30203 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60075FB")]
		[Address(RVA = "0xBF84", Offset = "0xBF84", VA = "0xBF84")]
		public LanguageSourceAsset()
		{
		/* --- GHIDRA: .ctor ---
		int * I2_Loc_LanguageSourceAsset___ctor(int param1,undefined4 param2)
		
		{
		  int *piVar1;
		  int *piVar2;
		  
		  piVar1 = (int *)0x0;
		  if (DAT_ram_00a6047a == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a6047a = '\x01';
		  }
		  piVar2 = *(int **)(param1 + 8);
		  if (piVar2 != (int *)0x0) {
		    if (((uint)*(byte *)(UnityEngine_Object_TypeInfo + 0xb8) <= (uint)*(byte *)(*piVar2 + 0xb8)) &&
		       (piVar1 = piVar2,
		       *(int *)(*(int *)(*piVar2 + 100) + (uint)*(byte *)(UnityEngine_Object_TypeInfo + 0xb8) * 4 +
		               -4) != UnityEngine_Object_TypeInfo)) {
		      piVar1 = (int *)0x0;
		    }
		  }
		  return piVar1;
		}
		*/

		}

		// Token: 0x04003DB6 RID: 15798
		[Token(Token = "0x4003DB6")]
		[FieldOffset(Offset = "0xC")]
		public LanguageSourceData mSource;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_SourceData ---
		void I2_Loc_LanguageSourceAsset__set_SourceData(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a60479 == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_LanguageSourceData_TypeInfo);
		    DAT_ram_00a60479 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(I2_Loc_LanguageSourceData_TypeInfo);
		  I2_Loc_LanguageSourceData__ValidateFullTerm(param1_00,param1);
		  *(undefined4 *)(param1 + 0xc) = param1_00;
		  UnityEngine_RuntimeInitializeOnLoadMethodAttribute__set_loadType(param1,0);
		  return;
		}
		*/

}
