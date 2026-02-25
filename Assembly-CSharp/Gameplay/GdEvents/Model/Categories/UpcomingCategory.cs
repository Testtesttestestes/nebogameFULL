using System;
using Core.GameTime;
using Il2CppDummyDll;

namespace Gameplay.GdEvents.Model.Categories
{
	// Token: 0x02000762 RID: 1890
	[Token(Token = "0x2000762")]
	public class UpcomingCategory : AbstractGdEventCatData
	{
		// Token: 0x170008AD RID: 2221
		// (get) Token: 0x06002D02 RID: 11522 RVA: 0x00008AA8 File Offset: 0x00006CA8
		[Token(Token = "0x170008AD")]
		public override Category Category
		{
			[Token(Token = "0x6002D02")]
			[Address(RVA = "0x7D80", Offset = "0x7D80", VA = "0x7D80", Slot = "6")]
			get
			{
				return Category.Unknown;
			}
		}

		// Token: 0x06002D03 RID: 11523 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D03")]
		[Address(RVA = "0x7D81", Offset = "0x7D81", VA = "0x7D81")]
		public UpcomingCategory(string title, ICurrentTimeProvider timeProvider, ITimeOffsetProvider timeOffsetProvider, TimerStrings timerStrings)
		{
		}

		// Token: 0x06002D04 RID: 11524 RVA: 0x00008AC0 File Offset: 0x00006CC0
		[Token(Token = "0x6002D04")]
		[Address(RVA = "0x7D82", Offset = "0x7D82", VA = "0x7D82", Slot = "7")]
		public override float GetBackTime(GdEventData evt)
		{
			return 0f;
		}

		// Token: 0x06002D05 RID: 11525 RVA: 0x00008AD8 File Offset: 0x00006CD8
		[Token(Token = "0x6002D05")]
		[Address(RVA = "0x7D83", Offset = "0x7D83", VA = "0x7D83", Slot = "9")]
		public override bool IsBackTimeAvail(GdEventData evt)
		{
			return default(bool);
		}

		// Token: 0x06002D06 RID: 11526 RVA: 0x00008AF0 File Offset: 0x00006CF0
		[Token(Token = "0x6002D06")]
		[Address(RVA = "0x7D84", Offset = "0x7D84", VA = "0x7D84", Slot = "10")]
		public override bool IsFit(GdEventData evt)
		{
			return default(bool);
		}

		// Token: 0x06002D07 RID: 11527 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002D07")]
		[Address(RVA = "0x7D85", Offset = "0x7D85", VA = "0x7D85", Slot = "8")]
		public override string GetBackTimeTitle(GdEventData evt, TimerStrings timerStrings)
		{
			return null;
		}

		// Token: 0x06002D08 RID: 11528 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D08")]
		[Address(RVA = "0x7D86", Offset = "0x7D86", VA = "0x7D86", Slot = "11")]
		protected override void Sort()
		{
		}
	}
}
