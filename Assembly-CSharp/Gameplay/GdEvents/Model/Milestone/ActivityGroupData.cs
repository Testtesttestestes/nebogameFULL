using System;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Gameplay.GdEvents.Model.Milestone
{
	// Token: 0x02000755 RID: 1877
	[Token(Token = "0x2000755")]
	public class ActivityGroupData
	{
		// Token: 0x06002CCB RID: 11467 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002CCB")]
		[Address(RVA = "0x2190", Offset = "0x2190", VA = "0x2190")]
		public ActivityGroupData(ActivityTypeDic activityType)
		{
		}

		// Token: 0x0400189B RID: 6299
		[Token(Token = "0x400189B")]
		[FieldOffset(Offset = "0x8")]
		public readonly ActivityTypeDic ActivityTypeDic;

		// Token: 0x0400189C RID: 6300
		[Token(Token = "0x400189C")]
		[FieldOffset(Offset = "0xC")]
		public GameActivityData[] Items;
	}
}
