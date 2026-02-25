using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Core.Data.User
{
	// Token: 0x020010C9 RID: 4297
	[Token(Token = "0x20010C9")]
	public class UserSettingsStub : IUserSettings
	{
		// Token: 0x17001456 RID: 5206
		// (get) Token: 0x060064A0 RID: 25760 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001456")]
		public UserSettings Settings
		{
			[Token(Token = "0x60064A0")]
			[Address(RVA = "0xB089", Offset = "0xB089", VA = "0xB089", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x060064A1 RID: 25761 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064A1")]
		[Address(RVA = "0xB08A", Offset = "0xB08A", VA = "0xB08A", Slot = "5")]
		public void CommitSettings()
		{
		}

		// Token: 0x060064A2 RID: 25762 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064A2")]
		[Address(RVA = "0xB08B", Offset = "0xB08B", VA = "0xB08B")]
		public UserSettingsStub()
		{
		}
	}
}
