using System;
using Il2CppDummyDll;
using UI.ToolTip.Implementations;
using UnityEngine;
using UnityEngine.UI;
using Utils;

namespace UI.Elements.ProgressBars
{
	// Token: 0x0200021E RID: 542
	[Token(Token = "0x200021E")]
	[ExecuteInEditMode]
	public class ProgressBar : BaseMonoBehaviour, IProgress
	{
		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x06000D74 RID: 3444 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001C3")]
		public TextToolTip ToolTip
		{
			[Token(Token = "0x6000D74")]
			[Address(RVA = "0x6057", Offset = "0x6057", VA = "0x6057")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x06000D75 RID: 3445 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001C4")]
		protected Scrollbar scrollbar
		{
			[Token(Token = "0x6000D75")]
			[Address(RVA = "0x6058", Offset = "0x6058", VA = "0x6058")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x06000D76 RID: 3446 RVA: 0x00004080 File Offset: 0x00002280
		// (set) Token: 0x06000D77 RID: 3447 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001C5")]
		public virtual float Value
		{
			[Token(Token = "0x6000D76")]
			[Address(RVA = "0x6059", Offset = "0x6059", VA = "0x6059", Slot = "8")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000D77")]
			[Address(RVA = "0x605A", Offset = "0x605A", VA = "0x605A", Slot = "9")]
			set
			{
			}
		}

		// Token: 0x06000D78 RID: 3448 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D78")]
		[Address(RVA = "0x605B", Offset = "0x605B", VA = "0x605B", Slot = "7")]
		public void SetProgress(float current, float total)
		{
		}

		// Token: 0x06000D79 RID: 3449 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D79")]
		[Address(RVA = "0x605C", Offset = "0x605C", VA = "0x605C")]
		private void Start()
		{
		}

		// Token: 0x06000D7A RID: 3450 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D7A")]
		[Address(RVA = "0x605D", Offset = "0x605D", VA = "0x605D")]
		private void OnEnable()
		{
		}

		// Token: 0x06000D7B RID: 3451 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D7B")]
		[Address(RVA = "0x605E", Offset = "0x605E", VA = "0x605E", Slot = "4")]
		protected override void OnValidateSafety()
		{
		}

		// Token: 0x06000D7C RID: 3452 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D7C")]
		[Address(RVA = "0x605F", Offset = "0x605F", VA = "0x605F")]
		public ProgressBar()
		{
		}

		// Token: 0x040006B3 RID: 1715
		[Token(Token = "0x40006B3")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Scrollbar _scrollbar;

		// Token: 0x040006B4 RID: 1716
		[Token(Token = "0x40006B4")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		protected Filler _filler;

		// Token: 0x040006B5 RID: 1717
		[Token(Token = "0x40006B5")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		protected TextToolTip _toolTip;
	}
}
