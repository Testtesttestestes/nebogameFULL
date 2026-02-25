using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace UI.Elements.ProgressBars
{
	// Token: 0x02000221 RID: 545
	[Token(Token = "0x2000221")]
	[ExecuteInEditMode]
	public class ProgressBarWithTimer : ProgressBarWithText
	{
		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x06000D87 RID: 3463 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000D88 RID: 3464 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001C8")]
		public override string Text
		{
			[Token(Token = "0x6000D87")]
			[Address(RVA = "0x606A", Offset = "0x606A", VA = "0x606A", Slot = "10")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000D88")]
			[Address(RVA = "0x606B", Offset = "0x606B", VA = "0x606B", Slot = "11")]
			set
			{
			}
		}

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x06000D89 RID: 3465 RVA: 0x000040C8 File Offset: 0x000022C8
		// (set) Token: 0x06000D8A RID: 3466 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001C9")]
		public override float Value
		{
			[Token(Token = "0x6000D89")]
			[Address(RVA = "0x606C", Offset = "0x606C", VA = "0x606C", Slot = "8")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000D8A")]
			[Address(RVA = "0x606D", Offset = "0x606D", VA = "0x606D", Slot = "9")]
			set
			{
			}
		}

		// Token: 0x06000D8B RID: 3467 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000D8B")]
		[Address(RVA = "0x606E", Offset = "0x606E", VA = "0x606E")]
		private IEnumerator TimerRoutine(ulong durationMs, DateTime endTime)
		{
			return null;
		}

		// Token: 0x06000D8C RID: 3468 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D8C")]
		[Address(RVA = "0x606F", Offset = "0x606F", VA = "0x606F")]
		public void Init(ulong durationMs, DateTime endTime)
		{
		}

		// Token: 0x06000D8D RID: 3469 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D8D")]
		[Address(RVA = "0x6070", Offset = "0x6070", VA = "0x6070")]
		private void TimerComplete()
		{
		}

		// Token: 0x06000D8E RID: 3470 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D8E")]
		[Address(RVA = "0x6071", Offset = "0x6071", VA = "0x6071")]
		public void Init(ulong durationMs, ulong backtimer)
		{
		}

		// Token: 0x06000D8F RID: 3471 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D8F")]
		[Address(RVA = "0x6072", Offset = "0x6072", VA = "0x6072")]
		public ProgressBarWithTimer()
		{
		}

		// Token: 0x040006B9 RID: 1721
		[Token(Token = "0x40006B9")]
		[FieldOffset(Offset = "0x20")]
		private Coroutine _timerRoutine;
	}
}
