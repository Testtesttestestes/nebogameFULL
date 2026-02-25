using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AssetContent.Loaders;
using Core.Data;
using Gameplay.Isles.Axis.Controller;
using Il2CppDummyDll;
using Protocol.Dic;
using UnityEngine;

namespace Gameplay.Isles.Axis.View
{
	// Token: 0x02000D03 RID: 3331
	[Token(Token = "0x2000D03")]
	public class AxisIsleView : MonoBehaviour
	{
		// Token: 0x17001077 RID: 4215
		// (get) Token: 0x06005145 RID: 20805 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001077")]
		public GameSpriteRendererLoaderInteractable BgSprite
		{
			[Token(Token = "0x6005145")]
			[Address(RVA = "0x9F24", Offset = "0x9F24", VA = "0x9F24")]
			get
			{
				return null;
			}
		}

		// Token: 0x140001EB RID: 491
		// (add) Token: 0x06005146 RID: 20806 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06005147 RID: 20807 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001EB")]
		public event Action OnClickEvent
		{
			[Token(Token = "0x6005146")]
			[Address(RVA = "0x9F25", Offset = "0x9F25", VA = "0x9F25")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6005147")]
			[Address(RVA = "0x9F26", Offset = "0x9F26", VA = "0x9F26")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140001EC RID: 492
		// (add) Token: 0x06005148 RID: 20808 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06005149 RID: 20809 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001EC")]
		public event Action<ColossusBattleData> ColossusClickedEvent
		{
			[Token(Token = "0x6005148")]
			[Address(RVA = "0x9F27", Offset = "0x9F27", VA = "0x9F27")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6005149")]
			[Address(RVA = "0x9F28", Offset = "0x9F28", VA = "0x9F28")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x0600514A RID: 20810 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600514A")]
		[Address(RVA = "0x9F29", Offset = "0x9F29", VA = "0x9F29")]
		private void Start()
		{
		}

		// Token: 0x0600514B RID: 20811 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600514B")]
		[Address(RVA = "0x9F2A", Offset = "0x9F2A", VA = "0x9F2A")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600514C RID: 20812 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600514C")]
		[Address(RVA = "0x9F2B", Offset = "0x9F2B", VA = "0x9F2B")]
		private void OnPointerClick()
		{
		}

		// Token: 0x0600514D RID: 20813 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600514D")]
		[Address(RVA = "0x9F2C", Offset = "0x9F2C", VA = "0x9F2C")]
		private void ColossusClickedEventHandler(ColossusBattleData data)
		{
		}

		// Token: 0x0600514E RID: 20814 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600514E")]
		[Address(RVA = "0x9F2D", Offset = "0x9F2D", VA = "0x9F2D")]
		public void UpdateViews(IList<ColossusBattleData> datas, IList<ColossusDic> colossus)
		{
		}

		// Token: 0x0600514F RID: 20815 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600514F")]
		[Address(RVA = "0x9F2E", Offset = "0x9F2E", VA = "0x9F2E")]
		public void Init(AxisIsle isle)
		{
		}

		// Token: 0x06005150 RID: 20816 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005150")]
		[Address(RVA = "0x9F2F", Offset = "0x9F2F", VA = "0x9F2F")]
		public void Deinit()
		{
		}

		// Token: 0x06005151 RID: 20817 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005151")]
		[Address(RVA = "0x9F30", Offset = "0x9F30", VA = "0x9F30")]
		public AxisIsleView()
		{
		}

		// Token: 0x04002C3B RID: 11323
		[Token(Token = "0x4002C3B")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private GameSpriteRendererLoaderInteractable _spriteLoader;

		// Token: 0x04002C3C RID: 11324
		[Token(Token = "0x4002C3C")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private SpriteRenderer _cloud;

		// Token: 0x04002C3D RID: 11325
		[Token(Token = "0x4002C3D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ColossusInWorldView[] _colossusViews;

		// Token: 0x04002C3E RID: 11326
		[Token(Token = "0x4002C3E")]
		[FieldOffset(Offset = "0x1C")]
		private AxisIsleViewMediator _mediator;
	}
}
