using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Dict;
using Core.Gameplay;
using Google.Protobuf.Collections;
using Il2CppDummyDll;
using MVC;
using Protocol.Dic;
using Protocol.Services;
using UnityEngine;

namespace Gameplay.Bank.Model
{
	// Token: 0x02000C53 RID: 3155
	[Token(Token = "0x2000C53")]
	public class BankModel : AbstractModel
	{
		// Token: 0x17000F80 RID: 3968
		// (get) Token: 0x06004CD5 RID: 19669 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004CD6 RID: 19670 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000F80")]
		public List<BankTabData> AvailableBankTabs
		{
			[Token(Token = "0x6004CD5")]
			[Address(RVA = "0x9B12", Offset = "0x9B12", VA = "0x9B12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004CD6")]
			[Address(RVA = "0x9B13", Offset = "0x9B13", VA = "0x9B13")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000F81 RID: 3969
		// (get) Token: 0x06004CD7 RID: 19671 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004CD8 RID: 19672 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000F81")]
		public List<PromotionsDic> ActivePromotions
		{
			[Token(Token = "0x6004CD7")]
			[Address(RVA = "0x9B14", Offset = "0x9B14", VA = "0x9B14")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004CD8")]
			[Address(RVA = "0x9B15", Offset = "0x9B15", VA = "0x9B15")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000F82 RID: 3970
		// (get) Token: 0x06004CD9 RID: 19673 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000F82")]
		public IOptionValidator OptionValidator
		{
			[Token(Token = "0x6004CD9")]
			[Address(RVA = "0x9B16", Offset = "0x9B16", VA = "0x9B16")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000F83 RID: 3971
		// (get) Token: 0x06004CDA RID: 19674 RVA: 0x0000E118 File Offset: 0x0000C318
		// (set) Token: 0x06004CDB RID: 19675 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000F83")]
		public Vector2 LastPosition
		{
			[Token(Token = "0x6004CDA")]
			[Address(RVA = "0x9B17", Offset = "0x9B17", VA = "0x9B17")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6004CDB")]
			[Address(RVA = "0x9B18", Offset = "0x9B18", VA = "0x9B18")]
			set
			{
			}
		}

		// Token: 0x17000F84 RID: 3972
		// (get) Token: 0x06004CDC RID: 19676 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004CDD RID: 19677 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000F84")]
		public IGame Game
		{
			[Token(Token = "0x6004CDC")]
			[Address(RVA = "0x9B19", Offset = "0x9B19", VA = "0x9B19")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004CDD")]
			[Address(RVA = "0x9B1A", Offset = "0x9B1A", VA = "0x9B1A")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000F85 RID: 3973
		// (get) Token: 0x06004CDE RID: 19678 RVA: 0x0000E130 File Offset: 0x0000C330
		// (set) Token: 0x06004CDF RID: 19679 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000F85")]
		public int EpNotificationCount
		{
			[Token(Token = "0x6004CDE")]
			[Address(RVA = "0x9B1B", Offset = "0x9B1B", VA = "0x9B1B")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6004CDF")]
			[Address(RVA = "0x9B1C", Offset = "0x9B1C", VA = "0x9B1C")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000F86 RID: 3974
		// (get) Token: 0x06004CE0 RID: 19680 RVA: 0x0000E148 File Offset: 0x0000C348
		// (set) Token: 0x06004CE1 RID: 19681 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000F86")]
		public int LastSelectedTabIndex
		{
			[Token(Token = "0x6004CE0")]
			[Address(RVA = "0x9B1D", Offset = "0x9B1D", VA = "0x9B1D")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6004CE1")]
			[Address(RVA = "0x9B1E", Offset = "0x9B1E", VA = "0x9B1E")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06004CE2 RID: 19682 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004CE2")]
		[Address(RVA = "0x9B1F", Offset = "0x9B1F", VA = "0x9B1F", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x06004CE3 RID: 19683 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004CE3")]
		[Address(RVA = "0x9B20", Offset = "0x9B20", VA = "0x9B20")]
		public BankModel(UserData user, IDictProvider dictProvider, IGame game)
		{
		}

		// Token: 0x06004CE4 RID: 19684 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004CE4")]
		[Address(RVA = "0x9B21", Offset = "0x9B21", VA = "0x9B21")]
		public void ResetScrollPositions()
		{
		}

		// Token: 0x06004CE5 RID: 19685 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004CE5")]
		[Address(RVA = "0x9B22", Offset = "0x9B22", VA = "0x9B22")]
		private void Init()
		{
		}

		// Token: 0x06004CE6 RID: 19686 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004CE6")]
		[Address(RVA = "0x9B23", Offset = "0x9B23", VA = "0x9B23")]
		public List<BankOptionData> GetOptionsByType(OptionTypesDic.Types.OptionType optionType)
		{
			return null;
		}

		// Token: 0x06004CE7 RID: 19687 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004CE7")]
		[Address(RVA = "0x9B24", Offset = "0x9B24", VA = "0x9B24")]
		public void SetOptionRewards(IList<OptionRewards> optionRewards)
		{
		}

		// Token: 0x06004CE8 RID: 19688 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004CE8")]
		[Address(RVA = "0x9B25", Offset = "0x9B25", VA = "0x9B25")]
		public void SetActivePromotions(RepeatedField<uint> promotionsIds)
		{
		}

		// Token: 0x06004CE9 RID: 19689 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004CE9")]
		[Address(RVA = "0x9B26", Offset = "0x9B26", VA = "0x9B26")]
		public void SetOptionArtikuls(uint optionId, ProtoGetOptionArtikulsAns msg)
		{
		}

		// Token: 0x06004CEA RID: 19690 RVA: 0x0000E160 File Offset: 0x0000C360
		[Token(Token = "0x6004CEA")]
		[Address(RVA = "0x1ADC", Offset = "0x1ADC", VA = "0x1ADC")]
		public bool TryGetOption(uint optionId, out BankOptionData result)
		{
			return default(bool);
		}

		// Token: 0x06004CEB RID: 19691 RVA: 0x0000E178 File Offset: 0x0000C378
		[Token(Token = "0x6004CEB")]
		[Address(RVA = "0x9B27", Offset = "0x9B27", VA = "0x9B27")]
		public bool TryGetOption(string optionIdString, out BankOptionData result)
		{
			return default(bool);
		}

		// Token: 0x06004CEC RID: 19692 RVA: 0x0000E190 File Offset: 0x0000C390
		[Token(Token = "0x6004CEC")]
		[Address(RVA = "0x9B28", Offset = "0x9B28", VA = "0x9B28")]
		public bool IsArtikulOptionActive(uint optionId)
		{
			return default(bool);
		}

		// Token: 0x06004CED RID: 19693 RVA: 0x0000E1A8 File Offset: 0x0000C3A8
		[Token(Token = "0x6004CED")]
		[Address(RVA = "0x9B29", Offset = "0x9B29", VA = "0x9B29")]
		public bool AnyBankOption(Func<BankOptionData, bool> predicate)
		{
			return default(bool);
		}

		// Token: 0x040029F9 RID: 10745
		[Token(Token = "0x40029F9")]
		[FieldOffset(Offset = "0xC")]
		public readonly IDictProvider DictProvider;

		// Token: 0x040029FE RID: 10750
		[Token(Token = "0x40029FE")]
		[FieldOffset(Offset = "0x20")]
		private readonly Dictionary<int, Vector2> _tabScrollPositions;

		// Token: 0x040029FF RID: 10751
		[Token(Token = "0x40029FF")]
		[FieldOffset(Offset = "0x24")]
		private readonly Dictionary<uint, BankOptionData> _optionsById;

		// Token: 0x04002A00 RID: 10752
		[Token(Token = "0x4002A00")]
		[FieldOffset(Offset = "0x28")]
		private Dictionary<OptionTypesDic.Types.OptionType, List<BankOptionData>> _optionsByType;
	}
}
