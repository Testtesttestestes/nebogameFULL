using System;
using Il2CppDummyDll;
using UnityEngine;

namespace WebGLSupport
{
	// Token: 0x0200002B RID: 43
	[Token(Token = "0x200002B")]
	public interface IInputField
	{
		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060001BE RID: 446
		[Token(Token = "0x17000030")]
		ContentType contentType { [Token(Token = "0x60001BE")] get; }

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060001BF RID: 447
		[Token(Token = "0x17000031")]
		LineType lineType { [Token(Token = "0x60001BF")] get; }

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060001C0 RID: 448
		[Token(Token = "0x17000032")]
		int fontSize { [Token(Token = "0x60001C0")] get; }

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060001C1 RID: 449
		// (set) Token: 0x060001C2 RID: 450
		[Token(Token = "0x17000033")]
		string text { [Token(Token = "0x60001C1")] get; [Token(Token = "0x60001C2")] set; }

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060001C3 RID: 451
		[Token(Token = "0x17000034")]
		string placeholder { [Token(Token = "0x60001C3")] get; }

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060001C4 RID: 452
		[Token(Token = "0x17000035")]
		int characterLimit { [Token(Token = "0x60001C4")] get; }

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060001C5 RID: 453
		[Token(Token = "0x17000036")]
		int caretPosition { [Token(Token = "0x60001C5")] get; }

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060001C6 RID: 454
		[Token(Token = "0x17000037")]
		bool isFocused { [Token(Token = "0x60001C6")] get; }

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060001C7 RID: 455
		// (set) Token: 0x060001C8 RID: 456
		[Token(Token = "0x17000038")]
		int selectionFocusPosition { [Token(Token = "0x60001C7")] get; [Token(Token = "0x60001C8")] set; }

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060001C9 RID: 457
		// (set) Token: 0x060001CA RID: 458
		[Token(Token = "0x17000039")]
		int selectionAnchorPosition { [Token(Token = "0x60001C9")] get; [Token(Token = "0x60001CA")] set; }

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060001CB RID: 459
		[Token(Token = "0x1700003A")]
		bool ReadOnly { [Token(Token = "0x60001CB")] get; }

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060001CC RID: 460
		[Token(Token = "0x1700003B")]
		bool OnFocusSelectAll { [Token(Token = "0x60001CC")] get; }

		// Token: 0x060001CD RID: 461
		[Token(Token = "0x60001CD")]
		RectTransform RectTransform();

		// Token: 0x060001CE RID: 462
		[Token(Token = "0x60001CE")]
		void ActivateInputField();

		// Token: 0x060001CF RID: 463
		[Token(Token = "0x60001CF")]
		void DeactivateInputField();

		// Token: 0x060001D0 RID: 464
		[Token(Token = "0x60001D0")]
		void Rebuild();
	}
}
