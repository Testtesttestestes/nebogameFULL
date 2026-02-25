using System;
using Il2CppDummyDll;
using TMPro;
using UI.Utils;
using UnityEngine;

namespace UI
{
	// Token: 0x02000114 RID: 276
	[Token(Token = "0x2000114")]
	public class TextFieldWhitLayoutUpdater : MonoBehaviour
	{
		// Token: 0x1700011C RID: 284
		// (get) Token: 0x060008B7 RID: 2231 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060008B8 RID: 2232 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700011C")]
		public virtual string Text
		{
			[Token(Token = "0x60008B7")]
			[Address(RVA = "0x5C43", Offset = "0x5C43", VA = "0x5C43", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008B8")]
			[Address(RVA = "0x5C44", Offset = "0x5C44", VA = "0x5C44", Slot = "5")]
			set
			{
			}
		}

		// Token: 0x060008B9 RID: 2233 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008B9")]
		[Address(RVA = "0x5C45", Offset = "0x5C45", VA = "0x5C45")]
		public TextFieldWhitLayoutUpdater()
		{
		}

		// Token: 0x04000324 RID: 804
		[Token(Token = "0x4000324")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		protected TextMeshProUGUI _textField;

		// Token: 0x04000325 RID: 805
		[Token(Token = "0x4000325")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private LayoutUpdater _layoutUpdater;
	}
}
