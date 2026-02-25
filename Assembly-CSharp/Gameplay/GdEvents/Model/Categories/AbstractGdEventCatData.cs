using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.GameTime;
using Il2CppDummyDll;

namespace Gameplay.GdEvents.Model.Categories
{
	// Token: 0x0200075D RID: 1885
	[Token(Token = "0x200075D")]
	public abstract class AbstractGdEventCatData : IDisposable
	{
		// Token: 0x170008A8 RID: 2216
		// (get) Token: 0x06002CE8 RID: 11496 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170008A8")]
		public IList<GdEventData> Items
		{
			[Token(Token = "0x6002CE8")]
			[Address(RVA = "0x7D6C", Offset = "0x7D6C", VA = "0x7D6C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x170008A9 RID: 2217
		// (get) Token: 0x06002CE9 RID: 11497 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002CEA RID: 11498 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008A9")]
		public ITimeOffsetProvider TimeOffsetProvider
		{
			[Token(Token = "0x6002CE9")]
			[Address(RVA = "0x7D6D", Offset = "0x7D6D", VA = "0x7D6D")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002CEA")]
			[Address(RVA = "0x7D6E", Offset = "0x7D6E", VA = "0x7D6E")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170008AA RID: 2218
		// (get) Token: 0x06002CEB RID: 11499 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170008AA")]
		public TimerStrings TimerStrings
		{
			[Token(Token = "0x6002CEB")]
			[Address(RVA = "0x7D6F", Offset = "0x7D6F", VA = "0x7D6F")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002CEC RID: 11500 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002CEC")]
		[Address(RVA = "0x7D70", Offset = "0x7D70", VA = "0x7D70", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x06002CED RID: 11501 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002CED")]
		[Address(RVA = "0x7D71", Offset = "0x7D71", VA = "0x7D71")]
		public AbstractGdEventCatData(string title, ICurrentTimeProvider timeProvider, ITimeOffsetProvider timeOffsetProvider, TimerStrings timerStrings)
		{
		}

		// Token: 0x06002CEE RID: 11502 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002CEE")]
		[Address(RVA = "0x7D72", Offset = "0x7D72", VA = "0x7D72")]
		public void ResetItems()
		{
		}

		// Token: 0x06002CEF RID: 11503 RVA: 0x00008A00 File Offset: 0x00006C00
		[Token(Token = "0x6002CEF")]
		[Address(RVA = "0x7D73", Offset = "0x7D73", VA = "0x7D73", Slot = "5")]
		public virtual bool TryAdd(GdEventData evt)
		{
			return default(bool);
		}

		// Token: 0x06002CF0 RID: 11504 RVA: 0x00008A18 File Offset: 0x00006C18
		[Token(Token = "0x6002CF0")]
		[Address(RVA = "0x7D74", Offset = "0x7D74", VA = "0x7D74")]
		public bool TryRemove(GdEventData evt)
		{
			return default(bool);
		}

		// Token: 0x170008AB RID: 2219
		// (get) Token: 0x06002CF1 RID: 11505
		[Token(Token = "0x170008AB")]
		public abstract Category Category { [Token(Token = "0x6002CF1")] get; }

		// Token: 0x06002CF2 RID: 11506
		[Token(Token = "0x6002CF2")]
		public abstract float GetBackTime(GdEventData evt);

		// Token: 0x06002CF3 RID: 11507
		[Token(Token = "0x6002CF3")]
		public abstract string GetBackTimeTitle(GdEventData evt, TimerStrings timerStrings);

		// Token: 0x06002CF4 RID: 11508
		[Token(Token = "0x6002CF4")]
		public abstract bool IsBackTimeAvail(GdEventData evt);

		// Token: 0x06002CF5 RID: 11509
		[Token(Token = "0x6002CF5")]
		public abstract bool IsFit(GdEventData evt);

		// Token: 0x06002CF6 RID: 11510
		[Token(Token = "0x6002CF6")]
		protected abstract void Sort();

		// Token: 0x040018B2 RID: 6322
		[Token(Token = "0x40018B2")]
		[FieldOffset(Offset = "0x8")]
		public readonly string Title;

		// Token: 0x040018B5 RID: 6325
		[Token(Token = "0x40018B5")]
		[FieldOffset(Offset = "0x14")]
		protected ICurrentTimeProvider _timeProvider;

		// Token: 0x040018B6 RID: 6326
		[Token(Token = "0x40018B6")]
		[FieldOffset(Offset = "0x18")]
		protected TimerStrings _timerStrings;
	}
}
