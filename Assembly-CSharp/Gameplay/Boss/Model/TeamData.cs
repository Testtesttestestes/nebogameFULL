using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Data.Skills;
using Il2CppDummyDll;
using JetBrains.Annotations;
using Protocol.Boss;
using Utils;

namespace Gameplay.Boss.Model
{
	// Token: 0x02000B95 RID: 2965
	[Token(Token = "0x2000B95")]
	public class TeamData : IDisposable
	{
		// Token: 0x17000EB3 RID: 3763
		// (get) Token: 0x06004870 RID: 18544 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004871 RID: 18545 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000EB3")]
		[NotNull]
		public BackTime TimeoutBacktimer
		{
			[Token(Token = "0x6004870")]
			[Address(RVA = "0x96EF", Offset = "0x96EF", VA = "0x96EF")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004871")]
			[Address(RVA = "0x96F0", Offset = "0x96F0", VA = "0x96F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000EB4 RID: 3764
		// (get) Token: 0x06004872 RID: 18546 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004873 RID: 18547 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000EB4")]
		public Skill TotalSkillBonus
		{
			[Token(Token = "0x6004872")]
			[Address(RVA = "0x96F1", Offset = "0x96F1", VA = "0x96F1")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004873")]
			[Address(RVA = "0x96F2", Offset = "0x96F2", VA = "0x96F2")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000EB5 RID: 3765
		// (get) Token: 0x06004874 RID: 18548 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004875 RID: 18549 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000EB5")]
		public List<TeamData.TeamAssistantData> Assistants
		{
			[Token(Token = "0x6004874")]
			[Address(RVA = "0x96F3", Offset = "0x96F3", VA = "0x96F3")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004875")]
			[Address(RVA = "0x96F4", Offset = "0x96F4", VA = "0x96F4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000EB6 RID: 3766
		// (get) Token: 0x06004876 RID: 18550 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004877 RID: 18551 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000EB6")]
		public TeamData.TeamCaptainData Captain
		{
			[Token(Token = "0x6004876")]
			[Address(RVA = "0x96F5", Offset = "0x96F5", VA = "0x96F5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004877")]
			[Address(RVA = "0x96F6", Offset = "0x96F6", VA = "0x96F6")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000EB7 RID: 3767
		// (get) Token: 0x06004878 RID: 18552 RVA: 0x0000D668 File Offset: 0x0000B868
		[Token(Token = "0x17000EB7")]
		public bool HasEmptySlots
		{
			[Token(Token = "0x6004878")]
			[Address(RVA = "0x96F7", Offset = "0x96F7", VA = "0x96F7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x140001CA RID: 458
		// (add) Token: 0x06004879 RID: 18553 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600487A RID: 18554 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001CA")]
		public event Action CaptainRatingChangedEvent
		{
			[Token(Token = "0x6004879")]
			[Address(RVA = "0x96F8", Offset = "0x96F8", VA = "0x96F8")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600487A")]
			[Address(RVA = "0x96F9", Offset = "0x96F9", VA = "0x96F9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000EB8 RID: 3768
		// (get) Token: 0x0600487B RID: 18555 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600487C RID: 18556 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000EB8")]
		public CaptainRating CaptainRating
		{
			[Token(Token = "0x600487B")]
			[Address(RVA = "0x96FA", Offset = "0x96FA", VA = "0x96FA")]
			get
			{
				return null;
			}
			[Token(Token = "0x600487C")]
			[Address(RVA = "0x96FB", Offset = "0x96FB", VA = "0x96FB")]
			set
			{
			}
		}

		// Token: 0x17000EB9 RID: 3769
		// (get) Token: 0x0600487D RID: 18557 RVA: 0x0000D680 File Offset: 0x0000B880
		// (set) Token: 0x0600487E RID: 18558 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000EB9")]
		public ulong CaptainsCount
		{
			[Token(Token = "0x600487D")]
			[Address(RVA = "0x96FC", Offset = "0x96FC", VA = "0x96FC")]
			[CompilerGenerated]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x600487E")]
			[Address(RVA = "0x96FD", Offset = "0x96FD", VA = "0x96FD")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000EBA RID: 3770
		// (get) Token: 0x0600487F RID: 18559 RVA: 0x0000D698 File Offset: 0x0000B898
		// (set) Token: 0x06004880 RID: 18560 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000EBA")]
		public bool IsMyTeam
		{
			[Token(Token = "0x600487F")]
			[Address(RVA = "0x96FE", Offset = "0x96FE", VA = "0x96FE")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004880")]
			[Address(RVA = "0x96FF", Offset = "0x96FF", VA = "0x96FF")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000EBB RID: 3771
		// (get) Token: 0x06004881 RID: 18561 RVA: 0x0000D6B0 File Offset: 0x0000B8B0
		[Token(Token = "0x17000EBB")]
		public ulong TeamId
		{
			[Token(Token = "0x6004881")]
			[Address(RVA = "0x9700", Offset = "0x9700", VA = "0x9700")]
			get
			{
				return 0UL;
			}
		}

		// Token: 0x17000EBC RID: 3772
		// (get) Token: 0x06004882 RID: 18562 RVA: 0x0000D6C8 File Offset: 0x0000B8C8
		[Token(Token = "0x17000EBC")]
		public ulong MyRatingPlace
		{
			[Token(Token = "0x6004882")]
			[Address(RVA = "0x9701", Offset = "0x9701", VA = "0x9701")]
			get
			{
				return 0UL;
			}
		}

		// Token: 0x06004883 RID: 18563 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004883")]
		[Address(RVA = "0x1B87", Offset = "0x1B87", VA = "0x1B87")]
		public TeamData.TeamAssistantData GetAssistantById(ulong uid)
		{
			return null;
		}

		// Token: 0x06004884 RID: 18564 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004884")]
		[Address(RVA = "0x9702", Offset = "0x9702", VA = "0x9702")]
		public TeamData(TeamInfo rawTeamInfo, BossInfo bossInfo, UserData loggedUser)
		{
		}

		// Token: 0x17000EBD RID: 3773
		// (get) Token: 0x06004885 RID: 18565 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004886 RID: 18566 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000EBD")]
		public TeamInfo RawTeamInfo
		{
			[Token(Token = "0x6004885")]
			[Address(RVA = "0x9703", Offset = "0x9703", VA = "0x9703")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004886")]
			[Address(RVA = "0x9704", Offset = "0x9704", VA = "0x9704")]
			set
			{
			}
		}

		// Token: 0x06004887 RID: 18567 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004887")]
		[Address(RVA = "0x9705", Offset = "0x9705", VA = "0x9705", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x040027B0 RID: 10160
		[Token(Token = "0x40027B0")]
		[FieldOffset(Offset = "0x8")]
		private BossInfo _bossInfo;

		// Token: 0x040027B1 RID: 10161
		[Token(Token = "0x40027B1")]
		public const int CAPACITY = 5;

		// Token: 0x040027B7 RID: 10167
		[Token(Token = "0x40027B7")]
		[FieldOffset(Offset = "0x20")]
		private CaptainRating _captainRating;

		// Token: 0x040027BA RID: 10170
		[Token(Token = "0x40027BA")]
		[FieldOffset(Offset = "0x34")]
		private TeamInfo _rawTeamInfo;

		// Token: 0x02000B96 RID: 2966
		[Token(Token = "0x2000B96")]
		public abstract class AbstractTeamMember
		{
			// Token: 0x17000EBE RID: 3774
			// (get) Token: 0x06004888 RID: 18568 RVA: 0x0000D6E0 File Offset: 0x0000B8E0
			// (set) Token: 0x06004889 RID: 18569 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000EBE")]
			public long InstanceId
			{
				[Token(Token = "0x6004888")]
				[Address(RVA = "0x9706", Offset = "0x9706", VA = "0x9706")]
				[CompilerGenerated]
				get
				{
					return 0L;
				}
				[Token(Token = "0x6004889")]
				[Address(RVA = "0x9707", Offset = "0x9707", VA = "0x9707")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000EBF RID: 3775
			// (get) Token: 0x0600488A RID: 18570 RVA: 0x0000D6F8 File Offset: 0x0000B8F8
			// (set) Token: 0x0600488B RID: 18571 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000EBF")]
			public ulong TeamId
			{
				[Token(Token = "0x600488A")]
				[Address(RVA = "0x9708", Offset = "0x9708", VA = "0x9708")]
				[CompilerGenerated]
				get
				{
					return 0UL;
				}
				[Token(Token = "0x600488B")]
				[Address(RVA = "0x9709", Offset = "0x9709", VA = "0x9709")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000EC0 RID: 3776
			// (get) Token: 0x0600488C RID: 18572
			[Token(Token = "0x17000EC0")]
			public abstract UserData UserData { [Token(Token = "0x600488C")] get; }

			// Token: 0x0600488D RID: 18573 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600488D")]
			[Address(RVA = "0x970A", Offset = "0x970A", VA = "0x970A")]
			public AbstractTeamMember(long instanceId, ulong teamId)
			{
			}
		}

		// Token: 0x02000B97 RID: 2967
		[Token(Token = "0x2000B97")]
		public class TeamAssistantData : TeamData.AbstractTeamMember
		{
			// Token: 0x17000EC1 RID: 3777
			// (get) Token: 0x0600488E RID: 18574 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000EC1")]
			public override UserData UserData
			{
				[Token(Token = "0x600488E")]
				[Address(RVA = "0x970B", Offset = "0x970B", VA = "0x970B", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000EC2 RID: 3778
			// (get) Token: 0x0600488F RID: 18575 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x06004890 RID: 18576 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000EC2")]
			public Skills SkillBonuses
			{
				[Token(Token = "0x600488F")]
				[Address(RVA = "0x970C", Offset = "0x970C", VA = "0x970C")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6004890")]
				[Address(RVA = "0x970D", Offset = "0x970D", VA = "0x970D")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000EC3 RID: 3779
			// (get) Token: 0x06004891 RID: 18577 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x06004892 RID: 18578 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000EC3")]
			public Skill SkillBonus
			{
				[Token(Token = "0x6004891")]
				[Address(RVA = "0x970E", Offset = "0x970E", VA = "0x970E")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6004892")]
				[Address(RVA = "0x970F", Offset = "0x970F", VA = "0x970F")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000EC4 RID: 3780
			// (get) Token: 0x06004893 RID: 18579 RVA: 0x0000D710 File Offset: 0x0000B910
			// (set) Token: 0x06004894 RID: 18580 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000EC4")]
			public int CultBonusPercent
			{
				[Token(Token = "0x6004893")]
				[Address(RVA = "0x9710", Offset = "0x9710", VA = "0x9710")]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[Token(Token = "0x6004894")]
				[Address(RVA = "0x9711", Offset = "0x9711", VA = "0x9711")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000EC5 RID: 3781
			// (get) Token: 0x06004895 RID: 18581 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x06004896 RID: 18582 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000EC5")]
			[NotNull]
			public BackTime BackTime
			{
				[Token(Token = "0x6004895")]
				[Address(RVA = "0x9712", Offset = "0x9712", VA = "0x9712")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6004896")]
				[Address(RVA = "0x9713", Offset = "0x9713", VA = "0x9713")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000EC6 RID: 3782
			// (get) Token: 0x06004897 RID: 18583 RVA: 0x0000D728 File Offset: 0x0000B928
			[Token(Token = "0x17000EC6")]
			public bool IsAbsent
			{
				[Token(Token = "0x6004897")]
				[Address(RVA = "0x9714", Offset = "0x9714", VA = "0x9714")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17000EC7 RID: 3783
			// (get) Token: 0x06004898 RID: 18584 RVA: 0x0000D740 File Offset: 0x0000B940
			[Token(Token = "0x17000EC7")]
			public bool IsInvited
			{
				[Token(Token = "0x6004898")]
				[Address(RVA = "0x9715", Offset = "0x9715", VA = "0x9715")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17000EC8 RID: 3784
			// (get) Token: 0x06004899 RID: 18585 RVA: 0x0000D758 File Offset: 0x0000B958
			[Token(Token = "0x17000EC8")]
			public bool IsReady
			{
				[Token(Token = "0x6004899")]
				[Address(RVA = "0x9716", Offset = "0x9716", VA = "0x9716")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0600489A RID: 18586 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600489A")]
			[Address(RVA = "0x9717", Offset = "0x9717", VA = "0x9717")]
			public TeamAssistantData(TeamInfo.Types.MercenaryInfo mercenaryInfo, BossInfo bossInfo, long instanceId, ulong teamId)
			{
			}

			// Token: 0x17000EC9 RID: 3785
			// (get) Token: 0x0600489B RID: 18587 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x0600489C RID: 18588 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000EC9")]
			public TeamInfo.Types.MercenaryInfo RawMercenaryInfo
			{
				[Token(Token = "0x600489B")]
				[Address(RVA = "0x9718", Offset = "0x9718", VA = "0x9718")]
				get
				{
					return null;
				}
				[Token(Token = "0x600489C")]
				[Address(RVA = "0x1B30", Offset = "0x1B30", VA = "0x1B30")]
				set
				{
				}
			}

			// Token: 0x040027BD RID: 10173
			[Token(Token = "0x40027BD")]
			[FieldOffset(Offset = "0x18")]
			private BossInfo _bossInfo;

			// Token: 0x040027BE RID: 10174
			[Token(Token = "0x40027BE")]
			[FieldOffset(Offset = "0x1C")]
			private UserData _userData;

			// Token: 0x040027C3 RID: 10179
			[Token(Token = "0x40027C3")]
			[FieldOffset(Offset = "0x30")]
			private TeamInfo.Types.MercenaryInfo _rawMercenaryInfo;
		}

		// Token: 0x02000B99 RID: 2969
		[Token(Token = "0x2000B99")]
		public class TeamCaptainData : TeamData.AbstractTeamMember
		{
			// Token: 0x17000ECA RID: 3786
			// (get) Token: 0x060048A0 RID: 18592 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000ECA")]
			public override UserData UserData
			{
				[Token(Token = "0x60048A0")]
				[Address(RVA = "0x971C", Offset = "0x971C", VA = "0x971C", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000ECB RID: 3787
			// (get) Token: 0x060048A1 RID: 18593 RVA: 0x0000D788 File Offset: 0x0000B988
			// (set) Token: 0x060048A2 RID: 18594 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000ECB")]
			public uint SlotsCont
			{
				[Token(Token = "0x60048A1")]
				[Address(RVA = "0x971D", Offset = "0x971D", VA = "0x971D")]
				[CompilerGenerated]
				get
				{
					return 0U;
				}
				[Token(Token = "0x60048A2")]
				[Address(RVA = "0x971E", Offset = "0x971E", VA = "0x971E")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x060048A3 RID: 18595 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60048A3")]
			[Address(RVA = "0x971F", Offset = "0x971F", VA = "0x971F")]
			public TeamCaptainData(TeamInfo.Types.CaptainInfo captainInfo, long instanceId, ulong teamId)
			{
			}

			// Token: 0x17000ECC RID: 3788
			// (get) Token: 0x060048A4 RID: 18596 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x060048A5 RID: 18597 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000ECC")]
			public TeamInfo.Types.CaptainInfo RawCaptainInfo
			{
				[Token(Token = "0x60048A4")]
				[Address(RVA = "0x9720", Offset = "0x9720", VA = "0x9720")]
				get
				{
					return null;
				}
				[Token(Token = "0x60048A5")]
				[Address(RVA = "0x9721", Offset = "0x9721", VA = "0x9721")]
				set
				{
				}
			}

			// Token: 0x040027C6 RID: 10182
			[Token(Token = "0x40027C6")]
			[FieldOffset(Offset = "0x18")]
			private UserData _userData;

			// Token: 0x040027C8 RID: 10184
			[Token(Token = "0x40027C8")]
			[FieldOffset(Offset = "0x20")]
			private TeamInfo.Types.CaptainInfo _rawCaptainInfo;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Captain ---
		uint Gameplay_Boss_Model_TeamData__set_Captain(int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57890 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_TeamData_TeamAssistantData__get_Count__);
		    DAT_ram_00a57890 = '\x01';
		  }
		  return (uint)(*(int *)(*(int *)(param1 + 0x14) + 0xc) < 5);
		}
		*/


		/* --- GHIDRA: get_HasEmptySlots ---
		void Gameplay_Boss_Model_TeamData__get_HasEmptySlots(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a57891 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a57891 = '\x01';
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


		/* --- GHIDRA: add_CaptainRatingChangedEvent ---
		void Gameplay_Boss_Model_TeamData__add_CaptainRatingChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a57892 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a57892 = '\x01';
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


		/* --- GHIDRA: get_CaptainRating ---
		void Gameplay_Boss_Model_TeamData__get_CaptainRating(int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  *(undefined4 *)(param1 + 0x20) = param2;
		  iVar1 = *(int *)(param1 + 0x1c);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_IsMyTeam ---
		undefined8 Gameplay_Boss_Model_TeamData__set_IsMyTeam(int param1,undefined4 param2)
		
		{
		  return *(undefined8 *)(*(int *)(param1 + 0x34) + 0x20);
		}
		*/


		/* --- GHIDRA: get_TeamId ---
		undefined8 Gameplay_Boss_Model_TeamData__get_TeamId(int param1,undefined4 param2)
		
		{
		  if (*(int *)(param1 + 0x20) != 0) {
		    return *(undefined8 *)(*(int *)(param1 + 0x20) + 0x20);
		  }
		  return 0;
		}
		*/


		/* --- GHIDRA: get_MyRatingPlace ---
		void Gameplay_Boss_Model_TeamData__get_MyRatingPlace
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  undefined4 uVar1;
		  longlong lVar2;
		  longlong lVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a57894 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_TeamData_TeamAssistantData___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_List_TeamData_TeamAssistantData__TypeInfo);
		    DAT_ram_00a57894 = '\x01';
		  }
		  uVar1 = unnamed_function_1417
		                    (System_Collections_Generic_List_TeamData_TeamAssistantData__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (uVar1,Method_System_Collections_Generic_List_TeamData_TeamAssistantData___ctor__);
		  *(undefined4 *)(param1 + 0x14) = uVar1;
		  *(undefined4 *)(param1 + 8) = param3;
		  Gameplay_Boss_Model_TeamData__get_RawTeamInfo(param1,param2,param1);
		  iVar4 = **(int **)(param1 + 0x18);
		  uVar1 = (**(code **)((ulonglong)*(uint *)(iVar4 + 0xe0) * 4))
		                    (*(int **)(param1 + 0x18),*(undefined4 *)(iVar4 + 0xe4));
		  lVar2 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext(uVar1,0);
		  lVar3 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext(param4,0);
		  *(bool *)(param1 + 0x30) = lVar2 == lVar3;
		  return;
		}
		*/


		/* --- GHIDRA: get_RawTeamInfo ---
		/* WARNING: Removing unreachable block (ram,0x80ded559) */
		
		void Gameplay_Boss_Model_TeamData__get_RawTeamInfo(int param1,int param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000004;
		  int iVar1;
		  undefined4 *puVar2;
		  int *piVar3;
		  uint *puVar4;
		  float param2_00;
		  undefined4 uVar5;
		  int iVar6;
		  undefined4 uVar7;
		  int param2_01;
		  undefined8 uVar8;
		  undefined8 uVar9;
		  int *piVar10;
		  uint uVar11;
		  int local_c;
		  int **local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a57895 == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_BackTime_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_IEnumerator_TeamInfo_Types_MercenaryInfo__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_TeamData_TeamAssistantData__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_TeamData_TeamAssistantData__Clear__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Google_Protobuf_Collections_RepeatedField_TeamInfo_Types_MercenaryInfo__GetEnumerator__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Data_Skills_Skill_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Boss_Model_TeamData_TeamAssistantData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Boss_Model_TeamData_TeamCaptainData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    DAT_ram_00a57895 = '\x01';
		  }
		  *(int *)(param1 + 0x34) = param2;
		  uVar5 = *(undefined4 *)(param2 + 0x18);
		  uVar8 = *(undefined8 *)(param2 + 0x10);
		  uVar9 = *(undefined8 *)(param2 + 0x20);
		  iVar1 = unnamed_function_1417(Gameplay_Boss_Model_TeamData_TeamCaptainData_TypeInfo);
		  *(undefined8 *)(iVar1 + 0x10) = uVar9;
		  *(undefined8 *)(iVar1 + 8) = uVar8;
		  Gameplay_Boss_Model_TeamData_TeamCaptainData__get_RawCaptainInfo(iVar1,uVar5,iVar1);
		  *(int *)(param1 + 0x18) = iVar1;
		  iVar1 = *(int *)(param1 + 0x14);
		  iVar6 = *(int *)(iVar1 + 0xc);
		  *(undefined4 *)(iVar1 + 0xc) = 0;
		  *(int *)(iVar1 + 0x10) = *(int *)(iVar1 + 0x10) + 1;
		  if (0 < iVar6) {
		    func_ii_2064(*(undefined4 *)(iVar1 + 8),0,iVar6,0);
		  }
		  iVar1 = unnamed_function_1417(Core_Data_Skills_Skill_TypeInfo);
		  *(int *)(param1 + 0x10) = iVar1;
		  uVar5 = *(undefined4 *)(*(int *)(param1 + 8) + 0x24);
		  *(undefined8 *)(iVar1 + 0x10) = 0;
		  *(undefined4 *)(iVar1 + 8) = uVar5;
		  local_4 = (int *)Google_Protobuf_Collections_RepeatedField_float___Equals
		                             (*(undefined4 *)(*(int *)(param1 + 0x34) + 0x28),
		                              Method_Google_Protobuf_Collections_RepeatedField_TeamInfo_Types_MercenaryInfo__GetEnumerator__
		                             );
		  local_c = 0;
		  local_8 = &local_4;
		code_r0x80ded32c:
		  piVar3 = local_4;
		  iVar1 = *local_4;
		  if (*(ushort *)(iVar1 + 0xb6) != 0) {
		    uVar11 = 0;
		    do {
		      piVar10 = (int *)(*(int *)(iVar1 + 0x58) + uVar11 * 8);
		      if (System_Collections_IEnumerator_TypeInfo == *piVar10) {
		        puVar2 = (undefined4 *)(iVar1 + piVar10[1] * 8 + 0xc0);
		        goto code_r0x80ded3c4;
		      }
		      uVar11 = uVar11 + 1;
		    } while (*(ushort *)(iVar1 + 0xb6) != uVar11);
		  }
		  DAT_ram_009d3e38 = 0;
		  puVar2 = (undefined4 *)
		           import::env::invoke_iiii
		                     (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                      System_Collections_IEnumerator_TypeInfo,0);
		  if (DAT_ram_009d3e38 == 1) {
		code_r0x80ded408:
		    DAT_ram_009d3e38 = 0;
		    uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    goto code_r0x80ded6a5;
		  }
		code_r0x80ded3c4:
		  DAT_ram_009d3e38 = 0;
		  iVar1 = import::env::invoke_iii(*puVar2,piVar3,puVar2[1]);
		  piVar3 = local_4;
		  if (DAT_ram_009d3e38 == 1) goto code_r0x80ded408;
		  if (iVar1 == 0) goto code_r0x80ded6ee;
		  iVar1 = *local_4;
		  if (*(ushort *)(iVar1 + 0xb6) != 0) {
		    uVar11 = 0;
		    do {
		      piVar10 = (int *)(*(int *)(iVar1 + 0x58) + uVar11 * 8);
		      if (System_Collections_Generic_IEnumerator_TeamInfo_Types_MercenaryInfo__TypeInfo == *piVar10)
		      {
		        puVar2 = (undefined4 *)(iVar1 + piVar10[1] * 8 + 0xc0);
		        goto code_r0x80ded4ad;
		      }
		      uVar11 = uVar11 + 1;
		    } while (*(ushort *)(iVar1 + 0xb6) != uVar11);
		  }
		  DAT_ram_009d3e38 = 0;
		  puVar2 = (undefined4 *)
		           import::env::invoke_iiii
		                     (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                      System_Collections_Generic_IEnumerator_TeamInfo_Types_MercenaryInfo__TypeInfo,
		                      0);
		  if (DAT_ram_009d3e38 == 1) {
		code_r0x80ded67f:
		    DAT_ram_009d3e38 = 0;
		    uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    goto code_r0x80ded6a5;
		  }
		code_r0x80ded4ad:
		  DAT_ram_009d3e38 = 0;
		  uVar5 = import::env::invoke_iii(*puVar2,piVar3,puVar2[1]);
		  if (DAT_ram_009d3e38 == 1) goto code_r0x80ded67f;
		  uVar8 = *(undefined8 *)(param2 + 0x10);
		  uVar7 = *(undefined4 *)(param1 + 8);
		  uVar9 = *(undefined8 *)(*(int *)(param1 + 0x34) + 0x20);
		  DAT_ram_009d3e38 = 0;
		  iVar1 = import::env::invoke_ii
		                    (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                     Gameplay_Boss_Model_TeamData_TeamAssistantData_TypeInfo);
		  if (DAT_ram_009d3e38 == 1) {
		code_r0x80ded689:
		    DAT_ram_009d3e38 = 0;
		    uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    goto code_r0x80ded6a5;
		  }
		  *(undefined4 *)(iVar1 + 0x18) = uVar7;
		  *(undefined8 *)(iVar1 + 0x10) = uVar9;
		  *(undefined8 *)(iVar1 + 8) = uVar8;
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_viii
		            (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x368,iVar1,uVar5,iVar1);
		  iVar6 = Method_System_Collections_Generic_List_TeamData_TeamAssistantData__Add__;
		  if (DAT_ram_009d3e38 == 1) goto code_r0x80ded689;
		  param2_01 = *(int *)(param1 + 0x14);
		  *(int *)(param2_01 + 0x10) = *(int *)(param2_01 + 0x10) + 1;
		  uVar11 = *(uint *)(param2_01 + 0xc);
		  if (uVar11 < *(uint *)(*(int *)(param2_01 + 8) + 0xc)) {
		    *(uint *)(param2_01 + 0xc) = uVar11 + 1;
		    *(int *)(*(int *)(param2_01 + 8) + uVar11 * 4 + 0x10) = iVar1;
		  }
		  else {
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,param2_01,iVar1,
		               *(undefined4 *)(*(int *)(*(int *)(iVar6 + 0x10) + 0x60) + 0x38));
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 == 1) goto code_r0x80ded693;
		  }
		  if (*(int *)(iVar1 + 0x24) != 0) {
		    DAT_ram_009d3e38 = 0;
		    uVar5 = import::env::invoke_iiii
		                      (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x369,
		                       *(undefined4 *)(param1 + 0x10),*(int *)(iVar1 + 0x24),0);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) {
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80ded6a5;
		    }
		    *(undefined4 *)(param1 + 0x10) = uVar5;
		  }
		  goto code_r0x80ded32c;
		code_r0x80ded693:
		  uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80ded6a5:
		  iVar1 = global_1;
		  iVar6 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar1 == iVar6) {
		    piVar3 = (int *)import::env::__cxa_begin_catch(uVar5);
		    local_c = *piVar3;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 != 1) {
		code_r0x80ded6ee:
		      DAT_ram_009d3e38 = 0;
		      piVar3 = *local_8;
		      if (piVar3 != (int *)0x0) {
		        uVar11 = 0;
		        iVar1 = *piVar3;
		        if (*(ushort *)(iVar1 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar1 + 0x58) + uVar11 * 8)) {
		              puVar4 = (uint *)(iVar1 + *(int *)(*(int *)(iVar1 + 0x58) + uVar11 * 8 + 4) * 8 + 0xc0
		                               );
		              goto code_r0x80ded769;
		            }
		            uVar11 = uVar11 + 1;
		          } while (*(ushort *)(iVar1 + 0xb6) != uVar11);
		        }
		        puVar4 = (uint *)func_ii_1080(piVar3,System_IDisposable_TypeInfo,0);
		code_r0x80ded769:
		        (**(code **)((ulonglong)*puVar4 * 4))(CONCAT44(in_register_20000004,piVar3),puVar4[1]);
		      }
		      if (local_c != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(local_c);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      uVar8 = *(undefined8 *)(*(int *)(param1 + 0x34) + 0x30);
		      if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Utils_TimeUtils_TypeInfo);
		      }
		      param2_00 = func_ii_7331(uVar8,0);
		      uVar5 = unnamed_function_1417(Utils_BackTime_TypeInfo);
		      Core_Extensions_Dict_DictExt__BinarySearch_object__uint_(uVar5,param2_00,0);
		      *(undefined4 *)(param1 + 0xc) = uVar5;
		      return;
		    }
		    uVar5 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_000017c8 + 0x36a,&local_c);
		  iVar1 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar1 != 1) {
		    import::env::__resumeException(uVar5);
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
		*/

}
