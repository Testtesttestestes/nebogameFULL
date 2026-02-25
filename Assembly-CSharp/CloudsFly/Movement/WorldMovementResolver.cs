using System;
using Core.Data.User;
using Il2CppDummyDll;

namespace CloudsFly.Movement
{
	// Token: 0x02001315 RID: 4885
	[Token(Token = "0x2001315")]
	public class WorldMovementResolver
	{
		// Token: 0x06007411 RID: 29713 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007411")]
		[Address(RVA = "0xBDDF", Offset = "0xBDDF", VA = "0xBDDF")]
		public WorldMovementResolver(IUserSettings userSettings)
		{
		}

		// Token: 0x06007412 RID: 29714 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007412")]
		[Address(RVA = "0xBDE0", Offset = "0xBDE0", VA = "0xBDE0")]
		public AbstractWorldMovement GetMovementByType(WorldMovementTypes type)
		{
			return null;
		}

		// Token: 0x06007413 RID: 29715 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007413")]
		[Address(RVA = "0xBDE1", Offset = "0xBDE1", VA = "0xBDE1")]
		private AbstractWorldMovement GetInstantMovementByType(WorldMovementTypes type)
		{
			return null;
		}

		// Token: 0x06007414 RID: 29716 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007414")]
		[Address(RVA = "0xBDE2", Offset = "0xBDE2", VA = "0xBDE2")]
		private AbstractWorldMovement GetDefaultMovementByType(WorldMovementTypes type)
		{
			return null;
		}

		// Token: 0x04003CCF RID: 15567
		[Token(Token = "0x4003CCF")]
		[FieldOffset(Offset = "0x8")]
		private readonly IUserSettings _userSettings;
	}
}
