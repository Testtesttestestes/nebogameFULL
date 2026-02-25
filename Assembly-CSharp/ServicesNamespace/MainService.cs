using System;
using System.Runtime.CompilerServices;
using Core.Net;
using Google.Protobuf;
using Il2CppDummyDll;
using Protocol.Main;
using Utils;

namespace ServicesNamespace
{
	// Token: 0x020000A2 RID: 162
	[Token(Token = "0x20000A2")]
	public class MainService : AbstractService
	{
		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x060005A4 RID: 1444 RVA: 0x00003018 File Offset: 0x00001218
		[Token(Token = "0x170000A5")]
		public override short ServiceId
		{
			[Token(Token = "0x60005A4")]
			[Address(RVA = "0x59A9", Offset = "0x59A9", VA = "0x59A9", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x14000081 RID: 129
		// (add) Token: 0x060005A5 RID: 1445 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060005A6 RID: 1446 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000081")]
		public event Action<ProtoTriggersChangedEvt> TriggersChangedEvent
		{
			[Token(Token = "0x60005A5")]
			[Address(RVA = "0x59AA", Offset = "0x59AA", VA = "0x59AA")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60005A6")]
			[Address(RVA = "0x59AB", Offset = "0x59AB", VA = "0x59AB")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000082 RID: 130
		// (add) Token: 0x060005A7 RID: 1447 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060005A8 RID: 1448 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000082")]
		public event Action<ProtoNewLevelEvt> NewLevelEvent
		{
			[Token(Token = "0x60005A7")]
			[Address(RVA = "0x59AC", Offset = "0x59AC", VA = "0x59AC")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60005A8")]
			[Address(RVA = "0x59AD", Offset = "0x59AD", VA = "0x59AD")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000083 RID: 131
		// (add) Token: 0x060005A9 RID: 1449 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060005AA RID: 1450 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000083")]
		public event Action<ProtoExperienceChangedEvt> ExpChangedEvent
		{
			[Token(Token = "0x60005A9")]
			[Address(RVA = "0x59AE", Offset = "0x59AE", VA = "0x59AE")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60005AA")]
			[Address(RVA = "0x59AF", Offset = "0x59AF", VA = "0x59AF")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000084 RID: 132
		// (add) Token: 0x060005AB RID: 1451 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060005AC RID: 1452 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000084")]
		public event Action<ProtoDictionariesUpdatedEvt> DictionariesUpdatedEvent
		{
			[Token(Token = "0x60005AB")]
			[Address(RVA = "0x2286", Offset = "0x2286", VA = "0x2286")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60005AC")]
			[Address(RVA = "0x59B0", Offset = "0x59B0", VA = "0x59B0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000085 RID: 133
		// (add) Token: 0x060005AD RID: 1453 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060005AE RID: 1454 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000085")]
		public event Action<ProtoInventoryChangedEvt> InventoryChangedEvent
		{
			[Token(Token = "0x60005AD")]
			[Address(RVA = "0x59B1", Offset = "0x59B1", VA = "0x59B1")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60005AE")]
			[Address(RVA = "0x59B2", Offset = "0x59B2", VA = "0x59B2")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000086 RID: 134
		// (add) Token: 0x060005AF RID: 1455 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060005B0 RID: 1456 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000086")]
		public event Action<ProtoNewMedalsEvt> NewMedalsEvent
		{
			[Token(Token = "0x60005AF")]
			[Address(RVA = "0x59B3", Offset = "0x59B3", VA = "0x59B3")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60005B0")]
			[Address(RVA = "0x59B4", Offset = "0x59B4", VA = "0x59B4")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000087 RID: 135
		// (add) Token: 0x060005B1 RID: 1457 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060005B2 RID: 1458 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000087")]
		public event Action<ProtoTakeOffMedalsEvt> TakeOffMedalsEvent
		{
			[Token(Token = "0x60005B1")]
			[Address(RVA = "0x59B5", Offset = "0x59B5", VA = "0x59B5")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60005B2")]
			[Address(RVA = "0x59B6", Offset = "0x59B6", VA = "0x59B6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000088 RID: 136
		// (add) Token: 0x060005B3 RID: 1459 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060005B4 RID: 1460 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000088")]
		public event Action<ProtoSkillsChangedEvt> SkillsChangedEvent
		{
			[Token(Token = "0x60005B3")]
			[Address(RVA = "0x59B7", Offset = "0x59B7", VA = "0x59B7")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60005B4")]
			[Address(RVA = "0x59B8", Offset = "0x59B8", VA = "0x59B8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x060005B5 RID: 1461 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005B5")]
		[Address(RVA = "0x59B9", Offset = "0x59B9", VA = "0x59B9", Slot = "6")]
		protected override void ServerEventHandler(SrvAnswer evt)
		{
		}

		// Token: 0x060005B6 RID: 1462 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005B6")]
		[Address(RVA = "0x59BA", Offset = "0x59BA", VA = "0x59BA")]
		public OpToken<IMessage, object> GetUserSkills(ulong userId)
		{
			return null;
		}

		// Token: 0x060005B7 RID: 1463 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005B7")]
		[Address(RVA = "0x59BB", Offset = "0x59BB", VA = "0x59BB")]
		public OpToken<IMessage, object> GetUserMedals(ulong userId)
		{
			return null;
		}

		// Token: 0x060005B8 RID: 1464 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005B8")]
		[Address(RVA = "0x1E25", Offset = "0x1E25", VA = "0x1E25")]
		public OpToken<IMessage, object> GetUserStats(ulong userId)
		{
			return null;
		}

		// Token: 0x060005B9 RID: 1465 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005B9")]
		[Address(RVA = "0x59BC", Offset = "0x59BC", VA = "0x59BC")]
		public OpToken<IMessage, object> GetUserInfo()
		{
			return null;
		}

		// Token: 0x060005BA RID: 1466 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005BA")]
		[Address(RVA = "0x59BD", Offset = "0x59BD", VA = "0x59BD")]
		public OpToken<IMessage, object> GetShortUserInfo(params ulong[] ids)
		{
			return null;
		}

		// Token: 0x060005BB RID: 1467 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005BB")]
		[Address(RVA = "0x59BE", Offset = "0x59BE", VA = "0x59BE")]
		public OpToken<IMessage, object> GetClientState()
		{
			return null;
		}

		// Token: 0x060005BC RID: 1468 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005BC")]
		[Address(RVA = "0x59BF", Offset = "0x59BF", VA = "0x59BF")]
		public OpToken<IMessage, object> GetUserArtifacts(ulong userId)
		{
			return null;
		}

		// Token: 0x060005BD RID: 1469 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005BD")]
		[Address(RVA = "0x59C0", Offset = "0x59C0", VA = "0x59C0")]
		public OpToken<IMessage, object> SellArtifact(int slotId)
		{
			return null;
		}

		// Token: 0x060005BE RID: 1470 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005BE")]
		[Address(RVA = "0x59C1", Offset = "0x59C1", VA = "0x59C1")]
		public OpToken<IMessage, object> Ping()
		{
			return null;
		}

		// Token: 0x060005BF RID: 1471 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005BF")]
		[Address(RVA = "0x59C2", Offset = "0x59C2", VA = "0x59C2")]
		public OpToken<IMessage, object> SwapSlots(int slotIdFrom, int slotIdTo)
		{
			return null;
		}

		// Token: 0x060005C0 RID: 1472 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005C0")]
		[Address(RVA = "0x59C3", Offset = "0x59C3", VA = "0x59C3")]
		public OpToken<IMessage, object> InitComplete()
		{
			return null;
		}

		// Token: 0x060005C1 RID: 1473 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005C1")]
		[Address(RVA = "0x59C4", Offset = "0x59C4", VA = "0x59C4")]
		public OpToken<IMessage, object> GetLastDrop(DropTypes dropType)
		{
			return null;
		}

		// Token: 0x060005C2 RID: 1474 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005C2")]
		[Address(RVA = "0x59C5", Offset = "0x59C5", VA = "0x59C5")]
		public OpToken<IMessage, object> TakeArtifactFromDrop(DropTypes dropType, uint startSlotId, params ulong[] artifactIds)
		{
			return null;
		}

		// Token: 0x060005C3 RID: 1475 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005C3")]
		[Address(RVA = "0x59C6", Offset = "0x59C6", VA = "0x59C6")]
		public OpToken<IMessage, object> SellArtifactFromDrop(ulong[] artifactIds)
		{
			return null;
		}

		// Token: 0x060005C4 RID: 1476 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005C4")]
		[Address(RVA = "0x59C7", Offset = "0x59C7", VA = "0x59C7")]
		public OpToken<IMessage, object> TakeAllDrop(DropTypes dropType)
		{
			return null;
		}

		// Token: 0x060005C5 RID: 1477 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005C5")]
		[Address(RVA = "0x59C8", Offset = "0x59C8", VA = "0x59C8")]
		public OpToken<IMessage, object> SellAllFromDrop(DropTypes dropType)
		{
			return null;
		}

		// Token: 0x060005C6 RID: 1478 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005C6")]
		[Address(RVA = "0x59C9", Offset = "0x59C9", VA = "0x59C9")]
		public OpToken<IMessage, object> SetUserId(ulong userId)
		{
			return null;
		}

		// Token: 0x060005C7 RID: 1479 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005C7")]
		[Address(RVA = "0x59CA", Offset = "0x59CA", VA = "0x59CA")]
		public OpToken<IMessage, object> ChangeFavoriteArtifact(ulong artifactId, bool favorite)
		{
			return null;
		}

		// Token: 0x060005C8 RID: 1480 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005C8")]
		[Address(RVA = "0x59CB", Offset = "0x59CB", VA = "0x59CB")]
		public OpToken<IMessage, object> SetMedalsVisibility(bool hideMedals, bool hideAprs)
		{
			return null;
		}

		// Token: 0x060005C9 RID: 1481 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005C9")]
		[Address(RVA = "0x59CC", Offset = "0x59CC", VA = "0x59CC")]
		public OpToken<IMessage, object> MergeAllStackableItems(uint slotId)
		{
			return null;
		}

		// Token: 0x060005CA RID: 1482 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005CA")]
		[Address(RVA = "0x59CD", Offset = "0x59CD", VA = "0x59CD")]
		public OpToken<IMessage, object> SplitStackableItems(uint slotId, uint quantity)
		{
			return null;
		}

		// Token: 0x060005CB RID: 1483 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005CB")]
		[Address(RVA = "0x59CE", Offset = "0x59CE", VA = "0x59CE")]
		public OpToken<IMessage, object> UserSettingsSave(string settings)
		{
			return null;
		}

		// Token: 0x060005CC RID: 1484 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005CC")]
		[Address(RVA = "0x59CF", Offset = "0x59CF", VA = "0x59CF")]
		public OpToken<IMessage, object> GetGameEventsRewardsInfo(uint eventId)
		{
			return null;
		}

		// Token: 0x060005CD RID: 1485 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005CD")]
		[Address(RVA = "0x59D0", Offset = "0x59D0", VA = "0x59D0")]
		public OpToken<IMessage, object> GetEventMilestonesRewardsInfo(uint eventId, params uint[] milestoneNumbers)
		{
			return null;
		}

		// Token: 0x060005CE RID: 1486 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005CE")]
		[Address(RVA = "0x59D1", Offset = "0x59D1", VA = "0x59D1")]
		public OpToken<IMessage, object> GetUserLevelReward()
		{
			return null;
		}

		// Token: 0x060005CF RID: 1487 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005CF")]
		[Address(RVA = "0x59D2", Offset = "0x59D2", VA = "0x59D2")]
		public OpToken<IMessage, object> GetUserAntiqArtifacts()
		{
			return null;
		}

		// Token: 0x060005D0 RID: 1488 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005D0")]
		[Address(RVA = "0x59D3", Offset = "0x59D3", VA = "0x59D3")]
		public OpToken<IMessage, object> GetUserExperiments()
		{
			return null;
		}

		// Token: 0x060005D1 RID: 1489 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005D1")]
		[Address(RVA = "0x59D4", Offset = "0x59D4", VA = "0x59D4")]
		public void SetLevel(ProtoNewLevelEvt msg)
		{
		}

		// Token: 0x060005D2 RID: 1490 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005D2")]
		[Address(RVA = "0x59D5", Offset = "0x59D5", VA = "0x59D5")]
		public MainService()
		{
		}
	}
}
