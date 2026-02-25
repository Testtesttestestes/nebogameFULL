using System;
using Il2CppDummyDll;

namespace Gameplay.GameEvents.Model.Tags
{
	// Token: 0x02000797 RID: 1943
	[Token(Token = "0x2000797")]
	public class AccountTag_8 : AbstractTag
	{
		// Token: 0x170008EC RID: 2284
		// (get) Token: 0x06002E48 RID: 11848 RVA: 0x00008F70 File Offset: 0x00007170
		[Token(Token = "0x170008EC")]
		public uint AccountId
		{
			[Token(Token = "0x6002E48")]
			[Address(RVA = "0x7EC3", Offset = "0x7EC3", VA = "0x7EC3")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x06002E49 RID: 11849 RVA: 0x00008F88 File Offset: 0x00007188
		[Token(Token = "0x6002E49")]
		[Address(RVA = "0x7EC4", Offset = "0x7EC4", VA = "0x7EC4", Slot = "7")]
		public override bool TryGetValue(string tagName, GameEventData evtData, out string value, AbstractTag.TagViewHandler viewHandler)
		{
			return default(bool);
		}

		// Token: 0x06002E4A RID: 11850 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E4A")]
		[Address(RVA = "0x7EC5", Offset = "0x7EC5", VA = "0x7EC5")]
		public AccountTag_8()
		{
		}

		// Token: 0x04001965 RID: 6501
		[Token(Token = "0x4001965")]
		public const string ACCOUNT_NAME = "account";
	}
}
