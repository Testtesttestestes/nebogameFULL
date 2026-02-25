using System;
using Il2CppDummyDll;

namespace Gameplay.GameEvents.Model.Tags
{
	// Token: 0x0200079F RID: 1951
	[Token(Token = "0x200079F")]
	public class CultTag_13 : AbstractTag
	{
		// Token: 0x170008F5 RID: 2293
		// (get) Token: 0x06002E61 RID: 11873 RVA: 0x00009108 File Offset: 0x00007308
		[Token(Token = "0x170008F5")]
		public uint CultId
		{
			[Token(Token = "0x6002E61")]
			[Address(RVA = "0x7EDC", Offset = "0x7EDC", VA = "0x7EDC")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x06002E62 RID: 11874 RVA: 0x00009120 File Offset: 0x00007320
		[Token(Token = "0x6002E62")]
		[Address(RVA = "0x7EDD", Offset = "0x7EDD", VA = "0x7EDD", Slot = "7")]
		public override bool TryGetValue(string tagName, GameEventData evtData, out string value, AbstractTag.TagViewHandler viewHandler)
		{
			return default(bool);
		}

		// Token: 0x06002E63 RID: 11875 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E63")]
		[Address(RVA = "0x7EDE", Offset = "0x7EDE", VA = "0x7EDE")]
		public CultTag_13()
		{
		}
	}
}
