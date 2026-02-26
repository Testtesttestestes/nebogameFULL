using System;
using Il2CppDummyDll;

namespace I2.Loc
{
	// Token: 0x020013A9 RID: 5033
	[Token(Token = "0x20013A9")]
	[Serializable]
	public struct LocalizedString
	{
		// Token: 0x060077C6 RID: 30662 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60077C6")]
		[Address(RVA = "0xC121", Offset = "0xC121", VA = "0xC121")]
		public static implicit operator string(LocalizedString s)
		{
			return null;
		}

		// Token: 0x060077C7 RID: 30663 RVA: 0x00015FD8 File Offset: 0x000141D8
		[Token(Token = "0x60077C7")]
		[Address(RVA = "0xC122", Offset = "0xC122", VA = "0xC122")]
		public static implicit operator LocalizedString(string term)
		{
		/* --- GHIDRA: .ctor ---
		undefined4 I2_Loc_LocalizedString___ctor(undefined4 *param1,undefined4 param2)
		
		{
		  char cVar1;
		  char cVar2;
		  undefined4 param3;
		  undefined4 param1_00;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a54e16 == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		    DAT_ram_00a54e16 = '\x01';
		  }
		  cVar1 = *(char *)(param1 + 3);
		  param3 = param1[2];
		  cVar2 = *(char *)(param1 + 1);
		  param1_00 = *param1;
		  if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		  }
		  local_4 = I2_Loc_LocalizationManager__remove_OnLocalizeEvent
		                      (param1_00,(uint)(cVar2 == '\0'),param3,(uint)(cVar1 == '\0'),1,0,0,1,0);
		  I2_Loc_LocalizationManager__AutoLoadGlobalParamManagers
		            (&local_4,(uint)(*(char *)((int)param1 + 0xd) == '\0'),0);
		  return local_4;
		}
		*/

			return default(LocalizedString);
		}

		// Token: 0x060077C8 RID: 30664 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60077C8")]
		[Address(RVA = "0xC123", Offset = "0xC123", VA = "0xC123")]
		public LocalizedString(LocalizedString str)
		{
		}

		// Token: 0x060077C9 RID: 30665 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60077C9")]
		[Address(RVA = "0xC124", Offset = "0xC124", VA = "0xC124", Slot = "3")]
		public override string ToString()
		{
		/* --- GHIDRA: ToString ---
		undefined4 I2_Loc_LocalizedString__ToString(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = I2_Loc_RTLFixer__Fix(param1,0,1,param1);
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x04003E80 RID: 16000
		[Token(Token = "0x4003E80")]
		[FieldOffset(Offset = "0x0")]
		public string mTerm;

		// Token: 0x04003E81 RID: 16001
		[Token(Token = "0x4003E81")]
		[FieldOffset(Offset = "0x4")]
		public bool mRTL_IgnoreArabicFix;

		// Token: 0x04003E82 RID: 16002
		[Token(Token = "0x4003E82")]
		[FieldOffset(Offset = "0x8")]
		public int mRTL_MaxLineLength;

		// Token: 0x04003E83 RID: 16003
		[Token(Token = "0x4003E83")]
		[FieldOffset(Offset = "0xC")]
		public bool mRTL_ConvertNumbers;

		// Token: 0x04003E84 RID: 16004
		[Token(Token = "0x4003E84")]
		[FieldOffset(Offset = "0xD")]
		public bool m_DontLocalizeParameters;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: op_Implicit ---
		void I2_Loc_LocalizedString__op_Implicit(undefined4 *param1,undefined4 *param2,undefined4 param3)
		
		{
		  *param1 = *param2;
		  *(byte *)(param1 + 1) = *(byte *)(param2 + 1) & 1;
		  param1[2] = param2[2];
		  *(byte *)(param1 + 3) = *(byte *)(param2 + 3) & 1;
		  *(byte *)((int)param1 + 0xd) = *(byte *)((int)param2 + 0xd) & 1;
		  return;
		}
		*/


		/* --- GHIDRA: op_Implicit ---
		void I2_Loc_LocalizedString__op_Implicit(undefined4 *param1,undefined4 *param2,undefined4 param3)
		
		{
		  *param1 = *param2;
		  *(byte *)(param1 + 1) = *(byte *)(param2 + 1) & 1;
		  param1[2] = param2[2];
		  *(byte *)(param1 + 3) = *(byte *)(param2 + 3) & 1;
		  *(byte *)((int)param1 + 0xd) = *(byte *)((int)param2 + 0xd) & 1;
		  return;
		}
		*/

}
