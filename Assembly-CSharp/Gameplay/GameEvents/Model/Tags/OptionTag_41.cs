using System;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Gameplay.GameEvents.Model.Tags
{
	// Token: 0x020007AD RID: 1965
	[Token(Token = "0x20007AD")]
	public class OptionTag_41 : AbstractTag
	{
		// Token: 0x17000906 RID: 2310
		// (get) Token: 0x06002E8C RID: 11916 RVA: 0x000093C0 File Offset: 0x000075C0
		[Token(Token = "0x17000906")]
		public OptionTypesDic.Types.OptionType OptionType
		{
			[Token(Token = "0x6002E8C")]
			[Address(RVA = "0x7F07", Offset = "0x7F07", VA = "0x7F07")]
			get
			{
				return OptionTypesDic.Types.OptionType.Diamond;
			}
		}

		// Token: 0x17000907 RID: 2311
		// (get) Token: 0x06002E8D RID: 11917 RVA: 0x000093D8 File Offset: 0x000075D8
		[Token(Token = "0x17000907")]
		public uint OptionId
		{
			[Token(Token = "0x6002E8D")]
			[Address(RVA = "0x7F08", Offset = "0x7F08", VA = "0x7F08")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x06002E8E RID: 11918 RVA: 0x000093F0 File Offset: 0x000075F0
		[Token(Token = "0x6002E8E")]
		[Address(RVA = "0x7F09", Offset = "0x7F09", VA = "0x7F09", Slot = "7")]
		public override bool TryGetValue(string tagName, GameEventData evtData, out string value, AbstractTag.TagViewHandler viewHandler)
		{
			return default(bool);
		}

		// Token: 0x06002E8F RID: 11919 RVA: 0x00009408 File Offset: 0x00007608
		[Token(Token = "0x6002E8F")]
		[Address(RVA = "0x7F0A", Offset = "0x7F0A", VA = "0x7F0A")]
		public bool GetBaseOptionDic(OptionTypesDic.Types.OptionType type, uint optionId, out string optionTitle, out string optionEventPromoTitle, out string optionEventPromoDescription)
		{
			return default(bool);
		}

		// Token: 0x06002E90 RID: 11920 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E90")]
		[Address(RVA = "0x7F0B", Offset = "0x7F0B", VA = "0x7F0B")]
		public OptionTag_41()
		{
		}

		// Token: 0x04001982 RID: 6530
		[Token(Token = "0x4001982")]
		public const string OPTION_TITLE = "option_title";

		// Token: 0x04001983 RID: 6531
		[Token(Token = "0x4001983")]
		public const string OPTION_EVENT_PROMO_TITLE = "option_event_promo_title";

		// Token: 0x04001984 RID: 6532
		[Token(Token = "0x4001984")]
		public const string OPTION_EVENT_PROMO_DESCRIPTION = "option_event_promo_description";

		// Token: 0x04001985 RID: 6533
		[Token(Token = "0x4001985")]
		public const string OPTION_NOT_FOUND_TEXT = "Option Type: {0}, Id: {1} Not Found In Dicts";
	}
}
