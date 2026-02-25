using System;
using Il2CppDummyDll;

namespace UI.Windows
{
	// Token: 0x02000291 RID: 657
	[Token(Token = "0x2000291")]
	public class DialogWindow : BaseDialogWindow<DialogWindow.DialogWindowArgs>
	{
		// Token: 0x17000228 RID: 552
		// (get) Token: 0x06000F79 RID: 3961 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000228")]
		public override string WindowId
		{
			[Token(Token = "0x6000F79")]
			[Address(RVA = "0x61A4", Offset = "0x61A4", VA = "0x61A4", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000229 RID: 553
		// (get) Token: 0x06000F7A RID: 3962 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000229")]
		public static string YES_LABEL
		{
			[Token(Token = "0x6000F7A")]
			[Address(RVA = "0x61A5", Offset = "0x61A5", VA = "0x61A5")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700022A RID: 554
		// (get) Token: 0x06000F7B RID: 3963 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700022A")]
		public static string NO_LABEL
		{
			[Token(Token = "0x6000F7B")]
			[Address(RVA = "0x61A6", Offset = "0x61A6", VA = "0x61A6")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x06000F7C RID: 3964 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700022B")]
		public static string OK_LABEL
		{
			[Token(Token = "0x6000F7C")]
			[Address(RVA = "0x61A7", Offset = "0x61A7", VA = "0x61A7")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700022C RID: 556
		// (get) Token: 0x06000F7D RID: 3965 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700022C")]
		public static string CANCEL_LABEL
		{
			[Token(Token = "0x6000F7D")]
			[Address(RVA = "0x61A8", Offset = "0x61A8", VA = "0x61A8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000F7E RID: 3966 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000F7E")]
		[Address(RVA = "0x21B6", Offset = "0x21B6", VA = "0x21B6")]
		public static DialogWindow Show(DialogWindow.DialogWindowArgs args)
		{
			return null;
		}

		// Token: 0x06000F7F RID: 3967 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000F7F")]
		[Address(RVA = "0x61A9", Offset = "0x61A9", VA = "0x61A9")]
		public static DialogWindow Show(string title, string description, string label)
		{
			return null;
		}

		// Token: 0x06000F80 RID: 3968 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000F80")]
		[Address(RVA = "0x61AA", Offset = "0x61AA", VA = "0x61AA")]
		public static DialogWindow Show(string title, string description)
		{
			return null;
		}

		// Token: 0x06000F81 RID: 3969 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F81")]
		[Address(RVA = "0x61AB", Offset = "0x61AB", VA = "0x61AB")]
		public void TestDialogWnd()
		{
		}

		// Token: 0x06000F82 RID: 3970 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F82")]
		[Address(RVA = "0x61AC", Offset = "0x61AC", VA = "0x61AC")]
		public void TestAlert()
		{
		}

		// Token: 0x06000F83 RID: 3971 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F83")]
		[Address(RVA = "0x61AD", Offset = "0x61AD", VA = "0x61AD")]
		public DialogWindow()
		{
		}

		// Token: 0x040007DF RID: 2015
		[Token(Token = "0x40007DF")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/DialogWindow";

		// Token: 0x02000292 RID: 658
		[Token(Token = "0x2000292")]
		public class DialogWindowArgs : BaseDialogWindow<DialogWindow.DialogWindowArgs>.BaseDialogWindowArgs
		{
			// Token: 0x06000F84 RID: 3972 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000F84")]
			[Address(RVA = "0x21B2", Offset = "0x21B2", VA = "0x21B2")]
			public DialogWindowArgs()
			{
			}
		}
	}
}
