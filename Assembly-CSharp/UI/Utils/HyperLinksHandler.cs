using System;
using Il2CppDummyDll;
using TMPro;

namespace UI.Utils
{
	// Token: 0x0200011F RID: 287
	[Token(Token = "0x200011F")]
	public class HyperLinksHandler : TextLinkHandler
	{
		// Token: 0x060008F3 RID: 2291 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008F3")]
		[Address(RVA = "0x5C72", Offset = "0x5C72", VA = "0x5C72", Slot = "5")]
		protected override void Handle(TMP_LinkInfo linkInfo)
		{
		}

		// Token: 0x060008F4 RID: 2292 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008F4")]
		[Address(RVA = "0x5C73", Offset = "0x5C73", VA = "0x5C73")]
		public HyperLinksHandler()
		{
		/* --- GHIDRA: .ctor ---
		void UI_Utils_HyperLinksHandler___ctor(int param1,undefined4 param2)
		
		{
		  if (*(char *)(param1 + 0x14) == '\0') {
		    if (*(int *)(param1 + 0x10) != 0) {
		      UnityEngine_Events_UnityEvent__GetDelegate(*(int *)(param1 + 0x10),0);
		    }
		    *(undefined1 *)(param1 + 0x14) = 1;
		  }
		  return;
		}
		*/

		}
	}
}
