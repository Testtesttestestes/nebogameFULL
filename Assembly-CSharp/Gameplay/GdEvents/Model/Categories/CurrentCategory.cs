using System;
using Core.GameTime;
using Il2CppDummyDll;

namespace Gameplay.GdEvents.Model.Categories
{
	// Token: 0x0200075F RID: 1887
	[Token(Token = "0x200075F")]
	public class CurrentCategory : AbstractGdEventCatData
	{
		// Token: 0x170008AC RID: 2220
		// (get) Token: 0x06002CF7 RID: 11511 RVA: 0x00008A30 File Offset: 0x00006C30
		[Token(Token = "0x170008AC")]
		public override Category Category
		{
			[Token(Token = "0x6002CF7")]
			[Address(RVA = "0x7D75", Offset = "0x7D75", VA = "0x7D75", Slot = "6")]
			get
			{
				return Category.Unknown;
			}
		}

		// Token: 0x06002CF8 RID: 11512 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002CF8")]
		[Address(RVA = "0x7D76", Offset = "0x7D76", VA = "0x7D76")]
		public CurrentCategory(string title, ICurrentTimeProvider timeProvider, ITimeOffsetProvider timeOffsetProvider, TimerStrings timerStrings)
		{
		}

		// Token: 0x06002CF9 RID: 11513 RVA: 0x00008A48 File Offset: 0x00006C48
		[Token(Token = "0x6002CF9")]
		[Address(RVA = "0x7D77", Offset = "0x7D77", VA = "0x7D77", Slot = "7")]
		public override float GetBackTime(GdEventData evt)
		{
			return 0f;
		}

		// Token: 0x06002CFA RID: 11514 RVA: 0x00008A60 File Offset: 0x00006C60
		[Token(Token = "0x6002CFA")]
		[Address(RVA = "0x7D78", Offset = "0x7D78", VA = "0x7D78", Slot = "9")]
		public override bool IsBackTimeAvail(GdEventData evt)
		{
			return default(bool);
		}

		// Token: 0x06002CFB RID: 11515 RVA: 0x00008A78 File Offset: 0x00006C78
		[Token(Token = "0x6002CFB")]
		[Address(RVA = "0x7D79", Offset = "0x7D79", VA = "0x7D79", Slot = "10")]
		public override bool IsFit(GdEventData evt)
		{
			return default(bool);
		}

		// Token: 0x06002CFC RID: 11516 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002CFC")]
		[Address(RVA = "0x7D7A", Offset = "0x7D7A", VA = "0x7D7A", Slot = "8")]
		public override string GetBackTimeTitle(GdEventData evt, TimerStrings timerStrings)
		{
			return null;
		}

		// Token: 0x06002CFD RID: 11517 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002CFD")]
		[Address(RVA = "0x7D7B", Offset = "0x7D7B", VA = "0x7D7B", Slot = "11")]
		protected override void Sort()
		{
		}
	}
}
