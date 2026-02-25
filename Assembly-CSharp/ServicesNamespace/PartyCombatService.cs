using System;
using System.Runtime.CompilerServices;
using Core.Net;
using Google.Protobuf;
using Il2CppDummyDll;
using Protocol.Combat;
using Protocol.Partycombat;
using Utils;

namespace ServicesNamespace
{
	// Token: 0x020000A4 RID: 164
	[Token(Token = "0x20000A4")]
	public class PartyCombatService : CombatService
	{
		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x060005D7 RID: 1495 RVA: 0x00003048 File Offset: 0x00001248
		[Token(Token = "0x170000A7")]
		public override short ServiceId
		{
			[Token(Token = "0x60005D7")]
			[Address(RVA = "0x59DA", Offset = "0x59DA", VA = "0x59DA", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x14000089 RID: 137
		// (add) Token: 0x060005D8 RID: 1496 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060005D9 RID: 1497 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000089")]
		public new event Action<Protocol.Partycombat.ProtoSkillsChangedEvt> SkillsChangedEvent
		{
			[Token(Token = "0x60005D8")]
			[Address(RVA = "0x59DB", Offset = "0x59DB", VA = "0x59DB")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60005D9")]
			[Address(RVA = "0x59DC", Offset = "0x59DC", VA = "0x59DC")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400008A RID: 138
		// (add) Token: 0x060005DA RID: 1498 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060005DB RID: 1499 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400008A")]
		public new event Action<Protocol.Partycombat.ProtoFieldChangedEvt> FieldChangedEvent
		{
			[Token(Token = "0x60005DA")]
			[Address(RVA = "0x59DD", Offset = "0x59DD", VA = "0x59DD")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60005DB")]
			[Address(RVA = "0x59DE", Offset = "0x59DE", VA = "0x59DE")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400008B RID: 139
		// (add) Token: 0x060005DC RID: 1500 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060005DD RID: 1501 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400008B")]
		public new event Action<Protocol.Partycombat.ProtoCombatCompleteEvt> CombatCompleteEvent
		{
			[Token(Token = "0x60005DC")]
			[Address(RVA = "0x59DF", Offset = "0x59DF", VA = "0x59DF")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60005DD")]
			[Address(RVA = "0x59E0", Offset = "0x59E0", VA = "0x59E0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x060005DE RID: 1502 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005DE")]
		[Address(RVA = "0x59E1", Offset = "0x59E1", VA = "0x59E1", Slot = "6")]
		protected override void ServerEventHandler(SrvAnswer evt)
		{
		}

		// Token: 0x060005DF RID: 1503 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005DF")]
		[Address(RVA = "0x59E2", Offset = "0x59E2", VA = "0x59E2")]
		public OpToken<IMessage, object> PutJoinRequest(CombatTypes combatType, params long[] parameters)
		{
			return null;
		}

		// Token: 0x060005E0 RID: 1504 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005E0")]
		[Address(RVA = "0x59E3", Offset = "0x59E3", VA = "0x59E3", Slot = "46")]
		public override OpToken<IMessage, object> JoinToCombat()
		{
			return null;
		}

		// Token: 0x060005E1 RID: 1505 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005E1")]
		[Address(RVA = "0x59E4", Offset = "0x59E4", VA = "0x59E4")]
		public PartyCombatService()
		{
		}
	}
}
