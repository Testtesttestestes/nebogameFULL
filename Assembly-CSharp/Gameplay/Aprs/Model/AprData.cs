using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Dict;
using Core.Dict.DictWrappers.Wrappers;
using Gameplay.Discounts.Model;
using Il2CppDummyDll;
using JetBrains.Annotations;
using Protocol.Dic;
using Protocol.Main;
using Utils;

namespace Gameplay.Aprs.Model
{
	// Token: 0x02000D60 RID: 3424
	[Token(Token = "0x2000D60")]
	public class AprData : IAprDataDiscountProvider
	{
		// Token: 0x14000200 RID: 512
		// (add) Token: 0x060053D5 RID: 21461 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060053D6 RID: 21462 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000200")]
		public event AprData.CurrentMedalChanged CurrentMedalChangedEvent
		{
			[Token(Token = "0x60053D5")]
			[Address(RVA = "0xA191", Offset = "0xA191", VA = "0xA191")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60053D6")]
			[Address(RVA = "0xA192", Offset = "0xA192", VA = "0xA192")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17001107 RID: 4359
		// (get) Token: 0x060053D7 RID: 21463 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060053D8 RID: 21464 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001107")]
		public AprDicGroup AprDicGroup
		{
			[Token(Token = "0x60053D7")]
			[Address(RVA = "0xA193", Offset = "0xA193", VA = "0xA193")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60053D8")]
			[Address(RVA = "0xA194", Offset = "0xA194", VA = "0xA194")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001108 RID: 4360
		// (get) Token: 0x060053D9 RID: 21465 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060053DA RID: 21466 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001108")]
		public MedalDicWrapper CurrentMedal
		{
			[Token(Token = "0x60053D9")]
			[Address(RVA = "0xA195", Offset = "0xA195", VA = "0xA195")]
			get
			{
				return null;
			}
			[Token(Token = "0x60053DA")]
			[Address(RVA = "0xA196", Offset = "0xA196", VA = "0xA196")]
			private set
			{
			}
		}

		// Token: 0x17001109 RID: 4361
		// (get) Token: 0x060053DB RID: 21467 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060053DC RID: 21468 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001109")]
		public AprDicWrapper CurrentApr
		{
			[Token(Token = "0x60053DB")]
			[Address(RVA = "0xA197", Offset = "0xA197", VA = "0xA197")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60053DC")]
			[Address(RVA = "0xA198", Offset = "0xA198", VA = "0xA198")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700110A RID: 4362
		// (get) Token: 0x060053DD RID: 21469 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700110A")]
		public UserData LoggedUser
		{
			[Token(Token = "0x60053DD")]
			[Address(RVA = "0xA199", Offset = "0xA199", VA = "0xA199")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x1700110B RID: 4363
		// (get) Token: 0x060053DE RID: 21470 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700110B")]
		public UserData User
		{
			[Token(Token = "0x60053DE")]
			[Address(RVA = "0xA19A", Offset = "0xA19A", VA = "0xA19A")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x1700110C RID: 4364
		// (get) Token: 0x060053DF RID: 21471 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700110C")]
		public SortedList<uint, MedalInfo> MedalInfos
		{
			[Token(Token = "0x60053DF")]
			[Address(RVA = "0xA19B", Offset = "0xA19B", VA = "0xA19B")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x1700110D RID: 4365
		// (get) Token: 0x060053E0 RID: 21472 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060053E1 RID: 21473 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700110D")]
		public BackTime Backtime
		{
			[Token(Token = "0x60053E0")]
			[Address(RVA = "0xA19C", Offset = "0xA19C", VA = "0xA19C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60053E1")]
			[Address(RVA = "0xA19D", Offset = "0xA19D", VA = "0xA19D")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700110E RID: 4366
		// (get) Token: 0x060053E2 RID: 21474 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060053E3 RID: 21475 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700110E")]
		[CanBeNull]
		public SaleMarkersDic SaleMarkersDic
		{
			[Token(Token = "0x60053E2")]
			[Address(RVA = "0xA19E", Offset = "0xA19E", VA = "0xA19E")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60053E3")]
			[Address(RVA = "0xA19F", Offset = "0xA19F", VA = "0xA19F")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700110F RID: 4367
		// (get) Token: 0x060053E4 RID: 21476 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700110F")]
		public string Title
		{
			[Token(Token = "0x60053E4")]
			[Address(RVA = "0xA1A0", Offset = "0xA1A0", VA = "0xA1A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001110 RID: 4368
		// (get) Token: 0x060053E5 RID: 21477 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001110")]
		public string FilterTitle
		{
			[Token(Token = "0x60053E5")]
			[Address(RVA = "0xA1A1", Offset = "0xA1A1", VA = "0xA1A1")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001111 RID: 4369
		// (get) Token: 0x060053E6 RID: 21478 RVA: 0x0000F1E0 File Offset: 0x0000D3E0
		[Token(Token = "0x17001111")]
		public uint CurrentCollectionRank
		{
			[Token(Token = "0x60053E6")]
			[Address(RVA = "0xA1A2", Offset = "0xA1A2", VA = "0xA1A2")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x17001112 RID: 4370
		// (get) Token: 0x060053E7 RID: 21479 RVA: 0x0000F1F8 File Offset: 0x0000D3F8
		[Token(Token = "0x17001112")]
		public bool HasDiscount
		{
			[Token(Token = "0x60053E7")]
			[Address(RVA = "0xA1A3", Offset = "0xA1A3", VA = "0xA1A3", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001113 RID: 4371
		// (get) Token: 0x060053E8 RID: 21480 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001113")]
		private AprData AprData
		{
			[Token(Token = "0x60053E8")]
			[Address(RVA = "0xA1A4", Offset = "0xA1A4", VA = "0xA1A4", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x060053E9 RID: 21481 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053E9")]
		[Address(RVA = "0xA1A5", Offset = "0xA1A5", VA = "0xA1A5")]
		private AprData(AprDicGroup aprDicGroup, UserData user, UserData loggedUser)
		{
		}

		// Token: 0x060053EA RID: 21482 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60053EA")]
		[Address(RVA = "0xA1A6", Offset = "0xA1A6", VA = "0xA1A6")]
		private MedalDicWrapper GetCurrentMedal()
		{
			return null;
		}

		// Token: 0x060053EB RID: 21483 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053EB")]
		[Address(RVA = "0x1E53", Offset = "0x1E53", VA = "0x1E53")]
		private void ValidateState(IDictProvider dictionaries)
		{
		}

		// Token: 0x060053EC RID: 21484 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053EC")]
		[Address(RVA = "0x1E43", Offset = "0x1E43", VA = "0x1E43")]
		public void AddMedalInfo(MedalInfo medalInfo, IDictProvider dictionaries)
		{
		}

		// Token: 0x060053ED RID: 21485 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053ED")]
		[Address(RVA = "0xA1A7", Offset = "0xA1A7", VA = "0xA1A7")]
		public void RemoveMedalById(uint medalId, IDictProvider dictionaries)
		{
		}

		// Token: 0x060053EE RID: 21486 RVA: 0x0000F210 File Offset: 0x0000D410
		[Token(Token = "0x60053EE")]
		[Address(RVA = "0xA1A8", Offset = "0xA1A8", VA = "0xA1A8")]
		public bool IsAprAchieved()
		{
			return default(bool);
		}

		// Token: 0x060053EF RID: 21487 RVA: 0x0000F228 File Offset: 0x0000D428
		[Token(Token = "0x60053EF")]
		[Address(RVA = "0xA1A9", Offset = "0xA1A9", VA = "0xA1A9")]
		public bool IsAvailToBuy(IEnumerable<MedalInfo> medals)
		{
			return default(bool);
		}

		// Token: 0x060053F0 RID: 21488 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053F0")]
		[Address(RVA = "0xA1AA", Offset = "0xA1AA", VA = "0xA1AA")]
		public void InvalidateUser(IDictProvider dictionaries)
		{
		}

		// Token: 0x060053F1 RID: 21489 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053F1")]
		[Address(RVA = "0x1E51", Offset = "0x1E51", VA = "0x1E51")]
		public void InvalidateSaleMarkerInfo(IDictProvider dictProvider)
		{
		}

		// Token: 0x060053F2 RID: 21490 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60053F2")]
		[Address(RVA = "0x1E3E", Offset = "0x1E3E", VA = "0x1E3E")]
		public static AprData Create(AprDicGroup aprDicGroup, UserData user, UserData loggedUser, IDictProvider dictProvider)
		{
			return null;
		}

		// Token: 0x060053F3 RID: 21491 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60053F3")]
		[Address(RVA = "0xA1AB", Offset = "0xA1AB", VA = "0xA1AB")]
		public static AprDicWrapper GetAppropriateApr(uint medalId, UserData userData, IDictProvider dictionaries)
		{
			return null;
		}

		// Token: 0x060053F4 RID: 21492 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60053F4")]
		[Address(RVA = "0xA1AC", Offset = "0xA1AC", VA = "0xA1AC")]
		public static AprDicWrapper GetAppropriateApr(MedalDic medalDic, UserData userData, IDictProvider dictionaries)
		{
			return null;
		}

		// Token: 0x060053F5 RID: 21493 RVA: 0x0000F240 File Offset: 0x0000D440
		[Token(Token = "0x60053F5")]
		[Address(RVA = "0xA1AD", Offset = "0xA1AD", VA = "0xA1AD")]
		public static bool IsAppropriateApr(AprDic aprDic, UserData user)
		{
			return default(bool);
		}

		// Token: 0x04002D74 RID: 11636
		[Token(Token = "0x4002D74")]
		[FieldOffset(Offset = "0xC")]
		private string _filterTitle;

		// Token: 0x04002D75 RID: 11637
		[Token(Token = "0x4002D75")]
		[FieldOffset(Offset = "0x10")]
		private uint _currentCollectionRank;

		// Token: 0x04002D76 RID: 11638
		[Token(Token = "0x4002D76")]
		[FieldOffset(Offset = "0x14")]
		private MedalDicWrapper _currentMedal;

		// Token: 0x02000D61 RID: 3425
		// (Invoke) Token: 0x060053F9 RID: 21497
		[Token(Token = "0x2000D61")]
		public delegate void CurrentMedalChanged(MedalDicWrapper from, MedalDicWrapper to);
	}
}
