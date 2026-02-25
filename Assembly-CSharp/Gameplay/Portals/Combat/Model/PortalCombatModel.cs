using System;
using Core.Data;
using Core.Gameplay;
using Gameplay.Combat.Model;
using Il2CppDummyDll;
using Protocol.Common;
using Utils;

namespace Gameplay.Portals.Combat.Model
{
	// Token: 0x020005EC RID: 1516
	[Token(Token = "0x20005EC")]
	public class PortalCombatModel : CombatModel
	{
		// Token: 0x060024C7 RID: 9415 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024C7")]
		[Address(RVA = "0x7615", Offset = "0x7615", VA = "0x7615")]
		public PortalCombatModel(IPortal portal, IBalance balance, IMonsterSource monsterSource, IGame game, CombatDependencies dependencies, BackTime awaitBackTime, UserData loggedUser, UserData user)
		{
		}

		// Token: 0x060024C8 RID: 9416 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024C8")]
		[Address(RVA = "0x7616", Offset = "0x7616", VA = "0x7616")]
		public void SetNextCombatCost(ResourceSet value)
		{
		}

		// Token: 0x060024C9 RID: 9417 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60024C9")]
		[Address(RVA = "0x7617", Offset = "0x7617", VA = "0x7617", Slot = "12")]
		public override ResourceSet GetNextCombatCost()
		{
			return null;
		}

		// Token: 0x04001412 RID: 5138
		[Token(Token = "0x4001412")]
		[FieldOffset(Offset = "0x5C")]
		public readonly IGame Game;

		// Token: 0x04001413 RID: 5139
		[Token(Token = "0x4001413")]
		[FieldOffset(Offset = "0x60")]
		public readonly IBalance Balance;

		// Token: 0x04001414 RID: 5140
		[Token(Token = "0x4001414")]
		[FieldOffset(Offset = "0x64")]
		public readonly IPortal Portal;

		// Token: 0x04001415 RID: 5141
		[Token(Token = "0x4001415")]
		[FieldOffset(Offset = "0x68")]
		public readonly IMonsterSource MonsterSource;

		// Token: 0x04001416 RID: 5142
		[Token(Token = "0x4001416")]
		[FieldOffset(Offset = "0x6C")]
		private ResourceSet _nextCombatCost;
	}
}
