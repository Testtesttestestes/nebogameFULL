using System;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Gameplay.GameEvents.Model.Tags
{
	// Token: 0x020007AE RID: 1966
	[Token(Token = "0x20007AE")]
	public class OptionTypeTag_40 : AbstractTag
	{
		// Token: 0x17000908 RID: 2312
		// (get) Token: 0x06002E91 RID: 11921 RVA: 0x00009420 File Offset: 0x00007620
		[Token(Token = "0x17000908")]
		public OptionTypesDic.Types.OptionType OptionType
		{
			[Token(Token = "0x6002E91")]
			[Address(RVA = "0x7F0C", Offset = "0x7F0C", VA = "0x7F0C")]
			get
			{
				return OptionTypesDic.Types.OptionType.Diamond;
			}
		}

		// Token: 0x06002E92 RID: 11922 RVA: 0x00009438 File Offset: 0x00007638
		[Token(Token = "0x6002E92")]
		[Address(RVA = "0x7F0D", Offset = "0x7F0D", VA = "0x7F0D", Slot = "7")]
		public override bool TryGetValue(string tagName, GameEventData evtData, out string value, AbstractTag.TagViewHandler viewHandler)
		{
			return default(bool);
		}

		// Token: 0x06002E93 RID: 11923 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E93")]
		[Address(RVA = "0x7F0E", Offset = "0x7F0E", VA = "0x7F0E")]
		public OptionTypeTag_40()
		{
		}
	}
}
