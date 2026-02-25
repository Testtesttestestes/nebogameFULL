using System;
using Com.TheFallenGames.OSA.CustomParams;
using Il2CppDummyDll;

namespace UI.ValuePicker
{
	// Token: 0x0200011D RID: 285
	[Token(Token = "0x200011D")]
	[Serializable]
	public class ValuePickerOsaParams : BaseParamsWithPrefab
	{
		// Token: 0x060008EF RID: 2287 RVA: 0x000035B8 File Offset: 0x000017B8
		[Token(Token = "0x60008EF")]
		[Address(RVA = "0x5C6E", Offset = "0x5C6E", VA = "0x5C6E")]
		public int GetItemValueAtIndex(int index)
		{
			return 0;
		}

		// Token: 0x060008F0 RID: 2288 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008F0")]
		[Address(RVA = "0x5C6F", Offset = "0x5C6F", VA = "0x5C6F")]
		public ValuePickerOsaParams()
		{
		}

		// Token: 0x04000344 RID: 836
		[Token(Token = "0x4000344")]
		[FieldOffset(Offset = "0x58")]
		public int startItemNumber;

		// Token: 0x04000345 RID: 837
		[Token(Token = "0x4000345")]
		[FieldOffset(Offset = "0x5C")]
		public int increment;
	}
}
