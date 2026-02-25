using System;
using Il2CppDummyDll;
using UI.Windows;
using UnityEngine;

namespace Gameplay.AccountLinker.View
{
	// Token: 0x02000DFA RID: 3578
	[Token(Token = "0x2000DFA")]
	public class CodeDisplayViewWindow : ClosableBaseWindow<CodeDisplayViewWindow.CodeDisplayWindowArgs>
	{
		// Token: 0x170011CE RID: 4558
		// (get) Token: 0x06005750 RID: 22352 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170011CE")]
		public override string WindowId
		{
			[Token(Token = "0x6005750")]
			[Address(RVA = "0xA4CB", Offset = "0xA4CB", VA = "0xA4CB", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x06005751 RID: 22353 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005751")]
		[Address(RVA = "0xA4CC", Offset = "0xA4CC", VA = "0xA4CC", Slot = "22")]
		protected override void OnShow(CodeDisplayViewWindow.CodeDisplayWindowArgs args)
		{
		}

		// Token: 0x06005752 RID: 22354 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005752")]
		[Address(RVA = "0xA4CD", Offset = "0xA4CD", VA = "0xA4CD")]
		public CodeDisplayViewWindow()
		{
		}

		// Token: 0x04002F4E RID: 12110
		[Token(Token = "0x4002F4E")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/AccountLinker/CodeDisplayViewWindow";

		// Token: 0x04002F4F RID: 12111
		[Token(Token = "0x4002F4F")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private CodeDisplayView _codeDisplayView;

		// Token: 0x02000DFB RID: 3579
		[Token(Token = "0x2000DFB")]
		public class CodeDisplayWindowArgs : BaseWindowArgs
		{
			// Token: 0x06005753 RID: 22355 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005753")]
			[Address(RVA = "0xA4CE", Offset = "0xA4CE", VA = "0xA4CE")]
			public CodeDisplayWindowArgs()
			{
			}

			// Token: 0x04002F50 RID: 12112
			[Token(Token = "0x4002F50")]
			[FieldOffset(Offset = "0x18")]
			public string Code;
		}
	}
}
