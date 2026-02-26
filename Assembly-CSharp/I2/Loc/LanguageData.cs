using System;
using Il2CppDummyDll;

namespace I2.Loc
{
	// Token: 0x02001369 RID: 4969
	[Token(Token = "0x2001369")]
	[Serializable]
	public class LanguageData
	{
		// Token: 0x060075E4 RID: 30180 RVA: 0x000154C8 File Offset: 0x000136C8
		[Token(Token = "0x60075E4")]
		[Address(RVA = "0xBF6D", Offset = "0xBF6D", VA = "0xBF6D")]
		public bool IsEnabled()
		{
		/* --- GHIDRA: IsEnabled ---
		void I2_Loc_LanguageData__IsEnabled(int param1,undefined4 param2,undefined4 param3)
		
		{
		  *(byte *)(param1 + 0x10) = *(byte *)(param1 + 0x10) & 0xfe | (byte)param2 ^ 1;
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x060075E5 RID: 30181 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60075E5")]
		[Address(RVA = "0xBF6E", Offset = "0xBF6E", VA = "0xBF6E")]
		public void SetEnabled(bool bEnabled)
		{
		/* --- GHIDRA: SetEnabled ---
		uint I2_Loc_LanguageData__SetEnabled(int param1,undefined4 param2)
		
		{
		  return (uint)((*(byte *)(param1 + 0x10) & 4) == 0);
		}
		*/

		}

		// Token: 0x060075E6 RID: 30182 RVA: 0x000154E0 File Offset: 0x000136E0
		[Token(Token = "0x60075E6")]
		[Address(RVA = "0xBF6F", Offset = "0xBF6F", VA = "0xBF6F")]
		public bool IsLoaded()
		{
		/* --- GHIDRA: IsLoaded ---
		uint I2_Loc_LanguageData__IsLoaded(int param1,undefined4 param2)
		
		{
		  return (uint)((*(byte *)(param1 + 0x10) & 2) == 0);
		}
		*/

			return default(bool);
		}

		// Token: 0x060075E7 RID: 30183 RVA: 0x000154F8 File Offset: 0x000136F8
		[Token(Token = "0x60075E7")]
		[Address(RVA = "0xBF70", Offset = "0xBF70", VA = "0xBF70")]
		public bool CanBeUnloaded()
		{
		/* --- GHIDRA: CanBeUnloaded ---
		void I2_Loc_LanguageData__CanBeUnloaded(int param1,int param2,undefined4 param3)
		
		{
		  byte bVar1;
		  
		  bVar1 = 0;
		  if (param2 == 0) {
		    bVar1 = 4;
		  }
		  *(byte *)(param1 + 0x10) = *(byte *)(param1 + 0x10) & 0xfb | bVar1;
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x060075E8 RID: 30184 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60075E8")]
		[Address(RVA = "0xBF71", Offset = "0xBF71", VA = "0xBF71")]
		public void SetLoaded(bool loaded)
		{
		/* --- GHIDRA: SetLoaded ---
		void I2_Loc_LanguageData__SetLoaded(int param1,int param2,undefined4 param3)
		
		{
		  byte bVar1;
		  
		  bVar1 = 0;
		  if (param2 == 0) {
		    bVar1 = 2;
		  }
		  *(byte *)(param1 + 0x10) = *(byte *)(param1 + 0x10) & 0xfd | bVar1;
		  return;
		}
		*/

		}

		// Token: 0x060075E9 RID: 30185 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60075E9")]
		[Address(RVA = "0xBF72", Offset = "0xBF72", VA = "0xBF72")]
		public void SetCanBeUnLoaded(bool allowUnloading)
		{
		}

		// Token: 0x060075EA RID: 30186 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60075EA")]
		[Address(RVA = "0xBF73", Offset = "0xBF73", VA = "0xBF73")]
		public LanguageData()
		{
		}

		// Token: 0x04003D9D RID: 15773
		[Token(Token = "0x4003D9D")]
		[FieldOffset(Offset = "0x8")]
		public string Name;

		// Token: 0x04003D9E RID: 15774
		[Token(Token = "0x4003D9E")]
		[FieldOffset(Offset = "0xC")]
		public string Code;

		// Token: 0x04003D9F RID: 15775
		[Token(Token = "0x4003D9F")]
		[FieldOffset(Offset = "0x10")]
		public byte Flags;

		// Token: 0x04003DA0 RID: 15776
		[Token(Token = "0x4003DA0")]
		[FieldOffset(Offset = "0x11")]
		[NonSerialized]
		public bool Compressed;
	}
}
