using System;
using Il2CppDummyDll;

namespace Mycom.Tracker.Unity
{
	// Token: 0x02001344 RID: 4932
	[Token(Token = "0x2001344")]
	public static class SDKVersion
	{
		// Token: 0x04003D3E RID: 15678
		[Token(Token = "0x4003D3E")]
		[FieldOffset(Offset = "0x0")]
		public static readonly string Version;

		// Token: 0x04003D3F RID: 15679
		[Token(Token = "0x4003D3F")]
		[FieldOffset(Offset = "0x4")]
		public static readonly string Build;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: .cctor ---
		undefined4 Mycom_Tracker_Unity_SDKVersion___cctor(undefined4 param1)
		
		{
		  if (DAT_ram_00a5970b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Mycom_Tracker_Unity_Internal_Implementations_Fake_Tracker_TypeInfo);
		    DAT_ram_00a5970b = '\x01';
		  }
		  if (*(int *)(Mycom_Tracker_Unity_Internal_Implementations_Fake_Tracker_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Mycom_Tracker_Unity_Internal_Implementations_Fake_Tracker_TypeInfo);
		  }
		  return **(undefined4 **)
		           (Mycom_Tracker_Unity_Internal_Implementations_Fake_Tracker_TypeInfo + 0x5c);
		}
		*/

}
