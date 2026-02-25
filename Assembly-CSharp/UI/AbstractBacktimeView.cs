using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using Utils;

namespace UI
{
	// Token: 0x020000E7 RID: 231
	[Token(Token = "0x20000E7")]
	public abstract class AbstractBacktimeView : MonoBehaviour
	{
		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x060007C3 RID: 1987 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060007C4 RID: 1988 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000E7")]
		public AbstractBacktimeView.FormatCallback FormatBackTimeCallback
		{
			[Token(Token = "0x60007C3")]
			[Address(RVA = "0x5B93", Offset = "0x5B93", VA = "0x5B93")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60007C4")]
			[Address(RVA = "0x5B94", Offset = "0x5B94", VA = "0x5B94")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060007C5 RID: 1989
		[Token(Token = "0x60007C5")]
		protected abstract void RenderValue(string text);

		// Token: 0x060007C6 RID: 1990 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007C6")]
		[Address(RVA = "0x5B95", Offset = "0x5B95", VA = "0x5B95")]
		public void SetCustomStaticText(string text)
		{
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x060007C7 RID: 1991 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060007C8 RID: 1992 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000E8")]
		public BackTime BackTime
		{
			[Token(Token = "0x60007C7")]
			[Address(RVA = "0x5B96", Offset = "0x5B96", VA = "0x5B96")]
			get
			{
				return null;
			}
			[Token(Token = "0x60007C8")]
			[Address(RVA = "0x1B54", Offset = "0x1B54", VA = "0x1B54")]
			set
			{
			}
		}

		// Token: 0x060007C9 RID: 1993 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60007C9")]
		[Address(RVA = "0x5B97", Offset = "0x5B97", VA = "0x5B97")]
		private IEnumerator DisplayCurrentBackTime()
		{
			return null;
		}

		// Token: 0x060007CA RID: 1994 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007CA")]
		[Address(RVA = "0x5B98", Offset = "0x5B98", VA = "0x5B98")]
		public void Display(BackTime backtime)
		{
		}

		// Token: 0x060007CB RID: 1995 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007CB")]
		[Address(RVA = "0x5B99", Offset = "0x5B99", VA = "0x5B99")]
		private void StopCurrentCoroutine()
		{
		}

		// Token: 0x060007CC RID: 1996 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007CC")]
		[Address(RVA = "0x5B9A", Offset = "0x5B9A", VA = "0x5B9A")]
		private void OnDestroy()
		{
		}

		// Token: 0x060007CD RID: 1997 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007CD")]
		[Address(RVA = "0x5B9B", Offset = "0x5B9B", VA = "0x5B9B")]
		protected AbstractBacktimeView()
		{
		}

		// Token: 0x040002AE RID: 686
		[Token(Token = "0x40002AE")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private bool _hideZeroTimer;

		// Token: 0x040002B0 RID: 688
		[Token(Token = "0x40002B0")]
		[FieldOffset(Offset = "0x18")]
		private BackTime _backTime;

		// Token: 0x040002B1 RID: 689
		[Token(Token = "0x40002B1")]
		[FieldOffset(Offset = "0x1C")]
		private Coroutine _displayBackTimeCoroutine;

		// Token: 0x020000E8 RID: 232
		// (Invoke) Token: 0x060007CF RID: 1999
		[Token(Token = "0x20000E8")]
		public delegate string FormatCallback(float value);
	}
}
