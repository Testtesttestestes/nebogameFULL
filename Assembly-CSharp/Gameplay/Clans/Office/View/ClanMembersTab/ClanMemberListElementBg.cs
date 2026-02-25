using System;
using Il2CppDummyDll;
using UI;
using UnityEngine;

namespace Gameplay.Clans.Office.View.ClanMembersTab
{
	// Token: 0x02000A38 RID: 2616
	[Token(Token = "0x2000A38")]
	[DisallowMultipleComponent]
	public class ClanMemberListElementBg : MonoBehaviourWithStates<ClanMemberListElementBg.States>
	{
		// Token: 0x06003DF1 RID: 15857 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DF1")]
		[Address(RVA = "0x8CB0", Offset = "0x8CB0", VA = "0x8CB0")]
		public ClanMemberListElementBg()
		{
		}

		// Token: 0x02000A39 RID: 2617
		[Token(Token = "0x2000A39")]
		public enum States
		{
			// Token: 0x040022C4 RID: 8900
			[Token(Token = "0x40022C4")]
			Regular,
			// Token: 0x040022C5 RID: 8901
			[Token(Token = "0x40022C5")]
			Blue
		}
	}
}
