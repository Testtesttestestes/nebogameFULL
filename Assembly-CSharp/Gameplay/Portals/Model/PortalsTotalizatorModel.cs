using System;
using System.Runtime.CompilerServices;
using Core.Cache.User;
using Core.Data;
using Core.Gameplay;
using Gameplay.Portals.View.TotalizatorTab;
using Il2CppDummyDll;
using Protocol.Common;
using Protocol.Portal;

namespace Gameplay.Portals.Model
{
	// Token: 0x020005D6 RID: 1494
	[Token(Token = "0x20005D6")]
	public class PortalsTotalizatorModel : PortalsRatingModel
	{
		// Token: 0x170006C7 RID: 1735
		// (get) Token: 0x060023F2 RID: 9202 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060023F3 RID: 9203 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006C7")]
		public BetList CurrentBetList
		{
			[Token(Token = "0x60023F2")]
			[Address(RVA = "0x7543", Offset = "0x7543", VA = "0x7543")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60023F3")]
			[Address(RVA = "0x7544", Offset = "0x7544", VA = "0x7544")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060023F4 RID: 9204 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023F4")]
		[Address(RVA = "0x7545", Offset = "0x7545", VA = "0x7545")]
		public PortalsTotalizatorModel(UserData user, IGame game, IUserCache userCache)
		{
		}

		// Token: 0x170006C8 RID: 1736
		// (get) Token: 0x060023F5 RID: 9205 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060023F6 RID: 9206 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006C8")]
		public UserInPortalTotalizatorListElement.UserInPortalTotalizatorListElementArgs[] UsersCache
		{
			[Token(Token = "0x60023F5")]
			[Address(RVA = "0x7546", Offset = "0x7546", VA = "0x7546")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60023F6")]
			[Address(RVA = "0x7547", Offset = "0x7547", VA = "0x7547")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170006C9 RID: 1737
		// (get) Token: 0x060023F7 RID: 9207 RVA: 0x00006FD8 File Offset: 0x000051D8
		// (set) Token: 0x060023F8 RID: 9208 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006C9")]
		public ulong CurrentBetId
		{
			[Token(Token = "0x60023F7")]
			[Address(RVA = "0x7548", Offset = "0x7548", VA = "0x7548")]
			[CompilerGenerated]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x60023F8")]
			[Address(RVA = "0x7549", Offset = "0x7549", VA = "0x7549")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006CA RID: 1738
		// (get) Token: 0x060023F9 RID: 9209 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060023FA RID: 9210 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006CA")]
		public ResourceSet AcceptPrice
		{
			[Token(Token = "0x60023F9")]
			[Address(RVA = "0x754A", Offset = "0x754A", VA = "0x754A")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60023FA")]
			[Address(RVA = "0x754B", Offset = "0x754B", VA = "0x754B")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006CB RID: 1739
		// (get) Token: 0x060023FB RID: 9211 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060023FC RID: 9212 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006CB")]
		public ResourceSet UpdatePrice
		{
			[Token(Token = "0x60023FB")]
			[Address(RVA = "0x754C", Offset = "0x754C", VA = "0x754C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60023FC")]
			[Address(RVA = "0x754D", Offset = "0x754D", VA = "0x754D")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060023FD RID: 9213 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023FD")]
		[Address(RVA = "0x754E", Offset = "0x754E", VA = "0x754E")]
		public void PopulateUsers()
		{
		}

		// Token: 0x060023FE RID: 9214 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60023FE")]
		[Address(RVA = "0x754F", Offset = "0x754F", VA = "0x754F")]
		private UserInPortalTotalizatorListElement.UserInPortalTotalizatorListElementArgs ConstructArgs(Bet bet)
		{
			return null;
		}
	}
}
