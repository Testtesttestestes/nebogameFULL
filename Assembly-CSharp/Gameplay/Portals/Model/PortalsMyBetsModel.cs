using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Gameplay;
using Gameplay.Portals.View.MyBetsTab;
using Gameplay.Portals.View.TotalizatorTab;
using Gameplay.Rating.Model;
using Google.Protobuf.Collections;
using Il2CppDummyDll;
using Protocol.Portal;

namespace Gameplay.Portals.Model
{
	// Token: 0x020005D0 RID: 1488
	[Token(Token = "0x20005D0")]
	public class PortalsMyBetsModel : RatingModel
	{
		// Token: 0x170006BA RID: 1722
		// (get) Token: 0x060023C9 RID: 9161 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060023CA RID: 9162 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006BA")]
		public RepeatedField<BetHistoryRow> History
		{
			[Token(Token = "0x60023C9")]
			[Address(RVA = "0x751B", Offset = "0x751B", VA = "0x751B")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60023CA")]
			[Address(RVA = "0x751C", Offset = "0x751C", VA = "0x751C")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006BB RID: 1723
		// (get) Token: 0x060023CB RID: 9163 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060023CC RID: 9164 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006BB")]
		public StageInPortalsMyBetsListElement.StageInPortalsMyBetsListElementArgs[] HistoryCache
		{
			[Token(Token = "0x60023CB")]
			[Address(RVA = "0x751D", Offset = "0x751D", VA = "0x751D")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60023CC")]
			[Address(RVA = "0x751E", Offset = "0x751E", VA = "0x751E")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170006BC RID: 1724
		// (get) Token: 0x060023CD RID: 9165 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060023CE RID: 9166 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006BC")]
		public UserInPortalTotalizatorListElement.UserInPortalTotalizatorListElementArgs[] UsersCache
		{
			[Token(Token = "0x60023CD")]
			[Address(RVA = "0x751F", Offset = "0x751F", VA = "0x751F")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60023CE")]
			[Address(RVA = "0x7520", Offset = "0x7520", VA = "0x7520")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170006BD RID: 1725
		// (get) Token: 0x060023CF RID: 9167 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060023D0 RID: 9168 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006BD")]
		public BetList CurrentBetList
		{
			[Token(Token = "0x60023CF")]
			[Address(RVA = "0x7521", Offset = "0x7521", VA = "0x7521")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60023D0")]
			[Address(RVA = "0x7522", Offset = "0x7522", VA = "0x7522")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006BE RID: 1726
		// (get) Token: 0x060023D1 RID: 9169 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170006BE")]
		public IGame Game
		{
			[Token(Token = "0x60023D1")]
			[Address(RVA = "0x7523", Offset = "0x7523", VA = "0x7523")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x060023D2 RID: 9170 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023D2")]
		[Address(RVA = "0x7524", Offset = "0x7524", VA = "0x7524")]
		public PortalsMyBetsModel(UserData user, IGame game)
		{
		}

		// Token: 0x060023D3 RID: 9171 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023D3")]
		[Address(RVA = "0x7525", Offset = "0x7525", VA = "0x7525")]
		public void PopulateUsers()
		{
		}

		// Token: 0x060023D4 RID: 9172 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023D4")]
		[Address(RVA = "0x7526", Offset = "0x7526", VA = "0x7526")]
		public void PopulateHistory()
		{
		}

		// Token: 0x060023D5 RID: 9173 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60023D5")]
		[Address(RVA = "0x7527", Offset = "0x7527", VA = "0x7527")]
		private UserInPortalTotalizatorListElement.UserInPortalTotalizatorListElementArgs ConstructArgs(Bet bet)
		{
			return null;
		}
	}
}
