using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data.Accounts;
using Core.Data.Balance;
using Core.Dict;
using Core.Dict.DictWrappers.Wrappers;
using Gameplay.World.Model;
using Google.Protobuf.Collections;
using Il2CppDummyDll;
using JetBrains.Annotations;
using Protocol.Common;
using Protocol.Dic;
using Protocol.Main;
using Utils.Accumulators;

namespace Core.Data
{
	// Token: 0x020010C3 RID: 4291
	[Token(Token = "0x20010C3")]
	public class UserData : UserData.IManagedUserData, IBalanceSource
	{
		// Token: 0x14000238 RID: 568
		// (add) Token: 0x06006444 RID: 25668 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006445 RID: 25669 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000238")]
		public event Action OnUserInfoChangedEvent
		{
			[Token(Token = "0x6006444")]
			[Address(RVA = "0xB036", Offset = "0xB036", VA = "0xB036")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006445")]
			[Address(RVA = "0xB037", Offset = "0xB037", VA = "0xB037")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000239 RID: 569
		// (add) Token: 0x06006446 RID: 25670 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006447 RID: 25671 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000239")]
		public event IBalanceSource.BalanceChangedDelegate BalanceChangedEvent
		{
			[Token(Token = "0x6006446")]
			[Address(RVA = "0xB038", Offset = "0xB038", VA = "0xB038", Slot = "5")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006447")]
			[Address(RVA = "0xB039", Offset = "0xB039", VA = "0xB039", Slot = "6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400023A RID: 570
		// (add) Token: 0x06006448 RID: 25672 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006449 RID: 25673 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400023A")]
		public event Action OnUserNickChangedEvent
		{
			[Token(Token = "0x6006448")]
			[Address(RVA = "0xB03A", Offset = "0xB03A", VA = "0xB03A")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006449")]
			[Address(RVA = "0xB03B", Offset = "0xB03B", VA = "0xB03B")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400023B RID: 571
		// (add) Token: 0x0600644A RID: 25674 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600644B RID: 25675 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400023B")]
		public event Action OnUserExperienceChangedEvent
		{
			[Token(Token = "0x600644A")]
			[Address(RVA = "0xB03C", Offset = "0xB03C", VA = "0xB03C")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600644B")]
			[Address(RVA = "0xB03D", Offset = "0xB03D", VA = "0xB03D")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400023C RID: 572
		// (add) Token: 0x0600644C RID: 25676 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600644D RID: 25677 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400023C")]
		public event Action<uint, uint> OnUserLicenseCountChangedEvent
		{
			[Token(Token = "0x600644C")]
			[Address(RVA = "0xB03E", Offset = "0xB03E", VA = "0xB03E")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600644D")]
			[Address(RVA = "0xB03F", Offset = "0xB03F", VA = "0xB03F")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400023D RID: 573
		// (add) Token: 0x0600644E RID: 25678 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600644F RID: 25679 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400023D")]
		public event Action OnUserTreeLevelChangedEvent
		{
			[Token(Token = "0x600644E")]
			[Address(RVA = "0xB040", Offset = "0xB040", VA = "0xB040")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600644F")]
			[Address(RVA = "0xB041", Offset = "0xB041", VA = "0xB041")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400023E RID: 574
		// (add) Token: 0x06006450 RID: 25680 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006451 RID: 25681 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400023E")]
		public event Action UserSkillsChangedEvent
		{
			[Token(Token = "0x6006450")]
			[Address(RVA = "0xB042", Offset = "0xB042", VA = "0xB042")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006451")]
			[Address(RVA = "0xB043", Offset = "0xB043", VA = "0xB043")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400023F RID: 575
		// (add) Token: 0x06006452 RID: 25682 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006453 RID: 25683 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400023F")]
		public event Action OnUserLevelChangedEvent
		{
			[Token(Token = "0x6006452")]
			[Address(RVA = "0xB044", Offset = "0xB044", VA = "0xB044")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006453")]
			[Address(RVA = "0xB045", Offset = "0xB045", VA = "0xB045")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000240 RID: 576
		// (add) Token: 0x06006454 RID: 25684 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006455 RID: 25685 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000240")]
		public event Action<AprDicWrapper> OnUserAprChangedEvent
		{
			[Token(Token = "0x6006454")]
			[Address(RVA = "0xB046", Offset = "0xB046", VA = "0xB046")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006455")]
			[Address(RVA = "0xB047", Offset = "0xB047", VA = "0xB047")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000241 RID: 577
		// (add) Token: 0x06006456 RID: 25686 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006457 RID: 25687 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000241")]
		public event Action<CultDic> OnUserCultChangedEvent
		{
			[Token(Token = "0x6006456")]
			[Address(RVA = "0xB048", Offset = "0xB048", VA = "0xB048")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006457")]
			[Address(RVA = "0xB049", Offset = "0xB049", VA = "0xB049")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000242 RID: 578
		// (add) Token: 0x06006458 RID: 25688 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006459 RID: 25689 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000242")]
		public event Action OnUserGenderChangedEvent
		{
			[Token(Token = "0x6006458")]
			[Address(RVA = "0xB04A", Offset = "0xB04A", VA = "0xB04A")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006459")]
			[Address(RVA = "0xB04B", Offset = "0xB04B", VA = "0xB04B")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17001432 RID: 5170
		// (get) Token: 0x0600645A RID: 25690 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001432")]
		public TriggersAccumulator Triggers
		{
			[Token(Token = "0x600645A")]
			[Address(RVA = "0x1BCA", Offset = "0x1BCA", VA = "0x1BCA")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001433 RID: 5171
		// (get) Token: 0x0600645B RID: 25691 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600645C RID: 25692 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001433")]
		public RepeatedField<MedalInfo> Medals
		{
			[Token(Token = "0x600645B")]
			[Address(RVA = "0xB04C", Offset = "0xB04C", VA = "0xB04C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600645C")]
			[Address(RVA = "0xB04D", Offset = "0xB04D", VA = "0xB04D")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17001434 RID: 5172
		// (get) Token: 0x0600645D RID: 25693 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001434")]
		public UserSkillsData SkillsData
		{
			[Token(Token = "0x600645D")]
			[Address(RVA = "0xB04E", Offset = "0xB04E", VA = "0xB04E")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x0600645E RID: 25694 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600645E")]
		[Address(RVA = "0xB04F", Offset = "0xB04F", VA = "0xB04F")]
		public void SetRawUserSkills(ProtoSkillsChangedEvt value)
		{
		}

		// Token: 0x17001435 RID: 5173
		// (get) Token: 0x0600645F RID: 25695 RVA: 0x00013098 File Offset: 0x00011298
		// (set) Token: 0x06006460 RID: 25696 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001435")]
		public bool HideMedals
		{
			[Token(Token = "0x600645F")]
			[Address(RVA = "0xB050", Offset = "0xB050", VA = "0xB050")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6006460")]
			[Address(RVA = "0xB051", Offset = "0xB051", VA = "0xB051")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17001436 RID: 5174
		// (get) Token: 0x06006461 RID: 25697 RVA: 0x000130B0 File Offset: 0x000112B0
		// (set) Token: 0x06006462 RID: 25698 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001436")]
		public bool HideAprs
		{
			[Token(Token = "0x6006461")]
			[Address(RVA = "0xB052", Offset = "0xB052", VA = "0xB052")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6006462")]
			[Address(RVA = "0xB053", Offset = "0xB053", VA = "0xB053")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17001437 RID: 5175
		// (get) Token: 0x06006463 RID: 25699 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001437")]
		public CultDic CultDic
		{
			[Token(Token = "0x6006463")]
			[Address(RVA = "0xB054", Offset = "0xB054", VA = "0xB054")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001438 RID: 5176
		// (get) Token: 0x06006464 RID: 25700 RVA: 0x000130C8 File Offset: 0x000112C8
		// (set) Token: 0x06006465 RID: 25701 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001438")]
		public uint Gender
		{
			[Token(Token = "0x6006464")]
			[Address(RVA = "0x1E34", Offset = "0x1E34", VA = "0x1E34")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6006465")]
			[Address(RVA = "0xB055", Offset = "0xB055", VA = "0xB055")]
			set
			{
			}
		}

		// Token: 0x17001439 RID: 5177
		// (get) Token: 0x06006466 RID: 25702 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006467 RID: 25703 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001439")]
		public AprDicWrapper Apr
		{
			[Token(Token = "0x6006466")]
			[Address(RVA = "0xB056", Offset = "0xB056", VA = "0xB056")]
			get
			{
				return null;
			}
			[Token(Token = "0x6006467")]
			[Address(RVA = "0xB057", Offset = "0xB057", VA = "0xB057")]
			set
			{
			}
		}

		// Token: 0x1700143A RID: 5178
		// (get) Token: 0x06006468 RID: 25704 RVA: 0x000130E0 File Offset: 0x000112E0
		// (set) Token: 0x06006469 RID: 25705 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700143A")]
		public ulong Experience
		{
			[Token(Token = "0x6006468")]
			[Address(RVA = "0xB058", Offset = "0xB058", VA = "0xB058")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6006469")]
			[Address(RVA = "0xB059", Offset = "0xB059", VA = "0xB059")]
			set
			{
			}
		}

		// Token: 0x1700143B RID: 5179
		// (get) Token: 0x0600646A RID: 25706 RVA: 0x000130F8 File Offset: 0x000112F8
		// (set) Token: 0x0600646B RID: 25707 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700143B")]
		public uint LicenseCount
		{
			[Token(Token = "0x600646A")]
			[Address(RVA = "0xB05A", Offset = "0xB05A", VA = "0xB05A")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x600646B")]
			[Address(RVA = "0xB05B", Offset = "0xB05B", VA = "0xB05B")]
			set
			{
			}
		}

		// Token: 0x1700143C RID: 5180
		// (get) Token: 0x0600646C RID: 25708 RVA: 0x00013110 File Offset: 0x00011310
		// (set) Token: 0x0600646D RID: 25709 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700143C")]
		public uint TreeLevel
		{
			[Token(Token = "0x600646C")]
			[Address(RVA = "0xB05C", Offset = "0xB05C", VA = "0xB05C")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x600646D")]
			[Address(RVA = "0xB05D", Offset = "0xB05D", VA = "0xB05D")]
			set
			{
			}
		}

		// Token: 0x1700143D RID: 5181
		// (get) Token: 0x0600646E RID: 25710 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600646F RID: 25711 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700143D")]
		[CanBeNull]
		public ClanData ClanData
		{
			[Token(Token = "0x600646E")]
			[Address(RVA = "0xB05E", Offset = "0xB05E", VA = "0xB05E")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600646F")]
			[Address(RVA = "0xB05F", Offset = "0xB05F", VA = "0xB05F")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06006470 RID: 25712 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006470")]
		[Address(RVA = "0xB060", Offset = "0xB060", VA = "0xB060")]
		private UserData(UserInfo userInfo)
		{
		/* --- GHIDRA: .ctor ---
		undefined8 Core_Data_UserData___ctor(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(*(int *)(param1 + 0x34) + 0x40);
		  if (iVar1 != 0) {
		    return *(undefined8 *)(iVar1 + 0x10);
		  }
		  return 0;
		}
		*/

		}

		// Token: 0x1700143E RID: 5182
		// (get) Token: 0x06006471 RID: 25713 RVA: 0x00013128 File Offset: 0x00011328
		[Token(Token = "0x1700143E")]
		public ulong UserId
		{
			[Token(Token = "0x6006471")]
			[Address(RVA = "0x1B1E", Offset = "0x1B1E", VA = "0x1B1E")]
			get
			{
				return 0UL;
			}
		}

		// Token: 0x1700143F RID: 5183
		// (get) Token: 0x06006472 RID: 25714 RVA: 0x00013140 File Offset: 0x00011340
		[Token(Token = "0x1700143F")]
		public uint CultId
		{
			[Token(Token = "0x6006472")]
			[Address(RVA = "0x1B36", Offset = "0x1B36", VA = "0x1B36")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x17001440 RID: 5184
		// (get) Token: 0x06006473 RID: 25715 RVA: 0x00013158 File Offset: 0x00011358
		[Token(Token = "0x17001440")]
		public ulong ClanId
		{
			[Token(Token = "0x6006473")]
			[Address(RVA = "0xB061", Offset = "0xB061", VA = "0xB061")]
			get
			{
				return 0UL;
			}
		}

		// Token: 0x17001441 RID: 5185
		// (get) Token: 0x06006474 RID: 25716 RVA: 0x00013170 File Offset: 0x00011370
		[Token(Token = "0x17001441")]
		public bool IsClanHead
		{
			[Token(Token = "0x6006474")]
			[Address(RVA = "0xB062", Offset = "0xB062", VA = "0xB062")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001442 RID: 5186
		// (get) Token: 0x06006475 RID: 25717 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006476 RID: 25718 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001442")]
		public string Nick
		{
			[Token(Token = "0x6006475")]
			[Address(RVA = "0x1B6B", Offset = "0x1B6B", VA = "0x1B6B")]
			get
			{
				return null;
			}
			[Token(Token = "0x6006476")]
			[Address(RVA = "0xB063", Offset = "0xB063", VA = "0xB063")]
			set
			{
			}
		}

		// Token: 0x17001443 RID: 5187
		// (get) Token: 0x06006477 RID: 25719 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006478 RID: 25720 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001443")]
		public UserLevelDic LevelDic
		{
			[Token(Token = "0x6006477")]
			[Address(RVA = "0xB064", Offset = "0xB064", VA = "0xB064")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006478")]
			[Address(RVA = "0xB065", Offset = "0xB065", VA = "0xB065")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17001444 RID: 5188
		// (get) Token: 0x06006479 RID: 25721 RVA: 0x00013188 File Offset: 0x00011388
		// (set) Token: 0x0600647A RID: 25722 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001444")]
		public uint Level
		{
			[Token(Token = "0x6006479")]
			[Address(RVA = "0xB066", Offset = "0xB066", VA = "0xB066")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x600647A")]
			[Address(RVA = "0xB067", Offset = "0xB067", VA = "0xB067")]
			set
			{
			}
		}

		// Token: 0x17001445 RID: 5189
		// (get) Token: 0x0600647B RID: 25723 RVA: 0x000131A0 File Offset: 0x000113A0
		[Token(Token = "0x17001445")]
		public uint RankId
		{
			[Token(Token = "0x600647B")]
			[Address(RVA = "0xB068", Offset = "0xB068", VA = "0xB068")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x17001446 RID: 5190
		// (get) Token: 0x0600647C RID: 25724 RVA: 0x000131B8 File Offset: 0x000113B8
		// (set) Token: 0x0600647D RID: 25725 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001446")]
		public int PremiumExpMinLevel
		{
			[Token(Token = "0x600647C")]
			[Address(RVA = "0xB069", Offset = "0xB069", VA = "0xB069")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x600647D")]
			[Address(RVA = "0xB06A", Offset = "0xB06A", VA = "0xB06A")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600647E RID: 25726 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600647E")]
		[Address(RVA = "0xB06B", Offset = "0xB06B", VA = "0xB06B")]
		private void HandleChangeLevel(uint from, uint to)
		{
		}

		// Token: 0x17001447 RID: 5191
		// (get) Token: 0x0600647F RID: 25727 RVA: 0x000131D0 File Offset: 0x000113D0
		// (set) Token: 0x06006480 RID: 25728 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001447")]
		public bool IsPremiumExp
		{
			[Token(Token = "0x600647F")]
			[Address(RVA = "0xB06C", Offset = "0xB06C", VA = "0xB06C")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6006480")]
			[Address(RVA = "0xB06D", Offset = "0xB06D", VA = "0xB06D")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17001448 RID: 5192
		// (get) Token: 0x06006481 RID: 25729 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001448")]
		public UserInfo UserInfo
		{
			[Token(Token = "0x6006481")]
			[Address(RVA = "0xB06E", Offset = "0xB06E", VA = "0xB06E")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006482 RID: 25730 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006482")]
		[Address(RVA = "0xB06F", Offset = "0xB06F", VA = "0xB06F")]
		public void SetCult(CultDic value)
		{
		/* --- GHIDRA: SetCult ---
		void Core_Data_UserData__SetCult(int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  uint uVar2;
		  uint uVar3;
		  
		  iVar1 = *(int *)(param1 + 0x34);
		  *(int *)(param1 + 0x34) = param2;
		  if ((((param2 != 0) && (iVar1 != 0)) &&
		      (uVar2 = *(uint *)(iVar1 + 0x20), uVar3 = *(uint *)(param2 + 0x20),
		      *(bool *)(param1 + 0x74) = (longlong)*(int *)(param1 + 0x70) <= (longlong)(ulonglong)uVar3,
		      uVar3 != uVar2)) && (iVar1 = *(int *)(param1 + 0x24), iVar1 != 0)) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06006483 RID: 25731 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006483")]
		[Address(RVA = "0xB070", Offset = "0xB070", VA = "0xB070", Slot = "4")]
		private void SetUserInfo(UserInfo value)
		{
		}

		// Token: 0x17001449 RID: 5193
		// (get) Token: 0x06006484 RID: 25732 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006485 RID: 25733 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001449")]
		public ResourceSet Money
		{
			[Token(Token = "0x6006484")]
			[Address(RVA = "0xB071", Offset = "0xB071", VA = "0xB071", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x6006485")]
			[Address(RVA = "0xB072", Offset = "0xB072", VA = "0xB072")]
			set
			{
			}
		}

		// Token: 0x1700144A RID: 5194
		// (get) Token: 0x06006486 RID: 25734 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700144A")]
		public AccountsStorage Accounts
		{
			[Token(Token = "0x6006486")]
			[Address(RVA = "0x1D51", Offset = "0x1D51", VA = "0x1D51")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700144B RID: 5195
		// (get) Token: 0x06006487 RID: 25735 RVA: 0x000131E8 File Offset: 0x000113E8
		[Token(Token = "0x1700144B")]
		public bool IsSigninConfirmed
		{
			[Token(Token = "0x6006487")]
			[Address(RVA = "0xB073", Offset = "0xB073", VA = "0xB073")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06006488 RID: 25736 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006488")]
		[Address(RVA = "0xB074", Offset = "0xB074", VA = "0xB074")]
		public static UserData Create(UserInfo userInfo, IDictProvider dict)
		{
			return null;
		}

		// Token: 0x0400358C RID: 13708
		[Token(Token = "0x400358C")]
		public const float TRIGGER_DELAY = 0.1f;

		// Token: 0x04003598 RID: 13720
		[Token(Token = "0x4003598")]
		[FieldOffset(Offset = "0x34")]
		private UserInfo _userInfo;

		// Token: 0x04003599 RID: 13721
		[Token(Token = "0x4003599")]
		[FieldOffset(Offset = "0x38")]
		private AprDicWrapper _apr;

		// Token: 0x0400359A RID: 13722
		[Token(Token = "0x400359A")]
		[FieldOffset(Offset = "0x3C")]
		private TriggersAccumulator _triggers;

		// Token: 0x0400359F RID: 13727
		[Token(Token = "0x400359F")]
		[FieldOffset(Offset = "0x4C")]
		private CultDic _cultDic;

		// Token: 0x040035A0 RID: 13728
		[Token(Token = "0x40035A0")]
		[FieldOffset(Offset = "0x50")]
		public List<RefAccountInfo> RefAccounts;

		// Token: 0x040035A1 RID: 13729
		[Token(Token = "0x40035A1")]
		[FieldOffset(Offset = "0x54")]
		public ulong[] AdditionalUserIds;

		// Token: 0x040035A2 RID: 13730
		[Token(Token = "0x40035A2")]
		[FieldOffset(Offset = "0x58")]
		private ulong _experience;

		// Token: 0x040035A3 RID: 13731
		[Token(Token = "0x40035A3")]
		[FieldOffset(Offset = "0x60")]
		private uint _licenseCount;

		// Token: 0x040035A4 RID: 13732
		[Token(Token = "0x40035A4")]
		[FieldOffset(Offset = "0x64")]
		private uint _treeLevel;

		// Token: 0x040035A9 RID: 13737
		[Token(Token = "0x40035A9")]
		[FieldOffset(Offset = "0x78")]
		private ResourceSet _money;

		// Token: 0x040035AA RID: 13738
		[Token(Token = "0x40035AA")]
		[FieldOffset(Offset = "0x7C")]
		private AccountsStorage _accounts;

		// Token: 0x020010C4 RID: 4292
		[Token(Token = "0x20010C4")]
		public interface IManagedUserData
		{
			// Token: 0x06006489 RID: 25737
			[Token(Token = "0x6006489")]
			void SetUserInfo(UserInfo value);
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_OnUserInfoChangedEvent ---
		void Core_Data_UserData__add_OnUserInfoChangedEvent(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a607e9 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a607e9 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 8);
		  while ((param1_01 = (int *)func_ii_7048(param1_00,param2,0), param1_01 == (int *)0x0 ||
		         (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 8,param1_01,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,System_Action_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: remove_OnUserInfoChangedEvent ---
		void Core_Data_UserData__remove_OnUserInfoChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a607ea == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Data_Balance_IBalanceSource_BalanceChangedDelegate_TypeInfo);
		    DAT_ram_00a607ea = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0xc);
		  while ((param1_01 = (int *)UnityEngine_UI_Image__set_sprite(param1_00,param2,0),
		         param1_01 == (int *)0x0 ||
		         (Core_Data_Balance_IBalanceSource_BalanceChangedDelegate_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0xc,param1_01,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance
		            (param1_01,Core_Data_Balance_IBalanceSource_BalanceChangedDelegate_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: add_BalanceChangedEvent ---
		void Core_Data_UserData__add_BalanceChangedEvent(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a607eb == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Data_Balance_IBalanceSource_BalanceChangedDelegate_TypeInfo);
		    DAT_ram_00a607eb = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0xc);
		  while ((param1_01 = (int *)func_ii_7048(param1_00,param2,0), param1_01 == (int *)0x0 ||
		         (Core_Data_Balance_IBalanceSource_BalanceChangedDelegate_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0xc,param1_01,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance
		            (param1_01,Core_Data_Balance_IBalanceSource_BalanceChangedDelegate_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: remove_BalanceChangedEvent ---
		void Core_Data_UserData__remove_BalanceChangedEvent(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a607ec == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a607ec = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x10);
		  while ((param1_01 = (int *)UnityEngine_UI_Image__set_sprite(param1_00,param2,0),
		         param1_01 == (int *)0x0 || (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x10,param1_01,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,System_Action_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: add_OnUserNickChangedEvent ---
		void Core_Data_UserData__add_OnUserNickChangedEvent(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a607ed == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a607ed = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x10);
		  while ((param1_01 = (int *)func_ii_7048(param1_00,param2,0), param1_01 == (int *)0x0 ||
		         (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x10,param1_01,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,System_Action_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: remove_OnUserNickChangedEvent ---
		void Core_Data_UserData__remove_OnUserNickChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a607ee == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a607ee = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x14);
		  while ((param1_01 = (int *)UnityEngine_UI_Image__set_sprite(param1_00,param2,0),
		         param1_01 == (int *)0x0 || (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x14,param1_01,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,System_Action_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: add_OnUserExperienceChangedEvent ---
		void Core_Data_UserData__add_OnUserExperienceChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a607ef == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a607ef = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x14);
		  while ((param1_01 = (int *)func_ii_7048(param1_00,param2,0), param1_01 == (int *)0x0 ||
		         (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x14,param1_01,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,System_Action_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: remove_OnUserExperienceChangedEvent ---
		void Core_Data_UserData__remove_OnUserExperienceChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a607f0 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_uint__uint__TypeInfo);
		    DAT_ram_00a607f0 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x18);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_uint__uint__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_uint__uint__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x18,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: add_OnUserLicenseCountChangedEvent ---
		void Core_Data_UserData__add_OnUserLicenseCountChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a607f1 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_uint__uint__TypeInfo);
		    DAT_ram_00a607f1 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x18);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_uint__uint__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_uint__uint__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x18,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: remove_OnUserLicenseCountChangedEvent ---
		void Core_Data_UserData__remove_OnUserLicenseCountChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a607f2 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a607f2 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x1c);
		  while ((param1_01 = (int *)UnityEngine_UI_Image__set_sprite(param1_00,param2,0),
		         param1_01 == (int *)0x0 || (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x1c,param1_01,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,System_Action_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: add_OnUserTreeLevelChangedEvent ---
		void Core_Data_UserData__add_OnUserTreeLevelChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a607f3 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a607f3 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x1c);
		  while ((param1_01 = (int *)func_ii_7048(param1_00,param2,0), param1_01 == (int *)0x0 ||
		         (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x1c,param1_01,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,System_Action_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: remove_OnUserTreeLevelChangedEvent ---
		void Core_Data_UserData__remove_OnUserTreeLevelChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a607f4 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a607f4 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x20);
		  while ((param1_01 = (int *)UnityEngine_UI_Image__set_sprite(param1_00,param2,0),
		         param1_01 == (int *)0x0 || (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x20,param1_01,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,System_Action_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: add_UserSkillsChangedEvent ---
		void Core_Data_UserData__add_UserSkillsChangedEvent(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a607f5 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a607f5 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x20);
		  while ((param1_01 = (int *)func_ii_7048(param1_00,param2,0), param1_01 == (int *)0x0 ||
		         (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x20,param1_01,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,System_Action_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: remove_UserSkillsChangedEvent ---
		void Core_Data_UserData__remove_UserSkillsChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a607f6 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a607f6 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x24);
		  while ((param1_01 = (int *)UnityEngine_UI_Image__set_sprite(param1_00,param2,0),
		         param1_01 == (int *)0x0 || (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x24,param1_01,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,System_Action_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: add_OnUserLevelChangedEvent ---
		void Core_Data_UserData__add_OnUserLevelChangedEvent(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a607f7 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a607f7 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x24);
		  while ((param1_01 = (int *)func_ii_7048(param1_00,param2,0), param1_01 == (int *)0x0 ||
		         (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x24,param1_01,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,System_Action_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: remove_OnUserLevelChangedEvent ---
		void Core_Data_UserData__remove_OnUserLevelChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a607f8 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_AprDicWrapper__TypeInfo);
		    DAT_ram_00a607f8 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x28);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_AprDicWrapper__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_AprDicWrapper__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x28,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: add_OnUserAprChangedEvent ---
		void Core_Data_UserData__add_OnUserAprChangedEvent(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a607f9 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_AprDicWrapper__TypeInfo);
		    DAT_ram_00a607f9 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x28);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_AprDicWrapper__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_AprDicWrapper__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x28,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: remove_OnUserAprChangedEvent ---
		void Core_Data_UserData__remove_OnUserAprChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a607fa == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_CultDic__TypeInfo);
		    DAT_ram_00a607fa = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x2c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_CultDic__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_CultDic__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x2c,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: add_OnUserCultChangedEvent ---
		void Core_Data_UserData__add_OnUserCultChangedEvent(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a607fb == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_CultDic__TypeInfo);
		    DAT_ram_00a607fb = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x2c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_CultDic__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_CultDic__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x2c,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: remove_OnUserCultChangedEvent ---
		void Core_Data_UserData__remove_OnUserCultChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a607fc == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a607fc = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x30);
		  while ((param1_01 = (int *)UnityEngine_UI_Image__set_sprite(param1_00,param2,0),
		         param1_01 == (int *)0x0 || (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x30,param1_01,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,System_Action_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: add_OnUserGenderChangedEvent ---
		void Core_Data_UserData__add_OnUserGenderChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a607fd == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a607fd = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x30);
		  while ((param1_01 = (int *)func_ii_7048(param1_00,param2,0), param1_01 == (int *)0x0 ||
		         (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x30,param1_01,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,System_Action_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: get_SkillsData ---
		void Core_Data_UserData__get_SkillsData(int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  
		  iVar1 = *(int *)(param1 + 0x44);
		  iVar2 = *(int *)(iVar1 + 8);
		  if (iVar2 == 0) {
		    *(int *)(iVar1 + 8) = param2;
		  }
		  else {
		    if (*(int *)(param2 + 0xc) != 0) {
		      *(int *)(iVar2 + 0xc) = *(int *)(param2 + 0xc);
		    }
		    if (*(int *)(param2 + 0x10) != 0) {
		      *(int *)(iVar2 + 0x10) = *(int *)(param2 + 0x10);
		    }
		    param2 = *(int *)(param2 + 0x14);
		    if (param2 != 0) {
		      *(int *)(iVar2 + 0x14) = param2;
		    }
		  }
		  Core_Data_UserSkillsData__set_BonusRelativeSkills(iVar1,param2);
		  iVar1 = *(int *)(param1 + 0x20);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/


		/* --- GHIDRA: get_CultDic ---
		void Core_Data_UserData__get_CultDic(int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (*(int *)(*(int *)(param1 + 0x34) + 0x2c) != param2) {
		    *(int *)(*(int *)(param1 + 0x34) + 0x2c) = param2;
		    iVar1 = *(int *)(param1 + 0x30);
		    if (iVar1 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		    }
		  }
		  return;
		}
		*/


		/* --- GHIDRA: get_Apr ---
		void Core_Data_UserData__get_Apr(int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a607ff == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_AprDic__uint__get_Data__);
		    DAT_ram_00a607ff = '\x01';
		  }
		  iVar1 = *(int *)(param1 + 0x38);
		  *(int *)(param1 + 0x38) = param2;
		  *(undefined4 *)(*(int *)(param1 + 0x34) + 0x1c) = *(undefined4 *)(*(int *)(param2 + 0x10) + 0xc);
		  if ((param2 != iVar1) && (iVar1 = *(int *)(param1 + 0x28), iVar1 != 0)) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param2,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/


		/* --- GHIDRA: get_Experience ---
		void Core_Data_UserData__get_Experience(int param1,longlong param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (*(longlong *)(param1 + 0x58) != param2) {
		    *(longlong *)(param1 + 0x58) = param2;
		    iVar1 = *(int *)(param1 + 0x14);
		    if (iVar1 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		    }
		  }
		  return;
		}
		*/


		/* --- GHIDRA: get_LicenseCount ---
		void Core_Data_UserData__get_LicenseCount(int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  
		  iVar1 = *(int *)(param1 + 0x60);
		  if (iVar1 != param2) {
		    *(int *)(param1 + 0x60) = param2;
		    iVar2 = *(int *)(param1 + 0x18);
		    if (iVar2 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                (*(undefined4 *)(iVar2 + 0x20),iVar1,param2,*(undefined4 *)(iVar2 + 0x14));
		    }
		  }
		  return;
		}
		*/


		/* --- GHIDRA: get_TreeLevel ---
		void Core_Data_UserData__get_TreeLevel(int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (*(int *)(param1 + 100) != param2) {
		    *(int *)(param1 + 100) = param2;
		    iVar1 = *(int *)(param1 + 0x1c);
		    if (iVar1 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		    }
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_ClanData ---
		void Core_Data_UserData__set_ClanData(int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a60800 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Data_UserSkillsData_TypeInfo);
		    DAT_ram_00a60800 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Core_Data_UserSkillsData_TypeInfo);
		  *(undefined4 *)(param1 + 0x44) = uVar1;
		  *(undefined4 *)(param1 + 0x34) = param2;
		  return;
		}
		*/


		/* --- GHIDRA: get_UserId ---
		undefined8 Core_Data_UserData__get_UserId(int param1,undefined4 param2)
		
		{
		  return *(undefined8 *)(*(int *)(*(int *)(param1 + 8) + 0xc) + 0x10);
		}
		*/


		/* --- GHIDRA: get_CultId ---
		int * Core_Data_UserData__get_CultId(int *param1)
		
		{
		  if (*param1 == 0) {
		    return param1;
		  }
		  System_Data_DataSet__ValidateLocaleConstraint(*param1);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: get_ClanId ---
		uint Core_Data_UserData__get_ClanId(int param1,undefined4 param2)
		
		{
		  if (*(int *)(param1 + 0x68) != 0) {
		    return (uint)(*(longlong *)(*(int *)(*(int *)(*(int *)(param1 + 0x68) + 0x14) + 0x34) + 0x10) ==
		                 *(longlong *)(*(int *)(param1 + 0x34) + 0x10));
		  }
		  return 0;
		}
		*/


		/* --- GHIDRA: get_IsClanHead ---
		void Core_Data_UserData__get_IsClanHead(int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = System_Collections_CollectionBase___ctor
		                    (*(undefined4 *)(*(int *)(param1 + 0x34) + 0x18),param2,0);
		  if (iVar1 == 0) {
		    Protocol_Common_UserInfo__get_Nick(*(undefined4 *)(param1 + 0x34),param2,0);
		    iVar1 = *(int *)(param1 + 0x10);
		    if (iVar1 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		    }
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_LevelDic ---
		undefined4 Core_Data_UserData__set_LevelDic(int param1,undefined4 param2)
		
		{
		  return *(undefined4 *)(*(int *)(param1 + 0x34) + 0x20);
		}
		*/


		/* --- GHIDRA: get_Level ---
		void Core_Data_UserData__get_Level(int param1,uint param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  
		  uVar1 = *(uint *)(*(int *)(param1 + 0x34) + 0x20);
		  if (uVar1 != param2) {
		    *(uint *)(*(int *)(param1 + 0x34) + 0x20) = param2;
		    iVar2 = *(int *)(param1 + 8);
		    if (iVar2 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                (*(undefined4 *)(iVar2 + 0x20),*(undefined4 *)(iVar2 + 0x14));
		      param2 = *(uint *)(*(int *)(param1 + 0x34) + 0x20);
		    }
		    *(bool *)(param1 + 0x74) = (longlong)*(int *)(param1 + 0x70) <= (longlong)(ulonglong)param2;
		    if ((param2 != uVar1) && (iVar2 = *(int *)(param1 + 0x24), iVar2 != 0)) {
		      (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                (*(undefined4 *)(iVar2 + 0x20),*(undefined4 *)(iVar2 + 0x14));
		    }
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_Level ---
		undefined4 Core_Data_UserData__set_Level(int param1,undefined4 param2)
		
		{
		  return *(undefined4 *)(*(int *)(param1 + 0x34) + 0x28);
		}
		*/


		/* --- GHIDRA: set_PremiumExpMinLevel ---
		void Core_Data_UserData__set_PremiumExpMinLevel
		               (int param1,uint param2,uint param3,undefined4 param4)
		
		{
		  int iVar1;
		  
		  *(bool *)(param1 + 0x74) = (longlong)*(int *)(param1 + 0x70) <= (longlong)(ulonglong)param3;
		  if ((param2 != param3) && (iVar1 = *(int *)(param1 + 0x24), iVar1 != 0)) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/


		/* --- GHIDRA: get_UserInfo ---
		void Core_Data_UserData__get_UserInfo(int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (*(int *)(param1 + 0x4c) != param2) {
		    *(int *)(param1 + 0x4c) = param2;
		    *(undefined4 *)(*(int *)(param1 + 0x34) + 0x24) = *(undefined4 *)(param2 + 0xc);
		    iVar1 = *(int *)(param1 + 0x2c);
		    if (iVar1 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),param2,*(undefined4 *)(iVar1 + 0x14));
		    }
		  }
		  return;
		}
		*/


		/* --- GHIDRA: get_Money ---
		void Core_Data_UserData__get_Money(int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  int iVar5;
		  undefined4 param1_00;
		  
		  if (*(int *)(param1 + 0x78) == 0) {
		    if (param2 == 0) {
		      return;
		    }
		    *(int *)(param1 + 0x78) = param2;
		    uVar1 = 0;
		    uVar2 = 0;
		    uVar3 = 0;
		    uVar4 = 0x7ff80000;
		    param1_00 = Utils_MoneyUtils__Create(0.0,0.0,0.0,NAN,NAN,0);
		  }
		  else {
		    iVar5 = Protocol_Common_ResourceSet__Equals(*(int *)(param1 + 0x78),param2,0);
		    if (iVar5 != 0) {
		      return;
		    }
		    iVar5 = *(int *)(param1 + 0x78);
		    *(int *)(param1 + 0x78) = param2;
		    uVar1 = 0;
		    uVar2 = 0;
		    uVar3 = 0;
		    uVar4 = 0x7ff80000;
		    param1_00 = Utils_MoneyUtils__Create(0.0,0.0,0.0,NAN,NAN,0);
		    if (iVar5 != 0) {
		      param1_00 = Core_Extensions_Dict_ResourceSetExt__Sub(iVar5,*(undefined4 *)(param1 + 0x78),0);
		      iVar5 = Core_Extensions_Dict_ResourceSetExt__GetDelta(param1_00,0);
		      if (iVar5 != 0) {
		        return;
		      }
		    }
		  }
		  iVar5 = *(int *)(param1 + 0xc);
		  if (iVar5 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar5 + 0xc) * 4))
		              (CONCAT44(uVar1,*(undefined4 *)(iVar5 + 0x20)),
		               CONCAT44(uVar2,*(undefined4 *)(param1 + 0x78)),CONCAT44(uVar3,param1_00),
		               CONCAT44(uVar4,*(undefined4 *)(iVar5 + 0x14)));
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_Money ---
		undefined4 Core_Data_UserData__set_Money(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 param1_00;
		  int *piVar3;
		  int local_18;
		  undefined8 *local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a60802 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_RefAccountInfo__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_RefAccountInfo__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_RefAccountInfo__get_Current__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_RefAccountInfo__GetEnumerator__);
		    DAT_ram_00a60802 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_10,*(undefined4 *)(param1 + 0x50),
		             Method_System_Collections_Generic_List_RefAccountInfo__GetEnumerator__);
		  local_18 = 0;
		  local_14 = &local_10;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar2 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_10,
		                       Method_System_Collections_Generic_List_Enumerator_RefAccountInfo__MoveNext__)
		    ;
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) {
		      param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      iVar1 = global_1;
		      iVar2 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar1 == iVar2) {
		        piVar3 = (int *)import::env::__cxa_begin_catch(param1_00);
		        iVar2 = *piVar3;
		        DAT_ram_009d3e38 = 0;
		        local_18 = iVar2;
		        import::env::invoke_v(0x123);
		        iVar1 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar1 != 1) {
		          if (iVar2 == 0) {
		            DAT_ram_009d3e38 = 0;
		            return 0;
		          }
		          System_Data_DataSet__ValidateLocaleConstraint(iVar2);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        param1_00 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s___Scripting__UnityEngine__Render_ram_000036af + 0x41,&local_18);
		      iVar1 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar1 != 1) {
		        import::env::__resumeException(param1_00);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      import::env::__cxa_find_matching_catch_3(0);
		      unnamed_function_937();
		      do {
		        halt_trap();
		      } while( true );
		    }
		    if (iVar2 == 0) {
		      DAT_ram_009d3e38 = 0;
		      return 0;
		    }
		  } while (*(int *)(local_8._4_4_ + 0xc) == 0x6f);
		  DAT_ram_009d3e38 = 0;
		  return iVar2;
		}
		*/


		/* --- GHIDRA: get_Accounts ---
		undefined4
		Core_Data_UserData__get_Accounts(int param1,int param2,undefined4 *param3,undefined4 param4)
		
		{
		  uint uVar1;
		  int *piVar2;
		  uint *puVar3;
		  int iVar4;
		  int param2_00;
		  int iVar5;
		  int *piVar6;
		  
		  param2_00 = 0;
		  if (DAT_ram_00a6084d == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Data_Accounts_IAccountData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IAccountData__RemoveAt__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IAccountData__get_Count__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IAccountData__get_Item__);
		    DAT_ram_00a6084d = '\x01';
		  }
		  iVar4 = *(int *)(*(int *)(param1 + 0xc) + 0xc);
		  if (0 < iVar4) {
		    do {
		      piVar2 = (int *)System_Linq_Enumerable__ToList_object_
		                                (*(undefined4 *)(param1 + 0xc),param2_00,
		                                 Method_System_Collections_Generic_List_IAccountData__get_Item__);
		      *param3 = piVar2;
		      iVar5 = *piVar2;
		      if (*(ushort *)(iVar5 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          piVar6 = (int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8);
		          if (Core_Data_Accounts_IAccountData_TypeInfo == *piVar6) {
		            puVar3 = (uint *)(iVar5 + piVar6[1] * 8 + 0xc0);
		            goto code_r0x81ce7488;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		      }
		      puVar3 = (uint *)func_ii_1080(piVar2,Core_Data_Accounts_IAccountData_TypeInfo,0);
		code_r0x81ce7488:
		      iVar5 = (**(code **)((ulonglong)*puVar3 * 4))(piVar2,puVar3[1]);
		      if (param2 == *(int *)(iVar5 + 0x10)) {
		        uVar1 = 0;
		        piVar2 = (int *)*param3;
		        iVar4 = *piVar2;
		        if (*(ushort *)(iVar4 + 0xb6) == 0) goto code_r0x81ce7503;
		        goto code_r0x81ce74cb;
		      }
		      param2_00 = param2_00 + 1;
		    } while (param2_00 != iVar4);
		  }
		  goto code_r0x81ce7548;
		  while (uVar1 = uVar1 + 1, *(ushort *)(iVar4 + 0xb6) != uVar1) {
		code_r0x81ce74cb:
		    if (Core_Data_Accounts_IAccountData_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		      puVar3 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xd0);
		      goto code_r0x81ce750d;
		    }
		  }
		code_r0x81ce7503:
		  puVar3 = (uint *)func_ii_1080(piVar2,Core_Data_Accounts_IAccountData_TypeInfo,2);
		code_r0x81ce750d:
		  iVar4 = (**(code **)((ulonglong)*puVar3 * 4))(piVar2,puVar3[1]);
		  if (iVar4 == 0) {
		    return 1;
		  }
		  UnityEngine_TextCore_Glyph__set_atlasIndex
		            (*(undefined4 *)(param1 + 0xc),param2_00,
		             Method_System_Collections_Generic_List_IAccountData__RemoveAt__);
		code_r0x81ce7548:
		  *param3 = 0;
		  return 0;
		}
		*/


		/* --- GHIDRA: get_IsSigninConfirmed ---
		int Core_Data_UserData__get_IsSigninConfirmed(int param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  int iVar5;
		  int iVar6;
		  
		  if (DAT_ram_00a60803 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Dict_DictWrappers_Base_AbstractDictWrapperStorage_AprDicWrapper__uint__GetWrapper__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Data_UserData_TypeInfo);
		    DAT_ram_00a60803 = '\x01';
		  }
		  iVar2 = unnamed_function_1417(Core_Data_UserData_TypeInfo);
		  if (DAT_ram_00a60800 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Data_UserSkillsData_TypeInfo);
		    DAT_ram_00a60800 = '\x01';
		  }
		  uVar1 = 0;
		  uVar3 = unnamed_function_1417(Core_Data_UserSkillsData_TypeInfo);
		  *(undefined4 *)(iVar2 + 0x44) = uVar3;
		  *(int *)(iVar2 + 0x34) = param1;
		  iVar6 = *param2;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0xd8);
		        goto code_r0x81ce98f7;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(param2,Core_Dict_IDictProvider_TypeInfo,3);
		code_r0x81ce98f7:
		  iVar6 = (**(code **)((ulonglong)*puVar4 * 4))(param2,puVar4[1]);
		  iVar6 = func_ii_7730(*(undefined4 *)(iVar6 + 0x14),*(undefined4 *)(param1 + 0x1c),
		                       Method_Core_Dict_DictWrappers_Base_AbstractDictWrapperStorage_AprDicWrapper__uint__GetWrapper__
		                      );
		  if (DAT_ram_00a607ff == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_AprDic__uint__get_Data__);
		    DAT_ram_00a607ff = '\x01';
		  }
		  iVar5 = *(int *)(iVar2 + 0x38);
		  *(int *)(iVar2 + 0x38) = iVar6;
		  *(undefined4 *)(*(int *)(iVar2 + 0x34) + 0x1c) = *(undefined4 *)(*(int *)(iVar6 + 0x10) + 0xc);
		  if ((iVar6 != iVar5) && (iVar5 = *(int *)(iVar2 + 0x28), iVar5 != 0)) {
		    (**(code **)((ulonglong)*(uint *)(iVar5 + 0xc) * 4))
		              (*(undefined4 *)(iVar5 + 0x20),iVar6,*(undefined4 *)(iVar5 + 0x14));
		  }
		  uVar1 = 0;
		  iVar6 = *param2;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0xd0);
		        goto code_r0x81ce99ef;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(param2,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x81ce99ef:
		  uVar3 = (**(code **)((ulonglong)*puVar4 * 4))(param2,puVar4[1]);
		  iVar6 = Core_Extensions_Dict_DictExt__GetAllArtikulTypeMetaFilterByType
		                    (uVar3,*(undefined4 *)(param1 + 0x24),0);
		  if (iVar6 != *(int *)(iVar2 + 0x4c)) {
		    *(int *)(iVar2 + 0x4c) = iVar6;
		    *(undefined4 *)(*(int *)(iVar2 + 0x34) + 0x24) = *(undefined4 *)(iVar6 + 0xc);
		    iVar5 = *(int *)(iVar2 + 0x2c);
		    if (iVar5 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar5 + 0xc) * 4))
		                (*(undefined4 *)(iVar5 + 0x20),iVar6,*(undefined4 *)(iVar5 + 0x14));
		    }
		  }
		  return iVar2;
		}
		*/

}
