using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Protocol.World;

namespace Core.Errors.Expected
{
	// Token: 0x0200105E RID: 4190
	[Token(Token = "0x200105E")]
	public class ExpectedGetUserIsleInfoErrors : ExpectedDefaultError
	{
		// Token: 0x0600624D RID: 25165 RVA: 0x000125D0 File Offset: 0x000107D0
		[Token(Token = "0x600624D")]
		[Address(RVA = "0xAE73", Offset = "0xAE73", VA = "0xAE73", Slot = "4")]
		public override bool Handle(int errorCode)
		{
			return default(bool);
		}

		// Token: 0x0600624E RID: 25166 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600624E")]
		[Address(RVA = "0xAE74", Offset = "0xAE74", VA = "0xAE74")]
		private void ShowUsersOverLimitWindow()
		{
		}

		// Token: 0x0600624F RID: 25167 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600624F")]
		[Address(RVA = "0xAE75", Offset = "0xAE75", VA = "0xAE75")]
		public ExpectedGetUserIsleInfoErrors()
		{
		}

		// Token: 0x0200105F RID: 4191
		[Token(Token = "0x200105F")]
		public class ExpectedGetUserIsleInfoErrorArgs : IDisposable
		{
			// Token: 0x170013A8 RID: 5032
			// (get) Token: 0x06006250 RID: 25168 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x06006251 RID: 25169 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170013A8")]
			public ProtoGetUserIsleInfoAns Msg
			{
				[Token(Token = "0x6006250")]
				[Address(RVA = "0xAE76", Offset = "0xAE76", VA = "0xAE76")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6006251")]
				[Address(RVA = "0xAE77", Offset = "0xAE77", VA = "0xAE77")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x06006252 RID: 25170 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006252")]
			[Address(RVA = "0xAE78", Offset = "0xAE78", VA = "0xAE78")]
			public ExpectedGetUserIsleInfoErrorArgs(ProtoGetUserIsleInfoAns msg)
			{
			}

			// Token: 0x06006253 RID: 25171 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006253")]
			[Address(RVA = "0xAE79", Offset = "0xAE79", VA = "0xAE79", Slot = "4")]
			public void Dispose()
			{
			}
		}
	}
}
