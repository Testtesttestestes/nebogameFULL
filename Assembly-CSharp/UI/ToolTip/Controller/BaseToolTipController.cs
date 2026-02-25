using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace UI.ToolTip.Controller
{
	// Token: 0x02000169 RID: 361
	[Token(Token = "0x2000169")]
	public abstract class BaseToolTipController : IToolTipController, IDisposable
	{
		// Token: 0x140000D4 RID: 212
		// (add) Token: 0x06000A0B RID: 2571 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000A0C RID: 2572 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000D4")]
		public event Action<IToolTipSource> ShownEvent
		{
			[Token(Token = "0x6000A0B")]
			[Address(RVA = "0x5D67", Offset = "0x5D67", VA = "0x5D67", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000A0C")]
			[Address(RVA = "0x5D68", Offset = "0x5D68", VA = "0x5D68", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x06000A0D RID: 2573 RVA: 0x00003840 File Offset: 0x00001A40
		// (set) Token: 0x06000A0E RID: 2574 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700014C")]
		public Vector2 RadiusAroundPointer
		{
			[Token(Token = "0x6000A0D")]
			[Address(RVA = "0x5D69", Offset = "0x5D69", VA = "0x5D69")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6000A0E")]
			[Address(RVA = "0x5D6A", Offset = "0x5D6A", VA = "0x5D6A")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06000A0F RID: 2575 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A0F")]
		[Address(RVA = "0x5D6B", Offset = "0x5D6B", VA = "0x5D6B", Slot = "9")]
		public virtual void Dispose()
		{
		}

		// Token: 0x06000A10 RID: 2576 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A10")]
		[Address(RVA = "0x5D6C", Offset = "0x5D6C", VA = "0x5D6C")]
		public BaseToolTipController(Canvas canvas, RectTransform layer, Vector2 padding)
		{
		}

		// Token: 0x06000A11 RID: 2577 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A11")]
		[Address(RVA = "0x5D6D", Offset = "0x5D6D", VA = "0x5D6D", Slot = "10")]
		public virtual void Show(IToolTipSource source)
		{
		}

		// Token: 0x06000A12 RID: 2578 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A12")]
		[Address(RVA = "0x5D6E", Offset = "0x5D6E", VA = "0x5D6E")]
		protected void OnTooltipShown()
		{
		}

		// Token: 0x06000A13 RID: 2579 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A13")]
		[Address(RVA = "0x5D6F", Offset = "0x5D6F", VA = "0x5D6F", Slot = "11")]
		public virtual void Hide(IToolTipSource source)
		{
		}

		// Token: 0x06000A14 RID: 2580 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A14")]
		[Address(RVA = "0x5D70", Offset = "0x5D70", VA = "0x5D70")]
		protected void SetCurrentView(RectTransform view)
		{
		}

		// Token: 0x06000A15 RID: 2581 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A15")]
		[Address(RVA = "0x5D71", Offset = "0x5D71", VA = "0x5D71")]
		protected void SetCurrentSource(IToolTipSource dataProvider)
		{
		}

		// Token: 0x06000A16 RID: 2582 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A16")]
		[Address(RVA = "0x5D72", Offset = "0x5D72", VA = "0x5D72")]
		protected void GetContentSize(in Vector2 contentSize, out Vector2 result)
		{
		}

		// Token: 0x06000A17 RID: 2583 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A17")]
		[Address(RVA = "0x5D73", Offset = "0x5D73", VA = "0x5D73")]
		public void GetPosition(in Vector3 center, RectTransform target, out Vector3 result)
		{
		}

		// Token: 0x06000A18 RID: 2584 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000A18")]
		[Address(RVA = "0x5D74", Offset = "0x5D74", VA = "0x5D74")]
		protected IEnumerator UpdateToolTipPositionCoroutine(RectTransform target)
		{
			return null;
		}

		// Token: 0x06000A19 RID: 2585 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A19")]
		[Address(RVA = "0x5D75", Offset = "0x5D75", VA = "0x5D75")]
		protected void StartUpdateToolTipPositionCoroutine(IToolTipSource source, RectTransform target)
		{
		}

		// Token: 0x06000A1A RID: 2586 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A1A")]
		[Address(RVA = "0x5D76", Offset = "0x5D76", VA = "0x5D76")]
		protected void StopUpdateToolTipPositionCoroutine(IToolTipSource source)
		{
		}

		// Token: 0x06000A1B RID: 2587
		[Token(Token = "0x6000A1B")]
		protected abstract void GetPointerPosition(out Vector3 position);

		// Token: 0x04000440 RID: 1088
		[Token(Token = "0x4000440")]
		[FieldOffset(Offset = "0x8")]
		private readonly Dictionary<IToolTipSource, Coroutine> _coroutines;

		// Token: 0x04000442 RID: 1090
		[Token(Token = "0x4000442")]
		[FieldOffset(Offset = "0x10")]
		protected IToolTipSource _currentSource;

		// Token: 0x04000443 RID: 1091
		[Token(Token = "0x4000443")]
		[FieldOffset(Offset = "0x14")]
		protected RectTransform _currentView;

		// Token: 0x04000444 RID: 1092
		[Token(Token = "0x4000444")]
		[FieldOffset(Offset = "0x18")]
		public readonly RectTransform Layer;

		// Token: 0x04000445 RID: 1093
		[Token(Token = "0x4000445")]
		[FieldOffset(Offset = "0x1C")]
		public readonly Canvas Canvas;

		// Token: 0x04000446 RID: 1094
		[Token(Token = "0x4000446")]
		[FieldOffset(Offset = "0x20")]
		public readonly Vector2 Padding;
	}
}
