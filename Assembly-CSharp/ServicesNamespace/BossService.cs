using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Net;
using Google.Protobuf;
using Il2CppDummyDll;
using Protocol.Boss;
using Utils;

namespace ServicesNamespace
{
	// Token: 0x02000090 RID: 144
	[Token(Token = "0x2000090")]
	public class BossService : AbstractService
	{
		// Token: 0x17000094 RID: 148
		// (get) Token: 0x0600040C RID: 1036 RVA: 0x00002E80 File Offset: 0x00001080
		[Token(Token = "0x17000094")]
		public override short ServiceId
		{
			[Token(Token = "0x600040C")]
			[Address(RVA = "0x5839", Offset = "0x5839", VA = "0x5839", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1400001E RID: 30
		// (add) Token: 0x0600040D RID: 1037 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600040E RID: 1038 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400001E")]
		public event Action<InstanceInfoEvt> InstanceInfoEvent
		{
			[Token(Token = "0x600040D")]
			[Address(RVA = "0x583A", Offset = "0x583A", VA = "0x583A")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600040E")]
			[Address(RVA = "0x583B", Offset = "0x583B", VA = "0x583B")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400001F RID: 31
		// (add) Token: 0x0600040F RID: 1039 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000410 RID: 1040 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400001F")]
		public event Action<ActiveTeamArchivedEvt> ActiveTeamArchivedEvent
		{
			[Token(Token = "0x600040F")]
			[Address(RVA = "0x583C", Offset = "0x583C", VA = "0x583C")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000410")]
			[Address(RVA = "0x583D", Offset = "0x583D", VA = "0x583D")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000020 RID: 32
		// (add) Token: 0x06000411 RID: 1041 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000412 RID: 1042 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000020")]
		public event Action<TeamTimeoutEvt> ActiveTeamTimeoutEvent
		{
			[Token(Token = "0x6000411")]
			[Address(RVA = "0x583E", Offset = "0x583E", VA = "0x583E")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000412")]
			[Address(RVA = "0x583F", Offset = "0x583F", VA = "0x583F")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000021 RID: 33
		// (add) Token: 0x06000413 RID: 1043 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000414 RID: 1044 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000021")]
		public event Action<CreateRequestEvt> CreateRequestEvent
		{
			[Token(Token = "0x6000413")]
			[Address(RVA = "0x5840", Offset = "0x5840", VA = "0x5840")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000414")]
			[Address(RVA = "0x5841", Offset = "0x5841", VA = "0x5841")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000022 RID: 34
		// (add) Token: 0x06000415 RID: 1045 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000416 RID: 1046 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000022")]
		public event Action<TeamInfo> TeamInfoChangedEvent
		{
			[Token(Token = "0x6000415")]
			[Address(RVA = "0x5842", Offset = "0x5842", VA = "0x5842")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000416")]
			[Address(RVA = "0x5843", Offset = "0x5843", VA = "0x5843")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000023 RID: 35
		// (add) Token: 0x06000417 RID: 1047 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000418 RID: 1048 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000023")]
		public event Action<MonsterHealthEvt> MonsterHealthChangedEvent
		{
			[Token(Token = "0x6000417")]
			[Address(RVA = "0x5844", Offset = "0x5844", VA = "0x5844")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000418")]
			[Address(RVA = "0x5845", Offset = "0x5845", VA = "0x5845")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000024 RID: 36
		// (add) Token: 0x06000419 RID: 1049 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600041A RID: 1050 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000024")]
		public event Action<InstanceState> InstanceStateChangedEvent
		{
			[Token(Token = "0x6000419")]
			[Address(RVA = "0x5846", Offset = "0x5846", VA = "0x5846")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600041A")]
			[Address(RVA = "0x5847", Offset = "0x5847", VA = "0x5847")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000025 RID: 37
		// (add) Token: 0x0600041B RID: 1051 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600041C RID: 1052 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000025")]
		public event Action<MercenaryInvitesEvt> MercenaryInvitesChangedEvent
		{
			[Token(Token = "0x600041B")]
			[Address(RVA = "0x5848", Offset = "0x5848", VA = "0x5848")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600041C")]
			[Address(RVA = "0x5849", Offset = "0x5849", VA = "0x5849")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000026 RID: 38
		// (add) Token: 0x0600041D RID: 1053 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600041E RID: 1054 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000026")]
		public event Action<MercenaryTeamsEvt> MercenaryTeamsChangedEvent
		{
			[Token(Token = "0x600041D")]
			[Address(RVA = "0x584A", Offset = "0x584A", VA = "0x584A")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600041E")]
			[Address(RVA = "0x584B", Offset = "0x584B", VA = "0x584B")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000027 RID: 39
		// (add) Token: 0x0600041F RID: 1055 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000420 RID: 1056 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000027")]
		public event Action<MinionAttackEvt> MinionAttackEvent
		{
			[Token(Token = "0x600041F")]
			[Address(RVA = "0x584C", Offset = "0x584C", VA = "0x584C")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000420")]
			[Address(RVA = "0x584D", Offset = "0x584D", VA = "0x584D")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000028 RID: 40
		// (add) Token: 0x06000421 RID: 1057 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000422 RID: 1058 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000028")]
		public event Action<MinionAttackServerCancelationEvt> MinionAttackServerCancelationEvent
		{
			[Token(Token = "0x6000421")]
			[Address(RVA = "0x584E", Offset = "0x584E", VA = "0x584E")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000422")]
			[Address(RVA = "0x584F", Offset = "0x584F", VA = "0x584F")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06000423 RID: 1059 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000423")]
		[Address(RVA = "0x5850", Offset = "0x5850", VA = "0x5850", Slot = "6")]
		protected override void ServerEventHandler(SrvAnswer evt)
		{
		}

		// Token: 0x06000424 RID: 1060 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000424")]
		[Address(RVA = "0x5851", Offset = "0x5851", VA = "0x5851")]
		public OpToken<IMessage, object> GetInstanceList()
		{
			return null;
		}

		// Token: 0x06000425 RID: 1061 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000425")]
		[Address(RVA = "0x5852", Offset = "0x5852", VA = "0x5852")]
		public OpToken<IMessage, object> CreateTeam()
		{
			return null;
		}

		// Token: 0x06000426 RID: 1062 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000426")]
		[Address(RVA = "0x5853", Offset = "0x5853", VA = "0x5853")]
		public OpToken<IMessage, object> InviteAssistant(ulong userId)
		{
			return null;
		}

		// Token: 0x06000427 RID: 1063 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000427")]
		[Address(RVA = "0x5854", Offset = "0x5854", VA = "0x5854")]
		public OpToken<IMessage, object> KickAssistant(long instanceId, ulong userId)
		{
			return null;
		}

		// Token: 0x06000428 RID: 1064 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000428")]
		[Address(RVA = "0x5855", Offset = "0x5855", VA = "0x5855")]
		public OpToken<IMessage, object> AcceptInvitation(long instanceId, ulong userId)
		{
			return null;
		}

		// Token: 0x06000429 RID: 1065 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000429")]
		[Address(RVA = "0x5856", Offset = "0x5856", VA = "0x5856")]
		public OpToken<IMessage, object> RefuseInvitation(long instanceId, ulong userId)
		{
			return null;
		}

		// Token: 0x0600042A RID: 1066 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600042A")]
		[Address(RVA = "0x5857", Offset = "0x5857", VA = "0x5857")]
		public OpToken<IMessage, object> GetTeamInfo(long instanceId, ulong teamId)
		{
			return null;
		}

		// Token: 0x0600042B RID: 1067 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600042B")]
		[Address(RVA = "0x5858", Offset = "0x5858", VA = "0x5858")]
		public OpToken<IMessage, object> GetActiveTeamInfo(long instanceId, ulong captainId)
		{
			return null;
		}

		// Token: 0x0600042C RID: 1068 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600042C")]
		[Address(RVA = "0x5859", Offset = "0x5859", VA = "0x5859")]
		public OpToken<IMessage, object> DistributeRewards(long instanceId, ulong teamId, List<DistributeRewardsCmd.Types.UserReward> userRewards)
		{
			return null;
		}

		// Token: 0x0600042D RID: 1069 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600042D")]
		[Address(RVA = "0x585A", Offset = "0x585A", VA = "0x585A")]
		public OpToken<IMessage, object> GetTeamRewards(long instanceId, ulong teamId)
		{
			return null;
		}

		// Token: 0x0600042E RID: 1070 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600042E")]
		[Address(RVA = "0x585B", Offset = "0x585B", VA = "0x585B")]
		public OpToken<IMessage, object> BeginBattle(long optionId, int variantId)
		{
			return null;
		}

		// Token: 0x0600042F RID: 1071 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600042F")]
		[Address(RVA = "0x585C", Offset = "0x585C", VA = "0x585C")]
		public OpToken<IMessage, object> GetCaptainTeamList(long instanceId, ulong captainId)
		{
			return null;
		}

		// Token: 0x06000430 RID: 1072 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000430")]
		[Address(RVA = "0x585D", Offset = "0x585D", VA = "0x585D")]
		public OpToken<IMessage, object> GetRating(long instanceId)
		{
			return null;
		}

		// Token: 0x06000431 RID: 1073 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000431")]
		[Address(RVA = "0x585E", Offset = "0x585E", VA = "0x585E")]
		public OpToken<IMessage, object> BuyLicence()
		{
			return null;
		}

		// Token: 0x06000432 RID: 1074 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000432")]
		[Address(RVA = "0x585F", Offset = "0x585F", VA = "0x585F")]
		public OpToken<IMessage, object> GetPlace(long instanceId)
		{
			return null;
		}

		// Token: 0x06000433 RID: 1075 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000433")]
		[Address(RVA = "0x5860", Offset = "0x5860", VA = "0x5860")]
		public OpToken<IMessage, object> GetPossibleMercenaries(long instanceId)
		{
			return null;
		}

		// Token: 0x06000434 RID: 1076 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000434")]
		[Address(RVA = "0x5861", Offset = "0x5861", VA = "0x5861")]
		public OpToken<IMessage, object> ReadyToListen()
		{
			return null;
		}

		// Token: 0x06000435 RID: 1077 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000435")]
		[Address(RVA = "0x5862", Offset = "0x5862", VA = "0x5862")]
		public OpToken<IMessage, object> MinionAttackCancel()
		{
			return null;
		}

		// Token: 0x06000436 RID: 1078 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000436")]
		[Address(RVA = "0x5863", Offset = "0x5863", VA = "0x5863")]
		public OpToken<IMessage, object> MinionJumpToCombat()
		{
			return null;
		}

		// Token: 0x06000437 RID: 1079 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000437")]
		[Address(RVA = "0x5864", Offset = "0x5864", VA = "0x5864")]
		public BossService()
		{
		}
	}
}
