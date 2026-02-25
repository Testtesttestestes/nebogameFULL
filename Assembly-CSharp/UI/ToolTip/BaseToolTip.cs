using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace UI.ToolTip
{
	// Token: 0x02000138 RID: 312
	[Token(Token = "0x2000138")]
	public abstract class BaseToolTip<T> : MonoBehaviour, IDisposable
	{
		// Token: 0x1700013C RID: 316
		// (get) Token: 0x06000962 RID: 2402 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000963 RID: 2403 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700013C")]
		public T Data
		{
			[Token(Token = "0x6000962")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000963")]
			set
			{
			}
		}

		// Token: 0x06000964 RID: 2404 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000964")]
		protected virtual void HandleDataChanged()
		{
		}

		// Token: 0x06000965 RID: 2405 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000965")]
		public virtual void Dispose()
		{
		}

		// Token: 0x06000966 RID: 2406 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000966")]
		protected virtual void OnDestroy()
		{
		}

		// Token: 0x06000967 RID: 2407 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000967")]
		public void SetMaxSize(in Vector2 maxsize)
		{
		}

		// Token: 0x06000968 RID: 2408 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000968")]
		public void SetMinSize(in Vector2 minSize)
		{
		}

		// Token: 0x06000969 RID: 2409 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000969")]
		protected BaseToolTip()
		{
		}

		// Token: 0x04000387 RID: 903
		[Token(Token = "0x4000387")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private LayoutElement _layoutElement;

		// Token: 0x04000388 RID: 904
		[Token(Token = "0x4000388")]
		[FieldOffset(Offset = "0x0")]
		private T _data;
	}
}
