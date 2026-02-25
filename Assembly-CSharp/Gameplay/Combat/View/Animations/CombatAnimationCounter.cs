using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Gameplay.Combat.View.Animations
{
	// Token: 0x02000981 RID: 2433
	[Token(Token = "0x2000981")]
	public class CombatAnimationCounter
	{
		// Token: 0x17000B62 RID: 2914
		// (get) Token: 0x06003A00 RID: 14848 RVA: 0x0000B928 File Offset: 0x00009B28
		// (set) Token: 0x06003A01 RID: 14849 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B62")]
		public int Value
		{
			[Token(Token = "0x6003A00")]
			[Address(RVA = "0x8984", Offset = "0x8984", VA = "0x8984")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6003A01")]
			[Address(RVA = "0x8985", Offset = "0x8985", VA = "0x8985")]
			set
			{
			}
		}

		// Token: 0x06003A02 RID: 14850 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A02")]
		[Address(RVA = "0x8986", Offset = "0x8986", VA = "0x8986")]
		private void HandleCountChanged()
		{
		}

		// Token: 0x14000189 RID: 393
		// (add) Token: 0x06003A03 RID: 14851 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06003A04 RID: 14852 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000189")]
		private event Action _completeEvent
		{
			[Token(Token = "0x6003A03")]
			[Address(RVA = "0x8987", Offset = "0x8987", VA = "0x8987")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6003A04")]
			[Address(RVA = "0x8988", Offset = "0x8988", VA = "0x8988")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400018A RID: 394
		// (add) Token: 0x06003A05 RID: 14853 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06003A06 RID: 14854 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400018A")]
		public event Action CompleteEvent
		{
			[Token(Token = "0x6003A05")]
			[Address(RVA = "0x8989", Offset = "0x8989", VA = "0x8989")]
			add
			{
			}
			[Token(Token = "0x6003A06")]
			[Address(RVA = "0x898A", Offset = "0x898A", VA = "0x898A")]
			remove
			{
			}
		}

		// Token: 0x06003A07 RID: 14855 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A07")]
		[Address(RVA = "0x898B", Offset = "0x898B", VA = "0x898B")]
		public void Reset()
		{
		}

		// Token: 0x06003A08 RID: 14856 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A08")]
		[Address(RVA = "0x898C", Offset = "0x898C", VA = "0x898C")]
		public CombatAnimationCounter()
		{
		}

		// Token: 0x04002010 RID: 8208
		[Token(Token = "0x4002010")]
		[FieldOffset(Offset = "0x8")]
		private int _value;
	}
}
