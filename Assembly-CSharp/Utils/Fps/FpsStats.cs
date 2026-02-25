using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Utils.Fps
{
	// Token: 0x02000068 RID: 104
	[Token(Token = "0x2000068")]
	public class FpsStats : AbstractFpsCounter
	{
		// Token: 0x1400000F RID: 15
		// (add) Token: 0x06000331 RID: 817 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000332 RID: 818 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400000F")]
		public event Action<float> AverageFpsCalculatedEvent
		{
			[Token(Token = "0x6000331")]
			[Address(RVA = "0x579F", Offset = "0x579F", VA = "0x579F")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000332")]
			[Address(RVA = "0x57A0", Offset = "0x57A0", VA = "0x57A0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06000333 RID: 819 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000333")]
		[Address(RVA = "0x57A1", Offset = "0x57A1", VA = "0x57A1", Slot = "4")]
		public override void HandleUpdate()
		{
		}

		// Token: 0x06000334 RID: 820 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000334")]
		[Address(RVA = "0x57A2", Offset = "0x57A2", VA = "0x57A2", Slot = "5")]
		public override void HandleFpsCalculated(float fps)
		{
		}

		// Token: 0x06000335 RID: 821 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000335")]
		[Address(RVA = "0x57A3", Offset = "0x57A3", VA = "0x57A3")]
		public FpsStats()
		{
		}
	}
}
