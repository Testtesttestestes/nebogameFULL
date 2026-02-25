using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Data.InfoRows;
using Il2CppDummyDll;
using Protocol.Common;

namespace Core.Gameplay.Managers.Requirements.Custom
{
	// Token: 0x0200119D RID: 4509
	[Token(Token = "0x200119D")]
	public class RequirementsInfoProviderWhitCommonTitle : RequirementsInfoProvider
	{
		// Token: 0x170015DB RID: 5595
		// (get) Token: 0x06006B24 RID: 27428 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006B23 RID: 27427 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170015DB")]
		public string Title
		{
			[Token(Token = "0x6006B24")]
			[Address(RVA = "0xB627", Offset = "0xB627", VA = "0xB627")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006B23")]
			[Address(RVA = "0xB626", Offset = "0xB626", VA = "0xB626")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06006B25 RID: 27429 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B25")]
		[Address(RVA = "0xB628", Offset = "0xB628", VA = "0xB628")]
		public RequirementsInfoProviderWhitCommonTitle(UserData user, UserData loggedUser, IInformationProvider costProvider, IList<RestrictionInfo> restrictionInfos, IList<RewardInfo> materials)
		{
		}

		// Token: 0x06006B26 RID: 27430 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B26")]
		[Address(RVA = "0xB629", Offset = "0xB629", VA = "0xB629")]
		public RequirementsInfoProviderWhitCommonTitle(UserData user, UserData loggedUser, IList<RestrictionInfo> restrictionInfos)
		{
		}

		// Token: 0x06006B27 RID: 27431 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B27")]
		[Address(RVA = "0xB62A", Offset = "0xB62A", VA = "0xB62A")]
		public RequirementsInfoProviderWhitCommonTitle(UserData user, UserData loggedUser, IList<RestrictionInfo> restrictionInfos, IList<RewardInfo> materials)
		{
		}

		// Token: 0x06006B28 RID: 27432 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B28")]
		[Address(RVA = "0xB62B", Offset = "0xB62B", VA = "0xB62B", Slot = "9")]
		protected override void PrepareInformation()
		{
		}
	}
}
