using System;
using Com.TheFallenGames.OSA.Core;
using Il2CppDummyDll;

namespace UI.ValuePicker
{
	// Token: 0x0200011E RID: 286
	[Token(Token = "0x200011E")]
	public class ValuePickerOsaViewHolder : BaseItemViewsHolder
	{
		// Token: 0x060008F1 RID: 2289 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008F1")]
		[Address(RVA = "0x5C70", Offset = "0x5C70", VA = "0x5C70", Slot = "7")]
		public override void CollectViews()
		{
		}

		// Token: 0x060008F2 RID: 2290 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008F2")]
		[Address(RVA = "0x5C71", Offset = "0x5C71", VA = "0x5C71")]
		public ValuePickerOsaViewHolder()
		{
		/* --- GHIDRA: .ctor ---
		void UI_ValuePicker_ValuePickerOsaViewHolder___ctor
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5b8af == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_19433);
		    DAT_ram_00a5b8af = '\x01';
		  }
		  param1_00 = TMPro_TMP_LinkInfo__GetLink(param2,0);
		  Core_ExternAppMethods__OpenPaymentWindow(param1_00,StringLiteral_19433,0,0);
		  return;
		}
		*/

		}

		// Token: 0x04000346 RID: 838
		[Token(Token = "0x4000346")]
		[FieldOffset(Offset = "0x14")]
		public ValuePickerItem ValuePickerItem;
	}
}
