using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using JetBrains.Annotations;

namespace Core.Data.InfoRows
{
	// Token: 0x020010DC RID: 4316
	[Token(Token = "0x20010DC")]
	public abstract class AbstractUserInformationProvider : AbstractInformationProvider
	{
		// Token: 0x17001475 RID: 5237
		// (get) Token: 0x06006512 RID: 25874 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006513 RID: 25875 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001475")]
		[NotNull]
		public UserData User
		{
			[Token(Token = "0x6006512")]
			[Address(RVA = "0xB0E8", Offset = "0xB0E8", VA = "0xB0E8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006513")]
			[Address(RVA = "0xB0E9", Offset = "0xB0E9", VA = "0xB0E9")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06006514 RID: 25876 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006514")]
		[Address(RVA = "0xB0EA", Offset = "0xB0EA", VA = "0xB0EA", Slot = "7")]
		public override void Dispose()
		{
		}

		// Token: 0x06006515 RID: 25877 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006515")]
		[Address(RVA = "0xB0EB", Offset = "0xB0EB", VA = "0xB0EB")]
		protected AbstractUserInformationProvider([NotNull] UserData user, [NotNull] UserData loggedUser)
		{
		}
	}
}
