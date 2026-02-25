using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Animations;
using Gameplay.ArtifactDrop;
using Gameplay.ArtifactDrop.Control;
using Gameplay.ArtifactDrop.Model;
using Il2CppDummyDll;
using UI.Rewards.Renderers;
using UnityEngine;

namespace Core.Gameplay.Managers
{
	// Token: 0x02001140 RID: 4416
	[Token(Token = "0x2001140")]
	public class ArtifactDropManager : IGameManager, IBaseManager, IAnimationProvider
	{
		// Token: 0x17001537 RID: 5431
		// (get) Token: 0x0600679A RID: 26522 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001537")]
		public string Name
		{
			[Token(Token = "0x600679A")]
			[Address(RVA = "0xB2C6", Offset = "0xB2C6", VA = "0xB2C6", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x1400025C RID: 604
		// (add) Token: 0x0600679B RID: 26523 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600679C RID: 26524 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400025C")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x600679B")]
			[Address(RVA = "0xB2C7", Offset = "0xB2C7", VA = "0xB2C7", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600679C")]
			[Address(RVA = "0xB2C8", Offset = "0xB2C8", VA = "0xB2C8", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400025D RID: 605
		// (add) Token: 0x0600679D RID: 26525 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600679E RID: 26526 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400025D")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x600679D")]
			[Address(RVA = "0xB2C9", Offset = "0xB2C9", VA = "0xB2C9", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600679E")]
			[Address(RVA = "0xB2CA", Offset = "0xB2CA", VA = "0xB2CA", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17001538 RID: 5432
		// (get) Token: 0x0600679F RID: 26527 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001538")]
		public ArtifactDropController Controller
		{
			[Token(Token = "0x600679F")]
			[Address(RVA = "0xB2CB", Offset = "0xB2CB", VA = "0xB2CB")]
			get
			{
				return null;
			}
		}

		// Token: 0x060067A0 RID: 26528 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067A0")]
		[Address(RVA = "0xB2CC", Offset = "0xB2CC", VA = "0xB2CC")]
		public void AddView(ArtifactRewardRender view)
		{
		}

		// Token: 0x060067A1 RID: 26529 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067A1")]
		[Address(RVA = "0xB2CD", Offset = "0xB2CD", VA = "0xB2CD")]
		public void RemoveView(ArtifactRewardRender view)
		{
		}

		// Token: 0x060067A2 RID: 26530 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067A2")]
		[Address(RVA = "0xB2CE", Offset = "0xB2CE", VA = "0xB2CE")]
		public void AddAnimationTarget(IAnimationTarget target)
		{
		}

		// Token: 0x060067A3 RID: 26531 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067A3")]
		[Address(RVA = "0xB2CF", Offset = "0xB2CF", VA = "0xB2CF")]
		public void RemoveAnimationTarget(IAnimationTarget target)
		{
		}

		// Token: 0x060067A4 RID: 26532 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067A4")]
		[Address(RVA = "0xB2D0", Offset = "0xB2D0", VA = "0xB2D0", Slot = "8")]
		public void Init()
		{
		}

		// Token: 0x060067A5 RID: 26533 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067A5")]
		[Address(RVA = "0xB2D1", Offset = "0xB2D1", VA = "0xB2D1", Slot = "9")]
		public void Deinit()
		{
		}

		// Token: 0x060067A6 RID: 26534 RVA: 0x00013848 File Offset: 0x00011A48
		[Token(Token = "0x60067A6")]
		[Address(RVA = "0xB2D2", Offset = "0xB2D2", VA = "0xB2D2", Slot = "11")]
		private bool TryStartAnimation(Transform target, out float duration)
		{
			return default(bool);
		}

		// Token: 0x060067A7 RID: 26535 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067A7")]
		[Address(RVA = "0xB2D3", Offset = "0xB2D3", VA = "0xB2D3")]
		public ArtifactDropManager()
		{
		}

		// Token: 0x04003749 RID: 14153
		[Token(Token = "0x4003749")]
		[FieldOffset(Offset = "0x10")]
		private ArtifactDropController _controller;

		// Token: 0x0400374A RID: 14154
		[Token(Token = "0x400374A")]
		[FieldOffset(Offset = "0x14")]
		private ArtifactDropModel _model;

		// Token: 0x0400374B RID: 14155
		[Token(Token = "0x400374B")]
		[FieldOffset(Offset = "0x18")]
		private ArtifactDropEvents _events;

		// Token: 0x0400374C RID: 14156
		[Token(Token = "0x400374C")]
		[FieldOffset(Offset = "0x1C")]
		private readonly Dictionary<ArtifactRewardRender, ArtifactDropViewMediator> _mediators;

		// Token: 0x0400374D RID: 14157
		[Token(Token = "0x400374D")]
		[FieldOffset(Offset = "0x20")]
		private readonly List<IAnimationTarget> _animationTargets;
	}
}
