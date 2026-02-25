using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Gameplay;
using Core.Gameplay.Managers;
using Google.Protobuf.Collections;
using Il2CppDummyDll;
using MVC;
using Protocol.Dic;
using Protocol.Main;

namespace Gameplay.Medals.Model
{
	// Token: 0x02000605 RID: 1541
	[Token(Token = "0x2000605")]
	public class MedalsModel : AbstractModel
	{
		// Token: 0x17000707 RID: 1799
		// (get) Token: 0x0600255E RID: 9566 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000707")]
		public Dictionaries Dict
		{
			[Token(Token = "0x600255E")]
			[Address(RVA = "0x76A4", Offset = "0x76A4", VA = "0x76A4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000708 RID: 1800
		// (get) Token: 0x0600255F RID: 9567 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002560 RID: 9568 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000708")]
		public UserData LoggedUser
		{
			[Token(Token = "0x600255F")]
			[Address(RVA = "0x76A5", Offset = "0x76A5", VA = "0x76A5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002560")]
			[Address(RVA = "0x76A6", Offset = "0x76A6", VA = "0x76A6")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000709 RID: 1801
		// (get) Token: 0x06002561 RID: 9569 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002562 RID: 9570 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000709")]
		public MedalDicGroupStorage MedalDicGroupStorage
		{
			[Token(Token = "0x6002561")]
			[Address(RVA = "0x76A7", Offset = "0x76A7", VA = "0x76A7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002562")]
			[Address(RVA = "0x76A8", Offset = "0x76A8", VA = "0x76A8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700070A RID: 1802
		// (get) Token: 0x06002563 RID: 9571 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002564 RID: 9572 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700070A")]
		public Dictionary<uint, Dictionary<uint, List<MedalData>>> VisibleMedals
		{
			[Token(Token = "0x6002563")]
			[Address(RVA = "0x76A9", Offset = "0x76A9", VA = "0x76A9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002564")]
			[Address(RVA = "0x76AA", Offset = "0x76AA", VA = "0x76AA")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700070B RID: 1803
		// (get) Token: 0x06002565 RID: 9573 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002566 RID: 9574 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700070B")]
		public Dictionary<uint, List<MedalData>> AllVisibleMedalsByCategoryId
		{
			[Token(Token = "0x6002565")]
			[Address(RVA = "0x76AB", Offset = "0x76AB", VA = "0x76AB")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002566")]
			[Address(RVA = "0x76AC", Offset = "0x76AC", VA = "0x76AC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700070C RID: 1804
		// (get) Token: 0x06002567 RID: 9575 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002568 RID: 9576 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700070C")]
		public Dictionary<uint, MedalData> MedalDataByMedalId
		{
			[Token(Token = "0x6002567")]
			[Address(RVA = "0x76AD", Offset = "0x76AD", VA = "0x76AD")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002568")]
			[Address(RVA = "0x76AE", Offset = "0x76AE", VA = "0x76AE")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700070D RID: 1805
		// (get) Token: 0x06002569 RID: 9577 RVA: 0x00007218 File Offset: 0x00005418
		// (set) Token: 0x0600256A RID: 9578 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700070D")]
		public int BuyProcessCount
		{
			[Token(Token = "0x6002569")]
			[Address(RVA = "0x76AF", Offset = "0x76AF", VA = "0x76AF")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x600256A")]
			[Address(RVA = "0x76B0", Offset = "0x76B0", VA = "0x76B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700070E RID: 1806
		// (get) Token: 0x0600256B RID: 9579 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600256C RID: 9580 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700070E")]
		public IGame Game
		{
			[Token(Token = "0x600256B")]
			[Address(RVA = "0x76B1", Offset = "0x76B1", VA = "0x76B1")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600256C")]
			[Address(RVA = "0x76B2", Offset = "0x76B2", VA = "0x76B2")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600256D RID: 9581 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600256D")]
		[Address(RVA = "0x76B3", Offset = "0x76B3", VA = "0x76B3", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x0600256E RID: 9582 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600256E")]
		[Address(RVA = "0x76B4", Offset = "0x76B4", VA = "0x76B4")]
		public MedalsModel(IGame game, UserData user, UserData loggedUser, MedalDicGroupStorage medalDicGroupStorage)
		{
		}

		// Token: 0x0600256F RID: 9583 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600256F")]
		[Address(RVA = "0x76B5", Offset = "0x76B5", VA = "0x76B5")]
		public void SetMedals(RepeatedField<MedalInfo> medalInfos)
		{
		}

		// Token: 0x06002570 RID: 9584 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002570")]
		[Address(RVA = "0x76B6", Offset = "0x76B6", VA = "0x76B6")]
		public void RemoveMedal(uint medalId)
		{
		}

		// Token: 0x06002571 RID: 9585 RVA: 0x00007230 File Offset: 0x00005430
		[Token(Token = "0x6002571")]
		[Address(RVA = "0x1C19", Offset = "0x1C19", VA = "0x1C19")]
		public bool AddMedal(MedalInfo mi)
		{
			return default(bool);
		}

		// Token: 0x04001477 RID: 5239
		[Token(Token = "0x4001477")]
		[FieldOffset(Offset = "0xC")]
		private readonly DictManager _dictManager;
	}
}
