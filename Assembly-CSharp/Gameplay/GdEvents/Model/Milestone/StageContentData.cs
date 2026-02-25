using System;
using Core;
using Core.Dict;
using Il2CppDummyDll;

namespace Gameplay.GdEvents.Model.Milestone
{
	// Token: 0x0200075C RID: 1884
	[Token(Token = "0x200075C")]
	public class StageContentData<T>
	{
		// Token: 0x06002CE6 RID: 11494 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002CE6")]
		public StageContentData(T[] items, IDictProvider dictProvider, GdEventData evt)
		{
		}

		// Token: 0x170008A7 RID: 2215
		// (get) Token: 0x06002CE7 RID: 11495 RVA: 0x000089E8 File Offset: 0x00006BE8
		[Token(Token = "0x170008A7")]
		public InteractiveBehavior InteractiveMode
		{
			[Token(Token = "0x6002CE7")]
			get
			{
				return InteractiveBehavior.Default;
			}
		}

		// Token: 0x040018AF RID: 6319
		[Token(Token = "0x40018AF")]
		[FieldOffset(Offset = "0x0")]
		public readonly T[] Items;

		// Token: 0x040018B0 RID: 6320
		[Token(Token = "0x40018B0")]
		[FieldOffset(Offset = "0x0")]
		public readonly IDictProvider DictProvider;

		// Token: 0x040018B1 RID: 6321
		[Token(Token = "0x40018B1")]
		[FieldOffset(Offset = "0x0")]
		public readonly GdEventData Evt;
	}
}
