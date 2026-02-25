using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UI.ValuePicker;
using UnityEngine;

namespace UI.Windows
{
	// Token: 0x02000298 RID: 664
	[Token(Token = "0x2000298")]
	public class IntegerValuePickerWindow : BaseDialogWindow<IntegerValuePickerWindow.IntegerValuePickerWindowArgs>
	{
		// Token: 0x1700022E RID: 558
		// (get) Token: 0x06000F93 RID: 3987 RVA: 0x000044E8 File Offset: 0x000026E8
		// (set) Token: 0x06000F94 RID: 3988 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700022E")]
		public int SelectedValue
		{
			[Token(Token = "0x6000F93")]
			[Address(RVA = "0x61BC", Offset = "0x61BC", VA = "0x61BC")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000F94")]
			[Address(RVA = "0x61BD", Offset = "0x61BD", VA = "0x61BD")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700022F RID: 559
		// (get) Token: 0x06000F95 RID: 3989 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700022F")]
		public override string WindowId
		{
			[Token(Token = "0x6000F95")]
			[Address(RVA = "0x61BE", Offset = "0x61BE", VA = "0x61BE", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000F96 RID: 3990 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F96")]
		[Address(RVA = "0x61BF", Offset = "0x61BF", VA = "0x61BF", Slot = "22")]
		protected override void OnShow(IntegerValuePickerWindow.IntegerValuePickerWindowArgs args)
		{
		}

		// Token: 0x06000F97 RID: 3991 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F97")]
		[Address(RVA = "0x61C0", Offset = "0x61C0", VA = "0x61C0", Slot = "19")]
		protected override void OnClose()
		{
		}

		// Token: 0x06000F98 RID: 3992 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F98")]
		[Address(RVA = "0x61C1", Offset = "0x61C1", VA = "0x61C1")]
		private void HandlePickerSelectionChangedEvent(int value)
		{
		}

		// Token: 0x06000F99 RID: 3993 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F99")]
		[Address(RVA = "0x61C2", Offset = "0x61C2", VA = "0x61C2", Slot = "28")]
		protected override void HandleContent()
		{
		}

		// Token: 0x06000F9A RID: 3994 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000F9A")]
		[Address(RVA = "0x61C3", Offset = "0x61C3", VA = "0x61C3")]
		public static IntegerValuePickerWindow Show(IntegerValuePickerWindow.IntegerValuePickerWindowArgs args)
		{
			return null;
		}

		// Token: 0x06000F9B RID: 3995 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F9B")]
		[Address(RVA = "0x61C4", Offset = "0x61C4", VA = "0x61C4")]
		public IntegerValuePickerWindow()
		{
		}

		// Token: 0x040007E9 RID: 2025
		[Token(Token = "0x40007E9")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private IntegerValuePicker _picker;

		// Token: 0x040007EB RID: 2027
		[Token(Token = "0x40007EB")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/IntegerValuePickerWindow";

		// Token: 0x02000299 RID: 665
		[Token(Token = "0x2000299")]
		public class IntegerValuePickerWindowArgs : BaseDialogWindow<IntegerValuePickerWindow.IntegerValuePickerWindowArgs>.BaseDialogWindowArgs
		{
			// Token: 0x17000230 RID: 560
			// (get) Token: 0x06000F9C RID: 3996 RVA: 0x00004500 File Offset: 0x00002700
			// (set) Token: 0x06000F9D RID: 3997 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000230")]
			public int SelectedValue
			{
				[Token(Token = "0x6000F9C")]
				[Address(RVA = "0x61C5", Offset = "0x61C5", VA = "0x61C5")]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[Token(Token = "0x6000F9D")]
				[Address(RVA = "0x61C6", Offset = "0x61C6", VA = "0x61C6")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x06000F9E RID: 3998 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000F9E")]
			[Address(RVA = "0x61C7", Offset = "0x61C7", VA = "0x61C7")]
			public IntegerValuePickerWindowArgs(string selectButtonLabel)
			{
			}

			// Token: 0x040007EC RID: 2028
			[Token(Token = "0x40007EC")]
			[FieldOffset(Offset = "0x2C")]
			public IList<int> Values;

			// Token: 0x040007EE RID: 2030
			[Token(Token = "0x40007EE")]
			[FieldOffset(Offset = "0x34")]
			public BaseDialogWindow<IntegerValuePickerWindow.IntegerValuePickerWindowArgs>.BaseDialogWindowArgs.DialogWindowButton.ButtonInvoker<int>.ButtonCallbackDelegate SelectCallback;

			// Token: 0x040007EF RID: 2031
			[Token(Token = "0x40007EF")]
			[FieldOffset(Offset = "0x38")]
			public readonly string SelectButtonLabel;
		}
	}
}
