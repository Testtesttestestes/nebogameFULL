using System;
using Core.MVC.Interfaces;
using Gameplay.GdEvents.Control;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.GdEvents.View.EventView
{
	// Token: 0x02000740 RID: 1856
	[Token(Token = "0x2000740")]
	public abstract class AbstractEventSectionView : MonoBehaviour
	{
		// Token: 0x06002C30 RID: 11312 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C30")]
		[Address(RVA = "0x7CC0", Offset = "0x7CC0", VA = "0x7CC0", Slot = "4")]
		protected virtual void OnDestroy()
		{
		}

		// Token: 0x06002C31 RID: 11313 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C31")]
		[Address(RVA = "0x7CC1", Offset = "0x7CC1", VA = "0x7CC1")]
		protected void Start()
		{
		}

		// Token: 0x06002C32 RID: 11314 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C32")]
		[Address(RVA = "0x7CC2", Offset = "0x7CC2", VA = "0x7CC2")]
		public void Init(GdEventsController controller)
		{
		}

		// Token: 0x06002C33 RID: 11315
		[Token(Token = "0x6002C33")]
		protected abstract void CreateMediator(ref IViewMediator mediator, GdEventsController controller);

		// Token: 0x06002C34 RID: 11316 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C34")]
		[Address(RVA = "0x7CC3", Offset = "0x7CC3", VA = "0x7CC3")]
		protected AbstractEventSectionView()
		{
		}

		// Token: 0x04001839 RID: 6201
		[Token(Token = "0x4001839")]
		[FieldOffset(Offset = "0x10")]
		private IViewMediator _mediator;

		// Token: 0x0400183A RID: 6202
		[Token(Token = "0x400183A")]
		[FieldOffset(Offset = "0x14")]
		private bool _isInit;

		// Token: 0x0400183B RID: 6203
		[Token(Token = "0x400183B")]
		[FieldOffset(Offset = "0x18")]
		private GdEventsController _controller;
	}
}
