using System;
using Gameplay.Inventory;
using Il2CppDummyDll;
using JetBrains.Annotations;
using UI.Toast;

namespace Core.Errors.Expected
{
	// Token: 0x02001063 RID: 4195
	[Token(Token = "0x2001063")]
	public class ExpectedItemErrors : ExpectedDefaultError
	{
		// Token: 0x0600625B RID: 25179 RVA: 0x00012600 File Offset: 0x00010800
		[Token(Token = "0x600625B")]
		[Address(RVA = "0xAE81", Offset = "0xAE81", VA = "0xAE81", Slot = "4")]
		public override bool Handle(int errorCode)
		{
			return default(bool);
		}

		// Token: 0x0600625C RID: 25180 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600625C")]
		[Address(RVA = "0xAE82", Offset = "0xAE82", VA = "0xAE82")]
		public ExpectedItemErrors()
		{
		}

		// Token: 0x02001064 RID: 4196
		[Token(Token = "0x2001064")]
		internal class ErrorArgs
		{
			// Token: 0x0600625D RID: 25181 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600625D")]
			[Address(RVA = "0xAE83", Offset = "0xAE83", VA = "0xAE83")]
			public ErrorArgs(IInventory inventory, ToastController toasts, int requiredSlotsCount)
			{
			}

			// Token: 0x040034E3 RID: 13539
			[Token(Token = "0x40034E3")]
			[FieldOffset(Offset = "0x8")]
			public readonly IInventory Inventory;

			// Token: 0x040034E4 RID: 13540
			[Token(Token = "0x40034E4")]
			[FieldOffset(Offset = "0xC")]
			public readonly ToastController Toasts;

			// Token: 0x040034E5 RID: 13541
			[Token(Token = "0x40034E5")]
			[FieldOffset(Offset = "0x10")]
			public readonly int RequiredSlotsCount;

			// Token: 0x040034E6 RID: 13542
			[Token(Token = "0x40034E6")]
			[FieldOffset(Offset = "0x14")]
			[CanBeNull]
			public Action<int> EmptySlotResolveCallback;
		}
	}
}
