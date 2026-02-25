using System;
using Gameplay.Isles.Base.View;
using Il2CppDummyDll;
using Protocol.Consts;
using UnityEngine;

namespace Gameplay.Isles.Clan.View
{
	// Token: 0x02000CF0 RID: 3312
	[Token(Token = "0x2000CF0")]
	public class ClanIsleBuildingView : BaseIsleBuildingView
	{
		// Token: 0x1700104B RID: 4171
		// (get) Token: 0x0600509A RID: 20634 RVA: 0x0000EBF8 File Offset: 0x0000CDF8
		[Token(Token = "0x1700104B")]
		public override uint Type
		{
			[Token(Token = "0x600509A")]
			[Address(RVA = "0x9EA9", Offset = "0x9EA9", VA = "0x9EA9", Slot = "10")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x0600509B RID: 20635 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600509B")]
		[Address(RVA = "0x9EAA", Offset = "0x9EAA", VA = "0x9EAA")]
		public ClanIsleBuildingView()
		{
		}

		// Token: 0x04002C0B RID: 11275
		[Token(Token = "0x4002C0B")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private ClanBuildingTypes _type;
	}
}
