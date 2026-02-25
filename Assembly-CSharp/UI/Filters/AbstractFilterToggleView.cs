using System;
using System.Runtime.CompilerServices;
using AssetContent;
using Il2CppDummyDll;
using UI.ToolTip;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Filters
{
	// Token: 0x020001DC RID: 476
	[Token(Token = "0x20001DC")]
	public abstract class AbstractFilterToggleView<T> : MonoBehaviour, IToolTipDataProvider
	{
		// Token: 0x1700019D RID: 413
		// (get) Token: 0x06000C63 RID: 3171 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000C64 RID: 3172 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700019D")]
		public T Data
		{
			[Token(Token = "0x6000C63")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000C64")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x06000C65 RID: 3173 RVA: 0x00003E70 File Offset: 0x00002070
		[Token(Token = "0x1700019E")]
		public bool IsOn
		{
			[Token(Token = "0x6000C65")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x140000E4 RID: 228
		// (add) Token: 0x06000C66 RID: 3174 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000C67 RID: 3175 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000E4")]
		public event Action<AbstractFilterToggleView<T>> FilterToggleClickedEvent
		{
			[Token(Token = "0x6000C66")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000C67")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06000C68 RID: 3176 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C68")]
		public virtual void Init(T filter)
		{
		}

		// Token: 0x06000C69 RID: 3177 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000C69")]
		public virtual BaseToolTipData GetData()
		{
			return null;
		}

		// Token: 0x06000C6A RID: 3178 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C6A")]
		private void Awake()
		{
		}

		// Token: 0x06000C6B RID: 3179 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C6B")]
		private void OnDestroy()
		{
		}

		// Token: 0x06000C6C RID: 3180 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C6C")]
		protected virtual void ToggleValueChangedEventHandler(bool isOn)
		{
		}

		// Token: 0x06000C6D RID: 3181 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C6D")]
		protected AbstractFilterToggleView()
		{
		}

		// Token: 0x040005F7 RID: 1527
		[Token(Token = "0x40005F7")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		protected Toggle _toggle;

		// Token: 0x040005F8 RID: 1528
		[Token(Token = "0x40005F8")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		protected GameImage _image;
	}
}
