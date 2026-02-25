using System;
using Il2CppDummyDll;
using UI.Windows;
using Utils;

namespace Gameplay.Clans.Buildings.Golem.View
{
	// Token: 0x02000AC9 RID: 2761
	[Token(Token = "0x2000AC9")]
	public class NoFreeSlotsDialogWindow : BaseDialogWindow<NoFreeSlotsDialogWindow.NoFreeSlotsDialogWindowArgs>
	{
		// Token: 0x17000D1B RID: 3355
		// (get) Token: 0x0600428A RID: 17034 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000D1B")]
		public override string WindowId
		{
			[Token(Token = "0x600428A")]
			[Address(RVA = "0x913E", Offset = "0x913E", VA = "0x913E", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600428B RID: 17035 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600428B")]
		[Address(RVA = "0x913F", Offset = "0x913F", VA = "0x913F", Slot = "25")]
		protected override void HandleCloseButton()
		{
		}

		// Token: 0x0600428C RID: 17036 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600428C")]
		[Address(RVA = "0x9140", Offset = "0x9140", VA = "0x9140")]
		public static OpToken<int, int> Show()
		{
			return null;
		}

		// Token: 0x0600428D RID: 17037 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600428D")]
		[Address(RVA = "0x9141", Offset = "0x9141", VA = "0x9141")]
		public NoFreeSlotsDialogWindow()
		{
		}

		// Token: 0x040024B5 RID: 9397
		[Token(Token = "0x40024B5")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Clans/Golem/NoFreeSlotsDialogWindow";

		// Token: 0x02000ACA RID: 2762
		[Token(Token = "0x2000ACA")]
		public class NoFreeSlotsDialogWindowArgs : BaseDialogWindow<NoFreeSlotsDialogWindow.NoFreeSlotsDialogWindowArgs>.BaseDialogWindowArgs
		{
			// Token: 0x0600428E RID: 17038 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600428E")]
			[Address(RVA = "0x9142", Offset = "0x9142", VA = "0x9142")]
			public NoFreeSlotsDialogWindowArgs()
			{
			}

			// Token: 0x040024B6 RID: 9398
			[Token(Token = "0x40024B6")]
			[FieldOffset(Offset = "0x2C")]
			public OpToken<int, int> OpToken;
		}
	}
}
