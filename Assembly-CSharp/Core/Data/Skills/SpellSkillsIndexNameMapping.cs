using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Core.Data.Skills
{
	// Token: 0x020010D8 RID: 4312
	[Token(Token = "0x20010D8")]
	public static class SpellSkillsIndexNameMapping
	{
		// Token: 0x17001471 RID: 5233
		// (get) Token: 0x06006505 RID: 25861 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001471")]
		public static Dictionary<int, string> SkillsIndexNameDefinition
		{
			[Token(Token = "0x6006505")]
			[Address(RVA = "0xB0DD", Offset = "0xB0DD", VA = "0xB0DD")]
			get
			{
				return null;
			}
		}

		// Token: 0x040035DB RID: 13787
		[Token(Token = "0x40035DB")]
		public const string MANA_PRICE_NAME = "manaPrice";

		// Token: 0x040035DC RID: 13788
		[Token(Token = "0x40035DC")]
		public const string GAME_PRICE_NAME = "gamePrice";

		// Token: 0x040035DD RID: 13789
		[Token(Token = "0x40035DD")]
		public const string REAL_PRICE_NAME = "realPrice";

		// Token: 0x040035DE RID: 13790
		[Token(Token = "0x40035DE")]
		public const string COOL_DOWN_NAME = "coolDownTime";

		// Token: 0x040035DF RID: 13791
		[Token(Token = "0x40035DF")]
		public const string COOL_DOWN_SEC_NAME = "coolDownTimeSEC";

		// Token: 0x040035E0 RID: 13792
		[Token(Token = "0x40035E0")]
		public const string ENERGY_PRICE_NAME = "energyPrice";

		// Token: 0x040035E1 RID: 13793
		[Token(Token = "0x40035E1")]
		public const string NEW_RESOURCE_PRICE_NAME = "newResourcePrice";

		// Token: 0x040035E2 RID: 13794
		[Token(Token = "0x40035E2")]
		public const string BOOST_MAMA_PRICE_NAME = "boostManaPrice";

		// Token: 0x040035E3 RID: 13795
		[Token(Token = "0x40035E3")]
		public const string COLOSSUS_FRAGMENTS_PRICE_NAME = "colossusFragmentsPrice";

		// Token: 0x040035E4 RID: 13796
		[Token(Token = "0x40035E4")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<int, string> _skillsIndexNameDefinition;
	}
}
