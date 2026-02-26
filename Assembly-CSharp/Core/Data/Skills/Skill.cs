using System;
using Il2CppDummyDll;

namespace Core.Data.Skills
{
	// Token: 0x020010D5 RID: 4309
	[Token(Token = "0x20010D5")]
	public class Skill
	{
		// Token: 0x060064F5 RID: 25845 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60064F5")]
		[Address(RVA = "0xB0CF", Offset = "0xB0CF", VA = "0xB0CF", Slot = "3")]
		public override string ToString()
		{
		/* --- GHIDRA: ToString ---
		uint Core_Data_Skills_Skill__ToString(int param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  ulonglong uVar2;
		  
		  uVar2 = *(ulonglong *)(param2 + 0x10) & 0x80000000;
		  uVar1 = (uint)(uVar2 >> 0x1f);
		  if ((*(byte *)(param1 + 0x13) & 0x80) == 0) {
		    uVar1 = (uint)(uVar2 == 0);
		  }
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x17001470 RID: 5232
		// (get) Token: 0x060064F6 RID: 25846 RVA: 0x000133B0 File Offset: 0x000115B0
		[Token(Token = "0x17001470")]
		public bool IsProcent
		{
			[Token(Token = "0x60064F6")]
			[Address(RVA = "0x2161", Offset = "0x2161", VA = "0x2161")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060064F7 RID: 25847 RVA: 0x000133C8 File Offset: 0x000115C8
		[Token(Token = "0x60064F7")]
		[Address(RVA = "0xB0D0", Offset = "0xB0D0", VA = "0xB0D0")]
		public bool EqualType(Skill skill)
		{
		/* --- GHIDRA: EqualType ---
		int Core_Data_Skills_Skill__EqualType(undefined8 param1,int param2,undefined4 param3)
		
		{
		  int param2_00;
		  longlong local_8;
		  
		  if (DAT_ram_00a6082c == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_1226);
		    Mono_Security_ASN1__get_Item(&StringLiteral_708);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    DAT_ram_00a6082c = '\x01';
		  }
		  local_8 = (longlong)(int)(((uint)param1 & 0x40000000) << 1 | (uint)param1 & 0x7fffffff);
		  param2_00 = UnityEngine_GameObject__SetActive(&local_8,0);
		  if (param2_00 == 0) {
		    param2_00 = StringLiteral_5;
		  }
		  if ((param2 != 0) && (0 < local_8)) {
		    param2_00 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(StringLiteral_1226,param2_00,0);
		  }
		  if (((uint)param1 & 0x80000000) != 0) {
		    param2_00 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(param2_00,StringLiteral_708,0);
		  }
		  return param2_00;
		}
		*/

			return default(bool);
		}

		// Token: 0x060064F8 RID: 25848 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60064F8")]
		[Address(RVA = "0x1B31", Offset = "0x1B31", VA = "0x1B31")]
		public static Skill operator +(Skill a, Skill b)
		{
			return null;
		}

		// Token: 0x060064F9 RID: 25849 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60064F9")]
		[Address(RVA = "0xB0D1", Offset = "0xB0D1", VA = "0xB0D1")]
		public static string FormatUserSkillValue(long value, bool polar)
		{
			return null;
		}

		// Token: 0x060064FA RID: 25850 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064FA")]
		[Address(RVA = "0xB0D2", Offset = "0xB0D2", VA = "0xB0D2")]
		public Skill()
		{
		/* --- GHIDRA: .ctor ---
		void Core_Data_Skills_Skill___ctor(undefined4 param1,int param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a6082d == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_Dictionary_int__Skill__Add__);
		    DAT_ram_00a6082d = '\x01';
		  }
		  UnityEngine_Object__GetInstanceID
		            (param1,*(undefined4 *)(param2 + 8),param2,
		             Method_System_Collections_Generic_Dictionary_int__Skill__Add__);
		  return;
		}
		*/

		}

		// Token: 0x040035D7 RID: 13783
		[Token(Token = "0x40035D7")]
		[FieldOffset(Offset = "0x8")]
		public int Id;

		// Token: 0x040035D8 RID: 13784
		[Token(Token = "0x40035D8")]
		[FieldOffset(Offset = "0x10")]
		public long Value;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_IsProcent ---
		int Core_Data_Skills_Skill__get_IsProcent(undefined8 param1,undefined4 param2)
		
		{
		  int param1_00;
		  longlong local_8;
		  
		  if (DAT_ram_00a607d9 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_708);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    DAT_ram_00a607d9 = '\x01';
		  }
		  local_8 = (longlong)(int)(((uint)param1 & 0x40000000) << 1 | (uint)param1 & 0x7fffffff);
		  param1_00 = UnityEngine_GameObject__SetActive(&local_8,0);
		  if (param1_00 == 0) {
		    param1_00 = StringLiteral_5;
		  }
		  if (((uint)param1 & 0x80000000) != 0) {
		    param1_00 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(param1_00,StringLiteral_708,0);
		  }
		  return param1_00;
		}
		*/

}
