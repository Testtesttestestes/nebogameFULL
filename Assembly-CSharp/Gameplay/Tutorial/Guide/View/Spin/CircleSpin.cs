using System;
using DG.Tweening;
using Il2CppDummyDll;

namespace Gameplay.Tutorial.Guide.View.Spin
{
	// Token: 0x02000466 RID: 1126
	[Token(Token = "0x2000466")]
	public class CircleSpin : AbstractSpin
	{
		// Token: 0x06001AC1 RID: 6849 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AC1")]
		[Address(RVA = "0x6C4E", Offset = "0x6C4E", VA = "0x6C4E", Slot = "5")]
		public override void Start()
		{
		}

		// Token: 0x06001AC2 RID: 6850 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AC2")]
		[Address(RVA = "0x6C4F", Offset = "0x6C4F", VA = "0x6C4F", Slot = "6")]
		public override void Stop()
		{
		}

		// Token: 0x06001AC3 RID: 6851 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AC3")]
		[Address(RVA = "0x6C50", Offset = "0x6C50", VA = "0x6C50", Slot = "7")]
		public override void Dispose()
		{
		}

		// Token: 0x06001AC4 RID: 6852 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AC4")]
		[Address(RVA = "0x6C51", Offset = "0x6C51", VA = "0x6C51")]
		public CircleSpin()
		{
		}

		// Token: 0x04000E66 RID: 3686
		[Token(Token = "0x4000E66")]
		[FieldOffset(Offset = "0x18")]
		private Tween _tween;
	}
}
