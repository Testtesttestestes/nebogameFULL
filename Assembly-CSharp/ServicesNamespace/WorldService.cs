using System;
using System.Runtime.CompilerServices;
using Core.Net;
using Google.Protobuf;
using Il2CppDummyDll;
using Protocol.World;
using Utils;

namespace ServicesNamespace
{
	// Token: 0x020000B2 RID: 178
	[Token(Token = "0x20000B2")]
	public class WorldService : AbstractService
	{
		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x060006C6 RID: 1734 RVA: 0x00003198 File Offset: 0x00001398
		[Token(Token = "0x170000B5")]
		public override short ServiceId
		{
			[Token(Token = "0x60006C6")]
			[Address(RVA = "0x5AC3", Offset = "0x5AC3", VA = "0x5AC3", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x140000B3 RID: 179
		// (add) Token: 0x060006C7 RID: 1735 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060006C8 RID: 1736 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000B3")]
		public event Action<ProtoBuildingAcceleratedEvt> BuildingAcceleratedEvent
		{
			[Token(Token = "0x60006C7")]
			[Address(RVA = "0x5AC4", Offset = "0x5AC4", VA = "0x5AC4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60006C8")]
			[Address(RVA = "0x5AC5", Offset = "0x5AC5", VA = "0x5AC5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140000B4 RID: 180
		// (add) Token: 0x060006C9 RID: 1737 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060006CA RID: 1738 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000B4")]
		public event Action<ProtoBuildingFinishedEvt> BuildingFinishedEvent
		{
			[Token(Token = "0x60006C9")]
			[Address(RVA = "0x5AC6", Offset = "0x5AC6", VA = "0x5AC6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60006CA")]
			[Address(RVA = "0x5AC7", Offset = "0x5AC7", VA = "0x5AC7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140000B5 RID: 181
		// (add) Token: 0x060006CB RID: 1739 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060006CC RID: 1740 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000B5")]
		public event Action<ProtoBuildingCanceledEvt> BuildingCanceledEvent
		{
			[Token(Token = "0x60006CB")]
			[Address(RVA = "0x5AC8", Offset = "0x5AC8", VA = "0x5AC8")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60006CC")]
			[Address(RVA = "0x5AC9", Offset = "0x5AC9", VA = "0x5AC9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140000B6 RID: 182
		// (add) Token: 0x060006CD RID: 1741 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060006CE RID: 1742 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000B6")]
		public event Action<ProtoBuildingStartedEvt> BuildingStartedEvent
		{
			[Token(Token = "0x60006CD")]
			[Address(RVA = "0x5ACA", Offset = "0x5ACA", VA = "0x5ACA")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60006CE")]
			[Address(RVA = "0x5ACB", Offset = "0x5ACB", VA = "0x5ACB")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140000B7 RID: 183
		// (add) Token: 0x060006CF RID: 1743 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060006D0 RID: 1744 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000B7")]
		public event Action<ProtoGoHomeEvt> GoHomeEvent
		{
			[Token(Token = "0x60006CF")]
			[Address(RVA = "0x5ACC", Offset = "0x5ACC", VA = "0x5ACC")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60006D0")]
			[Address(RVA = "0x5ACD", Offset = "0x5ACD", VA = "0x5ACD")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140000B8 RID: 184
		// (add) Token: 0x060006D1 RID: 1745 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060006D2 RID: 1746 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000B8")]
		public event Action<ProtoUserAprChangedEvt> UserAprChangedEvent
		{
			[Token(Token = "0x60006D1")]
			[Address(RVA = "0x5ACE", Offset = "0x5ACE", VA = "0x5ACE")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60006D2")]
			[Address(RVA = "0x5ACF", Offset = "0x5ACF", VA = "0x5ACF")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140000B9 RID: 185
		// (add) Token: 0x060006D3 RID: 1747 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060006D4 RID: 1748 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000B9")]
		public event Action<ProtoAnimationStartedEvt> AnimationStartedEvent
		{
			[Token(Token = "0x60006D3")]
			[Address(RVA = "0x5AD0", Offset = "0x5AD0", VA = "0x5AD0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60006D4")]
			[Address(RVA = "0x5AD1", Offset = "0x5AD1", VA = "0x5AD1")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140000BA RID: 186
		// (add) Token: 0x060006D5 RID: 1749 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060006D6 RID: 1750 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000BA")]
		public event Action<ProtoIsleMonsterInfoChangedEvt> IsleMonsterInfoChangedEvent
		{
			[Token(Token = "0x60006D5")]
			[Address(RVA = "0x5AD2", Offset = "0x5AD2", VA = "0x5AD2")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60006D6")]
			[Address(RVA = "0x5AD3", Offset = "0x5AD3", VA = "0x5AD3")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140000BB RID: 187
		// (add) Token: 0x060006D7 RID: 1751 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060006D8 RID: 1752 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000BB")]
		public event Action<ProtoUserIsleBuildingViewChangedEvt> UserIsleBuildingViewChangedEvent
		{
			[Token(Token = "0x60006D7")]
			[Address(RVA = "0x5AD4", Offset = "0x5AD4", VA = "0x5AD4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60006D8")]
			[Address(RVA = "0x5AD5", Offset = "0x5AD5", VA = "0x5AD5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140000BC RID: 188
		// (add) Token: 0x060006D9 RID: 1753 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060006DA RID: 1754 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000BC")]
		public event Action<ProtoUserIsleDecorationAddedEvt> UserIsleDecorationAddedEvent
		{
			[Token(Token = "0x60006D9")]
			[Address(RVA = "0x5AD6", Offset = "0x5AD6", VA = "0x5AD6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60006DA")]
			[Address(RVA = "0x5AD7", Offset = "0x5AD7", VA = "0x5AD7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140000BD RID: 189
		// (add) Token: 0x060006DB RID: 1755 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060006DC RID: 1756 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000BD")]
		public event Action<ProtoUserIsleDecorationRemovedEvt> UserIsleDecorationRemovedEvent
		{
			[Token(Token = "0x60006DB")]
			[Address(RVA = "0x5AD8", Offset = "0x5AD8", VA = "0x5AD8")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60006DC")]
			[Address(RVA = "0x5AD9", Offset = "0x5AD9", VA = "0x5AD9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140000BE RID: 190
		// (add) Token: 0x060006DD RID: 1757 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060006DE RID: 1758 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000BE")]
		public event Action<ProtoIsleMonsterFlewAwayEvt> IsleMonsterFlewAwayEvent
		{
			[Token(Token = "0x60006DD")]
			[Address(RVA = "0x5ADA", Offset = "0x5ADA", VA = "0x5ADA")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60006DE")]
			[Address(RVA = "0x5ADB", Offset = "0x5ADB", VA = "0x5ADB")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x060006DF RID: 1759 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006DF")]
		[Address(RVA = "0x5ADC", Offset = "0x5ADC", VA = "0x5ADC", Slot = "6")]
		protected override void ServerEventHandler(SrvAnswer evt)
		{
		}

		// Token: 0x060006E0 RID: 1760 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60006E0")]
		[Address(RVA = "0x5ADD", Offset = "0x5ADD", VA = "0x5ADD")]
		public OpToken<IMessage, object> GetUserIsleInfo(ulong userId, ProtoGetUserIsleInfoCmd.Types.RequestedTypeInfo flag)
		{
			return null;
		}

		// Token: 0x060006E1 RID: 1761 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60006E1")]
		[Address(RVA = "0x5ADE", Offset = "0x5ADE", VA = "0x5ADE")]
		public OpToken<IMessage, object> AttackMonster(ulong ownerId)
		{
			return null;
		}

		// Token: 0x060006E2 RID: 1762 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60006E2")]
		[Address(RVA = "0x5ADF", Offset = "0x5ADF", VA = "0x5ADF")]
		public OpToken<IMessage, object> KickMonster(ulong ownerId, uint monsterId)
		{
			return null;
		}

		// Token: 0x060006E3 RID: 1763 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60006E3")]
		[Address(RVA = "0x5AE0", Offset = "0x5AE0", VA = "0x5AE0")]
		public OpToken<IMessage, object> GetMonsterInfo(ulong ownerId)
		{
			return null;
		}

		// Token: 0x060006E4 RID: 1764 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60006E4")]
		[Address(RVA = "0x5AE1", Offset = "0x5AE1", VA = "0x5AE1")]
		public OpToken<IMessage, object> StartBuilding(uint buildingType)
		{
			return null;
		}

		// Token: 0x060006E5 RID: 1765 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60006E5")]
		[Address(RVA = "0x5AE2", Offset = "0x5AE2", VA = "0x5AE2")]
		public OpToken<IMessage, object> AccelerateBuilding(ulong ownerId, uint buildingType)
		{
			return null;
		}

		// Token: 0x060006E6 RID: 1766 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60006E6")]
		[Address(RVA = "0x5AE3", Offset = "0x5AE3", VA = "0x5AE3")]
		public OpToken<IMessage, object> CancelBuilding(uint buildingType)
		{
			return null;
		}

		// Token: 0x060006E7 RID: 1767 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60006E7")]
		[Address(RVA = "0x5AE4", Offset = "0x5AE4", VA = "0x5AE4")]
		public OpToken<IMessage, object> GetAnimationsInfo()
		{
			return null;
		}

		// Token: 0x060006E8 RID: 1768 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60006E8")]
		[Address(RVA = "0x5AE5", Offset = "0x5AE5", VA = "0x5AE5")]
		public OpToken<IMessage, object> StartAnimation(uint animationId, ulong ownerId, uint launchesAtTime)
		{
			return null;
		}

		// Token: 0x060006E9 RID: 1769 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60006E9")]
		[Address(RVA = "0x5AE6", Offset = "0x5AE6", VA = "0x5AE6")]
		public OpToken<IMessage, object> KickFromIsle(ulong userId)
		{
			return null;
		}

		// Token: 0x060006EA RID: 1770 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60006EA")]
		[Address(RVA = "0x5AE7", Offset = "0x5AE7", VA = "0x5AE7")]
		public OpToken<IMessage, object> GetHordeInfo(bool isCave)
		{
			return null;
		}

		// Token: 0x060006EB RID: 1771 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60006EB")]
		[Address(RVA = "0x5AE8", Offset = "0x5AE8", VA = "0x5AE8")]
		public OpToken<IMessage, object> ExitHorde(bool isCave)
		{
			return null;
		}

		// Token: 0x060006EC RID: 1772 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006EC")]
		[Address(RVA = "0x5AE9", Offset = "0x5AE9", VA = "0x5AE9")]
		public WorldService()
		{
		}
	}
}
