using System;
using Gameplay.Boss.Controller;
using Gameplay.Boss.Events;
using Gameplay.Boss.Model;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.Boss.View
{
	// Token: 0x02000B46 RID: 2886
	[Token(Token = "0x2000B46")]
	public abstract class AbstractBossWindowView<TView, TMediator> : MonoBehaviour, IBossWindowView where TView : AbstractBossWindowView<TView, TMediator> where TMediator : AbstractBossWindowViewMediator<TView>
	{
		// Token: 0x060045EC RID: 17900 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045EC")]
		public void Init(BossInstanceModel model, BossInstanceEvents events, BossInstanceController controller)
		{
		}

		// Token: 0x060045ED RID: 17901
		[Token(Token = "0x60045ED")]
		protected abstract TMediator CreateMediator();

		// Token: 0x060045EE RID: 17902 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045EE")]
		protected virtual void OnEnable()
		{
		}

		// Token: 0x060045EF RID: 17903 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045EF")]
		private void Start()
		{
		}

		// Token: 0x060045F0 RID: 17904 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045F0")]
		private void SetViewIfReady()
		{
		}

		// Token: 0x060045F1 RID: 17905 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045F1")]
		protected virtual void OnDisable()
		{
		}

		// Token: 0x060045F2 RID: 17906 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045F2")]
		protected virtual void OnDestroy()
		{
		}

		// Token: 0x060045F3 RID: 17907 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045F3")]
		protected AbstractBossWindowView()
		{
		}

		// Token: 0x04002627 RID: 9767
		[Token(Token = "0x4002627")]
		[FieldOffset(Offset = "0x0")]
		protected TMediator _mediator;

		// Token: 0x04002628 RID: 9768
		[Token(Token = "0x4002628")]
		[FieldOffset(Offset = "0x0")]
		protected BossInstanceModel _model;

		// Token: 0x04002629 RID: 9769
		[Token(Token = "0x4002629")]
		[FieldOffset(Offset = "0x0")]
		protected BossInstanceEvents _events;

		// Token: 0x0400262A RID: 9770
		[Token(Token = "0x400262A")]
		[FieldOffset(Offset = "0x0")]
		protected BossInstanceController _controller;

		// Token: 0x0400262B RID: 9771
		[Token(Token = "0x400262B")]
		[FieldOffset(Offset = "0x0")]
		private bool _started;
	}
}
