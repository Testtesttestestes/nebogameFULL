using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Data.Balance;
using Gameplay.WorldAxis.Model;
using Il2CppDummyDll;
using MVC;
using Protocol.Colossus;
using Protocol.Dic;

namespace Gameplay.Clans.Office.Model
{
	// Token: 0x02000A54 RID: 2644
	[Token(Token = "0x2000A54")]
	public class SquadModel : AbstractModel
	{
		// Token: 0x17000C8D RID: 3213
		// (get) Token: 0x06003E9F RID: 16031 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C8D")]
		public Dictionaries Dict
		{
			[Token(Token = "0x6003E9F")]
			[Address(RVA = "0x8D5D", Offset = "0x8D5D", VA = "0x8D5D")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C8E RID: 3214
		// (get) Token: 0x06003EA0 RID: 16032 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003EA1 RID: 16033 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C8E")]
		public List<SquadModel.PartyData> Parties
		{
			[Token(Token = "0x6003EA0")]
			[Address(RVA = "0x8D5E", Offset = "0x8D5E", VA = "0x8D5E")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003EA1")]
			[Address(RVA = "0x8D5F", Offset = "0x8D5F", VA = "0x8D5F")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000C8F RID: 3215
		// (get) Token: 0x06003EA2 RID: 16034 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003EA3 RID: 16035 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C8F")]
		public IBalanceSource Treasury
		{
			[Token(Token = "0x6003EA2")]
			[Address(RVA = "0x8D60", Offset = "0x8D60", VA = "0x8D60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003EA3")]
			[Address(RVA = "0x8D61", Offset = "0x8D61", VA = "0x8D61")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06003EA4 RID: 16036 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EA4")]
		[Address(RVA = "0x8D62", Offset = "0x8D62", VA = "0x8D62")]
		public SquadModel(UserData user, ClanInfoModel model, WorldAxisModel worldAxisModel)
		{
		}

		// Token: 0x06003EA5 RID: 16037 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EA5")]
		[Address(RVA = "0x8D63", Offset = "0x8D63", VA = "0x8D63")]
		public void PopulateParties(IList<PartyInfo> parties)
		{
		}

		// Token: 0x06003EA6 RID: 16038 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EA6")]
		[Address(RVA = "0x8D64", Offset = "0x8D64", VA = "0x8D64")]
		public void ParsePartyChanges(IList<PartyInfo> partiesChanged)
		{
		}

		// Token: 0x06003EA7 RID: 16039 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EA7")]
		[Address(RVA = "0x8D65", Offset = "0x8D65", VA = "0x8D65")]
		private void UpdatePlayerParty()
		{
		}

		// Token: 0x0400233E RID: 9022
		[Token(Token = "0x400233E")]
		[FieldOffset(Offset = "0xC")]
		public readonly ClanInfoModel ClanInfoModel;

		// Token: 0x0400233F RID: 9023
		[Token(Token = "0x400233F")]
		[FieldOffset(Offset = "0x10")]
		public readonly WorldAxisModel WorldAxisModel;

		// Token: 0x04002340 RID: 9024
		[Token(Token = "0x4002340")]
		[FieldOffset(Offset = "0x14")]
		public readonly ColossusSlotsInfoDic[] Slots;

		// Token: 0x02000A55 RID: 2645
		[Token(Token = "0x2000A55")]
		public class PartyData
		{
			// Token: 0x17000C90 RID: 3216
			// (get) Token: 0x06003EA9 RID: 16041 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x06003EAA RID: 16042 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000C90")]
			public ColossusPartiesInfoDic PartyInfoDic
			{
				[Token(Token = "0x6003EA9")]
				[Address(RVA = "0x8D67", Offset = "0x8D67", VA = "0x8D67")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6003EAA")]
				[Address(RVA = "0x8D68", Offset = "0x8D68", VA = "0x8D68")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000C91 RID: 3217
			// (get) Token: 0x06003EAB RID: 16043 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x06003EAC RID: 16044 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000C91")]
			public List<SquadModel.ColossusPartySlot> Slots
			{
				[Token(Token = "0x6003EAB")]
				[Address(RVA = "0x8D69", Offset = "0x8D69", VA = "0x8D69")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6003EAC")]
				[Address(RVA = "0x8D6A", Offset = "0x8D6A", VA = "0x8D6A")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000C92 RID: 3218
			// (get) Token: 0x06003EAD RID: 16045 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x06003EAE RID: 16046 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000C92")]
			public PartyInfo PartyInfo
			{
				[Token(Token = "0x6003EAD")]
				[Address(RVA = "0x8D6B", Offset = "0x8D6B", VA = "0x8D6B")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6003EAE")]
				[Address(RVA = "0x8D6C", Offset = "0x8D6C", VA = "0x8D6C")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x06003EAF RID: 16047 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6003EAF")]
			[Address(RVA = "0x1C84", Offset = "0x1C84", VA = "0x1C84")]
			public static SquadModel.PartyData Create(PartyInfo info, Dictionaries dict, UserData user)
			{
				return null;
			}

			// Token: 0x06003EB0 RID: 16048 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003EB0")]
			[Address(RVA = "0x8D6D", Offset = "0x8D6D", VA = "0x8D6D")]
			public PartyData()
			{
			}
		}

		// Token: 0x02000A57 RID: 2647
		[Token(Token = "0x2000A57")]
		public class ColossusPartySlot
		{
			// Token: 0x17000C93 RID: 3219
			// (get) Token: 0x06003EB3 RID: 16051 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x06003EB4 RID: 16052 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000C93")]
			public DollsInfoDic DollDic
			{
				[Token(Token = "0x6003EB3")]
				[Address(RVA = "0x8D70", Offset = "0x8D70", VA = "0x8D70")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6003EB4")]
				[Address(RVA = "0x8D71", Offset = "0x8D71", VA = "0x8D71")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000C94 RID: 3220
			// (get) Token: 0x06003EB5 RID: 16053 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x06003EB6 RID: 16054 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000C94")]
			public UserData DollUser
			{
				[Token(Token = "0x6003EB5")]
				[Address(RVA = "0x8D72", Offset = "0x8D72", VA = "0x8D72")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6003EB6")]
				[Address(RVA = "0x8D73", Offset = "0x8D73", VA = "0x8D73")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000C95 RID: 3221
			// (get) Token: 0x06003EB7 RID: 16055 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x06003EB8 RID: 16056 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000C95")]
			public PartySlot PartySlot
			{
				[Token(Token = "0x6003EB7")]
				[Address(RVA = "0x8D74", Offset = "0x8D74", VA = "0x8D74")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6003EB8")]
				[Address(RVA = "0x8D75", Offset = "0x8D75", VA = "0x8D75")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000C96 RID: 3222
			// (get) Token: 0x06003EB9 RID: 16057 RVA: 0x0000C570 File Offset: 0x0000A770
			// (set) Token: 0x06003EBA RID: 16058 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000C96")]
			public bool MyDoll
			{
				[Token(Token = "0x6003EB9")]
				[Address(RVA = "0x8D76", Offset = "0x8D76", VA = "0x8D76")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6003EBA")]
				[Address(RVA = "0x8D77", Offset = "0x8D77", VA = "0x8D77")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x06003EBB RID: 16059 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6003EBB")]
			[Address(RVA = "0x1C85", Offset = "0x1C85", VA = "0x1C85")]
			public static SquadModel.ColossusPartySlot Create(PartySlot slot, Dictionaries dict, UserData user)
			{
				return null;
			}

			// Token: 0x06003EBC RID: 16060 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003EBC")]
			[Address(RVA = "0x8D78", Offset = "0x8D78", VA = "0x8D78")]
			public ColossusPartySlot()
			{
			}
		}
	}
}
