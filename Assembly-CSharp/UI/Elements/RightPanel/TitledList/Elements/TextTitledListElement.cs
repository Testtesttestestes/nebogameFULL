using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace UI.Elements.RightPanel.TitledList.Elements
{
	// Token: 0x0200020E RID: 526
	[Token(Token = "0x200020E")]
	public class TextTitledListElement : BaseTitledListElement<TextTitledListElement.TextTitledListElementArgs>
	{
		// Token: 0x06000D49 RID: 3401 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D49")]
		[Address(RVA = "0x602C", Offset = "0x602C", VA = "0x602C", Slot = "6")]
		protected override void OnInit(TextTitledListElement.TextTitledListElementArgs args)
		{
		/* --- GHIDRA: OnInit ---
		void UI_Elements_RightPanel_TitledList_Elements_TextTitledListElement__OnInit
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a63967 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_RightPanel_TitledList_BaseTitledListElement_TextTitledListElement_TextTitledListElementArgs___ctor__
		              );
		    DAT_ram_00a63967 = '\x01';
		  }
		  UnityEngine_ParticleSystemRenderer__GetMeshes
		            (param1,
		             Method_UI_Elements_RightPanel_TitledList_BaseTitledListElement_TextTitledListElement_TextTitledListElementArgs___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06000D4A RID: 3402 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D4A")]
		[Address(RVA = "0x602D", Offset = "0x602D", VA = "0x602D")]
		public TextTitledListElement()
		{
		}

		// Token: 0x04000690 RID: 1680
		[Token(Token = "0x4000690")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextMeshProUGUI _textField;

		// Token: 0x0200020F RID: 527
		[Token(Token = "0x200020F")]
		public class TextTitledListElementArgs : BaseTitledListElementArgs
		{
			// Token: 0x06000D4B RID: 3403 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000D4B")]
			[Address(RVA = "0x602E", Offset = "0x602E", VA = "0x602E")]
			public TextTitledListElementArgs(string text)
			{
			}

			// Token: 0x04000691 RID: 1681
			[Token(Token = "0x4000691")]
			[FieldOffset(Offset = "0x8")]
			public readonly string Text;
		}
	}
}
