using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace UI
{
	// Token: 0x020000EB RID: 235
	[Token(Token = "0x20000EB")]
	public abstract class AbstractDeferredRenderer : MonoBehaviour, IDisposable
	{
		// Token: 0x170000ED RID: 237
		// (get) Token: 0x060007E7 RID: 2023 RVA: 0x00003498 File Offset: 0x00001698
		// (set) Token: 0x060007E8 RID: 2024 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000ED")]
		public bool IsDisposed
		{
			[Token(Token = "0x60007E7")]
			[Address(RVA = "0x5BA6", Offset = "0x5BA6", VA = "0x5BA6")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60007E8")]
			[Address(RVA = "0x5BA7", Offset = "0x5BA7", VA = "0x5BA7")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060007E9 RID: 2025
		[Token(Token = "0x60007E9")]
		protected abstract void CommitProperties();

		// Token: 0x060007EA RID: 2026 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007EA")]
		[Address(RVA = "0x5BA8", Offset = "0x5BA8", VA = "0x5BA8", Slot = "6")]
		protected virtual void OnEnable()
		{
		}

		// Token: 0x060007EB RID: 2027 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007EB")]
		[Address(RVA = "0x5BA9", Offset = "0x5BA9", VA = "0x5BA9", Slot = "7")]
		protected virtual void OnDisable()
		{
		}

		// Token: 0x060007EC RID: 2028 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007EC")]
		[Address(RVA = "0x5BAA", Offset = "0x5BAA", VA = "0x5BAA", Slot = "8")]
		protected virtual void OnDestroy()
		{
		}

		// Token: 0x060007ED RID: 2029 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007ED")]
		[Address(RVA = "0x5BAB", Offset = "0x5BAB", VA = "0x5BAB", Slot = "9")]
		protected virtual void Awake()
		{
		}

		// Token: 0x060007EE RID: 2030 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007EE")]
		[Address(RVA = "0x5BAC", Offset = "0x5BAC", VA = "0x5BAC")]
		private void KillCoroutine()
		{
		}

		// Token: 0x060007EF RID: 2031 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007EF")]
		[Address(RVA = "0x5BAD", Offset = "0x5BAD", VA = "0x5BAD")]
		protected void InvalidateProperties()
		{
		}

		// Token: 0x060007F0 RID: 2032 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007F0")]
		[Address(RVA = "0x5BAE", Offset = "0x5BAE", VA = "0x5BAE")]
		protected void ValidatePropertiesImmediately()
		{
		}

		// Token: 0x060007F1 RID: 2033 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60007F1")]
		[Address(RVA = "0x5BAF", Offset = "0x5BAF", VA = "0x5BAF")]
		private IEnumerator InvalidateCoroutine()
		{
			return null;
		}

		// Token: 0x060007F2 RID: 2034 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007F2")]
		[Address(RVA = "0x5BB0", Offset = "0x5BB0", VA = "0x5BB0", Slot = "10")]
		public virtual void Dispose()
		{
		}

		// Token: 0x060007F3 RID: 2035 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007F3")]
		[Address(RVA = "0x5BB1", Offset = "0x5BB1", VA = "0x5BB1")]
		protected AbstractDeferredRenderer()
		{
		}

		// Token: 0x040002B9 RID: 697
		[Token(Token = "0x40002B9")]
		[FieldOffset(Offset = "0x14")]
		private Coroutine _invalidateCoroutine;
	}
}
