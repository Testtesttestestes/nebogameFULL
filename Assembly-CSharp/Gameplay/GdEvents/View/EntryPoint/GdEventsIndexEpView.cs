using System;
using AssetContent;
using Core.MVC.Interfaces;
using Il2CppDummyDll;
using UI.Elements.Counters;
using UnityEngine;

namespace Gameplay.GdEvents.View.EntryPoint
{
	// Token: 0x0200074A RID: 1866
	[Token(Token = "0x200074A")]
	public class GdEventsIndexEpView : AbstractEpView
	{
		// Token: 0x1700088A RID: 2186
		// (get) Token: 0x06002C78 RID: 11384 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700088A")]
		public CounterAutoHide Counter
		{
			[Token(Token = "0x6002C78")]
			[Address(RVA = "0x7D07", Offset = "0x7D07", VA = "0x7D07")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700088B RID: 2187
		// (get) Token: 0x06002C79 RID: 11385 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700088B")]
		public GameAssetViewRawImage View
		{
			[Token(Token = "0x6002C79")]
			[Address(RVA = "0x7D08", Offset = "0x7D08", VA = "0x7D08")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002C7A RID: 11386 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C7A")]
		[Address(RVA = "0x7D09", Offset = "0x7D09", VA = "0x7D09")]
		private void OnDestroy()
		{
		}

		// Token: 0x06002C7B RID: 11387 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C7B")]
		[Address(RVA = "0x7D0A", Offset = "0x7D0A", VA = "0x7D0A")]
		private void Start()
		{
		}

		// Token: 0x06002C7C RID: 11388 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C7C")]
		[Address(RVA = "0x7D0B", Offset = "0x7D0B", VA = "0x7D0B")]
		public GdEventsIndexEpView()
		{
		}

		// Token: 0x0400186D RID: 6253
		[Token(Token = "0x400186D")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private GameAssetViewRawImage _view;

		// Token: 0x0400186E RID: 6254
		[Token(Token = "0x400186E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CounterAutoHide _counter;

		// Token: 0x0400186F RID: 6255
		[Token(Token = "0x400186F")]
		[FieldOffset(Offset = "0x1C")]
		private IViewMediator _mediator;
	}
}
