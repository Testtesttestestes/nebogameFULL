using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Net;
using Google.Protobuf;
using Il2CppDummyDll;
using Protocol.Portal;
using Utils;

namespace ServicesNamespace
{
	// Token: 0x020000A5 RID: 165
	[Token(Token = "0x20000A5")]
	public class PortalsService : AbstractService
	{
		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x060005E2 RID: 1506 RVA: 0x00003060 File Offset: 0x00001260
		[Token(Token = "0x170000A8")]
		public override short ServiceId
		{
			[Token(Token = "0x60005E2")]
			[Address(RVA = "0x59E5", Offset = "0x59E5", VA = "0x59E5", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1400008C RID: 140
		// (add) Token: 0x060005E3 RID: 1507 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060005E4 RID: 1508 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400008C")]
		public event Action<ProtoPortalStartedEvt> OnProtoPortalStartedEvt
		{
			[Token(Token = "0x60005E3")]
			[Address(RVA = "0x59E6", Offset = "0x59E6", VA = "0x59E6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60005E4")]
			[Address(RVA = "0x59E7", Offset = "0x59E7", VA = "0x59E7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400008D RID: 141
		// (add) Token: 0x060005E5 RID: 1509 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060005E6 RID: 1510 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400008D")]
		public event Action<ProtoPortalDoneEvt> OnProtoPortalDoneEvt
		{
			[Token(Token = "0x60005E5")]
			[Address(RVA = "0x59E8", Offset = "0x59E8", VA = "0x59E8")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60005E6")]
			[Address(RVA = "0x59E9", Offset = "0x59E9", VA = "0x59E9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400008E RID: 142
		// (add) Token: 0x060005E7 RID: 1511 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060005E8 RID: 1512 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400008E")]
		public event Action<ProtoPortalStageInfoChangedEvt> OnProtoPortalStageInfoChangedEvt
		{
			[Token(Token = "0x60005E7")]
			[Address(RVA = "0x59EA", Offset = "0x59EA", VA = "0x59EA")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60005E8")]
			[Address(RVA = "0x59EB", Offset = "0x59EB", VA = "0x59EB")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400008F RID: 143
		// (add) Token: 0x060005E9 RID: 1513 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060005EA RID: 1514 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400008F")]
		public event Action<ProtoPortalUserBetChangedEvt> OnProtoPortalUserBetChangedEvt
		{
			[Token(Token = "0x60005E9")]
			[Address(RVA = "0x59EC", Offset = "0x59EC", VA = "0x59EC")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60005EA")]
			[Address(RVA = "0x59ED", Offset = "0x59ED", VA = "0x59ED")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000090 RID: 144
		// (add) Token: 0x060005EB RID: 1515 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060005EC RID: 1516 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000090")]
		public event Action<ProtoPortalUserInfoChangedEvt> OnProtoPortalUserInfoChangedEvt
		{
			[Token(Token = "0x60005EB")]
			[Address(RVA = "0x59EE", Offset = "0x59EE", VA = "0x59EE")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60005EC")]
			[Address(RVA = "0x59EF", Offset = "0x59EF", VA = "0x59EF")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000091 RID: 145
		// (add) Token: 0x060005ED RID: 1517 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060005EE RID: 1518 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000091")]
		public event Action<ProtoPortalMonsterInfoChangedEvt> OnProtoPortalMonsterInfoChangedEvt
		{
			[Token(Token = "0x60005ED")]
			[Address(RVA = "0x59F0", Offset = "0x59F0", VA = "0x59F0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60005EE")]
			[Address(RVA = "0x59F1", Offset = "0x59F1", VA = "0x59F1")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x060005EF RID: 1519 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005EF")]
		[Address(RVA = "0x59F2", Offset = "0x59F2", VA = "0x59F2", Slot = "6")]
		protected override void ServerEventHandler(SrvAnswer evt)
		{
		}

		// Token: 0x060005F0 RID: 1520 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005F0")]
		[Address(RVA = "0x59F3", Offset = "0x59F3", VA = "0x59F3")]
		public OpToken<IMessage, object> RegisterUser()
		{
			return null;
		}

		// Token: 0x060005F1 RID: 1521 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005F1")]
		[Address(RVA = "0x59F4", Offset = "0x59F4", VA = "0x59F4")]
		public OpToken<IMessage, object> Subscribe()
		{
			return null;
		}

		// Token: 0x060005F2 RID: 1522 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005F2")]
		[Address(RVA = "0x59F5", Offset = "0x59F5", VA = "0x59F5")]
		public OpToken<IMessage, object> Unsubscribe()
		{
			return null;
		}

		// Token: 0x060005F3 RID: 1523 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005F3")]
		[Address(RVA = "0x59F6", Offset = "0x59F6", VA = "0x59F6")]
		public OpToken<IMessage, object> GetPortalInfo()
		{
			return null;
		}

		// Token: 0x060005F4 RID: 1524 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005F4")]
		[Address(RVA = "0x59F7", Offset = "0x59F7", VA = "0x59F7")]
		public OpToken<IMessage, object> GetStageInfo()
		{
			return null;
		}

		// Token: 0x060005F5 RID: 1525 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005F5")]
		[Address(RVA = "0x59F8", Offset = "0x59F8", VA = "0x59F8")]
		public OpToken<IMessage, object> GetMonsterInfo()
		{
			return null;
		}

		// Token: 0x060005F6 RID: 1526 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005F6")]
		[Address(RVA = "0x59F9", Offset = "0x59F9", VA = "0x59F9")]
		public OpToken<IMessage, object> ComebackToStage()
		{
			return null;
		}

		// Token: 0x060005F7 RID: 1527 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005F7")]
		[Address(RVA = "0x59FA", Offset = "0x59FA", VA = "0x59FA")]
		public OpToken<IMessage, object> GetBetList(ulong id = 0UL)
		{
			return null;
		}

		// Token: 0x060005F8 RID: 1528 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005F8")]
		[Address(RVA = "0x59FB", Offset = "0x59FB", VA = "0x59FB")]
		public OpToken<IMessage, object> UpdateBetList()
		{
			return null;
		}

		// Token: 0x060005F9 RID: 1529 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005F9")]
		[Address(RVA = "0x59FC", Offset = "0x59FC", VA = "0x59FC")]
		public OpToken<IMessage, object> DoBet(IEnumerable<ProtoDoBetCmd.Types.BetChoice> bet)
		{
			return null;
		}

		// Token: 0x060005FA RID: 1530 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005FA")]
		[Address(RVA = "0x59FD", Offset = "0x59FD", VA = "0x59FD")]
		public OpToken<IMessage, object> GetBetsHistory()
		{
			return null;
		}

		// Token: 0x060005FB RID: 1531 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005FB")]
		[Address(RVA = "0x59FE", Offset = "0x59FE", VA = "0x59FE")]
		public OpToken<IMessage, object> GetStoreItemsInfo()
		{
			return null;
		}

		// Token: 0x060005FC RID: 1532 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005FC")]
		[Address(RVA = "0x59FF", Offset = "0x59FF", VA = "0x59FF")]
		public OpToken<IMessage, object> BuyShopItem(ulong price, ulong artId, uint destSlot)
		{
			return null;
		}

		// Token: 0x060005FD RID: 1533 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005FD")]
		[Address(RVA = "0x5A00", Offset = "0x5A00", VA = "0x5A00")]
		public OpToken<IMessage, object> RequestCombat()
		{
			return null;
		}

		// Token: 0x060005FE RID: 1534 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005FE")]
		[Address(RVA = "0x5A01", Offset = "0x5A01", VA = "0x5A01")]
		public OpToken<IMessage, object> GetBetPoolInfo()
		{
			return null;
		}

		// Token: 0x060005FF RID: 1535 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005FF")]
		[Address(RVA = "0x5A02", Offset = "0x5A02", VA = "0x5A02")]
		public OpToken<IMessage, object> GetJackpotInfo()
		{
			return null;
		}

		// Token: 0x06000600 RID: 1536 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000600")]
		[Address(RVA = "0x5A03", Offset = "0x5A03", VA = "0x5A03")]
		public PortalsService()
		{
		}
	}
}
