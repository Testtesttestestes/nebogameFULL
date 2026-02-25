using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Gameplay.Isles.User;
using Il2CppDummyDll;

namespace UI.Windows.Buildings.MageSchoolWindow
{
	// Token: 0x020002BD RID: 701
	[Token(Token = "0x20002BD")]
	public class SchoolWindowArgs : BaseBuildingWindowArgs
	{
		// Token: 0x1700026D RID: 621
		// (get) Token: 0x06001086 RID: 4230 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001087 RID: 4231 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700026D")]
		public UserData LoggedUser
		{
			[Token(Token = "0x6001086")]
			[Address(RVA = "0x6283", Offset = "0x6283", VA = "0x6283")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001087")]
			[Address(RVA = "0x6284", Offset = "0x6284", VA = "0x6284")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06001088 RID: 4232 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001088")]
		[Address(RVA = "0x6285", Offset = "0x6285", VA = "0x6285")]
		public SchoolWindowArgs(UserIsle isle, uint buildingTypeId, UserData loggedUser)
		{
		}
	}
}
