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
		/* --- GHIDRA: CommitSettings ---
		void Core_Data_User_UserSettingsStub__CommitSettings(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a60805 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Data_User_TutorialUserSettings_TypeInfo);
		    DAT_ram_00a60805 = '\x01';
		  }
		  iVar1 = unnamed_function_1417(Core_Data_User_TutorialUserSettings_TypeInfo);
		  *(undefined **)(iVar1 + 8) = &DAT_ram_01010101;
		  *(undefined1 *)(iVar1 + 0xc) = 1;
		  *(int *)(param1 + 8) = iVar1;
		  return;
		}
		*/

		}

		// Token: 0x060064A2 RID: 25762 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064A2")]
		[Address(RVA = "0xB08B", Offset = "0xB08B", VA = "0xB08B")]
		public UserSettingsStub()
		{
		}
	}
}
