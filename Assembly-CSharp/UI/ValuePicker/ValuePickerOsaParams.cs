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
		/* --- GHIDRA: .ctor ---
		void UI_ValuePicker_ValuePickerOsaParams___ctor(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5b8ae == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_ValuePickerItem___);
		    DAT_ram_00a5b8ae = '\x01';
		  }
		  uVar1 = func_ii_5677(*(undefined4 *)(param1 + 8),
		                       Method_UnityEngine_Component_GetComponent_ValuePickerItem___);
		  *(undefined4 *)(param1 + 0x14) = uVar1;
		  return;
		}
		*/

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
