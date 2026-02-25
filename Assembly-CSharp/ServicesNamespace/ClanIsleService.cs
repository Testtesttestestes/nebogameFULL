using System;
using System.Runtime.CompilerServices;
using Core.Net;
using Google.Protobuf;
using Il2CppDummyDll;
using Protocol.ClanIsle;
using Protocol.Consts;
using Utils;

namespace ServicesNamespace
{
	// Token: 0x02000093 RID: 147
	[Token(Token = "0x2000093")]
	public class ClanIsleService : AbstractService
	{
		// Token: 0x17000097 RID: 151
		// (get) Token: 0x06000468 RID: 1128 RVA: 0x00002EC8 File Offset: 0x000010C8
		[Token(Token = "0x17000097")]
		public override short ServiceId
		{
			[Token(Token = "0x6000468")]
			[Address(RVA = "0x5893", Offset = "0x5893", VA = "0x5893", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x14000036 RID: 54
		// (add) Token: 0x06000469 RID: 1129 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600046A RID: 1130 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000036")]
		public event Action<ProtoBuildingAcceleratedEvt> BuildingAcceleratedEvent
		{
			[Token(Token = "0x6000469")]
			[Address(RVA = "0x5894", Offset = "0x5894", VA = "0x5894")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600046A")]
			[Address(RVA = "0x5895", Offset = "0x5895", VA = "0x5895")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000037 RID: 55
		// (add) Token: 0x0600046B RID: 1131 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600046C RID: 1132 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000037")]
		public event Action<ProtoBuildingFinishedEvt> BuildingFinishedEvent
		{
			[Token(Token = "0x600046B")]
			[Address(RVA = "0x5896", Offset = "0x5896", VA = "0x5896")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600046C")]
			[Address(RVA = "0x5897", Offset = "0x5897", VA = "0x5897")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000038 RID: 56
		// (add) Token: 0x0600046D RID: 1133 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600046E RID: 1134 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000038")]
		public event Action<ProtoBuildingStartedEvt> BuildingStartedEvent
		{
			[Token(Token = "0x600046D")]
			[Address(RVA = "0x5898", Offset = "0x5898", VA = "0x5898")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600046E")]
			[Address(RVA = "0x5899", Offset = "0x5899", VA = "0x5899")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000039 RID: 57
		// (add) Token: 0x0600046F RID: 1135 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000470 RID: 1136 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000039")]
		public event Action<ProtoBuildingCanceledEvt> BuildingCanceledEvent
		{
			[Token(Token = "0x600046F")]
			[Address(RVA = "0x589A", Offset = "0x589A", VA = "0x589A")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000470")]
			[Address(RVA = "0x589B", Offset = "0x589B", VA = "0x589B")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400003A RID: 58
		// (add) Token: 0x06000471 RID: 1137 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000472 RID: 1138 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400003A")]
		public event Action<ProtoGolemStateChangedEvt> GolemStateChangedEvent
		{
			[Token(Token = "0x6000471")]
			[Address(RVA = "0x589C", Offset = "0x589C", VA = "0x589C")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000472")]
			[Address(RVA = "0x589D", Offset = "0x589D", VA = "0x589D")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400003B RID: 59
		// (add) Token: 0x06000473 RID: 1139 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000474 RID: 1140 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400003B")]
		public event Action<ProtoClanRemovedEvt> ClanRemovedEvent
		{
			[Token(Token = "0x6000473")]
			[Address(RVA = "0x589E", Offset = "0x589E", VA = "0x589E")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000474")]
			[Address(RVA = "0x589F", Offset = "0x589F", VA = "0x589F")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06000475 RID: 1141 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000475")]
		[Address(RVA = "0x58A0", Offset = "0x58A0", VA = "0x58A0", Slot = "6")]
		protected override void ServerEventHandler(SrvAnswer evt)
		{
		}

		// Token: 0x06000476 RID: 1142 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000476")]
		[Address(RVA = "0x58A1", Offset = "0x58A1", VA = "0x58A1")]
		public OpToken<IMessage, object> GetClanIsleInfo(ulong clanId, uint flags)
		{
			return null;
		}

		// Token: 0x06000477 RID: 1143 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000477")]
		[Address(RVA = "0x58A2", Offset = "0x58A2", VA = "0x58A2")]
		public OpToken<IMessage, object> StartClanBuild(ClanBuildingTypes typeId)
		{
			return null;
		}

		// Token: 0x06000478 RID: 1144 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000478")]
		[Address(RVA = "0x58A3", Offset = "0x58A3", VA = "0x58A3")]
		public OpToken<IMessage, object> AccelerateClanBuilding(ClanBuildingTypes typeId)
		{
			return null;
		}

		// Token: 0x06000479 RID: 1145 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000479")]
		[Address(RVA = "0x58A4", Offset = "0x58A4", VA = "0x58A4")]
		public OpToken<IMessage, object> CancelClanBuilding(ClanBuildingTypes typeId)
		{
			return null;
		}

		// Token: 0x0600047A RID: 1146 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600047A")]
		[Address(RVA = "0x58A5", Offset = "0x58A5", VA = "0x58A5")]
		public OpToken<IMessage, object> KickFromIsle(ulong userId)
		{
			return null;
		}

		// Token: 0x0600047B RID: 1147 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600047B")]
		[Address(RVA = "0x58A6", Offset = "0x58A6", VA = "0x58A6")]
		public ClanIsleService()
		{
		}
	}
}
