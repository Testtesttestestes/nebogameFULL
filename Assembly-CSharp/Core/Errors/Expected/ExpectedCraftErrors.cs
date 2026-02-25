using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Core.Errors.Expected
{
	// Token: 0x0200104F RID: 4175
	[Token(Token = "0x200104F")]
	public class ExpectedCraftErrors : ExpectedDefaultError
	{
		// Token: 0x06006220 RID: 25120 RVA: 0x00012450 File Offset: 0x00010650
		[Token(Token = "0x6006220")]
		[Address(RVA = "0xAE4B", Offset = "0xAE4B", VA = "0xAE4B", Slot = "4")]
		public override bool Handle(int errorCode)
		{
			return default(bool);
		}

		// Token: 0x06006221 RID: 25121 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006221")]
		[Address(RVA = "0xAE4C", Offset = "0xAE4C", VA = "0xAE4C")]
		public void ShowToast(string msg)
		{
		}

		// Token: 0x06006222 RID: 25122 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006222")]
		[Address(RVA = "0xAE4D", Offset = "0xAE4D", VA = "0xAE4D")]
		public ExpectedCraftErrors()
		{
		}

		// Token: 0x02001050 RID: 4176
		[Token(Token = "0x2001050")]
		public class ExpectedCraftErrorsArgs : IDisposable
		{
			// Token: 0x170013A6 RID: 5030
			// (get) Token: 0x06006224 RID: 25124 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x06006225 RID: 25125 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170013A6")]
			public Action Callback
			{
				[Token(Token = "0x6006224")]
				[Address(RVA = "0xAE4F", Offset = "0xAE4F", VA = "0xAE4F")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6006225")]
				[Address(RVA = "0xAE50", Offset = "0xAE50", VA = "0xAE50")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x06006226 RID: 25126 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006226")]
			[Address(RVA = "0xAE51", Offset = "0xAE51", VA = "0xAE51")]
			public ExpectedCraftErrorsArgs(Action callback)
			{
			}

			// Token: 0x06006227 RID: 25127 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006227")]
			[Address(RVA = "0xAE52", Offset = "0xAE52", VA = "0xAE52", Slot = "4")]
			public void Dispose()
			{
			}
		}
	}
}
