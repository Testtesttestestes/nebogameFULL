using System;
using Il2CppDummyDll;

namespace Gameplay.GameEvents.Model.Tags
{
	// Token: 0x020007B4 RID: 1972
	[Token(Token = "0x20007B4")]
	public class TimestampTag_2 : AbstractTag
	{
		// Token: 0x17000910 RID: 2320
		// (get) Token: 0x06002EA4 RID: 11940 RVA: 0x00009540 File Offset: 0x00007740
		[Token(Token = "0x17000910")]
		public long Timestamp
		{
			[Token(Token = "0x6002EA4")]
			[Address(RVA = "0x7F1F", Offset = "0x7F1F", VA = "0x7F1F")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x06002EA5 RID: 11941 RVA: 0x00009558 File Offset: 0x00007758
		[Token(Token = "0x6002EA5")]
		[Address(RVA = "0x7F20", Offset = "0x7F20", VA = "0x7F20", Slot = "7")]
		public override bool TryGetValue(string tagName, GameEventData evtData, out string value, AbstractTag.TagViewHandler viewHandler)
		{
			return default(bool);
		}

		// Token: 0x06002EA6 RID: 11942 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EA6")]
		[Address(RVA = "0x7F21", Offset = "0x7F21", VA = "0x7F21")]
		public TimestampTag_2()
		{
		}

		// Token: 0x0400198D RID: 6541
		[Token(Token = "0x400198D")]
		public const string TIMESTAMP = "timestamp";

		// Token: 0x0400198E RID: 6542
		[Token(Token = "0x400198E")]
		public const string TIMESTAMP_REL = "timestamp_rel";
	}
}
