using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;
using Protocol.Consts;

namespace Core.Application.Managers
{
	// Token: 0x02001257 RID: 4695
	[Token(Token = "0x2001257")]
	public abstract class AbstractPlatformSigninProvider : IPlatformSigninProvider
	{
		// Token: 0x06006F4F RID: 28495 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006F4F")]
		[Address(RVA = "0xB9BB", Offset = "0xB9BB", VA = "0xB9BB")]
		public AbstractPlatformSigninProvider(ClientPlatform platform)
		{
		}

		// Token: 0x170016B9 RID: 5817
		// (get) Token: 0x06006F50 RID: 28496 RVA: 0x00014460 File Offset: 0x00012660
		[Token(Token = "0x170016B9")]
		public ClientPlatform Platform
		{
			[Token(Token = "0x6006F50")]
			[Address(RVA = "0xB9BC", Offset = "0xB9BC", VA = "0xB9BC", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return ClientPlatform.UnknownClientPlatform;
			}
		}

		// Token: 0x170016BA RID: 5818
		// (get) Token: 0x06006F51 RID: 28497 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006F52 RID: 28498 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170016BA")]
		public string Nick
		{
			[Token(Token = "0x6006F51")]
			[Address(RVA = "0xB9BD", Offset = "0xB9BD", VA = "0xB9BD", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006F52")]
			[Address(RVA = "0xB9BE", Offset = "0xB9BE", VA = "0xB9BE")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170016BB RID: 5819
		// (get) Token: 0x06006F53 RID: 28499 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006F54 RID: 28500 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170016BB")]
		public SigninRecord SigninRecord
		{
			[Token(Token = "0x6006F53")]
			[Address(RVA = "0xB9BF", Offset = "0xB9BF", VA = "0xB9BF", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006F54")]
			[Address(RVA = "0xB9C0", Offset = "0xB9C0", VA = "0xB9C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170016BC RID: 5820
		// (get) Token: 0x06006F55 RID: 28501 RVA: 0x00014478 File Offset: 0x00012678
		// (set) Token: 0x06006F56 RID: 28502 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170016BC")]
		public virtual AbstractPlatformSigninProvider.SigninState CurrentState
		{
			[Token(Token = "0x6006F55")]
			[Address(RVA = "0xB9C1", Offset = "0xB9C1", VA = "0xB9C1", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return AbstractPlatformSigninProvider.SigninState.DEFAULT;
			}
			[Token(Token = "0x6006F56")]
			[Address(RVA = "0xB9C2", Offset = "0xB9C2", VA = "0xB9C2", Slot = "13")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06006F57 RID: 28503 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006F57")]
		[Address(RVA = "0xB9C3", Offset = "0xB9C3", VA = "0xB9C3", Slot = "14")]
		public virtual void Commit()
		{
		}

		// Token: 0x06006F58 RID: 28504 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006F58")]
		[Address(RVA = "0xB9C4", Offset = "0xB9C4", VA = "0xB9C4", Slot = "15")]
		public virtual void Reset()
		{
		}

		// Token: 0x06006F59 RID: 28505 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006F59")]
		[Address(RVA = "0xB9C5", Offset = "0xB9C5", VA = "0xB9C5", Slot = "16")]
		public virtual void SignOut()
		{
		}

		// Token: 0x06006F5A RID: 28506
		[Token(Token = "0x6006F5A")]
		public abstract UniTask<IPlatformSigninProvider> UpdateSigninRecord();

		// Token: 0x06006F5B RID: 28507 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006F5B")]
		[Address(RVA = "0xB9C6", Offset = "0xB9C6", VA = "0xB9C6", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x02001258 RID: 4696
		[Token(Token = "0x2001258")]
		public enum SigninState
		{
			// Token: 0x04003A1E RID: 14878
			[Token(Token = "0x4003A1E")]
			DEFAULT,
			// Token: 0x04003A1F RID: 14879
			[Token(Token = "0x4003A1F")]
			SIGNIN_SUCCESS,
			// Token: 0x04003A20 RID: 14880
			[Token(Token = "0x4003A20")]
			SIGNIN_FAILED,
			// Token: 0x04003A21 RID: 14881
			[Token(Token = "0x4003A21")]
			SIGNIN_PENDDING
		}
	}
}
