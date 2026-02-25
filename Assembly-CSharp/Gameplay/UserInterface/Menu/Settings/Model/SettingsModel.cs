using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Data.User;
using Core.Gameplay;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.UserInterface.Menu.Settings.Model
{
	// Token: 0x020003DE RID: 990
	[Token(Token = "0x20003DE")]
	public class SettingsModel : AbstractModel
	{
		// Token: 0x17000403 RID: 1027
		// (get) Token: 0x0600172A RID: 5930 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600172B RID: 5931 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000403")]
		public IGame Game
		{
			[Token(Token = "0x600172A")]
			[Address(RVA = "0x68E9", Offset = "0x68E9", VA = "0x68E9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600172B")]
			[Address(RVA = "0x68EA", Offset = "0x68EA", VA = "0x68EA")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000404 RID: 1028
		// (get) Token: 0x0600172C RID: 5932 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600172D RID: 5933 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000404")]
		public IUserSettings UserSettings
		{
			[Token(Token = "0x600172C")]
			[Address(RVA = "0x68EB", Offset = "0x68EB", VA = "0x68EB")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600172D")]
			[Address(RVA = "0x68EC", Offset = "0x68EC", VA = "0x68EC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600172E RID: 5934 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600172E")]
		[Address(RVA = "0x68ED", Offset = "0x68ED", VA = "0x68ED", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x0600172F RID: 5935 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600172F")]
		[Address(RVA = "0x68EE", Offset = "0x68EE", VA = "0x68EE")]
		public SettingsModel(IGame game, UserData user)
		{
		}
	}
}
